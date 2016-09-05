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

Public Class dlgRowNamesOrNumbers
    Public bFirstLoad As Boolean = True
    Dim sort As RFunction

    Private Sub dlgRowNamesOrNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
        autoTranslate(Me)
    End Sub
    Private Sub TestOKEnabled()
        If ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub InitialiseDialog()
        ucrReceiverSingleRownamesOrNumbers.Selector = ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers
        ucrReceiverSingleRownamesOrNumbers.SetMeAsReceiver()
        ucrBase.iHelpTopicID = 178
        ucrNewColumnName.SetDefaultTypeAsColumn()
        ucrNewColumnName.SetValidationTypeAsRVariable()
        ucrNewColumnName.SetDataFrameSelector(ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.ucrAvailableDataFrames)
    End Sub

    Private Sub SetDefaults()
        ucrNewColumnName.Reset()
        ucrNewColumnName.SetName("row_names")
        ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Reset()
        rdoCopytoFirstColumn.Checked = True
        rdoSortAscending.Checked = True
        chkAsNumeric.Checked = True
        OptionSettings()
    End Sub

    Private Sub ReopenDialog()
        ' ToBeAssigned/IsAssigned values get reset after running script 
        ' so need to be redone here
        SetAssignment()
    End Sub

    Private Sub ucrBaseRownamesOrNumbers_clickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub rdoOptionSettings_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCopytoFirstColumn.CheckedChanged, rdoCopyfromColumn.CheckedChanged, rdoResetintoPositiveIntegers.CheckedChanged, rdoSortbyRowNames.CheckedChanged
        OptionSettings()
    End Sub

    Private Sub OptionSettings()
        If rdoCopytoFirstColumn.Checked Then
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$get_row_names")
            ucrBase.clsRsyntax.ClearParameters()
            ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Enabled = False
            ucrReceiverSingleRownamesOrNumbers.Visible = False
            grpSortOptions.Visible = False
            lblColumnName.Visible = True
            ucrNewColumnName.Visible = True
        ElseIf rdoCopyfromColumn.Checked Then
            ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Enabled = True
            ucrReceiverSingleRownamesOrNumbers.Visible = True
            ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Enabled = True
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_row_names")
            ucrBase.clsRsyntax.ClearParameters()
            grpSortOptions.Visible = False
            lblColumnName.Visible = False
            ucrNewColumnName.Visible = False
        ElseIf rdoResetintoPositiveIntegers.Checked Then
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_row_names")
            ucrBase.clsRsyntax.ClearParameters()
            ucrReceiverSingleRownamesOrNumbers.Visible = False
            ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Enabled = False
            grpSortOptions.Visible = False
            lblColumnName.Visible = False
            ucrNewColumnName.Visible = False
        ElseIf rdoSortbyRowNames.Checked Then
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$sort_dataframe")
            ucrBase.clsRsyntax.ClearParameters()
            ucrBase.clsRsyntax.AddParameter("by_row_names", "TRUE")
            ucrReceiverSingleRownamesOrNumbers.Visible = False
            ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Enabled = False
            grpSortOptions.Visible = True
            lblColumnName.Visible = False
            ucrNewColumnName.Visible = False
        End If
        SetSortOrderParameter()
        SetAsNumericParameter()
        SetAssignment()
        SetRowNamesParameter()
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.strCurrentDataFrame & Chr(34))
    End Sub

    Private Sub ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers_DataFrameChanged() Handles ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.strCurrentDataFrame & Chr(34))
        SetAssignment()
        TestOKEnabled()
    End Sub

    Private Sub rdoSortAscendingDescending_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSortAscending.CheckedChanged, rdoSortDescending.CheckedChanged
        SetSortOrderParameter()
    End Sub

    Private Sub SetSortOrderParameter()
        If rdoSortbyRowNames.Checked Then
            If rdoSortAscending.Checked Then
                If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    ucrBase.clsRsyntax.AddParameter("decreasing", "FALSE")
                Else
                    ucrBase.clsRsyntax.RemoveParameter("decreasing")
                End If
            ElseIf rdoSortDescending.Checked Then
                ucrBase.clsRsyntax.AddParameter("decreasing", "TRUE")
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("decreasing")
        End If
    End Sub

    Private Sub chkAsNumeric_CheckedChanged(sender As Object, e As EventArgs) Handles chkAsNumeric.CheckedChanged
        SetAsNumericParameter()
    End Sub

    Private Sub SetAsNumericParameter()
        If rdoSortbyRowNames.Checked Then
            If chkAsNumeric.Checked Then
                If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    ucrBase.clsRsyntax.AddParameter("row_names_as_numeric", "TRUE")
                Else
                    ucrBase.clsRsyntax.RemoveParameter("row_names_as_numeric")
                End If
            Else
                ucrBase.clsRsyntax.AddParameter("row_names_as_numeric", "FALSE")
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("row_names_as_numeric")
        End If
    End Sub

    Private Sub ucrNewColumnName_NameChanged()
        SetAssignment()
    End Sub

    Private Sub SetAssignment()
        If rdoCopytoFirstColumn.Checked AndAlso Not ucrNewColumnName.IsEmpty Then
            ucrBase.clsRsyntax.SetAssignTo(ucrNewColumnName.GetText(), strTempDataframe:=ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText(), bInsertColumnBefore:=True)
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrReceiverSingleRownamesOrNumbers_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSingleRownamesOrNumbers.SelectionChanged
        SetRowNamesParameter()
    End Sub

    Private Sub SetRowNamesParameter()
        If rdoCopyfromColumn.Checked Then
            If ucrReceiverSingleRownamesOrNumbers.IsEmpty Then
                ucrBase.clsRsyntax.RemoveParameter("row_names")
            Else
                ucrBase.clsRsyntax.AddParameter("row_names", clsRFunctionParameter:=ucrReceiverSingleRownamesOrNumbers.GetVariables())
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("row_names")
        End If
    End Sub
End Class