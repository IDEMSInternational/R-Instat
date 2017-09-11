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
        Me.ucrButtonsInventoryplot = New instat.ucrButtonsSubdialogue()
        Me.ucrChkDisplayRainDays = New instat.ucrCheck()
        Me.lblRainLabel = New System.Windows.Forms.Label()
        Me.lblDryLabel = New System.Windows.Forms.Label()
        Me.ucrInputRain = New instat.ucrInputTextBox()
        Me.ucrInputDry = New instat.ucrInputTextBox()
        Me.lblRainThresholdValue = New System.Windows.Forms.Label()
        Me.ucrNudThresholdValue = New instat.ucrNud()
        Me.ucrRainColour = New instat.ucrColors()
        Me.ucrDryColour = New instat.ucrColors()
        Me.lblRainColour = New System.Windows.Forms.Label()
        Me.lblDryColour = New System.Windows.Forms.Label()
        Me.grpDisplayRainDays = New System.Windows.Forms.GroupBox()
        Me.grpDisplayRainDays.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrButtonsInventoryplot
        '
        Me.ucrButtonsInventoryplot.Location = New System.Drawing.Point(197, 428)
        Me.ucrButtonsInventoryplot.Name = "ucrButtonsInventoryplot"
        Me.ucrButtonsInventoryplot.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsInventoryplot.TabIndex = 0
        '
        'ucrChkDisplayRainDays
        '
        Me.ucrChkDisplayRainDays.Checked = False
        Me.ucrChkDisplayRainDays.Location = New System.Drawing.Point(12, 12)
        Me.ucrChkDisplayRainDays.Name = "ucrChkDisplayRainDays"
        Me.ucrChkDisplayRainDays.Size = New System.Drawing.Size(151, 20)
        Me.ucrChkDisplayRainDays.TabIndex = 19
        '
        'lblRainLabel
        '
        Me.lblRainLabel.AutoSize = True
        Me.lblRainLabel.Location = New System.Drawing.Point(6, 16)
        Me.lblRainLabel.Name = "lblRainLabel"
        Me.lblRainLabel.Size = New System.Drawing.Size(58, 13)
        Me.lblRainLabel.TabIndex = 20
        Me.lblRainLabel.Text = "Rain Label"
        '
        'lblDryLabel
        '
        Me.lblDryLabel.AutoSize = True
        Me.lblDryLabel.Location = New System.Drawing.Point(6, 41)
        Me.lblDryLabel.Name = "lblDryLabel"
        Me.lblDryLabel.Size = New System.Drawing.Size(52, 13)
        Me.lblDryLabel.TabIndex = 20
        Me.lblDryLabel.Text = "Dry Label"
        '
        'ucrInputRain
        '
        Me.ucrInputRain.AddQuotesIfUnrecognised = True
        Me.ucrInputRain.IsMultiline = False
        Me.ucrInputRain.IsReadOnly = False
        Me.ucrInputRain.Location = New System.Drawing.Point(92, 16)
        Me.ucrInputRain.Name = "ucrInputRain"
        Me.ucrInputRain.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputRain.TabIndex = 21
        '
        'ucrInputDry
        '
        Me.ucrInputDry.AddQuotesIfUnrecognised = True
        Me.ucrInputDry.IsMultiline = False
        Me.ucrInputDry.IsReadOnly = False
        Me.ucrInputDry.Location = New System.Drawing.Point(92, 41)
        Me.ucrInputDry.Name = "ucrInputDry"
        Me.ucrInputDry.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDry.TabIndex = 21
        '
        'lblRainThresholdValue
        '
        Me.lblRainThresholdValue.AutoSize = True
        Me.lblRainThresholdValue.Location = New System.Drawing.Point(6, 81)
        Me.lblRainThresholdValue.Name = "lblRainThresholdValue"
        Me.lblRainThresholdValue.Size = New System.Drawing.Size(109, 13)
        Me.lblRainThresholdValue.TabIndex = 20
        Me.lblRainThresholdValue.Text = "Rain Threshold Value"
        '
        'ucrNudThresholdValue
        '
        Me.ucrNudThresholdValue.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholdValue.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThresholdValue.Location = New System.Drawing.Point(131, 81)
        Me.ucrNudThresholdValue.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThresholdValue.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholdValue.Name = "ucrNudThresholdValue"
        Me.ucrNudThresholdValue.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThresholdValue.TabIndex = 22
        Me.ucrNudThresholdValue.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrRainColour
        '
        Me.ucrRainColour.AddQuotesIfUnrecognised = True
        Me.ucrRainColour.IsReadOnly = False
        Me.ucrRainColour.Location = New System.Drawing.Point(92, 108)
        Me.ucrRainColour.Name = "ucrRainColour"
        Me.ucrRainColour.Size = New System.Drawing.Size(89, 21)
        Me.ucrRainColour.TabIndex = 23
        '
        'ucrDryColour
        '
        Me.ucrDryColour.AddQuotesIfUnrecognised = True
        Me.ucrDryColour.IsReadOnly = False
        Me.ucrDryColour.Location = New System.Drawing.Point(92, 151)
        Me.ucrDryColour.Name = "ucrDryColour"
        Me.ucrDryColour.Size = New System.Drawing.Size(89, 21)
        Me.ucrDryColour.TabIndex = 23
        '
        'lblRainColour
        '
        Me.lblRainColour.AutoSize = True
        Me.lblRainColour.Location = New System.Drawing.Point(6, 116)
        Me.lblRainColour.Name = "lblRainColour"
        Me.lblRainColour.Size = New System.Drawing.Size(62, 13)
        Me.lblRainColour.TabIndex = 24
        Me.lblRainColour.Text = "Rain Colour"
        '
        'lblDryColour
        '
        Me.lblDryColour.AutoSize = True
        Me.lblDryColour.Location = New System.Drawing.Point(6, 151)
        Me.lblDryColour.Name = "lblDryColour"
        Me.lblDryColour.Size = New System.Drawing.Size(56, 13)
        Me.lblDryColour.TabIndex = 24
        Me.lblDryColour.Text = "Dry Colour"
        '
        'grpDisplayRainDays
        '
        Me.grpDisplayRainDays.Controls.Add(Me.ucrInputRain)
        Me.grpDisplayRainDays.Controls.Add(Me.lblDryColour)
        Me.grpDisplayRainDays.Controls.Add(Me.lblRainLabel)
        Me.grpDisplayRainDays.Controls.Add(Me.lblRainColour)
        Me.grpDisplayRainDays.Controls.Add(Me.lblDryLabel)
        Me.grpDisplayRainDays.Controls.Add(Me.ucrDryColour)
        Me.grpDisplayRainDays.Controls.Add(Me.lblRainThresholdValue)
        Me.grpDisplayRainDays.Controls.Add(Me.ucrRainColour)
        Me.grpDisplayRainDays.Controls.Add(Me.ucrInputDry)
        Me.grpDisplayRainDays.Controls.Add(Me.ucrNudThresholdValue)
        Me.grpDisplayRainDays.Location = New System.Drawing.Point(12, 38)
        Me.grpDisplayRainDays.Name = "grpDisplayRainDays"
        Me.grpDisplayRainDays.Size = New System.Drawing.Size(233, 191)
        Me.grpDisplayRainDays.TabIndex = 25
        Me.grpDisplayRainDays.TabStop = False
        '
        'sdgInventoryPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 470)
        Me.Controls.Add(Me.grpDisplayRainDays)
        Me.Controls.Add(Me.ucrChkDisplayRainDays)
        Me.Controls.Add(Me.ucrButtonsInventoryplot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgInventoryPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventory Plot"
        Me.grpDisplayRainDays.ResumeLayout(False)
        Me.grpDisplayRainDays.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsInventoryplot As ucrButtonsSubdialogue
    Friend WithEvents ucrChkDisplayRainDays As ucrCheck
    Friend WithEvents lblRainLabel As Label
    Friend WithEvents lblDryLabel As Label
    Friend WithEvents ucrInputRain As ucrInputTextBox
    Friend WithEvents ucrInputDry As ucrInputTextBox
    Friend WithEvents lblRainThresholdValue As Label
    Friend WithEvents ucrNudThresholdValue As ucrNud
    Friend WithEvents ucrRainColour As ucrColors
    Friend WithEvents ucrDryColour As ucrColors
    Friend WithEvents lblRainColour As Label
    Friend WithEvents lblDryColour As Label
    Friend WithEvents grpDisplayRainDays As GroupBox
End Class
