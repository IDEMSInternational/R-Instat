<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOutfillingStationData
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorOutfilling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverRain = New instat.ucrReceiverSingle()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverEstimates = New instat.ucrReceiverSingle()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblLong = New System.Windows.Forms.Label()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.lblEstimates = New System.Windows.Forms.Label()
        Me.ucrInputBins = New instat.ucrInputComboBox()
        Me.lblBins = New System.Windows.Forms.Label()
        Me.ucrNudCount = New instat.ucrNud()
        Me.ucrNudDays = New instat.ucrNud()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.cmdOmitMonths = New System.Windows.Forms.Button()
        Me.ucrInputDist = New instat.ucrInputComboBox()
        Me.ucrInputMarkov = New instat.ucrInputComboBox()
        Me.lblDist = New System.Windows.Forms.Label()
        Me.lblMarkov = New System.Windows.Forms.Label()
        Me.ucrChkOmitMonths = New instat.ucrCheck()
        Me.ucrInputSelectStation = New instat.ucrInputFactorLevels()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(16, 558)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(615, 78)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorOutfilling
        '
        Me.ucrSelectorOutfilling.AutoSize = True
        Me.ucrSelectorOutfilling.bDropUnusedFilterLevels = False
        Me.ucrSelectorOutfilling.bShowHiddenColumns = False
        Me.ucrSelectorOutfilling.bUseCurrentFilter = True
        Me.ucrSelectorOutfilling.Location = New System.Drawing.Point(9, 17)
        Me.ucrSelectorOutfilling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOutfilling.Name = "ucrSelectorOutfilling"
        Me.ucrSelectorOutfilling.Size = New System.Drawing.Size(318, 274)
        Me.ucrSelectorOutfilling.TabIndex = 1
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(492, 55)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.AutoSize = True
        Me.ucrReceiverRain.frmParent = Me
        Me.ucrReceiverRain.Location = New System.Drawing.Point(492, 371)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverRain.strNcFilePath = ""
        Me.ucrReceiverRain.TabIndex = 3
        Me.ucrReceiverRain.ucrSelector = Nothing
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.AutoSize = True
        Me.ucrReceiverLongitude.frmParent = Me
        Me.ucrReceiverLongitude.Location = New System.Drawing.Point(492, 303)
        Me.ucrReceiverLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.TabIndex = 4
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(492, 236)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 5
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(492, 170)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 6
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverEstimates
        '
        Me.ucrReceiverEstimates.AutoSize = True
        Me.ucrReceiverEstimates.frmParent = Me
        Me.ucrReceiverEstimates.Location = New System.Drawing.Point(492, 444)
        Me.ucrReceiverEstimates.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEstimates.Name = "ucrReceiverEstimates"
        Me.ucrReceiverEstimates.Selector = Nothing
        Me.ucrReceiverEstimates.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverEstimates.strNcFilePath = ""
        Me.ucrReceiverEstimates.TabIndex = 7
        Me.ucrReceiverEstimates.ucrSelector = Nothing
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(496, 28)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(64, 20)
        Me.lblStation.TabIndex = 8
        Me.lblStation.Text = "Station:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(496, 144)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 9
        Me.lblDate.Text = "Date:"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Location = New System.Drawing.Point(496, 209)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(71, 20)
        Me.lblLatitude.TabIndex = 10
        Me.lblLatitude.Text = "Latitude:"
        '
        'lblLong
        '
        Me.lblLong.AutoSize = True
        Me.lblLong.Location = New System.Drawing.Point(496, 276)
        Me.lblLong.Name = "lblLong"
        Me.lblLong.Size = New System.Drawing.Size(84, 20)
        Me.lblLong.TabIndex = 11
        Me.lblLong.Text = "Longitude:"
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(496, 344)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(46, 20)
        Me.lblRain.TabIndex = 12
        Me.lblRain.Text = "Rain:"
        '
        'lblEstimates
        '
        Me.lblEstimates.AutoSize = True
        Me.lblEstimates.Location = New System.Drawing.Point(496, 417)
        Me.lblEstimates.Name = "lblEstimates"
        Me.lblEstimates.Size = New System.Drawing.Size(84, 20)
        Me.lblEstimates.TabIndex = 13
        Me.lblEstimates.Text = "Estimates:"
        '
        'ucrInputBins
        '
        Me.ucrInputBins.AddQuotesIfUnrecognised = True
        Me.ucrInputBins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBins.GetSetSelectedIndex = -1
        Me.ucrInputBins.IsReadOnly = False
        Me.ucrInputBins.Location = New System.Drawing.Point(104, 304)
        Me.ucrInputBins.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputBins.Name = "ucrInputBins"
        Me.ucrInputBins.Size = New System.Drawing.Size(254, 32)
        Me.ucrInputBins.TabIndex = 54
        '
        'lblBins
        '
        Me.lblBins.AutoSize = True
        Me.lblBins.Location = New System.Drawing.Point(43, 309)
        Me.lblBins.Name = "lblBins"
        Me.lblBins.Size = New System.Drawing.Size(44, 20)
        Me.lblBins.TabIndex = 55
        Me.lblBins.Text = "Bins:"
        '
        'ucrNudCount
        '
        Me.ucrNudCount.AutoSize = True
        Me.ucrNudCount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCount.Location = New System.Drawing.Point(104, 353)
        Me.ucrNudCount.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudCount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCount.Name = "ucrNudCount"
        Me.ucrNudCount.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudCount.TabIndex = 56
        Me.ucrNudCount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDays
        '
        Me.ucrNudDays.AutoSize = True
        Me.ucrNudDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDays.Location = New System.Drawing.Point(104, 397)
        Me.ucrNudDays.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDays.Name = "ucrNudDays"
        Me.ucrNudDays.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudDays.TabIndex = 57
        Me.ucrNudDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(43, 407)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(49, 20)
        Me.lblDays.TabIndex = 58
        Me.lblDays.Text = "Days:"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(36, 358)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(56, 20)
        Me.lblCount.TabIndex = 59
        Me.lblCount.Text = "Count:"
        '
        'cmdOmitMonths
        '
        Me.cmdOmitMonths.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOmitMonths.Location = New System.Drawing.Point(564, 481)
        Me.cmdOmitMonths.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOmitMonths.Name = "cmdOmitMonths"
        Me.cmdOmitMonths.Size = New System.Drawing.Size(104, 66)
        Me.cmdOmitMonths.TabIndex = 60
        Me.cmdOmitMonths.Text = "Omit Months"
        Me.cmdOmitMonths.UseVisualStyleBackColor = True
        '
        'ucrInputDist
        '
        Me.ucrInputDist.AddQuotesIfUnrecognised = True
        Me.ucrInputDist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDist.GetSetSelectedIndex = -1
        Me.ucrInputDist.IsReadOnly = False
        Me.ucrInputDist.Location = New System.Drawing.Point(104, 437)
        Me.ucrInputDist.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputDist.Name = "ucrInputDist"
        Me.ucrInputDist.Size = New System.Drawing.Size(171, 32)
        Me.ucrInputDist.TabIndex = 61
        '
        'ucrInputMarkov
        '
        Me.ucrInputMarkov.AddQuotesIfUnrecognised = True
        Me.ucrInputMarkov.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMarkov.GetSetSelectedIndex = -1
        Me.ucrInputMarkov.IsReadOnly = False
        Me.ucrInputMarkov.Location = New System.Drawing.Point(104, 485)
        Me.ucrInputMarkov.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputMarkov.Name = "ucrInputMarkov"
        Me.ucrInputMarkov.Size = New System.Drawing.Size(173, 32)
        Me.ucrInputMarkov.TabIndex = 62
        '
        'lblDist
        '
        Me.lblDist.AutoSize = True
        Me.lblDist.Location = New System.Drawing.Point(5, 441)
        Me.lblDist.Name = "lblDist"
        Me.lblDist.Size = New System.Drawing.Size(93, 20)
        Me.lblDist.TabIndex = 63
        Me.lblDist.Text = "Distribution:"
        '
        'lblMarkov
        '
        Me.lblMarkov.AutoSize = True
        Me.lblMarkov.Location = New System.Drawing.Point(28, 490)
        Me.lblMarkov.Name = "lblMarkov"
        Me.lblMarkov.Size = New System.Drawing.Size(64, 20)
        Me.lblMarkov.TabIndex = 64
        Me.lblMarkov.Text = "Markov:"
        '
        'ucrChkOmitMonths
        '
        Me.ucrChkOmitMonths.AutoSize = True
        Me.ucrChkOmitMonths.Checked = False
        Me.ucrChkOmitMonths.Location = New System.Drawing.Point(394, 497)
        Me.ucrChkOmitMonths.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkOmitMonths.Name = "ucrChkOmitMonths"
        Me.ucrChkOmitMonths.Size = New System.Drawing.Size(150, 34)
        Me.ucrChkOmitMonths.TabIndex = 65
        '
        'ucrInputSelectStation
        '
        Me.ucrInputSelectStation.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSelectStation.GetSetSelectedIndex = -1
        Me.ucrInputSelectStation.IsReadOnly = False
        Me.ucrInputSelectStation.Location = New System.Drawing.Point(497, 111)
        Me.ucrInputSelectStation.Margin = New System.Windows.Forms.Padding(21)
        Me.ucrInputSelectStation.Name = "ucrInputSelectStation"
        Me.ucrInputSelectStation.Size = New System.Drawing.Size(180, 34)
        Me.ucrInputSelectStation.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(498, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Station To Exclude:"
        '
        'dlgOutfillingStationData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 655)
        Me.Controls.Add(Me.ucrInputSelectStation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrChkOmitMonths)
        Me.Controls.Add(Me.lblMarkov)
        Me.Controls.Add(Me.lblDist)
        Me.Controls.Add(Me.ucrInputMarkov)
        Me.Controls.Add(Me.ucrInputDist)
        Me.Controls.Add(Me.cmdOmitMonths)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.ucrNudDays)
        Me.Controls.Add(Me.ucrNudCount)
        Me.Controls.Add(Me.lblBins)
        Me.Controls.Add(Me.ucrInputBins)
        Me.Controls.Add(Me.lblEstimates)
        Me.Controls.Add(Me.lblRain)
        Me.Controls.Add(Me.lblLong)
        Me.Controls.Add(Me.lblLatitude)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverEstimates)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverLatitude)
        Me.Controls.Add(Me.ucrReceiverLongitude)
        Me.Controls.Add(Me.ucrReceiverRain)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorOutfilling)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOutfillingStationData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Outfilling Station Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorOutfilling As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblEstimates As Label
    Friend WithEvents lblRain As Label
    Friend WithEvents lblLong As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverEstimates As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverRain As ucrReceiverSingle
    Friend WithEvents lblCount As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents ucrNudDays As ucrNud
    Friend WithEvents ucrNudCount As ucrNud
    Friend WithEvents lblBins As Label
    Friend WithEvents ucrInputBins As ucrInputComboBox
    Friend WithEvents lblMarkov As Label
    Friend WithEvents lblDist As Label
    Friend WithEvents ucrInputMarkov As ucrInputComboBox
    Friend WithEvents ucrInputDist As ucrInputComboBox
    Friend WithEvents cmdOmitMonths As Button
    Friend WithEvents ucrChkOmitMonths As ucrCheck
    Friend WithEvents ucrInputSelectStation As ucrInputFactorLevels
    Friend WithEvents Label1 As Label
End Class
