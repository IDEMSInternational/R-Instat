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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorDisplayDailyClimaticData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFrequencyDisplay = New instat.UcrPanel()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.ucrReceiverStations = New instat.ucrReceiverSingle()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.ucrReceiverXaxis = New instat.ucrReceiverSingle()
        Me.lblXaxis = New System.Windows.Forms.Label()
        Me.lblYaxisUpper = New System.Windows.Forms.Label()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrChkMissingRugPlot = New instat.ucrCheck()
        Me.ucrNudLowerYaxis = New instat.ucrNud()
        Me.grpGraph = New System.Windows.Forms.GroupBox()
        Me.ucrChkValuesOutsideYrange = New instat.ucrCheck()
        Me.ucrNudUpperYaxis = New instat.ucrNud()
        Me.lblYaxisLower = New System.Windows.Forms.Label()
        Me.grpGraph.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 375)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(428, 52)
        Me.ucrBase.TabIndex = 16
        '
        'ucrSelectorDisplayDailyClimaticData
        '
        Me.ucrSelectorDisplayDailyClimaticData.bShowHiddenColumns = False
        Me.ucrSelectorDisplayDailyClimaticData.bUseCurrentFilter = True
        Me.ucrSelectorDisplayDailyClimaticData.Location = New System.Drawing.Point(10, 43)
        Me.ucrSelectorDisplayDailyClimaticData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDisplayDailyClimaticData.Name = "ucrSelectorDisplayDailyClimaticData"
        Me.ucrSelectorDisplayDailyClimaticData.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDisplayDailyClimaticData.TabIndex = 4
        '
        'rdoTable
        '
        Me.rdoTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoTable.Location = New System.Drawing.Point(133, 12)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(100, 28)
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
        Me.rdoGraph.Location = New System.Drawing.Point(231, 12)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(100, 28)
        Me.rdoGraph.TabIndex = 2
        Me.rdoGraph.Text = "Graph"
        Me.rdoGraph.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'ucrPnlFrequencyDisplay
        '
        Me.ucrPnlFrequencyDisplay.Location = New System.Drawing.Point(122, 12)
        Me.ucrPnlFrequencyDisplay.Name = "ucrPnlFrequencyDisplay"
        Me.ucrPnlFrequencyDisplay.Size = New System.Drawing.Size(214, 29)
        Me.ucrPnlFrequencyDisplay.TabIndex = 0
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(293, 65)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 5
        Me.lblStation.Text = "Station:"
        '
        'ucrReceiverStations
        '
        Me.ucrReceiverStations.frmParent = Me
        Me.ucrReceiverStations.Location = New System.Drawing.Point(293, 80)
        Me.ucrReceiverStations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStations.Name = "ucrReceiverStations"
        Me.ucrReceiverStations.Selector = Nothing
        Me.ucrReceiverStations.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStations.strNcFilePath = ""
        Me.ucrReceiverStations.TabIndex = 6
        Me.ucrReceiverStations.ucrSelector = Nothing
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(293, 239)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(59, 13)
        Me.lblElement.TabIndex = 14
        Me.lblElement.Text = "Element(s):"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(293, 109)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Date:"
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(293, 124)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 8
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(293, 168)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 10
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(293, 153)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 9
        Me.lblYear.Text = "Year:"
        '
        'ucrReceiverXaxis
        '
        Me.ucrReceiverXaxis.frmParent = Me
        Me.ucrReceiverXaxis.Location = New System.Drawing.Point(293, 212)
        Me.ucrReceiverXaxis.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverXaxis.Name = "ucrReceiverXaxis"
        Me.ucrReceiverXaxis.Selector = Nothing
        Me.ucrReceiverXaxis.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverXaxis.strNcFilePath = ""
        Me.ucrReceiverXaxis.TabIndex = 12
        Me.ucrReceiverXaxis.ucrSelector = Nothing
        '
        'lblXaxis
        '
        Me.lblXaxis.AutoSize = True
        Me.lblXaxis.Location = New System.Drawing.Point(293, 195)
        Me.lblXaxis.Name = "lblXaxis"
        Me.lblXaxis.Size = New System.Drawing.Size(38, 13)
        Me.lblXaxis.TabIndex = 11
        Me.lblXaxis.Text = "X-axis:"
        '
        'lblYaxisUpper
        '
        Me.lblYaxisUpper.AutoSize = True
        Me.lblYaxisUpper.Location = New System.Drawing.Point(140, 19)
        Me.lblYaxisUpper.Name = "lblYaxisUpper"
        Me.lblYaxisUpper.Size = New System.Drawing.Size(70, 13)
        Me.lblYaxisUpper.TabIndex = 2
        Me.lblYaxisUpper.Text = "Y-axis Upper:"
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(293, 253)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(120, 78)
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.TabIndex = 15
        Me.ucrReceiverElements.ucrSelector = Nothing
        '
        'ucrChkMissingRugPlot
        '
        Me.ucrChkMissingRugPlot.Checked = False
        Me.ucrChkMissingRugPlot.Location = New System.Drawing.Point(9, 71)
        Me.ucrChkMissingRugPlot.Name = "ucrChkMissingRugPlot"
        Me.ucrChkMissingRugPlot.Size = New System.Drawing.Size(263, 20)
        Me.ucrChkMissingRugPlot.TabIndex = 5
        '
        'ucrNudLowerYaxis
        '
        Me.ucrNudLowerYaxis.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLowerYaxis.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLowerYaxis.Location = New System.Drawing.Point(80, 16)
        Me.ucrNudLowerYaxis.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLowerYaxis.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLowerYaxis.Name = "ucrNudLowerYaxis"
        Me.ucrNudLowerYaxis.Size = New System.Drawing.Size(50, 23)
        Me.ucrNudLowerYaxis.TabIndex = 1
        Me.ucrNudLowerYaxis.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpGraph
        '
        Me.grpGraph.Controls.Add(Me.ucrChkValuesOutsideYrange)
        Me.grpGraph.Controls.Add(Me.ucrChkMissingRugPlot)
        Me.grpGraph.Controls.Add(Me.ucrNudUpperYaxis)
        Me.grpGraph.Controls.Add(Me.lblYaxisLower)
        Me.grpGraph.Controls.Add(Me.ucrNudLowerYaxis)
        Me.grpGraph.Controls.Add(Me.lblYaxisUpper)
        Me.grpGraph.Location = New System.Drawing.Point(10, 232)
        Me.grpGraph.Name = "grpGraph"
        Me.grpGraph.Size = New System.Drawing.Size(277, 105)
        Me.grpGraph.TabIndex = 13
        Me.grpGraph.TabStop = False
        Me.grpGraph.Text = "Graph"
        '
        'ucrChkValuesOutsideYrange
        '
        Me.ucrChkValuesOutsideYrange.Checked = False
        Me.ucrChkValuesOutsideYrange.Location = New System.Drawing.Point(9, 45)
        Me.ucrChkValuesOutsideYrange.Name = "ucrChkValuesOutsideYrange"
        Me.ucrChkValuesOutsideYrange.Size = New System.Drawing.Size(263, 20)
        Me.ucrChkValuesOutsideYrange.TabIndex = 4
        '
        'ucrNudUpperYaxis
        '
        Me.ucrNudUpperYaxis.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperYaxis.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudUpperYaxis.Location = New System.Drawing.Point(216, 16)
        Me.ucrNudUpperYaxis.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudUpperYaxis.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperYaxis.Name = "ucrNudUpperYaxis"
        Me.ucrNudUpperYaxis.Size = New System.Drawing.Size(50, 23)
        Me.ucrNudUpperYaxis.TabIndex = 3
        Me.ucrNudUpperYaxis.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblYaxisLower
        '
        Me.lblYaxisLower.AutoSize = True
        Me.lblYaxisLower.Location = New System.Drawing.Point(6, 19)
        Me.lblYaxisLower.Name = "lblYaxisLower"
        Me.lblYaxisLower.Size = New System.Drawing.Size(70, 13)
        Me.lblYaxisLower.TabIndex = 0
        Me.lblYaxisLower.Text = "Y-axis Lower:"
        '
        'dlgDisplayDailyData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 444)
        Me.Controls.Add(Me.grpGraph)
        Me.Controls.Add(Me.ucrReceiverElements)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblXaxis)
        Me.Controls.Add(Me.ucrReceiverXaxis)
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
    Friend WithEvents ucrReceiverXaxis As ucrReceiverSingle
    Friend WithEvents lblXaxis As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrChkMissingRugPlot As ucrCheck
    Friend WithEvents ucrNudLowerYaxis As ucrNud
    Friend WithEvents grpGraph As GroupBox
    Friend WithEvents ucrChkValuesOutsideYrange As ucrCheck
    Friend WithEvents ucrNudUpperYaxis As ucrNud
    Friend WithEvents lblYaxisLower As Label
End Class
