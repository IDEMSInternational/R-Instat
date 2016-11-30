<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimdex
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
        Me.lblTmax = New System.Windows.Forms.Label()
        Me.lblTmin = New System.Windows.Forms.Label()
        Me.lblPrec = New System.Windows.Forms.Label()
        Me.cmdIndices = New System.Windows.Forms.Button()
        Me.lblBaseRangeFrom = New System.Windows.Forms.Label()
        Me.nudYearFrom = New System.Windows.Forms.NumericUpDown()
        Me.nudYearTo = New System.Windows.Forms.NumericUpDown()
        Me.lblBaseRangeTo = New System.Windows.Forms.Label()
        Me.lblN = New System.Windows.Forms.Label()
        Me.nudN = New System.Windows.Forms.NumericUpDown()
        Me.chkNHemisphere = New System.Windows.Forms.CheckBox()
        Me.lblAnnual = New System.Windows.Forms.Label()
        Me.nudMothlyMissingDays = New System.Windows.Forms.NumericUpDown()
        Me.nudAnnualMissingDays = New System.Windows.Forms.NumericUpDown()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.grpBaseRange = New System.Windows.Forms.GroupBox()
        Me.grpMaxMissingDays = New System.Windows.Forms.GroupBox()
        Me.lblMinBaseData = New System.Windows.Forms.Label()
        Me.nudMinBaseData = New System.Windows.Forms.NumericUpDown()
        Me.lblTempQuantiles = New System.Windows.Forms.Label()
        Me.lblPrecQuantiles = New System.Windows.Forms.Label()
        Me.lblFreq = New System.Windows.Forms.Label()
        Me.ucrInputFreq = New instat.ucrInputComboBox()
        Me.ucrMultipleInputTempQtiles = New instat.ucrMultipleInput()
        Me.ucrMultipleInputPrecQtiles = New instat.ucrMultipleInput()
        Me.ucrReceiverPrec = New instat.ucrReceiverSingle()
        Me.ucrReceiverTmin = New instat.ucrReceiverSingle()
        Me.ucrReceiverTmax = New instat.ucrReceiverSingle()
        Me.ucrSelectorClimdex = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseClimdex = New instat.ucrButtons()
        Me.UcrDialogDisabled1 = New instat.ucrDialogDisabled()
        CType(Me.nudYearFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYearTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMothlyMissingDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAnnualMissingDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBaseRange.SuspendLayout()
        Me.grpMaxMissingDays.SuspendLayout()
        CType(Me.nudMinBaseData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTmax
        '
        Me.lblTmax.AutoSize = True
        Me.lblTmax.Location = New System.Drawing.Point(332, 6)
        Me.lblTmax.Name = "lblTmax"
        Me.lblTmax.Size = New System.Drawing.Size(33, 13)
        Me.lblTmax.TabIndex = 1
        Me.lblTmax.Tag = "Tmax"
        Me.lblTmax.Text = "Tmax"
        '
        'lblTmin
        '
        Me.lblTmin.AutoSize = True
        Me.lblTmin.Location = New System.Drawing.Point(333, 53)
        Me.lblTmin.Name = "lblTmin"
        Me.lblTmin.Size = New System.Drawing.Size(30, 13)
        Me.lblTmin.TabIndex = 3
        Me.lblTmin.Tag = "Tmin"
        Me.lblTmin.Text = "Tmin"
        '
        'lblPrec
        '
        Me.lblPrec.AutoSize = True
        Me.lblPrec.Location = New System.Drawing.Point(334, 97)
        Me.lblPrec.Name = "lblPrec"
        Me.lblPrec.Size = New System.Drawing.Size(29, 13)
        Me.lblPrec.TabIndex = 5
        Me.lblPrec.Tag = "Prec"
        Me.lblPrec.Text = "Prec"
        '
        'cmdIndices
        '
        Me.cmdIndices.Location = New System.Drawing.Point(316, 321)
        Me.cmdIndices.Name = "cmdIndices"
        Me.cmdIndices.Size = New System.Drawing.Size(62, 23)
        Me.cmdIndices.TabIndex = 20
        Me.cmdIndices.Tag = "Indices..."
        Me.cmdIndices.Text = "Indices..."
        Me.cmdIndices.UseVisualStyleBackColor = True
        '
        'lblBaseRangeFrom
        '
        Me.lblBaseRangeFrom.AutoSize = True
        Me.lblBaseRangeFrom.Location = New System.Drawing.Point(7, 22)
        Me.lblBaseRangeFrom.Name = "lblBaseRangeFrom"
        Me.lblBaseRangeFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblBaseRangeFrom.TabIndex = 0
        Me.lblBaseRangeFrom.Tag = "From"
        Me.lblBaseRangeFrom.Text = "From"
        '
        'nudYearFrom
        '
        Me.nudYearFrom.Location = New System.Drawing.Point(43, 20)
        Me.nudYearFrom.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudYearFrom.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.nudYearFrom.Name = "nudYearFrom"
        Me.nudYearFrom.Size = New System.Drawing.Size(47, 20)
        Me.nudYearFrom.TabIndex = 1
        Me.nudYearFrom.Value = New Decimal(New Integer() {1961, 0, 0, 0})
        '
        'nudYearTo
        '
        Me.nudYearTo.Location = New System.Drawing.Point(121, 19)
        Me.nudYearTo.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudYearTo.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.nudYearTo.Name = "nudYearTo"
        Me.nudYearTo.Size = New System.Drawing.Size(47, 20)
        Me.nudYearTo.TabIndex = 3
        Me.nudYearTo.Value = New Decimal(New Integer() {1990, 0, 0, 0})
        '
        'lblBaseRangeTo
        '
        Me.lblBaseRangeTo.AutoSize = True
        Me.lblBaseRangeTo.Location = New System.Drawing.Point(96, 22)
        Me.lblBaseRangeTo.Name = "lblBaseRangeTo"
        Me.lblBaseRangeTo.Size = New System.Drawing.Size(20, 13)
        Me.lblBaseRangeTo.TabIndex = 2
        Me.lblBaseRangeTo.Tag = "To"
        Me.lblBaseRangeTo.Text = "To"
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(278, 197)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(93, 13)
        Me.lblN.TabIndex = 10
        Me.lblN.Tag = "Days_for_Quantiles"
        Me.lblN.Text = "Days for Quantiles"
        '
        'nudN
        '
        Me.nudN.Location = New System.Drawing.Point(381, 194)
        Me.nudN.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudN.Name = "nudN"
        Me.nudN.Size = New System.Drawing.Size(36, 20)
        Me.nudN.TabIndex = 11
        Me.nudN.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'chkNHemisphere
        '
        Me.chkNHemisphere.AutoSize = True
        Me.chkNHemisphere.Location = New System.Drawing.Point(10, 301)
        Me.chkNHemisphere.Name = "chkNHemisphere"
        Me.chkNHemisphere.Size = New System.Drawing.Size(126, 17)
        Me.chkNHemisphere.TabIndex = 16
        Me.chkNHemisphere.Tag = "Northern_Hemisphere"
        Me.chkNHemisphere.Text = "Northern Hemisphere"
        Me.chkNHemisphere.UseVisualStyleBackColor = True
        '
        'lblAnnual
        '
        Me.lblAnnual.AutoSize = True
        Me.lblAnnual.Location = New System.Drawing.Point(7, 19)
        Me.lblAnnual.Name = "lblAnnual"
        Me.lblAnnual.Size = New System.Drawing.Size(40, 13)
        Me.lblAnnual.TabIndex = 0
        Me.lblAnnual.Tag = "Annual"
        Me.lblAnnual.Text = "Annual"
        '
        'nudMothlyMissingDays
        '
        Me.nudMothlyMissingDays.Location = New System.Drawing.Point(156, 17)
        Me.nudMothlyMissingDays.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.nudMothlyMissingDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMothlyMissingDays.Name = "nudMothlyMissingDays"
        Me.nudMothlyMissingDays.Size = New System.Drawing.Size(47, 20)
        Me.nudMothlyMissingDays.TabIndex = 3
        Me.nudMothlyMissingDays.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'nudAnnualMissingDays
        '
        Me.nudAnnualMissingDays.Location = New System.Drawing.Point(53, 17)
        Me.nudAnnualMissingDays.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudAnnualMissingDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAnnualMissingDays.Name = "nudAnnualMissingDays"
        Me.nudAnnualMissingDays.Size = New System.Drawing.Size(47, 20)
        Me.nudAnnualMissingDays.TabIndex = 1
        Me.nudAnnualMissingDays.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'lblMonthly
        '
        Me.lblMonthly.AutoSize = True
        Me.lblMonthly.Location = New System.Drawing.Point(106, 19)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(44, 13)
        Me.lblMonthly.TabIndex = 2
        Me.lblMonthly.Tag = "Monthly"
        Me.lblMonthly.Text = "Monthly"
        '
        'grpBaseRange
        '
        Me.grpBaseRange.Controls.Add(Me.nudYearFrom)
        Me.grpBaseRange.Controls.Add(Me.nudYearTo)
        Me.grpBaseRange.Controls.Add(Me.lblBaseRangeTo)
        Me.grpBaseRange.Controls.Add(Me.lblBaseRangeFrom)
        Me.grpBaseRange.Location = New System.Drawing.Point(10, 196)
        Me.grpBaseRange.Name = "grpBaseRange"
        Me.grpBaseRange.Size = New System.Drawing.Size(174, 46)
        Me.grpBaseRange.TabIndex = 9
        Me.grpBaseRange.TabStop = False
        Me.grpBaseRange.Tag = "Base_Range"
        Me.grpBaseRange.Text = "Base Range"
        '
        'grpMaxMissingDays
        '
        Me.grpMaxMissingDays.Controls.Add(Me.nudMothlyMissingDays)
        Me.grpMaxMissingDays.Controls.Add(Me.lblMonthly)
        Me.grpMaxMissingDays.Controls.Add(Me.lblAnnual)
        Me.grpMaxMissingDays.Controls.Add(Me.nudAnnualMissingDays)
        Me.grpMaxMissingDays.Location = New System.Drawing.Point(10, 247)
        Me.grpMaxMissingDays.Name = "grpMaxMissingDays"
        Me.grpMaxMissingDays.Size = New System.Drawing.Size(216, 46)
        Me.grpMaxMissingDays.TabIndex = 13
        Me.grpMaxMissingDays.TabStop = False
        Me.grpMaxMissingDays.Tag = "Maximum_Missing_Days"
        Me.grpMaxMissingDays.Text = "Maximum Missing Days"
        '
        'lblMinBaseData
        '
        Me.lblMinBaseData.AutoSize = True
        Me.lblMinBaseData.Location = New System.Drawing.Point(10, 326)
        Me.lblMinBaseData.Name = "lblMinBaseData"
        Me.lblMinBaseData.Size = New System.Drawing.Size(193, 13)
        Me.lblMinBaseData.TabIndex = 18
        Me.lblMinBaseData.Tag = "Minimum_Fraction_of_Base_Data_ Present"
        Me.lblMinBaseData.Text = "Minimum Fraction of Base Data Present"
        '
        'nudMinBaseData
        '
        Me.nudMinBaseData.DecimalPlaces = 1
        Me.nudMinBaseData.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudMinBaseData.Location = New System.Drawing.Point(216, 322)
        Me.nudMinBaseData.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMinBaseData.Name = "nudMinBaseData"
        Me.nudMinBaseData.Size = New System.Drawing.Size(36, 20)
        Me.nudMinBaseData.TabIndex = 19
        Me.nudMinBaseData.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'lblTempQuantiles
        '
        Me.lblTempQuantiles.AutoSize = True
        Me.lblTempQuantiles.Location = New System.Drawing.Point(291, 221)
        Me.lblTempQuantiles.Name = "lblTempQuantiles"
        Me.lblTempQuantiles.Size = New System.Drawing.Size(114, 13)
        Me.lblTempQuantiles.TabIndex = 12
        Me.lblTempQuantiles.Tag = "Temperature_Quantiles"
        Me.lblTempQuantiles.Text = "Temperature Quantiles"
        '
        'lblPrecQuantiles
        '
        Me.lblPrecQuantiles.AutoSize = True
        Me.lblPrecQuantiles.Location = New System.Drawing.Point(292, 269)
        Me.lblPrecQuantiles.Name = "lblPrecQuantiles"
        Me.lblPrecQuantiles.Size = New System.Drawing.Size(112, 13)
        Me.lblPrecQuantiles.TabIndex = 15
        Me.lblPrecQuantiles.Tag = "Precipitation_Quantiles"
        Me.lblPrecQuantiles.Text = "Precipitation Quantiles"
        '
        'lblFreq
        '
        Me.lblFreq.AutoSize = True
        Me.lblFreq.Location = New System.Drawing.Point(320, 143)
        Me.lblFreq.Name = "lblFreq"
        Me.lblFreq.Size = New System.Drawing.Size(57, 13)
        Me.lblFreq.TabIndex = 7
        Me.lblFreq.Tag = "Frequency"
        Me.lblFreq.Text = "Frequency"
        '
        'ucrInputFreq
        '
        Me.ucrInputFreq.IsReadOnly = False
        Me.ucrInputFreq.Location = New System.Drawing.Point(280, 164)
        Me.ucrInputFreq.Name = "ucrInputFreq"
        Me.ucrInputFreq.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFreq.TabIndex = 8
        '
        'ucrMultipleInputTempQtiles
        '
        Me.ucrMultipleInputTempQtiles.Location = New System.Drawing.Point(273, 239)
        Me.ucrMultipleInputTempQtiles.Name = "ucrMultipleInputTempQtiles"
        Me.ucrMultipleInputTempQtiles.Size = New System.Drawing.Size(150, 29)
        Me.ucrMultipleInputTempQtiles.TabIndex = 14
        '
        'ucrMultipleInputPrecQtiles
        '
        Me.ucrMultipleInputPrecQtiles.Location = New System.Drawing.Point(273, 286)
        Me.ucrMultipleInputPrecQtiles.Name = "ucrMultipleInputPrecQtiles"
        Me.ucrMultipleInputPrecQtiles.Size = New System.Drawing.Size(150, 29)
        Me.ucrMultipleInputPrecQtiles.TabIndex = 17
        '
        'ucrReceiverPrec
        '
        Me.ucrReceiverPrec.Location = New System.Drawing.Point(288, 114)
        Me.ucrReceiverPrec.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPrec.Name = "ucrReceiverPrec"
        Me.ucrReceiverPrec.Selector = Nothing
        Me.ucrReceiverPrec.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPrec.TabIndex = 6
        '
        'ucrReceiverTmin
        '
        Me.ucrReceiverTmin.Location = New System.Drawing.Point(288, 71)
        Me.ucrReceiverTmin.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmin.Name = "ucrReceiverTmin"
        Me.ucrReceiverTmin.Selector = Nothing
        Me.ucrReceiverTmin.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTmin.TabIndex = 4
        '
        'ucrReceiverTmax
        '
        Me.ucrReceiverTmax.Location = New System.Drawing.Point(288, 24)
        Me.ucrReceiverTmax.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmax.Name = "ucrReceiverTmax"
        Me.ucrReceiverTmax.Selector = Nothing
        Me.ucrReceiverTmax.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTmax.TabIndex = 2
        '
        'ucrSelectorClimdex
        '
        Me.ucrSelectorClimdex.bShowHiddenColumns = False
        Me.ucrSelectorClimdex.bUseCurrentFilter = True
        Me.ucrSelectorClimdex.Location = New System.Drawing.Point(10, 9)
        Me.ucrSelectorClimdex.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimdex.Name = "ucrSelectorClimdex"
        Me.ucrSelectorClimdex.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorClimdex.TabIndex = 0
        '
        'ucrBaseClimdex
        '
        Me.ucrBaseClimdex.Location = New System.Drawing.Point(10, 346)
        Me.ucrBaseClimdex.Name = "ucrBaseClimdex"
        Me.ucrBaseClimdex.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseClimdex.TabIndex = 21
        '
        'UcrDialogDisabled1
        '
        Me.UcrDialogDisabled1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcrDialogDisabled1.Location = New System.Drawing.Point(74, 114)
        Me.UcrDialogDisabled1.Name = "UcrDialogDisabled1"
        Me.UcrDialogDisabled1.Size = New System.Drawing.Size(240, 50)
        Me.UcrDialogDisabled1.TabIndex = 22
        '
        'dlgClimdex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 402)
        Me.Controls.Add(Me.UcrDialogDisabled1)
        Me.Controls.Add(Me.ucrInputFreq)
        Me.Controls.Add(Me.lblFreq)
        Me.Controls.Add(Me.ucrMultipleInputTempQtiles)
        Me.Controls.Add(Me.ucrMultipleInputPrecQtiles)
        Me.Controls.Add(Me.lblPrecQuantiles)
        Me.Controls.Add(Me.lblTempQuantiles)
        Me.Controls.Add(Me.lblMinBaseData)
        Me.Controls.Add(Me.nudMinBaseData)
        Me.Controls.Add(Me.grpMaxMissingDays)
        Me.Controls.Add(Me.grpBaseRange)
        Me.Controls.Add(Me.chkNHemisphere)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.nudN)
        Me.Controls.Add(Me.cmdIndices)
        Me.Controls.Add(Me.lblPrec)
        Me.Controls.Add(Me.lblTmin)
        Me.Controls.Add(Me.lblTmax)
        Me.Controls.Add(Me.ucrReceiverPrec)
        Me.Controls.Add(Me.ucrReceiverTmin)
        Me.Controls.Add(Me.ucrReceiverTmax)
        Me.Controls.Add(Me.ucrSelectorClimdex)
        Me.Controls.Add(Me.ucrBaseClimdex)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimdex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Climdex Indices"
        Me.Text = "Climdex Indices"
        CType(Me.nudYearFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYearTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMothlyMissingDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAnnualMissingDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBaseRange.ResumeLayout(False)
        Me.grpBaseRange.PerformLayout()
        Me.grpMaxMissingDays.ResumeLayout(False)
        Me.grpMaxMissingDays.PerformLayout()
        CType(Me.nudMinBaseData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseClimdex As ucrButtons

    Friend WithEvents ucrSelectorClimdex As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverTmax As ucrReceiverSingle
    Friend WithEvents ucrReceiverTmin As ucrReceiverSingle
    Friend WithEvents ucrReceiverPrec As ucrReceiverSingle
    Friend WithEvents lblTmax As Label
    Friend WithEvents lblTmin As Label
    Friend WithEvents lblPrec As Label
    Friend WithEvents cmdIndices As Button
    Friend WithEvents lblBaseRangeFrom As Label
    Friend WithEvents nudYearFrom As NumericUpDown
    Friend WithEvents nudYearTo As NumericUpDown
    Friend WithEvents lblBaseRangeTo As Label
    Friend WithEvents lblN As Label
    Friend WithEvents nudN As NumericUpDown
    Friend WithEvents chkNHemisphere As CheckBox
    Friend WithEvents lblAnnual As Label
    Friend WithEvents nudMothlyMissingDays As NumericUpDown
    Friend WithEvents nudAnnualMissingDays As NumericUpDown
    Friend WithEvents lblMonthly As Label
    Friend WithEvents grpBaseRange As GroupBox
    Friend WithEvents grpMaxMissingDays As GroupBox
    Friend WithEvents lblMinBaseData As Label
    Friend WithEvents nudMinBaseData As NumericUpDown
    Friend WithEvents lblTempQuantiles As Label
    Friend WithEvents lblPrecQuantiles As Label
    Friend WithEvents ucrMultipleInputPrecQtiles As ucrMultipleInput
    Friend WithEvents ucrMultipleInputTempQtiles As ucrMultipleInput
    Friend WithEvents lblFreq As Label
    Friend WithEvents ucrInputFreq As ucrInputComboBox
    Friend WithEvents UcrDialogDisabled1 As ucrDialogDisabled
End Class