' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgExtremesClimatic
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
        Me.components = New System.ComponentModel.Container()
        Me.lblStations = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDayOfYear = New System.Windows.Forms.Label()
        Me.grpMinMaxOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkLastDate = New instat.ucrCheck()
        Me.ucrChkNDates = New instat.ucrCheck()
        Me.ucrChkMissingValues = New instat.ucrCheck()
        Me.rdoMin = New System.Windows.Forms.RadioButton()
        Me.rdoMax = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMaxMin = New instat.UcrPanel()
        Me.ucrChkFirstDate = New instat.ucrCheck()
        Me.lblValues = New System.Windows.Forms.Label()
        Me.cmdDoyRange = New System.Windows.Forms.Button()
        Me.rdoMinMax = New System.Windows.Forms.RadioButton()
        Me.rdoPeaks = New System.Windows.Forms.RadioButton()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblNewColName = New System.Windows.Forms.Label()
        Me.lblNewDFName = New System.Windows.Forms.Label()
        Me.grpPeakOptions = New System.Windows.Forms.GroupBox()
        Me.ucrInputThresholdValue = New instat.ucrInputTextBox()
        Me.ucrInputThresholdOperator = New instat.ucrInputComboBox()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblMinimum = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.lblThresholdColumns = New System.Windows.Forms.Label()
        Me.lblThresholds = New System.Windows.Forms.Label()
        Me.lblAlpha = New System.Windows.Forms.Label()
        Me.lblDistribution = New System.Windows.Forms.Label()
        Me.rdoMrlPlot = New System.Windows.Forms.RadioButton()
        Me.rdoThreshRangePlot = New System.Windows.Forms.RadioButton()
        Me.grpThresholdOptions = New System.Windows.Forms.GroupBox()
        Me.ucrNudThresholdColumns = New instat.ucrNud()
        Me.ucrNudAlpha = New instat.ucrNud()
        Me.ucrNudThresholds = New instat.ucrNud()
        Me.ucrInputDistribution = New instat.ucrInputComboBox()
        Me.grpMrlOptions = New System.Windows.Forms.GroupBox()
        Me.ucrNudColumns = New instat.ucrNud()
        Me.ucrInputMin = New instat.ucrInputTextBox()
        Me.ucrChkRugPlot = New instat.ucrCheck()
        Me.ucrInputMax = New instat.ucrInputTextBox()
        Me.ucrInputColours = New instat.ucrInputComboBox()
        Me.ucrInputFill = New instat.ucrInputComboBox()
        Me.grpPlots = New System.Windows.Forms.GroupBox()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.rdoThreshold = New System.Windows.Forms.RadioButton()
        Me.ttpThreshold = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblDeclusterColumns = New System.Windows.Forms.Label()
        Me.grpDeclusteringOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkRunLength = New instat.ucrCheck()
        Me.ucrNudRunLength = New instat.ucrNud()
        Me.ucrChkPrintSummary = New instat.ucrCheck()
        Me.ucrNudDeclusterColumns = New instat.ucrNud()
        Me.ucrChkDeclustering = New instat.ucrCheck()
        Me.ucrSaveDeclusteredPlot = New instat.ucrSave()
        Me.ucrSaveThresholdPlot = New instat.ucrSave()
        Me.ucrSaveMrlPlot = New instat.ucrSave()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.ucrInputSave = New instat.ucrInputTextBox()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrSelectorClimaticExtremes = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlExtremesType = New instat.UcrPanel()
        Me.grpMinMaxOptions.SuspendLayout()
        Me.grpPeakOptions.SuspendLayout()
        Me.grpThresholdOptions.SuspendLayout()
        Me.grpMrlOptions.SuspendLayout()
        Me.grpPlots.SuspendLayout()
        Me.grpDeclusteringOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStations
        '
        Me.lblStations.AutoSize = True
        Me.lblStations.Location = New System.Drawing.Point(251, 62)
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Size = New System.Drawing.Size(43, 13)
        Me.lblStations.TabIndex = 5
        Me.lblStations.Text = "Station:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(251, 104)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(251, 146)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 9
        Me.lblYear.Text = "Year:"
        '
        'lblDayOfYear
        '
        Me.lblDayOfYear.AutoSize = True
        Me.lblDayOfYear.Location = New System.Drawing.Point(251, 189)
        Me.lblDayOfYear.Name = "lblDayOfYear"
        Me.lblDayOfYear.Size = New System.Drawing.Size(66, 13)
        Me.lblDayOfYear.TabIndex = 11
        Me.lblDayOfYear.Text = "Day of Year:"
        '
        'grpMinMaxOptions
        '
        Me.grpMinMaxOptions.Controls.Add(Me.ucrChkLastDate)
        Me.grpMinMaxOptions.Controls.Add(Me.ucrChkNDates)
        Me.grpMinMaxOptions.Controls.Add(Me.ucrChkMissingValues)
        Me.grpMinMaxOptions.Controls.Add(Me.rdoMin)
        Me.grpMinMaxOptions.Controls.Add(Me.rdoMax)
        Me.grpMinMaxOptions.Controls.Add(Me.ucrPnlMaxMin)
        Me.grpMinMaxOptions.Controls.Add(Me.ucrChkFirstDate)
        Me.grpMinMaxOptions.Location = New System.Drawing.Point(10, 228)
        Me.grpMinMaxOptions.Name = "grpMinMaxOptions"
        Me.grpMinMaxOptions.Size = New System.Drawing.Size(210, 173)
        Me.grpMinMaxOptions.TabIndex = 14
        Me.grpMinMaxOptions.TabStop = False
        Me.grpMinMaxOptions.Text = "Options"
        '
        'ucrChkLastDate
        '
        Me.ucrChkLastDate.AutoSize = True
        Me.ucrChkLastDate.Checked = False
        Me.ucrChkLastDate.Location = New System.Drawing.Point(9, 121)
        Me.ucrChkLastDate.Name = "ucrChkLastDate"
        Me.ucrChkLastDate.Size = New System.Drawing.Size(195, 23)
        Me.ucrChkLastDate.TabIndex = 13
        '
        'ucrChkNDates
        '
        Me.ucrChkNDates.AutoSize = True
        Me.ucrChkNDates.Checked = False
        Me.ucrChkNDates.Location = New System.Drawing.Point(10, 97)
        Me.ucrChkNDates.Name = "ucrChkNDates"
        Me.ucrChkNDates.Size = New System.Drawing.Size(194, 23)
        Me.ucrChkNDates.TabIndex = 12
        '
        'ucrChkMissingValues
        '
        Me.ucrChkMissingValues.AutoSize = True
        Me.ucrChkMissingValues.Checked = False
        Me.ucrChkMissingValues.Location = New System.Drawing.Point(10, 147)
        Me.ucrChkMissingValues.Name = "ucrChkMissingValues"
        Me.ucrChkMissingValues.Size = New System.Drawing.Size(194, 23)
        Me.ucrChkMissingValues.TabIndex = 11
        '
        'rdoMin
        '
        Me.rdoMin.AutoSize = True
        Me.rdoMin.Location = New System.Drawing.Point(10, 24)
        Me.rdoMin.Name = "rdoMin"
        Me.rdoMin.Size = New System.Drawing.Size(101, 17)
        Me.rdoMin.TabIndex = 4
        Me.rdoMin.TabStop = True
        Me.rdoMin.Text = "Minimum Values"
        Me.rdoMin.UseVisualStyleBackColor = True
        '
        'rdoMax
        '
        Me.rdoMax.AutoSize = True
        Me.rdoMax.Location = New System.Drawing.Point(12, 48)
        Me.rdoMax.Name = "rdoMax"
        Me.rdoMax.Size = New System.Drawing.Size(104, 17)
        Me.rdoMax.TabIndex = 9
        Me.rdoMax.TabStop = True
        Me.rdoMax.Text = "Maximum Values"
        Me.rdoMax.UseVisualStyleBackColor = True
        '
        'ucrPnlMaxMin
        '
        Me.ucrPnlMaxMin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMaxMin.Location = New System.Drawing.Point(6, 18)
        Me.ucrPnlMaxMin.Name = "ucrPnlMaxMin"
        Me.ucrPnlMaxMin.Size = New System.Drawing.Size(131, 49)
        Me.ucrPnlMaxMin.TabIndex = 7
        '
        'ucrChkFirstDate
        '
        Me.ucrChkFirstDate.AutoSize = True
        Me.ucrChkFirstDate.Checked = False
        Me.ucrChkFirstDate.Location = New System.Drawing.Point(10, 73)
        Me.ucrChkFirstDate.Name = "ucrChkFirstDate"
        Me.ucrChkFirstDate.Size = New System.Drawing.Size(194, 23)
        Me.ucrChkFirstDate.TabIndex = 0
        '
        'lblValues
        '
        Me.lblValues.AutoSize = True
        Me.lblValues.Location = New System.Drawing.Point(4, 22)
        Me.lblValues.Name = "lblValues"
        Me.lblValues.Size = New System.Drawing.Size(37, 13)
        Me.lblValues.TabIndex = 5
        Me.lblValues.Text = "Value:"
        '
        'cmdDoyRange
        '
        Me.cmdDoyRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoyRange.Location = New System.Drawing.Point(8, 440)
        Me.cmdDoyRange.Name = "cmdDoyRange"
        Me.cmdDoyRange.Size = New System.Drawing.Size(105, 26)
        Me.cmdDoyRange.TabIndex = 17
        Me.cmdDoyRange.Tag = ""
        Me.cmdDoyRange.Text = "Day Range"
        Me.cmdDoyRange.UseVisualStyleBackColor = True
        '
        'rdoMinMax
        '
        Me.rdoMinMax.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMinMax.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMinMax.FlatAppearance.BorderSize = 2
        Me.rdoMinMax.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMinMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMinMax.Location = New System.Drawing.Point(81, 6)
        Me.rdoMinMax.Name = "rdoMinMax"
        Me.rdoMinMax.Size = New System.Drawing.Size(88, 27)
        Me.rdoMinMax.TabIndex = 1
        Me.rdoMinMax.TabStop = True
        Me.rdoMinMax.Text = "Min/Max"
        Me.rdoMinMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMinMax.UseVisualStyleBackColor = True
        '
        'rdoPeaks
        '
        Me.rdoPeaks.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPeaks.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPeaks.FlatAppearance.BorderSize = 2
        Me.rdoPeaks.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPeaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPeaks.Location = New System.Drawing.Point(256, 6)
        Me.rdoPeaks.Name = "rdoPeaks"
        Me.rdoPeaks.Size = New System.Drawing.Size(87, 27)
        Me.rdoPeaks.TabIndex = 3
        Me.rdoPeaks.TabStop = True
        Me.rdoPeaks.Text = "Peaks"
        Me.rdoPeaks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPeaks.UseVisualStyleBackColor = True
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(251, 232)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 13
        Me.lblElement.Text = "Element:"
        '
        'lblNewColName
        '
        Me.lblNewColName.Location = New System.Drawing.Point(16, 470)
        Me.lblNewColName.Name = "lblNewColName"
        Me.lblNewColName.Size = New System.Drawing.Size(180, 19)
        Me.lblNewColName.TabIndex = 20
        Me.lblNewColName.Text = "New Column Name:"
        '
        'lblNewDFName
        '
        Me.lblNewDFName.AutoSize = True
        Me.lblNewDFName.Location = New System.Drawing.Point(17, 471)
        Me.lblNewDFName.Name = "lblNewDFName"
        Me.lblNewDFName.Size = New System.Drawing.Size(121, 13)
        Me.lblNewDFName.TabIndex = 1
        Me.lblNewDFName.Text = "New Data Frame Name:"
        '
        'grpPeakOptions
        '
        Me.grpPeakOptions.Controls.Add(Me.ucrInputThresholdValue)
        Me.grpPeakOptions.Controls.Add(Me.lblValues)
        Me.grpPeakOptions.Controls.Add(Me.ucrInputThresholdOperator)
        Me.grpPeakOptions.Location = New System.Drawing.Point(9, 229)
        Me.grpPeakOptions.Name = "grpPeakOptions"
        Me.grpPeakOptions.Size = New System.Drawing.Size(211, 46)
        Me.grpPeakOptions.TabIndex = 14
        Me.grpPeakOptions.TabStop = False
        Me.grpPeakOptions.Text = "Options"
        '
        'ucrInputThresholdValue
        '
        Me.ucrInputThresholdValue.AddQuotesIfUnrecognised = True
        Me.ucrInputThresholdValue.AutoSize = True
        Me.ucrInputThresholdValue.IsMultiline = False
        Me.ucrInputThresholdValue.IsReadOnly = False
        Me.ucrInputThresholdValue.Location = New System.Drawing.Point(113, 19)
        Me.ucrInputThresholdValue.Name = "ucrInputThresholdValue"
        Me.ucrInputThresholdValue.Size = New System.Drawing.Size(43, 21)
        Me.ucrInputThresholdValue.TabIndex = 0
        '
        'ucrInputThresholdOperator
        '
        Me.ucrInputThresholdOperator.AddQuotesIfUnrecognised = True
        Me.ucrInputThresholdOperator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputThresholdOperator.GetSetSelectedIndex = -1
        Me.ucrInputThresholdOperator.IsReadOnly = False
        Me.ucrInputThresholdOperator.Location = New System.Drawing.Point(44, 18)
        Me.ucrInputThresholdOperator.Name = "ucrInputThresholdOperator"
        Me.ucrInputThresholdOperator.Size = New System.Drawing.Size(68, 21)
        Me.ucrInputThresholdOperator.TabIndex = 6
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.Location = New System.Drawing.Point(6, 66)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(55, 13)
        Me.lblFill.TabIndex = 40
        Me.lblFill.Text = "Fill Colour:"
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(6, 43)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(63, 13)
        Me.lblColour.TabIndex = 39
        Me.lblColour.Text = "Line Colour:"
        '
        'lblMinimum
        '
        Me.lblMinimum.AutoSize = True
        Me.lblMinimum.Location = New System.Drawing.Point(6, 20)
        Me.lblMinimum.Name = "lblMinimum"
        Me.lblMinimum.Size = New System.Drawing.Size(33, 13)
        Me.lblMinimum.TabIndex = 34
        Me.lblMinimum.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(126, 20)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 32
        Me.lblTo.Text = "To:"
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Location = New System.Drawing.Point(6, 113)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(56, 13)
        Me.lblColumns.TabIndex = 31
        Me.lblColumns.Text = "Column(s):"
        '
        'lblThresholdColumns
        '
        Me.lblThresholdColumns.AutoSize = True
        Me.lblThresholdColumns.Location = New System.Drawing.Point(6, 108)
        Me.lblThresholdColumns.Name = "lblThresholdColumns"
        Me.lblThresholdColumns.Size = New System.Drawing.Size(56, 13)
        Me.lblThresholdColumns.TabIndex = 33
        Me.lblThresholdColumns.Text = "Column(s):"
        '
        'lblThresholds
        '
        Me.lblThresholds.AutoSize = True
        Me.lblThresholds.Location = New System.Drawing.Point(6, 84)
        Me.lblThresholds.Name = "lblThresholds"
        Me.lblThresholds.Size = New System.Drawing.Size(114, 13)
        Me.lblThresholds.TabIndex = 37
        Me.lblThresholds.Text = "Number of Thresholds:"
        '
        'lblAlpha
        '
        Me.lblAlpha.AutoSize = True
        Me.lblAlpha.Location = New System.Drawing.Point(6, 57)
        Me.lblAlpha.Name = "lblAlpha"
        Me.lblAlpha.Size = New System.Drawing.Size(37, 13)
        Me.lblAlpha.TabIndex = 38
        Me.lblAlpha.Text = "Alpha:"
        '
        'lblDistribution
        '
        Me.lblDistribution.AutoSize = True
        Me.lblDistribution.Location = New System.Drawing.Point(6, 29)
        Me.lblDistribution.Name = "lblDistribution"
        Me.lblDistribution.Size = New System.Drawing.Size(62, 13)
        Me.lblDistribution.TabIndex = 40
        Me.lblDistribution.Text = "Distribution:"
        '
        'rdoMrlPlot
        '
        Me.rdoMrlPlot.AutoSize = True
        Me.rdoMrlPlot.Location = New System.Drawing.Point(14, 16)
        Me.rdoMrlPlot.Name = "rdoMrlPlot"
        Me.rdoMrlPlot.Size = New System.Drawing.Size(107, 17)
        Me.rdoMrlPlot.TabIndex = 42
        Me.rdoMrlPlot.TabStop = True
        Me.rdoMrlPlot.Text = "Mean residual life"
        Me.rdoMrlPlot.UseVisualStyleBackColor = True
        '
        'rdoThreshRangePlot
        '
        Me.rdoThreshRangePlot.AutoSize = True
        Me.rdoThreshRangePlot.Location = New System.Drawing.Point(14, 35)
        Me.rdoThreshRangePlot.Name = "rdoThreshRangePlot"
        Me.rdoThreshRangePlot.Size = New System.Drawing.Size(105, 17)
        Me.rdoThreshRangePlot.TabIndex = 43
        Me.rdoThreshRangePlot.TabStop = True
        Me.rdoThreshRangePlot.Text = "Threshold range "
        Me.rdoThreshRangePlot.UseVisualStyleBackColor = True
        '
        'grpThresholdOptions
        '
        Me.grpThresholdOptions.Controls.Add(Me.lblThresholds)
        Me.grpThresholdOptions.Controls.Add(Me.ucrNudThresholdColumns)
        Me.grpThresholdOptions.Controls.Add(Me.lblThresholdColumns)
        Me.grpThresholdOptions.Controls.Add(Me.ucrNudAlpha)
        Me.grpThresholdOptions.Controls.Add(Me.ucrNudThresholds)
        Me.grpThresholdOptions.Controls.Add(Me.lblAlpha)
        Me.grpThresholdOptions.Controls.Add(Me.ucrInputDistribution)
        Me.grpThresholdOptions.Controls.Add(Me.lblDistribution)
        Me.grpThresholdOptions.Location = New System.Drawing.Point(10, 297)
        Me.grpThresholdOptions.Name = "grpThresholdOptions"
        Me.grpThresholdOptions.Size = New System.Drawing.Size(210, 141)
        Me.grpThresholdOptions.TabIndex = 44
        Me.grpThresholdOptions.TabStop = False
        Me.grpThresholdOptions.Text = "Options"
        '
        'ucrNudThresholdColumns
        '
        Me.ucrNudThresholdColumns.AutoSize = True
        Me.ucrNudThresholdColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholdColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThresholdColumns.Location = New System.Drawing.Point(70, 106)
        Me.ucrNudThresholdColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThresholdColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholdColumns.Name = "ucrNudThresholdColumns"
        Me.ucrNudThresholdColumns.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThresholdColumns.TabIndex = 32
        Me.ucrNudThresholdColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAlpha
        '
        Me.ucrNudAlpha.AutoSize = True
        Me.ucrNudAlpha.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlpha.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAlpha.Location = New System.Drawing.Point(72, 54)
        Me.ucrNudAlpha.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAlpha.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlpha.Name = "ucrNudAlpha"
        Me.ucrNudAlpha.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAlpha.TabIndex = 35
        Me.ucrNudAlpha.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudThresholds
        '
        Me.ucrNudThresholds.AutoSize = True
        Me.ucrNudThresholds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThresholds.Location = New System.Drawing.Point(124, 81)
        Me.ucrNudThresholds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThresholds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholds.Name = "ucrNudThresholds"
        Me.ucrNudThresholds.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThresholds.TabIndex = 36
        Me.ucrNudThresholds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputDistribution
        '
        Me.ucrInputDistribution.AddQuotesIfUnrecognised = True
        Me.ucrInputDistribution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDistribution.GetSetSelectedIndex = -1
        Me.ucrInputDistribution.IsReadOnly = False
        Me.ucrInputDistribution.Location = New System.Drawing.Point(71, 25)
        Me.ucrInputDistribution.Name = "ucrInputDistribution"
        Me.ucrInputDistribution.Size = New System.Drawing.Size(78, 21)
        Me.ucrInputDistribution.TabIndex = 39
        '
        'grpMrlOptions
        '
        Me.grpMrlOptions.Controls.Add(Me.lblColour)
        Me.grpMrlOptions.Controls.Add(Me.ucrNudColumns)
        Me.grpMrlOptions.Controls.Add(Me.lblFill)
        Me.grpMrlOptions.Controls.Add(Me.lblColumns)
        Me.grpMrlOptions.Controls.Add(Me.lblTo)
        Me.grpMrlOptions.Controls.Add(Me.ucrInputMin)
        Me.grpMrlOptions.Controls.Add(Me.ucrChkRugPlot)
        Me.grpMrlOptions.Controls.Add(Me.lblMinimum)
        Me.grpMrlOptions.Controls.Add(Me.ucrInputMax)
        Me.grpMrlOptions.Controls.Add(Me.ucrInputColours)
        Me.grpMrlOptions.Controls.Add(Me.ucrInputFill)
        Me.grpMrlOptions.Location = New System.Drawing.Point(10, 300)
        Me.grpMrlOptions.Name = "grpMrlOptions"
        Me.grpMrlOptions.Size = New System.Drawing.Size(273, 139)
        Me.grpMrlOptions.TabIndex = 16
        Me.grpMrlOptions.TabStop = False
        Me.grpMrlOptions.Text = "Options"
        '
        'ucrNudColumns
        '
        Me.ucrNudColumns.AutoSize = True
        Me.ucrNudColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColumns.Location = New System.Drawing.Point(75, 111)
        Me.ucrNudColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumns.Name = "ucrNudColumns"
        Me.ucrNudColumns.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudColumns.TabIndex = 30
        Me.ucrNudColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputMin
        '
        Me.ucrInputMin.AddQuotesIfUnrecognised = True
        Me.ucrInputMin.AutoSize = True
        Me.ucrInputMin.IsMultiline = False
        Me.ucrInputMin.IsReadOnly = False
        Me.ucrInputMin.Location = New System.Drawing.Point(75, 16)
        Me.ucrInputMin.Name = "ucrInputMin"
        Me.ucrInputMin.Size = New System.Drawing.Size(43, 21)
        Me.ucrInputMin.TabIndex = 33
        '
        'ucrChkRugPlot
        '
        Me.ucrChkRugPlot.AutoSize = True
        Me.ucrChkRugPlot.Checked = False
        Me.ucrChkRugPlot.Location = New System.Drawing.Point(9, 88)
        Me.ucrChkRugPlot.Name = "ucrChkRugPlot"
        Me.ucrChkRugPlot.Size = New System.Drawing.Size(144, 23)
        Me.ucrChkRugPlot.TabIndex = 38
        '
        'ucrInputMax
        '
        Me.ucrInputMax.AddQuotesIfUnrecognised = True
        Me.ucrInputMax.AutoSize = True
        Me.ucrInputMax.IsMultiline = False
        Me.ucrInputMax.IsReadOnly = False
        Me.ucrInputMax.Location = New System.Drawing.Point(152, 16)
        Me.ucrInputMax.Name = "ucrInputMax"
        Me.ucrInputMax.Size = New System.Drawing.Size(43, 21)
        Me.ucrInputMax.TabIndex = 35
        '
        'ucrInputColours
        '
        Me.ucrInputColours.AddQuotesIfUnrecognised = True
        Me.ucrInputColours.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColours.GetSetSelectedIndex = -1
        Me.ucrInputColours.IsReadOnly = False
        Me.ucrInputColours.Location = New System.Drawing.Point(152, 40)
        Me.ucrInputColours.Name = "ucrInputColours"
        Me.ucrInputColours.Size = New System.Drawing.Size(78, 21)
        Me.ucrInputColours.TabIndex = 37
        '
        'ucrInputFill
        '
        Me.ucrInputFill.AddQuotesIfUnrecognised = True
        Me.ucrInputFill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFill.GetSetSelectedIndex = -1
        Me.ucrInputFill.IsReadOnly = False
        Me.ucrInputFill.Location = New System.Drawing.Point(152, 64)
        Me.ucrInputFill.Name = "ucrInputFill"
        Me.ucrInputFill.Size = New System.Drawing.Size(78, 21)
        Me.ucrInputFill.TabIndex = 36
        '
        'grpPlots
        '
        Me.grpPlots.Controls.Add(Me.rdoMrlPlot)
        Me.grpPlots.Controls.Add(Me.rdoThreshRangePlot)
        Me.grpPlots.Controls.Add(Me.ucrPnlPlots)
        Me.grpPlots.Location = New System.Drawing.Point(9, 218)
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.Size = New System.Drawing.Size(211, 65)
        Me.grpPlots.TabIndex = 15
        Me.grpPlots.TabStop = False
        Me.grpPlots.Text = "Plots"
        '
        'ucrPnlPlots
        '
        Me.ucrPnlPlots.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlPlots.Location = New System.Drawing.Point(12, 13)
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        Me.ucrPnlPlots.Size = New System.Drawing.Size(111, 44)
        Me.ucrPnlPlots.TabIndex = 41
        '
        'rdoThreshold
        '
        Me.rdoThreshold.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoThreshold.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreshold.FlatAppearance.BorderSize = 2
        Me.rdoThreshold.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreshold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoThreshold.Location = New System.Drawing.Point(169, 6)
        Me.rdoThreshold.Name = "rdoThreshold"
        Me.rdoThreshold.Size = New System.Drawing.Size(87, 27)
        Me.rdoThreshold.TabIndex = 2
        Me.rdoThreshold.TabStop = True
        Me.rdoThreshold.Text = "Threshold "
        Me.rdoThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoThreshold.UseVisualStyleBackColor = True
        '
        'lblDeclusterColumns
        '
        Me.lblDeclusterColumns.AutoSize = True
        Me.lblDeclusterColumns.Location = New System.Drawing.Point(7, 74)
        Me.lblDeclusterColumns.Name = "lblDeclusterColumns"
        Me.lblDeclusterColumns.Size = New System.Drawing.Size(82, 13)
        Me.lblDeclusterColumns.TabIndex = 51
        Me.lblDeclusterColumns.Text = "Graph Columns:"
        '
        'grpDeclusteringOptions
        '
        Me.grpDeclusteringOptions.Controls.Add(Me.ucrChkRunLength)
        Me.grpDeclusteringOptions.Controls.Add(Me.ucrNudRunLength)
        Me.grpDeclusteringOptions.Controls.Add(Me.ucrChkPrintSummary)
        Me.grpDeclusteringOptions.Controls.Add(Me.ucrNudDeclusterColumns)
        Me.grpDeclusteringOptions.Controls.Add(Me.lblDeclusterColumns)
        Me.grpDeclusteringOptions.Location = New System.Drawing.Point(11, 282)
        Me.grpDeclusteringOptions.Name = "grpDeclusteringOptions"
        Me.grpDeclusteringOptions.Size = New System.Drawing.Size(209, 100)
        Me.grpDeclusteringOptions.TabIndex = 16
        Me.grpDeclusteringOptions.TabStop = False
        Me.grpDeclusteringOptions.Text = "Options"
        '
        'ucrChkRunLength
        '
        Me.ucrChkRunLength.AutoSize = True
        Me.ucrChkRunLength.Checked = False
        Me.ucrChkRunLength.Location = New System.Drawing.Point(7, 20)
        Me.ucrChkRunLength.Name = "ucrChkRunLength"
        Me.ucrChkRunLength.Size = New System.Drawing.Size(117, 23)
        Me.ucrChkRunLength.TabIndex = 52
        '
        'ucrNudRunLength
        '
        Me.ucrNudRunLength.AutoSize = True
        Me.ucrNudRunLength.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRunLength.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRunLength.Location = New System.Drawing.Point(145, 20)
        Me.ucrNudRunLength.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRunLength.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRunLength.Name = "ucrNudRunLength"
        Me.ucrNudRunLength.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudRunLength.TabIndex = 49
        Me.ucrNudRunLength.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkPrintSummary
        '
        Me.ucrChkPrintSummary.AutoSize = True
        Me.ucrChkPrintSummary.Checked = False
        Me.ucrChkPrintSummary.Location = New System.Drawing.Point(7, 47)
        Me.ucrChkPrintSummary.Name = "ucrChkPrintSummary"
        Me.ucrChkPrintSummary.Size = New System.Drawing.Size(149, 23)
        Me.ucrChkPrintSummary.TabIndex = 45
        '
        'ucrNudDeclusterColumns
        '
        Me.ucrNudDeclusterColumns.AutoSize = True
        Me.ucrNudDeclusterColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDeclusterColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDeclusterColumns.Location = New System.Drawing.Point(145, 70)
        Me.ucrNudDeclusterColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDeclusterColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDeclusterColumns.Name = "ucrNudDeclusterColumns"
        Me.ucrNudDeclusterColumns.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDeclusterColumns.TabIndex = 50
        Me.ucrNudDeclusterColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkDeclustering
        '
        Me.ucrChkDeclustering.AutoSize = True
        Me.ucrChkDeclustering.Checked = False
        Me.ucrChkDeclustering.Location = New System.Drawing.Point(251, 282)
        Me.ucrChkDeclustering.Name = "ucrChkDeclustering"
        Me.ucrChkDeclustering.Size = New System.Drawing.Size(93, 23)
        Me.ucrChkDeclustering.TabIndex = 53
        '
        'ucrSaveDeclusteredPlot
        '
        Me.ucrSaveDeclusteredPlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDeclusteredPlot.Location = New System.Drawing.Point(8, 411)
        Me.ucrSaveDeclusteredPlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveDeclusteredPlot.Name = "ucrSaveDeclusteredPlot"
        Me.ucrSaveDeclusteredPlot.Size = New System.Drawing.Size(267, 24)
        Me.ucrSaveDeclusteredPlot.TabIndex = 19
        '
        'ucrSaveThresholdPlot
        '
        Me.ucrSaveThresholdPlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveThresholdPlot.Location = New System.Drawing.Point(8, 468)
        Me.ucrSaveThresholdPlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveThresholdPlot.Name = "ucrSaveThresholdPlot"
        Me.ucrSaveThresholdPlot.Size = New System.Drawing.Size(320, 24)
        Me.ucrSaveThresholdPlot.TabIndex = 19
        '
        'ucrSaveMrlPlot
        '
        Me.ucrSaveMrlPlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveMrlPlot.Location = New System.Drawing.Point(8, 468)
        Me.ucrSaveMrlPlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveMrlPlot.Name = "ucrSaveMrlPlot"
        Me.ucrSaveMrlPlot.Size = New System.Drawing.Size(369, 24)
        Me.ucrSaveMrlPlot.TabIndex = 15
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.AutoSize = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = True
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(115, 442)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(242, 22)
        Me.ucrInputFilterPreview.TabIndex = 18
        '
        'ucrInputSave
        '
        Me.ucrInputSave.AddQuotesIfUnrecognised = True
        Me.ucrInputSave.AutoSize = True
        Me.ucrInputSave.IsMultiline = False
        Me.ucrInputSave.IsReadOnly = False
        Me.ucrInputSave.Location = New System.Drawing.Point(203, 469)
        Me.ucrInputSave.Name = "ucrInputSave"
        Me.ucrInputSave.Size = New System.Drawing.Size(170, 21)
        Me.ucrInputSave.TabIndex = 20
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.AutoSize = True
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(251, 204)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 12
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(251, 161)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 10
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(251, 119)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 8
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(251, 77)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 6
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.AutoSize = True
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(251, 247)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 14
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrSelectorClimaticExtremes
        '
        Me.ucrSelectorClimaticExtremes.AutoSize = True
        Me.ucrSelectorClimaticExtremes.bDropUnusedFilterLevels = False
        Me.ucrSelectorClimaticExtremes.bShowHiddenColumns = False
        Me.ucrSelectorClimaticExtremes.bUseCurrentFilter = True
        Me.ucrSelectorClimaticExtremes.Location = New System.Drawing.Point(10, 36)
        Me.ucrSelectorClimaticExtremes.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimaticExtremes.Name = "ucrSelectorClimaticExtremes"
        Me.ucrSelectorClimaticExtremes.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorClimaticExtremes.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 494)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 21
        '
        'ucrPnlExtremesType
        '
        Me.ucrPnlExtremesType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlExtremesType.Location = New System.Drawing.Point(72, 2)
        Me.ucrPnlExtremesType.Name = "ucrPnlExtremesType"
        Me.ucrPnlExtremesType.Size = New System.Drawing.Size(280, 37)
        Me.ucrPnlExtremesType.TabIndex = 0
        '
        'dlgExtremesClimatic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(416, 549)
        Me.Controls.Add(Me.ucrChkDeclustering)
        Me.Controls.Add(Me.grpDeclusteringOptions)
        Me.Controls.Add(Me.ucrSaveDeclusteredPlot)
        Me.Controls.Add(Me.ucrSaveThresholdPlot)
        Me.Controls.Add(Me.ucrSaveMrlPlot)
        Me.Controls.Add(Me.grpMrlOptions)
        Me.Controls.Add(Me.grpThresholdOptions)
        Me.Controls.Add(Me.rdoThreshold)
        Me.Controls.Add(Me.grpPeakOptions)
        Me.Controls.Add(Me.cmdDoyRange)
        Me.Controls.Add(Me.ucrInputFilterPreview)
        Me.Controls.Add(Me.lblNewColName)
        Me.Controls.Add(Me.ucrInputSave)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.rdoPeaks)
        Me.Controls.Add(Me.rdoMinMax)
        Me.Controls.Add(Me.lblDayOfYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStations)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrSelectorClimaticExtremes)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlExtremesType)
        Me.Controls.Add(Me.lblNewDFName)
        Me.Controls.Add(Me.grpPlots)
        Me.Controls.Add(Me.grpMinMaxOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExtremesClimatic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extremes "
        Me.grpMinMaxOptions.ResumeLayout(False)
        Me.grpMinMaxOptions.PerformLayout()
        Me.grpPeakOptions.ResumeLayout(False)
        Me.grpPeakOptions.PerformLayout()
        Me.grpThresholdOptions.ResumeLayout(False)
        Me.grpThresholdOptions.PerformLayout()
        Me.grpMrlOptions.ResumeLayout(False)
        Me.grpMrlOptions.PerformLayout()
        Me.grpPlots.ResumeLayout(False)
        Me.grpPlots.PerformLayout()
        Me.grpDeclusteringOptions.ResumeLayout(False)
        Me.grpDeclusteringOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorClimaticExtremes As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents grpMinMaxOptions As GroupBox
    Friend WithEvents lblDayOfYear As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStations As Label
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrPnlExtremesType As UcrPanel
    Friend WithEvents rdoPeaks As RadioButton
    Friend WithEvents rdoMinMax As RadioButton
    Friend WithEvents ucrChkFirstDate As ucrCheck
    Friend WithEvents lblElement As Label
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents ucrInputSave As ucrInputTextBox
    Friend WithEvents ucrInputThresholdValue As ucrInputTextBox
    Friend WithEvents ucrInputThresholdOperator As ucrInputComboBox
    Friend WithEvents lblValues As Label
    Friend WithEvents rdoMin As RadioButton
    Friend WithEvents rdoMax As RadioButton
    Friend WithEvents ucrPnlMaxMin As UcrPanel
    Friend WithEvents lblNewColName As Label
    Friend WithEvents ucrChkMissingValues As ucrCheck
    Friend WithEvents lblNewDFName As Label
    Friend WithEvents cmdDoyRange As Button
    Friend WithEvents ucrInputFilterPreview As ucrInputTextBox
    Friend WithEvents ucrChkLastDate As ucrCheck
    Friend WithEvents ucrChkNDates As ucrCheck
    Friend WithEvents grpPeakOptions As GroupBox
    Friend WithEvents ucrSaveMrlPlot As ucrSave
    Friend WithEvents ucrNudColumns As ucrNud
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrInputMax As ucrInputTextBox
    Friend WithEvents lblMinimum As Label
    Friend WithEvents ucrInputMin As ucrInputTextBox
    Friend WithEvents lblTo As Label
    Friend WithEvents ucrInputColours As ucrInputComboBox
    Friend WithEvents ucrInputFill As ucrInputComboBox
    Friend WithEvents ucrChkRugPlot As ucrCheck
    Friend WithEvents lblFill As Label
    Friend WithEvents lblColour As Label
    Friend WithEvents lblThresholdColumns As Label
    Friend WithEvents ucrNudThresholdColumns As ucrNud
    Friend WithEvents ucrNudThresholds As ucrNud
    Friend WithEvents ucrNudAlpha As ucrNud
    Friend WithEvents lblAlpha As Label
    Friend WithEvents lblThresholds As Label
    Friend WithEvents lblDistribution As Label
    Friend WithEvents ucrInputDistribution As ucrInputComboBox
    Friend WithEvents rdoThreshRangePlot As RadioButton
    Friend WithEvents rdoMrlPlot As RadioButton
    Friend WithEvents ucrPnlPlots As UcrPanel
    Friend WithEvents grpMrlOptions As GroupBox
    Friend WithEvents grpThresholdOptions As GroupBox
    Friend WithEvents grpPlots As GroupBox
    Friend WithEvents rdoThreshold As RadioButton
    Friend WithEvents ucrSaveThresholdPlot As ucrSave
    Friend WithEvents ttpThreshold As ToolTip
    Friend WithEvents ucrChkPrintSummary As ucrCheck
    Friend WithEvents ucrSaveDeclusteredPlot As ucrSave
    Friend WithEvents ucrNudRunLength As ucrNud
    Friend WithEvents ucrNudDeclusterColumns As ucrNud
    Friend WithEvents lblDeclusterColumns As Label
    Friend WithEvents grpDeclusteringOptions As GroupBox
    Friend WithEvents ucrChkRunLength As ucrCheck
    Friend WithEvents ucrChkDeclustering As ucrCheck
End Class
