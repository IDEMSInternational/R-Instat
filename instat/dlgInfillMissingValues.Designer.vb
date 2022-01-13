<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgInfillMissingValues
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
        Me.rdoNaStructTS = New System.Windows.Forms.RadioButton()
        Me.rdoNaLocf = New System.Windows.Forms.RadioButton()
        Me.rdoNaSpline = New System.Windows.Forms.RadioButton()
        Me.rdoNaFill = New System.Windows.Forms.RadioButton()
        Me.rdoNaAggregate = New System.Windows.Forms.RadioButton()
        Me.rdoNaApproximate = New System.Windows.Forms.RadioButton()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.rdoFitSingle = New System.Windows.Forms.RadioButton()
        Me.rdoFitMultiple = New System.Windows.Forms.RadioButton()
        Me.grpMethods = New System.Windows.Forms.GroupBox()
        Me.ucrPnlMethods = New instat.UcrPanel()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.grpStartEnd = New System.Windows.Forms.GroupBox()
        Me.rdoExtendFill = New System.Windows.Forms.RadioButton()
        Me.rdoLeaveAsMissing = New System.Windows.Forms.RadioButton()
        Me.ucrPnlStartEnd = New instat.UcrPanel()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.lblFunction = New System.Windows.Forms.Label()
        Me.lblRows = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblEstimated = New System.Windows.Forms.Label()
        Me.lblObserved = New System.Windows.Forms.Label()
        Me.rdoDisplay = New System.Windows.Forms.RadioButton()
        Me.rdoShow = New System.Windows.Forms.RadioButton()
        Me.lblFacetColumns = New System.Windows.Forms.Label()
        Me.lblImputed = New System.Windows.Forms.Label()
        Me.lblDisplayElement = New System.Windows.Forms.Label()
        Me.lblDisplayDate = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblIntervalSize = New System.Windows.Forms.Label()
        Me.lblDispMultShowStation = New System.Windows.Forms.Label()
        Me.lblTrueValues = New System.Windows.Forms.Label()
        Me.lblPercentCount = New System.Windows.Forms.Label()
        Me.ucrInputTimeInterval = New instat.ucrInputComboBox()
        Me.ucrNudTimeInterval = New instat.ucrNud()
        Me.ucrChkTimeInterval = New instat.ucrCheck()
        Me.ucrInputComboMeasure = New instat.ucrInputComboBox()
        Me.ucrReceiverTrueValues = New instat.ucrReceiverSingle()
        Me.ucrReceiverDispMultShowStation = New instat.ucrReceiverSingle()
        Me.ucrInputIntervalSize = New instat.ucrInputTextBox()
        Me.ucrChkFlipCordinates = New instat.ucrCheck()
        Me.ucrInputComboType = New instat.ucrInputComboBox()
        Me.ucrChkAddLegend = New instat.ucrCheck()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrNudFacetColumns = New instat.ucrNud()
        Me.ucrReceiverImputed = New instat.ucrReceiverSingle()
        Me.ucrReceiverDisplayObserved = New instat.ucrReceiverSingle()
        Me.ucrReceiverDisplayShowDate = New instat.ucrReceiverSingle()
        Me.ucrInputStdBias = New instat.ucrInputTextBox()
        Me.ucrInputMeanBias = New instat.ucrInputTextBox()
        Me.ucrChkStdBias = New instat.ucrCheck()
        Me.ucrChkMeanBias = New instat.ucrCheck()
        Me.ucrReceiverObserved = New instat.ucrReceiverSingle()
        Me.ucrReceiverEstimatedElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrInputConstant = New instat.ucrInputTextBox()
        Me.ucrReceiverByFactor = New instat.ucrReceiverMultiple()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrChkSetSeed = New instat.ucrCheck()
        Me.ucrNudSetSeed = New instat.ucrNud()
        Me.ucrNudMaximum = New instat.ucrNud()
        Me.ucrChkMaxGap = New instat.ucrCheck()
        Me.ucrChkBy = New instat.ucrCheck()
        Me.ucrChkCopyFromBelow = New instat.ucrCheck()
        Me.ucrSaveNewColumn = New instat.ucrSave()
        Me.ucrInputComboFunction = New instat.ucrInputComboBox()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorInfillMissing = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrInputNewColumnName = New instat.ucrInputTextBox()
        Me.grpMethods.SuspendLayout()
        Me.grpStartEnd.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoNaStructTS
        '
        Me.rdoNaStructTS.AutoSize = True
        Me.rdoNaStructTS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNaStructTS.Location = New System.Drawing.Point(103, 65)
        Me.rdoNaStructTS.Name = "rdoNaStructTS"
        Me.rdoNaStructTS.Size = New System.Drawing.Size(67, 17)
        Me.rdoNaStructTS.TabIndex = 6
        Me.rdoNaStructTS.TabStop = True
        Me.rdoNaStructTS.Text = "StructTS"
        Me.rdoNaStructTS.UseVisualStyleBackColor = True
        '
        'rdoNaLocf
        '
        Me.rdoNaLocf.AutoSize = True
        Me.rdoNaLocf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNaLocf.Location = New System.Drawing.Point(103, 42)
        Me.rdoNaLocf.Name = "rdoNaLocf"
        Me.rdoNaLocf.Size = New System.Drawing.Size(49, 17)
        Me.rdoNaLocf.TabIndex = 7
        Me.rdoNaLocf.TabStop = True
        Me.rdoNaLocf.Text = "Copy"
        Me.rdoNaLocf.UseVisualStyleBackColor = True
        '
        'rdoNaSpline
        '
        Me.rdoNaSpline.AutoSize = True
        Me.rdoNaSpline.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNaSpline.Location = New System.Drawing.Point(103, 19)
        Me.rdoNaSpline.Name = "rdoNaSpline"
        Me.rdoNaSpline.Size = New System.Drawing.Size(54, 17)
        Me.rdoNaSpline.TabIndex = 8
        Me.rdoNaSpline.TabStop = True
        Me.rdoNaSpline.Text = "Spline"
        Me.rdoNaSpline.UseVisualStyleBackColor = True
        '
        'rdoNaFill
        '
        Me.rdoNaFill.AutoSize = True
        Me.rdoNaFill.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNaFill.Location = New System.Drawing.Point(9, 65)
        Me.rdoNaFill.Name = "rdoNaFill"
        Me.rdoNaFill.Size = New System.Drawing.Size(67, 17)
        Me.rdoNaFill.TabIndex = 9
        Me.rdoNaFill.TabStop = True
        Me.rdoNaFill.Text = "Constant"
        Me.rdoNaFill.UseVisualStyleBackColor = True
        '
        'rdoNaAggregate
        '
        Me.rdoNaAggregate.AutoSize = True
        Me.rdoNaAggregate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNaAggregate.Location = New System.Drawing.Point(9, 42)
        Me.rdoNaAggregate.Name = "rdoNaAggregate"
        Me.rdoNaAggregate.Size = New System.Drawing.Size(59, 17)
        Me.rdoNaAggregate.TabIndex = 10
        Me.rdoNaAggregate.TabStop = True
        Me.rdoNaAggregate.Text = "Typical"
        Me.rdoNaAggregate.UseVisualStyleBackColor = True
        '
        'rdoNaApproximate
        '
        Me.rdoNaApproximate.AutoSize = True
        Me.rdoNaApproximate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNaApproximate.Location = New System.Drawing.Point(9, 19)
        Me.rdoNaApproximate.Name = "rdoNaApproximate"
        Me.rdoNaApproximate.Size = New System.Drawing.Size(75, 17)
        Me.rdoNaApproximate.TabIndex = 11
        Me.rdoNaApproximate.TabStop = True
        Me.rdoNaApproximate.Text = "Interpolate"
        Me.rdoNaApproximate.UseVisualStyleBackColor = True
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement.Location = New System.Drawing.Point(281, 110)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 7
        Me.lblElement.Text = "Element:"
        '
        'rdoFitSingle
        '
        Me.rdoFitSingle.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFitSingle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFitSingle.FlatAppearance.BorderSize = 2
        Me.rdoFitSingle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFitSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFitSingle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFitSingle.Location = New System.Drawing.Point(122, 7)
        Me.rdoFitSingle.Name = "rdoFitSingle"
        Me.rdoFitSingle.Size = New System.Drawing.Size(107, 27)
        Me.rdoFitSingle.TabIndex = 1
        Me.rdoFitSingle.TabStop = True
        Me.rdoFitSingle.Text = "Fit Single"
        Me.rdoFitSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFitSingle.UseVisualStyleBackColor = True
        '
        'rdoFitMultiple
        '
        Me.rdoFitMultiple.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFitMultiple.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFitMultiple.FlatAppearance.BorderSize = 2
        Me.rdoFitMultiple.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFitMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFitMultiple.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFitMultiple.Location = New System.Drawing.Point(227, 7)
        Me.rdoFitMultiple.Name = "rdoFitMultiple"
        Me.rdoFitMultiple.Size = New System.Drawing.Size(107, 27)
        Me.rdoFitMultiple.TabIndex = 2
        Me.rdoFitMultiple.TabStop = True
        Me.rdoFitMultiple.Text = "Ajuster a multiple"
        Me.rdoFitMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFitMultiple.UseVisualStyleBackColor = True
        '
        'grpMethods
        '
        Me.grpMethods.Controls.Add(Me.rdoNaStructTS)
        Me.grpMethods.Controls.Add(Me.rdoNaLocf)
        Me.grpMethods.Controls.Add(Me.rdoNaSpline)
        Me.grpMethods.Controls.Add(Me.rdoNaApproximate)
        Me.grpMethods.Controls.Add(Me.rdoNaFill)
        Me.grpMethods.Controls.Add(Me.rdoNaAggregate)
        Me.grpMethods.Controls.Add(Me.ucrPnlMethods)
        Me.grpMethods.Location = New System.Drawing.Point(12, 295)
        Me.grpMethods.Name = "grpMethods"
        Me.grpMethods.Size = New System.Drawing.Size(210, 99)
        Me.grpMethods.TabIndex = 21
        Me.grpMethods.TabStop = False
        Me.grpMethods.Text = "Methods"
        '
        'ucrPnlMethods
        '
        Me.ucrPnlMethods.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMethods.Location = New System.Drawing.Point(6, 15)
        Me.ucrPnlMethods.Name = "ucrPnlMethods"
        Me.ucrPnlMethods.Size = New System.Drawing.Size(177, 71)
        Me.ucrPnlMethods.TabIndex = 17
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNewColumnName.Location = New System.Drawing.Point(13, 329)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColumnName.TabIndex = 72
        Me.lblNewColumnName.Text = "New Column Name:"
        '
        'grpStartEnd
        '
        Me.grpStartEnd.Controls.Add(Me.rdoExtendFill)
        Me.grpStartEnd.Controls.Add(Me.rdoLeaveAsMissing)
        Me.grpStartEnd.Controls.Add(Me.ucrPnlStartEnd)
        Me.grpStartEnd.Location = New System.Drawing.Point(228, 295)
        Me.grpStartEnd.Name = "grpStartEnd"
        Me.grpStartEnd.Size = New System.Drawing.Size(183, 66)
        Me.grpStartEnd.TabIndex = 22
        Me.grpStartEnd.TabStop = False
        Me.grpStartEnd.Text = "Start and End"
        '
        'rdoExtendFill
        '
        Me.rdoExtendFill.AutoSize = True
        Me.rdoExtendFill.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoExtendFill.Location = New System.Drawing.Point(11, 39)
        Me.rdoExtendFill.Name = "rdoExtendFill"
        Me.rdoExtendFill.Size = New System.Drawing.Size(73, 17)
        Me.rdoExtendFill.TabIndex = 13
        Me.rdoExtendFill.TabStop = True
        Me.rdoExtendFill.Text = "Extend Fill"
        Me.rdoExtendFill.UseVisualStyleBackColor = True
        '
        'rdoLeaveAsMissing
        '
        Me.rdoLeaveAsMissing.AutoSize = True
        Me.rdoLeaveAsMissing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLeaveAsMissing.Location = New System.Drawing.Point(11, 16)
        Me.rdoLeaveAsMissing.Name = "rdoLeaveAsMissing"
        Me.rdoLeaveAsMissing.Size = New System.Drawing.Size(107, 17)
        Me.rdoLeaveAsMissing.TabIndex = 12
        Me.rdoLeaveAsMissing.TabStop = True
        Me.rdoLeaveAsMissing.Text = "Leave as Missing"
        Me.rdoLeaveAsMissing.UseVisualStyleBackColor = True
        '
        'ucrPnlStartEnd
        '
        Me.ucrPnlStartEnd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlStartEnd.Location = New System.Drawing.Point(6, 15)
        Me.ucrPnlStartEnd.Name = "ucrPnlStartEnd"
        Me.ucrPnlStartEnd.Size = New System.Drawing.Size(118, 44)
        Me.ucrPnlStartEnd.TabIndex = 18
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValue.Location = New System.Drawing.Point(236, 365)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(37, 13)
        Me.lblValue.TabIndex = 23
        Me.lblValue.Text = "Value:"
        '
        'lblFunction
        '
        Me.lblFunction.AutoSize = True
        Me.lblFunction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFunction.Location = New System.Drawing.Point(12, 408)
        Me.lblFunction.Name = "lblFunction"
        Me.lblFunction.Size = New System.Drawing.Size(51, 13)
        Me.lblFunction.TabIndex = 20
        Me.lblFunction.Text = "Function:"
        '
        'lblRows
        '
        Me.lblRows.AutoSize = True
        Me.lblRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRows.Location = New System.Drawing.Point(159, 261)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(35, 13)
        Me.lblRows.TabIndex = 18
        Me.lblRows.Text = "row(s)"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(281, 60)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 5
        Me.lblStation.Text = "Station:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(281, 103)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Date:"
        '
        'lblEstimated
        '
        Me.lblEstimated.AutoSize = True
        Me.lblEstimated.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEstimated.Location = New System.Drawing.Point(281, 188)
        Me.lblEstimated.Name = "lblEstimated"
        Me.lblEstimated.Size = New System.Drawing.Size(56, 13)
        Me.lblEstimated.TabIndex = 11
        Me.lblEstimated.Text = "Estimated:"
        '
        'lblObserved
        '
        Me.lblObserved.AutoSize = True
        Me.lblObserved.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObserved.Location = New System.Drawing.Point(281, 146)
        Me.lblObserved.Name = "lblObserved"
        Me.lblObserved.Size = New System.Drawing.Size(56, 13)
        Me.lblObserved.TabIndex = 9
        Me.lblObserved.Text = "Observed:"
        '
        'rdoDisplay
        '
        Me.rdoDisplay.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDisplay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDisplay.FlatAppearance.BorderSize = 2
        Me.rdoDisplay.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDisplay.Location = New System.Drawing.Point(17, 7)
        Me.rdoDisplay.Name = "rdoDisplay"
        Me.rdoDisplay.Size = New System.Drawing.Size(107, 27)
        Me.rdoDisplay.TabIndex = 44
        Me.rdoDisplay.TabStop = True
        Me.rdoDisplay.Text = "Display"
        Me.rdoDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDisplay.UseVisualStyleBackColor = True
        '
        'rdoShow
        '
        Me.rdoShow.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoShow.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoShow.FlatAppearance.BorderSize = 2
        Me.rdoShow.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoShow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoShow.Location = New System.Drawing.Point(332, 7)
        Me.rdoShow.Name = "rdoShow"
        Me.rdoShow.Size = New System.Drawing.Size(107, 27)
        Me.rdoShow.TabIndex = 45
        Me.rdoShow.TabStop = True
        Me.rdoShow.Text = "Show"
        Me.rdoShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoShow.UseVisualStyleBackColor = True
        '
        'lblFacetColumns
        '
        Me.lblFacetColumns.AutoSize = True
        Me.lblFacetColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetColumns.Location = New System.Drawing.Point(281, 284)
        Me.lblFacetColumns.Name = "lblFacetColumns"
        Me.lblFacetColumns.Size = New System.Drawing.Size(86, 13)
        Me.lblFacetColumns.TabIndex = 50
        Me.lblFacetColumns.Text = "Facet Column(s):"
        '
        'lblImputed
        '
        Me.lblImputed.AutoSize = True
        Me.lblImputed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblImputed.Location = New System.Drawing.Point(281, 186)
        Me.lblImputed.Name = "lblImputed"
        Me.lblImputed.Size = New System.Drawing.Size(48, 13)
        Me.lblImputed.TabIndex = 51
        Me.lblImputed.Text = "Imputed:"
        '
        'lblDisplayElement
        '
        Me.lblDisplayElement.AutoSize = True
        Me.lblDisplayElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDisplayElement.Location = New System.Drawing.Point(281, 144)
        Me.lblDisplayElement.Name = "lblDisplayElement"
        Me.lblDisplayElement.Size = New System.Drawing.Size(48, 13)
        Me.lblDisplayElement.TabIndex = 52
        Me.lblDisplayElement.Text = "Element:"
        '
        'lblDisplayDate
        '
        Me.lblDisplayDate.AutoSize = True
        Me.lblDisplayDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDisplayDate.Location = New System.Drawing.Point(281, 105)
        Me.lblDisplayDate.Name = "lblDisplayDate"
        Me.lblDisplayDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDisplayDate.TabIndex = 53
        Me.lblDisplayDate.Text = "Date:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblType.Location = New System.Drawing.Point(281, 189)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 58
        Me.lblType.Text = "Type:"
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Enabled = False
        Me.cmdDisplayOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(13, 236)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(119, 23)
        Me.cmdDisplayOptions.TabIndex = 60
        Me.cmdDisplayOptions.Text = "Display Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblIntervalSize
        '
        Me.lblIntervalSize.AutoSize = True
        Me.lblIntervalSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIntervalSize.Location = New System.Drawing.Point(12, 289)
        Me.lblIntervalSize.Name = "lblIntervalSize"
        Me.lblIntervalSize.Size = New System.Drawing.Size(68, 13)
        Me.lblIntervalSize.TabIndex = 62
        Me.lblIntervalSize.Text = "Interval Size:"
        '
        'lblDispMultShowStation
        '
        Me.lblDispMultShowStation.AutoSize = True
        Me.lblDispMultShowStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDispMultShowStation.Location = New System.Drawing.Point(278, 60)
        Me.lblDispMultShowStation.Name = "lblDispMultShowStation"
        Me.lblDispMultShowStation.Size = New System.Drawing.Size(43, 13)
        Me.lblDispMultShowStation.TabIndex = 64
        Me.lblDispMultShowStation.Text = "Station:"
        '
        'lblTrueValues
        '
        Me.lblTrueValues.AutoSize = True
        Me.lblTrueValues.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTrueValues.Location = New System.Drawing.Point(279, 233)
        Me.lblTrueValues.Name = "lblTrueValues"
        Me.lblTrueValues.Size = New System.Drawing.Size(112, 13)
        Me.lblTrueValues.TabIndex = 65
        Me.lblTrueValues.Text = "True Values(Optional):"
        '
        'lblPercentCount
        '
        Me.lblPercentCount.AutoSize = True
        Me.lblPercentCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPercentCount.Location = New System.Drawing.Point(278, 233)
        Me.lblPercentCount.Name = "lblPercentCount"
        Me.lblPercentCount.Size = New System.Drawing.Size(51, 13)
        Me.lblPercentCount.TabIndex = 67
        Me.lblPercentCount.Text = "Measure:"
        '
        'ucrInputTimeInterval
        '
        Me.ucrInputTimeInterval.AddQuotesIfUnrecognised = True
        Me.ucrInputTimeInterval.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTimeInterval.GetSetSelectedIndex = -1
        Me.ucrInputTimeInterval.IsReadOnly = False
        Me.ucrInputTimeInterval.Location = New System.Drawing.Point(199, 303)
        Me.ucrInputTimeInterval.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputTimeInterval.Name = "ucrInputTimeInterval"
        Me.ucrInputTimeInterval.Size = New System.Drawing.Size(70, 21)
        Me.ucrInputTimeInterval.TabIndex = 71
        '
        'ucrNudTimeInterval
        '
        Me.ucrNudTimeInterval.AutoSize = True
        Me.ucrNudTimeInterval.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTimeInterval.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTimeInterval.Location = New System.Drawing.Point(144, 304)
        Me.ucrNudTimeInterval.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTimeInterval.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTimeInterval.Name = "ucrNudTimeInterval"
        Me.ucrNudTimeInterval.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTimeInterval.TabIndex = 69
        Me.ucrNudTimeInterval.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkTimeInterval
        '
        Me.ucrChkTimeInterval.AutoSize = True
        Me.ucrChkTimeInterval.Checked = False
        Me.ucrChkTimeInterval.Location = New System.Drawing.Point(13, 305)
        Me.ucrChkTimeInterval.Name = "ucrChkTimeInterval"
        Me.ucrChkTimeInterval.Size = New System.Drawing.Size(134, 23)
        Me.ucrChkTimeInterval.TabIndex = 68
        '
        'ucrInputComboMeasure
        '
        Me.ucrInputComboMeasure.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMeasure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboMeasure.GetSetSelectedIndex = -1
        Me.ucrInputComboMeasure.IsReadOnly = False
        Me.ucrInputComboMeasure.Location = New System.Drawing.Point(281, 249)
        Me.ucrInputComboMeasure.Name = "ucrInputComboMeasure"
        Me.ucrInputComboMeasure.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputComboMeasure.TabIndex = 66
        '
        'ucrReceiverTrueValues
        '
        Me.ucrReceiverTrueValues.AutoSize = True
        Me.ucrReceiverTrueValues.frmParent = Me
        Me.ucrReceiverTrueValues.Location = New System.Drawing.Point(281, 249)
        Me.ucrReceiverTrueValues.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTrueValues.Name = "ucrReceiverTrueValues"
        Me.ucrReceiverTrueValues.Selector = Nothing
        Me.ucrReceiverTrueValues.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTrueValues.strNcFilePath = ""
        Me.ucrReceiverTrueValues.TabIndex = 48
        Me.ucrReceiverTrueValues.ucrSelector = Nothing
        '
        'ucrReceiverDispMultShowStation
        '
        Me.ucrReceiverDispMultShowStation.AutoSize = True
        Me.ucrReceiverDispMultShowStation.frmParent = Me
        Me.ucrReceiverDispMultShowStation.Location = New System.Drawing.Point(281, 76)
        Me.ucrReceiverDispMultShowStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDispMultShowStation.Name = "ucrReceiverDispMultShowStation"
        Me.ucrReceiverDispMultShowStation.Selector = Nothing
        Me.ucrReceiverDispMultShowStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDispMultShowStation.strNcFilePath = ""
        Me.ucrReceiverDispMultShowStation.TabIndex = 63
        Me.ucrReceiverDispMultShowStation.ucrSelector = Nothing
        '
        'ucrInputIntervalSize
        '
        Me.ucrInputIntervalSize.AddQuotesIfUnrecognised = True
        Me.ucrInputIntervalSize.AutoSize = True
        Me.ucrInputIntervalSize.IsMultiline = False
        Me.ucrInputIntervalSize.IsReadOnly = False
        Me.ucrInputIntervalSize.Location = New System.Drawing.Point(84, 288)
        Me.ucrInputIntervalSize.Name = "ucrInputIntervalSize"
        Me.ucrInputIntervalSize.Size = New System.Drawing.Size(62, 21)
        Me.ucrInputIntervalSize.TabIndex = 61
        '
        'ucrChkFlipCordinates
        '
        Me.ucrChkFlipCordinates.AutoSize = True
        Me.ucrChkFlipCordinates.Checked = False
        Me.ucrChkFlipCordinates.Location = New System.Drawing.Point(13, 289)
        Me.ucrChkFlipCordinates.Name = "ucrChkFlipCordinates"
        Me.ucrChkFlipCordinates.Size = New System.Drawing.Size(132, 23)
        Me.ucrChkFlipCordinates.TabIndex = 59
        '
        'ucrInputComboType
        '
        Me.ucrInputComboType.AddQuotesIfUnrecognised = True
        Me.ucrInputComboType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboType.GetSetSelectedIndex = -1
        Me.ucrInputComboType.IsReadOnly = False
        Me.ucrInputComboType.Location = New System.Drawing.Point(281, 205)
        Me.ucrInputComboType.Name = "ucrInputComboType"
        Me.ucrInputComboType.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputComboType.TabIndex = 57
        '
        'ucrChkAddLegend
        '
        Me.ucrChkAddLegend.AutoSize = True
        Me.ucrChkAddLegend.Checked = False
        Me.ucrChkAddLegend.Location = New System.Drawing.Point(13, 266)
        Me.ucrChkAddLegend.Name = "ucrChkAddLegend"
        Me.ucrChkAddLegend.Size = New System.Drawing.Size(134, 23)
        Me.ucrChkAddLegend.TabIndex = 56
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(13, 318)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(355, 24)
        Me.ucrSaveGraph.TabIndex = 55
        '
        'ucrNudFacetColumns
        '
        Me.ucrNudFacetColumns.AutoSize = True
        Me.ucrNudFacetColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFacetColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFacetColumns.Location = New System.Drawing.Point(368, 281)
        Me.ucrNudFacetColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFacetColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFacetColumns.Name = "ucrNudFacetColumns"
        Me.ucrNudFacetColumns.Size = New System.Drawing.Size(48, 20)
        Me.ucrNudFacetColumns.TabIndex = 49
        Me.ucrNudFacetColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverImputed
        '
        Me.ucrReceiverImputed.AutoSize = True
        Me.ucrReceiverImputed.frmParent = Me
        Me.ucrReceiverImputed.Location = New System.Drawing.Point(281, 203)
        Me.ucrReceiverImputed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverImputed.Name = "ucrReceiverImputed"
        Me.ucrReceiverImputed.Selector = Nothing
        Me.ucrReceiverImputed.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverImputed.strNcFilePath = ""
        Me.ucrReceiverImputed.TabIndex = 48
        Me.ucrReceiverImputed.ucrSelector = Nothing
        '
        'ucrReceiverDisplayObserved
        '
        Me.ucrReceiverDisplayObserved.AutoSize = True
        Me.ucrReceiverDisplayObserved.frmParent = Me
        Me.ucrReceiverDisplayObserved.Location = New System.Drawing.Point(281, 162)
        Me.ucrReceiverDisplayObserved.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDisplayObserved.Name = "ucrReceiverDisplayObserved"
        Me.ucrReceiverDisplayObserved.Selector = Nothing
        Me.ucrReceiverDisplayObserved.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDisplayObserved.strNcFilePath = ""
        Me.ucrReceiverDisplayObserved.TabIndex = 47
        Me.ucrReceiverDisplayObserved.ucrSelector = Nothing
        '
        'ucrReceiverDisplayShowDate
        '
        Me.ucrReceiverDisplayShowDate.AutoSize = True
        Me.ucrReceiverDisplayShowDate.frmParent = Me
        Me.ucrReceiverDisplayShowDate.Location = New System.Drawing.Point(281, 119)
        Me.ucrReceiverDisplayShowDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDisplayShowDate.Name = "ucrReceiverDisplayShowDate"
        Me.ucrReceiverDisplayShowDate.Selector = Nothing
        Me.ucrReceiverDisplayShowDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDisplayShowDate.strNcFilePath = ""
        Me.ucrReceiverDisplayShowDate.TabIndex = 46
        Me.ucrReceiverDisplayShowDate.ucrSelector = Nothing
        '
        'ucrInputStdBias
        '
        Me.ucrInputStdBias.AddQuotesIfUnrecognised = True
        Me.ucrInputStdBias.AutoSize = True
        Me.ucrInputStdBias.IsMultiline = False
        Me.ucrInputStdBias.IsReadOnly = False
        Me.ucrInputStdBias.Location = New System.Drawing.Point(144, 282)
        Me.ucrInputStdBias.Name = "ucrInputStdBias"
        Me.ucrInputStdBias.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputStdBias.TabIndex = 20
        '
        'ucrInputMeanBias
        '
        Me.ucrInputMeanBias.AddQuotesIfUnrecognised = True
        Me.ucrInputMeanBias.AutoSize = True
        Me.ucrInputMeanBias.IsMultiline = False
        Me.ucrInputMeanBias.IsReadOnly = False
        Me.ucrInputMeanBias.Location = New System.Drawing.Point(144, 261)
        Me.ucrInputMeanBias.Name = "ucrInputMeanBias"
        Me.ucrInputMeanBias.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMeanBias.TabIndex = 17
        '
        'ucrChkStdBias
        '
        Me.ucrChkStdBias.AutoSize = True
        Me.ucrChkStdBias.Checked = False
        Me.ucrChkStdBias.Location = New System.Drawing.Point(13, 283)
        Me.ucrChkStdBias.Name = "ucrChkStdBias"
        Me.ucrChkStdBias.Size = New System.Drawing.Size(127, 23)
        Me.ucrChkStdBias.TabIndex = 19
        '
        'ucrChkMeanBias
        '
        Me.ucrChkMeanBias.AutoSize = True
        Me.ucrChkMeanBias.Checked = False
        Me.ucrChkMeanBias.Location = New System.Drawing.Point(13, 261)
        Me.ucrChkMeanBias.Name = "ucrChkMeanBias"
        Me.ucrChkMeanBias.Size = New System.Drawing.Size(208, 23)
        Me.ucrChkMeanBias.TabIndex = 13
        '
        'ucrReceiverObserved
        '
        Me.ucrReceiverObserved.AutoSize = True
        Me.ucrReceiverObserved.frmParent = Me
        Me.ucrReceiverObserved.Location = New System.Drawing.Point(281, 163)
        Me.ucrReceiverObserved.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverObserved.Name = "ucrReceiverObserved"
        Me.ucrReceiverObserved.Selector = Nothing
        Me.ucrReceiverObserved.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverObserved.strNcFilePath = ""
        Me.ucrReceiverObserved.TabIndex = 10
        Me.ucrReceiverObserved.ucrSelector = Nothing
        '
        'ucrReceiverEstimatedElements
        '
        Me.ucrReceiverEstimatedElements.AutoSize = True
        Me.ucrReceiverEstimatedElements.frmParent = Me
        Me.ucrReceiverEstimatedElements.Location = New System.Drawing.Point(281, 202)
        Me.ucrReceiverEstimatedElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEstimatedElements.Name = "ucrReceiverEstimatedElements"
        Me.ucrReceiverEstimatedElements.Selector = Nothing
        Me.ucrReceiverEstimatedElements.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverEstimatedElements.strNcFilePath = ""
        Me.ucrReceiverEstimatedElements.TabIndex = 12
        Me.ucrReceiverEstimatedElements.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(281, 118)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 7
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrInputConstant
        '
        Me.ucrInputConstant.AddQuotesIfUnrecognised = True
        Me.ucrInputConstant.AutoSize = True
        Me.ucrInputConstant.IsMultiline = False
        Me.ucrInputConstant.IsReadOnly = False
        Me.ucrInputConstant.Location = New System.Drawing.Point(279, 362)
        Me.ucrInputConstant.Name = "ucrInputConstant"
        Me.ucrInputConstant.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputConstant.TabIndex = 24
        '
        'ucrReceiverByFactor
        '
        Me.ucrReceiverByFactor.AutoSize = True
        Me.ucrReceiverByFactor.frmParent = Me
        Me.ucrReceiverByFactor.Location = New System.Drawing.Point(281, 185)
        Me.ucrReceiverByFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverByFactor.Name = "ucrReceiverByFactor"
        Me.ucrReceiverByFactor.Selector = Nothing
        Me.ucrReceiverByFactor.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverByFactor.strNcFilePath = ""
        Me.ucrReceiverByFactor.TabIndex = 10
        Me.ucrReceiverByFactor.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(281, 76)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 6
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrChkSetSeed
        '
        Me.ucrChkSetSeed.AutoSize = True
        Me.ucrChkSetSeed.Checked = False
        Me.ucrChkSetSeed.Location = New System.Drawing.Point(146, 405)
        Me.ucrChkSetSeed.Name = "ucrChkSetSeed"
        Me.ucrChkSetSeed.Size = New System.Drawing.Size(76, 23)
        Me.ucrChkSetSeed.TabIndex = 27
        '
        'ucrNudSetSeed
        '
        Me.ucrNudSetSeed.AutoSize = True
        Me.ucrNudSetSeed.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSetSeed.Location = New System.Drawing.Point(223, 405)
        Me.ucrNudSetSeed.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSetSeed.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Name = "ucrNudSetSeed"
        Me.ucrNudSetSeed.Size = New System.Drawing.Size(48, 20)
        Me.ucrNudSetSeed.TabIndex = 28
        Me.ucrNudSetSeed.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaximum
        '
        Me.ucrNudMaximum.AutoSize = True
        Me.ucrNudMaximum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaximum.Location = New System.Drawing.Point(110, 257)
        Me.ucrNudMaximum.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaximum.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximum.Name = "ucrNudMaximum"
        Me.ucrNudMaximum.Size = New System.Drawing.Size(48, 20)
        Me.ucrNudMaximum.TabIndex = 15
        Me.ucrNudMaximum.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkMaxGap
        '
        Me.ucrChkMaxGap.AutoSize = True
        Me.ucrChkMaxGap.Checked = False
        Me.ucrChkMaxGap.Location = New System.Drawing.Point(13, 258)
        Me.ucrChkMaxGap.Name = "ucrChkMaxGap"
        Me.ucrChkMaxGap.Size = New System.Drawing.Size(96, 23)
        Me.ucrChkMaxGap.TabIndex = 14
        '
        'ucrChkBy
        '
        Me.ucrChkBy.AutoSize = True
        Me.ucrChkBy.Checked = False
        Me.ucrChkBy.Location = New System.Drawing.Point(281, 162)
        Me.ucrChkBy.Name = "ucrChkBy"
        Me.ucrChkBy.Size = New System.Drawing.Size(103, 23)
        Me.ucrChkBy.TabIndex = 9
        '
        'ucrChkCopyFromBelow
        '
        Me.ucrChkCopyFromBelow.AutoSize = True
        Me.ucrChkCopyFromBelow.Checked = False
        Me.ucrChkCopyFromBelow.Location = New System.Drawing.Point(12, 405)
        Me.ucrChkCopyFromBelow.Name = "ucrChkCopyFromBelow"
        Me.ucrChkCopyFromBelow.Size = New System.Drawing.Size(110, 23)
        Me.ucrChkCopyFromBelow.TabIndex = 25
        '
        'ucrSaveNewColumn
        '
        Me.ucrSaveNewColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewColumn.Location = New System.Drawing.Point(12, 433)
        Me.ucrSaveNewColumn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewColumn.Name = "ucrSaveNewColumn"
        Me.ucrSaveNewColumn.Size = New System.Drawing.Size(320, 24)
        Me.ucrSaveNewColumn.TabIndex = 29
        '
        'ucrInputComboFunction
        '
        Me.ucrInputComboFunction.AddQuotesIfUnrecognised = True
        Me.ucrInputComboFunction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboFunction.GetSetSelectedIndex = -1
        Me.ucrInputComboFunction.IsReadOnly = False
        Me.ucrInputComboFunction.Location = New System.Drawing.Point(66, 404)
        Me.ucrInputComboFunction.Name = "ucrInputComboFunction"
        Me.ucrInputComboFunction.Size = New System.Drawing.Size(66, 21)
        Me.ucrInputComboFunction.TabIndex = 26
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.AutoSize = True
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(281, 127)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 8
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 461)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 30
        '
        'ucrSelectorInfillMissing
        '
        Me.ucrSelectorInfillMissing.AutoSize = True
        Me.ucrSelectorInfillMissing.bDropUnusedFilterLevels = False
        Me.ucrSelectorInfillMissing.bShowHiddenColumns = False
        Me.ucrSelectorInfillMissing.bUseCurrentFilter = True
        Me.ucrSelectorInfillMissing.Location = New System.Drawing.Point(12, 53)
        Me.ucrSelectorInfillMissing.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorInfillMissing.Name = "ucrSelectorInfillMissing"
        Me.ucrSelectorInfillMissing.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorInfillMissing.TabIndex = 3
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(13, 7)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(432, 27)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrInputNewColumnName
        '
        Me.ucrInputNewColumnName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewColumnName.AutoSize = True
        Me.ucrInputNewColumnName.IsMultiline = False
        Me.ucrInputNewColumnName.IsReadOnly = False
        Me.ucrInputNewColumnName.Location = New System.Drawing.Point(144, 326)
        Me.ucrInputNewColumnName.Name = "ucrInputNewColumnName"
        Me.ucrInputNewColumnName.Size = New System.Drawing.Size(134, 21)
        Me.ucrInputNewColumnName.TabIndex = 72
        '
        'dlgInfillMissingValues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(454, 514)
        Me.Controls.Add(Me.ucrInputNewColumnName)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputTimeInterval)
        Me.Controls.Add(Me.ucrNudTimeInterval)
        Me.Controls.Add(Me.ucrChkTimeInterval)
        Me.Controls.Add(Me.lblPercentCount)
        Me.Controls.Add(Me.ucrInputComboMeasure)
        Me.Controls.Add(Me.ucrReceiverTrueValues)
        Me.Controls.Add(Me.lblTrueValues)
        Me.Controls.Add(Me.lblDispMultShowStation)
        Me.Controls.Add(Me.ucrReceiverDispMultShowStation)
        Me.Controls.Add(Me.lblIntervalSize)
        Me.Controls.Add(Me.ucrInputIntervalSize)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrChkFlipCordinates)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.ucrInputComboType)
        Me.Controls.Add(Me.ucrChkAddLegend)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblDisplayDate)
        Me.Controls.Add(Me.lblDisplayElement)
        Me.Controls.Add(Me.lblImputed)
        Me.Controls.Add(Me.lblFacetColumns)
        Me.Controls.Add(Me.ucrNudFacetColumns)
        Me.Controls.Add(Me.ucrReceiverImputed)
        Me.Controls.Add(Me.ucrReceiverDisplayObserved)
        Me.Controls.Add(Me.ucrReceiverDisplayShowDate)
        Me.Controls.Add(Me.rdoShow)
        Me.Controls.Add(Me.rdoDisplay)
        Me.Controls.Add(Me.ucrInputStdBias)
        Me.Controls.Add(Me.ucrInputMeanBias)
        Me.Controls.Add(Me.ucrChkStdBias)
        Me.Controls.Add(Me.ucrChkMeanBias)
        Me.Controls.Add(Me.lblObserved)
        Me.Controls.Add(Me.ucrReceiverObserved)
        Me.Controls.Add(Me.lblEstimated)
        Me.Controls.Add(Me.ucrReceiverEstimatedElements)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrInputConstant)
        Me.Controls.Add(Me.ucrReceiverByFactor)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrChkSetSeed)
        Me.Controls.Add(Me.ucrNudSetSeed)
        Me.Controls.Add(Me.lblRows)
        Me.Controls.Add(Me.ucrNudMaximum)
        Me.Controls.Add(Me.ucrChkMaxGap)
        Me.Controls.Add(Me.ucrChkBy)
        Me.Controls.Add(Me.ucrChkCopyFromBelow)
        Me.Controls.Add(Me.grpStartEnd)
        Me.Controls.Add(Me.lblFunction)
        Me.Controls.Add(Me.ucrSaveNewColumn)
        Me.Controls.Add(Me.ucrInputComboFunction)
        Me.Controls.Add(Me.rdoFitMultiple)
        Me.Controls.Add(Me.rdoFitSingle)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorInfillMissing)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.grpMethods)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInfillMissingValues"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Missing Values"
        Me.grpMethods.ResumeLayout(False)
        Me.grpMethods.PerformLayout()
        Me.grpStartEnd.ResumeLayout(False)
        Me.grpStartEnd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorInfillMissing As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents rdoNaApproximate As RadioButton
    Friend WithEvents rdoNaAggregate As RadioButton
    Friend WithEvents rdoNaFill As RadioButton
    Friend WithEvents rdoNaSpline As RadioButton
    Friend WithEvents rdoNaLocf As RadioButton
    Friend WithEvents rdoNaStructTS As RadioButton
    Friend WithEvents lblElement As Label
    Friend WithEvents rdoFitMultiple As RadioButton
    Friend WithEvents rdoFitSingle As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrPnlMethods As UcrPanel
    Friend WithEvents grpMethods As GroupBox
    Friend WithEvents ucrSaveNewColumn As ucrSave
    Friend WithEvents grpStartEnd As GroupBox
    Friend WithEvents rdoExtendFill As RadioButton
    Friend WithEvents rdoLeaveAsMissing As RadioButton
    Friend WithEvents ucrPnlStartEnd As UcrPanel
    Friend WithEvents ucrInputComboFunction As ucrInputComboBox
    Friend WithEvents lblFunction As Label
    Friend WithEvents ucrChkCopyFromBelow As ucrCheck
    Friend WithEvents ucrInputConstant As ucrInputTextBox
    Friend WithEvents ucrChkBy As ucrCheck
    Friend WithEvents ucrChkMaxGap As ucrCheck
    Friend WithEvents ucrNudMaximum As ucrNud
    Friend WithEvents lblRows As Label
    Friend WithEvents ucrNudSetSeed As ucrNud
    Friend WithEvents lblValue As Label
    Friend WithEvents ucrChkSetSeed As ucrCheck
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverByFactor As ucrReceiverMultiple
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblEstimated As Label
    Friend WithEvents ucrReceiverEstimatedElements As ucrReceiverMultiple
    Friend WithEvents lblObserved As Label
    Friend WithEvents ucrReceiverObserved As ucrReceiverSingle
    Friend WithEvents ucrChkStdBias As ucrCheck
    Friend WithEvents ucrChkMeanBias As ucrCheck
    Friend WithEvents ucrInputStdBias As ucrInputTextBox
    Friend WithEvents ucrInputMeanBias As ucrInputTextBox
    Friend WithEvents rdoShow As RadioButton
    Friend WithEvents rdoDisplay As RadioButton
    Friend WithEvents ucrReceiverDisplayObserved As ucrReceiverSingle
    Friend WithEvents ucrReceiverDisplayShowDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverImputed As ucrReceiverSingle
    Friend WithEvents ucrNudFacetColumns As ucrNud
    Friend WithEvents lblFacetColumns As Label
    Friend WithEvents lblImputed As Label
    Friend WithEvents lblDisplayDate As Label
    Friend WithEvents lblDisplayElement As Label
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrChkAddLegend As ucrCheck
    Friend WithEvents lblType As Label
    Friend WithEvents ucrInputComboType As ucrInputComboBox
    Friend WithEvents ucrChkFlipCordinates As ucrCheck
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents lblIntervalSize As Label
    Friend WithEvents ucrInputIntervalSize As ucrInputTextBox
    Friend WithEvents lblDispMultShowStation As Label
    Friend WithEvents ucrReceiverDispMultShowStation As ucrReceiverSingle
    Friend WithEvents lblTrueValues As Label
    Friend WithEvents ucrReceiverTrueValues As ucrReceiverSingle
    Friend WithEvents ucrInputComboMeasure As ucrInputComboBox
    Friend WithEvents lblPercentCount As Label
    Friend WithEvents ucrNudTimeInterval As ucrNud
    Friend WithEvents ucrChkTimeInterval As ucrCheck
    Friend WithEvents ucrInputTimeInterval As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrInputNewColumnName As ucrInputTextBox
End Class
