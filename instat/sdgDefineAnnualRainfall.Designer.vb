<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgDefineAnnualRainfall
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
        Me.lblSeasonPlantingDay = New System.Windows.Forms.Label()
        Me.tbSummaries = New System.Windows.Forms.TabControl()
        Me.tbAnnualRainfall = New System.Windows.Forms.TabPage()
        Me.lblExtremRain = New System.Windows.Forms.Label()
        Me.ucrReceiverExtremRian = New instat.ucrReceiverSingle()
        Me.lblStartRainStatus = New System.Windows.Forms.Label()
        Me.ucrReceiverStartRainStatus = New instat.ucrReceiverSingle()
        Me.lblEndRainStatus = New System.Windows.Forms.Label()
        Me.ucrReceiverEndRainStatus = New instat.ucrReceiverSingle()
        Me.lblEndSeasonStatus = New System.Windows.Forms.Label()
        Me.ucrReceiverEndSeasonStatus = New instat.ucrReceiverSingle()
        Me.lblRainyDaysYear = New System.Windows.Forms.Label()
        Me.ucrReceiverRainDaysYear = New instat.ucrReceiverSingle()
        Me.lblNoRainDaysSeason = New System.Windows.Forms.Label()
        Me.lblSeasonalLength = New System.Windows.Forms.Label()
        Me.lblSeasonalRain = New System.Windows.Forms.Label()
        Me.lblAnnualRain = New System.Windows.Forms.Label()
        Me.lblEndSeasonDate = New System.Windows.Forms.Label()
        Me.lblEndSeasonDOY = New System.Windows.Forms.Label()
        Me.lblEndRainDate = New System.Windows.Forms.Label()
        Me.lblEndRainsDOY = New System.Windows.Forms.Label()
        Me.lblStartRainDate = New System.Windows.Forms.Label()
        Me.lblStartRainDOY = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.ucrReceiverStartRainDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStartRainDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverEndSeasonDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverEndSeasonDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverEndRainsDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverEndRainsDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverSeasonalLength = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainDaysSeason = New instat.ucrReceiverSingle()
        Me.ucrReceiverSeasonalRain = New instat.ucrReceiverSingle()
        Me.ucrReceiverAnnualRain = New instat.ucrReceiverSingle()
        Me.ucrSelectorDefineAnnualRain = New instat.ucrSelectorByDataFrame()
        Me.tbCropSuccessProp = New System.Windows.Forms.TabPage()
        Me.lblPropSuccessWithoutStart = New System.Windows.Forms.Label()
        Me.ucrReceiverPropSuccessNoStart = New instat.ucrReceiverSingle()
        Me.lblPlantingLength = New System.Windows.Forms.Label()
        Me.lblPlantingDay = New System.Windows.Forms.Label()
        Me.lblProbSuccess = New System.Windows.Forms.Label()
        Me.lblTotalRain = New System.Windows.Forms.Label()
        Me.lblCropStation = New System.Windows.Forms.Label()
        Me.ucrReceiverPlantingLenghth = New instat.ucrReceiverSingle()
        Me.ucrReceiverPropSuccess = New instat.ucrReceiverSingle()
        Me.ucrReceiverPlantingDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverTotalRain = New instat.ucrReceiverSingle()
        Me.ucrReceiverStationCrop = New instat.ucrReceiverSingle()
        Me.ucrSelectorCropProp = New instat.ucrSelectorByDataFrame()
        Me.tbSeasonStartProb = New System.Windows.Forms.TabPage()
        Me.lblPlantingDayCond = New System.Windows.Forms.Label()
        Me.lblSeasonYear = New System.Windows.Forms.Label()
        Me.lblStationSeasonProb = New System.Windows.Forms.Label()
        Me.ucrReceiverPlantingDayCondition = New instat.ucrReceiverSingle()
        Me.ucrReceiverSeasonPlantingDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverSeasonYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverSeasonStationProb = New instat.ucrReceiverSingle()
        Me.ucrSelectorSeasonStartProp = New instat.ucrSelectorByDataFrame()
        Me.tbAnnualTempSummaries = New System.Windows.Forms.TabPage()
        Me.lblMinMinAnnual = New System.Windows.Forms.Label()
        Me.lblMeanAnnualTemp = New System.Windows.Forms.Label()
        Me.lblMaxMinAnnual = New System.Windows.Forms.Label()
        Me.lblAnnualTempYear = New System.Windows.Forms.Label()
        Me.lblAnnualTempStation = New System.Windows.Forms.Label()
        Me.lblMaxMaxAnnual = New System.Windows.Forms.Label()
        Me.lblMinMaxAnnual = New System.Windows.Forms.Label()
        Me.lblMeanMaxAnnual = New System.Windows.Forms.Label()
        Me.ucrReceiverMinMinAnnual = New instat.ucrReceiverSingle()
        Me.ucrReceiverMaxMaxAnnual = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeanMaxAnnual = New instat.ucrReceiverSingle()
        Me.ucrReceiverMinMaxAnnual = New instat.ucrReceiverSingle()
        Me.ucrReceiverMaxMinAnnual = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeanAnnual = New instat.ucrReceiverSingle()
        Me.ucrReceiverAnnualTempYr = New instat.ucrReceiverSingle()
        Me.ucrReceiverAnnualTempStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorAnnualTemp = New instat.ucrSelectorByDataFrame()
        Me.tbMonthlyTemp = New System.Windows.Forms.TabPage()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblMinMInMonthly = New System.Windows.Forms.Label()
        Me.lblMeanMinMonthly = New System.Windows.Forms.Label()
        Me.lblMaxMinMonthly = New System.Windows.Forms.Label()
        Me.lblYearMonthTemp = New System.Windows.Forms.Label()
        Me.lblStationMonthTemp = New System.Windows.Forms.Label()
        Me.lblMaxMaxMonthly = New System.Windows.Forms.Label()
        Me.lblMinMaxMonthly = New System.Windows.Forms.Label()
        Me.lblMeanMaxMonthly = New System.Windows.Forms.Label()
        Me.ucrReceiverMonthMonthly = New instat.ucrReceiverSingle()
        Me.ucrReceiverMinMinMonthly = New instat.ucrReceiverSingle()
        Me.ucrReceiverMaxMaxMonthly = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeanmaxMonthly = New instat.ucrReceiverSingle()
        Me.ucrReceiverMinMaxMonthly = New instat.ucrReceiverSingle()
        Me.ucrReceiverMaxMinMonthly = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeanminMontly = New instat.ucrReceiverSingle()
        Me.ucrReceiverYearMonthly = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonthlyTemp = New instat.ucrReceiverSingle()
        Me.ucrSelecetorMonthlyTemp = New instat.ucrSelectorByDataFrame()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.lblExtremeMinTemp = New System.Windows.Forms.Label()
        Me.ucrReceiverExtremeMinTemp = New instat.ucrReceiverSingle()
        Me.lblExtremeMaxTemp = New System.Windows.Forms.Label()
        Me.ucrReceiverExtremeMaxTemp = New instat.ucrReceiverSingle()
        Me.lblLongestRainfallSpell = New System.Windows.Forms.Label()
        Me.ucrReceiverLongestRainfallSpell = New instat.ucrReceiverSingle()
        Me.lblLongestMinTempSpell = New System.Windows.Forms.Label()
        Me.ucrReceiverLongestMinTempSpell = New instat.ucrReceiverSingle()
        Me.lblLongestMaxTempSpell = New System.Windows.Forms.Label()
        Me.ucrReceiverLongestMaxTempSpell = New instat.ucrReceiverSingle()
        Me.tbSummaries.SuspendLayout()
        Me.tbAnnualRainfall.SuspendLayout()
        Me.tbCropSuccessProp.SuspendLayout()
        Me.tbSeasonStartProb.SuspendLayout()
        Me.tbAnnualTempSummaries.SuspendLayout()
        Me.tbMonthlyTemp.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSeasonPlantingDay
        '
        Me.lblSeasonPlantingDay.AutoSize = True
        Me.lblSeasonPlantingDay.Location = New System.Drawing.Point(375, 149)
        Me.lblSeasonPlantingDay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeasonPlantingDay.Name = "lblSeasonPlantingDay"
        Me.lblSeasonPlantingDay.Size = New System.Drawing.Size(102, 20)
        Me.lblSeasonPlantingDay.TabIndex = 5
        Me.lblSeasonPlantingDay.Text = "Planting Day:"
        '
        'tbSummaries
        '
        Me.tbSummaries.Controls.Add(Me.tbAnnualRainfall)
        Me.tbSummaries.Controls.Add(Me.tbCropSuccessProp)
        Me.tbSummaries.Controls.Add(Me.tbSeasonStartProb)
        Me.tbSummaries.Controls.Add(Me.tbAnnualTempSummaries)
        Me.tbSummaries.Controls.Add(Me.tbMonthlyTemp)
        Me.tbSummaries.Location = New System.Drawing.Point(18, 22)
        Me.tbSummaries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSummaries.Name = "tbSummaries"
        Me.tbSummaries.SelectedIndex = 0
        Me.tbSummaries.Size = New System.Drawing.Size(784, 778)
        Me.tbSummaries.TabIndex = 34
        '
        'tbAnnualRainfall
        '
        Me.tbAnnualRainfall.Controls.Add(Me.lblLongestMaxTempSpell)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverLongestMaxTempSpell)
        Me.tbAnnualRainfall.Controls.Add(Me.lblLongestMinTempSpell)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverLongestMinTempSpell)
        Me.tbAnnualRainfall.Controls.Add(Me.lblLongestRainfallSpell)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverLongestRainfallSpell)
        Me.tbAnnualRainfall.Controls.Add(Me.lblExtremeMaxTemp)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverExtremeMaxTemp)
        Me.tbAnnualRainfall.Controls.Add(Me.lblExtremeMinTemp)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverExtremeMinTemp)
        Me.tbAnnualRainfall.Controls.Add(Me.lblExtremRain)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverExtremRian)
        Me.tbAnnualRainfall.Controls.Add(Me.lblStartRainStatus)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverStartRainStatus)
        Me.tbAnnualRainfall.Controls.Add(Me.lblEndRainStatus)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverEndRainStatus)
        Me.tbAnnualRainfall.Controls.Add(Me.lblEndSeasonStatus)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverEndSeasonStatus)
        Me.tbAnnualRainfall.Controls.Add(Me.lblRainyDaysYear)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverRainDaysYear)
        Me.tbAnnualRainfall.Controls.Add(Me.lblNoRainDaysSeason)
        Me.tbAnnualRainfall.Controls.Add(Me.lblSeasonalLength)
        Me.tbAnnualRainfall.Controls.Add(Me.lblSeasonalRain)
        Me.tbAnnualRainfall.Controls.Add(Me.lblAnnualRain)
        Me.tbAnnualRainfall.Controls.Add(Me.lblEndSeasonDate)
        Me.tbAnnualRainfall.Controls.Add(Me.lblEndSeasonDOY)
        Me.tbAnnualRainfall.Controls.Add(Me.lblEndRainDate)
        Me.tbAnnualRainfall.Controls.Add(Me.lblEndRainsDOY)
        Me.tbAnnualRainfall.Controls.Add(Me.lblStartRainDate)
        Me.tbAnnualRainfall.Controls.Add(Me.lblStartRainDOY)
        Me.tbAnnualRainfall.Controls.Add(Me.lblYear)
        Me.tbAnnualRainfall.Controls.Add(Me.lblStation)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverStartRainDate)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverStartRainDOY)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverYear)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverStation)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverEndSeasonDate)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverEndSeasonDOY)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverEndRainsDOY)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverEndRainsDate)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverSeasonalLength)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverRainDaysSeason)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverSeasonalRain)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrReceiverAnnualRain)
        Me.tbAnnualRainfall.Controls.Add(Me.ucrSelectorDefineAnnualRain)
        Me.tbAnnualRainfall.Location = New System.Drawing.Point(4, 29)
        Me.tbAnnualRainfall.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbAnnualRainfall.Name = "tbAnnualRainfall"
        Me.tbAnnualRainfall.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbAnnualRainfall.Size = New System.Drawing.Size(776, 745)
        Me.tbAnnualRainfall.TabIndex = 0
        Me.tbAnnualRainfall.Text = "Annual Rainfall"
        Me.tbAnnualRainfall.UseVisualStyleBackColor = True
        '
        'lblExtremRain
        '
        Me.lblExtremRain.AutoSize = True
        Me.lblExtremRain.Location = New System.Drawing.Point(18, 609)
        Me.lblExtremRain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExtremRain.Name = "lblExtremRain"
        Me.lblExtremRain.Size = New System.Drawing.Size(129, 20)
        Me.lblExtremRain.TabIndex = 11
        Me.lblExtremRain.Text = "Extreme Rainfall:"
        '
        'ucrReceiverExtremRian
        '
        Me.ucrReceiverExtremRian.AutoSize = True
        Me.ucrReceiverExtremRian.frmParent = Nothing
        Me.ucrReceiverExtremRian.Location = New System.Drawing.Point(14, 637)
        Me.ucrReceiverExtremRian.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExtremRian.Name = "ucrReceiverExtremRian"
        Me.ucrReceiverExtremRian.Selector = Nothing
        Me.ucrReceiverExtremRian.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverExtremRian.strNcFilePath = ""
        Me.ucrReceiverExtremRian.TabIndex = 12
        Me.ucrReceiverExtremRian.ucrSelector = Nothing
        '
        'lblStartRainStatus
        '
        Me.lblStartRainStatus.AutoSize = True
        Me.lblStartRainStatus.Location = New System.Drawing.Point(280, 502)
        Me.lblStartRainStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartRainStatus.Name = "lblStartRainStatus"
        Me.lblStartRainStatus.Size = New System.Drawing.Size(144, 20)
        Me.lblStartRainStatus.TabIndex = 29
        Me.lblStartRainStatus.Text = "Start Rains Status:"
        '
        'ucrReceiverStartRainStatus
        '
        Me.ucrReceiverStartRainStatus.AutoSize = True
        Me.ucrReceiverStartRainStatus.frmParent = Nothing
        Me.ucrReceiverStartRainStatus.Location = New System.Drawing.Point(280, 528)
        Me.ucrReceiverStartRainStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStartRainStatus.Name = "ucrReceiverStartRainStatus"
        Me.ucrReceiverStartRainStatus.Selector = Nothing
        Me.ucrReceiverStartRainStatus.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverStartRainStatus.strNcFilePath = ""
        Me.ucrReceiverStartRainStatus.TabIndex = 30
        Me.ucrReceiverStartRainStatus.ucrSelector = Nothing
        '
        'lblEndRainStatus
        '
        Me.lblEndRainStatus.AutoSize = True
        Me.lblEndRainStatus.Location = New System.Drawing.Point(280, 565)
        Me.lblEndRainStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndRainStatus.Name = "lblEndRainStatus"
        Me.lblEndRainStatus.Size = New System.Drawing.Size(138, 20)
        Me.lblEndRainStatus.TabIndex = 31
        Me.lblEndRainStatus.Text = "End Rains Status:"
        '
        'ucrReceiverEndRainStatus
        '
        Me.ucrReceiverEndRainStatus.AutoSize = True
        Me.ucrReceiverEndRainStatus.frmParent = Nothing
        Me.ucrReceiverEndRainStatus.Location = New System.Drawing.Point(280, 589)
        Me.ucrReceiverEndRainStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEndRainStatus.Name = "ucrReceiverEndRainStatus"
        Me.ucrReceiverEndRainStatus.Selector = Nothing
        Me.ucrReceiverEndRainStatus.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverEndRainStatus.strNcFilePath = ""
        Me.ucrReceiverEndRainStatus.TabIndex = 32
        Me.ucrReceiverEndRainStatus.ucrSelector = Nothing
        '
        'lblEndSeasonStatus
        '
        Me.lblEndSeasonStatus.AutoSize = True
        Me.lblEndSeasonStatus.Location = New System.Drawing.Point(280, 628)
        Me.lblEndSeasonStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndSeasonStatus.Name = "lblEndSeasonStatus"
        Me.lblEndSeasonStatus.Size = New System.Drawing.Size(152, 20)
        Me.lblEndSeasonStatus.TabIndex = 33
        Me.lblEndSeasonStatus.Text = "End Season Status:"
        '
        'ucrReceiverEndSeasonStatus
        '
        Me.ucrReceiverEndSeasonStatus.AutoSize = True
        Me.ucrReceiverEndSeasonStatus.frmParent = Nothing
        Me.ucrReceiverEndSeasonStatus.Location = New System.Drawing.Point(276, 649)
        Me.ucrReceiverEndSeasonStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEndSeasonStatus.Name = "ucrReceiverEndSeasonStatus"
        Me.ucrReceiverEndSeasonStatus.Selector = Nothing
        Me.ucrReceiverEndSeasonStatus.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverEndSeasonStatus.strNcFilePath = ""
        Me.ucrReceiverEndSeasonStatus.TabIndex = 34
        Me.ucrReceiverEndSeasonStatus.ucrSelector = Nothing
        '
        'lblRainyDaysYear
        '
        Me.lblRainyDaysYear.AutoSize = True
        Me.lblRainyDaysYear.Location = New System.Drawing.Point(280, 132)
        Me.lblRainyDaysYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRainyDaysYear.Name = "lblRainyDaysYear"
        Me.lblRainyDaysYear.Size = New System.Drawing.Size(151, 20)
        Me.lblRainyDaysYear.TabIndex = 17
        Me.lblRainyDaysYear.Text = " Rainy Days in Year:"
        '
        'ucrReceiverRainDaysYear
        '
        Me.ucrReceiverRainDaysYear.AutoSize = True
        Me.ucrReceiverRainDaysYear.frmParent = Nothing
        Me.ucrReceiverRainDaysYear.Location = New System.Drawing.Point(280, 155)
        Me.ucrReceiverRainDaysYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainDaysYear.Name = "ucrReceiverRainDaysYear"
        Me.ucrReceiverRainDaysYear.Selector = Nothing
        Me.ucrReceiverRainDaysYear.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverRainDaysYear.strNcFilePath = ""
        Me.ucrReceiverRainDaysYear.TabIndex = 18
        Me.ucrReceiverRainDaysYear.ucrSelector = Nothing
        '
        'lblNoRainDaysSeason
        '
        Me.lblNoRainDaysSeason.AutoSize = True
        Me.lblNoRainDaysSeason.Location = New System.Drawing.Point(280, 63)
        Me.lblNoRainDaysSeason.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoRainDaysSeason.Name = "lblNoRainDaysSeason"
        Me.lblNoRainDaysSeason.Size = New System.Drawing.Size(172, 20)
        Me.lblNoRainDaysSeason.TabIndex = 15
        Me.lblNoRainDaysSeason.Text = " Rainy Days in Season:"
        '
        'lblSeasonalLength
        '
        Me.lblSeasonalLength.AutoSize = True
        Me.lblSeasonalLength.Location = New System.Drawing.Point(280, 191)
        Me.lblSeasonalLength.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeasonalLength.Name = "lblSeasonalLength"
        Me.lblSeasonalLength.Size = New System.Drawing.Size(134, 20)
        Me.lblSeasonalLength.TabIndex = 19
        Me.lblSeasonalLength.Text = "Seasonal Length:"
        '
        'lblSeasonalRain
        '
        Me.lblSeasonalRain.AutoSize = True
        Me.lblSeasonalRain.Location = New System.Drawing.Point(18, 671)
        Me.lblSeasonalRain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeasonalRain.Name = "lblSeasonalRain"
        Me.lblSeasonalRain.Size = New System.Drawing.Size(117, 20)
        Me.lblSeasonalRain.TabIndex = 13
        Me.lblSeasonalRain.Text = "Seasonal Rain:"
        '
        'lblAnnualRain
        '
        Me.lblAnnualRain.AutoSize = True
        Me.lblAnnualRain.Location = New System.Drawing.Point(20, 548)
        Me.lblAnnualRain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnnualRain.Name = "lblAnnualRain"
        Me.lblAnnualRain.Size = New System.Drawing.Size(100, 20)
        Me.lblAnnualRain.TabIndex = 9
        Me.lblAnnualRain.Text = "Annual Rain:"
        '
        'lblEndSeasonDate
        '
        Me.lblEndSeasonDate.AutoSize = True
        Me.lblEndSeasonDate.Location = New System.Drawing.Point(280, 438)
        Me.lblEndSeasonDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndSeasonDate.Name = "lblEndSeasonDate"
        Me.lblEndSeasonDate.Size = New System.Drawing.Size(146, 20)
        Me.lblEndSeasonDate.TabIndex = 27
        Me.lblEndSeasonDate.Text = "End Season(Date):"
        '
        'lblEndSeasonDOY
        '
        Me.lblEndSeasonDOY.AutoSize = True
        Me.lblEndSeasonDOY.Location = New System.Drawing.Point(280, 385)
        Me.lblEndSeasonDOY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndSeasonDOY.Name = "lblEndSeasonDOY"
        Me.lblEndSeasonDOY.Size = New System.Drawing.Size(146, 20)
        Me.lblEndSeasonDOY.TabIndex = 25
        Me.lblEndSeasonDOY.Text = "End Season(DOY):"
        '
        'lblEndRainDate
        '
        Me.lblEndRainDate.AutoSize = True
        Me.lblEndRainDate.Location = New System.Drawing.Point(280, 318)
        Me.lblEndRainDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndRainDate.Name = "lblEndRainDate"
        Me.lblEndRainDate.Size = New System.Drawing.Size(124, 20)
        Me.lblEndRainDate.TabIndex = 23
        Me.lblEndRainDate.Text = "End Rain(Date):"
        '
        'lblEndRainsDOY
        '
        Me.lblEndRainsDOY.AutoSize = True
        Me.lblEndRainsDOY.Location = New System.Drawing.Point(280, 257)
        Me.lblEndRainsDOY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndRainsDOY.Name = "lblEndRainsDOY"
        Me.lblEndRainsDOY.Size = New System.Drawing.Size(124, 20)
        Me.lblEndRainsDOY.TabIndex = 21
        Me.lblEndRainsDOY.Text = "End Rain(DOY):"
        '
        'lblStartRainDate
        '
        Me.lblStartRainDate.AutoSize = True
        Me.lblStartRainDate.Location = New System.Drawing.Point(16, 486)
        Me.lblStartRainDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartRainDate.Name = "lblStartRainDate"
        Me.lblStartRainDate.Size = New System.Drawing.Size(130, 20)
        Me.lblStartRainDate.TabIndex = 7
        Me.lblStartRainDate.Text = "Start Rain(Date):"
        '
        'lblStartRainDOY
        '
        Me.lblStartRainDOY.AutoSize = True
        Me.lblStartRainDOY.Location = New System.Drawing.Point(18, 422)
        Me.lblStartRainDOY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartRainDOY.Name = "lblStartRainDOY"
        Me.lblStartRainDOY.Size = New System.Drawing.Size(130, 20)
        Me.lblStartRainDOY.TabIndex = 5
        Me.lblStartRainDOY.Text = "Start Rain(DOY):"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(21, 355)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(47, 20)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "Year:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(22, 288)
        Me.lblStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(64, 20)
        Me.lblStation.TabIndex = 1
        Me.lblStation.Text = "Station:"
        '
        'ucrReceiverStartRainDate
        '
        Me.ucrReceiverStartRainDate.AutoSize = True
        Me.ucrReceiverStartRainDate.frmParent = Nothing
        Me.ucrReceiverStartRainDate.Location = New System.Drawing.Point(14, 512)
        Me.ucrReceiverStartRainDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStartRainDate.Name = "ucrReceiverStartRainDate"
        Me.ucrReceiverStartRainDate.Selector = Nothing
        Me.ucrReceiverStartRainDate.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverStartRainDate.strNcFilePath = ""
        Me.ucrReceiverStartRainDate.TabIndex = 8
        Me.ucrReceiverStartRainDate.ucrSelector = Nothing
        '
        'ucrReceiverStartRainDOY
        '
        Me.ucrReceiverStartRainDOY.AutoSize = True
        Me.ucrReceiverStartRainDOY.frmParent = Nothing
        Me.ucrReceiverStartRainDOY.Location = New System.Drawing.Point(14, 449)
        Me.ucrReceiverStartRainDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStartRainDOY.Name = "ucrReceiverStartRainDOY"
        Me.ucrReceiverStartRainDOY.Selector = Nothing
        Me.ucrReceiverStartRainDOY.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverStartRainDOY.strNcFilePath = ""
        Me.ucrReceiverStartRainDOY.TabIndex = 6
        Me.ucrReceiverStartRainDOY.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Nothing
        Me.ucrReceiverYear.Location = New System.Drawing.Point(14, 382)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 4
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Nothing
        Me.ucrReceiverStation.Location = New System.Drawing.Point(16, 314)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverEndSeasonDate
        '
        Me.ucrReceiverEndSeasonDate.AutoSize = True
        Me.ucrReceiverEndSeasonDate.frmParent = Nothing
        Me.ucrReceiverEndSeasonDate.Location = New System.Drawing.Point(280, 465)
        Me.ucrReceiverEndSeasonDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEndSeasonDate.Name = "ucrReceiverEndSeasonDate"
        Me.ucrReceiverEndSeasonDate.Selector = Nothing
        Me.ucrReceiverEndSeasonDate.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverEndSeasonDate.strNcFilePath = ""
        Me.ucrReceiverEndSeasonDate.TabIndex = 28
        Me.ucrReceiverEndSeasonDate.ucrSelector = Nothing
        '
        'ucrReceiverEndSeasonDOY
        '
        Me.ucrReceiverEndSeasonDOY.AutoSize = True
        Me.ucrReceiverEndSeasonDOY.frmParent = Nothing
        Me.ucrReceiverEndSeasonDOY.Location = New System.Drawing.Point(280, 405)
        Me.ucrReceiverEndSeasonDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEndSeasonDOY.Name = "ucrReceiverEndSeasonDOY"
        Me.ucrReceiverEndSeasonDOY.Selector = Nothing
        Me.ucrReceiverEndSeasonDOY.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverEndSeasonDOY.strNcFilePath = ""
        Me.ucrReceiverEndSeasonDOY.TabIndex = 26
        Me.ucrReceiverEndSeasonDOY.ucrSelector = Nothing
        '
        'ucrReceiverEndRainsDOY
        '
        Me.ucrReceiverEndRainsDOY.AutoSize = True
        Me.ucrReceiverEndRainsDOY.frmParent = Nothing
        Me.ucrReceiverEndRainsDOY.Location = New System.Drawing.Point(280, 283)
        Me.ucrReceiverEndRainsDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEndRainsDOY.Name = "ucrReceiverEndRainsDOY"
        Me.ucrReceiverEndRainsDOY.Selector = Nothing
        Me.ucrReceiverEndRainsDOY.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverEndRainsDOY.strNcFilePath = ""
        Me.ucrReceiverEndRainsDOY.TabIndex = 22
        Me.ucrReceiverEndRainsDOY.ucrSelector = Nothing
        '
        'ucrReceiverEndRainsDate
        '
        Me.ucrReceiverEndRainsDate.AutoSize = True
        Me.ucrReceiverEndRainsDate.frmParent = Nothing
        Me.ucrReceiverEndRainsDate.Location = New System.Drawing.Point(280, 346)
        Me.ucrReceiverEndRainsDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEndRainsDate.Name = "ucrReceiverEndRainsDate"
        Me.ucrReceiverEndRainsDate.Selector = Nothing
        Me.ucrReceiverEndRainsDate.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverEndRainsDate.strNcFilePath = ""
        Me.ucrReceiverEndRainsDate.TabIndex = 24
        Me.ucrReceiverEndRainsDate.ucrSelector = Nothing
        '
        'ucrReceiverSeasonalLength
        '
        Me.ucrReceiverSeasonalLength.AutoSize = True
        Me.ucrReceiverSeasonalLength.frmParent = Nothing
        Me.ucrReceiverSeasonalLength.Location = New System.Drawing.Point(280, 218)
        Me.ucrReceiverSeasonalLength.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSeasonalLength.Name = "ucrReceiverSeasonalLength"
        Me.ucrReceiverSeasonalLength.Selector = Nothing
        Me.ucrReceiverSeasonalLength.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverSeasonalLength.strNcFilePath = ""
        Me.ucrReceiverSeasonalLength.TabIndex = 20
        Me.ucrReceiverSeasonalLength.ucrSelector = Nothing
        '
        'ucrReceiverRainDaysSeason
        '
        Me.ucrReceiverRainDaysSeason.AutoSize = True
        Me.ucrReceiverRainDaysSeason.frmParent = Nothing
        Me.ucrReceiverRainDaysSeason.Location = New System.Drawing.Point(280, 89)
        Me.ucrReceiverRainDaysSeason.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainDaysSeason.Name = "ucrReceiverRainDaysSeason"
        Me.ucrReceiverRainDaysSeason.Selector = Nothing
        Me.ucrReceiverRainDaysSeason.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverRainDaysSeason.strNcFilePath = ""
        Me.ucrReceiverRainDaysSeason.TabIndex = 16
        Me.ucrReceiverRainDaysSeason.ucrSelector = Nothing
        '
        'ucrReceiverSeasonalRain
        '
        Me.ucrReceiverSeasonalRain.AutoSize = True
        Me.ucrReceiverSeasonalRain.frmParent = Nothing
        Me.ucrReceiverSeasonalRain.Location = New System.Drawing.Point(14, 695)
        Me.ucrReceiverSeasonalRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSeasonalRain.Name = "ucrReceiverSeasonalRain"
        Me.ucrReceiverSeasonalRain.Selector = Nothing
        Me.ucrReceiverSeasonalRain.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverSeasonalRain.strNcFilePath = ""
        Me.ucrReceiverSeasonalRain.TabIndex = 14
        Me.ucrReceiverSeasonalRain.ucrSelector = Nothing
        '
        'ucrReceiverAnnualRain
        '
        Me.ucrReceiverAnnualRain.AutoSize = True
        Me.ucrReceiverAnnualRain.frmParent = Nothing
        Me.ucrReceiverAnnualRain.Location = New System.Drawing.Point(16, 572)
        Me.ucrReceiverAnnualRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAnnualRain.Name = "ucrReceiverAnnualRain"
        Me.ucrReceiverAnnualRain.Selector = Nothing
        Me.ucrReceiverAnnualRain.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverAnnualRain.strNcFilePath = ""
        Me.ucrReceiverAnnualRain.TabIndex = 10
        Me.ucrReceiverAnnualRain.ucrSelector = Nothing
        '
        'ucrSelectorDefineAnnualRain
        '
        Me.ucrSelectorDefineAnnualRain.AutoSize = True
        Me.ucrSelectorDefineAnnualRain.bDropUnusedFilterLevels = False
        Me.ucrSelectorDefineAnnualRain.bShowHiddenColumns = False
        Me.ucrSelectorDefineAnnualRain.bUseCurrentFilter = True
        Me.ucrSelectorDefineAnnualRain.Location = New System.Drawing.Point(10, 8)
        Me.ucrSelectorDefineAnnualRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDefineAnnualRain.Name = "ucrSelectorDefineAnnualRain"
        Me.ucrSelectorDefineAnnualRain.Size = New System.Drawing.Size(339, 412)
        Me.ucrSelectorDefineAnnualRain.TabIndex = 0
        '
        'tbCropSuccessProp
        '
        Me.tbCropSuccessProp.Controls.Add(Me.lblPropSuccessWithoutStart)
        Me.tbCropSuccessProp.Controls.Add(Me.ucrReceiverPropSuccessNoStart)
        Me.tbCropSuccessProp.Controls.Add(Me.lblPlantingLength)
        Me.tbCropSuccessProp.Controls.Add(Me.lblPlantingDay)
        Me.tbCropSuccessProp.Controls.Add(Me.lblProbSuccess)
        Me.tbCropSuccessProp.Controls.Add(Me.lblTotalRain)
        Me.tbCropSuccessProp.Controls.Add(Me.lblCropStation)
        Me.tbCropSuccessProp.Controls.Add(Me.ucrReceiverPlantingLenghth)
        Me.tbCropSuccessProp.Controls.Add(Me.ucrReceiverPropSuccess)
        Me.tbCropSuccessProp.Controls.Add(Me.ucrReceiverPlantingDay)
        Me.tbCropSuccessProp.Controls.Add(Me.ucrReceiverTotalRain)
        Me.tbCropSuccessProp.Controls.Add(Me.ucrReceiverStationCrop)
        Me.tbCropSuccessProp.Controls.Add(Me.ucrSelectorCropProp)
        Me.tbCropSuccessProp.Location = New System.Drawing.Point(4, 29)
        Me.tbCropSuccessProp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbCropSuccessProp.Name = "tbCropSuccessProp"
        Me.tbCropSuccessProp.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbCropSuccessProp.Size = New System.Drawing.Size(776, 745)
        Me.tbCropSuccessProp.TabIndex = 1
        Me.tbCropSuccessProp.Text = "Crop Success Prop"
        Me.tbCropSuccessProp.UseVisualStyleBackColor = True
        '
        'lblPropSuccessWithoutStart
        '
        Me.lblPropSuccessWithoutStart.AutoSize = True
        Me.lblPropSuccessWithoutStart.Location = New System.Drawing.Point(372, 338)
        Me.lblPropSuccessWithoutStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPropSuccessWithoutStart.Name = "lblPropSuccessWithoutStart"
        Me.lblPropSuccessWithoutStart.Size = New System.Drawing.Size(270, 20)
        Me.lblPropSuccessWithoutStart.TabIndex = 11
        Me.lblPropSuccessWithoutStart.Text = "Proportion of Success (without start):"
        '
        'ucrReceiverPropSuccessNoStart
        '
        Me.ucrReceiverPropSuccessNoStart.AutoSize = True
        Me.ucrReceiverPropSuccessNoStart.frmParent = Nothing
        Me.ucrReceiverPropSuccessNoStart.Location = New System.Drawing.Point(372, 366)
        Me.ucrReceiverPropSuccessNoStart.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPropSuccessNoStart.Name = "ucrReceiverPropSuccessNoStart"
        Me.ucrReceiverPropSuccessNoStart.Selector = Nothing
        Me.ucrReceiverPropSuccessNoStart.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverPropSuccessNoStart.strNcFilePath = ""
        Me.ucrReceiverPropSuccessNoStart.TabIndex = 12
        Me.ucrReceiverPropSuccessNoStart.ucrSelector = Nothing
        '
        'lblPlantingLength
        '
        Me.lblPlantingLength.AutoSize = True
        Me.lblPlantingLength.Location = New System.Drawing.Point(372, 211)
        Me.lblPlantingLength.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantingLength.Name = "lblPlantingLength"
        Me.lblPlantingLength.Size = New System.Drawing.Size(124, 20)
        Me.lblPlantingLength.TabIndex = 7
        Me.lblPlantingLength.Text = "Planting Length:"
        '
        'lblPlantingDay
        '
        Me.lblPlantingDay.AutoSize = True
        Me.lblPlantingDay.Location = New System.Drawing.Point(372, 146)
        Me.lblPlantingDay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantingDay.Name = "lblPlantingDay"
        Me.lblPlantingDay.Size = New System.Drawing.Size(102, 20)
        Me.lblPlantingDay.TabIndex = 5
        Me.lblPlantingDay.Text = "Planting Day:"
        '
        'lblProbSuccess
        '
        Me.lblProbSuccess.AutoSize = True
        Me.lblProbSuccess.Location = New System.Drawing.Point(372, 271)
        Me.lblProbSuccess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProbSuccess.Name = "lblProbSuccess"
        Me.lblProbSuccess.Size = New System.Drawing.Size(247, 20)
        Me.lblProbSuccess.TabIndex = 9
        Me.lblProbSuccess.Text = "Proportion of Success (with start):"
        '
        'lblTotalRain
        '
        Me.lblTotalRain.AutoSize = True
        Me.lblTotalRain.Location = New System.Drawing.Point(372, 83)
        Me.lblTotalRain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalRain.Name = "lblTotalRain"
        Me.lblTotalRain.Size = New System.Drawing.Size(85, 20)
        Me.lblTotalRain.TabIndex = 3
        Me.lblTotalRain.Text = "Total Rain:"
        '
        'lblCropStation
        '
        Me.lblCropStation.AutoSize = True
        Me.lblCropStation.Location = New System.Drawing.Point(372, 17)
        Me.lblCropStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCropStation.Name = "lblCropStation"
        Me.lblCropStation.Size = New System.Drawing.Size(64, 20)
        Me.lblCropStation.TabIndex = 1
        Me.lblCropStation.Text = "Station:"
        '
        'ucrReceiverPlantingLenghth
        '
        Me.ucrReceiverPlantingLenghth.AutoSize = True
        Me.ucrReceiverPlantingLenghth.frmParent = Nothing
        Me.ucrReceiverPlantingLenghth.Location = New System.Drawing.Point(372, 235)
        Me.ucrReceiverPlantingLenghth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPlantingLenghth.Name = "ucrReceiverPlantingLenghth"
        Me.ucrReceiverPlantingLenghth.Selector = Nothing
        Me.ucrReceiverPlantingLenghth.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverPlantingLenghth.strNcFilePath = ""
        Me.ucrReceiverPlantingLenghth.TabIndex = 8
        Me.ucrReceiverPlantingLenghth.ucrSelector = Nothing
        '
        'ucrReceiverPropSuccess
        '
        Me.ucrReceiverPropSuccess.AutoSize = True
        Me.ucrReceiverPropSuccess.frmParent = Nothing
        Me.ucrReceiverPropSuccess.Location = New System.Drawing.Point(372, 298)
        Me.ucrReceiverPropSuccess.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPropSuccess.Name = "ucrReceiverPropSuccess"
        Me.ucrReceiverPropSuccess.Selector = Nothing
        Me.ucrReceiverPropSuccess.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverPropSuccess.strNcFilePath = ""
        Me.ucrReceiverPropSuccess.TabIndex = 10
        Me.ucrReceiverPropSuccess.ucrSelector = Nothing
        '
        'ucrReceiverPlantingDay
        '
        Me.ucrReceiverPlantingDay.AutoSize = True
        Me.ucrReceiverPlantingDay.frmParent = Nothing
        Me.ucrReceiverPlantingDay.Location = New System.Drawing.Point(372, 175)
        Me.ucrReceiverPlantingDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPlantingDay.Name = "ucrReceiverPlantingDay"
        Me.ucrReceiverPlantingDay.Selector = Nothing
        Me.ucrReceiverPlantingDay.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverPlantingDay.strNcFilePath = ""
        Me.ucrReceiverPlantingDay.TabIndex = 6
        Me.ucrReceiverPlantingDay.ucrSelector = Nothing
        '
        'ucrReceiverTotalRain
        '
        Me.ucrReceiverTotalRain.AutoSize = True
        Me.ucrReceiverTotalRain.frmParent = Nothing
        Me.ucrReceiverTotalRain.Location = New System.Drawing.Point(372, 109)
        Me.ucrReceiverTotalRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTotalRain.Name = "ucrReceiverTotalRain"
        Me.ucrReceiverTotalRain.Selector = Nothing
        Me.ucrReceiverTotalRain.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverTotalRain.strNcFilePath = ""
        Me.ucrReceiverTotalRain.TabIndex = 4
        Me.ucrReceiverTotalRain.ucrSelector = Nothing
        '
        'ucrReceiverStationCrop
        '
        Me.ucrReceiverStationCrop.AutoSize = True
        Me.ucrReceiverStationCrop.frmParent = Nothing
        Me.ucrReceiverStationCrop.Location = New System.Drawing.Point(372, 43)
        Me.ucrReceiverStationCrop.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationCrop.Name = "ucrReceiverStationCrop"
        Me.ucrReceiverStationCrop.Selector = Nothing
        Me.ucrReceiverStationCrop.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverStationCrop.strNcFilePath = ""
        Me.ucrReceiverStationCrop.TabIndex = 2
        Me.ucrReceiverStationCrop.ucrSelector = Nothing
        '
        'ucrSelectorCropProp
        '
        Me.ucrSelectorCropProp.AutoSize = True
        Me.ucrSelectorCropProp.bDropUnusedFilterLevels = False
        Me.ucrSelectorCropProp.bShowHiddenColumns = False
        Me.ucrSelectorCropProp.bUseCurrentFilter = True
        Me.ucrSelectorCropProp.Location = New System.Drawing.Point(16, 12)
        Me.ucrSelectorCropProp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCropProp.Name = "ucrSelectorCropProp"
        Me.ucrSelectorCropProp.Size = New System.Drawing.Size(339, 412)
        Me.ucrSelectorCropProp.TabIndex = 0
        '
        'tbSeasonStartProb
        '
        Me.tbSeasonStartProb.Controls.Add(Me.lblPlantingDayCond)
        Me.tbSeasonStartProb.Controls.Add(Me.lblSeasonPlantingDay)
        Me.tbSeasonStartProb.Controls.Add(Me.lblSeasonYear)
        Me.tbSeasonStartProb.Controls.Add(Me.lblStationSeasonProb)
        Me.tbSeasonStartProb.Controls.Add(Me.ucrReceiverPlantingDayCondition)
        Me.tbSeasonStartProb.Controls.Add(Me.ucrReceiverSeasonPlantingDay)
        Me.tbSeasonStartProb.Controls.Add(Me.ucrReceiverSeasonYear)
        Me.tbSeasonStartProb.Controls.Add(Me.ucrReceiverSeasonStationProb)
        Me.tbSeasonStartProb.Controls.Add(Me.ucrSelectorSeasonStartProp)
        Me.tbSeasonStartProb.Location = New System.Drawing.Point(4, 29)
        Me.tbSeasonStartProb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSeasonStartProb.Name = "tbSeasonStartProb"
        Me.tbSeasonStartProb.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSeasonStartProb.Size = New System.Drawing.Size(776, 745)
        Me.tbSeasonStartProb.TabIndex = 2
        Me.tbSeasonStartProb.Text = "Season Start Prob"
        Me.tbSeasonStartProb.UseVisualStyleBackColor = True
        '
        'lblPlantingDayCond
        '
        Me.lblPlantingDayCond.AutoSize = True
        Me.lblPlantingDayCond.Location = New System.Drawing.Point(375, 214)
        Me.lblPlantingDayCond.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantingDayCond.Name = "lblPlantingDayCond"
        Me.lblPlantingDayCond.Size = New System.Drawing.Size(173, 20)
        Me.lblPlantingDayCond.TabIndex = 7
        Me.lblPlantingDayCond.Text = "Planting Day Condition:"
        '
        'lblSeasonYear
        '
        Me.lblSeasonYear.AutoSize = True
        Me.lblSeasonYear.Location = New System.Drawing.Point(375, 86)
        Me.lblSeasonYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeasonYear.Name = "lblSeasonYear"
        Me.lblSeasonYear.Size = New System.Drawing.Size(47, 20)
        Me.lblSeasonYear.TabIndex = 3
        Me.lblSeasonYear.Text = "Year:"
        '
        'lblStationSeasonProb
        '
        Me.lblStationSeasonProb.AutoSize = True
        Me.lblStationSeasonProb.Location = New System.Drawing.Point(375, 20)
        Me.lblStationSeasonProb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStationSeasonProb.Name = "lblStationSeasonProb"
        Me.lblStationSeasonProb.Size = New System.Drawing.Size(64, 20)
        Me.lblStationSeasonProb.TabIndex = 1
        Me.lblStationSeasonProb.Text = "Station:"
        '
        'ucrReceiverPlantingDayCondition
        '
        Me.ucrReceiverPlantingDayCondition.AutoSize = True
        Me.ucrReceiverPlantingDayCondition.frmParent = Nothing
        Me.ucrReceiverPlantingDayCondition.Location = New System.Drawing.Point(375, 238)
        Me.ucrReceiverPlantingDayCondition.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPlantingDayCondition.Name = "ucrReceiverPlantingDayCondition"
        Me.ucrReceiverPlantingDayCondition.Selector = Nothing
        Me.ucrReceiverPlantingDayCondition.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverPlantingDayCondition.strNcFilePath = ""
        Me.ucrReceiverPlantingDayCondition.TabIndex = 8
        Me.ucrReceiverPlantingDayCondition.ucrSelector = Nothing
        '
        'ucrReceiverSeasonPlantingDay
        '
        Me.ucrReceiverSeasonPlantingDay.AutoSize = True
        Me.ucrReceiverSeasonPlantingDay.frmParent = Nothing
        Me.ucrReceiverSeasonPlantingDay.Location = New System.Drawing.Point(375, 178)
        Me.ucrReceiverSeasonPlantingDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSeasonPlantingDay.Name = "ucrReceiverSeasonPlantingDay"
        Me.ucrReceiverSeasonPlantingDay.Selector = Nothing
        Me.ucrReceiverSeasonPlantingDay.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverSeasonPlantingDay.strNcFilePath = ""
        Me.ucrReceiverSeasonPlantingDay.TabIndex = 6
        Me.ucrReceiverSeasonPlantingDay.ucrSelector = Nothing
        '
        'ucrReceiverSeasonYear
        '
        Me.ucrReceiverSeasonYear.AutoSize = True
        Me.ucrReceiverSeasonYear.frmParent = Nothing
        Me.ucrReceiverSeasonYear.Location = New System.Drawing.Point(375, 112)
        Me.ucrReceiverSeasonYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSeasonYear.Name = "ucrReceiverSeasonYear"
        Me.ucrReceiverSeasonYear.Selector = Nothing
        Me.ucrReceiverSeasonYear.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverSeasonYear.strNcFilePath = ""
        Me.ucrReceiverSeasonYear.TabIndex = 4
        Me.ucrReceiverSeasonYear.ucrSelector = Nothing
        '
        'ucrReceiverSeasonStationProb
        '
        Me.ucrReceiverSeasonStationProb.AutoSize = True
        Me.ucrReceiverSeasonStationProb.frmParent = Nothing
        Me.ucrReceiverSeasonStationProb.Location = New System.Drawing.Point(375, 46)
        Me.ucrReceiverSeasonStationProb.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSeasonStationProb.Name = "ucrReceiverSeasonStationProb"
        Me.ucrReceiverSeasonStationProb.Selector = Nothing
        Me.ucrReceiverSeasonStationProb.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverSeasonStationProb.strNcFilePath = ""
        Me.ucrReceiverSeasonStationProb.TabIndex = 2
        Me.ucrReceiverSeasonStationProb.ucrSelector = Nothing
        '
        'ucrSelectorSeasonStartProp
        '
        Me.ucrSelectorSeasonStartProp.AutoSize = True
        Me.ucrSelectorSeasonStartProp.bDropUnusedFilterLevels = False
        Me.ucrSelectorSeasonStartProp.bShowHiddenColumns = False
        Me.ucrSelectorSeasonStartProp.bUseCurrentFilter = True
        Me.ucrSelectorSeasonStartProp.Location = New System.Drawing.Point(20, 15)
        Me.ucrSelectorSeasonStartProp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSeasonStartProp.Name = "ucrSelectorSeasonStartProp"
        Me.ucrSelectorSeasonStartProp.Size = New System.Drawing.Size(339, 412)
        Me.ucrSelectorSeasonStartProp.TabIndex = 0
        '
        'tbAnnualTempSummaries
        '
        Me.tbAnnualTempSummaries.Controls.Add(Me.lblMinMinAnnual)
        Me.tbAnnualTempSummaries.Controls.Add(Me.lblMeanAnnualTemp)
        Me.tbAnnualTempSummaries.Controls.Add(Me.lblMaxMinAnnual)
        Me.tbAnnualTempSummaries.Controls.Add(Me.lblAnnualTempYear)
        Me.tbAnnualTempSummaries.Controls.Add(Me.lblAnnualTempStation)
        Me.tbAnnualTempSummaries.Controls.Add(Me.lblMaxMaxAnnual)
        Me.tbAnnualTempSummaries.Controls.Add(Me.lblMinMaxAnnual)
        Me.tbAnnualTempSummaries.Controls.Add(Me.lblMeanMaxAnnual)
        Me.tbAnnualTempSummaries.Controls.Add(Me.ucrReceiverMinMinAnnual)
        Me.tbAnnualTempSummaries.Controls.Add(Me.ucrReceiverMaxMaxAnnual)
        Me.tbAnnualTempSummaries.Controls.Add(Me.ucrReceiverMeanMaxAnnual)
        Me.tbAnnualTempSummaries.Controls.Add(Me.ucrReceiverMinMaxAnnual)
        Me.tbAnnualTempSummaries.Controls.Add(Me.ucrReceiverMaxMinAnnual)
        Me.tbAnnualTempSummaries.Controls.Add(Me.ucrReceiverMeanAnnual)
        Me.tbAnnualTempSummaries.Controls.Add(Me.ucrReceiverAnnualTempYr)
        Me.tbAnnualTempSummaries.Controls.Add(Me.ucrReceiverAnnualTempStation)
        Me.tbAnnualTempSummaries.Controls.Add(Me.ucrSelectorAnnualTemp)
        Me.tbAnnualTempSummaries.Location = New System.Drawing.Point(4, 29)
        Me.tbAnnualTempSummaries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbAnnualTempSummaries.Name = "tbAnnualTempSummaries"
        Me.tbAnnualTempSummaries.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbAnnualTempSummaries.Size = New System.Drawing.Size(776, 745)
        Me.tbAnnualTempSummaries.TabIndex = 3
        Me.tbAnnualTempSummaries.Text = "Annual Temperature"
        Me.tbAnnualTempSummaries.UseVisualStyleBackColor = True
        '
        'lblMinMinAnnual
        '
        Me.lblMinMinAnnual.AutoSize = True
        Me.lblMinMinAnnual.Location = New System.Drawing.Point(372, 208)
        Me.lblMinMinAnnual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinMinAnnual.Name = "lblMinMinAnnual"
        Me.lblMinMinAnnual.Size = New System.Drawing.Size(145, 20)
        Me.lblMinMinAnnual.TabIndex = 7
        Me.lblMinMinAnnual.Text = "Min Minimum Temp"
        '
        'lblMeanAnnualTemp
        '
        Me.lblMeanAnnualTemp.AutoSize = True
        Me.lblMeanAnnualTemp.Location = New System.Drawing.Point(372, 143)
        Me.lblMeanAnnualTemp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMeanAnnualTemp.Name = "lblMeanAnnualTemp"
        Me.lblMeanAnnualTemp.Size = New System.Drawing.Size(160, 20)
        Me.lblMeanAnnualTemp.TabIndex = 5
        Me.lblMeanAnnualTemp.Text = "Mean Minimum Temp"
        '
        'lblMaxMinAnnual
        '
        Me.lblMaxMinAnnual.AutoSize = True
        Me.lblMaxMinAnnual.Location = New System.Drawing.Point(372, 268)
        Me.lblMaxMinAnnual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxMinAnnual.Name = "lblMaxMinAnnual"
        Me.lblMaxMinAnnual.Size = New System.Drawing.Size(149, 20)
        Me.lblMaxMinAnnual.TabIndex = 9
        Me.lblMaxMinAnnual.Text = "Max Minimum Temp"
        '
        'lblAnnualTempYear
        '
        Me.lblAnnualTempYear.AutoSize = True
        Me.lblAnnualTempYear.Location = New System.Drawing.Point(372, 80)
        Me.lblAnnualTempYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnnualTempYear.Name = "lblAnnualTempYear"
        Me.lblAnnualTempYear.Size = New System.Drawing.Size(47, 20)
        Me.lblAnnualTempYear.TabIndex = 3
        Me.lblAnnualTempYear.Text = "Year:"
        '
        'lblAnnualTempStation
        '
        Me.lblAnnualTempStation.AutoSize = True
        Me.lblAnnualTempStation.Location = New System.Drawing.Point(372, 14)
        Me.lblAnnualTempStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnnualTempStation.Name = "lblAnnualTempStation"
        Me.lblAnnualTempStation.Size = New System.Drawing.Size(64, 20)
        Me.lblAnnualTempStation.TabIndex = 1
        Me.lblAnnualTempStation.Text = "Station:"
        '
        'lblMaxMaxAnnual
        '
        Me.lblMaxMaxAnnual.AutoSize = True
        Me.lblMaxMaxAnnual.Location = New System.Drawing.Point(372, 454)
        Me.lblMaxMaxAnnual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxMaxAnnual.Name = "lblMaxMaxAnnual"
        Me.lblMaxMaxAnnual.Size = New System.Drawing.Size(153, 20)
        Me.lblMaxMaxAnnual.TabIndex = 15
        Me.lblMaxMaxAnnual.Text = "Max Maximum Temp"
        '
        'lblMinMaxAnnual
        '
        Me.lblMinMaxAnnual.AutoSize = True
        Me.lblMinMaxAnnual.Location = New System.Drawing.Point(372, 389)
        Me.lblMinMaxAnnual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinMaxAnnual.Name = "lblMinMaxAnnual"
        Me.lblMinMaxAnnual.Size = New System.Drawing.Size(153, 20)
        Me.lblMinMaxAnnual.TabIndex = 13
        Me.lblMinMaxAnnual.Text = "Min Maximum Temp:"
        '
        'lblMeanMaxAnnual
        '
        Me.lblMeanMaxAnnual.AutoSize = True
        Me.lblMeanMaxAnnual.Location = New System.Drawing.Point(372, 329)
        Me.lblMeanMaxAnnual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMeanMaxAnnual.Name = "lblMeanMaxAnnual"
        Me.lblMeanMaxAnnual.Size = New System.Drawing.Size(164, 20)
        Me.lblMeanMaxAnnual.TabIndex = 11
        Me.lblMeanMaxAnnual.Text = "Mean Maximum Temp"
        '
        'ucrReceiverMinMinAnnual
        '
        Me.ucrReceiverMinMinAnnual.AutoSize = True
        Me.ucrReceiverMinMinAnnual.frmParent = Nothing
        Me.ucrReceiverMinMinAnnual.Location = New System.Drawing.Point(372, 232)
        Me.ucrReceiverMinMinAnnual.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinMinAnnual.Name = "ucrReceiverMinMinAnnual"
        Me.ucrReceiverMinMinAnnual.Selector = Nothing
        Me.ucrReceiverMinMinAnnual.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverMinMinAnnual.strNcFilePath = ""
        Me.ucrReceiverMinMinAnnual.TabIndex = 8
        Me.ucrReceiverMinMinAnnual.ucrSelector = Nothing
        '
        'ucrReceiverMaxMaxAnnual
        '
        Me.ucrReceiverMaxMaxAnnual.AutoSize = True
        Me.ucrReceiverMaxMaxAnnual.frmParent = Nothing
        Me.ucrReceiverMaxMaxAnnual.Location = New System.Drawing.Point(372, 474)
        Me.ucrReceiverMaxMaxAnnual.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxMaxAnnual.Name = "ucrReceiverMaxMaxAnnual"
        Me.ucrReceiverMaxMaxAnnual.Selector = Nothing
        Me.ucrReceiverMaxMaxAnnual.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverMaxMaxAnnual.strNcFilePath = ""
        Me.ucrReceiverMaxMaxAnnual.TabIndex = 16
        Me.ucrReceiverMaxMaxAnnual.ucrSelector = Nothing
        '
        'ucrReceiverMeanMaxAnnual
        '
        Me.ucrReceiverMeanMaxAnnual.AutoSize = True
        Me.ucrReceiverMeanMaxAnnual.frmParent = Nothing
        Me.ucrReceiverMeanMaxAnnual.Location = New System.Drawing.Point(372, 355)
        Me.ucrReceiverMeanMaxAnnual.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanMaxAnnual.Name = "ucrReceiverMeanMaxAnnual"
        Me.ucrReceiverMeanMaxAnnual.Selector = Nothing
        Me.ucrReceiverMeanMaxAnnual.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverMeanMaxAnnual.strNcFilePath = ""
        Me.ucrReceiverMeanMaxAnnual.TabIndex = 12
        Me.ucrReceiverMeanMaxAnnual.ucrSelector = Nothing
        '
        'ucrReceiverMinMaxAnnual
        '
        Me.ucrReceiverMinMaxAnnual.AutoSize = True
        Me.ucrReceiverMinMaxAnnual.frmParent = Nothing
        Me.ucrReceiverMinMaxAnnual.Location = New System.Drawing.Point(372, 417)
        Me.ucrReceiverMinMaxAnnual.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinMaxAnnual.Name = "ucrReceiverMinMaxAnnual"
        Me.ucrReceiverMinMaxAnnual.Selector = Nothing
        Me.ucrReceiverMinMaxAnnual.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverMinMaxAnnual.strNcFilePath = ""
        Me.ucrReceiverMinMaxAnnual.TabIndex = 14
        Me.ucrReceiverMinMaxAnnual.ucrSelector = Nothing
        '
        'ucrReceiverMaxMinAnnual
        '
        Me.ucrReceiverMaxMinAnnual.AutoSize = True
        Me.ucrReceiverMaxMinAnnual.frmParent = Nothing
        Me.ucrReceiverMaxMinAnnual.Location = New System.Drawing.Point(372, 295)
        Me.ucrReceiverMaxMinAnnual.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxMinAnnual.Name = "ucrReceiverMaxMinAnnual"
        Me.ucrReceiverMaxMinAnnual.Selector = Nothing
        Me.ucrReceiverMaxMinAnnual.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverMaxMinAnnual.strNcFilePath = ""
        Me.ucrReceiverMaxMinAnnual.TabIndex = 10
        Me.ucrReceiverMaxMinAnnual.ucrSelector = Nothing
        '
        'ucrReceiverMeanAnnual
        '
        Me.ucrReceiverMeanAnnual.AutoSize = True
        Me.ucrReceiverMeanAnnual.frmParent = Nothing
        Me.ucrReceiverMeanAnnual.Location = New System.Drawing.Point(372, 172)
        Me.ucrReceiverMeanAnnual.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanAnnual.Name = "ucrReceiverMeanAnnual"
        Me.ucrReceiverMeanAnnual.Selector = Nothing
        Me.ucrReceiverMeanAnnual.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverMeanAnnual.strNcFilePath = ""
        Me.ucrReceiverMeanAnnual.TabIndex = 6
        Me.ucrReceiverMeanAnnual.ucrSelector = Nothing
        '
        'ucrReceiverAnnualTempYr
        '
        Me.ucrReceiverAnnualTempYr.AutoSize = True
        Me.ucrReceiverAnnualTempYr.frmParent = Nothing
        Me.ucrReceiverAnnualTempYr.Location = New System.Drawing.Point(372, 106)
        Me.ucrReceiverAnnualTempYr.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAnnualTempYr.Name = "ucrReceiverAnnualTempYr"
        Me.ucrReceiverAnnualTempYr.Selector = Nothing
        Me.ucrReceiverAnnualTempYr.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverAnnualTempYr.strNcFilePath = ""
        Me.ucrReceiverAnnualTempYr.TabIndex = 4
        Me.ucrReceiverAnnualTempYr.ucrSelector = Nothing
        '
        'ucrReceiverAnnualTempStation
        '
        Me.ucrReceiverAnnualTempStation.AutoSize = True
        Me.ucrReceiverAnnualTempStation.frmParent = Nothing
        Me.ucrReceiverAnnualTempStation.Location = New System.Drawing.Point(372, 40)
        Me.ucrReceiverAnnualTempStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAnnualTempStation.Name = "ucrReceiverAnnualTempStation"
        Me.ucrReceiverAnnualTempStation.Selector = Nothing
        Me.ucrReceiverAnnualTempStation.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverAnnualTempStation.strNcFilePath = ""
        Me.ucrReceiverAnnualTempStation.TabIndex = 2
        Me.ucrReceiverAnnualTempStation.ucrSelector = Nothing
        '
        'ucrSelectorAnnualTemp
        '
        Me.ucrSelectorAnnualTemp.AutoSize = True
        Me.ucrSelectorAnnualTemp.bDropUnusedFilterLevels = False
        Me.ucrSelectorAnnualTemp.bShowHiddenColumns = False
        Me.ucrSelectorAnnualTemp.bUseCurrentFilter = True
        Me.ucrSelectorAnnualTemp.Location = New System.Drawing.Point(16, 9)
        Me.ucrSelectorAnnualTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorAnnualTemp.Name = "ucrSelectorAnnualTemp"
        Me.ucrSelectorAnnualTemp.Size = New System.Drawing.Size(339, 412)
        Me.ucrSelectorAnnualTemp.TabIndex = 0
        '
        'tbMonthlyTemp
        '
        Me.tbMonthlyTemp.Controls.Add(Me.lblMonth)
        Me.tbMonthlyTemp.Controls.Add(Me.lblMinMInMonthly)
        Me.tbMonthlyTemp.Controls.Add(Me.lblMeanMinMonthly)
        Me.tbMonthlyTemp.Controls.Add(Me.lblMaxMinMonthly)
        Me.tbMonthlyTemp.Controls.Add(Me.lblYearMonthTemp)
        Me.tbMonthlyTemp.Controls.Add(Me.lblStationMonthTemp)
        Me.tbMonthlyTemp.Controls.Add(Me.lblMaxMaxMonthly)
        Me.tbMonthlyTemp.Controls.Add(Me.lblMinMaxMonthly)
        Me.tbMonthlyTemp.Controls.Add(Me.lblMeanMaxMonthly)
        Me.tbMonthlyTemp.Controls.Add(Me.ucrReceiverMonthMonthly)
        Me.tbMonthlyTemp.Controls.Add(Me.ucrReceiverMinMinMonthly)
        Me.tbMonthlyTemp.Controls.Add(Me.ucrReceiverMaxMaxMonthly)
        Me.tbMonthlyTemp.Controls.Add(Me.ucrReceiverMeanmaxMonthly)
        Me.tbMonthlyTemp.Controls.Add(Me.ucrReceiverMinMaxMonthly)
        Me.tbMonthlyTemp.Controls.Add(Me.ucrReceiverMaxMinMonthly)
        Me.tbMonthlyTemp.Controls.Add(Me.ucrReceiverMeanminMontly)
        Me.tbMonthlyTemp.Controls.Add(Me.ucrReceiverYearMonthly)
        Me.tbMonthlyTemp.Controls.Add(Me.ucrReceiverMonthlyTemp)
        Me.tbMonthlyTemp.Controls.Add(Me.ucrSelecetorMonthlyTemp)
        Me.tbMonthlyTemp.Location = New System.Drawing.Point(4, 29)
        Me.tbMonthlyTemp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbMonthlyTemp.Name = "tbMonthlyTemp"
        Me.tbMonthlyTemp.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbMonthlyTemp.Size = New System.Drawing.Size(776, 745)
        Me.tbMonthlyTemp.TabIndex = 4
        Me.tbMonthlyTemp.Text = "Monthly Temperature"
        Me.tbMonthlyTemp.UseVisualStyleBackColor = True
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(370, 146)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(58, 20)
        Me.lblMonth.TabIndex = 5
        Me.lblMonth.Text = "Month:"
        '
        'lblMinMInMonthly
        '
        Me.lblMinMInMonthly.AutoSize = True
        Me.lblMinMInMonthly.Location = New System.Drawing.Point(370, 278)
        Me.lblMinMInMonthly.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinMInMonthly.Name = "lblMinMInMonthly"
        Me.lblMinMInMonthly.Size = New System.Drawing.Size(145, 20)
        Me.lblMinMInMonthly.TabIndex = 9
        Me.lblMinMInMonthly.Text = "Min Minimum Temp"
        '
        'lblMeanMinMonthly
        '
        Me.lblMeanMinMonthly.AutoSize = True
        Me.lblMeanMinMonthly.Location = New System.Drawing.Point(370, 214)
        Me.lblMeanMinMonthly.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMeanMinMonthly.Name = "lblMeanMinMonthly"
        Me.lblMeanMinMonthly.Size = New System.Drawing.Size(160, 20)
        Me.lblMeanMinMonthly.TabIndex = 7
        Me.lblMeanMinMonthly.Text = "Mean Minimum Temp"
        '
        'lblMaxMinMonthly
        '
        Me.lblMaxMinMonthly.AutoSize = True
        Me.lblMaxMinMonthly.Location = New System.Drawing.Point(370, 338)
        Me.lblMaxMinMonthly.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxMinMonthly.Name = "lblMaxMinMonthly"
        Me.lblMaxMinMonthly.Size = New System.Drawing.Size(149, 20)
        Me.lblMaxMinMonthly.TabIndex = 11
        Me.lblMaxMinMonthly.Text = "Max Minimum Temp"
        '
        'lblYearMonthTemp
        '
        Me.lblYearMonthTemp.AutoSize = True
        Me.lblYearMonthTemp.Location = New System.Drawing.Point(370, 83)
        Me.lblYearMonthTemp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYearMonthTemp.Name = "lblYearMonthTemp"
        Me.lblYearMonthTemp.Size = New System.Drawing.Size(47, 20)
        Me.lblYearMonthTemp.TabIndex = 3
        Me.lblYearMonthTemp.Text = "Year:"
        '
        'lblStationMonthTemp
        '
        Me.lblStationMonthTemp.AutoSize = True
        Me.lblStationMonthTemp.Location = New System.Drawing.Point(370, 23)
        Me.lblStationMonthTemp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStationMonthTemp.Name = "lblStationMonthTemp"
        Me.lblStationMonthTemp.Size = New System.Drawing.Size(64, 20)
        Me.lblStationMonthTemp.TabIndex = 1
        Me.lblStationMonthTemp.Text = "Station:"
        '
        'lblMaxMaxMonthly
        '
        Me.lblMaxMaxMonthly.AutoSize = True
        Me.lblMaxMaxMonthly.Location = New System.Drawing.Point(370, 525)
        Me.lblMaxMaxMonthly.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxMaxMonthly.Name = "lblMaxMaxMonthly"
        Me.lblMaxMaxMonthly.Size = New System.Drawing.Size(153, 20)
        Me.lblMaxMaxMonthly.TabIndex = 17
        Me.lblMaxMaxMonthly.Text = "Max Maximum Temp"
        '
        'lblMinMaxMonthly
        '
        Me.lblMinMaxMonthly.AutoSize = True
        Me.lblMinMaxMonthly.Location = New System.Drawing.Point(370, 460)
        Me.lblMinMaxMonthly.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinMaxMonthly.Name = "lblMinMaxMonthly"
        Me.lblMinMaxMonthly.Size = New System.Drawing.Size(153, 20)
        Me.lblMinMaxMonthly.TabIndex = 15
        Me.lblMinMaxMonthly.Text = "Min Maximum Temp:"
        '
        'lblMeanMaxMonthly
        '
        Me.lblMeanMaxMonthly.AutoSize = True
        Me.lblMeanMaxMonthly.Location = New System.Drawing.Point(370, 400)
        Me.lblMeanMaxMonthly.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMeanMaxMonthly.Name = "lblMeanMaxMonthly"
        Me.lblMeanMaxMonthly.Size = New System.Drawing.Size(164, 20)
        Me.lblMeanMaxMonthly.TabIndex = 13
        Me.lblMeanMaxMonthly.Text = "Mean Maximum Temp"
        '
        'ucrReceiverMonthMonthly
        '
        Me.ucrReceiverMonthMonthly.AutoSize = True
        Me.ucrReceiverMonthMonthly.frmParent = Nothing
        Me.ucrReceiverMonthMonthly.Location = New System.Drawing.Point(370, 172)
        Me.ucrReceiverMonthMonthly.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonthMonthly.Name = "ucrReceiverMonthMonthly"
        Me.ucrReceiverMonthMonthly.Selector = Nothing
        Me.ucrReceiverMonthMonthly.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverMonthMonthly.strNcFilePath = ""
        Me.ucrReceiverMonthMonthly.TabIndex = 6
        Me.ucrReceiverMonthMonthly.ucrSelector = Nothing
        '
        'ucrReceiverMinMinMonthly
        '
        Me.ucrReceiverMinMinMonthly.AutoSize = True
        Me.ucrReceiverMinMinMonthly.frmParent = Nothing
        Me.ucrReceiverMinMinMonthly.Location = New System.Drawing.Point(370, 303)
        Me.ucrReceiverMinMinMonthly.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinMinMonthly.Name = "ucrReceiverMinMinMonthly"
        Me.ucrReceiverMinMinMonthly.Selector = Nothing
        Me.ucrReceiverMinMinMonthly.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverMinMinMonthly.strNcFilePath = ""
        Me.ucrReceiverMinMinMonthly.TabIndex = 10
        Me.ucrReceiverMinMinMonthly.ucrSelector = Nothing
        '
        'ucrReceiverMaxMaxMonthly
        '
        Me.ucrReceiverMaxMaxMonthly.AutoSize = True
        Me.ucrReceiverMaxMaxMonthly.frmParent = Nothing
        Me.ucrReceiverMaxMaxMonthly.Location = New System.Drawing.Point(370, 545)
        Me.ucrReceiverMaxMaxMonthly.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxMaxMonthly.Name = "ucrReceiverMaxMaxMonthly"
        Me.ucrReceiverMaxMaxMonthly.Selector = Nothing
        Me.ucrReceiverMaxMaxMonthly.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverMaxMaxMonthly.strNcFilePath = ""
        Me.ucrReceiverMaxMaxMonthly.TabIndex = 18
        Me.ucrReceiverMaxMaxMonthly.ucrSelector = Nothing
        '
        'ucrReceiverMeanmaxMonthly
        '
        Me.ucrReceiverMeanmaxMonthly.AutoSize = True
        Me.ucrReceiverMeanmaxMonthly.frmParent = Nothing
        Me.ucrReceiverMeanmaxMonthly.Location = New System.Drawing.Point(370, 426)
        Me.ucrReceiverMeanmaxMonthly.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanmaxMonthly.Name = "ucrReceiverMeanmaxMonthly"
        Me.ucrReceiverMeanmaxMonthly.Selector = Nothing
        Me.ucrReceiverMeanmaxMonthly.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverMeanmaxMonthly.strNcFilePath = ""
        Me.ucrReceiverMeanmaxMonthly.TabIndex = 14
        Me.ucrReceiverMeanmaxMonthly.ucrSelector = Nothing
        '
        'ucrReceiverMinMaxMonthly
        '
        Me.ucrReceiverMinMaxMonthly.AutoSize = True
        Me.ucrReceiverMinMaxMonthly.frmParent = Nothing
        Me.ucrReceiverMinMaxMonthly.Location = New System.Drawing.Point(370, 488)
        Me.ucrReceiverMinMaxMonthly.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinMaxMonthly.Name = "ucrReceiverMinMaxMonthly"
        Me.ucrReceiverMinMaxMonthly.Selector = Nothing
        Me.ucrReceiverMinMaxMonthly.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverMinMaxMonthly.strNcFilePath = ""
        Me.ucrReceiverMinMaxMonthly.TabIndex = 16
        Me.ucrReceiverMinMaxMonthly.ucrSelector = Nothing
        '
        'ucrReceiverMaxMinMonthly
        '
        Me.ucrReceiverMaxMinMonthly.AutoSize = True
        Me.ucrReceiverMaxMinMonthly.frmParent = Nothing
        Me.ucrReceiverMaxMinMonthly.Location = New System.Drawing.Point(370, 366)
        Me.ucrReceiverMaxMinMonthly.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxMinMonthly.Name = "ucrReceiverMaxMinMonthly"
        Me.ucrReceiverMaxMinMonthly.Selector = Nothing
        Me.ucrReceiverMaxMinMonthly.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverMaxMinMonthly.strNcFilePath = ""
        Me.ucrReceiverMaxMinMonthly.TabIndex = 12
        Me.ucrReceiverMaxMinMonthly.ucrSelector = Nothing
        '
        'ucrReceiverMeanminMontly
        '
        Me.ucrReceiverMeanminMontly.AutoSize = True
        Me.ucrReceiverMeanminMontly.frmParent = Nothing
        Me.ucrReceiverMeanminMontly.Location = New System.Drawing.Point(370, 243)
        Me.ucrReceiverMeanminMontly.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanminMontly.Name = "ucrReceiverMeanminMontly"
        Me.ucrReceiverMeanminMontly.Selector = Nothing
        Me.ucrReceiverMeanminMontly.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverMeanminMontly.strNcFilePath = ""
        Me.ucrReceiverMeanminMontly.TabIndex = 8
        Me.ucrReceiverMeanminMontly.ucrSelector = Nothing
        '
        'ucrReceiverYearMonthly
        '
        Me.ucrReceiverYearMonthly.AutoSize = True
        Me.ucrReceiverYearMonthly.frmParent = Nothing
        Me.ucrReceiverYearMonthly.Location = New System.Drawing.Point(370, 109)
        Me.ucrReceiverYearMonthly.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYearMonthly.Name = "ucrReceiverYearMonthly"
        Me.ucrReceiverYearMonthly.Selector = Nothing
        Me.ucrReceiverYearMonthly.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverYearMonthly.strNcFilePath = ""
        Me.ucrReceiverYearMonthly.TabIndex = 4
        Me.ucrReceiverYearMonthly.ucrSelector = Nothing
        '
        'ucrReceiverMonthlyTemp
        '
        Me.ucrReceiverMonthlyTemp.AutoSize = True
        Me.ucrReceiverMonthlyTemp.frmParent = Nothing
        Me.ucrReceiverMonthlyTemp.Location = New System.Drawing.Point(370, 49)
        Me.ucrReceiverMonthlyTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonthlyTemp.Name = "ucrReceiverMonthlyTemp"
        Me.ucrReceiverMonthlyTemp.Selector = Nothing
        Me.ucrReceiverMonthlyTemp.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverMonthlyTemp.strNcFilePath = ""
        Me.ucrReceiverMonthlyTemp.TabIndex = 2
        Me.ucrReceiverMonthlyTemp.ucrSelector = Nothing
        '
        'ucrSelecetorMonthlyTemp
        '
        Me.ucrSelecetorMonthlyTemp.AutoSize = True
        Me.ucrSelecetorMonthlyTemp.bDropUnusedFilterLevels = False
        Me.ucrSelecetorMonthlyTemp.bShowHiddenColumns = False
        Me.ucrSelecetorMonthlyTemp.bUseCurrentFilter = True
        Me.ucrSelecetorMonthlyTemp.Location = New System.Drawing.Point(15, 18)
        Me.ucrSelecetorMonthlyTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelecetorMonthlyTemp.Name = "ucrSelecetorMonthlyTemp"
        Me.ucrSelecetorMonthlyTemp.Size = New System.Drawing.Size(339, 412)
        Me.ucrSelecetorMonthlyTemp.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(236, 811)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(336, 46)
        Me.ucrBase.TabIndex = 35
        '
        'lblExtremeMinTemp
        '
        Me.lblExtremeMinTemp.AutoSize = True
        Me.lblExtremeMinTemp.Location = New System.Drawing.Point(503, 63)
        Me.lblExtremeMinTemp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExtremeMinTemp.Name = "lblExtremeMinTemp"
        Me.lblExtremeMinTemp.Size = New System.Drawing.Size(234, 20)
        Me.lblExtremeMinTemp.TabIndex = 35
        Me.lblExtremeMinTemp.Text = "Extreme Minimum Temperature:"
        '
        'ucrReceiverExtremeMinTemp
        '
        Me.ucrReceiverExtremeMinTemp.AutoSize = True
        Me.ucrReceiverExtremeMinTemp.frmParent = Me
        Me.ucrReceiverExtremeMinTemp.Location = New System.Drawing.Point(503, 89)
        Me.ucrReceiverExtremeMinTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExtremeMinTemp.Name = "ucrReceiverExtremeMinTemp"
        Me.ucrReceiverExtremeMinTemp.Selector = Nothing
        Me.ucrReceiverExtremeMinTemp.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverExtremeMinTemp.strNcFilePath = ""
        Me.ucrReceiverExtremeMinTemp.TabIndex = 36
        Me.ucrReceiverExtremeMinTemp.ucrSelector = Nothing
        '
        'lblExtremeMaxTemp
        '
        Me.lblExtremeMaxTemp.AutoSize = True
        Me.lblExtremeMaxTemp.Location = New System.Drawing.Point(503, 128)
        Me.lblExtremeMaxTemp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExtremeMaxTemp.Name = "lblExtremeMaxTemp"
        Me.lblExtremeMaxTemp.Size = New System.Drawing.Size(238, 20)
        Me.lblExtremeMaxTemp.TabIndex = 37
        Me.lblExtremeMaxTemp.Text = "Extreme Maximum Temperature:"
        '
        'ucrReceiverExtremeMaxTemp
        '
        Me.ucrReceiverExtremeMaxTemp.AutoSize = True
        Me.ucrReceiverExtremeMaxTemp.frmParent = Me
        Me.ucrReceiverExtremeMaxTemp.Location = New System.Drawing.Point(503, 154)
        Me.ucrReceiverExtremeMaxTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExtremeMaxTemp.Name = "ucrReceiverExtremeMaxTemp"
        Me.ucrReceiverExtremeMaxTemp.Selector = Nothing
        Me.ucrReceiverExtremeMaxTemp.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverExtremeMaxTemp.strNcFilePath = ""
        Me.ucrReceiverExtremeMaxTemp.TabIndex = 38
        Me.ucrReceiverExtremeMaxTemp.ucrSelector = Nothing
        '
        'lblLongestRainfallSpell
        '
        Me.lblLongestRainfallSpell.AutoSize = True
        Me.lblLongestRainfallSpell.Location = New System.Drawing.Point(503, 192)
        Me.lblLongestRainfallSpell.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLongestRainfallSpell.Name = "lblLongestRainfallSpell"
        Me.lblLongestRainfallSpell.Size = New System.Drawing.Size(167, 20)
        Me.lblLongestRainfallSpell.TabIndex = 39
        Me.lblLongestRainfallSpell.Text = "Longest Rainfall Spell:"
        '
        'ucrReceiverLongestRainfallSpell
        '
        Me.ucrReceiverLongestRainfallSpell.AutoSize = True
        Me.ucrReceiverLongestRainfallSpell.frmParent = Me
        Me.ucrReceiverLongestRainfallSpell.Location = New System.Drawing.Point(503, 218)
        Me.ucrReceiverLongestRainfallSpell.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongestRainfallSpell.Name = "ucrReceiverLongestRainfallSpell"
        Me.ucrReceiverLongestRainfallSpell.Selector = Nothing
        Me.ucrReceiverLongestRainfallSpell.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverLongestRainfallSpell.strNcFilePath = ""
        Me.ucrReceiverLongestRainfallSpell.TabIndex = 40
        Me.ucrReceiverLongestRainfallSpell.ucrSelector = Nothing
        '
        'lblLongestMinTempSpell
        '
        Me.lblLongestMinTempSpell.AutoSize = True
        Me.lblLongestMinTempSpell.Location = New System.Drawing.Point(503, 257)
        Me.lblLongestMinTempSpell.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLongestMinTempSpell.Name = "lblLongestMinTempSpell"
        Me.lblLongestMinTempSpell.Size = New System.Drawing.Size(272, 20)
        Me.lblLongestMinTempSpell.TabIndex = 41
        Me.lblLongestMinTempSpell.Text = "Longest Minimum Temperature Spell:"
        '
        'ucrReceiverLongestMinTempSpell
        '
        Me.ucrReceiverLongestMinTempSpell.AutoSize = True
        Me.ucrReceiverLongestMinTempSpell.frmParent = Me
        Me.ucrReceiverLongestMinTempSpell.Location = New System.Drawing.Point(503, 283)
        Me.ucrReceiverLongestMinTempSpell.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongestMinTempSpell.Name = "ucrReceiverLongestMinTempSpell"
        Me.ucrReceiverLongestMinTempSpell.Selector = Nothing
        Me.ucrReceiverLongestMinTempSpell.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverLongestMinTempSpell.strNcFilePath = ""
        Me.ucrReceiverLongestMinTempSpell.TabIndex = 42
        Me.ucrReceiverLongestMinTempSpell.ucrSelector = Nothing
        '
        'lblLongestMaxTempSpell
        '
        Me.lblLongestMaxTempSpell.AutoSize = True
        Me.lblLongestMaxTempSpell.Location = New System.Drawing.Point(503, 320)
        Me.lblLongestMaxTempSpell.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLongestMaxTempSpell.Name = "lblLongestMaxTempSpell"
        Me.lblLongestMaxTempSpell.Size = New System.Drawing.Size(276, 20)
        Me.lblLongestMaxTempSpell.TabIndex = 43
        Me.lblLongestMaxTempSpell.Text = "Longest Maximum Temperature Spell:"
        '
        'ucrReceiverLongestMaxTempSpell
        '
        Me.ucrReceiverLongestMaxTempSpell.AutoSize = True
        Me.ucrReceiverLongestMaxTempSpell.frmParent = Me
        Me.ucrReceiverLongestMaxTempSpell.Location = New System.Drawing.Point(503, 346)
        Me.ucrReceiverLongestMaxTempSpell.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongestMaxTempSpell.Name = "ucrReceiverLongestMaxTempSpell"
        Me.ucrReceiverLongestMaxTempSpell.Selector = Nothing
        Me.ucrReceiverLongestMaxTempSpell.Size = New System.Drawing.Size(180, 38)
        Me.ucrReceiverLongestMaxTempSpell.strNcFilePath = ""
        Me.ucrReceiverLongestMaxTempSpell.TabIndex = 44
        Me.ucrReceiverLongestMaxTempSpell.ucrSelector = Nothing
        '
        'sdgDefineAnnualRainfall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(820, 865)
        Me.Controls.Add(Me.tbSummaries)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDefineAnnualRainfall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define Elements"
        Me.tbSummaries.ResumeLayout(False)
        Me.tbAnnualRainfall.ResumeLayout(False)
        Me.tbAnnualRainfall.PerformLayout()
        Me.tbCropSuccessProp.ResumeLayout(False)
        Me.tbCropSuccessProp.PerformLayout()
        Me.tbSeasonStartProb.ResumeLayout(False)
        Me.tbSeasonStartProb.PerformLayout()
        Me.tbAnnualTempSummaries.ResumeLayout(False)
        Me.tbAnnualTempSummaries.PerformLayout()
        Me.tbMonthlyTemp.ResumeLayout(False)
        Me.tbMonthlyTemp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiverMaxMinMonthly As ucrReceiverSingle
    Friend WithEvents ucrReceiverYearMonthly As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonthlyTemp As ucrReceiverSingle
    Friend WithEvents ucrSelecetorMonthlyTemp As ucrSelectorByDataFrame
    Friend WithEvents lblSeasonPlantingDay As Label
    Friend WithEvents ucrSelectorSeasonStartProp As ucrSelectorByDataFrame
    Friend WithEvents tbSummaries As TabControl
    Friend WithEvents tbAnnualRainfall As TabPage
    Friend WithEvents lblStartRainStatus As Label
    Friend WithEvents ucrReceiverStartRainStatus As ucrReceiverSingle
    Friend WithEvents lblEndRainStatus As Label
    Friend WithEvents ucrReceiverEndRainStatus As ucrReceiverSingle
    Friend WithEvents lblEndSeasonStatus As Label
    Friend WithEvents ucrReceiverEndSeasonStatus As ucrReceiverSingle
    Friend WithEvents lblRainyDaysYear As Label
    Friend WithEvents ucrReceiverRainDaysYear As ucrReceiverSingle
    Friend WithEvents lblNoRainDaysSeason As Label
    Friend WithEvents lblSeasonalLength As Label
    Friend WithEvents lblSeasonalRain As Label
    Friend WithEvents lblAnnualRain As Label
    Friend WithEvents lblEndSeasonDate As Label
    Friend WithEvents lblEndSeasonDOY As Label
    Friend WithEvents lblEndRainDate As Label
    Friend WithEvents lblEndRainsDOY As Label
    Friend WithEvents lblStartRainDate As Label
    Friend WithEvents lblStartRainDOY As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStartRainDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverStartRainDOY As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverEndSeasonDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverEndSeasonDOY As ucrReceiverSingle
    Friend WithEvents ucrReceiverEndRainsDOY As ucrReceiverSingle
    Friend WithEvents ucrReceiverEndRainsDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverSeasonalLength As ucrReceiverSingle
    Friend WithEvents ucrReceiverRainDaysSeason As ucrReceiverSingle
    Friend WithEvents ucrReceiverSeasonalRain As ucrReceiverSingle
    Friend WithEvents ucrReceiverAnnualRain As ucrReceiverSingle
    Friend WithEvents ucrSelectorDefineAnnualRain As ucrSelectorByDataFrame
    Friend WithEvents tbCropSuccessProp As TabPage
    Friend WithEvents lblPlantingLength As Label
    Friend WithEvents lblPlantingDay As Label
    Friend WithEvents lblProbSuccess As Label
    Friend WithEvents lblTotalRain As Label
    Friend WithEvents lblCropStation As Label
    Friend WithEvents ucrReceiverPlantingLenghth As ucrReceiverSingle
    Friend WithEvents ucrReceiverPropSuccess As ucrReceiverSingle
    Friend WithEvents ucrReceiverPlantingDay As ucrReceiverSingle
    Friend WithEvents ucrReceiverTotalRain As ucrReceiverSingle
    Friend WithEvents ucrReceiverStationCrop As ucrReceiverSingle
    Friend WithEvents ucrSelectorCropProp As ucrSelectorByDataFrame
    Friend WithEvents tbSeasonStartProb As TabPage
    Friend WithEvents lblPlantingDayCond As Label
    Friend WithEvents lblSeasonYear As Label
    Friend WithEvents lblStationSeasonProb As Label
    Friend WithEvents ucrReceiverPlantingDayCondition As ucrReceiverSingle
    Friend WithEvents ucrReceiverSeasonPlantingDay As ucrReceiverSingle
    Friend WithEvents ucrReceiverSeasonYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverSeasonStationProb As ucrReceiverSingle
    Friend WithEvents tbAnnualTempSummaries As TabPage
    Friend WithEvents lblMinMinAnnual As Label
    Friend WithEvents lblMeanAnnualTemp As Label
    Friend WithEvents lblMaxMinAnnual As Label
    Friend WithEvents lblAnnualTempYear As Label
    Friend WithEvents lblAnnualTempStation As Label
    Friend WithEvents lblMaxMaxAnnual As Label
    Friend WithEvents lblMinMaxAnnual As Label
    Friend WithEvents lblMeanMaxAnnual As Label
    Friend WithEvents ucrReceiverMinMinAnnual As ucrReceiverSingle
    Friend WithEvents ucrReceiverMaxMaxAnnual As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanMaxAnnual As ucrReceiverSingle
    Friend WithEvents ucrReceiverMinMaxAnnual As ucrReceiverSingle
    Friend WithEvents ucrReceiverMaxMinAnnual As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanAnnual As ucrReceiverSingle
    Friend WithEvents ucrReceiverAnnualTempYr As ucrReceiverSingle
    Friend WithEvents ucrReceiverAnnualTempStation As ucrReceiverSingle
    Friend WithEvents ucrSelectorAnnualTemp As ucrSelectorByDataFrame
    Friend WithEvents tbMonthlyTemp As TabPage
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblMinMInMonthly As Label
    Friend WithEvents lblMeanMinMonthly As Label
    Friend WithEvents lblMaxMinMonthly As Label
    Friend WithEvents lblYearMonthTemp As Label
    Friend WithEvents lblStationMonthTemp As Label
    Friend WithEvents lblMaxMaxMonthly As Label
    Friend WithEvents lblMinMaxMonthly As Label
    Friend WithEvents lblMeanMaxMonthly As Label
    Friend WithEvents ucrReceiverMonthMonthly As ucrReceiverSingle
    Friend WithEvents ucrReceiverMinMinMonthly As ucrReceiverSingle
    Friend WithEvents ucrReceiverMaxMaxMonthly As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanmaxMonthly As ucrReceiverSingle
    Friend WithEvents ucrReceiverMinMaxMonthly As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanminMontly As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents lblPropSuccessWithoutStart As Label
    Friend WithEvents ucrReceiverPropSuccessNoStart As ucrReceiverSingle
    Friend WithEvents lblExtremRain As Label
    Friend WithEvents ucrReceiverExtremRian As ucrReceiverSingle
    Friend WithEvents lblLongestMaxTempSpell As Label
    Friend WithEvents ucrReceiverLongestMaxTempSpell As ucrReceiverSingle
    Friend WithEvents lblLongestMinTempSpell As Label
    Friend WithEvents ucrReceiverLongestMinTempSpell As ucrReceiverSingle
    Friend WithEvents lblLongestRainfallSpell As Label
    Friend WithEvents ucrReceiverLongestRainfallSpell As ucrReceiverSingle
    Friend WithEvents lblExtremeMaxTemp As Label
    Friend WithEvents ucrReceiverExtremeMaxTemp As ucrReceiverSingle
    Friend WithEvents lblExtremeMinTemp As Label
    Friend WithEvents ucrReceiverExtremeMinTemp As ucrReceiverSingle
End Class
