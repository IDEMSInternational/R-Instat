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
Partial Class dlgHeatMapPlot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgHeatMapPlot))
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdTileOptions = New System.Windows.Forms.Button()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.lblLabelPosition = New System.Windows.Forms.Label()
        Me.lblLabelColour = New System.Windows.Forms.Label()
        Me.lblLabelSize = New System.Windows.Forms.Label()
        Me.lblPointsOptional = New System.Windows.Forms.Label()
        Me.lblPointsSize = New System.Windows.Forms.Label()
        Me.lblReorderVariableX = New System.Windows.Forms.Label()
        Me.lblReorderValue = New System.Windows.Forms.Label()
        Me.rdoChoroplethMap = New System.Windows.Forms.RadioButton()
        Me.rdoHeatMap = New System.Windows.Forms.RadioButton()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblFillChoropleth = New System.Windows.Forms.Label()
        Me.lblPointsChoropleth = New System.Windows.Forms.Label()
        Me.lblSizeChoropleth = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.ucrReceiverPointsHeatMap = New instat.ucrReceiverSingle()
        Me.ucrNudShapeHeatMap = New instat.ucrNud()
        Me.ucrChkColourPalette = New instat.ucrCheck()
        Me.ucrInputColourPalette = New instat.ucrInputComboBox()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrInputReorderValue = New instat.ucrInputComboBox()
        Me.ucrHeatMapSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverFillChoropleth = New instat.ucrReceiverSingle()
        Me.ucrVariableAsFactorForHeatMap = New instat.ucrVariablesAsFactor()
        Me.ucrInputReorderVariableX = New instat.ucrInputComboBox()
        Me.ucrNudShapeChoropleth = New instat.ucrNud()
        Me.ucrInputSize = New instat.ucrInputComboBox()
        Me.ucrChkAddLabels = New instat.ucrCheck()
        Me.ucrInputPosition = New instat.ucrInputComboBox()
        Me.ucrInputColour = New instat.ucrInputComboBox()
        Me.ucrReceiverPointsChoropleth = New instat.ucrReceiverSingle()
        Me.ucrReceiverGroup = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdTileOptions
        '
        resources.ApplyResources(Me.cmdTileOptions, "cmdTileOptions")
        Me.cmdTileOptions.Name = "cmdTileOptions"
        Me.cmdTileOptions.Tag = "Tile_Options"
        Me.cmdTileOptions.UseVisualStyleBackColor = True
        '
        'lblXVariable
        '
        resources.ApplyResources(Me.lblXVariable, "lblXVariable")
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Tag = "X_Variable:"
        '
        'lblFill
        '
        resources.ApplyResources(Me.lblFill, "lblFill")
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Tag = "fill"
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
        'lblPointsOptional
        '
        resources.ApplyResources(Me.lblPointsOptional, "lblPointsOptional")
        Me.lblPointsOptional.Name = "lblPointsOptional"
        Me.lblPointsOptional.Tag = "Points_Optional"
        '
        'lblPointsSize
        '
        resources.ApplyResources(Me.lblPointsSize, "lblPointsSize")
        Me.lblPointsSize.Name = "lblPointsSize"
        '
        'lblReorderVariableX
        '
        resources.ApplyResources(Me.lblReorderVariableX, "lblReorderVariableX")
        Me.lblReorderVariableX.Name = "lblReorderVariableX"
        '
        'lblReorderValue
        '
        resources.ApplyResources(Me.lblReorderValue, "lblReorderValue")
        Me.lblReorderValue.Name = "lblReorderValue"
        '
        'rdoChoroplethMap
        '
        resources.ApplyResources(Me.rdoChoroplethMap, "rdoChoroplethMap")
        Me.rdoChoroplethMap.BackColor = System.Drawing.SystemColors.Control
        Me.rdoChoroplethMap.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoChoroplethMap.FlatAppearance.BorderSize = 2
        Me.rdoChoroplethMap.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoChoroplethMap.Name = "rdoChoroplethMap"
        Me.rdoChoroplethMap.TabStop = True
        Me.rdoChoroplethMap.Tag = "ChoroplethMap"
        Me.rdoChoroplethMap.UseVisualStyleBackColor = False
        '
        'rdoHeatMap
        '
        resources.ApplyResources(Me.rdoHeatMap, "rdoHeatMap")
        Me.rdoHeatMap.BackColor = System.Drawing.SystemColors.Control
        Me.rdoHeatMap.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHeatMap.FlatAppearance.BorderSize = 2
        Me.rdoHeatMap.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHeatMap.Name = "rdoHeatMap"
        Me.rdoHeatMap.TabStop = True
        Me.rdoHeatMap.Tag = "HeatMap"
        Me.rdoHeatMap.UseVisualStyleBackColor = False
        '
        'lblLongitude
        '
        resources.ApplyResources(Me.lblLongitude, "lblLongitude")
        Me.lblLongitude.Name = "lblLongitude"
        '
        'lblLatitude
        '
        resources.ApplyResources(Me.lblLatitude, "lblLatitude")
        Me.lblLatitude.Name = "lblLatitude"
        '
        'lblFillChoropleth
        '
        resources.ApplyResources(Me.lblFillChoropleth, "lblFillChoropleth")
        Me.lblFillChoropleth.Name = "lblFillChoropleth"
        Me.lblFillChoropleth.Tag = "fill"
        '
        'lblPointsChoropleth
        '
        resources.ApplyResources(Me.lblPointsChoropleth, "lblPointsChoropleth")
        Me.lblPointsChoropleth.Name = "lblPointsChoropleth"
        Me.lblPointsChoropleth.Tag = "Points_Optional"
        '
        'lblSizeChoropleth
        '
        resources.ApplyResources(Me.lblSizeChoropleth, "lblSizeChoropleth")
        Me.lblSizeChoropleth.Name = "lblSizeChoropleth"
        '
        'lblGroup
        '
        resources.ApplyResources(Me.lblGroup, "lblGroup")
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Tag = "Group"
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.Checked = False
        resources.ApplyResources(Me.ucrChkFlipCoordinates, "ucrChkFlipCoordinates")
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        '
        'ucrReceiverPointsHeatMap
        '
        Me.ucrReceiverPointsHeatMap.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverPointsHeatMap, "ucrReceiverPointsHeatMap")
        Me.ucrReceiverPointsHeatMap.Name = "ucrReceiverPointsHeatMap"
        Me.ucrReceiverPointsHeatMap.Selector = Nothing
        Me.ucrReceiverPointsHeatMap.strNcFilePath = ""
        Me.ucrReceiverPointsHeatMap.ucrSelector = Nothing
        '
        'ucrNudShapeHeatMap
        '
        Me.ucrNudShapeHeatMap.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShapeHeatMap.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudShapeHeatMap, "ucrNudShapeHeatMap")
        Me.ucrNudShapeHeatMap.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShapeHeatMap.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShapeHeatMap.Name = "ucrNudShapeHeatMap"
        Me.ucrNudShapeHeatMap.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkColourPalette
        '
        Me.ucrChkColourPalette.Checked = False
        resources.ApplyResources(Me.ucrChkColourPalette, "ucrChkColourPalette")
        Me.ucrChkColourPalette.Name = "ucrChkColourPalette"
        '
        'ucrInputColourPalette
        '
        Me.ucrInputColourPalette.AddQuotesIfUnrecognised = True
        Me.ucrInputColourPalette.GetSetSelectedIndex = -1
        Me.ucrInputColourPalette.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputColourPalette, "ucrInputColourPalette")
        Me.ucrInputColourPalette.Name = "ucrInputColourPalette"
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
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
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
        'ucrInputReorderValue
        '
        Me.ucrInputReorderValue.AddQuotesIfUnrecognised = True
        Me.ucrInputReorderValue.GetSetSelectedIndex = -1
        Me.ucrInputReorderValue.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputReorderValue, "ucrInputReorderValue")
        Me.ucrInputReorderValue.Name = "ucrInputReorderValue"
        '
        'ucrHeatMapSelector
        '
        Me.ucrHeatMapSelector.bDropUnusedFilterLevels = False
        Me.ucrHeatMapSelector.bShowHiddenColumns = False
        Me.ucrHeatMapSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrHeatMapSelector, "ucrHeatMapSelector")
        Me.ucrHeatMapSelector.Name = "ucrHeatMapSelector"
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLongitude, "ucrReceiverLongitude")
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLatitude, "ucrReceiverLatitude")
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverFillChoropleth
        '
        Me.ucrReceiverFillChoropleth.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFillChoropleth, "ucrReceiverFillChoropleth")
        Me.ucrReceiverFillChoropleth.Name = "ucrReceiverFillChoropleth"
        Me.ucrReceiverFillChoropleth.Selector = Nothing
        Me.ucrReceiverFillChoropleth.strNcFilePath = ""
        Me.ucrReceiverFillChoropleth.ucrSelector = Nothing
        '
        'ucrVariableAsFactorForHeatMap
        '
        Me.ucrVariableAsFactorForHeatMap.frmParent = Me
        resources.ApplyResources(Me.ucrVariableAsFactorForHeatMap, "ucrVariableAsFactorForHeatMap")
        Me.ucrVariableAsFactorForHeatMap.Name = "ucrVariableAsFactorForHeatMap"
        Me.ucrVariableAsFactorForHeatMap.Selector = Nothing
        Me.ucrVariableAsFactorForHeatMap.strNcFilePath = ""
        Me.ucrVariableAsFactorForHeatMap.ucrSelector = Nothing
        Me.ucrVariableAsFactorForHeatMap.ucrVariableSelector = Nothing
        '
        'ucrInputReorderVariableX
        '
        Me.ucrInputReorderVariableX.AddQuotesIfUnrecognised = True
        Me.ucrInputReorderVariableX.GetSetSelectedIndex = -1
        Me.ucrInputReorderVariableX.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputReorderVariableX, "ucrInputReorderVariableX")
        Me.ucrInputReorderVariableX.Name = "ucrInputReorderVariableX"
        '
        'ucrNudShapeChoropleth
        '
        Me.ucrNudShapeChoropleth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShapeChoropleth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudShapeChoropleth, "ucrNudShapeChoropleth")
        Me.ucrNudShapeChoropleth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShapeChoropleth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShapeChoropleth.Name = "ucrNudShapeChoropleth"
        Me.ucrNudShapeChoropleth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSize
        '
        Me.ucrInputSize.AddQuotesIfUnrecognised = True
        Me.ucrInputSize.GetSetSelectedIndex = -1
        Me.ucrInputSize.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSize, "ucrInputSize")
        Me.ucrInputSize.Name = "ucrInputSize"
        '
        'ucrChkAddLabels
        '
        Me.ucrChkAddLabels.Checked = False
        resources.ApplyResources(Me.ucrChkAddLabels, "ucrChkAddLabels")
        Me.ucrChkAddLabels.Name = "ucrChkAddLabels"
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPosition, "ucrInputPosition")
        Me.ucrInputPosition.Name = "ucrInputPosition"
        '
        'ucrInputColour
        '
        Me.ucrInputColour.AddQuotesIfUnrecognised = True
        Me.ucrInputColour.GetSetSelectedIndex = -1
        Me.ucrInputColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputColour, "ucrInputColour")
        Me.ucrInputColour.Name = "ucrInputColour"
        '
        'ucrReceiverPointsChoropleth
        '
        Me.ucrReceiverPointsChoropleth.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverPointsChoropleth, "ucrReceiverPointsChoropleth")
        Me.ucrReceiverPointsChoropleth.Name = "ucrReceiverPointsChoropleth"
        Me.ucrReceiverPointsChoropleth.Selector = Nothing
        Me.ucrReceiverPointsChoropleth.strNcFilePath = ""
        Me.ucrReceiverPointsChoropleth.ucrSelector = Nothing
        '
        'ucrReceiverGroup
        '
        Me.ucrReceiverGroup.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverGroup, "ucrReceiverGroup")
        Me.ucrReceiverGroup.Name = "ucrReceiverGroup"
        Me.ucrReceiverGroup.Selector = Nothing
        Me.ucrReceiverGroup.strNcFilePath = ""
        Me.ucrReceiverGroup.ucrSelector = Nothing
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
        'dlgHeatMapPlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.lblFillChoropleth)
        Me.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.Controls.Add(Me.rdoChoroplethMap)
        Me.Controls.Add(Me.rdoHeatMap)
        Me.Controls.Add(Me.lblPointsOptional)
        Me.Controls.Add(Me.lblPointsSize)
        Me.Controls.Add(Me.ucrReceiverPointsHeatMap)
        Me.Controls.Add(Me.ucrNudShapeHeatMap)
        Me.Controls.Add(Me.ucrChkColourPalette)
        Me.Controls.Add(Me.ucrInputColourPalette)
        Me.Controls.Add(Me.lblFill)
        Me.Controls.Add(Me.ucrReceiverFill)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdTileOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrInputReorderValue)
        Me.Controls.Add(Me.ucrHeatMapSelector)
        Me.Controls.Add(Me.lblLongitude)
        Me.Controls.Add(Me.ucrReceiverLongitude)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrReceiverLatitude)
        Me.Controls.Add(Me.lblLatitude)
        Me.Controls.Add(Me.lblReorderValue)
        Me.Controls.Add(Me.ucrReceiverFillChoropleth)
        Me.Controls.Add(Me.ucrVariableAsFactorForHeatMap)
        Me.Controls.Add(Me.ucrInputReorderVariableX)
        Me.Controls.Add(Me.ucrNudShapeChoropleth)
        Me.Controls.Add(Me.lblSizeChoropleth)
        Me.Controls.Add(Me.ucrInputSize)
        Me.Controls.Add(Me.ucrChkAddLabels)
        Me.Controls.Add(Me.lblLabelPosition)
        Me.Controls.Add(Me.ucrInputPosition)
        Me.Controls.Add(Me.lblLabelColour)
        Me.Controls.Add(Me.ucrInputColour)
        Me.Controls.Add(Me.lblLabelSize)
        Me.Controls.Add(Me.ucrReceiverPointsChoropleth)
        Me.Controls.Add(Me.ucrReceiverGroup)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblPointsChoropleth)
        Me.Controls.Add(Me.lblReorderVariableX)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgHeatMapPlot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdTileOptions As Button
    Friend WithEvents ucrHeatMapSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrVariableAsFactorForHeatMap As ucrVariablesAsFactor
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrReceiverFill As ucrReceiverSingle
    Friend WithEvents ucrChkAddLabels As ucrCheck
    Friend WithEvents lblLabelPosition As Label
    Friend WithEvents ucrInputPosition As ucrInputComboBox
    Friend WithEvents lblLabelColour As Label
    Friend WithEvents ucrInputColour As ucrInputComboBox
    Friend WithEvents ucrInputSize As ucrInputComboBox
    Friend WithEvents lblLabelSize As Label
    Friend WithEvents ucrInputColourPalette As ucrInputComboBox
    Friend WithEvents ucrChkColourPalette As ucrCheck
    Friend WithEvents lblPointsOptional As Label
    Friend WithEvents lblPointsSize As Label
    Friend WithEvents ucrReceiverPointsHeatMap As ucrReceiverSingle
    Friend WithEvents ucrNudShapeHeatMap As ucrNud
    Friend WithEvents lblReorderVariableX As Label
    Friend WithEvents ucrInputReorderVariableX As ucrInputComboBox
    Friend WithEvents ucrInputReorderValue As ucrInputComboBox
    Friend WithEvents lblReorderValue As Label
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoChoroplethMap As RadioButton
    Friend WithEvents rdoHeatMap As RadioButton
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents lblLongitude As Label
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents lblLatitude As Label
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents lblFillChoropleth As Label
    Friend WithEvents ucrReceiverFillChoropleth As ucrReceiverSingle
    Friend WithEvents ucrNudShapeChoropleth As ucrNud
    Friend WithEvents lblPointsChoropleth As Label
    Friend WithEvents lblSizeChoropleth As Label
    Friend WithEvents ucrReceiverPointsChoropleth As ucrReceiverSingle
    Friend WithEvents lblGroup As Label
    Friend WithEvents ucrReceiverGroup As ucrReceiverSingle
End Class