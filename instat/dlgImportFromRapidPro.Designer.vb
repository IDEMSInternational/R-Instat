<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgImportFromRapidPro
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
        Me.ucrPnlImportFromRapidPro = New instat.UcrPanel()
        Me.rdoUserData = New System.Windows.Forms.RadioButton()
        Me.rdoFlowData = New System.Windows.Forms.RadioButton()
        Me.lblRapidProSite = New System.Windows.Forms.Label()
        Me.ucrInputRapidProSite = New instat.ucrInputTextBox()
        Me.cmdSetToken = New System.Windows.Forms.Button()
        Me.ucrChkFlattenData = New instat.ucrCheck()
        Me.ucrChkSetStartDate = New instat.ucrCheck()
        Me.ucrChkSetEndDate = New instat.ucrCheck()
        Me.lblDateFormat = New System.Windows.Forms.Label()
        Me.lblTimezone = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputDateFormat = New instat.ucrInputComboBox()
        Me.ucrInputTimezone = New instat.ucrInputComboBox()
        Me.ucrInputStartDate = New instat.ucrInputTextBox()
        Me.ucrInputEndDate = New instat.ucrInputTextBox()
        Me.ucrSaveDataframeName = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'ucrPnlImportFromRapidPro
        '
        Me.ucrPnlImportFromRapidPro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlImportFromRapidPro.Location = New System.Drawing.Point(70, 18)
        Me.ucrPnlImportFromRapidPro.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlImportFromRapidPro.Name = "ucrPnlImportFromRapidPro"
        Me.ucrPnlImportFromRapidPro.Size = New System.Drawing.Size(448, 46)
        Me.ucrPnlImportFromRapidPro.TabIndex = 0
        '
        'rdoUserData
        '
        Me.rdoUserData.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoUserData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUserData.FlatAppearance.BorderSize = 2
        Me.rdoUserData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoUserData.Location = New System.Drawing.Point(135, 22)
        Me.rdoUserData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoUserData.Name = "rdoUserData"
        Me.rdoUserData.Size = New System.Drawing.Size(168, 43)
        Me.rdoUserData.TabIndex = 1
        Me.rdoUserData.TabStop = True
        Me.rdoUserData.Text = "User Data"
        Me.rdoUserData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoUserData.UseVisualStyleBackColor = True
        '
        'rdoFlowData
        '
        Me.rdoFlowData.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFlowData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFlowData.FlatAppearance.BorderSize = 2
        Me.rdoFlowData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFlowData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFlowData.Location = New System.Drawing.Point(300, 22)
        Me.rdoFlowData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoFlowData.Name = "rdoFlowData"
        Me.rdoFlowData.Size = New System.Drawing.Size(168, 43)
        Me.rdoFlowData.TabIndex = 2
        Me.rdoFlowData.TabStop = True
        Me.rdoFlowData.Text = "Flow Data"
        Me.rdoFlowData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFlowData.UseVisualStyleBackColor = True
        '
        'lblRapidProSite
        '
        Me.lblRapidProSite.AutoSize = True
        Me.lblRapidProSite.Location = New System.Drawing.Point(13, 100)
        Me.lblRapidProSite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRapidProSite.Name = "lblRapidProSite"
        Me.lblRapidProSite.Size = New System.Drawing.Size(41, 20)
        Me.lblRapidProSite.TabIndex = 3
        Me.lblRapidProSite.Text = "Site:"
        '
        'ucrInputRapidProSite
        '
        Me.ucrInputRapidProSite.AddQuotesIfUnrecognised = True
        Me.ucrInputRapidProSite.AutoSize = True
        Me.ucrInputRapidProSite.IsMultiline = False
        Me.ucrInputRapidProSite.IsReadOnly = False
        Me.ucrInputRapidProSite.Location = New System.Drawing.Point(72, 95)
        Me.ucrInputRapidProSite.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputRapidProSite.Name = "ucrInputRapidProSite"
        Me.ucrInputRapidProSite.Size = New System.Drawing.Size(452, 32)
        Me.ucrInputRapidProSite.TabIndex = 4
        '
        'cmdSetToken
        '
        Me.cmdSetToken.Location = New System.Drawing.Point(72, 134)
        Me.cmdSetToken.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSetToken.Name = "cmdSetToken"
        Me.cmdSetToken.Size = New System.Drawing.Size(202, 35)
        Me.cmdSetToken.TabIndex = 5
        Me.cmdSetToken.Text = "Set Token"
        Me.cmdSetToken.UseVisualStyleBackColor = True
        '
        'ucrChkFlattenData
        '
        Me.ucrChkFlattenData.AutoSize = True
        Me.ucrChkFlattenData.Checked = False
        Me.ucrChkFlattenData.Location = New System.Drawing.Point(10, 183)
        Me.ucrChkFlattenData.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkFlattenData.Name = "ucrChkFlattenData"
        Me.ucrChkFlattenData.Size = New System.Drawing.Size(170, 35)
        Me.ucrChkFlattenData.TabIndex = 6
        '
        'ucrChkSetStartDate
        '
        Me.ucrChkSetStartDate.AutoSize = True
        Me.ucrChkSetStartDate.Checked = False
        Me.ucrChkSetStartDate.Location = New System.Drawing.Point(10, 225)
        Me.ucrChkSetStartDate.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkSetStartDate.Name = "ucrChkSetStartDate"
        Me.ucrChkSetStartDate.Size = New System.Drawing.Size(192, 35)
        Me.ucrChkSetStartDate.TabIndex = 7
        '
        'ucrChkSetEndDate
        '
        Me.ucrChkSetEndDate.AutoSize = True
        Me.ucrChkSetEndDate.Checked = False
        Me.ucrChkSetEndDate.Location = New System.Drawing.Point(10, 266)
        Me.ucrChkSetEndDate.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkSetEndDate.Name = "ucrChkSetEndDate"
        Me.ucrChkSetEndDate.Size = New System.Drawing.Size(170, 35)
        Me.ucrChkSetEndDate.TabIndex = 9
        '
        'lblDateFormat
        '
        Me.lblDateFormat.AutoSize = True
        Me.lblDateFormat.Location = New System.Drawing.Point(13, 311)
        Me.lblDateFormat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateFormat.Name = "lblDateFormat"
        Me.lblDateFormat.Size = New System.Drawing.Size(103, 20)
        Me.lblDateFormat.TabIndex = 11
        Me.lblDateFormat.Text = "Date Format:"
        '
        'lblTimezone
        '
        Me.lblTimezone.AutoSize = True
        Me.lblTimezone.Location = New System.Drawing.Point(13, 349)
        Me.lblTimezone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimezone.Name = "lblTimezone"
        Me.lblTimezone.Size = New System.Drawing.Size(82, 20)
        Me.lblTimezone.TabIndex = 13
        Me.lblTimezone.Text = "Timezone:"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 436)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(614, 80)
        Me.ucrBase.TabIndex = 16
        '
        'ucrInputDateFormat
        '
        Me.ucrInputDateFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputDateFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDateFormat.GetSetSelectedIndex = -1
        Me.ucrInputDateFormat.IsReadOnly = False
        Me.ucrInputDateFormat.Location = New System.Drawing.Point(172, 309)
        Me.ucrInputDateFormat.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputDateFormat.Name = "ucrInputDateFormat"
        Me.ucrInputDateFormat.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputDateFormat.TabIndex = 12
        '
        'ucrInputTimezone
        '
        Me.ucrInputTimezone.AddQuotesIfUnrecognised = True
        Me.ucrInputTimezone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTimezone.GetSetSelectedIndex = -1
        Me.ucrInputTimezone.IsReadOnly = False
        Me.ucrInputTimezone.Location = New System.Drawing.Point(172, 351)
        Me.ucrInputTimezone.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputTimezone.Name = "ucrInputTimezone"
        Me.ucrInputTimezone.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputTimezone.TabIndex = 14
        '
        'ucrInputStartDate
        '
        Me.ucrInputStartDate.AddQuotesIfUnrecognised = True
        Me.ucrInputStartDate.AutoSize = True
        Me.ucrInputStartDate.IsMultiline = False
        Me.ucrInputStartDate.IsReadOnly = False
        Me.ucrInputStartDate.Location = New System.Drawing.Point(172, 225)
        Me.ucrInputStartDate.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputStartDate.Name = "ucrInputStartDate"
        Me.ucrInputStartDate.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputStartDate.TabIndex = 8
        '
        'ucrInputEndDate
        '
        Me.ucrInputEndDate.AddQuotesIfUnrecognised = True
        Me.ucrInputEndDate.AutoSize = True
        Me.ucrInputEndDate.IsMultiline = False
        Me.ucrInputEndDate.IsReadOnly = False
        Me.ucrInputEndDate.Location = New System.Drawing.Point(172, 266)
        Me.ucrInputEndDate.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputEndDate.Name = "ucrInputEndDate"
        Me.ucrInputEndDate.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputEndDate.TabIndex = 10
        '
        'ucrSaveDataframeName
        '
        Me.ucrSaveDataframeName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDataframeName.Location = New System.Drawing.Point(10, 389)
        Me.ucrSaveDataframeName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveDataframeName.Name = "ucrSaveDataframeName"
        Me.ucrSaveDataframeName.Size = New System.Drawing.Size(405, 36)
        Me.ucrSaveDataframeName.TabIndex = 15
        '
        'dlgImportFromRapidPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 531)
        Me.Controls.Add(Me.ucrSaveDataframeName)
        Me.Controls.Add(Me.ucrInputEndDate)
        Me.Controls.Add(Me.ucrInputStartDate)
        Me.Controls.Add(Me.ucrInputTimezone)
        Me.Controls.Add(Me.ucrInputDateFormat)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblTimezone)
        Me.Controls.Add(Me.lblDateFormat)
        Me.Controls.Add(Me.ucrChkSetEndDate)
        Me.Controls.Add(Me.ucrChkSetStartDate)
        Me.Controls.Add(Me.ucrChkFlattenData)
        Me.Controls.Add(Me.cmdSetToken)
        Me.Controls.Add(Me.ucrInputRapidProSite)
        Me.Controls.Add(Me.lblRapidProSite)
        Me.Controls.Add(Me.rdoFlowData)
        Me.Controls.Add(Me.rdoUserData)
        Me.Controls.Add(Me.ucrPnlImportFromRapidPro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportFromRapidPro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import from RapidPro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrPnlImportFromRapidPro As UcrPanel
    Friend WithEvents rdoUserData As RadioButton
    Friend WithEvents rdoFlowData As RadioButton
    Friend WithEvents lblRapidProSite As Label
    Friend WithEvents ucrInputRapidProSite As ucrInputTextBox
    Friend WithEvents cmdSetToken As Button
    Friend WithEvents ucrChkFlattenData As ucrCheck
    Friend WithEvents ucrChkSetStartDate As ucrCheck
    Friend WithEvents ucrChkSetEndDate As ucrCheck
    Friend WithEvents lblDateFormat As Label
    Friend WithEvents lblTimezone As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputDateFormat As ucrInputComboBox
    Friend WithEvents ucrInputTimezone As ucrInputComboBox
    Friend WithEvents ucrInputStartDate As ucrInputTextBox
    Friend WithEvents ucrInputEndDate As ucrInputTextBox
    Friend WithEvents ucrSaveDataframeName As ucrSave
End Class
