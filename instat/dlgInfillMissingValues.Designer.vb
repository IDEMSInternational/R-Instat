<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgInfillMissingValues
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgInfillMissingValues))
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
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.rdoDisplay = New System.Windows.Forms.RadioButton()
        Me.rdoShow = New System.Windows.Forms.RadioButton()
        Me.lblFacetColumns = New System.Windows.Forms.Label()
        Me.lblImputed = New System.Windows.Forms.Label()
        Me.lblDisplayElement = New System.Windows.Forms.Label()
        Me.lblDisplayDate = New System.Windows.Forms.Label()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrNudFacetColumns = New instat.ucrNud()
        Me.ucrReceiverImputed = New instat.ucrReceiverSingle()
        Me.ucrReceiverDisplayObserved = New instat.ucrReceiverSingle()
        Me.ucrReceiverDisplayShowDate = New instat.ucrReceiverSingle()
        Me.ucrInputNewColumnName = New instat.ucrInputTextBox()
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
        Me.ucrChkAddLegend = New instat.ucrCheck()
        Me.ucrInputComboType = New instat.ucrInputComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.ucrChkFlipCordinates = New instat.ucrCheck()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.ucrInputIntervalSize = New instat.ucrInputTextBox()
        Me.lblIntervalSize = New System.Windows.Forms.Label()
        Me.ucrReceiverDispMultShowStation = New instat.ucrReceiverSingle()
        Me.lblDispMultShowStation = New System.Windows.Forms.Label()
        Me.ucrReceiverTrueValues = New instat.ucrReceiverSingle()
        Me.lblTrueValues = New System.Windows.Forms.Label()
        Me.ucrInputComboMeasure = New instat.ucrInputComboBox()
        Me.lblPercentCount = New System.Windows.Forms.Label()
        Me.grpMethods.SuspendLayout()
        Me.grpStartEnd.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoNaStructTS
        '
        resources.ApplyResources(Me.rdoNaStructTS, "rdoNaStructTS")
        Me.rdoNaStructTS.Name = "rdoNaStructTS"
        Me.rdoNaStructTS.TabStop = True
        Me.rdoNaStructTS.UseVisualStyleBackColor = True
        '
        'rdoNaLocf
        '
        resources.ApplyResources(Me.rdoNaLocf, "rdoNaLocf")
        Me.rdoNaLocf.Name = "rdoNaLocf"
        Me.rdoNaLocf.TabStop = True
        Me.rdoNaLocf.UseVisualStyleBackColor = True
        '
        'rdoNaSpline
        '
        resources.ApplyResources(Me.rdoNaSpline, "rdoNaSpline")
        Me.rdoNaSpline.Name = "rdoNaSpline"
        Me.rdoNaSpline.TabStop = True
        Me.rdoNaSpline.UseVisualStyleBackColor = True
        '
        'rdoNaFill
        '
        resources.ApplyResources(Me.rdoNaFill, "rdoNaFill")
        Me.rdoNaFill.Name = "rdoNaFill"
        Me.rdoNaFill.TabStop = True
        Me.rdoNaFill.UseVisualStyleBackColor = True
        '
        'rdoNaAggregate
        '
        resources.ApplyResources(Me.rdoNaAggregate, "rdoNaAggregate")
        Me.rdoNaAggregate.Name = "rdoNaAggregate"
        Me.rdoNaAggregate.TabStop = True
        Me.rdoNaAggregate.UseVisualStyleBackColor = True
        '
        'rdoNaApproximate
        '
        resources.ApplyResources(Me.rdoNaApproximate, "rdoNaApproximate")
        Me.rdoNaApproximate.Name = "rdoNaApproximate"
        Me.rdoNaApproximate.TabStop = True
        Me.rdoNaApproximate.UseVisualStyleBackColor = True
        '
        'lblElement
        '
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
        '
        'rdoFitSingle
        '
        resources.ApplyResources(Me.rdoFitSingle, "rdoFitSingle")
        Me.rdoFitSingle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFitSingle.FlatAppearance.BorderSize = 2
        Me.rdoFitSingle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFitSingle.Name = "rdoFitSingle"
        Me.rdoFitSingle.TabStop = True
        Me.rdoFitSingle.UseVisualStyleBackColor = True
        '
        'rdoFitMultiple
        '
        resources.ApplyResources(Me.rdoFitMultiple, "rdoFitMultiple")
        Me.rdoFitMultiple.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFitMultiple.FlatAppearance.BorderSize = 2
        Me.rdoFitMultiple.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFitMultiple.Name = "rdoFitMultiple"
        Me.rdoFitMultiple.TabStop = True
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
        resources.ApplyResources(Me.grpMethods, "grpMethods")
        Me.grpMethods.Name = "grpMethods"
        Me.grpMethods.TabStop = False
        '
        'ucrPnlMethods
        '
        resources.ApplyResources(Me.ucrPnlMethods, "ucrPnlMethods")
        Me.ucrPnlMethods.Name = "ucrPnlMethods"
        '
        'grpStartEnd
        '
        Me.grpStartEnd.Controls.Add(Me.rdoExtendFill)
        Me.grpStartEnd.Controls.Add(Me.rdoLeaveAsMissing)
        Me.grpStartEnd.Controls.Add(Me.ucrPnlStartEnd)
        resources.ApplyResources(Me.grpStartEnd, "grpStartEnd")
        Me.grpStartEnd.Name = "grpStartEnd"
        Me.grpStartEnd.TabStop = False
        '
        'rdoExtendFill
        '
        resources.ApplyResources(Me.rdoExtendFill, "rdoExtendFill")
        Me.rdoExtendFill.Name = "rdoExtendFill"
        Me.rdoExtendFill.TabStop = True
        Me.rdoExtendFill.UseVisualStyleBackColor = True
        '
        'rdoLeaveAsMissing
        '
        resources.ApplyResources(Me.rdoLeaveAsMissing, "rdoLeaveAsMissing")
        Me.rdoLeaveAsMissing.Name = "rdoLeaveAsMissing"
        Me.rdoLeaveAsMissing.TabStop = True
        Me.rdoLeaveAsMissing.UseVisualStyleBackColor = True
        '
        'ucrPnlStartEnd
        '
        resources.ApplyResources(Me.ucrPnlStartEnd, "ucrPnlStartEnd")
        Me.ucrPnlStartEnd.Name = "ucrPnlStartEnd"
        '
        'lblValue
        '
        resources.ApplyResources(Me.lblValue, "lblValue")
        Me.lblValue.Name = "lblValue"
        '
        'lblFunction
        '
        resources.ApplyResources(Me.lblFunction, "lblFunction")
        Me.lblFunction.Name = "lblFunction"
        '
        'lblRows
        '
        resources.ApplyResources(Me.lblRows, "lblRows")
        Me.lblRows.Name = "lblRows"
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'lblEstimated
        '
        resources.ApplyResources(Me.lblEstimated, "lblEstimated")
        Me.lblEstimated.Name = "lblEstimated"
        '
        'lblObserved
        '
        resources.ApplyResources(Me.lblObserved, "lblObserved")
        Me.lblObserved.Name = "lblObserved"
        '
        'lblNewColumnName
        '
        resources.ApplyResources(Me.lblNewColumnName, "lblNewColumnName")
        Me.lblNewColumnName.Name = "lblNewColumnName"
        '
        'rdoDisplay
        '
        resources.ApplyResources(Me.rdoDisplay, "rdoDisplay")
        Me.rdoDisplay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDisplay.FlatAppearance.BorderSize = 2
        Me.rdoDisplay.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDisplay.Name = "rdoDisplay"
        Me.rdoDisplay.TabStop = True
        Me.rdoDisplay.UseVisualStyleBackColor = True
        '
        'rdoShow
        '
        resources.ApplyResources(Me.rdoShow, "rdoShow")
        Me.rdoShow.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoShow.FlatAppearance.BorderSize = 2
        Me.rdoShow.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoShow.Name = "rdoShow"
        Me.rdoShow.TabStop = True
        Me.rdoShow.UseVisualStyleBackColor = True
        '
        'lblFacetColumns
        '
        resources.ApplyResources(Me.lblFacetColumns, "lblFacetColumns")
        Me.lblFacetColumns.Name = "lblFacetColumns"
        '
        'lblImputed
        '
        resources.ApplyResources(Me.lblImputed, "lblImputed")
        Me.lblImputed.Name = "lblImputed"
        '
        'lblDisplayElement
        '
        resources.ApplyResources(Me.lblDisplayElement, "lblDisplayElement")
        Me.lblDisplayElement.Name = "lblDisplayElement"
        '
        'lblDisplayDate
        '
        resources.ApplyResources(Me.lblDisplayDate, "lblDisplayDate")
        Me.lblDisplayDate.Name = "lblDisplayDate"
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'ucrNudFacetColumns
        '
        Me.ucrNudFacetColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFacetColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudFacetColumns, "ucrNudFacetColumns")
        Me.ucrNudFacetColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFacetColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFacetColumns.Name = "ucrNudFacetColumns"
        Me.ucrNudFacetColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverImputed
        '
        Me.ucrReceiverImputed.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverImputed, "ucrReceiverImputed")
        Me.ucrReceiverImputed.Name = "ucrReceiverImputed"
        Me.ucrReceiverImputed.Selector = Nothing
        Me.ucrReceiverImputed.strNcFilePath = ""
        Me.ucrReceiverImputed.ucrSelector = Nothing
        '
        'ucrReceiverDisplayObserved
        '
        Me.ucrReceiverDisplayObserved.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDisplayObserved, "ucrReceiverDisplayObserved")
        Me.ucrReceiverDisplayObserved.Name = "ucrReceiverDisplayObserved"
        Me.ucrReceiverDisplayObserved.Selector = Nothing
        Me.ucrReceiverDisplayObserved.strNcFilePath = ""
        Me.ucrReceiverDisplayObserved.ucrSelector = Nothing
        '
        'ucrReceiverDisplayShowDate
        '
        Me.ucrReceiverDisplayShowDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDisplayShowDate, "ucrReceiverDisplayShowDate")
        Me.ucrReceiverDisplayShowDate.Name = "ucrReceiverDisplayShowDate"
        Me.ucrReceiverDisplayShowDate.Selector = Nothing
        Me.ucrReceiverDisplayShowDate.strNcFilePath = ""
        Me.ucrReceiverDisplayShowDate.ucrSelector = Nothing
        '
        'ucrInputNewColumnName
        '
        Me.ucrInputNewColumnName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewColumnName.IsMultiline = False
        Me.ucrInputNewColumnName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNewColumnName, "ucrInputNewColumnName")
        Me.ucrInputNewColumnName.Name = "ucrInputNewColumnName"
        '
        'ucrInputStdBias
        '
        Me.ucrInputStdBias.AddQuotesIfUnrecognised = True
        Me.ucrInputStdBias.IsMultiline = False
        Me.ucrInputStdBias.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStdBias, "ucrInputStdBias")
        Me.ucrInputStdBias.Name = "ucrInputStdBias"
        '
        'ucrInputMeanBias
        '
        Me.ucrInputMeanBias.AddQuotesIfUnrecognised = True
        Me.ucrInputMeanBias.IsMultiline = False
        Me.ucrInputMeanBias.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMeanBias, "ucrInputMeanBias")
        Me.ucrInputMeanBias.Name = "ucrInputMeanBias"
        '
        'ucrChkStdBias
        '
        Me.ucrChkStdBias.Checked = False
        resources.ApplyResources(Me.ucrChkStdBias, "ucrChkStdBias")
        Me.ucrChkStdBias.Name = "ucrChkStdBias"
        '
        'ucrChkMeanBias
        '
        Me.ucrChkMeanBias.Checked = False
        resources.ApplyResources(Me.ucrChkMeanBias, "ucrChkMeanBias")
        Me.ucrChkMeanBias.Name = "ucrChkMeanBias"
        '
        'ucrReceiverObserved
        '
        Me.ucrReceiverObserved.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverObserved, "ucrReceiverObserved")
        Me.ucrReceiverObserved.Name = "ucrReceiverObserved"
        Me.ucrReceiverObserved.Selector = Nothing
        Me.ucrReceiverObserved.strNcFilePath = ""
        Me.ucrReceiverObserved.ucrSelector = Nothing
        '
        'ucrReceiverEstimatedElements
        '
        Me.ucrReceiverEstimatedElements.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverEstimatedElements, "ucrReceiverEstimatedElements")
        Me.ucrReceiverEstimatedElements.Name = "ucrReceiverEstimatedElements"
        Me.ucrReceiverEstimatedElements.Selector = Nothing
        Me.ucrReceiverEstimatedElements.strNcFilePath = ""
        Me.ucrReceiverEstimatedElements.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrInputConstant
        '
        Me.ucrInputConstant.AddQuotesIfUnrecognised = True
        Me.ucrInputConstant.IsMultiline = False
        Me.ucrInputConstant.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputConstant, "ucrInputConstant")
        Me.ucrInputConstant.Name = "ucrInputConstant"
        '
        'ucrReceiverByFactor
        '
        Me.ucrReceiverByFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverByFactor, "ucrReceiverByFactor")
        Me.ucrReceiverByFactor.Name = "ucrReceiverByFactor"
        Me.ucrReceiverByFactor.Selector = Nothing
        Me.ucrReceiverByFactor.strNcFilePath = ""
        Me.ucrReceiverByFactor.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStation, "ucrReceiverStation")
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrChkSetSeed
        '
        Me.ucrChkSetSeed.Checked = False
        resources.ApplyResources(Me.ucrChkSetSeed, "ucrChkSetSeed")
        Me.ucrChkSetSeed.Name = "ucrChkSetSeed"
        '
        'ucrNudSetSeed
        '
        Me.ucrNudSetSeed.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSetSeed, "ucrNudSetSeed")
        Me.ucrNudSetSeed.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSetSeed.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Name = "ucrNudSetSeed"
        Me.ucrNudSetSeed.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaximum
        '
        Me.ucrNudMaximum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMaximum, "ucrNudMaximum")
        Me.ucrNudMaximum.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaximum.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximum.Name = "ucrNudMaximum"
        Me.ucrNudMaximum.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkMaxGap
        '
        Me.ucrChkMaxGap.Checked = False
        resources.ApplyResources(Me.ucrChkMaxGap, "ucrChkMaxGap")
        Me.ucrChkMaxGap.Name = "ucrChkMaxGap"
        '
        'ucrChkBy
        '
        Me.ucrChkBy.Checked = False
        resources.ApplyResources(Me.ucrChkBy, "ucrChkBy")
        Me.ucrChkBy.Name = "ucrChkBy"
        '
        'ucrChkCopyFromBelow
        '
        Me.ucrChkCopyFromBelow.Checked = False
        resources.ApplyResources(Me.ucrChkCopyFromBelow, "ucrChkCopyFromBelow")
        Me.ucrChkCopyFromBelow.Name = "ucrChkCopyFromBelow"
        '
        'ucrSaveNewColumn
        '
        resources.ApplyResources(Me.ucrSaveNewColumn, "ucrSaveNewColumn")
        Me.ucrSaveNewColumn.Name = "ucrSaveNewColumn"
        '
        'ucrInputComboFunction
        '
        Me.ucrInputComboFunction.AddQuotesIfUnrecognised = True
        Me.ucrInputComboFunction.GetSetSelectedIndex = -1
        Me.ucrInputComboFunction.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboFunction, "ucrInputComboFunction")
        Me.ucrInputComboFunction.Name = "ucrInputComboFunction"
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverElement, "ucrReceiverElement")
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorInfillMissing
        '
        Me.ucrSelectorInfillMissing.bDropUnusedFilterLevels = False
        Me.ucrSelectorInfillMissing.bShowHiddenColumns = False
        Me.ucrSelectorInfillMissing.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorInfillMissing, "ucrSelectorInfillMissing")
        Me.ucrSelectorInfillMissing.Name = "ucrSelectorInfillMissing"
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'ucrChkAddLegend
        '
        Me.ucrChkAddLegend.Checked = False
        resources.ApplyResources(Me.ucrChkAddLegend, "ucrChkAddLegend")
        Me.ucrChkAddLegend.Name = "ucrChkAddLegend"
        '
        'ucrInputComboType
        '
        Me.ucrInputComboType.AddQuotesIfUnrecognised = True
        Me.ucrInputComboType.GetSetSelectedIndex = -1
        Me.ucrInputComboType.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboType, "ucrInputComboType")
        Me.ucrInputComboType.Name = "ucrInputComboType"
        '
        'lblType
        '
        resources.ApplyResources(Me.lblType, "lblType")
        Me.lblType.Name = "lblType"
        '
        'ucrChkFlipCordinates
        '
        Me.ucrChkFlipCordinates.Checked = False
        resources.ApplyResources(Me.ucrChkFlipCordinates, "ucrChkFlipCordinates")
        Me.ucrChkFlipCordinates.Name = "ucrChkFlipCordinates"
        '
        'cmdDisplayOptions
        '
        resources.ApplyResources(Me.cmdDisplayOptions, "cmdDisplayOptions")
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'ucrInputIntervalSize
        '
        Me.ucrInputIntervalSize.AddQuotesIfUnrecognised = True
        Me.ucrInputIntervalSize.IsMultiline = False
        Me.ucrInputIntervalSize.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputIntervalSize, "ucrInputIntervalSize")
        Me.ucrInputIntervalSize.Name = "ucrInputIntervalSize"
        '
        'lblIntervalSize
        '
        resources.ApplyResources(Me.lblIntervalSize, "lblIntervalSize")
        Me.lblIntervalSize.Name = "lblIntervalSize"
        '
        'ucrReceiverDispMultShowStation
        '
        Me.ucrReceiverDispMultShowStation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDispMultShowStation, "ucrReceiverDispMultShowStation")
        Me.ucrReceiverDispMultShowStation.Name = "ucrReceiverDispMultShowStation"
        Me.ucrReceiverDispMultShowStation.Selector = Nothing
        Me.ucrReceiverDispMultShowStation.strNcFilePath = ""
        Me.ucrReceiverDispMultShowStation.ucrSelector = Nothing
        '
        'lblDispMultShowStation
        '
        resources.ApplyResources(Me.lblDispMultShowStation, "lblDispMultShowStation")
        Me.lblDispMultShowStation.Name = "lblDispMultShowStation"
        '
        'ucrReceiverTrueValues
        '
        Me.ucrReceiverTrueValues.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverTrueValues, "ucrReceiverTrueValues")
        Me.ucrReceiverTrueValues.Name = "ucrReceiverTrueValues"
        Me.ucrReceiverTrueValues.Selector = Nothing
        Me.ucrReceiverTrueValues.strNcFilePath = ""
        Me.ucrReceiverTrueValues.ucrSelector = Nothing
        '
        'lblTrueValues
        '
        resources.ApplyResources(Me.lblTrueValues, "lblTrueValues")
        Me.lblTrueValues.Name = "lblTrueValues"
        '
        'ucrInputComboMeasure
        '
        Me.ucrInputComboMeasure.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMeasure.GetSetSelectedIndex = -1
        Me.ucrInputComboMeasure.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboMeasure, "ucrInputComboMeasure")
        Me.ucrInputComboMeasure.Name = "ucrInputComboMeasure"
        '
        'lblPercentCount
        '
        resources.ApplyResources(Me.lblPercentCount, "lblPercentCount")
        Me.lblPercentCount.Name = "lblPercentCount"
        '
        'dlgInfillMissingValues
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Controls.Add(Me.ucrInputNewColumnName)
        Me.Controls.Add(Me.lblNewColumnName)
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
    Friend WithEvents ucrInputNewColumnName As ucrInputTextBox
    Friend WithEvents lblNewColumnName As Label
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
End Class
