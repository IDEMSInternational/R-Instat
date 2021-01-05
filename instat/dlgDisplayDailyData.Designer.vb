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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDisplayDailyData))
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
        Me.lblRugColor = New System.Windows.Forms.Label()
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
        resources.ApplyResources(Me.rdoTable, "rdoTable")
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'rdoGraph
        '
        resources.ApplyResources(Me.rdoGraph, "rdoGraph")
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'lblElement
        '
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'lblDayOfTheYear
        '
        resources.ApplyResources(Me.lblDayOfTheYear, "lblDayOfTheYear")
        Me.lblDayOfTheYear.Name = "lblDayOfTheYear"
        '
        'lblYaxisUpper
        '
        resources.ApplyResources(Me.lblYaxisUpper, "lblYaxisUpper")
        Me.lblYaxisUpper.Name = "lblYaxisUpper"
        '
        'grpGraph
        '
        Me.grpGraph.Controls.Add(Me.ucrInputRugColour)
        Me.grpGraph.Controls.Add(Me.lblRugColor)
        Me.grpGraph.Controls.Add(Me.ucrInputBarColour)
        Me.grpGraph.Controls.Add(Me.lblBarColour)
        Me.grpGraph.Controls.Add(Me.ucrNudUpperYaxis)
        Me.grpGraph.Controls.Add(Me.lblYaxisUpper)
        resources.ApplyResources(Me.grpGraph, "grpGraph")
        Me.grpGraph.Name = "grpGraph"
        Me.grpGraph.TabStop = False
        '
        'ucrInputRugColour
        '
        Me.ucrInputRugColour.AddQuotesIfUnrecognised = True
        Me.ucrInputRugColour.GetSetSelectedIndex = -1
        Me.ucrInputRugColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputRugColour, "ucrInputRugColour")
        Me.ucrInputRugColour.Name = "ucrInputRugColour"
        '
        'lblRugColor
        '
        resources.ApplyResources(Me.lblRugColor, "lblRugColor")
        Me.lblRugColor.Name = "lblRugColor"
        '
        'ucrInputBarColour
        '
        Me.ucrInputBarColour.AddQuotesIfUnrecognised = True
        Me.ucrInputBarColour.GetSetSelectedIndex = -1
        Me.ucrInputBarColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputBarColour, "ucrInputBarColour")
        Me.ucrInputBarColour.Name = "ucrInputBarColour"
        '
        'lblBarColour
        '
        resources.ApplyResources(Me.lblBarColour, "lblBarColour")
        Me.lblBarColour.Name = "lblBarColour"
        '
        'ucrNudUpperYaxis
        '
        Me.ucrNudUpperYaxis.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperYaxis.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudUpperYaxis, "ucrNudUpperYaxis")
        Me.ucrNudUpperYaxis.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudUpperYaxis.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperYaxis.Name = "ucrNudUpperYaxis"
        Me.ucrNudUpperYaxis.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblElements
        '
        resources.ApplyResources(Me.lblElements, "lblElements")
        Me.lblElements.Name = "lblElements"
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
        resources.ApplyResources(Me.grpSummary, "grpSummary")
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.TabStop = False
        '
        'ucrChkSumMissing
        '
        Me.ucrChkSumMissing.Checked = False
        resources.ApplyResources(Me.ucrChkSumMissing, "ucrChkSumMissing")
        Me.ucrChkSumMissing.Name = "ucrChkSumMissing"
        '
        'ucrChkMax
        '
        Me.ucrChkMax.Checked = False
        resources.ApplyResources(Me.ucrChkMax, "ucrChkMax")
        Me.ucrChkMax.Name = "ucrChkMax"
        '
        'ucrChkIQR
        '
        Me.ucrChkIQR.Checked = False
        resources.ApplyResources(Me.ucrChkIQR, "ucrChkIQR")
        Me.ucrChkIQR.Name = "ucrChkIQR"
        '
        'ucrChkMedian
        '
        Me.ucrChkMedian.Checked = False
        resources.ApplyResources(Me.ucrChkMedian, "ucrChkMedian")
        Me.ucrChkMedian.Name = "ucrChkMedian"
        '
        'ucrChkSum
        '
        Me.ucrChkSum.Checked = False
        resources.ApplyResources(Me.ucrChkSum, "ucrChkSum")
        Me.ucrChkSum.Name = "ucrChkSum"
        '
        'ucrChkMin
        '
        Me.ucrChkMin.Checked = False
        resources.ApplyResources(Me.ucrChkMin, "ucrChkMin")
        Me.ucrChkMin.Name = "ucrChkMin"
        '
        'ucrChkMean
        '
        Me.ucrChkMean.Checked = False
        resources.ApplyResources(Me.ucrChkMean, "ucrChkMean")
        Me.ucrChkMean.Name = "ucrChkMean"
        '
        'grpFacet
        '
        Me.grpFacet.Controls.Add(Me.lblScales)
        Me.grpFacet.Controls.Add(Me.ucrInputScale)
        Me.grpFacet.Controls.Add(Me.lblFacetby)
        Me.grpFacet.Controls.Add(Me.ucrNudNumberOfColumns)
        Me.grpFacet.Controls.Add(Me.ucrInputFacetBy)
        Me.grpFacet.Controls.Add(Me.ucrChkNumberOfColumns)
        resources.ApplyResources(Me.grpFacet, "grpFacet")
        Me.grpFacet.Name = "grpFacet"
        Me.grpFacet.TabStop = False
        '
        'lblScales
        '
        resources.ApplyResources(Me.lblScales, "lblScales")
        Me.lblScales.Name = "lblScales"
        '
        'ucrInputScale
        '
        Me.ucrInputScale.AddQuotesIfUnrecognised = True
        Me.ucrInputScale.GetSetSelectedIndex = -1
        Me.ucrInputScale.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputScale, "ucrInputScale")
        Me.ucrInputScale.Name = "ucrInputScale"
        '
        'lblFacetby
        '
        resources.ApplyResources(Me.lblFacetby, "lblFacetby")
        Me.lblFacetby.Name = "lblFacetby"
        '
        'ucrNudNumberOfColumns
        '
        Me.ucrNudNumberOfColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNumberOfColumns, "ucrNudNumberOfColumns")
        Me.ucrNudNumberOfColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Name = "ucrNudNumberOfColumns"
        Me.ucrNudNumberOfColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputFacetBy
        '
        Me.ucrInputFacetBy.AddQuotesIfUnrecognised = True
        Me.ucrInputFacetBy.GetSetSelectedIndex = -1
        Me.ucrInputFacetBy.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFacetBy, "ucrInputFacetBy")
        Me.ucrInputFacetBy.Name = "ucrInputFacetBy"
        '
        'ucrChkNumberOfColumns
        '
        Me.ucrChkNumberOfColumns.Checked = False
        resources.ApplyResources(Me.ucrChkNumberOfColumns, "ucrChkNumberOfColumns")
        Me.ucrChkNumberOfColumns.Name = "ucrChkNumberOfColumns"
        '
        'rdoGraphByYear
        '
        resources.ApplyResources(Me.rdoGraphByYear, "rdoGraphByYear")
        Me.rdoGraphByYear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraphByYear.FlatAppearance.BorderSize = 2
        Me.rdoGraphByYear.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraphByYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoGraphByYear.Name = "rdoGraphByYear"
        Me.rdoGraphByYear.UseVisualStyleBackColor = True
        '
        'lblGRugColour
        '
        resources.ApplyResources(Me.lblGRugColour, "lblGRugColour")
        Me.lblGRugColour.Name = "lblGRugColour"
        '
        'ucrInputGraphRugColur
        '
        Me.ucrInputGraphRugColur.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphRugColur.GetSetSelectedIndex = -1
        Me.ucrInputGraphRugColur.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphRugColur, "ucrInputGraphRugColur")
        Me.ucrInputGraphRugColur.Name = "ucrInputGraphRugColur"
        '
        'ucrReceiverMultipleElements
        '
        Me.ucrReceiverMultipleElements.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMultipleElements, "ucrReceiverMultipleElements")
        Me.ucrReceiverMultipleElements.Name = "ucrReceiverMultipleElements"
        Me.ucrReceiverMultipleElements.Selector = Nothing
        Me.ucrReceiverMultipleElements.strNcFilePath = ""
        Me.ucrReceiverMultipleElements.ucrSelector = Nothing
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverElement, "ucrReceiverElement")
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrInputComboMissing
        '
        Me.ucrInputComboMissing.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMissing.GetSetSelectedIndex = -1
        Me.ucrInputComboMissing.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboMissing, "ucrInputComboMissing")
        Me.ucrInputComboMissing.Name = "ucrInputComboMissing"
        '
        'ucrInputComboTrace
        '
        Me.ucrInputComboTrace.AddQuotesIfUnrecognised = True
        Me.ucrInputComboTrace.GetSetSelectedIndex = -1
        Me.ucrInputComboTrace.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboTrace, "ucrInputComboTrace")
        Me.ucrInputComboTrace.Name = "ucrInputComboTrace"
        '
        'ucrChkMissing
        '
        Me.ucrChkMissing.Checked = False
        resources.ApplyResources(Me.ucrChkMissing, "ucrChkMissing")
        Me.ucrChkMissing.Name = "ucrChkMissing"
        '
        'ucrChkTrace
        '
        Me.ucrChkTrace.Checked = False
        resources.ApplyResources(Me.ucrChkTrace, "ucrChkTrace")
        Me.ucrChkTrace.Name = "ucrChkTrace"
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYear, "ucrReceiverYear")
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDayOfYear
        '
        Me.ucrReceiverDayOfYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDayOfYear, "ucrReceiverDayOfYear")
        Me.ucrReceiverDayOfYear.Name = "ucrReceiverDayOfYear"
        Me.ucrReceiverDayOfYear.Selector = Nothing
        Me.ucrReceiverDayOfYear.strNcFilePath = ""
        Me.ucrReceiverDayOfYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStations
        '
        Me.ucrReceiverStations.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStations, "ucrReceiverStations")
        Me.ucrReceiverStations.Name = "ucrReceiverStations"
        Me.ucrReceiverStations.Selector = Nothing
        Me.ucrReceiverStations.strNcFilePath = ""
        Me.ucrReceiverStations.ucrSelector = Nothing
        '
        'ucrPnlFrequencyDisplay
        '
        resources.ApplyResources(Me.ucrPnlFrequencyDisplay, "ucrPnlFrequencyDisplay")
        Me.ucrPnlFrequencyDisplay.Name = "ucrPnlFrequencyDisplay"
        '
        'ucrSelectorDisplayDailyClimaticData
        '
        Me.ucrSelectorDisplayDailyClimaticData.bDropUnusedFilterLevels = False
        Me.ucrSelectorDisplayDailyClimaticData.bShowHiddenColumns = False
        Me.ucrSelectorDisplayDailyClimaticData.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorDisplayDailyClimaticData, "ucrSelectorDisplayDailyClimaticData")
        Me.ucrSelectorDisplayDailyClimaticData.Name = "ucrSelectorDisplayDailyClimaticData"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverSingleElements
        '
        Me.ucrReceiverSingleElements.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSingleElements, "ucrReceiverSingleElements")
        Me.ucrReceiverSingleElements.Name = "ucrReceiverSingleElements"
        Me.ucrReceiverSingleElements.Selector = Nothing
        Me.ucrReceiverSingleElements.strNcFilePath = ""
        Me.ucrReceiverSingleElements.ucrSelector = Nothing
        '
        'ucrChkZero
        '
        Me.ucrChkZero.Checked = False
        resources.ApplyResources(Me.ucrChkZero, "ucrChkZero")
        Me.ucrChkZero.Name = "ucrChkZero"
        '
        'ucrInputComboZero
        '
        Me.ucrInputComboZero.AddQuotesIfUnrecognised = True
        Me.ucrInputComboZero.GetSetSelectedIndex = -1
        Me.ucrInputComboZero.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboZero, "ucrInputComboZero")
        Me.ucrInputComboZero.Name = "ucrInputComboZero"
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'cmdDispalyDailyOptions
        '
        resources.ApplyResources(Me.cmdDispalyDailyOptions, "cmdDispalyDailyOptions")
        Me.cmdDispalyDailyOptions.Name = "cmdDispalyDailyOptions"
        Me.cmdDispalyDailyOptions.UseVisualStyleBackColor = True
        '
        'dlgDisplayDailyData
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdDispalyDailyOptions)
        Me.Controls.Add(Me.grpGraph)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.grpFacet)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayDailyData"
        Me.grpGraph.ResumeLayout(False)
        Me.grpGraph.PerformLayout()
        Me.grpSummary.ResumeLayout(False)
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
    Friend WithEvents lblRugColor As Label
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