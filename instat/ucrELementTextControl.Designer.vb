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
Partial Class ucrELementTextControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.grpAxisLabels = New System.Windows.Forms.GroupBox()
        Me.ucrTextColors = New instat.ucrColors()
        Me.ucrChkTextColour = New instat.ucrCheck()
        Me.ucrChkTextFace = New instat.ucrCheck()
        Me.ucrChkTextFamily = New instat.ucrCheck()
        Me.ucrChkAngle = New instat.ucrCheck()
        Me.ucrChkHjust = New instat.ucrCheck()
        Me.ucrChkVjust = New instat.ucrCheck()
        Me.ucrChkLineHeight = New instat.ucrCheck()
        Me.ucrChkSize = New instat.ucrCheck()
        Me.ucrNudVjust = New instat.ucrNud()
        Me.ucrNudLineHeight = New instat.ucrNud()
        Me.ucrNudAngle = New instat.ucrNud()
        Me.ucrNudHjust = New instat.ucrNud()
        Me.ucrNudsize = New instat.ucrNud()
        Me.ucrInputTextFace = New instat.ucrInputComboBox()
        Me.ucrInputTextFamily = New instat.ucrInputComboBox()
        Me.grpAxisLabels.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAxisLabels
        '
        Me.grpAxisLabels.Controls.Add(Me.ucrTextColors)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkTextColour)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkTextFace)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkTextFamily)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkAngle)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkHjust)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkVjust)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkLineHeight)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkSize)
        Me.grpAxisLabels.Controls.Add(Me.ucrNudVjust)
        Me.grpAxisLabels.Controls.Add(Me.ucrNudLineHeight)
        Me.grpAxisLabels.Controls.Add(Me.ucrNudAngle)
        Me.grpAxisLabels.Controls.Add(Me.ucrNudHjust)
        Me.grpAxisLabels.Controls.Add(Me.ucrNudsize)
        Me.grpAxisLabels.Controls.Add(Me.ucrInputTextFace)
        Me.grpAxisLabels.Controls.Add(Me.ucrInputTextFamily)
        Me.grpAxisLabels.Location = New System.Drawing.Point(3, 0)
        Me.grpAxisLabels.Name = "grpAxisLabels"
        Me.grpAxisLabels.Size = New System.Drawing.Size(246, 223)
        Me.grpAxisLabels.TabIndex = 71
        Me.grpAxisLabels.TabStop = False
        Me.grpAxisLabels.Text = "Element Text "
        '
        'ucrTextColors
        '
        Me.ucrTextColors.AddQuotesIfUnrecognised = True
        Me.ucrTextColors.IsReadOnly = False
        Me.ucrTextColors.Location = New System.Drawing.Point(105, 191)
        Me.ucrTextColors.Name = "ucrTextColors"
        Me.ucrTextColors.Size = New System.Drawing.Size(137, 21)
        Me.ucrTextColors.TabIndex = 86
        '
        'ucrChkTextColour
        '
        Me.ucrChkTextColour.Checked = False
        Me.ucrChkTextColour.Location = New System.Drawing.Point(8, 192)
        Me.ucrChkTextColour.Name = "ucrChkTextColour"
        Me.ucrChkTextColour.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkTextColour.TabIndex = 85
        '
        'ucrChkTextFace
        '
        Me.ucrChkTextFace.Checked = False
        Me.ucrChkTextFace.Location = New System.Drawing.Point(8, 167)
        Me.ucrChkTextFace.Name = "ucrChkTextFace"
        Me.ucrChkTextFace.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkTextFace.TabIndex = 84
        '
        'ucrChkTextFamily
        '
        Me.ucrChkTextFamily.Checked = False
        Me.ucrChkTextFamily.Location = New System.Drawing.Point(8, 142)
        Me.ucrChkTextFamily.Name = "ucrChkTextFamily"
        Me.ucrChkTextFamily.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkTextFamily.TabIndex = 83
        '
        'ucrChkAngle
        '
        Me.ucrChkAngle.Checked = False
        Me.ucrChkAngle.Location = New System.Drawing.Point(8, 117)
        Me.ucrChkAngle.Name = "ucrChkAngle"
        Me.ucrChkAngle.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkAngle.TabIndex = 82
        '
        'ucrChkHjust
        '
        Me.ucrChkHjust.Checked = False
        Me.ucrChkHjust.Location = New System.Drawing.Point(8, 44)
        Me.ucrChkHjust.Name = "ucrChkHjust"
        Me.ucrChkHjust.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkHjust.TabIndex = 81
        '
        'ucrChkVjust
        '
        Me.ucrChkVjust.Checked = False
        Me.ucrChkVjust.Location = New System.Drawing.Point(8, 69)
        Me.ucrChkVjust.Name = "ucrChkVjust"
        Me.ucrChkVjust.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkVjust.TabIndex = 80
        '
        'ucrChkLineHeight
        '
        Me.ucrChkLineHeight.Checked = False
        Me.ucrChkLineHeight.Location = New System.Drawing.Point(8, 94)
        Me.ucrChkLineHeight.Name = "ucrChkLineHeight"
        Me.ucrChkLineHeight.Size = New System.Drawing.Size(94, 18)
        Me.ucrChkLineHeight.TabIndex = 79
        '
        'ucrChkSize
        '
        Me.ucrChkSize.Checked = False
        Me.ucrChkSize.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkSize.Name = "ucrChkSize"
        Me.ucrChkSize.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkSize.TabIndex = 78
        '
        'ucrNudVjust
        '
        Me.ucrNudVjust.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudVjust.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ucrNudVjust.Location = New System.Drawing.Point(105, 68)
        Me.ucrNudVjust.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudVjust.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudVjust.Name = "ucrNudVjust"
        Me.ucrNudVjust.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudVjust.TabIndex = 77
        Me.ucrNudVjust.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLineHeight
        '
        Me.ucrNudLineHeight.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLineHeight.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ucrNudLineHeight.Location = New System.Drawing.Point(105, 92)
        Me.ucrNudLineHeight.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLineHeight.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLineHeight.Name = "ucrNudLineHeight"
        Me.ucrNudLineHeight.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLineHeight.TabIndex = 76
        Me.ucrNudLineHeight.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAngle
        '
        Me.ucrNudAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAngle.Location = New System.Drawing.Point(105, 117)
        Me.ucrNudAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngle.Name = "ucrNudAngle"
        Me.ucrNudAngle.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAngle.TabIndex = 75
        Me.ucrNudAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudHjust
        '
        Me.ucrNudHjust.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHjust.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ucrNudHjust.Location = New System.Drawing.Point(105, 43)
        Me.ucrNudHjust.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHjust.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHjust.Name = "ucrNudHjust"
        Me.ucrNudHjust.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudHjust.TabIndex = 74
        Me.ucrNudHjust.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudsize
        '
        Me.ucrNudsize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudsize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudsize.Location = New System.Drawing.Point(105, 19)
        Me.ucrNudsize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudsize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudsize.Name = "ucrNudsize"
        Me.ucrNudsize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudsize.TabIndex = 73
        Me.ucrNudsize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputTextFace
        '
        Me.ucrInputTextFace.AddQuotesIfUnrecognised = True
        Me.ucrInputTextFace.IsReadOnly = False
        Me.ucrInputTextFace.Location = New System.Drawing.Point(105, 166)
        Me.ucrInputTextFace.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputTextFace.Name = "ucrInputTextFace"
        Me.ucrInputTextFace.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTextFace.TabIndex = 71
        '
        'ucrInputTextFamily
        '
        Me.ucrInputTextFamily.AddQuotesIfUnrecognised = True
        Me.ucrInputTextFamily.IsReadOnly = False
        Me.ucrInputTextFamily.Location = New System.Drawing.Point(105, 141)
        Me.ucrInputTextFamily.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputTextFamily.Name = "ucrInputTextFamily"
        Me.ucrInputTextFamily.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTextFamily.TabIndex = 70
        '
        'ucrELementTextControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpAxisLabels)
        Me.Name = "ucrELementTextControl"
        Me.Size = New System.Drawing.Size(255, 227)
        Me.grpAxisLabels.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpAxisLabels As GroupBox
    Friend WithEvents ucrChkTextFace As ucrCheck
    Friend WithEvents ucrChkTextFamily As ucrCheck
    Friend WithEvents ucrChkAngle As ucrCheck
    Friend WithEvents ucrChkHjust As ucrCheck
    Friend WithEvents ucrChkVjust As ucrCheck
    Friend WithEvents ucrChkLineHeight As ucrCheck
    Friend WithEvents ucrChkSize As ucrCheck
    Friend WithEvents ucrNudVjust As ucrNud
    Friend WithEvents ucrNudLineHeight As ucrNud
    Friend WithEvents ucrNudAngle As ucrNud
    Friend WithEvents ucrNudHjust As ucrNud
    Friend WithEvents ucrNudsize As ucrNud
    Friend WithEvents ucrInputTextFace As ucrInputComboBox
    Friend WithEvents ucrInputTextFamily As ucrInputComboBox
    Friend WithEvents ucrChkTextColour As ucrCheck
    Friend WithEvents ucrTextColors As ucrColors
End Class
