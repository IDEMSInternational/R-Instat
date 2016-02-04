<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgChangeFormatDayMonth
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.lblMonthFormat = New System.Windows.Forms.Label()
        Me.lblRequiredFormat = New System.Windows.Forms.Label()
        Me.nudOption = New System.Windows.Forms.NumericUpDown()
        Me.txtColumnName = New System.Windows.Forms.TextBox()
        Me.txtMonthFormat = New System.Windows.Forms.TextBox()
        Me.txtPeriods = New System.Windows.Forms.TextBox()
        Me.lblOption = New System.Windows.Forms.Label()
        Me.txtRequiredFormat = New System.Windows.Forms.TextBox()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data list not implemented"
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(32, 45)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(39, 13)
        Me.lblPeriod.TabIndex = 2
        Me.lblPeriod.Tag = "Period"
        Me.lblPeriod.Text = "Label2"
        '
        'lblColumnName
        '
        Me.lblColumnName.AutoSize = True
        Me.lblColumnName.Location = New System.Drawing.Point(32, 71)
        Me.lblColumnName.Name = "lblColumnName"
        Me.lblColumnName.Size = New System.Drawing.Size(39, 13)
        Me.lblColumnName.TabIndex = 3
        Me.lblColumnName.Tag = "Column_Name"
        Me.lblColumnName.Text = "Label3"
        '
        'lblMonthFormat
        '
        Me.lblMonthFormat.AutoSize = True
        Me.lblMonthFormat.Location = New System.Drawing.Point(32, 97)
        Me.lblMonthFormat.Name = "lblMonthFormat"
        Me.lblMonthFormat.Size = New System.Drawing.Size(39, 13)
        Me.lblMonthFormat.TabIndex = 4
        Me.lblMonthFormat.Tag = "Month_Format"
        Me.lblMonthFormat.Text = "Label4"
        '
        'lblRequiredFormat
        '
        Me.lblRequiredFormat.AutoSize = True
        Me.lblRequiredFormat.Location = New System.Drawing.Point(32, 116)
        Me.lblRequiredFormat.Name = "lblRequiredFormat"
        Me.lblRequiredFormat.Size = New System.Drawing.Size(39, 13)
        Me.lblRequiredFormat.TabIndex = 5
        Me.lblRequiredFormat.Tag = "Required_Format"
        Me.lblRequiredFormat.Text = "Label5"
        '
        'nudOption
        '
        Me.nudOption.Location = New System.Drawing.Point(129, 175)
        Me.nudOption.Name = "nudOption"
        Me.nudOption.Size = New System.Drawing.Size(56, 20)
        Me.nudOption.TabIndex = 6
        Me.nudOption.Tag = "Option"
        '
        'txtColumnName
        '
        Me.txtColumnName.Location = New System.Drawing.Point(129, 64)
        Me.txtColumnName.Name = "txtColumnName"
        Me.txtColumnName.Size = New System.Drawing.Size(100, 20)
        Me.txtColumnName.TabIndex = 7
        Me.txtColumnName.Tag = ""
        '
        'txtMonthFormat
        '
        Me.txtMonthFormat.Location = New System.Drawing.Point(129, 90)
        Me.txtMonthFormat.Name = "txtMonthFormat"
        Me.txtMonthFormat.Size = New System.Drawing.Size(100, 20)
        Me.txtMonthFormat.TabIndex = 8
        Me.txtMonthFormat.Tag = ""
        '
        'txtPeriods
        '
        Me.txtPeriods.Location = New System.Drawing.Point(129, 38)
        Me.txtPeriods.Name = "txtPeriods"
        Me.txtPeriods.Size = New System.Drawing.Size(100, 20)
        Me.txtPeriods.TabIndex = 9
        Me.txtPeriods.Tag = ""
        '
        'lblOption
        '
        Me.lblOption.AutoSize = True
        Me.lblOption.Location = New System.Drawing.Point(32, 177)
        Me.lblOption.Name = "lblOption"
        Me.lblOption.Size = New System.Drawing.Size(39, 13)
        Me.lblOption.TabIndex = 10
        Me.lblOption.Tag = "Option"
        Me.lblOption.Text = "Label6"
        '
        'txtRequiredFormat
        '
        Me.txtRequiredFormat.Location = New System.Drawing.Point(129, 109)
        Me.txtRequiredFormat.Name = "txtRequiredFormat"
        Me.txtRequiredFormat.Size = New System.Drawing.Size(100, 20)
        Me.txtRequiredFormat.TabIndex = 11
        Me.txtRequiredFormat.Tag = ""
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 227)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'dlgChangeFormatDayMonth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 262)
        Me.Controls.Add(Me.txtRequiredFormat)
        Me.Controls.Add(Me.lblOption)
        Me.Controls.Add(Me.txtPeriods)
        Me.Controls.Add(Me.txtMonthFormat)
        Me.Controls.Add(Me.txtColumnName)
        Me.Controls.Add(Me.nudOption)
        Me.Controls.Add(Me.lblRequiredFormat)
        Me.Controls.Add(Me.lblMonthFormat)
        Me.Controls.Add(Me.lblColumnName)
        Me.Controls.Add(Me.lblPeriod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgChangeFormatDayMonth"
        Me.Tag = "Change_Format_Day_Month"
        Me.Text = "Change Format Day Month"
        CType(Me.nudOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPeriod As Label
    Friend WithEvents lblColumnName As Label
    Friend WithEvents lblMonthFormat As Label
    Friend WithEvents lblRequiredFormat As Label
    Friend WithEvents nudOption As NumericUpDown
    Friend WithEvents txtColumnName As TextBox
    Friend WithEvents txtMonthFormat As TextBox
    Friend WithEvents txtPeriods As TextBox
    Friend WithEvents lblOption As Label
    Friend WithEvents txtRequiredFormat As TextBox
End Class
