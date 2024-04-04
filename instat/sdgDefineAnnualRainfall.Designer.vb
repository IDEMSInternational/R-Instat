<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgDefineAnnualRainfall
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
        Me.ucrBaseSdg = New instat.ucrButtonsSubdialogue()
        Me.ucrSelectorDefineAnnualRain = New instat.ucrSelectorByDataFrame()
        Me.ucrReceiverAnnualRain = New instat.ucrReceiverSingle()
        Me.ucrReceiverSeasonalRain = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainDaysSeason = New instat.ucrReceiverSingle()
        Me.ucrReceiverSeasonalLength = New instat.ucrReceiverSingle()
        Me.ucrReceiverEndRainsDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverEndRainsDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverEndSeasonDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverEndSeasonDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverStartRainDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverStartRainDate = New instat.ucrReceiverSingle()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblStartRainDOY = New System.Windows.Forms.Label()
        Me.lblStartRainDate = New System.Windows.Forms.Label()
        Me.lblEndRainsDOY = New System.Windows.Forms.Label()
        Me.lblEndRainDate = New System.Windows.Forms.Label()
        Me.lblEndSeasonDOY = New System.Windows.Forms.Label()
        Me.lblEndSeasonDate = New System.Windows.Forms.Label()
        Me.lblAnnualRain = New System.Windows.Forms.Label()
        Me.lblSeasonalRain = New System.Windows.Forms.Label()
        Me.lblSeasonalLength = New System.Windows.Forms.Label()
        Me.lblNoRainDaysSeason = New System.Windows.Forms.Label()
        Me.ucrReceiverRainDaysYear = New instat.ucrReceiverSingle()
        Me.lblRainyDaysYear = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBaseSdg
        '
        Me.ucrBaseSdg.AutoSize = True
        Me.ucrBaseSdg.Location = New System.Drawing.Point(18, 406)
        Me.ucrBaseSdg.Name = "ucrBaseSdg"
        Me.ucrBaseSdg.Size = New System.Drawing.Size(224, 35)
        Me.ucrBaseSdg.TabIndex = 1
        '
        'ucrSelectorDefineAnnualRain
        '
        Me.ucrSelectorDefineAnnualRain.AutoSize = True
        Me.ucrSelectorDefineAnnualRain.bDropUnusedFilterLevels = False
        Me.ucrSelectorDefineAnnualRain.bShowHiddenColumns = False
        Me.ucrSelectorDefineAnnualRain.bUseCurrentFilter = True
        Me.ucrSelectorDefineAnnualRain.Location = New System.Drawing.Point(7, 23)
        Me.ucrSelectorDefineAnnualRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDefineAnnualRain.Name = "ucrSelectorDefineAnnualRain"
        Me.ucrSelectorDefineAnnualRain.Size = New System.Drawing.Size(151, 185)
        Me.ucrSelectorDefineAnnualRain.TabIndex = 2
        '
        'ucrReceiverAnnualRain
        '
        Me.ucrReceiverAnnualRain.AutoSize = True
        Me.ucrReceiverAnnualRain.frmParent = Me
        Me.ucrReceiverAnnualRain.Location = New System.Drawing.Point(242, 43)
        Me.ucrReceiverAnnualRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAnnualRain.Name = "ucrReceiverAnnualRain"
        Me.ucrReceiverAnnualRain.Selector = Nothing
        Me.ucrReceiverAnnualRain.Size = New System.Drawing.Size(120, 25)
        Me.ucrReceiverAnnualRain.strNcFilePath = ""
        Me.ucrReceiverAnnualRain.TabIndex = 3
        Me.ucrReceiverAnnualRain.ucrSelector = Nothing
        '
        'ucrReceiverSeasonalRain
        '
        Me.ucrReceiverSeasonalRain.AutoSize = True
        Me.ucrReceiverSeasonalRain.frmParent = Me
        Me.ucrReceiverSeasonalRain.Location = New System.Drawing.Point(243, 86)
        Me.ucrReceiverSeasonalRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSeasonalRain.Name = "ucrReceiverSeasonalRain"
        Me.ucrReceiverSeasonalRain.Selector = Nothing
        Me.ucrReceiverSeasonalRain.Size = New System.Drawing.Size(120, 25)
        Me.ucrReceiverSeasonalRain.strNcFilePath = ""
        Me.ucrReceiverSeasonalRain.TabIndex = 4
        Me.ucrReceiverSeasonalRain.ucrSelector = Nothing
        '
        'ucrReceiverRainDaysSeason
        '
        Me.ucrReceiverRainDaysSeason.AutoSize = True
        Me.ucrReceiverRainDaysSeason.frmParent = Me
        Me.ucrReceiverRainDaysSeason.Location = New System.Drawing.Point(244, 129)
        Me.ucrReceiverRainDaysSeason.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainDaysSeason.Name = "ucrReceiverRainDaysSeason"
        Me.ucrReceiverRainDaysSeason.Selector = Nothing
        Me.ucrReceiverRainDaysSeason.Size = New System.Drawing.Size(120, 25)
        Me.ucrReceiverRainDaysSeason.strNcFilePath = ""
        Me.ucrReceiverRainDaysSeason.TabIndex = 5
        Me.ucrReceiverRainDaysSeason.ucrSelector = Nothing
        '
        'ucrReceiverSeasonalLength
        '
        Me.ucrReceiverSeasonalLength.AutoSize = True
        Me.ucrReceiverSeasonalLength.frmParent = Me
        Me.ucrReceiverSeasonalLength.Location = New System.Drawing.Point(245, 209)
        Me.ucrReceiverSeasonalLength.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSeasonalLength.Name = "ucrReceiverSeasonalLength"
        Me.ucrReceiverSeasonalLength.Selector = Nothing
        Me.ucrReceiverSeasonalLength.Size = New System.Drawing.Size(120, 25)
        Me.ucrReceiverSeasonalLength.strNcFilePath = ""
        Me.ucrReceiverSeasonalLength.TabIndex = 6
        Me.ucrReceiverSeasonalLength.ucrSelector = Nothing
        '
        'ucrReceiverEndRainsDate
        '
        Me.ucrReceiverEndRainsDate.AutoSize = True
        Me.ucrReceiverEndRainsDate.frmParent = Me
        Me.ucrReceiverEndRainsDate.Location = New System.Drawing.Point(247, 288)
        Me.ucrReceiverEndRainsDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEndRainsDate.Name = "ucrReceiverEndRainsDate"
        Me.ucrReceiverEndRainsDate.Selector = Nothing
        Me.ucrReceiverEndRainsDate.Size = New System.Drawing.Size(120, 25)
        Me.ucrReceiverEndRainsDate.strNcFilePath = ""
        Me.ucrReceiverEndRainsDate.TabIndex = 7
        Me.ucrReceiverEndRainsDate.ucrSelector = Nothing
        '
        'ucrReceiverEndRainsDOY
        '
        Me.ucrReceiverEndRainsDOY.AutoSize = True
        Me.ucrReceiverEndRainsDOY.frmParent = Me
        Me.ucrReceiverEndRainsDOY.Location = New System.Drawing.Point(249, 248)
        Me.ucrReceiverEndRainsDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEndRainsDOY.Name = "ucrReceiverEndRainsDOY"
        Me.ucrReceiverEndRainsDOY.Selector = Nothing
        Me.ucrReceiverEndRainsDOY.Size = New System.Drawing.Size(120, 25)
        Me.ucrReceiverEndRainsDOY.strNcFilePath = ""
        Me.ucrReceiverEndRainsDOY.TabIndex = 8
        Me.ucrReceiverEndRainsDOY.ucrSelector = Nothing
        '
        'ucrReceiverEndSeasonDOY
        '
        Me.ucrReceiverEndSeasonDOY.AutoSize = True
        Me.ucrReceiverEndSeasonDOY.frmParent = Me
        Me.ucrReceiverEndSeasonDOY.Location = New System.Drawing.Point(250, 325)
        Me.ucrReceiverEndSeasonDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEndSeasonDOY.Name = "ucrReceiverEndSeasonDOY"
        Me.ucrReceiverEndSeasonDOY.Selector = Nothing
        Me.ucrReceiverEndSeasonDOY.Size = New System.Drawing.Size(120, 25)
        Me.ucrReceiverEndSeasonDOY.strNcFilePath = ""
        Me.ucrReceiverEndSeasonDOY.TabIndex = 9
        Me.ucrReceiverEndSeasonDOY.ucrSelector = Nothing
        '
        'ucrReceiverEndSeasonDate
        '
        Me.ucrReceiverEndSeasonDate.AutoSize = True
        Me.ucrReceiverEndSeasonDate.frmParent = Me
        Me.ucrReceiverEndSeasonDate.Location = New System.Drawing.Point(246, 363)
        Me.ucrReceiverEndSeasonDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEndSeasonDate.Name = "ucrReceiverEndSeasonDate"
        Me.ucrReceiverEndSeasonDate.Selector = Nothing
        Me.ucrReceiverEndSeasonDate.Size = New System.Drawing.Size(120, 25)
        Me.ucrReceiverEndSeasonDate.strNcFilePath = ""
        Me.ucrReceiverEndSeasonDate.TabIndex = 10
        Me.ucrReceiverEndSeasonDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(11, 230)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 25)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 11
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(9, 273)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 25)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 12
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverStartRainDOY
        '
        Me.ucrReceiverStartRainDOY.AutoSize = True
        Me.ucrReceiverStartRainDOY.frmParent = Me
        Me.ucrReceiverStartRainDOY.Location = New System.Drawing.Point(9, 317)
        Me.ucrReceiverStartRainDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStartRainDOY.Name = "ucrReceiverStartRainDOY"
        Me.ucrReceiverStartRainDOY.Selector = Nothing
        Me.ucrReceiverStartRainDOY.Size = New System.Drawing.Size(120, 25)
        Me.ucrReceiverStartRainDOY.strNcFilePath = ""
        Me.ucrReceiverStartRainDOY.TabIndex = 13
        Me.ucrReceiverStartRainDOY.ucrSelector = Nothing
        '
        'ucrReceiverStartRainDate
        '
        Me.ucrReceiverStartRainDate.AutoSize = True
        Me.ucrReceiverStartRainDate.frmParent = Me
        Me.ucrReceiverStartRainDate.Location = New System.Drawing.Point(9, 359)
        Me.ucrReceiverStartRainDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStartRainDate.Name = "ucrReceiverStartRainDate"
        Me.ucrReceiverStartRainDate.Selector = Nothing
        Me.ucrReceiverStartRainDate.Size = New System.Drawing.Size(120, 25)
        Me.ucrReceiverStartRainDate.strNcFilePath = ""
        Me.ucrReceiverStartRainDate.TabIndex = 14
        Me.ucrReceiverStartRainDate.ucrSelector = Nothing
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(15, 213)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 15
        Me.lblStation.Text = "Station:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(14, 254)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 16
        Me.lblYear.Text = "Year:"
        '
        'lblStartRainDOY
        '
        Me.lblStartRainDOY.AutoSize = True
        Me.lblStartRainDOY.Location = New System.Drawing.Point(12, 300)
        Me.lblStartRainDOY.Name = "lblStartRainDOY"
        Me.lblStartRainDOY.Size = New System.Drawing.Size(86, 13)
        Me.lblStartRainDOY.TabIndex = 17
        Me.lblStartRainDOY.Text = "Start Rain(DOY):"
        '
        'lblStartRainDate
        '
        Me.lblStartRainDate.AutoSize = True
        Me.lblStartRainDate.Location = New System.Drawing.Point(11, 341)
        Me.lblStartRainDate.Name = "lblStartRainDate"
        Me.lblStartRainDate.Size = New System.Drawing.Size(86, 13)
        Me.lblStartRainDate.TabIndex = 18
        Me.lblStartRainDate.Text = "Start Rain(Date):"
        '
        'lblEndRainsDOY
        '
        Me.lblEndRainsDOY.AutoSize = True
        Me.lblEndRainsDOY.Location = New System.Drawing.Point(250, 231)
        Me.lblEndRainsDOY.Name = "lblEndRainsDOY"
        Me.lblEndRainsDOY.Size = New System.Drawing.Size(83, 13)
        Me.lblEndRainsDOY.TabIndex = 19
        Me.lblEndRainsDOY.Text = "End Rain(DOY):"
        '
        'lblEndRainDate
        '
        Me.lblEndRainDate.AutoSize = True
        Me.lblEndRainDate.Location = New System.Drawing.Point(250, 270)
        Me.lblEndRainDate.Name = "lblEndRainDate"
        Me.lblEndRainDate.Size = New System.Drawing.Size(83, 13)
        Me.lblEndRainDate.TabIndex = 20
        Me.lblEndRainDate.Text = "End Rain(Date):"
        '
        'lblEndSeasonDOY
        '
        Me.lblEndSeasonDOY.AutoSize = True
        Me.lblEndSeasonDOY.Location = New System.Drawing.Point(251, 312)
        Me.lblEndSeasonDOY.Name = "lblEndSeasonDOY"
        Me.lblEndSeasonDOY.Size = New System.Drawing.Size(97, 13)
        Me.lblEndSeasonDOY.TabIndex = 21
        Me.lblEndSeasonDOY.Text = "End Season(DOY):"
        '
        'lblEndSeasonDate
        '
        Me.lblEndSeasonDate.AutoSize = True
        Me.lblEndSeasonDate.Location = New System.Drawing.Point(250, 346)
        Me.lblEndSeasonDate.Name = "lblEndSeasonDate"
        Me.lblEndSeasonDate.Size = New System.Drawing.Size(97, 13)
        Me.lblEndSeasonDate.TabIndex = 22
        Me.lblEndSeasonDate.Text = "End Season(Date):"
        '
        'lblAnnualRain
        '
        Me.lblAnnualRain.AutoSize = True
        Me.lblAnnualRain.Location = New System.Drawing.Point(244, 26)
        Me.lblAnnualRain.Name = "lblAnnualRain"
        Me.lblAnnualRain.Size = New System.Drawing.Size(68, 13)
        Me.lblAnnualRain.TabIndex = 23
        Me.lblAnnualRain.Text = "Annual Rain:"
        '
        'lblSeasonalRain
        '
        Me.lblSeasonalRain.AutoSize = True
        Me.lblSeasonalRain.Location = New System.Drawing.Point(245, 69)
        Me.lblSeasonalRain.Name = "lblSeasonalRain"
        Me.lblSeasonalRain.Size = New System.Drawing.Size(79, 13)
        Me.lblSeasonalRain.TabIndex = 24
        Me.lblSeasonalRain.Text = "Seasonal Rain:"
        '
        'lblSeasonalLength
        '
        Me.lblSeasonalLength.AutoSize = True
        Me.lblSeasonalLength.Location = New System.Drawing.Point(247, 191)
        Me.lblSeasonalLength.Name = "lblSeasonalLength"
        Me.lblSeasonalLength.Size = New System.Drawing.Size(90, 13)
        Me.lblSeasonalLength.TabIndex = 25
        Me.lblSeasonalLength.Text = "Seasonal Length:"
        '
        'lblNoRainDaysSeason
        '
        Me.lblNoRainDaysSeason.AutoSize = True
        Me.lblNoRainDaysSeason.Location = New System.Drawing.Point(241, 110)
        Me.lblNoRainDaysSeason.Name = "lblNoRainDaysSeason"
        Me.lblNoRainDaysSeason.Size = New System.Drawing.Size(117, 13)
        Me.lblNoRainDaysSeason.TabIndex = 26
        Me.lblNoRainDaysSeason.Text = " Rainy Days in Season:"
        '
        'ucrReceiverRainDaysYear
        '
        Me.ucrReceiverRainDaysYear.AutoSize = True
        Me.ucrReceiverRainDaysYear.frmParent = Me
        Me.ucrReceiverRainDaysYear.Location = New System.Drawing.Point(246, 168)
        Me.ucrReceiverRainDaysYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainDaysYear.Name = "ucrReceiverRainDaysYear"
        Me.ucrReceiverRainDaysYear.Selector = Nothing
        Me.ucrReceiverRainDaysYear.Size = New System.Drawing.Size(120, 25)
        Me.ucrReceiverRainDaysYear.strNcFilePath = ""
        Me.ucrReceiverRainDaysYear.TabIndex = 27
        Me.ucrReceiverRainDaysYear.ucrSelector = Nothing
        '
        'lblRainyDaysYear
        '
        Me.lblRainyDaysYear.AutoSize = True
        Me.lblRainyDaysYear.Location = New System.Drawing.Point(248, 152)
        Me.lblRainyDaysYear.Name = "lblRainyDaysYear"
        Me.lblRainyDaysYear.Size = New System.Drawing.Size(103, 13)
        Me.lblRainyDaysYear.TabIndex = 28
        Me.lblRainyDaysYear.Text = " Rainy Days in Year:"
        '
        'sdgDefineAnnualRainfall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 438)
        Me.Controls.Add(Me.lblRainyDaysYear)
        Me.Controls.Add(Me.ucrReceiverRainDaysYear)
        Me.Controls.Add(Me.lblNoRainDaysSeason)
        Me.Controls.Add(Me.lblSeasonalLength)
        Me.Controls.Add(Me.lblSeasonalRain)
        Me.Controls.Add(Me.lblAnnualRain)
        Me.Controls.Add(Me.lblEndSeasonDate)
        Me.Controls.Add(Me.lblEndSeasonDOY)
        Me.Controls.Add(Me.lblEndRainDate)
        Me.Controls.Add(Me.lblEndRainsDOY)
        Me.Controls.Add(Me.lblStartRainDate)
        Me.Controls.Add(Me.lblStartRainDOY)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStartRainDate)
        Me.Controls.Add(Me.ucrReceiverStartRainDOY)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverEndSeasonDate)
        Me.Controls.Add(Me.ucrReceiverEndSeasonDOY)
        Me.Controls.Add(Me.ucrReceiverEndRainsDOY)
        Me.Controls.Add(Me.ucrReceiverEndRainsDate)
        Me.Controls.Add(Me.ucrReceiverSeasonalLength)
        Me.Controls.Add(Me.ucrReceiverRainDaysSeason)
        Me.Controls.Add(Me.ucrReceiverSeasonalRain)
        Me.Controls.Add(Me.ucrReceiverAnnualRain)
        Me.Controls.Add(Me.ucrSelectorDefineAnnualRain)
        Me.Controls.Add(Me.ucrBaseSdg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDefineAnnualRainfall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Define Annual Rainfall"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSdg As ucrButtonsSubdialogue
    Friend WithEvents ucrSelectorDefineAnnualRain As ucrSelectorByDataFrame
    Friend WithEvents ucrReceiverAnnualRain As ucrReceiverSingle
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
End Class
