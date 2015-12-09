<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgStartSpoolingOutputToFile
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
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblSpoolFileName = New System.Windows.Forms.Label()
        Me.txtSpoolFileName = New System.Windows.Forms.TextBox()
        Me.chkAppendToFile = New System.Windows.Forms.CheckBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(330, 39)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Tag = "Browse"
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblSpoolFileName
        '
        Me.lblSpoolFileName.AutoSize = True
        Me.lblSpoolFileName.Location = New System.Drawing.Point(21, 9)
        Me.lblSpoolFileName.Name = "lblSpoolFileName"
        Me.lblSpoolFileName.Size = New System.Drawing.Size(79, 13)
        Me.lblSpoolFileName.TabIndex = 1
        Me.lblSpoolFileName.Tag = "Spool_file_name"
        Me.lblSpoolFileName.Text = "Spool file name"
        '
        'txtSpoolFileName
        '
        Me.txtSpoolFileName.Location = New System.Drawing.Point(24, 42)
        Me.txtSpoolFileName.Name = "txtSpoolFileName"
        Me.txtSpoolFileName.Size = New System.Drawing.Size(279, 20)
        Me.txtSpoolFileName.TabIndex = 2
        '
        'chkAppendToFile
        '
        Me.chkAppendToFile.AutoSize = True
        Me.chkAppendToFile.Location = New System.Drawing.Point(24, 85)
        Me.chkAppendToFile.Name = "chkAppendToFile"
        Me.chkAppendToFile.Size = New System.Drawing.Size(91, 17)
        Me.chkAppendToFile.TabIndex = 3
        Me.chkAppendToFile.Tag = "Append_to_file"
        Me.chkAppendToFile.Text = "Append to file"
        Me.chkAppendToFile.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 141)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 4
        '
        'dlgStartSpoolingOutputToFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 178)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.chkAppendToFile)
        Me.Controls.Add(Me.txtSpoolFileName)
        Me.Controls.Add(Me.lblSpoolFileName)
        Me.Controls.Add(Me.btnBrowse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgStartSpoolingOutputToFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Start_spooling_output_to_file"
        Me.Text = "Start spooling output to file"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblSpoolFileName As Label
    Friend WithEvents txtSpoolFileName As TextBox
    Friend WithEvents chkAppendToFile As CheckBox
    Friend WithEvents ucrBase As ucrButtons
End Class
