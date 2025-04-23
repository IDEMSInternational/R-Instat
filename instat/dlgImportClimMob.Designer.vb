<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgImportfromClimMob
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
        Me.cmdFindForms.Location = New System.Drawing.Point(5, 89)
        Me.cmdFindForms.Name = "cmdFindForms"
        Me.cmdFindForms.Size = New System.Drawing.Size(102, 23)
        Me.cmdFindForms.TabIndex = 9
        Me.cmdFindForms.Text = "Find Forms"
        Me.cmdFindForms.UseVisualStyleBackColor = True
        '
        'ucrInputChooseForm
        '
        Me.ucrInputChooseForm.AddQuotesIfUnrecognised = True
        Me.ucrInputChooseForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputChooseForm.GetSetSelectedIndex = -1
        Me.ucrInputChooseForm.IsReadOnly = False
        Me.ucrInputChooseForm.Location = New System.Drawing.Point(123, 91)
        Me.ucrInputChooseForm.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputChooseForm.Name = "ucrInputChooseForm"
        Me.ucrInputChooseForm.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputChooseForm.TabIndex = 11
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(5, 219)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 12
        '
        'lblServerName
        '
        Me.lblServerName.Location = New System.Drawing.Point(21, 54)
        Me.lblServerName.Name = "lblServerName"
        Me.lblServerName.Size = New System.Drawing.Size(112, 21)
        Me.lblServerName.TabIndex = 7
        Me.lblServerName.Text = "Server Name:"
        '
        'cmdKey
        '
        Me.cmdKey.Location = New System.Drawing.Point(316, 54)
        Me.cmdKey.Name = "cmdKey"
        Me.cmdKey.Size = New System.Drawing.Size(86, 23)
        Me.cmdKey.TabIndex = 15
        Me.cmdKey.Text = "Get Key..."
        Me.cmdKey.UseVisualStyleBackColor = True
        '
        'ucrInputServerName
        '
        Me.ucrInputServerName.AddQuotesIfUnrecognised = True
        Me.ucrInputServerName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputServerName.GetSetSelectedIndex = -1
        Me.ucrInputServerName.IsReadOnly = False
        Me.ucrInputServerName.Location = New System.Drawing.Point(123, 54)
        Me.ucrInputServerName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputServerName.Name = "ucrInputServerName"
        Me.ucrInputServerName.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputServerName.TabIndex = 16
        '
        'ucrSaveFile
        '
        Me.ucrSaveFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveFile.Location = New System.Drawing.Point(5, 188)
        Me.ucrSaveFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveFile.Name = "ucrSaveFile"
        Me.ucrSaveFile.Size = New System.Drawing.Size(385, 22)
        Me.ucrSaveFile.TabIndex = 30
        '
        'dlgImportfromClimMob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 280)
        Me.Controls.Add(Me.ucrSaveFile)
        Me.Controls.Add(Me.ucrInputServerName)
        Me.Controls.Add(Me.cmdKey)
        Me.Controls.Add(Me.cmdFindForms)
        Me.Controls.Add(Me.ucrInputChooseForm)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblServerName)
        Me.Name = "dlgImportfromClimMob"
        Me.ShowIcon = False
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
