<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgPriorParameters
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
        Me.lblSampleSize = New System.Windows.Forms.Label()
        Me.lblPrioir = New System.Windows.Forms.Label()
        Me.lblScalingParameter = New System.Windows.Forms.Label()
        Me.lblDegreesFreedom = New System.Windows.Forms.Label()
        Me.lblStandardDeviation = New System.Windows.Forms.Label()
        Me.lblAlternative = New System.Windows.Forms.Label()
        Me.grpHypothesisPrior = New System.Windows.Forms.GroupBox()
        Me.ucrNudAlternativePrioir = New instat.ucrNud()
        Me.ucrNudPrioirNull = New instat.ucrNud()
        Me.ucrNudStandardDeviation = New instat.ucrNud()
        Me.ucrNudDegreesFreedom = New instat.ucrNud()
        Me.ucrNudScaleParameter = New instat.ucrNud()
        Me.ucrNudSampleSize = New instat.ucrNud()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'lblSampleSize
        '
        Me.lblSampleSize.AutoSize = True
        Me.lblSampleSize.Location = New System.Drawing.Point(42, 18)
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Size = New System.Drawing.Size(92, 13)
        Me.lblSampleSize.TabIndex = 9
        Me.lblSampleSize.Text = "Prior Sample Size:"
        '
        'lblPrioir
        '
        Me.lblPrioir.AutoSize = True
        Me.lblPrioir.Location = New System.Drawing.Point(14, 154)
        Me.lblPrioir.Name = "lblPrioir"
        Me.lblPrioir.Size = New System.Drawing.Size(24, 13)
        Me.lblPrioir.TabIndex = 10
        Me.lblPrioir.Text = "H1:"
        '
        'lblScalingParameter
        '
        Me.lblScalingParameter.AutoSize = True
        Me.lblScalingParameter.Location = New System.Drawing.Point(38, 109)
        Me.lblScalingParameter.Name = "lblScalingParameter"
        Me.lblScalingParameter.Size = New System.Drawing.Size(96, 13)
        Me.lblScalingParameter.TabIndex = 12
        Me.lblScalingParameter.Text = "Scaling Parameter:"
        '
        'lblDegreesFreedom
        '
        Me.lblDegreesFreedom.AutoSize = True
        Me.lblDegreesFreedom.Location = New System.Drawing.Point(4, 78)
        Me.lblDegreesFreedom.Name = "lblDegreesFreedom"
        Me.lblDegreesFreedom.Size = New System.Drawing.Size(130, 13)
        Me.lblDegreesFreedom.TabIndex = 13
        Me.lblDegreesFreedom.Text = "Prior Degrees of Freedom:"
        '
        'lblStandardDeviation
        '
        Me.lblStandardDeviation.AutoSize = True
        Me.lblStandardDeviation.Location = New System.Drawing.Point(7, 47)
        Me.lblStandardDeviation.Name = "lblStandardDeviation"
        Me.lblStandardDeviation.Size = New System.Drawing.Size(127, 13)
        Me.lblStandardDeviation.TabIndex = 14
        Me.lblStandardDeviation.Text = "Prioir Standard Deviation:"
        '
        'lblAlternative
        '
        Me.lblAlternative.AutoSize = True
        Me.lblAlternative.Location = New System.Drawing.Point(98, 153)
        Me.lblAlternative.Name = "lblAlternative"
        Me.lblAlternative.Size = New System.Drawing.Size(24, 13)
        Me.lblAlternative.TabIndex = 15
        Me.lblAlternative.Text = "H2:"
        '
        'grpHypothesisPrior
        '
        Me.grpHypothesisPrior.Location = New System.Drawing.Point(7, 130)
        Me.grpHypothesisPrior.Name = "grpHypothesisPrior"
        Me.grpHypothesisPrior.Size = New System.Drawing.Size(200, 67)
        Me.grpHypothesisPrior.TabIndex = 16
        Me.grpHypothesisPrior.TabStop = False
        Me.grpHypothesisPrior.Text = "Hypothesis Prior"
        '
        'ucrNudAlternativePrioir
        '
        Me.ucrNudAlternativePrioir.AutoSize = True
        Me.ucrNudAlternativePrioir.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlternativePrioir.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAlternativePrioir.Location = New System.Drawing.Point(124, 150)
        Me.ucrNudAlternativePrioir.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAlternativePrioir.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlternativePrioir.Name = "ucrNudAlternativePrioir"
        Me.ucrNudAlternativePrioir.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAlternativePrioir.TabIndex = 8
        Me.ucrNudAlternativePrioir.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudPrioirNull
        '
        Me.ucrNudPrioirNull.AutoSize = True
        Me.ucrNudPrioirNull.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPrioirNull.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPrioirNull.Location = New System.Drawing.Point(40, 150)
        Me.ucrNudPrioirNull.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPrioirNull.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPrioirNull.Name = "ucrNudPrioirNull"
        Me.ucrNudPrioirNull.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPrioirNull.TabIndex = 7
        Me.ucrNudPrioirNull.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudStandardDeviation
        '
        Me.ucrNudStandardDeviation.AutoSize = True
        Me.ucrNudStandardDeviation.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStandardDeviation.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudStandardDeviation.Location = New System.Drawing.Point(136, 44)
        Me.ucrNudStandardDeviation.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudStandardDeviation.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStandardDeviation.Name = "ucrNudStandardDeviation"
        Me.ucrNudStandardDeviation.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudStandardDeviation.TabIndex = 6
        Me.ucrNudStandardDeviation.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDegreesFreedom
        '
        Me.ucrNudDegreesFreedom.AutoSize = True
        Me.ucrNudDegreesFreedom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDegreesFreedom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDegreesFreedom.Location = New System.Drawing.Point(136, 75)
        Me.ucrNudDegreesFreedom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDegreesFreedom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDegreesFreedom.Name = "ucrNudDegreesFreedom"
        Me.ucrNudDegreesFreedom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDegreesFreedom.TabIndex = 5
        Me.ucrNudDegreesFreedom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudScaleParameter
        '
        Me.ucrNudScaleParameter.AutoSize = True
        Me.ucrNudScaleParameter.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScaleParameter.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudScaleParameter.Location = New System.Drawing.Point(136, 105)
        Me.ucrNudScaleParameter.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudScaleParameter.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScaleParameter.Name = "ucrNudScaleParameter"
        Me.ucrNudScaleParameter.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudScaleParameter.TabIndex = 4
        Me.ucrNudScaleParameter.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSampleSize
        '
        Me.ucrNudSampleSize.AutoSize = True
        Me.ucrNudSampleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSampleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSampleSize.Location = New System.Drawing.Point(136, 14)
        Me.ucrNudSampleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSampleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSampleSize.Name = "ucrNudSampleSize"
        Me.ucrNudSampleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSampleSize.TabIndex = 3
        Me.ucrNudSampleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(8, 213)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgButtons.TabIndex = 2
        '
        'sdgPriorParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 255)
        Me.Controls.Add(Me.lblAlternative)
        Me.Controls.Add(Me.lblStandardDeviation)
        Me.Controls.Add(Me.lblDegreesFreedom)
        Me.Controls.Add(Me.lblScalingParameter)
        Me.Controls.Add(Me.lblPrioir)
        Me.Controls.Add(Me.lblSampleSize)
        Me.Controls.Add(Me.ucrNudAlternativePrioir)
        Me.Controls.Add(Me.ucrNudPrioirNull)
        Me.Controls.Add(Me.ucrNudStandardDeviation)
        Me.Controls.Add(Me.ucrNudDegreesFreedom)
        Me.Controls.Add(Me.ucrNudScaleParameter)
        Me.Controls.Add(Me.ucrNudSampleSize)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.Controls.Add(Me.grpHypothesisPrior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPriorParameters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Prior Parameters"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents ucrNudSampleSize As ucrNud
    Friend WithEvents ucrNudScaleParameter As ucrNud
    Friend WithEvents ucrNudDegreesFreedom As ucrNud
    Friend WithEvents ucrNudStandardDeviation As ucrNud
    Friend WithEvents ucrNudPrioirNull As ucrNud
    Friend WithEvents ucrNudAlternativePrioir As ucrNud
    Friend WithEvents lblSampleSize As Label
    Friend WithEvents lblPrioir As Label
    Friend WithEvents lblScalingParameter As Label
    Friend WithEvents lblDegreesFreedom As Label
    Friend WithEvents lblStandardDeviation As Label
    Friend WithEvents lblAlternative As Label
    Friend WithEvents grpHypothesisPrior As GroupBox
End Class
