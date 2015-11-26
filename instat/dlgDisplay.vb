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
Public Class dlgDisplayData


    Private Sub dlgDisplayData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("view")
        ucrBase.clsRsyntax.iCallType = 1
        ucrReceiverDisplay.Selector = ucrAddRemove
        ucrReceiverDisplay.SetMeAsReceiver()
        autoTranslate(Me)
    End Sub
    Private Sub ucrReceiverDisplay_Enter(sender As Object, e As EventArgs) Handles ucrReceiverDisplay.Enter
        ucrReceiverDisplay.SetMeAsReceiver()
    End Sub
    Private Sub ucrReceiverDisplay_Leave(sender As Object, e As EventArgs) Handles ucrReceiverDisplay.Leave
        ucrBase.clsRsyntax.AddParameter("x", ucrReceiverDisplay.GetVariables())
    End Sub
End Class