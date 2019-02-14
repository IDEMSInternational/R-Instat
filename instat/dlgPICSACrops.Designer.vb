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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.grpSeasonReceivers = New System.Windows.Forms.GroupBox()
        Me.grpCropDefinitions = New System.Windows.Forms.GroupBox()
        Me.ucrChkPlantingLengthDays = New instat.ucrCheck()
        Me.ucrChkWaterAmounts = New instat.ucrCheck()
        Me.ucrCheckPlantingDays = New instat.ucrCheck()
        Me.ucrInputPlantingLengths = New instat.ucrInputComboBox()
        Me.ucrInputWaterAmounts = New instat.ucrInputComboBox()
        Me.ucrInputPlantingDates = New instat.ucrInputComboBox()
        Me.ucrReceiverStart = New instat.ucrReceiverSingle()
        Me.ucrReceiverEnd = New instat.ucrReceiverSingle()
        Me.ucrChkDataProp = New instat.ucrCheck()
        Me.ucrChkPrintDataProp = New instat.ucrCheck()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorForCrops = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpSeasonReceivers.SuspendLayout()
        Me.grpCropDefinitions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedSet
        '
        Me.lblSelectedSet.AutoSize = True
        Me.lblSelectedSet.Location = New System.Drawing.Point(255, 21)
        Me.lblSelectedSet.Name = "lblSelectedSet"
        Me.lblSelectedSet.Size = New System.Drawing.Size(43, 13)
        Me.lblSelectedSet.TabIndex = 15
        Me.lblSelectedSet.Tag = ""
        Me.lblSelectedSet.Text = "Station:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(413, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Tag = ""
        Me.Label2.Text = "Year:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(413, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Tag = ""
        Me.Label3.Text = "Day in Year:"
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(256, 66)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(32, 13)
        Me.lblRain.TabIndex = 23
        Me.lblRain.Tag = ""
        Me.lblRain.Text = "Rain:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Tag = ""
        Me.Label5.Text = "Start:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Tag = ""
        Me.Label6.Text = "End :"
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(368, 336)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 31
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'grpSeasonReceivers
        '
        Me.grpSeasonReceivers.Controls.Add(Me.Label5)
        Me.grpSeasonReceivers.Controls.Add(Me.ucrReceiverStart)
        Me.grpSeasonReceivers.Controls.Add(Me.Label6)
        Me.grpSeasonReceivers.Controls.Add(Me.ucrReceiverEnd)
        Me.grpSeasonReceivers.Location = New System.Drawing.Point(248, 111)
        Me.grpSeasonReceivers.Name = "grpSeasonReceivers"
        Me.grpSeasonReceivers.Size = New System.Drawing.Size(298, 66)
        Me.grpSeasonReceivers.TabIndex = 38
        Me.grpSeasonReceivers.TabStop = False
        Me.grpSeasonReceivers.Text = "Season Dates"
        '
        'grpCropDefinitions
        '
        Me.grpCropDefinitions.Controls.Add(Me.ucrChkPlantingLengthDays)
        Me.grpCropDefinitions.Controls.Add(Me.ucrChkWaterAmounts)
        Me.grpCropDefinitions.Controls.Add(Me.ucrCheckPlantingDays)
        Me.grpCropDefinitions.Controls.Add(Me.ucrInputPlantingLengths)
        Me.grpCropDefinitions.Controls.Add(Me.ucrInputWaterAmounts)
        Me.grpCropDefinitions.Controls.Add(Me.ucrInputPlantingDates)
        Me.grpCropDefinitions.Location = New System.Drawing.Point(6, 194)
        Me.grpCropDefinitions.Name = "grpCropDefinitions"
        Me.grpCropDefinitions.Size = New System.Drawing.Size(292, 137)
        Me.grpCropDefinitions.TabIndex = 39
        Me.grpCropDefinitions.TabStop = False
        Me.grpCropDefinitions.Text = "Crop Definitions"
        '
        'ucrChkPlantingLengthDays
        '
        Me.ucrChkPlantingLengthDays.Checked = False
        Me.ucrChkPlantingLengthDays.Location = New System.Drawing.Point(14, 100)
        Me.ucrChkPlantingLengthDays.Name = "ucrChkPlantingLengthDays"
        Me.ucrChkPlantingLengthDays.Size = New System.Drawing.Size(114, 20)
        Me.ucrChkPlantingLengthDays.TabIndex = 41
        '
        'ucrChkWaterAmounts
        '
        Me.ucrChkWaterAmounts.Checked = False
        Me.ucrChkWaterAmounts.Location = New System.Drawing.Point(14, 64)
        Me.ucrChkWaterAmounts.Name = "ucrChkWaterAmounts"
        Me.ucrChkWaterAmounts.Size = New System.Drawing.Size(114, 20)
        Me.ucrChkWaterAmounts.TabIndex = 40
        '
        'ucrCheckPlantingDays
        '
        Me.ucrCheckPlantingDays.Checked = False
        Me.ucrCheckPlantingDays.Location = New System.Drawing.Point(14, 26)
        Me.ucrCheckPlantingDays.Name = "ucrCheckPlantingDays"
        Me.ucrCheckPlantingDays.Size = New System.Drawing.Size(114, 20)
        Me.ucrCheckPlantingDays.TabIndex = 39
        '
        'ucrInputPlantingLengths
        '
        Me.ucrInputPlantingLengths.AddQuotesIfUnrecognised = True
        Me.ucrInputPlantingLengths.IsReadOnly = False
        Me.ucrInputPlantingLengths.Location = New System.Drawing.Point(134, 100)
        Me.ucrInputPlantingLengths.Name = "ucrInputPlantingLengths"
        Me.ucrInputPlantingLengths.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPlantingLengths.TabIndex = 38
        '
        'ucrInputWaterAmounts
        '
        Me.ucrInputWaterAmounts.AddQuotesIfUnrecognised = True
        Me.ucrInputWaterAmounts.IsReadOnly = False
        Me.ucrInputWaterAmounts.Location = New System.Drawing.Point(134, 63)
        Me.ucrInputWaterAmounts.Name = "ucrInputWaterAmounts"
        Me.ucrInputWaterAmounts.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputWaterAmounts.TabIndex = 38
        '
        'ucrInputPlantingDates
        '
        Me.ucrInputPlantingDates.AddQuotesIfUnrecognised = True
        Me.ucrInputPlantingDates.IsReadOnly = False
        Me.ucrInputPlantingDates.Location = New System.Drawing.Point(134, 25)
        Me.ucrInputPlantingDates.Name = "ucrInputPlantingDates"
        Me.ucrInputPlantingDates.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPlantingDates.TabIndex = 38
        '
        'ucrReceiverStart
        '
        Me.ucrReceiverStart.frmParent = Nothing
        Me.ucrReceiverStart.Location = New System.Drawing.Point(10, 34)
        Me.ucrReceiverStart.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStart.Name = "ucrReceiverStart"
        Me.ucrReceiverStart.Selector = Nothing
        Me.ucrReceiverStart.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStart.strNcFilePath = ""
        Me.ucrReceiverStart.TabIndex = 19
        Me.ucrReceiverStart.ucrSelector = Nothing
        '
        'ucrReceiverEnd
        '
        Me.ucrReceiverEnd.frmParent = Nothing
        Me.ucrReceiverEnd.Location = New System.Drawing.Point(166, 34)
        Me.ucrReceiverEnd.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEnd.Name = "ucrReceiverEnd"
        Me.ucrReceiverEnd.Selector = Nothing
        Me.ucrReceiverEnd.Size = New System.Drawing.Size(120, 22)
        Me.ucrReceiverEnd.strNcFilePath = ""
        Me.ucrReceiverEnd.TabIndex = 26
        Me.ucrReceiverEnd.ucrSelector = Nothing
        '
        'ucrChkDataProp
        '
        Me.ucrChkDataProp.Checked = False
        Me.ucrChkDataProp.Location = New System.Drawing.Point(10, 336)
        Me.ucrChkDataProp.Name = "ucrChkDataProp"
        Me.ucrChkDataProp.Size = New System.Drawing.Size(172, 20)
        Me.ucrChkDataProp.TabIndex = 37
        '
        'ucrChkPrintDataProp
        '
        Me.ucrChkPrintDataProp.Checked = False
        Me.ucrChkPrintDataProp.Location = New System.Drawing.Point(188, 336)
        Me.ucrChkPrintDataProp.Name = "ucrChkPrintDataProp"
        Me.ucrChkPrintDataProp.Size = New System.Drawing.Size(164, 20)
        Me.ucrChkPrintDataProp.TabIndex = 36
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(258, 81)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRainfall.strNcFilePath = ""
        Me.ucrReceiverRainfall.TabIndex = 17
        Me.ucrReceiverRainfall.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.frmParent = Me
        Me.ucrReceiverDay.Location = New System.Drawing.Point(415, 81)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.TabIndex = 16
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(415, 37)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 3
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(258, 37)
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
        Me.ucrSelectorForCrops.bDropUnusedFilterLevels = False
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
        Me.ucrBase.Location = New System.Drawing.Point(10, 370)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgPICSACrops
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 426)
        Me.Controls.Add(Me.grpCropDefinitions)
        Me.Controls.Add(Me.grpSeasonReceivers)
        Me.Controls.Add(Me.ucrChkDataProp)
        Me.Controls.Add(Me.ucrChkPrintDataProp)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblRain)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
        Me.grpSeasonReceivers.ResumeLayout(False)
        Me.grpSeasonReceivers.PerformLayout()
        Me.grpCropDefinitions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForCrops As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ucrReceiverStart As ucrReceiverSingle
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents ucrReceiverDay As ucrReceiverSingle
    Friend WithEvents lblSelectedSet As Label
    Friend WithEvents ucrReceiverEnd As ucrReceiverSingle
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblRain As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrChkPrintDataProp As ucrCheck
    Friend WithEvents ucrChkDataProp As ucrCheck
    Friend WithEvents ucrInputPlantingDates As ucrInputComboBox
    Friend WithEvents ucrInputWaterAmounts As ucrInputComboBox
    Friend WithEvents ucrInputPlantingLengths As ucrInputComboBox
    Friend WithEvents grpSeasonReceivers As GroupBox
    Friend WithEvents grpCropDefinitions As GroupBox
    Friend WithEvents ucrCheckPlantingDays As ucrCheck
    Friend WithEvents ucrChkPlantingLengthDays As ucrCheck
    Friend WithEvents ucrChkWaterAmounts As ucrCheck
End Class
