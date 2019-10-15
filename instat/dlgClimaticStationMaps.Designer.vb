<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticStationMaps
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
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.cmdMapOptions = New System.Windows.Forms.Button()
        Me.cmdSFOptions = New System.Windows.Forms.Button()
        Me.grpPoints = New System.Windows.Forms.GroupBox()
        Me.lblLabels = New System.Windows.Forms.Label()
        Me.lblFacet = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.lbllatitude = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.grpMapOutline = New System.Windows.Forms.GroupBox()
        Me.ldlGeometry = New System.Windows.Forms.Label()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.ucrChkAddPoints = New instat.ucrCheck()
        Me.ucrReceiverGeometry = New instat.ucrReceiverSingle()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
        Me.ucrSelectorOutline = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverFacet = New instat.ucrReceiverSingle()
        Me.ucrSelectorStation = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverColor = New instat.ucrReceiverSingle()
        Me.ucrReceiverShape = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.ucrSaveMap = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpPoints.SuspendLayout()
        Me.grpMapOutline.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.Location = New System.Drawing.Point(10, 321)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(103, 23)
        Me.cmdPlotOptions.TabIndex = 12
        Me.cmdPlotOptions.Text = "Plot Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdMapOptions
        '
        Me.cmdMapOptions.Location = New System.Drawing.Point(10, 292)
        Me.cmdMapOptions.Name = "cmdMapOptions"
        Me.cmdMapOptions.Size = New System.Drawing.Size(103, 23)
        Me.cmdMapOptions.TabIndex = 14
        Me.cmdMapOptions.Text = "Map Options"
        Me.cmdMapOptions.UseVisualStyleBackColor = True
        '
        'cmdSFOptions
        '
        Me.cmdSFOptions.Location = New System.Drawing.Point(10, 264)
        Me.cmdSFOptions.Name = "cmdSFOptions"
        Me.cmdSFOptions.Size = New System.Drawing.Size(103, 23)
        Me.cmdSFOptions.TabIndex = 13
        Me.cmdSFOptions.Text = "SF Options"
        Me.cmdSFOptions.UseVisualStyleBackColor = True
        '
        'grpPoints
        '
        Me.grpPoints.Controls.Add(Me.lblLabels)
        Me.grpPoints.Controls.Add(Me.ucrReceiverStation)
        Me.grpPoints.Controls.Add(Me.lblFacet)
        Me.grpPoints.Controls.Add(Me.ucrReceiverFacet)
        Me.grpPoints.Controls.Add(Me.ucrSelectorStation)
        Me.grpPoints.Controls.Add(Me.lblColor)
        Me.grpPoints.Controls.Add(Me.lblShape)
        Me.grpPoints.Controls.Add(Me.lbllatitude)
        Me.grpPoints.Controls.Add(Me.ucrReceiverColor)
        Me.grpPoints.Controls.Add(Me.lblLongitude)
        Me.grpPoints.Controls.Add(Me.ucrReceiverShape)
        Me.grpPoints.Controls.Add(Me.ucrReceiverLatitude)
        Me.grpPoints.Controls.Add(Me.ucrReceiverLongitude)
        Me.grpPoints.Location = New System.Drawing.Point(373, 8)
        Me.grpPoints.Name = "grpPoints"
        Me.grpPoints.Size = New System.Drawing.Size(371, 292)
        Me.grpPoints.TabIndex = 21
        Me.grpPoints.TabStop = False
        Me.grpPoints.Text = "Points"
        '
        'lblLabels
        '
        Me.lblLabels.AutoSize = True
        Me.lblLabels.Location = New System.Drawing.Point(237, 101)
        Me.lblLabels.Name = "lblLabels"
        Me.lblLabels.Size = New System.Drawing.Size(89, 13)
        Me.lblLabels.TabIndex = 33
        Me.lblLabels.Text = "Labels (Optional):"
        '
        'lblFacet
        '
        Me.lblFacet.AutoSize = True
        Me.lblFacet.Location = New System.Drawing.Point(240, 235)
        Me.lblFacet.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFacet.Name = "lblFacet"
        Me.lblFacet.Size = New System.Drawing.Size(42, 13)
        Me.lblFacet.TabIndex = 31
        Me.lblFacet.Text = "Facets:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(238, 190)
        Me.lblColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(82, 13)
        Me.lblColor.TabIndex = 28
        Me.lblColor.Text = "Color (Optional):"
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.Location = New System.Drawing.Point(237, 147)
        Me.lblShape.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(89, 13)
        Me.lblShape.TabIndex = 26
        Me.lblShape.Text = "Shape (Optional):"
        '
        'lbllatitude
        '
        Me.lbllatitude.AutoSize = True
        Me.lbllatitude.Location = New System.Drawing.Point(237, 55)
        Me.lbllatitude.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbllatitude.Name = "lbllatitude"
        Me.lbllatitude.Size = New System.Drawing.Size(48, 13)
        Me.lbllatitude.TabIndex = 24
        Me.lbllatitude.Text = "Latitude:"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Location = New System.Drawing.Point(240, 12)
        Me.lblLongitude.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(57, 13)
        Me.lblLongitude.TabIndex = 22
        Me.lblLongitude.Text = "Longitude:"
        '
        'grpMapOutline
        '
        Me.grpMapOutline.Controls.Add(Me.ucrChkAddPoints)
        Me.grpMapOutline.Controls.Add(Me.ldlGeometry)
        Me.grpMapOutline.Controls.Add(Me.ucrReceiverGeometry)
        Me.grpMapOutline.Controls.Add(Me.lblFill)
        Me.grpMapOutline.Controls.Add(Me.ucrReceiverFill)
        Me.grpMapOutline.Controls.Add(Me.ucrSelectorOutline)
        Me.grpMapOutline.Location = New System.Drawing.Point(10, 12)
        Me.grpMapOutline.Name = "grpMapOutline"
        Me.grpMapOutline.Size = New System.Drawing.Size(357, 245)
        Me.grpMapOutline.TabIndex = 22
        Me.grpMapOutline.TabStop = False
        Me.grpMapOutline.Text = "Map Outline"
        '
        'ldlGeometry
        '
        Me.ldlGeometry.AutoSize = True
        Me.ldlGeometry.Location = New System.Drawing.Point(232, 9)
        Me.ldlGeometry.Name = "ldlGeometry"
        Me.ldlGeometry.Size = New System.Drawing.Size(52, 13)
        Me.ldlGeometry.TabIndex = 7
        Me.ldlGeometry.Text = "Geometry"
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.Location = New System.Drawing.Point(231, 55)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(70, 13)
        Me.lblFill.TabIndex = 4
        Me.lblFill.Text = "Fill (Optional):"
        '
        'ucrChkAddPoints
        '
        Me.ucrChkAddPoints.Checked = False
        Me.ucrChkAddPoints.Location = New System.Drawing.Point(234, 97)
        Me.ucrChkAddPoints.Name = "ucrChkAddPoints"
        Me.ucrChkAddPoints.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkAddPoints.TabIndex = 8
        '
        'ucrReceiverGeometry
        '
        Me.ucrReceiverGeometry.frmParent = Nothing
        Me.ucrReceiverGeometry.Location = New System.Drawing.Point(234, 27)
        Me.ucrReceiverGeometry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGeometry.Name = "ucrReceiverGeometry"
        Me.ucrReceiverGeometry.Selector = Nothing
        Me.ucrReceiverGeometry.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverGeometry.strNcFilePath = ""
        Me.ucrReceiverGeometry.TabIndex = 6
        Me.ucrReceiverGeometry.ucrSelector = Nothing
        '
        'ucrReceiverFill
        '
        Me.ucrReceiverFill.frmParent = Nothing
        Me.ucrReceiverFill.Location = New System.Drawing.Point(234, 68)
        Me.ucrReceiverFill.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFill.Name = "ucrReceiverFill"
        Me.ucrReceiverFill.Selector = Nothing
        Me.ucrReceiverFill.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFill.strNcFilePath = ""
        Me.ucrReceiverFill.TabIndex = 5
        Me.ucrReceiverFill.ucrSelector = Nothing
        '
        'ucrSelectorOutline
        '
        Me.ucrSelectorOutline.bDropUnusedFilterLevels = False
        Me.ucrSelectorOutline.bShowHiddenColumns = False
        Me.ucrSelectorOutline.bUseCurrentFilter = True
        Me.ucrSelectorOutline.Location = New System.Drawing.Point(4, 15)
        Me.ucrSelectorOutline.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOutline.Name = "ucrSelectorOutline"
        Me.ucrSelectorOutline.Size = New System.Drawing.Size(220, 189)
        Me.ucrSelectorOutline.TabIndex = 3
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Nothing
        Me.ucrReceiverStation.Location = New System.Drawing.Point(239, 120)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 32
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverFacet
        '
        Me.ucrReceiverFacet.frmParent = Nothing
        Me.ucrReceiverFacet.Location = New System.Drawing.Point(241, 256)
        Me.ucrReceiverFacet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacet.Name = "ucrReceiverFacet"
        Me.ucrReceiverFacet.Selector = Nothing
        Me.ucrReceiverFacet.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFacet.strNcFilePath = ""
        Me.ucrReceiverFacet.TabIndex = 30
        Me.ucrReceiverFacet.ucrSelector = Nothing
        '
        'ucrSelectorStation
        '
        Me.ucrSelectorStation.bDropUnusedFilterLevels = False
        Me.ucrSelectorStation.bShowHiddenColumns = False
        Me.ucrSelectorStation.bUseCurrentFilter = True
        Me.ucrSelectorStation.Location = New System.Drawing.Point(8, 16)
        Me.ucrSelectorStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStation.Name = "ucrSelectorStation"
        Me.ucrSelectorStation.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorStation.TabIndex = 21
        '
        'ucrReceiverColor
        '
        Me.ucrReceiverColor.frmParent = Nothing
        Me.ucrReceiverColor.Location = New System.Drawing.Point(240, 209)
        Me.ucrReceiverColor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColor.Name = "ucrReceiverColor"
        Me.ucrReceiverColor.Selector = Nothing
        Me.ucrReceiverColor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverColor.strNcFilePath = ""
        Me.ucrReceiverColor.TabIndex = 29
        Me.ucrReceiverColor.ucrSelector = Nothing
        '
        'ucrReceiverShape
        '
        Me.ucrReceiverShape.frmParent = Nothing
        Me.ucrReceiverShape.Location = New System.Drawing.Point(240, 165)
        Me.ucrReceiverShape.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverShape.Name = "ucrReceiverShape"
        Me.ucrReceiverShape.Selector = Nothing
        Me.ucrReceiverShape.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverShape.strNcFilePath = ""
        Me.ucrReceiverShape.TabIndex = 27
        Me.ucrReceiverShape.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.frmParent = Nothing
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(240, 72)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 25
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.frmParent = Nothing
        Me.ucrReceiverLongitude.Location = New System.Drawing.Point(240, 31)
        Me.ucrReceiverLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.TabIndex = 23
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrSaveMap
        '
        Me.ucrSaveMap.Location = New System.Drawing.Point(8, 356)
        Me.ucrSaveMap.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveMap.Name = "ucrSaveMap"
        Me.ucrSaveMap.Size = New System.Drawing.Size(244, 24)
        Me.ucrSaveMap.TabIndex = 15
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(14, 393)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(409, 52)
        Me.ucrBase.TabIndex = 16
        '
        'dlgClimaticStationMaps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 456)
        Me.Controls.Add(Me.grpMapOutline)
        Me.Controls.Add(Me.grpPoints)
        Me.Controls.Add(Me.cmdSFOptions)
        Me.Controls.Add(Me.cmdMapOptions)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.ucrSaveMap)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticStationMaps"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climatic Maps"
        Me.grpPoints.ResumeLayout(False)
        Me.grpPoints.PerformLayout()
        Me.grpMapOutline.ResumeLayout(False)
        Me.grpMapOutline.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents ucrSaveMap As ucrSave
    Friend WithEvents cmdSFOptions As Button
    Friend WithEvents cmdMapOptions As Button
    Friend WithEvents grpPoints As GroupBox
    Friend WithEvents lblLabels As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents grpMapOutline As GroupBox
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrReceiverFill As ucrReceiverSingle
    Friend WithEvents ucrSelectorOutline As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFacet As Label
    Friend WithEvents ucrReceiverFacet As ucrReceiverSingle
    Friend WithEvents ucrSelectorStation As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblColor As Label
    Friend WithEvents lblShape As Label
    Friend WithEvents lbllatitude As Label
    Friend WithEvents ucrReceiverColor As ucrReceiverSingle
    Friend WithEvents lblLongitude As Label
    Friend WithEvents ucrReceiverShape As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents ucrChkAddPoints As ucrCheck
    Friend WithEvents ldlGeometry As Label
    Friend WithEvents ucrReceiverGeometry As ucrReceiverSingle
End Class
