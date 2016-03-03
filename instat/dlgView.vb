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
Public Class dlgView
    Public bFast As Boolean = True
    Private Sub dlgView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.iHelpTopicID = 32
        ucrReceiverView.Selector = ucrSelectorDataFrame
        ucrReceiverView.SetMeAsReceiver()
    End Sub
    Private Sub ucrReceiverView_Leave(sender As Object, e As EventArgs) Handles ucrReceiverView.Leave
        ucrBase.clsRsyntax.AddParameter("X", ucrReceiverView.GetVariableNames())

    End Sub

    Private Sub txtTop_leave(sender As Object, e As EventArgs) Handles txtTop.Leave
        ucrBase.clsRsyntax.AddParameter("n", txtTop.Text)
    End Sub

    Private Sub txtBottom_leave(sender As Object, e As EventArgs) Handles txtBottom.Leave
        ucrBase.clsRsyntax.AddParameter("n", txtBottom.Text)
    End Sub

    Private Sub rdoTop_click(sender As Object, e As EventArgs) Handles rdoTop.Click
        ucrBase.clsRsyntax.SetFunction("head")
    End Sub

    Private Sub rdoBottom_click(sender As Object, e As EventArgs) Handles rdoBottom.Click
        ucrBase.clsRsyntax.SetFunction("tail")
    End Sub
End Class