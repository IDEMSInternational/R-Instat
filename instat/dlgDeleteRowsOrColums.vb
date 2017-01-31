Imports instat
Imports instat.Translations
Public Class dlgDeleteRowsOrColums
    Public bFirstLoad As Boolean = True
    Private clsDefaultFunction As New RFunction

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

        ucrPnlRows.AddRadioButton(rdoColumns)
        ucrPnlRows.AddRadioButton(rdoRows)

        ucrSelectorForDeleteColumns.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForDeleteColumns.SetParameterIsString()

        ucrSelectorForDeleteRows.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForDeleteRows.SetParameterIsString()

        ucrReceiverForColumnsToDelete.Selector = ucrSelectorForDeleteColumns
        ucrReceiverForColumnsToDelete.SetMeAsReceiver()
        ucrReceiverForColumnsToDelete.SetParameter(New RParameter("cols"))
        ucrReceiverForColumnsToDelete.SetParameterIsString()
        ucrNudRowsToDelete.SendToBack()

        ucrNudRowsToDelete.SetParameter(New RParameter("row_names"))
        ucrNudRowsToDelete.Minimum = 1
        ucrNudRowsToDelete.Maximum = ucrSelectorForDeleteRows.iDataFrameLength

        ucrDataFrameLengthForDeleteRows.SetDataFrameSelector(ucrSelectorForDeleteRows)
        ColumnsRows()
    End Sub

    Private Sub ReopenDialog()
        ucrReceiverForColumnsToDelete.lstSelectedVariables.Clear()
    End Sub

    Private Sub TestOKEnabled()
        If rdoColumns.Checked Then
            If Not ucrReceiverForColumnsToDelete.IsEmpty() Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoRows.Checked Then
            If ucrNudRowsToDelete.Text <> "" Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub plnRows() Handles ucrPnlRows.ControlContentsChanged, ucrReceiverForColumnsToDelete.ControlContentsChanged
        ColumnsRows()
        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrSelectorForDeleteColumns.Reset()
        ucrSelectorForDeleteRows.Reset()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        ucrNudRowsToDelete.Value = 1
        rdoColumns.Checked = True
        ColumnsRows()
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ColumnsRows()
        If rdoRows.Checked Then
            ucrSelectorForDeleteRows.Reset()
            clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_rows_in_data")
            ucrNudRowsToDelete.Visible = True
            ucrSelectorForDeleteRows.Visible = True
            ucrDataFrameLengthForDeleteRows.Visible = True
            lblRowNames.Visible = True
            ucrSelectorForDeleteColumns.Visible = False
            lblColumnsToDelete.Visible = False
            ucrReceiverForColumnsToDelete.Visible = False
        ElseIf rdoColumns.Checked Then
            ucrSelectorForDeleteRows.Reset()
            clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_columns_in_data")
            ucrNudRowsToDelete.Visible = False
            ucrSelectorForDeleteRows.Visible = False
            ucrDataFrameLengthForDeleteRows.Visible = False
            lblRowNames.Visible = False
            ucrSelectorForDeleteColumns.Visible = True
            lblColumnsToDelete.Visible = True
            ucrReceiverForColumnsToDelete.Visible = True
        End If
    End Sub
End Class