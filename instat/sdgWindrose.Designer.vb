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
        Me.lblNoofDirections.Location = New System.Drawing.Point(11, 18)
        Me.lblNoofDirections.Name = "lblNoofDirections"
        Me.lblNoofDirections.Size = New System.Drawing.Size(89, 13)
        Me.lblNoofDirections.TabIndex = 0
        Me.lblNoofDirections.Text = "No. of Directions:"
        '
        'lblNoOfSpeeds
        '
        Me.lblNoOfSpeeds.AutoSize = True
        Me.lblNoOfSpeeds.Location = New System.Drawing.Point(11, 71)
        Me.lblNoOfSpeeds.Name = "lblNoOfSpeeds"
        Me.lblNoOfSpeeds.Size = New System.Drawing.Size(78, 13)
        Me.lblNoOfSpeeds.TabIndex = 4
        Me.lblNoOfSpeeds.Text = "No. of Speeds:"
        '
        'lblCalmWind
        '
        Me.lblCalmWind.AutoSize = True
        Me.lblCalmWind.Location = New System.Drawing.Point(11, 45)
        Me.lblCalmWind.Name = "lblCalmWind"
        Me.lblCalmWind.Size = New System.Drawing.Size(61, 13)
        Me.lblCalmWind.TabIndex = 2
        Me.lblCalmWind.Text = "Calm Wind:"
        '
        'lblSpeedCuts
        '
        Me.lblSpeedCuts.AutoSize = True
        Me.lblSpeedCuts.Location = New System.Drawing.Point(11, 98)
        Me.lblSpeedCuts.Name = "lblSpeedCuts"
        Me.lblSpeedCuts.Size = New System.Drawing.Size(65, 13)
        Me.lblSpeedCuts.TabIndex = 6
        Me.lblSpeedCuts.Text = "Speed Cuts:"
        '
        'ucrInputSpeedCuts
        '
        Me.ucrInputSpeedCuts.AddQuotesIfUnrecognised = True
        Me.ucrInputSpeedCuts.IsMultiline = False
        Me.ucrInputSpeedCuts.IsReadOnly = False
        Me.ucrInputSpeedCuts.Location = New System.Drawing.Point(103, 94)
        Me.ucrInputSpeedCuts.Name = "ucrInputSpeedCuts"
        Me.ucrInputSpeedCuts.Size = New System.Drawing.Size(109, 21)
        Me.ucrInputSpeedCuts.TabIndex = 7
        '
        'ucrNudCalmWind
        '
        Me.ucrNudCalmWind.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCalmWind.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCalmWind.Location = New System.Drawing.Point(103, 42)
        Me.ucrNudCalmWind.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCalmWind.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCalmWind.Name = "ucrNudCalmWind"
        Me.ucrNudCalmWind.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCalmWind.TabIndex = 3
        Me.ucrNudCalmWind.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNoOfSpeeds
        '
        Me.ucrNudNoOfSpeeds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Location = New System.Drawing.Point(103, 68)
        Me.ucrNudNoOfSpeeds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfSpeeds.Name = "ucrNudNoOfSpeeds"
        Me.ucrNudNoOfSpeeds.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNoOfSpeeds.TabIndex = 5
        Me.ucrNudNoOfSpeeds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNoOfDirections
        '
        Me.ucrNudNoOfDirections.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfDirections.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNoOfDirections.Location = New System.Drawing.Point(103, 16)
        Me.ucrNudNoOfDirections.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoOfDirections.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfDirections.Name = "ucrNudNoOfDirections"
        Me.ucrNudNoOfDirections.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNoOfDirections.TabIndex = 1
        Me.ucrNudNoOfDirections.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrButtonsSdgWindrose
        '
        Me.ucrButtonsSdgWindrose.Location = New System.Drawing.Point(36, 155)
        Me.ucrButtonsSdgWindrose.Name = "ucrButtonsSdgWindrose"
        Me.ucrButtonsSdgWindrose.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsSdgWindrose.TabIndex = 10
        '
        'lblTheme
        '
        Me.lblTheme.AutoSize = True
        Me.lblTheme.Location = New System.Drawing.Point(12, 124)
        Me.lblTheme.Name = "lblTheme"
        Me.lblTheme.Size = New System.Drawing.Size(43, 13)
        Me.lblTheme.TabIndex = 8
        Me.lblTheme.Text = "Theme:"
        '
        'ucrInputTheme
        '
        Me.ucrInputTheme.AddQuotesIfUnrecognised = True
        Me.ucrInputTheme.IsReadOnly = False
        Me.ucrInputTheme.Location = New System.Drawing.Point(103, 121)
        Me.ucrInputTheme.Name = "ucrInputTheme"
        Me.ucrInputTheme.Size = New System.Drawing.Size(109, 21)
        Me.ucrInputTheme.TabIndex = 9
        '
        'sdgWindrose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 190)
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
