<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgEditMacro
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
        Me.ucrBase = New instat.ucrButtons()
        Me.grpDirectory = New System.Windows.Forms.GroupBox()
        Me.chkCurrent = New System.Windows.Forms.CheckBox()
        Me.chkLocal = New System.Windows.Forms.CheckBox()
        Me.chkClimatic = New System.Windows.Forms.CheckBox()
        Me.chkGeneral = New System.Windows.Forms.CheckBox()
        Me.cboMacroFileName = New System.Windows.Forms.ComboBox()
        Me.lblMacroFileName = New System.Windows.Forms.Label()
        Me.btnHelpOnMacro = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.grpDirectory.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 167)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'grpDirectory
        '
        Me.grpDirectory.Controls.Add(Me.chkGeneral)
        Me.grpDirectory.Controls.Add(Me.chkClimatic)
        Me.grpDirectory.Controls.Add(Me.chkLocal)
        Me.grpDirectory.Controls.Add(Me.chkCurrent)
        Me.grpDirectory.Location = New System.Drawing.Point(12, 13)
        Me.grpDirectory.Name = "grpDirectory"
        Me.grpDirectory.Size = New System.Drawing.Size(115, 129)
        Me.grpDirectory.TabIndex = 1
        Me.grpDirectory.TabStop = False
        Me.grpDirectory.Tag = "Directory"
        Me.grpDirectory.Text = "Directory"
        '
        'chkCurrent
        '
        Me.chkCurrent.AutoSize = True
        Me.chkCurrent.Location = New System.Drawing.Point(7, 20)
        Me.chkCurrent.Name = "chkCurrent"
        Me.chkCurrent.Size = New System.Drawing.Size(60, 17)
        Me.chkCurrent.TabIndex = 0
        Me.chkCurrent.Tag = "Current"
        Me.chkCurrent.Text = "Current"
        Me.chkCurrent.UseVisualStyleBackColor = True
        '
        'chkLocal
        '
        Me.chkLocal.AutoSize = True
        Me.chkLocal.Location = New System.Drawing.Point(7, 43)
        Me.chkLocal.Name = "chkLocal"
        Me.chkLocal.Size = New System.Drawing.Size(52, 17)
        Me.chkLocal.TabIndex = 0
        Me.chkLocal.Tag = "Local"
        Me.chkLocal.Text = "Local"
        Me.chkLocal.UseVisualStyleBackColor = True
        '
        'chkClimatic
        '
        Me.chkClimatic.AutoSize = True
        Me.chkClimatic.Location = New System.Drawing.Point(6, 66)
        Me.chkClimatic.Name = "chkClimatic"
        Me.chkClimatic.Size = New System.Drawing.Size(62, 17)
        Me.chkClimatic.TabIndex = 0
        Me.chkClimatic.Tag = "Climatic"
        Me.chkClimatic.Text = "Climatic"
        Me.chkClimatic.UseVisualStyleBackColor = True
        '
        'chkGeneral
        '
        Me.chkGeneral.AutoSize = True
        Me.chkGeneral.Location = New System.Drawing.Point(6, 89)
        Me.chkGeneral.Name = "chkGeneral"
        Me.chkGeneral.Size = New System.Drawing.Size(63, 17)
        Me.chkGeneral.TabIndex = 0
        Me.chkGeneral.Tag = "General"
        Me.chkGeneral.Text = "General"
        Me.chkGeneral.UseVisualStyleBackColor = True
        '
        'cboMacroFileName
        '
        Me.cboMacroFileName.FormattingEnabled = True
        Me.cboMacroFileName.Location = New System.Drawing.Point(133, 33)
        Me.cboMacroFileName.Name = "cboMacroFileName"
        Me.cboMacroFileName.Size = New System.Drawing.Size(289, 21)
        Me.cboMacroFileName.TabIndex = 2
        '
        'lblMacroFileName
        '
        Me.lblMacroFileName.AutoSize = True
        Me.lblMacroFileName.Location = New System.Drawing.Point(133, 13)
        Me.lblMacroFileName.Name = "lblMacroFileName"
        Me.lblMacroFileName.Size = New System.Drawing.Size(82, 13)
        Me.lblMacroFileName.TabIndex = 3
        Me.lblMacroFileName.Tag = "Macro_file_name"
        Me.lblMacroFileName.Text = "Macro file name"
        '
        'btnHelpOnMacro
        '
        Me.btnHelpOnMacro.Location = New System.Drawing.Point(294, 119)
        Me.btnHelpOnMacro.Name = "btnHelpOnMacro"
        Me.btnHelpOnMacro.Size = New System.Drawing.Size(128, 23)
        Me.btnHelpOnMacro.TabIndex = 4
        Me.btnHelpOnMacro.Tag = "Help_on_macro"
        Me.btnHelpOnMacro.Text = "Help on macro"
        Me.btnHelpOnMacro.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(347, 73)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Tag = "Browse"
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'dlgEditMacro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 214)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnHelpOnMacro)
        Me.Controls.Add(Me.lblMacroFileName)
        Me.Controls.Add(Me.cboMacroFileName)
        Me.Controls.Add(Me.grpDirectory)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgEditMacro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Edit_macro"
        Me.Text = "Edit macro"
        Me.grpDirectory.ResumeLayout(False)
        Me.grpDirectory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpDirectory As GroupBox
    Friend WithEvents chkGeneral As CheckBox
    Friend WithEvents chkClimatic As CheckBox
    Friend WithEvents chkLocal As CheckBox
    Friend WithEvents chkCurrent As CheckBox
    Friend WithEvents cboMacroFileName As ComboBox
    Friend WithEvents lblMacroFileName As Label
    Friend WithEvents btnHelpOnMacro As Button
    Friend WithEvents btnBrowse As Button
End Class
