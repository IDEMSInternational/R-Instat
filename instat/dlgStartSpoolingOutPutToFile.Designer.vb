<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgStartSpoolingOutPutToFile
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
        Me.chkAppendToTheFile = New System.Windows.Forms.CheckBox()
        Me.txtSpoolFileName = New System.Windows.Forms.TextBox()
        Me.lblSpoolFileName = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 145)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'chkAppendToTheFile
        '
        Me.chkAppendToTheFile.AutoSize = True
        Me.chkAppendToTheFile.Location = New System.Drawing.Point(36, 87)
        Me.chkAppendToTheFile.Name = "chkAppendToTheFile"
        Me.chkAppendToTheFile.Size = New System.Drawing.Size(109, 17)
        Me.chkAppendToTheFile.TabIndex = 1
        Me.chkAppendToTheFile.Tag = "Append_to_the_file"
        Me.chkAppendToTheFile.Text = "Append to the file"
        Me.chkAppendToTheFile.UseVisualStyleBackColor = True
        '
        'txtSpoolFileName
        '
        Me.txtSpoolFileName.Location = New System.Drawing.Point(36, 41)
        Me.txtSpoolFileName.Name = "txtSpoolFileName"
        Me.txtSpoolFileName.Size = New System.Drawing.Size(229, 20)
        Me.txtSpoolFileName.TabIndex = 2
        '
        'lblSpoolFileName
        '
        Me.lblSpoolFileName.AutoSize = True
        Me.lblSpoolFileName.Location = New System.Drawing.Point(33, 9)
        Me.lblSpoolFileName.Name = "lblSpoolFileName"
        Me.lblSpoolFileName.Size = New System.Drawing.Size(79, 13)
        Me.lblSpoolFileName.TabIndex = 3
        Me.lblSpoolFileName.Tag = "Spool_file_name"
        Me.lblSpoolFileName.Text = "Spool file name"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(317, 39)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Tag = "Browse"
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'dlgStartSpoolingOutPutToFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 212)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.lblSpoolFileName)
        Me.Controls.Add(Me.txtSpoolFileName)
        Me.Controls.Add(Me.chkAppendToTheFile)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgStartSpoolingOutPutToFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Start_spooling_output_to_file"
        Me.Text = "Start spooling output to file"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkAppendToTheFile As CheckBox
    Friend WithEvents txtSpoolFileName As TextBox
    Friend WithEvents lblSpoolFileName As Label
    Friend WithEvents btnBrowse As Button
End Class
