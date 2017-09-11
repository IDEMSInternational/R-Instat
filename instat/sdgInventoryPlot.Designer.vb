<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgInventoryPlot
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
        Me.ucrChkDisplayRainDays = New instat.ucrCheck()
        Me.ucrButtonsInventoryplot = New instat.ucrButtonsSubdialogue()
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
        Me.SuspendLayout()
        '
        'ucrChkDisplayRainDays
        '
        Me.ucrChkDisplayRainDays.Checked = False
        Me.ucrChkDisplayRainDays.Location = New System.Drawing.Point(12, 12)
        Me.ucrChkDisplayRainDays.Name = "ucrChkDisplayRainDays"
        Me.ucrChkDisplayRainDays.Size = New System.Drawing.Size(151, 20)
        Me.ucrChkDisplayRainDays.TabIndex = 19
        '
        'ucrButtonsInventoryplot
        '
        Me.ucrButtonsInventoryplot.Location = New System.Drawing.Point(197, 428)
        Me.ucrButtonsInventoryplot.Name = "ucrButtonsInventoryplot"
        Me.ucrButtonsInventoryplot.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsInventoryplot.TabIndex = 0
        '
        'ucrInputRain
        '
        Me.ucrInputRain.AddQuotesIfUnrecognised = True
        Me.ucrInputRain.IsMultiline = False
        Me.ucrInputRain.IsReadOnly = False
        Me.ucrInputRain.Location = New System.Drawing.Point(98, 44)
        Me.ucrInputRain.Name = "ucrInputRain"
        Me.ucrInputRain.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputRain.TabIndex = 28
        '
        'lblDryColour
        '
        Me.lblDryColour.AutoSize = True
        Me.lblDryColour.Location = New System.Drawing.Point(12, 179)
        Me.lblDryColour.Name = "lblDryColour"
        Me.lblDryColour.Size = New System.Drawing.Size(56, 13)
        Me.lblDryColour.TabIndex = 33
        Me.lblDryColour.Text = "Dry Colour"
        '
        'lblRainLabel
        '
        Me.lblRainLabel.AutoSize = True
        Me.lblRainLabel.Location = New System.Drawing.Point(12, 44)
        Me.lblRainLabel.Name = "lblRainLabel"
        Me.lblRainLabel.Size = New System.Drawing.Size(58, 13)
        Me.lblRainLabel.TabIndex = 25
        Me.lblRainLabel.Text = "Rain Label"
        '
        'lblRainColour
        '
        Me.lblRainColour.AutoSize = True
        Me.lblRainColour.Location = New System.Drawing.Point(12, 144)
        Me.lblRainColour.Name = "lblRainColour"
        Me.lblRainColour.Size = New System.Drawing.Size(62, 13)
        Me.lblRainColour.TabIndex = 34
        Me.lblRainColour.Text = "Rain Colour"
        '
        'lblDryLabel
        '
        Me.lblDryLabel.AutoSize = True
        Me.lblDryLabel.Location = New System.Drawing.Point(12, 69)
        Me.lblDryLabel.Name = "lblDryLabel"
        Me.lblDryLabel.Size = New System.Drawing.Size(52, 13)
        Me.lblDryLabel.TabIndex = 26
        Me.lblDryLabel.Text = "Dry Label"
        '
        'ucrDryColour
        '
        Me.ucrDryColour.AddQuotesIfUnrecognised = True
        Me.ucrDryColour.IsReadOnly = False
        Me.ucrDryColour.Location = New System.Drawing.Point(98, 179)
        Me.ucrDryColour.Name = "ucrDryColour"
        Me.ucrDryColour.Size = New System.Drawing.Size(89, 21)
        Me.ucrDryColour.TabIndex = 31
        '
        'lblRainThresholdValue
        '
        Me.lblRainThresholdValue.AutoSize = True
        Me.lblRainThresholdValue.Location = New System.Drawing.Point(12, 109)
        Me.lblRainThresholdValue.Name = "lblRainThresholdValue"
        Me.lblRainThresholdValue.Size = New System.Drawing.Size(109, 13)
        Me.lblRainThresholdValue.TabIndex = 27
        Me.lblRainThresholdValue.Text = "Rain Threshold Value"
        '
        'ucrRainColour
        '
        Me.ucrRainColour.AddQuotesIfUnrecognised = True
        Me.ucrRainColour.IsReadOnly = False
        Me.ucrRainColour.Location = New System.Drawing.Point(98, 136)
        Me.ucrRainColour.Name = "ucrRainColour"
        Me.ucrRainColour.Size = New System.Drawing.Size(89, 21)
        Me.ucrRainColour.TabIndex = 32
        '
        'ucrInputDry
        '
        Me.ucrInputDry.AddQuotesIfUnrecognised = True
        Me.ucrInputDry.IsMultiline = False
        Me.ucrInputDry.IsReadOnly = False
        Me.ucrInputDry.Location = New System.Drawing.Point(98, 69)
        Me.ucrInputDry.Name = "ucrInputDry"
        Me.ucrInputDry.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDry.TabIndex = 29
        '
        'ucrNudThresholdValue
        '
        Me.ucrNudThresholdValue.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholdValue.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThresholdValue.Location = New System.Drawing.Point(137, 109)
        Me.ucrNudThresholdValue.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThresholdValue.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholdValue.Name = "ucrNudThresholdValue"
        Me.ucrNudThresholdValue.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThresholdValue.TabIndex = 30
        Me.ucrNudThresholdValue.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'sdgInventoryPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 470)
        Me.Controls.Add(Me.ucrInputRain)
        Me.Controls.Add(Me.lblDryColour)
        Me.Controls.Add(Me.lblRainLabel)
        Me.Controls.Add(Me.lblRainColour)
        Me.Controls.Add(Me.lblDryLabel)
        Me.Controls.Add(Me.ucrDryColour)
        Me.Controls.Add(Me.lblRainThresholdValue)
        Me.Controls.Add(Me.ucrRainColour)
        Me.Controls.Add(Me.ucrInputDry)
        Me.Controls.Add(Me.ucrNudThresholdValue)
        Me.Controls.Add(Me.ucrChkDisplayRainDays)
        Me.Controls.Add(Me.ucrButtonsInventoryplot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgInventoryPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventory Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrButtonsInventoryplot As ucrButtonsSubdialogue
    Friend WithEvents ucrChkDisplayRainDays As ucrCheck
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
