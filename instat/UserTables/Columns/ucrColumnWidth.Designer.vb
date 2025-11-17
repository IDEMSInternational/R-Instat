<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrColumnWidth
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
        Me.lblColumnWidths = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ucrSelectorByDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.colWidthExpression = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblColWidth = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleCols = New instat.ucrReceiverMultiple()
        Me.ucrNudWidth = New instat.ucrNud()
        Me.ucrSelectorByTableDF = New instat.ucrSelectorByOutputObject()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblColumnWidths
        '
        Me.lblColumnWidths.AutoSize = True
        Me.lblColumnWidths.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnWidths.Location = New System.Drawing.Point(245, 171)
        Me.lblColumnWidths.Name = "lblColumnWidths"
        Me.lblColumnWidths.Size = New System.Drawing.Size(81, 13)
        Me.lblColumnWidths.TabIndex = 313
        Me.lblColumnWidths.Text = "Column Widths:"
        '
        'btnClear
        '
        Me.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClear.Location = New System.Drawing.Point(534, 162)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 312
        Me.btnClear.Tag = ""
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(242, 5)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(56, 13)
        Me.lblColumns.TabIndex = 311
        Me.lblColumns.Text = "Column(s):"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAdd.Location = New System.Drawing.Point(243, 138)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 23)
        Me.btnAdd.TabIndex = 310
        Me.btnAdd.Tag = ""
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
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
        Me.ucrSelectorByDF.TabIndex = 309
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colWidthExpression})
        Me.dataGrid.Location = New System.Drawing.Point(240, 188)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.RowHeadersWidth = 62
        Me.dataGrid.Size = New System.Drawing.Size(369, 73)
        Me.dataGrid.TabIndex = 308
        '
        'colWidthExpression
        '
        Me.colWidthExpression.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colWidthExpression.HeaderText = "Width Expression"
        Me.colWidthExpression.MinimumWidth = 8
        Me.colWidthExpression.Name = "colWidthExpression"
        Me.colWidthExpression.ReadOnly = True
        '
        'lblColWidth
        '
        Me.lblColWidth.AutoSize = True
        Me.lblColWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColWidth.Location = New System.Drawing.Point(245, 94)
        Me.lblColWidth.Name = "lblColWidth"
        Me.lblColWidth.Size = New System.Drawing.Size(38, 13)
        Me.lblColWidth.TabIndex = 315
        Me.lblColWidth.Text = "Width:"
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
        Me.ucrReceiverMultipleCols.TabIndex = 314
        Me.ucrReceiverMultipleCols.ucrSelector = Nothing
        '
        'ucrNudWidth
        '
        Me.ucrNudWidth.AutoSize = True
        Me.ucrNudWidth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidth.Location = New System.Drawing.Point(246, 110)
        Me.ucrNudWidth.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudWidth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Name = "ucrNudWidth"
        Me.ucrNudWidth.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWidth.TabIndex = 318
        Me.ucrNudWidth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSelectorByTableDF
        '
        Me.ucrSelectorByTableDF.AutoSize = True
        Me.ucrSelectorByTableDF.bShowHiddenColumns = False
        Me.ucrSelectorByTableDF.Location = New System.Drawing.Point(2, 2)
        Me.ucrSelectorByTableDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByTableDF.Name = "ucrSelectorByTableDF"
        Me.ucrSelectorByTableDF.Size = New System.Drawing.Size(216, 194)
        Me.ucrSelectorByTableDF.TabIndex = 361
        '
        'ucrColumnWidth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrNudWidth)
        Me.Controls.Add(Me.lblColumnWidths)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.lblColWidth)
        Me.Controls.Add(Me.ucrReceiverMultipleCols)
        Me.Controls.Add(Me.ucrSelectorByTableDF)
        Me.Controls.Add(Me.ucrSelectorByDF)
        Me.Name = "ucrColumnWidth"
        Me.Size = New System.Drawing.Size(613, 267)
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblColumnWidths As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lblColumns As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents ucrSelectorByDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents colWidthExpression As DataGridViewTextBoxColumn
    Friend WithEvents lblColWidth As Label
    Friend WithEvents ucrReceiverMultipleCols As ucrReceiverMultiple
    Friend WithEvents ucrNudWidth As ucrNud
    Friend WithEvents ucrSelectorByTableDF As ucrSelectorByOutputObject
End Class
