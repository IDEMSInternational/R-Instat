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
        Me.lblGroups = New System.Windows.Forms.Label()
        Me.btnClearGroups = New System.Windows.Forms.Button()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.btnAddGroupCondition = New System.Windows.Forms.Button()
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        Me.dataGridGroups = New System.Windows.Forms.DataGridView()
        Me.UcrReceiverMultiple1 = New instat.ucrReceiverMultiple()
        Me.lblCondition = New System.Windows.Forms.Label()
        Me.txtGroupLabel = New System.Windows.Forms.TextBox()
        Me.cboConditionOperator = New System.Windows.Forms.ComboBox()
        Me.lblGroupCondition = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLabel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFormat = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dataGridGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGroups
        '
        Me.lblGroups.AutoSize = True
        Me.lblGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroups.Location = New System.Drawing.Point(245, 169)
        Me.lblGroups.Name = "lblGroups"
        Me.lblGroups.Size = New System.Drawing.Size(55, 13)
        Me.lblGroups.TabIndex = 297
        Me.lblGroups.Text = "Spanners:"
        '
        'btnClearGroups
        '
        Me.btnClearGroups.Enabled = False
        Me.btnClearGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearGroups.Location = New System.Drawing.Point(534, 162)
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
        Me.lblColumns.Location = New System.Drawing.Point(245, 5)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(56, 13)
        Me.lblColumns.TabIndex = 294
        Me.lblColumns.Text = "Column(s):"
        '
        'btnAddGroupCondition
        '
        Me.btnAddGroupCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAddGroupCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddGroupCondition.Location = New System.Drawing.Point(472, 20)
        Me.btnAddGroupCondition.Name = "btnAddGroupCondition"
        Me.btnAddGroupCondition.Size = New System.Drawing.Size(99, 23)
        Me.btnAddGroupCondition.TabIndex = 292
        Me.btnAddGroupCondition.Tag = ""
        Me.btnAddGroupCondition.Text = "Add"
        Me.btnAddGroupCondition.UseVisualStyleBackColor = True
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
        'dataGridGroups
        '
        Me.dataGridGroups.AllowUserToAddRows = False
        Me.dataGridGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridGroups.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colLabel, Me.colValue, Me.colFormat})
        Me.dataGridGroups.Location = New System.Drawing.Point(240, 189)
        Me.dataGridGroups.Name = "dataGridGroups"
        Me.dataGridGroups.RowHeadersWidth = 62
        Me.dataGridGroups.Size = New System.Drawing.Size(369, 73)
        Me.dataGridGroups.TabIndex = 289
        '
        'UcrReceiverMultiple1
        '
        Me.UcrReceiverMultiple1.AutoSize = True
        Me.UcrReceiverMultiple1.frmParent = Nothing
        Me.UcrReceiverMultiple1.Location = New System.Drawing.Point(240, 21)
        Me.UcrReceiverMultiple1.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverMultiple1.Name = "UcrReceiverMultiple1"
        Me.UcrReceiverMultiple1.Selector = Nothing
        Me.UcrReceiverMultiple1.Size = New System.Drawing.Size(120, 78)
        Me.UcrReceiverMultiple1.strNcFilePath = ""
        Me.UcrReceiverMultiple1.TabIndex = 299
        Me.UcrReceiverMultiple1.ucrSelector = Nothing
        '
        'lblCondition
        '
        Me.lblCondition.AutoSize = True
        Me.lblCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCondition.Location = New System.Drawing.Point(370, 5)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(79, 13)
        Me.lblCondition.TabIndex = 301
        Me.lblCondition.Text = "Spanner Label:"
        '
        'txtGroupLabel
        '
        Me.txtGroupLabel.Location = New System.Drawing.Point(368, 23)
        Me.txtGroupLabel.Name = "txtGroupLabel"
        Me.txtGroupLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtGroupLabel.TabIndex = 300
        '
        'cboConditionOperator
        '
        Me.cboConditionOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConditionOperator.FormattingEnabled = True
        Me.cboConditionOperator.Items.AddRange(New Object() {"==", "<", "<=", ">", ">=", "!=", "Expression"})
        Me.cboConditionOperator.Location = New System.Drawing.Point(240, 132)
        Me.cboConditionOperator.Name = "cboConditionOperator"
        Me.cboConditionOperator.Size = New System.Drawing.Size(120, 21)
        Me.cboConditionOperator.TabIndex = 303
        '
        'lblGroupCondition
        '
        Me.lblGroupCondition.AutoSize = True
        Me.lblGroupCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupCondition.Location = New System.Drawing.Point(245, 115)
        Me.lblGroupCondition.Name = "lblGroupCondition"
        Me.lblGroupCondition.Size = New System.Drawing.Size(62, 13)
        Me.lblGroupCondition.TabIndex = 302
        Me.lblGroupCondition.Text = "Spanner Id:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(370, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 305
        Me.Label1.Text = "Spanner Label:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(368, 133)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 304
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(474, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 306
        Me.Button1.Tag = ""
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
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
        'colValue
        '
        Me.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colValue.HeaderText = "Value"
        Me.colValue.MinimumWidth = 8
        Me.colValue.Name = "colValue"
        Me.colValue.Width = 59
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
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cboConditionOperator)
        Me.Controls.Add(Me.lblGroupCondition)
        Me.Controls.Add(Me.lblCondition)
        Me.Controls.Add(Me.txtGroupLabel)
        Me.Controls.Add(Me.UcrReceiverMultiple1)
        Me.Controls.Add(Me.lblGroups)
        Me.Controls.Add(Me.btnClearGroups)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.btnAddGroupCondition)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.Controls.Add(Me.dataGridGroups)
        Me.Name = "ucrColumnSpanners"
        Me.Size = New System.Drawing.Size(615, 268)
        CType(Me.dataGridGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGroups As Label
    Friend WithEvents btnClearGroups As Button
    Friend WithEvents lblColumns As Label
    Friend WithEvents btnAddGroupCondition As Button
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
    Friend WithEvents dataGridGroups As DataGridView
    Friend WithEvents UcrReceiverMultiple1 As ucrReceiverMultiple
    Friend WithEvents lblCondition As Label
    Friend WithEvents txtGroupLabel As TextBox
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colLabel As DataGridViewTextBoxColumn
    Friend WithEvents colValue As DataGridViewTextBoxColumn
    Friend WithEvents colFormat As DataGridViewButtonColumn
    Friend WithEvents cboConditionOperator As ComboBox
    Friend WithEvents lblGroupCondition As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
