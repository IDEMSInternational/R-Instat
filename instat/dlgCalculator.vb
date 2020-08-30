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
    Dim clsAttach As New RFunction
    Dim clsDetach As New RFunction
    Public bFirstLoad As Boolean = True
    Public iHelpCalcID As Integer
    Private iBasicWidth As Integer
    Private iBaseY As Integer

    Private Sub dlgCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            iBasicWidth = Me.Width
            iBaseY = ucrBase.Location.Y
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
        ucrCalc.ucrSaveResultInto.SetPrefix("Calc")
        ucrCalc.ucrSaveResultInto.SetSaveTypeAsColumn()
        ucrCalc.ucrSaveResultInto.SetIsTextBox()
        ucrCalc.ucrSaveResultInto.SetLabelText("Save Result Into:")
        ucrCalc.ucrSaveResultInto.SetDataFrameSelector(ucrCalc.ucrSelectorForCalculations.ucrAvailableDataFrames)
        ucrCalc.ucrTryCalculator.StrvecOutputRequired()
    End Sub

    Private Sub ucrCalc_SaveNameChanged() Handles ucrCalc.SaveNameChanged
        SaveResults()
        TestOKEnabled()
    End Sub

    Private Sub SaveResults()
        If ucrCalc.ucrSaveResultInto.IsComplete Then
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
                ucrBase.Location = New Point(ucrBase.Location.X, iBaseY)
            Case "Logical and Symbols"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.4, Me.Height)
                ucrBase.Location = New Point(ucrBase.Location.X, iBaseY)
            Case "Summary"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.43, Me.Height)
                ucrBase.Location = New Point(ucrBase.Location.X, iBaseY)
            Case "Strings (Character Columns)"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.47, Me.Height)
                ucrBase.Location = New Point(ucrBase.Location.X, iBaseY)
            Case "Factor"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.4, Me.Height)
                ucrBase.Location = New Point(ucrBase.Location.X, iBaseY)
            Case "Probability"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.5, Me.Height)
                ucrBase.Location = New Point(ucrBase.Location.X, iBaseY)
            Case "Dates"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.3, Me.Height)
                ucrBase.Location = New Point(ucrBase.Location.X, iBaseY)
            Case "Transform"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.35, Me.Height)
                ucrBase.Location = New Point(ucrBase.Location.X, iBaseY)
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.35, Me.Height)
            Case "Circular"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.36, Me.Height)
                ucrBase.Location = New Point(ucrBase.Location.X, iBaseY)
            Case "Wakefield"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.7, Me.Height)
                ucrBase.Location = New Point(ucrBase.Location.X, iBaseY + 50)
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.7, Me.Height + 10)
            Case "Modifier"
                Me.Size = New Size(iBasicWidth * 1.39, Me.Height)
                ucrBase.Location = New Point(ucrBase.Location.X, iBaseY)
            Case "Symbols"
                Me.Size = New Size(iBasicWidth * 2.56, Me.Height)
                ucrBase.Location = New Point(ucrBase.Location.X, iBaseY)
            Case "hydroGOF"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.27, Me.Height)
                ucrBase.Location = New Point(ucrBase.Location.X, iBaseY)
            Case Else
                Me.Size = New System.Drawing.Size(iBasicWidth, Me.Height)
                ucrBase.Location = New Point(ucrBase.Location.X, iBaseY)
        End Select
    End Sub

    Private Sub ucrSelectorForCalculations_DataframeChanged() Handles ucrCalc.DataFrameChanged
        ucrCalc.ucrTryCalculator.ucrInputTryMessage.SetName("")
        SaveResults()
    End Sub
End Class