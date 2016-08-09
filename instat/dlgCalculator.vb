
' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations
Imports RDotNet
Public Class dlgCalculator
    Dim dataset As DataFrame
    Dim clsAttach As New RFunction
    Dim clsDetach As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub dlgCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.iHelpTopicID = 14
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverForCalculation.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        ucrSaveResultInto.SetPrefix("Cal")
        ucrSaveResultInto.Reset()
        ucrInputCalOptions.Reset()
        Me.Size = New System.Drawing.Size(436, 402)
        ucrInputCalOptions.cboInput.Text = "Basic"
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverForCalculation.Selector = ucrSelectorForCalculations
        ucrReceiverForCalculation.SetMeAsReceiver()
        clsAttach.SetRCommand("attach")
        clsDetach.SetRCommand("detach")
        clsDetach.AddParameter("unload", "TRUE")
        ucrBase.clsRsyntax.SetCommandString("")
        ucrSaveResultInto.SetItemsTypeAsColumns()
        ucrSaveResultInto.SetDefaultTypeAsColumn()
        ucrSaveResultInto.SetDataFrameSelector(ucrSelectorForCalculations.ucrAvailableDataFrames)
        ucrSelectorForCalculations.Reset()
        ucrInputCalOptions.cboInput.Items.Add("Basic")
        ucrInputCalOptions.cboInput.Items.Add("Maths")
        ucrInputCalOptions.cboInput.Items.Add("Logical")
    End Sub

    'Private Sub ucrSaveResultIntoInto_NameChanged() Handles ucrSaveResultInto.NameChanged
    '    ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrSaveResultInto.GetText, strTempDataframe:=ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveResultInto.GetText, bAssignToIsPrefix:=True)
    'End Sub

    Private Sub AddText(strVar As String, Optional intStepsBack As Integer = 0, Optional bolInsertSelected As Boolean = False)
        'Dim intCurrCursorPosition As Integer
        'Dim strSelectedText As String = txtCalcLine.SelectedText

        'txtCalcLine.SelectedText = ""
        'intCurrCursorPosition = txtCalcLine.SelectionStart
        'txtCalcLine.Text = txtCalcLine.Text.Insert(txtCalcLine.SelectionStart, strVar)
        'intCurrCursorPosition = intCurrCursorPosition + strVar.Length - intStepsBack
        'If bolInsertSelected Then
        '    txtCalcLine.Text = txtCalcLine.Text.Insert(intCurrCursorPosition, strSelectedText)
        '    intCurrCursorPosition = intCurrCursorPosition + strSelectedText.Length + 1
        'End If
        'txtCalcLine.SelectionStart = intCurrCursorPosition
        'txtCalcLine.Select()
    End Sub

    Private Sub cmd0_Click(sender As Object, e As EventArgs) Handles cmd0.Click
        AddText("0")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("0")
    End Sub

    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd1.Click
        AddText("1")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("1")
    End Sub

    Private Sub cmd2_Click(sender As Object, e As EventArgs) Handles cmd2.Click
        AddText("2")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("2")
    End Sub

    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmd3.Click
        AddText("3")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("3")
    End Sub

    Private Sub cmd4_Click(sender As Object, e As EventArgs) Handles cmd4.Click
        AddText("4")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("4")
    End Sub

    Private Sub cmd5_Click(sender As Object, e As EventArgs) Handles cmd5.Click
        AddText("5")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("5")
    End Sub

    Private Sub cmd6_Click(sender As Object, e As EventArgs) Handles cmd6.Click
        AddText("6")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("6")
    End Sub

    Private Sub cmd7_Click(sender As Object, e As EventArgs) Handles cmd7.Click
        AddText("7")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("7")
    End Sub

    Private Sub cmd8_Click(sender As Object, e As EventArgs) Handles cmd8.Click
        AddText("8")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("8")
    End Sub

    Private Sub cmd9_Click(sender As Object, e As EventArgs) Handles cmd9.Click
        AddText("9")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("9")
    End Sub

    Private Sub cmdDot_Click(sender As Object, e As EventArgs) Handles cmdDot.Click
        AddText(".")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(".")
    End Sub

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        AddText("+")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdMinus_Click(sender As Object, e As EventArgs) Handles cmdMinus.Click
        AddText("-")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("-")
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        AddText("*")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("*")
    End Sub

    Private Sub cmdDivide_Click(sender As Object, e As EventArgs) Handles cmdDivide.Click
        AddText("/")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("/")
    End Sub

    Private Sub lstAvailableVariable_DoubleClick(sender As Object, e As EventArgs)
        'If lstAvailableVariable.SelectedItem <> "" Then
        '    AddText("data[[""" & lstAvailableVariable.SelectedItem & """]]")
        'End If
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        AddText("^")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("^")
    End Sub

    'Private Sub cmdOpenBracket_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
    '    AddText("(")
    'End Sub

    'Private Sub cmdCloseBracket_Click(sender As Object, e As EventArgs)
    '    Dim intCursorPosition As Integer

    '    intCursorPosition = txtCalcLine.SelectionStart
    '    txtCalcLine.Text = txtCalcLine.Text.Insert(txtCalcLine.SelectionStart, ")")
    '    txtCalcLine.SelectionStart = intCursorPosition + 1
    '    txtCalcLine.Focus()
    'End Sub

    'Private Sub cmdRowNumbers_Click(sender As Object, e As EventArgs)
    '    AddText("(1:nrow(data))")
    'End Sub

    'Private Sub ucrBase_clickOK(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
    '    Dim strScript As String
    '    strScript = ("data[[" & Chr(34) & txtNewColumnName.Text & Chr(34) & "]]" & " <- " & txtCalcLine.Text).ToString
    '    frmMain.clsRLink.RunScript(strScript)
    '    'dataset = frmMain.clsRLink.GetData("data")
    '    'frmEditor.UpdateSheet(dataset)
    'End Sub

    'Private Sub cmdBackSpace_Click(sender As Object, e As EventArgs) Handles cmdBackSpace.Click
    '    If txtCalcLine.Text.Length > 0 Then
    '        txtCalcLine.Text = txtCalcLine.Text.Remove(txtCalcLine.Text.Length - 1)
    '    End If
    'End Sub

    'Private Sub txtCalcLine_TextChanged(sender As Object, e As EventArgs)
    '    If txtCalcLine.Text.Length = 0 Then
    '        cmdBackSpace.Enabled = False
    '    Else
    '        cmdBackSpace.Enabled = True
    '    End If
    'End Sub

    Private Sub cmdSqrt_Click(sender As Object, e As EventArgs)
        AddText("sqrt()", 1, True)
    End Sub

    Private Sub cmdLog10_Click(sender As Object, e As EventArgs)
        AddText("log10()", 1, True)
    End Sub

    Private Sub cmdExp_Click(sender As Object, e As EventArgs)
        AddText("exp()", 1, True)
    End Sub

    Private Sub ucrSaveResultInto_NameChanged() Handles ucrSaveResultInto.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(ucrSaveResultInto.GetText(), strTempColumn:=ucrSaveResultInto.GetText(), strTempDataframe:=ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        Dim strScript As String = ""
        Dim strFunc As String
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrSelectorForCalculations.ucrAvailableDataFrames.clsCurrDataFrame)
        strFunc = clsAttach.ToScript(strScript)
        frmMain.clsRLink.RunScript(strScript & strFunc)
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strScript As String = ""
        Dim strFunc As String
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrSelectorForCalculations.ucrAvailableDataFrames.clsCurrDataFrame)
        strFunc = clsDetach.ToScript(strScript)
        frmMain.clsRLink.RunScript(strScript & strFunc)
    End Sub

    Private Sub ucrReceiverForCalculation_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForCalculation.SelectionChanged
        ucrBase.clsRsyntax.SetCommandString(ucrReceiverForCalculation.GetVariableNames(False))
        ucrBase.OKEnabled(True)
    End Sub

    Private Sub cmdGreaterThan_Click(sender As Object, e As EventArgs) Handles cmdGreaterThan.Click
        AddText(">")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(">")
    End Sub

    Private Sub cmdLessThan_Click(sender As Object, e As EventArgs) Handles cmdLessThan.Click
        AddText("<")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("<")
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

    End Sub


    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputCalOptions_NameChanged() Handles ucrInputCalOptions.NameChanged
        Select Case ucrInputCalOptions.GetText
            Case "Maths"
                grpMaths.Visible = True
                grpLogical.Visible = False
                grpBasic.Visible = True
                Me.Size = New System.Drawing.Size(601, 402)
            Case "Logical"
                grpLogical.Visible = True
                grpMaths.Visible = False
                grpBasic.Visible = True
                Me.Size = New System.Drawing.Size(500, 402)
            Case Else
                Me.Size = New System.Drawing.Size(436, 402)
                grpBasic.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
        End Select
    End Sub


End Class