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
Partial Class dlgFind
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
        Me.cmdFindNext = New System.Windows.Forms.Button()
        Me.cmdReplace = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.chkSearchToEndOnly = New System.Windows.Forms.CheckBox()
        Me.chkMatchCase = New System.Windows.Forms.CheckBox()
        Me.chkFindWholeWordOnly = New System.Windows.Forms.CheckBox()
        Me.lblFindWhat = New System.Windows.Forms.Label()
        Me.txtFindWhat = New System.Windows.Forms.TextBox()
        Me.cmdFindAll = New System.Windows.Forms.Button()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'cmdFindNext
        '
        Me.cmdFindNext.Location = New System.Drawing.Point(268, 39)
        Me.cmdFindNext.Name = "cmdFindNext"
        Me.cmdFindNext.Size = New System.Drawing.Size(75, 23)
        Me.cmdFindNext.TabIndex = 1
        Me.cmdFindNext.Tag = "Find_next"
        Me.cmdFindNext.Text = "Find next"
        Me.cmdFindNext.UseVisualStyleBackColor = True
        '
        'cmdReplace
        '
        Me.cmdReplace.Enabled = False
        Me.cmdReplace.Location = New System.Drawing.Point(268, 102)
        Me.cmdReplace.Name = "cmdReplace"
        Me.cmdReplace.Size = New System.Drawing.Size(75, 23)
        Me.cmdReplace.TabIndex = 3
        Me.cmdReplace.Tag = "Replace"
        Me.cmdReplace.Text = "Replace"
        Me.cmdReplace.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(268, 140)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Tag = "Close"
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'chkSearchToEndOnly
        '
        Me.chkSearchToEndOnly.AutoSize = True
        Me.chkSearchToEndOnly.Enabled = False
        Me.chkSearchToEndOnly.Location = New System.Drawing.Point(13, 100)
        Me.chkSearchToEndOnly.Name = "chkSearchToEndOnly"
        Me.chkSearchToEndOnly.Size = New System.Drawing.Size(115, 17)
        Me.chkSearchToEndOnly.TabIndex = 4
        Me.chkSearchToEndOnly.Tag = "Search_to_end_only"
        Me.chkSearchToEndOnly.Text = "Search to end only"
        Me.chkSearchToEndOnly.UseVisualStyleBackColor = True
        '
        'chkMatchCase
        '
        Me.chkMatchCase.AutoSize = True
        Me.chkMatchCase.Checked = True
        Me.chkMatchCase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMatchCase.Enabled = False
        Me.chkMatchCase.Location = New System.Drawing.Point(13, 123)
        Me.chkMatchCase.Name = "chkMatchCase"
        Me.chkMatchCase.Size = New System.Drawing.Size(83, 17)
        Me.chkMatchCase.TabIndex = 5
        Me.chkMatchCase.Tag = "Match_case"
        Me.chkMatchCase.Text = "Match Case"
        Me.chkMatchCase.UseVisualStyleBackColor = True
        '
        'chkFindWholeWordOnly
        '
        Me.chkFindWholeWordOnly.AutoSize = True
        Me.chkFindWholeWordOnly.Enabled = False
        Me.chkFindWholeWordOnly.Location = New System.Drawing.Point(13, 146)
        Me.chkFindWholeWordOnly.Name = "chkFindWholeWordOnly"
        Me.chkFindWholeWordOnly.Size = New System.Drawing.Size(125, 17)
        Me.chkFindWholeWordOnly.TabIndex = 6
        Me.chkFindWholeWordOnly.Tag = "Find_whole_word_only"
        Me.chkFindWholeWordOnly.Text = "Find whole word only"
        Me.chkFindWholeWordOnly.UseVisualStyleBackColor = True
        '
        'lblFindWhat
        '
        Me.lblFindWhat.AutoSize = True
        Me.lblFindWhat.Location = New System.Drawing.Point(13, 13)
        Me.lblFindWhat.Name = "lblFindWhat"
        Me.lblFindWhat.Size = New System.Drawing.Size(53, 13)
        Me.lblFindWhat.TabIndex = 8
        Me.lblFindWhat.Tag = "Find_what"
        Me.lblFindWhat.Text = "Find what"
        '
        'txtFindWhat
        '
        Me.txtFindWhat.Location = New System.Drawing.Point(83, 13)
        Me.txtFindWhat.Name = "txtFindWhat"
        Me.txtFindWhat.Size = New System.Drawing.Size(161, 20)
        Me.txtFindWhat.TabIndex = 0
        '
        'cmdFindAll
        '
        Me.cmdFindAll.Location = New System.Drawing.Point(268, 68)
        Me.cmdFindAll.Name = "cmdFindAll"
        Me.cmdFindAll.Size = New System.Drawing.Size(75, 23)
        Me.cmdFindAll.TabIndex = 2
        Me.cmdFindAll.Tag = "Find_zll"
        Me.cmdFindAll.Text = "Find all"
        Me.cmdFindAll.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 234)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 9
        '
        'dlgFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(420, 287)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdFindAll)
        Me.Controls.Add(Me.txtFindWhat)
        Me.Controls.Add(Me.lblFindWhat)
        Me.Controls.Add(Me.chkFindWholeWordOnly)
        Me.Controls.Add(Me.chkMatchCase)
        Me.Controls.Add(Me.chkSearchToEndOnly)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdReplace)
        Me.Controls.Add(Me.cmdFindNext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Find"
        Me.Text = "Find"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdFindNext As Button
    Friend WithEvents cmdReplace As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents chkSearchToEndOnly As CheckBox
    Friend WithEvents chkMatchCase As CheckBox
    Friend WithEvents chkFindWholeWordOnly As CheckBox
    Friend WithEvents lblFindWhat As Label
    Friend WithEvents txtFindWhat As TextBox
    Friend WithEvents cmdFindAll As Button
    Friend WithEvents ucrBase As ucrButtons
End Class
