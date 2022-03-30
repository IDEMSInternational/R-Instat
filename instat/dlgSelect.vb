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
Public Class dlgSelect
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSetCurrentColumnSelection As RFunction
    Private clsApplyAsSubset As New RFunction

    Private Sub dlgSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRcodeForControls(bReset)
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 597
        ucrBase.clsRsyntax.iCallType = 2

        ucrInputSelectPreview.txtInput.ReadOnly = True
        ucrReceiverSelect.SetItemType("column_selection")
        ucrReceiverSelect.strSelectorHeading = "Column selections"
        ucrReceiverSelect.Selector = ucrSelectorForSelectColumns
        ucrReceiverSelect.SetMeAsReceiver()

        ucrSelectorForSelectColumns.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForSelectColumns.SetParameterIsString()
        ucrSelectorForSelectColumns.HideShowAddOrDataOptionsOrListView(bDataOptionsVisible:=False)

        ucrReceiverSelect.SetParameter(New RParameter("name", 1))
        ucrReceiverSelect.SetParameterIsString()

        ucrPnlApplyOptions.AddRadioButton(rdoApplyAsSelect)
        ucrPnlApplyOptions.AddRadioButton(rdoApplyAsSubset)
        ucrPnlApplyOptions.AddFunctionNamesCondition(rdoApplyAsSelect, frmMain.clsRLink.strInstatDataObject & "$set_current_column_selection")
        ucrPnlApplyOptions.AddFunctionNamesCondition(rdoApplyAsSubset, frmMain.clsRLink.strInstatDataObject & "$copy_data_object")

        ucrInputNewDataFrameName.SetParameter(New RParameter("new_name", 1))
        ucrInputNewDataFrameName.SetDataFrameSelector(ucrSelectorForSelectColumns.ucrAvailableDataFrames)
        ucrInputNewDataFrameName.bAllowNonConditionValues = True

        ucrPnlApplyOptions.AddToLinkedControls({ucrInputNewDataFrameName}, {rdoApplyAsSubset}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputNewDataFrameName.SetLinkedDisplayControl(lblNewDataFrameName)
    End Sub

    Private Sub SetDefaults()
        clsSetCurrentColumnSelection = New RFunction
        clsApplyAsSubset = New RFunction
        ucrSelectorForSelectColumns.Reset()

        clsSetCurrentColumnSelection.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_current_column_selection")

        clsApplyAsSubset.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$copy_data_object")
        clsApplyAsSubset.AddParameter("data_name", Chr(34) & ucrSelectorForSelectColumns.strCurrentDataFrame & Chr(34), iPosition:=0)

        ucrBase.clsRsyntax.SetBaseRFunction(clsSetCurrentColumnSelection)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrReceiverSelect.AddAdditionalCodeParameterPair(clsApplyAsSubset, New RParameter("column_selection_name", 2), iAdditionalPairNo:=1)
        ucrSelectorForSelectColumns.SetRCode(clsSetCurrentColumnSelection, bReset)
        ucrReceiverSelect.SetRCode(clsSetCurrentColumnSelection, bReset)
        ucrInputNewDataFrameName.SetRCode(clsApplyAsSubset, bReset)
        ucrPnlApplyOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoApplyAsSubset.Checked Then
            ucrBase.OKEnabled(Not ucrInputNewDataFrameName.IsEmpty AndAlso Not ucrReceiverSelect.IsEmpty)
        Else
            ucrBase.OKEnabled(Not ucrReceiverSelect.IsEmpty)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Public Sub SetDefaultDataFrame(Optional strDefaultDataframe As String = "")
        If strDefaultDataframe <> "" Then
            ucrSelectorForSelectColumns.SetDataframe(strDefaultDataframe)
        End If
    End Sub

    Private Sub cmdDefineNewSelect_Click(sender As Object, e As EventArgs) Handles cmdDefineNewSelect.Click
        dlgSelectColumns.SetDefaultDataFrame(ucrSelectorForSelectColumns.ucrAvailableDataFrames.strCurrDataFrame)
        dlgSelectColumns.ShowDialog()
        ucrSelectorForSelectColumns.LoadList()
    End Sub

    Private Sub ucrPnlApplyOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlApplyOptions.ControlValueChanged
        If rdoApplyAsSelect.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSetCurrentColumnSelection)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsApplyAsSubset)
        End If
    End Sub

    Private Sub ucrSelectorForSelectColumns_DataFrameChanged() Handles ucrSelectorForSelectColumns.DataFrameChanged
        If Not ucrSelectorForSelectColumns.IsEmpty() Then
            clsApplyAsSubset.AddParameter("data_name", Chr(34) & ucrSelectorForSelectColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        Else
            clsApplyAsSubset.RemoveParameterByName("data_name")
        End If
    End Sub

    Private Sub ucrReceiverSelect_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelect.ControlValueChanged
        If Not ucrReceiverSelect.IsEmpty Then
            ucrInputNewDataFrameName.SetName(ucrReceiverSelect.GetVariableNames.Trim(Chr(34)))
        Else
            ucrInputNewDataFrameName.SetName("")
        End If
    End Sub

    Private Sub ucrReceiverSelect_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelect.ControlContentsChanged, ucrInputNewDataFrameName.ControlContentsChanged, ucrPnlApplyOptions.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class