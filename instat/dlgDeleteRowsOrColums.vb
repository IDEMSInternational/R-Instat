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
        ucrBase.iHelpTopicID = 53
        ucrDataFrameLengthForDeleteRows.SetDataFrameSelector(ucrSelectorForDeleteRows)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If ucrInputRowsToDelete IsNot Nothing Or ucrReceiverForColumnsToDelete.IsEmpty = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        rdoColumns.Checked = False
        rdoRows.Checked = True
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorForDeleteColumns_DataFrameChanged() Handles ucrSelectorForDeleteColumns.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForDeleteColumns.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrSelectorForDeleteRows_DataFrameChanged() Handles ucrSelectorForDeleteRows.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", clsRFunctionParameter:=ucrSelectorForDeleteColumns.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrReceiveForColumnsToDelete_SelectionChanged() Handles ucrReceiverForColumnsToDelete.SelectionChanged
        If Not ucrReceiverForColumnsToDelete.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("cols", ucrReceiverForColumnsToDelete.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("cols")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrinputRowsToDelete_NameChanged() Handles ucrInputRowsToDelete.NameChanged
        If Not ucrInputRowsToDelete IsNot Nothing Then
            ucrBase.clsRsyntax.AddParameter("select", Chr(34) & ucrInputRowsToDelete.GetText & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("select")
        End If
        TestOKEnabled()
    End Sub

    Private Sub rdoColumnsRows_CheckedChanged(sender As Object, e As EventArgs) Handles rdoColumns.CheckedChanged, rdoRows.CheckedChanged
        ColumnsRows()
    End Sub

    Private Sub ColumnsRows()
        If rdoRows.Checked = True Then
            ucrSelectorForDeleteRows.Reset()
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$remove_rows_in_data")
            ucrSelectorForDeleteRows.Visible = True
            ucrDataFrameLengthForDeleteRows.Visible = True
            lblNumberofRows.Visible = True
            lblRowsToDelete.Visible = True
            ucrInputRowsToDelete.Visible = True
            ucrSelectorForDeleteColumns.Visible = False
            lblColumnsToDelete.Visible = False
            ucrReceiverForColumnsToDelete.Visible = False
        End If
        If rdoColumns.Checked = True Then
            ucrSelectorForDeleteRows.Reset()
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$remove_columns_in_data")
            ucrSelectorForDeleteRows.Visible = False
            ucrDataFrameLengthForDeleteRows.Visible = False
            lblNumberofRows.Visible = False
            lblRowsToDelete.Visible = False
            ucrInputRowsToDelete.Visible = False
            ucrSelectorForDeleteColumns.Visible = True
            lblColumnsToDelete.Visible = True
            ucrReceiverForColumnsToDelete.Visible = True
            ucrReceiverForColumnsToDelete.Selector = ucrSelectorForDeleteColumns
            ucrReceiverForColumnsToDelete.SetMeAsReceiver()

        End If

    End Sub
End Class