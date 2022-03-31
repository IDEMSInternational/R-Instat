<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticCheckDataTemperature
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
        Me.components = New System.ComponentModel.Container()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblElement1 = New System.Windows.Forms.Label()
        Me.lblRangeElement1to = New System.Windows.Forms.Label()
        Me.lblRangeElement2to = New System.Windows.Forms.Label()
        Me.lblElement2 = New System.Windows.Forms.Label()
        Me.rdoIndividual = New System.Windows.Forms.RadioButton()
        Me.rdoMultiple = New System.Windows.Forms.RadioButton()
        Me.lblNudSame = New System.Windows.Forms.Label()
        Me.ttOutliers = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblCoeff = New System.Windows.Forms.Label()
        Me.grpLogicalCalculatedColumns = New System.Windows.Forms.GroupBox()
        Me.ucrChkIncludeCalculatedColumns = New instat.ucrCheck()
        Me.ttMultiple = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrNudCoeff = New instat.ucrNud()
        Me.ucrChkIncludeLogicalColumns = New instat.ucrCheck()
        Me.ucrChkRangeElement2 = New instat.ucrCheck()
        Me.ucrReceiverElement2 = New instat.ucrReceiverSingle()
        Me.ucrNudJump = New instat.ucrNud()
        Me.ucrChkRangeElement1 = New instat.ucrCheck()
        Me.ucrNudSame = New instat.ucrNud()
        Me.ucrNudDifference = New instat.ucrNud()
        Me.ucrChkOutlier = New instat.ucrCheck()
        Me.ucrChkSame = New instat.ucrCheck()
        Me.ucrChkJump = New instat.ucrCheck()
        Me.ucrChkDifference = New instat.ucrCheck()
        Me.ucrReceiverElement1 = New instat.ucrReceiverSingle()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorTemperature = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlType = New instat.UcrPanel()
        Me.ucrInputRangeElement1Min = New instat.ucrInputTextBox()
        Me.ucrInputRangeElement1Max = New instat.ucrInputTextBox()
        Me.ucrInputRangeElement2Min = New instat.ucrInputTextBox()
        Me.ucrInputRangeElement2Max = New instat.ucrInputTextBox()
        Me.lblRangeElement1From = New System.Windows.Forms.Label()
        Me.lblRangeElement2From = New System.Windows.Forms.Label()
        Me.grpLogicalCalculatedColumns.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(349, 83)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 6
        Me.lblStation.Text = "Station:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(349, 131)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(349, 178)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 10
        Me.lblYear.Text = "Year:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonth.Location = New System.Drawing.Point(349, 223)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 12
        Me.lblMonth.Text = "Month:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDay.Location = New System.Drawing.Point(349, 271)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(29, 13)
        Me.lblDay.TabIndex = 14
        Me.lblDay.Text = "Day:"
        '
        'lblElement1
        '
        Me.lblElement1.AutoSize = True
        Me.lblElement1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement1.Location = New System.Drawing.Point(349, 317)
        Me.lblElement1.Name = "lblElement1"
        Me.lblElement1.Size = New System.Drawing.Size(89, 13)
        Me.lblElement1.TabIndex = 16
        Me.lblElement1.Text = "Element1 (Tmax):"
        '
        'lblRangeElement1to
        '
        Me.lblRangeElement1to.AutoSize = True
        Me.lblRangeElement1to.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRangeElement1to.Location = New System.Drawing.Point(272, 268)
        Me.lblRangeElement1to.Name = "lblRangeElement1to"
        Me.lblRangeElement1to.Size = New System.Drawing.Size(23, 13)
        Me.lblRangeElement1to.TabIndex = 23
        Me.lblRangeElement1to.Text = "To:"
        '
        'lblRangeElement2to
        '
        Me.lblRangeElement2to.AutoSize = True
        Me.lblRangeElement2to.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRangeElement2to.Location = New System.Drawing.Point(273, 297)
        Me.lblRangeElement2to.Name = "lblRangeElement2to"
        Me.lblRangeElement2to.Size = New System.Drawing.Size(23, 13)
        Me.lblRangeElement2to.TabIndex = 29
        Me.lblRangeElement2to.Text = "To:"
        '
        'lblElement2
        '
        Me.lblElement2.AutoSize = True
        Me.lblElement2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement2.Location = New System.Drawing.Point(349, 365)
        Me.lblElement2.Name = "lblElement2"
        Me.lblElement2.Size = New System.Drawing.Size(86, 13)
        Me.lblElement2.TabIndex = 18
        Me.lblElement2.Text = "Element2 (Tmin):"
        '
        'rdoIndividual
        '
        Me.rdoIndividual.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoIndividual.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoIndividual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIndividual.FlatAppearance.BorderSize = 2
        Me.rdoIndividual.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoIndividual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoIndividual.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoIndividual.Location = New System.Drawing.Point(147, 24)
        Me.rdoIndividual.Name = "rdoIndividual"
        Me.rdoIndividual.Size = New System.Drawing.Size(91, 28)
        Me.rdoIndividual.TabIndex = 2
        Me.rdoIndividual.Text = "Individual"
        Me.rdoIndividual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoIndividual.UseVisualStyleBackColor = True
        '
        'rdoMultiple
        '
        Me.rdoMultiple.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMultiple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoMultiple.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMultiple.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatAppearance.BorderSize = 2
        Me.rdoMultiple.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMultiple.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoMultiple.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMultiple.Location = New System.Drawing.Point(236, 24)
        Me.rdoMultiple.Name = "rdoMultiple"
        Me.rdoMultiple.Size = New System.Drawing.Size(91, 28)
        Me.rdoMultiple.TabIndex = 3
        Me.rdoMultiple.Text = "Multiple"
        Me.rdoMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMultiple.UseVisualStyleBackColor = True
        '
        'lblNudSame
        '
        Me.lblNudSame.AutoSize = True
        Me.lblNudSame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNudSame.Location = New System.Drawing.Point(238, 328)
        Me.lblNudSame.Name = "lblNudSame"
        Me.lblNudSame.Size = New System.Drawing.Size(29, 13)
        Me.lblNudSame.TabIndex = 34
        Me.lblNudSame.Text = "days"
        '
        'lblCoeff
        '
        Me.lblCoeff.AutoSize = True
        Me.lblCoeff.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCoeff.Location = New System.Drawing.Point(143, 426)
        Me.lblCoeff.Name = "lblCoeff"
        Me.lblCoeff.Size = New System.Drawing.Size(32, 13)
        Me.lblCoeff.TabIndex = 42
        Me.lblCoeff.Text = "Coef:"
        '
        'grpLogicalCalculatedColumns
        '
        Me.grpLogicalCalculatedColumns.Controls.Add(Me.ucrChkIncludeCalculatedColumns)
        Me.grpLogicalCalculatedColumns.Location = New System.Drawing.Point(10, 444)
        Me.grpLogicalCalculatedColumns.Name = "grpLogicalCalculatedColumns"
        Me.grpLogicalCalculatedColumns.Size = New System.Drawing.Size(459, 53)
        Me.grpLogicalCalculatedColumns.TabIndex = 46
        Me.grpLogicalCalculatedColumns.TabStop = False
        Me.grpLogicalCalculatedColumns.Text = "Include in Original Data"
        '
        'ucrChkIncludeCalculatedColumns
        '
        Me.ucrChkIncludeCalculatedColumns.AutoSize = True
        Me.ucrChkIncludeCalculatedColumns.Checked = False
        Me.ucrChkIncludeCalculatedColumns.Location = New System.Drawing.Point(217, 22)
        Me.ucrChkIncludeCalculatedColumns.Name = "ucrChkIncludeCalculatedColumns"
        Me.ucrChkIncludeCalculatedColumns.Size = New System.Drawing.Size(204, 23)
        Me.ucrChkIncludeCalculatedColumns.TabIndex = 45
        '
        'ttMultiple
        '
        Me.ttMultiple.AutoPopDelay = 10000
        Me.ttMultiple.InitialDelay = 500
        Me.ttMultiple.ReshowDelay = 100
        '
        'ucrNudCoeff
        '
        Me.ucrNudCoeff.AutoSize = True
        Me.ucrNudCoeff.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCoeff.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCoeff.Location = New System.Drawing.Point(184, 422)
        Me.ucrNudCoeff.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCoeff.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCoeff.Name = "ucrNudCoeff"
        Me.ucrNudCoeff.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCoeff.TabIndex = 43
        Me.ucrNudCoeff.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkIncludeLogicalColumns
        '
        Me.ucrChkIncludeLogicalColumns.AutoSize = True
        Me.ucrChkIncludeLogicalColumns.Checked = False
        Me.ucrChkIncludeLogicalColumns.Location = New System.Drawing.Point(19, 466)
        Me.ucrChkIncludeLogicalColumns.Name = "ucrChkIncludeLogicalColumns"
        Me.ucrChkIncludeLogicalColumns.Size = New System.Drawing.Size(201, 23)
        Me.ucrChkIncludeLogicalColumns.TabIndex = 44
        '
        'ucrChkRangeElement2
        '
        Me.ucrChkRangeElement2.AutoSize = True
        Me.ucrChkRangeElement2.Checked = False
        Me.ucrChkRangeElement2.Location = New System.Drawing.Point(10, 293)
        Me.ucrChkRangeElement2.Name = "ucrChkRangeElement2"
        Me.ucrChkRangeElement2.Size = New System.Drawing.Size(165, 23)
        Me.ucrChkRangeElement2.TabIndex = 26
        '
        'ucrReceiverElement2
        '
        Me.ucrReceiverElement2.AutoSize = True
        Me.ucrReceiverElement2.frmParent = Me
        Me.ucrReceiverElement2.Location = New System.Drawing.Point(349, 381)
        Me.ucrReceiverElement2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement2.Name = "ucrReceiverElement2"
        Me.ucrReceiverElement2.Selector = Nothing
        Me.ucrReceiverElement2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement2.strNcFilePath = ""
        Me.ucrReceiverElement2.TabIndex = 19
        Me.ucrReceiverElement2.ucrSelector = Nothing
        '
        'ucrNudJump
        '
        Me.ucrNudJump.AutoSize = True
        Me.ucrNudJump.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJump.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudJump.Location = New System.Drawing.Point(184, 356)
        Me.ucrNudJump.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudJump.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJump.Name = "ucrNudJump"
        Me.ucrNudJump.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudJump.TabIndex = 36
        Me.ucrNudJump.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkRangeElement1
        '
        Me.ucrChkRangeElement1.AutoSize = True
        Me.ucrChkRangeElement1.Checked = False
        Me.ucrChkRangeElement1.Location = New System.Drawing.Point(10, 264)
        Me.ucrChkRangeElement1.Name = "ucrChkRangeElement1"
        Me.ucrChkRangeElement1.Size = New System.Drawing.Size(165, 23)
        Me.ucrChkRangeElement1.TabIndex = 20
        '
        'ucrNudSame
        '
        Me.ucrNudSame.AutoSize = True
        Me.ucrNudSame.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSame.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSame.Location = New System.Drawing.Point(184, 324)
        Me.ucrNudSame.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSame.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSame.Name = "ucrNudSame"
        Me.ucrNudSame.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSame.TabIndex = 33
        Me.ucrNudSame.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDifference
        '
        Me.ucrNudDifference.AutoSize = True
        Me.ucrNudDifference.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDifference.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDifference.Location = New System.Drawing.Point(184, 389)
        Me.ucrNudDifference.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDifference.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDifference.Name = "ucrNudDifference"
        Me.ucrNudDifference.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDifference.TabIndex = 39
        Me.ucrNudDifference.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkOutlier
        '
        Me.ucrChkOutlier.AutoSize = True
        Me.ucrChkOutlier.Checked = False
        Me.ucrChkOutlier.Location = New System.Drawing.Point(10, 422)
        Me.ucrChkOutlier.Name = "ucrChkOutlier"
        Me.ucrChkOutlier.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkOutlier.TabIndex = 41
        '
        'ucrChkSame
        '
        Me.ucrChkSame.AutoSize = True
        Me.ucrChkSame.Checked = False
        Me.ucrChkSame.Location = New System.Drawing.Point(10, 324)
        Me.ucrChkSame.Name = "ucrChkSame"
        Me.ucrChkSame.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSame.TabIndex = 32
        '
        'ucrChkJump
        '
        Me.ucrChkJump.AutoSize = True
        Me.ucrChkJump.Checked = False
        Me.ucrChkJump.Location = New System.Drawing.Point(10, 356)
        Me.ucrChkJump.Name = "ucrChkJump"
        Me.ucrChkJump.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkJump.TabIndex = 35
        '
        'ucrChkDifference
        '
        Me.ucrChkDifference.AutoSize = True
        Me.ucrChkDifference.Checked = False
        Me.ucrChkDifference.Location = New System.Drawing.Point(10, 389)
        Me.ucrChkDifference.Name = "ucrChkDifference"
        Me.ucrChkDifference.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkDifference.TabIndex = 38
        '
        'ucrReceiverElement1
        '
        Me.ucrReceiverElement1.AutoSize = True
        Me.ucrReceiverElement1.frmParent = Me
        Me.ucrReceiverElement1.Location = New System.Drawing.Point(349, 334)
        Me.ucrReceiverElement1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement1.Name = "ucrReceiverElement1"
        Me.ucrReceiverElement1.Selector = Nothing
        Me.ucrReceiverElement1.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement1.strNcFilePath = ""
        Me.ucrReceiverElement1.TabIndex = 17
        Me.ucrReceiverElement1.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.AutoSize = True
        Me.ucrReceiverDay.frmParent = Me
        Me.ucrReceiverDay.Location = New System.Drawing.Point(349, 287)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.TabIndex = 15
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.AutoSize = True
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(349, 240)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 13
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(349, 193)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 11
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(349, 146)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 9
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(349, 99)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 7
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorTemperature
        '
        Me.ucrSelectorTemperature.AutoSize = True
        Me.ucrSelectorTemperature.bDropUnusedFilterLevels = False
        Me.ucrSelectorTemperature.bShowHiddenColumns = False
        Me.ucrSelectorTemperature.bUseCurrentFilter = True
        Me.ucrSelectorTemperature.Location = New System.Drawing.Point(10, 76)
        Me.ucrSelectorTemperature.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTemperature.Name = "ucrSelectorTemperature"
        Me.ucrSelectorTemperature.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorTemperature.TabIndex = 5
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 503)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrPnlType
        '
        Me.ucrPnlType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlType.Location = New System.Drawing.Point(132, 9)
        Me.ucrPnlType.Name = "ucrPnlType"
        Me.ucrPnlType.Size = New System.Drawing.Size(212, 60)
        Me.ucrPnlType.TabIndex = 0
        '
        'ucrInputRangeElement1Min
        '
        Me.ucrInputRangeElement1Min.AddQuotesIfUnrecognised = True
        Me.ucrInputRangeElement1Min.AutoSize = True
        Me.ucrInputRangeElement1Min.IsMultiline = False
        Me.ucrInputRangeElement1Min.IsReadOnly = False
        Me.ucrInputRangeElement1Min.Location = New System.Drawing.Point(221, 264)
        Me.ucrInputRangeElement1Min.Name = "ucrInputRangeElement1Min"
        Me.ucrInputRangeElement1Min.Size = New System.Drawing.Size(44, 21)
        Me.ucrInputRangeElement1Min.TabIndex = 48
        '
        'ucrInputRangeElement1Max
        '
        Me.ucrInputRangeElement1Max.AddQuotesIfUnrecognised = True
        Me.ucrInputRangeElement1Max.AutoSize = True
        Me.ucrInputRangeElement1Max.IsMultiline = False
        Me.ucrInputRangeElement1Max.IsReadOnly = False
        Me.ucrInputRangeElement1Max.Location = New System.Drawing.Point(297, 264)
        Me.ucrInputRangeElement1Max.Name = "ucrInputRangeElement1Max"
        Me.ucrInputRangeElement1Max.Size = New System.Drawing.Size(44, 21)
        Me.ucrInputRangeElement1Max.TabIndex = 49
        '
        'ucrInputRangeElement2Min
        '
        Me.ucrInputRangeElement2Min.AddQuotesIfUnrecognised = True
        Me.ucrInputRangeElement2Min.AutoSize = True
        Me.ucrInputRangeElement2Min.IsMultiline = False
        Me.ucrInputRangeElement2Min.IsReadOnly = False
        Me.ucrInputRangeElement2Min.Location = New System.Drawing.Point(221, 293)
        Me.ucrInputRangeElement2Min.Name = "ucrInputRangeElement2Min"
        Me.ucrInputRangeElement2Min.Size = New System.Drawing.Size(44, 21)
        Me.ucrInputRangeElement2Min.TabIndex = 50
        '
        'ucrInputRangeElement2Max
        '
        Me.ucrInputRangeElement2Max.AddQuotesIfUnrecognised = True
        Me.ucrInputRangeElement2Max.AutoSize = True
        Me.ucrInputRangeElement2Max.IsMultiline = False
        Me.ucrInputRangeElement2Max.IsReadOnly = False
        Me.ucrInputRangeElement2Max.Location = New System.Drawing.Point(297, 293)
        Me.ucrInputRangeElement2Max.Name = "ucrInputRangeElement2Max"
        Me.ucrInputRangeElement2Max.Size = New System.Drawing.Size(44, 21)
        Me.ucrInputRangeElement2Max.TabIndex = 51
        '
        'lblRangeElement1From
        '
        Me.lblRangeElement1From.AutoSize = True
        Me.lblRangeElement1From.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRangeElement1From.Location = New System.Drawing.Point(185, 268)
        Me.lblRangeElement1From.Name = "lblRangeElement1From"
        Me.lblRangeElement1From.Size = New System.Drawing.Size(33, 13)
        Me.lblRangeElement1From.TabIndex = 52
        Me.lblRangeElement1From.Text = "From:"
        '
        'lblRangeElement2From
        '
        Me.lblRangeElement2From.AutoSize = True
        Me.lblRangeElement2From.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRangeElement2From.Location = New System.Drawing.Point(185, 297)
        Me.lblRangeElement2From.Name = "lblRangeElement2From"
        Me.lblRangeElement2From.Size = New System.Drawing.Size(33, 13)
        Me.lblRangeElement2From.TabIndex = 53
        Me.lblRangeElement2From.Text = "From:"
        '
        'dlgClimaticCheckDataTemperature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(478, 561)
        Me.Controls.Add(Me.lblRangeElement2From)
        Me.Controls.Add(Me.lblRangeElement1From)
        Me.Controls.Add(Me.ucrInputRangeElement2Max)
        Me.Controls.Add(Me.ucrInputRangeElement2Min)
        Me.Controls.Add(Me.ucrInputRangeElement1Max)
        Me.Controls.Add(Me.ucrInputRangeElement1Min)
        Me.Controls.Add(Me.lblCoeff)
        Me.Controls.Add(Me.ucrNudCoeff)
        Me.Controls.Add(Me.ucrChkIncludeLogicalColumns)
        Me.Controls.Add(Me.ucrChkRangeElement2)
        Me.Controls.Add(Me.lblNudSame)
        Me.Controls.Add(Me.rdoIndividual)
        Me.Controls.Add(Me.rdoMultiple)
        Me.Controls.Add(Me.lblElement2)
        Me.Controls.Add(Me.ucrReceiverElement2)
        Me.Controls.Add(Me.ucrNudJump)
        Me.Controls.Add(Me.ucrChkRangeElement1)
        Me.Controls.Add(Me.lblRangeElement1to)
        Me.Controls.Add(Me.ucrNudSame)
        Me.Controls.Add(Me.lblRangeElement2to)
        Me.Controls.Add(Me.ucrNudDifference)
        Me.Controls.Add(Me.ucrChkOutlier)
        Me.Controls.Add(Me.ucrChkSame)
        Me.Controls.Add(Me.ucrChkJump)
        Me.Controls.Add(Me.ucrChkDifference)
        Me.Controls.Add(Me.lblElement1)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverElement1)
        Me.Controls.Add(Me.ucrReceiverDay)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorTemperature)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlType)
        Me.Controls.Add(Me.grpLogicalCalculatedColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticCheckDataTemperature"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climatic Check Data Temperature"
        Me.grpLogicalCalculatedColumns.ResumeLayout(False)
        Me.grpLogicalCalculatedColumns.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTemperature As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblElement1 As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverElement1 As ucrReceiverSingle
    Friend WithEvents ucrReceiverDay As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrChkOutlier As ucrCheck
    Friend WithEvents ucrChkSame As ucrCheck
    Friend WithEvents ucrChkJump As ucrCheck
    Friend WithEvents ucrChkDifference As ucrCheck
    Friend WithEvents ucrNudSame As ucrNud
    Friend WithEvents ucrNudDifference As ucrNud
    Friend WithEvents lblRangeElement1to As Label
    Friend WithEvents lblRangeElement2to As Label
    Friend WithEvents ucrChkRangeElement1 As ucrCheck
    Friend WithEvents ucrNudJump As ucrNud
    Friend WithEvents lblElement2 As Label
    Friend WithEvents ucrReceiverElement2 As ucrReceiverSingle
    Friend WithEvents rdoIndividual As RadioButton
    Friend WithEvents rdoMultiple As RadioButton
    Friend WithEvents ucrPnlType As UcrPanel
    Friend WithEvents lblNudSame As Label
    Friend WithEvents ucrChkRangeElement2 As ucrCheck
    Friend WithEvents ttOutliers As ToolTip
    Friend WithEvents ucrChkIncludeCalculatedColumns As ucrCheck
    Friend WithEvents ucrChkIncludeLogicalColumns As ucrCheck
    Friend WithEvents ucrNudCoeff As ucrNud
    Friend WithEvents lblCoeff As Label
    Friend WithEvents grpLogicalCalculatedColumns As GroupBox
    Friend WithEvents ttMultiple As ToolTip
    Friend WithEvents ucrInputRangeElement1Min As ucrInputTextBox
    Friend WithEvents ucrInputRangeElement1Max As ucrInputTextBox
    Friend WithEvents ucrInputRangeElement2Max As ucrInputTextBox
    Friend WithEvents ucrInputRangeElement2Min As ucrInputTextBox
    Friend WithEvents lblRangeElement2From As Label
    Friend WithEvents lblRangeElement1From As Label
End Class
