<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgMissingOptionsEvapotranspiration
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
        Me.lblMaxPerctMissindData = New System.Windows.Forms.Label()
        Me.lblMaxDurationMissingData = New System.Windows.Forms.Label()
        Me.lblMaxMissingDays = New System.Windows.Forms.Label()
        Me.grpMissingDataOpts = New System.Windows.Forms.GroupBox()
        Me.ucrChkInterpMissingEntries = New instat.ucrCheck()
        Me.ucrChkInterpMissingDays = New instat.ucrCheck()
        Me.ucrNudMaxDurationMissingData = New instat.ucrNud()
        Me.ucrNudMaxMissingDays = New instat.ucrNud()
        Me.ucrNudMaxMissingData = New instat.ucrNud()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.grpMissingDataOpts.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMaxPerctMissindData
        '
        Me.lblMaxPerctMissindData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxPerctMissindData.Location = New System.Drawing.Point(9, 69)
        Me.lblMaxPerctMissindData.Name = "lblMaxPerctMissindData"
        Me.lblMaxPerctMissindData.Size = New System.Drawing.Size(169, 19)
        Me.lblMaxPerctMissindData.TabIndex = 29
        Me.lblMaxPerctMissindData.Text = "Max  Missing Data"
        '
        'lblMaxDurationMissingData
        '
        Me.lblMaxDurationMissingData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxDurationMissingData.Location = New System.Drawing.Point(9, 45)
        Me.lblMaxDurationMissingData.Name = "lblMaxDurationMissingData"
        Me.lblMaxDurationMissingData.Size = New System.Drawing.Size(160, 20)
        Me.lblMaxDurationMissingData.TabIndex = 27
        Me.lblMaxDurationMissingData.Text = "Max Duration Missing Data"
        '
        'lblMaxMissingDays
        '
        Me.lblMaxMissingDays.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxMissingDays.Location = New System.Drawing.Point(9, 22)
        Me.lblMaxMissingDays.Name = "lblMaxMissingDays"
        Me.lblMaxMissingDays.Size = New System.Drawing.Size(169, 20)
        Me.lblMaxMissingDays.TabIndex = 25
        Me.lblMaxMissingDays.Text = "Max Missing Days"
        '
        'grpMissingDataOpts
        '
        Me.grpMissingDataOpts.Controls.Add(Me.ucrChkInterpMissingEntries)
        Me.grpMissingDataOpts.Controls.Add(Me.ucrChkInterpMissingDays)
        Me.grpMissingDataOpts.Location = New System.Drawing.Point(9, 106)
        Me.grpMissingDataOpts.Name = "grpMissingDataOpts"
        Me.grpMissingDataOpts.Size = New System.Drawing.Size(198, 66)
        Me.grpMissingDataOpts.TabIndex = 31
        Me.grpMissingDataOpts.TabStop = False
        Me.grpMissingDataOpts.Text = "Missing Data Options"
        '
        'ucrChkInterpMissingEntries
        '
        Me.ucrChkInterpMissingEntries.AutoSize = True
        Me.ucrChkInterpMissingEntries.Checked = False
        Me.ucrChkInterpMissingEntries.Location = New System.Drawing.Point(2, 38)
        Me.ucrChkInterpMissingEntries.Name = "ucrChkInterpMissingEntries"
        Me.ucrChkInterpMissingEntries.Size = New System.Drawing.Size(188, 23)
        Me.ucrChkInterpMissingEntries.TabIndex = 5
        '
        'ucrChkInterpMissingDays
        '
        Me.ucrChkInterpMissingDays.AutoSize = True
        Me.ucrChkInterpMissingDays.Checked = False
        Me.ucrChkInterpMissingDays.Location = New System.Drawing.Point(2, 16)
        Me.ucrChkInterpMissingDays.Name = "ucrChkInterpMissingDays"
        Me.ucrChkInterpMissingDays.Size = New System.Drawing.Size(168, 23)
        Me.ucrChkInterpMissingDays.TabIndex = 6
        '
        'ucrNudMaxDurationMissingData
        '
        Me.ucrNudMaxDurationMissingData.AutoSize = True
        Me.ucrNudMaxDurationMissingData.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxDurationMissingData.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxDurationMissingData.Location = New System.Drawing.Point(184, 69)
        Me.ucrNudMaxDurationMissingData.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxDurationMissingData.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxDurationMissingData.Name = "ucrNudMaxDurationMissingData"
        Me.ucrNudMaxDurationMissingData.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxDurationMissingData.TabIndex = 30
        Me.ucrNudMaxDurationMissingData.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxMissingDays
        '
        Me.ucrNudMaxMissingDays.AutoSize = True
        Me.ucrNudMaxMissingDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxMissingDays.Location = New System.Drawing.Point(184, 22)
        Me.ucrNudMaxMissingDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxMissingDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingDays.Name = "ucrNudMaxMissingDays"
        Me.ucrNudMaxMissingDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxMissingDays.TabIndex = 26
        Me.ucrNudMaxMissingDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxMissingData
        '
        Me.ucrNudMaxMissingData.AutoSize = True
        Me.ucrNudMaxMissingData.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingData.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxMissingData.Location = New System.Drawing.Point(184, 45)
        Me.ucrNudMaxMissingData.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxMissingData.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingData.Name = "ucrNudMaxMissingData"
        Me.ucrNudMaxMissingData.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxMissingData.TabIndex = 28
        Me.ucrNudMaxMissingData.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(0, 189)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(259, 29)
        Me.ucrSdgButtons.TabIndex = 3
        '
        'sdgMissingOptionsEvapotranspiration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 229)
        Me.Controls.Add(Me.lblMaxPerctMissindData)
        Me.Controls.Add(Me.ucrNudMaxDurationMissingData)
        Me.Controls.Add(Me.ucrNudMaxMissingDays)
        Me.Controls.Add(Me.lblMaxDurationMissingData)
        Me.Controls.Add(Me.lblMaxMissingDays)
        Me.Controls.Add(Me.ucrNudMaxMissingData)
        Me.Controls.Add(Me.grpMissingDataOpts)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgMissingOptionsEvapotranspiration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Missing Options Evapotranspiration"
        Me.grpMissingDataOpts.ResumeLayout(False)
        Me.grpMissingDataOpts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents lblMaxPerctMissindData As Label
    Friend WithEvents ucrNudMaxDurationMissingData As ucrNud
    Friend WithEvents ucrNudMaxMissingDays As ucrNud
    Friend WithEvents lblMaxDurationMissingData As Label
    Friend WithEvents lblMaxMissingDays As Label
    Friend WithEvents ucrNudMaxMissingData As ucrNud
    Friend WithEvents grpMissingDataOpts As GroupBox
    Friend WithEvents ucrChkInterpMissingEntries As ucrCheck
    Friend WithEvents ucrChkInterpMissingDays As ucrCheck
End Class
