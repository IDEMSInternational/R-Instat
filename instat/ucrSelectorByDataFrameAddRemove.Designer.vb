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
Partial Class ucrSelectorByDataFrameAddRemove
    Inherits instat.ucrSelectorByDataFrame

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
        Me.btnDataOptions = New System.Windows.Forms.Button()
        Me.btnAdd = New instat.ucrSplitButton()
        Me.contextMenuStripAdd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripAddSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripAddAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparatorContext = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.checkBoxScalar = New System.Windows.Forms.CheckBox()
        Me.contextMenuStripAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrAvailableDataFrames
        '
        Me.ucrAvailableDataFrames.TabIndex = 0
        '
        'lstAvailableVariable
        '
        Me.lstAvailableVariable.TabIndex = 2
        '
        'btnDataOptions
        '
        Me.btnDataOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.btnDataOptions.Location = New System.Drawing.Point(226, 219)
        Me.btnDataOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDataOptions.Name = "btnDataOptions"
        Me.btnDataOptions.Size = New System.Drawing.Size(86, 51)
        Me.btnDataOptions.TabIndex = 4
        Me.btnDataOptions.Tag = "Data_Options"
        Me.btnDataOptions.Text = "Data Options"
        Me.btnDataOptions.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.ContextMenuStrip = Me.contextMenuStripAdd
        Me.btnAdd.Location = New System.Drawing.Point(226, 68)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 51)
        Me.btnAdd.SplitMenuStrip = Me.contextMenuStripAdd
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'contextMenuStripAdd
        '
        Me.contextMenuStripAdd.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.contextMenuStripAdd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripAddSelected, Me.toolStripAddAll, Me.ToolStripSeparatorContext, Me.toolStripHelp})
        Me.contextMenuStripAdd.Name = "SelectionMenuStrip"
        Me.contextMenuStripAdd.Size = New System.Drawing.Size(190, 106)
        '
        'toolStripAddSelected
        '
        Me.toolStripAddSelected.Name = "toolStripAddSelected"
        Me.toolStripAddSelected.Size = New System.Drawing.Size(189, 32)
        Me.toolStripAddSelected.Tag = "Add_selected"
        Me.toolStripAddSelected.Text = "Add Selected"
        '
        'toolStripAddAll
        '
        Me.toolStripAddAll.Name = "toolStripAddAll"
        Me.toolStripAddAll.Size = New System.Drawing.Size(189, 32)
        Me.toolStripAddAll.Text = "Add All"
        '
        'ToolStripSeparatorContext
        '
        Me.ToolStripSeparatorContext.Name = "ToolStripSeparatorContext"
        Me.ToolStripSeparatorContext.Size = New System.Drawing.Size(186, 6)
        '
        'toolStripHelp
        '
        Me.toolStripHelp.Name = "toolStripHelp"
        Me.toolStripHelp.Size = New System.Drawing.Size(189, 32)
        Me.toolStripHelp.Text = "Help"
        '
        'checkBoxScalar
        '
        Me.checkBoxScalar.AutoSize = True
        Me.checkBoxScalar.Location = New System.Drawing.Point(226, 153)
        Me.checkBoxScalar.Name = "checkBoxScalar"
        Me.checkBoxScalar.Size = New System.Drawing.Size(63, 21)
        Me.checkBoxScalar.TabIndex = 86
        Me.checkBoxScalar.Text = "Scalar"
        Me.checkBoxScalar.UseVisualStyleBackColor = True
        Me.checkBoxScalar.Visible = False
        '
        'ucrSelectorByDataFrameAddRemove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.checkBoxScalar)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDataOptions)
        Me.Name = "ucrSelectorByDataFrameAddRemove"
        Me.Size = New System.Drawing.Size(405, 402)
        Me.Controls.SetChildIndex(Me.btnDataOptions, 0)
        Me.Controls.SetChildIndex(Me.btnAdd, 0)
        Me.Controls.SetChildIndex(Me.ucrAvailableDataFrames, 0)
        Me.Controls.SetChildIndex(Me.lstAvailableVariable, 0)
        Me.Controls.SetChildIndex(Me.checkBoxScalar, 0)
        Me.contextMenuStripAdd.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDataOptions As Button
    Friend WithEvents btnAdd As ucrSplitButton
    Friend WithEvents contextMenuStripAdd As ContextMenuStrip
    Friend WithEvents toolStripAddSelected As ToolStripMenuItem
    Friend WithEvents toolStripAddAll As ToolStripMenuItem
    Friend WithEvents ToolStripSeparatorContext As ToolStripSeparator
    Friend WithEvents toolStripHelp As ToolStripMenuItem
    Friend WithEvents checkBoxScalar As CheckBox
End Class
