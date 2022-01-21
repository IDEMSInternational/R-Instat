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
Partial Class dlgThemes
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
        Me.lblThemetoEdit = New System.Windows.Forms.Label()
        Me.cmdThemeOptions = New System.Windows.Forms.Button()
        Me.ucrChkDeleteTheme = New instat.ucrCheck()
        Me.ucrSaveTheme = New instat.ucrSave()
        Me.ucrReceiverThemetoEdit = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorThemes = New instat.ucrSelectorAddRemove()
        Me.SuspendLayout()
        '
        'lblThemetoEdit
        '
        Me.lblThemetoEdit.AutoSize = True
        Me.lblThemetoEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblThemetoEdit.Location = New System.Drawing.Point(240, 58)
        Me.lblThemetoEdit.Name = "lblThemetoEdit"
        Me.lblThemetoEdit.Size = New System.Drawing.Size(76, 13)
        Me.lblThemetoEdit.TabIndex = 3
        Me.lblThemetoEdit.Text = "Theme to Edit:"
        '
        'cmdThemeOptions
        '
        Me.cmdThemeOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdThemeOptions.Location = New System.Drawing.Point(243, 131)
        Me.cmdThemeOptions.Name = "cmdThemeOptions"
        Me.cmdThemeOptions.Size = New System.Drawing.Size(120, 23)
        Me.cmdThemeOptions.TabIndex = 4
        Me.cmdThemeOptions.Text = "Theme Options"
        Me.cmdThemeOptions.UseVisualStyleBackColor = True
        '
        'ucrChkDeleteTheme
        '
        Me.ucrChkDeleteTheme.AutoSize = True
        Me.ucrChkDeleteTheme.Checked = False
        Me.ucrChkDeleteTheme.Enabled = False
        Me.ucrChkDeleteTheme.Location = New System.Drawing.Point(243, 107)
        Me.ucrChkDeleteTheme.Name = "ucrChkDeleteTheme"
        Me.ucrChkDeleteTheme.Size = New System.Drawing.Size(145, 23)
        Me.ucrChkDeleteTheme.TabIndex = 6
        '
        'ucrSaveTheme
        '
        Me.ucrSaveTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTheme.Location = New System.Drawing.Point(9, 182)
        Me.ucrSaveTheme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTheme.Name = "ucrSaveTheme"
        Me.ucrSaveTheme.Size = New System.Drawing.Size(254, 24)
        Me.ucrSaveTheme.TabIndex = 5
        '
        'ucrReceiverThemetoEdit
        '
        Me.ucrReceiverThemetoEdit.AutoSize = True
        Me.ucrReceiverThemetoEdit.frmParent = Me
        Me.ucrReceiverThemetoEdit.Location = New System.Drawing.Point(243, 73)
        Me.ucrReceiverThemetoEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverThemetoEdit.Name = "ucrReceiverThemetoEdit"
        Me.ucrReceiverThemetoEdit.Selector = Nothing
        Me.ucrReceiverThemetoEdit.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverThemetoEdit.strNcFilePath = ""
        Me.ucrReceiverThemetoEdit.TabIndex = 2
        Me.ucrReceiverThemetoEdit.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 212)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorThemes
        '
        Me.ucrSelectorThemes.AutoSize = True
        Me.ucrSelectorThemes.bShowHiddenColumns = False
        Me.ucrSelectorThemes.Location = New System.Drawing.Point(9, 32)
        Me.ucrSelectorThemes.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorThemes.Name = "ucrSelectorThemes"
        Me.ucrSelectorThemes.Size = New System.Drawing.Size(213, 147)
        Me.ucrSelectorThemes.TabIndex = 7
        '
        'dlgThemes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(423, 279)
        Me.Controls.Add(Me.ucrSelectorThemes)
        Me.Controls.Add(Me.ucrChkDeleteTheme)
        Me.Controls.Add(Me.ucrSaveTheme)
        Me.Controls.Add(Me.cmdThemeOptions)
        Me.Controls.Add(Me.lblThemetoEdit)
        Me.Controls.Add(Me.ucrReceiverThemetoEdit)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgThemes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Themes"
        Me.Text = "Themes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverThemetoEdit As ucrReceiverSingle
    Friend WithEvents cmdThemeOptions As Button
    Friend WithEvents lblThemetoEdit As Label
    Friend WithEvents ucrSaveTheme As ucrSave
    Friend WithEvents ucrChkDeleteTheme As ucrCheck
    Friend WithEvents ucrSelectorThemes As ucrSelectorAddRemove
End Class
