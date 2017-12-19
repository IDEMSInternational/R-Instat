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
        Me.grpPlantDate = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rdPlantSeq = New System.Windows.Forms.RadioButton()
        Me.rdPlantSingle = New System.Windows.Forms.RadioButton()
        Me.grpLength = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rdLengthSeq = New System.Windows.Forms.RadioButton()
        Me.rdLengthSingle = New System.Windows.Forms.RadioButton()
        Me.grpWater = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.rdWaterSeq = New System.Windows.Forms.RadioButton()
        Me.rdWaterSingle = New System.Windows.Forms.RadioButton()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrSaveDataFrame = New instat.ucrSave()
        Me.UcrNudWaterSeqTo = New instat.ucrNud()
        Me.UcrNudWaterSeqStep = New instat.ucrNud()
        Me.UcrNudWaterSingleDayNum = New instat.ucrNud()
        Me.UcrNudWaterSeqFrom = New instat.ucrNud()
        Me.UcrNudLengthSeqTo = New instat.ucrNud()
        Me.UcrNudLengthSeqStep = New instat.ucrNud()
        Me.UcrNudLengthSingleDayNum = New instat.ucrNud()
        Me.UcrNudLengthSeqFrom = New instat.ucrNud()
        Me.UcrNudPlantSeqTo = New instat.ucrNud()
        Me.UcrNudPlantSeqStep = New instat.ucrNud()
        Me.UcrNudPlantSingleDayNum = New instat.ucrNud()
        Me.UcrNudPlantSeqFrom = New instat.ucrNud()
        Me.UcrReceiverEnd = New instat.ucrReceiverSingle()
        Me.UcrReceiverStart = New instat.ucrReceiverSingle()
        Me.UcrReceiverDate = New instat.ucrReceiverSingle()
        Me.UcrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.UcrReceiverDay = New instat.ucrReceiverSingle()
        Me.UcrReceiverYear = New instat.ucrReceiverSingle()
        Me.UcrReceiverStation = New instat.ucrReceiverSingle()
        Me.UcrSelectorForCrops = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpPlantDate.SuspendLayout()
        Me.grpLength.SuspendLayout()
        Me.grpWater.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedSet
        '
        Me.lblSelectedSet.AutoSize = True
        Me.lblSelectedSet.Location = New System.Drawing.Point(380, 9)
        Me.lblSelectedSet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedSet.Name = "lblSelectedSet"
        Me.lblSelectedSet.Size = New System.Drawing.Size(68, 20)
        Me.lblSelectedSet.TabIndex = 15
        Me.lblSelectedSet.Tag = ""
        Me.lblSelectedSet.Text = "Station :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(403, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Tag = ""
        Me.Label1.Text = "Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(404, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Tag = ""
        Me.Label2.Text = "Year :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(410, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Tag = ""
        Me.Label3.Text = "Day :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(381, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Tag = ""
        Me.Label4.Text = "Rainfall :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(399, 229)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Tag = ""
        Me.Label5.Text = "Start :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(402, 264)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Tag = ""
        Me.Label6.Text = "End :"
        '
        'grpPlantDate
        '
        Me.grpPlantDate.Controls.Add(Me.Label10)
        Me.grpPlantDate.Controls.Add(Me.Label9)
        Me.grpPlantDate.Controls.Add(Me.Label8)
        Me.grpPlantDate.Controls.Add(Me.UcrNudPlantSeqTo)
        Me.grpPlantDate.Controls.Add(Me.UcrNudPlantSeqStep)
        Me.grpPlantDate.Controls.Add(Me.UcrNudPlantSingleDayNum)
        Me.grpPlantDate.Controls.Add(Me.UcrNudPlantSeqFrom)
        Me.grpPlantDate.Controls.Add(Me.Label7)
        Me.grpPlantDate.Controls.Add(Me.rdPlantSeq)
        Me.grpPlantDate.Controls.Add(Me.rdPlantSingle)
        Me.grpPlantDate.Location = New System.Drawing.Point(10, 307)
        Me.grpPlantDate.Name = "grpPlantDate"
        Me.grpPlantDate.Size = New System.Drawing.Size(262, 244)
        Me.grpPlantDate.TabIndex = 27
        Me.grpPlantDate.TabStop = False
        Me.grpPlantDate.Text = "Plant Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(57, 66)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 20)
        Me.Label10.TabIndex = 34
        Me.Label10.Tag = ""
        Me.Label10.Text = "Day Number :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(133, 211)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 20)
        Me.Label9.TabIndex = 34
        Me.Label9.Tag = ""
        Me.Label9.Text = "To :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(80, 176)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.TabIndex = 33
        Me.Label8.Tag = ""
        Me.Label8.Text = "Step (Day) :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(114, 142)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Tag = ""
        Me.Label7.Text = "From :"
        '
        'rdPlantSeq
        '
        Me.rdPlantSeq.AutoSize = True
        Me.rdPlantSeq.Location = New System.Drawing.Point(24, 110)
        Me.rdPlantSeq.Name = "rdPlantSeq"
        Me.rdPlantSeq.Size = New System.Drawing.Size(107, 24)
        Me.rdPlantSeq.TabIndex = 2
        Me.rdPlantSeq.TabStop = True
        Me.rdPlantSeq.Text = "Sequence"
        Me.rdPlantSeq.UseVisualStyleBackColor = True
        '
        'rdPlantSingle
        '
        Me.rdPlantSingle.AutoSize = True
        Me.rdPlantSingle.Location = New System.Drawing.Point(24, 36)
        Me.rdPlantSingle.Name = "rdPlantSingle"
        Me.rdPlantSingle.Size = New System.Drawing.Size(78, 24)
        Me.rdPlantSingle.TabIndex = 0
        Me.rdPlantSingle.TabStop = True
        Me.rdPlantSingle.Text = "Single"
        Me.rdPlantSingle.UseVisualStyleBackColor = True
        '
        'grpLength
        '
        Me.grpLength.Controls.Add(Me.Label11)
        Me.grpLength.Controls.Add(Me.Label12)
        Me.grpLength.Controls.Add(Me.Label13)
        Me.grpLength.Controls.Add(Me.UcrNudLengthSeqTo)
        Me.grpLength.Controls.Add(Me.UcrNudLengthSeqStep)
        Me.grpLength.Controls.Add(Me.UcrNudLengthSingleDayNum)
        Me.grpLength.Controls.Add(Me.UcrNudLengthSeqFrom)
        Me.grpLength.Controls.Add(Me.Label14)
        Me.grpLength.Controls.Add(Me.rdLengthSeq)
        Me.grpLength.Controls.Add(Me.rdLengthSingle)
        Me.grpLength.Location = New System.Drawing.Point(278, 307)
        Me.grpLength.Name = "grpLength"
        Me.grpLength.Size = New System.Drawing.Size(262, 244)
        Me.grpLength.TabIndex = 28
        Me.grpLength.TabStop = False
        Me.grpLength.Text = "Length (days)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(57, 66)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 20)
        Me.Label11.TabIndex = 34
        Me.Label11.Tag = ""
        Me.Label11.Text = "Day Number :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(133, 211)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 20)
        Me.Label12.TabIndex = 34
        Me.Label12.Tag = ""
        Me.Label12.Text = "To :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(80, 176)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 20)
        Me.Label13.TabIndex = 33
        Me.Label13.Tag = ""
        Me.Label13.Text = "Step (Day) :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(114, 142)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 20)
        Me.Label14.TabIndex = 28
        Me.Label14.Tag = ""
        Me.Label14.Text = "From :"
        '
        'rdLengthSeq
        '
        Me.rdLengthSeq.AutoSize = True
        Me.rdLengthSeq.Location = New System.Drawing.Point(24, 110)
        Me.rdLengthSeq.Name = "rdLengthSeq"
        Me.rdLengthSeq.Size = New System.Drawing.Size(107, 24)
        Me.rdLengthSeq.TabIndex = 2
        Me.rdLengthSeq.TabStop = True
        Me.rdLengthSeq.Text = "Sequence"
        Me.rdLengthSeq.UseVisualStyleBackColor = True
        '
        'rdLengthSingle
        '
        Me.rdLengthSingle.AutoSize = True
        Me.rdLengthSingle.Location = New System.Drawing.Point(24, 36)
        Me.rdLengthSingle.Name = "rdLengthSingle"
        Me.rdLengthSingle.Size = New System.Drawing.Size(78, 24)
        Me.rdLengthSingle.TabIndex = 0
        Me.rdLengthSingle.TabStop = True
        Me.rdLengthSingle.Text = "Single"
        Me.rdLengthSingle.UseVisualStyleBackColor = True
        '
        'grpWater
        '
        Me.grpWater.Controls.Add(Me.Label15)
        Me.grpWater.Controls.Add(Me.Label16)
        Me.grpWater.Controls.Add(Me.Label17)
        Me.grpWater.Controls.Add(Me.UcrNudWaterSeqTo)
        Me.grpWater.Controls.Add(Me.UcrNudWaterSeqStep)
        Me.grpWater.Controls.Add(Me.UcrNudWaterSingleDayNum)
        Me.grpWater.Controls.Add(Me.UcrNudWaterSeqFrom)
        Me.grpWater.Controls.Add(Me.Label18)
        Me.grpWater.Controls.Add(Me.rdWaterSeq)
        Me.grpWater.Controls.Add(Me.rdWaterSingle)
        Me.grpWater.Location = New System.Drawing.Point(546, 307)
        Me.grpWater.Name = "grpWater"
        Me.grpWater.Size = New System.Drawing.Size(262, 244)
        Me.grpWater.TabIndex = 29
        Me.grpWater.TabStop = False
        Me.grpWater.Text = "Water (mm)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(57, 66)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 20)
        Me.Label15.TabIndex = 34
        Me.Label15.Tag = ""
        Me.Label15.Text = "Day Number :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(133, 211)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 20)
        Me.Label16.TabIndex = 34
        Me.Label16.Tag = ""
        Me.Label16.Text = "To :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(80, 176)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 20)
        Me.Label17.TabIndex = 33
        Me.Label17.Tag = ""
        Me.Label17.Text = "Step (mm) :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(114, 142)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 20)
        Me.Label18.TabIndex = 28
        Me.Label18.Tag = ""
        Me.Label18.Text = "From :"
        '
        'rdWaterSeq
        '
        Me.rdWaterSeq.AutoSize = True
        Me.rdWaterSeq.Location = New System.Drawing.Point(24, 110)
        Me.rdWaterSeq.Name = "rdWaterSeq"
        Me.rdWaterSeq.Size = New System.Drawing.Size(107, 24)
        Me.rdWaterSeq.TabIndex = 2
        Me.rdWaterSeq.TabStop = True
        Me.rdWaterSeq.Text = "Sequence"
        Me.rdWaterSeq.UseVisualStyleBackColor = True
        '
        'rdWaterSingle
        '
        Me.rdWaterSingle.AutoSize = True
        Me.rdWaterSingle.Location = New System.Drawing.Point(24, 36)
        Me.rdWaterSingle.Name = "rdWaterSingle"
        Me.rdWaterSingle.Size = New System.Drawing.Size(78, 24)
        Me.rdWaterSingle.TabIndex = 0
        Me.rdWaterSingle.TabStop = True
        Me.rdWaterSingle.Text = "Single"
        Me.rdWaterSingle.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(626, 557)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(180, 38)
        Me.cmdOptions.TabIndex = 31
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrSaveDataFrame
        '
        Me.ucrSaveDataFrame.Location = New System.Drawing.Point(7, 558)
        Me.ucrSaveDataFrame.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveDataFrame.Name = "ucrSaveDataFrame"
        Me.ucrSaveDataFrame.Size = New System.Drawing.Size(410, 37)
        Me.ucrSaveDataFrame.TabIndex = 30
        '
        'UcrNudWaterSeqTo
        '
        Me.UcrNudWaterSeqTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudWaterSeqTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNudWaterSeqTo.Location = New System.Drawing.Point(178, 207)
        Me.UcrNudWaterSeqTo.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcrNudWaterSeqTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudWaterSeqTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudWaterSeqTo.Name = "UcrNudWaterSeqTo"
        Me.UcrNudWaterSeqTo.Size = New System.Drawing.Size(75, 31)
        Me.UcrNudWaterSeqTo.TabIndex = 32
        Me.UcrNudWaterSeqTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrNudWaterSeqStep
        '
        Me.UcrNudWaterSeqStep.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudWaterSeqStep.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNudWaterSeqStep.Location = New System.Drawing.Point(178, 172)
        Me.UcrNudWaterSeqStep.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcrNudWaterSeqStep.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudWaterSeqStep.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudWaterSeqStep.Name = "UcrNudWaterSeqStep"
        Me.UcrNudWaterSeqStep.Size = New System.Drawing.Size(75, 31)
        Me.UcrNudWaterSeqStep.TabIndex = 31
        Me.UcrNudWaterSeqStep.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrNudWaterSingleDayNum
        '
        Me.UcrNudWaterSingleDayNum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudWaterSingleDayNum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNudWaterSingleDayNum.Location = New System.Drawing.Point(175, 63)
        Me.UcrNudWaterSingleDayNum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcrNudWaterSingleDayNum.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudWaterSingleDayNum.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudWaterSingleDayNum.Name = "UcrNudWaterSingleDayNum"
        Me.UcrNudWaterSingleDayNum.Size = New System.Drawing.Size(75, 31)
        Me.UcrNudWaterSingleDayNum.TabIndex = 30
        Me.UcrNudWaterSingleDayNum.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrNudWaterSeqFrom
        '
        Me.UcrNudWaterSeqFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudWaterSeqFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNudWaterSeqFrom.Location = New System.Drawing.Point(178, 139)
        Me.UcrNudWaterSeqFrom.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcrNudWaterSeqFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudWaterSeqFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudWaterSeqFrom.Name = "UcrNudWaterSeqFrom"
        Me.UcrNudWaterSeqFrom.Size = New System.Drawing.Size(75, 31)
        Me.UcrNudWaterSeqFrom.TabIndex = 29
        Me.UcrNudWaterSeqFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrNudLengthSeqTo
        '
        Me.UcrNudLengthSeqTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudLengthSeqTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNudLengthSeqTo.Location = New System.Drawing.Point(178, 207)
        Me.UcrNudLengthSeqTo.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcrNudLengthSeqTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudLengthSeqTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudLengthSeqTo.Name = "UcrNudLengthSeqTo"
        Me.UcrNudLengthSeqTo.Size = New System.Drawing.Size(75, 31)
        Me.UcrNudLengthSeqTo.TabIndex = 32
        Me.UcrNudLengthSeqTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrNudLengthSeqStep
        '
        Me.UcrNudLengthSeqStep.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudLengthSeqStep.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNudLengthSeqStep.Location = New System.Drawing.Point(178, 172)
        Me.UcrNudLengthSeqStep.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcrNudLengthSeqStep.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudLengthSeqStep.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudLengthSeqStep.Name = "UcrNudLengthSeqStep"
        Me.UcrNudLengthSeqStep.Size = New System.Drawing.Size(75, 31)
        Me.UcrNudLengthSeqStep.TabIndex = 31
        Me.UcrNudLengthSeqStep.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrNudLengthSingleDayNum
        '
        Me.UcrNudLengthSingleDayNum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudLengthSingleDayNum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNudLengthSingleDayNum.Location = New System.Drawing.Point(175, 63)
        Me.UcrNudLengthSingleDayNum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcrNudLengthSingleDayNum.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudLengthSingleDayNum.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudLengthSingleDayNum.Name = "UcrNudLengthSingleDayNum"
        Me.UcrNudLengthSingleDayNum.Size = New System.Drawing.Size(75, 31)
        Me.UcrNudLengthSingleDayNum.TabIndex = 30
        Me.UcrNudLengthSingleDayNum.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrNudLengthSeqFrom
        '
        Me.UcrNudLengthSeqFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudLengthSeqFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNudLengthSeqFrom.Location = New System.Drawing.Point(178, 139)
        Me.UcrNudLengthSeqFrom.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcrNudLengthSeqFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudLengthSeqFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudLengthSeqFrom.Name = "UcrNudLengthSeqFrom"
        Me.UcrNudLengthSeqFrom.Size = New System.Drawing.Size(75, 31)
        Me.UcrNudLengthSeqFrom.TabIndex = 29
        Me.UcrNudLengthSeqFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrNudPlantSeqTo
        '
        Me.UcrNudPlantSeqTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudPlantSeqTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNudPlantSeqTo.Location = New System.Drawing.Point(178, 207)
        Me.UcrNudPlantSeqTo.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcrNudPlantSeqTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudPlantSeqTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudPlantSeqTo.Name = "UcrNudPlantSeqTo"
        Me.UcrNudPlantSeqTo.Size = New System.Drawing.Size(75, 31)
        Me.UcrNudPlantSeqTo.TabIndex = 32
        Me.UcrNudPlantSeqTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrNudPlantSeqStep
        '
        Me.UcrNudPlantSeqStep.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudPlantSeqStep.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNudPlantSeqStep.Location = New System.Drawing.Point(178, 172)
        Me.UcrNudPlantSeqStep.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcrNudPlantSeqStep.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudPlantSeqStep.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudPlantSeqStep.Name = "UcrNudPlantSeqStep"
        Me.UcrNudPlantSeqStep.Size = New System.Drawing.Size(75, 31)
        Me.UcrNudPlantSeqStep.TabIndex = 31
        Me.UcrNudPlantSeqStep.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrNudPlantSingleDayNum
        '
        Me.UcrNudPlantSingleDayNum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudPlantSingleDayNum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNudPlantSingleDayNum.Location = New System.Drawing.Point(175, 63)
        Me.UcrNudPlantSingleDayNum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcrNudPlantSingleDayNum.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudPlantSingleDayNum.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudPlantSingleDayNum.Name = "UcrNudPlantSingleDayNum"
        Me.UcrNudPlantSingleDayNum.Size = New System.Drawing.Size(75, 31)
        Me.UcrNudPlantSingleDayNum.TabIndex = 30
        Me.UcrNudPlantSingleDayNum.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrNudPlantSeqFrom
        '
        Me.UcrNudPlantSeqFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudPlantSeqFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNudPlantSeqFrom.Location = New System.Drawing.Point(178, 139)
        Me.UcrNudPlantSeqFrom.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcrNudPlantSeqFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudPlantSeqFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudPlantSeqFrom.Name = "UcrNudPlantSeqFrom"
        Me.UcrNudPlantSeqFrom.Size = New System.Drawing.Size(75, 31)
        Me.UcrNudPlantSeqFrom.TabIndex = 29
        Me.UcrNudPlantSeqFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrReceiverEnd
        '
        Me.UcrReceiverEnd.frmParent = Me
        Me.UcrReceiverEnd.Location = New System.Drawing.Point(461, 264)
        Me.UcrReceiverEnd.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverEnd.Name = "UcrReceiverEnd"
        Me.UcrReceiverEnd.Selector = Nothing
        Me.UcrReceiverEnd.Size = New System.Drawing.Size(180, 31)
        Me.UcrReceiverEnd.strNcFilePath = ""
        Me.UcrReceiverEnd.TabIndex = 26
        Me.UcrReceiverEnd.ucrSelector = Nothing
        '
        'UcrReceiverStart
        '
        Me.UcrReceiverStart.frmParent = Me
        Me.UcrReceiverStart.Location = New System.Drawing.Point(461, 229)
        Me.UcrReceiverStart.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverStart.Name = "UcrReceiverStart"
        Me.UcrReceiverStart.Selector = Nothing
        Me.UcrReceiverStart.Size = New System.Drawing.Size(180, 31)
        Me.UcrReceiverStart.strNcFilePath = ""
        Me.UcrReceiverStart.TabIndex = 19
        Me.UcrReceiverStart.ucrSelector = Nothing
        '
        'UcrReceiverDate
        '
        Me.UcrReceiverDate.frmParent = Me
        Me.UcrReceiverDate.Location = New System.Drawing.Point(461, 43)
        Me.UcrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverDate.Name = "UcrReceiverDate"
        Me.UcrReceiverDate.Selector = Nothing
        Me.UcrReceiverDate.Size = New System.Drawing.Size(180, 31)
        Me.UcrReceiverDate.strNcFilePath = ""
        Me.UcrReceiverDate.TabIndex = 18
        Me.UcrReceiverDate.ucrSelector = Nothing
        '
        'UcrReceiverRainfall
        '
        Me.UcrReceiverRainfall.frmParent = Me
        Me.UcrReceiverRainfall.Location = New System.Drawing.Point(461, 151)
        Me.UcrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverRainfall.Name = "UcrReceiverRainfall"
        Me.UcrReceiverRainfall.Selector = Nothing
        Me.UcrReceiverRainfall.Size = New System.Drawing.Size(180, 31)
        Me.UcrReceiverRainfall.strNcFilePath = ""
        Me.UcrReceiverRainfall.TabIndex = 17
        Me.UcrReceiverRainfall.ucrSelector = Nothing
        '
        'UcrReceiverDay
        '
        Me.UcrReceiverDay.frmParent = Me
        Me.UcrReceiverDay.Location = New System.Drawing.Point(461, 115)
        Me.UcrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverDay.Name = "UcrReceiverDay"
        Me.UcrReceiverDay.Selector = Nothing
        Me.UcrReceiverDay.Size = New System.Drawing.Size(180, 31)
        Me.UcrReceiverDay.strNcFilePath = ""
        Me.UcrReceiverDay.TabIndex = 16
        Me.UcrReceiverDay.ucrSelector = Nothing
        '
        'UcrReceiverYear
        '
        Me.UcrReceiverYear.frmParent = Me
        Me.UcrReceiverYear.Location = New System.Drawing.Point(461, 81)
        Me.UcrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverYear.Name = "UcrReceiverYear"
        Me.UcrReceiverYear.Selector = Nothing
        Me.UcrReceiverYear.Size = New System.Drawing.Size(180, 31)
        Me.UcrReceiverYear.strNcFilePath = ""
        Me.UcrReceiverYear.TabIndex = 3
        Me.UcrReceiverYear.ucrSelector = Nothing
        '
        'UcrReceiverStation
        '
        Me.UcrReceiverStation.frmParent = Me
        Me.UcrReceiverStation.Location = New System.Drawing.Point(461, 9)
        Me.UcrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverStation.Name = "UcrReceiverStation"
        Me.UcrReceiverStation.Selector = Nothing
        Me.UcrReceiverStation.Size = New System.Drawing.Size(180, 31)
        Me.UcrReceiverStation.strNcFilePath = ""
        Me.UcrReceiverStation.TabIndex = 2
        Me.UcrReceiverStation.ucrSelector = Nothing
        '
        'UcrSelectorForCrops
        '
        Me.UcrSelectorForCrops.bShowHiddenColumns = False
        Me.UcrSelectorForCrops.bUseCurrentFilter = True
        Me.UcrSelectorForCrops.Location = New System.Drawing.Point(9, 7)
        Me.UcrSelectorForCrops.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrSelectorForCrops.Name = "UcrSelectorForCrops"
        Me.UcrSelectorForCrops.Size = New System.Drawing.Size(315, 277)
        Me.UcrSelectorForCrops.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 603)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(615, 80)
        Me.ucrBase.TabIndex = 0
        '
        'dlgPICSACrops
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 692)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrSaveDataFrame)
        Me.Controls.Add(Me.grpWater)
        Me.Controls.Add(Me.grpLength)
        Me.Controls.Add(Me.grpPlantDate)
        Me.Controls.Add(Me.UcrReceiverEnd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UcrReceiverStart)
        Me.Controls.Add(Me.UcrReceiverDate)
        Me.Controls.Add(Me.UcrReceiverRainfall)
        Me.Controls.Add(Me.UcrReceiverDay)
        Me.Controls.Add(Me.lblSelectedSet)
        Me.Controls.Add(Me.UcrReceiverYear)
        Me.Controls.Add(Me.UcrReceiverStation)
        Me.Controls.Add(Me.UcrSelectorForCrops)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPICSACrops"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PICSA Crops"
        Me.grpPlantDate.ResumeLayout(False)
        Me.grpPlantDate.PerformLayout()
        Me.grpLength.ResumeLayout(False)
        Me.grpLength.PerformLayout()
        Me.grpWater.ResumeLayout(False)
        Me.grpWater.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents UcrSelectorForCrops As ucrSelectorByDataFrameAddRemove
    Friend WithEvents UcrReceiverStation As ucrReceiverSingle
    Friend WithEvents UcrReceiverYear As ucrReceiverSingle
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UcrReceiverStart As ucrReceiverSingle
    Friend WithEvents UcrReceiverDate As ucrReceiverSingle
    Friend WithEvents UcrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents UcrReceiverDay As ucrReceiverSingle
    Friend WithEvents lblSelectedSet As Label
    Friend WithEvents UcrReceiverEnd As ucrReceiverSingle
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents grpPlantDate As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents UcrNudPlantSeqTo As ucrNud
    Friend WithEvents UcrNudPlantSeqStep As ucrNud
    Friend WithEvents UcrNudPlantSingleDayNum As ucrNud
    Friend WithEvents UcrNudPlantSeqFrom As ucrNud
    Friend WithEvents Label7 As Label
    Friend WithEvents rdPlantSeq As RadioButton
    Friend WithEvents rdPlantSingle As RadioButton
    Friend WithEvents ucrSaveDataFrame As ucrSave
    Friend WithEvents grpWater As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents UcrNudWaterSeqTo As ucrNud
    Friend WithEvents UcrNudWaterSeqStep As ucrNud
    Friend WithEvents UcrNudWaterSingleDayNum As ucrNud
    Friend WithEvents UcrNudWaterSeqFrom As ucrNud
    Friend WithEvents Label18 As Label
    Friend WithEvents rdWaterSeq As RadioButton
    Friend WithEvents rdWaterSingle As RadioButton
    Friend WithEvents grpLength As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents UcrNudLengthSeqTo As ucrNud
    Friend WithEvents UcrNudLengthSeqStep As ucrNud
    Friend WithEvents UcrNudLengthSingleDayNum As ucrNud
    Friend WithEvents UcrNudLengthSeqFrom As ucrNud
    Friend WithEvents Label14 As Label
    Friend WithEvents rdLengthSeq As RadioButton
    Friend WithEvents rdLengthSingle As RadioButton
    Friend WithEvents cmdOptions As Button
End Class
