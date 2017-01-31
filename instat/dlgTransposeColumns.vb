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
Imports instat
Imports instat.Translations
Public Class dlgTransposeColumns
    Private bFirstLoad As Boolean = True
    Public clsRToDataFrame, clsTranspose As New RFunction
    Private clsOverallFunction, clsTFunction, clsTDefaultFunction As New RFunction
    Private Sub dlgTransposeColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
            SetDefaults()
        Else
            ReOpenDialog()
        End If
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 277

        'WANT:
        ' Sheet1_transposed <- as.data.frame(x=t(x=InstatDataObject$get_columns_from_data(data_name="Sheet1", col_names="dlgAddComment")))
        'InstatDataObject$import_data(data_tables = List(Sheet1_transposed = Sheet1_transposed))

        ' checkbox doesn't do anything - not yet implemented.

        ' ucrReceiver
        ucrReceiverColumsToTranspose.SetParameter(New RParameter("x"))
        ucrReceiverColumsToTranspose.SetParameterIsRFunction()
        ucrReceiverColumsToTranspose.Selector = ucrSelectorTransposeColumns
        ucrReceiverColumsToTranspose.SetMeAsReceiver()

        'ucrNewDF
        ucrNewDataframe.SetIsTextBox()
        ucrNewDataframe.SetSaveTypeAsDataFrame()
        ucrNewDataframe.SetDataFrameSelector(ucrSelectorTransposeColumns.ucrAvailableDataFrames)
        ucrNewDataframe.SetLabelText("New Data Frame Name:")

        'chkbox
        ucrChkNameNewColumns.SetParameter(New RParameter(""))
        ucrChkNameNewColumns.SetText("Name New Columns")
        ucrChkNameNewColumns.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkNameNewColumns.SetRDefault("FALSE")
        ucrChkNameNewColumns.Enabled = False


        ' Default R
        clsOverallFunction.SetRCommand("as.data.frame")
        clsOverallFunction.SetAssignTo(ucrNewDataframe.GetText(), strTempDataframe:=ucrNewDataframe.GetText())

        clsTDefaultFunction.SetRCommand("t")
    End Sub


    Private Sub SetDefaults()
        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFunction)
        clsTFunction = clsTDefaultFunction.Clone()
        clsOverallFunction.AddParameter("x", clsRFunctionParameter:=clsTFunction)
        ucrReceiverColumsToTranspose.SetRCode(clsTFunction)
        ucrNewDataframe.SetRCode(clsOverallFunction)
        ucrSelectorTransposeColumns.Reset()
        ucrNewDataframe.Reset()
        TestOkEnabled()
        NewDefaultName()
    End Sub

    Private Sub ReOpenDialog()
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
    End Sub

    Private Sub ucrs_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTransposeColumns.ControlValueChanged
        NewDefaultName()
    End Sub

    Private Sub NewDefaultName()
        If (Not ucrNewDataframe.bUserTyped) AndAlso ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataframe.SetName(ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_transposed")
        End If
    End Sub

    Private Sub ucrReceiverColumsToTranspose_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumsToTranspose.ControlContentsChanged, ucrNewDataframe.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class