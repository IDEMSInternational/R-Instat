﻿'Instat-R
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

Public Class dlgConvertColumns
    Public bFirstLoad As Boolean = True

    Private Sub ucrSelectorDataFrameColumns_Load(sender As Object, e As EventArgs) Handles ucrSelectorDataFrameColumns.Load
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")

        ucrReceiverColumnsToConvert.Selector = ucrSelectorDataFrameColumns
        autoTranslate(Me)
        ucrBase.iHelpTopicID = 34

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False

        End If

        rdoCharacter.Enabled = False
        rdoInteger.Enabled = False
        rdoNumeric.Enabled = False
        TestOKEnabled()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorDataFrameColumns.Reset()
        ucrSelectorDataFrameColumns.Focus()
        ucrReceiverColumnsToConvert.SetMeAsReceiver()
        rdoByLevels.Checked = True
        grpFactorNumeric.Visible = False

        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorDataFrameolumns_DataFrameChanged() Handles ucrSelectorDataFrameColumns.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorDataFrameColumns.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))

    End Sub

    Private Sub ucrReceiverColumnsToConvert_SelectionChanged() Handles ucrReceiverColumnsToConvert.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("col_names", ucrReceiverColumnsToConvert.GetVariableNames)
        TestOKEnabled()
    End Sub

    Private Sub grpForConvertToType_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFactor.CheckedChanged, rdoNumeric.CheckedChanged, rdoCharacter.CheckedChanged, rdoInteger.CheckedChanged
        If rdoFactor.Checked Then
            grpFactorNumeric.Visible = False
            ucrBase.clsRsyntax.AddParameter("to_type", Chr(34) & "factor" & Chr(34))
            TestOKEnabled()

        ElseIf rdoNumeric.Checked Then
            grpFactorNumeric.Visible = True
            ucrBase.clsRsyntax.AddParameter("to_type", Chr(34) & "numeric" & Chr(34))
            TestOKEnabled()
        ElseIf rdoCharacter.Checked Then
            grpFactorNumeric.Visible = False
            ucrBase.clsRsyntax.AddParameter("to_type", Chr(34) & "character" & Chr(34))
            TestOKEnabled()
        ElseIf rdoInteger.Checked Then
            grpFactorNumeric.Visible = False
            ucrBase.clsRsyntax.AddParameter("to_type", Chr(34) & "integer" & Chr(34))
            TestOKEnabled()
        Else
            ucrBase.clsRsyntax.RemoveParameter("to_type")
            grpFactorNumeric.Visible = False

            'the else case should never happen but is there just in case
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()

    End Sub


    Private Sub TestOKEnabled()
        If ucrReceiverColumnsToConvert.IsEmpty() = False And (rdoFactor.Checked = True Or rdoNumeric.Checked = True Or rdoCharacter.Checked = True Or rdoInteger.Checked = True) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub rdoByLevelsAndrdoByOrdinals_CheckedChanged(sender As Object, e As EventArgs) Handles rdoByLevels.CheckedChanged, rdoByOrdinals.CheckedChanged
        If rdoByLevels.Checked = True Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                ucrBase.clsRsyntax.AddParameter("factor_numeric", Chr(34) & "by_levels" & Chr(34))


            Else
                ucrBase.clsRsyntax.RemoveParameter("factor_numeric")
            End If

        ElseIf rdoByOrdinals.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("factor_numeric", Chr(34) & "by_ordinals" & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("factor_numeric")
        End If
    End Sub

End Class