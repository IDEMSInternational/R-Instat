<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgThemes
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
        Me.ucrBase = New instat.ucrButtons()
        Me.lblTheme = New System.Windows.Forms.Label()
        Me.cmdCreateNewTheme = New System.Windows.Forms.Button()
        Me.ucrInputThemeLists = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 244)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'lblTheme
        '
        Me.lblTheme.AutoSize = True
        Me.lblTheme.Location = New System.Drawing.Point(10, 10)
        Me.lblTheme.Name = "lblTheme"
        Me.lblTheme.Size = New System.Drawing.Size(45, 13)
        Me.lblTheme.TabIndex = 2
        Me.lblTheme.Text = "Themes"
        '
        'cmdCreateNewTheme
        '
        Me.cmdCreateNewTheme.Location = New System.Drawing.Point(13, 139)
        Me.cmdCreateNewTheme.Name = "cmdCreateNewTheme"
        Me.cmdCreateNewTheme.Size = New System.Drawing.Size(126, 23)
        Me.cmdCreateNewTheme.TabIndex = 3
        Me.cmdCreateNewTheme.Text = "Create New Theme"
        Me.cmdCreateNewTheme.UseVisualStyleBackColor = True
        '
        'ucrInputThemeLists
        '
        Me.ucrInputThemeLists.Location = New System.Drawing.Point(13, 39)
        Me.ucrInputThemeLists.Name = "ucrInputThemeLists"
        Me.ucrInputThemeLists.Size = New System.Drawing.Size(137, 25)
        Me.ucrInputThemeLists.TabIndex = 4
        '
        'dlgThemes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 309)
        Me.Controls.Add(Me.ucrInputThemeLists)
        Me.Controls.Add(Me.cmdCreateNewTheme)
        Me.Controls.Add(Me.lblTheme)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgThemes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Themes"
        Me.Text = "Themes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblTheme As Label
    Friend WithEvents cmdCreateNewTheme As Button
    Friend WithEvents ucrInputThemeLists As ucrInputComboBox
End Class

