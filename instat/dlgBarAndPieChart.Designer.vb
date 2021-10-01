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
Partial Class dlgBarAndPieChart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgBarAndPieChart))
        Me.lblByFactor = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdPieChartOptions = New System.Windows.Forms.Button()
        Me.rdoValue = New System.Windows.Forms.RadioButton()
        Me.cmdBarChartOptions = New System.Windows.Forms.Button()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.cmdColumnChartOptions = New System.Windows.Forms.Button()
        Me.rdoFrequency = New System.Windows.Forms.RadioButton()
        Me.lblXvariable = New System.Windows.Forms.Label()
        Me.rdoPie = New System.Windows.Forms.RadioButton()
        Me.rdoDonut = New System.Windows.Forms.RadioButton()
        Me.lblLabelPosition = New System.Windows.Forms.Label()
        Me.lblLabelColour = New System.Windows.Forms.Label()
        Me.lblLabelSize = New System.Windows.Forms.Label()
        Me.lblLollipopSize = New System.Windows.Forms.Label()
        Me.lblLollipopColour = New System.Windows.Forms.Label()
        Me.lblReorder = New System.Windows.Forms.Label()
        Me.lblReorderX = New System.Windows.Forms.Label()
        Me.lblReorderValue = New System.Windows.Forms.Label()
        Me.rdoTreeMap = New System.Windows.Forms.RadioButton()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.ttArea = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttFill = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblPlace = New System.Windows.Forms.Label()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.rdoWordCloud = New System.Windows.Forms.RadioButton()
        Me.lblWordcloudLabel = New System.Windows.Forms.Label()
        Me.lblWordcloudSize = New System.Windows.Forms.Label()
        Me.lblWordcloudColor = New System.Windows.Forms.Label()
        Me.lblWordcloudAngle = New System.Windows.Forms.Label()
        Me.ucrChkAddLabelsTreemap = New instat.ucrCheck()
        Me.ucrReceiverWordcloudLabel = New instat.ucrReceiverSingle()
        Me.ucrReceiverWordcloudSize = New instat.ucrReceiverSingle()
        Me.ucrReceiverWordcloudColor = New instat.ucrReceiverSingle()
        Me.ucrReceiverWordcloudAngle = New instat.ucrReceiverSingle()
        Me.ucrChkLayout = New instat.ucrCheck()
        Me.ucrChkStart = New instat.ucrCheck()
        Me.ucrInputStart = New instat.ucrInputComboBox()
        Me.ucrInputLayout = New instat.ucrInputComboBox()
        Me.ucrInputPlace = New instat.ucrInputComboBox()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
        Me.ucrReceiverLabel = New instat.ucrReceiverSingle()
        Me.ucrReceiverArea = New instat.ucrReceiverSingle()
        Me.ucrInputReorderValue = New instat.ucrInputComboBox()
        Me.ucrInputReorderX = New instat.ucrInputComboBox()
        Me.ucrInputAddReorder = New instat.ucrInputComboBox()
        Me.ucrInputLollipopColour = New instat.ucrInputComboBox()
        Me.ucrNudLollipopSize = New instat.ucrNud()
        Me.ucrChkLollipop = New instat.ucrCheck()
        Me.ucrInputLabelSize = New instat.ucrInputComboBox()
        Me.ucrInputLabelPosition = New instat.ucrInputComboBox()
        Me.ucrInputLabelColour = New instat.ucrInputComboBox()
        Me.ucrChkAddLabelsText = New instat.ucrCheck()
        Me.ucrChkPolarCoordinates = New instat.ucrCheck()
        Me.ucrPnlPolar = New instat.UcrPanel()
        Me.ucrChkBacktoback = New instat.ucrCheck()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrVariablesAsFactorForBarChart = New instat.ucrVariablesAsFactor()
        Me.ucrInputBarChartPositions = New instat.ucrInputComboBox()
        Me.ucrSaveBar = New instat.ucrSave()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.ucrReceiverByFactor = New instat.ucrReceiverSingle()
        Me.ucrBarChartSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'lblByFactor
        '
        resources.ApplyResources(Me.lblByFactor, "lblByFactor")
        Me.lblByFactor.Name = "lblByFactor"
        Me.lblByFactor.Tag = "By_Factor:"
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Plot_Options..."
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdPieChartOptions
        '
        resources.ApplyResources(Me.cmdPieChartOptions, "cmdPieChartOptions")
        Me.cmdPieChartOptions.Name = "cmdPieChartOptions"
        Me.cmdPieChartOptions.Tag = "Pie_Chart_Options"
        Me.cmdPieChartOptions.UseVisualStyleBackColor = True
        '
        'rdoValue
        '
        resources.ApplyResources(Me.rdoValue, "rdoValue")
        Me.rdoValue.BackColor = System.Drawing.SystemColors.Control
        Me.rdoValue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoValue.FlatAppearance.BorderSize = 2
        Me.rdoValue.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoValue.Name = "rdoValue"
        Me.rdoValue.TabStop = True
        Me.rdoValue.Tag = "Value"
        Me.rdoValue.UseVisualStyleBackColor = False
        '
        'cmdBarChartOptions
        '
        resources.ApplyResources(Me.cmdBarChartOptions, "cmdBarChartOptions")
        Me.cmdBarChartOptions.Name = "cmdBarChartOptions"
        Me.cmdBarChartOptions.Tag = "Bar_Chart_Options"
        Me.cmdBarChartOptions.UseVisualStyleBackColor = True
        '
        'lblPosition
        '
        resources.ApplyResources(Me.lblPosition, "lblPosition")
        Me.lblPosition.Name = "lblPosition"
        '
        'cmdColumnChartOptions
        '
        resources.ApplyResources(Me.cmdColumnChartOptions, "cmdColumnChartOptions")
        Me.cmdColumnChartOptions.Name = "cmdColumnChartOptions"
        Me.cmdColumnChartOptions.Tag = "Column_Chart_Options"
        Me.cmdColumnChartOptions.UseVisualStyleBackColor = True
        '
        'rdoFrequency
        '
        resources.ApplyResources(Me.rdoFrequency, "rdoFrequency")
        Me.rdoFrequency.BackColor = System.Drawing.SystemColors.Control
        Me.rdoFrequency.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrequency.FlatAppearance.BorderSize = 2
        Me.rdoFrequency.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrequency.Name = "rdoFrequency"
        Me.rdoFrequency.TabStop = True
        Me.rdoFrequency.Tag = "Frequency"
        Me.rdoFrequency.UseVisualStyleBackColor = False
        '
        'lblXvariable
        '
        resources.ApplyResources(Me.lblXvariable, "lblXvariable")
        Me.lblXvariable.Name = "lblXvariable"
        '
        'rdoPie
        '
        resources.ApplyResources(Me.rdoPie, "rdoPie")
        Me.rdoPie.Name = "rdoPie"
        Me.rdoPie.TabStop = True
        Me.rdoPie.UseVisualStyleBackColor = True
        '
        'rdoDonut
        '
        resources.ApplyResources(Me.rdoDonut, "rdoDonut")
        Me.rdoDonut.Name = "rdoDonut"
        Me.rdoDonut.TabStop = True
        Me.rdoDonut.UseVisualStyleBackColor = True
        '
        'lblLabelPosition
        '
        resources.ApplyResources(Me.lblLabelPosition, "lblLabelPosition")
        Me.lblLabelPosition.Name = "lblLabelPosition"
        '
        'lblLabelColour
        '
        resources.ApplyResources(Me.lblLabelColour, "lblLabelColour")
        Me.lblLabelColour.Name = "lblLabelColour"
        '
        'lblLabelSize
        '
        resources.ApplyResources(Me.lblLabelSize, "lblLabelSize")
        Me.lblLabelSize.Name = "lblLabelSize"
        '
        'lblLollipopSize
        '
        resources.ApplyResources(Me.lblLollipopSize, "lblLollipopSize")
        Me.lblLollipopSize.Name = "lblLollipopSize"
        '
        'lblLollipopColour
        '
        resources.ApplyResources(Me.lblLollipopColour, "lblLollipopColour")
        Me.lblLollipopColour.Name = "lblLollipopColour"
        '
        'lblReorder
        '
        resources.ApplyResources(Me.lblReorder, "lblReorder")
        Me.lblReorder.Name = "lblReorder"
        '
        'lblReorderX
        '
        resources.ApplyResources(Me.lblReorderX, "lblReorderX")
        Me.lblReorderX.Name = "lblReorderX"
        '
        'lblReorderValue
        '
        resources.ApplyResources(Me.lblReorderValue, "lblReorderValue")
        Me.lblReorderValue.Name = "lblReorderValue"
        '
        'rdoTreeMap
        '
        resources.ApplyResources(Me.rdoTreeMap, "rdoTreeMap")
        Me.rdoTreeMap.BackColor = System.Drawing.SystemColors.Control
        Me.rdoTreeMap.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTreeMap.FlatAppearance.BorderSize = 2
        Me.rdoTreeMap.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTreeMap.Name = "rdoTreeMap"
        Me.rdoTreeMap.TabStop = True
        Me.rdoTreeMap.Tag = "Value"
        Me.rdoTreeMap.UseVisualStyleBackColor = False
        '
        'lblFill
        '
        resources.ApplyResources(Me.lblFill, "lblFill")
        Me.lblFill.Name = "lblFill"
        '
        'lblArea
        '
        resources.ApplyResources(Me.lblArea, "lblArea")
        Me.lblArea.Name = "lblArea"
        '
        'lblPlace
        '
        resources.ApplyResources(Me.lblPlace, "lblPlace")
        Me.lblPlace.Name = "lblPlace"
        '
        'lblLabel
        '
        resources.ApplyResources(Me.lblLabel, "lblLabel")
        Me.lblLabel.Name = "lblLabel"
        '
        'rdoWordCloud
        '
        resources.ApplyResources(Me.rdoWordCloud, "rdoWordCloud")
        Me.rdoWordCloud.BackColor = System.Drawing.SystemColors.Control
        Me.rdoWordCloud.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWordCloud.FlatAppearance.BorderSize = 2
        Me.rdoWordCloud.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWordCloud.Name = "rdoWordCloud"
        Me.rdoWordCloud.TabStop = True
        Me.rdoWordCloud.Tag = "Value"
        Me.rdoWordCloud.UseVisualStyleBackColor = False
        '
        'lblWordcloudLabel
        '
        resources.ApplyResources(Me.lblWordcloudLabel, "lblWordcloudLabel")
        Me.lblWordcloudLabel.Name = "lblWordcloudLabel"
        '
        'lblWordcloudSize
        '
        resources.ApplyResources(Me.lblWordcloudSize, "lblWordcloudSize")
        Me.lblWordcloudSize.Name = "lblWordcloudSize"
        '
        'lblWordcloudColor
        '
        resources.ApplyResources(Me.lblWordcloudColor, "lblWordcloudColor")
        Me.lblWordcloudColor.Name = "lblWordcloudColor"
        '
        'lblWordcloudAngle
        '
        resources.ApplyResources(Me.lblWordcloudAngle, "lblWordcloudAngle")
        Me.lblWordcloudAngle.Name = "lblWordcloudAngle"
        '
        'ucrChkAddLabelsTreemap
        '
        Me.ucrChkAddLabelsTreemap.Checked = False
        resources.ApplyResources(Me.ucrChkAddLabelsTreemap, "ucrChkAddLabelsTreemap")
        Me.ucrChkAddLabelsTreemap.Name = "ucrChkAddLabelsTreemap"
        '
        'ucrReceiverWordcloudLabel
        '
        Me.ucrReceiverWordcloudLabel.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWordcloudLabel, "ucrReceiverWordcloudLabel")
        Me.ucrReceiverWordcloudLabel.Name = "ucrReceiverWordcloudLabel"
        Me.ucrReceiverWordcloudLabel.Selector = Nothing
        Me.ucrReceiverWordcloudLabel.strNcFilePath = ""
        Me.ucrReceiverWordcloudLabel.ucrSelector = Nothing
        '
        'ucrReceiverWordcloudSize
        '
        Me.ucrReceiverWordcloudSize.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWordcloudSize, "ucrReceiverWordcloudSize")
        Me.ucrReceiverWordcloudSize.Name = "ucrReceiverWordcloudSize"
        Me.ucrReceiverWordcloudSize.Selector = Nothing
        Me.ucrReceiverWordcloudSize.strNcFilePath = ""
        Me.ucrReceiverWordcloudSize.ucrSelector = Nothing
        '
        'ucrReceiverWordcloudColor
        '
        Me.ucrReceiverWordcloudColor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWordcloudColor, "ucrReceiverWordcloudColor")
        Me.ucrReceiverWordcloudColor.Name = "ucrReceiverWordcloudColor"
        Me.ucrReceiverWordcloudColor.Selector = Nothing
        Me.ucrReceiverWordcloudColor.strNcFilePath = ""
        Me.ucrReceiverWordcloudColor.ucrSelector = Nothing
        '
        'ucrReceiverWordcloudAngle
        '
        Me.ucrReceiverWordcloudAngle.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWordcloudAngle, "ucrReceiverWordcloudAngle")
        Me.ucrReceiverWordcloudAngle.Name = "ucrReceiverWordcloudAngle"
        Me.ucrReceiverWordcloudAngle.Selector = Nothing
        Me.ucrReceiverWordcloudAngle.strNcFilePath = ""
        Me.ucrReceiverWordcloudAngle.ucrSelector = Nothing
        '
        'ucrChkLayout
        '
        Me.ucrChkLayout.Checked = False
        resources.ApplyResources(Me.ucrChkLayout, "ucrChkLayout")
        Me.ucrChkLayout.Name = "ucrChkLayout"
        '
        'ucrChkStart
        '
        Me.ucrChkStart.Checked = False
        resources.ApplyResources(Me.ucrChkStart, "ucrChkStart")
        Me.ucrChkStart.Name = "ucrChkStart"
        '
        'ucrInputStart
        '
        Me.ucrInputStart.AddQuotesIfUnrecognised = True
        Me.ucrInputStart.GetSetSelectedIndex = -1
        Me.ucrInputStart.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStart, "ucrInputStart")
        Me.ucrInputStart.Name = "ucrInputStart"
        '
        'ucrInputLayout
        '
        Me.ucrInputLayout.AddQuotesIfUnrecognised = True
        Me.ucrInputLayout.GetSetSelectedIndex = -1
        Me.ucrInputLayout.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLayout, "ucrInputLayout")
        Me.ucrInputLayout.Name = "ucrInputLayout"
        '
        'ucrInputPlace
        '
        Me.ucrInputPlace.AddQuotesIfUnrecognised = True
        Me.ucrInputPlace.GetSetSelectedIndex = -1
        Me.ucrInputPlace.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPlace, "ucrInputPlace")
        Me.ucrInputPlace.Name = "ucrInputPlace"
        '
        'ucrReceiverFill
        '
        Me.ucrReceiverFill.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFill, "ucrReceiverFill")
        Me.ucrReceiverFill.Name = "ucrReceiverFill"
        Me.ucrReceiverFill.Selector = Nothing
        Me.ucrReceiverFill.strNcFilePath = ""
        Me.ucrReceiverFill.ucrSelector = Nothing
        '
        'ucrReceiverLabel
        '
        Me.ucrReceiverLabel.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLabel, "ucrReceiverLabel")
        Me.ucrReceiverLabel.Name = "ucrReceiverLabel"
        Me.ucrReceiverLabel.Selector = Nothing
        Me.ucrReceiverLabel.strNcFilePath = ""
        Me.ucrReceiverLabel.ucrSelector = Nothing
        '
        'ucrReceiverArea
        '
        Me.ucrReceiverArea.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverArea, "ucrReceiverArea")
        Me.ucrReceiverArea.Name = "ucrReceiverArea"
        Me.ucrReceiverArea.Selector = Nothing
        Me.ucrReceiverArea.strNcFilePath = ""
        Me.ucrReceiverArea.ucrSelector = Nothing
        '
        'ucrInputReorderValue
        '
        Me.ucrInputReorderValue.AddQuotesIfUnrecognised = True
        Me.ucrInputReorderValue.GetSetSelectedIndex = -1
        Me.ucrInputReorderValue.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputReorderValue, "ucrInputReorderValue")
        Me.ucrInputReorderValue.Name = "ucrInputReorderValue"
        '
        'ucrInputReorderX
        '
        Me.ucrInputReorderX.AddQuotesIfUnrecognised = True
        Me.ucrInputReorderX.GetSetSelectedIndex = -1
        Me.ucrInputReorderX.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputReorderX, "ucrInputReorderX")
        Me.ucrInputReorderX.Name = "ucrInputReorderX"
        '
        'ucrInputAddReorder
        '
        Me.ucrInputAddReorder.AddQuotesIfUnrecognised = True
        Me.ucrInputAddReorder.GetSetSelectedIndex = -1
        Me.ucrInputAddReorder.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputAddReorder, "ucrInputAddReorder")
        Me.ucrInputAddReorder.Name = "ucrInputAddReorder"
        '
        'ucrInputLollipopColour
        '
        Me.ucrInputLollipopColour.AddQuotesIfUnrecognised = True
        Me.ucrInputLollipopColour.GetSetSelectedIndex = -1
        Me.ucrInputLollipopColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLollipopColour, "ucrInputLollipopColour")
        Me.ucrInputLollipopColour.Name = "ucrInputLollipopColour"
        '
        'ucrNudLollipopSize
        '
        Me.ucrNudLollipopSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLollipopSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudLollipopSize, "ucrNudLollipopSize")
        Me.ucrNudLollipopSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLollipopSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLollipopSize.Name = "ucrNudLollipopSize"
        Me.ucrNudLollipopSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrChkLollipop
        '
        Me.ucrChkLollipop.Checked = False
        resources.ApplyResources(Me.ucrChkLollipop, "ucrChkLollipop")
        Me.ucrChkLollipop.Name = "ucrChkLollipop"
        '
        'ucrInputLabelSize
        '
        Me.ucrInputLabelSize.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelSize.GetSetSelectedIndex = -1
        Me.ucrInputLabelSize.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLabelSize, "ucrInputLabelSize")
        Me.ucrInputLabelSize.Name = "ucrInputLabelSize"
        '
        'ucrInputLabelPosition
        '
        Me.ucrInputLabelPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelPosition.GetSetSelectedIndex = -1
        Me.ucrInputLabelPosition.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLabelPosition, "ucrInputLabelPosition")
        Me.ucrInputLabelPosition.Name = "ucrInputLabelPosition"
        '
        'ucrInputLabelColour
        '
        Me.ucrInputLabelColour.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelColour.GetSetSelectedIndex = -1
        Me.ucrInputLabelColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLabelColour, "ucrInputLabelColour")
        Me.ucrInputLabelColour.Name = "ucrInputLabelColour"
        '
        'ucrChkAddLabelsText
        '
        Me.ucrChkAddLabelsText.Checked = False
        resources.ApplyResources(Me.ucrChkAddLabelsText, "ucrChkAddLabelsText")
        Me.ucrChkAddLabelsText.Name = "ucrChkAddLabelsText"
        '
        'ucrChkPolarCoordinates
        '
        Me.ucrChkPolarCoordinates.Checked = False
        resources.ApplyResources(Me.ucrChkPolarCoordinates, "ucrChkPolarCoordinates")
        Me.ucrChkPolarCoordinates.Name = "ucrChkPolarCoordinates"
        '
        'ucrPnlPolar
        '
        resources.ApplyResources(Me.ucrPnlPolar, "ucrPnlPolar")
        Me.ucrPnlPolar.Name = "ucrPnlPolar"
        '
        'ucrChkBacktoback
        '
        Me.ucrChkBacktoback.Checked = False
        resources.ApplyResources(Me.ucrChkBacktoback, "ucrChkBacktoback")
        Me.ucrChkBacktoback.Name = "ucrChkBacktoback"
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverX, "ucrReceiverX")
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrVariablesAsFactorForBarChart
        '
        Me.ucrVariablesAsFactorForBarChart.frmParent = Me
        resources.ApplyResources(Me.ucrVariablesAsFactorForBarChart, "ucrVariablesAsFactorForBarChart")
        Me.ucrVariablesAsFactorForBarChart.Name = "ucrVariablesAsFactorForBarChart"
        Me.ucrVariablesAsFactorForBarChart.Selector = Nothing
        Me.ucrVariablesAsFactorForBarChart.strNcFilePath = ""
        Me.ucrVariablesAsFactorForBarChart.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForBarChart.ucrVariableSelector = Nothing
        '
        'ucrInputBarChartPositions
        '
        Me.ucrInputBarChartPositions.AddQuotesIfUnrecognised = True
        Me.ucrInputBarChartPositions.GetSetSelectedIndex = -1
        Me.ucrInputBarChartPositions.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputBarChartPositions, "ucrInputBarChartPositions")
        Me.ucrInputBarChartPositions.Name = "ucrInputBarChartPositions"
        '
        'ucrSaveBar
        '
        resources.ApplyResources(Me.ucrSaveBar, "ucrSaveBar")
        Me.ucrSaveBar.Name = "ucrSaveBar"
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.Checked = False
        resources.ApplyResources(Me.ucrChkFlipCoordinates, "ucrChkFlipCoordinates")
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        '
        'ucrReceiverByFactor
        '
        Me.ucrReceiverByFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverByFactor, "ucrReceiverByFactor")
        Me.ucrReceiverByFactor.Name = "ucrReceiverByFactor"
        Me.ucrReceiverByFactor.Selector = Nothing
        Me.ucrReceiverByFactor.strNcFilePath = ""
        Me.ucrReceiverByFactor.ucrSelector = Nothing
        '
        'ucrBarChartSelector
        '
        Me.ucrBarChartSelector.bDropUnusedFilterLevels = False
        Me.ucrBarChartSelector.bShowHiddenColumns = False
        Me.ucrBarChartSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrBarChartSelector, "ucrBarChartSelector")
        Me.ucrBarChartSelector.Name = "ucrBarChartSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'dlgBarAndPieChart
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkAddLabelsTreemap)
        Me.Controls.Add(Me.lblWordcloudAngle)
        Me.Controls.Add(Me.lblWordcloudColor)
        Me.Controls.Add(Me.lblWordcloudSize)
        Me.Controls.Add(Me.lblWordcloudLabel)
        Me.Controls.Add(Me.ucrReceiverWordcloudLabel)
        Me.Controls.Add(Me.ucrReceiverWordcloudSize)
        Me.Controls.Add(Me.ucrReceiverWordcloudColor)
        Me.Controls.Add(Me.ucrReceiverWordcloudAngle)
        Me.Controls.Add(Me.rdoWordCloud)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.lblPlace)
        Me.Controls.Add(Me.ucrChkLayout)
        Me.Controls.Add(Me.ucrChkStart)
        Me.Controls.Add(Me.ucrInputStart)
        Me.Controls.Add(Me.ucrInputLayout)
        Me.Controls.Add(Me.ucrInputPlace)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblFill)
        Me.Controls.Add(Me.ucrReceiverFill)
        Me.Controls.Add(Me.ucrReceiverLabel)
        Me.Controls.Add(Me.ucrReceiverArea)
        Me.Controls.Add(Me.rdoTreeMap)
        Me.Controls.Add(Me.ucrInputReorderValue)
        Me.Controls.Add(Me.lblReorderValue)
        Me.Controls.Add(Me.lblReorderX)
        Me.Controls.Add(Me.ucrInputReorderX)
        Me.Controls.Add(Me.lblReorder)
        Me.Controls.Add(Me.ucrInputAddReorder)
        Me.Controls.Add(Me.ucrInputLollipopColour)
        Me.Controls.Add(Me.lblLollipopColour)
        Me.Controls.Add(Me.ucrNudLollipopSize)
        Me.Controls.Add(Me.lblLollipopSize)
        Me.Controls.Add(Me.ucrChkLollipop)
        Me.Controls.Add(Me.lblLabelSize)
        Me.Controls.Add(Me.ucrInputLabelSize)
        Me.Controls.Add(Me.lblLabelColour)
        Me.Controls.Add(Me.lblLabelPosition)
        Me.Controls.Add(Me.ucrInputLabelPosition)
        Me.Controls.Add(Me.ucrInputLabelColour)
        Me.Controls.Add(Me.ucrChkAddLabelsText)
        Me.Controls.Add(Me.rdoDonut)
        Me.Controls.Add(Me.rdoPie)
        Me.Controls.Add(Me.ucrChkPolarCoordinates)
        Me.Controls.Add(Me.ucrPnlPolar)
        Me.Controls.Add(Me.ucrChkBacktoback)
        Me.Controls.Add(Me.lblXvariable)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrVariablesAsFactorForBarChart)
        Me.Controls.Add(Me.rdoFrequency)
        Me.Controls.Add(Me.ucrInputBarChartPositions)
        Me.Controls.Add(Me.cmdColumnChartOptions)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.ucrSaveBar)
        Me.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.Controls.Add(Me.rdoValue)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblByFactor)
        Me.Controls.Add(Me.ucrReceiverByFactor)
        Me.Controls.Add(Me.ucrBarChartSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdBarChartOptions)
        Me.Controls.Add(Me.cmdPieChartOptions)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBarAndPieChart"
        Me.Tag = "Bar_and_Pie_Chart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrBarChartSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverByFactor As ucrReceiverSingle
    Friend WithEvents lblByFactor As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdPieChartOptions As Button
    Friend WithEvents ucrSaveBar As ucrSave
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents rdoValue As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents cmdBarChartOptions As Button
    Friend WithEvents lblPosition As Label
    Friend WithEvents cmdColumnChartOptions As Button
    Friend WithEvents ucrInputBarChartPositions As ucrInputComboBox
    Friend WithEvents rdoFrequency As RadioButton
    Friend WithEvents ucrVariablesAsFactorForBarChart As ucrVariablesAsFactor
    Friend WithEvents lblXvariable As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrChkBacktoback As ucrCheck
    Friend WithEvents ucrChkPolarCoordinates As ucrCheck
    Friend WithEvents ucrPnlPolar As UcrPanel
    Friend WithEvents rdoDonut As RadioButton
    Friend WithEvents rdoPie As RadioButton
    Friend WithEvents ucrChkAddLabelsText As ucrCheck
    Friend WithEvents lblLabelColour As Label
    Friend WithEvents lblLabelPosition As Label
    Friend WithEvents ucrInputLabelPosition As ucrInputComboBox
    Friend WithEvents ucrInputLabelColour As ucrInputComboBox
    Friend WithEvents lblLabelSize As Label
    Friend WithEvents ucrInputLabelSize As ucrInputComboBox
    Friend WithEvents ucrInputLollipopColour As ucrInputComboBox
    Friend WithEvents lblLollipopColour As Label
    Friend WithEvents ucrNudLollipopSize As ucrNud
    Friend WithEvents lblLollipopSize As Label
    Friend WithEvents ucrChkLollipop As ucrCheck
    Friend WithEvents ucrInputAddReorder As ucrInputComboBox
    Friend WithEvents lblReorder As Label
    Friend WithEvents lblReorderX As Label
    Friend WithEvents ucrInputReorderX As ucrInputComboBox
    Friend WithEvents ucrInputReorderValue As ucrInputComboBox
    Friend WithEvents lblReorderValue As Label
    Friend WithEvents rdoTreeMap As RadioButton
    Friend WithEvents lblArea As Label
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrReceiverFill As ucrReceiverSingle
    Friend WithEvents ucrReceiverLabel As ucrReceiverSingle
    Friend WithEvents ucrReceiverArea As ucrReceiverSingle
    Friend WithEvents ttArea As ToolTip
    Friend WithEvents ttFill As ToolTip
    Friend WithEvents ucrChkLayout As ucrCheck
    Friend WithEvents ucrChkStart As ucrCheck
    Friend WithEvents ucrInputStart As ucrInputComboBox
    Friend WithEvents ucrInputLayout As ucrInputComboBox
    Friend WithEvents ucrInputPlace As ucrInputComboBox
    Friend WithEvents lblPlace As Label
    Friend WithEvents lblLabel As Label
    Friend WithEvents rdoWordCloud As RadioButton
    Friend WithEvents lblWordcloudAngle As Label
    Friend WithEvents lblWordcloudColor As Label
    Friend WithEvents lblWordcloudSize As Label
    Friend WithEvents lblWordcloudLabel As Label
    Friend WithEvents ucrReceiverWordcloudLabel As ucrReceiverSingle
    Friend WithEvents ucrReceiverWordcloudSize As ucrReceiverSingle
    Friend WithEvents ucrReceiverWordcloudColor As ucrReceiverSingle
    Friend WithEvents ucrReceiverWordcloudAngle As ucrReceiverSingle
    Friend WithEvents ucrChkAddLabelsTreemap As ucrCheck
End Class