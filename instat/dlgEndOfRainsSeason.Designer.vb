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
Partial Class dlgEndOfRainsSeason
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
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.lblRainfall = New System.Windows.Forms.Label()
        Me.lblEvaporation = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblTotalOverDays = New System.Windows.Forms.Label()
        Me.lblWaterBalanceLessThan = New System.Windows.Forms.Label()
        Me.lblEndRainsColName = New System.Windows.Forms.Label()
        Me.lblWBColName = New System.Windows.Forms.Label()
        Me.ucrNudTotalOverDays = New instat.ucrNud()
        Me.ucrNudAmount = New instat.ucrNud()
        Me.ucrChkEndOfRains = New instat.ucrCheck()
        Me.ucrChkEvaporationAsReceiver = New instat.ucrCheck()
        Me.ucrReceiverEvaporation = New instat.ucrReceiverSingle()
        Me.ucrChkEndOfSeason = New instat.ucrCheck()
        Me.ucrNudWBLessThan = New instat.ucrNud()
        Me.ucrNudCapacity = New instat.ucrNud()
        Me.ucrInputWBColName = New instat.ucrInputTextBox()
        Me.ucrInputEndRainColName = New instat.ucrInputTextBox()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrSelectorForWaterBalance = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputEvaporation = New instat.ucrInputTextBox()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.cmdDoyRange = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(255, 108)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(254, 67)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(254, 150)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(66, 13)
        Me.lblDOY.TabIndex = 7
        Me.lblDOY.Text = "Day of Year:"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(156, 287)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(51, 13)
        Me.lblCapacity.TabIndex = 14
        Me.lblCapacity.Tag = "Capacity:"
        Me.lblCapacity.Text = "Capacity:"
        '
        'lblRainfall
        '
        Me.lblRainfall.AutoSize = True
        Me.lblRainfall.Location = New System.Drawing.Point(253, 192)
        Me.lblRainfall.Name = "lblRainfall"
        Me.lblRainfall.Size = New System.Drawing.Size(70, 13)
        Me.lblRainfall.TabIndex = 9
        Me.lblRainfall.Text = "Rain Column:"
        '
        'lblEvaporation
        '
        Me.lblEvaporation.AutoSize = True
        Me.lblEvaporation.Location = New System.Drawing.Point(140, 313)
        Me.lblEvaporation.Name = "lblEvaporation"
        Me.lblEvaporation.Size = New System.Drawing.Size(67, 13)
        Me.lblEvaporation.TabIndex = 18
        Me.lblEvaporation.Text = "Evaporation:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(254, 28)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 1
        Me.lblStation.Text = "Station:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(153, 347)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblAmount.TabIndex = 22
        Me.lblAmount.Text = "Amount:"
        '
        'lblTotalOverDays
        '
        Me.lblTotalOverDays.AutoSize = True
        Me.lblTotalOverDays.Location = New System.Drawing.Point(323, 347)
        Me.lblTotalOverDays.Name = "lblTotalOverDays"
        Me.lblTotalOverDays.Size = New System.Drawing.Size(66, 13)
        Me.lblTotalOverDays.TabIndex = 24
        Me.lblTotalOverDays.Text = "Over Day(s):"
        '
        'lblWaterBalanceLessThan
        '
        Me.lblWaterBalanceLessThan.AutoSize = True
        Me.lblWaterBalanceLessThan.Location = New System.Drawing.Point(295, 287)
        Me.lblWaterBalanceLessThan.Name = "lblWaterBalanceLessThan"
        Me.lblWaterBalanceLessThan.Size = New System.Drawing.Size(93, 13)
        Me.lblWaterBalanceLessThan.TabIndex = 16
        Me.lblWaterBalanceLessThan.Tag = "Water Balance <="
        Me.lblWaterBalanceLessThan.Text = "Water Balance <="
        '
        'lblEndRainsColName
        '
        Me.lblEndRainsColName.AutoSize = True
        Me.lblEndRainsColName.Location = New System.Drawing.Point(6, 417)
        Me.lblEndRainsColName.Name = "lblEndRainsColName"
        Me.lblEndRainsColName.Size = New System.Drawing.Size(140, 13)
        Me.lblEndRainsColName.TabIndex = 28
        Me.lblEndRainsColName.Tag = "End of Rains Col Name:"
        Me.lblEndRainsColName.Text = "End of Rains Column Name:"
        '
        'lblWBColName
        '
        Me.lblWBColName.AutoSize = True
        Me.lblWBColName.Location = New System.Drawing.Point(6, 390)
        Me.lblWBColName.Name = "lblWBColName"
        Me.lblWBColName.Size = New System.Drawing.Size(149, 13)
        Me.lblWBColName.TabIndex = 26
        Me.lblWBColName.Tag = "Water Balance Col Name:"
        Me.lblWBColName.Text = "End of Season Column Name:"
        '
        'ucrNudTotalOverDays
        '
        Me.ucrNudTotalOverDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalOverDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTotalOverDays.Location = New System.Drawing.Point(395, 345)
        Me.ucrNudTotalOverDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTotalOverDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalOverDays.Name = "ucrNudTotalOverDays"
        Me.ucrNudTotalOverDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTotalOverDays.TabIndex = 25
        Me.ucrNudTotalOverDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAmount
        '
        Me.ucrNudAmount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAmount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAmount.Location = New System.Drawing.Point(209, 344)
        Me.ucrNudAmount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAmount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAmount.Name = "ucrNudAmount"
        Me.ucrNudAmount.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAmount.TabIndex = 23
        Me.ucrNudAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkEndOfRains
        '
        Me.ucrChkEndOfRains.Checked = False
        Me.ucrChkEndOfRains.Location = New System.Drawing.Point(15, 344)
        Me.ucrChkEndOfRains.Name = "ucrChkEndOfRains"
        Me.ucrChkEndOfRains.Size = New System.Drawing.Size(135, 20)
        Me.ucrChkEndOfRains.TabIndex = 21
        '
        'ucrChkEvaporationAsReceiver
        '
        Me.ucrChkEvaporationAsReceiver.Checked = False
        Me.ucrChkEvaporationAsReceiver.Location = New System.Drawing.Point(370, 310)
        Me.ucrChkEvaporationAsReceiver.Name = "ucrChkEvaporationAsReceiver"
        Me.ucrChkEvaporationAsReceiver.Size = New System.Drawing.Size(201, 20)
        Me.ucrChkEvaporationAsReceiver.TabIndex = 20
        '
        'ucrReceiverEvaporation
        '
        Me.ucrReceiverEvaporation.frmParent = Me
        Me.ucrReceiverEvaporation.Location = New System.Drawing.Point(209, 310)
        Me.ucrReceiverEvaporation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEvaporation.Name = "ucrReceiverEvaporation"
        Me.ucrReceiverEvaporation.Selector = Nothing
        Me.ucrReceiverEvaporation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverEvaporation.strNcFilePath = ""
        Me.ucrReceiverEvaporation.TabIndex = 19
        Me.ucrReceiverEvaporation.ucrSelector = Nothing
        '
        'ucrChkEndOfSeason
        '
        Me.ucrChkEndOfSeason.Checked = False
        Me.ucrChkEndOfSeason.Location = New System.Drawing.Point(15, 287)
        Me.ucrChkEndOfSeason.Name = "ucrChkEndOfSeason"
        Me.ucrChkEndOfSeason.Size = New System.Drawing.Size(135, 20)
        Me.ucrChkEndOfSeason.TabIndex = 13
        '
        'ucrNudWBLessThan
        '
        Me.ucrNudWBLessThan.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBLessThan.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWBLessThan.Location = New System.Drawing.Point(394, 284)
        Me.ucrNudWBLessThan.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWBLessThan.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBLessThan.Name = "ucrNudWBLessThan"
        Me.ucrNudWBLessThan.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWBLessThan.TabIndex = 17
        Me.ucrNudWBLessThan.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudCapacity
        '
        Me.ucrNudCapacity.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCapacity.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCapacity.Location = New System.Drawing.Point(209, 284)
        Me.ucrNudCapacity.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCapacity.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCapacity.Name = "ucrNudCapacity"
        Me.ucrNudCapacity.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCapacity.TabIndex = 15
        Me.ucrNudCapacity.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputWBColName
        '
        Me.ucrInputWBColName.AddQuotesIfUnrecognised = True
        Me.ucrInputWBColName.IsMultiline = False
        Me.ucrInputWBColName.IsReadOnly = False
        Me.ucrInputWBColName.Location = New System.Drawing.Point(158, 386)
        Me.ucrInputWBColName.Name = "ucrInputWBColName"
        Me.ucrInputWBColName.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputWBColName.TabIndex = 27
        '
        'ucrInputEndRainColName
        '
        Me.ucrInputEndRainColName.AddQuotesIfUnrecognised = True
        Me.ucrInputEndRainColName.IsMultiline = False
        Me.ucrInputEndRainColName.IsReadOnly = False
        Me.ucrInputEndRainColName.Location = New System.Drawing.Point(158, 413)
        Me.ucrInputEndRainColName.Name = "ucrInputEndRainColName"
        Me.ucrInputEndRainColName.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputEndRainColName.TabIndex = 29
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(253, 43)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(253, 123)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 6
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(253, 82)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 4
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(253, 165)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 8
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(253, 207)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverRainfall.strNcFilePath = ""
        Me.ucrReceiverRainfall.TabIndex = 10
        Me.ucrReceiverRainfall.ucrSelector = Nothing
        '
        'ucrSelectorForWaterBalance
        '
        Me.ucrSelectorForWaterBalance.bShowHiddenColumns = False
        Me.ucrSelectorForWaterBalance.bUseCurrentFilter = True
        Me.ucrSelectorForWaterBalance.Location = New System.Drawing.Point(9, 11)
        Me.ucrSelectorForWaterBalance.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForWaterBalance.Name = "ucrSelectorForWaterBalance"
        Me.ucrSelectorForWaterBalance.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForWaterBalance.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(8, 436)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 56)
        Me.ucrBase.TabIndex = 30
        '
        'ucrInputEvaporation
        '
        Me.ucrInputEvaporation.AddQuotesIfUnrecognised = True
        Me.ucrInputEvaporation.IsMultiline = False
        Me.ucrInputEvaporation.IsReadOnly = False
        Me.ucrInputEvaporation.Location = New System.Drawing.Point(209, 310)
        Me.ucrInputEvaporation.Name = "ucrInputEvaporation"
        Me.ucrInputEvaporation.Size = New System.Drawing.Size(143, 21)
        Me.ucrInputEvaporation.TabIndex = 26
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = True
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(130, 245)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(242, 22)
        Me.ucrInputFilterPreview.TabIndex = 12
        '
        'cmdDoyRange
        '
        Me.cmdDoyRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoyRange.Location = New System.Drawing.Point(12, 241)
        Me.cmdDoyRange.Name = "cmdDoyRange"
        Me.cmdDoyRange.Size = New System.Drawing.Size(105, 26)
        Me.cmdDoyRange.TabIndex = 11
        Me.cmdDoyRange.Tag = ""
        Me.cmdDoyRange.Text = "Day Range"
        Me.cmdDoyRange.UseVisualStyleBackColor = True
        '
        'dlgEndOfRainsSeason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 496)
        Me.Controls.Add(Me.ucrInputFilterPreview)
        Me.Controls.Add(Me.cmdDoyRange)
        Me.Controls.Add(Me.ucrNudTotalOverDays)
        Me.Controls.Add(Me.lblTotalOverDays)
        Me.Controls.Add(Me.ucrNudAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.ucrChkEndOfRains)
        Me.Controls.Add(Me.ucrChkEvaporationAsReceiver)
        Me.Controls.Add(Me.ucrReceiverEvaporation)
        Me.Controls.Add(Me.ucrChkEndOfSeason)
        Me.Controls.Add(Me.lblEvaporation)
        Me.Controls.Add(Me.ucrNudWBLessThan)
        Me.Controls.Add(Me.lblWaterBalanceLessThan)
        Me.Controls.Add(Me.lblCapacity)
        Me.Controls.Add(Me.ucrNudCapacity)
        Me.Controls.Add(Me.lblWBColName)
        Me.Controls.Add(Me.ucrInputWBColName)
        Me.Controls.Add(Me.lblEndRainsColName)
        Me.Controls.Add(Me.ucrInputEndRainColName)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.lblDOY)
        Me.Controls.Add(Me.lblRainfall)
        Me.Controls.Add(Me.ucrReceiverRainfall)
        Me.Controls.Add(Me.ucrSelectorForWaterBalance)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrInputEvaporation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgEndOfRainsSeason"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "End_of_Rains_Season"
        Me.Text = "End of Rains/Season"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrInputEvaporation As ucrInputTextBox
    Friend WithEvents lblEvaporation As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents lblDOY As Label
    Friend WithEvents lblCapacity As Label
    Friend WithEvents lblRainfall As Label
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents ucrSelectorForWaterBalance As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblAmount As Label
    Friend WithEvents ucrNudAmount As ucrNud
    Friend WithEvents lblTotalOverDays As Label
    Friend WithEvents ucrNudTotalOverDays As ucrNud
    Friend WithEvents ucrNudWBLessThan As ucrNud
    Friend WithEvents ucrNudCapacity As ucrNud
    Friend WithEvents ucrInputEndRainColName As ucrInputTextBox
    Friend WithEvents lblEndRainsColName As Label
    Friend WithEvents lblWBColName As Label
    Friend WithEvents ucrInputWBColName As ucrInputTextBox
    Friend WithEvents lblWaterBalanceLessThan As Label
    Friend WithEvents ucrChkEvaporationAsReceiver As ucrCheck
    Friend WithEvents ucrReceiverEvaporation As ucrReceiverSingle
    Friend WithEvents ucrChkEndOfSeason As ucrCheck
    Friend WithEvents ucrChkEndOfRains As ucrCheck
    Friend WithEvents ucrInputFilterPreview As ucrInputTextBox
    Friend WithEvents cmdDoyRange As Button
End Class