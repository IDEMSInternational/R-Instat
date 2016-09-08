<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCumulativeDistribution
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
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.chkExceedancePlots = New System.Windows.Forms.CheckBox()
        Me.chkCountsOnYAxis = New System.Windows.Forms.CheckBox()
        Me.chkIncludePoints = New System.Windows.Forms.CheckBox()
        Me.cmdLineOptions = New System.Windows.Forms.Button()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrCumDistSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveCumDist = New instat.ucrSaveGraph()
        Me.ucrVariablesAsFactorforCumDist = New instat.ucrVariablesAsFactor()
        Me.SuspendLayout()
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(255, 173)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(88, 13)
        Me.lblFactors.TabIndex = 3
        Me.lblFactors.Tag = "Factors_Optional"
        Me.lblFactors.Text = "Factor  (Optional)"
        '
        'chkExceedancePlots
        '
        Me.chkExceedancePlots.AutoSize = True
        Me.chkExceedancePlots.Location = New System.Drawing.Point(255, 217)
        Me.chkExceedancePlots.Name = "chkExceedancePlots"
        Me.chkExceedancePlots.Size = New System.Drawing.Size(112, 17)
        Me.chkExceedancePlots.TabIndex = 5
        Me.chkExceedancePlots.Tag = "Exceedance_Plots"
        Me.chkExceedancePlots.Text = "Exceedance Plots"
        Me.chkExceedancePlots.UseVisualStyleBackColor = True
        '
        'chkCountsOnYAxis
        '
        Me.chkCountsOnYAxis.AutoSize = True
        Me.chkCountsOnYAxis.Enabled = False
        Me.chkCountsOnYAxis.Location = New System.Drawing.Point(255, 243)
        Me.chkCountsOnYAxis.Name = "chkCountsOnYAxis"
        Me.chkCountsOnYAxis.Size = New System.Drawing.Size(108, 17)
        Me.chkCountsOnYAxis.TabIndex = 6
        Me.chkCountsOnYAxis.Tag = "Counts_On_YAxis"
        Me.chkCountsOnYAxis.Text = "Counts On Y-Axis"
        Me.chkCountsOnYAxis.UseVisualStyleBackColor = True
        '
        'chkIncludePoints
        '
        Me.chkIncludePoints.AutoSize = True
        Me.chkIncludePoints.Enabled = False
        Me.chkIncludePoints.Location = New System.Drawing.Point(255, 269)
        Me.chkIncludePoints.Name = "chkIncludePoints"
        Me.chkIncludePoints.Size = New System.Drawing.Size(93, 17)
        Me.chkIncludePoints.TabIndex = 7
        Me.chkIncludePoints.Tag = "Include Points"
        Me.chkIncludePoints.Text = "Include Points"
        Me.chkIncludePoints.UseVisualStyleBackColor = True
        '
        'cmdLineOptions
        '
        Me.cmdLineOptions.Location = New System.Drawing.Point(12, 210)
        Me.cmdLineOptions.Name = "cmdLineOptions"
        Me.cmdLineOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdLineOptions.TabIndex = 8
        Me.cmdLineOptions.Tag = "Line_Options"
        Me.cmdLineOptions.Text = "Line Options"
        Me.cmdLineOptions.UseVisualStyleBackColor = True
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.Location = New System.Drawing.Point(12, 253)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdPlotOptions.TabIndex = 9
        Me.cmdPlotOptions.Tag = "Plot_Options"
        Me.cmdPlotOptions.Text = "Plot Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(255, 188)
        Me.ucrFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrFactorReceiver.TabIndex = 4
        '
        'ucrCumDistSelector
        '
        Me.ucrCumDistSelector.bShowHiddenColumns = False
        Me.ucrCumDistSelector.bUseCurrentFilter = False
        Me.ucrCumDistSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrCumDistSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCumDistSelector.Name = "ucrCumDistSelector"
        Me.ucrCumDistSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrCumDistSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 325)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 11
        '
        'ucrSaveCumDist
        '
        Me.ucrSaveCumDist.Location = New System.Drawing.Point(10, 296)
        Me.ucrSaveCumDist.Name = "ucrSaveCumDist"
        Me.ucrSaveCumDist.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveCumDist.TabIndex = 10
        '
        'ucrVariablesAsFactorforCumDist
        '
        Me.ucrVariablesAsFactorforCumDist.Location = New System.Drawing.Point(255, 25)
        Me.ucrVariablesAsFactorforCumDist.Name = "ucrVariablesAsFactorforCumDist"
        Me.ucrVariablesAsFactorforCumDist.Size = New System.Drawing.Size(125, 136)
        Me.ucrVariablesAsFactorforCumDist.TabIndex = 2
        Me.ucrVariablesAsFactorforCumDist.ucrVariableSelector = Nothing
        '
        'dlgCumulativeDistribution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 379)
        Me.Controls.Add(Me.ucrVariablesAsFactorforCumDist)
        Me.Controls.Add(Me.ucrSaveCumDist)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.cmdLineOptions)
        Me.Controls.Add(Me.chkIncludePoints)
        Me.Controls.Add(Me.chkCountsOnYAxis)
        Me.Controls.Add(Me.chkExceedancePlots)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrCumDistSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCumulativeDistribution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Cumulative_Distribution"
        Me.Text = "Cumulative Distribution"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrCumDistSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactors As Label
    Friend WithEvents chkExceedancePlots As CheckBox
    Friend WithEvents chkCountsOnYAxis As CheckBox
    Friend WithEvents chkIncludePoints As CheckBox
    Friend WithEvents cmdLineOptions As Button
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucrSaveCumDist As ucrSaveGraph
    Friend WithEvents ucrVariablesAsFactorforCumDist As ucrVariablesAsFactor
End Class
