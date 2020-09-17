<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSeasonalPlot
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorSeasonalityComparisons = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverReference = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverSeasonality = New instat.ucrReceiverSingle()
        Me.ucrReceiverEstimate = New instat.ucrReceiverSingle()
        Me.ucrChkRemoveMissing = New instat.ucrCheck()
        Me.grpValues = New System.Windows.Forms.GroupBox()
        Me.ucrInputN = New instat.ucrInputTextBox()
        Me.lblN = New System.Windows.Forms.Label()
        Me.ucrChkPoints = New instat.ucrCheck()
        Me.ucrChkMovingAverage = New instat.ucrCheck()
        Me.grpSmoothing = New System.Windows.Forms.GroupBox()
        Me.ucrNudSpan = New instat.ucrNud()
        Me.lblSpan = New System.Windows.Forms.Label()
        Me.lblDf = New System.Windows.Forms.Label()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.ucrNudDf = New instat.ucrNud()
        Me.lblHarmonics = New System.Windows.Forms.Label()
        Me.ucrNudPeriod = New instat.ucrNud()
        Me.ucrNudHarmonics = New instat.ucrNud()
        Me.ucrInputSmoothing = New instat.ucrInputComboBox()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrInputEstimateSummary = New instat.ucrInputComboBox()
        Me.ucrInputReferenceSummary = New instat.ucrInputComboBox()
        Me.ucrInputReferenceThreshold = New instat.ucrInputTextBox()
        Me.ucrInputEstimateThreshold = New instat.ucrInputTextBox()
        Me.lblRefSummary = New System.Windows.Forms.Label()
        Me.lblEstSummary = New System.Windows.Forms.Label()
        Me.lblSeasonality = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblReference = New System.Windows.Forms.Label()
        Me.lblEstimate = New System.Windows.Forms.Label()
        Me.grpValues.SuspendLayout()
        Me.grpSmoothing.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 429)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 19
        '
        'ucrSelectorSeasonalityComparisons
        '
        Me.ucrSelectorSeasonalityComparisons.bDropUnusedFilterLevels = False
        Me.ucrSelectorSeasonalityComparisons.bShowHiddenColumns = False
        Me.ucrSelectorSeasonalityComparisons.bUseCurrentFilter = True
        Me.ucrSelectorSeasonalityComparisons.Location = New System.Drawing.Point(12, 28)
        Me.ucrSelectorSeasonalityComparisons.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSeasonalityComparisons.Name = "ucrSelectorSeasonalityComparisons"
        Me.ucrSelectorSeasonalityComparisons.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorSeasonalityComparisons.TabIndex = 0
        '
        'ucrReceiverReference
        '
        Me.ucrReceiverReference.frmParent = Me
        Me.ucrReceiverReference.Location = New System.Drawing.Point(266, 36)
        Me.ucrReceiverReference.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverReference.Name = "ucrReceiverReference"
        Me.ucrReceiverReference.Selector = Nothing
        Me.ucrReceiverReference.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverReference.strNcFilePath = ""
        Me.ucrReceiverReference.TabIndex = 2
        Me.ucrReceiverReference.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(266, 268)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 14
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverSeasonality
        '
        Me.ucrReceiverSeasonality.frmParent = Me
        Me.ucrReceiverSeasonality.Location = New System.Drawing.Point(266, 222)
        Me.ucrReceiverSeasonality.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSeasonality.Name = "ucrReceiverSeasonality"
        Me.ucrReceiverSeasonality.Selector = Nothing
        Me.ucrReceiverSeasonality.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverSeasonality.strNcFilePath = ""
        Me.ucrReceiverSeasonality.TabIndex = 12
        Me.ucrReceiverSeasonality.ucrSelector = Nothing
        '
        'ucrReceiverEstimate
        '
        Me.ucrReceiverEstimate.frmParent = Me
        Me.ucrReceiverEstimate.Location = New System.Drawing.Point(266, 129)
        Me.ucrReceiverEstimate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEstimate.Name = "ucrReceiverEstimate"
        Me.ucrReceiverEstimate.Selector = Nothing
        Me.ucrReceiverEstimate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverEstimate.strNcFilePath = ""
        Me.ucrReceiverEstimate.TabIndex = 7
        Me.ucrReceiverEstimate.ucrSelector = Nothing
        '
        'ucrChkRemoveMissing
        '
        Me.ucrChkRemoveMissing.Checked = False
        Me.ucrChkRemoveMissing.Location = New System.Drawing.Point(22, 219)
        Me.ucrChkRemoveMissing.Name = "ucrChkRemoveMissing"
        Me.ucrChkRemoveMissing.Size = New System.Drawing.Size(197, 20)
        Me.ucrChkRemoveMissing.TabIndex = 15
        '
        'grpValues
        '
        Me.grpValues.Controls.Add(Me.ucrInputN)
        Me.grpValues.Controls.Add(Me.lblN)
        Me.grpValues.Controls.Add(Me.ucrChkPoints)
        Me.grpValues.Controls.Add(Me.ucrChkMovingAverage)
        Me.grpValues.Location = New System.Drawing.Point(12, 242)
        Me.grpValues.Name = "grpValues"
        Me.grpValues.Size = New System.Drawing.Size(232, 71)
        Me.grpValues.TabIndex = 16
        Me.grpValues.TabStop = False
        Me.grpValues.Text = "Values"
        '
        'ucrInputN
        '
        Me.ucrInputN.AddQuotesIfUnrecognised = True
        Me.ucrInputN.IsMultiline = False
        Me.ucrInputN.IsReadOnly = False
        Me.ucrInputN.Location = New System.Drawing.Point(167, 41)
        Me.ucrInputN.Name = "ucrInputN"
        Me.ucrInputN.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputN.TabIndex = 23
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(148, 45)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(16, 13)
        Me.lblN.TabIndex = 21
        Me.lblN.Text = "n:"
        '
        'ucrChkPoints
        '
        Me.ucrChkPoints.Checked = False
        Me.ucrChkPoints.Location = New System.Drawing.Point(8, 15)
        Me.ucrChkPoints.Name = "ucrChkPoints"
        Me.ucrChkPoints.Size = New System.Drawing.Size(155, 20)
        Me.ucrChkPoints.TabIndex = 8
        '
        'ucrChkMovingAverage
        '
        Me.ucrChkMovingAverage.Checked = False
        Me.ucrChkMovingAverage.Location = New System.Drawing.Point(8, 41)
        Me.ucrChkMovingAverage.Name = "ucrChkMovingAverage"
        Me.ucrChkMovingAverage.Size = New System.Drawing.Size(134, 20)
        Me.ucrChkMovingAverage.TabIndex = 7
        '
        'grpSmoothing
        '
        Me.grpSmoothing.Controls.Add(Me.ucrNudSpan)
        Me.grpSmoothing.Controls.Add(Me.lblSpan)
        Me.grpSmoothing.Controls.Add(Me.lblDf)
        Me.grpSmoothing.Controls.Add(Me.lblPeriod)
        Me.grpSmoothing.Controls.Add(Me.ucrNudDf)
        Me.grpSmoothing.Controls.Add(Me.lblHarmonics)
        Me.grpSmoothing.Controls.Add(Me.ucrNudPeriod)
        Me.grpSmoothing.Controls.Add(Me.ucrNudHarmonics)
        Me.grpSmoothing.Controls.Add(Me.ucrInputSmoothing)
        Me.grpSmoothing.Location = New System.Drawing.Point(12, 317)
        Me.grpSmoothing.Name = "grpSmoothing"
        Me.grpSmoothing.Size = New System.Drawing.Size(243, 75)
        Me.grpSmoothing.TabIndex = 17
        Me.grpSmoothing.TabStop = False
        Me.grpSmoothing.Text = "Smoothing"
        '
        'ucrNudSpan
        '
        Me.ucrNudSpan.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSpan.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSpan.Location = New System.Drawing.Point(53, 45)
        Me.ucrNudSpan.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSpan.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSpan.Name = "ucrNudSpan"
        Me.ucrNudSpan.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSpan.TabIndex = 20
        Me.ucrNudSpan.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSpan
        '
        Me.lblSpan.AutoSize = True
        Me.lblSpan.Location = New System.Drawing.Point(15, 49)
        Me.lblSpan.Name = "lblSpan"
        Me.lblSpan.Size = New System.Drawing.Size(35, 13)
        Me.lblSpan.TabIndex = 23
        Me.lblSpan.Text = "Span:"
        '
        'lblDf
        '
        Me.lblDf.AutoSize = True
        Me.lblDf.Location = New System.Drawing.Point(12, 49)
        Me.lblDf.Name = "lblDf"
        Me.lblDf.Size = New System.Drawing.Size(103, 13)
        Me.lblDf.TabIndex = 24
        Me.lblDf.Text = "Degrees of freedom:"
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(128, 49)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(45, 13)
        Me.lblPeriod.TabIndex = 18
        Me.lblPeriod.Text = "Periods:"
        '
        'ucrNudDf
        '
        Me.ucrNudDf.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDf.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDf.Location = New System.Drawing.Point(117, 46)
        Me.ucrNudDf.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDf.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDf.Name = "ucrNudDf"
        Me.ucrNudDf.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDf.TabIndex = 21
        Me.ucrNudDf.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblHarmonics
        '
        Me.lblHarmonics.AutoSize = True
        Me.lblHarmonics.Location = New System.Drawing.Point(12, 49)
        Me.lblHarmonics.Name = "lblHarmonics"
        Me.lblHarmonics.Size = New System.Drawing.Size(60, 13)
        Me.lblHarmonics.TabIndex = 19
        Me.lblHarmonics.Text = "Harmonics:"
        '
        'ucrNudPeriod
        '
        Me.ucrNudPeriod.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPeriod.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPeriod.Location = New System.Drawing.Point(176, 45)
        Me.ucrNudPeriod.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPeriod.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPeriod.Name = "ucrNudPeriod"
        Me.ucrNudPeriod.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPeriod.TabIndex = 2
        Me.ucrNudPeriod.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudHarmonics
        '
        Me.ucrNudHarmonics.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHarmonics.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHarmonics.Location = New System.Drawing.Point(74, 46)
        Me.ucrNudHarmonics.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHarmonics.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHarmonics.Name = "ucrNudHarmonics"
        Me.ucrNudHarmonics.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudHarmonics.TabIndex = 1
        Me.ucrNudHarmonics.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSmoothing
        '
        Me.ucrInputSmoothing.AddQuotesIfUnrecognised = True
        Me.ucrInputSmoothing.GetSetSelectedIndex = -1
        Me.ucrInputSmoothing.IsReadOnly = False
        Me.ucrInputSmoothing.Location = New System.Drawing.Point(10, 20)
        Me.ucrInputSmoothing.Name = "ucrInputSmoothing"
        Me.ucrInputSmoothing.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputSmoothing.TabIndex = 0
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(12, 400)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(255, 29)
        Me.ucrSaveGraph.TabIndex = 18
        '
        'ucrInputEstimateSummary
        '
        Me.ucrInputEstimateSummary.AddQuotesIfUnrecognised = True
        Me.ucrInputEstimateSummary.GetSetSelectedIndex = -1
        Me.ucrInputEstimateSummary.IsReadOnly = False
        Me.ucrInputEstimateSummary.Location = New System.Drawing.Point(266, 175)
        Me.ucrInputEstimateSummary.Name = "ucrInputEstimateSummary"
        Me.ucrInputEstimateSummary.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputEstimateSummary.TabIndex = 9
        '
        'ucrInputReferenceSummary
        '
        Me.ucrInputReferenceSummary.AddQuotesIfUnrecognised = True
        Me.ucrInputReferenceSummary.GetSetSelectedIndex = -1
        Me.ucrInputReferenceSummary.IsReadOnly = False
        Me.ucrInputReferenceSummary.Location = New System.Drawing.Point(266, 82)
        Me.ucrInputReferenceSummary.Name = "ucrInputReferenceSummary"
        Me.ucrInputReferenceSummary.Size = New System.Drawing.Size(89, 21)
        Me.ucrInputReferenceSummary.TabIndex = 4
        '
        'ucrInputReferenceThreshold
        '
        Me.ucrInputReferenceThreshold.AddQuotesIfUnrecognised = True
        Me.ucrInputReferenceThreshold.IsMultiline = False
        Me.ucrInputReferenceThreshold.IsReadOnly = False
        Me.ucrInputReferenceThreshold.Location = New System.Drawing.Point(356, 82)
        Me.ucrInputReferenceThreshold.Name = "ucrInputReferenceThreshold"
        Me.ucrInputReferenceThreshold.Size = New System.Drawing.Size(53, 21)
        Me.ucrInputReferenceThreshold.TabIndex = 5
        '
        'ucrInputEstimateThreshold
        '
        Me.ucrInputEstimateThreshold.AddQuotesIfUnrecognised = True
        Me.ucrInputEstimateThreshold.IsMultiline = False
        Me.ucrInputEstimateThreshold.IsReadOnly = False
        Me.ucrInputEstimateThreshold.Location = New System.Drawing.Point(361, 175)
        Me.ucrInputEstimateThreshold.Name = "ucrInputEstimateThreshold"
        Me.ucrInputEstimateThreshold.Size = New System.Drawing.Size(48, 21)
        Me.ucrInputEstimateThreshold.TabIndex = 10
        '
        'lblRefSummary
        '
        Me.lblRefSummary.AutoSize = True
        Me.lblRefSummary.Location = New System.Drawing.Point(266, 66)
        Me.lblRefSummary.Name = "lblRefSummary"
        Me.lblRefSummary.Size = New System.Drawing.Size(53, 13)
        Me.lblRefSummary.TabIndex = 3
        Me.lblRefSummary.Text = "Summary:"
        '
        'lblEstSummary
        '
        Me.lblEstSummary.AutoSize = True
        Me.lblEstSummary.Location = New System.Drawing.Point(266, 159)
        Me.lblEstSummary.Name = "lblEstSummary"
        Me.lblEstSummary.Size = New System.Drawing.Size(53, 13)
        Me.lblEstSummary.TabIndex = 8
        Me.lblEstSummary.Text = "Summary:"
        '
        'lblSeasonality
        '
        Me.lblSeasonality.AutoSize = True
        Me.lblSeasonality.Location = New System.Drawing.Point(266, 206)
        Me.lblSeasonality.Name = "lblSeasonality"
        Me.lblSeasonality.Size = New System.Drawing.Size(64, 13)
        Me.lblSeasonality.TabIndex = 11
        Me.lblSeasonality.Text = "Seasonality:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(266, 252)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 13
        Me.lblStation.Text = "Station:"
        '
        'lblReference
        '
        Me.lblReference.AutoSize = True
        Me.lblReference.Location = New System.Drawing.Point(266, 20)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(60, 13)
        Me.lblReference.TabIndex = 1
        Me.lblReference.Text = "Reference:"
        '
        'lblEstimate
        '
        Me.lblEstimate.AutoSize = True
        Me.lblEstimate.Location = New System.Drawing.Point(266, 113)
        Me.lblEstimate.Name = "lblEstimate"
        Me.lblEstimate.Size = New System.Drawing.Size(50, 13)
        Me.lblEstimate.TabIndex = 6
        Me.lblEstimate.Text = "Estimate:"
        '
        'dlgSeasonalPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 491)
        Me.Controls.Add(Me.lblEstimate)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.lblSeasonality)
        Me.Controls.Add(Me.lblEstSummary)
        Me.Controls.Add(Me.lblRefSummary)
        Me.Controls.Add(Me.ucrInputEstimateThreshold)
        Me.Controls.Add(Me.ucrInputReferenceThreshold)
        Me.Controls.Add(Me.ucrInputReferenceSummary)
        Me.Controls.Add(Me.ucrInputEstimateSummary)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.grpSmoothing)
        Me.Controls.Add(Me.grpValues)
        Me.Controls.Add(Me.ucrChkRemoveMissing)
        Me.Controls.Add(Me.ucrReceiverEstimate)
        Me.Controls.Add(Me.ucrReceiverSeasonality)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverReference)
        Me.Controls.Add(Me.ucrSelectorSeasonalityComparisons)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSeasonalPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seasonal Comparisons"
        Me.grpValues.ResumeLayout(False)
        Me.grpValues.PerformLayout()
        Me.grpSmoothing.ResumeLayout(False)
        Me.grpSmoothing.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorSeasonalityComparisons As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverReference As ucrReceiverSingle
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents grpSmoothing As GroupBox
    Friend WithEvents grpValues As GroupBox
    Friend WithEvents ucrChkPoints As ucrCheck
    Friend WithEvents ucrChkMovingAverage As ucrCheck
    Friend WithEvents ucrChkRemoveMissing As ucrCheck
    Friend WithEvents ucrReceiverEstimate As ucrReceiverSingle
    Friend WithEvents ucrReceiverSeasonality As ucrReceiverSingle
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrNudPeriod As ucrNud
    Friend WithEvents ucrNudHarmonics As ucrNud
    Friend WithEvents ucrInputSmoothing As ucrInputComboBox
    Friend WithEvents ucrInputEstimateThreshold As ucrInputTextBox
    Friend WithEvents ucrInputReferenceThreshold As ucrInputTextBox
    Friend WithEvents ucrInputReferenceSummary As ucrInputComboBox
    Friend WithEvents ucrInputEstimateSummary As ucrInputComboBox
    Friend WithEvents lblEstimate As Label
    Friend WithEvents lblReference As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents lblSeasonality As Label
    Friend WithEvents lblEstSummary As Label
    Friend WithEvents lblRefSummary As Label
    Friend WithEvents lblPeriod As Label
    Friend WithEvents lblHarmonics As Label
    Friend WithEvents ucrInputN As ucrInputTextBox
    Friend WithEvents lblN As Label
    Friend WithEvents ucrNudSpan As ucrNud
    Friend WithEvents ucrNudDf As ucrNud
    Friend WithEvents lblDf As Label
    Friend WithEvents lblSpan As Label
End Class
