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
Public Class dlgCopyDataFrame
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsCopyDataFrameFunction As New RFunction
    Private clsCopyColumnMetadataFunction As New RFunction
    Private clsCopyDataFrameMetadataFunction As New RFunction
    Private Sub dlgCopyDataFrame_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetControls()
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub SetControls()
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 263

        'ucrDataFrame
        ucrDataFrameCopySheets.SetParameter(New RParameter("data_name", 0))
        ucrDataFrameCopySheets.SetParameterIsString()

        'ucrNewName
        ucrInputNewDataFrameName.SetParameter(New RParameter("new_name", 1))
        ucrInputNewDataFrameName.SetValidationTypeAsRVariable()
        ucrInputNewDataFrameName.SetLinkedDisplayControl(lblNewName)

        ucrInputLabel.SetParameter(New RParameter("label", 2))
        ucrInputLabel.SetLinkedDisplayControl(lblLabel)

        ucrChkCopyToClipboard.SetText("Copy to clipboard")
        ucrChkCopyToClipboard.SetParameter(New RParameter("copy_to_clipboard", 3))
        ucrChkCopyToClipboard.SetRDefault("FALSE")
        ucrChkCopyToClipboard.AddToLinkedControls({ucrInputNewDataFrameName, ucrInputLabel}, objValues:={False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkCopyToClipboard.AddToLinkedControls({ucrPnlOptions}, objValues:={True}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlOptions.AddRadioButton(rdoDataFrame)
        ucrPnlOptions.AddRadioButton(rdoColumnsMetadata)
        ucrPnlOptions.AddRadioButton(rdoDataFrameMetadata)
        ucrPnlOptions.AddFunctionNamesCondition(rdoDataFrame, frmMain.clsRLink.strInstatDataObject & "$copy_data_frame")
        ucrPnlOptions.AddFunctionNamesCondition(rdoColumnsMetadata, frmMain.clsRLink.strInstatDataObject & "$copy_col_metadata_to_clipboard")
        ucrPnlOptions.AddFunctionNamesCondition(rdoDataFrameMetadata, frmMain.clsRLink.strInstatDataObject & "$copy_data_frame_metadata_to_clipboard")
    End Sub

    Private Sub SetDefaults()
        clsCopyDataFrameFunction = New RFunction
        clsCopyColumnMetadataFunction = New RFunction
        clsCopyDataFrameMetadataFunction = New RFunction

        ucrInputNewDataFrameName.Reset()
        ucrDataFrameCopySheets.Reset()
        ucrInputLabel.Reset()
        ucrInputLabel.SetName("")
        CheckAutoName()

        clsCopyDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$copy_data_frame")
        clsCopyDataFrameFunction.AddParameter("copy_to_clipboard", "FALSE", iPosition:=3)

        clsCopyColumnMetadataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$copy_col_metadata_to_clipboard")

        clsCopyDataFrameMetadataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$copy_data_frame_metadata_to_clipboard")

        ucrBase.clsRsyntax.SetBaseRFunction(clsCopyDataFrameFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrDataFrameCopySheets.AddAdditionalCodeParameterPair(clsCopyColumnMetadataFunction, New RParameter("data_name", 0), iAdditionalPairNo:=1)
        ucrDataFrameCopySheets.AddAdditionalCodeParameterPair(clsCopyDataFrameMetadataFunction, New RParameter("data_name", 0), iAdditionalPairNo:=2)
        ucrDataFrameCopySheets.SetRCode(clsCopyDataFrameFunction, bReset)

        ucrInputNewDataFrameName.SetRCode(clsCopyDataFrameFunction, bReset)
        ucrInputLabel.SetRCode(clsCopyDataFrameFunction, bReset)
        ucrChkCopyToClipboard.SetRCode(clsCopyDataFrameFunction, bReset)

        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrChkCopyToClipboard.Checked Then
            ucrBase.OKEnabled(ucrDataFrameCopySheets.cboAvailableDataFrames.Text <> "")
        Else
            ucrBase.OKEnabled(((Not ucrInputNewDataFrameName.IsEmpty) AndAlso (ucrDataFrameCopySheets.cboAvailableDataFrames.Text <> "")) AndAlso (Not ucrDataFrameCopySheets.cboAvailableDataFrames.Items.Contains(ucrInputNewDataFrameName.GetText)))
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub CheckAutoName()
        If Not ucrInputNewDataFrameName.bUserTyped Then
            ucrInputNewDataFrameName.SetName(ucrDataFrameCopySheets.cboAvailableDataFrames.Text & "_copy")
        End If
    End Sub

    Public Sub SetCurrentDataframe(strDataFrame As String)
        SetControls()
        ucrDataFrameCopySheets.SetDataframe(strDataFrame)
    End Sub

    Private Sub ucrDataFrameToRename_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDataFrameCopySheets.ControlValueChanged
        CheckAutoName()
    End Sub

    Private Sub Control_ContentsChanged(ucrChangedControl As ucrCore) Handles ucrDataFrameCopySheets.ControlContentsChanged, ucrInputNewDataFrameName.ControlContentsChanged, ucrChkCopyToClipboard.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If Not ucrChkCopyToClipboard.Checked OrElse rdoDataFrame.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCopyDataFrameFunction)
        ElseIf rdoColumnsMetadata.Checked Then
            'todo. temporarily added here because this control's parameter pair condition is not updated
            'until when a selection change event is raised
            clsCopyColumnMetadataFunction.AddParameter("data_name", strParameterValue:=Chr(34) & ucrDataFrameCopySheets.strCurrDataFrame & Chr(34), iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsCopyColumnMetadataFunction)
        ElseIf rdoDataFrameMetadata.Checked Then
            'todo. temporarily added here because this control's parameter pair condition is not updated
            'until when a selection change event is raised
            clsCopyDataFrameMetadataFunction.AddParameter("data_name", strParameterValue:=Chr(34) & ucrDataFrameCopySheets.strCurrDataFrame & Chr(34), iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsCopyDataFrameMetadataFunction)
        End If
    End Sub
End Class
