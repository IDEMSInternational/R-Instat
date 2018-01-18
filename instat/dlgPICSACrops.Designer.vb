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
        Me.lblPlantingDayNum = New System.Windows.Forms.Label()
        Me.lblPlantingTo = New System.Windows.Forms.Label()
        Me.lblPlantingStep = New System.Windows.Forms.Label()
        Me.ucrNudPlantingSeqTo = New instat.ucrNud()
        Me.ucrNudPlantingSeqStep = New instat.ucrNud()
        Me.ucrNudPlantingSingleDayNum = New instat.ucrNud()
        Me.ucrNudPlantingSeqFrom = New instat.ucrNud()
        Me.lblPlantingFrom = New System.Windows.Forms.Label()
        Me.rdPlantingSeq = New System.Windows.Forms.RadioButton()
        Me.rdPlantingSingle = New System.Windows.Forms.RadioButton()
        Me.grpLength = New System.Windows.Forms.GroupBox()
        Me.lblLengthDay = New System.Windows.Forms.Label()
        Me.lblLengthTo = New System.Windows.Forms.Label()
        Me.lblLengthStep = New System.Windows.Forms.Label()
        Me.ucrNudLengthSeqTo = New instat.ucrNud()
        Me.ucrNudLengthSeqStep = New instat.ucrNud()
        Me.ucrNudLengthSingleDays = New instat.ucrNud()
        Me.ucrNudLengthSeqFrom = New instat.ucrNud()
        Me.lblLengthFrom = New System.Windows.Forms.Label()
        Me.rdLengthSeq = New System.Windows.Forms.RadioButton()
        Me.rdLengthSingle = New System.Windows.Forms.RadioButton()
        Me.grpWater = New System.Windows.Forms.GroupBox()
        Me.lblWaterAmt = New System.Windows.Forms.Label()
        Me.lblWaterTo = New System.Windows.Forms.Label()
        Me.lblWaterStep = New System.Windows.Forms.Label()
        Me.ucrNudWaterSeqTo = New instat.ucrNud()
        Me.ucrNudWaterSeqStep = New instat.ucrNud()
        Me.ucrNudWaterSingleAmt = New instat.ucrNud()
        Me.ucrNudWaterSeqFrom = New instat.ucrNud()
        Me.lblWaterFrom = New System.Windows.Forms.Label()
        Me.rdWaterSeq = New System.Windows.Forms.RadioButton()
        Me.rdWaterSingle = New System.Windows.Forms.RadioButton()
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
        Me.grpPlantDate.SuspendLayout()
        Me.grpLength.SuspendLayout()
        Me.grpWater.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedSet
        '
        Me.lblSelectedSet.AutoSize = True
        Me.lblSelectedSet.Location = New System.Drawing.Point(383, 9)
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
        Me.Label1.Location = New System.Drawing.Point(383, 71)
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
        Me.Label2.Location = New System.Drawing.Point(619, 9)
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
        Me.Label3.Location = New System.Drawing.Point(619, 71)
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
        Me.Label4.Location = New System.Drawing.Point(619, 135)
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
        Me.Label5.Location = New System.Drawing.Point(383, 170)
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
        Me.Label6.Location = New System.Drawing.Point(383, 226)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Tag = ""
        Me.Label6.Text = "End :"
        '
        'grpPlantDate
        '
        Me.grpPlantDate.Controls.Add(Me.lblPlantingDayNum)
        Me.grpPlantDate.Controls.Add(Me.lblPlantingTo)
        Me.grpPlantDate.Controls.Add(Me.lblPlantingStep)
        Me.grpPlantDate.Controls.Add(Me.ucrNudPlantingSeqTo)
        Me.grpPlantDate.Controls.Add(Me.ucrNudPlantingSeqStep)
        Me.grpPlantDate.Controls.Add(Me.ucrNudPlantingSingleDayNum)
        Me.grpPlantDate.Controls.Add(Me.ucrNudPlantingSeqFrom)
        Me.grpPlantDate.Controls.Add(Me.lblPlantingFrom)
        Me.grpPlantDate.Controls.Add(Me.rdPlantingSeq)
        Me.grpPlantDate.Controls.Add(Me.rdPlantingSingle)
        Me.grpPlantDate.Location = New System.Drawing.Point(10, 307)
        Me.grpPlantDate.Name = "grpPlantDate"
        Me.grpPlantDate.Size = New System.Drawing.Size(262, 244)
        Me.grpPlantDate.TabIndex = 27
        Me.grpPlantDate.TabStop = False
        Me.grpPlantDate.Text = "Planting Date"
        '
        'lblPlantingDayNum
        '
        Me.lblPlantingDayNum.AutoSize = True
        Me.lblPlantingDayNum.Location = New System.Drawing.Point(57, 66)
        Me.lblPlantingDayNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantingDayNum.Name = "lblPlantingDayNum"
        Me.lblPlantingDayNum.Size = New System.Drawing.Size(105, 20)
        Me.lblPlantingDayNum.TabIndex = 34
        Me.lblPlantingDayNum.Tag = ""
        Me.lblPlantingDayNum.Text = "Day Number :"
        '
        'lblPlantingTo
        '
        Me.lblPlantingTo.AutoSize = True
        Me.lblPlantingTo.Location = New System.Drawing.Point(127, 211)
        Me.lblPlantingTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantingTo.Name = "lblPlantingTo"
        Me.lblPlantingTo.Size = New System.Drawing.Size(35, 20)
        Me.lblPlantingTo.TabIndex = 34
        Me.lblPlantingTo.Tag = ""
        Me.lblPlantingTo.Text = "To :"
        '
        'lblPlantingStep
        '
        Me.lblPlantingStep.AutoSize = True
        Me.lblPlantingStep.Location = New System.Drawing.Point(70, 176)
        Me.lblPlantingStep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantingStep.Name = "lblPlantingStep"
        Me.lblPlantingStep.Size = New System.Drawing.Size(98, 20)
        Me.lblPlantingStep.TabIndex = 33
        Me.lblPlantingStep.Tag = ""
        Me.lblPlantingStep.Text = "Step (days) :"
        '
        'ucrNudPlantingSeqTo
        '
        Me.ucrNudPlantingSeqTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSeqTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPlantingSeqTo.Location = New System.Drawing.Point(178, 207)
        Me.ucrNudPlantingSeqTo.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrNudPlantingSeqTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPlantingSeqTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSeqTo.Name = "ucrNudPlantingSeqTo"
        Me.ucrNudPlantingSeqTo.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudPlantingSeqTo.TabIndex = 32
        Me.ucrNudPlantingSeqTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudPlantingSeqStep
        '
        Me.ucrNudPlantingSeqStep.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSeqStep.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPlantingSeqStep.Location = New System.Drawing.Point(178, 172)
        Me.ucrNudPlantingSeqStep.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrNudPlantingSeqStep.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPlantingSeqStep.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSeqStep.Name = "ucrNudPlantingSeqStep"
        Me.ucrNudPlantingSeqStep.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudPlantingSeqStep.TabIndex = 31
        Me.ucrNudPlantingSeqStep.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudPlantingSingleDayNum
        '
        Me.ucrNudPlantingSingleDayNum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSingleDayNum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPlantingSingleDayNum.Location = New System.Drawing.Point(175, 63)
        Me.ucrNudPlantingSingleDayNum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrNudPlantingSingleDayNum.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPlantingSingleDayNum.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSingleDayNum.Name = "ucrNudPlantingSingleDayNum"
        Me.ucrNudPlantingSingleDayNum.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudPlantingSingleDayNum.TabIndex = 30
        Me.ucrNudPlantingSingleDayNum.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudPlantingSeqFrom
        '
        Me.ucrNudPlantingSeqFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSeqFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPlantingSeqFrom.Location = New System.Drawing.Point(178, 139)
        Me.ucrNudPlantingSeqFrom.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrNudPlantingSeqFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPlantingSeqFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPlantingSeqFrom.Name = "ucrNudPlantingSeqFrom"
        Me.ucrNudPlantingSeqFrom.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudPlantingSeqFrom.TabIndex = 29
        Me.ucrNudPlantingSeqFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblPlantingFrom
        '
        Me.lblPlantingFrom.AutoSize = True
        Me.lblPlantingFrom.Location = New System.Drawing.Point(117, 142)
        Me.lblPlantingFrom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantingFrom.Name = "lblPlantingFrom"
        Me.lblPlantingFrom.Size = New System.Drawing.Size(54, 20)
        Me.lblPlantingFrom.TabIndex = 28
        Me.lblPlantingFrom.Tag = ""
        Me.lblPlantingFrom.Text = "From :"
        '
        'rdPlantingSeq
        '
        Me.rdPlantingSeq.AutoSize = True
        Me.rdPlantingSeq.Location = New System.Drawing.Point(24, 110)
        Me.rdPlantingSeq.Name = "rdPlantingSeq"
        Me.rdPlantingSeq.Size = New System.Drawing.Size(107, 24)
        Me.rdPlantingSeq.TabIndex = 2
        Me.rdPlantingSeq.TabStop = True
        Me.rdPlantingSeq.Text = "Sequence"
        Me.rdPlantingSeq.UseVisualStyleBackColor = True
        '
        'rdPlantingSingle
        '
        Me.rdPlantingSingle.AutoSize = True
        Me.rdPlantingSingle.Location = New System.Drawing.Point(24, 36)
        Me.rdPlantingSingle.Name = "rdPlantingSingle"
        Me.rdPlantingSingle.Size = New System.Drawing.Size(78, 24)
        Me.rdPlantingSingle.TabIndex = 0
        Me.rdPlantingSingle.TabStop = True
        Me.rdPlantingSingle.Text = "Single"
        Me.rdPlantingSingle.UseVisualStyleBackColor = True
        '
        'grpLength
        '
        Me.grpLength.Controls.Add(Me.lblLengthDay)
        Me.grpLength.Controls.Add(Me.lblLengthTo)
        Me.grpLength.Controls.Add(Me.lblLengthStep)
        Me.grpLength.Controls.Add(Me.ucrNudLengthSeqTo)
        Me.grpLength.Controls.Add(Me.ucrNudLengthSeqStep)
        Me.grpLength.Controls.Add(Me.ucrNudLengthSingleDays)
        Me.grpLength.Controls.Add(Me.ucrNudLengthSeqFrom)
        Me.grpLength.Controls.Add(Me.lblLengthFrom)
        Me.grpLength.Controls.Add(Me.rdLengthSeq)
        Me.grpLength.Controls.Add(Me.rdLengthSingle)
        Me.grpLength.Location = New System.Drawing.Point(278, 307)
        Me.grpLength.Name = "grpLength"
        Me.grpLength.Size = New System.Drawing.Size(262, 244)
        Me.grpLength.TabIndex = 28
        Me.grpLength.TabStop = False
        Me.grpLength.Text = "Length (days)"
        '
        'lblLengthDay
        '
        Me.lblLengthDay.AutoSize = True
        Me.lblLengthDay.Location = New System.Drawing.Point(115, 66)
        Me.lblLengthDay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLengthDay.Name = "lblLengthDay"
        Me.lblLengthDay.Size = New System.Drawing.Size(53, 20)
        Me.lblLengthDay.TabIndex = 34
        Me.lblLengthDay.Tag = ""
        Me.lblLengthDay.Text = "Days :"
        '
        'lblLengthTo
        '
        Me.lblLengthTo.AutoSize = True
        Me.lblLengthTo.Location = New System.Drawing.Point(133, 211)
        Me.lblLengthTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLengthTo.Name = "lblLengthTo"
        Me.lblLengthTo.Size = New System.Drawing.Size(35, 20)
        Me.lblLengthTo.TabIndex = 34
        Me.lblLengthTo.Tag = ""
        Me.lblLengthTo.Text = "To :"
        '
        'lblLengthStep
        '
        Me.lblLengthStep.AutoSize = True
        Me.lblLengthStep.Location = New System.Drawing.Point(70, 176)
        Me.lblLengthStep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLengthStep.Name = "lblLengthStep"
        Me.lblLengthStep.Size = New System.Drawing.Size(98, 20)
        Me.lblLengthStep.TabIndex = 33
        Me.lblLengthStep.Tag = ""
        Me.lblLengthStep.Text = "Step (days) :"
        '
        'ucrNudLengthSeqTo
        '
        Me.ucrNudLengthSeqTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSeqTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLengthSeqTo.Location = New System.Drawing.Point(178, 207)
        Me.ucrNudLengthSeqTo.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrNudLengthSeqTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLengthSeqTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSeqTo.Name = "ucrNudLengthSeqTo"
        Me.ucrNudLengthSeqTo.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudLengthSeqTo.TabIndex = 32
        Me.ucrNudLengthSeqTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLengthSeqStep
        '
        Me.ucrNudLengthSeqStep.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSeqStep.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLengthSeqStep.Location = New System.Drawing.Point(178, 172)
        Me.ucrNudLengthSeqStep.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrNudLengthSeqStep.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLengthSeqStep.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSeqStep.Name = "ucrNudLengthSeqStep"
        Me.ucrNudLengthSeqStep.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudLengthSeqStep.TabIndex = 31
        Me.ucrNudLengthSeqStep.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLengthSingleDays
        '
        Me.ucrNudLengthSingleDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSingleDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLengthSingleDays.Location = New System.Drawing.Point(175, 63)
        Me.ucrNudLengthSingleDays.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrNudLengthSingleDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLengthSingleDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSingleDays.Name = "ucrNudLengthSingleDays"
        Me.ucrNudLengthSingleDays.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudLengthSingleDays.TabIndex = 30
        Me.ucrNudLengthSingleDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLengthSeqFrom
        '
        Me.ucrNudLengthSeqFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSeqFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLengthSeqFrom.Location = New System.Drawing.Point(178, 139)
        Me.ucrNudLengthSeqFrom.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrNudLengthSeqFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLengthSeqFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLengthSeqFrom.Name = "ucrNudLengthSeqFrom"
        Me.ucrNudLengthSeqFrom.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudLengthSeqFrom.TabIndex = 29
        Me.ucrNudLengthSeqFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLengthFrom
        '
        Me.lblLengthFrom.AutoSize = True
        Me.lblLengthFrom.Location = New System.Drawing.Point(114, 142)
        Me.lblLengthFrom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLengthFrom.Name = "lblLengthFrom"
        Me.lblLengthFrom.Size = New System.Drawing.Size(54, 20)
        Me.lblLengthFrom.TabIndex = 28
        Me.lblLengthFrom.Tag = ""
        Me.lblLengthFrom.Text = "From :"
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
        Me.grpWater.Controls.Add(Me.lblWaterAmt)
        Me.grpWater.Controls.Add(Me.lblWaterTo)
        Me.grpWater.Controls.Add(Me.lblWaterStep)
        Me.grpWater.Controls.Add(Me.ucrNudWaterSeqTo)
        Me.grpWater.Controls.Add(Me.ucrNudWaterSeqStep)
        Me.grpWater.Controls.Add(Me.ucrNudWaterSingleAmt)
        Me.grpWater.Controls.Add(Me.ucrNudWaterSeqFrom)
        Me.grpWater.Controls.Add(Me.lblWaterFrom)
        Me.grpWater.Controls.Add(Me.rdWaterSeq)
        Me.grpWater.Controls.Add(Me.rdWaterSingle)
        Me.grpWater.Location = New System.Drawing.Point(546, 307)
        Me.grpWater.Name = "grpWater"
        Me.grpWater.Size = New System.Drawing.Size(262, 244)
        Me.grpWater.TabIndex = 29
        Me.grpWater.TabStop = False
        Me.grpWater.Text = "Water (mm)"
        '
        'lblWaterAmt
        '
        Me.lblWaterAmt.AutoSize = True
        Me.lblWaterAmt.Location = New System.Drawing.Point(95, 66)
        Me.lblWaterAmt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWaterAmt.Name = "lblWaterAmt"
        Me.lblWaterAmt.Size = New System.Drawing.Size(73, 20)
        Me.lblWaterAmt.TabIndex = 34
        Me.lblWaterAmt.Tag = ""
        Me.lblWaterAmt.Text = "Amount :"
        '
        'lblWaterTo
        '
        Me.lblWaterTo.AutoSize = True
        Me.lblWaterTo.Location = New System.Drawing.Point(133, 211)
        Me.lblWaterTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWaterTo.Name = "lblWaterTo"
        Me.lblWaterTo.Size = New System.Drawing.Size(35, 20)
        Me.lblWaterTo.TabIndex = 34
        Me.lblWaterTo.Tag = ""
        Me.lblWaterTo.Text = "To :"
        '
        'lblWaterStep
        '
        Me.lblWaterStep.AutoSize = True
        Me.lblWaterStep.Location = New System.Drawing.Point(117, 176)
        Me.lblWaterStep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWaterStep.Name = "lblWaterStep"
        Me.lblWaterStep.Size = New System.Drawing.Size(51, 20)
        Me.lblWaterStep.TabIndex = 33
        Me.lblWaterStep.Tag = ""
        Me.lblWaterStep.Text = "Step :"
        '
        'ucrNudWaterSeqTo
        '
        Me.ucrNudWaterSeqTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSeqTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWaterSeqTo.Location = New System.Drawing.Point(178, 207)
        Me.ucrNudWaterSeqTo.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrNudWaterSeqTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWaterSeqTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSeqTo.Name = "ucrNudWaterSeqTo"
        Me.ucrNudWaterSeqTo.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudWaterSeqTo.TabIndex = 32
        Me.ucrNudWaterSeqTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudWaterSeqStep
        '
        Me.ucrNudWaterSeqStep.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSeqStep.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWaterSeqStep.Location = New System.Drawing.Point(178, 172)
        Me.ucrNudWaterSeqStep.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrNudWaterSeqStep.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWaterSeqStep.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSeqStep.Name = "ucrNudWaterSeqStep"
        Me.ucrNudWaterSeqStep.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudWaterSeqStep.TabIndex = 31
        Me.ucrNudWaterSeqStep.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudWaterSingleAmt
        '
        Me.ucrNudWaterSingleAmt.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSingleAmt.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWaterSingleAmt.Location = New System.Drawing.Point(175, 63)
        Me.ucrNudWaterSingleAmt.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrNudWaterSingleAmt.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWaterSingleAmt.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSingleAmt.Name = "ucrNudWaterSingleAmt"
        Me.ucrNudWaterSingleAmt.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudWaterSingleAmt.TabIndex = 30
        Me.ucrNudWaterSingleAmt.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudWaterSeqFrom
        '
        Me.ucrNudWaterSeqFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSeqFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWaterSeqFrom.Location = New System.Drawing.Point(178, 139)
        Me.ucrNudWaterSeqFrom.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrNudWaterSeqFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWaterSeqFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaterSeqFrom.Name = "ucrNudWaterSeqFrom"
        Me.ucrNudWaterSeqFrom.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudWaterSeqFrom.TabIndex = 29
        Me.ucrNudWaterSeqFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblWaterFrom
        '
        Me.lblWaterFrom.AutoSize = True
        Me.lblWaterFrom.Location = New System.Drawing.Point(114, 142)
        Me.lblWaterFrom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWaterFrom.Name = "lblWaterFrom"
        Me.lblWaterFrom.Size = New System.Drawing.Size(54, 20)
        Me.lblWaterFrom.TabIndex = 28
        Me.lblWaterFrom.Tag = ""
        Me.lblWaterFrom.Text = "From :"
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
        'ucrReceiverEnd
        '
        Me.ucrReceiverEnd.frmParent = Me
        Me.ucrReceiverEnd.Location = New System.Drawing.Point(387, 251)
        Me.ucrReceiverEnd.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEnd.Name = "ucrReceiverEnd"
        Me.ucrReceiverEnd.Selector = Nothing
        Me.ucrReceiverEnd.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverEnd.strNcFilePath = ""
        Me.ucrReceiverEnd.TabIndex = 26
        Me.ucrReceiverEnd.ucrSelector = Nothing
        '
        'ucrReceiverStart
        '
        Me.ucrReceiverStart.frmParent = Me
        Me.ucrReceiverStart.Location = New System.Drawing.Point(387, 190)
        Me.ucrReceiverStart.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStart.Name = "ucrReceiverStart"
        Me.ucrReceiverStart.Selector = Nothing
        Me.ucrReceiverStart.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverStart.strNcFilePath = ""
        Me.ucrReceiverStart.TabIndex = 19
        Me.ucrReceiverStart.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(387, 95)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 18
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(623, 159)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverRainfall.strNcFilePath = ""
        Me.ucrReceiverRainfall.TabIndex = 17
        Me.ucrReceiverRainfall.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.frmParent = Me
        Me.ucrReceiverDay.Location = New System.Drawing.Point(623, 97)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.TabIndex = 16
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(623, 33)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 3
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(387, 34)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(180, 31)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorForCrops
        '
        Me.ucrSelectorForCrops.bShowHiddenColumns = False
        Me.ucrSelectorForCrops.bUseCurrentFilter = True
        Me.ucrSelectorForCrops.Location = New System.Drawing.Point(9, 7)
        Me.ucrSelectorForCrops.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForCrops.Name = "ucrSelectorForCrops"
        Me.ucrSelectorForCrops.Size = New System.Drawing.Size(315, 277)
        Me.ucrSelectorForCrops.TabIndex = 1
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
        Me.ClientSize = New System.Drawing.Size(813, 692)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrSaveDataFrame)
        Me.Controls.Add(Me.grpWater)
        Me.Controls.Add(Me.grpLength)
        Me.Controls.Add(Me.grpPlantDate)
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
    Friend WithEvents grpPlantDate As GroupBox
    Friend WithEvents lblPlantingDayNum As Label
    Friend WithEvents lblPlantingTo As Label
    Friend WithEvents lblPlantingStep As Label
    Friend WithEvents ucrNudPlantingSeqTo As ucrNud
    Friend WithEvents ucrNudPlantingSeqStep As ucrNud
    Friend WithEvents ucrNudPlantingSingleDayNum As ucrNud
    Friend WithEvents ucrNudPlantingSeqFrom As ucrNud
    Friend WithEvents lblPlantingFrom As Label
    Friend WithEvents rdPlantingSeq As RadioButton
    Friend WithEvents rdPlantingSingle As RadioButton
    Friend WithEvents ucrSaveDataFrame As ucrSave
    Friend WithEvents grpWater As GroupBox
    Friend WithEvents lblWaterAmt As Label
    Friend WithEvents lblWaterTo As Label
    Friend WithEvents lblWaterStep As Label
    Friend WithEvents ucrNudWaterSeqTo As ucrNud
    Friend WithEvents ucrNudWaterSeqStep As ucrNud
    Friend WithEvents ucrNudWaterSingleAmt As ucrNud
    Friend WithEvents ucrNudWaterSeqFrom As ucrNud
    Friend WithEvents lblWaterFrom As Label
    Friend WithEvents rdWaterSeq As RadioButton
    Friend WithEvents rdWaterSingle As RadioButton
    Friend WithEvents grpLength As GroupBox
    Friend WithEvents lblLengthDay As Label
    Friend WithEvents lblLengthTo As Label
    Friend WithEvents lblLengthStep As Label
    Friend WithEvents ucrNudLengthSeqTo As ucrNud
    Friend WithEvents ucrNudLengthSeqStep As ucrNud
    Friend WithEvents ucrNudLengthSingleDays As ucrNud
    Friend WithEvents ucrNudLengthSeqFrom As ucrNud
    Friend WithEvents lblLengthFrom As Label
    Friend WithEvents rdLengthSeq As RadioButton
    Friend WithEvents rdLengthSingle As RadioButton
    Friend WithEvents cmdOptions As Button
End Class
