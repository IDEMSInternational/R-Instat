<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTemperature
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
        Me.ucrbase = New instat.ucrButtons()
        Me.ucrSelectorForPICSATemp = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverForPICSATemp = New instat.ucrReceiverSingle()
        Me.lblTemperatureCol = New System.Windows.Forms.Label()
        Me.lblThreshhold = New System.Windows.Forms.Label()
        Me.nudThreshholdVal = New System.Windows.Forms.NumericUpDown()
        Me.grpPlots = New System.Windows.Forms.GroupBox()
        Me.chkTrendline = New System.Windows.Forms.CheckBox()
        Me.chkTmax = New System.Windows.Forms.CheckBox()
        Me.chkTemperatureMin = New System.Windows.Forms.CheckBox()
        Me.chkTMean = New System.Windows.Forms.CheckBox()
        Me.chkSaveResults = New System.Windows.Forms.CheckBox()
        Me.ucrInputSaveResults = New instat.ucrInputComboBox()
        CType(Me.nudThreshholdVal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPlots.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrbase
        '
        Me.ucrbase.Location = New System.Drawing.Point(12, 230)
        Me.ucrbase.Name = "ucrbase"
        Me.ucrbase.Size = New System.Drawing.Size(410, 52)
        Me.ucrbase.TabIndex = 0
        '
        'ucrSelectorForPICSATemp
        '
        Me.ucrSelectorForPICSATemp.bShowHiddenColumns = False
        Me.ucrSelectorForPICSATemp.bUseCurrentFilter = True
        Me.ucrSelectorForPICSATemp.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorForPICSATemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForPICSATemp.Name = "ucrSelectorForPICSATemp"
        Me.ucrSelectorForPICSATemp.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForPICSATemp.TabIndex = 1
        '
        'ucrReceiverForPICSATemp
        '
        Me.ucrReceiverForPICSATemp.Location = New System.Drawing.Point(250, 31)
        Me.ucrReceiverForPICSATemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForPICSATemp.Name = "ucrReceiverForPICSATemp"
        Me.ucrReceiverForPICSATemp.Selector = Nothing
        Me.ucrReceiverForPICSATemp.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverForPICSATemp.TabIndex = 2
        '
        'lblTemperatureCol
        '
        Me.lblTemperatureCol.AutoSize = True
        Me.lblTemperatureCol.Location = New System.Drawing.Point(247, 13)
        Me.lblTemperatureCol.Name = "lblTemperatureCol"
        Me.lblTemperatureCol.Size = New System.Drawing.Size(108, 13)
        Me.lblTemperatureCol.TabIndex = 3
        Me.lblTemperatureCol.Text = "Temperature Variable"
        '
        'lblThreshhold
        '
        Me.lblThreshhold.AutoSize = True
        Me.lblThreshhold.Location = New System.Drawing.Point(247, 64)
        Me.lblThreshhold.Name = "lblThreshhold"
        Me.lblThreshhold.Size = New System.Drawing.Size(90, 13)
        Me.lblThreshhold.TabIndex = 4
        Me.lblThreshhold.Text = "Threshhold Value"
        '
        'nudThreshholdVal
        '
        Me.nudThreshholdVal.Location = New System.Drawing.Point(340, 61)
        Me.nudThreshholdVal.Name = "nudThreshholdVal"
        Me.nudThreshholdVal.Size = New System.Drawing.Size(49, 20)
        Me.nudThreshholdVal.TabIndex = 5
        '
        'grpPlots
        '
        Me.grpPlots.Controls.Add(Me.chkTMean)
        Me.grpPlots.Controls.Add(Me.chkTemperatureMin)
        Me.grpPlots.Controls.Add(Me.chkTmax)
        Me.grpPlots.Controls.Add(Me.chkTrendline)
        Me.grpPlots.Location = New System.Drawing.Point(253, 88)
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.Size = New System.Drawing.Size(153, 109)
        Me.grpPlots.TabIndex = 6
        Me.grpPlots.TabStop = False
        Me.grpPlots.Text = "Plots"
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
        'chkSaveResults
        '
        Me.chkSaveResults.AutoSize = True
        Me.chkSaveResults.Location = New System.Drawing.Point(13, 203)
        Me.chkSaveResults.Name = "chkSaveResults"
        Me.chkSaveResults.Size = New System.Drawing.Size(89, 17)
        Me.chkSaveResults.TabIndex = 7
        Me.chkSaveResults.Text = "Save Results"
        Me.chkSaveResults.UseVisualStyleBackColor = True
        '
        'ucrInputSaveResults
        '
        Me.ucrInputSaveResults.IsReadOnly = False
        Me.ucrInputSaveResults.Location = New System.Drawing.Point(101, 203)
        Me.ucrInputSaveResults.Name = "ucrInputSaveResults"
        Me.ucrInputSaveResults.Size = New System.Drawing.Size(153, 21)
        Me.ucrInputSaveResults.TabIndex = 8
        '
        'dlgTemperature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 288)
        Me.Controls.Add(Me.ucrInputSaveResults)
        Me.Controls.Add(Me.chkSaveResults)
        Me.Controls.Add(Me.grpPlots)
        Me.Controls.Add(Me.nudThreshholdVal)
        Me.Controls.Add(Me.lblThreshhold)
        Me.Controls.Add(Me.lblTemperatureCol)
        Me.Controls.Add(Me.ucrReceiverForPICSATemp)
        Me.Controls.Add(Me.ucrSelectorForPICSATemp)
        Me.Controls.Add(Me.ucrbase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTemperature"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temperature"
        CType(Me.nudThreshholdVal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPlots.ResumeLayout(False)
        Me.grpPlots.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrbase As ucrButtons
    Friend WithEvents ucrSelectorForPICSATemp As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverForPICSATemp As ucrReceiverSingle
    Friend WithEvents lblTemperatureCol As Label
    Friend WithEvents lblThreshhold As Label
    Friend WithEvents nudThreshholdVal As NumericUpDown
    Friend WithEvents grpPlots As GroupBox
    Friend WithEvents chkTMean As CheckBox
    Friend WithEvents chkTemperatureMin As CheckBox
    Friend WithEvents chkTmax As CheckBox
    Friend WithEvents chkTrendline As CheckBox
    Friend WithEvents chkSaveResults As CheckBox
    Friend WithEvents ucrInputSaveResults As ucrInputComboBox
End Class
