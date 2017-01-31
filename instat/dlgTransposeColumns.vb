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
Public Class dlgTransposeColumns
    Private bFirstLoad As Boolean = True
    Public clsRToDataFrame, clsTranspose As New RFunction
    Private Sub dlgTransposeColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReOpenDialog()
        End If
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ' Sheet1_transposed <- as.data.frame(x=t(x=InstatDataObject$get_columns_from_data(data_name="Sheet1", col_names="dlgAddComment")))
        'InstatDataObject$import_data(data_tables = List(Sheet1_transposed = Sheet1_transposed))
        ' found a bug - checkbox doesn't do anything

        ' ucrSelector

        ' ucrReceiver
        '        ucrReceiverColumsToTranspose.SetParameter(New RParameter("x", 0))
        ucrReceiverColumsToTranspose.SetParameterIsRFunction()
        ucrReceiverColumsToTranspose.Selector = ucrSelectorTransposeColumns
        ucrReceiverColumsToTranspose.SetMeAsReceiver()
        '        clsTranspose.AddParameter("x", clsRFunctionParameter:=ucrReceiverColumsToTranspose.GetVariables())

        'ucrNewDF
        ucrNewDataframe.SetIsTextBox()
        ucrNewDataframe.SetSaveTypeAsColumn()
        ucrNewDataframe.SetDataFrameSelector(ucrSelectorTransposeColumns.ucrAvailableDataFrames)
        ucrNewDataframe.SetLabelText("New Data Frame Name:")


        ucrBase.clsRsyntax.SetFunction("")
        clsRToDataFrame.SetRCommand("as.data.frame") 'transposed data is in matrix form. We need to convert to dataframe inorder to write back


        clsTranspose.SetRCommand("t")
        ucrBase.iHelpTopicID = 277
    End Sub

    Private Sub SetDefaults()
        ucrSelectorTransposeColumns.Reset()
        ucrNewDataframe.Reset()
        chkNameNewColumns.Checked = False
        '     If (ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "") Then
        '    ucrNewDataFrameName.SetName(ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_transposed")
        '   Else
        '  ucrNewDataFrameName.SetName("")
        ' End If
        TestOkEnabled()
    End Sub

    Private Sub ReOpenDialog()

    End Sub

    Private Sub TestOkEnabled()
        '     If Not ucrReceiverColumsToTranspose.IsEmpty AndAlso Not ucrNewDataFrameName.IsEmpty Then
        '    ucrBase.OKEnabled(True)
        '   Else
        '  ucrBase.OKEnabled(False)
        ' End If
    End Sub

    Public Sub ucrReceiverColumsToTranspose_SelectionChanged() Handles ucrReceiverColumsToTranspose.SelectionChanged
        clsTranspose.AddParameter("x", clsRFunctionParameter:=ucrReceiverColumsToTranspose.GetVariables())
        clsRToDataFrame.AddParameter("x", clsRFunctionParameter:=clsTranspose)
        ucrBase.clsRsyntax.AddParameter("", clsRFunctionParameter:=clsRToDataFrame)
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorTransposeColumns_DataFrameChanged() Handles ucrSelectorTransposeColumns.DataFrameChanged
        '       If (Not ucrNewDataFrameName.UserTyped()) AndAlso ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
        '      ucrNewDataFrameName.SetName(ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_transposed")
        '     End If
        TestOkEnabled()
    End Sub

    Public Sub ucrNewDataFrameName_NameChanged()
        '      If Not ucrNewDataFrameName.IsEmpty Then
        '     ucrBase.clsRsyntax.SetAssignTo(ucrNewDataFrameName.GetText(), strTempDataframe:=ucrNewDataFrameName.GetText())
        '    Else
        '   ucrBase.clsRsyntax.RemoveAssignTo()
        '  End If
        TestOkEnabled()
    End Sub

    Private Sub chkNameNewColumns_CheckedChanged(sender As Object, e As EventArgs) Handles chkNameNewColumns.CheckedChanged
        'this is not yet implemented.
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
End Class