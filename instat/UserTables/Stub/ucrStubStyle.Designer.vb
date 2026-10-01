<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrStubStyle
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
        Me.btnEnterStyle = New System.Windows.Forms.Button()
        Me.lblFormats = New System.Windows.Forms.Label()
        Me.btnClearStyle = New System.Windows.Forms.Button()
        Me.dataGridFormats = New System.Windows.Forms.DataGridView()
        Me.colStyles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrRowExpression = New instat.ucrRowExpression()
        CType(Me.dataGridFormats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnterStyle
        '
        Me.btnEnterStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnEnterStyle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEnterStyle.Location = New System.Drawing.Point(8, 54)
        Me.btnEnterStyle.Name = "btnEnterStyle"
        Me.btnEnterStyle.Size = New System.Drawing.Size(126, 23)
        Me.btnEnterStyle.TabIndex = 335
        Me.btnEnterStyle.Tag = ""
        Me.btnEnterStyle.Text = "Enter Style"
        Me.btnEnterStyle.UseVisualStyleBackColor = True
        '
        'lblFormats
        '
        Me.lblFormats.AutoSize = True
        Me.lblFormats.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFormats.Location = New System.Drawing.Point(6, 85)
        Me.lblFormats.Name = "lblFormats"
        Me.lblFormats.Size = New System.Drawing.Size(38, 13)
        Me.lblFormats.TabIndex = 338
        Me.lblFormats.Text = "Styles:"
        '
        'btnClearStyle
        '
        Me.btnClearStyle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearStyle.Location = New System.Drawing.Point(290, 76)
        Me.btnClearStyle.Name = "btnClearStyle"
        Me.btnClearStyle.Size = New System.Drawing.Size(75, 23)
        Me.btnClearStyle.TabIndex = 337
        Me.btnClearStyle.Tag = ""
        Me.btnClearStyle.Text = "Clear"
        Me.btnClearStyle.UseVisualStyleBackColor = True
        '
        'dataGridFormats
        '
        Me.dataGridFormats.AllowUserToAddRows = False
        Me.dataGridFormats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridFormats.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colStyles})
        Me.dataGridFormats.Location = New System.Drawing.Point(8, 102)
        Me.dataGridFormats.Name = "dataGridFormats"
        Me.dataGridFormats.RowHeadersWidth = 62
        Me.dataGridFormats.Size = New System.Drawing.Size(361, 73)
        Me.dataGridFormats.TabIndex = 336
        '
        'colStyles
        '
        Me.colStyles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colStyles.HeaderText = "Style Expressions"
        Me.colStyles.MinimumWidth = 8
        Me.colStyles.Name = "colStyles"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 333
        Me.Label1.Text = "Row Expression(Optional):"
        '
        'ucrRowExpression
        '
        Me.ucrRowExpression.Location = New System.Drawing.Point(3, 20)
        Me.ucrRowExpression.Name = "ucrRowExpression"
        Me.ucrRowExpression.Size = New System.Drawing.Size(134, 26)
        Me.ucrRowExpression.TabIndex = 339
        '
        'ucrStubStyle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrRowExpression)
        Me.Controls.Add(Me.lblFormats)
        Me.Controls.Add(Me.btnClearStyle)
        Me.Controls.Add(Me.dataGridFormats)
        Me.Controls.Add(Me.btnEnterStyle)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucrStubStyle"
        Me.Size = New System.Drawing.Size(372, 177)
        CType(Me.dataGridFormats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnterStyle As Button
    Friend WithEvents lblFormats As Label
    Friend WithEvents btnClearStyle As Button
    Friend WithEvents dataGridFormats As DataGridView
    Friend WithEvents colStyles As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrRowExpression As ucrRowExpression
End Class
