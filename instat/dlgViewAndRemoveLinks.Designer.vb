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
        Me.lblLinks.AutoSize = True
        Me.lblLinks.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLinks.Location = New System.Drawing.Point(12, 15)
        Me.lblLinks.Name = "lblLinks"
        Me.lblLinks.Size = New System.Drawing.Size(35, 13)
        Me.lblLinks.TabIndex = 0
        Me.lblLinks.Text = "Links:"
        '
        'lblSelectedLink
        '
        Me.lblSelectedLink.AutoSize = True
        Me.lblSelectedLink.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedLink.Location = New System.Drawing.Point(254, 28)
        Me.lblSelectedLink.Name = "lblSelectedLink"
        Me.lblSelectedLink.Size = New System.Drawing.Size(75, 13)
        Me.lblSelectedLink.TabIndex = 2
        Me.lblSelectedLink.Text = "Selected Link:"
        '
        'rdoViewLink
        '
        Me.rdoViewLink.AutoSize = True
        Me.rdoViewLink.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoViewLink.Location = New System.Drawing.Point(252, 74)
        Me.rdoViewLink.Name = "rdoViewLink"
        Me.rdoViewLink.Size = New System.Drawing.Size(71, 17)
        Me.rdoViewLink.TabIndex = 5
        Me.rdoViewLink.TabStop = True
        Me.rdoViewLink.Text = "View Link"
        Me.rdoViewLink.UseVisualStyleBackColor = True
        '
        'rdoDeleteLink
        '
        Me.rdoDeleteLink.AutoSize = True
        Me.rdoDeleteLink.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDeleteLink.Location = New System.Drawing.Point(252, 97)
        Me.rdoDeleteLink.Name = "rdoDeleteLink"
        Me.rdoDeleteLink.Size = New System.Drawing.Size(79, 17)
        Me.rdoDeleteLink.TabIndex = 6
        Me.rdoDeleteLink.TabStop = True
        Me.rdoDeleteLink.Text = "Delete Link"
        Me.rdoDeleteLink.UseVisualStyleBackColor = True
        '
        'ucrReceiverViewLinks
        '
        Me.ucrReceiverViewLinks.AutoSize = True
        Me.ucrReceiverViewLinks.frmParent = Me
        Me.ucrReceiverViewLinks.Location = New System.Drawing.Point(252, 43)
        Me.ucrReceiverViewLinks.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverViewLinks.Name = "ucrReceiverViewLinks"
        Me.ucrReceiverViewLinks.Selector = Nothing
        Me.ucrReceiverViewLinks.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverViewLinks.strNcFilePath = ""
        Me.ucrReceiverViewLinks.TabIndex = 3
        Me.ucrReceiverViewLinks.ucrSelector = Nothing
        '
        'ucrPnlLinks
        '
        Me.ucrPnlLinks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlLinks.Location = New System.Drawing.Point(242, 66)
        Me.ucrPnlLinks.Name = "ucrPnlLinks"
        Me.ucrPnlLinks.Size = New System.Drawing.Size(130, 62)
        Me.ucrPnlLinks.TabIndex = 4
        '
        'ucrSelectorLinks
        '
        Me.ucrSelectorLinks.AutoSize = True
        Me.ucrSelectorLinks.bShowHiddenColumns = False
        Me.ucrSelectorLinks.Location = New System.Drawing.Point(10, 30)
        Me.ucrSelectorLinks.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorLinks.Name = "ucrSelectorLinks"
        Me.ucrSelectorLinks.Size = New System.Drawing.Size(136, 117)
        Me.ucrSelectorLinks.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 203)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 7
        '
        'dlgViewAndRemoveLinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(440, 261)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View and Remove Links"
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
