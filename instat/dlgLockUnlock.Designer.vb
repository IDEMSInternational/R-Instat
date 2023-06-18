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
Partial Class dlgLockUnlock
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverLockUnlock = New instat.ucrReceiverMultiple()
        Me.lblSelectedColumns = New System.Windows.Forms.Label()
        Me.rdoLock = New System.Windows.Forms.RadioButton()
        Me.rdoUnlock = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLock = New instat.UcrPanel()
        Me.ucrChkReserveFreeSpace = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 235)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.AutoSize = True
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(9, 39)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(213, 155)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrReceiverLockUnlock
        '
        Me.ucrReceiverLockUnlock.AutoSize = True
        Me.ucrReceiverLockUnlock.frmParent = Me
        Me.ucrReceiverLockUnlock.Location = New System.Drawing.Point(260, 39)
        Me.ucrReceiverLockUnlock.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLockUnlock.Name = "ucrReceiverLockUnlock"
        Me.ucrReceiverLockUnlock.Selector = Nothing
        Me.ucrReceiverLockUnlock.Size = New System.Drawing.Size(121, 134)
        Me.ucrReceiverLockUnlock.strNcFilePath = ""
        Me.ucrReceiverLockUnlock.TabIndex = 2
        Me.ucrReceiverLockUnlock.ucrSelector = Nothing
        '
        'lblSelectedColumns
        '
        Me.lblSelectedColumns.AutoSize = True
        Me.lblSelectedColumns.Location = New System.Drawing.Point(260, 24)
        Me.lblSelectedColumns.Name = "lblSelectedColumns"
        Me.lblSelectedColumns.Size = New System.Drawing.Size(98, 13)
        Me.lblSelectedColumns.TabIndex = 3
        Me.lblSelectedColumns.Tag = "Selected_Variables:"
        Me.lblSelectedColumns.Text = "Selected Variables:"
        '
        'rdoLock
        '
        Me.rdoLock.AutoSize = True
        Me.rdoLock.Location = New System.Drawing.Point(12, 197)
        Me.rdoLock.Name = "rdoLock"
        Me.rdoLock.Size = New System.Drawing.Size(49, 17)
        Me.rdoLock.TabIndex = 4
        Me.rdoLock.TabStop = True
        Me.rdoLock.Tag = "Lock"
        Me.rdoLock.Text = "Lock"
        Me.rdoLock.UseVisualStyleBackColor = True
        '
        'rdoUnlock
        '
        Me.rdoUnlock.AutoSize = True
        Me.rdoUnlock.Location = New System.Drawing.Point(85, 197)
        Me.rdoUnlock.Name = "rdoUnlock"
        Me.rdoUnlock.Size = New System.Drawing.Size(59, 17)
        Me.rdoUnlock.TabIndex = 5
        Me.rdoUnlock.TabStop = True
        Me.rdoUnlock.Tag = "Unlock"
        Me.rdoUnlock.Text = "Unlock"
        Me.rdoUnlock.UseVisualStyleBackColor = True
        '
        'ucrPnlLock
        '
        Me.ucrPnlLock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlLock.Location = New System.Drawing.Point(6, 189)
        Me.ucrPnlLock.Name = "ucrPnlLock"
        Me.ucrPnlLock.Size = New System.Drawing.Size(163, 33)
        Me.ucrPnlLock.TabIndex = 7
        '
        'ucrChkReserveFreeSpace
        '
        Me.ucrChkReserveFreeSpace.AutoSize = True
        Me.ucrChkReserveFreeSpace.Checked = False
        Me.ucrChkReserveFreeSpace.Location = New System.Drawing.Point(188, 197)
        Me.ucrChkReserveFreeSpace.Name = "ucrChkReserveFreeSpace"
        Me.ucrChkReserveFreeSpace.Size = New System.Drawing.Size(204, 23)
        Me.ucrChkReserveFreeSpace.TabIndex = 8
        '
        'dlgLockUnlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(453, 308)
        Me.Controls.Add(Me.ucrChkReserveFreeSpace)
        Me.Controls.Add(Me.rdoUnlock)
        Me.Controls.Add(Me.rdoLock)
        Me.Controls.Add(Me.lblSelectedColumns)
        Me.Controls.Add(Me.ucrReceiverLockUnlock)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlLock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgLockUnlock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Lock_and_unlock"
        Me.Text = "Lock and Unlock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverLockUnlock As ucrReceiverMultiple
    Friend WithEvents lblSelectedColumns As Label
    Friend WithEvents rdoLock As RadioButton
    Friend WithEvents rdoUnlock As RadioButton
    Friend WithEvents ucrPnlLock As UcrPanel
    Friend WithEvents ucrChkReserveFreeSpace As ucrCheck
End Class
