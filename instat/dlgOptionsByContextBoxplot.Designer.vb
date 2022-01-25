<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOptionsByContextBoxplot
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
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.cmdHLineOptions = New System.Windows.Forms.Button()
        Me.cmdPointOptions = New System.Windows.Forms.Button()
        Me.rdoViolin = New System.Windows.Forms.RadioButton()
        Me.rdoBoxplot = New System.Windows.Forms.RadioButton()
        Me.ucrInputJitter = New instat.ucrInputTextBox()
        Me.lblJitter = New System.Windows.Forms.Label()
        Me.ucrChkVerticalXTickMarkers = New instat.ucrCheck()
        Me.ucrChkHorizontalBoxplot = New instat.ucrCheck()
        Me.ucrChkVarWidth = New instat.ucrCheck()
        Me.ucrChkIncludePoints = New instat.ucrCheck()
        Me.ucrInputHlineValue = New instat.ucrInputTextBox()
        Me.lblHlineValue = New System.Windows.Forms.Label()
        Me.ucrChkIncludeHline = New instat.ucrCheck()
        Me.lblTransparency = New System.Windows.Forms.Label()
        Me.ucrNudTransparency = New instat.ucrNud()
        Me.ucrPnlPlotType = New instat.UcrPanel()
        Me.grpContexts = New System.Windows.Forms.GroupBox()
        Me.lblContext3 = New System.Windows.Forms.Label()
        Me.ucrInputContext3 = New instat.ucrInputComboBox()
        Me.ucrReceiverContext3 = New instat.ucrReceiverSingle()
        Me.lblContext2 = New System.Windows.Forms.Label()
        Me.lblContext1 = New System.Windows.Forms.Label()
        Me.ucrInputContext2 = New instat.ucrInputComboBox()
        Me.ucrReceiverContext2 = New instat.ucrReceiverSingle()
        Me.ucrInputContext1 = New instat.ucrInputComboBox()
        Me.ucrReceiverContext1 = New instat.ucrReceiverSingle()
        Me.lblXAxis = New System.Windows.Forms.Label()
        Me.lblMeasurement = New System.Windows.Forms.Label()
        Me.cmdBoxPlotOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeasurement = New instat.ucrReceiverSingle()
        Me.ucrSelectorPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpOptions.SuspendLayout()
        Me.grpContexts.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.cmdHLineOptions)
        Me.grpOptions.Controls.Add(Me.cmdPointOptions)
        Me.grpOptions.Controls.Add(Me.rdoViolin)
        Me.grpOptions.Controls.Add(Me.rdoBoxplot)
        Me.grpOptions.Controls.Add(Me.ucrInputJitter)
        Me.grpOptions.Controls.Add(Me.lblJitter)
        Me.grpOptions.Controls.Add(Me.ucrChkVerticalXTickMarkers)
        Me.grpOptions.Controls.Add(Me.ucrChkHorizontalBoxplot)
        Me.grpOptions.Controls.Add(Me.ucrChkVarWidth)
        Me.grpOptions.Controls.Add(Me.ucrChkIncludePoints)
        Me.grpOptions.Controls.Add(Me.ucrInputHlineValue)
        Me.grpOptions.Controls.Add(Me.lblHlineValue)
        Me.grpOptions.Controls.Add(Me.ucrChkIncludeHline)
        Me.grpOptions.Controls.Add(Me.lblTransparency)
        Me.grpOptions.Controls.Add(Me.ucrNudTransparency)
        Me.grpOptions.Controls.Add(Me.ucrPnlPlotType)
        Me.grpOptions.Location = New System.Drawing.Point(12, 284)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(502, 196)
        Me.grpOptions.TabIndex = 10
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'cmdHLineOptions
        '
        Me.cmdHLineOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHLineOptions.Location = New System.Drawing.Point(138, 135)
        Me.cmdHLineOptions.Name = "cmdHLineOptions"
        Me.cmdHLineOptions.Size = New System.Drawing.Size(95, 22)
        Me.cmdHLineOptions.TabIndex = 11
        Me.cmdHLineOptions.Tag = ""
        Me.cmdHLineOptions.Text = "H Line Options"
        Me.cmdHLineOptions.UseVisualStyleBackColor = True
        '
        'cmdPointOptions
        '
        Me.cmdPointOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPointOptions.Location = New System.Drawing.Point(138, 57)
        Me.cmdPointOptions.Name = "cmdPointOptions"
        Me.cmdPointOptions.Size = New System.Drawing.Size(95, 22)
        Me.cmdPointOptions.TabIndex = 5
        Me.cmdPointOptions.Tag = ""
        Me.cmdPointOptions.Text = "Point Options"
        Me.cmdPointOptions.UseVisualStyleBackColor = True
        '
        'rdoViolin
        '
        Me.rdoViolin.AutoSize = True
        Me.rdoViolin.Location = New System.Drawing.Point(89, 22)
        Me.rdoViolin.Name = "rdoViolin"
        Me.rdoViolin.Size = New System.Drawing.Size(50, 17)
        Me.rdoViolin.TabIndex = 2
        Me.rdoViolin.TabStop = True
        Me.rdoViolin.Text = "Violin"
        Me.rdoViolin.UseVisualStyleBackColor = True
        '
        'rdoBoxplot
        '
        Me.rdoBoxplot.AutoSize = True
        Me.rdoBoxplot.Location = New System.Drawing.Point(6, 22)
        Me.rdoBoxplot.Name = "rdoBoxplot"
        Me.rdoBoxplot.Size = New System.Drawing.Size(60, 17)
        Me.rdoBoxplot.TabIndex = 3
        Me.rdoBoxplot.TabStop = True
        Me.rdoBoxplot.Text = "Boxplot"
        Me.rdoBoxplot.UseVisualStyleBackColor = True
        '
        'ucrInputJitter
        '
        Me.ucrInputJitter.AddQuotesIfUnrecognised = True
        Me.ucrInputJitter.AutoSize = True
        Me.ucrInputJitter.IsMultiline = False
        Me.ucrInputJitter.IsReadOnly = False
        Me.ucrInputJitter.Location = New System.Drawing.Point(115, 83)
        Me.ucrInputJitter.Name = "ucrInputJitter"
        Me.ucrInputJitter.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputJitter.TabIndex = 7
        '
        'lblJitter
        '
        Me.lblJitter.AutoSize = True
        Me.lblJitter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblJitter.Location = New System.Drawing.Point(31, 84)
        Me.lblJitter.Name = "lblJitter"
        Me.lblJitter.Size = New System.Drawing.Size(32, 13)
        Me.lblJitter.TabIndex = 6
        Me.lblJitter.Text = "Jitter:"
        '
        'ucrChkVerticalXTickMarkers
        '
        Me.ucrChkVerticalXTickMarkers.AutoSize = True
        Me.ucrChkVerticalXTickMarkers.Checked = False
        Me.ucrChkVerticalXTickMarkers.Location = New System.Drawing.Point(283, 109)
        Me.ucrChkVerticalXTickMarkers.Name = "ucrChkVerticalXTickMarkers"
        Me.ucrChkVerticalXTickMarkers.Size = New System.Drawing.Size(210, 23)
        Me.ucrChkVerticalXTickMarkers.TabIndex = 0
        '
        'ucrChkHorizontalBoxplot
        '
        Me.ucrChkHorizontalBoxplot.AutoSize = True
        Me.ucrChkHorizontalBoxplot.Checked = False
        Me.ucrChkHorizontalBoxplot.Location = New System.Drawing.Point(283, 83)
        Me.ucrChkHorizontalBoxplot.Name = "ucrChkHorizontalBoxplot"
        Me.ucrChkHorizontalBoxplot.Size = New System.Drawing.Size(210, 23)
        Me.ucrChkHorizontalBoxplot.TabIndex = 15
        '
        'ucrChkVarWidth
        '
        Me.ucrChkVarWidth.AutoSize = True
        Me.ucrChkVarWidth.Checked = False
        Me.ucrChkVarWidth.Location = New System.Drawing.Point(283, 57)
        Me.ucrChkVarWidth.Name = "ucrChkVarWidth"
        Me.ucrChkVarWidth.Size = New System.Drawing.Size(210, 23)
        Me.ucrChkVarWidth.TabIndex = 14
        '
        'ucrChkIncludePoints
        '
        Me.ucrChkIncludePoints.AutoSize = True
        Me.ucrChkIncludePoints.Checked = False
        Me.ucrChkIncludePoints.Location = New System.Drawing.Point(6, 57)
        Me.ucrChkIncludePoints.Name = "ucrChkIncludePoints"
        Me.ucrChkIncludePoints.Size = New System.Drawing.Size(178, 23)
        Me.ucrChkIncludePoints.TabIndex = 4
        '
        'ucrInputHlineValue
        '
        Me.ucrInputHlineValue.AddQuotesIfUnrecognised = True
        Me.ucrInputHlineValue.AutoSize = True
        Me.ucrInputHlineValue.IsMultiline = False
        Me.ucrInputHlineValue.IsReadOnly = False
        Me.ucrInputHlineValue.Location = New System.Drawing.Point(76, 165)
        Me.ucrInputHlineValue.Name = "ucrInputHlineValue"
        Me.ucrInputHlineValue.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputHlineValue.TabIndex = 13
        '
        'lblHlineValue
        '
        Me.lblHlineValue.AutoSize = True
        Me.lblHlineValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHlineValue.Location = New System.Drawing.Point(31, 168)
        Me.lblHlineValue.Name = "lblHlineValue"
        Me.lblHlineValue.Size = New System.Drawing.Size(36, 13)
        Me.lblHlineValue.TabIndex = 12
        Me.lblHlineValue.Text = "At Y ="
        '
        'ucrChkIncludeHline
        '
        Me.ucrChkIncludeHline.AutoSize = True
        Me.ucrChkIncludeHline.Checked = False
        Me.ucrChkIncludeHline.Location = New System.Drawing.Point(6, 137)
        Me.ucrChkIncludeHline.Name = "ucrChkIncludeHline"
        Me.ucrChkIncludeHline.Size = New System.Drawing.Size(159, 23)
        Me.ucrChkIncludeHline.TabIndex = 10
        '
        'lblTransparency
        '
        Me.lblTransparency.AutoSize = True
        Me.lblTransparency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTransparency.Location = New System.Drawing.Point(31, 112)
        Me.lblTransparency.Name = "lblTransparency"
        Me.lblTransparency.Size = New System.Drawing.Size(75, 13)
        Me.lblTransparency.TabIndex = 8
        Me.lblTransparency.Text = "Transparency:"
        '
        'ucrNudTransparency
        '
        Me.ucrNudTransparency.AutoSize = True
        Me.ucrNudTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTransparency.Location = New System.Drawing.Point(115, 110)
        Me.ucrNudTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Name = "ucrNudTransparency"
        Me.ucrNudTransparency.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTransparency.TabIndex = 9
        Me.ucrNudTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlPlotType
        '
        Me.ucrPnlPlotType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlPlotType.Location = New System.Drawing.Point(4, 19)
        Me.ucrPnlPlotType.Name = "ucrPnlPlotType"
        Me.ucrPnlPlotType.Size = New System.Drawing.Size(170, 26)
        Me.ucrPnlPlotType.TabIndex = 22
        '
        'grpContexts
        '
        Me.grpContexts.Controls.Add(Me.lblContext3)
        Me.grpContexts.Controls.Add(Me.ucrInputContext3)
        Me.grpContexts.Controls.Add(Me.ucrReceiverContext3)
        Me.grpContexts.Controls.Add(Me.lblContext2)
        Me.grpContexts.Controls.Add(Me.lblContext1)
        Me.grpContexts.Controls.Add(Me.ucrInputContext2)
        Me.grpContexts.Controls.Add(Me.ucrReceiverContext2)
        Me.grpContexts.Controls.Add(Me.ucrInputContext1)
        Me.grpContexts.Controls.Add(Me.ucrReceiverContext1)
        Me.grpContexts.Location = New System.Drawing.Point(266, 116)
        Me.grpContexts.Name = "grpContexts"
        Me.grpContexts.Size = New System.Drawing.Size(248, 159)
        Me.grpContexts.TabIndex = 5
        Me.grpContexts.TabStop = False
        Me.grpContexts.Text = "Include Contexts"
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
        'lblXAxis
        '
        Me.lblXAxis.AutoSize = True
        Me.lblXAxis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXAxis.Location = New System.Drawing.Point(270, 67)
        Me.lblXAxis.Name = "lblXAxis"
        Me.lblXAxis.Size = New System.Drawing.Size(38, 13)
        Me.lblXAxis.TabIndex = 3
        Me.lblXAxis.Text = "X axis:"
        '
        'lblMeasurement
        '
        Me.lblMeasurement.AutoSize = True
        Me.lblMeasurement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMeasurement.Location = New System.Drawing.Point(270, 26)
        Me.lblMeasurement.Name = "lblMeasurement"
        Me.lblMeasurement.Size = New System.Drawing.Size(105, 13)
        Me.lblMeasurement.TabIndex = 1
        Me.lblMeasurement.Text = "Measurement Y axis:"
        '
        'cmdBoxPlotOptions
        '
        Me.cmdBoxPlotOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBoxPlotOptions.Location = New System.Drawing.Point(10, 208)
        Me.cmdBoxPlotOptions.Name = "cmdBoxPlotOptions"
        Me.cmdBoxPlotOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdBoxPlotOptions.TabIndex = 6
        Me.cmdBoxPlotOptions.Tag = "Boxplot_Options"
        Me.cmdBoxPlotOptions.Text = "Boxplot Options"
        Me.cmdBoxPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(10, 239)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 7
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrSavePlot
        '
        Me.ucrSavePlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSavePlot.Location = New System.Drawing.Point(10, 497)
        Me.ucrSavePlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSavePlot.Name = "ucrSavePlot"
        Me.ucrSavePlot.Size = New System.Drawing.Size(255, 24)
        Me.ucrSavePlot.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 526)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 1
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(270, 82)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 4
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrReceiverMeasurement
        '
        Me.ucrReceiverMeasurement.AutoSize = True
        Me.ucrReceiverMeasurement.frmParent = Me
        Me.ucrReceiverMeasurement.Location = New System.Drawing.Point(270, 41)
        Me.ucrReceiverMeasurement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeasurement.Name = "ucrReceiverMeasurement"
        Me.ucrReceiverMeasurement.Selector = Nothing
        Me.ucrReceiverMeasurement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMeasurement.strNcFilePath = ""
        Me.ucrReceiverMeasurement.TabIndex = 2
        Me.ucrReceiverMeasurement.ucrSelector = Nothing
        '
        'ucrSelectorPlot
        '
        Me.ucrSelectorPlot.AutoSize = True
        Me.ucrSelectorPlot.bDropUnusedFilterLevels = False
        Me.ucrSelectorPlot.bShowHiddenColumns = False
        Me.ucrSelectorPlot.bUseCurrentFilter = True
        Me.ucrSelectorPlot.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorPlot.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPlot.Name = "ucrSelectorPlot"
        Me.ucrSelectorPlot.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorPlot.TabIndex = 0
        '
        'dlgOptionsByContextBoxplot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(543, 582)
        Me.Controls.Add(Me.cmdBoxPlotOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpContexts)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblXAxis)
        Me.Controls.Add(Me.ucrReceiverMeasurement)
        Me.Controls.Add(Me.lblMeasurement)
        Me.Controls.Add(Me.ucrSelectorPlot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOptionsByContextBoxplot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options by Context Boxplot"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpContexts.ResumeLayout(False)
        Me.grpContexts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrChkIncludePoints As ucrCheck
    Friend WithEvents ucrInputHlineValue As ucrInputTextBox
    Friend WithEvents lblHlineValue As Label
    Friend WithEvents ucrChkIncludeHline As ucrCheck
    Friend WithEvents lblTransparency As Label
    Friend WithEvents ucrNudTransparency As ucrNud
    Friend WithEvents grpContexts As GroupBox
    Friend WithEvents lblContext3 As Label
    Friend WithEvents ucrInputContext3 As ucrInputComboBox
    Friend WithEvents ucrReceiverContext3 As ucrReceiverSingle
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXAxis As Label
    Friend WithEvents ucrReceiverMeasurement As ucrReceiverSingle
    Friend WithEvents lblMeasurement As Label
    Friend WithEvents ucrSelectorPlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblContext2 As Label
    Friend WithEvents lblContext1 As Label
    Friend WithEvents ucrInputContext2 As ucrInputComboBox
    Friend WithEvents ucrReceiverContext2 As ucrReceiverSingle
    Friend WithEvents ucrInputContext1 As ucrInputComboBox
    Friend WithEvents ucrReceiverContext1 As ucrReceiverSingle
    Friend WithEvents ucrSavePlot As ucrSave
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdBoxPlotOptions As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrChkVerticalXTickMarkers As ucrCheck
    Friend WithEvents ucrChkHorizontalBoxplot As ucrCheck
    Friend WithEvents ucrChkVarWidth As ucrCheck
    Friend WithEvents ucrInputJitter As ucrInputTextBox
    Friend WithEvents lblJitter As Label
    Friend WithEvents rdoViolin As RadioButton
    Friend WithEvents rdoBoxplot As RadioButton
    Friend WithEvents ucrPnlPlotType As UcrPanel
    Friend WithEvents cmdHLineOptions As Button
    Friend WithEvents cmdPointOptions As Button
End Class
