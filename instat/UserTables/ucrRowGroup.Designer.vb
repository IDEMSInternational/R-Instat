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
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        Me.btnClearGroups = New System.Windows.Forms.Button()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.btnAddCondition = New System.Windows.Forms.Button()
        Me.ucrSingleReceiverCol = New instat.ucrReceiverSingle()
        Me.lblGroups = New System.Windows.Forms.Label()
        Me.lblGroupCondition = New System.Windows.Forms.Label()
        Me.rdoGroup = New System.Windows.Forms.RadioButton()
        Me.rdoSummary = New System.Windows.Forms.RadioButton()
        Me.ucrPnlRow = New instat.UcrPanel()
        Me.rdoStyle = New System.Windows.Forms.RadioButton()
        Me.cboConditionOperator = New System.Windows.Forms.ComboBox()
        Me.cboConditionValue = New System.Windows.Forms.ComboBox()
        Me.txtGroupLabel = New System.Windows.Forms.TextBox()
        Me.lblCondition = New System.Windows.Forms.Label()
        Me.colLabel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodnition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFormat = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dataGridGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridGroups
        '
        Me.dataGridGroups.AllowUserToAddRows = False
        Me.dataGridGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridGroups.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLabel, Me.colCodnition, Me.colFormat})
        Me.dataGridGroups.Location = New System.Drawing.Point(266, 175)
        Me.dataGridGroups.Name = "dataGridGroups"
        Me.dataGridGroups.RowHeadersWidth = 62
        Me.dataGridGroups.Size = New System.Drawing.Size(361, 73)
        Me.dataGridGroups.TabIndex = 11
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
        'btnClearGroups
        '
        Me.btnClearGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearGroups.Location = New System.Drawing.Point(545, 150)
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
        Me.lblColumns.Location = New System.Drawing.Point(263, 52)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(45, 13)
        Me.lblColumns.TabIndex = 28
        Me.lblColumns.Text = "Column:"
        '
        'btnAddCondition
        '
        Me.btnAddCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAddCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddCondition.Location = New System.Drawing.Point(555, 113)
        Me.btnAddCondition.Name = "btnAddCondition"
        Me.btnAddCondition.Size = New System.Drawing.Size(96, 23)
        Me.btnAddCondition.TabIndex = 25
        Me.btnAddCondition.Tag = ""
        Me.btnAddCondition.Text = "Add Group"
        Me.btnAddCondition.UseVisualStyleBackColor = True
        '
        'ucrSingleReceiverCol
        '
        Me.ucrSingleReceiverCol.AutoSize = True
        Me.ucrSingleReceiverCol.frmParent = Nothing
        Me.ucrSingleReceiverCol.Location = New System.Drawing.Point(260, 68)
        Me.ucrSingleReceiverCol.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSingleReceiverCol.Name = "ucrSingleReceiverCol"
        Me.ucrSingleReceiverCol.Selector = Nothing
        Me.ucrSingleReceiverCol.Size = New System.Drawing.Size(120, 21)
        Me.ucrSingleReceiverCol.strNcFilePath = ""
        Me.ucrSingleReceiverCol.TabIndex = 24
        Me.ucrSingleReceiverCol.ucrSelector = Nothing
        '
        'lblGroups
        '
        Me.lblGroups.AutoSize = True
        Me.lblGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroups.Location = New System.Drawing.Point(263, 156)
        Me.lblGroups.Name = "lblGroups"
        Me.lblGroups.Size = New System.Drawing.Size(44, 13)
        Me.lblGroups.TabIndex = 32
        Me.lblGroups.Text = "Groups:"
        '
        'lblGroupCondition
        '
        Me.lblGroupCondition.AutoSize = True
        Me.lblGroupCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupCondition.Location = New System.Drawing.Point(371, 98)
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
        'cboConditionOperator
        '
        Me.cboConditionOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConditionOperator.FormattingEnabled = True
        Me.cboConditionOperator.Items.AddRange(New Object() {"==", "<", "<=", ">", ">=", "!=", "expression"})
        Me.cboConditionOperator.Location = New System.Drawing.Point(367, 115)
        Me.cboConditionOperator.Name = "cboConditionOperator"
        Me.cboConditionOperator.Size = New System.Drawing.Size(78, 21)
        Me.cboConditionOperator.TabIndex = 279
        '
        'cboConditionValue
        '
        Me.cboConditionValue.FormattingEnabled = True
        Me.cboConditionValue.Location = New System.Drawing.Point(446, 115)
        Me.cboConditionValue.Name = "cboConditionValue"
        Me.cboConditionValue.Size = New System.Drawing.Size(106, 21)
        Me.cboConditionValue.TabIndex = 280
        '
        'txtGroupLabel
        '
        Me.txtGroupLabel.Location = New System.Drawing.Point(261, 117)
        Me.txtGroupLabel.Name = "txtGroupLabel"
        Me.txtGroupLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtGroupLabel.TabIndex = 281
        '
        'lblCondition
        '
        Me.lblCondition.AutoSize = True
        Me.lblCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCondition.Location = New System.Drawing.Point(263, 99)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(68, 13)
        Me.lblCondition.TabIndex = 282
        Me.lblCondition.Text = "Group Label:"
        '
        'colLabel
        '
        Me.colLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colLabel.HeaderText = "Label"
        Me.colLabel.MinimumWidth = 8
        Me.colLabel.Name = "colLabel"
        '
        'colCodnition
        '
        Me.colCodnition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colCodnition.HeaderText = "Condition"
        Me.colCodnition.MinimumWidth = 8
        Me.colCodnition.Name = "colCodnition"
        '
        'colFormat
        '
        Me.colFormat.HeaderText = ""
        Me.colFormat.MinimumWidth = 8
        Me.colFormat.Name = "colFormat"
        Me.colFormat.ReadOnly = True
        Me.colFormat.Text = "Format"
        Me.colFormat.Width = 99
        '
        'ucrRowGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblCondition)
        Me.Controls.Add(Me.txtGroupLabel)
        Me.Controls.Add(Me.cboConditionValue)
        Me.Controls.Add(Me.cboConditionOperator)
        Me.Controls.Add(Me.rdoStyle)
        Me.Controls.Add(Me.rdoGroup)
        Me.Controls.Add(Me.rdoSummary)
        Me.Controls.Add(Me.ucrPnlRow)
        Me.Controls.Add(Me.lblGroupCondition)
        Me.Controls.Add(Me.lblGroups)
        Me.Controls.Add(Me.btnClearGroups)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.btnAddCondition)
        Me.Controls.Add(Me.ucrSingleReceiverCol)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.Controls.Add(Me.dataGridGroups)
        Me.Name = "ucrRowGroup"
        Me.Size = New System.Drawing.Size(660, 252)
        CType(Me.dataGridGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGridGroups As DataGridView
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
    Friend WithEvents btnClearGroups As Button
    Friend WithEvents lblColumns As Label
    Friend WithEvents btnAddCondition As Button
    Friend WithEvents ucrSingleReceiverCol As ucrReceiverSingle
    Friend WithEvents lblGroups As Label
    Friend WithEvents lblGroupCondition As Label
    Friend WithEvents rdoGroup As RadioButton
    Friend WithEvents rdoSummary As RadioButton
    Friend WithEvents ucrPnlRow As UcrPanel
    Friend WithEvents rdoStyle As RadioButton
    Friend WithEvents cboConditionOperator As ComboBox
    Friend WithEvents cboConditionValue As ComboBox
    Friend WithEvents txtGroupLabel As TextBox
    Friend WithEvents lblCondition As Label
    Friend WithEvents colLabel As DataGridViewTextBoxColumn
    Friend WithEvents colCodnition As DataGridViewTextBoxColumn
    Friend WithEvents colFormat As DataGridViewButtonColumn
End Class
