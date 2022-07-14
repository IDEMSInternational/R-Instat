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
    Private clsGetRowNamesFunction As New RFunction
    Private clsSetRowNamesFunction As New RFunction
    Private clsAddKeyFunction As New RFunction
    Private clsAsNumericFunction As New RFunction
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
        ucrChkMakeColumnIntoKey.AddParameterValuesCondition(True, "add_key", "TRUE")
        ucrChkMakeColumnIntoKey.AddParameterValuesCondition(False, "add_key", "FALSE")

        'ucrNewColumnName
        ucrNewColumnName.SetIsComboBox()
        ucrNewColumnName.SetPrefix("row")
        ucrNewColumnName.SetSaveTypeAsColumn()
        ucrNewColumnName.SetDataFrameSelector(ucrSelectorRowNames.ucrAvailableDataFrames)
        ucrNewColumnName.SetLabelText("Column Name:")
    End Sub

    Private Sub SetDefaults()
        clsGetRowNamesFunction = New RFunction
        clsAddKeyFunction = New RFunction
        clsDummyFunction = New RFunction
        clsSetRowNamesFunction = New RFunction
        clsAsNumericFunction = New RFunction

        ucrNewColumnName.Reset()
        ucrSelectorRowNames.Reset()
        ucrBase.clsRsyntax.lstAfterCodes.Clear()

        clsDummyFunction.AddParameter("checked_rdo", "copy_row", iPosition:=1)
        clsDummyFunction.AddParameter("add_key", "FALSE", iPosition:=2)

        clsAddKeyFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")

        clsAsNumericFunction.SetRCommand("as.numeric")
        clsAsNumericFunction.AddParameter("x", clsRFunctionParameter:=clsGetRowNamesFunction, iPosition:=0)

        clsGetRowNamesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_row_names")
        clsGetRowNamesFunction.SetAssignTo(strTemp:=ucrNewColumnName.GetText(), strTempDataframe:=ucrSelectorRowNames.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText())

        clsSetRowNamesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_row_names")

        ucrBase.clsRsyntax.SetBaseRFunction(clsGetRowNamesFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorRowNames.AddAdditionalCodeParameterPair(clsSetRowNamesFunction, ucrSelectorRowNames.GetParameter, iAdditionalPairNo:=1)
        ucrSelectorRowNames.AddAdditionalCodeParameterPair(clsAddKeyFunction, ucrSelectorRowNames.GetParameter, iAdditionalPairNo:=2)

        ucrSelectorRowNames.SetRCode(clsGetRowNamesFunction, bReset)
        ucrReceiverRowNames.SetRCode(clsSetRowNamesFunction, bReset)
        ucrChkMakeColumnIntoKey.SetRCode(clsDummyFunction, bReset)
        ucrPnlOverallOptions.SetRCode(clsDummyFunction, bReset)
        ucrNewColumnName.AddAdditionalRCode(clsGetRowNamesFunction, bReset)
        ucrNewColumnName.SetRCode(clsAsNumericFunction, bReset)
        ucrChkAsNumeric.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
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

    Private Sub ucrPnl_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOverallOptions.ControlValueChanged
        ucrNewColumnName.SetAssignToBooleans(bTempInsertColumnBefore:=True)
        If rdoSetRowNamesFromColumn.Checked Then
            ucrSelectorRowNames.SetVariablesVisible(True)
            ucrBase.clsRsyntax.SetBaseRFunction(clsSetRowNamesFunction)
            clsDummyFunction.AddParameter("checked_rdo", "set_row", iPosition:=1)
        Else
            ucrSelectorRowNames.SetVariablesVisible(False)
            If rdoCopyRowNamesIntoFirstColumn.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsAsNumericFunction)
                clsDummyFunction.AddParameter("checked_rdo", "copy_row", iPosition:=1)
            ElseIf rdoResetintoPositiveIntegers.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsSetRowNamesFunction)
                clsDummyFunction.AddParameter("checked_rdo", "reset_row", iPosition:=1)
            ElseIf rdoSortbyRowNames.Checked Then
                ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$sort_dataframe")
                clsDummyFunction.AddParameter("checked_rdo", "sort_row", iPosition:=1)
            End If
        End If
        AddRemoveKeyFromAfterCodes()
    End Sub

    Private Sub AddRemoveKeyFromAfterCodes()
        ucrBase.clsRsyntax.RemoveFromAfterCodes(clsAddKeyFunction)
        If rdoCopyRowNamesIntoFirstColumn.Checked Then
            If ucrChkMakeColumnIntoKey.Checked Then
                ucrBase.clsRsyntax.AddToAfterCodes(clsAddKeyFunction, iPosition:=0)
                clsDummyFunction.AddParameter("add_key", "TRUE", iPosition:=2)
            Else
                clsDummyFunction.AddParameter("add_key", "FALSE", iPosition:=2)
            End If
        End If
    End Sub

    Private Sub ucrChkMakeColumnIntoKey_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMakeColumnIntoKey.ControlValueChanged
        AddRemoveKeyFromAfterCodes()
    End Sub

    Private Sub ucrNewColumnName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNewColumnName.ControlValueChanged
        clsAddKeyFunction.AddParameter("col_names", Chr(34) & ucrNewColumnName.GetText & Chr(34), iPosition:=1)
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorRowNames.ControlContentsChanged,
        ucrPnlOverallOptions.ControlContentsChanged, ucrReceiverRowNames.ControlContentsChanged, ucrNewColumnName.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class