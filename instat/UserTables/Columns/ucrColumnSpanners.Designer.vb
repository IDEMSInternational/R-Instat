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
        Me.ucrSelectorByDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.dataGridColSpanners = New System.Windows.Forms.DataGridView()
        Me.colLabel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSpanners = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStyleExpression = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ucrReceiverMultipleCols = New instat.ucrReceiverMultiple()
        Me.lblColSpanner = New System.Windows.Forms.Label()
        Me.ucrInputColSpanner = New instat.ucrInputTextBox()
        Me.btnStyle = New System.Windows.Forms.Button()
        Me.ucrSelectorByTableDF = New instat.ucrSelectorByOutputObject()
        CType(Me.dataGridColSpanners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSpanners
        '
        Me.lblSpanners.AutoSize = True
        Me.lblSpanners.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSpanners.Location = New System.Drawing.Point(245, 171)
        Me.lblSpanners.Name = "lblSpanners"
        Me.lblSpanners.Size = New System.Drawing.Size(93, 13)
        Me.lblSpanners.TabIndex = 297
        Me.lblSpanners.Text = "Column Spanners:"
        '
        'btnClearSpanners
        '
        Me.btnClearSpanners.Enabled = False
        Me.btnClearSpanners.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearSpanners.Location = New System.Drawing.Point(476, 162)
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
        Me.lblColumns.Location = New System.Drawing.Point(242, 5)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(56, 13)
        Me.lblColumns.TabIndex = 294
        Me.lblColumns.Text = "Column(s):"
        '
        'btnAddColSpanner
        '
        Me.btnAddColSpanner.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAddColSpanner.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddColSpanner.Location = New System.Drawing.Point(243, 138)
        Me.btnAddColSpanner.Name = "btnAddColSpanner"
        Me.btnAddColSpanner.Size = New System.Drawing.Size(88, 23)
        Me.btnAddColSpanner.TabIndex = 292
        Me.btnAddColSpanner.Tag = ""
        Me.btnAddColSpanner.Text = "Add"
        Me.btnAddColSpanner.UseVisualStyleBackColor = True
        '
        'ucrSelectorByDF
        '
        Me.ucrSelectorByDF.AutoSize = True
        Me.ucrSelectorByDF.bDropUnusedFilterLevels = False
        Me.ucrSelectorByDF.bShowHiddenColumns = False
        Me.ucrSelectorByDF.bUseCurrentFilter = True
        Me.ucrSelectorByDF.Location = New System.Drawing.Point(4, 5)
        Me.ucrSelectorByDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDF.Name = "ucrSelectorByDF"
        Me.ucrSelectorByDF.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorByDF.TabIndex = 290
        '
        'dataGridColSpanners
        '
        Me.dataGridColSpanners.AllowUserToAddRows = False
        Me.dataGridColSpanners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridColSpanners.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLabel, Me.colSpanners, Me.colStyleExpression})
        Me.dataGridColSpanners.Location = New System.Drawing.Point(240, 188)
        Me.dataGridColSpanners.Name = "dataGridColSpanners"
        Me.dataGridColSpanners.ReadOnly = True
        Me.dataGridColSpanners.RowHeadersWidth = 62
        Me.dataGridColSpanners.Size = New System.Drawing.Size(311, 73)
        Me.dataGridColSpanners.TabIndex = 289
        '
        'colLabel
        '
        Me.colLabel.HeaderText = "Label"
        Me.colLabel.MinimumWidth = 8
        Me.colLabel.Name = "colLabel"
        Me.colLabel.ReadOnly = True
        Me.colLabel.Width = 60
        '
        'colSpanners
        '
        Me.colSpanners.HeaderText = "Column(s)"
        Me.colSpanners.MinimumWidth = 8
        Me.colSpanners.Name = "colSpanners"
        Me.colSpanners.ReadOnly = True
        Me.colSpanners.Width = 90
        '
        'colStyleExpression
        '
        Me.colStyleExpression.HeaderText = "Style Expression"
        Me.colStyleExpression.MinimumWidth = 8
        Me.colStyleExpression.Name = "colStyleExpression"
        Me.colStyleExpression.ReadOnly = True
        Me.colStyleExpression.Width = 90
        '
        'ucrReceiverMultipleCols
        '
        Me.ucrReceiverMultipleCols.AutoSize = True
        Me.ucrReceiverMultipleCols.frmParent = Nothing
        Me.ucrReceiverMultipleCols.Location = New System.Drawing.Point(240, 21)
        Me.ucrReceiverMultipleCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleCols.Name = "ucrReceiverMultipleCols"
        Me.ucrReceiverMultipleCols.Selector = Nothing
        Me.ucrReceiverMultipleCols.Size = New System.Drawing.Size(120, 64)
        Me.ucrReceiverMultipleCols.strNcFilePath = ""
        Me.ucrReceiverMultipleCols.TabIndex = 299
        Me.ucrReceiverMultipleCols.ucrSelector = Nothing
        '
        'lblColSpanner
        '
        Me.lblColSpanner.AutoSize = True
        Me.lblColSpanner.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColSpanner.Location = New System.Drawing.Point(245, 94)
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
        Me.ucrInputColSpanner.Location = New System.Drawing.Point(243, 111)
        Me.ucrInputColSpanner.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputColSpanner.Name = "ucrInputColSpanner"
        Me.ucrInputColSpanner.Size = New System.Drawing.Size(117, 21)
        Me.ucrInputColSpanner.TabIndex = 307
        '
        'btnStyle
        '
        Me.btnStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnStyle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnStyle.Location = New System.Drawing.Point(366, 108)
        Me.btnStyle.Name = "btnStyle"
        Me.btnStyle.Size = New System.Drawing.Size(49, 23)
        Me.btnStyle.TabIndex = 308
        Me.btnStyle.Tag = ""
        Me.btnStyle.Text = "Style"
        Me.btnStyle.UseVisualStyleBackColor = True
        '
        'ucrSelectorByTableDF
        '
        Me.ucrSelectorByTableDF.AutoSize = True
        Me.ucrSelectorByTableDF.bShowHiddenColumns = False
        Me.ucrSelectorByTableDF.Location = New System.Drawing.Point(3, 4)
        Me.ucrSelectorByTableDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByTableDF.Name = "ucrSelectorByTableDF"
        Me.ucrSelectorByTableDF.Size = New System.Drawing.Size(216, 194)
        Me.ucrSelectorByTableDF.TabIndex = 361
        '
        'ucrColumnSpanners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSelectorByTableDF)
        Me.Controls.Add(Me.btnStyle)
        Me.Controls.Add(Me.ucrInputColSpanner)
        Me.Controls.Add(Me.lblColSpanner)
        Me.Controls.Add(Me.ucrReceiverMultipleCols)
        Me.Controls.Add(Me.lblSpanners)
        Me.Controls.Add(Me.btnClearSpanners)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.btnAddColSpanner)
        Me.Controls.Add(Me.ucrSelectorByDF)
        Me.Controls.Add(Me.dataGridColSpanners)
        Me.Name = "ucrColumnSpanners"
        Me.Size = New System.Drawing.Size(554, 265)
        CType(Me.dataGridColSpanners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSpanners As Label
    Friend WithEvents btnClearSpanners As Button
    Friend WithEvents lblColumns As Label
    Friend WithEvents btnAddColSpanner As Button
    Friend WithEvents ucrSelectorByDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents dataGridColSpanners As DataGridView
    Friend WithEvents ucrReceiverMultipleCols As ucrReceiverMultiple
    Friend WithEvents lblColSpanner As Label
    Friend WithEvents ucrInputColSpanner As ucrInputTextBox
    Friend WithEvents btnStyle As Button
    Friend WithEvents colLabel As DataGridViewTextBoxColumn
    Friend WithEvents colSpanners As DataGridViewTextBoxColumn
    Friend WithEvents colStyleExpression As DataGridViewTextBoxColumn
    Friend WithEvents ucrSelectorByTableDF As ucrSelectorByOutputObject
End Class
