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
        Me.btnAdd = New instat.ucrSplitButton()
        Me.contextMenuStripAdd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripAddSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripAddAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DensityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DensityridgesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LlabelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelrepelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PointToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RugSmoothToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextrepelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
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
        Me.grpGeoms.Controls.Add(Me.btnAdd)
        Me.grpGeoms.Controls.Add(Me.cmdDelete)
        Me.grpGeoms.Controls.Add(Me.cmdEdit)
        Me.grpGeoms.Location = New System.Drawing.Point(134, 53)
        Me.grpGeoms.Name = "grpGeoms"
        Me.grpGeoms.Size = New System.Drawing.Size(106, 100)
        Me.grpGeoms.TabIndex = 9
        Me.grpGeoms.TabStop = False
        Me.grpGeoms.Text = "Geoms:"
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.ContextMenuStrip = Me.contextMenuStripAdd
        Me.btnAdd.Location = New System.Drawing.Point(16, 15)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.SplitMenuStrip = Me.contextMenuStripAdd
        Me.btnAdd.TabIndex = 87
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'contextMenuStripAdd
        '
        Me.contextMenuStripAdd.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.contextMenuStripAdd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripAddSelected, Me.toolStripAddAll, Me.toolStripHelp, Me.CountToolStripMenuItem, Me.DensityToolStripMenuItem, Me.DensityridgesToolStripMenuItem, Me.JitterToolStripMenuItem, Me.LlabelToolStripMenuItem, Me.LabelrepelToolStripMenuItem, Me.LineToolStripMenuItem, Me.PointToolStripMenuItem, Me.RugSmoothToolStripMenuItem, Me.TextToolStripMenuItem, Me.TextrepelToolStripMenuItem})
        Me.contextMenuStripAdd.Name = "SelectionMenuStrip"
        Me.contextMenuStripAdd.Size = New System.Drawing.Size(186, 334)
        '
        'toolStripAddSelected
        '
        Me.toolStripAddSelected.Name = "toolStripAddSelected"
        Me.toolStripAddSelected.Size = New System.Drawing.Size(185, 22)
        Me.toolStripAddSelected.Tag = "Add_selected"
        Me.toolStripAddSelected.Text = " geom_bar"
        '
        'toolStripAddAll
        '
        Me.toolStripAddAll.Name = "toolStripAddAll"
        Me.toolStripAddAll.Size = New System.Drawing.Size(185, 22)
        Me.toolStripAddAll.Text = "geom_boxplot"
        '
        'toolStripHelp
        '
        Me.toolStripHelp.Name = "toolStripHelp"
        Me.toolStripHelp.Size = New System.Drawing.Size(185, 22)
        Me.toolStripHelp.Text = "geom_col"
        '
        'CountToolStripMenuItem
        '
        Me.CountToolStripMenuItem.Name = "CountToolStripMenuItem"
        Me.CountToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CountToolStripMenuItem.Text = "geom_count"
        '
        'DensityToolStripMenuItem
        '
        Me.DensityToolStripMenuItem.Name = "DensityToolStripMenuItem"
        Me.DensityToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.DensityToolStripMenuItem.Text = "geom_density"
        '
        'DensityridgesToolStripMenuItem
        '
        Me.DensityridgesToolStripMenuItem.Name = "DensityridgesToolStripMenuItem"
        Me.DensityridgesToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.DensityridgesToolStripMenuItem.Text = "geom_density-ridges"
        '
        'JitterToolStripMenuItem
        '
        Me.JitterToolStripMenuItem.Name = "JitterToolStripMenuItem"
        Me.JitterToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.JitterToolStripMenuItem.Text = "geom_ jitter"
        '
        'LlabelToolStripMenuItem
        '
        Me.LlabelToolStripMenuItem.Name = "LlabelToolStripMenuItem"
        Me.LlabelToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.LlabelToolStripMenuItem.Text = "geom_label"
        '
        'LabelrepelToolStripMenuItem
        '
        Me.LabelrepelToolStripMenuItem.Name = "LabelrepelToolStripMenuItem"
        Me.LabelrepelToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.LabelrepelToolStripMenuItem.Text = "geom_label_repel"
        '
        'LineToolStripMenuItem
        '
        Me.LineToolStripMenuItem.Name = "LineToolStripMenuItem"
        Me.LineToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.LineToolStripMenuItem.Text = "geom_line"
        '
        'PointToolStripMenuItem
        '
        Me.PointToolStripMenuItem.Name = "PointToolStripMenuItem"
        Me.PointToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.PointToolStripMenuItem.Text = " geom_point"
        '
        'RugSmoothToolStripMenuItem
        '
        Me.RugSmoothToolStripMenuItem.Name = "RugSmoothToolStripMenuItem"
        Me.RugSmoothToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.RugSmoothToolStripMenuItem.Text = "geom_rug smooth"
        '
        'TextToolStripMenuItem
        '
        Me.TextToolStripMenuItem.Name = "TextToolStripMenuItem"
        Me.TextToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.TextToolStripMenuItem.Text = " geom_text"
        '
        'TextrepelToolStripMenuItem
        '
        Me.TextrepelToolStripMenuItem.Name = "TextrepelToolStripMenuItem"
        Me.TextrepelToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.TextrepelToolStripMenuItem.Text = "geom_text_repel"
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
    Friend WithEvents toolStripAddSelected As ToolStripMenuItem
    Friend WithEvents toolStripAddAll As ToolStripMenuItem
    Friend WithEvents toolStripHelp As ToolStripMenuItem
    Friend WithEvents btnAdd As ucrSplitButton
    Friend WithEvents CountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DensityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DensityridgesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LlabelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelrepelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PointToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RugSmoothToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextrepelToolStripMenuItem As ToolStripMenuItem
End Class
