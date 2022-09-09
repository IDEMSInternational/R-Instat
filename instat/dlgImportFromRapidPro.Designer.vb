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
        Me.SuspendLayout()
        '
        'ucrPnlImportFromRapidPro
        '
        Me.ucrPnlImportFromRapidPro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlImportFromRapidPro.Location = New System.Drawing.Point(47, 12)
        Me.ucrPnlImportFromRapidPro.Name = "ucrPnlImportFromRapidPro"
        Me.ucrPnlImportFromRapidPro.Size = New System.Drawing.Size(299, 30)
        Me.ucrPnlImportFromRapidPro.TabIndex = 0
        '
        'rdoUserData
        '
        Me.rdoUserData.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoUserData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUserData.FlatAppearance.BorderSize = 2
        Me.rdoUserData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoUserData.Location = New System.Drawing.Point(90, 14)
        Me.rdoUserData.Name = "rdoUserData"
        Me.rdoUserData.Size = New System.Drawing.Size(112, 28)
        Me.rdoUserData.TabIndex = 2
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
        Me.rdoFlowData.Location = New System.Drawing.Point(200, 14)
        Me.rdoFlowData.Name = "rdoFlowData"
        Me.rdoFlowData.Size = New System.Drawing.Size(112, 28)
        Me.rdoFlowData.TabIndex = 3
        Me.rdoFlowData.TabStop = True
        Me.rdoFlowData.Text = "Flow Data"
        Me.rdoFlowData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFlowData.UseVisualStyleBackColor = True
        '
        'lblRapidProSite
        '
        Me.lblRapidProSite.AutoSize = True
        Me.lblRapidProSite.Location = New System.Drawing.Point(46, 70)
        Me.lblRapidProSite.Name = "lblRapidProSite"
        Me.lblRapidProSite.Size = New System.Drawing.Size(28, 13)
        Me.lblRapidProSite.TabIndex = 4
        Me.lblRapidProSite.Text = "Site:"
        '
        'ucrInputRapidProSite
        '
        Me.ucrInputRapidProSite.AddQuotesIfUnrecognised = True
        Me.ucrInputRapidProSite.AutoSize = True
        Me.ucrInputRapidProSite.IsMultiline = False
        Me.ucrInputRapidProSite.IsReadOnly = False
        Me.ucrInputRapidProSite.Location = New System.Drawing.Point(90, 62)
        Me.ucrInputRapidProSite.Name = "ucrInputRapidProSite"
        Me.ucrInputRapidProSite.Size = New System.Drawing.Size(222, 21)
        Me.ucrInputRapidProSite.TabIndex = 5
        '
        'cmdSetToken
        '
        Me.cmdSetToken.Location = New System.Drawing.Point(90, 90)
        Me.cmdSetToken.Name = "cmdSetToken"
        Me.cmdSetToken.Size = New System.Drawing.Size(135, 23)
        Me.cmdSetToken.TabIndex = 7
        Me.cmdSetToken.Text = "Set Token"
        Me.cmdSetToken.UseVisualStyleBackColor = True
        '
        'ucrChkFlattenData
        '
        Me.ucrChkFlattenData.AutoSize = True
        Me.ucrChkFlattenData.Checked = False
        Me.ucrChkFlattenData.Location = New System.Drawing.Point(21, 119)
        Me.ucrChkFlattenData.Name = "ucrChkFlattenData"
        Me.ucrChkFlattenData.Size = New System.Drawing.Size(128, 23)
        Me.ucrChkFlattenData.TabIndex = 8
        '
        'ucrChkSetStartDate
        '
        Me.ucrChkSetStartDate.AutoSize = True
        Me.ucrChkSetStartDate.Checked = False
        Me.ucrChkSetStartDate.Location = New System.Drawing.Point(21, 146)
        Me.ucrChkSetStartDate.Name = "ucrChkSetStartDate"
        Me.ucrChkSetStartDate.Size = New System.Drawing.Size(128, 23)
        Me.ucrChkSetStartDate.TabIndex = 9
        '
        'ucrChkSetEndDate
        '
        Me.ucrChkSetEndDate.AutoSize = True
        Me.ucrChkSetEndDate.Checked = False
        Me.ucrChkSetEndDate.Location = New System.Drawing.Point(21, 173)
        Me.ucrChkSetEndDate.Name = "ucrChkSetEndDate"
        Me.ucrChkSetEndDate.Size = New System.Drawing.Size(128, 23)
        Me.ucrChkSetEndDate.TabIndex = 10
        '
        'lblDateFormat
        '
        Me.lblDateFormat.AutoSize = True
        Me.lblDateFormat.Location = New System.Drawing.Point(18, 201)
        Me.lblDateFormat.Name = "lblDateFormat"
        Me.lblDateFormat.Size = New System.Drawing.Size(68, 13)
        Me.lblDateFormat.TabIndex = 11
        Me.lblDateFormat.Text = "Date Format:"
        '
        'lblTimezone
        '
        Me.lblTimezone.AutoSize = True
        Me.lblTimezone.Location = New System.Drawing.Point(18, 227)
        Me.lblTimezone.Name = "lblTimezone"
        Me.lblTimezone.Size = New System.Drawing.Size(56, 13)
        Me.lblTimezone.TabIndex = 12
        Me.lblTimezone.Text = "Timezone:"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(4, 255)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(409, 52)
        Me.ucrBase.TabIndex = 13
        '
        'ucrInputDateFormat
        '
        Me.ucrInputDateFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputDateFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDateFormat.GetSetSelectedIndex = -1
        Me.ucrInputDateFormat.IsReadOnly = False
        Me.ucrInputDateFormat.Location = New System.Drawing.Point(90, 201)
        Me.ucrInputDateFormat.Name = "ucrInputDateFormat"
        Me.ucrInputDateFormat.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDateFormat.TabIndex = 14
        '
        'ucrInputTimezone
        '
        Me.ucrInputTimezone.AddQuotesIfUnrecognised = True
        Me.ucrInputTimezone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTimezone.GetSetSelectedIndex = -1
        Me.ucrInputTimezone.IsReadOnly = False
        Me.ucrInputTimezone.Location = New System.Drawing.Point(90, 228)
        Me.ucrInputTimezone.Name = "ucrInputTimezone"
        Me.ucrInputTimezone.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTimezone.TabIndex = 15
        '
        'ucrInputStartDate
        '
        Me.ucrInputStartDate.AddQuotesIfUnrecognised = True
        Me.ucrInputStartDate.AutoSize = True
        Me.ucrInputStartDate.IsMultiline = False
        Me.ucrInputStartDate.IsReadOnly = False
        Me.ucrInputStartDate.Location = New System.Drawing.Point(175, 146)
        Me.ucrInputStartDate.Name = "ucrInputStartDate"
        Me.ucrInputStartDate.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputStartDate.TabIndex = 16
        '
        'ucrInputEndDate
        '
        Me.ucrInputEndDate.AddQuotesIfUnrecognised = True
        Me.ucrInputEndDate.AutoSize = True
        Me.ucrInputEndDate.IsMultiline = False
        Me.ucrInputEndDate.IsReadOnly = False
        Me.ucrInputEndDate.Location = New System.Drawing.Point(175, 173)
        Me.ucrInputEndDate.Name = "ucrInputEndDate"
        Me.ucrInputEndDate.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputEndDate.TabIndex = 17
        '
        'dlgImportFromRapidPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 313)
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
        Me.Name = "dlgImportFromRapidPro"
        Me.Text = "dlgImportFromRapidPro"
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
End Class
