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
        Me.ucrInputDist = New instat.ucrInputComboBox()
        Me.ucrInputMarkov = New instat.ucrInputComboBox()
        Me.lblDist = New System.Windows.Forms.Label()
        Me.lblMarkov = New System.Windows.Forms.Label()
        Me.ucrChkOmitMonths = New instat.ucrCheck()
        Me.ucrInputOmitMonths = New instat.ucrInputComboBox()
        Me.ucrChkStationToExclude = New instat.ucrCheck()
        Me.ucrChkRandomSeed = New instat.ucrCheck()
        Me.ucrNudRandomSeed = New instat.ucrNud()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.cmdFilterFromFactors = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 432)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 51)
        Me.ucrBase.TabIndex = 27
        '
        'ucrSelectorOutfilling
        '
        Me.ucrSelectorOutfilling.AutoSize = True
        Me.ucrSelectorOutfilling.bDropUnusedFilterLevels = False
        Me.ucrSelectorOutfilling.bShowHiddenColumns = False
        Me.ucrSelectorOutfilling.bUseCurrentFilter = True
        Me.ucrSelectorOutfilling.Location = New System.Drawing.Point(6, 10)
        Me.ucrSelectorOutfilling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOutfilling.Name = "ucrSelectorOutfilling"
        Me.ucrSelectorOutfilling.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorOutfilling.TabIndex = 0
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(328, 39)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.AutoSize = True
        Me.ucrReceiverRain.frmParent = Me
        Me.ucrReceiverRain.Location = New System.Drawing.Point(328, 221)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRain.strNcFilePath = ""
        Me.ucrReceiverRain.TabIndex = 12
        Me.ucrReceiverRain.ucrSelector = Nothing
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.AutoSize = True
        Me.ucrReceiverLongitude.frmParent = Me
        Me.ucrReceiverLongitude.Location = New System.Drawing.Point(328, 177)
        Me.ucrReceiverLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.TabIndex = 10
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(328, 130)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(120, 23)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 8
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(328, 83)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 6
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverEstimates
        '
        Me.ucrReceiverEstimates.AutoSize = True
        Me.ucrReceiverEstimates.frmParent = Me
        Me.ucrReceiverEstimates.Location = New System.Drawing.Point(328, 267)
        Me.ucrReceiverEstimates.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEstimates.Name = "ucrReceiverEstimates"
        Me.ucrReceiverEstimates.Selector = Nothing
        Me.ucrReceiverEstimates.Size = New System.Drawing.Size(120, 22)
        Me.ucrReceiverEstimates.strNcFilePath = ""
        Me.ucrReceiverEstimates.TabIndex = 14
        Me.ucrReceiverEstimates.ucrSelector = Nothing
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(331, 21)
        Me.lblStation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 1
        Me.lblStation.Text = "Station:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(331, 66)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Date:"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Location = New System.Drawing.Point(331, 113)
        Me.lblLatitude.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(48, 13)
        Me.lblLatitude.TabIndex = 7
        Me.lblLatitude.Text = "Latitude:"
        '
        'lblLong
        '
        Me.lblLong.AutoSize = True
        Me.lblLong.Location = New System.Drawing.Point(331, 159)
        Me.lblLong.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLong.Name = "lblLong"
        Me.lblLong.Size = New System.Drawing.Size(57, 13)
        Me.lblLong.TabIndex = 9
        Me.lblLong.Text = "Longitude:"
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(331, 204)
        Me.lblRain.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(32, 13)
        Me.lblRain.TabIndex = 11
        Me.lblRain.Text = "Rain:"
        '
        'lblEstimates
        '
        Me.lblEstimates.AutoSize = True
        Me.lblEstimates.Location = New System.Drawing.Point(331, 248)
        Me.lblEstimates.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstimates.Name = "lblEstimates"
        Me.lblEstimates.Size = New System.Drawing.Size(55, 13)
        Me.lblEstimates.TabIndex = 13
        Me.lblEstimates.Text = "Estimates:"
        '
        'ucrInputBins
        '
        Me.ucrInputBins.AddQuotesIfUnrecognised = True
        Me.ucrInputBins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBins.GetSetSelectedIndex = -1
        Me.ucrInputBins.IsReadOnly = False
        Me.ucrInputBins.Location = New System.Drawing.Point(60, 324)
        Me.ucrInputBins.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputBins.Name = "ucrInputBins"
        Me.ucrInputBins.Size = New System.Drawing.Size(132, 21)
        Me.ucrInputBins.TabIndex = 16
        '
        'lblBins
        '
        Me.lblBins.AutoSize = True
        Me.lblBins.Location = New System.Drawing.Point(6, 328)
        Me.lblBins.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBins.Name = "lblBins"
        Me.lblBins.Size = New System.Drawing.Size(30, 13)
        Me.lblBins.TabIndex = 15
        Me.lblBins.Text = "Bins:"
        '
        'ucrNudCount
        '
        Me.ucrNudCount.AutoSize = True
        Me.ucrNudCount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCount.Location = New System.Drawing.Point(60, 356)
        Me.ucrNudCount.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrNudCount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCount.Name = "ucrNudCount"
        Me.ucrNudCount.Size = New System.Drawing.Size(50, 32)
        Me.ucrNudCount.TabIndex = 18
        Me.ucrNudCount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDays
        '
        Me.ucrNudDays.AutoSize = True
        Me.ucrNudDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDays.Location = New System.Drawing.Point(328, 297)
        Me.ucrNudDays.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrNudDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDays.Name = "ucrNudDays"
        Me.ucrNudDays.Size = New System.Drawing.Size(50, 21)
        Me.ucrNudDays.TabIndex = 20
        Me.ucrNudDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(291, 299)
        Me.lblDays.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(34, 13)
        Me.lblDays.TabIndex = 19
        Me.lblDays.Text = "Days:"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(6, 360)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(38, 13)
        Me.lblCount.TabIndex = 17
        Me.lblCount.Text = "Count:"
        '
        'ucrInputDist
        '
        Me.ucrInputDist.AddQuotesIfUnrecognised = True
        Me.ucrInputDist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDist.GetSetSelectedIndex = -1
        Me.ucrInputDist.IsReadOnly = False
        Me.ucrInputDist.Location = New System.Drawing.Point(328, 330)
        Me.ucrInputDist.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrInputDist.Name = "ucrInputDist"
        Me.ucrInputDist.Size = New System.Drawing.Size(77, 21)
        Me.ucrInputDist.TabIndex = 22
        '
        'ucrInputMarkov
        '
        Me.ucrInputMarkov.AddQuotesIfUnrecognised = True
        Me.ucrInputMarkov.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMarkov.GetSetSelectedIndex = -1
        Me.ucrInputMarkov.IsReadOnly = False
        Me.ucrInputMarkov.Location = New System.Drawing.Point(328, 369)
        Me.ucrInputMarkov.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrInputMarkov.Name = "ucrInputMarkov"
        Me.ucrInputMarkov.Size = New System.Drawing.Size(77, 21)
        Me.ucrInputMarkov.TabIndex = 24
        '
        'lblDist
        '
        Me.lblDist.AutoSize = True
        Me.lblDist.Location = New System.Drawing.Point(264, 332)
        Me.lblDist.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDist.Name = "lblDist"
        Me.lblDist.Size = New System.Drawing.Size(62, 13)
        Me.lblDist.TabIndex = 21
        Me.lblDist.Text = "Distribution:"
        '
        'lblMarkov
        '
        Me.lblMarkov.AutoSize = True
        Me.lblMarkov.Location = New System.Drawing.Point(282, 372)
        Me.lblMarkov.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMarkov.Name = "lblMarkov"
        Me.lblMarkov.Size = New System.Drawing.Size(46, 13)
        Me.lblMarkov.TabIndex = 23
        Me.lblMarkov.Text = "Markov:"
        '
        'ucrChkOmitMonths
        '
        Me.ucrChkOmitMonths.AutoSize = True
        Me.ucrChkOmitMonths.Checked = False
        Me.ucrChkOmitMonths.Location = New System.Drawing.Point(6, 245)
        Me.ucrChkOmitMonths.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkOmitMonths.Name = "ucrChkOmitMonths"
        Me.ucrChkOmitMonths.Size = New System.Drawing.Size(114, 23)
        Me.ucrChkOmitMonths.TabIndex = 25
        '
        'ucrInputOmitMonths
        '
        Me.ucrInputOmitMonths.AddQuotesIfUnrecognised = True
        Me.ucrInputOmitMonths.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputOmitMonths.GetSetSelectedIndex = -1
        Me.ucrInputOmitMonths.IsReadOnly = False
        Me.ucrInputOmitMonths.Location = New System.Drawing.Point(133, 244)
        Me.ucrInputOmitMonths.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputOmitMonths.Name = "ucrInputOmitMonths"
        Me.ucrInputOmitMonths.Size = New System.Drawing.Size(114, 21)
        Me.ucrInputOmitMonths.TabIndex = 28
        '
        'ucrChkStationToExclude
        '
        Me.ucrChkStationToExclude.AutoSize = True
        Me.ucrChkStationToExclude.Checked = False
        Me.ucrChkStationToExclude.Location = New System.Drawing.Point(6, 202)
        Me.ucrChkStationToExclude.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkStationToExclude.Name = "ucrChkStationToExclude"
        Me.ucrChkStationToExclude.Size = New System.Drawing.Size(125, 23)
        Me.ucrChkStationToExclude.TabIndex = 29
        '
        'ucrChkRandomSeed
        '
        Me.ucrChkRandomSeed.AutoSize = True
        Me.ucrChkRandomSeed.Checked = False
        Me.ucrChkRandomSeed.Location = New System.Drawing.Point(6, 282)
        Me.ucrChkRandomSeed.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkRandomSeed.Name = "ucrChkRandomSeed"
        Me.ucrChkRandomSeed.Size = New System.Drawing.Size(117, 23)
        Me.ucrChkRandomSeed.TabIndex = 30
        '
        'ucrNudRandomSeed
        '
        Me.ucrNudRandomSeed.AutoSize = True
        Me.ucrNudRandomSeed.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRandomSeed.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRandomSeed.Location = New System.Drawing.Point(133, 284)
        Me.ucrNudRandomSeed.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrNudRandomSeed.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRandomSeed.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRandomSeed.Name = "ucrNudRandomSeed"
        Me.ucrNudRandomSeed.Size = New System.Drawing.Size(78, 27)
        Me.ucrNudRandomSeed.TabIndex = 31
        Me.ucrNudRandomSeed.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveColumn
        '
        Me.ucrSaveColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveColumn.Location = New System.Drawing.Point(9, 396)
        Me.ucrSaveColumn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        Me.ucrSaveColumn.Size = New System.Drawing.Size(292, 21)
        Me.ucrSaveColumn.TabIndex = 32
        '
        'cmdFilterFromFactors
        '
        Me.cmdFilterFromFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFilterFromFactors.Location = New System.Drawing.Point(133, 197)
        Me.cmdFilterFromFactors.Name = "cmdFilterFromFactors"
        Me.cmdFilterFromFactors.Size = New System.Drawing.Size(73, 33)
        Me.cmdFilterFromFactors.TabIndex = 33
        Me.cmdFilterFromFactors.Tag = "Define_New_Filter"
        Me.cmdFilterFromFactors.Text = "Include"
        Me.cmdFilterFromFactors.UseVisualStyleBackColor = True
        '
        'dlgOutfillingStationData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 493)
        Me.Controls.Add(Me.cmdFilterFromFactors)
        Me.Controls.Add(Me.ucrSaveColumn)
        Me.Controls.Add(Me.ucrNudRandomSeed)
        Me.Controls.Add(Me.ucrChkRandomSeed)
        Me.Controls.Add(Me.ucrChkStationToExclude)
        Me.Controls.Add(Me.ucrInputOmitMonths)
        Me.Controls.Add(Me.ucrChkOmitMonths)
        Me.Controls.Add(Me.lblMarkov)
        Me.Controls.Add(Me.lblDist)
        Me.Controls.Add(Me.ucrInputMarkov)
        Me.Controls.Add(Me.ucrInputDist)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents ucrChkOmitMonths As ucrCheck
    Friend WithEvents ucrInputOmitMonths As ucrInputComboBox
    Friend WithEvents ucrNudRandomSeed As ucrNud
    Friend WithEvents ucrChkRandomSeed As ucrCheck
    Friend WithEvents ucrChkStationToExclude As ucrCheck
    Friend WithEvents ucrSaveColumn As ucrSave
    Friend WithEvents cmdFilterFromFactors As Button
End Class
