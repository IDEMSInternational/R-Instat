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
Partial Class dlgViewAndRemoveKeys
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lblSelectedKey = New System.Windows.Forms.Label()
        Me.ucrReceiverSelectedKey = New instat.ucrReceiverSingle()
        Me.ucrSelectorKeys = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoDeleteKey = New System.Windows.Forms.RadioButton()
        Me.rdoViewKey = New System.Windows.Forms.RadioButton()
        Me.ucrPnlKeys = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'lblSelectedKey
        '
        Me.lblSelectedKey.AutoSize = True
        Me.lblSelectedKey.Location = New System.Drawing.Point(266, 45)
        Me.lblSelectedKey.Name = "lblSelectedKey"
        Me.lblSelectedKey.Size = New System.Drawing.Size(73, 13)
        Me.lblSelectedKey.TabIndex = 1
        Me.lblSelectedKey.Text = "Selected Key:"
        '
        'ucrReceiverSelectedKey
        '
        Me.ucrReceiverSelectedKey.frmParent = Me
        Me.ucrReceiverSelectedKey.Location = New System.Drawing.Point(266, 60)
        Me.ucrReceiverSelectedKey.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedKey.Name = "ucrReceiverSelectedKey"
        Me.ucrReceiverSelectedKey.Selector = Nothing
        Me.ucrReceiverSelectedKey.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSelectedKey.strNcFilePath = ""
        Me.ucrReceiverSelectedKey.TabIndex = 2
        Me.ucrReceiverSelectedKey.ucrSelector = Nothing
        '
        'ucrSelectorKeys
        '
        Me.ucrSelectorKeys.bShowHiddenColumns = False
        Me.ucrSelectorKeys.bUseCurrentFilter = True
        Me.ucrSelectorKeys.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorKeys.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorKeys.Name = "ucrSelectorKeys"
        Me.ucrSelectorKeys.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorKeys.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 203)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 4
        '
        'rdoDeleteKey
        '
        Me.rdoDeleteKey.AutoSize = True
        Me.rdoDeleteKey.Location = New System.Drawing.Point(266, 125)
        Me.rdoDeleteKey.Name = "rdoDeleteKey"
        Me.rdoDeleteKey.Size = New System.Drawing.Size(77, 17)
        Me.rdoDeleteKey.TabIndex = 9
        Me.rdoDeleteKey.TabStop = True
        Me.rdoDeleteKey.Text = "Delete Key"
        Me.rdoDeleteKey.UseVisualStyleBackColor = True
        '
        'rdoViewKey
        '
        Me.rdoViewKey.AutoSize = True
        Me.rdoViewKey.Location = New System.Drawing.Point(266, 102)
        Me.rdoViewKey.Name = "rdoViewKey"
        Me.rdoViewKey.Size = New System.Drawing.Size(69, 17)
        Me.rdoViewKey.TabIndex = 8
        Me.rdoViewKey.TabStop = True
        Me.rdoViewKey.Text = "View Key"
        Me.rdoViewKey.UseVisualStyleBackColor = True
        '
        'ucrPnlKeys
        '
        Me.ucrPnlKeys.Location = New System.Drawing.Point(266, 94)
        Me.ucrPnlKeys.Name = "ucrPnlKeys"
        Me.ucrPnlKeys.Size = New System.Drawing.Size(130, 62)
        Me.ucrPnlKeys.TabIndex = 7
        '
        'dlgViewAndRemoveKeys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 260)
        Me.Controls.Add(Me.rdoDeleteKey)
        Me.Controls.Add(Me.rdoViewKey)
        Me.Controls.Add(Me.ucrPnlKeys)
        Me.Controls.Add(Me.lblSelectedKey)
        Me.Controls.Add(Me.ucrReceiverSelectedKey)
        Me.Controls.Add(Me.ucrSelectorKeys)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgViewAndRemoveKeys"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View and Remove Keys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorKeys As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSelectedKey As ucrReceiverSingle
    Friend WithEvents lblSelectedKey As Label
    Friend WithEvents rdoDeleteKey As RadioButton
    Friend WithEvents rdoViewKey As RadioButton
    Friend WithEvents ucrPnlKeys As UcrPanel
End Class
