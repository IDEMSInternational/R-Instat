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
Partial Class sdgSimpleRegOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgSimpleRegOptions))
        Me.tbGraphics = New System.Windows.Forms.TabPage()
        Me.tcGraphics = New System.Windows.Forms.TabControl()
        Me.tbModel = New System.Windows.Forms.TabPage()
        Me.ucrNudWhiteSpace = New instat.ucrNud()
        Me.ucrNudGraphicsCLevel = New instat.ucrNud()
        Me.ucrChkRugs = New instat.ucrCheck()
        Me.ucrChkJitter = New instat.ucrCheck()
        Me.ucrChkPartial = New instat.ucrCheck()
        Me.ucrChkConfIntervalband = New instat.ucrCheck()
        Me.ucrChkFittedModel = New instat.ucrCheck()
        Me.grpRugs = New System.Windows.Forms.GroupBox()
        Me.rdoPartial = New System.Windows.Forms.RadioButton()
        Me.rdo1 = New System.Windows.Forms.RadioButton()
        Me.rdo2 = New System.Windows.Forms.RadioButton()
        Me.ucrPnlPartial12 = New instat.UcrPanel()
        Me.lblWhiteSpace = New System.Windows.Forms.Label()
        Me.lblGraphicsSignLevel = New System.Windows.Forms.Label()
        Me.grpPlotType = New System.Windows.Forms.GroupBox()
        Me.rdoContrast = New System.Windows.Forms.RadioButton()
        Me.rdoConditional = New System.Windows.Forms.RadioButton()
        Me.ucrPnlPlotType = New instat.UcrPanel()
        Me.grpScale = New System.Windows.Forms.GroupBox()
        Me.rdoResponse = New System.Windows.Forms.RadioButton()
        Me.rdoLinear = New System.Windows.Forms.RadioButton()
        Me.ucrPnlScale = New instat.UcrPanel()
        Me.tbResiduals = New System.Windows.Forms.TabPage()
        Me.grpMultiplePlots = New System.Windows.Forms.GroupBox()
        Me.rdoSixPlots = New System.Windows.Forms.RadioButton()
        Me.rdoFourPlots = New System.Windows.Forms.RadioButton()
        Me.rdoChooseIndividual = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMutiplePlots = New instat.UcrPanel()
        Me.grpIndividualPlots = New System.Windows.Forms.GroupBox()
        Me.ucrChkCooksDistance = New instat.ucrCheck()
        Me.ucrChkResidualsFitted = New instat.ucrCheck()
        Me.ucrChkScaleLocation = New instat.ucrCheck()
        Me.ucrChkResidualsLeverage = New instat.ucrCheck()
        Me.ucrChkQQ = New instat.ucrCheck()
        Me.ucrChkCooksDistanceLeverage = New instat.ucrCheck()
        Me.ucrChkResidualPlots = New instat.ucrCheck()
        Me.tbDisplay = New System.Windows.Forms.TabPage()
        Me.ucrNudConfLevel = New instat.ucrNud()
        Me.ucrChkPvalues = New instat.ucrCheck()
        Me.ucrChkEstimates = New instat.ucrCheck()
        Me.ucrChkConfLimits = New instat.ucrCheck()
        Me.ucrChkANOVA = New instat.ucrCheck()
        Me.ucrChkModel = New instat.ucrCheck()
        Me.lblConfLevel = New System.Windows.Forms.Label()
        Me.tbpRegOptions = New System.Windows.Forms.TabControl()
        Me.tbSave = New System.Windows.Forms.TabPage()
        Me.ucrSaveLeverageColumnName = New instat.ucrSave()
        Me.ucrSaveStdResidualsColumnName = New instat.ucrSave()
        Me.ucrSaveResidualsColumnName = New instat.ucrSave()
        Me.ucrSaveFittedColumnName = New instat.ucrSave()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.tbGraphics.SuspendLayout()
        Me.tcGraphics.SuspendLayout()
        Me.tbModel.SuspendLayout()
        Me.grpRugs.SuspendLayout()
        Me.grpPlotType.SuspendLayout()
        Me.grpScale.SuspendLayout()
        Me.tbResiduals.SuspendLayout()
        Me.grpMultiplePlots.SuspendLayout()
        Me.grpIndividualPlots.SuspendLayout()
        Me.tbDisplay.SuspendLayout()
        Me.tbpRegOptions.SuspendLayout()
        Me.tbSave.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbGraphics
        '
        Me.tbGraphics.Controls.Add(Me.tcGraphics)
        resources.ApplyResources(Me.tbGraphics, "tbGraphics")
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Tag = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'tcGraphics
        '
        Me.tcGraphics.Controls.Add(Me.tbModel)
        Me.tcGraphics.Controls.Add(Me.tbResiduals)
        resources.ApplyResources(Me.tcGraphics, "tcGraphics")
        Me.tcGraphics.Name = "tcGraphics"
        Me.tcGraphics.SelectedIndex = 0
        '
        'tbModel
        '
        resources.ApplyResources(Me.tbModel, "tbModel")
        Me.tbModel.Controls.Add(Me.ucrNudWhiteSpace)
        Me.tbModel.Controls.Add(Me.ucrNudGraphicsCLevel)
        Me.tbModel.Controls.Add(Me.ucrChkRugs)
        Me.tbModel.Controls.Add(Me.ucrChkJitter)
        Me.tbModel.Controls.Add(Me.ucrChkPartial)
        Me.tbModel.Controls.Add(Me.ucrChkConfIntervalband)
        Me.tbModel.Controls.Add(Me.ucrChkFittedModel)
        Me.tbModel.Controls.Add(Me.grpRugs)
        Me.tbModel.Controls.Add(Me.lblWhiteSpace)
        Me.tbModel.Controls.Add(Me.lblGraphicsSignLevel)
        Me.tbModel.Controls.Add(Me.grpPlotType)
        Me.tbModel.Controls.Add(Me.grpScale)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Tag = "Model"
        Me.tbModel.UseVisualStyleBackColor = True
        '
        'ucrNudWhiteSpace
        '
        Me.ucrNudWhiteSpace.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWhiteSpace.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudWhiteSpace, "ucrNudWhiteSpace")
        Me.ucrNudWhiteSpace.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWhiteSpace.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWhiteSpace.Name = "ucrNudWhiteSpace"
        Me.ucrNudWhiteSpace.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudGraphicsCLevel
        '
        Me.ucrNudGraphicsCLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudGraphicsCLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudGraphicsCLevel, "ucrNudGraphicsCLevel")
        Me.ucrNudGraphicsCLevel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudGraphicsCLevel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudGraphicsCLevel.Name = "ucrNudGraphicsCLevel"
        Me.ucrNudGraphicsCLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkRugs
        '
        Me.ucrChkRugs.Checked = False
        resources.ApplyResources(Me.ucrChkRugs, "ucrChkRugs")
        Me.ucrChkRugs.Name = "ucrChkRugs"
        '
        'ucrChkJitter
        '
        Me.ucrChkJitter.Checked = False
        resources.ApplyResources(Me.ucrChkJitter, "ucrChkJitter")
        Me.ucrChkJitter.Name = "ucrChkJitter"
        '
        'ucrChkPartial
        '
        Me.ucrChkPartial.Checked = False
        resources.ApplyResources(Me.ucrChkPartial, "ucrChkPartial")
        Me.ucrChkPartial.Name = "ucrChkPartial"
        '
        'ucrChkConfIntervalband
        '
        Me.ucrChkConfIntervalband.Checked = False
        resources.ApplyResources(Me.ucrChkConfIntervalband, "ucrChkConfIntervalband")
        Me.ucrChkConfIntervalband.Name = "ucrChkConfIntervalband"
        '
        'ucrChkFittedModel
        '
        Me.ucrChkFittedModel.Checked = False
        resources.ApplyResources(Me.ucrChkFittedModel, "ucrChkFittedModel")
        Me.ucrChkFittedModel.Name = "ucrChkFittedModel"
        '
        'grpRugs
        '
        Me.grpRugs.Controls.Add(Me.rdoPartial)
        Me.grpRugs.Controls.Add(Me.rdo1)
        Me.grpRugs.Controls.Add(Me.rdo2)
        Me.grpRugs.Controls.Add(Me.ucrPnlPartial12)
        resources.ApplyResources(Me.grpRugs, "grpRugs")
        Me.grpRugs.Name = "grpRugs"
        Me.grpRugs.TabStop = False
        '
        'rdoPartial
        '
        resources.ApplyResources(Me.rdoPartial, "rdoPartial")
        Me.rdoPartial.Name = "rdoPartial"
        Me.rdoPartial.TabStop = True
        Me.rdoPartial.Tag = "Partial"
        Me.rdoPartial.UseVisualStyleBackColor = True
        '
        'rdo1
        '
        resources.ApplyResources(Me.rdo1, "rdo1")
        Me.rdo1.Name = "rdo1"
        Me.rdo1.TabStop = True
        Me.rdo1.Tag = "1"
        Me.rdo1.UseVisualStyleBackColor = True
        '
        'rdo2
        '
        resources.ApplyResources(Me.rdo2, "rdo2")
        Me.rdo2.Name = "rdo2"
        Me.rdo2.TabStop = True
        Me.rdo2.Tag = "2"
        Me.rdo2.UseVisualStyleBackColor = True
        '
        'ucrPnlPartial12
        '
        resources.ApplyResources(Me.ucrPnlPartial12, "ucrPnlPartial12")
        Me.ucrPnlPartial12.Name = "ucrPnlPartial12"
        '
        'lblWhiteSpace
        '
        resources.ApplyResources(Me.lblWhiteSpace, "lblWhiteSpace")
        Me.lblWhiteSpace.Name = "lblWhiteSpace"
        Me.lblWhiteSpace.Tag = "White_Space:"
        '
        'lblGraphicsSignLevel
        '
        resources.ApplyResources(Me.lblGraphicsSignLevel, "lblGraphicsSignLevel")
        Me.lblGraphicsSignLevel.Name = "lblGraphicsSignLevel"
        Me.lblGraphicsSignLevel.Tag = "Significance_Level:"
        '
        'grpPlotType
        '
        Me.grpPlotType.Controls.Add(Me.rdoContrast)
        Me.grpPlotType.Controls.Add(Me.rdoConditional)
        Me.grpPlotType.Controls.Add(Me.ucrPnlPlotType)
        resources.ApplyResources(Me.grpPlotType, "grpPlotType")
        Me.grpPlotType.Name = "grpPlotType"
        Me.grpPlotType.TabStop = False
        Me.grpPlotType.Tag = "Plot_type"
        '
        'rdoContrast
        '
        resources.ApplyResources(Me.rdoContrast, "rdoContrast")
        Me.rdoContrast.Name = "rdoContrast"
        Me.rdoContrast.Tag = "Contrast"
        Me.rdoContrast.UseVisualStyleBackColor = True
        '
        'rdoConditional
        '
        resources.ApplyResources(Me.rdoConditional, "rdoConditional")
        Me.rdoConditional.Name = "rdoConditional"
        Me.rdoConditional.Tag = "Conditional"
        Me.rdoConditional.UseVisualStyleBackColor = True
        '
        'ucrPnlPlotType
        '
        resources.ApplyResources(Me.ucrPnlPlotType, "ucrPnlPlotType")
        Me.ucrPnlPlotType.Name = "ucrPnlPlotType"
        '
        'grpScale
        '
        Me.grpScale.Controls.Add(Me.rdoResponse)
        Me.grpScale.Controls.Add(Me.rdoLinear)
        Me.grpScale.Controls.Add(Me.ucrPnlScale)
        resources.ApplyResources(Me.grpScale, "grpScale")
        Me.grpScale.Name = "grpScale"
        Me.grpScale.TabStop = False
        Me.grpScale.Tag = "Scale"
        '
        'rdoResponse
        '
        resources.ApplyResources(Me.rdoResponse, "rdoResponse")
        Me.rdoResponse.Name = "rdoResponse"
        Me.rdoResponse.TabStop = True
        Me.rdoResponse.Tag = "Response"
        Me.rdoResponse.UseVisualStyleBackColor = True
        '
        'rdoLinear
        '
        resources.ApplyResources(Me.rdoLinear, "rdoLinear")
        Me.rdoLinear.Name = "rdoLinear"
        Me.rdoLinear.TabStop = True
        Me.rdoLinear.Tag = "Linear"
        Me.rdoLinear.UseVisualStyleBackColor = True
        '
        'ucrPnlScale
        '
        resources.ApplyResources(Me.ucrPnlScale, "ucrPnlScale")
        Me.ucrPnlScale.Name = "ucrPnlScale"
        '
        'tbResiduals
        '
        Me.tbResiduals.Controls.Add(Me.grpMultiplePlots)
        Me.tbResiduals.Controls.Add(Me.grpIndividualPlots)
        Me.tbResiduals.Controls.Add(Me.ucrChkResidualPlots)
        resources.ApplyResources(Me.tbResiduals, "tbResiduals")
        Me.tbResiduals.Name = "tbResiduals"
        Me.tbResiduals.Tag = "Residuals"
        Me.tbResiduals.UseVisualStyleBackColor = True
        '
        'grpMultiplePlots
        '
        Me.grpMultiplePlots.Controls.Add(Me.rdoSixPlots)
        Me.grpMultiplePlots.Controls.Add(Me.rdoFourPlots)
        Me.grpMultiplePlots.Controls.Add(Me.rdoChooseIndividual)
        Me.grpMultiplePlots.Controls.Add(Me.ucrPnlMutiplePlots)
        resources.ApplyResources(Me.grpMultiplePlots, "grpMultiplePlots")
        Me.grpMultiplePlots.Name = "grpMultiplePlots"
        Me.grpMultiplePlots.TabStop = False
        Me.grpMultiplePlots.Tag = ""
        '
        'rdoSixPlots
        '
        resources.ApplyResources(Me.rdoSixPlots, "rdoSixPlots")
        Me.rdoSixPlots.Name = "rdoSixPlots"
        Me.rdoSixPlots.TabStop = True
        Me.rdoSixPlots.Tag = "Six Plots"
        Me.rdoSixPlots.UseVisualStyleBackColor = True
        '
        'rdoFourPlots
        '
        resources.ApplyResources(Me.rdoFourPlots, "rdoFourPlots")
        Me.rdoFourPlots.Name = "rdoFourPlots"
        Me.rdoFourPlots.TabStop = True
        Me.rdoFourPlots.Tag = "Four_Plots"
        Me.rdoFourPlots.UseVisualStyleBackColor = True
        '
        'rdoChooseIndividual
        '
        resources.ApplyResources(Me.rdoChooseIndividual, "rdoChooseIndividual")
        Me.rdoChooseIndividual.Name = "rdoChooseIndividual"
        Me.rdoChooseIndividual.TabStop = True
        Me.rdoChooseIndividual.Tag = ""
        Me.rdoChooseIndividual.UseVisualStyleBackColor = True
        '
        'ucrPnlMutiplePlots
        '
        resources.ApplyResources(Me.ucrPnlMutiplePlots, "ucrPnlMutiplePlots")
        Me.ucrPnlMutiplePlots.Name = "ucrPnlMutiplePlots"
        '
        'grpIndividualPlots
        '
        Me.grpIndividualPlots.Controls.Add(Me.ucrChkCooksDistance)
        Me.grpIndividualPlots.Controls.Add(Me.ucrChkResidualsFitted)
        Me.grpIndividualPlots.Controls.Add(Me.ucrChkScaleLocation)
        Me.grpIndividualPlots.Controls.Add(Me.ucrChkResidualsLeverage)
        Me.grpIndividualPlots.Controls.Add(Me.ucrChkQQ)
        Me.grpIndividualPlots.Controls.Add(Me.ucrChkCooksDistanceLeverage)
        resources.ApplyResources(Me.grpIndividualPlots, "grpIndividualPlots")
        Me.grpIndividualPlots.Name = "grpIndividualPlots"
        Me.grpIndividualPlots.TabStop = False
        Me.grpIndividualPlots.Tag = ""
        '
        'ucrChkCooksDistance
        '
        Me.ucrChkCooksDistance.Checked = False
        resources.ApplyResources(Me.ucrChkCooksDistance, "ucrChkCooksDistance")
        Me.ucrChkCooksDistance.Name = "ucrChkCooksDistance"
        '
        'ucrChkResidualsFitted
        '
        Me.ucrChkResidualsFitted.Checked = False
        resources.ApplyResources(Me.ucrChkResidualsFitted, "ucrChkResidualsFitted")
        Me.ucrChkResidualsFitted.Name = "ucrChkResidualsFitted"
        '
        'ucrChkScaleLocation
        '
        Me.ucrChkScaleLocation.Checked = False
        resources.ApplyResources(Me.ucrChkScaleLocation, "ucrChkScaleLocation")
        Me.ucrChkScaleLocation.Name = "ucrChkScaleLocation"
        '
        'ucrChkResidualsLeverage
        '
        Me.ucrChkResidualsLeverage.Checked = False
        resources.ApplyResources(Me.ucrChkResidualsLeverage, "ucrChkResidualsLeverage")
        Me.ucrChkResidualsLeverage.Name = "ucrChkResidualsLeverage"
        '
        'ucrChkQQ
        '
        Me.ucrChkQQ.Checked = False
        resources.ApplyResources(Me.ucrChkQQ, "ucrChkQQ")
        Me.ucrChkQQ.Name = "ucrChkQQ"
        '
        'ucrChkCooksDistanceLeverage
        '
        Me.ucrChkCooksDistanceLeverage.Checked = False
        resources.ApplyResources(Me.ucrChkCooksDistanceLeverage, "ucrChkCooksDistanceLeverage")
        Me.ucrChkCooksDistanceLeverage.Name = "ucrChkCooksDistanceLeverage"
        '
        'ucrChkResidualPlots
        '
        Me.ucrChkResidualPlots.Checked = False
        resources.ApplyResources(Me.ucrChkResidualPlots, "ucrChkResidualPlots")
        Me.ucrChkResidualPlots.Name = "ucrChkResidualPlots"
        '
        'tbDisplay
        '
        Me.tbDisplay.Controls.Add(Me.ucrNudConfLevel)
        Me.tbDisplay.Controls.Add(Me.ucrChkPvalues)
        Me.tbDisplay.Controls.Add(Me.ucrChkEstimates)
        Me.tbDisplay.Controls.Add(Me.ucrChkConfLimits)
        Me.tbDisplay.Controls.Add(Me.ucrChkANOVA)
        Me.tbDisplay.Controls.Add(Me.ucrChkModel)
        Me.tbDisplay.Controls.Add(Me.lblConfLevel)
        resources.ApplyResources(Me.tbDisplay, "tbDisplay")
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.Tag = "Display"
        Me.tbDisplay.UseVisualStyleBackColor = True
        '
        'ucrNudConfLevel
        '
        Me.ucrNudConfLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConfLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudConfLevel, "ucrNudConfLevel")
        Me.ucrNudConfLevel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudConfLevel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConfLevel.Name = "ucrNudConfLevel"
        Me.ucrNudConfLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkPvalues
        '
        Me.ucrChkPvalues.Checked = False
        resources.ApplyResources(Me.ucrChkPvalues, "ucrChkPvalues")
        Me.ucrChkPvalues.Name = "ucrChkPvalues"
        '
        'ucrChkEstimates
        '
        Me.ucrChkEstimates.Checked = False
        resources.ApplyResources(Me.ucrChkEstimates, "ucrChkEstimates")
        Me.ucrChkEstimates.Name = "ucrChkEstimates"
        '
        'ucrChkConfLimits
        '
        Me.ucrChkConfLimits.Checked = False
        resources.ApplyResources(Me.ucrChkConfLimits, "ucrChkConfLimits")
        Me.ucrChkConfLimits.Name = "ucrChkConfLimits"
        '
        'ucrChkANOVA
        '
        Me.ucrChkANOVA.Checked = False
        resources.ApplyResources(Me.ucrChkANOVA, "ucrChkANOVA")
        Me.ucrChkANOVA.Name = "ucrChkANOVA"
        '
        'ucrChkModel
        '
        Me.ucrChkModel.Checked = False
        resources.ApplyResources(Me.ucrChkModel, "ucrChkModel")
        Me.ucrChkModel.Name = "ucrChkModel"
        '
        'lblConfLevel
        '
        resources.ApplyResources(Me.lblConfLevel, "lblConfLevel")
        Me.lblConfLevel.Name = "lblConfLevel"
        Me.lblConfLevel.Tag = "Confidence_Level:"
        '
        'tbpRegOptions
        '
        Me.tbpRegOptions.Controls.Add(Me.tbDisplay)
        Me.tbpRegOptions.Controls.Add(Me.tbGraphics)
        Me.tbpRegOptions.Controls.Add(Me.tbSave)
        resources.ApplyResources(Me.tbpRegOptions, "tbpRegOptions")
        Me.tbpRegOptions.Name = "tbpRegOptions"
        Me.tbpRegOptions.SelectedIndex = 0
        '
        'tbSave
        '
        Me.tbSave.Controls.Add(Me.ucrSaveLeverageColumnName)
        Me.tbSave.Controls.Add(Me.ucrSaveStdResidualsColumnName)
        Me.tbSave.Controls.Add(Me.ucrSaveResidualsColumnName)
        Me.tbSave.Controls.Add(Me.ucrSaveFittedColumnName)
        resources.ApplyResources(Me.tbSave, "tbSave")
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Tag = "Save"
        Me.tbSave.UseVisualStyleBackColor = True
        '
        'ucrSaveLeverageColumnName
        '
        resources.ApplyResources(Me.ucrSaveLeverageColumnName, "ucrSaveLeverageColumnName")
        Me.ucrSaveLeverageColumnName.Name = "ucrSaveLeverageColumnName"
        '
        'ucrSaveStdResidualsColumnName
        '
        resources.ApplyResources(Me.ucrSaveStdResidualsColumnName, "ucrSaveStdResidualsColumnName")
        Me.ucrSaveStdResidualsColumnName.Name = "ucrSaveStdResidualsColumnName"
        '
        'ucrSaveResidualsColumnName
        '
        resources.ApplyResources(Me.ucrSaveResidualsColumnName, "ucrSaveResidualsColumnName")
        Me.ucrSaveResidualsColumnName.Name = "ucrSaveResidualsColumnName"
        '
        'ucrSaveFittedColumnName
        '
        resources.ApplyResources(Me.ucrSaveFittedColumnName, "ucrSaveFittedColumnName")
        Me.ucrSaveFittedColumnName.Name = "ucrSaveFittedColumnName"
        '
        'ucrSdgButtons
        '
        resources.ApplyResources(Me.ucrSdgButtons, "ucrSdgButtons")
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        '
        'sdgSimpleRegOptions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbpRegOptions)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSimpleRegOptions"
        Me.Tag = "Graph_and_Display_Options"
        Me.tbGraphics.ResumeLayout(False)
        Me.tcGraphics.ResumeLayout(False)
        Me.tbModel.ResumeLayout(False)
        Me.tbModel.PerformLayout()
        Me.grpRugs.ResumeLayout(False)
        Me.grpRugs.PerformLayout()
        Me.grpPlotType.ResumeLayout(False)
        Me.grpPlotType.PerformLayout()
        Me.grpScale.ResumeLayout(False)
        Me.grpScale.PerformLayout()
        Me.tbResiduals.ResumeLayout(False)
        Me.grpMultiplePlots.ResumeLayout(False)
        Me.grpMultiplePlots.PerformLayout()
        Me.grpIndividualPlots.ResumeLayout(False)
        Me.tbDisplay.ResumeLayout(False)
        Me.tbDisplay.PerformLayout()
        Me.tbpRegOptions.ResumeLayout(False)
        Me.tbSave.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents tbGraphics As TabPage
    Friend WithEvents nudGraphicsCLevel As NumericUpDown
    Friend WithEvents lblGraphicsSignLevel As Label
    Friend WithEvents grpMultiplePlots As GroupBox
    Friend WithEvents tbDisplay As TabPage
    Friend WithEvents lblConfLevel As Label
    Friend WithEvents chkPvalues As CheckBox
    Friend WithEvents tbpRegOptions As TabControl
    Friend WithEvents tbSave As TabPage
    Friend WithEvents grpPlotType As GroupBox
    Friend WithEvents grpScale As GroupBox
    Friend WithEvents nudWhiteSpace As NumericUpDown
    Friend WithEvents lblWhiteSpace As Label
    Friend WithEvents grpRugs As GroupBox
    Friend WithEvents tcGraphics As TabControl
    Friend WithEvents tbModel As TabPage
    Friend WithEvents tbResiduals As TabPage
    Friend WithEvents grpIndividualPlots As GroupBox
    Friend WithEvents ucrChkEstimates As ucrCheck
    Friend WithEvents ucrChkConfLimits As ucrCheck
    Friend WithEvents ucrChkANOVA As ucrCheck
    Friend WithEvents ucrChkModel As ucrCheck
    Friend WithEvents ucrNudConfLevel As ucrNud
    Friend WithEvents ucrChkPvalues As ucrCheck
    Friend WithEvents ucrChkRugs As ucrCheck
    Friend WithEvents ucrChkJitter As ucrCheck
    Friend WithEvents ucrChkPartial As ucrCheck
    Friend WithEvents ucrChkConfIntervalband As ucrCheck
    Friend WithEvents ucrChkFittedModel As ucrCheck
    Friend WithEvents rdoResponse As RadioButton
    Friend WithEvents rdoLinear As RadioButton
    Friend WithEvents ucrPnlScale As UcrPanel
    Friend WithEvents rdoContrast As RadioButton
    Friend WithEvents rdoConditional As RadioButton
    Friend WithEvents ucrPnlPlotType As UcrPanel
    Friend WithEvents rdoPartial As RadioButton
    Friend WithEvents rdo1 As RadioButton
    Friend WithEvents rdo2 As RadioButton
    Friend WithEvents ucrPnlPartial12 As UcrPanel
    Friend WithEvents ucrChkResidualPlots As ucrCheck
    Friend WithEvents rdoSixPlots As RadioButton
    Friend WithEvents rdoFourPlots As RadioButton
    Friend WithEvents rdoChooseIndividual As RadioButton
    Friend WithEvents ucrPnlMutiplePlots As UcrPanel
    Friend WithEvents ucrSaveFittedColumnName As ucrSave
    Friend WithEvents ucrSaveLeverageColumnName As ucrSave
    Friend WithEvents ucrSaveStdResidualsColumnName As ucrSave
    Friend WithEvents ucrSaveResidualsColumnName As ucrSave
    Friend WithEvents ucrNudWhiteSpace As ucrNud
    Friend WithEvents ucrChkCooksDistance As ucrCheck
    Friend WithEvents ucrChkScaleLocation As ucrCheck
    Friend WithEvents ucrChkQQ As ucrCheck
    Friend WithEvents ucrChkResidualsLeverage As ucrCheck
    Friend WithEvents ucrChkCooksDistanceLeverage As ucrCheck
    Friend WithEvents ucrChkResidualsFitted As ucrCheck
    Friend WithEvents ucrNudGraphicsCLevel As ucrNud
End Class