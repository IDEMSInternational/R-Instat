Imports RDotNet
Public Class dlgCalculator
    Dim dataset As DataFrame

    Private Sub dlgCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer

        dataset = frmMain.clsRInterface.GetData("data")
        For i = 0 To dataset.ColumnCount - 1
            lstAvailableVariable.Items.Add(dataset.ColumnNames(i))
        Next

        txtNewColumnName.Text = "Column_" & (dataset.ColumnCount + 1).ToString
        btnBackSpace.Enabled = True
        txtCalcLine.Select()
    End Sub

    Private Sub AddText(strVar As String, Optional intStepsBack As Integer = 0, Optional bolInsertSelected As Boolean = False)
        Dim intCurrCursorPosition As Integer
        Dim strSelectedText As String = txtCalcLine.SelectedText

        txtCalcLine.SelectedText = ""
        intCurrCursorPosition = txtCalcLine.SelectionStart
        txtCalcLine.Text = txtCalcLine.Text.Insert(txtCalcLine.SelectionStart, strVar)
        intCurrCursorPosition = intCurrCursorPosition + strVar.Length - intStepsBack
        If bolInsertSelected Then
            txtCalcLine.Text = txtCalcLine.Text.Insert(intCurrCursorPosition, strSelectedText)
            intCurrCursorPosition = intCurrCursorPosition + strSelectedText.Length + 1
        End If
        txtCalcLine.SelectionStart = intCurrCursorPosition
        txtCalcLine.Select()
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        AddText("0")
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        AddText("1")
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        AddText("2")
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        AddText("3")
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        AddText("4")
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        AddText("5")
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        AddText("6")
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        AddText("7")
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        AddText("8")
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        AddText("9")
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        AddText(".")
    End Sub

    Private Sub btnPi_Click(sender As Object, e As EventArgs) Handles btnPi.Click
        AddText("pi")
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        AddText("+")
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        AddText("-")
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        AddText("*")
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        AddText("/")
    End Sub

    Private Sub lstAvailableVariable_DoubleClick(sender As Object, e As EventArgs) Handles lstAvailableVariable.DoubleClick
        If lstAvailableVariable.SelectedItem <> "" Then
            AddText("data[[""" & lstAvailableVariable.SelectedItem & """]]")
        End If
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        AddText("^")
    End Sub

    Private Sub btnOpenBracket_Click(sender As Object, e As EventArgs) Handles btnOpenBracket.Click
        AddText("(")
    End Sub

    Private Sub btnCloseBracket_Click(sender As Object, e As EventArgs) Handles btnCloseBracket.Click
        Dim intCursorPosition As Integer

        intCursorPosition = txtCalcLine.SelectionStart
        txtCalcLine.Text = txtCalcLine.Text.Insert(txtCalcLine.SelectionStart, ")")
        txtCalcLine.SelectionStart = intCursorPosition + 1
        txtCalcLine.Focus()
    End Sub

    Private Sub btnRowNumbers_Click(sender As Object, e As EventArgs) Handles btnRowNumbers.Click
        AddText("(1:nrow(data))")
    End Sub

    Private Sub UcrButtons1_clickOK(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strScript As String
        strScript = ("data[[" & Chr(34) & txtNewColumnName.Text & Chr(34) & "]]" & " <- " & txtCalcLine.Text).ToString
        frmMain.clsRInterface.RunScript(strScript)
        dataset = frmMain.clsRInterface.GetData("data")
        frmEditor.UpdateSheet(dataset)
    End Sub

    Private Sub btnBackSpace_Click(sender As Object, e As EventArgs) Handles btnBackSpace.Click
        If txtCalcLine.Text.Length > 0 Then
            txtCalcLine.Text = txtCalcLine.Text.Remove(txtCalcLine.Text.Length - 1)
        End If
    End Sub

    Private Sub txtCalcLine_TextChanged(sender As Object, e As EventArgs) Handles txtCalcLine.TextChanged
        If txtCalcLine.Text.Length = 0 Then
            btnBackSpace.Enabled = False
        Else
            btnBackSpace.Enabled = True
        End If
    End Sub

    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        AddText("sqrt()", 1, True)
    End Sub

    Private Sub btnLog10_Click(sender As Object, e As EventArgs) Handles btnLog10.Click
        AddText("log10()", 1, True)
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        AddText("exp()", 1, True)
    End Sub
End Class