<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DlgDefineClimaticData
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
        Me.grpClimaticType = New System.Windows.Forms.GroupBox()
        Me.panClimateType = New System.Windows.Forms.Panel()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverRain = New instat.ucrReceiverSingle()
        Me.ucrReceiverMaxTemp = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.ucrReceiverSunshine = New instat.ucrReceiverSingle()
        Me.ucrReceiverRadiation = New instat.ucrReceiverSingle()
        Me.ucrReceiverCloudCover = New instat.ucrReceiverSingle()
        Me.lblCloudCover = New System.Windows.Forms.Label()
        Me.lblRadiation = New System.Windows.Forms.Label()
        Me.lblWindDirection = New System.Windows.Forms.Label()
        Me.lblSunshine = New System.Windows.Forms.Label()
        Me.lblWindSpeed = New System.Windows.Forms.Label()
        Me.ucrReceiverMinTemp = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.lblMinTemp = New System.Windows.Forms.Label()
        Me.lblMaxTemp = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ucrSelectorDefineClimaticData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpClimaticType.SuspendLayout()
        Me.panClimateType.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpClimaticType
        '
        Me.grpClimaticType.Controls.Add(Me.panClimateType)
        Me.grpClimaticType.Location = New System.Drawing.Point(237, 9)
        Me.grpClimaticType.Name = "grpClimaticType"
        Me.grpClimaticType.Size = New System.Drawing.Size(187, 306)
        Me.grpClimaticType.TabIndex = 39
        Me.grpClimaticType.TabStop = False
        Me.grpClimaticType.Text = "Climatic Type"
        '
        'panClimateType
        '
        Me.panClimateType.AutoScroll = True
        Me.panClimateType.Controls.Add(Me.ucrReceiverDay)
        Me.panClimateType.Controls.Add(Me.lblDay)
        Me.panClimateType.Controls.Add(Me.ucrReceiverMonth)
        Me.panClimateType.Controls.Add(Me.lblMonth)
        Me.panClimateType.Controls.Add(Me.ucrReceiverYear)
        Me.panClimateType.Controls.Add(Me.lblYear)
        Me.panClimateType.Controls.Add(Me.ucrReceiverStation)
        Me.panClimateType.Controls.Add(Me.lblStation)
        Me.panClimateType.Controls.Add(Me.ucrReceiverDate)
        Me.panClimateType.Controls.Add(Me.ucrReceiverRain)
        Me.panClimateType.Controls.Add(Me.ucrReceiverMaxTemp)
        Me.panClimateType.Controls.Add(Me.ucrReceiverWindDirection)
        Me.panClimateType.Controls.Add(Me.ucrReceiverSunshine)
        Me.panClimateType.Controls.Add(Me.ucrReceiverRadiation)
        Me.panClimateType.Controls.Add(Me.ucrReceiverCloudCover)
        Me.panClimateType.Controls.Add(Me.lblCloudCover)
        Me.panClimateType.Controls.Add(Me.lblRadiation)
        Me.panClimateType.Controls.Add(Me.lblWindDirection)
        Me.panClimateType.Controls.Add(Me.lblSunshine)
        Me.panClimateType.Controls.Add(Me.lblWindSpeed)
        Me.panClimateType.Controls.Add(Me.ucrReceiverMinTemp)
        Me.panClimateType.Controls.Add(Me.ucrReceiverWindSpeed)
        Me.panClimateType.Controls.Add(Me.lblRain)
        Me.panClimateType.Controls.Add(Me.lblMinTemp)
        Me.panClimateType.Controls.Add(Me.lblMaxTemp)
        Me.panClimateType.Controls.Add(Me.lblDate)
        Me.panClimateType.Location = New System.Drawing.Point(8, 13)
        Me.panClimateType.Name = "panClimateType"
        Me.panClimateType.Size = New System.Drawing.Size(172, 272)
        Me.panClimateType.TabIndex = 39
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.Location = New System.Drawing.Point(14, 543)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDay.TabIndex = 58
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(14, 525)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(29, 13)
        Me.lblDay.TabIndex = 57
        Me.lblDay.Text = "Day:"
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(14, 500)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.TabIndex = 56
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(14, 482)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 55
        Me.lblMonth.Text = "Month:"
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.Location = New System.Drawing.Point(14, 457)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.TabIndex = 54
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(14, 439)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 53
        Me.lblYear.Text = "Year:"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.Location = New System.Drawing.Point(14, 70)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.TabIndex = 52
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(14, 52)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 51
        Me.lblStation.Text = "Station:"
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.Location = New System.Drawing.Point(14, 27)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.TabIndex = 50
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.Location = New System.Drawing.Point(14, 113)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRain.TabIndex = 50
        '
        'ucrReceiverMaxTemp
        '
        Me.ucrReceiverMaxTemp.Location = New System.Drawing.Point(14, 199)
        Me.ucrReceiverMaxTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxTemp.Name = "ucrReceiverMaxTemp"
        Me.ucrReceiverMaxTemp.Selector = Nothing
        Me.ucrReceiverMaxTemp.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMaxTemp.TabIndex = 49
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(14, 285)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection.TabIndex = 48
        '
        'ucrReceiverSunshine
        '
        Me.ucrReceiverSunshine.Location = New System.Drawing.Point(14, 328)
        Me.ucrReceiverSunshine.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSunshine.Name = "ucrReceiverSunshine"
        Me.ucrReceiverSunshine.Selector = Nothing
        Me.ucrReceiverSunshine.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSunshine.TabIndex = 48
        '
        'ucrReceiverRadiation
        '
        Me.ucrReceiverRadiation.Location = New System.Drawing.Point(14, 371)
        Me.ucrReceiverRadiation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRadiation.Name = "ucrReceiverRadiation"
        Me.ucrReceiverRadiation.Selector = Nothing
        Me.ucrReceiverRadiation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRadiation.TabIndex = 48
        '
        'ucrReceiverCloudCover
        '
        Me.ucrReceiverCloudCover.Location = New System.Drawing.Point(14, 414)
        Me.ucrReceiverCloudCover.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCloudCover.Name = "ucrReceiverCloudCover"
        Me.ucrReceiverCloudCover.Selector = Nothing
        Me.ucrReceiverCloudCover.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCloudCover.TabIndex = 48
        '
        'lblCloudCover
        '
        Me.lblCloudCover.AutoSize = True
        Me.lblCloudCover.Location = New System.Drawing.Point(14, 396)
        Me.lblCloudCover.Name = "lblCloudCover"
        Me.lblCloudCover.Size = New System.Drawing.Size(68, 13)
        Me.lblCloudCover.TabIndex = 47
        Me.lblCloudCover.Text = "Cloud Cover:"
        '
        'lblRadiation
        '
        Me.lblRadiation.AutoSize = True
        Me.lblRadiation.Location = New System.Drawing.Point(14, 353)
        Me.lblRadiation.Name = "lblRadiation"
        Me.lblRadiation.Size = New System.Drawing.Size(55, 13)
        Me.lblRadiation.TabIndex = 45
        Me.lblRadiation.Text = "Radiation:"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.Location = New System.Drawing.Point(14, 267)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(80, 13)
        Me.lblWindDirection.TabIndex = 43
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'lblSunshine
        '
        Me.lblSunshine.AutoSize = True
        Me.lblSunshine.Location = New System.Drawing.Point(14, 310)
        Me.lblSunshine.Name = "lblSunshine"
        Me.lblSunshine.Size = New System.Drawing.Size(85, 13)
        Me.lblSunshine.TabIndex = 41
        Me.lblSunshine.Text = "Sunshine Hours:"
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.Location = New System.Drawing.Point(14, 224)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(69, 13)
        Me.lblWindSpeed.TabIndex = 39
        Me.lblWindSpeed.Text = "Wind Speed:"
        '
        'ucrReceiverMinTemp
        '
        Me.ucrReceiverMinTemp.Location = New System.Drawing.Point(14, 156)
        Me.ucrReceiverMinTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinTemp.Name = "ucrReceiverMinTemp"
        Me.ucrReceiverMinTemp.Selector = Nothing
        Me.ucrReceiverMinTemp.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMinTemp.TabIndex = 38
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(14, 242)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindSpeed.TabIndex = 38
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(14, 95)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(32, 13)
        Me.lblRain.TabIndex = 36
        Me.lblRain.Text = "Rain:"
        '
        'lblMinTemp
        '
        Me.lblMinTemp.AutoSize = True
        Me.lblMinTemp.Location = New System.Drawing.Point(14, 138)
        Me.lblMinTemp.Name = "lblMinTemp"
        Me.lblMinTemp.Size = New System.Drawing.Size(111, 13)
        Me.lblMinTemp.TabIndex = 35
        Me.lblMinTemp.Text = "Minimum Temperature"
        '
        'lblMaxTemp
        '
        Me.lblMaxTemp.AutoSize = True
        Me.lblMaxTemp.Location = New System.Drawing.Point(14, 181)
        Me.lblMaxTemp.Name = "lblMaxTemp"
        Me.lblMaxTemp.Size = New System.Drawing.Size(117, 13)
        Me.lblMaxTemp.TabIndex = 34
        Me.lblMaxTemp.Text = "Maximum Temperature:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(14, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 33
        Me.lblDate.Text = "Date:"
        '
        'ucrSelectorDefineClimaticData
        '
        Me.ucrSelectorDefineClimaticData.bShowHiddenColumns = False
        Me.ucrSelectorDefineClimaticData.bUseCurrentFilter = True
        Me.ucrSelectorDefineClimaticData.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorDefineClimaticData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDefineClimaticData.Name = "ucrSelectorDefineClimaticData"
        Me.ucrSelectorDefineClimaticData.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDefineClimaticData.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 337)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(423, 52)
        Me.ucrBase.TabIndex = 13
        '
        'DlgDefineClimaticData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 398)
        Me.Controls.Add(Me.grpClimaticType)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorDefineClimaticData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DlgDefineClimaticData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define Climatic Data"
        Me.grpClimaticType.ResumeLayout(False)
        Me.panClimateType.ResumeLayout(False)
        Me.panClimateType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSelectorDefineClimaticData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpClimaticType As GroupBox
    Friend WithEvents panClimateType As Panel
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverRain As ucrReceiverSingle
    Friend WithEvents ucrReceiverMaxTemp As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
    Friend WithEvents ucrReceiverSunshine As ucrReceiverSingle
    Friend WithEvents ucrReceiverRadiation As ucrReceiverSingle
    Friend WithEvents ucrReceiverCloudCover As ucrReceiverSingle
    Friend WithEvents lblCloudCover As Label
    Friend WithEvents lblRadiation As Label
    Friend WithEvents lblWindDirection As Label
    Friend WithEvents lblSunshine As Label
    Friend WithEvents lblWindSpeed As Label
    Friend WithEvents ucrReceiverMinTemp As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents lblRain As Label
    Friend WithEvents lblMinTemp As Label
    Friend WithEvents lblMaxTemp As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverDay As ucrReceiverSingle
    Friend WithEvents lblDay As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblStation As Label
End Class
