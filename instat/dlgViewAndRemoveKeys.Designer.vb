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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgViewAndRemoveKeys))
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
        resources.ApplyResources(Me.lblSelectedKey, "lblSelectedKey")
        Me.lblSelectedKey.Name = "lblSelectedKey"
        '
        'ucrReceiverSelectedKey
        '
        Me.ucrReceiverSelectedKey.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSelectedKey, "ucrReceiverSelectedKey")
        Me.ucrReceiverSelectedKey.Name = "ucrReceiverSelectedKey"
        Me.ucrReceiverSelectedKey.Selector = Nothing
        Me.ucrReceiverSelectedKey.strNcFilePath = ""
        Me.ucrReceiverSelectedKey.ucrSelector = Nothing
        '
        'ucrSelectorKeys
        '
        Me.ucrSelectorKeys.bShowHiddenColumns = False
        Me.ucrSelectorKeys.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorKeys, "ucrSelectorKeys")
        Me.ucrSelectorKeys.Name = "ucrSelectorKeys"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'rdoDeleteKey
        '
        resources.ApplyResources(Me.rdoDeleteKey, "rdoDeleteKey")
        Me.rdoDeleteKey.Name = "rdoDeleteKey"
        Me.rdoDeleteKey.TabStop = True
        Me.rdoDeleteKey.UseVisualStyleBackColor = True
        '
        'rdoViewKey
        '
        resources.ApplyResources(Me.rdoViewKey, "rdoViewKey")
        Me.rdoViewKey.Name = "rdoViewKey"
        Me.rdoViewKey.TabStop = True
        Me.rdoViewKey.UseVisualStyleBackColor = True
        '
        'ucrPnlKeys
        '
        resources.ApplyResources(Me.ucrPnlKeys, "ucrPnlKeys")
        Me.ucrPnlKeys.Name = "ucrPnlKeys"
        '
        'dlgViewAndRemoveKeys
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
