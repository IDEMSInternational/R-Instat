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
Public Class dlgBoxplot
    Private Sub dlgBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("boxplot")
        ucrBase.clsRsyntax.iCallType = 0
        ucrReceiverDataToPlot.Selector = ucrAddRemove
        ucrReceiverDataToPlot.SetMeAsReceiver()
        autoTranslate(Me)
        ucrBase.OKEnabled(False)
    End Sub

    Private Sub ucrReceiveBoxplotVariable_Enter(sender As Object, e As EventArgs)
        ucrReceiverDataToPlot.SetMeAsReceiver()
    End Sub


    Private Sub ucrReceiveBoxplotVariable_ValueChanged(sender As Object, e As EventArgs)
        If Not (ucrReceiverDataToPlot.lstSelectedVariables.SelectedItem = "") Then
            ucrBase.clsRsyntax.AddParameter("x", ucrReceiverDataToPlot.GetVariables())
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
End Class