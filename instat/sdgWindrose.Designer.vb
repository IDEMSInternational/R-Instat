' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgWindrose
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
        Me.ucrButtonsSdgWindrose = New instat.ucrButtonsSubdialogue()
        Me.tbpColours = New System.Windows.Forms.TabPage()
        Me.grpColours = New System.Windows.Forms.GroupBox()
        Me.lblPalette = New System.Windows.Forms.Label()
        Me.ucrInputPalettes = New instat.ucrInputComboBox()
        Me.rdoQualitative = New System.Windows.Forms.RadioButton()
        Me.rdoSequential = New System.Windows.Forms.RadioButton()
        Me.rdoDiverging = New System.Windows.Forms.RadioButton()
        Me.ucrPnlColourPalette = New instat.UcrPanel()
        Me.tbpOptions = New System.Windows.Forms.TabPage()
        Me.ucrInputSpeedCuts = New instat.ucrInputTextBox()
        Me.ucrInputTheme = New instat.ucrInputComboBox()
        Me.ucrNudNoOfDirections = New instat.ucrNud()
        Me.lblTheme = New System.Windows.Forms.Label()
        Me.ucrNudNoOfSpeeds = New instat.ucrNud()
        Me.lblSpeedCuts = New System.Windows.Forms.Label()
        Me.ucrNudCalmWind = New instat.ucrNud()
        Me.lblCalmWind = New System.Windows.Forms.Label()
        Me.lblNoofDirections = New System.Windows.Forms.Label()
        Me.lblNoOfSpeeds = New System.Windows.Forms.Label()
        Me.tbpWindRoseOptions = New System.Windows.Forms.TabControl()
        Me.tbpColours.SuspendLayout()
        Me.grpColours.SuspendLayout()
        Me.tbpOptions.SuspendLayout()
        Me.tbpWindRoseOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrButtonsSdgWindrose
        '
        Me.ucrButtonsSdgWindrose.AutoSize = True
        Me.ucrButtonsSdgWindrose.Location = New System.Drawing.Point(106, 207)
        Me.ucrButtonsSdgWindrose.Name = "ucrButtonsSdgWindrose"
        Me.ucrButtonsSdgWindrose.Size = New System.Drawing.Size(224, 30)
        Me.ucrButtonsSdgWindrose.TabIndex = 10
        '
        'tbpColours
        '
        Me.tbpColours.Controls.Add(Me.grpColours)
        Me.tbpColours.Location = New System.Drawing.Point(4, 22)
        Me.tbpColours.Name = "tbpColours"
        Me.tbpColours.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpColours.Size = New System.Drawing.Size(350, 158)
        Me.tbpColours.TabIndex = 2
        Me.tbpColours.Text = "Colours"
        Me.tbpColours.UseVisualStyleBackColor = True
        '
        'grpColours
        '
        Me.grpColours.Controls.Add(Me.lblPalette)
        Me.grpColours.Controls.Add(Me.ucrInputPalettes)
        Me.grpColours.Controls.Add(Me.rdoQualitative)
        Me.grpColours.Controls.Add(Me.rdoSequential)
        Me.grpColours.Controls.Add(Me.rdoDiverging)
        Me.grpColours.Controls.Add(Me.ucrPnlColourPalette)
        Me.grpColours.Location = New System.Drawing.Point(6, 6)
        Me.grpColours.Name = "grpColours"
        Me.grpColours.Size = New System.Drawing.Size(302, 92)
        Me.grpColours.TabIndex = 23
        Me.grpColours.TabStop = False
        Me.grpColours.Text = "Type of Palette"
        '
        'lblPalette
        '
        Me.lblPalette.AutoSize = True
        Me.lblPalette.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPalette.Location = New System.Drawing.Point(22, 64)
        Me.lblPalette.Name = "lblPalette"
        Me.lblPalette.Size = New System.Drawing.Size(43, 13)
        Me.lblPalette.TabIndex = 23
        Me.lblPalette.Text = "Palette:"
        '
        'ucrInputPalettes
        '
        Me.ucrInputPalettes.AddQuotesIfUnrecognised = True
        Me.ucrInputPalettes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPalettes.GetSetSelectedIndex = -1
        Me.ucrInputPalettes.IsReadOnly = False
        Me.ucrInputPalettes.Location = New System.Drawing.Point(71, 60)
        Me.ucrInputPalettes.Name = "ucrInputPalettes"
        Me.ucrInputPalettes.Size = New System.Drawing.Size(146, 26)
        Me.ucrInputPalettes.TabIndex = 22
        '
        'rdoQualitative
        '
        Me.rdoQualitative.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoQualitative.BackColor = System.Drawing.SystemColors.Control
        Me.rdoQualitative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoQualitative.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoQualitative.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoQualitative.FlatAppearance.BorderSize = 2
        Me.rdoQualitative.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoQualitative.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoQualitative.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoQualitative.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoQualitative.Location = New System.Drawing.Point(199, 24)
        Me.rdoQualitative.Name = "rdoQualitative"
        Me.rdoQualitative.Size = New System.Drawing.Size(91, 29)
        Me.rdoQualitative.TabIndex = 21
        Me.rdoQualitative.Text = "Qualitative"
        Me.rdoQualitative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoQualitative.UseVisualStyleBackColor = True
        '
        'rdoSequential
        '
        Me.rdoSequential.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSequential.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSequential.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoSequential.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSequential.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSequential.FlatAppearance.BorderSize = 2
        Me.rdoSequential.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSequential.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSequential.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoSequential.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSequential.Location = New System.Drawing.Point(21, 24)
        Me.rdoSequential.Name = "rdoSequential"
        Me.rdoSequential.Size = New System.Drawing.Size(91, 29)
        Me.rdoSequential.TabIndex = 19
        Me.rdoSequential.Text = "Sequential"
        Me.rdoSequential.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSequential.UseVisualStyleBackColor = True
        '
        'rdoDiverging
        '
        Me.rdoDiverging.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDiverging.BackColor = System.Drawing.SystemColors.Control
        Me.rdoDiverging.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoDiverging.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDiverging.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDiverging.FlatAppearance.BorderSize = 2
        Me.rdoDiverging.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDiverging.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDiverging.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoDiverging.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDiverging.Location = New System.Drawing.Point(110, 24)
        Me.rdoDiverging.Name = "rdoDiverging"
        Me.rdoDiverging.Size = New System.Drawing.Size(91, 29)
        Me.rdoDiverging.TabIndex = 20
        Me.rdoDiverging.Text = "Diverging"
        Me.rdoDiverging.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDiverging.UseVisualStyleBackColor = True
        '
        'ucrPnlColourPalette
        '
        Me.ucrPnlColourPalette.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlColourPalette.Location = New System.Drawing.Point(21, 24)
        Me.ucrPnlColourPalette.Name = "ucrPnlColourPalette"
        Me.ucrPnlColourPalette.Size = New System.Drawing.Size(269, 29)
        Me.ucrPnlColourPalette.TabIndex = 18
        '
        'tbpOptions
        '
        Me.tbpOptions.Controls.Add(Me.ucrInputSpeedCuts)
        Me.tbpOptions.Controls.Add(Me.ucrInputTheme)
        Me.tbpOptions.Controls.Add(Me.ucrNudNoOfDirections)
        Me.tbpOptions.Controls.Add(Me.lblTheme)
        Me.tbpOptions.Controls.Add(Me.ucrNudNoOfSpeeds)
        Me.tbpOptions.Controls.Add(Me.lblSpeedCuts)
        Me.tbpOptions.Controls.Add(Me.ucrNudCalmWind)
        Me.tbpOptions.Controls.Add(Me.lblCalmWind)
        Me.tbpOptions.Controls.Add(Me.lblNoofDirections)
        Me.tbpOptions.Controls.Add(Me.lblNoOfSpeeds)
        Me.tbpOptions.Location = New System.Drawing.Point(4, 22)
        Me.tbpOptions.Name = "tbpOptions"
        Me.tbpOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpOptions.Size = New System.Drawing.Size(350, 158)
        Me.tbpOptions.TabIndex = 1
        Me.tbpOptions.Text = "Windrose Options"
        Me.tbpOptions.UseVisualStyleBackColor = True
        '
        'ucrInputSpeedCuts
        '
        Me.ucrInputSpeedCuts.AddQuotesIfUnrecognised = True
        Me.ucrInputSpeedCuts.AutoSize = True
        Me.ucrInputSpeedCuts.IsMultiline = False
        Me.ucrInputSpeedCuts.IsReadOnly = False
        Me.ucrInputSpeedCuts.Location = New System.Drawing.Point(102, 90)
        Me.ucrInputSpeedCuts.Name = "ucrInputSpeedCuts"
        Me.ucrInputSpeedCuts.Size = New System.Drawing.Size(109, 21)
        Me.ucrInputSpeedCuts.TabIndex = 7
        '
        'ucrInputTheme
        '
        Me.ucrInputTheme.AddQuotesIfUnrecognised = True
        Me.ucrInputTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTheme.GetSetSelectedIndex = -1
        Me.ucrInputTheme.IsReadOnly = False
        Me.ucrInputTheme.Location = New System.Drawing.Point(102, 117)
        Me.ucrInputTheme.Name = "ucrInputTheme"
        Me.ucrInputTheme.Size = New System.Drawing.Size(109, 21)
        Me.ucrInputTheme.TabIndex = 9
        '
        'ucrNudNoOfDirections
        '
        Me.ucrNudNoOfDirections.AutoSize = True
        Me.ucrNudNoOfDirections.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfDirections.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNoOfDirections.Location = New System.Drawing.Point(102, 12)
        Me.ucrNudNoOfDirections.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoOfDirections.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfDirections.Name = "ucrNudNoOfDirections"
        Me.ucrNudNoOfDirections.Size = New System.Drawing.Size(72, 20)
        Me.ucrNudNoOfDirections.TabIndex = 1
        Me.ucrNudNoOfDirections.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTheme
        '
        Me.lblTheme.AutoSize = True
        Me.lblTheme.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTheme.Location = New System.Drawing.Point(11, 120)
        Me.lblTheme.Name = "lblTheme"
        Me.lblTheme.Size = New System.Drawing.Size(43, 13)
        Me.lblTheme.TabIndex = 8
        Me.lblTheme.Text = "Theme:"
        '
        'ucrNudNoOfSpeeds
        '
        Me.ucrNudNoOfSpeeds.AutoSize = True
        Me.ucrNudNoOfSpeeds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Location = New System.Drawing.Point(102, 64)
        Me.ucrNudNoOfSpeeds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Name = "ucrNudNoOfSpeeds"
        Me.ucrNudNoOfSpeeds.Size = New System.Drawing.Size(72, 20)
        Me.ucrNudNoOfSpeeds.TabIndex = 5
        Me.ucrNudNoOfSpeeds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSpeedCuts
        '
        Me.lblSpeedCuts.AutoSize = True
        Me.lblSpeedCuts.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSpeedCuts.Location = New System.Drawing.Point(10, 94)
        Me.lblSpeedCuts.Name = "lblSpeedCuts"
        Me.lblSpeedCuts.Size = New System.Drawing.Size(65, 13)
        Me.lblSpeedCuts.TabIndex = 6
        Me.lblSpeedCuts.Text = "Speed Cuts:"
        '
        'ucrNudCalmWind
        '
        Me.ucrNudCalmWind.AutoSize = True
        Me.ucrNudCalmWind.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCalmWind.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCalmWind.Location = New System.Drawing.Point(102, 38)
        Me.ucrNudCalmWind.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCalmWind.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCalmWind.Name = "ucrNudCalmWind"
        Me.ucrNudCalmWind.Size = New System.Drawing.Size(72, 20)
        Me.ucrNudCalmWind.TabIndex = 3
        Me.ucrNudCalmWind.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblCalmWind
        '
        Me.lblCalmWind.AutoSize = True
        Me.lblCalmWind.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCalmWind.Location = New System.Drawing.Point(10, 41)
        Me.lblCalmWind.Name = "lblCalmWind"
        Me.lblCalmWind.Size = New System.Drawing.Size(61, 13)
        Me.lblCalmWind.TabIndex = 2
        Me.lblCalmWind.Text = "Calm Wind:"
        '
        'lblNoofDirections
        '
        Me.lblNoofDirections.AutoSize = True
        Me.lblNoofDirections.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNoofDirections.Location = New System.Drawing.Point(10, 14)
        Me.lblNoofDirections.Name = "lblNoofDirections"
        Me.lblNoofDirections.Size = New System.Drawing.Size(89, 13)
        Me.lblNoofDirections.TabIndex = 0
        Me.lblNoofDirections.Text = "No. of Directions:"
        '
        'lblNoOfSpeeds
        '
        Me.lblNoOfSpeeds.AutoSize = True
        Me.lblNoOfSpeeds.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNoOfSpeeds.Location = New System.Drawing.Point(10, 67)
        Me.lblNoOfSpeeds.Name = "lblNoOfSpeeds"
        Me.lblNoOfSpeeds.Size = New System.Drawing.Size(78, 13)
        Me.lblNoOfSpeeds.TabIndex = 4
        Me.lblNoOfSpeeds.Text = "No. of Speeds:"
        '
        'tbpWindRoseOptions
        '
        Me.tbpWindRoseOptions.Controls.Add(Me.tbpOptions)
        Me.tbpWindRoseOptions.Controls.Add(Me.tbpColours)
        Me.tbpWindRoseOptions.Location = New System.Drawing.Point(0, 2)
        Me.tbpWindRoseOptions.Name = "tbpWindRoseOptions"
        Me.tbpWindRoseOptions.SelectedIndex = 0
        Me.tbpWindRoseOptions.Size = New System.Drawing.Size(358, 184)
        Me.tbpWindRoseOptions.TabIndex = 11
        '
        'sdgWindrose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(384, 239)
        Me.Controls.Add(Me.tbpWindRoseOptions)
        Me.Controls.Add(Me.ucrButtonsSdgWindrose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgWindrose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wind Rose"
        Me.tbpColours.ResumeLayout(False)
        Me.grpColours.ResumeLayout(False)
        Me.grpColours.PerformLayout()
        Me.tbpOptions.ResumeLayout(False)
        Me.tbpOptions.PerformLayout()
        Me.tbpWindRoseOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrButtonsSdgWindrose As ucrButtonsSubdialogue
    Friend WithEvents tbpColours As TabPage
    Friend WithEvents grpColours As GroupBox
    Friend WithEvents lblPalette As Label
    Friend WithEvents ucrInputPalettes As ucrInputComboBox
    Friend WithEvents rdoQualitative As RadioButton
    Friend WithEvents rdoSequential As RadioButton
    Friend WithEvents rdoDiverging As RadioButton
    Friend WithEvents ucrPnlColourPalette As UcrPanel
    Friend WithEvents tbpOptions As TabPage
    Friend WithEvents ucrInputSpeedCuts As ucrInputTextBox
    Friend WithEvents ucrInputTheme As ucrInputComboBox
    Friend WithEvents ucrNudNoOfDirections As ucrNud
    Friend WithEvents lblTheme As Label
    Friend WithEvents ucrNudNoOfSpeeds As ucrNud
    Friend WithEvents lblSpeedCuts As Label
    Friend WithEvents ucrNudCalmWind As ucrNud
    Friend WithEvents lblCalmWind As Label
    Friend WithEvents lblNoofDirections As Label
    Friend WithEvents lblNoOfSpeeds As Label
    Friend WithEvents tbpWindRoseOptions As TabControl
End Class
