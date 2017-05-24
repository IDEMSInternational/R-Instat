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
        Me.cmdLineOptions = New System.Windows.Forms.Button()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.ucrChkExceedancePlots = New instat.ucrCheck()
        Me.ucrSaveCumDist = New instat.ucrSave()
        Me.ucrVariablesAsFactorforCumDist = New instat.ucrVariablesAsFactor()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrCumDistSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkCountsOnYAxis = New instat.ucrCheck()
        Me.ucrChkIncludePoints = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(255, 173)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(88, 13)
        Me.lblFactors.TabIndex = 2
        Me.lblFactors.Tag = "Factors_Optional:"
        Me.lblFactors.Text = "Factor (Optional):"
        '
        'cmdLineOptions
        '
        Me.cmdLineOptions.Enabled = False
        Me.cmdLineOptions.Location = New System.Drawing.Point(10, 198)
        Me.cmdLineOptions.Name = "cmdLineOptions"
        Me.cmdLineOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdLineOptions.TabIndex = 4
        Me.cmdLineOptions.Tag = "Line_Options"
        Me.cmdLineOptions.Text = "Line Options"
        Me.cmdLineOptions.UseVisualStyleBackColor = True
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.Location = New System.Drawing.Point(10, 229)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdPlotOptions.TabIndex = 5
        Me.cmdPlotOptions.Tag = "Plot_Options"
        Me.cmdPlotOptions.Text = "Plot Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrChkExceedancePlots
        '
        Me.ucrChkExceedancePlots.Checked = False
        Me.ucrChkExceedancePlots.Location = New System.Drawing.Point(10, 260)
        Me.ucrChkExceedancePlots.Name = "ucrChkExceedancePlots"
        Me.ucrChkExceedancePlots.Size = New System.Drawing.Size(152, 20)
        Me.ucrChkExceedancePlots.TabIndex = 6
        '
        'ucrSaveCumDist
        '
        Me.ucrSaveCumDist.Location = New System.Drawing.Point(10, 338)
        Me.ucrSaveCumDist.Name = "ucrSaveCumDist"
        Me.ucrSaveCumDist.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveCumDist.TabIndex = 9
        '
        'ucrVariablesAsFactorforCumDist
        '
        Me.ucrVariablesAsFactorforCumDist.frmParent = Me
        Me.ucrVariablesAsFactorforCumDist.Location = New System.Drawing.Point(255, 30)
        Me.ucrVariablesAsFactorforCumDist.Name = "ucrVariablesAsFactorforCumDist"
        Me.ucrVariablesAsFactorforCumDist.Selector = Nothing
        Me.ucrVariablesAsFactorforCumDist.Size = New System.Drawing.Size(125, 136)
        Me.ucrVariablesAsFactorforCumDist.strNcFilePath = ""
        Me.ucrVariablesAsFactorforCumDist.TabIndex = 1
        Me.ucrVariablesAsFactorforCumDist.ucrSelector = Nothing
        Me.ucrVariablesAsFactorforCumDist.ucrVariableSelector = Nothing
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.frmParent = Me
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(255, 188)
        Me.ucrFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(125, 26)
        Me.ucrFactorReceiver.strNcFilePath = ""
        Me.ucrFactorReceiver.TabIndex = 3
        Me.ucrFactorReceiver.ucrSelector = Nothing
        '
        'ucrCumDistSelector
        '
        Me.ucrCumDistSelector.bShowHiddenColumns = False
        Me.ucrCumDistSelector.bUseCurrentFilter = True
        Me.ucrCumDistSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrCumDistSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCumDistSelector.Name = "ucrCumDistSelector"
        Me.ucrCumDistSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrCumDistSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 363)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrChkCountsOnYAxis
        '
        Me.ucrChkCountsOnYAxis.Checked = False
        Me.ucrChkCountsOnYAxis.Location = New System.Drawing.Point(10, 286)
        Me.ucrChkCountsOnYAxis.Name = "ucrChkCountsOnYAxis"
        Me.ucrChkCountsOnYAxis.Size = New System.Drawing.Size(152, 20)
        Me.ucrChkCountsOnYAxis.TabIndex = 7
        '
        'ucrChkIncludePoints
        '
        Me.ucrChkIncludePoints.Checked = False
        Me.ucrChkIncludePoints.Location = New System.Drawing.Point(10, 312)
        Me.ucrChkIncludePoints.Name = "ucrChkIncludePoints"
        Me.ucrChkIncludePoints.Size = New System.Drawing.Size(152, 20)
        Me.ucrChkIncludePoints.TabIndex = 8
        '
        'dlgCumulativeDistribution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 418)
        Me.Controls.Add(Me.ucrChkIncludePoints)
        Me.Controls.Add(Me.ucrChkCountsOnYAxis)
        Me.Controls.Add(Me.ucrChkExceedancePlots)
        Me.Controls.Add(Me.ucrSaveCumDist)
        Me.Controls.Add(Me.ucrVariablesAsFactorforCumDist)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.cmdLineOptions)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrCumDistSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCumulativeDistribution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Cumulative_Distribution"
        Me.Text = "Cumulative/Exceedance Graphs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrCumDistSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactors As Label
    Friend WithEvents cmdLineOptions As Button
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucrVariablesAsFactorforCumDist As ucrVariablesAsFactor
    Friend WithEvents ucrSaveCumDist As ucrSave
    Friend WithEvents ucrChkExceedancePlots As ucrCheck
    Friend WithEvents ucrChkIncludePoints As ucrCheck
    Friend WithEvents ucrChkCountsOnYAxis As ucrCheck
End Class
