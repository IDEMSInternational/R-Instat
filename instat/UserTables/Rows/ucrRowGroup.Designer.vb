<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrRowGroup
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dataGridGroups = New System.Windows.Forms.DataGridView()
        Me.btnClearGroups = New System.Windows.Forms.Button()
        Me.btnAddCondition = New System.Windows.Forms.Button()
        Me.lblGroups = New System.Windows.Forms.Label()
        Me.lblCondition = New System.Windows.Forms.Label()
        Me.ucrInputGroupLabel = New instat.ucrInputTextBox()
        Me.btnStyle = New System.Windows.Forms.Button()
        Me.ucrRowExpression = New instat.ucrRowExpression()
        Me.lblGroupExpression = New System.Windows.Forms.Label()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLabel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodnition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStyleExpression = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataGridGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridGroups
        '
        Me.dataGridGroups.AllowUserToAddRows = False
        Me.dataGridGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridGroups.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colLabel, Me.colCodnition, Me.colStyleExpression})
        Me.dataGridGroups.Location = New System.Drawing.Point(12, 249)
        Me.dataGridGroups.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dataGridGroups.Name = "dataGridGroups"
        Me.dataGridGroups.ReadOnly = True
        Me.dataGridGroups.RowHeadersWidth = 62
        Me.dataGridGroups.Size = New System.Drawing.Size(484, 146)
        Me.dataGridGroups.TabIndex = 11
        '
        'btnClearGroups
        '
        Me.btnClearGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearGroups.Location = New System.Drawing.Point(368, 204)
        Me.btnClearGroups.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClearGroups.Name = "btnClearGroups"
        Me.btnClearGroups.Size = New System.Drawing.Size(118, 35)
        Me.btnClearGroups.TabIndex = 30
        Me.btnClearGroups.Tag = ""
        Me.btnClearGroups.Text = "Clear"
        Me.btnClearGroups.UseVisualStyleBackColor = True
        '
        'btnAddCondition
        '
        Me.btnAddCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAddCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddCondition.Location = New System.Drawing.Point(13, 170)
        Me.btnAddCondition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddCondition.Name = "btnAddCondition"
        Me.btnAddCondition.Size = New System.Drawing.Size(144, 35)
        Me.btnAddCondition.TabIndex = 25
        Me.btnAddCondition.Tag = ""
        Me.btnAddCondition.Text = "Add"
        Me.btnAddCondition.UseVisualStyleBackColor = True
        '
        'lblGroups
        '
        Me.lblGroups.AutoSize = True
        Me.lblGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroups.Location = New System.Drawing.Point(7, 220)
        Me.lblGroups.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGroups.Name = "lblGroups"
        Me.lblGroups.Size = New System.Drawing.Size(66, 20)
        Me.lblGroups.TabIndex = 32
        Me.lblGroups.Text = "Groups:"
        '
        'lblCondition
        '
        Me.lblCondition.AutoSize = True
        Me.lblCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCondition.Location = New System.Drawing.Point(9, 8)
        Me.lblCondition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(101, 20)
        Me.lblCondition.TabIndex = 282
        Me.lblCondition.Text = "Group Label:"
        '
        'ucrInputGroupLabel
        '
        Me.ucrInputGroupLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputGroupLabel.AutoSize = True
        Me.ucrInputGroupLabel.IsMultiline = False
        Me.ucrInputGroupLabel.IsReadOnly = False
        Me.ucrInputGroupLabel.Location = New System.Drawing.Point(8, 34)
        Me.ucrInputGroupLabel.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputGroupLabel.Name = "ucrInputGroupLabel"
        Me.ucrInputGroupLabel.Size = New System.Drawing.Size(180, 32)
        Me.ucrInputGroupLabel.TabIndex = 308
        '
        'btnStyle
        '
        Me.btnStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnStyle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnStyle.Location = New System.Drawing.Point(210, 101)
        Me.btnStyle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStyle.Name = "btnStyle"
        Me.btnStyle.Size = New System.Drawing.Size(74, 35)
        Me.btnStyle.TabIndex = 309
        Me.btnStyle.Tag = ""
        Me.btnStyle.Text = "Style"
        Me.btnStyle.UseVisualStyleBackColor = True
        '
        'ucrRowExpression
        '
        Me.ucrRowExpression.Location = New System.Drawing.Point(13, 108)
        Me.ucrRowExpression.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrRowExpression.Name = "ucrRowExpression"
        Me.ucrRowExpression.Size = New System.Drawing.Size(186, 38)
        Me.ucrRowExpression.TabIndex = 333
        '
        'lblGroupExpression
        '
        Me.lblGroupExpression.AutoSize = True
        Me.lblGroupExpression.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupExpression.Location = New System.Drawing.Point(9, 80)
        Me.lblGroupExpression.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGroupExpression.Name = "lblGroupExpression"
        Me.lblGroupExpression.Size = New System.Drawing.Size(129, 20)
        Me.lblGroupExpression.TabIndex = 334
        Me.lblGroupExpression.Text = "Group Condition:"
        '
        'colId
        '
        Me.colId.HeaderText = "Id"
        Me.colId.MinimumWidth = 8
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        Me.colId.Width = 70
        '
        'colLabel
        '
        Me.colLabel.HeaderText = "Label"
        Me.colLabel.MinimumWidth = 8
        Me.colLabel.Name = "colLabel"
        Me.colLabel.ReadOnly = True
        Me.colLabel.Width = 70
        '
        'colCodnition
        '
        Me.colCodnition.HeaderText = "Condition"
        Me.colCodnition.MinimumWidth = 8
        Me.colCodnition.Name = "colCodnition"
        Me.colCodnition.ReadOnly = True
        Me.colCodnition.Width = 90
        '
        'colStyleExpression
        '
        Me.colStyleExpression.HeaderText = "Style Expression"
        Me.colStyleExpression.MinimumWidth = 8
        Me.colStyleExpression.Name = "colStyleExpression"
        Me.colStyleExpression.ReadOnly = True
        Me.colStyleExpression.Width = 90
        '
        'ucrRowGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblGroupExpression)
        Me.Controls.Add(Me.ucrRowExpression)
        Me.Controls.Add(Me.btnStyle)
        Me.Controls.Add(Me.ucrInputGroupLabel)
        Me.Controls.Add(Me.lblCondition)
        Me.Controls.Add(Me.lblGroups)
        Me.Controls.Add(Me.btnClearGroups)
        Me.Controls.Add(Me.btnAddCondition)
        Me.Controls.Add(Me.dataGridGroups)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucrRowGroup"
        Me.Size = New System.Drawing.Size(507, 403)
        CType(Me.dataGridGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGridGroups As DataGridView
    Friend WithEvents btnClearGroups As Button
    Friend WithEvents btnAddCondition As Button
    Friend WithEvents lblGroups As Label
    Friend WithEvents lblCondition As Label
    Friend WithEvents ucrInputGroupLabel As ucrInputTextBox
    Friend WithEvents btnStyle As Button
    Friend WithEvents ucrRowExpression As ucrRowExpression
    Friend WithEvents lblGroupExpression As Label
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colLabel As DataGridViewTextBoxColumn
    Friend WithEvents colCodnition As DataGridViewTextBoxColumn
    Friend WithEvents colStyleExpression As DataGridViewTextBoxColumn
End Class
