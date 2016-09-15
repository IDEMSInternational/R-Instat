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
            If ((Not nudStart.Text = "") And (Not nudNumberofRows.Text = "")) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        nudNumberofRows.Value = 1
        nudStart.Value = 1
        ColumnsRows()
        rdoColumns.Checked = True
        ucrSelectorForDeleteColumns.Reset()
        rdoRows.Enabled = False

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
        nudNumberofRows.Maximum = ucrSelectorForDeleteRows.iDataFrameLength
        nudStart.Maximum = ucrSelectorForDeleteRows.iDataFrameLength
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
            nudNumberofRows.Maximum = ucrSelectorForDeleteRows.iDataFrameLength
            nudStart.Maximum = ucrSelectorForDeleteRows.iDataFrameLength
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$remove_rows_in_data")
            FromToParameter()
            ReceiverCols()
            ucrSelectorForDeleteRows.Visible = True
            ucrDataFrameLengthForDeleteRows.Visible = True
            lblNumberofRows.Visible = True
            grpRowsToDelete.Visible = True
            ucrSelectorForDeleteColumns.Visible = False
            lblColumnsToDelete.Visible = False
            ucrReceiverForColumnsToDelete.Visible = False
        End If
        If rdoColumns.Checked = True Then
            ucrSelectorForDeleteRows.Reset()
            ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForDeleteColumns.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$remove_columns_in_data")
            FromToParameter()
            ReceiverCols()
            ucrSelectorForDeleteRows.Visible = False
            ucrDataFrameLengthForDeleteRows.Visible = False
            lblNumberofRows.Visible = False
            grpRowsToDelete.Visible = False
            ucrSelectorForDeleteColumns.Visible = True
            lblColumnsToDelete.Visible = True
            ucrReceiverForColumnsToDelete.Visible = True
        End If

    End Sub

    Private Sub grpRowsToDelete_TextChanged(sender As Object, e As EventArgs) Handles nudStart.TextChanged, nudNumberofRows.TextChanged
        FromToParameter()
        TestOKEnabled()
    End Sub

    Private Sub FromToParameter()
        If rdoRows.Checked = True Then
            If Not nudStart.Text = "" Then
                ucrBase.clsRsyntax.AddParameter("start_pos", nudStart.Value)
            Else
                ucrBase.clsRsyntax.RemoveParameter("start_pos")
            End If
            If Not nudNumberofRows.Text = "" Then
                ucrBase.clsRsyntax.AddParameter("num_rows", nudNumberofRows.Value)
            Else
                ucrBase.clsRsyntax.RemoveParameter("num_rows")
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("start_pos")
            ucrBase.clsRsyntax.RemoveParameter("num_rows")
        End If
    End Sub

    Private Sub ucrReceiveForColumnsToDelete_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForColumnsToDelete.SelectionChanged

    End Sub
End Class