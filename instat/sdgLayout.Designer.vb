<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgLayout
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
        Me.tbcLayout = New System.Windows.Forms.TabControl()
        Me.tbpSimple = New System.Windows.Forms.TabPage()
        Me.tbpGeneral = New System.Windows.Forms.TabPage()
        Me.nudRows = New System.Windows.Forms.NumericUpDown()
        Me.nudColumns = New System.Windows.Forms.NumericUpDown()
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.lblNumberofColumns = New System.Windows.Forms.Label()
        Me.ucrsdgLayoutBase = New instat.ucrButtonsSubdialogue()
        Me.tbcLayout.SuspendLayout()
        Me.tbpSimple.SuspendLayout()
        CType(Me.nudRows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcLayout
        '
        Me.tbcLayout.Controls.Add(Me.tbpSimple)
        Me.tbcLayout.Controls.Add(Me.tbpGeneral)
        Me.tbcLayout.Location = New System.Drawing.Point(13, 13)
        Me.tbcLayout.Name = "tbcLayout"
        Me.tbcLayout.SelectedIndex = 0
        Me.tbcLayout.Size = New System.Drawing.Size(259, 183)
        Me.tbcLayout.TabIndex = 0
        '
        'tbpSimple
        '
        Me.tbpSimple.Controls.Add(Me.lblNumberofColumns)
        Me.tbpSimple.Controls.Add(Me.lblNumberofRows)
        Me.tbpSimple.Controls.Add(Me.nudColumns)
        Me.tbpSimple.Controls.Add(Me.nudRows)
        Me.tbpSimple.Location = New System.Drawing.Point(4, 22)
        Me.tbpSimple.Name = "tbpSimple"
        Me.tbpSimple.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSimple.Size = New System.Drawing.Size(251, 157)
        Me.tbpSimple.TabIndex = 0
        Me.tbpSimple.Text = "Simple"
        Me.tbpSimple.UseVisualStyleBackColor = True
        '
        'tbpGeneral
        '
        Me.tbpGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tbpGeneral.Name = "tbpGeneral"
        Me.tbpGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGeneral.Size = New System.Drawing.Size(251, 157)
        Me.tbpGeneral.TabIndex = 1
        Me.tbpGeneral.Text = "General"
        Me.tbpGeneral.UseVisualStyleBackColor = True
        '
        'nudRows
        '
        Me.nudRows.Location = New System.Drawing.Point(117, 20)
        Me.nudRows.Name = "nudRows"
        Me.nudRows.Size = New System.Drawing.Size(95, 20)
        Me.nudRows.TabIndex = 0
        Me.nudRows.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'nudColumns
        '
        Me.nudColumns.Location = New System.Drawing.Point(117, 59)
        Me.nudColumns.Name = "nudColumns"
        Me.nudColumns.Size = New System.Drawing.Size(95, 20)
        Me.nudColumns.TabIndex = 0
        Me.nudColumns.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblNumberofRows
        '
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.Location = New System.Drawing.Point(7, 22)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(86, 13)
        Me.lblNumberofRows.TabIndex = 1
        Me.lblNumberofRows.Text = "Number of Rows"
        '
        'lblNumberofColumns
        '
        Me.lblNumberofColumns.AutoSize = True
        Me.lblNumberofColumns.Location = New System.Drawing.Point(8, 61)
        Me.lblNumberofColumns.Name = "lblNumberofColumns"
        Me.lblNumberofColumns.Size = New System.Drawing.Size(99, 13)
        Me.lblNumberofColumns.TabIndex = 1
        Me.lblNumberofColumns.Text = "Number of Columns"
        '
        'ucrsdgLayoutBase
        '
        Me.ucrsdgLayoutBase.Location = New System.Drawing.Point(60, 202)
        Me.ucrsdgLayoutBase.Name = "ucrsdgLayoutBase"
        Me.ucrsdgLayoutBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrsdgLayoutBase.TabIndex = 1
        '
        'sdgLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 247)
        Me.Controls.Add(Me.ucrsdgLayoutBase)
        Me.Controls.Add(Me.tbcLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgLayout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Layout"
        Me.tbcLayout.ResumeLayout(False)
        Me.tbpSimple.ResumeLayout(False)
        Me.tbpSimple.PerformLayout()
        CType(Me.nudRows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudColumns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcLayout As TabControl
    Friend WithEvents tbpSimple As TabPage
    Friend WithEvents lblNumberofColumns As Label
    Friend WithEvents lblNumberofRows As Label
    Friend WithEvents nudColumns As NumericUpDown
    Friend WithEvents nudRows As NumericUpDown
    Friend WithEvents tbpGeneral As TabPage
    Friend WithEvents ucrsdgLayoutBase As ucrButtonsSubdialogue
End Class
