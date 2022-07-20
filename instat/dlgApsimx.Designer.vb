<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgApsimx
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.ucrChkSilent = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputPath = New instat.ucrInputTextBox()
        Me.ucrSaveFile = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(13, 33)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(32, 13)
        Me.lblPath.TabIndex = 2
        Me.lblPath.Text = "Path:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrowse.Location = New System.Drawing.Point(312, 33)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(109, 23)
        Me.cmdBrowse.TabIndex = 5
        Me.cmdBrowse.Tag = "browse"
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'ucrChkSilent
        '
        Me.ucrChkSilent.AutoSize = True
        Me.ucrChkSilent.Checked = False
        Me.ucrChkSilent.Location = New System.Drawing.Point(16, 81)
        Me.ucrChkSilent.Name = "ucrChkSilent"
        Me.ucrChkSilent.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSilent.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(13, 188)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 1
        '
        'ucrInputPath
        '
        Me.ucrInputPath.AddQuotesIfUnrecognised = True
        Me.ucrInputPath.AutoSize = True
        Me.ucrInputPath.IsMultiline = False
        Me.ucrInputPath.IsReadOnly = False
        Me.ucrInputPath.Location = New System.Drawing.Point(50, 33)
        Me.ucrInputPath.Name = "ucrInputPath"
        Me.ucrInputPath.Size = New System.Drawing.Size(256, 21)
        Me.ucrInputPath.TabIndex = 6
        '
        'ucrSaveFile
        '
        Me.ucrSaveFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveFile.Location = New System.Drawing.Point(16, 158)
        Me.ucrSaveFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveFile.Name = "ucrSaveFile"
        Me.ucrSaveFile.Size = New System.Drawing.Size(394, 23)
        Me.ucrSaveFile.TabIndex = 30
        '
        'dlgApsimx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 251)
        Me.Controls.Add(Me.ucrSaveFile)
        Me.Controls.Add(Me.ucrInputPath)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.ucrChkSilent)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgApsimx"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apsimx"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblPath As Label
    Friend WithEvents ucrChkSilent As ucrCheck
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents ucrInputPath As ucrInputTextBox
    Friend WithEvents ucrSaveFile As ucrSave
End Class
