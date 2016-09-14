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
Imports RDotNet

Public Class dlgReplace
    Public bFirstLoad As Boolean = True
    Dim strVarType As String
    Dim clsGetDataType As New RFunction

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
        ucrReceiverReplace.Selector = ucrSelectorReplace
        ucrReceiverReplace.SetSingleTypeStatus(True)
        ucrReceiverReplace.SetMeAsReceiver()
        ucrBaseReplace.iHelpTopicID = 47
        clsGetDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetDataType.AddParameter("property", "data_type_label")
        rdoFromAbove.Enabled = False
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorReplace.Reset()
        ucrSelectorReplace.Focus()
        rdoOldValue.Checked = True
        rdoNewValue.Checked = True
        ucrInputOldValue.SetName("")
        ucrInputNewValue.SetName("")
        chkIncludeMinimum.Checked = True
        chkIncludingMaximum.Checked = True
        ucrInputRangeFrom.SetName("")
        ucrInputRangeTo.SetName("")
        RangeOption()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverReplace.IsEmpty()) Then
            If (rdoOldValue.Checked AndAlso ucrInputOldValue.IsEmpty()) OrElse (rdoRange.Checked AndAlso ucrInputRangeFrom.IsEmpty() AndAlso ucrInputRangeTo.IsEmpty()) OrElse (rdoNewValue.Checked AndAlso ucrInputNewValue.IsEmpty()) Then
                ucrBaseReplace.OKEnabled(False)
            Else
                ucrBaseReplace.OKEnabled(True)
            End If
        Else
            ucrBaseReplace.OKEnabled(False)
        End If
    End Sub

    Private Sub CheckType()
        'Dim strVariableTypes As List(Of String)
        'Dim strOldType As String
        'strOldType = strVarType
        'If (Not ucrReceiverReplace.IsEmpty()) Then
        '    clsGetDataType.AddParameter("data_name", Chr(34) & ucrSelectorReplace.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
        '    clsGetDataType.AddParameter("column", ucrReceiverReplace.GetVariableNames())
        '    If ucrReceiverReplace.lstSelectedVariables.Items.Count = 1 Then
        '        strVarType = frmMain.clsRLink.RunInternalScriptGetValue(clsGetDataType.ToScript()).AsCharacter(0)
        '        If (strVarType = "numeric" OrElse strVarType = "integer") Then
        '            ucrReceiverReplace.SetDataType("numeric")
        '        Else
        '            ucrReceiverReplace.SetDataType(strVarType)
        '        End If
        '    ElseIf strVarType = "" AndAlso ucrReceiverReplace.lstSelectedVariables.Items.Count > 1 Then
        '        strVariableTypes = frmMain.clsRLink.RunInternalScriptGetValue(clsGetDataType.ToScript()).AsCharacter.ToList()
        '        If strVariableTypes.Distinct().Count > 1 AndAlso Not (strVariableTypes.Distinct().Count = 2 AndAlso strVariableTypes.Distinct().Contains("numeric") AndAlso strVariableTypes.Distinct().Contains("integer")) Then
        '            MsgBox("Cannot add these variables. All variables must be of the same data type.", MsgBoxStyle.OkOnly, "Cannot add variables.")
        '            ucrReceiverReplace.Clear()
        '        Else
        '            If strVariableTypes.Distinct().Count = 1 Then
        '                strVarType = strVariableTypes(0)
        '            Else
        '                strVarType = "numeric"
        '            End If
        '            ucrReceiverReplace.SetDataType(strVarType)
        '        End If
        '    End If
        'Else
        '    strVarType = ""
        '    ucrReceiverReplace.RemoveIncludedMetadataProperty(strProperty:="class")
        'End If
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
        If rdoOldValue.Checked Then
            rdoOldValue.Checked = False
            rdoOldValue.Checked = True
        End If
        If rdoNewValue.Checked Then
            rdoNewValue.Checked = False
            rdoNewValue.Checked = True
        End If
        RangeEnable()
        ucrBaseReplace.clsRsyntax.AddParameter("col_names", ucrReceiverReplace.GetVariableNames())
        TestOKEnabled()
    End Sub

    Private Sub InputOldValue()
        If ucrInputOldValue.IsEmpty() Then
            ucrBaseReplace.clsRsyntax.RemoveParameter("old_value")
        Else
            If (strVarType = "numeric" OrElse strVarType = "integer") Then
                ucrBaseReplace.clsRsyntax.AddParameter("old_value", ucrInputOldValue.GetText)
            Else
                ucrBaseReplace.clsRsyntax.AddParameter("old_value", Chr(34) & ucrInputOldValue.GetText() & Chr(34))
            End If
        End If
    End Sub

    Private Sub InputNewValue()
        If ucrInputNewValue.IsEmpty() Then
            ucrBaseReplace.clsRsyntax.RemoveParameter("new_value")
        Else
            If (strVarType = "numeric" OrElse strVarType = "integer") Then
                ucrBaseReplace.clsRsyntax.AddParameter("new_value", ucrInputNewValue.GetText())
            Else
                ucrBaseReplace.clsRsyntax.AddParameter("new_value", Chr(34) & ucrInputNewValue.GetText & Chr(34))
            End If
        End If
    End Sub

    Private Sub rdoOldValue_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOldValue.CheckedChanged
        If rdoOldValue.Checked Then
            ucrInputOldValue.Visible = True
            InputOldValue()
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("old_value")
            ucrInputOldValue.Visible = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub rdoOldMissing_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOldMissing.CheckedChanged
        If rdoOldMissing.Checked Then
            ucrBaseReplace.clsRsyntax.AddParameter("old_value", "NA")
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("old_value")
        End If
        TestOKEnabled()
    End Sub

    Private Sub rdoNewValue_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNewValue.CheckedChanged
        If rdoNewValue.Checked Then
            ucrInputNewValue.Visible = True
            InputNewValue()
        Else
            ucrInputNewValue.Visible = False
            ucrBaseReplace.clsRsyntax.RemoveParameter("new_value")
        End If
        TestOKEnabled()
    End Sub

    Private Sub rdoRange_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRange.CheckedChanged
        RangeOption()
    End Sub

    Private Sub RangeOption()
        If rdoRange.Checked Then
            chkIncludeMinimum.Visible = True
            chkIncludingMaximum.Visible = True
            ucrInputRangeFrom.Visible = True
            ucrInputRangeTo.Visible = True
            lblMaximum.Visible = True
            lblRangeMin.Visible = True
            If ucrInputRangeFrom.IsEmpty() Then
                ucrBaseReplace.clsRsyntax.RemoveParameter("start_value")
            Else
                ucrBaseReplace.clsRsyntax.AddParameter("start_value", ucrInputRangeFrom.GetText)
            End If
            If ucrInputRangeTo.IsEmpty() Then
                ucrBaseReplace.clsRsyntax.RemoveParameter("end_value")
            Else
                ucrBaseReplace.clsRsyntax.AddParameter("end_value", ucrInputRangeTo.GetText)
            End If
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("start_value")
            ucrBaseReplace.clsRsyntax.RemoveParameter("end_value")
            chkIncludeMinimum.Visible = False
            chkIncludingMaximum.Visible = False
            ucrInputRangeFrom.Visible = False
            ucrInputRangeTo.Visible = False
            lblMaximum.Visible = False
            lblRangeMin.Visible = False
        End If
        ClosedRangeParameters()
        RangeToParameter()
        RangeFromParameter()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputOldValue_NameChanged() Handles ucrInputOldValue.NameChanged
        If rdoOldValue.Checked Then
            InputOldValue()
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("old_value")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrInputRangeFrom_NameChanged() Handles ucrInputRangeFrom.NameChanged
        RangeFromParameter()
        TestOKEnabled()
    End Sub

    Private Sub RangeFromParameter()
        If rdoRange.Checked Then
            If ucrInputRangeFrom.IsEmpty() Then
                ucrBaseReplace.clsRsyntax.RemoveParameter("start_value")
            Else
                ucrBaseReplace.clsRsyntax.AddParameter("start_value", ucrInputRangeFrom.GetText)
            End If
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("start_value")
        End If
    End Sub

    Private Sub ucrInputRangeTo_NameChanged() Handles ucrInputRangeTo.NameChanged
        RangeToParameter()
        TestOKEnabled()
    End Sub

    Private Sub RangeToParameter()
        If rdoRange.Checked Then
            If ucrInputRangeTo.IsEmpty() Then
                ucrBaseReplace.clsRsyntax.RemoveParameter("end_value")
            Else
                ucrBaseReplace.clsRsyntax.AddParameter("end_value", ucrInputRangeTo.GetText)
            End If
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("end_value")
        End If
    End Sub

    Private Sub ucrInputNewValue_NameChanged() Handles ucrInputNewValue.NameChanged
        If rdoNewValue.Checked Then
            InputNewValue()
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("new_value")
        End If
        TestOKEnabled()
    End Sub

    Private Sub chkClosedLowerRange_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeMinimum.CheckedChanged
        ClosedRangeParameters()
        TestOKEnabled()
    End Sub

    Private Sub chkClosedUpperRange_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludingMaximum.CheckedChanged
        ClosedRangeParameters()
        TestOKEnabled()
    End Sub

    Private Sub ClosedRangeParameters()
        If rdoRange.Checked Then
            If chkIncludingMaximum.Checked Then
                If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    ucrBaseReplace.clsRsyntax.AddParameter("closed_end_value", "TRUE")
                Else
                    ucrBaseReplace.clsRsyntax.RemoveParameter("closed_end_value")
                End If
            Else
                ucrBaseReplace.clsRsyntax.AddParameter("closed_end_value", "FALSE")
            End If

            If chkIncludeMinimum.Checked Then
                If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    ucrBaseReplace.clsRsyntax.AddParameter("closed_start_value", "TRUE")
                Else
                    ucrBaseReplace.clsRsyntax.RemoveParameter("closed_start_value")
                End If
            Else
                ucrBaseReplace.clsRsyntax.AddParameter("closed_start_value", "FALSE")
            End If
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("closed_start_value")
            ucrBaseReplace.clsRsyntax.RemoveParameter("closed_end_value")
        End If
    End Sub

    Private Sub rdoNewMissing_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNewMissing.CheckedChanged
        If rdoNewMissing.Checked Then
            ucrBaseReplace.clsRsyntax.AddParameter("new_value", "NA")
        Else
            ucrBaseReplace.clsRsyntax.RemoveParameter("new_value")
        End If
        TestOKEnabled()
    End Sub

    Private Sub RangeEnable()
        If strVarType = "" OrElse strVarType = "numeric" OrElse strVarType = "integer" Then
            rdoRange.Enabled = True
        Else
            rdoRange.Enabled = False
            If rdoRange.Checked Then
                rdoOldValue.Checked = True
            End If
        End If
    End Sub
End Class