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
Partial Class dlgPICSACrops
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
        Me.lblSelectedSet = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrSaveDataFrame = New instat.ucrSave()
        Me.ucrReceiverEnd = New instat.ucrReceiverSingle()
        Me.ucrReceiverStart = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorForCrops = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNudLengthSeqFrom = New instat.ucrNud()
        Me.ucrPnlPlantingDate = New instat.UcrPanel()
        Me.grpPlantingDate = New System.Windows.Forms.GroupBox()
        Me.ucrNudPlantingSeqTo = New instat.ucrNud()
        Me.lblPlantingTo = New System.Windows.Forms.Label()
        Me.ucrNudPlantingSeqStep = New instat.ucrNud()
        Me.lblPlantingStep = New System.Windows.Forms.Label()
        Me.ucrNudPlantingSeqFrom = New instat.ucrNud()
        Me.lblPlantingFrom = New System.Windows.Forms.Label()
        Me.rdPlantingSeq = New System.Windows.Forms.RadioButton()
        Me.lblPlantingDayNum = New System.Windows.Forms.Label()
        Me.ucrNudPlantingSingleDayNum = New instat.ucrNud()
        Me.rdPlantingSingle = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLength = New instat.UcrPanel()
        Me.grpLength = New System.Windows.Forms.GroupBox()
        Me.ucrNudLengthSeqTo = New instat.ucrNud()
        Me.lblLengthTo = New System.Windows.Forms.Label()
        Me.ucrNudLengthSeqStep = New instat.ucrNud()
        Me.lblLengthStep = New System.Windows.Forms.Label()
        Me.lblLengthFrom = New System.Windows.Forms.Label()
        Me.rdLengthSeq = New System.Windows.Forms.RadioButton()
        Me.ucrNudLengthSingleDays = New instat.ucrNud()
        Me.lblLengthDay = New System.Windows.Forms.Label()
        Me.rdLengthSingle = New System.Windows.Forms.RadioButton()
        Me.grpWater = New System.Windows.Forms.GroupBox()
        Me.ucrNudWaterSeqTo = New instat.ucrNud()
        Me.lblWaterTo = New System.Windows.Forms.Label()
        Me.ucrNudWaterSeqStep = New instat.ucrNud()
        Me.lblWaterStep = New System.Windows.Forms.Label()
        Me.ucrNudWaterSeqFrom = New instat.ucrNud()
        Me.lblWaterFrom = New System.Windows.Forms.Label()
        Me.rdWaterSeq = New System.Windows.Forms.RadioButton()
        Me.ucrNudWaterSingleAmt = New instat.ucrNud()
        Me.lblWaterAmt = New System.Windows.Forms.Label()
        Me.rdWaterSingle = New System.Windows.Forms.RadioButton()
        Me.ucrPanlWater = New instat.UcrPanel()
        Me.grpPlantingDate.SuspendLayout()
        Me.grpLength.SuspendLayout()
        Me.grpWater.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedSet
        '
        Me.lblSelectedSet.AutoSize = True
        Me.lblSelectedSet.Location = New System.Drawing.Point(255, 6)
        Me.lblSelectedSet.Name = "lblSelectedSet"
        Me.lblSelectedSet.Size = New System.Drawing.Size(43, 13)
        Me.lblSelectedSet.TabIndex = 15
        Me.lblSelectedSet.Tag = ""
        Me.lblSelectedSet.Text = "Station:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Tag = ""
        Me.Label1.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(413, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Tag = ""
        Me.Label2.Text = "Year:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(413, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Tag = ""
        Me.Label3.Text = "Day:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(413, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Tag = ""
        Me.Label4.Text = "Rainfall:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Tag = ""
        Me.Label5.Text = "Start:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Tag = ""
        Me.Label6.Text = "End :"
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(416, 365)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 31
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrSaveDataFrame
        '
        Me.ucrSaveDataFrame.Location = New System.Drawing.Point(5, 365)
        Me.ucrSaveDataFrame.Name = "ucrSaveDataFrame"
        Me.ucrSaveDataFrame.Size = New System.Drawing.Size(410, 24)
        Me.ucrSaveDataFrame.TabIndex = 32
        '
        'ucrReceiverEnd
        '
        Me.ucrReceiverEnd.frmParent = Me
        Me.ucrReceiverEnd.Location = New System.Drawing.Point(258, 163)
        Me.ucrReceiverEnd.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEnd.Name = "ucrReceiverEnd"
        Me.ucrReceiverEnd.Selector = Nothing
        Me.ucrReceiverEnd.Size = New System.Drawing.Size(120, 22)
        Me.ucrReceiverEnd.strNcFilePath = ""
        Me.ucrReceiverEnd.TabIndex = 26
        Me.ucrReceiverEnd.ucrSelector = Nothing
        '
        'ucrReceiverStart
        '
        Me.ucrReceiverStart.frmParent = Me
        Me.ucrReceiverStart.Location = New System.Drawing.Point(258, 115)
        Me.ucrReceiverStart.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStart.Name = "ucrReceiverStart"
        Me.ucrReceiverStart.Selector = Nothing
        Me.ucrReceiverStart.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStart.strNcFilePath = ""
        Me.ucrReceiverStart.TabIndex = 19
        Me.ucrReceiverStart.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(258, 66)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 18
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(415, 115)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(116, 20)
        Me.ucrReceiverRainfall.strNcFilePath = ""
        Me.ucrReceiverRainfall.TabIndex = 17
        Me.ucrReceiverRainfall.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.frmParent = Me
        Me.ucrReceiverDay.Location = New System.Drawing.Point(415, 66)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(116, 20)
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.TabIndex = 16
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(415, 22)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(116, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 3
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(258, 22)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorForCrops
        '
        Me.ucrSelectorForCrops.bShowHiddenColumns = False
        Me.ucrSelectorForCrops.bUseCurrentFilter = True
        Me.ucrSelectorForCrops.Location = New System.Drawing.Point(6, 5)
        Me.ucrSelectorForCrops.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForCrops.Name = "ucrSelectorForCrops"
        Me.ucrSelectorForCrops.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForCrops.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(5, 395)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrNudLengthSeqFrom
        '
        Me.ucrNudLengthSeqFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSeqFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLengthSeqFrom.Location = New System.Drawing.Point(122, 82)
        Me.ucrNudLengthSeqFrom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudLengthSeqFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLengthSeqFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSeqFrom.Name = "ucrNudLengthSeqFrom"
        Me.ucrNudLengthSeqFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLengthSeqFrom.TabIndex = 29
        Me.ucrNudLengthSeqFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlPlantingDate
        '
        Me.ucrPnlPlantingDate.Location = New System.Drawing.Point(6, 17)
        Me.ucrPnlPlantingDate.Name = "ucrPnlPlantingDate"
        Me.ucrPnlPlantingDate.Size = New System.Drawing.Size(180, 136)
        Me.ucrPnlPlantingDate.TabIndex = 35
        '
        'grpPlantingDate
        '
        Me.grpPlantingDate.Controls.Add(Me.ucrNudPlantingSeqTo)
        Me.grpPlantingDate.Controls.Add(Me.lblPlantingTo)
        Me.grpPlantingDate.Controls.Add(Me.ucrNudPlantingSeqStep)
        Me.grpPlantingDate.Controls.Add(Me.lblPlantingStep)
        Me.grpPlantingDate.Controls.Add(Me.ucrNudPlantingSeqFrom)
        Me.grpPlantingDate.Controls.Add(Me.lblPlantingFrom)
        Me.grpPlantingDate.Controls.Add(Me.rdPlantingSeq)
        Me.grpPlantingDate.Controls.Add(Me.lblPlantingDayNum)
        Me.grpPlantingDate.Controls.Add(Me.ucrNudPlantingSingleDayNum)
        Me.grpPlantingDate.Controls.Add(Me.rdPlantingSingle)
        Me.grpPlantingDate.Controls.Add(Me.ucrPnlPlantingDate)
        Me.grpPlantingDate.Location = New System.Drawing.Point(5, 200)
        Me.grpPlantingDate.Name = "grpPlantingDate"
        Me.grpPlantingDate.Size = New System.Drawing.Size(189, 159)
        Me.grpPlantingDate.TabIndex = 33
        Me.grpPlantingDate.TabStop = False
        Me.grpPlantingDate.Text = "Planting Date "
        '
        'ucrNudPlantingSeqTo
        '
        Me.ucrNudPlantingSeqTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSeqTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPlantingSeqTo.Location = New System.Drawing.Point(133, 131)
        Me.ucrNudPlantingSeqTo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudPlantingSeqTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPlantingSeqTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSeqTo.Name = "ucrNudPlantingSeqTo"
        Me.ucrNudPlantingSeqTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPlantingSeqTo.TabIndex = 45
        Me.ucrNudPlantingSeqTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblPlantingTo
        '
        Me.lblPlantingTo.AutoSize = True
        Me.lblPlantingTo.Location = New System.Drawing.Point(66, 135)
        Me.lblPlantingTo.Name = "lblPlantingTo"
        Me.lblPlantingTo.Size = New System.Drawing.Size(23, 13)
        Me.lblPlantingTo.TabIndex = 44
        Me.lblPlantingTo.Tag = ""
        Me.lblPlantingTo.Text = "To:"
        '
        'ucrNudPlantingSeqStep
        '
        Me.ucrNudPlantingSeqStep.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSeqStep.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPlantingSeqStep.Location = New System.Drawing.Point(133, 107)
        Me.ucrNudPlantingSeqStep.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudPlantingSeqStep.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPlantingSeqStep.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSeqStep.Name = "ucrNudPlantingSeqStep"
        Me.ucrNudPlantingSeqStep.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPlantingSeqStep.TabIndex = 43
        Me.ucrNudPlantingSeqStep.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblPlantingStep
        '
        Me.lblPlantingStep.AutoSize = True
        Me.lblPlantingStep.Location = New System.Drawing.Point(66, 108)
        Me.lblPlantingStep.Name = "lblPlantingStep"
        Me.lblPlantingStep.Size = New System.Drawing.Size(63, 13)
        Me.lblPlantingStep.TabIndex = 42
        Me.lblPlantingStep.Tag = ""
        Me.lblPlantingStep.Text = "Step (days):"
        '
        'ucrNudPlantingSeqFrom
        '
        Me.ucrNudPlantingSeqFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSeqFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPlantingSeqFrom.Location = New System.Drawing.Point(133, 82)
        Me.ucrNudPlantingSeqFrom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudPlantingSeqFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPlantingSeqFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSeqFrom.Name = "ucrNudPlantingSeqFrom"
        Me.ucrNudPlantingSeqFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPlantingSeqFrom.TabIndex = 41
        Me.ucrNudPlantingSeqFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblPlantingFrom
        '
        Me.lblPlantingFrom.AutoSize = True
        Me.lblPlantingFrom.Location = New System.Drawing.Point(66, 83)
        Me.lblPlantingFrom.Name = "lblPlantingFrom"
        Me.lblPlantingFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblPlantingFrom.TabIndex = 40
        Me.lblPlantingFrom.Tag = ""
        Me.lblPlantingFrom.Text = "From:"
        '
        'rdPlantingSeq
        '
        Me.rdPlantingSeq.AutoSize = True
        Me.rdPlantingSeq.Location = New System.Drawing.Point(8, 63)
        Me.rdPlantingSeq.Margin = New System.Windows.Forms.Padding(2)
        Me.rdPlantingSeq.Name = "rdPlantingSeq"
        Me.rdPlantingSeq.Size = New System.Drawing.Size(74, 17)
        Me.rdPlantingSeq.TabIndex = 39
        Me.rdPlantingSeq.TabStop = True
        Me.rdPlantingSeq.Text = "Sequence"
        Me.rdPlantingSeq.UseVisualStyleBackColor = True
        '
        'lblPlantingDayNum
        '
        Me.lblPlantingDayNum.AutoSize = True
        Me.lblPlantingDayNum.Location = New System.Drawing.Point(66, 38)
        Me.lblPlantingDayNum.Name = "lblPlantingDayNum"
        Me.lblPlantingDayNum.Size = New System.Drawing.Size(34, 13)
        Me.lblPlantingDayNum.TabIndex = 38
        Me.lblPlantingDayNum.Tag = ""
        Me.lblPlantingDayNum.Text = "Days:"
        '
        'ucrNudPlantingSingleDayNum
        '
        Me.ucrNudPlantingSingleDayNum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSingleDayNum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPlantingSingleDayNum.Location = New System.Drawing.Point(133, 33)
        Me.ucrNudPlantingSingleDayNum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudPlantingSingleDayNum.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPlantingSingleDayNum.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSingleDayNum.Name = "ucrNudPlantingSingleDayNum"
        Me.ucrNudPlantingSingleDayNum.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPlantingSingleDayNum.TabIndex = 37
        Me.ucrNudPlantingSingleDayNum.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdPlantingSingle
        '
        Me.rdPlantingSingle.AutoSize = True
        Me.rdPlantingSingle.Location = New System.Drawing.Point(8, 20)
        Me.rdPlantingSingle.Margin = New System.Windows.Forms.Padding(2)
        Me.rdPlantingSingle.Name = "rdPlantingSingle"
        Me.rdPlantingSingle.Size = New System.Drawing.Size(54, 17)
        Me.rdPlantingSingle.TabIndex = 36
        Me.rdPlantingSingle.TabStop = True
        Me.rdPlantingSingle.Text = "Single"
        Me.rdPlantingSingle.UseVisualStyleBackColor = True
        '
        'ucrPnlLength
        '
        Me.ucrPnlLength.Location = New System.Drawing.Point(6, 14)
        Me.ucrPnlLength.Name = "ucrPnlLength"
        Me.ucrPnlLength.Size = New System.Drawing.Size(152, 141)
        Me.ucrPnlLength.TabIndex = 34
        '
        'grpLength
        '
        Me.grpLength.Controls.Add(Me.ucrNudLengthSeqTo)
        Me.grpLength.Controls.Add(Me.lblLengthTo)
        Me.grpLength.Controls.Add(Me.ucrNudLengthSeqStep)
        Me.grpLength.Controls.Add(Me.lblLengthStep)
        Me.grpLength.Controls.Add(Me.lblLengthFrom)
        Me.grpLength.Controls.Add(Me.rdLengthSeq)
        Me.grpLength.Controls.Add(Me.ucrNudLengthSingleDays)
        Me.grpLength.Controls.Add(Me.lblLengthDay)
        Me.grpLength.Controls.Add(Me.ucrNudLengthSeqFrom)
        Me.grpLength.Controls.Add(Me.rdLengthSingle)
        Me.grpLength.Controls.Add(Me.ucrPnlLength)
        Me.grpLength.Location = New System.Drawing.Point(200, 200)
        Me.grpLength.Name = "grpLength"
        Me.grpLength.Size = New System.Drawing.Size(172, 159)
        Me.grpLength.TabIndex = 35
        Me.grpLength.TabStop = False
        Me.grpLength.Text = "Length (days)"
        '
        'ucrNudLengthSeqTo
        '
        Me.ucrNudLengthSeqTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSeqTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLengthSeqTo.Location = New System.Drawing.Point(122, 131)
        Me.ucrNudLengthSeqTo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudLengthSeqTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLengthSeqTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSeqTo.Name = "ucrNudLengthSeqTo"
        Me.ucrNudLengthSeqTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLengthSeqTo.TabIndex = 43
        Me.ucrNudLengthSeqTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLengthTo
        '
        Me.lblLengthTo.AutoSize = True
        Me.lblLengthTo.Location = New System.Drawing.Point(59, 135)
        Me.lblLengthTo.Name = "lblLengthTo"
        Me.lblLengthTo.Size = New System.Drawing.Size(23, 13)
        Me.lblLengthTo.TabIndex = 42
        Me.lblLengthTo.Tag = ""
        Me.lblLengthTo.Text = "To:"
        '
        'ucrNudLengthSeqStep
        '
        Me.ucrNudLengthSeqStep.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSeqStep.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLengthSeqStep.Location = New System.Drawing.Point(122, 107)
        Me.ucrNudLengthSeqStep.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudLengthSeqStep.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLengthSeqStep.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSeqStep.Name = "ucrNudLengthSeqStep"
        Me.ucrNudLengthSeqStep.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLengthSeqStep.TabIndex = 41
        Me.ucrNudLengthSeqStep.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLengthStep
        '
        Me.lblLengthStep.AutoSize = True
        Me.lblLengthStep.Location = New System.Drawing.Point(59, 107)
        Me.lblLengthStep.Name = "lblLengthStep"
        Me.lblLengthStep.Size = New System.Drawing.Size(63, 13)
        Me.lblLengthStep.TabIndex = 40
        Me.lblLengthStep.Tag = ""
        Me.lblLengthStep.Text = "Step (days):"
        '
        'lblLengthFrom
        '
        Me.lblLengthFrom.AutoSize = True
        Me.lblLengthFrom.Location = New System.Drawing.Point(59, 82)
        Me.lblLengthFrom.Name = "lblLengthFrom"
        Me.lblLengthFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblLengthFrom.TabIndex = 39
        Me.lblLengthFrom.Tag = ""
        Me.lblLengthFrom.Text = "From:"
        '
        'rdLengthSeq
        '
        Me.rdLengthSeq.AutoSize = True
        Me.rdLengthSeq.Location = New System.Drawing.Point(6, 63)
        Me.rdLengthSeq.Margin = New System.Windows.Forms.Padding(2)
        Me.rdLengthSeq.Name = "rdLengthSeq"
        Me.rdLengthSeq.Size = New System.Drawing.Size(74, 17)
        Me.rdLengthSeq.TabIndex = 38
        Me.rdLengthSeq.TabStop = True
        Me.rdLengthSeq.Text = "Sequence"
        Me.rdLengthSeq.UseVisualStyleBackColor = True
        '
        'ucrNudLengthSingleDays
        '
        Me.ucrNudLengthSingleDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSingleDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLengthSingleDays.Location = New System.Drawing.Point(122, 33)
        Me.ucrNudLengthSingleDays.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudLengthSingleDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLengthSingleDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSingleDays.Name = "ucrNudLengthSingleDays"
        Me.ucrNudLengthSingleDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLengthSingleDays.TabIndex = 37
        Me.ucrNudLengthSingleDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLengthDay
        '
        Me.lblLengthDay.AutoSize = True
        Me.lblLengthDay.Location = New System.Drawing.Point(58, 37)
        Me.lblLengthDay.Name = "lblLengthDay"
        Me.lblLengthDay.Size = New System.Drawing.Size(34, 13)
        Me.lblLengthDay.TabIndex = 36
        Me.lblLengthDay.Tag = ""
        Me.lblLengthDay.Text = "Days:"
        '
        'rdLengthSingle
        '
        Me.rdLengthSingle.AutoSize = True
        Me.rdLengthSingle.Location = New System.Drawing.Point(6, 18)
        Me.rdLengthSingle.Margin = New System.Windows.Forms.Padding(2)
        Me.rdLengthSingle.Name = "rdLengthSingle"
        Me.rdLengthSingle.Size = New System.Drawing.Size(54, 17)
        Me.rdLengthSingle.TabIndex = 35
        Me.rdLengthSingle.TabStop = True
        Me.rdLengthSingle.Text = "Single"
        Me.rdLengthSingle.UseVisualStyleBackColor = True
        '
        'grpWater
        '
        Me.grpWater.Controls.Add(Me.ucrNudWaterSeqTo)
        Me.grpWater.Controls.Add(Me.lblWaterTo)
        Me.grpWater.Controls.Add(Me.ucrNudWaterSeqStep)
        Me.grpWater.Controls.Add(Me.lblWaterStep)
        Me.grpWater.Controls.Add(Me.ucrNudWaterSeqFrom)
        Me.grpWater.Controls.Add(Me.lblWaterFrom)
        Me.grpWater.Controls.Add(Me.rdWaterSeq)
        Me.grpWater.Controls.Add(Me.ucrNudWaterSingleAmt)
        Me.grpWater.Controls.Add(Me.lblWaterAmt)
        Me.grpWater.Controls.Add(Me.rdWaterSingle)
        Me.grpWater.Controls.Add(Me.ucrPanlWater)
        Me.grpWater.Location = New System.Drawing.Point(379, 200)
        Me.grpWater.Name = "grpWater"
        Me.grpWater.Size = New System.Drawing.Size(173, 155)
        Me.grpWater.TabIndex = 36
        Me.grpWater.TabStop = False
        Me.grpWater.Text = "Water (mm)"
        '
        'ucrNudWaterSeqTo
        '
        Me.ucrNudWaterSeqTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSeqTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWaterSeqTo.Location = New System.Drawing.Point(118, 128)
        Me.ucrNudWaterSeqTo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudWaterSeqTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWaterSeqTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSeqTo.Name = "ucrNudWaterSeqTo"
        Me.ucrNudWaterSeqTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWaterSeqTo.TabIndex = 47
        Me.ucrNudWaterSeqTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblWaterTo
        '
        Me.lblWaterTo.AutoSize = True
        Me.lblWaterTo.Location = New System.Drawing.Point(65, 135)
        Me.lblWaterTo.Name = "lblWaterTo"
        Me.lblWaterTo.Size = New System.Drawing.Size(23, 13)
        Me.lblWaterTo.TabIndex = 46
        Me.lblWaterTo.Tag = ""
        Me.lblWaterTo.Text = "To:"
        '
        'ucrNudWaterSeqStep
        '
        Me.ucrNudWaterSeqStep.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSeqStep.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWaterSeqStep.Location = New System.Drawing.Point(118, 101)
        Me.ucrNudWaterSeqStep.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudWaterSeqStep.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWaterSeqStep.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSeqStep.Name = "ucrNudWaterSeqStep"
        Me.ucrNudWaterSeqStep.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWaterSeqStep.TabIndex = 45
        Me.ucrNudWaterSeqStep.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblWaterStep
        '
        Me.lblWaterStep.AutoSize = True
        Me.lblWaterStep.Location = New System.Drawing.Point(65, 101)
        Me.lblWaterStep.Name = "lblWaterStep"
        Me.lblWaterStep.Size = New System.Drawing.Size(32, 13)
        Me.lblWaterStep.TabIndex = 44
        Me.lblWaterStep.Tag = ""
        Me.lblWaterStep.Text = "Step:"
        '
        'ucrNudWaterSeqFrom
        '
        Me.ucrNudWaterSeqFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSeqFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWaterSeqFrom.Location = New System.Drawing.Point(118, 76)
        Me.ucrNudWaterSeqFrom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudWaterSeqFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWaterSeqFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSeqFrom.Name = "ucrNudWaterSeqFrom"
        Me.ucrNudWaterSeqFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWaterSeqFrom.TabIndex = 43
        Me.ucrNudWaterSeqFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblWaterFrom
        '
        Me.lblWaterFrom.AutoSize = True
        Me.lblWaterFrom.Location = New System.Drawing.Point(65, 76)
        Me.lblWaterFrom.Name = "lblWaterFrom"
        Me.lblWaterFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblWaterFrom.TabIndex = 42
        Me.lblWaterFrom.Tag = ""
        Me.lblWaterFrom.Text = "From:"
        '
        'rdWaterSeq
        '
        Me.rdWaterSeq.AutoSize = True
        Me.rdWaterSeq.Location = New System.Drawing.Point(7, 57)
        Me.rdWaterSeq.Margin = New System.Windows.Forms.Padding(2)
        Me.rdWaterSeq.Name = "rdWaterSeq"
        Me.rdWaterSeq.Size = New System.Drawing.Size(74, 17)
        Me.rdWaterSeq.TabIndex = 41
        Me.rdWaterSeq.TabStop = True
        Me.rdWaterSeq.Text = "Sequence"
        Me.rdWaterSeq.UseVisualStyleBackColor = True
        '
        'ucrNudWaterSingleAmt
        '
        Me.ucrNudWaterSingleAmt.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSingleAmt.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWaterSingleAmt.Location = New System.Drawing.Point(118, 30)
        Me.ucrNudWaterSingleAmt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudWaterSingleAmt.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWaterSingleAmt.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSingleAmt.Name = "ucrNudWaterSingleAmt"
        Me.ucrNudWaterSingleAmt.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWaterSingleAmt.TabIndex = 40
        Me.ucrNudWaterSingleAmt.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblWaterAmt
        '
        Me.lblWaterAmt.AutoSize = True
        Me.lblWaterAmt.Location = New System.Drawing.Point(65, 30)
        Me.lblWaterAmt.Name = "lblWaterAmt"
        Me.lblWaterAmt.Size = New System.Drawing.Size(46, 13)
        Me.lblWaterAmt.TabIndex = 39
        Me.lblWaterAmt.Tag = ""
        Me.lblWaterAmt.Text = "Amount:"
        '
        'rdWaterSingle
        '
        Me.rdWaterSingle.AutoSize = True
        Me.rdWaterSingle.Location = New System.Drawing.Point(7, 18)
        Me.rdWaterSingle.Margin = New System.Windows.Forms.Padding(2)
        Me.rdWaterSingle.Name = "rdWaterSingle"
        Me.rdWaterSingle.Size = New System.Drawing.Size(54, 17)
        Me.rdWaterSingle.TabIndex = 38
        Me.rdWaterSingle.TabStop = True
        Me.rdWaterSingle.Text = "Single"
        Me.rdWaterSingle.UseVisualStyleBackColor = True
        '
        'ucrPanlWater
        '
        Me.ucrPanlWater.Location = New System.Drawing.Point(3, 18)
        Me.ucrPanlWater.Name = "ucrPanlWater"
        Me.ucrPanlWater.Size = New System.Drawing.Size(165, 130)
        Me.ucrPanlWater.TabIndex = 37
        '
        'dlgPICSACrops
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 450)
        Me.Controls.Add(Me.grpWater)
        Me.Controls.Add(Me.grpLength)
        Me.Controls.Add(Me.grpPlantingDate)
        Me.Controls.Add(Me.ucrSaveDataFrame)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrReceiverEnd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrReceiverStart)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverRainfall)
        Me.Controls.Add(Me.ucrReceiverDay)
        Me.Controls.Add(Me.lblSelectedSet)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorForCrops)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPICSACrops"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PICSA Crops"
        Me.grpPlantingDate.ResumeLayout(False)
        Me.grpPlantingDate.PerformLayout()
        Me.grpLength.ResumeLayout(False)
        Me.grpLength.PerformLayout()
        Me.grpWater.ResumeLayout(False)
        Me.grpWater.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForCrops As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrReceiverStart As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents ucrReceiverDay As ucrReceiverSingle
    Friend WithEvents lblSelectedSet As Label
    Friend WithEvents ucrReceiverEnd As ucrReceiverSingle
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrSaveDataFrame As ucrSave
    Friend WithEvents ucrNudLengthSeqFrom As ucrNud
    Friend WithEvents ucrPnlPlantingDate As UcrPanel
    Friend WithEvents grpPlantingDate As GroupBox
    Friend WithEvents ucrNudPlantingSeqTo As ucrNud
    Friend WithEvents lblPlantingTo As Label
    Friend WithEvents ucrNudPlantingSeqStep As ucrNud
    Friend WithEvents lblPlantingStep As Label
    Friend WithEvents ucrNudPlantingSeqFrom As ucrNud
    Friend WithEvents lblPlantingFrom As Label
    Friend WithEvents rdPlantingSeq As RadioButton
    Friend WithEvents lblPlantingDayNum As Label
    Friend WithEvents ucrNudPlantingSingleDayNum As ucrNud
    Friend WithEvents rdPlantingSingle As RadioButton
    Friend WithEvents grpLength As GroupBox
    Friend WithEvents ucrPnlLength As UcrPanel
    Friend WithEvents ucrNudLengthSeqTo As ucrNud
    Friend WithEvents lblLengthTo As Label
    Friend WithEvents ucrNudLengthSeqStep As ucrNud
    Friend WithEvents lblLengthStep As Label
    Friend WithEvents lblLengthFrom As Label
    Friend WithEvents rdLengthSeq As RadioButton
    Friend WithEvents ucrNudLengthSingleDays As ucrNud
    Friend WithEvents lblLengthDay As Label
    Friend WithEvents rdLengthSingle As RadioButton
    Friend WithEvents grpWater As GroupBox
    Friend WithEvents ucrNudWaterSeqTo As ucrNud
    Friend WithEvents lblWaterTo As Label
    Friend WithEvents ucrNudWaterSeqStep As ucrNud
    Friend WithEvents lblWaterStep As Label
    Friend WithEvents ucrNudWaterSeqFrom As ucrNud
    Friend WithEvents lblWaterFrom As Label
    Friend WithEvents rdWaterSeq As RadioButton
    Friend WithEvents ucrNudWaterSingleAmt As ucrNud
    Friend WithEvents lblWaterAmt As Label
    Friend WithEvents rdWaterSingle As RadioButton
    Friend WithEvents ucrPanlWater As UcrPanel
End Class
