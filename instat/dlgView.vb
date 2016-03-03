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
    Public bFirstLoad As Boolean = True
    Private Sub dlgView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.iHelpTopicID = 32
        txtBottom.Enabled = False
        txtTop.Enabled = False
        ucrReceiverView.Selector = ucrSelectorForView
        ucrReceiverView.SetMeAsReceiver()

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        'Checks if Ok can be enabled.
        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverView.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiverView_SelectionChanged() Handles ucrReceiverView.SelectionChanged
        If Not ucrReceiverView.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("x", ucrReceiverView.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("x")
        End If
        TestOKEnabled()
    End Sub

    Private Sub grpSelectedRows_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBottom.CheckedChanged, rdoTop.CheckedChanged
        If rdoTop.Checked Then
            txtTop.Enabled = True
        Else
            txtBottom.Enabled = True
        End If

    End Sub

    Private Sub grpRowsToBeSelected()

        If rdoTop.Checked Then
            ucrBase.clsRsyntax.SetFunction("head")
            ucrBase.clsRsyntax.AddParameter("n", txtTop.Text)
        Else
            ucrBase.clsRsyntax.SetFunction("tail")
            ucrBase.clsRsyntax.AddParameter("n")
        End If

    End Sub



End Class