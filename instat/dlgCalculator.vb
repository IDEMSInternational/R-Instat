' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Imports RDotNet

Public Class dlgCalculator
    Dim strCalcHistory As List(Of String)
    Dim dataset As DataFrame
    Dim clsAttach As New RFunction
    Dim clsDetach As New RFunction
    Public bFirstLoad As Boolean = True
    Public iHelpCalcID As Integer
    Private iBasicWidth As Integer
    Private strDefaultKeyboard As String
    ' Note: This list needs to be updated when a new keyboard is added.
    Private strKeyboards() As String = {"Maths", "Logical and Symbols", "Summary", "Strings (Character Columns)", "Factor", "Probability", "Dates", "Transform", "Circular", "Wakefield", "Modifier", "Symbols", "HydroGOF"}


    Private Sub dlgCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            iBasicWidth = Me.Width
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrCalc.ucrReceiverForCalculation.IsEmpty Then
            If ucrCalc.chkSaveResultInto.Checked AndAlso ucrCalc.ucrSaveResultInto.IsEmpty Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        ucrCalc.ucrSaveResultInto.SetPrefix("Calc")
        If strDefaultKeyboard <> "" Then
            ucrCalc.ucrInputCalOptions.SetName(strDefaultKeyboard)
            strDefaultKeyboard = ""
        Else
            ucrCalc.ucrInputCalOptions.SetName("Basic")
        End If
        ucrCalc.Reset()
        ucrCalc.chkShowParameters.Checked = False
        ucrCalc.chkSaveResultInto.Checked = True
        SaveResults()
        ucrCalc.ucrSelectorForCalculations.bUseCurrentFilter = False
        ucrCalc.ucrTryCalculator.SetRSyntax(ucrBase.clsRsyntax)
        ucrBase.Visible = True
    End Sub

    Private Sub ReopenDialog()
        SaveResults()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 14
        ucrCalc.ucrReceiverForCalculation.SetMeAsReceiver()
        ucrCalc.ucrTryCalculator.SetIsCommand()
        ucrCalc.ucrTryCalculator.SetReceiver(ucrCalc.ucrReceiverForCalculation)
        clsAttach.SetRCommand("attach")
        clsDetach.SetRCommand("detach")
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrCalc.ucrSelectorForCalculations.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrCalc.ucrSelectorForCalculations.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("unload", "TRUE")
        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttach)
        ucrBase.clsRsyntax.AddToAfterCodes(clsDetach)
        ucrBase.clsRsyntax.SetCommandString("")
        ucrCalc.ucrSaveResultInto.SetItemsTypeAsColumns()
        ucrCalc.ucrSaveResultInto.SetDefaultTypeAsColumn()
        ucrCalc.ucrSaveResultInto.SetDataFrameSelector(ucrCalc.ucrSelectorForCalculations.ucrAvailableDataFrames)
        ucrCalc.ucrSelectorForCalculations.Reset()
        ucrCalc.ucrSaveResultInto.SetValidationTypeAsRVariable()
        ucrCalc.ucrTryCalculator.StrvecOutputRequired()
    End Sub

    Public Sub SetDefaultKeyboard(strNewDefaultKeyboard As String)
        If Not strKeyboards.Contains(strNewDefaultKeyboard) Then
            MsgBox("Developer error: there is no Calculator keyboard called" & Chr(34) & strNewDefaultKeyboard & Chr(34) & vbNewLine & "Default keyboard will be selected.")
            strDefaultKeyboard = ""
        Else
            strDefaultKeyboard = strNewDefaultKeyboard
        End If
    End Sub

    Private Sub ucrCalc_SaveNameChanged() Handles ucrCalc.SaveNameChanged
        SaveResults()
        TestOKEnabled()
    End Sub

    Private Sub SaveResults()
        If ucrCalc.chkSaveResultInto.Checked Then
            ucrBase.clsRsyntax.SetAssignTo(ucrCalc.ucrSaveResultInto.GetText(), strTempColumn:=ucrCalc.ucrSaveResultInto.GetText(), strTempDataframe:=ucrCalc.ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
            ucrBase.clsRsyntax.iCallType = 2
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub
    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ucrCalc.SetCalculationHistory()
    End Sub

    Private Sub ucrCalc_SelectionChanged() Handles ucrCalc.SelectionChanged
        ucrBase.clsRsyntax.SetCommandString(ucrCalc.ucrReceiverForCalculation.GetVariableNames(False))
        ucrCalc.ucrTryCalculator.ucrInputTryMessage.SetName("")
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputCalOptions_NameChanged() Handles ucrCalc.NameChanged
        CalculationsOptions()
    End Sub

    Private Sub CalculationsOptions()
        Select Case ucrCalc.ucrInputCalOptions.GetText
            Case "Maths"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.38, Me.Height)
            Case "Logical and Symbols"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.4, Me.Height)
            Case "Summary"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.43, Me.Height)
            Case "Strings (Character Columns)"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.47, Me.Height)
            Case "Factor"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.4, Me.Height)
            Case "Probability"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.5, Me.Height)
            Case "Dates"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.3, Me.Height)
            Case "Transform"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.35, Me.Height)
            Case "Circular"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.36, Me.Height)
            Case "Wakefield"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.7, Me.Height)
            Case "Modifier"
                Me.Size = New Size(iBasicWidth * 1.39, Me.Height)
            Case "Symbols"
                Me.Size = New Size(iBasicWidth * 2.56, Me.Height)
            Case "hydroGOF"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.27, Me.Height)
            Case Else
                Me.Size = New System.Drawing.Size(iBasicWidth, Me.Height)
        End Select
    End Sub

    Private Sub chkSaveResultInto_CheckedChanged() Handles ucrCalc.SaveResultsCheckedChanged
        SaveResults()
        ShowControl()
    End Sub

    Private Sub ucrSelectorForCalculations_DataframeChanged() Handles ucrCalc.DataFrameChanged
        ucrCalc.ucrTryCalculator.ucrInputTryMessage.SetName("")
        SaveResults()
    End Sub

    Private Sub ShowControl()
        If ucrCalc.chkSaveResultInto.Checked Then
            ucrCalc.ucrSaveResultInto.Visible = True
        Else
            ucrCalc.ucrSaveResultInto.Visible = False
        End If
    End Sub
End Class
