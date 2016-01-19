<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFileNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.ucrBase = New instat.ucrButtons()
        Me.lblRows = New System.Windows.Forms.Label()
        Me.txtRows = New System.Windows.Forms.TextBox()
        Me.txtColumns = New System.Windows.Forms.TextBox()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 170)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 61)
        Me.ucrBase.TabIndex = 0
        '
        'lblRows
        '
        Me.lblRows.AutoSize = True
        Me.lblRows.Location = New System.Drawing.Point(37, 35)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(37, 13)
        Me.lblRows.TabIndex = 1
        Me.lblRows.Text = "Rows:"
        '
        'txtRows
        '
        Me.txtRows.Location = New System.Drawing.Point(137, 35)
        Me.txtRows.Name = "txtRows"
        Me.txtRows.Size = New System.Drawing.Size(39, 20)
        Me.txtRows.TabIndex = 2
        '
        'txtColumns
        '
        Me.txtColumns.Location = New System.Drawing.Point(137, 75)
        Me.txtColumns.Name = "txtColumns"
        Me.txtColumns.Size = New System.Drawing.Size(39, 20)
        Me.txtColumns.TabIndex = 4
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Location = New System.Drawing.Point(37, 78)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(50, 13)
        Me.lblColumns.TabIndex = 3
        Me.lblColumns.Text = "Columns:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(137, 119)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(139, 20)
        Me.txtName.TabIndex = 5
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(37, 122)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(94, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "New Sheet Name:"
        '
        'dlgFileNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 229)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtColumns)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.txtRows)
        Me.Controls.Add(Me.lblRows)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgFileNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New file"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblColumns As Label
    Friend WithEvents txtColumns As TextBox
    Friend WithEvents txtRows As TextBox
    Friend WithEvents lblRows As Label
End Class
