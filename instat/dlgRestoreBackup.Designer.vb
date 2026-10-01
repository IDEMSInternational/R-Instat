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
        Me.ucrInputSavedPathInternalLog = New instat.ucrFilePath()
        Me.ucrInputSavedPathLog = New instat.ucrFilePath()
        Me.ucrInputSavedPathData = New instat.ucrFilePath()
        Me.ucrChkShowInternalLogFile = New instat.ucrCheck()
        Me.ucrChkShowLogFile = New instat.ucrCheck()
        Me.ucrChkShowDataFile = New instat.ucrCheck()
        Me.grpEndChoice = New System.Windows.Forms.GroupBox()
        Me.rdoNeither = New System.Windows.Forms.RadioButton()
        Me.rdoLoadBackupData = New System.Windows.Forms.RadioButton()
        Me.rdoRunBackupLog = New System.Windows.Forms.RadioButton()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkSendInternalLog = New instat.ucrCheck()
        Me.ucrPnlRecoveryOption = New instat.UcrPanel()
        Me.grpSavingOptions.SuspendLayout()
        Me.grpEndChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSavingOptions
        '
        Me.grpSavingOptions.Controls.Add(Me.ucrInputSavedPathInternalLog)
        Me.grpSavingOptions.Controls.Add(Me.ucrInputSavedPathLog)
        Me.grpSavingOptions.Controls.Add(Me.ucrInputSavedPathData)
        Me.grpSavingOptions.Controls.Add(Me.ucrChkShowInternalLogFile)
        Me.grpSavingOptions.Controls.Add(Me.ucrChkShowLogFile)
        Me.grpSavingOptions.Controls.Add(Me.ucrChkShowDataFile)
        Me.grpSavingOptions.Location = New System.Drawing.Point(12, 16)
        Me.grpSavingOptions.Name = "grpSavingOptions"
        Me.grpSavingOptions.Size = New System.Drawing.Size(604, 154)
        Me.grpSavingOptions.TabIndex = 20
        Me.grpSavingOptions.TabStop = False
        Me.grpSavingOptions.Text = "Saving Options"
        '
        'ucrInputSavedPathInternalLog
        '
        Me.ucrInputSavedPathInternalLog.AutoSize = True
        Me.ucrInputSavedPathInternalLog.DefaultFileSuggestionName = ""
        Me.ucrInputSavedPathInternalLog.FilePath = ""
        Me.ucrInputSavedPathInternalLog.FilePathBrowseText = "Browse"
        Me.ucrInputSavedPathInternalLog.FilePathDialogFilter = "R file (*.R)|*.R"
        Me.ucrInputSavedPathInternalLog.FilePathDialogTitle = "Save R File"
        Me.ucrInputSavedPathInternalLog.FilePathLabel = "Save As:"
        Me.ucrInputSavedPathInternalLog.FolderBrowse = False
        Me.ucrInputSavedPathInternalLog.Location = New System.Drawing.Point(222, 115)
        Me.ucrInputSavedPathInternalLog.Name = "ucrInputSavedPathInternalLog"
        Me.ucrInputSavedPathInternalLog.SelectedFileFilterIndex = 1
        Me.ucrInputSavedPathInternalLog.Size = New System.Drawing.Size(380, 34)
        Me.ucrInputSavedPathInternalLog.TabIndex = 29
        '
        'ucrInputSavedPathLog
        '
        Me.ucrInputSavedPathLog.AutoSize = True
        Me.ucrInputSavedPathLog.DefaultFileSuggestionName = ""
        Me.ucrInputSavedPathLog.FilePath = ""
        Me.ucrInputSavedPathLog.FilePathBrowseText = "Browse"
        Me.ucrInputSavedPathLog.FilePathDialogFilter = "R file (*.R)|*.R"
        Me.ucrInputSavedPathLog.FilePathDialogTitle = "Save R File"
        Me.ucrInputSavedPathLog.FilePathLabel = "Save As:"
        Me.ucrInputSavedPathLog.FolderBrowse = False
        Me.ucrInputSavedPathLog.Location = New System.Drawing.Point(222, 70)
        Me.ucrInputSavedPathLog.Name = "ucrInputSavedPathLog"
        Me.ucrInputSavedPathLog.SelectedFileFilterIndex = 1
        Me.ucrInputSavedPathLog.Size = New System.Drawing.Size(380, 34)
        Me.ucrInputSavedPathLog.TabIndex = 28
        '
        'ucrInputSavedPathData
        '
        Me.ucrInputSavedPathData.AutoSize = True
        Me.ucrInputSavedPathData.DefaultFileSuggestionName = ""
        Me.ucrInputSavedPathData.FilePath = ""
        Me.ucrInputSavedPathData.FilePathBrowseText = "Browse"
        Me.ucrInputSavedPathData.FilePathDialogFilter = "RDS Data file (*.RDS)|*.RDS"
        Me.ucrInputSavedPathData.FilePathDialogTitle = "Save Data File"
        Me.ucrInputSavedPathData.FilePathLabel = "Save As:"
        Me.ucrInputSavedPathData.FolderBrowse = False
        Me.ucrInputSavedPathData.Location = New System.Drawing.Point(222, 25)
        Me.ucrInputSavedPathData.Name = "ucrInputSavedPathData"
        Me.ucrInputSavedPathData.SelectedFileFilterIndex = 1
        Me.ucrInputSavedPathData.Size = New System.Drawing.Size(380, 34)
        Me.ucrInputSavedPathData.TabIndex = 25
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
        'ucrChkShowLogFile
        '
        Me.ucrChkShowLogFile.AutoSize = True
        Me.ucrChkShowLogFile.Checked = False
        Me.ucrChkShowLogFile.Location = New System.Drawing.Point(6, 74)
        Me.ucrChkShowLogFile.Name = "ucrChkShowLogFile"
        Me.ucrChkShowLogFile.Size = New System.Drawing.Size(216, 23)
        Me.ucrChkShowLogFile.TabIndex = 26
        '
        'ucrChkShowDataFile
        '
        Me.ucrChkShowDataFile.AutoSize = True
        Me.ucrChkShowDataFile.Checked = False
        Me.ucrChkShowDataFile.Location = New System.Drawing.Point(6, 31)
        Me.ucrChkShowDataFile.Name = "ucrChkShowDataFile"
        Me.ucrChkShowDataFile.Size = New System.Drawing.Size(216, 23)
        Me.ucrChkShowDataFile.TabIndex = 25
        '
        'grpEndChoice
        '
        Me.grpEndChoice.Controls.Add(Me.rdoRunBackupLog)
        Me.grpEndChoice.Controls.Add(Me.rdoLoadBackupData)
        Me.grpEndChoice.Controls.Add(Me.rdoNeither)
        Me.grpEndChoice.Controls.Add(Me.ucrPnlRecoveryOption)
        Me.grpEndChoice.Location = New System.Drawing.Point(136, 209)
        Me.grpEndChoice.Name = "grpEndChoice"
        Me.grpEndChoice.Size = New System.Drawing.Size(358, 66)
        Me.grpEndChoice.TabIndex = 23
        Me.grpEndChoice.TabStop = False
        Me.grpEndChoice.Text = "Choose one of the following"
        '
        'rdoNeither
        '
        Me.rdoNeither.AutoSize = True
        Me.rdoNeither.Location = New System.Drawing.Point(272, 30)
        Me.rdoNeither.Name = "rdoNeither"
        Me.rdoNeither.Size = New System.Drawing.Size(59, 17)
        Me.rdoNeither.TabIndex = 44
        Me.rdoNeither.TabStop = True
        Me.rdoNeither.Text = "Neither"
        Me.rdoNeither.UseVisualStyleBackColor = True
        '
        'rdoLoadBackupData
        '
        Me.rdoLoadBackupData.AutoSize = True
        Me.rdoLoadBackupData.Location = New System.Drawing.Point(138, 30)
        Me.rdoLoadBackupData.Name = "rdoLoadBackupData"
        Me.rdoLoadBackupData.Size = New System.Drawing.Size(115, 17)
        Me.rdoLoadBackupData.TabIndex = 43
        Me.rdoLoadBackupData.TabStop = True
        Me.rdoLoadBackupData.Text = "Load Backup Data"
        Me.rdoLoadBackupData.UseVisualStyleBackColor = True
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
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(111, 282)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 24
        '
        'ucrChkSendInternalLog
        '
        Me.ucrChkSendInternalLog.AutoSize = True
        Me.ucrChkSendInternalLog.Checked = False
        Me.ucrChkSendInternalLog.Location = New System.Drawing.Point(23, 177)
        Me.ucrChkSendInternalLog.Name = "ucrChkSendInternalLog"
        Me.ucrChkSendInternalLog.Size = New System.Drawing.Size(266, 23)
        Me.ucrChkSendInternalLog.TabIndex = 21
        '
        'ucrPnlRecoveryOption
        '
        Me.ucrPnlRecoveryOption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRecoveryOption.Location = New System.Drawing.Point(17, 19)
        Me.ucrPnlRecoveryOption.Name = "ucrPnlRecoveryOption"
        Me.ucrPnlRecoveryOption.Size = New System.Drawing.Size(314, 36)
        Me.ucrPnlRecoveryOption.TabIndex = 25
        '
        'dlgRestoreBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(627, 340)
        Me.Controls.Add(Me.grpEndChoice)
        Me.Controls.Add(Me.ucrBase)
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
    Friend WithEvents grpEndChoice As GroupBox
    Friend WithEvents ucrChkSendInternalLog As ucrCheck
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkShowDataFile As ucrCheck
    Friend WithEvents ucrChkShowInternalLogFile As ucrCheck
    Friend WithEvents ucrChkShowLogFile As ucrCheck
    Friend WithEvents rdoNeither As RadioButton
    Friend WithEvents rdoLoadBackupData As RadioButton
    Friend WithEvents rdoRunBackupLog As RadioButton
    Friend WithEvents ucrInputSavedPathData As ucrFilePath
    Friend WithEvents ucrInputSavedPathLog As ucrFilePath
    Friend WithEvents ucrInputSavedPathInternalLog As ucrFilePath
    Friend WithEvents ucrPnlRecoveryOption As UcrPanel
End Class
