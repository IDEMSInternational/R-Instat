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
        Me.toolStripMenuItemGeomBoxPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomCol = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomCount = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomDensity = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomJitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomPath = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemGeomEncircle = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.toolStripMenuItemGeomDumbbell = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpGeoms.SuspendLayout()
        Me.contextMenuStripAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLayers
        '
        Me.lblLayers.AutoSize = True
        Me.lblLayers.Location = New System.Drawing.Point(6, 20)
        Me.lblLayers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLayers.Name = "lblLayers"
        Me.lblLayers.Size = New System.Drawing.Size(60, 20)
        Me.lblLayers.TabIndex = 5
        Me.lblLayers.Text = "Layers:"
        '
        'lstLayers
        '
        Me.lstLayers.FullRowSelect = True
        Me.lstLayers.HideSelection = False
        Me.lstLayers.Location = New System.Drawing.Point(4, 42)
        Me.lstLayers.Margin = New System.Windows.Forms.Padding(4)
        Me.lstLayers.Name = "lstLayers"
        Me.lstLayers.Size = New System.Drawing.Size(186, 222)
        Me.lstLayers.TabIndex = 4
        Me.lstLayers.UseCompatibleStateImageBehavior = False
        Me.lstLayers.View = System.Windows.Forms.View.List
        '
        'grpGeoms
        '
        Me.grpGeoms.Controls.Add(Me.cmdDelete)
        Me.grpGeoms.Controls.Add(Me.cmdAdd)
        Me.grpGeoms.Controls.Add(Me.cmdEdit)
        Me.grpGeoms.Location = New System.Drawing.Point(201, 80)
        Me.grpGeoms.Margin = New System.Windows.Forms.Padding(4)
        Me.grpGeoms.Name = "grpGeoms"
        Me.grpGeoms.Padding = New System.Windows.Forms.Padding(4)
        Me.grpGeoms.Size = New System.Drawing.Size(159, 150)
        Me.grpGeoms.TabIndex = 9
        Me.grpGeoms.TabStop = False
        Me.grpGeoms.Text = "Geoms:"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(24, 108)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(112, 34)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.AutoSize = True
        Me.cmdAdd.ContextMenuStrip = Me.contextMenuStripAdd
        Me.cmdAdd.Location = New System.Drawing.Point(24, 22)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(112, 34)
        Me.cmdAdd.SplitMenuStrip = Me.contextMenuStripAdd
        Me.cmdAdd.TabIndex = 11
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'contextMenuStripAdd
        '
        Me.contextMenuStripAdd.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.contextMenuStripAdd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemGeomBoxPlot, Me.toolStripMenuItemGeomBar, Me.toolStripMenuItemGeomCol, Me.toolStripMenuItemGeomCount, Me.toolStripMenuItemGeomDensity, Me.toolStripMenuItemGeomJitter, Me.toolStripMenuItemGeomPath, Me.toolStripMenuItemGeomEncircle, Me.toolStripMenuItemGeomDumbbell})
        Me.contextMenuStripAdd.Name = "contextMenuStripOk"
        Me.contextMenuStripAdd.Size = New System.Drawing.Size(241, 325)
        '
        'toolStripMenuItemGeomBoxPlot
        '
        Me.toolStripMenuItemGeomBoxPlot.Name = "toolStripMenuItemGeomBoxPlot"
        Me.toolStripMenuItemGeomBoxPlot.Size = New System.Drawing.Size(240, 32)
        Me.toolStripMenuItemGeomBoxPlot.Text = "geom_boxplot"
        '
        'toolStripMenuItemGeomBar
        '
        Me.toolStripMenuItemGeomBar.Name = "toolStripMenuItemGeomBar"
        Me.toolStripMenuItemGeomBar.Size = New System.Drawing.Size(240, 32)
        Me.toolStripMenuItemGeomBar.Text = "geom_bar"
        '
        'toolStripMenuItemGeomCol
        '
        Me.toolStripMenuItemGeomCol.Name = "toolStripMenuItemGeomCol"
        Me.toolStripMenuItemGeomCol.Size = New System.Drawing.Size(240, 32)
        Me.toolStripMenuItemGeomCol.Text = "geom_col"
        '
        'toolStripMenuItemGeomCount
        '
        Me.toolStripMenuItemGeomCount.Name = "toolStripMenuItemGeomCount"
        Me.toolStripMenuItemGeomCount.Size = New System.Drawing.Size(240, 32)
        Me.toolStripMenuItemGeomCount.Text = "geom_count"
        '
        'toolStripMenuItemGeomDensity
        '
        Me.toolStripMenuItemGeomDensity.Name = "toolStripMenuItemGeomDensity"
        Me.toolStripMenuItemGeomDensity.Size = New System.Drawing.Size(240, 32)
        Me.toolStripMenuItemGeomDensity.Text = "geom_density"
        '
        'toolStripMenuItemGeomJitter
        '
        Me.toolStripMenuItemGeomJitter.Name = "toolStripMenuItemGeomJitter"
        Me.toolStripMenuItemGeomJitter.Size = New System.Drawing.Size(240, 32)
        Me.toolStripMenuItemGeomJitter.Text = "geom_jitter"
        '
        'toolStripMenuItemGeomPath
        '
        Me.toolStripMenuItemGeomPath.Name = "toolStripMenuItemGeomPath"
        Me.toolStripMenuItemGeomPath.Size = New System.Drawing.Size(240, 32)
        Me.toolStripMenuItemGeomPath.Text = "geom_path"
        '
        'toolStripMenuItemGeomEncircle
        '
        Me.toolStripMenuItemGeomEncircle.Name = "toolStripMenuItemGeomEncircle"
        Me.toolStripMenuItemGeomEncircle.Size = New System.Drawing.Size(240, 32)
        Me.toolStripMenuItemGeomEncircle.Text = "geom_encircle"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(24, 64)
        Me.cmdEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(112, 34)
        Me.cmdEdit.TabIndex = 10
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'toolStripMenuItemGeomDumbbell
        '
        Me.toolStripMenuItemGeomDumbbell.Name = "toolStripMenuItemGeomDumbbell"
        Me.toolStripMenuItemGeomDumbbell.Size = New System.Drawing.Size(240, 32)
        Me.toolStripMenuItemGeomDumbbell.Text = "geom_dumbbell"
        '
        'ucrAdditionalLayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.grpGeoms)
        Me.Controls.Add(Me.lblLayers)
        Me.Controls.Add(Me.lstLayers)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucrAdditionalLayers"
        Me.Size = New System.Drawing.Size(374, 270)
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
    Friend WithEvents toolStripMenuItemGeomPath As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomEncircle As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemGeomDumbbell As ToolStripMenuItem
End Class
