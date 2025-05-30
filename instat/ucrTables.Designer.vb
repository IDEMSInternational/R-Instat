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
Partial Class ucrTables
    Inherits instat.ucrCore

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
        Me.cboAvailableTables = New System.Windows.Forms.ComboBox()
        Me.mnuRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRightClickCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRightClickSetData = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.ucrDataFrame = New instat.ucrDataFrame()
        Me.mnuRightClick.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboAvailableTables
        '
        Me.cboAvailableTables.ContextMenuStrip = Me.mnuRightClick
        Me.cboAvailableTables.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAvailableTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAvailableTables.FormattingEnabled = True
        Me.cboAvailableTables.Location = New System.Drawing.Point(0, 106)
        Me.cboAvailableTables.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAvailableTables.Name = "cboAvailableTables"
        Me.cboAvailableTables.Size = New System.Drawing.Size(220, 21)
        Me.cboAvailableTables.TabIndex = 0
        '
        'mnuRightClick
        '
        Me.mnuRightClick.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRightClickCopy, Me.mnuRightClickSetData})
        Me.mnuRightClick.Name = "mnuRightClick"
        Me.mnuRightClick.Size = New System.Drawing.Size(218, 68)
        '
        'mnuRightClickCopy
        '
        Me.mnuRightClickCopy.Name = "mnuRightClickCopy"
        Me.mnuRightClickCopy.Size = New System.Drawing.Size(217, 32)
        Me.mnuRightClickCopy.Text = "Copy"
        '
        'mnuRightClickSetData
        '
        Me.mnuRightClickSetData.Name = "mnuRightClickSetData"
        Me.mnuRightClickSetData.Size = New System.Drawing.Size(217, 32)
        Me.mnuRightClickSetData.Text = "View Data Frame"
        '
        'lblTable
        '
        Me.lblTable.Location = New System.Drawing.Point(0, 82)
        Me.lblTable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(98, 20)
        Me.lblTable.TabIndex = 1
        Me.lblTable.Tag = "Table:"
        Me.lblTable.Text = "Table:"
        '
        'ucrDataFrame
        '
        Me.ucrDataFrame.AutoSize = True
        Me.ucrDataFrame.bDropUnusedFilterLevels = False
        Me.ucrDataFrame.bUseCurrentFilter = True
        Me.ucrDataFrame.Location = New System.Drawing.Point(0, 3)
        Me.ucrDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrame.Name = "ucrDataFrame"
        Me.ucrDataFrame.Size = New System.Drawing.Size(224, 53)
        Me.ucrDataFrame.TabIndex = 2
        '
        'ucrTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ucrDataFrame)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.cboAvailableTables)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ucrTables"
        Me.Size = New System.Drawing.Size(226, 140)
        Me.mnuRightClick.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboAvailableTables As ComboBox
    Friend WithEvents lblTable As Label
    Friend WithEvents mnuRightClick As ContextMenuStrip
    Friend WithEvents mnuRightClickCopy As ToolStripMenuItem
    Friend WithEvents mnuRightClickSetData As ToolStripMenuItem
    Friend WithEvents ucrDataFrame As ucrDataFrame
End Class
