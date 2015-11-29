' Instat-R
' Copyright (C) 2015

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

Public Class dlgDescriptiveStatistics
    Private Sub dlgDescriptiveStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrReceiverSingle.Selector = ucrSelectorAddRemove
        ucrReceiverSingle.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction("summary")
        ucrBase.clsRsyntax.iCallType = 2
        autoTranslate(Me)
        grpgraphics.Visible = False
    End Sub

    Private Sub chkGraphics_CheckedChanged(sender As Object, e As EventArgs) Handles chkGraphics.CheckedChanged
        If chkGraphics.Checked = True Then
            grpgraphics.Visible = True
        End If
        If chkGraphics.Checked = False Then
            grpgraphics.Visible = False
        End If
    End Sub

    Private Sub ucrReceiverSingle_Leave(sender As Object, e As EventArgs) Handles ucrReceiverSingle.Leave
        ucrBase.clsRsyntax.AddParameter("object", ucrReceiverSingle.GetVariables())
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        'this is a chang i icnnnnn
        MsgBox("this is test branch1")
    End Sub
End Class