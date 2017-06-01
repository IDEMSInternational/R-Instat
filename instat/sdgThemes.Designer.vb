<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgThemes
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
        Me.ucrBaseSubdialogue = New instat.ucrButtonsSubdialogue()
        Me.tbXaxis = New System.Windows.Forms.TabControl()
        Me.tbAxis = New System.Windows.Forms.TabPage()
        Me.grpTableOptions = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSizeSegment = New System.Windows.Forms.Label()
        Me.ucrNudSizeSegment = New instat.ucrNud()
        Me.lblColourSegment = New System.Windows.Forms.Label()
        Me.ucrInputColourSegment = New instat.ucrInputComboBox()
        Me.lblLineType = New System.Windows.Forms.Label()
        Me.ucrInputLineType = New instat.ucrInputComboBox()
        Me.grpThemetext = New System.Windows.Forms.GroupBox()
        Me.lblVjust = New System.Windows.Forms.Label()
        Me.ucrNudVjust = New instat.ucrNud()
        Me.lblLineHeight = New System.Windows.Forms.Label()
        Me.ucrNudLineHeight = New instat.ucrNud()
        Me.lblAngle = New System.Windows.Forms.Label()
        Me.ucrNudAngle = New instat.ucrNud()
        Me.lblHjust = New System.Windows.Forms.Label()
        Me.ucrNudHjust = New instat.ucrNud()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.ucrNudsize = New instat.ucrNud()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ucrInputColour = New instat.ucrInputComboBox()
        Me.lblFace = New System.Windows.Forms.Label()
        Me.ucrInputFace = New instat.ucrInputComboBox()
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.ucrInputFamily = New instat.ucrInputComboBox()
        Me.tbYaxis = New System.Windows.Forms.TabPage()
        Me.grpGraphOptions = New System.Windows.Forms.GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHjust5 = New System.Windows.Forms.Label()
        Me.lblVjust1 = New System.Windows.Forms.Label()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.ucrInputHorizontalLabels = New instat.ucrInputComboBox()
        Me.ucrInputVerticalLabels = New instat.ucrInputComboBox()
        Me.ucrChkShowMissing = New instat.ucrCheck()
        Me.ucrChkShowPercentage = New instat.ucrCheck()
        Me.ucrChkShowCount = New instat.ucrCheck()
        Me.grpGraphType = New System.Windows.Forms.GroupBox()
        Me.rdoLine = New System.Windows.Forms.RadioButton()
        Me.rdoDot = New System.Windows.Forms.RadioButton()
        Me.rdoBar = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGraphType = New instat.UcrPanel()
        Me.tbXaxis.SuspendLayout()
        Me.tbAxis.SuspendLayout()
        Me.grpTableOptions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpThemetext.SuspendLayout()
        Me.tbYaxis.SuspendLayout()
        Me.grpGraphOptions.SuspendLayout()
        Me.grpGraphType.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBaseSubdialogue
        '
        Me.ucrBaseSubdialogue.Location = New System.Drawing.Point(157, 441)
        Me.ucrBaseSubdialogue.Name = "ucrBaseSubdialogue"
        Me.ucrBaseSubdialogue.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSubdialogue.TabIndex = 0
        '
        'tbXaxis
        '
        Me.tbXaxis.Controls.Add(Me.tbAxis)
        Me.tbXaxis.Controls.Add(Me.tbYaxis)
        Me.tbXaxis.Location = New System.Drawing.Point(4, 8)
        Me.tbXaxis.Name = "tbXaxis"
        Me.tbXaxis.SelectedIndex = 0
        Me.tbXaxis.Size = New System.Drawing.Size(506, 421)
        Me.tbXaxis.TabIndex = 1
        '
        'tbAxis
        '
        Me.tbAxis.Controls.Add(Me.grpTableOptions)
        Me.tbAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbAxis.Name = "tbAxis"
        Me.tbAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAxis.Size = New System.Drawing.Size(498, 395)
        Me.tbAxis.TabIndex = 0
        Me.tbAxis.Text = "X-axis"
        Me.tbAxis.UseVisualStyleBackColor = True
        '
        'grpTableOptions
        '
        Me.grpTableOptions.Controls.Add(Me.GroupBox1)
        Me.grpTableOptions.Controls.Add(Me.grpThemetext)
        Me.grpTableOptions.Location = New System.Drawing.Point(-1, 3)
        Me.grpTableOptions.Name = "grpTableOptions"
        Me.grpTableOptions.Size = New System.Drawing.Size(492, 397)
        Me.grpTableOptions.TabIndex = 0
        Me.grpTableOptions.TabStop = False
        Me.grpTableOptions.Text = "More Options"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSizeSegment)
        Me.GroupBox1.Controls.Add(Me.ucrNudSizeSegment)
        Me.GroupBox1.Controls.Add(Me.lblColourSegment)
        Me.GroupBox1.Controls.Add(Me.ucrInputColourSegment)
        Me.GroupBox1.Controls.Add(Me.lblLineType)
        Me.GroupBox1.Controls.Add(Me.ucrInputLineType)
        Me.GroupBox1.Location = New System.Drawing.Point(251, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 110)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Segment Theme"
        '
        'lblSizeSegment
        '
        Me.lblSizeSegment.AutoSize = True
        Me.lblSizeSegment.Location = New System.Drawing.Point(13, 22)
        Me.lblSizeSegment.Name = "lblSizeSegment"
        Me.lblSizeSegment.Size = New System.Drawing.Size(30, 13)
        Me.lblSizeSegment.TabIndex = 29
        Me.lblSizeSegment.Text = "Size:"
        '
        'ucrNudSizeSegment
        '
        Me.ucrNudSizeSegment.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeSegment.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSizeSegment.Location = New System.Drawing.Point(94, 17)
        Me.ucrNudSizeSegment.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSizeSegment.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeSegment.Name = "ucrNudSizeSegment"
        Me.ucrNudSizeSegment.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSizeSegment.TabIndex = 30
        Me.ucrNudSizeSegment.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblColourSegment
        '
        Me.lblColourSegment.AutoSize = True
        Me.lblColourSegment.Location = New System.Drawing.Point(12, 76)
        Me.lblColourSegment.Name = "lblColourSegment"
        Me.lblColourSegment.Size = New System.Drawing.Size(40, 13)
        Me.lblColourSegment.TabIndex = 27
        Me.lblColourSegment.Text = "Colour:"
        '
        'ucrInputColourSegment
        '
        Me.ucrInputColourSegment.AddQuotesIfUnrecognised = True
        Me.ucrInputColourSegment.IsReadOnly = False
        Me.ucrInputColourSegment.Location = New System.Drawing.Point(72, 68)
        Me.ucrInputColourSegment.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputColourSegment.Name = "ucrInputColourSegment"
        Me.ucrInputColourSegment.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColourSegment.TabIndex = 28
        '
        'lblLineType
        '
        Me.lblLineType.AutoSize = True
        Me.lblLineType.Location = New System.Drawing.Point(12, 47)
        Me.lblLineType.Name = "lblLineType"
        Me.lblLineType.Size = New System.Drawing.Size(57, 13)
        Me.lblLineType.TabIndex = 25
        Me.lblLineType.Text = "Line Type:"
        '
        'ucrInputLineType
        '
        Me.ucrInputLineType.AddQuotesIfUnrecognised = True
        Me.ucrInputLineType.IsReadOnly = False
        Me.ucrInputLineType.Location = New System.Drawing.Point(72, 40)
        Me.ucrInputLineType.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLineType.Name = "ucrInputLineType"
        Me.ucrInputLineType.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLineType.TabIndex = 26
        '
        'grpThemetext
        '
        Me.grpThemetext.Controls.Add(Me.lblVjust)
        Me.grpThemetext.Controls.Add(Me.ucrNudVjust)
        Me.grpThemetext.Controls.Add(Me.lblLineHeight)
        Me.grpThemetext.Controls.Add(Me.ucrNudLineHeight)
        Me.grpThemetext.Controls.Add(Me.lblAngle)
        Me.grpThemetext.Controls.Add(Me.ucrNudAngle)
        Me.grpThemetext.Controls.Add(Me.lblHjust)
        Me.grpThemetext.Controls.Add(Me.ucrNudHjust)
        Me.grpThemetext.Controls.Add(Me.lblSize)
        Me.grpThemetext.Controls.Add(Me.ucrNudsize)
        Me.grpThemetext.Controls.Add(Me.Label2)
        Me.grpThemetext.Controls.Add(Me.ucrInputColour)
        Me.grpThemetext.Controls.Add(Me.lblFace)
        Me.grpThemetext.Controls.Add(Me.ucrInputFace)
        Me.grpThemetext.Controls.Add(Me.lblFamily)
        Me.grpThemetext.Controls.Add(Me.ucrInputFamily)
        Me.grpThemetext.Location = New System.Drawing.Point(15, 19)
        Me.grpThemetext.Name = "grpThemetext"
        Me.grpThemetext.Size = New System.Drawing.Size(230, 291)
        Me.grpThemetext.TabIndex = 23
        Me.grpThemetext.TabStop = False
        Me.grpThemetext.Text = "Text Theme"
        '
        'lblVjust
        '
        Me.lblVjust.AutoSize = True
        Me.lblVjust.Location = New System.Drawing.Point(13, 80)
        Me.lblVjust.Name = "lblVjust"
        Me.lblVjust.Size = New System.Drawing.Size(33, 13)
        Me.lblVjust.TabIndex = 37
        Me.lblVjust.Text = "Vjust:"
        '
        'ucrNudVjust
        '
        Me.ucrNudVjust.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudVjust.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudVjust.Location = New System.Drawing.Point(94, 75)
        Me.ucrNudVjust.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudVjust.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudVjust.Name = "ucrNudVjust"
        Me.ucrNudVjust.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudVjust.TabIndex = 38
        Me.ucrNudVjust.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLineHeight
        '
        Me.lblLineHeight.AutoSize = True
        Me.lblLineHeight.Location = New System.Drawing.Point(13, 111)
        Me.lblLineHeight.Name = "lblLineHeight"
        Me.lblLineHeight.Size = New System.Drawing.Size(64, 13)
        Me.lblLineHeight.TabIndex = 35
        Me.lblLineHeight.Text = "Line Height:"
        '
        'ucrNudLineHeight
        '
        Me.ucrNudLineHeight.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLineHeight.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLineHeight.Location = New System.Drawing.Point(94, 106)
        Me.ucrNudLineHeight.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLineHeight.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLineHeight.Name = "ucrNudLineHeight"
        Me.ucrNudLineHeight.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLineHeight.TabIndex = 36
        Me.ucrNudLineHeight.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblAngle
        '
        Me.lblAngle.AutoSize = True
        Me.lblAngle.Location = New System.Drawing.Point(13, 144)
        Me.lblAngle.Name = "lblAngle"
        Me.lblAngle.Size = New System.Drawing.Size(37, 13)
        Me.lblAngle.TabIndex = 33
        Me.lblAngle.Text = "Angle:"
        '
        'ucrNudAngle
        '
        Me.ucrNudAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAngle.Location = New System.Drawing.Point(94, 139)
        Me.ucrNudAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngle.Name = "ucrNudAngle"
        Me.ucrNudAngle.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAngle.TabIndex = 34
        Me.ucrNudAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblHjust
        '
        Me.lblHjust.AutoSize = True
        Me.lblHjust.Location = New System.Drawing.Point(13, 48)
        Me.lblHjust.Name = "lblHjust"
        Me.lblHjust.Size = New System.Drawing.Size(34, 13)
        Me.lblHjust.TabIndex = 31
        Me.lblHjust.Text = "Hjust:"
        '
        'ucrNudHjust
        '
        Me.ucrNudHjust.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHjust.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHjust.Location = New System.Drawing.Point(94, 43)
        Me.ucrNudHjust.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHjust.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHjust.Name = "ucrNudHjust"
        Me.ucrNudHjust.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudHjust.TabIndex = 32
        Me.ucrNudHjust.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(13, 22)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(30, 13)
        Me.lblSize.TabIndex = 29
        Me.lblSize.Text = "Size:"
        '
        'ucrNudsize
        '
        Me.ucrNudsize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudsize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudsize.Location = New System.Drawing.Point(94, 17)
        Me.ucrNudsize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudsize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudsize.Name = "ucrNudsize"
        Me.ucrNudsize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudsize.TabIndex = 30
        Me.ucrNudsize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Colour:"
        '
        'ucrInputColour
        '
        Me.ucrInputColour.AddQuotesIfUnrecognised = True
        Me.ucrInputColour.IsReadOnly = False
        Me.ucrInputColour.Location = New System.Drawing.Point(73, 229)
        Me.ucrInputColour.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputColour.Name = "ucrInputColour"
        Me.ucrInputColour.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColour.TabIndex = 28
        '
        'lblFace
        '
        Me.lblFace.AutoSize = True
        Me.lblFace.Location = New System.Drawing.Point(13, 209)
        Me.lblFace.Name = "lblFace"
        Me.lblFace.Size = New System.Drawing.Size(34, 13)
        Me.lblFace.TabIndex = 25
        Me.lblFace.Text = "Face:"
        '
        'ucrInputFace
        '
        Me.ucrInputFace.AddQuotesIfUnrecognised = True
        Me.ucrInputFace.IsReadOnly = False
        Me.ucrInputFace.Location = New System.Drawing.Point(73, 201)
        Me.ucrInputFace.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputFace.Name = "ucrInputFace"
        Me.ucrInputFace.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFace.TabIndex = 26
        '
        'lblFamily
        '
        Me.lblFamily.AutoSize = True
        Me.lblFamily.Location = New System.Drawing.Point(13, 182)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.Size = New System.Drawing.Size(39, 13)
        Me.lblFamily.TabIndex = 23
        Me.lblFamily.Text = "Family:"
        '
        'ucrInputFamily
        '
        Me.ucrInputFamily.AddQuotesIfUnrecognised = True
        Me.ucrInputFamily.IsReadOnly = False
        Me.ucrInputFamily.Location = New System.Drawing.Point(73, 174)
        Me.ucrInputFamily.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputFamily.Name = "ucrInputFamily"
        Me.ucrInputFamily.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFamily.TabIndex = 24
        '
        'tbYaxis
        '
        Me.tbYaxis.Controls.Add(Me.grpGraphOptions)
        Me.tbYaxis.Controls.Add(Me.grpGraphType)
        Me.tbYaxis.Location = New System.Drawing.Point(4, 22)
        Me.tbYaxis.Name = "tbYaxis"
        Me.tbYaxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbYaxis.Size = New System.Drawing.Size(498, 395)
        Me.tbYaxis.TabIndex = 1
        Me.tbYaxis.Text = "Y-axis"
        Me.tbYaxis.UseVisualStyleBackColor = True
        '
        'grpGraphOptions
        '
        Me.grpGraphOptions.Controls.Add(Me.lblTitle)
        Me.grpGraphOptions.Controls.Add(Me.lblHjust5)
        Me.grpGraphOptions.Controls.Add(Me.lblVjust1)
        Me.grpGraphOptions.Controls.Add(Me.ucrInputGraphTitle)
        Me.grpGraphOptions.Controls.Add(Me.ucrInputHorizontalLabels)
        Me.grpGraphOptions.Controls.Add(Me.ucrInputVerticalLabels)
        Me.grpGraphOptions.Controls.Add(Me.ucrChkShowMissing)
        Me.grpGraphOptions.Controls.Add(Me.ucrChkShowPercentage)
        Me.grpGraphOptions.Controls.Add(Me.ucrChkShowCount)
        Me.grpGraphOptions.Location = New System.Drawing.Point(6, 59)
        Me.grpGraphOptions.Name = "grpGraphOptions"
        Me.grpGraphOptions.Size = New System.Drawing.Size(329, 184)
        Me.grpGraphOptions.TabIndex = 1
        Me.grpGraphOptions.TabStop = False
        Me.grpGraphOptions.Text = "Graph Options"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 155)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(62, 13)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Graph Title:"
        '
        'lblHjust5
        '
        Me.lblHjust5.AutoSize = True
        Me.lblHjust5.Location = New System.Drawing.Point(12, 127)
        Me.lblHjust5.Name = "lblHjust5"
        Me.lblHjust5.Size = New System.Drawing.Size(126, 13)
        Me.lblHjust5.TabIndex = 5
        Me.lblHjust5.Text = "Horizontal Label Position:"
        '
        'lblVjust1
        '
        Me.lblVjust1.AutoSize = True
        Me.lblVjust1.Location = New System.Drawing.Point(12, 99)
        Me.lblVjust1.Name = "lblVjust1"
        Me.lblVjust1.Size = New System.Drawing.Size(114, 13)
        Me.lblVjust1.TabIndex = 3
        Me.lblVjust1.Text = "Vertical Label Position:"
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        Me.ucrInputGraphTitle.Location = New System.Drawing.Point(141, 151)
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        Me.ucrInputGraphTitle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputGraphTitle.TabIndex = 8
        '
        'ucrInputHorizontalLabels
        '
        Me.ucrInputHorizontalLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputHorizontalLabels.IsReadOnly = False
        Me.ucrInputHorizontalLabels.Location = New System.Drawing.Point(141, 123)
        Me.ucrInputHorizontalLabels.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputHorizontalLabels.Name = "ucrInputHorizontalLabels"
        Me.ucrInputHorizontalLabels.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputHorizontalLabels.TabIndex = 6
        '
        'ucrInputVerticalLabels
        '
        Me.ucrInputVerticalLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputVerticalLabels.IsReadOnly = False
        Me.ucrInputVerticalLabels.Location = New System.Drawing.Point(141, 95)
        Me.ucrInputVerticalLabels.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputVerticalLabels.Name = "ucrInputVerticalLabels"
        Me.ucrInputVerticalLabels.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputVerticalLabels.TabIndex = 4
        '
        'ucrChkShowMissing
        '
        Me.ucrChkShowMissing.Checked = False
        Me.ucrChkShowMissing.Location = New System.Drawing.Point(12, 73)
        Me.ucrChkShowMissing.Name = "ucrChkShowMissing"
        Me.ucrChkShowMissing.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowMissing.TabIndex = 2
        '
        'ucrChkShowPercentage
        '
        Me.ucrChkShowPercentage.Checked = False
        Me.ucrChkShowPercentage.Location = New System.Drawing.Point(12, 19)
        Me.ucrChkShowPercentage.Name = "ucrChkShowPercentage"
        Me.ucrChkShowPercentage.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowPercentage.TabIndex = 0
        '
        'ucrChkShowCount
        '
        Me.ucrChkShowCount.Checked = False
        Me.ucrChkShowCount.Location = New System.Drawing.Point(12, 46)
        Me.ucrChkShowCount.Name = "ucrChkShowCount"
        Me.ucrChkShowCount.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowCount.TabIndex = 1
        '
        'grpGraphType
        '
        Me.grpGraphType.Controls.Add(Me.rdoLine)
        Me.grpGraphType.Controls.Add(Me.rdoDot)
        Me.grpGraphType.Controls.Add(Me.rdoBar)
        Me.grpGraphType.Controls.Add(Me.ucrPnlGraphType)
        Me.grpGraphType.Location = New System.Drawing.Point(6, 6)
        Me.grpGraphType.Name = "grpGraphType"
        Me.grpGraphType.Size = New System.Drawing.Size(327, 48)
        Me.grpGraphType.TabIndex = 0
        Me.grpGraphType.TabStop = False
        Me.grpGraphType.Text = "Type of Graph"
        '
        'rdoLine
        '
        Me.rdoLine.AutoSize = True
        Me.rdoLine.Location = New System.Drawing.Point(242, 19)
        Me.rdoLine.Name = "rdoLine"
        Me.rdoLine.Size = New System.Drawing.Size(77, 17)
        Me.rdoLine.TabIndex = 3
        Me.rdoLine.TabStop = True
        Me.rdoLine.Text = "Line Graph"
        Me.rdoLine.UseVisualStyleBackColor = True
        '
        'rdoDot
        '
        Me.rdoDot.AutoSize = True
        Me.rdoDot.Location = New System.Drawing.Point(118, 19)
        Me.rdoDot.Name = "rdoDot"
        Me.rdoDot.Size = New System.Drawing.Size(74, 17)
        Me.rdoDot.TabIndex = 2
        Me.rdoDot.TabStop = True
        Me.rdoDot.Text = "Dot Graph"
        Me.rdoDot.UseVisualStyleBackColor = True
        '
        'rdoBar
        '
        Me.rdoBar.AutoSize = True
        Me.rdoBar.Location = New System.Drawing.Point(6, 19)
        Me.rdoBar.Name = "rdoBar"
        Me.rdoBar.Size = New System.Drawing.Size(73, 17)
        Me.rdoBar.TabIndex = 1
        Me.rdoBar.TabStop = True
        Me.rdoBar.Text = "Bar Graph"
        Me.rdoBar.UseVisualStyleBackColor = True
        '
        'ucrPnlGraphType
        '
        Me.ucrPnlGraphType.Location = New System.Drawing.Point(6, 7)
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        Me.ucrPnlGraphType.Size = New System.Drawing.Size(323, 44)
        Me.ucrPnlGraphType.TabIndex = 0
        '
        'sdgThemes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 472)
        Me.Controls.Add(Me.tbXaxis)
        Me.Controls.Add(Me.ucrBaseSubdialogue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgThemes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Themes"
        Me.tbXaxis.ResumeLayout(False)
        Me.tbAxis.ResumeLayout(False)
        Me.grpTableOptions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpThemetext.ResumeLayout(False)
        Me.grpThemetext.PerformLayout()
        Me.tbYaxis.ResumeLayout(False)
        Me.grpGraphOptions.ResumeLayout(False)
        Me.grpGraphOptions.PerformLayout()
        Me.grpGraphType.ResumeLayout(False)
        Me.grpGraphType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSubdialogue As ucrButtonsSubdialogue
    Friend WithEvents tbXaxis As TabControl
    Friend WithEvents tbAxis As TabPage
    Friend WithEvents grpTableOptions As GroupBox
    Friend WithEvents tbYaxis As TabPage
    Friend WithEvents grpGraphOptions As GroupBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHjust5 As Label
    Friend WithEvents lblVjust1 As Label
    Friend WithEvents ucrInputGraphTitle As ucrInputTextBox
    Friend WithEvents ucrInputHorizontalLabels As ucrInputComboBox
    Friend WithEvents ucrInputVerticalLabels As ucrInputComboBox
    Friend WithEvents ucrChkShowMissing As ucrCheck
    Friend WithEvents ucrChkShowPercentage As ucrCheck
    Friend WithEvents ucrChkShowCount As ucrCheck
    Friend WithEvents grpGraphType As GroupBox
    Friend WithEvents rdoLine As RadioButton
    Friend WithEvents rdoDot As RadioButton
    Friend WithEvents rdoBar As RadioButton
    Friend WithEvents ucrPnlGraphType As UcrPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSizeSegment As Label
    Friend WithEvents ucrNudSizeSegment As ucrNud
    Friend WithEvents lblColourSegment As Label
    Friend WithEvents ucrInputColourSegment As ucrInputComboBox
    Friend WithEvents lblLineType As Label
    Friend WithEvents ucrInputLineType As ucrInputComboBox
    Friend WithEvents grpThemetext As GroupBox
    Friend WithEvents lblVjust As Label
    Friend WithEvents ucrNudVjust As ucrNud
    Friend WithEvents lblLineHeight As Label
    Friend WithEvents ucrNudLineHeight As ucrNud
    Friend WithEvents lblAngle As Label
    Friend WithEvents ucrNudAngle As ucrNud
    Friend WithEvents lblHjust As Label
    Friend WithEvents ucrNudHjust As ucrNud
    Friend WithEvents lblSize As Label
    Friend WithEvents ucrNudsize As ucrNud
    Friend WithEvents Label2 As Label
    Friend WithEvents ucrInputColour As ucrInputComboBox
    Friend WithEvents lblFace As Label
    Friend WithEvents ucrInputFace As ucrInputComboBox
    Friend WithEvents lblFamily As Label
    Friend WithEvents ucrInputFamily As ucrInputComboBox
End Class
