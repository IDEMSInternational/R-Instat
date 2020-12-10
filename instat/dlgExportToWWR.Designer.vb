<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgExportToWWR
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorExportToWWR = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeanRelativeHumidity = New instat.ucrReceiverSingle()
        Me.ucrReceiverPrecipitation = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeanSeaLevelPressure = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeanMonthlyAirTemperature = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeanDailyMaxAirTemperature = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeanDailyMinAirTemperature = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeanStationPressure = New instat.ucrReceiverSingle()
        Me.lblStationID = New System.Windows.Forms.Label()
        Me.lblMeanDailyMinAirTemperature = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblMeanStationPressure = New System.Windows.Forms.Label()
        Me.lblMeanSeaLevelPressure = New System.Windows.Forms.Label()
        Me.lblMeanMonthlyAirTemperature = New System.Windows.Forms.Label()
        Me.lblPrecipitation = New System.Windows.Forms.Label()
        Me.lblMeanDailyMaxAirTemperature = New System.Windows.Forms.Label()
        Me.lblMeanRelativeHumidity = New System.Windows.Forms.Label()
        Me.lblWMONumber = New System.Windows.Forms.Label()
        Me.ucrNudWMONumber = New instat.ucrNud()
        Me.btnStationMetadata = New System.Windows.Forms.Button()
        Me.UcrInputComboBox1 = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(43, 344)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorExportToWWR
        '
        Me.ucrSelectorExportToWWR.bDropUnusedFilterLevels = False
        Me.ucrSelectorExportToWWR.bShowHiddenColumns = False
        Me.ucrSelectorExportToWWR.bUseCurrentFilter = True
        Me.ucrSelectorExportToWWR.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorExportToWWR.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorExportToWWR.Name = "ucrSelectorExportToWWR"
        Me.ucrSelectorExportToWWR.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorExportToWWR.TabIndex = 1
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(258, 84)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 2
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverMeanRelativeHumidity
        '
        Me.ucrReceiverMeanRelativeHumidity.frmParent = Me
        Me.ucrReceiverMeanRelativeHumidity.Location = New System.Drawing.Point(256, 289)
        Me.ucrReceiverMeanRelativeHumidity.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanRelativeHumidity.Name = "ucrReceiverMeanRelativeHumidity"
        Me.ucrReceiverMeanRelativeHumidity.Selector = Nothing
        Me.ucrReceiverMeanRelativeHumidity.Size = New System.Drawing.Size(122, 20)
        Me.ucrReceiverMeanRelativeHumidity.strNcFilePath = ""
        Me.ucrReceiverMeanRelativeHumidity.TabIndex = 5
        Me.ucrReceiverMeanRelativeHumidity.ucrSelector = Nothing
        '
        'ucrReceiverPrecipitation
        '
        Me.ucrReceiverPrecipitation.frmParent = Me
        Me.ucrReceiverPrecipitation.Location = New System.Drawing.Point(258, 245)
        Me.ucrReceiverPrecipitation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPrecipitation.Name = "ucrReceiverPrecipitation"
        Me.ucrReceiverPrecipitation.Selector = Nothing
        Me.ucrReceiverPrecipitation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPrecipitation.strNcFilePath = ""
        Me.ucrReceiverPrecipitation.TabIndex = 7
        Me.ucrReceiverPrecipitation.ucrSelector = Nothing
        '
        'ucrReceiverMeanSeaLevelPressure
        '
        Me.ucrReceiverMeanSeaLevelPressure.frmParent = Me
        Me.ucrReceiverMeanSeaLevelPressure.Location = New System.Drawing.Point(258, 199)
        Me.ucrReceiverMeanSeaLevelPressure.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanSeaLevelPressure.Name = "ucrReceiverMeanSeaLevelPressure"
        Me.ucrReceiverMeanSeaLevelPressure.Selector = Nothing
        Me.ucrReceiverMeanSeaLevelPressure.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMeanSeaLevelPressure.strNcFilePath = ""
        Me.ucrReceiverMeanSeaLevelPressure.TabIndex = 9
        Me.ucrReceiverMeanSeaLevelPressure.ucrSelector = Nothing
        '
        'ucrReceiverMeanMonthlyAirTemperature
        '
        Me.ucrReceiverMeanMonthlyAirTemperature.frmParent = Me
        Me.ucrReceiverMeanMonthlyAirTemperature.Location = New System.Drawing.Point(19, 294)
        Me.ucrReceiverMeanMonthlyAirTemperature.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanMonthlyAirTemperature.Name = "ucrReceiverMeanMonthlyAirTemperature"
        Me.ucrReceiverMeanMonthlyAirTemperature.Selector = Nothing
        Me.ucrReceiverMeanMonthlyAirTemperature.Size = New System.Drawing.Size(158, 20)
        Me.ucrReceiverMeanMonthlyAirTemperature.strNcFilePath = ""
        Me.ucrReceiverMeanMonthlyAirTemperature.TabIndex = 8
        Me.ucrReceiverMeanMonthlyAirTemperature.ucrSelector = Nothing
        '
        'ucrReceiverMeanDailyMaxAirTemperature
        '
        Me.ucrReceiverMeanDailyMaxAirTemperature.frmParent = Me
        Me.ucrReceiverMeanDailyMaxAirTemperature.Location = New System.Drawing.Point(19, 219)
        Me.ucrReceiverMeanDailyMaxAirTemperature.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanDailyMaxAirTemperature.Name = "ucrReceiverMeanDailyMaxAirTemperature"
        Me.ucrReceiverMeanDailyMaxAirTemperature.Selector = Nothing
        Me.ucrReceiverMeanDailyMaxAirTemperature.Size = New System.Drawing.Size(158, 20)
        Me.ucrReceiverMeanDailyMaxAirTemperature.strNcFilePath = ""
        Me.ucrReceiverMeanDailyMaxAirTemperature.TabIndex = 11
        Me.ucrReceiverMeanDailyMaxAirTemperature.ucrSelector = Nothing
        '
        'ucrReceiverMeanDailyMinAirTemperature
        '
        Me.ucrReceiverMeanDailyMinAirTemperature.frmParent = Me
        Me.ucrReceiverMeanDailyMinAirTemperature.Location = New System.Drawing.Point(19, 256)
        Me.ucrReceiverMeanDailyMinAirTemperature.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanDailyMinAirTemperature.Name = "ucrReceiverMeanDailyMinAirTemperature"
        Me.ucrReceiverMeanDailyMinAirTemperature.Selector = Nothing
        Me.ucrReceiverMeanDailyMinAirTemperature.Size = New System.Drawing.Size(158, 20)
        Me.ucrReceiverMeanDailyMinAirTemperature.strNcFilePath = ""
        Me.ucrReceiverMeanDailyMinAirTemperature.TabIndex = 10
        Me.ucrReceiverMeanDailyMinAirTemperature.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(258, 120)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 13
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverMeanStationPressure
        '
        Me.ucrReceiverMeanStationPressure.frmParent = Me
        Me.ucrReceiverMeanStationPressure.Location = New System.Drawing.Point(258, 159)
        Me.ucrReceiverMeanStationPressure.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeanStationPressure.Name = "ucrReceiverMeanStationPressure"
        Me.ucrReceiverMeanStationPressure.Selector = Nothing
        Me.ucrReceiverMeanStationPressure.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMeanStationPressure.strNcFilePath = ""
        Me.ucrReceiverMeanStationPressure.TabIndex = 12
        Me.ucrReceiverMeanStationPressure.ucrSelector = Nothing
        '
        'lblStationID
        '
        Me.lblStationID.AutoSize = True
        Me.lblStationID.Location = New System.Drawing.Point(255, 32)
        Me.lblStationID.Name = "lblStationID"
        Me.lblStationID.Size = New System.Drawing.Size(57, 13)
        Me.lblStationID.TabIndex = 14
        Me.lblStationID.Text = "Station ID:"
        '
        'lblMeanDailyMinAirTemperature
        '
        Me.lblMeanDailyMinAirTemperature.AutoSize = True
        Me.lblMeanDailyMinAirTemperature.Location = New System.Drawing.Point(16, 241)
        Me.lblMeanDailyMinAirTemperature.Name = "lblMeanDailyMinAirTemperature"
        Me.lblMeanDailyMinAirTemperature.Size = New System.Drawing.Size(161, 13)
        Me.lblMeanDailyMinAirTemperature.TabIndex = 15
        Me.lblMeanDailyMinAirTemperature.Text = "Mean Daily Min Air Temperature:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(255, 71)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 16
        Me.lblYear.Text = "Year:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(255, 107)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 17
        Me.lblMonth.Text = "Month:"
        '
        'lblMeanStationPressure
        '
        Me.lblMeanStationPressure.AutoSize = True
        Me.lblMeanStationPressure.Location = New System.Drawing.Point(255, 146)
        Me.lblMeanStationPressure.Name = "lblMeanStationPressure"
        Me.lblMeanStationPressure.Size = New System.Drawing.Size(117, 13)
        Me.lblMeanStationPressure.TabIndex = 18
        Me.lblMeanStationPressure.Text = "Mean Station Pressure:"
        '
        'lblMeanSeaLevelPressure
        '
        Me.lblMeanSeaLevelPressure.AutoSize = True
        Me.lblMeanSeaLevelPressure.Location = New System.Drawing.Point(255, 186)
        Me.lblMeanSeaLevelPressure.Name = "lblMeanSeaLevelPressure"
        Me.lblMeanSeaLevelPressure.Size = New System.Drawing.Size(132, 13)
        Me.lblMeanSeaLevelPressure.TabIndex = 19
        Me.lblMeanSeaLevelPressure.Text = "Mean Sea Level Pressure:"
        '
        'lblMeanMonthlyAirTemperature
        '
        Me.lblMeanMonthlyAirTemperature.AutoSize = True
        Me.lblMeanMonthlyAirTemperature.Location = New System.Drawing.Point(16, 281)
        Me.lblMeanMonthlyAirTemperature.Name = "lblMeanMonthlyAirTemperature"
        Me.lblMeanMonthlyAirTemperature.Size = New System.Drawing.Size(155, 13)
        Me.lblMeanMonthlyAirTemperature.TabIndex = 20
        Me.lblMeanMonthlyAirTemperature.Text = "Mean Monthly Air Temperature:"
        '
        'lblPrecipitation
        '
        Me.lblPrecipitation.AutoSize = True
        Me.lblPrecipitation.Location = New System.Drawing.Point(255, 232)
        Me.lblPrecipitation.Name = "lblPrecipitation"
        Me.lblPrecipitation.Size = New System.Drawing.Size(68, 13)
        Me.lblPrecipitation.TabIndex = 21
        Me.lblPrecipitation.Text = "Precipitation:"
        '
        'lblMeanDailyMaxAirTemperature
        '
        Me.lblMeanDailyMaxAirTemperature.AutoSize = True
        Me.lblMeanDailyMaxAirTemperature.Location = New System.Drawing.Point(16, 204)
        Me.lblMeanDailyMaxAirTemperature.Name = "lblMeanDailyMaxAirTemperature"
        Me.lblMeanDailyMaxAirTemperature.Size = New System.Drawing.Size(164, 13)
        Me.lblMeanDailyMaxAirTemperature.TabIndex = 23
        Me.lblMeanDailyMaxAirTemperature.Text = "Mean Daily Max Air Temperature:"
        '
        'lblMeanRelativeHumidity
        '
        Me.lblMeanRelativeHumidity.AutoSize = True
        Me.lblMeanRelativeHumidity.Location = New System.Drawing.Point(253, 274)
        Me.lblMeanRelativeHumidity.Name = "lblMeanRelativeHumidity"
        Me.lblMeanRelativeHumidity.Size = New System.Drawing.Size(125, 13)
        Me.lblMeanRelativeHumidity.TabIndex = 24
        Me.lblMeanRelativeHumidity.Text = "Mean Daily Rel Humidity:"
        '
        'lblWMONumber
        '
        Me.lblWMONumber.AutoSize = True
        Me.lblWMONumber.Location = New System.Drawing.Point(398, 49)
        Me.lblWMONumber.Name = "lblWMONumber"
        Me.lblWMONumber.Size = New System.Drawing.Size(55, 13)
        Me.lblWMONumber.TabIndex = 25
        Me.lblWMONumber.Text = "WMO No:"
        '
        'ucrNudWMONumber
        '
        Me.ucrNudWMONumber.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWMONumber.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWMONumber.Location = New System.Drawing.Point(461, 45)
        Me.ucrNudWMONumber.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWMONumber.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWMONumber.Name = "ucrNudWMONumber"
        Me.ucrNudWMONumber.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWMONumber.TabIndex = 26
        Me.ucrNudWMONumber.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'btnStationMetadata
        '
        Me.btnStationMetadata.Location = New System.Drawing.Point(401, 84)
        Me.btnStationMetadata.Name = "btnStationMetadata"
        Me.btnStationMetadata.Size = New System.Drawing.Size(128, 36)
        Me.btnStationMetadata.TabIndex = 27
        Me.btnStationMetadata.Text = "Station Metadata:"
        Me.btnStationMetadata.UseVisualStyleBackColor = True
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox1.GetSetSelectedIndex = -1
        Me.UcrInputComboBox1.IsReadOnly = False
        Me.UcrInputComboBox1.Location = New System.Drawing.Point(258, 47)
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        Me.UcrInputComboBox1.Size = New System.Drawing.Size(120, 21)
        Me.UcrInputComboBox1.TabIndex = 28
        '
        'dlgExportToWWR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 421)
        Me.Controls.Add(Me.UcrInputComboBox1)
        Me.Controls.Add(Me.btnStationMetadata)
        Me.Controls.Add(Me.ucrNudWMONumber)
        Me.Controls.Add(Me.lblWMONumber)
        Me.Controls.Add(Me.lblMeanRelativeHumidity)
        Me.Controls.Add(Me.lblMeanDailyMaxAirTemperature)
        Me.Controls.Add(Me.lblPrecipitation)
        Me.Controls.Add(Me.lblMeanMonthlyAirTemperature)
        Me.Controls.Add(Me.lblMeanSeaLevelPressure)
        Me.Controls.Add(Me.lblMeanStationPressure)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblMeanDailyMinAirTemperature)
        Me.Controls.Add(Me.lblStationID)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverMeanStationPressure)
        Me.Controls.Add(Me.ucrReceiverMeanDailyMaxAirTemperature)
        Me.Controls.Add(Me.ucrReceiverMeanDailyMinAirTemperature)
        Me.Controls.Add(Me.ucrReceiverMeanSeaLevelPressure)
        Me.Controls.Add(Me.ucrReceiverMeanMonthlyAirTemperature)
        Me.Controls.Add(Me.ucrReceiverPrecipitation)
        Me.Controls.Add(Me.ucrReceiverMeanRelativeHumidity)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrSelectorExportToWWR)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportToWWR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export To WWR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorExportToWWR As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblMeanRelativeHumidity As Label
    Friend WithEvents lblMeanDailyMaxAirTemperature As Label
    Friend WithEvents lblPrecipitation As Label
    Friend WithEvents lblMeanMonthlyAirTemperature As Label
    Friend WithEvents lblMeanSeaLevelPressure As Label
    Friend WithEvents lblMeanStationPressure As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblMeanDailyMinAirTemperature As Label
    Friend WithEvents lblStationID As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanStationPressure As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanDailyMaxAirTemperature As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanDailyMinAirTemperature As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanSeaLevelPressure As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanMonthlyAirTemperature As ucrReceiverSingle
    Friend WithEvents ucrReceiverPrecipitation As ucrReceiverSingle
    Friend WithEvents ucrReceiverMeanRelativeHumidity As ucrReceiverSingle
    Friend WithEvents ucrNudWMONumber As ucrNud
    Friend WithEvents lblWMONumber As Label
    Friend WithEvents btnStationMetadata As Button
    Friend WithEvents UcrInputComboBox1 As ucrInputComboBox
End Class
