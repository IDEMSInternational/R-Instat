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
        Me.tbcOneVarGraph = New System.Windows.Forms.TabControl()
        Me.tbpTypes = New System.Windows.Forms.TabPage()
        Me.grpCategorical = New System.Windows.Forms.GroupBox()
        Me.lblCategorical = New System.Windows.Forms.Label()
        Me.ucrInputCategorical = New instat.ucrInputComboBox()
        Me.ucrChkColour = New instat.ucrCheck()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.ucrInputLabel = New instat.ucrInputComboBox()
        Me.lblNumeric = New System.Windows.Forms.Label()
        Me.ucrInputNumeric = New instat.ucrInputComboBox()
        Me.tbpDisplay = New System.Windows.Forms.TabPage()
        Me.ucrNudNumberofColumns = New instat.ucrNud()
        Me.ucrChkFreeScaleAxisforFacets = New instat.ucrCheck()
        Me.ucrChkSpecifyLayout = New instat.ucrCheck()
        Me.lblNumberofColumns = New System.Windows.Forms.Label()
        Me.ucrButtonsOneVarGraph = New instat.ucrButtonsSubdialogue()
        Me.tbcOneVarGraph.SuspendLayout()
        Me.tbpTypes.SuspendLayout()
        Me.grpCategorical.SuspendLayout()
        Me.tbpDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcOneVarGraph
        '
        Me.tbcOneVarGraph.AccessibleName = ""
        Me.tbcOneVarGraph.Controls.Add(Me.tbpTypes)
        Me.tbcOneVarGraph.Controls.Add(Me.tbpDisplay)
        Me.tbcOneVarGraph.Location = New System.Drawing.Point(6, 9)
        Me.tbcOneVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.tbcOneVarGraph.Name = "tbcOneVarGraph"
        Me.tbcOneVarGraph.SelectedIndex = 0
        Me.tbcOneVarGraph.Size = New System.Drawing.Size(306, 244)
        Me.tbcOneVarGraph.TabIndex = 0
        '
        'tbpTypes
        '
        Me.tbpTypes.Controls.Add(Me.grpCategorical)
        Me.tbpTypes.Controls.Add(Me.lblNumeric)
        Me.tbpTypes.Controls.Add(Me.ucrInputNumeric)
        Me.tbpTypes.Location = New System.Drawing.Point(4, 25)
        Me.tbpTypes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpTypes.Name = "tbpTypes"
        Me.tbpTypes.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpTypes.Size = New System.Drawing.Size(298, 215)
        Me.tbpTypes.TabIndex = 0
        Me.tbpTypes.Text = "Types"
        Me.tbpTypes.UseVisualStyleBackColor = True
        '
        'grpCategorical
        '
        Me.grpCategorical.Controls.Add(Me.lblCategorical)
        Me.grpCategorical.Controls.Add(Me.ucrInputCategorical)
        Me.grpCategorical.Controls.Add(Me.ucrChkColour)
        Me.grpCategorical.Controls.Add(Me.lblLabel)
        Me.grpCategorical.Controls.Add(Me.ucrInputLabel)
        Me.grpCategorical.Location = New System.Drawing.Point(9, 56)
        Me.grpCategorical.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpCategorical.Name = "grpCategorical"
        Me.grpCategorical.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpCategorical.Size = New System.Drawing.Size(275, 144)
        Me.grpCategorical.TabIndex = 2
        Me.grpCategorical.TabStop = False
        Me.grpCategorical.Text = "Categorical"
        '
        'lblCategorical
        '
        Me.lblCategorical.AutoSize = True
        Me.lblCategorical.Location = New System.Drawing.Point(8, 28)
        Me.lblCategorical.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategorical.Name = "lblCategorical"
        Me.lblCategorical.Size = New System.Drawing.Size(79, 16)
        Me.lblCategorical.TabIndex = 2
        Me.lblCategorical.Text = "Categorical:"
        '
        'ucrInputCategorical
        '
        Me.ucrInputCategorical.AddQuotesIfUnrecognised = True
        Me.ucrInputCategorical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCategorical.GetSetSelectedIndex = -1
        Me.ucrInputCategorical.IsReadOnly = False
        Me.ucrInputCategorical.Location = New System.Drawing.Point(100, 24)
        Me.ucrInputCategorical.Margin = New System.Windows.Forms.Padding(26, 21, 26, 21)
        Me.ucrInputCategorical.Name = "ucrInputCategorical"
        Me.ucrInputCategorical.Size = New System.Drawing.Size(162, 26)
        Me.ucrInputCategorical.TabIndex = 3
        '
        'ucrChkColour
        '
        Me.ucrChkColour.AutoSize = True
        Me.ucrChkColour.Checked = False
        Me.ucrChkColour.Location = New System.Drawing.Point(100, 62)
        Me.ucrChkColour.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkColour.Name = "ucrChkColour"
        Me.ucrChkColour.Size = New System.Drawing.Size(138, 36)
        Me.ucrChkColour.TabIndex = 4
        Me.ucrChkColour.Tag = ""
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Location = New System.Drawing.Point(8, 102)
        Me.lblLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(44, 16)
        Me.lblLabel.TabIndex = 5
        Me.lblLabel.Text = "Label:"
        '
        'ucrInputLabel
        '
        Me.ucrInputLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLabel.GetSetSelectedIndex = -1
        Me.ucrInputLabel.IsReadOnly = False
        Me.ucrInputLabel.Location = New System.Drawing.Point(100, 99)
        Me.ucrInputLabel.Margin = New System.Windows.Forms.Padding(26, 21, 26, 21)
        Me.ucrInputLabel.Name = "ucrInputLabel"
        Me.ucrInputLabel.Size = New System.Drawing.Size(162, 26)
        Me.ucrInputLabel.TabIndex = 6
        '
        'lblNumeric
        '
        Me.lblNumeric.AutoSize = True
        Me.lblNumeric.Location = New System.Drawing.Point(16, 28)
        Me.lblNumeric.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeric.Name = "lblNumeric"
        Me.lblNumeric.Size = New System.Drawing.Size(60, 16)
        Me.lblNumeric.TabIndex = 0
        Me.lblNumeric.Text = "Numeric:"
        '
        'ucrInputNumeric
        '
        Me.ucrInputNumeric.AddQuotesIfUnrecognised = True
        Me.ucrInputNumeric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputNumeric.GetSetSelectedIndex = -1
        Me.ucrInputNumeric.IsReadOnly = False
        Me.ucrInputNumeric.Location = New System.Drawing.Point(109, 24)
        Me.ucrInputNumeric.Margin = New System.Windows.Forms.Padding(26, 21, 26, 21)
        Me.ucrInputNumeric.Name = "ucrInputNumeric"
        Me.ucrInputNumeric.Size = New System.Drawing.Size(162, 26)
        Me.ucrInputNumeric.TabIndex = 1
        '
        'tbpDisplay
        '
        Me.tbpDisplay.Controls.Add(Me.ucrNudNumberofColumns)
        Me.tbpDisplay.Controls.Add(Me.ucrChkFreeScaleAxisforFacets)
        Me.tbpDisplay.Controls.Add(Me.ucrChkSpecifyLayout)
        Me.tbpDisplay.Controls.Add(Me.lblNumberofColumns)
        Me.tbpDisplay.Location = New System.Drawing.Point(4, 25)
        Me.tbpDisplay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpDisplay.Name = "tbpDisplay"
        Me.tbpDisplay.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpDisplay.Size = New System.Drawing.Size(298, 215)
        Me.tbpDisplay.TabIndex = 1
        Me.tbpDisplay.Text = "Display"
        Me.tbpDisplay.UseVisualStyleBackColor = True
        '
        'ucrNudNumberofColumns
        '
        Me.ucrNudNumberofColumns.AutoSize = True
        Me.ucrNudNumberofColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberofColumns.Location = New System.Drawing.Point(150, 58)
        Me.ucrNudNumberofColumns.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.ucrNudNumberofColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColumns.Name = "ucrNudNumberofColumns"
        Me.ucrNudNumberofColumns.Size = New System.Drawing.Size(54, 25)
        Me.ucrNudNumberofColumns.TabIndex = 2
        Me.ucrNudNumberofColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkFreeScaleAxisforFacets
        '
        Me.ucrChkFreeScaleAxisforFacets.AutoSize = True
        Me.ucrChkFreeScaleAxisforFacets.Checked = False
        Me.ucrChkFreeScaleAxisforFacets.Location = New System.Drawing.Point(14, 94)
        Me.ucrChkFreeScaleAxisforFacets.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.ucrChkFreeScaleAxisforFacets.Name = "ucrChkFreeScaleAxisforFacets"
        Me.ucrChkFreeScaleAxisforFacets.Size = New System.Drawing.Size(282, 36)
        Me.ucrChkFreeScaleAxisforFacets.TabIndex = 3
        Me.ucrChkFreeScaleAxisforFacets.Tag = ""
        '
        'ucrChkSpecifyLayout
        '
        Me.ucrChkSpecifyLayout.AutoSize = True
        Me.ucrChkSpecifyLayout.Checked = False
        Me.ucrChkSpecifyLayout.Location = New System.Drawing.Point(12, 20)
        Me.ucrChkSpecifyLayout.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.ucrChkSpecifyLayout.Name = "ucrChkSpecifyLayout"
        Me.ucrChkSpecifyLayout.Size = New System.Drawing.Size(250, 36)
        Me.ucrChkSpecifyLayout.TabIndex = 0
        Me.ucrChkSpecifyLayout.Tag = ""
        '
        'lblNumberofColumns
        '
        Me.lblNumberofColumns.AutoSize = True
        Me.lblNumberofColumns.Location = New System.Drawing.Point(10, 60)
        Me.lblNumberofColumns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumberofColumns.Name = "lblNumberofColumns"
        Me.lblNumberofColumns.Size = New System.Drawing.Size(127, 16)
        Me.lblNumberofColumns.TabIndex = 1
        Me.lblNumberofColumns.Text = "Number of Columns:"
        '
        'ucrButtonsOneVarGraph
        '
        Me.ucrButtonsOneVarGraph.AutoSize = True
        Me.ucrButtonsOneVarGraph.Location = New System.Drawing.Point(21, 259)
        Me.ucrButtonsOneVarGraph.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.ucrButtonsOneVarGraph.Name = "ucrButtonsOneVarGraph"
        Me.ucrButtonsOneVarGraph.Size = New System.Drawing.Size(281, 38)
        Me.ucrButtonsOneVarGraph.TabIndex = 1
        '
        'sdgOneVarGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(316, 306)
        Me.Controls.Add(Me.tbcOneVarGraph)
        Me.Controls.Add(Me.ucrButtonsOneVarGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "One Variable Graph Options"
        Me.tbcOneVarGraph.ResumeLayout(False)
        Me.tbpTypes.ResumeLayout(False)
        Me.tbpTypes.PerformLayout()
        Me.grpCategorical.ResumeLayout(False)
        Me.grpCategorical.PerformLayout()
        Me.tbpDisplay.ResumeLayout(False)
        Me.tbpDisplay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbcOneVarGraph As TabControl
    Friend WithEvents tbpTypes As TabPage
    Friend WithEvents tbpDisplay As TabPage
    Friend WithEvents ucrButtonsOneVarGraph As ucrButtonsSubdialogue
    Friend WithEvents ucrInputNumeric As ucrInputComboBox
    Friend WithEvents lblNumeric As Label
    Friend WithEvents grpCategorical As GroupBox
    Friend WithEvents lblCategorical As Label
    Friend WithEvents ucrInputCategorical As ucrInputComboBox
    Friend WithEvents ucrChkColour As ucrCheck
    Friend WithEvents lblLabel As Label
    Friend WithEvents ucrInputLabel As ucrInputComboBox
    Friend WithEvents lblNumberofColumns As Label
    Friend WithEvents ucrChkFreeScaleAxisforFacets As ucrCheck
    Friend WithEvents ucrChkSpecifyLayout As ucrCheck
    Friend WithEvents ucrNudNumberofColumns As ucrNud
End Class