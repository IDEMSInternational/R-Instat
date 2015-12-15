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
        Me.grpStatistcsRequired = New System.Windows.Forms.GroupBox()
        Me.chkSum = New System.Windows.Forms.CheckBox()
        Me.chkStDev = New System.Windows.Forms.CheckBox()
        Me.chkMaximum = New System.Windows.Forms.CheckBox()
        Me.chkMinimum = New System.Windows.Forms.CheckBox()
        Me.chkMean = New System.Windows.Forms.CheckBox()
        Me.chkCount = New System.Windows.Forms.CheckBox()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.chkRestrictDataValues = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.grpStatistcsRequired.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStatistcsRequired
        '
        Me.grpStatistcsRequired.Controls.Add(Me.chkSum)
        Me.grpStatistcsRequired.Controls.Add(Me.chkStDev)
        Me.grpStatistcsRequired.Controls.Add(Me.chkMaximum)
        Me.grpStatistcsRequired.Controls.Add(Me.chkMinimum)
        Me.grpStatistcsRequired.Controls.Add(Me.chkMean)
        Me.grpStatistcsRequired.Controls.Add(Me.chkCount)
        Me.grpStatistcsRequired.Location = New System.Drawing.Point(344, 12)
        Me.grpStatistcsRequired.Name = "grpStatistcsRequired"
        Me.grpStatistcsRequired.Size = New System.Drawing.Size(110, 155)
        Me.grpStatistcsRequired.TabIndex = 5
        Me.grpStatistcsRequired.TabStop = False
        Me.grpStatistcsRequired.Tag = "Statistcs_Required"
        Me.grpStatistcsRequired.Text = "Statistcs Required"
        '
        'chkSum
        '
        Me.chkSum.AutoSize = True
        Me.chkSum.Location = New System.Drawing.Point(7, 135)
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
        Me.chkStDev.Location = New System.Drawing.Point(7, 112)
        Me.chkStDev.Name = "chkStDev"
        Me.chkStDev.Size = New System.Drawing.Size(62, 17)
        Me.chkStDev.TabIndex = 0
        Me.chkStDev.Tag = "St_Dev"
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
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(216, 9)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(95, 13)
        Me.lblSelectedVariables.TabIndex = 14
        Me.lblSelectedVariables.Tag = "Selected Variables"
        Me.lblSelectedVariables.Text = "Selected Variables"
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(209, 22)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(124, 142)
        Me.ucrReceiverMultiple.TabIndex = 13
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(1, 9)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(202, 129)
        Me.ucrAddRemove.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(14, 188)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 6
        '
        'chkRestrictDataValues
        '
        Me.chkRestrictDataValues.AutoSize = True
        Me.chkRestrictDataValues.Location = New System.Drawing.Point(13, 144)
        Me.chkRestrictDataValues.Name = "chkRestrictDataValues"
        Me.chkRestrictDataValues.Size = New System.Drawing.Size(122, 17)
        Me.chkRestrictDataValues.TabIndex = 15
        Me.chkRestrictDataValues.Tag = "Restrict_Data_values"
        Me.chkRestrictDataValues.Text = "Restrict Data values"
        Me.chkRestrictDataValues.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(13, 169)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox7.TabIndex = 16
        Me.CheckBox7.Text = "Weights"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'dlgRowStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 221)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.chkRestrictDataValues)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpStatistcsRequired)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRowStats"
        Me.Tag = "Row_Stats"
        Me.Text = "Row Stats"
        Me.grpStatistcsRequired.ResumeLayout(False)
        Me.grpStatistcsRequired.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpStatistcsRequired As GroupBox
    Friend WithEvents chkSum As CheckBox
    Friend WithEvents chkStDev As CheckBox
    Friend WithEvents chkMaximum As CheckBox
    Friend WithEvents chkMinimum As CheckBox
    Friend WithEvents chkMean As CheckBox
    Friend WithEvents chkCount As CheckBox
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents chkRestrictDataValues As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
End Class
