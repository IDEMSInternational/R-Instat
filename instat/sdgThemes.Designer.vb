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
        Me.tbXaxis = New System.Windows.Forms.TabControl()
        Me.tbAxis = New System.Windows.Forms.TabPage()
        Me.grpTableOptions = New System.Windows.Forms.GroupBox()
        Me.ucrThemeTopXAxis = New instat.ucrThemeAxes()
        Me.ucrThemeBottomXAxis = New instat.ucrThemeAxes()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UcrCheck1 = New instat.ucrCheck()
        Me.UcrCheck2 = New instat.ucrCheck()
        Me.UcrCheck3 = New instat.ucrCheck()
        Me.UcrCheck4 = New instat.ucrCheck()
        Me.UcrInputComboBox1 = New instat.ucrInputComboBox()
        Me.UcrNud1 = New instat.ucrNud()
        Me.UcrInputComboBox2 = New instat.ucrInputComboBox()
        Me.UcrInputComboBox3 = New instat.ucrInputComboBox()
        Me.grpTickLabels = New System.Windows.Forms.GroupBox()
        Me.ucrChkLineEndTickLabelsXAxis = New instat.ucrCheck()
        Me.ucrChkSizeTickLabelsXAxis = New instat.ucrCheck()
        Me.ucrChkLineTypeTickLabelsXAxis = New instat.ucrCheck()
        Me.ucrChkColourTickLabelsXAxis = New instat.ucrCheck()
        Me.ucrInputLineEndTickLabelsXAxis = New instat.ucrInputComboBox()
        Me.ucrNudSizeTickLabelsXAxis = New instat.ucrNud()
        Me.ucrInputColourTickLabelsXAxis = New instat.ucrInputComboBox()
        Me.ucrInputLineTypeTickLabelsXAxis = New instat.ucrInputComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrInputMargin = New instat.ucrInputTextBox()
        Me.ucrChkMaigin = New instat.ucrCheck()
        Me.ucrInputMarginUnits = New instat.ucrInputComboBox()
        Me.ucrInputUnits = New instat.ucrInputTextBox()
        Me.ucrChkLineEndTickMarksXAxis = New instat.ucrCheck()
        Me.ucrChkUnits = New instat.ucrCheck()
        Me.ucrInputTickUnits = New instat.ucrInputComboBox()
        Me.ucrChkSizeTickMarksXAxis = New instat.ucrCheck()
        Me.ucrChkLineTypeTickMarksXAxis = New instat.ucrCheck()
        Me.ucrChkColourTickMarksXAxis = New instat.ucrCheck()
        Me.ucrInputLineEndTickMarks = New instat.ucrInputComboBox()
        Me.ucrNudSizeTickMarks = New instat.ucrNud()
        Me.ucrInputColourTickMarks = New instat.ucrInputComboBox()
        Me.ucrInputLineTypeTickMarks = New instat.ucrInputComboBox()
        Me.tbYaxis = New System.Windows.Forms.TabPage()
        Me.ucrThemeRightYAxis = New instat.ucrThemeAxes()
        Me.ucrThemeLeftYAxis = New instat.ucrThemeAxes()
        Me.grpTickLabelYAxis = New System.Windows.Forms.GroupBox()
        Me.ucrChkLineEndTickLabelsYAxis = New instat.ucrCheck()
        Me.ucrChkSizeTickLabelsYAxis = New instat.ucrCheck()
        Me.ucrChkLineTypeTickLabelsYAxis = New instat.ucrCheck()
        Me.ucrChkColourTickLabelsYAxis = New instat.ucrCheck()
        Me.ucrInputLineEndTickLabelsYAxis = New instat.ucrInputComboBox()
        Me.ucrNudSizeTickLabelsYAxis = New instat.ucrNud()
        Me.ucrInputColourTickLabelsYAxis = New instat.ucrInputComboBox()
        Me.ucrInputLineTypeTickLabelsYAxis = New instat.ucrInputComboBox()
        Me.grpTickMarksYAxis = New System.Windows.Forms.GroupBox()
        Me.ucrChkLineEndTickMarksYAxis = New instat.ucrCheck()
        Me.ucrChkSizeTickMarksYAxis = New instat.ucrCheck()
        Me.ucrChkLineTypeTickMarksYAxis = New instat.ucrCheck()
        Me.ucrChkColourTickMarksYAxis = New instat.ucrCheck()
        Me.ucrInputLineEndTickMarksYAxis = New instat.ucrInputComboBox()
        Me.ucrNudSizeTickMarksYAxis = New instat.ucrNud()
        Me.ucrInputColourTickMarksYAxis = New instat.ucrInputComboBox()
        Me.ucrInputLineTypeTickMarksYAxis = New instat.ucrInputComboBox()
        Me.ucrBaseSubdialogue = New instat.ucrButtonsSubdialogue()
        Me.tbXaxis.SuspendLayout()
        Me.tbAxis.SuspendLayout()
        Me.grpTableOptions.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpTickLabels.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbYaxis.SuspendLayout()
        Me.grpTickLabelYAxis.SuspendLayout()
        Me.grpTickMarksYAxis.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbXaxis
        '
        Me.tbXaxis.Controls.Add(Me.tbAxis)
        Me.tbXaxis.Controls.Add(Me.tbYaxis)
        Me.tbXaxis.Location = New System.Drawing.Point(4, 8)
        Me.tbXaxis.Name = "tbXaxis"
        Me.tbXaxis.SelectedIndex = 0
        Me.tbXaxis.Size = New System.Drawing.Size(605, 603)
        Me.tbXaxis.TabIndex = 1
        '
        'tbAxis
        '
        Me.tbAxis.Controls.Add(Me.grpTableOptions)
        Me.tbAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbAxis.Name = "tbAxis"
        Me.tbAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAxis.Size = New System.Drawing.Size(597, 577)
        Me.tbAxis.TabIndex = 0
        Me.tbAxis.Text = "X-axis"
        Me.tbAxis.UseVisualStyleBackColor = True
        '
        'grpTableOptions
        '
        Me.grpTableOptions.Controls.Add(Me.ucrThemeTopXAxis)
        Me.grpTableOptions.Controls.Add(Me.ucrThemeBottomXAxis)
        Me.grpTableOptions.Controls.Add(Me.GroupBox2)
        Me.grpTableOptions.Controls.Add(Me.grpTickLabels)
        Me.grpTableOptions.Controls.Add(Me.GroupBox1)
        Me.grpTableOptions.Location = New System.Drawing.Point(-1, 3)
        Me.grpTableOptions.Name = "grpTableOptions"
        Me.grpTableOptions.Size = New System.Drawing.Size(592, 578)
        Me.grpTableOptions.TabIndex = 0
        Me.grpTableOptions.TabStop = False
        Me.grpTableOptions.Text = "More Options"
        '
        'ucrThemeTopXAxis
        '
        Me.ucrThemeTopXAxis.Location = New System.Drawing.Point(307, 10)
        Me.ucrThemeTopXAxis.Name = "ucrThemeTopXAxis"
        Me.ucrThemeTopXAxis.Size = New System.Drawing.Size(296, 260)
        Me.ucrThemeTopXAxis.TabIndex = 57
        '
        'ucrThemeBottomXAxis
        '
        Me.ucrThemeBottomXAxis.Location = New System.Drawing.Point(5, 10)
        Me.ucrThemeBottomXAxis.Name = "ucrThemeBottomXAxis"
        Me.ucrThemeBottomXAxis.Size = New System.Drawing.Size(296, 260)
        Me.ucrThemeBottomXAxis.TabIndex = 56
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UcrCheck1)
        Me.GroupBox2.Controls.Add(Me.UcrCheck2)
        Me.GroupBox2.Controls.Add(Me.UcrCheck3)
        Me.GroupBox2.Controls.Add(Me.UcrCheck4)
        Me.GroupBox2.Controls.Add(Me.UcrInputComboBox1)
        Me.GroupBox2.Controls.Add(Me.UcrNud1)
        Me.GroupBox2.Controls.Add(Me.UcrInputComboBox2)
        Me.GroupBox2.Controls.Add(Me.UcrInputComboBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(284, 424)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 154)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "X axis tick labels"
        '
        'UcrCheck1
        '
        Me.UcrCheck1.Checked = False
        Me.UcrCheck1.Location = New System.Drawing.Point(11, 104)
        Me.UcrCheck1.Name = "UcrCheck1"
        Me.UcrCheck1.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck1.TabIndex = 54
        '
        'UcrCheck2
        '
        Me.UcrCheck2.Checked = False
        Me.UcrCheck2.Location = New System.Drawing.Point(11, 20)
        Me.UcrCheck2.Name = "UcrCheck2"
        Me.UcrCheck2.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck2.TabIndex = 53
        '
        'UcrCheck3
        '
        Me.UcrCheck3.Checked = False
        Me.UcrCheck3.Location = New System.Drawing.Point(11, 45)
        Me.UcrCheck3.Name = "UcrCheck3"
        Me.UcrCheck3.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck3.TabIndex = 52
        '
        'UcrCheck4
        '
        Me.UcrCheck4.Checked = False
        Me.UcrCheck4.Location = New System.Drawing.Point(11, 72)
        Me.UcrCheck4.Name = "UcrCheck4"
        Me.UcrCheck4.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck4.TabIndex = 51
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox1.IsReadOnly = False
        Me.UcrInputComboBox1.Location = New System.Drawing.Point(117, 103)
        Me.UcrInputComboBox1.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        Me.UcrInputComboBox1.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox1.TabIndex = 32
        '
        'UcrNud1
        '
        Me.UcrNud1.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNud1.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNud1.Location = New System.Drawing.Point(116, 19)
        Me.UcrNud1.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNud1.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud1.Name = "UcrNud1"
        Me.UcrNud1.Size = New System.Drawing.Size(50, 20)
        Me.UcrNud1.TabIndex = 30
        Me.UcrNud1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrInputComboBox2
        '
        Me.UcrInputComboBox2.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox2.IsReadOnly = False
        Me.UcrInputComboBox2.Location = New System.Drawing.Point(117, 72)
        Me.UcrInputComboBox2.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.UcrInputComboBox2.Name = "UcrInputComboBox2"
        Me.UcrInputComboBox2.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox2.TabIndex = 28
        '
        'UcrInputComboBox3
        '
        Me.UcrInputComboBox3.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox3.IsReadOnly = False
        Me.UcrInputComboBox3.Location = New System.Drawing.Point(117, 44)
        Me.UcrInputComboBox3.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.UcrInputComboBox3.Name = "UcrInputComboBox3"
        Me.UcrInputComboBox3.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox3.TabIndex = 26
        '
        'grpTickLabels
        '
        Me.grpTickLabels.Controls.Add(Me.ucrChkLineEndTickLabelsXAxis)
        Me.grpTickLabels.Controls.Add(Me.ucrChkSizeTickLabelsXAxis)
        Me.grpTickLabels.Controls.Add(Me.ucrChkLineTypeTickLabelsXAxis)
        Me.grpTickLabels.Controls.Add(Me.ucrChkColourTickLabelsXAxis)
        Me.grpTickLabels.Controls.Add(Me.ucrInputLineEndTickLabelsXAxis)
        Me.grpTickLabels.Controls.Add(Me.ucrNudSizeTickLabelsXAxis)
        Me.grpTickLabels.Controls.Add(Me.ucrInputColourTickLabelsXAxis)
        Me.grpTickLabels.Controls.Add(Me.ucrInputLineTypeTickLabelsXAxis)
        Me.grpTickLabels.Location = New System.Drawing.Point(282, 273)
        Me.grpTickLabels.Name = "grpTickLabels"
        Me.grpTickLabels.Size = New System.Drawing.Size(264, 154)
        Me.grpTickLabels.TabIndex = 40
        Me.grpTickLabels.TabStop = False
        Me.grpTickLabels.Text = "X axis tick labels"
        '
        'ucrChkLineEndTickLabelsXAxis
        '
        Me.ucrChkLineEndTickLabelsXAxis.Checked = False
        Me.ucrChkLineEndTickLabelsXAxis.Location = New System.Drawing.Point(11, 104)
        Me.ucrChkLineEndTickLabelsXAxis.Name = "ucrChkLineEndTickLabelsXAxis"
        Me.ucrChkLineEndTickLabelsXAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkLineEndTickLabelsXAxis.TabIndex = 54
        '
        'ucrChkSizeTickLabelsXAxis
        '
        Me.ucrChkSizeTickLabelsXAxis.Checked = False
        Me.ucrChkSizeTickLabelsXAxis.Location = New System.Drawing.Point(11, 20)
        Me.ucrChkSizeTickLabelsXAxis.Name = "ucrChkSizeTickLabelsXAxis"
        Me.ucrChkSizeTickLabelsXAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSizeTickLabelsXAxis.TabIndex = 53
        '
        'ucrChkLineTypeTickLabelsXAxis
        '
        Me.ucrChkLineTypeTickLabelsXAxis.Checked = False
        Me.ucrChkLineTypeTickLabelsXAxis.Location = New System.Drawing.Point(11, 45)
        Me.ucrChkLineTypeTickLabelsXAxis.Name = "ucrChkLineTypeTickLabelsXAxis"
        Me.ucrChkLineTypeTickLabelsXAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkLineTypeTickLabelsXAxis.TabIndex = 52
        '
        'ucrChkColourTickLabelsXAxis
        '
        Me.ucrChkColourTickLabelsXAxis.Checked = False
        Me.ucrChkColourTickLabelsXAxis.Location = New System.Drawing.Point(11, 72)
        Me.ucrChkColourTickLabelsXAxis.Name = "ucrChkColourTickLabelsXAxis"
        Me.ucrChkColourTickLabelsXAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkColourTickLabelsXAxis.TabIndex = 51
        '
        'ucrInputLineEndTickLabelsXAxis
        '
        Me.ucrInputLineEndTickLabelsXAxis.AddQuotesIfUnrecognised = True
        Me.ucrInputLineEndTickLabelsXAxis.IsReadOnly = False
        Me.ucrInputLineEndTickLabelsXAxis.Location = New System.Drawing.Point(117, 103)
        Me.ucrInputLineEndTickLabelsXAxis.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLineEndTickLabelsXAxis.Name = "ucrInputLineEndTickLabelsXAxis"
        Me.ucrInputLineEndTickLabelsXAxis.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLineEndTickLabelsXAxis.TabIndex = 32
        '
        'ucrNudSizeTickLabelsXAxis
        '
        Me.ucrNudSizeTickLabelsXAxis.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSizeTickLabelsXAxis.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSizeTickLabelsXAxis.Location = New System.Drawing.Point(116, 19)
        Me.ucrNudSizeTickLabelsXAxis.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSizeTickLabelsXAxis.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeTickLabelsXAxis.Name = "ucrNudSizeTickLabelsXAxis"
        Me.ucrNudSizeTickLabelsXAxis.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSizeTickLabelsXAxis.TabIndex = 30
        Me.ucrNudSizeTickLabelsXAxis.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputColourTickLabelsXAxis
        '
        Me.ucrInputColourTickLabelsXAxis.AddQuotesIfUnrecognised = True
        Me.ucrInputColourTickLabelsXAxis.IsReadOnly = False
        Me.ucrInputColourTickLabelsXAxis.Location = New System.Drawing.Point(117, 72)
        Me.ucrInputColourTickLabelsXAxis.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputColourTickLabelsXAxis.Name = "ucrInputColourTickLabelsXAxis"
        Me.ucrInputColourTickLabelsXAxis.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColourTickLabelsXAxis.TabIndex = 28
        '
        'ucrInputLineTypeTickLabelsXAxis
        '
        Me.ucrInputLineTypeTickLabelsXAxis.AddQuotesIfUnrecognised = True
        Me.ucrInputLineTypeTickLabelsXAxis.IsReadOnly = False
        Me.ucrInputLineTypeTickLabelsXAxis.Location = New System.Drawing.Point(117, 44)
        Me.ucrInputLineTypeTickLabelsXAxis.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLineTypeTickLabelsXAxis.Name = "ucrInputLineTypeTickLabelsXAxis"
        Me.ucrInputLineTypeTickLabelsXAxis.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLineTypeTickLabelsXAxis.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucrInputMargin)
        Me.GroupBox1.Controls.Add(Me.ucrChkMaigin)
        Me.GroupBox1.Controls.Add(Me.ucrInputMarginUnits)
        Me.GroupBox1.Controls.Add(Me.ucrInputUnits)
        Me.GroupBox1.Controls.Add(Me.ucrChkLineEndTickMarksXAxis)
        Me.GroupBox1.Controls.Add(Me.ucrChkUnits)
        Me.GroupBox1.Controls.Add(Me.ucrInputTickUnits)
        Me.GroupBox1.Controls.Add(Me.ucrChkSizeTickMarksXAxis)
        Me.GroupBox1.Controls.Add(Me.ucrChkLineTypeTickMarksXAxis)
        Me.GroupBox1.Controls.Add(Me.ucrChkColourTickMarksXAxis)
        Me.GroupBox1.Controls.Add(Me.ucrInputLineEndTickMarks)
        Me.GroupBox1.Controls.Add(Me.ucrNudSizeTickMarks)
        Me.GroupBox1.Controls.Add(Me.ucrInputColourTickMarks)
        Me.GroupBox1.Controls.Add(Me.ucrInputLineTypeTickMarks)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 270)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 283)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tick marks along axes"
        '
        'ucrInputMargin
        '
        Me.ucrInputMargin.AddQuotesIfUnrecognised = True
        Me.ucrInputMargin.IsMultiline = False
        Me.ucrInputMargin.IsReadOnly = False
        Me.ucrInputMargin.Location = New System.Drawing.Point(111, 199)
        Me.ucrInputMargin.Name = "ucrInputMargin"
        Me.ucrInputMargin.Size = New System.Drawing.Size(50, 23)
        Me.ucrInputMargin.TabIndex = 59
        '
        'ucrChkMaigin
        '
        Me.ucrChkMaigin.Checked = False
        Me.ucrChkMaigin.Location = New System.Drawing.Point(11, 199)
        Me.ucrChkMaigin.Name = "ucrChkMaigin"
        Me.ucrChkMaigin.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMaigin.TabIndex = 58
        '
        'ucrInputMarginUnits
        '
        Me.ucrInputMarginUnits.AddQuotesIfUnrecognised = True
        Me.ucrInputMarginUnits.IsReadOnly = False
        Me.ucrInputMarginUnits.Location = New System.Drawing.Point(111, 231)
        Me.ucrInputMarginUnits.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputMarginUnits.Name = "ucrInputMarginUnits"
        Me.ucrInputMarginUnits.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMarginUnits.TabIndex = 57
        '
        'ucrInputUnits
        '
        Me.ucrInputUnits.AddQuotesIfUnrecognised = True
        Me.ucrInputUnits.IsMultiline = False
        Me.ucrInputUnits.IsReadOnly = False
        Me.ucrInputUnits.Location = New System.Drawing.Point(111, 137)
        Me.ucrInputUnits.Name = "ucrInputUnits"
        Me.ucrInputUnits.Size = New System.Drawing.Size(50, 23)
        Me.ucrInputUnits.TabIndex = 56
        '
        'ucrChkLineEndTickMarksXAxis
        '
        Me.ucrChkLineEndTickMarksXAxis.Checked = False
        Me.ucrChkLineEndTickMarksXAxis.Location = New System.Drawing.Point(11, 111)
        Me.ucrChkLineEndTickMarksXAxis.Name = "ucrChkLineEndTickMarksXAxis"
        Me.ucrChkLineEndTickMarksXAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkLineEndTickMarksXAxis.TabIndex = 54
        '
        'ucrChkUnits
        '
        Me.ucrChkUnits.Checked = False
        Me.ucrChkUnits.Location = New System.Drawing.Point(11, 137)
        Me.ucrChkUnits.Name = "ucrChkUnits"
        Me.ucrChkUnits.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkUnits.TabIndex = 55
        '
        'ucrInputTickUnits
        '
        Me.ucrInputTickUnits.AddQuotesIfUnrecognised = True
        Me.ucrInputTickUnits.IsReadOnly = False
        Me.ucrInputTickUnits.Location = New System.Drawing.Point(111, 169)
        Me.ucrInputTickUnits.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputTickUnits.Name = "ucrInputTickUnits"
        Me.ucrInputTickUnits.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTickUnits.TabIndex = 54
        '
        'ucrChkSizeTickMarksXAxis
        '
        Me.ucrChkSizeTickMarksXAxis.Checked = False
        Me.ucrChkSizeTickMarksXAxis.Location = New System.Drawing.Point(11, 24)
        Me.ucrChkSizeTickMarksXAxis.Name = "ucrChkSizeTickMarksXAxis"
        Me.ucrChkSizeTickMarksXAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSizeTickMarksXAxis.TabIndex = 53
        '
        'ucrChkLineTypeTickMarksXAxis
        '
        Me.ucrChkLineTypeTickMarksXAxis.Checked = False
        Me.ucrChkLineTypeTickMarksXAxis.Location = New System.Drawing.Point(11, 53)
        Me.ucrChkLineTypeTickMarksXAxis.Name = "ucrChkLineTypeTickMarksXAxis"
        Me.ucrChkLineTypeTickMarksXAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkLineTypeTickMarksXAxis.TabIndex = 52
        '
        'ucrChkColourTickMarksXAxis
        '
        Me.ucrChkColourTickMarksXAxis.Checked = False
        Me.ucrChkColourTickMarksXAxis.Location = New System.Drawing.Point(11, 82)
        Me.ucrChkColourTickMarksXAxis.Name = "ucrChkColourTickMarksXAxis"
        Me.ucrChkColourTickMarksXAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkColourTickMarksXAxis.TabIndex = 51
        '
        'ucrInputLineEndTickMarks
        '
        Me.ucrInputLineEndTickMarks.AddQuotesIfUnrecognised = True
        Me.ucrInputLineEndTickMarks.IsReadOnly = False
        Me.ucrInputLineEndTickMarks.Location = New System.Drawing.Point(111, 110)
        Me.ucrInputLineEndTickMarks.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLineEndTickMarks.Name = "ucrInputLineEndTickMarks"
        Me.ucrInputLineEndTickMarks.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLineEndTickMarks.TabIndex = 32
        '
        'ucrNudSizeTickMarks
        '
        Me.ucrNudSizeTickMarks.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSizeTickMarks.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSizeTickMarks.Location = New System.Drawing.Point(111, 24)
        Me.ucrNudSizeTickMarks.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSizeTickMarks.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeTickMarks.Name = "ucrNudSizeTickMarks"
        Me.ucrNudSizeTickMarks.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSizeTickMarks.TabIndex = 30
        Me.ucrNudSizeTickMarks.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputColourTickMarks
        '
        Me.ucrInputColourTickMarks.AddQuotesIfUnrecognised = True
        Me.ucrInputColourTickMarks.IsReadOnly = False
        Me.ucrInputColourTickMarks.Location = New System.Drawing.Point(111, 81)
        Me.ucrInputColourTickMarks.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputColourTickMarks.Name = "ucrInputColourTickMarks"
        Me.ucrInputColourTickMarks.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColourTickMarks.TabIndex = 28
        '
        'ucrInputLineTypeTickMarks
        '
        Me.ucrInputLineTypeTickMarks.AddQuotesIfUnrecognised = True
        Me.ucrInputLineTypeTickMarks.IsReadOnly = False
        Me.ucrInputLineTypeTickMarks.Location = New System.Drawing.Point(111, 52)
        Me.ucrInputLineTypeTickMarks.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLineTypeTickMarks.Name = "ucrInputLineTypeTickMarks"
        Me.ucrInputLineTypeTickMarks.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLineTypeTickMarks.TabIndex = 26
        '
        'tbYaxis
        '
        Me.tbYaxis.Controls.Add(Me.ucrThemeRightYAxis)
        Me.tbYaxis.Controls.Add(Me.ucrThemeLeftYAxis)
        Me.tbYaxis.Controls.Add(Me.grpTickLabelYAxis)
        Me.tbYaxis.Controls.Add(Me.grpTickMarksYAxis)
        Me.tbYaxis.Location = New System.Drawing.Point(4, 22)
        Me.tbYaxis.Name = "tbYaxis"
        Me.tbYaxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbYaxis.Size = New System.Drawing.Size(597, 577)
        Me.tbYaxis.TabIndex = 1
        Me.tbYaxis.Text = "Y-axis"
        Me.tbYaxis.UseVisualStyleBackColor = True
        '
        'ucrThemeRightYAxis
        '
        Me.ucrThemeRightYAxis.Location = New System.Drawing.Point(305, 10)
        Me.ucrThemeRightYAxis.Name = "ucrThemeRightYAxis"
        Me.ucrThemeRightYAxis.Size = New System.Drawing.Size(296, 260)
        Me.ucrThemeRightYAxis.TabIndex = 58
        '
        'ucrThemeLeftYAxis
        '
        Me.ucrThemeLeftYAxis.Location = New System.Drawing.Point(12, 10)
        Me.ucrThemeLeftYAxis.Name = "ucrThemeLeftYAxis"
        Me.ucrThemeLeftYAxis.Size = New System.Drawing.Size(296, 260)
        Me.ucrThemeLeftYAxis.TabIndex = 57
        '
        'grpTickLabelYAxis
        '
        Me.grpTickLabelYAxis.Controls.Add(Me.ucrChkLineEndTickLabelsYAxis)
        Me.grpTickLabelYAxis.Controls.Add(Me.ucrChkSizeTickLabelsYAxis)
        Me.grpTickLabelYAxis.Controls.Add(Me.ucrChkLineTypeTickLabelsYAxis)
        Me.grpTickLabelYAxis.Controls.Add(Me.ucrChkColourTickLabelsYAxis)
        Me.grpTickLabelYAxis.Controls.Add(Me.ucrInputLineEndTickLabelsYAxis)
        Me.grpTickLabelYAxis.Controls.Add(Me.ucrNudSizeTickLabelsYAxis)
        Me.grpTickLabelYAxis.Controls.Add(Me.ucrInputColourTickLabelsYAxis)
        Me.grpTickLabelYAxis.Controls.Add(Me.ucrInputLineTypeTickLabelsYAxis)
        Me.grpTickLabelYAxis.Location = New System.Drawing.Point(263, 256)
        Me.grpTickLabelYAxis.Name = "grpTickLabelYAxis"
        Me.grpTickLabelYAxis.Size = New System.Drawing.Size(264, 154)
        Me.grpTickLabelYAxis.TabIndex = 43
        Me.grpTickLabelYAxis.TabStop = False
        Me.grpTickLabelYAxis.Text = "Y axis tick labels"
        '
        'ucrChkLineEndTickLabelsYAxis
        '
        Me.ucrChkLineEndTickLabelsYAxis.Checked = False
        Me.ucrChkLineEndTickLabelsYAxis.Location = New System.Drawing.Point(13, 107)
        Me.ucrChkLineEndTickLabelsYAxis.Name = "ucrChkLineEndTickLabelsYAxis"
        Me.ucrChkLineEndTickLabelsYAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkLineEndTickLabelsYAxis.TabIndex = 58
        '
        'ucrChkSizeTickLabelsYAxis
        '
        Me.ucrChkSizeTickLabelsYAxis.Checked = False
        Me.ucrChkSizeTickLabelsYAxis.Location = New System.Drawing.Point(13, 20)
        Me.ucrChkSizeTickLabelsYAxis.Name = "ucrChkSizeTickLabelsYAxis"
        Me.ucrChkSizeTickLabelsYAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSizeTickLabelsYAxis.TabIndex = 57
        '
        'ucrChkLineTypeTickLabelsYAxis
        '
        Me.ucrChkLineTypeTickLabelsYAxis.Checked = False
        Me.ucrChkLineTypeTickLabelsYAxis.Location = New System.Drawing.Point(13, 49)
        Me.ucrChkLineTypeTickLabelsYAxis.Name = "ucrChkLineTypeTickLabelsYAxis"
        Me.ucrChkLineTypeTickLabelsYAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkLineTypeTickLabelsYAxis.TabIndex = 56
        '
        'ucrChkColourTickLabelsYAxis
        '
        Me.ucrChkColourTickLabelsYAxis.Checked = False
        Me.ucrChkColourTickLabelsYAxis.Location = New System.Drawing.Point(13, 78)
        Me.ucrChkColourTickLabelsYAxis.Name = "ucrChkColourTickLabelsYAxis"
        Me.ucrChkColourTickLabelsYAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkColourTickLabelsYAxis.TabIndex = 55
        '
        'ucrInputLineEndTickLabelsYAxis
        '
        Me.ucrInputLineEndTickLabelsYAxis.AddQuotesIfUnrecognised = True
        Me.ucrInputLineEndTickLabelsYAxis.IsReadOnly = False
        Me.ucrInputLineEndTickLabelsYAxis.Location = New System.Drawing.Point(114, 106)
        Me.ucrInputLineEndTickLabelsYAxis.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLineEndTickLabelsYAxis.Name = "ucrInputLineEndTickLabelsYAxis"
        Me.ucrInputLineEndTickLabelsYAxis.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLineEndTickLabelsYAxis.TabIndex = 32
        '
        'ucrNudSizeTickLabelsYAxis
        '
        Me.ucrNudSizeTickLabelsYAxis.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSizeTickLabelsYAxis.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSizeTickLabelsYAxis.Location = New System.Drawing.Point(114, 19)
        Me.ucrNudSizeTickLabelsYAxis.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSizeTickLabelsYAxis.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeTickLabelsYAxis.Name = "ucrNudSizeTickLabelsYAxis"
        Me.ucrNudSizeTickLabelsYAxis.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSizeTickLabelsYAxis.TabIndex = 30
        Me.ucrNudSizeTickLabelsYAxis.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputColourTickLabelsYAxis
        '
        Me.ucrInputColourTickLabelsYAxis.AddQuotesIfUnrecognised = True
        Me.ucrInputColourTickLabelsYAxis.IsReadOnly = False
        Me.ucrInputColourTickLabelsYAxis.Location = New System.Drawing.Point(114, 77)
        Me.ucrInputColourTickLabelsYAxis.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputColourTickLabelsYAxis.Name = "ucrInputColourTickLabelsYAxis"
        Me.ucrInputColourTickLabelsYAxis.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColourTickLabelsYAxis.TabIndex = 28
        '
        'ucrInputLineTypeTickLabelsYAxis
        '
        Me.ucrInputLineTypeTickLabelsYAxis.AddQuotesIfUnrecognised = True
        Me.ucrInputLineTypeTickLabelsYAxis.IsReadOnly = False
        Me.ucrInputLineTypeTickLabelsYAxis.Location = New System.Drawing.Point(114, 48)
        Me.ucrInputLineTypeTickLabelsYAxis.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLineTypeTickLabelsYAxis.Name = "ucrInputLineTypeTickLabelsYAxis"
        Me.ucrInputLineTypeTickLabelsYAxis.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLineTypeTickLabelsYAxis.TabIndex = 26
        '
        'grpTickMarksYAxis
        '
        Me.grpTickMarksYAxis.Controls.Add(Me.ucrChkLineEndTickMarksYAxis)
        Me.grpTickMarksYAxis.Controls.Add(Me.ucrChkSizeTickMarksYAxis)
        Me.grpTickMarksYAxis.Controls.Add(Me.ucrChkLineTypeTickMarksYAxis)
        Me.grpTickMarksYAxis.Controls.Add(Me.ucrChkColourTickMarksYAxis)
        Me.grpTickMarksYAxis.Controls.Add(Me.ucrInputLineEndTickMarksYAxis)
        Me.grpTickMarksYAxis.Controls.Add(Me.ucrNudSizeTickMarksYAxis)
        Me.grpTickMarksYAxis.Controls.Add(Me.ucrInputColourTickMarksYAxis)
        Me.grpTickMarksYAxis.Controls.Add(Me.ucrInputLineTypeTickMarksYAxis)
        Me.grpTickMarksYAxis.Location = New System.Drawing.Point(6, 256)
        Me.grpTickMarksYAxis.Name = "grpTickMarksYAxis"
        Me.grpTickMarksYAxis.Size = New System.Drawing.Size(250, 154)
        Me.grpTickMarksYAxis.TabIndex = 42
        Me.grpTickMarksYAxis.TabStop = False
        Me.grpTickMarksYAxis.Text = "Tick marks along axes"
        '
        'ucrChkLineEndTickMarksYAxis
        '
        Me.ucrChkLineEndTickMarksYAxis.Checked = False
        Me.ucrChkLineEndTickMarksYAxis.Location = New System.Drawing.Point(6, 107)
        Me.ucrChkLineEndTickMarksYAxis.Name = "ucrChkLineEndTickMarksYAxis"
        Me.ucrChkLineEndTickMarksYAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkLineEndTickMarksYAxis.TabIndex = 58
        '
        'ucrChkSizeTickMarksYAxis
        '
        Me.ucrChkSizeTickMarksYAxis.Checked = False
        Me.ucrChkSizeTickMarksYAxis.Location = New System.Drawing.Point(6, 20)
        Me.ucrChkSizeTickMarksYAxis.Name = "ucrChkSizeTickMarksYAxis"
        Me.ucrChkSizeTickMarksYAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSizeTickMarksYAxis.TabIndex = 57
        '
        'ucrChkLineTypeTickMarksYAxis
        '
        Me.ucrChkLineTypeTickMarksYAxis.Checked = False
        Me.ucrChkLineTypeTickMarksYAxis.Location = New System.Drawing.Point(6, 49)
        Me.ucrChkLineTypeTickMarksYAxis.Name = "ucrChkLineTypeTickMarksYAxis"
        Me.ucrChkLineTypeTickMarksYAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkLineTypeTickMarksYAxis.TabIndex = 56
        '
        'ucrChkColourTickMarksYAxis
        '
        Me.ucrChkColourTickMarksYAxis.Checked = False
        Me.ucrChkColourTickMarksYAxis.Location = New System.Drawing.Point(6, 78)
        Me.ucrChkColourTickMarksYAxis.Name = "ucrChkColourTickMarksYAxis"
        Me.ucrChkColourTickMarksYAxis.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkColourTickMarksYAxis.TabIndex = 55
        '
        'ucrInputLineEndTickMarksYAxis
        '
        Me.ucrInputLineEndTickMarksYAxis.AddQuotesIfUnrecognised = True
        Me.ucrInputLineEndTickMarksYAxis.IsReadOnly = False
        Me.ucrInputLineEndTickMarksYAxis.Location = New System.Drawing.Point(110, 106)
        Me.ucrInputLineEndTickMarksYAxis.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLineEndTickMarksYAxis.Name = "ucrInputLineEndTickMarksYAxis"
        Me.ucrInputLineEndTickMarksYAxis.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLineEndTickMarksYAxis.TabIndex = 32
        '
        'ucrNudSizeTickMarksYAxis
        '
        Me.ucrNudSizeTickMarksYAxis.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSizeTickMarksYAxis.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSizeTickMarksYAxis.Location = New System.Drawing.Point(110, 19)
        Me.ucrNudSizeTickMarksYAxis.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSizeTickMarksYAxis.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeTickMarksYAxis.Name = "ucrNudSizeTickMarksYAxis"
        Me.ucrNudSizeTickMarksYAxis.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSizeTickMarksYAxis.TabIndex = 30
        Me.ucrNudSizeTickMarksYAxis.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputColourTickMarksYAxis
        '
        Me.ucrInputColourTickMarksYAxis.AddQuotesIfUnrecognised = True
        Me.ucrInputColourTickMarksYAxis.IsReadOnly = False
        Me.ucrInputColourTickMarksYAxis.Location = New System.Drawing.Point(110, 77)
        Me.ucrInputColourTickMarksYAxis.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputColourTickMarksYAxis.Name = "ucrInputColourTickMarksYAxis"
        Me.ucrInputColourTickMarksYAxis.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColourTickMarksYAxis.TabIndex = 28
        '
        'ucrInputLineTypeTickMarksYAxis
        '
        Me.ucrInputLineTypeTickMarksYAxis.AddQuotesIfUnrecognised = True
        Me.ucrInputLineTypeTickMarksYAxis.IsReadOnly = False
        Me.ucrInputLineTypeTickMarksYAxis.Location = New System.Drawing.Point(110, 48)
        Me.ucrInputLineTypeTickMarksYAxis.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLineTypeTickMarksYAxis.Name = "ucrInputLineTypeTickMarksYAxis"
        Me.ucrInputLineTypeTickMarksYAxis.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLineTypeTickMarksYAxis.TabIndex = 26
        '
        'ucrBaseSubdialogue
        '
        Me.ucrBaseSubdialogue.Location = New System.Drawing.Point(215, 610)
        Me.ucrBaseSubdialogue.Name = "ucrBaseSubdialogue"
        Me.ucrBaseSubdialogue.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSubdialogue.TabIndex = 0
        '
        'sdgThemes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 652)
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
        Me.GroupBox2.ResumeLayout(False)
        Me.grpTickLabels.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.tbYaxis.ResumeLayout(False)
        Me.grpTickLabelYAxis.ResumeLayout(False)
        Me.grpTickMarksYAxis.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSubdialogue As ucrButtonsSubdialogue
    Friend WithEvents tbXaxis As TabControl
    Friend WithEvents tbAxis As TabPage
    Friend WithEvents grpTableOptions As GroupBox
    Friend WithEvents tbYaxis As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrNudSizeTickMarks As ucrNud
    Friend WithEvents ucrInputColourTickMarks As ucrInputComboBox
    Friend WithEvents ucrInputLineTypeTickMarks As ucrInputComboBox
    Friend WithEvents ucrInputLineEndTickMarks As ucrInputComboBox
    Friend WithEvents grpTickLabels As GroupBox
    Friend WithEvents ucrInputLineEndTickLabelsXAxis As ucrInputComboBox
    Friend WithEvents ucrNudSizeTickLabelsXAxis As ucrNud
    Friend WithEvents ucrInputColourTickLabelsXAxis As ucrInputComboBox
    Friend WithEvents ucrInputLineTypeTickLabelsXAxis As ucrInputComboBox
    Friend WithEvents grpTickLabelYAxis As GroupBox
    Friend WithEvents ucrInputLineEndTickLabelsYAxis As ucrInputComboBox
    Friend WithEvents ucrNudSizeTickLabelsYAxis As ucrNud
    Friend WithEvents ucrInputColourTickLabelsYAxis As ucrInputComboBox
    Friend WithEvents ucrInputLineTypeTickLabelsYAxis As ucrInputComboBox
    Friend WithEvents grpTickMarksYAxis As GroupBox
    Friend WithEvents ucrInputLineEndTickMarksYAxis As ucrInputComboBox
    Friend WithEvents ucrNudSizeTickMarksYAxis As ucrNud
    Friend WithEvents ucrInputColourTickMarksYAxis As ucrInputComboBox
    Friend WithEvents ucrInputLineTypeTickMarksYAxis As ucrInputComboBox
    Friend WithEvents ucrChkLineEndTickLabelsXAxis As ucrCheck
    Friend WithEvents ucrChkSizeTickLabelsXAxis As ucrCheck
    Friend WithEvents ucrChkLineTypeTickLabelsXAxis As ucrCheck
    Friend WithEvents ucrChkColourTickLabelsXAxis As ucrCheck
    Friend WithEvents ucrChkLineEndTickMarksXAxis As ucrCheck
    Friend WithEvents ucrChkSizeTickMarksXAxis As ucrCheck
    Friend WithEvents ucrChkLineTypeTickMarksXAxis As ucrCheck
    Friend WithEvents ucrChkColourTickMarksXAxis As ucrCheck
    Friend WithEvents ucrChkLineEndTickLabelsYAxis As ucrCheck
    Friend WithEvents ucrChkSizeTickLabelsYAxis As ucrCheck
    Friend WithEvents ucrChkLineTypeTickLabelsYAxis As ucrCheck
    Friend WithEvents ucrChkColourTickLabelsYAxis As ucrCheck
    Friend WithEvents ucrChkLineEndTickMarksYAxis As ucrCheck
    Friend WithEvents ucrChkSizeTickMarksYAxis As ucrCheck
    Friend WithEvents ucrChkLineTypeTickMarksYAxis As ucrCheck
    Friend WithEvents ucrChkColourTickMarksYAxis As ucrCheck
    Friend WithEvents ucrInputUnits As ucrInputTextBox
    Friend WithEvents ucrChkUnits As ucrCheck
    Friend WithEvents ucrInputTickUnits As ucrInputComboBox
    Friend WithEvents ucrInputMargin As ucrInputTextBox
    Friend WithEvents ucrChkMaigin As ucrCheck
    Friend WithEvents ucrInputMarginUnits As ucrInputComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents UcrCheck1 As ucrCheck
    Friend WithEvents UcrCheck2 As ucrCheck
    Friend WithEvents UcrCheck3 As ucrCheck
    Friend WithEvents UcrCheck4 As ucrCheck
    Friend WithEvents UcrInputComboBox1 As ucrInputComboBox
    Friend WithEvents UcrNud1 As ucrNud
    Friend WithEvents UcrInputComboBox2 As ucrInputComboBox
    Friend WithEvents UcrInputComboBox3 As ucrInputComboBox
    Friend WithEvents ucrThemeBottomXAxis As ucrThemeAxes
    Friend WithEvents ucrThemeTopXAxis As ucrThemeAxes
    Friend WithEvents ucrThemeRightYAxis As ucrThemeAxes
    Friend WithEvents ucrThemeLeftYAxis As ucrThemeAxes
End Class
