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
        Me.ucrReceiverRowStatistics = New instat.ucrReceiverMultiple()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.chkRestrictData_Values = New System.Windows.Forms.CheckBox()
        Me.chkWeights = New System.Windows.Forms.CheckBox()
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
        Me.grpStatistcsRequired.Location = New System.Drawing.Point(276, 12)
        Me.grpStatistcsRequired.Name = "grpStatistcsRequired"
        Me.grpStatistcsRequired.Size = New System.Drawing.Size(110, 155)
        Me.grpStatistcsRequired.TabIndex = 5
        Me.grpStatistcsRequired.TabStop = False
        Me.grpStatistcsRequired.Tag = "Statistcs_required"
        Me.grpStatistcsRequired.Text = "Statistcs required"
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
        Me.chkStDev.Tag = "Standard_deviation"
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
        Me.lblSelectedVariables.Location = New System.Drawing.Point(175, 9)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(94, 13)
        Me.lblSelectedVariables.TabIndex = 14
        Me.lblSelectedVariables.Tag = "Selected_variables"
        Me.lblSelectedVariables.Text = "Selected variables"
        '
        'ucrReceiverRowStatistics
        '
        Me.ucrReceiverRowStatistics.Location = New System.Drawing.Point(175, 22)
        Me.ucrReceiverRowStatistics.Name = "ucrReceiverRowStatistics"
        Me.ucrReceiverRowStatistics.Size = New System.Drawing.Size(91, 142)
        Me.ucrReceiverRowStatistics.TabIndex = 13
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(1, 9)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(182, 118)
        Me.ucrAddRemove.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(1, 169)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 6
        '
        'chkRestrictData_Values
        '
        Me.chkRestrictData_Values.AutoSize = True
        Me.chkRestrictData_Values.Location = New System.Drawing.Point(13, 124)
        Me.chkRestrictData_Values.Name = "chkRestrictData_Values"
        Me.chkRestrictData_Values.Size = New System.Drawing.Size(120, 17)
        Me.chkRestrictData_Values.TabIndex = 15
        Me.chkRestrictData_Values.Tag = "Restrict_data_values"
        Me.chkRestrictData_Values.Text = "Restrict data values"
        Me.chkRestrictData_Values.UseVisualStyleBackColor = True
        '
        'chkWeights
        '
        Me.chkWeights.AutoSize = True
        Me.chkWeights.Location = New System.Drawing.Point(13, 150)
        Me.chkWeights.Name = "chkWeights"
        Me.chkWeights.Size = New System.Drawing.Size(65, 17)
        Me.chkWeights.TabIndex = 16
        Me.chkWeights.Tag = "Weights"
        Me.chkWeights.Text = "Weights"
        Me.chkWeights.UseVisualStyleBackColor = True
        '
        'dlgRowStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 201)
        Me.Controls.Add(Me.chkWeights)
        Me.Controls.Add(Me.chkRestrictData_Values)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrReceiverRowStatistics)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpStatistcsRequired)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRowStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Row_statistics"
        Me.Text = "Row statistics"
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
    Friend WithEvents ucrReceiverRowStatistics As ucrReceiverMultiple
    Friend WithEvents chkRestrictData_Values As CheckBox
    Friend WithEvents chkWeights As CheckBox
End Class
