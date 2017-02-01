<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgInventoryPlot
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
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDayOfyear = New System.Windows.Forms.Label()
        Me.lblColourBand = New System.Windows.Forms.Label()
        Me.lblDoY = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblFacet = New System.Windows.Forms.Label()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.ucrChkAddRecodetoData = New instat.ucrCheck()
        Me.ucrNudThreashold = New instat.ucrNud()
        Me.ucrFacetsReceiver = New instat.ucrReceiverSingle()
        Me.ucrColourReceiver = New instat.ucrReceiverSingle()
        Me.ucrDayOfYearReceiver = New instat.ucrReceiverSingle()
        Me.ucrYearReceiver = New instat.ucrReceiverSingle()
        Me.ucrInventoryPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(289, 10)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 16
        Me.lblYear.Text = "Year"
        '
        'lblDayOfyear
        '
        Me.lblDayOfyear.AutoSize = True
        Me.lblDayOfyear.Location = New System.Drawing.Point(289, 90)
        Me.lblDayOfyear.Name = "lblDayOfyear"
        Me.lblDayOfyear.Size = New System.Drawing.Size(0, 13)
        Me.lblDayOfyear.TabIndex = 19
        '
        'lblColourBand
        '
        Me.lblColourBand.AutoSize = True
        Me.lblColourBand.Location = New System.Drawing.Point(289, 113)
        Me.lblColourBand.Name = "lblColourBand"
        Me.lblColourBand.Size = New System.Drawing.Size(29, 13)
        Me.lblColourBand.TabIndex = 20
        Me.lblColourBand.Text = "Rain"
        '
        'lblDoY
        '
        Me.lblDoY.AutoSize = True
        Me.lblDoY.Location = New System.Drawing.Point(289, 59)
        Me.lblDoY.Name = "lblDoY"
        Me.lblDoY.Size = New System.Drawing.Size(81, 13)
        Me.lblDoY.TabIndex = 22
        Me.lblDoY.Text = "Day of the Year"
        '
        'cmdOptions
        '
        Me.cmdOptions.Enabled = False
        Me.cmdOptions.Location = New System.Drawing.Point(12, 204)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 23
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(292, 165)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(54, 13)
        Me.lblThreshold.TabIndex = 27
        Me.lblThreshold.Text = "Threshold"
        '
        'lblFacet
        '
        Me.lblFacet.AutoSize = True
        Me.lblFacet.Location = New System.Drawing.Point(295, 189)
        Me.lblFacet.Name = "lblFacet"
        Me.lblFacet.Size = New System.Drawing.Size(49, 13)
        Me.lblFacet.TabIndex = 29
        Me.lblFacet.Text = "Facet By"
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(12, 253)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(277, 24)
        Me.ucrSaveGraph.TabIndex = 33
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.Checked = False
        Me.ucrChkFlipCoordinates.Location = New System.Drawing.Point(292, 263)
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        Me.ucrChkFlipCoordinates.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFlipCoordinates.TabIndex = 32
        '
        'ucrChkAddRecodetoData
        '
        Me.ucrChkAddRecodetoData.Checked = False
        Me.ucrChkAddRecodetoData.Location = New System.Drawing.Point(292, 237)
        Me.ucrChkAddRecodetoData.Name = "ucrChkAddRecodetoData"
        Me.ucrChkAddRecodetoData.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkAddRecodetoData.TabIndex = 31
        '
        'ucrNudThreashold
        '
        Me.ucrNudThreashold.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreashold.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThreashold.Location = New System.Drawing.Point(362, 165)
        Me.ucrNudThreashold.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThreashold.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreashold.Name = "ucrNudThreashold"
        Me.ucrNudThreashold.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThreashold.TabIndex = 30
        Me.ucrNudThreashold.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrFacetsReceiver
        '
        Me.ucrFacetsReceiver.frmParent = Me
        Me.ucrFacetsReceiver.Location = New System.Drawing.Point(292, 204)
        Me.ucrFacetsReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFacetsReceiver.Name = "ucrFacetsReceiver"
        Me.ucrFacetsReceiver.Selector = Nothing
        Me.ucrFacetsReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFacetsReceiver.TabIndex = 28
        '
        'ucrColourReceiver
        '
        Me.ucrColourReceiver.frmParent = Me
        Me.ucrColourReceiver.Location = New System.Drawing.Point(292, 135)
        Me.ucrColourReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrColourReceiver.Name = "ucrColourReceiver"
        Me.ucrColourReceiver.Selector = Nothing
        Me.ucrColourReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrColourReceiver.TabIndex = 18
        '
        'ucrDayOfYearReceiver
        '
        Me.ucrDayOfYearReceiver.frmParent = Me
        Me.ucrDayOfYearReceiver.Location = New System.Drawing.Point(292, 82)
        Me.ucrDayOfYearReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDayOfYearReceiver.Name = "ucrDayOfYearReceiver"
        Me.ucrDayOfYearReceiver.Selector = Nothing
        Me.ucrDayOfYearReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrDayOfYearReceiver.TabIndex = 17
        '
        'ucrYearReceiver
        '
        Me.ucrYearReceiver.frmParent = Me
        Me.ucrYearReceiver.Location = New System.Drawing.Point(292, 32)
        Me.ucrYearReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrYearReceiver.Name = "ucrYearReceiver"
        Me.ucrYearReceiver.Selector = Nothing
        Me.ucrYearReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrYearReceiver.TabIndex = 15
        '
        'ucrInventoryPlotSelector
        '
        Me.ucrInventoryPlotSelector.bShowHiddenColumns = False
        Me.ucrInventoryPlotSelector.bUseCurrentFilter = True
        Me.ucrInventoryPlotSelector.Location = New System.Drawing.Point(9, 9)
        Me.ucrInventoryPlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInventoryPlotSelector.Name = "ucrInventoryPlotSelector"
        Me.ucrInventoryPlotSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrInventoryPlotSelector.TabIndex = 13
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 283)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 12
        '
        'dlgInventoryPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 337)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.Controls.Add(Me.ucrChkAddRecodetoData)
        Me.Controls.Add(Me.ucrNudThreashold)
        Me.Controls.Add(Me.lblFacet)
        Me.Controls.Add(Me.ucrFacetsReceiver)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblDoY)
        Me.Controls.Add(Me.lblColourBand)
        Me.Controls.Add(Me.lblDayOfyear)
        Me.Controls.Add(Me.ucrColourReceiver)
        Me.Controls.Add(Me.ucrDayOfYearReceiver)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.ucrYearReceiver)
        Me.Controls.Add(Me.ucrInventoryPlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInventoryPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Inventory_Plot"
        Me.Text = "Inventory Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInventoryPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrYearReceiver As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrDayOfYearReceiver As ucrReceiverSingle
    Friend WithEvents ucrColourReceiver As ucrReceiverSingle
    Friend WithEvents lblDayOfyear As Label
    Friend WithEvents lblColourBand As Label
    Friend WithEvents lblDoY As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents lblThreshold As Label
    Friend WithEvents ucrFacetsReceiver As ucrReceiverSingle
    Friend WithEvents lblFacet As Label
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents ucrChkAddRecodetoData As ucrCheck
    Friend WithEvents ucrNudThreashold As ucrNud
    Friend WithEvents ucrSaveGraph As ucrSave
End Class
