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
Partial Class ucrDataFrame
    Inherits instat.ucrCore

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
        Me.cboAvailableDataFrames = New System.Windows.Forms.ComboBox()
        Me.lblDataFrame = New System.Windows.Forms.Label()
        Me.mnuRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRightClickCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRightClickSetData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRightClick.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboAvailableDataFrames
        '
        Me.cboAvailableDataFrames.ContextMenuStrip = Me.mnuRightClick
        Me.cboAvailableDataFrames.FormattingEnabled = True
        Me.cboAvailableDataFrames.Location = New System.Drawing.Point(0, 19)
        Me.cboAvailableDataFrames.Name = "cboAvailableDataFrames"
        Me.cboAvailableDataFrames.Size = New System.Drawing.Size(120, 21)
        Me.cboAvailableDataFrames.TabIndex = 0
        '
        'lblDataFrame
        '
        Me.lblDataFrame.Location = New System.Drawing.Point(0, 3)
        Me.lblDataFrame.Name = "lblDataFrame"
        Me.lblDataFrame.Size = New System.Drawing.Size(65, 13)
        Me.lblDataFrame.TabIndex = 1
        Me.lblDataFrame.Tag = "Data_Frame:"
        Me.lblDataFrame.Text = "Data Frame:"
        '
        'mnuRightClick
        '
        Me.mnuRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRightClickCopy, Me.mnuRightClickSetData})
        Me.mnuRightClick.Name = "mnuRightClick"
        Me.mnuRightClick.Size = New System.Drawing.Size(103, 26)
        '
        'mnuRightClickCopy
        '
        Me.mnuRightClickCopy.Name = "mnuRightClickCopy"
        Me.mnuRightClickCopy.Size = New System.Drawing.Size(102, 22)
        Me.mnuRightClickCopy.Text = "Copy"
        '
        'mnuRightClickSetData
        '
        Me.mnuRightClickSetData.Name = "mnuRightClickSetData"
        Me.mnuRightClickSetData.Size = New System.Drawing.Size(102, 22)
        Me.mnuRightClickSetData.Text = "View Data Frame"
        '
        'ucrDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblDataFrame)
        Me.Controls.Add(Me.cboAvailableDataFrames)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ucrDataFrame"
        Me.Size = New System.Drawing.Size(120, 50)
        Me.mnuRightClick.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboAvailableDataFrames As ComboBox
    Friend WithEvents lblDataFrame As Label
    Friend WithEvents mnuRightClick As ContextMenuStrip
    Friend WithEvents mnuRightClickCopy As ToolStripMenuItem
    Friend WithEvents mnuRightClickSetData As ToolStripMenuItem
End Class
