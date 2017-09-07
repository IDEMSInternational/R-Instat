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
        Me.SuspendLayout()
        '
        'ucrButtonsInventoryplot
        '
        Me.ucrButtonsInventoryplot.Location = New System.Drawing.Point(63, 205)
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
        Me.lblRainLabel.Location = New System.Drawing.Point(13, 39)
        Me.lblRainLabel.Name = "lblRainLabel"
        Me.lblRainLabel.Size = New System.Drawing.Size(58, 13)
        Me.lblRainLabel.TabIndex = 20
        Me.lblRainLabel.Text = "Rain Label"
        '
        'lblDryLabel
        '
        Me.lblDryLabel.AutoSize = True
        Me.lblDryLabel.Location = New System.Drawing.Point(13, 64)
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
        Me.ucrInputRain.Location = New System.Drawing.Point(91, 39)
        Me.ucrInputRain.Name = "ucrInputRain"
        Me.ucrInputRain.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputRain.TabIndex = 21
        '
        'ucrInputDry
        '
        Me.ucrInputDry.AddQuotesIfUnrecognised = True
        Me.ucrInputDry.IsMultiline = False
        Me.ucrInputDry.IsReadOnly = False
        Me.ucrInputDry.Location = New System.Drawing.Point(91, 64)
        Me.ucrInputDry.Name = "ucrInputDry"
        Me.ucrInputDry.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDry.TabIndex = 21
        '
        'lblRainThresholdValue
        '
        Me.lblRainThresholdValue.AutoSize = True
        Me.lblRainThresholdValue.Location = New System.Drawing.Point(19, 104)
        Me.lblRainThresholdValue.Name = "lblRainThresholdValue"
        Me.lblRainThresholdValue.Size = New System.Drawing.Size(109, 13)
        Me.lblRainThresholdValue.TabIndex = 20
        Me.lblRainThresholdValue.Text = "Rain Threshold Value"
        '
        'ucrNudThresholdValue
        '
        Me.ucrNudThresholdValue.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholdValue.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThresholdValue.Location = New System.Drawing.Point(135, 104)
        Me.ucrNudThresholdValue.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThresholdValue.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholdValue.Name = "ucrNudThresholdValue"
        Me.ucrNudThresholdValue.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThresholdValue.TabIndex = 22
        Me.ucrNudThresholdValue.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'sdgInventoryPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ucrNudThresholdValue)
        Me.Controls.Add(Me.ucrInputDry)
        Me.Controls.Add(Me.ucrInputRain)
        Me.Controls.Add(Me.lblRainThresholdValue)
        Me.Controls.Add(Me.lblDryLabel)
        Me.Controls.Add(Me.lblRainLabel)
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
    Friend WithEvents lblRainLabel As Label
    Friend WithEvents lblDryLabel As Label
    Friend WithEvents ucrInputRain As ucrInputTextBox
    Friend WithEvents ucrInputDry As ucrInputTextBox
    Friend WithEvents lblRainThresholdValue As Label
    Friend WithEvents ucrNudThresholdValue As ucrNud
End Class
