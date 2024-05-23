<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrRowGroup
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.dataGridGroups = New System.Windows.Forms.DataGridView()
        Me.colLabel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodnition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFormat = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrLogicalCombobox = New instat.ucrInputComboBox()
        Me.btnClearGroups = New System.Windows.Forms.Button()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.btnAddGroupCondition = New System.Windows.Forms.Button()
        Me.ucrFilterByReceiver = New instat.ucrReceiverSingle()
        Me.ucrFilterOperation = New instat.ucrInputComboBox()
        Me.lblGroups = New System.Windows.Forms.Label()
        Me.lblGroupCondition = New System.Windows.Forms.Label()
        Me.rdoGroup = New System.Windows.Forms.RadioButton()
        Me.rdoSummary = New System.Windows.Forms.RadioButton()
        Me.ucrPnlRow = New instat.UcrPanel()
        Me.rdoStyle = New System.Windows.Forms.RadioButton()
        CType(Me.dataGridGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridGroups
        '
        Me.dataGridGroups.AllowUserToAddRows = False
        Me.dataGridGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridGroups.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLabel, Me.colCodnition, Me.colFormat})
        Me.dataGridGroups.Location = New System.Drawing.Point(266, 156)
        Me.dataGridGroups.Name = "dataGridGroups"
        Me.dataGridGroups.RowHeadersWidth = 62
        Me.dataGridGroups.Size = New System.Drawing.Size(361, 73)
        Me.dataGridGroups.TabIndex = 11
        '
        'colLabel
        '
        Me.colLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colLabel.HeaderText = "Label"
        Me.colLabel.MinimumWidth = 8
        Me.colLabel.Name = "colLabel"
        Me.colLabel.Width = 58
        '
        'colCodnition
        '
        Me.colCodnition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colCodnition.HeaderText = "Condition"
        Me.colCodnition.MinimumWidth = 8
        Me.colCodnition.Name = "colCodnition"
        Me.colCodnition.Width = 76
        '
        'colFormat
        '
        Me.colFormat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colFormat.HeaderText = ""
        Me.colFormat.MinimumWidth = 8
        Me.colFormat.Name = "colFormat"
        Me.colFormat.Width = 8
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(10, 49)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorCols.TabIndex = 23
        '
        'ucrLogicalCombobox
        '
        Me.ucrLogicalCombobox.AddQuotesIfUnrecognised = True
        Me.ucrLogicalCombobox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrLogicalCombobox.GetSetSelectedIndex = -1
        Me.ucrLogicalCombobox.IsReadOnly = False
        Me.ucrLogicalCombobox.Location = New System.Drawing.Point(460, 65)
        Me.ucrLogicalCombobox.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrLogicalCombobox.Name = "ucrLogicalCombobox"
        Me.ucrLogicalCombobox.Size = New System.Drawing.Size(89, 21)
        Me.ucrLogicalCombobox.TabIndex = 31
        '
        'btnClearGroups
        '
        Me.btnClearGroups.Enabled = False
        Me.btnClearGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearGroups.Location = New System.Drawing.Point(543, 131)
        Me.btnClearGroups.Name = "btnClearGroups"
        Me.btnClearGroups.Size = New System.Drawing.Size(79, 23)
        Me.btnClearGroups.TabIndex = 30
        Me.btnClearGroups.Tag = ""
        Me.btnClearGroups.Text = "Clear"
        Me.btnClearGroups.UseVisualStyleBackColor = True
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(263, 49)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(45, 13)
        Me.lblColumns.TabIndex = 28
        Me.lblColumns.Text = "Column:"
        '
        'btnAddGroupCondition
        '
        Me.btnAddGroupCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAddGroupCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddGroupCondition.Location = New System.Drawing.Point(260, 86)
        Me.btnAddGroupCondition.Name = "btnAddGroupCondition"
        Me.btnAddGroupCondition.Size = New System.Drawing.Size(120, 23)
        Me.btnAddGroupCondition.TabIndex = 25
        Me.btnAddGroupCondition.Tag = ""
        Me.btnAddGroupCondition.Text = "Add"
        Me.btnAddGroupCondition.UseVisualStyleBackColor = True
        '
        'ucrFilterByReceiver
        '
        Me.ucrFilterByReceiver.AutoSize = True
        Me.ucrFilterByReceiver.frmParent = Nothing
        Me.ucrFilterByReceiver.Location = New System.Drawing.Point(260, 65)
        Me.ucrFilterByReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFilterByReceiver.Name = "ucrFilterByReceiver"
        Me.ucrFilterByReceiver.Selector = Nothing
        Me.ucrFilterByReceiver.Size = New System.Drawing.Size(120, 21)
        Me.ucrFilterByReceiver.strNcFilePath = ""
        Me.ucrFilterByReceiver.TabIndex = 24
        Me.ucrFilterByReceiver.ucrSelector = Nothing
        '
        'ucrFilterOperation
        '
        Me.ucrFilterOperation.AddQuotesIfUnrecognised = True
        Me.ucrFilterOperation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrFilterOperation.GetSetSelectedIndex = -1
        Me.ucrFilterOperation.IsReadOnly = False
        Me.ucrFilterOperation.Location = New System.Drawing.Point(381, 65)
        Me.ucrFilterOperation.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrFilterOperation.Name = "ucrFilterOperation"
        Me.ucrFilterOperation.Size = New System.Drawing.Size(78, 21)
        Me.ucrFilterOperation.TabIndex = 26
        '
        'lblGroups
        '
        Me.lblGroups.AutoSize = True
        Me.lblGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroups.Location = New System.Drawing.Point(263, 136)
        Me.lblGroups.Name = "lblGroups"
        Me.lblGroups.Size = New System.Drawing.Size(44, 13)
        Me.lblGroups.TabIndex = 32
        Me.lblGroups.Text = "Groups:"
        '
        'lblGroupCondition
        '
        Me.lblGroupCondition.AutoSize = True
        Me.lblGroupCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupCondition.Location = New System.Drawing.Point(385, 46)
        Me.lblGroupCondition.Name = "lblGroupCondition"
        Me.lblGroupCondition.Size = New System.Drawing.Size(54, 13)
        Me.lblGroupCondition.TabIndex = 33
        Me.lblGroupCondition.Text = "Condition:"
        '
        'rdoGroup
        '
        Me.rdoGroup.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGroup.BackColor = System.Drawing.SystemColors.Control
        Me.rdoGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoGroup.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGroup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGroup.FlatAppearance.BorderSize = 2
        Me.rdoGroup.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGroup.Location = New System.Drawing.Point(191, 3)
        Me.rdoGroup.Name = "rdoGroup"
        Me.rdoGroup.Size = New System.Drawing.Size(91, 29)
        Me.rdoGroup.TabIndex = 276
        Me.rdoGroup.Text = "Groups"
        Me.rdoGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGroup.UseVisualStyleBackColor = True
        '
        'rdoSummary
        '
        Me.rdoSummary.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSummary.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoSummary.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSummary.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummary.FlatAppearance.BorderSize = 2
        Me.rdoSummary.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSummary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSummary.Location = New System.Drawing.Point(280, 3)
        Me.rdoSummary.Name = "rdoSummary"
        Me.rdoSummary.Size = New System.Drawing.Size(91, 29)
        Me.rdoSummary.TabIndex = 277
        Me.rdoSummary.Text = "Summaries"
        Me.rdoSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSummary.UseVisualStyleBackColor = True
        '
        'ucrPnlRow
        '
        Me.ucrPnlRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRow.Location = New System.Drawing.Point(174, 3)
        Me.ucrPnlRow.Name = "ucrPnlRow"
        Me.ucrPnlRow.Size = New System.Drawing.Size(309, 29)
        Me.ucrPnlRow.TabIndex = 275
        '
        'rdoStyle
        '
        Me.rdoStyle.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStyle.BackColor = System.Drawing.SystemColors.Control
        Me.rdoStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoStyle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStyle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStyle.FlatAppearance.BorderSize = 2
        Me.rdoStyle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoStyle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStyle.Location = New System.Drawing.Point(368, 3)
        Me.rdoStyle.Name = "rdoStyle"
        Me.rdoStyle.Size = New System.Drawing.Size(91, 29)
        Me.rdoStyle.TabIndex = 278
        Me.rdoStyle.Text = "Styles"
        Me.rdoStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStyle.UseVisualStyleBackColor = True
        '
        'ucrRowGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoStyle)
        Me.Controls.Add(Me.rdoGroup)
        Me.Controls.Add(Me.rdoSummary)
        Me.Controls.Add(Me.ucrPnlRow)
        Me.Controls.Add(Me.lblGroupCondition)
        Me.Controls.Add(Me.lblGroups)
        Me.Controls.Add(Me.ucrLogicalCombobox)
        Me.Controls.Add(Me.btnClearGroups)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.btnAddGroupCondition)
        Me.Controls.Add(Me.ucrFilterByReceiver)
        Me.Controls.Add(Me.ucrFilterOperation)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.Controls.Add(Me.dataGridGroups)
        Me.Name = "ucrRowGroup"
        Me.Size = New System.Drawing.Size(635, 242)
        CType(Me.dataGridGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGridGroups As DataGridView
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrLogicalCombobox As ucrInputComboBox
    Friend WithEvents btnClearGroups As Button
    Friend WithEvents lblColumns As Label
    Friend WithEvents btnAddGroupCondition As Button
    Friend WithEvents ucrFilterByReceiver As ucrReceiverSingle
    Friend WithEvents ucrFilterOperation As ucrInputComboBox
    Friend WithEvents lblGroups As Label
    Friend WithEvents colLabel As DataGridViewTextBoxColumn
    Friend WithEvents colCodnition As DataGridViewTextBoxColumn
    Friend WithEvents colFormat As DataGridViewButtonColumn
    Friend WithEvents lblGroupCondition As Label
    Friend WithEvents rdoGroup As RadioButton
    Friend WithEvents rdoSummary As RadioButton
    Friend WithEvents ucrPnlRow As UcrPanel
    Friend WithEvents rdoStyle As RadioButton
End Class
