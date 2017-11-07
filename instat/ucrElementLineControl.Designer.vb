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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrElementLineControl))
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
        resources.ApplyResources(Me.grpTickMarks, "grpTickMarks")
        Me.grpTickMarks.Name = "grpTickMarks"
        Me.grpTickMarks.TabStop = False
        '
        'ucrLineColors
        '
        Me.ucrLineColors.AddQuotesIfUnrecognised = True
        Me.ucrLineColors.IsReadOnly = False
        resources.ApplyResources(Me.ucrLineColors, "ucrLineColors")
        Me.ucrLineColors.Name = "ucrLineColors"
        '
        'ucrChkLineLineEnd
        '
        Me.ucrChkLineLineEnd.Checked = False
        resources.ApplyResources(Me.ucrChkLineLineEnd, "ucrChkLineLineEnd")
        Me.ucrChkLineLineEnd.Name = "ucrChkLineLineEnd"
        '
        'ucrChkLineSize
        '
        Me.ucrChkLineSize.Checked = False
        resources.ApplyResources(Me.ucrChkLineSize, "ucrChkLineSize")
        Me.ucrChkLineSize.Name = "ucrChkLineSize"
        '
        'ucrChkLineLineType
        '
        Me.ucrChkLineLineType.Checked = False
        resources.ApplyResources(Me.ucrChkLineLineType, "ucrChkLineLineType")
        Me.ucrChkLineLineType.Name = "ucrChkLineLineType"
        '
        'ucrChkLineColour
        '
        Me.ucrChkLineColour.Checked = False
        resources.ApplyResources(Me.ucrChkLineColour, "ucrChkLineColour")
        Me.ucrChkLineColour.Name = "ucrChkLineColour"
        '
        'ucrInputLineLineEnd
        '
        Me.ucrInputLineLineEnd.AddQuotesIfUnrecognised = True
        Me.ucrInputLineLineEnd.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLineLineEnd, "ucrInputLineLineEnd")
        Me.ucrInputLineLineEnd.Name = "ucrInputLineLineEnd"
        '
        'ucrNudLineSize
        '
        Me.ucrNudLineSize.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLineSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudLineSize, "ucrNudLineSize")
        Me.ucrNudLineSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLineSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLineSize.Name = "ucrNudLineSize"
        Me.ucrNudLineSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputLineLineType
        '
        Me.ucrInputLineLineType.AddQuotesIfUnrecognised = True
        Me.ucrInputLineLineType.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLineLineType, "ucrInputLineLineType")
        Me.ucrInputLineLineType.Name = "ucrInputLineLineType"
        '
        'ucrElementLineControl
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpTickMarks)
        Me.Name = "ucrElementLineControl"
        Me.grpTickMarks.ResumeLayout(False)
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
