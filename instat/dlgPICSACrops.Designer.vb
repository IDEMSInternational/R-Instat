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
        Me.grpPlantingDate = New System.Windows.Forms.GroupBox()
        Me.lblPlantingDateDays = New System.Windows.Forms.Label()
        Me.grpPlantingLength = New System.Windows.Forms.GroupBox()
        Me.lblPlantingLengthDays = New System.Windows.Forms.Label()
        Me.grpWater = New System.Windows.Forms.GroupBox()
        Me.lblWaterAmount = New System.Windows.Forms.Label()
        Me.ucrChkPrintDataProp = New instat.ucrCheck()
        Me.ucrTxtBoxWaterAmount = New instat.ucrInputTextBox()
        Me.ucrTxtBoxPlantingLength = New instat.ucrInputTextBox()
        Me.ucrTxtBoxPlantingDate = New instat.ucrInputTextBox()
        Me.ucrReceiverEnd = New instat.ucrReceiverSingle()
        Me.ucrReceiverStart = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorForCrops = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkDataProp = New instat.ucrCheck()
        Me.grpPlantingDate.SuspendLayout()
        Me.grpPlantingLength.SuspendLayout()
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
        'grpPlantingDate
        '
        Me.grpPlantingDate.Controls.Add(Me.lblPlantingDateDays)
        Me.grpPlantingDate.Controls.Add(Me.ucrTxtBoxPlantingDate)
        Me.grpPlantingDate.Location = New System.Drawing.Point(6, 203)
        Me.grpPlantingDate.Name = "grpPlantingDate"
        Me.grpPlantingDate.Size = New System.Drawing.Size(200, 53)
        Me.grpPlantingDate.TabIndex = 33
        Me.grpPlantingDate.TabStop = False
        Me.grpPlantingDate.Text = "Planting Date"
        '
        'lblPlantingDateDays
        '
        Me.lblPlantingDateDays.AutoSize = True
        Me.lblPlantingDateDays.Location = New System.Drawing.Point(6, 19)
        Me.lblPlantingDateDays.Name = "lblPlantingDateDays"
        Me.lblPlantingDateDays.Size = New System.Drawing.Size(40, 13)
        Me.lblPlantingDateDays.TabIndex = 34
        Me.lblPlantingDateDays.Text = "Day(s):"
        '
        'grpPlantingLength
        '
        Me.grpPlantingLength.Controls.Add(Me.ucrTxtBoxPlantingLength)
        Me.grpPlantingLength.Controls.Add(Me.lblPlantingLengthDays)
        Me.grpPlantingLength.Location = New System.Drawing.Point(6, 271)
        Me.grpPlantingLength.Name = "grpPlantingLength"
        Me.grpPlantingLength.Size = New System.Drawing.Size(200, 50)
        Me.grpPlantingLength.TabIndex = 34
        Me.grpPlantingLength.TabStop = False
        Me.grpPlantingLength.Text = "Planting Length "
        '
        'lblPlantingLengthDays
        '
        Me.lblPlantingLengthDays.AutoSize = True
        Me.lblPlantingLengthDays.Location = New System.Drawing.Point(6, 25)
        Me.lblPlantingLengthDays.Name = "lblPlantingLengthDays"
        Me.lblPlantingLengthDays.Size = New System.Drawing.Size(40, 13)
        Me.lblPlantingLengthDays.TabIndex = 35
        Me.lblPlantingLengthDays.Text = "Day(s):"
        '
        'grpWater
        '
        Me.grpWater.Controls.Add(Me.ucrTxtBoxWaterAmount)
        Me.grpWater.Controls.Add(Me.lblWaterAmount)
        Me.grpWater.Location = New System.Drawing.Point(258, 203)
        Me.grpWater.Name = "grpWater"
        Me.grpWater.Size = New System.Drawing.Size(206, 53)
        Me.grpWater.TabIndex = 35
        Me.grpWater.TabStop = False
        Me.grpWater.Text = "Water (mm)"
        '
        'lblWaterAmount
        '
        Me.lblWaterAmount.AutoSize = True
        Me.lblWaterAmount.Location = New System.Drawing.Point(6, 19)
        Me.lblWaterAmount.Name = "lblWaterAmount"
        Me.lblWaterAmount.Size = New System.Drawing.Size(57, 13)
        Me.lblWaterAmount.TabIndex = 0
        Me.lblWaterAmount.Text = "Amount(s):"
        '
        'ucrChkPrintDataProp
        '
        Me.ucrChkPrintDataProp.Checked = False
        Me.ucrChkPrintDataProp.Location = New System.Drawing.Point(144, 331)
        Me.ucrChkPrintDataProp.Name = "ucrChkPrintDataProp"
        Me.ucrChkPrintDataProp.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkPrintDataProp.TabIndex = 36
        '
        'ucrTxtBoxWaterAmount
        '
        Me.ucrTxtBoxWaterAmount.AddQuotesIfUnrecognised = True
        Me.ucrTxtBoxWaterAmount.IsMultiline = False
        Me.ucrTxtBoxWaterAmount.IsReadOnly = False
        Me.ucrTxtBoxWaterAmount.Location = New System.Drawing.Point(63, 19)
        Me.ucrTxtBoxWaterAmount.Name = "ucrTxtBoxWaterAmount"
        Me.ucrTxtBoxWaterAmount.Size = New System.Drawing.Size(137, 21)
        Me.ucrTxtBoxWaterAmount.TabIndex = 37
        '
        'ucrTxtBoxPlantingLength
        '
        Me.ucrTxtBoxPlantingLength.AddQuotesIfUnrecognised = True
        Me.ucrTxtBoxPlantingLength.IsMultiline = False
        Me.ucrTxtBoxPlantingLength.IsReadOnly = False
        Me.ucrTxtBoxPlantingLength.Location = New System.Drawing.Point(46, 19)
        Me.ucrTxtBoxPlantingLength.Name = "ucrTxtBoxPlantingLength"
        Me.ucrTxtBoxPlantingLength.Size = New System.Drawing.Size(137, 21)
        Me.ucrTxtBoxPlantingLength.TabIndex = 36
        '
        'ucrTxtBoxPlantingDate
        '
        Me.ucrTxtBoxPlantingDate.AddQuotesIfUnrecognised = True
        Me.ucrTxtBoxPlantingDate.IsMultiline = False
        Me.ucrTxtBoxPlantingDate.IsReadOnly = False
        Me.ucrTxtBoxPlantingDate.Location = New System.Drawing.Point(46, 19)
        Me.ucrTxtBoxPlantingDate.Name = "ucrTxtBoxPlantingDate"
        Me.ucrTxtBoxPlantingDate.Size = New System.Drawing.Size(137, 21)
        Me.ucrTxtBoxPlantingDate.TabIndex = 34
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
        Me.ucrBase.Location = New System.Drawing.Point(5, 357)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrChkDataProp
        '
        Me.ucrChkDataProp.Checked = False
        Me.ucrChkDataProp.Location = New System.Drawing.Point(5, 331)
        Me.ucrChkDataProp.Name = "ucrChkDataProp"
        Me.ucrChkDataProp.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkDataProp.TabIndex = 37
        '
        'dlgPICSACrops
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 414)
        Me.Controls.Add(Me.ucrChkDataProp)
        Me.Controls.Add(Me.ucrChkPrintDataProp)
        Me.Controls.Add(Me.grpWater)
        Me.Controls.Add(Me.grpPlantingLength)
        Me.Controls.Add(Me.grpPlantingDate)
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
        Me.grpPlantingLength.ResumeLayout(False)
        Me.grpPlantingLength.PerformLayout()
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
    Friend WithEvents grpWater As GroupBox
    Friend WithEvents ucrTxtBoxWaterAmount As ucrInputTextBox
    Friend WithEvents lblWaterAmount As Label
    Friend WithEvents grpPlantingLength As GroupBox
    Friend WithEvents ucrTxtBoxPlantingLength As ucrInputTextBox
    Friend WithEvents lblPlantingLengthDays As Label
    Friend WithEvents grpPlantingDate As GroupBox
    Friend WithEvents lblPlantingDateDays As Label
    Friend WithEvents ucrTxtBoxPlantingDate As ucrInputTextBox
    Friend WithEvents ucrChkPrintDataProp As ucrCheck
    Friend WithEvents ucrChkDataProp As ucrCheck
End Class
