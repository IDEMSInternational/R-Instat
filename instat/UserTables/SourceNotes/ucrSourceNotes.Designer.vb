<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrSourceNotes
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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSourceNotes = New System.Windows.Forms.Label()
        Me.btnClearNotes = New System.Windows.Forms.Button()
        CType(Me.dataGridSourceNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridSourceNotes
        '
        Me.dataGridSourceNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridSourceNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridSourceNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.dataGridSourceNotes.Location = New System.Drawing.Point(3, 23)
        Me.dataGridSourceNotes.Name = "dataGridSourceNotes"
        Me.dataGridSourceNotes.RowHeadersWidth = 62
        Me.dataGridSourceNotes.Size = New System.Drawing.Size(464, 197)
        Me.dataGridSourceNotes.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Note Text"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'lblSourceNotes
        '
        Me.lblSourceNotes.AutoSize = True
        Me.lblSourceNotes.Location = New System.Drawing.Point(6, 7)
        Me.lblSourceNotes.Name = "lblSourceNotes"
        Me.lblSourceNotes.Size = New System.Drawing.Size(73, 13)
        Me.lblSourceNotes.TabIndex = 8
        Me.lblSourceNotes.Text = "Source notes:"
        '
        'btnClearNotes
        '
        Me.btnClearNotes.Enabled = False
        Me.btnClearNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearNotes.Location = New System.Drawing.Point(392, 0)
        Me.btnClearNotes.Name = "btnClearNotes"
        Me.btnClearNotes.Size = New System.Drawing.Size(75, 23)
        Me.btnClearNotes.TabIndex = 296
        Me.btnClearNotes.Tag = ""
        Me.btnClearNotes.Text = "Clear"
        Me.btnClearNotes.UseVisualStyleBackColor = True
        '
        'ucrSourceNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnClearNotes)
        Me.Controls.Add(Me.dataGridSourceNotes)
        Me.Controls.Add(Me.lblSourceNotes)
        Me.Name = "ucrSourceNotes"
        Me.Size = New System.Drawing.Size(470, 223)
        CType(Me.dataGridSourceNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGridSourceNotes As DataGridView
    Friend WithEvents lblSourceNotes As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents btnClearNotes As Button
End Class
