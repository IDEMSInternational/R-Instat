<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgColumnStats
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.grpStatistcsRequired = New System.Windows.Forms.GroupBox()
        Me.chkMedian = New System.Windows.Forms.CheckBox()
        Me.chkMissing = New System.Windows.Forms.CheckBox()
        Me.chkSum = New System.Windows.Forms.CheckBox()
        Me.chkStDev = New System.Windows.Forms.CheckBox()
        Me.chkMaximum = New System.Windows.Forms.CheckBox()
        Me.chkMinimum = New System.Windows.Forms.CheckBox()
        Me.chkMean = New System.Windows.Forms.CheckBox()
        Me.chkCount = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkByFactor = New System.Windows.Forms.CheckBox()
        Me.chkForFactor = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpStatistcsRequired.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(1, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(447, 230)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblSelectedVariables)
        Me.TabPage1.Controls.Add(Me.ucrReceiverMultiple)
        Me.TabPage1.Controls.Add(Me.ucrAddRemove)
        Me.TabPage1.Controls.Add(Me.grpStatistcsRequired)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(439, 204)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(177, 6)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(95, 13)
        Me.lblSelectedVariables.TabIndex = 12
        Me.lblSelectedVariables.Tag = "Selected_Variables"
        Me.lblSelectedVariables.Text = "Selected Variables"
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(177, 19)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(91, 101)
        Me.ucrReceiverMultiple.TabIndex = 11
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(3, 6)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(182, 118)
        Me.ucrAddRemove.TabIndex = 10
        '
        'grpStatistcsRequired
        '
        Me.grpStatistcsRequired.Controls.Add(Me.chkMedian)
        Me.grpStatistcsRequired.Controls.Add(Me.chkMissing)
        Me.grpStatistcsRequired.Controls.Add(Me.chkSum)
        Me.grpStatistcsRequired.Controls.Add(Me.chkStDev)
        Me.grpStatistcsRequired.Controls.Add(Me.chkMaximum)
        Me.grpStatistcsRequired.Controls.Add(Me.chkMinimum)
        Me.grpStatistcsRequired.Controls.Add(Me.chkMean)
        Me.grpStatistcsRequired.Controls.Add(Me.chkCount)
        Me.grpStatistcsRequired.Location = New System.Drawing.Point(278, 7)
        Me.grpStatistcsRequired.Name = "grpStatistcsRequired"
        Me.grpStatistcsRequired.Size = New System.Drawing.Size(153, 117)
        Me.grpStatistcsRequired.TabIndex = 9
        Me.grpStatistcsRequired.TabStop = False
        Me.grpStatistcsRequired.Tag = "Statistcs_Required"
        Me.grpStatistcsRequired.Text = "Statistcs Required"
        '
        'chkMedian
        '
        Me.chkMedian.AutoSize = True
        Me.chkMedian.Location = New System.Drawing.Point(87, 43)
        Me.chkMedian.Name = "chkMedian"
        Me.chkMedian.Size = New System.Drawing.Size(61, 17)
        Me.chkMedian.TabIndex = 0
        Me.chkMedian.Tag = "Median"
        Me.chkMedian.Text = "Median"
        Me.chkMedian.UseVisualStyleBackColor = True
        '
        'chkMissing
        '
        Me.chkMissing.AutoSize = True
        Me.chkMissing.Location = New System.Drawing.Point(87, 20)
        Me.chkMissing.Name = "chkMissing"
        Me.chkMissing.Size = New System.Drawing.Size(64, 17)
        Me.chkMissing.TabIndex = 0
        Me.chkMissing.Tag = "Missing"
        Me.chkMissing.Text = "Missing "
        Me.chkMissing.UseVisualStyleBackColor = True
        '
        'chkSum
        '
        Me.chkSum.AutoSize = True
        Me.chkSum.Location = New System.Drawing.Point(87, 89)
        Me.chkSum.Name = "chkSum"
        Me.chkSum.Size = New System.Drawing.Size(47, 17)
        Me.chkSum.TabIndex = 0
        Me.chkSum.Tag = "Sum"
        Me.chkSum.Text = "Sum"
        Me.chkSum.UseVisualStyleBackColor = True
        '
        'chkStDev
        '
        Me.chkStDev.AutoSize = True
        Me.chkStDev.Location = New System.Drawing.Point(87, 66)
        Me.chkStDev.Name = "chkStDev"
        Me.chkStDev.Size = New System.Drawing.Size(62, 17)
        Me.chkStDev.TabIndex = 0
        Me.chkStDev.Tag = "St_dev"
        Me.chkStDev.Text = "St. Dev"
        Me.chkStDev.UseVisualStyleBackColor = True
        '
        'chkMaximum
        '
        Me.chkMaximum.AutoSize = True
        Me.chkMaximum.Location = New System.Drawing.Point(7, 89)
        Me.chkMaximum.Name = "chkMaximum"
        Me.chkMaximum.Size = New System.Drawing.Size(73, 17)
        Me.chkMaximum.TabIndex = 0
        Me.chkMaximum.Tag = "Maximum"
        Me.chkMaximum.Text = "Maximum "
        Me.chkMaximum.UseVisualStyleBackColor = True
        '
        'chkMinimum
        '
        Me.chkMinimum.AutoSize = True
        Me.chkMinimum.Location = New System.Drawing.Point(7, 66)
        Me.chkMinimum.Name = "chkMinimum"
        Me.chkMinimum.Size = New System.Drawing.Size(67, 17)
        Me.chkMinimum.TabIndex = 0
        Me.chkMinimum.Tag = "Minimum"
        Me.chkMinimum.Text = "Minimum"
        Me.chkMinimum.UseVisualStyleBackColor = True
        '
        'chkMean
        '
        Me.chkMean.AutoSize = True
        Me.chkMean.Location = New System.Drawing.Point(7, 43)
        Me.chkMean.Name = "chkMean"
        Me.chkMean.Size = New System.Drawing.Size(53, 17)
        Me.chkMean.TabIndex = 0
        Me.chkMean.Tag = "Mean"
        Me.chkMean.Text = "Mean"
        Me.chkMean.UseVisualStyleBackColor = True
        '
        'chkCount
        '
        Me.chkCount.AutoSize = True
        Me.chkCount.Location = New System.Drawing.Point(7, 20)
        Me.chkCount.Name = "chkCount"
        Me.chkCount.Size = New System.Drawing.Size(57, 17)
        Me.chkCount.TabIndex = 0
        Me.chkCount.Tag = "Count"
        Me.chkCount.Text = "Count "
        Me.chkCount.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkByFactor)
        Me.GroupBox1.Controls.Add(Me.chkForFactor)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 66)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'chkByFactor
        '
        Me.chkByFactor.AutoSize = True
        Me.chkByFactor.Location = New System.Drawing.Point(7, 43)
        Me.chkByFactor.Name = "chkByFactor"
        Me.chkByFactor.Size = New System.Drawing.Size(74, 17)
        Me.chkByFactor.TabIndex = 1
        Me.chkByFactor.Tag = "By_Factor"
        Me.chkByFactor.Text = "By Factor "
        Me.chkByFactor.UseVisualStyleBackColor = True
        '
        'chkForFactor
        '
        Me.chkForFactor.AutoSize = True
        Me.chkForFactor.Location = New System.Drawing.Point(7, 12)
        Me.chkForFactor.Name = "chkForFactor"
        Me.chkForFactor.Size = New System.Drawing.Size(74, 17)
        Me.chkForFactor.TabIndex = 0
        Me.chkForFactor.Tag = "For_Factor"
        Me.chkForFactor.Text = "For Factor"
        Me.chkForFactor.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CheckBox11)
        Me.TabPage2.Controls.Add(Me.CheckBox10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(439, 204)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Save"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(9, 57)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(183, 17)
        Me.CheckBox11.TabIndex = 1
        Me.CheckBox11.Text = "Save fitted values and deviations"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(9, 18)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(99, 17)
        Me.CheckBox10.TabIndex = 2
        Me.CheckBox10.Text = "Save Statistics "
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CheckBox12)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(439, 204)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Options"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(7, 6)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(123, 17)
        Me.CheckBox12.TabIndex = 2
        Me.CheckBox12.Text = "Restrict data values "
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox16)
        Me.GroupBox2.Controls.Add(Me.CheckBox15)
        Me.GroupBox2.Controls.Add(Me.CheckBox14)
        Me.GroupBox2.Controls.Add(Me.CheckBox17)
        Me.GroupBox2.Controls.Add(Me.CheckBox13)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Location = New System.Drawing.Point(228, 14)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(44, 17)
        Me.CheckBox16.TabIndex = 0
        Me.CheckBox16.Text = "* * *"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Location = New System.Drawing.Point(191, 14)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(37, 17)
        Me.CheckBox15.TabIndex = 0
        Me.CheckBox15.Text = "* *"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Location = New System.Drawing.Point(142, 14)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(30, 17)
        Me.CheckBox14.TabIndex = 0
        Me.CheckBox14.Text = "*"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Location = New System.Drawing.Point(6, 57)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(211, 17)
        Me.CheckBox17.TabIndex = 0
        Me.CheckBox17.Text = "Set summary to missing  if they are over"
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(5, 14)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(131, 17)
        Me.CheckBox13.TabIndex = 0
        Me.CheckBox13.Text = "Ignore missing Values "
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 239)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 2
        '
        'dlgColumnStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 272)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgColumnStats"
        Me.Tag = "Column_Statistics"
        Me.Text = "Column Stats"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.grpStatistcsRequired.ResumeLayout(False)
        Me.grpStatistcsRequired.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents grpStatistcsRequired As GroupBox
    Friend WithEvents chkMedian As CheckBox
    Friend WithEvents chkMissing As CheckBox
    Friend WithEvents chkSum As CheckBox
    Friend WithEvents chkStDev As CheckBox
    Friend WithEvents chkMaximum As CheckBox
    Friend WithEvents chkMinimum As CheckBox
    Friend WithEvents chkMean As CheckBox
    Friend WithEvents chkCount As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkByFactor As CheckBox
    Friend WithEvents chkForFactor As CheckBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox17 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
End Class
