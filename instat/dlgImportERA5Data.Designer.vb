<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgImportERA5Data
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
        Me.grpTimeSelection = New System.Windows.Forms.GroupBox()
        Me.rdoRange = New System.Windows.Forms.RadioButton()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.rdoSelection = New System.Windows.Forms.RadioButton()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.ucrDtpEndDate = New instat.ucrDateTimePicker()
        Me.ucrDtpStartDate = New instat.ucrDateTimePicker()
        Me.ucrPnlRangeSelection = New instat.UcrPanel()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblAPIKey = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblMinLongitude = New System.Windows.Forms.Label()
        Me.lblMinLatitude = New System.Windows.Forms.Label()
        Me.lblMaxLatitude = New System.Windows.Forms.Label()
        Me.lblMaxLongitude = New System.Windows.Forms.Label()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.grpLocationSelection = New System.Windows.Forms.GroupBox()
        Me.ucrInputMinLongitude = New instat.ucrInputTextBox()
        Me.ucrInputMinLatitude = New instat.ucrInputTextBox()
        Me.ucrInputMaxLongitude = New instat.ucrInputTextBox()
        Me.ucrInputMaxLatitude = New instat.ucrInputTextBox()
        Me.lblResolutionLabel = New System.Windows.Forms.Label()
        Me.grpLoginToCDS = New System.Windows.Forms.GroupBox()
        Me.ucrInputUserID = New instat.ucrInputTextBox()
        Me.ucrInputAPIKey = New instat.ucrInputTextBox()
        Me.lblResolution = New System.Windows.Forms.Label()
        Me.lnkCreateAnAccount = New System.Windows.Forms.LinkLabel()
        Me.lblSaveDownloadedFileTo = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrChkDoNotImport = New instat.ucrCheck()
        Me.ucrInputNewDataFrameName = New instat.ucrInputTextBox()
        Me.ucrInputElement = New instat.ucrInputComboBox()
        Me.ucrInputData = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpTimeSelection.SuspendLayout()
        Me.grpLocationSelection.SuspendLayout()
        Me.grpLoginToCDS.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTimeSelection
        '
        Me.grpTimeSelection.Controls.Add(Me.rdoRange)
        Me.grpTimeSelection.Controls.Add(Me.lblTo)
        Me.grpTimeSelection.Controls.Add(Me.rdoSelection)
        Me.grpTimeSelection.Controls.Add(Me.lblFrom)
        Me.grpTimeSelection.Controls.Add(Me.ucrDtpEndDate)
        Me.grpTimeSelection.Controls.Add(Me.ucrDtpStartDate)
        Me.grpTimeSelection.Controls.Add(Me.ucrPnlRangeSelection)
        Me.grpTimeSelection.Location = New System.Drawing.Point(11, 133)
        Me.grpTimeSelection.Name = "grpTimeSelection"
        Me.grpTimeSelection.Size = New System.Drawing.Size(297, 129)
        Me.grpTimeSelection.TabIndex = 7
        Me.grpTimeSelection.TabStop = False
        Me.grpTimeSelection.Text = "Time Selection"
        '
        'rdoRange
        '
        Me.rdoRange.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRange.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRange.Checked = True
        Me.rdoRange.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRange.FlatAppearance.BorderSize = 2
        Me.rdoRange.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRange.Location = New System.Drawing.Point(43, 23)
        Me.rdoRange.Name = "rdoRange"
        Me.rdoRange.Size = New System.Drawing.Size(102, 28)
        Me.rdoRange.TabIndex = 1
        Me.rdoRange.TabStop = True
        Me.rdoRange.Tag = ""
        Me.rdoRange.Text = "Range"
        Me.rdoRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRange.UseVisualStyleBackColor = False
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTo.Location = New System.Drawing.Point(6, 100)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 5
        Me.lblTo.Text = "To:"
        '
        'rdoSelection
        '
        Me.rdoSelection.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSelection.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSelection.Enabled = False
        Me.rdoSelection.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSelection.FlatAppearance.BorderSize = 2
        Me.rdoSelection.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSelection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSelection.Location = New System.Drawing.Point(143, 23)
        Me.rdoSelection.Name = "rdoSelection"
        Me.rdoSelection.Size = New System.Drawing.Size(102, 28)
        Me.rdoSelection.TabIndex = 2
        Me.rdoSelection.TabStop = True
        Me.rdoSelection.Tag = ""
        Me.rdoSelection.Text = "Selection"
        Me.rdoSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSelection.UseVisualStyleBackColor = False
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFrom.Location = New System.Drawing.Point(6, 70)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 3
        Me.lblFrom.Text = "From:"
        '
        'ucrDtpEndDate
        '
        Me.ucrDtpEndDate.AutoSize = True
        Me.ucrDtpEndDate.DateValue = New Date(2021, 3, 29, 10, 5, 8, 139)
        Me.ucrDtpEndDate.Format = "dd MMM yyyy"
        Me.ucrDtpEndDate.Location = New System.Drawing.Point(46, 100)
        Me.ucrDtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpEndDate.Name = "ucrDtpEndDate"
        Me.ucrDtpEndDate.Size = New System.Drawing.Size(163, 20)
        Me.ucrDtpEndDate.TabIndex = 6
        '
        'ucrDtpStartDate
        '
        Me.ucrDtpStartDate.AutoSize = True
        Me.ucrDtpStartDate.DateValue = New Date(2021, 3, 29, 10, 5, 8, 139)
        Me.ucrDtpStartDate.Format = "dd MMM yyyy"
        Me.ucrDtpStartDate.Location = New System.Drawing.Point(46, 68)
        Me.ucrDtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpStartDate.Name = "ucrDtpStartDate"
        Me.ucrDtpStartDate.Size = New System.Drawing.Size(165, 20)
        Me.ucrDtpStartDate.TabIndex = 4
        '
        'ucrPnlRangeSelection
        '
        Me.ucrPnlRangeSelection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRangeSelection.Location = New System.Drawing.Point(38, 16)
        Me.ucrPnlRangeSelection.Name = "ucrPnlRangeSelection"
        Me.ucrPnlRangeSelection.Size = New System.Drawing.Size(223, 42)
        Me.ucrPnlRangeSelection.TabIndex = 0
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblData.Location = New System.Drawing.Point(19, 85)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(33, 13)
        Me.lblData.TabIndex = 2
        Me.lblData.Text = "Data:"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement.Location = New System.Drawing.Point(18, 111)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 4
        Me.lblElement.Text = "Element:"
        '
        'lblAPIKey
        '
        Me.lblAPIKey.AutoSize = True
        Me.lblAPIKey.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAPIKey.Location = New System.Drawing.Point(6, 46)
        Me.lblAPIKey.Name = "lblAPIKey"
        Me.lblAPIKey.Size = New System.Drawing.Size(48, 13)
        Me.lblAPIKey.TabIndex = 2
        Me.lblAPIKey.Text = "API Key:"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUserID.Location = New System.Drawing.Point(6, 19)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(29, 13)
        Me.lblUserID.TabIndex = 0
        Me.lblUserID.Text = "UID:"
        '
        'lblMinLongitude
        '
        Me.lblMinLongitude.AutoSize = True
        Me.lblMinLongitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinLongitude.Location = New System.Drawing.Point(70, 19)
        Me.lblMinLongitude.Name = "lblMinLongitude"
        Me.lblMinLongitude.Size = New System.Drawing.Size(24, 13)
        Me.lblMinLongitude.TabIndex = 1
        Me.lblMinLongitude.Text = "Min"
        '
        'lblMinLatitude
        '
        Me.lblMinLatitude.AutoSize = True
        Me.lblMinLatitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinLatitude.Location = New System.Drawing.Point(70, 49)
        Me.lblMinLatitude.Name = "lblMinLatitude"
        Me.lblMinLatitude.Size = New System.Drawing.Size(24, 13)
        Me.lblMinLatitude.TabIndex = 6
        Me.lblMinLatitude.Text = "Min"
        '
        'lblMaxLatitude
        '
        Me.lblMaxLatitude.AutoSize = True
        Me.lblMaxLatitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxLatitude.Location = New System.Drawing.Point(180, 49)
        Me.lblMaxLatitude.Name = "lblMaxLatitude"
        Me.lblMaxLatitude.Size = New System.Drawing.Size(27, 13)
        Me.lblMaxLatitude.TabIndex = 8
        Me.lblMaxLatitude.Text = "Max"
        '
        'lblMaxLongitude
        '
        Me.lblMaxLongitude.AutoSize = True
        Me.lblMaxLongitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxLongitude.Location = New System.Drawing.Point(180, 19)
        Me.lblMaxLongitude.Name = "lblMaxLongitude"
        Me.lblMaxLongitude.Size = New System.Drawing.Size(27, 13)
        Me.lblMaxLongitude.TabIndex = 3
        Me.lblMaxLongitude.Text = "Max"
        '
        'lblNewDataFrameName
        '
        Me.lblNewDataFrameName.AutoSize = True
        Me.lblNewDataFrameName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNewDataFrameName.Location = New System.Drawing.Point(11, 443)
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Size = New System.Drawing.Size(121, 13)
        Me.lblNewDataFrameName.TabIndex = 0
        Me.lblNewDataFrameName.Text = "New Data Frame Name:"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLatitude.Location = New System.Drawing.Point(7, 49)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(48, 13)
        Me.lblLatitude.TabIndex = 5
        Me.lblLatitude.Text = "Latitude:"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLongitude.Location = New System.Drawing.Point(7, 19)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(57, 13)
        Me.lblLongitude.TabIndex = 0
        Me.lblLongitude.Text = "Longitude:"
        '
        'grpLocationSelection
        '
        Me.grpLocationSelection.Controls.Add(Me.lblLongitude)
        Me.grpLocationSelection.Controls.Add(Me.lblLatitude)
        Me.grpLocationSelection.Controls.Add(Me.lblMaxLatitude)
        Me.grpLocationSelection.Controls.Add(Me.lblMaxLongitude)
        Me.grpLocationSelection.Controls.Add(Me.lblMinLongitude)
        Me.grpLocationSelection.Controls.Add(Me.lblMinLatitude)
        Me.grpLocationSelection.Controls.Add(Me.ucrInputMinLongitude)
        Me.grpLocationSelection.Controls.Add(Me.ucrInputMinLatitude)
        Me.grpLocationSelection.Controls.Add(Me.ucrInputMaxLongitude)
        Me.grpLocationSelection.Controls.Add(Me.ucrInputMaxLatitude)
        Me.grpLocationSelection.Location = New System.Drawing.Point(11, 295)
        Me.grpLocationSelection.Name = "grpLocationSelection"
        Me.grpLocationSelection.Size = New System.Drawing.Size(297, 79)
        Me.grpLocationSelection.TabIndex = 12
        Me.grpLocationSelection.TabStop = False
        Me.grpLocationSelection.Text = "Location Selection"
        '
        'ucrInputMinLongitude
        '
        Me.ucrInputMinLongitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLongitude.AutoSize = True
        Me.ucrInputMinLongitude.IsMultiline = False
        Me.ucrInputMinLongitude.IsReadOnly = False
        Me.ucrInputMinLongitude.Location = New System.Drawing.Point(100, 15)
        Me.ucrInputMinLongitude.Name = "ucrInputMinLongitude"
        Me.ucrInputMinLongitude.Size = New System.Drawing.Size(70, 21)
        Me.ucrInputMinLongitude.TabIndex = 2
        '
        'ucrInputMinLatitude
        '
        Me.ucrInputMinLatitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLatitude.AutoSize = True
        Me.ucrInputMinLatitude.IsMultiline = False
        Me.ucrInputMinLatitude.IsReadOnly = False
        Me.ucrInputMinLatitude.Location = New System.Drawing.Point(100, 45)
        Me.ucrInputMinLatitude.Name = "ucrInputMinLatitude"
        Me.ucrInputMinLatitude.Size = New System.Drawing.Size(70, 21)
        Me.ucrInputMinLatitude.TabIndex = 7
        '
        'ucrInputMaxLongitude
        '
        Me.ucrInputMaxLongitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLongitude.AutoSize = True
        Me.ucrInputMaxLongitude.IsMultiline = False
        Me.ucrInputMaxLongitude.IsReadOnly = False
        Me.ucrInputMaxLongitude.Location = New System.Drawing.Point(211, 15)
        Me.ucrInputMaxLongitude.Name = "ucrInputMaxLongitude"
        Me.ucrInputMaxLongitude.Size = New System.Drawing.Size(70, 21)
        Me.ucrInputMaxLongitude.TabIndex = 4
        '
        'ucrInputMaxLatitude
        '
        Me.ucrInputMaxLatitude.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLatitude.AutoSize = True
        Me.ucrInputMaxLatitude.IsMultiline = False
        Me.ucrInputMaxLatitude.IsReadOnly = False
        Me.ucrInputMaxLatitude.Location = New System.Drawing.Point(211, 45)
        Me.ucrInputMaxLatitude.Name = "ucrInputMaxLatitude"
        Me.ucrInputMaxLatitude.Size = New System.Drawing.Size(70, 21)
        Me.ucrInputMaxLatitude.TabIndex = 9
        '
        'lblResolutionLabel
        '
        Me.lblResolutionLabel.AutoSize = True
        Me.lblResolutionLabel.ForeColor = System.Drawing.Color.Red
        Me.lblResolutionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResolutionLabel.Location = New System.Drawing.Point(86, 274)
        Me.lblResolutionLabel.Name = "lblResolutionLabel"
        Me.lblResolutionLabel.Size = New System.Drawing.Size(60, 13)
        Me.lblResolutionLabel.TabIndex = 9
        Me.lblResolutionLabel.Text = "0.25 x 0.25"
        '
        'grpLoginToCDS
        '
        Me.grpLoginToCDS.Controls.Add(Me.lblUserID)
        Me.grpLoginToCDS.Controls.Add(Me.lblAPIKey)
        Me.grpLoginToCDS.Controls.Add(Me.ucrInputUserID)
        Me.grpLoginToCDS.Controls.Add(Me.ucrInputAPIKey)
        Me.grpLoginToCDS.Location = New System.Drawing.Point(12, 9)
        Me.grpLoginToCDS.Name = "grpLoginToCDS"
        Me.grpLoginToCDS.Size = New System.Drawing.Size(296, 67)
        Me.grpLoginToCDS.TabIndex = 0
        Me.grpLoginToCDS.TabStop = False
        Me.grpLoginToCDS.Text = "Login to CDS"
        '
        'ucrInputUserID
        '
        Me.ucrInputUserID.AddQuotesIfUnrecognised = True
        Me.ucrInputUserID.AutoSize = True
        Me.ucrInputUserID.IsMultiline = False
        Me.ucrInputUserID.IsReadOnly = False
        Me.ucrInputUserID.Location = New System.Drawing.Point(68, 16)
        Me.ucrInputUserID.Name = "ucrInputUserID"
        Me.ucrInputUserID.Size = New System.Drawing.Size(221, 21)
        Me.ucrInputUserID.TabIndex = 1
        '
        'ucrInputAPIKey
        '
        Me.ucrInputAPIKey.AddQuotesIfUnrecognised = True
        Me.ucrInputAPIKey.AutoSize = True
        Me.ucrInputAPIKey.IsMultiline = False
        Me.ucrInputAPIKey.IsReadOnly = False
        Me.ucrInputAPIKey.Location = New System.Drawing.Point(67, 43)
        Me.ucrInputAPIKey.Name = "ucrInputAPIKey"
        Me.ucrInputAPIKey.Size = New System.Drawing.Size(222, 21)
        Me.ucrInputAPIKey.TabIndex = 3
        '
        'lblResolution
        '
        Me.lblResolution.AutoSize = True
        Me.lblResolution.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResolution.Location = New System.Drawing.Point(19, 274)
        Me.lblResolution.Name = "lblResolution"
        Me.lblResolution.Size = New System.Drawing.Size(60, 13)
        Me.lblResolution.TabIndex = 8
        Me.lblResolution.Text = "Resolution:"
        '
        'lnkCreateAnAccount
        '
        Me.lnkCreateAnAccount.AutoSize = True
        Me.lnkCreateAnAccount.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lnkCreateAnAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lnkCreateAnAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkCreateAnAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lnkCreateAnAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lnkCreateAnAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkCreateAnAccount.Location = New System.Drawing.Point(309, 37)
        Me.lnkCreateAnAccount.Name = "lnkCreateAnAccount"
        Me.lnkCreateAnAccount.Size = New System.Drawing.Size(118, 18)
        Me.lnkCreateAnAccount.TabIndex = 1
        Me.lnkCreateAnAccount.TabStop = True
        Me.lnkCreateAnAccount.Text = "Create an account"
        '
        'lblSaveDownloadedFileTo
        '
        Me.lblSaveDownloadedFileTo.AutoSize = True
        Me.lblSaveDownloadedFileTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaveDownloadedFileTo.Location = New System.Drawing.Point(10, 388)
        Me.lblSaveDownloadedFileTo.Name = "lblSaveDownloadedFileTo"
        Me.lblSaveDownloadedFileTo.Size = New System.Drawing.Size(129, 13)
        Me.lblSaveDownloadedFileTo.TabIndex = 13
        Me.lblSaveDownloadedFileTo.Text = "Save Downloaded File to:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrowse.Location = New System.Drawing.Point(351, 383)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(71, 23)
        Me.cmdBrowse.TabIndex = 15
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.AutoSize = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(202, 385)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(148, 21)
        Me.ucrInputFilePath.TabIndex = 14
        '
        'ucrChkDoNotImport
        '
        Me.ucrChkDoNotImport.AutoSize = True
        Me.ucrChkDoNotImport.Checked = False
        Me.ucrChkDoNotImport.Location = New System.Drawing.Point(11, 412)
        Me.ucrChkDoNotImport.Name = "ucrChkDoNotImport"
        Me.ucrChkDoNotImport.Size = New System.Drawing.Size(347, 23)
        Me.ucrChkDoNotImport.TabIndex = 16
        '
        'ucrInputNewDataFrameName
        '
        Me.ucrInputNewDataFrameName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDataFrameName.AutoSize = True
        Me.ucrInputNewDataFrameName.IsMultiline = False
        Me.ucrInputNewDataFrameName.IsReadOnly = False
        Me.ucrInputNewDataFrameName.Location = New System.Drawing.Point(201, 440)
        Me.ucrInputNewDataFrameName.Name = "ucrInputNewDataFrameName"
        Me.ucrInputNewDataFrameName.Size = New System.Drawing.Size(173, 21)
        Me.ucrInputNewDataFrameName.TabIndex = 1
        '
        'ucrInputElement
        '
        Me.ucrInputElement.AddQuotesIfUnrecognised = True
        Me.ucrInputElement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputElement.GetSetSelectedIndex = -1
        Me.ucrInputElement.IsReadOnly = False
        Me.ucrInputElement.Location = New System.Drawing.Point(80, 107)
        Me.ucrInputElement.Name = "ucrInputElement"
        Me.ucrInputElement.Size = New System.Drawing.Size(221, 21)
        Me.ucrInputElement.TabIndex = 5
        '
        'ucrInputData
        '
        Me.ucrInputData.AddQuotesIfUnrecognised = True
        Me.ucrInputData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputData.GetSetSelectedIndex = -1
        Me.ucrInputData.IsReadOnly = False
        Me.ucrInputData.Location = New System.Drawing.Point(80, 81)
        Me.ucrInputData.Name = "ucrInputData"
        Me.ucrInputData.Size = New System.Drawing.Size(221, 21)
        Me.ucrInputData.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(11, 465)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 2
        '
        'dlgImportERA5Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(428, 517)
        Me.Controls.Add(Me.lblSaveDownloadedFileTo)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.lnkCreateAnAccount)
        Me.Controls.Add(Me.lblResolution)
        Me.Controls.Add(Me.lblResolutionLabel)
        Me.Controls.Add(Me.grpLocationSelection)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.ucrChkDoNotImport)
        Me.Controls.Add(Me.ucrInputNewDataFrameName)
        Me.Controls.Add(Me.grpTimeSelection)
        Me.Controls.Add(Me.ucrInputElement)
        Me.Controls.Add(Me.ucrInputData)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpLoginToCDS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportERA5Data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import from CDS (Climate Data Store)"
        Me.grpTimeSelection.ResumeLayout(False)
        Me.grpTimeSelection.PerformLayout()
        Me.grpLocationSelection.ResumeLayout(False)
        Me.grpLocationSelection.PerformLayout()
        Me.grpLoginToCDS.ResumeLayout(False)
        Me.grpLoginToCDS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputData As ucrInputComboBox
    Friend WithEvents ucrInputElement As ucrInputComboBox
    Friend WithEvents grpTimeSelection As GroupBox
    Friend WithEvents ucrDtpEndDate As ucrDateTimePicker
    Friend WithEvents ucrDtpStartDate As ucrDateTimePicker
    Friend WithEvents ucrInputMinLongitude As ucrInputTextBox
    Friend WithEvents ucrInputMaxLatitude As ucrInputTextBox
    Friend WithEvents ucrInputMaxLongitude As ucrInputTextBox
    Friend WithEvents ucrInputMinLatitude As ucrInputTextBox
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrInputNewDataFrameName As ucrInputTextBox
    Friend WithEvents ucrChkDoNotImport As ucrCheck
    Friend WithEvents ucrInputAPIKey As ucrInputTextBox
    Friend WithEvents ucrInputUserID As ucrInputTextBox
    Friend WithEvents lblData As Label
    Friend WithEvents lblElement As Label
    Friend WithEvents lblAPIKey As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblMinLongitude As Label
    Friend WithEvents lblMinLatitude As Label
    Friend WithEvents lblMaxLatitude As Label
    Friend WithEvents lblMaxLongitude As Label
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents lblLongitude As Label
    Friend WithEvents grpLocationSelection As GroupBox
    Friend WithEvents rdoRange As RadioButton
    Friend WithEvents rdoSelection As RadioButton
    Friend WithEvents ucrPnlRangeSelection As UcrPanel
    Friend WithEvents lblResolutionLabel As Label
    Friend WithEvents grpLoginToCDS As GroupBox
    Friend WithEvents lblResolution As Label
    Friend WithEvents lnkCreateAnAccount As LinkLabel
    Friend WithEvents lblSaveDownloadedFileTo As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents cmdBrowse As Button
End Class
