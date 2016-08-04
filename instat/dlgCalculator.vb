Imports RDotNet
Public Class dlgCalculator
    Dim dataset As DataFrame
    Dim clsAttach As New RFunction
    Dim clsDetach As New RFunction

    Private Sub dlgCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.OKEnabled(False)
        cmdBackSpace.Enabled = True
        'txtCalcLine.Select()
        ucrBase.iHelpTopicID = 14
        InitialiseDialog()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverForCalculation.Selector = ucrSelectorForCalculations
        ucrReceiverForCalculation.SetMeAsReceiver()
        clsAttach.SetRCommand("attach")
        clsDetach.SetRCommand("detach")
        clsDetach.AddParameter("unload", "TRUE")
        ucrBase.clsRsyntax.SetCommandString("")
    End Sub

    Private Sub AddText(strVar As String, Optional intStepsBack As Integer = 0, Optional bolInsertSelected As Boolean = False)
        Dim intCurrCursorPosition As Integer
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
    End Sub

    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd1.Click
        AddText("1")
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("1")
    End Sub

    Private Sub cmd2_Click(sender As Object, e As EventArgs) Handles cmd2.Click
        AddText("2")
    End Sub

    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmd3.Click
        AddText("3")
    End Sub

    Private Sub cmd4_Click(sender As Object, e As EventArgs) Handles cmd4.Click
        AddText("4")
    End Sub

    Private Sub cmd5_Click(sender As Object, e As EventArgs) Handles cmd5.Click
        AddText("5")
    End Sub

    Private Sub cmd6_Click(sender As Object, e As EventArgs) Handles cmd6.Click
        AddText("6")
    End Sub

    Private Sub cmd7_Click(sender As Object, e As EventArgs) Handles cmd7.Click
        AddText("7")
    End Sub

    Private Sub cmd8_Click(sender As Object, e As EventArgs) Handles cmd8.Click
        AddText("8")
    End Sub

    Private Sub cmd9_Click(sender As Object, e As EventArgs) Handles cmd9.Click
        AddText("9")
    End Sub

    Private Sub cmdDot_Click(sender As Object, e As EventArgs) Handles cmdDot.Click
        AddText(".")
    End Sub

    Private Sub cmdPi_Click(sender As Object, e As EventArgs)
        AddText("pi")
    End Sub

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        AddText("+")
    End Sub

    Private Sub cmdMinus_Click(sender As Object, e As EventArgs) Handles cmdMinus.Click
        AddText("-")
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        AddText("*")
    End Sub

    Private Sub cmdDivide_Click(sender As Object, e As EventArgs) Handles cmdDivide.Click
        AddText("/")
    End Sub

    Private Sub lstAvailableVariable_DoubleClick(sender As Object, e As EventArgs)
        'If lstAvailableVariable.SelectedItem <> "" Then
        '    AddText("data[[""" & lstAvailableVariable.SelectedItem & """]]")
        'End If
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        AddText("^")
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

    Private Sub cmdRowNumbers_Click(sender As Object, e As EventArgs)
        AddText("(1:nrow(data))")
    End Sub

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
End Class