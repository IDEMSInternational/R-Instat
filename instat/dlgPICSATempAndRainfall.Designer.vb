<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPICSATempAndRainfall
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
        Me.ucrInputSaveResults = New instat.ucrInputComboBox()
        Me.chkSaveResults = New System.Windows.Forms.CheckBox()
        Me.grpPlots = New System.Windows.Forms.GroupBox()
        Me.chkTMean = New System.Windows.Forms.CheckBox()
        Me.chkTemperatureMin = New System.Windows.Forms.CheckBox()
        Me.chkTmax = New System.Windows.Forms.CheckBox()
        Me.chkTrendline = New System.Windows.Forms.CheckBox()
        Me.nudThreshholdVal = New System.Windows.Forms.NumericUpDown()
        Me.lblThreshhold = New System.Windows.Forms.Label()
        Me.lblTemperatureCol = New System.Windows.Forms.Label()
        Me.ucrReceiverForPICSATemporRainFall = New instat.ucrReceiverSingle()
        Me.ucrSelectorForPICSATempandRainfall = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrbase = New instat.ucrButtons()
        Me.ucrInputTempOrRainfall = New instat.ucrInputComboBox()
        Me.lblTemporRainfall = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkExteremes = New System.Windows.Forms.CheckBox()
        Me.chkTotalRaifall = New System.Windows.Forms.CheckBox()
        Me.chkSeasonalRainfall = New System.Windows.Forms.CheckBox()
        Me.chkTrendLineRainfall = New System.Windows.Forms.CheckBox()
        Me.lblRainfallCol = New System.Windows.Forms.Label()
        Me.grpPlots.SuspendLayout()
        CType(Me.nudThreshholdVal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrInputSaveResults
        '
        Me.ucrInputSaveResults.IsReadOnly = False
        Me.ucrInputSaveResults.Location = New System.Drawing.Point(102, 240)
        Me.ucrInputSaveResults.Name = "ucrInputSaveResults"
        Me.ucrInputSaveResults.Size = New System.Drawing.Size(153, 21)
        Me.ucrInputSaveResults.TabIndex = 17
        '
        'chkSaveResults
        '
        Me.chkSaveResults.AutoSize = True
        Me.chkSaveResults.Location = New System.Drawing.Point(14, 240)
        Me.chkSaveResults.Name = "chkSaveResults"
        Me.chkSaveResults.Size = New System.Drawing.Size(89, 17)
        Me.chkSaveResults.TabIndex = 16
        Me.chkSaveResults.Text = "Save Results"
        Me.chkSaveResults.UseVisualStyleBackColor = True
        '
        'grpPlots
        '
        Me.grpPlots.Controls.Add(Me.chkTMean)
        Me.grpPlots.Controls.Add(Me.chkTemperatureMin)
        Me.grpPlots.Controls.Add(Me.chkTmax)
        Me.grpPlots.Controls.Add(Me.chkTrendline)
        Me.grpPlots.Location = New System.Drawing.Point(254, 125)
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.Size = New System.Drawing.Size(153, 109)
        Me.grpPlots.TabIndex = 15
        Me.grpPlots.TabStop = False
        Me.grpPlots.Text = "Plots"
        '
        'chkTMean
        '
        Me.chkTMean.AutoSize = True
        Me.chkTMean.Location = New System.Drawing.Point(6, 88)
        Me.chkTMean.Name = "chkTMean"
        Me.chkTMean.Size = New System.Drawing.Size(116, 17)
        Me.chkTMean.TabIndex = 3
        Me.chkTMean.Text = "Temperature Mean"
        Me.chkTMean.UseVisualStyleBackColor = True
        '
        'chkTemperatureMin
        '
        Me.chkTemperatureMin.AutoSize = True
        Me.chkTemperatureMin.Location = New System.Drawing.Point(6, 65)
        Me.chkTemperatureMin.Name = "chkTemperatureMin"
        Me.chkTemperatureMin.Size = New System.Drawing.Size(130, 17)
        Me.chkTemperatureMin.TabIndex = 2
        Me.chkTemperatureMin.Text = "Temperature Minimum"
        Me.chkTemperatureMin.UseVisualStyleBackColor = True
        '
        'chkTmax
        '
        Me.chkTmax.AutoSize = True
        Me.chkTmax.Location = New System.Drawing.Point(6, 42)
        Me.chkTmax.Name = "chkTmax"
        Me.chkTmax.Size = New System.Drawing.Size(133, 17)
        Me.chkTmax.TabIndex = 1
        Me.chkTmax.Text = "Temperature Maximum"
        Me.chkTmax.UseVisualStyleBackColor = True
        '
        'chkTrendline
        '
        Me.chkTrendline.AutoSize = True
        Me.chkTrendline.Location = New System.Drawing.Point(6, 19)
        Me.chkTrendline.Name = "chkTrendline"
        Me.chkTrendline.Size = New System.Drawing.Size(77, 17)
        Me.chkTrendline.TabIndex = 0
        Me.chkTrendline.Text = "Trend Line"
        Me.chkTrendline.UseVisualStyleBackColor = True
        '
        'nudThreshholdVal
        '
        Me.nudThreshholdVal.Location = New System.Drawing.Point(341, 98)
        Me.nudThreshholdVal.Name = "nudThreshholdVal"
        Me.nudThreshholdVal.Size = New System.Drawing.Size(49, 20)
        Me.nudThreshholdVal.TabIndex = 14
        '
        'lblThreshhold
        '
        Me.lblThreshhold.AutoSize = True
        Me.lblThreshhold.Location = New System.Drawing.Point(248, 101)
        Me.lblThreshhold.Name = "lblThreshhold"
        Me.lblThreshhold.Size = New System.Drawing.Size(90, 13)
        Me.lblThreshhold.TabIndex = 13
        Me.lblThreshhold.Text = "Threshhold Value"
        '
        'lblTemperatureCol
        '
        Me.lblTemperatureCol.AutoSize = True
        Me.lblTemperatureCol.Location = New System.Drawing.Point(248, 50)
        Me.lblTemperatureCol.Name = "lblTemperatureCol"
        Me.lblTemperatureCol.Size = New System.Drawing.Size(108, 13)
        Me.lblTemperatureCol.TabIndex = 12
        Me.lblTemperatureCol.Text = "Temperature Variable"
        '
        'ucrReceiverForPICSATemporRainFall
        '
        Me.ucrReceiverForPICSATemporRainFall.Location = New System.Drawing.Point(251, 68)
        Me.ucrReceiverForPICSATemporRainFall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForPICSATemporRainFall.Name = "ucrReceiverForPICSATemporRainFall"
        Me.ucrReceiverForPICSATemporRainFall.Selector = Nothing
        Me.ucrReceiverForPICSATemporRainFall.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverForPICSATemporRainFall.TabIndex = 11
        '
        'ucrSelectorForPICSATempandRainfall
        '
        Me.ucrSelectorForPICSATempandRainfall.bShowHiddenColumns = False
        Me.ucrSelectorForPICSATempandRainfall.bUseCurrentFilter = True
        Me.ucrSelectorForPICSATempandRainfall.Location = New System.Drawing.Point(14, 50)
        Me.ucrSelectorForPICSATempandRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForPICSATempandRainfall.Name = "ucrSelectorForPICSATempandRainfall"
        Me.ucrSelectorForPICSATempandRainfall.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForPICSATempandRainfall.TabIndex = 10
        '
        'ucrbase
        '
        Me.ucrbase.Location = New System.Drawing.Point(13, 267)
        Me.ucrbase.Name = "ucrbase"
        Me.ucrbase.Size = New System.Drawing.Size(410, 52)
        Me.ucrbase.TabIndex = 9
        '
        'ucrInputTempOrRainfall
        '
        Me.ucrInputTempOrRainfall.IsReadOnly = False
        Me.ucrInputTempOrRainfall.Location = New System.Drawing.Point(146, 12)
        Me.ucrInputTempOrRainfall.Name = "ucrInputTempOrRainfall"
        Me.ucrInputTempOrRainfall.Size = New System.Drawing.Size(210, 21)
        Me.ucrInputTempOrRainfall.TabIndex = 18
        '
        'lblTemporRainfall
        '
        Me.lblTemporRainfall.AutoSize = True
        Me.lblTemporRainfall.Location = New System.Drawing.Point(13, 16)
        Me.lblTemporRainfall.Name = "lblTemporRainfall"
        Me.lblTemporRainfall.Size = New System.Drawing.Size(107, 13)
        Me.lblTemporRainfall.TabIndex = 19
        Me.lblTemporRainfall.Text = "Temperature/Rainfall"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkExteremes)
        Me.GroupBox1.Controls.Add(Me.chkTotalRaifall)
        Me.GroupBox1.Controls.Add(Me.chkSeasonalRainfall)
        Me.GroupBox1.Controls.Add(Me.chkTrendLineRainfall)
        Me.GroupBox1.Location = New System.Drawing.Point(253, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 109)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plots"
        '
        'chkExteremes
        '
        Me.chkExteremes.AutoSize = True
        Me.chkExteremes.Location = New System.Drawing.Point(6, 88)
        Me.chkExteremes.Name = "chkExteremes"
        Me.chkExteremes.Size = New System.Drawing.Size(69, 17)
        Me.chkExteremes.TabIndex = 3
        Me.chkExteremes.Text = "Extremes"
        Me.chkExteremes.UseVisualStyleBackColor = True
        '
        'chkTotalRaifall
        '
        Me.chkTotalRaifall.AutoSize = True
        Me.chkTotalRaifall.Location = New System.Drawing.Point(6, 65)
        Me.chkTotalRaifall.Name = "chkTotalRaifall"
        Me.chkTotalRaifall.Size = New System.Drawing.Size(88, 17)
        Me.chkTotalRaifall.TabIndex = 2
        Me.chkTotalRaifall.Text = "Total Rainfall"
        Me.chkTotalRaifall.UseVisualStyleBackColor = True
        '
        'chkSeasonalRainfall
        '
        Me.chkSeasonalRainfall.AutoSize = True
        Me.chkSeasonalRainfall.Location = New System.Drawing.Point(6, 42)
        Me.chkSeasonalRainfall.Name = "chkSeasonalRainfall"
        Me.chkSeasonalRainfall.Size = New System.Drawing.Size(108, 17)
        Me.chkSeasonalRainfall.TabIndex = 1
        Me.chkSeasonalRainfall.Text = "Seasonal Rainfall"
        Me.chkSeasonalRainfall.UseVisualStyleBackColor = True
        '
        'chkTrendLineRainfall
        '
        Me.chkTrendLineRainfall.AutoSize = True
        Me.chkTrendLineRainfall.Location = New System.Drawing.Point(8, 18)
        Me.chkTrendLineRainfall.Name = "chkTrendLineRainfall"
        Me.chkTrendLineRainfall.Size = New System.Drawing.Size(77, 17)
        Me.chkTrendLineRainfall.TabIndex = 0
        Me.chkTrendLineRainfall.Text = "Trend Line"
        Me.chkTrendLineRainfall.UseVisualStyleBackColor = True
        '
        'lblRainfallCol
        '
        Me.lblRainfallCol.AutoSize = True
        Me.lblRainfallCol.Location = New System.Drawing.Point(251, 50)
        Me.lblRainfallCol.Name = "lblRainfallCol"
        Me.lblRainfallCol.Size = New System.Drawing.Size(83, 13)
        Me.lblRainfallCol.TabIndex = 21
        Me.lblRainfallCol.Text = "Rainfall Variable"
        '
        'dlgPICSATempAndRainfall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 321)
        Me.Controls.Add(Me.lblRainfallCol)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTemporRainfall)
        Me.Controls.Add(Me.ucrInputTempOrRainfall)
        Me.Controls.Add(Me.ucrInputSaveResults)
        Me.Controls.Add(Me.chkSaveResults)
        Me.Controls.Add(Me.grpPlots)
        Me.Controls.Add(Me.nudThreshholdVal)
        Me.Controls.Add(Me.lblThreshhold)
        Me.Controls.Add(Me.lblTemperatureCol)
        Me.Controls.Add(Me.ucrReceiverForPICSATemporRainFall)
        Me.Controls.Add(Me.ucrSelectorForPICSATempandRainfall)
        Me.Controls.Add(Me.ucrbase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPICSATempAndRainfall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PICSA Temperature and Rainfall"
        Me.grpPlots.ResumeLayout(False)
        Me.grpPlots.PerformLayout()
        CType(Me.nudThreshholdVal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputSaveResults As ucrInputComboBox
    Friend WithEvents chkSaveResults As CheckBox
    Friend WithEvents grpPlots As GroupBox
    Friend WithEvents chkTMean As CheckBox
    Friend WithEvents chkTemperatureMin As CheckBox
    Friend WithEvents chkTmax As CheckBox
    Friend WithEvents chkTrendline As CheckBox
    Friend WithEvents nudThreshholdVal As NumericUpDown
    Friend WithEvents lblThreshhold As Label
    Friend WithEvents lblTemperatureCol As Label
    Friend WithEvents ucrReceiverForPICSATemporRainFall As ucrReceiverSingle
    Friend WithEvents ucrSelectorForPICSATempandRainfall As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrbase As ucrButtons
    Friend WithEvents ucrInputTempOrRainfall As ucrInputComboBox
    Friend WithEvents lblTemporRainfall As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkExteremes As CheckBox
    Friend WithEvents chkTotalRaifall As CheckBox
    Friend WithEvents chkSeasonalRainfall As CheckBox
    Friend WithEvents chkTrendLineRainfall As CheckBox
    Friend WithEvents lblRainfallCol As Label
End Class
