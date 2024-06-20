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
        Me.lblFill = New System.Windows.Forms.Label()
        Me.grpBoxAlignment = New System.Windows.Forms.GroupBox()
        Me.lblAlignHorizontal = New System.Windows.Forms.Label()
        Me.lblUnderlineType = New System.Windows.Forms.Label()
        Me.grpBoxUnderline = New System.Windows.Forms.GroupBox()
        Me.lblUnderlineStyle = New System.Windows.Forms.Label()
        Me.lblUnderlineColor = New System.Windows.Forms.Label()
        Me.lblFontWeight = New System.Windows.Forms.Label()
        Me.grpBoxFont = New System.Windows.Forms.GroupBox()
        Me.lblFontFamily = New System.Windows.Forms.Label()
        Me.lblFontStyle = New System.Windows.Forms.Label()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.lblAlignVertical = New System.Windows.Forms.Label()
        Me.grpBoxOthers = New System.Windows.Forms.GroupBox()
        Me.lblTransform = New System.Windows.Forms.Label()
        Me.lblIndent = New System.Windows.Forms.Label()
        Me.lblWhiteSpace = New System.Windows.Forms.Label()
        Me.lblStretch = New System.Windows.Forms.Label()
        Me.ucrCboStretch = New instat.ucrInputComboBox()
        Me.ucrCboWhiteSpace = New instat.ucrInputComboBox()
        Me.ucrTxtIndent = New instat.ucrInputTextBox()
        Me.ucrInputCboTransform = New instat.ucrInputComboBox()
        Me.ucrCboColorBackground = New instat.ucrColors()
        Me.ucrCboColorText = New instat.ucrColors()
        Me.ucrCboAlignVertical = New instat.ucrInputComboBox()
        Me.ucrCboAlignHorizontal = New instat.ucrInputComboBox()
        Me.ucrCboUnderlineType = New instat.ucrInputComboBox()
        Me.ucrCboUnderLineColor = New instat.ucrColors()
        Me.ucrCboUnderlineStyle = New instat.ucrInputComboBox()
        Me.ucrTxtFontSize = New instat.ucrInputTextBox()
        Me.ucrCboFontWeight = New instat.ucrInputComboBox()
        Me.ucrCboFontStyle = New instat.ucrInputComboBox()
        Me.ucrCboFontFamily = New instat.ucrInputComboBox()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.grpBoxBorders = New System.Windows.Forms.GroupBox()
        Me.lblBordersSides = New System.Windows.Forms.Label()
        Me.ucrCboBorderColor = New instat.ucrColors()
        Me.lblBorderColor = New System.Windows.Forms.Label()
        Me.ucrCboBorderWeight = New instat.ucrInputTextBox()
        Me.lblBorderWeight = New System.Windows.Forms.Label()
        Me.lblBorderStyle = New System.Windows.Forms.Label()
        Me.ucrCboBorderStyle = New instat.ucrInputComboBox()
        Me.ucrChkBorderLeft = New instat.ucrCheck()
        Me.ucrChkBorderRight = New instat.ucrCheck()
        Me.ucrChkBorderBottom = New instat.ucrCheck()
        Me.ucrChkBorderTop = New instat.ucrCheck()
        Me.grpBoxColor.SuspendLayout()
        Me.grpBoxAlignment.SuspendLayout()
        Me.grpBoxUnderline.SuspendLayout()
        Me.grpBoxFont.SuspendLayout()
        Me.grpBoxOthers.SuspendLayout()
        Me.grpBoxBorders.SuspendLayout()
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
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.Location = New System.Drawing.Point(6, 21)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(22, 13)
        Me.lblFill.TabIndex = 14
        Me.lblFill.Text = "Fill:"
        '
        'grpBoxAlignment
        '
        Me.grpBoxAlignment.Controls.Add(Me.lblAlignVertical)
        Me.grpBoxAlignment.Controls.Add(Me.ucrCboAlignVertical)
        Me.grpBoxAlignment.Controls.Add(Me.lblAlignHorizontal)
        Me.grpBoxAlignment.Controls.Add(Me.ucrCboAlignHorizontal)
        Me.grpBoxAlignment.Enabled = False
        Me.grpBoxAlignment.Location = New System.Drawing.Point(7, 221)
        Me.grpBoxAlignment.Name = "grpBoxAlignment"
        Me.grpBoxAlignment.Size = New System.Drawing.Size(594, 65)
        Me.grpBoxAlignment.TabIndex = 28
        Me.grpBoxAlignment.TabStop = False
        Me.grpBoxAlignment.Text = "Alignment"
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
        'lblUnderlineType
        '
        Me.lblUnderlineType.AutoSize = True
        Me.lblUnderlineType.Location = New System.Drawing.Point(6, 16)
        Me.lblUnderlineType.Name = "lblUnderlineType"
        Me.lblUnderlineType.Size = New System.Drawing.Size(34, 13)
        Me.lblUnderlineType.TabIndex = 21
        Me.lblUnderlineType.Text = "Type:"
        '
        'grpBoxUnderline
        '
        Me.grpBoxUnderline.Controls.Add(Me.lblUnderlineType)
        Me.grpBoxUnderline.Controls.Add(Me.ucrCboUnderlineType)
        Me.grpBoxUnderline.Controls.Add(Me.ucrCboUnderLineColor)
        Me.grpBoxUnderline.Controls.Add(Me.lblUnderlineStyle)
        Me.grpBoxUnderline.Controls.Add(Me.ucrCboUnderlineStyle)
        Me.grpBoxUnderline.Controls.Add(Me.lblUnderlineColor)
        Me.grpBoxUnderline.Location = New System.Drawing.Point(7, 149)
        Me.grpBoxUnderline.Name = "grpBoxUnderline"
        Me.grpBoxUnderline.Size = New System.Drawing.Size(594, 68)
        Me.grpBoxUnderline.TabIndex = 27
        Me.grpBoxUnderline.TabStop = False
        Me.grpBoxUnderline.Text = "Underline"
        '
        'lblUnderlineStyle
        '
        Me.lblUnderlineStyle.AutoSize = True
        Me.lblUnderlineStyle.Enabled = False
        Me.lblUnderlineStyle.Location = New System.Drawing.Point(151, 16)
        Me.lblUnderlineStyle.Name = "lblUnderlineStyle"
        Me.lblUnderlineStyle.Size = New System.Drawing.Size(33, 13)
        Me.lblUnderlineStyle.TabIndex = 14
        Me.lblUnderlineStyle.Text = "Style:"
        '
        'lblUnderlineColor
        '
        Me.lblUnderlineColor.AutoSize = True
        Me.lblUnderlineColor.Enabled = False
        Me.lblUnderlineColor.Location = New System.Drawing.Point(300, 16)
        Me.lblUnderlineColor.Name = "lblUnderlineColor"
        Me.lblUnderlineColor.Size = New System.Drawing.Size(34, 13)
        Me.lblUnderlineColor.TabIndex = 16
        Me.lblUnderlineColor.Text = "Color:"
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
        'lblFontFamily
        '
        Me.lblFontFamily.AutoSize = True
        Me.lblFontFamily.Location = New System.Drawing.Point(6, 19)
        Me.lblFontFamily.Name = "lblFontFamily"
        Me.lblFontFamily.Size = New System.Drawing.Size(69, 13)
        Me.lblFontFamily.TabIndex = 6
        Me.lblFontFamily.Text = "Type (family):"
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
        'lblAlignVertical
        '
        Me.lblAlignVertical.AutoSize = True
        Me.lblAlignVertical.Location = New System.Drawing.Point(155, 20)
        Me.lblAlignVertical.Name = "lblAlignVertical"
        Me.lblAlignVertical.Size = New System.Drawing.Size(45, 13)
        Me.lblAlignVertical.TabIndex = 20
        Me.lblAlignVertical.Text = "Vertical:"
        '
        'grpBoxOthers
        '
        Me.grpBoxOthers.Controls.Add(Me.lblStretch)
        Me.grpBoxOthers.Controls.Add(Me.ucrCboStretch)
        Me.grpBoxOthers.Controls.Add(Me.lblWhiteSpace)
        Me.grpBoxOthers.Controls.Add(Me.ucrCboWhiteSpace)
        Me.grpBoxOthers.Controls.Add(Me.ucrTxtIndent)
        Me.grpBoxOthers.Controls.Add(Me.lblIndent)
        Me.grpBoxOthers.Controls.Add(Me.lblTransform)
        Me.grpBoxOthers.Controls.Add(Me.ucrInputCboTransform)
        Me.grpBoxOthers.Enabled = False
        Me.grpBoxOthers.Location = New System.Drawing.Point(7, 409)
        Me.grpBoxOthers.Name = "grpBoxOthers"
        Me.grpBoxOthers.Size = New System.Drawing.Size(594, 65)
        Me.grpBoxOthers.TabIndex = 30
        Me.grpBoxOthers.TabStop = False
        Me.grpBoxOthers.Text = "Others"
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
        'lblIndent
        '
        Me.lblIndent.AutoSize = True
        Me.lblIndent.Location = New System.Drawing.Point(151, 20)
        Me.lblIndent.Name = "lblIndent"
        Me.lblIndent.Size = New System.Drawing.Size(40, 13)
        Me.lblIndent.TabIndex = 19
        Me.lblIndent.Text = "Indent:"
        '
        'lblWhiteSpace
        '
        Me.lblWhiteSpace.AutoSize = True
        Me.lblWhiteSpace.Location = New System.Drawing.Point(300, 20)
        Me.lblWhiteSpace.Name = "lblWhiteSpace"
        Me.lblWhiteSpace.Size = New System.Drawing.Size(72, 13)
        Me.lblWhiteSpace.TabIndex = 22
        Me.lblWhiteSpace.Text = "White Space:"
        '
        'lblStretch
        '
        Me.lblStretch.AutoSize = True
        Me.lblStretch.Location = New System.Drawing.Point(447, 20)
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
        Me.ucrCboStretch.Location = New System.Drawing.Point(450, 36)
        Me.ucrCboStretch.Name = "ucrCboStretch"
        Me.ucrCboStretch.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboStretch.TabIndex = 23
        '
        'ucrCboWhiteSpace
        '
        Me.ucrCboWhiteSpace.AddQuotesIfUnrecognised = True
        Me.ucrCboWhiteSpace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboWhiteSpace.GetSetSelectedIndex = -1
        Me.ucrCboWhiteSpace.IsReadOnly = False
        Me.ucrCboWhiteSpace.Location = New System.Drawing.Point(303, 36)
        Me.ucrCboWhiteSpace.Name = "ucrCboWhiteSpace"
        Me.ucrCboWhiteSpace.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboWhiteSpace.TabIndex = 21
        '
        'ucrTxtIndent
        '
        Me.ucrTxtIndent.AddQuotesIfUnrecognised = True
        Me.ucrTxtIndent.AutoSize = True
        Me.ucrTxtIndent.IsMultiline = False
        Me.ucrTxtIndent.IsReadOnly = False
        Me.ucrTxtIndent.Location = New System.Drawing.Point(154, 36)
        Me.ucrTxtIndent.Name = "ucrTxtIndent"
        Me.ucrTxtIndent.Size = New System.Drawing.Size(137, 21)
        Me.ucrTxtIndent.TabIndex = 20
        '
        'ucrInputCboTransform
        '
        Me.ucrInputCboTransform.AddQuotesIfUnrecognised = True
        Me.ucrInputCboTransform.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCboTransform.GetSetSelectedIndex = -1
        Me.ucrInputCboTransform.IsReadOnly = False
        Me.ucrInputCboTransform.Location = New System.Drawing.Point(9, 36)
        Me.ucrInputCboTransform.Name = "ucrInputCboTransform"
        Me.ucrInputCboTransform.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputCboTransform.TabIndex = 17
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
        'ucrCboUnderlineType
        '
        Me.ucrCboUnderlineType.AddQuotesIfUnrecognised = True
        Me.ucrCboUnderlineType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboUnderlineType.GetSetSelectedIndex = -1
        Me.ucrCboUnderlineType.IsReadOnly = False
        Me.ucrCboUnderlineType.Location = New System.Drawing.Point(9, 32)
        Me.ucrCboUnderlineType.Name = "ucrCboUnderlineType"
        Me.ucrCboUnderlineType.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboUnderlineType.TabIndex = 20
        '
        'ucrCboUnderLineColor
        '
        Me.ucrCboUnderLineColor.AddQuotesIfUnrecognised = True
        Me.ucrCboUnderLineColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboUnderLineColor.Enabled = False
        Me.ucrCboUnderLineColor.GetSetSelectedIndex = -1
        Me.ucrCboUnderLineColor.IsReadOnly = False
        Me.ucrCboUnderLineColor.Location = New System.Drawing.Point(302, 32)
        Me.ucrCboUnderLineColor.Name = "ucrCboUnderLineColor"
        Me.ucrCboUnderLineColor.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboUnderLineColor.TabIndex = 19
        '
        'ucrCboUnderlineStyle
        '
        Me.ucrCboUnderlineStyle.AddQuotesIfUnrecognised = True
        Me.ucrCboUnderlineStyle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboUnderlineStyle.Enabled = False
        Me.ucrCboUnderlineStyle.GetSetSelectedIndex = -1
        Me.ucrCboUnderlineStyle.IsReadOnly = False
        Me.ucrCboUnderlineStyle.Location = New System.Drawing.Point(157, 32)
        Me.ucrCboUnderlineStyle.Name = "ucrCboUnderlineStyle"
        Me.ucrCboUnderlineStyle.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboUnderlineStyle.TabIndex = 13
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
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(211, 479)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 29)
        Me.ucrBaseSubdialog.TabIndex = 25
        '
        'grpBoxBorders
        '
        Me.grpBoxBorders.Controls.Add(Me.ucrChkBorderTop)
        Me.grpBoxBorders.Controls.Add(Me.ucrChkBorderBottom)
        Me.grpBoxBorders.Controls.Add(Me.ucrChkBorderRight)
        Me.grpBoxBorders.Controls.Add(Me.ucrChkBorderLeft)
        Me.grpBoxBorders.Controls.Add(Me.lblBorderStyle)
        Me.grpBoxBorders.Controls.Add(Me.ucrCboBorderStyle)
        Me.grpBoxBorders.Controls.Add(Me.ucrCboBorderWeight)
        Me.grpBoxBorders.Controls.Add(Me.ucrCboBorderColor)
        Me.grpBoxBorders.Controls.Add(Me.lblBorderWeight)
        Me.grpBoxBorders.Controls.Add(Me.lblBorderColor)
        Me.grpBoxBorders.Controls.Add(Me.lblBordersSides)
        Me.grpBoxBorders.Enabled = False
        Me.grpBoxBorders.Location = New System.Drawing.Point(7, 295)
        Me.grpBoxBorders.Name = "grpBoxBorders"
        Me.grpBoxBorders.Size = New System.Drawing.Size(594, 109)
        Me.grpBoxBorders.TabIndex = 31
        Me.grpBoxBorders.TabStop = False
        Me.grpBoxBorders.Text = "Borders"
        '
        'lblBordersSides
        '
        Me.lblBordersSides.AutoSize = True
        Me.lblBordersSides.Location = New System.Drawing.Point(6, 20)
        Me.lblBordersSides.Name = "lblBordersSides"
        Me.lblBordersSides.Size = New System.Drawing.Size(36, 13)
        Me.lblBordersSides.TabIndex = 18
        Me.lblBordersSides.Text = "Sides:"
        '
        'ucrCboBorderColor
        '
        Me.ucrCboBorderColor.AddQuotesIfUnrecognised = True
        Me.ucrCboBorderColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboBorderColor.Enabled = False
        Me.ucrCboBorderColor.GetSetSelectedIndex = -1
        Me.ucrCboBorderColor.IsReadOnly = False
        Me.ucrCboBorderColor.Location = New System.Drawing.Point(302, 36)
        Me.ucrCboBorderColor.Name = "ucrCboBorderColor"
        Me.ucrCboBorderColor.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboBorderColor.TabIndex = 23
        '
        'lblBorderColor
        '
        Me.lblBorderColor.AutoSize = True
        Me.lblBorderColor.Enabled = False
        Me.lblBorderColor.Location = New System.Drawing.Point(300, 20)
        Me.lblBorderColor.Name = "lblBorderColor"
        Me.lblBorderColor.Size = New System.Drawing.Size(34, 13)
        Me.lblBorderColor.TabIndex = 22
        Me.lblBorderColor.Text = "Color:"
        '
        'ucrCboBorderWeight
        '
        Me.ucrCboBorderWeight.AddQuotesIfUnrecognised = True
        Me.ucrCboBorderWeight.AutoSize = True
        Me.ucrCboBorderWeight.IsMultiline = False
        Me.ucrCboBorderWeight.IsReadOnly = False
        Me.ucrCboBorderWeight.Location = New System.Drawing.Point(450, 36)
        Me.ucrCboBorderWeight.Name = "ucrCboBorderWeight"
        Me.ucrCboBorderWeight.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboBorderWeight.TabIndex = 22
        '
        'lblBorderWeight
        '
        Me.lblBorderWeight.AutoSize = True
        Me.lblBorderWeight.Location = New System.Drawing.Point(447, 20)
        Me.lblBorderWeight.Name = "lblBorderWeight"
        Me.lblBorderWeight.Size = New System.Drawing.Size(44, 13)
        Me.lblBorderWeight.TabIndex = 21
        Me.lblBorderWeight.Text = "Weight:"
        '
        'lblBorderStyle
        '
        Me.lblBorderStyle.AutoSize = True
        Me.lblBorderStyle.Enabled = False
        Me.lblBorderStyle.Location = New System.Drawing.Point(299, 65)
        Me.lblBorderStyle.Name = "lblBorderStyle"
        Me.lblBorderStyle.Size = New System.Drawing.Size(33, 13)
        Me.lblBorderStyle.TabIndex = 25
        Me.lblBorderStyle.Text = "Style:"
        '
        'ucrCboBorderStyle
        '
        Me.ucrCboBorderStyle.AddQuotesIfUnrecognised = True
        Me.ucrCboBorderStyle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboBorderStyle.Enabled = False
        Me.ucrCboBorderStyle.GetSetSelectedIndex = -1
        Me.ucrCboBorderStyle.IsReadOnly = False
        Me.ucrCboBorderStyle.Location = New System.Drawing.Point(305, 81)
        Me.ucrCboBorderStyle.Name = "ucrCboBorderStyle"
        Me.ucrCboBorderStyle.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboBorderStyle.TabIndex = 24
        '
        'ucrChkBorderLeft
        '
        Me.ucrChkBorderLeft.AutoSize = True
        Me.ucrChkBorderLeft.Checked = False
        Me.ucrChkBorderLeft.Location = New System.Drawing.Point(9, 36)
        Me.ucrChkBorderLeft.Name = "ucrChkBorderLeft"
        Me.ucrChkBorderLeft.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBorderLeft.TabIndex = 26
        '
        'ucrChkBorderRight
        '
        Me.ucrChkBorderRight.AutoSize = True
        Me.ucrChkBorderRight.Checked = False
        Me.ucrChkBorderRight.Location = New System.Drawing.Point(9, 65)
        Me.ucrChkBorderRight.Name = "ucrChkBorderRight"
        Me.ucrChkBorderRight.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBorderRight.TabIndex = 27
        '
        'ucrChkBorderBottom
        '
        Me.ucrChkBorderBottom.AutoSize = True
        Me.ucrChkBorderBottom.Checked = False
        Me.ucrChkBorderBottom.Location = New System.Drawing.Point(115, 63)
        Me.ucrChkBorderBottom.Name = "ucrChkBorderBottom"
        Me.ucrChkBorderBottom.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBorderBottom.TabIndex = 28
        '
        'ucrChkBorderTop
        '
        Me.ucrChkBorderTop.AutoSize = True
        Me.ucrChkBorderTop.Checked = False
        Me.ucrChkBorderTop.Location = New System.Drawing.Point(115, 34)
        Me.ucrChkBorderTop.Name = "ucrChkBorderTop"
        Me.ucrChkBorderTop.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBorderTop.TabIndex = 29
        '
        'sdgTableStyles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 517)
        Me.Controls.Add(Me.grpBoxBorders)
        Me.Controls.Add(Me.grpBoxOthers)
        Me.Controls.Add(Me.grpBoxColor)
        Me.Controls.Add(Me.grpBoxAlignment)
        Me.Controls.Add(Me.grpBoxUnderline)
        Me.Controls.Add(Me.grpBoxFont)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgTableStyles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Format Text"
        Me.grpBoxColor.ResumeLayout(False)
        Me.grpBoxColor.PerformLayout()
        Me.grpBoxAlignment.ResumeLayout(False)
        Me.grpBoxAlignment.PerformLayout()
        Me.grpBoxUnderline.ResumeLayout(False)
        Me.grpBoxUnderline.PerformLayout()
        Me.grpBoxFont.ResumeLayout(False)
        Me.grpBoxFont.PerformLayout()
        Me.grpBoxOthers.ResumeLayout(False)
        Me.grpBoxOthers.PerformLayout()
        Me.grpBoxBorders.ResumeLayout(False)
        Me.grpBoxBorders.PerformLayout()
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
    Friend WithEvents ucrCboUnderLineColor As ucrColors
    Friend WithEvents ucrCboUnderlineStyle As ucrInputComboBox
    Friend WithEvents grpBoxUnderline As GroupBox
    Friend WithEvents lblUnderlineStyle As Label
    Friend WithEvents lblUnderlineColor As Label
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
    Friend WithEvents ucrInputCboTransform As ucrInputComboBox
    Friend WithEvents ucrTxtIndent As ucrInputTextBox
    Friend WithEvents lblIndent As Label
    Friend WithEvents lblWhiteSpace As Label
    Friend WithEvents ucrCboWhiteSpace As ucrInputComboBox
    Friend WithEvents lblStretch As Label
    Friend WithEvents ucrCboStretch As ucrInputComboBox
    Friend WithEvents grpBoxBorders As GroupBox
    Friend WithEvents lblBordersSides As Label
    Friend WithEvents lblBorderStyle As Label
    Friend WithEvents ucrCboBorderStyle As ucrInputComboBox
    Friend WithEvents ucrCboBorderWeight As ucrInputTextBox
    Friend WithEvents ucrCboBorderColor As ucrColors
    Friend WithEvents lblBorderWeight As Label
    Friend WithEvents lblBorderColor As Label
    Friend WithEvents ucrChkBorderTop As ucrCheck
    Friend WithEvents ucrChkBorderBottom As ucrCheck
    Friend WithEvents ucrChkBorderRight As ucrCheck
    Friend WithEvents ucrChkBorderLeft As ucrCheck
End Class
