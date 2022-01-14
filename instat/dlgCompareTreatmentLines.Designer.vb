<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCompareTreatmentLines
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
        Me.lblMeasurement = New System.Windows.Forms.Label()
        Me.lblOption = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblOption1 = New System.Windows.Forms.Label()
        Me.lblTreatment2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblContext3 = New System.Windows.Forms.Label()
        Me.ucrInputContext3 = New instat.ucrInputComboBox()
        Me.ucrReceiverContext3 = New instat.ucrReceiverSingle()
        Me.lblContext2 = New System.Windows.Forms.Label()
        Me.lblContext1 = New System.Windows.Forms.Label()
        Me.ucrInputContext2 = New instat.ucrInputComboBox()
        Me.ucrReceiverContext2 = New instat.ucrReceiverSingle()
        Me.ucrInputContext1 = New instat.ucrInputComboBox()
        Me.ucrReceiverContext1 = New instat.ucrReceiverSingle()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkIncludeMeanLine = New instat.ucrCheck()
        Me.ucrChkIncludeSmoothLine = New instat.ucrCheck()
        Me.ucrChkBoxplotOnlyComplete = New instat.ucrCheck()
        Me.ucrInputHlineValue = New instat.ucrInputTextBox()
        Me.lblHlineValue = New System.Windows.Forms.Label()
        Me.ucrChkIncludeHline = New instat.ucrCheck()
        Me.lblTransparency = New System.Windows.Forms.Label()
        Me.ucrNudTransparency = New instat.ucrNud()
        Me.ucrChkIncludeBoxplot = New instat.ucrCheck()
        Me.ucrChkColourByDifference = New instat.ucrCheck()
        Me.rdoLines = New System.Windows.Forms.RadioButton()
        Me.rdoPoints = New System.Windows.Forms.RadioButton()
        Me.ucrPnlCompareType = New instat.UcrPanel()
        Me.ucrInputFactorOption2 = New instat.ucrInputFactorLevels()
        Me.ucrInputFactorOption1 = New instat.ucrInputFactorLevels()
        Me.ucrReceiverID = New instat.ucrReceiverSingle()
        Me.ucrReceiverOption = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeasurement = New instat.ucrReceiverSingle()
        Me.ucrSelectorPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.GroupBox1.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMeasurement
        '
        Me.lblMeasurement.AutoSize = True
        Me.lblMeasurement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMeasurement.Location = New System.Drawing.Point(267, 80)
        Me.lblMeasurement.Name = "lblMeasurement"
        Me.lblMeasurement.Size = New System.Drawing.Size(74, 13)
        Me.lblMeasurement.TabIndex = 4
        Me.lblMeasurement.Text = "Measurement:"
        '
        'lblOption
        '
        Me.lblOption.AutoSize = True
        Me.lblOption.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOption.Location = New System.Drawing.Point(267, 121)
        Me.lblOption.Name = "lblOption"
        Me.lblOption.Size = New System.Drawing.Size(41, 13)
        Me.lblOption.TabIndex = 6
        Me.lblOption.Text = "Option:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblID.Location = New System.Drawing.Point(267, 246)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 12
        Me.lblID.Text = "ID:"
        '
        'lblOption1
        '
        Me.lblOption1.AutoSize = True
        Me.lblOption1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOption1.Location = New System.Drawing.Point(267, 162)
        Me.lblOption1.Name = "lblOption1"
        Me.lblOption1.Size = New System.Drawing.Size(50, 13)
        Me.lblOption1.TabIndex = 8
        Me.lblOption1.Text = "Option 1:"
        '
        'lblTreatment2
        '
        Me.lblTreatment2.AutoSize = True
        Me.lblTreatment2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTreatment2.Location = New System.Drawing.Point(267, 204)
        Me.lblTreatment2.Name = "lblTreatment2"
        Me.lblTreatment2.Size = New System.Drawing.Size(50, 13)
        Me.lblTreatment2.TabIndex = 10
        Me.lblTreatment2.Text = "Option 2:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblContext3)
        Me.GroupBox1.Controls.Add(Me.ucrInputContext3)
        Me.GroupBox1.Controls.Add(Me.ucrReceiverContext3)
        Me.GroupBox1.Controls.Add(Me.lblContext2)
        Me.GroupBox1.Controls.Add(Me.lblContext1)
        Me.GroupBox1.Controls.Add(Me.ucrInputContext2)
        Me.GroupBox1.Controls.Add(Me.ucrReceiverContext2)
        Me.GroupBox1.Controls.Add(Me.ucrInputContext1)
        Me.GroupBox1.Controls.Add(Me.ucrReceiverContext1)
        Me.GroupBox1.Location = New System.Drawing.Point(263, 292)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 184)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Include Contexts"
        '
        'lblContext3
        '
        Me.lblContext3.AutoSize = True
        Me.lblContext3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContext3.Location = New System.Drawing.Point(6, 115)
        Me.lblContext3.Name = "lblContext3"
        Me.lblContext3.Size = New System.Drawing.Size(73, 13)
        Me.lblContext3.TabIndex = 6
        Me.lblContext3.Text = "Third Context:"
        '
        'ucrInputContext3
        '
        Me.ucrInputContext3.AddQuotesIfUnrecognised = True
        Me.ucrInputContext3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputContext3.GetSetSelectedIndex = -1
        Me.ucrInputContext3.IsReadOnly = False
        Me.ucrInputContext3.Location = New System.Drawing.Point(141, 130)
        Me.ucrInputContext3.Name = "ucrInputContext3"
        Me.ucrInputContext3.Size = New System.Drawing.Size(98, 21)
        Me.ucrInputContext3.TabIndex = 8
        '
        'ucrReceiverContext3
        '
        Me.ucrReceiverContext3.AutoSize = True
        Me.ucrReceiverContext3.frmParent = Me
        Me.ucrReceiverContext3.Location = New System.Drawing.Point(8, 130)
        Me.ucrReceiverContext3.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContext3.Name = "ucrReceiverContext3"
        Me.ucrReceiverContext3.Selector = Nothing
        Me.ucrReceiverContext3.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverContext3.strNcFilePath = ""
        Me.ucrReceiverContext3.TabIndex = 7
        Me.ucrReceiverContext3.ucrSelector = Nothing
        '
        'lblContext2
        '
        Me.lblContext2.AutoSize = True
        Me.lblContext2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContext2.Location = New System.Drawing.Point(6, 69)
        Me.lblContext2.Name = "lblContext2"
        Me.lblContext2.Size = New System.Drawing.Size(86, 13)
        Me.lblContext2.TabIndex = 3
        Me.lblContext2.Text = "Second Context:"
        '
        'lblContext1
        '
        Me.lblContext1.AutoSize = True
        Me.lblContext1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContext1.Location = New System.Drawing.Point(6, 23)
        Me.lblContext1.Name = "lblContext1"
        Me.lblContext1.Size = New System.Drawing.Size(68, 13)
        Me.lblContext1.TabIndex = 0
        Me.lblContext1.Text = "First Context:"
        '
        'ucrInputContext2
        '
        Me.ucrInputContext2.AddQuotesIfUnrecognised = True
        Me.ucrInputContext2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputContext2.GetSetSelectedIndex = -1
        Me.ucrInputContext2.IsReadOnly = False
        Me.ucrInputContext2.Location = New System.Drawing.Point(141, 84)
        Me.ucrInputContext2.Name = "ucrInputContext2"
        Me.ucrInputContext2.Size = New System.Drawing.Size(98, 21)
        Me.ucrInputContext2.TabIndex = 5
        '
        'ucrReceiverContext2
        '
        Me.ucrReceiverContext2.AutoSize = True
        Me.ucrReceiverContext2.frmParent = Me
        Me.ucrReceiverContext2.Location = New System.Drawing.Point(8, 84)
        Me.ucrReceiverContext2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContext2.Name = "ucrReceiverContext2"
        Me.ucrReceiverContext2.Selector = Nothing
        Me.ucrReceiverContext2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverContext2.strNcFilePath = ""
        Me.ucrReceiverContext2.TabIndex = 4
        Me.ucrReceiverContext2.ucrSelector = Nothing
        '
        'ucrInputContext1
        '
        Me.ucrInputContext1.AddQuotesIfUnrecognised = True
        Me.ucrInputContext1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputContext1.GetSetSelectedIndex = -1
        Me.ucrInputContext1.IsReadOnly = False
        Me.ucrInputContext1.Location = New System.Drawing.Point(141, 38)
        Me.ucrInputContext1.Name = "ucrInputContext1"
        Me.ucrInputContext1.Size = New System.Drawing.Size(98, 21)
        Me.ucrInputContext1.TabIndex = 2
        '
        'ucrReceiverContext1
        '
        Me.ucrReceiverContext1.AutoSize = True
        Me.ucrReceiverContext1.frmParent = Me
        Me.ucrReceiverContext1.Location = New System.Drawing.Point(8, 38)
        Me.ucrReceiverContext1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContext1.Name = "ucrReceiverContext1"
        Me.ucrReceiverContext1.Selector = Nothing
        Me.ucrReceiverContext1.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverContext1.strNcFilePath = ""
        Me.ucrReceiverContext1.TabIndex = 1
        Me.ucrReceiverContext1.ucrSelector = Nothing
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkIncludeMeanLine)
        Me.grpOptions.Controls.Add(Me.ucrChkIncludeSmoothLine)
        Me.grpOptions.Controls.Add(Me.ucrChkBoxplotOnlyComplete)
        Me.grpOptions.Controls.Add(Me.ucrInputHlineValue)
        Me.grpOptions.Controls.Add(Me.lblHlineValue)
        Me.grpOptions.Controls.Add(Me.ucrChkIncludeHline)
        Me.grpOptions.Controls.Add(Me.lblTransparency)
        Me.grpOptions.Controls.Add(Me.ucrNudTransparency)
        Me.grpOptions.Controls.Add(Me.ucrChkIncludeBoxplot)
        Me.grpOptions.Controls.Add(Me.ucrChkColourByDifference)
        Me.grpOptions.Location = New System.Drawing.Point(7, 292)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(234, 184)
        Me.grpOptions.TabIndex = 14
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrChkIncludeMeanLine
        '
        Me.ucrChkIncludeMeanLine.AutoSize = True
        Me.ucrChkIncludeMeanLine.Checked = False
        Me.ucrChkIncludeMeanLine.Location = New System.Drawing.Point(6, 48)
        Me.ucrChkIncludeMeanLine.Name = "ucrChkIncludeMeanLine"
        Me.ucrChkIncludeMeanLine.Size = New System.Drawing.Size(178, 23)
        Me.ucrChkIncludeMeanLine.TabIndex = 1
        '
        'ucrChkIncludeSmoothLine
        '
        Me.ucrChkIncludeSmoothLine.AutoSize = True
        Me.ucrChkIncludeSmoothLine.Checked = False
        Me.ucrChkIncludeSmoothLine.Location = New System.Drawing.Point(6, 22)
        Me.ucrChkIncludeSmoothLine.Name = "ucrChkIncludeSmoothLine"
        Me.ucrChkIncludeSmoothLine.Size = New System.Drawing.Size(222, 23)
        Me.ucrChkIncludeSmoothLine.TabIndex = 0
        '
        'ucrChkBoxplotOnlyComplete
        '
        Me.ucrChkBoxplotOnlyComplete.AutoSize = True
        Me.ucrChkBoxplotOnlyComplete.Checked = False
        Me.ucrChkBoxplotOnlyComplete.Location = New System.Drawing.Point(31, 98)
        Me.ucrChkBoxplotOnlyComplete.Name = "ucrChkBoxplotOnlyComplete"
        Me.ucrChkBoxplotOnlyComplete.Size = New System.Drawing.Size(197, 23)
        Me.ucrChkBoxplotOnlyComplete.TabIndex = 4
        '
        'ucrInputHlineValue
        '
        Me.ucrInputHlineValue.AddQuotesIfUnrecognised = True
        Me.ucrInputHlineValue.AutoSize = True
        Me.ucrInputHlineValue.IsMultiline = False
        Me.ucrInputHlineValue.IsReadOnly = False
        Me.ucrInputHlineValue.Location = New System.Drawing.Point(89, 152)
        Me.ucrInputHlineValue.Name = "ucrInputHlineValue"
        Me.ucrInputHlineValue.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputHlineValue.TabIndex = 7
        '
        'lblHlineValue
        '
        Me.lblHlineValue.AutoSize = True
        Me.lblHlineValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHlineValue.Location = New System.Drawing.Point(44, 156)
        Me.lblHlineValue.Name = "lblHlineValue"
        Me.lblHlineValue.Size = New System.Drawing.Size(36, 13)
        Me.lblHlineValue.TabIndex = 6
        Me.lblHlineValue.Text = "At Y ="
        '
        'ucrChkIncludeHline
        '
        Me.ucrChkIncludeHline.AutoSize = True
        Me.ucrChkIncludeHline.Checked = False
        Me.ucrChkIncludeHline.Location = New System.Drawing.Point(6, 129)
        Me.ucrChkIncludeHline.Name = "ucrChkIncludeHline"
        Me.ucrChkIncludeHline.Size = New System.Drawing.Size(222, 23)
        Me.ucrChkIncludeHline.TabIndex = 5
        '
        'lblTransparency
        '
        Me.lblTransparency.AutoSize = True
        Me.lblTransparency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTransparency.Location = New System.Drawing.Point(31, 74)
        Me.lblTransparency.Name = "lblTransparency"
        Me.lblTransparency.Size = New System.Drawing.Size(75, 13)
        Me.lblTransparency.TabIndex = 2
        Me.lblTransparency.Text = "Transparency:"
        '
        'ucrNudTransparency
        '
        Me.ucrNudTransparency.AutoSize = True
        Me.ucrNudTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTransparency.Location = New System.Drawing.Point(114, 72)
        Me.ucrNudTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Name = "ucrNudTransparency"
        Me.ucrNudTransparency.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTransparency.TabIndex = 3
        Me.ucrNudTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkIncludeBoxplot
        '
        Me.ucrChkIncludeBoxplot.AutoSize = True
        Me.ucrChkIncludeBoxplot.Checked = False
        Me.ucrChkIncludeBoxplot.Location = New System.Drawing.Point(6, 48)
        Me.ucrChkIncludeBoxplot.Name = "ucrChkIncludeBoxplot"
        Me.ucrChkIncludeBoxplot.Size = New System.Drawing.Size(178, 23)
        Me.ucrChkIncludeBoxplot.TabIndex = 14
        '
        'ucrChkColourByDifference
        '
        Me.ucrChkColourByDifference.AutoSize = True
        Me.ucrChkColourByDifference.Checked = False
        Me.ucrChkColourByDifference.Location = New System.Drawing.Point(6, 22)
        Me.ucrChkColourByDifference.Name = "ucrChkColourByDifference"
        Me.ucrChkColourByDifference.Size = New System.Drawing.Size(178, 23)
        Me.ucrChkColourByDifference.TabIndex = 13
        '
        'rdoLines
        '
        Me.rdoLines.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLines.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLines.FlatAppearance.BorderSize = 2
        Me.rdoLines.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLines.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLines.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLines.Location = New System.Drawing.Point(122, 15)
        Me.rdoLines.Name = "rdoLines"
        Me.rdoLines.Size = New System.Drawing.Size(140, 28)
        Me.rdoLines.TabIndex = 0
        Me.rdoLines.Text = "Connecting Lines"
        Me.rdoLines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLines.UseVisualStyleBackColor = True
        '
        'rdoPoints
        '
        Me.rdoPoints.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPoints.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPoints.FlatAppearance.BorderSize = 2
        Me.rdoPoints.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPoints.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPoints.Location = New System.Drawing.Point(260, 15)
        Me.rdoPoints.Name = "rdoPoints"
        Me.rdoPoints.Size = New System.Drawing.Size(140, 28)
        Me.rdoPoints.TabIndex = 1
        Me.rdoPoints.Text = "Points"
        Me.rdoPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPoints.UseVisualStyleBackColor = True
        '
        'ucrPnlCompareType
        '
        Me.ucrPnlCompareType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlCompareType.Location = New System.Drawing.Point(54, 2)
        Me.ucrPnlCompareType.Name = "ucrPnlCompareType"
        Me.ucrPnlCompareType.Size = New System.Drawing.Size(397, 62)
        Me.ucrPnlCompareType.TabIndex = 2
        '
        'ucrInputFactorOption2
        '
        Me.ucrInputFactorOption2.AddQuotesIfUnrecognised = True
        Me.ucrInputFactorOption2.AutoSize = True
        Me.ucrInputFactorOption2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFactorOption2.GetSetSelectedIndex = -1
        Me.ucrInputFactorOption2.IsReadOnly = False
        Me.ucrInputFactorOption2.Location = New System.Drawing.Point(267, 219)
        Me.ucrInputFactorOption2.Name = "ucrInputFactorOption2"
        Me.ucrInputFactorOption2.Size = New System.Drawing.Size(0, 0)
        Me.ucrInputFactorOption2.TabIndex = 11
        '
        'ucrInputFactorOption1
        '
        Me.ucrInputFactorOption1.AddQuotesIfUnrecognised = True
        Me.ucrInputFactorOption1.AutoSize = True
        Me.ucrInputFactorOption1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFactorOption1.GetSetSelectedIndex = -1
        Me.ucrInputFactorOption1.IsReadOnly = False
        Me.ucrInputFactorOption1.Location = New System.Drawing.Point(267, 177)
        Me.ucrInputFactorOption1.Name = "ucrInputFactorOption1"
        Me.ucrInputFactorOption1.Size = New System.Drawing.Size(0, 0)
        Me.ucrInputFactorOption1.TabIndex = 9
        '
        'ucrReceiverID
        '
        Me.ucrReceiverID.AutoSize = True
        Me.ucrReceiverID.frmParent = Me
        Me.ucrReceiverID.Location = New System.Drawing.Point(267, 261)
        Me.ucrReceiverID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverID.Name = "ucrReceiverID"
        Me.ucrReceiverID.Selector = Nothing
        Me.ucrReceiverID.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverID.strNcFilePath = ""
        Me.ucrReceiverID.TabIndex = 13
        Me.ucrReceiverID.ucrSelector = Nothing
        '
        'ucrReceiverOption
        '
        Me.ucrReceiverOption.AutoSize = True
        Me.ucrReceiverOption.frmParent = Me
        Me.ucrReceiverOption.Location = New System.Drawing.Point(267, 136)
        Me.ucrReceiverOption.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOption.Name = "ucrReceiverOption"
        Me.ucrReceiverOption.Selector = Nothing
        Me.ucrReceiverOption.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverOption.strNcFilePath = ""
        Me.ucrReceiverOption.TabIndex = 7
        Me.ucrReceiverOption.ucrSelector = Nothing
        '
        'ucrReceiverMeasurement
        '
        Me.ucrReceiverMeasurement.AutoSize = True
        Me.ucrReceiverMeasurement.frmParent = Me
        Me.ucrReceiverMeasurement.Location = New System.Drawing.Point(267, 95)
        Me.ucrReceiverMeasurement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeasurement.Name = "ucrReceiverMeasurement"
        Me.ucrReceiverMeasurement.Selector = Nothing
        Me.ucrReceiverMeasurement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMeasurement.strNcFilePath = ""
        Me.ucrReceiverMeasurement.TabIndex = 5
        Me.ucrReceiverMeasurement.ucrSelector = Nothing
        '
        'ucrSelectorPlot
        '
        Me.ucrSelectorPlot.AutoSize = True
        Me.ucrSelectorPlot.bDropUnusedFilterLevels = False
        Me.ucrSelectorPlot.bShowHiddenColumns = False
        Me.ucrSelectorPlot.bUseCurrentFilter = True
        Me.ucrSelectorPlot.Location = New System.Drawing.Point(7, 64)
        Me.ucrSelectorPlot.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPlot.Name = "ucrSelectorPlot"
        Me.ucrSelectorPlot.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorPlot.TabIndex = 3
        '
        'ucrSavePlot
        '
        Me.ucrSavePlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSavePlot.Location = New System.Drawing.Point(9, 482)
        Me.ucrSavePlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSavePlot.Name = "ucrSavePlot"
        Me.ucrSavePlot.Size = New System.Drawing.Size(333, 24)
        Me.ucrSavePlot.TabIndex = 16
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 507)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 17
        '
        'dlgCompareTreatmentLines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(523, 562)
        Me.Controls.Add(Me.rdoPoints)
        Me.Controls.Add(Me.rdoLines)
        Me.Controls.Add(Me.ucrPnlCompareType)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTreatment2)
        Me.Controls.Add(Me.lblOption1)
        Me.Controls.Add(Me.ucrInputFactorOption2)
        Me.Controls.Add(Me.ucrInputFactorOption1)
        Me.Controls.Add(Me.ucrReceiverID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.ucrReceiverOption)
        Me.Controls.Add(Me.lblOption)
        Me.Controls.Add(Me.ucrReceiverMeasurement)
        Me.Controls.Add(Me.lblMeasurement)
        Me.Controls.Add(Me.ucrSelectorPlot)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCompareTreatmentLines"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compare Two Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSavePlot As ucrSave
    Friend WithEvents ucrSelectorPlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblMeasurement As Label
    Friend WithEvents ucrReceiverMeasurement As ucrReceiverSingle
    Friend WithEvents ucrReceiverOption As ucrReceiverSingle
    Friend WithEvents lblOption As Label
    Friend WithEvents ucrReceiverID As ucrReceiverSingle
    Friend WithEvents lblID As Label
    Friend WithEvents lblTreatment2 As Label
    Friend WithEvents lblOption1 As Label
    Friend WithEvents ucrInputFactorOption2 As ucrInputFactorLevels
    Friend WithEvents ucrInputFactorOption1 As ucrInputFactorLevels
    Friend WithEvents ucrChkColourByDifference As ucrCheck
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrInputContext2 As ucrInputComboBox
    Friend WithEvents ucrReceiverContext2 As ucrReceiverSingle
    Friend WithEvents ucrInputContext1 As ucrInputComboBox
    Friend WithEvents ucrReceiverContext1 As ucrReceiverSingle
    Friend WithEvents lblContext2 As Label
    Friend WithEvents lblContext1 As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblTransparency As Label
    Friend WithEvents ucrNudTransparency As ucrNud
    Friend WithEvents ucrChkIncludeHline As ucrCheck
    Friend WithEvents ucrInputHlineValue As ucrInputTextBox
    Friend WithEvents lblHlineValue As Label
    Friend WithEvents ucrChkBoxplotOnlyComplete As ucrCheck
    Friend WithEvents ucrChkIncludeBoxplot As ucrCheck
    Friend WithEvents lblContext3 As Label
    Friend WithEvents ucrInputContext3 As ucrInputComboBox
    Friend WithEvents ucrReceiverContext3 As ucrReceiverSingle
    Friend WithEvents ucrPnlCompareType As UcrPanel
    Friend WithEvents ucrChkIncludeSmoothLine As ucrCheck
    Friend WithEvents ucrChkIncludeMeanLine As ucrCheck
    Friend WithEvents rdoPoints As RadioButton
    Friend WithEvents rdoLines As RadioButton
End Class
