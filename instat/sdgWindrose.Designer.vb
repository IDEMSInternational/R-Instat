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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgWindrose))
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
        resources.ApplyResources(Me.ucrButtonsSdgWindrose, "ucrButtonsSdgWindrose")
        Me.ucrButtonsSdgWindrose.Name = "ucrButtonsSdgWindrose"
        '
        'tbpColours
        '
        Me.tbpColours.Controls.Add(Me.grpColours)
        resources.ApplyResources(Me.tbpColours, "tbpColours")
        Me.tbpColours.Name = "tbpColours"
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
        resources.ApplyResources(Me.grpColours, "grpColours")
        Me.grpColours.Name = "grpColours"
        Me.grpColours.TabStop = False
        '
        'lblPalette
        '
        resources.ApplyResources(Me.lblPalette, "lblPalette")
        Me.lblPalette.Name = "lblPalette"
        '
        'ucrInputPalettes
        '
        Me.ucrInputPalettes.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputPalettes, "ucrInputPalettes")
        Me.ucrInputPalettes.GetSetSelectedIndex = -1
        Me.ucrInputPalettes.IsReadOnly = False
        Me.ucrInputPalettes.Name = "ucrInputPalettes"
        '
        'rdoQualitative
        '
        resources.ApplyResources(Me.rdoQualitative, "rdoQualitative")
        Me.rdoQualitative.BackColor = System.Drawing.SystemColors.Control
        Me.rdoQualitative.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoQualitative.FlatAppearance.BorderSize = 2
        Me.rdoQualitative.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoQualitative.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoQualitative.Name = "rdoQualitative"
        Me.rdoQualitative.UseVisualStyleBackColor = True
        '
        'rdoSequential
        '
        resources.ApplyResources(Me.rdoSequential, "rdoSequential")
        Me.rdoSequential.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSequential.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSequential.FlatAppearance.BorderSize = 2
        Me.rdoSequential.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSequential.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoSequential.Name = "rdoSequential"
        Me.rdoSequential.UseVisualStyleBackColor = True
        '
        'rdoDiverging
        '
        resources.ApplyResources(Me.rdoDiverging, "rdoDiverging")
        Me.rdoDiverging.BackColor = System.Drawing.SystemColors.Control
        Me.rdoDiverging.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDiverging.FlatAppearance.BorderSize = 2
        Me.rdoDiverging.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDiverging.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoDiverging.Name = "rdoDiverging"
        Me.rdoDiverging.UseVisualStyleBackColor = True
        '
        'ucrPnlColourPalette
        '
        resources.ApplyResources(Me.ucrPnlColourPalette, "ucrPnlColourPalette")
        Me.ucrPnlColourPalette.Name = "ucrPnlColourPalette"
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
        resources.ApplyResources(Me.tbpOptions, "tbpOptions")
        Me.tbpOptions.Name = "tbpOptions"
        Me.tbpOptions.UseVisualStyleBackColor = True
        '
        'ucrInputSpeedCuts
        '
        Me.ucrInputSpeedCuts.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputSpeedCuts, "ucrInputSpeedCuts")
        Me.ucrInputSpeedCuts.IsMultiline = False
        Me.ucrInputSpeedCuts.IsReadOnly = False
        Me.ucrInputSpeedCuts.Name = "ucrInputSpeedCuts"
        '
        'ucrInputTheme
        '
        Me.ucrInputTheme.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputTheme, "ucrInputTheme")
        Me.ucrInputTheme.GetSetSelectedIndex = -1
        Me.ucrInputTheme.IsReadOnly = False
        Me.ucrInputTheme.Name = "ucrInputTheme"
        '
        'ucrNudNoOfDirections
        '
        resources.ApplyResources(Me.ucrNudNoOfDirections, "ucrNudNoOfDirections")
        Me.ucrNudNoOfDirections.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfDirections.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNoOfDirections.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoOfDirections.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfDirections.Name = "ucrNudNoOfDirections"
        Me.ucrNudNoOfDirections.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTheme
        '
        resources.ApplyResources(Me.lblTheme, "lblTheme")
        Me.lblTheme.Name = "lblTheme"
        '
        'ucrNudNoOfSpeeds
        '
        resources.ApplyResources(Me.ucrNudNoOfSpeeds, "ucrNudNoOfSpeeds")
        Me.ucrNudNoOfSpeeds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Name = "ucrNudNoOfSpeeds"
        Me.ucrNudNoOfSpeeds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSpeedCuts
        '
        resources.ApplyResources(Me.lblSpeedCuts, "lblSpeedCuts")
        Me.lblSpeedCuts.Name = "lblSpeedCuts"
        '
        'ucrNudCalmWind
        '
        resources.ApplyResources(Me.ucrNudCalmWind, "ucrNudCalmWind")
        Me.ucrNudCalmWind.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCalmWind.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCalmWind.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCalmWind.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCalmWind.Name = "ucrNudCalmWind"
        Me.ucrNudCalmWind.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblCalmWind
        '
        resources.ApplyResources(Me.lblCalmWind, "lblCalmWind")
        Me.lblCalmWind.Name = "lblCalmWind"
        '
        'lblNoofDirections
        '
        resources.ApplyResources(Me.lblNoofDirections, "lblNoofDirections")
        Me.lblNoofDirections.Name = "lblNoofDirections"
        '
        'lblNoOfSpeeds
        '
        resources.ApplyResources(Me.lblNoOfSpeeds, "lblNoOfSpeeds")
        Me.lblNoOfSpeeds.Name = "lblNoOfSpeeds"
        '
        'tbpWindRoseOptions
        '
        Me.tbpWindRoseOptions.Controls.Add(Me.tbpOptions)
        Me.tbpWindRoseOptions.Controls.Add(Me.tbpColours)
        resources.ApplyResources(Me.tbpWindRoseOptions, "tbpWindRoseOptions")
        Me.tbpWindRoseOptions.Name = "tbpWindRoseOptions"
        Me.tbpWindRoseOptions.SelectedIndex = 0
        '
        'sdgWindrose
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.tbpWindRoseOptions)
        Me.Controls.Add(Me.ucrButtonsSdgWindrose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgWindrose"
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
