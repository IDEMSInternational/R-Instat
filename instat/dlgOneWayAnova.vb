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
Public Class dlgOneWayANOVA
    Private Sub dlgOneWayAnova_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("aov")
        ucrYVariate.Selector = ucrAddRemove
        ucrYVariate.SetMeAsReceiver()
        ucrFactor.Selector = ucrAddRemove
        ucrFactor.SetDataType("factor")
        autoTranslate(Me)
        ucrBase.OKEnabled(False)

    End Sub


    Private Sub ucrYVariate_ValueChanged(sender As Object, e As EventArgs) Handles ucrYVariate.ValueChanged
        Fillformula()
    End Sub

    Private Sub ucrFactor_ValueChanged(sender As Object, e As EventArgs) Handles ucrFactor.ValueChanged
        Fillformula()
    End Sub
    Private Sub Fillformula()
        Dim strFactor As String = ""
        Dim strYVariate As String = ""
        strYVariate = ucrYVariate.GetVariableNames()
        strFactor = ucrFactor.GetVariableNames()



        If ((Not (strYVariate = "")) And (Not (strFactor = ""))) Then

            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub


End Class