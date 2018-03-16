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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgWindrose))
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
        resources.ApplyResources(Me.lblNoofDirections, "lblNoofDirections")
        Me.lblNoofDirections.Name = "lblNoofDirections"
        '
        'lblNoOfSpeeds
        '
        resources.ApplyResources(Me.lblNoOfSpeeds, "lblNoOfSpeeds")
        Me.lblNoOfSpeeds.Name = "lblNoOfSpeeds"
        '
        'lblCalmWind
        '
        resources.ApplyResources(Me.lblCalmWind, "lblCalmWind")
        Me.lblCalmWind.Name = "lblCalmWind"
        '
        'lblSpeedCuts
        '
        resources.ApplyResources(Me.lblSpeedCuts, "lblSpeedCuts")
        Me.lblSpeedCuts.Name = "lblSpeedCuts"
        '
        'ucrInputSpeedCuts
        '
        Me.ucrInputSpeedCuts.AddQuotesIfUnrecognised = True
        Me.ucrInputSpeedCuts.IsMultiline = False
        Me.ucrInputSpeedCuts.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSpeedCuts, "ucrInputSpeedCuts")
        Me.ucrInputSpeedCuts.Name = "ucrInputSpeedCuts"
        '
        'ucrNudCalmWind
        '
        Me.ucrNudCalmWind.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCalmWind.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudCalmWind, "ucrNudCalmWind")
        Me.ucrNudCalmWind.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCalmWind.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCalmWind.Name = "ucrNudCalmWind"
        Me.ucrNudCalmWind.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNoOfSpeeds
        '
        Me.ucrNudNoOfSpeeds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNoOfSpeeds, "ucrNudNoOfSpeeds")
        Me.ucrNudNoOfSpeeds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Name = "ucrNudNoOfSpeeds"
        Me.ucrNudNoOfSpeeds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNoOfDirections
        '
        Me.ucrNudNoOfDirections.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfDirections.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNoOfDirections, "ucrNudNoOfDirections")
        Me.ucrNudNoOfDirections.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoOfDirections.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfDirections.Name = "ucrNudNoOfDirections"
        Me.ucrNudNoOfDirections.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrButtonsSdgWindrose
        '
        resources.ApplyResources(Me.ucrButtonsSdgWindrose, "ucrButtonsSdgWindrose")
        Me.ucrButtonsSdgWindrose.Name = "ucrButtonsSdgWindrose"
        '
        'lblTheme
        '
        resources.ApplyResources(Me.lblTheme, "lblTheme")
        Me.lblTheme.Name = "lblTheme"
        '
        'ucrInputTheme
        '
        Me.ucrInputTheme.AddQuotesIfUnrecognised = True
        Me.ucrInputTheme.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTheme, "ucrInputTheme")
        Me.ucrInputTheme.Name = "ucrInputTheme"
        '
        'sdgWindrose
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
