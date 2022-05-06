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
Partial Class ucrButtons
    Inherits System.Windows.Forms.UserControl

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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.chkComment = New System.Windows.Forms.CheckBox()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.cmdLanguage = New System.Windows.Forms.Button()
        Me.cmdOk = New instat.ucrSplitButton()
        Me.contextMenuStripOk = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItemOkClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPaste = New instat.ucrSplitButton()
        Me.contextMenuStripToScript = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItemToScriptClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemToScriptKeep = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemOkKeep = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextMenuStripOk.SuspendLayout()
        Me.contextMenuStripToScript.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(158, 26)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Tag = "Close"
        Me.cmdCancel.Text = "Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(79, 26)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 3
        Me.cmdReset.Tag = "Reset"
        Me.cmdReset.Text = "Reset "
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHelp.Location = New System.Drawing.Point(237, 26)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(84, 23)
        Me.cmdHelp.TabIndex = 5
        Me.cmdHelp.Tag = "Help"
        Me.cmdHelp.Text = "Help "
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'chkComment
        '
        Me.chkComment.AutoSize = True
        Me.chkComment.Location = New System.Drawing.Point(0, 3)
        Me.chkComment.Name = "chkComment"
        Me.chkComment.Size = New System.Drawing.Size(73, 17)
        Me.chkComment.TabIndex = 0
        Me.chkComment.Tag = "comment:"
        Me.chkComment.Text = "Comment:"
        Me.chkComment.UseVisualStyleBackColor = True
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(90, 1)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(312, 20)
        Me.txtComment.TabIndex = 1
        '
        'cmdLanguage
        '
        Me.cmdLanguage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLanguage.Location = New System.Drawing.Point(286, 26)
        Me.cmdLanguage.Name = "cmdLanguage"
        Me.cmdLanguage.Size = New System.Drawing.Size(37, 23)
        Me.cmdLanguage.TabIndex = 7
        Me.cmdLanguage.Tag = ""
        Me.cmdLanguage.Text = "Lang"
        Me.cmdLanguage.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.AutoSize = True
        Me.cmdOk.ContextMenuStrip = Me.contextMenuStripOk
        Me.cmdOk.Location = New System.Drawing.Point(0, 26)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.SplitMenuStrip = Me.contextMenuStripOk
        Me.cmdOk.TabIndex = 8
        Me.cmdOk.Tag = "Ok"
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'contextMenuStripOk
        '
        Me.contextMenuStripOk.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemOkClose, Me.toolStripMenuItemOkKeep})
        Me.contextMenuStripOk.Name = "contextMenuStripOk"
        Me.contextMenuStripOk.Size = New System.Drawing.Size(135, 48)
        '
        'toolStripMenuItemOkClose
        '
        Me.toolStripMenuItemOkClose.Name = "toolStripMenuItemOkClose"
        Me.toolStripMenuItemOkClose.Size = New System.Drawing.Size(134, 22)
        Me.toolStripMenuItemOkClose.Text = "Ok && Close"
        '
        'cmdPaste
        '
        Me.cmdPaste.AutoSize = True
        Me.cmdPaste.ContextMenuStrip = Me.contextMenuStripToScript
        Me.cmdPaste.Location = New System.Drawing.Point(327, 26)
        Me.cmdPaste.Name = "cmdPaste"
        Me.cmdPaste.Size = New System.Drawing.Size(78, 23)
        Me.cmdPaste.SplitMenuStrip = Me.contextMenuStripToScript
        Me.cmdPaste.TabIndex = 10
        Me.cmdPaste.Tag = "To_Script"
        Me.cmdPaste.Text = "To Script"
        Me.cmdPaste.UseVisualStyleBackColor = True
        '
        'contextMenuStripToScript
        '
        Me.contextMenuStripToScript.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemToScriptClose, Me.toolStripMenuItemToScriptKeep})
        Me.contextMenuStripToScript.Name = "contextMenuStripToScript"
        Me.contextMenuStripToScript.Size = New System.Drawing.Size(181, 70)
        '
        'toolStripMenuItemToScriptClose
        '
        Me.toolStripMenuItemToScriptClose.Name = "toolStripMenuItemToScriptClose"
        Me.toolStripMenuItemToScriptClose.Size = New System.Drawing.Size(180, 22)
        Me.toolStripMenuItemToScriptClose.Text = "To Script && Close"
        '
        'toolStripMenuItemToScriptKeep
        '
        Me.toolStripMenuItemToScriptKeep.Name = "toolStripMenuItemToScriptKeep"
        Me.toolStripMenuItemToScriptKeep.Size = New System.Drawing.Size(180, 22)
        Me.toolStripMenuItemToScriptKeep.Text = "To Script && Keep"
        '
        'toolStripMenuItemOkKeep
        '
        Me.toolStripMenuItemOkKeep.Name = "toolStripMenuItemOkKeep"
        Me.toolStripMenuItemOkKeep.Size = New System.Drawing.Size(134, 22)
        Me.toolStripMenuItemOkKeep.Text = "Ok && Keep"
        '
        'ucrButtons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.cmdPaste)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdLanguage)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.chkComment)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdHelp)
        Me.Name = "ucrButtons"
        Me.Size = New System.Drawing.Size(410, 52)
        Me.contextMenuStripOk.ResumeLayout(False)
        Me.contextMenuStripToScript.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents chkComment As CheckBox
    Friend WithEvents txtComment As TextBox
    Friend WithEvents cmdLanguage As Button
    Friend WithEvents cmdOk As ucrSplitButton
    Friend WithEvents contextMenuStripOk As ContextMenuStrip
    Friend WithEvents toolStripMenuItemOkClose As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemOkKeep As ToolStripMenuItem
    Friend WithEvents cmdPaste As ucrSplitButton
    Friend WithEvents contextMenuStripToScript As ContextMenuStrip
    Friend WithEvents toolStripMenuItemToScriptClose As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemToScriptKeep As ToolStripMenuItem
End Class
