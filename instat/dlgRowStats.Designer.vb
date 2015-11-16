<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRowStats
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
        Me.ucrSelectorAddRemove = New instat.ucrSelectorAddRemove()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.grpStatistcsRequired = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.grpStatistcsRequired.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSelectorAddRemove
        '
        Me.ucrSelectorAddRemove.Location = New System.Drawing.Point(3, 13)
        Me.ucrSelectorAddRemove.Name = "ucrSelectorAddRemove"
        Me.ucrSelectorAddRemove.Size = New System.Drawing.Size(182, 118)
        Me.ucrSelectorAddRemove.TabIndex = 0
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(188, 10)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(89, 13)
        Me.lblSelectedVariable.TabIndex = 1
        Me.lblSelectedVariable.Tag = "Selected_Variables"
        Me.lblSelectedVariable.Text = "Selected variable"
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(185, 28)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(91, 101)
        Me.ucrReceiverMultiple.TabIndex = 2
        Me.ucrReceiverMultiple.Tag = ""
        '
        'grpStatistcsRequired
        '
        Me.grpStatistcsRequired.Controls.Add(Me.CheckBox6)
        Me.grpStatistcsRequired.Controls.Add(Me.CheckBox5)
        Me.grpStatistcsRequired.Controls.Add(Me.CheckBox4)
        Me.grpStatistcsRequired.Controls.Add(Me.CheckBox3)
        Me.grpStatistcsRequired.Controls.Add(Me.CheckBox2)
        Me.grpStatistcsRequired.Controls.Add(Me.CheckBox1)
        Me.grpStatistcsRequired.Location = New System.Drawing.Point(283, 13)
        Me.grpStatistcsRequired.Name = "grpStatistcsRequired"
        Me.grpStatistcsRequired.Size = New System.Drawing.Size(110, 155)
        Me.grpStatistcsRequired.TabIndex = 3
        Me.grpStatistcsRequired.TabStop = False
        Me.grpStatistcsRequired.Tag = "Statistcs_Required"
        Me.grpStatistcsRequired.Text = "StatistcsRequired"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Count "
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(7, 43)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = "Mean"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(7, 66)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(67, 17)
        Me.CheckBox3.TabIndex = 0
        Me.CheckBox3.Text = "Minimum"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(7, 89)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox4.TabIndex = 0
        Me.CheckBox4.Text = "Maximum "
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(7, 112)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox5.TabIndex = 0
        Me.CheckBox5.Text = "St. Dev"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(7, 135)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox6.TabIndex = 0
        Me.CheckBox6.Text = "Sum"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'UcrButtons1
        '
        Me.UcrButtons1.Location = New System.Drawing.Point(3, 174)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(410, 32)
        Me.UcrButtons1.TabIndex = 4
        '
        'dlgRowStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 212)
        Me.Controls.Add(Me.UcrButtons1)
        Me.Controls.Add(Me.grpStatistcsRequired)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.ucrSelectorAddRemove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRowStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dlgRowStats"
        Me.grpStatistcsRequired.ResumeLayout(False)
        Me.grpStatistcsRequired.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorAddRemove As ucrSelectorAddRemove
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents grpStatistcsRequired As GroupBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents UcrButtons1 As ucrButtons
End Class
