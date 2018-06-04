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
        Me.ucrChkPlotTerciles = New instat.ucrCheck()
        Me.ucrChkPlotMedian = New instat.ucrCheck()
        Me.ucrChkPlotMean = New instat.ucrCheck()
        Me.ucrSdgPICSARainfalbuttons = New instat.ucrButtonsSubdialogue()
        Me.ucrChkYAxisTitle = New instat.ucrCheck()
        Me.ucrInputYAxisTitle = New instat.ucrInputTextBox()
        Me.lblYAxisTitleSize = New System.Windows.Forms.Label()
        Me.ucrNudYAxisTitleSize = New instat.ucrNud()
        Me.ucrChkXaxisAngle = New instat.ucrCheck()
        Me.ucrNudXAxisAngle = New instat.ucrNud()
        Me.ucrChkXaxisLabelSize = New instat.ucrCheck()
        Me.ucrNudXaxisLabelSize = New instat.ucrNud()
        Me.ucrChkAddLabel = New instat.ucrCheck()
        Me.ucrChkAddMeanLabel = New instat.ucrCheck()
        Me.ucrChkAddMedianLabel = New instat.ucrCheck()
        Me.ucrChkAddTercillesLabel = New instat.ucrCheck()
        Me.ucrChkFootNote = New instat.ucrCheck()
        Me.ucrInputFootNote = New instat.ucrInputTextBox()
        Me.ucrChkSubFootNote = New instat.ucrCheck()
        Me.UcrInputTextBox1 = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'ucrChkPlotTerciles
        '
        Me.ucrChkPlotTerciles.Checked = False
        resources.ApplyResources(Me.ucrChkPlotTerciles, "ucrChkPlotTerciles")
        Me.ucrChkPlotTerciles.Name = "ucrChkPlotTerciles"
        '
        'ucrChkPlotMedian
        '
        Me.ucrChkPlotMedian.Checked = False
        resources.ApplyResources(Me.ucrChkPlotMedian, "ucrChkPlotMedian")
        Me.ucrChkPlotMedian.Name = "ucrChkPlotMedian"
        '
        'ucrChkPlotMean
        '
        Me.ucrChkPlotMean.Checked = False
        resources.ApplyResources(Me.ucrChkPlotMean, "ucrChkPlotMean")
        Me.ucrChkPlotMean.Name = "ucrChkPlotMean"
        '
        'ucrSdgPICSARainfalbuttons
        '
        resources.ApplyResources(Me.ucrSdgPICSARainfalbuttons, "ucrSdgPICSARainfalbuttons")
        Me.ucrSdgPICSARainfalbuttons.Name = "ucrSdgPICSARainfalbuttons"
        '
        'ucrChkYAxisTitle
        '
        Me.ucrChkYAxisTitle.Checked = False
        resources.ApplyResources(Me.ucrChkYAxisTitle, "ucrChkYAxisTitle")
        Me.ucrChkYAxisTitle.Name = "ucrChkYAxisTitle"
        '
        'ucrInputYAxisTitle
        '
        Me.ucrInputYAxisTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputYAxisTitle.IsMultiline = False
        Me.ucrInputYAxisTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYAxisTitle, "ucrInputYAxisTitle")
        Me.ucrInputYAxisTitle.Name = "ucrInputYAxisTitle"
        '
        'lblYAxisTitleSize
        '
        resources.ApplyResources(Me.lblYAxisTitleSize, "lblYAxisTitleSize")
        Me.lblYAxisTitleSize.Name = "lblYAxisTitleSize"
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
        'ucrChkXaxisAngle
        '
        Me.ucrChkXaxisAngle.Checked = False
        resources.ApplyResources(Me.ucrChkXaxisAngle, "ucrChkXaxisAngle")
        Me.ucrChkXaxisAngle.Name = "ucrChkXaxisAngle"
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
        'ucrChkXaxisLabelSize
        '
        Me.ucrChkXaxisLabelSize.Checked = False
        resources.ApplyResources(Me.ucrChkXaxisLabelSize, "ucrChkXaxisLabelSize")
        Me.ucrChkXaxisLabelSize.Name = "ucrChkXaxisLabelSize"
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
        'ucrChkAddLabel
        '
        Me.ucrChkAddLabel.Checked = False
        resources.ApplyResources(Me.ucrChkAddLabel, "ucrChkAddLabel")
        Me.ucrChkAddLabel.Name = "ucrChkAddLabel"
        '
        'ucrChkAddMeanLabel
        '
        Me.ucrChkAddMeanLabel.Checked = False
        resources.ApplyResources(Me.ucrChkAddMeanLabel, "ucrChkAddMeanLabel")
        Me.ucrChkAddMeanLabel.Name = "ucrChkAddMeanLabel"
        '
        'ucrChkAddMedianLabel
        '
        Me.ucrChkAddMedianLabel.Checked = False
        resources.ApplyResources(Me.ucrChkAddMedianLabel, "ucrChkAddMedianLabel")
        Me.ucrChkAddMedianLabel.Name = "ucrChkAddMedianLabel"
        '
        'ucrChkAddTercillesLabel
        '
        Me.ucrChkAddTercillesLabel.Checked = False
        resources.ApplyResources(Me.ucrChkAddTercillesLabel, "ucrChkAddTercillesLabel")
        Me.ucrChkAddTercillesLabel.Name = "ucrChkAddTercillesLabel"
        '
        'ucrChkFootNote
        '
        Me.ucrChkFootNote.Checked = False
        resources.ApplyResources(Me.ucrChkFootNote, "ucrChkFootNote")
        Me.ucrChkFootNote.Name = "ucrChkFootNote"
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
        'UcrInputTextBox1
        '
        Me.UcrInputTextBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputTextBox1.IsMultiline = False
        Me.UcrInputTextBox1.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputTextBox1, "UcrInputTextBox1")
        Me.UcrInputTextBox1.Name = "UcrInputTextBox1"
        '
        'sdgPICSARainfallGraph
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrNudXaxisLabelSize)
        Me.Controls.Add(Me.ucrNudXAxisAngle)
        Me.Controls.Add(Me.ucrNudYAxisTitleSize)
        Me.Controls.Add(Me.lblYAxisTitleSize)
        Me.Controls.Add(Me.ucrChkAddTercillesLabel)
        Me.Controls.Add(Me.ucrChkAddMedianLabel)
        Me.Controls.Add(Me.ucrChkAddMeanLabel)
        Me.Controls.Add(Me.ucrChkAddLabel)
        Me.Controls.Add(Me.ucrChkXaxisLabelSize)
        Me.Controls.Add(Me.UcrInputTextBox1)
        Me.Controls.Add(Me.ucrInputFootNote)
        Me.Controls.Add(Me.ucrChkSubFootNote)
        Me.Controls.Add(Me.ucrInputYAxisTitle)
        Me.Controls.Add(Me.ucrChkFootNote)
        Me.Controls.Add(Me.ucrChkXaxisAngle)
        Me.Controls.Add(Me.ucrChkYAxisTitle)
        Me.Controls.Add(Me.ucrChkPlotTerciles)
        Me.Controls.Add(Me.ucrChkPlotMedian)
        Me.Controls.Add(Me.ucrChkPlotMean)
        Me.Controls.Add(Me.ucrSdgPICSARainfalbuttons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPICSARainfallGraph"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSdgPICSARainfalbuttons As ucrButtonsSubdialogue
    Friend WithEvents ucrChkPlotMean As ucrCheck
    Friend WithEvents ucrChkPlotMedian As ucrCheck
    Friend WithEvents ucrChkPlotTerciles As ucrCheck
    Friend WithEvents ucrChkYAxisTitle As ucrCheck
    Friend WithEvents ucrInputYAxisTitle As ucrInputTextBox
    Friend WithEvents lblYAxisTitleSize As Label
    Friend WithEvents ucrNudYAxisTitleSize As ucrNud
    Friend WithEvents ucrChkXaxisAngle As ucrCheck
    Friend WithEvents ucrNudXAxisAngle As ucrNud
    Friend WithEvents ucrChkXaxisLabelSize As ucrCheck
    Friend WithEvents ucrNudXaxisLabelSize As ucrNud
    Friend WithEvents ucrChkAddLabel As ucrCheck
    Friend WithEvents ucrChkAddMeanLabel As ucrCheck
    Friend WithEvents ucrChkAddMedianLabel As ucrCheck
    Friend WithEvents ucrChkAddTercillesLabel As ucrCheck
    Friend WithEvents ucrChkFootNote As ucrCheck
    Friend WithEvents ucrInputFootNote As ucrInputTextBox
    Friend WithEvents ucrChkSubFootNote As ucrCheck
    Friend WithEvents UcrInputTextBox1 As ucrInputTextBox
End Class
