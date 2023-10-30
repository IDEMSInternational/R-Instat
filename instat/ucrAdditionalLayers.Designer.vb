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
        Me.components = New System.ComponentModel.Container()
        Me.lblLayers = New System.Windows.Forms.Label()
        Me.lstLayers = New System.Windows.Forms.ListView()
        Me.grpGeoms = New System.Windows.Forms.GroupBox()
        Me.cmdAdd = New instat.ucrSplitButton()
        Me.contextMenuStripAdd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripmenuItemGeomBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomBoxplot = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomCol = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomCount = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomcontour = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemDensity = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemDensityridges = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomdotplot = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemGeomhistogram = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemJitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemLabel = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemLabelrepel = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemLine = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeommosaic = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomparallelslopes = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemPoint = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemRugSmooth = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomSmooth = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemText = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemTextrepel = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomtile = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomviolin = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.toolStripMenuItemGeomcategoricalmodel = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpGeoms.SuspendLayout()
        Me.contextMenuStripAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLayers
        '
        Me.lblLayers.AutoSize = True
        Me.lblLayers.Location = New System.Drawing.Point(4, 13)
        Me.lblLayers.Name = "lblLayers"
        Me.lblLayers.Size = New System.Drawing.Size(41, 13)
        Me.lblLayers.TabIndex = 5
        Me.lblLayers.Text = "Layers:"
        '
        'lstLayers
        '
        Me.lstLayers.FullRowSelect = True
        Me.lstLayers.HideSelection = False
        Me.lstLayers.Location = New System.Drawing.Point(3, 28)
        Me.lstLayers.Name = "lstLayers"
        Me.lstLayers.Size = New System.Drawing.Size(125, 149)
        Me.lstLayers.TabIndex = 4
        Me.lstLayers.UseCompatibleStateImageBehavior = False
        Me.lstLayers.View = System.Windows.Forms.View.List
        '
        'grpGeoms
        '
        Me.grpGeoms.Controls.Add(Me.cmdAdd)
        Me.grpGeoms.Controls.Add(Me.cmdDelete)
        Me.grpGeoms.Controls.Add(Me.cmdEdit)
        Me.grpGeoms.Location = New System.Drawing.Point(134, 53)
        Me.grpGeoms.Name = "grpGeoms"
        Me.grpGeoms.Size = New System.Drawing.Size(106, 100)
        Me.grpGeoms.TabIndex = 9
        Me.grpGeoms.TabStop = False
        Me.grpGeoms.Text = "Geoms:"
        '
        'cmdAdd
        '
        Me.cmdAdd.AutoSize = True
        Me.cmdAdd.ContextMenuStrip = Me.contextMenuStripAdd
        Me.cmdAdd.Location = New System.Drawing.Point(19, 15)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(68, 23)
        Me.cmdAdd.SplitMenuStrip = Me.contextMenuStripAdd
        Me.cmdAdd.TabIndex = 214
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'contextMenuStripAdd
        '
        Me.contextMenuStripAdd.AutoSize = False
        Me.contextMenuStripAdd.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.contextMenuStripAdd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripmenuItemGeomBar, Me.toolStripMenuItemGeomBoxplot, Me.toolStripMenuItemGeomcategoricalmodel, Me.toolStripMenuItemGeomCol, Me.toolStripMenuItemGeomCount, Me.toolStripMenuItemGeomcontour, Me.toolStripMenuItemDensity, Me.toolStripMenuItemDensityridges, Me.toolStripMenuItemGeomdotplot, Me.ToolStripMenuItemGeomhistogram, Me.toolStripMenuItemJitter, Me.toolStripMenuItemLabel, Me.toolStripMenuItemLabelrepel, Me.toolStripMenuItemLine, Me.toolStripMenuItemGeommosaic, Me.toolStripMenuItemGeomparallelslopes, Me.toolStripMenuItemPoint, Me.toolStripMenuItemRugSmooth, Me.toolStripMenuItemGeomSmooth, Me.toolStripMenuItemText, Me.toolStripMenuItemTextrepel, Me.toolStripMenuItemGeomtile, Me.toolStripMenuItemGeomviolin})
        Me.contextMenuStripAdd.Name = "SelectionMenuStrip"
        Me.contextMenuStripAdd.Size = New System.Drawing.Size(187, 447)
        '
        'toolStripmenuItemGeomBar
        '
        Me.toolStripmenuItemGeomBar.AutoSize = False
        Me.toolStripmenuItemGeomBar.Name = "toolStripmenuItemGeomBar"
        Me.toolStripmenuItemGeomBar.Size = New System.Drawing.Size(186, 18)
        Me.toolStripmenuItemGeomBar.Tag = "Add_selected"
        Me.toolStripmenuItemGeomBar.Text = "geom_bar"
        '
        'toolStripMenuItemGeomBoxplot
        '
        Me.toolStripMenuItemGeomBoxplot.AutoSize = False
        Me.toolStripMenuItemGeomBoxplot.Name = "toolStripMenuItemGeomBoxplot"
        Me.toolStripMenuItemGeomBoxplot.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemGeomBoxplot.Text = "geom_boxplot"
        '
        'toolStripMenuItemGeomCol
        '
        Me.toolStripMenuItemGeomCol.AutoSize = False
        Me.toolStripMenuItemGeomCol.Name = "toolStripMenuItemGeomCol"
        Me.toolStripMenuItemGeomCol.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemGeomCol.Text = "geom_col"
        '
        'toolStripMenuItemGeomCount
        '
        Me.toolStripMenuItemGeomCount.AutoSize = False
        Me.toolStripMenuItemGeomCount.Name = "toolStripMenuItemGeomCount"
        Me.toolStripMenuItemGeomCount.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemGeomCount.Text = "geom_count"
        '
        'toolStripMenuItemGeomcontour
        '
        Me.toolStripMenuItemGeomcontour.AutoSize = False
        Me.toolStripMenuItemGeomcontour.Name = "toolStripMenuItemGeomcontour"
        Me.toolStripMenuItemGeomcontour.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemGeomcontour.Text = "geom_contour"
        '
        'toolStripMenuItemDensity
        '
        Me.toolStripMenuItemDensity.AutoSize = False
        Me.toolStripMenuItemDensity.Name = "toolStripMenuItemDensity"
        Me.toolStripMenuItemDensity.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemDensity.Text = "geom_density"
        '
        'toolStripMenuItemDensityridges
        '
        Me.toolStripMenuItemDensityridges.AutoSize = False
        Me.toolStripMenuItemDensityridges.Name = "toolStripMenuItemDensityridges"
        Me.toolStripMenuItemDensityridges.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemDensityridges.Text = "geom_density-ridges"
        '
        'toolStripMenuItemGeomdotplot
        '
        Me.toolStripMenuItemGeomdotplot.AutoSize = False
        Me.toolStripMenuItemGeomdotplot.Name = "toolStripMenuItemGeomdotplot"
        Me.toolStripMenuItemGeomdotplot.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemGeomdotplot.Text = "geom_dotplot"
        '
        'ToolStripMenuItemGeomhistogram
        '
        Me.ToolStripMenuItemGeomhistogram.AutoSize = False
        Me.ToolStripMenuItemGeomhistogram.Name = "ToolStripMenuItemGeomhistogram"
        Me.ToolStripMenuItemGeomhistogram.Size = New System.Drawing.Size(186, 18)
        Me.ToolStripMenuItemGeomhistogram.Text = "geom_histogram"
        '
        'toolStripMenuItemJitter
        '
        Me.toolStripMenuItemJitter.AutoSize = False
        Me.toolStripMenuItemJitter.Name = "toolStripMenuItemJitter"
        Me.toolStripMenuItemJitter.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemJitter.Text = "geom_ jitter"
        '
        'toolStripMenuItemLabel
        '
        Me.toolStripMenuItemLabel.AutoSize = False
        Me.toolStripMenuItemLabel.Name = "toolStripMenuItemLabel"
        Me.toolStripMenuItemLabel.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemLabel.Text = "geom_label"
        '
        'toolStripMenuItemLabelrepel
        '
        Me.toolStripMenuItemLabelrepel.AutoSize = False
        Me.toolStripMenuItemLabelrepel.Name = "toolStripMenuItemLabelrepel"
        Me.toolStripMenuItemLabelrepel.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemLabelrepel.Text = "geom_label_repel"
        '
        'toolStripMenuItemLine
        '
        Me.toolStripMenuItemLine.AutoSize = False
        Me.toolStripMenuItemLine.Name = "toolStripMenuItemLine"
        Me.toolStripMenuItemLine.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemLine.Text = "geom_line"
        '
        'toolStripMenuItemGeommosaic
        '
        Me.toolStripMenuItemGeommosaic.AutoSize = False
        Me.toolStripMenuItemGeommosaic.Name = "toolStripMenuItemGeommosaic"
        Me.toolStripMenuItemGeommosaic.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemGeommosaic.Text = "geom_mosaic"
        '
        'toolStripMenuItemGeomparallelslopes
        '
        Me.toolStripMenuItemGeomparallelslopes.AutoSize = False
        Me.toolStripMenuItemGeomparallelslopes.Name = "toolStripMenuItemGeomparallelslopes"
        Me.toolStripMenuItemGeomparallelslopes.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemGeomparallelslopes.Text = "geom_parallel_slopes"
        '
        'toolStripMenuItemPoint
        '
        Me.toolStripMenuItemPoint.AutoSize = False
        Me.toolStripMenuItemPoint.Name = "toolStripMenuItemPoint"
        Me.toolStripMenuItemPoint.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemPoint.Text = "geom_point"
        '
        'toolStripMenuItemRugSmooth
        '
        Me.toolStripMenuItemRugSmooth.AutoSize = False
        Me.toolStripMenuItemRugSmooth.Name = "toolStripMenuItemRugSmooth"
        Me.toolStripMenuItemRugSmooth.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemRugSmooth.Text = "geom_rug"
        '
        'toolStripMenuItemGeomSmooth
        '
        Me.toolStripMenuItemGeomSmooth.AutoSize = False
        Me.toolStripMenuItemGeomSmooth.Name = "toolStripMenuItemGeomSmooth"
        Me.toolStripMenuItemGeomSmooth.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemGeomSmooth.Text = "geom_ smooth"
        '
        'toolStripMenuItemText
        '
        Me.toolStripMenuItemText.AutoSize = False
        Me.toolStripMenuItemText.Name = "toolStripMenuItemText"
        Me.toolStripMenuItemText.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemText.Text = "geom_text"
        '
        'toolStripMenuItemTextrepel
        '
        Me.toolStripMenuItemTextrepel.AutoSize = False
        Me.toolStripMenuItemTextrepel.Name = "toolStripMenuItemTextrepel"
        Me.toolStripMenuItemTextrepel.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemTextrepel.Text = "geom_text_repel"
        '
        'toolStripMenuItemGeomtile
        '
        Me.toolStripMenuItemGeomtile.AutoSize = False
        Me.toolStripMenuItemGeomtile.Name = "toolStripMenuItemGeomtile"
        Me.toolStripMenuItemGeomtile.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemGeomtile.Text = "geom_tile"
        '
        'toolStripMenuItemGeomviolin
        '
        Me.toolStripMenuItemGeomviolin.AutoSize = False
        Me.toolStripMenuItemGeomviolin.Name = "toolStripMenuItemGeomviolin"
        Me.toolStripMenuItemGeomviolin.Size = New System.Drawing.Size(186, 18)
        Me.toolStripMenuItemGeomviolin.Text = "geom_violin"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(16, 72)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(16, 43)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 10
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'toolStripMenuItemGeomcategoricalmodel
        '
        Me.toolStripMenuItemGeomcategoricalmodel.AutoSize = False
        Me.toolStripMenuItemGeomcategoricalmodel.Name = "toolStripMenuItemGeomcategoricalmodel"
        Me.toolStripMenuItemGeomcategoricalmodel.Size = New System.Drawing.Size(207, 18)
        Me.toolStripMenuItemGeomcategoricalmodel.Text = "geom_categorical_model"
        '
        'ucrAdditionalLayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.grpGeoms)
        Me.Controls.Add(Me.lblLayers)
        Me.Controls.Add(Me.lstLayers)
        Me.Name = "ucrAdditionalLayers"
        Me.Size = New System.Drawing.Size(249, 180)
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
    Friend WithEvents contextMenuStripAdd As ContextMenuStrip
    Friend WithEvents toolStripmenuItemGeomBar As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomBoxplot As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomCol As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomCount As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemDensity As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemDensityridges As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemJitter As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemLabel As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemLabelrepel As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemLine As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemPoint As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemRugSmooth As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemText As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemTextrepel As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomcontour As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomdotplot As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemGeomhistogram As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeommosaic As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomparallelslopes As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomSmooth As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomtile As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomviolin As ToolStripMenuItem
    Friend WithEvents cmdAdd As ucrSplitButton
    Friend WithEvents toolStripMenuItemGeomcategoricalmodel As ToolStripMenuItem
End Class
