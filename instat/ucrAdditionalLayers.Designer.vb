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
Partial Class ucrAdditionalLayers
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
        Me.components = New System.ComponentModel.Container()
        Me.lblLayers = New System.Windows.Forms.Label()
        Me.lstLayers = New System.Windows.Forms.ListView()
        Me.grpGeoms = New System.Windows.Forms.GroupBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdAdd = New instat.ucrSplitButton()
        Me.contextMenuStripAdd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItemGeomBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomBoxPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomcategoricalmodel = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomCol = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomcontour = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomCount = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomDensity = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomDensityRidges = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomhistogram = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomJitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomLabel = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomLabelRepel = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomLine = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomparallelslopes = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomPoint = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomRug = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomsmooth = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomText = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomTextRepel = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomtile = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmducrTop = New System.Windows.Forms.Button()
        Me.cmdUp = New System.Windows.Forms.Button()
        Me.cmdDown = New System.Windows.Forms.Button()
        Me.cmdBottom = New System.Windows.Forms.Button()
        Me.grpGeoms.SuspendLayout()
        Me.contextMenuStripAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLayers
        '
        Me.lblLayers.AutoSize = True
        Me.lblLayers.Location = New System.Drawing.Point(5, 16)
        Me.lblLayers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLayers.Name = "lblLayers"
        Me.lblLayers.Size = New System.Drawing.Size(51, 16)
        Me.lblLayers.TabIndex = 5
        Me.lblLayers.Text = "Layers:"
        '
        'lstLayers
        '
        Me.lstLayers.FullRowSelect = True
        Me.lstLayers.HideSelection = False
        Me.lstLayers.Location = New System.Drawing.Point(4, 35)
        Me.lstLayers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstLayers.Name = "lstLayers"
        Me.lstLayers.Size = New System.Drawing.Size(155, 185)
        Me.lstLayers.TabIndex = 4
        Me.lstLayers.UseCompatibleStateImageBehavior = False
        Me.lstLayers.View = System.Windows.Forms.View.List
        '
        'grpGeoms
        '
        Me.grpGeoms.Controls.Add(Me.cmdDelete)
        Me.grpGeoms.Controls.Add(Me.cmdAdd)
        Me.grpGeoms.Controls.Add(Me.cmdEdit)
        Me.grpGeoms.Location = New System.Drawing.Point(235, 66)
        Me.grpGeoms.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpGeoms.Name = "grpGeoms"
        Me.grpGeoms.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpGeoms.Size = New System.Drawing.Size(132, 125)
        Me.grpGeoms.TabIndex = 9
        Me.grpGeoms.TabStop = False
        Me.grpGeoms.Text = "Geoms:"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(20, 90)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(94, 29)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.AutoSize = True
        Me.cmdAdd.ContextMenuStrip = Me.contextMenuStripAdd
        Me.cmdAdd.Location = New System.Drawing.Point(20, 19)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(94, 32)
        Me.cmdAdd.SplitMenuStrip = Me.contextMenuStripAdd
        Me.cmdAdd.TabIndex = 11
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'contextMenuStripAdd
        '
        Me.contextMenuStripAdd.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.contextMenuStripAdd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemGeomBar, Me.toolStripMenuItemGeomBoxPlot, Me.toolStripMenuItemGeomcategoricalmodel, Me.toolStripMenuItemGeomCol, Me.toolStripMenuItemGeomcontour, Me.toolStripMenuItemGeomCount, Me.toolStripMenuItemGeomDensity, Me.toolStripMenuItemGeomDensityRidges, Me.toolStripMenuItemGeomhistogram, Me.toolStripMenuItemGeomJitter, Me.toolStripMenuItemGeomLabel, Me.toolStripMenuItemGeomLabelRepel, Me.toolStripMenuItemGeomLine, Me.toolStripMenuItemGeomparallelslopes, Me.toolStripMenuItemGeomPoint, Me.toolStripMenuItemGeomRug, Me.toolStripMenuItemGeomsmooth, Me.toolStripMenuItemGeomText, Me.toolStripMenuItemGeomTextRepel, Me.toolStripMenuItemGeomtile})
        Me.contextMenuStripAdd.Name = "contextMenuStripOk"
        Me.contextMenuStripAdd.Size = New System.Drawing.Size(247, 484)
        '
        'toolStripMenuItemGeomBar
        '
        Me.toolStripMenuItemGeomBar.Name = "toolStripMenuItemGeomBar"
        Me.toolStripMenuItemGeomBar.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomBar.Text = "geom_bar"
        '
        'toolStripMenuItemGeomBoxPlot
        '
        Me.toolStripMenuItemGeomBoxPlot.Name = "toolStripMenuItemGeomBoxPlot"
        Me.toolStripMenuItemGeomBoxPlot.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomBoxPlot.Text = "geom_boxplot"
        '
        'toolStripMenuItemGeomcategoricalmodel
        '
        Me.toolStripMenuItemGeomcategoricalmodel.Name = "toolStripMenuItemGeomcategoricalmodel"
        Me.toolStripMenuItemGeomcategoricalmodel.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomcategoricalmodel.Text = "geom_categorical_model"
        '
        'toolStripMenuItemGeomCol
        '
        Me.toolStripMenuItemGeomCol.Name = "toolStripMenuItemGeomCol"
        Me.toolStripMenuItemGeomCol.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomCol.Text = "geom_col"
        '
        'toolStripMenuItemGeomcontour
        '
        Me.toolStripMenuItemGeomcontour.Name = "toolStripMenuItemGeomcontour"
        Me.toolStripMenuItemGeomcontour.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomcontour.Text = "geom_contour"
        '
        'toolStripMenuItemGeomCount
        '
        Me.toolStripMenuItemGeomCount.Name = "toolStripMenuItemGeomCount"
        Me.toolStripMenuItemGeomCount.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomCount.Text = "geom_count"
        '
        'toolStripMenuItemGeomDensity
        '
        Me.toolStripMenuItemGeomDensity.Name = "toolStripMenuItemGeomDensity"
        Me.toolStripMenuItemGeomDensity.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomDensity.Text = "geom_density"
        '
        'toolStripMenuItemGeomDensityRidges
        '
        Me.toolStripMenuItemGeomDensityRidges.Name = "toolStripMenuItemGeomDensityRidges"
        Me.toolStripMenuItemGeomDensityRidges.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomDensityRidges.Text = "geom_density_ridges"
        '
        'toolStripMenuItemGeomhistogram
        '
        Me.toolStripMenuItemGeomhistogram.Name = "toolStripMenuItemGeomhistogram"
        Me.toolStripMenuItemGeomhistogram.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomhistogram.Text = "geom_histogram "
        '
        'toolStripMenuItemGeomJitter
        '
        Me.toolStripMenuItemGeomJitter.Name = "toolStripMenuItemGeomJitter"
        Me.toolStripMenuItemGeomJitter.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomJitter.Text = "geom_jitter"
        '
        'toolStripMenuItemGeomLabel
        '
        Me.toolStripMenuItemGeomLabel.Name = "toolStripMenuItemGeomLabel"
        Me.toolStripMenuItemGeomLabel.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomLabel.Text = "geom_label"
        '
        'toolStripMenuItemGeomLabelRepel
        '
        Me.toolStripMenuItemGeomLabelRepel.Name = "toolStripMenuItemGeomLabelRepel"
        Me.toolStripMenuItemGeomLabelRepel.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomLabelRepel.Text = "geom_label_repel"
        '
        'toolStripMenuItemGeomLine
        '
        Me.toolStripMenuItemGeomLine.Name = "toolStripMenuItemGeomLine"
        Me.toolStripMenuItemGeomLine.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomLine.Text = "geom_line"
        '
        'toolStripMenuItemGeomparallelslopes
        '
        Me.toolStripMenuItemGeomparallelslopes.Name = "toolStripMenuItemGeomparallelslopes"
        Me.toolStripMenuItemGeomparallelslopes.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomparallelslopes.Text = "geom_parallel_slopes"
        '
        'toolStripMenuItemGeomPoint
        '
        Me.toolStripMenuItemGeomPoint.Name = "toolStripMenuItemGeomPoint"
        Me.toolStripMenuItemGeomPoint.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomPoint.Text = "geom_point"
        '
        'toolStripMenuItemGeomRug
        '
        Me.toolStripMenuItemGeomRug.Name = "toolStripMenuItemGeomRug"
        Me.toolStripMenuItemGeomRug.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomRug.Text = "geom_rug"
        '
        'toolStripMenuItemGeomsmooth
        '
        Me.toolStripMenuItemGeomsmooth.Name = "toolStripMenuItemGeomsmooth"
        Me.toolStripMenuItemGeomsmooth.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomsmooth.Text = "geom_smooth"
        '
        'toolStripMenuItemGeomText
        '
        Me.toolStripMenuItemGeomText.Name = "toolStripMenuItemGeomText"
        Me.toolStripMenuItemGeomText.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomText.Text = "geom_text"
        '
        'toolStripMenuItemGeomTextRepel
        '
        Me.toolStripMenuItemGeomTextRepel.Name = "toolStripMenuItemGeomTextRepel"
        Me.toolStripMenuItemGeomTextRepel.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomTextRepel.Text = "geom_text_repel"
        '
        'toolStripMenuItemGeomtile
        '
        Me.toolStripMenuItemGeomtile.Name = "toolStripMenuItemGeomtile"
        Me.toolStripMenuItemGeomtile.Size = New System.Drawing.Size(246, 24)
        Me.toolStripMenuItemGeomtile.Text = "geom_tile"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(20, 54)
        Me.cmdEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(94, 29)
        Me.cmdEdit.TabIndex = 10
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmducrTop
        '
        Me.cmducrTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmducrTop.Image = Global.instat.My.Resources.Resources.arrows_top
        Me.cmducrTop.Location = New System.Drawing.Point(172, 66)
        Me.cmducrTop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmducrTop.Name = "cmducrTop"
        Me.cmducrTop.Size = New System.Drawing.Size(40, 28)
        Me.cmducrTop.TabIndex = 10
        Me.cmducrTop.UseVisualStyleBackColor = True
        '
        'cmdUp
        '
        Me.cmdUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdUp.Image = Global.instat.My.Resources.Resources.arrows_up
        Me.cmdUp.Location = New System.Drawing.Point(172, 101)
        Me.cmdUp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(40, 28)
        Me.cmdUp.TabIndex = 11
        Me.cmdUp.UseVisualStyleBackColor = True
        '
        'cmdDown
        '
        Me.cmdDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdDown.Image = Global.instat.My.Resources.Resources.arrows_down
        Me.cmdDown.Location = New System.Drawing.Point(172, 134)
        Me.cmdDown.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdDown.Name = "cmdDown"
        Me.cmdDown.Size = New System.Drawing.Size(40, 28)
        Me.cmdDown.TabIndex = 12
        Me.cmdDown.UseVisualStyleBackColor = True
        '
        'cmdBottom
        '
        Me.cmdBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdBottom.Image = Global.instat.My.Resources.Resources.arrows_bottom
        Me.cmdBottom.Location = New System.Drawing.Point(172, 164)
        Me.cmdBottom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBottom.Name = "cmdBottom"
        Me.cmdBottom.Size = New System.Drawing.Size(40, 28)
        Me.cmdBottom.TabIndex = 13
        Me.cmdBottom.UseVisualStyleBackColor = True
        '
        'ucrAdditionalLayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.cmdBottom)
        Me.Controls.Add(Me.cmdDown)
        Me.Controls.Add(Me.cmdUp)
        Me.Controls.Add(Me.cmducrTop)
        Me.Controls.Add(Me.grpGeoms)
        Me.Controls.Add(Me.lblLayers)
        Me.Controls.Add(Me.lstLayers)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucrAdditionalLayers"
        Me.Size = New System.Drawing.Size(386, 225)
        Me.grpGeoms.ResumeLayout(False)
        Me.grpGeoms.PerformLayout()
        Me.contextMenuStripAdd.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLayers As Label
    Friend WithEvents lstLayers As ListView
    Friend WithEvents grpGeoms As GroupBox
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdAdd As ucrSplitButton
    Friend WithEvents contextMenuStripAdd As ContextMenuStrip
    Friend WithEvents toolStripMenuItemGeomBar As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomBoxPlot As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomCol As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomCount As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomDensity As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomJitter As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomDensityRidges As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomLabel As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomLabelRepel As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomLine As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomPoint As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomRug As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomText As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomTextRepel As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomcategoricalmodel As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomcontour As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomhistogram As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomparallelslopes As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomsmooth As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomtile As ToolStripMenuItem
    Friend WithEvents cmducrTop As Button
    Friend WithEvents cmdUp As Button
    Friend WithEvents cmdDown As Button
    Friend WithEvents cmdBottom As Button
End Class
