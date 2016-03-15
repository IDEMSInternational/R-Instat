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
    Public bFirstLoad As Boolean = True
    Public clsCentredOptionFunc As New RFunction
    Dim dataf
    Private Sub dlgPolynomials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrInputPolynomial.SetPrefix("Polynomial")
        ucrInputPolynomial.SetItemsTypeAsColumns()
        ucrInputPolynomial.SetDefaultTypeAsColumn()
        ucrInputPolynomial.SetDataFrameSelector(ucrSelectorForPolynomial.ucrAvailableDataFrames)


        If bFirstLoad Then
            InitializeDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub
    Private Sub TestOKEnabled()
        If ucrReceiverPolynomial.IsEmpty() = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub
    Private Sub SetDefaults()

        rdoSimple.Checked = True
        clsCentredOptionFunc.SetRCommand("scale")
        ucrBase.clsRsyntax.AddParameter("raw", "TRUE")
        ucrBase.clsRsyntax.AddParameter("degree", nudDegree.Value)
        ucrSelectorForPolynomial.Reset()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub InitializeDialog()

        ucrReceiverPolynomial.Selector = ucrSelectorForPolynomial
        ucrReceiverPolynomial.SetMeAsReceiver()
        ucrReceiverPolynomial.SetDataType("numeric")
        ucrBase.clsRsyntax.SetFunction("poly")
    End Sub




    Private Sub ucrReceiverPolynomial_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverPolynomial.SelectionChanged
        If Not ucrReceiverPolynomial.IsEmpty Then

            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverPolynomial.GetVariables())
            clsCentredOptionFunc.AddParameter("x", clsRFunctionParameter:=ucrReceiverPolynomial.GetVariables())
        Else
            ucrBase.clsRsyntax.RemoveParameter("x")
        End If
        TestOKEnabled()

    End Sub

    Private Sub grpType_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSimple.CheckedChanged, rdoCentered.CheckedChanged, rdoOrthogonal.CheckedChanged
        If rdoSimple.Checked Then
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverPolynomial.GetVariables())
            ucrBase.clsRsyntax.AddParameter("raw", "TRUE")


        ElseIf rdoOrthogonal.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("raw", "FALSE")
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverPolynomial.GetVariables())

        ElseIf rdoCentered.Checked = True Then
            clsCentredOptionFunc.AddParameter("x", clsRFunctionParameter:=ucrReceiverPolynomial.GetVariables())
            clsCentredOptionFunc.AddParameter("center", "True")
            clsCentredOptionFunc.AddParameter("scale", "FALSE")
            ucrBase.clsRsyntax.AddParameter("raw", "TRUE")
        Else

            ucrBase.clsRsyntax.RemoveParameter("raw")


        End If

    End Sub

    Private Sub nudDegree_ValueChanged(sender As Object, e As EventArgs) Handles nudDegree.ValueChanged
        ucrBase.clsRsyntax.AddParameter("degree", nudDegree.Value)
    End Sub

    Private Sub ucrInputPolynomial_NameChanged() Handles ucrInputPolynomial.NameChanged

        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputPolynomial.GetText, strTempDataframe:=ucrSelectorForPolynomial.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputPolynomial.GetText)
    End Sub


End Class