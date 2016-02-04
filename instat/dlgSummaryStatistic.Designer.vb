<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSummaryStatistic
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
        Me.chkRemoveNA = New System.Windows.Forms.CheckBox()
        Me.chkAppend = New System.Windows.Forms.CheckBox()
        Me.chkConvert = New System.Windows.Forms.CheckBox()
        Me.chkStatistics = New System.Windows.Forms.CheckBox()
        Me.chkCounts = New System.Windows.Forms.CheckBox()
        Me.chkPercents = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtPeriodLabel = New System.Windows.Forms.TextBox()
        Me.txtInterestedVariable = New System.Windows.Forms.TextBox()
        Me.nudDigits = New System.Windows.Forms.NumericUpDown()
        Me.lblInterestedVariable = New System.Windows.Forms.Label()
        Me.lblPeriodLabel = New System.Windows.Forms.Label()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.lblDigits = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.nudDigits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(37, 274)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(150, 237)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(81, 17)
        Me.chkRemoveNA.TabIndex = 1
        Me.chkRemoveNA.Tag = "Remove_NA"
        Me.chkRemoveNA.Text = "CheckBox1"
        Me.chkRemoveNA.UseVisualStyleBackColor = True
        '
        'chkAppend
        '
        Me.chkAppend.AutoSize = True
        Me.chkAppend.Location = New System.Drawing.Point(324, 204)
        Me.chkAppend.Name = "chkAppend"
        Me.chkAppend.Size = New System.Drawing.Size(81, 17)
        Me.chkAppend.TabIndex = 2
        Me.chkAppend.Tag = "Append"
        Me.chkAppend.Text = "CheckBox2"
        Me.chkAppend.UseVisualStyleBackColor = True
        '
        'chkConvert
        '
        Me.chkConvert.AutoSize = True
        Me.chkConvert.Location = New System.Drawing.Point(150, 204)
        Me.chkConvert.Name = "chkConvert"
        Me.chkConvert.Size = New System.Drawing.Size(81, 17)
        Me.chkConvert.TabIndex = 3
        Me.chkConvert.Tag = "Convert"
        Me.chkConvert.Text = "CheckBox3"
        Me.chkConvert.UseVisualStyleBackColor = True
        '
        'chkStatistics
        '
        Me.chkStatistics.AutoSize = True
        Me.chkStatistics.Location = New System.Drawing.Point(324, 166)
        Me.chkStatistics.Name = "chkStatistics"
        Me.chkStatistics.Size = New System.Drawing.Size(81, 17)
        Me.chkStatistics.TabIndex = 4
        Me.chkStatistics.Tag = "Statistics"
        Me.chkStatistics.Text = "CheckBox4"
        Me.chkStatistics.UseVisualStyleBackColor = True
        '
        'chkCounts
        '
        Me.chkCounts.AutoSize = True
        Me.chkCounts.Location = New System.Drawing.Point(150, 166)
        Me.chkCounts.Name = "chkCounts"
        Me.chkCounts.Size = New System.Drawing.Size(81, 17)
        Me.chkCounts.TabIndex = 5
        Me.chkCounts.Tag = "Counts"
        Me.chkCounts.Text = "CheckBox5"
        Me.chkCounts.UseVisualStyleBackColor = True
        '
        'chkPercents
        '
        Me.chkPercents.AutoSize = True
        Me.chkPercents.Location = New System.Drawing.Point(324, 121)
        Me.chkPercents.Name = "chkPercents"
        Me.chkPercents.Size = New System.Drawing.Size(81, 17)
        Me.chkPercents.TabIndex = 6
        Me.chkPercents.Tag = "Percents"
        Me.chkPercents.Text = "CheckBox6"
        Me.chkPercents.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(150, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        '
        'txtPeriodLabel
        '
        Me.txtPeriodLabel.Location = New System.Drawing.Point(150, 53)
        Me.txtPeriodLabel.Name = "txtPeriodLabel"
        Me.txtPeriodLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtPeriodLabel.TabIndex = 8
        '
        'txtInterestedVariable
        '
        Me.txtInterestedVariable.Location = New System.Drawing.Point(150, 24)
        Me.txtInterestedVariable.Name = "txtInterestedVariable"
        Me.txtInterestedVariable.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestedVariable.TabIndex = 9
        '
        'nudDigits
        '
        Me.nudDigits.Location = New System.Drawing.Point(150, 118)
        Me.nudDigits.Name = "nudDigits"
        Me.nudDigits.Size = New System.Drawing.Size(50, 20)
        Me.nudDigits.TabIndex = 10
        '
        'lblInterestedVariable
        '
        Me.lblInterestedVariable.AutoSize = True
        Me.lblInterestedVariable.Location = New System.Drawing.Point(34, 27)
        Me.lblInterestedVariable.Name = "lblInterestedVariable"
        Me.lblInterestedVariable.Size = New System.Drawing.Size(39, 13)
        Me.lblInterestedVariable.TabIndex = 11
        Me.lblInterestedVariable.Tag = "Interested_Variable"
        Me.lblInterestedVariable.Text = "Label1"
        '
        'lblPeriodLabel
        '
        Me.lblPeriodLabel.AutoSize = True
        Me.lblPeriodLabel.Location = New System.Drawing.Point(34, 53)
        Me.lblPeriodLabel.Name = "lblPeriodLabel"
        Me.lblPeriodLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblPeriodLabel.TabIndex = 12
        Me.lblPeriodLabel.Tag = "Period_Label"
        Me.lblPeriodLabel.Text = "Label2"
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Location = New System.Drawing.Point(34, 86)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(39, 13)
        Me.lblFilename.TabIndex = 13
        Me.lblFilename.Tag = "Filename"
        Me.lblFilename.Text = "Label3"
        '
        'lblDigits
        '
        Me.lblDigits.AutoSize = True
        Me.lblDigits.Location = New System.Drawing.Point(34, 121)
        Me.lblDigits.Name = "lblDigits"
        Me.lblDigits.Size = New System.Drawing.Size(39, 13)
        Me.lblDigits.TabIndex = 14
        Me.lblDigits.Tag = "Digits"
        Me.lblDigits.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, -1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Data list not implemented"
        '
        'dlgSummaryStatistic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 309)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDigits)
        Me.Controls.Add(Me.lblFilename)
        Me.Controls.Add(Me.lblPeriodLabel)
        Me.Controls.Add(Me.lblInterestedVariable)
        Me.Controls.Add(Me.nudDigits)
        Me.Controls.Add(Me.txtInterestedVariable)
        Me.Controls.Add(Me.txtPeriodLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.chkPercents)
        Me.Controls.Add(Me.chkCounts)
        Me.Controls.Add(Me.chkStatistics)
        Me.Controls.Add(Me.chkConvert)
        Me.Controls.Add(Me.chkAppend)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.ucrBase)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSummaryStatistic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary Statistic"
        CType(Me.nudDigits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkRemoveNA As CheckBox
    Friend WithEvents chkAppend As CheckBox
    Friend WithEvents chkConvert As CheckBox
    Friend WithEvents chkStatistics As CheckBox
    Friend WithEvents chkCounts As CheckBox
    Friend WithEvents chkPercents As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtPeriodLabel As TextBox
    Friend WithEvents txtInterestedVariable As TextBox
    Friend WithEvents nudDigits As NumericUpDown
    Friend WithEvents lblInterestedVariable As Label
    Friend WithEvents lblPeriodLabel As Label
    Friend WithEvents lblFilename As Label
    Friend WithEvents lblDigits As Label
    Friend WithEvents Label5 As Label
End Class
