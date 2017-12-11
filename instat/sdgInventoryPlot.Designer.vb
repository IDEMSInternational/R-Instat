<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgInventoryPlot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgInventoryPlot))
        Me.lblMissing = New System.Windows.Forms.Label()
        Me.lblNonMissing = New System.Windows.Forms.Label()
        Me.grpRainyDays = New System.Windows.Forms.GroupBox()
        Me.lblDryColour = New System.Windows.Forms.Label()
        Me.lblRainLabel = New System.Windows.Forms.Label()
        Me.lblRainColour = New System.Windows.Forms.Label()
        Me.lblDryLabel = New System.Windows.Forms.Label()
        Me.lblRainThresholdValue = New System.Windows.Forms.Label()
        Me.ucrInputRain = New instat.ucrInputTextBox()
        Me.ucrDryColour = New instat.ucrColors()
        Me.ucrRainColour = New instat.ucrColors()
        Me.ucrInputDry = New instat.ucrInputTextBox()
        Me.ucrNudThresholdValue = New instat.ucrNud()
        Me.ucrColourNonMissing = New instat.ucrColors()
        Me.ucrColourMissing = New instat.ucrColors()
        Me.ucrChkDisplayRainDays = New instat.ucrCheck()
        Me.ucrButtonsInventoryplot = New instat.ucrButtonsSubdialogue()
        Me.grpRainyDays.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMissing
        '
        resources.ApplyResources(Me.lblMissing, "lblMissing")
        Me.lblMissing.Name = "lblMissing"
        '
        'lblNonMissing
        '
        resources.ApplyResources(Me.lblNonMissing, "lblNonMissing")
        Me.lblNonMissing.Name = "lblNonMissing"
        '
        'grpRainyDays
        '
        Me.grpRainyDays.Controls.Add(Me.ucrInputRain)
        Me.grpRainyDays.Controls.Add(Me.lblDryColour)
        Me.grpRainyDays.Controls.Add(Me.lblRainLabel)
        Me.grpRainyDays.Controls.Add(Me.lblRainColour)
        Me.grpRainyDays.Controls.Add(Me.lblDryLabel)
        Me.grpRainyDays.Controls.Add(Me.ucrDryColour)
        Me.grpRainyDays.Controls.Add(Me.lblRainThresholdValue)
        Me.grpRainyDays.Controls.Add(Me.ucrRainColour)
        Me.grpRainyDays.Controls.Add(Me.ucrInputDry)
        Me.grpRainyDays.Controls.Add(Me.ucrNudThresholdValue)
        resources.ApplyResources(Me.grpRainyDays, "grpRainyDays")
        Me.grpRainyDays.Name = "grpRainyDays"
        Me.grpRainyDays.TabStop = False
        '
        'lblDryColour
        '
        resources.ApplyResources(Me.lblDryColour, "lblDryColour")
        Me.lblDryColour.Name = "lblDryColour"
        '
        'lblRainLabel
        '
        resources.ApplyResources(Me.lblRainLabel, "lblRainLabel")
        Me.lblRainLabel.Name = "lblRainLabel"
        '
        'lblRainColour
        '
        resources.ApplyResources(Me.lblRainColour, "lblRainColour")
        Me.lblRainColour.Name = "lblRainColour"
        '
        'lblDryLabel
        '
        resources.ApplyResources(Me.lblDryLabel, "lblDryLabel")
        Me.lblDryLabel.Name = "lblDryLabel"
        '
        'lblRainThresholdValue
        '
        resources.ApplyResources(Me.lblRainThresholdValue, "lblRainThresholdValue")
        Me.lblRainThresholdValue.Name = "lblRainThresholdValue"
        '
        'ucrInputRain
        '
        Me.ucrInputRain.AddQuotesIfUnrecognised = True
        Me.ucrInputRain.IsMultiline = False
        Me.ucrInputRain.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputRain, "ucrInputRain")
        Me.ucrInputRain.Name = "ucrInputRain"
        '
        'ucrDryColour
        '
        Me.ucrDryColour.AddQuotesIfUnrecognised = True
        Me.ucrDryColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrDryColour, "ucrDryColour")
        Me.ucrDryColour.Name = "ucrDryColour"
        '
        'ucrRainColour
        '
        Me.ucrRainColour.AddQuotesIfUnrecognised = True
        Me.ucrRainColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrRainColour, "ucrRainColour")
        Me.ucrRainColour.Name = "ucrRainColour"
        '
        'ucrInputDry
        '
        Me.ucrInputDry.AddQuotesIfUnrecognised = True
        Me.ucrInputDry.IsMultiline = False
        Me.ucrInputDry.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDry, "ucrInputDry")
        Me.ucrInputDry.Name = "ucrInputDry"
        '
        'ucrNudThresholdValue
        '
        Me.ucrNudThresholdValue.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholdValue.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudThresholdValue, "ucrNudThresholdValue")
        Me.ucrNudThresholdValue.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThresholdValue.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholdValue.Name = "ucrNudThresholdValue"
        Me.ucrNudThresholdValue.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrColourNonMissing
        '
        Me.ucrColourNonMissing.AddQuotesIfUnrecognised = True
        Me.ucrColourNonMissing.IsReadOnly = False
        resources.ApplyResources(Me.ucrColourNonMissing, "ucrColourNonMissing")
        Me.ucrColourNonMissing.Name = "ucrColourNonMissing"
        '
        'ucrColourMissing
        '
        Me.ucrColourMissing.AddQuotesIfUnrecognised = True
        Me.ucrColourMissing.IsReadOnly = False
        resources.ApplyResources(Me.ucrColourMissing, "ucrColourMissing")
        Me.ucrColourMissing.Name = "ucrColourMissing"
        '
        'ucrChkDisplayRainDays
        '
        Me.ucrChkDisplayRainDays.Checked = False
        resources.ApplyResources(Me.ucrChkDisplayRainDays, "ucrChkDisplayRainDays")
        Me.ucrChkDisplayRainDays.Name = "ucrChkDisplayRainDays"
        '
        'ucrButtonsInventoryplot
        '
        resources.ApplyResources(Me.ucrButtonsInventoryplot, "ucrButtonsInventoryplot")
        Me.ucrButtonsInventoryplot.Name = "ucrButtonsInventoryplot"
        '
        'sdgInventoryPlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpRainyDays)
        Me.Controls.Add(Me.lblNonMissing)
        Me.Controls.Add(Me.lblMissing)
        Me.Controls.Add(Me.ucrColourNonMissing)
        Me.Controls.Add(Me.ucrColourMissing)
        Me.Controls.Add(Me.ucrChkDisplayRainDays)
        Me.Controls.Add(Me.ucrButtonsInventoryplot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgInventoryPlot"
        Me.grpRainyDays.ResumeLayout(False)
        Me.grpRainyDays.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrButtonsInventoryplot As ucrButtonsSubdialogue
    Friend WithEvents ucrChkDisplayRainDays As ucrCheck
    Friend WithEvents ucrColourMissing As ucrColors
    Friend WithEvents ucrColourNonMissing As ucrColors
    Friend WithEvents lblMissing As Label
    Friend WithEvents lblNonMissing As Label
    Friend WithEvents grpRainyDays As GroupBox
    Friend WithEvents ucrInputRain As ucrInputTextBox
    Friend WithEvents lblDryColour As Label
    Friend WithEvents lblRainLabel As Label
    Friend WithEvents lblRainColour As Label
    Friend WithEvents lblDryLabel As Label
    Friend WithEvents ucrDryColour As ucrColors
    Friend WithEvents lblRainThresholdValue As Label
    Friend WithEvents ucrRainColour As ucrColors
    Friend WithEvents ucrInputDry As ucrInputTextBox
    Friend WithEvents ucrNudThresholdValue As ucrNud
End Class
