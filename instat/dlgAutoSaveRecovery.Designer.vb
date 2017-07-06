' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgAutoSaveRecovery
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
        Me.lblAutoRecoverMessage = New System.Windows.Forms.Label()
        Me.cmdRunLog = New System.Windows.Forms.Button()
        Me.cmdNewSession = New System.Windows.Forms.Button()
        Me.cmdLoadData = New System.Windows.Forms.Button()
        Me.lblBackupLogDetected = New System.Windows.Forms.Label()
        Me.cmdSaveLog = New System.Windows.Forms.Button()
        Me.cmdSaveInternalLog = New System.Windows.Forms.Button()
        Me.lblBackupInternalLogDetected = New System.Windows.Forms.Label()
        Me.cmdSaveData = New System.Windows.Forms.Button()
        Me.lblBackupDataDetected = New System.Windows.Forms.Label()
        Me.lblDataSavedTo = New System.Windows.Forms.Label()
        Me.ucrInputSavedPathData = New instat.ucrInputTextBox()
        Me.ucrInputSavedPathLog = New instat.ucrInputTextBox()
        Me.lblLogSavedTo = New System.Windows.Forms.Label()
        Me.ucrInputSavedPathInternalLog = New instat.ucrInputTextBox()
        Me.lblInternalLogSavedTo = New System.Windows.Forms.Label()
        Me.ucrChkSendInternalLog = New instat.ucrCheck()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.grpSavingOptions = New System.Windows.Forms.GroupBox()
        Me.grpEndChoice = New System.Windows.Forms.GroupBox()
        Me.grpSavingOptions.SuspendLayout()
        Me.grpEndChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAutoRecoverMessage
        '
        Me.lblAutoRecoverMessage.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAutoRecoverMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutoRecoverMessage.Location = New System.Drawing.Point(0, 0)
        Me.lblAutoRecoverMessage.Name = "lblAutoRecoverMessage"
        Me.lblAutoRecoverMessage.Size = New System.Drawing.Size(762, 91)
        Me.lblAutoRecoverMessage.TabIndex = 0
        Me.lblAutoRecoverMessage.Text = "We have detected that R-Instat may have closed unexpectedly." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Below are your auto" &
    " recovery options."
        Me.lblAutoRecoverMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdRunLog
        '
        Me.cmdRunLog.Location = New System.Drawing.Point(39, 24)
        Me.cmdRunLog.Name = "cmdRunLog"
        Me.cmdRunLog.Size = New System.Drawing.Size(131, 29)
        Me.cmdRunLog.TabIndex = 1
        Me.cmdRunLog.Text = "Run Backup Log"
        Me.cmdRunLog.UseVisualStyleBackColor = True
        '
        'cmdNewSession
        '
        Me.cmdNewSession.Location = New System.Drawing.Point(341, 24)
        Me.cmdNewSession.Name = "cmdNewSession"
        Me.cmdNewSession.Size = New System.Drawing.Size(131, 29)
        Me.cmdNewSession.TabIndex = 2
        Me.cmdNewSession.Text = "Start New Session"
        Me.cmdNewSession.UseVisualStyleBackColor = True
        '
        'cmdLoadData
        '
        Me.cmdLoadData.Location = New System.Drawing.Point(190, 24)
        Me.cmdLoadData.Name = "cmdLoadData"
        Me.cmdLoadData.Size = New System.Drawing.Size(131, 29)
        Me.cmdLoadData.TabIndex = 3
        Me.cmdLoadData.Text = "Load Backup Data"
        Me.cmdLoadData.UseVisualStyleBackColor = True
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
        Me.cmdSaveLog.Location = New System.Drawing.Point(203, 68)
        Me.cmdSaveLog.Name = "cmdSaveLog"
        Me.cmdSaveLog.Size = New System.Drawing.Size(176, 29)
        Me.cmdSaveLog.TabIndex = 5
        Me.cmdSaveLog.Text = "Save Backup Log..."
        Me.cmdSaveLog.UseVisualStyleBackColor = True
        '
        'cmdSaveInternalLog
        '
        Me.cmdSaveInternalLog.Location = New System.Drawing.Point(203, 115)
        Me.cmdSaveInternalLog.Name = "cmdSaveInternalLog"
        Me.cmdSaveInternalLog.Size = New System.Drawing.Size(176, 29)
        Me.cmdSaveInternalLog.TabIndex = 7
        Me.cmdSaveInternalLog.Text = "Save Backup Internal Log..."
        Me.cmdSaveInternalLog.UseVisualStyleBackColor = True
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
        'cmdSaveData
        '
        Me.cmdSaveData.Location = New System.Drawing.Point(203, 21)
        Me.cmdSaveData.Name = "cmdSaveData"
        Me.cmdSaveData.Size = New System.Drawing.Size(176, 29)
        Me.cmdSaveData.TabIndex = 9
        Me.cmdSaveData.Text = "Save Backup Data..."
        Me.cmdSaveData.UseVisualStyleBackColor = True
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
        'lblDataSavedTo
        '
        Me.lblDataSavedTo.AutoSize = True
        Me.lblDataSavedTo.Location = New System.Drawing.Point(398, 29)
        Me.lblDataSavedTo.Name = "lblDataSavedTo"
        Me.lblDataSavedTo.Size = New System.Drawing.Size(55, 13)
        Me.lblDataSavedTo.TabIndex = 11
        Me.lblDataSavedTo.Text = "Saving at:"
        '
        'ucrInputSavedPathData
        '
        Me.ucrInputSavedPathData.AddQuotesIfUnrecognised = True
        Me.ucrInputSavedPathData.IsMultiline = False
        Me.ucrInputSavedPathData.IsReadOnly = False
        Me.ucrInputSavedPathData.Location = New System.Drawing.Point(468, 27)
        Me.ucrInputSavedPathData.Name = "ucrInputSavedPathData"
        Me.ucrInputSavedPathData.Size = New System.Drawing.Size(258, 21)
        Me.ucrInputSavedPathData.TabIndex = 12
        '
        'ucrInputSavedPathLog
        '
        Me.ucrInputSavedPathLog.AddQuotesIfUnrecognised = True
        Me.ucrInputSavedPathLog.IsMultiline = False
        Me.ucrInputSavedPathLog.IsReadOnly = False
        Me.ucrInputSavedPathLog.Location = New System.Drawing.Point(468, 76)
        Me.ucrInputSavedPathLog.Name = "ucrInputSavedPathLog"
        Me.ucrInputSavedPathLog.Size = New System.Drawing.Size(258, 21)
        Me.ucrInputSavedPathLog.TabIndex = 14
        '
        'lblLogSavedTo
        '
        Me.lblLogSavedTo.AutoSize = True
        Me.lblLogSavedTo.Location = New System.Drawing.Point(398, 78)
        Me.lblLogSavedTo.Name = "lblLogSavedTo"
        Me.lblLogSavedTo.Size = New System.Drawing.Size(55, 13)
        Me.lblLogSavedTo.TabIndex = 13
        Me.lblLogSavedTo.Text = "Saving at:"
        '
        'ucrInputSavedPathInternalLog
        '
        Me.ucrInputSavedPathInternalLog.AddQuotesIfUnrecognised = True
        Me.ucrInputSavedPathInternalLog.IsMultiline = False
        Me.ucrInputSavedPathInternalLog.IsReadOnly = False
        Me.ucrInputSavedPathInternalLog.Location = New System.Drawing.Point(468, 123)
        Me.ucrInputSavedPathInternalLog.Name = "ucrInputSavedPathInternalLog"
        Me.ucrInputSavedPathInternalLog.Size = New System.Drawing.Size(258, 21)
        Me.ucrInputSavedPathInternalLog.TabIndex = 16
        '
        'lblInternalLogSavedTo
        '
        Me.lblInternalLogSavedTo.AutoSize = True
        Me.lblInternalLogSavedTo.Location = New System.Drawing.Point(398, 125)
        Me.lblInternalLogSavedTo.Name = "lblInternalLogSavedTo"
        Me.lblInternalLogSavedTo.Size = New System.Drawing.Size(55, 13)
        Me.lblInternalLogSavedTo.TabIndex = 15
        Me.lblInternalLogSavedTo.Text = "Saving at:"
        '
        'ucrChkSendInternalLog
        '
        Me.ucrChkSendInternalLog.Checked = False
        Me.ucrChkSendInternalLog.Location = New System.Drawing.Point(12, 254)
        Me.ucrChkSendInternalLog.Name = "ucrChkSendInternalLog"
        Me.ucrChkSendInternalLog.Size = New System.Drawing.Size(266, 20)
        Me.ucrChkSendInternalLog.TabIndex = 17
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(660, 254)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(78, 29)
        Me.cmdHelp.TabIndex = 18
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
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
        Me.grpSavingOptions.Location = New System.Drawing.Point(12, 85)
        Me.grpSavingOptions.Name = "grpSavingOptions"
        Me.grpSavingOptions.Size = New System.Drawing.Size(738, 154)
        Me.grpSavingOptions.TabIndex = 19
        Me.grpSavingOptions.TabStop = False
        Me.grpSavingOptions.Text = "Saving Options"
        '
        'grpEndChoice
        '
        Me.grpEndChoice.Controls.Add(Me.cmdRunLog)
        Me.grpEndChoice.Controls.Add(Me.cmdNewSession)
        Me.grpEndChoice.Controls.Add(Me.cmdLoadData)
        Me.grpEndChoice.Location = New System.Drawing.Point(124, 294)
        Me.grpEndChoice.Name = "grpEndChoice"
        Me.grpEndChoice.Size = New System.Drawing.Size(509, 66)
        Me.grpEndChoice.TabIndex = 20
        Me.grpEndChoice.TabStop = False
        Me.grpEndChoice.Text = "Choose one of the following to proceed"
        '
        'dlgAutoSaveRecovery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 371)
        Me.Controls.Add(Me.grpEndChoice)
        Me.Controls.Add(Me.grpSavingOptions)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.ucrChkSendInternalLog)
        Me.Controls.Add(Me.lblAutoRecoverMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAutoSaveRecovery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Save Recovery Options"
        Me.grpSavingOptions.ResumeLayout(False)
        Me.grpSavingOptions.PerformLayout()
        Me.grpEndChoice.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblAutoRecoverMessage As Label
    Friend WithEvents cmdRunLog As Button
    Friend WithEvents cmdNewSession As Button
    Friend WithEvents cmdLoadData As Button
    Friend WithEvents lblBackupLogDetected As Label
    Friend WithEvents cmdSaveLog As Button
    Friend WithEvents cmdSaveInternalLog As Button
    Friend WithEvents lblBackupInternalLogDetected As Label
    Friend WithEvents cmdSaveData As Button
    Friend WithEvents lblBackupDataDetected As Label
    Friend WithEvents lblDataSavedTo As Label
    Friend WithEvents ucrInputSavedPathData As ucrInputTextBox
    Friend WithEvents ucrInputSavedPathLog As ucrInputTextBox
    Friend WithEvents lblLogSavedTo As Label
    Friend WithEvents ucrInputSavedPathInternalLog As ucrInputTextBox
    Friend WithEvents lblInternalLogSavedTo As Label
    Friend WithEvents ucrChkSendInternalLog As ucrCheck
    Friend WithEvents cmdHelp As Button
    Friend WithEvents grpSavingOptions As GroupBox
    Friend WithEvents grpEndChoice As GroupBox
End Class
