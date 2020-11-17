<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgInventoryPlot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgInventoryPlot))
        Me.tbInventory = New System.Windows.Forms.TabControl()
        Me.tpTitles = New System.Windows.Forms.TabPage()
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
        Me.tpXAxis = New System.Windows.Forms.TabPage()
        Me.grpScaleXDate = New System.Windows.Forms.GroupBox()
        Me.ucrInputComboDateLabel = New instat.ucrInputComboBox()
        Me.ucrChkDateLabels = New instat.ucrCheck()
        Me.ucrInputComboDateBreak = New instat.ucrInputComboBox()
        Me.lbXscaleDateLowerLimit = New System.Windows.Forms.Label()
        Me.lblXScalDateUpperLimit = New System.Windows.Forms.Label()
        Me.ucrNudDateBreak = New instat.ucrNud()
        Me.ucrDtpLowerLimit = New instat.ucrDateTimePicker()
        Me.ucrDtpUpperLimit = New instat.ucrDateTimePicker()
        Me.ucrChkLimits = New instat.ucrCheck()
        Me.ucrChkBreaks = New instat.ucrCheck()
        Me.ucrInputAxisType = New instat.ucrInputComboBox()
        Me.grpAxes = New System.Windows.Forms.GroupBox()
        Me.ucrChkXAxisLabelSize = New instat.ucrCheck()
        Me.rdoAutoXAxis = New System.Windows.Forms.RadioButton()
        Me.ucrNudXaxisLabelSize = New instat.ucrNud()
        Me.ucrInputXAxisTitle = New instat.ucrInputTextBox()
        Me.ucrChkXAxisAngle = New instat.ucrCheck()
        Me.rdoNoTitleXAxisTitle = New System.Windows.Forms.RadioButton()
        Me.ucrNudXAxisAngle = New instat.ucrNud()
        Me.rdoSpecifyXAxisTitle = New System.Windows.Forms.RadioButton()
        Me.ucrPnlXAxisTitle = New instat.UcrPanel()
        Me.tpYAxis = New System.Windows.Forms.TabPage()
        Me.grpyAxisTitle = New System.Windows.Forms.GroupBox()
        Me.ucrChkYAxisAngle = New instat.ucrCheck()
        Me.ucrNudYAxisAngle = New instat.ucrNud()
        Me.rdoAutoYAxis = New System.Windows.Forms.RadioButton()
        Me.ucrInputYAxisTitle = New instat.ucrInputTextBox()
        Me.rdoNoYAxisTitle = New System.Windows.Forms.RadioButton()
        Me.ucrNudYAxisTitleSize = New instat.ucrNud()
        Me.rdoSpecifyYAxisTitle = New System.Windows.Forms.RadioButton()
        Me.UcrPnlYAxisTitle = New instat.UcrPanel()
        Me.lblYAxisTitleSize = New System.Windows.Forms.Label()
        Me.tpLegend = New System.Windows.Forms.TabPage()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkLegendPosition = New instat.ucrCheck()
        Me.ucrButtonsInventoryplot = New instat.ucrButtonsSubdialogue()
        Me.ucrChkInputAxisType = New instat.ucrCheck()
        Me.tbInventory.SuspendLayout()
        Me.tpTitles.SuspendLayout()
        Me.grpGraphTitles.SuspendLayout()
        Me.tpXAxis.SuspendLayout()
        Me.grpScaleXDate.SuspendLayout()
        Me.grpAxes.SuspendLayout()
        Me.tpYAxis.SuspendLayout()
        Me.grpyAxisTitle.SuspendLayout()
        Me.tpLegend.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbInventory
        '
        Me.tbInventory.Controls.Add(Me.tpTitles)
        Me.tbInventory.Controls.Add(Me.tpXAxis)
        Me.tbInventory.Controls.Add(Me.tpYAxis)
        Me.tbInventory.Controls.Add(Me.tpLegend)
        resources.ApplyResources(Me.tbInventory, "tbInventory")
        Me.tbInventory.Name = "tbInventory"
        Me.tbInventory.SelectedIndex = 0
        '
        'tpTitles
        '
        Me.tpTitles.Controls.Add(Me.grpGraphTitles)
        resources.ApplyResources(Me.tpTitles, "tpTitles")
        Me.tpTitles.Name = "tpTitles"
        Me.tpTitles.UseVisualStyleBackColor = True
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
        resources.ApplyResources(Me.grpGraphTitles, "grpGraphTitles")
        Me.grpGraphTitles.Name = "grpGraphTitles"
        Me.grpGraphTitles.TabStop = False
        '
        'lblCaptionSize
        '
        resources.ApplyResources(Me.lblCaptionSize, "lblCaptionSize")
        Me.lblCaptionSize.Name = "lblCaptionSize"
        '
        'lblSubTitleSize
        '
        resources.ApplyResources(Me.lblSubTitleSize, "lblSubTitleSize")
        Me.lblSubTitleSize.Name = "lblSubTitleSize"
        '
        'lblTitleSize
        '
        resources.ApplyResources(Me.lblTitleSize, "lblTitleSize")
        Me.lblTitleSize.Name = "lblTitleSize"
        '
        'lblCaption
        '
        resources.ApplyResources(Me.lblCaption, "lblCaption")
        Me.lblCaption.Name = "lblCaption"
        '
        'lblSubTitle
        '
        resources.ApplyResources(Me.lblSubTitle, "lblSubTitle")
        Me.lblSubTitle.Name = "lblSubTitle"
        '
        'lblTitle
        '
        resources.ApplyResources(Me.lblTitle, "lblTitle")
        Me.lblTitle.Name = "lblTitle"
        '
        'ucrNudCaptionSize
        '
        Me.ucrNudCaptionSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCaptionSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudCaptionSize, "ucrNudCaptionSize")
        Me.ucrNudCaptionSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCaptionSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCaptionSize.Name = "ucrNudCaptionSize"
        Me.ucrNudCaptionSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSubTitleSize
        '
        Me.ucrNudSubTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSubTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSubTitleSize, "ucrNudSubTitleSize")
        Me.ucrNudSubTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSubTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSubTitleSize.Name = "ucrNudSubTitleSize"
        Me.ucrNudSubTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTitleSize
        '
        Me.ucrNudTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudTitleSize, "ucrNudTitleSize")
        Me.ucrNudTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Name = "ucrNudTitleSize"
        Me.ucrNudTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputGraphcCaption
        '
        Me.ucrInputGraphcCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphcCaption.IsMultiline = True
        Me.ucrInputGraphcCaption.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphcCaption, "ucrInputGraphcCaption")
        Me.ucrInputGraphcCaption.Name = "ucrInputGraphcCaption"
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphTitle, "ucrInputGraphTitle")
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        '
        'ucrInputGraphSubTitle
        '
        Me.ucrInputGraphSubTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphSubTitle.IsMultiline = False
        Me.ucrInputGraphSubTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphSubTitle, "ucrInputGraphSubTitle")
        Me.ucrInputGraphSubTitle.Name = "ucrInputGraphSubTitle"
        '
        'tpXAxis
        '
        Me.tpXAxis.Controls.Add(Me.ucrChkInputAxisType)
        Me.tpXAxis.Controls.Add(Me.grpScaleXDate)
        Me.tpXAxis.Controls.Add(Me.ucrInputAxisType)
        Me.tpXAxis.Controls.Add(Me.grpAxes)
        resources.ApplyResources(Me.tpXAxis, "tpXAxis")
        Me.tpXAxis.Name = "tpXAxis"
        Me.tpXAxis.UseVisualStyleBackColor = True
        '
        'grpScaleXDate
        '
        Me.grpScaleXDate.Controls.Add(Me.ucrInputComboDateLabel)
        Me.grpScaleXDate.Controls.Add(Me.ucrChkDateLabels)
        Me.grpScaleXDate.Controls.Add(Me.ucrInputComboDateBreak)
        Me.grpScaleXDate.Controls.Add(Me.lbXscaleDateLowerLimit)
        Me.grpScaleXDate.Controls.Add(Me.lblXScalDateUpperLimit)
        Me.grpScaleXDate.Controls.Add(Me.ucrNudDateBreak)
        Me.grpScaleXDate.Controls.Add(Me.ucrDtpLowerLimit)
        Me.grpScaleXDate.Controls.Add(Me.ucrDtpUpperLimit)
        Me.grpScaleXDate.Controls.Add(Me.ucrChkLimits)
        Me.grpScaleXDate.Controls.Add(Me.ucrChkBreaks)
        resources.ApplyResources(Me.grpScaleXDate, "grpScaleXDate")
        Me.grpScaleXDate.Name = "grpScaleXDate"
        Me.grpScaleXDate.TabStop = False
        '
        'ucrInputComboDateLabel
        '
        Me.ucrInputComboDateLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputComboDateLabel.GetSetSelectedIndex = -1
        Me.ucrInputComboDateLabel.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboDateLabel, "ucrInputComboDateLabel")
        Me.ucrInputComboDateLabel.Name = "ucrInputComboDateLabel"
        '
        'ucrChkDateLabels
        '
        Me.ucrChkDateLabels.Checked = False
        resources.ApplyResources(Me.ucrChkDateLabels, "ucrChkDateLabels")
        Me.ucrChkDateLabels.Name = "ucrChkDateLabels"
        '
        'ucrInputComboDateBreak
        '
        Me.ucrInputComboDateBreak.AddQuotesIfUnrecognised = True
        Me.ucrInputComboDateBreak.GetSetSelectedIndex = -1
        Me.ucrInputComboDateBreak.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboDateBreak, "ucrInputComboDateBreak")
        Me.ucrInputComboDateBreak.Name = "ucrInputComboDateBreak"
        '
        'lbXscaleDateLowerLimit
        '
        resources.ApplyResources(Me.lbXscaleDateLowerLimit, "lbXscaleDateLowerLimit")
        Me.lbXscaleDateLowerLimit.Name = "lbXscaleDateLowerLimit"
        '
        'lblXScalDateUpperLimit
        '
        resources.ApplyResources(Me.lblXScalDateUpperLimit, "lblXScalDateUpperLimit")
        Me.lblXScalDateUpperLimit.Name = "lblXScalDateUpperLimit"
        '
        'ucrNudDateBreak
        '
        Me.ucrNudDateBreak.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDateBreak.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudDateBreak, "ucrNudDateBreak")
        Me.ucrNudDateBreak.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDateBreak.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDateBreak.Name = "ucrNudDateBreak"
        Me.ucrNudDateBreak.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrDtpLowerLimit
        '
        resources.ApplyResources(Me.ucrDtpLowerLimit, "ucrDtpLowerLimit")
        Me.ucrDtpLowerLimit.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpLowerLimit.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpLowerLimit.Name = "ucrDtpLowerLimit"
        '
        'ucrDtpUpperLimit
        '
        resources.ApplyResources(Me.ucrDtpUpperLimit, "ucrDtpUpperLimit")
        Me.ucrDtpUpperLimit.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpUpperLimit.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpUpperLimit.Name = "ucrDtpUpperLimit"
        '
        'ucrChkLimits
        '
        Me.ucrChkLimits.Checked = False
        resources.ApplyResources(Me.ucrChkLimits, "ucrChkLimits")
        Me.ucrChkLimits.Name = "ucrChkLimits"
        '
        'ucrChkBreaks
        '
        Me.ucrChkBreaks.Checked = False
        resources.ApplyResources(Me.ucrChkBreaks, "ucrChkBreaks")
        Me.ucrChkBreaks.Name = "ucrChkBreaks"
        '
        'ucrInputAxisType
        '
        Me.ucrInputAxisType.AddQuotesIfUnrecognised = True
        Me.ucrInputAxisType.GetSetSelectedIndex = -1
        Me.ucrInputAxisType.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputAxisType, "ucrInputAxisType")
        Me.ucrInputAxisType.Name = "ucrInputAxisType"
        '
        'grpAxes
        '
        Me.grpAxes.Controls.Add(Me.ucrChkXAxisLabelSize)
        Me.grpAxes.Controls.Add(Me.rdoAutoXAxis)
        Me.grpAxes.Controls.Add(Me.ucrNudXaxisLabelSize)
        Me.grpAxes.Controls.Add(Me.ucrInputXAxisTitle)
        Me.grpAxes.Controls.Add(Me.ucrChkXAxisAngle)
        Me.grpAxes.Controls.Add(Me.rdoNoTitleXAxisTitle)
        Me.grpAxes.Controls.Add(Me.ucrNudXAxisAngle)
        Me.grpAxes.Controls.Add(Me.rdoSpecifyXAxisTitle)
        Me.grpAxes.Controls.Add(Me.ucrPnlXAxisTitle)
        resources.ApplyResources(Me.grpAxes, "grpAxes")
        Me.grpAxes.Name = "grpAxes"
        Me.grpAxes.TabStop = False
        '
        'ucrChkXAxisLabelSize
        '
        Me.ucrChkXAxisLabelSize.Checked = False
        resources.ApplyResources(Me.ucrChkXAxisLabelSize, "ucrChkXAxisLabelSize")
        Me.ucrChkXAxisLabelSize.Name = "ucrChkXAxisLabelSize"
        '
        'rdoAutoXAxis
        '
        resources.ApplyResources(Me.rdoAutoXAxis, "rdoAutoXAxis")
        Me.rdoAutoXAxis.Name = "rdoAutoXAxis"
        Me.rdoAutoXAxis.TabStop = True
        Me.rdoAutoXAxis.UseVisualStyleBackColor = True
        '
        'ucrNudXaxisLabelSize
        '
        Me.ucrNudXaxisLabelSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisLabelSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudXaxisLabelSize, "ucrNudXaxisLabelSize")
        Me.ucrNudXaxisLabelSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXaxisLabelSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisLabelSize.Name = "ucrNudXaxisLabelSize"
        Me.ucrNudXaxisLabelSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputXAxisTitle
        '
        Me.ucrInputXAxisTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputXAxisTitle.IsMultiline = False
        Me.ucrInputXAxisTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXAxisTitle, "ucrInputXAxisTitle")
        Me.ucrInputXAxisTitle.Name = "ucrInputXAxisTitle"
        '
        'ucrChkXAxisAngle
        '
        Me.ucrChkXAxisAngle.Checked = False
        resources.ApplyResources(Me.ucrChkXAxisAngle, "ucrChkXAxisAngle")
        Me.ucrChkXAxisAngle.Name = "ucrChkXAxisAngle"
        '
        'rdoNoTitleXAxisTitle
        '
        resources.ApplyResources(Me.rdoNoTitleXAxisTitle, "rdoNoTitleXAxisTitle")
        Me.rdoNoTitleXAxisTitle.Name = "rdoNoTitleXAxisTitle"
        Me.rdoNoTitleXAxisTitle.TabStop = True
        Me.rdoNoTitleXAxisTitle.UseVisualStyleBackColor = True
        '
        'ucrNudXAxisAngle
        '
        Me.ucrNudXAxisAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudXAxisAngle, "ucrNudXAxisAngle")
        Me.ucrNudXAxisAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAxisAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisAngle.Name = "ucrNudXAxisAngle"
        Me.ucrNudXAxisAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoSpecifyXAxisTitle
        '
        resources.ApplyResources(Me.rdoSpecifyXAxisTitle, "rdoSpecifyXAxisTitle")
        Me.rdoSpecifyXAxisTitle.Name = "rdoSpecifyXAxisTitle"
        Me.rdoSpecifyXAxisTitle.TabStop = True
        Me.rdoSpecifyXAxisTitle.UseVisualStyleBackColor = True
        '
        'ucrPnlXAxisTitle
        '
        resources.ApplyResources(Me.ucrPnlXAxisTitle, "ucrPnlXAxisTitle")
        Me.ucrPnlXAxisTitle.Name = "ucrPnlXAxisTitle"
        '
        'tpYAxis
        '
        Me.tpYAxis.Controls.Add(Me.grpyAxisTitle)
        resources.ApplyResources(Me.tpYAxis, "tpYAxis")
        Me.tpYAxis.Name = "tpYAxis"
        Me.tpYAxis.UseVisualStyleBackColor = True
        '
        'grpyAxisTitle
        '
        Me.grpyAxisTitle.Controls.Add(Me.ucrChkYAxisAngle)
        Me.grpyAxisTitle.Controls.Add(Me.ucrNudYAxisAngle)
        Me.grpyAxisTitle.Controls.Add(Me.rdoAutoYAxis)
        Me.grpyAxisTitle.Controls.Add(Me.ucrInputYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.rdoNoYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.ucrNudYAxisTitleSize)
        Me.grpyAxisTitle.Controls.Add(Me.rdoSpecifyYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.UcrPnlYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.lblYAxisTitleSize)
        resources.ApplyResources(Me.grpyAxisTitle, "grpyAxisTitle")
        Me.grpyAxisTitle.Name = "grpyAxisTitle"
        Me.grpyAxisTitle.TabStop = False
        '
        'ucrChkYAxisAngle
        '
        Me.ucrChkYAxisAngle.Checked = False
        resources.ApplyResources(Me.ucrChkYAxisAngle, "ucrChkYAxisAngle")
        Me.ucrChkYAxisAngle.Name = "ucrChkYAxisAngle"
        '
        'ucrNudYAxisAngle
        '
        Me.ucrNudYAxisAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudYAxisAngle, "ucrNudYAxisAngle")
        Me.ucrNudYAxisAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYAxisAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisAngle.Name = "ucrNudYAxisAngle"
        Me.ucrNudYAxisAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoAutoYAxis
        '
        resources.ApplyResources(Me.rdoAutoYAxis, "rdoAutoYAxis")
        Me.rdoAutoYAxis.Name = "rdoAutoYAxis"
        Me.rdoAutoYAxis.TabStop = True
        Me.rdoAutoYAxis.UseVisualStyleBackColor = True
        '
        'ucrInputYAxisTitle
        '
        Me.ucrInputYAxisTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputYAxisTitle.IsMultiline = False
        Me.ucrInputYAxisTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYAxisTitle, "ucrInputYAxisTitle")
        Me.ucrInputYAxisTitle.Name = "ucrInputYAxisTitle"
        '
        'rdoNoYAxisTitle
        '
        resources.ApplyResources(Me.rdoNoYAxisTitle, "rdoNoYAxisTitle")
        Me.rdoNoYAxisTitle.Name = "rdoNoYAxisTitle"
        Me.rdoNoYAxisTitle.TabStop = True
        Me.rdoNoYAxisTitle.UseVisualStyleBackColor = True
        '
        'ucrNudYAxisTitleSize
        '
        Me.ucrNudYAxisTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudYAxisTitleSize, "ucrNudYAxisTitleSize")
        Me.ucrNudYAxisTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Name = "ucrNudYAxisTitleSize"
        Me.ucrNudYAxisTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoSpecifyYAxisTitle
        '
        resources.ApplyResources(Me.rdoSpecifyYAxisTitle, "rdoSpecifyYAxisTitle")
        Me.rdoSpecifyYAxisTitle.Name = "rdoSpecifyYAxisTitle"
        Me.rdoSpecifyYAxisTitle.TabStop = True
        Me.rdoSpecifyYAxisTitle.UseVisualStyleBackColor = True
        '
        'UcrPnlYAxisTitle
        '
        resources.ApplyResources(Me.UcrPnlYAxisTitle, "UcrPnlYAxisTitle")
        Me.UcrPnlYAxisTitle.Name = "UcrPnlYAxisTitle"
        '
        'lblYAxisTitleSize
        '
        resources.ApplyResources(Me.lblYAxisTitleSize, "lblYAxisTitleSize")
        Me.lblYAxisTitleSize.Name = "lblYAxisTitleSize"
        '
        'tpLegend
        '
        Me.tpLegend.Controls.Add(Me.ucrInputLegendPosition)
        Me.tpLegend.Controls.Add(Me.ucrChkLegendPosition)
        resources.ApplyResources(Me.tpLegend, "tpLegend")
        Me.tpLegend.Name = "tpLegend"
        Me.tpLegend.UseVisualStyleBackColor = True
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLegendPosition, "ucrInputLegendPosition")
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        '
        'ucrChkLegendPosition
        '
        Me.ucrChkLegendPosition.Checked = False
        resources.ApplyResources(Me.ucrChkLegendPosition, "ucrChkLegendPosition")
        Me.ucrChkLegendPosition.Name = "ucrChkLegendPosition"
        '
        'ucrButtonsInventoryplot
        '
        resources.ApplyResources(Me.ucrButtonsInventoryplot, "ucrButtonsInventoryplot")
        Me.ucrButtonsInventoryplot.Name = "ucrButtonsInventoryplot"
        '
        'ucrChkInputAxisType
        '
        Me.ucrChkInputAxisType.Checked = False
        resources.ApplyResources(Me.ucrChkInputAxisType, "ucrChkInputAxisType")
        Me.ucrChkInputAxisType.Name = "ucrChkInputAxisType"
        '
        'sdgInventoryPlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbInventory)
        Me.Controls.Add(Me.ucrButtonsInventoryplot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgInventoryPlot"
        Me.tbInventory.ResumeLayout(False)
        Me.tpTitles.ResumeLayout(False)
        Me.grpGraphTitles.ResumeLayout(False)
        Me.grpGraphTitles.PerformLayout()
        Me.tpXAxis.ResumeLayout(False)
        Me.grpScaleXDate.ResumeLayout(False)
        Me.grpScaleXDate.PerformLayout()
        Me.grpAxes.ResumeLayout(False)
        Me.grpAxes.PerformLayout()
        Me.tpYAxis.ResumeLayout(False)
        Me.grpyAxisTitle.ResumeLayout(False)
        Me.grpyAxisTitle.PerformLayout()
        Me.tpLegend.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsInventoryplot As ucrButtonsSubdialogue
    Friend WithEvents tbInventory As TabControl
    Friend WithEvents tpTitles As TabPage
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
    Friend WithEvents tpXAxis As TabPage
    Friend WithEvents ucrChkXAxisAngle As ucrCheck
    Friend WithEvents ucrNudXAxisAngle As ucrNud
    Friend WithEvents grpAxes As GroupBox
    Friend WithEvents rdoAutoXAxis As RadioButton
    Friend WithEvents ucrInputXAxisTitle As ucrInputTextBox
    Friend WithEvents rdoNoTitleXAxisTitle As RadioButton
    Friend WithEvents rdoSpecifyXAxisTitle As RadioButton
    Friend WithEvents ucrPnlXAxisTitle As UcrPanel
    Friend WithEvents ucrChkXAxisLabelSize As ucrCheck
    Friend WithEvents ucrNudXaxisLabelSize As ucrNud
    Friend WithEvents tpYAxis As TabPage
    Friend WithEvents grpyAxisTitle As GroupBox
    Friend WithEvents rdoAutoYAxis As RadioButton
    Friend WithEvents ucrInputYAxisTitle As ucrInputTextBox
    Friend WithEvents rdoNoYAxisTitle As RadioButton
    Friend WithEvents ucrNudYAxisTitleSize As ucrNud
    Friend WithEvents rdoSpecifyYAxisTitle As RadioButton
    Friend WithEvents UcrPnlYAxisTitle As UcrPanel
    Friend WithEvents lblYAxisTitleSize As Label
    Friend WithEvents tpLegend As TabPage
    Friend WithEvents ucrInputAxisType As ucrInputComboBox
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrChkLegendPosition As ucrCheck
    Friend WithEvents ucrChkYAxisAngle As ucrCheck
    Friend WithEvents ucrNudYAxisAngle As ucrNud
    Friend WithEvents grpScaleXDate As GroupBox
    Friend WithEvents ucrInputComboDateLabel As ucrInputComboBox
    Friend WithEvents ucrChkDateLabels As ucrCheck
    Friend WithEvents ucrInputComboDateBreak As ucrInputComboBox
    Friend WithEvents lbXscaleDateLowerLimit As Label
    Friend WithEvents lblXScalDateUpperLimit As Label
    Friend WithEvents ucrNudDateBreak As ucrNud
    Friend WithEvents ucrDtpLowerLimit As ucrDateTimePicker
    Friend WithEvents ucrDtpUpperLimit As ucrDateTimePicker
    Friend WithEvents ucrChkLimits As ucrCheck
    Friend WithEvents ucrChkBreaks As ucrCheck
    Friend WithEvents ucrChkInputAxisType As ucrCheck
End Class
