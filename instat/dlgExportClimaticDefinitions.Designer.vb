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
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblMinTemp = New System.Windows.Forms.Label()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.lblDataByYear = New System.Windows.Forms.Label()
        Me.lblDataByYearMonth = New System.Windows.Forms.Label()
        Me.lblCropData = New System.Windows.Forms.Label()
        Me.lblMaxTemp = New System.Windows.Forms.Label()
        Me.grpSummaries = New System.Windows.Forms.GroupBox()
        Me.ucrChkMonthlyTemp = New instat.ucrCheck()
        Me.ucrChkSeasonStartProp = New instat.ucrCheck()
        Me.ucrChkExtremes = New instat.ucrCheck()
        Me.ucrChkCropSuccessProp = New instat.ucrCheck()
        Me.ucrChkAnnualTemp = New instat.ucrCheck()
        Me.ucrChkAnnualRainfall = New instat.ucrCheck()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrChkIncludeSummaryData = New instat.ucrCheck()
        Me.ucrReceiverDataYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDataYearMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverCropData = New instat.ucrReceiverSingle()
        Me.ucrReceiverRain = New instat.ucrReceiverSingle()
        Me.ucrReceiverMinTemp = New instat.ucrReceiverSingle()
        Me.ucrReceiverMaxTemp = New instat.ucrReceiverSingle()
        Me.ucrReceiverData = New instat.ucrReceiverSingle()
        Me.ucrSelectorExportDefinitions = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputStationID = New instat.ucrInputTextBox()
        Me.ucrInputCountry = New instat.ucrInputTextBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblStationID = New System.Windows.Forms.Label()
        Me.cmdDefine = New System.Windows.Forms.Button()
        Me.grpSummaries.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(500, 31)
        Me.lblData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(48, 20)
        Me.lblData.TabIndex = 1
        Me.lblData.Text = "Data:"
        '
        'lblMinTemp
        '
        Me.lblMinTemp.AutoSize = True
        Me.lblMinTemp.Location = New System.Drawing.Point(500, 355)
        Me.lblMinTemp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinTemp.Name = "lblMinTemp"
        Me.lblMinTemp.Size = New System.Drawing.Size(82, 20)
        Me.lblMinTemp.TabIndex = 11
        Me.lblMinTemp.Text = "Min Temp:"
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(500, 289)
        Me.lblRain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(46, 20)
        Me.lblRain.TabIndex = 9
        Me.lblRain.Text = "Rain:"
        '
        'lblDataByYear
        '
        Me.lblDataByYear.AutoSize = True
        Me.lblDataByYear.Location = New System.Drawing.Point(500, 95)
        Me.lblDataByYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataByYear.Name = "lblDataByYear"
        Me.lblDataByYear.Size = New System.Drawing.Size(108, 20)
        Me.lblDataByYear.TabIndex = 3
        Me.lblDataByYear.Text = "Data By Year:"
        '
        'lblDataByYearMonth
        '
        Me.lblDataByYearMonth.AutoSize = True
        Me.lblDataByYearMonth.Location = New System.Drawing.Point(495, 162)
        Me.lblDataByYearMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataByYearMonth.Name = "lblDataByYearMonth"
        Me.lblDataByYearMonth.Size = New System.Drawing.Size(188, 20)
        Me.lblDataByYearMonth.TabIndex = 5
        Me.lblDataByYearMonth.Text = "Data By Year and Month:"
        '
        'lblCropData
        '
        Me.lblCropData.AutoSize = True
        Me.lblCropData.Location = New System.Drawing.Point(500, 226)
        Me.lblCropData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCropData.Name = "lblCropData"
        Me.lblCropData.Size = New System.Drawing.Size(86, 20)
        Me.lblCropData.TabIndex = 7
        Me.lblCropData.Text = "Crop Data:"
        '
        'lblMaxTemp
        '
        Me.lblMaxTemp.AutoSize = True
        Me.lblMaxTemp.Location = New System.Drawing.Point(500, 420)
        Me.lblMaxTemp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxTemp.Name = "lblMaxTemp"
        Me.lblMaxTemp.Size = New System.Drawing.Size(86, 20)
        Me.lblMaxTemp.TabIndex = 13
        Me.lblMaxTemp.Text = "Max Temp:"
        '
        'grpSummaries
        '
        Me.grpSummaries.Controls.Add(Me.ucrChkMonthlyTemp)
        Me.grpSummaries.Controls.Add(Me.ucrChkSeasonStartProp)
        Me.grpSummaries.Controls.Add(Me.ucrChkExtremes)
        Me.grpSummaries.Controls.Add(Me.ucrChkCropSuccessProp)
        Me.grpSummaries.Controls.Add(Me.ucrChkAnnualTemp)
        Me.grpSummaries.Controls.Add(Me.ucrChkAnnualRainfall)
        Me.grpSummaries.Location = New System.Drawing.Point(8, 342)
        Me.grpSummaries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpSummaries.Size = New System.Drawing.Size(470, 171)
        Me.grpSummaries.TabIndex = 19
        Me.grpSummaries.TabStop = False
        Me.grpSummaries.Text = "Summaries"
        '
        'ucrChkMonthlyTemp
        '
        Me.ucrChkMonthlyTemp.AutoSize = True
        Me.ucrChkMonthlyTemp.Checked = False
        Me.ucrChkMonthlyTemp.Location = New System.Drawing.Point(8, 120)
        Me.ucrChkMonthlyTemp.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkMonthlyTemp.Name = "ucrChkMonthlyTemp"
        Me.ucrChkMonthlyTemp.Size = New System.Drawing.Size(220, 52)
        Me.ucrChkMonthlyTemp.TabIndex = 2
        '
        'ucrChkSeasonStartProp
        '
        Me.ucrChkSeasonStartProp.AutoSize = True
        Me.ucrChkSeasonStartProp.Checked = False
        Me.ucrChkSeasonStartProp.Location = New System.Drawing.Point(231, 71)
        Me.ucrChkSeasonStartProp.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkSeasonStartProp.Name = "ucrChkSeasonStartProp"
        Me.ucrChkSeasonStartProp.Size = New System.Drawing.Size(226, 52)
        Me.ucrChkSeasonStartProp.TabIndex = 4
        '
        'ucrChkExtremes
        '
        Me.ucrChkExtremes.AutoSize = True
        Me.ucrChkExtremes.Checked = False
        Me.ucrChkExtremes.Location = New System.Drawing.Point(231, 120)
        Me.ucrChkExtremes.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkExtremes.Name = "ucrChkExtremes"
        Me.ucrChkExtremes.Size = New System.Drawing.Size(220, 52)
        Me.ucrChkExtremes.TabIndex = 5
        '
        'ucrChkCropSuccessProp
        '
        Me.ucrChkCropSuccessProp.AutoSize = True
        Me.ucrChkCropSuccessProp.Checked = False
        Me.ucrChkCropSuccessProp.Location = New System.Drawing.Point(231, 28)
        Me.ucrChkCropSuccessProp.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkCropSuccessProp.Name = "ucrChkCropSuccessProp"
        Me.ucrChkCropSuccessProp.Size = New System.Drawing.Size(230, 52)
        Me.ucrChkCropSuccessProp.TabIndex = 3
        '
        'ucrChkAnnualTemp
        '
        Me.ucrChkAnnualTemp.AutoSize = True
        Me.ucrChkAnnualTemp.Checked = False
        Me.ucrChkAnnualTemp.Location = New System.Drawing.Point(8, 71)
        Me.ucrChkAnnualTemp.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkAnnualTemp.Name = "ucrChkAnnualTemp"
        Me.ucrChkAnnualTemp.Size = New System.Drawing.Size(224, 52)
        Me.ucrChkAnnualTemp.TabIndex = 1
        '
        'ucrChkAnnualRainfall
        '
        Me.ucrChkAnnualRainfall.AutoSize = True
        Me.ucrChkAnnualRainfall.Checked = False
        Me.ucrChkAnnualRainfall.Location = New System.Drawing.Point(8, 28)
        Me.ucrChkAnnualRainfall.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkAnnualRainfall.Name = "ucrChkAnnualRainfall"
        Me.ucrChkAnnualRainfall.Size = New System.Drawing.Size(224, 52)
        Me.ucrChkAnnualRainfall.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(120, 720)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 25
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(507, 480)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(47, 20)
        Me.lblYear.TabIndex = 15
        Me.lblYear.Text = "Year:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(506, 538)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(58, 20)
        Me.lblMonth.TabIndex = 17
        Me.lblMonth.Text = "Month:"
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.AutoSize = True
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(500, 565)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 18
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(501, 505)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 16
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrChkIncludeSummaryData
        '
        Me.ucrChkIncludeSummaryData.AutoSize = True
        Me.ucrChkIncludeSummaryData.Checked = False
        Me.ucrChkIncludeSummaryData.Location = New System.Drawing.Point(8, 526)
        Me.ucrChkIncludeSummaryData.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkIncludeSummaryData.Name = "ucrChkIncludeSummaryData"
        Me.ucrChkIncludeSummaryData.Size = New System.Drawing.Size(332, 48)
        Me.ucrChkIncludeSummaryData.TabIndex = 20
        '
        'ucrReceiverDataYear
        '
        Me.ucrReceiverDataYear.AutoSize = True
        Me.ucrReceiverDataYear.frmParent = Me
        Me.ucrReceiverDataYear.Location = New System.Drawing.Point(496, 122)
        Me.ucrReceiverDataYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataYear.Name = "ucrReceiverDataYear"
        Me.ucrReceiverDataYear.Selector = Nothing
        Me.ucrReceiverDataYear.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverDataYear.strNcFilePath = ""
        Me.ucrReceiverDataYear.TabIndex = 4
        Me.ucrReceiverDataYear.ucrSelector = Nothing
        '
        'ucrReceiverDataYearMonth
        '
        Me.ucrReceiverDataYearMonth.AutoSize = True
        Me.ucrReceiverDataYearMonth.frmParent = Me
        Me.ucrReceiverDataYearMonth.Location = New System.Drawing.Point(496, 188)
        Me.ucrReceiverDataYearMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataYearMonth.Name = "ucrReceiverDataYearMonth"
        Me.ucrReceiverDataYearMonth.Selector = Nothing
        Me.ucrReceiverDataYearMonth.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverDataYearMonth.strNcFilePath = ""
        Me.ucrReceiverDataYearMonth.TabIndex = 6
        Me.ucrReceiverDataYearMonth.ucrSelector = Nothing
        '
        'ucrReceiverCropData
        '
        Me.ucrReceiverCropData.AutoSize = True
        Me.ucrReceiverCropData.frmParent = Me
        Me.ucrReceiverCropData.Location = New System.Drawing.Point(496, 251)
        Me.ucrReceiverCropData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCropData.Name = "ucrReceiverCropData"
        Me.ucrReceiverCropData.Selector = Nothing
        Me.ucrReceiverCropData.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverCropData.strNcFilePath = ""
        Me.ucrReceiverCropData.TabIndex = 8
        Me.ucrReceiverCropData.ucrSelector = Nothing
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.AutoSize = True
        Me.ucrReceiverRain.frmParent = Me
        Me.ucrReceiverRain.Location = New System.Drawing.Point(496, 315)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverRain.strNcFilePath = ""
        Me.ucrReceiverRain.TabIndex = 10
        Me.ucrReceiverRain.ucrSelector = Nothing
        '
        'ucrReceiverMinTemp
        '
        Me.ucrReceiverMinTemp.AutoSize = True
        Me.ucrReceiverMinTemp.frmParent = Me
        Me.ucrReceiverMinTemp.Location = New System.Drawing.Point(496, 382)
        Me.ucrReceiverMinTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinTemp.Name = "ucrReceiverMinTemp"
        Me.ucrReceiverMinTemp.Selector = Nothing
        Me.ucrReceiverMinTemp.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverMinTemp.strNcFilePath = ""
        Me.ucrReceiverMinTemp.TabIndex = 12
        Me.ucrReceiverMinTemp.ucrSelector = Nothing
        '
        'ucrReceiverMaxTemp
        '
        Me.ucrReceiverMaxTemp.AutoSize = True
        Me.ucrReceiverMaxTemp.frmParent = Me
        Me.ucrReceiverMaxTemp.Location = New System.Drawing.Point(496, 448)
        Me.ucrReceiverMaxTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxTemp.Name = "ucrReceiverMaxTemp"
        Me.ucrReceiverMaxTemp.Selector = Nothing
        Me.ucrReceiverMaxTemp.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverMaxTemp.strNcFilePath = ""
        Me.ucrReceiverMaxTemp.TabIndex = 14
        Me.ucrReceiverMaxTemp.ucrSelector = Nothing
        '
        'ucrReceiverData
        '
        Me.ucrReceiverData.AutoSize = True
        Me.ucrReceiverData.frmParent = Me
        Me.ucrReceiverData.Location = New System.Drawing.Point(496, 57)
        Me.ucrReceiverData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverData.Name = "ucrReceiverData"
        Me.ucrReceiverData.Selector = Nothing
        Me.ucrReceiverData.Size = New System.Drawing.Size(180, 31)
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
        Me.ucrSelectorExportDefinitions.Location = New System.Drawing.Point(8, 29)
        Me.ucrSelectorExportDefinitions.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorExportDefinitions.Name = "ucrSelectorExportDefinitions"
        Me.ucrSelectorExportDefinitions.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelectorExportDefinitions.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(8, 722)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(615, 92)
        Me.ucrBase.TabIndex = 24
        '
        'ucrInputStationID
        '
        Me.ucrInputStationID.AddQuotesIfUnrecognised = True
        Me.ucrInputStationID.AutoSize = True
        Me.ucrInputStationID.IsMultiline = False
        Me.ucrInputStationID.IsReadOnly = False
        Me.ucrInputStationID.Location = New System.Drawing.Point(502, 623)
        Me.ucrInputStationID.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputStationID.Name = "ucrInputStationID"
        Me.ucrInputStationID.Size = New System.Drawing.Size(177, 32)
        Me.ucrInputStationID.TabIndex = 26
        '
        'ucrInputCountry
        '
        Me.ucrInputCountry.AddQuotesIfUnrecognised = True
        Me.ucrInputCountry.AutoSize = True
        Me.ucrInputCountry.IsMultiline = False
        Me.ucrInputCountry.IsReadOnly = False
        Me.ucrInputCountry.Location = New System.Drawing.Point(502, 678)
        Me.ucrInputCountry.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputCountry.Name = "ucrInputCountry"
        Me.ucrInputCountry.Size = New System.Drawing.Size(177, 32)
        Me.ucrInputCountry.TabIndex = 27
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(506, 655)
        Me.lblCountry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(68, 20)
        Me.lblCountry.TabIndex = 28
        Me.lblCountry.Text = "Country:"
        '
        'lblStationID
        '
        Me.lblStationID.AutoSize = True
        Me.lblStationID.Location = New System.Drawing.Point(502, 598)
        Me.lblStationID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStationID.Name = "lblStationID"
        Me.lblStationID.Size = New System.Drawing.Size(85, 20)
        Me.lblStationID.TabIndex = 29
        Me.lblStationID.Text = "Station ID:"
        '
        'cmdDefine
        '
        Me.cmdDefine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDefine.Location = New System.Drawing.Point(256, 576)
        Me.cmdDefine.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDefine.Name = "cmdDefine"
        Me.cmdDefine.Size = New System.Drawing.Size(171, 38)
        Me.cmdDefine.TabIndex = 30
        Me.cmdDefine.Tag = "Options"
        Me.cmdDefine.Text = "Define"
        Me.cmdDefine.UseVisualStyleBackColor = True
        '
        'dlgExportClimaticDefinitions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(682, 811)
        Me.Controls.Add(Me.cmdDefine)
        Me.Controls.Add(Me.lblStationID)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.ucrInputCountry)
        Me.Controls.Add(Me.ucrInputStationID)
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
        Me.Controls.Add(Me.ucrReceiverDataYear)
        Me.Controls.Add(Me.ucrReceiverDataYearMonth)
        Me.Controls.Add(Me.ucrReceiverCropData)
        Me.Controls.Add(Me.ucrReceiverRain)
        Me.Controls.Add(Me.ucrReceiverMinTemp)
        Me.Controls.Add(Me.ucrReceiverMaxTemp)
        Me.Controls.Add(Me.ucrReceiverData)
        Me.Controls.Add(Me.ucrSelectorExportDefinitions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorExportDefinitions As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverData As ucrReceiverSingle
    Friend WithEvents ucrChkIncludeSummaryData As ucrCheck
    Friend WithEvents grpSummaries As GroupBox
    Friend WithEvents ucrChkMonthlyTemp As ucrCheck
    Friend WithEvents ucrChkSeasonStartProp As ucrCheck
    Friend WithEvents ucrChkExtremes As ucrCheck
    Friend WithEvents ucrChkCropSuccessProp As ucrCheck
    Friend WithEvents ucrChkAnnualTemp As ucrCheck
    Friend WithEvents ucrChkAnnualRainfall As ucrCheck
    Friend WithEvents lblMaxTemp As Label
    Friend WithEvents lblCropData As Label
    Friend WithEvents lblDataByYearMonth As Label
    Friend WithEvents lblDataByYear As Label
    Friend WithEvents lblRain As Label
    Friend WithEvents lblMinTemp As Label
    Friend WithEvents lblData As Label
    Friend WithEvents ucrReceiverDataYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDataYearMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverCropData As ucrReceiverSingle
    Friend WithEvents ucrReceiverRain As ucrReceiverSingle
    Friend WithEvents ucrReceiverMinTemp As ucrReceiverSingle
    Friend WithEvents ucrReceiverMaxTemp As ucrReceiverSingle
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblStationID As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents ucrInputCountry As ucrInputTextBox
    Friend WithEvents ucrInputStationID As ucrInputTextBox
    Friend WithEvents cmdDefine As Button
End Class
