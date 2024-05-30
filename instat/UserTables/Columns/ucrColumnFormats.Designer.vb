<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrColumnFormats
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
        Me.lblFormat = New System.Windows.Forms.Label()
        Me.lblGroups = New System.Windows.Forms.Label()
        Me.btnClearGroups = New System.Windows.Forms.Button()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.btnAddGroupCondition = New System.Windows.Forms.Button()
        Me.dataGridGroups = New System.Windows.Forms.DataGridView()
        Me.colLabel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodnition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFormat = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ucrLogicalCombobox = New instat.ucrInputComboBox()
        Me.ucrFilterByReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        CType(Me.dataGridGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFormat.Location = New System.Drawing.Point(373, 2)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(42, 13)
        Me.lblFormat.TabIndex = 298
        Me.lblFormat.Text = "Format:"
        '
        'lblGroups
        '
        Me.lblGroups.AutoSize = True
        Me.lblGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroups.Location = New System.Drawing.Point(239, 71)
        Me.lblGroups.Name = "lblGroups"
        Me.lblGroups.Size = New System.Drawing.Size(47, 13)
        Me.lblGroups.TabIndex = 297
        Me.lblGroups.Text = "Formats:"
        '
        'btnClearGroups
        '
        Me.btnClearGroups.Enabled = False
        Me.btnClearGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearGroups.Location = New System.Drawing.Point(523, 65)
        Me.btnClearGroups.Name = "btnClearGroups"
        Me.btnClearGroups.Size = New System.Drawing.Size(75, 23)
        Me.btnClearGroups.TabIndex = 295
        Me.btnClearGroups.Tag = ""
        Me.btnClearGroups.Text = "Clear"
        Me.btnClearGroups.UseVisualStyleBackColor = True
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(239, 5)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(45, 13)
        Me.lblColumns.TabIndex = 294
        Me.lblColumns.Text = "Column:"
        '
        'btnAddGroupCondition
        '
        Me.btnAddGroupCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAddGroupCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddGroupCondition.Location = New System.Drawing.Point(476, 19)
        Me.btnAddGroupCondition.Name = "btnAddGroupCondition"
        Me.btnAddGroupCondition.Size = New System.Drawing.Size(93, 23)
        Me.btnAddGroupCondition.TabIndex = 292
        Me.btnAddGroupCondition.Tag = ""
        Me.btnAddGroupCondition.Text = "Add"
        Me.btnAddGroupCondition.UseVisualStyleBackColor = True
        '
        'dataGridGroups
        '
        Me.dataGridGroups.AllowUserToAddRows = False
        Me.dataGridGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridGroups.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLabel, Me.colCodnition, Me.colFormat})
        Me.dataGridGroups.Location = New System.Drawing.Point(242, 90)
        Me.dataGridGroups.Name = "dataGridGroups"
        Me.dataGridGroups.RowHeadersWidth = 62
        Me.dataGridGroups.Size = New System.Drawing.Size(361, 73)
        Me.dataGridGroups.TabIndex = 289
        '
        'colLabel
        '
        Me.colLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colLabel.HeaderText = "Column"
        Me.colLabel.MinimumWidth = 8
        Me.colLabel.Name = "colLabel"
        Me.colLabel.Width = 67
        '
        'colCodnition
        '
        Me.colCodnition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colCodnition.HeaderText = "Format"
        Me.colCodnition.MinimumWidth = 8
        Me.colCodnition.Name = "colCodnition"
        Me.colCodnition.Width = 64
        '
        'colFormat
        '
        Me.colFormat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colFormat.HeaderText = ""
        Me.colFormat.MinimumWidth = 8
        Me.colFormat.Name = "colFormat"
        Me.colFormat.Width = 8
        '
        'ucrLogicalCombobox
        '
        Me.ucrLogicalCombobox.AddQuotesIfUnrecognised = True
        Me.ucrLogicalCombobox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrLogicalCombobox.GetSetSelectedIndex = -1
        Me.ucrLogicalCombobox.IsReadOnly = False
        Me.ucrLogicalCombobox.Location = New System.Drawing.Point(376, 21)
        Me.ucrLogicalCombobox.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrLogicalCombobox.Name = "ucrLogicalCombobox"
        Me.ucrLogicalCombobox.Size = New System.Drawing.Size(89, 21)
        Me.ucrLogicalCombobox.TabIndex = 296
        '
        'ucrFilterByReceiver
        '
        Me.ucrFilterByReceiver.AutoSize = True
        Me.ucrFilterByReceiver.frmParent = Nothing
        Me.ucrFilterByReceiver.Location = New System.Drawing.Point(236, 21)
        Me.ucrFilterByReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFilterByReceiver.Name = "ucrFilterByReceiver"
        Me.ucrFilterByReceiver.Selector = Nothing
        Me.ucrFilterByReceiver.Size = New System.Drawing.Size(120, 21)
        Me.ucrFilterByReceiver.strNcFilePath = ""
        Me.ucrFilterByReceiver.TabIndex = 291
        Me.ucrFilterByReceiver.ucrSelector = Nothing
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(6, 5)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorCols.TabIndex = 290
        '
        'ucrColumnFormats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblFormat)
        Me.Controls.Add(Me.lblGroups)
        Me.Controls.Add(Me.ucrLogicalCombobox)
        Me.Controls.Add(Me.btnClearGroups)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrFilterByReceiver)
        Me.Controls.Add(Me.btnAddGroupCondition)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.Controls.Add(Me.dataGridGroups)
        Me.Name = "ucrColumnFormats"
        Me.Size = New System.Drawing.Size(609, 194)
        CType(Me.dataGridGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormat As Label
    Friend WithEvents lblGroups As Label
    Friend WithEvents ucrLogicalCombobox As ucrInputComboBox
    Friend WithEvents btnClearGroups As Button
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrFilterByReceiver As ucrReceiverSingle
    Friend WithEvents btnAddGroupCondition As Button
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
    Friend WithEvents dataGridGroups As DataGridView
    Friend WithEvents colLabel As DataGridViewTextBoxColumn
    Friend WithEvents colCodnition As DataGridViewTextBoxColumn
    Friend WithEvents colFormat As DataGridViewButtonColumn
End Class
