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
        Me.lblRugColor = New System.Windows.Forms.Label()
        Me.lblBarColour = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.grpTable = New System.Windows.Forms.GroupBox()
        Me.lblMarginSummary = New System.Windows.Forms.Label()
        Me.lblSigFigs = New System.Windows.Forms.Label()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrInputComboSummary = New instat.ucrInputComboBox()
        Me.ucrNudSigFigs = New instat.ucrNud()
        Me.ucrChkAsHTMLTable = New instat.ucrCheck()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrInputRugColour = New instat.ucrInputComboBox()
        Me.ucrInputBarColour = New instat.ucrInputComboBox()
        Me.ucrNudUpperYaxis = New instat.ucrNud()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayOfYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStations = New instat.ucrReceiverSingle()
        Me.ucrPnlFrequencyDisplay = New instat.UcrPanel()
        Me.ucrSelectorDisplayDailyClimaticData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpGraph.SuspendLayout()
        Me.grpTable.SuspendLayout()
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
        Me.rdoTable.Location = New System.Drawing.Point(115, 12)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(100, 29)
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
        Me.rdoGraph.Location = New System.Drawing.Point(213, 12)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(100, 29)
        Me.rdoGraph.TabIndex = 2
        Me.rdoGraph.Text = "Graph"
        Me.rdoGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(291, 65)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 4
        Me.lblStation.Text = "Station:"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(291, 239)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(59, 13)
        Me.lblElement.TabIndex = 14
        Me.lblElement.Text = "Element(s):"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(288, 109)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(291, 193)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 12
        Me.lblYear.Text = "Year:"
        '
        'lblDayOfTheYear
        '
        Me.lblDayOfTheYear.AutoSize = True
        Me.lblDayOfTheYear.Location = New System.Drawing.Point(290, 152)
        Me.lblDayOfTheYear.Name = "lblDayOfTheYear"
        Me.lblDayOfTheYear.Size = New System.Drawing.Size(29, 13)
        Me.lblDayOfTheYear.TabIndex = 10
        Me.lblDayOfTheYear.Text = "Doy:"
        '
        'lblYaxisUpper
        '
        Me.lblYaxisUpper.AutoSize = True
        Me.lblYaxisUpper.Location = New System.Drawing.Point(9, 16)
        Me.lblYaxisUpper.Name = "lblYaxisUpper"
        Me.lblYaxisUpper.Size = New System.Drawing.Size(70, 13)
        Me.lblYaxisUpper.TabIndex = 0
        Me.lblYaxisUpper.Text = "Y-axis Upper:"
        '
        'grpGraph
        '
        Me.grpGraph.Controls.Add(Me.ucrSaveGraph)
        Me.grpGraph.Controls.Add(Me.ucrInputRugColour)
        Me.grpGraph.Controls.Add(Me.lblRugColor)
        Me.grpGraph.Controls.Add(Me.ucrInputBarColour)
        Me.grpGraph.Controls.Add(Me.lblBarColour)
        Me.grpGraph.Controls.Add(Me.ucrNudUpperYaxis)
        Me.grpGraph.Controls.Add(Me.lblYaxisUpper)
        Me.grpGraph.Location = New System.Drawing.Point(10, 232)
        Me.grpGraph.Name = "grpGraph"
        Me.grpGraph.Size = New System.Drawing.Size(277, 137)
        Me.grpGraph.TabIndex = 17
        Me.grpGraph.TabStop = False
        Me.grpGraph.Text = "Graph"
        '
        'lblRugColor
        '
        Me.lblRugColor.AutoSize = True
        Me.lblRugColor.Location = New System.Drawing.Point(9, 75)
        Me.lblRugColor.Name = "lblRugColor"
        Me.lblRugColor.Size = New System.Drawing.Size(57, 13)
        Me.lblRugColor.TabIndex = 4
        Me.lblRugColor.Text = "Rug Color:"
        '
        'lblBarColour
        '
        Me.lblBarColour.AutoSize = True
        Me.lblBarColour.Location = New System.Drawing.Point(9, 48)
        Me.lblBarColour.Name = "lblBarColour"
        Me.lblBarColour.Size = New System.Drawing.Size(59, 13)
        Me.lblBarColour.TabIndex = 2
        Me.lblBarColour.Text = "Bar Colour:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(291, 109)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 6
        Me.lblMonth.Text = "Month:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(291, 152)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(29, 13)
        Me.lblDay.TabIndex = 10
        Me.lblDay.Text = "Day:"
        '
        'grpTable
        '
        Me.grpTable.Controls.Add(Me.ucrChkDisplayMargins)
        Me.grpTable.Controls.Add(Me.ucrSaveTable)
        Me.grpTable.Controls.Add(Me.lblMarginSummary)
        Me.grpTable.Controls.Add(Me.ucrInputComboSummary)
        Me.grpTable.Controls.Add(Me.ucrNudSigFigs)
        Me.grpTable.Controls.Add(Me.lblSigFigs)
        Me.grpTable.Controls.Add(Me.ucrChkAsHTMLTable)
        Me.grpTable.Location = New System.Drawing.Point(10, 232)
        Me.grpTable.Name = "grpTable"
        Me.grpTable.Size = New System.Drawing.Size(277, 155)
        Me.grpTable.TabIndex = 16
        Me.grpTable.TabStop = False
        Me.grpTable.Text = "Display"
        '
        'lblMarginSummary
        '
        Me.lblMarginSummary.AutoSize = True
        Me.lblMarginSummary.Location = New System.Drawing.Point(9, 101)
        Me.lblMarginSummary.Name = "lblMarginSummary"
        Me.lblMarginSummary.Size = New System.Drawing.Size(88, 13)
        Me.lblMarginSummary.TabIndex = 4
        Me.lblMarginSummary.Tag = "Margin Summary:"
        Me.lblMarginSummary.Text = "Margin Summary:"
        '
        'lblSigFigs
        '
        Me.lblSigFigs.AutoSize = True
        Me.lblSigFigs.Location = New System.Drawing.Point(9, 48)
        Me.lblSigFigs.Name = "lblSigFigs"
        Me.lblSigFigs.Size = New System.Drawing.Size(96, 13)
        Me.lblSigFigs.TabIndex = 2
        Me.lblSigFigs.Tag = "Significant_Figures:"
        Me.lblSigFigs.Text = "Significant Figures:"
        '
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.Checked = False
        Me.ucrChkDisplayMargins.Location = New System.Drawing.Point(9, 74)
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        Me.ucrChkDisplayMargins.Size = New System.Drawing.Size(104, 20)
        Me.ucrChkDisplayMargins.TabIndex = 0
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.Location = New System.Drawing.Point(9, 126)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(256, 24)
        Me.ucrSaveTable.TabIndex = 1
        '
        'ucrInputComboSummary
        '
        Me.ucrInputComboSummary.AddQuotesIfUnrecognised = True
        Me.ucrInputComboSummary.IsReadOnly = False
        Me.ucrInputComboSummary.Location = New System.Drawing.Point(107, 97)
        Me.ucrInputComboSummary.Name = "ucrInputComboSummary"
        Me.ucrInputComboSummary.Size = New System.Drawing.Size(106, 21)
        Me.ucrInputComboSummary.TabIndex = 2
        '
        'ucrNudSigFigs
        '
        Me.ucrNudSigFigs.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSigFigs.Location = New System.Drawing.Point(107, 45)
        Me.ucrNudSigFigs.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSigFigs.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Name = "ucrNudSigFigs"
        Me.ucrNudSigFigs.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSigFigs.TabIndex = 1
        Me.ucrNudSigFigs.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkAsHTMLTable
        '
        Me.ucrChkAsHTMLTable.Checked = False
        Me.ucrChkAsHTMLTable.Location = New System.Drawing.Point(9, 22)
        Me.ucrChkAsHTMLTable.Name = "ucrChkAsHTMLTable"
        Me.ucrChkAsHTMLTable.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkAsHTMLTable.TabIndex = 0
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.frmParent = Me
        Me.ucrReceiverDay.Location = New System.Drawing.Point(290, 166)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(122, 20)
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.TabIndex = 11
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(288, 124)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(122, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 7
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(9, 106)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveGraph.TabIndex = 4
        '
        'ucrInputRugColour
        '
        Me.ucrInputRugColour.AddQuotesIfUnrecognised = True
        Me.ucrInputRugColour.IsReadOnly = False
        Me.ucrInputRugColour.Location = New System.Drawing.Point(83, 70)
        Me.ucrInputRugColour.Name = "ucrInputRugColour"
        Me.ucrInputRugColour.Size = New System.Drawing.Size(73, 21)
        Me.ucrInputRugColour.TabIndex = 6
        '
        'ucrInputBarColour
        '
        Me.ucrInputBarColour.AddQuotesIfUnrecognised = True
        Me.ucrInputBarColour.IsReadOnly = False
        Me.ucrInputBarColour.Location = New System.Drawing.Point(83, 43)
        Me.ucrInputBarColour.Name = "ucrInputBarColour"
        Me.ucrInputBarColour.Size = New System.Drawing.Size(73, 21)
        Me.ucrInputBarColour.TabIndex = 2
        '
        'ucrNudUpperYaxis
        '
        Me.ucrNudUpperYaxis.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperYaxis.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudUpperYaxis.Location = New System.Drawing.Point(83, 13)
        Me.ucrNudUpperYaxis.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrNudUpperYaxis.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudUpperYaxis.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperYaxis.Name = "ucrNudUpperYaxis"
        Me.ucrNudUpperYaxis.Size = New System.Drawing.Size(50, 23)
        Me.ucrNudUpperYaxis.TabIndex = 3
        Me.ucrNudUpperYaxis.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(290, 253)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(122, 78)
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.TabIndex = 15
        Me.ucrReceiverElements.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(290, 209)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(122, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 13
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDayOfYear
        '
        Me.ucrReceiverDayOfYear.frmParent = Me
        Me.ucrReceiverDayOfYear.Location = New System.Drawing.Point(290, 166)
        Me.ucrReceiverDayOfYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDayOfYear.Name = "ucrReceiverDayOfYear"
        Me.ucrReceiverDayOfYear.Selector = Nothing
        Me.ucrReceiverDayOfYear.Size = New System.Drawing.Size(122, 20)
        Me.ucrReceiverDayOfYear.strNcFilePath = ""
        Me.ucrReceiverDayOfYear.TabIndex = 11
        Me.ucrReceiverDayOfYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(288, 124)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(122, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 9
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStations
        '
        Me.ucrReceiverStations.frmParent = Me
        Me.ucrReceiverStations.Location = New System.Drawing.Point(290, 80)
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
        Me.ucrPnlFrequencyDisplay.Location = New System.Drawing.Point(104, 12)
        Me.ucrPnlFrequencyDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrPnlFrequencyDisplay.Name = "ucrPnlFrequencyDisplay"
        Me.ucrPnlFrequencyDisplay.Size = New System.Drawing.Size(214, 29)
        Me.ucrPnlFrequencyDisplay.TabIndex = 0
        '
        'ucrSelectorDisplayDailyClimaticData
        '
        Me.ucrSelectorDisplayDailyClimaticData.bShowHiddenColumns = False
        Me.ucrSelectorDisplayDailyClimaticData.bUseCurrentFilter = True
        Me.ucrSelectorDisplayDailyClimaticData.Location = New System.Drawing.Point(10, 43)
        Me.ucrSelectorDisplayDailyClimaticData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDisplayDailyClimaticData.Name = "ucrSelectorDisplayDailyClimaticData"
        Me.ucrSelectorDisplayDailyClimaticData.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDisplayDailyClimaticData.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 394)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(412, 52)
        Me.ucrBase.TabIndex = 18
        '
        'dlgDisplayDailyData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 459)
        Me.Controls.Add(Me.grpTable)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.ucrReceiverDay)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.grpGraph)
        Me.Controls.Add(Me.ucrReceiverElements)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayDailyData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Display Daily Data"
        Me.grpGraph.ResumeLayout(False)
        Me.grpGraph.PerformLayout()
        Me.grpTable.ResumeLayout(False)
        Me.grpTable.PerformLayout()
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
    Friend WithEvents ucrReceiverElements As ucrReceiverMultiple
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
    Friend WithEvents ucrReceiverDay As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents lblDay As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents grpTable As GroupBox
    Friend WithEvents ucrChkAsHTMLTable As ucrCheck
    Friend WithEvents ucrSaveTable As ucrSave
    Friend WithEvents ucrNudSigFigs As ucrNud
    Friend WithEvents lblSigFigs As Label
    Friend WithEvents lblMarginSummary As Label
    Friend WithEvents ucrInputComboSummary As ucrInputComboBox
    Friend WithEvents ucrChkDisplayMargins As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSave
End Class