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
        Me.ucrInputXInStepsOf = New instat.ucrInputTextBox()
        Me.ucrInputXTo = New instat.ucrInputTextBox()
        Me.ucrInputYInStepsOf = New instat.ucrInputTextBox()
        Me.ucrInputXFrom = New instat.ucrInputTextBox()
        Me.ucrInputYTo = New instat.ucrInputTextBox()
        Me.ucrInputYFrom = New instat.ucrInputTextBox()
        Me.ucrNudXaxisLabelSize = New instat.ucrNud()
        Me.ucrNudXAxisAngle = New instat.ucrNud()
        Me.ucrNudYAxisLabelSize = New instat.ucrNud()
        Me.ucrChkAddTerciles = New instat.ucrCheck()
        Me.ucrChkAddMedian = New instat.ucrCheck()
        Me.ucrChkAddMean = New instat.ucrCheck()
        Me.ucrSdgPICSARainfalbuttons = New instat.ucrButtonsSubdialogue()
        Me.tbPICSA = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grpAxes = New System.Windows.Forms.GroupBox()
        Me.ucrChkRemoveYAxisTitle = New instat.ucrCheck()
        Me.ucrChkRemoveXAxisTitle = New instat.ucrCheck()
        Me.UcrNudXAxisTitleSzie = New instat.ucrNud()
        Me.UcrNudYAxisTitleSzie = New instat.ucrNud()
        Me.UcrChkYAxisTitleSzie = New instat.ucrCheck()
        Me.UcrChkXAxisTitleSzie = New instat.ucrCheck()
        Me.lblXAxis = New System.Windows.Forms.Label()
        Me.lblYAxis = New System.Windows.Forms.Label()
        Me.ucrInputXAxisTitle = New instat.ucrInputTextBox()
        Me.ucrInputYAxisTitle = New instat.ucrInputTextBox()
        Me.grpGraphTitles = New System.Windows.Forms.GroupBox()
        Me.UcrNudCaptionSize = New instat.ucrNud()
        Me.UcrNudSubTitleSize = New instat.ucrNud()
        Me.UcrNudTitleSize = New instat.ucrNud()
        Me.ucrChkCaptionSize = New instat.ucrCheck()
        Me.UcrChkSubTitleSize = New instat.ucrCheck()
        Me.UcrChkTitleSize = New instat.ucrCheck()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.ucrInputGraphcCaption = New instat.ucrInputTextBox()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.ucrInputGraphSubTitle = New instat.ucrInputTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grpXAxisLabels = New System.Windows.Forms.GroupBox()
        Me.ucrInputLabelForDays = New instat.ucrInputComboBox()
        Me.ucrChkLabelForDays = New instat.ucrCheck()
        Me.ucrChkXAxisLabelSize = New instat.ucrCheck()
        Me.ucrChkXAxisAngle = New instat.ucrCheck()
        Me.ucrChkSpecifyXAxisTickMarks = New instat.ucrCheck()
        Me.grpYAxisLabels = New System.Windows.Forms.GroupBox()
        Me.ucrNudYAxisAngle = New instat.ucrNud()
        Me.ucrChkYAxisAngle = New instat.ucrCheck()
        Me.ucrChkYAxisLabelSize = New instat.ucrCheck()
        Me.ucrChkSpecifyYAxisTickMarks = New instat.ucrCheck()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.grpGridLines = New System.Windows.Forms.GroupBox()
        Me.UcrInputGridLineLinetype = New instat.ucrInputComboBox()
        Me.UcrInputGridLineColour = New instat.ucrInputComboBox()
        Me.UcrChkGridLinetype = New instat.ucrCheck()
        Me.UcrChkGridLineColour = New instat.ucrCheck()
        Me.grpPnlBackground = New System.Windows.Forms.GroupBox()
        Me.ucrNudPnlBackgroundSize = New instat.ucrNud()
        Me.UcrInputPnlBackgroundFill = New instat.ucrInputComboBox()
        Me.UcrInputPnlBackgroundLinetype = New instat.ucrInputComboBox()
        Me.UcrInputPnlBackgroundColour = New instat.ucrInputComboBox()
        Me.UcrChkPnlBackgroundSize = New instat.ucrCheck()
        Me.UcrChkPnlBackgroundLineType = New instat.ucrCheck()
        Me.UcrChkPnlBackgroundFill = New instat.ucrCheck()
        Me.ucrChkPnlBackgroundColour = New instat.ucrCheck()
        Me.grpyAxisTitle = New System.Windows.Forms.GroupBox()
        Me.tbPICSA.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpAxes.SuspendLayout()
        Me.grpGraphTitles.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grpXAxisLabels.SuspendLayout()
        Me.grpYAxisLabels.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.grpGridLines.SuspendLayout()
        Me.grpPnlBackground.SuspendLayout()
        Me.grpyAxisTitle.SuspendLayout()
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
        'ucrInputXInStepsOf
        '
        Me.ucrInputXInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputXInStepsOf.IsMultiline = False
        Me.ucrInputXInStepsOf.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXInStepsOf, "ucrInputXInStepsOf")
        Me.ucrInputXInStepsOf.Name = "ucrInputXInStepsOf"
        '
        'ucrInputXTo
        '
        Me.ucrInputXTo.AddQuotesIfUnrecognised = True
        Me.ucrInputXTo.IsMultiline = False
        Me.ucrInputXTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXTo, "ucrInputXTo")
        Me.ucrInputXTo.Name = "ucrInputXTo"
        '
        'ucrInputYInStepsOf
        '
        Me.ucrInputYInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputYInStepsOf.IsMultiline = False
        Me.ucrInputYInStepsOf.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYInStepsOf, "ucrInputYInStepsOf")
        Me.ucrInputYInStepsOf.Name = "ucrInputYInStepsOf"
        '
        'ucrInputXFrom
        '
        Me.ucrInputXFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputXFrom.IsMultiline = False
        Me.ucrInputXFrom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXFrom, "ucrInputXFrom")
        Me.ucrInputXFrom.Name = "ucrInputXFrom"
        '
        'ucrInputYTo
        '
        Me.ucrInputYTo.AddQuotesIfUnrecognised = True
        Me.ucrInputYTo.IsMultiline = False
        Me.ucrInputYTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYTo, "ucrInputYTo")
        Me.ucrInputYTo.Name = "ucrInputYTo"
        '
        'ucrInputYFrom
        '
        Me.ucrInputYFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputYFrom.IsMultiline = False
        Me.ucrInputYFrom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYFrom, "ucrInputYFrom")
        Me.ucrInputYFrom.Name = "ucrInputYFrom"
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
        'ucrChkAddTerciles
        '
        Me.ucrChkAddTerciles.Checked = False
        resources.ApplyResources(Me.ucrChkAddTerciles, "ucrChkAddTerciles")
        Me.ucrChkAddTerciles.Name = "ucrChkAddTerciles"
        '
        'ucrChkAddMedian
        '
        Me.ucrChkAddMedian.Checked = False
        resources.ApplyResources(Me.ucrChkAddMedian, "ucrChkAddMedian")
        Me.ucrChkAddMedian.Name = "ucrChkAddMedian"
        '
        'ucrChkAddMean
        '
        Me.ucrChkAddMean.Checked = False
        resources.ApplyResources(Me.ucrChkAddMean, "ucrChkAddMean")
        Me.ucrChkAddMean.Name = "ucrChkAddMean"
        '
        'ucrSdgPICSARainfalbuttons
        '
        resources.ApplyResources(Me.ucrSdgPICSARainfalbuttons, "ucrSdgPICSARainfalbuttons")
        Me.ucrSdgPICSARainfalbuttons.Name = "ucrSdgPICSARainfalbuttons"
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
        'grpAxes
        '
        Me.grpAxes.Controls.Add(Me.ucrChkRemoveXAxisTitle)
        Me.grpAxes.Controls.Add(Me.UcrNudXAxisTitleSzie)
        Me.grpAxes.Controls.Add(Me.UcrChkXAxisTitleSzie)
        Me.grpAxes.Controls.Add(Me.lblXAxis)
        Me.grpAxes.Controls.Add(Me.ucrInputXAxisTitle)
        resources.ApplyResources(Me.grpAxes, "grpAxes")
        Me.grpAxes.Name = "grpAxes"
        Me.grpAxes.TabStop = False
        '
        'ucrChkRemoveYAxisTitle
        '
        Me.ucrChkRemoveYAxisTitle.Checked = False
        resources.ApplyResources(Me.ucrChkRemoveYAxisTitle, "ucrChkRemoveYAxisTitle")
        Me.ucrChkRemoveYAxisTitle.Name = "ucrChkRemoveYAxisTitle"
        '
        'ucrChkRemoveXAxisTitle
        '
        Me.ucrChkRemoveXAxisTitle.Checked = False
        resources.ApplyResources(Me.ucrChkRemoveXAxisTitle, "ucrChkRemoveXAxisTitle")
        Me.ucrChkRemoveXAxisTitle.Name = "ucrChkRemoveXAxisTitle"
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
        'UcrChkYAxisTitleSzie
        '
        Me.UcrChkYAxisTitleSzie.Checked = False
        resources.ApplyResources(Me.UcrChkYAxisTitleSzie, "UcrChkYAxisTitleSzie")
        Me.UcrChkYAxisTitleSzie.Name = "UcrChkYAxisTitleSzie"
        '
        'UcrChkXAxisTitleSzie
        '
        Me.UcrChkXAxisTitleSzie.Checked = False
        resources.ApplyResources(Me.UcrChkXAxisTitleSzie, "UcrChkXAxisTitleSzie")
        Me.UcrChkXAxisTitleSzie.Name = "UcrChkXAxisTitleSzie"
        '
        'lblXAxis
        '
        resources.ApplyResources(Me.lblXAxis, "lblXAxis")
        Me.lblXAxis.Name = "lblXAxis"
        '
        'lblYAxis
        '
        resources.ApplyResources(Me.lblYAxis, "lblYAxis")
        Me.lblYAxis.Name = "lblYAxis"
        '
        'ucrInputXAxisTitle
        '
        Me.ucrInputXAxisTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputXAxisTitle.IsMultiline = False
        Me.ucrInputXAxisTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXAxisTitle, "ucrInputXAxisTitle")
        Me.ucrInputXAxisTitle.Name = "ucrInputXAxisTitle"
        '
        'ucrInputYAxisTitle
        '
        Me.ucrInputYAxisTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputYAxisTitle.IsMultiline = False
        Me.ucrInputYAxisTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYAxisTitle, "ucrInputYAxisTitle")
        Me.ucrInputYAxisTitle.Name = "ucrInputYAxisTitle"
        '
        'grpGraphTitles
        '
        Me.grpGraphTitles.Controls.Add(Me.UcrNudCaptionSize)
        Me.grpGraphTitles.Controls.Add(Me.UcrNudSubTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.UcrNudTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.ucrChkCaptionSize)
        Me.grpGraphTitles.Controls.Add(Me.UcrChkSubTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.UcrChkTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.Label1)
        Me.grpGraphTitles.Controls.Add(Me.lblCaption)
        Me.grpGraphTitles.Controls.Add(Me.ucrInputGraphcCaption)
        Me.grpGraphTitles.Controls.Add(Me.lblSubTitle)
        Me.grpGraphTitles.Controls.Add(Me.ucrInputGraphTitle)
        Me.grpGraphTitles.Controls.Add(Me.ucrInputGraphSubTitle)
        resources.ApplyResources(Me.grpGraphTitles, "grpGraphTitles")
        Me.grpGraphTitles.Name = "grpGraphTitles"
        Me.grpGraphTitles.TabStop = False
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
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'lblCaption
        '
        resources.ApplyResources(Me.lblCaption, "lblCaption")
        Me.lblCaption.Name = "lblCaption"
        '
        'ucrInputGraphcCaption
        '
        Me.ucrInputGraphcCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphcCaption.IsMultiline = False
        Me.ucrInputGraphcCaption.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphcCaption, "ucrInputGraphcCaption")
        Me.ucrInputGraphcCaption.Name = "ucrInputGraphcCaption"
        '
        'lblSubTitle
        '
        resources.ApplyResources(Me.lblSubTitle, "lblSubTitle")
        Me.lblSubTitle.Name = "lblSubTitle"
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
        Me.grpXAxisLabels.Controls.Add(Me.ucrInputLabelForDays)
        Me.grpXAxisLabels.Controls.Add(Me.ucrChkLabelForDays)
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
        'ucrInputLabelForDays
        '
        Me.ucrInputLabelForDays.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelForDays.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLabelForDays, "ucrInputLabelForDays")
        Me.ucrInputLabelForDays.Name = "ucrInputLabelForDays"
        '
        'ucrChkLabelForDays
        '
        Me.ucrChkLabelForDays.Checked = False
        resources.ApplyResources(Me.ucrChkLabelForDays, "ucrChkLabelForDays")
        Me.ucrChkLabelForDays.Name = "ucrChkLabelForDays"
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
        'grpYAxisLabels
        '
        Me.grpYAxisLabels.Controls.Add(Me.ucrNudYAxisAngle)
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ucrChkAddMean)
        Me.TabPage3.Controls.Add(Me.ucrChkAddMedian)
        Me.TabPage3.Controls.Add(Me.ucrChkAddTerciles)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.grpGridLines)
        Me.TabPage4.Controls.Add(Me.grpPnlBackground)
        resources.ApplyResources(Me.TabPage4, "TabPage4")
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'grpGridLines
        '
        Me.grpGridLines.Controls.Add(Me.UcrInputGridLineLinetype)
        Me.grpGridLines.Controls.Add(Me.UcrInputGridLineColour)
        Me.grpGridLines.Controls.Add(Me.UcrChkGridLinetype)
        Me.grpGridLines.Controls.Add(Me.UcrChkGridLineColour)
        resources.ApplyResources(Me.grpGridLines, "grpGridLines")
        Me.grpGridLines.Name = "grpGridLines"
        Me.grpGridLines.TabStop = False
        '
        'UcrInputGridLineLinetype
        '
        Me.UcrInputGridLineLinetype.AddQuotesIfUnrecognised = True
        Me.UcrInputGridLineLinetype.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputGridLineLinetype, "UcrInputGridLineLinetype")
        Me.UcrInputGridLineLinetype.Name = "UcrInputGridLineLinetype"
        '
        'UcrInputGridLineColour
        '
        Me.UcrInputGridLineColour.AddQuotesIfUnrecognised = True
        Me.UcrInputGridLineColour.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputGridLineColour, "UcrInputGridLineColour")
        Me.UcrInputGridLineColour.Name = "UcrInputGridLineColour"
        '
        'UcrChkGridLinetype
        '
        Me.UcrChkGridLinetype.Checked = False
        resources.ApplyResources(Me.UcrChkGridLinetype, "UcrChkGridLinetype")
        Me.UcrChkGridLinetype.Name = "UcrChkGridLinetype"
        '
        'UcrChkGridLineColour
        '
        Me.UcrChkGridLineColour.Checked = False
        resources.ApplyResources(Me.UcrChkGridLineColour, "UcrChkGridLineColour")
        Me.UcrChkGridLineColour.Name = "UcrChkGridLineColour"
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
        'grpyAxisTitle
        '
        Me.grpyAxisTitle.Controls.Add(Me.lblYAxis)
        Me.grpyAxisTitle.Controls.Add(Me.ucrChkRemoveYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.ucrInputYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.UcrChkYAxisTitleSzie)
        Me.grpyAxisTitle.Controls.Add(Me.UcrNudYAxisTitleSzie)
        resources.ApplyResources(Me.grpyAxisTitle, "grpyAxisTitle")
        Me.grpyAxisTitle.Name = "grpyAxisTitle"
        Me.grpyAxisTitle.TabStop = False
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
        Me.grpAxes.ResumeLayout(False)
        Me.grpAxes.PerformLayout()
        Me.grpGraphTitles.ResumeLayout(False)
        Me.grpGraphTitles.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.grpXAxisLabels.ResumeLayout(False)
        Me.grpXAxisLabels.PerformLayout()
        Me.grpYAxisLabels.ResumeLayout(False)
        Me.grpYAxisLabels.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.grpGridLines.ResumeLayout(False)
        Me.grpPnlBackground.ResumeLayout(False)
        Me.grpyAxisTitle.ResumeLayout(False)
        Me.grpyAxisTitle.PerformLayout()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrInputGraphSubTitle As ucrInputTextBox
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents grpAxes As GroupBox
    Friend WithEvents lblXAxis As Label
    Friend WithEvents lblYAxis As Label
    Friend WithEvents ucrInputXAxisTitle As ucrInputTextBox
    Friend WithEvents ucrInputYAxisTitle As ucrInputTextBox
    Friend WithEvents grpGraphTitles As GroupBox
    Friend WithEvents lblCaption As Label
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
    Friend WithEvents grpGridLines As GroupBox
    Friend WithEvents UcrChkGridLineColour As ucrCheck
    Friend WithEvents UcrChkPnlBackgroundSize As ucrCheck
    Friend WithEvents UcrChkPnlBackgroundLineType As ucrCheck
    Friend WithEvents UcrChkPnlBackgroundFill As ucrCheck
    Friend WithEvents ucrChkPnlBackgroundColour As ucrCheck
    Friend WithEvents UcrChkGridLinetype As ucrCheck
    Friend WithEvents ucrInputLabelForDays As ucrInputComboBox
    Friend WithEvents ucrChkLabelForDays As ucrCheck
    Friend WithEvents UcrInputGridLineLinetype As ucrInputComboBox
    Friend WithEvents UcrInputGridLineColour As ucrInputComboBox
    Friend WithEvents ucrNudPnlBackgroundSize As ucrNud
    Friend WithEvents UcrInputPnlBackgroundFill As ucrInputComboBox
    Friend WithEvents UcrInputPnlBackgroundLinetype As ucrInputComboBox
    Friend WithEvents UcrInputPnlBackgroundColour As ucrInputComboBox
    Friend WithEvents UcrNudXAxisTitleSzie As ucrNud
    Friend WithEvents UcrNudYAxisTitleSzie As ucrNud
    Friend WithEvents UcrChkYAxisTitleSzie As ucrCheck
    Friend WithEvents UcrChkXAxisTitleSzie As ucrCheck
    Friend WithEvents UcrNudCaptionSize As ucrNud
    Friend WithEvents UcrNudSubTitleSize As ucrNud
    Friend WithEvents UcrNudTitleSize As ucrNud
    Friend WithEvents ucrChkCaptionSize As ucrCheck
    Friend WithEvents UcrChkSubTitleSize As ucrCheck
    Friend WithEvents UcrChkTitleSize As ucrCheck
    Friend WithEvents ucrChkRemoveYAxisTitle As ucrCheck
    Friend WithEvents ucrChkRemoveXAxisTitle As ucrCheck
    Friend WithEvents grpyAxisTitle As GroupBox
End Class
