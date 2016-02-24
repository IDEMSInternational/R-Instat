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
Public Class dlgUnstack
    Private Sub unstackDefaultSettings()
        ucrIDColumnReceiver.Selector = ucrSelectorForUnstack
        ucrFactorToUnstackReceiver.Selector = ucrSelectorForUnstack
        ucrFactorToUnstackReceiver.SetMeAsReceiver()
        autoTranslate(Me)
        ucrIDColumnReceiver.Visible = False
        chkIDColumn.Checked = False
    End Sub
    Private Sub dlgUnstack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        unstackDefaultSettings()
        ucrBase.clsRsyntax.SetFunction("dcast")
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        unstackDefaultSettings()
    End Sub
    Private Sub chkIDColumn_CheckedChanged(sender As Object, e As EventArgs) Handles chkIDColumn.CheckedChanged
        If chkIDColumn.Checked = True Then
            ucrIDColumnReceiver.Visible = True
            ucrIDColumnReceiver.SetMeAsReceiver()
        Else
            ucrIDColumnReceiver.Visible = False
        End If
    End Sub

    Private Sub ucrfactortoUnstackReceiver_Leave(sender As Object, e As EventArgs) Handles ucrFactorToUnstackReceiver.Leave
        ucrBase.clsRsyntax.AddParameter("", ucrFactorToUnstackReceiver.GetVariableNames())
    End Sub

    Private Sub ucrColumntoUnstackReceiver_Leave(sender As Object, e As EventArgs) Handles ucrColumnToUnstackReceiver.Leave
        ucrBase.clsRsyntax.AddParameter("value.var", ucrColumnToUnstackReceiver.GetVariableNames())
    End Sub
    Private Sub ucrIDColumnReceiver_Leave(sender As Object, e As EventArgs) Handles ucrIDColumnReceiver.Leave
        ucrBase.clsRsyntax.AddParameter("", ucrIDColumnReceiver.GetVariableNames())
    End Sub

    'Private Sub ucrColumnToUnstackReceiver_Enter(sender As Object, e As EventArgs) Handles ucrColumnToUnstackReceiver.Enter
    '    ucrColumnToUnstackReceiver.SetMeAsReceiver()
    'End Sub
    'Private Sub ucrIDColumnReceiver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ucrIDColumnReceiver.KeyPress
    '    If e.KeyChar = vbCr Then
    '        ucrIDColumnReceiver.RemoveSelected()
    '    End If
    'End Sub

    'Private Sub ucrFactorToUnstackReceiver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ucrFactorToUnstackReceiver.KeyPress
    '    If e.KeyChar = vbCr Then
    '        ucrFactorToUnstackReceiver.RemoveSelected()
    '    End If
    'End Sub
    'Private Sub ucrColumnToUnstackReceiver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ucrColumnToUnstackReceiver.KeyPress
    '    If e.KeyChar = vbCr Then
    '        ucrColumnToUnstackReceiver.RemoveSelected()
    '    End If
    'End Sub
    'Private Sub ucrSelectorByDataFrameAddRemove_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ucrSelectorByDataFrameAddRemove.KeyPress
    '    If e.KeyChar = vbCr Then
    '        ucrSelectorByDataFrameAddRemove.Add()
    '    End If
    'End Sub
End Class