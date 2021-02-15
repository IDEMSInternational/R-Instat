<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgCircularDensityPlotsOptions
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
        Me.tbpTheme = New System.Windows.Forms.TabPage()
        Me.cmdSimpleOptions = New System.Windows.Forms.Button()
        Me.urChkSelectTheme = New instat.ucrCheck()
        Me.grpCommonOptions = New System.Windows.Forms.GroupBox()
        Me.ucrNudYaxisMarkSize = New instat.ucrNud()
        Me.ucrNudXaxisMarkSize = New instat.ucrNud()
        Me.ucrNudYSize = New instat.ucrNud()
        Me.ucrNudXSize = New instat.ucrNud()
        Me.ucrNudXAngle = New instat.ucrNud()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkYaxisTickMarkLabelSize = New instat.ucrCheck()
        Me.ucrChkXaxisTickMarkLabelSize = New instat.ucrCheck()
        Me.ucrChkYaxisSize = New instat.ucrCheck()
        Me.ucrChkXaxisSize = New instat.ucrCheck()
        Me.ucrChkXaxisAngle = New instat.ucrCheck()
        Me.ucrChkLegendPosition = New instat.ucrCheck()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.cmdAllOptions = New System.Windows.Forms.Button()
        Me.ucrInputThemes = New instat.ucrInputComboBox()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpLegendTitle = New System.Windows.Forms.GroupBox()
        Me.ucrChkOverwriteLegendTitle = New instat.ucrCheck()
        Me.ucrChkDisplayLegendTitle = New instat.ucrCheck()
        Me.ucrInputLegend = New instat.ucrInputTextBox()
        Me.rdoLegendTitleCustom = New System.Windows.Forms.RadioButton()
        Me.rdoLegendTitleAuto = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLegendTitle = New instat.UcrPanel()
        Me.ucrInputGraphCaption = New instat.ucrInputTextBox()
        Me.ucrInputGraphSubTitle = New instat.ucrInputTextBox()
        Me.ucrYAxis = New instat.ucrAxes()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.ucrChkSameScale = New instat.ucrCheck()
        Me.grpPolarCordinates = New System.Windows.Forms.GroupBox()
        Me.ucrInputPolarCoordinates = New instat.ucrInputComboBox()
        Me.lblPolarCoordinate = New System.Windows.Forms.Label()
        Me.lblStartingAngle = New System.Windows.Forms.Label()
        Me.ucrChkUsePolarCoordinates = New instat.ucrCheck()
        Me.lblPi = New System.Windows.Forms.Label()
        Me.ucrChkDirectionAnticlockwise = New instat.ucrCheck()
        Me.ucrInputStartingAngle = New instat.ucrInputTextBox()
        Me.tbpCoordinates = New System.Windows.Forms.TabPage()
        Me.ucrChkHorizontalPlot = New instat.ucrCheck()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.tbpFacet = New System.Windows.Forms.TabPage()
        Me.ucrChkDrop = New instat.ucrCheck()
        Me.ucrNudNumberofRows = New instat.ucrNud()
        Me.ucrChkNoOfRowsOrColumns = New instat.ucrCheck()
        Me.ucrChkIncludeFacets = New instat.ucrCheck()
        Me.ucrChkLabeler = New instat.ucrCheck()
        Me.ucrChkFreeSpace = New instat.ucrCheck()
        Me.ucrChkFreeScalesY = New instat.ucrCheck()
        Me.ucrChkFreeScalesX = New instat.ucrCheck()
        Me.ucrChkMargin = New instat.ucrCheck()
        Me.ucrFacetSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.rdoHorizontal = New System.Windows.Forms.RadioButton()
        Me.rdoVertical = New System.Windows.Forms.RadioButton()
        Me.lblFactor2 = New System.Windows.Forms.Label()
        Me.lblFactor1 = New System.Windows.Forms.Label()
        Me.ucr2ndFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrPnlHorizonatalVertical = New instat.UcrPanel()
        Me.tbpPlotsOptions = New System.Windows.Forms.TabControl()
        Me.tbpLayers = New System.Windows.Forms.TabPage()
        Me.ucrPlotsAdditionalLayers = New instat.ucrAdditionalLayers()
        Me.tbpTitles = New System.Windows.Forms.TabPage()
        Me.tbpXAxis = New System.Windows.Forms.TabPage()
        Me.ucrXAxis = New instat.ucrAxes()
        Me.tbpYAxis = New System.Windows.Forms.TabPage()
        Me.tbpTheme.SuspendLayout()
        Me.grpCommonOptions.SuspendLayout()
        Me.grpLegendTitle.SuspendLayout()
        Me.grpPolarCordinates.SuspendLayout()
        Me.tbpCoordinates.SuspendLayout()
        Me.tbpFacet.SuspendLayout()
        Me.tbpPlotsOptions.SuspendLayout()
        Me.tbpLayers.SuspendLayout()
        Me.tbpTitles.SuspendLayout()
        Me.tbpXAxis.SuspendLayout()
        Me.tbpYAxis.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpTheme
        '
        Me.tbpTheme.Controls.Add(Me.cmdSimpleOptions)
        Me.tbpTheme.Controls.Add(Me.urChkSelectTheme)
        Me.tbpTheme.Controls.Add(Me.grpCommonOptions)
        Me.tbpTheme.Controls.Add(Me.lblFont)
        Me.tbpTheme.Controls.Add(Me.cmdAllOptions)
        Me.tbpTheme.Controls.Add(Me.ucrInputThemes)
        Me.tbpTheme.Location = New System.Drawing.Point(4, 22)
        Me.tbpTheme.Name = "tbpTheme"
        Me.tbpTheme.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTheme.Size = New System.Drawing.Size(192, 74)
        Me.tbpTheme.TabIndex = 1
        Me.tbpTheme.Tag = "Theme"
        Me.tbpTheme.Text = "Themes"
        Me.tbpTheme.UseVisualStyleBackColor = True
        '
        'cmdSimpleOptions
        '
        Me.cmdSimpleOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSimpleOptions.Location = New System.Drawing.Point(113, 48)
        Me.cmdSimpleOptions.Name = "cmdSimpleOptions"
        Me.cmdSimpleOptions.Size = New System.Drawing.Size(92, 23)
        Me.cmdSimpleOptions.TabIndex = 107
        Me.cmdSimpleOptions.Text = "Simple Options"
        Me.cmdSimpleOptions.UseVisualStyleBackColor = True
        '
        'urChkSelectTheme
        '
        Me.urChkSelectTheme.Checked = False
        Me.urChkSelectTheme.Location = New System.Drawing.Point(6, 19)
        Me.urChkSelectTheme.Name = "urChkSelectTheme"
        Me.urChkSelectTheme.Size = New System.Drawing.Size(97, 20)
        Me.urChkSelectTheme.TabIndex = 106
        '
        'grpCommonOptions
        '
        Me.grpCommonOptions.Controls.Add(Me.ucrNudYaxisMarkSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrNudXaxisMarkSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrNudYSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrNudXSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrNudXAngle)
        Me.grpCommonOptions.Controls.Add(Me.ucrInputLegendPosition)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkYaxisTickMarkLabelSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkXaxisTickMarkLabelSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkYaxisSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkXaxisSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkXaxisAngle)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkLegendPosition)
        Me.grpCommonOptions.Location = New System.Drawing.Point(7, 81)
        Me.grpCommonOptions.Name = "grpCommonOptions"
        Me.grpCommonOptions.Size = New System.Drawing.Size(455, 243)
        Me.grpCommonOptions.TabIndex = 5
        Me.grpCommonOptions.TabStop = False
        Me.grpCommonOptions.Text = "Common Options"
        '
        'ucrNudYaxisMarkSize
        '
        Me.ucrNudYaxisMarkSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYaxisMarkSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudYaxisMarkSize.Location = New System.Drawing.Point(246, 205)
        Me.ucrNudYaxisMarkSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYaxisMarkSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYaxisMarkSize.Name = "ucrNudYaxisMarkSize"
        Me.ucrNudYaxisMarkSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudYaxisMarkSize.TabIndex = 11
        Me.ucrNudYaxisMarkSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudXaxisMarkSize
        '
        Me.ucrNudXaxisMarkSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisMarkSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXaxisMarkSize.Location = New System.Drawing.Point(246, 169)
        Me.ucrNudXaxisMarkSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXaxisMarkSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisMarkSize.Name = "ucrNudXaxisMarkSize"
        Me.ucrNudXaxisMarkSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXaxisMarkSize.TabIndex = 10
        Me.ucrNudXaxisMarkSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudYSize
        '
        Me.ucrNudYSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudYSize.Location = New System.Drawing.Point(246, 133)
        Me.ucrNudYSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYSize.Name = "ucrNudYSize"
        Me.ucrNudYSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudYSize.TabIndex = 9
        Me.ucrNudYSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudXSize
        '
        Me.ucrNudXSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXSize.Location = New System.Drawing.Point(246, 97)
        Me.ucrNudXSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXSize.Name = "ucrNudXSize"
        Me.ucrNudXSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXSize.TabIndex = 8
        Me.ucrNudXSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudXAngle
        '
        Me.ucrNudXAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXAngle.Location = New System.Drawing.Point(246, 61)
        Me.ucrNudXAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAngle.Name = "ucrNudXAngle"
        Me.ucrNudXAngle.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXAngle.TabIndex = 7
        Me.ucrNudXAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(246, 25)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLegendPosition.TabIndex = 6
        '
        'ucrChkYaxisTickMarkLabelSize
        '
        Me.ucrChkYaxisTickMarkLabelSize.Checked = False
        Me.ucrChkYaxisTickMarkLabelSize.Location = New System.Drawing.Point(6, 205)
        Me.ucrChkYaxisTickMarkLabelSize.Name = "ucrChkYaxisTickMarkLabelSize"
        Me.ucrChkYaxisTickMarkLabelSize.Size = New System.Drawing.Size(234, 20)
        Me.ucrChkYaxisTickMarkLabelSize.TabIndex = 5
        '
        'ucrChkXaxisTickMarkLabelSize
        '
        Me.ucrChkXaxisTickMarkLabelSize.Checked = False
        Me.ucrChkXaxisTickMarkLabelSize.Location = New System.Drawing.Point(6, 169)
        Me.ucrChkXaxisTickMarkLabelSize.Name = "ucrChkXaxisTickMarkLabelSize"
        Me.ucrChkXaxisTickMarkLabelSize.Size = New System.Drawing.Size(234, 20)
        Me.ucrChkXaxisTickMarkLabelSize.TabIndex = 4
        '
        'ucrChkYaxisSize
        '
        Me.ucrChkYaxisSize.Checked = False
        Me.ucrChkYaxisSize.Location = New System.Drawing.Point(6, 133)
        Me.ucrChkYaxisSize.Name = "ucrChkYaxisSize"
        Me.ucrChkYaxisSize.Size = New System.Drawing.Size(234, 20)
        Me.ucrChkYaxisSize.TabIndex = 3
        '
        'ucrChkXaxisSize
        '
        Me.ucrChkXaxisSize.Checked = False
        Me.ucrChkXaxisSize.Location = New System.Drawing.Point(6, 97)
        Me.ucrChkXaxisSize.Name = "ucrChkXaxisSize"
        Me.ucrChkXaxisSize.Size = New System.Drawing.Size(234, 20)
        Me.ucrChkXaxisSize.TabIndex = 2
        '
        'ucrChkXaxisAngle
        '
        Me.ucrChkXaxisAngle.Checked = False
        Me.ucrChkXaxisAngle.Location = New System.Drawing.Point(6, 61)
        Me.ucrChkXaxisAngle.Name = "ucrChkXaxisAngle"
        Me.ucrChkXaxisAngle.Size = New System.Drawing.Size(234, 20)
        Me.ucrChkXaxisAngle.TabIndex = 1
        '
        'ucrChkLegendPosition
        '
        Me.ucrChkLegendPosition.Checked = False
        Me.ucrChkLegendPosition.Location = New System.Drawing.Point(6, 25)
        Me.ucrChkLegendPosition.Name = "ucrChkLegendPosition"
        Me.ucrChkLegendPosition.Size = New System.Drawing.Size(204, 20)
        Me.ucrChkLegendPosition.TabIndex = 0
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFont.Location = New System.Drawing.Point(233, 49)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(0, 13)
        Me.lblFont.TabIndex = 4
        '
        'cmdAllOptions
        '
        Me.cmdAllOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAllOptions.Location = New System.Drawing.Point(10, 48)
        Me.cmdAllOptions.Name = "cmdAllOptions"
        Me.cmdAllOptions.Size = New System.Drawing.Size(92, 23)
        Me.cmdAllOptions.TabIndex = 2
        Me.cmdAllOptions.Text = "All Options"
        Me.cmdAllOptions.UseVisualStyleBackColor = True
        '
        'ucrInputThemes
        '
        Me.ucrInputThemes.AddQuotesIfUnrecognised = True
        Me.ucrInputThemes.GetSetSelectedIndex = -1
        Me.ucrInputThemes.IsReadOnly = False
        Me.ucrInputThemes.Location = New System.Drawing.Point(113, 14)
        Me.ucrInputThemes.Name = "ucrInputThemes"
        Me.ucrInputThemes.Size = New System.Drawing.Size(171, 21)
        Me.ucrInputThemes.TabIndex = 1
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCaption.Location = New System.Drawing.Point(6, 68)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(78, 13)
        Me.lblCaption.TabIndex = 10
        Me.lblCaption.Text = "Graph Caption:"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubTitle.Location = New System.Drawing.Point(6, 41)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(84, 13)
        Me.lblSubTitle.TabIndex = 10
        Me.lblSubTitle.Text = "Graph Sub Title:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(7, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Graph Title:"
        '
        'grpLegendTitle
        '
        Me.grpLegendTitle.Controls.Add(Me.ucrChkOverwriteLegendTitle)
        Me.grpLegendTitle.Controls.Add(Me.ucrChkDisplayLegendTitle)
        Me.grpLegendTitle.Controls.Add(Me.ucrInputLegend)
        Me.grpLegendTitle.Controls.Add(Me.rdoLegendTitleCustom)
        Me.grpLegendTitle.Controls.Add(Me.rdoLegendTitleAuto)
        Me.grpLegendTitle.Controls.Add(Me.ucrPnlLegendTitle)
        Me.grpLegendTitle.Location = New System.Drawing.Point(10, 171)
        Me.grpLegendTitle.Name = "grpLegendTitle"
        Me.grpLegendTitle.Size = New System.Drawing.Size(299, 105)
        Me.grpLegendTitle.TabIndex = 8
        Me.grpLegendTitle.TabStop = False
        Me.grpLegendTitle.Text = "Legend Title"
        Me.grpLegendTitle.Visible = False
        '
        'ucrChkOverwriteLegendTitle
        '
        Me.ucrChkOverwriteLegendTitle.Checked = False
        Me.ucrChkOverwriteLegendTitle.Location = New System.Drawing.Point(6, 75)
        Me.ucrChkOverwriteLegendTitle.Name = "ucrChkOverwriteLegendTitle"
        Me.ucrChkOverwriteLegendTitle.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkOverwriteLegendTitle.TabIndex = 14
        '
        'ucrChkDisplayLegendTitle
        '
        Me.ucrChkDisplayLegendTitle.Checked = False
        Me.ucrChkDisplayLegendTitle.Location = New System.Drawing.Point(6, 51)
        Me.ucrChkDisplayLegendTitle.Name = "ucrChkDisplayLegendTitle"
        Me.ucrChkDisplayLegendTitle.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkDisplayLegendTitle.TabIndex = 13
        '
        'ucrInputLegend
        '
        Me.ucrInputLegend.AddQuotesIfUnrecognised = True
        Me.ucrInputLegend.IsMultiline = False
        Me.ucrInputLegend.IsReadOnly = False
        Me.ucrInputLegend.Location = New System.Drawing.Point(133, 74)
        Me.ucrInputLegend.Name = "ucrInputLegend"
        Me.ucrInputLegend.Size = New System.Drawing.Size(160, 21)
        Me.ucrInputLegend.TabIndex = 11
        '
        'rdoLegendTitleCustom
        '
        Me.rdoLegendTitleCustom.AutoSize = True
        Me.rdoLegendTitleCustom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLegendTitleCustom.Location = New System.Drawing.Point(73, 23)
        Me.rdoLegendTitleCustom.Name = "rdoLegendTitleCustom"
        Me.rdoLegendTitleCustom.Size = New System.Drawing.Size(60, 17)
        Me.rdoLegendTitleCustom.TabIndex = 10
        Me.rdoLegendTitleCustom.TabStop = True
        Me.rdoLegendTitleCustom.Text = "Custom"
        Me.rdoLegendTitleCustom.UseVisualStyleBackColor = True
        '
        'rdoLegendTitleAuto
        '
        Me.rdoLegendTitleAuto.AutoSize = True
        Me.rdoLegendTitleAuto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLegendTitleAuto.Location = New System.Drawing.Point(6, 23)
        Me.rdoLegendTitleAuto.Name = "rdoLegendTitleAuto"
        Me.rdoLegendTitleAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoLegendTitleAuto.TabIndex = 9
        Me.rdoLegendTitleAuto.TabStop = True
        Me.rdoLegendTitleAuto.Text = "Auto"
        Me.rdoLegendTitleAuto.UseVisualStyleBackColor = True
        '
        'ucrPnlLegendTitle
        '
        Me.ucrPnlLegendTitle.Location = New System.Drawing.Point(4, 20)
        Me.ucrPnlLegendTitle.Name = "ucrPnlLegendTitle"
        Me.ucrPnlLegendTitle.Size = New System.Drawing.Size(117, 25)
        Me.ucrPnlLegendTitle.TabIndex = 12
        '
        'ucrInputGraphCaption
        '
        Me.ucrInputGraphCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphCaption.IsMultiline = False
        Me.ucrInputGraphCaption.IsReadOnly = False
        Me.ucrInputGraphCaption.Location = New System.Drawing.Point(126, 71)
        Me.ucrInputGraphCaption.Name = "ucrInputGraphCaption"
        Me.ucrInputGraphCaption.Size = New System.Drawing.Size(166, 21)
        Me.ucrInputGraphCaption.TabIndex = 9
        '
        'ucrInputGraphSubTitle
        '
        Me.ucrInputGraphSubTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphSubTitle.IsMultiline = False
        Me.ucrInputGraphSubTitle.IsReadOnly = False
        Me.ucrInputGraphSubTitle.Location = New System.Drawing.Point(126, 44)
        Me.ucrInputGraphSubTitle.Name = "ucrInputGraphSubTitle"
        Me.ucrInputGraphSubTitle.Size = New System.Drawing.Size(166, 21)
        Me.ucrInputGraphSubTitle.TabIndex = 9
        '
        'ucrYAxis
        '
        Me.ucrYAxis.Location = New System.Drawing.Point(0, 1)
        Me.ucrYAxis.Name = "ucrYAxis"
        Me.ucrYAxis.Size = New System.Drawing.Size(496, 329)
        Me.ucrYAxis.TabIndex = 0
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(171, 365)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(160, 41)
        Me.ucrBaseSubdialog.TabIndex = 3
        '
        'ucrChkSameScale
        '
        Me.ucrChkSameScale.Checked = False
        Me.ucrChkSameScale.Location = New System.Drawing.Point(13, 41)
        Me.ucrChkSameScale.Name = "ucrChkSameScale"
        Me.ucrChkSameScale.Size = New System.Drawing.Size(233, 20)
        Me.ucrChkSameScale.TabIndex = 15
        '
        'grpPolarCordinates
        '
        Me.grpPolarCordinates.Controls.Add(Me.ucrInputPolarCoordinates)
        Me.grpPolarCordinates.Controls.Add(Me.lblPolarCoordinate)
        Me.grpPolarCordinates.Controls.Add(Me.lblStartingAngle)
        Me.grpPolarCordinates.Controls.Add(Me.ucrChkUsePolarCoordinates)
        Me.grpPolarCordinates.Controls.Add(Me.lblPi)
        Me.grpPolarCordinates.Controls.Add(Me.ucrChkDirectionAnticlockwise)
        Me.grpPolarCordinates.Controls.Add(Me.ucrInputStartingAngle)
        Me.grpPolarCordinates.Location = New System.Drawing.Point(3, 67)
        Me.grpPolarCordinates.Name = "grpPolarCordinates"
        Me.grpPolarCordinates.Size = New System.Drawing.Size(300, 136)
        Me.grpPolarCordinates.TabIndex = 22
        Me.grpPolarCordinates.TabStop = False
        Me.grpPolarCordinates.Text = "Polar Cordinates"
        '
        'ucrInputPolarCoordinates
        '
        Me.ucrInputPolarCoordinates.AddQuotesIfUnrecognised = True
        Me.ucrInputPolarCoordinates.GetSetSelectedIndex = -1
        Me.ucrInputPolarCoordinates.IsReadOnly = False
        Me.ucrInputPolarCoordinates.Location = New System.Drawing.Point(103, 43)
        Me.ucrInputPolarCoordinates.Name = "ucrInputPolarCoordinates"
        Me.ucrInputPolarCoordinates.Size = New System.Drawing.Size(65, 21)
        Me.ucrInputPolarCoordinates.TabIndex = 24
        '
        'lblPolarCoordinate
        '
        Me.lblPolarCoordinate.AutoSize = True
        Me.lblPolarCoordinate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPolarCoordinate.Location = New System.Drawing.Point(10, 46)
        Me.lblPolarCoordinate.Name = "lblPolarCoordinate"
        Me.lblPolarCoordinate.Size = New System.Drawing.Size(88, 13)
        Me.lblPolarCoordinate.TabIndex = 23
        Me.lblPolarCoordinate.Text = "Polar Coordinate:"
        '
        'lblStartingAngle
        '
        Me.lblStartingAngle.AutoSize = True
        Me.lblStartingAngle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStartingAngle.Location = New System.Drawing.Point(10, 99)
        Me.lblStartingAngle.Name = "lblStartingAngle"
        Me.lblStartingAngle.Size = New System.Drawing.Size(76, 13)
        Me.lblStartingAngle.TabIndex = 22
        Me.lblStartingAngle.Text = "Starting Angle:"
        '
        'ucrChkUsePolarCoordinates
        '
        Me.ucrChkUsePolarCoordinates.Checked = False
        Me.ucrChkUsePolarCoordinates.Location = New System.Drawing.Point(12, 19)
        Me.ucrChkUsePolarCoordinates.Name = "ucrChkUsePolarCoordinates"
        Me.ucrChkUsePolarCoordinates.Size = New System.Drawing.Size(147, 20)
        Me.ucrChkUsePolarCoordinates.TabIndex = 16
        '
        'lblPi
        '
        Me.lblPi.AutoSize = True
        Me.lblPi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPi.Location = New System.Drawing.Point(138, 100)
        Me.lblPi.Name = "lblPi"
        Me.lblPi.Size = New System.Drawing.Size(15, 13)
        Me.lblPi.TabIndex = 21
        Me.lblPi.Tag = ""
        Me.lblPi.Text = "pi"
        '
        'ucrChkDirectionAnticlockwise
        '
        Me.ucrChkDirectionAnticlockwise.Checked = False
        Me.ucrChkDirectionAnticlockwise.Location = New System.Drawing.Point(12, 70)
        Me.ucrChkDirectionAnticlockwise.Name = "ucrChkDirectionAnticlockwise"
        Me.ucrChkDirectionAnticlockwise.Size = New System.Drawing.Size(155, 20)
        Me.ucrChkDirectionAnticlockwise.TabIndex = 17
        '
        'ucrInputStartingAngle
        '
        Me.ucrInputStartingAngle.AddQuotesIfUnrecognised = True
        Me.ucrInputStartingAngle.IsMultiline = False
        Me.ucrInputStartingAngle.IsReadOnly = False
        Me.ucrInputStartingAngle.Location = New System.Drawing.Point(92, 95)
        Me.ucrInputStartingAngle.Name = "ucrInputStartingAngle"
        Me.ucrInputStartingAngle.Size = New System.Drawing.Size(43, 21)
        Me.ucrInputStartingAngle.TabIndex = 19
        '
        'tbpCoordinates
        '
        Me.tbpCoordinates.Controls.Add(Me.grpPolarCordinates)
        Me.tbpCoordinates.Controls.Add(Me.ucrChkSameScale)
        Me.tbpCoordinates.Controls.Add(Me.ucrChkHorizontalPlot)
        Me.tbpCoordinates.Location = New System.Drawing.Point(4, 22)
        Me.tbpCoordinates.Name = "tbpCoordinates"
        Me.tbpCoordinates.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCoordinates.Size = New System.Drawing.Size(192, 74)
        Me.tbpCoordinates.TabIndex = 7
        Me.tbpCoordinates.Text = "Coordinates"
        Me.tbpCoordinates.UseVisualStyleBackColor = True
        '
        'ucrChkHorizontalPlot
        '
        Me.ucrChkHorizontalPlot.Checked = False
        Me.ucrChkHorizontalPlot.Location = New System.Drawing.Point(13, 15)
        Me.ucrChkHorizontalPlot.Name = "ucrChkHorizontalPlot"
        Me.ucrChkHorizontalPlot.Size = New System.Drawing.Size(233, 20)
        Me.ucrChkHorizontalPlot.TabIndex = 14
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        Me.ucrInputGraphTitle.Location = New System.Drawing.Point(126, 17)
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        Me.ucrInputGraphTitle.Size = New System.Drawing.Size(166, 21)
        Me.ucrInputGraphTitle.TabIndex = 9
        '
        'tbpFacet
        '
        Me.tbpFacet.Controls.Add(Me.ucrChkDrop)
        Me.tbpFacet.Controls.Add(Me.ucrNudNumberofRows)
        Me.tbpFacet.Controls.Add(Me.ucrChkNoOfRowsOrColumns)
        Me.tbpFacet.Controls.Add(Me.ucrChkIncludeFacets)
        Me.tbpFacet.Controls.Add(Me.ucrChkLabeler)
        Me.tbpFacet.Controls.Add(Me.ucrChkFreeSpace)
        Me.tbpFacet.Controls.Add(Me.ucrChkFreeScalesY)
        Me.tbpFacet.Controls.Add(Me.ucrChkFreeScalesX)
        Me.tbpFacet.Controls.Add(Me.ucrChkMargin)
        Me.tbpFacet.Controls.Add(Me.ucrFacetSelector)
        Me.tbpFacet.Controls.Add(Me.rdoHorizontal)
        Me.tbpFacet.Controls.Add(Me.rdoVertical)
        Me.tbpFacet.Controls.Add(Me.lblFactor2)
        Me.tbpFacet.Controls.Add(Me.lblFactor1)
        Me.tbpFacet.Controls.Add(Me.ucr2ndFactorReceiver)
        Me.tbpFacet.Controls.Add(Me.ucr1stFactorReceiver)
        Me.tbpFacet.Controls.Add(Me.ucrPnlHorizonatalVertical)
        Me.tbpFacet.Location = New System.Drawing.Point(4, 22)
        Me.tbpFacet.Name = "tbpFacet"
        Me.tbpFacet.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFacet.Size = New System.Drawing.Size(499, 330)
        Me.tbpFacet.TabIndex = 3
        Me.tbpFacet.Tag = "Facet"
        Me.tbpFacet.Text = "Facets"
        Me.tbpFacet.UseVisualStyleBackColor = True
        '
        'ucrChkDrop
        '
        Me.ucrChkDrop.Checked = False
        Me.ucrChkDrop.Location = New System.Drawing.Point(273, 269)
        Me.ucrChkDrop.Name = "ucrChkDrop"
        Me.ucrChkDrop.Size = New System.Drawing.Size(156, 20)
        Me.ucrChkDrop.TabIndex = 11
        '
        'ucrNudNumberofRows
        '
        Me.ucrNudNumberofRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberofRows.Location = New System.Drawing.Point(169, 252)
        Me.ucrNudNumberofRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRows.Name = "ucrNudNumberofRows"
        Me.ucrNudNumberofRows.Size = New System.Drawing.Size(46, 20)
        Me.ucrNudNumberofRows.TabIndex = 15
        Me.ucrNudNumberofRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkNoOfRowsOrColumns
        '
        Me.ucrChkNoOfRowsOrColumns.Checked = False
        Me.ucrChkNoOfRowsOrColumns.Location = New System.Drawing.Point(7, 254)
        Me.ucrChkNoOfRowsOrColumns.Name = "ucrChkNoOfRowsOrColumns"
        Me.ucrChkNoOfRowsOrColumns.Size = New System.Drawing.Size(156, 20)
        Me.ucrChkNoOfRowsOrColumns.TabIndex = 14
        '
        'ucrChkIncludeFacets
        '
        Me.ucrChkIncludeFacets.Checked = False
        Me.ucrChkIncludeFacets.Location = New System.Drawing.Point(8, 13)
        Me.ucrChkIncludeFacets.Name = "ucrChkIncludeFacets"
        Me.ucrChkIncludeFacets.Size = New System.Drawing.Size(121, 20)
        Me.ucrChkIncludeFacets.TabIndex = 0
        '
        'ucrChkLabeler
        '
        Me.ucrChkLabeler.Checked = False
        Me.ucrChkLabeler.Location = New System.Drawing.Point(273, 245)
        Me.ucrChkLabeler.Name = "ucrChkLabeler"
        Me.ucrChkLabeler.Size = New System.Drawing.Size(220, 20)
        Me.ucrChkLabeler.TabIndex = 10
        '
        'ucrChkFreeSpace
        '
        Me.ucrChkFreeSpace.Checked = False
        Me.ucrChkFreeSpace.Location = New System.Drawing.Point(273, 221)
        Me.ucrChkFreeSpace.Name = "ucrChkFreeSpace"
        Me.ucrChkFreeSpace.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFreeSpace.TabIndex = 9
        '
        'ucrChkFreeScalesY
        '
        Me.ucrChkFreeScalesY.Checked = False
        Me.ucrChkFreeScalesY.Location = New System.Drawing.Point(273, 197)
        Me.ucrChkFreeScalesY.Name = "ucrChkFreeScalesY"
        Me.ucrChkFreeScalesY.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFreeScalesY.TabIndex = 8
        '
        'ucrChkFreeScalesX
        '
        Me.ucrChkFreeScalesX.Checked = False
        Me.ucrChkFreeScalesX.Location = New System.Drawing.Point(273, 173)
        Me.ucrChkFreeScalesX.Name = "ucrChkFreeScalesX"
        Me.ucrChkFreeScalesX.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFreeScalesX.TabIndex = 7
        '
        'ucrChkMargin
        '
        Me.ucrChkMargin.Checked = False
        Me.ucrChkMargin.Location = New System.Drawing.Point(273, 149)
        Me.ucrChkMargin.Name = "ucrChkMargin"
        Me.ucrChkMargin.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMargin.TabIndex = 6
        '
        'ucrFacetSelector
        '
        Me.ucrFacetSelector.bDropUnusedFilterLevels = False
        Me.ucrFacetSelector.bShowHiddenColumns = False
        Me.ucrFacetSelector.bUseCurrentFilter = True
        Me.ucrFacetSelector.Location = New System.Drawing.Point(8, 36)
        Me.ucrFacetSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFacetSelector.Name = "ucrFacetSelector"
        Me.ucrFacetSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrFacetSelector.TabIndex = 1
        '
        'rdoHorizontal
        '
        Me.rdoHorizontal.AutoSize = True
        Me.rdoHorizontal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHorizontal.Location = New System.Drawing.Point(8, 230)
        Me.rdoHorizontal.Name = "rdoHorizontal"
        Me.rdoHorizontal.Size = New System.Drawing.Size(72, 17)
        Me.rdoHorizontal.TabIndex = 12
        Me.rdoHorizontal.TabStop = True
        Me.rdoHorizontal.Tag = "Horizontal"
        Me.rdoHorizontal.Text = "Horizontal"
        Me.rdoHorizontal.UseVisualStyleBackColor = True
        '
        'rdoVertical
        '
        Me.rdoVertical.AutoSize = True
        Me.rdoVertical.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoVertical.Location = New System.Drawing.Point(104, 230)
        Me.rdoVertical.Name = "rdoVertical"
        Me.rdoVertical.Size = New System.Drawing.Size(60, 17)
        Me.rdoVertical.TabIndex = 13
        Me.rdoVertical.TabStop = True
        Me.rdoVertical.Tag = "Vertical"
        Me.rdoVertical.Text = "Vertical"
        Me.rdoVertical.UseVisualStyleBackColor = True
        '
        'lblFactor2
        '
        Me.lblFactor2.AutoSize = True
        Me.lblFactor2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactor2.Location = New System.Drawing.Point(274, 99)
        Me.lblFactor2.Name = "lblFactor2"
        Me.lblFactor2.Size = New System.Drawing.Size(109, 13)
        Me.lblFactor2.TabIndex = 4
        Me.lblFactor2.Text = "2nd Factor (Optional):"
        '
        'lblFactor1
        '
        Me.lblFactor1.AutoSize = True
        Me.lblFactor1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactor1.Location = New System.Drawing.Point(272, 44)
        Me.lblFactor1.Name = "lblFactor1"
        Me.lblFactor1.Size = New System.Drawing.Size(57, 13)
        Me.lblFactor1.TabIndex = 2
        Me.lblFactor1.Tag = ""
        Me.lblFactor1.Text = "1st Factor:"
        '
        'ucr2ndFactorReceiver
        '
        Me.ucr2ndFactorReceiver.frmParent = Nothing
        Me.ucr2ndFactorReceiver.Location = New System.Drawing.Point(273, 114)
        Me.ucr2ndFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr2ndFactorReceiver.Name = "ucr2ndFactorReceiver"
        Me.ucr2ndFactorReceiver.Selector = Nothing
        Me.ucr2ndFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucr2ndFactorReceiver.strNcFilePath = ""
        Me.ucr2ndFactorReceiver.TabIndex = 5
        Me.ucr2ndFactorReceiver.ucrSelector = Nothing
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.frmParent = Nothing
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(273, 59)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.TabIndex = 3
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'ucrPnlHorizonatalVertical
        '
        Me.ucrPnlHorizonatalVertical.Location = New System.Drawing.Point(8, 228)
        Me.ucrPnlHorizonatalVertical.Name = "ucrPnlHorizonatalVertical"
        Me.ucrPnlHorizonatalVertical.Size = New System.Drawing.Size(165, 20)
        Me.ucrPnlHorizonatalVertical.TabIndex = 30
        '
        'tbpPlotsOptions
        '
        Me.tbpPlotsOptions.Controls.Add(Me.tbpFacet)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpLayers)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpTitles)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpXAxis)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpYAxis)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpTheme)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpCoordinates)
        Me.tbpPlotsOptions.Location = New System.Drawing.Point(8, 3)
        Me.tbpPlotsOptions.Name = "tbpPlotsOptions"
        Me.tbpPlotsOptions.SelectedIndex = 0
        Me.tbpPlotsOptions.Size = New System.Drawing.Size(507, 356)
        Me.tbpPlotsOptions.TabIndex = 2
        '
        'tbpLayers
        '
        Me.tbpLayers.Controls.Add(Me.ucrPlotsAdditionalLayers)
        Me.tbpLayers.Location = New System.Drawing.Point(4, 22)
        Me.tbpLayers.Name = "tbpLayers"
        Me.tbpLayers.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLayers.Size = New System.Drawing.Size(499, 330)
        Me.tbpLayers.TabIndex = 4
        Me.tbpLayers.Tag = "Layers"
        Me.tbpLayers.Text = "Layers"
        Me.tbpLayers.UseVisualStyleBackColor = True
        '
        'ucrPlotsAdditionalLayers
        '
        Me.ucrPlotsAdditionalLayers.Location = New System.Drawing.Point(7, 6)
        Me.ucrPlotsAdditionalLayers.Name = "ucrPlotsAdditionalLayers"
        Me.ucrPlotsAdditionalLayers.Size = New System.Drawing.Size(218, 191)
        Me.ucrPlotsAdditionalLayers.TabIndex = 0
        '
        'tbpTitles
        '
        Me.tbpTitles.Controls.Add(Me.lblCaption)
        Me.tbpTitles.Controls.Add(Me.lblSubTitle)
        Me.tbpTitles.Controls.Add(Me.Label1)
        Me.tbpTitles.Controls.Add(Me.grpLegendTitle)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphCaption)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphSubTitle)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphTitle)
        Me.tbpTitles.Location = New System.Drawing.Point(4, 22)
        Me.tbpTitles.Name = "tbpTitles"
        Me.tbpTitles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTitles.Size = New System.Drawing.Size(499, 330)
        Me.tbpTitles.TabIndex = 2
        Me.tbpTitles.Tag = "Titles"
        Me.tbpTitles.Text = "Titles"
        Me.tbpTitles.UseVisualStyleBackColor = True
        '
        'tbpXAxis
        '
        Me.tbpXAxis.Controls.Add(Me.ucrXAxis)
        Me.tbpXAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbpXAxis.Name = "tbpXAxis"
        Me.tbpXAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpXAxis.Size = New System.Drawing.Size(499, 330)
        Me.tbpXAxis.TabIndex = 5
        Me.tbpXAxis.Text = "X-Axis"
        Me.tbpXAxis.UseVisualStyleBackColor = True
        '
        'ucrXAxis
        '
        Me.ucrXAxis.Location = New System.Drawing.Point(0, 1)
        Me.ucrXAxis.Name = "ucrXAxis"
        Me.ucrXAxis.Size = New System.Drawing.Size(512, 322)
        Me.ucrXAxis.TabIndex = 0
        '
        'tbpYAxis
        '
        Me.tbpYAxis.Controls.Add(Me.ucrYAxis)
        Me.tbpYAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbpYAxis.Name = "tbpYAxis"
        Me.tbpYAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpYAxis.Size = New System.Drawing.Size(499, 330)
        Me.tbpYAxis.TabIndex = 6
        Me.tbpYAxis.Text = "Y-Axis"
        Me.tbpYAxis.UseVisualStyleBackColor = True
        '
        'sdgCircularDensityPlotsOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 399)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.tbpPlotsOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCircularDensityPlotsOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plots Options"
        Me.tbpTheme.ResumeLayout(False)
        Me.tbpTheme.PerformLayout()
        Me.grpCommonOptions.ResumeLayout(False)
        Me.grpLegendTitle.ResumeLayout(False)
        Me.grpLegendTitle.PerformLayout()
        Me.grpPolarCordinates.ResumeLayout(False)
        Me.grpPolarCordinates.PerformLayout()
        Me.tbpCoordinates.ResumeLayout(False)
        Me.tbpFacet.ResumeLayout(False)
        Me.tbpFacet.PerformLayout()
        Me.tbpPlotsOptions.ResumeLayout(False)
        Me.tbpLayers.ResumeLayout(False)
        Me.tbpTitles.ResumeLayout(False)
        Me.tbpTitles.PerformLayout()
        Me.tbpXAxis.ResumeLayout(False)
        Me.tbpYAxis.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbpTheme As TabPage
    Friend WithEvents cmdSimpleOptions As Button
    Friend WithEvents urChkSelectTheme As ucrCheck
    Friend WithEvents grpCommonOptions As GroupBox
    Friend WithEvents ucrNudYaxisMarkSize As ucrNud
    Friend WithEvents ucrNudXaxisMarkSize As ucrNud
    Friend WithEvents ucrNudYSize As ucrNud
    Friend WithEvents ucrNudXSize As ucrNud
    Friend WithEvents ucrNudXAngle As ucrNud
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrChkYaxisTickMarkLabelSize As ucrCheck
    Friend WithEvents ucrChkXaxisTickMarkLabelSize As ucrCheck
    Friend WithEvents ucrChkYaxisSize As ucrCheck
    Friend WithEvents ucrChkXaxisSize As ucrCheck
    Friend WithEvents ucrChkXaxisAngle As ucrCheck
    Friend WithEvents ucrChkLegendPosition As ucrCheck
    Friend WithEvents lblFont As Label
    Friend WithEvents cmdAllOptions As Button
    Friend WithEvents ucrInputThemes As ucrInputComboBox
    Friend WithEvents lblCaption As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpLegendTitle As GroupBox
    Friend WithEvents ucrChkOverwriteLegendTitle As ucrCheck
    Friend WithEvents ucrChkDisplayLegendTitle As ucrCheck
    Friend WithEvents ucrInputLegend As ucrInputTextBox
    Friend WithEvents rdoLegendTitleCustom As RadioButton
    Friend WithEvents rdoLegendTitleAuto As RadioButton
    Friend WithEvents ucrPnlLegendTitle As UcrPanel
    Friend WithEvents ucrInputGraphCaption As ucrInputTextBox
    Friend WithEvents ucrInputGraphSubTitle As ucrInputTextBox
    Friend WithEvents ucrYAxis As ucrAxes
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents ucrChkSameScale As ucrCheck
    Friend WithEvents grpPolarCordinates As GroupBox
    Friend WithEvents ucrInputPolarCoordinates As ucrInputComboBox
    Friend WithEvents lblPolarCoordinate As Label
    Friend WithEvents lblStartingAngle As Label
    Friend WithEvents ucrChkUsePolarCoordinates As ucrCheck
    Friend WithEvents lblPi As Label
    Friend WithEvents ucrChkDirectionAnticlockwise As ucrCheck
    Friend WithEvents ucrInputStartingAngle As ucrInputTextBox
    Friend WithEvents tbpCoordinates As TabPage
    Friend WithEvents ucrChkHorizontalPlot As ucrCheck
    Friend WithEvents ucrInputGraphTitle As ucrInputTextBox
    Friend WithEvents tbpFacet As TabPage
    Friend WithEvents ucrChkDrop As ucrCheck
    Friend WithEvents ucrNudNumberofRows As ucrNud
    Friend WithEvents ucrChkNoOfRowsOrColumns As ucrCheck
    Friend WithEvents ucrChkIncludeFacets As ucrCheck
    Friend WithEvents ucrChkLabeler As ucrCheck
    Friend WithEvents ucrChkFreeSpace As ucrCheck
    Friend WithEvents ucrChkFreeScalesY As ucrCheck
    Friend WithEvents ucrChkFreeScalesX As ucrCheck
    Friend WithEvents ucrChkMargin As ucrCheck
    Friend WithEvents ucrFacetSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoHorizontal As RadioButton
    Friend WithEvents rdoVertical As RadioButton
    Friend WithEvents lblFactor2 As Label
    Friend WithEvents lblFactor1 As Label
    Friend WithEvents ucr2ndFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucrPnlHorizonatalVertical As UcrPanel
    Friend WithEvents tbpPlotsOptions As TabControl
    Friend WithEvents tbpLayers As TabPage
    Friend WithEvents ucrPlotsAdditionalLayers As ucrAdditionalLayers
    Friend WithEvents tbpTitles As TabPage
    Friend WithEvents tbpXAxis As TabPage
    Friend WithEvents ucrXAxis As ucrAxes
    Friend WithEvents tbpYAxis As TabPage
End Class
