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
        Me.ucrInputMarkov = New instat.ucrInputComboBox()
        Me.lblMarkov = New System.Windows.Forms.Label()
        Me.ucrChkOmitMonths = New instat.ucrCheck()
        Me.ucrInputOmitMonths = New instat.ucrInputComboBox()
        Me.ucrChkStationToExclude = New instat.ucrCheck()
        Me.ucrChkRandomSeed = New instat.ucrCheck()
        Me.ucrNudRandomSeed = New instat.ucrNud()
        Me.cmdFilterFromFactors = New System.Windows.Forms.Button()
        Me.ucrSaveResultEst = New instat.ucrSave()
        Me.ucrSaveResultGen = New instat.ucrSave()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 636)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(615, 87)
        Me.ucrBase.TabIndex = 27
        '
        'ucrSelectorOutfilling
        '
        Me.ucrSelectorOutfilling.AutoSize = True
        Me.ucrSelectorOutfilling.bDropUnusedFilterLevels = False
        Me.ucrSelectorOutfilling.bShowHiddenColumns = False
        Me.ucrSelectorOutfilling.bUseCurrentFilter = True
        Me.ucrSelectorOutfilling.Location = New System.Drawing.Point(9, 15)
        Me.ucrSelectorOutfilling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOutfilling.Name = "ucrSelectorOutfilling"
        Me.ucrSelectorOutfilling.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelectorOutfilling.TabIndex = 0
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(492, 60)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(180, 32)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.AutoSize = True
        Me.ucrReceiverRain.frmParent = Me
        Me.ucrReceiverRain.Location = New System.Drawing.Point(492, 340)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverRain.strNcFilePath = ""
        Me.ucrReceiverRain.TabIndex = 12
        Me.ucrReceiverRain.ucrSelector = Nothing
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.AutoSize = True
        Me.ucrReceiverLongitude.frmParent = Me
        Me.ucrReceiverLongitude.Location = New System.Drawing.Point(492, 272)
        Me.ucrReceiverLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.Size = New System.Drawing.Size(180, 32)
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.TabIndex = 10
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(492, 200)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(180, 35)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 8
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(492, 128)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 6
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverEstimates
        '
        Me.ucrReceiverEstimates.AutoSize = True
        Me.ucrReceiverEstimates.frmParent = Me
        Me.ucrReceiverEstimates.Location = New System.Drawing.Point(492, 411)
        Me.ucrReceiverEstimates.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEstimates.Name = "ucrReceiverEstimates"
        Me.ucrReceiverEstimates.Selector = Nothing
        Me.ucrReceiverEstimates.Size = New System.Drawing.Size(180, 34)
        Me.ucrReceiverEstimates.strNcFilePath = ""
        Me.ucrReceiverEstimates.TabIndex = 14
        Me.ucrReceiverEstimates.ucrSelector = Nothing
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(496, 32)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(64, 20)
        Me.lblStation.TabIndex = 1
        Me.lblStation.Text = "Station:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(496, 102)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Date:"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Location = New System.Drawing.Point(496, 174)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(71, 20)
        Me.lblLatitude.TabIndex = 7
        Me.lblLatitude.Text = "Latitude:"
        '
        'lblLong
        '
        Me.lblLong.AutoSize = True
        Me.lblLong.Location = New System.Drawing.Point(496, 245)
        Me.lblLong.Name = "lblLong"
        Me.lblLong.Size = New System.Drawing.Size(84, 20)
        Me.lblLong.TabIndex = 9
        Me.lblLong.Text = "Longitude:"
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(496, 314)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(46, 20)
        Me.lblRain.TabIndex = 11
        Me.lblRain.Text = "Rain:"
        '
        'lblEstimates
        '
        Me.lblEstimates.AutoSize = True
        Me.lblEstimates.Location = New System.Drawing.Point(496, 382)
        Me.lblEstimates.Name = "lblEstimates"
        Me.lblEstimates.Size = New System.Drawing.Size(84, 20)
        Me.lblEstimates.TabIndex = 13
        Me.lblEstimates.Text = "Estimates:"
        '
        'ucrInputMarkov
        '
        Me.ucrInputMarkov.AddQuotesIfUnrecognised = True
        Me.ucrInputMarkov.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMarkov.GetSetSelectedIndex = -1
        Me.ucrInputMarkov.IsReadOnly = False
        Me.ucrInputMarkov.Location = New System.Drawing.Point(77, 491)
        Me.ucrInputMarkov.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputMarkov.Name = "ucrInputMarkov"
        Me.ucrInputMarkov.Size = New System.Drawing.Size(116, 32)
        Me.ucrInputMarkov.TabIndex = 24
        '
        'lblMarkov
        '
        Me.lblMarkov.AutoSize = True
        Me.lblMarkov.Location = New System.Drawing.Point(5, 494)
        Me.lblMarkov.Name = "lblMarkov"
        Me.lblMarkov.Size = New System.Drawing.Size(64, 20)
        Me.lblMarkov.TabIndex = 23
        Me.lblMarkov.Text = "Markov:"
        '
        'ucrChkOmitMonths
        '
        Me.ucrChkOmitMonths.AutoSize = True
        Me.ucrChkOmitMonths.Checked = False
        Me.ucrChkOmitMonths.Location = New System.Drawing.Point(9, 377)
        Me.ucrChkOmitMonths.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkOmitMonths.Name = "ucrChkOmitMonths"
        Me.ucrChkOmitMonths.Size = New System.Drawing.Size(171, 35)
        Me.ucrChkOmitMonths.TabIndex = 25
        '
        'ucrInputOmitMonths
        '
        Me.ucrInputOmitMonths.AddQuotesIfUnrecognised = True
        Me.ucrInputOmitMonths.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputOmitMonths.GetSetSelectedIndex = -1
        Me.ucrInputOmitMonths.IsReadOnly = False
        Me.ucrInputOmitMonths.Location = New System.Drawing.Point(200, 375)
        Me.ucrInputOmitMonths.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputOmitMonths.Name = "ucrInputOmitMonths"
        Me.ucrInputOmitMonths.Size = New System.Drawing.Size(171, 32)
        Me.ucrInputOmitMonths.TabIndex = 28
        '
        'ucrChkStationToExclude
        '
        Me.ucrChkStationToExclude.AutoSize = True
        Me.ucrChkStationToExclude.Checked = False
        Me.ucrChkStationToExclude.Location = New System.Drawing.Point(9, 311)
        Me.ucrChkStationToExclude.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkStationToExclude.Name = "ucrChkStationToExclude"
        Me.ucrChkStationToExclude.Size = New System.Drawing.Size(188, 35)
        Me.ucrChkStationToExclude.TabIndex = 29
        '
        'ucrChkRandomSeed
        '
        Me.ucrChkRandomSeed.AutoSize = True
        Me.ucrChkRandomSeed.Checked = False
        Me.ucrChkRandomSeed.Location = New System.Drawing.Point(9, 434)
        Me.ucrChkRandomSeed.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkRandomSeed.Name = "ucrChkRandomSeed"
        Me.ucrChkRandomSeed.Size = New System.Drawing.Size(176, 35)
        Me.ucrChkRandomSeed.TabIndex = 30
        '
        'ucrNudRandomSeed
        '
        Me.ucrNudRandomSeed.AutoSize = True
        Me.ucrNudRandomSeed.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRandomSeed.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRandomSeed.Location = New System.Drawing.Point(200, 437)
        Me.ucrNudRandomSeed.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudRandomSeed.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRandomSeed.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRandomSeed.Name = "ucrNudRandomSeed"
        Me.ucrNudRandomSeed.Size = New System.Drawing.Size(117, 42)
        Me.ucrNudRandomSeed.TabIndex = 31
        Me.ucrNudRandomSeed.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmdFilterFromFactors
        '
        Me.cmdFilterFromFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFilterFromFactors.Location = New System.Drawing.Point(200, 303)
        Me.cmdFilterFromFactors.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdFilterFromFactors.Name = "cmdFilterFromFactors"
        Me.cmdFilterFromFactors.Size = New System.Drawing.Size(110, 51)
        Me.cmdFilterFromFactors.TabIndex = 33
        Me.cmdFilterFromFactors.Tag = "Define_New_Filter"
        Me.cmdFilterFromFactors.Text = "Include"
        Me.cmdFilterFromFactors.UseVisualStyleBackColor = True
        '
        'ucrSaveResultEst
        '
        Me.ucrSaveResultEst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveResultEst.Location = New System.Drawing.Point(9, 540)
        Me.ucrSaveResultEst.Margin = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.ucrSaveResultEst.Name = "ucrSaveResultEst"
        Me.ucrSaveResultEst.Size = New System.Drawing.Size(489, 34)
        Me.ucrSaveResultEst.TabIndex = 197
        '
        'ucrSaveResultGen
        '
        Me.ucrSaveResultGen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveResultGen.Location = New System.Drawing.Point(9, 593)
        Me.ucrSaveResultGen.Margin = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.ucrSaveResultGen.Name = "ucrSaveResultGen"
        Me.ucrSaveResultGen.Size = New System.Drawing.Size(489, 34)
        Me.ucrSaveResultGen.TabIndex = 198
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(492, 464)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(164, 51)
        Me.cmdOptions.TabIndex = 199
        Me.cmdOptions.Tag = "Define_New_Filter"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'dlgOutfillingStationData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 740)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrSaveResultGen)
        Me.Controls.Add(Me.ucrSaveResultEst)
        Me.Controls.Add(Me.cmdFilterFromFactors)
        Me.Controls.Add(Me.ucrNudRandomSeed)
        Me.Controls.Add(Me.ucrChkRandomSeed)
        Me.Controls.Add(Me.ucrChkStationToExclude)
        Me.Controls.Add(Me.ucrInputOmitMonths)
        Me.Controls.Add(Me.ucrChkOmitMonths)
        Me.Controls.Add(Me.lblMarkov)
        Me.Controls.Add(Me.ucrInputMarkov)
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
    Friend WithEvents lblMarkov As Label
    Friend WithEvents ucrInputMarkov As ucrInputComboBox
    Friend WithEvents ucrChkOmitMonths As ucrCheck
    Friend WithEvents ucrInputOmitMonths As ucrInputComboBox
    Friend WithEvents ucrNudRandomSeed As ucrNud
    Friend WithEvents ucrChkRandomSeed As ucrCheck
    Friend WithEvents ucrChkStationToExclude As ucrCheck
    Friend WithEvents cmdFilterFromFactors As Button
    Friend WithEvents ucrSaveResultGen As ucrSave
    Friend WithEvents ucrSaveResultEst As ucrSave
    Friend WithEvents cmdOptions As Button
End Class
