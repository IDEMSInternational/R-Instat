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
        Me.ucrChkVariableName = New instat.ucrCheck()
        Me.ucrSaveVariableName = New instat.ucrSave()
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
        Me.lblStations.Location = New System.Drawing.Point(376, 93)
        Me.lblStations.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Size = New System.Drawing.Size(64, 20)
        Me.lblStations.TabIndex = 5
        Me.lblStations.Text = "Station:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(376, 156)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(376, 219)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(47, 20)
        Me.lblYear.TabIndex = 9
        Me.lblYear.Text = "Year:"
        '
        'lblDayOfYear
        '
        Me.lblDayOfYear.AutoSize = True
        Me.lblDayOfYear.Location = New System.Drawing.Point(376, 284)
        Me.lblDayOfYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDayOfYear.Name = "lblDayOfYear"
        Me.lblDayOfYear.Size = New System.Drawing.Size(97, 20)
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
        Me.grpMinMaxOptions.Location = New System.Drawing.Point(15, 342)
        Me.grpMinMaxOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpMinMaxOptions.Name = "grpMinMaxOptions"
        Me.grpMinMaxOptions.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpMinMaxOptions.Size = New System.Drawing.Size(315, 260)
        Me.grpMinMaxOptions.TabIndex = 14
        Me.grpMinMaxOptions.TabStop = False
        Me.grpMinMaxOptions.Text = "Options"
        '
        'ucrChkLastDate
        '
        Me.ucrChkLastDate.AutoSize = True
        Me.ucrChkLastDate.Checked = False
        Me.ucrChkLastDate.Location = New System.Drawing.Point(14, 182)
        Me.ucrChkLastDate.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkLastDate.Name = "ucrChkLastDate"
        Me.ucrChkLastDate.Size = New System.Drawing.Size(292, 51)
        Me.ucrChkLastDate.TabIndex = 13
        '
        'ucrChkNDates
        '
        Me.ucrChkNDates.AutoSize = True
        Me.ucrChkNDates.Checked = False
        Me.ucrChkNDates.Location = New System.Drawing.Point(15, 146)
        Me.ucrChkNDates.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkNDates.Name = "ucrChkNDates"
        Me.ucrChkNDates.Size = New System.Drawing.Size(291, 51)
        Me.ucrChkNDates.TabIndex = 12
        '
        'ucrChkMissingValues
        '
        Me.ucrChkMissingValues.AutoSize = True
        Me.ucrChkMissingValues.Checked = False
        Me.ucrChkMissingValues.Location = New System.Drawing.Point(15, 220)
        Me.ucrChkMissingValues.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkMissingValues.Name = "ucrChkMissingValues"
        Me.ucrChkMissingValues.Size = New System.Drawing.Size(291, 51)
        Me.ucrChkMissingValues.TabIndex = 11
        '
        'rdoMin
        '
        Me.rdoMin.AutoSize = True
        Me.rdoMin.Location = New System.Drawing.Point(15, 36)
        Me.rdoMin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoMin.Name = "rdoMin"
        Me.rdoMin.Size = New System.Drawing.Size(150, 24)
        Me.rdoMin.TabIndex = 4
        Me.rdoMin.TabStop = True
        Me.rdoMin.Text = "Minimum Values"
        Me.rdoMin.UseVisualStyleBackColor = True
        '
        'rdoMax
        '
        Me.rdoMax.AutoSize = True
        Me.rdoMax.Location = New System.Drawing.Point(18, 72)
        Me.rdoMax.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoMax.Name = "rdoMax"
        Me.rdoMax.Size = New System.Drawing.Size(154, 24)
        Me.rdoMax.TabIndex = 9
        Me.rdoMax.TabStop = True
        Me.rdoMax.Text = "Maximum Values"
        Me.rdoMax.UseVisualStyleBackColor = True
        '
        'ucrPnlMaxMin
        '
        Me.ucrPnlMaxMin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMaxMin.Location = New System.Drawing.Point(9, 27)
        Me.ucrPnlMaxMin.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrPnlMaxMin.Name = "ucrPnlMaxMin"
        Me.ucrPnlMaxMin.Size = New System.Drawing.Size(196, 74)
        Me.ucrPnlMaxMin.TabIndex = 7
        '
        'ucrChkFirstDate
        '
        Me.ucrChkFirstDate.AutoSize = True
        Me.ucrChkFirstDate.Checked = False
        Me.ucrChkFirstDate.Location = New System.Drawing.Point(15, 110)
        Me.ucrChkFirstDate.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkFirstDate.Name = "ucrChkFirstDate"
        Me.ucrChkFirstDate.Size = New System.Drawing.Size(291, 51)
        Me.ucrChkFirstDate.TabIndex = 0
        '
        'lblValues
        '
        Me.lblValues.AutoSize = True
        Me.lblValues.Location = New System.Drawing.Point(6, 33)
        Me.lblValues.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValues.Name = "lblValues"
        Me.lblValues.Size = New System.Drawing.Size(54, 20)
        Me.lblValues.TabIndex = 5
        Me.lblValues.Text = "Value:"
        '
        'cmdDoyRange
        '
        Me.cmdDoyRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoyRange.Location = New System.Drawing.Point(12, 660)
        Me.cmdDoyRange.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdDoyRange.Name = "cmdDoyRange"
        Me.cmdDoyRange.Size = New System.Drawing.Size(158, 39)
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
        Me.rdoMinMax.Location = New System.Drawing.Point(122, 9)
        Me.rdoMinMax.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoMinMax.Name = "rdoMinMax"
        Me.rdoMinMax.Size = New System.Drawing.Size(132, 40)
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
        Me.rdoPeaks.Location = New System.Drawing.Point(384, 9)
        Me.rdoPeaks.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoPeaks.Name = "rdoPeaks"
        Me.rdoPeaks.Size = New System.Drawing.Size(130, 40)
        Me.rdoPeaks.TabIndex = 3
        Me.rdoPeaks.TabStop = True
        Me.rdoPeaks.Text = "Peaks"
        Me.rdoPeaks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPeaks.UseVisualStyleBackColor = True
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(376, 348)
        Me.lblElement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(72, 20)
        Me.lblElement.TabIndex = 13
        Me.lblElement.Text = "Element:"
        '
        'lblNewColName
        '
        Me.lblNewColName.Location = New System.Drawing.Point(24, 705)
        Me.lblNewColName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewColName.Name = "lblNewColName"
        Me.lblNewColName.Size = New System.Drawing.Size(270, 28)
        Me.lblNewColName.TabIndex = 20
        Me.lblNewColName.Text = "New Column Name:"
        '
        'lblNewDFName
        '
        Me.lblNewDFName.AutoSize = True
        Me.lblNewDFName.Location = New System.Drawing.Point(26, 706)
        Me.lblNewDFName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewDFName.Name = "lblNewDFName"
        Me.lblNewDFName.Size = New System.Drawing.Size(179, 20)
        Me.lblNewDFName.TabIndex = 1
        Me.lblNewDFName.Text = "New Data Frame Name:"
        '
        'grpPeakOptions
        '
        Me.grpPeakOptions.Controls.Add(Me.ucrInputThresholdValue)
        Me.grpPeakOptions.Controls.Add(Me.lblValues)
        Me.grpPeakOptions.Controls.Add(Me.ucrInputThresholdOperator)
        Me.grpPeakOptions.Location = New System.Drawing.Point(14, 344)
        Me.grpPeakOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPeakOptions.Name = "grpPeakOptions"
        Me.grpPeakOptions.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPeakOptions.Size = New System.Drawing.Size(316, 69)
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
        Me.ucrInputThresholdValue.Location = New System.Drawing.Point(170, 28)
        Me.ucrInputThresholdValue.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputThresholdValue.Name = "ucrInputThresholdValue"
        Me.ucrInputThresholdValue.Size = New System.Drawing.Size(64, 32)
        Me.ucrInputThresholdValue.TabIndex = 0
        '
        'ucrInputThresholdOperator
        '
        Me.ucrInputThresholdOperator.AddQuotesIfUnrecognised = True
        Me.ucrInputThresholdOperator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputThresholdOperator.GetSetSelectedIndex = -1
        Me.ucrInputThresholdOperator.IsReadOnly = False
        Me.ucrInputThresholdOperator.Location = New System.Drawing.Point(66, 27)
        Me.ucrInputThresholdOperator.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputThresholdOperator.Name = "ucrInputThresholdOperator"
        Me.ucrInputThresholdOperator.Size = New System.Drawing.Size(102, 32)
        Me.ucrInputThresholdOperator.TabIndex = 6
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.Location = New System.Drawing.Point(9, 99)
        Me.lblFill.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(82, 20)
        Me.lblFill.TabIndex = 40
        Me.lblFill.Text = "Fill Colour:"
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(9, 64)
        Me.lblColour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(93, 20)
        Me.lblColour.TabIndex = 39
        Me.lblColour.Text = "Line Colour:"
        '
        'lblMinimum
        '
        Me.lblMinimum.AutoSize = True
        Me.lblMinimum.Location = New System.Drawing.Point(9, 30)
        Me.lblMinimum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinimum.Name = "lblMinimum"
        Me.lblMinimum.Size = New System.Drawing.Size(50, 20)
        Me.lblMinimum.TabIndex = 34
        Me.lblMinimum.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(189, 30)
        Me.lblTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(31, 20)
        Me.lblTo.TabIndex = 32
        Me.lblTo.Text = "To:"
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Location = New System.Drawing.Point(9, 170)
        Me.lblColumns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(85, 20)
        Me.lblColumns.TabIndex = 31
        Me.lblColumns.Text = "Column(s):"
        '
        'lblThresholdColumns
        '
        Me.lblThresholdColumns.AutoSize = True
        Me.lblThresholdColumns.Location = New System.Drawing.Point(9, 162)
        Me.lblThresholdColumns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThresholdColumns.Name = "lblThresholdColumns"
        Me.lblThresholdColumns.Size = New System.Drawing.Size(85, 20)
        Me.lblThresholdColumns.TabIndex = 33
        Me.lblThresholdColumns.Text = "Column(s):"
        '
        'lblThresholds
        '
        Me.lblThresholds.AutoSize = True
        Me.lblThresholds.Location = New System.Drawing.Point(9, 126)
        Me.lblThresholds.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThresholds.Name = "lblThresholds"
        Me.lblThresholds.Size = New System.Drawing.Size(169, 20)
        Me.lblThresholds.TabIndex = 37
        Me.lblThresholds.Text = "Number of Thresholds:"
        '
        'lblAlpha
        '
        Me.lblAlpha.AutoSize = True
        Me.lblAlpha.Location = New System.Drawing.Point(9, 86)
        Me.lblAlpha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAlpha.Name = "lblAlpha"
        Me.lblAlpha.Size = New System.Drawing.Size(54, 20)
        Me.lblAlpha.TabIndex = 38
        Me.lblAlpha.Text = "Alpha:"
        '
        'lblDistribution
        '
        Me.lblDistribution.AutoSize = True
        Me.lblDistribution.Location = New System.Drawing.Point(9, 44)
        Me.lblDistribution.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDistribution.Name = "lblDistribution"
        Me.lblDistribution.Size = New System.Drawing.Size(93, 20)
        Me.lblDistribution.TabIndex = 40
        Me.lblDistribution.Text = "Distribution:"
        '
        'rdoMrlPlot
        '
        Me.rdoMrlPlot.AutoSize = True
        Me.rdoMrlPlot.Location = New System.Drawing.Point(21, 24)
        Me.rdoMrlPlot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoMrlPlot.Name = "rdoMrlPlot"
        Me.rdoMrlPlot.Size = New System.Drawing.Size(157, 24)
        Me.rdoMrlPlot.TabIndex = 42
        Me.rdoMrlPlot.TabStop = True
        Me.rdoMrlPlot.Text = "Mean residual life"
        Me.rdoMrlPlot.UseVisualStyleBackColor = True
        '
        'rdoThreshRangePlot
        '
        Me.rdoThreshRangePlot.AutoSize = True
        Me.rdoThreshRangePlot.Location = New System.Drawing.Point(21, 52)
        Me.rdoThreshRangePlot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoThreshRangePlot.Name = "rdoThreshRangePlot"
        Me.rdoThreshRangePlot.Size = New System.Drawing.Size(153, 24)
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
        Me.grpThresholdOptions.Location = New System.Drawing.Point(15, 446)
        Me.grpThresholdOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpThresholdOptions.Name = "grpThresholdOptions"
        Me.grpThresholdOptions.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpThresholdOptions.Size = New System.Drawing.Size(315, 212)
        Me.grpThresholdOptions.TabIndex = 44
        Me.grpThresholdOptions.TabStop = False
        Me.grpThresholdOptions.Text = "Options"
        '
        'ucrNudThresholdColumns
        '
        Me.ucrNudThresholdColumns.AutoSize = True
        Me.ucrNudThresholdColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholdColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThresholdColumns.Location = New System.Drawing.Point(105, 159)
        Me.ucrNudThresholdColumns.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudThresholdColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThresholdColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholdColumns.Name = "ucrNudThresholdColumns"
        Me.ucrNudThresholdColumns.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudThresholdColumns.TabIndex = 32
        Me.ucrNudThresholdColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAlpha
        '
        Me.ucrNudAlpha.AutoSize = True
        Me.ucrNudAlpha.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlpha.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAlpha.Location = New System.Drawing.Point(108, 81)
        Me.ucrNudAlpha.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudAlpha.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAlpha.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlpha.Name = "ucrNudAlpha"
        Me.ucrNudAlpha.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudAlpha.TabIndex = 35
        Me.ucrNudAlpha.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudThresholds
        '
        Me.ucrNudThresholds.AutoSize = True
        Me.ucrNudThresholds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThresholds.Location = New System.Drawing.Point(186, 122)
        Me.ucrNudThresholds.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudThresholds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThresholds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThresholds.Name = "ucrNudThresholds"
        Me.ucrNudThresholds.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudThresholds.TabIndex = 36
        Me.ucrNudThresholds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputDistribution
        '
        Me.ucrInputDistribution.AddQuotesIfUnrecognised = True
        Me.ucrInputDistribution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDistribution.GetSetSelectedIndex = -1
        Me.ucrInputDistribution.IsReadOnly = False
        Me.ucrInputDistribution.Location = New System.Drawing.Point(106, 38)
        Me.ucrInputDistribution.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputDistribution.Name = "ucrInputDistribution"
        Me.ucrInputDistribution.Size = New System.Drawing.Size(117, 32)
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
        Me.grpMrlOptions.Location = New System.Drawing.Point(15, 450)
        Me.grpMrlOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpMrlOptions.Name = "grpMrlOptions"
        Me.grpMrlOptions.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpMrlOptions.Size = New System.Drawing.Size(410, 208)
        Me.grpMrlOptions.TabIndex = 16
        Me.grpMrlOptions.TabStop = False
        Me.grpMrlOptions.Text = "Options"
        '
        'ucrNudColumns
        '
        Me.ucrNudColumns.AutoSize = True
        Me.ucrNudColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColumns.Location = New System.Drawing.Point(112, 166)
        Me.ucrNudColumns.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumns.Name = "ucrNudColumns"
        Me.ucrNudColumns.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudColumns.TabIndex = 30
        Me.ucrNudColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputMin
        '
        Me.ucrInputMin.AddQuotesIfUnrecognised = True
        Me.ucrInputMin.AutoSize = True
        Me.ucrInputMin.IsMultiline = False
        Me.ucrInputMin.IsReadOnly = False
        Me.ucrInputMin.Location = New System.Drawing.Point(112, 24)
        Me.ucrInputMin.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputMin.Name = "ucrInputMin"
        Me.ucrInputMin.Size = New System.Drawing.Size(64, 32)
        Me.ucrInputMin.TabIndex = 33
        '
        'ucrChkRugPlot
        '
        Me.ucrChkRugPlot.AutoSize = True
        Me.ucrChkRugPlot.Checked = False
        Me.ucrChkRugPlot.Location = New System.Drawing.Point(14, 132)
        Me.ucrChkRugPlot.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkRugPlot.Name = "ucrChkRugPlot"
        Me.ucrChkRugPlot.Size = New System.Drawing.Size(216, 51)
        Me.ucrChkRugPlot.TabIndex = 38
        '
        'ucrInputMax
        '
        Me.ucrInputMax.AddQuotesIfUnrecognised = True
        Me.ucrInputMax.AutoSize = True
        Me.ucrInputMax.IsMultiline = False
        Me.ucrInputMax.IsReadOnly = False
        Me.ucrInputMax.Location = New System.Drawing.Point(228, 24)
        Me.ucrInputMax.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputMax.Name = "ucrInputMax"
        Me.ucrInputMax.Size = New System.Drawing.Size(64, 32)
        Me.ucrInputMax.TabIndex = 35
        '
        'ucrInputColours
        '
        Me.ucrInputColours.AddQuotesIfUnrecognised = True
        Me.ucrInputColours.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColours.GetSetSelectedIndex = -1
        Me.ucrInputColours.IsReadOnly = False
        Me.ucrInputColours.Location = New System.Drawing.Point(228, 60)
        Me.ucrInputColours.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputColours.Name = "ucrInputColours"
        Me.ucrInputColours.Size = New System.Drawing.Size(117, 32)
        Me.ucrInputColours.TabIndex = 37
        '
        'ucrInputFill
        '
        Me.ucrInputFill.AddQuotesIfUnrecognised = True
        Me.ucrInputFill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFill.GetSetSelectedIndex = -1
        Me.ucrInputFill.IsReadOnly = False
        Me.ucrInputFill.Location = New System.Drawing.Point(228, 96)
        Me.ucrInputFill.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputFill.Name = "ucrInputFill"
        Me.ucrInputFill.Size = New System.Drawing.Size(117, 32)
        Me.ucrInputFill.TabIndex = 36
        '
        'grpPlots
        '
        Me.grpPlots.Controls.Add(Me.rdoMrlPlot)
        Me.grpPlots.Controls.Add(Me.rdoThreshRangePlot)
        Me.grpPlots.Controls.Add(Me.ucrPnlPlots)
        Me.grpPlots.Location = New System.Drawing.Point(14, 327)
        Me.grpPlots.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPlots.Size = New System.Drawing.Size(316, 98)
        Me.grpPlots.TabIndex = 15
        Me.grpPlots.TabStop = False
        Me.grpPlots.Text = "Plots"
        '
        'ucrPnlPlots
        '
        Me.ucrPnlPlots.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlPlots.Location = New System.Drawing.Point(18, 20)
        Me.ucrPnlPlots.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        Me.ucrPnlPlots.Size = New System.Drawing.Size(166, 66)
        Me.ucrPnlPlots.TabIndex = 41
        '
        'rdoThreshold
        '
        Me.rdoThreshold.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoThreshold.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreshold.FlatAppearance.BorderSize = 2
        Me.rdoThreshold.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreshold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoThreshold.Location = New System.Drawing.Point(254, 9)
        Me.rdoThreshold.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoThreshold.Name = "rdoThreshold"
        Me.rdoThreshold.Size = New System.Drawing.Size(130, 40)
        Me.rdoThreshold.TabIndex = 2
        Me.rdoThreshold.TabStop = True
        Me.rdoThreshold.Text = "Threshold "
        Me.rdoThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoThreshold.UseVisualStyleBackColor = True
        '
        'lblDeclusterColumns
        '
        Me.lblDeclusterColumns.AutoSize = True
        Me.lblDeclusterColumns.Location = New System.Drawing.Point(10, 111)
        Me.lblDeclusterColumns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDeclusterColumns.Name = "lblDeclusterColumns"
        Me.lblDeclusterColumns.Size = New System.Drawing.Size(124, 20)
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
        Me.grpDeclusteringOptions.Location = New System.Drawing.Point(16, 423)
        Me.grpDeclusteringOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDeclusteringOptions.Name = "grpDeclusteringOptions"
        Me.grpDeclusteringOptions.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDeclusteringOptions.Size = New System.Drawing.Size(314, 150)
        Me.grpDeclusteringOptions.TabIndex = 16
        Me.grpDeclusteringOptions.TabStop = False
        Me.grpDeclusteringOptions.Text = "Options"
        '
        'ucrChkRunLength
        '
        Me.ucrChkRunLength.AutoSize = True
        Me.ucrChkRunLength.Checked = False
        Me.ucrChkRunLength.Location = New System.Drawing.Point(10, 30)
        Me.ucrChkRunLength.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkRunLength.Name = "ucrChkRunLength"
        Me.ucrChkRunLength.Size = New System.Drawing.Size(176, 51)
        Me.ucrChkRunLength.TabIndex = 52
        '
        'ucrNudRunLength
        '
        Me.ucrNudRunLength.AutoSize = True
        Me.ucrNudRunLength.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRunLength.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRunLength.Location = New System.Drawing.Point(218, 30)
        Me.ucrNudRunLength.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudRunLength.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRunLength.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRunLength.Name = "ucrNudRunLength"
        Me.ucrNudRunLength.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudRunLength.TabIndex = 49
        Me.ucrNudRunLength.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkPrintSummary
        '
        Me.ucrChkPrintSummary.AutoSize = True
        Me.ucrChkPrintSummary.Checked = False
        Me.ucrChkPrintSummary.Location = New System.Drawing.Point(10, 70)
        Me.ucrChkPrintSummary.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkPrintSummary.Name = "ucrChkPrintSummary"
        Me.ucrChkPrintSummary.Size = New System.Drawing.Size(224, 51)
        Me.ucrChkPrintSummary.TabIndex = 45
        '
        'ucrNudDeclusterColumns
        '
        Me.ucrNudDeclusterColumns.AutoSize = True
        Me.ucrNudDeclusterColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDeclusterColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDeclusterColumns.Location = New System.Drawing.Point(218, 105)
        Me.ucrNudDeclusterColumns.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudDeclusterColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDeclusterColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDeclusterColumns.Name = "ucrNudDeclusterColumns"
        Me.ucrNudDeclusterColumns.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudDeclusterColumns.TabIndex = 50
        Me.ucrNudDeclusterColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkDeclustering
        '
        Me.ucrChkDeclustering.AutoSize = True
        Me.ucrChkDeclustering.Checked = False
        Me.ucrChkDeclustering.Location = New System.Drawing.Point(376, 423)
        Me.ucrChkDeclustering.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkDeclustering.Name = "ucrChkDeclustering"
        Me.ucrChkDeclustering.Size = New System.Drawing.Size(140, 34)
        Me.ucrChkDeclustering.TabIndex = 53
        '
        'ucrSaveDeclusteredPlot
        '
        Me.ucrSaveDeclusteredPlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDeclusteredPlot.Location = New System.Drawing.Point(12, 616)
        Me.ucrSaveDeclusteredPlot.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveDeclusteredPlot.Name = "ucrSaveDeclusteredPlot"
        Me.ucrSaveDeclusteredPlot.Size = New System.Drawing.Size(400, 36)
        Me.ucrSaveDeclusteredPlot.TabIndex = 19
        '
        'ucrSaveThresholdPlot
        '
        Me.ucrSaveThresholdPlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveThresholdPlot.Location = New System.Drawing.Point(12, 702)
        Me.ucrSaveThresholdPlot.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveThresholdPlot.Name = "ucrSaveThresholdPlot"
        Me.ucrSaveThresholdPlot.Size = New System.Drawing.Size(480, 36)
        Me.ucrSaveThresholdPlot.TabIndex = 19
        '
        'ucrSaveMrlPlot
        '
        Me.ucrSaveMrlPlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveMrlPlot.Location = New System.Drawing.Point(12, 702)
        Me.ucrSaveMrlPlot.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveMrlPlot.Name = "ucrSaveMrlPlot"
        Me.ucrSaveMrlPlot.Size = New System.Drawing.Size(554, 36)
        Me.ucrSaveMrlPlot.TabIndex = 15
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.AutoSize = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = True
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(172, 663)
        Me.ucrInputFilterPreview.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(363, 33)
        Me.ucrInputFilterPreview.TabIndex = 18
        '
        'ucrInputSave
        '
        Me.ucrInputSave.AddQuotesIfUnrecognised = True
        Me.ucrInputSave.AutoSize = True
        Me.ucrInputSave.IsMultiline = False
        Me.ucrInputSave.IsReadOnly = False
        Me.ucrInputSave.Location = New System.Drawing.Point(304, 704)
        Me.ucrInputSave.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputSave.Name = "ucrInputSave"
        Me.ucrInputSave.Size = New System.Drawing.Size(255, 32)
        Me.ucrInputSave.TabIndex = 20
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.AutoSize = True
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(376, 306)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 12
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(376, 242)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 10
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(376, 178)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 8
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(376, 116)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 6
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.AutoSize = True
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(376, 370)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(180, 30)
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
        Me.ucrSelectorClimaticExtremes.Location = New System.Drawing.Point(15, 54)
        Me.ucrSelectorClimaticExtremes.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimaticExtremes.Name = "ucrSelectorClimaticExtremes"
        Me.ucrSelectorClimaticExtremes.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorClimaticExtremes.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 769)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 21
        '
        'ucrPnlExtremesType
        '
        Me.ucrPnlExtremesType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlExtremesType.Location = New System.Drawing.Point(108, 3)
        Me.ucrPnlExtremesType.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrPnlExtremesType.Name = "ucrPnlExtremesType"
        Me.ucrPnlExtremesType.Size = New System.Drawing.Size(420, 56)
        Me.ucrPnlExtremesType.TabIndex = 0
        '
        'ucrChkVariableName
        '
        Me.ucrChkVariableName.AutoSize = True
        Me.ucrChkVariableName.Checked = False
        Me.ucrChkVariableName.Location = New System.Drawing.Point(444, 480)
        Me.ucrChkVariableName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkVariableName.Name = "ucrChkVariableName"
        Me.ucrChkVariableName.Size = New System.Drawing.Size(150, 34)
        Me.ucrChkVariableName.TabIndex = 54
        '
        'ucrSaveVariableName
        '
        Me.ucrSaveVariableName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveVariableName.Location = New System.Drawing.Point(12, 734)
        Me.ucrSaveVariableName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveVariableName.Name = "ucrSaveVariableName"
        Me.ucrSaveVariableName.Size = New System.Drawing.Size(436, 41)
        Me.ucrSaveVariableName.TabIndex = 55
        '
        'dlgExtremesClimatic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(624, 861)
        Me.Controls.Add(Me.ucrSaveVariableName)
        Me.Controls.Add(Me.ucrChkVariableName)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents ucrSaveVariableName As ucrSave
    Friend WithEvents ucrChkVariableName As ucrCheck
End Class
