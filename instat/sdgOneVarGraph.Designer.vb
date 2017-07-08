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
Partial Class sdgOneVarGraph
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
        Me.tbcOneVarGraph = New System.Windows.Forms.TabControl()
        Me.tbpTypes = New System.Windows.Forms.TabPage()
        Me.lblCategorical = New System.Windows.Forms.Label()
        Me.lblNumeric = New System.Windows.Forms.Label()
        Me.ucrInputCategorical = New instat.ucrInputComboBox()
        Me.ucrInputNumeric = New instat.ucrInputComboBox()
        Me.tbpDisplay = New System.Windows.Forms.TabPage()
        Me.ucrNudNumberofColumns = New instat.ucrNud()
        Me.ucrChkFreeScaleAxisforFacets = New instat.ucrCheck()
        Me.ucrChkSpecifyLayout = New instat.ucrCheck()
        Me.lblNumberofColumns = New System.Windows.Forms.Label()
        Me.ucrButtonsOneVarGraph = New instat.ucrButtonsSubdialogue()
        Me.tbcOneVarGraph.SuspendLayout()
        Me.tbpTypes.SuspendLayout()
        Me.tbpDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcOneVarGraph
        '
        Me.tbcOneVarGraph.AccessibleName = ""
        Me.tbcOneVarGraph.Controls.Add(Me.tbpTypes)
        Me.tbcOneVarGraph.Controls.Add(Me.tbpDisplay)
        Me.tbcOneVarGraph.Location = New System.Drawing.Point(5, 7)
        Me.tbcOneVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.tbcOneVarGraph.Name = "tbcOneVarGraph"
        Me.tbcOneVarGraph.SelectedIndex = 0
        Me.tbcOneVarGraph.Size = New System.Drawing.Size(245, 168)
        Me.tbcOneVarGraph.TabIndex = 0
        '
        'tbpTypes
        '
        Me.tbpTypes.Controls.Add(Me.lblCategorical)
        Me.tbpTypes.Controls.Add(Me.lblNumeric)
        Me.tbpTypes.Controls.Add(Me.ucrInputCategorical)
        Me.tbpTypes.Controls.Add(Me.ucrInputNumeric)
        Me.tbpTypes.Location = New System.Drawing.Point(4, 22)
        Me.tbpTypes.Name = "tbpTypes"
        Me.tbpTypes.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpTypes.Size = New System.Drawing.Size(237, 142)
        Me.tbpTypes.TabIndex = 0
        Me.tbpTypes.Text = "Types"
        Me.tbpTypes.UseVisualStyleBackColor = True
        '
        'lblCategorical
        '
        Me.lblCategorical.AutoSize = True
        Me.lblCategorical.Location = New System.Drawing.Point(10, 53)
        Me.lblCategorical.Name = "lblCategorical"
        Me.lblCategorical.Size = New System.Drawing.Size(63, 13)
        Me.lblCategorical.TabIndex = 2
        Me.lblCategorical.Text = "Categorical:"
        '
        'lblNumeric
        '
        Me.lblNumeric.AutoSize = True
        Me.lblNumeric.Location = New System.Drawing.Point(10, 22)
        Me.lblNumeric.Name = "lblNumeric"
        Me.lblNumeric.Size = New System.Drawing.Size(49, 13)
        Me.lblNumeric.TabIndex = 0
        Me.lblNumeric.Text = "Numeric:"
        '
        'ucrInputCategorical
        '
        Me.ucrInputCategorical.AddQuotesIfUnrecognised = True
        Me.ucrInputCategorical.IsReadOnly = False
        Me.ucrInputCategorical.Location = New System.Drawing.Point(76, 50)
        Me.ucrInputCategorical.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputCategorical.Name = "ucrInputCategorical"
        Me.ucrInputCategorical.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputCategorical.TabIndex = 3
        '
        'ucrInputNumeric
        '
        Me.ucrInputNumeric.AddQuotesIfUnrecognised = True
        Me.ucrInputNumeric.IsReadOnly = False
        Me.ucrInputNumeric.Location = New System.Drawing.Point(76, 19)
        Me.ucrInputNumeric.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputNumeric.Name = "ucrInputNumeric"
        Me.ucrInputNumeric.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNumeric.TabIndex = 1
        '
        'tbpDisplay
        '
        Me.tbpDisplay.Controls.Add(Me.ucrNudNumberofColumns)
        Me.tbpDisplay.Controls.Add(Me.ucrChkFreeScaleAxisforFacets)
        Me.tbpDisplay.Controls.Add(Me.ucrChkSpecifyLayout)
        Me.tbpDisplay.Controls.Add(Me.lblNumberofColumns)
        Me.tbpDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbpDisplay.Name = "tbpDisplay"
        Me.tbpDisplay.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpDisplay.Size = New System.Drawing.Size(237, 142)
        Me.tbpDisplay.TabIndex = 1
        Me.tbpDisplay.Text = "Display"
        Me.tbpDisplay.UseVisualStyleBackColor = True
        '
        'ucrNudNumberofColumns
        '
        Me.ucrNudNumberofColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberofColumns.Location = New System.Drawing.Point(113, 46)
        Me.ucrNudNumberofColumns.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ucrNudNumberofColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColumns.Name = "ucrNudNumberofColumns"
        Me.ucrNudNumberofColumns.Size = New System.Drawing.Size(43, 20)
        Me.ucrNudNumberofColumns.TabIndex = 2
        Me.ucrNudNumberofColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkFreeScaleAxisforFacets
        '
        Me.ucrChkFreeScaleAxisforFacets.Checked = False
        Me.ucrChkFreeScaleAxisforFacets.Location = New System.Drawing.Point(11, 75)
        Me.ucrChkFreeScaleAxisforFacets.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ucrChkFreeScaleAxisforFacets.Name = "ucrChkFreeScaleAxisforFacets"
        Me.ucrChkFreeScaleAxisforFacets.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFreeScaleAxisforFacets.TabIndex = 3
        Me.ucrChkFreeScaleAxisforFacets.Tag = ""
        '
        'ucrChkSpecifyLayout
        '
        Me.ucrChkSpecifyLayout.Checked = False
        Me.ucrChkSpecifyLayout.Location = New System.Drawing.Point(10, 16)
        Me.ucrChkSpecifyLayout.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ucrChkSpecifyLayout.Name = "ucrChkSpecifyLayout"
        Me.ucrChkSpecifyLayout.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSpecifyLayout.TabIndex = 0
        Me.ucrChkSpecifyLayout.Tag = ""
        '
        'lblNumberofColumns
        '
        Me.lblNumberofColumns.AutoSize = True
        Me.lblNumberofColumns.Location = New System.Drawing.Point(8, 48)
        Me.lblNumberofColumns.Name = "lblNumberofColumns"
        Me.lblNumberofColumns.Size = New System.Drawing.Size(102, 13)
        Me.lblNumberofColumns.TabIndex = 1
        Me.lblNumberofColumns.Text = "Number of Columns:"
        '
        'ucrButtonsOneVarGraph
        '
        Me.ucrButtonsOneVarGraph.Location = New System.Drawing.Point(52, 181)
        Me.ucrButtonsOneVarGraph.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ucrButtonsOneVarGraph.Name = "ucrButtonsOneVarGraph"
        Me.ucrButtonsOneVarGraph.Size = New System.Drawing.Size(145, 30)
        Me.ucrButtonsOneVarGraph.TabIndex = 1
        '
        'sdgOneVarGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 216)
        Me.Controls.Add(Me.ucrButtonsOneVarGraph)
        Me.Controls.Add(Me.tbcOneVarGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "One Variable Graph Options"
        Me.tbcOneVarGraph.ResumeLayout(False)
        Me.tbpTypes.ResumeLayout(False)
        Me.tbpTypes.PerformLayout()
        Me.tbpDisplay.ResumeLayout(False)
        Me.tbpDisplay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcOneVarGraph As TabControl
    Friend WithEvents tbpTypes As TabPage
    Friend WithEvents tbpDisplay As TabPage
    Friend WithEvents ucrButtonsOneVarGraph As ucrButtonsSubdialogue
    Friend WithEvents ucrInputNumeric As ucrInputComboBox
    Friend WithEvents lblNumeric As Label
    Friend WithEvents lblCategorical As Label
    Friend WithEvents ucrInputCategorical As ucrInputComboBox
    Friend WithEvents lblNumberofColumns As Label
    Friend WithEvents ucrChkFreeScaleAxisforFacets As ucrCheck
    Friend WithEvents ucrChkSpecifyLayout As ucrCheck
    Friend WithEvents ucrNudNumberofColumns As ucrNud
End Class
