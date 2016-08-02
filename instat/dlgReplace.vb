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
Public Class dlgReplace
    Public bFirstLoad As Boolean = True
    Dim strVarType As String
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
        rdoRange.Enabled = False
        lblFrom.Enabled = False
        lblTo.Enabled = False
        ucrInputRangeFro.Enabled = False
        ucrInputRangeTo.Enabled = False
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverReplace.IsEmpty()) Then
            ucrBaseReplace.OKEnabled(True)
        Else
            ucrBaseReplace.OKEnabled(False)
        End If
    End Sub

    Private Sub CheckType()
        If (Not ucrReceiverReplace.IsEmpty() And ucrReceiverReplace.lstSelectedVariables.Items.Count = 1) Then
            strVarType = frmMain.clsRLink.GetDataType(ucrSelectorReplace.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverReplace.GetVariableNames(bWithQuotes:=False))
            If (strVarType = "numeric" Or strVarType = "integer" Or strVarType = "positive integer") Then
                ucrReceiverReplace.SetDataType("numeric")
            End If
            If (strVarType = "character") Then
                ucrReceiverReplace.SetDataType("character")
            End If
            If (strVarType = "factor" Or strVarType = "two level factor" Or strVarType = "multilevel factor") Then
                ucrReceiverReplace.SetDataType("factor")
            End If
            If (strVarType = "logical") Then
                ucrReceiverReplace.SetDataType("logical")
            End If
            If (strVarType = "Date") Then
                ucrReceiverReplace.SetDataType("Date")
            End If
        Else
            ucrReceiverReplace.RemoveIncludedMetadataProperty(strProperty:="class")
        End If
    End Sub

    Private Sub ucrBaseReplace_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseReplace.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorReplace_DataFrameChanged() Handles ucrSelectorReplace.DataFrameChanged
        CheckType()
        ucrBaseReplace.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorReplace.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverReplace_SelectionChanged() Handles ucrReceiverReplace.SelectionChanged
        CheckType()
        RangeEnable()
        ucrBaseReplace.clsRsyntax.AddParameter("col_names", ucrReceiverReplace.GetVariableNames())
        TestOKEnabled()
    End Sub

    Private Sub InputOldValue()
        If (strVarType = "numeric" Or strVarType = "integer" Or strVarType = "positive integer") Then
            ucrBaseReplace.clsRsyntax.AddParameter("old_value", ucrInputOldValue.GetText)
        End If
        If (strVarType = "character") Then
            ucrBaseReplace.clsRsyntax.AddParameter("old_value", Chr(34) & ucrInputOldValue.GetText & Chr(34))
        End If
        If (strVarType = "factor" Or strVarType = "two level factor" Or strVarType = "multilevel factor") Then
            ucrBaseReplace.clsRsyntax.AddParameter("old_value", Chr(34) & ucrInputOldValue.GetText & Chr(34))
        End If
        'If (strVarType = "logical") Then

        'End If
        'If (strVarType = "Date") Then

        'End If
    End Sub

    Private Sub InputNewValue()
        If (strVarType = "numeric" Or strVarType = "integer" Or strVarType = "positive integer") Then
            ucrBaseReplace.clsRsyntax.AddParameter("new_value", ucrInputNewValue.GetText)
        End If
        If (strVarType = "character") Then
            ucrBaseReplace.clsRsyntax.AddParameter("new_value", Chr(34) & ucrInputNewValue.GetText & Chr(34))
        End If
        If (strVarType = "character" or strVarType = "factor" Or strVarType = "two level factor" Or strVarType = "multilevel factor") Then
            ucrBaseReplace.clsRsyntax.AddParameter("new_value", Chr(34) & ucrInputNewValue.GetText & Chr(34))
        End If
        'If (strVarType = "logical") Then

        'End If
        'If (strVarType = "Date") Then

        'End If
    End Sub

    Private Sub rdoOldValue_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOldValue.CheckedChanged
        If rdoOldValue.Checked Then
            InputOldValue()
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("old_value")
            ucrInputOldValue.txtInput.Text = ""
        End If
    End Sub

    Private Sub rdoOldMissing_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOldMissing.CheckedChanged
        If rdoOldMissing.Checked Then
            If (strVarType = "numeric" Or strVarType = "integer" Or strVarType = "positive integer") Then
                ucrBaseReplace.clsRsyntax.AddParameter("old_value", "NA")
            End If
            If (strVarType = "character" Or strVarType = "factor" Or strVarType = "two level factor" Or strVarType = "multilevel factor") Then
                ucrBaseReplace.clsRsyntax.AddParameter("old_value", Chr(34) & "" & Chr(34))
            End If
            'If (strVarType = "logical") Then

            'End If
            'If (strVarType = "Date") Then

            'End If
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("old_value")
        End If
    End Sub

    Private Sub rdoNewValue_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNewValue.CheckedChanged
        If rdoNewValue.Checked Then
            InputNewValue()
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
            InputOldValue()
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("old_value")
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
            InputNewValue()
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("new_value")
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
            If (strVarType = "numeric" Or strVarType = "integer" Or strVarType = "positive integer") Then
                ucrBaseReplace.clsRsyntax.AddParameter("new_value", "NA")
            End If
            If (strVarType = "character" Or strVarType = "factor" Or strVarType = "two level factor" Or strVarType = "multilevel factor") Then
                ucrBaseReplace.clsRsyntax.AddParameter("new_value", Chr(34) & "" & Chr(34))
            End If
            'If (strVarType = "logical") Then

            'End If
            'If (strVarType = "Date") Then

            'End If
        Else
                ucrBaseReplace.clsRsyntax.RemoveParameter("new_value")
        End If
    End Sub
    Private Sub RangeEnable()
        If ((Not ucrReceiverReplace.IsEmpty()) And (strVarType = "numeric" Or strVarType = "integer" Or strVarType = "positive integer")) Then
            rdoRange.Enabled = True
            lblFrom.Enabled = True
            lblTo.Enabled = True
            ucrInputRangeFro.Enabled = True
            ucrInputRangeTo.Enabled = True
        Else
            rdoRange.Enabled = False
            lblFrom.Enabled = False
            lblTo.Enabled = False
            ucrInputRangeFro.Enabled = False
            ucrInputRangeTo.Enabled = False
        End If
    End Sub
End Class