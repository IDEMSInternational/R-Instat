<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrCellStyles
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
        Me.lblRowExpression = New System.Windows.Forms.Label()
        Me.lblFormats = New System.Windows.Forms.Label()
        Me.btnClearFormats = New System.Windows.Forms.Button()
        Me.dataGridFormats = New System.Windows.Forms.DataGridView()
        Me.colStyles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEnterStyle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrRowExpression = New instat.ucrRowExpression()
        Me.ucrReceiverMultipleCols = New instat.ucrReceiverMultiple()
        Me.ucrSelectorByDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorByTableDF = New instat.ucrSelectorByOutputObject()
        CType(Me.dataGridFormats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRowExpression
        '
        Me.lblRowExpression.AutoSize = True
        Me.lblRowExpression.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRowExpression.Location = New System.Drawing.Point(245, 86)
        Me.lblRowExpression.Name = "lblRowExpression"
        Me.lblRowExpression.Size = New System.Drawing.Size(134, 13)
        Me.lblRowExpression.TabIndex = 329
        Me.lblRowExpression.Text = "Row Expression (Optional):"
        '
        'lblFormats
        '
        Me.lblFormats.AutoSize = True
        Me.lblFormats.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFormats.Location = New System.Drawing.Point(236, 166)
        Me.lblFormats.Name = "lblFormats"
        Me.lblFormats.Size = New System.Drawing.Size(38, 13)
        Me.lblFormats.TabIndex = 326
        Me.lblFormats.Text = "Styles:"
        '
        'btnClearFormats
        '
        Me.btnClearFormats.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearFormats.Location = New System.Drawing.Point(475, 157)
        Me.btnClearFormats.Name = "btnClearFormats"
        Me.btnClearFormats.Size = New System.Drawing.Size(75, 23)
        Me.btnClearFormats.TabIndex = 5
        Me.btnClearFormats.Tag = ""
        Me.btnClearFormats.Text = "Clear"
        Me.btnClearFormats.UseVisualStyleBackColor = True
        '
        'dataGridFormats
        '
        Me.dataGridFormats.AllowUserToAddRows = False
        Me.dataGridFormats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridFormats.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colStyles})
        Me.dataGridFormats.Location = New System.Drawing.Point(239, 183)
        Me.dataGridFormats.Name = "dataGridFormats"
        Me.dataGridFormats.RowHeadersWidth = 62
        Me.dataGridFormats.Size = New System.Drawing.Size(315, 73)
        Me.dataGridFormats.TabIndex = 6
        '
        'colStyles
        '
        Me.colStyles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colStyles.HeaderText = "Style Expressions"
        Me.colStyles.MinimumWidth = 8
        Me.colStyles.Name = "colStyles"
        '
        'btnEnterStyle
        '
        Me.btnEnterStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnEnterStyle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEnterStyle.Location = New System.Drawing.Point(244, 136)
        Me.btnEnterStyle.Name = "btnEnterStyle"
        Me.btnEnterStyle.Size = New System.Drawing.Size(126, 23)
        Me.btnEnterStyle.TabIndex = 4
        Me.btnEnterStyle.Tag = ""
        Me.btnEnterStyle.Text = "Enter Style"
        Me.btnEnterStyle.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(246, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 331
        Me.Label1.Text = "Column(s):"
        '
        'ucrRowExpression
        '
        Me.ucrRowExpression.Location = New System.Drawing.Point(244, 103)
        Me.ucrRowExpression.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrRowExpression.Name = "ucrRowExpression"
        Me.ucrRowExpression.Size = New System.Drawing.Size(124, 25)
        Me.ucrRowExpression.TabIndex = 332
        '
        'ucrReceiverMultipleCols
        '
        Me.ucrReceiverMultipleCols.AutoSize = True
        Me.ucrReceiverMultipleCols.frmParent = Nothing
        Me.ucrReceiverMultipleCols.Location = New System.Drawing.Point(244, 23)
        Me.ucrReceiverMultipleCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleCols.Name = "ucrReceiverMultipleCols"
        Me.ucrReceiverMultipleCols.Selector = Nothing
        Me.ucrReceiverMultipleCols.Size = New System.Drawing.Size(120, 55)
        Me.ucrReceiverMultipleCols.strNcFilePath = ""
        Me.ucrReceiverMultipleCols.TabIndex = 2
        Me.ucrReceiverMultipleCols.ucrSelector = Nothing
        '
        'ucrSelectorByDF
        '
        Me.ucrSelectorByDF.AutoSize = True
        Me.ucrSelectorByDF.bDropUnusedFilterLevels = False
        Me.ucrSelectorByDF.bShowHiddenColumns = False
        Me.ucrSelectorByDF.bUseCurrentFilter = True
        Me.ucrSelectorByDF.Location = New System.Drawing.Point(7, 7)
        Me.ucrSelectorByDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDF.Name = "ucrSelectorByDF"
        Me.ucrSelectorByDF.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorByDF.TabIndex = 1
        '
        'ucrSelectorByTableDF
        '
        Me.ucrSelectorByTableDF.AutoSize = True
        Me.ucrSelectorByTableDF.bShowHiddenColumns = False
        Me.ucrSelectorByTableDF.Location = New System.Drawing.Point(3, 4)
        Me.ucrSelectorByTableDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByTableDF.Name = "ucrSelectorByTableDF"
        Me.ucrSelectorByTableDF.Size = New System.Drawing.Size(216, 194)
        Me.ucrSelectorByTableDF.TabIndex = 377
        '
        'ucrCellStyles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSelectorByTableDF)
        Me.Controls.Add(Me.ucrRowExpression)
        Me.Controls.Add(Me.ucrReceiverMultipleCols)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRowExpression)
        Me.Controls.Add(Me.lblFormats)
        Me.Controls.Add(Me.btnClearFormats)
        Me.Controls.Add(Me.btnEnterStyle)
        Me.Controls.Add(Me.dataGridFormats)
        Me.Controls.Add(Me.ucrSelectorByDF)
        Me.Name = "ucrCellStyles"
        Me.Size = New System.Drawing.Size(557, 259)
        CType(Me.dataGridFormats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRowExpression As Label
    Friend WithEvents lblFormats As Label
    Friend WithEvents btnClearFormats As Button
    Friend WithEvents ucrSelectorByDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents dataGridFormats As DataGridView
    Friend WithEvents btnEnterStyle As Button
    Friend WithEvents colStyles As DataGridViewTextBoxColumn
    Friend WithEvents ucrReceiverMultipleCols As ucrReceiverMultiple
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrRowExpression As ucrRowExpression
    Friend WithEvents ucrSelectorByTableDF As ucrSelectorByOutputObject
End Class
