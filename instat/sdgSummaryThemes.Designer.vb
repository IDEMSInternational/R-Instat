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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSideWidth = New System.Windows.Forms.Label()
        Me.lblBottomColour = New System.Windows.Forms.Label()
        Me.lblBottomStyle = New System.Windows.Forms.Label()
        Me.lblBottomWidth = New System.Windows.Forms.Label()
        Me.ucrInputSideWidth = New instat.ucrInputComboBox()
        Me.ucrInputBottomColour = New instat.ucrInputComboBox()
        Me.ucrInputBottomStyle = New instat.ucrInputComboBox()
        Me.ucrInputBottomWidth = New instat.ucrInputComboBox()
        Me.ucrInputBoxLength = New instat.ucrInputComboBox()
        Me.ucrInputBoxWidth = New instat.ucrInputComboBox()
        Me.lblBoxLength = New System.Windows.Forms.Label()
        Me.lblBoxWidth = New System.Windows.Forms.Label()
        Me.grpSubTitle = New System.Windows.Forms.GroupBox()
        Me.ucrInputSubTitleWeight = New instat.ucrInputComboBox()
        Me.ucrInputSubTitleSize = New instat.ucrInputComboBox()
        Me.lblFontWeight2 = New System.Windows.Forms.Label()
        Me.lblFontSize2 = New System.Windows.Forms.Label()
        Me.grpTitle = New System.Windows.Forms.GroupBox()
        Me.ucrInputFontWeight = New instat.ucrInputComboBox()
        Me.ucrInputFontSize = New instat.ucrInputComboBox()
        Me.lblFontWeight = New System.Windows.Forms.Label()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.ucrInputAlignment = New instat.ucrInputComboBox()
        Me.ucrInputBackgroundColour = New instat.ucrInputComboBox()
        Me.lblAlignment = New System.Windows.Forms.Label()
        Me.lblBackgroundColour = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.ucrInputSideStyle = New instat.ucrInputComboBox()
        Me.ucrInputSideColour = New instat.ucrInputComboBox()
        Me.lblSideStyle = New System.Windows.Forms.Label()
        Me.lblSideColour = New System.Windows.Forms.Label()
        Me.tbSummaryThemes.SuspendLayout()
        Me.tbThemeTitles.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpSubTitle.SuspendLayout()
        Me.grpTitle.SuspendLayout()
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
        Me.tbThemeTitles.Controls.Add(Me.GroupBox1)
        Me.tbThemeTitles.Controls.Add(Me.grpSubTitle)
        Me.tbThemeTitles.Controls.Add(Me.grpTitle)
        Me.tbThemeTitles.Controls.Add(Me.ucrInputAlignment)
        Me.tbThemeTitles.Controls.Add(Me.ucrInputBackgroundColour)
        Me.tbThemeTitles.Controls.Add(Me.lblAlignment)
        Me.tbThemeTitles.Controls.Add(Me.lblBackgroundColour)
        Me.tbThemeTitles.Location = New System.Drawing.Point(4, 22)
        Me.tbThemeTitles.Name = "tbThemeTitles"
        Me.tbThemeTitles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbThemeTitles.Size = New System.Drawing.Size(728, 346)
        Me.tbThemeTitles.TabIndex = 1
        Me.tbThemeTitles.Text = "Titles"
        Me.tbThemeTitles.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSideColour)
        Me.GroupBox1.Controls.Add(Me.lblSideStyle)
        Me.GroupBox1.Controls.Add(Me.ucrInputSideColour)
        Me.GroupBox1.Controls.Add(Me.ucrInputSideStyle)
        Me.GroupBox1.Controls.Add(Me.lblSideWidth)
        Me.GroupBox1.Controls.Add(Me.lblBottomColour)
        Me.GroupBox1.Controls.Add(Me.lblBottomStyle)
        Me.GroupBox1.Controls.Add(Me.lblBottomWidth)
        Me.GroupBox1.Controls.Add(Me.ucrInputSideWidth)
        Me.GroupBox1.Controls.Add(Me.ucrInputBottomColour)
        Me.GroupBox1.Controls.Add(Me.ucrInputBottomStyle)
        Me.GroupBox1.Controls.Add(Me.ucrInputBottomWidth)
        Me.GroupBox1.Controls.Add(Me.ucrInputBoxLength)
        Me.GroupBox1.Controls.Add(Me.ucrInputBoxWidth)
        Me.GroupBox1.Controls.Add(Me.lblBoxLength)
        Me.GroupBox1.Controls.Add(Me.lblBoxWidth)
        Me.GroupBox1.Location = New System.Drawing.Point(324, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 238)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Title"
        '
        'lblSideWidth
        '
        Me.lblSideWidth.AutoSize = True
        Me.lblSideWidth.Location = New System.Drawing.Point(12, 156)
        Me.lblSideWidth.Name = "lblSideWidth"
        Me.lblSideWidth.Size = New System.Drawing.Size(105, 13)
        Me.lblSideWidth.TabIndex = 13
        Me.lblSideWidth.Text = "Width of side border:"
        '
        'lblBottomColour
        '
        Me.lblBottomColour.AutoSize = True
        Me.lblBottomColour.Location = New System.Drawing.Point(12, 128)
        Me.lblBottomColour.Name = "lblBottomColour"
        Me.lblBottomColour.Size = New System.Drawing.Size(120, 13)
        Me.lblBottomColour.TabIndex = 12
        Me.lblBottomColour.Text = "Colour of bottom border:"
        '
        'lblBottomStyle
        '
        Me.lblBottomStyle.AutoSize = True
        Me.lblBottomStyle.Location = New System.Drawing.Point(12, 102)
        Me.lblBottomStyle.Name = "lblBottomStyle"
        Me.lblBottomStyle.Size = New System.Drawing.Size(113, 13)
        Me.lblBottomStyle.TabIndex = 11
        Me.lblBottomStyle.Text = "Style of bottom border:"
        '
        'lblBottomWidth
        '
        Me.lblBottomWidth.AutoSize = True
        Me.lblBottomWidth.Location = New System.Drawing.Point(12, 76)
        Me.lblBottomWidth.Name = "lblBottomWidth"
        Me.lblBottomWidth.Size = New System.Drawing.Size(118, 13)
        Me.lblBottomWidth.TabIndex = 10
        Me.lblBottomWidth.Text = "Width of bottom border:"
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
        'lblBoxLength
        '
        Me.lblBoxLength.AutoSize = True
        Me.lblBoxLength.Location = New System.Drawing.Point(12, 49)
        Me.lblBoxLength.Name = "lblBoxLength"
        Me.lblBoxLength.Size = New System.Drawing.Size(75, 13)
        Me.lblBoxLength.TabIndex = 3
        Me.lblBoxLength.Text = "Length of box:"
        '
        'lblBoxWidth
        '
        Me.lblBoxWidth.AutoSize = True
        Me.lblBoxWidth.Location = New System.Drawing.Point(12, 23)
        Me.lblBoxWidth.Name = "lblBoxWidth"
        Me.lblBoxWidth.Size = New System.Drawing.Size(70, 13)
        Me.lblBoxWidth.TabIndex = 2
        Me.lblBoxWidth.Text = "Width of box:"
        '
        'grpSubTitle
        '
        Me.grpSubTitle.Controls.Add(Me.ucrInputSubTitleWeight)
        Me.grpSubTitle.Controls.Add(Me.ucrInputSubTitleSize)
        Me.grpSubTitle.Controls.Add(Me.lblFontWeight2)
        Me.grpSubTitle.Controls.Add(Me.lblFontSize2)
        Me.grpSubTitle.Location = New System.Drawing.Point(28, 184)
        Me.grpSubTitle.Name = "grpSubTitle"
        Me.grpSubTitle.Size = New System.Drawing.Size(252, 76)
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
        Me.ucrInputSubTitleWeight.Location = New System.Drawing.Point(104, 43)
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
        Me.ucrInputSubTitleSize.Location = New System.Drawing.Point(104, 16)
        Me.ucrInputSubTitleSize.Name = "ucrInputSubTitleSize"
        Me.ucrInputSubTitleSize.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSubTitleSize.TabIndex = 4
        '
        'lblFontWeight2
        '
        Me.lblFontWeight2.AutoSize = True
        Me.lblFontWeight2.Location = New System.Drawing.Point(6, 45)
        Me.lblFontWeight2.Name = "lblFontWeight2"
        Me.lblFontWeight2.Size = New System.Drawing.Size(68, 13)
        Me.lblFontWeight2.TabIndex = 3
        Me.lblFontWeight2.Text = "Font Weight:"
        '
        'lblFontSize2
        '
        Me.lblFontSize2.AutoSize = True
        Me.lblFontSize2.Location = New System.Drawing.Point(6, 22)
        Me.lblFontSize2.Name = "lblFontSize2"
        Me.lblFontSize2.Size = New System.Drawing.Size(54, 13)
        Me.lblFontSize2.TabIndex = 2
        Me.lblFontSize2.Text = "Font Size:"
        '
        'grpTitle
        '
        Me.grpTitle.Controls.Add(Me.ucrInputFontWeight)
        Me.grpTitle.Controls.Add(Me.ucrInputFontSize)
        Me.grpTitle.Controls.Add(Me.lblFontWeight)
        Me.grpTitle.Controls.Add(Me.lblFontSize)
        Me.grpTitle.Location = New System.Drawing.Point(28, 88)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Size = New System.Drawing.Size(252, 76)
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
        Me.ucrInputFontWeight.Location = New System.Drawing.Point(104, 43)
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
        Me.ucrInputFontSize.Location = New System.Drawing.Point(104, 16)
        Me.ucrInputFontSize.Name = "ucrInputFontSize"
        Me.ucrInputFontSize.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFontSize.TabIndex = 4
        '
        'lblFontWeight
        '
        Me.lblFontWeight.AutoSize = True
        Me.lblFontWeight.Location = New System.Drawing.Point(6, 45)
        Me.lblFontWeight.Name = "lblFontWeight"
        Me.lblFontWeight.Size = New System.Drawing.Size(68, 13)
        Me.lblFontWeight.TabIndex = 3
        Me.lblFontWeight.Text = "Font Weight:"
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(6, 22)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(54, 13)
        Me.lblFontSize.TabIndex = 2
        Me.lblFontSize.Text = "Font Size:"
        '
        'ucrInputAlignment
        '
        Me.ucrInputAlignment.AddQuotesIfUnrecognised = True
        Me.ucrInputAlignment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAlignment.GetSetSelectedIndex = -1
        Me.ucrInputAlignment.IsReadOnly = False
        Me.ucrInputAlignment.Location = New System.Drawing.Point(132, 49)
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
        Me.ucrInputBackgroundColour.Location = New System.Drawing.Point(132, 22)
        Me.ucrInputBackgroundColour.Name = "ucrInputBackgroundColour"
        Me.ucrInputBackgroundColour.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputBackgroundColour.TabIndex = 2
        '
        'lblAlignment
        '
        Me.lblAlignment.AutoSize = True
        Me.lblAlignment.Location = New System.Drawing.Point(25, 54)
        Me.lblAlignment.Name = "lblAlignment"
        Me.lblAlignment.Size = New System.Drawing.Size(56, 13)
        Me.lblAlignment.TabIndex = 1
        Me.lblAlignment.Text = "Alignment:"
        '
        'lblBackgroundColour
        '
        Me.lblBackgroundColour.AutoSize = True
        Me.lblBackgroundColour.Location = New System.Drawing.Point(25, 26)
        Me.lblBackgroundColour.Name = "lblBackgroundColour"
        Me.lblBackgroundColour.Size = New System.Drawing.Size(101, 13)
        Me.lblBackgroundColour.TabIndex = 0
        Me.lblBackgroundColour.Text = "Background Colour:"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(728, 411)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Columns"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(728, 411)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Rows"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(728, 411)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Stub"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(728, 411)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Footnotes"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(728, 411)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Sourcenotes"
        Me.TabPage7.UseVisualStyleBackColor = True
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
        'lblSideStyle
        '
        Me.lblSideStyle.AutoSize = True
        Me.lblSideStyle.Location = New System.Drawing.Point(12, 185)
        Me.lblSideStyle.Name = "lblSideStyle"
        Me.lblSideStyle.Size = New System.Drawing.Size(100, 13)
        Me.lblSideStyle.TabIndex = 16
        Me.lblSideStyle.Text = "Style of side border:"
        '
        'lblSideColour
        '
        Me.lblSideColour.AutoSize = True
        Me.lblSideColour.Location = New System.Drawing.Point(12, 213)
        Me.lblSideColour.Name = "lblSideColour"
        Me.lblSideColour.Size = New System.Drawing.Size(107, 13)
        Me.lblSideColour.TabIndex = 17
        Me.lblSideColour.Text = "Colour of side border:"
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpSubTitle.ResumeLayout(False)
        Me.grpSubTitle.PerformLayout()
        Me.grpTitle.ResumeLayout(False)
        Me.grpTitle.PerformLayout()
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
    Friend WithEvents lblBackgroundColour As Label
    Friend WithEvents lblAlignment As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrInputSideWidth As ucrInputComboBox
    Friend WithEvents ucrInputBottomColour As ucrInputComboBox
    Friend WithEvents ucrInputBottomStyle As ucrInputComboBox
    Friend WithEvents ucrInputBottomWidth As ucrInputComboBox
    Friend WithEvents ucrInputBoxLength As ucrInputComboBox
    Friend WithEvents ucrInputBoxWidth As ucrInputComboBox
    Friend WithEvents lblBoxLength As Label
    Friend WithEvents lblBoxWidth As Label
    Friend WithEvents grpSubTitle As GroupBox
    Friend WithEvents ucrInputSubTitleWeight As ucrInputComboBox
    Friend WithEvents ucrInputSubTitleSize As ucrInputComboBox
    Friend WithEvents lblFontWeight2 As Label
    Friend WithEvents lblFontSize2 As Label
    Friend WithEvents grpTitle As GroupBox
    Friend WithEvents ucrInputFontWeight As ucrInputComboBox
    Friend WithEvents ucrInputFontSize As ucrInputComboBox
    Friend WithEvents lblFontWeight As Label
    Friend WithEvents lblFontSize As Label
    Friend WithEvents ucrInputAlignment As ucrInputComboBox
    Friend WithEvents ucrInputBackgroundColour As ucrInputComboBox
    Friend WithEvents lblSideWidth As Label
    Friend WithEvents lblBottomColour As Label
    Friend WithEvents lblBottomStyle As Label
    Friend WithEvents lblBottomWidth As Label
    Friend WithEvents lblSideColour As Label
    Friend WithEvents lblSideStyle As Label
    Friend WithEvents ucrInputSideColour As ucrInputComboBox
    Friend WithEvents ucrInputSideStyle As ucrInputComboBox
End Class
