<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgAdditionalCondition
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrNudDPOverallInterval = New instat.ucrNud()
        Me.ucrNudDSMaximumDays = New instat.ucrNud()
        Me.ucrNudDSLengthOfTime = New instat.ucrNud()
        Me.lblDPOverallInterval = New System.Windows.Forms.Label()
        Me.ucrNudRDMinimumDays = New instat.ucrNud()
        Me.ucrNudDPRainPeriod = New instat.ucrNud()
        Me.lblDPLength = New System.Windows.Forms.Label()
        Me.ucrChkDryPeriod = New instat.ucrCheck()
        Me.lblDSLengthofTime = New System.Windows.Forms.Label()
        Me.lblDPMaxRain = New System.Windows.Forms.Label()
        Me.ucrNudRDOutOfDays = New instat.ucrNud()
        Me.ucrNudDPMaxRain = New instat.ucrNud()
        Me.ucrChkDrySpell = New instat.ucrCheck()
        Me.lblDSMaximumDays = New System.Windows.Forms.Label()
        Me.lblRDMinimum = New System.Windows.Forms.Label()
        Me.lblRDWidth = New System.Windows.Forms.Label()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.ucrChkNumberOfRainyDays = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrNudDPOverallInterval
        '
        Me.ucrNudDPOverallInterval.AutoSize = True
        Me.ucrNudDPOverallInterval.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDPOverallInterval.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDPOverallInterval.Location = New System.Drawing.Point(246, 98)
        Me.ucrNudDPOverallInterval.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDPOverallInterval.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDPOverallInterval.Name = "ucrNudDPOverallInterval"
        Me.ucrNudDPOverallInterval.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudDPOverallInterval.TabIndex = 61
        Me.ucrNudDPOverallInterval.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDSMaximumDays
        '
        Me.ucrNudDSMaximumDays.AutoSize = True
        Me.ucrNudDSMaximumDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDSMaximumDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDSMaximumDays.Location = New System.Drawing.Point(246, 46)
        Me.ucrNudDSMaximumDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDSMaximumDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDSMaximumDays.Name = "ucrNudDSMaximumDays"
        Me.ucrNudDSMaximumDays.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudDSMaximumDays.TabIndex = 52
        Me.ucrNudDSMaximumDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDSLengthOfTime
        '
        Me.ucrNudDSLengthOfTime.AutoSize = True
        Me.ucrNudDSLengthOfTime.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDSLengthOfTime.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDSLengthOfTime.Location = New System.Drawing.Point(412, 46)
        Me.ucrNudDSLengthOfTime.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDSLengthOfTime.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDSLengthOfTime.Name = "ucrNudDSLengthOfTime"
        Me.ucrNudDSLengthOfTime.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudDSLengthOfTime.TabIndex = 54
        Me.ucrNudDSLengthOfTime.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDPOverallInterval
        '
        Me.lblDPOverallInterval.AutoSize = True
        Me.lblDPOverallInterval.Location = New System.Drawing.Point(132, 101)
        Me.lblDPOverallInterval.Name = "lblDPOverallInterval"
        Me.lblDPOverallInterval.Size = New System.Drawing.Size(117, 13)
        Me.lblDPOverallInterval.TabIndex = 60
        Me.lblDPOverallInterval.Text = "Overall Interval Length:"
        '
        'ucrNudRDMinimumDays
        '
        Me.ucrNudRDMinimumDays.AutoSize = True
        Me.ucrNudRDMinimumDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRDMinimumDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRDMinimumDays.Location = New System.Drawing.Point(246, 19)
        Me.ucrNudRDMinimumDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRDMinimumDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRDMinimumDays.Name = "ucrNudRDMinimumDays"
        Me.ucrNudRDMinimumDays.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudRDMinimumDays.TabIndex = 47
        Me.ucrNudRDMinimumDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDPRainPeriod
        '
        Me.ucrNudDPRainPeriod.AutoSize = True
        Me.ucrNudDPRainPeriod.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDPRainPeriod.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDPRainPeriod.Location = New System.Drawing.Point(412, 77)
        Me.ucrNudDPRainPeriod.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDPRainPeriod.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDPRainPeriod.Name = "ucrNudDPRainPeriod"
        Me.ucrNudDPRainPeriod.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudDPRainPeriod.TabIndex = 59
        Me.ucrNudDPRainPeriod.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDPLength
        '
        Me.lblDPLength.AutoSize = True
        Me.lblDPLength.Location = New System.Drawing.Point(310, 77)
        Me.lblDPLength.Name = "lblDPLength"
        Me.lblDPLength.Size = New System.Drawing.Size(100, 13)
        Me.lblDPLength.TabIndex = 58
        Me.lblDPLength.Text = "Maximum Dry Days:"
        '
        'ucrChkDryPeriod
        '
        Me.ucrChkDryPeriod.AutoSize = True
        Me.ucrChkDryPeriod.Checked = False
        Me.ucrChkDryPeriod.Location = New System.Drawing.Point(11, 77)
        Me.ucrChkDryPeriod.Name = "ucrChkDryPeriod"
        Me.ucrChkDryPeriod.Size = New System.Drawing.Size(138, 55)
        Me.ucrChkDryPeriod.TabIndex = 55
        '
        'lblDSLengthofTime
        '
        Me.lblDSLengthofTime.AutoSize = True
        Me.lblDSLengthofTime.Location = New System.Drawing.Point(293, 50)
        Me.lblDSLengthofTime.Name = "lblDSLengthofTime"
        Me.lblDSLengthofTime.Size = New System.Drawing.Size(117, 13)
        Me.lblDSLengthofTime.TabIndex = 53
        Me.lblDSLengthofTime.Text = "Overall Interval Length:"
        '
        'lblDPMaxRain
        '
        Me.lblDPMaxRain.AutoSize = True
        Me.lblDPMaxRain.Location = New System.Drawing.Point(161, 79)
        Me.lblDPMaxRain.Name = "lblDPMaxRain"
        Me.lblDPMaxRain.Size = New System.Drawing.Size(79, 13)
        Me.lblDPMaxRain.TabIndex = 56
        Me.lblDPMaxRain.Text = "Maximum Rain:"
        '
        'ucrNudRDOutOfDays
        '
        Me.ucrNudRDOutOfDays.AutoSize = True
        Me.ucrNudRDOutOfDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRDOutOfDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRDOutOfDays.Location = New System.Drawing.Point(412, 19)
        Me.ucrNudRDOutOfDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRDOutOfDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRDOutOfDays.Name = "ucrNudRDOutOfDays"
        Me.ucrNudRDOutOfDays.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudRDOutOfDays.TabIndex = 49
        Me.ucrNudRDOutOfDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDPMaxRain
        '
        Me.ucrNudDPMaxRain.AutoSize = True
        Me.ucrNudDPMaxRain.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDPMaxRain.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDPMaxRain.Location = New System.Drawing.Point(246, 72)
        Me.ucrNudDPMaxRain.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDPMaxRain.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDPMaxRain.Name = "ucrNudDPMaxRain"
        Me.ucrNudDPMaxRain.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudDPMaxRain.TabIndex = 57
        Me.ucrNudDPMaxRain.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkDrySpell
        '
        Me.ucrChkDrySpell.AutoSize = True
        Me.ucrChkDrySpell.Checked = False
        Me.ucrChkDrySpell.Location = New System.Drawing.Point(11, 46)
        Me.ucrChkDrySpell.Name = "ucrChkDrySpell"
        Me.ucrChkDrySpell.Size = New System.Drawing.Size(126, 23)
        Me.ucrChkDrySpell.TabIndex = 50
        '
        'lblDSMaximumDays
        '
        Me.lblDSMaximumDays.AutoSize = True
        Me.lblDSMaximumDays.Location = New System.Drawing.Point(140, 50)
        Me.lblDSMaximumDays.Name = "lblDSMaximumDays"
        Me.lblDSMaximumDays.Size = New System.Drawing.Size(100, 13)
        Me.lblDSMaximumDays.TabIndex = 51
        Me.lblDSMaximumDays.Text = "Maximum Dry Days:"
        '
        'lblRDMinimum
        '
        Me.lblRDMinimum.AutoSize = True
        Me.lblRDMinimum.Location = New System.Drawing.Point(189, 22)
        Me.lblRDMinimum.Name = "lblRDMinimum"
        Me.lblRDMinimum.Size = New System.Drawing.Size(51, 13)
        Me.lblRDMinimum.TabIndex = 46
        Me.lblRDMinimum.Text = "Minimum:"
        '
        'lblRDWidth
        '
        Me.lblRDWidth.AutoSize = True
        Me.lblRDWidth.Location = New System.Drawing.Point(344, 19)
        Me.lblRDWidth.Name = "lblRDWidth"
        Me.lblRDWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblRDWidth.TabIndex = 48
        Me.lblRDWidth.Text = "Out of Days:"
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(105, 138)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(259, 29)
        Me.ucrSdgButtons.TabIndex = 62
        '
        'ucrChkNumberOfRainyDays
        '
        Me.ucrChkNumberOfRainyDays.AutoSize = True
        Me.ucrChkNumberOfRainyDays.Checked = False
        Me.ucrChkNumberOfRainyDays.Location = New System.Drawing.Point(11, 12)
        Me.ucrChkNumberOfRainyDays.Name = "ucrChkNumberOfRainyDays"
        Me.ucrChkNumberOfRainyDays.Size = New System.Drawing.Size(161, 23)
        Me.ucrChkNumberOfRainyDays.TabIndex = 63
        '
        'sdgAdditionalCondition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 179)
        Me.Controls.Add(Me.ucrChkNumberOfRainyDays)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.Controls.Add(Me.ucrNudDPOverallInterval)
        Me.Controls.Add(Me.ucrNudDSMaximumDays)
        Me.Controls.Add(Me.ucrNudDSLengthOfTime)
        Me.Controls.Add(Me.lblDPOverallInterval)
        Me.Controls.Add(Me.ucrNudRDMinimumDays)
        Me.Controls.Add(Me.ucrNudDPRainPeriod)
        Me.Controls.Add(Me.lblDPLength)
        Me.Controls.Add(Me.ucrChkDryPeriod)
        Me.Controls.Add(Me.lblDSLengthofTime)
        Me.Controls.Add(Me.lblDPMaxRain)
        Me.Controls.Add(Me.ucrNudRDOutOfDays)
        Me.Controls.Add(Me.ucrNudDPMaxRain)
        Me.Controls.Add(Me.ucrChkDrySpell)
        Me.Controls.Add(Me.lblDSMaximumDays)
        Me.Controls.Add(Me.lblRDMinimum)
        Me.Controls.Add(Me.lblRDWidth)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgAdditionalCondition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Additional Condition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrNudDPOverallInterval As ucrNud
    Friend WithEvents ucrNudDSMaximumDays As ucrNud
    Friend WithEvents ucrNudDSLengthOfTime As ucrNud
    Friend WithEvents lblDPOverallInterval As Label
    Friend WithEvents ucrNudRDMinimumDays As ucrNud
    Friend WithEvents ucrNudDPRainPeriod As ucrNud
    Friend WithEvents lblDPLength As Label
    Friend WithEvents ucrChkDryPeriod As ucrCheck
    Friend WithEvents lblDSLengthofTime As Label
    Friend WithEvents lblDPMaxRain As Label
    Friend WithEvents ucrNudRDOutOfDays As ucrNud
    Friend WithEvents ucrNudDPMaxRain As ucrNud
    Friend WithEvents ucrChkDrySpell As ucrCheck
    Friend WithEvents lblDSMaximumDays As Label
    Friend WithEvents lblRDMinimum As Label
    Friend WithEvents lblRDWidth As Label
    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents ucrChkNumberOfRainyDays As ucrCheck
End Class
