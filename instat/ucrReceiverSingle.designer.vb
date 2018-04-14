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
Partial Class ucrReceiverSingle
    Inherits instat.ucrReceiver

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrReceiverSingle))
        Me.txtReceiverSingle = New System.Windows.Forms.TextBox()
        Me.mnuRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRightClickRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRightClickCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRightClick.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtReceiverSingle
        '
        Me.txtReceiverSingle.ContextMenuStrip = Me.mnuRightClick
        resources.ApplyResources(Me.txtReceiverSingle, "txtReceiverSingle")
        Me.txtReceiverSingle.Name = "txtReceiverSingle"
        Me.txtReceiverSingle.ReadOnly = True
        '
        'mnuRightClick
        '
        Me.mnuRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRightClickRemove, Me.mnuRightClickCopy})
        Me.mnuRightClick.Name = "SelectionMenuStrip"
        resources.ApplyResources(Me.mnuRightClick, "mnuRightClick")
        '
        'mnuRightClickRemove
        '
        Me.mnuRightClickRemove.Name = "mnuRightClickRemove"
        resources.ApplyResources(Me.mnuRightClickRemove, "mnuRightClickRemove")
        Me.mnuRightClickRemove.Tag = "remove"
        '
        'mnuRightClickCopy
        '
        Me.mnuRightClickCopy.Name = "mnuRightClickCopy"
        resources.ApplyResources(Me.mnuRightClickCopy, "mnuRightClickCopy")
        '
        'ucrReceiverSingle
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.txtReceiverSingle)
        Me.Name = "ucrReceiverSingle"
        Me.mnuRightClick.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtReceiverSingle As TextBox
    Friend WithEvents mnuRightClick As ContextMenuStrip
    Friend WithEvents mnuRightClickRemove As ToolStripMenuItem
    Friend WithEvents mnuRightClickCopy As ToolStripMenuItem
End Class
