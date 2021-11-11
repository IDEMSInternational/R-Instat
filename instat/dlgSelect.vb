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
        ucrInputSelectPreview.txtInput.ReadOnly = True
        ucrReceiverSelect.SetItemType("column_selection")
        ucrReceiverSelect.strSelectorHeading = "Column selections"
        ucrReceiverSelect.Selector = ucrSelectorForSelectColumns
        ucrReceiverSelect.SetMeAsReceiver()

        ucrSelectorForSelectColumns.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForSelectColumns.SetParameterIsString()
        ucrSelectorForSelectColumns.HideShowAddOrDataOptionsButton(bDataOptionsVisible:=False)

        ucrReceiverSelect.SetParameter(New RParameter("name", 1))
        ucrReceiverSelect.SetParameterIsString()

        ucrPnlApplyOptions.AddRadioButton(rdoApplyAsSelect)
        ucrPnlApplyOptions.AddRadioButton(rdoApplyAsSubset)
        rdoApplyAsSubset.Enabled = False

        ucrPnlApplyOptions.AddToLinkedControls({ucrNewDataFrameName}, {rdoApplyAsSubset}, bNewLinkedHideIfParameterMissing:=True)

        ucrNewDataFrameName.SetIsTextBox()
        ucrNewDataFrameName.SetSaveTypeAsDataFrame()
        ucrNewDataFrameName.SetDataFrameSelector(ucrSelectorForSelectColumns.ucrAvailableDataFrames)
        ucrNewDataFrameName.SetLabelText("New Data Frame Name:")
    End Sub

    Private Sub SetDefaults()
        clsSetCurrentColumnSelection = New RFunction
        ucrSelectorForSelectColumns.Reset()
        rdoApplyAsSelect.Checked = True

        clsSetCurrentColumnSelection.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_current_column_selection")

        ucrBase.clsRsyntax.SetBaseRFunction(clsSetCurrentColumnSelection)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrSelectorForSelectColumns.SetRCode(clsSetCurrentColumnSelection, bReset)
        ucrReceiverSelect.SetRCode(clsSetCurrentColumnSelection, bReset)
    End Sub

    Private Sub TestOkEnabled()
        ucrBase.OKEnabled(Not ucrReceiverSelect.IsEmpty)
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

    Private Sub ucrReceiverSelect_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelect.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class