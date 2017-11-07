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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrELementTextControl))
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
        resources.ApplyResources(Me.grpAxisLabels, "grpAxisLabels")
        Me.grpAxisLabels.Name = "grpAxisLabels"
        Me.grpAxisLabels.TabStop = False
        '
        'ucrTextColors
        '
        Me.ucrTextColors.AddQuotesIfUnrecognised = True
        Me.ucrTextColors.IsReadOnly = False
        resources.ApplyResources(Me.ucrTextColors, "ucrTextColors")
        Me.ucrTextColors.Name = "ucrTextColors"
        '
        'ucrChkTextColour
        '
        Me.ucrChkTextColour.Checked = False
        resources.ApplyResources(Me.ucrChkTextColour, "ucrChkTextColour")
        Me.ucrChkTextColour.Name = "ucrChkTextColour"
        '
        'ucrChkTextFace
        '
        Me.ucrChkTextFace.Checked = False
        resources.ApplyResources(Me.ucrChkTextFace, "ucrChkTextFace")
        Me.ucrChkTextFace.Name = "ucrChkTextFace"
        '
        'ucrChkTextFamily
        '
        Me.ucrChkTextFamily.Checked = False
        resources.ApplyResources(Me.ucrChkTextFamily, "ucrChkTextFamily")
        Me.ucrChkTextFamily.Name = "ucrChkTextFamily"
        '
        'ucrChkAngle
        '
        Me.ucrChkAngle.Checked = False
        resources.ApplyResources(Me.ucrChkAngle, "ucrChkAngle")
        Me.ucrChkAngle.Name = "ucrChkAngle"
        '
        'ucrChkHjust
        '
        Me.ucrChkHjust.Checked = False
        resources.ApplyResources(Me.ucrChkHjust, "ucrChkHjust")
        Me.ucrChkHjust.Name = "ucrChkHjust"
        '
        'ucrChkVjust
        '
        Me.ucrChkVjust.Checked = False
        resources.ApplyResources(Me.ucrChkVjust, "ucrChkVjust")
        Me.ucrChkVjust.Name = "ucrChkVjust"
        '
        'ucrChkLineHeight
        '
        Me.ucrChkLineHeight.Checked = False
        resources.ApplyResources(Me.ucrChkLineHeight, "ucrChkLineHeight")
        Me.ucrChkLineHeight.Name = "ucrChkLineHeight"
        '
        'ucrChkSize
        '
        Me.ucrChkSize.Checked = False
        resources.ApplyResources(Me.ucrChkSize, "ucrChkSize")
        Me.ucrChkSize.Name = "ucrChkSize"
        '
        'ucrNudVjust
        '
        Me.ucrNudVjust.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudVjust.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.ucrNudVjust, "ucrNudVjust")
        Me.ucrNudVjust.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudVjust.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudVjust.Name = "ucrNudVjust"
        Me.ucrNudVjust.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLineHeight
        '
        Me.ucrNudLineHeight.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLineHeight.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.ucrNudLineHeight, "ucrNudLineHeight")
        Me.ucrNudLineHeight.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLineHeight.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLineHeight.Name = "ucrNudLineHeight"
        Me.ucrNudLineHeight.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAngle
        '
        Me.ucrNudAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudAngle, "ucrNudAngle")
        Me.ucrNudAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngle.Name = "ucrNudAngle"
        Me.ucrNudAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudHjust
        '
        Me.ucrNudHjust.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHjust.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.ucrNudHjust, "ucrNudHjust")
        Me.ucrNudHjust.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHjust.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHjust.Name = "ucrNudHjust"
        Me.ucrNudHjust.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudsize
        '
        Me.ucrNudsize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudsize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudsize, "ucrNudsize")
        Me.ucrNudsize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudsize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudsize.Name = "ucrNudsize"
        Me.ucrNudsize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputTextFace
        '
        Me.ucrInputTextFace.AddQuotesIfUnrecognised = True
        Me.ucrInputTextFace.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTextFace, "ucrInputTextFace")
        Me.ucrInputTextFace.Name = "ucrInputTextFace"
        '
        'ucrInputTextFamily
        '
        Me.ucrInputTextFamily.AddQuotesIfUnrecognised = True
        Me.ucrInputTextFamily.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTextFamily, "ucrInputTextFamily")
        Me.ucrInputTextFamily.Name = "ucrInputTextFamily"
        '
        'ucrELementTextControl
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpAxisLabels)
        Me.Name = "ucrELementTextControl"
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
