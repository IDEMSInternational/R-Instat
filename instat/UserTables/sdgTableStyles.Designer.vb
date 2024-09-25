<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgTableStyles
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpBoxColor = New System.Windows.Forms.GroupBox()
        Me.ucrCboColorBackground = New instat.ucrColors()
        Me.ucrCboColorText = New instat.ucrColors()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.grpBoxAlignment = New System.Windows.Forms.GroupBox()
        Me.lblAlignVertical = New System.Windows.Forms.Label()
        Me.ucrCboAlignVertical = New instat.ucrInputComboBox()
        Me.lblAlignHorizontal = New System.Windows.Forms.Label()
        Me.ucrCboAlignHorizontal = New instat.ucrInputComboBox()
        Me.lblUnderlineType = New System.Windows.Forms.Label()
        Me.ucrCboUnderlineType = New instat.ucrInputComboBox()
        Me.lblFontWeight = New System.Windows.Forms.Label()
        Me.grpBoxFont = New System.Windows.Forms.GroupBox()
        Me.ucrTxtFontSize = New instat.ucrInputTextBox()
        Me.ucrCboFontWeight = New instat.ucrInputComboBox()
        Me.lblFontFamily = New System.Windows.Forms.Label()
        Me.ucrCboFontStyle = New instat.ucrInputComboBox()
        Me.ucrCboFontFamily = New instat.ucrInputComboBox()
        Me.lblFontStyle = New System.Windows.Forms.Label()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.grpBoxOthers = New System.Windows.Forms.GroupBox()
        Me.ucrNudIndent = New instat.ucrNud()
        Me.lblStretch = New System.Windows.Forms.Label()
        Me.ucrCboStretch = New instat.ucrInputComboBox()
        Me.lblWhiteSpace = New System.Windows.Forms.Label()
        Me.ucrCboWhiteSpace = New instat.ucrInputComboBox()
        Me.lblIndent = New System.Windows.Forms.Label()
        Me.lblTransform = New System.Windows.Forms.Label()
        Me.ucrCboTransform = New instat.ucrInputComboBox()
        Me.grpBoxBorders = New System.Windows.Forms.GroupBox()
        Me.ucrNudBorderWeight = New instat.ucrNud()
        Me.grpBoxSides = New System.Windows.Forms.GroupBox()
        Me.ucrChkBorderLeft = New instat.ucrCheck()
        Me.ucrChkBorderBottom = New instat.ucrCheck()
        Me.ucrChkBorderTop = New instat.ucrCheck()
        Me.ucrChkBorderRight = New instat.ucrCheck()
        Me.lblBorderStyle = New System.Windows.Forms.Label()
        Me.ucrCboBorderStyle = New instat.ucrInputComboBox()
        Me.ucrCboBorderColor = New instat.ucrColors()
        Me.lblBorderWeight = New System.Windows.Forms.Label()
        Me.lblBorderColor = New System.Windows.Forms.Label()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.grpBoxColor.SuspendLayout()
        Me.grpBoxAlignment.SuspendLayout()
        Me.grpBoxFont.SuspendLayout()
        Me.grpBoxOthers.SuspendLayout()
        Me.grpBoxBorders.SuspendLayout()
        Me.grpBoxSides.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(155, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Background:"
        '
        'grpBoxColor
        '
        Me.grpBoxColor.Controls.Add(Me.ucrCboColorBackground)
        Me.grpBoxColor.Controls.Add(Me.ucrCboColorText)
        Me.grpBoxColor.Controls.Add(Me.lblFill)
        Me.grpBoxColor.Controls.Add(Me.Label2)
        Me.grpBoxColor.Location = New System.Drawing.Point(7, 78)
        Me.grpBoxColor.Name = "grpBoxColor"
        Me.grpBoxColor.Size = New System.Drawing.Size(594, 68)
        Me.grpBoxColor.TabIndex = 29
        Me.grpBoxColor.TabStop = False
        Me.grpBoxColor.Text = "Color"
        '
        'ucrCboColorBackground
        '
        Me.ucrCboColorBackground.AddQuotesIfUnrecognised = True
        Me.ucrCboColorBackground.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboColorBackground.GetSetSelectedIndex = -1
        Me.ucrCboColorBackground.IsReadOnly = False
        Me.ucrCboColorBackground.Location = New System.Drawing.Point(157, 37)
        Me.ucrCboColorBackground.Name = "ucrCboColorBackground"
        Me.ucrCboColorBackground.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboColorBackground.TabIndex = 18
        '
        'ucrCboColorText
        '
        Me.ucrCboColorText.AddQuotesIfUnrecognised = True
        Me.ucrCboColorText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboColorText.GetSetSelectedIndex = -1
        Me.ucrCboColorText.IsReadOnly = False
        Me.ucrCboColorText.Location = New System.Drawing.Point(9, 37)
        Me.ucrCboColorText.Name = "ucrCboColorText"
        Me.ucrCboColorText.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboColorText.TabIndex = 17
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.Location = New System.Drawing.Point(6, 21)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(31, 13)
        Me.lblFill.TabIndex = 14
        Me.lblFill.Text = "Text:"
        '
        'grpBoxAlignment
        '
        Me.grpBoxAlignment.Controls.Add(Me.lblAlignVertical)
        Me.grpBoxAlignment.Controls.Add(Me.ucrCboAlignVertical)
        Me.grpBoxAlignment.Controls.Add(Me.lblAlignHorizontal)
        Me.grpBoxAlignment.Controls.Add(Me.ucrCboAlignHorizontal)
        Me.grpBoxAlignment.Location = New System.Drawing.Point(7, 149)
        Me.grpBoxAlignment.Name = "grpBoxAlignment"
        Me.grpBoxAlignment.Size = New System.Drawing.Size(594, 65)
        Me.grpBoxAlignment.TabIndex = 28
        Me.grpBoxAlignment.TabStop = False
        Me.grpBoxAlignment.Text = "Alignment"
        '
        'lblAlignVertical
        '
        Me.lblAlignVertical.AutoSize = True
        Me.lblAlignVertical.Location = New System.Drawing.Point(155, 20)
        Me.lblAlignVertical.Name = "lblAlignVertical"
        Me.lblAlignVertical.Size = New System.Drawing.Size(45, 13)
        Me.lblAlignVertical.TabIndex = 20
        Me.lblAlignVertical.Text = "Vertical:"
        '
        'ucrCboAlignVertical
        '
        Me.ucrCboAlignVertical.AddQuotesIfUnrecognised = True
        Me.ucrCboAlignVertical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboAlignVertical.GetSetSelectedIndex = -1
        Me.ucrCboAlignVertical.IsReadOnly = False
        Me.ucrCboAlignVertical.Location = New System.Drawing.Point(158, 36)
        Me.ucrCboAlignVertical.Name = "ucrCboAlignVertical"
        Me.ucrCboAlignVertical.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboAlignVertical.TabIndex = 19
        '
        'lblAlignHorizontal
        '
        Me.lblAlignHorizontal.AutoSize = True
        Me.lblAlignHorizontal.Location = New System.Drawing.Point(6, 20)
        Me.lblAlignHorizontal.Name = "lblAlignHorizontal"
        Me.lblAlignHorizontal.Size = New System.Drawing.Size(57, 13)
        Me.lblAlignHorizontal.TabIndex = 18
        Me.lblAlignHorizontal.Text = "Horizontal:"
        '
        'ucrCboAlignHorizontal
        '
        Me.ucrCboAlignHorizontal.AddQuotesIfUnrecognised = True
        Me.ucrCboAlignHorizontal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboAlignHorizontal.GetSetSelectedIndex = -1
        Me.ucrCboAlignHorizontal.IsReadOnly = False
        Me.ucrCboAlignHorizontal.Location = New System.Drawing.Point(9, 36)
        Me.ucrCboAlignHorizontal.Name = "ucrCboAlignHorizontal"
        Me.ucrCboAlignHorizontal.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboAlignHorizontal.TabIndex = 17
        '
        'lblUnderlineType
        '
        Me.lblUnderlineType.AutoSize = True
        Me.lblUnderlineType.Location = New System.Drawing.Point(6, 67)
        Me.lblUnderlineType.Name = "lblUnderlineType"
        Me.lblUnderlineType.Size = New System.Drawing.Size(82, 13)
        Me.lblUnderlineType.TabIndex = 21
        Me.lblUnderlineType.Text = "Underline Type:"
        '
        'ucrCboUnderlineType
        '
        Me.ucrCboUnderlineType.AddQuotesIfUnrecognised = True
        Me.ucrCboUnderlineType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboUnderlineType.GetSetSelectedIndex = -1
        Me.ucrCboUnderlineType.IsReadOnly = False
        Me.ucrCboUnderlineType.Location = New System.Drawing.Point(9, 83)
        Me.ucrCboUnderlineType.Name = "ucrCboUnderlineType"
        Me.ucrCboUnderlineType.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboUnderlineType.TabIndex = 20
        '
        'lblFontWeight
        '
        Me.lblFontWeight.AutoSize = True
        Me.lblFontWeight.Location = New System.Drawing.Point(297, 19)
        Me.lblFontWeight.Name = "lblFontWeight"
        Me.lblFontWeight.Size = New System.Drawing.Size(44, 13)
        Me.lblFontWeight.TabIndex = 14
        Me.lblFontWeight.Text = "Weight:"
        '
        'grpBoxFont
        '
        Me.grpBoxFont.Controls.Add(Me.ucrTxtFontSize)
        Me.grpBoxFont.Controls.Add(Me.ucrCboFontWeight)
        Me.grpBoxFont.Controls.Add(Me.lblFontWeight)
        Me.grpBoxFont.Controls.Add(Me.lblFontFamily)
        Me.grpBoxFont.Controls.Add(Me.ucrCboFontStyle)
        Me.grpBoxFont.Controls.Add(Me.ucrCboFontFamily)
        Me.grpBoxFont.Controls.Add(Me.lblFontStyle)
        Me.grpBoxFont.Controls.Add(Me.lblFontSize)
        Me.grpBoxFont.Location = New System.Drawing.Point(7, 6)
        Me.grpBoxFont.Name = "grpBoxFont"
        Me.grpBoxFont.Size = New System.Drawing.Size(594, 68)
        Me.grpBoxFont.TabIndex = 26
        Me.grpBoxFont.TabStop = False
        Me.grpBoxFont.Text = "Font"
        '
        'ucrTxtFontSize
        '
        Me.ucrTxtFontSize.AddQuotesIfUnrecognised = True
        Me.ucrTxtFontSize.AutoSize = True
        Me.ucrTxtFontSize.IsMultiline = False
        Me.ucrTxtFontSize.IsReadOnly = False
        Me.ucrTxtFontSize.Location = New System.Drawing.Point(447, 35)
        Me.ucrTxtFontSize.Name = "ucrTxtFontSize"
        Me.ucrTxtFontSize.Size = New System.Drawing.Size(137, 21)
        Me.ucrTxtFontSize.TabIndex = 15
        '
        'ucrCboFontWeight
        '
        Me.ucrCboFontWeight.AddQuotesIfUnrecognised = True
        Me.ucrCboFontWeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboFontWeight.GetSetSelectedIndex = -1
        Me.ucrCboFontWeight.IsReadOnly = False
        Me.ucrCboFontWeight.Location = New System.Drawing.Point(300, 35)
        Me.ucrCboFontWeight.Name = "ucrCboFontWeight"
        Me.ucrCboFontWeight.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboFontWeight.TabIndex = 13
        '
        'lblFontFamily
        '
        Me.lblFontFamily.AutoSize = True
        Me.lblFontFamily.Location = New System.Drawing.Point(6, 19)
        Me.lblFontFamily.Name = "lblFontFamily"
        Me.lblFontFamily.Size = New System.Drawing.Size(69, 13)
        Me.lblFontFamily.TabIndex = 6
        Me.lblFontFamily.Text = "Type (family):"
        '
        'ucrCboFontStyle
        '
        Me.ucrCboFontStyle.AddQuotesIfUnrecognised = True
        Me.ucrCboFontStyle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboFontStyle.GetSetSelectedIndex = -1
        Me.ucrCboFontStyle.IsReadOnly = False
        Me.ucrCboFontStyle.Location = New System.Drawing.Point(154, 35)
        Me.ucrCboFontStyle.Name = "ucrCboFontStyle"
        Me.ucrCboFontStyle.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboFontStyle.TabIndex = 7
        '
        'ucrCboFontFamily
        '
        Me.ucrCboFontFamily.AddQuotesIfUnrecognised = True
        Me.ucrCboFontFamily.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboFontFamily.GetSetSelectedIndex = -1
        Me.ucrCboFontFamily.IsReadOnly = False
        Me.ucrCboFontFamily.Location = New System.Drawing.Point(9, 35)
        Me.ucrCboFontFamily.Name = "ucrCboFontFamily"
        Me.ucrCboFontFamily.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboFontFamily.TabIndex = 5
        '
        'lblFontStyle
        '
        Me.lblFontStyle.AutoSize = True
        Me.lblFontStyle.Location = New System.Drawing.Point(151, 19)
        Me.lblFontStyle.Name = "lblFontStyle"
        Me.lblFontStyle.Size = New System.Drawing.Size(33, 13)
        Me.lblFontStyle.TabIndex = 8
        Me.lblFontStyle.Text = "Style:"
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(444, 19)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(30, 13)
        Me.lblFontSize.TabIndex = 10
        Me.lblFontSize.Text = "Size:"
        '
        'grpBoxOthers
        '
        Me.grpBoxOthers.Controls.Add(Me.lblUnderlineType)
        Me.grpBoxOthers.Controls.Add(Me.ucrCboUnderlineType)
        Me.grpBoxOthers.Controls.Add(Me.ucrNudIndent)
        Me.grpBoxOthers.Controls.Add(Me.lblStretch)
        Me.grpBoxOthers.Controls.Add(Me.ucrCboStretch)
        Me.grpBoxOthers.Controls.Add(Me.lblWhiteSpace)
        Me.grpBoxOthers.Controls.Add(Me.ucrCboWhiteSpace)
        Me.grpBoxOthers.Controls.Add(Me.lblIndent)
        Me.grpBoxOthers.Controls.Add(Me.lblTransform)
        Me.grpBoxOthers.Controls.Add(Me.ucrCboTransform)
        Me.grpBoxOthers.Location = New System.Drawing.Point(7, 330)
        Me.grpBoxOthers.Name = "grpBoxOthers"
        Me.grpBoxOthers.Size = New System.Drawing.Size(594, 132)
        Me.grpBoxOthers.TabIndex = 30
        Me.grpBoxOthers.TabStop = False
        Me.grpBoxOthers.Text = "Others"
        '
        'ucrNudIndent
        '
        Me.ucrNudIndent.AutoSize = True
        Me.ucrNudIndent.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudIndent.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudIndent.Location = New System.Drawing.Point(469, 35)
        Me.ucrNudIndent.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudIndent.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudIndent.Name = "ucrNudIndent"
        Me.ucrNudIndent.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudIndent.TabIndex = 27
        Me.ucrNudIndent.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblStretch
        '
        Me.lblStretch.AutoSize = True
        Me.lblStretch.Location = New System.Drawing.Point(302, 20)
        Me.lblStretch.Name = "lblStretch"
        Me.lblStretch.Size = New System.Drawing.Size(44, 13)
        Me.lblStretch.TabIndex = 24
        Me.lblStretch.Text = "Stretch:"
        '
        'ucrCboStretch
        '
        Me.ucrCboStretch.AddQuotesIfUnrecognised = True
        Me.ucrCboStretch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboStretch.GetSetSelectedIndex = -1
        Me.ucrCboStretch.IsReadOnly = False
        Me.ucrCboStretch.Location = New System.Drawing.Point(303, 36)
        Me.ucrCboStretch.Name = "ucrCboStretch"
        Me.ucrCboStretch.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboStretch.TabIndex = 23
        '
        'lblWhiteSpace
        '
        Me.lblWhiteSpace.AutoSize = True
        Me.lblWhiteSpace.Location = New System.Drawing.Point(155, 20)
        Me.lblWhiteSpace.Name = "lblWhiteSpace"
        Me.lblWhiteSpace.Size = New System.Drawing.Size(72, 13)
        Me.lblWhiteSpace.TabIndex = 22
        Me.lblWhiteSpace.Text = "White Space:"
        '
        'ucrCboWhiteSpace
        '
        Me.ucrCboWhiteSpace.AddQuotesIfUnrecognised = True
        Me.ucrCboWhiteSpace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboWhiteSpace.GetSetSelectedIndex = -1
        Me.ucrCboWhiteSpace.IsReadOnly = False
        Me.ucrCboWhiteSpace.Location = New System.Drawing.Point(158, 36)
        Me.ucrCboWhiteSpace.Name = "ucrCboWhiteSpace"
        Me.ucrCboWhiteSpace.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboWhiteSpace.TabIndex = 21
        '
        'lblIndent
        '
        Me.lblIndent.AutoSize = True
        Me.lblIndent.Location = New System.Drawing.Point(466, 16)
        Me.lblIndent.Name = "lblIndent"
        Me.lblIndent.Size = New System.Drawing.Size(40, 13)
        Me.lblIndent.TabIndex = 19
        Me.lblIndent.Text = "Indent:"
        '
        'lblTransform
        '
        Me.lblTransform.AutoSize = True
        Me.lblTransform.Location = New System.Drawing.Point(6, 20)
        Me.lblTransform.Name = "lblTransform"
        Me.lblTransform.Size = New System.Drawing.Size(57, 13)
        Me.lblTransform.TabIndex = 18
        Me.lblTransform.Text = "Transform:"
        '
        'ucrCboTransform
        '
        Me.ucrCboTransform.AddQuotesIfUnrecognised = True
        Me.ucrCboTransform.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboTransform.GetSetSelectedIndex = -1
        Me.ucrCboTransform.IsReadOnly = False
        Me.ucrCboTransform.Location = New System.Drawing.Point(9, 36)
        Me.ucrCboTransform.Name = "ucrCboTransform"
        Me.ucrCboTransform.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboTransform.TabIndex = 17
        '
        'grpBoxBorders
        '
        Me.grpBoxBorders.Controls.Add(Me.ucrNudBorderWeight)
        Me.grpBoxBorders.Controls.Add(Me.grpBoxSides)
        Me.grpBoxBorders.Controls.Add(Me.lblBorderStyle)
        Me.grpBoxBorders.Controls.Add(Me.ucrCboBorderStyle)
        Me.grpBoxBorders.Controls.Add(Me.ucrCboBorderColor)
        Me.grpBoxBorders.Controls.Add(Me.lblBorderWeight)
        Me.grpBoxBorders.Controls.Add(Me.lblBorderColor)
        Me.grpBoxBorders.Location = New System.Drawing.Point(7, 218)
        Me.grpBoxBorders.Name = "grpBoxBorders"
        Me.grpBoxBorders.Size = New System.Drawing.Size(594, 109)
        Me.grpBoxBorders.TabIndex = 31
        Me.grpBoxBorders.TabStop = False
        Me.grpBoxBorders.Text = "Borders"
        '
        'ucrNudBorderWeight
        '
        Me.ucrNudBorderWeight.AutoSize = True
        Me.ucrNudBorderWeight.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBorderWeight.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBorderWeight.Location = New System.Drawing.Point(469, 36)
        Me.ucrNudBorderWeight.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBorderWeight.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBorderWeight.Name = "ucrNudBorderWeight"
        Me.ucrNudBorderWeight.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudBorderWeight.TabIndex = 26
        Me.ucrNudBorderWeight.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpBoxSides
        '
        Me.grpBoxSides.Controls.Add(Me.ucrChkBorderLeft)
        Me.grpBoxSides.Controls.Add(Me.ucrChkBorderBottom)
        Me.grpBoxSides.Controls.Add(Me.ucrChkBorderTop)
        Me.grpBoxSides.Controls.Add(Me.ucrChkBorderRight)
        Me.grpBoxSides.Location = New System.Drawing.Point(9, 19)
        Me.grpBoxSides.Name = "grpBoxSides"
        Me.grpBoxSides.Size = New System.Drawing.Size(259, 83)
        Me.grpBoxSides.TabIndex = 21
        Me.grpBoxSides.TabStop = False
        Me.grpBoxSides.Text = "Sides"
        '
        'ucrChkBorderLeft
        '
        Me.ucrChkBorderLeft.AutoSize = True
        Me.ucrChkBorderLeft.Checked = False
        Me.ucrChkBorderLeft.Location = New System.Drawing.Point(6, 21)
        Me.ucrChkBorderLeft.Name = "ucrChkBorderLeft"
        Me.ucrChkBorderLeft.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBorderLeft.TabIndex = 26
        '
        'ucrChkBorderBottom
        '
        Me.ucrChkBorderBottom.AutoSize = True
        Me.ucrChkBorderBottom.Checked = False
        Me.ucrChkBorderBottom.Location = New System.Drawing.Point(137, 54)
        Me.ucrChkBorderBottom.Name = "ucrChkBorderBottom"
        Me.ucrChkBorderBottom.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBorderBottom.TabIndex = 28
        '
        'ucrChkBorderTop
        '
        Me.ucrChkBorderTop.AutoSize = True
        Me.ucrChkBorderTop.Checked = False
        Me.ucrChkBorderTop.Location = New System.Drawing.Point(137, 21)
        Me.ucrChkBorderTop.Name = "ucrChkBorderTop"
        Me.ucrChkBorderTop.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBorderTop.TabIndex = 29
        '
        'ucrChkBorderRight
        '
        Me.ucrChkBorderRight.AutoSize = True
        Me.ucrChkBorderRight.Checked = False
        Me.ucrChkBorderRight.Location = New System.Drawing.Point(6, 54)
        Me.ucrChkBorderRight.Name = "ucrChkBorderRight"
        Me.ucrChkBorderRight.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBorderRight.TabIndex = 27
        '
        'lblBorderStyle
        '
        Me.lblBorderStyle.AutoSize = True
        Me.lblBorderStyle.Location = New System.Drawing.Point(300, 65)
        Me.lblBorderStyle.Name = "lblBorderStyle"
        Me.lblBorderStyle.Size = New System.Drawing.Size(33, 13)
        Me.lblBorderStyle.TabIndex = 25
        Me.lblBorderStyle.Text = "Style:"
        '
        'ucrCboBorderStyle
        '
        Me.ucrCboBorderStyle.AddQuotesIfUnrecognised = True
        Me.ucrCboBorderStyle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboBorderStyle.GetSetSelectedIndex = -1
        Me.ucrCboBorderStyle.IsReadOnly = False
        Me.ucrCboBorderStyle.Location = New System.Drawing.Point(300, 81)
        Me.ucrCboBorderStyle.Name = "ucrCboBorderStyle"
        Me.ucrCboBorderStyle.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboBorderStyle.TabIndex = 24
        '
        'ucrCboBorderColor
        '
        Me.ucrCboBorderColor.AddQuotesIfUnrecognised = True
        Me.ucrCboBorderColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboBorderColor.GetSetSelectedIndex = -1
        Me.ucrCboBorderColor.IsReadOnly = False
        Me.ucrCboBorderColor.Location = New System.Drawing.Point(300, 35)
        Me.ucrCboBorderColor.Name = "ucrCboBorderColor"
        Me.ucrCboBorderColor.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboBorderColor.TabIndex = 23
        '
        'lblBorderWeight
        '
        Me.lblBorderWeight.AutoSize = True
        Me.lblBorderWeight.Location = New System.Drawing.Point(466, 20)
        Me.lblBorderWeight.Name = "lblBorderWeight"
        Me.lblBorderWeight.Size = New System.Drawing.Size(44, 13)
        Me.lblBorderWeight.TabIndex = 21
        Me.lblBorderWeight.Text = "Weight:"
        '
        'lblBorderColor
        '
        Me.lblBorderColor.AutoSize = True
        Me.lblBorderColor.Location = New System.Drawing.Point(300, 20)
        Me.lblBorderColor.Name = "lblBorderColor"
        Me.lblBorderColor.Size = New System.Drawing.Size(34, 13)
        Me.lblBorderColor.TabIndex = 22
        Me.lblBorderColor.Text = "Color:"
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(185, 467)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 29)
        Me.ucrBaseSubdialog.TabIndex = 25
        '
        'sdgTableStyles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 504)
        Me.Controls.Add(Me.grpBoxBorders)
        Me.Controls.Add(Me.grpBoxOthers)
        Me.Controls.Add(Me.grpBoxColor)
        Me.Controls.Add(Me.grpBoxAlignment)
        Me.Controls.Add(Me.grpBoxFont)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgTableStyles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Styles"
        Me.grpBoxColor.ResumeLayout(False)
        Me.grpBoxColor.PerformLayout()
        Me.grpBoxAlignment.ResumeLayout(False)
        Me.grpBoxAlignment.PerformLayout()
        Me.grpBoxFont.ResumeLayout(False)
        Me.grpBoxFont.PerformLayout()
        Me.grpBoxOthers.ResumeLayout(False)
        Me.grpBoxOthers.PerformLayout()
        Me.grpBoxBorders.ResumeLayout(False)
        Me.grpBoxBorders.PerformLayout()
        Me.grpBoxSides.ResumeLayout(False)
        Me.grpBoxSides.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrCboColorBackground As ucrColors
    Friend WithEvents ucrCboColorText As ucrColors
    Friend WithEvents Label2 As Label
    Friend WithEvents grpBoxColor As GroupBox
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrCboAlignHorizontal As ucrInputComboBox
    Friend WithEvents grpBoxAlignment As GroupBox
    Friend WithEvents lblAlignHorizontal As Label
    Friend WithEvents lblUnderlineType As Label
    Friend WithEvents ucrCboUnderlineType As ucrInputComboBox
    Friend WithEvents ucrTxtFontSize As ucrInputTextBox
    Friend WithEvents ucrCboFontWeight As ucrInputComboBox
    Friend WithEvents lblFontWeight As Label
    Friend WithEvents ucrCboFontStyle As ucrInputComboBox
    Friend WithEvents grpBoxFont As GroupBox
    Friend WithEvents lblFontFamily As Label
    Friend WithEvents ucrCboFontFamily As ucrInputComboBox
    Friend WithEvents lblFontStyle As Label
    Friend WithEvents lblFontSize As Label
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents lblAlignVertical As Label
    Friend WithEvents ucrCboAlignVertical As ucrInputComboBox
    Friend WithEvents grpBoxOthers As GroupBox
    Friend WithEvents lblTransform As Label
    Friend WithEvents ucrCboTransform As ucrInputComboBox
    Friend WithEvents lblIndent As Label
    Friend WithEvents lblWhiteSpace As Label
    Friend WithEvents ucrCboWhiteSpace As ucrInputComboBox
    Friend WithEvents lblStretch As Label
    Friend WithEvents ucrCboStretch As ucrInputComboBox
    Friend WithEvents grpBoxBorders As GroupBox
    Friend WithEvents lblBorderStyle As Label
    Friend WithEvents ucrCboBorderStyle As ucrInputComboBox
    Friend WithEvents ucrCboBorderColor As ucrColors
    Friend WithEvents lblBorderWeight As Label
    Friend WithEvents lblBorderColor As Label
    Friend WithEvents ucrChkBorderTop As ucrCheck
    Friend WithEvents ucrChkBorderBottom As ucrCheck
    Friend WithEvents ucrChkBorderRight As ucrCheck
    Friend WithEvents ucrChkBorderLeft As ucrCheck
    Friend WithEvents grpBoxSides As GroupBox
    Friend WithEvents ucrNudBorderWeight As ucrNud
    Friend WithEvents ucrNudIndent As ucrNud
End Class
