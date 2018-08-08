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
        Me.lblYAxisTitleSize = New System.Windows.Forms.Label()
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
        Me.ucrNudYAxisTitleSize = New instat.ucrNud()
        Me.ucrChkAddTerciles = New instat.ucrCheck()
        Me.ucrChkAddMedian = New instat.ucrCheck()
        Me.ucrChkAddMean = New instat.ucrCheck()
        Me.ucrSdgPICSARainfalbuttons = New instat.ucrButtonsSubdialogue()
        Me.tbPICSA = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.ucrInputGraphSubTitle = New instat.ucrInputTextBox()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.ucrInputGraphcCaption = New instat.ucrInputTextBox()
        Me.grpGraphTitles = New System.Windows.Forms.GroupBox()
        Me.grpAxes = New System.Windows.Forms.GroupBox()
        Me.lblXAxis = New System.Windows.Forms.Label()
        Me.lblYAxis = New System.Windows.Forms.Label()
        Me.ucrInputXAxisTitle = New instat.ucrInputTextBox()
        Me.ucrInputYAxisTitle = New instat.ucrInputTextBox()
        Me.grpYAxisLabels = New System.Windows.Forms.GroupBox()
        Me.grpXAxisLabels = New System.Windows.Forms.GroupBox()
        Me.lblXAxisAngle = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.tbPICSA.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.grpGraphTitles.SuspendLayout()
        Me.grpAxes.SuspendLayout()
        Me.grpYAxisLabels.SuspendLayout()
        Me.grpXAxisLabels.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblYAxisTitleSize
        '
        resources.ApplyResources(Me.lblYAxisTitleSize, "lblYAxisTitleSize")
        Me.lblYAxisTitleSize.Name = "lblYAxisTitleSize"
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
        Me.TabPage1.Controls.Add(Me.grpAxes)
        Me.TabPage1.Controls.Add(Me.grpGraphTitles)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grpXAxisLabels)
        Me.TabPage2.Controls.Add(Me.grpYAxisLabels)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphTitle, "ucrInputGraphTitle")
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        '
        'lblSubTitle
        '
        resources.ApplyResources(Me.lblSubTitle, "lblSubTitle")
        Me.lblSubTitle.Name = "lblSubTitle"
        '
        'ucrInputGraphSubTitle
        '
        Me.ucrInputGraphSubTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphSubTitle.IsMultiline = False
        Me.ucrInputGraphSubTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphSubTitle, "ucrInputGraphSubTitle")
        Me.ucrInputGraphSubTitle.Name = "ucrInputGraphSubTitle"
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
        'grpGraphTitles
        '
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
        'grpAxes
        '
        Me.grpAxes.Controls.Add(Me.lblXAxis)
        Me.grpAxes.Controls.Add(Me.lblYAxis)
        Me.grpAxes.Controls.Add(Me.ucrInputXAxisTitle)
        Me.grpAxes.Controls.Add(Me.ucrInputYAxisTitle)
        resources.ApplyResources(Me.grpAxes, "grpAxes")
        Me.grpAxes.Name = "grpAxes"
        Me.grpAxes.TabStop = False
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
        'grpYAxisLabels
        '
        Me.grpYAxisLabels.Controls.Add(Me.ucrInputYFrom)
        Me.grpYAxisLabels.Controls.Add(Me.lblYAxisTitleSize)
        Me.grpYAxisLabels.Controls.Add(Me.lblYFrom)
        Me.grpYAxisLabels.Controls.Add(Me.ucrNudYAxisTitleSize)
        Me.grpYAxisLabels.Controls.Add(Me.ucrInputYTo)
        Me.grpYAxisLabels.Controls.Add(Me.lblYTo)
        Me.grpYAxisLabels.Controls.Add(Me.lblYInStepsOf)
        Me.grpYAxisLabels.Controls.Add(Me.ucrInputYInStepsOf)
        resources.ApplyResources(Me.grpYAxisLabels, "grpYAxisLabels")
        Me.grpYAxisLabels.Name = "grpYAxisLabels"
        Me.grpYAxisLabels.TabStop = False
        '
        'grpXAxisLabels
        '
        Me.grpXAxisLabels.Controls.Add(Me.lblXAxisAngle)
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
        'lblXAxisAngle
        '
        resources.ApplyResources(Me.lblXAxisAngle, "lblXAxisAngle")
        Me.lblXAxisAngle.Name = "lblXAxisAngle"
        '
        'TabPage4
        '
        resources.ApplyResources(Me.TabPage4, "TabPage4")
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
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
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.grpGraphTitles.ResumeLayout(False)
        Me.grpGraphTitles.PerformLayout()
        Me.grpAxes.ResumeLayout(False)
        Me.grpAxes.PerformLayout()
        Me.grpYAxisLabels.ResumeLayout(False)
        Me.grpYAxisLabels.PerformLayout()
        Me.grpXAxisLabels.ResumeLayout(False)
        Me.grpXAxisLabels.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgPICSARainfalbuttons As ucrButtonsSubdialogue
    Friend WithEvents ucrChkAddMean As ucrCheck
    Friend WithEvents ucrChkAddMedian As ucrCheck
    Friend WithEvents ucrChkAddTerciles As ucrCheck
    Friend WithEvents lblYAxisTitleSize As Label
    Friend WithEvents ucrNudYAxisTitleSize As ucrNud
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
    Friend WithEvents lblXAxisAngle As Label
    Friend WithEvents TabPage4 As TabPage
End Class
