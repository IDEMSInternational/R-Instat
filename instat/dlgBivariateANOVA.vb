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
Public Class dlgBivariateANOVA
    Private Sub dlgBivariateANOVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("manova")
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiver1stResponseVariable.Selector = ucrAddRemove
        ucrReceiver1stResponseVariable.SetMeAsReceiver()
        autoTranslate(Me)
        ucrReceiver2ndResponseVariable.Selector = ucrAddRemove
        ucrReceiverTreatmentFactor.Selector = ucrAddRemove
        ucrReceiverBlockingFactor.Selector = ucrAddRemove
        ucrBase.OKEnabled(False)
    End Sub

    Private Sub ucrReceiver1stResponseVariable_ValueChanged(sender As Object, e As EventArgs) Handles ucrReceiver1stResponseVariable.ValueChanged
        FillFormula()

    End Sub

    Private Sub ucrReceiver2ndResponseVariable_ValueChanged(sender As Object, e As EventArgs) Handles ucrReceiver2ndResponseVariable.ValueChanged
        FillFormula()
    End Sub

    Private Sub ucrReceiverTreatmentFactor_ValueChanged(sender As Object, e As EventArgs) Handles ucrReceiverTreatmentFactor.ValueChanged
        FillFormula()

    End Sub

    Private Sub ucrReceiverBlockingFactor_ValueChanged(sender As Object, e As EventArgs) Handles ucrReceiverBlockingFactor.ValueChanged
        FillFormula()
    End Sub
    Private Sub FillFormula()
        Dim str1stResponseVariable As String = ""
        Dim str2ndResponseVariable As String = ""
        Dim strTreatmentFactor As String = ""
        Dim strBlockingFactor As String = ""
        'str1stResponseVariable = ucrReceiver1stResponseVariable.GetVariables()
        'str2ndResponseVariable = ucrReceiver2ndResponseVariable.GetVariables()
        'strTreatmentFactor = ucrReceiverBlockingFactor.GetVariables()
        'strBlockingFactor = ucrReceiverBlockingFactor.GetVariables()
        If ((Not (str1stResponseVariable = "")) And (Not (str2ndResponseVariable = "")) And (Not (strTreatmentFactor = "")) And (Not (strBlockingFactor = ""))) Then
            'ucrBase.clsRsyntax.AddParameter("formula", cbind(str1stResponseVariable, str2ndResponseVariable) & "~" & strTreatmentFactor & "*" & strBlockingFactor) #researching on the cbind
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)



        End If
    End Sub
End Class