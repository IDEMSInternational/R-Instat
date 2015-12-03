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
Public Class dlgBoxPlot
    Private Sub dlgBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("boxplot")
        ucrBase.clsRsyntax.iCallType = 0
        ucrReceiveBoxplotVariable.Selector = UcrAddRemove
        ucrReceiveBoxplotVariable.SetMeAsReceiver()
        autoTranslate(Me)
    End Sub

    Private Sub ucrReceiveBoxplotVariable_Enter(sender As Object, e As EventArgs) Handles ucrReceiveBoxplotVariable.Enter
        ucrReceiveBoxplotVariable.SetMeAsReceiver()
    End Sub


    Private Sub ucrReceiveBoxplotVariable_leave(sender As Object, e As EventArgs) Handles ucrReceiveBoxplotVariable.Leave
        ucrBase.clsRsyntax.AddParameter("x", ucrReceiveBoxplotVariable.GetVariables())

    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        ucrBase.clsRsyntax.AddParameter("main", Chr(34) & txtTitle.Text & Chr(34))
    End Sub

    Private Sub txtYLabel_Leave(sender As Object, e As EventArgs) Handles txtYLabel.Leave
        ucrBase.clsRsyntax.AddParameter("ylab", Chr(34) & txtYLabel.Text & Chr(34))
    End Sub

    Private Sub txtXLabel_Leave(sender As Object, e As EventArgs) Handles txtXLabel.Leave
        ucrBase.clsRsyntax.AddParameter("xlab", Chr(34) & txtXLabel.Text & Chr(34))
    End Sub
End Class