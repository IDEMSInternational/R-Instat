﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgWindrose
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
        Me.lblNoofDirections = New System.Windows.Forms.Label()
        Me.lblNoOfSpeeds = New System.Windows.Forms.Label()
        Me.lblCalmWind = New System.Windows.Forms.Label()
        Me.lblSpeedCuts = New System.Windows.Forms.Label()
        Me.ucrInputSpeedCuts = New instat.ucrInputTextBox()
        Me.ucrNudCalmWind = New instat.ucrNud()
        Me.ucrNudNoOfSpeeds = New instat.ucrNud()
        Me.ucrNudNoOfDirections = New instat.ucrNud()
        Me.ucrButtonsSdgWindrose = New instat.ucrButtonsSubdialogue()
        Me.lblTheme = New System.Windows.Forms.Label()
        Me.ucrInputTheme = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'lblNoofDirections
        '
        Me.lblNoofDirections.AutoSize = True
        Me.lblNoofDirections.Location = New System.Drawing.Point(13, 28)
        Me.lblNoofDirections.Name = "lblNoofDirections"
        Me.lblNoofDirections.Size = New System.Drawing.Size(89, 13)
        Me.lblNoofDirections.TabIndex = 0
        Me.lblNoofDirections.Text = "No. of Directions:"
        '
        'lblNoOfSpeeds
        '
        Me.lblNoOfSpeeds.AutoSize = True
        Me.lblNoOfSpeeds.Location = New System.Drawing.Point(13, 86)
        Me.lblNoOfSpeeds.Name = "lblNoOfSpeeds"
        Me.lblNoOfSpeeds.Size = New System.Drawing.Size(78, 13)
        Me.lblNoOfSpeeds.TabIndex = 2
        Me.lblNoOfSpeeds.Text = "No. of Speeds:"
        '
        'lblCalmWind
        '
        Me.lblCalmWind.AutoSize = True
        Me.lblCalmWind.Location = New System.Drawing.Point(13, 57)
        Me.lblCalmWind.Name = "lblCalmWind"
        Me.lblCalmWind.Size = New System.Drawing.Size(61, 13)
        Me.lblCalmWind.TabIndex = 4
        Me.lblCalmWind.Text = "Calm Wind:"
        '
        'lblSpeedCuts
        '
        Me.lblSpeedCuts.AutoSize = True
        Me.lblSpeedCuts.Location = New System.Drawing.Point(13, 115)
        Me.lblSpeedCuts.Name = "lblSpeedCuts"
        Me.lblSpeedCuts.Size = New System.Drawing.Size(65, 13)
        Me.lblSpeedCuts.TabIndex = 2
        Me.lblSpeedCuts.Text = "Speed Cuts:"
        '
        'ucrInputSpeedCuts
        '
        Me.ucrInputSpeedCuts.AddQuotesIfUnrecognised = True
        Me.ucrInputSpeedCuts.IsMultiline = False
        Me.ucrInputSpeedCuts.IsReadOnly = False
        Me.ucrInputSpeedCuts.Location = New System.Drawing.Point(130, 115)
        Me.ucrInputSpeedCuts.Name = "ucrInputSpeedCuts"
        Me.ucrInputSpeedCuts.Size = New System.Drawing.Size(109, 21)
        Me.ucrInputSpeedCuts.TabIndex = 6
        '
        'ucrNudCalmWind
        '
        Me.ucrNudCalmWind.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCalmWind.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCalmWind.Location = New System.Drawing.Point(130, 57)
        Me.ucrNudCalmWind.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCalmWind.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCalmWind.Name = "ucrNudCalmWind"
        Me.ucrNudCalmWind.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCalmWind.TabIndex = 5
        Me.ucrNudCalmWind.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNoOfSpeeds
        '
        Me.ucrNudNoOfSpeeds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Location = New System.Drawing.Point(130, 86)
        Me.ucrNudNoOfSpeeds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Name = "ucrNudNoOfSpeeds"
        Me.ucrNudNoOfSpeeds.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNoOfSpeeds.TabIndex = 3
        Me.ucrNudNoOfSpeeds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNoOfDirections
        '
        Me.ucrNudNoOfDirections.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfDirections.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNoOfDirections.Location = New System.Drawing.Point(130, 28)
        Me.ucrNudNoOfDirections.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoOfDirections.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfDirections.Name = "ucrNudNoOfDirections"
        Me.ucrNudNoOfDirections.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNoOfDirections.TabIndex = 1
        Me.ucrNudNoOfDirections.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrButtonsSdgWindrose
        '
        Me.ucrButtonsSdgWindrose.Location = New System.Drawing.Point(51, 183)
        Me.ucrButtonsSdgWindrose.Name = "ucrButtonsSdgWindrose"
        Me.ucrButtonsSdgWindrose.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsSdgWindrose.TabIndex = 7
        '
        'lblTheme
        '
        Me.lblTheme.AutoSize = True
        Me.lblTheme.Location = New System.Drawing.Point(13, 144)
        Me.lblTheme.Name = "lblTheme"
        Me.lblTheme.Size = New System.Drawing.Size(43, 13)
        Me.lblTheme.TabIndex = 2
        Me.lblTheme.Text = "Theme:"
        '
        'ucrInputTheme
        '
        Me.ucrInputTheme.AddQuotesIfUnrecognised = True
        Me.ucrInputTheme.IsReadOnly = False
        Me.ucrInputTheme.Location = New System.Drawing.Point(130, 144)
        Me.ucrInputTheme.Name = "ucrInputTheme"
        Me.ucrInputTheme.Size = New System.Drawing.Size(109, 21)
        Me.ucrInputTheme.TabIndex = 8
        '
        'sdgWindrose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 220)
        Me.Controls.Add(Me.ucrInputTheme)
        Me.Controls.Add(Me.lblTheme)
        Me.Controls.Add(Me.lblSpeedCuts)
        Me.Controls.Add(Me.lblCalmWind)
        Me.Controls.Add(Me.lblNoOfSpeeds)
        Me.Controls.Add(Me.lblNoofDirections)
        Me.Controls.Add(Me.ucrInputSpeedCuts)
        Me.Controls.Add(Me.ucrNudCalmWind)
        Me.Controls.Add(Me.ucrNudNoOfSpeeds)
        Me.Controls.Add(Me.ucrNudNoOfDirections)
        Me.Controls.Add(Me.ucrButtonsSdgWindrose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgWindrose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wind Rose"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrButtonsSdgWindrose As ucrButtonsSubdialogue
    Friend WithEvents ucrNudNoOfDirections As ucrNud
    Friend WithEvents lblNoofDirections As Label
    Friend WithEvents ucrNudNoOfSpeeds As ucrNud
    Friend WithEvents lblNoOfSpeeds As Label
    Friend WithEvents ucrNudCalmWind As ucrNud
    Friend WithEvents lblCalmWind As Label
    Friend WithEvents lblSpeedCuts As Label
    Friend WithEvents ucrInputSpeedCuts As ucrInputTextBox
    Friend WithEvents lblTheme As Label
    Friend WithEvents ucrInputTheme As ucrInputComboBox
End Class
