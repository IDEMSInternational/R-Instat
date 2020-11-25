<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgDisplayDailyData
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
        Me.tpTitles = New System.Windows.Forms.TabPage()
        Me.tbDisplayDaily = New System.Windows.Forms.TabControl()
        Me.grpGraphTitles = New System.Windows.Forms.GroupBox()
        Me.lblCaptionSize = New System.Windows.Forms.Label()
        Me.lblSubTitleSize = New System.Windows.Forms.Label()
        Me.lblTitleSize = New System.Windows.Forms.Label()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ucrNudCaptionSize = New instat.ucrNud()
        Me.ucrNudSubTitleSize = New instat.ucrNud()
        Me.ucrNudTitleSize = New instat.ucrNud()
        Me.ucrInputGraphcCaption = New instat.ucrInputTextBox()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.ucrInputGraphSubTitle = New instat.ucrInputTextBox()
        Me.grpAxes = New System.Windows.Forms.GroupBox()
        Me.lblXAxisTitleSize = New System.Windows.Forms.Label()
        Me.rdoAutoXAxis = New System.Windows.Forms.RadioButton()
        Me.ucrInputXAxisTitle = New instat.ucrInputTextBox()
        Me.rdoNoTitleXAxisTitle = New System.Windows.Forms.RadioButton()
        Me.rdoSpecifyXAxisTitle = New System.Windows.Forms.RadioButton()
        Me.ucrNudXAxisTitleSize = New instat.ucrNud()
        Me.ucrPnlXAxisTitle = New instat.UcrPanel()
        Me.grpyAxisTitle = New System.Windows.Forms.GroupBox()
        Me.rdoAutoYAxis = New System.Windows.Forms.RadioButton()
        Me.ucrInputYAxisTitle = New instat.ucrInputTextBox()
        Me.rdoNoYAxisTitle = New System.Windows.Forms.RadioButton()
        Me.ucrNudYAxisTitleSize = New instat.ucrNud()
        Me.rdoSpecifyYAxisTitle = New System.Windows.Forms.RadioButton()
        Me.UcrPnlYAxisTitle = New instat.UcrPanel()
        Me.lblYAxisTitleSize = New System.Windows.Forms.Label()
        Me.tpTitles.SuspendLayout()
        Me.tbDisplayDaily.SuspendLayout()
        Me.grpGraphTitles.SuspendLayout()
        Me.grpAxes.SuspendLayout()
        Me.grpyAxisTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'tpTitles
        '
        Me.tpTitles.Controls.Add(Me.grpGraphTitles)
        Me.tpTitles.Controls.Add(Me.grpAxes)
        Me.tpTitles.Controls.Add(Me.grpyAxisTitle)
        Me.tpTitles.Location = New System.Drawing.Point(4, 22)
        Me.tpTitles.Name = "tpTitles"
        Me.tpTitles.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTitles.Size = New System.Drawing.Size(564, 322)
        Me.tpTitles.TabIndex = 0
        Me.tpTitles.Text = "Titles"
        Me.tpTitles.UseVisualStyleBackColor = True
        '
        'tbDisplayDaily
        '
        Me.tbDisplayDaily.Controls.Add(Me.tpTitles)
        Me.tbDisplayDaily.Location = New System.Drawing.Point(2, 0)
        Me.tbDisplayDaily.Name = "tbDisplayDaily"
        Me.tbDisplayDaily.SelectedIndex = 0
        Me.tbDisplayDaily.Size = New System.Drawing.Size(572, 348)
        Me.tbDisplayDaily.TabIndex = 0
        '
        'grpGraphTitles
        '
        Me.grpGraphTitles.Controls.Add(Me.lblCaptionSize)
        Me.grpGraphTitles.Controls.Add(Me.lblSubTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.lblTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.lblCaption)
        Me.grpGraphTitles.Controls.Add(Me.lblSubTitle)
        Me.grpGraphTitles.Controls.Add(Me.lblTitle)
        Me.grpGraphTitles.Controls.Add(Me.ucrNudCaptionSize)
        Me.grpGraphTitles.Controls.Add(Me.ucrNudSubTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.ucrNudTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.ucrInputGraphcCaption)
        Me.grpGraphTitles.Controls.Add(Me.ucrInputGraphTitle)
        Me.grpGraphTitles.Controls.Add(Me.ucrInputGraphSubTitle)
        Me.grpGraphTitles.Location = New System.Drawing.Point(6, 19)
        Me.grpGraphTitles.Name = "grpGraphTitles"
        Me.grpGraphTitles.Size = New System.Drawing.Size(525, 136)
        Me.grpGraphTitles.TabIndex = 37
        Me.grpGraphTitles.TabStop = False
        Me.grpGraphTitles.Text = "Graph"
        '
        'lblCaptionSize
        '
        Me.lblCaptionSize.AutoSize = True
        Me.lblCaptionSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCaptionSize.Location = New System.Drawing.Point(360, 83)
        Me.lblCaptionSize.Name = "lblCaptionSize"
        Me.lblCaptionSize.Size = New System.Drawing.Size(69, 13)
        Me.lblCaptionSize.TabIndex = 26
        Me.lblCaptionSize.Text = "Caption Size:"
        '
        'lblSubTitleSize
        '
        Me.lblSubTitleSize.AutoSize = True
        Me.lblSubTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubTitleSize.Location = New System.Drawing.Point(360, 53)
        Me.lblSubTitleSize.Name = "lblSubTitleSize"
        Me.lblSubTitleSize.Size = New System.Drawing.Size(75, 13)
        Me.lblSubTitleSize.TabIndex = 27
        Me.lblSubTitleSize.Text = "Sub Title Size:"
        '
        'lblTitleSize
        '
        Me.lblTitleSize.AutoSize = True
        Me.lblTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitleSize.Location = New System.Drawing.Point(361, 23)
        Me.lblTitleSize.Name = "lblTitleSize"
        Me.lblTitleSize.Size = New System.Drawing.Size(53, 13)
        Me.lblTitleSize.TabIndex = 28
        Me.lblTitleSize.Text = "Title Size:"
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCaption.Location = New System.Drawing.Point(5, 83)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(78, 13)
        Me.lblCaption.TabIndex = 23
        Me.lblCaption.Text = "Graph Caption:"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubTitle.Location = New System.Drawing.Point(5, 53)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(84, 13)
        Me.lblSubTitle.TabIndex = 24
        Me.lblSubTitle.Text = "Graph Sub Title:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitle.Location = New System.Drawing.Point(6, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(62, 13)
        Me.lblTitle.TabIndex = 25
        Me.lblTitle.Text = "Graph Title:"
        '
        'ucrNudCaptionSize
        '
        Me.ucrNudCaptionSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCaptionSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCaptionSize.Location = New System.Drawing.Point(448, 78)
        Me.ucrNudCaptionSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudCaptionSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCaptionSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCaptionSize.Name = "ucrNudCaptionSize"
        Me.ucrNudCaptionSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCaptionSize.TabIndex = 22
        Me.ucrNudCaptionSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSubTitleSize
        '
        Me.ucrNudSubTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSubTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSubTitleSize.Location = New System.Drawing.Point(448, 48)
        Me.ucrNudSubTitleSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudSubTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSubTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSubTitleSize.Name = "ucrNudSubTitleSize"
        Me.ucrNudSubTitleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSubTitleSize.TabIndex = 21
        Me.ucrNudSubTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTitleSize
        '
        Me.ucrNudTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTitleSize.Location = New System.Drawing.Point(448, 18)
        Me.ucrNudTitleSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Name = "ucrNudTitleSize"
        Me.ucrNudTitleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTitleSize.TabIndex = 20
        Me.ucrNudTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputGraphcCaption
        '
        Me.ucrInputGraphcCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphcCaption.IsMultiline = True
        Me.ucrInputGraphcCaption.IsReadOnly = False
        Me.ucrInputGraphcCaption.Location = New System.Drawing.Point(119, 78)
        Me.ucrInputGraphcCaption.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputGraphcCaption.Name = "ucrInputGraphcCaption"
        Me.ucrInputGraphcCaption.Size = New System.Drawing.Size(181, 53)
        Me.ucrInputGraphcCaption.TabIndex = 16
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        Me.ucrInputGraphTitle.Location = New System.Drawing.Point(119, 18)
        Me.ucrInputGraphTitle.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        Me.ucrInputGraphTitle.Size = New System.Drawing.Size(181, 21)
        Me.ucrInputGraphTitle.TabIndex = 12
        '
        'ucrInputGraphSubTitle
        '
        Me.ucrInputGraphSubTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphSubTitle.IsMultiline = False
        Me.ucrInputGraphSubTitle.IsReadOnly = False
        Me.ucrInputGraphSubTitle.Location = New System.Drawing.Point(119, 48)
        Me.ucrInputGraphSubTitle.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputGraphSubTitle.Name = "ucrInputGraphSubTitle"
        Me.ucrInputGraphSubTitle.Size = New System.Drawing.Size(181, 21)
        Me.ucrInputGraphSubTitle.TabIndex = 14
        '
        'grpAxes
        '
        Me.grpAxes.Controls.Add(Me.lblXAxisTitleSize)
        Me.grpAxes.Controls.Add(Me.rdoAutoXAxis)
        Me.grpAxes.Controls.Add(Me.ucrInputXAxisTitle)
        Me.grpAxes.Controls.Add(Me.rdoNoTitleXAxisTitle)
        Me.grpAxes.Controls.Add(Me.rdoSpecifyXAxisTitle)
        Me.grpAxes.Controls.Add(Me.ucrNudXAxisTitleSize)
        Me.grpAxes.Controls.Add(Me.ucrPnlXAxisTitle)
        Me.grpAxes.Location = New System.Drawing.Point(6, 167)
        Me.grpAxes.Name = "grpAxes"
        Me.grpAxes.Size = New System.Drawing.Size(228, 105)
        Me.grpAxes.TabIndex = 38
        Me.grpAxes.TabStop = False
        Me.grpAxes.Text = "X-Axis Title"
        '
        'lblXAxisTitleSize
        '
        Me.lblXAxisTitleSize.AutoSize = True
        Me.lblXAxisTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXAxisTitleSize.Location = New System.Drawing.Point(6, 82)
        Me.lblXAxisTitleSize.Name = "lblXAxisTitleSize"
        Me.lblXAxisTitleSize.Size = New System.Drawing.Size(30, 13)
        Me.lblXAxisTitleSize.TabIndex = 44
        Me.lblXAxisTitleSize.Text = "Size:"
        '
        'rdoAutoXAxis
        '
        Me.rdoAutoXAxis.AutoSize = True
        Me.rdoAutoXAxis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAutoXAxis.Location = New System.Drawing.Point(6, 21)
        Me.rdoAutoXAxis.Name = "rdoAutoXAxis"
        Me.rdoAutoXAxis.Size = New System.Drawing.Size(50, 17)
        Me.rdoAutoXAxis.TabIndex = 43
        Me.rdoAutoXAxis.TabStop = True
        Me.rdoAutoXAxis.Text = "Auto "
        Me.rdoAutoXAxis.UseVisualStyleBackColor = True
        '
        'ucrInputXAxisTitle
        '
        Me.ucrInputXAxisTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputXAxisTitle.IsMultiline = False
        Me.ucrInputXAxisTitle.IsReadOnly = False
        Me.ucrInputXAxisTitle.Location = New System.Drawing.Point(6, 44)
        Me.ucrInputXAxisTitle.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputXAxisTitle.Name = "ucrInputXAxisTitle"
        Me.ucrInputXAxisTitle.Size = New System.Drawing.Size(181, 21)
        Me.ucrInputXAxisTitle.TabIndex = 42
        '
        'rdoNoTitleXAxisTitle
        '
        Me.rdoNoTitleXAxisTitle.AutoSize = True
        Me.rdoNoTitleXAxisTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNoTitleXAxisTitle.Location = New System.Drawing.Point(142, 21)
        Me.rdoNoTitleXAxisTitle.Name = "rdoNoTitleXAxisTitle"
        Me.rdoNoTitleXAxisTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoNoTitleXAxisTitle.TabIndex = 41
        Me.rdoNoTitleXAxisTitle.TabStop = True
        Me.rdoNoTitleXAxisTitle.Text = "No Title"
        Me.rdoNoTitleXAxisTitle.UseVisualStyleBackColor = True
        '
        'rdoSpecifyXAxisTitle
        '
        Me.rdoSpecifyXAxisTitle.AutoSize = True
        Me.rdoSpecifyXAxisTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSpecifyXAxisTitle.Location = New System.Drawing.Point(67, 21)
        Me.rdoSpecifyXAxisTitle.Name = "rdoSpecifyXAxisTitle"
        Me.rdoSpecifyXAxisTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoSpecifyXAxisTitle.TabIndex = 40
        Me.rdoSpecifyXAxisTitle.TabStop = True
        Me.rdoSpecifyXAxisTitle.Text = "Specifiy"
        Me.rdoSpecifyXAxisTitle.UseVisualStyleBackColor = True
        '
        'ucrNudXAxisTitleSize
        '
        Me.ucrNudXAxisTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXAxisTitleSize.Location = New System.Drawing.Point(43, 80)
        Me.ucrNudXAxisTitleSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudXAxisTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAxisTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisTitleSize.Name = "ucrNudXAxisTitleSize"
        Me.ucrNudXAxisTitleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXAxisTitleSize.TabIndex = 23
        Me.ucrNudXAxisTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlXAxisTitle
        '
        Me.ucrPnlXAxisTitle.Location = New System.Drawing.Point(6, 15)
        Me.ucrPnlXAxisTitle.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlXAxisTitle.Name = "ucrPnlXAxisTitle"
        Me.ucrPnlXAxisTitle.Size = New System.Drawing.Size(204, 57)
        Me.ucrPnlXAxisTitle.TabIndex = 36
        '
        'grpyAxisTitle
        '
        Me.grpyAxisTitle.Controls.Add(Me.rdoAutoYAxis)
        Me.grpyAxisTitle.Controls.Add(Me.ucrInputYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.rdoNoYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.ucrNudYAxisTitleSize)
        Me.grpyAxisTitle.Controls.Add(Me.rdoSpecifyYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.UcrPnlYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.lblYAxisTitleSize)
        Me.grpyAxisTitle.Location = New System.Drawing.Point(303, 165)
        Me.grpyAxisTitle.Name = "grpyAxisTitle"
        Me.grpyAxisTitle.Size = New System.Drawing.Size(228, 105)
        Me.grpyAxisTitle.TabIndex = 39
        Me.grpyAxisTitle.TabStop = False
        Me.grpyAxisTitle.Text = "Y-Axis Title"
        '
        'rdoAutoYAxis
        '
        Me.rdoAutoYAxis.AutoSize = True
        Me.rdoAutoYAxis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAutoYAxis.Location = New System.Drawing.Point(6, 21)
        Me.rdoAutoYAxis.Name = "rdoAutoYAxis"
        Me.rdoAutoYAxis.Size = New System.Drawing.Size(50, 17)
        Me.rdoAutoYAxis.TabIndex = 44
        Me.rdoAutoYAxis.TabStop = True
        Me.rdoAutoYAxis.Text = "Auto "
        Me.rdoAutoYAxis.UseVisualStyleBackColor = True
        '
        'ucrInputYAxisTitle
        '
        Me.ucrInputYAxisTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputYAxisTitle.IsMultiline = False
        Me.ucrInputYAxisTitle.IsReadOnly = False
        Me.ucrInputYAxisTitle.Location = New System.Drawing.Point(6, 44)
        Me.ucrInputYAxisTitle.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputYAxisTitle.Name = "ucrInputYAxisTitle"
        Me.ucrInputYAxisTitle.Size = New System.Drawing.Size(181, 21)
        Me.ucrInputYAxisTitle.TabIndex = 14
        '
        'rdoNoYAxisTitle
        '
        Me.rdoNoYAxisTitle.AutoSize = True
        Me.rdoNoYAxisTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNoYAxisTitle.Location = New System.Drawing.Point(142, 21)
        Me.rdoNoYAxisTitle.Name = "rdoNoYAxisTitle"
        Me.rdoNoYAxisTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoNoYAxisTitle.TabIndex = 42
        Me.rdoNoYAxisTitle.TabStop = True
        Me.rdoNoYAxisTitle.Text = "No Title"
        Me.rdoNoYAxisTitle.UseVisualStyleBackColor = True
        '
        'ucrNudYAxisTitleSize
        '
        Me.ucrNudYAxisTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Location = New System.Drawing.Point(43, 79)
        Me.ucrNudYAxisTitleSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudYAxisTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Name = "ucrNudYAxisTitleSize"
        Me.ucrNudYAxisTitleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudYAxisTitleSize.TabIndex = 22
        Me.ucrNudYAxisTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoSpecifyYAxisTitle
        '
        Me.rdoSpecifyYAxisTitle.AutoSize = True
        Me.rdoSpecifyYAxisTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSpecifyYAxisTitle.Location = New System.Drawing.Point(67, 21)
        Me.rdoSpecifyYAxisTitle.Name = "rdoSpecifyYAxisTitle"
        Me.rdoSpecifyYAxisTitle.Size = New System.Drawing.Size(60, 17)
        Me.rdoSpecifyYAxisTitle.TabIndex = 41
        Me.rdoSpecifyYAxisTitle.TabStop = True
        Me.rdoSpecifyYAxisTitle.Text = "Specify"
        Me.rdoSpecifyYAxisTitle.UseVisualStyleBackColor = True
        '
        'UcrPnlYAxisTitle
        '
        Me.UcrPnlYAxisTitle.Location = New System.Drawing.Point(6, 15)
        Me.UcrPnlYAxisTitle.Margin = New System.Windows.Forms.Padding(5)
        Me.UcrPnlYAxisTitle.Name = "UcrPnlYAxisTitle"
        Me.UcrPnlYAxisTitle.Size = New System.Drawing.Size(204, 57)
        Me.UcrPnlYAxisTitle.TabIndex = 37
        '
        'lblYAxisTitleSize
        '
        Me.lblYAxisTitleSize.AutoSize = True
        Me.lblYAxisTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYAxisTitleSize.Location = New System.Drawing.Point(6, 82)
        Me.lblYAxisTitleSize.Name = "lblYAxisTitleSize"
        Me.lblYAxisTitleSize.Size = New System.Drawing.Size(30, 13)
        Me.lblYAxisTitleSize.TabIndex = 45
        Me.lblYAxisTitleSize.Text = "Size:"
        '
        'sdgDisplayDailyData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 355)
        Me.Controls.Add(Me.tbDisplayDaily)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDisplayDailyData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Display Daily Data"
        Me.tpTitles.ResumeLayout(False)
        Me.tbDisplayDaily.ResumeLayout(False)
        Me.grpGraphTitles.ResumeLayout(False)
        Me.grpGraphTitles.PerformLayout()
        Me.grpAxes.ResumeLayout(False)
        Me.grpAxes.PerformLayout()
        Me.grpyAxisTitle.ResumeLayout(False)
        Me.grpyAxisTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tpTitles As TabPage
    Friend WithEvents tbDisplayDaily As TabControl
    Friend WithEvents grpGraphTitles As GroupBox
    Friend WithEvents lblCaptionSize As Label
    Friend WithEvents lblSubTitleSize As Label
    Friend WithEvents lblTitleSize As Label
    Friend WithEvents lblCaption As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents ucrNudCaptionSize As ucrNud
    Friend WithEvents ucrNudSubTitleSize As ucrNud
    Friend WithEvents ucrNudTitleSize As ucrNud
    Friend WithEvents ucrInputGraphcCaption As ucrInputTextBox
    Friend WithEvents ucrInputGraphTitle As ucrInputTextBox
    Friend WithEvents ucrInputGraphSubTitle As ucrInputTextBox
    Friend WithEvents grpAxes As GroupBox
    Friend WithEvents lblXAxisTitleSize As Label
    Friend WithEvents rdoAutoXAxis As RadioButton
    Friend WithEvents ucrInputXAxisTitle As ucrInputTextBox
    Friend WithEvents rdoNoTitleXAxisTitle As RadioButton
    Friend WithEvents rdoSpecifyXAxisTitle As RadioButton
    Friend WithEvents ucrNudXAxisTitleSize As ucrNud
    Friend WithEvents ucrPnlXAxisTitle As UcrPanel
    Friend WithEvents grpyAxisTitle As GroupBox
    Friend WithEvents rdoAutoYAxis As RadioButton
    Friend WithEvents ucrInputYAxisTitle As ucrInputTextBox
    Friend WithEvents rdoNoYAxisTitle As RadioButton
    Friend WithEvents ucrNudYAxisTitleSize As ucrNud
    Friend WithEvents rdoSpecifyYAxisTitle As RadioButton
    Friend WithEvents UcrPnlYAxisTitle As UcrPanel
    Friend WithEvents lblYAxisTitleSize As Label
End Class
