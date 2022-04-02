' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class dlgRowNamesOrNumbers
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRowNamesFunction As New RFunction
    Private clsAddKeyFunction As New RFunction
    Private clsDummyFunction As New RFunction

    Private Sub dlgRowNamesOrNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 178

        ' selector
        ucrSelectorRowNames.SetParameter(New RParameter("data_name", 0))
        ucrSelectorRowNames.SetParameterIsString()

        'ucrReceiverSingle
        ucrReceiverRowNames.SetParameter(New RParameter("row_names", 1))
        ucrReceiverRowNames.SetParameterIsRFunction()
        ucrReceiverRowNames.Selector = ucrSelectorRowNames
        ucrReceiverRowNames.SetMeAsReceiver()
        ucrReceiverRowNames.bUseFilteredData = False

        ' main rdo options
        ucrPnlOverallOptions.AddRadioButton(rdoCopyRowNamesIntoFirstColumn)
        ucrPnlOverallOptions.AddRadioButton(rdoSetRowNamesFromColumn)
        ucrPnlOverallOptions.AddRadioButton(rdoResetintoPositiveIntegers)
        ucrPnlOverallOptions.AddRadioButton(rdoSortbyRowNames)

        ucrPnlOverallOptions.AddParameterValuesCondition(rdoCopyRowNamesIntoFirstColumn, "checked_rdo", "copy_row")
        ucrPnlOverallOptions.AddParameterValuesCondition(rdoSetRowNamesFromColumn, "checked_rdo", "set_row")
        ucrPnlOverallOptions.AddParameterValuesCondition(rdoResetintoPositiveIntegers, "checked_rdo", "reset_row")
        ucrPnlOverallOptions.AddParameterValuesCondition(rdoSortbyRowNames, "checked_rdo", "sort_row")

        ucrPnlOverallOptions.AddToLinkedControls({ucrNewColumnName, ucrChkMakeColumnIntoKey}, {rdoCopyRowNamesIntoFirstColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOverallOptions.AddToLinkedControls(ucrReceiverRowNames, {rdoSetRowNamesFromColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOverallOptions.AddToLinkedControls(ucrPnlSortOptions, {rdoSortbyRowNames}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOverallOptions.AddToLinkedControls(ucrChkAsNumeric, {rdoSortbyRowNames}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'temp hidden as not working
        rdoSortbyRowNames.Visible = False
        rdoSortAscending.Visible = False
        rdoSortDescending.Visible = False

        'ucrPnlSortOptions
        ucrPnlSortOptions.SetParameter(New RParameter("decreasing", 2))
        ucrPnlSortOptions.AddRadioButton(rdoSortAscending, "FALSE")
        ucrPnlSortOptions.AddRadioButton(rdoSortDescending, "TRUE")
        ucrPnlSortOptions.SetRDefault("TRUE")

        'ucrChkAsNumeric
        ucrChkAsNumeric.SetParameter(New RParameter("row_names_as_numeric", 5))
        ucrChkAsNumeric.SetText("Treat Row Names as Numeric")
        ucrChkAsNumeric.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkAsNumeric.SetRDefault("TRUE")

        'ucrChkMakeColumnIntoKey
        ucrChkMakeColumnIntoKey.SetText("Make the Column a Key for the Data Frame")
        ucrChkMakeColumnIntoKey.SetParameter(New RParameter("check", 0))
        ucrChkMakeColumnIntoKey.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMakeColumnIntoKey.SetRDefault("TRUE")

        'ucrNewColumnName
        ucrNewColumnName.SetIsComboBox()
        ucrNewColumnName.SetPrefix("row")
        ucrNewColumnName.SetSaveTypeAsColumn()
        ucrNewColumnName.SetDataFrameSelector(ucrSelectorRowNames.ucrAvailableDataFrames)
        ucrNewColumnName.SetLabelText("Column Name:")
    End Sub

    Private Sub SetDefaults()
        clsRowNamesFunction = New RFunction
        clsAddKeyFunction = New RFunction
        clsDummyFunction = New RFunction

        ucrNewColumnName.Reset()
        ucrSelectorRowNames.Reset()

        clsDummyFunction.AddParameter("check", "TRUE", iPosition:=0)
        clsDummyFunction.AddParameter("checked_rdo", "copy_row", iPosition:=1)

        clsAddKeyFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")

        clsRowNamesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_row_names")
        clsRowNamesFunction.SetAssignTo(strTemp:=ucrNewColumnName.GetText(), strTempDataframe:=ucrSelectorRowNames.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText())
        ucrBase.clsRsyntax.SetBaseRFunction(clsRowNamesFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkAsNumeric.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSelectorRowNames.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverRowNames.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlOverallOptions.SetRCode(clsDummyFunction, bReset)
        ucrNewColumnName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkMakeColumnIntoKey.SetRCode(clsDummyFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If (ucrSelectorRowNames.ucrAvailableDataFrames.cboAvailableDataFrames.Text = "") OrElse (rdoSetRowNamesFromColumn.Checked AndAlso ucrReceiverRowNames.IsEmpty) OrElse (rdoCopyRowNamesIntoFirstColumn.Checked AndAlso Not ucrNewColumnName.IsComplete) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnl_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOverallOptions.ControlValueChanged, ucrChkMakeColumnIntoKey.ControlValueChanged, ucrNewColumnName.ControlValueChanged
        ucrNewColumnName.SetAssignToBooleans(bTempInsertColumnBefore:=True)
        If rdoSetRowNamesFromColumn.Checked Then
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_row_names")
            clsDummyFunction.AddParameter("checked_rdo", "set_row", iPosition:=1)
            ucrSelectorRowNames.SetVariablesVisible(True)
        Else
            ucrSelectorRowNames.SetVariablesVisible(False)
            If rdoCopyRowNamesIntoFirstColumn.Checked Then
                ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$get_row_names")
                clsDummyFunction.AddParameter("checked_rdo", "copy_row", iPosition:=1)
                If ucrChkMakeColumnIntoKey.Checked Then
                    clsAddKeyFunction.AddParameter("col_names", Chr(34) & ucrNewColumnName.GetText & Chr(34), iPosition:=1)
                    ucrBase.clsRsyntax.AddToAfterCodes(clsAddKeyFunction, iPosition:=0)
                Else
                    clsAddKeyFunction.RemoveParameterByName("col_names")
                    ucrBase.clsRsyntax.RemoveFromAfterCodes(clsAddKeyFunction)
                End If
            ElseIf rdoResetintoPositiveIntegers.Checked Then
                ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_row_names")
                clsDummyFunction.AddParameter("checked_rdo", "reset_row", iPosition:=1)
            ElseIf rdoSortbyRowNames.Checked Then
                ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$sort_dataframe")
                clsDummyFunction.AddParameter("checked_rdo", "sort_row", iPosition:=1)
            End If
        End If
        If Not rdoCopyRowNamesIntoFirstColumn.Checked Then
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsAddKeyFunction)
        End If
    End Sub

    Private Sub ucrSelectorRowNames_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorRowNames.ControlValueChanged
        clsAddKeyFunction.AddParameter("data_name", Chr(34) & ucrSelectorRowNames.strCurrentDataFrame & Chr(34), iPosition:=0)
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorRowNames.ControlContentsChanged, ucrPnlOverallOptions.ControlContentsChanged, ucrReceiverRowNames.ControlContentsChanged, ucrNewColumnName.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class