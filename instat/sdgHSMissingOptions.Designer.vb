<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgHSMissingOptions
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
        Me.gprMissingDataOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkInterpMissingEntries = New instat.ucrCheck()
        Me.ucrChkInterpMissingDays = New instat.ucrCheck()
        Me.ucrNudMaxMissingData = New instat.ucrNud()
        Me.ucrNudMaxDurationMissingData = New instat.ucrNud()
        Me.lblMaxMissingData = New System.Windows.Forms.Label()
        Me.lblMaxDurationMissingData = New System.Windows.Forms.Label()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.ucrNudMaxMissingDays = New instat.ucrNud()
        Me.lblMaxMissingDays = New System.Windows.Forms.Label()
        Me.gprMissingDataOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'gprMissingDataOptions
        '
        Me.gprMissingDataOptions.Controls.Add(Me.ucrChkInterpMissingEntries)
        Me.gprMissingDataOptions.Controls.Add(Me.ucrChkInterpMissingDays)
        Me.gprMissingDataOptions.Location = New System.Drawing.Point(11, 90)
        Me.gprMissingDataOptions.Name = "gprMissingDataOptions"
        Me.gprMissingDataOptions.Size = New System.Drawing.Size(200, 82)
        Me.gprMissingDataOptions.TabIndex = 17
        Me.gprMissingDataOptions.TabStop = False
        Me.gprMissingDataOptions.Text = "Missing Data Options"
        '
        'ucrChkInterpMissingEntries
        '
        Me.ucrChkInterpMissingEntries.AutoSize = True
        Me.ucrChkInterpMissingEntries.Checked = False
        Me.ucrChkInterpMissingEntries.Location = New System.Drawing.Point(7, 53)
        Me.ucrChkInterpMissingEntries.Name = "ucrChkInterpMissingEntries"
        Me.ucrChkInterpMissingEntries.Size = New System.Drawing.Size(183, 23)
        Me.ucrChkInterpMissingEntries.TabIndex = 1
        '
        'ucrChkInterpMissingDays
        '
        Me.ucrChkInterpMissingDays.AutoSize = True
        Me.ucrChkInterpMissingDays.Checked = False
        Me.ucrChkInterpMissingDays.Location = New System.Drawing.Point(7, 22)
        Me.ucrChkInterpMissingDays.Name = "ucrChkInterpMissingDays"
        Me.ucrChkInterpMissingDays.Size = New System.Drawing.Size(183, 23)
        Me.ucrChkInterpMissingDays.TabIndex = 0
        '
        'ucrNudMaxMissingData
        '
        Me.ucrNudMaxMissingData.AutoSize = True
        Me.ucrNudMaxMissingData.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingData.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxMissingData.Location = New System.Drawing.Point(151, 64)
        Me.ucrNudMaxMissingData.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxMissingData.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingData.Name = "ucrNudMaxMissingData"
        Me.ucrNudMaxMissingData.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxMissingData.TabIndex = 16
        Me.ucrNudMaxMissingData.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxDurationMissingData
        '
        Me.ucrNudMaxDurationMissingData.AutoSize = True
        Me.ucrNudMaxDurationMissingData.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxDurationMissingData.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxDurationMissingData.Location = New System.Drawing.Point(151, 38)
        Me.ucrNudMaxDurationMissingData.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxDurationMissingData.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxDurationMissingData.Name = "ucrNudMaxDurationMissingData"
        Me.ucrNudMaxDurationMissingData.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxDurationMissingData.TabIndex = 15
        Me.ucrNudMaxDurationMissingData.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMaxMissingData
        '
        Me.lblMaxMissingData.AutoSize = True
        Me.lblMaxMissingData.Location = New System.Drawing.Point(11, 64)
        Me.lblMaxMissingData.Name = "lblMaxMissingData"
        Me.lblMaxMissingData.Size = New System.Drawing.Size(91, 13)
        Me.lblMaxMissingData.TabIndex = 14
        Me.lblMaxMissingData.Text = "Max Missing Data"
        '
        'lblMaxDurationMissingData
        '
        Me.lblMaxDurationMissingData.AutoSize = True
        Me.lblMaxDurationMissingData.Location = New System.Drawing.Point(11, 39)
        Me.lblMaxDurationMissingData.Name = "lblMaxDurationMissingData"
        Me.lblMaxDurationMissingData.Size = New System.Drawing.Size(134, 13)
        Me.lblMaxDurationMissingData.TabIndex = 13
        Me.lblMaxDurationMissingData.Text = "Max Duration Missing Data"
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(11, 178)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(259, 29)
        Me.ucrSdgButtons.TabIndex = 12
        '
        'ucrNudMaxMissingDays
        '
        Me.ucrNudMaxMissingDays.AutoSize = True
        Me.ucrNudMaxMissingDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxMissingDays.Location = New System.Drawing.Point(151, 11)
        Me.ucrNudMaxMissingDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxMissingDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxMissingDays.Name = "ucrNudMaxMissingDays"
        Me.ucrNudMaxMissingDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxMissingDays.TabIndex = 11
        Me.ucrNudMaxMissingDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMaxMissingDays
        '
        Me.lblMaxMissingDays.AutoSize = True
        Me.lblMaxMissingDays.Location = New System.Drawing.Point(11, 11)
        Me.lblMaxMissingDays.Name = "lblMaxMissingDays"
        Me.lblMaxMissingDays.Size = New System.Drawing.Size(92, 13)
        Me.lblMaxMissingDays.TabIndex = 10
        Me.lblMaxMissingDays.Text = "Max Missing Days"
        '
        'sdgHSMissingOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 216)
        Me.Controls.Add(Me.gprMissingDataOptions)
        Me.Controls.Add(Me.ucrNudMaxMissingData)
        Me.Controls.Add(Me.ucrNudMaxDurationMissingData)
        Me.Controls.Add(Me.lblMaxMissingData)
        Me.Controls.Add(Me.lblMaxDurationMissingData)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.Controls.Add(Me.ucrNudMaxMissingDays)
        Me.Controls.Add(Me.lblMaxMissingDays)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgHSMissingOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hargreaves Samani Missing Options"
        Me.gprMissingDataOptions.ResumeLayout(False)
        Me.gprMissingDataOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gprMissingDataOptions As GroupBox
    Friend WithEvents ucrChkInterpMissingEntries As ucrCheck
    Friend WithEvents ucrChkInterpMissingDays As ucrCheck
    Friend WithEvents ucrNudMaxMissingData As ucrNud
    Friend WithEvents ucrNudMaxDurationMissingData As ucrNud
    Friend WithEvents lblMaxMissingData As Label
    Friend WithEvents lblMaxDurationMissingData As Label
    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents ucrNudMaxMissingDays As ucrNud
    Friend WithEvents lblMaxMissingDays As Label
End Class
