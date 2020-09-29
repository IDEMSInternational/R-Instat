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
        Me.lblStations = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDayOfYear = New System.Windows.Forms.Label()
        Me.grpMinMaxOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkLastDate = New instat.ucrCheck()
        Me.ucrChkNDates = New instat.ucrCheck()
        Me.ucrInputThresholdValue = New instat.ucrInputTextBox()
        Me.ucrInputThresholdOperator = New instat.ucrInputComboBox()
        Me.lblValues = New System.Windows.Forms.Label()
        Me.ucrChkMissingValues = New instat.ucrCheck()
        Me.rdoMin = New System.Windows.Forms.RadioButton()
        Me.rdoMax = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMaxMin = New instat.UcrPanel()
        Me.ucrChkFirstDate = New instat.ucrCheck()
        Me.cmdDoyRange = New System.Windows.Forms.Button()
        Me.rdoMinMax = New System.Windows.Forms.RadioButton()
        Me.rdoPeaks = New System.Windows.Forms.RadioButton()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblNewColName = New System.Windows.Forms.Label()
        Me.lblNewDFName = New System.Windows.Forms.Label()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.ucrInputSave = New instat.ucrInputTextBox()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorClimaticExtremes = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlExtremesType = New instat.UcrPanel()
        Me.grpPeakOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkDecluster = New instat.ucrCheck()
        Me.ucrNudDeclusterThreshold = New instat.ucrNud()
        Me.grpPlotOptions = New System.Windows.Forms.GroupBox()
        Me.rdoCounts = New System.Windows.Forms.RadioButton()
        Me.rdoRunLength = New System.Windows.Forms.RadioButton()
        Me.ucrPnlCountsRunLength = New instat.UcrPanel()
        Me.ucrChkTcPlot = New instat.ucrCheck()
        Me.ucrChkMrlPlot = New instat.ucrCheck()
        Me.ucrInputTo = New instat.ucrInputTextBox()
        Me.ucrInputSteps = New instat.ucrInputTextBox()
        Me.ucrInputFrom = New instat.ucrInputTextBox()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblSteps = New System.Windows.Forms.Label()
        Me.grpMinMaxOptions.SuspendLayout()
        Me.grpPeakOptions.SuspendLayout()
        Me.grpPlotOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStations
        '
        Me.lblStations.AutoSize = True
        Me.lblStations.Location = New System.Drawing.Point(251, 78)
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Size = New System.Drawing.Size(43, 13)
        Me.lblStations.TabIndex = 4
        Me.lblStations.Text = "Station:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(251, 120)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(251, 162)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 8
        Me.lblYear.Text = "Year:"
        '
        'lblDayOfYear
        '
        Me.lblDayOfYear.AutoSize = True
        Me.lblDayOfYear.Location = New System.Drawing.Point(251, 205)
        Me.lblDayOfYear.Name = "lblDayOfYear"
        Me.lblDayOfYear.Size = New System.Drawing.Size(66, 13)
        Me.lblDayOfYear.TabIndex = 10
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
        Me.grpMinMaxOptions.Location = New System.Drawing.Point(10, 237)
        Me.grpMinMaxOptions.Name = "grpMinMaxOptions"
        Me.grpMinMaxOptions.Size = New System.Drawing.Size(210, 173)
        Me.grpMinMaxOptions.TabIndex = 14
        Me.grpMinMaxOptions.TabStop = False
        Me.grpMinMaxOptions.Text = "Options"
        '
        'ucrChkLastDate
        '
        Me.ucrChkLastDate.Checked = False
        Me.ucrChkLastDate.Location = New System.Drawing.Point(9, 121)
        Me.ucrChkLastDate.Name = "ucrChkLastDate"
        Me.ucrChkLastDate.Size = New System.Drawing.Size(195, 20)
        Me.ucrChkLastDate.TabIndex = 13
        '
        'ucrChkNDates
        '
        Me.ucrChkNDates.Checked = False
        Me.ucrChkNDates.Location = New System.Drawing.Point(10, 97)
        Me.ucrChkNDates.Name = "ucrChkNDates"
        Me.ucrChkNDates.Size = New System.Drawing.Size(194, 20)
        Me.ucrChkNDates.TabIndex = 12
        '
        'ucrInputThresholdValue
        '
        Me.ucrInputThresholdValue.AddQuotesIfUnrecognised = True
        Me.ucrInputThresholdValue.IsMultiline = False
        Me.ucrInputThresholdValue.IsReadOnly = False
        Me.ucrInputThresholdValue.Location = New System.Drawing.Point(113, 19)
        Me.ucrInputThresholdValue.Name = "ucrInputThresholdValue"
        Me.ucrInputThresholdValue.Size = New System.Drawing.Size(43, 21)
        Me.ucrInputThresholdValue.TabIndex = 8
        '
        'ucrInputThresholdOperator
        '
        Me.ucrInputThresholdOperator.AddQuotesIfUnrecognised = True
        Me.ucrInputThresholdOperator.GetSetSelectedIndex = -1
        Me.ucrInputThresholdOperator.IsReadOnly = False
        Me.ucrInputThresholdOperator.Location = New System.Drawing.Point(44, 18)
        Me.ucrInputThresholdOperator.Name = "ucrInputThresholdOperator"
        Me.ucrInputThresholdOperator.Size = New System.Drawing.Size(68, 21)
        Me.ucrInputThresholdOperator.TabIndex = 6
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
        'ucrChkMissingValues
        '
        Me.ucrChkMissingValues.Checked = False
        Me.ucrChkMissingValues.Location = New System.Drawing.Point(10, 147)
        Me.ucrChkMissingValues.Name = "ucrChkMissingValues"
        Me.ucrChkMissingValues.Size = New System.Drawing.Size(194, 20)
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
        Me.rdoMax.Location = New System.Drawing.Point(10, 48)
        Me.rdoMax.Name = "rdoMax"
        Me.rdoMax.Size = New System.Drawing.Size(104, 17)
        Me.rdoMax.TabIndex = 9
        Me.rdoMax.TabStop = True
        Me.rdoMax.Text = "Maximum Values"
        Me.rdoMax.UseVisualStyleBackColor = True
        '
        'ucrPnlMaxMin
        '
        Me.ucrPnlMaxMin.Location = New System.Drawing.Point(6, 18)
        Me.ucrPnlMaxMin.Name = "ucrPnlMaxMin"
        Me.ucrPnlMaxMin.Size = New System.Drawing.Size(131, 49)
        Me.ucrPnlMaxMin.TabIndex = 7
        '
        'ucrChkFirstDate
        '
        Me.ucrChkFirstDate.Checked = False
        Me.ucrChkFirstDate.Location = New System.Drawing.Point(10, 73)
        Me.ucrChkFirstDate.Name = "ucrChkFirstDate"
        Me.ucrChkFirstDate.Size = New System.Drawing.Size(194, 20)
        Me.ucrChkFirstDate.TabIndex = 10
        '
        'cmdDoyRange
        '
        Me.cmdDoyRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoyRange.Location = New System.Drawing.Point(13, 428)
        Me.cmdDoyRange.Name = "cmdDoyRange"
        Me.cmdDoyRange.Size = New System.Drawing.Size(105, 26)
        Me.cmdDoyRange.TabIndex = 26
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
        Me.rdoMinMax.Location = New System.Drawing.Point(121, 12)
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
        Me.rdoPeaks.Location = New System.Drawing.Point(207, 12)
        Me.rdoPeaks.Name = "rdoPeaks"
        Me.rdoPeaks.Size = New System.Drawing.Size(87, 27)
        Me.rdoPeaks.TabIndex = 2
        Me.rdoPeaks.TabStop = True
        Me.rdoPeaks.Text = "Peaks"
        Me.rdoPeaks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPeaks.UseVisualStyleBackColor = True
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(251, 248)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 12
        Me.lblElement.Text = "Element:"
        '
        'lblNewColName
        '
        Me.lblNewColName.Location = New System.Drawing.Point(16, 468)
        Me.lblNewColName.Name = "lblNewColName"
        Me.lblNewColName.Size = New System.Drawing.Size(119, 13)
        Me.lblNewColName.TabIndex = 17
        Me.lblNewColName.Text = "New Column Name:"
        '
        'lblNewDFName
        '
        Me.lblNewDFName.AutoSize = True
        Me.lblNewDFName.Location = New System.Drawing.Point(18, 468)
        Me.lblNewDFName.Name = "lblNewDFName"
        Me.lblNewDFName.Size = New System.Drawing.Size(121, 13)
        Me.lblNewDFName.TabIndex = 1
        Me.lblNewDFName.Text = "New Data Frame Name:"
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = True
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(130, 431)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(242, 22)
        Me.ucrInputFilterPreview.TabIndex = 16
        '
        'ucrInputSave
        '
        Me.ucrInputSave.AddQuotesIfUnrecognised = True
        Me.ucrInputSave.IsMultiline = False
        Me.ucrInputSave.IsReadOnly = False
        Me.ucrInputSave.Location = New System.Drawing.Point(140, 467)
        Me.ucrInputSave.Name = "ucrInputSave"
        Me.ucrInputSave.Size = New System.Drawing.Size(170, 21)
        Me.ucrInputSave.TabIndex = 18
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(251, 263)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 13
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(251, 220)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 11
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(251, 177)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 9
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(251, 135)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 7
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(251, 93)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 5
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorClimaticExtremes
        '
        Me.ucrSelectorClimaticExtremes.bDropUnusedFilterLevels = False
        Me.ucrSelectorClimaticExtremes.bShowHiddenColumns = False
        Me.ucrSelectorClimaticExtremes.bUseCurrentFilter = True
        Me.ucrSelectorClimaticExtremes.Location = New System.Drawing.Point(10, 44)
        Me.ucrSelectorClimaticExtremes.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimaticExtremes.Name = "ucrSelectorClimaticExtremes"
        Me.ucrSelectorClimaticExtremes.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorClimaticExtremes.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 503)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(398, 52)
        Me.ucrBase.TabIndex = 19
        '
        'ucrPnlExtremesType
        '
        Me.ucrPnlExtremesType.Location = New System.Drawing.Point(99, 6)
        Me.ucrPnlExtremesType.Name = "ucrPnlExtremesType"
        Me.ucrPnlExtremesType.Size = New System.Drawing.Size(218, 37)
        Me.ucrPnlExtremesType.TabIndex = 0
        '
        'grpPeakOptions
        '
        Me.grpPeakOptions.Controls.Add(Me.ucrNudDeclusterThreshold)
        Me.grpPeakOptions.Controls.Add(Me.ucrChkDecluster)
        Me.grpPeakOptions.Controls.Add(Me.ucrInputThresholdValue)
        Me.grpPeakOptions.Controls.Add(Me.lblValues)
        Me.grpPeakOptions.Controls.Add(Me.ucrInputThresholdOperator)
        Me.grpPeakOptions.Location = New System.Drawing.Point(9, 237)
        Me.grpPeakOptions.Name = "grpPeakOptions"
        Me.grpPeakOptions.Size = New System.Drawing.Size(210, 77)
        Me.grpPeakOptions.TabIndex = 27
        Me.grpPeakOptions.TabStop = False
        Me.grpPeakOptions.Text = "Options"
        '
        'ucrChkDecluster
        '
        Me.ucrChkDecluster.Checked = False
        Me.ucrChkDecluster.Location = New System.Drawing.Point(6, 45)
        Me.ucrChkDecluster.Name = "ucrChkDecluster"
        Me.ucrChkDecluster.Size = New System.Drawing.Size(91, 20)
        Me.ucrChkDecluster.TabIndex = 28
        '
        'ucrNudDeclusterThreshold
        '
        Me.ucrNudDeclusterThreshold.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDeclusterThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDeclusterThreshold.Location = New System.Drawing.Point(113, 45)
        Me.ucrNudDeclusterThreshold.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDeclusterThreshold.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDeclusterThreshold.Name = "ucrNudDeclusterThreshold"
        Me.ucrNudDeclusterThreshold.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDeclusterThreshold.TabIndex = 29
        Me.ucrNudDeclusterThreshold.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpPlotOptions
        '
        Me.grpPlotOptions.Controls.Add(Me.lblSteps)
        Me.grpPlotOptions.Controls.Add(Me.lblTo)
        Me.grpPlotOptions.Controls.Add(Me.lblFrom)
        Me.grpPlotOptions.Controls.Add(Me.ucrInputFrom)
        Me.grpPlotOptions.Controls.Add(Me.ucrInputSteps)
        Me.grpPlotOptions.Controls.Add(Me.ucrInputTo)
        Me.grpPlotOptions.Controls.Add(Me.ucrChkMrlPlot)
        Me.grpPlotOptions.Controls.Add(Me.ucrChkTcPlot)
        Me.grpPlotOptions.Controls.Add(Me.rdoRunLength)
        Me.grpPlotOptions.Controls.Add(Me.rdoCounts)
        Me.grpPlotOptions.Controls.Add(Me.ucrPnlCountsRunLength)
        Me.grpPlotOptions.Location = New System.Drawing.Point(9, 318)
        Me.grpPlotOptions.Name = "grpPlotOptions"
        Me.grpPlotOptions.Size = New System.Drawing.Size(363, 88)
        Me.grpPlotOptions.TabIndex = 28
        Me.grpPlotOptions.TabStop = False
        Me.grpPlotOptions.Text = "Plot Options"
        '
        'rdoCounts
        '
        Me.rdoCounts.AutoSize = True
        Me.rdoCounts.Location = New System.Drawing.Point(10, 19)
        Me.rdoCounts.Name = "rdoCounts"
        Me.rdoCounts.Size = New System.Drawing.Size(58, 17)
        Me.rdoCounts.TabIndex = 0
        Me.rdoCounts.TabStop = True
        Me.rdoCounts.Text = "Counts"
        Me.rdoCounts.UseVisualStyleBackColor = True
        '
        'rdoRunLength
        '
        Me.rdoRunLength.AutoSize = True
        Me.rdoRunLength.Location = New System.Drawing.Point(10, 51)
        Me.rdoRunLength.Name = "rdoRunLength"
        Me.rdoRunLength.Size = New System.Drawing.Size(81, 17)
        Me.rdoRunLength.TabIndex = 1
        Me.rdoRunLength.TabStop = True
        Me.rdoRunLength.Text = "Run Length"
        Me.rdoRunLength.UseVisualStyleBackColor = True
        '
        'ucrPnlCountsRunLength
        '
        Me.ucrPnlCountsRunLength.Location = New System.Drawing.Point(8, 17)
        Me.ucrPnlCountsRunLength.Name = "ucrPnlCountsRunLength"
        Me.ucrPnlCountsRunLength.Size = New System.Drawing.Size(86, 56)
        Me.ucrPnlCountsRunLength.TabIndex = 2
        '
        'ucrChkTcPlot
        '
        Me.ucrChkTcPlot.Checked = False
        Me.ucrChkTcPlot.Location = New System.Drawing.Point(207, 18)
        Me.ucrChkTcPlot.Name = "ucrChkTcPlot"
        Me.ucrChkTcPlot.Size = New System.Drawing.Size(91, 20)
        Me.ucrChkTcPlot.TabIndex = 29
        '
        'ucrChkMrlPlot
        '
        Me.ucrChkMrlPlot.Checked = False
        Me.ucrChkMrlPlot.Location = New System.Drawing.Point(100, 18)
        Me.ucrChkMrlPlot.Name = "ucrChkMrlPlot"
        Me.ucrChkMrlPlot.Size = New System.Drawing.Size(91, 20)
        Me.ucrChkMrlPlot.TabIndex = 30
        '
        'ucrInputTo
        '
        Me.ucrInputTo.AddQuotesIfUnrecognised = True
        Me.ucrInputTo.IsMultiline = False
        Me.ucrInputTo.IsReadOnly = False
        Me.ucrInputTo.Location = New System.Drawing.Point(207, 51)
        Me.ucrInputTo.Name = "ucrInputTo"
        Me.ucrInputTo.Size = New System.Drawing.Size(43, 21)
        Me.ucrInputTo.TabIndex = 31
        '
        'ucrInputSteps
        '
        Me.ucrInputSteps.AddQuotesIfUnrecognised = True
        Me.ucrInputSteps.IsMultiline = False
        Me.ucrInputSteps.IsReadOnly = False
        Me.ucrInputSteps.Location = New System.Drawing.Point(300, 51)
        Me.ucrInputSteps.Name = "ucrInputSteps"
        Me.ucrInputSteps.Size = New System.Drawing.Size(43, 21)
        Me.ucrInputSteps.TabIndex = 32
        '
        'ucrInputFrom
        '
        Me.ucrInputFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputFrom.IsMultiline = False
        Me.ucrInputFrom.IsReadOnly = False
        Me.ucrInputFrom.Location = New System.Drawing.Point(133, 51)
        Me.ucrInputFrom.Name = "ucrInputFrom"
        Me.ucrInputFrom.Size = New System.Drawing.Size(43, 21)
        Me.ucrInputFrom.TabIndex = 33
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(97, 53)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 34
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(181, 54)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 35
        Me.lblTo.Text = "To:"
        '
        'lblSteps
        '
        Me.lblSteps.AutoSize = True
        Me.lblSteps.Location = New System.Drawing.Point(260, 55)
        Me.lblSteps.Name = "lblSteps"
        Me.lblSteps.Size = New System.Drawing.Size(37, 13)
        Me.lblSteps.TabIndex = 36
        Me.lblSteps.Text = "Steps:"
        '
        'dlgExtremesClimatic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 556)
        Me.Controls.Add(Me.grpPlotOptions)
        Me.Controls.Add(Me.grpPeakOptions)
        Me.Controls.Add(Me.cmdDoyRange)
        Me.Controls.Add(Me.ucrInputFilterPreview)
        Me.Controls.Add(Me.lblNewColName)
        Me.Controls.Add(Me.ucrInputSave)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.rdoPeaks)
        Me.Controls.Add(Me.rdoMinMax)
        Me.Controls.Add(Me.grpMinMaxOptions)
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
        Me.grpPlotOptions.ResumeLayout(False)
        Me.grpPlotOptions.PerformLayout()
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
    Friend WithEvents ucrNudDeclusterThreshold As ucrNud
    Friend WithEvents ucrChkDecluster As ucrCheck
    Friend WithEvents grpPlotOptions As GroupBox
    Friend WithEvents rdoRunLength As RadioButton
    Friend WithEvents rdoCounts As RadioButton
    Friend WithEvents ucrPnlCountsRunLength As UcrPanel
    Friend WithEvents ucrChkMrlPlot As ucrCheck
    Friend WithEvents ucrChkTcPlot As ucrCheck
    Friend WithEvents lblSteps As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrInputFrom As ucrInputTextBox
    Friend WithEvents ucrInputSteps As ucrInputTextBox
    Friend WithEvents ucrInputTo As ucrInputTextBox
End Class
