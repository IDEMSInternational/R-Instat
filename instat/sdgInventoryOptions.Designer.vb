<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgInventoryOptions
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
        Me.lblMissingColour = New System.Windows.Forms.Label()
        Me.lblNonMissingColour = New System.Windows.Forms.Label()
        Me.ucrColourMissing = New instat.ucrColors()
        Me.ucrColorsNonMissing = New instat.ucrColors()
        Me.ucrChkDisplayRainday = New instat.ucrCheck()
        Me.grpDisplayraindays = New System.Windows.Forms.GroupBox()
        Me.ucrColorsDryColour = New instat.ucrColors()
        Me.ucrInputDryLabel = New instat.ucrInputTextBox()
        Me.ucrInputRainLabel = New instat.ucrInputTextBox()
        Me.lblRainThreshold = New System.Windows.Forms.Label()
        Me.lblRainColour = New System.Windows.Forms.Label()
        Me.lblDryColour = New System.Windows.Forms.Label()
        Me.lblRainLabel = New System.Windows.Forms.Label()
        Me.lblDryLabel = New System.Windows.Forms.Label()
        Me.ucrNudRainThreshold = New instat.ucrNud()
        Me.ucrSdgLayerBase = New instat.ucrButtonsSubdialogue()
        Me.ucrColorsRain = New instat.ucrColors()
        Me.grpDisplayraindays.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMissingColour
        '
        Me.lblMissingColour.AutoSize = True
        Me.lblMissingColour.Location = New System.Drawing.Point(12, 19)
        Me.lblMissingColour.Name = "lblMissingColour"
        Me.lblMissingColour.Size = New System.Drawing.Size(75, 13)
        Me.lblMissingColour.TabIndex = 0
        Me.lblMissingColour.Text = "Missing Colour"
        '
        'lblNonMissingColour
        '
        Me.lblNonMissingColour.AutoSize = True
        Me.lblNonMissingColour.Location = New System.Drawing.Point(12, 57)
        Me.lblNonMissingColour.Name = "lblNonMissingColour"
        Me.lblNonMissingColour.Size = New System.Drawing.Size(98, 13)
        Me.lblNonMissingColour.TabIndex = 1
        Me.lblNonMissingColour.Text = "Non Missing Colour"
        '
        'ucrColourMissing
        '
        Me.ucrColourMissing.AddQuotesIfUnrecognised = True
        Me.ucrColourMissing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrColourMissing.GetSetSelectedIndex = -1
        Me.ucrColourMissing.IsReadOnly = False
        Me.ucrColourMissing.Location = New System.Drawing.Point(172, 19)
        Me.ucrColourMissing.Name = "ucrColourMissing"
        Me.ucrColourMissing.Size = New System.Drawing.Size(63, 21)
        Me.ucrColourMissing.TabIndex = 115
        '
        'ucrColorsNonMissing
        '
        Me.ucrColorsNonMissing.AddQuotesIfUnrecognised = True
        Me.ucrColorsNonMissing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrColorsNonMissing.GetSetSelectedIndex = -1
        Me.ucrColorsNonMissing.IsReadOnly = False
        Me.ucrColorsNonMissing.Location = New System.Drawing.Point(172, 57)
        Me.ucrColorsNonMissing.Name = "ucrColorsNonMissing"
        Me.ucrColorsNonMissing.Size = New System.Drawing.Size(63, 21)
        Me.ucrColorsNonMissing.TabIndex = 116
        '
        'ucrChkDisplayRainday
        '
        Me.ucrChkDisplayRainday.AutoSize = True
        Me.ucrChkDisplayRainday.Checked = False
        Me.ucrChkDisplayRainday.Location = New System.Drawing.Point(15, 103)
        Me.ucrChkDisplayRainday.Name = "ucrChkDisplayRainday"
        Me.ucrChkDisplayRainday.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkDisplayRainday.TabIndex = 117
        '
        'grpDisplayraindays
        '
        Me.grpDisplayraindays.Controls.Add(Me.ucrColorsRain)
        Me.grpDisplayraindays.Controls.Add(Me.ucrColorsDryColour)
        Me.grpDisplayraindays.Controls.Add(Me.ucrInputDryLabel)
        Me.grpDisplayraindays.Controls.Add(Me.ucrInputRainLabel)
        Me.grpDisplayraindays.Controls.Add(Me.lblRainThreshold)
        Me.grpDisplayraindays.Controls.Add(Me.lblRainColour)
        Me.grpDisplayraindays.Controls.Add(Me.lblDryColour)
        Me.grpDisplayraindays.Controls.Add(Me.lblRainLabel)
        Me.grpDisplayraindays.Controls.Add(Me.lblDryLabel)
        Me.grpDisplayraindays.Controls.Add(Me.ucrNudRainThreshold)
        Me.grpDisplayraindays.Location = New System.Drawing.Point(15, 135)
        Me.grpDisplayraindays.Name = "grpDisplayraindays"
        Me.grpDisplayraindays.Size = New System.Drawing.Size(296, 180)
        Me.grpDisplayraindays.TabIndex = 118
        Me.grpDisplayraindays.TabStop = False
        Me.grpDisplayraindays.Text = "Display Rain Days"
        '
        'ucrColorsDryColour
        '
        Me.ucrColorsDryColour.AddQuotesIfUnrecognised = True
        Me.ucrColorsDryColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrColorsDryColour.GetSetSelectedIndex = -1
        Me.ucrColorsDryColour.IsReadOnly = False
        Me.ucrColorsDryColour.Location = New System.Drawing.Point(157, 146)
        Me.ucrColorsDryColour.Name = "ucrColorsDryColour"
        Me.ucrColorsDryColour.Size = New System.Drawing.Size(63, 21)
        Me.ucrColorsDryColour.TabIndex = 120
        '
        'ucrInputDryLabel
        '
        Me.ucrInputDryLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputDryLabel.AutoSize = True
        Me.ucrInputDryLabel.IsMultiline = False
        Me.ucrInputDryLabel.IsReadOnly = False
        Me.ucrInputDryLabel.Location = New System.Drawing.Point(157, 55)
        Me.ucrInputDryLabel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputDryLabel.Name = "ucrInputDryLabel"
        Me.ucrInputDryLabel.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDryLabel.TabIndex = 120
        '
        'ucrInputRainLabel
        '
        Me.ucrInputRainLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputRainLabel.AutoSize = True
        Me.ucrInputRainLabel.IsMultiline = False
        Me.ucrInputRainLabel.IsReadOnly = False
        Me.ucrInputRainLabel.Location = New System.Drawing.Point(157, 22)
        Me.ucrInputRainLabel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputRainLabel.Name = "ucrInputRainLabel"
        Me.ucrInputRainLabel.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputRainLabel.TabIndex = 119
        '
        'lblRainThreshold
        '
        Me.lblRainThreshold.AutoSize = True
        Me.lblRainThreshold.Location = New System.Drawing.Point(6, 89)
        Me.lblRainThreshold.Name = "lblRainThreshold"
        Me.lblRainThreshold.Size = New System.Drawing.Size(109, 13)
        Me.lblRainThreshold.TabIndex = 7
        Me.lblRainThreshold.Text = "Rain Threshold Value"
        '
        'lblRainColour
        '
        Me.lblRainColour.AutoSize = True
        Me.lblRainColour.Location = New System.Drawing.Point(6, 121)
        Me.lblRainColour.Name = "lblRainColour"
        Me.lblRainColour.Size = New System.Drawing.Size(62, 13)
        Me.lblRainColour.TabIndex = 6
        Me.lblRainColour.Text = "Rain Colour"
        '
        'lblDryColour
        '
        Me.lblDryColour.AutoSize = True
        Me.lblDryColour.Location = New System.Drawing.Point(6, 152)
        Me.lblDryColour.Name = "lblDryColour"
        Me.lblDryColour.Size = New System.Drawing.Size(56, 13)
        Me.lblDryColour.TabIndex = 5
        Me.lblDryColour.Text = "Dry Colour"
        '
        'lblRainLabel
        '
        Me.lblRainLabel.AutoSize = True
        Me.lblRainLabel.Location = New System.Drawing.Point(6, 26)
        Me.lblRainLabel.Name = "lblRainLabel"
        Me.lblRainLabel.Size = New System.Drawing.Size(58, 13)
        Me.lblRainLabel.TabIndex = 3
        Me.lblRainLabel.Text = "Rain Label"
        '
        'lblDryLabel
        '
        Me.lblDryLabel.AutoSize = True
        Me.lblDryLabel.Location = New System.Drawing.Point(6, 58)
        Me.lblDryLabel.Name = "lblDryLabel"
        Me.lblDryLabel.Size = New System.Drawing.Size(52, 13)
        Me.lblDryLabel.TabIndex = 4
        Me.lblDryLabel.Text = "Dry Label"
        '
        'ucrNudRainThreshold
        '
        Me.ucrNudRainThreshold.AutoSize = True
        Me.ucrNudRainThreshold.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRainThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRainThreshold.Location = New System.Drawing.Point(157, 85)
        Me.ucrNudRainThreshold.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRainThreshold.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRainThreshold.Name = "ucrNudRainThreshold"
        Me.ucrNudRainThreshold.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudRainThreshold.TabIndex = 121
        Me.ucrNudRainThreshold.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSdgLayerBase
        '
        Me.ucrSdgLayerBase.AutoSize = True
        Me.ucrSdgLayerBase.Location = New System.Drawing.Point(37, 326)
        Me.ucrSdgLayerBase.Name = "ucrSdgLayerBase"
        Me.ucrSdgLayerBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgLayerBase.TabIndex = 119
        '
        'ucrColorsRain
        '
        Me.ucrColorsRain.AddQuotesIfUnrecognised = True
        Me.ucrColorsRain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrColorsRain.GetSetSelectedIndex = -1
        Me.ucrColorsRain.IsReadOnly = False
        Me.ucrColorsRain.Location = New System.Drawing.Point(157, 116)
        Me.ucrColorsRain.Name = "ucrColorsRain"
        Me.ucrColorsRain.Size = New System.Drawing.Size(63, 21)
        Me.ucrColorsRain.TabIndex = 120
        '
        'sdgInventoryOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 362)
        Me.Controls.Add(Me.ucrSdgLayerBase)
        Me.Controls.Add(Me.grpDisplayraindays)
        Me.Controls.Add(Me.ucrChkDisplayRainday)
        Me.Controls.Add(Me.ucrColorsNonMissing)
        Me.Controls.Add(Me.ucrColourMissing)
        Me.Controls.Add(Me.lblNonMissingColour)
        Me.Controls.Add(Me.lblMissingColour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgInventoryOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Options"
        Me.grpDisplayraindays.ResumeLayout(False)
        Me.grpDisplayraindays.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMissingColour As Label
    Friend WithEvents lblNonMissingColour As Label
    Friend WithEvents ucrColourMissing As ucrColors
    Friend WithEvents ucrColorsNonMissing As ucrColors
    Friend WithEvents ucrChkDisplayRainday As ucrCheck
    Friend WithEvents grpDisplayraindays As GroupBox
    Friend WithEvents ucrInputDryLabel As ucrInputTextBox
    Friend WithEvents ucrInputRainLabel As ucrInputTextBox
    Friend WithEvents ucrNudRainThreshold As ucrNud
    Friend WithEvents ucrColorsDryColour As ucrColors
    Friend WithEvents ucrSdgLayerBase As ucrButtonsSubdialogue
    Friend WithEvents lblRainThreshold As Label
    Friend WithEvents lblRainColour As Label
    Friend WithEvents lblDryColour As Label
    Friend WithEvents lblRainLabel As Label
    Friend WithEvents lblDryLabel As Label
    Friend WithEvents ucrColorsRain As ucrColors
End Class
