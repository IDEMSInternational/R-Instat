Imports instat.Translations
Public Class dlgDeleteRowsOrColums
    Public bFirstLoad As Boolean = True
    Private Sub dlgDeleteRows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 165
        ucrReceiverForColumnsToDelete.Selector = ucrSelectorForDeleteColumns
        ucrReceiverForColumnsToDelete.SetMeAsReceiver()
        ucrDataFrameLengthForDeleteRows.SetDataFrameSelector(ucrSelectorForDeleteRows)
    End Sub

    Private Sub ReopenDialog()
        ucrReceiverForColumnsToDelete.lstSelectedVariables.Clear()
    End Sub

    Private Sub TestOKEnabled()
        If rdoColumns.Checked Then
            If ucrReceiverForColumnsToDelete.IsEmpty = False Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoRows.Checked Then
            If Not nudRowNames.Text = "" Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        nudRowNames.Value = 1
        ColumnsRows()
        rdoColumns.Checked = True
        ucrSelectorForDeleteColumns.Reset()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorForDeleteColumns_DataFrameChanged() Handles ucrSelectorForDeleteColumns.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForDeleteColumns.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrSelectorForDeleteRows_DataFrameChanged() Handles ucrSelectorForDeleteRows.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForDeleteRows.cboAvailableDataFrames.SelectedItem & Chr(34))
        nudRowNames.Maximum = ucrSelectorForDeleteRows.iDataFrameLength
    End Sub

    Private Sub ucrReceiveForColumnsToDelete_SelectionChanged() Handles ucrReceiverForColumnsToDelete.SelectionChanged
        ReceiverCols()
        TestOKEnabled()
    End Sub

    Private Sub ReceiverCols()
        If rdoColumns.Checked = True Then
            If Not ucrReceiverForColumnsToDelete.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("cols", ucrReceiverForColumnsToDelete.GetVariableNames)
            Else
                ucrBase.clsRsyntax.RemoveParameter("cols")
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("cols")
        End If
    End Sub

    Private Sub rdoColumnsRows_CheckedChanged(sender As Object, e As EventArgs) Handles rdoColumns.CheckedChanged, rdoRows.CheckedChanged
        ColumnsRows()
        TestOKEnabled()
    End Sub

    Private Sub ColumnsRows()
        If rdoRows.Checked = True Then
            ucrSelectorForDeleteRows.Reset()
            ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForDeleteRows.cboAvailableDataFrames.SelectedItem & Chr(34))
            nudRowNames.Maximum = ucrSelectorForDeleteRows.iDataFrameLength
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$remove_rows_in_data")
            RowNamesParam()
            ReceiverCols()
            nudRowNames.Visible = True
            ucrSelectorForDeleteRows.Visible = True
            ucrDataFrameLengthForDeleteRows.Visible = True
            lblNumberofRows.Visible = True
            ucrSelectorForDeleteColumns.Visible = False
            lblColumnsToDelete.Visible = False
            ucrReceiverForColumnsToDelete.Visible = False
        End If
        If rdoColumns.Checked = True Then
            ucrSelectorForDeleteRows.Reset()
            ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForDeleteColumns.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$remove_columns_in_data")
            RowNamesParam()
            ReceiverCols()
            nudRowNames.Visible = False
            ucrSelectorForDeleteRows.Visible = False
            ucrDataFrameLengthForDeleteRows.Visible = False
            lblNumberofRows.Visible = False
            ucrSelectorForDeleteColumns.Visible = True
            lblColumnsToDelete.Visible = True
            ucrReceiverForColumnsToDelete.Visible = True
        End If

    End Sub

    Private Sub RowNamesParam()
        If rdoRows.Checked = True Then
            If Not nudRowNames.Text = "" Then
                ucrBase.clsRsyntax.AddParameter("row_names", nudRowNames.Value)
            Else
                ucrBase.clsRsyntax.RemoveParameter("row_names")
            End If

        Else
            ucrBase.clsRsyntax.RemoveParameter("row_names")
        End If
    End Sub

    Private Sub nudRowNames_TextChanged(sender As Object, e As EventArgs) Handles nudRowNames.TextChanged
        RowNamesParam()
    End Sub

End Class