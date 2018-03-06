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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrDataFrame))
        Me.cboAvailableDataFrames = New System.Windows.Forms.ComboBox()
        Me.mnuRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRightClickCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRightClickSetData = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDataFrame = New System.Windows.Forms.Label()
        Me.mnuRightClick.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboAvailableDataFrames
        '
        Me.cboAvailableDataFrames.ContextMenuStrip = Me.mnuRightClick
        Me.cboAvailableDataFrames.FormattingEnabled = True
        resources.ApplyResources(Me.cboAvailableDataFrames, "cboAvailableDataFrames")
        Me.cboAvailableDataFrames.Name = "cboAvailableDataFrames"
        '
        'mnuRightClick
        '
        Me.mnuRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRightClickCopy, Me.mnuRightClickSetData})
        Me.mnuRightClick.Name = "mnuRightClick"
        resources.ApplyResources(Me.mnuRightClick, "mnuRightClick")
        '
        'mnuRightClickCopy
        '
        Me.mnuRightClickCopy.Name = "mnuRightClickCopy"
        resources.ApplyResources(Me.mnuRightClickCopy, "mnuRightClickCopy")
        '
        'mnuRightClickSetData
        '
        Me.mnuRightClickSetData.Name = "mnuRightClickSetData"
        resources.ApplyResources(Me.mnuRightClickSetData, "mnuRightClickSetData")
        '
        'lblDataFrame
        '
        resources.ApplyResources(Me.lblDataFrame, "lblDataFrame")
        Me.lblDataFrame.Name = "lblDataFrame"
        Me.lblDataFrame.Tag = "Data_Frame:"
        '
        'ucrDataFrame
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblDataFrame)
        Me.Controls.Add(Me.cboAvailableDataFrames)
        Me.Name = "ucrDataFrame"
        Me.mnuRightClick.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboAvailableDataFrames As ComboBox
    Friend WithEvents lblDataFrame As Label
    Friend WithEvents mnuRightClick As ContextMenuStrip
    Friend WithEvents mnuRightClickCopy As ToolStripMenuItem
    Friend WithEvents mnuRightClickSetData As ToolStripMenuItem
End Class
