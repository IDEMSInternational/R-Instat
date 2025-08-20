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
        Me.components = New System.ComponentModel.Container()
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
        Me.ucrChkIncludeSummaryData = New instat.ucrCheck()
        Me.grpSummaries = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverExtremIndicator = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainIndicator = New instat.ucrReceiverSingle()
        Me.lblRainIndicator = New System.Windows.Forms.Label()
        Me.lblExtremRain = New System.Windows.Forms.Label()
        Me.lblDataByYearMonth = New System.Windows.Forms.Label()
        Me.ucrChkMonthlyTemp = New instat.ucrCheck()
        Me.ucrChkSeasonStartProp = New instat.ucrCheck()
        Me.ucrChkCropSuccessProp = New instat.ucrCheck()
        Me.ucrChkAnnualTemp = New instat.ucrCheck()
        Me.ucrChkAnnualRainfall = New instat.ucrCheck()
        Me.lblCropData = New System.Windows.Forms.Label()
        Me.ucrReceiverCropData = New instat.ucrReceiverSingle()
        Me.lblDataByYear = New System.Windows.Forms.Label()
        Me.ucrReceiverDataYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDataYearMonth = New instat.ucrReceiverSingle()
        Me.ucrSelectorExportDefinitions = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
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
        Me.ucrInputComboCountry = New instat.ucrInputComboBox()
        Me.ucrInputComboCountryMetadata = New instat.ucrInputComboBox()
        Me.ttExportToGoogleBuckets = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpSummaries.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExport.Location = New System.Drawing.Point(105, 69)
        Me.lblExport.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(57, 20)
        Me.lblExport.TabIndex = 5
        Me.lblExport.Text = "Token:"
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdChooseFile.Location = New System.Drawing.Point(465, 62)
        Me.cmdChooseFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(120, 35)
        Me.cmdChooseFile.TabIndex = 4
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
        Me.ucrInputTokenPath.TabIndex = 3
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
        Me.rdoUploadSummaries.TabIndex = 2
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
        Me.rdoUpdateMetadata.TabIndex = 1
        Me.rdoUpdateMetadata.Text = "Update Metadata"
        Me.rdoUpdateMetadata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoUpdateMetadata.UseVisualStyleBackColor = True
        '
        'ucrPnlExportGoogle
        '
        Me.ucrPnlExportGoogle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlExportGoogle.Location = New System.Drawing.Point(166, 3)
        Me.ucrPnlExportGoogle.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlExportGoogle.Name = "ucrPnlExportGoogle"
        Me.ucrPnlExportGoogle.Size = New System.Drawing.Size(374, 51)
        Me.ucrPnlExportGoogle.TabIndex = 0
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(478, 143)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 20
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'lblDefinitionsID
        '
        Me.lblDefinitionsID.AutoSize = True
        Me.lblDefinitionsID.Location = New System.Drawing.Point(482, 244)
        Me.lblDefinitionsID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDefinitionsID.Name = "lblDefinitionsID"
        Me.lblDefinitionsID.Size = New System.Drawing.Size(109, 20)
        Me.lblDefinitionsID.TabIndex = 23
        Me.lblDefinitionsID.Text = "Definitions ID:"
        '
        'ucrInputDefinitionsID
        '
        Me.ucrInputDefinitionsID.AddQuotesIfUnrecognised = True
        Me.ucrInputDefinitionsID.AutoSize = True
        Me.ucrInputDefinitionsID.IsMultiline = False
        Me.ucrInputDefinitionsID.IsReadOnly = False
        Me.ucrInputDefinitionsID.Location = New System.Drawing.Point(478, 265)
        Me.ucrInputDefinitionsID.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputDefinitionsID.Name = "ucrInputDefinitionsID"
        Me.ucrInputDefinitionsID.Size = New System.Drawing.Size(180, 32)
        Me.ucrInputDefinitionsID.TabIndex = 24
        '
        'cmdDefine
        '
        Me.cmdDefine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDefine.Location = New System.Drawing.Point(466, 671)
        Me.cmdDefine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdDefine.Name = "cmdDefine"
        Me.cmdDefine.Size = New System.Drawing.Size(188, 38)
        Me.cmdDefine.TabIndex = 27
        Me.cmdDefine.Text = "Define"
        Me.cmdDefine.UseVisualStyleBackColor = True
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(482, 120)
        Me.lblStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(110, 20)
        Me.lblStation.TabIndex = 19
        Me.lblStation.Text = "Station Name:"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(482, 184)
        Me.lblCountry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(68, 20)
        Me.lblCountry.TabIndex = 21
        Me.lblCountry.Text = "Country:"
        '
        'ucrChkIncludeSummaryData
        '
        Me.ucrChkIncludeSummaryData.AutoSize = True
        Me.ucrChkIncludeSummaryData.Checked = False
        Me.ucrChkIncludeSummaryData.Location = New System.Drawing.Point(13, 675)
        Me.ucrChkIncludeSummaryData.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkIncludeSummaryData.Name = "ucrChkIncludeSummaryData"
        Me.ucrChkIncludeSummaryData.Size = New System.Drawing.Size(368, 48)
        Me.ucrChkIncludeSummaryData.TabIndex = 26
        '
        'grpSummaries
        '
        Me.grpSummaries.Controls.Add(Me.ucrReceiverExtremIndicator)
        Me.grpSummaries.Controls.Add(Me.ucrReceiverRainIndicator)
        Me.grpSummaries.Controls.Add(Me.lblRainIndicator)
        Me.grpSummaries.Controls.Add(Me.lblExtremRain)
        Me.grpSummaries.Controls.Add(Me.lblDataByYearMonth)
        Me.grpSummaries.Controls.Add(Me.ucrChkMonthlyTemp)
        Me.grpSummaries.Controls.Add(Me.ucrChkSeasonStartProp)
        Me.grpSummaries.Controls.Add(Me.ucrChkCropSuccessProp)
        Me.grpSummaries.Controls.Add(Me.ucrChkAnnualTemp)
        Me.grpSummaries.Controls.Add(Me.ucrChkAnnualRainfall)
        Me.grpSummaries.Controls.Add(Me.lblCropData)
        Me.grpSummaries.Controls.Add(Me.ucrReceiverCropData)
        Me.grpSummaries.Controls.Add(Me.lblDataByYear)
        Me.grpSummaries.Controls.Add(Me.ucrReceiverDataYear)
        Me.grpSummaries.Controls.Add(Me.ucrReceiverDataYearMonth)
        Me.grpSummaries.Location = New System.Drawing.Point(14, 396)
        Me.grpSummaries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpSummaries.Size = New System.Drawing.Size(669, 265)
        Me.grpSummaries.TabIndex = 25
        Me.grpSummaries.TabStop = False
        Me.grpSummaries.Text = "Summaries"
        '
        'ucrReceiverExtremIndicator
        '
        Me.ucrReceiverExtremIndicator.AutoSize = True
        Me.ucrReceiverExtremIndicator.frmParent = Me
        Me.ucrReceiverExtremIndicator.Location = New System.Drawing.Point(472, 101)
        Me.ucrReceiverExtremIndicator.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExtremIndicator.Name = "ucrReceiverExtremIndicator"
        Me.ucrReceiverExtremIndicator.Selector = Nothing
        Me.ucrReceiverExtremIndicator.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverExtremIndicator.strNcFilePath = ""
        Me.ucrReceiverExtremIndicator.TabIndex = 10
        Me.ucrReceiverExtremIndicator.ucrSelector = Nothing
        '
        'ucrReceiverRainIndicator
        '
        Me.ucrReceiverRainIndicator.AutoSize = True
        Me.ucrReceiverRainIndicator.frmParent = Me
        Me.ucrReceiverRainIndicator.Location = New System.Drawing.Point(472, 63)
        Me.ucrReceiverRainIndicator.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainIndicator.Name = "ucrReceiverRainIndicator"
        Me.ucrReceiverRainIndicator.Selector = Nothing
        Me.ucrReceiverRainIndicator.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverRainIndicator.strNcFilePath = ""
        Me.ucrReceiverRainIndicator.TabIndex = 8
        Me.ucrReceiverRainIndicator.ucrSelector = Nothing
        '
        'lblRainIndicator
        '
        Me.lblRainIndicator.AutoSize = True
        Me.lblRainIndicator.Location = New System.Drawing.Point(298, 65)
        Me.lblRainIndicator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRainIndicator.Name = "lblRainIndicator"
        Me.lblRainIndicator.Size = New System.Drawing.Size(170, 20)
        Me.lblRainIndicator.TabIndex = 7
        Me.lblRainIndicator.Text = "Rain Indicator Column:"
        '
        'lblExtremRain
        '
        Me.lblExtremRain.AutoSize = True
        Me.lblExtremRain.Location = New System.Drawing.Point(293, 103)
        Me.lblExtremRain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExtremRain.Name = "lblExtremRain"
        Me.lblExtremRain.Size = New System.Drawing.Size(175, 20)
        Me.lblExtremRain.TabIndex = 9
        Me.lblExtremRain.Text = "Extreme Rain Indicator:"
        '
        'lblDataByYearMonth
        '
        Me.lblDataByYearMonth.AutoSize = True
        Me.lblDataByYearMonth.Location = New System.Drawing.Point(280, 145)
        Me.lblDataByYearMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataByYearMonth.Name = "lblDataByYearMonth"
        Me.lblDataByYearMonth.Size = New System.Drawing.Size(188, 20)
        Me.lblDataByYearMonth.TabIndex = 11
        Me.lblDataByYearMonth.Text = "Data By Year and Month:"
        '
        'ucrChkMonthlyTemp
        '
        Me.ucrChkMonthlyTemp.AutoSize = True
        Me.ucrChkMonthlyTemp.Checked = False
        Me.ucrChkMonthlyTemp.Location = New System.Drawing.Point(12, 140)
        Me.ucrChkMonthlyTemp.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkMonthlyTemp.Name = "ucrChkMonthlyTemp"
        Me.ucrChkMonthlyTemp.Size = New System.Drawing.Size(220, 34)
        Me.ucrChkMonthlyTemp.TabIndex = 2
        '
        'ucrChkSeasonStartProp
        '
        Me.ucrChkSeasonStartProp.AutoSize = True
        Me.ucrChkSeasonStartProp.Checked = False
        Me.ucrChkSeasonStartProp.Location = New System.Drawing.Point(12, 224)
        Me.ucrChkSeasonStartProp.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkSeasonStartProp.Name = "ucrChkSeasonStartProp"
        Me.ucrChkSeasonStartProp.Size = New System.Drawing.Size(226, 37)
        Me.ucrChkSeasonStartProp.TabIndex = 4
        '
        'ucrChkCropSuccessProp
        '
        Me.ucrChkCropSuccessProp.AutoSize = True
        Me.ucrChkCropSuccessProp.Checked = False
        Me.ucrChkCropSuccessProp.Location = New System.Drawing.Point(12, 182)
        Me.ucrChkCropSuccessProp.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkCropSuccessProp.Name = "ucrChkCropSuccessProp"
        Me.ucrChkCropSuccessProp.Size = New System.Drawing.Size(230, 34)
        Me.ucrChkCropSuccessProp.TabIndex = 3
        '
        'ucrChkAnnualTemp
        '
        Me.ucrChkAnnualTemp.AutoSize = True
        Me.ucrChkAnnualTemp.Checked = False
        Me.ucrChkAnnualTemp.Location = New System.Drawing.Point(12, 66)
        Me.ucrChkAnnualTemp.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkAnnualTemp.Name = "ucrChkAnnualTemp"
        Me.ucrChkAnnualTemp.Size = New System.Drawing.Size(224, 34)
        Me.ucrChkAnnualTemp.TabIndex = 1
        '
        'ucrChkAnnualRainfall
        '
        Me.ucrChkAnnualRainfall.AutoSize = True
        Me.ucrChkAnnualRainfall.Checked = False
        Me.ucrChkAnnualRainfall.Location = New System.Drawing.Point(12, 24)
        Me.ucrChkAnnualRainfall.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkAnnualRainfall.Name = "ucrChkAnnualRainfall"
        Me.ucrChkAnnualRainfall.Size = New System.Drawing.Size(224, 34)
        Me.ucrChkAnnualRainfall.TabIndex = 0
        '
        'lblCropData
        '
        Me.lblCropData.AutoSize = True
        Me.lblCropData.Location = New System.Drawing.Point(382, 184)
        Me.lblCropData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCropData.Name = "lblCropData"
        Me.lblCropData.Size = New System.Drawing.Size(86, 20)
        Me.lblCropData.TabIndex = 13
        Me.lblCropData.Text = "Crop Data:"
        '
        'ucrReceiverCropData
        '
        Me.ucrReceiverCropData.AutoSize = True
        Me.ucrReceiverCropData.frmParent = Me
        Me.ucrReceiverCropData.Location = New System.Drawing.Point(472, 182)
        Me.ucrReceiverCropData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCropData.Name = "ucrReceiverCropData"
        Me.ucrReceiverCropData.Selector = Nothing
        Me.ucrReceiverCropData.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverCropData.strNcFilePath = ""
        Me.ucrReceiverCropData.TabIndex = 14
        Me.ucrReceiverCropData.ucrSelector = Nothing
        '
        'lblDataByYear
        '
        Me.lblDataByYear.AutoSize = True
        Me.lblDataByYear.Location = New System.Drawing.Point(360, 24)
        Me.lblDataByYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataByYear.Name = "lblDataByYear"
        Me.lblDataByYear.Size = New System.Drawing.Size(108, 20)
        Me.lblDataByYear.TabIndex = 5
        Me.lblDataByYear.Text = "Data By Year:"
        '
        'ucrReceiverDataYear
        '
        Me.ucrReceiverDataYear.AutoSize = True
        Me.ucrReceiverDataYear.frmParent = Me
        Me.ucrReceiverDataYear.Location = New System.Drawing.Point(472, 22)
        Me.ucrReceiverDataYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataYear.Name = "ucrReceiverDataYear"
        Me.ucrReceiverDataYear.Selector = Nothing
        Me.ucrReceiverDataYear.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverDataYear.strNcFilePath = ""
        Me.ucrReceiverDataYear.TabIndex = 6
        Me.ucrReceiverDataYear.ucrSelector = Nothing
        '
        'ucrReceiverDataYearMonth
        '
        Me.ucrReceiverDataYearMonth.AutoSize = True
        Me.ucrReceiverDataYearMonth.frmParent = Me
        Me.ucrReceiverDataYearMonth.Location = New System.Drawing.Point(472, 143)
        Me.ucrReceiverDataYearMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataYearMonth.Name = "ucrReceiverDataYearMonth"
        Me.ucrReceiverDataYearMonth.Selector = Nothing
        Me.ucrReceiverDataYearMonth.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverDataYearMonth.strNcFilePath = ""
        Me.ucrReceiverDataYearMonth.TabIndex = 12
        Me.ucrReceiverDataYearMonth.ucrSelector = Nothing
        '
        'ucrSelectorExportDefinitions
        '
        Me.ucrSelectorExportDefinitions.AutoSize = True
        Me.ucrSelectorExportDefinitions.bDropUnusedFilterLevels = False
        Me.ucrSelectorExportDefinitions.bShowHiddenColumns = False
        Me.ucrSelectorExportDefinitions.bUseCurrentFilter = True
        Me.ucrSelectorExportDefinitions.Location = New System.Drawing.Point(13, 109)
        Me.ucrSelectorExportDefinitions.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorExportDefinitions.Name = "ucrSelectorExportDefinitions"
        Me.ucrSelectorExportDefinitions.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelectorExportDefinitions.TabIndex = 6
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(14, 738)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 28
        '
        'lblDistrict
        '
        Me.lblDistrict.AutoSize = True
        Me.lblDistrict.Location = New System.Drawing.Point(482, 375)
        Me.lblDistrict.Name = "lblDistrict"
        Me.lblDistrict.Size = New System.Drawing.Size(62, 20)
        Me.lblDistrict.TabIndex = 15
        Me.lblDistrict.Text = "District:"
        '
        'lblElavation
        '
        Me.lblElavation.AutoSize = True
        Me.lblElavation.Location = New System.Drawing.Point(482, 309)
        Me.lblElavation.Name = "lblElavation"
        Me.lblElavation.Size = New System.Drawing.Size(78, 20)
        Me.lblElavation.TabIndex = 13
        Me.lblElavation.Text = "Elevation:"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Location = New System.Drawing.Point(482, 247)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(71, 20)
        Me.lblLatitude.TabIndex = 11
        Me.lblLatitude.Text = "Latitude:"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Location = New System.Drawing.Point(482, 185)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(84, 20)
        Me.lblLongitude.TabIndex = 9
        Me.lblLongitude.Text = "Longitude:"
        '
        'ucrReceiverLongititude
        '
        Me.ucrReceiverLongititude.AutoSize = True
        Me.ucrReceiverLongititude.frmParent = Me
        Me.ucrReceiverLongititude.Location = New System.Drawing.Point(478, 205)
        Me.ucrReceiverLongititude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongititude.Name = "ucrReceiverLongititude"
        Me.ucrReceiverLongititude.Selector = Nothing
        Me.ucrReceiverLongititude.Size = New System.Drawing.Size(180, 35)
        Me.ucrReceiverLongititude.strNcFilePath = ""
        Me.ucrReceiverLongititude.TabIndex = 10
        Me.ucrReceiverLongititude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(478, 267)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 12
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverElavation
        '
        Me.ucrReceiverElavation.AutoSize = True
        Me.ucrReceiverElavation.frmParent = Me
        Me.ucrReceiverElavation.Location = New System.Drawing.Point(478, 329)
        Me.ucrReceiverElavation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElavation.Name = "ucrReceiverElavation"
        Me.ucrReceiverElavation.Selector = Nothing
        Me.ucrReceiverElavation.Size = New System.Drawing.Size(180, 35)
        Me.ucrReceiverElavation.strNcFilePath = ""
        Me.ucrReceiverElavation.TabIndex = 14
        Me.ucrReceiverElavation.ucrSelector = Nothing
        '
        'ucrReceiverDistrict
        '
        Me.ucrReceiverDistrict.AutoSize = True
        Me.ucrReceiverDistrict.frmParent = Me
        Me.ucrReceiverDistrict.Location = New System.Drawing.Point(478, 396)
        Me.ucrReceiverDistrict.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDistrict.Name = "ucrReceiverDistrict"
        Me.ucrReceiverDistrict.Selector = Nothing
        Me.ucrReceiverDistrict.Size = New System.Drawing.Size(180, 43)
        Me.ucrReceiverDistrict.strNcFilePath = ""
        Me.ucrReceiverDistrict.TabIndex = 16
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
        Me.ucrReceiverStationName.TabIndex = 8
        Me.ucrReceiverStationName.ucrSelector = Nothing
        '
        'lblStationName
        '
        Me.lblStationName.AutoSize = True
        Me.lblStationName.Location = New System.Drawing.Point(482, 120)
        Me.lblStationName.Name = "lblStationName"
        Me.lblStationName.Size = New System.Drawing.Size(110, 20)
        Me.lblStationName.TabIndex = 7
        Me.lblStationName.Text = "Station Name:"
        '
        'lblCountryMetada
        '
        Me.lblCountryMetada.AutoSize = True
        Me.lblCountryMetada.Location = New System.Drawing.Point(482, 439)
        Me.lblCountryMetada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountryMetada.Name = "lblCountryMetada"
        Me.lblCountryMetada.Size = New System.Drawing.Size(68, 20)
        Me.lblCountryMetada.TabIndex = 17
        Me.lblCountryMetada.Text = "Country:"
        '
        'ucrInputComboCountry
        '
        Me.ucrInputComboCountry.AddQuotesIfUnrecognised = True
        Me.ucrInputComboCountry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboCountry.GetSetSelectedIndex = -1
        Me.ucrInputComboCountry.IsReadOnly = False
        Me.ucrInputComboCountry.Location = New System.Drawing.Point(478, 206)
        Me.ucrInputComboCountry.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputComboCountry.Name = "ucrInputComboCountry"
        Me.ucrInputComboCountry.Size = New System.Drawing.Size(180, 32)
        Me.ucrInputComboCountry.TabIndex = 22
        '
        'ucrInputComboCountryMetadata
        '
        Me.ucrInputComboCountryMetadata.AddQuotesIfUnrecognised = True
        Me.ucrInputComboCountryMetadata.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboCountryMetadata.GetSetSelectedIndex = -1
        Me.ucrInputComboCountryMetadata.IsReadOnly = False
        Me.ucrInputComboCountryMetadata.Location = New System.Drawing.Point(478, 463)
        Me.ucrInputComboCountryMetadata.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputComboCountryMetadata.Name = "ucrInputComboCountryMetadata"
        Me.ucrInputComboCountryMetadata.Size = New System.Drawing.Size(180, 32)
        Me.ucrInputComboCountryMetadata.TabIndex = 18
        '
        'dlgExportClimaticDefinitions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(698, 819)
        Me.Controls.Add(Me.grpSummaries)
        Me.Controls.Add(Me.ucrInputComboCountryMetadata)
        Me.Controls.Add(Me.ucrInputComboCountry)
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
        Me.Controls.Add(Me.ucrChkIncludeSummaryData)
        Me.Controls.Add(Me.ucrSelectorExportDefinitions)
        Me.Controls.Add(Me.ucrBase)
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
    Friend WithEvents ucrChkIncludeSummaryData As ucrCheck
    Friend WithEvents grpSummaries As GroupBox
    Friend WithEvents ucrChkMonthlyTemp As ucrCheck
    Friend WithEvents ucrChkSeasonStartProp As ucrCheck
    Friend WithEvents ucrChkCropSuccessProp As ucrCheck
    Friend WithEvents ucrChkAnnualTemp As ucrCheck
    Friend WithEvents ucrChkAnnualRainfall As ucrCheck
    Friend WithEvents lblCropData As Label
    Friend WithEvents lblDataByYearMonth As Label
    Friend WithEvents lblDataByYear As Label
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
    Friend WithEvents ucrReceiverExtremIndicator As ucrReceiverSingle
    Friend WithEvents ucrReceiverRainIndicator As ucrReceiverSingle
    Friend WithEvents lblRainIndicator As Label
    Friend WithEvents lblExtremRain As Label
    Friend WithEvents ucrInputComboCountryMetadata As ucrInputComboBox
    Friend WithEvents ucrInputComboCountry As ucrInputComboBox
    Friend WithEvents ttExportToGoogleBuckets As ToolTip
End Class
