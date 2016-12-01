<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRainfallPICSA
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
        Me.chkExteremes = New System.Windows.Forms.CheckBox()
        Me.chkTotalRaifall = New System.Windows.Forms.CheckBox()
        Me.chkSeasonalRainfall = New System.Windows.Forms.CheckBox()
        Me.chkTrendline = New System.Windows.Forms.CheckBox()
        Me.nudThreshholdVal = New System.Windows.Forms.NumericUpDown()
        Me.lblThreshhold = New System.Windows.Forms.Label()
        Me.lblRainfallCol = New System.Windows.Forms.Label()
        Me.ucrReceiverForPICSARainfall = New instat.ucrReceiverSingle()
        Me.ucrSelectorForPICSARainfall = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrbase = New instat.ucrButtons()
        Me.grpPlots.SuspendLayout()
        CType(Me.nudThreshholdVal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrInputSaveResults
        '
        Me.ucrInputSaveResults.IsReadOnly = False
        Me.ucrInputSaveResults.Location = New System.Drawing.Point(95, 215)
        Me.ucrInputSaveResults.Name = "ucrInputSaveResults"
        Me.ucrInputSaveResults.Size = New System.Drawing.Size(153, 21)
        Me.ucrInputSaveResults.TabIndex = 17
        '
        'chkSaveResults
        '
        Me.chkSaveResults.AutoSize = True
        Me.chkSaveResults.Location = New System.Drawing.Point(7, 215)
        Me.chkSaveResults.Name = "chkSaveResults"
        Me.chkSaveResults.Size = New System.Drawing.Size(89, 17)
        Me.chkSaveResults.TabIndex = 16
        Me.chkSaveResults.Text = "Save Results"
        Me.chkSaveResults.UseVisualStyleBackColor = True
        '
        'grpPlots
        '
        Me.grpPlots.Controls.Add(Me.chkExteremes)
        Me.grpPlots.Controls.Add(Me.chkTotalRaifall)
        Me.grpPlots.Controls.Add(Me.chkSeasonalRainfall)
        Me.grpPlots.Controls.Add(Me.chkTrendline)
        Me.grpPlots.Location = New System.Drawing.Point(244, 99)
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.Size = New System.Drawing.Size(153, 109)
        Me.grpPlots.TabIndex = 15
        Me.grpPlots.TabStop = False
        Me.grpPlots.Text = "Plots"
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
        Me.nudThreshholdVal.Location = New System.Drawing.Point(334, 73)
        Me.nudThreshholdVal.Name = "nudThreshholdVal"
        Me.nudThreshholdVal.Size = New System.Drawing.Size(49, 20)
        Me.nudThreshholdVal.TabIndex = 14
        '
        'lblThreshhold
        '
        Me.lblThreshhold.AutoSize = True
        Me.lblThreshhold.Location = New System.Drawing.Point(241, 75)
        Me.lblThreshhold.Name = "lblThreshhold"
        Me.lblThreshhold.Size = New System.Drawing.Size(90, 13)
        Me.lblThreshhold.TabIndex = 13
        Me.lblThreshhold.Text = "Threshhold Value"
        '
        'lblRainfallCol
        '
        Me.lblRainfallCol.AutoSize = True
        Me.lblRainfallCol.Location = New System.Drawing.Point(241, 25)
        Me.lblRainfallCol.Name = "lblRainfallCol"
        Me.lblRainfallCol.Size = New System.Drawing.Size(83, 13)
        Me.lblRainfallCol.TabIndex = 12
        Me.lblRainfallCol.Text = "Rainfall Variable"
        '
        'ucrReceiverForPICSARainfall
        '
        Me.ucrReceiverForPICSARainfall.Location = New System.Drawing.Point(244, 43)
        Me.ucrReceiverForPICSARainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForPICSARainfall.Name = "ucrReceiverForPICSARainfall"
        Me.ucrReceiverForPICSARainfall.Selector = Nothing
        Me.ucrReceiverForPICSARainfall.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverForPICSARainfall.TabIndex = 11
        '
        'ucrSelectorForPICSARainfall
        '
        Me.ucrSelectorForPICSARainfall.bShowHiddenColumns = False
        Me.ucrSelectorForPICSARainfall.bUseCurrentFilter = True
        Me.ucrSelectorForPICSARainfall.Location = New System.Drawing.Point(7, 14)
        Me.ucrSelectorForPICSARainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForPICSARainfall.Name = "ucrSelectorForPICSARainfall"
        Me.ucrSelectorForPICSARainfall.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForPICSARainfall.TabIndex = 10
        '
        'ucrbase
        '
        Me.ucrbase.Location = New System.Drawing.Point(6, 242)
        Me.ucrbase.Name = "ucrbase"
        Me.ucrbase.Size = New System.Drawing.Size(410, 52)
        Me.ucrbase.TabIndex = 9
        '
        'dlgRainfallPICSA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 295)
        Me.Controls.Add(Me.ucrInputSaveResults)
        Me.Controls.Add(Me.chkSaveResults)
        Me.Controls.Add(Me.grpPlots)
        Me.Controls.Add(Me.nudThreshholdVal)
        Me.Controls.Add(Me.lblThreshhold)
        Me.Controls.Add(Me.lblRainfallCol)
        Me.Controls.Add(Me.ucrReceiverForPICSARainfall)
        Me.Controls.Add(Me.ucrSelectorForPICSARainfall)
        Me.Controls.Add(Me.ucrbase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRainfallPICSA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rainfall"
        Me.grpPlots.ResumeLayout(False)
        Me.grpPlots.PerformLayout()
        CType(Me.nudThreshholdVal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputSaveResults As ucrInputComboBox
    Friend WithEvents chkSaveResults As CheckBox
    Friend WithEvents grpPlots As GroupBox
    Friend WithEvents chkExteremes As CheckBox
    Friend WithEvents chkTotalRaifall As CheckBox
    Friend WithEvents chkSeasonalRainfall As CheckBox
    Friend WithEvents chkTrendline As CheckBox
    Friend WithEvents nudThreshholdVal As NumericUpDown
    Friend WithEvents lblThreshhold As Label
    Friend WithEvents lblRainfallCol As Label
    Friend WithEvents ucrReceiverForPICSARainfall As ucrReceiverSingle
    Friend WithEvents ucrSelectorForPICSARainfall As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrbase As ucrButtons
End Class
