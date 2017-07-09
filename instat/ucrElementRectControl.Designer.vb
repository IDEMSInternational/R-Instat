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
Partial Class ucrElementRectControl
    Inherits instat.ucrCore

    'UserControl overrides dispose to clean up the component list.
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
        Me.grpElementRect = New System.Windows.Forms.GroupBox()
        Me.ucrRectFill = New instat.ucrColors()
        Me.ucrRectColors = New instat.ucrColors()
        Me.ucrChkRectFill = New instat.ucrCheck()
        Me.ucrChkRectSize = New instat.ucrCheck()
        Me.ucrChkRectLineType = New instat.ucrCheck()
        Me.ucrChkRectColour = New instat.ucrCheck()
        Me.ucrNudRectSize = New instat.ucrNud()
        Me.ucrInputRectLineType = New instat.ucrInputComboBox()
        Me.grpElementRect.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpElementRect
        '
        Me.grpElementRect.Controls.Add(Me.ucrRectFill)
        Me.grpElementRect.Controls.Add(Me.ucrRectColors)
        Me.grpElementRect.Controls.Add(Me.ucrChkRectFill)
        Me.grpElementRect.Controls.Add(Me.ucrChkRectSize)
        Me.grpElementRect.Controls.Add(Me.ucrChkRectLineType)
        Me.grpElementRect.Controls.Add(Me.ucrChkRectColour)
        Me.grpElementRect.Controls.Add(Me.ucrNudRectSize)
        Me.grpElementRect.Controls.Add(Me.ucrInputRectLineType)
        Me.grpElementRect.Location = New System.Drawing.Point(3, 0)
        Me.grpElementRect.Name = "grpElementRect"
        Me.grpElementRect.Size = New System.Drawing.Size(246, 119)
        Me.grpElementRect.TabIndex = 0
        Me.grpElementRect.TabStop = False
        Me.grpElementRect.Text = "ElementRect"
        '
        'ucrRectFill
        '
        Me.ucrRectFill.AddQuotesIfUnrecognised = True
        Me.ucrRectFill.IsReadOnly = False
        Me.ucrRectFill.Location = New System.Drawing.Point(105, 93)
        Me.ucrRectFill.Name = "ucrRectFill"
        Me.ucrRectFill.Size = New System.Drawing.Size(137, 21)
        Me.ucrRectFill.TabIndex = 7
        '
        'ucrRectColors
        '
        Me.ucrRectColors.AddQuotesIfUnrecognised = True
        Me.ucrRectColors.IsReadOnly = False
        Me.ucrRectColors.Location = New System.Drawing.Point(105, 68)
        Me.ucrRectColors.Name = "ucrRectColors"
        Me.ucrRectColors.Size = New System.Drawing.Size(137, 21)
        Me.ucrRectColors.TabIndex = 5
        '
        'ucrChkRectFill
        '
        Me.ucrChkRectFill.Checked = False
        Me.ucrChkRectFill.Location = New System.Drawing.Point(6, 94)
        Me.ucrChkRectFill.Name = "ucrChkRectFill"
        Me.ucrChkRectFill.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkRectFill.TabIndex = 6
        '
        'ucrChkRectSize
        '
        Me.ucrChkRectSize.Checked = False
        Me.ucrChkRectSize.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkRectSize.Name = "ucrChkRectSize"
        Me.ucrChkRectSize.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkRectSize.TabIndex = 0
        '
        'ucrChkRectLineType
        '
        Me.ucrChkRectLineType.Checked = False
        Me.ucrChkRectLineType.Location = New System.Drawing.Point(8, 44)
        Me.ucrChkRectLineType.Name = "ucrChkRectLineType"
        Me.ucrChkRectLineType.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkRectLineType.TabIndex = 2
        '
        'ucrChkRectColour
        '
        Me.ucrChkRectColour.Checked = False
        Me.ucrChkRectColour.Location = New System.Drawing.Point(6, 69)
        Me.ucrChkRectColour.Name = "ucrChkRectColour"
        Me.ucrChkRectColour.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkRectColour.TabIndex = 4
        '
        'ucrNudRectSize
        '
        Me.ucrNudRectSize.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRectSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRectSize.Location = New System.Drawing.Point(105, 19)
        Me.ucrNudRectSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRectSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRectSize.Name = "ucrNudRectSize"
        Me.ucrNudRectSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudRectSize.TabIndex = 1
        Me.ucrNudRectSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputRectLineType
        '
        Me.ucrInputRectLineType.AddQuotesIfUnrecognised = True
        Me.ucrInputRectLineType.IsReadOnly = False
        Me.ucrInputRectLineType.Location = New System.Drawing.Point(105, 43)
        Me.ucrInputRectLineType.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputRectLineType.Name = "ucrInputRectLineType"
        Me.ucrInputRectLineType.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputRectLineType.TabIndex = 3
        '
        'ucrElementRectControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpElementRect)
        Me.Name = "ucrElementRectControl"
        Me.Size = New System.Drawing.Size(255, 123)
        Me.grpElementRect.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpElementRect As GroupBox
    Friend WithEvents ucrRectColors As ucrColors
    Friend WithEvents ucrChkRectFill As ucrCheck
    Friend WithEvents ucrChkRectSize As ucrCheck
    Friend WithEvents ucrChkRectLineType As ucrCheck
    Friend WithEvents ucrChkRectColour As ucrCheck
    Friend WithEvents ucrNudRectSize As ucrNud
    Friend WithEvents ucrInputRectLineType As ucrInputComboBox
    Friend WithEvents ucrRectFill As ucrColors
End Class
