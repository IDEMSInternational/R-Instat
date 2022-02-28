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
Public Class dlgTransposeColumns
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsOverallFunction, clsTransposeFunction, clsGetColumnNames As New RFunction

    Private Sub dlgTransposeColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 277

        ucrReceiverColumsToTranspose.SetParameterIsRFunction()
        ucrReceiverColumsToTranspose.Selector = ucrSelectorTransposeColumns
        ucrReceiverColumsToTranspose.SetMeAsReceiver()

        ucrReceiverVariableNames.SetParameter(New RParameter("make.names", 1))
        ucrReceiverVariableNames.SetParameterIsRFunction()
        ucrReceiverVariableNames.Selector = ucrSelectorTransposeColumns

        'The checkbox is not yet implemented in the updated code as it was not implemented in pre-updated code
        ucrChkNameNewColumns.SetText("Name New Columns")
        ucrChkNameNewColumns.Enabled = False ' temporary

        ucrChkDisplayVariableNames.SetText("Include Old Names")
        ucrChkDisplayVariableNames.AddParameterPresentCondition(True, "keep.names")
        ucrChkDisplayVariableNames.AddParameterPresentCondition(False, "keep.names", False)

        ucrInputDisplayVariableNames.SetParameter(New RParameter("keep.names", 2))

        'ucrNewDF
        ucrNewDataframe.SetIsTextBox()
        ucrNewDataframe.SetSaveTypeAsDataFrame()
        ucrNewDataframe.SetDataFrameSelector(ucrSelectorTransposeColumns.ucrAvailableDataFrames)
        ucrNewDataframe.SetLabelText("New Data Frame Name:")

        ucrChkDisplayVariableNames.AddToLinkedControls({ucrInputDisplayVariableNames}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, objNewDefaultState:="old name", bNewLinkedChangeToDefaultState:=True)
    End Sub

    Private Sub SetDefaults()
        clsTransposeFunction = New RFunction
        clsOverallFunction = New RFunction
        clsGetColumnNames = New RFunction

        ucrSelectorTransposeColumns.Reset()
        ucrNewDataframe.Reset()
        NewDefaultName()

        clsOverallFunction.SetRCommand("as.data.frame")
        clsOverallFunction.SetAssignTo(ucrNewDataframe.GetText(), strTempDataframe:=ucrNewDataframe.GetText())
        clsOverallFunction.AddParameter("x", clsRFunctionParameter:=clsTransposeFunction)

        clsTransposeFunction.SetPackageName("data.table")
        clsTransposeFunction.SetRCommand("transpose")
        clsTransposeFunction.AddParameter("l", "columns", iPosition:=0)
        clsTransposeFunction.AddParameter("make.names", "NULL", iPosition:=1)

        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverVariableNames.SetRCode(clsTransposeFunction, bReset)
        ucrChkDisplayVariableNames.SetRCode(clsTransposeFunction, bReset)
        ucrNewDataframe.SetRCode(clsOverallFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverColumsToTranspose.IsEmpty AndAlso ucrNewDataframe.IsComplete() Then
            If ucrChkDisplayVariableNames.Checked AndAlso (Not ucrInputDisplayVariableNames.IsEmpty) Then
                ucrBase.OKEnabled(True)
            ElseIf ucrChkDisplayVariableNames.Checked AndAlso ucrInputDisplayVariableNames.IsEmpty Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub NewDefaultName()
        If (Not ucrNewDataframe.bUserTyped) AndAlso ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataframe.SetName(ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_transposed")
        End If
    End Sub

    Private Sub CoreName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTransposeColumns.ControlValueChanged
        NewDefaultName()
    End Sub

    Private Sub ucrReceiverColumsToTranspose_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumsToTranspose.ControlValueChanged
        ucrBase.clsRsyntax.lstBeforeCodes.Clear()
        clsGetColumnNames = ucrReceiverColumsToTranspose.GetVariables(True).Clone
        clsGetColumnNames.SetAssignTo("columns")
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetColumnNames)
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumsToTranspose.ControlContentsChanged,
        ucrNewDataframe.ControlContentsChanged, ucrReceiverVariableNames.ControlContentsChanged, ucrChkDisplayVariableNames.ControlContentsChanged,
        ucrInputDisplayVariableNames.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class