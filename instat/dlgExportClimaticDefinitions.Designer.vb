<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgExportClimaticDefinitions
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
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.cmdChooseFile = New System.Windows.Forms.Button()
        Me.ucrInputTokenPath = New instat.ucrInputTextBox()
        Me.rdoUploadSummaries = New System.Windows.Forms.RadioButton()
        Me.rdoUpdateMetadata = New System.Windows.Forms.RadioButton()
        Me.ucrPnlExportGoogle = New instat.UcrPanel()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.lblDefinitionsID = New System.Windows.Forms.Label()
        Me.ucrInputDefinitionsID = New instat.ucrInputTextBox()
        Me.cmdDefine = New System.Windows.Forms.Button()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.ucrInputCountry = New instat.ucrInputTextBox()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrChkIncludeSummaryData = New instat.ucrCheck()
        Me.grpSummaries = New System.Windows.Forms.GroupBox()
        Me.ucrChkMonthlyTemp = New instat.ucrCheck()
        Me.ucrChkSeasonStartProp = New instat.ucrCheck()
        Me.ucrChkExtremes = New instat.ucrCheck()
        Me.ucrChkCropSuccessProp = New instat.ucrCheck()
        Me.ucrChkAnnualTemp = New instat.ucrCheck()
        Me.ucrChkAnnualRainfall = New instat.ucrCheck()
        Me.lblCropData = New System.Windows.Forms.Label()
        Me.lblDataByYearMonth = New System.Windows.Forms.Label()
        Me.lblDataByYear = New System.Windows.Forms.Label()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.ucrReceiverRain = New instat.ucrReceiverSingle()
        Me.ucrSelectorExportDefinitions = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverDataYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDataYearMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverCropData = New instat.ucrReceiverSingle()
        Me.lblDistrict = New System.Windows.Forms.Label()
        Me.lblElavation = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.ucrReceiverLongititude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverElavation = New instat.ucrReceiverSingle()
        Me.ucrReceiverDistrict = New instat.ucrReceiverSingle()
        Me.ucrReceiverStationName = New instat.ucrReceiverSingle()
        Me.lblStationName = New System.Windows.Forms.Label()
        Me.lblCountryMetada = New System.Windows.Forms.Label()
        Me.ucrInputCountryMetadata = New instat.ucrInputTextBox()
        Me.ucrReceiverExtremIndicator = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainIndicator = New instat.ucrReceiverSingle()
        Me.lblRainIndicator = New System.Windows.Forms.Label()
        Me.lblExtremRain = New System.Windows.Forms.Label()
        Me.lblExtremeTmaxIndicator = New System.Windows.Forms.Label()
        Me.ucrReceiverExtremeTmaxIndicator = New instat.ucrReceiverSingle()
        Me.lblExtremeTminIndicator = New System.Windows.Forms.Label()
        Me.ucrReceiverExtremeTminIndicator = New instat.ucrReceiverSingle()
        Me.grpSummaries.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(495, 194)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 52
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExport.Location = New System.Drawing.Point(96, 71)
        Me.lblExport.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(57, 20)
        Me.lblExport.TabIndex = 81
        Me.lblExport.Text = "Token:"
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdChooseFile.Location = New System.Drawing.Point(466, 62)
        Me.cmdChooseFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(120, 35)
        Me.cmdChooseFile.TabIndex = 83
        Me.cmdChooseFile.Text = "Browse"
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'ucrInputTokenPath
        '
        Me.ucrInputTokenPath.AddQuotesIfUnrecognised = True
        Me.ucrInputTokenPath.AutoSize = True
        Me.ucrInputTokenPath.IsMultiline = False
        Me.ucrInputTokenPath.IsReadOnly = False
        Me.ucrInputTokenPath.Location = New System.Drawing.Point(166, 66)
        Me.ucrInputTokenPath.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputTokenPath.Name = "ucrInputTokenPath"
        Me.ucrInputTokenPath.Size = New System.Drawing.Size(286, 32)
        Me.ucrInputTokenPath.TabIndex = 82
        '
        'rdoUploadSummaries
        '
        Me.rdoUploadSummaries.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoUploadSummaries.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUploadSummaries.FlatAppearance.BorderSize = 2
        Me.rdoUploadSummaries.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUploadSummaries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoUploadSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoUploadSummaries.Location = New System.Drawing.Point(340, 11)
        Me.rdoUploadSummaries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoUploadSummaries.Name = "rdoUploadSummaries"
        Me.rdoUploadSummaries.Size = New System.Drawing.Size(183, 42)
        Me.rdoUploadSummaries.TabIndex = 47
        Me.rdoUploadSummaries.Text = "Upload Summaries"
        Me.rdoUploadSummaries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoUploadSummaries.UseVisualStyleBackColor = True
        '
        'rdoUpdateMetadata
        '
        Me.rdoUpdateMetadata.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoUpdateMetadata.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUpdateMetadata.FlatAppearance.BorderSize = 2
        Me.rdoUpdateMetadata.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUpdateMetadata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoUpdateMetadata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoUpdateMetadata.Location = New System.Drawing.Point(171, 11)
        Me.rdoUpdateMetadata.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoUpdateMetadata.Name = "rdoUpdateMetadata"
        Me.rdoUpdateMetadata.Size = New System.Drawing.Size(174, 42)
        Me.rdoUpdateMetadata.TabIndex = 46
        Me.rdoUpdateMetadata.Text = "Update Metadata"
        Me.rdoUpdateMetadata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoUpdateMetadata.UseVisualStyleBackColor = True
        '
        'ucrPnlExportGoogle
        '
        Me.ucrPnlExportGoogle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlExportGoogle.Location = New System.Drawing.Point(166, 3)
        Me.ucrPnlExportGoogle.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrPnlExportGoogle.Name = "ucrPnlExportGoogle"
        Me.ucrPnlExportGoogle.Size = New System.Drawing.Size(374, 51)
        Me.ucrPnlExportGoogle.TabIndex = 45
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(495, 142)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 50
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'lblDefinitionsID
        '
        Me.lblDefinitionsID.AutoSize = True
        Me.lblDefinitionsID.Location = New System.Drawing.Point(2, 600)
        Me.lblDefinitionsID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDefinitionsID.Name = "lblDefinitionsID"
        Me.lblDefinitionsID.Size = New System.Drawing.Size(109, 20)
        Me.lblDefinitionsID.TabIndex = 67
        Me.lblDefinitionsID.Text = "Definitions ID:"
        '
        'ucrInputDefinitionsID
        '
        Me.ucrInputDefinitionsID.AddQuotesIfUnrecognised = True
        Me.ucrInputDefinitionsID.AutoSize = True
        Me.ucrInputDefinitionsID.IsMultiline = False
        Me.ucrInputDefinitionsID.IsReadOnly = False
        Me.ucrInputDefinitionsID.Location = New System.Drawing.Point(129, 594)
        Me.ucrInputDefinitionsID.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputDefinitionsID.Name = "ucrInputDefinitionsID"
        Me.ucrInputDefinitionsID.Size = New System.Drawing.Size(177, 32)
        Me.ucrInputDefinitionsID.TabIndex = 68
        '
        'cmdDefine
        '
        Me.cmdDefine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDefine.Location = New System.Drawing.Point(495, 691)
        Me.cmdDefine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdDefine.Name = "cmdDefine"
        Me.cmdDefine.Size = New System.Drawing.Size(188, 38)
        Me.cmdDefine.TabIndex = 72
        Me.cmdDefine.Text = "Define"
        Me.cmdDefine.UseVisualStyleBackColor = True
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(495, 122)
        Me.lblStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(64, 20)
        Me.lblStation.TabIndex = 49
        Me.lblStation.Text = "Station:"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(42, 642)
        Me.lblCountry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(68, 20)
        Me.lblCountry.TabIndex = 69
        Me.lblCountry.Text = "Country:"
        '
        'ucrInputCountry
        '
        Me.ucrInputCountry.AddQuotesIfUnrecognised = True
        Me.ucrInputCountry.AutoSize = True
        Me.ucrInputCountry.IsMultiline = False
        Me.ucrInputCountry.IsReadOnly = False
        Me.ucrInputCountry.Location = New System.Drawing.Point(129, 635)
        Me.ucrInputCountry.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputCountry.Name = "ucrInputCountry"
        Me.ucrInputCountry.Size = New System.Drawing.Size(177, 32)
        Me.ucrInputCountry.TabIndex = 70
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(495, 232)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(58, 20)
        Me.lblMonth.TabIndex = 53
        Me.lblMonth.Text = "Month:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(495, 171)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(47, 20)
        Me.lblYear.TabIndex = 51
        Me.lblYear.Text = "Year:"
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.AutoSize = True
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(495, 257)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 54
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrChkIncludeSummaryData
        '
        Me.ucrChkIncludeSummaryData.AutoSize = True
        Me.ucrChkIncludeSummaryData.Checked = False
        Me.ucrChkIncludeSummaryData.Location = New System.Drawing.Point(9, 685)
        Me.ucrChkIncludeSummaryData.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkIncludeSummaryData.Name = "ucrChkIncludeSummaryData"
        Me.ucrChkIncludeSummaryData.Size = New System.Drawing.Size(332, 48)
        Me.ucrChkIncludeSummaryData.TabIndex = 71
        '
        'grpSummaries
        '
        Me.grpSummaries.Controls.Add(Me.ucrChkMonthlyTemp)
        Me.grpSummaries.Controls.Add(Me.ucrChkSeasonStartProp)
        Me.grpSummaries.Controls.Add(Me.ucrChkExtremes)
        Me.grpSummaries.Controls.Add(Me.ucrChkCropSuccessProp)
        Me.grpSummaries.Controls.Add(Me.ucrChkAnnualTemp)
        Me.grpSummaries.Controls.Add(Me.ucrChkAnnualRainfall)
        Me.grpSummaries.Location = New System.Drawing.Point(3, 406)
        Me.grpSummaries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpSummaries.Size = New System.Drawing.Size(470, 178)
        Me.grpSummaries.TabIndex = 67
        Me.grpSummaries.TabStop = False
        Me.grpSummaries.Text = "Summaries"
        '
        'ucrChkMonthlyTemp
        '
        Me.ucrChkMonthlyTemp.AutoSize = True
        Me.ucrChkMonthlyTemp.Checked = False
        Me.ucrChkMonthlyTemp.Location = New System.Drawing.Point(12, 118)
        Me.ucrChkMonthlyTemp.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkMonthlyTemp.Name = "ucrChkMonthlyTemp"
        Me.ucrChkMonthlyTemp.Size = New System.Drawing.Size(220, 52)
        Me.ucrChkMonthlyTemp.TabIndex = 4
        '
        'ucrChkSeasonStartProp
        '
        Me.ucrChkSeasonStartProp.AutoSize = True
        Me.ucrChkSeasonStartProp.Checked = False
        Me.ucrChkSeasonStartProp.Location = New System.Drawing.Point(236, 68)
        Me.ucrChkSeasonStartProp.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkSeasonStartProp.Name = "ucrChkSeasonStartProp"
        Me.ucrChkSeasonStartProp.Size = New System.Drawing.Size(226, 52)
        Me.ucrChkSeasonStartProp.TabIndex = 3
        '
        'ucrChkExtremes
        '
        Me.ucrChkExtremes.AutoSize = True
        Me.ucrChkExtremes.Checked = False
        Me.ucrChkExtremes.Location = New System.Drawing.Point(236, 118)
        Me.ucrChkExtremes.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkExtremes.Name = "ucrChkExtremes"
        Me.ucrChkExtremes.Size = New System.Drawing.Size(220, 52)
        Me.ucrChkExtremes.TabIndex = 5
        Me.ucrChkExtremes.Visible = False
        '
        'ucrChkCropSuccessProp
        '
        Me.ucrChkCropSuccessProp.AutoSize = True
        Me.ucrChkCropSuccessProp.Checked = False
        Me.ucrChkCropSuccessProp.Location = New System.Drawing.Point(236, 20)
        Me.ucrChkCropSuccessProp.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkCropSuccessProp.Name = "ucrChkCropSuccessProp"
        Me.ucrChkCropSuccessProp.Size = New System.Drawing.Size(230, 52)
        Me.ucrChkCropSuccessProp.TabIndex = 1
        '
        'ucrChkAnnualTemp
        '
        Me.ucrChkAnnualTemp.AutoSize = True
        Me.ucrChkAnnualTemp.Checked = False
        Me.ucrChkAnnualTemp.Location = New System.Drawing.Point(12, 69)
        Me.ucrChkAnnualTemp.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkAnnualTemp.Name = "ucrChkAnnualTemp"
        Me.ucrChkAnnualTemp.Size = New System.Drawing.Size(224, 52)
        Me.ucrChkAnnualTemp.TabIndex = 2
        '
        'ucrChkAnnualRainfall
        '
        Me.ucrChkAnnualRainfall.AutoSize = True
        Me.ucrChkAnnualRainfall.Checked = False
        Me.ucrChkAnnualRainfall.Location = New System.Drawing.Point(12, 20)
        Me.ucrChkAnnualRainfall.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkAnnualRainfall.Name = "ucrChkAnnualRainfall"
        Me.ucrChkAnnualRainfall.Size = New System.Drawing.Size(224, 52)
        Me.ucrChkAnnualRainfall.TabIndex = 0
        '
        'lblCropData
        '
        Me.lblCropData.AutoSize = True
        Me.lblCropData.Location = New System.Drawing.Point(495, 472)
        Me.lblCropData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCropData.Name = "lblCropData"
        Me.lblCropData.Size = New System.Drawing.Size(86, 20)
        Me.lblCropData.TabIndex = 61
        Me.lblCropData.Text = "Crop Data:"
        '
        'lblDataByYearMonth
        '
        Me.lblDataByYearMonth.AutoSize = True
        Me.lblDataByYearMonth.Location = New System.Drawing.Point(494, 411)
        Me.lblDataByYearMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataByYearMonth.Name = "lblDataByYearMonth"
        Me.lblDataByYearMonth.Size = New System.Drawing.Size(188, 20)
        Me.lblDataByYearMonth.TabIndex = 59
        Me.lblDataByYearMonth.Text = "Data By Year and Month:"
        '
        'lblDataByYear
        '
        Me.lblDataByYear.AutoSize = True
        Me.lblDataByYear.Location = New System.Drawing.Point(495, 349)
        Me.lblDataByYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataByYear.Name = "lblDataByYear"
        Me.lblDataByYear.Size = New System.Drawing.Size(108, 20)
        Me.lblDataByYear.TabIndex = 57
        Me.lblDataByYear.Text = "Data By Year:"
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(495, 294)
        Me.lblRain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(46, 20)
        Me.lblRain.TabIndex = 55
        Me.lblRain.Text = "Rain:"
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.AutoSize = True
        Me.ucrReceiverRain.frmParent = Me
        Me.ucrReceiverRain.Location = New System.Drawing.Point(495, 318)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverRain.strNcFilePath = ""
        Me.ucrReceiverRain.TabIndex = 56
        Me.ucrReceiverRain.ucrSelector = Nothing
        '
        'ucrSelectorExportDefinitions
        '
        Me.ucrSelectorExportDefinitions.AutoSize = True
        Me.ucrSelectorExportDefinitions.bDropUnusedFilterLevels = False
        Me.ucrSelectorExportDefinitions.bShowHiddenColumns = False
        Me.ucrSelectorExportDefinitions.bUseCurrentFilter = True
        Me.ucrSelectorExportDefinitions.Location = New System.Drawing.Point(3, 120)
        Me.ucrSelectorExportDefinitions.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorExportDefinitions.Name = "ucrSelectorExportDefinitions"
        Me.ucrSelectorExportDefinitions.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelectorExportDefinitions.TabIndex = 48
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(3, 749)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 73
        '
        'ucrReceiverDataYear
        '
        Me.ucrReceiverDataYear.AutoSize = True
        Me.ucrReceiverDataYear.frmParent = Me
        Me.ucrReceiverDataYear.Location = New System.Drawing.Point(495, 375)
        Me.ucrReceiverDataYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataYear.Name = "ucrReceiverDataYear"
        Me.ucrReceiverDataYear.Selector = Nothing
        Me.ucrReceiverDataYear.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverDataYear.strNcFilePath = ""
        Me.ucrReceiverDataYear.TabIndex = 58
        Me.ucrReceiverDataYear.ucrSelector = Nothing
        '
        'ucrReceiverDataYearMonth
        '
        Me.ucrReceiverDataYearMonth.AutoSize = True
        Me.ucrReceiverDataYearMonth.frmParent = Me
        Me.ucrReceiverDataYearMonth.Location = New System.Drawing.Point(495, 435)
        Me.ucrReceiverDataYearMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataYearMonth.Name = "ucrReceiverDataYearMonth"
        Me.ucrReceiverDataYearMonth.Selector = Nothing
        Me.ucrReceiverDataYearMonth.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverDataYearMonth.strNcFilePath = ""
        Me.ucrReceiverDataYearMonth.TabIndex = 60
        Me.ucrReceiverDataYearMonth.ucrSelector = Nothing
        '
        'ucrReceiverCropData
        '
        Me.ucrReceiverCropData.AutoSize = True
        Me.ucrReceiverCropData.frmParent = Me
        Me.ucrReceiverCropData.Location = New System.Drawing.Point(495, 497)
        Me.ucrReceiverCropData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCropData.Name = "ucrReceiverCropData"
        Me.ucrReceiverCropData.Selector = Nothing
        Me.ucrReceiverCropData.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverCropData.strNcFilePath = ""
        Me.ucrReceiverCropData.TabIndex = 62
        Me.ucrReceiverCropData.ucrSelector = Nothing
        '
        'lblDistrict
        '
        Me.lblDistrict.AutoSize = True
        Me.lblDistrict.Location = New System.Drawing.Point(486, 415)
        Me.lblDistrict.Name = "lblDistrict"
        Me.lblDistrict.Size = New System.Drawing.Size(58, 20)
        Me.lblDistrict.TabIndex = 79
        Me.lblDistrict.Text = "District"
        '
        'lblElavation
        '
        Me.lblElavation.AutoSize = True
        Me.lblElavation.Location = New System.Drawing.Point(484, 342)
        Me.lblElavation.Name = "lblElavation"
        Me.lblElavation.Size = New System.Drawing.Size(74, 20)
        Me.lblElavation.TabIndex = 77
        Me.lblElavation.Text = "Elevation"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Location = New System.Drawing.Point(483, 266)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(67, 20)
        Me.lblLatitude.TabIndex = 75
        Me.lblLatitude.Text = "Latitude"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Location = New System.Drawing.Point(482, 189)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(84, 20)
        Me.lblLongitude.TabIndex = 73
        Me.lblLongitude.Text = "Longitude "
        '
        'ucrReceiverLongititude
        '
        Me.ucrReceiverLongititude.AutoSize = True
        Me.ucrReceiverLongititude.frmParent = Me
        Me.ucrReceiverLongititude.Location = New System.Drawing.Point(478, 215)
        Me.ucrReceiverLongititude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongititude.Name = "ucrReceiverLongititude"
        Me.ucrReceiverLongititude.Selector = Nothing
        Me.ucrReceiverLongititude.Size = New System.Drawing.Size(180, 35)
        Me.ucrReceiverLongititude.strNcFilePath = ""
        Me.ucrReceiverLongititude.TabIndex = 74
        Me.ucrReceiverLongititude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(478, 295)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 76
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverElavation
        '
        Me.ucrReceiverElavation.AutoSize = True
        Me.ucrReceiverElavation.frmParent = Me
        Me.ucrReceiverElavation.Location = New System.Drawing.Point(478, 369)
        Me.ucrReceiverElavation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElavation.Name = "ucrReceiverElavation"
        Me.ucrReceiverElavation.Selector = Nothing
        Me.ucrReceiverElavation.Size = New System.Drawing.Size(180, 35)
        Me.ucrReceiverElavation.strNcFilePath = ""
        Me.ucrReceiverElavation.TabIndex = 78
        Me.ucrReceiverElavation.ucrSelector = Nothing
        '
        'ucrReceiverDistrict
        '
        Me.ucrReceiverDistrict.AutoSize = True
        Me.ucrReceiverDistrict.frmParent = Me
        Me.ucrReceiverDistrict.Location = New System.Drawing.Point(478, 445)
        Me.ucrReceiverDistrict.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDistrict.Name = "ucrReceiverDistrict"
        Me.ucrReceiverDistrict.Selector = Nothing
        Me.ucrReceiverDistrict.Size = New System.Drawing.Size(180, 43)
        Me.ucrReceiverDistrict.strNcFilePath = ""
        Me.ucrReceiverDistrict.TabIndex = 80
        Me.ucrReceiverDistrict.ucrSelector = Nothing
        '
        'ucrReceiverStationName
        '
        Me.ucrReceiverStationName.AutoSize = True
        Me.ucrReceiverStationName.frmParent = Me
        Me.ucrReceiverStationName.Location = New System.Drawing.Point(478, 143)
        Me.ucrReceiverStationName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationName.Name = "ucrReceiverStationName"
        Me.ucrReceiverStationName.Selector = Nothing
        Me.ucrReceiverStationName.Size = New System.Drawing.Size(180, 42)
        Me.ucrReceiverStationName.strNcFilePath = ""
        Me.ucrReceiverStationName.TabIndex = 72
        Me.ucrReceiverStationName.ucrSelector = Nothing
        '
        'lblStationName
        '
        Me.lblStationName.AutoSize = True
        Me.lblStationName.Location = New System.Drawing.Point(482, 120)
        Me.lblStationName.Name = "lblStationName"
        Me.lblStationName.Size = New System.Drawing.Size(106, 20)
        Me.lblStationName.TabIndex = 71
        Me.lblStationName.Text = "Station Name"
        '
        'lblCountryMetada
        '
        Me.lblCountryMetada.AutoSize = True
        Me.lblCountryMetada.Location = New System.Drawing.Point(484, 486)
        Me.lblCountryMetada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountryMetada.Name = "lblCountryMetada"
        Me.lblCountryMetada.Size = New System.Drawing.Size(68, 20)
        Me.lblCountryMetada.TabIndex = 85
        Me.lblCountryMetada.Text = "Country:"
        '
        'ucrInputCountryMetadata
        '
        Me.ucrInputCountryMetadata.AddQuotesIfUnrecognised = True
        Me.ucrInputCountryMetadata.AutoSize = True
        Me.ucrInputCountryMetadata.IsMultiline = False
        Me.ucrInputCountryMetadata.IsReadOnly = False
        Me.ucrInputCountryMetadata.Location = New System.Drawing.Point(478, 514)
        Me.ucrInputCountryMetadata.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputCountryMetadata.Name = "ucrInputCountryMetadata"
        Me.ucrInputCountryMetadata.Size = New System.Drawing.Size(177, 32)
        Me.ucrInputCountryMetadata.TabIndex = 84
        '
        'ucrReceiverExtremIndicator
        '
        Me.ucrReceiverExtremIndicator.AutoSize = True
        Me.ucrReceiverExtremIndicator.frmParent = Me
        Me.ucrReceiverExtremIndicator.Location = New System.Drawing.Point(495, 637)
        Me.ucrReceiverExtremIndicator.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExtremIndicator.Name = "ucrReceiverExtremIndicator"
        Me.ucrReceiverExtremIndicator.Selector = Nothing
        Me.ucrReceiverExtremIndicator.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverExtremIndicator.strNcFilePath = ""
        Me.ucrReceiverExtremIndicator.TabIndex = 66
        Me.ucrReceiverExtremIndicator.ucrSelector = Nothing
        '
        'ucrReceiverRainIndicator
        '
        Me.ucrReceiverRainIndicator.AutoSize = True
        Me.ucrReceiverRainIndicator.frmParent = Me
        Me.ucrReceiverRainIndicator.Location = New System.Drawing.Point(495, 574)
        Me.ucrReceiverRainIndicator.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainIndicator.Name = "ucrReceiverRainIndicator"
        Me.ucrReceiverRainIndicator.Selector = Nothing
        Me.ucrReceiverRainIndicator.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverRainIndicator.strNcFilePath = ""
        Me.ucrReceiverRainIndicator.TabIndex = 64
        Me.ucrReceiverRainIndicator.ucrSelector = Nothing
        '
        'lblRainIndicator
        '
        Me.lblRainIndicator.AutoSize = True
        Me.lblRainIndicator.Location = New System.Drawing.Point(502, 549)
        Me.lblRainIndicator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRainIndicator.Name = "lblRainIndicator"
        Me.lblRainIndicator.Size = New System.Drawing.Size(170, 20)
        Me.lblRainIndicator.TabIndex = 63
        Me.lblRainIndicator.Text = "Rain Indicator Column:"
        '
        'lblExtremRain
        '
        Me.lblExtremRain.AutoSize = True
        Me.lblExtremRain.Location = New System.Drawing.Point(501, 615)
        Me.lblExtremRain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExtremRain.Name = "lblExtremRain"
        Me.lblExtremRain.Size = New System.Drawing.Size(175, 20)
        Me.lblExtremRain.TabIndex = 65
        Me.lblExtremRain.Text = "Extreme Rain Indicator:"
        '
        'lblExtremeTmaxIndicator
        '
        Me.lblExtremeTmaxIndicator.AutoSize = True
        Me.lblExtremeTmaxIndicator.Location = New System.Drawing.Point(500, 484)
        Me.lblExtremeTmaxIndicator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExtremeTmaxIndicator.Name = "lblExtremeTmaxIndicator"
        Me.lblExtremeTmaxIndicator.Size = New System.Drawing.Size(180, 20)
        Me.lblExtremeTmaxIndicator.TabIndex = 86
        Me.lblExtremeTmaxIndicator.Text = " Extreme tmax Indicator:"
        '
        'ucrReceiverExtremeTmaxIndicator
        '
        Me.ucrReceiverExtremeTmaxIndicator.AutoSize = True
        Me.ucrReceiverExtremeTmaxIndicator.frmParent = Me
        Me.ucrReceiverExtremeTmaxIndicator.Location = New System.Drawing.Point(494, 506)
        Me.ucrReceiverExtremeTmaxIndicator.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExtremeTmaxIndicator.Name = "ucrReceiverExtremeTmaxIndicator"
        Me.ucrReceiverExtremeTmaxIndicator.Selector = Nothing
        Me.ucrReceiverExtremeTmaxIndicator.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverExtremeTmaxIndicator.strNcFilePath = ""
        Me.ucrReceiverExtremeTmaxIndicator.TabIndex = 87
        Me.ucrReceiverExtremeTmaxIndicator.ucrSelector = Nothing
        '
        'lblExtremeTminIndicator
        '
        Me.lblExtremeTminIndicator.AutoSize = True
        Me.lblExtremeTminIndicator.Location = New System.Drawing.Point(499, 418)
        Me.lblExtremeTminIndicator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExtremeTminIndicator.Name = "lblExtremeTminIndicator"
        Me.lblExtremeTminIndicator.Size = New System.Drawing.Size(168, 20)
        Me.lblExtremeTminIndicator.TabIndex = 88
        Me.lblExtremeTminIndicator.Text = "Extreme tmin Indicator"
        '
        'ucrReceiverExtremeTminIndicator
        '
        Me.ucrReceiverExtremeTminIndicator.AutoSize = True
        Me.ucrReceiverExtremeTminIndicator.frmParent = Me
        Me.ucrReceiverExtremeTminIndicator.Location = New System.Drawing.Point(493, 440)
        Me.ucrReceiverExtremeTminIndicator.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExtremeTminIndicator.Name = "ucrReceiverExtremeTminIndicator"
        Me.ucrReceiverExtremeTminIndicator.Selector = Nothing
        Me.ucrReceiverExtremeTminIndicator.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverExtremeTminIndicator.strNcFilePath = ""
        Me.ucrReceiverExtremeTminIndicator.TabIndex = 89
        Me.ucrReceiverExtremeTminIndicator.ucrSelector = Nothing
        '
        'dlgExportClimaticDefinitions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(688, 834)
        Me.Controls.Add(Me.lblExtremeTminIndicator)
        Me.Controls.Add(Me.ucrReceiverExtremeTminIndicator)
        Me.Controls.Add(Me.lblExtremeTmaxIndicator)
        Me.Controls.Add(Me.ucrReceiverExtremeTmaxIndicator)
        Me.Controls.Add(Me.lblDataByYearMonth)
        Me.Controls.Add(Me.lblRainIndicator)
        Me.Controls.Add(Me.ucrReceiverRainIndicator)
        Me.Controls.Add(Me.lblExtremRain)
        Me.Controls.Add(Me.ucrReceiverExtremIndicator)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblExport)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.ucrInputTokenPath)
        Me.Controls.Add(Me.rdoUploadSummaries)
        Me.Controls.Add(Me.rdoUpdateMetadata)
        Me.Controls.Add(Me.ucrPnlExportGoogle)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.lblDefinitionsID)
        Me.Controls.Add(Me.ucrInputDefinitionsID)
        Me.Controls.Add(Me.cmdDefine)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.ucrInputCountry)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrChkIncludeSummaryData)
        Me.Controls.Add(Me.grpSummaries)
        Me.Controls.Add(Me.lblCropData)
        Me.Controls.Add(Me.lblDataByYear)
        Me.Controls.Add(Me.lblRain)
        Me.Controls.Add(Me.ucrReceiverRain)
        Me.Controls.Add(Me.ucrSelectorExportDefinitions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverDataYear)
        Me.Controls.Add(Me.ucrReceiverDataYearMonth)
        Me.Controls.Add(Me.ucrReceiverCropData)
        Me.Controls.Add(Me.lblDistrict)
        Me.Controls.Add(Me.lblElavation)
        Me.Controls.Add(Me.lblLatitude)
        Me.Controls.Add(Me.lblLongitude)
        Me.Controls.Add(Me.ucrReceiverLongititude)
        Me.Controls.Add(Me.ucrReceiverLatitude)
        Me.Controls.Add(Me.ucrReceiverElavation)
        Me.Controls.Add(Me.ucrReceiverDistrict)
        Me.Controls.Add(Me.ucrReceiverStationName)
        Me.Controls.Add(Me.lblStationName)
        Me.Controls.Add(Me.lblCountryMetada)
        Me.Controls.Add(Me.ucrInputCountryMetadata)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportClimaticDefinitions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export to Google Buckets"
        Me.grpSummaries.ResumeLayout(False)
        Me.grpSummaries.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblExport As Label
    Friend WithEvents cmdChooseFile As Button
    Friend WithEvents ucrInputTokenPath As ucrInputTextBox
    Friend WithEvents rdoUploadSummaries As RadioButton
    Friend WithEvents rdoUpdateMetadata As RadioButton
    Friend WithEvents ucrPnlExportGoogle As UcrPanel
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblDefinitionsID As Label
    Friend WithEvents ucrInputDefinitionsID As ucrInputTextBox
    Friend WithEvents cmdDefine As Button
    Friend WithEvents lblStation As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents ucrInputCountry As ucrInputTextBox
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrChkIncludeSummaryData As ucrCheck
    Friend WithEvents grpSummaries As GroupBox
    Friend WithEvents ucrChkMonthlyTemp As ucrCheck
    Friend WithEvents ucrChkSeasonStartProp As ucrCheck
    Friend WithEvents ucrChkExtremes As ucrCheck
    Friend WithEvents ucrChkCropSuccessProp As ucrCheck
    Friend WithEvents ucrChkAnnualTemp As ucrCheck
    Friend WithEvents ucrChkAnnualRainfall As ucrCheck
    Friend WithEvents lblCropData As Label
    Friend WithEvents lblDataByYearMonth As Label
    Friend WithEvents lblDataByYear As Label
    Friend WithEvents lblRain As Label
    Friend WithEvents ucrReceiverRain As ucrReceiverSingle
    Friend WithEvents ucrSelectorExportDefinitions As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverDataYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDataYearMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverCropData As ucrReceiverSingle
    Friend WithEvents lblDistrict As Label
    Friend WithEvents lblElavation As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents lblLongitude As Label
    Friend WithEvents ucrReceiverLongititude As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverElavation As ucrReceiverSingle
    Friend WithEvents ucrReceiverDistrict As ucrReceiverSingle
    Friend WithEvents ucrReceiverStationName As ucrReceiverSingle
    Friend WithEvents lblStationName As Label
    Friend WithEvents lblCountryMetada As Label
    Friend WithEvents ucrInputCountryMetadata As ucrInputTextBox
    Friend WithEvents ucrReceiverExtremIndicator As ucrReceiverSingle
    Friend WithEvents ucrReceiverRainIndicator As ucrReceiverSingle
    Friend WithEvents lblRainIndicator As Label
    Friend WithEvents lblExtremRain As Label
    Friend WithEvents lblExtremeTminIndicator As Label
    Friend WithEvents ucrReceiverExtremeTminIndicator As ucrReceiverSingle
    Friend WithEvents lblExtremeTmaxIndicator As Label
    Friend WithEvents ucrReceiverExtremeTmaxIndicator As ucrReceiverSingle
End Class
