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
        Me.rdoUserData = New System.Windows.Forms.RadioButton()
        Me.rdoFlowData = New System.Windows.Forms.RadioButton()
        Me.lblRapidProSite = New System.Windows.Forms.Label()
        Me.cmdSetToken = New System.Windows.Forms.Button()
        Me.lblDateFormat = New System.Windows.Forms.Label()
        Me.lblTimezone = New System.Windows.Forms.Label()
        Me.ucrSaveDataframeName = New instat.ucrSave()
        Me.ucrInputEndDate = New instat.ucrInputTextBox()
        Me.ucrInputStartDate = New instat.ucrInputTextBox()
        Me.ucrInputTimezone = New instat.ucrInputComboBox()
        Me.ucrInputDateFormat = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkSetEndDate = New instat.ucrCheck()
        Me.ucrChkSetStartDate = New instat.ucrCheck()
        Me.ucrChkFlattenData = New instat.ucrCheck()
        Me.ucrInputRapidProSite = New instat.ucrInputTextBox()
        Me.ucrPnlImportFromRapidPro = New instat.UcrPanel()
        Me.ucrChkUser = New instat.ucrCheck()
        Me.ucrChkFlow = New instat.ucrCheck()
        Me.cmdSelectFlows = New System.Windows.Forms.Button()
        Me.grpDataToImport = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
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
        Me.rdoUserData.Text = " Data"
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
        Me.rdoFlowData.Text = "Flow Names"
        Me.rdoFlowData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFlowData.UseVisualStyleBackColor = True
        '
        'lblRapidProSite
        '
        Me.lblRapidProSite.AutoSize = True
        Me.lblRapidProSite.Location = New System.Drawing.Point(6, 97)
        Me.lblRapidProSite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRapidProSite.Name = "lblRapidProSite"
        Me.lblRapidProSite.Size = New System.Drawing.Size(41, 20)
        Me.lblRapidProSite.TabIndex = 3
        Me.lblRapidProSite.Text = "Site:"
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
        'lblDateFormat
        '
        Me.lblDateFormat.AutoSize = True
        Me.lblDateFormat.Location = New System.Drawing.Point(6, 386)
        Me.lblDateFormat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateFormat.Name = "lblDateFormat"
        Me.lblDateFormat.Size = New System.Drawing.Size(103, 20)
        Me.lblDateFormat.TabIndex = 11
        Me.lblDateFormat.Text = "Date Format:"
        '
        'lblTimezone
        '
        Me.lblTimezone.AutoSize = True
        Me.lblTimezone.Location = New System.Drawing.Point(6, 426)
        Me.lblTimezone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimezone.Name = "lblTimezone"
        Me.lblTimezone.Size = New System.Drawing.Size(82, 20)
        Me.lblTimezone.TabIndex = 13
        Me.lblTimezone.Text = "Timezone:"
        '
        'ucrSaveDataframeName
        '
        Me.ucrSaveDataframeName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDataframeName.Location = New System.Drawing.Point(10, 469)
        Me.ucrSaveDataframeName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveDataframeName.Name = "ucrSaveDataframeName"
        Me.ucrSaveDataframeName.Size = New System.Drawing.Size(513, 35)
        Me.ucrSaveDataframeName.TabIndex = 15
        '
        'ucrInputEndDate
        '
        Me.ucrInputEndDate.AddQuotesIfUnrecognised = True
        Me.ucrInputEndDate.AutoSize = True
        Me.ucrInputEndDate.IsMultiline = False
        Me.ucrInputEndDate.IsReadOnly = False
        Me.ucrInputEndDate.Location = New System.Drawing.Point(172, 341)
        Me.ucrInputEndDate.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputEndDate.Name = "ucrInputEndDate"
        Me.ucrInputEndDate.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputEndDate.TabIndex = 10
        '
        'ucrInputStartDate
        '
        Me.ucrInputStartDate.AddQuotesIfUnrecognised = True
        Me.ucrInputStartDate.AutoSize = True
        Me.ucrInputStartDate.IsMultiline = False
        Me.ucrInputStartDate.IsReadOnly = False
        Me.ucrInputStartDate.Location = New System.Drawing.Point(172, 300)
        Me.ucrInputStartDate.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputStartDate.Name = "ucrInputStartDate"
        Me.ucrInputStartDate.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputStartDate.TabIndex = 8
        '
        'ucrInputTimezone
        '
        Me.ucrInputTimezone.AddQuotesIfUnrecognised = True
        Me.ucrInputTimezone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTimezone.GetSetSelectedIndex = -1
        Me.ucrInputTimezone.IsReadOnly = False
        Me.ucrInputTimezone.Location = New System.Drawing.Point(172, 426)
        Me.ucrInputTimezone.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputTimezone.Name = "ucrInputTimezone"
        Me.ucrInputTimezone.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputTimezone.TabIndex = 14
        '
        'ucrInputDateFormat
        '
        Me.ucrInputDateFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputDateFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDateFormat.GetSetSelectedIndex = -1
        Me.ucrInputDateFormat.IsReadOnly = False
        Me.ucrInputDateFormat.Location = New System.Drawing.Point(172, 384)
        Me.ucrInputDateFormat.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputDateFormat.Name = "ucrInputDateFormat"
        Me.ucrInputDateFormat.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputDateFormat.TabIndex = 12
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 510)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(614, 80)
        Me.ucrBase.TabIndex = 16
        '
        'ucrChkSetEndDate
        '
        Me.ucrChkSetEndDate.AutoSize = True
        Me.ucrChkSetEndDate.Checked = False
        Me.ucrChkSetEndDate.Location = New System.Drawing.Point(10, 341)
        Me.ucrChkSetEndDate.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkSetEndDate.Name = "ucrChkSetEndDate"
        Me.ucrChkSetEndDate.Size = New System.Drawing.Size(152, 35)
        Me.ucrChkSetEndDate.TabIndex = 9
        '
        'ucrChkSetStartDate
        '
        Me.ucrChkSetStartDate.AutoSize = True
        Me.ucrChkSetStartDate.Checked = False
        Me.ucrChkSetStartDate.Location = New System.Drawing.Point(10, 300)
        Me.ucrChkSetStartDate.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkSetStartDate.Name = "ucrChkSetStartDate"
        Me.ucrChkSetStartDate.Size = New System.Drawing.Size(152, 35)
        Me.ucrChkSetStartDate.TabIndex = 7
        '
        'ucrChkFlattenData
        '
        Me.ucrChkFlattenData.AutoSize = True
        Me.ucrChkFlattenData.Checked = False
        Me.ucrChkFlattenData.Location = New System.Drawing.Point(10, 258)
        Me.ucrChkFlattenData.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkFlattenData.Name = "ucrChkFlattenData"
        Me.ucrChkFlattenData.Size = New System.Drawing.Size(152, 35)
        Me.ucrChkFlattenData.TabIndex = 6
        '
        'ucrInputRapidProSite
        '
        Me.ucrInputRapidProSite.AddQuotesIfUnrecognised = True
        Me.ucrInputRapidProSite.AutoSize = True
        Me.ucrInputRapidProSite.IsMultiline = False
        Me.ucrInputRapidProSite.IsReadOnly = False
        Me.ucrInputRapidProSite.Location = New System.Drawing.Point(72, 95)
        Me.ucrInputRapidProSite.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputRapidProSite.Name = "ucrInputRapidProSite"
        Me.ucrInputRapidProSite.Size = New System.Drawing.Size(452, 32)
        Me.ucrInputRapidProSite.TabIndex = 4
        '
        'ucrPnlImportFromRapidPro
        '
        Me.ucrPnlImportFromRapidPro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlImportFromRapidPro.Location = New System.Drawing.Point(70, 18)
        Me.ucrPnlImportFromRapidPro.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrPnlImportFromRapidPro.Name = "ucrPnlImportFromRapidPro"
        Me.ucrPnlImportFromRapidPro.Size = New System.Drawing.Size(448, 46)
        Me.ucrPnlImportFromRapidPro.TabIndex = 0
        '
        'ucrChkUser
        '
        Me.ucrChkUser.AutoSize = True
        Me.ucrChkUser.Checked = False
        Me.ucrChkUser.Location = New System.Drawing.Point(218, 194)
        Me.ucrChkUser.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkUser.Name = "ucrChkUser"
        Me.ucrChkUser.Size = New System.Drawing.Size(150, 34)
        Me.ucrChkUser.TabIndex = 17
        '
        'ucrChkFlow
        '
        Me.ucrChkFlow.AutoSize = True
        Me.ucrChkFlow.Checked = False
        Me.ucrChkFlow.Location = New System.Drawing.Point(220, 229)
        Me.ucrChkFlow.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkFlow.Name = "ucrChkFlow"
        Me.ucrChkFlow.Size = New System.Drawing.Size(150, 34)
        Me.ucrChkFlow.TabIndex = 18
        '
        'cmdSelectFlows
        '
        Me.cmdSelectFlows.Location = New System.Drawing.Point(384, 234)
        Me.cmdSelectFlows.Name = "cmdSelectFlows"
        Me.cmdSelectFlows.Size = New System.Drawing.Size(110, 29)
        Me.cmdSelectFlows.TabIndex = 19
        Me.cmdSelectFlows.Text = "Select Flows"
        Me.cmdSelectFlows.UseVisualStyleBackColor = True
        '
        'grpDataToImport
        '
        Me.grpDataToImport.Location = New System.Drawing.Point(214, 174)
        Me.grpDataToImport.Name = "grpDataToImport"
        Me.grpDataToImport.Size = New System.Drawing.Size(292, 105)
        Me.grpDataToImport.TabIndex = 20
        Me.grpDataToImport.TabStop = False
        Me.grpDataToImport.Text = "Data To Import"
        '
        'dlgImportFromRapidPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 591)
        Me.Controls.Add(Me.cmdSelectFlows)
        Me.Controls.Add(Me.ucrChkFlow)
        Me.Controls.Add(Me.ucrChkUser)
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
        Me.Controls.Add(Me.grpDataToImport)
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
    Friend WithEvents ucrChkUser As ucrCheck
    Friend WithEvents ucrChkFlow As ucrCheck
    Friend WithEvents cmdSelectFlows As Button
    Friend WithEvents grpDataToImport As GroupBox
End Class
