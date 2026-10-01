<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgImportfromClimMob
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
        Me.cmdFindForms = New System.Windows.Forms.Button()
        Me.ucrInputChooseForm = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblServerName = New System.Windows.Forms.Label()
        Me.cmdKey = New System.Windows.Forms.Button()
        Me.ucrInputServerName = New instat.ucrInputComboBox()
        Me.ucrSaveFile = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'cmdFindForms
        '
        Me.cmdFindForms.Location = New System.Drawing.Point(13, 76)
        Me.cmdFindForms.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdFindForms.Name = "cmdFindForms"
        Me.cmdFindForms.Size = New System.Drawing.Size(150, 35)
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
        Me.ucrInputChooseForm.Location = New System.Drawing.Point(176, 80)
        Me.ucrInputChooseForm.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputChooseForm.Name = "ucrInputChooseForm"
        Me.ucrInputChooseForm.Size = New System.Drawing.Size(287, 35)
        Me.ucrInputChooseForm.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(13, 185)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 6
        '
        'lblServerName
        '
        Me.lblServerName.Location = New System.Drawing.Point(18, 31)
        Me.lblServerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServerName.Name = "lblServerName"
        Me.lblServerName.Size = New System.Drawing.Size(166, 32)
        Me.lblServerName.TabIndex = 0
        Me.lblServerName.Text = "Server Name:"
        '
        'cmdKey
        '
        Me.cmdKey.Location = New System.Drawing.Point(476, 24)
        Me.cmdKey.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdKey.Name = "cmdKey"
        Me.cmdKey.Size = New System.Drawing.Size(129, 35)
        Me.cmdKey.TabIndex = 2
        Me.cmdKey.Text = "Get Key..."
        Me.cmdKey.UseVisualStyleBackColor = True
        '
        'ucrInputServerName
        '
        Me.ucrInputServerName.AddQuotesIfUnrecognised = True
        Me.ucrInputServerName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputServerName.GetSetSelectedIndex = -1
        Me.ucrInputServerName.IsReadOnly = False
        Me.ucrInputServerName.Location = New System.Drawing.Point(141, 27)
        Me.ucrInputServerName.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputServerName.Name = "ucrInputServerName"
        Me.ucrInputServerName.Size = New System.Drawing.Size(322, 32)
        Me.ucrInputServerName.TabIndex = 1
        '
        'ucrSaveFile
        '
        Me.ucrSaveFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveFile.Location = New System.Drawing.Point(13, 135)
        Me.ucrSaveFile.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveFile.Name = "ucrSaveFile"
        Me.ucrSaveFile.Size = New System.Drawing.Size(562, 34)
        Me.ucrSaveFile.TabIndex = 5
        '
        'dlgImportfromClimMob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 272)
        Me.Controls.Add(Me.ucrSaveFile)
        Me.Controls.Add(Me.ucrInputServerName)
        Me.Controls.Add(Me.cmdKey)
        Me.Controls.Add(Me.cmdFindForms)
        Me.Controls.Add(Me.ucrInputChooseForm)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblServerName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "dlgImportfromClimMob"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import From ClimMob"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdFindForms As Button
    Friend WithEvents ucrInputChooseForm As ucrInputComboBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblServerName As Label
    Friend WithEvents cmdKey As Button
    Friend WithEvents ucrInputServerName As ucrInputComboBox
    Friend WithEvents ucrSaveFile As ucrSave
End Class
