Public Class ucrInputComboBox
    Dim strItemsType As String = ""
    Private Sub cboInput_Leave(sender As Object, e As EventArgs) Handles cboInput.Leave
        ValidateText(cboInput.Text, cboInput)
    End Sub

    Public Sub SetItemsTypeAsColumns()
        strItemsType = "Columns"
        FillItemTypes()
    End Sub

    Public Sub SetItemsTypeAsDataFrames()
        strItemsType = "Data Frames"
        FillItemTypes()
    End Sub

    Public Sub SetItemsTypeAsModels()
        strItemsType = "Models"
        FillItemTypes()
    End Sub

    Private Sub FillItemTypes()
        Select Case strItemsType
            Case "Columns"
                If ucrDataFrameSelector IsNot Nothing Then
                    frmMain.clsRLink.FillColumnNames(ucrDataFrameSelector.cboAvailableDataFrames.Text, cboColumns:=cboInput)
                End If
            Case "Data Frames"
            Case "Models"
        End Select
    End Sub

    Public Sub ucrDataFrameSelector_DataFrameChanged() Handles ucrDataFrameSelector.DataFrameChanged
        FillItemTypes()
    End Sub

    Public Overrides Sub SetName(strName As String)
        If IsValid(strName) Then
            cboInput.Text = strName
        Else
            MsgBox(strName & "is not a valid for this combobox", vbOKOnly)
        End If
    End Sub

    Public Sub AddItems(strItems As String())
        cboInput.Items.AddRange(strItems)
    End Sub

    Private Sub cboInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboInput.KeyPress
        bUserTyped = True
    End Sub
End Class
