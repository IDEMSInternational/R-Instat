<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRestoreBackup
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
        Me.grpSavingOptions = New System.Windows.Forms.GroupBox()
        Me.cmdSaveLog = New System.Windows.Forms.Button()
        Me.ucrInputSavedPathInternalLog = New instat.ucrInputTextBox()
        Me.lblInternalLogSavedTo = New System.Windows.Forms.Label()
        Me.cmdSaveInternalLog = New System.Windows.Forms.Button()
        Me.ucrInputSavedPathLog = New instat.ucrInputTextBox()
        Me.cmdSaveData = New System.Windows.Forms.Button()
        Me.lblLogSavedTo = New System.Windows.Forms.Label()
        Me.lblDataSavedTo = New System.Windows.Forms.Label()
        Me.ucrInputSavedPathData = New instat.ucrInputTextBox()
        Me.grpEndChoice = New System.Windows.Forms.GroupBox()
        Me.ucrChkSendInternalLog = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkShowDataFile = New instat.ucrCheck()
        Me.ucrChkShowLogFile = New instat.ucrCheck()
        Me.ucrChkShowInternalLogFile = New instat.ucrCheck()
        Me.rdoRunBackupLog = New System.Windows.Forms.RadioButton()
        Me.rdoLoadBackupData = New System.Windows.Forms.RadioButton()
        Me.rdoNeither = New System.Windows.Forms.RadioButton()
        Me.grpSavingOptions.SuspendLayout()
        Me.grpEndChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSavingOptions
        '
        Me.grpSavingOptions.Controls.Add(Me.ucrChkShowInternalLogFile)
        Me.grpSavingOptions.Controls.Add(Me.ucrChkShowLogFile)
        Me.grpSavingOptions.Controls.Add(Me.ucrChkShowDataFile)
        Me.grpSavingOptions.Controls.Add(Me.cmdSaveLog)
        Me.grpSavingOptions.Controls.Add(Me.ucrInputSavedPathInternalLog)
        Me.grpSavingOptions.Controls.Add(Me.lblInternalLogSavedTo)
        Me.grpSavingOptions.Controls.Add(Me.cmdSaveInternalLog)
        Me.grpSavingOptions.Controls.Add(Me.ucrInputSavedPathLog)
        Me.grpSavingOptions.Controls.Add(Me.cmdSaveData)
        Me.grpSavingOptions.Controls.Add(Me.lblLogSavedTo)
        Me.grpSavingOptions.Controls.Add(Me.lblDataSavedTo)
        Me.grpSavingOptions.Controls.Add(Me.ucrInputSavedPathData)
        Me.grpSavingOptions.Location = New System.Drawing.Point(12, 31)
        Me.grpSavingOptions.Name = "grpSavingOptions"
        Me.grpSavingOptions.Size = New System.Drawing.Size(726, 154)
        Me.grpSavingOptions.TabIndex = 20
        Me.grpSavingOptions.TabStop = False
        Me.grpSavingOptions.Text = "Saving Options"
        '
        'cmdSaveLog
        '
        Me.cmdSaveLog.Location = New System.Drawing.Point(228, 68)
        Me.cmdSaveLog.Name = "cmdSaveLog"
        Me.cmdSaveLog.Size = New System.Drawing.Size(145, 29)
        Me.cmdSaveLog.TabIndex = 5
        Me.cmdSaveLog.Text = "Browse"
        Me.cmdSaveLog.UseVisualStyleBackColor = True
        '
        'ucrInputSavedPathInternalLog
        '
        Me.ucrInputSavedPathInternalLog.AddQuotesIfUnrecognised = True
        Me.ucrInputSavedPathInternalLog.AutoSize = True
        Me.ucrInputSavedPathInternalLog.IsMultiline = False
        Me.ucrInputSavedPathInternalLog.IsReadOnly = False
        Me.ucrInputSavedPathInternalLog.Location = New System.Drawing.Point(447, 123)
        Me.ucrInputSavedPathInternalLog.Name = "ucrInputSavedPathInternalLog"
        Me.ucrInputSavedPathInternalLog.Size = New System.Drawing.Size(258, 21)
        Me.ucrInputSavedPathInternalLog.TabIndex = 16
        '
        'lblInternalLogSavedTo
        '
        Me.lblInternalLogSavedTo.AutoSize = True
        Me.lblInternalLogSavedTo.Location = New System.Drawing.Point(385, 125)
        Me.lblInternalLogSavedTo.Name = "lblInternalLogSavedTo"
        Me.lblInternalLogSavedTo.Size = New System.Drawing.Size(55, 13)
        Me.lblInternalLogSavedTo.TabIndex = 15
        Me.lblInternalLogSavedTo.Text = "Saving at:"
        '
        'cmdSaveInternalLog
        '
        Me.cmdSaveInternalLog.Location = New System.Drawing.Point(229, 115)
        Me.cmdSaveInternalLog.Name = "cmdSaveInternalLog"
        Me.cmdSaveInternalLog.Size = New System.Drawing.Size(144, 29)
        Me.cmdSaveInternalLog.TabIndex = 7
        Me.cmdSaveInternalLog.Text = "Browse"
        Me.cmdSaveInternalLog.UseVisualStyleBackColor = True
        '
        'ucrInputSavedPathLog
        '
        Me.ucrInputSavedPathLog.AddQuotesIfUnrecognised = True
        Me.ucrInputSavedPathLog.AutoSize = True
        Me.ucrInputSavedPathLog.IsMultiline = False
        Me.ucrInputSavedPathLog.IsReadOnly = False
        Me.ucrInputSavedPathLog.Location = New System.Drawing.Point(446, 76)
        Me.ucrInputSavedPathLog.Name = "ucrInputSavedPathLog"
        Me.ucrInputSavedPathLog.Size = New System.Drawing.Size(258, 21)
        Me.ucrInputSavedPathLog.TabIndex = 14
        '
        'cmdSaveData
        '
        Me.cmdSaveData.Location = New System.Drawing.Point(229, 21)
        Me.cmdSaveData.Name = "cmdSaveData"
        Me.cmdSaveData.Size = New System.Drawing.Size(144, 29)
        Me.cmdSaveData.TabIndex = 9
        Me.cmdSaveData.Text = "Browse"
        Me.cmdSaveData.UseVisualStyleBackColor = True
        '
        'lblLogSavedTo
        '
        Me.lblLogSavedTo.AutoSize = True
        Me.lblLogSavedTo.Location = New System.Drawing.Point(385, 78)
        Me.lblLogSavedTo.Name = "lblLogSavedTo"
        Me.lblLogSavedTo.Size = New System.Drawing.Size(55, 13)
        Me.lblLogSavedTo.TabIndex = 13
        Me.lblLogSavedTo.Text = "Saving at:"
        '
        'lblDataSavedTo
        '
        Me.lblDataSavedTo.AutoSize = True
        Me.lblDataSavedTo.Location = New System.Drawing.Point(384, 29)
        Me.lblDataSavedTo.Name = "lblDataSavedTo"
        Me.lblDataSavedTo.Size = New System.Drawing.Size(55, 13)
        Me.lblDataSavedTo.TabIndex = 11
        Me.lblDataSavedTo.Text = "Saving at:"
        '
        'ucrInputSavedPathData
        '
        Me.ucrInputSavedPathData.AddQuotesIfUnrecognised = True
        Me.ucrInputSavedPathData.AutoSize = True
        Me.ucrInputSavedPathData.IsMultiline = False
        Me.ucrInputSavedPathData.IsReadOnly = False
        Me.ucrInputSavedPathData.Location = New System.Drawing.Point(446, 27)
        Me.ucrInputSavedPathData.Name = "ucrInputSavedPathData"
        Me.ucrInputSavedPathData.Size = New System.Drawing.Size(258, 21)
        Me.ucrInputSavedPathData.TabIndex = 12
        '
        'grpEndChoice
        '
        Me.grpEndChoice.Controls.Add(Me.rdoNeither)
        Me.grpEndChoice.Controls.Add(Me.rdoLoadBackupData)
        Me.grpEndChoice.Controls.Add(Me.rdoRunBackupLog)
        Me.grpEndChoice.Location = New System.Drawing.Point(222, 221)
        Me.grpEndChoice.Name = "grpEndChoice"
        Me.grpEndChoice.Size = New System.Drawing.Size(394, 66)
        Me.grpEndChoice.TabIndex = 23
        Me.grpEndChoice.TabStop = False
        Me.grpEndChoice.Text = "Choose one of the following to proceed"
        '
        'ucrChkSendInternalLog
        '
        Me.ucrChkSendInternalLog.AutoSize = True
        Me.ucrChkSendInternalLog.Checked = False
        Me.ucrChkSendInternalLog.Location = New System.Drawing.Point(36, 195)
        Me.ucrChkSendInternalLog.Name = "ucrChkSendInternalLog"
        Me.ucrChkSendInternalLog.Size = New System.Drawing.Size(266, 23)
        Me.ucrChkSendInternalLog.TabIndex = 21
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(208, 298)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 24
        '
        'ucrChkShowDataFile
        '
        Me.ucrChkShowDataFile.AutoSize = True
        Me.ucrChkShowDataFile.Checked = False
        Me.ucrChkShowDataFile.Location = New System.Drawing.Point(6, 25)
        Me.ucrChkShowDataFile.Name = "ucrChkShowDataFile"
        Me.ucrChkShowDataFile.Size = New System.Drawing.Size(216, 23)
        Me.ucrChkShowDataFile.TabIndex = 25
        '
        'ucrChkShowLogFile
        '
        Me.ucrChkShowLogFile.AutoSize = True
        Me.ucrChkShowLogFile.Checked = False
        Me.ucrChkShowLogFile.Location = New System.Drawing.Point(6, 74)
        Me.ucrChkShowLogFile.Name = "ucrChkShowLogFile"
        Me.ucrChkShowLogFile.Size = New System.Drawing.Size(216, 23)
        Me.ucrChkShowLogFile.TabIndex = 26
        '
        'ucrChkShowInternalLogFile
        '
        Me.ucrChkShowInternalLogFile.AutoSize = True
        Me.ucrChkShowInternalLogFile.Checked = False
        Me.ucrChkShowInternalLogFile.Location = New System.Drawing.Point(6, 117)
        Me.ucrChkShowInternalLogFile.Name = "ucrChkShowInternalLogFile"
        Me.ucrChkShowInternalLogFile.Size = New System.Drawing.Size(216, 23)
        Me.ucrChkShowInternalLogFile.TabIndex = 27
        '
        'rdoRunBackupLog
        '
        Me.rdoRunBackupLog.AutoSize = True
        Me.rdoRunBackupLog.Location = New System.Drawing.Point(25, 30)
        Me.rdoRunBackupLog.Name = "rdoRunBackupLog"
        Me.rdoRunBackupLog.Size = New System.Drawing.Size(106, 17)
        Me.rdoRunBackupLog.TabIndex = 42
        Me.rdoRunBackupLog.TabStop = True
        Me.rdoRunBackupLog.Text = "Run Backup Log"
        Me.rdoRunBackupLog.UseVisualStyleBackColor = True
        '
        'rdoLoadBackupData
        '
        Me.rdoLoadBackupData.AutoSize = True
        Me.rdoLoadBackupData.Location = New System.Drawing.Point(151, 30)
        Me.rdoLoadBackupData.Name = "rdoLoadBackupData"
        Me.rdoLoadBackupData.Size = New System.Drawing.Size(115, 17)
        Me.rdoLoadBackupData.TabIndex = 43
        Me.rdoLoadBackupData.TabStop = True
        Me.rdoLoadBackupData.Text = "Load Backup Data"
        Me.rdoLoadBackupData.UseVisualStyleBackColor = True
        '
        'rdoNeither
        '
        Me.rdoNeither.AutoSize = True
        Me.rdoNeither.Location = New System.Drawing.Point(297, 30)
        Me.rdoNeither.Name = "rdoNeither"
        Me.rdoNeither.Size = New System.Drawing.Size(59, 17)
        Me.rdoNeither.TabIndex = 44
        Me.rdoNeither.TabStop = True
        Me.rdoNeither.Text = "Neither"
        Me.rdoNeither.UseVisualStyleBackColor = True
        '
        'dlgRestoreBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(748, 359)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpEndChoice)
        Me.Controls.Add(Me.ucrChkSendInternalLog)
        Me.Controls.Add(Me.grpSavingOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRestoreBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restore Backup"
        Me.grpSavingOptions.ResumeLayout(False)
        Me.grpSavingOptions.PerformLayout()
        Me.grpEndChoice.ResumeLayout(False)
        Me.grpEndChoice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSavingOptions As GroupBox
    Friend WithEvents cmdSaveLog As Button
    Friend WithEvents ucrInputSavedPathInternalLog As ucrInputTextBox
    Friend WithEvents lblInternalLogSavedTo As Label
    Friend WithEvents cmdSaveInternalLog As Button
    Friend WithEvents ucrInputSavedPathLog As ucrInputTextBox
    Friend WithEvents cmdSaveData As Button
    Friend WithEvents lblLogSavedTo As Label
    Friend WithEvents lblDataSavedTo As Label
    Friend WithEvents ucrInputSavedPathData As ucrInputTextBox
    Friend WithEvents grpEndChoice As GroupBox
    Friend WithEvents ucrChkSendInternalLog As ucrCheck
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkShowDataFile As ucrCheck
    Friend WithEvents ucrChkShowInternalLogFile As ucrCheck
    Friend WithEvents ucrChkShowLogFile As ucrCheck
    Friend WithEvents rdoNeither As RadioButton
    Friend WithEvents rdoLoadBackupData As RadioButton
    Friend WithEvents rdoRunBackupLog As RadioButton
End Class
