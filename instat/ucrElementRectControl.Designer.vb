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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrElementRectControl))
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
        resources.ApplyResources(Me.grpElementRect, "grpElementRect")
        Me.grpElementRect.Name = "grpElementRect"
        Me.grpElementRect.TabStop = False
        '
        'ucrRectFill
        '
        Me.ucrRectFill.AddQuotesIfUnrecognised = True
        Me.ucrRectFill.IsReadOnly = False
        resources.ApplyResources(Me.ucrRectFill, "ucrRectFill")
        Me.ucrRectFill.Name = "ucrRectFill"
        '
        'ucrRectColors
        '
        Me.ucrRectColors.AddQuotesIfUnrecognised = True
        Me.ucrRectColors.IsReadOnly = False
        resources.ApplyResources(Me.ucrRectColors, "ucrRectColors")
        Me.ucrRectColors.Name = "ucrRectColors"
        '
        'ucrChkRectFill
        '
        Me.ucrChkRectFill.Checked = False
        resources.ApplyResources(Me.ucrChkRectFill, "ucrChkRectFill")
        Me.ucrChkRectFill.Name = "ucrChkRectFill"
        '
        'ucrChkRectSize
        '
        Me.ucrChkRectSize.Checked = False
        resources.ApplyResources(Me.ucrChkRectSize, "ucrChkRectSize")
        Me.ucrChkRectSize.Name = "ucrChkRectSize"
        '
        'ucrChkRectLineType
        '
        Me.ucrChkRectLineType.Checked = False
        resources.ApplyResources(Me.ucrChkRectLineType, "ucrChkRectLineType")
        Me.ucrChkRectLineType.Name = "ucrChkRectLineType"
        '
        'ucrChkRectColour
        '
        Me.ucrChkRectColour.Checked = False
        resources.ApplyResources(Me.ucrChkRectColour, "ucrChkRectColour")
        Me.ucrChkRectColour.Name = "ucrChkRectColour"
        '
        'ucrNudRectSize
        '
        Me.ucrNudRectSize.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRectSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudRectSize, "ucrNudRectSize")
        Me.ucrNudRectSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRectSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRectSize.Name = "ucrNudRectSize"
        Me.ucrNudRectSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputRectLineType
        '
        Me.ucrInputRectLineType.AddQuotesIfUnrecognised = True
        Me.ucrInputRectLineType.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputRectLineType, "ucrInputRectLineType")
        Me.ucrInputRectLineType.Name = "ucrInputRectLineType"
        '
        'ucrElementRectControl
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpElementRect)
        Me.Name = "ucrElementRectControl"
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
