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
        Me.lblBackupDataDetected = New System.Windows.Forms.Label()
        Me.lblBackupLogDetected = New System.Windows.Forms.Label()
        Me.cmdSaveLog = New System.Windows.Forms.Button()
        Me.ucrInputSavedPathInternalLog = New instat.ucrInputTextBox()
        Me.lblBackupInternalLogDetected = New System.Windows.Forms.Label()
        Me.lblInternalLogSavedTo = New System.Windows.Forms.Label()
        Me.cmdSaveInternalLog = New System.Windows.Forms.Button()
        Me.ucrInputSavedPathLog = New instat.ucrInputTextBox()
        Me.cmdSaveData = New System.Windows.Forms.Button()
        Me.lblLogSavedTo = New System.Windows.Forms.Label()
        Me.lblDataSavedTo = New System.Windows.Forms.Label()
        Me.ucrInputSavedPathData = New instat.ucrInputTextBox()
        Me.grpEndChoice = New System.Windows.Forms.GroupBox()
        Me.cmdRunLog = New System.Windows.Forms.Button()
        Me.cmdCloseSession = New System.Windows.Forms.Button()
        Me.cmdLoadData = New System.Windows.Forms.Button()
        Me.ucrChkSendInternalLog = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpSavingOptions.SuspendLayout()
        Me.grpEndChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSavingOptions
        '
        Me.grpSavingOptions.Controls.Add(Me.lblBackupDataDetected)
        Me.grpSavingOptions.Controls.Add(Me.lblBackupLogDetected)
        Me.grpSavingOptions.Controls.Add(Me.cmdSaveLog)
        Me.grpSavingOptions.Controls.Add(Me.ucrInputSavedPathInternalLog)
        Me.grpSavingOptions.Controls.Add(Me.lblBackupInternalLogDetected)
        Me.grpSavingOptions.Controls.Add(Me.lblInternalLogSavedTo)
        Me.grpSavingOptions.Controls.Add(Me.cmdSaveInternalLog)
        Me.grpSavingOptions.Controls.Add(Me.ucrInputSavedPathLog)
        Me.grpSavingOptions.Controls.Add(Me.cmdSaveData)
        Me.grpSavingOptions.Controls.Add(Me.lblLogSavedTo)
        Me.grpSavingOptions.Controls.Add(Me.lblDataSavedTo)
        Me.grpSavingOptions.Controls.Add(Me.ucrInputSavedPathData)
        Me.grpSavingOptions.Location = New System.Drawing.Point(12, 31)
        Me.grpSavingOptions.Name = "grpSavingOptions"
        Me.grpSavingOptions.Size = New System.Drawing.Size(877, 154)
        Me.grpSavingOptions.TabIndex = 20
        Me.grpSavingOptions.TabStop = False
        Me.grpSavingOptions.Text = "Saving Options"
        '
        'lblBackupDataDetected
        '
        Me.lblBackupDataDetected.AutoSize = True
        Me.lblBackupDataDetected.Location = New System.Drawing.Point(11, 29)
        Me.lblBackupDataDetected.Name = "lblBackupDataDetected"
        Me.lblBackupDataDetected.Size = New System.Drawing.Size(136, 13)
        Me.lblBackupDataDetected.TabIndex = 8
        Me.lblBackupDataDetected.Text = "Backup Data File Detected"
        '
        'lblBackupLogDetected
        '
        Me.lblBackupLogDetected.AutoSize = True
        Me.lblBackupLogDetected.Location = New System.Drawing.Point(11, 76)
        Me.lblBackupLogDetected.Name = "lblBackupLogDetected"
        Me.lblBackupLogDetected.Size = New System.Drawing.Size(131, 13)
        Me.lblBackupLogDetected.TabIndex = 4
        Me.lblBackupLogDetected.Text = "Backup Log File Detected"
        '
        'cmdSaveLog
        '
        Me.cmdSaveLog.Location = New System.Drawing.Point(261, 68)
        Me.cmdSaveLog.Name = "cmdSaveLog"
        Me.cmdSaveLog.Size = New System.Drawing.Size(241, 29)
        Me.cmdSaveLog.TabIndex = 5
        Me.cmdSaveLog.Text = "Save Backup Log..."
        Me.cmdSaveLog.UseVisualStyleBackColor = True
        '
        'ucrInputSavedPathInternalLog
        '
        Me.ucrInputSavedPathInternalLog.AddQuotesIfUnrecognised = True
        Me.ucrInputSavedPathInternalLog.AutoSize = True
        Me.ucrInputSavedPathInternalLog.IsMultiline = False
        Me.ucrInputSavedPathInternalLog.IsReadOnly = False
        Me.ucrInputSavedPathInternalLog.Location = New System.Drawing.Point(605, 123)
        Me.ucrInputSavedPathInternalLog.Name = "ucrInputSavedPathInternalLog"
        Me.ucrInputSavedPathInternalLog.Size = New System.Drawing.Size(258, 21)
        Me.ucrInputSavedPathInternalLog.TabIndex = 16
        '
        'lblBackupInternalLogDetected
        '
        Me.lblBackupInternalLogDetected.AutoSize = True
        Me.lblBackupInternalLogDetected.Location = New System.Drawing.Point(11, 123)
        Me.lblBackupInternalLogDetected.Name = "lblBackupInternalLogDetected"
        Me.lblBackupInternalLogDetected.Size = New System.Drawing.Size(169, 13)
        Me.lblBackupInternalLogDetected.TabIndex = 6
        Me.lblBackupInternalLogDetected.Text = "Backup Internal Log File Detected"
        '
        'lblInternalLogSavedTo
        '
        Me.lblInternalLogSavedTo.AutoSize = True
        Me.lblInternalLogSavedTo.Location = New System.Drawing.Point(509, 125)
        Me.lblInternalLogSavedTo.Name = "lblInternalLogSavedTo"
        Me.lblInternalLogSavedTo.Size = New System.Drawing.Size(55, 13)
        Me.lblInternalLogSavedTo.TabIndex = 15
        Me.lblInternalLogSavedTo.Text = "Saving at:"
        '
        'cmdSaveInternalLog
        '
        Me.cmdSaveInternalLog.Location = New System.Drawing.Point(262, 115)
        Me.cmdSaveInternalLog.Name = "cmdSaveInternalLog"
        Me.cmdSaveInternalLog.Size = New System.Drawing.Size(240, 29)
        Me.cmdSaveInternalLog.TabIndex = 7
        Me.cmdSaveInternalLog.Text = "Save Backup Internal Log..."
        Me.cmdSaveInternalLog.UseVisualStyleBackColor = True
        '
        'ucrInputSavedPathLog
        '
        Me.ucrInputSavedPathLog.AddQuotesIfUnrecognised = True
        Me.ucrInputSavedPathLog.AutoSize = True
        Me.ucrInputSavedPathLog.IsMultiline = False
        Me.ucrInputSavedPathLog.IsReadOnly = False
        Me.ucrInputSavedPathLog.Location = New System.Drawing.Point(604, 76)
        Me.ucrInputSavedPathLog.Name = "ucrInputSavedPathLog"
        Me.ucrInputSavedPathLog.Size = New System.Drawing.Size(258, 21)
        Me.ucrInputSavedPathLog.TabIndex = 14
        '
        'cmdSaveData
        '
        Me.cmdSaveData.Location = New System.Drawing.Point(262, 21)
        Me.cmdSaveData.Name = "cmdSaveData"
        Me.cmdSaveData.Size = New System.Drawing.Size(240, 29)
        Me.cmdSaveData.TabIndex = 9
        Me.cmdSaveData.Text = "Save Backup Data..."
        Me.cmdSaveData.UseVisualStyleBackColor = True
        '
        'lblLogSavedTo
        '
        Me.lblLogSavedTo.AutoSize = True
        Me.lblLogSavedTo.Location = New System.Drawing.Point(509, 78)
        Me.lblLogSavedTo.Name = "lblLogSavedTo"
        Me.lblLogSavedTo.Size = New System.Drawing.Size(55, 13)
        Me.lblLogSavedTo.TabIndex = 13
        Me.lblLogSavedTo.Text = "Saving at:"
        '
        'lblDataSavedTo
        '
        Me.lblDataSavedTo.AutoSize = True
        Me.lblDataSavedTo.Location = New System.Drawing.Point(508, 29)
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
        Me.ucrInputSavedPathData.Location = New System.Drawing.Point(604, 27)
        Me.ucrInputSavedPathData.Name = "ucrInputSavedPathData"
        Me.ucrInputSavedPathData.Size = New System.Drawing.Size(258, 21)
        Me.ucrInputSavedPathData.TabIndex = 12
        '
        'grpEndChoice
        '
        Me.grpEndChoice.Controls.Add(Me.cmdRunLog)
        Me.grpEndChoice.Controls.Add(Me.cmdCloseSession)
        Me.grpEndChoice.Controls.Add(Me.cmdLoadData)
        Me.grpEndChoice.Location = New System.Drawing.Point(131, 221)
        Me.grpEndChoice.Name = "grpEndChoice"
        Me.grpEndChoice.Size = New System.Drawing.Size(602, 66)
        Me.grpEndChoice.TabIndex = 23
        Me.grpEndChoice.TabStop = False
        Me.grpEndChoice.Text = "Choose one of the following to proceed"
        '
        'cmdRunLog
        '
        Me.cmdRunLog.Location = New System.Drawing.Point(11, 24)
        Me.cmdRunLog.Name = "cmdRunLog"
        Me.cmdRunLog.Size = New System.Drawing.Size(190, 29)
        Me.cmdRunLog.TabIndex = 1
        Me.cmdRunLog.Text = "Run Backup Log"
        Me.cmdRunLog.UseVisualStyleBackColor = True
        '
        'cmdCloseSession
        '
        Me.cmdCloseSession.Location = New System.Drawing.Point(415, 24)
        Me.cmdCloseSession.Name = "cmdCloseSession"
        Me.cmdCloseSession.Size = New System.Drawing.Size(181, 29)
        Me.cmdCloseSession.TabIndex = 2
        Me.cmdCloseSession.Text = "Close"
        Me.cmdCloseSession.UseVisualStyleBackColor = True
        '
        'cmdLoadData
        '
        Me.cmdLoadData.Location = New System.Drawing.Point(213, 24)
        Me.cmdLoadData.Name = "cmdLoadData"
        Me.cmdLoadData.Size = New System.Drawing.Size(195, 29)
        Me.cmdLoadData.TabIndex = 3
        Me.cmdLoadData.Text = "Load Backup Data"
        Me.cmdLoadData.UseVisualStyleBackColor = True
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
        'dlgRestoreBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 359)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSavingOptions As GroupBox
    Friend WithEvents lblBackupDataDetected As Label
    Friend WithEvents lblBackupLogDetected As Label
    Friend WithEvents cmdSaveLog As Button
    Friend WithEvents ucrInputSavedPathInternalLog As ucrInputTextBox
    Friend WithEvents lblBackupInternalLogDetected As Label
    Friend WithEvents lblInternalLogSavedTo As Label
    Friend WithEvents cmdSaveInternalLog As Button
    Friend WithEvents ucrInputSavedPathLog As ucrInputTextBox
    Friend WithEvents cmdSaveData As Button
    Friend WithEvents lblLogSavedTo As Label
    Friend WithEvents lblDataSavedTo As Label
    Friend WithEvents ucrInputSavedPathData As ucrInputTextBox
    Friend WithEvents grpEndChoice As GroupBox
    Friend WithEvents cmdRunLog As Button
    Friend WithEvents cmdCloseSession As Button
    Friend WithEvents cmdLoadData As Button
    Friend WithEvents ucrChkSendInternalLog As ucrCheck
    Friend WithEvents ucrBase As ucrButtons
End Class
