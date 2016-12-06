<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgStartofRains
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
        Me.nudValue = New System.Windows.Forms.NumericUpDown()
        Me.nudMinimum = New System.Windows.Forms.NumericUpDown()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorForStartofRains = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.lblRainfall = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.grpConditionsForSatrtofRains = New System.Windows.Forms.GroupBox()
        Me.nudLengthofTime = New System.Windows.Forms.NumericUpDown()
        Me.nudMaximumDays = New System.Windows.Forms.NumericUpDown()
        Me.lblLengthofTime = New System.Windows.Forms.Label()
        Me.lblMaximumDays = New System.Windows.Forms.Label()
        Me.lblVal = New System.Windows.Forms.Label()
        Me.lblMinimum = New System.Windows.Forms.Label()
        Me.chkDrySpell = New System.Windows.Forms.CheckBox()
        Me.chkTotalRainfall = New System.Windows.Forms.CheckBox()
        Me.chkConsecutiveRainyDays = New System.Windows.Forms.CheckBox()
        Me.grpRainParameters = New System.Windows.Forms.GroupBox()
        Me.nudFrom = New System.Windows.Forms.NumericUpDown()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.nudOverDays = New System.Windows.Forms.NumericUpDown()
        Me.nudTo = New System.Windows.Forms.NumericUpDown()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblOverDays = New System.Windows.Forms.Label()
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinimum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConditionsForSatrtofRains.SuspendLayout()
        CType(Me.nudLengthofTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaximumDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRainParameters.SuspendLayout()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOverDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudValue
        '
        Me.nudValue.Location = New System.Drawing.Point(173, 77)
        Me.nudValue.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudValue.Name = "nudValue"
        Me.nudValue.Size = New System.Drawing.Size(48, 20)
        Me.nudValue.TabIndex = 4
        Me.nudValue.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'nudMinimum
        '
        Me.nudMinimum.Location = New System.Drawing.Point(173, 37)
        Me.nudMinimum.Name = "nudMinimum"
        Me.nudMinimum.Size = New System.Drawing.Size(45, 20)
        Me.nudMinimum.TabIndex = 2
        Me.nudMinimum.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 375)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorForStartofRains
        '
        Me.ucrSelectorForStartofRains.bShowHiddenColumns = False
        Me.ucrSelectorForStartofRains.bUseCurrentFilter = True
        Me.ucrSelectorForStartofRains.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorForStartofRains.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForStartofRains.Name = "ucrSelectorForStartofRains"
        Me.ucrSelectorForStartofRains.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForStartofRains.TabIndex = 0
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(234, 26)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(144, 20)
        Me.ucrReceiverRainfall.TabIndex = 2
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.Location = New System.Drawing.Point(234, 65)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(144, 20)
        Me.ucrReceiverDate.TabIndex = 4
        '
        'lblRainfall
        '
        Me.lblRainfall.AutoSize = True
        Me.lblRainfall.Location = New System.Drawing.Point(231, 9)
        Me.lblRainfall.Name = "lblRainfall"
        Me.lblRainfall.Size = New System.Drawing.Size(45, 13)
        Me.lblRainfall.TabIndex = 1
        Me.lblRainfall.Text = "Rainfall:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(234, 49)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date:"
        '
        'grpConditionsForSatrtofRains
        '
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.nudLengthofTime)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.nudMaximumDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblLengthofTime)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblMaximumDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblVal)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.lblMinimum)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.chkDrySpell)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.chkTotalRainfall)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.chkConsecutiveRainyDays)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.nudMinimum)
        Me.grpConditionsForSatrtofRains.Controls.Add(Me.nudValue)
        Me.grpConditionsForSatrtofRains.Location = New System.Drawing.Point(9, 201)
        Me.grpConditionsForSatrtofRains.Name = "grpConditionsForSatrtofRains"
        Me.grpConditionsForSatrtofRains.Size = New System.Drawing.Size(369, 168)
        Me.grpConditionsForSatrtofRains.TabIndex = 7
        Me.grpConditionsForSatrtofRains.TabStop = False
        Me.grpConditionsForSatrtofRains.Text = "Conditions for Start of Rains"
        '
        'nudLengthofTime
        '
        Me.nudLengthofTime.Location = New System.Drawing.Point(173, 144)
        Me.nudLengthofTime.Name = "nudLengthofTime"
        Me.nudLengthofTime.Size = New System.Drawing.Size(48, 20)
        Me.nudLengthofTime.TabIndex = 9
        '
        'nudMaximumDays
        '
        Me.nudMaximumDays.Location = New System.Drawing.Point(173, 118)
        Me.nudMaximumDays.Name = "nudMaximumDays"
        Me.nudMaximumDays.Size = New System.Drawing.Size(48, 20)
        Me.nudMaximumDays.TabIndex = 7
        '
        'lblLengthofTime
        '
        Me.lblLengthofTime.AutoSize = True
        Me.lblLengthofTime.Location = New System.Drawing.Point(86, 144)
        Me.lblLengthofTime.Name = "lblLengthofTime"
        Me.lblLengthofTime.Size = New System.Drawing.Size(81, 13)
        Me.lblLengthofTime.TabIndex = 8
        Me.lblLengthofTime.Text = "Length of Time:"
        '
        'lblMaximumDays
        '
        Me.lblMaximumDays.AutoSize = True
        Me.lblMaximumDays.Location = New System.Drawing.Point(86, 121)
        Me.lblMaximumDays.Name = "lblMaximumDays"
        Me.lblMaximumDays.Size = New System.Drawing.Size(81, 13)
        Me.lblMaximumDays.TabIndex = 6
        Me.lblMaximumDays.Text = "Maximum Days:"
        '
        'lblVal
        '
        Me.lblVal.AutoSize = True
        Me.lblVal.Location = New System.Drawing.Point(130, 84)
        Me.lblVal.Name = "lblVal"
        Me.lblVal.Size = New System.Drawing.Size(37, 13)
        Me.lblVal.TabIndex = 3
        Me.lblVal.Text = "Value:"
        '
        'lblMinimum
        '
        Me.lblMinimum.AutoSize = True
        Me.lblMinimum.Location = New System.Drawing.Point(116, 44)
        Me.lblMinimum.Name = "lblMinimum"
        Me.lblMinimum.Size = New System.Drawing.Size(51, 13)
        Me.lblMinimum.TabIndex = 1
        Me.lblMinimum.Text = "Minimum:"
        '
        'chkDrySpell
        '
        Me.chkDrySpell.AutoSize = True
        Me.chkDrySpell.Location = New System.Drawing.Point(6, 100)
        Me.chkDrySpell.Name = "chkDrySpell"
        Me.chkDrySpell.Size = New System.Drawing.Size(68, 17)
        Me.chkDrySpell.TabIndex = 5
        Me.chkDrySpell.Text = "Dry Spell"
        Me.chkDrySpell.UseVisualStyleBackColor = True
        '
        'chkTotalRainfall
        '
        Me.chkTotalRainfall.AutoSize = True
        Me.chkTotalRainfall.Location = New System.Drawing.Point(6, 60)
        Me.chkTotalRainfall.Name = "chkTotalRainfall"
        Me.chkTotalRainfall.Size = New System.Drawing.Size(88, 17)
        Me.chkTotalRainfall.TabIndex = 1
        Me.chkTotalRainfall.Text = "Total Rainfall"
        Me.chkTotalRainfall.UseVisualStyleBackColor = True
        '
        'chkConsecutiveRainyDays
        '
        Me.chkConsecutiveRainyDays.AutoSize = True
        Me.chkConsecutiveRainyDays.Location = New System.Drawing.Point(7, 20)
        Me.chkConsecutiveRainyDays.Name = "chkConsecutiveRainyDays"
        Me.chkConsecutiveRainyDays.Size = New System.Drawing.Size(142, 17)
        Me.chkConsecutiveRainyDays.TabIndex = 0
        Me.chkConsecutiveRainyDays.Text = "Consecutive Rainy Days"
        Me.chkConsecutiveRainyDays.UseVisualStyleBackColor = True
        '
        'grpRainParameters
        '
        Me.grpRainParameters.Controls.Add(Me.nudFrom)
        Me.grpRainParameters.Controls.Add(Me.lblFrom)
        Me.grpRainParameters.Controls.Add(Me.nudThreshold)
        Me.grpRainParameters.Controls.Add(Me.nudOverDays)
        Me.grpRainParameters.Controls.Add(Me.nudTo)
        Me.grpRainParameters.Controls.Add(Me.lblTo)
        Me.grpRainParameters.Controls.Add(Me.lblThreshold)
        Me.grpRainParameters.Controls.Add(Me.lblOverDays)
        Me.grpRainParameters.Location = New System.Drawing.Point(234, 88)
        Me.grpRainParameters.Name = "grpRainParameters"
        Me.grpRainParameters.Size = New System.Drawing.Size(144, 113)
        Me.grpRainParameters.TabIndex = 5
        Me.grpRainParameters.TabStop = False
        '
        'nudFrom
        '
        Me.nudFrom.Location = New System.Drawing.Point(81, 9)
        Me.nudFrom.Name = "nudFrom"
        Me.nudFrom.Size = New System.Drawing.Size(55, 20)
        Me.nudFrom.TabIndex = 1
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(31, 11)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From:"
        '
        'nudThreshold
        '
        Me.nudThreshold.DecimalPlaces = 2
        Me.nudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudThreshold.Location = New System.Drawing.Point(81, 61)
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(53, 20)
        Me.nudThreshold.TabIndex = 5
        Me.nudThreshold.Value = New Decimal(New Integer() {85, 0, 0, 131072})
        '
        'nudOverDays
        '
        Me.nudOverDays.Location = New System.Drawing.Point(81, 87)
        Me.nudOverDays.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudOverDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudOverDays.Name = "nudOverDays"
        Me.nudOverDays.Size = New System.Drawing.Size(53, 20)
        Me.nudOverDays.TabIndex = 7
        Me.nudOverDays.Value = New Decimal(New Integer() {92, 0, 0, 0})
        '
        'nudTo
        '
        Me.nudTo.Location = New System.Drawing.Point(81, 35)
        Me.nudTo.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudTo.Name = "nudTo"
        Me.nudTo.Size = New System.Drawing.Size(53, 20)
        Me.nudTo.TabIndex = 3
        Me.nudTo.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(41, 37)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Tag = ""
        Me.lblTo.Text = "To:"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(7, 63)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(57, 13)
        Me.lblThreshold.TabIndex = 4
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold:"
        '
        'lblOverDays
        '
        Me.lblOverDays.AutoSize = True
        Me.lblOverDays.Location = New System.Drawing.Point(7, 91)
        Me.lblOverDays.Name = "lblOverDays"
        Me.lblOverDays.Size = New System.Drawing.Size(60, 13)
        Me.lblOverDays.TabIndex = 6
        Me.lblOverDays.Tag = ""
        Me.lblOverDays.Text = "Over Days:"
        '
        'dlgStartofRains
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 431)
        Me.Controls.Add(Me.grpRainParameters)
        Me.Controls.Add(Me.grpConditionsForSatrtofRains)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblRainfall)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverRainfall)
        Me.Controls.Add(Me.ucrSelectorForStartofRains)
        Me.Controls.Add(Me.ucrBase)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStartofRains"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start of Rains"
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinimum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConditionsForSatrtofRains.ResumeLayout(False)
        Me.grpConditionsForSatrtofRains.PerformLayout()
        CType(Me.nudLengthofTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaximumDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRainParameters.ResumeLayout(False)
        Me.grpRainParameters.PerformLayout()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudOverDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents nudValue As NumericUpDown
    Friend WithEvents nudMinimum As NumericUpDown
    Friend WithEvents ucrSelectorForStartofRains As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblRainfall As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents grpConditionsForSatrtofRains As GroupBox
    Friend WithEvents nudLengthofTime As NumericUpDown
    Friend WithEvents nudMaximumDays As NumericUpDown
    Friend WithEvents lblLengthofTime As Label
    Friend WithEvents lblMaximumDays As Label
    Friend WithEvents lblVal As Label
    Friend WithEvents lblMinimum As Label
    Friend WithEvents chkDrySpell As CheckBox
    Friend WithEvents chkTotalRainfall As CheckBox
    Friend WithEvents chkConsecutiveRainyDays As CheckBox
    Friend WithEvents grpRainParameters As GroupBox
    Friend WithEvents nudFrom As NumericUpDown
    Friend WithEvents lblFrom As Label
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents nudOverDays As NumericUpDown
    Friend WithEvents nudTo As NumericUpDown
    Friend WithEvents lblTo As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblOverDays As Label
End Class
