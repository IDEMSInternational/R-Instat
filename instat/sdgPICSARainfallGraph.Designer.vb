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
        Me.ucrNudYAxisLabelsSize = New instat.ucrNud()
        Me.ucrNudYAxisTitleSize = New instat.ucrNud()
        Me.ucrChkAddLabel = New instat.ucrCheck()
        Me.ucrChkXaxisLabelSize = New instat.ucrCheck()
        Me.ucrInputSubFootNote = New instat.ucrInputTextBox()
        Me.ucrInputFootNote = New instat.ucrInputTextBox()
        Me.ucrChkSubFootNote = New instat.ucrCheck()
        Me.ucrInputYAxisTitle = New instat.ucrInputTextBox()
        Me.ucrChkFootNote = New instat.ucrCheck()
        Me.ucrChkXaxisAngle = New instat.ucrCheck()
        Me.ucrSpecifyXAxisTickMarks = New instat.ucrCheck()
        Me.ucrSpecifyYAxisTickMarks = New instat.ucrCheck()
        Me.ucrChkYAxisTitle = New instat.ucrCheck()
        Me.ucrChkAddTerciles = New instat.ucrCheck()
        Me.ucrChkAddMedian = New instat.ucrCheck()
        Me.ucrChkYAxisLabelsSize = New instat.ucrCheck()
        Me.ucrChkAddMean = New instat.ucrCheck()
        Me.ucrSdgPICSARainfalbuttons = New instat.ucrButtonsSubdialogue()
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
        'ucrNudYAxisLabelsSize
        '
        Me.ucrNudYAxisLabelsSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisLabelsSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudYAxisLabelsSize, "ucrNudYAxisLabelsSize")
        Me.ucrNudYAxisLabelsSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYAxisLabelsSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisLabelsSize.Name = "ucrNudYAxisLabelsSize"
        Me.ucrNudYAxisLabelsSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
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
        'ucrChkAddLabel
        '
        Me.ucrChkAddLabel.Checked = False
        resources.ApplyResources(Me.ucrChkAddLabel, "ucrChkAddLabel")
        Me.ucrChkAddLabel.Name = "ucrChkAddLabel"
        '
        'ucrChkXaxisLabelSize
        '
        Me.ucrChkXaxisLabelSize.Checked = False
        resources.ApplyResources(Me.ucrChkXaxisLabelSize, "ucrChkXaxisLabelSize")
        Me.ucrChkXaxisLabelSize.Name = "ucrChkXaxisLabelSize"
        '
        'ucrInputSubFootNote
        '
        Me.ucrInputSubFootNote.AddQuotesIfUnrecognised = True
        Me.ucrInputSubFootNote.IsMultiline = False
        Me.ucrInputSubFootNote.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSubFootNote, "ucrInputSubFootNote")
        Me.ucrInputSubFootNote.Name = "ucrInputSubFootNote"
        '
        'ucrInputFootNote
        '
        Me.ucrInputFootNote.AddQuotesIfUnrecognised = True
        Me.ucrInputFootNote.IsMultiline = False
        Me.ucrInputFootNote.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFootNote, "ucrInputFootNote")
        Me.ucrInputFootNote.Name = "ucrInputFootNote"
        '
        'ucrChkSubFootNote
        '
        Me.ucrChkSubFootNote.Checked = False
        resources.ApplyResources(Me.ucrChkSubFootNote, "ucrChkSubFootNote")
        Me.ucrChkSubFootNote.Name = "ucrChkSubFootNote"
        '
        'ucrInputYAxisTitle
        '
        Me.ucrInputYAxisTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputYAxisTitle.IsMultiline = False
        Me.ucrInputYAxisTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYAxisTitle, "ucrInputYAxisTitle")
        Me.ucrInputYAxisTitle.Name = "ucrInputYAxisTitle"
        '
        'ucrChkFootNote
        '
        Me.ucrChkFootNote.Checked = False
        resources.ApplyResources(Me.ucrChkFootNote, "ucrChkFootNote")
        Me.ucrChkFootNote.Name = "ucrChkFootNote"
        '
        'ucrChkXaxisAngle
        '
        Me.ucrChkXaxisAngle.Checked = False
        resources.ApplyResources(Me.ucrChkXaxisAngle, "ucrChkXaxisAngle")
        Me.ucrChkXaxisAngle.Name = "ucrChkXaxisAngle"
        '
        'ucrSpecifyXAxisTickMarks
        '
        Me.ucrSpecifyXAxisTickMarks.Checked = False
        resources.ApplyResources(Me.ucrSpecifyXAxisTickMarks, "ucrSpecifyXAxisTickMarks")
        Me.ucrSpecifyXAxisTickMarks.Name = "ucrSpecifyXAxisTickMarks"
        '
        'ucrSpecifyYAxisTickMarks
        '
        Me.ucrSpecifyYAxisTickMarks.Checked = False
        resources.ApplyResources(Me.ucrSpecifyYAxisTickMarks, "ucrSpecifyYAxisTickMarks")
        Me.ucrSpecifyYAxisTickMarks.Name = "ucrSpecifyYAxisTickMarks"
        '
        'ucrChkYAxisTitle
        '
        Me.ucrChkYAxisTitle.Checked = False
        resources.ApplyResources(Me.ucrChkYAxisTitle, "ucrChkYAxisTitle")
        Me.ucrChkYAxisTitle.Name = "ucrChkYAxisTitle"
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
        'ucrChkYAxisLabelsSize
        '
        Me.ucrChkYAxisLabelsSize.Checked = False
        resources.ApplyResources(Me.ucrChkYAxisLabelsSize, "ucrChkYAxisLabelsSize")
        Me.ucrChkYAxisLabelsSize.Name = "ucrChkYAxisLabelsSize"
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
        'sdgPICSARainfallGraph
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputXInStepsOf)
        Me.Controls.Add(Me.ucrInputXTo)
        Me.Controls.Add(Me.ucrInputYInStepsOf)
        Me.Controls.Add(Me.ucrInputXFrom)
        Me.Controls.Add(Me.ucrInputYTo)
        Me.Controls.Add(Me.lblXInStepsOf)
        Me.Controls.Add(Me.ucrInputYFrom)
        Me.Controls.Add(Me.lblXFrom)
        Me.Controls.Add(Me.lblYInStepsOf)
        Me.Controls.Add(Me.lblXTo)
        Me.Controls.Add(Me.lblYFrom)
        Me.Controls.Add(Me.lblYTo)
        Me.Controls.Add(Me.ucrNudXaxisLabelSize)
        Me.Controls.Add(Me.ucrNudXAxisAngle)
        Me.Controls.Add(Me.ucrNudYAxisLabelsSize)
        Me.Controls.Add(Me.ucrNudYAxisTitleSize)
        Me.Controls.Add(Me.lblYAxisTitleSize)
        Me.Controls.Add(Me.ucrChkAddLabel)
        Me.Controls.Add(Me.ucrChkXaxisLabelSize)
        Me.Controls.Add(Me.ucrInputSubFootNote)
        Me.Controls.Add(Me.ucrInputFootNote)
        Me.Controls.Add(Me.ucrChkSubFootNote)
        Me.Controls.Add(Me.ucrInputYAxisTitle)
        Me.Controls.Add(Me.ucrChkFootNote)
        Me.Controls.Add(Me.ucrChkXaxisAngle)
        Me.Controls.Add(Me.ucrSpecifyXAxisTickMarks)
        Me.Controls.Add(Me.ucrSpecifyYAxisTickMarks)
        Me.Controls.Add(Me.ucrChkYAxisTitle)
        Me.Controls.Add(Me.ucrChkAddTerciles)
        Me.Controls.Add(Me.ucrChkAddMedian)
        Me.Controls.Add(Me.ucrChkYAxisLabelsSize)
        Me.Controls.Add(Me.ucrChkAddMean)
        Me.Controls.Add(Me.ucrSdgPICSARainfalbuttons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPICSARainfallGraph"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSdgPICSARainfalbuttons As ucrButtonsSubdialogue
    Friend WithEvents ucrChkAddMean As ucrCheck
    Friend WithEvents ucrChkAddMedian As ucrCheck
    Friend WithEvents ucrChkAddTerciles As ucrCheck
    Friend WithEvents ucrChkYAxisTitle As ucrCheck
    Friend WithEvents ucrInputYAxisTitle As ucrInputTextBox
    Friend WithEvents lblYAxisTitleSize As Label
    Friend WithEvents ucrNudYAxisTitleSize As ucrNud
    Friend WithEvents ucrChkXaxisAngle As ucrCheck
    Friend WithEvents ucrNudXAxisAngle As ucrNud
    Friend WithEvents ucrChkXaxisLabelSize As ucrCheck
    Friend WithEvents ucrNudXaxisLabelSize As ucrNud
    Friend WithEvents ucrChkAddLabel As ucrCheck
    Friend WithEvents ucrChkFootNote As ucrCheck
    Friend WithEvents ucrInputFootNote As ucrInputTextBox
    Friend WithEvents ucrChkSubFootNote As ucrCheck
    Friend WithEvents ucrInputSubFootNote As ucrInputTextBox
    Friend WithEvents ucrSpecifyYAxisTickMarks As ucrCheck
    Friend WithEvents ucrSpecifyXAxisTickMarks As ucrCheck
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
    Friend WithEvents ucrChkYAxisLabelsSize As ucrCheck
    Friend WithEvents ucrNudYAxisLabelsSize As ucrNud
End Class
