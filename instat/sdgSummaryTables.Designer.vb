<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgTableOptions
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
        Me.tbTableOptions = New System.Windows.Forms.TabControl()
        Me.tbCells = New System.Windows.Forms.TabPage()
        Me.grpFill = New System.Windows.Forms.GroupBox()
        Me.ucrNudFillTransparency = New instat.ucrNud()
        Me.ucrInputFillColor = New instat.ucrInputComboBox()
        Me.lblFillTransparency = New System.Windows.Forms.Label()
        Me.lblFillColor = New System.Windows.Forms.Label()
        Me.ucrChkEditFill = New instat.ucrCheck()
        Me.ucrChkEditText = New instat.ucrCheck()
        Me.ucrChkEditBorders = New instat.ucrCheck()
        Me.grpBorders = New System.Windows.Forms.GroupBox()
        Me.grpBorderSides = New System.Windows.Forms.GroupBox()
        Me.ucrChkSideBottom = New instat.ucrCheck()
        Me.ucrChkSideTop = New instat.ucrCheck()
        Me.ucrChkSideRight = New instat.ucrCheck()
        Me.ucrChkSideLeft = New instat.ucrCheck()
        Me.ucrInputBorderWeight = New instat.ucrInputComboBox()
        Me.ucrInputBorderStyle = New instat.ucrInputComboBox()
        Me.ucrInputBorderColor = New instat.ucrInputComboBox()
        Me.ucrChkBorderWeight = New instat.ucrCheck()
        Me.ucrChkBorderStyle = New instat.ucrCheck()
        Me.ucrChkBorderColor = New instat.ucrCheck()
        Me.grpText = New System.Windows.Forms.GroupBox()
        Me.ucrInputWeight = New instat.ucrInputComboBox()
        Me.ucrInputSize = New instat.ucrInputComboBox()
        Me.ucrChkIndent = New instat.ucrCheck()
        Me.ucrChkTransform = New instat.ucrCheck()
        Me.ucrChkDecorate = New instat.ucrCheck()
        Me.ucrChkWhitespace = New instat.ucrCheck()
        Me.ucrChkStretch = New instat.ucrCheck()
        Me.ucrChkWeight = New instat.ucrCheck()
        Me.ucrChkStyle = New instat.ucrCheck()
        Me.ucrChkValign = New instat.ucrCheck()
        Me.ucrChkAlign = New instat.ucrCheck()
        Me.ucrChkFont = New instat.ucrCheck()
        Me.ucrChkColor = New instat.ucrCheck()
        Me.ucrChkSize = New instat.ucrCheck()
        Me.ucrInputTransform = New instat.ucrInputComboBox()
        Me.ucrInputDecorate = New instat.ucrInputComboBox()
        Me.ucrInputWhitespace = New instat.ucrInputComboBox()
        Me.ucrInputStretch = New instat.ucrInputComboBox()
        Me.ucrInputStyle = New instat.ucrInputComboBox()
        Me.ucrInputValign = New instat.ucrInputComboBox()
        Me.ucrInputAlign = New instat.ucrInputComboBox()
        Me.ucrInputFont = New instat.ucrInputComboBox()
        Me.ucrInputColor = New instat.ucrInputComboBox()
        Me.ucrNudIndent = New instat.ucrNud()
        Me.tbColumnsRows = New System.Windows.Forms.TabPage()
        Me.tbFormatData = New System.Windows.Forms.TabPage()
        Me.tbSummary = New System.Windows.Forms.TabPage()
        Me.tbInfo = New System.Windows.Forms.TabPage()
        Me.ucrBaseSubDialog = New instat.ucrButtonsSubdialogue()
        Me.tbTableOptions.SuspendLayout()
        Me.tbCells.SuspendLayout()
        Me.grpFill.SuspendLayout()
        Me.grpBorders.SuspendLayout()
        Me.grpBorderSides.SuspendLayout()
        Me.grpText.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbTableOptions
        '
        Me.tbTableOptions.Controls.Add(Me.tbCells)
        Me.tbTableOptions.Controls.Add(Me.tbColumnsRows)
        Me.tbTableOptions.Controls.Add(Me.tbFormatData)
        Me.tbTableOptions.Controls.Add(Me.tbSummary)
        Me.tbTableOptions.Controls.Add(Me.tbInfo)
        Me.tbTableOptions.Location = New System.Drawing.Point(24, 12)
        Me.tbTableOptions.Name = "tbTableOptions"
        Me.tbTableOptions.SelectedIndex = 0
        Me.tbTableOptions.Size = New System.Drawing.Size(799, 451)
        Me.tbTableOptions.TabIndex = 1
        '
        'tbCells
        '
        Me.tbCells.Controls.Add(Me.grpFill)
        Me.tbCells.Controls.Add(Me.ucrChkEditFill)
        Me.tbCells.Controls.Add(Me.ucrChkEditText)
        Me.tbCells.Controls.Add(Me.ucrChkEditBorders)
        Me.tbCells.Controls.Add(Me.grpBorders)
        Me.tbCells.Controls.Add(Me.grpText)
        Me.tbCells.Location = New System.Drawing.Point(4, 25)
        Me.tbCells.Name = "tbCells"
        Me.tbCells.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCells.Size = New System.Drawing.Size(791, 422)
        Me.tbCells.TabIndex = 0
        Me.tbCells.Text = "Cells"
        Me.tbCells.UseVisualStyleBackColor = True
        '
        'grpFill
        '
        Me.grpFill.Controls.Add(Me.ucrNudFillTransparency)
        Me.grpFill.Controls.Add(Me.ucrInputFillColor)
        Me.grpFill.Controls.Add(Me.lblFillTransparency)
        Me.grpFill.Controls.Add(Me.lblFillColor)
        Me.grpFill.Location = New System.Drawing.Point(422, 316)
        Me.grpFill.Name = "grpFill"
        Me.grpFill.Size = New System.Drawing.Size(348, 92)
        Me.grpFill.TabIndex = 5
        Me.grpFill.TabStop = False
        Me.grpFill.Text = "Fill"
        '
        'ucrNudFillTransparency
        '
        Me.ucrNudFillTransparency.AutoSize = True
        Me.ucrNudFillTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFillTransparency.Location = New System.Drawing.Point(168, 49)
        Me.ucrNudFillTransparency.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrNudFillTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFillTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillTransparency.Name = "ucrNudFillTransparency"
        Me.ucrNudFillTransparency.Size = New System.Drawing.Size(171, 25)
        Me.ucrNudFillTransparency.TabIndex = 39
        Me.ucrNudFillTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputFillColor
        '
        Me.ucrInputFillColor.AddQuotesIfUnrecognised = True
        Me.ucrInputFillColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFillColor.GetSetSelectedIndex = -1
        Me.ucrInputFillColor.IsReadOnly = False
        Me.ucrInputFillColor.Location = New System.Drawing.Point(168, 22)
        Me.ucrInputFillColor.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputFillColor.Name = "ucrInputFillColor"
        Me.ucrInputFillColor.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputFillColor.TabIndex = 38
        '
        'lblFillTransparency
        '
        Me.lblFillTransparency.AutoSize = True
        Me.lblFillTransparency.Location = New System.Drawing.Point(8, 49)
        Me.lblFillTransparency.Name = "lblFillTransparency"
        Me.lblFillTransparency.Size = New System.Drawing.Size(94, 16)
        Me.lblFillTransparency.TabIndex = 1
        Me.lblFillTransparency.Text = "Transparency:"
        '
        'lblFillColor
        '
        Me.lblFillColor.AutoSize = True
        Me.lblFillColor.Location = New System.Drawing.Point(8, 22)
        Me.lblFillColor.Name = "lblFillColor"
        Me.lblFillColor.Size = New System.Drawing.Size(42, 16)
        Me.lblFillColor.TabIndex = 0
        Me.lblFillColor.Text = "Color:"
        '
        'ucrChkEditFill
        '
        Me.ucrChkEditFill.AutoSize = True
        Me.ucrChkEditFill.Checked = False
        Me.ucrChkEditFill.Location = New System.Drawing.Point(422, 279)
        Me.ucrChkEditFill.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkEditFill.Name = "ucrChkEditFill"
        Me.ucrChkEditFill.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkEditFill.TabIndex = 4
        '
        'ucrChkEditText
        '
        Me.ucrChkEditText.AutoSize = True
        Me.ucrChkEditText.Checked = False
        Me.ucrChkEditText.Location = New System.Drawing.Point(16, 17)
        Me.ucrChkEditText.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkEditText.Name = "ucrChkEditText"
        Me.ucrChkEditText.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkEditText.TabIndex = 3
        '
        'ucrChkEditBorders
        '
        Me.ucrChkEditBorders.AutoSize = True
        Me.ucrChkEditBorders.Checked = False
        Me.ucrChkEditBorders.Location = New System.Drawing.Point(422, 17)
        Me.ucrChkEditBorders.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkEditBorders.Name = "ucrChkEditBorders"
        Me.ucrChkEditBorders.Size = New System.Drawing.Size(132, 29)
        Me.ucrChkEditBorders.TabIndex = 2
        '
        'grpBorders
        '
        Me.grpBorders.Controls.Add(Me.grpBorderSides)
        Me.grpBorders.Controls.Add(Me.ucrInputBorderWeight)
        Me.grpBorders.Controls.Add(Me.ucrInputBorderStyle)
        Me.grpBorders.Controls.Add(Me.ucrInputBorderColor)
        Me.grpBorders.Controls.Add(Me.ucrChkBorderWeight)
        Me.grpBorders.Controls.Add(Me.ucrChkBorderStyle)
        Me.grpBorders.Controls.Add(Me.ucrChkBorderColor)
        Me.grpBorders.Location = New System.Drawing.Point(422, 50)
        Me.grpBorders.Name = "grpBorders"
        Me.grpBorders.Size = New System.Drawing.Size(348, 215)
        Me.grpBorders.TabIndex = 1
        Me.grpBorders.TabStop = False
        Me.grpBorders.Text = "Borders"
        '
        'grpBorderSides
        '
        Me.grpBorderSides.Controls.Add(Me.ucrChkSideBottom)
        Me.grpBorderSides.Controls.Add(Me.ucrChkSideTop)
        Me.grpBorderSides.Controls.Add(Me.ucrChkSideRight)
        Me.grpBorderSides.Controls.Add(Me.ucrChkSideLeft)
        Me.grpBorderSides.Location = New System.Drawing.Point(8, 27)
        Me.grpBorderSides.Name = "grpBorderSides"
        Me.grpBorderSides.Size = New System.Drawing.Size(331, 83)
        Me.grpBorderSides.TabIndex = 40
        Me.grpBorderSides.TabStop = False
        Me.grpBorderSides.Text = "Sides:"
        '
        'ucrChkSideBottom
        '
        Me.ucrChkSideBottom.AutoSize = True
        Me.ucrChkSideBottom.Checked = False
        Me.ucrChkSideBottom.Location = New System.Drawing.Point(198, 48)
        Me.ucrChkSideBottom.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkSideBottom.Name = "ucrChkSideBottom"
        Me.ucrChkSideBottom.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkSideBottom.TabIndex = 3
        '
        'ucrChkSideTop
        '
        Me.ucrChkSideTop.AutoSize = True
        Me.ucrChkSideTop.Checked = False
        Me.ucrChkSideTop.Location = New System.Drawing.Point(8, 48)
        Me.ucrChkSideTop.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkSideTop.Name = "ucrChkSideTop"
        Me.ucrChkSideTop.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkSideTop.TabIndex = 2
        '
        'ucrChkSideRight
        '
        Me.ucrChkSideRight.AutoSize = True
        Me.ucrChkSideRight.Checked = False
        Me.ucrChkSideRight.Location = New System.Drawing.Point(198, 18)
        Me.ucrChkSideRight.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkSideRight.Name = "ucrChkSideRight"
        Me.ucrChkSideRight.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkSideRight.TabIndex = 1
        '
        'ucrChkSideLeft
        '
        Me.ucrChkSideLeft.AutoSize = True
        Me.ucrChkSideLeft.Checked = False
        Me.ucrChkSideLeft.Location = New System.Drawing.Point(8, 18)
        Me.ucrChkSideLeft.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkSideLeft.Name = "ucrChkSideLeft"
        Me.ucrChkSideLeft.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkSideLeft.TabIndex = 0
        '
        'ucrInputBorderWeight
        '
        Me.ucrInputBorderWeight.AddQuotesIfUnrecognised = True
        Me.ucrInputBorderWeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBorderWeight.GetSetSelectedIndex = -1
        Me.ucrInputBorderWeight.IsReadOnly = False
        Me.ucrInputBorderWeight.Location = New System.Drawing.Point(168, 167)
        Me.ucrInputBorderWeight.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputBorderWeight.Name = "ucrInputBorderWeight"
        Me.ucrInputBorderWeight.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputBorderWeight.TabIndex = 39
        '
        'ucrInputBorderStyle
        '
        Me.ucrInputBorderStyle.AddQuotesIfUnrecognised = True
        Me.ucrInputBorderStyle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBorderStyle.GetSetSelectedIndex = -1
        Me.ucrInputBorderStyle.IsReadOnly = False
        Me.ucrInputBorderStyle.Location = New System.Drawing.Point(168, 140)
        Me.ucrInputBorderStyle.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputBorderStyle.Name = "ucrInputBorderStyle"
        Me.ucrInputBorderStyle.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputBorderStyle.TabIndex = 38
        '
        'ucrInputBorderColor
        '
        Me.ucrInputBorderColor.AddQuotesIfUnrecognised = True
        Me.ucrInputBorderColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBorderColor.GetSetSelectedIndex = -1
        Me.ucrInputBorderColor.IsReadOnly = False
        Me.ucrInputBorderColor.Location = New System.Drawing.Point(168, 113)
        Me.ucrInputBorderColor.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputBorderColor.Name = "ucrInputBorderColor"
        Me.ucrInputBorderColor.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputBorderColor.TabIndex = 37
        '
        'ucrChkBorderWeight
        '
        Me.ucrChkBorderWeight.AutoSize = True
        Me.ucrChkBorderWeight.Checked = False
        Me.ucrChkBorderWeight.Location = New System.Drawing.Point(8, 167)
        Me.ucrChkBorderWeight.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkBorderWeight.Name = "ucrChkBorderWeight"
        Me.ucrChkBorderWeight.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkBorderWeight.TabIndex = 3
        '
        'ucrChkBorderStyle
        '
        Me.ucrChkBorderStyle.AutoSize = True
        Me.ucrChkBorderStyle.Checked = False
        Me.ucrChkBorderStyle.Location = New System.Drawing.Point(8, 140)
        Me.ucrChkBorderStyle.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkBorderStyle.Name = "ucrChkBorderStyle"
        Me.ucrChkBorderStyle.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkBorderStyle.TabIndex = 2
        '
        'ucrChkBorderColor
        '
        Me.ucrChkBorderColor.AutoSize = True
        Me.ucrChkBorderColor.Checked = False
        Me.ucrChkBorderColor.Location = New System.Drawing.Point(8, 113)
        Me.ucrChkBorderColor.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkBorderColor.Name = "ucrChkBorderColor"
        Me.ucrChkBorderColor.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkBorderColor.TabIndex = 1
        '
        'grpText
        '
        Me.grpText.Controls.Add(Me.ucrInputWeight)
        Me.grpText.Controls.Add(Me.ucrInputSize)
        Me.grpText.Controls.Add(Me.ucrChkIndent)
        Me.grpText.Controls.Add(Me.ucrChkTransform)
        Me.grpText.Controls.Add(Me.ucrChkDecorate)
        Me.grpText.Controls.Add(Me.ucrChkWhitespace)
        Me.grpText.Controls.Add(Me.ucrChkStretch)
        Me.grpText.Controls.Add(Me.ucrChkWeight)
        Me.grpText.Controls.Add(Me.ucrChkStyle)
        Me.grpText.Controls.Add(Me.ucrChkValign)
        Me.grpText.Controls.Add(Me.ucrChkAlign)
        Me.grpText.Controls.Add(Me.ucrChkFont)
        Me.grpText.Controls.Add(Me.ucrChkColor)
        Me.grpText.Controls.Add(Me.ucrChkSize)
        Me.grpText.Controls.Add(Me.ucrInputTransform)
        Me.grpText.Controls.Add(Me.ucrInputDecorate)
        Me.grpText.Controls.Add(Me.ucrInputWhitespace)
        Me.grpText.Controls.Add(Me.ucrInputStretch)
        Me.grpText.Controls.Add(Me.ucrInputStyle)
        Me.grpText.Controls.Add(Me.ucrInputValign)
        Me.grpText.Controls.Add(Me.ucrInputAlign)
        Me.grpText.Controls.Add(Me.ucrInputFont)
        Me.grpText.Controls.Add(Me.ucrInputColor)
        Me.grpText.Controls.Add(Me.ucrNudIndent)
        Me.grpText.Location = New System.Drawing.Point(16, 50)
        Me.grpText.Name = "grpText"
        Me.grpText.Size = New System.Drawing.Size(368, 360)
        Me.grpText.TabIndex = 0
        Me.grpText.TabStop = False
        Me.grpText.Text = "Text"
        '
        'ucrInputWeight
        '
        Me.ucrInputWeight.AddQuotesIfUnrecognised = True
        Me.ucrInputWeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputWeight.GetSetSelectedIndex = -1
        Me.ucrInputWeight.IsReadOnly = False
        Me.ucrInputWeight.Location = New System.Drawing.Point(177, 188)
        Me.ucrInputWeight.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputWeight.Name = "ucrInputWeight"
        Me.ucrInputWeight.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputWeight.TabIndex = 36
        '
        'ucrInputSize
        '
        Me.ucrInputSize.AddQuotesIfUnrecognised = True
        Me.ucrInputSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSize.GetSetSelectedIndex = -1
        Me.ucrInputSize.IsReadOnly = False
        Me.ucrInputSize.Location = New System.Drawing.Point(177, 27)
        Me.ucrInputSize.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputSize.Name = "ucrInputSize"
        Me.ucrInputSize.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputSize.TabIndex = 35
        '
        'ucrChkIndent
        '
        Me.ucrChkIndent.AutoSize = True
        Me.ucrChkIndent.Checked = False
        Me.ucrChkIndent.Location = New System.Drawing.Point(8, 323)
        Me.ucrChkIndent.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkIndent.Name = "ucrChkIndent"
        Me.ucrChkIndent.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkIndent.TabIndex = 34
        '
        'ucrChkTransform
        '
        Me.ucrChkTransform.AutoSize = True
        Me.ucrChkTransform.Checked = False
        Me.ucrChkTransform.Location = New System.Drawing.Point(8, 296)
        Me.ucrChkTransform.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkTransform.Name = "ucrChkTransform"
        Me.ucrChkTransform.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkTransform.TabIndex = 33
        '
        'ucrChkDecorate
        '
        Me.ucrChkDecorate.AutoSize = True
        Me.ucrChkDecorate.Checked = False
        Me.ucrChkDecorate.Location = New System.Drawing.Point(8, 269)
        Me.ucrChkDecorate.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkDecorate.Name = "ucrChkDecorate"
        Me.ucrChkDecorate.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkDecorate.TabIndex = 32
        '
        'ucrChkWhitespace
        '
        Me.ucrChkWhitespace.AutoSize = True
        Me.ucrChkWhitespace.Checked = False
        Me.ucrChkWhitespace.Location = New System.Drawing.Point(8, 242)
        Me.ucrChkWhitespace.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkWhitespace.Name = "ucrChkWhitespace"
        Me.ucrChkWhitespace.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkWhitespace.TabIndex = 31
        '
        'ucrChkStretch
        '
        Me.ucrChkStretch.AutoSize = True
        Me.ucrChkStretch.Checked = False
        Me.ucrChkStretch.Location = New System.Drawing.Point(7, 215)
        Me.ucrChkStretch.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkStretch.Name = "ucrChkStretch"
        Me.ucrChkStretch.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkStretch.TabIndex = 30
        '
        'ucrChkWeight
        '
        Me.ucrChkWeight.AutoSize = True
        Me.ucrChkWeight.Checked = False
        Me.ucrChkWeight.Location = New System.Drawing.Point(7, 188)
        Me.ucrChkWeight.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkWeight.Name = "ucrChkWeight"
        Me.ucrChkWeight.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkWeight.TabIndex = 29
        '
        'ucrChkStyle
        '
        Me.ucrChkStyle.AutoSize = True
        Me.ucrChkStyle.Checked = False
        Me.ucrChkStyle.Location = New System.Drawing.Point(7, 162)
        Me.ucrChkStyle.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkStyle.Name = "ucrChkStyle"
        Me.ucrChkStyle.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkStyle.TabIndex = 28
        '
        'ucrChkValign
        '
        Me.ucrChkValign.AutoSize = True
        Me.ucrChkValign.Checked = False
        Me.ucrChkValign.Location = New System.Drawing.Point(7, 135)
        Me.ucrChkValign.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkValign.Name = "ucrChkValign"
        Me.ucrChkValign.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkValign.TabIndex = 27
        '
        'ucrChkAlign
        '
        Me.ucrChkAlign.AutoSize = True
        Me.ucrChkAlign.Checked = False
        Me.ucrChkAlign.Location = New System.Drawing.Point(7, 108)
        Me.ucrChkAlign.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkAlign.Name = "ucrChkAlign"
        Me.ucrChkAlign.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkAlign.TabIndex = 26
        '
        'ucrChkFont
        '
        Me.ucrChkFont.AutoSize = True
        Me.ucrChkFont.Checked = False
        Me.ucrChkFont.Location = New System.Drawing.Point(7, 81)
        Me.ucrChkFont.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkFont.Name = "ucrChkFont"
        Me.ucrChkFont.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkFont.TabIndex = 25
        '
        'ucrChkColor
        '
        Me.ucrChkColor.AutoSize = True
        Me.ucrChkColor.Checked = False
        Me.ucrChkColor.Location = New System.Drawing.Point(7, 54)
        Me.ucrChkColor.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkColor.Name = "ucrChkColor"
        Me.ucrChkColor.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkColor.TabIndex = 24
        '
        'ucrChkSize
        '
        Me.ucrChkSize.AutoSize = True
        Me.ucrChkSize.Checked = False
        Me.ucrChkSize.Location = New System.Drawing.Point(7, 27)
        Me.ucrChkSize.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkSize.Name = "ucrChkSize"
        Me.ucrChkSize.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkSize.TabIndex = 2
        '
        'ucrInputTransform
        '
        Me.ucrInputTransform.AddQuotesIfUnrecognised = True
        Me.ucrInputTransform.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTransform.GetSetSelectedIndex = -1
        Me.ucrInputTransform.IsReadOnly = False
        Me.ucrInputTransform.Location = New System.Drawing.Point(177, 296)
        Me.ucrInputTransform.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputTransform.Name = "ucrInputTransform"
        Me.ucrInputTransform.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputTransform.TabIndex = 23
        '
        'ucrInputDecorate
        '
        Me.ucrInputDecorate.AddQuotesIfUnrecognised = True
        Me.ucrInputDecorate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDecorate.GetSetSelectedIndex = -1
        Me.ucrInputDecorate.IsReadOnly = False
        Me.ucrInputDecorate.Location = New System.Drawing.Point(177, 269)
        Me.ucrInputDecorate.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputDecorate.Name = "ucrInputDecorate"
        Me.ucrInputDecorate.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputDecorate.TabIndex = 22
        '
        'ucrInputWhitespace
        '
        Me.ucrInputWhitespace.AddQuotesIfUnrecognised = True
        Me.ucrInputWhitespace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputWhitespace.GetSetSelectedIndex = -1
        Me.ucrInputWhitespace.IsReadOnly = False
        Me.ucrInputWhitespace.Location = New System.Drawing.Point(177, 242)
        Me.ucrInputWhitespace.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputWhitespace.Name = "ucrInputWhitespace"
        Me.ucrInputWhitespace.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputWhitespace.TabIndex = 21
        '
        'ucrInputStretch
        '
        Me.ucrInputStretch.AddQuotesIfUnrecognised = True
        Me.ucrInputStretch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStretch.GetSetSelectedIndex = -1
        Me.ucrInputStretch.IsReadOnly = False
        Me.ucrInputStretch.Location = New System.Drawing.Point(177, 215)
        Me.ucrInputStretch.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputStretch.Name = "ucrInputStretch"
        Me.ucrInputStretch.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputStretch.TabIndex = 20
        '
        'ucrInputStyle
        '
        Me.ucrInputStyle.AddQuotesIfUnrecognised = True
        Me.ucrInputStyle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStyle.GetSetSelectedIndex = -1
        Me.ucrInputStyle.IsReadOnly = False
        Me.ucrInputStyle.Location = New System.Drawing.Point(177, 162)
        Me.ucrInputStyle.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputStyle.Name = "ucrInputStyle"
        Me.ucrInputStyle.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputStyle.TabIndex = 19
        '
        'ucrInputValign
        '
        Me.ucrInputValign.AddQuotesIfUnrecognised = True
        Me.ucrInputValign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputValign.GetSetSelectedIndex = -1
        Me.ucrInputValign.IsReadOnly = False
        Me.ucrInputValign.Location = New System.Drawing.Point(177, 135)
        Me.ucrInputValign.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputValign.Name = "ucrInputValign"
        Me.ucrInputValign.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputValign.TabIndex = 18
        '
        'ucrInputAlign
        '
        Me.ucrInputAlign.AddQuotesIfUnrecognised = True
        Me.ucrInputAlign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAlign.GetSetSelectedIndex = -1
        Me.ucrInputAlign.IsReadOnly = False
        Me.ucrInputAlign.Location = New System.Drawing.Point(177, 108)
        Me.ucrInputAlign.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputAlign.Name = "ucrInputAlign"
        Me.ucrInputAlign.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputAlign.TabIndex = 17
        '
        'ucrInputFont
        '
        Me.ucrInputFont.AddQuotesIfUnrecognised = True
        Me.ucrInputFont.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFont.GetSetSelectedIndex = -1
        Me.ucrInputFont.IsReadOnly = False
        Me.ucrInputFont.Location = New System.Drawing.Point(177, 81)
        Me.ucrInputFont.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputFont.Name = "ucrInputFont"
        Me.ucrInputFont.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputFont.TabIndex = 16
        '
        'ucrInputColor
        '
        Me.ucrInputColor.AddQuotesIfUnrecognised = True
        Me.ucrInputColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColor.GetSetSelectedIndex = -1
        Me.ucrInputColor.IsReadOnly = False
        Me.ucrInputColor.Location = New System.Drawing.Point(177, 54)
        Me.ucrInputColor.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputColor.Name = "ucrInputColor"
        Me.ucrInputColor.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputColor.TabIndex = 15
        '
        'ucrNudIndent
        '
        Me.ucrNudIndent.AutoSize = True
        Me.ucrNudIndent.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudIndent.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudIndent.Location = New System.Drawing.Point(177, 323)
        Me.ucrNudIndent.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrNudIndent.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudIndent.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudIndent.Name = "ucrNudIndent"
        Me.ucrNudIndent.Size = New System.Drawing.Size(171, 25)
        Me.ucrNudIndent.TabIndex = 14
        Me.ucrNudIndent.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'tbColumnsRows
        '
        Me.tbColumnsRows.Location = New System.Drawing.Point(4, 25)
        Me.tbColumnsRows.Name = "tbColumnsRows"
        Me.tbColumnsRows.Padding = New System.Windows.Forms.Padding(3)
        Me.tbColumnsRows.Size = New System.Drawing.Size(791, 422)
        Me.tbColumnsRows.TabIndex = 1
        Me.tbColumnsRows.Text = "Columns & Rows"
        Me.tbColumnsRows.UseVisualStyleBackColor = True
        '
        'tbFormatData
        '
        Me.tbFormatData.Location = New System.Drawing.Point(4, 25)
        Me.tbFormatData.Name = "tbFormatData"
        Me.tbFormatData.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFormatData.Size = New System.Drawing.Size(791, 422)
        Me.tbFormatData.TabIndex = 2
        Me.tbFormatData.Text = "Format Data"
        Me.tbFormatData.UseVisualStyleBackColor = True
        '
        'tbSummary
        '
        Me.tbSummary.Location = New System.Drawing.Point(4, 25)
        Me.tbSummary.Name = "tbSummary"
        Me.tbSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSummary.Size = New System.Drawing.Size(791, 422)
        Me.tbSummary.TabIndex = 3
        Me.tbSummary.Text = "Summary"
        Me.tbSummary.UseVisualStyleBackColor = True
        '
        'tbInfo
        '
        Me.tbInfo.Location = New System.Drawing.Point(4, 25)
        Me.tbInfo.Name = "tbInfo"
        Me.tbInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tbInfo.Size = New System.Drawing.Size(791, 422)
        Me.tbInfo.TabIndex = 4
        Me.tbInfo.Text = "Info"
        Me.tbInfo.UseVisualStyleBackColor = True
        '
        'ucrBaseSubDialog
        '
        Me.ucrBaseSubDialog.AutoSize = True
        Me.ucrBaseSubDialog.Location = New System.Drawing.Point(271, 470)
        Me.ucrBaseSubDialog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrBaseSubDialog.Name = "ucrBaseSubDialog"
        Me.ucrBaseSubDialog.Size = New System.Drawing.Size(281, 37)
        Me.ucrBaseSubDialog.TabIndex = 37
        '
        'sdgTableOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 513)
        Me.Controls.Add(Me.ucrBaseSubDialog)
        Me.Controls.Add(Me.tbTableOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgTableOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "+"
        Me.tbTableOptions.ResumeLayout(False)
        Me.tbCells.ResumeLayout(False)
        Me.tbCells.PerformLayout()
        Me.grpFill.ResumeLayout(False)
        Me.grpFill.PerformLayout()
        Me.grpBorders.ResumeLayout(False)
        Me.grpBorders.PerformLayout()
        Me.grpBorderSides.ResumeLayout(False)
        Me.grpBorderSides.PerformLayout()
        Me.grpText.ResumeLayout(False)
        Me.grpText.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbTableOptions As TabControl
    Friend WithEvents tbCells As TabPage
    Friend WithEvents tbColumnsRows As TabPage
    Friend WithEvents tbFormatData As TabPage
    Friend WithEvents tbSummary As TabPage
    Friend WithEvents tbInfo As TabPage
    Friend WithEvents grpText As GroupBox
    Friend WithEvents ucrInputTransform As ucrInputComboBox
    Friend WithEvents ucrInputDecorate As ucrInputComboBox
    Friend WithEvents ucrInputWhitespace As ucrInputComboBox
    Friend WithEvents ucrInputStretch As ucrInputComboBox
    Friend WithEvents ucrInputStyle As ucrInputComboBox
    Friend WithEvents ucrInputValign As ucrInputComboBox
    Friend WithEvents ucrInputAlign As ucrInputComboBox
    Friend WithEvents ucrInputFont As ucrInputComboBox
    Friend WithEvents ucrInputColor As ucrInputComboBox
    Friend WithEvents ucrChkSize As ucrCheck
    Friend WithEvents ucrChkIndent As ucrCheck
    Friend WithEvents ucrChkTransform As ucrCheck
    Friend WithEvents ucrChkDecorate As ucrCheck
    Friend WithEvents ucrChkWhitespace As ucrCheck
    Friend WithEvents ucrChkStretch As ucrCheck
    Friend WithEvents ucrChkWeight As ucrCheck
    Friend WithEvents ucrChkStyle As ucrCheck
    Friend WithEvents ucrChkValign As ucrCheck
    Friend WithEvents ucrChkAlign As ucrCheck
    Friend WithEvents ucrChkFont As ucrCheck
    Friend WithEvents ucrChkColor As ucrCheck
    Friend WithEvents ucrInputWeight As ucrInputComboBox
    Friend WithEvents ucrInputSize As ucrInputComboBox
    Friend WithEvents ucrNudIndent As ucrNud
    Friend WithEvents ucrBaseSubDialog As ucrButtonsSubdialogue
    Friend WithEvents grpBorders As GroupBox
    Friend WithEvents ucrChkBorderWeight As ucrCheck
    Friend WithEvents ucrChkBorderStyle As ucrCheck
    Friend WithEvents ucrChkBorderColor As ucrCheck
    Friend WithEvents ucrChkEditBorders As ucrCheck
    Friend WithEvents ucrInputBorderWeight As ucrInputComboBox
    Friend WithEvents grpFill As GroupBox
    Friend WithEvents ucrChkEditFill As ucrCheck
    Friend WithEvents ucrChkEditText As ucrCheck
    Friend WithEvents ucrInputBorderStyle As ucrInputComboBox
    Friend WithEvents ucrInputBorderColor As ucrInputComboBox
    Friend WithEvents grpBorderSides As GroupBox
    Friend WithEvents ucrChkSideBottom As ucrCheck
    Friend WithEvents ucrChkSideTop As ucrCheck
    Friend WithEvents ucrChkSideRight As ucrCheck
    Friend WithEvents ucrChkSideLeft As ucrCheck
    Friend WithEvents ucrNudFillTransparency As ucrNud
    Friend WithEvents ucrInputFillColor As ucrInputComboBox
    Friend WithEvents lblFillTransparency As Label
    Friend WithEvents lblFillColor As Label
End Class
