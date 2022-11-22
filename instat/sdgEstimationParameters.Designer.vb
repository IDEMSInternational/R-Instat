<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgEstimationParameters
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
        Me.lblPriorFamily = New System.Windows.Forms.Label()
        Me.ucrInputPriorFamily = New instat.ucrInputComboBox()
        Me.ucrNudPrioirNull = New instat.ucrInputComboBox()
        Me.lblStandardDeviation = New System.Windows.Forms.Label()
        Me.lblDegreesFreedom = New System.Windows.Forms.Label()
        Me.lblScalingParameter = New System.Windows.Forms.Label()
        Me.lblPrioir = New System.Windows.Forms.Label()
        Me.lblSampleSize = New System.Windows.Forms.Label()
        Me.ucrNudStandardDeviation = New instat.ucrNud()
        Me.ucrNudDegreesFreedom = New instat.ucrNud()
        Me.ucrNudScaleParameter = New instat.ucrNud()
        Me.ucrNudSampleSize = New instat.ucrNud()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.grpHypothesisPrior = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'lblPriorFamily
        '
        Me.lblPriorFamily.AutoSize = True
        Me.lblPriorFamily.Location = New System.Drawing.Point(9, 219)
        Me.lblPriorFamily.Name = "lblPriorFamily"
        Me.lblPriorFamily.Size = New System.Drawing.Size(63, 13)
        Me.lblPriorFamily.TabIndex = 103
        Me.lblPriorFamily.Text = "Prior Family:"
        '
        'ucrInputPriorFamily
        '
        Me.ucrInputPriorFamily.AddQuotesIfUnrecognised = True
        Me.ucrInputPriorFamily.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPriorFamily.GetSetSelectedIndex = -1
        Me.ucrInputPriorFamily.IsReadOnly = False
        Me.ucrInputPriorFamily.Location = New System.Drawing.Point(73, 217)
        Me.ucrInputPriorFamily.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputPriorFamily.Name = "ucrInputPriorFamily"
        Me.ucrInputPriorFamily.Size = New System.Drawing.Size(81, 21)
        Me.ucrInputPriorFamily.TabIndex = 102
        '
        'ucrNudPrioirNull
        '
        Me.ucrNudPrioirNull.AddQuotesIfUnrecognised = True
        Me.ucrNudPrioirNull.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNudPrioirNull.GetSetSelectedIndex = -1
        Me.ucrNudPrioirNull.IsReadOnly = False
        Me.ucrNudPrioirNull.Location = New System.Drawing.Point(39, 152)
        Me.ucrNudPrioirNull.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudPrioirNull.Name = "ucrNudPrioirNull"
        Me.ucrNudPrioirNull.Size = New System.Drawing.Size(81, 21)
        Me.ucrNudPrioirNull.TabIndex = 101
        '
        'lblStandardDeviation
        '
        Me.lblStandardDeviation.AutoSize = True
        Me.lblStandardDeviation.Location = New System.Drawing.Point(8, 51)
        Me.lblStandardDeviation.Name = "lblStandardDeviation"
        Me.lblStandardDeviation.Size = New System.Drawing.Size(127, 13)
        Me.lblStandardDeviation.TabIndex = 99
        Me.lblStandardDeviation.Text = "Prioir Standard Deviation:"
        '
        'lblDegreesFreedom
        '
        Me.lblDegreesFreedom.AutoSize = True
        Me.lblDegreesFreedom.Location = New System.Drawing.Point(5, 82)
        Me.lblDegreesFreedom.Name = "lblDegreesFreedom"
        Me.lblDegreesFreedom.Size = New System.Drawing.Size(130, 13)
        Me.lblDegreesFreedom.TabIndex = 98
        Me.lblDegreesFreedom.Text = "Prior Degrees of Freedom:"
        '
        'lblScalingParameter
        '
        Me.lblScalingParameter.AutoSize = True
        Me.lblScalingParameter.Location = New System.Drawing.Point(39, 113)
        Me.lblScalingParameter.Name = "lblScalingParameter"
        Me.lblScalingParameter.Size = New System.Drawing.Size(96, 13)
        Me.lblScalingParameter.TabIndex = 97
        Me.lblScalingParameter.Text = "Scaling Parameter:"
        '
        'lblPrioir
        '
        Me.lblPrioir.AutoSize = True
        Me.lblPrioir.Location = New System.Drawing.Point(15, 158)
        Me.lblPrioir.Name = "lblPrioir"
        Me.lblPrioir.Size = New System.Drawing.Size(24, 13)
        Me.lblPrioir.TabIndex = 96
        Me.lblPrioir.Text = "H1:"
        '
        'lblSampleSize
        '
        Me.lblSampleSize.AutoSize = True
        Me.lblSampleSize.Location = New System.Drawing.Point(43, 22)
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Size = New System.Drawing.Size(92, 13)
        Me.lblSampleSize.TabIndex = 95
        Me.lblSampleSize.Text = "Prior Sample Size:"
        '
        'ucrNudStandardDeviation
        '
        Me.ucrNudStandardDeviation.AutoSize = True
        Me.ucrNudStandardDeviation.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStandardDeviation.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudStandardDeviation.Location = New System.Drawing.Point(137, 48)
        Me.ucrNudStandardDeviation.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudStandardDeviation.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStandardDeviation.Name = "ucrNudStandardDeviation"
        Me.ucrNudStandardDeviation.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudStandardDeviation.TabIndex = 94
        Me.ucrNudStandardDeviation.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDegreesFreedom
        '
        Me.ucrNudDegreesFreedom.AutoSize = True
        Me.ucrNudDegreesFreedom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDegreesFreedom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDegreesFreedom.Location = New System.Drawing.Point(137, 79)
        Me.ucrNudDegreesFreedom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDegreesFreedom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDegreesFreedom.Name = "ucrNudDegreesFreedom"
        Me.ucrNudDegreesFreedom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDegreesFreedom.TabIndex = 93
        Me.ucrNudDegreesFreedom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudScaleParameter
        '
        Me.ucrNudScaleParameter.AutoSize = True
        Me.ucrNudScaleParameter.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScaleParameter.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudScaleParameter.Location = New System.Drawing.Point(137, 109)
        Me.ucrNudScaleParameter.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudScaleParameter.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScaleParameter.Name = "ucrNudScaleParameter"
        Me.ucrNudScaleParameter.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudScaleParameter.TabIndex = 92
        Me.ucrNudScaleParameter.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSampleSize
        '
        Me.ucrNudSampleSize.AutoSize = True
        Me.ucrNudSampleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSampleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSampleSize.Location = New System.Drawing.Point(137, 18)
        Me.ucrNudSampleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSampleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSampleSize.Name = "ucrNudSampleSize"
        Me.ucrNudSampleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSampleSize.TabIndex = 91
        Me.ucrNudSampleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(9, 259)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgButtons.TabIndex = 90
        '
        'grpHypothesisPrior
        '
        Me.grpHypothesisPrior.Location = New System.Drawing.Point(8, 134)
        Me.grpHypothesisPrior.Name = "grpHypothesisPrior"
        Me.grpHypothesisPrior.Size = New System.Drawing.Size(179, 67)
        Me.grpHypothesisPrior.TabIndex = 100
        Me.grpHypothesisPrior.TabStop = False
        Me.grpHypothesisPrior.Text = "Hypothesis Prior"
        '
        'sdgEstimationParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(293, 306)
        Me.Controls.Add(Me.lblPriorFamily)
        Me.Controls.Add(Me.ucrInputPriorFamily)
        Me.Controls.Add(Me.ucrNudPrioirNull)
        Me.Controls.Add(Me.lblStandardDeviation)
        Me.Controls.Add(Me.lblDegreesFreedom)
        Me.Controls.Add(Me.lblScalingParameter)
        Me.Controls.Add(Me.lblPrioir)
        Me.Controls.Add(Me.lblSampleSize)
        Me.Controls.Add(Me.ucrNudStandardDeviation)
        Me.Controls.Add(Me.ucrNudDegreesFreedom)
        Me.Controls.Add(Me.ucrNudScaleParameter)
        Me.Controls.Add(Me.ucrNudSampleSize)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.Controls.Add(Me.grpHypothesisPrior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgEstimationParameters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Estimation Prioir Parameters"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPriorFamily As Label
    Friend WithEvents ucrInputPriorFamily As ucrInputComboBox
    Friend WithEvents ucrNudPrioirNull As ucrInputComboBox
    Friend WithEvents lblStandardDeviation As Label
    Friend WithEvents lblDegreesFreedom As Label
    Friend WithEvents lblScalingParameter As Label
    Friend WithEvents lblPrioir As Label
    Friend WithEvents lblSampleSize As Label
    Friend WithEvents ucrNudStandardDeviation As ucrNud
    Friend WithEvents ucrNudDegreesFreedom As ucrNud
    Friend WithEvents ucrNudScaleParameter As ucrNud
    Friend WithEvents ucrNudSampleSize As ucrNud
    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents grpHypothesisPrior As GroupBox
End Class
