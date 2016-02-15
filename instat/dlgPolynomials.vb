'Instat-R
'Copyright (C) 2015
'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'You should have received a copy of the GNU General Public License k
'along with this program.  If not, see <http://www.gnu.org/licenses/>.
'
Imports instat.Translations

Public Class dlgPolynomials
    Public clsCentredOptionFunc As New RFunction
    Dim dataf
    Private Sub dlgPolynomials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("poly")
        ucrReceiverPolynomial.Selector = ucrSelectorDataFrameAddRemove
        ucrReceiverPolynomial.SetMeAsReceiver()
        nudDegree.Text = "1"
        ucrBase.clsRsyntax.AddParameter("degree", nudDegree.Text)

        ucrNewColumnNameSelector.SetDataFrameSelector(ucrSelectorDataFrameAddRemove.ucrAvailableDataFrames)
        ucrNewColumnNameSelector.SetPrefix("Polynomial")
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnNameSelector.cboColumnName.Text, strTempDataframe:=ucrSelectorDataFrameAddRemove.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnNameSelector.cboColumnName.Text)

        clsCentredOptionFunc.SetRCommand("scale")
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverPolynomial.GetVariables(), clsRFunction:=clsCentredOptionFunc)
        ucrBase.clsRsyntax.AddParameter("raw", "TRUE", clsRFunction:=clsCentredOptionFunc)
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=clsCentredOptionFunc)

    End Sub



    Private Sub ucrReceiverPolynomial_Leave(sender As Object, e As EventArgs) Handles ucrReceiverPolynomial.Leave
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverPolynomial.GetVariables())
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverPolynomial.GetVariables(), clsRFunction:=clsCentredOptionFunc)
    End Sub

    Private Sub grpType_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSimple.CheckedChanged, rdoCentered.CheckedChanged, rdoOrthogonal.CheckedChanged
        If rdoSimple.Checked Then
            ucrBase.clsRsyntax.AddParameter("raw", "TRUE")
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverPolynomial.GetVariables())
        ElseIf rdoOrthogonal.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("raw", "FALSE")
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverPolynomial.GetVariables())
        Else
            ucrBase.clsRsyntax.RemoveParameter("raw")
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverPolynomial.GetVariables(), clsRFunction:=clsCentredOptionFunc)
        End If

    End Sub

    Private Sub nudDegree_Leave(sender As Object, e As EventArgs) Handles nudDegree.Leave
        ucrBase.clsRsyntax.AddParameter("degree", nudDegree.Text)
    End Sub
End Class