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
Partial Class sdgPlots
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
        Me.tbpPlotsOptions = New System.Windows.Forms.TabControl()
        Me.tbpFacet = New System.Windows.Forms.TabPage()
        Me.ucrChkDrop = New instat.ucrCheck()
        Me.ucrNudNumberofRows = New instat.ucrNud()
        Me.ucrChkNoOfRowsOrColumns = New instat.ucrCheck()
        Me.ucrChkIncludeFacets = New instat.ucrCheck()
        Me.ucrChkLabeler = New instat.ucrCheck()
        Me.ucrChkFreeSpace = New instat.ucrCheck()
        Me.ucrChkFreeScalesY = New instat.ucrCheck()
        Me.ucrChkFreeScalesX = New instat.ucrCheck()
        Me.ucrChkMargin = New instat.ucrCheck()
        Me.ucrFacetSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.rdoHorizontal = New System.Windows.Forms.RadioButton()
        Me.rdoVertical = New System.Windows.Forms.RadioButton()
        Me.lblFactor2 = New System.Windows.Forms.Label()
        Me.lblFactor1 = New System.Windows.Forms.Label()
        Me.ucr2ndFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrPnlHorizonatalVertical = New instat.UcrPanel()
        Me.tbpLayers = New System.Windows.Forms.TabPage()
        Me.ucrPlotsAdditionalLayers = New instat.ucrAdditionalLayers()
        Me.tbpTitles = New System.Windows.Forms.TabPage()
        Me.ucrChkIncludeTitles = New instat.ucrCheck()
        Me.lblLegendSize = New System.Windows.Forms.Label()
        Me.lblTagSize = New System.Windows.Forms.Label()
        Me.lblCaptionSize = New System.Windows.Forms.Label()
        Me.lblSubTitleSize = New System.Windows.Forms.Label()
        Me.lblTitleSize = New System.Windows.Forms.Label()
        Me.lblLegendTitle = New System.Windows.Forms.Label()
        Me.lblTag = New System.Windows.Forms.Label()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpLegendTitle = New System.Windows.Forms.GroupBox()
        Me.ucrChkOverwriteLegendTitle = New instat.ucrCheck()
        Me.ucrChkDisplayLegendTitle = New instat.ucrCheck()
        Me.ucrInputLegend = New instat.ucrInputTextBox()
        Me.rdoLegendTitleCustom = New System.Windows.Forms.RadioButton()
        Me.rdoLegendTitleAuto = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLegendTitle = New instat.UcrPanel()
        Me.ucrNudLegendSize = New instat.ucrNud()
        Me.ucrNudTagSize = New instat.ucrNud()
        Me.ucrChkTag = New instat.ucrCheck()
        Me.ucrChkNewLegend = New instat.ucrCheck()
        Me.ucrInputGraphCaption = New instat.ucrInputTextBox()
        Me.ucrNudCaptionSize = New instat.ucrNud()
        Me.ucrNudSubTitleSize = New instat.ucrNud()
        Me.ucrNudTitleSize = New instat.ucrNud()
        Me.ucrInputLegendTitle = New instat.ucrInputTextBox()
        Me.ucrInputTag = New instat.ucrInputTextBox()
        Me.ucrInputGraphSubTitle = New instat.ucrInputTextBox()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.tbpXAxis = New System.Windows.Forms.TabPage()
        Me.ucrXAxis = New instat.ucrAxes()
        Me.tbpYAxis = New System.Windows.Forms.TabPage()
        Me.ucrYAxis = New instat.ucrAxes()
        Me.tbpTheme = New System.Windows.Forms.TabPage()
        Me.cmdSimpleOptions = New System.Windows.Forms.Button()
        Me.grpCommonOptions = New System.Windows.Forms.GroupBox()
        Me.ucrNudYaxisMarkSize = New instat.ucrNud()
        Me.ucrNudXaxisMarkSize = New instat.ucrNud()
        Me.ucrNudYSize = New instat.ucrNud()
        Me.ucrNudXSize = New instat.ucrNud()
        Me.ucrNudXAngle = New instat.ucrNud()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkYaxisTickMarkLabelSize = New instat.ucrCheck()
        Me.ucrChkXaxisTickMarkLabelSize = New instat.ucrCheck()
        Me.ucrChkYaxisSize = New instat.ucrCheck()
        Me.ucrChkXaxisSize = New instat.ucrCheck()
        Me.ucrChkXaxisAngle = New instat.ucrCheck()
        Me.ucrChkLegendPosition = New instat.ucrCheck()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.cmdAllOptions = New System.Windows.Forms.Button()
        Me.urChkSelectTheme = New instat.ucrCheck()
        Me.ucrInputThemes = New instat.ucrInputComboBox()
        Me.tbpCoordinates = New System.Windows.Forms.TabPage()
        Me.grpPolarCordinates = New System.Windows.Forms.GroupBox()
        Me.ucrInputPolarCoordinates = New instat.ucrInputComboBox()
        Me.lblPolarCoordinate = New System.Windows.Forms.Label()
        Me.lblStartingAngle = New System.Windows.Forms.Label()
        Me.ucrChkUsePolarCoordinates = New instat.ucrCheck()
        Me.lblPi = New System.Windows.Forms.Label()
        Me.ucrChkDirectionAnticlockwise = New instat.ucrCheck()
        Me.ucrInputStartingAngle = New instat.ucrInputTextBox()
        Me.ucrChkSameScale = New instat.ucrCheck()
        Me.ucrChkHorizontalPlot = New instat.ucrCheck()
        Me.tbpColour = New System.Windows.Forms.TabPage()
        Me.grpScalecolorpt = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreaksColorpt = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueColorpt = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitColorpt = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandColorpt = New instat.ucrInputTextBox()
        Me.ucrInputPositionColorpt = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsColorpt = New instat.ucrInputComboBox()
        Me.ucrChkExpandColorpt = New instat.ucrCheck()
        Me.ucrChkPositionColorpt = New instat.ucrCheck()
        Me.ucrChkLimitColorpt = New instat.ucrCheck()
        Me.ucrChkBreaksColorpt = New instat.ucrCheck()
        Me.ucrChkNaValueColorpt = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsColorpt = New instat.ucrCheck()
        Me.grpScaleColorfiv = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreaksColorfiv = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueColorfiv = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitColorfiv = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandColorfiv = New instat.ucrInputTextBox()
        Me.ucrInputPositionColorfiv = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsColorfiv = New instat.ucrInputComboBox()
        Me.ucrChkExpandColorfiv = New instat.ucrCheck()
        Me.ucrChkPositionColorfiv = New instat.ucrCheck()
        Me.ucrChkLimitColorfiv = New instat.ucrCheck()
        Me.ucrChkBreaksColorfiv = New instat.ucrCheck()
        Me.ucrChkNaValueColorfiv = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsColorfiv = New instat.ucrCheck()
        Me.grpScalecolorExn = New System.Windows.Forms.GroupBox()
        Me.ucrInputThemeColor = New instat.ucrInputComboBox()
        Me.ucrChkThemecolor = New instat.ucrCheck()
        Me.ucrInputTextBreaksColorExn = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandColorExn = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitColorExn = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueColorExn = New instat.ucrInputTextBox()
        Me.ucrInputPositionColorExn = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsColorExn = New instat.ucrInputComboBox()
        Me.ucrChkNaValueColorExn = New instat.ucrCheck()
        Me.ucrChkPositionColorExn = New instat.ucrCheck()
        Me.ucrChkLimitColorExn = New instat.ucrCheck()
        Me.ucrChkBreaksColorExn = New instat.ucrCheck()
        Me.ucrChkExpandColorExn = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsColorExn = New instat.ucrCheck()
        Me.grpScalecolorst = New System.Windows.Forms.GroupBox()
        Me.ucrInputSchemecolor = New instat.ucrInputComboBox()
        Me.ucrChkSchemecolor = New instat.ucrCheck()
        Me.ucrInputTextBreaksColorst = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueColorst = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitColorst = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandColorst = New instat.ucrInputTextBox()
        Me.ucrInputPositionColorst = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsColorst = New instat.ucrInputComboBox()
        Me.ucrChkExpandColorst = New instat.ucrCheck()
        Me.ucrChkPositionColorst = New instat.ucrCheck()
        Me.ucrChkLimitColorst = New instat.ucrCheck()
        Me.ucrChkBreaksColorst = New instat.ucrCheck()
        Me.ucrChkNaValueColorst = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsColorst = New instat.ucrCheck()
        Me.grpScalecolorEcon = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreaksColorEcon = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueColorEcon = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitColorEcon = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandColorEcon = New instat.ucrInputTextBox()
        Me.ucrInputPositionColorEcon = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsColorEcon = New instat.ucrInputComboBox()
        Me.ucrChkExpandColorEcon = New instat.ucrCheck()
        Me.ucrChkPositionColorEcon = New instat.ucrCheck()
        Me.ucrChkLimitColorEcon = New instat.ucrCheck()
        Me.ucrChkBreaksColorEcon = New instat.ucrCheck()
        Me.ucrChkNaValueColorEcon = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsColorEcon = New instat.ucrCheck()
        Me.grpScalecolorEx = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreaksColorEx = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueColorEx = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitColorEx = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandColorEx = New instat.ucrInputTextBox()
        Me.ucrInputPositionColorEx = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsColorEx = New instat.ucrInputComboBox()
        Me.ucrChkExpandColorEx = New instat.ucrCheck()
        Me.ucrChkPositionColorEx = New instat.ucrCheck()
        Me.ucrChkLimitColorEx = New instat.ucrCheck()
        Me.ucrChkBreaksColorEx = New instat.ucrCheck()
        Me.ucrChkNaValueColorEx = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsColorEx = New instat.ucrCheck()
        Me.grpColourScaleGgthemes = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreaksColor = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueColor = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitColor = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandColor = New instat.ucrInputTextBox()
        Me.ucrInputPositionColor = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsColor = New instat.ucrInputComboBox()
        Me.ucrChkExpandColor = New instat.ucrCheck()
        Me.ucrChkPositionColor = New instat.ucrCheck()
        Me.ucrChkLimitColor = New instat.ucrCheck()
        Me.ucrChkBreaksColor = New instat.ucrCheck()
        Me.ucrChkNaValueColor = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsColor = New instat.ucrCheck()
        Me.grpScalecolorg = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreaksColorg = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueColorg = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitColorg = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandColorg = New instat.ucrInputTextBox()
        Me.ucrInputPositionColorg = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsColorg = New instat.ucrInputComboBox()
        Me.ucrChkExpandColorg = New instat.ucrCheck()
        Me.ucrChkPositionColorg = New instat.ucrCheck()
        Me.ucrChkLimitColorg = New instat.ucrCheck()
        Me.ucrChkBreaksColorg = New instat.ucrCheck()
        Me.ucrChkNaValueColorg = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsColorg = New instat.ucrCheck()
        Me.grpScalecolorpan = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreaksColorpan = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueColorpan = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitColorpan = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandColorpan = New instat.ucrInputTextBox()
        Me.ucrInputPositionColorpan = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsColorpan = New instat.ucrInputComboBox()
        Me.ucrChkExpandColorpan = New instat.ucrCheck()
        Me.ucrChkPositionColorpan = New instat.ucrCheck()
        Me.ucrChkLimitColorpan = New instat.ucrCheck()
        Me.ucrChkBreaksColorpan = New instat.ucrCheck()
        Me.ucrChkNaValueColorpan = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsColorpan = New instat.ucrCheck()
        Me.grpScalecolorsol = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreaksColorsol = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueColorsol = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitColorsol = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandColorsol = New instat.ucrInputTextBox()
        Me.ucrInputPositionColorsol = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsColorsol = New instat.ucrInputComboBox()
        Me.ucrChkExpandColorsol = New instat.ucrCheck()
        Me.ucrChkPositionColorsol = New instat.ucrCheck()
        Me.ucrChkLimitColorsol = New instat.ucrCheck()
        Me.ucrChkBreaksColorsol = New instat.ucrCheck()
        Me.ucrChkNaValueColorsol = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsColorsol = New instat.ucrCheck()
        Me.grpScalecolorfew = New System.Windows.Forms.GroupBox()
        Me.ucrInputPalettecolor = New instat.ucrInputComboBox()
        Me.ucrChkPalettecolor = New instat.ucrCheck()
        Me.ucrInputTextBreaksColorfew = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandColorfew = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitColorfew = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueColorfew = New instat.ucrInputTextBox()
        Me.ucrInputPositionColorfew = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsColorfew = New instat.ucrInputComboBox()
        Me.ucrChkNaValueColorfew = New instat.ucrCheck()
        Me.ucrChkPositionColorfew = New instat.ucrCheck()
        Me.ucrChkLimitColorfew = New instat.ucrCheck()
        Me.ucrChkBreaksColorfew = New instat.ucrCheck()
        Me.ucrChkExpandColorfew = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsColorfew = New instat.ucrCheck()
        Me.grpScalecolorhc = New System.Windows.Forms.GroupBox()
        Me.ucrInputPalettecolorhc = New instat.ucrInputComboBox()
        Me.ucrChkPalettecolorhc = New instat.ucrCheck()
        Me.ucrInputTextBreaksColorhc = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueColorhc = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitColorhc = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandColorhc = New instat.ucrInputTextBox()
        Me.ucrInputPositionColorhc = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsColorhc = New instat.ucrInputComboBox()
        Me.ucrChkExpandColorhc = New instat.ucrCheck()
        Me.ucrChkPositionColorhc = New instat.ucrCheck()
        Me.ucrChkLimitColorhc = New instat.ucrCheck()
        Me.ucrChkBreaksColorhc = New instat.ucrCheck()
        Me.ucrChkNaValueColorhc = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsColorhc = New instat.ucrCheck()
        Me.grpScalecolorcal = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreaksColorCal = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueColorCal = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitColorCal = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandColorCal = New instat.ucrInputTextBox()
        Me.ucrInputPositionColorCal = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsColorCal = New instat.ucrInputComboBox()
        Me.ucrChkExpandColorCal = New instat.ucrCheck()
        Me.ucrChkPositionColorCal = New instat.ucrCheck()
        Me.ucrChkLimitColorCal = New instat.ucrCheck()
        Me.ucrChkBreaksColorCal = New instat.ucrCheck()
        Me.ucrChkNaValueColorCal = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsColorCal = New instat.ucrCheck()
        Me.grpScaleFillfiv = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreaksfiv = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValuefiv = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitfiv = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandfiv = New instat.ucrInputTextBox()
        Me.ucrInputPositionfiv = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsfiv = New instat.ucrInputComboBox()
        Me.ucrChkExpandfiv = New instat.ucrCheck()
        Me.ucrChkPositionfiv = New instat.ucrCheck()
        Me.ucrChkLimitfiv = New instat.ucrCheck()
        Me.ucrChkBreaksfiv = New instat.ucrCheck()
        Me.ucrChkNaValuefiv = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsfiv = New instat.ucrCheck()
        Me.grpScalefillpt = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreakspt = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValuept = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitpt = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandpt = New instat.ucrInputTextBox()
        Me.ucrInputPositionpt = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelspt = New instat.ucrInputComboBox()
        Me.ucrChkExpandpt = New instat.ucrCheck()
        Me.ucrChkPositionpt = New instat.ucrCheck()
        Me.ucrChkLimitpt = New instat.ucrCheck()
        Me.ucrChkBreakspt = New instat.ucrCheck()
        Me.ucrChkNaValuept = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelspt = New instat.ucrCheck()
        Me.grpScalefillw = New System.Windows.Forms.GroupBox()
        Me.ucrInputPalettefillw = New instat.ucrInputComboBox()
        Me.ucrChkpalettefillw = New instat.ucrCheck()
        Me.ucrInputTextBreaksw = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValuew = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitw = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandw = New instat.ucrInputTextBox()
        Me.ucrInputPositionw = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsw = New instat.ucrInputComboBox()
        Me.ucrChkExpandw = New instat.ucrCheck()
        Me.ucrChkPositionw = New instat.ucrCheck()
        Me.ucrChkLimitw = New instat.ucrCheck()
        Me.ucrChkBreaksw = New instat.ucrCheck()
        Me.ucrChkNaValuew = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsw = New instat.ucrCheck()
        Me.grpScalefillst = New System.Windows.Forms.GroupBox()
        Me.ucrInputSchemefill = New instat.ucrInputComboBox()
        Me.ucrChkSchemefill = New instat.ucrCheck()
        Me.ucrInputTextBreaksst = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValuest = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitst = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandst = New instat.ucrInputTextBox()
        Me.ucrInputPositionst = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsst = New instat.ucrInputComboBox()
        Me.ucrChkExpandst = New instat.ucrCheck()
        Me.ucrChkPositionst = New instat.ucrCheck()
        Me.ucrChkLimitst = New instat.ucrCheck()
        Me.ucrChkBreaksst = New instat.ucrCheck()
        Me.ucrChkNaValuest = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsst = New instat.ucrCheck()
        Me.grpScalefillpan = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreakspan = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValuepan = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitpan = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandpan = New instat.ucrInputTextBox()
        Me.ucrInputPositionpan = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelspan = New instat.ucrInputComboBox()
        Me.ucrChkExpandpan = New instat.ucrCheck()
        Me.ucrChkPositionpan = New instat.ucrCheck()
        Me.ucrChkLimitpan = New instat.ucrCheck()
        Me.ucrChkBreakspan = New instat.ucrCheck()
        Me.ucrChkNaValuepan = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelspan = New instat.ucrCheck()
        Me.grpScalefillCal = New System.Windows.Forms.GroupBox()
        Me.ucrChkNaValueCal = New instat.ucrCheck()
        Me.ucrInputTextExpandCal = New instat.ucrInputTextBox()
        Me.ucrInputPositionCal = New instat.ucrInputComboBox()
        Me.ucrChkExpandCal = New instat.ucrCheck()
        Me.ucrChkPositionCal = New instat.ucrCheck()
        Me.ucrInputTextLimitCal = New instat.ucrInputTextBox()
        Me.ucrInputDropUnusedLevelsCal = New instat.ucrInputComboBox()
        Me.ucrChkDropUnusedLevelsCal = New instat.ucrCheck()
        Me.ucrChkBreaksCal = New instat.ucrCheck()
        Me.ucrChkLimitCal = New instat.ucrCheck()
        Me.ucrInputTextBreaksCal = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueCal = New instat.ucrInputTextBox()
        Me.grpScalefillg = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreaksg = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueg = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitg = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandg = New instat.ucrInputTextBox()
        Me.ucrInputPositiong = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsg = New instat.ucrInputComboBox()
        Me.ucrChkExpandg = New instat.ucrCheck()
        Me.ucrChkPositiong = New instat.ucrCheck()
        Me.ucrChkLimitg = New instat.ucrCheck()
        Me.ucrChkBreaksg = New instat.ucrCheck()
        Me.ucrChkNaValueg = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsg = New instat.ucrCheck()
        Me.grpScalefillEx = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreaksEx = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueEx = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitEx = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandEx = New instat.ucrInputTextBox()
        Me.ucrInputPositionEx = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsEx = New instat.ucrInputComboBox()
        Me.ucrChkExpandEx = New instat.ucrCheck()
        Me.ucrChkPositionEx = New instat.ucrCheck()
        Me.ucrChkLimitEx = New instat.ucrCheck()
        Me.ucrChkBreaksEx = New instat.ucrCheck()
        Me.ucrChkNaValueEx = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsEx = New instat.ucrCheck()
        Me.grpScalefillEcon = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreaksEcon = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueEcon = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitEcon = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandEcon = New instat.ucrInputTextBox()
        Me.ucrInputPositionEcon = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsEcon = New instat.ucrInputComboBox()
        Me.ucrChkExpandEcon = New instat.ucrCheck()
        Me.ucrChkPositionEcon = New instat.ucrCheck()
        Me.ucrChkLimitEcon = New instat.ucrCheck()
        Me.ucrChkBreaksEcon = New instat.ucrCheck()
        Me.ucrChkNaValueEcon = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsEcon = New instat.ucrCheck()
        Me.grpScalefillExn = New System.Windows.Forms.GroupBox()
        Me.ucrInputThemeFill = New instat.ucrInputComboBox()
        Me.ucrChkThemeFill = New instat.ucrCheck()
        Me.ucrInputTextBreaksExn = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueExn = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitExn = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandExn = New instat.ucrInputTextBox()
        Me.ucrInputPositionExn = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsExn = New instat.ucrInputComboBox()
        Me.ucrChkExpandExn = New instat.ucrCheck()
        Me.ucrChkPositionExn = New instat.ucrCheck()
        Me.ucrChkLimitExn = New instat.ucrCheck()
        Me.ucrChkBreaksExn = New instat.ucrCheck()
        Me.ucrChkNaValueExn = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsExn = New instat.ucrCheck()
        Me.grpScalefillsol = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreakssol = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValuesol = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitsol = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandsol = New instat.ucrInputTextBox()
        Me.ucrInputPositionsol = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelssol = New instat.ucrInputComboBox()
        Me.ucrChkExpandsol = New instat.ucrCheck()
        Me.ucrChkPositionsol = New instat.ucrCheck()
        Me.ucrChkLimitsol = New instat.ucrCheck()
        Me.ucrChkBreakssol = New instat.ucrCheck()
        Me.ucrChkNaValuesol = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelssol = New instat.ucrCheck()
        Me.grpFillScaleggthemes = New System.Windows.Forms.GroupBox()
        Me.ucrInputTextBreaks = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValue = New instat.ucrInputTextBox()
        Me.ucrInputTextLimit = New instat.ucrInputTextBox()
        Me.ucrInputTextExpand = New instat.ucrInputTextBox()
        Me.ucrInputPosition = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevels = New instat.ucrInputComboBox()
        Me.ucrChkExpand = New instat.ucrCheck()
        Me.ucrChkPosition = New instat.ucrCheck()
        Me.ucrChkLimit = New instat.ucrCheck()
        Me.ucrChkBreaks = New instat.ucrCheck()
        Me.ucrChkNaValue = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevels = New instat.ucrCheck()
        Me.grpScalefillfew = New System.Windows.Forms.GroupBox()
        Me.ucrChkPalettefill = New instat.ucrCheck()
        Me.ucrInputPalettefill = New instat.ucrInputComboBox()
        Me.ucrInputTextBreaksfew = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValuefew = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitfew = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandfew = New instat.ucrInputTextBox()
        Me.ucrInputPositionfew = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsfew = New instat.ucrInputComboBox()
        Me.ucrChkExpandfew = New instat.ucrCheck()
        Me.ucrChkPositionfew = New instat.ucrCheck()
        Me.ucrChkLimitfew = New instat.ucrCheck()
        Me.ucrChkBreaksfew = New instat.ucrCheck()
        Me.ucrChkNaValuefew = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsfew = New instat.ucrCheck()
        Me.grpScalefillhc = New System.Windows.Forms.GroupBox()
        Me.ucrInputPalettehc = New instat.ucrInputComboBox()
        Me.ucrChkPalettehc = New instat.ucrCheck()
        Me.ucrInputTextBreakshc = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValuehc = New instat.ucrInputTextBox()
        Me.ucrInputTextLimithc = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandhc = New instat.ucrInputTextBox()
        Me.ucrInputPositionhc = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelshc = New instat.ucrInputComboBox()
        Me.ucrChkExpandhc = New instat.ucrCheck()
        Me.ucrChkPositionhc = New instat.ucrCheck()
        Me.ucrChkLimithc = New instat.ucrCheck()
        Me.ucrChkBreakshc = New instat.ucrCheck()
        Me.ucrChkNaValuehc = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelshc = New instat.ucrCheck()
        Me.grpScaleColorw = New System.Windows.Forms.GroupBox()
        Me.ucrInputPalettecolorw = New instat.ucrInputComboBox()
        Me.ucrChkPalettecolorw = New instat.ucrCheck()
        Me.ucrInputTextBreaksColorw = New instat.ucrInputTextBox()
        Me.ucrInputTextNaValueColorw = New instat.ucrInputTextBox()
        Me.ucrInputTextLimitColorw = New instat.ucrInputTextBox()
        Me.ucrInputTextExpandColorw = New instat.ucrInputTextBox()
        Me.ucrInputPositionColorw = New instat.ucrInputComboBox()
        Me.ucrInputDropUnusedLevelsColorw = New instat.ucrInputComboBox()
        Me.ucrChkExpandColorw = New instat.ucrCheck()
        Me.ucrChkPositionColorw = New instat.ucrCheck()
        Me.ucrChkLimitColorw = New instat.ucrCheck()
        Me.ucrChkBreaksColorw = New instat.ucrCheck()
        Me.ucrChkNaValueColorw = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevelsColorw = New instat.ucrCheck()
        Me.lblCanvasColorPalette = New System.Windows.Forms.Label()
        Me.ucrInputCanvasColorPalette = New instat.ucrInputComboBox()
        Me.lblGgthemesFunctions = New System.Windows.Forms.Label()
        Me.ucrInputColorFunctions = New instat.ucrInputComboBox()
        Me.lblFillFunction = New System.Windows.Forms.Label()
        Me.ucrInputFillFunction = New instat.ucrInputComboBox()
        Me.lblCanvasFillPalette = New System.Windows.Forms.Label()
        Me.ucrInputCanvasFillPalette = New instat.ucrInputComboBox()
        Me.ucrChkUseFill = New instat.ucrCheck()
        Me.ucrChkUseColor = New instat.ucrCheck()
        Me.rdoGgthemes = New System.Windows.Forms.RadioButton()
        Me.rdoViridis = New System.Windows.Forms.RadioButton()
        Me.lblPalette = New System.Windows.Forms.Label()
        Me.ucrInputPalettes = New instat.ucrInputComboBox()
        Me.rdoQualitative = New System.Windows.Forms.RadioButton()
        Me.rdoSequential = New System.Windows.Forms.RadioButton()
        Me.rdoDiverging = New System.Windows.Forms.RadioButton()
        Me.ucrPnlColourPalette = New instat.UcrPanel()
        Me.ucrInputAxisType = New instat.ucrInputComboBox()
        Me.ucrChkAddColour = New instat.ucrCheck()
        Me.ucrChkAddFillScale = New instat.ucrCheck()
        Me.grpColourScale = New System.Windows.Forms.GroupBox()
        Me.ucrChkColourDiscrete = New instat.ucrCheck()
        Me.ucrNudColourScaleTransparency = New instat.ucrNud()
        Me.ucrInputColourScalePalette = New instat.ucrInputComboBox()
        Me.ucrNudColourScaleMapEnds = New instat.ucrNud()
        Me.ucrNudColourScaleMapBegins = New instat.ucrNud()
        Me.ucrChkColourScaleReverseOrder = New instat.ucrCheck()
        Me.lblColourScaleMapEnds = New System.Windows.Forms.Label()
        Me.lblColourScaleMapBegins = New System.Windows.Forms.Label()
        Me.lblColourScalePalette = New System.Windows.Forms.Label()
        Me.lblColourScaleTransparency = New System.Windows.Forms.Label()
        Me.grpFillScale = New System.Windows.Forms.GroupBox()
        Me.ucrChkFillDiscrete = New instat.ucrCheck()
        Me.ucrNudFillScaleTransparency = New instat.ucrNud()
        Me.ucrNudFillScaleMapEnds = New instat.ucrNud()
        Me.ucrNudFillScaleMapBegins = New instat.ucrNud()
        Me.ucrInputFillScaleColour = New instat.ucrInputComboBox()
        Me.ucrChkFillScaleReverseColourOrder = New instat.ucrCheck()
        Me.lblFillScaleMapEnds = New System.Windows.Forms.Label()
        Me.lblFillScaleBeginColour = New System.Windows.Forms.Label()
        Me.lblFillScaleColourPalettte = New System.Windows.Forms.Label()
        Me.lblFillScaleTransparency = New System.Windows.Forms.Label()
        Me.lblPalcontinuouscolor = New System.Windows.Forms.Label()
        Me.ucrInputcontinuouscolor = New instat.ucrInputComboBox()
        Me.lblPaletteContinuousfill = New System.Windows.Forms.Label()
        Me.ucrInputContinousfill = New instat.ucrInputComboBox()
        Me.lblPaletteContinuous = New System.Windows.Forms.Label()
        Me.ucrInputPaletteContinuous = New instat.ucrInputComboBox()
        Me.tbpAnnotation = New System.Windows.Forms.TabPage()
        Me.ucrChkAnnotation = New instat.ucrCheck()
        Me.grpAnnotation = New System.Windows.Forms.GroupBox()
        Me.ucrChkParse = New instat.ucrCheck()
        Me.ucrInputFill = New instat.ucrColors()
        Me.ucrInputColour = New instat.ucrColors()
        Me.lblCurvature = New System.Windows.Forms.Label()
        Me.ucrNudAlpha = New instat.ucrNud()
        Me.lblAlpha = New System.Windows.Forms.Label()
        Me.lblLineend = New System.Windows.Forms.Label()
        Me.lblAngle = New System.Windows.Forms.Label()
        Me.ucrNudAngle = New instat.ucrNud()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.lblAnnotationGeoms = New System.Windows.Forms.Label()
        Me.ucrInputAnnotationGeoms = New instat.ucrInputComboBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.ucrNudSize = New instat.ucrNud()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.lblXmax = New System.Windows.Forms.Label()
        Me.ucrInputXmax = New instat.ucrInputTextBox()
        Me.ucrInputYmin = New instat.ucrInputTextBox()
        Me.ucrInputXmin = New instat.ucrInputTextBox()
        Me.lblYmin = New System.Windows.Forms.Label()
        Me.lblXmin = New System.Windows.Forms.Label()
        Me.lblXend = New System.Windows.Forms.Label()
        Me.lblYmax = New System.Windows.Forms.Label()
        Me.ucrInputYmax = New instat.ucrInputTextBox()
        Me.ucrInputYend = New instat.ucrInputTextBox()
        Me.ucrInputXend = New instat.ucrInputTextBox()
        Me.lblYend = New System.Windows.Forms.Label()
        Me.ucrNudLinetype = New instat.ucrNud()
        Me.lblLinetype = New System.Windows.Forms.Label()
        Me.lblPointrangeFatten = New System.Windows.Forms.Label()
        Me.ucrNudPointrangeFatten = New instat.ucrNud()
        Me.ucrNudCrossbarFatten = New instat.ucrNud()
        Me.lblCrossbarFatten = New System.Windows.Forms.Label()
        Me.ucrNudCurvature = New instat.ucrNud()
        Me.ucrNudShape = New instat.ucrNud()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.ucrInputLabel = New instat.ucrInputTextBox()
        Me.ucrInputLineend = New instat.ucrInputComboBox()
        Me.ucrInputY = New instat.ucrInputTextBox()
        Me.ucrInputX = New instat.ucrInputTextBox()
        Me.ucrReceiverY = New instat.ucrReceiverSingle()
        Me.ttCaptionTitle = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.tbpPlotsOptions.SuspendLayout()
        Me.tbpFacet.SuspendLayout()
        Me.tbpLayers.SuspendLayout()
        Me.tbpTitles.SuspendLayout()
        Me.grpLegendTitle.SuspendLayout()
        Me.tbpXAxis.SuspendLayout()
        Me.tbpYAxis.SuspendLayout()
        Me.tbpTheme.SuspendLayout()
        Me.grpCommonOptions.SuspendLayout()
        Me.tbpCoordinates.SuspendLayout()
        Me.grpPolarCordinates.SuspendLayout()
        Me.tbpColour.SuspendLayout()
        Me.grpScalecolorpt.SuspendLayout()
        Me.grpScaleColorfiv.SuspendLayout()
        Me.grpScalecolorExn.SuspendLayout()
        Me.grpScalecolorst.SuspendLayout()
        Me.grpScalecolorEcon.SuspendLayout()
        Me.grpScalecolorEx.SuspendLayout()
        Me.grpColourScaleGgthemes.SuspendLayout()
        Me.grpScalecolorg.SuspendLayout()
        Me.grpScalecolorpan.SuspendLayout()
        Me.grpScalecolorsol.SuspendLayout()
        Me.grpScalecolorfew.SuspendLayout()
        Me.grpScalecolorhc.SuspendLayout()
        Me.grpScalecolorcal.SuspendLayout()
        Me.grpScaleFillfiv.SuspendLayout()
        Me.grpScalefillpt.SuspendLayout()
        Me.grpScalefillw.SuspendLayout()
        Me.grpScalefillst.SuspendLayout()
        Me.grpScalefillpan.SuspendLayout()
        Me.grpScalefillCal.SuspendLayout()
        Me.grpScalefillg.SuspendLayout()
        Me.grpScalefillEx.SuspendLayout()
        Me.grpScalefillEcon.SuspendLayout()
        Me.grpScalefillExn.SuspendLayout()
        Me.grpScalefillsol.SuspendLayout()
        Me.grpFillScaleggthemes.SuspendLayout()
        Me.grpScalefillfew.SuspendLayout()
        Me.grpScalefillhc.SuspendLayout()
        Me.grpScaleColorw.SuspendLayout()
        Me.grpColourScale.SuspendLayout()
        Me.grpFillScale.SuspendLayout()
        Me.tbpAnnotation.SuspendLayout()
        Me.grpAnnotation.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpPlotsOptions
        '
        Me.tbpPlotsOptions.Controls.Add(Me.tbpFacet)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpLayers)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpTitles)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpXAxis)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpYAxis)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpTheme)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpCoordinates)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpColour)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpAnnotation)
        Me.tbpPlotsOptions.Location = New System.Drawing.Point(7, 3)
        Me.tbpPlotsOptions.Name = "tbpPlotsOptions"
        Me.tbpPlotsOptions.SelectedIndex = 0
        Me.tbpPlotsOptions.Size = New System.Drawing.Size(677, 736)
        Me.tbpPlotsOptions.TabIndex = 0
        '
        'tbpFacet
        '
        Me.tbpFacet.Controls.Add(Me.ucrChkDrop)
        Me.tbpFacet.Controls.Add(Me.ucrNudNumberofRows)
        Me.tbpFacet.Controls.Add(Me.ucrChkNoOfRowsOrColumns)
        Me.tbpFacet.Controls.Add(Me.ucrChkIncludeFacets)
        Me.tbpFacet.Controls.Add(Me.ucrChkLabeler)
        Me.tbpFacet.Controls.Add(Me.ucrChkFreeSpace)
        Me.tbpFacet.Controls.Add(Me.ucrChkFreeScalesY)
        Me.tbpFacet.Controls.Add(Me.ucrChkFreeScalesX)
        Me.tbpFacet.Controls.Add(Me.ucrChkMargin)
        Me.tbpFacet.Controls.Add(Me.ucrFacetSelector)
        Me.tbpFacet.Controls.Add(Me.rdoHorizontal)
        Me.tbpFacet.Controls.Add(Me.rdoVertical)
        Me.tbpFacet.Controls.Add(Me.lblFactor2)
        Me.tbpFacet.Controls.Add(Me.lblFactor1)
        Me.tbpFacet.Controls.Add(Me.ucr2ndFactorReceiver)
        Me.tbpFacet.Controls.Add(Me.ucr1stFactorReceiver)
        Me.tbpFacet.Controls.Add(Me.ucrPnlHorizonatalVertical)
        Me.tbpFacet.Location = New System.Drawing.Point(4, 22)
        Me.tbpFacet.Name = "tbpFacet"
        Me.tbpFacet.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFacet.Size = New System.Drawing.Size(669, 710)
        Me.tbpFacet.TabIndex = 3
        Me.tbpFacet.Tag = "Facet"
        Me.tbpFacet.Text = "Facets"
        Me.tbpFacet.UseVisualStyleBackColor = True
        '
        'ucrChkDrop
        '
        Me.ucrChkDrop.AutoSize = True
        Me.ucrChkDrop.Checked = False
        Me.ucrChkDrop.Location = New System.Drawing.Point(273, 269)
        Me.ucrChkDrop.Name = "ucrChkDrop"
        Me.ucrChkDrop.Size = New System.Drawing.Size(257, 23)
        Me.ucrChkDrop.TabIndex = 11
        '
        'ucrNudNumberofRows
        '
        Me.ucrNudNumberofRows.AutoSize = True
        Me.ucrNudNumberofRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberofRows.Location = New System.Drawing.Point(169, 252)
        Me.ucrNudNumberofRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRows.Name = "ucrNudNumberofRows"
        Me.ucrNudNumberofRows.Size = New System.Drawing.Size(46, 20)
        Me.ucrNudNumberofRows.TabIndex = 15
        Me.ucrNudNumberofRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkNoOfRowsOrColumns
        '
        Me.ucrChkNoOfRowsOrColumns.AutoSize = True
        Me.ucrChkNoOfRowsOrColumns.Checked = False
        Me.ucrChkNoOfRowsOrColumns.Location = New System.Drawing.Point(7, 254)
        Me.ucrChkNoOfRowsOrColumns.Name = "ucrChkNoOfRowsOrColumns"
        Me.ucrChkNoOfRowsOrColumns.Size = New System.Drawing.Size(156, 23)
        Me.ucrChkNoOfRowsOrColumns.TabIndex = 14
        '
        'ucrChkIncludeFacets
        '
        Me.ucrChkIncludeFacets.AutoSize = True
        Me.ucrChkIncludeFacets.Checked = False
        Me.ucrChkIncludeFacets.Location = New System.Drawing.Point(8, 13)
        Me.ucrChkIncludeFacets.Name = "ucrChkIncludeFacets"
        Me.ucrChkIncludeFacets.Size = New System.Drawing.Size(121, 23)
        Me.ucrChkIncludeFacets.TabIndex = 0
        '
        'ucrChkLabeler
        '
        Me.ucrChkLabeler.AutoSize = True
        Me.ucrChkLabeler.Checked = False
        Me.ucrChkLabeler.Location = New System.Drawing.Point(273, 245)
        Me.ucrChkLabeler.Name = "ucrChkLabeler"
        Me.ucrChkLabeler.Size = New System.Drawing.Size(257, 23)
        Me.ucrChkLabeler.TabIndex = 10
        '
        'ucrChkFreeSpace
        '
        Me.ucrChkFreeSpace.AutoSize = True
        Me.ucrChkFreeSpace.Checked = False
        Me.ucrChkFreeSpace.Location = New System.Drawing.Point(273, 221)
        Me.ucrChkFreeSpace.Name = "ucrChkFreeSpace"
        Me.ucrChkFreeSpace.Size = New System.Drawing.Size(257, 23)
        Me.ucrChkFreeSpace.TabIndex = 9
        '
        'ucrChkFreeScalesY
        '
        Me.ucrChkFreeScalesY.AutoSize = True
        Me.ucrChkFreeScalesY.Checked = False
        Me.ucrChkFreeScalesY.Location = New System.Drawing.Point(273, 197)
        Me.ucrChkFreeScalesY.Name = "ucrChkFreeScalesY"
        Me.ucrChkFreeScalesY.Size = New System.Drawing.Size(257, 23)
        Me.ucrChkFreeScalesY.TabIndex = 8
        '
        'ucrChkFreeScalesX
        '
        Me.ucrChkFreeScalesX.AutoSize = True
        Me.ucrChkFreeScalesX.Checked = False
        Me.ucrChkFreeScalesX.Location = New System.Drawing.Point(273, 173)
        Me.ucrChkFreeScalesX.Name = "ucrChkFreeScalesX"
        Me.ucrChkFreeScalesX.Size = New System.Drawing.Size(257, 23)
        Me.ucrChkFreeScalesX.TabIndex = 7
        '
        'ucrChkMargin
        '
        Me.ucrChkMargin.AutoSize = True
        Me.ucrChkMargin.Checked = False
        Me.ucrChkMargin.Location = New System.Drawing.Point(273, 149)
        Me.ucrChkMargin.Name = "ucrChkMargin"
        Me.ucrChkMargin.Size = New System.Drawing.Size(257, 23)
        Me.ucrChkMargin.TabIndex = 6
        '
        'ucrFacetSelector
        '
        Me.ucrFacetSelector.AutoSize = True
        Me.ucrFacetSelector.bDropUnusedFilterLevels = False
        Me.ucrFacetSelector.bShowHiddenColumns = False
        Me.ucrFacetSelector.bUseCurrentFilter = True
        Me.ucrFacetSelector.Location = New System.Drawing.Point(8, 36)
        Me.ucrFacetSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFacetSelector.Name = "ucrFacetSelector"
        Me.ucrFacetSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrFacetSelector.TabIndex = 1
        '
        'rdoHorizontal
        '
        Me.rdoHorizontal.AutoSize = True
        Me.rdoHorizontal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHorizontal.Location = New System.Drawing.Point(8, 230)
        Me.rdoHorizontal.Name = "rdoHorizontal"
        Me.rdoHorizontal.Size = New System.Drawing.Size(72, 17)
        Me.rdoHorizontal.TabIndex = 12
        Me.rdoHorizontal.TabStop = True
        Me.rdoHorizontal.Tag = "Horizontal"
        Me.rdoHorizontal.Text = "Horizontal"
        Me.rdoHorizontal.UseVisualStyleBackColor = True
        '
        'rdoVertical
        '
        Me.rdoVertical.AutoSize = True
        Me.rdoVertical.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoVertical.Location = New System.Drawing.Point(104, 230)
        Me.rdoVertical.Name = "rdoVertical"
        Me.rdoVertical.Size = New System.Drawing.Size(60, 17)
        Me.rdoVertical.TabIndex = 13
        Me.rdoVertical.TabStop = True
        Me.rdoVertical.Tag = "Vertical"
        Me.rdoVertical.Text = "Vertical"
        Me.rdoVertical.UseVisualStyleBackColor = True
        '
        'lblFactor2
        '
        Me.lblFactor2.AutoSize = True
        Me.lblFactor2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactor2.Location = New System.Drawing.Point(274, 99)
        Me.lblFactor2.Name = "lblFactor2"
        Me.lblFactor2.Size = New System.Drawing.Size(109, 13)
        Me.lblFactor2.TabIndex = 4
        Me.lblFactor2.Text = "2nd Factor (Optional):"
        '
        'lblFactor1
        '
        Me.lblFactor1.AutoSize = True
        Me.lblFactor1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactor1.Location = New System.Drawing.Point(272, 44)
        Me.lblFactor1.Name = "lblFactor1"
        Me.lblFactor1.Size = New System.Drawing.Size(57, 13)
        Me.lblFactor1.TabIndex = 2
        Me.lblFactor1.Tag = ""
        Me.lblFactor1.Text = "1st Factor:"
        '
        'ucr2ndFactorReceiver
        '
        Me.ucr2ndFactorReceiver.AutoSize = True
        Me.ucr2ndFactorReceiver.frmParent = Nothing
        Me.ucr2ndFactorReceiver.Location = New System.Drawing.Point(273, 114)
        Me.ucr2ndFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr2ndFactorReceiver.Name = "ucr2ndFactorReceiver"
        Me.ucr2ndFactorReceiver.Selector = Nothing
        Me.ucr2ndFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucr2ndFactorReceiver.strNcFilePath = ""
        Me.ucr2ndFactorReceiver.TabIndex = 5
        Me.ucr2ndFactorReceiver.ucrSelector = Nothing
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.AutoSize = True
        Me.ucr1stFactorReceiver.frmParent = Nothing
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(273, 59)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.TabIndex = 3
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'ucrPnlHorizonatalVertical
        '
        Me.ucrPnlHorizonatalVertical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlHorizonatalVertical.Location = New System.Drawing.Point(8, 228)
        Me.ucrPnlHorizonatalVertical.Name = "ucrPnlHorizonatalVertical"
        Me.ucrPnlHorizonatalVertical.Size = New System.Drawing.Size(165, 20)
        Me.ucrPnlHorizonatalVertical.TabIndex = 30
        '
        'tbpLayers
        '
        Me.tbpLayers.Controls.Add(Me.ucrPlotsAdditionalLayers)
        Me.tbpLayers.Location = New System.Drawing.Point(4, 22)
        Me.tbpLayers.Name = "tbpLayers"
        Me.tbpLayers.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLayers.Size = New System.Drawing.Size(669, 710)
        Me.tbpLayers.TabIndex = 4
        Me.tbpLayers.Tag = "Layers"
        Me.tbpLayers.Text = "Layers"
        Me.tbpLayers.UseVisualStyleBackColor = True
        '
        'ucrPlotsAdditionalLayers
        '
        Me.ucrPlotsAdditionalLayers.AutoSize = True
        Me.ucrPlotsAdditionalLayers.Location = New System.Drawing.Point(7, 6)
        Me.ucrPlotsAdditionalLayers.Name = "ucrPlotsAdditionalLayers"
        Me.ucrPlotsAdditionalLayers.Size = New System.Drawing.Size(243, 191)
        Me.ucrPlotsAdditionalLayers.TabIndex = 0
        '
        'tbpTitles
        '
        Me.tbpTitles.Controls.Add(Me.ucrChkIncludeTitles)
        Me.tbpTitles.Controls.Add(Me.lblLegendSize)
        Me.tbpTitles.Controls.Add(Me.lblTagSize)
        Me.tbpTitles.Controls.Add(Me.lblCaptionSize)
        Me.tbpTitles.Controls.Add(Me.lblSubTitleSize)
        Me.tbpTitles.Controls.Add(Me.lblTitleSize)
        Me.tbpTitles.Controls.Add(Me.lblLegendTitle)
        Me.tbpTitles.Controls.Add(Me.lblTag)
        Me.tbpTitles.Controls.Add(Me.lblCaption)
        Me.tbpTitles.Controls.Add(Me.lblSubTitle)
        Me.tbpTitles.Controls.Add(Me.lblTitle)
        Me.tbpTitles.Controls.Add(Me.grpLegendTitle)
        Me.tbpTitles.Controls.Add(Me.ucrNudLegendSize)
        Me.tbpTitles.Controls.Add(Me.ucrNudTagSize)
        Me.tbpTitles.Controls.Add(Me.ucrChkTag)
        Me.tbpTitles.Controls.Add(Me.ucrChkNewLegend)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphCaption)
        Me.tbpTitles.Controls.Add(Me.ucrNudCaptionSize)
        Me.tbpTitles.Controls.Add(Me.ucrNudSubTitleSize)
        Me.tbpTitles.Controls.Add(Me.ucrNudTitleSize)
        Me.tbpTitles.Controls.Add(Me.ucrInputLegendTitle)
        Me.tbpTitles.Controls.Add(Me.ucrInputTag)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphSubTitle)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphTitle)
        Me.tbpTitles.Location = New System.Drawing.Point(4, 22)
        Me.tbpTitles.Name = "tbpTitles"
        Me.tbpTitles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTitles.Size = New System.Drawing.Size(669, 710)
        Me.tbpTitles.TabIndex = 2
        Me.tbpTitles.Tag = "Titles"
        Me.tbpTitles.Text = "Titles"
        Me.tbpTitles.UseVisualStyleBackColor = True
        '
        'ucrChkIncludeTitles
        '
        Me.ucrChkIncludeTitles.AutoSize = True
        Me.ucrChkIncludeTitles.Checked = False
        Me.ucrChkIncludeTitles.Location = New System.Drawing.Point(6, 10)
        Me.ucrChkIncludeTitles.Name = "ucrChkIncludeTitles"
        Me.ucrChkIncludeTitles.Size = New System.Drawing.Size(121, 23)
        Me.ucrChkIncludeTitles.TabIndex = 55
        '
        'lblLegendSize
        '
        Me.lblLegendSize.AutoSize = True
        Me.lblLegendSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLegendSize.Location = New System.Drawing.Point(320, 207)
        Me.lblLegendSize.Name = "lblLegendSize"
        Me.lblLegendSize.Size = New System.Drawing.Size(69, 13)
        Me.lblLegendSize.TabIndex = 54
        Me.lblLegendSize.Text = "Legend Size:"
        '
        'lblTagSize
        '
        Me.lblTagSize.AutoSize = True
        Me.lblTagSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTagSize.Location = New System.Drawing.Point(320, 168)
        Me.lblTagSize.Name = "lblTagSize"
        Me.lblTagSize.Size = New System.Drawing.Size(52, 13)
        Me.lblTagSize.TabIndex = 52
        Me.lblTagSize.Text = "Tag Size:"
        '
        'lblCaptionSize
        '
        Me.lblCaptionSize.AutoSize = True
        Me.lblCaptionSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCaptionSize.Location = New System.Drawing.Point(320, 115)
        Me.lblCaptionSize.Name = "lblCaptionSize"
        Me.lblCaptionSize.Size = New System.Drawing.Size(69, 13)
        Me.lblCaptionSize.TabIndex = 45
        Me.lblCaptionSize.Text = "Caption Size:"
        '
        'lblSubTitleSize
        '
        Me.lblSubTitleSize.AutoSize = True
        Me.lblSubTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubTitleSize.Location = New System.Drawing.Point(318, 72)
        Me.lblSubTitleSize.Name = "lblSubTitleSize"
        Me.lblSubTitleSize.Size = New System.Drawing.Size(75, 13)
        Me.lblSubTitleSize.TabIndex = 46
        Me.lblSubTitleSize.Text = "Sub Title Size:"
        '
        'lblTitleSize
        '
        Me.lblTitleSize.AutoSize = True
        Me.lblTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitleSize.Location = New System.Drawing.Point(318, 42)
        Me.lblTitleSize.Name = "lblTitleSize"
        Me.lblTitleSize.Size = New System.Drawing.Size(53, 13)
        Me.lblTitleSize.TabIndex = 47
        Me.lblTitleSize.Text = "Title Size:"
        '
        'lblLegendTitle
        '
        Me.lblLegendTitle.AutoSize = True
        Me.lblLegendTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLegendTitle.Location = New System.Drawing.Point(126, 207)
        Me.lblLegendTitle.Name = "lblLegendTitle"
        Me.lblLegendTitle.Size = New System.Drawing.Size(72, 13)
        Me.lblLegendTitle.TabIndex = 40
        Me.lblLegendTitle.Text = " Legend Title:"
        '
        'lblTag
        '
        Me.lblTag.AutoSize = True
        Me.lblTag.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTag.Location = New System.Drawing.Point(126, 168)
        Me.lblTag.Name = "lblTag"
        Me.lblTag.Size = New System.Drawing.Size(29, 13)
        Me.lblTag.TabIndex = 36
        Me.lblTag.Text = "Tag:"
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCaption.Location = New System.Drawing.Point(6, 114)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(78, 13)
        Me.lblCaption.TabIndex = 10
        Me.lblCaption.Text = "Graph Caption:"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubTitle.Location = New System.Drawing.Point(6, 65)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(84, 13)
        Me.lblSubTitle.TabIndex = 10
        Me.lblSubTitle.Text = "Graph Sub Title:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitle.Location = New System.Drawing.Point(7, 41)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(62, 13)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Graph Title:"
        '
        'grpLegendTitle
        '
        Me.grpLegendTitle.Controls.Add(Me.ucrChkOverwriteLegendTitle)
        Me.grpLegendTitle.Controls.Add(Me.ucrChkDisplayLegendTitle)
        Me.grpLegendTitle.Controls.Add(Me.ucrInputLegend)
        Me.grpLegendTitle.Controls.Add(Me.rdoLegendTitleCustom)
        Me.grpLegendTitle.Controls.Add(Me.rdoLegendTitleAuto)
        Me.grpLegendTitle.Controls.Add(Me.ucrPnlLegendTitle)
        Me.grpLegendTitle.Location = New System.Drawing.Point(10, 257)
        Me.grpLegendTitle.Name = "grpLegendTitle"
        Me.grpLegendTitle.Size = New System.Drawing.Size(299, 105)
        Me.grpLegendTitle.TabIndex = 8
        Me.grpLegendTitle.TabStop = False
        Me.grpLegendTitle.Text = "Legend Title"
        Me.grpLegendTitle.Visible = False
        '
        'ucrChkOverwriteLegendTitle
        '
        Me.ucrChkOverwriteLegendTitle.AutoSize = True
        Me.ucrChkOverwriteLegendTitle.Checked = False
        Me.ucrChkOverwriteLegendTitle.Location = New System.Drawing.Point(6, 75)
        Me.ucrChkOverwriteLegendTitle.Name = "ucrChkOverwriteLegendTitle"
        Me.ucrChkOverwriteLegendTitle.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkOverwriteLegendTitle.TabIndex = 14
        '
        'ucrChkDisplayLegendTitle
        '
        Me.ucrChkDisplayLegendTitle.AutoSize = True
        Me.ucrChkDisplayLegendTitle.Checked = False
        Me.ucrChkDisplayLegendTitle.Location = New System.Drawing.Point(6, 51)
        Me.ucrChkDisplayLegendTitle.Name = "ucrChkDisplayLegendTitle"
        Me.ucrChkDisplayLegendTitle.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkDisplayLegendTitle.TabIndex = 13
        '
        'ucrInputLegend
        '
        Me.ucrInputLegend.AddQuotesIfUnrecognised = True
        Me.ucrInputLegend.AutoSize = True
        Me.ucrInputLegend.IsMultiline = False
        Me.ucrInputLegend.IsReadOnly = False
        Me.ucrInputLegend.Location = New System.Drawing.Point(133, 74)
        Me.ucrInputLegend.Name = "ucrInputLegend"
        Me.ucrInputLegend.Size = New System.Drawing.Size(160, 21)
        Me.ucrInputLegend.TabIndex = 11
        '
        'rdoLegendTitleCustom
        '
        Me.rdoLegendTitleCustom.AutoSize = True
        Me.rdoLegendTitleCustom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLegendTitleCustom.Location = New System.Drawing.Point(73, 23)
        Me.rdoLegendTitleCustom.Name = "rdoLegendTitleCustom"
        Me.rdoLegendTitleCustom.Size = New System.Drawing.Size(60, 17)
        Me.rdoLegendTitleCustom.TabIndex = 10
        Me.rdoLegendTitleCustom.TabStop = True
        Me.rdoLegendTitleCustom.Text = "Custom"
        Me.rdoLegendTitleCustom.UseVisualStyleBackColor = True
        '
        'rdoLegendTitleAuto
        '
        Me.rdoLegendTitleAuto.AutoSize = True
        Me.rdoLegendTitleAuto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLegendTitleAuto.Location = New System.Drawing.Point(6, 23)
        Me.rdoLegendTitleAuto.Name = "rdoLegendTitleAuto"
        Me.rdoLegendTitleAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoLegendTitleAuto.TabIndex = 9
        Me.rdoLegendTitleAuto.TabStop = True
        Me.rdoLegendTitleAuto.Text = "Auto"
        Me.rdoLegendTitleAuto.UseVisualStyleBackColor = True
        '
        'ucrPnlLegendTitle
        '
        Me.ucrPnlLegendTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlLegendTitle.Location = New System.Drawing.Point(4, 20)
        Me.ucrPnlLegendTitle.Name = "ucrPnlLegendTitle"
        Me.ucrPnlLegendTitle.Size = New System.Drawing.Size(117, 25)
        Me.ucrPnlLegendTitle.TabIndex = 12
        '
        'ucrNudLegendSize
        '
        Me.ucrNudLegendSize.AutoSize = True
        Me.ucrNudLegendSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLegendSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLegendSize.Location = New System.Drawing.Point(434, 203)
        Me.ucrNudLegendSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudLegendSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLegendSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLegendSize.Name = "ucrNudLegendSize"
        Me.ucrNudLegendSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLegendSize.TabIndex = 53
        Me.ucrNudLegendSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTagSize
        '
        Me.ucrNudTagSize.AutoSize = True
        Me.ucrNudTagSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTagSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTagSize.Location = New System.Drawing.Point(434, 165)
        Me.ucrNudTagSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudTagSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTagSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTagSize.Name = "ucrNudTagSize"
        Me.ucrNudTagSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTagSize.TabIndex = 51
        Me.ucrNudTagSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkTag
        '
        Me.ucrChkTag.AutoSize = True
        Me.ucrChkTag.Checked = False
        Me.ucrChkTag.Location = New System.Drawing.Point(6, 165)
        Me.ucrChkTag.Name = "ucrChkTag"
        Me.ucrChkTag.Size = New System.Drawing.Size(104, 23)
        Me.ucrChkTag.TabIndex = 50
        '
        'ucrChkNewLegend
        '
        Me.ucrChkNewLegend.AutoSize = True
        Me.ucrChkNewLegend.Checked = False
        Me.ucrChkNewLegend.Location = New System.Drawing.Point(6, 203)
        Me.ucrChkNewLegend.Name = "ucrChkNewLegend"
        Me.ucrChkNewLegend.Size = New System.Drawing.Size(125, 23)
        Me.ucrChkNewLegend.TabIndex = 49
        '
        'ucrInputGraphCaption
        '
        Me.ucrInputGraphCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphCaption.AutoSize = True
        Me.ucrInputGraphCaption.IsMultiline = True
        Me.ucrInputGraphCaption.IsReadOnly = False
        Me.ucrInputGraphCaption.Location = New System.Drawing.Point(126, 96)
        Me.ucrInputGraphCaption.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputGraphCaption.Name = "ucrInputGraphCaption"
        Me.ucrInputGraphCaption.Size = New System.Drawing.Size(181, 53)
        Me.ucrInputGraphCaption.TabIndex = 48
        '
        'ucrNudCaptionSize
        '
        Me.ucrNudCaptionSize.AutoSize = True
        Me.ucrNudCaptionSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCaptionSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCaptionSize.Location = New System.Drawing.Point(434, 113)
        Me.ucrNudCaptionSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudCaptionSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCaptionSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCaptionSize.Name = "ucrNudCaptionSize"
        Me.ucrNudCaptionSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCaptionSize.TabIndex = 44
        Me.ucrNudCaptionSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSubTitleSize
        '
        Me.ucrNudSubTitleSize.AutoSize = True
        Me.ucrNudSubTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSubTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSubTitleSize.Location = New System.Drawing.Point(434, 67)
        Me.ucrNudSubTitleSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudSubTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSubTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSubTitleSize.Name = "ucrNudSubTitleSize"
        Me.ucrNudSubTitleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSubTitleSize.TabIndex = 43
        Me.ucrNudSubTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTitleSize
        '
        Me.ucrNudTitleSize.AutoSize = True
        Me.ucrNudTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTitleSize.Location = New System.Drawing.Point(434, 37)
        Me.ucrNudTitleSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Name = "ucrNudTitleSize"
        Me.ucrNudTitleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTitleSize.TabIndex = 42
        Me.ucrNudTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputLegendTitle
        '
        Me.ucrInputLegendTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendTitle.AutoSize = True
        Me.ucrInputLegendTitle.IsMultiline = False
        Me.ucrInputLegendTitle.IsReadOnly = False
        Me.ucrInputLegendTitle.Location = New System.Drawing.Point(205, 203)
        Me.ucrInputLegendTitle.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputLegendTitle.Name = "ucrInputLegendTitle"
        Me.ucrInputLegendTitle.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputLegendTitle.TabIndex = 38
        '
        'ucrInputTag
        '
        Me.ucrInputTag.AddQuotesIfUnrecognised = True
        Me.ucrInputTag.AutoSize = True
        Me.ucrInputTag.IsMultiline = False
        Me.ucrInputTag.IsReadOnly = False
        Me.ucrInputTag.Location = New System.Drawing.Point(205, 165)
        Me.ucrInputTag.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputTag.Name = "ucrInputTag"
        Me.ucrInputTag.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputTag.TabIndex = 35
        '
        'ucrInputGraphSubTitle
        '
        Me.ucrInputGraphSubTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphSubTitle.AutoSize = True
        Me.ucrInputGraphSubTitle.IsMultiline = False
        Me.ucrInputGraphSubTitle.IsReadOnly = False
        Me.ucrInputGraphSubTitle.Location = New System.Drawing.Point(126, 68)
        Me.ucrInputGraphSubTitle.Name = "ucrInputGraphSubTitle"
        Me.ucrInputGraphSubTitle.Size = New System.Drawing.Size(166, 21)
        Me.ucrInputGraphSubTitle.TabIndex = 9
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.AutoSize = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        Me.ucrInputGraphTitle.Location = New System.Drawing.Point(126, 41)
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        Me.ucrInputGraphTitle.Size = New System.Drawing.Size(166, 21)
        Me.ucrInputGraphTitle.TabIndex = 9
        '
        'tbpXAxis
        '
        Me.tbpXAxis.Controls.Add(Me.ucrXAxis)
        Me.tbpXAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbpXAxis.Name = "tbpXAxis"
        Me.tbpXAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpXAxis.Size = New System.Drawing.Size(669, 710)
        Me.tbpXAxis.TabIndex = 5
        Me.tbpXAxis.Text = "X-Axis"
        Me.tbpXAxis.UseVisualStyleBackColor = True
        '
        'ucrXAxis
        '
        Me.ucrXAxis.AutoSize = True
        Me.ucrXAxis.Location = New System.Drawing.Point(-4, 3)
        Me.ucrXAxis.Name = "ucrXAxis"
        Me.ucrXAxis.Size = New System.Drawing.Size(669, 463)
        Me.ucrXAxis.TabIndex = 0
        '
        'tbpYAxis
        '
        Me.tbpYAxis.Controls.Add(Me.ucrYAxis)
        Me.tbpYAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbpYAxis.Name = "tbpYAxis"
        Me.tbpYAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpYAxis.Size = New System.Drawing.Size(669, 710)
        Me.tbpYAxis.TabIndex = 6
        Me.tbpYAxis.Text = "Y-Axis"
        Me.tbpYAxis.UseVisualStyleBackColor = True
        '
        'ucrYAxis
        '
        Me.ucrYAxis.AutoSize = True
        Me.ucrYAxis.Location = New System.Drawing.Point(0, 1)
        Me.ucrYAxis.Name = "ucrYAxis"
        Me.ucrYAxis.Size = New System.Drawing.Size(669, 463)
        Me.ucrYAxis.TabIndex = 0
        '
        'tbpTheme
        '
        Me.tbpTheme.Controls.Add(Me.cmdSimpleOptions)
        Me.tbpTheme.Controls.Add(Me.grpCommonOptions)
        Me.tbpTheme.Controls.Add(Me.lblFont)
        Me.tbpTheme.Controls.Add(Me.cmdAllOptions)
        Me.tbpTheme.Controls.Add(Me.urChkSelectTheme)
        Me.tbpTheme.Controls.Add(Me.ucrInputThemes)
        Me.tbpTheme.Location = New System.Drawing.Point(4, 22)
        Me.tbpTheme.Name = "tbpTheme"
        Me.tbpTheme.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTheme.Size = New System.Drawing.Size(669, 710)
        Me.tbpTheme.TabIndex = 1
        Me.tbpTheme.Tag = "Theme"
        Me.tbpTheme.Text = "Themes"
        Me.tbpTheme.UseVisualStyleBackColor = True
        '
        'cmdSimpleOptions
        '
        Me.cmdSimpleOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSimpleOptions.Location = New System.Drawing.Point(174, 49)
        Me.cmdSimpleOptions.Name = "cmdSimpleOptions"
        Me.cmdSimpleOptions.Size = New System.Drawing.Size(135, 23)
        Me.cmdSimpleOptions.TabIndex = 107
        Me.cmdSimpleOptions.Text = "Simple Options"
        Me.cmdSimpleOptions.UseVisualStyleBackColor = True
        '
        'grpCommonOptions
        '
        Me.grpCommonOptions.Controls.Add(Me.ucrNudYaxisMarkSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrNudXaxisMarkSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrNudYSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrNudXSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrNudXAngle)
        Me.grpCommonOptions.Controls.Add(Me.ucrInputLegendPosition)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkYaxisTickMarkLabelSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkXaxisTickMarkLabelSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkYaxisSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkXaxisSize)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkXaxisAngle)
        Me.grpCommonOptions.Controls.Add(Me.ucrChkLegendPosition)
        Me.grpCommonOptions.Location = New System.Drawing.Point(7, 81)
        Me.grpCommonOptions.Name = "grpCommonOptions"
        Me.grpCommonOptions.Size = New System.Drawing.Size(497, 243)
        Me.grpCommonOptions.TabIndex = 5
        Me.grpCommonOptions.TabStop = False
        Me.grpCommonOptions.Text = "Common Options"
        '
        'ucrNudYaxisMarkSize
        '
        Me.ucrNudYaxisMarkSize.AutoSize = True
        Me.ucrNudYaxisMarkSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYaxisMarkSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudYaxisMarkSize.Location = New System.Drawing.Point(246, 205)
        Me.ucrNudYaxisMarkSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYaxisMarkSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYaxisMarkSize.Name = "ucrNudYaxisMarkSize"
        Me.ucrNudYaxisMarkSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudYaxisMarkSize.TabIndex = 11
        Me.ucrNudYaxisMarkSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudXaxisMarkSize
        '
        Me.ucrNudXaxisMarkSize.AutoSize = True
        Me.ucrNudXaxisMarkSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisMarkSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXaxisMarkSize.Location = New System.Drawing.Point(246, 169)
        Me.ucrNudXaxisMarkSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXaxisMarkSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisMarkSize.Name = "ucrNudXaxisMarkSize"
        Me.ucrNudXaxisMarkSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXaxisMarkSize.TabIndex = 10
        Me.ucrNudXaxisMarkSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudYSize
        '
        Me.ucrNudYSize.AutoSize = True
        Me.ucrNudYSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudYSize.Location = New System.Drawing.Point(246, 133)
        Me.ucrNudYSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYSize.Name = "ucrNudYSize"
        Me.ucrNudYSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudYSize.TabIndex = 9
        Me.ucrNudYSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudXSize
        '
        Me.ucrNudXSize.AutoSize = True
        Me.ucrNudXSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXSize.Location = New System.Drawing.Point(246, 97)
        Me.ucrNudXSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXSize.Name = "ucrNudXSize"
        Me.ucrNudXSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXSize.TabIndex = 8
        Me.ucrNudXSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudXAngle
        '
        Me.ucrNudXAngle.AutoSize = True
        Me.ucrNudXAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXAngle.Location = New System.Drawing.Point(246, 61)
        Me.ucrNudXAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAngle.Name = "ucrNudXAngle"
        Me.ucrNudXAngle.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXAngle.TabIndex = 7
        Me.ucrNudXAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(246, 25)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLegendPosition.TabIndex = 6
        '
        'ucrChkYaxisTickMarkLabelSize
        '
        Me.ucrChkYaxisTickMarkLabelSize.AutoSize = True
        Me.ucrChkYaxisTickMarkLabelSize.Checked = False
        Me.ucrChkYaxisTickMarkLabelSize.Location = New System.Drawing.Point(6, 205)
        Me.ucrChkYaxisTickMarkLabelSize.Name = "ucrChkYaxisTickMarkLabelSize"
        Me.ucrChkYaxisTickMarkLabelSize.Size = New System.Drawing.Size(234, 23)
        Me.ucrChkYaxisTickMarkLabelSize.TabIndex = 5
        '
        'ucrChkXaxisTickMarkLabelSize
        '
        Me.ucrChkXaxisTickMarkLabelSize.AutoSize = True
        Me.ucrChkXaxisTickMarkLabelSize.Checked = False
        Me.ucrChkXaxisTickMarkLabelSize.Location = New System.Drawing.Point(6, 169)
        Me.ucrChkXaxisTickMarkLabelSize.Name = "ucrChkXaxisTickMarkLabelSize"
        Me.ucrChkXaxisTickMarkLabelSize.Size = New System.Drawing.Size(234, 23)
        Me.ucrChkXaxisTickMarkLabelSize.TabIndex = 4
        '
        'ucrChkYaxisSize
        '
        Me.ucrChkYaxisSize.AutoSize = True
        Me.ucrChkYaxisSize.Checked = False
        Me.ucrChkYaxisSize.Location = New System.Drawing.Point(6, 133)
        Me.ucrChkYaxisSize.Name = "ucrChkYaxisSize"
        Me.ucrChkYaxisSize.Size = New System.Drawing.Size(234, 23)
        Me.ucrChkYaxisSize.TabIndex = 3
        '
        'ucrChkXaxisSize
        '
        Me.ucrChkXaxisSize.AutoSize = True
        Me.ucrChkXaxisSize.Checked = False
        Me.ucrChkXaxisSize.Location = New System.Drawing.Point(6, 97)
        Me.ucrChkXaxisSize.Name = "ucrChkXaxisSize"
        Me.ucrChkXaxisSize.Size = New System.Drawing.Size(234, 23)
        Me.ucrChkXaxisSize.TabIndex = 2
        '
        'ucrChkXaxisAngle
        '
        Me.ucrChkXaxisAngle.AutoSize = True
        Me.ucrChkXaxisAngle.Checked = False
        Me.ucrChkXaxisAngle.Location = New System.Drawing.Point(6, 61)
        Me.ucrChkXaxisAngle.Name = "ucrChkXaxisAngle"
        Me.ucrChkXaxisAngle.Size = New System.Drawing.Size(234, 23)
        Me.ucrChkXaxisAngle.TabIndex = 1
        '
        'ucrChkLegendPosition
        '
        Me.ucrChkLegendPosition.AutoSize = True
        Me.ucrChkLegendPosition.Checked = False
        Me.ucrChkLegendPosition.Location = New System.Drawing.Point(6, 25)
        Me.ucrChkLegendPosition.Name = "ucrChkLegendPosition"
        Me.ucrChkLegendPosition.Size = New System.Drawing.Size(234, 23)
        Me.ucrChkLegendPosition.TabIndex = 0
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFont.Location = New System.Drawing.Point(233, 49)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(0, 13)
        Me.lblFont.TabIndex = 4
        '
        'cmdAllOptions
        '
        Me.cmdAllOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAllOptions.Location = New System.Drawing.Point(29, 49)
        Me.cmdAllOptions.Name = "cmdAllOptions"
        Me.cmdAllOptions.Size = New System.Drawing.Size(139, 23)
        Me.cmdAllOptions.TabIndex = 2
        Me.cmdAllOptions.Text = "All Options"
        Me.cmdAllOptions.UseVisualStyleBackColor = True
        '
        'urChkSelectTheme
        '
        Me.urChkSelectTheme.AutoSize = True
        Me.urChkSelectTheme.Checked = False
        Me.urChkSelectTheme.Location = New System.Drawing.Point(29, 19)
        Me.urChkSelectTheme.Name = "urChkSelectTheme"
        Me.urChkSelectTheme.Size = New System.Drawing.Size(139, 23)
        Me.urChkSelectTheme.TabIndex = 106
        '
        'ucrInputThemes
        '
        Me.ucrInputThemes.AddQuotesIfUnrecognised = True
        Me.ucrInputThemes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputThemes.GetSetSelectedIndex = -1
        Me.ucrInputThemes.IsReadOnly = False
        Me.ucrInputThemes.Location = New System.Drawing.Point(174, 19)
        Me.ucrInputThemes.Name = "ucrInputThemes"
        Me.ucrInputThemes.Size = New System.Drawing.Size(171, 21)
        Me.ucrInputThemes.TabIndex = 1
        '
        'tbpCoordinates
        '
        Me.tbpCoordinates.Controls.Add(Me.grpPolarCordinates)
        Me.tbpCoordinates.Controls.Add(Me.ucrChkSameScale)
        Me.tbpCoordinates.Controls.Add(Me.ucrChkHorizontalPlot)
        Me.tbpCoordinates.Location = New System.Drawing.Point(4, 22)
        Me.tbpCoordinates.Name = "tbpCoordinates"
        Me.tbpCoordinates.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCoordinates.Size = New System.Drawing.Size(669, 710)
        Me.tbpCoordinates.TabIndex = 7
        Me.tbpCoordinates.Text = "Coordinates"
        Me.tbpCoordinates.UseVisualStyleBackColor = True
        '
        'grpPolarCordinates
        '
        Me.grpPolarCordinates.Controls.Add(Me.ucrInputPolarCoordinates)
        Me.grpPolarCordinates.Controls.Add(Me.lblPolarCoordinate)
        Me.grpPolarCordinates.Controls.Add(Me.lblStartingAngle)
        Me.grpPolarCordinates.Controls.Add(Me.ucrChkUsePolarCoordinates)
        Me.grpPolarCordinates.Controls.Add(Me.lblPi)
        Me.grpPolarCordinates.Controls.Add(Me.ucrChkDirectionAnticlockwise)
        Me.grpPolarCordinates.Controls.Add(Me.ucrInputStartingAngle)
        Me.grpPolarCordinates.Location = New System.Drawing.Point(3, 67)
        Me.grpPolarCordinates.Name = "grpPolarCordinates"
        Me.grpPolarCordinates.Size = New System.Drawing.Size(300, 136)
        Me.grpPolarCordinates.TabIndex = 22
        Me.grpPolarCordinates.TabStop = False
        Me.grpPolarCordinates.Text = "Polar Cordinates"
        '
        'ucrInputPolarCoordinates
        '
        Me.ucrInputPolarCoordinates.AddQuotesIfUnrecognised = True
        Me.ucrInputPolarCoordinates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPolarCoordinates.GetSetSelectedIndex = -1
        Me.ucrInputPolarCoordinates.IsReadOnly = False
        Me.ucrInputPolarCoordinates.Location = New System.Drawing.Point(141, 43)
        Me.ucrInputPolarCoordinates.Name = "ucrInputPolarCoordinates"
        Me.ucrInputPolarCoordinates.Size = New System.Drawing.Size(65, 21)
        Me.ucrInputPolarCoordinates.TabIndex = 24
        '
        'lblPolarCoordinate
        '
        Me.lblPolarCoordinate.AutoSize = True
        Me.lblPolarCoordinate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPolarCoordinate.Location = New System.Drawing.Point(10, 46)
        Me.lblPolarCoordinate.Name = "lblPolarCoordinate"
        Me.lblPolarCoordinate.Size = New System.Drawing.Size(88, 13)
        Me.lblPolarCoordinate.TabIndex = 23
        Me.lblPolarCoordinate.Text = "Polar Coordinate:"
        '
        'lblStartingAngle
        '
        Me.lblStartingAngle.AutoSize = True
        Me.lblStartingAngle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStartingAngle.Location = New System.Drawing.Point(10, 99)
        Me.lblStartingAngle.Name = "lblStartingAngle"
        Me.lblStartingAngle.Size = New System.Drawing.Size(76, 13)
        Me.lblStartingAngle.TabIndex = 22
        Me.lblStartingAngle.Text = "Starting Angle:"
        '
        'ucrChkUsePolarCoordinates
        '
        Me.ucrChkUsePolarCoordinates.AutoSize = True
        Me.ucrChkUsePolarCoordinates.Checked = False
        Me.ucrChkUsePolarCoordinates.Location = New System.Drawing.Point(12, 19)
        Me.ucrChkUsePolarCoordinates.Name = "ucrChkUsePolarCoordinates"
        Me.ucrChkUsePolarCoordinates.Size = New System.Drawing.Size(194, 23)
        Me.ucrChkUsePolarCoordinates.TabIndex = 16
        '
        'lblPi
        '
        Me.lblPi.AutoSize = True
        Me.lblPi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPi.Location = New System.Drawing.Point(191, 103)
        Me.lblPi.Name = "lblPi"
        Me.lblPi.Size = New System.Drawing.Size(15, 13)
        Me.lblPi.TabIndex = 21
        Me.lblPi.Tag = ""
        Me.lblPi.Text = "pi"
        '
        'ucrChkDirectionAnticlockwise
        '
        Me.ucrChkDirectionAnticlockwise.AutoSize = True
        Me.ucrChkDirectionAnticlockwise.Checked = False
        Me.ucrChkDirectionAnticlockwise.Location = New System.Drawing.Point(12, 70)
        Me.ucrChkDirectionAnticlockwise.Name = "ucrChkDirectionAnticlockwise"
        Me.ucrChkDirectionAnticlockwise.Size = New System.Drawing.Size(194, 23)
        Me.ucrChkDirectionAnticlockwise.TabIndex = 17
        '
        'ucrInputStartingAngle
        '
        Me.ucrInputStartingAngle.AddQuotesIfUnrecognised = True
        Me.ucrInputStartingAngle.AutoSize = True
        Me.ucrInputStartingAngle.IsMultiline = False
        Me.ucrInputStartingAngle.IsReadOnly = False
        Me.ucrInputStartingAngle.Location = New System.Drawing.Point(141, 95)
        Me.ucrInputStartingAngle.Name = "ucrInputStartingAngle"
        Me.ucrInputStartingAngle.Size = New System.Drawing.Size(43, 21)
        Me.ucrInputStartingAngle.TabIndex = 19
        '
        'ucrChkSameScale
        '
        Me.ucrChkSameScale.AutoSize = True
        Me.ucrChkSameScale.Checked = False
        Me.ucrChkSameScale.Location = New System.Drawing.Point(13, 41)
        Me.ucrChkSameScale.Name = "ucrChkSameScale"
        Me.ucrChkSameScale.Size = New System.Drawing.Size(233, 23)
        Me.ucrChkSameScale.TabIndex = 15
        '
        'ucrChkHorizontalPlot
        '
        Me.ucrChkHorizontalPlot.AutoSize = True
        Me.ucrChkHorizontalPlot.Checked = False
        Me.ucrChkHorizontalPlot.Location = New System.Drawing.Point(13, 15)
        Me.ucrChkHorizontalPlot.Name = "ucrChkHorizontalPlot"
        Me.ucrChkHorizontalPlot.Size = New System.Drawing.Size(233, 23)
        Me.ucrChkHorizontalPlot.TabIndex = 14
        '
        'tbpColour
        '
        Me.tbpColour.Controls.Add(Me.grpScalecolorpt)
        Me.tbpColour.Controls.Add(Me.grpScaleColorfiv)
        Me.tbpColour.Controls.Add(Me.grpScalecolorExn)
        Me.tbpColour.Controls.Add(Me.grpScalecolorst)
        Me.tbpColour.Controls.Add(Me.grpScalecolorEcon)
        Me.tbpColour.Controls.Add(Me.grpScalecolorEx)
        Me.tbpColour.Controls.Add(Me.grpColourScaleGgthemes)
        Me.tbpColour.Controls.Add(Me.grpScalecolorg)
        Me.tbpColour.Controls.Add(Me.grpScalecolorpan)
        Me.tbpColour.Controls.Add(Me.grpScalecolorsol)
        Me.tbpColour.Controls.Add(Me.grpScalecolorfew)
        Me.tbpColour.Controls.Add(Me.grpScalecolorhc)
        Me.tbpColour.Controls.Add(Me.grpScalecolorcal)
        Me.tbpColour.Controls.Add(Me.grpScaleFillfiv)
        Me.tbpColour.Controls.Add(Me.grpScalefillpt)
        Me.tbpColour.Controls.Add(Me.grpScalefillw)
        Me.tbpColour.Controls.Add(Me.grpScalefillst)
        Me.tbpColour.Controls.Add(Me.grpScalefillpan)
        Me.tbpColour.Controls.Add(Me.grpScalefillCal)
        Me.tbpColour.Controls.Add(Me.grpScalefillg)
        Me.tbpColour.Controls.Add(Me.grpScalefillEx)
        Me.tbpColour.Controls.Add(Me.grpScalefillEcon)
        Me.tbpColour.Controls.Add(Me.grpScalefillExn)
        Me.tbpColour.Controls.Add(Me.grpScalefillsol)
        Me.tbpColour.Controls.Add(Me.grpFillScaleggthemes)
        Me.tbpColour.Controls.Add(Me.grpScalefillfew)
        Me.tbpColour.Controls.Add(Me.grpScalefillhc)
        Me.tbpColour.Controls.Add(Me.grpScaleColorw)
        Me.tbpColour.Controls.Add(Me.lblCanvasColorPalette)
        Me.tbpColour.Controls.Add(Me.ucrInputCanvasColorPalette)
        Me.tbpColour.Controls.Add(Me.lblGgthemesFunctions)
        Me.tbpColour.Controls.Add(Me.ucrInputColorFunctions)
        Me.tbpColour.Controls.Add(Me.lblFillFunction)
        Me.tbpColour.Controls.Add(Me.ucrInputFillFunction)
        Me.tbpColour.Controls.Add(Me.lblCanvasFillPalette)
        Me.tbpColour.Controls.Add(Me.ucrInputCanvasFillPalette)
        Me.tbpColour.Controls.Add(Me.ucrChkUseFill)
        Me.tbpColour.Controls.Add(Me.ucrChkUseColor)
        Me.tbpColour.Controls.Add(Me.rdoGgthemes)
        Me.tbpColour.Controls.Add(Me.rdoViridis)
        Me.tbpColour.Controls.Add(Me.lblPalette)
        Me.tbpColour.Controls.Add(Me.ucrInputPalettes)
        Me.tbpColour.Controls.Add(Me.rdoQualitative)
        Me.tbpColour.Controls.Add(Me.rdoSequential)
        Me.tbpColour.Controls.Add(Me.rdoDiverging)
        Me.tbpColour.Controls.Add(Me.ucrPnlColourPalette)
        Me.tbpColour.Controls.Add(Me.ucrInputAxisType)
        Me.tbpColour.Controls.Add(Me.ucrChkAddColour)
        Me.tbpColour.Controls.Add(Me.ucrChkAddFillScale)
        Me.tbpColour.Controls.Add(Me.grpColourScale)
        Me.tbpColour.Controls.Add(Me.grpFillScale)
        Me.tbpColour.Controls.Add(Me.lblPalcontinuouscolor)
        Me.tbpColour.Controls.Add(Me.ucrInputcontinuouscolor)
        Me.tbpColour.Controls.Add(Me.lblPaletteContinuousfill)
        Me.tbpColour.Controls.Add(Me.ucrInputContinousfill)
        Me.tbpColour.Controls.Add(Me.lblPaletteContinuous)
        Me.tbpColour.Controls.Add(Me.ucrInputPaletteContinuous)
        Me.tbpColour.Location = New System.Drawing.Point(4, 22)
        Me.tbpColour.Name = "tbpColour"
        Me.tbpColour.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpColour.Size = New System.Drawing.Size(669, 710)
        Me.tbpColour.TabIndex = 8
        Me.tbpColour.Text = "Colour"
        Me.tbpColour.UseVisualStyleBackColor = True
        '
        'grpScalecolorpt
        '
        Me.grpScalecolorpt.Controls.Add(Me.ucrInputTextBreaksColorpt)
        Me.grpScalecolorpt.Controls.Add(Me.ucrInputTextNaValueColorpt)
        Me.grpScalecolorpt.Controls.Add(Me.ucrInputTextLimitColorpt)
        Me.grpScalecolorpt.Controls.Add(Me.ucrInputTextExpandColorpt)
        Me.grpScalecolorpt.Controls.Add(Me.ucrInputPositionColorpt)
        Me.grpScalecolorpt.Controls.Add(Me.ucrInputDropUnusedLevelsColorpt)
        Me.grpScalecolorpt.Controls.Add(Me.ucrChkExpandColorpt)
        Me.grpScalecolorpt.Controls.Add(Me.ucrChkPositionColorpt)
        Me.grpScalecolorpt.Controls.Add(Me.ucrChkLimitColorpt)
        Me.grpScalecolorpt.Controls.Add(Me.ucrChkBreaksColorpt)
        Me.grpScalecolorpt.Controls.Add(Me.ucrChkNaValueColorpt)
        Me.grpScalecolorpt.Controls.Add(Me.ucrChkDropUnusedLevelsColorpt)
        Me.grpScalecolorpt.Location = New System.Drawing.Point(10, 460)
        Me.grpScalecolorpt.Name = "grpScalecolorpt"
        Me.grpScalecolorpt.Size = New System.Drawing.Size(447, 170)
        Me.grpScalecolorpt.TabIndex = 266
        Me.grpScalecolorpt.TabStop = False
        Me.grpScalecolorpt.Text = "Colour Scale"
        '
        'ucrInputTextBreaksColorpt
        '
        Me.ucrInputTextBreaksColorpt.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksColorpt.AutoSize = True
        Me.ucrInputTextBreaksColorpt.IsMultiline = False
        Me.ucrInputTextBreaksColorpt.IsReadOnly = False
        Me.ucrInputTextBreaksColorpt.Location = New System.Drawing.Point(286, 40)
        Me.ucrInputTextBreaksColorpt.Name = "ucrInputTextBreaksColorpt"
        Me.ucrInputTextBreaksColorpt.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksColorpt.TabIndex = 245
        '
        'ucrInputTextNaValueColorpt
        '
        Me.ucrInputTextNaValueColorpt.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueColorpt.AutoSize = True
        Me.ucrInputTextNaValueColorpt.IsMultiline = False
        Me.ucrInputTextNaValueColorpt.IsReadOnly = False
        Me.ucrInputTextNaValueColorpt.Location = New System.Drawing.Point(286, 140)
        Me.ucrInputTextNaValueColorpt.Name = "ucrInputTextNaValueColorpt"
        Me.ucrInputTextNaValueColorpt.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueColorpt.TabIndex = 244
        '
        'ucrInputTextLimitColorpt
        '
        Me.ucrInputTextLimitColorpt.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitColorpt.AutoSize = True
        Me.ucrInputTextLimitColorpt.IsMultiline = False
        Me.ucrInputTextLimitColorpt.IsReadOnly = False
        Me.ucrInputTextLimitColorpt.Location = New System.Drawing.Point(286, 66)
        Me.ucrInputTextLimitColorpt.Name = "ucrInputTextLimitColorpt"
        Me.ucrInputTextLimitColorpt.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitColorpt.TabIndex = 243
        '
        'ucrInputTextExpandColorpt
        '
        Me.ucrInputTextExpandColorpt.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandColorpt.AutoSize = True
        Me.ucrInputTextExpandColorpt.IsMultiline = False
        Me.ucrInputTextExpandColorpt.IsReadOnly = False
        Me.ucrInputTextExpandColorpt.Location = New System.Drawing.Point(286, 115)
        Me.ucrInputTextExpandColorpt.Name = "ucrInputTextExpandColorpt"
        Me.ucrInputTextExpandColorpt.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandColorpt.TabIndex = 242
        '
        'ucrInputPositionColorpt
        '
        Me.ucrInputPositionColorpt.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionColorpt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionColorpt.GetSetSelectedIndex = -1
        Me.ucrInputPositionColorpt.IsReadOnly = False
        Me.ucrInputPositionColorpt.Location = New System.Drawing.Point(286, 90)
        Me.ucrInputPositionColorpt.Name = "ucrInputPositionColorpt"
        Me.ucrInputPositionColorpt.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionColorpt.TabIndex = 241
        '
        'ucrInputDropUnusedLevelsColorpt
        '
        Me.ucrInputDropUnusedLevelsColorpt.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsColorpt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsColorpt.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsColorpt.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsColorpt.Location = New System.Drawing.Point(286, 12)
        Me.ucrInputDropUnusedLevelsColorpt.Name = "ucrInputDropUnusedLevelsColorpt"
        Me.ucrInputDropUnusedLevelsColorpt.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsColorpt.TabIndex = 240
        '
        'ucrChkExpandColorpt
        '
        Me.ucrChkExpandColorpt.AutoSize = True
        Me.ucrChkExpandColorpt.Checked = False
        Me.ucrChkExpandColorpt.Location = New System.Drawing.Point(6, 114)
        Me.ucrChkExpandColorpt.Name = "ucrChkExpandColorpt"
        Me.ucrChkExpandColorpt.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandColorpt.TabIndex = 239
        '
        'ucrChkPositionColorpt
        '
        Me.ucrChkPositionColorpt.AutoSize = True
        Me.ucrChkPositionColorpt.Checked = False
        Me.ucrChkPositionColorpt.Location = New System.Drawing.Point(6, 89)
        Me.ucrChkPositionColorpt.Name = "ucrChkPositionColorpt"
        Me.ucrChkPositionColorpt.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionColorpt.TabIndex = 238
        '
        'ucrChkLimitColorpt
        '
        Me.ucrChkLimitColorpt.AutoSize = True
        Me.ucrChkLimitColorpt.Checked = False
        Me.ucrChkLimitColorpt.Location = New System.Drawing.Point(6, 66)
        Me.ucrChkLimitColorpt.Name = "ucrChkLimitColorpt"
        Me.ucrChkLimitColorpt.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitColorpt.TabIndex = 237
        '
        'ucrChkBreaksColorpt
        '
        Me.ucrChkBreaksColorpt.AutoSize = True
        Me.ucrChkBreaksColorpt.Checked = False
        Me.ucrChkBreaksColorpt.Location = New System.Drawing.Point(6, 43)
        Me.ucrChkBreaksColorpt.Name = "ucrChkBreaksColorpt"
        Me.ucrChkBreaksColorpt.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksColorpt.TabIndex = 236
        '
        'ucrChkNaValueColorpt
        '
        Me.ucrChkNaValueColorpt.AutoSize = True
        Me.ucrChkNaValueColorpt.Checked = False
        Me.ucrChkNaValueColorpt.Location = New System.Drawing.Point(6, 143)
        Me.ucrChkNaValueColorpt.Name = "ucrChkNaValueColorpt"
        Me.ucrChkNaValueColorpt.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValueColorpt.TabIndex = 235
        '
        'ucrChkDropUnusedLevelsColorpt
        '
        Me.ucrChkDropUnusedLevelsColorpt.AutoSize = True
        Me.ucrChkDropUnusedLevelsColorpt.Checked = False
        Me.ucrChkDropUnusedLevelsColorpt.Location = New System.Drawing.Point(6, 21)
        Me.ucrChkDropUnusedLevelsColorpt.Name = "ucrChkDropUnusedLevelsColorpt"
        Me.ucrChkDropUnusedLevelsColorpt.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsColorpt.TabIndex = 234
        '
        'grpScaleColorfiv
        '
        Me.grpScaleColorfiv.Controls.Add(Me.ucrInputTextBreaksColorfiv)
        Me.grpScaleColorfiv.Controls.Add(Me.ucrInputTextNaValueColorfiv)
        Me.grpScaleColorfiv.Controls.Add(Me.ucrInputTextLimitColorfiv)
        Me.grpScaleColorfiv.Controls.Add(Me.ucrInputTextExpandColorfiv)
        Me.grpScaleColorfiv.Controls.Add(Me.ucrInputPositionColorfiv)
        Me.grpScaleColorfiv.Controls.Add(Me.ucrInputDropUnusedLevelsColorfiv)
        Me.grpScaleColorfiv.Controls.Add(Me.ucrChkExpandColorfiv)
        Me.grpScaleColorfiv.Controls.Add(Me.ucrChkPositionColorfiv)
        Me.grpScaleColorfiv.Controls.Add(Me.ucrChkLimitColorfiv)
        Me.grpScaleColorfiv.Controls.Add(Me.ucrChkBreaksColorfiv)
        Me.grpScaleColorfiv.Controls.Add(Me.ucrChkNaValueColorfiv)
        Me.grpScaleColorfiv.Controls.Add(Me.ucrChkDropUnusedLevelsColorfiv)
        Me.grpScaleColorfiv.Location = New System.Drawing.Point(14, 465)
        Me.grpScaleColorfiv.Name = "grpScaleColorfiv"
        Me.grpScaleColorfiv.Size = New System.Drawing.Size(444, 178)
        Me.grpScaleColorfiv.TabIndex = 263
        Me.grpScaleColorfiv.TabStop = False
        Me.grpScaleColorfiv.Text = "Colour Scale"
        '
        'ucrInputTextBreaksColorfiv
        '
        Me.ucrInputTextBreaksColorfiv.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksColorfiv.AutoSize = True
        Me.ucrInputTextBreaksColorfiv.IsMultiline = False
        Me.ucrInputTextBreaksColorfiv.IsReadOnly = False
        Me.ucrInputTextBreaksColorfiv.Location = New System.Drawing.Point(285, 43)
        Me.ucrInputTextBreaksColorfiv.Name = "ucrInputTextBreaksColorfiv"
        Me.ucrInputTextBreaksColorfiv.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksColorfiv.TabIndex = 233
        '
        'ucrInputTextNaValueColorfiv
        '
        Me.ucrInputTextNaValueColorfiv.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueColorfiv.AutoSize = True
        Me.ucrInputTextNaValueColorfiv.IsMultiline = False
        Me.ucrInputTextNaValueColorfiv.IsReadOnly = False
        Me.ucrInputTextNaValueColorfiv.Location = New System.Drawing.Point(285, 150)
        Me.ucrInputTextNaValueColorfiv.Name = "ucrInputTextNaValueColorfiv"
        Me.ucrInputTextNaValueColorfiv.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueColorfiv.TabIndex = 232
        '
        'ucrInputTextLimitColorfiv
        '
        Me.ucrInputTextLimitColorfiv.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitColorfiv.AutoSize = True
        Me.ucrInputTextLimitColorfiv.IsMultiline = False
        Me.ucrInputTextLimitColorfiv.IsReadOnly = False
        Me.ucrInputTextLimitColorfiv.Location = New System.Drawing.Point(285, 68)
        Me.ucrInputTextLimitColorfiv.Name = "ucrInputTextLimitColorfiv"
        Me.ucrInputTextLimitColorfiv.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitColorfiv.TabIndex = 231
        '
        'ucrInputTextExpandColorfiv
        '
        Me.ucrInputTextExpandColorfiv.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandColorfiv.AutoSize = True
        Me.ucrInputTextExpandColorfiv.IsMultiline = False
        Me.ucrInputTextExpandColorfiv.IsReadOnly = False
        Me.ucrInputTextExpandColorfiv.Location = New System.Drawing.Point(285, 123)
        Me.ucrInputTextExpandColorfiv.Name = "ucrInputTextExpandColorfiv"
        Me.ucrInputTextExpandColorfiv.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandColorfiv.TabIndex = 230
        '
        'ucrInputPositionColorfiv
        '
        Me.ucrInputPositionColorfiv.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionColorfiv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionColorfiv.GetSetSelectedIndex = -1
        Me.ucrInputPositionColorfiv.IsReadOnly = False
        Me.ucrInputPositionColorfiv.Location = New System.Drawing.Point(285, 95)
        Me.ucrInputPositionColorfiv.Name = "ucrInputPositionColorfiv"
        Me.ucrInputPositionColorfiv.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionColorfiv.TabIndex = 229
        '
        'ucrInputDropUnusedLevelsColorfiv
        '
        Me.ucrInputDropUnusedLevelsColorfiv.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsColorfiv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsColorfiv.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsColorfiv.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsColorfiv.Location = New System.Drawing.Point(285, 15)
        Me.ucrInputDropUnusedLevelsColorfiv.Name = "ucrInputDropUnusedLevelsColorfiv"
        Me.ucrInputDropUnusedLevelsColorfiv.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsColorfiv.TabIndex = 228
        '
        'ucrChkExpandColorfiv
        '
        Me.ucrChkExpandColorfiv.AutoSize = True
        Me.ucrChkExpandColorfiv.Checked = False
        Me.ucrChkExpandColorfiv.Location = New System.Drawing.Point(8, 124)
        Me.ucrChkExpandColorfiv.Name = "ucrChkExpandColorfiv"
        Me.ucrChkExpandColorfiv.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandColorfiv.TabIndex = 227
        '
        'ucrChkPositionColorfiv
        '
        Me.ucrChkPositionColorfiv.AutoSize = True
        Me.ucrChkPositionColorfiv.Checked = False
        Me.ucrChkPositionColorfiv.Location = New System.Drawing.Point(8, 100)
        Me.ucrChkPositionColorfiv.Name = "ucrChkPositionColorfiv"
        Me.ucrChkPositionColorfiv.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionColorfiv.TabIndex = 226
        '
        'ucrChkLimitColorfiv
        '
        Me.ucrChkLimitColorfiv.AutoSize = True
        Me.ucrChkLimitColorfiv.Checked = False
        Me.ucrChkLimitColorfiv.Location = New System.Drawing.Point(8, 76)
        Me.ucrChkLimitColorfiv.Name = "ucrChkLimitColorfiv"
        Me.ucrChkLimitColorfiv.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitColorfiv.TabIndex = 225
        '
        'ucrChkBreaksColorfiv
        '
        Me.ucrChkBreaksColorfiv.AutoSize = True
        Me.ucrChkBreaksColorfiv.Checked = False
        Me.ucrChkBreaksColorfiv.Location = New System.Drawing.Point(8, 48)
        Me.ucrChkBreaksColorfiv.Name = "ucrChkBreaksColorfiv"
        Me.ucrChkBreaksColorfiv.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksColorfiv.TabIndex = 224
        '
        'ucrChkNaValueColorfiv
        '
        Me.ucrChkNaValueColorfiv.AutoSize = True
        Me.ucrChkNaValueColorfiv.Checked = False
        Me.ucrChkNaValueColorfiv.Location = New System.Drawing.Point(8, 151)
        Me.ucrChkNaValueColorfiv.Name = "ucrChkNaValueColorfiv"
        Me.ucrChkNaValueColorfiv.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValueColorfiv.TabIndex = 223
        '
        'ucrChkDropUnusedLevelsColorfiv
        '
        Me.ucrChkDropUnusedLevelsColorfiv.AutoSize = True
        Me.ucrChkDropUnusedLevelsColorfiv.Checked = False
        Me.ucrChkDropUnusedLevelsColorfiv.Location = New System.Drawing.Point(8, 23)
        Me.ucrChkDropUnusedLevelsColorfiv.Name = "ucrChkDropUnusedLevelsColorfiv"
        Me.ucrChkDropUnusedLevelsColorfiv.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsColorfiv.TabIndex = 222
        '
        'grpScalecolorExn
        '
        Me.grpScalecolorExn.Controls.Add(Me.ucrInputThemeColor)
        Me.grpScalecolorExn.Controls.Add(Me.ucrChkThemecolor)
        Me.grpScalecolorExn.Controls.Add(Me.ucrInputTextBreaksColorExn)
        Me.grpScalecolorExn.Controls.Add(Me.ucrInputTextExpandColorExn)
        Me.grpScalecolorExn.Controls.Add(Me.ucrInputTextLimitColorExn)
        Me.grpScalecolorExn.Controls.Add(Me.ucrInputTextNaValueColorExn)
        Me.grpScalecolorExn.Controls.Add(Me.ucrInputPositionColorExn)
        Me.grpScalecolorExn.Controls.Add(Me.ucrInputDropUnusedLevelsColorExn)
        Me.grpScalecolorExn.Controls.Add(Me.ucrChkNaValueColorExn)
        Me.grpScalecolorExn.Controls.Add(Me.ucrChkPositionColorExn)
        Me.grpScalecolorExn.Controls.Add(Me.ucrChkLimitColorExn)
        Me.grpScalecolorExn.Controls.Add(Me.ucrChkBreaksColorExn)
        Me.grpScalecolorExn.Controls.Add(Me.ucrChkExpandColorExn)
        Me.grpScalecolorExn.Controls.Add(Me.ucrChkDropUnusedLevelsColorExn)
        Me.grpScalecolorExn.Location = New System.Drawing.Point(11, 466)
        Me.grpScalecolorExn.Name = "grpScalecolorExn"
        Me.grpScalecolorExn.Size = New System.Drawing.Size(447, 175)
        Me.grpScalecolorExn.TabIndex = 254
        Me.grpScalecolorExn.TabStop = False
        Me.grpScalecolorExn.Text = "Colour Scale"
        '
        'ucrInputThemeColor
        '
        Me.ucrInputThemeColor.AddQuotesIfUnrecognised = True
        Me.ucrInputThemeColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputThemeColor.GetSetSelectedIndex = -1
        Me.ucrInputThemeColor.IsReadOnly = False
        Me.ucrInputThemeColor.Location = New System.Drawing.Point(285, 149)
        Me.ucrInputThemeColor.Name = "ucrInputThemeColor"
        Me.ucrInputThemeColor.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputThemeColor.TabIndex = 199
        '
        'ucrChkThemecolor
        '
        Me.ucrChkThemecolor.AutoSize = True
        Me.ucrChkThemecolor.Checked = False
        Me.ucrChkThemecolor.Location = New System.Drawing.Point(8, 152)
        Me.ucrChkThemecolor.Name = "ucrChkThemecolor"
        Me.ucrChkThemecolor.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkThemecolor.TabIndex = 198
        '
        'ucrInputTextBreaksColorExn
        '
        Me.ucrInputTextBreaksColorExn.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksColorExn.AutoSize = True
        Me.ucrInputTextBreaksColorExn.IsMultiline = False
        Me.ucrInputTextBreaksColorExn.IsReadOnly = False
        Me.ucrInputTextBreaksColorExn.Location = New System.Drawing.Point(286, 34)
        Me.ucrInputTextBreaksColorExn.Name = "ucrInputTextBreaksColorExn"
        Me.ucrInputTextBreaksColorExn.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksColorExn.TabIndex = 197
        '
        'ucrInputTextExpandColorExn
        '
        Me.ucrInputTextExpandColorExn.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandColorExn.AutoSize = True
        Me.ucrInputTextExpandColorExn.IsMultiline = False
        Me.ucrInputTextExpandColorExn.IsReadOnly = False
        Me.ucrInputTextExpandColorExn.Location = New System.Drawing.Point(286, 127)
        Me.ucrInputTextExpandColorExn.Name = "ucrInputTextExpandColorExn"
        Me.ucrInputTextExpandColorExn.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandColorExn.TabIndex = 196
        '
        'ucrInputTextLimitColorExn
        '
        Me.ucrInputTextLimitColorExn.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitColorExn.AutoSize = True
        Me.ucrInputTextLimitColorExn.IsMultiline = False
        Me.ucrInputTextLimitColorExn.IsReadOnly = False
        Me.ucrInputTextLimitColorExn.Location = New System.Drawing.Point(286, 57)
        Me.ucrInputTextLimitColorExn.Name = "ucrInputTextLimitColorExn"
        Me.ucrInputTextLimitColorExn.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitColorExn.TabIndex = 195
        '
        'ucrInputTextNaValueColorExn
        '
        Me.ucrInputTextNaValueColorExn.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueColorExn.AutoSize = True
        Me.ucrInputTextNaValueColorExn.IsMultiline = False
        Me.ucrInputTextNaValueColorExn.IsReadOnly = False
        Me.ucrInputTextNaValueColorExn.Location = New System.Drawing.Point(286, 104)
        Me.ucrInputTextNaValueColorExn.Name = "ucrInputTextNaValueColorExn"
        Me.ucrInputTextNaValueColorExn.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueColorExn.TabIndex = 194
        '
        'ucrInputPositionColorExn
        '
        Me.ucrInputPositionColorExn.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionColorExn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionColorExn.GetSetSelectedIndex = -1
        Me.ucrInputPositionColorExn.IsReadOnly = False
        Me.ucrInputPositionColorExn.Location = New System.Drawing.Point(286, 80)
        Me.ucrInputPositionColorExn.Name = "ucrInputPositionColorExn"
        Me.ucrInputPositionColorExn.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionColorExn.TabIndex = 193
        '
        'ucrInputDropUnusedLevelsColorExn
        '
        Me.ucrInputDropUnusedLevelsColorExn.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsColorExn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsColorExn.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsColorExn.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsColorExn.Location = New System.Drawing.Point(286, 10)
        Me.ucrInputDropUnusedLevelsColorExn.Name = "ucrInputDropUnusedLevelsColorExn"
        Me.ucrInputDropUnusedLevelsColorExn.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsColorExn.TabIndex = 192
        '
        'ucrChkNaValueColorExn
        '
        Me.ucrChkNaValueColorExn.AutoSize = True
        Me.ucrChkNaValueColorExn.Checked = False
        Me.ucrChkNaValueColorExn.Location = New System.Drawing.Point(8, 107)
        Me.ucrChkNaValueColorExn.Name = "ucrChkNaValueColorExn"
        Me.ucrChkNaValueColorExn.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkNaValueColorExn.TabIndex = 191
        '
        'ucrChkPositionColorExn
        '
        Me.ucrChkPositionColorExn.AutoSize = True
        Me.ucrChkPositionColorExn.Checked = False
        Me.ucrChkPositionColorExn.Location = New System.Drawing.Point(8, 84)
        Me.ucrChkPositionColorExn.Name = "ucrChkPositionColorExn"
        Me.ucrChkPositionColorExn.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionColorExn.TabIndex = 190
        '
        'ucrChkLimitColorExn
        '
        Me.ucrChkLimitColorExn.AutoSize = True
        Me.ucrChkLimitColorExn.Checked = False
        Me.ucrChkLimitColorExn.Location = New System.Drawing.Point(8, 61)
        Me.ucrChkLimitColorExn.Name = "ucrChkLimitColorExn"
        Me.ucrChkLimitColorExn.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitColorExn.TabIndex = 189
        '
        'ucrChkBreaksColorExn
        '
        Me.ucrChkBreaksColorExn.AutoSize = True
        Me.ucrChkBreaksColorExn.Checked = False
        Me.ucrChkBreaksColorExn.Location = New System.Drawing.Point(8, 39)
        Me.ucrChkBreaksColorExn.Name = "ucrChkBreaksColorExn"
        Me.ucrChkBreaksColorExn.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksColorExn.TabIndex = 188
        '
        'ucrChkExpandColorExn
        '
        Me.ucrChkExpandColorExn.AutoSize = True
        Me.ucrChkExpandColorExn.Checked = False
        Me.ucrChkExpandColorExn.Location = New System.Drawing.Point(8, 130)
        Me.ucrChkExpandColorExn.Name = "ucrChkExpandColorExn"
        Me.ucrChkExpandColorExn.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkExpandColorExn.TabIndex = 187
        '
        'ucrChkDropUnusedLevelsColorExn
        '
        Me.ucrChkDropUnusedLevelsColorExn.AutoSize = True
        Me.ucrChkDropUnusedLevelsColorExn.Checked = False
        Me.ucrChkDropUnusedLevelsColorExn.Location = New System.Drawing.Point(8, 17)
        Me.ucrChkDropUnusedLevelsColorExn.Name = "ucrChkDropUnusedLevelsColorExn"
        Me.ucrChkDropUnusedLevelsColorExn.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsColorExn.TabIndex = 186
        '
        'grpScalecolorst
        '
        Me.grpScalecolorst.Controls.Add(Me.ucrInputSchemecolor)
        Me.grpScalecolorst.Controls.Add(Me.ucrChkSchemecolor)
        Me.grpScalecolorst.Controls.Add(Me.ucrInputTextBreaksColorst)
        Me.grpScalecolorst.Controls.Add(Me.ucrInputTextNaValueColorst)
        Me.grpScalecolorst.Controls.Add(Me.ucrInputTextLimitColorst)
        Me.grpScalecolorst.Controls.Add(Me.ucrInputTextExpandColorst)
        Me.grpScalecolorst.Controls.Add(Me.ucrInputPositionColorst)
        Me.grpScalecolorst.Controls.Add(Me.ucrInputDropUnusedLevelsColorst)
        Me.grpScalecolorst.Controls.Add(Me.ucrChkExpandColorst)
        Me.grpScalecolorst.Controls.Add(Me.ucrChkPositionColorst)
        Me.grpScalecolorst.Controls.Add(Me.ucrChkLimitColorst)
        Me.grpScalecolorst.Controls.Add(Me.ucrChkBreaksColorst)
        Me.grpScalecolorst.Controls.Add(Me.ucrChkNaValueColorst)
        Me.grpScalecolorst.Controls.Add(Me.ucrChkDropUnusedLevelsColorst)
        Me.grpScalecolorst.Location = New System.Drawing.Point(10, 464)
        Me.grpScalecolorst.Name = "grpScalecolorst"
        Me.grpScalecolorst.Size = New System.Drawing.Size(444, 178)
        Me.grpScalecolorst.TabIndex = 262
        Me.grpScalecolorst.TabStop = False
        Me.grpScalecolorst.Text = "Colour Scale"
        '
        'ucrInputSchemecolor
        '
        Me.ucrInputSchemecolor.AddQuotesIfUnrecognised = True
        Me.ucrInputSchemecolor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSchemecolor.GetSetSelectedIndex = -1
        Me.ucrInputSchemecolor.IsReadOnly = False
        Me.ucrInputSchemecolor.Location = New System.Drawing.Point(284, 152)
        Me.ucrInputSchemecolor.Name = "ucrInputSchemecolor"
        Me.ucrInputSchemecolor.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSchemecolor.TabIndex = 213
        '
        'ucrChkSchemecolor
        '
        Me.ucrChkSchemecolor.AutoSize = True
        Me.ucrChkSchemecolor.Checked = False
        Me.ucrChkSchemecolor.Location = New System.Drawing.Point(8, 153)
        Me.ucrChkSchemecolor.Name = "ucrChkSchemecolor"
        Me.ucrChkSchemecolor.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkSchemecolor.TabIndex = 212
        '
        'ucrInputTextBreaksColorst
        '
        Me.ucrInputTextBreaksColorst.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksColorst.AutoSize = True
        Me.ucrInputTextBreaksColorst.IsMultiline = False
        Me.ucrInputTextBreaksColorst.IsReadOnly = False
        Me.ucrInputTextBreaksColorst.Location = New System.Drawing.Point(285, 37)
        Me.ucrInputTextBreaksColorst.Name = "ucrInputTextBreaksColorst"
        Me.ucrInputTextBreaksColorst.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksColorst.TabIndex = 211
        '
        'ucrInputTextNaValueColorst
        '
        Me.ucrInputTextNaValueColorst.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueColorst.AutoSize = True
        Me.ucrInputTextNaValueColorst.IsMultiline = False
        Me.ucrInputTextNaValueColorst.IsReadOnly = False
        Me.ucrInputTextNaValueColorst.Location = New System.Drawing.Point(285, 130)
        Me.ucrInputTextNaValueColorst.Name = "ucrInputTextNaValueColorst"
        Me.ucrInputTextNaValueColorst.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueColorst.TabIndex = 210
        '
        'ucrInputTextLimitColorst
        '
        Me.ucrInputTextLimitColorst.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitColorst.AutoSize = True
        Me.ucrInputTextLimitColorst.IsMultiline = False
        Me.ucrInputTextLimitColorst.IsReadOnly = False
        Me.ucrInputTextLimitColorst.Location = New System.Drawing.Point(285, 60)
        Me.ucrInputTextLimitColorst.Name = "ucrInputTextLimitColorst"
        Me.ucrInputTextLimitColorst.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitColorst.TabIndex = 209
        '
        'ucrInputTextExpandColorst
        '
        Me.ucrInputTextExpandColorst.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandColorst.AutoSize = True
        Me.ucrInputTextExpandColorst.IsMultiline = False
        Me.ucrInputTextExpandColorst.IsReadOnly = False
        Me.ucrInputTextExpandColorst.Location = New System.Drawing.Point(285, 107)
        Me.ucrInputTextExpandColorst.Name = "ucrInputTextExpandColorst"
        Me.ucrInputTextExpandColorst.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandColorst.TabIndex = 208
        '
        'ucrInputPositionColorst
        '
        Me.ucrInputPositionColorst.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionColorst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionColorst.GetSetSelectedIndex = -1
        Me.ucrInputPositionColorst.IsReadOnly = False
        Me.ucrInputPositionColorst.Location = New System.Drawing.Point(285, 83)
        Me.ucrInputPositionColorst.Name = "ucrInputPositionColorst"
        Me.ucrInputPositionColorst.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionColorst.TabIndex = 207
        '
        'ucrInputDropUnusedLevelsColorst
        '
        Me.ucrInputDropUnusedLevelsColorst.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsColorst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsColorst.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsColorst.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsColorst.Location = New System.Drawing.Point(285, 13)
        Me.ucrInputDropUnusedLevelsColorst.Name = "ucrInputDropUnusedLevelsColorst"
        Me.ucrInputDropUnusedLevelsColorst.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsColorst.TabIndex = 206
        '
        'ucrChkExpandColorst
        '
        Me.ucrChkExpandColorst.AutoSize = True
        Me.ucrChkExpandColorst.Checked = False
        Me.ucrChkExpandColorst.Location = New System.Drawing.Point(8, 107)
        Me.ucrChkExpandColorst.Name = "ucrChkExpandColorst"
        Me.ucrChkExpandColorst.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandColorst.TabIndex = 205
        '
        'ucrChkPositionColorst
        '
        Me.ucrChkPositionColorst.AutoSize = True
        Me.ucrChkPositionColorst.Checked = False
        Me.ucrChkPositionColorst.Location = New System.Drawing.Point(8, 86)
        Me.ucrChkPositionColorst.Name = "ucrChkPositionColorst"
        Me.ucrChkPositionColorst.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionColorst.TabIndex = 204
        '
        'ucrChkLimitColorst
        '
        Me.ucrChkLimitColorst.AutoSize = True
        Me.ucrChkLimitColorst.Checked = False
        Me.ucrChkLimitColorst.Location = New System.Drawing.Point(8, 62)
        Me.ucrChkLimitColorst.Name = "ucrChkLimitColorst"
        Me.ucrChkLimitColorst.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitColorst.TabIndex = 203
        '
        'ucrChkBreaksColorst
        '
        Me.ucrChkBreaksColorst.AutoSize = True
        Me.ucrChkBreaksColorst.Checked = False
        Me.ucrChkBreaksColorst.Location = New System.Drawing.Point(8, 40)
        Me.ucrChkBreaksColorst.Name = "ucrChkBreaksColorst"
        Me.ucrChkBreaksColorst.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksColorst.TabIndex = 202
        '
        'ucrChkNaValueColorst
        '
        Me.ucrChkNaValueColorst.AutoSize = True
        Me.ucrChkNaValueColorst.Checked = False
        Me.ucrChkNaValueColorst.Location = New System.Drawing.Point(8, 130)
        Me.ucrChkNaValueColorst.Name = "ucrChkNaValueColorst"
        Me.ucrChkNaValueColorst.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValueColorst.TabIndex = 201
        '
        'ucrChkDropUnusedLevelsColorst
        '
        Me.ucrChkDropUnusedLevelsColorst.AutoSize = True
        Me.ucrChkDropUnusedLevelsColorst.Checked = False
        Me.ucrChkDropUnusedLevelsColorst.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkDropUnusedLevelsColorst.Name = "ucrChkDropUnusedLevelsColorst"
        Me.ucrChkDropUnusedLevelsColorst.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsColorst.TabIndex = 200
        '
        'grpScalecolorEcon
        '
        Me.grpScalecolorEcon.Controls.Add(Me.ucrInputTextBreaksColorEcon)
        Me.grpScalecolorEcon.Controls.Add(Me.ucrInputTextNaValueColorEcon)
        Me.grpScalecolorEcon.Controls.Add(Me.ucrInputTextLimitColorEcon)
        Me.grpScalecolorEcon.Controls.Add(Me.ucrInputTextExpandColorEcon)
        Me.grpScalecolorEcon.Controls.Add(Me.ucrInputPositionColorEcon)
        Me.grpScalecolorEcon.Controls.Add(Me.ucrInputDropUnusedLevelsColorEcon)
        Me.grpScalecolorEcon.Controls.Add(Me.ucrChkExpandColorEcon)
        Me.grpScalecolorEcon.Controls.Add(Me.ucrChkPositionColorEcon)
        Me.grpScalecolorEcon.Controls.Add(Me.ucrChkLimitColorEcon)
        Me.grpScalecolorEcon.Controls.Add(Me.ucrChkBreaksColorEcon)
        Me.grpScalecolorEcon.Controls.Add(Me.ucrChkNaValueColorEcon)
        Me.grpScalecolorEcon.Controls.Add(Me.ucrChkDropUnusedLevelsColorEcon)
        Me.grpScalecolorEcon.Location = New System.Drawing.Point(11, 466)
        Me.grpScalecolorEcon.Name = "grpScalecolorEcon"
        Me.grpScalecolorEcon.Size = New System.Drawing.Size(444, 178)
        Me.grpScalecolorEcon.TabIndex = 261
        Me.grpScalecolorEcon.TabStop = False
        Me.grpScalecolorEcon.Text = "Color Scale"
        '
        'ucrInputTextBreaksColorEcon
        '
        Me.ucrInputTextBreaksColorEcon.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksColorEcon.AutoSize = True
        Me.ucrInputTextBreaksColorEcon.IsMultiline = False
        Me.ucrInputTextBreaksColorEcon.IsReadOnly = False
        Me.ucrInputTextBreaksColorEcon.Location = New System.Drawing.Point(285, 42)
        Me.ucrInputTextBreaksColorEcon.Name = "ucrInputTextBreaksColorEcon"
        Me.ucrInputTextBreaksColorEcon.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksColorEcon.TabIndex = 221
        '
        'ucrInputTextNaValueColorEcon
        '
        Me.ucrInputTextNaValueColorEcon.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueColorEcon.AutoSize = True
        Me.ucrInputTextNaValueColorEcon.IsMultiline = False
        Me.ucrInputTextNaValueColorEcon.IsReadOnly = False
        Me.ucrInputTextNaValueColorEcon.Location = New System.Drawing.Point(285, 142)
        Me.ucrInputTextNaValueColorEcon.Name = "ucrInputTextNaValueColorEcon"
        Me.ucrInputTextNaValueColorEcon.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueColorEcon.TabIndex = 220
        '
        'ucrInputTextLimitColorEcon
        '
        Me.ucrInputTextLimitColorEcon.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitColorEcon.AutoSize = True
        Me.ucrInputTextLimitColorEcon.IsMultiline = False
        Me.ucrInputTextLimitColorEcon.IsReadOnly = False
        Me.ucrInputTextLimitColorEcon.Location = New System.Drawing.Point(285, 68)
        Me.ucrInputTextLimitColorEcon.Name = "ucrInputTextLimitColorEcon"
        Me.ucrInputTextLimitColorEcon.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitColorEcon.TabIndex = 219
        '
        'ucrInputTextExpandColorEcon
        '
        Me.ucrInputTextExpandColorEcon.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandColorEcon.AutoSize = True
        Me.ucrInputTextExpandColorEcon.IsMultiline = False
        Me.ucrInputTextExpandColorEcon.IsReadOnly = False
        Me.ucrInputTextExpandColorEcon.Location = New System.Drawing.Point(285, 117)
        Me.ucrInputTextExpandColorEcon.Name = "ucrInputTextExpandColorEcon"
        Me.ucrInputTextExpandColorEcon.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandColorEcon.TabIndex = 218
        '
        'ucrInputPositionColorEcon
        '
        Me.ucrInputPositionColorEcon.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionColorEcon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionColorEcon.GetSetSelectedIndex = -1
        Me.ucrInputPositionColorEcon.IsReadOnly = False
        Me.ucrInputPositionColorEcon.Location = New System.Drawing.Point(285, 92)
        Me.ucrInputPositionColorEcon.Name = "ucrInputPositionColorEcon"
        Me.ucrInputPositionColorEcon.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionColorEcon.TabIndex = 217
        '
        'ucrInputDropUnusedLevelsColorEcon
        '
        Me.ucrInputDropUnusedLevelsColorEcon.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsColorEcon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsColorEcon.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsColorEcon.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsColorEcon.Location = New System.Drawing.Point(285, 14)
        Me.ucrInputDropUnusedLevelsColorEcon.Name = "ucrInputDropUnusedLevelsColorEcon"
        Me.ucrInputDropUnusedLevelsColorEcon.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsColorEcon.TabIndex = 216
        '
        'ucrChkExpandColorEcon
        '
        Me.ucrChkExpandColorEcon.AutoSize = True
        Me.ucrChkExpandColorEcon.Checked = False
        Me.ucrChkExpandColorEcon.Location = New System.Drawing.Point(7, 122)
        Me.ucrChkExpandColorEcon.Name = "ucrChkExpandColorEcon"
        Me.ucrChkExpandColorEcon.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandColorEcon.TabIndex = 215
        '
        'ucrChkPositionColorEcon
        '
        Me.ucrChkPositionColorEcon.AutoSize = True
        Me.ucrChkPositionColorEcon.Checked = False
        Me.ucrChkPositionColorEcon.Location = New System.Drawing.Point(7, 98)
        Me.ucrChkPositionColorEcon.Name = "ucrChkPositionColorEcon"
        Me.ucrChkPositionColorEcon.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionColorEcon.TabIndex = 214
        '
        'ucrChkLimitColorEcon
        '
        Me.ucrChkLimitColorEcon.AutoSize = True
        Me.ucrChkLimitColorEcon.Checked = False
        Me.ucrChkLimitColorEcon.Location = New System.Drawing.Point(7, 73)
        Me.ucrChkLimitColorEcon.Name = "ucrChkLimitColorEcon"
        Me.ucrChkLimitColorEcon.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitColorEcon.TabIndex = 213
        '
        'ucrChkBreaksColorEcon
        '
        Me.ucrChkBreaksColorEcon.AutoSize = True
        Me.ucrChkBreaksColorEcon.Checked = False
        Me.ucrChkBreaksColorEcon.Location = New System.Drawing.Point(7, 49)
        Me.ucrChkBreaksColorEcon.Name = "ucrChkBreaksColorEcon"
        Me.ucrChkBreaksColorEcon.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksColorEcon.TabIndex = 212
        '
        'ucrChkNaValueColorEcon
        '
        Me.ucrChkNaValueColorEcon.AutoSize = True
        Me.ucrChkNaValueColorEcon.Checked = False
        Me.ucrChkNaValueColorEcon.Location = New System.Drawing.Point(7, 146)
        Me.ucrChkNaValueColorEcon.Name = "ucrChkNaValueColorEcon"
        Me.ucrChkNaValueColorEcon.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValueColorEcon.TabIndex = 211
        '
        'ucrChkDropUnusedLevelsColorEcon
        '
        Me.ucrChkDropUnusedLevelsColorEcon.AutoSize = True
        Me.ucrChkDropUnusedLevelsColorEcon.Checked = False
        Me.ucrChkDropUnusedLevelsColorEcon.Location = New System.Drawing.Point(7, 24)
        Me.ucrChkDropUnusedLevelsColorEcon.Name = "ucrChkDropUnusedLevelsColorEcon"
        Me.ucrChkDropUnusedLevelsColorEcon.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsColorEcon.TabIndex = 210
        '
        'grpScalecolorEx
        '
        Me.grpScalecolorEx.Controls.Add(Me.ucrInputTextBreaksColorEx)
        Me.grpScalecolorEx.Controls.Add(Me.ucrInputTextNaValueColorEx)
        Me.grpScalecolorEx.Controls.Add(Me.ucrInputTextLimitColorEx)
        Me.grpScalecolorEx.Controls.Add(Me.ucrInputTextExpandColorEx)
        Me.grpScalecolorEx.Controls.Add(Me.ucrInputPositionColorEx)
        Me.grpScalecolorEx.Controls.Add(Me.ucrInputDropUnusedLevelsColorEx)
        Me.grpScalecolorEx.Controls.Add(Me.ucrChkExpandColorEx)
        Me.grpScalecolorEx.Controls.Add(Me.ucrChkPositionColorEx)
        Me.grpScalecolorEx.Controls.Add(Me.ucrChkLimitColorEx)
        Me.grpScalecolorEx.Controls.Add(Me.ucrChkBreaksColorEx)
        Me.grpScalecolorEx.Controls.Add(Me.ucrChkNaValueColorEx)
        Me.grpScalecolorEx.Controls.Add(Me.ucrChkDropUnusedLevelsColorEx)
        Me.grpScalecolorEx.Location = New System.Drawing.Point(11, 464)
        Me.grpScalecolorEx.Name = "grpScalecolorEx"
        Me.grpScalecolorEx.Size = New System.Drawing.Size(447, 175)
        Me.grpScalecolorEx.TabIndex = 260
        Me.grpScalecolorEx.TabStop = False
        Me.grpScalecolorEx.Text = "Colour Scale"
        '
        'ucrInputTextBreaksColorEx
        '
        Me.ucrInputTextBreaksColorEx.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksColorEx.AutoSize = True
        Me.ucrInputTextBreaksColorEx.IsMultiline = False
        Me.ucrInputTextBreaksColorEx.IsReadOnly = False
        Me.ucrInputTextBreaksColorEx.Location = New System.Drawing.Point(286, 45)
        Me.ucrInputTextBreaksColorEx.Name = "ucrInputTextBreaksColorEx"
        Me.ucrInputTextBreaksColorEx.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksColorEx.TabIndex = 209
        '
        'ucrInputTextNaValueColorEx
        '
        Me.ucrInputTextNaValueColorEx.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueColorEx.AutoSize = True
        Me.ucrInputTextNaValueColorEx.IsMultiline = False
        Me.ucrInputTextNaValueColorEx.IsReadOnly = False
        Me.ucrInputTextNaValueColorEx.Location = New System.Drawing.Point(286, 145)
        Me.ucrInputTextNaValueColorEx.Name = "ucrInputTextNaValueColorEx"
        Me.ucrInputTextNaValueColorEx.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueColorEx.TabIndex = 208
        '
        'ucrInputTextLimitColorEx
        '
        Me.ucrInputTextLimitColorEx.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitColorEx.AutoSize = True
        Me.ucrInputTextLimitColorEx.IsMultiline = False
        Me.ucrInputTextLimitColorEx.IsReadOnly = False
        Me.ucrInputTextLimitColorEx.Location = New System.Drawing.Point(286, 71)
        Me.ucrInputTextLimitColorEx.Name = "ucrInputTextLimitColorEx"
        Me.ucrInputTextLimitColorEx.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitColorEx.TabIndex = 207
        '
        'ucrInputTextExpandColorEx
        '
        Me.ucrInputTextExpandColorEx.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandColorEx.AutoSize = True
        Me.ucrInputTextExpandColorEx.IsMultiline = False
        Me.ucrInputTextExpandColorEx.IsReadOnly = False
        Me.ucrInputTextExpandColorEx.Location = New System.Drawing.Point(286, 120)
        Me.ucrInputTextExpandColorEx.Name = "ucrInputTextExpandColorEx"
        Me.ucrInputTextExpandColorEx.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandColorEx.TabIndex = 206
        '
        'ucrInputPositionColorEx
        '
        Me.ucrInputPositionColorEx.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionColorEx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionColorEx.GetSetSelectedIndex = -1
        Me.ucrInputPositionColorEx.IsReadOnly = False
        Me.ucrInputPositionColorEx.Location = New System.Drawing.Point(286, 95)
        Me.ucrInputPositionColorEx.Name = "ucrInputPositionColorEx"
        Me.ucrInputPositionColorEx.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionColorEx.TabIndex = 205
        '
        'ucrInputDropUnusedLevelsColorEx
        '
        Me.ucrInputDropUnusedLevelsColorEx.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsColorEx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsColorEx.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsColorEx.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsColorEx.Location = New System.Drawing.Point(286, 17)
        Me.ucrInputDropUnusedLevelsColorEx.Name = "ucrInputDropUnusedLevelsColorEx"
        Me.ucrInputDropUnusedLevelsColorEx.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsColorEx.TabIndex = 204
        '
        'ucrChkExpandColorEx
        '
        Me.ucrChkExpandColorEx.AutoSize = True
        Me.ucrChkExpandColorEx.Checked = False
        Me.ucrChkExpandColorEx.Location = New System.Drawing.Point(7, 122)
        Me.ucrChkExpandColorEx.Name = "ucrChkExpandColorEx"
        Me.ucrChkExpandColorEx.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandColorEx.TabIndex = 203
        '
        'ucrChkPositionColorEx
        '
        Me.ucrChkPositionColorEx.AutoSize = True
        Me.ucrChkPositionColorEx.Checked = False
        Me.ucrChkPositionColorEx.Location = New System.Drawing.Point(7, 97)
        Me.ucrChkPositionColorEx.Name = "ucrChkPositionColorEx"
        Me.ucrChkPositionColorEx.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionColorEx.TabIndex = 202
        '
        'ucrChkLimitColorEx
        '
        Me.ucrChkLimitColorEx.AutoSize = True
        Me.ucrChkLimitColorEx.Checked = False
        Me.ucrChkLimitColorEx.Location = New System.Drawing.Point(7, 73)
        Me.ucrChkLimitColorEx.Name = "ucrChkLimitColorEx"
        Me.ucrChkLimitColorEx.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitColorEx.TabIndex = 201
        '
        'ucrChkBreaksColorEx
        '
        Me.ucrChkBreaksColorEx.AutoSize = True
        Me.ucrChkBreaksColorEx.Checked = False
        Me.ucrChkBreaksColorEx.Location = New System.Drawing.Point(7, 49)
        Me.ucrChkBreaksColorEx.Name = "ucrChkBreaksColorEx"
        Me.ucrChkBreaksColorEx.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksColorEx.TabIndex = 200
        '
        'ucrChkNaValueColorEx
        '
        Me.ucrChkNaValueColorEx.AutoSize = True
        Me.ucrChkNaValueColorEx.Checked = False
        Me.ucrChkNaValueColorEx.Location = New System.Drawing.Point(7, 146)
        Me.ucrChkNaValueColorEx.Name = "ucrChkNaValueColorEx"
        Me.ucrChkNaValueColorEx.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValueColorEx.TabIndex = 199
        '
        'ucrChkDropUnusedLevelsColorEx
        '
        Me.ucrChkDropUnusedLevelsColorEx.AutoSize = True
        Me.ucrChkDropUnusedLevelsColorEx.Checked = False
        Me.ucrChkDropUnusedLevelsColorEx.Location = New System.Drawing.Point(7, 24)
        Me.ucrChkDropUnusedLevelsColorEx.Name = "ucrChkDropUnusedLevelsColorEx"
        Me.ucrChkDropUnusedLevelsColorEx.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsColorEx.TabIndex = 198
        '
        'grpColourScaleGgthemes
        '
        Me.grpColourScaleGgthemes.Controls.Add(Me.ucrInputTextBreaksColor)
        Me.grpColourScaleGgthemes.Controls.Add(Me.ucrInputTextNaValueColor)
        Me.grpColourScaleGgthemes.Controls.Add(Me.ucrInputTextLimitColor)
        Me.grpColourScaleGgthemes.Controls.Add(Me.ucrInputTextExpandColor)
        Me.grpColourScaleGgthemes.Controls.Add(Me.ucrInputPositionColor)
        Me.grpColourScaleGgthemes.Controls.Add(Me.ucrInputDropUnusedLevelsColor)
        Me.grpColourScaleGgthemes.Controls.Add(Me.ucrChkExpandColor)
        Me.grpColourScaleGgthemes.Controls.Add(Me.ucrChkPositionColor)
        Me.grpColourScaleGgthemes.Controls.Add(Me.ucrChkLimitColor)
        Me.grpColourScaleGgthemes.Controls.Add(Me.ucrChkBreaksColor)
        Me.grpColourScaleGgthemes.Controls.Add(Me.ucrChkNaValueColor)
        Me.grpColourScaleGgthemes.Controls.Add(Me.ucrChkDropUnusedLevelsColor)
        Me.grpColourScaleGgthemes.Location = New System.Drawing.Point(12, 462)
        Me.grpColourScaleGgthemes.Name = "grpColourScaleGgthemes"
        Me.grpColourScaleGgthemes.Size = New System.Drawing.Size(447, 175)
        Me.grpColourScaleGgthemes.TabIndex = 259
        Me.grpColourScaleGgthemes.TabStop = False
        Me.grpColourScaleGgthemes.Text = "Colour scale"
        '
        'ucrInputTextBreaksColor
        '
        Me.ucrInputTextBreaksColor.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksColor.AutoSize = True
        Me.ucrInputTextBreaksColor.IsMultiline = False
        Me.ucrInputTextBreaksColor.IsReadOnly = False
        Me.ucrInputTextBreaksColor.Location = New System.Drawing.Point(286, 40)
        Me.ucrInputTextBreaksColor.Name = "ucrInputTextBreaksColor"
        Me.ucrInputTextBreaksColor.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksColor.TabIndex = 221
        '
        'ucrInputTextNaValueColor
        '
        Me.ucrInputTextNaValueColor.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueColor.AutoSize = True
        Me.ucrInputTextNaValueColor.IsMultiline = False
        Me.ucrInputTextNaValueColor.IsReadOnly = False
        Me.ucrInputTextNaValueColor.Location = New System.Drawing.Point(286, 140)
        Me.ucrInputTextNaValueColor.Name = "ucrInputTextNaValueColor"
        Me.ucrInputTextNaValueColor.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueColor.TabIndex = 220
        '
        'ucrInputTextLimitColor
        '
        Me.ucrInputTextLimitColor.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitColor.AutoSize = True
        Me.ucrInputTextLimitColor.IsMultiline = False
        Me.ucrInputTextLimitColor.IsReadOnly = False
        Me.ucrInputTextLimitColor.Location = New System.Drawing.Point(286, 66)
        Me.ucrInputTextLimitColor.Name = "ucrInputTextLimitColor"
        Me.ucrInputTextLimitColor.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitColor.TabIndex = 219
        '
        'ucrInputTextExpandColor
        '
        Me.ucrInputTextExpandColor.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandColor.AutoSize = True
        Me.ucrInputTextExpandColor.IsMultiline = False
        Me.ucrInputTextExpandColor.IsReadOnly = False
        Me.ucrInputTextExpandColor.Location = New System.Drawing.Point(286, 115)
        Me.ucrInputTextExpandColor.Name = "ucrInputTextExpandColor"
        Me.ucrInputTextExpandColor.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandColor.TabIndex = 218
        '
        'ucrInputPositionColor
        '
        Me.ucrInputPositionColor.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionColor.GetSetSelectedIndex = -1
        Me.ucrInputPositionColor.IsReadOnly = False
        Me.ucrInputPositionColor.Location = New System.Drawing.Point(286, 90)
        Me.ucrInputPositionColor.Name = "ucrInputPositionColor"
        Me.ucrInputPositionColor.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionColor.TabIndex = 217
        '
        'ucrInputDropUnusedLevelsColor
        '
        Me.ucrInputDropUnusedLevelsColor.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsColor.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsColor.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsColor.Location = New System.Drawing.Point(286, 12)
        Me.ucrInputDropUnusedLevelsColor.Name = "ucrInputDropUnusedLevelsColor"
        Me.ucrInputDropUnusedLevelsColor.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsColor.TabIndex = 216
        '
        'ucrChkExpandColor
        '
        Me.ucrChkExpandColor.AutoSize = True
        Me.ucrChkExpandColor.Checked = False
        Me.ucrChkExpandColor.Location = New System.Drawing.Point(5, 121)
        Me.ucrChkExpandColor.Name = "ucrChkExpandColor"
        Me.ucrChkExpandColor.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandColor.TabIndex = 215
        '
        'ucrChkPositionColor
        '
        Me.ucrChkPositionColor.AutoSize = True
        Me.ucrChkPositionColor.Checked = False
        Me.ucrChkPositionColor.Location = New System.Drawing.Point(5, 93)
        Me.ucrChkPositionColor.Name = "ucrChkPositionColor"
        Me.ucrChkPositionColor.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionColor.TabIndex = 214
        '
        'ucrChkLimitColor
        '
        Me.ucrChkLimitColor.AutoSize = True
        Me.ucrChkLimitColor.Checked = False
        Me.ucrChkLimitColor.Location = New System.Drawing.Point(5, 68)
        Me.ucrChkLimitColor.Name = "ucrChkLimitColor"
        Me.ucrChkLimitColor.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitColor.TabIndex = 213
        '
        'ucrChkBreaksColor
        '
        Me.ucrChkBreaksColor.AutoSize = True
        Me.ucrChkBreaksColor.Checked = False
        Me.ucrChkBreaksColor.Location = New System.Drawing.Point(5, 46)
        Me.ucrChkBreaksColor.Name = "ucrChkBreaksColor"
        Me.ucrChkBreaksColor.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksColor.TabIndex = 212
        '
        'ucrChkNaValueColor
        '
        Me.ucrChkNaValueColor.AutoSize = True
        Me.ucrChkNaValueColor.Checked = False
        Me.ucrChkNaValueColor.Location = New System.Drawing.Point(5, 147)
        Me.ucrChkNaValueColor.Name = "ucrChkNaValueColor"
        Me.ucrChkNaValueColor.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValueColor.TabIndex = 211
        '
        'ucrChkDropUnusedLevelsColor
        '
        Me.ucrChkDropUnusedLevelsColor.AutoSize = True
        Me.ucrChkDropUnusedLevelsColor.Checked = False
        Me.ucrChkDropUnusedLevelsColor.Location = New System.Drawing.Point(5, 23)
        Me.ucrChkDropUnusedLevelsColor.Name = "ucrChkDropUnusedLevelsColor"
        Me.ucrChkDropUnusedLevelsColor.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsColor.TabIndex = 210
        '
        'grpScalecolorg
        '
        Me.grpScalecolorg.Controls.Add(Me.ucrInputTextBreaksColorg)
        Me.grpScalecolorg.Controls.Add(Me.ucrInputTextNaValueColorg)
        Me.grpScalecolorg.Controls.Add(Me.ucrInputTextLimitColorg)
        Me.grpScalecolorg.Controls.Add(Me.ucrInputTextExpandColorg)
        Me.grpScalecolorg.Controls.Add(Me.ucrInputPositionColorg)
        Me.grpScalecolorg.Controls.Add(Me.ucrInputDropUnusedLevelsColorg)
        Me.grpScalecolorg.Controls.Add(Me.ucrChkExpandColorg)
        Me.grpScalecolorg.Controls.Add(Me.ucrChkPositionColorg)
        Me.grpScalecolorg.Controls.Add(Me.ucrChkLimitColorg)
        Me.grpScalecolorg.Controls.Add(Me.ucrChkBreaksColorg)
        Me.grpScalecolorg.Controls.Add(Me.ucrChkNaValueColorg)
        Me.grpScalecolorg.Controls.Add(Me.ucrChkDropUnusedLevelsColorg)
        Me.grpScalecolorg.Location = New System.Drawing.Point(13, 464)
        Me.grpScalecolorg.Name = "grpScalecolorg"
        Me.grpScalecolorg.Size = New System.Drawing.Size(447, 175)
        Me.grpScalecolorg.TabIndex = 257
        Me.grpScalecolorg.TabStop = False
        Me.grpScalecolorg.Text = "Colour Scale"
        '
        'ucrInputTextBreaksColorg
        '
        Me.ucrInputTextBreaksColorg.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksColorg.AutoSize = True
        Me.ucrInputTextBreaksColorg.IsMultiline = False
        Me.ucrInputTextBreaksColorg.IsReadOnly = False
        Me.ucrInputTextBreaksColorg.Location = New System.Drawing.Point(286, 40)
        Me.ucrInputTextBreaksColorg.Name = "ucrInputTextBreaksColorg"
        Me.ucrInputTextBreaksColorg.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksColorg.TabIndex = 233
        '
        'ucrInputTextNaValueColorg
        '
        Me.ucrInputTextNaValueColorg.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueColorg.AutoSize = True
        Me.ucrInputTextNaValueColorg.IsMultiline = False
        Me.ucrInputTextNaValueColorg.IsReadOnly = False
        Me.ucrInputTextNaValueColorg.Location = New System.Drawing.Point(286, 140)
        Me.ucrInputTextNaValueColorg.Name = "ucrInputTextNaValueColorg"
        Me.ucrInputTextNaValueColorg.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueColorg.TabIndex = 232
        '
        'ucrInputTextLimitColorg
        '
        Me.ucrInputTextLimitColorg.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitColorg.AutoSize = True
        Me.ucrInputTextLimitColorg.IsMultiline = False
        Me.ucrInputTextLimitColorg.IsReadOnly = False
        Me.ucrInputTextLimitColorg.Location = New System.Drawing.Point(286, 66)
        Me.ucrInputTextLimitColorg.Name = "ucrInputTextLimitColorg"
        Me.ucrInputTextLimitColorg.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitColorg.TabIndex = 231
        '
        'ucrInputTextExpandColorg
        '
        Me.ucrInputTextExpandColorg.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandColorg.AutoSize = True
        Me.ucrInputTextExpandColorg.IsMultiline = False
        Me.ucrInputTextExpandColorg.IsReadOnly = False
        Me.ucrInputTextExpandColorg.Location = New System.Drawing.Point(286, 115)
        Me.ucrInputTextExpandColorg.Name = "ucrInputTextExpandColorg"
        Me.ucrInputTextExpandColorg.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandColorg.TabIndex = 230
        '
        'ucrInputPositionColorg
        '
        Me.ucrInputPositionColorg.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionColorg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionColorg.GetSetSelectedIndex = -1
        Me.ucrInputPositionColorg.IsReadOnly = False
        Me.ucrInputPositionColorg.Location = New System.Drawing.Point(286, 90)
        Me.ucrInputPositionColorg.Name = "ucrInputPositionColorg"
        Me.ucrInputPositionColorg.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionColorg.TabIndex = 229
        '
        'ucrInputDropUnusedLevelsColorg
        '
        Me.ucrInputDropUnusedLevelsColorg.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsColorg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsColorg.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsColorg.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsColorg.Location = New System.Drawing.Point(286, 12)
        Me.ucrInputDropUnusedLevelsColorg.Name = "ucrInputDropUnusedLevelsColorg"
        Me.ucrInputDropUnusedLevelsColorg.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsColorg.TabIndex = 228
        '
        'ucrChkExpandColorg
        '
        Me.ucrChkExpandColorg.AutoSize = True
        Me.ucrChkExpandColorg.Checked = False
        Me.ucrChkExpandColorg.Location = New System.Drawing.Point(6, 119)
        Me.ucrChkExpandColorg.Name = "ucrChkExpandColorg"
        Me.ucrChkExpandColorg.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandColorg.TabIndex = 227
        '
        'ucrChkPositionColorg
        '
        Me.ucrChkPositionColorg.AutoSize = True
        Me.ucrChkPositionColorg.Checked = False
        Me.ucrChkPositionColorg.Location = New System.Drawing.Point(6, 95)
        Me.ucrChkPositionColorg.Name = "ucrChkPositionColorg"
        Me.ucrChkPositionColorg.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionColorg.TabIndex = 226
        '
        'ucrChkLimitColorg
        '
        Me.ucrChkLimitColorg.AutoSize = True
        Me.ucrChkLimitColorg.Checked = False
        Me.ucrChkLimitColorg.Location = New System.Drawing.Point(6, 70)
        Me.ucrChkLimitColorg.Name = "ucrChkLimitColorg"
        Me.ucrChkLimitColorg.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitColorg.TabIndex = 225
        '
        'ucrChkBreaksColorg
        '
        Me.ucrChkBreaksColorg.AutoSize = True
        Me.ucrChkBreaksColorg.Checked = False
        Me.ucrChkBreaksColorg.Location = New System.Drawing.Point(6, 43)
        Me.ucrChkBreaksColorg.Name = "ucrChkBreaksColorg"
        Me.ucrChkBreaksColorg.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksColorg.TabIndex = 224
        '
        'ucrChkNaValueColorg
        '
        Me.ucrChkNaValueColorg.AutoSize = True
        Me.ucrChkNaValueColorg.Checked = False
        Me.ucrChkNaValueColorg.Location = New System.Drawing.Point(6, 145)
        Me.ucrChkNaValueColorg.Name = "ucrChkNaValueColorg"
        Me.ucrChkNaValueColorg.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValueColorg.TabIndex = 223
        '
        'ucrChkDropUnusedLevelsColorg
        '
        Me.ucrChkDropUnusedLevelsColorg.AutoSize = True
        Me.ucrChkDropUnusedLevelsColorg.Checked = False
        Me.ucrChkDropUnusedLevelsColorg.Location = New System.Drawing.Point(6, 18)
        Me.ucrChkDropUnusedLevelsColorg.Name = "ucrChkDropUnusedLevelsColorg"
        Me.ucrChkDropUnusedLevelsColorg.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsColorg.TabIndex = 222
        '
        'grpScalecolorpan
        '
        Me.grpScalecolorpan.Controls.Add(Me.ucrInputTextBreaksColorpan)
        Me.grpScalecolorpan.Controls.Add(Me.ucrInputTextNaValueColorpan)
        Me.grpScalecolorpan.Controls.Add(Me.ucrInputTextLimitColorpan)
        Me.grpScalecolorpan.Controls.Add(Me.ucrInputTextExpandColorpan)
        Me.grpScalecolorpan.Controls.Add(Me.ucrInputPositionColorpan)
        Me.grpScalecolorpan.Controls.Add(Me.ucrInputDropUnusedLevelsColorpan)
        Me.grpScalecolorpan.Controls.Add(Me.ucrChkExpandColorpan)
        Me.grpScalecolorpan.Controls.Add(Me.ucrChkPositionColorpan)
        Me.grpScalecolorpan.Controls.Add(Me.ucrChkLimitColorpan)
        Me.grpScalecolorpan.Controls.Add(Me.ucrChkBreaksColorpan)
        Me.grpScalecolorpan.Controls.Add(Me.ucrChkNaValueColorpan)
        Me.grpScalecolorpan.Controls.Add(Me.ucrChkDropUnusedLevelsColorpan)
        Me.grpScalecolorpan.Location = New System.Drawing.Point(13, 462)
        Me.grpScalecolorpan.Name = "grpScalecolorpan"
        Me.grpScalecolorpan.Size = New System.Drawing.Size(447, 175)
        Me.grpScalecolorpan.TabIndex = 256
        Me.grpScalecolorpan.TabStop = False
        Me.grpScalecolorpan.Text = "Colour Scale"
        '
        'ucrInputTextBreaksColorpan
        '
        Me.ucrInputTextBreaksColorpan.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksColorpan.AutoSize = True
        Me.ucrInputTextBreaksColorpan.IsMultiline = False
        Me.ucrInputTextBreaksColorpan.IsReadOnly = False
        Me.ucrInputTextBreaksColorpan.Location = New System.Drawing.Point(286, 38)
        Me.ucrInputTextBreaksColorpan.Name = "ucrInputTextBreaksColorpan"
        Me.ucrInputTextBreaksColorpan.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksColorpan.TabIndex = 245
        '
        'ucrInputTextNaValueColorpan
        '
        Me.ucrInputTextNaValueColorpan.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueColorpan.AutoSize = True
        Me.ucrInputTextNaValueColorpan.IsMultiline = False
        Me.ucrInputTextNaValueColorpan.IsReadOnly = False
        Me.ucrInputTextNaValueColorpan.Location = New System.Drawing.Point(286, 140)
        Me.ucrInputTextNaValueColorpan.Name = "ucrInputTextNaValueColorpan"
        Me.ucrInputTextNaValueColorpan.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueColorpan.TabIndex = 244
        '
        'ucrInputTextLimitColorpan
        '
        Me.ucrInputTextLimitColorpan.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitColorpan.AutoSize = True
        Me.ucrInputTextLimitColorpan.IsMultiline = False
        Me.ucrInputTextLimitColorpan.IsReadOnly = False
        Me.ucrInputTextLimitColorpan.Location = New System.Drawing.Point(286, 63)
        Me.ucrInputTextLimitColorpan.Name = "ucrInputTextLimitColorpan"
        Me.ucrInputTextLimitColorpan.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitColorpan.TabIndex = 243
        '
        'ucrInputTextExpandColorpan
        '
        Me.ucrInputTextExpandColorpan.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandColorpan.AutoSize = True
        Me.ucrInputTextExpandColorpan.IsMultiline = False
        Me.ucrInputTextExpandColorpan.IsReadOnly = False
        Me.ucrInputTextExpandColorpan.Location = New System.Drawing.Point(286, 114)
        Me.ucrInputTextExpandColorpan.Name = "ucrInputTextExpandColorpan"
        Me.ucrInputTextExpandColorpan.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandColorpan.TabIndex = 242
        '
        'ucrInputPositionColorpan
        '
        Me.ucrInputPositionColorpan.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionColorpan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionColorpan.GetSetSelectedIndex = -1
        Me.ucrInputPositionColorpan.IsReadOnly = False
        Me.ucrInputPositionColorpan.Location = New System.Drawing.Point(286, 88)
        Me.ucrInputPositionColorpan.Name = "ucrInputPositionColorpan"
        Me.ucrInputPositionColorpan.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionColorpan.TabIndex = 241
        '
        'ucrInputDropUnusedLevelsColorpan
        '
        Me.ucrInputDropUnusedLevelsColorpan.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsColorpan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsColorpan.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsColorpan.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsColorpan.Location = New System.Drawing.Point(286, 10)
        Me.ucrInputDropUnusedLevelsColorpan.Name = "ucrInputDropUnusedLevelsColorpan"
        Me.ucrInputDropUnusedLevelsColorpan.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsColorpan.TabIndex = 240
        '
        'ucrChkExpandColorpan
        '
        Me.ucrChkExpandColorpan.AutoSize = True
        Me.ucrChkExpandColorpan.Checked = False
        Me.ucrChkExpandColorpan.Location = New System.Drawing.Point(8, 122)
        Me.ucrChkExpandColorpan.Name = "ucrChkExpandColorpan"
        Me.ucrChkExpandColorpan.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandColorpan.TabIndex = 239
        '
        'ucrChkPositionColorpan
        '
        Me.ucrChkPositionColorpan.AutoSize = True
        Me.ucrChkPositionColorpan.Checked = False
        Me.ucrChkPositionColorpan.Location = New System.Drawing.Point(8, 99)
        Me.ucrChkPositionColorpan.Name = "ucrChkPositionColorpan"
        Me.ucrChkPositionColorpan.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionColorpan.TabIndex = 238
        '
        'ucrChkLimitColorpan
        '
        Me.ucrChkLimitColorpan.AutoSize = True
        Me.ucrChkLimitColorpan.Checked = False
        Me.ucrChkLimitColorpan.Location = New System.Drawing.Point(8, 74)
        Me.ucrChkLimitColorpan.Name = "ucrChkLimitColorpan"
        Me.ucrChkLimitColorpan.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitColorpan.TabIndex = 237
        '
        'ucrChkBreaksColorpan
        '
        Me.ucrChkBreaksColorpan.AutoSize = True
        Me.ucrChkBreaksColorpan.Checked = False
        Me.ucrChkBreaksColorpan.Location = New System.Drawing.Point(8, 47)
        Me.ucrChkBreaksColorpan.Name = "ucrChkBreaksColorpan"
        Me.ucrChkBreaksColorpan.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksColorpan.TabIndex = 236
        '
        'ucrChkNaValueColorpan
        '
        Me.ucrChkNaValueColorpan.AutoSize = True
        Me.ucrChkNaValueColorpan.Checked = False
        Me.ucrChkNaValueColorpan.Location = New System.Drawing.Point(8, 148)
        Me.ucrChkNaValueColorpan.Name = "ucrChkNaValueColorpan"
        Me.ucrChkNaValueColorpan.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValueColorpan.TabIndex = 235
        '
        'ucrChkDropUnusedLevelsColorpan
        '
        Me.ucrChkDropUnusedLevelsColorpan.AutoSize = True
        Me.ucrChkDropUnusedLevelsColorpan.Checked = False
        Me.ucrChkDropUnusedLevelsColorpan.Location = New System.Drawing.Point(8, 22)
        Me.ucrChkDropUnusedLevelsColorpan.Name = "ucrChkDropUnusedLevelsColorpan"
        Me.ucrChkDropUnusedLevelsColorpan.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsColorpan.TabIndex = 234
        '
        'grpScalecolorsol
        '
        Me.grpScalecolorsol.Controls.Add(Me.ucrInputTextBreaksColorsol)
        Me.grpScalecolorsol.Controls.Add(Me.ucrInputTextNaValueColorsol)
        Me.grpScalecolorsol.Controls.Add(Me.ucrInputTextLimitColorsol)
        Me.grpScalecolorsol.Controls.Add(Me.ucrInputTextExpandColorsol)
        Me.grpScalecolorsol.Controls.Add(Me.ucrInputPositionColorsol)
        Me.grpScalecolorsol.Controls.Add(Me.ucrInputDropUnusedLevelsColorsol)
        Me.grpScalecolorsol.Controls.Add(Me.ucrChkExpandColorsol)
        Me.grpScalecolorsol.Controls.Add(Me.ucrChkPositionColorsol)
        Me.grpScalecolorsol.Controls.Add(Me.ucrChkLimitColorsol)
        Me.grpScalecolorsol.Controls.Add(Me.ucrChkBreaksColorsol)
        Me.grpScalecolorsol.Controls.Add(Me.ucrChkNaValueColorsol)
        Me.grpScalecolorsol.Controls.Add(Me.ucrChkDropUnusedLevelsColorsol)
        Me.grpScalecolorsol.Location = New System.Drawing.Point(11, 459)
        Me.grpScalecolorsol.Name = "grpScalecolorsol"
        Me.grpScalecolorsol.Size = New System.Drawing.Size(447, 175)
        Me.grpScalecolorsol.TabIndex = 255
        Me.grpScalecolorsol.TabStop = False
        Me.grpScalecolorsol.Text = "Colour Scale"
        '
        'ucrInputTextBreaksColorsol
        '
        Me.ucrInputTextBreaksColorsol.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksColorsol.AutoSize = True
        Me.ucrInputTextBreaksColorsol.IsMultiline = False
        Me.ucrInputTextBreaksColorsol.IsReadOnly = False
        Me.ucrInputTextBreaksColorsol.Location = New System.Drawing.Point(286, 40)
        Me.ucrInputTextBreaksColorsol.Name = "ucrInputTextBreaksColorsol"
        Me.ucrInputTextBreaksColorsol.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksColorsol.TabIndex = 245
        '
        'ucrInputTextNaValueColorsol
        '
        Me.ucrInputTextNaValueColorsol.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueColorsol.AutoSize = True
        Me.ucrInputTextNaValueColorsol.IsMultiline = False
        Me.ucrInputTextNaValueColorsol.IsReadOnly = False
        Me.ucrInputTextNaValueColorsol.Location = New System.Drawing.Point(286, 140)
        Me.ucrInputTextNaValueColorsol.Name = "ucrInputTextNaValueColorsol"
        Me.ucrInputTextNaValueColorsol.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueColorsol.TabIndex = 244
        '
        'ucrInputTextLimitColorsol
        '
        Me.ucrInputTextLimitColorsol.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitColorsol.AutoSize = True
        Me.ucrInputTextLimitColorsol.IsMultiline = False
        Me.ucrInputTextLimitColorsol.IsReadOnly = False
        Me.ucrInputTextLimitColorsol.Location = New System.Drawing.Point(286, 66)
        Me.ucrInputTextLimitColorsol.Name = "ucrInputTextLimitColorsol"
        Me.ucrInputTextLimitColorsol.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitColorsol.TabIndex = 243
        '
        'ucrInputTextExpandColorsol
        '
        Me.ucrInputTextExpandColorsol.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandColorsol.AutoSize = True
        Me.ucrInputTextExpandColorsol.IsMultiline = False
        Me.ucrInputTextExpandColorsol.IsReadOnly = False
        Me.ucrInputTextExpandColorsol.Location = New System.Drawing.Point(286, 115)
        Me.ucrInputTextExpandColorsol.Name = "ucrInputTextExpandColorsol"
        Me.ucrInputTextExpandColorsol.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandColorsol.TabIndex = 242
        '
        'ucrInputPositionColorsol
        '
        Me.ucrInputPositionColorsol.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionColorsol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionColorsol.GetSetSelectedIndex = -1
        Me.ucrInputPositionColorsol.IsReadOnly = False
        Me.ucrInputPositionColorsol.Location = New System.Drawing.Point(286, 90)
        Me.ucrInputPositionColorsol.Name = "ucrInputPositionColorsol"
        Me.ucrInputPositionColorsol.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionColorsol.TabIndex = 241
        '
        'ucrInputDropUnusedLevelsColorsol
        '
        Me.ucrInputDropUnusedLevelsColorsol.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsColorsol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsColorsol.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsColorsol.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsColorsol.Location = New System.Drawing.Point(286, 12)
        Me.ucrInputDropUnusedLevelsColorsol.Name = "ucrInputDropUnusedLevelsColorsol"
        Me.ucrInputDropUnusedLevelsColorsol.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsColorsol.TabIndex = 240
        '
        'ucrChkExpandColorsol
        '
        Me.ucrChkExpandColorsol.AutoSize = True
        Me.ucrChkExpandColorsol.Checked = False
        Me.ucrChkExpandColorsol.Location = New System.Drawing.Point(7, 120)
        Me.ucrChkExpandColorsol.Name = "ucrChkExpandColorsol"
        Me.ucrChkExpandColorsol.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandColorsol.TabIndex = 239
        '
        'ucrChkPositionColorsol
        '
        Me.ucrChkPositionColorsol.AutoSize = True
        Me.ucrChkPositionColorsol.Checked = False
        Me.ucrChkPositionColorsol.Location = New System.Drawing.Point(7, 99)
        Me.ucrChkPositionColorsol.Name = "ucrChkPositionColorsol"
        Me.ucrChkPositionColorsol.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionColorsol.TabIndex = 238
        '
        'ucrChkLimitColorsol
        '
        Me.ucrChkLimitColorsol.AutoSize = True
        Me.ucrChkLimitColorsol.Checked = False
        Me.ucrChkLimitColorsol.Location = New System.Drawing.Point(7, 75)
        Me.ucrChkLimitColorsol.Name = "ucrChkLimitColorsol"
        Me.ucrChkLimitColorsol.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitColorsol.TabIndex = 237
        '
        'ucrChkBreaksColorsol
        '
        Me.ucrChkBreaksColorsol.AutoSize = True
        Me.ucrChkBreaksColorsol.Checked = False
        Me.ucrChkBreaksColorsol.Location = New System.Drawing.Point(7, 47)
        Me.ucrChkBreaksColorsol.Name = "ucrChkBreaksColorsol"
        Me.ucrChkBreaksColorsol.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksColorsol.TabIndex = 236
        '
        'ucrChkNaValueColorsol
        '
        Me.ucrChkNaValueColorsol.AutoSize = True
        Me.ucrChkNaValueColorsol.Checked = False
        Me.ucrChkNaValueColorsol.Location = New System.Drawing.Point(7, 144)
        Me.ucrChkNaValueColorsol.Name = "ucrChkNaValueColorsol"
        Me.ucrChkNaValueColorsol.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValueColorsol.TabIndex = 235
        '
        'ucrChkDropUnusedLevelsColorsol
        '
        Me.ucrChkDropUnusedLevelsColorsol.AutoSize = True
        Me.ucrChkDropUnusedLevelsColorsol.Checked = False
        Me.ucrChkDropUnusedLevelsColorsol.Location = New System.Drawing.Point(7, 22)
        Me.ucrChkDropUnusedLevelsColorsol.Name = "ucrChkDropUnusedLevelsColorsol"
        Me.ucrChkDropUnusedLevelsColorsol.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsColorsol.TabIndex = 234
        '
        'grpScalecolorfew
        '
        Me.grpScalecolorfew.Controls.Add(Me.ucrInputPalettecolor)
        Me.grpScalecolorfew.Controls.Add(Me.ucrChkPalettecolor)
        Me.grpScalecolorfew.Controls.Add(Me.ucrInputTextBreaksColorfew)
        Me.grpScalecolorfew.Controls.Add(Me.ucrInputTextExpandColorfew)
        Me.grpScalecolorfew.Controls.Add(Me.ucrInputTextLimitColorfew)
        Me.grpScalecolorfew.Controls.Add(Me.ucrInputTextNaValueColorfew)
        Me.grpScalecolorfew.Controls.Add(Me.ucrInputPositionColorfew)
        Me.grpScalecolorfew.Controls.Add(Me.ucrInputDropUnusedLevelsColorfew)
        Me.grpScalecolorfew.Controls.Add(Me.ucrChkNaValueColorfew)
        Me.grpScalecolorfew.Controls.Add(Me.ucrChkPositionColorfew)
        Me.grpScalecolorfew.Controls.Add(Me.ucrChkLimitColorfew)
        Me.grpScalecolorfew.Controls.Add(Me.ucrChkBreaksColorfew)
        Me.grpScalecolorfew.Controls.Add(Me.ucrChkExpandColorfew)
        Me.grpScalecolorfew.Controls.Add(Me.ucrChkDropUnusedLevelsColorfew)
        Me.grpScalecolorfew.Location = New System.Drawing.Point(13, 456)
        Me.grpScalecolorfew.Name = "grpScalecolorfew"
        Me.grpScalecolorfew.Size = New System.Drawing.Size(444, 178)
        Me.grpScalecolorfew.TabIndex = 253
        Me.grpScalecolorfew.TabStop = False
        Me.grpScalecolorfew.Text = "Colour Scale"
        '
        'ucrInputPalettecolor
        '
        Me.ucrInputPalettecolor.AddQuotesIfUnrecognised = True
        Me.ucrInputPalettecolor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPalettecolor.GetSetSelectedIndex = -1
        Me.ucrInputPalettecolor.IsReadOnly = False
        Me.ucrInputPalettecolor.Location = New System.Drawing.Point(284, 147)
        Me.ucrInputPalettecolor.Name = "ucrInputPalettecolor"
        Me.ucrInputPalettecolor.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPalettecolor.TabIndex = 227
        '
        'ucrChkPalettecolor
        '
        Me.ucrChkPalettecolor.AutoSize = True
        Me.ucrChkPalettecolor.Checked = False
        Me.ucrChkPalettecolor.Location = New System.Drawing.Point(9, 148)
        Me.ucrChkPalettecolor.Name = "ucrChkPalettecolor"
        Me.ucrChkPalettecolor.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPalettecolor.TabIndex = 226
        '
        'ucrInputTextBreaksColorfew
        '
        Me.ucrInputTextBreaksColorfew.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksColorfew.AutoSize = True
        Me.ucrInputTextBreaksColorfew.IsMultiline = False
        Me.ucrInputTextBreaksColorfew.IsReadOnly = False
        Me.ucrInputTextBreaksColorfew.Location = New System.Drawing.Point(285, 32)
        Me.ucrInputTextBreaksColorfew.Name = "ucrInputTextBreaksColorfew"
        Me.ucrInputTextBreaksColorfew.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksColorfew.TabIndex = 225
        '
        'ucrInputTextExpandColorfew
        '
        Me.ucrInputTextExpandColorfew.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandColorfew.AutoSize = True
        Me.ucrInputTextExpandColorfew.IsMultiline = False
        Me.ucrInputTextExpandColorfew.IsReadOnly = False
        Me.ucrInputTextExpandColorfew.Location = New System.Drawing.Point(285, 125)
        Me.ucrInputTextExpandColorfew.Name = "ucrInputTextExpandColorfew"
        Me.ucrInputTextExpandColorfew.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandColorfew.TabIndex = 224
        '
        'ucrInputTextLimitColorfew
        '
        Me.ucrInputTextLimitColorfew.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitColorfew.AutoSize = True
        Me.ucrInputTextLimitColorfew.IsMultiline = False
        Me.ucrInputTextLimitColorfew.IsReadOnly = False
        Me.ucrInputTextLimitColorfew.Location = New System.Drawing.Point(285, 55)
        Me.ucrInputTextLimitColorfew.Name = "ucrInputTextLimitColorfew"
        Me.ucrInputTextLimitColorfew.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitColorfew.TabIndex = 223
        '
        'ucrInputTextNaValueColorfew
        '
        Me.ucrInputTextNaValueColorfew.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueColorfew.AutoSize = True
        Me.ucrInputTextNaValueColorfew.IsMultiline = False
        Me.ucrInputTextNaValueColorfew.IsReadOnly = False
        Me.ucrInputTextNaValueColorfew.Location = New System.Drawing.Point(285, 102)
        Me.ucrInputTextNaValueColorfew.Name = "ucrInputTextNaValueColorfew"
        Me.ucrInputTextNaValueColorfew.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueColorfew.TabIndex = 222
        '
        'ucrInputPositionColorfew
        '
        Me.ucrInputPositionColorfew.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionColorfew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionColorfew.GetSetSelectedIndex = -1
        Me.ucrInputPositionColorfew.IsReadOnly = False
        Me.ucrInputPositionColorfew.Location = New System.Drawing.Point(285, 78)
        Me.ucrInputPositionColorfew.Name = "ucrInputPositionColorfew"
        Me.ucrInputPositionColorfew.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionColorfew.TabIndex = 221
        '
        'ucrInputDropUnusedLevelsColorfew
        '
        Me.ucrInputDropUnusedLevelsColorfew.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsColorfew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsColorfew.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsColorfew.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsColorfew.Location = New System.Drawing.Point(285, 8)
        Me.ucrInputDropUnusedLevelsColorfew.Name = "ucrInputDropUnusedLevelsColorfew"
        Me.ucrInputDropUnusedLevelsColorfew.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsColorfew.TabIndex = 220
        '
        'ucrChkNaValueColorfew
        '
        Me.ucrChkNaValueColorfew.AutoSize = True
        Me.ucrChkNaValueColorfew.Checked = False
        Me.ucrChkNaValueColorfew.Location = New System.Drawing.Point(9, 104)
        Me.ucrChkNaValueColorfew.Name = "ucrChkNaValueColorfew"
        Me.ucrChkNaValueColorfew.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkNaValueColorfew.TabIndex = 219
        '
        'ucrChkPositionColorfew
        '
        Me.ucrChkPositionColorfew.AutoSize = True
        Me.ucrChkPositionColorfew.Checked = False
        Me.ucrChkPositionColorfew.Location = New System.Drawing.Point(9, 83)
        Me.ucrChkPositionColorfew.Name = "ucrChkPositionColorfew"
        Me.ucrChkPositionColorfew.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionColorfew.TabIndex = 218
        '
        'ucrChkLimitColorfew
        '
        Me.ucrChkLimitColorfew.AutoSize = True
        Me.ucrChkLimitColorfew.Checked = False
        Me.ucrChkLimitColorfew.Location = New System.Drawing.Point(9, 59)
        Me.ucrChkLimitColorfew.Name = "ucrChkLimitColorfew"
        Me.ucrChkLimitColorfew.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitColorfew.TabIndex = 217
        '
        'ucrChkBreaksColorfew
        '
        Me.ucrChkBreaksColorfew.AutoSize = True
        Me.ucrChkBreaksColorfew.Checked = False
        Me.ucrChkBreaksColorfew.Location = New System.Drawing.Point(9, 35)
        Me.ucrChkBreaksColorfew.Name = "ucrChkBreaksColorfew"
        Me.ucrChkBreaksColorfew.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksColorfew.TabIndex = 216
        '
        'ucrChkExpandColorfew
        '
        Me.ucrChkExpandColorfew.AutoSize = True
        Me.ucrChkExpandColorfew.Checked = False
        Me.ucrChkExpandColorfew.Location = New System.Drawing.Point(9, 125)
        Me.ucrChkExpandColorfew.Name = "ucrChkExpandColorfew"
        Me.ucrChkExpandColorfew.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkExpandColorfew.TabIndex = 215
        '
        'ucrChkDropUnusedLevelsColorfew
        '
        Me.ucrChkDropUnusedLevelsColorfew.AutoSize = True
        Me.ucrChkDropUnusedLevelsColorfew.Checked = False
        Me.ucrChkDropUnusedLevelsColorfew.Location = New System.Drawing.Point(9, 14)
        Me.ucrChkDropUnusedLevelsColorfew.Name = "ucrChkDropUnusedLevelsColorfew"
        Me.ucrChkDropUnusedLevelsColorfew.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsColorfew.TabIndex = 214
        '
        'grpScalecolorhc
        '
        Me.grpScalecolorhc.Controls.Add(Me.ucrInputPalettecolorhc)
        Me.grpScalecolorhc.Controls.Add(Me.ucrChkPalettecolorhc)
        Me.grpScalecolorhc.Controls.Add(Me.ucrInputTextBreaksColorhc)
        Me.grpScalecolorhc.Controls.Add(Me.ucrInputTextNaValueColorhc)
        Me.grpScalecolorhc.Controls.Add(Me.ucrInputTextLimitColorhc)
        Me.grpScalecolorhc.Controls.Add(Me.ucrInputTextExpandColorhc)
        Me.grpScalecolorhc.Controls.Add(Me.ucrInputPositionColorhc)
        Me.grpScalecolorhc.Controls.Add(Me.ucrInputDropUnusedLevelsColorhc)
        Me.grpScalecolorhc.Controls.Add(Me.ucrChkExpandColorhc)
        Me.grpScalecolorhc.Controls.Add(Me.ucrChkPositionColorhc)
        Me.grpScalecolorhc.Controls.Add(Me.ucrChkLimitColorhc)
        Me.grpScalecolorhc.Controls.Add(Me.ucrChkBreaksColorhc)
        Me.grpScalecolorhc.Controls.Add(Me.ucrChkNaValueColorhc)
        Me.grpScalecolorhc.Controls.Add(Me.ucrChkDropUnusedLevelsColorhc)
        Me.grpScalecolorhc.Location = New System.Drawing.Point(12, 460)
        Me.grpScalecolorhc.Name = "grpScalecolorhc"
        Me.grpScalecolorhc.Size = New System.Drawing.Size(447, 175)
        Me.grpScalecolorhc.TabIndex = 252
        Me.grpScalecolorhc.TabStop = False
        Me.grpScalecolorhc.Text = "Colour Scale"
        '
        'ucrInputPalettecolorhc
        '
        Me.ucrInputPalettecolorhc.AddQuotesIfUnrecognised = True
        Me.ucrInputPalettecolorhc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPalettecolorhc.GetSetSelectedIndex = -1
        Me.ucrInputPalettecolorhc.IsReadOnly = False
        Me.ucrInputPalettecolorhc.Location = New System.Drawing.Point(285, 150)
        Me.ucrInputPalettecolorhc.Name = "ucrInputPalettecolorhc"
        Me.ucrInputPalettecolorhc.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPalettecolorhc.TabIndex = 199
        '
        'ucrChkPalettecolorhc
        '
        Me.ucrChkPalettecolorhc.AutoSize = True
        Me.ucrChkPalettecolorhc.Checked = False
        Me.ucrChkPalettecolorhc.Location = New System.Drawing.Point(8, 153)
        Me.ucrChkPalettecolorhc.Name = "ucrChkPalettecolorhc"
        Me.ucrChkPalettecolorhc.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPalettecolorhc.TabIndex = 198
        '
        'ucrInputTextBreaksColorhc
        '
        Me.ucrInputTextBreaksColorhc.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksColorhc.AutoSize = True
        Me.ucrInputTextBreaksColorhc.IsMultiline = False
        Me.ucrInputTextBreaksColorhc.IsReadOnly = False
        Me.ucrInputTextBreaksColorhc.Location = New System.Drawing.Point(286, 35)
        Me.ucrInputTextBreaksColorhc.Name = "ucrInputTextBreaksColorhc"
        Me.ucrInputTextBreaksColorhc.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksColorhc.TabIndex = 197
        '
        'ucrInputTextNaValueColorhc
        '
        Me.ucrInputTextNaValueColorhc.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueColorhc.AutoSize = True
        Me.ucrInputTextNaValueColorhc.IsMultiline = False
        Me.ucrInputTextNaValueColorhc.IsReadOnly = False
        Me.ucrInputTextNaValueColorhc.Location = New System.Drawing.Point(286, 128)
        Me.ucrInputTextNaValueColorhc.Name = "ucrInputTextNaValueColorhc"
        Me.ucrInputTextNaValueColorhc.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueColorhc.TabIndex = 196
        '
        'ucrInputTextLimitColorhc
        '
        Me.ucrInputTextLimitColorhc.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitColorhc.AutoSize = True
        Me.ucrInputTextLimitColorhc.IsMultiline = False
        Me.ucrInputTextLimitColorhc.IsReadOnly = False
        Me.ucrInputTextLimitColorhc.Location = New System.Drawing.Point(286, 58)
        Me.ucrInputTextLimitColorhc.Name = "ucrInputTextLimitColorhc"
        Me.ucrInputTextLimitColorhc.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitColorhc.TabIndex = 195
        '
        'ucrInputTextExpandColorhc
        '
        Me.ucrInputTextExpandColorhc.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandColorhc.AutoSize = True
        Me.ucrInputTextExpandColorhc.IsMultiline = False
        Me.ucrInputTextExpandColorhc.IsReadOnly = False
        Me.ucrInputTextExpandColorhc.Location = New System.Drawing.Point(286, 105)
        Me.ucrInputTextExpandColorhc.Name = "ucrInputTextExpandColorhc"
        Me.ucrInputTextExpandColorhc.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandColorhc.TabIndex = 194
        '
        'ucrInputPositionColorhc
        '
        Me.ucrInputPositionColorhc.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionColorhc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionColorhc.GetSetSelectedIndex = -1
        Me.ucrInputPositionColorhc.IsReadOnly = False
        Me.ucrInputPositionColorhc.Location = New System.Drawing.Point(286, 81)
        Me.ucrInputPositionColorhc.Name = "ucrInputPositionColorhc"
        Me.ucrInputPositionColorhc.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionColorhc.TabIndex = 193
        '
        'ucrInputDropUnusedLevelsColorhc
        '
        Me.ucrInputDropUnusedLevelsColorhc.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsColorhc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsColorhc.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsColorhc.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsColorhc.Location = New System.Drawing.Point(286, 11)
        Me.ucrInputDropUnusedLevelsColorhc.Name = "ucrInputDropUnusedLevelsColorhc"
        Me.ucrInputDropUnusedLevelsColorhc.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsColorhc.TabIndex = 192
        '
        'ucrChkExpandColorhc
        '
        Me.ucrChkExpandColorhc.AutoSize = True
        Me.ucrChkExpandColorhc.Checked = False
        Me.ucrChkExpandColorhc.Location = New System.Drawing.Point(8, 109)
        Me.ucrChkExpandColorhc.Name = "ucrChkExpandColorhc"
        Me.ucrChkExpandColorhc.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandColorhc.TabIndex = 191
        '
        'ucrChkPositionColorhc
        '
        Me.ucrChkPositionColorhc.AutoSize = True
        Me.ucrChkPositionColorhc.Checked = False
        Me.ucrChkPositionColorhc.Location = New System.Drawing.Point(8, 88)
        Me.ucrChkPositionColorhc.Name = "ucrChkPositionColorhc"
        Me.ucrChkPositionColorhc.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionColorhc.TabIndex = 190
        '
        'ucrChkLimitColorhc
        '
        Me.ucrChkLimitColorhc.AutoSize = True
        Me.ucrChkLimitColorhc.Checked = False
        Me.ucrChkLimitColorhc.Location = New System.Drawing.Point(8, 64)
        Me.ucrChkLimitColorhc.Name = "ucrChkLimitColorhc"
        Me.ucrChkLimitColorhc.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitColorhc.TabIndex = 189
        '
        'ucrChkBreaksColorhc
        '
        Me.ucrChkBreaksColorhc.AutoSize = True
        Me.ucrChkBreaksColorhc.Checked = False
        Me.ucrChkBreaksColorhc.Location = New System.Drawing.Point(8, 40)
        Me.ucrChkBreaksColorhc.Name = "ucrChkBreaksColorhc"
        Me.ucrChkBreaksColorhc.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksColorhc.TabIndex = 188
        '
        'ucrChkNaValueColorhc
        '
        Me.ucrChkNaValueColorhc.AutoSize = True
        Me.ucrChkNaValueColorhc.Checked = False
        Me.ucrChkNaValueColorhc.Location = New System.Drawing.Point(8, 130)
        Me.ucrChkNaValueColorhc.Name = "ucrChkNaValueColorhc"
        Me.ucrChkNaValueColorhc.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValueColorhc.TabIndex = 187
        '
        'ucrChkDropUnusedLevelsColorhc
        '
        Me.ucrChkDropUnusedLevelsColorhc.AutoSize = True
        Me.ucrChkDropUnusedLevelsColorhc.Checked = False
        Me.ucrChkDropUnusedLevelsColorhc.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkDropUnusedLevelsColorhc.Name = "ucrChkDropUnusedLevelsColorhc"
        Me.ucrChkDropUnusedLevelsColorhc.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsColorhc.TabIndex = 186
        '
        'grpScalecolorcal
        '
        Me.grpScalecolorcal.Controls.Add(Me.ucrInputTextBreaksColorCal)
        Me.grpScalecolorcal.Controls.Add(Me.ucrInputTextNaValueColorCal)
        Me.grpScalecolorcal.Controls.Add(Me.ucrInputTextLimitColorCal)
        Me.grpScalecolorcal.Controls.Add(Me.ucrInputTextExpandColorCal)
        Me.grpScalecolorcal.Controls.Add(Me.ucrInputPositionColorCal)
        Me.grpScalecolorcal.Controls.Add(Me.ucrInputDropUnusedLevelsColorCal)
        Me.grpScalecolorcal.Controls.Add(Me.ucrChkExpandColorCal)
        Me.grpScalecolorcal.Controls.Add(Me.ucrChkPositionColorCal)
        Me.grpScalecolorcal.Controls.Add(Me.ucrChkLimitColorCal)
        Me.grpScalecolorcal.Controls.Add(Me.ucrChkBreaksColorCal)
        Me.grpScalecolorcal.Controls.Add(Me.ucrChkNaValueColorCal)
        Me.grpScalecolorcal.Controls.Add(Me.ucrChkDropUnusedLevelsColorCal)
        Me.grpScalecolorcal.Location = New System.Drawing.Point(11, 460)
        Me.grpScalecolorcal.Name = "grpScalecolorcal"
        Me.grpScalecolorcal.Size = New System.Drawing.Size(447, 175)
        Me.grpScalecolorcal.TabIndex = 251
        Me.grpScalecolorcal.TabStop = False
        Me.grpScalecolorcal.Text = "Colour Scale"
        '
        'ucrInputTextBreaksColorCal
        '
        Me.ucrInputTextBreaksColorCal.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksColorCal.AutoSize = True
        Me.ucrInputTextBreaksColorCal.IsMultiline = False
        Me.ucrInputTextBreaksColorCal.IsReadOnly = False
        Me.ucrInputTextBreaksColorCal.Location = New System.Drawing.Point(286, 45)
        Me.ucrInputTextBreaksColorCal.Name = "ucrInputTextBreaksColorCal"
        Me.ucrInputTextBreaksColorCal.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksColorCal.TabIndex = 209
        '
        'ucrInputTextNaValueColorCal
        '
        Me.ucrInputTextNaValueColorCal.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueColorCal.AutoSize = True
        Me.ucrInputTextNaValueColorCal.IsMultiline = False
        Me.ucrInputTextNaValueColorCal.IsReadOnly = False
        Me.ucrInputTextNaValueColorCal.Location = New System.Drawing.Point(286, 145)
        Me.ucrInputTextNaValueColorCal.Name = "ucrInputTextNaValueColorCal"
        Me.ucrInputTextNaValueColorCal.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueColorCal.TabIndex = 208
        '
        'ucrInputTextLimitColorCal
        '
        Me.ucrInputTextLimitColorCal.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitColorCal.AutoSize = True
        Me.ucrInputTextLimitColorCal.IsMultiline = False
        Me.ucrInputTextLimitColorCal.IsReadOnly = False
        Me.ucrInputTextLimitColorCal.Location = New System.Drawing.Point(286, 71)
        Me.ucrInputTextLimitColorCal.Name = "ucrInputTextLimitColorCal"
        Me.ucrInputTextLimitColorCal.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitColorCal.TabIndex = 207
        '
        'ucrInputTextExpandColorCal
        '
        Me.ucrInputTextExpandColorCal.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandColorCal.AutoSize = True
        Me.ucrInputTextExpandColorCal.IsMultiline = False
        Me.ucrInputTextExpandColorCal.IsReadOnly = False
        Me.ucrInputTextExpandColorCal.Location = New System.Drawing.Point(286, 120)
        Me.ucrInputTextExpandColorCal.Name = "ucrInputTextExpandColorCal"
        Me.ucrInputTextExpandColorCal.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandColorCal.TabIndex = 206
        '
        'ucrInputPositionColorCal
        '
        Me.ucrInputPositionColorCal.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionColorCal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionColorCal.GetSetSelectedIndex = -1
        Me.ucrInputPositionColorCal.IsReadOnly = False
        Me.ucrInputPositionColorCal.Location = New System.Drawing.Point(286, 95)
        Me.ucrInputPositionColorCal.Name = "ucrInputPositionColorCal"
        Me.ucrInputPositionColorCal.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionColorCal.TabIndex = 205
        '
        'ucrInputDropUnusedLevelsColorCal
        '
        Me.ucrInputDropUnusedLevelsColorCal.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsColorCal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsColorCal.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsColorCal.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsColorCal.Location = New System.Drawing.Point(286, 17)
        Me.ucrInputDropUnusedLevelsColorCal.Name = "ucrInputDropUnusedLevelsColorCal"
        Me.ucrInputDropUnusedLevelsColorCal.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsColorCal.TabIndex = 204
        '
        'ucrChkExpandColorCal
        '
        Me.ucrChkExpandColorCal.AutoSize = True
        Me.ucrChkExpandColorCal.Checked = False
        Me.ucrChkExpandColorCal.Location = New System.Drawing.Point(9, 121)
        Me.ucrChkExpandColorCal.Name = "ucrChkExpandColorCal"
        Me.ucrChkExpandColorCal.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandColorCal.TabIndex = 203
        '
        'ucrChkPositionColorCal
        '
        Me.ucrChkPositionColorCal.AutoSize = True
        Me.ucrChkPositionColorCal.Checked = False
        Me.ucrChkPositionColorCal.Location = New System.Drawing.Point(9, 100)
        Me.ucrChkPositionColorCal.Name = "ucrChkPositionColorCal"
        Me.ucrChkPositionColorCal.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionColorCal.TabIndex = 202
        '
        'ucrChkLimitColorCal
        '
        Me.ucrChkLimitColorCal.AutoSize = True
        Me.ucrChkLimitColorCal.Checked = False
        Me.ucrChkLimitColorCal.Location = New System.Drawing.Point(9, 73)
        Me.ucrChkLimitColorCal.Name = "ucrChkLimitColorCal"
        Me.ucrChkLimitColorCal.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitColorCal.TabIndex = 201
        '
        'ucrChkBreaksColorCal
        '
        Me.ucrChkBreaksColorCal.AutoSize = True
        Me.ucrChkBreaksColorCal.Checked = False
        Me.ucrChkBreaksColorCal.Location = New System.Drawing.Point(9, 48)
        Me.ucrChkBreaksColorCal.Name = "ucrChkBreaksColorCal"
        Me.ucrChkBreaksColorCal.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksColorCal.TabIndex = 200
        '
        'ucrChkNaValueColorCal
        '
        Me.ucrChkNaValueColorCal.AutoSize = True
        Me.ucrChkNaValueColorCal.Checked = False
        Me.ucrChkNaValueColorCal.Location = New System.Drawing.Point(9, 145)
        Me.ucrChkNaValueColorCal.Name = "ucrChkNaValueColorCal"
        Me.ucrChkNaValueColorCal.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValueColorCal.TabIndex = 199
        '
        'ucrChkDropUnusedLevelsColorCal
        '
        Me.ucrChkDropUnusedLevelsColorCal.AutoSize = True
        Me.ucrChkDropUnusedLevelsColorCal.Checked = False
        Me.ucrChkDropUnusedLevelsColorCal.Location = New System.Drawing.Point(9, 23)
        Me.ucrChkDropUnusedLevelsColorCal.Name = "ucrChkDropUnusedLevelsColorCal"
        Me.ucrChkDropUnusedLevelsColorCal.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsColorCal.TabIndex = 198
        '
        'grpScaleFillfiv
        '
        Me.grpScaleFillfiv.Controls.Add(Me.ucrInputTextBreaksfiv)
        Me.grpScaleFillfiv.Controls.Add(Me.ucrInputTextNaValuefiv)
        Me.grpScaleFillfiv.Controls.Add(Me.ucrInputTextLimitfiv)
        Me.grpScaleFillfiv.Controls.Add(Me.ucrInputTextExpandfiv)
        Me.grpScaleFillfiv.Controls.Add(Me.ucrInputPositionfiv)
        Me.grpScaleFillfiv.Controls.Add(Me.ucrInputDropUnusedLevelsfiv)
        Me.grpScaleFillfiv.Controls.Add(Me.ucrChkExpandfiv)
        Me.grpScaleFillfiv.Controls.Add(Me.ucrChkPositionfiv)
        Me.grpScaleFillfiv.Controls.Add(Me.ucrChkLimitfiv)
        Me.grpScaleFillfiv.Controls.Add(Me.ucrChkBreaksfiv)
        Me.grpScaleFillfiv.Controls.Add(Me.ucrChkNaValuefiv)
        Me.grpScaleFillfiv.Controls.Add(Me.ucrChkDropUnusedLevelsfiv)
        Me.grpScaleFillfiv.Location = New System.Drawing.Point(14, 200)
        Me.grpScaleFillfiv.Name = "grpScaleFillfiv"
        Me.grpScaleFillfiv.Size = New System.Drawing.Size(444, 184)
        Me.grpScaleFillfiv.TabIndex = 240
        Me.grpScaleFillfiv.TabStop = False
        Me.grpScaleFillfiv.Text = "Fill Scale"
        '
        'ucrInputTextBreaksfiv
        '
        Me.ucrInputTextBreaksfiv.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksfiv.AutoSize = True
        Me.ucrInputTextBreaksfiv.IsMultiline = False
        Me.ucrInputTextBreaksfiv.IsReadOnly = False
        Me.ucrInputTextBreaksfiv.Location = New System.Drawing.Point(285, 48)
        Me.ucrInputTextBreaksfiv.Name = "ucrInputTextBreaksfiv"
        Me.ucrInputTextBreaksfiv.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksfiv.TabIndex = 109
        '
        'ucrInputTextNaValuefiv
        '
        Me.ucrInputTextNaValuefiv.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValuefiv.AutoSize = True
        Me.ucrInputTextNaValuefiv.IsMultiline = False
        Me.ucrInputTextNaValuefiv.IsReadOnly = False
        Me.ucrInputTextNaValuefiv.Location = New System.Drawing.Point(285, 154)
        Me.ucrInputTextNaValuefiv.Name = "ucrInputTextNaValuefiv"
        Me.ucrInputTextNaValuefiv.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValuefiv.TabIndex = 108
        '
        'ucrInputTextLimitfiv
        '
        Me.ucrInputTextLimitfiv.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitfiv.AutoSize = True
        Me.ucrInputTextLimitfiv.IsMultiline = False
        Me.ucrInputTextLimitfiv.IsReadOnly = False
        Me.ucrInputTextLimitfiv.Location = New System.Drawing.Point(285, 75)
        Me.ucrInputTextLimitfiv.Name = "ucrInputTextLimitfiv"
        Me.ucrInputTextLimitfiv.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitfiv.TabIndex = 107
        '
        'ucrInputTextExpandfiv
        '
        Me.ucrInputTextExpandfiv.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandfiv.AutoSize = True
        Me.ucrInputTextExpandfiv.IsMultiline = False
        Me.ucrInputTextExpandfiv.IsReadOnly = False
        Me.ucrInputTextExpandfiv.Location = New System.Drawing.Point(285, 127)
        Me.ucrInputTextExpandfiv.Name = "ucrInputTextExpandfiv"
        Me.ucrInputTextExpandfiv.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandfiv.TabIndex = 106
        '
        'ucrInputPositionfiv
        '
        Me.ucrInputPositionfiv.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionfiv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionfiv.GetSetSelectedIndex = -1
        Me.ucrInputPositionfiv.IsReadOnly = False
        Me.ucrInputPositionfiv.Location = New System.Drawing.Point(285, 102)
        Me.ucrInputPositionfiv.Name = "ucrInputPositionfiv"
        Me.ucrInputPositionfiv.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionfiv.TabIndex = 105
        '
        'ucrInputDropUnusedLevelsfiv
        '
        Me.ucrInputDropUnusedLevelsfiv.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsfiv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsfiv.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsfiv.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsfiv.Location = New System.Drawing.Point(285, 23)
        Me.ucrInputDropUnusedLevelsfiv.Name = "ucrInputDropUnusedLevelsfiv"
        Me.ucrInputDropUnusedLevelsfiv.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsfiv.TabIndex = 104
        '
        'ucrChkExpandfiv
        '
        Me.ucrChkExpandfiv.AutoSize = True
        Me.ucrChkExpandfiv.Checked = False
        Me.ucrChkExpandfiv.Location = New System.Drawing.Point(11, 126)
        Me.ucrChkExpandfiv.Name = "ucrChkExpandfiv"
        Me.ucrChkExpandfiv.Size = New System.Drawing.Size(242, 23)
        Me.ucrChkExpandfiv.TabIndex = 103
        '
        'ucrChkPositionfiv
        '
        Me.ucrChkPositionfiv.AutoSize = True
        Me.ucrChkPositionfiv.Checked = False
        Me.ucrChkPositionfiv.Location = New System.Drawing.Point(11, 101)
        Me.ucrChkPositionfiv.Name = "ucrChkPositionfiv"
        Me.ucrChkPositionfiv.Size = New System.Drawing.Size(242, 23)
        Me.ucrChkPositionfiv.TabIndex = 102
        '
        'ucrChkLimitfiv
        '
        Me.ucrChkLimitfiv.AutoSize = True
        Me.ucrChkLimitfiv.Checked = False
        Me.ucrChkLimitfiv.Location = New System.Drawing.Point(11, 76)
        Me.ucrChkLimitfiv.Name = "ucrChkLimitfiv"
        Me.ucrChkLimitfiv.Size = New System.Drawing.Size(242, 23)
        Me.ucrChkLimitfiv.TabIndex = 101
        '
        'ucrChkBreaksfiv
        '
        Me.ucrChkBreaksfiv.AutoSize = True
        Me.ucrChkBreaksfiv.Checked = False
        Me.ucrChkBreaksfiv.Location = New System.Drawing.Point(11, 51)
        Me.ucrChkBreaksfiv.Name = "ucrChkBreaksfiv"
        Me.ucrChkBreaksfiv.Size = New System.Drawing.Size(242, 23)
        Me.ucrChkBreaksfiv.TabIndex = 100
        '
        'ucrChkNaValuefiv
        '
        Me.ucrChkNaValuefiv.AutoSize = True
        Me.ucrChkNaValuefiv.Checked = False
        Me.ucrChkNaValuefiv.Location = New System.Drawing.Point(11, 151)
        Me.ucrChkNaValuefiv.Name = "ucrChkNaValuefiv"
        Me.ucrChkNaValuefiv.Size = New System.Drawing.Size(243, 23)
        Me.ucrChkNaValuefiv.TabIndex = 99
        '
        'ucrChkDropUnusedLevelsfiv
        '
        Me.ucrChkDropUnusedLevelsfiv.AutoSize = True
        Me.ucrChkDropUnusedLevelsfiv.Checked = False
        Me.ucrChkDropUnusedLevelsfiv.Location = New System.Drawing.Point(11, 23)
        Me.ucrChkDropUnusedLevelsfiv.Name = "ucrChkDropUnusedLevelsfiv"
        Me.ucrChkDropUnusedLevelsfiv.Size = New System.Drawing.Size(242, 23)
        Me.ucrChkDropUnusedLevelsfiv.TabIndex = 98
        '
        'grpScalefillpt
        '
        Me.grpScalefillpt.Controls.Add(Me.ucrInputTextBreakspt)
        Me.grpScalefillpt.Controls.Add(Me.ucrInputTextNaValuept)
        Me.grpScalefillpt.Controls.Add(Me.ucrInputTextLimitpt)
        Me.grpScalefillpt.Controls.Add(Me.ucrInputTextExpandpt)
        Me.grpScalefillpt.Controls.Add(Me.ucrInputPositionpt)
        Me.grpScalefillpt.Controls.Add(Me.ucrInputDropUnusedLevelspt)
        Me.grpScalefillpt.Controls.Add(Me.ucrChkExpandpt)
        Me.grpScalefillpt.Controls.Add(Me.ucrChkPositionpt)
        Me.grpScalefillpt.Controls.Add(Me.ucrChkLimitpt)
        Me.grpScalefillpt.Controls.Add(Me.ucrChkBreakspt)
        Me.grpScalefillpt.Controls.Add(Me.ucrChkNaValuept)
        Me.grpScalefillpt.Controls.Add(Me.ucrChkDropUnusedLevelspt)
        Me.grpScalefillpt.Location = New System.Drawing.Point(14, 200)
        Me.grpScalefillpt.Name = "grpScalefillpt"
        Me.grpScalefillpt.Size = New System.Drawing.Size(444, 178)
        Me.grpScalefillpt.TabIndex = 250
        Me.grpScalefillpt.TabStop = False
        Me.grpScalefillpt.Text = "Fill Scale "
        '
        'ucrInputTextBreakspt
        '
        Me.ucrInputTextBreakspt.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreakspt.AutoSize = True
        Me.ucrInputTextBreakspt.IsMultiline = False
        Me.ucrInputTextBreakspt.IsReadOnly = False
        Me.ucrInputTextBreakspt.Location = New System.Drawing.Point(285, 45)
        Me.ucrInputTextBreakspt.Name = "ucrInputTextBreakspt"
        Me.ucrInputTextBreakspt.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreakspt.TabIndex = 169
        '
        'ucrInputTextNaValuept
        '
        Me.ucrInputTextNaValuept.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValuept.AutoSize = True
        Me.ucrInputTextNaValuept.IsMultiline = False
        Me.ucrInputTextNaValuept.IsReadOnly = False
        Me.ucrInputTextNaValuept.Location = New System.Drawing.Point(285, 149)
        Me.ucrInputTextNaValuept.Name = "ucrInputTextNaValuept"
        Me.ucrInputTextNaValuept.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValuept.TabIndex = 168
        '
        'ucrInputTextLimitpt
        '
        Me.ucrInputTextLimitpt.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitpt.AutoSize = True
        Me.ucrInputTextLimitpt.IsMultiline = False
        Me.ucrInputTextLimitpt.IsReadOnly = False
        Me.ucrInputTextLimitpt.Location = New System.Drawing.Point(285, 72)
        Me.ucrInputTextLimitpt.Name = "ucrInputTextLimitpt"
        Me.ucrInputTextLimitpt.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitpt.TabIndex = 167
        '
        'ucrInputTextExpandpt
        '
        Me.ucrInputTextExpandpt.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandpt.AutoSize = True
        Me.ucrInputTextExpandpt.IsMultiline = False
        Me.ucrInputTextExpandpt.IsReadOnly = False
        Me.ucrInputTextExpandpt.Location = New System.Drawing.Point(285, 123)
        Me.ucrInputTextExpandpt.Name = "ucrInputTextExpandpt"
        Me.ucrInputTextExpandpt.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandpt.TabIndex = 166
        '
        'ucrInputPositionpt
        '
        Me.ucrInputPositionpt.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionpt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionpt.GetSetSelectedIndex = -1
        Me.ucrInputPositionpt.IsReadOnly = False
        Me.ucrInputPositionpt.Location = New System.Drawing.Point(285, 97)
        Me.ucrInputPositionpt.Name = "ucrInputPositionpt"
        Me.ucrInputPositionpt.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionpt.TabIndex = 165
        '
        'ucrInputDropUnusedLevelspt
        '
        Me.ucrInputDropUnusedLevelspt.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelspt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelspt.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelspt.IsReadOnly = False
        Me.ucrInputDropUnusedLevelspt.Location = New System.Drawing.Point(285, 17)
        Me.ucrInputDropUnusedLevelspt.Name = "ucrInputDropUnusedLevelspt"
        Me.ucrInputDropUnusedLevelspt.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelspt.TabIndex = 164
        '
        'ucrChkExpandpt
        '
        Me.ucrChkExpandpt.AutoSize = True
        Me.ucrChkExpandpt.Checked = False
        Me.ucrChkExpandpt.Location = New System.Drawing.Point(11, 123)
        Me.ucrChkExpandpt.Name = "ucrChkExpandpt"
        Me.ucrChkExpandpt.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandpt.TabIndex = 163
        '
        'ucrChkPositionpt
        '
        Me.ucrChkPositionpt.AutoSize = True
        Me.ucrChkPositionpt.Checked = False
        Me.ucrChkPositionpt.Location = New System.Drawing.Point(11, 98)
        Me.ucrChkPositionpt.Name = "ucrChkPositionpt"
        Me.ucrChkPositionpt.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionpt.TabIndex = 162
        '
        'ucrChkLimitpt
        '
        Me.ucrChkLimitpt.AutoSize = True
        Me.ucrChkLimitpt.Checked = False
        Me.ucrChkLimitpt.Location = New System.Drawing.Point(11, 71)
        Me.ucrChkLimitpt.Name = "ucrChkLimitpt"
        Me.ucrChkLimitpt.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitpt.TabIndex = 161
        '
        'ucrChkBreakspt
        '
        Me.ucrChkBreakspt.AutoSize = True
        Me.ucrChkBreakspt.Checked = False
        Me.ucrChkBreakspt.Location = New System.Drawing.Point(11, 46)
        Me.ucrChkBreakspt.Name = "ucrChkBreakspt"
        Me.ucrChkBreakspt.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreakspt.TabIndex = 160
        '
        'ucrChkNaValuept
        '
        Me.ucrChkNaValuept.AutoSize = True
        Me.ucrChkNaValuept.Checked = False
        Me.ucrChkNaValuept.Location = New System.Drawing.Point(10, 150)
        Me.ucrChkNaValuept.Name = "ucrChkNaValuept"
        Me.ucrChkNaValuept.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValuept.TabIndex = 159
        '
        'ucrChkDropUnusedLevelspt
        '
        Me.ucrChkDropUnusedLevelspt.AutoSize = True
        Me.ucrChkDropUnusedLevelspt.Checked = False
        Me.ucrChkDropUnusedLevelspt.Location = New System.Drawing.Point(11, 18)
        Me.ucrChkDropUnusedLevelspt.Name = "ucrChkDropUnusedLevelspt"
        Me.ucrChkDropUnusedLevelspt.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelspt.TabIndex = 158
        '
        'grpScalefillw
        '
        Me.grpScalefillw.Controls.Add(Me.ucrInputPalettefillw)
        Me.grpScalefillw.Controls.Add(Me.ucrChkpalettefillw)
        Me.grpScalefillw.Controls.Add(Me.ucrInputTextBreaksw)
        Me.grpScalefillw.Controls.Add(Me.ucrInputTextNaValuew)
        Me.grpScalefillw.Controls.Add(Me.ucrInputTextLimitw)
        Me.grpScalefillw.Controls.Add(Me.ucrInputTextExpandw)
        Me.grpScalefillw.Controls.Add(Me.ucrInputPositionw)
        Me.grpScalefillw.Controls.Add(Me.ucrInputDropUnusedLevelsw)
        Me.grpScalefillw.Controls.Add(Me.ucrChkExpandw)
        Me.grpScalefillw.Controls.Add(Me.ucrChkPositionw)
        Me.grpScalefillw.Controls.Add(Me.ucrChkLimitw)
        Me.grpScalefillw.Controls.Add(Me.ucrChkBreaksw)
        Me.grpScalefillw.Controls.Add(Me.ucrChkNaValuew)
        Me.grpScalefillw.Controls.Add(Me.ucrChkDropUnusedLevelsw)
        Me.grpScalefillw.Location = New System.Drawing.Point(13, 200)
        Me.grpScalefillw.Name = "grpScalefillw"
        Me.grpScalefillw.Size = New System.Drawing.Size(444, 176)
        Me.grpScalefillw.TabIndex = 242
        Me.grpScalefillw.TabStop = False
        Me.grpScalefillw.Text = "Fill Scale"
        '
        'ucrInputPalettefillw
        '
        Me.ucrInputPalettefillw.AddQuotesIfUnrecognised = True
        Me.ucrInputPalettefillw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPalettefillw.GetSetSelectedIndex = -1
        Me.ucrInputPalettefillw.IsReadOnly = False
        Me.ucrInputPalettefillw.Location = New System.Drawing.Point(284, 144)
        Me.ucrInputPalettefillw.Name = "ucrInputPalettefillw"
        Me.ucrInputPalettefillw.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPalettefillw.TabIndex = 185
        '
        'ucrChkpalettefillw
        '
        Me.ucrChkpalettefillw.AutoSize = True
        Me.ucrChkpalettefillw.Checked = False
        Me.ucrChkpalettefillw.Location = New System.Drawing.Point(12, 151)
        Me.ucrChkpalettefillw.Name = "ucrChkpalettefillw"
        Me.ucrChkpalettefillw.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkpalettefillw.TabIndex = 184
        '
        'ucrInputTextBreaksw
        '
        Me.ucrInputTextBreaksw.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksw.AutoSize = True
        Me.ucrInputTextBreaksw.IsMultiline = False
        Me.ucrInputTextBreaksw.IsReadOnly = False
        Me.ucrInputTextBreaksw.Location = New System.Drawing.Point(285, 32)
        Me.ucrInputTextBreaksw.Name = "ucrInputTextBreaksw"
        Me.ucrInputTextBreaksw.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksw.TabIndex = 183
        '
        'ucrInputTextNaValuew
        '
        Me.ucrInputTextNaValuew.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValuew.AutoSize = True
        Me.ucrInputTextNaValuew.IsMultiline = False
        Me.ucrInputTextNaValuew.IsReadOnly = False
        Me.ucrInputTextNaValuew.Location = New System.Drawing.Point(285, 122)
        Me.ucrInputTextNaValuew.Name = "ucrInputTextNaValuew"
        Me.ucrInputTextNaValuew.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValuew.TabIndex = 182
        '
        'ucrInputTextLimitw
        '
        Me.ucrInputTextLimitw.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitw.AutoSize = True
        Me.ucrInputTextLimitw.IsMultiline = False
        Me.ucrInputTextLimitw.IsReadOnly = False
        Me.ucrInputTextLimitw.Location = New System.Drawing.Point(285, 55)
        Me.ucrInputTextLimitw.Name = "ucrInputTextLimitw"
        Me.ucrInputTextLimitw.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitw.TabIndex = 181
        '
        'ucrInputTextExpandw
        '
        Me.ucrInputTextExpandw.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandw.AutoSize = True
        Me.ucrInputTextExpandw.IsMultiline = False
        Me.ucrInputTextExpandw.IsReadOnly = False
        Me.ucrInputTextExpandw.Location = New System.Drawing.Point(285, 99)
        Me.ucrInputTextExpandw.Name = "ucrInputTextExpandw"
        Me.ucrInputTextExpandw.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandw.TabIndex = 180
        '
        'ucrInputPositionw
        '
        Me.ucrInputPositionw.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionw.GetSetSelectedIndex = -1
        Me.ucrInputPositionw.IsReadOnly = False
        Me.ucrInputPositionw.Location = New System.Drawing.Point(285, 76)
        Me.ucrInputPositionw.Name = "ucrInputPositionw"
        Me.ucrInputPositionw.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionw.TabIndex = 179
        '
        'ucrInputDropUnusedLevelsw
        '
        Me.ucrInputDropUnusedLevelsw.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsw.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsw.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsw.Location = New System.Drawing.Point(285, 9)
        Me.ucrInputDropUnusedLevelsw.Name = "ucrInputDropUnusedLevelsw"
        Me.ucrInputDropUnusedLevelsw.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsw.TabIndex = 178
        '
        'ucrChkExpandw
        '
        Me.ucrChkExpandw.AutoSize = True
        Me.ucrChkExpandw.Checked = False
        Me.ucrChkExpandw.Location = New System.Drawing.Point(12, 104)
        Me.ucrChkExpandw.Name = "ucrChkExpandw"
        Me.ucrChkExpandw.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandw.TabIndex = 177
        '
        'ucrChkPositionw
        '
        Me.ucrChkPositionw.AutoSize = True
        Me.ucrChkPositionw.Checked = False
        Me.ucrChkPositionw.Location = New System.Drawing.Point(12, 82)
        Me.ucrChkPositionw.Name = "ucrChkPositionw"
        Me.ucrChkPositionw.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionw.TabIndex = 176
        '
        'ucrChkLimitw
        '
        Me.ucrChkLimitw.AutoSize = True
        Me.ucrChkLimitw.Checked = False
        Me.ucrChkLimitw.Location = New System.Drawing.Point(12, 60)
        Me.ucrChkLimitw.Name = "ucrChkLimitw"
        Me.ucrChkLimitw.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitw.TabIndex = 175
        '
        'ucrChkBreaksw
        '
        Me.ucrChkBreaksw.AutoSize = True
        Me.ucrChkBreaksw.Checked = False
        Me.ucrChkBreaksw.Location = New System.Drawing.Point(12, 38)
        Me.ucrChkBreaksw.Name = "ucrChkBreaksw"
        Me.ucrChkBreaksw.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksw.TabIndex = 174
        '
        'ucrChkNaValuew
        '
        Me.ucrChkNaValuew.AutoSize = True
        Me.ucrChkNaValuew.Checked = False
        Me.ucrChkNaValuew.Location = New System.Drawing.Point(12, 126)
        Me.ucrChkNaValuew.Name = "ucrChkNaValuew"
        Me.ucrChkNaValuew.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValuew.TabIndex = 173
        '
        'ucrChkDropUnusedLevelsw
        '
        Me.ucrChkDropUnusedLevelsw.AutoSize = True
        Me.ucrChkDropUnusedLevelsw.Checked = False
        Me.ucrChkDropUnusedLevelsw.Location = New System.Drawing.Point(12, 17)
        Me.ucrChkDropUnusedLevelsw.Name = "ucrChkDropUnusedLevelsw"
        Me.ucrChkDropUnusedLevelsw.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsw.TabIndex = 172
        '
        'grpScalefillst
        '
        Me.grpScalefillst.Controls.Add(Me.ucrInputSchemefill)
        Me.grpScalefillst.Controls.Add(Me.ucrChkSchemefill)
        Me.grpScalefillst.Controls.Add(Me.ucrInputTextBreaksst)
        Me.grpScalefillst.Controls.Add(Me.ucrInputTextNaValuest)
        Me.grpScalefillst.Controls.Add(Me.ucrInputTextLimitst)
        Me.grpScalefillst.Controls.Add(Me.ucrInputTextExpandst)
        Me.grpScalefillst.Controls.Add(Me.ucrInputPositionst)
        Me.grpScalefillst.Controls.Add(Me.ucrInputDropUnusedLevelsst)
        Me.grpScalefillst.Controls.Add(Me.ucrChkExpandst)
        Me.grpScalefillst.Controls.Add(Me.ucrChkPositionst)
        Me.grpScalefillst.Controls.Add(Me.ucrChkLimitst)
        Me.grpScalefillst.Controls.Add(Me.ucrChkBreaksst)
        Me.grpScalefillst.Controls.Add(Me.ucrChkNaValuest)
        Me.grpScalefillst.Controls.Add(Me.ucrChkDropUnusedLevelsst)
        Me.grpScalefillst.Location = New System.Drawing.Point(17, 197)
        Me.grpScalefillst.Name = "grpScalefillst"
        Me.grpScalefillst.Size = New System.Drawing.Size(444, 178)
        Me.grpScalefillst.TabIndex = 246
        Me.grpScalefillst.TabStop = False
        Me.grpScalefillst.Text = "Fill Scale"
        '
        'ucrInputSchemefill
        '
        Me.ucrInputSchemefill.AddQuotesIfUnrecognised = True
        Me.ucrInputSchemefill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSchemefill.GetSetSelectedIndex = -1
        Me.ucrInputSchemefill.IsReadOnly = False
        Me.ucrInputSchemefill.Location = New System.Drawing.Point(284, 148)
        Me.ucrInputSchemefill.Name = "ucrInputSchemefill"
        Me.ucrInputSchemefill.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSchemefill.TabIndex = 199
        '
        'ucrChkSchemefill
        '
        Me.ucrChkSchemefill.AutoSize = True
        Me.ucrChkSchemefill.Checked = False
        Me.ucrChkSchemefill.Location = New System.Drawing.Point(9, 153)
        Me.ucrChkSchemefill.Name = "ucrChkSchemefill"
        Me.ucrChkSchemefill.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkSchemefill.TabIndex = 198
        '
        'ucrInputTextBreaksst
        '
        Me.ucrInputTextBreaksst.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksst.AutoSize = True
        Me.ucrInputTextBreaksst.IsMultiline = False
        Me.ucrInputTextBreaksst.IsReadOnly = False
        Me.ucrInputTextBreaksst.Location = New System.Drawing.Point(285, 33)
        Me.ucrInputTextBreaksst.Name = "ucrInputTextBreaksst"
        Me.ucrInputTextBreaksst.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksst.TabIndex = 197
        '
        'ucrInputTextNaValuest
        '
        Me.ucrInputTextNaValuest.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValuest.AutoSize = True
        Me.ucrInputTextNaValuest.IsMultiline = False
        Me.ucrInputTextNaValuest.IsReadOnly = False
        Me.ucrInputTextNaValuest.Location = New System.Drawing.Point(285, 126)
        Me.ucrInputTextNaValuest.Name = "ucrInputTextNaValuest"
        Me.ucrInputTextNaValuest.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValuest.TabIndex = 196
        '
        'ucrInputTextLimitst
        '
        Me.ucrInputTextLimitst.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitst.AutoSize = True
        Me.ucrInputTextLimitst.IsMultiline = False
        Me.ucrInputTextLimitst.IsReadOnly = False
        Me.ucrInputTextLimitst.Location = New System.Drawing.Point(285, 56)
        Me.ucrInputTextLimitst.Name = "ucrInputTextLimitst"
        Me.ucrInputTextLimitst.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitst.TabIndex = 195
        '
        'ucrInputTextExpandst
        '
        Me.ucrInputTextExpandst.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandst.AutoSize = True
        Me.ucrInputTextExpandst.IsMultiline = False
        Me.ucrInputTextExpandst.IsReadOnly = False
        Me.ucrInputTextExpandst.Location = New System.Drawing.Point(285, 103)
        Me.ucrInputTextExpandst.Name = "ucrInputTextExpandst"
        Me.ucrInputTextExpandst.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandst.TabIndex = 194
        '
        'ucrInputPositionst
        '
        Me.ucrInputPositionst.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionst.GetSetSelectedIndex = -1
        Me.ucrInputPositionst.IsReadOnly = False
        Me.ucrInputPositionst.Location = New System.Drawing.Point(285, 79)
        Me.ucrInputPositionst.Name = "ucrInputPositionst"
        Me.ucrInputPositionst.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionst.TabIndex = 193
        '
        'ucrInputDropUnusedLevelsst
        '
        Me.ucrInputDropUnusedLevelsst.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsst.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsst.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsst.Location = New System.Drawing.Point(285, 9)
        Me.ucrInputDropUnusedLevelsst.Name = "ucrInputDropUnusedLevelsst"
        Me.ucrInputDropUnusedLevelsst.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsst.TabIndex = 192
        '
        'ucrChkExpandst
        '
        Me.ucrChkExpandst.AutoSize = True
        Me.ucrChkExpandst.Checked = False
        Me.ucrChkExpandst.Location = New System.Drawing.Point(9, 108)
        Me.ucrChkExpandst.Name = "ucrChkExpandst"
        Me.ucrChkExpandst.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandst.TabIndex = 191
        '
        'ucrChkPositionst
        '
        Me.ucrChkPositionst.AutoSize = True
        Me.ucrChkPositionst.Checked = False
        Me.ucrChkPositionst.Location = New System.Drawing.Point(9, 87)
        Me.ucrChkPositionst.Name = "ucrChkPositionst"
        Me.ucrChkPositionst.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionst.TabIndex = 190
        '
        'ucrChkLimitst
        '
        Me.ucrChkLimitst.AutoSize = True
        Me.ucrChkLimitst.Checked = False
        Me.ucrChkLimitst.Location = New System.Drawing.Point(9, 63)
        Me.ucrChkLimitst.Name = "ucrChkLimitst"
        Me.ucrChkLimitst.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitst.TabIndex = 189
        '
        'ucrChkBreaksst
        '
        Me.ucrChkBreaksst.AutoSize = True
        Me.ucrChkBreaksst.Checked = False
        Me.ucrChkBreaksst.Location = New System.Drawing.Point(9, 39)
        Me.ucrChkBreaksst.Name = "ucrChkBreaksst"
        Me.ucrChkBreaksst.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksst.TabIndex = 188
        '
        'ucrChkNaValuest
        '
        Me.ucrChkNaValuest.AutoSize = True
        Me.ucrChkNaValuest.Checked = False
        Me.ucrChkNaValuest.Location = New System.Drawing.Point(9, 132)
        Me.ucrChkNaValuest.Name = "ucrChkNaValuest"
        Me.ucrChkNaValuest.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValuest.TabIndex = 187
        '
        'ucrChkDropUnusedLevelsst
        '
        Me.ucrChkDropUnusedLevelsst.AutoSize = True
        Me.ucrChkDropUnusedLevelsst.Checked = False
        Me.ucrChkDropUnusedLevelsst.Location = New System.Drawing.Point(9, 18)
        Me.ucrChkDropUnusedLevelsst.Name = "ucrChkDropUnusedLevelsst"
        Me.ucrChkDropUnusedLevelsst.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsst.TabIndex = 186
        '
        'grpScalefillpan
        '
        Me.grpScalefillpan.Controls.Add(Me.ucrInputTextBreakspan)
        Me.grpScalefillpan.Controls.Add(Me.ucrInputTextNaValuepan)
        Me.grpScalefillpan.Controls.Add(Me.ucrInputTextLimitpan)
        Me.grpScalefillpan.Controls.Add(Me.ucrInputTextExpandpan)
        Me.grpScalefillpan.Controls.Add(Me.ucrInputPositionpan)
        Me.grpScalefillpan.Controls.Add(Me.ucrInputDropUnusedLevelspan)
        Me.grpScalefillpan.Controls.Add(Me.ucrChkExpandpan)
        Me.grpScalefillpan.Controls.Add(Me.ucrChkPositionpan)
        Me.grpScalefillpan.Controls.Add(Me.ucrChkLimitpan)
        Me.grpScalefillpan.Controls.Add(Me.ucrChkBreakspan)
        Me.grpScalefillpan.Controls.Add(Me.ucrChkNaValuepan)
        Me.grpScalefillpan.Controls.Add(Me.ucrChkDropUnusedLevelspan)
        Me.grpScalefillpan.Location = New System.Drawing.Point(17, 199)
        Me.grpScalefillpan.Name = "grpScalefillpan"
        Me.grpScalefillpan.Size = New System.Drawing.Size(444, 178)
        Me.grpScalefillpan.TabIndex = 249
        Me.grpScalefillpan.TabStop = False
        Me.grpScalefillpan.Text = "Fill Scale"
        '
        'ucrInputTextBreakspan
        '
        Me.ucrInputTextBreakspan.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreakspan.AutoSize = True
        Me.ucrInputTextBreakspan.IsMultiline = False
        Me.ucrInputTextBreakspan.IsReadOnly = False
        Me.ucrInputTextBreakspan.Location = New System.Drawing.Point(285, 38)
        Me.ucrInputTextBreakspan.Name = "ucrInputTextBreakspan"
        Me.ucrInputTextBreakspan.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreakspan.TabIndex = 157
        '
        'ucrInputTextNaValuepan
        '
        Me.ucrInputTextNaValuepan.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValuepan.AutoSize = True
        Me.ucrInputTextNaValuepan.IsMultiline = False
        Me.ucrInputTextNaValuepan.IsReadOnly = False
        Me.ucrInputTextNaValuepan.Location = New System.Drawing.Point(285, 144)
        Me.ucrInputTextNaValuepan.Name = "ucrInputTextNaValuepan"
        Me.ucrInputTextNaValuepan.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValuepan.TabIndex = 156
        '
        'ucrInputTextLimitpan
        '
        Me.ucrInputTextLimitpan.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitpan.AutoSize = True
        Me.ucrInputTextLimitpan.IsMultiline = False
        Me.ucrInputTextLimitpan.IsReadOnly = False
        Me.ucrInputTextLimitpan.Location = New System.Drawing.Point(285, 64)
        Me.ucrInputTextLimitpan.Name = "ucrInputTextLimitpan"
        Me.ucrInputTextLimitpan.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitpan.TabIndex = 155
        '
        'ucrInputTextExpandpan
        '
        Me.ucrInputTextExpandpan.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandpan.AutoSize = True
        Me.ucrInputTextExpandpan.IsMultiline = False
        Me.ucrInputTextExpandpan.IsReadOnly = False
        Me.ucrInputTextExpandpan.Location = New System.Drawing.Point(285, 119)
        Me.ucrInputTextExpandpan.Name = "ucrInputTextExpandpan"
        Me.ucrInputTextExpandpan.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandpan.TabIndex = 154
        '
        'ucrInputPositionpan
        '
        Me.ucrInputPositionpan.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionpan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionpan.GetSetSelectedIndex = -1
        Me.ucrInputPositionpan.IsReadOnly = False
        Me.ucrInputPositionpan.Location = New System.Drawing.Point(285, 90)
        Me.ucrInputPositionpan.Name = "ucrInputPositionpan"
        Me.ucrInputPositionpan.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionpan.TabIndex = 153
        '
        'ucrInputDropUnusedLevelspan
        '
        Me.ucrInputDropUnusedLevelspan.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelspan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelspan.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelspan.IsReadOnly = False
        Me.ucrInputDropUnusedLevelspan.Location = New System.Drawing.Point(285, 10)
        Me.ucrInputDropUnusedLevelspan.Name = "ucrInputDropUnusedLevelspan"
        Me.ucrInputDropUnusedLevelspan.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelspan.TabIndex = 152
        '
        'ucrChkExpandpan
        '
        Me.ucrChkExpandpan.AutoSize = True
        Me.ucrChkExpandpan.Checked = False
        Me.ucrChkExpandpan.Location = New System.Drawing.Point(11, 124)
        Me.ucrChkExpandpan.Name = "ucrChkExpandpan"
        Me.ucrChkExpandpan.Size = New System.Drawing.Size(238, 23)
        Me.ucrChkExpandpan.TabIndex = 151
        '
        'ucrChkPositionpan
        '
        Me.ucrChkPositionpan.AutoSize = True
        Me.ucrChkPositionpan.Checked = False
        Me.ucrChkPositionpan.Location = New System.Drawing.Point(11, 99)
        Me.ucrChkPositionpan.Name = "ucrChkPositionpan"
        Me.ucrChkPositionpan.Size = New System.Drawing.Size(238, 23)
        Me.ucrChkPositionpan.TabIndex = 150
        '
        'ucrChkLimitpan
        '
        Me.ucrChkLimitpan.AutoSize = True
        Me.ucrChkLimitpan.Checked = False
        Me.ucrChkLimitpan.Location = New System.Drawing.Point(11, 72)
        Me.ucrChkLimitpan.Name = "ucrChkLimitpan"
        Me.ucrChkLimitpan.Size = New System.Drawing.Size(238, 23)
        Me.ucrChkLimitpan.TabIndex = 149
        '
        'ucrChkBreakspan
        '
        Me.ucrChkBreakspan.AutoSize = True
        Me.ucrChkBreakspan.Checked = False
        Me.ucrChkBreakspan.Location = New System.Drawing.Point(11, 48)
        Me.ucrChkBreakspan.Name = "ucrChkBreakspan"
        Me.ucrChkBreakspan.Size = New System.Drawing.Size(238, 23)
        Me.ucrChkBreakspan.TabIndex = 148
        '
        'ucrChkNaValuepan
        '
        Me.ucrChkNaValuepan.AutoSize = True
        Me.ucrChkNaValuepan.Checked = False
        Me.ucrChkNaValuepan.Location = New System.Drawing.Point(11, 151)
        Me.ucrChkNaValuepan.Name = "ucrChkNaValuepan"
        Me.ucrChkNaValuepan.Size = New System.Drawing.Size(239, 23)
        Me.ucrChkNaValuepan.TabIndex = 147
        '
        'ucrChkDropUnusedLevelspan
        '
        Me.ucrChkDropUnusedLevelspan.AutoSize = True
        Me.ucrChkDropUnusedLevelspan.Checked = False
        Me.ucrChkDropUnusedLevelspan.Location = New System.Drawing.Point(11, 20)
        Me.ucrChkDropUnusedLevelspan.Name = "ucrChkDropUnusedLevelspan"
        Me.ucrChkDropUnusedLevelspan.Size = New System.Drawing.Size(238, 23)
        Me.ucrChkDropUnusedLevelspan.TabIndex = 146
        '
        'grpScalefillCal
        '
        Me.grpScalefillCal.Controls.Add(Me.ucrChkNaValueCal)
        Me.grpScalefillCal.Controls.Add(Me.ucrInputTextExpandCal)
        Me.grpScalefillCal.Controls.Add(Me.ucrInputPositionCal)
        Me.grpScalefillCal.Controls.Add(Me.ucrChkExpandCal)
        Me.grpScalefillCal.Controls.Add(Me.ucrChkPositionCal)
        Me.grpScalefillCal.Controls.Add(Me.ucrInputTextLimitCal)
        Me.grpScalefillCal.Controls.Add(Me.ucrInputDropUnusedLevelsCal)
        Me.grpScalefillCal.Controls.Add(Me.ucrChkDropUnusedLevelsCal)
        Me.grpScalefillCal.Controls.Add(Me.ucrChkBreaksCal)
        Me.grpScalefillCal.Controls.Add(Me.ucrChkLimitCal)
        Me.grpScalefillCal.Controls.Add(Me.ucrInputTextBreaksCal)
        Me.grpScalefillCal.Controls.Add(Me.ucrInputTextNaValueCal)
        Me.grpScalefillCal.Location = New System.Drawing.Point(16, 198)
        Me.grpScalefillCal.Name = "grpScalefillCal"
        Me.grpScalefillCal.Size = New System.Drawing.Size(444, 184)
        Me.grpScalefillCal.TabIndex = 248
        Me.grpScalefillCal.TabStop = False
        Me.grpScalefillCal.Text = "Fill Scale"
        '
        'ucrChkNaValueCal
        '
        Me.ucrChkNaValueCal.AutoSize = True
        Me.ucrChkNaValueCal.Checked = False
        Me.ucrChkNaValueCal.Location = New System.Drawing.Point(7, 153)
        Me.ucrChkNaValueCal.Name = "ucrChkNaValueCal"
        Me.ucrChkNaValueCal.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkNaValueCal.TabIndex = 34
        '
        'ucrInputTextExpandCal
        '
        Me.ucrInputTextExpandCal.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandCal.AutoSize = True
        Me.ucrInputTextExpandCal.IsMultiline = False
        Me.ucrInputTextExpandCal.IsReadOnly = False
        Me.ucrInputTextExpandCal.Location = New System.Drawing.Point(268, 126)
        Me.ucrInputTextExpandCal.Name = "ucrInputTextExpandCal"
        Me.ucrInputTextExpandCal.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandCal.TabIndex = 33
        '
        'ucrInputPositionCal
        '
        Me.ucrInputPositionCal.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionCal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionCal.GetSetSelectedIndex = -1
        Me.ucrInputPositionCal.IsReadOnly = False
        Me.ucrInputPositionCal.Location = New System.Drawing.Point(268, 99)
        Me.ucrInputPositionCal.Name = "ucrInputPositionCal"
        Me.ucrInputPositionCal.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputPositionCal.TabIndex = 32
        '
        'ucrChkExpandCal
        '
        Me.ucrChkExpandCal.AutoSize = True
        Me.ucrChkExpandCal.Checked = False
        Me.ucrChkExpandCal.Location = New System.Drawing.Point(7, 127)
        Me.ucrChkExpandCal.Name = "ucrChkExpandCal"
        Me.ucrChkExpandCal.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkExpandCal.TabIndex = 30
        '
        'ucrChkPositionCal
        '
        Me.ucrChkPositionCal.AutoSize = True
        Me.ucrChkPositionCal.Checked = False
        Me.ucrChkPositionCal.Location = New System.Drawing.Point(7, 100)
        Me.ucrChkPositionCal.Name = "ucrChkPositionCal"
        Me.ucrChkPositionCal.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkPositionCal.TabIndex = 31
        '
        'ucrInputTextLimitCal
        '
        Me.ucrInputTextLimitCal.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitCal.AutoSize = True
        Me.ucrInputTextLimitCal.IsMultiline = False
        Me.ucrInputTextLimitCal.IsReadOnly = False
        Me.ucrInputTextLimitCal.Location = New System.Drawing.Point(268, 71)
        Me.ucrInputTextLimitCal.Name = "ucrInputTextLimitCal"
        Me.ucrInputTextLimitCal.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitCal.TabIndex = 29
        '
        'ucrInputDropUnusedLevelsCal
        '
        Me.ucrInputDropUnusedLevelsCal.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsCal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsCal.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsCal.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsCal.Location = New System.Drawing.Point(268, 14)
        Me.ucrInputDropUnusedLevelsCal.Name = "ucrInputDropUnusedLevelsCal"
        Me.ucrInputDropUnusedLevelsCal.Size = New System.Drawing.Size(137, 24)
        Me.ucrInputDropUnusedLevelsCal.TabIndex = 11
        '
        'ucrChkDropUnusedLevelsCal
        '
        Me.ucrChkDropUnusedLevelsCal.AutoSize = True
        Me.ucrChkDropUnusedLevelsCal.Checked = False
        Me.ucrChkDropUnusedLevelsCal.Location = New System.Drawing.Point(7, 19)
        Me.ucrChkDropUnusedLevelsCal.Name = "ucrChkDropUnusedLevelsCal"
        Me.ucrChkDropUnusedLevelsCal.Size = New System.Drawing.Size(141, 23)
        Me.ucrChkDropUnusedLevelsCal.TabIndex = 10
        '
        'ucrChkBreaksCal
        '
        Me.ucrChkBreaksCal.AutoSize = True
        Me.ucrChkBreaksCal.Checked = False
        Me.ucrChkBreaksCal.Location = New System.Drawing.Point(7, 49)
        Me.ucrChkBreaksCal.Name = "ucrChkBreaksCal"
        Me.ucrChkBreaksCal.Size = New System.Drawing.Size(141, 23)
        Me.ucrChkBreaksCal.TabIndex = 1
        '
        'ucrChkLimitCal
        '
        Me.ucrChkLimitCal.AutoSize = True
        Me.ucrChkLimitCal.Checked = False
        Me.ucrChkLimitCal.Location = New System.Drawing.Point(7, 75)
        Me.ucrChkLimitCal.Name = "ucrChkLimitCal"
        Me.ucrChkLimitCal.Size = New System.Drawing.Size(138, 23)
        Me.ucrChkLimitCal.TabIndex = 2
        '
        'ucrInputTextBreaksCal
        '
        Me.ucrInputTextBreaksCal.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksCal.AutoSize = True
        Me.ucrInputTextBreaksCal.IsMultiline = False
        Me.ucrInputTextBreaksCal.IsReadOnly = False
        Me.ucrInputTextBreaksCal.Location = New System.Drawing.Point(268, 44)
        Me.ucrInputTextBreaksCal.Name = "ucrInputTextBreaksCal"
        Me.ucrInputTextBreaksCal.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksCal.TabIndex = 28
        '
        'ucrInputTextNaValueCal
        '
        Me.ucrInputTextNaValueCal.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueCal.AutoSize = True
        Me.ucrInputTextNaValueCal.IsMultiline = False
        Me.ucrInputTextNaValueCal.IsReadOnly = False
        Me.ucrInputTextNaValueCal.Location = New System.Drawing.Point(268, 153)
        Me.ucrInputTextNaValueCal.Name = "ucrInputTextNaValueCal"
        Me.ucrInputTextNaValueCal.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueCal.TabIndex = 35
        '
        'grpScalefillg
        '
        Me.grpScalefillg.Controls.Add(Me.ucrInputTextBreaksg)
        Me.grpScalefillg.Controls.Add(Me.ucrInputTextNaValueg)
        Me.grpScalefillg.Controls.Add(Me.ucrInputTextLimitg)
        Me.grpScalefillg.Controls.Add(Me.ucrInputTextExpandg)
        Me.grpScalefillg.Controls.Add(Me.ucrInputPositiong)
        Me.grpScalefillg.Controls.Add(Me.ucrInputDropUnusedLevelsg)
        Me.grpScalefillg.Controls.Add(Me.ucrChkExpandg)
        Me.grpScalefillg.Controls.Add(Me.ucrChkPositiong)
        Me.grpScalefillg.Controls.Add(Me.ucrChkLimitg)
        Me.grpScalefillg.Controls.Add(Me.ucrChkBreaksg)
        Me.grpScalefillg.Controls.Add(Me.ucrChkNaValueg)
        Me.grpScalefillg.Controls.Add(Me.ucrChkDropUnusedLevelsg)
        Me.grpScalefillg.Location = New System.Drawing.Point(16, 198)
        Me.grpScalefillg.Name = "grpScalefillg"
        Me.grpScalefillg.Size = New System.Drawing.Size(444, 184)
        Me.grpScalefillg.TabIndex = 247
        Me.grpScalefillg.TabStop = False
        Me.grpScalefillg.Text = "Fill Scale"
        '
        'ucrInputTextBreaksg
        '
        Me.ucrInputTextBreaksg.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksg.AutoSize = True
        Me.ucrInputTextBreaksg.IsMultiline = False
        Me.ucrInputTextBreaksg.IsReadOnly = False
        Me.ucrInputTextBreaksg.Location = New System.Drawing.Point(285, 41)
        Me.ucrInputTextBreaksg.Name = "ucrInputTextBreaksg"
        Me.ucrInputTextBreaksg.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksg.TabIndex = 121
        '
        'ucrInputTextNaValueg
        '
        Me.ucrInputTextNaValueg.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueg.AutoSize = True
        Me.ucrInputTextNaValueg.IsMultiline = False
        Me.ucrInputTextNaValueg.IsReadOnly = False
        Me.ucrInputTextNaValueg.Location = New System.Drawing.Point(285, 146)
        Me.ucrInputTextNaValueg.Name = "ucrInputTextNaValueg"
        Me.ucrInputTextNaValueg.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueg.TabIndex = 120
        '
        'ucrInputTextLimitg
        '
        Me.ucrInputTextLimitg.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitg.AutoSize = True
        Me.ucrInputTextLimitg.IsMultiline = False
        Me.ucrInputTextLimitg.IsReadOnly = False
        Me.ucrInputTextLimitg.Location = New System.Drawing.Point(285, 67)
        Me.ucrInputTextLimitg.Name = "ucrInputTextLimitg"
        Me.ucrInputTextLimitg.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitg.TabIndex = 119
        '
        'ucrInputTextExpandg
        '
        Me.ucrInputTextExpandg.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandg.AutoSize = True
        Me.ucrInputTextExpandg.IsMultiline = False
        Me.ucrInputTextExpandg.IsReadOnly = False
        Me.ucrInputTextExpandg.Location = New System.Drawing.Point(285, 120)
        Me.ucrInputTextExpandg.Name = "ucrInputTextExpandg"
        Me.ucrInputTextExpandg.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandg.TabIndex = 118
        '
        'ucrInputPositiong
        '
        Me.ucrInputPositiong.AddQuotesIfUnrecognised = True
        Me.ucrInputPositiong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositiong.GetSetSelectedIndex = -1
        Me.ucrInputPositiong.IsReadOnly = False
        Me.ucrInputPositiong.Location = New System.Drawing.Point(285, 92)
        Me.ucrInputPositiong.Name = "ucrInputPositiong"
        Me.ucrInputPositiong.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositiong.TabIndex = 117
        '
        'ucrInputDropUnusedLevelsg
        '
        Me.ucrInputDropUnusedLevelsg.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsg.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsg.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsg.Location = New System.Drawing.Point(285, 13)
        Me.ucrInputDropUnusedLevelsg.Name = "ucrInputDropUnusedLevelsg"
        Me.ucrInputDropUnusedLevelsg.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsg.TabIndex = 116
        '
        'ucrChkExpandg
        '
        Me.ucrChkExpandg.AutoSize = True
        Me.ucrChkExpandg.Checked = False
        Me.ucrChkExpandg.Location = New System.Drawing.Point(8, 123)
        Me.ucrChkExpandg.Name = "ucrChkExpandg"
        Me.ucrChkExpandg.Size = New System.Drawing.Size(214, 23)
        Me.ucrChkExpandg.TabIndex = 115
        '
        'ucrChkPositiong
        '
        Me.ucrChkPositiong.AutoSize = True
        Me.ucrChkPositiong.Checked = False
        Me.ucrChkPositiong.Location = New System.Drawing.Point(8, 96)
        Me.ucrChkPositiong.Name = "ucrChkPositiong"
        Me.ucrChkPositiong.Size = New System.Drawing.Size(233, 23)
        Me.ucrChkPositiong.TabIndex = 114
        '
        'ucrChkLimitg
        '
        Me.ucrChkLimitg.AutoSize = True
        Me.ucrChkLimitg.Checked = False
        Me.ucrChkLimitg.Location = New System.Drawing.Point(8, 71)
        Me.ucrChkLimitg.Name = "ucrChkLimitg"
        Me.ucrChkLimitg.Size = New System.Drawing.Size(246, 23)
        Me.ucrChkLimitg.TabIndex = 113
        '
        'ucrChkBreaksg
        '
        Me.ucrChkBreaksg.AutoSize = True
        Me.ucrChkBreaksg.Checked = False
        Me.ucrChkBreaksg.Location = New System.Drawing.Point(8, 45)
        Me.ucrChkBreaksg.Name = "ucrChkBreaksg"
        Me.ucrChkBreaksg.Size = New System.Drawing.Size(233, 23)
        Me.ucrChkBreaksg.TabIndex = 112
        '
        'ucrChkNaValueg
        '
        Me.ucrChkNaValueg.AutoSize = True
        Me.ucrChkNaValueg.Checked = False
        Me.ucrChkNaValueg.Location = New System.Drawing.Point(7, 149)
        Me.ucrChkNaValueg.Name = "ucrChkNaValueg"
        Me.ucrChkNaValueg.Size = New System.Drawing.Size(233, 23)
        Me.ucrChkNaValueg.TabIndex = 111
        '
        'ucrChkDropUnusedLevelsg
        '
        Me.ucrChkDropUnusedLevelsg.AutoSize = True
        Me.ucrChkDropUnusedLevelsg.Checked = False
        Me.ucrChkDropUnusedLevelsg.Location = New System.Drawing.Point(8, 20)
        Me.ucrChkDropUnusedLevelsg.Name = "ucrChkDropUnusedLevelsg"
        Me.ucrChkDropUnusedLevelsg.Size = New System.Drawing.Size(246, 23)
        Me.ucrChkDropUnusedLevelsg.TabIndex = 110
        '
        'grpScalefillEx
        '
        Me.grpScalefillEx.Controls.Add(Me.ucrInputTextBreaksEx)
        Me.grpScalefillEx.Controls.Add(Me.ucrInputTextNaValueEx)
        Me.grpScalefillEx.Controls.Add(Me.ucrInputTextLimitEx)
        Me.grpScalefillEx.Controls.Add(Me.ucrInputTextExpandEx)
        Me.grpScalefillEx.Controls.Add(Me.ucrInputPositionEx)
        Me.grpScalefillEx.Controls.Add(Me.ucrInputDropUnusedLevelsEx)
        Me.grpScalefillEx.Controls.Add(Me.ucrChkExpandEx)
        Me.grpScalefillEx.Controls.Add(Me.ucrChkPositionEx)
        Me.grpScalefillEx.Controls.Add(Me.ucrChkLimitEx)
        Me.grpScalefillEx.Controls.Add(Me.ucrChkBreaksEx)
        Me.grpScalefillEx.Controls.Add(Me.ucrChkNaValueEx)
        Me.grpScalefillEx.Controls.Add(Me.ucrChkDropUnusedLevelsEx)
        Me.grpScalefillEx.Location = New System.Drawing.Point(16, 199)
        Me.grpScalefillEx.Name = "grpScalefillEx"
        Me.grpScalefillEx.Size = New System.Drawing.Size(444, 184)
        Me.grpScalefillEx.TabIndex = 245
        Me.grpScalefillEx.TabStop = False
        Me.grpScalefillEx.Text = "Fill Scale"
        '
        'ucrInputTextBreaksEx
        '
        Me.ucrInputTextBreaksEx.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksEx.AutoSize = True
        Me.ucrInputTextBreaksEx.IsMultiline = False
        Me.ucrInputTextBreaksEx.IsReadOnly = False
        Me.ucrInputTextBreaksEx.Location = New System.Drawing.Point(285, 39)
        Me.ucrInputTextBreaksEx.Name = "ucrInputTextBreaksEx"
        Me.ucrInputTextBreaksEx.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksEx.TabIndex = 85
        '
        'ucrInputTextNaValueEx
        '
        Me.ucrInputTextNaValueEx.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueEx.AutoSize = True
        Me.ucrInputTextNaValueEx.IsMultiline = False
        Me.ucrInputTextNaValueEx.IsReadOnly = False
        Me.ucrInputTextNaValueEx.Location = New System.Drawing.Point(285, 150)
        Me.ucrInputTextNaValueEx.Name = "ucrInputTextNaValueEx"
        Me.ucrInputTextNaValueEx.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueEx.TabIndex = 84
        '
        'ucrInputTextLimitEx
        '
        Me.ucrInputTextLimitEx.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitEx.AutoSize = True
        Me.ucrInputTextLimitEx.IsMultiline = False
        Me.ucrInputTextLimitEx.IsReadOnly = False
        Me.ucrInputTextLimitEx.Location = New System.Drawing.Point(285, 67)
        Me.ucrInputTextLimitEx.Name = "ucrInputTextLimitEx"
        Me.ucrInputTextLimitEx.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitEx.TabIndex = 83
        '
        'ucrInputTextExpandEx
        '
        Me.ucrInputTextExpandEx.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandEx.AutoSize = True
        Me.ucrInputTextExpandEx.IsMultiline = False
        Me.ucrInputTextExpandEx.IsReadOnly = False
        Me.ucrInputTextExpandEx.Location = New System.Drawing.Point(285, 123)
        Me.ucrInputTextExpandEx.Name = "ucrInputTextExpandEx"
        Me.ucrInputTextExpandEx.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandEx.TabIndex = 82
        '
        'ucrInputPositionEx
        '
        Me.ucrInputPositionEx.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionEx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionEx.GetSetSelectedIndex = -1
        Me.ucrInputPositionEx.IsReadOnly = False
        Me.ucrInputPositionEx.Location = New System.Drawing.Point(285, 96)
        Me.ucrInputPositionEx.Name = "ucrInputPositionEx"
        Me.ucrInputPositionEx.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionEx.TabIndex = 81
        '
        'ucrInputDropUnusedLevelsEx
        '
        Me.ucrInputDropUnusedLevelsEx.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsEx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsEx.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsEx.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsEx.Location = New System.Drawing.Point(285, 11)
        Me.ucrInputDropUnusedLevelsEx.Name = "ucrInputDropUnusedLevelsEx"
        Me.ucrInputDropUnusedLevelsEx.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsEx.TabIndex = 80
        '
        'ucrChkExpandEx
        '
        Me.ucrChkExpandEx.AutoSize = True
        Me.ucrChkExpandEx.Checked = False
        Me.ucrChkExpandEx.Location = New System.Drawing.Point(8, 129)
        Me.ucrChkExpandEx.Name = "ucrChkExpandEx"
        Me.ucrChkExpandEx.Size = New System.Drawing.Size(256, 23)
        Me.ucrChkExpandEx.TabIndex = 79
        '
        'ucrChkPositionEx
        '
        Me.ucrChkPositionEx.AutoSize = True
        Me.ucrChkPositionEx.Checked = False
        Me.ucrChkPositionEx.Location = New System.Drawing.Point(8, 104)
        Me.ucrChkPositionEx.Name = "ucrChkPositionEx"
        Me.ucrChkPositionEx.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkPositionEx.TabIndex = 78
        '
        'ucrChkLimitEx
        '
        Me.ucrChkLimitEx.AutoSize = True
        Me.ucrChkLimitEx.Checked = False
        Me.ucrChkLimitEx.Location = New System.Drawing.Point(8, 74)
        Me.ucrChkLimitEx.Name = "ucrChkLimitEx"
        Me.ucrChkLimitEx.Size = New System.Drawing.Size(256, 23)
        Me.ucrChkLimitEx.TabIndex = 77
        '
        'ucrChkBreaksEx
        '
        Me.ucrChkBreaksEx.AutoSize = True
        Me.ucrChkBreaksEx.Checked = False
        Me.ucrChkBreaksEx.Location = New System.Drawing.Point(8, 47)
        Me.ucrChkBreaksEx.Name = "ucrChkBreaksEx"
        Me.ucrChkBreaksEx.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkBreaksEx.TabIndex = 76
        '
        'ucrChkNaValueEx
        '
        Me.ucrChkNaValueEx.AutoSize = True
        Me.ucrChkNaValueEx.Checked = False
        Me.ucrChkNaValueEx.Location = New System.Drawing.Point(7, 157)
        Me.ucrChkNaValueEx.Name = "ucrChkNaValueEx"
        Me.ucrChkNaValueEx.Size = New System.Drawing.Size(257, 23)
        Me.ucrChkNaValueEx.TabIndex = 75
        '
        'ucrChkDropUnusedLevelsEx
        '
        Me.ucrChkDropUnusedLevelsEx.AutoSize = True
        Me.ucrChkDropUnusedLevelsEx.Checked = False
        Me.ucrChkDropUnusedLevelsEx.Location = New System.Drawing.Point(8, 20)
        Me.ucrChkDropUnusedLevelsEx.Name = "ucrChkDropUnusedLevelsEx"
        Me.ucrChkDropUnusedLevelsEx.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkDropUnusedLevelsEx.TabIndex = 74
        '
        'grpScalefillEcon
        '
        Me.grpScalefillEcon.Controls.Add(Me.ucrInputTextBreaksEcon)
        Me.grpScalefillEcon.Controls.Add(Me.ucrInputTextNaValueEcon)
        Me.grpScalefillEcon.Controls.Add(Me.ucrInputTextLimitEcon)
        Me.grpScalefillEcon.Controls.Add(Me.ucrInputTextExpandEcon)
        Me.grpScalefillEcon.Controls.Add(Me.ucrInputPositionEcon)
        Me.grpScalefillEcon.Controls.Add(Me.ucrInputDropUnusedLevelsEcon)
        Me.grpScalefillEcon.Controls.Add(Me.ucrChkExpandEcon)
        Me.grpScalefillEcon.Controls.Add(Me.ucrChkPositionEcon)
        Me.grpScalefillEcon.Controls.Add(Me.ucrChkLimitEcon)
        Me.grpScalefillEcon.Controls.Add(Me.ucrChkBreaksEcon)
        Me.grpScalefillEcon.Controls.Add(Me.ucrChkNaValueEcon)
        Me.grpScalefillEcon.Controls.Add(Me.ucrChkDropUnusedLevelsEcon)
        Me.grpScalefillEcon.Location = New System.Drawing.Point(17, 198)
        Me.grpScalefillEcon.Name = "grpScalefillEcon"
        Me.grpScalefillEcon.Size = New System.Drawing.Size(444, 184)
        Me.grpScalefillEcon.TabIndex = 244
        Me.grpScalefillEcon.TabStop = False
        Me.grpScalefillEcon.Text = "Fill Scale"
        '
        'ucrInputTextBreaksEcon
        '
        Me.ucrInputTextBreaksEcon.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksEcon.AutoSize = True
        Me.ucrInputTextBreaksEcon.IsMultiline = False
        Me.ucrInputTextBreaksEcon.IsReadOnly = False
        Me.ucrInputTextBreaksEcon.Location = New System.Drawing.Point(285, 40)
        Me.ucrInputTextBreaksEcon.Name = "ucrInputTextBreaksEcon"
        Me.ucrInputTextBreaksEcon.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksEcon.TabIndex = 73
        '
        'ucrInputTextNaValueEcon
        '
        Me.ucrInputTextNaValueEcon.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueEcon.AutoSize = True
        Me.ucrInputTextNaValueEcon.IsMultiline = False
        Me.ucrInputTextNaValueEcon.IsReadOnly = False
        Me.ucrInputTextNaValueEcon.Location = New System.Drawing.Point(285, 149)
        Me.ucrInputTextNaValueEcon.Name = "ucrInputTextNaValueEcon"
        Me.ucrInputTextNaValueEcon.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueEcon.TabIndex = 72
        '
        'ucrInputTextLimitEcon
        '
        Me.ucrInputTextLimitEcon.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitEcon.AutoSize = True
        Me.ucrInputTextLimitEcon.IsMultiline = False
        Me.ucrInputTextLimitEcon.IsReadOnly = False
        Me.ucrInputTextLimitEcon.Location = New System.Drawing.Point(285, 67)
        Me.ucrInputTextLimitEcon.Name = "ucrInputTextLimitEcon"
        Me.ucrInputTextLimitEcon.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitEcon.TabIndex = 71
        '
        'ucrInputTextExpandEcon
        '
        Me.ucrInputTextExpandEcon.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandEcon.AutoSize = True
        Me.ucrInputTextExpandEcon.IsMultiline = False
        Me.ucrInputTextExpandEcon.IsReadOnly = False
        Me.ucrInputTextExpandEcon.Location = New System.Drawing.Point(285, 123)
        Me.ucrInputTextExpandEcon.Name = "ucrInputTextExpandEcon"
        Me.ucrInputTextExpandEcon.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandEcon.TabIndex = 70
        '
        'ucrInputPositionEcon
        '
        Me.ucrInputPositionEcon.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionEcon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionEcon.GetSetSelectedIndex = -1
        Me.ucrInputPositionEcon.IsReadOnly = False
        Me.ucrInputPositionEcon.Location = New System.Drawing.Point(285, 95)
        Me.ucrInputPositionEcon.Name = "ucrInputPositionEcon"
        Me.ucrInputPositionEcon.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionEcon.TabIndex = 69
        '
        'ucrInputDropUnusedLevelsEcon
        '
        Me.ucrInputDropUnusedLevelsEcon.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsEcon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsEcon.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsEcon.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsEcon.Location = New System.Drawing.Point(285, 12)
        Me.ucrInputDropUnusedLevelsEcon.Name = "ucrInputDropUnusedLevelsEcon"
        Me.ucrInputDropUnusedLevelsEcon.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsEcon.TabIndex = 68
        '
        'ucrChkExpandEcon
        '
        Me.ucrChkExpandEcon.AutoSize = True
        Me.ucrChkExpandEcon.Checked = False
        Me.ucrChkExpandEcon.Location = New System.Drawing.Point(10, 132)
        Me.ucrChkExpandEcon.Name = "ucrChkExpandEcon"
        Me.ucrChkExpandEcon.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkExpandEcon.TabIndex = 67
        '
        'ucrChkPositionEcon
        '
        Me.ucrChkPositionEcon.AutoSize = True
        Me.ucrChkPositionEcon.Checked = False
        Me.ucrChkPositionEcon.Location = New System.Drawing.Point(10, 105)
        Me.ucrChkPositionEcon.Name = "ucrChkPositionEcon"
        Me.ucrChkPositionEcon.Size = New System.Drawing.Size(256, 23)
        Me.ucrChkPositionEcon.TabIndex = 66
        '
        'ucrChkLimitEcon
        '
        Me.ucrChkLimitEcon.AutoSize = True
        Me.ucrChkLimitEcon.Checked = False
        Me.ucrChkLimitEcon.Location = New System.Drawing.Point(10, 78)
        Me.ucrChkLimitEcon.Name = "ucrChkLimitEcon"
        Me.ucrChkLimitEcon.Size = New System.Drawing.Size(256, 23)
        Me.ucrChkLimitEcon.TabIndex = 65
        '
        'ucrChkBreaksEcon
        '
        Me.ucrChkBreaksEcon.AutoSize = True
        Me.ucrChkBreaksEcon.Checked = False
        Me.ucrChkBreaksEcon.Location = New System.Drawing.Point(10, 51)
        Me.ucrChkBreaksEcon.Name = "ucrChkBreaksEcon"
        Me.ucrChkBreaksEcon.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkBreaksEcon.TabIndex = 64
        '
        'ucrChkNaValueEcon
        '
        Me.ucrChkNaValueEcon.AutoSize = True
        Me.ucrChkNaValueEcon.Checked = False
        Me.ucrChkNaValueEcon.Location = New System.Drawing.Point(10, 158)
        Me.ucrChkNaValueEcon.Name = "ucrChkNaValueEcon"
        Me.ucrChkNaValueEcon.Size = New System.Drawing.Size(257, 23)
        Me.ucrChkNaValueEcon.TabIndex = 63
        '
        'ucrChkDropUnusedLevelsEcon
        '
        Me.ucrChkDropUnusedLevelsEcon.AutoSize = True
        Me.ucrChkDropUnusedLevelsEcon.Checked = False
        Me.ucrChkDropUnusedLevelsEcon.Location = New System.Drawing.Point(10, 23)
        Me.ucrChkDropUnusedLevelsEcon.Name = "ucrChkDropUnusedLevelsEcon"
        Me.ucrChkDropUnusedLevelsEcon.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkDropUnusedLevelsEcon.TabIndex = 62
        '
        'grpScalefillExn
        '
        Me.grpScalefillExn.Controls.Add(Me.ucrInputThemeFill)
        Me.grpScalefillExn.Controls.Add(Me.ucrChkThemeFill)
        Me.grpScalefillExn.Controls.Add(Me.ucrInputTextBreaksExn)
        Me.grpScalefillExn.Controls.Add(Me.ucrInputTextNaValueExn)
        Me.grpScalefillExn.Controls.Add(Me.ucrInputTextLimitExn)
        Me.grpScalefillExn.Controls.Add(Me.ucrInputTextExpandExn)
        Me.grpScalefillExn.Controls.Add(Me.ucrInputPositionExn)
        Me.grpScalefillExn.Controls.Add(Me.ucrInputDropUnusedLevelsExn)
        Me.grpScalefillExn.Controls.Add(Me.ucrChkExpandExn)
        Me.grpScalefillExn.Controls.Add(Me.ucrChkPositionExn)
        Me.grpScalefillExn.Controls.Add(Me.ucrChkLimitExn)
        Me.grpScalefillExn.Controls.Add(Me.ucrChkBreaksExn)
        Me.grpScalefillExn.Controls.Add(Me.ucrChkNaValueExn)
        Me.grpScalefillExn.Controls.Add(Me.ucrChkDropUnusedLevelsExn)
        Me.grpScalefillExn.Location = New System.Drawing.Point(17, 198)
        Me.grpScalefillExn.Name = "grpScalefillExn"
        Me.grpScalefillExn.Size = New System.Drawing.Size(444, 184)
        Me.grpScalefillExn.TabIndex = 243
        Me.grpScalefillExn.TabStop = False
        Me.grpScalefillExn.Text = "Fill Scale"
        '
        'ucrInputThemeFill
        '
        Me.ucrInputThemeFill.AddQuotesIfUnrecognised = True
        Me.ucrInputThemeFill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputThemeFill.GetSetSelectedIndex = -1
        Me.ucrInputThemeFill.IsReadOnly = False
        Me.ucrInputThemeFill.Location = New System.Drawing.Point(285, 153)
        Me.ucrInputThemeFill.Name = "ucrInputThemeFill"
        Me.ucrInputThemeFill.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputThemeFill.TabIndex = 101
        '
        'ucrChkThemeFill
        '
        Me.ucrChkThemeFill.AutoSize = True
        Me.ucrChkThemeFill.Checked = False
        Me.ucrChkThemeFill.Location = New System.Drawing.Point(10, 161)
        Me.ucrChkThemeFill.Name = "ucrChkThemeFill"
        Me.ucrChkThemeFill.Size = New System.Drawing.Size(256, 23)
        Me.ucrChkThemeFill.TabIndex = 100
        '
        'ucrInputTextBreaksExn
        '
        Me.ucrInputTextBreaksExn.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksExn.AutoSize = True
        Me.ucrInputTextBreaksExn.IsMultiline = False
        Me.ucrInputTextBreaksExn.IsReadOnly = False
        Me.ucrInputTextBreaksExn.Location = New System.Drawing.Point(285, 35)
        Me.ucrInputTextBreaksExn.Name = "ucrInputTextBreaksExn"
        Me.ucrInputTextBreaksExn.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksExn.TabIndex = 99
        '
        'ucrInputTextNaValueExn
        '
        Me.ucrInputTextNaValueExn.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueExn.AutoSize = True
        Me.ucrInputTextNaValueExn.IsMultiline = False
        Me.ucrInputTextNaValueExn.IsReadOnly = False
        Me.ucrInputTextNaValueExn.Location = New System.Drawing.Point(285, 129)
        Me.ucrInputTextNaValueExn.Name = "ucrInputTextNaValueExn"
        Me.ucrInputTextNaValueExn.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueExn.TabIndex = 98
        '
        'ucrInputTextLimitExn
        '
        Me.ucrInputTextLimitExn.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitExn.AutoSize = True
        Me.ucrInputTextLimitExn.IsMultiline = False
        Me.ucrInputTextLimitExn.IsReadOnly = False
        Me.ucrInputTextLimitExn.Location = New System.Drawing.Point(285, 58)
        Me.ucrInputTextLimitExn.Name = "ucrInputTextLimitExn"
        Me.ucrInputTextLimitExn.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitExn.TabIndex = 97
        '
        'ucrInputTextExpandExn
        '
        Me.ucrInputTextExpandExn.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandExn.AutoSize = True
        Me.ucrInputTextExpandExn.IsMultiline = False
        Me.ucrInputTextExpandExn.IsReadOnly = False
        Me.ucrInputTextExpandExn.Location = New System.Drawing.Point(285, 105)
        Me.ucrInputTextExpandExn.Name = "ucrInputTextExpandExn"
        Me.ucrInputTextExpandExn.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandExn.TabIndex = 96
        '
        'ucrInputPositionExn
        '
        Me.ucrInputPositionExn.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionExn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionExn.GetSetSelectedIndex = -1
        Me.ucrInputPositionExn.IsReadOnly = False
        Me.ucrInputPositionExn.Location = New System.Drawing.Point(285, 81)
        Me.ucrInputPositionExn.Name = "ucrInputPositionExn"
        Me.ucrInputPositionExn.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionExn.TabIndex = 95
        '
        'ucrInputDropUnusedLevelsExn
        '
        Me.ucrInputDropUnusedLevelsExn.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsExn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsExn.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsExn.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsExn.Location = New System.Drawing.Point(285, 10)
        Me.ucrInputDropUnusedLevelsExn.Name = "ucrInputDropUnusedLevelsExn"
        Me.ucrInputDropUnusedLevelsExn.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsExn.TabIndex = 94
        '
        'ucrChkExpandExn
        '
        Me.ucrChkExpandExn.AutoSize = True
        Me.ucrChkExpandExn.Checked = False
        Me.ucrChkExpandExn.Location = New System.Drawing.Point(10, 114)
        Me.ucrChkExpandExn.Name = "ucrChkExpandExn"
        Me.ucrChkExpandExn.Size = New System.Drawing.Size(251, 24)
        Me.ucrChkExpandExn.TabIndex = 93
        '
        'ucrChkPositionExn
        '
        Me.ucrChkPositionExn.AutoSize = True
        Me.ucrChkPositionExn.Checked = False
        Me.ucrChkPositionExn.Location = New System.Drawing.Point(10, 91)
        Me.ucrChkPositionExn.Name = "ucrChkPositionExn"
        Me.ucrChkPositionExn.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkPositionExn.TabIndex = 92
        '
        'ucrChkLimitExn
        '
        Me.ucrChkLimitExn.AutoSize = True
        Me.ucrChkLimitExn.Checked = False
        Me.ucrChkLimitExn.Location = New System.Drawing.Point(10, 68)
        Me.ucrChkLimitExn.Name = "ucrChkLimitExn"
        Me.ucrChkLimitExn.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkLimitExn.TabIndex = 91
        '
        'ucrChkBreaksExn
        '
        Me.ucrChkBreaksExn.AutoSize = True
        Me.ucrChkBreaksExn.Checked = False
        Me.ucrChkBreaksExn.Location = New System.Drawing.Point(10, 46)
        Me.ucrChkBreaksExn.Name = "ucrChkBreaksExn"
        Me.ucrChkBreaksExn.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkBreaksExn.TabIndex = 90
        '
        'ucrChkNaValueExn
        '
        Me.ucrChkNaValueExn.AutoSize = True
        Me.ucrChkNaValueExn.Checked = False
        Me.ucrChkNaValueExn.Location = New System.Drawing.Point(10, 138)
        Me.ucrChkNaValueExn.Name = "ucrChkNaValueExn"
        Me.ucrChkNaValueExn.Size = New System.Drawing.Size(257, 23)
        Me.ucrChkNaValueExn.TabIndex = 89
        '
        'ucrChkDropUnusedLevelsExn
        '
        Me.ucrChkDropUnusedLevelsExn.AutoSize = True
        Me.ucrChkDropUnusedLevelsExn.Checked = False
        Me.ucrChkDropUnusedLevelsExn.Location = New System.Drawing.Point(10, 21)
        Me.ucrChkDropUnusedLevelsExn.Name = "ucrChkDropUnusedLevelsExn"
        Me.ucrChkDropUnusedLevelsExn.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkDropUnusedLevelsExn.TabIndex = 88
        '
        'grpScalefillsol
        '
        Me.grpScalefillsol.Controls.Add(Me.ucrInputTextBreakssol)
        Me.grpScalefillsol.Controls.Add(Me.ucrInputTextNaValuesol)
        Me.grpScalefillsol.Controls.Add(Me.ucrInputTextLimitsol)
        Me.grpScalefillsol.Controls.Add(Me.ucrInputTextExpandsol)
        Me.grpScalefillsol.Controls.Add(Me.ucrInputPositionsol)
        Me.grpScalefillsol.Controls.Add(Me.ucrInputDropUnusedLevelssol)
        Me.grpScalefillsol.Controls.Add(Me.ucrChkExpandsol)
        Me.grpScalefillsol.Controls.Add(Me.ucrChkPositionsol)
        Me.grpScalefillsol.Controls.Add(Me.ucrChkLimitsol)
        Me.grpScalefillsol.Controls.Add(Me.ucrChkBreakssol)
        Me.grpScalefillsol.Controls.Add(Me.ucrChkNaValuesol)
        Me.grpScalefillsol.Controls.Add(Me.ucrChkDropUnusedLevelssol)
        Me.grpScalefillsol.Location = New System.Drawing.Point(16, 196)
        Me.grpScalefillsol.Name = "grpScalefillsol"
        Me.grpScalefillsol.Size = New System.Drawing.Size(444, 184)
        Me.grpScalefillsol.TabIndex = 241
        Me.grpScalefillsol.TabStop = False
        Me.grpScalefillsol.Text = "Fill Scale"
        '
        'ucrInputTextBreakssol
        '
        Me.ucrInputTextBreakssol.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreakssol.AutoSize = True
        Me.ucrInputTextBreakssol.IsMultiline = False
        Me.ucrInputTextBreakssol.IsReadOnly = False
        Me.ucrInputTextBreakssol.Location = New System.Drawing.Point(285, 42)
        Me.ucrInputTextBreakssol.Name = "ucrInputTextBreakssol"
        Me.ucrInputTextBreakssol.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreakssol.TabIndex = 169
        '
        'ucrInputTextNaValuesol
        '
        Me.ucrInputTextNaValuesol.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValuesol.AutoSize = True
        Me.ucrInputTextNaValuesol.IsMultiline = False
        Me.ucrInputTextNaValuesol.IsReadOnly = False
        Me.ucrInputTextNaValuesol.Location = New System.Drawing.Point(285, 146)
        Me.ucrInputTextNaValuesol.Name = "ucrInputTextNaValuesol"
        Me.ucrInputTextNaValuesol.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValuesol.TabIndex = 168
        '
        'ucrInputTextLimitsol
        '
        Me.ucrInputTextLimitsol.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitsol.AutoSize = True
        Me.ucrInputTextLimitsol.IsMultiline = False
        Me.ucrInputTextLimitsol.IsReadOnly = False
        Me.ucrInputTextLimitsol.Location = New System.Drawing.Point(285, 68)
        Me.ucrInputTextLimitsol.Name = "ucrInputTextLimitsol"
        Me.ucrInputTextLimitsol.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitsol.TabIndex = 167
        '
        'ucrInputTextExpandsol
        '
        Me.ucrInputTextExpandsol.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandsol.AutoSize = True
        Me.ucrInputTextExpandsol.IsMultiline = False
        Me.ucrInputTextExpandsol.IsReadOnly = False
        Me.ucrInputTextExpandsol.Location = New System.Drawing.Point(285, 119)
        Me.ucrInputTextExpandsol.Name = "ucrInputTextExpandsol"
        Me.ucrInputTextExpandsol.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandsol.TabIndex = 166
        '
        'ucrInputPositionsol
        '
        Me.ucrInputPositionsol.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionsol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionsol.GetSetSelectedIndex = -1
        Me.ucrInputPositionsol.IsReadOnly = False
        Me.ucrInputPositionsol.Location = New System.Drawing.Point(285, 92)
        Me.ucrInputPositionsol.Name = "ucrInputPositionsol"
        Me.ucrInputPositionsol.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionsol.TabIndex = 165
        '
        'ucrInputDropUnusedLevelssol
        '
        Me.ucrInputDropUnusedLevelssol.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelssol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelssol.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelssol.IsReadOnly = False
        Me.ucrInputDropUnusedLevelssol.Location = New System.Drawing.Point(285, 16)
        Me.ucrInputDropUnusedLevelssol.Name = "ucrInputDropUnusedLevelssol"
        Me.ucrInputDropUnusedLevelssol.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelssol.TabIndex = 164
        '
        'ucrChkExpandsol
        '
        Me.ucrChkExpandsol.AutoSize = True
        Me.ucrChkExpandsol.Checked = False
        Me.ucrChkExpandsol.Location = New System.Drawing.Point(10, 123)
        Me.ucrChkExpandsol.Name = "ucrChkExpandsol"
        Me.ucrChkExpandsol.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandsol.TabIndex = 163
        '
        'ucrChkPositionsol
        '
        Me.ucrChkPositionsol.AutoSize = True
        Me.ucrChkPositionsol.Checked = False
        Me.ucrChkPositionsol.Location = New System.Drawing.Point(10, 97)
        Me.ucrChkPositionsol.Name = "ucrChkPositionsol"
        Me.ucrChkPositionsol.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionsol.TabIndex = 162
        '
        'ucrChkLimitsol
        '
        Me.ucrChkLimitsol.AutoSize = True
        Me.ucrChkLimitsol.Checked = False
        Me.ucrChkLimitsol.Location = New System.Drawing.Point(10, 71)
        Me.ucrChkLimitsol.Name = "ucrChkLimitsol"
        Me.ucrChkLimitsol.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitsol.TabIndex = 161
        '
        'ucrChkBreakssol
        '
        Me.ucrChkBreakssol.AutoSize = True
        Me.ucrChkBreakssol.Checked = False
        Me.ucrChkBreakssol.Location = New System.Drawing.Point(10, 45)
        Me.ucrChkBreakssol.Name = "ucrChkBreakssol"
        Me.ucrChkBreakssol.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreakssol.TabIndex = 160
        '
        'ucrChkNaValuesol
        '
        Me.ucrChkNaValuesol.AutoSize = True
        Me.ucrChkNaValuesol.Checked = False
        Me.ucrChkNaValuesol.Location = New System.Drawing.Point(9, 150)
        Me.ucrChkNaValuesol.Name = "ucrChkNaValuesol"
        Me.ucrChkNaValuesol.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValuesol.TabIndex = 159
        '
        'ucrChkDropUnusedLevelssol
        '
        Me.ucrChkDropUnusedLevelssol.AutoSize = True
        Me.ucrChkDropUnusedLevelssol.Checked = False
        Me.ucrChkDropUnusedLevelssol.Location = New System.Drawing.Point(10, 22)
        Me.ucrChkDropUnusedLevelssol.Name = "ucrChkDropUnusedLevelssol"
        Me.ucrChkDropUnusedLevelssol.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelssol.TabIndex = 158
        '
        'grpFillScaleggthemes
        '
        Me.grpFillScaleggthemes.Controls.Add(Me.ucrInputTextBreaks)
        Me.grpFillScaleggthemes.Controls.Add(Me.ucrInputTextNaValue)
        Me.grpFillScaleggthemes.Controls.Add(Me.ucrInputTextLimit)
        Me.grpFillScaleggthemes.Controls.Add(Me.ucrInputTextExpand)
        Me.grpFillScaleggthemes.Controls.Add(Me.ucrInputPosition)
        Me.grpFillScaleggthemes.Controls.Add(Me.ucrInputDropUnusedLevels)
        Me.grpFillScaleggthemes.Controls.Add(Me.ucrChkExpand)
        Me.grpFillScaleggthemes.Controls.Add(Me.ucrChkPosition)
        Me.grpFillScaleggthemes.Controls.Add(Me.ucrChkLimit)
        Me.grpFillScaleggthemes.Controls.Add(Me.ucrChkBreaks)
        Me.grpFillScaleggthemes.Controls.Add(Me.ucrChkNaValue)
        Me.grpFillScaleggthemes.Controls.Add(Me.ucrChkDropUnusedLevels)
        Me.grpFillScaleggthemes.Location = New System.Drawing.Point(16, 194)
        Me.grpFillScaleggthemes.Name = "grpFillScaleggthemes"
        Me.grpFillScaleggthemes.Size = New System.Drawing.Size(444, 184)
        Me.grpFillScaleggthemes.TabIndex = 238
        Me.grpFillScaleggthemes.TabStop = False
        Me.grpFillScaleggthemes.Text = "Fill Scale"
        '
        'ucrInputTextBreaks
        '
        Me.ucrInputTextBreaks.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaks.AutoSize = True
        Me.ucrInputTextBreaks.IsMultiline = False
        Me.ucrInputTextBreaks.IsReadOnly = False
        Me.ucrInputTextBreaks.Location = New System.Drawing.Point(269, 43)
        Me.ucrInputTextBreaks.Name = "ucrInputTextBreaks"
        Me.ucrInputTextBreaks.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaks.TabIndex = 49
        '
        'ucrInputTextNaValue
        '
        Me.ucrInputTextNaValue.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValue.AutoSize = True
        Me.ucrInputTextNaValue.IsMultiline = False
        Me.ucrInputTextNaValue.IsReadOnly = False
        Me.ucrInputTextNaValue.Location = New System.Drawing.Point(269, 151)
        Me.ucrInputTextNaValue.Name = "ucrInputTextNaValue"
        Me.ucrInputTextNaValue.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValue.TabIndex = 48
        '
        'ucrInputTextLimit
        '
        Me.ucrInputTextLimit.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimit.AutoSize = True
        Me.ucrInputTextLimit.IsMultiline = False
        Me.ucrInputTextLimit.IsReadOnly = False
        Me.ucrInputTextLimit.Location = New System.Drawing.Point(269, 70)
        Me.ucrInputTextLimit.Name = "ucrInputTextLimit"
        Me.ucrInputTextLimit.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimit.TabIndex = 47
        '
        'ucrInputTextExpand
        '
        Me.ucrInputTextExpand.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpand.AutoSize = True
        Me.ucrInputTextExpand.IsMultiline = False
        Me.ucrInputTextExpand.IsReadOnly = False
        Me.ucrInputTextExpand.Location = New System.Drawing.Point(269, 125)
        Me.ucrInputTextExpand.Name = "ucrInputTextExpand"
        Me.ucrInputTextExpand.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpand.TabIndex = 46
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        Me.ucrInputPosition.Location = New System.Drawing.Point(269, 98)
        Me.ucrInputPosition.Name = "ucrInputPosition"
        Me.ucrInputPosition.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPosition.TabIndex = 45
        '
        'ucrInputDropUnusedLevels
        '
        Me.ucrInputDropUnusedLevels.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevels.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevels.IsReadOnly = False
        Me.ucrInputDropUnusedLevels.Location = New System.Drawing.Point(269, 16)
        Me.ucrInputDropUnusedLevels.Name = "ucrInputDropUnusedLevels"
        Me.ucrInputDropUnusedLevels.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevels.TabIndex = 44
        '
        'ucrChkExpand
        '
        Me.ucrChkExpand.AutoSize = True
        Me.ucrChkExpand.Checked = False
        Me.ucrChkExpand.Location = New System.Drawing.Point(7, 125)
        Me.ucrChkExpand.Name = "ucrChkExpand"
        Me.ucrChkExpand.Size = New System.Drawing.Size(241, 23)
        Me.ucrChkExpand.TabIndex = 5
        '
        'ucrChkPosition
        '
        Me.ucrChkPosition.AutoSize = True
        Me.ucrChkPosition.Checked = False
        Me.ucrChkPosition.Location = New System.Drawing.Point(7, 98)
        Me.ucrChkPosition.Name = "ucrChkPosition"
        Me.ucrChkPosition.Size = New System.Drawing.Size(241, 23)
        Me.ucrChkPosition.TabIndex = 4
        '
        'ucrChkLimit
        '
        Me.ucrChkLimit.AutoSize = True
        Me.ucrChkLimit.Checked = False
        Me.ucrChkLimit.Location = New System.Drawing.Point(7, 70)
        Me.ucrChkLimit.Name = "ucrChkLimit"
        Me.ucrChkLimit.Size = New System.Drawing.Size(243, 23)
        Me.ucrChkLimit.TabIndex = 3
        '
        'ucrChkBreaks
        '
        Me.ucrChkBreaks.AutoSize = True
        Me.ucrChkBreaks.Checked = False
        Me.ucrChkBreaks.Location = New System.Drawing.Point(7, 43)
        Me.ucrChkBreaks.Name = "ucrChkBreaks"
        Me.ucrChkBreaks.Size = New System.Drawing.Size(243, 23)
        Me.ucrChkBreaks.TabIndex = 2
        '
        'ucrChkNaValue
        '
        Me.ucrChkNaValue.AutoSize = True
        Me.ucrChkNaValue.Checked = False
        Me.ucrChkNaValue.Location = New System.Drawing.Point(6, 156)
        Me.ucrChkNaValue.Name = "ucrChkNaValue"
        Me.ucrChkNaValue.Size = New System.Drawing.Size(242, 23)
        Me.ucrChkNaValue.TabIndex = 1
        '
        'ucrChkDropUnusedLevels
        '
        Me.ucrChkDropUnusedLevels.AutoSize = True
        Me.ucrChkDropUnusedLevels.Checked = False
        Me.ucrChkDropUnusedLevels.Location = New System.Drawing.Point(7, 17)
        Me.ucrChkDropUnusedLevels.Name = "ucrChkDropUnusedLevels"
        Me.ucrChkDropUnusedLevels.Size = New System.Drawing.Size(243, 23)
        Me.ucrChkDropUnusedLevels.TabIndex = 0
        '
        'grpScalefillfew
        '
        Me.grpScalefillfew.Controls.Add(Me.ucrChkPalettefill)
        Me.grpScalefillfew.Controls.Add(Me.ucrInputPalettefill)
        Me.grpScalefillfew.Controls.Add(Me.ucrInputTextBreaksfew)
        Me.grpScalefillfew.Controls.Add(Me.ucrInputTextNaValuefew)
        Me.grpScalefillfew.Controls.Add(Me.ucrInputTextLimitfew)
        Me.grpScalefillfew.Controls.Add(Me.ucrInputTextExpandfew)
        Me.grpScalefillfew.Controls.Add(Me.ucrInputPositionfew)
        Me.grpScalefillfew.Controls.Add(Me.ucrInputDropUnusedLevelsfew)
        Me.grpScalefillfew.Controls.Add(Me.ucrChkExpandfew)
        Me.grpScalefillfew.Controls.Add(Me.ucrChkPositionfew)
        Me.grpScalefillfew.Controls.Add(Me.ucrChkLimitfew)
        Me.grpScalefillfew.Controls.Add(Me.ucrChkBreaksfew)
        Me.grpScalefillfew.Controls.Add(Me.ucrChkNaValuefew)
        Me.grpScalefillfew.Controls.Add(Me.ucrChkDropUnusedLevelsfew)
        Me.grpScalefillfew.Location = New System.Drawing.Point(15, 194)
        Me.grpScalefillfew.Name = "grpScalefillfew"
        Me.grpScalefillfew.Size = New System.Drawing.Size(444, 184)
        Me.grpScalefillfew.TabIndex = 239
        Me.grpScalefillfew.TabStop = False
        Me.grpScalefillfew.Text = "Fill Scale"
        '
        'ucrChkPalettefill
        '
        Me.ucrChkPalettefill.AutoSize = True
        Me.ucrChkPalettefill.Checked = False
        Me.ucrChkPalettefill.Location = New System.Drawing.Point(10, 157)
        Me.ucrChkPalettefill.Name = "ucrChkPalettefill"
        Me.ucrChkPalettefill.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkPalettefill.TabIndex = 99
        '
        'ucrInputPalettefill
        '
        Me.ucrInputPalettefill.AddQuotesIfUnrecognised = True
        Me.ucrInputPalettefill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPalettefill.GetSetSelectedIndex = -1
        Me.ucrInputPalettefill.IsReadOnly = False
        Me.ucrInputPalettefill.Location = New System.Drawing.Point(285, 155)
        Me.ucrInputPalettefill.Name = "ucrInputPalettefill"
        Me.ucrInputPalettefill.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPalettefill.TabIndex = 98
        '
        'ucrInputTextBreaksfew
        '
        Me.ucrInputTextBreaksfew.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksfew.AutoSize = True
        Me.ucrInputTextBreaksfew.IsMultiline = False
        Me.ucrInputTextBreaksfew.IsReadOnly = False
        Me.ucrInputTextBreaksfew.Location = New System.Drawing.Point(285, 39)
        Me.ucrInputTextBreaksfew.Name = "ucrInputTextBreaksfew"
        Me.ucrInputTextBreaksfew.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksfew.TabIndex = 97
        '
        'ucrInputTextNaValuefew
        '
        Me.ucrInputTextNaValuefew.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValuefew.AutoSize = True
        Me.ucrInputTextNaValuefew.IsMultiline = False
        Me.ucrInputTextNaValuefew.IsReadOnly = False
        Me.ucrInputTextNaValuefew.Location = New System.Drawing.Point(285, 131)
        Me.ucrInputTextNaValuefew.Name = "ucrInputTextNaValuefew"
        Me.ucrInputTextNaValuefew.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValuefew.TabIndex = 96
        '
        'ucrInputTextLimitfew
        '
        Me.ucrInputTextLimitfew.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitfew.AutoSize = True
        Me.ucrInputTextLimitfew.IsMultiline = False
        Me.ucrInputTextLimitfew.IsReadOnly = False
        Me.ucrInputTextLimitfew.Location = New System.Drawing.Point(285, 61)
        Me.ucrInputTextLimitfew.Name = "ucrInputTextLimitfew"
        Me.ucrInputTextLimitfew.Size = New System.Drawing.Size(137, 24)
        Me.ucrInputTextLimitfew.TabIndex = 95
        '
        'ucrInputTextExpandfew
        '
        Me.ucrInputTextExpandfew.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandfew.AutoSize = True
        Me.ucrInputTextExpandfew.IsMultiline = False
        Me.ucrInputTextExpandfew.IsReadOnly = False
        Me.ucrInputTextExpandfew.Location = New System.Drawing.Point(285, 108)
        Me.ucrInputTextExpandfew.Name = "ucrInputTextExpandfew"
        Me.ucrInputTextExpandfew.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandfew.TabIndex = 94
        '
        'ucrInputPositionfew
        '
        Me.ucrInputPositionfew.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionfew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionfew.GetSetSelectedIndex = -1
        Me.ucrInputPositionfew.IsReadOnly = False
        Me.ucrInputPositionfew.Location = New System.Drawing.Point(285, 85)
        Me.ucrInputPositionfew.Name = "ucrInputPositionfew"
        Me.ucrInputPositionfew.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionfew.TabIndex = 93
        '
        'ucrInputDropUnusedLevelsfew
        '
        Me.ucrInputDropUnusedLevelsfew.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsfew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsfew.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsfew.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsfew.Location = New System.Drawing.Point(285, 15)
        Me.ucrInputDropUnusedLevelsfew.Name = "ucrInputDropUnusedLevelsfew"
        Me.ucrInputDropUnusedLevelsfew.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsfew.TabIndex = 92
        '
        'ucrChkExpandfew
        '
        Me.ucrChkExpandfew.AutoSize = True
        Me.ucrChkExpandfew.Checked = False
        Me.ucrChkExpandfew.Location = New System.Drawing.Point(10, 111)
        Me.ucrChkExpandfew.Name = "ucrChkExpandfew"
        Me.ucrChkExpandfew.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkExpandfew.TabIndex = 91
        '
        'ucrChkPositionfew
        '
        Me.ucrChkPositionfew.AutoSize = True
        Me.ucrChkPositionfew.Checked = False
        Me.ucrChkPositionfew.Location = New System.Drawing.Point(10, 88)
        Me.ucrChkPositionfew.Name = "ucrChkPositionfew"
        Me.ucrChkPositionfew.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkPositionfew.TabIndex = 90
        '
        'ucrChkLimitfew
        '
        Me.ucrChkLimitfew.AutoSize = True
        Me.ucrChkLimitfew.Checked = False
        Me.ucrChkLimitfew.Location = New System.Drawing.Point(10, 65)
        Me.ucrChkLimitfew.Name = "ucrChkLimitfew"
        Me.ucrChkLimitfew.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkLimitfew.TabIndex = 89
        '
        'ucrChkBreaksfew
        '
        Me.ucrChkBreaksfew.AutoSize = True
        Me.ucrChkBreaksfew.Checked = False
        Me.ucrChkBreaksfew.Location = New System.Drawing.Point(10, 42)
        Me.ucrChkBreaksfew.Name = "ucrChkBreaksfew"
        Me.ucrChkBreaksfew.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkBreaksfew.TabIndex = 88
        '
        'ucrChkNaValuefew
        '
        Me.ucrChkNaValuefew.AutoSize = True
        Me.ucrChkNaValuefew.Checked = False
        Me.ucrChkNaValuefew.Location = New System.Drawing.Point(10, 134)
        Me.ucrChkNaValuefew.Name = "ucrChkNaValuefew"
        Me.ucrChkNaValuefew.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkNaValuefew.TabIndex = 87
        '
        'ucrChkDropUnusedLevelsfew
        '
        Me.ucrChkDropUnusedLevelsfew.AutoSize = True
        Me.ucrChkDropUnusedLevelsfew.Checked = False
        Me.ucrChkDropUnusedLevelsfew.Location = New System.Drawing.Point(10, 19)
        Me.ucrChkDropUnusedLevelsfew.Name = "ucrChkDropUnusedLevelsfew"
        Me.ucrChkDropUnusedLevelsfew.Size = New System.Drawing.Size(251, 23)
        Me.ucrChkDropUnusedLevelsfew.TabIndex = 86
        '
        'grpScalefillhc
        '
        Me.grpScalefillhc.Controls.Add(Me.ucrInputPalettehc)
        Me.grpScalefillhc.Controls.Add(Me.ucrChkPalettehc)
        Me.grpScalefillhc.Controls.Add(Me.ucrInputTextBreakshc)
        Me.grpScalefillhc.Controls.Add(Me.ucrInputTextNaValuehc)
        Me.grpScalefillhc.Controls.Add(Me.ucrInputTextLimithc)
        Me.grpScalefillhc.Controls.Add(Me.ucrInputTextExpandhc)
        Me.grpScalefillhc.Controls.Add(Me.ucrInputPositionhc)
        Me.grpScalefillhc.Controls.Add(Me.ucrInputDropUnusedLevelshc)
        Me.grpScalefillhc.Controls.Add(Me.ucrChkExpandhc)
        Me.grpScalefillhc.Controls.Add(Me.ucrChkPositionhc)
        Me.grpScalefillhc.Controls.Add(Me.ucrChkLimithc)
        Me.grpScalefillhc.Controls.Add(Me.ucrChkBreakshc)
        Me.grpScalefillhc.Controls.Add(Me.ucrChkNaValuehc)
        Me.grpScalefillhc.Controls.Add(Me.ucrChkDropUnusedLevelshc)
        Me.grpScalefillhc.Location = New System.Drawing.Point(13, 202)
        Me.grpScalefillhc.Name = "grpScalefillhc"
        Me.grpScalefillhc.Size = New System.Drawing.Size(444, 184)
        Me.grpScalefillhc.TabIndex = 232
        Me.grpScalefillhc.TabStop = False
        Me.grpScalefillhc.Text = "Fill Scale"
        '
        'ucrInputPalettehc
        '
        Me.ucrInputPalettehc.AddQuotesIfUnrecognised = True
        Me.ucrInputPalettehc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPalettehc.GetSetSelectedIndex = -1
        Me.ucrInputPalettehc.IsReadOnly = False
        Me.ucrInputPalettehc.Location = New System.Drawing.Point(285, 155)
        Me.ucrInputPalettehc.Name = "ucrInputPalettehc"
        Me.ucrInputPalettehc.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPalettehc.TabIndex = 149
        '
        'ucrChkPalettehc
        '
        Me.ucrChkPalettehc.AutoSize = True
        Me.ucrChkPalettehc.Checked = False
        Me.ucrChkPalettehc.Location = New System.Drawing.Point(9, 163)
        Me.ucrChkPalettehc.Name = "ucrChkPalettehc"
        Me.ucrChkPalettehc.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkPalettehc.TabIndex = 148
        '
        'ucrInputTextBreakshc
        '
        Me.ucrInputTextBreakshc.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreakshc.AutoSize = True
        Me.ucrInputTextBreakshc.IsMultiline = False
        Me.ucrInputTextBreakshc.IsReadOnly = False
        Me.ucrInputTextBreakshc.Location = New System.Drawing.Point(285, 36)
        Me.ucrInputTextBreakshc.Name = "ucrInputTextBreakshc"
        Me.ucrInputTextBreakshc.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreakshc.TabIndex = 147
        '
        'ucrInputTextNaValuehc
        '
        Me.ucrInputTextNaValuehc.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValuehc.AutoSize = True
        Me.ucrInputTextNaValuehc.IsMultiline = False
        Me.ucrInputTextNaValuehc.IsReadOnly = False
        Me.ucrInputTextNaValuehc.Location = New System.Drawing.Point(285, 132)
        Me.ucrInputTextNaValuehc.Name = "ucrInputTextNaValuehc"
        Me.ucrInputTextNaValuehc.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValuehc.TabIndex = 146
        '
        'ucrInputTextLimithc
        '
        Me.ucrInputTextLimithc.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimithc.AutoSize = True
        Me.ucrInputTextLimithc.IsMultiline = False
        Me.ucrInputTextLimithc.IsReadOnly = False
        Me.ucrInputTextLimithc.Location = New System.Drawing.Point(285, 60)
        Me.ucrInputTextLimithc.Name = "ucrInputTextLimithc"
        Me.ucrInputTextLimithc.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimithc.TabIndex = 145
        '
        'ucrInputTextExpandhc
        '
        Me.ucrInputTextExpandhc.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandhc.AutoSize = True
        Me.ucrInputTextExpandhc.IsMultiline = False
        Me.ucrInputTextExpandhc.IsReadOnly = False
        Me.ucrInputTextExpandhc.Location = New System.Drawing.Point(285, 109)
        Me.ucrInputTextExpandhc.Name = "ucrInputTextExpandhc"
        Me.ucrInputTextExpandhc.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandhc.TabIndex = 144
        '
        'ucrInputPositionhc
        '
        Me.ucrInputPositionhc.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionhc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionhc.GetSetSelectedIndex = -1
        Me.ucrInputPositionhc.IsReadOnly = False
        Me.ucrInputPositionhc.Location = New System.Drawing.Point(285, 84)
        Me.ucrInputPositionhc.Name = "ucrInputPositionhc"
        Me.ucrInputPositionhc.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionhc.TabIndex = 143
        '
        'ucrInputDropUnusedLevelshc
        '
        Me.ucrInputDropUnusedLevelshc.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelshc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelshc.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelshc.IsReadOnly = False
        Me.ucrInputDropUnusedLevelshc.Location = New System.Drawing.Point(285, 12)
        Me.ucrInputDropUnusedLevelshc.Name = "ucrInputDropUnusedLevelshc"
        Me.ucrInputDropUnusedLevelshc.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelshc.TabIndex = 142
        '
        'ucrChkExpandhc
        '
        Me.ucrChkExpandhc.AutoSize = True
        Me.ucrChkExpandhc.Checked = False
        Me.ucrChkExpandhc.Location = New System.Drawing.Point(10, 116)
        Me.ucrChkExpandhc.Name = "ucrChkExpandhc"
        Me.ucrChkExpandhc.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandhc.TabIndex = 141
        '
        'ucrChkPositionhc
        '
        Me.ucrChkPositionhc.AutoSize = True
        Me.ucrChkPositionhc.Checked = False
        Me.ucrChkPositionhc.Location = New System.Drawing.Point(10, 91)
        Me.ucrChkPositionhc.Name = "ucrChkPositionhc"
        Me.ucrChkPositionhc.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionhc.TabIndex = 140
        '
        'ucrChkLimithc
        '
        Me.ucrChkLimithc.AutoSize = True
        Me.ucrChkLimithc.Checked = False
        Me.ucrChkLimithc.Location = New System.Drawing.Point(10, 67)
        Me.ucrChkLimithc.Name = "ucrChkLimithc"
        Me.ucrChkLimithc.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimithc.TabIndex = 139
        '
        'ucrChkBreakshc
        '
        Me.ucrChkBreakshc.AutoSize = True
        Me.ucrChkBreakshc.Checked = False
        Me.ucrChkBreakshc.Location = New System.Drawing.Point(10, 45)
        Me.ucrChkBreakshc.Name = "ucrChkBreakshc"
        Me.ucrChkBreakshc.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreakshc.TabIndex = 138
        '
        'ucrChkNaValuehc
        '
        Me.ucrChkNaValuehc.AutoSize = True
        Me.ucrChkNaValuehc.Checked = False
        Me.ucrChkNaValuehc.Location = New System.Drawing.Point(9, 139)
        Me.ucrChkNaValuehc.Name = "ucrChkNaValuehc"
        Me.ucrChkNaValuehc.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValuehc.TabIndex = 137
        '
        'ucrChkDropUnusedLevelshc
        '
        Me.ucrChkDropUnusedLevelshc.AutoSize = True
        Me.ucrChkDropUnusedLevelshc.Checked = False
        Me.ucrChkDropUnusedLevelshc.Location = New System.Drawing.Point(10, 21)
        Me.ucrChkDropUnusedLevelshc.Name = "ucrChkDropUnusedLevelshc"
        Me.ucrChkDropUnusedLevelshc.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelshc.TabIndex = 136
        '
        'grpScaleColorw
        '
        Me.grpScaleColorw.Controls.Add(Me.ucrInputPalettecolorw)
        Me.grpScaleColorw.Controls.Add(Me.ucrChkPalettecolorw)
        Me.grpScaleColorw.Controls.Add(Me.ucrInputTextBreaksColorw)
        Me.grpScaleColorw.Controls.Add(Me.ucrInputTextNaValueColorw)
        Me.grpScaleColorw.Controls.Add(Me.ucrInputTextLimitColorw)
        Me.grpScaleColorw.Controls.Add(Me.ucrInputTextExpandColorw)
        Me.grpScaleColorw.Controls.Add(Me.ucrInputPositionColorw)
        Me.grpScaleColorw.Controls.Add(Me.ucrInputDropUnusedLevelsColorw)
        Me.grpScaleColorw.Controls.Add(Me.ucrChkExpandColorw)
        Me.grpScaleColorw.Controls.Add(Me.ucrChkPositionColorw)
        Me.grpScaleColorw.Controls.Add(Me.ucrChkLimitColorw)
        Me.grpScaleColorw.Controls.Add(Me.ucrChkBreaksColorw)
        Me.grpScaleColorw.Controls.Add(Me.ucrChkNaValueColorw)
        Me.grpScaleColorw.Controls.Add(Me.ucrChkDropUnusedLevelsColorw)
        Me.grpScaleColorw.Location = New System.Drawing.Point(13, 459)
        Me.grpScaleColorw.Name = "grpScaleColorw"
        Me.grpScaleColorw.Size = New System.Drawing.Size(447, 175)
        Me.grpScaleColorw.TabIndex = 233
        Me.grpScaleColorw.TabStop = False
        Me.grpScaleColorw.Text = "Colour Scale"
        '
        'ucrInputPalettecolorw
        '
        Me.ucrInputPalettecolorw.AddQuotesIfUnrecognised = True
        Me.ucrInputPalettecolorw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPalettecolorw.GetSetSelectedIndex = -1
        Me.ucrInputPalettecolorw.IsReadOnly = False
        Me.ucrInputPalettecolorw.Location = New System.Drawing.Point(285, 149)
        Me.ucrInputPalettecolorw.Name = "ucrInputPalettecolorw"
        Me.ucrInputPalettecolorw.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPalettecolorw.TabIndex = 199
        '
        'ucrChkPalettecolorw
        '
        Me.ucrChkPalettecolorw.AutoSize = True
        Me.ucrChkPalettecolorw.Checked = False
        Me.ucrChkPalettecolorw.Location = New System.Drawing.Point(7, 152)
        Me.ucrChkPalettecolorw.Name = "ucrChkPalettecolorw"
        Me.ucrChkPalettecolorw.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPalettecolorw.TabIndex = 198
        '
        'ucrInputTextBreaksColorw
        '
        Me.ucrInputTextBreaksColorw.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBreaksColorw.AutoSize = True
        Me.ucrInputTextBreaksColorw.IsMultiline = False
        Me.ucrInputTextBreaksColorw.IsReadOnly = False
        Me.ucrInputTextBreaksColorw.Location = New System.Drawing.Point(286, 34)
        Me.ucrInputTextBreaksColorw.Name = "ucrInputTextBreaksColorw"
        Me.ucrInputTextBreaksColorw.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextBreaksColorw.TabIndex = 197
        '
        'ucrInputTextNaValueColorw
        '
        Me.ucrInputTextNaValueColorw.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNaValueColorw.AutoSize = True
        Me.ucrInputTextNaValueColorw.IsMultiline = False
        Me.ucrInputTextNaValueColorw.IsReadOnly = False
        Me.ucrInputTextNaValueColorw.Location = New System.Drawing.Point(286, 127)
        Me.ucrInputTextNaValueColorw.Name = "ucrInputTextNaValueColorw"
        Me.ucrInputTextNaValueColorw.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextNaValueColorw.TabIndex = 196
        '
        'ucrInputTextLimitColorw
        '
        Me.ucrInputTextLimitColorw.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLimitColorw.AutoSize = True
        Me.ucrInputTextLimitColorw.IsMultiline = False
        Me.ucrInputTextLimitColorw.IsReadOnly = False
        Me.ucrInputTextLimitColorw.Location = New System.Drawing.Point(286, 57)
        Me.ucrInputTextLimitColorw.Name = "ucrInputTextLimitColorw"
        Me.ucrInputTextLimitColorw.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextLimitColorw.TabIndex = 195
        '
        'ucrInputTextExpandColorw
        '
        Me.ucrInputTextExpandColorw.AddQuotesIfUnrecognised = True
        Me.ucrInputTextExpandColorw.AutoSize = True
        Me.ucrInputTextExpandColorw.IsMultiline = False
        Me.ucrInputTextExpandColorw.IsReadOnly = False
        Me.ucrInputTextExpandColorw.Location = New System.Drawing.Point(286, 104)
        Me.ucrInputTextExpandColorw.Name = "ucrInputTextExpandColorw"
        Me.ucrInputTextExpandColorw.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputTextExpandColorw.TabIndex = 194
        '
        'ucrInputPositionColorw
        '
        Me.ucrInputPositionColorw.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionColorw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionColorw.GetSetSelectedIndex = -1
        Me.ucrInputPositionColorw.IsReadOnly = False
        Me.ucrInputPositionColorw.Location = New System.Drawing.Point(286, 80)
        Me.ucrInputPositionColorw.Name = "ucrInputPositionColorw"
        Me.ucrInputPositionColorw.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPositionColorw.TabIndex = 193
        '
        'ucrInputDropUnusedLevelsColorw
        '
        Me.ucrInputDropUnusedLevelsColorw.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevelsColorw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevelsColorw.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevelsColorw.IsReadOnly = False
        Me.ucrInputDropUnusedLevelsColorw.Location = New System.Drawing.Point(286, 10)
        Me.ucrInputDropUnusedLevelsColorw.Name = "ucrInputDropUnusedLevelsColorw"
        Me.ucrInputDropUnusedLevelsColorw.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDropUnusedLevelsColorw.TabIndex = 192
        '
        'ucrChkExpandColorw
        '
        Me.ucrChkExpandColorw.AutoSize = True
        Me.ucrChkExpandColorw.Checked = False
        Me.ucrChkExpandColorw.Location = New System.Drawing.Point(7, 108)
        Me.ucrChkExpandColorw.Name = "ucrChkExpandColorw"
        Me.ucrChkExpandColorw.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkExpandColorw.TabIndex = 191
        '
        'ucrChkPositionColorw
        '
        Me.ucrChkPositionColorw.AutoSize = True
        Me.ucrChkPositionColorw.Checked = False
        Me.ucrChkPositionColorw.Location = New System.Drawing.Point(7, 87)
        Me.ucrChkPositionColorw.Name = "ucrChkPositionColorw"
        Me.ucrChkPositionColorw.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkPositionColorw.TabIndex = 190
        '
        'ucrChkLimitColorw
        '
        Me.ucrChkLimitColorw.AutoSize = True
        Me.ucrChkLimitColorw.Checked = False
        Me.ucrChkLimitColorw.Location = New System.Drawing.Point(7, 63)
        Me.ucrChkLimitColorw.Name = "ucrChkLimitColorw"
        Me.ucrChkLimitColorw.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkLimitColorw.TabIndex = 189
        '
        'ucrChkBreaksColorw
        '
        Me.ucrChkBreaksColorw.AutoSize = True
        Me.ucrChkBreaksColorw.Checked = False
        Me.ucrChkBreaksColorw.Location = New System.Drawing.Point(7, 39)
        Me.ucrChkBreaksColorw.Name = "ucrChkBreaksColorw"
        Me.ucrChkBreaksColorw.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkBreaksColorw.TabIndex = 188
        '
        'ucrChkNaValueColorw
        '
        Me.ucrChkNaValueColorw.AutoSize = True
        Me.ucrChkNaValueColorw.Checked = False
        Me.ucrChkNaValueColorw.Location = New System.Drawing.Point(7, 129)
        Me.ucrChkNaValueColorw.Name = "ucrChkNaValueColorw"
        Me.ucrChkNaValueColorw.Size = New System.Drawing.Size(245, 23)
        Me.ucrChkNaValueColorw.TabIndex = 187
        '
        'ucrChkDropUnusedLevelsColorw
        '
        Me.ucrChkDropUnusedLevelsColorw.AutoSize = True
        Me.ucrChkDropUnusedLevelsColorw.Checked = False
        Me.ucrChkDropUnusedLevelsColorw.Location = New System.Drawing.Point(7, 18)
        Me.ucrChkDropUnusedLevelsColorw.Name = "ucrChkDropUnusedLevelsColorw"
        Me.ucrChkDropUnusedLevelsColorw.Size = New System.Drawing.Size(244, 23)
        Me.ucrChkDropUnusedLevelsColorw.TabIndex = 186
        '
        'lblCanvasColorPalette
        '
        Me.lblCanvasColorPalette.AutoSize = True
        Me.lblCanvasColorPalette.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCanvasColorPalette.Location = New System.Drawing.Point(32, 431)
        Me.lblCanvasColorPalette.Name = "lblCanvasColorPalette"
        Me.lblCanvasColorPalette.Size = New System.Drawing.Size(43, 13)
        Me.lblCanvasColorPalette.TabIndex = 72
        Me.lblCanvasColorPalette.Text = "Palette:"
        '
        'ucrInputCanvasColorPalette
        '
        Me.ucrInputCanvasColorPalette.AddQuotesIfUnrecognised = True
        Me.ucrInputCanvasColorPalette.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCanvasColorPalette.GetSetSelectedIndex = -1
        Me.ucrInputCanvasColorPalette.IsReadOnly = False
        Me.ucrInputCanvasColorPalette.Location = New System.Drawing.Point(81, 427)
        Me.ucrInputCanvasColorPalette.Name = "ucrInputCanvasColorPalette"
        Me.ucrInputCanvasColorPalette.Size = New System.Drawing.Size(146, 26)
        Me.ucrInputCanvasColorPalette.TabIndex = 71
        '
        'lblGgthemesFunctions
        '
        Me.lblGgthemesFunctions.AutoSize = True
        Me.lblGgthemesFunctions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGgthemesFunctions.Location = New System.Drawing.Point(365, 395)
        Me.lblGgthemesFunctions.Name = "lblGgthemesFunctions"
        Me.lblGgthemesFunctions.Size = New System.Drawing.Size(83, 13)
        Me.lblGgthemesFunctions.TabIndex = 70
        Me.lblGgthemesFunctions.Text = "Color Functions:"
        '
        'ucrInputColorFunctions
        '
        Me.ucrInputColorFunctions.AddQuotesIfUnrecognised = True
        Me.ucrInputColorFunctions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColorFunctions.GetSetSelectedIndex = -1
        Me.ucrInputColorFunctions.IsReadOnly = False
        Me.ucrInputColorFunctions.Location = New System.Drawing.Point(470, 391)
        Me.ucrInputColorFunctions.Name = "ucrInputColorFunctions"
        Me.ucrInputColorFunctions.Size = New System.Drawing.Size(167, 26)
        Me.ucrInputColorFunctions.TabIndex = 69
        '
        'lblFillFunction
        '
        Me.lblFillFunction.AutoSize = True
        Me.lblFillFunction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFillFunction.Location = New System.Drawing.Point(369, 140)
        Me.lblFillFunction.Name = "lblFillFunction"
        Me.lblFillFunction.Size = New System.Drawing.Size(71, 13)
        Me.lblFillFunction.TabIndex = 68
        Me.lblFillFunction.Text = "Fill Functions:"
        '
        'ucrInputFillFunction
        '
        Me.ucrInputFillFunction.AddQuotesIfUnrecognised = True
        Me.ucrInputFillFunction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFillFunction.GetSetSelectedIndex = -1
        Me.ucrInputFillFunction.IsReadOnly = False
        Me.ucrInputFillFunction.Location = New System.Drawing.Point(470, 135)
        Me.ucrInputFillFunction.Name = "ucrInputFillFunction"
        Me.ucrInputFillFunction.Size = New System.Drawing.Size(167, 26)
        Me.ucrInputFillFunction.TabIndex = 67
        '
        'lblCanvasFillPalette
        '
        Me.lblCanvasFillPalette.AutoSize = True
        Me.lblCanvasFillPalette.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCanvasFillPalette.Location = New System.Drawing.Point(32, 171)
        Me.lblCanvasFillPalette.Name = "lblCanvasFillPalette"
        Me.lblCanvasFillPalette.Size = New System.Drawing.Size(43, 13)
        Me.lblCanvasFillPalette.TabIndex = 66
        Me.lblCanvasFillPalette.Text = "Palette:"
        '
        'ucrInputCanvasFillPalette
        '
        Me.ucrInputCanvasFillPalette.AddQuotesIfUnrecognised = True
        Me.ucrInputCanvasFillPalette.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCanvasFillPalette.GetSetSelectedIndex = -1
        Me.ucrInputCanvasFillPalette.IsReadOnly = False
        Me.ucrInputCanvasFillPalette.Location = New System.Drawing.Point(81, 167)
        Me.ucrInputCanvasFillPalette.Name = "ucrInputCanvasFillPalette"
        Me.ucrInputCanvasFillPalette.Size = New System.Drawing.Size(146, 26)
        Me.ucrInputCanvasFillPalette.TabIndex = 65
        '
        'ucrChkUseFill
        '
        Me.ucrChkUseFill.AutoSize = True
        Me.ucrChkUseFill.Checked = False
        Me.ucrChkUseFill.Location = New System.Drawing.Point(32, 107)
        Me.ucrChkUseFill.Name = "ucrChkUseFill"
        Me.ucrChkUseFill.Size = New System.Drawing.Size(256, 23)
        Me.ucrChkUseFill.TabIndex = 64
        '
        'ucrChkUseColor
        '
        Me.ucrChkUseColor.AutoSize = True
        Me.ucrChkUseColor.Checked = False
        Me.ucrChkUseColor.Location = New System.Drawing.Point(368, 96)
        Me.ucrChkUseColor.Name = "ucrChkUseColor"
        Me.ucrChkUseColor.Size = New System.Drawing.Size(265, 23)
        Me.ucrChkUseColor.TabIndex = 63
        '
        'rdoGgthemes
        '
        Me.rdoGgthemes.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGgthemes.BackColor = System.Drawing.SystemColors.Control
        Me.rdoGgthemes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoGgthemes.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGgthemes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGgthemes.FlatAppearance.BorderSize = 2
        Me.rdoGgthemes.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGgthemes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGgthemes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoGgthemes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGgthemes.Location = New System.Drawing.Point(464, 38)
        Me.rdoGgthemes.Name = "rdoGgthemes"
        Me.rdoGgthemes.Size = New System.Drawing.Size(91, 29)
        Me.rdoGgthemes.TabIndex = 62
        Me.rdoGgthemes.Text = "ggthemes"
        Me.rdoGgthemes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGgthemes.UseVisualStyleBackColor = True
        '
        'rdoViridis
        '
        Me.rdoViridis.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoViridis.BackColor = System.Drawing.SystemColors.Control
        Me.rdoViridis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoViridis.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoViridis.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViridis.FlatAppearance.BorderSize = 2
        Me.rdoViridis.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViridis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoViridis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoViridis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoViridis.Location = New System.Drawing.Point(375, 38)
        Me.rdoViridis.Name = "rdoViridis"
        Me.rdoViridis.Size = New System.Drawing.Size(91, 29)
        Me.rdoViridis.TabIndex = 61
        Me.rdoViridis.Text = "Viridis"
        Me.rdoViridis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoViridis.UseVisualStyleBackColor = True
        '
        'lblPalette
        '
        Me.lblPalette.AutoSize = True
        Me.lblPalette.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPalette.Location = New System.Drawing.Point(109, 79)
        Me.lblPalette.Name = "lblPalette"
        Me.lblPalette.Size = New System.Drawing.Size(43, 13)
        Me.lblPalette.TabIndex = 60
        Me.lblPalette.Text = "Palette:"
        '
        'ucrInputPalettes
        '
        Me.ucrInputPalettes.AddQuotesIfUnrecognised = True
        Me.ucrInputPalettes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPalettes.GetSetSelectedIndex = -1
        Me.ucrInputPalettes.IsReadOnly = False
        Me.ucrInputPalettes.Location = New System.Drawing.Point(158, 75)
        Me.ucrInputPalettes.Name = "ucrInputPalettes"
        Me.ucrInputPalettes.Size = New System.Drawing.Size(146, 26)
        Me.ucrInputPalettes.TabIndex = 59
        '
        'rdoQualitative
        '
        Me.rdoQualitative.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoQualitative.BackColor = System.Drawing.SystemColors.Control
        Me.rdoQualitative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoQualitative.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoQualitative.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoQualitative.FlatAppearance.BorderSize = 2
        Me.rdoQualitative.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoQualitative.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoQualitative.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoQualitative.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoQualitative.Location = New System.Drawing.Point(286, 38)
        Me.rdoQualitative.Name = "rdoQualitative"
        Me.rdoQualitative.Size = New System.Drawing.Size(91, 29)
        Me.rdoQualitative.TabIndex = 58
        Me.rdoQualitative.Text = "Qualitative"
        Me.rdoQualitative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoQualitative.UseVisualStyleBackColor = True
        '
        'rdoSequential
        '
        Me.rdoSequential.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSequential.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSequential.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoSequential.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSequential.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSequential.FlatAppearance.BorderSize = 2
        Me.rdoSequential.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSequential.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSequential.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoSequential.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSequential.Location = New System.Drawing.Point(108, 38)
        Me.rdoSequential.Name = "rdoSequential"
        Me.rdoSequential.Size = New System.Drawing.Size(91, 29)
        Me.rdoSequential.TabIndex = 56
        Me.rdoSequential.Text = "Sequential"
        Me.rdoSequential.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSequential.UseVisualStyleBackColor = True
        '
        'rdoDiverging
        '
        Me.rdoDiverging.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDiverging.BackColor = System.Drawing.SystemColors.Control
        Me.rdoDiverging.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoDiverging.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDiverging.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDiverging.FlatAppearance.BorderSize = 2
        Me.rdoDiverging.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDiverging.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDiverging.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoDiverging.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDiverging.Location = New System.Drawing.Point(197, 38)
        Me.rdoDiverging.Name = "rdoDiverging"
        Me.rdoDiverging.Size = New System.Drawing.Size(91, 29)
        Me.rdoDiverging.TabIndex = 57
        Me.rdoDiverging.Text = "Diverging"
        Me.rdoDiverging.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDiverging.UseVisualStyleBackColor = True
        '
        'ucrPnlColourPalette
        '
        Me.ucrPnlColourPalette.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlColourPalette.Location = New System.Drawing.Point(108, 38)
        Me.ucrPnlColourPalette.Name = "ucrPnlColourPalette"
        Me.ucrPnlColourPalette.Size = New System.Drawing.Size(463, 29)
        Me.ucrPnlColourPalette.TabIndex = 55
        '
        'ucrInputAxisType
        '
        Me.ucrInputAxisType.AddQuotesIfUnrecognised = True
        Me.ucrInputAxisType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAxisType.GetSetSelectedIndex = -1
        Me.ucrInputAxisType.IsReadOnly = False
        Me.ucrInputAxisType.Location = New System.Drawing.Point(470, 6)
        Me.ucrInputAxisType.Name = "ucrInputAxisType"
        Me.ucrInputAxisType.Size = New System.Drawing.Size(167, 24)
        Me.ucrInputAxisType.TabIndex = 52
        '
        'ucrChkAddColour
        '
        Me.ucrChkAddColour.AutoSize = True
        Me.ucrChkAddColour.Checked = False
        Me.ucrChkAddColour.Location = New System.Drawing.Point(32, 396)
        Me.ucrChkAddColour.Name = "ucrChkAddColour"
        Me.ucrChkAddColour.Size = New System.Drawing.Size(326, 23)
        Me.ucrChkAddColour.TabIndex = 54
        '
        'ucrChkAddFillScale
        '
        Me.ucrChkAddFillScale.AutoSize = True
        Me.ucrChkAddFillScale.Checked = False
        Me.ucrChkAddFillScale.Location = New System.Drawing.Point(32, 138)
        Me.ucrChkAddFillScale.Name = "ucrChkAddFillScale"
        Me.ucrChkAddFillScale.Size = New System.Drawing.Size(256, 23)
        Me.ucrChkAddFillScale.TabIndex = 53
        '
        'grpColourScale
        '
        Me.grpColourScale.Controls.Add(Me.ucrChkColourDiscrete)
        Me.grpColourScale.Controls.Add(Me.ucrNudColourScaleTransparency)
        Me.grpColourScale.Controls.Add(Me.ucrInputColourScalePalette)
        Me.grpColourScale.Controls.Add(Me.ucrNudColourScaleMapEnds)
        Me.grpColourScale.Controls.Add(Me.ucrNudColourScaleMapBegins)
        Me.grpColourScale.Controls.Add(Me.ucrChkColourScaleReverseOrder)
        Me.grpColourScale.Controls.Add(Me.lblColourScaleMapEnds)
        Me.grpColourScale.Controls.Add(Me.lblColourScaleMapBegins)
        Me.grpColourScale.Controls.Add(Me.lblColourScalePalette)
        Me.grpColourScale.Controls.Add(Me.lblColourScaleTransparency)
        Me.grpColourScale.Location = New System.Drawing.Point(13, 466)
        Me.grpColourScale.Name = "grpColourScale"
        Me.grpColourScale.Size = New System.Drawing.Size(444, 181)
        Me.grpColourScale.TabIndex = 25
        Me.grpColourScale.TabStop = False
        Me.grpColourScale.Text = "Colour Scale"
        '
        'ucrChkColourDiscrete
        '
        Me.ucrChkColourDiscrete.AutoSize = True
        Me.ucrChkColourDiscrete.Checked = False
        Me.ucrChkColourDiscrete.Location = New System.Drawing.Point(7, 125)
        Me.ucrChkColourDiscrete.Name = "ucrChkColourDiscrete"
        Me.ucrChkColourDiscrete.Size = New System.Drawing.Size(352, 23)
        Me.ucrChkColourDiscrete.TabIndex = 12
        '
        'ucrNudColourScaleTransparency
        '
        Me.ucrNudColourScaleTransparency.AutoSize = True
        Me.ucrNudColourScaleTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColourScaleTransparency.Location = New System.Drawing.Point(268, 46)
        Me.ucrNudColourScaleTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColourScaleTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleTransparency.Name = "ucrNudColourScaleTransparency"
        Me.ucrNudColourScaleTransparency.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudColourScaleTransparency.TabIndex = 11
        Me.ucrNudColourScaleTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputColourScalePalette
        '
        Me.ucrInputColourScalePalette.AddQuotesIfUnrecognised = True
        Me.ucrInputColourScalePalette.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColourScalePalette.GetSetSelectedIndex = -1
        Me.ucrInputColourScalePalette.IsReadOnly = False
        Me.ucrInputColourScalePalette.Location = New System.Drawing.Point(268, 19)
        Me.ucrInputColourScalePalette.Name = "ucrInputColourScalePalette"
        Me.ucrInputColourScalePalette.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColourScalePalette.TabIndex = 10
        '
        'ucrNudColourScaleMapEnds
        '
        Me.ucrNudColourScaleMapEnds.AutoSize = True
        Me.ucrNudColourScaleMapEnds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleMapEnds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColourScaleMapEnds.Location = New System.Drawing.Point(268, 97)
        Me.ucrNudColourScaleMapEnds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColourScaleMapEnds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleMapEnds.Name = "ucrNudColourScaleMapEnds"
        Me.ucrNudColourScaleMapEnds.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudColourScaleMapEnds.TabIndex = 9
        Me.ucrNudColourScaleMapEnds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudColourScaleMapBegins
        '
        Me.ucrNudColourScaleMapBegins.AutoSize = True
        Me.ucrNudColourScaleMapBegins.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleMapBegins.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColourScaleMapBegins.Location = New System.Drawing.Point(268, 71)
        Me.ucrNudColourScaleMapBegins.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColourScaleMapBegins.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColourScaleMapBegins.Name = "ucrNudColourScaleMapBegins"
        Me.ucrNudColourScaleMapBegins.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudColourScaleMapBegins.TabIndex = 8
        Me.ucrNudColourScaleMapBegins.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkColourScaleReverseOrder
        '
        Me.ucrChkColourScaleReverseOrder.AutoSize = True
        Me.ucrChkColourScaleReverseOrder.Checked = False
        Me.ucrChkColourScaleReverseOrder.Location = New System.Drawing.Point(6, 152)
        Me.ucrChkColourScaleReverseOrder.Name = "ucrChkColourScaleReverseOrder"
        Me.ucrChkColourScaleReverseOrder.Size = New System.Drawing.Size(352, 23)
        Me.ucrChkColourScaleReverseOrder.TabIndex = 5
        '
        'lblColourScaleMapEnds
        '
        Me.lblColourScaleMapEnds.AutoSize = True
        Me.lblColourScaleMapEnds.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColourScaleMapEnds.Location = New System.Drawing.Point(7, 100)
        Me.lblColourScaleMapEnds.Name = "lblColourScaleMapEnds"
        Me.lblColourScaleMapEnds.Size = New System.Drawing.Size(198, 13)
        Me.lblColourScaleMapEnds.TabIndex = 3
        Me.lblColourScaleMapEnds.Text = "Corrected Hue Where Colour Map Ends:"
        '
        'lblColourScaleMapBegins
        '
        Me.lblColourScaleMapBegins.AutoSize = True
        Me.lblColourScaleMapBegins.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColourScaleMapBegins.Location = New System.Drawing.Point(7, 75)
        Me.lblColourScaleMapBegins.Name = "lblColourScaleMapBegins"
        Me.lblColourScaleMapBegins.Size = New System.Drawing.Size(206, 13)
        Me.lblColourScaleMapBegins.TabIndex = 2
        Me.lblColourScaleMapBegins.Text = "Corrected Hue Where Colour Map Begins:"
        '
        'lblColourScalePalette
        '
        Me.lblColourScalePalette.AutoSize = True
        Me.lblColourScalePalette.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColourScalePalette.Location = New System.Drawing.Point(7, 25)
        Me.lblColourScalePalette.Name = "lblColourScalePalette"
        Me.lblColourScalePalette.Size = New System.Drawing.Size(76, 13)
        Me.lblColourScalePalette.TabIndex = 1
        Me.lblColourScalePalette.Text = "Colour Palette:"
        '
        'lblColourScaleTransparency
        '
        Me.lblColourScaleTransparency.AutoSize = True
        Me.lblColourScaleTransparency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColourScaleTransparency.Location = New System.Drawing.Point(7, 50)
        Me.lblColourScaleTransparency.Name = "lblColourScaleTransparency"
        Me.lblColourScaleTransparency.Size = New System.Drawing.Size(75, 13)
        Me.lblColourScaleTransparency.TabIndex = 0
        Me.lblColourScaleTransparency.Text = "Transparency:"
        '
        'grpFillScale
        '
        Me.grpFillScale.Controls.Add(Me.ucrChkFillDiscrete)
        Me.grpFillScale.Controls.Add(Me.ucrNudFillScaleTransparency)
        Me.grpFillScale.Controls.Add(Me.ucrNudFillScaleMapEnds)
        Me.grpFillScale.Controls.Add(Me.ucrNudFillScaleMapBegins)
        Me.grpFillScale.Controls.Add(Me.ucrInputFillScaleColour)
        Me.grpFillScale.Controls.Add(Me.ucrChkFillScaleReverseColourOrder)
        Me.grpFillScale.Controls.Add(Me.lblFillScaleMapEnds)
        Me.grpFillScale.Controls.Add(Me.lblFillScaleBeginColour)
        Me.grpFillScale.Controls.Add(Me.lblFillScaleColourPalettte)
        Me.grpFillScale.Controls.Add(Me.lblFillScaleTransparency)
        Me.grpFillScale.Location = New System.Drawing.Point(13, 202)
        Me.grpFillScale.Name = "grpFillScale"
        Me.grpFillScale.Size = New System.Drawing.Size(444, 174)
        Me.grpFillScale.TabIndex = 23
        Me.grpFillScale.TabStop = False
        Me.grpFillScale.Text = "Fill Scale"
        '
        'ucrChkFillDiscrete
        '
        Me.ucrChkFillDiscrete.AutoSize = True
        Me.ucrChkFillDiscrete.Checked = False
        Me.ucrChkFillDiscrete.Location = New System.Drawing.Point(7, 119)
        Me.ucrChkFillDiscrete.Name = "ucrChkFillDiscrete"
        Me.ucrChkFillDiscrete.Size = New System.Drawing.Size(352, 23)
        Me.ucrChkFillDiscrete.TabIndex = 10
        '
        'ucrNudFillScaleTransparency
        '
        Me.ucrNudFillScaleTransparency.AutoSize = True
        Me.ucrNudFillScaleTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFillScaleTransparency.Location = New System.Drawing.Point(268, 43)
        Me.ucrNudFillScaleTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFillScaleTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleTransparency.Name = "ucrNudFillScaleTransparency"
        Me.ucrNudFillScaleTransparency.Size = New System.Drawing.Size(50, 21)
        Me.ucrNudFillScaleTransparency.TabIndex = 9
        Me.ucrNudFillScaleTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFillScaleMapEnds
        '
        Me.ucrNudFillScaleMapEnds.AutoSize = True
        Me.ucrNudFillScaleMapEnds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleMapEnds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFillScaleMapEnds.Location = New System.Drawing.Point(268, 94)
        Me.ucrNudFillScaleMapEnds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFillScaleMapEnds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleMapEnds.Name = "ucrNudFillScaleMapEnds"
        Me.ucrNudFillScaleMapEnds.Size = New System.Drawing.Size(50, 22)
        Me.ucrNudFillScaleMapEnds.TabIndex = 8
        Me.ucrNudFillScaleMapEnds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFillScaleMapBegins
        '
        Me.ucrNudFillScaleMapBegins.AutoSize = True
        Me.ucrNudFillScaleMapBegins.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleMapBegins.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFillScaleMapBegins.Location = New System.Drawing.Point(268, 69)
        Me.ucrNudFillScaleMapBegins.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFillScaleMapBegins.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFillScaleMapBegins.Name = "ucrNudFillScaleMapBegins"
        Me.ucrNudFillScaleMapBegins.Size = New System.Drawing.Size(50, 27)
        Me.ucrNudFillScaleMapBegins.TabIndex = 7
        Me.ucrNudFillScaleMapBegins.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputFillScaleColour
        '
        Me.ucrInputFillScaleColour.AddQuotesIfUnrecognised = True
        Me.ucrInputFillScaleColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFillScaleColour.GetSetSelectedIndex = -1
        Me.ucrInputFillScaleColour.IsReadOnly = False
        Me.ucrInputFillScaleColour.Location = New System.Drawing.Point(268, 14)
        Me.ucrInputFillScaleColour.Name = "ucrInputFillScaleColour"
        Me.ucrInputFillScaleColour.Size = New System.Drawing.Size(137, 24)
        Me.ucrInputFillScaleColour.TabIndex = 6
        '
        'ucrChkFillScaleReverseColourOrder
        '
        Me.ucrChkFillScaleReverseColourOrder.AutoSize = True
        Me.ucrChkFillScaleReverseColourOrder.Checked = False
        Me.ucrChkFillScaleReverseColourOrder.Location = New System.Drawing.Point(7, 145)
        Me.ucrChkFillScaleReverseColourOrder.Name = "ucrChkFillScaleReverseColourOrder"
        Me.ucrChkFillScaleReverseColourOrder.Size = New System.Drawing.Size(352, 23)
        Me.ucrChkFillScaleReverseColourOrder.TabIndex = 5
        '
        'lblFillScaleMapEnds
        '
        Me.lblFillScaleMapEnds.AutoSize = True
        Me.lblFillScaleMapEnds.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFillScaleMapEnds.Location = New System.Drawing.Point(7, 98)
        Me.lblFillScaleMapEnds.Name = "lblFillScaleMapEnds"
        Me.lblFillScaleMapEnds.Size = New System.Drawing.Size(198, 13)
        Me.lblFillScaleMapEnds.TabIndex = 3
        Me.lblFillScaleMapEnds.Text = "Corrected Hue Where Colour Map Ends:"
        '
        'lblFillScaleBeginColour
        '
        Me.lblFillScaleBeginColour.AutoSize = True
        Me.lblFillScaleBeginColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFillScaleBeginColour.Location = New System.Drawing.Point(7, 73)
        Me.lblFillScaleBeginColour.Name = "lblFillScaleBeginColour"
        Me.lblFillScaleBeginColour.Size = New System.Drawing.Size(206, 13)
        Me.lblFillScaleBeginColour.TabIndex = 2
        Me.lblFillScaleBeginColour.Text = "Corrected Hue Where Colour Map Begins:"
        '
        'lblFillScaleColourPalettte
        '
        Me.lblFillScaleColourPalettte.AutoSize = True
        Me.lblFillScaleColourPalettte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFillScaleColourPalettte.Location = New System.Drawing.Point(7, 23)
        Me.lblFillScaleColourPalettte.Name = "lblFillScaleColourPalettte"
        Me.lblFillScaleColourPalettte.Size = New System.Drawing.Size(76, 13)
        Me.lblFillScaleColourPalettte.TabIndex = 1
        Me.lblFillScaleColourPalettte.Text = "Colour Palette:"
        '
        'lblFillScaleTransparency
        '
        Me.lblFillScaleTransparency.AutoSize = True
        Me.lblFillScaleTransparency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFillScaleTransparency.Location = New System.Drawing.Point(7, 48)
        Me.lblFillScaleTransparency.Name = "lblFillScaleTransparency"
        Me.lblFillScaleTransparency.Size = New System.Drawing.Size(75, 13)
        Me.lblFillScaleTransparency.TabIndex = 0
        Me.lblFillScaleTransparency.Text = "Transparency:"
        '
        'lblPalcontinuouscolor
        '
        Me.lblPalcontinuouscolor.AutoSize = True
        Me.lblPalcontinuouscolor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPalcontinuouscolor.Location = New System.Drawing.Point(32, 429)
        Me.lblPalcontinuouscolor.Name = "lblPalcontinuouscolor"
        Me.lblPalcontinuouscolor.Size = New System.Drawing.Size(43, 13)
        Me.lblPalcontinuouscolor.TabIndex = 231
        Me.lblPalcontinuouscolor.Text = "Palette:"
        '
        'ucrInputcontinuouscolor
        '
        Me.ucrInputcontinuouscolor.AddQuotesIfUnrecognised = True
        Me.ucrInputcontinuouscolor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputcontinuouscolor.GetSetSelectedIndex = -1
        Me.ucrInputcontinuouscolor.IsReadOnly = False
        Me.ucrInputcontinuouscolor.Location = New System.Drawing.Point(81, 425)
        Me.ucrInputcontinuouscolor.Name = "ucrInputcontinuouscolor"
        Me.ucrInputcontinuouscolor.Size = New System.Drawing.Size(146, 26)
        Me.ucrInputcontinuouscolor.TabIndex = 230
        '
        'lblPaletteContinuousfill
        '
        Me.lblPaletteContinuousfill.AutoSize = True
        Me.lblPaletteContinuousfill.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPaletteContinuousfill.Location = New System.Drawing.Point(32, 171)
        Me.lblPaletteContinuousfill.Name = "lblPaletteContinuousfill"
        Me.lblPaletteContinuousfill.Size = New System.Drawing.Size(43, 13)
        Me.lblPaletteContinuousfill.TabIndex = 229
        Me.lblPaletteContinuousfill.Text = "Palette:"
        '
        'ucrInputContinousfill
        '
        Me.ucrInputContinousfill.AddQuotesIfUnrecognised = True
        Me.ucrInputContinousfill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputContinousfill.GetSetSelectedIndex = -1
        Me.ucrInputContinousfill.IsReadOnly = False
        Me.ucrInputContinousfill.Location = New System.Drawing.Point(81, 167)
        Me.ucrInputContinousfill.Name = "ucrInputContinousfill"
        Me.ucrInputContinousfill.Size = New System.Drawing.Size(146, 26)
        Me.ucrInputContinousfill.TabIndex = 228
        '
        'lblPaletteContinuous
        '
        Me.lblPaletteContinuous.AutoSize = True
        Me.lblPaletteContinuous.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPaletteContinuous.Location = New System.Drawing.Point(109, 79)
        Me.lblPaletteContinuous.Name = "lblPaletteContinuous"
        Me.lblPaletteContinuous.Size = New System.Drawing.Size(43, 13)
        Me.lblPaletteContinuous.TabIndex = 265
        Me.lblPaletteContinuous.Text = "Palette:"
        '
        'ucrInputPaletteContinuous
        '
        Me.ucrInputPaletteContinuous.AddQuotesIfUnrecognised = True
        Me.ucrInputPaletteContinuous.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPaletteContinuous.GetSetSelectedIndex = -1
        Me.ucrInputPaletteContinuous.IsReadOnly = False
        Me.ucrInputPaletteContinuous.Location = New System.Drawing.Point(158, 75)
        Me.ucrInputPaletteContinuous.Name = "ucrInputPaletteContinuous"
        Me.ucrInputPaletteContinuous.Size = New System.Drawing.Size(146, 26)
        Me.ucrInputPaletteContinuous.TabIndex = 264
        '
        'tbpAnnotation
        '
        Me.tbpAnnotation.Controls.Add(Me.ucrChkAnnotation)
        Me.tbpAnnotation.Controls.Add(Me.grpAnnotation)
        Me.tbpAnnotation.Location = New System.Drawing.Point(4, 22)
        Me.tbpAnnotation.Name = "tbpAnnotation"
        Me.tbpAnnotation.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAnnotation.Size = New System.Drawing.Size(669, 710)
        Me.tbpAnnotation.TabIndex = 9
        Me.tbpAnnotation.Text = "Annotation"
        Me.tbpAnnotation.UseVisualStyleBackColor = True
        '
        'ucrChkAnnotation
        '
        Me.ucrChkAnnotation.AutoSize = True
        Me.ucrChkAnnotation.Checked = False
        Me.ucrChkAnnotation.Location = New System.Drawing.Point(7, 17)
        Me.ucrChkAnnotation.Name = "ucrChkAnnotation"
        Me.ucrChkAnnotation.Size = New System.Drawing.Size(278, 23)
        Me.ucrChkAnnotation.TabIndex = 44
        '
        'grpAnnotation
        '
        Me.grpAnnotation.Controls.Add(Me.ucrChkParse)
        Me.grpAnnotation.Controls.Add(Me.ucrInputFill)
        Me.grpAnnotation.Controls.Add(Me.ucrInputColour)
        Me.grpAnnotation.Controls.Add(Me.lblCurvature)
        Me.grpAnnotation.Controls.Add(Me.ucrNudAlpha)
        Me.grpAnnotation.Controls.Add(Me.lblAlpha)
        Me.grpAnnotation.Controls.Add(Me.lblLineend)
        Me.grpAnnotation.Controls.Add(Me.lblAngle)
        Me.grpAnnotation.Controls.Add(Me.ucrNudAngle)
        Me.grpAnnotation.Controls.Add(Me.lblShape)
        Me.grpAnnotation.Controls.Add(Me.lblAnnotationGeoms)
        Me.grpAnnotation.Controls.Add(Me.ucrInputAnnotationGeoms)
        Me.grpAnnotation.Controls.Add(Me.lblSize)
        Me.grpAnnotation.Controls.Add(Me.ucrNudSize)
        Me.grpAnnotation.Controls.Add(Me.lblColour)
        Me.grpAnnotation.Controls.Add(Me.lblY)
        Me.grpAnnotation.Controls.Add(Me.lblX)
        Me.grpAnnotation.Controls.Add(Me.lblFill)
        Me.grpAnnotation.Controls.Add(Me.lblXmax)
        Me.grpAnnotation.Controls.Add(Me.ucrInputXmax)
        Me.grpAnnotation.Controls.Add(Me.ucrInputYmin)
        Me.grpAnnotation.Controls.Add(Me.ucrInputXmin)
        Me.grpAnnotation.Controls.Add(Me.lblYmin)
        Me.grpAnnotation.Controls.Add(Me.lblXmin)
        Me.grpAnnotation.Controls.Add(Me.lblXend)
        Me.grpAnnotation.Controls.Add(Me.lblYmax)
        Me.grpAnnotation.Controls.Add(Me.ucrInputYmax)
        Me.grpAnnotation.Controls.Add(Me.ucrInputYend)
        Me.grpAnnotation.Controls.Add(Me.ucrInputXend)
        Me.grpAnnotation.Controls.Add(Me.lblYend)
        Me.grpAnnotation.Controls.Add(Me.ucrNudLinetype)
        Me.grpAnnotation.Controls.Add(Me.lblLinetype)
        Me.grpAnnotation.Controls.Add(Me.lblPointrangeFatten)
        Me.grpAnnotation.Controls.Add(Me.ucrNudPointrangeFatten)
        Me.grpAnnotation.Controls.Add(Me.ucrNudCrossbarFatten)
        Me.grpAnnotation.Controls.Add(Me.lblCrossbarFatten)
        Me.grpAnnotation.Controls.Add(Me.ucrNudCurvature)
        Me.grpAnnotation.Controls.Add(Me.ucrNudShape)
        Me.grpAnnotation.Controls.Add(Me.lblLabel)
        Me.grpAnnotation.Controls.Add(Me.ucrInputLabel)
        Me.grpAnnotation.Controls.Add(Me.ucrInputLineend)
        Me.grpAnnotation.Controls.Add(Me.ucrInputY)
        Me.grpAnnotation.Controls.Add(Me.ucrInputX)
        Me.grpAnnotation.Controls.Add(Me.ucrReceiverY)
        Me.grpAnnotation.Location = New System.Drawing.Point(7, 43)
        Me.grpAnnotation.Name = "grpAnnotation"
        Me.grpAnnotation.Size = New System.Drawing.Size(459, 374)
        Me.grpAnnotation.TabIndex = 43
        Me.grpAnnotation.TabStop = False
        Me.grpAnnotation.Text = "Annotation"
        '
        'ucrChkParse
        '
        Me.ucrChkParse.AutoSize = True
        Me.ucrChkParse.Checked = False
        Me.ucrChkParse.Location = New System.Drawing.Point(75, 230)
        Me.ucrChkParse.Name = "ucrChkParse"
        Me.ucrChkParse.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkParse.TabIndex = 102
        '
        'ucrInputFill
        '
        Me.ucrInputFill.AddQuotesIfUnrecognised = True
        Me.ucrInputFill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFill.GetSetSelectedIndex = -1
        Me.ucrInputFill.IsReadOnly = False
        Me.ucrInputFill.Location = New System.Drawing.Point(75, 179)
        Me.ucrInputFill.Name = "ucrInputFill"
        Me.ucrInputFill.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFill.TabIndex = 101
        '
        'ucrInputColour
        '
        Me.ucrInputColour.AddQuotesIfUnrecognised = True
        Me.ucrInputColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColour.GetSetSelectedIndex = -1
        Me.ucrInputColour.IsReadOnly = False
        Me.ucrInputColour.Location = New System.Drawing.Point(75, 81)
        Me.ucrInputColour.Name = "ucrInputColour"
        Me.ucrInputColour.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColour.TabIndex = 100
        '
        'lblCurvature
        '
        Me.lblCurvature.AutoSize = True
        Me.lblCurvature.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCurvature.Location = New System.Drawing.Point(7, 184)
        Me.lblCurvature.Name = "lblCurvature"
        Me.lblCurvature.Size = New System.Drawing.Size(58, 13)
        Me.lblCurvature.TabIndex = 85
        Me.lblCurvature.Text = "curvature :"
        '
        'ucrNudAlpha
        '
        Me.ucrNudAlpha.AutoSize = True
        Me.ucrNudAlpha.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlpha.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAlpha.Location = New System.Drawing.Point(75, 130)
        Me.ucrNudAlpha.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAlpha.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAlpha.Name = "ucrNudAlpha"
        Me.ucrNudAlpha.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAlpha.TabIndex = 20
        Me.ucrNudAlpha.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblAlpha
        '
        Me.lblAlpha.AutoSize = True
        Me.lblAlpha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAlpha.Location = New System.Drawing.Point(26, 135)
        Me.lblAlpha.Name = "lblAlpha"
        Me.lblAlpha.Size = New System.Drawing.Size(39, 13)
        Me.lblAlpha.TabIndex = 19
        Me.lblAlpha.Text = "alpha :"
        '
        'lblLineend
        '
        Me.lblLineend.AutoSize = True
        Me.lblLineend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineend.Location = New System.Drawing.Point(18, 184)
        Me.lblLineend.Name = "lblLineend"
        Me.lblLineend.Size = New System.Drawing.Size(47, 13)
        Me.lblLineend.TabIndex = 83
        Me.lblLineend.Text = "lineend :"
        '
        'lblAngle
        '
        Me.lblAngle.AutoSize = True
        Me.lblAngle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAngle.Location = New System.Drawing.Point(26, 208)
        Me.lblAngle.Name = "lblAngle"
        Me.lblAngle.Size = New System.Drawing.Size(39, 13)
        Me.lblAngle.TabIndex = 80
        Me.lblAngle.Text = "angle :"
        '
        'ucrNudAngle
        '
        Me.ucrNudAngle.AutoSize = True
        Me.ucrNudAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAngle.Location = New System.Drawing.Point(75, 204)
        Me.ucrNudAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngle.Name = "ucrNudAngle"
        Me.ucrNudAngle.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAngle.TabIndex = 78
        Me.ucrNudAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShape.Location = New System.Drawing.Point(23, 210)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(42, 13)
        Me.lblShape.TabIndex = 79
        Me.lblShape.Text = "shape :"
        '
        'lblAnnotationGeoms
        '
        Me.lblAnnotationGeoms.AutoSize = True
        Me.lblAnnotationGeoms.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAnnotationGeoms.Location = New System.Drawing.Point(25, 24)
        Me.lblAnnotationGeoms.Name = "lblAnnotationGeoms"
        Me.lblAnnotationGeoms.Size = New System.Drawing.Size(41, 13)
        Me.lblAnnotationGeoms.TabIndex = 77
        Me.lblAnnotationGeoms.Text = "Geom :"
        '
        'ucrInputAnnotationGeoms
        '
        Me.ucrInputAnnotationGeoms.AddQuotesIfUnrecognised = True
        Me.ucrInputAnnotationGeoms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAnnotationGeoms.GetSetSelectedIndex = -1
        Me.ucrInputAnnotationGeoms.IsReadOnly = False
        Me.ucrInputAnnotationGeoms.Location = New System.Drawing.Point(75, 19)
        Me.ucrInputAnnotationGeoms.Name = "ucrInputAnnotationGeoms"
        Me.ucrInputAnnotationGeoms.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputAnnotationGeoms.TabIndex = 76
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSize.Location = New System.Drawing.Point(34, 111)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(31, 13)
        Me.lblSize.TabIndex = 75
        Me.lblSize.Text = "size :"
        '
        'ucrNudSize
        '
        Me.ucrNudSize.AutoSize = True
        Me.ucrNudSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSize.Location = New System.Drawing.Point(75, 106)
        Me.ucrNudSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Name = "ucrNudSize"
        Me.ucrNudSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSize.TabIndex = 74
        Me.ucrNudSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColour.Location = New System.Drawing.Point(23, 87)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(42, 13)
        Me.lblColour.TabIndex = 73
        Me.lblColour.Text = "colour :"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblY.Location = New System.Drawing.Point(291, 56)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(18, 13)
        Me.lblY.TabIndex = 69
        Me.lblY.Text = "y :"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblX.Location = New System.Drawing.Point(294, 31)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(15, 13)
        Me.lblX.TabIndex = 68
        Me.lblX.Text = "x:"
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFill.Location = New System.Drawing.Point(43, 184)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(22, 13)
        Me.lblFill.TabIndex = 61
        Me.lblFill.Text = "fill :"
        '
        'lblXmax
        '
        Me.lblXmax.AutoSize = True
        Me.lblXmax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXmax.Location = New System.Drawing.Point(272, 132)
        Me.lblXmax.Name = "lblXmax"
        Me.lblXmax.Size = New System.Drawing.Size(37, 13)
        Me.lblXmax.TabIndex = 51
        Me.lblXmax.Text = "xmax :"
        '
        'ucrInputXmax
        '
        Me.ucrInputXmax.AddQuotesIfUnrecognised = True
        Me.ucrInputXmax.AutoSize = True
        Me.ucrInputXmax.IsMultiline = False
        Me.ucrInputXmax.IsReadOnly = False
        Me.ucrInputXmax.Location = New System.Drawing.Point(318, 127)
        Me.ucrInputXmax.Name = "ucrInputXmax"
        Me.ucrInputXmax.Size = New System.Drawing.Size(116, 21)
        Me.ucrInputXmax.TabIndex = 50
        '
        'ucrInputYmin
        '
        Me.ucrInputYmin.AddQuotesIfUnrecognised = True
        Me.ucrInputYmin.AutoSize = True
        Me.ucrInputYmin.IsMultiline = False
        Me.ucrInputYmin.IsReadOnly = False
        Me.ucrInputYmin.Location = New System.Drawing.Point(318, 102)
        Me.ucrInputYmin.Name = "ucrInputYmin"
        Me.ucrInputYmin.Size = New System.Drawing.Size(116, 21)
        Me.ucrInputYmin.TabIndex = 49
        '
        'ucrInputXmin
        '
        Me.ucrInputXmin.AddQuotesIfUnrecognised = True
        Me.ucrInputXmin.AutoSize = True
        Me.ucrInputXmin.IsMultiline = False
        Me.ucrInputXmin.IsReadOnly = False
        Me.ucrInputXmin.Location = New System.Drawing.Point(318, 77)
        Me.ucrInputXmin.Name = "ucrInputXmin"
        Me.ucrInputXmin.Size = New System.Drawing.Size(116, 21)
        Me.ucrInputXmin.TabIndex = 48
        '
        'lblYmin
        '
        Me.lblYmin.AutoSize = True
        Me.lblYmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYmin.Location = New System.Drawing.Point(275, 106)
        Me.lblYmin.Name = "lblYmin"
        Me.lblYmin.Size = New System.Drawing.Size(34, 13)
        Me.lblYmin.TabIndex = 47
        Me.lblYmin.Text = "ymin :"
        '
        'lblXmin
        '
        Me.lblXmin.AutoSize = True
        Me.lblXmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXmin.Location = New System.Drawing.Point(275, 81)
        Me.lblXmin.Name = "lblXmin"
        Me.lblXmin.Size = New System.Drawing.Size(34, 13)
        Me.lblXmin.TabIndex = 46
        Me.lblXmin.Text = "xmin :"
        '
        'lblXend
        '
        Me.lblXend.AutoSize = True
        Me.lblXend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXend.Location = New System.Drawing.Point(273, 181)
        Me.lblXend.Name = "lblXend"
        Me.lblXend.Size = New System.Drawing.Size(36, 13)
        Me.lblXend.TabIndex = 40
        Me.lblXend.Text = "xend :"
        '
        'lblYmax
        '
        Me.lblYmax.AutoSize = True
        Me.lblYmax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYmax.Location = New System.Drawing.Point(272, 156)
        Me.lblYmax.Name = "lblYmax"
        Me.lblYmax.Size = New System.Drawing.Size(37, 13)
        Me.lblYmax.TabIndex = 39
        Me.lblYmax.Text = "ymax :"
        '
        'ucrInputYmax
        '
        Me.ucrInputYmax.AddQuotesIfUnrecognised = True
        Me.ucrInputYmax.AutoSize = True
        Me.ucrInputYmax.IsMultiline = False
        Me.ucrInputYmax.IsReadOnly = False
        Me.ucrInputYmax.Location = New System.Drawing.Point(319, 152)
        Me.ucrInputYmax.Name = "ucrInputYmax"
        Me.ucrInputYmax.Size = New System.Drawing.Size(115, 21)
        Me.ucrInputYmax.TabIndex = 38
        '
        'ucrInputYend
        '
        Me.ucrInputYend.AddQuotesIfUnrecognised = True
        Me.ucrInputYend.AutoSize = True
        Me.ucrInputYend.IsMultiline = False
        Me.ucrInputYend.IsReadOnly = False
        Me.ucrInputYend.Location = New System.Drawing.Point(319, 202)
        Me.ucrInputYend.Name = "ucrInputYend"
        Me.ucrInputYend.Size = New System.Drawing.Size(115, 21)
        Me.ucrInputYend.TabIndex = 37
        '
        'ucrInputXend
        '
        Me.ucrInputXend.AddQuotesIfUnrecognised = True
        Me.ucrInputXend.AutoSize = True
        Me.ucrInputXend.IsMultiline = False
        Me.ucrInputXend.IsReadOnly = False
        Me.ucrInputXend.Location = New System.Drawing.Point(319, 177)
        Me.ucrInputXend.Name = "ucrInputXend"
        Me.ucrInputXend.Size = New System.Drawing.Size(115, 21)
        Me.ucrInputXend.TabIndex = 36
        '
        'lblYend
        '
        Me.lblYend.AutoSize = True
        Me.lblYend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYend.Location = New System.Drawing.Point(273, 206)
        Me.lblYend.Name = "lblYend"
        Me.lblYend.Size = New System.Drawing.Size(36, 13)
        Me.lblYend.TabIndex = 35
        Me.lblYend.Text = "yend :"
        '
        'ucrNudLinetype
        '
        Me.ucrNudLinetype.AutoSize = True
        Me.ucrNudLinetype.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLinetype.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLinetype.Location = New System.Drawing.Point(75, 154)
        Me.ucrNudLinetype.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLinetype.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLinetype.Name = "ucrNudLinetype"
        Me.ucrNudLinetype.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLinetype.TabIndex = 62
        Me.ucrNudLinetype.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLinetype
        '
        Me.lblLinetype.AutoSize = True
        Me.lblLinetype.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLinetype.Location = New System.Drawing.Point(16, 159)
        Me.lblLinetype.Name = "lblLinetype"
        Me.lblLinetype.Size = New System.Drawing.Size(49, 13)
        Me.lblLinetype.TabIndex = 63
        Me.lblLinetype.Text = "linetype :"
        '
        'lblPointrangeFatten
        '
        Me.lblPointrangeFatten.AutoSize = True
        Me.lblPointrangeFatten.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPointrangeFatten.Location = New System.Drawing.Point(25, 184)
        Me.lblPointrangeFatten.Name = "lblPointrangeFatten"
        Me.lblPointrangeFatten.Size = New System.Drawing.Size(40, 13)
        Me.lblPointrangeFatten.TabIndex = 89
        Me.lblPointrangeFatten.Text = "fatten :"
        '
        'ucrNudPointrangeFatten
        '
        Me.ucrNudPointrangeFatten.AutoSize = True
        Me.ucrNudPointrangeFatten.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPointrangeFatten.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPointrangeFatten.Location = New System.Drawing.Point(75, 179)
        Me.ucrNudPointrangeFatten.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPointrangeFatten.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPointrangeFatten.Name = "ucrNudPointrangeFatten"
        Me.ucrNudPointrangeFatten.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPointrangeFatten.TabIndex = 88
        Me.ucrNudPointrangeFatten.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudCrossbarFatten
        '
        Me.ucrNudCrossbarFatten.AutoSize = True
        Me.ucrNudCrossbarFatten.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCrossbarFatten.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCrossbarFatten.Location = New System.Drawing.Point(75, 179)
        Me.ucrNudCrossbarFatten.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCrossbarFatten.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCrossbarFatten.Name = "ucrNudCrossbarFatten"
        Me.ucrNudCrossbarFatten.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCrossbarFatten.TabIndex = 87
        Me.ucrNudCrossbarFatten.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblCrossbarFatten
        '
        Me.lblCrossbarFatten.AutoSize = True
        Me.lblCrossbarFatten.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCrossbarFatten.Location = New System.Drawing.Point(25, 184)
        Me.lblCrossbarFatten.Name = "lblCrossbarFatten"
        Me.lblCrossbarFatten.Size = New System.Drawing.Size(40, 13)
        Me.lblCrossbarFatten.TabIndex = 86
        Me.lblCrossbarFatten.Text = "fatten :"
        '
        'ucrNudCurvature
        '
        Me.ucrNudCurvature.AutoSize = True
        Me.ucrNudCurvature.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCurvature.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCurvature.Location = New System.Drawing.Point(75, 179)
        Me.ucrNudCurvature.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCurvature.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCurvature.Name = "ucrNudCurvature"
        Me.ucrNudCurvature.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCurvature.TabIndex = 84
        Me.ucrNudCurvature.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudShape
        '
        Me.ucrNudShape.AutoSize = True
        Me.ucrNudShape.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShape.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudShape.Location = New System.Drawing.Point(75, 204)
        Me.ucrNudShape.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShape.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShape.Name = "ucrNudShape"
        Me.ucrNudShape.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudShape.TabIndex = 81
        Me.ucrNudShape.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabel.Location = New System.Drawing.Point(30, 159)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(35, 13)
        Me.lblLabel.TabIndex = 91
        Me.lblLabel.Text = "label :"
        '
        'ucrInputLabel
        '
        Me.ucrInputLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel.AutoSize = True
        Me.ucrInputLabel.IsMultiline = False
        Me.ucrInputLabel.IsReadOnly = False
        Me.ucrInputLabel.Location = New System.Drawing.Point(75, 154)
        Me.ucrInputLabel.Name = "ucrInputLabel"
        Me.ucrInputLabel.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLabel.TabIndex = 90
        '
        'ucrInputLineend
        '
        Me.ucrInputLineend.AddQuotesIfUnrecognised = True
        Me.ucrInputLineend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLineend.GetSetSelectedIndex = -1
        Me.ucrInputLineend.IsReadOnly = False
        Me.ucrInputLineend.Location = New System.Drawing.Point(75, 179)
        Me.ucrInputLineend.Name = "ucrInputLineend"
        Me.ucrInputLineend.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLineend.TabIndex = 82
        '
        'ucrInputY
        '
        Me.ucrInputY.AddQuotesIfUnrecognised = True
        Me.ucrInputY.AutoSize = True
        Me.ucrInputY.IsMultiline = False
        Me.ucrInputY.IsReadOnly = False
        Me.ucrInputY.Location = New System.Drawing.Point(318, 52)
        Me.ucrInputY.Name = "ucrInputY"
        Me.ucrInputY.Size = New System.Drawing.Size(116, 21)
        Me.ucrInputY.TabIndex = 70
        '
        'ucrInputX
        '
        Me.ucrInputX.AddQuotesIfUnrecognised = True
        Me.ucrInputX.AutoSize = True
        Me.ucrInputX.IsMultiline = False
        Me.ucrInputX.IsReadOnly = False
        Me.ucrInputX.Location = New System.Drawing.Point(318, 27)
        Me.ucrInputX.Name = "ucrInputX"
        Me.ucrInputX.Size = New System.Drawing.Size(116, 21)
        Me.ucrInputX.TabIndex = 71
        '
        'ucrReceiverY
        '
        Me.ucrReceiverY.AutoSize = True
        Me.ucrReceiverY.frmParent = Nothing
        Me.ucrReceiverY.Location = New System.Drawing.Point(318, 52)
        Me.ucrReceiverY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverY.Name = "ucrReceiverY"
        Me.ucrReceiverY.Selector = Nothing
        Me.ucrReceiverY.Size = New System.Drawing.Size(116, 21)
        Me.ucrReceiverY.strNcFilePath = ""
        Me.ucrReceiverY.TabIndex = 99
        Me.ucrReceiverY.ucrSelector = Nothing
        '
        'ttCaptionTitle
        '
        Me.ttCaptionTitle.AutoPopDelay = 10000
        Me.ttCaptionTitle.InitialDelay = 500
        Me.ttCaptionTitle.ReshowDelay = 100
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(232, 688)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 29)
        Me.ucrBaseSubdialog.TabIndex = 1
        '
        'sdgPlots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(687, 784)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.tbpPlotsOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPlots"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Plot_Options"
        Me.Text = "Plot Options"
        Me.tbpPlotsOptions.ResumeLayout(False)
        Me.tbpFacet.ResumeLayout(False)
        Me.tbpFacet.PerformLayout()
        Me.tbpLayers.ResumeLayout(False)
        Me.tbpLayers.PerformLayout()
        Me.tbpTitles.ResumeLayout(False)
        Me.tbpTitles.PerformLayout()
        Me.grpLegendTitle.ResumeLayout(False)
        Me.grpLegendTitle.PerformLayout()
        Me.tbpXAxis.ResumeLayout(False)
        Me.tbpXAxis.PerformLayout()
        Me.tbpYAxis.ResumeLayout(False)
        Me.tbpYAxis.PerformLayout()
        Me.tbpTheme.ResumeLayout(False)
        Me.tbpTheme.PerformLayout()
        Me.grpCommonOptions.ResumeLayout(False)
        Me.grpCommonOptions.PerformLayout()
        Me.tbpCoordinates.ResumeLayout(False)
        Me.tbpCoordinates.PerformLayout()
        Me.grpPolarCordinates.ResumeLayout(False)
        Me.grpPolarCordinates.PerformLayout()
        Me.tbpColour.ResumeLayout(False)
        Me.tbpColour.PerformLayout()
        Me.grpScalecolorpt.ResumeLayout(False)
        Me.grpScalecolorpt.PerformLayout()
        Me.grpScaleColorfiv.ResumeLayout(False)
        Me.grpScaleColorfiv.PerformLayout()
        Me.grpScalecolorExn.ResumeLayout(False)
        Me.grpScalecolorExn.PerformLayout()
        Me.grpScalecolorst.ResumeLayout(False)
        Me.grpScalecolorst.PerformLayout()
        Me.grpScalecolorEcon.ResumeLayout(False)
        Me.grpScalecolorEcon.PerformLayout()
        Me.grpScalecolorEx.ResumeLayout(False)
        Me.grpScalecolorEx.PerformLayout()
        Me.grpColourScaleGgthemes.ResumeLayout(False)
        Me.grpColourScaleGgthemes.PerformLayout()
        Me.grpScalecolorg.ResumeLayout(False)
        Me.grpScalecolorg.PerformLayout()
        Me.grpScalecolorpan.ResumeLayout(False)
        Me.grpScalecolorpan.PerformLayout()
        Me.grpScalecolorsol.ResumeLayout(False)
        Me.grpScalecolorsol.PerformLayout()
        Me.grpScalecolorfew.ResumeLayout(False)
        Me.grpScalecolorfew.PerformLayout()
        Me.grpScalecolorhc.ResumeLayout(False)
        Me.grpScalecolorhc.PerformLayout()
        Me.grpScalecolorcal.ResumeLayout(False)
        Me.grpScalecolorcal.PerformLayout()
        Me.grpScaleFillfiv.ResumeLayout(False)
        Me.grpScaleFillfiv.PerformLayout()
        Me.grpScalefillpt.ResumeLayout(False)
        Me.grpScalefillpt.PerformLayout()
        Me.grpScalefillw.ResumeLayout(False)
        Me.grpScalefillw.PerformLayout()
        Me.grpScalefillst.ResumeLayout(False)
        Me.grpScalefillst.PerformLayout()
        Me.grpScalefillpan.ResumeLayout(False)
        Me.grpScalefillpan.PerformLayout()
        Me.grpScalefillCal.ResumeLayout(False)
        Me.grpScalefillCal.PerformLayout()
        Me.grpScalefillg.ResumeLayout(False)
        Me.grpScalefillg.PerformLayout()
        Me.grpScalefillEx.ResumeLayout(False)
        Me.grpScalefillEx.PerformLayout()
        Me.grpScalefillEcon.ResumeLayout(False)
        Me.grpScalefillEcon.PerformLayout()
        Me.grpScalefillExn.ResumeLayout(False)
        Me.grpScalefillExn.PerformLayout()
        Me.grpScalefillsol.ResumeLayout(False)
        Me.grpScalefillsol.PerformLayout()
        Me.grpFillScaleggthemes.ResumeLayout(False)
        Me.grpFillScaleggthemes.PerformLayout()
        Me.grpScalefillfew.ResumeLayout(False)
        Me.grpScalefillfew.PerformLayout()
        Me.grpScalefillhc.ResumeLayout(False)
        Me.grpScalefillhc.PerformLayout()
        Me.grpScaleColorw.ResumeLayout(False)
        Me.grpScaleColorw.PerformLayout()
        Me.grpColourScale.ResumeLayout(False)
        Me.grpColourScale.PerformLayout()
        Me.grpFillScale.ResumeLayout(False)
        Me.grpFillScale.PerformLayout()
        Me.tbpAnnotation.ResumeLayout(False)
        Me.tbpAnnotation.PerformLayout()
        Me.grpAnnotation.ResumeLayout(False)
        Me.grpAnnotation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbpPlotsOptions As TabControl
    Friend WithEvents tbpTheme As TabPage
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tbpTitles As TabPage
    Friend WithEvents tbpFacet As TabPage
    Friend WithEvents tbpLayers As TabPage
    Friend WithEvents rdoHorizontal As RadioButton
    Friend WithEvents rdoVertical As RadioButton
    Friend WithEvents lblFactor2 As Label
    Friend WithEvents lblFactor1 As Label
    Friend WithEvents ucr2ndFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents tbpXAxis As TabPage
    Friend WithEvents tbpYAxis As TabPage
    Friend WithEvents ucrInputThemes As ucrInputComboBox
    Friend WithEvents cmdAllOptions As Button
    Friend WithEvents lblFont As Label
    Friend WithEvents ucrPlotsAdditionalLayers As ucrAdditionalLayers
    Friend WithEvents grpCommonOptions As GroupBox
    Friend WithEvents ucrFacetSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpLegendTitle As GroupBox
    Friend WithEvents rdoLegendTitleCustom As RadioButton
    Friend WithEvents rdoLegendTitleAuto As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents ucrInputGraphTitle As ucrInputTextBox
    Friend WithEvents ucrXAxis As ucrAxes
    Friend WithEvents ucrYAxis As ucrAxes
    Friend WithEvents ucrInputLegend As ucrInputTextBox
    Friend WithEvents tbpCoordinates As TabPage
    Friend WithEvents ucrChkNoOfRowsOrColumns As ucrCheck
    Friend WithEvents ucrChkIncludeFacets As ucrCheck
    Friend WithEvents ucrChkFreeSpace As ucrCheck
    Friend WithEvents ucrChkFreeScalesY As ucrCheck
    Friend WithEvents ucrChkFreeScalesX As ucrCheck
    Friend WithEvents ucrChkMargin As ucrCheck
    Friend WithEvents ucrPnlHorizonatalVertical As UcrPanel
    Friend WithEvents ucrNudNumberofRows As ucrNud
    Friend WithEvents ucrPnlLegendTitle As UcrPanel
    Friend WithEvents ucrChkDisplayLegendTitle As ucrCheck
    Friend WithEvents ucrChkOverwriteLegendTitle As ucrCheck
    Friend WithEvents lblCaption As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents ucrInputGraphSubTitle As ucrInputTextBox
    Friend WithEvents urChkSelectTheme As ucrCheck
    Friend WithEvents ucrChkHorizontalPlot As ucrCheck

    Friend WithEvents ucrChkYaxisTickMarkLabelSize As ucrCheck
    Friend WithEvents ucrChkXaxisTickMarkLabelSize As ucrCheck
    Friend WithEvents ucrChkYaxisSize As ucrCheck
    Friend WithEvents ucrChkXaxisSize As ucrCheck
    Friend WithEvents ucrChkXaxisAngle As ucrCheck
    Friend WithEvents ucrChkLegendPosition As ucrCheck
    Friend WithEvents ucrNudYSize As ucrNud
    Friend WithEvents ucrNudXSize As ucrNud
    Friend WithEvents ucrNudXAngle As ucrNud
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrNudYaxisMarkSize As ucrNud
    Friend WithEvents ucrNudXaxisMarkSize As ucrNud

    Friend WithEvents ucrChkLabeler As ucrCheck
    Friend WithEvents cmdSimpleOptions As Button
    Friend WithEvents ucrChkSameScale As ucrCheck
    Friend WithEvents ucrChkUsePolarCoordinates As ucrCheck
    Friend WithEvents ucrChkDirectionAnticlockwise As ucrCheck
    Friend WithEvents ucrInputStartingAngle As ucrInputTextBox
    Friend WithEvents lblPi As Label
    Friend WithEvents grpPolarCordinates As GroupBox
    Friend WithEvents lblStartingAngle As Label
    Friend WithEvents ucrInputPolarCoordinates As ucrInputComboBox
    Friend WithEvents lblPolarCoordinate As Label
    Friend WithEvents ucrChkDrop As ucrCheck
    Friend WithEvents tbpColour As TabPage
    Friend WithEvents grpFillScale As GroupBox
    Friend WithEvents lblFillScaleMapEnds As Label
    Friend WithEvents lblFillScaleBeginColour As Label
    Friend WithEvents lblFillScaleColourPalettte As Label
    Friend WithEvents lblFillScaleTransparency As Label
    Friend WithEvents ucrChkFillScaleReverseColourOrder As ucrCheck
    Friend WithEvents grpColourScale As GroupBox
    Friend WithEvents ucrNudColourScaleTransparency As ucrNud
    Friend WithEvents ucrInputColourScalePalette As ucrInputComboBox
    Friend WithEvents ucrNudColourScaleMapEnds As ucrNud
    Friend WithEvents ucrNudColourScaleMapBegins As ucrNud
    Friend WithEvents ucrChkColourScaleReverseOrder As ucrCheck
    Friend WithEvents lblColourScaleMapEnds As Label
    Friend WithEvents lblColourScaleMapBegins As Label
    Friend WithEvents lblColourScalePalette As Label
    Friend WithEvents lblColourScaleTransparency As Label
    Friend WithEvents ucrNudFillScaleTransparency As ucrNud
    Friend WithEvents ucrNudFillScaleMapEnds As ucrNud
    Friend WithEvents ucrNudFillScaleMapBegins As ucrNud
    Friend WithEvents ucrInputFillScaleColour As ucrInputComboBox
    Friend WithEvents ucrChkColourDiscrete As ucrCheck
    Friend WithEvents ucrChkFillDiscrete As ucrCheck
    Friend WithEvents tbpAnnotation As TabPage
    Friend WithEvents ucrNudAlpha As ucrNud
    Friend WithEvents lblAlpha As Label
    Friend WithEvents grpAnnotation As GroupBox
    Friend WithEvents lblCurvature As Label
    Friend WithEvents lblLineend As Label
    Friend WithEvents ucrInputLineend As ucrInputComboBox
    Friend WithEvents lblAngle As Label
    Friend WithEvents ucrNudAngle As ucrNud
    Friend WithEvents lblShape As Label
    Friend WithEvents lblAnnotationGeoms As Label
    Friend WithEvents ucrInputAnnotationGeoms As ucrInputComboBox
    Friend WithEvents lblSize As Label
    Friend WithEvents ucrNudSize As ucrNud
    Friend WithEvents lblColour As Label
    Friend WithEvents ucrInputX As ucrInputTextBox
    Friend WithEvents ucrInputY As ucrInputTextBox
    Friend WithEvents lblY As Label
    Friend WithEvents lblX As Label
    Friend WithEvents lblFill As Label
    Friend WithEvents lblXmax As Label
    Friend WithEvents ucrInputXmax As ucrInputTextBox
    Friend WithEvents ucrInputYmin As ucrInputTextBox
    Friend WithEvents ucrInputXmin As ucrInputTextBox
    Friend WithEvents lblYmin As Label
    Friend WithEvents lblXmin As Label
    Friend WithEvents lblXend As Label
    Friend WithEvents lblYmax As Label
    Friend WithEvents ucrInputYmax As ucrInputTextBox
    Friend WithEvents ucrInputYend As ucrInputTextBox
    Friend WithEvents ucrInputXend As ucrInputTextBox
    Friend WithEvents lblYend As Label
    Friend WithEvents lblPointrangeFatten As Label
    Friend WithEvents ucrNudPointrangeFatten As ucrNud
    Friend WithEvents ucrNudCrossbarFatten As ucrNud
    Friend WithEvents lblCrossbarFatten As Label
    Friend WithEvents ucrNudCurvature As ucrNud
    Friend WithEvents ucrNudShape As ucrNud
    Friend WithEvents ucrChkAnnotation As ucrCheck
    Friend WithEvents lblLabel As Label
    Friend WithEvents ucrInputLabel As ucrInputTextBox
    Friend WithEvents ucrNudLinetype As ucrNud
    Friend WithEvents lblLinetype As Label
    Friend WithEvents ucrReceiverY As ucrReceiverSingle
    Friend WithEvents ucrInputColour As ucrColors
    Friend WithEvents ucrInputFill As ucrColors
    Friend WithEvents ucrChkParse As ucrCheck
    Friend WithEvents lblLegendTitle As Label
    Friend WithEvents ucrInputLegendTitle As ucrInputTextBox
    Friend WithEvents lblTag As Label
    Friend WithEvents ucrInputTag As ucrInputTextBox
    Friend WithEvents lblCaptionSize As Label
    Friend WithEvents lblSubTitleSize As Label
    Friend WithEvents lblTitleSize As Label
    Friend WithEvents ucrNudCaptionSize As ucrNud
    Friend WithEvents ucrNudSubTitleSize As ucrNud
    Friend WithEvents ucrNudTitleSize As ucrNud
    Friend WithEvents ucrInputGraphCaption As ucrInputTextBox
    Friend WithEvents ttCaptionTitle As ToolTip
    Friend WithEvents ucrChkTag As ucrCheck
    Friend WithEvents ucrChkNewLegend As ucrCheck
    Friend WithEvents lblTagSize As Label
    Friend WithEvents ucrNudTagSize As ucrNud
    Friend WithEvents lblLegendSize As Label
    Friend WithEvents ucrNudLegendSize As ucrNud
    Friend WithEvents ucrChkIncludeTitles As ucrCheck
    Friend WithEvents lblCanvasColorPalette As Label
    Friend WithEvents ucrInputCanvasColorPalette As ucrInputComboBox
    Friend WithEvents lblGgthemesFunctions As Label
    Friend WithEvents ucrInputColorFunctions As ucrInputComboBox
    Friend WithEvents lblFillFunction As Label
    Friend WithEvents ucrInputFillFunction As ucrInputComboBox
    Friend WithEvents lblCanvasFillPalette As Label
    Friend WithEvents ucrInputCanvasFillPalette As ucrInputComboBox
    Friend WithEvents ucrChkUseFill As ucrCheck
    Friend WithEvents ucrChkUseColor As ucrCheck
    Friend WithEvents rdoGgthemes As RadioButton
    Friend WithEvents rdoViridis As RadioButton
    Friend WithEvents lblPalette As Label
    Friend WithEvents ucrInputPalettes As ucrInputComboBox
    Friend WithEvents rdoQualitative As RadioButton
    Friend WithEvents rdoSequential As RadioButton
    Friend WithEvents rdoDiverging As RadioButton
    Friend WithEvents ucrPnlColourPalette As UcrPanel
    Friend WithEvents ucrInputAxisType As ucrInputComboBox
    Friend WithEvents ucrChkAddColour As ucrCheck
    Friend WithEvents ucrChkAddFillScale As ucrCheck
    Friend WithEvents grpScalefillhc As GroupBox
    Friend WithEvents ucrInputPalettehc As ucrInputComboBox
    Friend WithEvents ucrChkPalettehc As ucrCheck
    Friend WithEvents ucrInputTextBreakshc As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValuehc As ucrInputTextBox
    Friend WithEvents ucrInputTextLimithc As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandhc As ucrInputTextBox
    Friend WithEvents ucrInputPositionhc As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelshc As ucrInputComboBox
    Friend WithEvents ucrChkExpandhc As ucrCheck
    Friend WithEvents ucrChkPositionhc As ucrCheck
    Friend WithEvents ucrChkLimithc As ucrCheck
    Friend WithEvents ucrChkBreakshc As ucrCheck
    Friend WithEvents ucrChkNaValuehc As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelshc As ucrCheck
    Friend WithEvents grpScaleColorw As GroupBox
    Friend WithEvents ucrInputPalettecolorw As ucrInputComboBox
    Friend WithEvents ucrChkPalettecolorw As ucrCheck
    Friend WithEvents ucrInputTextBreaksColorw As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueColorw As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitColorw As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandColorw As ucrInputTextBox
    Friend WithEvents ucrInputPositionColorw As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsColorw As ucrInputComboBox
    Friend WithEvents ucrChkExpandColorw As ucrCheck
    Friend WithEvents ucrChkPositionColorw As ucrCheck
    Friend WithEvents ucrChkLimitColorw As ucrCheck
    Friend WithEvents ucrChkBreaksColorw As ucrCheck
    Friend WithEvents ucrChkNaValueColorw As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsColorw As ucrCheck
    Friend WithEvents lblPalcontinuouscolor As Label
    Friend WithEvents ucrInputcontinuouscolor As ucrInputComboBox
    Friend WithEvents lblPaletteContinuousfill As Label
    Friend WithEvents ucrInputContinousfill As ucrInputComboBox
    Friend WithEvents grpScaleFillfiv As GroupBox
    Friend WithEvents ucrInputTextBreaksfiv As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValuefiv As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitfiv As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandfiv As ucrInputTextBox
    Friend WithEvents ucrInputPositionfiv As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsfiv As ucrInputComboBox
    Friend WithEvents ucrChkExpandfiv As ucrCheck
    Friend WithEvents ucrChkPositionfiv As ucrCheck
    Friend WithEvents ucrChkLimitfiv As ucrCheck
    Friend WithEvents ucrChkBreaksfiv As ucrCheck
    Friend WithEvents ucrChkNaValuefiv As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsfiv As ucrCheck
    Friend WithEvents grpScalefillpt As GroupBox
    Friend WithEvents ucrInputTextBreakspt As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValuept As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitpt As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandpt As ucrInputTextBox
    Friend WithEvents ucrInputPositionpt As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelspt As ucrInputComboBox
    Friend WithEvents ucrChkExpandpt As ucrCheck
    Friend WithEvents ucrChkPositionpt As ucrCheck
    Friend WithEvents ucrChkLimitpt As ucrCheck
    Friend WithEvents ucrChkBreakspt As ucrCheck
    Friend WithEvents ucrChkNaValuept As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelspt As ucrCheck
    Friend WithEvents grpScalefillw As GroupBox
    Friend WithEvents ucrInputPalettefillw As ucrInputComboBox
    Friend WithEvents ucrChkpalettefillw As ucrCheck
    Friend WithEvents ucrInputTextBreaksw As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValuew As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitw As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandw As ucrInputTextBox
    Friend WithEvents ucrInputPositionw As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsw As ucrInputComboBox
    Friend WithEvents ucrChkExpandw As ucrCheck
    Friend WithEvents ucrChkPositionw As ucrCheck
    Friend WithEvents ucrChkLimitw As ucrCheck
    Friend WithEvents ucrChkBreaksw As ucrCheck
    Friend WithEvents ucrChkNaValuew As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsw As ucrCheck
    Friend WithEvents grpScalefillst As GroupBox
    Friend WithEvents ucrInputSchemefill As ucrInputComboBox
    Friend WithEvents ucrChkSchemefill As ucrCheck
    Friend WithEvents ucrInputTextBreaksst As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValuest As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitst As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandst As ucrInputTextBox
    Friend WithEvents ucrInputPositionst As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsst As ucrInputComboBox
    Friend WithEvents ucrChkExpandst As ucrCheck
    Friend WithEvents ucrChkPositionst As ucrCheck
    Friend WithEvents ucrChkLimitst As ucrCheck
    Friend WithEvents ucrChkBreaksst As ucrCheck
    Friend WithEvents ucrChkNaValuest As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsst As ucrCheck
    Friend WithEvents grpScalefillpan As GroupBox
    Friend WithEvents ucrInputTextBreakspan As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValuepan As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitpan As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandpan As ucrInputTextBox
    Friend WithEvents ucrInputPositionpan As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelspan As ucrInputComboBox
    Friend WithEvents ucrChkExpandpan As ucrCheck
    Friend WithEvents ucrChkPositionpan As ucrCheck
    Friend WithEvents ucrChkLimitpan As ucrCheck
    Friend WithEvents ucrChkBreakspan As ucrCheck
    Friend WithEvents ucrChkNaValuepan As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelspan As ucrCheck
    Friend WithEvents grpScalefillCal As GroupBox
    Friend WithEvents ucrChkNaValueCal As ucrCheck
    Friend WithEvents ucrInputTextExpandCal As ucrInputTextBox
    Friend WithEvents ucrInputPositionCal As ucrInputComboBox
    Friend WithEvents ucrChkExpandCal As ucrCheck
    Friend WithEvents ucrChkPositionCal As ucrCheck
    Friend WithEvents ucrInputTextLimitCal As ucrInputTextBox
    Friend WithEvents ucrInputDropUnusedLevelsCal As ucrInputComboBox
    Friend WithEvents ucrChkDropUnusedLevelsCal As ucrCheck
    Friend WithEvents ucrChkBreaksCal As ucrCheck
    Friend WithEvents ucrChkLimitCal As ucrCheck
    Friend WithEvents ucrInputTextBreaksCal As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueCal As ucrInputTextBox
    Friend WithEvents grpScalefillg As GroupBox
    Friend WithEvents ucrInputTextBreaksg As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueg As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitg As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandg As ucrInputTextBox
    Friend WithEvents ucrInputPositiong As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsg As ucrInputComboBox
    Friend WithEvents ucrChkExpandg As ucrCheck
    Friend WithEvents ucrChkPositiong As ucrCheck
    Friend WithEvents ucrChkLimitg As ucrCheck
    Friend WithEvents ucrChkBreaksg As ucrCheck
    Friend WithEvents ucrChkNaValueg As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsg As ucrCheck
    Friend WithEvents grpScalefillEx As GroupBox
    Friend WithEvents ucrInputTextBreaksEx As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueEx As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitEx As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandEx As ucrInputTextBox
    Friend WithEvents ucrInputPositionEx As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsEx As ucrInputComboBox
    Friend WithEvents ucrChkExpandEx As ucrCheck
    Friend WithEvents ucrChkPositionEx As ucrCheck
    Friend WithEvents ucrChkLimitEx As ucrCheck
    Friend WithEvents ucrChkBreaksEx As ucrCheck
    Friend WithEvents ucrChkNaValueEx As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsEx As ucrCheck
    Friend WithEvents grpScalefillEcon As GroupBox
    Friend WithEvents ucrInputTextBreaksEcon As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueEcon As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitEcon As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandEcon As ucrInputTextBox
    Friend WithEvents ucrInputPositionEcon As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsEcon As ucrInputComboBox
    Friend WithEvents ucrChkExpandEcon As ucrCheck
    Friend WithEvents ucrChkPositionEcon As ucrCheck
    Friend WithEvents ucrChkLimitEcon As ucrCheck
    Friend WithEvents ucrChkBreaksEcon As ucrCheck
    Friend WithEvents ucrChkNaValueEcon As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsEcon As ucrCheck
    Friend WithEvents grpScalefillExn As GroupBox
    Friend WithEvents ucrInputThemeFill As ucrInputComboBox
    Friend WithEvents ucrChkThemeFill As ucrCheck
    Friend WithEvents ucrInputTextBreaksExn As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueExn As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitExn As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandExn As ucrInputTextBox
    Friend WithEvents ucrInputPositionExn As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsExn As ucrInputComboBox
    Friend WithEvents ucrChkExpandExn As ucrCheck
    Friend WithEvents ucrChkPositionExn As ucrCheck
    Friend WithEvents ucrChkLimitExn As ucrCheck
    Friend WithEvents ucrChkBreaksExn As ucrCheck
    Friend WithEvents ucrChkNaValueExn As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsExn As ucrCheck
    Friend WithEvents grpScalefillsol As GroupBox
    Friend WithEvents ucrInputTextBreakssol As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValuesol As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitsol As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandsol As ucrInputTextBox
    Friend WithEvents ucrInputPositionsol As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelssol As ucrInputComboBox
    Friend WithEvents ucrChkExpandsol As ucrCheck
    Friend WithEvents ucrChkPositionsol As ucrCheck
    Friend WithEvents ucrChkLimitsol As ucrCheck
    Friend WithEvents ucrChkBreakssol As ucrCheck
    Friend WithEvents ucrChkNaValuesol As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelssol As ucrCheck
    Friend WithEvents grpFillScaleggthemes As GroupBox
    Friend WithEvents ucrInputTextBreaks As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValue As ucrInputTextBox
    Friend WithEvents ucrInputTextLimit As ucrInputTextBox
    Friend WithEvents ucrInputTextExpand As ucrInputTextBox
    Friend WithEvents ucrInputPosition As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevels As ucrInputComboBox
    Friend WithEvents ucrChkExpand As ucrCheck
    Friend WithEvents ucrChkPosition As ucrCheck
    Friend WithEvents ucrChkLimit As ucrCheck
    Friend WithEvents ucrChkBreaks As ucrCheck
    Friend WithEvents ucrChkNaValue As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevels As ucrCheck
    Friend WithEvents grpScalefillfew As GroupBox
    Friend WithEvents ucrChkPalettefill As ucrCheck
    Friend WithEvents ucrInputPalettefill As ucrInputComboBox
    Friend WithEvents ucrInputTextBreaksfew As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValuefew As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitfew As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandfew As ucrInputTextBox
    Friend WithEvents ucrInputPositionfew As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsfew As ucrInputComboBox
    Friend WithEvents ucrChkExpandfew As ucrCheck
    Friend WithEvents ucrChkPositionfew As ucrCheck
    Friend WithEvents ucrChkLimitfew As ucrCheck
    Friend WithEvents ucrChkBreaksfew As ucrCheck
    Friend WithEvents ucrChkNaValuefew As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsfew As ucrCheck
    Friend WithEvents grpScaleColorfiv As GroupBox
    Friend WithEvents ucrInputTextBreaksColorfiv As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueColorfiv As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitColorfiv As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandColorfiv As ucrInputTextBox
    Friend WithEvents ucrInputPositionColorfiv As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsColorfiv As ucrInputComboBox
    Friend WithEvents ucrChkExpandColorfiv As ucrCheck
    Friend WithEvents ucrChkPositionColorfiv As ucrCheck
    Friend WithEvents ucrChkLimitColorfiv As ucrCheck
    Friend WithEvents ucrChkBreaksColorfiv As ucrCheck
    Friend WithEvents ucrChkNaValueColorfiv As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsColorfiv As ucrCheck
    Friend WithEvents grpScalecolorExn As GroupBox
    Friend WithEvents ucrInputThemeColor As ucrInputComboBox
    Friend WithEvents ucrChkThemecolor As ucrCheck
    Friend WithEvents ucrInputTextBreaksColorExn As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandColorExn As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitColorExn As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueColorExn As ucrInputTextBox
    Friend WithEvents ucrInputPositionColorExn As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsColorExn As ucrInputComboBox
    Friend WithEvents ucrChkNaValueColorExn As ucrCheck
    Friend WithEvents ucrChkPositionColorExn As ucrCheck
    Friend WithEvents ucrChkLimitColorExn As ucrCheck
    Friend WithEvents ucrChkBreaksColorExn As ucrCheck
    Friend WithEvents ucrChkExpandColorExn As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsColorExn As ucrCheck
    Friend WithEvents grpScalecolorst As GroupBox
    Friend WithEvents ucrInputSchemecolor As ucrInputComboBox
    Friend WithEvents ucrChkSchemecolor As ucrCheck
    Friend WithEvents ucrInputTextBreaksColorst As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueColorst As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitColorst As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandColorst As ucrInputTextBox
    Friend WithEvents ucrInputPositionColorst As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsColorst As ucrInputComboBox
    Friend WithEvents ucrChkExpandColorst As ucrCheck
    Friend WithEvents ucrChkPositionColorst As ucrCheck
    Friend WithEvents ucrChkLimitColorst As ucrCheck
    Friend WithEvents ucrChkBreaksColorst As ucrCheck
    Friend WithEvents ucrChkNaValueColorst As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsColorst As ucrCheck
    Friend WithEvents grpScalecolorEcon As GroupBox
    Friend WithEvents ucrInputTextBreaksColorEcon As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueColorEcon As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitColorEcon As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandColorEcon As ucrInputTextBox
    Friend WithEvents ucrInputPositionColorEcon As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsColorEcon As ucrInputComboBox
    Friend WithEvents ucrChkExpandColorEcon As ucrCheck
    Friend WithEvents ucrChkPositionColorEcon As ucrCheck
    Friend WithEvents ucrChkLimitColorEcon As ucrCheck
    Friend WithEvents ucrChkBreaksColorEcon As ucrCheck
    Friend WithEvents ucrChkNaValueColorEcon As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsColorEcon As ucrCheck
    Friend WithEvents grpScalecolorEx As GroupBox
    Friend WithEvents ucrInputTextBreaksColorEx As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueColorEx As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitColorEx As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandColorEx As ucrInputTextBox
    Friend WithEvents ucrInputPositionColorEx As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsColorEx As ucrInputComboBox
    Friend WithEvents ucrChkExpandColorEx As ucrCheck
    Friend WithEvents ucrChkPositionColorEx As ucrCheck
    Friend WithEvents ucrChkLimitColorEx As ucrCheck
    Friend WithEvents ucrChkBreaksColorEx As ucrCheck
    Friend WithEvents ucrChkNaValueColorEx As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsColorEx As ucrCheck
    Friend WithEvents grpColourScaleGgthemes As GroupBox
    Friend WithEvents ucrInputTextBreaksColor As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueColor As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitColor As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandColor As ucrInputTextBox
    Friend WithEvents ucrInputPositionColor As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsColor As ucrInputComboBox
    Friend WithEvents ucrChkExpandColor As ucrCheck
    Friend WithEvents ucrChkPositionColor As ucrCheck
    Friend WithEvents ucrChkLimitColor As ucrCheck
    Friend WithEvents ucrChkBreaksColor As ucrCheck
    Friend WithEvents ucrChkNaValueColor As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsColor As ucrCheck
    Friend WithEvents grpScalecolorg As GroupBox
    Friend WithEvents ucrInputTextBreaksColorg As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueColorg As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitColorg As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandColorg As ucrInputTextBox
    Friend WithEvents ucrInputPositionColorg As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsColorg As ucrInputComboBox
    Friend WithEvents ucrChkExpandColorg As ucrCheck
    Friend WithEvents ucrChkPositionColorg As ucrCheck
    Friend WithEvents ucrChkLimitColorg As ucrCheck
    Friend WithEvents ucrChkBreaksColorg As ucrCheck
    Friend WithEvents ucrChkNaValueColorg As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsColorg As ucrCheck
    Friend WithEvents grpScalecolorpan As GroupBox
    Friend WithEvents ucrInputTextBreaksColorpan As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueColorpan As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitColorpan As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandColorpan As ucrInputTextBox
    Friend WithEvents ucrInputPositionColorpan As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsColorpan As ucrInputComboBox
    Friend WithEvents ucrChkExpandColorpan As ucrCheck
    Friend WithEvents ucrChkPositionColorpan As ucrCheck
    Friend WithEvents ucrChkLimitColorpan As ucrCheck
    Friend WithEvents ucrChkBreaksColorpan As ucrCheck
    Friend WithEvents ucrChkNaValueColorpan As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsColorpan As ucrCheck
    Friend WithEvents grpScalecolorsol As GroupBox
    Friend WithEvents ucrInputTextBreaksColorsol As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueColorsol As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitColorsol As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandColorsol As ucrInputTextBox
    Friend WithEvents ucrInputPositionColorsol As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsColorsol As ucrInputComboBox
    Friend WithEvents ucrChkExpandColorsol As ucrCheck
    Friend WithEvents ucrChkPositionColorsol As ucrCheck
    Friend WithEvents ucrChkLimitColorsol As ucrCheck
    Friend WithEvents ucrChkBreaksColorsol As ucrCheck
    Friend WithEvents ucrChkNaValueColorsol As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsColorsol As ucrCheck
    Friend WithEvents grpScalecolorfew As GroupBox
    Friend WithEvents ucrInputPalettecolor As ucrInputComboBox
    Friend WithEvents ucrChkPalettecolor As ucrCheck
    Friend WithEvents ucrInputTextBreaksColorfew As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandColorfew As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitColorfew As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueColorfew As ucrInputTextBox
    Friend WithEvents ucrInputPositionColorfew As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsColorfew As ucrInputComboBox
    Friend WithEvents ucrChkNaValueColorfew As ucrCheck
    Friend WithEvents ucrChkPositionColorfew As ucrCheck
    Friend WithEvents ucrChkLimitColorfew As ucrCheck
    Friend WithEvents ucrChkBreaksColorfew As ucrCheck
    Friend WithEvents ucrChkExpandColorfew As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsColorfew As ucrCheck
    Friend WithEvents grpScalecolorhc As GroupBox
    Friend WithEvents ucrInputPalettecolorhc As ucrInputComboBox
    Friend WithEvents ucrChkPalettecolorhc As ucrCheck
    Friend WithEvents ucrInputTextBreaksColorhc As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueColorhc As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitColorhc As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandColorhc As ucrInputTextBox
    Friend WithEvents ucrInputPositionColorhc As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsColorhc As ucrInputComboBox
    Friend WithEvents ucrChkExpandColorhc As ucrCheck
    Friend WithEvents ucrChkPositionColorhc As ucrCheck
    Friend WithEvents ucrChkLimitColorhc As ucrCheck
    Friend WithEvents ucrChkBreaksColorhc As ucrCheck
    Friend WithEvents ucrChkNaValueColorhc As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsColorhc As ucrCheck
    Friend WithEvents grpScalecolorcal As GroupBox
    Friend WithEvents ucrInputTextBreaksColorCal As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueColorCal As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitColorCal As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandColorCal As ucrInputTextBox
    Friend WithEvents ucrInputPositionColorCal As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsColorCal As ucrInputComboBox
    Friend WithEvents ucrChkExpandColorCal As ucrCheck
    Friend WithEvents ucrChkPositionColorCal As ucrCheck
    Friend WithEvents ucrChkLimitColorCal As ucrCheck
    Friend WithEvents ucrChkBreaksColorCal As ucrCheck
    Friend WithEvents ucrChkNaValueColorCal As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsColorCal As ucrCheck
    Friend WithEvents grpScalecolorpt As GroupBox
    Friend WithEvents ucrInputTextBreaksColorpt As ucrInputTextBox
    Friend WithEvents ucrInputTextNaValueColorpt As ucrInputTextBox
    Friend WithEvents ucrInputTextLimitColorpt As ucrInputTextBox
    Friend WithEvents ucrInputTextExpandColorpt As ucrInputTextBox
    Friend WithEvents ucrInputPositionColorpt As ucrInputComboBox
    Friend WithEvents ucrInputDropUnusedLevelsColorpt As ucrInputComboBox
    Friend WithEvents ucrChkExpandColorpt As ucrCheck
    Friend WithEvents ucrChkPositionColorpt As ucrCheck
    Friend WithEvents ucrChkLimitColorpt As ucrCheck
    Friend WithEvents ucrChkBreaksColorpt As ucrCheck
    Friend WithEvents ucrChkNaValueColorpt As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevelsColorpt As ucrCheck
    Friend WithEvents lblPaletteContinuous As Label
    Friend WithEvents ucrInputPaletteContinuous As ucrInputComboBox
End Class


