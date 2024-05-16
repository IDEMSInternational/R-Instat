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
        Me.dataGridSourceNotes = New System.Windows.Forms.DataGridView()
        Me.lblRowGroups = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colOperator = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataGridSourceNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridSourceNotes
        '
        Me.dataGridSourceNotes.AllowUserToAddRows = False
        Me.dataGridSourceNotes.AllowUserToDeleteRows = False
        Me.dataGridSourceNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridSourceNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridSourceNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.colName, Me.colOperator, Me.colValue})
        Me.dataGridSourceNotes.Location = New System.Drawing.Point(3, 17)
        Me.dataGridSourceNotes.Name = "dataGridSourceNotes"
        Me.dataGridSourceNotes.RowHeadersWidth = 62
        Me.dataGridSourceNotes.Size = New System.Drawing.Size(480, 205)
        Me.dataGridSourceNotes.TabIndex = 11
        '
        'lblRowGroups
        '
        Me.lblRowGroups.AutoSize = True
        Me.lblRowGroups.Location = New System.Drawing.Point(0, 1)
        Me.lblRowGroups.Name = "lblRowGroups"
        Me.lblRowGroups.Size = New System.Drawing.Size(69, 13)
        Me.lblRowGroups.TabIndex = 10
        Me.lblRowGroups.Text = "Row Groups:"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Group Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'colName
        '
        Me.colName.HeaderText = "Column"
        Me.colName.Name = "colName"
        '
        'colOperator
        '
        Me.colOperator.HeaderText = "Operator"
        Me.colOperator.Name = "colOperator"
        '
        'colValue
        '
        Me.colValue.HeaderText = "Value"
        Me.colValue.Name = "colValue"
        '
        'ucrRowGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dataGridSourceNotes)
        Me.Controls.Add(Me.lblRowGroups)
        Me.Name = "ucrRowGroup"
        Me.Size = New System.Drawing.Size(486, 225)
        CType(Me.dataGridSourceNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGridSourceNotes As DataGridView
    Friend WithEvents lblRowGroups As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewComboBoxColumn
    Friend WithEvents colOperator As DataGridViewComboBoxColumn
    Friend WithEvents colValue As DataGridViewTextBoxColumn
End Class
