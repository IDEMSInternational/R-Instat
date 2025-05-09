<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrNewCellFormats
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
        Me.ucrRowExpression = New instat.ucrRowExpression()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSelectFormat = New System.Windows.Forms.ComboBox()
        Me.ucrReceiverMultipleCols = New instat.ucrReceiverMultiple()
        Me.lblFormats = New System.Windows.Forms.Label()
        Me.btnClearFormats = New System.Windows.Forms.Button()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.btnEnterFormat = New System.Windows.Forms.Button()
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        Me.dataGridFormats = New System.Windows.Forms.DataGridView()
        Me.colCodnition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLabel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRow = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataGridFormats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrRowExpression
        '
        Me.ucrRowExpression.Location = New System.Drawing.Point(236, 156)
        Me.ucrRowExpression.Name = "ucrRowExpression"
        Me.ucrRowExpression.Size = New System.Drawing.Size(132, 25)
        Me.ucrRowExpression.TabIndex = 345
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(238, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 344
        Me.Label1.Text = "Row Expression (Optional):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(233, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 343
        Me.Label2.Text = "Select Format:"
        '
        'cboSelectFormat
        '
        Me.cboSelectFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectFormat.FormattingEnabled = True
        Me.cboSelectFormat.Items.AddRange(New Object() {"Number", "Date", "Text"})
        Me.cboSelectFormat.Location = New System.Drawing.Point(236, 31)
        Me.cboSelectFormat.Name = "cboSelectFormat"
        Me.cboSelectFormat.Size = New System.Drawing.Size(132, 21)
        Me.cboSelectFormat.TabIndex = 342
        '
        'ucrReceiverMultipleCols
        '
        Me.ucrReceiverMultipleCols.AutoSize = True
        Me.ucrReceiverMultipleCols.frmParent = Nothing
        Me.ucrReceiverMultipleCols.Location = New System.Drawing.Point(236, 74)
        Me.ucrReceiverMultipleCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleCols.Name = "ucrReceiverMultipleCols"
        Me.ucrReceiverMultipleCols.Selector = Nothing
        Me.ucrReceiverMultipleCols.Size = New System.Drawing.Size(132, 55)
        Me.ucrReceiverMultipleCols.strNcFilePath = ""
        Me.ucrReceiverMultipleCols.TabIndex = 341
        Me.ucrReceiverMultipleCols.ucrSelector = Nothing
        '
        'lblFormats
        '
        Me.lblFormats.AutoSize = True
        Me.lblFormats.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFormats.Location = New System.Drawing.Point(233, 218)
        Me.lblFormats.Name = "lblFormats"
        Me.lblFormats.Size = New System.Drawing.Size(47, 13)
        Me.lblFormats.TabIndex = 340
        Me.lblFormats.Text = "Formats:"
        '
        'btnClearFormats
        '
        Me.btnClearFormats.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearFormats.Location = New System.Drawing.Point(517, 209)
        Me.btnClearFormats.Name = "btnClearFormats"
        Me.btnClearFormats.Size = New System.Drawing.Size(75, 23)
        Me.btnClearFormats.TabIndex = 339
        Me.btnClearFormats.Tag = ""
        Me.btnClearFormats.Text = "Clear"
        Me.btnClearFormats.UseVisualStyleBackColor = True
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(239, 58)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(56, 13)
        Me.lblColumns.TabIndex = 338
        Me.lblColumns.Text = "Column(s):"
        '
        'btnEnterFormat
        '
        Me.btnEnterFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnEnterFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEnterFormat.Location = New System.Drawing.Point(236, 186)
        Me.btnEnterFormat.Name = "btnEnterFormat"
        Me.btnEnterFormat.Size = New System.Drawing.Size(126, 23)
        Me.btnEnterFormat.TabIndex = 337
        Me.btnEnterFormat.Tag = ""
        Me.btnEnterFormat.Text = "Enter Format"
        Me.btnEnterFormat.UseVisualStyleBackColor = True
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(6, 4)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorCols.TabIndex = 336
        '
        'dataGridFormats
        '
        Me.dataGridFormats.AllowUserToAddRows = False
        Me.dataGridFormats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridFormats.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodnition, Me.colLabel, Me.colRow})
        Me.dataGridFormats.Location = New System.Drawing.Point(236, 235)
        Me.dataGridFormats.Name = "dataGridFormats"
        Me.dataGridFormats.ReadOnly = True
        Me.dataGridFormats.RowHeadersWidth = 62
        Me.dataGridFormats.Size = New System.Drawing.Size(361, 73)
        Me.dataGridFormats.TabIndex = 335
        '
        'colCodnition
        '
        Me.colCodnition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colCodnition.HeaderText = "Format"
        Me.colCodnition.MinimumWidth = 8
        Me.colCodnition.Name = "colCodnition"
        Me.colCodnition.ReadOnly = True
        Me.colCodnition.Width = 64
        '
        'colLabel
        '
        Me.colLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colLabel.HeaderText = "Column(s)"
        Me.colLabel.MinimumWidth = 8
        Me.colLabel.Name = "colLabel"
        Me.colLabel.ReadOnly = True
        Me.colLabel.Width = 78
        '
        'colRow
        '
        Me.colRow.HeaderText = "Row Expression"
        Me.colRow.Name = "colRow"
        Me.colRow.ReadOnly = True
        '
        'ucrNewCellFormats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrRowExpression)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSelectFormat)
        Me.Controls.Add(Me.ucrReceiverMultipleCols)
        Me.Controls.Add(Me.lblFormats)
        Me.Controls.Add(Me.btnClearFormats)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.btnEnterFormat)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.Controls.Add(Me.dataGridFormats)
        Me.Name = "ucrNewCellFormats"
        Me.Size = New System.Drawing.Size(602, 312)
        CType(Me.dataGridFormats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrRowExpression As ucrRowExpression
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboSelectFormat As ComboBox
    Friend WithEvents ucrReceiverMultipleCols As ucrReceiverMultiple
    Friend WithEvents lblFormats As Label
    Friend WithEvents btnClearFormats As Button
    Friend WithEvents lblColumns As Label
    Friend WithEvents btnEnterFormat As Button
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
    Friend WithEvents dataGridFormats As DataGridView
    Friend WithEvents colCodnition As DataGridViewTextBoxColumn
    Friend WithEvents colLabel As DataGridViewTextBoxColumn
    Friend WithEvents colRow As DataGridViewTextBoxColumn
End Class
