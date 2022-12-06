<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgSummaryThemes
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
        Me.tbSummaryThemes = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tbThemeTitles = New System.Windows.Forms.TabPage()
        Me.grpSubTitle = New System.Windows.Forms.GroupBox()
        Me.ucrInputSubTitleWeight = New instat.ucrInputComboBox()
        Me.ucrInputSubTitleSize = New instat.ucrInputComboBox()
        Me.grpTitle = New System.Windows.Forms.GroupBox()
        Me.ucrInputFontWeight = New instat.ucrInputComboBox()
        Me.ucrInputFontSize = New instat.ucrInputComboBox()
        Me.ucrInputAlignment = New instat.ucrInputComboBox()
        Me.ucrInputBackgroundColour = New instat.ucrInputComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.ucrInputBoxWidth = New instat.ucrInputComboBox()
        Me.ucrInputBoxLength = New instat.ucrInputComboBox()
        Me.ucrInputBottomWidth = New instat.ucrInputComboBox()
        Me.ucrInputBottomStyle = New instat.ucrInputComboBox()
        Me.ucrInputBottomColour = New instat.ucrInputComboBox()
        Me.ucrInputSideWidth = New instat.ucrInputComboBox()
        Me.ucrInputSideStyle = New instat.ucrInputComboBox()
        Me.ucrInputSideColour = New instat.ucrInputComboBox()
        Me.ucrChkBoxWidth = New instat.ucrCheck()
        Me.ucrChkBoxLength = New instat.ucrCheck()
        Me.ucrChkBottomWidth = New instat.ucrCheck()
        Me.ucrChkBottomStyle = New instat.ucrCheck()
        Me.ucrChkBottomColour = New instat.ucrCheck()
        Me.grpHeadingBorder = New System.Windows.Forms.GroupBox()
        Me.ucrChkSideWidth = New instat.ucrCheck()
        Me.ucrChkSideStyle = New instat.ucrCheck()
        Me.ucrChkSideColour = New instat.ucrCheck()
        Me.ucrChkFontSize = New instat.ucrCheck()
        Me.ucrChkFontWeight = New instat.ucrCheck()
        Me.ucrChkSubTitleSize = New instat.ucrCheck()
        Me.ucrChkSubTitleWeight = New instat.ucrCheck()
        Me.ucrChkAlignment = New instat.ucrCheck()
        Me.ucrChkBackgroundColour = New instat.ucrCheck()
        Me.tbSummaryThemes.SuspendLayout()
        Me.tbThemeTitles.SuspendLayout()
        Me.grpSubTitle.SuspendLayout()
        Me.grpTitle.SuspendLayout()
        Me.grpHeadingBorder.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSummaryThemes
        '
        Me.tbSummaryThemes.Controls.Add(Me.TabPage1)
        Me.tbSummaryThemes.Controls.Add(Me.tbThemeTitles)
        Me.tbSummaryThemes.Controls.Add(Me.TabPage3)
        Me.tbSummaryThemes.Controls.Add(Me.TabPage4)
        Me.tbSummaryThemes.Controls.Add(Me.TabPage5)
        Me.tbSummaryThemes.Controls.Add(Me.TabPage6)
        Me.tbSummaryThemes.Controls.Add(Me.TabPage7)
        Me.tbSummaryThemes.Location = New System.Drawing.Point(5, 1)
        Me.tbSummaryThemes.Name = "tbSummaryThemes"
        Me.tbSummaryThemes.SelectedIndex = 0
        Me.tbSummaryThemes.Size = New System.Drawing.Size(736, 372)
        Me.tbSummaryThemes.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(728, 346)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Table"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tbThemeTitles
        '
        Me.tbThemeTitles.Controls.Add(Me.ucrChkBackgroundColour)
        Me.tbThemeTitles.Controls.Add(Me.ucrChkAlignment)
        Me.tbThemeTitles.Controls.Add(Me.grpHeadingBorder)
        Me.tbThemeTitles.Controls.Add(Me.grpSubTitle)
        Me.tbThemeTitles.Controls.Add(Me.grpTitle)
        Me.tbThemeTitles.Controls.Add(Me.ucrInputAlignment)
        Me.tbThemeTitles.Controls.Add(Me.ucrInputBackgroundColour)
        Me.tbThemeTitles.Location = New System.Drawing.Point(4, 22)
        Me.tbThemeTitles.Name = "tbThemeTitles"
        Me.tbThemeTitles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbThemeTitles.Size = New System.Drawing.Size(728, 346)
        Me.tbThemeTitles.TabIndex = 1
        Me.tbThemeTitles.Text = "Titles"
        Me.tbThemeTitles.UseVisualStyleBackColor = True
        '
        'grpSubTitle
        '
        Me.grpSubTitle.Controls.Add(Me.ucrChkSubTitleWeight)
        Me.grpSubTitle.Controls.Add(Me.ucrChkSubTitleSize)
        Me.grpSubTitle.Controls.Add(Me.ucrInputSubTitleWeight)
        Me.grpSubTitle.Controls.Add(Me.ucrInputSubTitleSize)
        Me.grpSubTitle.Location = New System.Drawing.Point(28, 184)
        Me.grpSubTitle.Name = "grpSubTitle"
        Me.grpSubTitle.Size = New System.Drawing.Size(277, 76)
        Me.grpSubTitle.TabIndex = 5
        Me.grpSubTitle.TabStop = False
        Me.grpSubTitle.Text = "Sub -Title"
        '
        'ucrInputSubTitleWeight
        '
        Me.ucrInputSubTitleWeight.AddQuotesIfUnrecognised = True
        Me.ucrInputSubTitleWeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSubTitleWeight.GetSetSelectedIndex = -1
        Me.ucrInputSubTitleWeight.IsReadOnly = False
        Me.ucrInputSubTitleWeight.Location = New System.Drawing.Point(130, 43)
        Me.ucrInputSubTitleWeight.Name = "ucrInputSubTitleWeight"
        Me.ucrInputSubTitleWeight.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSubTitleWeight.TabIndex = 5
        '
        'ucrInputSubTitleSize
        '
        Me.ucrInputSubTitleSize.AddQuotesIfUnrecognised = True
        Me.ucrInputSubTitleSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSubTitleSize.GetSetSelectedIndex = -1
        Me.ucrInputSubTitleSize.IsReadOnly = False
        Me.ucrInputSubTitleSize.Location = New System.Drawing.Point(130, 16)
        Me.ucrInputSubTitleSize.Name = "ucrInputSubTitleSize"
        Me.ucrInputSubTitleSize.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSubTitleSize.TabIndex = 4
        '
        'grpTitle
        '
        Me.grpTitle.Controls.Add(Me.ucrChkFontWeight)
        Me.grpTitle.Controls.Add(Me.ucrChkFontSize)
        Me.grpTitle.Controls.Add(Me.ucrInputFontWeight)
        Me.grpTitle.Controls.Add(Me.ucrInputFontSize)
        Me.grpTitle.Location = New System.Drawing.Point(28, 88)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Size = New System.Drawing.Size(277, 76)
        Me.grpTitle.TabIndex = 4
        Me.grpTitle.TabStop = False
        Me.grpTitle.Text = "Title"
        '
        'ucrInputFontWeight
        '
        Me.ucrInputFontWeight.AddQuotesIfUnrecognised = True
        Me.ucrInputFontWeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFontWeight.GetSetSelectedIndex = -1
        Me.ucrInputFontWeight.IsReadOnly = False
        Me.ucrInputFontWeight.Location = New System.Drawing.Point(130, 49)
        Me.ucrInputFontWeight.Name = "ucrInputFontWeight"
        Me.ucrInputFontWeight.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFontWeight.TabIndex = 5
        '
        'ucrInputFontSize
        '
        Me.ucrInputFontSize.AddQuotesIfUnrecognised = True
        Me.ucrInputFontSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFontSize.GetSetSelectedIndex = -1
        Me.ucrInputFontSize.IsReadOnly = False
        Me.ucrInputFontSize.Location = New System.Drawing.Point(130, 16)
        Me.ucrInputFontSize.Name = "ucrInputFontSize"
        Me.ucrInputFontSize.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFontSize.TabIndex = 4
        '
        'ucrInputAlignment
        '
        Me.ucrInputAlignment.AddQuotesIfUnrecognised = True
        Me.ucrInputAlignment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAlignment.GetSetSelectedIndex = -1
        Me.ucrInputAlignment.IsReadOnly = False
        Me.ucrInputAlignment.Location = New System.Drawing.Point(158, 54)
        Me.ucrInputAlignment.Name = "ucrInputAlignment"
        Me.ucrInputAlignment.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputAlignment.TabIndex = 3
        '
        'ucrInputBackgroundColour
        '
        Me.ucrInputBackgroundColour.AddQuotesIfUnrecognised = True
        Me.ucrInputBackgroundColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBackgroundColour.GetSetSelectedIndex = -1
        Me.ucrInputBackgroundColour.IsReadOnly = False
        Me.ucrInputBackgroundColour.Location = New System.Drawing.Point(158, 22)
        Me.ucrInputBackgroundColour.Name = "ucrInputBackgroundColour"
        Me.ucrInputBackgroundColour.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputBackgroundColour.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(728, 346)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Columns"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(728, 346)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Rows"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(728, 346)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Stub"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(728, 346)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Footnotes"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(728, 346)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Sourcenotes"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'ucrInputBoxWidth
        '
        Me.ucrInputBoxWidth.AddQuotesIfUnrecognised = True
        Me.ucrInputBoxWidth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBoxWidth.GetSetSelectedIndex = -1
        Me.ucrInputBoxWidth.IsReadOnly = False
        Me.ucrInputBoxWidth.Location = New System.Drawing.Point(170, 16)
        Me.ucrInputBoxWidth.Name = "ucrInputBoxWidth"
        Me.ucrInputBoxWidth.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputBoxWidth.TabIndex = 4
        '
        'ucrInputBoxLength
        '
        Me.ucrInputBoxLength.AddQuotesIfUnrecognised = True
        Me.ucrInputBoxLength.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBoxLength.GetSetSelectedIndex = -1
        Me.ucrInputBoxLength.IsReadOnly = False
        Me.ucrInputBoxLength.Location = New System.Drawing.Point(170, 43)
        Me.ucrInputBoxLength.Name = "ucrInputBoxLength"
        Me.ucrInputBoxLength.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputBoxLength.TabIndex = 5
        '
        'ucrInputBottomWidth
        '
        Me.ucrInputBottomWidth.AddQuotesIfUnrecognised = True
        Me.ucrInputBottomWidth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBottomWidth.GetSetSelectedIndex = -1
        Me.ucrInputBottomWidth.IsReadOnly = False
        Me.ucrInputBottomWidth.Location = New System.Drawing.Point(170, 70)
        Me.ucrInputBottomWidth.Name = "ucrInputBottomWidth"
        Me.ucrInputBottomWidth.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputBottomWidth.TabIndex = 6
        '
        'ucrInputBottomStyle
        '
        Me.ucrInputBottomStyle.AddQuotesIfUnrecognised = True
        Me.ucrInputBottomStyle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBottomStyle.GetSetSelectedIndex = -1
        Me.ucrInputBottomStyle.IsReadOnly = False
        Me.ucrInputBottomStyle.Location = New System.Drawing.Point(170, 97)
        Me.ucrInputBottomStyle.Name = "ucrInputBottomStyle"
        Me.ucrInputBottomStyle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputBottomStyle.TabIndex = 7
        '
        'ucrInputBottomColour
        '
        Me.ucrInputBottomColour.AddQuotesIfUnrecognised = True
        Me.ucrInputBottomColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBottomColour.GetSetSelectedIndex = -1
        Me.ucrInputBottomColour.IsReadOnly = False
        Me.ucrInputBottomColour.Location = New System.Drawing.Point(170, 124)
        Me.ucrInputBottomColour.Name = "ucrInputBottomColour"
        Me.ucrInputBottomColour.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputBottomColour.TabIndex = 8
        '
        'ucrInputSideWidth
        '
        Me.ucrInputSideWidth.AddQuotesIfUnrecognised = True
        Me.ucrInputSideWidth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSideWidth.GetSetSelectedIndex = -1
        Me.ucrInputSideWidth.IsReadOnly = False
        Me.ucrInputSideWidth.Location = New System.Drawing.Point(170, 151)
        Me.ucrInputSideWidth.Name = "ucrInputSideWidth"
        Me.ucrInputSideWidth.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSideWidth.TabIndex = 9
        '
        'ucrInputSideStyle
        '
        Me.ucrInputSideStyle.AddQuotesIfUnrecognised = True
        Me.ucrInputSideStyle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSideStyle.GetSetSelectedIndex = -1
        Me.ucrInputSideStyle.IsReadOnly = False
        Me.ucrInputSideStyle.Location = New System.Drawing.Point(170, 178)
        Me.ucrInputSideStyle.Name = "ucrInputSideStyle"
        Me.ucrInputSideStyle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSideStyle.TabIndex = 14
        '
        'ucrInputSideColour
        '
        Me.ucrInputSideColour.AddQuotesIfUnrecognised = True
        Me.ucrInputSideColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSideColour.GetSetSelectedIndex = -1
        Me.ucrInputSideColour.IsReadOnly = False
        Me.ucrInputSideColour.Location = New System.Drawing.Point(170, 207)
        Me.ucrInputSideColour.Name = "ucrInputSideColour"
        Me.ucrInputSideColour.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSideColour.TabIndex = 15
        '
        'ucrChkBoxWidth
        '
        Me.ucrChkBoxWidth.AutoSize = True
        Me.ucrChkBoxWidth.Checked = False
        Me.ucrChkBoxWidth.Location = New System.Drawing.Point(15, 21)
        Me.ucrChkBoxWidth.Name = "ucrChkBoxWidth"
        Me.ucrChkBoxWidth.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBoxWidth.TabIndex = 18
        '
        'ucrChkBoxLength
        '
        Me.ucrChkBoxLength.AutoSize = True
        Me.ucrChkBoxLength.Checked = False
        Me.ucrChkBoxLength.Location = New System.Drawing.Point(15, 43)
        Me.ucrChkBoxLength.Name = "ucrChkBoxLength"
        Me.ucrChkBoxLength.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBoxLength.TabIndex = 19
        '
        'ucrChkBottomWidth
        '
        Me.ucrChkBottomWidth.AutoSize = True
        Me.ucrChkBottomWidth.Checked = False
        Me.ucrChkBottomWidth.Location = New System.Drawing.Point(15, 69)
        Me.ucrChkBottomWidth.Name = "ucrChkBottomWidth"
        Me.ucrChkBottomWidth.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBottomWidth.TabIndex = 20
        '
        'ucrChkBottomStyle
        '
        Me.ucrChkBottomStyle.AutoSize = True
        Me.ucrChkBottomStyle.Checked = False
        Me.ucrChkBottomStyle.Location = New System.Drawing.Point(15, 97)
        Me.ucrChkBottomStyle.Name = "ucrChkBottomStyle"
        Me.ucrChkBottomStyle.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBottomStyle.TabIndex = 21
        '
        'ucrChkBottomColour
        '
        Me.ucrChkBottomColour.AutoSize = True
        Me.ucrChkBottomColour.Checked = False
        Me.ucrChkBottomColour.Location = New System.Drawing.Point(15, 124)
        Me.ucrChkBottomColour.Name = "ucrChkBottomColour"
        Me.ucrChkBottomColour.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBottomColour.TabIndex = 22
        '
        'grpHeadingBorder
        '
        Me.grpHeadingBorder.Controls.Add(Me.ucrChkSideColour)
        Me.grpHeadingBorder.Controls.Add(Me.ucrChkSideStyle)
        Me.grpHeadingBorder.Controls.Add(Me.ucrChkSideWidth)
        Me.grpHeadingBorder.Controls.Add(Me.ucrChkBottomColour)
        Me.grpHeadingBorder.Controls.Add(Me.ucrChkBottomStyle)
        Me.grpHeadingBorder.Controls.Add(Me.ucrChkBottomWidth)
        Me.grpHeadingBorder.Controls.Add(Me.ucrChkBoxLength)
        Me.grpHeadingBorder.Controls.Add(Me.ucrChkBoxWidth)
        Me.grpHeadingBorder.Controls.Add(Me.ucrInputSideColour)
        Me.grpHeadingBorder.Controls.Add(Me.ucrInputSideStyle)
        Me.grpHeadingBorder.Controls.Add(Me.ucrInputSideWidth)
        Me.grpHeadingBorder.Controls.Add(Me.ucrInputBottomColour)
        Me.grpHeadingBorder.Controls.Add(Me.ucrInputBottomStyle)
        Me.grpHeadingBorder.Controls.Add(Me.ucrInputBottomWidth)
        Me.grpHeadingBorder.Controls.Add(Me.ucrInputBoxLength)
        Me.grpHeadingBorder.Controls.Add(Me.ucrInputBoxWidth)
        Me.grpHeadingBorder.Location = New System.Drawing.Point(324, 18)
        Me.grpHeadingBorder.Name = "grpHeadingBorder"
        Me.grpHeadingBorder.Size = New System.Drawing.Size(314, 238)
        Me.grpHeadingBorder.TabIndex = 6
        Me.grpHeadingBorder.TabStop = False
        Me.grpHeadingBorder.Text = "Heading Border"
        '
        'ucrChkSideWidth
        '
        Me.ucrChkSideWidth.AutoSize = True
        Me.ucrChkSideWidth.Checked = False
        Me.ucrChkSideWidth.Location = New System.Drawing.Point(15, 151)
        Me.ucrChkSideWidth.Name = "ucrChkSideWidth"
        Me.ucrChkSideWidth.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSideWidth.TabIndex = 23
        '
        'ucrChkSideStyle
        '
        Me.ucrChkSideStyle.AutoSize = True
        Me.ucrChkSideStyle.Checked = False
        Me.ucrChkSideStyle.Location = New System.Drawing.Point(15, 178)
        Me.ucrChkSideStyle.Name = "ucrChkSideStyle"
        Me.ucrChkSideStyle.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSideStyle.TabIndex = 24
        '
        'ucrChkSideColour
        '
        Me.ucrChkSideColour.AutoSize = True
        Me.ucrChkSideColour.Checked = False
        Me.ucrChkSideColour.Location = New System.Drawing.Point(15, 207)
        Me.ucrChkSideColour.Name = "ucrChkSideColour"
        Me.ucrChkSideColour.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSideColour.TabIndex = 25
        '
        'ucrChkFontSize
        '
        Me.ucrChkFontSize.AutoSize = True
        Me.ucrChkFontSize.Checked = False
        Me.ucrChkFontSize.Location = New System.Drawing.Point(6, 16)
        Me.ucrChkFontSize.Name = "ucrChkFontSize"
        Me.ucrChkFontSize.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkFontSize.TabIndex = 19
        '
        'ucrChkFontWeight
        '
        Me.ucrChkFontWeight.AutoSize = True
        Me.ucrChkFontWeight.Checked = False
        Me.ucrChkFontWeight.Location = New System.Drawing.Point(6, 45)
        Me.ucrChkFontWeight.Name = "ucrChkFontWeight"
        Me.ucrChkFontWeight.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkFontWeight.TabIndex = 20
        '
        'ucrChkSubTitleSize
        '
        Me.ucrChkSubTitleSize.AutoSize = True
        Me.ucrChkSubTitleSize.Checked = False
        Me.ucrChkSubTitleSize.Location = New System.Drawing.Point(6, 16)
        Me.ucrChkSubTitleSize.Name = "ucrChkSubTitleSize"
        Me.ucrChkSubTitleSize.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSubTitleSize.TabIndex = 19
        '
        'ucrChkSubTitleWeight
        '
        Me.ucrChkSubTitleWeight.AutoSize = True
        Me.ucrChkSubTitleWeight.Checked = False
        Me.ucrChkSubTitleWeight.Location = New System.Drawing.Point(6, 41)
        Me.ucrChkSubTitleWeight.Name = "ucrChkSubTitleWeight"
        Me.ucrChkSubTitleWeight.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSubTitleWeight.TabIndex = 20
        '
        'ucrChkAlignment
        '
        Me.ucrChkAlignment.AutoSize = True
        Me.ucrChkAlignment.Checked = False
        Me.ucrChkAlignment.Location = New System.Drawing.Point(34, 54)
        Me.ucrChkAlignment.Name = "ucrChkAlignment"
        Me.ucrChkAlignment.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkAlignment.TabIndex = 19
        '
        'ucrChkBackgroundColour
        '
        Me.ucrChkBackgroundColour.AutoSize = True
        Me.ucrChkBackgroundColour.Checked = False
        Me.ucrChkBackgroundColour.Location = New System.Drawing.Point(34, 22)
        Me.ucrChkBackgroundColour.Name = "ucrChkBackgroundColour"
        Me.ucrChkBackgroundColour.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBackgroundColour.TabIndex = 20
        '
        'sdgSummaryThemes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 386)
        Me.Controls.Add(Me.tbSummaryThemes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSummaryThemes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Themes"
        Me.tbSummaryThemes.ResumeLayout(False)
        Me.tbThemeTitles.ResumeLayout(False)
        Me.tbThemeTitles.PerformLayout()
        Me.grpSubTitle.ResumeLayout(False)
        Me.grpSubTitle.PerformLayout()
        Me.grpTitle.ResumeLayout(False)
        Me.grpTitle.PerformLayout()
        Me.grpHeadingBorder.ResumeLayout(False)
        Me.grpHeadingBorder.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbSummaryThemes As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tbThemeTitles As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents grpSubTitle As GroupBox
    Friend WithEvents ucrInputSubTitleWeight As ucrInputComboBox
    Friend WithEvents ucrInputSubTitleSize As ucrInputComboBox
    Friend WithEvents grpTitle As GroupBox
    Friend WithEvents ucrInputFontWeight As ucrInputComboBox
    Friend WithEvents ucrInputFontSize As ucrInputComboBox
    Friend WithEvents ucrInputAlignment As ucrInputComboBox
    Friend WithEvents ucrInputBackgroundColour As ucrInputComboBox
    Friend WithEvents ucrChkBackgroundColour As ucrCheck
    Friend WithEvents ucrChkAlignment As ucrCheck
    Friend WithEvents grpHeadingBorder As GroupBox
    Friend WithEvents ucrChkSideColour As ucrCheck
    Friend WithEvents ucrChkSideStyle As ucrCheck
    Friend WithEvents ucrChkSideWidth As ucrCheck
    Friend WithEvents ucrChkBottomColour As ucrCheck
    Friend WithEvents ucrChkBottomStyle As ucrCheck
    Friend WithEvents ucrChkBottomWidth As ucrCheck
    Friend WithEvents ucrChkBoxLength As ucrCheck
    Friend WithEvents ucrChkBoxWidth As ucrCheck
    Friend WithEvents ucrInputSideColour As ucrInputComboBox
    Friend WithEvents ucrInputSideStyle As ucrInputComboBox
    Friend WithEvents ucrInputSideWidth As ucrInputComboBox
    Friend WithEvents ucrInputBottomColour As ucrInputComboBox
    Friend WithEvents ucrInputBottomStyle As ucrInputComboBox
    Friend WithEvents ucrInputBottomWidth As ucrInputComboBox
    Friend WithEvents ucrInputBoxLength As ucrInputComboBox
    Friend WithEvents ucrInputBoxWidth As ucrInputComboBox
    Friend WithEvents ucrChkSubTitleWeight As ucrCheck
    Friend WithEvents ucrChkSubTitleSize As ucrCheck
    Friend WithEvents ucrChkFontWeight As ucrCheck
    Friend WithEvents ucrChkFontSize As ucrCheck
End Class
