<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPICSA
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
        Me.lblRainfallCol = New System.Windows.Forms.Label()
        Me.grpRainFallPlots = New System.Windows.Forms.GroupBox()
        Me.chkExteremes = New System.Windows.Forms.CheckBox()
        Me.chkTotalRaifall = New System.Windows.Forms.CheckBox()
        Me.chkSeasonalRainfall = New System.Windows.Forms.CheckBox()
        Me.chkTrendLineRainfall = New System.Windows.Forms.CheckBox()
        Me.lblTemporRainfall = New System.Windows.Forms.Label()
        Me.ucrInputTempOrRainfall = New instat.ucrInputComboBox()
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
        Me.ucrReceiverForPICSA = New instat.ucrReceiverSingle()
        Me.ucrSelectorForPICSA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrbase = New instat.ucrButtons()
        Me.grpCropModels = New System.Windows.Forms.GroupBox()
        Me.grpRainFallPlots.SuspendLayout()
        Me.grpPlots.SuspendLayout()
        CType(Me.nudThreshholdVal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRainfallCol
        '
        Me.lblRainfallCol.AutoSize = True
        Me.lblRainfallCol.Location = New System.Drawing.Point(248, 48)
        Me.lblRainfallCol.Name = "lblRainfallCol"
        Me.lblRainfallCol.Size = New System.Drawing.Size(83, 13)
        Me.lblRainfallCol.TabIndex = 34
        Me.lblRainfallCol.Text = "Rainfall Variable"
        '
        'grpRainFallPlots
        '
        Me.grpRainFallPlots.Controls.Add(Me.chkExteremes)
        Me.grpRainFallPlots.Controls.Add(Me.chkTotalRaifall)
        Me.grpRainFallPlots.Controls.Add(Me.chkSeasonalRainfall)
        Me.grpRainFallPlots.Controls.Add(Me.chkTrendLineRainfall)
        Me.grpRainFallPlots.Location = New System.Drawing.Point(250, 124)
        Me.grpRainFallPlots.Name = "grpRainFallPlots"
        Me.grpRainFallPlots.Size = New System.Drawing.Size(153, 109)
        Me.grpRainFallPlots.TabIndex = 33
        Me.grpRainFallPlots.TabStop = False
        Me.grpRainFallPlots.Text = "Plots"
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
        'lblTemporRainfall
        '
        Me.lblTemporRainfall.AutoSize = True
        Me.lblTemporRainfall.Location = New System.Drawing.Point(10, 14)
        Me.lblTemporRainfall.Name = "lblTemporRainfall"
        Me.lblTemporRainfall.Size = New System.Drawing.Size(107, 13)
        Me.lblTemporRainfall.TabIndex = 32
        Me.lblTemporRainfall.Text = "Temperature/Rainfall"
        '
        'ucrInputTempOrRainfall
        '
        Me.ucrInputTempOrRainfall.IsReadOnly = False
        Me.ucrInputTempOrRainfall.Location = New System.Drawing.Point(143, 10)
        Me.ucrInputTempOrRainfall.Name = "ucrInputTempOrRainfall"
        Me.ucrInputTempOrRainfall.Size = New System.Drawing.Size(210, 21)
        Me.ucrInputTempOrRainfall.TabIndex = 31
        '
        'ucrInputSaveResults
        '
        Me.ucrInputSaveResults.IsReadOnly = False
        Me.ucrInputSaveResults.Location = New System.Drawing.Point(106, 323)
        Me.ucrInputSaveResults.Name = "ucrInputSaveResults"
        Me.ucrInputSaveResults.Size = New System.Drawing.Size(297, 21)
        Me.ucrInputSaveResults.TabIndex = 30
        '
        'chkSaveResults
        '
        Me.chkSaveResults.AutoSize = True
        Me.chkSaveResults.Location = New System.Drawing.Point(11, 327)
        Me.chkSaveResults.Name = "chkSaveResults"
        Me.chkSaveResults.Size = New System.Drawing.Size(89, 17)
        Me.chkSaveResults.TabIndex = 29
        Me.chkSaveResults.Text = "Save Results"
        Me.chkSaveResults.UseVisualStyleBackColor = True
        '
        'grpPlots
        '
        Me.grpPlots.Controls.Add(Me.chkTMean)
        Me.grpPlots.Controls.Add(Me.chkTemperatureMin)
        Me.grpPlots.Controls.Add(Me.chkTmax)
        Me.grpPlots.Controls.Add(Me.chkTrendline)
        Me.grpPlots.Location = New System.Drawing.Point(251, 123)
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.Size = New System.Drawing.Size(153, 109)
        Me.grpPlots.TabIndex = 28
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
        Me.nudThreshholdVal.Location = New System.Drawing.Point(338, 96)
        Me.nudThreshholdVal.Name = "nudThreshholdVal"
        Me.nudThreshholdVal.Size = New System.Drawing.Size(49, 20)
        Me.nudThreshholdVal.TabIndex = 27
        '
        'lblThreshhold
        '
        Me.lblThreshhold.AutoSize = True
        Me.lblThreshhold.Location = New System.Drawing.Point(245, 99)
        Me.lblThreshhold.Name = "lblThreshhold"
        Me.lblThreshhold.Size = New System.Drawing.Size(90, 13)
        Me.lblThreshhold.TabIndex = 26
        Me.lblThreshhold.Text = "Threshhold Value"
        '
        'lblTemperatureCol
        '
        Me.lblTemperatureCol.AutoSize = True
        Me.lblTemperatureCol.Location = New System.Drawing.Point(245, 48)
        Me.lblTemperatureCol.Name = "lblTemperatureCol"
        Me.lblTemperatureCol.Size = New System.Drawing.Size(108, 13)
        Me.lblTemperatureCol.TabIndex = 25
        Me.lblTemperatureCol.Text = "Temperature Variable"
        '
        'ucrReceiverForPICSA
        '
        Me.ucrReceiverForPICSA.Location = New System.Drawing.Point(248, 66)
        Me.ucrReceiverForPICSA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForPICSA.Name = "ucrReceiverForPICSA"
        Me.ucrReceiverForPICSA.Selector = Nothing
        Me.ucrReceiverForPICSA.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverForPICSA.TabIndex = 24
        '
        'ucrSelectorForPICSA
        '
        Me.ucrSelectorForPICSA.bShowHiddenColumns = False
        Me.ucrSelectorForPICSA.bUseCurrentFilter = True
        Me.ucrSelectorForPICSA.Location = New System.Drawing.Point(11, 48)
        Me.ucrSelectorForPICSA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForPICSA.Name = "ucrSelectorForPICSA"
        Me.ucrSelectorForPICSA.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForPICSA.TabIndex = 23
        '
        'ucrbase
        '
        Me.ucrbase.Location = New System.Drawing.Point(11, 350)
        Me.ucrbase.Name = "ucrbase"
        Me.ucrbase.Size = New System.Drawing.Size(410, 52)
        Me.ucrbase.TabIndex = 22
        '
        'grpCropModels
        '
        Me.grpCropModels.Location = New System.Drawing.Point(11, 238)
        Me.grpCropModels.Name = "grpCropModels"
        Me.grpCropModels.Size = New System.Drawing.Size(392, 79)
        Me.grpCropModels.TabIndex = 35
        Me.grpCropModels.TabStop = False
        Me.grpCropModels.Text = "Crop Models"
        '
        'dlgPICSA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 405)
        Me.Controls.Add(Me.grpCropModels)
        Me.Controls.Add(Me.lblRainfallCol)
        Me.Controls.Add(Me.grpRainFallPlots)
        Me.Controls.Add(Me.lblTemporRainfall)
        Me.Controls.Add(Me.ucrInputTempOrRainfall)
        Me.Controls.Add(Me.ucrInputSaveResults)
        Me.Controls.Add(Me.chkSaveResults)
        Me.Controls.Add(Me.grpPlots)
        Me.Controls.Add(Me.nudThreshholdVal)
        Me.Controls.Add(Me.lblThreshhold)
        Me.Controls.Add(Me.lblTemperatureCol)
        Me.Controls.Add(Me.ucrReceiverForPICSA)
        Me.Controls.Add(Me.ucrSelectorForPICSA)
        Me.Controls.Add(Me.ucrbase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPICSA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PICSA"
        Me.grpRainFallPlots.ResumeLayout(False)
        Me.grpRainFallPlots.PerformLayout()
        Me.grpPlots.ResumeLayout(False)
        Me.grpPlots.PerformLayout()
        CType(Me.nudThreshholdVal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRainfallCol As Label
    Friend WithEvents grpRainFallPlots As GroupBox
    Friend WithEvents chkExteremes As CheckBox
    Friend WithEvents chkTotalRaifall As CheckBox
    Friend WithEvents chkSeasonalRainfall As CheckBox
    Friend WithEvents chkTrendLineRainfall As CheckBox
    Friend WithEvents lblTemporRainfall As Label
    Friend WithEvents ucrInputTempOrRainfall As ucrInputComboBox
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
    Friend WithEvents ucrReceiverForPICSA As ucrReceiverSingle
    Friend WithEvents ucrSelectorForPICSA As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrbase As ucrButtons
    Friend WithEvents grpCropModels As GroupBox
End Class
