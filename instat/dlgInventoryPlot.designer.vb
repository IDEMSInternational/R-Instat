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
Partial Class dlgInventoryPlot
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
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.rdoMissing = New System.Windows.Forms.RadioButton()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.cmdInventoryPlotOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.rdoElementOrder = New System.Windows.Forms.RadioButton()
        Me.rdoDateOrder = New System.Windows.Forms.RadioButton()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkOmitStart = New instat.ucrCheck()
        Me.ucrChkOmitEnd = New instat.ucrCheck()
        Me.ucrChkDetails = New instat.ucrCheck()
        Me.ucrPnlOrder = New instat.UcrPanel()
        Me.ucrChkSummary = New instat.ucrCheck()
        Me.grpDetailsOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkMinute = New instat.ucrCheck()
        Me.ucrSaveDetails = New instat.ucrSave()
        Me.ucrChkSecond = New instat.ucrCheck()
        Me.ucrChkMonth = New instat.ucrCheck()
        Me.ucrChkHour = New instat.ucrCheck()
        Me.ucrChkYear = New instat.ucrCheck()
        Me.ucrChkDay = New instat.ucrCheck()
        Me.lblGraphTitle = New System.Windows.Forms.Label()
        Me.grpPlotType = New System.Windows.Forms.GroupBox()
        Me.rdoyear_doy_plot = New System.Windows.Forms.RadioButton()
        Me.rdoDatePlot = New System.Windows.Forms.RadioButton()
        Me.ucrPnlPlotType = New instat.UcrPanel()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.ucrChkDisplayRainDays = New instat.ucrCheck()
        Me.ucrInputFacetBy = New instat.ucrInputComboBox()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrChkShowNonMissing = New instat.ucrCheck()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrInventoryPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpOptions.SuspendLayout()
        Me.grpDetailsOptions.SuspendLayout()
        Me.grpPlotType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(263, 42)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 24
        Me.lblDate.Text = "Date:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(263, 200)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(91, 13)
        Me.lblStation.TabIndex = 26
        Me.lblStation.Text = "Station (Optional):"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement.Location = New System.Drawing.Point(263, 81)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(59, 13)
        Me.lblElement.TabIndex = 25
        Me.lblElement.Text = "Element(s):"
        '
        'rdoMissing
        '
        Me.rdoMissing.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMissing.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMissing.FlatAppearance.BorderSize = 2
        Me.rdoMissing.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMissing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMissing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMissing.Location = New System.Drawing.Point(222, 3)
        Me.rdoMissing.Name = "rdoMissing"
        Me.rdoMissing.Size = New System.Drawing.Size(135, 27)
        Me.rdoMissing.TabIndex = 1
        Me.rdoMissing.Text = "Missing"
        Me.rdoMissing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMissing.UseVisualStyleBackColor = True
        '
        'rdoGraph
        '
        Me.rdoGraph.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGraph.Location = New System.Drawing.Point(89, 3)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(135, 27)
        Me.rdoGraph.TabIndex = 2
        Me.rdoGraph.Text = "Graph"
        Me.rdoGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'cmdInventoryPlotOptions
        '
        Me.cmdInventoryPlotOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdInventoryPlotOptions.Location = New System.Drawing.Point(7, 215)
        Me.cmdInventoryPlotOptions.Name = "cmdInventoryPlotOptions"
        Me.cmdInventoryPlotOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdInventoryPlotOptions.TabIndex = 50
        Me.cmdInventoryPlotOptions.Text = "Inventory Plot Options"
        Me.cmdInventoryPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Enabled = False
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(7, 240)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdOptions.TabIndex = 51
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'rdoElementOrder
        '
        Me.rdoElementOrder.AutoSize = True
        Me.rdoElementOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoElementOrder.Location = New System.Drawing.Point(248, 38)
        Me.rdoElementOrder.Name = "rdoElementOrder"
        Me.rdoElementOrder.Size = New System.Drawing.Size(92, 17)
        Me.rdoElementOrder.TabIndex = 13
        Me.rdoElementOrder.TabStop = True
        Me.rdoElementOrder.Text = "Element Order"
        Me.rdoElementOrder.UseVisualStyleBackColor = True
        '
        'rdoDateOrder
        '
        Me.rdoDateOrder.AutoSize = True
        Me.rdoDateOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDateOrder.Location = New System.Drawing.Point(125, 38)
        Me.rdoDateOrder.Name = "rdoDateOrder"
        Me.rdoDateOrder.Size = New System.Drawing.Size(77, 17)
        Me.rdoDateOrder.TabIndex = 12
        Me.rdoDateOrder.TabStop = True
        Me.rdoDateOrder.Text = "Date Order"
        Me.rdoDateOrder.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkOmitStart)
        Me.grpOptions.Controls.Add(Me.rdoElementOrder)
        Me.grpOptions.Controls.Add(Me.ucrChkOmitEnd)
        Me.grpOptions.Controls.Add(Me.rdoDateOrder)
        Me.grpOptions.Controls.Add(Me.ucrChkDetails)
        Me.grpOptions.Controls.Add(Me.ucrPnlOrder)
        Me.grpOptions.Controls.Add(Me.ucrChkSummary)
        Me.grpOptions.Location = New System.Drawing.Point(7, 254)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(376, 60)
        Me.grpOptions.TabIndex = 52
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Summary Options"
        '
        'ucrChkOmitStart
        '
        Me.ucrChkOmitStart.AutoSize = True
        Me.ucrChkOmitStart.Checked = False
        Me.ucrChkOmitStart.Location = New System.Drawing.Point(126, 16)
        Me.ucrChkOmitStart.Name = "ucrChkOmitStart"
        Me.ucrChkOmitStart.Size = New System.Drawing.Size(119, 23)
        Me.ucrChkOmitStart.TabIndex = 39
        '
        'ucrChkOmitEnd
        '
        Me.ucrChkOmitEnd.AutoSize = True
        Me.ucrChkOmitEnd.Checked = False
        Me.ucrChkOmitEnd.Location = New System.Drawing.Point(248, 16)
        Me.ucrChkOmitEnd.Name = "ucrChkOmitEnd"
        Me.ucrChkOmitEnd.Size = New System.Drawing.Size(127, 23)
        Me.ucrChkOmitEnd.TabIndex = 10
        '
        'ucrChkDetails
        '
        Me.ucrChkDetails.AutoSize = True
        Me.ucrChkDetails.Checked = False
        Me.ucrChkDetails.Location = New System.Drawing.Point(6, 38)
        Me.ucrChkDetails.Name = "ucrChkDetails"
        Me.ucrChkDetails.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkDetails.TabIndex = 11
        '
        'ucrPnlOrder
        '
        Me.ucrPnlOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOrder.Location = New System.Drawing.Point(124, 36)
        Me.ucrPnlOrder.Name = "ucrPnlOrder"
        Me.ucrPnlOrder.Size = New System.Drawing.Size(238, 20)
        Me.ucrPnlOrder.TabIndex = 38
        '
        'ucrChkSummary
        '
        Me.ucrChkSummary.AutoSize = True
        Me.ucrChkSummary.Checked = False
        Me.ucrChkSummary.Location = New System.Drawing.Point(6, 16)
        Me.ucrChkSummary.Name = "ucrChkSummary"
        Me.ucrChkSummary.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSummary.TabIndex = 16
        '
        'grpDetailsOptions
        '
        Me.grpDetailsOptions.Controls.Add(Me.ucrChkMinute)
        Me.grpDetailsOptions.Controls.Add(Me.ucrSaveDetails)
        Me.grpDetailsOptions.Controls.Add(Me.ucrChkSecond)
        Me.grpDetailsOptions.Controls.Add(Me.ucrChkMonth)
        Me.grpDetailsOptions.Controls.Add(Me.ucrChkHour)
        Me.grpDetailsOptions.Controls.Add(Me.ucrChkYear)
        Me.grpDetailsOptions.Controls.Add(Me.ucrChkDay)
        Me.grpDetailsOptions.Location = New System.Drawing.Point(7, 316)
        Me.grpDetailsOptions.Name = "grpDetailsOptions"
        Me.grpDetailsOptions.Size = New System.Drawing.Size(376, 114)
        Me.grpDetailsOptions.TabIndex = 53
        Me.grpDetailsOptions.TabStop = False
        Me.grpDetailsOptions.Text = "Details Options"
        '
        'ucrChkMinute
        '
        Me.ucrChkMinute.AutoSize = True
        Me.ucrChkMinute.Checked = False
        Me.ucrChkMinute.Enabled = False
        Me.ucrChkMinute.Location = New System.Drawing.Point(248, 36)
        Me.ucrChkMinute.Name = "ucrChkMinute"
        Me.ucrChkMinute.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkMinute.TabIndex = 18
        '
        'ucrSaveDetails
        '
        Me.ucrSaveDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDetails.Location = New System.Drawing.Point(6, 86)
        Me.ucrSaveDetails.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveDetails.Name = "ucrSaveDetails"
        Me.ucrSaveDetails.Size = New System.Drawing.Size(262, 21)
        Me.ucrSaveDetails.TabIndex = 20
        '
        'ucrChkSecond
        '
        Me.ucrChkSecond.AutoSize = True
        Me.ucrChkSecond.Checked = False
        Me.ucrChkSecond.Enabled = False
        Me.ucrChkSecond.Location = New System.Drawing.Point(248, 62)
        Me.ucrChkSecond.Name = "ucrChkSecond"
        Me.ucrChkSecond.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSecond.TabIndex = 19
        '
        'ucrChkMonth
        '
        Me.ucrChkMonth.AutoSize = True
        Me.ucrChkMonth.Checked = False
        Me.ucrChkMonth.Location = New System.Drawing.Point(126, 36)
        Me.ucrChkMonth.Name = "ucrChkMonth"
        Me.ucrChkMonth.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkMonth.TabIndex = 15
        '
        'ucrChkHour
        '
        Me.ucrChkHour.AutoSize = True
        Me.ucrChkHour.Checked = False
        Me.ucrChkHour.Enabled = False
        Me.ucrChkHour.Location = New System.Drawing.Point(248, 12)
        Me.ucrChkHour.Name = "ucrChkHour"
        Me.ucrChkHour.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkHour.TabIndex = 17
        '
        'ucrChkYear
        '
        Me.ucrChkYear.AutoSize = True
        Me.ucrChkYear.Checked = False
        Me.ucrChkYear.Location = New System.Drawing.Point(126, 12)
        Me.ucrChkYear.Name = "ucrChkYear"
        Me.ucrChkYear.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkYear.TabIndex = 14
        '
        'ucrChkDay
        '
        Me.ucrChkDay.AutoSize = True
        Me.ucrChkDay.Checked = False
        Me.ucrChkDay.Location = New System.Drawing.Point(126, 62)
        Me.ucrChkDay.Name = "ucrChkDay"
        Me.ucrChkDay.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkDay.TabIndex = 16
        '
        'lblGraphTitle
        '
        Me.lblGraphTitle.AutoSize = True
        Me.lblGraphTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGraphTitle.Location = New System.Drawing.Point(14, 384)
        Me.lblGraphTitle.Name = "lblGraphTitle"
        Me.lblGraphTitle.Size = New System.Drawing.Size(62, 13)
        Me.lblGraphTitle.TabIndex = 62
        Me.lblGraphTitle.Text = "Graph Title:"
        '
        'grpPlotType
        '
        Me.grpPlotType.Controls.Add(Me.rdoyear_doy_plot)
        Me.grpPlotType.Controls.Add(Me.rdoDatePlot)
        Me.grpPlotType.Controls.Add(Me.ucrPnlPlotType)
        Me.grpPlotType.Location = New System.Drawing.Point(7, 269)
        Me.grpPlotType.Name = "grpPlotType"
        Me.grpPlotType.Size = New System.Drawing.Size(245, 53)
        Me.grpPlotType.TabIndex = 57
        Me.grpPlotType.TabStop = False
        Me.grpPlotType.Text = "Plot Type"
        '
        'rdoyear_doy_plot
        '
        Me.rdoyear_doy_plot.AutoSize = True
        Me.rdoyear_doy_plot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoyear_doy_plot.Location = New System.Drawing.Point(131, 21)
        Me.rdoyear_doy_plot.Name = "rdoyear_doy_plot"
        Me.rdoyear_doy_plot.Size = New System.Drawing.Size(100, 17)
        Me.rdoyear_doy_plot.TabIndex = 2
        Me.rdoyear_doy_plot.TabStop = True
        Me.rdoyear_doy_plot.Text = "Year - DOY Plot"
        Me.rdoyear_doy_plot.UseVisualStyleBackColor = True
        '
        'rdoDatePlot
        '
        Me.rdoDatePlot.AutoSize = True
        Me.rdoDatePlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDatePlot.Location = New System.Drawing.Point(7, 21)
        Me.rdoDatePlot.Name = "rdoDatePlot"
        Me.rdoDatePlot.Size = New System.Drawing.Size(69, 17)
        Me.rdoDatePlot.TabIndex = 1
        Me.rdoDatePlot.TabStop = True
        Me.rdoDatePlot.Text = "Date Plot"
        Me.rdoDatePlot.UseVisualStyleBackColor = True
        '
        'ucrPnlPlotType
        '
        Me.ucrPnlPlotType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlPlotType.Location = New System.Drawing.Point(6, 13)
        Me.ucrPnlPlotType.Name = "ucrPnlPlotType"
        Me.ucrPnlPlotType.Size = New System.Drawing.Size(236, 33)
        Me.ucrPnlPlotType.TabIndex = 0
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(254, 292)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(52, 13)
        Me.lblFacetBy.TabIndex = 54
        Me.lblFacetBy.Text = "Facet By:"
        '
        'ucrChkDisplayRainDays
        '
        Me.ucrChkDisplayRainDays.AutoSize = True
        Me.ucrChkDisplayRainDays.Checked = False
        Me.ucrChkDisplayRainDays.Location = New System.Drawing.Point(14, 354)
        Me.ucrChkDisplayRainDays.Name = "ucrChkDisplayRainDays"
        Me.ucrChkDisplayRainDays.Size = New System.Drawing.Size(151, 23)
        Me.ucrChkDisplayRainDays.TabIndex = 61
        '
        'ucrInputFacetBy
        '
        Me.ucrInputFacetBy.AddQuotesIfUnrecognised = True
        Me.ucrInputFacetBy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFacetBy.GetSetSelectedIndex = -1
        Me.ucrInputFacetBy.IsReadOnly = False
        Me.ucrInputFacetBy.Location = New System.Drawing.Point(318, 288)
        Me.ucrInputFacetBy.Name = "ucrInputFacetBy"
        Me.ucrInputFacetBy.Size = New System.Drawing.Size(109, 21)
        Me.ucrInputFacetBy.TabIndex = 55
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.AutoSize = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(121, 381)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(204, 21)
        Me.ucrInputTitle.TabIndex = 59
        '
        'ucrChkShowNonMissing
        '
        Me.ucrChkShowNonMissing.AutoSize = True
        Me.ucrChkShowNonMissing.Checked = False
        Me.ucrChkShowNonMissing.Location = New System.Drawing.Point(171, 328)
        Me.ucrChkShowNonMissing.Name = "ucrChkShowNonMissing"
        Me.ucrChkShowNonMissing.Size = New System.Drawing.Size(151, 23)
        Me.ucrChkShowNonMissing.TabIndex = 56
        Me.ucrChkShowNonMissing.Visible = False
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(14, 407)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(320, 24)
        Me.ucrSaveGraph.TabIndex = 60
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.AutoSize = True
        Me.ucrChkFlipCoordinates.Checked = False
        Me.ucrChkFlipCoordinates.Location = New System.Drawing.Point(14, 328)
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        Me.ucrChkFlipCoordinates.Size = New System.Drawing.Size(224, 23)
        Me.ucrChkFlipCoordinates.TabIndex = 58
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(84, 1)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(278, 35)
        Me.ucrPnlOptions.TabIndex = 23
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(263, 57)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 4
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.AutoSize = True
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(263, 96)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.TabIndex = 5
        Me.ucrReceiverElements.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(263, 215)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 46
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrInventoryPlotSelector
        '
        Me.ucrInventoryPlotSelector.AutoSize = True
        Me.ucrInventoryPlotSelector.bDropUnusedFilterLevels = False
        Me.ucrInventoryPlotSelector.bShowHiddenColumns = False
        Me.ucrInventoryPlotSelector.bUseCurrentFilter = True
        Me.ucrInventoryPlotSelector.Location = New System.Drawing.Point(7, 32)
        Me.ucrInventoryPlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInventoryPlotSelector.Name = "ucrInventoryPlotSelector"
        Me.ucrInventoryPlotSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrInventoryPlotSelector.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 435)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 20
        '
        'dlgInventoryPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(448, 489)
        Me.Controls.Add(Me.lblGraphTitle)
        Me.Controls.Add(Me.ucrChkDisplayRainDays)
        Me.Controls.Add(Me.grpPlotType)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrInputFacetBy)
        Me.Controls.Add(Me.ucrInputTitle)
        Me.Controls.Add(Me.ucrChkShowNonMissing)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.Controls.Add(Me.grpDetailsOptions)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.cmdInventoryPlotOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.rdoMissing)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverElements)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrInventoryPlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInventoryPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Inventory_Plot"
        Me.Text = "Inventory"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpDetailsOptions.ResumeLayout(False)
        Me.grpDetailsOptions.PerformLayout()
        Me.grpPlotType.ResumeLayout(False)
        Me.grpPlotType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInventoryPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverElements As ucrReceiverMultiple
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrChkMinute As ucrCheck
    Friend WithEvents ucrChkSecond As ucrCheck
    Friend WithEvents ucrChkYear As ucrCheck
    Friend WithEvents ucrChkMonth As ucrCheck
    Friend WithEvents ucrChkDay As ucrCheck
    Friend WithEvents ucrChkHour As ucrCheck
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents rdoMissing As RadioButton
    Friend WithEvents cmdInventoryPlotOptions As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents rdoElementOrder As RadioButton
    Friend WithEvents ucrSaveDetails As ucrSave
    Friend WithEvents rdoDateOrder As RadioButton
    Friend WithEvents ucrPnlOrder As UcrPanel
    Friend WithEvents ucrChkDetails As ucrCheck
    Friend WithEvents ucrChkSummary As ucrCheck
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents grpDetailsOptions As GroupBox
    Friend WithEvents lblGraphTitle As Label
    Friend WithEvents ucrChkDisplayRainDays As ucrCheck
    Friend WithEvents grpPlotType As GroupBox
    Friend WithEvents rdoyear_doy_plot As RadioButton
    Friend WithEvents rdoDatePlot As RadioButton
    Friend WithEvents ucrPnlPlotType As UcrPanel
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrInputFacetBy As ucrInputComboBox
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents ucrChkShowNonMissing As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents ucrChkOmitStart As ucrCheck
    Friend WithEvents ucrChkOmitEnd As ucrCheck
End Class
