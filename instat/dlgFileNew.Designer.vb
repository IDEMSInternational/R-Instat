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
        Me.lblRows = New System.Windows.Forms.Label()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrName = New instat.ucrInputComboBox()
        Me.nudRows = New System.Windows.Forms.NumericUpDown()
        Me.nudColumns = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudRows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRows
        '
        Me.lblRows.AutoSize = True
        Me.lblRows.Location = New System.Drawing.Point(10, 15)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(37, 13)
        Me.lblRows.TabIndex = 0
        Me.lblRows.Text = "Rows:"
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Location = New System.Drawing.Point(10, 43)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(50, 13)
        Me.lblColumns.TabIndex = 2
        Me.lblColumns.Text = "Columns:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(7, 78)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(94, 13)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "New Sheet Name:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 103)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(399, 48)
        Me.ucrBase.TabIndex = 6
        '
        'ucrName
        '
        Me.ucrName.IsReadOnly = False
        Me.ucrName.Location = New System.Drawing.Point(107, 75)
        Me.ucrName.Name = "ucrName"
        Me.ucrName.Size = New System.Drawing.Size(137, 21)
        Me.ucrName.TabIndex = 7
        '
        'nudRows
        '
        Me.nudRows.Location = New System.Drawing.Point(75, 12)
        Me.nudRows.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.nudRows.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRows.Name = "nudRows"
        Me.nudRows.Size = New System.Drawing.Size(47, 20)
        Me.nudRows.TabIndex = 8
        Me.nudRows.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudColumns
        '
        Me.nudColumns.Location = New System.Drawing.Point(75, 41)
        Me.nudColumns.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.nudColumns.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudColumns.Name = "nudColumns"
        Me.nudColumns.Size = New System.Drawing.Size(47, 20)
        Me.nudColumns.TabIndex = 9
        Me.nudColumns.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dlgFileNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 162)
        Me.Controls.Add(Me.nudColumns)
        Me.Controls.Add(Me.nudRows)
        Me.Controls.Add(Me.ucrName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.lblRows)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFileNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New file"
        CType(Me.nudRows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudColumns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblName As Label
    Friend WithEvents lblColumns As Label
    Friend WithEvents lblRows As Label
    Friend WithEvents ucrName As ucrInputComboBox
    Friend WithEvents nudRows As NumericUpDown
    Friend WithEvents nudColumns As NumericUpDown
End Class
