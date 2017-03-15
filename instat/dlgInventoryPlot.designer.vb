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
        Me.lblDayOfyear = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.cmdInventoryPlotOptions = New System.Windows.Forms.Button()
        Me.rdoMultipleStationsMultipleElements = New System.Windows.Forms.RadioButton()
        Me.rdoMultipleStationsSingleElement = New System.Windows.Forms.RadioButton()
        Me.rdoSingleStationMultipleElments = New System.Windows.Forms.RadioButton()
        Me.rdoSingleStationSingleElement = New System.Windows.Forms.RadioButton()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrChkTitle = New instat.ucrCheck()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrpnlOptions = New instat.UcrPanel()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrChkShowNonMissing = New instat.ucrCheck()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrInventoryPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'lblDayOfyear
        '
        Me.lblDayOfyear.AutoSize = True
        Me.lblDayOfyear.Location = New System.Drawing.Point(289, 152)
        Me.lblDayOfyear.Name = "lblDayOfyear"
        Me.lblDayOfyear.Size = New System.Drawing.Size(0, 13)
        Me.lblDayOfyear.TabIndex = 19
        '
        'cmdOptions
        '
        Me.cmdOptions.Enabled = False
        Me.cmdOptions.Location = New System.Drawing.Point(10, 269)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 23
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(260, 119)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(50, 13)
        Me.lblElement.TabIndex = 37
        Me.lblElement.Text = "Elements"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(260, 75)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 38
        Me.lblDate.Text = "Date"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(260, 238)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(40, 13)
        Me.lblStation.TabIndex = 16
        Me.lblStation.Text = "Station"
        '
        'cmdInventoryPlotOptions
        '
        Me.cmdInventoryPlotOptions.Location = New System.Drawing.Point(10, 302)
        Me.cmdInventoryPlotOptions.Name = "cmdInventoryPlotOptions"
        Me.cmdInventoryPlotOptions.Size = New System.Drawing.Size(124, 23)
        Me.cmdInventoryPlotOptions.TabIndex = 40
        Me.cmdInventoryPlotOptions.Text = "Inventory Plot Options"
        Me.cmdInventoryPlotOptions.UseVisualStyleBackColor = True
        '
        'rdoMultipleStationsMultipleElements
        '
        Me.rdoMultipleStationsMultipleElements.AutoSize = True
        Me.rdoMultipleStationsMultipleElements.Location = New System.Drawing.Point(217, 41)
        Me.rdoMultipleStationsMultipleElements.Name = "rdoMultipleStationsMultipleElements"
        Me.rdoMultipleStationsMultipleElements.Size = New System.Drawing.Size(187, 17)
        Me.rdoMultipleStationsMultipleElements.TabIndex = 42
        Me.rdoMultipleStationsMultipleElements.TabStop = True
        Me.rdoMultipleStationsMultipleElements.Text = "Multiple Stations Multiple Elements"
        Me.rdoMultipleStationsMultipleElements.UseVisualStyleBackColor = True
        '
        'rdoMultipleStationsSingleElement
        '
        Me.rdoMultipleStationsSingleElement.AutoSize = True
        Me.rdoMultipleStationsSingleElement.Location = New System.Drawing.Point(217, 12)
        Me.rdoMultipleStationsSingleElement.Name = "rdoMultipleStationsSingleElement"
        Me.rdoMultipleStationsSingleElement.Size = New System.Drawing.Size(175, 17)
        Me.rdoMultipleStationsSingleElement.TabIndex = 43
        Me.rdoMultipleStationsSingleElement.TabStop = True
        Me.rdoMultipleStationsSingleElement.Text = "Multiple Stations Single Element"
        Me.rdoMultipleStationsSingleElement.UseVisualStyleBackColor = True
        '
        'rdoSingleStationMultipleElments
        '
        Me.rdoSingleStationMultipleElments.AutoSize = True
        Me.rdoSingleStationMultipleElments.Location = New System.Drawing.Point(11, 41)
        Me.rdoSingleStationMultipleElments.Name = "rdoSingleStationMultipleElments"
        Me.rdoSingleStationMultipleElments.Size = New System.Drawing.Size(169, 17)
        Me.rdoSingleStationMultipleElments.TabIndex = 44
        Me.rdoSingleStationMultipleElments.TabStop = True
        Me.rdoSingleStationMultipleElments.Text = "Single Station Multiple Elments"
        Me.rdoSingleStationMultipleElments.UseVisualStyleBackColor = True
        '
        'rdoSingleStationSingleElement
        '
        Me.rdoSingleStationSingleElement.AutoSize = True
        Me.rdoSingleStationSingleElement.Location = New System.Drawing.Point(11, 12)
        Me.rdoSingleStationSingleElement.Name = "rdoSingleStationSingleElement"
        Me.rdoSingleStationSingleElement.Size = New System.Drawing.Size(163, 17)
        Me.rdoSingleStationSingleElement.TabIndex = 45
        Me.rdoSingleStationSingleElement.TabStop = True
        Me.rdoSingleStationSingleElement.Text = "Single Station Single Element"
        Me.rdoSingleStationSingleElement.UseVisualStyleBackColor = True
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(101, 334)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTitle.TabIndex = 48
        '
        'ucrChkTitle
        '
        Me.ucrChkTitle.Checked = False
        Me.ucrChkTitle.Location = New System.Drawing.Point(10, 336)
        Me.ucrChkTitle.Name = "ucrChkTitle"
        Me.ucrChkTitle.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkTitle.TabIndex = 47
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(260, 132)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement.TabIndex = 46
        '
        'ucrpnlOptions
        '
        Me.ucrpnlOptions.Location = New System.Drawing.Point(10, 10)
        Me.ucrpnlOptions.Name = "ucrpnlOptions"
        Me.ucrpnlOptions.Size = New System.Drawing.Size(391, 58)
        Me.ucrpnlOptions.TabIndex = 41
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(260, 132)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverElements.TabIndex = 36
        '
        'ucrChkShowNonMissing
        '
        Me.ucrChkShowNonMissing.Checked = False
        Me.ucrChkShowNonMissing.Location = New System.Drawing.Point(260, 305)
        Me.ucrChkShowNonMissing.Name = "ucrChkShowNonMissing"
        Me.ucrChkShowNonMissing.Size = New System.Drawing.Size(120, 20)
        Me.ucrChkShowNonMissing.TabIndex = 34
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 361)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(277, 24)
        Me.ucrSaveGraph.TabIndex = 33
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.Checked = False
        Me.ucrChkFlipCoordinates.Location = New System.Drawing.Point(260, 282)
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        Me.ucrChkFlipCoordinates.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFlipCoordinates.TabIndex = 32
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(260, 252)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.TabIndex = 15
        '
        'ucrInventoryPlotSelector
        '
        Me.ucrInventoryPlotSelector.bShowHiddenColumns = False
        Me.ucrInventoryPlotSelector.bUseCurrentFilter = True
        Me.ucrInventoryPlotSelector.Location = New System.Drawing.Point(11, 75)
        Me.ucrInventoryPlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInventoryPlotSelector.Name = "ucrInventoryPlotSelector"
        Me.ucrInventoryPlotSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrInventoryPlotSelector.TabIndex = 13
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 394)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 12
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(260, 92)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.TabIndex = 49
        '
        'dlgInventoryPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 458)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrInputTitle)
        Me.Controls.Add(Me.ucrChkTitle)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.rdoMultipleStationsMultipleElements)
        Me.Controls.Add(Me.rdoMultipleStationsSingleElement)
        Me.Controls.Add(Me.rdoSingleStationMultipleElments)
        Me.Controls.Add(Me.rdoSingleStationSingleElement)
        Me.Controls.Add(Me.ucrpnlOptions)
        Me.Controls.Add(Me.cmdInventoryPlotOptions)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverElements)
        Me.Controls.Add(Me.ucrChkShowNonMissing)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblDayOfyear)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
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
    Friend WithEvents lblDayOfyear As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrChkShowNonMissing As ucrCheck
    Friend WithEvents lblDate As Label
    Friend WithEvents lblElement As Label
    Friend WithEvents ucrReceiverElements As ucrReceiverMultiple
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents cmdInventoryPlotOptions As Button
    Friend WithEvents ucrpnlOptions As UcrPanel
    Friend WithEvents rdoMultipleStationsMultipleElements As RadioButton
    Friend WithEvents rdoMultipleStationsSingleElement As RadioButton
    Friend WithEvents rdoSingleStationMultipleElments As RadioButton
    Friend WithEvents rdoSingleStationSingleElement As RadioButton
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents ucrChkTitle As ucrCheck
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
End Class
