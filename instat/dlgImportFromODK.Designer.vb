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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgImportFromODK))
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
        resources.ApplyResources(Me.lblUsername, "lblUsername")
        Me.lblUsername.Name = "lblUsername"
        '
        'lblChooseForm
        '
        resources.ApplyResources(Me.lblChooseForm, "lblChooseForm")
        Me.lblChooseForm.Name = "lblChooseForm"
        '
        'cmdFindForms
        '
        resources.ApplyResources(Me.cmdFindForms, "cmdFindForms")
        Me.cmdFindForms.Name = "cmdFindForms"
        Me.cmdFindForms.UseVisualStyleBackColor = True
        '
        'ucrInputChooseForm
        '
        Me.ucrInputChooseForm.AddQuotesIfUnrecognised = True
        Me.ucrInputChooseForm.GetSetSelectedIndex = -1
        Me.ucrInputChooseForm.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputChooseForm, "ucrInputChooseForm")
        Me.ucrInputChooseForm.Name = "ucrInputChooseForm"
        '
        'ucrInputUsername
        '
        Me.ucrInputUsername.AddQuotesIfUnrecognised = True
        Me.ucrInputUsername.IsMultiline = False
        Me.ucrInputUsername.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputUsername, "ucrInputUsername")
        Me.ucrInputUsername.Name = "ucrInputUsername"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrPnlPlatform
        '
        resources.ApplyResources(Me.ucrPnlPlatform, "ucrPnlPlatform")
        Me.ucrPnlPlatform.Name = "ucrPnlPlatform"
        '
        'rdoKobo
        '
        resources.ApplyResources(Me.rdoKobo, "rdoKobo")
        Me.rdoKobo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoKobo.FlatAppearance.BorderSize = 2
        Me.rdoKobo.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoKobo.Name = "rdoKobo"
        Me.rdoKobo.TabStop = True
        Me.rdoKobo.UseVisualStyleBackColor = True
        '
        'rdoOna
        '
        resources.ApplyResources(Me.rdoOna, "rdoOna")
        Me.rdoOna.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOna.FlatAppearance.BorderSize = 2
        Me.rdoOna.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOna.Name = "rdoOna"
        Me.rdoOna.TabStop = True
        Me.rdoOna.UseVisualStyleBackColor = True
        '
        'dlgImportFromODK
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.ResumeLayout(False)

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