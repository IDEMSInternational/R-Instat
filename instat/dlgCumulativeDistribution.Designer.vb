<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCumulativeDistribution
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
        Me.ucrCumDistSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrVariatesreceiver = New instat.ucrReceiverMultiple()
        Me.lblvariates = New System.Windows.Forms.Label()
        Me.ucrFactorReceiver = New instat.ucrReceiverMultiple()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.chkExeedancePlots = New System.Windows.Forms.CheckBox()
        Me.chkCountsOnYAxis = New System.Windows.Forms.CheckBox()
        Me.chkIncludePoints = New System.Windows.Forms.CheckBox()
        Me.cmdLineOptions = New System.Windows.Forms.Button()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.cmdThemeOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 331)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrCumDistSelector
        '
        Me.ucrCumDistSelector.Location = New System.Drawing.Point(4, 4)
        Me.ucrCumDistSelector.Name = "ucrCumDistSelector"
        Me.ucrCumDistSelector.Size = New System.Drawing.Size(242, 179)
        Me.ucrCumDistSelector.TabIndex = 1
        '
        'ucrVariatesreceiver
        '
        Me.ucrVariatesreceiver.Location = New System.Drawing.Point(270, 29)
        Me.ucrVariatesreceiver.Name = "ucrVariatesreceiver"
        Me.ucrVariatesreceiver.Selector = Nothing
        Me.ucrVariatesreceiver.Size = New System.Drawing.Size(121, 104)
        Me.ucrVariatesreceiver.TabIndex = 2
        '
        'lblvariates
        '
        Me.lblvariates.AutoSize = True
        Me.lblvariates.Location = New System.Drawing.Point(270, 10)
        Me.lblvariates.Name = "lblvariates"
        Me.lblvariates.Size = New System.Drawing.Size(51, 13)
        Me.lblvariates.TabIndex = 3
        Me.lblvariates.Tag = "Variates"
        Me.lblvariates.Text = "Variate(s)"
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(273, 167)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(121, 104)
        Me.ucrFactorReceiver.TabIndex = 2
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(273, 148)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(96, 13)
        Me.lblFactors.TabIndex = 3
        Me.lblFactors.Tag = "Factors_Optional"
        Me.lblFactors.Text = "Factor(s) (Optional)"
        '
        'chkExeedancePlots
        '
        Me.chkExeedancePlots.AutoSize = True
        Me.chkExeedancePlots.Location = New System.Drawing.Point(13, 181)
        Me.chkExeedancePlots.Name = "chkExeedancePlots"
        Me.chkExeedancePlots.Size = New System.Drawing.Size(106, 17)
        Me.chkExeedancePlots.TabIndex = 4
        Me.chkExeedancePlots.Tag = "Exeedance_Plots"
        Me.chkExeedancePlots.Text = "Exeedance Plots"
        Me.chkExeedancePlots.UseVisualStyleBackColor = True
        '
        'chkCountsOnYAxis
        '
        Me.chkCountsOnYAxis.AutoSize = True
        Me.chkCountsOnYAxis.Location = New System.Drawing.Point(12, 217)
        Me.chkCountsOnYAxis.Name = "chkCountsOnYAxis"
        Me.chkCountsOnYAxis.Size = New System.Drawing.Size(108, 17)
        Me.chkCountsOnYAxis.TabIndex = 4
        Me.chkCountsOnYAxis.Tag = "Counts_On_YAxis"
        Me.chkCountsOnYAxis.Text = "Counts On Y-Axis"
        Me.chkCountsOnYAxis.UseVisualStyleBackColor = True
        '
        'chkIncludePoints
        '
        Me.chkIncludePoints.AutoSize = True
        Me.chkIncludePoints.Location = New System.Drawing.Point(13, 254)
        Me.chkIncludePoints.Name = "chkIncludePoints"
        Me.chkIncludePoints.Size = New System.Drawing.Size(93, 17)
        Me.chkIncludePoints.TabIndex = 4
        Me.chkIncludePoints.Tag = "Include Points"
        Me.chkIncludePoints.Text = "Include Points"
        Me.chkIncludePoints.UseVisualStyleBackColor = True
        '
        'cmdLineOptions
        '
        Me.cmdLineOptions.Location = New System.Drawing.Point(13, 294)
        Me.cmdLineOptions.Name = "cmdLineOptions"
        Me.cmdLineOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdLineOptions.TabIndex = 5
        Me.cmdLineOptions.Tag = "Line_Options"
        Me.cmdLineOptions.Text = "Line Options"
        Me.cmdLineOptions.UseVisualStyleBackColor = True
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.Location = New System.Drawing.Point(146, 294)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdPlotOptions.TabIndex = 5
        Me.cmdPlotOptions.Tag = "Plot_Options"
        Me.cmdPlotOptions.Text = "Plot Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdThemeOptions
        '
        Me.cmdThemeOptions.Location = New System.Drawing.Point(276, 294)
        Me.cmdThemeOptions.Name = "cmdThemeOptions"
        Me.cmdThemeOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdThemeOptions.TabIndex = 5
        Me.cmdThemeOptions.Tag = "Theme_Options"
        Me.cmdThemeOptions.Text = "Theme Options"
        Me.cmdThemeOptions.UseVisualStyleBackColor = True
        '
        'dlgCumulativeDistribution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 390)
        Me.Controls.Add(Me.cmdThemeOptions)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.cmdLineOptions)
        Me.Controls.Add(Me.chkIncludePoints)
        Me.Controls.Add(Me.chkCountsOnYAxis)
        Me.Controls.Add(Me.chkExeedancePlots)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.lblvariates)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.ucrVariatesreceiver)
        Me.Controls.Add(Me.ucrCumDistSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCumulativeDistribution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Cumulative_Distribution"
        Me.Text = "Cumulative Distribution"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrCumDistSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrVariatesreceiver As ucrReceiverMultiple
    Friend WithEvents lblvariates As Label
    Friend WithEvents ucrFactorReceiver As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents chkExeedancePlots As CheckBox
    Friend WithEvents chkCountsOnYAxis As CheckBox
    Friend WithEvents chkIncludePoints As CheckBox
    Friend WithEvents cmdLineOptions As Button
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents cmdThemeOptions As Button
End Class
