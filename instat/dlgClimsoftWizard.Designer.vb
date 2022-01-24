<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimsoftWizard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.panelConnectDatabase = New System.Windows.Forms.Panel()
        Me.ucrComboBoxPort = New instat.ucrInputComboBox()
        Me.ucrTxtHost = New instat.ucrInputTextBox()
        Me.ucrComboBoxDatabaseName = New instat.ucrInputComboBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.chkRememberCredentials = New System.Windows.Forms.CheckBox()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.ucrTxtUserName = New instat.ucrInputTextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.lblConnectionTitle = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.panelStations = New System.Windows.Forms.Panel()
        Me.ucrChkObservationData = New instat.ucrCheck()
        Me.lblStationsTitle = New System.Windows.Forms.Label()
        Me.ucrComboBoxStations = New instat.ucrInputComboBox()
        Me.ucrSelectorStations = New instat.ucrSelectorAddRemove()
        Me.lblStations = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleStations = New instat.ucrReceiverMultiple()
        Me.panelElementsData = New System.Windows.Forms.Panel()
        Me.ucrChkUnstackData = New instat.ucrCheck()
        Me.ucrChkFlagsData = New instat.ucrCheck()
        Me.ucrChkElements = New instat.ucrCheck()
        Me.ucrChkDateRange = New instat.ucrCheck()
        Me.ucrDtpEndDate = New instat.ucrDateTimePicker()
        Me.ucrDtpStartdate = New instat.ucrDateTimePicker()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.ucrComboBoxElements = New instat.ucrInputComboBox()
        Me.ucrReceiverMultipleElements = New instat.ucrReceiverMultiple()
        Me.lblElements = New System.Windows.Forms.Label()
        Me.lblElementsTitle = New System.Windows.Forms.Label()
        Me.ucrSelectorElements = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.panelConnectDatabase.SuspendLayout()
        Me.panelStations.SuspendLayout()
        Me.panelElementsData.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelConnectDatabase
        '
        Me.panelConnectDatabase.Controls.Add(Me.ucrComboBoxPort)
        Me.panelConnectDatabase.Controls.Add(Me.ucrTxtHost)
        Me.panelConnectDatabase.Controls.Add(Me.ucrComboBoxDatabaseName)
        Me.panelConnectDatabase.Controls.Add(Me.btnConnect)
        Me.panelConnectDatabase.Controls.Add(Me.chkRememberCredentials)
        Me.panelConnectDatabase.Controls.Add(Me.lblConnection)
        Me.panelConnectDatabase.Controls.Add(Me.lblUserName)
        Me.panelConnectDatabase.Controls.Add(Me.ucrTxtUserName)
        Me.panelConnectDatabase.Controls.Add(Me.lblPort)
        Me.panelConnectDatabase.Controls.Add(Me.lblHost)
        Me.panelConnectDatabase.Controls.Add(Me.lblDatabaseName)
        Me.panelConnectDatabase.Controls.Add(Me.lblConnectionTitle)
        Me.panelConnectDatabase.Location = New System.Drawing.Point(140, 15)
        Me.panelConnectDatabase.Name = "panelConnectDatabase"
        Me.panelConnectDatabase.Size = New System.Drawing.Size(308, 271)
        Me.panelConnectDatabase.TabIndex = 1
        '
        'ucrComboBoxPort
        '
        Me.ucrComboBoxPort.AddQuotesIfUnrecognised = False
        Me.ucrComboBoxPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboBoxPort.GetSetSelectedIndex = -1
        Me.ucrComboBoxPort.IsReadOnly = False
        Me.ucrComboBoxPort.Location = New System.Drawing.Point(153, 99)
        Me.ucrComboBoxPort.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrComboBoxPort.Name = "ucrComboBoxPort"
        Me.ucrComboBoxPort.Size = New System.Drawing.Size(145, 21)
        Me.ucrComboBoxPort.TabIndex = 15
        '
        'ucrTxtHost
        '
        Me.ucrTxtHost.AddQuotesIfUnrecognised = True
        Me.ucrTxtHost.AutoSize = True
        Me.ucrTxtHost.IsMultiline = False
        Me.ucrTxtHost.IsReadOnly = False
        Me.ucrTxtHost.Location = New System.Drawing.Point(153, 69)
        Me.ucrTxtHost.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrTxtHost.Name = "ucrTxtHost"
        Me.ucrTxtHost.Size = New System.Drawing.Size(145, 21)
        Me.ucrTxtHost.TabIndex = 13
        '
        'ucrComboBoxDatabaseName
        '
        Me.ucrComboBoxDatabaseName.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxDatabaseName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboBoxDatabaseName.GetSetSelectedIndex = -1
        Me.ucrComboBoxDatabaseName.IsReadOnly = False
        Me.ucrComboBoxDatabaseName.Location = New System.Drawing.Point(153, 37)
        Me.ucrComboBoxDatabaseName.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrComboBoxDatabaseName.Name = "ucrComboBoxDatabaseName"
        Me.ucrComboBoxDatabaseName.Size = New System.Drawing.Size(145, 21)
        Me.ucrComboBoxDatabaseName.TabIndex = 12
        '
        'btnConnect
        '
        Me.btnConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConnect.Location = New System.Drawing.Point(95, 210)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(76, 22)
        Me.btnConnect.TabIndex = 19
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'chkRememberCredentials
        '
        Me.chkRememberCredentials.Checked = True
        Me.chkRememberCredentials.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRememberCredentials.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkRememberCredentials.Location = New System.Drawing.Point(94, 164)
        Me.chkRememberCredentials.Name = "chkRememberCredentials"
        Me.chkRememberCredentials.Size = New System.Drawing.Size(179, 17)
        Me.chkRememberCredentials.TabIndex = 18
        Me.chkRememberCredentials.Text = "Remember Credentials"
        Me.chkRememberCredentials.UseVisualStyleBackColor = True
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnection.Location = New System.Drawing.Point(176, 215)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(78, 13)
        Me.lblConnection.TabIndex = 21
        Me.lblConnection.Text = "No Connection"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUserName.Location = New System.Drawing.Point(33, 132)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(58, 13)
        Me.lblUserName.TabIndex = 20
        Me.lblUserName.Text = "Username:"
        '
        'ucrTxtUserName
        '
        Me.ucrTxtUserName.AddQuotesIfUnrecognised = True
        Me.ucrTxtUserName.AutoSize = True
        Me.ucrTxtUserName.IsMultiline = False
        Me.ucrTxtUserName.IsReadOnly = False
        Me.ucrTxtUserName.Location = New System.Drawing.Point(153, 128)
        Me.ucrTxtUserName.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrTxtUserName.Name = "ucrTxtUserName"
        Me.ucrTxtUserName.Size = New System.Drawing.Size(145, 21)
        Me.ucrTxtUserName.TabIndex = 16
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPort.Location = New System.Drawing.Point(62, 102)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(29, 13)
        Me.lblPort.TabIndex = 17
        Me.lblPort.Text = "Port:"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHost.Location = New System.Drawing.Point(58, 73)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(32, 13)
        Me.lblHost.TabIndex = 14
        Me.lblHost.Text = "Host:"
        '
        'lblDatabaseName
        '
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDatabaseName.Location = New System.Drawing.Point(3, 40)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(87, 13)
        Me.lblDatabaseName.TabIndex = 11
        Me.lblDatabaseName.Text = "Database Name:"
        '
        'lblConnectionTitle
        '
        Me.lblConnectionTitle.AutoSize = True
        Me.lblConnectionTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnectionTitle.Location = New System.Drawing.Point(82, 10)
        Me.lblConnectionTitle.Name = "lblConnectionTitle"
        Me.lblConnectionTitle.Size = New System.Drawing.Size(147, 13)
        Me.lblConnectionTitle.TabIndex = 10
        Me.lblConnectionTitle.Text = "Connect to Climsoft Database"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(87, 359)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 50
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(10, 359)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 52
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'panelStations
        '
        Me.panelStations.Controls.Add(Me.ucrChkObservationData)
        Me.panelStations.Controls.Add(Me.lblStationsTitle)
        Me.panelStations.Controls.Add(Me.ucrComboBoxStations)
        Me.panelStations.Controls.Add(Me.ucrSelectorStations)
        Me.panelStations.Controls.Add(Me.lblStations)
        Me.panelStations.Controls.Add(Me.ucrReceiverMultipleStations)
        Me.panelStations.Location = New System.Drawing.Point(60, 10)
        Me.panelStations.Name = "panelStations"
        Me.panelStations.Size = New System.Drawing.Size(386, 288)
        Me.panelStations.TabIndex = 2
        '
        'ucrChkObservationData
        '
        Me.ucrChkObservationData.AutoSize = True
        Me.ucrChkObservationData.Checked = False
        Me.ucrChkObservationData.Location = New System.Drawing.Point(7, 212)
        Me.ucrChkObservationData.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkObservationData.Name = "ucrChkObservationData"
        Me.ucrChkObservationData.Size = New System.Drawing.Size(178, 23)
        Me.ucrChkObservationData.TabIndex = 10
        '
        'lblStationsTitle
        '
        Me.lblStationsTitle.AutoSize = True
        Me.lblStationsTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStationsTitle.Location = New System.Drawing.Point(130, 10)
        Me.lblStationsTitle.Name = "lblStationsTitle"
        Me.lblStationsTitle.Size = New System.Drawing.Size(122, 13)
        Me.lblStationsTitle.TabIndex = 9
        Me.lblStationsTitle.Text = "Select Stations to Import"
        Me.lblStationsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrComboBoxStations
        '
        Me.ucrComboBoxStations.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxStations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboBoxStations.GetSetSelectedIndex = -1
        Me.ucrComboBoxStations.IsReadOnly = False
        Me.ucrComboBoxStations.Location = New System.Drawing.Point(7, 37)
        Me.ucrComboBoxStations.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrComboBoxStations.Name = "ucrComboBoxStations"
        Me.ucrComboBoxStations.Size = New System.Drawing.Size(148, 21)
        Me.ucrComboBoxStations.TabIndex = 7
        '
        'ucrSelectorStations
        '
        Me.ucrSelectorStations.AutoSize = True
        Me.ucrSelectorStations.bShowHiddenColumns = False
        Me.ucrSelectorStations.Location = New System.Drawing.Point(7, 61)
        Me.ucrSelectorStations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStations.Name = "ucrSelectorStations"
        Me.ucrSelectorStations.Size = New System.Drawing.Size(216, 139)
        Me.ucrSelectorStations.TabIndex = 5
        '
        'lblStations
        '
        Me.lblStations.AutoSize = True
        Me.lblStations.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStations.Location = New System.Drawing.Point(231, 45)
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Size = New System.Drawing.Size(93, 13)
        Me.lblStations.TabIndex = 6
        Me.lblStations.Text = "Selected Stations:"
        Me.lblStations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrReceiverMultipleStations
        '
        Me.ucrReceiverMultipleStations.AutoSize = True
        Me.ucrReceiverMultipleStations.frmParent = Me
        Me.ucrReceiverMultipleStations.Location = New System.Drawing.Point(234, 61)
        Me.ucrReceiverMultipleStations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleStations.Name = "ucrReceiverMultipleStations"
        Me.ucrReceiverMultipleStations.Selector = Nothing
        Me.ucrReceiverMultipleStations.Size = New System.Drawing.Size(137, 100)
        Me.ucrReceiverMultipleStations.strNcFilePath = ""
        Me.ucrReceiverMultipleStations.TabIndex = 8
        Me.ucrReceiverMultipleStations.ucrSelector = Nothing
        '
        'panelElementsData
        '
        Me.panelElementsData.Controls.Add(Me.ucrChkUnstackData)
        Me.panelElementsData.Controls.Add(Me.ucrChkFlagsData)
        Me.panelElementsData.Controls.Add(Me.ucrChkElements)
        Me.panelElementsData.Controls.Add(Me.ucrChkDateRange)
        Me.panelElementsData.Controls.Add(Me.ucrDtpEndDate)
        Me.panelElementsData.Controls.Add(Me.ucrDtpStartdate)
        Me.panelElementsData.Controls.Add(Me.lblEndDate)
        Me.panelElementsData.Controls.Add(Me.lblStartDate)
        Me.panelElementsData.Controls.Add(Me.ucrComboBoxElements)
        Me.panelElementsData.Controls.Add(Me.ucrReceiverMultipleElements)
        Me.panelElementsData.Controls.Add(Me.lblElements)
        Me.panelElementsData.Controls.Add(Me.lblElementsTitle)
        Me.panelElementsData.Controls.Add(Me.ucrSelectorElements)
        Me.panelElementsData.Location = New System.Drawing.Point(60, 10)
        Me.panelElementsData.Name = "panelElementsData"
        Me.panelElementsData.Size = New System.Drawing.Size(443, 343)
        Me.panelElementsData.TabIndex = 3
        '
        'ucrChkUnstackData
        '
        Me.ucrChkUnstackData.AutoSize = True
        Me.ucrChkUnstackData.Checked = False
        Me.ucrChkUnstackData.Location = New System.Drawing.Point(50, 220)
        Me.ucrChkUnstackData.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkUnstackData.Name = "ucrChkUnstackData"
        Me.ucrChkUnstackData.Size = New System.Drawing.Size(212, 23)
        Me.ucrChkUnstackData.TabIndex = 20
        '
        'ucrChkFlagsData
        '
        Me.ucrChkFlagsData.AutoSize = True
        Me.ucrChkFlagsData.Checked = False
        Me.ucrChkFlagsData.Location = New System.Drawing.Point(50, 199)
        Me.ucrChkFlagsData.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkFlagsData.Name = "ucrChkFlagsData"
        Me.ucrChkFlagsData.Size = New System.Drawing.Size(212, 23)
        Me.ucrChkFlagsData.TabIndex = 19
        '
        'ucrChkElements
        '
        Me.ucrChkElements.AutoSize = True
        Me.ucrChkElements.Checked = False
        Me.ucrChkElements.Location = New System.Drawing.Point(50, 242)
        Me.ucrChkElements.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkElements.Name = "ucrChkElements"
        Me.ucrChkElements.Size = New System.Drawing.Size(212, 23)
        Me.ucrChkElements.TabIndex = 13
        '
        'ucrChkDateRange
        '
        Me.ucrChkDateRange.AutoSize = True
        Me.ucrChkDateRange.Checked = False
        Me.ucrChkDateRange.Location = New System.Drawing.Point(50, 264)
        Me.ucrChkDateRange.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkDateRange.Name = "ucrChkDateRange"
        Me.ucrChkDateRange.Size = New System.Drawing.Size(203, 23)
        Me.ucrChkDateRange.TabIndex = 15
        '
        'ucrDtpEndDate
        '
        Me.ucrDtpEndDate.AutoSize = True
        Me.ucrDtpEndDate.DateValue = New Date(2021, 5, 18, 16, 55, 57, 146)
        Me.ucrDtpEndDate.Format = "dd MMM yyyy"
        Me.ucrDtpEndDate.Location = New System.Drawing.Point(245, 299)
        Me.ucrDtpEndDate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpEndDate.Name = "ucrDtpEndDate"
        Me.ucrDtpEndDate.Size = New System.Drawing.Size(163, 20)
        Me.ucrDtpEndDate.TabIndex = 17
        '
        'ucrDtpStartdate
        '
        Me.ucrDtpStartdate.AutoSize = True
        Me.ucrDtpStartdate.DateValue = New Date(2021, 5, 18, 16, 55, 57, 157)
        Me.ucrDtpStartdate.Format = "dd MMM yyyy"
        Me.ucrDtpStartdate.Location = New System.Drawing.Point(74, 300)
        Me.ucrDtpStartdate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDtpStartdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpStartdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpStartdate.Name = "ucrDtpStartdate"
        Me.ucrDtpStartdate.Size = New System.Drawing.Size(163, 20)
        Me.ucrDtpStartdate.TabIndex = 16
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEndDate.Location = New System.Drawing.Point(243, 283)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(55, 13)
        Me.lblEndDate.TabIndex = 18
        Me.lblEndDate.Text = "End Date:"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStartDate.Location = New System.Drawing.Point(70, 285)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(58, 13)
        Me.lblStartDate.TabIndex = 14
        Me.lblStartDate.Text = "Start Date:"
        '
        'ucrComboBoxElements
        '
        Me.ucrComboBoxElements.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxElements.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboBoxElements.GetSetSelectedIndex = -1
        Me.ucrComboBoxElements.IsReadOnly = False
        Me.ucrComboBoxElements.Location = New System.Drawing.Point(50, 37)
        Me.ucrComboBoxElements.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrComboBoxElements.Name = "ucrComboBoxElements"
        Me.ucrComboBoxElements.Size = New System.Drawing.Size(149, 21)
        Me.ucrComboBoxElements.TabIndex = 10
        '
        'ucrReceiverMultipleElements
        '
        Me.ucrReceiverMultipleElements.AutoSize = True
        Me.ucrReceiverMultipleElements.frmParent = Me
        Me.ucrReceiverMultipleElements.Location = New System.Drawing.Point(277, 61)
        Me.ucrReceiverMultipleElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleElements.Name = "ucrReceiverMultipleElements"
        Me.ucrReceiverMultipleElements.Selector = Nothing
        Me.ucrReceiverMultipleElements.Size = New System.Drawing.Size(137, 100)
        Me.ucrReceiverMultipleElements.strNcFilePath = ""
        Me.ucrReceiverMultipleElements.TabIndex = 12
        Me.ucrReceiverMultipleElements.ucrSelector = Nothing
        '
        'lblElements
        '
        Me.lblElements.AutoSize = True
        Me.lblElements.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElements.Location = New System.Drawing.Point(274, 45)
        Me.lblElements.Name = "lblElements"
        Me.lblElements.Size = New System.Drawing.Size(98, 13)
        Me.lblElements.TabIndex = 11
        Me.lblElements.Text = "Selected Elements:"
        '
        'lblElementsTitle
        '
        Me.lblElementsTitle.AutoSize = True
        Me.lblElementsTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElementsTitle.Location = New System.Drawing.Point(124, 10)
        Me.lblElementsTitle.Name = "lblElementsTitle"
        Me.lblElementsTitle.Size = New System.Drawing.Size(213, 13)
        Me.lblElementsTitle.TabIndex = 9
        Me.lblElementsTitle.Text = "Select Elements Observation Data to Import"
        Me.lblElementsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrSelectorElements
        '
        Me.ucrSelectorElements.AutoSize = True
        Me.ucrSelectorElements.bShowHiddenColumns = False
        Me.ucrSelectorElements.Location = New System.Drawing.Point(50, 61)
        Me.ucrSelectorElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorElements.Name = "ucrSelectorElements"
        Me.ucrSelectorElements.Size = New System.Drawing.Size(216, 137)
        Me.ucrSelectorElements.TabIndex = 11
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(166, 333)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 51
        '
        'dlgClimsoftWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(584, 391)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.panelElementsData)
        Me.Controls.Add(Me.panelStations)
        Me.Controls.Add(Me.panelConnectDatabase)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimsoftWizard"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import From Climsoft Wizard"
        Me.panelConnectDatabase.ResumeLayout(False)
        Me.panelConnectDatabase.PerformLayout()
        Me.panelStations.ResumeLayout(False)
        Me.panelStations.PerformLayout()
        Me.panelElementsData.ResumeLayout(False)
        Me.panelElementsData.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelConnectDatabase As Panel
    Friend WithEvents lblConnectionTitle As Label
    Friend WithEvents ucrComboBoxPort As ucrInputComboBox
    Friend WithEvents ucrTxtHost As ucrInputTextBox
    Friend WithEvents ucrComboBoxDatabaseName As ucrInputComboBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents chkRememberCredentials As CheckBox
    Friend WithEvents lblConnection As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents ucrTxtUserName As ucrInputTextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents lblHost As Label
    Friend WithEvents lblDatabaseName As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents panelStations As Panel
    Friend WithEvents lblStationsTitle As Label
    Friend WithEvents ucrComboBoxStations As ucrInputComboBox
    Friend WithEvents ucrSelectorStations As ucrSelectorAddRemove
    Friend WithEvents lblStations As Label
    Friend WithEvents ucrReceiverMultipleStations As ucrReceiverMultiple
    Friend WithEvents btnBack As Button
    Friend WithEvents ucrChkObservationData As ucrCheck
    Friend WithEvents panelElementsData As Panel
    Friend WithEvents lblElementsTitle As Label
    Friend WithEvents ucrSelectorElements As ucrSelectorAddRemove
    Friend WithEvents ucrComboBoxElements As ucrInputComboBox
    Friend WithEvents ucrReceiverMultipleElements As ucrReceiverMultiple
    Friend WithEvents lblElements As Label
    Friend WithEvents ucrChkElements As ucrCheck
    Friend WithEvents ucrChkDateRange As ucrCheck
    Friend WithEvents ucrDtpEndDate As ucrDateTimePicker
    Friend WithEvents ucrDtpStartdate As ucrDateTimePicker
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkFlagsData As ucrCheck
    Friend WithEvents ucrChkUnstackData As ucrCheck
End Class
