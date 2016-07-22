﻿' Instat-R
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
Public Class dlgReplace
    Public bFirstLoad As Boolean = True
    Private Sub dlgReplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseReplace.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$replace_value_in_data")
        'ucrBasePCA.clsRsyntax.iCallType = 0
        ucrReceiverReplace.Selector = ucrSelectorReplace
        ucrBaseReplace.iHelpTopicID = 47
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorReplace.Reset()
        ucrReceiverReplace.SetMeAsReceiver()
        ucrSelectorReplace.Focus()
        rdoOldValue.Checked = True
        rdoNewValue.Checked = True
        ucrInputOldValue.txtInput.Text = ""
        ucrInputNewValue.txtInput.Text = ""
        chkClosedLowerRange.Checked = True
        chkClosedUpperRange.Checked = True
        chkClosedLowerRange.Enabled = False
        chkClosedUpperRange.Enabled = False
        ucrInputRangeFro.txtInput.Text = ""
        ucrInputRangeTo.txtInput.Text = ""
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverReplace.IsEmpty()) Then
            ucrBaseReplace.OKEnabled(True)
        Else
            ucrBaseReplace.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBaseReplace_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseReplace.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorReplace_DataFrameChanged() Handles ucrSelectorReplace.DataFrameChanged
        ucrBaseReplace.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorReplace.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverReplace_SelectionChanged() Handles ucrReceiverReplace.SelectionChanged
        ucrBaseReplace.clsRsyntax.AddParameter("col_names", ucrReceiverReplace.GetVariableNames())
        TestOKEnabled()
    End Sub

    Private Sub rdoOldValue_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOldValue.CheckedChanged
        If rdoOldValue.Checked Then
            ucrBaseReplace.clsRsyntax.AddParameter("old_value", Chr(34) & ucrInputOldValue.GetText & Chr(34))
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("old_value")
            ucrInputOldValue.txtInput.Text = ""
        End If
    End Sub

    Private Sub rdoOldMissing_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOldMissing.CheckedChanged
        If rdoOldMissing.Checked Then
            ucrBaseReplace.clsRsyntax.RemoveParameter("old_value")
        End If
    End Sub

    Private Sub rdoNewValue_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNewValue.CheckedChanged
        If rdoNewValue.Checked Then
            ucrBaseReplace.clsRsyntax.AddParameter("new_value", Chr(34) & ucrInputNewValue.GetText & Chr(34))
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("new_value")
            ucrInputNewValue.txtInput.Text = ""
        End If
    End Sub
    Private Sub rdoRange_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRange.CheckedChanged
        If rdoRange.Checked Then
            ucrBaseReplace.clsRsyntax.AddParameter("start_value", ucrInputRangeFro.GetText)
            ucrBaseReplace.clsRsyntax.AddParameter("end_value", ucrInputRangeTo.GetText)
            chkClosedLowerRange.Enabled = True
            chkClosedUpperRange.Enabled = True
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("start_value")
            ucrBaseReplace.clsRsyntax.RemoveParameter("end_value")
            ucrInputRangeFro.txtInput.Text = ""
            ucrInputRangeTo.txtInput.Text = ""
            chkClosedLowerRange.Checked = True
            chkClosedUpperRange.Checked = True
            chkClosedLowerRange.Enabled = False
            chkClosedUpperRange.Enabled = False
        End If
    End Sub


    Private Sub ucrInputOldValue_NameChanged() Handles ucrInputOldValue.NameChanged
        If rdoOldValue.Checked Then
            ucrBaseReplace.clsRsyntax.AddParameter("old_value", Chr(34) & ucrInputOldValue.GetText & Chr(34))
        End If
        'TestOKEnabled()
    End Sub

    Private Sub ucrInputRangeFro_NameChanged() Handles ucrInputRangeFro.NameChanged
        If rdoRange.Checked Then
            ucrBaseReplace.clsRsyntax.AddParameter("start_value", ucrInputRangeFro.GetText)
        End If
        'TestOKEnabled()
    End Sub

    Private Sub ucrInputRangeTo_NameChanged() Handles ucrInputRangeTo.NameChanged
        If rdoRange.Checked Then
            ucrBaseReplace.clsRsyntax.AddParameter("end_value", ucrInputRangeTo.GetText)
        End If
        'TestOKEnabled()
    End Sub

    Private Sub ucrInputNewValue_NameChanged() Handles ucrInputNewValue.NameChanged
        If rdoNewValue.Checked Then
            ucrBaseReplace.clsRsyntax.AddParameter("new_value", Chr(34) & ucrInputNewValue.GetText & Chr(34))
        End If
        'TestOKEnabled()
    End Sub

    Private Sub chkClosedLowerRange_CheckedChanged(sender As Object, e As EventArgs) Handles chkClosedLowerRange.CheckedChanged
        If chkClosedLowerRange.Checked Then
            ucrBaseReplace.clsRsyntax.RemoveParameter("closed_start_value")
        Else
            ucrBaseReplace.clsRsyntax.AddParameter("closed_start_value", "FALSE")
        End If
    End Sub

    Private Sub chkClosedUpperRange_CheckedChanged(sender As Object, e As EventArgs) Handles chkClosedUpperRange.CheckedChanged
        If chkClosedUpperRange.Checked Then
            ucrBaseReplace.clsRsyntax.RemoveParameter("closed_end_value")
        Else
            ucrBaseReplace.clsRsyntax.AddParameter("closed_end_value", "FALSE")
        End If
    End Sub

    Private Sub rdoNewMissing_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNewMissing.CheckedChanged
        If rdoNewMissing.Checked Then
            ucrBaseReplace.clsRsyntax.RemoveParameter("new_value")
        End If
    End Sub
End Class