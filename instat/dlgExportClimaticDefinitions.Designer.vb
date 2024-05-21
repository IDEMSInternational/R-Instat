<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgExportClimaticDefinitions
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
        Me.lblStationID = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.ucrChkSeasonStartProp = New instat.ucrCheck()
        Me.ucrChkExtremes = New instat.ucrCheck()
        Me.ucrChkCropSuccessProp = New instat.ucrCheck()
        Me.ucrChkAnnualTemp = New instat.ucrCheck()
        Me.ucrChkAnnualRainfall = New instat.ucrCheck()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrChkIncludeSummaryData = New instat.ucrCheck()
        Me.grpSummaries = New System.Windows.Forms.GroupBox()
        Me.ucrChkMonthlyTemp = New instat.ucrCheck()
        Me.lblMaxTemp = New System.Windows.Forms.Label()
        Me.lblCropData = New System.Windows.Forms.Label()
        Me.lblDataByYearMonth = New System.Windows.Forms.Label()
        Me.lblDataByYear = New System.Windows.Forms.Label()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.lblMinTemp = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.ucrReceiverRain = New instat.ucrReceiverSingle()
        Me.ucrReceiverMinTemp = New instat.ucrReceiverSingle()
        Me.ucrReceiverMaxTemp = New instat.ucrReceiverSingle()
        Me.ucrReceiverData = New instat.ucrReceiverSingle()
        Me.ucrSelectorExportDefinitions = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverDataYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDataYearMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverCropData = New instat.ucrReceiverSingle()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.cmdChooseFile = New System.Windows.Forms.Button()
        Me.ucrInputTokenPath = New instat.ucrInputTextBox()
        Me.cmdDefine = New System.Windows.Forms.Button()
        Me.ucrInputCountry = New instat.ucrInputTextBox()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.grpSummaries.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStationID
        '
        Me.lblStationID.AutoSize = True
        Me.lblStationID.Location = New System.Drawing.Point(334, 126)
        Me.lblStationID.Name = "lblStationID"
        Me.lblStationID.Size = New System.Drawing.Size(57, 13)
        Me.lblStationID.TabIndex = 7
        Me.lblStationID.Text = "Station ID:"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(336, 163)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(46, 13)
        Me.lblCountry.TabIndex = 9
        Me.lblCountry.Text = "Country:"
        '
        'ucrChkSeasonStartProp
        '
        Me.ucrChkSeasonStartProp.AutoSize = True
        Me.ucrChkSeasonStartProp.Checked = False
        Me.ucrChkSeasonStartProp.Location = New System.Drawing.Point(157, 46)
        Me.ucrChkSeasonStartProp.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkSeasonStartProp.Name = "ucrChkSeasonStartProp"
        Me.ucrChkSeasonStartProp.Size = New System.Drawing.Size(151, 34)
        Me.ucrChkSeasonStartProp.TabIndex = 3
        '
        'ucrChkExtremes
        '
        Me.ucrChkExtremes.AutoSize = True
        Me.ucrChkExtremes.Checked = False
        Me.ucrChkExtremes.Location = New System.Drawing.Point(157, 78)
        Me.ucrChkExtremes.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkExtremes.Name = "ucrChkExtremes"
        Me.ucrChkExtremes.Size = New System.Drawing.Size(147, 34)
        Me.ucrChkExtremes.TabIndex = 5
        Me.ucrChkExtremes.Visible = False
        '
        'ucrChkCropSuccessProp
        '
        Me.ucrChkCropSuccessProp.AutoSize = True
        Me.ucrChkCropSuccessProp.Checked = False
        Me.ucrChkCropSuccessProp.Location = New System.Drawing.Point(157, 18)
        Me.ucrChkCropSuccessProp.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkCropSuccessProp.Name = "ucrChkCropSuccessProp"
        Me.ucrChkCropSuccessProp.Size = New System.Drawing.Size(153, 34)
        Me.ucrChkCropSuccessProp.TabIndex = 1
        '
        'ucrChkAnnualTemp
        '
        Me.ucrChkAnnualTemp.AutoSize = True
        Me.ucrChkAnnualTemp.Checked = False
        Me.ucrChkAnnualTemp.Location = New System.Drawing.Point(8, 46)
        Me.ucrChkAnnualTemp.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkAnnualTemp.Name = "ucrChkAnnualTemp"
        Me.ucrChkAnnualTemp.Size = New System.Drawing.Size(149, 34)
        Me.ucrChkAnnualTemp.TabIndex = 2
        '
        'ucrChkAnnualRainfall
        '
        Me.ucrChkAnnualRainfall.AutoSize = True
        Me.ucrChkAnnualRainfall.Checked = False
        Me.ucrChkAnnualRainfall.Location = New System.Drawing.Point(8, 18)
        Me.ucrChkAnnualRainfall.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkAnnualRainfall.Name = "ucrChkAnnualRainfall"
        Me.ucrChkAnnualRainfall.Size = New System.Drawing.Size(149, 34)
        Me.ucrChkAnnualRainfall.TabIndex = 0
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(336, 87)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 5
        Me.lblMonth.Text = "Month:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(337, 49)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "Year:"
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.AutoSize = True
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(332, 104)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 6
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(333, 65)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 4
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(79, 457)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 30
        '
        'ucrChkIncludeSummaryData
        '
        Me.ucrChkIncludeSummaryData.AutoSize = True
        Me.ucrChkIncludeSummaryData.Checked = False
        Me.ucrChkIncludeSummaryData.Location = New System.Drawing.Point(4, 333)
        Me.ucrChkIncludeSummaryData.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkIncludeSummaryData.Name = "ucrChkIncludeSummaryData"
        Me.ucrChkIncludeSummaryData.Size = New System.Drawing.Size(221, 31)
        Me.ucrChkIncludeSummaryData.TabIndex = 24
        '
        'grpSummaries
        '
        Me.grpSummaries.Controls.Add(Me.ucrChkMonthlyTemp)
        Me.grpSummaries.Controls.Add(Me.ucrChkSeasonStartProp)
        Me.grpSummaries.Controls.Add(Me.ucrChkExtremes)
        Me.grpSummaries.Controls.Add(Me.ucrChkCropSuccessProp)
        Me.grpSummaries.Controls.Add(Me.ucrChkAnnualTemp)
        Me.grpSummaries.Controls.Add(Me.ucrChkAnnualRainfall)
        Me.grpSummaries.Location = New System.Drawing.Point(4, 211)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Size = New System.Drawing.Size(313, 115)
        Me.grpSummaries.TabIndex = 23
        Me.grpSummaries.TabStop = False
        Me.grpSummaries.Text = "Summaries"
        '
        'ucrChkMonthlyTemp
        '
        Me.ucrChkMonthlyTemp.AutoSize = True
        Me.ucrChkMonthlyTemp.Checked = False
        Me.ucrChkMonthlyTemp.Location = New System.Drawing.Point(8, 78)
        Me.ucrChkMonthlyTemp.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkMonthlyTemp.Name = "ucrChkMonthlyTemp"
        Me.ucrChkMonthlyTemp.Size = New System.Drawing.Size(147, 34)
        Me.ucrChkMonthlyTemp.TabIndex = 4
        '
        'lblMaxTemp
        '
        Me.lblMaxTemp.AutoSize = True
        Me.lblMaxTemp.Location = New System.Drawing.Point(336, 413)
        Me.lblMaxTemp.Name = "lblMaxTemp"
        Me.lblMaxTemp.Size = New System.Drawing.Size(60, 13)
        Me.lblMaxTemp.TabIndex = 21
        Me.lblMaxTemp.Text = "Max Temp:"
        '
        'lblCropData
        '
        Me.lblCropData.AutoSize = True
        Me.lblCropData.Location = New System.Drawing.Point(336, 287)
        Me.lblCropData.Name = "lblCropData"
        Me.lblCropData.Size = New System.Drawing.Size(58, 13)
        Me.lblCropData.TabIndex = 15
        Me.lblCropData.Text = "Crop Data:"
        '
        'lblDataByYearMonth
        '
        Me.lblDataByYearMonth.AutoSize = True
        Me.lblDataByYearMonth.Location = New System.Drawing.Point(333, 245)
        Me.lblDataByYearMonth.Name = "lblDataByYearMonth"
        Me.lblDataByYearMonth.Size = New System.Drawing.Size(127, 13)
        Me.lblDataByYearMonth.TabIndex = 13
        Me.lblDataByYearMonth.Text = "Data By Year and Month:"
        '
        'lblDataByYear
        '
        Me.lblDataByYear.AutoSize = True
        Me.lblDataByYear.Location = New System.Drawing.Point(336, 202)
        Me.lblDataByYear.Name = "lblDataByYear"
        Me.lblDataByYear.Size = New System.Drawing.Size(73, 13)
        Me.lblDataByYear.TabIndex = 11
        Me.lblDataByYear.Text = "Data By Year:"
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(336, 328)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(32, 13)
        Me.lblRain.TabIndex = 17
        Me.lblRain.Text = "Rain:"
        '
        'lblMinTemp
        '
        Me.lblMinTemp.AutoSize = True
        Me.lblMinTemp.Location = New System.Drawing.Point(336, 371)
        Me.lblMinTemp.Name = "lblMinTemp"
        Me.lblMinTemp.Size = New System.Drawing.Size(57, 13)
        Me.lblMinTemp.TabIndex = 19
        Me.lblMinTemp.Text = "Min Temp:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(332, 9)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(59, 13)
        Me.lblData.TabIndex = 1
        Me.lblData.Text = "Dataframe:"
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.AutoSize = True
        Me.ucrReceiverRain.frmParent = Me
        Me.ucrReceiverRain.Location = New System.Drawing.Point(334, 345)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRain.strNcFilePath = ""
        Me.ucrReceiverRain.TabIndex = 18
        Me.ucrReceiverRain.ucrSelector = Nothing
        '
        'ucrReceiverMinTemp
        '
        Me.ucrReceiverMinTemp.AutoSize = True
        Me.ucrReceiverMinTemp.frmParent = Me
        Me.ucrReceiverMinTemp.Location = New System.Drawing.Point(334, 388)
        Me.ucrReceiverMinTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinTemp.Name = "ucrReceiverMinTemp"
        Me.ucrReceiverMinTemp.Selector = Nothing
        Me.ucrReceiverMinTemp.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMinTemp.strNcFilePath = ""
        Me.ucrReceiverMinTemp.TabIndex = 20
        Me.ucrReceiverMinTemp.ucrSelector = Nothing
        '
        'ucrReceiverMaxTemp
        '
        Me.ucrReceiverMaxTemp.AutoSize = True
        Me.ucrReceiverMaxTemp.frmParent = Me
        Me.ucrReceiverMaxTemp.Location = New System.Drawing.Point(334, 431)
        Me.ucrReceiverMaxTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxTemp.Name = "ucrReceiverMaxTemp"
        Me.ucrReceiverMaxTemp.Selector = Nothing
        Me.ucrReceiverMaxTemp.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMaxTemp.strNcFilePath = ""
        Me.ucrReceiverMaxTemp.TabIndex = 22
        Me.ucrReceiverMaxTemp.ucrSelector = Nothing
        '
        'ucrReceiverData
        '
        Me.ucrReceiverData.AutoSize = True
        Me.ucrReceiverData.frmParent = Me
        Me.ucrReceiverData.Location = New System.Drawing.Point(330, 26)
        Me.ucrReceiverData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverData.Name = "ucrReceiverData"
        Me.ucrReceiverData.Selector = Nothing
        Me.ucrReceiverData.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverData.strNcFilePath = ""
        Me.ucrReceiverData.TabIndex = 2
        Me.ucrReceiverData.ucrSelector = Nothing
        '
        'ucrSelectorExportDefinitions
        '
        Me.ucrSelectorExportDefinitions.AutoSize = True
        Me.ucrSelectorExportDefinitions.bDropUnusedFilterLevels = False
        Me.ucrSelectorExportDefinitions.bShowHiddenColumns = False
        Me.ucrSelectorExportDefinitions.bUseCurrentFilter = True
        Me.ucrSelectorExportDefinitions.Location = New System.Drawing.Point(4, 8)
        Me.ucrSelectorExportDefinitions.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorExportDefinitions.Name = "ucrSelectorExportDefinitions"
        Me.ucrSelectorExportDefinitions.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorExportDefinitions.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(4, 458)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 60)
        Me.ucrBase.TabIndex = 29
        '
        'ucrReceiverDataYear
        '
        Me.ucrReceiverDataYear.AutoSize = True
        Me.ucrReceiverDataYear.frmParent = Me
        Me.ucrReceiverDataYear.Location = New System.Drawing.Point(334, 219)
        Me.ucrReceiverDataYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataYear.Name = "ucrReceiverDataYear"
        Me.ucrReceiverDataYear.Selector = Nothing
        Me.ucrReceiverDataYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDataYear.strNcFilePath = ""
        Me.ucrReceiverDataYear.TabIndex = 12
        Me.ucrReceiverDataYear.ucrSelector = Nothing
        '
        'ucrReceiverDataYearMonth
        '
        Me.ucrReceiverDataYearMonth.AutoSize = True
        Me.ucrReceiverDataYearMonth.frmParent = Me
        Me.ucrReceiverDataYearMonth.Location = New System.Drawing.Point(334, 262)
        Me.ucrReceiverDataYearMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataYearMonth.Name = "ucrReceiverDataYearMonth"
        Me.ucrReceiverDataYearMonth.Selector = Nothing
        Me.ucrReceiverDataYearMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDataYearMonth.strNcFilePath = ""
        Me.ucrReceiverDataYearMonth.TabIndex = 14
        Me.ucrReceiverDataYearMonth.ucrSelector = Nothing
        '
        'ucrReceiverCropData
        '
        Me.ucrReceiverCropData.AutoSize = True
        Me.ucrReceiverCropData.frmParent = Me
        Me.ucrReceiverCropData.Location = New System.Drawing.Point(334, 303)
        Me.ucrReceiverCropData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCropData.Name = "ucrReceiverCropData"
        Me.ucrReceiverCropData.Selector = Nothing
        Me.ucrReceiverCropData.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCropData.strNcFilePath = ""
        Me.ucrReceiverCropData.TabIndex = 16
        Me.ucrReceiverCropData.ucrSelector = Nothing
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExport.Location = New System.Drawing.Point(7, 392)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(41, 13)
        Me.lblExport.TabIndex = 26
        Me.lblExport.Text = "Token:"
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdChooseFile.Location = New System.Drawing.Point(253, 387)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(80, 23)
        Me.cmdChooseFile.TabIndex = 28
        Me.cmdChooseFile.Text = "Browse"
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'ucrInputTokenPath
        '
        Me.ucrInputTokenPath.AddQuotesIfUnrecognised = True
        Me.ucrInputTokenPath.AutoSize = True
        Me.ucrInputTokenPath.IsMultiline = False
        Me.ucrInputTokenPath.IsReadOnly = False
        Me.ucrInputTokenPath.Location = New System.Drawing.Point(67, 389)
        Me.ucrInputTokenPath.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputTokenPath.Name = "ucrInputTokenPath"
        Me.ucrInputTokenPath.Size = New System.Drawing.Size(182, 21)
        Me.ucrInputTokenPath.TabIndex = 27
        '
        'cmdDefine
        '
        Me.cmdDefine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDefine.Location = New System.Drawing.Point(225, 333)
        Me.cmdDefine.Name = "cmdDefine"
        Me.cmdDefine.Size = New System.Drawing.Size(80, 29)
        Me.cmdDefine.TabIndex = 25
        Me.cmdDefine.Text = "Define"
        Me.cmdDefine.UseVisualStyleBackColor = True
        '
        'ucrInputCountry
        '
        Me.ucrInputCountry.AddQuotesIfUnrecognised = True
        Me.ucrInputCountry.AutoSize = True
        Me.ucrInputCountry.IsMultiline = False
        Me.ucrInputCountry.IsReadOnly = False
        Me.ucrInputCountry.Location = New System.Drawing.Point(334, 178)
        Me.ucrInputCountry.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputCountry.Name = "ucrInputCountry"
        Me.ucrInputCountry.Size = New System.Drawing.Size(118, 21)
        Me.ucrInputCountry.TabIndex = 10
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(332, 139)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 31
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'dlgExportClimaticDefinitions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(455, 487)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.cmdDefine)
        Me.Controls.Add(Me.lblExport)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.ucrInputTokenPath)
        Me.Controls.Add(Me.lblStationID)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.ucrInputCountry)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrChkIncludeSummaryData)
        Me.Controls.Add(Me.grpSummaries)
        Me.Controls.Add(Me.lblMaxTemp)
        Me.Controls.Add(Me.lblCropData)
        Me.Controls.Add(Me.lblDataByYearMonth)
        Me.Controls.Add(Me.lblDataByYear)
        Me.Controls.Add(Me.lblRain)
        Me.Controls.Add(Me.lblMinTemp)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.ucrReceiverRain)
        Me.Controls.Add(Me.ucrReceiverMinTemp)
        Me.Controls.Add(Me.ucrReceiverMaxTemp)
        Me.Controls.Add(Me.ucrReceiverData)
        Me.Controls.Add(Me.ucrSelectorExportDefinitions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverDataYear)
        Me.Controls.Add(Me.ucrReceiverDataYearMonth)
        Me.Controls.Add(Me.ucrReceiverCropData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportClimaticDefinitions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Climatic Definitions"
        Me.grpSummaries.ResumeLayout(False)
        Me.grpSummaries.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStationID As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents ucrChkSeasonStartProp As ucrCheck
    Friend WithEvents ucrChkExtremes As ucrCheck
    Friend WithEvents ucrChkCropSuccessProp As ucrCheck
    Friend WithEvents ucrChkAnnualTemp As ucrCheck
    Friend WithEvents ucrChkAnnualRainfall As ucrCheck
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrChkIncludeSummaryData As ucrCheck
    Friend WithEvents grpSummaries As GroupBox
    Friend WithEvents ucrChkMonthlyTemp As ucrCheck
    Friend WithEvents lblMaxTemp As Label
    Friend WithEvents lblCropData As Label
    Friend WithEvents lblDataByYearMonth As Label
    Friend WithEvents lblDataByYear As Label
    Friend WithEvents lblRain As Label
    Friend WithEvents lblMinTemp As Label
    Friend WithEvents lblData As Label
    Friend WithEvents ucrReceiverRain As ucrReceiverSingle
    Friend WithEvents ucrReceiverMinTemp As ucrReceiverSingle
    Friend WithEvents ucrReceiverMaxTemp As ucrReceiverSingle
    Friend WithEvents ucrReceiverData As ucrReceiverSingle
    Friend WithEvents ucrSelectorExportDefinitions As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverDataYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDataYearMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverCropData As ucrReceiverSingle
    Friend WithEvents lblExport As Label
    Friend WithEvents cmdChooseFile As Button
    Friend WithEvents ucrInputTokenPath As ucrInputTextBox
    Friend WithEvents cmdDefine As Button
    Friend WithEvents ucrInputCountry As ucrInputTextBox
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
End Class
