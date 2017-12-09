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
        Me.ucrChkDisplayRainDays = New instat.ucrCheck()
        Me.ucrButtonsInventoryplot = New instat.ucrButtonsSubdialogue()
        Me.ucrColourMissing = New instat.ucrColors()
        Me.ucrColourNonMissing = New instat.ucrColors()
        Me.lblMissing = New System.Windows.Forms.Label()
        Me.lblNonMissing = New System.Windows.Forms.Label()
        Me.grpRainyDays = New System.Windows.Forms.GroupBox()
        Me.ucrInputRain = New instat.ucrInputTextBox()
        Me.lblDryColour = New System.Windows.Forms.Label()
        Me.lblRainLabel = New System.Windows.Forms.Label()
        Me.lblRainColour = New System.Windows.Forms.Label()
        Me.lblDryLabel = New System.Windows.Forms.Label()
        Me.ucrDryColour = New instat.ucrColors()
        Me.lblRainThresholdValue = New System.Windows.Forms.Label()
        Me.ucrRainColour = New instat.ucrColors()
        Me.ucrInputDry = New instat.ucrInputTextBox()
        Me.ucrNudThresholdValue = New instat.ucrNud()
        Me.grpRainyDays.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrChkDisplayRainDays
        '
        Me.ucrChkDisplayRainDays.Checked = False
        Me.ucrChkDisplayRainDays.Location = New System.Drawing.Point(12, 102)
        Me.ucrChkDisplayRainDays.Name = "ucrChkDisplayRainDays"
        Me.ucrChkDisplayRainDays.Size = New System.Drawing.Size(151, 20)
        Me.ucrChkDisplayRainDays.TabIndex = 19
        '
        'ucrButtonsInventoryplot
        '
        Me.ucrButtonsInventoryplot.Location = New System.Drawing.Point(67, 339)
        Me.ucrButtonsInventoryplot.Name = "ucrButtonsInventoryplot"
        Me.ucrButtonsInventoryplot.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsInventoryplot.TabIndex = 0
        '
        'ucrColourMissing
        '
        Me.ucrColourMissing.AddQuotesIfUnrecognised = True
        Me.ucrColourMissing.IsReadOnly = False
        Me.ucrColourMissing.Location = New System.Drawing.Point(120, 21)
        Me.ucrColourMissing.Name = "ucrColourMissing"
        Me.ucrColourMissing.Size = New System.Drawing.Size(89, 21)
        Me.ucrColourMissing.TabIndex = 32
        '
        'ucrColourNonMissing
        '
        Me.ucrColourNonMissing.AddQuotesIfUnrecognised = True
        Me.ucrColourNonMissing.IsReadOnly = False
        Me.ucrColourNonMissing.Location = New System.Drawing.Point(120, 56)
        Me.ucrColourNonMissing.Name = "ucrColourNonMissing"
        Me.ucrColourNonMissing.Size = New System.Drawing.Size(89, 21)
        Me.ucrColourNonMissing.TabIndex = 31
        '
        'lblMissing
        '
        Me.lblMissing.AutoSize = True
        Me.lblMissing.Location = New System.Drawing.Point(13, 21)
        Me.lblMissing.Name = "lblMissing"
        Me.lblMissing.Size = New System.Drawing.Size(75, 13)
        Me.lblMissing.TabIndex = 34
        Me.lblMissing.Text = "Missing Colour"
        '
        'lblNonMissing
        '
        Me.lblNonMissing.AutoSize = True
        Me.lblNonMissing.Location = New System.Drawing.Point(13, 56)
        Me.lblNonMissing.Name = "lblNonMissing"
        Me.lblNonMissing.Size = New System.Drawing.Size(98, 13)
        Me.lblNonMissing.TabIndex = 33
        Me.lblNonMissing.Text = "Non Missing Colour"
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
        Me.grpRainyDays.Location = New System.Drawing.Point(12, 128)
        Me.grpRainyDays.Name = "grpRainyDays"
        Me.grpRainyDays.Size = New System.Drawing.Size(261, 203)
        Me.grpRainyDays.TabIndex = 35
        Me.grpRainyDays.TabStop = False
        '
        'ucrInputRain
        '
        Me.ucrInputRain.AddQuotesIfUnrecognised = True
        Me.ucrInputRain.IsMultiline = False
        Me.ucrInputRain.IsReadOnly = False
        Me.ucrInputRain.Location = New System.Drawing.Point(104, 19)
        Me.ucrInputRain.Name = "ucrInputRain"
        Me.ucrInputRain.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputRain.TabIndex = 38
        '
        'lblDryColour
        '
        Me.lblDryColour.AutoSize = True
        Me.lblDryColour.Location = New System.Drawing.Point(18, 153)
        Me.lblDryColour.Name = "lblDryColour"
        Me.lblDryColour.Size = New System.Drawing.Size(56, 13)
        Me.lblDryColour.TabIndex = 43
        Me.lblDryColour.Text = "Dry Colour"
        '
        'lblRainLabel
        '
        Me.lblRainLabel.AutoSize = True
        Me.lblRainLabel.Location = New System.Drawing.Point(18, 19)
        Me.lblRainLabel.Name = "lblRainLabel"
        Me.lblRainLabel.Size = New System.Drawing.Size(58, 13)
        Me.lblRainLabel.TabIndex = 35
        Me.lblRainLabel.Text = "Rain Label"
        '
        'lblRainColour
        '
        Me.lblRainColour.AutoSize = True
        Me.lblRainColour.Location = New System.Drawing.Point(18, 118)
        Me.lblRainColour.Name = "lblRainColour"
        Me.lblRainColour.Size = New System.Drawing.Size(62, 13)
        Me.lblRainColour.TabIndex = 44
        Me.lblRainColour.Text = "Rain Colour"
        '
        'lblDryLabel
        '
        Me.lblDryLabel.AutoSize = True
        Me.lblDryLabel.Location = New System.Drawing.Point(18, 44)
        Me.lblDryLabel.Name = "lblDryLabel"
        Me.lblDryLabel.Size = New System.Drawing.Size(52, 13)
        Me.lblDryLabel.TabIndex = 36
        Me.lblDryLabel.Text = "Dry Label"
        '
        'ucrDryColour
        '
        Me.ucrDryColour.AddQuotesIfUnrecognised = True
        Me.ucrDryColour.IsReadOnly = False
        Me.ucrDryColour.Location = New System.Drawing.Point(104, 153)
        Me.ucrDryColour.Name = "ucrDryColour"
        Me.ucrDryColour.Size = New System.Drawing.Size(89, 21)
        Me.ucrDryColour.TabIndex = 41
        '
        'lblRainThresholdValue
        '
        Me.lblRainThresholdValue.AutoSize = True
        Me.lblRainThresholdValue.Location = New System.Drawing.Point(18, 84)
        Me.lblRainThresholdValue.Name = "lblRainThresholdValue"
        Me.lblRainThresholdValue.Size = New System.Drawing.Size(109, 13)
        Me.lblRainThresholdValue.TabIndex = 37
        Me.lblRainThresholdValue.Text = "Rain Threshold Value"
        '
        'ucrRainColour
        '
        Me.ucrRainColour.AddQuotesIfUnrecognised = True
        Me.ucrRainColour.IsReadOnly = False
        Me.ucrRainColour.Location = New System.Drawing.Point(104, 110)
        Me.ucrRainColour.Name = "ucrRainColour"
        Me.ucrRainColour.Size = New System.Drawing.Size(89, 21)
        Me.ucrRainColour.TabIndex = 42
        '
        'ucrInputDry
        '
        Me.ucrInputDry.AddQuotesIfUnrecognised = True
        Me.ucrInputDry.IsMultiline = False
        Me.ucrInputDry.IsReadOnly = False
        Me.ucrInputDry.Location = New System.Drawing.Point(104, 44)
        Me.ucrInputDry.Name = "ucrInputDry"
        Me.ucrInputDry.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDry.TabIndex = 39
        '
        'ucrNudThresholdValue
        '
        Me.ucrNudThresholdValue.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholdValue.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThresholdValue.Location = New System.Drawing.Point(143, 84)
        Me.ucrNudThresholdValue.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThresholdValue.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholdValue.Name = "ucrNudThresholdValue"
        Me.ucrNudThresholdValue.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThresholdValue.TabIndex = 40
        Me.ucrNudThresholdValue.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'sdgInventoryPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 381)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventory Plot"
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
