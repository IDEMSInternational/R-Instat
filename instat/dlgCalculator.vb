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

Public Class dlgCalculator
    Dim clsAttach As New RFunction
    Dim clsDetach As New RFunction
    Public bFirstLoad As Boolean = True
    Public iHelpCalcID As Integer

    'holds the original width of the form
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
        ucrBase.OKEnabled(Not ucrCalc.ucrReceiverForCalculation.IsEmpty AndAlso ucrCalc.ucrSaveResultInto.IsComplete)
    End Sub

    Private Sub SetDefaults()

        ucrCalc.ucrInputCalOptions.SetName("Basic")

        ucrCalc.Reset()
        ucrCalc.ucrSelectorForCalculations.Reset()
        ucrCalc.ucrSaveResultInto.Reset()
        ucrCalc.ucrSaveResultInto.ucrChkSave.Checked = True
        ucrCalc.chkShowParameters.Checked = False
        ucrCalc.ucrSaveResultInto.SetRCode(ucrBase.clsRsyntax.clsBaseCommandString)
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

        ucrCalc.ucrSaveResultInto.SetPrefix("calc")
        ucrCalc.ucrSaveResultInto.SetSaveTypeAsColumn()
        ucrCalc.ucrSaveResultInto.SetIsComboBox()
        ucrCalc.ucrSaveResultInto.SetCheckBoxText("Save Result ")

        ucrCalc.ucrSaveResultInto.SetDataFrameSelector(ucrCalc.ucrSelectorForCalculations.ucrAvailableDataFrames)
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

    ''' <summary>
    ''' Determines where the results will be saved; to a column or output window
    ''' </summary>
    Private Sub SaveResults()
        If ucrCalc.ucrSaveResultInto.ucrChkSave.Checked AndAlso ucrCalc.ucrSaveResultInto.IsComplete Then
            ucrBase.clsRsyntax.SetAssignTo(ucrCalc.ucrSaveResultInto.GetText(), strTempColumn:=ucrCalc.ucrSaveResultInto.GetText(), strTempDataframe:=ucrCalc.ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToIsPrefix:=ucrBase.clsRsyntax.clsBaseCommandString.bAssignToIsPrefix, bAssignToColumnWithoutNames:=ucrBase.clsRsyntax.clsBaseCommandString.bAssignToColumnWithoutNames, bInsertColumnBefore:=ucrBase.clsRsyntax.clsBaseCommandString.bInsertColumnBefore, bRequireCorrectLength:=ucrBase.clsRsyntax.clsBaseCommandString.bRequireCorrectLength)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
            ucrBase.clsRsyntax.iCallType = 1
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
        Select Case ucrCalc.ucrInputCalOptions.GetText
            Case "Maths"
                Me.Width = iBasicWidth * 1.38
            Case "Logical and Symbols"
                Me.Width = iBasicWidth * 1.4
            Case "Summary"
                Me.Width = iBasicWidth * 1.46
            Case "Strings (Character Columns)"
                Me.Width = iBasicWidth * 1.49
            Case "Factor"
                Me.Width = iBasicWidth * 1.4
            Case "Probability"
                Me.Width = iBasicWidth * 1.5
            Case "Dates"
                Me.Width = iBasicWidth * 1.3
            Case "Transform"
                Me.Width = iBasicWidth * 1.37
            Case "Circular"
                Me.Width = iBasicWidth * 1.36
            Case "Wakefield"
                Me.Width = iBasicWidth * 1.73
            Case "Modifier"
                Me.Width = iBasicWidth * 1.39
            Case "Symbols"
                Me.Width = iBasicWidth * 2.56
            Case "hydroGOF"
                Me.Width = iBasicWidth * 1.27
            Case Else
                Me.Width = iBasicWidth
        End Select
    End Sub

    Private Sub ucrSelectorForCalculations_DataframeChanged() Handles ucrCalc.DataFrameChanged
        ucrCalc.ucrTryCalculator.ucrInputTryMessage.SetName("")
        SaveResults()
    End Sub
End Class

    
