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
Public Class dlgTwoWayAnova
    Private Sub dlgTwoWayAnova_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("aov")
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverCounts.Selector = ucrAddRemove
        ucrReceiverCounts.SetMeAsReceiver()
        autoTranslate(Me)
        ucrReceiverRowFactor.Selector = ucrAddRemove
        ucrReceiverColumnFactor.Selector = ucrAddRemove
        ucrBase.OKEnabled(False)
    End Sub

    Private Sub ucrReceiverCounts_ValueChanged(sender As Object, e As EventArgs) Handles ucrReceiverCounts.ValueChanged
        FillFormula()
    End Sub

    Private Sub ucrReceiverRowFactor_ValueChanged(sender As Object, e As EventArgs) Handles ucrReceiverRowFactor.ValueChanged
        FillFormula()
    End Sub

    Private Sub ucrReceiverColumnFactor_ValueChanged(sender As Object, e As EventArgs) Handles ucrReceiverColumnFactor.ValueChanged
        FillFormula()
    End Sub

    Private Sub FillFormula()
        Dim strCounts As String = ""
        Dim strRowFactor As String = ""
        Dim strColumnFactor As String = ""

        'strCounts = ucrReceiverCounts.GetVariables()
        'strRowFactor = ucrReceiverRowFactor.GetVariables()
        'strColumnFactor = ucrReceiverColumnFactor.GetVariables()
        If ((Not (strCounts = "")) And (Not (strRowFactor = "")) And (Not (strColumnFactor = ""))) Then
            ucrBase.clsRsyntax.AddParameter("formula", strCounts & "~" & strRowFactor & "*" & strColumnFactor)
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

End Class