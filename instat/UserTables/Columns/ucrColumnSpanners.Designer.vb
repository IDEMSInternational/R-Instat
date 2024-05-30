<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrColumnSpanners
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
        Me.lblSpanners = New System.Windows.Forms.Label()
        Me.btnClearSpanners = New System.Windows.Forms.Button()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.btnAddColSpanner = New System.Windows.Forms.Button()
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        Me.dataGridSpanners = New System.Windows.Forms.DataGridView()
        Me.ucrReceiverMultipleCols = New instat.ucrReceiverMultiple()
        Me.lblColSpanner = New System.Windows.Forms.Label()
        Me.ucrInputColSpanner = New instat.ucrInputTextBox()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLabel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSpanners = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFormat = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dataGridSpanners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSpanners
        '
        Me.lblSpanners.AutoSize = True
        Me.lblSpanners.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSpanners.Location = New System.Drawing.Point(245, 118)
        Me.lblSpanners.Name = "lblSpanners"
        Me.lblSpanners.Size = New System.Drawing.Size(93, 13)
        Me.lblSpanners.TabIndex = 297
        Me.lblSpanners.Text = "Column Spanners:"
        '
        'btnClearSpanners
        '
        Me.btnClearSpanners.Enabled = False
        Me.btnClearSpanners.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearSpanners.Location = New System.Drawing.Point(534, 111)
        Me.btnClearSpanners.Name = "btnClearSpanners"
        Me.btnClearSpanners.Size = New System.Drawing.Size(75, 23)
        Me.btnClearSpanners.TabIndex = 295
        Me.btnClearSpanners.Tag = ""
        Me.btnClearSpanners.Text = "Clear"
        Me.btnClearSpanners.UseVisualStyleBackColor = True
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(245, 5)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(56, 13)
        Me.lblColumns.TabIndex = 294
        Me.lblColumns.Text = "Column(s):"
        '
        'btnAddColSpanner
        '
        Me.btnAddColSpanner.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAddColSpanner.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddColSpanner.Location = New System.Drawing.Point(472, 20)
        Me.btnAddColSpanner.Name = "btnAddColSpanner"
        Me.btnAddColSpanner.Size = New System.Drawing.Size(88, 23)
        Me.btnAddColSpanner.TabIndex = 292
        Me.btnAddColSpanner.Tag = ""
        Me.btnAddColSpanner.Text = "Add"
        Me.btnAddColSpanner.UseVisualStyleBackColor = True
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(4, 5)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorCols.TabIndex = 290
        '
        'dataGridSpanners
        '
        Me.dataGridSpanners.AllowUserToAddRows = False
        Me.dataGridSpanners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridSpanners.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colLabel, Me.colSpanners, Me.colFormat})
        Me.dataGridSpanners.Location = New System.Drawing.Point(240, 138)
        Me.dataGridSpanners.Name = "dataGridSpanners"
        Me.dataGridSpanners.RowHeadersWidth = 62
        Me.dataGridSpanners.Size = New System.Drawing.Size(369, 73)
        Me.dataGridSpanners.TabIndex = 289
        '
        'ucrReceiverMultipleCols
        '
        Me.ucrReceiverMultipleCols.AutoSize = True
        Me.ucrReceiverMultipleCols.frmParent = Nothing
        Me.ucrReceiverMultipleCols.Location = New System.Drawing.Point(240, 21)
        Me.ucrReceiverMultipleCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleCols.Name = "ucrReceiverMultipleCols"
        Me.ucrReceiverMultipleCols.Selector = Nothing
        Me.ucrReceiverMultipleCols.Size = New System.Drawing.Size(120, 78)
        Me.ucrReceiverMultipleCols.strNcFilePath = ""
        Me.ucrReceiverMultipleCols.TabIndex = 299
        Me.ucrReceiverMultipleCols.ucrSelector = Nothing
        '
        'lblColSpanner
        '
        Me.lblColSpanner.AutoSize = True
        Me.lblColSpanner.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColSpanner.Location = New System.Drawing.Point(370, 5)
        Me.lblColSpanner.Name = "lblColSpanner"
        Me.lblColSpanner.Size = New System.Drawing.Size(79, 13)
        Me.lblColSpanner.TabIndex = 301
        Me.lblColSpanner.Text = "Spanner Label:"
        '
        'ucrInputColSpanner
        '
        Me.ucrInputColSpanner.AddQuotesIfUnrecognised = True
        Me.ucrInputColSpanner.AutoSize = True
        Me.ucrInputColSpanner.IsMultiline = False
        Me.ucrInputColSpanner.IsReadOnly = False
        Me.ucrInputColSpanner.Location = New System.Drawing.Point(368, 22)
        Me.ucrInputColSpanner.Name = "ucrInputColSpanner"
        Me.ucrInputColSpanner.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputColSpanner.TabIndex = 307
        '
        'colId
        '
        Me.colId.HeaderText = "ID"
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        '
        'colLabel
        '
        Me.colLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colLabel.HeaderText = "Label"
        Me.colLabel.MinimumWidth = 8
        Me.colLabel.Name = "colLabel"
        Me.colLabel.Width = 58
        '
        'colSpanners
        '
        Me.colSpanners.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colSpanners.HeaderText = "Column(s)"
        Me.colSpanners.MinimumWidth = 8
        Me.colSpanners.Name = "colSpanners"
        Me.colSpanners.Width = 78
        '
        'colFormat
        '
        Me.colFormat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colFormat.HeaderText = ""
        Me.colFormat.MinimumWidth = 8
        Me.colFormat.Name = "colFormat"
        Me.colFormat.Width = 8
        '
        'ucrColumnSpanners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputColSpanner)
        Me.Controls.Add(Me.lblColSpanner)
        Me.Controls.Add(Me.ucrReceiverMultipleCols)
        Me.Controls.Add(Me.lblSpanners)
        Me.Controls.Add(Me.btnClearSpanners)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.btnAddColSpanner)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.Controls.Add(Me.dataGridSpanners)
        Me.Name = "ucrColumnSpanners"
        Me.Size = New System.Drawing.Size(612, 216)
        CType(Me.dataGridSpanners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSpanners As Label
    Friend WithEvents btnClearSpanners As Button
    Friend WithEvents lblColumns As Label
    Friend WithEvents btnAddColSpanner As Button
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
    Friend WithEvents dataGridSpanners As DataGridView
    Friend WithEvents ucrReceiverMultipleCols As ucrReceiverMultiple
    Friend WithEvents lblColSpanner As Label
    Friend WithEvents ucrInputColSpanner As ucrInputTextBox
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colLabel As DataGridViewTextBoxColumn
    Friend WithEvents colSpanners As DataGridViewTextBoxColumn
    Friend WithEvents colFormat As DataGridViewButtonColumn
End Class
