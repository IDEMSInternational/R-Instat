<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgThemesSub
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
        Me.TabThemes = New System.Windows.Forms.TabControl()
        Me.tbTitles = New System.Windows.Forms.TabPage()
        Me.ucrThemeTitleYAxis = New instat.ucrELementTextControl()
        Me.ucrThemeTitleXAxis = New instat.ucrELementTextControl()
        Me.ucrPlotTitle = New instat.ucrELementTextControl()
        Me.tbLabels = New System.Windows.Forms.TabPage()
        Me.ucrThemeLeftYAxis = New instat.ucrELementTextControl()
        Me.ucrThemeBottomXAxis = New instat.ucrELementTextControl()
        Me.ucrThemeAxesTickLabels = New instat.ucrELementTextControl()
        Me.tbAxes = New System.Windows.Forms.TabPage()
        Me.ucrYAxisLines = New instat.ucrElementLineControl()
        Me.ucrTickMarksYAxis = New instat.ucrElementLineControl()
        Me.ucrXAxisLines = New instat.ucrElementLineControl()
        Me.ucrTickMarksXAxis = New instat.ucrElementLineControl()
        Me.ucrThemeAxesLines = New instat.ucrElementLineControl()
        Me.ucrTickMarksAxes = New instat.ucrElementLineControl()
        Me.tbPanel = New System.Windows.Forms.TabPage()
        Me.ucrPanelGridMinor = New instat.ucrElementLineControl()
        Me.ucrPanelGridMajor = New instat.ucrElementLineControl()
        Me.ucrPanelGrid = New instat.ucrElementLineControl()
        Me.tbBackground = New System.Windows.Forms.TabPage()
        Me.ucrPanelBackground = New instat.ucrElementRectControl()
        Me.ucrPanelBorder = New instat.ucrElementRectControl()
        Me.tbLegend = New System.Windows.Forms.TabPage()
        Me.ucrChkAddLegend = New instat.ucrCheck()
        Me.grpLegendPosition = New System.Windows.Forms.GroupBox()
        Me.rdoColour = New System.Windows.Forms.RadioButton()
        Me.rdoFill = New System.Windows.Forms.RadioButton()
        Me.ucrPnlReverse = New instat.UcrPanel()
        Me.rdoHorizontal = New System.Windows.Forms.RadioButton()
        Me.rdoVertical = New System.Windows.Forms.RadioButton()
        Me.ucrPnlDirection = New instat.UcrPanel()
        Me.ucrChkReverse = New instat.ucrCheck()
        Me.ucrChkDirection = New instat.ucrCheck()
        Me.ucrNudY = New instat.ucrNud()
        Me.rdoCoordinates = New System.Windows.Forms.RadioButton()
        Me.ucrNudX = New instat.ucrNud()
        Me.rdoSpecific = New System.Windows.Forms.RadioButton()
        Me.lblYCoord = New System.Windows.Forms.Label()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.lblXCoord = New System.Windows.Forms.Label()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.lblLegendPosition = New System.Windows.Forms.Label()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.TabThemes.SuspendLayout()
        Me.tbTitles.SuspendLayout()
        Me.tbLabels.SuspendLayout()
        Me.tbAxes.SuspendLayout()
        Me.tbPanel.SuspendLayout()
        Me.tbBackground.SuspendLayout()
        Me.tbLegend.SuspendLayout()
        Me.grpLegendPosition.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabThemes
        '
        Me.TabThemes.Controls.Add(Me.tbTitles)
        Me.TabThemes.Controls.Add(Me.tbLabels)
        Me.TabThemes.Controls.Add(Me.tbAxes)
        Me.TabThemes.Controls.Add(Me.tbPanel)
        Me.TabThemes.Controls.Add(Me.tbBackground)
        Me.TabThemes.Controls.Add(Me.tbLegend)
        Me.TabThemes.Location = New System.Drawing.Point(2, 3)
        Me.TabThemes.Name = "TabThemes"
        Me.TabThemes.SelectedIndex = 0
        Me.TabThemes.Size = New System.Drawing.Size(527, 487)
        Me.TabThemes.TabIndex = 0
        '
        'tbTitles
        '
        Me.tbTitles.Controls.Add(Me.ucrThemeTitleYAxis)
        Me.tbTitles.Controls.Add(Me.ucrThemeTitleXAxis)
        Me.tbTitles.Controls.Add(Me.ucrPlotTitle)
        Me.tbTitles.Location = New System.Drawing.Point(4, 22)
        Me.tbTitles.Name = "tbTitles"
        Me.tbTitles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTitles.Size = New System.Drawing.Size(519, 461)
        Me.tbTitles.TabIndex = 0
        Me.tbTitles.Text = "Titles"
        Me.tbTitles.UseVisualStyleBackColor = True
        '
        'ucrThemeTitleYAxis
        '
        Me.ucrThemeTitleYAxis.AutoSize = True
        Me.ucrThemeTitleYAxis.Location = New System.Drawing.Point(0, 228)
        Me.ucrThemeTitleYAxis.Name = "ucrThemeTitleYAxis"
        Me.ucrThemeTitleYAxis.Size = New System.Drawing.Size(259, 227)
        Me.ucrThemeTitleYAxis.TabIndex = 3
        '
        'ucrThemeTitleXAxis
        '
        Me.ucrThemeTitleXAxis.AutoSize = True
        Me.ucrThemeTitleXAxis.Location = New System.Drawing.Point(259, 3)
        Me.ucrThemeTitleXAxis.Name = "ucrThemeTitleXAxis"
        Me.ucrThemeTitleXAxis.Size = New System.Drawing.Size(260, 231)
        Me.ucrThemeTitleXAxis.TabIndex = 2
        '
        'ucrPlotTitle
        '
        Me.ucrPlotTitle.AutoSize = True
        Me.ucrPlotTitle.Location = New System.Drawing.Point(0, 3)
        Me.ucrPlotTitle.Name = "ucrPlotTitle"
        Me.ucrPlotTitle.Size = New System.Drawing.Size(255, 226)
        Me.ucrPlotTitle.TabIndex = 1
        '
        'tbLabels
        '
        Me.tbLabels.Controls.Add(Me.ucrThemeLeftYAxis)
        Me.tbLabels.Controls.Add(Me.ucrThemeBottomXAxis)
        Me.tbLabels.Controls.Add(Me.ucrThemeAxesTickLabels)
        Me.tbLabels.Location = New System.Drawing.Point(4, 22)
        Me.tbLabels.Name = "tbLabels"
        Me.tbLabels.Padding = New System.Windows.Forms.Padding(3)
        Me.tbLabels.Size = New System.Drawing.Size(519, 461)
        Me.tbLabels.TabIndex = 1
        Me.tbLabels.Text = "Labels"
        Me.tbLabels.UseVisualStyleBackColor = True
        '
        'ucrThemeLeftYAxis
        '
        Me.ucrThemeLeftYAxis.AutoSize = True
        Me.ucrThemeLeftYAxis.Location = New System.Drawing.Point(254, 32)
        Me.ucrThemeLeftYAxis.Name = "ucrThemeLeftYAxis"
        Me.ucrThemeLeftYAxis.Size = New System.Drawing.Size(259, 226)
        Me.ucrThemeLeftYAxis.TabIndex = 4
        '
        'ucrThemeBottomXAxis
        '
        Me.ucrThemeBottomXAxis.AutoSize = True
        Me.ucrThemeBottomXAxis.Location = New System.Drawing.Point(0, 32)
        Me.ucrThemeBottomXAxis.Name = "ucrThemeBottomXAxis"
        Me.ucrThemeBottomXAxis.Size = New System.Drawing.Size(259, 226)
        Me.ucrThemeBottomXAxis.TabIndex = 3
        '
        'ucrThemeAxesTickLabels
        '
        Me.ucrThemeAxesTickLabels.AutoSize = True
        Me.ucrThemeAxesTickLabels.Location = New System.Drawing.Point(0, 32)
        Me.ucrThemeAxesTickLabels.Name = "ucrThemeAxesTickLabels"
        Me.ucrThemeAxesTickLabels.Size = New System.Drawing.Size(255, 228)
        Me.ucrThemeAxesTickLabels.TabIndex = 2
        '
        'tbAxes
        '
        Me.tbAxes.Controls.Add(Me.ucrYAxisLines)
        Me.tbAxes.Controls.Add(Me.ucrTickMarksYAxis)
        Me.tbAxes.Controls.Add(Me.ucrXAxisLines)
        Me.tbAxes.Controls.Add(Me.ucrTickMarksXAxis)
        Me.tbAxes.Controls.Add(Me.ucrThemeAxesLines)
        Me.tbAxes.Controls.Add(Me.ucrTickMarksAxes)
        Me.tbAxes.Location = New System.Drawing.Point(4, 22)
        Me.tbAxes.Name = "tbAxes"
        Me.tbAxes.Size = New System.Drawing.Size(519, 461)
        Me.tbAxes.TabIndex = 2
        Me.tbAxes.Text = "Axes"
        Me.tbAxes.UseVisualStyleBackColor = True
        '
        'ucrYAxisLines
        '
        Me.ucrYAxisLines.AutoSize = True
        Me.ucrYAxisLines.Location = New System.Drawing.Point(260, 197)
        Me.ucrYAxisLines.Name = "ucrYAxisLines"
        Me.ucrYAxisLines.Size = New System.Drawing.Size(254, 124)
        Me.ucrYAxisLines.TabIndex = 1
        '
        'ucrTickMarksYAxis
        '
        Me.ucrTickMarksYAxis.AutoSize = True
        Me.ucrTickMarksYAxis.Location = New System.Drawing.Point(258, 32)
        Me.ucrTickMarksYAxis.Name = "ucrTickMarksYAxis"
        Me.ucrTickMarksYAxis.Size = New System.Drawing.Size(255, 123)
        Me.ucrTickMarksYAxis.TabIndex = 0
        '
        'ucrXAxisLines
        '
        Me.ucrXAxisLines.AutoSize = True
        Me.ucrXAxisLines.Location = New System.Drawing.Point(0, 197)
        Me.ucrXAxisLines.Name = "ucrXAxisLines"
        Me.ucrXAxisLines.Size = New System.Drawing.Size(254, 124)
        Me.ucrXAxisLines.TabIndex = 1
        '
        'ucrTickMarksXAxis
        '
        Me.ucrTickMarksXAxis.AutoSize = True
        Me.ucrTickMarksXAxis.Location = New System.Drawing.Point(0, 32)
        Me.ucrTickMarksXAxis.Name = "ucrTickMarksXAxis"
        Me.ucrTickMarksXAxis.Size = New System.Drawing.Size(254, 124)
        Me.ucrTickMarksXAxis.TabIndex = 0
        '
        'ucrThemeAxesLines
        '
        Me.ucrThemeAxesLines.AutoSize = True
        Me.ucrThemeAxesLines.Location = New System.Drawing.Point(3, 197)
        Me.ucrThemeAxesLines.Name = "ucrThemeAxesLines"
        Me.ucrThemeAxesLines.Size = New System.Drawing.Size(253, 122)
        Me.ucrThemeAxesLines.TabIndex = 8
        '
        'ucrTickMarksAxes
        '
        Me.ucrTickMarksAxes.AutoSize = True
        Me.ucrTickMarksAxes.Location = New System.Drawing.Point(3, 32)
        Me.ucrTickMarksAxes.Name = "ucrTickMarksAxes"
        Me.ucrTickMarksAxes.Size = New System.Drawing.Size(257, 122)
        Me.ucrTickMarksAxes.TabIndex = 4
        '
        'tbPanel
        '
        Me.tbPanel.Controls.Add(Me.ucrPanelGridMinor)
        Me.tbPanel.Controls.Add(Me.ucrPanelGridMajor)
        Me.tbPanel.Controls.Add(Me.ucrPanelGrid)
        Me.tbPanel.Location = New System.Drawing.Point(4, 22)
        Me.tbPanel.Name = "tbPanel"
        Me.tbPanel.Size = New System.Drawing.Size(519, 461)
        Me.tbPanel.TabIndex = 3
        Me.tbPanel.Text = "Grid Lines"
        Me.tbPanel.UseVisualStyleBackColor = True
        '
        'ucrPanelGridMinor
        '
        Me.ucrPanelGridMinor.AutoSize = True
        Me.ucrPanelGridMinor.Location = New System.Drawing.Point(261, 31)
        Me.ucrPanelGridMinor.Name = "ucrPanelGridMinor"
        Me.ucrPanelGridMinor.Size = New System.Drawing.Size(254, 124)
        Me.ucrPanelGridMinor.TabIndex = 4
        '
        'ucrPanelGridMajor
        '
        Me.ucrPanelGridMajor.AutoSize = True
        Me.ucrPanelGridMajor.Location = New System.Drawing.Point(6, 31)
        Me.ucrPanelGridMajor.Name = "ucrPanelGridMajor"
        Me.ucrPanelGridMajor.Size = New System.Drawing.Size(254, 124)
        Me.ucrPanelGridMajor.TabIndex = 3
        '
        'ucrPanelGrid
        '
        Me.ucrPanelGrid.AutoSize = True
        Me.ucrPanelGrid.Location = New System.Drawing.Point(3, 31)
        Me.ucrPanelGrid.Name = "ucrPanelGrid"
        Me.ucrPanelGrid.Size = New System.Drawing.Size(254, 124)
        Me.ucrPanelGrid.TabIndex = 2
        '
        'tbBackground
        '
        Me.tbBackground.Controls.Add(Me.ucrPanelBackground)
        Me.tbBackground.Controls.Add(Me.ucrPanelBorder)
        Me.tbBackground.Location = New System.Drawing.Point(4, 22)
        Me.tbBackground.Name = "tbBackground"
        Me.tbBackground.Size = New System.Drawing.Size(519, 461)
        Me.tbBackground.TabIndex = 4
        Me.tbBackground.Text = "Panel"
        Me.tbBackground.UseVisualStyleBackColor = True
        '
        'ucrPanelBackground
        '
        Me.ucrPanelBackground.AutoSize = True
        Me.ucrPanelBackground.Location = New System.Drawing.Point(0, 144)
        Me.ucrPanelBackground.Name = "ucrPanelBackground"
        Me.ucrPanelBackground.Size = New System.Drawing.Size(253, 132)
        Me.ucrPanelBackground.TabIndex = 1
        '
        'ucrPanelBorder
        '
        Me.ucrPanelBorder.AutoSize = True
        Me.ucrPanelBorder.Location = New System.Drawing.Point(0, 6)
        Me.ucrPanelBorder.Name = "ucrPanelBorder"
        Me.ucrPanelBorder.Size = New System.Drawing.Size(253, 132)
        Me.ucrPanelBorder.TabIndex = 0
        '
        'tbLegend
        '
        Me.tbLegend.Controls.Add(Me.ucrChkAddLegend)
        Me.tbLegend.Controls.Add(Me.grpLegendPosition)
        Me.tbLegend.Location = New System.Drawing.Point(4, 22)
        Me.tbLegend.Name = "tbLegend"
        Me.tbLegend.Size = New System.Drawing.Size(519, 461)
        Me.tbLegend.TabIndex = 5
        Me.tbLegend.Text = "Legend"
        Me.tbLegend.UseVisualStyleBackColor = True
        '
        'ucrChkAddLegend
        '
        Me.ucrChkAddLegend.AutoSize = True
        Me.ucrChkAddLegend.Checked = False
        Me.ucrChkAddLegend.Location = New System.Drawing.Point(15, 19)
        Me.ucrChkAddLegend.Name = "ucrChkAddLegend"
        Me.ucrChkAddLegend.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkAddLegend.TabIndex = 332
        '
        'grpLegendPosition
        '
        Me.grpLegendPosition.Controls.Add(Me.rdoColour)
        Me.grpLegendPosition.Controls.Add(Me.rdoFill)
        Me.grpLegendPosition.Controls.Add(Me.ucrPnlReverse)
        Me.grpLegendPosition.Controls.Add(Me.rdoHorizontal)
        Me.grpLegendPosition.Controls.Add(Me.rdoVertical)
        Me.grpLegendPosition.Controls.Add(Me.ucrPnlDirection)
        Me.grpLegendPosition.Controls.Add(Me.ucrChkReverse)
        Me.grpLegendPosition.Controls.Add(Me.ucrChkDirection)
        Me.grpLegendPosition.Controls.Add(Me.ucrNudY)
        Me.grpLegendPosition.Controls.Add(Me.rdoCoordinates)
        Me.grpLegendPosition.Controls.Add(Me.ucrNudX)
        Me.grpLegendPosition.Controls.Add(Me.rdoSpecific)
        Me.grpLegendPosition.Controls.Add(Me.lblYCoord)
        Me.grpLegendPosition.Controls.Add(Me.ucrPnlOptions)
        Me.grpLegendPosition.Controls.Add(Me.lblXCoord)
        Me.grpLegendPosition.Controls.Add(Me.ucrInputLegendPosition)
        Me.grpLegendPosition.Controls.Add(Me.lblLegendPosition)
        Me.grpLegendPosition.Location = New System.Drawing.Point(6, 53)
        Me.grpLegendPosition.Name = "grpLegendPosition"
        Me.grpLegendPosition.Size = New System.Drawing.Size(413, 146)
        Me.grpLegendPosition.TabIndex = 6
        Me.grpLegendPosition.TabStop = False
        Me.grpLegendPosition.Text = "Legend Position"
        '
        'rdoColour
        '
        Me.rdoColour.AutoSize = True
        Me.rdoColour.Location = New System.Drawing.Point(244, 84)
        Me.rdoColour.Name = "rdoColour"
        Me.rdoColour.Size = New System.Drawing.Size(55, 17)
        Me.rdoColour.TabIndex = 341
        Me.rdoColour.TabStop = True
        Me.rdoColour.Text = "Colour"
        Me.rdoColour.UseVisualStyleBackColor = True
        '
        'rdoFill
        '
        Me.rdoFill.AutoSize = True
        Me.rdoFill.Location = New System.Drawing.Point(119, 84)
        Me.rdoFill.Name = "rdoFill"
        Me.rdoFill.Size = New System.Drawing.Size(37, 17)
        Me.rdoFill.TabIndex = 340
        Me.rdoFill.TabStop = True
        Me.rdoFill.Text = "Fill"
        Me.rdoFill.UseVisualStyleBackColor = True
        '
        'ucrPnlReverse
        '
        Me.ucrPnlReverse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlReverse.Location = New System.Drawing.Point(115, 81)
        Me.ucrPnlReverse.Name = "ucrPnlReverse"
        Me.ucrPnlReverse.Size = New System.Drawing.Size(281, 26)
        Me.ucrPnlReverse.TabIndex = 339
        '
        'rdoHorizontal
        '
        Me.rdoHorizontal.AutoSize = True
        Me.rdoHorizontal.Location = New System.Drawing.Point(244, 112)
        Me.rdoHorizontal.Name = "rdoHorizontal"
        Me.rdoHorizontal.Size = New System.Drawing.Size(72, 17)
        Me.rdoHorizontal.TabIndex = 338
        Me.rdoHorizontal.TabStop = True
        Me.rdoHorizontal.Text = "Horizontal"
        Me.rdoHorizontal.UseVisualStyleBackColor = True
        '
        'rdoVertical
        '
        Me.rdoVertical.AutoSize = True
        Me.rdoVertical.Location = New System.Drawing.Point(119, 112)
        Me.rdoVertical.Name = "rdoVertical"
        Me.rdoVertical.Size = New System.Drawing.Size(60, 17)
        Me.rdoVertical.TabIndex = 337
        Me.rdoVertical.TabStop = True
        Me.rdoVertical.Text = "Vertical"
        Me.rdoVertical.UseVisualStyleBackColor = True
        '
        'ucrPnlDirection
        '
        Me.ucrPnlDirection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDirection.Location = New System.Drawing.Point(115, 109)
        Me.ucrPnlDirection.Name = "ucrPnlDirection"
        Me.ucrPnlDirection.Size = New System.Drawing.Size(281, 26)
        Me.ucrPnlDirection.TabIndex = 336
        '
        'ucrChkReverse
        '
        Me.ucrChkReverse.AutoSize = True
        Me.ucrChkReverse.Checked = False
        Me.ucrChkReverse.Location = New System.Drawing.Point(9, 81)
        Me.ucrChkReverse.Name = "ucrChkReverse"
        Me.ucrChkReverse.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkReverse.TabIndex = 332
        '
        'ucrChkDirection
        '
        Me.ucrChkDirection.AutoSize = True
        Me.ucrChkDirection.Checked = False
        Me.ucrChkDirection.Location = New System.Drawing.Point(9, 112)
        Me.ucrChkDirection.Name = "ucrChkDirection"
        Me.ucrChkDirection.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkDirection.TabIndex = 331
        '
        'ucrNudY
        '
        Me.ucrNudY.AutoSize = True
        Me.ucrNudY.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudY.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudY.Location = New System.Drawing.Point(346, 52)
        Me.ucrNudY.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudY.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudY.Name = "ucrNudY"
        Me.ucrNudY.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudY.TabIndex = 330
        Me.ucrNudY.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoCoordinates
        '
        Me.rdoCoordinates.AutoSize = True
        Me.rdoCoordinates.Location = New System.Drawing.Point(195, 22)
        Me.rdoCoordinates.Name = "rdoCoordinates"
        Me.rdoCoordinates.Size = New System.Drawing.Size(81, 17)
        Me.rdoCoordinates.TabIndex = 329
        Me.rdoCoordinates.TabStop = True
        Me.rdoCoordinates.Text = "Coordinates"
        Me.rdoCoordinates.UseVisualStyleBackColor = True
        '
        'ucrNudX
        '
        Me.ucrNudX.AutoSize = True
        Me.ucrNudX.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudX.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudX.Location = New System.Drawing.Point(259, 51)
        Me.ucrNudX.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudX.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudX.Name = "ucrNudX"
        Me.ucrNudX.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudX.TabIndex = 7
        Me.ucrNudX.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoSpecific
        '
        Me.rdoSpecific.AutoSize = True
        Me.rdoSpecific.Location = New System.Drawing.Point(10, 22)
        Me.rdoSpecific.Name = "rdoSpecific"
        Me.rdoSpecific.Size = New System.Drawing.Size(63, 17)
        Me.rdoSpecific.TabIndex = 328
        Me.rdoSpecific.TabStop = True
        Me.rdoSpecific.Text = "Specific"
        Me.rdoSpecific.UseVisualStyleBackColor = True
        '
        'lblYCoord
        '
        Me.lblYCoord.AutoSize = True
        Me.lblYCoord.Location = New System.Drawing.Point(329, 52)
        Me.lblYCoord.Name = "lblYCoord"
        Me.lblYCoord.Size = New System.Drawing.Size(15, 13)
        Me.lblYCoord.TabIndex = 8
        Me.lblYCoord.Text = "y:"
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(356, 26)
        Me.ucrPnlOptions.TabIndex = 327
        '
        'lblXCoord
        '
        Me.lblXCoord.AutoSize = True
        Me.lblXCoord.Location = New System.Drawing.Point(239, 52)
        Me.lblXCoord.Name = "lblXCoord"
        Me.lblXCoord.Size = New System.Drawing.Size(15, 13)
        Me.lblXCoord.TabIndex = 7
        Me.lblXCoord.Text = "x:"
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(59, 51)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLegendPosition.TabIndex = 0
        '
        'lblLegendPosition
        '
        Me.lblLegendPosition.AutoSize = True
        Me.lblLegendPosition.Location = New System.Drawing.Point(6, 52)
        Me.lblLegendPosition.Name = "lblLegendPosition"
        Me.lblLegendPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblLegendPosition.TabIndex = 1
        Me.lblLegendPosition.Text = "Position:"
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(160, 495)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSubdialog.TabIndex = 2
        '
        'sdgThemesSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(531, 529)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.TabThemes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgThemesSub"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Themes"
        Me.TabThemes.ResumeLayout(False)
        Me.tbTitles.ResumeLayout(False)
        Me.tbTitles.PerformLayout()
        Me.tbLabels.ResumeLayout(False)
        Me.tbLabels.PerformLayout()
        Me.tbAxes.ResumeLayout(False)
        Me.tbAxes.PerformLayout()
        Me.tbPanel.ResumeLayout(False)
        Me.tbPanel.PerformLayout()
        Me.tbBackground.ResumeLayout(False)
        Me.tbBackground.PerformLayout()
        Me.tbLegend.ResumeLayout(False)
        Me.tbLegend.PerformLayout()
        Me.grpLegendPosition.ResumeLayout(False)
        Me.grpLegendPosition.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabThemes As TabControl
    Friend WithEvents tbTitles As TabPage
    Friend WithEvents tbLabels As TabPage
    Friend WithEvents tbAxes As TabPage
    Friend WithEvents tbPanel As TabPage
    Friend WithEvents tbBackground As TabPage
    Friend WithEvents tbLegend As TabPage
    Friend WithEvents ucrPlotTitle As ucrELementTextControl
    Friend WithEvents ucrThemeTitleXAxis As ucrELementTextControl
    Friend WithEvents ucrThemeTitleYAxis As ucrELementTextControl
    Friend WithEvents ucrThemeAxesTickLabels As ucrELementTextControl
    Friend WithEvents ucrThemeBottomXAxis As ucrELementTextControl
    Friend WithEvents ucrThemeLeftYAxis As ucrELementTextControl
    Friend WithEvents ucrTickMarksAxes As ucrElementLineControl
    Friend WithEvents ucrThemeAxesLines As ucrElementLineControl
    Friend WithEvents ucrXAxisLines As ucrElementLineControl
    Friend WithEvents ucrTickMarksXAxis As ucrElementLineControl
    Friend WithEvents ucrYAxisLines As ucrElementLineControl
    Friend WithEvents ucrTickMarksYAxis As ucrElementLineControl
    Friend WithEvents ucrPanelGrid As ucrElementLineControl
    Friend WithEvents ucrPanelGridMajor As ucrElementLineControl
    Friend WithEvents ucrPanelGridMinor As ucrElementLineControl
    Friend WithEvents ucrPanelBackground As ucrElementRectControl
    Friend WithEvents ucrPanelBorder As ucrElementRectControl
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents grpLegendPosition As GroupBox
    Friend WithEvents lblYCoord As Label
    Friend WithEvents lblXCoord As Label
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents lblLegendPosition As Label
    Friend WithEvents ucrNudX As ucrNud
    Friend WithEvents rdoCoordinates As RadioButton
    Friend WithEvents rdoSpecific As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrNudY As ucrNud
    Friend WithEvents ucrChkReverse As ucrCheck
    Friend WithEvents ucrChkDirection As ucrCheck
    Friend WithEvents rdoHorizontal As RadioButton
    Friend WithEvents rdoVertical As RadioButton
    Friend WithEvents ucrPnlDirection As UcrPanel
    Friend WithEvents rdoColour As RadioButton
    Friend WithEvents rdoFill As RadioButton
    Friend WithEvents ucrPnlReverse As UcrPanel
    Friend WithEvents ucrChkAddLegend As ucrCheck
End Class
