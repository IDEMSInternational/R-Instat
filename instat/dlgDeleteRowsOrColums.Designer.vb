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
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.lblColumnsToDelete = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.rdoColumns = New System.Windows.Forms.RadioButton()
        Me.rdoRows = New System.Windows.Forms.RadioButton()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrPnlColumnsOrRows = New instat.UcrPanel()
        Me.ucrDataFrameLengthForDeleteRows = New instat.ucrDataFrameLength()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.ucrSelectorForDeleteColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverForColumnsToDelete = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblNumberofRows
        '
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.Location = New System.Drawing.Point(7, 108)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(89, 13)
        Me.lblNumberofRows.TabIndex = 6
        Me.lblNumberofRows.Tag = "Number_of_Rows:"
        Me.lblNumberofRows.Text = "Number of Rows:"
        '
        'lblColumnsToDelete
        '
        Me.lblColumnsToDelete.AutoSize = True
        Me.lblColumnsToDelete.Location = New System.Drawing.Point(254, 89)
        Me.lblColumnsToDelete.Name = "lblColumnsToDelete"
        Me.lblColumnsToDelete.Size = New System.Drawing.Size(96, 13)
        Me.lblColumnsToDelete.TabIndex = 4
        Me.lblColumnsToDelete.Tag = "Columns_to_Delete"
        Me.lblColumnsToDelete.Text = "Columns to Delete:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(7, 143)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(67, 13)
        Me.lblFrom.TabIndex = 8
        Me.lblFrom.Tag = ""
        Me.lblFrom.Text = "Delete From:"
        '
        'rdoColumns
        '
        Me.rdoColumns.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumns.FlatAppearance.BorderSize = 2
        Me.rdoColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoColumns.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoColumns.Location = New System.Drawing.Point(105, 12)
        Me.rdoColumns.Name = "rdoColumns"
        Me.rdoColumns.Size = New System.Drawing.Size(100, 28)
        Me.rdoColumns.TabIndex = 1
        Me.rdoColumns.Text = "Columns"
        Me.rdoColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColumns.UseVisualStyleBackColor = True
        '
        'rdoRows
        '
        Me.rdoRows.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoRows.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRows.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRows.FlatAppearance.BorderSize = 2
        Me.rdoRows.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRows.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoRows.Location = New System.Drawing.Point(203, 12)
        Me.rdoRows.Name = "rdoRows"
        Me.rdoRows.Size = New System.Drawing.Size(100, 28)
        Me.rdoRows.TabIndex = 2
        Me.rdoRows.Text = "Rows"
        Me.rdoRows.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoRows.UseVisualStyleBackColor = True
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(51, 169)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 10
        Me.lblTo.Tag = ""
        Me.lblTo.Text = "To:"
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(100, 165)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTo.TabIndex = 11
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlColumnsOrRows
        '
        Me.ucrPnlColumnsOrRows.Location = New System.Drawing.Point(97, 11)
        Me.ucrPnlColumnsOrRows.Name = "ucrPnlColumnsOrRows"
        Me.ucrPnlColumnsOrRows.Size = New System.Drawing.Size(214, 29)
        Me.ucrPnlColumnsOrRows.TabIndex = 0
        '
        'ucrDataFrameLengthForDeleteRows
        '
        Me.ucrDataFrameLengthForDeleteRows.Location = New System.Drawing.Point(100, 104)
        Me.ucrDataFrameLengthForDeleteRows.Name = "ucrDataFrameLengthForDeleteRows"
        Me.ucrDataFrameLengthForDeleteRows.Size = New System.Drawing.Size(55, 24)
        Me.ucrDataFrameLengthForDeleteRows.TabIndex = 7
        Me.ucrDataFrameLengthForDeleteRows.ucrDataFrameSelector = Nothing
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(100, 139)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrom.TabIndex = 9
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSelectorForDeleteColumns
        '
        Me.ucrSelectorForDeleteColumns.bShowHiddenColumns = False
        Me.ucrSelectorForDeleteColumns.bUseCurrentFilter = True
        Me.ucrSelectorForDeleteColumns.Location = New System.Drawing.Point(9, 43)
        Me.ucrSelectorForDeleteColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDeleteColumns.Name = "ucrSelectorForDeleteColumns"
        Me.ucrSelectorForDeleteColumns.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForDeleteColumns.TabIndex = 3
        '
        'ucrReceiverForColumnsToDelete
        '
        Me.ucrReceiverForColumnsToDelete.frmParent = Me
        Me.ucrReceiverForColumnsToDelete.Location = New System.Drawing.Point(254, 104)
        Me.ucrReceiverForColumnsToDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForColumnsToDelete.Name = "ucrReceiverForColumnsToDelete"
        Me.ucrReceiverForColumnsToDelete.Selector = Nothing
        Me.ucrReceiverForColumnsToDelete.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverForColumnsToDelete.strNcFilePath = ""
        Me.ucrReceiverForColumnsToDelete.TabIndex = 5
        Me.ucrReceiverForColumnsToDelete.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 243)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 12
        '
        'dlgDeleteRowsOrColums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 299)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.ucrNudTo)
        Me.Controls.Add(Me.rdoColumns)
        Me.Controls.Add(Me.rdoRows)
        Me.Controls.Add(Me.ucrPnlColumnsOrRows)
        Me.Controls.Add(Me.ucrDataFrameLengthForDeleteRows)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblNumberofRows)
        Me.Controls.Add(Me.ucrNudFrom)
        Me.Controls.Add(Me.ucrSelectorForDeleteColumns)
        Me.Controls.Add(Me.lblColumnsToDelete)
        Me.Controls.Add(Me.ucrReceiverForColumnsToDelete)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDeleteRowsOrColums"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Delete_Rows_Columns"
        Me.Text = "Delete Rows/Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNumberofRows As Label
    Friend WithEvents ucrDataFrameLengthForDeleteRows As ucrDataFrameLength
    Friend WithEvents ucrSelectorForDeleteColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverForColumnsToDelete As ucrReceiverMultiple
    Friend WithEvents lblColumnsToDelete As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents rdoColumns As RadioButton
    Friend WithEvents rdoRows As RadioButton
    Friend WithEvents ucrPnlColumnsOrRows As UcrPanel
    Friend WithEvents lblTo As Label
    Friend WithEvents ucrNudTo As ucrNud
End Class
