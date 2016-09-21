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
Public Class dlgEnter
    Dim dataset As DataFrame
    Dim clsAttach As New RFunction
        Dim clsDetach As New RFunction
        Public bFirstLoad As Boolean = True
        Private Sub dlgEnter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub InitialiseDialog()

    End Sub
    Private Sub SetDefaults()
        chkShowEnterArguments.Checked = True
        ucrDataFrameEnter.Reset()
    End Sub
    Private Sub ReopenDialog()
    End Sub
    Private Sub TestOKEnabled()
        If Not ucrReceiverForEnterCalculation.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub
    Private Sub cmd0_Click(sender As Object, e As EventArgs) Handles cmd0.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("0")
        TestOKEnabled()
    End Sub
    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd1.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("1")
        TestOKEnabled()
    End Sub

    Private Sub md2_Click(sender As Object, e As EventArgs) Handles cmd2.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("2")
        TestOKEnabled()
    End Sub

    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmd3.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("3")
        TestOKEnabled()
    End Sub

    Private Sub cmd4_Click(sender As Object, e As EventArgs) Handles cmd4.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("4")
        TestOKEnabled()
    End Sub

    Private Sub cmd5_Click(sender As Object, e As EventArgs) Handles cmd5.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("5")
        TestOKEnabled()
    End Sub

    Private Sub cmd6_Click(sender As Object, e As EventArgs) Handles cmd6.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("6")
        TestOKEnabled()
    End Sub

    Private Sub cmd7_Click(sender As Object, e As EventArgs) Handles cmd7.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("7")
        TestOKEnabled()
    End Sub

    Private Sub cmd8_Click(sender As Object, e As EventArgs) Handles cmd8.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("8")
        TestOKEnabled()
    End Sub

    Private Sub cmd9_Click(sender As Object, e As EventArgs) Handles cmd9.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("9")
        TestOKEnabled()
    End Sub

    Private Sub cmdColon_Click(sender As Object, e As EventArgs) Handles cmdColon.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition(":")
        TestOKEnabled()
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("*")
        TestOKEnabled()
    End Sub

    Private Sub cmdMissingValues_Click(sender As Object, e As EventArgs) Handles cmdMissingValues.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("NA")
        TestOKEnabled()
    End Sub

    Private Sub cmdExponential_Click(sender As Object, e As EventArgs) Handles cmdExponential.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("e")
        TestOKEnabled()
    End Sub
    Private Sub cmdDot_Click(sender As Object, e As EventArgs) Handles cmdDot.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition(".")
        TestOKEnabled()
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("^")
        TestOKEnabled()
    End Sub

    Private Sub cmdBrackets_Click(sender As Object, e As EventArgs) Handles cmdBrackets.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("( )", 2)
        TestOKEnabled()
    End Sub
    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverForEnterCalculation.Clear()
        TestOKEnabled()
    End Sub

    Private Sub cmdSquareBrackets_Click(sender As Object, e As EventArgs) Handles cmdSquareBrackets.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("[ ]", 2)
        TestOKEnabled()
    End Sub

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("+")
        TestOKEnabled()
    End Sub

    Private Sub cmdMinus_Click(sender As Object, e As EventArgs) Handles cmdMinus.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("-")
        TestOKEnabled()
    End Sub

    Private Sub cmdComma_Click(sender As Object, e As EventArgs) Handles cmdComma.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition(",")
        TestOKEnabled()
    End Sub
    Private Sub cmdDelete_Click_1(sender As Object, e As EventArgs) Handles cmdDelete.Click
        ucrReceiverForEnterCalculation.Backspace()
        TestOKEnabled()
    End Sub

    Private Sub cmdDivide_Click(sender As Object, e As EventArgs) Handles cmdDivide.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("/")
        TestOKEnabled()

    End Sub

    Private Sub cmdConcantenateFunction_Click(sender As Object, e As EventArgs) Handles cmdConcantenateFunction.Click
        If chkShowEnterArguments.Checked Then
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("c( ,recursive=FALSE)", 17)
        Else
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("c( )", 2)
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdRepelicationFunction_Click(sender As Object, e As EventArgs) Handles cmdRepelicationFunction.Click
        If chkShowEnterArguments.Checked Then
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("rep(x= ,times= ,length= ,each= )", 17)
        Else ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("rep( )", 2)
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdSequenceFunction_Click(sender As Object, e As EventArgs) Handles cmdSequenceFunction.Click
        If chkShowEnterArguments.Checked Then
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("seq(from= ,to= ,by= )", 11)
        Else ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("seq( )", 2)
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdSequence2_Click(sender As Object, e As EventArgs) Handles cmdSequence2.Click
        Dim length As Integer = ucrDataFrameEnter.iDataFrameLength
        If chkShowEnterArguments.Checked Then
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("seq(from= ,to= ,length= )", 15)
        Else ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("seq( )", 2)
        End If
        TestOKEnabled()
    End Sub
End Class