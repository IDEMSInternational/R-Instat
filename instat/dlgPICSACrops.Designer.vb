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
        Me.components = New System.ComponentModel.Container()
        Me.ucrSelectorSummary = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkDataProp = New instat.ucrCheck()
        Me.ucrChkDataCrops = New instat.ucrCheck()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorForCrops = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblStarts = New System.Windows.Forms.Label()
        Me.ucrInputCropLengths = New instat.ucrInputComboBox()
        Me.ucrInputWaterAmounts = New instat.ucrInputComboBox()
        Me.ucrInputPlantingDates = New instat.ucrInputComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSelectedSet = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.rdoNo = New System.Windows.Forms.RadioButton()
        Me.rdoYes = New System.Windows.Forms.RadioButton()
        Me.lblPlantingDays = New System.Windows.Forms.Label()
        Me.lblCropLengthDays = New System.Windows.Forms.Label()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblWaterAmounts = New System.Windows.Forms.Label()
        Me.ucrPnlStartCheck = New instat.UcrPanel()
        Me.grpCropDefinitions = New System.Windows.Forms.GroupBox()
        Me.grpSeasonReceivers = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverStart = New instat.ucrReceiverSingle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ucrReceiverEnd = New instat.ucrReceiverSingle()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ttPlanting = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrSaveDefinitionCrops = New instat.ucrSave()
        Me.ucrSaveDefinitionProportions = New instat.ucrSave()
        Me.grpCropDefinitions.SuspendLayout()
        Me.grpSeasonReceivers.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSelectorSummary
        '
        Me.ucrSelectorSummary.AutoSize = True
        Me.ucrSelectorSummary.bDropUnusedFilterLevels = False
        Me.ucrSelectorSummary.bShowHiddenColumns = False
        Me.ucrSelectorSummary.bUseCurrentFilter = True
        Me.ucrSelectorSummary.Location = New System.Drawing.Point(9, 292)
        Me.ucrSelectorSummary.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSummary.Name = "ucrSelectorSummary"
        Me.ucrSelectorSummary.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorSummary.TabIndex = 56
        '
        'ucrChkDataProp
        '
        Me.ucrChkDataProp.AutoSize = True
        Me.ucrChkDataProp.Checked = False
        Me.ucrChkDataProp.Location = New System.Drawing.Point(280, 590)
        Me.ucrChkDataProp.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkDataProp.Name = "ucrChkDataProp"
        Me.ucrChkDataProp.Size = New System.Drawing.Size(258, 34)
        Me.ucrChkDataProp.TabIndex = 53
        '
        'ucrChkDataCrops
        '
        Me.ucrChkDataCrops.AutoSize = True
        Me.ucrChkDataCrops.Checked = False
        Me.ucrChkDataCrops.Location = New System.Drawing.Point(16, 590)
        Me.ucrChkDataCrops.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkDataCrops.Name = "ucrChkDataCrops"
        Me.ucrChkDataCrops.Size = New System.Drawing.Size(382, 34)
        Me.ucrChkDataCrops.TabIndex = 52
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.AutoSize = True
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(352, 122)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(170, 30)
        Me.ucrReceiverRainfall.strNcFilePath = ""
        Me.ucrReceiverRainfall.TabIndex = 47
        Me.ucrReceiverRainfall.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.AutoSize = True
        Me.ucrReceiverDay.frmParent = Me
        Me.ucrReceiverDay.Location = New System.Drawing.Point(537, 122)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(172, 30)
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.TabIndex = 46
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(537, 56)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(172, 30)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 44
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(352, 56)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(170, 30)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 43
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorForCrops
        '
        Me.ucrSelectorForCrops.AutoSize = True
        Me.ucrSelectorForCrops.bDropUnusedFilterLevels = False
        Me.ucrSelectorForCrops.bShowHiddenColumns = False
        Me.ucrSelectorForCrops.bUseCurrentFilter = True
        Me.ucrSelectorForCrops.Location = New System.Drawing.Point(9, 8)
        Me.ucrSelectorForCrops.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForCrops.Name = "ucrSelectorForCrops"
        Me.ucrSelectorForCrops.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorForCrops.TabIndex = 42
        '
        'lblStarts
        '
        Me.lblStarts.AutoSize = True
        Me.lblStarts.Location = New System.Drawing.Point(9, 40)
        Me.lblStarts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStarts.Name = "lblStarts"
        Me.lblStarts.Size = New System.Drawing.Size(104, 20)
        Me.lblStarts.TabIndex = 56
        Me.lblStarts.Text = "Include Start:"
        '
        'ucrInputCropLengths
        '
        Me.ucrInputCropLengths.AddQuotesIfUnrecognised = True
        Me.ucrInputCropLengths.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCropLengths.GetSetSelectedIndex = -1
        Me.ucrInputCropLengths.IsReadOnly = False
        Me.ucrInputCropLengths.Location = New System.Drawing.Point(141, 194)
        Me.ucrInputCropLengths.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputCropLengths.Name = "ucrInputCropLengths"
        Me.ucrInputCropLengths.Size = New System.Drawing.Size(208, 32)
        Me.ucrInputCropLengths.TabIndex = 55
        '
        'ucrInputWaterAmounts
        '
        Me.ucrInputWaterAmounts.AddQuotesIfUnrecognised = True
        Me.ucrInputWaterAmounts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputWaterAmounts.GetSetSelectedIndex = -1
        Me.ucrInputWaterAmounts.IsReadOnly = False
        Me.ucrInputWaterAmounts.Location = New System.Drawing.Point(141, 138)
        Me.ucrInputWaterAmounts.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputWaterAmounts.Name = "ucrInputWaterAmounts"
        Me.ucrInputWaterAmounts.Size = New System.Drawing.Size(208, 32)
        Me.ucrInputWaterAmounts.TabIndex = 40
        '
        'ucrInputPlantingDates
        '
        Me.ucrInputPlantingDates.AddQuotesIfUnrecognised = True
        Me.ucrInputPlantingDates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPlantingDates.GetSetSelectedIndex = -1
        Me.ucrInputPlantingDates.IsReadOnly = False
        Me.ucrInputPlantingDates.Location = New System.Drawing.Point(141, 87)
        Me.ucrInputPlantingDates.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputPlantingDates.Name = "ucrInputPlantingDates"
        Me.ucrInputPlantingDates.Size = New System.Drawing.Size(208, 32)
        Me.ucrInputPlantingDates.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(532, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Tag = ""
        Me.Label3.Text = "Day in Year:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(532, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Tag = ""
        Me.Label2.Text = "Year:"
        '
        'lblSelectedSet
        '
        Me.lblSelectedSet.AutoSize = True
        Me.lblSelectedSet.Location = New System.Drawing.Point(346, 32)
        Me.lblSelectedSet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedSet.Name = "lblSelectedSet"
        Me.lblSelectedSet.Size = New System.Drawing.Size(64, 20)
        Me.lblSelectedSet.TabIndex = 45
        Me.lblSelectedSet.Tag = ""
        Me.lblSelectedSet.Text = "Station:"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 744)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 41
        '
        'rdoBoth
        '
        Me.rdoBoth.AutoSize = True
        Me.rdoBoth.Location = New System.Drawing.Point(264, 38)
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.Size = New System.Drawing.Size(68, 24)
        Me.rdoBoth.TabIndex = 44
        Me.rdoBoth.TabStop = True
        Me.rdoBoth.Text = "Both"
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'rdoNo
        '
        Me.rdoNo.AutoSize = True
        Me.rdoNo.Location = New System.Drawing.Point(192, 38)
        Me.rdoNo.Name = "rdoNo"
        Me.rdoNo.Size = New System.Drawing.Size(54, 24)
        Me.rdoNo.TabIndex = 45
        Me.rdoNo.TabStop = True
        Me.rdoNo.Text = "No"
        Me.rdoNo.UseVisualStyleBackColor = True
        '
        'rdoYes
        '
        Me.rdoYes.AutoSize = True
        Me.rdoYes.Location = New System.Drawing.Point(122, 38)
        Me.rdoYes.Name = "rdoYes"
        Me.rdoYes.Size = New System.Drawing.Size(62, 24)
        Me.rdoYes.TabIndex = 43
        Me.rdoYes.TabStop = True
        Me.rdoYes.Text = "Yes"
        Me.rdoYes.UseVisualStyleBackColor = True
        '
        'lblPlantingDays
        '
        Me.lblPlantingDays.Location = New System.Drawing.Point(4, 90)
        Me.lblPlantingDays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantingDays.Name = "lblPlantingDays"
        Me.lblPlantingDays.Size = New System.Drawing.Size(110, 28)
        Me.lblPlantingDays.TabIndex = 42
        Me.lblPlantingDays.Text = "Planting:"
        '
        'lblCropLengthDays
        '
        Me.lblCropLengthDays.Location = New System.Drawing.Point(8, 200)
        Me.lblCropLengthDays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCropLengthDays.Name = "lblCropLengthDays"
        Me.lblCropLengthDays.Size = New System.Drawing.Size(106, 26)
        Me.lblCropLengthDays.TabIndex = 41
        Me.lblCropLengthDays.Text = "Length:"
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(346, 99)
        Me.lblRain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(46, 20)
        Me.lblRain.TabIndex = 50
        Me.lblRain.Tag = ""
        Me.lblRain.Text = "Rain:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Tag = ""
        Me.Label5.Text = "Start:"
        '
        'lblWaterAmounts
        '
        Me.lblWaterAmounts.Location = New System.Drawing.Point(8, 142)
        Me.lblWaterAmounts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWaterAmounts.Name = "lblWaterAmounts"
        Me.lblWaterAmounts.Size = New System.Drawing.Size(106, 27)
        Me.lblWaterAmounts.TabIndex = 40
        Me.lblWaterAmounts.Text = "Water:"
        '
        'ucrPnlStartCheck
        '
        Me.ucrPnlStartCheck.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlStartCheck.Location = New System.Drawing.Point(112, 21)
        Me.ucrPnlStartCheck.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrPnlStartCheck.Name = "ucrPnlStartCheck"
        Me.ucrPnlStartCheck.Size = New System.Drawing.Size(248, 56)
        Me.ucrPnlStartCheck.TabIndex = 46
        '
        'grpCropDefinitions
        '
        Me.grpCropDefinitions.Controls.Add(Me.lblStarts)
        Me.grpCropDefinitions.Controls.Add(Me.ucrInputCropLengths)
        Me.grpCropDefinitions.Controls.Add(Me.ucrInputWaterAmounts)
        Me.grpCropDefinitions.Controls.Add(Me.ucrInputPlantingDates)
        Me.grpCropDefinitions.Controls.Add(Me.rdoBoth)
        Me.grpCropDefinitions.Controls.Add(Me.rdoNo)
        Me.grpCropDefinitions.Controls.Add(Me.rdoYes)
        Me.grpCropDefinitions.Controls.Add(Me.lblPlantingDays)
        Me.grpCropDefinitions.Controls.Add(Me.lblCropLengthDays)
        Me.grpCropDefinitions.Controls.Add(Me.lblWaterAmounts)
        Me.grpCropDefinitions.Controls.Add(Me.ucrPnlStartCheck)
        Me.grpCropDefinitions.Location = New System.Drawing.Point(345, 314)
        Me.grpCropDefinitions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpCropDefinitions.Name = "grpCropDefinitions"
        Me.grpCropDefinitions.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpCropDefinitions.Size = New System.Drawing.Size(374, 237)
        Me.grpCropDefinitions.TabIndex = 55
        Me.grpCropDefinitions.TabStop = False
        Me.grpCropDefinitions.Text = "Crop Definitions"
        '
        'grpSeasonReceivers
        '
        Me.grpSeasonReceivers.Controls.Add(Me.Label5)
        Me.grpSeasonReceivers.Controls.Add(Me.ucrReceiverStart)
        Me.grpSeasonReceivers.Controls.Add(Me.Label6)
        Me.grpSeasonReceivers.Controls.Add(Me.ucrReceiverEnd)
        Me.grpSeasonReceivers.Location = New System.Drawing.Point(338, 166)
        Me.grpSeasonReceivers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSeasonReceivers.Name = "grpSeasonReceivers"
        Me.grpSeasonReceivers.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSeasonReceivers.Size = New System.Drawing.Size(381, 99)
        Me.grpSeasonReceivers.TabIndex = 54
        Me.grpSeasonReceivers.TabStop = False
        Me.grpSeasonReceivers.Text = "Season Dates"
        '
        'ucrReceiverStart
        '
        Me.ucrReceiverStart.AutoSize = True
        Me.ucrReceiverStart.frmParent = Me
        Me.ucrReceiverStart.Location = New System.Drawing.Point(14, 48)
        Me.ucrReceiverStart.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStart.Name = "ucrReceiverStart"
        Me.ucrReceiverStart.Selector = Nothing
        Me.ucrReceiverStart.Size = New System.Drawing.Size(170, 30)
        Me.ucrReceiverStart.strNcFilePath = ""
        Me.ucrReceiverStart.TabIndex = 19
        Me.ucrReceiverStart.ucrSelector = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(195, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Tag = ""
        Me.Label6.Text = "End :"
        '
        'ucrReceiverEnd
        '
        Me.ucrReceiverEnd.AutoSize = True
        Me.ucrReceiverEnd.frmParent = Me
        Me.ucrReceiverEnd.Location = New System.Drawing.Point(200, 48)
        Me.ucrReceiverEnd.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEnd.Name = "ucrReceiverEnd"
        Me.ucrReceiverEnd.Selector = Nothing
        Me.ucrReceiverEnd.Size = New System.Drawing.Size(172, 33)
        Me.ucrReceiverEnd.strNcFilePath = ""
        Me.ucrReceiverEnd.TabIndex = 26
        Me.ucrReceiverEnd.ucrSelector = Nothing
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(532, 588)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(180, 38)
        Me.cmdOptions.TabIndex = 51
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrSaveDefinitionCrops
        '
        Me.ucrSaveDefinitionCrops.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDefinitionCrops.Location = New System.Drawing.Point(15, 641)
        Me.ucrSaveDefinitionCrops.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveDefinitionCrops.Name = "ucrSaveDefinitionCrops"
        Me.ucrSaveDefinitionCrops.Size = New System.Drawing.Size(480, 36)
        Me.ucrSaveDefinitionCrops.TabIndex = 57
        '
        'ucrSaveDefinitionProportions
        '
        Me.ucrSaveDefinitionProportions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDefinitionProportions.Location = New System.Drawing.Point(16, 693)
        Me.ucrSaveDefinitionProportions.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveDefinitionProportions.Name = "ucrSaveDefinitionProportions"
        Me.ucrSaveDefinitionProportions.Size = New System.Drawing.Size(480, 36)
        Me.ucrSaveDefinitionProportions.TabIndex = 58
        '
        'dlgPICSACrops
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(723, 825)
        Me.Controls.Add(Me.ucrSaveDefinitionProportions)
        Me.Controls.Add(Me.ucrSaveDefinitionCrops)
        Me.Controls.Add(Me.ucrSelectorSummary)
        Me.Controls.Add(Me.ucrChkDataProp)
        Me.Controls.Add(Me.ucrChkDataCrops)
        Me.Controls.Add(Me.ucrReceiverRainfall)
        Me.Controls.Add(Me.ucrReceiverDay)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorForCrops)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSelectedSet)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblRain)
        Me.Controls.Add(Me.grpCropDefinitions)
        Me.Controls.Add(Me.grpSeasonReceivers)
        Me.Controls.Add(Me.cmdOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPICSACrops"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PICSA Crops"
        Me.grpCropDefinitions.ResumeLayout(False)
        Me.grpCropDefinitions.PerformLayout()
        Me.grpSeasonReceivers.ResumeLayout(False)
        Me.grpSeasonReceivers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorSummary As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrChkDataProp As ucrCheck
    Friend WithEvents ucrChkDataCrops As ucrCheck
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents ucrReceiverDay As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrSelectorForCrops As ucrSelectorByDataFrameAddRemove
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSelectedSet As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblRain As Label
    Friend WithEvents grpCropDefinitions As GroupBox
    Friend WithEvents lblStarts As Label
    Friend WithEvents ucrInputCropLengths As ucrInputComboBox
    Friend WithEvents ucrInputWaterAmounts As ucrInputComboBox
    Friend WithEvents ucrInputPlantingDates As ucrInputComboBox
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents rdoNo As RadioButton
    Friend WithEvents rdoYes As RadioButton
    Friend WithEvents lblPlantingDays As Label
    Friend WithEvents lblCropLengthDays As Label
    Friend WithEvents lblWaterAmounts As Label
    Friend WithEvents ucrPnlStartCheck As UcrPanel
    Friend WithEvents grpSeasonReceivers As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ucrReceiverStart As ucrReceiverSingle
    Friend WithEvents Label6 As Label
    Friend WithEvents ucrReceiverEnd As ucrReceiverSingle
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ttPlanting As ToolTip
    Friend WithEvents ucrSaveDefinitionProportions As ucrSave
    Friend WithEvents ucrSaveDefinitionCrops As ucrSave
End Class
