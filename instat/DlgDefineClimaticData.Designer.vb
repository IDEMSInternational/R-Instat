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
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
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
        Me.grpDateTime = New System.Windows.Forms.GroupBox()
        Me.grpClimaticType.SuspendLayout()
        Me.grpDateTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpClimaticType
        '
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverWindDirection)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverRain)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverSunshine)
        Me.grpClimaticType.Controls.Add(Me.lblRain)
        Me.grpClimaticType.Controls.Add(Me.lblStation)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverRadiation)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverStation)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverMaxTemp)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverCloudCover)
        Me.grpClimaticType.Controls.Add(Me.lblMaxTemp)
        Me.grpClimaticType.Controls.Add(Me.lblCloudCover)
        Me.grpClimaticType.Controls.Add(Me.lblMinTemp)
        Me.grpClimaticType.Controls.Add(Me.lblRadiation)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverWindSpeed)
        Me.grpClimaticType.Controls.Add(Me.lblSunshine)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverMinTemp)
        Me.grpClimaticType.Controls.Add(Me.lblWindSpeed)
        Me.grpClimaticType.Controls.Add(Me.lblWindDirection)
        Me.grpClimaticType.Location = New System.Drawing.Point(237, 6)
        Me.grpClimaticType.Name = "grpClimaticType"
        Me.grpClimaticType.Size = New System.Drawing.Size(187, 406)
        Me.grpClimaticType.TabIndex = 1
        Me.grpClimaticType.TabStop = False
        Me.grpClimaticType.Text = "Climatic Type"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(40, 180)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(66, 13)
        Me.lblDOY.TabIndex = 26
        Me.lblDOY.Text = "Day of Year:"
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(38, 198)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDOY.TabIndex = 27
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.frmParent = Me
        Me.ucrReceiverDay.Location = New System.Drawing.Point(38, 154)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDay.TabIndex = 25
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(39, 141)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(29, 13)
        Me.lblDay.TabIndex = 24
        Me.lblDay.Text = "Day:"
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(38, 116)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.TabIndex = 23
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(39, 98)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 22
        Me.lblMonth.Text = "Month:"
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(39, 72)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.TabIndex = 21
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(39, 59)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 20
        Me.lblYear.Text = "Year:"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(32, 37)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.TabIndex = 3
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(29, 16)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 2
        Me.lblStation.Text = "Station:"
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(40, 35)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.TabIndex = 1
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.frmParent = Me
        Me.ucrReceiverRain.Location = New System.Drawing.Point(35, 75)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRain.TabIndex = 5
        '
        'ucrReceiverMaxTemp
        '
        Me.ucrReceiverMaxTemp.frmParent = Me
        Me.ucrReceiverMaxTemp.Location = New System.Drawing.Point(35, 161)
        Me.ucrReceiverMaxTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxTemp.Name = "ucrReceiverMaxTemp"
        Me.ucrReceiverMaxTemp.Selector = Nothing
        Me.ucrReceiverMaxTemp.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMaxTemp.TabIndex = 9
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(35, 250)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection.TabIndex = 13
        '
        'ucrReceiverSunshine
        '
        Me.ucrReceiverSunshine.frmParent = Me
        Me.ucrReceiverSunshine.Location = New System.Drawing.Point(35, 293)
        Me.ucrReceiverSunshine.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSunshine.Name = "ucrReceiverSunshine"
        Me.ucrReceiverSunshine.Selector = Nothing
        Me.ucrReceiverSunshine.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSunshine.TabIndex = 15
        '
        'ucrReceiverRadiation
        '
        Me.ucrReceiverRadiation.frmParent = Me
        Me.ucrReceiverRadiation.Location = New System.Drawing.Point(35, 336)
        Me.ucrReceiverRadiation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRadiation.Name = "ucrReceiverRadiation"
        Me.ucrReceiverRadiation.Selector = Nothing
        Me.ucrReceiverRadiation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRadiation.TabIndex = 17
        '
        'ucrReceiverCloudCover
        '
        Me.ucrReceiverCloudCover.frmParent = Me
        Me.ucrReceiverCloudCover.Location = New System.Drawing.Point(35, 379)
        Me.ucrReceiverCloudCover.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCloudCover.Name = "ucrReceiverCloudCover"
        Me.ucrReceiverCloudCover.Selector = Nothing
        Me.ucrReceiverCloudCover.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCloudCover.TabIndex = 19
        '
        'lblCloudCover
        '
        Me.lblCloudCover.AutoSize = True
        Me.lblCloudCover.Location = New System.Drawing.Point(35, 361)
        Me.lblCloudCover.Name = "lblCloudCover"
        Me.lblCloudCover.Size = New System.Drawing.Size(68, 13)
        Me.lblCloudCover.TabIndex = 18
        Me.lblCloudCover.Text = "Cloud Cover:"
        '
        'lblRadiation
        '
        Me.lblRadiation.AutoSize = True
        Me.lblRadiation.Location = New System.Drawing.Point(35, 318)
        Me.lblRadiation.Name = "lblRadiation"
        Me.lblRadiation.Size = New System.Drawing.Size(55, 13)
        Me.lblRadiation.TabIndex = 16
        Me.lblRadiation.Text = "Radiation:"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.Location = New System.Drawing.Point(35, 229)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(80, 13)
        Me.lblWindDirection.TabIndex = 12
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'lblSunshine
        '
        Me.lblSunshine.AutoSize = True
        Me.lblSunshine.Location = New System.Drawing.Point(35, 275)
        Me.lblSunshine.Name = "lblSunshine"
        Me.lblSunshine.Size = New System.Drawing.Size(85, 13)
        Me.lblSunshine.TabIndex = 14
        Me.lblSunshine.Text = "Sunshine Hours:"
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.Location = New System.Drawing.Point(35, 186)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(69, 13)
        Me.lblWindSpeed.TabIndex = 10
        Me.lblWindSpeed.Text = "Wind Speed:"
        '
        'ucrReceiverMinTemp
        '
        Me.ucrReceiverMinTemp.frmParent = Me
        Me.ucrReceiverMinTemp.Location = New System.Drawing.Point(35, 118)
        Me.ucrReceiverMinTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinTemp.Name = "ucrReceiverMinTemp"
        Me.ucrReceiverMinTemp.Selector = Nothing
        Me.ucrReceiverMinTemp.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMinTemp.TabIndex = 7
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(35, 204)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindSpeed.TabIndex = 11
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(35, 57)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(32, 13)
        Me.lblRain.TabIndex = 4
        Me.lblRain.Text = "Rain:"
        '
        'lblMinTemp
        '
        Me.lblMinTemp.AutoSize = True
        Me.lblMinTemp.Location = New System.Drawing.Point(35, 100)
        Me.lblMinTemp.Name = "lblMinTemp"
        Me.lblMinTemp.Size = New System.Drawing.Size(111, 13)
        Me.lblMinTemp.TabIndex = 6
        Me.lblMinTemp.Text = "Minimum Temperature"
        '
        'lblMaxTemp
        '
        Me.lblMaxTemp.AutoSize = True
        Me.lblMaxTemp.Location = New System.Drawing.Point(35, 143)
        Me.lblMaxTemp.Name = "lblMaxTemp"
        Me.lblMaxTemp.Size = New System.Drawing.Size(117, 13)
        Me.lblMaxTemp.TabIndex = 8
        Me.lblMaxTemp.Text = "Maximum Temperature:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(40, 17)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date:"
        '
        'ucrSelectorDefineClimaticData
        '
        Me.ucrSelectorDefineClimaticData.bShowHiddenColumns = False
        Me.ucrSelectorDefineClimaticData.bUseCurrentFilter = True
        Me.ucrSelectorDefineClimaticData.Location = New System.Drawing.Point(7, 2)
        Me.ucrSelectorDefineClimaticData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDefineClimaticData.Name = "ucrSelectorDefineClimaticData"
        Me.ucrSelectorDefineClimaticData.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDefineClimaticData.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(8, 419)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(423, 52)
        Me.ucrBase.TabIndex = 2
        '
        'grpDateTime
        '
        Me.grpDateTime.Controls.Add(Me.lblDOY)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverYear)
        Me.grpDateTime.Controls.Add(Me.lblDate)
        Me.grpDateTime.Controls.Add(Me.lblMonth)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverDOY)
        Me.grpDateTime.Controls.Add(Me.lblYear)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverDate)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverMonth)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverDay)
        Me.grpDateTime.Controls.Add(Me.lblDay)
        Me.grpDateTime.Location = New System.Drawing.Point(6, 190)
        Me.grpDateTime.Name = "grpDateTime"
        Me.grpDateTime.Size = New System.Drawing.Size(187, 222)
        Me.grpDateTime.TabIndex = 3
        Me.grpDateTime.TabStop = False
        Me.grpDateTime.Tag = ""
        Me.grpDateTime.Text = "Date and time"
        '
        'DlgDefineClimaticData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 480)
        Me.Controls.Add(Me.grpDateTime)
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
        Me.grpClimaticType.PerformLayout()
        Me.grpDateTime.ResumeLayout(False)
        Me.grpDateTime.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSelectorDefineClimaticData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpClimaticType As GroupBox
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
    Friend WithEvents lblDOY As Label
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents grpDateTime As GroupBox
End Class
