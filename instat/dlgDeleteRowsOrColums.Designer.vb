<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDeleteRowsOrColums
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.ucrSelectorForDeleteRows = New instat.ucrDataFrame()
        Me.rdoColumns = New System.Windows.Forms.RadioButton()
        Me.rdoRows = New System.Windows.Forms.RadioButton()
        Me.ucrDataFrameLengthForDeleteRows = New instat.ucrDataFrameLength()
        Me.lblRowsToDelete = New System.Windows.Forms.Label()
        Me.ucrInputRowsToDelete = New instat.ucrInputTextBox()
        Me.ucrSelectorForDeleteColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverForColumnsToDelete = New instat.ucrReceiverMultiple()
        Me.lblColumnsToDelete = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 221)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 55)
        Me.ucrBase.TabIndex = 5
        '
        'lblNumberofRows
        '
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.Location = New System.Drawing.Point(10, 91)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(86, 13)
        Me.lblNumberofRows.TabIndex = 3
        Me.lblNumberofRows.Tag = "Number_of_Rows"
        Me.lblNumberofRows.Text = "Number of Rows"
        '
        'ucrSelectorForDeleteRows
        '
        Me.ucrSelectorForDeleteRows.Location = New System.Drawing.Point(12, 38)
        Me.ucrSelectorForDeleteRows.Name = "ucrSelectorForDeleteRows"
        Me.ucrSelectorForDeleteRows.Size = New System.Drawing.Size(127, 41)
        Me.ucrSelectorForDeleteRows.TabIndex = 6
        '
        'rdoColumns
        '
        Me.rdoColumns.AutoSize = True
        Me.rdoColumns.Location = New System.Drawing.Point(13, 13)
        Me.rdoColumns.Name = "rdoColumns"
        Me.rdoColumns.Size = New System.Drawing.Size(65, 17)
        Me.rdoColumns.TabIndex = 7
        Me.rdoColumns.TabStop = True
        Me.rdoColumns.Tag = "Columns"
        Me.rdoColumns.Text = "Columns"
        Me.rdoColumns.UseVisualStyleBackColor = True
        '
        'rdoRows
        '
        Me.rdoRows.AutoSize = True
        Me.rdoRows.Location = New System.Drawing.Point(267, 13)
        Me.rdoRows.Name = "rdoRows"
        Me.rdoRows.Size = New System.Drawing.Size(52, 17)
        Me.rdoRows.TabIndex = 8
        Me.rdoRows.TabStop = True
        Me.rdoRows.Tag = "Rows"
        Me.rdoRows.Text = "Rows"
        Me.rdoRows.UseVisualStyleBackColor = True
        '
        'ucrDataFrameLengthForDeleteRows
        '
        Me.ucrDataFrameLengthForDeleteRows.clsDataFrameSelector = Nothing
        Me.ucrDataFrameLengthForDeleteRows.Location = New System.Drawing.Point(112, 85)
        Me.ucrDataFrameLengthForDeleteRows.Name = "ucrDataFrameLengthForDeleteRows"
        Me.ucrDataFrameLengthForDeleteRows.Size = New System.Drawing.Size(53, 23)
        Me.ucrDataFrameLengthForDeleteRows.TabIndex = 9
        '
        'lblRowsToDelete
        '
        Me.lblRowsToDelete.AutoSize = True
        Me.lblRowsToDelete.Location = New System.Drawing.Point(264, 33)
        Me.lblRowsToDelete.Name = "lblRowsToDelete"
        Me.lblRowsToDelete.Size = New System.Drawing.Size(80, 13)
        Me.lblRowsToDelete.TabIndex = 10
        Me.lblRowsToDelete.Tag = "Rows_to_Delete"
        Me.lblRowsToDelete.Text = "Rows to Delete"
        '
        'ucrInputRowsToDelete
        '
        Me.ucrInputRowsToDelete.Location = New System.Drawing.Point(267, 49)
        Me.ucrInputRowsToDelete.Name = "ucrInputRowsToDelete"
        Me.ucrInputRowsToDelete.Size = New System.Drawing.Size(77, 21)
        Me.ucrInputRowsToDelete.TabIndex = 11
        '
        'ucrSelectorForDeleteColumns
        '
        Me.ucrSelectorForDeleteColumns.Location = New System.Drawing.Point(12, 36)
        Me.ucrSelectorForDeleteColumns.Name = "ucrSelectorForDeleteColumns"
        Me.ucrSelectorForDeleteColumns.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorForDeleteColumns.TabIndex = 12
        '
        'ucrReceiverForColumnsToDelete
        '
        Me.ucrReceiverForColumnsToDelete.Location = New System.Drawing.Point(260, 54)
        Me.ucrReceiverForColumnsToDelete.Name = "ucrReceiverForColumnsToDelete"
        Me.ucrReceiverForColumnsToDelete.Selector = Nothing
        Me.ucrReceiverForColumnsToDelete.Size = New System.Drawing.Size(144, 104)
        Me.ucrReceiverForColumnsToDelete.TabIndex = 13
        '
        'lblColumnsToDelete
        '
        Me.lblColumnsToDelete.AutoSize = True
        Me.lblColumnsToDelete.Location = New System.Drawing.Point(260, 38)
        Me.lblColumnsToDelete.Name = "lblColumnsToDelete"
        Me.lblColumnsToDelete.Size = New System.Drawing.Size(93, 13)
        Me.lblColumnsToDelete.TabIndex = 14
        Me.lblColumnsToDelete.Tag = "Columns_to_Delete"
        Me.lblColumnsToDelete.Text = "Columns to Delete"
        '
        'dlgDeleteRowsOrColums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 273)
        Me.Controls.Add(Me.lblColumnsToDelete)
        Me.Controls.Add(Me.ucrReceiverForColumnsToDelete)
        Me.Controls.Add(Me.ucrSelectorForDeleteColumns)
        Me.Controls.Add(Me.ucrInputRowsToDelete)
        Me.Controls.Add(Me.lblRowsToDelete)
        Me.Controls.Add(Me.ucrDataFrameLengthForDeleteRows)
        Me.Controls.Add(Me.rdoRows)
        Me.Controls.Add(Me.rdoColumns)
        Me.Controls.Add(Me.ucrSelectorForDeleteRows)
        Me.Controls.Add(Me.lblNumberofRows)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgDeleteRowsOrColums"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Delete_Rows_Columns"
        Me.Text = "Delete Rows/Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNumberofRows As Label
    Friend WithEvents ucrSelectorForDeleteRows As ucrDataFrame
    Friend WithEvents rdoColumns As RadioButton
    Friend WithEvents rdoRows As RadioButton
    Friend WithEvents ucrDataFrameLengthForDeleteRows As ucrDataFrameLength
    Friend WithEvents lblRowsToDelete As Label
    Friend WithEvents ucrInputRowsToDelete As ucrInputTextBox
    Friend WithEvents ucrSelectorForDeleteColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverForColumnsToDelete As ucrReceiverMultiple
    Friend WithEvents lblColumnsToDelete As Label
End Class
