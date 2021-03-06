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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgInventoryPlot))
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
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
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
        'rdoMissing
        '
        resources.ApplyResources(Me.rdoMissing, "rdoMissing")
        Me.rdoMissing.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMissing.FlatAppearance.BorderSize = 2
        Me.rdoMissing.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMissing.Name = "rdoMissing"
        Me.rdoMissing.UseVisualStyleBackColor = True
        '
        'rdoGraph
        '
        resources.ApplyResources(Me.rdoGraph, "rdoGraph")
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'cmdInventoryPlotOptions
        '
        resources.ApplyResources(Me.cmdInventoryPlotOptions, "cmdInventoryPlotOptions")
        Me.cmdInventoryPlotOptions.Name = "cmdInventoryPlotOptions"
        Me.cmdInventoryPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'rdoElementOrder
        '
        resources.ApplyResources(Me.rdoElementOrder, "rdoElementOrder")
        Me.rdoElementOrder.Name = "rdoElementOrder"
        Me.rdoElementOrder.TabStop = True
        Me.rdoElementOrder.UseVisualStyleBackColor = True
        '
        'rdoDateOrder
        '
        resources.ApplyResources(Me.rdoDateOrder, "rdoDateOrder")
        Me.rdoDateOrder.Name = "rdoDateOrder"
        Me.rdoDateOrder.TabStop = True
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
        resources.ApplyResources(Me.grpOptions, "grpOptions")
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.TabStop = False
        '
        'ucrChkOmitStart
        '
        Me.ucrChkOmitStart.Checked = False
        resources.ApplyResources(Me.ucrChkOmitStart, "ucrChkOmitStart")
        Me.ucrChkOmitStart.Name = "ucrChkOmitStart"
        '
        'ucrChkOmitEnd
        '
        Me.ucrChkOmitEnd.Checked = False
        resources.ApplyResources(Me.ucrChkOmitEnd, "ucrChkOmitEnd")
        Me.ucrChkOmitEnd.Name = "ucrChkOmitEnd"
        '
        'ucrChkDetails
        '
        Me.ucrChkDetails.Checked = False
        resources.ApplyResources(Me.ucrChkDetails, "ucrChkDetails")
        Me.ucrChkDetails.Name = "ucrChkDetails"
        '
        'ucrPnlOrder
        '
        resources.ApplyResources(Me.ucrPnlOrder, "ucrPnlOrder")
        Me.ucrPnlOrder.Name = "ucrPnlOrder"
        '
        'ucrChkSummary
        '
        Me.ucrChkSummary.Checked = False
        resources.ApplyResources(Me.ucrChkSummary, "ucrChkSummary")
        Me.ucrChkSummary.Name = "ucrChkSummary"
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
        resources.ApplyResources(Me.grpDetailsOptions, "grpDetailsOptions")
        Me.grpDetailsOptions.Name = "grpDetailsOptions"
        Me.grpDetailsOptions.TabStop = False
        '
        'ucrChkMinute
        '
        Me.ucrChkMinute.Checked = False
        resources.ApplyResources(Me.ucrChkMinute, "ucrChkMinute")
        Me.ucrChkMinute.Name = "ucrChkMinute"
        '
        'ucrSaveDetails
        '
        resources.ApplyResources(Me.ucrSaveDetails, "ucrSaveDetails")
        Me.ucrSaveDetails.Name = "ucrSaveDetails"
        '
        'ucrChkSecond
        '
        Me.ucrChkSecond.Checked = False
        resources.ApplyResources(Me.ucrChkSecond, "ucrChkSecond")
        Me.ucrChkSecond.Name = "ucrChkSecond"
        '
        'ucrChkMonth
        '
        Me.ucrChkMonth.Checked = False
        resources.ApplyResources(Me.ucrChkMonth, "ucrChkMonth")
        Me.ucrChkMonth.Name = "ucrChkMonth"
        '
        'ucrChkHour
        '
        Me.ucrChkHour.Checked = False
        resources.ApplyResources(Me.ucrChkHour, "ucrChkHour")
        Me.ucrChkHour.Name = "ucrChkHour"
        '
        'ucrChkYear
        '
        Me.ucrChkYear.Checked = False
        resources.ApplyResources(Me.ucrChkYear, "ucrChkYear")
        Me.ucrChkYear.Name = "ucrChkYear"
        '
        'ucrChkDay
        '
        Me.ucrChkDay.Checked = False
        resources.ApplyResources(Me.ucrChkDay, "ucrChkDay")
        Me.ucrChkDay.Name = "ucrChkDay"
        '
        'lblGraphTitle
        '
        resources.ApplyResources(Me.lblGraphTitle, "lblGraphTitle")
        Me.lblGraphTitle.Name = "lblGraphTitle"
        '
        'grpPlotType
        '
        Me.grpPlotType.Controls.Add(Me.rdoyear_doy_plot)
        Me.grpPlotType.Controls.Add(Me.rdoDatePlot)
        Me.grpPlotType.Controls.Add(Me.ucrPnlPlotType)
        resources.ApplyResources(Me.grpPlotType, "grpPlotType")
        Me.grpPlotType.Name = "grpPlotType"
        Me.grpPlotType.TabStop = False
        '
        'rdoyear_doy_plot
        '
        resources.ApplyResources(Me.rdoyear_doy_plot, "rdoyear_doy_plot")
        Me.rdoyear_doy_plot.Name = "rdoyear_doy_plot"
        Me.rdoyear_doy_plot.TabStop = True
        Me.rdoyear_doy_plot.UseVisualStyleBackColor = True
        '
        'rdoDatePlot
        '
        resources.ApplyResources(Me.rdoDatePlot, "rdoDatePlot")
        Me.rdoDatePlot.Name = "rdoDatePlot"
        Me.rdoDatePlot.TabStop = True
        Me.rdoDatePlot.UseVisualStyleBackColor = True
        '
        'ucrPnlPlotType
        '
        resources.ApplyResources(Me.ucrPnlPlotType, "ucrPnlPlotType")
        Me.ucrPnlPlotType.Name = "ucrPnlPlotType"
        '
        'lblFacetBy
        '
        resources.ApplyResources(Me.lblFacetBy, "lblFacetBy")
        Me.lblFacetBy.Name = "lblFacetBy"
        '
        'ucrChkDisplayRainDays
        '
        Me.ucrChkDisplayRainDays.Checked = False
        resources.ApplyResources(Me.ucrChkDisplayRainDays, "ucrChkDisplayRainDays")
        Me.ucrChkDisplayRainDays.Name = "ucrChkDisplayRainDays"
        '
        'ucrInputFacetBy
        '
        Me.ucrInputFacetBy.AddQuotesIfUnrecognised = True
        Me.ucrInputFacetBy.GetSetSelectedIndex = -1
        Me.ucrInputFacetBy.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFacetBy, "ucrInputFacetBy")
        Me.ucrInputFacetBy.Name = "ucrInputFacetBy"
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTitle, "ucrInputTitle")
        Me.ucrInputTitle.Name = "ucrInputTitle"
        '
        'ucrChkShowNonMissing
        '
        Me.ucrChkShowNonMissing.Checked = False
        resources.ApplyResources(Me.ucrChkShowNonMissing, "ucrChkShowNonMissing")
        Me.ucrChkShowNonMissing.Name = "ucrChkShowNonMissing"
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.Checked = False
        resources.ApplyResources(Me.ucrChkFlipCoordinates, "ucrChkFlipCoordinates")
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
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
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverElements, "ucrReceiverElements")
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStation, "ucrReceiverStation")
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrInventoryPlotSelector
        '
        Me.ucrInventoryPlotSelector.bDropUnusedFilterLevels = False
        Me.ucrInventoryPlotSelector.bShowHiddenColumns = False
        Me.ucrInventoryPlotSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrInventoryPlotSelector, "ucrInventoryPlotSelector")
        Me.ucrInventoryPlotSelector.Name = "ucrInventoryPlotSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgInventoryPlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Tag = "Inventory_Plot"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpDetailsOptions.ResumeLayout(False)
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
