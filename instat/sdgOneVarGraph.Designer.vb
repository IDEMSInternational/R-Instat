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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgOneVarGraph))
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
        resources.ApplyResources(Me.tbcOneVarGraph, "tbcOneVarGraph")
        Me.tbcOneVarGraph.Controls.Add(Me.tbpTypes)
        Me.tbcOneVarGraph.Controls.Add(Me.tbpDisplay)
        Me.tbcOneVarGraph.Name = "tbcOneVarGraph"
        Me.tbcOneVarGraph.SelectedIndex = 0
        '
        'tbpTypes
        '
        Me.tbpTypes.Controls.Add(Me.lblCategorical)
        Me.tbpTypes.Controls.Add(Me.lblNumeric)
        Me.tbpTypes.Controls.Add(Me.ucrInputCategorical)
        Me.tbpTypes.Controls.Add(Me.ucrInputNumeric)
        resources.ApplyResources(Me.tbpTypes, "tbpTypes")
        Me.tbpTypes.Name = "tbpTypes"
        Me.tbpTypes.UseVisualStyleBackColor = True
        '
        'lblCategorical
        '
        resources.ApplyResources(Me.lblCategorical, "lblCategorical")
        Me.lblCategorical.Name = "lblCategorical"
        '
        'lblNumeric
        '
        resources.ApplyResources(Me.lblNumeric, "lblNumeric")
        Me.lblNumeric.Name = "lblNumeric"
        '
        'ucrInputCategorical
        '
        Me.ucrInputCategorical.AddQuotesIfUnrecognised = True
        Me.ucrInputCategorical.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCategorical, "ucrInputCategorical")
        Me.ucrInputCategorical.Name = "ucrInputCategorical"
        '
        'ucrInputNumeric
        '
        Me.ucrInputNumeric.AddQuotesIfUnrecognised = True
        Me.ucrInputNumeric.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNumeric, "ucrInputNumeric")
        Me.ucrInputNumeric.Name = "ucrInputNumeric"
        '
        'tbpDisplay
        '
        Me.tbpDisplay.Controls.Add(Me.ucrNudNumberofColumns)
        Me.tbpDisplay.Controls.Add(Me.ucrChkFreeScaleAxisforFacets)
        Me.tbpDisplay.Controls.Add(Me.ucrChkSpecifyLayout)
        Me.tbpDisplay.Controls.Add(Me.lblNumberofColumns)
        resources.ApplyResources(Me.tbpDisplay, "tbpDisplay")
        Me.tbpDisplay.Name = "tbpDisplay"
        Me.tbpDisplay.UseVisualStyleBackColor = True
        '
        'ucrNudNumberofColumns
        '
        Me.ucrNudNumberofColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNumberofColumns, "ucrNudNumberofColumns")
        Me.ucrNudNumberofColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColumns.Name = "ucrNudNumberofColumns"
        Me.ucrNudNumberofColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkFreeScaleAxisforFacets
        '
        Me.ucrChkFreeScaleAxisforFacets.Checked = False
        resources.ApplyResources(Me.ucrChkFreeScaleAxisforFacets, "ucrChkFreeScaleAxisforFacets")
        Me.ucrChkFreeScaleAxisforFacets.Name = "ucrChkFreeScaleAxisforFacets"
        Me.ucrChkFreeScaleAxisforFacets.Tag = ""
        '
        'ucrChkSpecifyLayout
        '
        Me.ucrChkSpecifyLayout.Checked = False
        resources.ApplyResources(Me.ucrChkSpecifyLayout, "ucrChkSpecifyLayout")
        Me.ucrChkSpecifyLayout.Name = "ucrChkSpecifyLayout"
        Me.ucrChkSpecifyLayout.Tag = ""
        '
        'lblNumberofColumns
        '
        resources.ApplyResources(Me.lblNumberofColumns, "lblNumberofColumns")
        Me.lblNumberofColumns.Name = "lblNumberofColumns"
        '
        'ucrButtonsOneVarGraph
        '
        resources.ApplyResources(Me.ucrButtonsOneVarGraph, "ucrButtonsOneVarGraph")
        Me.ucrButtonsOneVarGraph.Name = "ucrButtonsOneVarGraph"
        '
        'sdgOneVarGraph
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrButtonsOneVarGraph)
        Me.Controls.Add(Me.tbcOneVarGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarGraph"
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
