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
Partial Class dlgDisplayDailyData
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
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDayOfTheYear = New System.Windows.Forms.Label()
        Me.lblYaxisUpper = New System.Windows.Forms.Label()
        Me.grpGraph = New System.Windows.Forms.GroupBox()
        Me.ucrInputRugColour = New instat.ucrInputComboBox()
        Me.lblRugColour = New System.Windows.Forms.Label()
        Me.ucrInputBarColour = New instat.ucrInputComboBox()
        Me.lblBarColour = New System.Windows.Forms.Label()
        Me.ucrNudUpperYaxis = New instat.ucrNud()
        Me.lblElements = New System.Windows.Forms.Label()
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.ucrChkSumMissing = New instat.ucrCheck()
        Me.ucrChkMax = New instat.ucrCheck()
        Me.ucrChkIQR = New instat.ucrCheck()
        Me.ucrChkMedian = New instat.ucrCheck()
        Me.ucrChkSum = New instat.ucrCheck()
        Me.ucrChkMin = New instat.ucrCheck()
        Me.ucrChkMean = New instat.ucrCheck()
        Me.grpFacet = New System.Windows.Forms.GroupBox()
        Me.lblScales = New System.Windows.Forms.Label()
        Me.ucrInputScale = New instat.ucrInputComboBox()
        Me.lblFacetby = New System.Windows.Forms.Label()
        Me.ucrNudNumberOfColumns = New instat.ucrNud()
        Me.ucrInputFacetBy = New instat.ucrInputComboBox()
        Me.ucrChkNumberOfColumns = New instat.ucrCheck()
        Me.rdoGraphByYear = New System.Windows.Forms.RadioButton()
        Me.lblGRugColour = New System.Windows.Forms.Label()
        Me.ucrInputGraphRugColur = New instat.ucrInputComboBox()
        Me.ucrReceiverMultipleElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrInputComboMissing = New instat.ucrInputComboBox()
        Me.ucrInputComboTrace = New instat.ucrInputComboBox()
        Me.ucrChkMissing = New instat.ucrCheck()
        Me.ucrChkTrace = New instat.ucrCheck()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayOfYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStations = New instat.ucrReceiverSingle()
        Me.ucrPnlFrequencyDisplay = New instat.UcrPanel()
        Me.ucrSelectorDisplayDailyClimaticData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverSingleElements = New instat.ucrReceiverSingle()
        Me.ucrChkZero = New instat.ucrCheck()
        Me.ucrInputComboZero = New instat.ucrInputComboBox()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.cmdDispalyDailyOptions = New System.Windows.Forms.Button()
        Me.grpGraph.SuspendLayout()
        Me.grpSummary.SuspendLayout()
        Me.grpFacet.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoTable
        '
        Me.rdoTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTable.Location = New System.Drawing.Point(268, 12)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(124, 29)
        Me.rdoTable.TabIndex = 1
        Me.rdoTable.Text = "Table"
        Me.rdoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'rdoGraph
        '
        Me.rdoGraph.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoGraph.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGraph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGraph.Location = New System.Drawing.Point(24, 12)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(124, 29)
        Me.rdoGraph.TabIndex = 2
        Me.rdoGraph.Text = "Graph"
        Me.rdoGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(283, 64)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 4
        Me.lblStation.Text = "Station:"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement.Location = New System.Drawing.Point(283, 237)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 12
        Me.lblElement.Text = "Element:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(283, 109)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(283, 193)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 10
        Me.lblYear.Text = "Year:"
        '
        'lblDayOfTheYear
        '
        Me.lblDayOfTheYear.AutoSize = True
        Me.lblDayOfTheYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDayOfTheYear.Location = New System.Drawing.Point(283, 150)
        Me.lblDayOfTheYear.Name = "lblDayOfTheYear"
        Me.lblDayOfTheYear.Size = New System.Drawing.Size(29, 13)
        Me.lblDayOfTheYear.TabIndex = 8
        Me.lblDayOfTheYear.Text = "Doy:"
        '
        'lblYaxisUpper
        '
        Me.lblYaxisUpper.AutoSize = True
        Me.lblYaxisUpper.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYaxisUpper.Location = New System.Drawing.Point(9, 16)
        Me.lblYaxisUpper.Name = "lblYaxisUpper"
        Me.lblYaxisUpper.Size = New System.Drawing.Size(70, 13)
        Me.lblYaxisUpper.TabIndex = 0
        Me.lblYaxisUpper.Text = "Y-axis Upper:"
        '
        'grpGraph
        '
        Me.grpGraph.Controls.Add(Me.ucrInputRugColour)
        Me.grpGraph.Controls.Add(Me.lblRugColour)
        Me.grpGraph.Controls.Add(Me.ucrInputBarColour)
        Me.grpGraph.Controls.Add(Me.lblBarColour)
        Me.grpGraph.Controls.Add(Me.ucrNudUpperYaxis)
        Me.grpGraph.Controls.Add(Me.lblYaxisUpper)
        Me.grpGraph.Location = New System.Drawing.Point(9, 256)
        Me.grpGraph.Name = "grpGraph"
        Me.grpGraph.Size = New System.Drawing.Size(234, 118)
        Me.grpGraph.TabIndex = 21
        Me.grpGraph.TabStop = False
        Me.grpGraph.Text = "Graph"
        '
        'ucrInputRugColour
        '
        Me.ucrInputRugColour.AddQuotesIfUnrecognised = True
        Me.ucrInputRugColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputRugColour.GetSetSelectedIndex = -1
        Me.ucrInputRugColour.IsReadOnly = False
        Me.ucrInputRugColour.Location = New System.Drawing.Point(126, 70)
        Me.ucrInputRugColour.Name = "ucrInputRugColour"
        Me.ucrInputRugColour.Size = New System.Drawing.Size(96, 21)
        Me.ucrInputRugColour.TabIndex = 6
        '
        'lblRugColour
        '
        Me.lblRugColour.AutoSize = True
        Me.lblRugColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRugColour.Location = New System.Drawing.Point(9, 75)
        Me.lblRugColour.Name = "lblRugColour"
        Me.lblRugColour.Size = New System.Drawing.Size(63, 13)
        Me.lblRugColour.TabIndex = 4
        Me.lblRugColour.Text = "Rug Colour:"
        '
        'ucrInputBarColour
        '
        Me.ucrInputBarColour.AddQuotesIfUnrecognised = True
        Me.ucrInputBarColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBarColour.GetSetSelectedIndex = -1
        Me.ucrInputBarColour.IsReadOnly = False
        Me.ucrInputBarColour.Location = New System.Drawing.Point(126, 43)
        Me.ucrInputBarColour.Name = "ucrInputBarColour"
        Me.ucrInputBarColour.Size = New System.Drawing.Size(96, 21)
        Me.ucrInputBarColour.TabIndex = 2
        '
        'lblBarColour
        '
        Me.lblBarColour.AutoSize = True
        Me.lblBarColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBarColour.Location = New System.Drawing.Point(9, 48)
        Me.lblBarColour.Name = "lblBarColour"
        Me.lblBarColour.Size = New System.Drawing.Size(59, 13)
        Me.lblBarColour.TabIndex = 2
        Me.lblBarColour.Text = "Bar Colour:"
        '
        'ucrNudUpperYaxis
        '
        Me.ucrNudUpperYaxis.AutoSize = True
        Me.ucrNudUpperYaxis.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperYaxis.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudUpperYaxis.Location = New System.Drawing.Point(126, 13)
        Me.ucrNudUpperYaxis.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrNudUpperYaxis.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudUpperYaxis.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperYaxis.Name = "ucrNudUpperYaxis"
        Me.ucrNudUpperYaxis.Size = New System.Drawing.Size(50, 23)
        Me.ucrNudUpperYaxis.TabIndex = 3
        Me.ucrNudUpperYaxis.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblElements
        '
        Me.lblElements.AutoSize = True
        Me.lblElements.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElements.Location = New System.Drawing.Point(283, 237)
        Me.lblElements.Name = "lblElements"
        Me.lblElements.Size = New System.Drawing.Size(59, 13)
        Me.lblElements.TabIndex = 12
        Me.lblElements.Text = "Element(s):"
        '
        'grpSummary
        '
        Me.grpSummary.Controls.Add(Me.ucrChkSumMissing)
        Me.grpSummary.Controls.Add(Me.ucrChkMax)
        Me.grpSummary.Controls.Add(Me.ucrChkIQR)
        Me.grpSummary.Controls.Add(Me.ucrChkMedian)
        Me.grpSummary.Controls.Add(Me.ucrChkSum)
        Me.grpSummary.Controls.Add(Me.ucrChkMin)
        Me.grpSummary.Controls.Add(Me.ucrChkMean)
        Me.grpSummary.Location = New System.Drawing.Point(9, 256)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Size = New System.Drawing.Size(235, 118)
        Me.grpSummary.TabIndex = 14
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Summary"
        '
        'ucrChkSumMissing
        '
        Me.ucrChkSumMissing.AutoSize = True
        Me.ucrChkSumMissing.Checked = False
        Me.ucrChkSumMissing.Location = New System.Drawing.Point(16, 97)
        Me.ucrChkSumMissing.Name = "ucrChkSumMissing"
        Me.ucrChkSumMissing.Size = New System.Drawing.Size(189, 23)
        Me.ucrChkSumMissing.TabIndex = 32
        '
        'ucrChkMax
        '
        Me.ucrChkMax.AutoSize = True
        Me.ucrChkMax.Checked = False
        Me.ucrChkMax.Location = New System.Drawing.Point(16, 45)
        Me.ucrChkMax.Name = "ucrChkMax"
        Me.ucrChkMax.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkMax.TabIndex = 26
        '
        'ucrChkIQR
        '
        Me.ucrChkIQR.AutoSize = True
        Me.ucrChkIQR.Checked = False
        Me.ucrChkIQR.Location = New System.Drawing.Point(127, 71)
        Me.ucrChkIQR.Name = "ucrChkIQR"
        Me.ucrChkIQR.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkIQR.TabIndex = 30
        '
        'ucrChkMedian
        '
        Me.ucrChkMedian.AutoSize = True
        Me.ucrChkMedian.Checked = False
        Me.ucrChkMedian.Location = New System.Drawing.Point(16, 70)
        Me.ucrChkMedian.Name = "ucrChkMedian"
        Me.ucrChkMedian.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkMedian.TabIndex = 31
        '
        'ucrChkSum
        '
        Me.ucrChkSum.AutoSize = True
        Me.ucrChkSum.Checked = False
        Me.ucrChkSum.Location = New System.Drawing.Point(16, 19)
        Me.ucrChkSum.Name = "ucrChkSum"
        Me.ucrChkSum.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSum.TabIndex = 27
        '
        'ucrChkMin
        '
        Me.ucrChkMin.AutoSize = True
        Me.ucrChkMin.Checked = False
        Me.ucrChkMin.Location = New System.Drawing.Point(127, 19)
        Me.ucrChkMin.Name = "ucrChkMin"
        Me.ucrChkMin.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkMin.TabIndex = 29
        '
        'ucrChkMean
        '
        Me.ucrChkMean.AutoSize = True
        Me.ucrChkMean.Checked = False
        Me.ucrChkMean.Location = New System.Drawing.Point(127, 45)
        Me.ucrChkMean.Name = "ucrChkMean"
        Me.ucrChkMean.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkMean.TabIndex = 28
        '
        'grpFacet
        '
        Me.grpFacet.Controls.Add(Me.lblScales)
        Me.grpFacet.Controls.Add(Me.ucrInputScale)
        Me.grpFacet.Controls.Add(Me.lblFacetby)
        Me.grpFacet.Controls.Add(Me.ucrNudNumberOfColumns)
        Me.grpFacet.Controls.Add(Me.ucrInputFacetBy)
        Me.grpFacet.Controls.Add(Me.ucrChkNumberOfColumns)
        Me.grpFacet.Location = New System.Drawing.Point(10, 256)
        Me.grpFacet.Name = "grpFacet"
        Me.grpFacet.Size = New System.Drawing.Size(203, 94)
        Me.grpFacet.TabIndex = 34
        Me.grpFacet.TabStop = False
        Me.grpFacet.Text = "Facet"
        '
        'lblScales
        '
        Me.lblScales.AutoSize = True
        Me.lblScales.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblScales.Location = New System.Drawing.Point(6, 16)
        Me.lblScales.Name = "lblScales"
        Me.lblScales.Size = New System.Drawing.Size(37, 13)
        Me.lblScales.TabIndex = 36
        Me.lblScales.Text = "Scale:"
        '
        'ucrInputScale
        '
        Me.ucrInputScale.AddQuotesIfUnrecognised = True
        Me.ucrInputScale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputScale.GetSetSelectedIndex = -1
        Me.ucrInputScale.IsReadOnly = False
        Me.ucrInputScale.Location = New System.Drawing.Point(62, 12)
        Me.ucrInputScale.Name = "ucrInputScale"
        Me.ucrInputScale.Size = New System.Drawing.Size(117, 21)
        Me.ucrInputScale.TabIndex = 35
        '
        'lblFacetby
        '
        Me.lblFacetby.AutoSize = True
        Me.lblFacetby.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetby.Location = New System.Drawing.Point(5, 39)
        Me.lblFacetby.Name = "lblFacetby"
        Me.lblFacetby.Size = New System.Drawing.Size(22, 13)
        Me.lblFacetby.TabIndex = 32
        Me.lblFacetby.Text = "By:"
        '
        'ucrNudNumberOfColumns
        '
        Me.ucrNudNumberOfColumns.AutoSize = True
        Me.ucrNudNumberOfColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Location = New System.Drawing.Point(129, 63)
        Me.ucrNudNumberOfColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Name = "ucrNudNumberOfColumns"
        Me.ucrNudNumberOfColumns.Size = New System.Drawing.Size(50, 23)
        Me.ucrNudNumberOfColumns.TabIndex = 33
        Me.ucrNudNumberOfColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputFacetBy
        '
        Me.ucrInputFacetBy.AddQuotesIfUnrecognised = True
        Me.ucrInputFacetBy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFacetBy.GetSetSelectedIndex = -1
        Me.ucrInputFacetBy.IsReadOnly = False
        Me.ucrInputFacetBy.Location = New System.Drawing.Point(62, 37)
        Me.ucrInputFacetBy.Name = "ucrInputFacetBy"
        Me.ucrInputFacetBy.Size = New System.Drawing.Size(117, 21)
        Me.ucrInputFacetBy.TabIndex = 31
        '
        'ucrChkNumberOfColumns
        '
        Me.ucrChkNumberOfColumns.AutoSize = True
        Me.ucrChkNumberOfColumns.Checked = False
        Me.ucrChkNumberOfColumns.Location = New System.Drawing.Point(7, 64)
        Me.ucrChkNumberOfColumns.Name = "ucrChkNumberOfColumns"
        Me.ucrChkNumberOfColumns.Size = New System.Drawing.Size(175, 23)
        Me.ucrChkNumberOfColumns.TabIndex = 33
        '
        'rdoGraphByYear
        '
        Me.rdoGraphByYear.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGraphByYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoGraphByYear.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGraphByYear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraphByYear.FlatAppearance.BorderSize = 2
        Me.rdoGraphByYear.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraphByYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGraphByYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoGraphByYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGraphByYear.Location = New System.Drawing.Point(146, 12)
        Me.rdoGraphByYear.Name = "rdoGraphByYear"
        Me.rdoGraphByYear.Size = New System.Drawing.Size(124, 29)
        Me.rdoGraphByYear.TabIndex = 23
        Me.rdoGraphByYear.Text = "Graph by Year"
        Me.rdoGraphByYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGraphByYear.UseVisualStyleBackColor = True
        '
        'lblGRugColour
        '
        Me.lblGRugColour.AutoSize = True
        Me.lblGRugColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGRugColour.Location = New System.Drawing.Point(17, 353)
        Me.lblGRugColour.Name = "lblGRugColour"
        Me.lblGRugColour.Size = New System.Drawing.Size(78, 13)
        Me.lblGRugColour.TabIndex = 36
        Me.lblGRugColour.Text = "Missing Colour:"
        '
        'ucrInputGraphRugColur
        '
        Me.ucrInputGraphRugColur.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphRugColur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputGraphRugColur.GetSetSelectedIndex = -1
        Me.ucrInputGraphRugColur.IsReadOnly = False
        Me.ucrInputGraphRugColur.Location = New System.Drawing.Point(135, 350)
        Me.ucrInputGraphRugColur.Name = "ucrInputGraphRugColur"
        Me.ucrInputGraphRugColur.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputGraphRugColur.TabIndex = 35
        '
        'ucrReceiverMultipleElements
        '
        Me.ucrReceiverMultipleElements.AutoSize = True
        Me.ucrReceiverMultipleElements.frmParent = Me
        Me.ucrReceiverMultipleElements.Location = New System.Drawing.Point(279, 252)
        Me.ucrReceiverMultipleElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleElements.Name = "ucrReceiverMultipleElements"
        Me.ucrReceiverMultipleElements.Selector = Nothing
        Me.ucrReceiverMultipleElements.Size = New System.Drawing.Size(126, 100)
        Me.ucrReceiverMultipleElements.strNcFilePath = ""
        Me.ucrReceiverMultipleElements.TabIndex = 25
        Me.ucrReceiverMultipleElements.ucrSelector = Nothing
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.AutoSize = True
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(280, 253)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(122, 20)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 1
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrInputComboMissing
        '
        Me.ucrInputComboMissing.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMissing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboMissing.GetSetSelectedIndex = -1
        Me.ucrInputComboMissing.IsReadOnly = False
        Me.ucrInputComboMissing.Location = New System.Drawing.Point(155, 380)
        Me.ucrInputComboMissing.Name = "ucrInputComboMissing"
        Me.ucrInputComboMissing.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputComboMissing.TabIndex = 16
        '
        'ucrInputComboTrace
        '
        Me.ucrInputComboTrace.AddQuotesIfUnrecognised = True
        Me.ucrInputComboTrace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboTrace.GetSetSelectedIndex = -1
        Me.ucrInputComboTrace.IsReadOnly = False
        Me.ucrInputComboTrace.Location = New System.Drawing.Point(155, 427)
        Me.ucrInputComboTrace.Name = "ucrInputComboTrace"
        Me.ucrInputComboTrace.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputComboTrace.TabIndex = 18
        '
        'ucrChkMissing
        '
        Me.ucrChkMissing.AutoSize = True
        Me.ucrChkMissing.Checked = False
        Me.ucrChkMissing.Location = New System.Drawing.Point(10, 380)
        Me.ucrChkMissing.Name = "ucrChkMissing"
        Me.ucrChkMissing.Size = New System.Drawing.Size(141, 23)
        Me.ucrChkMissing.TabIndex = 15
        '
        'ucrChkTrace
        '
        Me.ucrChkTrace.AutoSize = True
        Me.ucrChkTrace.Checked = False
        Me.ucrChkTrace.Location = New System.Drawing.Point(10, 428)
        Me.ucrChkTrace.Name = "ucrChkTrace"
        Me.ucrChkTrace.Size = New System.Drawing.Size(141, 23)
        Me.ucrChkTrace.TabIndex = 17
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(280, 209)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(122, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 11
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDayOfYear
        '
        Me.ucrReceiverDayOfYear.AutoSize = True
        Me.ucrReceiverDayOfYear.frmParent = Me
        Me.ucrReceiverDayOfYear.Location = New System.Drawing.Point(280, 166)
        Me.ucrReceiverDayOfYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDayOfYear.Name = "ucrReceiverDayOfYear"
        Me.ucrReceiverDayOfYear.Selector = Nothing
        Me.ucrReceiverDayOfYear.Size = New System.Drawing.Size(122, 20)
        Me.ucrReceiverDayOfYear.strNcFilePath = ""
        Me.ucrReceiverDayOfYear.TabIndex = 9
        Me.ucrReceiverDayOfYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(280, 124)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(122, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 7
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStations
        '
        Me.ucrReceiverStations.AutoSize = True
        Me.ucrReceiverStations.frmParent = Me
        Me.ucrReceiverStations.Location = New System.Drawing.Point(280, 80)
        Me.ucrReceiverStations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStations.Name = "ucrReceiverStations"
        Me.ucrReceiverStations.Selector = Nothing
        Me.ucrReceiverStations.Size = New System.Drawing.Size(122, 20)
        Me.ucrReceiverStations.strNcFilePath = ""
        Me.ucrReceiverStations.TabIndex = 5
        Me.ucrReceiverStations.ucrSelector = Nothing
        '
        'ucrPnlFrequencyDisplay
        '
        Me.ucrPnlFrequencyDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlFrequencyDisplay.Location = New System.Drawing.Point(23, 12)
        Me.ucrPnlFrequencyDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrPnlFrequencyDisplay.Name = "ucrPnlFrequencyDisplay"
        Me.ucrPnlFrequencyDisplay.Size = New System.Drawing.Size(370, 29)
        Me.ucrPnlFrequencyDisplay.TabIndex = 0
        '
        'ucrSelectorDisplayDailyClimaticData
        '
        Me.ucrSelectorDisplayDailyClimaticData.AutoSize = True
        Me.ucrSelectorDisplayDailyClimaticData.bDropUnusedFilterLevels = False
        Me.ucrSelectorDisplayDailyClimaticData.bShowHiddenColumns = False
        Me.ucrSelectorDisplayDailyClimaticData.bUseCurrentFilter = True
        Me.ucrSelectorDisplayDailyClimaticData.Location = New System.Drawing.Point(10, 43)
        Me.ucrSelectorDisplayDailyClimaticData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDisplayDailyClimaticData.Name = "ucrSelectorDisplayDailyClimaticData"
        Me.ucrSelectorDisplayDailyClimaticData.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorDisplayDailyClimaticData.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 452)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 22
        '
        'ucrReceiverSingleElements
        '
        Me.ucrReceiverSingleElements.AutoSize = True
        Me.ucrReceiverSingleElements.frmParent = Me
        Me.ucrReceiverSingleElements.Location = New System.Drawing.Point(280, 253)
        Me.ucrReceiverSingleElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleElements.Name = "ucrReceiverSingleElements"
        Me.ucrReceiverSingleElements.Selector = Nothing
        Me.ucrReceiverSingleElements.Size = New System.Drawing.Size(122, 20)
        Me.ucrReceiverSingleElements.strNcFilePath = ""
        Me.ucrReceiverSingleElements.TabIndex = 24
        Me.ucrReceiverSingleElements.ucrSelector = Nothing
        '
        'ucrChkZero
        '
        Me.ucrChkZero.AutoSize = True
        Me.ucrChkZero.Checked = False
        Me.ucrChkZero.Location = New System.Drawing.Point(10, 405)
        Me.ucrChkZero.Name = "ucrChkZero"
        Me.ucrChkZero.Size = New System.Drawing.Size(141, 23)
        Me.ucrChkZero.TabIndex = 19
        '
        'ucrInputComboZero
        '
        Me.ucrInputComboZero.AddQuotesIfUnrecognised = True
        Me.ucrInputComboZero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboZero.GetSetSelectedIndex = -1
        Me.ucrInputComboZero.IsReadOnly = False
        Me.ucrInputComboZero.Location = New System.Drawing.Point(155, 403)
        Me.ucrInputComboZero.Name = "ucrInputComboZero"
        Me.ucrInputComboZero.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputComboZero.TabIndex = 20
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 427)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(320, 23)
        Me.ucrSaveGraph.TabIndex = 4
        '
        'cmdDispalyDailyOptions
        '
        Me.cmdDispalyDailyOptions.Enabled = False
        Me.cmdDispalyDailyOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDispalyDailyOptions.Location = New System.Drawing.Point(9, 228)
        Me.cmdDispalyDailyOptions.Name = "cmdDispalyDailyOptions"
        Me.cmdDispalyDailyOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdDispalyDailyOptions.TabIndex = 51
        Me.cmdDispalyDailyOptions.Text = "Dispaly Daily Options"
        Me.cmdDispalyDailyOptions.UseVisualStyleBackColor = True
        '
        'dlgDisplayDailyData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(416, 511)
        Me.Controls.Add(Me.cmdDispalyDailyOptions)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrInputGraphRugColur)
        Me.Controls.Add(Me.lblGRugColour)
        Me.Controls.Add(Me.ucrReceiverMultipleElements)
        Me.Controls.Add(Me.rdoGraphByYear)
        Me.Controls.Add(Me.lblElements)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrInputComboZero)
        Me.Controls.Add(Me.ucrInputComboMissing)
        Me.Controls.Add(Me.ucrInputComboTrace)
        Me.Controls.Add(Me.ucrChkMissing)
        Me.Controls.Add(Me.ucrChkZero)
        Me.Controls.Add(Me.ucrChkTrace)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDayOfTheYear)
        Me.Controls.Add(Me.ucrReceiverDayOfYear)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStations)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.ucrPnlFrequencyDisplay)
        Me.Controls.Add(Me.ucrSelectorDisplayDailyClimaticData)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverSingleElements)
        Me.Controls.Add(Me.grpGraph)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.grpFacet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayDailyData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Display Daily Data"
        Me.grpGraph.ResumeLayout(False)
        Me.grpGraph.PerformLayout()
        Me.grpSummary.ResumeLayout(False)
        Me.grpSummary.PerformLayout()
        Me.grpFacet.ResumeLayout(False)
        Me.grpFacet.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDisplayDailyClimaticData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents ucrPnlFrequencyDisplay As UcrPanel
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStations As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents lblYaxisUpper As Label
    Friend WithEvents ucrReceiverDayOfYear As ucrReceiverSingle
    Friend WithEvents lblDayOfTheYear As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents grpGraph As GroupBox
    Friend WithEvents ucrNudUpperYaxis As ucrNud
    Friend WithEvents ucrInputRugColour As ucrInputComboBox
    Friend WithEvents lblRugColour As Label
    Friend WithEvents ucrInputBarColour As ucrInputComboBox
    Friend WithEvents lblBarColour As Label
    Friend WithEvents ucrChkTrace As ucrCheck
    Friend WithEvents ucrChkMissing As ucrCheck
    Friend WithEvents ucrInputComboMissing As ucrInputComboBox
    Friend WithEvents ucrInputComboTrace As ucrInputComboBox
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents lblElements As Label
    Friend WithEvents ucrChkSum As ucrCheck
    Friend WithEvents ucrChkMax As ucrCheck
    Friend WithEvents ucrChkMin As ucrCheck
    Friend WithEvents ucrChkMean As ucrCheck
    Friend WithEvents ucrChkMedian As ucrCheck
    Friend WithEvents ucrChkIQR As ucrCheck
    Friend WithEvents grpSummary As GroupBox
    Friend WithEvents ucrChkSumMissing As ucrCheck
    Friend WithEvents rdoGraphByYear As RadioButton
    Friend WithEvents ucrReceiverSingleElements As ucrReceiverSingle
    Friend WithEvents ucrReceiverMultipleElements As ucrReceiverMultiple
    Friend WithEvents lblFacetby As Label
    Friend WithEvents ucrInputFacetBy As ucrInputComboBox
    Friend WithEvents ucrChkNumberOfColumns As ucrCheck
    Friend WithEvents ucrNudNumberOfColumns As ucrNud
    Friend WithEvents grpFacet As GroupBox
    Friend WithEvents lblScales As Label
    Friend WithEvents ucrInputScale As ucrInputComboBox
    Friend WithEvents lblGRugColour As Label
    Friend WithEvents ucrInputGraphRugColur As ucrInputComboBox
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrInputComboZero As ucrInputComboBox
    Friend WithEvents ucrChkZero As ucrCheck
    Friend WithEvents cmdDispalyDailyOptions As Button
End Class