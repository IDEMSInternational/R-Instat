﻿' R- Instat
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
Partial Class dlgInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgInventory))
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.cmdInventoryPlotOptions = New System.Windows.Forms.Button()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.cmdSummary = New System.Windows.Forms.Button()
        Me.cmdGraph = New System.Windows.Forms.Button()
        Me.rdoDateOrder = New System.Windows.Forms.RadioButton()
        Me.rdoElementOrder = New System.Windows.Forms.RadioButton()
        Me.ucrChkMinute = New instat.ucrCheck()
        Me.ucrChkSecond = New instat.ucrCheck()
        Me.ucrChkDay = New instat.ucrCheck()
        Me.ucrChkMonth = New instat.ucrCheck()
        Me.ucrChkHour = New instat.ucrCheck()
        Me.ucrChkYear = New instat.ucrCheck()
        Me.ucrPnlDateOrderAndElementOrder = New instat.UcrPanel()
        Me.ucrChkDetails = New instat.ucrCheck()
        Me.ucrChkOmitEnd = New instat.ucrCheck()
        Me.ucrChkOmitStart = New instat.ucrCheck()
        Me.ucrChkSummary = New instat.ucrCheck()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrInventoryPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.UseVisualStyleBackColor = True
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
        'cmdInventoryPlotOptions
        '
        resources.ApplyResources(Me.cmdInventoryPlotOptions, "cmdInventoryPlotOptions")
        Me.cmdInventoryPlotOptions.Name = "cmdInventoryPlotOptions"
        Me.cmdInventoryPlotOptions.UseVisualStyleBackColor = True
        '
        'lblElement
        '
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
        '
        'cmdSummary
        '
        resources.ApplyResources(Me.cmdSummary, "cmdSummary")
        Me.cmdSummary.Name = "cmdSummary"
        Me.cmdSummary.UseVisualStyleBackColor = True
        '
        'cmdGraph
        '
        resources.ApplyResources(Me.cmdGraph, "cmdGraph")
        Me.cmdGraph.Name = "cmdGraph"
        Me.cmdGraph.UseVisualStyleBackColor = True
        '
        'rdoDateOrder
        '
        resources.ApplyResources(Me.rdoDateOrder, "rdoDateOrder")
        Me.rdoDateOrder.Name = "rdoDateOrder"
        Me.rdoDateOrder.TabStop = True
        Me.rdoDateOrder.UseVisualStyleBackColor = True
        '
        'rdoElementOrder
        '
        resources.ApplyResources(Me.rdoElementOrder, "rdoElementOrder")
        Me.rdoElementOrder.Name = "rdoElementOrder"
        Me.rdoElementOrder.TabStop = True
        Me.rdoElementOrder.UseVisualStyleBackColor = True
        '
        'ucrChkMinute
        '
        Me.ucrChkMinute.Checked = False
        resources.ApplyResources(Me.ucrChkMinute, "ucrChkMinute")
        Me.ucrChkMinute.Name = "ucrChkMinute"
        '
        'ucrChkSecond
        '
        Me.ucrChkSecond.Checked = False
        resources.ApplyResources(Me.ucrChkSecond, "ucrChkSecond")
        Me.ucrChkSecond.Name = "ucrChkSecond"
        '
        'ucrChkDay
        '
        Me.ucrChkDay.Checked = False
        resources.ApplyResources(Me.ucrChkDay, "ucrChkDay")
        Me.ucrChkDay.Name = "ucrChkDay"
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
        'ucrPnlDateOrderAndElementOrder
        '
        resources.ApplyResources(Me.ucrPnlDateOrderAndElementOrder, "ucrPnlDateOrderAndElementOrder")
        Me.ucrPnlDateOrderAndElementOrder.Name = "ucrPnlDateOrderAndElementOrder"
        '
        'ucrChkDetails
        '
        Me.ucrChkDetails.Checked = False
        resources.ApplyResources(Me.ucrChkDetails, "ucrChkDetails")
        Me.ucrChkDetails.Name = "ucrChkDetails"
        '
        'ucrChkOmitEnd
        '
        Me.ucrChkOmitEnd.Checked = False
        resources.ApplyResources(Me.ucrChkOmitEnd, "ucrChkOmitEnd")
        Me.ucrChkOmitEnd.Name = "ucrChkOmitEnd"
        '
        'ucrChkOmitStart
        '
        Me.ucrChkOmitStart.Checked = False
        resources.ApplyResources(Me.ucrChkOmitStart, "ucrChkOmitStart")
        Me.ucrChkOmitStart.Name = "ucrChkOmitStart"
        '
        'ucrChkSummary
        '
        Me.ucrChkSummary.Checked = False
        resources.ApplyResources(Me.ucrChkSummary, "ucrChkSummary")
        Me.ucrChkSummary.Name = "ucrChkSummary"
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
        'dlgInventory
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkMinute)
        Me.Controls.Add(Me.ucrChkSecond)
        Me.Controls.Add(Me.ucrChkDay)
        Me.Controls.Add(Me.ucrChkMonth)
        Me.Controls.Add(Me.ucrChkHour)
        Me.Controls.Add(Me.ucrChkYear)
        Me.Controls.Add(Me.rdoElementOrder)
        Me.Controls.Add(Me.rdoDateOrder)
        Me.Controls.Add(Me.ucrPnlDateOrderAndElementOrder)
        Me.Controls.Add(Me.ucrChkDetails)
        Me.Controls.Add(Me.ucrChkOmitEnd)
        Me.Controls.Add(Me.ucrChkOmitStart)
        Me.Controls.Add(Me.ucrChkSummary)
        Me.Controls.Add(Me.cmdGraph)
        Me.Controls.Add(Me.cmdSummary)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.cmdInventoryPlotOptions)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverElements)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrInventoryPlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInventory"
        Me.Tag = "Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInventoryPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdOptions As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverElements As ucrReceiverMultiple
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents cmdInventoryPlotOptions As Button
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents ucrChkMinute As ucrCheck
    Friend WithEvents ucrChkSecond As ucrCheck
    Friend WithEvents ucrChkDay As ucrCheck
    Friend WithEvents ucrChkMonth As ucrCheck
    Friend WithEvents ucrChkHour As ucrCheck
    Friend WithEvents ucrChkYear As ucrCheck
    Friend WithEvents rdoElementOrder As RadioButton
    Friend WithEvents rdoDateOrder As RadioButton
    Friend WithEvents ucrPnlDateOrderAndElementOrder As UcrPanel
    Friend WithEvents ucrChkDetails As ucrCheck
    Friend WithEvents ucrChkOmitEnd As ucrCheck
    Friend WithEvents ucrChkOmitStart As ucrCheck
    Friend WithEvents ucrChkSummary As ucrCheck
    Friend WithEvents cmdGraph As Button
    Friend WithEvents cmdSummary As Button
End Class
