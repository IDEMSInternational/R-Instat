<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgPICSARainfallGraph
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgPICSARainfallGraph))
        Me.lblYInStepsOf = New System.Windows.Forms.Label()
        Me.lblYFrom = New System.Windows.Forms.Label()
        Me.lblYTo = New System.Windows.Forms.Label()
        Me.lblXTo = New System.Windows.Forms.Label()
        Me.lblXFrom = New System.Windows.Forms.Label()
        Me.lblXInStepsOf = New System.Windows.Forms.Label()
        Me.tbPICSA = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grpyAxisTitle = New System.Windows.Forms.GroupBox()
        Me.rdoAutoYAxis = New System.Windows.Forms.RadioButton()
        Me.ucrInputYAxisTitle = New instat.ucrInputTextBox()
        Me.UcrChkYAxisTitleSzie = New instat.ucrCheck()
        Me.rdoRemoveYAxisTitle = New System.Windows.Forms.RadioButton()
        Me.UcrNudYAxisTitleSzie = New instat.ucrNud()
        Me.rdoChangeYAxisTitle = New System.Windows.Forms.RadioButton()
        Me.UcrPnlYAxisTitle = New instat.UcrPanel()
        Me.grpAxes = New System.Windows.Forms.GroupBox()
        Me.rdoAutoXAxis = New System.Windows.Forms.RadioButton()
        Me.ucrInputXAxisTitle = New instat.ucrInputTextBox()
        Me.rdoRemoveXAxisTitle = New System.Windows.Forms.RadioButton()
        Me.rdoChangeXAxisTitle = New System.Windows.Forms.RadioButton()
        Me.ucrPnlXAxisTitle = New instat.UcrPanel()
        Me.UcrNudXAxisTitleSzie = New instat.ucrNud()
        Me.UcrChkXAxisTitleSzie = New instat.ucrCheck()
        Me.grpGraphTitles = New System.Windows.Forms.GroupBox()
        Me.UcrChkCaption = New instat.ucrCheck()
        Me.UcrChkSubTitle = New instat.ucrCheck()
        Me.UcrChkTitle = New instat.ucrCheck()
        Me.UcrNudCaptionSize = New instat.ucrNud()
        Me.UcrNudSubTitleSize = New instat.ucrNud()
        Me.UcrNudTitleSize = New instat.ucrNud()
        Me.ucrChkCaptionSize = New instat.ucrCheck()
        Me.UcrChkSubTitleSize = New instat.ucrCheck()
        Me.UcrChkTitleSize = New instat.ucrCheck()
        Me.ucrInputGraphcCaption = New instat.ucrInputTextBox()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.ucrInputGraphSubTitle = New instat.ucrInputTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grpXAxisLabels = New System.Windows.Forms.GroupBox()
        Me.ucrChkXAxisLabelSize = New instat.ucrCheck()
        Me.ucrChkXAxisAngle = New instat.ucrCheck()
        Me.ucrChkSpecifyXAxisTickMarks = New instat.ucrCheck()
        Me.ucrInputXFrom = New instat.ucrInputTextBox()
        Me.ucrInputXInStepsOf = New instat.ucrInputTextBox()
        Me.ucrNudXaxisLabelSize = New instat.ucrNud()
        Me.ucrInputXTo = New instat.ucrInputTextBox()
        Me.ucrNudXAxisAngle = New instat.ucrNud()
        Me.grpYAxisLabels = New System.Windows.Forms.GroupBox()
        Me.ucrInputLabelForDays = New instat.ucrInputComboBox()
        Me.ucrNudYAxisAngle = New instat.ucrNud()
        Me.ucrChkLabelForDays = New instat.ucrCheck()
        Me.ucrChkYAxisAngle = New instat.ucrCheck()
        Me.ucrChkYAxisLabelSize = New instat.ucrCheck()
        Me.ucrChkSpecifyYAxisTickMarks = New instat.ucrCheck()
        Me.ucrInputYFrom = New instat.ucrInputTextBox()
        Me.ucrNudYAxisLabelSize = New instat.ucrNud()
        Me.ucrInputYTo = New instat.ucrInputTextBox()
        Me.ucrInputYInStepsOf = New instat.ucrInputTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ucrChkAddMean = New instat.ucrCheck()
        Me.ucrChkAddMedian = New instat.ucrCheck()
        Me.ucrChkAddTerciles = New instat.ucrCheck()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.grpMinorGridLine = New System.Windows.Forms.GroupBox()
        Me.UcrNudMinorGridLineSize = New instat.ucrNud()
        Me.UcrChkMinorGridLineSize = New instat.ucrCheck()
        Me.UcrInputMinorGridLineTpe = New instat.ucrInputComboBox()
        Me.UcrInputMinorGridLineColour = New instat.ucrInputComboBox()
        Me.UcrChkMinorGridLineType = New instat.ucrCheck()
        Me.UcrChkMinorGridLineColour = New instat.ucrCheck()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UcrNudBorderSize = New instat.ucrNud()
        Me.UcrChkBorderSize = New instat.ucrCheck()
        Me.UcrInputBorderLinetype = New instat.ucrInputComboBox()
        Me.UcrInputBorderColour = New instat.ucrInputComboBox()
        Me.ucrChkBorderLineType = New instat.ucrCheck()
        Me.ucrChkBorderColour = New instat.ucrCheck()
        Me.grpMajorGridLines = New System.Windows.Forms.GroupBox()
        Me.UcrNudMajorGridLineSize = New instat.ucrNud()
        Me.UcrChkMajorGridLineSize = New instat.ucrCheck()
        Me.UcrInputMajorGridLineLinetype = New instat.ucrInputComboBox()
        Me.UcrInputMajorGridLineColour = New instat.ucrInputComboBox()
        Me.UcrChkMajorGridLinetype = New instat.ucrCheck()
        Me.UcrChkMajorGridLineColour = New instat.ucrCheck()
        Me.grpPnlBackground = New System.Windows.Forms.GroupBox()
        Me.ucrNudPnlBackgroundSize = New instat.ucrNud()
        Me.UcrInputPnlBackgroundFill = New instat.ucrInputComboBox()
        Me.UcrInputPnlBackgroundLinetype = New instat.ucrInputComboBox()
        Me.UcrInputPnlBackgroundColour = New instat.ucrInputComboBox()
        Me.UcrChkPnlBackgroundSize = New instat.ucrCheck()
        Me.UcrChkPnlBackgroundLineType = New instat.ucrCheck()
        Me.UcrChkPnlBackgroundFill = New instat.ucrCheck()
        Me.ucrChkPnlBackgroundColour = New instat.ucrCheck()
        Me.ucrSdgPICSARainfalbuttons = New instat.ucrButtonsSubdialogue()
        Me.tbPICSA.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpyAxisTitle.SuspendLayout()
        Me.grpAxes.SuspendLayout()
        Me.grpGraphTitles.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grpXAxisLabels.SuspendLayout()
        Me.grpYAxisLabels.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.grpMinorGridLine.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpMajorGridLines.SuspendLayout()
        Me.grpPnlBackground.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblYInStepsOf
        '
        resources.ApplyResources(Me.lblYInStepsOf, "lblYInStepsOf")
        Me.lblYInStepsOf.Name = "lblYInStepsOf"
        '
        'lblYFrom
        '
        resources.ApplyResources(Me.lblYFrom, "lblYFrom")
        Me.lblYFrom.Name = "lblYFrom"
        '
        'lblYTo
        '
        resources.ApplyResources(Me.lblYTo, "lblYTo")
        Me.lblYTo.Name = "lblYTo"
        '
        'lblXTo
        '
        resources.ApplyResources(Me.lblXTo, "lblXTo")
        Me.lblXTo.Name = "lblXTo"
        '
        'lblXFrom
        '
        resources.ApplyResources(Me.lblXFrom, "lblXFrom")
        Me.lblXFrom.Name = "lblXFrom"
        '
        'lblXInStepsOf
        '
        resources.ApplyResources(Me.lblXInStepsOf, "lblXInStepsOf")
        Me.lblXInStepsOf.Name = "lblXInStepsOf"
        '
        'tbPICSA
        '
        Me.tbPICSA.Controls.Add(Me.TabPage1)
        Me.tbPICSA.Controls.Add(Me.TabPage2)
        Me.tbPICSA.Controls.Add(Me.TabPage3)
        Me.tbPICSA.Controls.Add(Me.TabPage4)
        resources.ApplyResources(Me.tbPICSA, "tbPICSA")
        Me.tbPICSA.Name = "tbPICSA"
        Me.tbPICSA.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grpyAxisTitle)
        Me.TabPage1.Controls.Add(Me.grpAxes)
        Me.TabPage1.Controls.Add(Me.grpGraphTitles)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grpyAxisTitle
        '
        Me.grpyAxisTitle.Controls.Add(Me.rdoAutoYAxis)
        Me.grpyAxisTitle.Controls.Add(Me.ucrInputYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.UcrChkYAxisTitleSzie)
        Me.grpyAxisTitle.Controls.Add(Me.rdoRemoveYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.UcrNudYAxisTitleSzie)
        Me.grpyAxisTitle.Controls.Add(Me.rdoChangeYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.UcrPnlYAxisTitle)
        resources.ApplyResources(Me.grpyAxisTitle, "grpyAxisTitle")
        Me.grpyAxisTitle.Name = "grpyAxisTitle"
        Me.grpyAxisTitle.TabStop = False
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
        'UcrChkYAxisTitleSzie
        '
        Me.UcrChkYAxisTitleSzie.Checked = False
        resources.ApplyResources(Me.UcrChkYAxisTitleSzie, "UcrChkYAxisTitleSzie")
        Me.UcrChkYAxisTitleSzie.Name = "UcrChkYAxisTitleSzie"
        '
        'rdoRemoveYAxisTitle
        '
        resources.ApplyResources(Me.rdoRemoveYAxisTitle, "rdoRemoveYAxisTitle")
        Me.rdoRemoveYAxisTitle.Name = "rdoRemoveYAxisTitle"
        Me.rdoRemoveYAxisTitle.TabStop = True
        Me.rdoRemoveYAxisTitle.UseVisualStyleBackColor = True
        '
        'UcrNudYAxisTitleSzie
        '
        Me.UcrNudYAxisTitleSzie.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudYAxisTitleSzie.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.UcrNudYAxisTitleSzie, "UcrNudYAxisTitleSzie")
        Me.UcrNudYAxisTitleSzie.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudYAxisTitleSzie.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudYAxisTitleSzie.Name = "UcrNudYAxisTitleSzie"
        Me.UcrNudYAxisTitleSzie.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoChangeYAxisTitle
        '
        resources.ApplyResources(Me.rdoChangeYAxisTitle, "rdoChangeYAxisTitle")
        Me.rdoChangeYAxisTitle.Name = "rdoChangeYAxisTitle"
        Me.rdoChangeYAxisTitle.TabStop = True
        Me.rdoChangeYAxisTitle.UseVisualStyleBackColor = True
        '
        'UcrPnlYAxisTitle
        '
        resources.ApplyResources(Me.UcrPnlYAxisTitle, "UcrPnlYAxisTitle")
        Me.UcrPnlYAxisTitle.Name = "UcrPnlYAxisTitle"
        '
        'grpAxes
        '
        Me.grpAxes.Controls.Add(Me.rdoAutoXAxis)
        Me.grpAxes.Controls.Add(Me.ucrInputXAxisTitle)
        Me.grpAxes.Controls.Add(Me.rdoRemoveXAxisTitle)
        Me.grpAxes.Controls.Add(Me.rdoChangeXAxisTitle)
        Me.grpAxes.Controls.Add(Me.ucrPnlXAxisTitle)
        Me.grpAxes.Controls.Add(Me.UcrNudXAxisTitleSzie)
        Me.grpAxes.Controls.Add(Me.UcrChkXAxisTitleSzie)
        resources.ApplyResources(Me.grpAxes, "grpAxes")
        Me.grpAxes.Name = "grpAxes"
        Me.grpAxes.TabStop = False
        '
        'rdoAutoXAxis
        '
        resources.ApplyResources(Me.rdoAutoXAxis, "rdoAutoXAxis")
        Me.rdoAutoXAxis.Name = "rdoAutoXAxis"
        Me.rdoAutoXAxis.TabStop = True
        Me.rdoAutoXAxis.UseVisualStyleBackColor = True
        '
        'ucrInputXAxisTitle
        '
        Me.ucrInputXAxisTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputXAxisTitle.IsMultiline = False
        Me.ucrInputXAxisTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXAxisTitle, "ucrInputXAxisTitle")
        Me.ucrInputXAxisTitle.Name = "ucrInputXAxisTitle"
        '
        'rdoRemoveXAxisTitle
        '
        resources.ApplyResources(Me.rdoRemoveXAxisTitle, "rdoRemoveXAxisTitle")
        Me.rdoRemoveXAxisTitle.Name = "rdoRemoveXAxisTitle"
        Me.rdoRemoveXAxisTitle.TabStop = True
        Me.rdoRemoveXAxisTitle.UseVisualStyleBackColor = True
        '
        'rdoChangeXAxisTitle
        '
        resources.ApplyResources(Me.rdoChangeXAxisTitle, "rdoChangeXAxisTitle")
        Me.rdoChangeXAxisTitle.Name = "rdoChangeXAxisTitle"
        Me.rdoChangeXAxisTitle.TabStop = True
        Me.rdoChangeXAxisTitle.UseVisualStyleBackColor = True
        '
        'ucrPnlXAxisTitle
        '
        resources.ApplyResources(Me.ucrPnlXAxisTitle, "ucrPnlXAxisTitle")
        Me.ucrPnlXAxisTitle.Name = "ucrPnlXAxisTitle"
        '
        'UcrNudXAxisTitleSzie
        '
        Me.UcrNudXAxisTitleSzie.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudXAxisTitleSzie.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.UcrNudXAxisTitleSzie, "UcrNudXAxisTitleSzie")
        Me.UcrNudXAxisTitleSzie.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudXAxisTitleSzie.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudXAxisTitleSzie.Name = "UcrNudXAxisTitleSzie"
        Me.UcrNudXAxisTitleSzie.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrChkXAxisTitleSzie
        '
        Me.UcrChkXAxisTitleSzie.Checked = False
        resources.ApplyResources(Me.UcrChkXAxisTitleSzie, "UcrChkXAxisTitleSzie")
        Me.UcrChkXAxisTitleSzie.Name = "UcrChkXAxisTitleSzie"
        '
        'grpGraphTitles
        '
        Me.grpGraphTitles.Controls.Add(Me.UcrChkCaption)
        Me.grpGraphTitles.Controls.Add(Me.UcrChkSubTitle)
        Me.grpGraphTitles.Controls.Add(Me.UcrChkTitle)
        Me.grpGraphTitles.Controls.Add(Me.UcrNudCaptionSize)
        Me.grpGraphTitles.Controls.Add(Me.UcrNudSubTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.UcrNudTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.ucrChkCaptionSize)
        Me.grpGraphTitles.Controls.Add(Me.UcrChkSubTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.UcrChkTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.ucrInputGraphcCaption)
        Me.grpGraphTitles.Controls.Add(Me.ucrInputGraphTitle)
        Me.grpGraphTitles.Controls.Add(Me.ucrInputGraphSubTitle)
        resources.ApplyResources(Me.grpGraphTitles, "grpGraphTitles")
        Me.grpGraphTitles.Name = "grpGraphTitles"
        Me.grpGraphTitles.TabStop = False
        '
        'UcrChkCaption
        '
        Me.UcrChkCaption.Checked = False
        resources.ApplyResources(Me.UcrChkCaption, "UcrChkCaption")
        Me.UcrChkCaption.Name = "UcrChkCaption"
        '
        'UcrChkSubTitle
        '
        Me.UcrChkSubTitle.Checked = False
        resources.ApplyResources(Me.UcrChkSubTitle, "UcrChkSubTitle")
        Me.UcrChkSubTitle.Name = "UcrChkSubTitle"
        '
        'UcrChkTitle
        '
        Me.UcrChkTitle.Checked = False
        resources.ApplyResources(Me.UcrChkTitle, "UcrChkTitle")
        Me.UcrChkTitle.Name = "UcrChkTitle"
        '
        'UcrNudCaptionSize
        '
        Me.UcrNudCaptionSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudCaptionSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.UcrNudCaptionSize, "UcrNudCaptionSize")
        Me.UcrNudCaptionSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudCaptionSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudCaptionSize.Name = "UcrNudCaptionSize"
        Me.UcrNudCaptionSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrNudSubTitleSize
        '
        Me.UcrNudSubTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudSubTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.UcrNudSubTitleSize, "UcrNudSubTitleSize")
        Me.UcrNudSubTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudSubTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudSubTitleSize.Name = "UcrNudSubTitleSize"
        Me.UcrNudSubTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrNudTitleSize
        '
        Me.UcrNudTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.UcrNudTitleSize, "UcrNudTitleSize")
        Me.UcrNudTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudTitleSize.Name = "UcrNudTitleSize"
        Me.UcrNudTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkCaptionSize
        '
        Me.ucrChkCaptionSize.Checked = False
        resources.ApplyResources(Me.ucrChkCaptionSize, "ucrChkCaptionSize")
        Me.ucrChkCaptionSize.Name = "ucrChkCaptionSize"
        '
        'UcrChkSubTitleSize
        '
        Me.UcrChkSubTitleSize.Checked = False
        resources.ApplyResources(Me.UcrChkSubTitleSize, "UcrChkSubTitleSize")
        Me.UcrChkSubTitleSize.Name = "UcrChkSubTitleSize"
        '
        'UcrChkTitleSize
        '
        Me.UcrChkTitleSize.Checked = False
        resources.ApplyResources(Me.UcrChkTitleSize, "UcrChkTitleSize")
        Me.UcrChkTitleSize.Name = "UcrChkTitleSize"
        '
        'ucrInputGraphcCaption
        '
        Me.ucrInputGraphcCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphcCaption.IsMultiline = False
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grpXAxisLabels)
        Me.TabPage2.Controls.Add(Me.grpYAxisLabels)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grpXAxisLabels
        '
        Me.grpXAxisLabels.Controls.Add(Me.ucrChkXAxisLabelSize)
        Me.grpXAxisLabels.Controls.Add(Me.ucrChkXAxisAngle)
        Me.grpXAxisLabels.Controls.Add(Me.ucrChkSpecifyXAxisTickMarks)
        Me.grpXAxisLabels.Controls.Add(Me.lblXFrom)
        Me.grpXAxisLabels.Controls.Add(Me.ucrInputXFrom)
        Me.grpXAxisLabels.Controls.Add(Me.ucrInputXInStepsOf)
        Me.grpXAxisLabels.Controls.Add(Me.ucrNudXaxisLabelSize)
        Me.grpXAxisLabels.Controls.Add(Me.ucrInputXTo)
        Me.grpXAxisLabels.Controls.Add(Me.ucrNudXAxisAngle)
        Me.grpXAxisLabels.Controls.Add(Me.lblXInStepsOf)
        Me.grpXAxisLabels.Controls.Add(Me.lblXTo)
        resources.ApplyResources(Me.grpXAxisLabels, "grpXAxisLabels")
        Me.grpXAxisLabels.Name = "grpXAxisLabels"
        Me.grpXAxisLabels.TabStop = False
        '
        'ucrChkXAxisLabelSize
        '
        Me.ucrChkXAxisLabelSize.Checked = False
        resources.ApplyResources(Me.ucrChkXAxisLabelSize, "ucrChkXAxisLabelSize")
        Me.ucrChkXAxisLabelSize.Name = "ucrChkXAxisLabelSize"
        '
        'ucrChkXAxisAngle
        '
        Me.ucrChkXAxisAngle.Checked = False
        resources.ApplyResources(Me.ucrChkXAxisAngle, "ucrChkXAxisAngle")
        Me.ucrChkXAxisAngle.Name = "ucrChkXAxisAngle"
        '
        'ucrChkSpecifyXAxisTickMarks
        '
        Me.ucrChkSpecifyXAxisTickMarks.Checked = False
        resources.ApplyResources(Me.ucrChkSpecifyXAxisTickMarks, "ucrChkSpecifyXAxisTickMarks")
        Me.ucrChkSpecifyXAxisTickMarks.Name = "ucrChkSpecifyXAxisTickMarks"
        '
        'ucrInputXFrom
        '
        Me.ucrInputXFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputXFrom.IsMultiline = False
        Me.ucrInputXFrom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXFrom, "ucrInputXFrom")
        Me.ucrInputXFrom.Name = "ucrInputXFrom"
        '
        'ucrInputXInStepsOf
        '
        Me.ucrInputXInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputXInStepsOf.IsMultiline = False
        Me.ucrInputXInStepsOf.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXInStepsOf, "ucrInputXInStepsOf")
        Me.ucrInputXInStepsOf.Name = "ucrInputXInStepsOf"
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
        'ucrInputXTo
        '
        Me.ucrInputXTo.AddQuotesIfUnrecognised = True
        Me.ucrInputXTo.IsMultiline = False
        Me.ucrInputXTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXTo, "ucrInputXTo")
        Me.ucrInputXTo.Name = "ucrInputXTo"
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
        'grpYAxisLabels
        '
        Me.grpYAxisLabels.Controls.Add(Me.ucrInputLabelForDays)
        Me.grpYAxisLabels.Controls.Add(Me.ucrNudYAxisAngle)
        Me.grpYAxisLabels.Controls.Add(Me.ucrChkLabelForDays)
        Me.grpYAxisLabels.Controls.Add(Me.ucrChkYAxisAngle)
        Me.grpYAxisLabels.Controls.Add(Me.ucrChkYAxisLabelSize)
        Me.grpYAxisLabels.Controls.Add(Me.ucrChkSpecifyYAxisTickMarks)
        Me.grpYAxisLabels.Controls.Add(Me.ucrInputYFrom)
        Me.grpYAxisLabels.Controls.Add(Me.lblYFrom)
        Me.grpYAxisLabels.Controls.Add(Me.ucrNudYAxisLabelSize)
        Me.grpYAxisLabels.Controls.Add(Me.ucrInputYTo)
        Me.grpYAxisLabels.Controls.Add(Me.lblYTo)
        Me.grpYAxisLabels.Controls.Add(Me.lblYInStepsOf)
        Me.grpYAxisLabels.Controls.Add(Me.ucrInputYInStepsOf)
        resources.ApplyResources(Me.grpYAxisLabels, "grpYAxisLabels")
        Me.grpYAxisLabels.Name = "grpYAxisLabels"
        Me.grpYAxisLabels.TabStop = False
        '
        'ucrInputLabelForDays
        '
        Me.ucrInputLabelForDays.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelForDays.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLabelForDays, "ucrInputLabelForDays")
        Me.ucrInputLabelForDays.Name = "ucrInputLabelForDays"
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
        'ucrChkLabelForDays
        '
        Me.ucrChkLabelForDays.Checked = False
        resources.ApplyResources(Me.ucrChkLabelForDays, "ucrChkLabelForDays")
        Me.ucrChkLabelForDays.Name = "ucrChkLabelForDays"
        '
        'ucrChkYAxisAngle
        '
        Me.ucrChkYAxisAngle.Checked = False
        resources.ApplyResources(Me.ucrChkYAxisAngle, "ucrChkYAxisAngle")
        Me.ucrChkYAxisAngle.Name = "ucrChkYAxisAngle"
        '
        'ucrChkYAxisLabelSize
        '
        Me.ucrChkYAxisLabelSize.Checked = False
        resources.ApplyResources(Me.ucrChkYAxisLabelSize, "ucrChkYAxisLabelSize")
        Me.ucrChkYAxisLabelSize.Name = "ucrChkYAxisLabelSize"
        '
        'ucrChkSpecifyYAxisTickMarks
        '
        Me.ucrChkSpecifyYAxisTickMarks.Checked = False
        resources.ApplyResources(Me.ucrChkSpecifyYAxisTickMarks, "ucrChkSpecifyYAxisTickMarks")
        Me.ucrChkSpecifyYAxisTickMarks.Name = "ucrChkSpecifyYAxisTickMarks"
        '
        'ucrInputYFrom
        '
        Me.ucrInputYFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputYFrom.IsMultiline = False
        Me.ucrInputYFrom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYFrom, "ucrInputYFrom")
        Me.ucrInputYFrom.Name = "ucrInputYFrom"
        '
        'ucrNudYAxisLabelSize
        '
        Me.ucrNudYAxisLabelSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisLabelSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudYAxisLabelSize, "ucrNudYAxisLabelSize")
        Me.ucrNudYAxisLabelSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYAxisLabelSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisLabelSize.Name = "ucrNudYAxisLabelSize"
        Me.ucrNudYAxisLabelSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputYTo
        '
        Me.ucrInputYTo.AddQuotesIfUnrecognised = True
        Me.ucrInputYTo.IsMultiline = False
        Me.ucrInputYTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYTo, "ucrInputYTo")
        Me.ucrInputYTo.Name = "ucrInputYTo"
        '
        'ucrInputYInStepsOf
        '
        Me.ucrInputYInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputYInStepsOf.IsMultiline = False
        Me.ucrInputYInStepsOf.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYInStepsOf, "ucrInputYInStepsOf")
        Me.ucrInputYInStepsOf.Name = "ucrInputYInStepsOf"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ucrChkAddMean)
        Me.TabPage3.Controls.Add(Me.ucrChkAddMedian)
        Me.TabPage3.Controls.Add(Me.ucrChkAddTerciles)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ucrChkAddMean
        '
        Me.ucrChkAddMean.Checked = False
        resources.ApplyResources(Me.ucrChkAddMean, "ucrChkAddMean")
        Me.ucrChkAddMean.Name = "ucrChkAddMean"
        '
        'ucrChkAddMedian
        '
        Me.ucrChkAddMedian.Checked = False
        resources.ApplyResources(Me.ucrChkAddMedian, "ucrChkAddMedian")
        Me.ucrChkAddMedian.Name = "ucrChkAddMedian"
        '
        'ucrChkAddTerciles
        '
        Me.ucrChkAddTerciles.Checked = False
        resources.ApplyResources(Me.ucrChkAddTerciles, "ucrChkAddTerciles")
        Me.ucrChkAddTerciles.Name = "ucrChkAddTerciles"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.grpMinorGridLine)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.grpMajorGridLines)
        Me.TabPage4.Controls.Add(Me.grpPnlBackground)
        resources.ApplyResources(Me.TabPage4, "TabPage4")
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'grpMinorGridLine
        '
        Me.grpMinorGridLine.Controls.Add(Me.UcrNudMinorGridLineSize)
        Me.grpMinorGridLine.Controls.Add(Me.UcrChkMinorGridLineSize)
        Me.grpMinorGridLine.Controls.Add(Me.UcrInputMinorGridLineTpe)
        Me.grpMinorGridLine.Controls.Add(Me.UcrInputMinorGridLineColour)
        Me.grpMinorGridLine.Controls.Add(Me.UcrChkMinorGridLineType)
        Me.grpMinorGridLine.Controls.Add(Me.UcrChkMinorGridLineColour)
        resources.ApplyResources(Me.grpMinorGridLine, "grpMinorGridLine")
        Me.grpMinorGridLine.Name = "grpMinorGridLine"
        Me.grpMinorGridLine.TabStop = False
        '
        'UcrNudMinorGridLineSize
        '
        Me.UcrNudMinorGridLineSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudMinorGridLineSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.UcrNudMinorGridLineSize, "UcrNudMinorGridLineSize")
        Me.UcrNudMinorGridLineSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudMinorGridLineSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudMinorGridLineSize.Name = "UcrNudMinorGridLineSize"
        Me.UcrNudMinorGridLineSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrChkMinorGridLineSize
        '
        Me.UcrChkMinorGridLineSize.Checked = False
        resources.ApplyResources(Me.UcrChkMinorGridLineSize, "UcrChkMinorGridLineSize")
        Me.UcrChkMinorGridLineSize.Name = "UcrChkMinorGridLineSize"
        '
        'UcrInputMinorGridLineTpe
        '
        Me.UcrInputMinorGridLineTpe.AddQuotesIfUnrecognised = True
        Me.UcrInputMinorGridLineTpe.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputMinorGridLineTpe, "UcrInputMinorGridLineTpe")
        Me.UcrInputMinorGridLineTpe.Name = "UcrInputMinorGridLineTpe"
        '
        'UcrInputMinorGridLineColour
        '
        Me.UcrInputMinorGridLineColour.AddQuotesIfUnrecognised = True
        Me.UcrInputMinorGridLineColour.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputMinorGridLineColour, "UcrInputMinorGridLineColour")
        Me.UcrInputMinorGridLineColour.Name = "UcrInputMinorGridLineColour"
        '
        'UcrChkMinorGridLineType
        '
        Me.UcrChkMinorGridLineType.Checked = False
        resources.ApplyResources(Me.UcrChkMinorGridLineType, "UcrChkMinorGridLineType")
        Me.UcrChkMinorGridLineType.Name = "UcrChkMinorGridLineType"
        '
        'UcrChkMinorGridLineColour
        '
        Me.UcrChkMinorGridLineColour.Checked = False
        resources.ApplyResources(Me.UcrChkMinorGridLineColour, "UcrChkMinorGridLineColour")
        Me.UcrChkMinorGridLineColour.Name = "UcrChkMinorGridLineColour"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UcrNudBorderSize)
        Me.GroupBox1.Controls.Add(Me.UcrChkBorderSize)
        Me.GroupBox1.Controls.Add(Me.UcrInputBorderLinetype)
        Me.GroupBox1.Controls.Add(Me.UcrInputBorderColour)
        Me.GroupBox1.Controls.Add(Me.ucrChkBorderLineType)
        Me.GroupBox1.Controls.Add(Me.ucrChkBorderColour)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'UcrNudBorderSize
        '
        Me.UcrNudBorderSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudBorderSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.UcrNudBorderSize, "UcrNudBorderSize")
        Me.UcrNudBorderSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudBorderSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudBorderSize.Name = "UcrNudBorderSize"
        Me.UcrNudBorderSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrChkBorderSize
        '
        Me.UcrChkBorderSize.Checked = False
        resources.ApplyResources(Me.UcrChkBorderSize, "UcrChkBorderSize")
        Me.UcrChkBorderSize.Name = "UcrChkBorderSize"
        '
        'UcrInputBorderLinetype
        '
        Me.UcrInputBorderLinetype.AddQuotesIfUnrecognised = True
        Me.UcrInputBorderLinetype.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputBorderLinetype, "UcrInputBorderLinetype")
        Me.UcrInputBorderLinetype.Name = "UcrInputBorderLinetype"
        '
        'UcrInputBorderColour
        '
        Me.UcrInputBorderColour.AddQuotesIfUnrecognised = True
        Me.UcrInputBorderColour.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputBorderColour, "UcrInputBorderColour")
        Me.UcrInputBorderColour.Name = "UcrInputBorderColour"
        '
        'ucrChkBorderLineType
        '
        Me.ucrChkBorderLineType.Checked = False
        resources.ApplyResources(Me.ucrChkBorderLineType, "ucrChkBorderLineType")
        Me.ucrChkBorderLineType.Name = "ucrChkBorderLineType"
        '
        'ucrChkBorderColour
        '
        Me.ucrChkBorderColour.Checked = False
        resources.ApplyResources(Me.ucrChkBorderColour, "ucrChkBorderColour")
        Me.ucrChkBorderColour.Name = "ucrChkBorderColour"
        '
        'grpMajorGridLines
        '
        Me.grpMajorGridLines.Controls.Add(Me.UcrNudMajorGridLineSize)
        Me.grpMajorGridLines.Controls.Add(Me.UcrChkMajorGridLineSize)
        Me.grpMajorGridLines.Controls.Add(Me.UcrInputMajorGridLineLinetype)
        Me.grpMajorGridLines.Controls.Add(Me.UcrInputMajorGridLineColour)
        Me.grpMajorGridLines.Controls.Add(Me.UcrChkMajorGridLinetype)
        Me.grpMajorGridLines.Controls.Add(Me.UcrChkMajorGridLineColour)
        resources.ApplyResources(Me.grpMajorGridLines, "grpMajorGridLines")
        Me.grpMajorGridLines.Name = "grpMajorGridLines"
        Me.grpMajorGridLines.TabStop = False
        '
        'UcrNudMajorGridLineSize
        '
        Me.UcrNudMajorGridLineSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudMajorGridLineSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.UcrNudMajorGridLineSize, "UcrNudMajorGridLineSize")
        Me.UcrNudMajorGridLineSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudMajorGridLineSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudMajorGridLineSize.Name = "UcrNudMajorGridLineSize"
        Me.UcrNudMajorGridLineSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrChkMajorGridLineSize
        '
        Me.UcrChkMajorGridLineSize.Checked = False
        resources.ApplyResources(Me.UcrChkMajorGridLineSize, "UcrChkMajorGridLineSize")
        Me.UcrChkMajorGridLineSize.Name = "UcrChkMajorGridLineSize"
        '
        'UcrInputMajorGridLineLinetype
        '
        Me.UcrInputMajorGridLineLinetype.AddQuotesIfUnrecognised = True
        Me.UcrInputMajorGridLineLinetype.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputMajorGridLineLinetype, "UcrInputMajorGridLineLinetype")
        Me.UcrInputMajorGridLineLinetype.Name = "UcrInputMajorGridLineLinetype"
        '
        'UcrInputMajorGridLineColour
        '
        Me.UcrInputMajorGridLineColour.AddQuotesIfUnrecognised = True
        Me.UcrInputMajorGridLineColour.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputMajorGridLineColour, "UcrInputMajorGridLineColour")
        Me.UcrInputMajorGridLineColour.Name = "UcrInputMajorGridLineColour"
        '
        'UcrChkMajorGridLinetype
        '
        Me.UcrChkMajorGridLinetype.Checked = False
        resources.ApplyResources(Me.UcrChkMajorGridLinetype, "UcrChkMajorGridLinetype")
        Me.UcrChkMajorGridLinetype.Name = "UcrChkMajorGridLinetype"
        '
        'UcrChkMajorGridLineColour
        '
        Me.UcrChkMajorGridLineColour.Checked = False
        resources.ApplyResources(Me.UcrChkMajorGridLineColour, "UcrChkMajorGridLineColour")
        Me.UcrChkMajorGridLineColour.Name = "UcrChkMajorGridLineColour"
        '
        'grpPnlBackground
        '
        Me.grpPnlBackground.Controls.Add(Me.ucrNudPnlBackgroundSize)
        Me.grpPnlBackground.Controls.Add(Me.UcrInputPnlBackgroundFill)
        Me.grpPnlBackground.Controls.Add(Me.UcrInputPnlBackgroundLinetype)
        Me.grpPnlBackground.Controls.Add(Me.UcrInputPnlBackgroundColour)
        Me.grpPnlBackground.Controls.Add(Me.UcrChkPnlBackgroundSize)
        Me.grpPnlBackground.Controls.Add(Me.UcrChkPnlBackgroundLineType)
        Me.grpPnlBackground.Controls.Add(Me.UcrChkPnlBackgroundFill)
        Me.grpPnlBackground.Controls.Add(Me.ucrChkPnlBackgroundColour)
        resources.ApplyResources(Me.grpPnlBackground, "grpPnlBackground")
        Me.grpPnlBackground.Name = "grpPnlBackground"
        Me.grpPnlBackground.TabStop = False
        '
        'ucrNudPnlBackgroundSize
        '
        Me.ucrNudPnlBackgroundSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPnlBackgroundSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudPnlBackgroundSize, "ucrNudPnlBackgroundSize")
        Me.ucrNudPnlBackgroundSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPnlBackgroundSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPnlBackgroundSize.Name = "ucrNudPnlBackgroundSize"
        Me.ucrNudPnlBackgroundSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrInputPnlBackgroundFill
        '
        Me.UcrInputPnlBackgroundFill.AddQuotesIfUnrecognised = True
        Me.UcrInputPnlBackgroundFill.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputPnlBackgroundFill, "UcrInputPnlBackgroundFill")
        Me.UcrInputPnlBackgroundFill.Name = "UcrInputPnlBackgroundFill"
        '
        'UcrInputPnlBackgroundLinetype
        '
        Me.UcrInputPnlBackgroundLinetype.AddQuotesIfUnrecognised = True
        Me.UcrInputPnlBackgroundLinetype.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputPnlBackgroundLinetype, "UcrInputPnlBackgroundLinetype")
        Me.UcrInputPnlBackgroundLinetype.Name = "UcrInputPnlBackgroundLinetype"
        '
        'UcrInputPnlBackgroundColour
        '
        Me.UcrInputPnlBackgroundColour.AddQuotesIfUnrecognised = True
        Me.UcrInputPnlBackgroundColour.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputPnlBackgroundColour, "UcrInputPnlBackgroundColour")
        Me.UcrInputPnlBackgroundColour.Name = "UcrInputPnlBackgroundColour"
        '
        'UcrChkPnlBackgroundSize
        '
        Me.UcrChkPnlBackgroundSize.Checked = False
        resources.ApplyResources(Me.UcrChkPnlBackgroundSize, "UcrChkPnlBackgroundSize")
        Me.UcrChkPnlBackgroundSize.Name = "UcrChkPnlBackgroundSize"
        '
        'UcrChkPnlBackgroundLineType
        '
        Me.UcrChkPnlBackgroundLineType.Checked = False
        resources.ApplyResources(Me.UcrChkPnlBackgroundLineType, "UcrChkPnlBackgroundLineType")
        Me.UcrChkPnlBackgroundLineType.Name = "UcrChkPnlBackgroundLineType"
        '
        'UcrChkPnlBackgroundFill
        '
        Me.UcrChkPnlBackgroundFill.Checked = False
        resources.ApplyResources(Me.UcrChkPnlBackgroundFill, "UcrChkPnlBackgroundFill")
        Me.UcrChkPnlBackgroundFill.Name = "UcrChkPnlBackgroundFill"
        '
        'ucrChkPnlBackgroundColour
        '
        Me.ucrChkPnlBackgroundColour.Checked = False
        resources.ApplyResources(Me.ucrChkPnlBackgroundColour, "ucrChkPnlBackgroundColour")
        Me.ucrChkPnlBackgroundColour.Name = "ucrChkPnlBackgroundColour"
        '
        'ucrSdgPICSARainfalbuttons
        '
        resources.ApplyResources(Me.ucrSdgPICSARainfalbuttons, "ucrSdgPICSARainfalbuttons")
        Me.ucrSdgPICSARainfalbuttons.Name = "ucrSdgPICSARainfalbuttons"
        '
        'sdgPICSARainfallGraph
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbPICSA)
        Me.Controls.Add(Me.ucrSdgPICSARainfalbuttons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPICSARainfallGraph"
        Me.tbPICSA.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grpyAxisTitle.ResumeLayout(False)
        Me.grpyAxisTitle.PerformLayout()
        Me.grpAxes.ResumeLayout(False)
        Me.grpAxes.PerformLayout()
        Me.grpGraphTitles.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.grpXAxisLabels.ResumeLayout(False)
        Me.grpXAxisLabels.PerformLayout()
        Me.grpYAxisLabels.ResumeLayout(False)
        Me.grpYAxisLabels.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.grpMinorGridLine.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grpMajorGridLines.ResumeLayout(False)
        Me.grpPnlBackground.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgPICSARainfalbuttons As ucrButtonsSubdialogue
    Friend WithEvents ucrChkAddMean As ucrCheck
    Friend WithEvents ucrChkAddMedian As ucrCheck
    Friend WithEvents ucrChkAddTerciles As ucrCheck
    Friend WithEvents ucrNudYAxisLabelSize As ucrNud
    Friend WithEvents ucrNudXAxisAngle As ucrNud
    Friend WithEvents ucrNudXaxisLabelSize As ucrNud
    Friend WithEvents ucrInputYInStepsOf As ucrInputTextBox
    Friend WithEvents ucrInputYTo As ucrInputTextBox
    Friend WithEvents ucrInputYFrom As ucrInputTextBox
    Friend WithEvents lblYInStepsOf As Label
    Friend WithEvents lblYFrom As Label
    Friend WithEvents lblYTo As Label
    Friend WithEvents lblXTo As Label
    Friend WithEvents lblXFrom As Label
    Friend WithEvents lblXInStepsOf As Label
    Friend WithEvents ucrInputXFrom As ucrInputTextBox
    Friend WithEvents ucrInputXTo As ucrInputTextBox
    Friend WithEvents ucrInputXInStepsOf As ucrInputTextBox
    Friend WithEvents tbPICSA As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ucrInputGraphTitle As ucrInputTextBox
    Friend WithEvents ucrInputGraphSubTitle As ucrInputTextBox
    Friend WithEvents ucrInputYAxisTitle As ucrInputTextBox
    Friend WithEvents grpGraphTitles As GroupBox
    Friend WithEvents ucrInputGraphcCaption As ucrInputTextBox
    Friend WithEvents grpYAxisLabels As GroupBox
    Friend WithEvents grpXAxisLabels As GroupBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ucrChkXAxisLabelSize As ucrCheck
    Friend WithEvents ucrChkXAxisAngle As ucrCheck
    Friend WithEvents ucrChkSpecifyXAxisTickMarks As ucrCheck
    Friend WithEvents ucrNudYAxisAngle As ucrNud
    Friend WithEvents ucrChkYAxisAngle As ucrCheck
    Friend WithEvents ucrChkYAxisLabelSize As ucrCheck
    Friend WithEvents ucrChkSpecifyYAxisTickMarks As ucrCheck
    Friend WithEvents grpPnlBackground As GroupBox
    Friend WithEvents grpMajorGridLines As GroupBox
    Friend WithEvents UcrChkMajorGridLineColour As ucrCheck
    Friend WithEvents UcrChkPnlBackgroundSize As ucrCheck
    Friend WithEvents UcrChkPnlBackgroundLineType As ucrCheck
    Friend WithEvents UcrChkPnlBackgroundFill As ucrCheck
    Friend WithEvents ucrChkPnlBackgroundColour As ucrCheck
    Friend WithEvents UcrChkMajorGridLinetype As ucrCheck
    Friend WithEvents ucrInputLabelForDays As ucrInputComboBox
    Friend WithEvents ucrChkLabelForDays As ucrCheck
    Friend WithEvents UcrInputMajorGridLineLinetype As ucrInputComboBox
    Friend WithEvents UcrInputMajorGridLineColour As ucrInputComboBox
    Friend WithEvents ucrNudPnlBackgroundSize As ucrNud
    Friend WithEvents UcrInputPnlBackgroundFill As ucrInputComboBox
    Friend WithEvents UcrInputPnlBackgroundLinetype As ucrInputComboBox
    Friend WithEvents UcrInputPnlBackgroundColour As ucrInputComboBox
    Friend WithEvents UcrNudYAxisTitleSzie As ucrNud
    Friend WithEvents UcrChkYAxisTitleSzie As ucrCheck
    Friend WithEvents UcrNudCaptionSize As ucrNud
    Friend WithEvents UcrNudSubTitleSize As ucrNud
    Friend WithEvents UcrNudTitleSize As ucrNud
    Friend WithEvents ucrChkCaptionSize As ucrCheck
    Friend WithEvents UcrChkSubTitleSize As ucrCheck
    Friend WithEvents UcrChkTitleSize As ucrCheck
    Friend WithEvents grpyAxisTitle As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UcrInputBorderLinetype As ucrInputComboBox
    Friend WithEvents UcrInputBorderColour As ucrInputComboBox
    Friend WithEvents ucrChkBorderLineType As ucrCheck
    Friend WithEvents ucrChkBorderColour As ucrCheck
    Friend WithEvents UcrChkCaption As ucrCheck
    Friend WithEvents UcrChkSubTitle As ucrCheck
    Friend WithEvents UcrChkTitle As ucrCheck
    Friend WithEvents grpMinorGridLine As GroupBox
    Friend WithEvents UcrInputMinorGridLineTpe As ucrInputComboBox
    Friend WithEvents UcrInputMinorGridLineColour As ucrInputComboBox
    Friend WithEvents UcrChkMinorGridLineType As ucrCheck
    Friend WithEvents UcrChkMinorGridLineColour As ucrCheck
    Friend WithEvents UcrNudBorderSize As ucrNud
    Friend WithEvents UcrChkBorderSize As ucrCheck
    Friend WithEvents UcrNudMajorGridLineSize As ucrNud
    Friend WithEvents UcrChkMajorGridLineSize As ucrCheck
    Friend WithEvents UcrNudMinorGridLineSize As ucrNud
    Friend WithEvents UcrChkMinorGridLineSize As ucrCheck
    Friend WithEvents UcrPnlYAxisTitle As UcrPanel
    Friend WithEvents rdoRemoveYAxisTitle As RadioButton
    Friend WithEvents rdoChangeYAxisTitle As RadioButton
    Friend WithEvents grpAxes As GroupBox
    Friend WithEvents ucrInputXAxisTitle As ucrInputTextBox
    Friend WithEvents rdoRemoveXAxisTitle As RadioButton
    Friend WithEvents rdoChangeXAxisTitle As RadioButton
    Friend WithEvents ucrPnlXAxisTitle As UcrPanel
    Friend WithEvents UcrNudXAxisTitleSzie As ucrNud
    Friend WithEvents UcrChkXAxisTitleSzie As ucrCheck
    Friend WithEvents rdoAutoYAxis As RadioButton
    Friend WithEvents rdoAutoXAxis As RadioButton
End Class
