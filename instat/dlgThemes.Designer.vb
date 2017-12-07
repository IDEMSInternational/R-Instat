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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgThemes))
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
        resources.ApplyResources(Me.lblThemetoEdit, "lblThemetoEdit")
        Me.lblThemetoEdit.Name = "lblThemetoEdit"
        '
        'cmdThemeOptions
        '
        resources.ApplyResources(Me.cmdThemeOptions, "cmdThemeOptions")
        Me.cmdThemeOptions.Name = "cmdThemeOptions"
        Me.cmdThemeOptions.UseVisualStyleBackColor = True
        '
        'ucrChkDeleteTheme
        '
        Me.ucrChkDeleteTheme.Checked = False
        resources.ApplyResources(Me.ucrChkDeleteTheme, "ucrChkDeleteTheme")
        Me.ucrChkDeleteTheme.Name = "ucrChkDeleteTheme"
        '
        'ucrSaveTheme
        '
        resources.ApplyResources(Me.ucrSaveTheme, "ucrSaveTheme")
        Me.ucrSaveTheme.Name = "ucrSaveTheme"
        '
        'ucrReceiverThemetoEdit
        '
        Me.ucrReceiverThemetoEdit.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverThemetoEdit, "ucrReceiverThemetoEdit")
        Me.ucrReceiverThemetoEdit.Name = "ucrReceiverThemetoEdit"
        Me.ucrReceiverThemetoEdit.Selector = Nothing
        Me.ucrReceiverThemetoEdit.strNcFilePath = ""
        Me.ucrReceiverThemetoEdit.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorThemes
        '
        Me.ucrSelectorThemes.bShowHiddenColumns = False
        resources.ApplyResources(Me.ucrSelectorThemes, "ucrSelectorThemes")
        Me.ucrSelectorThemes.Name = "ucrSelectorThemes"
        '
        'dlgThemes
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Tag = "Themes"
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
