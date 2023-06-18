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
Partial Class ucrElementLineControl
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
        Me.grpTickMarks = New System.Windows.Forms.GroupBox()
        Me.ucrLineColors = New instat.ucrColors()
        Me.ucrChkLineLineEnd = New instat.ucrCheck()
        Me.ucrChkLineSize = New instat.ucrCheck()
        Me.ucrChkLineLineType = New instat.ucrCheck()
        Me.ucrChkLineColour = New instat.ucrCheck()
        Me.ucrInputLineLineEnd = New instat.ucrInputComboBox()
        Me.ucrNudLineSize = New instat.ucrNud()
        Me.ucrInputLineLineType = New instat.ucrInputComboBox()
        Me.grpTickMarks.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTickMarks
        '
        Me.grpTickMarks.Controls.Add(Me.ucrLineColors)
        Me.grpTickMarks.Controls.Add(Me.ucrChkLineLineEnd)
        Me.grpTickMarks.Controls.Add(Me.ucrChkLineSize)
        Me.grpTickMarks.Controls.Add(Me.ucrChkLineLineType)
        Me.grpTickMarks.Controls.Add(Me.ucrChkLineColour)
        Me.grpTickMarks.Controls.Add(Me.ucrInputLineLineEnd)
        Me.grpTickMarks.Controls.Add(Me.ucrNudLineSize)
        Me.grpTickMarks.Controls.Add(Me.ucrInputLineLineType)
        Me.grpTickMarks.Location = New System.Drawing.Point(3, 0)
        Me.grpTickMarks.Name = "grpTickMarks"
        Me.grpTickMarks.Size = New System.Drawing.Size(246, 119)
        Me.grpTickMarks.TabIndex = 0
        Me.grpTickMarks.TabStop = False
        Me.grpTickMarks.Text = "Element Line"
        '
        'ucrLineColors
        '
        Me.ucrLineColors.AddQuotesIfUnrecognised = True
        Me.ucrLineColors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrLineColors.GetSetSelectedIndex = -1
        Me.ucrLineColors.IsReadOnly = False
        Me.ucrLineColors.Location = New System.Drawing.Point(138, 68)
        Me.ucrLineColors.Name = "ucrLineColors"
        Me.ucrLineColors.Size = New System.Drawing.Size(104, 21)
        Me.ucrLineColors.TabIndex = 5
        '
        'ucrChkLineLineEnd
        '
        Me.ucrChkLineLineEnd.AutoSize = True
        Me.ucrChkLineLineEnd.Checked = False
        Me.ucrChkLineLineEnd.Location = New System.Drawing.Point(8, 94)
        Me.ucrChkLineLineEnd.Name = "ucrChkLineLineEnd"
        Me.ucrChkLineLineEnd.Size = New System.Drawing.Size(125, 23)
        Me.ucrChkLineLineEnd.TabIndex = 6
        '
        'ucrChkLineSize
        '
        Me.ucrChkLineSize.AutoSize = True
        Me.ucrChkLineSize.Checked = False
        Me.ucrChkLineSize.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkLineSize.Name = "ucrChkLineSize"
        Me.ucrChkLineSize.Size = New System.Drawing.Size(125, 23)
        Me.ucrChkLineSize.TabIndex = 0
        '
        'ucrChkLineLineType
        '
        Me.ucrChkLineLineType.AutoSize = True
        Me.ucrChkLineLineType.Checked = False
        Me.ucrChkLineLineType.Location = New System.Drawing.Point(8, 44)
        Me.ucrChkLineLineType.Name = "ucrChkLineLineType"
        Me.ucrChkLineLineType.Size = New System.Drawing.Size(125, 23)
        Me.ucrChkLineLineType.TabIndex = 2
        '
        'ucrChkLineColour
        '
        Me.ucrChkLineColour.AutoSize = True
        Me.ucrChkLineColour.Checked = False
        Me.ucrChkLineColour.Location = New System.Drawing.Point(8, 69)
        Me.ucrChkLineColour.Name = "ucrChkLineColour"
        Me.ucrChkLineColour.Size = New System.Drawing.Size(125, 23)
        Me.ucrChkLineColour.TabIndex = 4
        '
        'ucrInputLineLineEnd
        '
        Me.ucrInputLineLineEnd.AddQuotesIfUnrecognised = True
        Me.ucrInputLineLineEnd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLineLineEnd.GetSetSelectedIndex = -1
        Me.ucrInputLineLineEnd.IsReadOnly = False
        Me.ucrInputLineLineEnd.Location = New System.Drawing.Point(138, 93)
        Me.ucrInputLineLineEnd.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLineLineEnd.Name = "ucrInputLineLineEnd"
        Me.ucrInputLineLineEnd.Size = New System.Drawing.Size(104, 21)
        Me.ucrInputLineLineEnd.TabIndex = 7
        '
        'ucrNudLineSize
        '
        Me.ucrNudLineSize.AutoSize = True
        Me.ucrNudLineSize.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLineSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLineSize.Location = New System.Drawing.Point(138, 19)
        Me.ucrNudLineSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLineSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLineSize.Name = "ucrNudLineSize"
        Me.ucrNudLineSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLineSize.TabIndex = 1
        Me.ucrNudLineSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputLineLineType
        '
        Me.ucrInputLineLineType.AddQuotesIfUnrecognised = True
        Me.ucrInputLineLineType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLineLineType.GetSetSelectedIndex = -1
        Me.ucrInputLineLineType.IsReadOnly = False
        Me.ucrInputLineLineType.Location = New System.Drawing.Point(138, 43)
        Me.ucrInputLineLineType.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLineLineType.Name = "ucrInputLineLineType"
        Me.ucrInputLineLineType.Size = New System.Drawing.Size(104, 21)
        Me.ucrInputLineLineType.TabIndex = 3
        '
        'ucrElementLineControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.grpTickMarks)
        Me.Name = "ucrElementLineControl"
        Me.Size = New System.Drawing.Size(255, 123)
        Me.grpTickMarks.ResumeLayout(False)
        Me.grpTickMarks.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpTickMarks As GroupBox
    Friend WithEvents ucrChkLineLineEnd As ucrCheck
    Friend WithEvents ucrChkLineSize As ucrCheck
    Friend WithEvents ucrChkLineLineType As ucrCheck
    Friend WithEvents ucrChkLineColour As ucrCheck
    Friend WithEvents ucrInputLineLineEnd As ucrInputComboBox
    Friend WithEvents ucrNudLineSize As ucrNud
    Friend WithEvents ucrInputLineLineType As ucrInputComboBox
    Friend WithEvents ucrLineColors As ucrColors
End Class
