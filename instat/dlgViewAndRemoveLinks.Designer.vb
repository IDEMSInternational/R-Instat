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
Partial Class dlgViewAndRemoveLinks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgViewAndRemoveLinks))
        Me.lblLinks = New System.Windows.Forms.Label()
        Me.lblSelectedLink = New System.Windows.Forms.Label()
        Me.rdoViewLink = New System.Windows.Forms.RadioButton()
        Me.rdoDeleteLink = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverViewLinks = New instat.ucrReceiverSingle()
        Me.ucrPnlLinks = New instat.UcrPanel()
        Me.ucrSelectorLinks = New instat.ucrSelector()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblLinks
        '
        resources.ApplyResources(Me.lblLinks, "lblLinks")
        Me.lblLinks.Name = "lblLinks"
        '
        'lblSelectedLink
        '
        resources.ApplyResources(Me.lblSelectedLink, "lblSelectedLink")
        Me.lblSelectedLink.Name = "lblSelectedLink"
        '
        'rdoViewLink
        '
        resources.ApplyResources(Me.rdoViewLink, "rdoViewLink")
        Me.rdoViewLink.Name = "rdoViewLink"
        Me.rdoViewLink.TabStop = True
        Me.rdoViewLink.UseVisualStyleBackColor = True
        '
        'rdoDeleteLink
        '
        resources.ApplyResources(Me.rdoDeleteLink, "rdoDeleteLink")
        Me.rdoDeleteLink.Name = "rdoDeleteLink"
        Me.rdoDeleteLink.TabStop = True
        Me.rdoDeleteLink.UseVisualStyleBackColor = True
        '
        'ucrReceiverViewLinks
        '
        Me.ucrReceiverViewLinks.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverViewLinks, "ucrReceiverViewLinks")
        Me.ucrReceiverViewLinks.Name = "ucrReceiverViewLinks"
        Me.ucrReceiverViewLinks.Selector = Nothing
        Me.ucrReceiverViewLinks.strNcFilePath = ""
        Me.ucrReceiverViewLinks.ucrSelector = Nothing
        '
        'ucrPnlLinks
        '
        resources.ApplyResources(Me.ucrPnlLinks, "ucrPnlLinks")
        Me.ucrPnlLinks.Name = "ucrPnlLinks"
        '
        'ucrSelectorLinks
        '
        Me.ucrSelectorLinks.bShowHiddenColumns = False
        resources.ApplyResources(Me.ucrSelectorLinks, "ucrSelectorLinks")
        Me.ucrSelectorLinks.Name = "ucrSelectorLinks"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgViewAndRemoveLinks
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrReceiverViewLinks)
        Me.Controls.Add(Me.rdoDeleteLink)
        Me.Controls.Add(Me.rdoViewLink)
        Me.Controls.Add(Me.ucrPnlLinks)
        Me.Controls.Add(Me.ucrSelectorLinks)
        Me.Controls.Add(Me.lblSelectedLink)
        Me.Controls.Add(Me.lblLinks)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgViewAndRemoveLinks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblLinks As Label
    Friend WithEvents lblSelectedLink As Label
    Friend WithEvents ucrSelectorLinks As ucrSelector
    Friend WithEvents rdoDeleteLink As RadioButton
    Friend WithEvents rdoViewLink As RadioButton
    Friend WithEvents ucrPnlLinks As UcrPanel
    Friend WithEvents ucrReceiverViewLinks As ucrReceiverSingle
End Class
