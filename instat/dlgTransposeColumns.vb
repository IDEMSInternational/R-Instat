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
    Private clsOverallFunction, clsTFunction As New RFunction

    Private Sub dlgTransposeColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 277

        ' ucrReceiver
        ucrReceiverColumsToTranspose.SetParameter(New RParameter("x", 0))
        ucrReceiverColumsToTranspose.SetParameterIsRFunction()
        ucrReceiverColumsToTranspose.Selector = ucrSelectorTransposeColumns
        ucrReceiverColumsToTranspose.SetMeAsReceiver()

        'The checkbox is not yet implemented in the updated code as it was not implemented in pre-updated code
        ucrChkNameNewColumns.SetText("Name New Columns")
        ucrChkNameNewColumns.Enabled = False ' temporary

        'ucrNewDF
        ucrNewDataframe.SetIsTextBox()
        ucrNewDataframe.SetSaveTypeAsDataFrame()
        ucrNewDataframe.SetDataFrameSelector(ucrSelectorTransposeColumns.ucrAvailableDataFrames)
        ucrNewDataframe.SetLabelText("New Data Frame Name:")
    End Sub

    Private Sub SetDefaults()
        clsTFunction = New RFunction
        clsOverallFunction = New RFunction

        ucrSelectorTransposeColumns.Reset()
        ucrNewDataframe.Reset()
        NewDefaultName()

        clsOverallFunction.SetRCommand("as.data.frame")
        clsOverallFunction.SetAssignTo(ucrNewDataframe.GetText(), strTempDataframe:=ucrNewDataframe.GetText())
        clsOverallFunction.AddParameter("x", clsRFunctionParameter:=clsTFunction)
        clsTFunction.SetRCommand("t")

        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverColumsToTranspose.SetRCode(clsTFunction, bReset)
        ucrNewDataframe.SetRCode(clsOverallFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverColumsToTranspose.IsEmpty AndAlso ucrNewDataframe.IsComplete() Then
            ucrBase.OKEnabled(True)
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

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumsToTranspose.ControlContentsChanged, ucrNewDataframe.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class