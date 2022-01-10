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
Partial Class dlgImportFromODK
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblChooseForm = New System.Windows.Forms.Label()
        Me.cmdFindForms = New System.Windows.Forms.Button()
        Me.ucrInputChooseForm = New instat.ucrInputComboBox()
        Me.ucrInputUsername = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlPlatform = New instat.UcrPanel()
        Me.rdoKobo = New System.Windows.Forms.RadioButton()
        Me.rdoOna = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.Location = New System.Drawing.Point(10, 58)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(112, 13)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username:"
        '
        'lblChooseForm
        '
        Me.lblChooseForm.Location = New System.Drawing.Point(10, 118)
        Me.lblChooseForm.Name = "lblChooseForm"
        Me.lblChooseForm.Size = New System.Drawing.Size(112, 13)
        Me.lblChooseForm.TabIndex = 4
        Me.lblChooseForm.Text = "Choose Form:"
        '
        'cmdFindForms
        '
        Me.cmdFindForms.Location = New System.Drawing.Point(10, 84)
        Me.cmdFindForms.Name = "cmdFindForms"
        Me.cmdFindForms.Size = New System.Drawing.Size(121, 23)
        Me.cmdFindForms.TabIndex = 3
        Me.cmdFindForms.Text = "Find Forms"
        Me.cmdFindForms.UseVisualStyleBackColor = True
        '
        'ucrInputChooseForm
        '
        Me.ucrInputChooseForm.AddQuotesIfUnrecognised = True
        Me.ucrInputChooseForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputChooseForm.GetSetSelectedIndex = -1
        Me.ucrInputChooseForm.IsReadOnly = False
        Me.ucrInputChooseForm.Location = New System.Drawing.Point(116, 114)
        Me.ucrInputChooseForm.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputChooseForm.Name = "ucrInputChooseForm"
        Me.ucrInputChooseForm.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputChooseForm.TabIndex = 5
        '
        'ucrInputUsername
        '
        Me.ucrInputUsername.AddQuotesIfUnrecognised = True
        Me.ucrInputUsername.AutoSize = True
        Me.ucrInputUsername.IsMultiline = False
        Me.ucrInputUsername.IsReadOnly = False
        Me.ucrInputUsername.Location = New System.Drawing.Point(116, 56)
        Me.ucrInputUsername.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputUsername.Name = "ucrInputUsername"
        Me.ucrInputUsername.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputUsername.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(2, 148)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 6
        '
        'ucrPnlPlatform
        '
        Me.ucrPnlPlatform.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlPlatform.Location = New System.Drawing.Point(98, 12)
        Me.ucrPnlPlatform.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrPnlPlatform.Name = "ucrPnlPlatform"
        Me.ucrPnlPlatform.Size = New System.Drawing.Size(246, 28)
        Me.ucrPnlPlatform.TabIndex = 0
        '
        'rdoKobo
        '
        Me.rdoKobo.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoKobo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoKobo.FlatAppearance.BorderSize = 2
        Me.rdoKobo.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoKobo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoKobo.Location = New System.Drawing.Point(116, 12)
        Me.rdoKobo.Name = "rdoKobo"
        Me.rdoKobo.Size = New System.Drawing.Size(100, 28)
        Me.rdoKobo.TabIndex = 0
        Me.rdoKobo.TabStop = True
        Me.rdoKobo.Text = "Kobo"
        Me.rdoKobo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoKobo.UseVisualStyleBackColor = True
        '
        'rdoOna
        '
        Me.rdoOna.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoOna.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOna.FlatAppearance.BorderSize = 2
        Me.rdoOna.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOna.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoOna.Location = New System.Drawing.Point(214, 12)
        Me.rdoOna.Name = "rdoOna"
        Me.rdoOna.Size = New System.Drawing.Size(100, 28)
        Me.rdoOna.TabIndex = 1
        Me.rdoOna.TabStop = True
        Me.rdoOna.Text = "Ona"
        Me.rdoOna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoOna.UseVisualStyleBackColor = True
        '
        'dlgImportFromODK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(426, 205)
        Me.Controls.Add(Me.rdoOna)
        Me.Controls.Add(Me.rdoKobo)
        Me.Controls.Add(Me.ucrPnlPlatform)
        Me.Controls.Add(Me.cmdFindForms)
        Me.Controls.Add(Me.ucrInputChooseForm)
        Me.Controls.Add(Me.ucrInputUsername)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblChooseForm)
        Me.Controls.Add(Me.lblUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportFromODK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import from ODK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblChooseForm As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputUsername As ucrInputTextBox
    Friend WithEvents ucrInputChooseForm As ucrInputComboBox
    Friend WithEvents cmdFindForms As Button
    Friend WithEvents ucrPnlPlatform As UcrPanel
    Friend WithEvents rdoKobo As RadioButton
    Friend WithEvents rdoOna As RadioButton
End Class