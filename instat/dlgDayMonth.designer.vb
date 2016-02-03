<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDayMonth
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
        Me.txtColumnName = New System.Windows.Forms.TextBox()
        Me.txtTimePeriod = New System.Windows.Forms.TextBox()
        Me.txtRequiredTimeFormat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.lblTimePeriod = New System.Windows.Forms.Label()
        Me.lblRequiredTimeFormat = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'txtColumnName
        '
        Me.txtColumnName.Location = New System.Drawing.Point(161, 68)
        Me.txtColumnName.Name = "txtColumnName"
        Me.txtColumnName.Size = New System.Drawing.Size(100, 20)
        Me.txtColumnName.TabIndex = 1
        Me.txtColumnName.Tag = ""
        '
        'txtTimePeriod
        '
        Me.txtTimePeriod.Location = New System.Drawing.Point(161, 110)
        Me.txtTimePeriod.Name = "txtTimePeriod"
        Me.txtTimePeriod.Size = New System.Drawing.Size(100, 20)
        Me.txtTimePeriod.TabIndex = 2
        Me.txtTimePeriod.Tag = ""
        '
        'txtRequiredTimeFormat
        '
        Me.txtRequiredTimeFormat.Location = New System.Drawing.Point(161, 149)
        Me.txtRequiredTimeFormat.Name = "txtRequiredTimeFormat"
        Me.txtRequiredTimeFormat.Size = New System.Drawing.Size(100, 20)
        Me.txtRequiredTimeFormat.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Not Implemented"
        '
        'lblColumnName
        '
        Me.lblColumnName.AutoSize = True
        Me.lblColumnName.Location = New System.Drawing.Point(40, 75)
        Me.lblColumnName.Name = "lblColumnName"
        Me.lblColumnName.Size = New System.Drawing.Size(39, 13)
        Me.lblColumnName.TabIndex = 5
        Me.lblColumnName.Tag = "Column_Name"
        Me.lblColumnName.Text = "Label2"
        '
        'lblTimePeriod
        '
        Me.lblTimePeriod.AutoSize = True
        Me.lblTimePeriod.Location = New System.Drawing.Point(40, 110)
        Me.lblTimePeriod.Name = "lblTimePeriod"
        Me.lblTimePeriod.Size = New System.Drawing.Size(39, 13)
        Me.lblTimePeriod.TabIndex = 6
        Me.lblTimePeriod.Tag = "Time_Period"
        Me.lblTimePeriod.Text = "Label3"
        '
        'lblRequiredTimeFormat
        '
        Me.lblRequiredTimeFormat.AutoSize = True
        Me.lblRequiredTimeFormat.Location = New System.Drawing.Point(40, 152)
        Me.lblRequiredTimeFormat.Name = "lblRequiredTimeFormat"
        Me.lblRequiredTimeFormat.Size = New System.Drawing.Size(39, 13)
        Me.lblRequiredTimeFormat.TabIndex = 7
        Me.lblRequiredTimeFormat.Tag = "Required_Time_Format"
        Me.lblRequiredTimeFormat.Text = "Label4"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 227)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 51)
        Me.ucrBase.TabIndex = 0
        '
        'dlgDayMonth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 290)
        Me.Controls.Add(Me.lblRequiredTimeFormat)
        Me.Controls.Add(Me.lblTimePeriod)
        Me.Controls.Add(Me.lblColumnName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRequiredTimeFormat)
        Me.Controls.Add(Me.txtTimePeriod)
        Me.Controls.Add(Me.txtColumnName)
        Me.Controls.Add(Me.ucrBase)
        Me.Name = "dlgDayMonth"
        Me.Tag = "Day_Month"
        Me.Text = "Day Month"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents txtColumnName As TextBox
    Friend WithEvents txtTimePeriod As TextBox
    Friend WithEvents txtRequiredTimeFormat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblColumnName As Label
    Friend WithEvents lblTimePeriod As Label
    Friend WithEvents lblRequiredTimeFormat As Label
End Class
