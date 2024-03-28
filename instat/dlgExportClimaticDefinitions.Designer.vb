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
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
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
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.grpSummaries.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(333, 20)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(33, 13)
        Me.lblData.TabIndex = 1
        Me.lblData.Text = "Data:"
        '
        'lblMinTemp
        '
        Me.lblMinTemp.AutoSize = True
        Me.lblMinTemp.Location = New System.Drawing.Point(333, 231)
        Me.lblMinTemp.Name = "lblMinTemp"
        Me.lblMinTemp.Size = New System.Drawing.Size(57, 13)
        Me.lblMinTemp.TabIndex = 11
        Me.lblMinTemp.Text = "Min Temp:"
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(333, 188)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(32, 13)
        Me.lblRain.TabIndex = 9
        Me.lblRain.Text = "Rain:"
        '
        'lblDataByYear
        '
        Me.lblDataByYear.AutoSize = True
        Me.lblDataByYear.Location = New System.Drawing.Point(333, 62)
        Me.lblDataByYear.Name = "lblDataByYear"
        Me.lblDataByYear.Size = New System.Drawing.Size(73, 13)
        Me.lblDataByYear.TabIndex = 3
        Me.lblDataByYear.Text = "Data By Year:"
        '
        'lblDataByYearMonth
        '
        Me.lblDataByYearMonth.AutoSize = True
        Me.lblDataByYearMonth.Location = New System.Drawing.Point(330, 105)
        Me.lblDataByYearMonth.Name = "lblDataByYearMonth"
        Me.lblDataByYearMonth.Size = New System.Drawing.Size(127, 13)
        Me.lblDataByYearMonth.TabIndex = 5
        Me.lblDataByYearMonth.Text = "Data By Year and Month:"
        '
        'lblCropData
        '
        Me.lblCropData.AutoSize = True
        Me.lblCropData.Location = New System.Drawing.Point(333, 147)
        Me.lblCropData.Name = "lblCropData"
        Me.lblCropData.Size = New System.Drawing.Size(58, 13)
        Me.lblCropData.TabIndex = 7
        Me.lblCropData.Text = "Crop Data:"
        '
        'lblMaxTemp
        '
        Me.lblMaxTemp.AutoSize = True
        Me.lblMaxTemp.Location = New System.Drawing.Point(333, 273)
        Me.lblMaxTemp.Name = "lblMaxTemp"
        Me.lblMaxTemp.Size = New System.Drawing.Size(60, 13)
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
        Me.grpSummaries.Location = New System.Drawing.Point(5, 222)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Size = New System.Drawing.Size(313, 111)
        Me.grpSummaries.TabIndex = 19
        Me.grpSummaries.TabStop = False
        Me.grpSummaries.Text = "Summaries"
        '
        'ucrChkMonthlyTemp
        '
        Me.ucrChkMonthlyTemp.AutoSize = True
        Me.ucrChkMonthlyTemp.Checked = False
        Me.ucrChkMonthlyTemp.Location = New System.Drawing.Point(5, 78)
        Me.ucrChkMonthlyTemp.Name = "ucrChkMonthlyTemp"
        Me.ucrChkMonthlyTemp.Size = New System.Drawing.Size(147, 23)
        Me.ucrChkMonthlyTemp.TabIndex = 2
        '
        'ucrChkSeasonStartProp
        '
        Me.ucrChkSeasonStartProp.AutoSize = True
        Me.ucrChkSeasonStartProp.Checked = False
        Me.ucrChkSeasonStartProp.Location = New System.Drawing.Point(154, 46)
        Me.ucrChkSeasonStartProp.Name = "ucrChkSeasonStartProp"
        Me.ucrChkSeasonStartProp.Size = New System.Drawing.Size(151, 23)
        Me.ucrChkSeasonStartProp.TabIndex = 4
        '
        'ucrChkExtremes
        '
        Me.ucrChkExtremes.AutoSize = True
        Me.ucrChkExtremes.Checked = False
        Me.ucrChkExtremes.Location = New System.Drawing.Point(154, 78)
        Me.ucrChkExtremes.Name = "ucrChkExtremes"
        Me.ucrChkExtremes.Size = New System.Drawing.Size(147, 23)
        Me.ucrChkExtremes.TabIndex = 5
        '
        'ucrChkCropSuccessProp
        '
        Me.ucrChkCropSuccessProp.AutoSize = True
        Me.ucrChkCropSuccessProp.Checked = False
        Me.ucrChkCropSuccessProp.Location = New System.Drawing.Point(154, 18)
        Me.ucrChkCropSuccessProp.Name = "ucrChkCropSuccessProp"
        Me.ucrChkCropSuccessProp.Size = New System.Drawing.Size(153, 23)
        Me.ucrChkCropSuccessProp.TabIndex = 3
        '
        'ucrChkAnnualTemp
        '
        Me.ucrChkAnnualTemp.AutoSize = True
        Me.ucrChkAnnualTemp.Checked = False
        Me.ucrChkAnnualTemp.Location = New System.Drawing.Point(5, 46)
        Me.ucrChkAnnualTemp.Name = "ucrChkAnnualTemp"
        Me.ucrChkAnnualTemp.Size = New System.Drawing.Size(149, 23)
        Me.ucrChkAnnualTemp.TabIndex = 1
        '
        'ucrChkAnnualRainfall
        '
        Me.ucrChkAnnualRainfall.AutoSize = True
        Me.ucrChkAnnualRainfall.Checked = False
        Me.ucrChkAnnualRainfall.Location = New System.Drawing.Point(5, 18)
        Me.ucrChkAnnualRainfall.Name = "ucrChkAnnualRainfall"
        Me.ucrChkAnnualRainfall.Size = New System.Drawing.Size(149, 23)
        Me.ucrChkAnnualRainfall.TabIndex = 0
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrowse.Location = New System.Drawing.Point(293, 401)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(80, 31)
        Me.cmdBrowse.TabIndex = 23
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExport.Location = New System.Drawing.Point(5, 405)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(59, 13)
        Me.lblExport.TabIndex = 21
        Me.lblExport.Text = "Export File:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(80, 468)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 25
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.AutoSize = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        Me.ucrInputExportFile.Location = New System.Drawing.Point(109, 402)
        Me.ucrInputExportFile.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        Me.ucrInputExportFile.Size = New System.Drawing.Size(182, 29)
        Me.ucrInputExportFile.TabIndex = 22
        '
        'ucrChkIncludeSummaryData
        '
        Me.ucrChkIncludeSummaryData.AutoSize = True
        Me.ucrChkIncludeSummaryData.Checked = False
        Me.ucrChkIncludeSummaryData.Location = New System.Drawing.Point(5, 368)
        Me.ucrChkIncludeSummaryData.Name = "ucrChkIncludeSummaryData"
        Me.ucrChkIncludeSummaryData.Size = New System.Drawing.Size(221, 31)
        Me.ucrChkIncludeSummaryData.TabIndex = 20
        '
        'ucrReceiverDataYear
        '
        Me.ucrReceiverDataYear.AutoSize = True
        Me.ucrReceiverDataYear.frmParent = Me
        Me.ucrReceiverDataYear.Location = New System.Drawing.Point(331, 79)
        Me.ucrReceiverDataYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataYear.Name = "ucrReceiverDataYear"
        Me.ucrReceiverDataYear.Selector = Nothing
        Me.ucrReceiverDataYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDataYear.strNcFilePath = ""
        Me.ucrReceiverDataYear.TabIndex = 4
        Me.ucrReceiverDataYear.ucrSelector = Nothing
        '
        'ucrReceiverDataYearMonth
        '
        Me.ucrReceiverDataYearMonth.AutoSize = True
        Me.ucrReceiverDataYearMonth.frmParent = Me
        Me.ucrReceiverDataYearMonth.Location = New System.Drawing.Point(331, 122)
        Me.ucrReceiverDataYearMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataYearMonth.Name = "ucrReceiverDataYearMonth"
        Me.ucrReceiverDataYearMonth.Selector = Nothing
        Me.ucrReceiverDataYearMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDataYearMonth.strNcFilePath = ""
        Me.ucrReceiverDataYearMonth.TabIndex = 6
        Me.ucrReceiverDataYearMonth.ucrSelector = Nothing
        '
        'ucrReceiverCropData
        '
        Me.ucrReceiverCropData.AutoSize = True
        Me.ucrReceiverCropData.frmParent = Me
        Me.ucrReceiverCropData.Location = New System.Drawing.Point(331, 163)
        Me.ucrReceiverCropData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCropData.Name = "ucrReceiverCropData"
        Me.ucrReceiverCropData.Selector = Nothing
        Me.ucrReceiverCropData.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCropData.strNcFilePath = ""
        Me.ucrReceiverCropData.TabIndex = 8
        Me.ucrReceiverCropData.ucrSelector = Nothing
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.AutoSize = True
        Me.ucrReceiverRain.frmParent = Me
        Me.ucrReceiverRain.Location = New System.Drawing.Point(331, 205)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRain.strNcFilePath = ""
        Me.ucrReceiverRain.TabIndex = 10
        Me.ucrReceiverRain.ucrSelector = Nothing
        '
        'ucrReceiverMinTemp
        '
        Me.ucrReceiverMinTemp.AutoSize = True
        Me.ucrReceiverMinTemp.frmParent = Me
        Me.ucrReceiverMinTemp.Location = New System.Drawing.Point(331, 248)
        Me.ucrReceiverMinTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinTemp.Name = "ucrReceiverMinTemp"
        Me.ucrReceiverMinTemp.Selector = Nothing
        Me.ucrReceiverMinTemp.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMinTemp.strNcFilePath = ""
        Me.ucrReceiverMinTemp.TabIndex = 12
        Me.ucrReceiverMinTemp.ucrSelector = Nothing
        '
        'ucrReceiverMaxTemp
        '
        Me.ucrReceiverMaxTemp.AutoSize = True
        Me.ucrReceiverMaxTemp.frmParent = Me
        Me.ucrReceiverMaxTemp.Location = New System.Drawing.Point(331, 291)
        Me.ucrReceiverMaxTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxTemp.Name = "ucrReceiverMaxTemp"
        Me.ucrReceiverMaxTemp.Selector = Nothing
        Me.ucrReceiverMaxTemp.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMaxTemp.strNcFilePath = ""
        Me.ucrReceiverMaxTemp.TabIndex = 14
        Me.ucrReceiverMaxTemp.ucrSelector = Nothing
        '
        'ucrReceiverData
        '
        Me.ucrReceiverData.AutoSize = True
        Me.ucrReceiverData.frmParent = Me
        Me.ucrReceiverData.Location = New System.Drawing.Point(331, 37)
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
        Me.ucrSelectorExportDefinitions.Location = New System.Drawing.Point(5, 19)
        Me.ucrSelectorExportDefinitions.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorExportDefinitions.Name = "ucrSelectorExportDefinitions"
        Me.ucrSelectorExportDefinitions.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorExportDefinitions.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(5, 438)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 60)
        Me.ucrBase.TabIndex = 24
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(334, 328)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 16
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.AutoSize = True
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(333, 367)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 18
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(338, 312)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 15
        Me.lblYear.Text = "Year:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(337, 350)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 17
        Me.lblMonth.Text = "Month:"
        '
        'dlgExportClimaticDefinitions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(455, 499)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblExport)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.ucrInputExportFile)
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
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents ucrInputExportFile As ucrInputTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblExport As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
End Class
