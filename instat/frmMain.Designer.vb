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
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuDescribe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeOneVariable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeOneVariableSummarise = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeOneVariableGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeOneVariableFrequencies = New System.Windows.Forms.ToolStripMenuItem()
        Me.RatingDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeTwoVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeTwoVariablesSummarise = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeTwoVariablesGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeTwoVariablesFrequencies = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeThreeVariable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeThreeVariableSummarise = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeThreeVariableGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator36 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeThreeVariableFrequencies = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecific = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificFrequency = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificMultipleResponse = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator26 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeSpecificScatterPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificLinePlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificHistogram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificBoxplot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificDotPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificRugPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificBarChart = New System.Windows.Forms.ToolStripMenuItem()
        Me.CummulativeDistributionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificParallelCoordinatePlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificMosaic = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeGeneralColumnSummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescribeGeneralTabulation = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescribeGeneralGraphics = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator38 = New System.Windows.Forms.ToolStripSeparator()
        Me.FrequencyTablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeMultivariate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeMultivariateCorrelations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeMultivariateprincipalComponents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeMultivariateCanonicalCorrelations = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeUseGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeCombineGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeThemes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeViewGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelProbabilityDistributions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelProbabilityDistributionsShowModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelProbabilityDistributionsCompareModels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelProbabilityDistributionsRandomSamplesUseModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuModelOneVariable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOneVariableFitModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOneVariableCompareModels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOneVariableUseModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelTwoVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelTwoVariablesFitModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelTwoVariablesChooseModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelTwoVariablesUseModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelThreeVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelThreeVariablesFitModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelThreeVariablesChooseModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelThreeVariablesUseModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelFourVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelFourVariablesFitModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelFourVariablesChooseModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelFourVariablesUseModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelGeneralFitModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelGeneralChooseModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelGeneralUseModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuModelHypothesisTests = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherOneVariable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherOneVariableExactResults = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherOneVariableSampleSummaryData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherOneVariableNonParametric = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherOneVariableGoodnessofFit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherTwoVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherTwoVariablesTwoSamples = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherTwoVariablesSummaryData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherTwoVariablesSimpleRegression = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherTwoVariablesOneWayANOVA = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherTwoVariablesNonParametricOneWayANOVA = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherThreeVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherThreeVariablesSimpleWithGroups = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherThreeVariablesChisquareTest = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherGeneralANOVAGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherGeneralRegression = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelOtherGeneralLogLinear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticExamine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticProcess = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticEvaporation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticEvaporationSite = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticEvaporationPenman = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCrop = New System.Windows.Forms.ToolStripMenuItem()
        Me.CropCoefficientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WaterSatisfactionIndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticHeatSum = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewDataView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewOutputWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewScriptWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewColumnMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewDataFrameMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuViewClimaticMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewProcurementMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewOptionsByContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator39 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuViewResetToDefaultLayout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpHelpIntroduction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpHistFAQ = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpSpreadsheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpGetingStarted = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator28 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelpMenus = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpR = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpRPackagesCommands = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpDataset = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator29 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelpGuide = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpGuidesCaseStudy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpGuideGlosary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuhelpGuidesMore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAboutRInstat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpLicence = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAcknowledgments = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.mnuClimatic = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticFileOpensst = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticFileImportGriddedData = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenNetCDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticFileImportShapeFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateFileClimSoft = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticFileCliData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticFileExportToCPT = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticTidyandExamine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineTidyDailyData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineNonNumericCases = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineReplaceValues = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineMerge = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator50 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticTidyandExamineOneVariableSummarize = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDatesGenerateDates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDatesMakeDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDatesInfillMissingDates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDatesUseDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDatesMakeTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDatesUseTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDefineClimaticData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCheckData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCheckDataStationMaps = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator51 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticCheckDataInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCheckDataDisplayDaily = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCheckDataBoxplot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCheckDataQCRainfall = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCheckDataQCTemperatures = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepare = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCimaticPrepareTransform = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareConversions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareCompare = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator37 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticPrepareClimaticSummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareStartoftheRains = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareEndOfRains = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareLengthOfSeason = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareSpells = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareExtremes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator46 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticPrepareEvapotranspiration = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareNewWorksheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareImportDailyData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareMakeFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareShiftDailyData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareUnstackDailyData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareStackDailyData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimdex = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator30 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticDescribe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDescribeRainfall = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDescribeTemperatures = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDescribeWindSpeedDirection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDescribeWindSpeedDirectionWindRose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDescribeSunshineRadiation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticDescribeGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticPICSA = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPICSARainfall = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPICSATemperature = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPICSACrops = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMSAF = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCMSAFPlotRegion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCMSAFExporttoCMSAFRToolbox = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticModels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticModelsExtremes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticModelsCircular = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticModelsMarkovModelling = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticSCF = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticSCFSupportOpenSST = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticSCFSupportExporttoCPT = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator32 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticSCFSupportCorrelations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticSCFSupportPrincipalComponents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticSCFSupportCanonicalCorrelations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticSCFSupportCumulativeExceedanceGraphs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethods = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationStartOfRain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationEndOfRain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationChangeFormatDayMonth = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationExportCPTToTabular = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationDayMonth = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationDisplayDaily = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationDisplayDOYOfYear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationDisplayRainRunningTotal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationDisplaySpellLength = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationExportForPICSA = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationExtremeEvents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationMissingData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationMissingDataTable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationMonthlySummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationOutputForCD = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsGraphics = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsGraphicsClipBoxPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsGraphicsCliplot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsGraphicsMissingValues = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsGraphicsHistogram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsGraphicsCumExceedance = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsGraphicsBoxplot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsGraphicsInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsGraphicsAnnualRainfall = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsGraphicsRainCount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsGraphicsTimeseries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsGraphicsWindrose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsGraphicsMultipleLines = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClmateMethodThreeSummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsAdditional = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsAdditionalOutputForCPT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsAdditionalRainsStatistics = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsAdditionalSeasonalSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsAdditionalSeasonalSummaryRain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsAdditionalWaterBalance = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsCreateClimateObject = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAsDataAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAsOutputAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAsLogAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAsScriptAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilePrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlSeparatorFile3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFIleExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditFindNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopySpecial = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.stsStrip = New System.Windows.Forms.StatusStrip()
        Me.tstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tool_strip = New System.Windows.Forms.ToolStrip()
        Me.mnuTbOpen = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuTbOpenFromLibrary = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbSave = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbCopy = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbPaste = New System.Windows.Forms.ToolStripButton()
        Me.separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbEditLastDialog = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbLast10Dialogs = New System.Windows.Forms.ToolStripDropDownButton()
        Me.sepStart = New System.Windows.Forms.ToolStripSeparator()
        Me.sepEnd = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbLastGraph = New System.Windows.Forms.ToolStripButton()
        Me.separator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbDataView = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbOutput = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbColumnMetadata = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbLog = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbResetLayout = New System.Windows.Forms.ToolStripButton()
        Me.separator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbHelp = New System.Windows.Forms.ToolStripButton()
        Me.mnuBar = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNewDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpenFromFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpenFromLibrary = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuImportFromODK = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFromCSPROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFromToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenNETcdfFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator27 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileConvert = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlSeparatorFile = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportDataSetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportRObjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportRWorkspaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportGraphAsImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileCloseData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepare = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameViewData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameRenameColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameRowNumbersNames = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareDataFrameSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameReplaceValues = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareDataFrameConvertColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameColumnMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameColumnStructure = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareDataFrameReorderColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameInsertColumnsRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameDeleteColumnsRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameProtectColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameHideColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameFreezeColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColourByPropertyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataDuplicates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataCompareColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataNonNumericCases = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator49 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareCheckDataBoxplot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataOneVariableSummarise = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataOneVariableGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataOneWayFrequencies = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator41 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareCheckDataExportOpenRefine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataImportOpenRefine = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator40 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPreparePrepareToShareJitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCheckDataPrePareToShareSdcPackage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataAnonymiseIDColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareColumnCalculate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnCalculateCalculations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnCalculateColumnSummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnCalculateGeneralSummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator24 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareCalculateDuplicateColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnCalculateTransform = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnCalculateRank = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnCalculatePolynomials = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnCalculateRowSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnGenerate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnGenerateRegularSequence = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnGenerateCountInFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator25 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareColumnGenerateEnter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnGenerateRandomSamples = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnGeneratePermuteRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactorConvertToFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactorRecodeNumeric = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareColumnFactorRecodeFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactorCombineFactors = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactorDummyVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareColumnFactorLevelsLabels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareFactorViewLabels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactorReorderLevels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactorReferenceLevel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactorUnusedLevels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactorContrasts = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareColumnFactorFactorDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnTextFindReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnTextTransform = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnTextSplit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnTextCombine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnTextMatch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnTextDistance = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnGenerateDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnMakeDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnInfillMissingDates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnUseDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnMakeTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnUseTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnReshape = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnReshapeColumnSummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnReshapeGeneralSummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareColumnReshapeStack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnReshapeUnstack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnReshapeMerge = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareAppendDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnReshapeSubset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnReshapeRandomSubset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnReshapeTranspose = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareKeysAndLinks = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareKeysAndLinksAddKey = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareKeysAndLinksViewAndRemoveKey = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareKeysAndLinksAddLink = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareKeysAndLinksViewAndRemoveKeys = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareKeysAndLinksAddComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataObject = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataObjectDataFrameMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataObjectRenameDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataObjectReorderDataFrames = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataObjectCopyDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataObjectDeleteDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareDataObjectHideDataframes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataObjectMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataObjectRenameMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataObjectReorderMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataObjectDeleteMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareRObjects = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareRObjectsView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareRObjectsRename = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareRObjectsReorder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareRObjectsDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurement = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementDefineData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementPrepare = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementPrepareFilterByCountry = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator42 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuProcurementPrepareDefineContractValueCategories = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementPrepareRecodeNumericIntoQuantiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementPrepareSetFactorReferenceLevel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementPrepareUseAwardDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator43 = New System.Windows.Forms.ToolStripSeparator()
        Me.SummariseRedFlagsByCountryorOtherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummariseRedFlagsByCountryAndYearorOtherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementPrepareMergeAdditionalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementDescribe = New System.Windows.Forms.ToolStripMenuItem()
        Me.OneVariableSummariseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OneVariableGraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementDescribeOneVar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator44 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuProcurementDescribeTwoVar = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorrelationsRedFlagsOrOthersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MappingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapCountryValuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementDefineCorruption = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementModelFitModelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator45 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuProcurementDefineRedFlags = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementUseCRI = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementCalculateCRI = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementUseCRISummariseCRIbyCountry = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContext = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextCheckData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextCheckDataDuplicates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextCheckDataCompareColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator47 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOptionsByContextCheckDataOneVariableSummarise = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextCheckDataOneVariableGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextCheckDataOneVariableFrequencies = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextDefineOptionsByContexts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextPrepare = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator48 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOptionsByContextMergeAdditionalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextPrepareStack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextPrepareUnstack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextDescribe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextDescribeCompareTwoTreatments = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextDescribeCompareMultipleTreatments = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextDescribeBoxplot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextModelFitModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextGeneralFitModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsRunRCode = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsRestartR = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsCheckForUpdates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsClearOutputWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuToolsSaveCurrentOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsLoadOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.splOverall = New System.Windows.Forms.SplitContainer()
        Me.splExtraWindows = New System.Windows.Forms.SplitContainer()
        Me.splMetadata = New System.Windows.Forms.SplitContainer()
        Me.ucrColumnMeta = New instat.ucrColumnMetadata()
        Me.ucrDataFrameMeta = New instat.ucrDataFrameMetadata()
        Me.splLogScript = New System.Windows.Forms.SplitContainer()
        Me.ucrLogWindow = New instat.ucrLog()
        Me.ucrScriptWindow = New instat.ucrScript()
        Me.splDataOutput = New System.Windows.Forms.SplitContainer()
        Me.ucrDataViewer = New instat.ucrDataView()
        Me.ucrOutput = New instat.ucrOutputWindow()
        Me.mnuClimaticModelSPI = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsStrip.SuspendLayout()
        Me.Tool_strip.SuspendLayout()
        Me.mnuBar.SuspendLayout()
        CType(Me.splOverall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splOverall.Panel1.SuspendLayout()
        Me.splOverall.Panel2.SuspendLayout()
        Me.splOverall.SuspendLayout()
        CType(Me.splExtraWindows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splExtraWindows.Panel1.SuspendLayout()
        Me.splExtraWindows.Panel2.SuspendLayout()
        Me.splExtraWindows.SuspendLayout()
        CType(Me.splMetadata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splMetadata.Panel1.SuspendLayout()
        Me.splMetadata.Panel2.SuspendLayout()
        Me.splMetadata.SuspendLayout()
        CType(Me.splLogScript, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splLogScript.Panel1.SuspendLayout()
        Me.splLogScript.Panel2.SuspendLayout()
        Me.splLogScript.SuspendLayout()
        CType(Me.splDataOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splDataOutput.Panel1.SuspendLayout()
        Me.splDataOutput.Panel2.SuspendLayout()
        Me.splDataOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuDescribe
        '
        Me.mnuDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeOneVariable, Me.mnuDescribeTwoVariables, Me.mnuDescribeThreeVariable, Me.mnuDescribeSpecific, Me.mnuDescribeGeneral, Me.ToolStripSeparator9, Me.mnuDescribeMultivariate, Me.ToolStripSeparator13, Me.mnuDescribeUseGraph, Me.mnuDescribeCombineGraph, Me.mnuDescribeThemes, Me.mnuDescribeViewGraph})
        Me.mnuDescribe.Name = "mnuDescribe"
        resources.ApplyResources(Me.mnuDescribe, "mnuDescribe")
        Me.mnuDescribe.Tag = "Describe"
        '
        'mnuDescribeOneVariable
        '
        Me.mnuDescribeOneVariable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeOneVariableSummarise, Me.mnuDescribeOneVariableGraph, Me.ToolStripSeparator33, Me.mnuDescribeOneVariableFrequencies, Me.RatingDataToolStripMenuItem})
        Me.mnuDescribeOneVariable.Name = "mnuDescribeOneVariable"
        resources.ApplyResources(Me.mnuDescribeOneVariable, "mnuDescribeOneVariable")
        Me.mnuDescribeOneVariable.Tag = "One_Variable"
        '
        'mnuDescribeOneVariableSummarise
        '
        Me.mnuDescribeOneVariableSummarise.Name = "mnuDescribeOneVariableSummarise"
        resources.ApplyResources(Me.mnuDescribeOneVariableSummarise, "mnuDescribeOneVariableSummarise")
        Me.mnuDescribeOneVariableSummarise.Tag = "Summarise..."
        '
        'mnuDescribeOneVariableGraph
        '
        Me.mnuDescribeOneVariableGraph.Name = "mnuDescribeOneVariableGraph"
        resources.ApplyResources(Me.mnuDescribeOneVariableGraph, "mnuDescribeOneVariableGraph")
        Me.mnuDescribeOneVariableGraph.Tag = "Graph..."
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        resources.ApplyResources(Me.ToolStripSeparator33, "ToolStripSeparator33")
        '
        'mnuDescribeOneVariableFrequencies
        '
        Me.mnuDescribeOneVariableFrequencies.Name = "mnuDescribeOneVariableFrequencies"
        resources.ApplyResources(Me.mnuDescribeOneVariableFrequencies, "mnuDescribeOneVariableFrequencies")
        '
        'RatingDataToolStripMenuItem
        '
        Me.RatingDataToolStripMenuItem.Name = "RatingDataToolStripMenuItem"
        resources.ApplyResources(Me.RatingDataToolStripMenuItem, "RatingDataToolStripMenuItem")
        '
        'mnuDescribeTwoVariables
        '
        Me.mnuDescribeTwoVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeTwoVariablesSummarise, Me.mnuDescribeTwoVariablesGraph, Me.ToolStripSeparator34, Me.mnuDescribeTwoVariablesFrequencies})
        Me.mnuDescribeTwoVariables.Name = "mnuDescribeTwoVariables"
        resources.ApplyResources(Me.mnuDescribeTwoVariables, "mnuDescribeTwoVariables")
        Me.mnuDescribeTwoVariables.Tag = "Two_Variables"
        '
        'mnuDescribeTwoVariablesSummarise
        '
        Me.mnuDescribeTwoVariablesSummarise.DoubleClickEnabled = True
        Me.mnuDescribeTwoVariablesSummarise.Name = "mnuDescribeTwoVariablesSummarise"
        resources.ApplyResources(Me.mnuDescribeTwoVariablesSummarise, "mnuDescribeTwoVariablesSummarise")
        Me.mnuDescribeTwoVariablesSummarise.Tag = "Summarise..."
        '
        'mnuDescribeTwoVariablesGraph
        '
        Me.mnuDescribeTwoVariablesGraph.Name = "mnuDescribeTwoVariablesGraph"
        resources.ApplyResources(Me.mnuDescribeTwoVariablesGraph, "mnuDescribeTwoVariablesGraph")
        Me.mnuDescribeTwoVariablesGraph.Tag = "Graph..."
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        resources.ApplyResources(Me.ToolStripSeparator34, "ToolStripSeparator34")
        '
        'mnuDescribeTwoVariablesFrequencies
        '
        Me.mnuDescribeTwoVariablesFrequencies.DoubleClickEnabled = True
        Me.mnuDescribeTwoVariablesFrequencies.Name = "mnuDescribeTwoVariablesFrequencies"
        resources.ApplyResources(Me.mnuDescribeTwoVariablesFrequencies, "mnuDescribeTwoVariablesFrequencies")
        '
        'mnuDescribeThreeVariable
        '
        Me.mnuDescribeThreeVariable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeThreeVariableSummarise, Me.mnuDescribeThreeVariableGraph, Me.ToolStripSeparator36, Me.mnuDescribeThreeVariableFrequencies})
        Me.mnuDescribeThreeVariable.Name = "mnuDescribeThreeVariable"
        resources.ApplyResources(Me.mnuDescribeThreeVariable, "mnuDescribeThreeVariable")
        '
        'mnuDescribeThreeVariableSummarise
        '
        resources.ApplyResources(Me.mnuDescribeThreeVariableSummarise, "mnuDescribeThreeVariableSummarise")
        Me.mnuDescribeThreeVariableSummarise.Name = "mnuDescribeThreeVariableSummarise"
        '
        'mnuDescribeThreeVariableGraph
        '
        resources.ApplyResources(Me.mnuDescribeThreeVariableGraph, "mnuDescribeThreeVariableGraph")
        Me.mnuDescribeThreeVariableGraph.Name = "mnuDescribeThreeVariableGraph"
        '
        'ToolStripSeparator36
        '
        Me.ToolStripSeparator36.Name = "ToolStripSeparator36"
        resources.ApplyResources(Me.ToolStripSeparator36, "ToolStripSeparator36")
        '
        'mnuDescribeThreeVariableFrequencies
        '
        Me.mnuDescribeThreeVariableFrequencies.Name = "mnuDescribeThreeVariableFrequencies"
        resources.ApplyResources(Me.mnuDescribeThreeVariableFrequencies, "mnuDescribeThreeVariableFrequencies")
        '
        'mnuDescribeSpecific
        '
        Me.mnuDescribeSpecific.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeSpecificFrequency, Me.mnuDescribeSpecificSummary, Me.mnuDescribeSpecificMultipleResponse, Me.ToolStripSeparator26, Me.mnuDescribeSpecificScatterPlot, Me.mnuDescribeSpecificLinePlot, Me.mnuDescribeSpecificHistogram, Me.mnuDescribeSpecificBoxplot, Me.mnuDescribeSpecificDotPlot, Me.mnuDescribeSpecificRugPlot, Me.mnuDescribeSpecificBarChart, Me.CummulativeDistributionToolStripMenuItem, Me.mnuDescribeSpecificParallelCoordinatePlot, Me.mnuDescribeSpecificMosaic})
        Me.mnuDescribeSpecific.Name = "mnuDescribeSpecific"
        resources.ApplyResources(Me.mnuDescribeSpecific, "mnuDescribeSpecific")
        Me.mnuDescribeSpecific.Tag = "Table_Dialogs"
        '
        'mnuDescribeSpecificFrequency
        '
        Me.mnuDescribeSpecificFrequency.Name = "mnuDescribeSpecificFrequency"
        resources.ApplyResources(Me.mnuDescribeSpecificFrequency, "mnuDescribeSpecificFrequency")
        Me.mnuDescribeSpecificFrequency.Tag = "Frequency..."
        '
        'mnuDescribeSpecificSummary
        '
        Me.mnuDescribeSpecificSummary.Name = "mnuDescribeSpecificSummary"
        resources.ApplyResources(Me.mnuDescribeSpecificSummary, "mnuDescribeSpecificSummary")
        Me.mnuDescribeSpecificSummary.Tag = "Summary..."
        '
        'mnuDescribeSpecificMultipleResponse
        '
        resources.ApplyResources(Me.mnuDescribeSpecificMultipleResponse, "mnuDescribeSpecificMultipleResponse")
        Me.mnuDescribeSpecificMultipleResponse.Name = "mnuDescribeSpecificMultipleResponse"
        Me.mnuDescribeSpecificMultipleResponse.Tag = "Multiple_Response..."
        '
        'ToolStripSeparator26
        '
        Me.ToolStripSeparator26.Name = "ToolStripSeparator26"
        resources.ApplyResources(Me.ToolStripSeparator26, "ToolStripSeparator26")
        '
        'mnuDescribeSpecificScatterPlot
        '
        Me.mnuDescribeSpecificScatterPlot.Name = "mnuDescribeSpecificScatterPlot"
        resources.ApplyResources(Me.mnuDescribeSpecificScatterPlot, "mnuDescribeSpecificScatterPlot")
        Me.mnuDescribeSpecificScatterPlot.Tag = "Scatter_Plot..."
        '
        'mnuDescribeSpecificLinePlot
        '
        Me.mnuDescribeSpecificLinePlot.Name = "mnuDescribeSpecificLinePlot"
        resources.ApplyResources(Me.mnuDescribeSpecificLinePlot, "mnuDescribeSpecificLinePlot")
        Me.mnuDescribeSpecificLinePlot.Tag = "Line_Plot..."
        '
        'mnuDescribeSpecificHistogram
        '
        Me.mnuDescribeSpecificHistogram.Name = "mnuDescribeSpecificHistogram"
        resources.ApplyResources(Me.mnuDescribeSpecificHistogram, "mnuDescribeSpecificHistogram")
        Me.mnuDescribeSpecificHistogram.Tag = "Histogram..."
        '
        'mnuDescribeSpecificBoxplot
        '
        Me.mnuDescribeSpecificBoxplot.Name = "mnuDescribeSpecificBoxplot"
        resources.ApplyResources(Me.mnuDescribeSpecificBoxplot, "mnuDescribeSpecificBoxplot")
        Me.mnuDescribeSpecificBoxplot.Tag = "Boxplot..."
        '
        'mnuDescribeSpecificDotPlot
        '
        resources.ApplyResources(Me.mnuDescribeSpecificDotPlot, "mnuDescribeSpecificDotPlot")
        Me.mnuDescribeSpecificDotPlot.Name = "mnuDescribeSpecificDotPlot"
        Me.mnuDescribeSpecificDotPlot.Tag = "Dotplot..."
        '
        'mnuDescribeSpecificRugPlot
        '
        Me.mnuDescribeSpecificRugPlot.Name = "mnuDescribeSpecificRugPlot"
        resources.ApplyResources(Me.mnuDescribeSpecificRugPlot, "mnuDescribeSpecificRugPlot")
        '
        'mnuDescribeSpecificBarChart
        '
        Me.mnuDescribeSpecificBarChart.Name = "mnuDescribeSpecificBarChart"
        resources.ApplyResources(Me.mnuDescribeSpecificBarChart, "mnuDescribeSpecificBarChart")
        Me.mnuDescribeSpecificBarChart.Tag = "Bar_Chart"
        '
        'CummulativeDistributionToolStripMenuItem
        '
        Me.CummulativeDistributionToolStripMenuItem.Name = "CummulativeDistributionToolStripMenuItem"
        resources.ApplyResources(Me.CummulativeDistributionToolStripMenuItem, "CummulativeDistributionToolStripMenuItem")
        '
        'mnuDescribeSpecificParallelCoordinatePlot
        '
        Me.mnuDescribeSpecificParallelCoordinatePlot.Name = "mnuDescribeSpecificParallelCoordinatePlot"
        resources.ApplyResources(Me.mnuDescribeSpecificParallelCoordinatePlot, "mnuDescribeSpecificParallelCoordinatePlot")
        '
        'mnuDescribeSpecificMosaic
        '
        resources.ApplyResources(Me.mnuDescribeSpecificMosaic, "mnuDescribeSpecificMosaic")
        Me.mnuDescribeSpecificMosaic.Name = "mnuDescribeSpecificMosaic"
        '
        'mnuDescribeGeneral
        '
        Me.mnuDescribeGeneral.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeGeneralColumnSummaries, Me.DescribeGeneralTabulation, Me.DescribeGeneralGraphics, Me.ToolStripSeparator38, Me.FrequencyTablesToolStripMenuItem})
        Me.mnuDescribeGeneral.Name = "mnuDescribeGeneral"
        resources.ApplyResources(Me.mnuDescribeGeneral, "mnuDescribeGeneral")
        Me.mnuDescribeGeneral.Tag = "General"
        '
        'mnuDescribeGeneralColumnSummaries
        '
        Me.mnuDescribeGeneralColumnSummaries.Name = "mnuDescribeGeneralColumnSummaries"
        resources.ApplyResources(Me.mnuDescribeGeneralColumnSummaries, "mnuDescribeGeneralColumnSummaries")
        Me.mnuDescribeGeneralColumnSummaries.Tag = "Column_Summaries..."
        '
        'DescribeGeneralTabulation
        '
        resources.ApplyResources(Me.DescribeGeneralTabulation, "DescribeGeneralTabulation")
        Me.DescribeGeneralTabulation.Name = "DescribeGeneralTabulation"
        Me.DescribeGeneralTabulation.Tag = "Tabulation..."
        '
        'DescribeGeneralGraphics
        '
        Me.DescribeGeneralGraphics.Name = "DescribeGeneralGraphics"
        resources.ApplyResources(Me.DescribeGeneralGraphics, "DescribeGeneralGraphics")
        Me.DescribeGeneralGraphics.Tag = "Graphics..."
        '
        'ToolStripSeparator38
        '
        Me.ToolStripSeparator38.Name = "ToolStripSeparator38"
        resources.ApplyResources(Me.ToolStripSeparator38, "ToolStripSeparator38")
        '
        'FrequencyTablesToolStripMenuItem
        '
        Me.FrequencyTablesToolStripMenuItem.Name = "FrequencyTablesToolStripMenuItem"
        resources.ApplyResources(Me.FrequencyTablesToolStripMenuItem, "FrequencyTablesToolStripMenuItem")
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        resources.ApplyResources(Me.ToolStripSeparator9, "ToolStripSeparator9")
        '
        'mnuDescribeMultivariate
        '
        Me.mnuDescribeMultivariate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeMultivariateCorrelations, Me.mnuDescribeMultivariateprincipalComponents, Me.mnuDescribeMultivariateCanonicalCorrelations})
        Me.mnuDescribeMultivariate.Name = "mnuDescribeMultivariate"
        resources.ApplyResources(Me.mnuDescribeMultivariate, "mnuDescribeMultivariate")
        '
        'mnuDescribeMultivariateCorrelations
        '
        Me.mnuDescribeMultivariateCorrelations.Name = "mnuDescribeMultivariateCorrelations"
        resources.ApplyResources(Me.mnuDescribeMultivariateCorrelations, "mnuDescribeMultivariateCorrelations")
        '
        'mnuDescribeMultivariateprincipalComponents
        '
        Me.mnuDescribeMultivariateprincipalComponents.Name = "mnuDescribeMultivariateprincipalComponents"
        resources.ApplyResources(Me.mnuDescribeMultivariateprincipalComponents, "mnuDescribeMultivariateprincipalComponents")
        '
        'mnuDescribeMultivariateCanonicalCorrelations
        '
        Me.mnuDescribeMultivariateCanonicalCorrelations.Name = "mnuDescribeMultivariateCanonicalCorrelations"
        resources.ApplyResources(Me.mnuDescribeMultivariateCanonicalCorrelations, "mnuDescribeMultivariateCanonicalCorrelations")
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        resources.ApplyResources(Me.ToolStripSeparator13, "ToolStripSeparator13")
        '
        'mnuDescribeUseGraph
        '
        Me.mnuDescribeUseGraph.Name = "mnuDescribeUseGraph"
        resources.ApplyResources(Me.mnuDescribeUseGraph, "mnuDescribeUseGraph")
        '
        'mnuDescribeCombineGraph
        '
        Me.mnuDescribeCombineGraph.Name = "mnuDescribeCombineGraph"
        resources.ApplyResources(Me.mnuDescribeCombineGraph, "mnuDescribeCombineGraph")
        '
        'mnuDescribeThemes
        '
        resources.ApplyResources(Me.mnuDescribeThemes, "mnuDescribeThemes")
        Me.mnuDescribeThemes.Name = "mnuDescribeThemes"
        '
        'mnuDescribeViewGraph
        '
        Me.mnuDescribeViewGraph.Name = "mnuDescribeViewGraph"
        resources.ApplyResources(Me.mnuDescribeViewGraph, "mnuDescribeViewGraph")
        '
        'mnuModel
        '
        Me.mnuModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelProbabilityDistributions, Me.ToolStripSeparator3, Me.mnuModelOneVariable, Me.mnuModelTwoVariables, Me.mnuModelThreeVariables, Me.mnuModelFourVariables, Me.mnuModelGeneral, Me.ToolStripSeparator4, Me.mnuModelHypothesisTests, Me.mnuModelOtherOneVariable, Me.mnuModelOtherTwoVariables, Me.mnuModelOtherThreeVariables, Me.mnuModelOtherGeneral})
        Me.mnuModel.Name = "mnuModel"
        resources.ApplyResources(Me.mnuModel, "mnuModel")
        Me.mnuModel.Tag = "Model"
        '
        'mnuModelProbabilityDistributions
        '
        Me.mnuModelProbabilityDistributions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelProbabilityDistributionsShowModel, Me.mnuModelProbabilityDistributionsCompareModels, Me.mnuModelProbabilityDistributionsRandomSamplesUseModel})
        Me.mnuModelProbabilityDistributions.Name = "mnuModelProbabilityDistributions"
        resources.ApplyResources(Me.mnuModelProbabilityDistributions, "mnuModelProbabilityDistributions")
        Me.mnuModelProbabilityDistributions.Tag = "Probability_Distributions"
        '
        'mnuModelProbabilityDistributionsShowModel
        '
        Me.mnuModelProbabilityDistributionsShowModel.Name = "mnuModelProbabilityDistributionsShowModel"
        resources.ApplyResources(Me.mnuModelProbabilityDistributionsShowModel, "mnuModelProbabilityDistributionsShowModel")
        '
        'mnuModelProbabilityDistributionsCompareModels
        '
        resources.ApplyResources(Me.mnuModelProbabilityDistributionsCompareModels, "mnuModelProbabilityDistributionsCompareModels")
        Me.mnuModelProbabilityDistributionsCompareModels.Name = "mnuModelProbabilityDistributionsCompareModels"
        Me.mnuModelProbabilityDistributionsCompareModels.Tag = "Show_Models..."
        '
        'mnuModelProbabilityDistributionsRandomSamplesUseModel
        '
        Me.mnuModelProbabilityDistributionsRandomSamplesUseModel.Name = "mnuModelProbabilityDistributionsRandomSamplesUseModel"
        resources.ApplyResources(Me.mnuModelProbabilityDistributionsRandomSamplesUseModel, "mnuModelProbabilityDistributionsRandomSamplesUseModel")
        Me.mnuModelProbabilityDistributionsRandomSamplesUseModel.Tag = "RandomSamples_(Use_Model)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'mnuModelOneVariable
        '
        Me.mnuModelOneVariable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelOneVariableFitModel, Me.mnuModelOneVariableCompareModels, Me.mnuModelOneVariableUseModel})
        Me.mnuModelOneVariable.Name = "mnuModelOneVariable"
        resources.ApplyResources(Me.mnuModelOneVariable, "mnuModelOneVariable")
        Me.mnuModelOneVariable.Tag = "One_Variable"
        '
        'mnuModelOneVariableFitModel
        '
        Me.mnuModelOneVariableFitModel.Name = "mnuModelOneVariableFitModel"
        resources.ApplyResources(Me.mnuModelOneVariableFitModel, "mnuModelOneVariableFitModel")
        Me.mnuModelOneVariableFitModel.Tag = "Fit_Model..."
        '
        'mnuModelOneVariableCompareModels
        '
        Me.mnuModelOneVariableCompareModels.Name = "mnuModelOneVariableCompareModels"
        resources.ApplyResources(Me.mnuModelOneVariableCompareModels, "mnuModelOneVariableCompareModels")
        Me.mnuModelOneVariableCompareModels.Tag = "Choose_Models..."
        '
        'mnuModelOneVariableUseModel
        '
        Me.mnuModelOneVariableUseModel.Name = "mnuModelOneVariableUseModel"
        resources.ApplyResources(Me.mnuModelOneVariableUseModel, "mnuModelOneVariableUseModel")
        Me.mnuModelOneVariableUseModel.Tag = "Use_Model..."
        '
        'mnuModelTwoVariables
        '
        Me.mnuModelTwoVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelTwoVariablesFitModel, Me.mnuModelTwoVariablesChooseModel, Me.mnuModelTwoVariablesUseModel})
        Me.mnuModelTwoVariables.Name = "mnuModelTwoVariables"
        resources.ApplyResources(Me.mnuModelTwoVariables, "mnuModelTwoVariables")
        Me.mnuModelTwoVariables.Tag = "Two_Variables"
        '
        'mnuModelTwoVariablesFitModel
        '
        Me.mnuModelTwoVariablesFitModel.Name = "mnuModelTwoVariablesFitModel"
        resources.ApplyResources(Me.mnuModelTwoVariablesFitModel, "mnuModelTwoVariablesFitModel")
        Me.mnuModelTwoVariablesFitModel.Tag = "Fit_Model..."
        '
        'mnuModelTwoVariablesChooseModel
        '
        resources.ApplyResources(Me.mnuModelTwoVariablesChooseModel, "mnuModelTwoVariablesChooseModel")
        Me.mnuModelTwoVariablesChooseModel.Name = "mnuModelTwoVariablesChooseModel"
        Me.mnuModelTwoVariablesChooseModel.Tag = "Choose_Model..."
        '
        'mnuModelTwoVariablesUseModel
        '
        Me.mnuModelTwoVariablesUseModel.Name = "mnuModelTwoVariablesUseModel"
        resources.ApplyResources(Me.mnuModelTwoVariablesUseModel, "mnuModelTwoVariablesUseModel")
        Me.mnuModelTwoVariablesUseModel.Tag = "Use_Model..."
        '
        'mnuModelThreeVariables
        '
        Me.mnuModelThreeVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelThreeVariablesFitModel, Me.mnuModelThreeVariablesChooseModel, Me.mnuModelThreeVariablesUseModel})
        Me.mnuModelThreeVariables.Name = "mnuModelThreeVariables"
        resources.ApplyResources(Me.mnuModelThreeVariables, "mnuModelThreeVariables")
        Me.mnuModelThreeVariables.Tag = "Three_Variables"
        '
        'mnuModelThreeVariablesFitModel
        '
        Me.mnuModelThreeVariablesFitModel.Name = "mnuModelThreeVariablesFitModel"
        resources.ApplyResources(Me.mnuModelThreeVariablesFitModel, "mnuModelThreeVariablesFitModel")
        Me.mnuModelThreeVariablesFitModel.Tag = "Fit_Model..."
        '
        'mnuModelThreeVariablesChooseModel
        '
        resources.ApplyResources(Me.mnuModelThreeVariablesChooseModel, "mnuModelThreeVariablesChooseModel")
        Me.mnuModelThreeVariablesChooseModel.Name = "mnuModelThreeVariablesChooseModel"
        Me.mnuModelThreeVariablesChooseModel.Tag = "Choose_Model..."
        '
        'mnuModelThreeVariablesUseModel
        '
        resources.ApplyResources(Me.mnuModelThreeVariablesUseModel, "mnuModelThreeVariablesUseModel")
        Me.mnuModelThreeVariablesUseModel.Name = "mnuModelThreeVariablesUseModel"
        Me.mnuModelThreeVariablesUseModel.Tag = "Use_Model..."
        '
        'mnuModelFourVariables
        '
        Me.mnuModelFourVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelFourVariablesFitModel, Me.mnuModelFourVariablesChooseModel, Me.mnuModelFourVariablesUseModel})
        Me.mnuModelFourVariables.Name = "mnuModelFourVariables"
        resources.ApplyResources(Me.mnuModelFourVariables, "mnuModelFourVariables")
        Me.mnuModelFourVariables.Tag = "Four_Variables"
        '
        'mnuModelFourVariablesFitModel
        '
        Me.mnuModelFourVariablesFitModel.Name = "mnuModelFourVariablesFitModel"
        resources.ApplyResources(Me.mnuModelFourVariablesFitModel, "mnuModelFourVariablesFitModel")
        Me.mnuModelFourVariablesFitModel.Tag = "Fit_Model..."
        '
        'mnuModelFourVariablesChooseModel
        '
        resources.ApplyResources(Me.mnuModelFourVariablesChooseModel, "mnuModelFourVariablesChooseModel")
        Me.mnuModelFourVariablesChooseModel.Name = "mnuModelFourVariablesChooseModel"
        Me.mnuModelFourVariablesChooseModel.Tag = "Choose_Model..."
        '
        'mnuModelFourVariablesUseModel
        '
        resources.ApplyResources(Me.mnuModelFourVariablesUseModel, "mnuModelFourVariablesUseModel")
        Me.mnuModelFourVariablesUseModel.Name = "mnuModelFourVariablesUseModel"
        Me.mnuModelFourVariablesUseModel.Tag = "Use_Model..."
        '
        'mnuModelGeneral
        '
        Me.mnuModelGeneral.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelGeneralFitModel, Me.mnuModelGeneralChooseModel, Me.mnuModelGeneralUseModel})
        Me.mnuModelGeneral.Name = "mnuModelGeneral"
        resources.ApplyResources(Me.mnuModelGeneral, "mnuModelGeneral")
        Me.mnuModelGeneral.Tag = "General"
        '
        'mnuModelGeneralFitModel
        '
        Me.mnuModelGeneralFitModel.Name = "mnuModelGeneralFitModel"
        resources.ApplyResources(Me.mnuModelGeneralFitModel, "mnuModelGeneralFitModel")
        Me.mnuModelGeneralFitModel.Tag = "Fit_Model..."
        '
        'mnuModelGeneralChooseModel
        '
        resources.ApplyResources(Me.mnuModelGeneralChooseModel, "mnuModelGeneralChooseModel")
        Me.mnuModelGeneralChooseModel.Name = "mnuModelGeneralChooseModel"
        Me.mnuModelGeneralChooseModel.Tag = "Choose_Model..."
        '
        'mnuModelGeneralUseModel
        '
        resources.ApplyResources(Me.mnuModelGeneralUseModel, "mnuModelGeneralUseModel")
        Me.mnuModelGeneralUseModel.Name = "mnuModelGeneralUseModel"
        Me.mnuModelGeneralUseModel.Tag = "Use_Model..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        '
        'mnuModelHypothesisTests
        '
        Me.mnuModelHypothesisTests.Name = "mnuModelHypothesisTests"
        resources.ApplyResources(Me.mnuModelHypothesisTests, "mnuModelHypothesisTests")
        '
        'mnuModelOtherOneVariable
        '
        Me.mnuModelOtherOneVariable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelOtherOneVariableExactResults, Me.mnuModelOtherOneVariableSampleSummaryData, Me.mnuModelOtherOneVariableNonParametric, Me.mnuModelOtherOneVariableGoodnessofFit})
        resources.ApplyResources(Me.mnuModelOtherOneVariable, "mnuModelOtherOneVariable")
        Me.mnuModelOtherOneVariable.Name = "mnuModelOtherOneVariable"
        Me.mnuModelOtherOneVariable.Tag = "Other_(One_Variable)"
        '
        'mnuModelOtherOneVariableExactResults
        '
        Me.mnuModelOtherOneVariableExactResults.Name = "mnuModelOtherOneVariableExactResults"
        resources.ApplyResources(Me.mnuModelOtherOneVariableExactResults, "mnuModelOtherOneVariableExactResults")
        Me.mnuModelOtherOneVariableExactResults.Tag = "Exact_Results..."
        '
        'mnuModelOtherOneVariableSampleSummaryData
        '
        resources.ApplyResources(Me.mnuModelOtherOneVariableSampleSummaryData, "mnuModelOtherOneVariableSampleSummaryData")
        Me.mnuModelOtherOneVariableSampleSummaryData.Name = "mnuModelOtherOneVariableSampleSummaryData"
        Me.mnuModelOtherOneVariableSampleSummaryData.Tag = "Summary_Data..."
        '
        'mnuModelOtherOneVariableNonParametric
        '
        resources.ApplyResources(Me.mnuModelOtherOneVariableNonParametric, "mnuModelOtherOneVariableNonParametric")
        Me.mnuModelOtherOneVariableNonParametric.Name = "mnuModelOtherOneVariableNonParametric"
        Me.mnuModelOtherOneVariableNonParametric.Tag = "Non_Parametric..."
        '
        'mnuModelOtherOneVariableGoodnessofFit
        '
        resources.ApplyResources(Me.mnuModelOtherOneVariableGoodnessofFit, "mnuModelOtherOneVariableGoodnessofFit")
        Me.mnuModelOtherOneVariableGoodnessofFit.Name = "mnuModelOtherOneVariableGoodnessofFit"
        Me.mnuModelOtherOneVariableGoodnessofFit.Tag = "Goodness_of_Fit"
        '
        'mnuModelOtherTwoVariables
        '
        Me.mnuModelOtherTwoVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelOtherTwoVariablesTwoSamples, Me.mnuModelOtherTwoVariablesSummaryData, Me.mnuModelOtherTwoVariablesSimpleRegression, Me.mnuModelOtherTwoVariablesOneWayANOVA, Me.mnuModelOtherTwoVariablesNonParametricTwoSamples, Me.mnuModelOtherTwoVariablesNonParametricOneWayANOVA})
        resources.ApplyResources(Me.mnuModelOtherTwoVariables, "mnuModelOtherTwoVariables")
        Me.mnuModelOtherTwoVariables.Name = "mnuModelOtherTwoVariables"
        Me.mnuModelOtherTwoVariables.Tag = "Other_(Two_Variables)"
        '
        'mnuModelOtherTwoVariablesTwoSamples
        '
        resources.ApplyResources(Me.mnuModelOtherTwoVariablesTwoSamples, "mnuModelOtherTwoVariablesTwoSamples")
        Me.mnuModelOtherTwoVariablesTwoSamples.Name = "mnuModelOtherTwoVariablesTwoSamples"
        Me.mnuModelOtherTwoVariablesTwoSamples.Tag = "Two_Samples..."
        '
        'mnuModelOtherTwoVariablesSummaryData
        '
        resources.ApplyResources(Me.mnuModelOtherTwoVariablesSummaryData, "mnuModelOtherTwoVariablesSummaryData")
        Me.mnuModelOtherTwoVariablesSummaryData.Name = "mnuModelOtherTwoVariablesSummaryData"
        Me.mnuModelOtherTwoVariablesSummaryData.Tag = "Summary_Data..."
        '
        'mnuModelOtherTwoVariablesSimpleRegression
        '
        Me.mnuModelOtherTwoVariablesSimpleRegression.Name = "mnuModelOtherTwoVariablesSimpleRegression"
        resources.ApplyResources(Me.mnuModelOtherTwoVariablesSimpleRegression, "mnuModelOtherTwoVariablesSimpleRegression")
        Me.mnuModelOtherTwoVariablesSimpleRegression.Tag = "Simple_Regression..."
        '
        'mnuModelOtherTwoVariablesOneWayANOVA
        '
        Me.mnuModelOtherTwoVariablesOneWayANOVA.Name = "mnuModelOtherTwoVariablesOneWayANOVA"
        resources.ApplyResources(Me.mnuModelOtherTwoVariablesOneWayANOVA, "mnuModelOtherTwoVariablesOneWayANOVA")
        Me.mnuModelOtherTwoVariablesOneWayANOVA.Tag = "One_Way_ANOVA..."
        '
        'mnuModelOtherTwoVariablesNonParametricTwoSamples
        '
        resources.ApplyResources(Me.mnuModelOtherTwoVariablesNonParametricTwoSamples, "mnuModelOtherTwoVariablesNonParametricTwoSamples")
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Name = "mnuModelOtherTwoVariablesNonParametricTwoSamples"
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Tag = "Non_Parameteric_Two_Samples..."
        '
        'mnuModelOtherTwoVariablesNonParametricOneWayANOVA
        '
        Me.mnuModelOtherTwoVariablesNonParametricOneWayANOVA.Name = "mnuModelOtherTwoVariablesNonParametricOneWayANOVA"
        resources.ApplyResources(Me.mnuModelOtherTwoVariablesNonParametricOneWayANOVA, "mnuModelOtherTwoVariablesNonParametricOneWayANOVA")
        Me.mnuModelOtherTwoVariablesNonParametricOneWayANOVA.Tag = "Non_Parameteric_One_Way_ANOVA..."
        '
        'mnuModelOtherThreeVariables
        '
        Me.mnuModelOtherThreeVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelOtherThreeVariablesSimpleWithGroups, Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA, Me.mnuModelOtherThreeVariablesChisquareTest})
        resources.ApplyResources(Me.mnuModelOtherThreeVariables, "mnuModelOtherThreeVariables")
        Me.mnuModelOtherThreeVariables.Name = "mnuModelOtherThreeVariables"
        Me.mnuModelOtherThreeVariables.Tag = "Other_(Three_Variable)"
        '
        'mnuModelOtherThreeVariablesSimpleWithGroups
        '
        resources.ApplyResources(Me.mnuModelOtherThreeVariablesSimpleWithGroups, "mnuModelOtherThreeVariablesSimpleWithGroups")
        Me.mnuModelOtherThreeVariablesSimpleWithGroups.Name = "mnuModelOtherThreeVariablesSimpleWithGroups"
        Me.mnuModelOtherThreeVariablesSimpleWithGroups.Tag = "Simple_with_groups..."
        '
        'mnuModelOtherThreeVariablesNonParametricTwoWayANOVA
        '
        Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Name = "mnuModelOtherThreeVariablesNonParametricTwoWayANOVA"
        resources.ApplyResources(Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA, "mnuModelOtherThreeVariablesNonParametricTwoWayANOVA")
        Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Tag = "Non_Parametric_Two_Way_ANOVA..."
        '
        'mnuModelOtherThreeVariablesChisquareTest
        '
        Me.mnuModelOtherThreeVariablesChisquareTest.Name = "mnuModelOtherThreeVariablesChisquareTest"
        resources.ApplyResources(Me.mnuModelOtherThreeVariablesChisquareTest, "mnuModelOtherThreeVariablesChisquareTest")
        Me.mnuModelOtherThreeVariablesChisquareTest.Tag = "Chi-square_Test"
        '
        'mnuModelOtherGeneral
        '
        Me.mnuModelOtherGeneral.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelOtherGeneralANOVAGeneral, Me.mnuModelOtherGeneralRegression, Me.mnuModelOtherGeneralLogLinear})
        resources.ApplyResources(Me.mnuModelOtherGeneral, "mnuModelOtherGeneral")
        Me.mnuModelOtherGeneral.Name = "mnuModelOtherGeneral"
        Me.mnuModelOtherGeneral.Tag = "Other_(General)"
        '
        'mnuModelOtherGeneralANOVAGeneral
        '
        resources.ApplyResources(Me.mnuModelOtherGeneralANOVAGeneral, "mnuModelOtherGeneralANOVAGeneral")
        Me.mnuModelOtherGeneralANOVAGeneral.Name = "mnuModelOtherGeneralANOVAGeneral"
        Me.mnuModelOtherGeneralANOVAGeneral.Tag = "ANOVA_General..."
        '
        'mnuModelOtherGeneralRegression
        '
        resources.ApplyResources(Me.mnuModelOtherGeneralRegression, "mnuModelOtherGeneralRegression")
        Me.mnuModelOtherGeneralRegression.Name = "mnuModelOtherGeneralRegression"
        Me.mnuModelOtherGeneralRegression.Tag = "Regression..."
        '
        'mnuModelOtherGeneralLogLinear
        '
        resources.ApplyResources(Me.mnuModelOtherGeneralLogLinear, "mnuModelOtherGeneralLogLinear")
        Me.mnuModelOtherGeneralLogLinear.Name = "mnuModelOtherGeneralLogLinear"
        Me.mnuModelOtherGeneralLogLinear.Tag = "Log_Linear"
        '
        'mnuClimaticExamine
        '
        resources.ApplyResources(Me.mnuClimaticExamine, "mnuClimaticExamine")
        Me.mnuClimaticExamine.Name = "mnuClimaticExamine"
        Me.mnuClimaticExamine.Tag = "Examine"
        '
        'mnuClimaticProcess
        '
        resources.ApplyResources(Me.mnuClimaticProcess, "mnuClimaticProcess")
        Me.mnuClimaticProcess.Name = "mnuClimaticProcess"
        Me.mnuClimaticProcess.Tag = "Process"
        '
        'mnuClimaticEvaporation
        '
        Me.mnuClimaticEvaporation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticEvaporationSite, Me.mnuClimaticEvaporationPenman})
        Me.mnuClimaticEvaporation.Name = "mnuClimaticEvaporation"
        resources.ApplyResources(Me.mnuClimaticEvaporation, "mnuClimaticEvaporation")
        Me.mnuClimaticEvaporation.Tag = "Evaporation"
        '
        'mnuClimaticEvaporationSite
        '
        resources.ApplyResources(Me.mnuClimaticEvaporationSite, "mnuClimaticEvaporationSite")
        Me.mnuClimaticEvaporationSite.Name = "mnuClimaticEvaporationSite"
        Me.mnuClimaticEvaporationSite.Tag = "Site"
        '
        'mnuClimaticEvaporationPenman
        '
        resources.ApplyResources(Me.mnuClimaticEvaporationPenman, "mnuClimaticEvaporationPenman")
        Me.mnuClimaticEvaporationPenman.Name = "mnuClimaticEvaporationPenman"
        Me.mnuClimaticEvaporationPenman.Tag = "Penman"
        '
        'mnuClimaticCrop
        '
        Me.mnuClimaticCrop.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CropCoefficientsToolStripMenuItem, Me.WaterSatisfactionIndexToolStripMenuItem})
        Me.mnuClimaticCrop.Name = "mnuClimaticCrop"
        resources.ApplyResources(Me.mnuClimaticCrop, "mnuClimaticCrop")
        Me.mnuClimaticCrop.Tag = "Crop"
        '
        'CropCoefficientsToolStripMenuItem
        '
        resources.ApplyResources(Me.CropCoefficientsToolStripMenuItem, "CropCoefficientsToolStripMenuItem")
        Me.CropCoefficientsToolStripMenuItem.Name = "CropCoefficientsToolStripMenuItem"
        '
        'WaterSatisfactionIndexToolStripMenuItem
        '
        resources.ApplyResources(Me.WaterSatisfactionIndexToolStripMenuItem, "WaterSatisfactionIndexToolStripMenuItem")
        Me.WaterSatisfactionIndexToolStripMenuItem.Name = "WaterSatisfactionIndexToolStripMenuItem"
        '
        'mnuClimaticHeatSum
        '
        resources.ApplyResources(Me.mnuClimaticHeatSum, "mnuClimaticHeatSum")
        Me.mnuClimaticHeatSum.Name = "mnuClimaticHeatSum"
        Me.mnuClimaticHeatSum.Tag = "Heat_Sum"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewDataView, Me.mnuViewOutputWindow, Me.mnuViewLog, Me.mnuViewScriptWindow, Me.mnuViewColumnMetadata, Me.mnuViewDataFrameMetadata, Me.ToolStripSeparator22, Me.mnuViewClimaticMenu, Me.mnuViewProcurementMenu, Me.mnuViewOptionsByContextMenu, Me.ToolStripSeparator39, Me.mnuViewResetToDefaultLayout})
        Me.mnuView.Name = "mnuView"
        resources.ApplyResources(Me.mnuView, "mnuView")
        Me.mnuView.Tag = "View"
        '
        'mnuViewDataView
        '
        Me.mnuViewDataView.Name = "mnuViewDataView"
        resources.ApplyResources(Me.mnuViewDataView, "mnuViewDataView")
        Me.mnuViewDataView.Tag = "Data_View"
        '
        'mnuViewOutputWindow
        '
        Me.mnuViewOutputWindow.Name = "mnuViewOutputWindow"
        resources.ApplyResources(Me.mnuViewOutputWindow, "mnuViewOutputWindow")
        '
        'mnuViewLog
        '
        Me.mnuViewLog.Name = "mnuViewLog"
        resources.ApplyResources(Me.mnuViewLog, "mnuViewLog")
        Me.mnuViewLog.Tag = "Log"
        '
        'mnuViewScriptWindow
        '
        Me.mnuViewScriptWindow.Name = "mnuViewScriptWindow"
        resources.ApplyResources(Me.mnuViewScriptWindow, "mnuViewScriptWindow")
        Me.mnuViewScriptWindow.Tag = "Script_Window"
        '
        'mnuViewColumnMetadata
        '
        Me.mnuViewColumnMetadata.Name = "mnuViewColumnMetadata"
        resources.ApplyResources(Me.mnuViewColumnMetadata, "mnuViewColumnMetadata")
        Me.mnuViewColumnMetadata.Tag = "Column_Metadata"
        '
        'mnuViewDataFrameMetadata
        '
        Me.mnuViewDataFrameMetadata.Name = "mnuViewDataFrameMetadata"
        resources.ApplyResources(Me.mnuViewDataFrameMetadata, "mnuViewDataFrameMetadata")
        Me.mnuViewDataFrameMetadata.Tag = "Data_Frame_Metadata"
        '
        'ToolStripSeparator22
        '
        Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
        resources.ApplyResources(Me.ToolStripSeparator22, "ToolStripSeparator22")
        '
        'mnuViewClimaticMenu
        '
        Me.mnuViewClimaticMenu.Name = "mnuViewClimaticMenu"
        resources.ApplyResources(Me.mnuViewClimaticMenu, "mnuViewClimaticMenu")
        Me.mnuViewClimaticMenu.Tag = ""
        '
        'mnuViewProcurementMenu
        '
        Me.mnuViewProcurementMenu.Name = "mnuViewProcurementMenu"
        resources.ApplyResources(Me.mnuViewProcurementMenu, "mnuViewProcurementMenu")
        Me.mnuViewProcurementMenu.Tag = ""
        '
        'mnuViewOptionsByContextMenu
        '
        Me.mnuViewOptionsByContextMenu.Name = "mnuViewOptionsByContextMenu"
        resources.ApplyResources(Me.mnuViewOptionsByContextMenu, "mnuViewOptionsByContextMenu")
        '
        'ToolStripSeparator39
        '
        Me.ToolStripSeparator39.Name = "ToolStripSeparator39"
        resources.ApplyResources(Me.ToolStripSeparator39, "ToolStripSeparator39")
        '
        'mnuViewResetToDefaultLayout
        '
        Me.mnuViewResetToDefaultLayout.Name = "mnuViewResetToDefaultLayout"
        resources.ApplyResources(Me.mnuViewResetToDefaultLayout, "mnuViewResetToDefaultLayout")
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpHelpIntroduction, Me.mnuHelpHistFAQ, Me.mnuHelpSpreadsheet, Me.mnuHelpGetingStarted, Me.ToolStripSeparator28, Me.mnuHelpMenus, Me.mnuHelpR, Me.mnuHelpRPackagesCommands, Me.mnuHelpDataset, Me.ToolStripSeparator29, Me.mnuHelpGuide, Me.mnuHelpAboutRInstat, Me.mnuHelpLicence, Me.mnuHelpAcknowledgments})
        Me.mnuHelp.Name = "mnuHelp"
        resources.ApplyResources(Me.mnuHelp, "mnuHelp")
        Me.mnuHelp.Tag = "Help"
        '
        'mnuHelpHelpIntroduction
        '
        Me.mnuHelpHelpIntroduction.Name = "mnuHelpHelpIntroduction"
        resources.ApplyResources(Me.mnuHelpHelpIntroduction, "mnuHelpHelpIntroduction")
        '
        'mnuHelpHistFAQ
        '
        Me.mnuHelpHistFAQ.Name = "mnuHelpHistFAQ"
        resources.ApplyResources(Me.mnuHelpHistFAQ, "mnuHelpHistFAQ")
        '
        'mnuHelpSpreadsheet
        '
        Me.mnuHelpSpreadsheet.Name = "mnuHelpSpreadsheet"
        resources.ApplyResources(Me.mnuHelpSpreadsheet, "mnuHelpSpreadsheet")
        '
        'mnuHelpGetingStarted
        '
        Me.mnuHelpGetingStarted.Name = "mnuHelpGetingStarted"
        resources.ApplyResources(Me.mnuHelpGetingStarted, "mnuHelpGetingStarted")
        '
        'ToolStripSeparator28
        '
        Me.ToolStripSeparator28.Name = "ToolStripSeparator28"
        resources.ApplyResources(Me.ToolStripSeparator28, "ToolStripSeparator28")
        '
        'mnuHelpMenus
        '
        Me.mnuHelpMenus.Name = "mnuHelpMenus"
        resources.ApplyResources(Me.mnuHelpMenus, "mnuHelpMenus")
        '
        'mnuHelpR
        '
        Me.mnuHelpR.Name = "mnuHelpR"
        resources.ApplyResources(Me.mnuHelpR, "mnuHelpR")
        '
        'mnuHelpRPackagesCommands
        '
        Me.mnuHelpRPackagesCommands.Name = "mnuHelpRPackagesCommands"
        resources.ApplyResources(Me.mnuHelpRPackagesCommands, "mnuHelpRPackagesCommands")
        '
        'mnuHelpDataset
        '
        Me.mnuHelpDataset.Name = "mnuHelpDataset"
        resources.ApplyResources(Me.mnuHelpDataset, "mnuHelpDataset")
        '
        'ToolStripSeparator29
        '
        Me.ToolStripSeparator29.Name = "ToolStripSeparator29"
        resources.ApplyResources(Me.ToolStripSeparator29, "ToolStripSeparator29")
        '
        'mnuHelpGuide
        '
        Me.mnuHelpGuide.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpGuidesCaseStudy, Me.mnuHelpGuideGlosary, Me.mnuhelpGuidesMore})
        Me.mnuHelpGuide.Name = "mnuHelpGuide"
        resources.ApplyResources(Me.mnuHelpGuide, "mnuHelpGuide")
        '
        'mnuHelpGuidesCaseStudy
        '
        Me.mnuHelpGuidesCaseStudy.Name = "mnuHelpGuidesCaseStudy"
        resources.ApplyResources(Me.mnuHelpGuidesCaseStudy, "mnuHelpGuidesCaseStudy")
        '
        'mnuHelpGuideGlosary
        '
        Me.mnuHelpGuideGlosary.Name = "mnuHelpGuideGlosary"
        resources.ApplyResources(Me.mnuHelpGuideGlosary, "mnuHelpGuideGlosary")
        '
        'mnuhelpGuidesMore
        '
        resources.ApplyResources(Me.mnuhelpGuidesMore, "mnuhelpGuidesMore")
        Me.mnuhelpGuidesMore.Name = "mnuhelpGuidesMore"
        '
        'mnuHelpAboutRInstat
        '
        resources.ApplyResources(Me.mnuHelpAboutRInstat, "mnuHelpAboutRInstat")
        Me.mnuHelpAboutRInstat.Name = "mnuHelpAboutRInstat"
        Me.mnuHelpAboutRInstat.Tag = "About_R-Instat"
        '
        'mnuHelpLicence
        '
        Me.mnuHelpLicence.Name = "mnuHelpLicence"
        resources.ApplyResources(Me.mnuHelpLicence, "mnuHelpLicence")
        Me.mnuHelpLicence.Tag = "Licence..."
        '
        'mnuHelpAcknowledgments
        '
        Me.mnuHelpAcknowledgments.Name = "mnuHelpAcknowledgments"
        resources.ApplyResources(Me.mnuHelpAcknowledgments, "mnuHelpAcknowledgments")
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        resources.ApplyResources(Me.ToolStripSeparator16, "ToolStripSeparator16")
        '
        'mnuClimatic
        '
        Me.mnuClimatic.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticFile, Me.ToolStripSeparator18, Me.mnuClimaticTidyandExamine, Me.mnuClimaticDates, Me.mnuClimaticDefineClimaticData, Me.mnuClimaticCheckData, Me.mnuClimaticPrepare, Me.mnuClimdex, Me.ToolStripSeparator30, Me.mnuClimaticDescribe, Me.mnuClimaticPICSA, Me.mnuCMSAF, Me.ToolStripSeparator16, Me.mnuClimaticModels, Me.mnuClimaticExamine, Me.mnuClimaticProcess, Me.ToolStripSeparator23, Me.mnuClimaticSCF, Me.mnuClimaticEvaporation, Me.mnuClimaticCrop, Me.mnuClimaticHeatSum, Me.mnuClimateMethods})
        Me.mnuClimatic.Name = "mnuClimatic"
        resources.ApplyResources(Me.mnuClimatic, "mnuClimatic")
        Me.mnuClimatic.Tag = "Climatic"
        '
        'mnuClimaticFile
        '
        Me.mnuClimaticFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticFileOpensst, Me.mnuClimaticFileImportGriddedData, Me.OpenNetCDFToolStripMenuItem, Me.mnuClimaticFileImportShapeFile, Me.mnuClimateFileClimSoft, Me.mnuClimaticFileCliData, Me.ToolStripSeparator15, Me.mnuClimaticFileExportToCPT})
        Me.mnuClimaticFile.Name = "mnuClimaticFile"
        resources.ApplyResources(Me.mnuClimaticFile, "mnuClimaticFile")
        '
        'mnuClimaticFileOpensst
        '
        Me.mnuClimaticFileOpensst.Name = "mnuClimaticFileOpensst"
        resources.ApplyResources(Me.mnuClimaticFileOpensst, "mnuClimaticFileOpensst")
        '
        'mnuClimaticFileImportGriddedData
        '
        Me.mnuClimaticFileImportGriddedData.Name = "mnuClimaticFileImportGriddedData"
        resources.ApplyResources(Me.mnuClimaticFileImportGriddedData, "mnuClimaticFileImportGriddedData")
        '
        'OpenNetCDFToolStripMenuItem
        '
        Me.OpenNetCDFToolStripMenuItem.Name = "OpenNetCDFToolStripMenuItem"
        resources.ApplyResources(Me.OpenNetCDFToolStripMenuItem, "OpenNetCDFToolStripMenuItem")
        '
        'mnuClimaticFileImportShapeFile
        '
        Me.mnuClimaticFileImportShapeFile.Name = "mnuClimaticFileImportShapeFile"
        resources.ApplyResources(Me.mnuClimaticFileImportShapeFile, "mnuClimaticFileImportShapeFile")
        '
        'mnuClimateFileClimSoft
        '
        Me.mnuClimateFileClimSoft.Name = "mnuClimateFileClimSoft"
        resources.ApplyResources(Me.mnuClimateFileClimSoft, "mnuClimateFileClimSoft")
        '
        'mnuClimaticFileCliData
        '
        resources.ApplyResources(Me.mnuClimaticFileCliData, "mnuClimaticFileCliData")
        Me.mnuClimaticFileCliData.Name = "mnuClimaticFileCliData"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        resources.ApplyResources(Me.ToolStripSeparator15, "ToolStripSeparator15")
        '
        'mnuClimaticFileExportToCPT
        '
        Me.mnuClimaticFileExportToCPT.Name = "mnuClimaticFileExportToCPT"
        resources.ApplyResources(Me.mnuClimaticFileExportToCPT, "mnuClimaticFileExportToCPT")
        Me.mnuClimaticFileExportToCPT.Tag = "Export_to_CPT"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        resources.ApplyResources(Me.ToolStripSeparator18, "ToolStripSeparator18")
        '
        'mnuClimaticTidyandExamine
        '
        Me.mnuClimaticTidyandExamine.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticTidyandExamineTidyDailyData, Me.mnuClimaticTidyandExamineNonNumericCases, Me.mnuClimaticTidyandExamineReplaceValues, Me.mnuClimaticTidyandExamineMerge, Me.ToolStripSeparator50, Me.mnuClimaticTidyandExamineOneVariableSummarize})
        Me.mnuClimaticTidyandExamine.Name = "mnuClimaticTidyandExamine"
        resources.ApplyResources(Me.mnuClimaticTidyandExamine, "mnuClimaticTidyandExamine")
        '
        'mnuClimaticTidyandExamineTidyDailyData
        '
        Me.mnuClimaticTidyandExamineTidyDailyData.Name = "mnuClimaticTidyandExamineTidyDailyData"
        resources.ApplyResources(Me.mnuClimaticTidyandExamineTidyDailyData, "mnuClimaticTidyandExamineTidyDailyData")
        '
        'mnuClimaticTidyandExamineNonNumericCases
        '
        Me.mnuClimaticTidyandExamineNonNumericCases.Name = "mnuClimaticTidyandExamineNonNumericCases"
        resources.ApplyResources(Me.mnuClimaticTidyandExamineNonNumericCases, "mnuClimaticTidyandExamineNonNumericCases")
        '
        'mnuClimaticTidyandExamineReplaceValues
        '
        Me.mnuClimaticTidyandExamineReplaceValues.Name = "mnuClimaticTidyandExamineReplaceValues"
        resources.ApplyResources(Me.mnuClimaticTidyandExamineReplaceValues, "mnuClimaticTidyandExamineReplaceValues")
        '
        'mnuClimaticTidyandExamineMerge
        '
        Me.mnuClimaticTidyandExamineMerge.Name = "mnuClimaticTidyandExamineMerge"
        resources.ApplyResources(Me.mnuClimaticTidyandExamineMerge, "mnuClimaticTidyandExamineMerge")
        '
        'ToolStripSeparator50
        '
        Me.ToolStripSeparator50.Name = "ToolStripSeparator50"
        resources.ApplyResources(Me.ToolStripSeparator50, "ToolStripSeparator50")
        '
        'mnuClimaticTidyandExamineOneVariableSummarize
        '
        Me.mnuClimaticTidyandExamineOneVariableSummarize.Name = "mnuClimaticTidyandExamineOneVariableSummarize"
        resources.ApplyResources(Me.mnuClimaticTidyandExamineOneVariableSummarize, "mnuClimaticTidyandExamineOneVariableSummarize")
        '
        'mnuClimaticDates
        '
        Me.mnuClimaticDates.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticDatesGenerateDates, Me.mnuClimaticDatesMakeDate, Me.mnuClimaticDatesInfillMissingDates, Me.mnuClimaticDatesUseDate, Me.mnuClimaticDatesMakeTime, Me.mnuClimaticDatesUseTime})
        Me.mnuClimaticDates.Name = "mnuClimaticDates"
        resources.ApplyResources(Me.mnuClimaticDates, "mnuClimaticDates")
        '
        'mnuClimaticDatesGenerateDates
        '
        Me.mnuClimaticDatesGenerateDates.Name = "mnuClimaticDatesGenerateDates"
        resources.ApplyResources(Me.mnuClimaticDatesGenerateDates, "mnuClimaticDatesGenerateDates")
        '
        'mnuClimaticDatesMakeDate
        '
        Me.mnuClimaticDatesMakeDate.Name = "mnuClimaticDatesMakeDate"
        resources.ApplyResources(Me.mnuClimaticDatesMakeDate, "mnuClimaticDatesMakeDate")
        '
        'mnuClimaticDatesInfillMissingDates
        '
        Me.mnuClimaticDatesInfillMissingDates.Name = "mnuClimaticDatesInfillMissingDates"
        resources.ApplyResources(Me.mnuClimaticDatesInfillMissingDates, "mnuClimaticDatesInfillMissingDates")
        '
        'mnuClimaticDatesUseDate
        '
        Me.mnuClimaticDatesUseDate.Name = "mnuClimaticDatesUseDate"
        resources.ApplyResources(Me.mnuClimaticDatesUseDate, "mnuClimaticDatesUseDate")
        '
        'mnuClimaticDatesMakeTime
        '
        resources.ApplyResources(Me.mnuClimaticDatesMakeTime, "mnuClimaticDatesMakeTime")
        Me.mnuClimaticDatesMakeTime.Name = "mnuClimaticDatesMakeTime"
        '
        'mnuClimaticDatesUseTime
        '
        resources.ApplyResources(Me.mnuClimaticDatesUseTime, "mnuClimaticDatesUseTime")
        Me.mnuClimaticDatesUseTime.Name = "mnuClimaticDatesUseTime"
        '
        'mnuClimaticDefineClimaticData
        '
        Me.mnuClimaticDefineClimaticData.Name = "mnuClimaticDefineClimaticData"
        resources.ApplyResources(Me.mnuClimaticDefineClimaticData, "mnuClimaticDefineClimaticData")
        '
        'mnuClimaticCheckData
        '
        Me.mnuClimaticCheckData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticCheckDataStationMaps, Me.ToolStripSeparator51, Me.mnuClimaticCheckDataInventory, Me.mnuClimaticCheckDataDisplayDaily, Me.mnuClimaticCheckDataBoxplot, Me.mnuClimaticCheckDataQCRainfall, Me.mnuClimaticCheckDataQCTemperatures})
        Me.mnuClimaticCheckData.Name = "mnuClimaticCheckData"
        resources.ApplyResources(Me.mnuClimaticCheckData, "mnuClimaticCheckData")
        '
        'mnuClimaticCheckDataStationMaps
        '
        Me.mnuClimaticCheckDataStationMaps.Name = "mnuClimaticCheckDataStationMaps"
        resources.ApplyResources(Me.mnuClimaticCheckDataStationMaps, "mnuClimaticCheckDataStationMaps")
        '
        'ToolStripSeparator51
        '
        Me.ToolStripSeparator51.Name = "ToolStripSeparator51"
        resources.ApplyResources(Me.ToolStripSeparator51, "ToolStripSeparator51")
        '
        'mnuClimaticCheckDataInventory
        '
        Me.mnuClimaticCheckDataInventory.Name = "mnuClimaticCheckDataInventory"
        resources.ApplyResources(Me.mnuClimaticCheckDataInventory, "mnuClimaticCheckDataInventory")
        '
        'mnuClimaticCheckDataDisplayDaily
        '
        Me.mnuClimaticCheckDataDisplayDaily.Name = "mnuClimaticCheckDataDisplayDaily"
        resources.ApplyResources(Me.mnuClimaticCheckDataDisplayDaily, "mnuClimaticCheckDataDisplayDaily")
        '
        'mnuClimaticCheckDataBoxplot
        '
        Me.mnuClimaticCheckDataBoxplot.Name = "mnuClimaticCheckDataBoxplot"
        resources.ApplyResources(Me.mnuClimaticCheckDataBoxplot, "mnuClimaticCheckDataBoxplot")
        '
        'mnuClimaticCheckDataQCRainfall
        '
        Me.mnuClimaticCheckDataQCRainfall.Name = "mnuClimaticCheckDataQCRainfall"
        resources.ApplyResources(Me.mnuClimaticCheckDataQCRainfall, "mnuClimaticCheckDataQCRainfall")
        '
        'mnuClimaticCheckDataQCTemperatures
        '
        Me.mnuClimaticCheckDataQCTemperatures.Name = "mnuClimaticCheckDataQCTemperatures"
        resources.ApplyResources(Me.mnuClimaticCheckDataQCTemperatures, "mnuClimaticCheckDataQCTemperatures")
        '
        'mnuClimaticPrepare
        '
        Me.mnuClimaticPrepare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCimaticPrepareTransform, Me.mnuClimaticPrepareConversions, Me.mnuClimaticPrepareCompare, Me.ToolStripSeparator37, Me.mnuClimaticPrepareClimaticSummaries, Me.mnuClimaticPrepareStartoftheRains, Me.mnuClimaticPrepareEndOfRains, Me.mnuClimaticPrepareLengthOfSeason, Me.mnuClimaticPrepareSpells, Me.mnuClimaticPrepareExtremes, Me.ToolStripSeparator46, Me.mnuClimaticPrepareEvapotranspiration, Me.mnuClimaticPrepareSummary, Me.mnuClimaticPrepareNewWorksheet, Me.mnuClimaticPrepareImportDailyData, Me.mnuClimaticPrepareMakeFactor, Me.mnuClimaticPrepareShiftDailyData, Me.mnuClimaticPrepareUnstackDailyData, Me.mnuClimaticPrepareStackDailyData})
        Me.mnuClimaticPrepare.Name = "mnuClimaticPrepare"
        resources.ApplyResources(Me.mnuClimaticPrepare, "mnuClimaticPrepare")
        Me.mnuClimaticPrepare.Tag = "Prepare"
        '
        'mnuCimaticPrepareTransform
        '
        Me.mnuCimaticPrepareTransform.Name = "mnuCimaticPrepareTransform"
        resources.ApplyResources(Me.mnuCimaticPrepareTransform, "mnuCimaticPrepareTransform")
        '
        'mnuClimaticPrepareConversions
        '
        Me.mnuClimaticPrepareConversions.Name = "mnuClimaticPrepareConversions"
        resources.ApplyResources(Me.mnuClimaticPrepareConversions, "mnuClimaticPrepareConversions")
        '
        'mnuClimaticPrepareCompare
        '
        Me.mnuClimaticPrepareCompare.Name = "mnuClimaticPrepareCompare"
        resources.ApplyResources(Me.mnuClimaticPrepareCompare, "mnuClimaticPrepareCompare")
        '
        'ToolStripSeparator37
        '
        Me.ToolStripSeparator37.Name = "ToolStripSeparator37"
        resources.ApplyResources(Me.ToolStripSeparator37, "ToolStripSeparator37")
        '
        'mnuClimaticPrepareClimaticSummaries
        '
        Me.mnuClimaticPrepareClimaticSummaries.Name = "mnuClimaticPrepareClimaticSummaries"
        resources.ApplyResources(Me.mnuClimaticPrepareClimaticSummaries, "mnuClimaticPrepareClimaticSummaries")
        '
        'mnuClimaticPrepareStartoftheRains
        '
        Me.mnuClimaticPrepareStartoftheRains.Name = "mnuClimaticPrepareStartoftheRains"
        resources.ApplyResources(Me.mnuClimaticPrepareStartoftheRains, "mnuClimaticPrepareStartoftheRains")
        '
        'mnuClimaticPrepareEndOfRains
        '
        Me.mnuClimaticPrepareEndOfRains.Name = "mnuClimaticPrepareEndOfRains"
        resources.ApplyResources(Me.mnuClimaticPrepareEndOfRains, "mnuClimaticPrepareEndOfRains")
        '
        'mnuClimaticPrepareLengthOfSeason
        '
        Me.mnuClimaticPrepareLengthOfSeason.Name = "mnuClimaticPrepareLengthOfSeason"
        resources.ApplyResources(Me.mnuClimaticPrepareLengthOfSeason, "mnuClimaticPrepareLengthOfSeason")
        '
        'mnuClimaticPrepareSpells
        '
        Me.mnuClimaticPrepareSpells.Name = "mnuClimaticPrepareSpells"
        resources.ApplyResources(Me.mnuClimaticPrepareSpells, "mnuClimaticPrepareSpells")
        '
        'mnuClimaticPrepareExtremes
        '
        Me.mnuClimaticPrepareExtremes.Name = "mnuClimaticPrepareExtremes"
        resources.ApplyResources(Me.mnuClimaticPrepareExtremes, "mnuClimaticPrepareExtremes")
        '
        'ToolStripSeparator46
        '
        Me.ToolStripSeparator46.Name = "ToolStripSeparator46"
        resources.ApplyResources(Me.ToolStripSeparator46, "ToolStripSeparator46")
        '
        'mnuClimaticPrepareEvapotranspiration
        '
        Me.mnuClimaticPrepareEvapotranspiration.Name = "mnuClimaticPrepareEvapotranspiration"
        resources.ApplyResources(Me.mnuClimaticPrepareEvapotranspiration, "mnuClimaticPrepareEvapotranspiration")
        '
        'mnuClimaticPrepareSummary
        '
        resources.ApplyResources(Me.mnuClimaticPrepareSummary, "mnuClimaticPrepareSummary")
        Me.mnuClimaticPrepareSummary.Name = "mnuClimaticPrepareSummary"
        '
        'mnuClimaticPrepareNewWorksheet
        '
        resources.ApplyResources(Me.mnuClimaticPrepareNewWorksheet, "mnuClimaticPrepareNewWorksheet")
        Me.mnuClimaticPrepareNewWorksheet.Name = "mnuClimaticPrepareNewWorksheet"
        Me.mnuClimaticPrepareNewWorksheet.Tag = "New_Worksheet"
        '
        'mnuClimaticPrepareImportDailyData
        '
        resources.ApplyResources(Me.mnuClimaticPrepareImportDailyData, "mnuClimaticPrepareImportDailyData")
        Me.mnuClimaticPrepareImportDailyData.Name = "mnuClimaticPrepareImportDailyData"
        Me.mnuClimaticPrepareImportDailyData.Tag = "Import_daily_data"
        '
        'mnuClimaticPrepareMakeFactor
        '
        resources.ApplyResources(Me.mnuClimaticPrepareMakeFactor, "mnuClimaticPrepareMakeFactor")
        Me.mnuClimaticPrepareMakeFactor.Name = "mnuClimaticPrepareMakeFactor"
        Me.mnuClimaticPrepareMakeFactor.Tag = "Make_Factor"
        '
        'mnuClimaticPrepareShiftDailyData
        '
        resources.ApplyResources(Me.mnuClimaticPrepareShiftDailyData, "mnuClimaticPrepareShiftDailyData")
        Me.mnuClimaticPrepareShiftDailyData.Name = "mnuClimaticPrepareShiftDailyData"
        Me.mnuClimaticPrepareShiftDailyData.Tag = "Shift_Daily_data"
        '
        'mnuClimaticPrepareUnstackDailyData
        '
        resources.ApplyResources(Me.mnuClimaticPrepareUnstackDailyData, "mnuClimaticPrepareUnstackDailyData")
        Me.mnuClimaticPrepareUnstackDailyData.Name = "mnuClimaticPrepareUnstackDailyData"
        Me.mnuClimaticPrepareUnstackDailyData.Tag = "Unstack_Daily_data"
        '
        'mnuClimaticPrepareStackDailyData
        '
        resources.ApplyResources(Me.mnuClimaticPrepareStackDailyData, "mnuClimaticPrepareStackDailyData")
        Me.mnuClimaticPrepareStackDailyData.Name = "mnuClimaticPrepareStackDailyData"
        Me.mnuClimaticPrepareStackDailyData.Tag = "Stack_Daily_data"
        '
        'mnuClimdex
        '
        Me.mnuClimdex.Name = "mnuClimdex"
        resources.ApplyResources(Me.mnuClimdex, "mnuClimdex")
        Me.mnuClimdex.Tag = "Climdex"
        '
        'ToolStripSeparator30
        '
        Me.ToolStripSeparator30.Name = "ToolStripSeparator30"
        resources.ApplyResources(Me.ToolStripSeparator30, "ToolStripSeparator30")
        '
        'mnuClimaticDescribe
        '
        Me.mnuClimaticDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticDescribeRainfall, Me.mnuClimaticDescribeTemperatures, Me.mnuClimaticDescribeWindSpeedDirection, Me.mnuClimaticDescribeSunshineRadiation, Me.ToolStripSeparator17, Me.mnuClimaticDescribeGeneral, Me.ToolStripSeparator31})
        Me.mnuClimaticDescribe.Name = "mnuClimaticDescribe"
        resources.ApplyResources(Me.mnuClimaticDescribe, "mnuClimaticDescribe")
        '
        'mnuClimaticDescribeRainfall
        '
        resources.ApplyResources(Me.mnuClimaticDescribeRainfall, "mnuClimaticDescribeRainfall")
        Me.mnuClimaticDescribeRainfall.Name = "mnuClimaticDescribeRainfall"
        '
        'mnuClimaticDescribeTemperatures
        '
        resources.ApplyResources(Me.mnuClimaticDescribeTemperatures, "mnuClimaticDescribeTemperatures")
        Me.mnuClimaticDescribeTemperatures.Name = "mnuClimaticDescribeTemperatures"
        '
        'mnuClimaticDescribeWindSpeedDirection
        '
        Me.mnuClimaticDescribeWindSpeedDirection.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticDescribeWindSpeedDirectionWindRose})
        Me.mnuClimaticDescribeWindSpeedDirection.Name = "mnuClimaticDescribeWindSpeedDirection"
        resources.ApplyResources(Me.mnuClimaticDescribeWindSpeedDirection, "mnuClimaticDescribeWindSpeedDirection")
        '
        'mnuClimaticDescribeWindSpeedDirectionWindRose
        '
        Me.mnuClimaticDescribeWindSpeedDirectionWindRose.Name = "mnuClimaticDescribeWindSpeedDirectionWindRose"
        resources.ApplyResources(Me.mnuClimaticDescribeWindSpeedDirectionWindRose, "mnuClimaticDescribeWindSpeedDirectionWindRose")
        '
        'mnuClimaticDescribeSunshineRadiation
        '
        resources.ApplyResources(Me.mnuClimaticDescribeSunshineRadiation, "mnuClimaticDescribeSunshineRadiation")
        Me.mnuClimaticDescribeSunshineRadiation.Name = "mnuClimaticDescribeSunshineRadiation"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        resources.ApplyResources(Me.ToolStripSeparator17, "ToolStripSeparator17")
        '
        'mnuClimaticDescribeGeneral
        '
        resources.ApplyResources(Me.mnuClimaticDescribeGeneral, "mnuClimaticDescribeGeneral")
        Me.mnuClimaticDescribeGeneral.Name = "mnuClimaticDescribeGeneral"
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        resources.ApplyResources(Me.ToolStripSeparator31, "ToolStripSeparator31")
        '
        'mnuClimaticPICSA
        '
        Me.mnuClimaticPICSA.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticPICSARainfall, Me.mnuClimaticPICSATemperature, Me.mnuClimaticPICSACrops})
        Me.mnuClimaticPICSA.Name = "mnuClimaticPICSA"
        resources.ApplyResources(Me.mnuClimaticPICSA, "mnuClimaticPICSA")
        '
        'mnuClimaticPICSARainfall
        '
        Me.mnuClimaticPICSARainfall.Name = "mnuClimaticPICSARainfall"
        resources.ApplyResources(Me.mnuClimaticPICSARainfall, "mnuClimaticPICSARainfall")
        '
        'mnuClimaticPICSATemperature
        '
        resources.ApplyResources(Me.mnuClimaticPICSATemperature, "mnuClimaticPICSATemperature")
        Me.mnuClimaticPICSATemperature.Name = "mnuClimaticPICSATemperature"
        '
        'mnuClimaticPICSACrops
        '
        Me.mnuClimaticPICSACrops.Name = "mnuClimaticPICSACrops"
        resources.ApplyResources(Me.mnuClimaticPICSACrops, "mnuClimaticPICSACrops")
        '
        'mnuCMSAF
        '
        Me.mnuCMSAF.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticCMSAFPlotRegion, Me.mnuClimaticCMSAFExporttoCMSAFRToolbox})
        Me.mnuCMSAF.Name = "mnuCMSAF"
        resources.ApplyResources(Me.mnuCMSAF, "mnuCMSAF")
        '
        'mnuClimaticCMSAFPlotRegion
        '
        Me.mnuClimaticCMSAFPlotRegion.Name = "mnuClimaticCMSAFPlotRegion"
        resources.ApplyResources(Me.mnuClimaticCMSAFPlotRegion, "mnuClimaticCMSAFPlotRegion")
        '
        'mnuClimaticCMSAFExporttoCMSAFRToolbox
        '
        Me.mnuClimaticCMSAFExporttoCMSAFRToolbox.Name = "mnuClimaticCMSAFExporttoCMSAFRToolbox"
        resources.ApplyResources(Me.mnuClimaticCMSAFExporttoCMSAFRToolbox, "mnuClimaticCMSAFExporttoCMSAFRToolbox")
        '
        'mnuClimaticModels
        '
        Me.mnuClimaticModels.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticModelSPI, Me.mnuClimaticModelsExtremes, Me.mnuClimaticModelsCircular, Me.mnuClimaticModelsMarkovModelling})
        Me.mnuClimaticModels.Name = "mnuClimaticModels"
        resources.ApplyResources(Me.mnuClimaticModels, "mnuClimaticModels")
        '
        'mnuClimaticModelsExtremes
        '
        Me.mnuClimaticModelsExtremes.Name = "mnuClimaticModelsExtremes"
        resources.ApplyResources(Me.mnuClimaticModelsExtremes, "mnuClimaticModelsExtremes")
        '
        'mnuClimaticModelsCircular
        '
        resources.ApplyResources(Me.mnuClimaticModelsCircular, "mnuClimaticModelsCircular")
        Me.mnuClimaticModelsCircular.Name = "mnuClimaticModelsCircular"
        '
        'mnuClimaticModelsMarkovModelling
        '
        Me.mnuClimaticModelsMarkovModelling.Name = "mnuClimaticModelsMarkovModelling"
        resources.ApplyResources(Me.mnuClimaticModelsMarkovModelling, "mnuClimaticModelsMarkovModelling")
        Me.mnuClimaticModelsMarkovModelling.Tag = "Markov_Modelling"
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        resources.ApplyResources(Me.ToolStripSeparator23, "ToolStripSeparator23")
        '
        'mnuClimaticSCF
        '
        Me.mnuClimaticSCF.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticSCFSupportOpenSST, Me.mnuClimaticSCFSupportExporttoCPT, Me.ToolStripSeparator32, Me.mnuClimaticSCFSupportCorrelations, Me.mnuClimaticSCFSupportPrincipalComponents, Me.mnuClimaticSCFSupportCanonicalCorrelations, Me.mnuClimaticSCFSupportCumulativeExceedanceGraphs})
        Me.mnuClimaticSCF.Name = "mnuClimaticSCF"
        resources.ApplyResources(Me.mnuClimaticSCF, "mnuClimaticSCF")
        '
        'mnuClimaticSCFSupportOpenSST
        '
        Me.mnuClimaticSCFSupportOpenSST.Name = "mnuClimaticSCFSupportOpenSST"
        resources.ApplyResources(Me.mnuClimaticSCFSupportOpenSST, "mnuClimaticSCFSupportOpenSST")
        '
        'mnuClimaticSCFSupportExporttoCPT
        '
        Me.mnuClimaticSCFSupportExporttoCPT.Name = "mnuClimaticSCFSupportExporttoCPT"
        resources.ApplyResources(Me.mnuClimaticSCFSupportExporttoCPT, "mnuClimaticSCFSupportExporttoCPT")
        Me.mnuClimaticSCFSupportExporttoCPT.Tag = "Export_to_CPT"
        '
        'ToolStripSeparator32
        '
        Me.ToolStripSeparator32.Name = "ToolStripSeparator32"
        resources.ApplyResources(Me.ToolStripSeparator32, "ToolStripSeparator32")
        '
        'mnuClimaticSCFSupportCorrelations
        '
        Me.mnuClimaticSCFSupportCorrelations.Name = "mnuClimaticSCFSupportCorrelations"
        resources.ApplyResources(Me.mnuClimaticSCFSupportCorrelations, "mnuClimaticSCFSupportCorrelations")
        '
        'mnuClimaticSCFSupportPrincipalComponents
        '
        Me.mnuClimaticSCFSupportPrincipalComponents.Name = "mnuClimaticSCFSupportPrincipalComponents"
        resources.ApplyResources(Me.mnuClimaticSCFSupportPrincipalComponents, "mnuClimaticSCFSupportPrincipalComponents")
        '
        'mnuClimaticSCFSupportCanonicalCorrelations
        '
        Me.mnuClimaticSCFSupportCanonicalCorrelations.Name = "mnuClimaticSCFSupportCanonicalCorrelations"
        resources.ApplyResources(Me.mnuClimaticSCFSupportCanonicalCorrelations, "mnuClimaticSCFSupportCanonicalCorrelations")
        '
        'mnuClimaticSCFSupportCumulativeExceedanceGraphs
        '
        Me.mnuClimaticSCFSupportCumulativeExceedanceGraphs.Name = "mnuClimaticSCFSupportCumulativeExceedanceGraphs"
        resources.ApplyResources(Me.mnuClimaticSCFSupportCumulativeExceedanceGraphs, "mnuClimaticSCFSupportCumulativeExceedanceGraphs")
        '
        'mnuClimateMethods
        '
        Me.mnuClimateMethods.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimateMethodsDataManipulation, Me.mnuClimateMethodsGraphics, Me.mnuClimateMethodsModel, Me.mnuClimateMethodsAdditional, Me.mnuClimateMethodsCreateClimateObject})
        Me.mnuClimateMethods.Name = "mnuClimateMethods"
        resources.ApplyResources(Me.mnuClimateMethods, "mnuClimateMethods")
        Me.mnuClimateMethods.Tag = "Climatic_Methods"
        '
        'mnuClimateMethodsDataManipulation
        '
        Me.mnuClimateMethodsDataManipulation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimateMethodsDataManipulationStartOfRain, Me.mnuClimateMethodsDataManipulationEndOfRain, Me.mnuClimateMethodsDataManipulationChangeFormatDayMonth, Me.mnuClimateMethodsDataManipulationExportCPTToTabular, Me.mnuClimateMethodsDataManipulationDayMonth, Me.mnuClimateMethodsDataManipulationDisplayDaily, Me.mnuClimateMethodsDataManipulationDisplayDOYOfYear, Me.mnuClimateMethodsDataManipulationDisplayRainRunningTotal, Me.mnuClimateMethodsDataManipulationDisplaySpellLength, Me.mnuClimateMethodsDataManipulationExportForPICSA, Me.mnuClimateMethodsDataManipulationExtremeEvents, Me.mnuClimateMethodsDataManipulationMissingData, Me.mnuClimateMethodsDataManipulationMissingDataTable, Me.mnuClimateMethodsDataManipulationMonthlySummaries, Me.mnuClimateMethodsDataManipulationOutputForCD})
        Me.mnuClimateMethodsDataManipulation.Name = "mnuClimateMethodsDataManipulation"
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulation, "mnuClimateMethodsDataManipulation")
        Me.mnuClimateMethodsDataManipulation.Tag = "Data_Manipulation"
        '
        'mnuClimateMethodsDataManipulationStartOfRain
        '
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulationStartOfRain, "mnuClimateMethodsDataManipulationStartOfRain")
        Me.mnuClimateMethodsDataManipulationStartOfRain.Name = "mnuClimateMethodsDataManipulationStartOfRain"
        Me.mnuClimateMethodsDataManipulationStartOfRain.Tag = "Start_of_Rain"
        '
        'mnuClimateMethodsDataManipulationEndOfRain
        '
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulationEndOfRain, "mnuClimateMethodsDataManipulationEndOfRain")
        Me.mnuClimateMethodsDataManipulationEndOfRain.Name = "mnuClimateMethodsDataManipulationEndOfRain"
        Me.mnuClimateMethodsDataManipulationEndOfRain.Tag = "End_of_Rain"
        '
        'mnuClimateMethodsDataManipulationChangeFormatDayMonth
        '
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulationChangeFormatDayMonth, "mnuClimateMethodsDataManipulationChangeFormatDayMonth")
        Me.mnuClimateMethodsDataManipulationChangeFormatDayMonth.Name = "mnuClimateMethodsDataManipulationChangeFormatDayMonth"
        Me.mnuClimateMethodsDataManipulationChangeFormatDayMonth.Tag = "Change_Format_Month"
        '
        'mnuClimateMethodsDataManipulationExportCPTToTabular
        '
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulationExportCPTToTabular, "mnuClimateMethodsDataManipulationExportCPTToTabular")
        Me.mnuClimateMethodsDataManipulationExportCPTToTabular.Name = "mnuClimateMethodsDataManipulationExportCPTToTabular"
        Me.mnuClimateMethodsDataManipulationExportCPTToTabular.Tag = "Expot_CPT_to_Tabular"
        '
        'mnuClimateMethodsDataManipulationDayMonth
        '
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulationDayMonth, "mnuClimateMethodsDataManipulationDayMonth")
        Me.mnuClimateMethodsDataManipulationDayMonth.Name = "mnuClimateMethodsDataManipulationDayMonth"
        Me.mnuClimateMethodsDataManipulationDayMonth.Tag = "Day_Month"
        '
        'mnuClimateMethodsDataManipulationDisplayDaily
        '
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulationDisplayDaily, "mnuClimateMethodsDataManipulationDisplayDaily")
        Me.mnuClimateMethodsDataManipulationDisplayDaily.Name = "mnuClimateMethodsDataManipulationDisplayDaily"
        Me.mnuClimateMethodsDataManipulationDisplayDaily.Tag = "Display_Daily"
        '
        'mnuClimateMethodsDataManipulationDisplayDOYOfYear
        '
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulationDisplayDOYOfYear, "mnuClimateMethodsDataManipulationDisplayDOYOfYear")
        Me.mnuClimateMethodsDataManipulationDisplayDOYOfYear.Name = "mnuClimateMethodsDataManipulationDisplayDOYOfYear"
        Me.mnuClimateMethodsDataManipulationDisplayDOYOfYear.Tag = "Display_DOY_of_Year"
        '
        'mnuClimateMethodsDataManipulationDisplayRainRunningTotal
        '
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulationDisplayRainRunningTotal, "mnuClimateMethodsDataManipulationDisplayRainRunningTotal")
        Me.mnuClimateMethodsDataManipulationDisplayRainRunningTotal.Name = "mnuClimateMethodsDataManipulationDisplayRainRunningTotal"
        Me.mnuClimateMethodsDataManipulationDisplayRainRunningTotal.Tag = "Display_Rain_Running_Total"
        '
        'mnuClimateMethodsDataManipulationDisplaySpellLength
        '
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulationDisplaySpellLength, "mnuClimateMethodsDataManipulationDisplaySpellLength")
        Me.mnuClimateMethodsDataManipulationDisplaySpellLength.Name = "mnuClimateMethodsDataManipulationDisplaySpellLength"
        Me.mnuClimateMethodsDataManipulationDisplaySpellLength.Tag = "Display_Spell_length"
        '
        'mnuClimateMethodsDataManipulationExportForPICSA
        '
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulationExportForPICSA, "mnuClimateMethodsDataManipulationExportForPICSA")
        Me.mnuClimateMethodsDataManipulationExportForPICSA.Name = "mnuClimateMethodsDataManipulationExportForPICSA"
        Me.mnuClimateMethodsDataManipulationExportForPICSA.Tag = "Export_for_PICSA"
        '
        'mnuClimateMethodsDataManipulationExtremeEvents
        '
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulationExtremeEvents, "mnuClimateMethodsDataManipulationExtremeEvents")
        Me.mnuClimateMethodsDataManipulationExtremeEvents.Name = "mnuClimateMethodsDataManipulationExtremeEvents"
        Me.mnuClimateMethodsDataManipulationExtremeEvents.Tag = "Extreme_Events"
        '
        'mnuClimateMethodsDataManipulationMissingData
        '
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulationMissingData, "mnuClimateMethodsDataManipulationMissingData")
        Me.mnuClimateMethodsDataManipulationMissingData.Name = "mnuClimateMethodsDataManipulationMissingData"
        Me.mnuClimateMethodsDataManipulationMissingData.Tag = "Missing_Data"
        '
        'mnuClimateMethodsDataManipulationMissingDataTable
        '
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulationMissingDataTable, "mnuClimateMethodsDataManipulationMissingDataTable")
        Me.mnuClimateMethodsDataManipulationMissingDataTable.Name = "mnuClimateMethodsDataManipulationMissingDataTable"
        Me.mnuClimateMethodsDataManipulationMissingDataTable.Tag = "Missing_Data_Table"
        '
        'mnuClimateMethodsDataManipulationMonthlySummaries
        '
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulationMonthlySummaries, "mnuClimateMethodsDataManipulationMonthlySummaries")
        Me.mnuClimateMethodsDataManipulationMonthlySummaries.Name = "mnuClimateMethodsDataManipulationMonthlySummaries"
        Me.mnuClimateMethodsDataManipulationMonthlySummaries.Tag = "Monthly_Summaries"
        '
        'mnuClimateMethodsDataManipulationOutputForCD
        '
        resources.ApplyResources(Me.mnuClimateMethodsDataManipulationOutputForCD, "mnuClimateMethodsDataManipulationOutputForCD")
        Me.mnuClimateMethodsDataManipulationOutputForCD.Name = "mnuClimateMethodsDataManipulationOutputForCD"
        Me.mnuClimateMethodsDataManipulationOutputForCD.Tag = "Output_for_CDT"
        '
        'mnuClimateMethodsGraphics
        '
        Me.mnuClimateMethodsGraphics.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimateMethodsGraphicsClipBoxPlot, Me.mnuClimateMethodsGraphicsCliplot, Me.mnuClimateMethodsGraphicsMissingValues, Me.mnuClimateMethodsGraphicsHistogram, Me.mnuClimateMethodsGraphicsCumExceedance, Me.mnuClimateMethodsGraphicsBoxplot, Me.mnuClimateMethodsGraphicsInventory, Me.mnuClimateMethodsGraphicsAnnualRainfall, Me.mnuClimateMethodsGraphicsRainCount, Me.mnuClimateMethodsGraphicsTimeseries, Me.mnuClimateMethodsGraphicsWindrose, Me.mnuClimateMethodsGraphicsMultipleLines, Me.mnuClmateMethodThreeSummaries})
        Me.mnuClimateMethodsGraphics.Name = "mnuClimateMethodsGraphics"
        resources.ApplyResources(Me.mnuClimateMethodsGraphics, "mnuClimateMethodsGraphics")
        Me.mnuClimateMethodsGraphics.Tag = "Graphics"
        '
        'mnuClimateMethodsGraphicsClipBoxPlot
        '
        resources.ApplyResources(Me.mnuClimateMethodsGraphicsClipBoxPlot, "mnuClimateMethodsGraphicsClipBoxPlot")
        Me.mnuClimateMethodsGraphicsClipBoxPlot.Name = "mnuClimateMethodsGraphicsClipBoxPlot"
        Me.mnuClimateMethodsGraphicsClipBoxPlot.Tag = "Cliboxplot"
        '
        'mnuClimateMethodsGraphicsCliplot
        '
        resources.ApplyResources(Me.mnuClimateMethodsGraphicsCliplot, "mnuClimateMethodsGraphicsCliplot")
        Me.mnuClimateMethodsGraphicsCliplot.Name = "mnuClimateMethodsGraphicsCliplot"
        Me.mnuClimateMethodsGraphicsCliplot.Tag = "Cliplot"
        '
        'mnuClimateMethodsGraphicsMissingValues
        '
        resources.ApplyResources(Me.mnuClimateMethodsGraphicsMissingValues, "mnuClimateMethodsGraphicsMissingValues")
        Me.mnuClimateMethodsGraphicsMissingValues.Name = "mnuClimateMethodsGraphicsMissingValues"
        Me.mnuClimateMethodsGraphicsMissingValues.Tag = "Missing_values"
        '
        'mnuClimateMethodsGraphicsHistogram
        '
        resources.ApplyResources(Me.mnuClimateMethodsGraphicsHistogram, "mnuClimateMethodsGraphicsHistogram")
        Me.mnuClimateMethodsGraphicsHistogram.Name = "mnuClimateMethodsGraphicsHistogram"
        Me.mnuClimateMethodsGraphicsHistogram.Tag = "Histogram"
        '
        'mnuClimateMethodsGraphicsCumExceedance
        '
        resources.ApplyResources(Me.mnuClimateMethodsGraphicsCumExceedance, "mnuClimateMethodsGraphicsCumExceedance")
        Me.mnuClimateMethodsGraphicsCumExceedance.Name = "mnuClimateMethodsGraphicsCumExceedance"
        Me.mnuClimateMethodsGraphicsCumExceedance.Tag = "Cumulative_Exceedence"
        '
        'mnuClimateMethodsGraphicsBoxplot
        '
        resources.ApplyResources(Me.mnuClimateMethodsGraphicsBoxplot, "mnuClimateMethodsGraphicsBoxplot")
        Me.mnuClimateMethodsGraphicsBoxplot.Name = "mnuClimateMethodsGraphicsBoxplot"
        Me.mnuClimateMethodsGraphicsBoxplot.Tag = "Boxplot"
        '
        'mnuClimateMethodsGraphicsInventory
        '
        resources.ApplyResources(Me.mnuClimateMethodsGraphicsInventory, "mnuClimateMethodsGraphicsInventory")
        Me.mnuClimateMethodsGraphicsInventory.Name = "mnuClimateMethodsGraphicsInventory"
        Me.mnuClimateMethodsGraphicsInventory.Tag = "Inventory"
        '
        'mnuClimateMethodsGraphicsAnnualRainfall
        '
        resources.ApplyResources(Me.mnuClimateMethodsGraphicsAnnualRainfall, "mnuClimateMethodsGraphicsAnnualRainfall")
        Me.mnuClimateMethodsGraphicsAnnualRainfall.Name = "mnuClimateMethodsGraphicsAnnualRainfall"
        Me.mnuClimateMethodsGraphicsAnnualRainfall.Tag = "Annual_rainfall"
        '
        'mnuClimateMethodsGraphicsRainCount
        '
        resources.ApplyResources(Me.mnuClimateMethodsGraphicsRainCount, "mnuClimateMethodsGraphicsRainCount")
        Me.mnuClimateMethodsGraphicsRainCount.Name = "mnuClimateMethodsGraphicsRainCount"
        Me.mnuClimateMethodsGraphicsRainCount.Tag = "Rain_count"
        '
        'mnuClimateMethodsGraphicsTimeseries
        '
        resources.ApplyResources(Me.mnuClimateMethodsGraphicsTimeseries, "mnuClimateMethodsGraphicsTimeseries")
        Me.mnuClimateMethodsGraphicsTimeseries.Name = "mnuClimateMethodsGraphicsTimeseries"
        Me.mnuClimateMethodsGraphicsTimeseries.Tag = "Timeseries"
        '
        'mnuClimateMethodsGraphicsWindrose
        '
        resources.ApplyResources(Me.mnuClimateMethodsGraphicsWindrose, "mnuClimateMethodsGraphicsWindrose")
        Me.mnuClimateMethodsGraphicsWindrose.Name = "mnuClimateMethodsGraphicsWindrose"
        Me.mnuClimateMethodsGraphicsWindrose.Tag = "Windrose"
        '
        'mnuClimateMethodsGraphicsMultipleLines
        '
        resources.ApplyResources(Me.mnuClimateMethodsGraphicsMultipleLines, "mnuClimateMethodsGraphicsMultipleLines")
        Me.mnuClimateMethodsGraphicsMultipleLines.Name = "mnuClimateMethodsGraphicsMultipleLines"
        Me.mnuClimateMethodsGraphicsMultipleLines.Tag = "Multiple_lines"
        '
        'mnuClmateMethodThreeSummaries
        '
        resources.ApplyResources(Me.mnuClmateMethodThreeSummaries, "mnuClmateMethodThreeSummaries")
        Me.mnuClmateMethodThreeSummaries.Name = "mnuClmateMethodThreeSummaries"
        Me.mnuClmateMethodThreeSummaries.Tag = "Three_Summaries"
        '
        'mnuClimateMethodsModel
        '
        resources.ApplyResources(Me.mnuClimateMethodsModel, "mnuClimateMethodsModel")
        Me.mnuClimateMethodsModel.Name = "mnuClimateMethodsModel"
        Me.mnuClimateMethodsModel.Tag = "Model"
        '
        'mnuClimateMethodsAdditional
        '
        Me.mnuClimateMethodsAdditional.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimateMethodsAdditionalOutputForCPT, Me.mnuClimateMethodsAdditionalRainsStatistics, Me.mnuClimateMethodsAdditionalSeasonalSummary, Me.mnuClimateMethodsAdditionalSeasonalSummaryRain, Me.mnuClimateMethodsAdditionalWaterBalance})
        Me.mnuClimateMethodsAdditional.Name = "mnuClimateMethodsAdditional"
        resources.ApplyResources(Me.mnuClimateMethodsAdditional, "mnuClimateMethodsAdditional")
        Me.mnuClimateMethodsAdditional.Tag = "Additional"
        '
        'mnuClimateMethodsAdditionalOutputForCPT
        '
        resources.ApplyResources(Me.mnuClimateMethodsAdditionalOutputForCPT, "mnuClimateMethodsAdditionalOutputForCPT")
        Me.mnuClimateMethodsAdditionalOutputForCPT.Name = "mnuClimateMethodsAdditionalOutputForCPT"
        Me.mnuClimateMethodsAdditionalOutputForCPT.Tag = "Output_for_CPT"
        '
        'mnuClimateMethodsAdditionalRainsStatistics
        '
        resources.ApplyResources(Me.mnuClimateMethodsAdditionalRainsStatistics, "mnuClimateMethodsAdditionalRainsStatistics")
        Me.mnuClimateMethodsAdditionalRainsStatistics.Name = "mnuClimateMethodsAdditionalRainsStatistics"
        Me.mnuClimateMethodsAdditionalRainsStatistics.Tag = "Rain_Statistics"
        '
        'mnuClimateMethodsAdditionalSeasonalSummary
        '
        resources.ApplyResources(Me.mnuClimateMethodsAdditionalSeasonalSummary, "mnuClimateMethodsAdditionalSeasonalSummary")
        Me.mnuClimateMethodsAdditionalSeasonalSummary.Name = "mnuClimateMethodsAdditionalSeasonalSummary"
        Me.mnuClimateMethodsAdditionalSeasonalSummary.Tag = "Seasonal_Summary"
        '
        'mnuClimateMethodsAdditionalSeasonalSummaryRain
        '
        resources.ApplyResources(Me.mnuClimateMethodsAdditionalSeasonalSummaryRain, "mnuClimateMethodsAdditionalSeasonalSummaryRain")
        Me.mnuClimateMethodsAdditionalSeasonalSummaryRain.Name = "mnuClimateMethodsAdditionalSeasonalSummaryRain"
        Me.mnuClimateMethodsAdditionalSeasonalSummaryRain.Tag = "Seasonal_Summary_Rain"
        '
        'mnuClimateMethodsAdditionalWaterBalance
        '
        resources.ApplyResources(Me.mnuClimateMethodsAdditionalWaterBalance, "mnuClimateMethodsAdditionalWaterBalance")
        Me.mnuClimateMethodsAdditionalWaterBalance.Name = "mnuClimateMethodsAdditionalWaterBalance"
        Me.mnuClimateMethodsAdditionalWaterBalance.Tag = "Water_Balance"
        '
        'mnuClimateMethodsCreateClimateObject
        '
        resources.ApplyResources(Me.mnuClimateMethodsCreateClimateObject, "mnuClimateMethodsCreateClimateObject")
        Me.mnuClimateMethodsCreateClimateObject.Name = "mnuClimateMethodsCreateClimateObject"
        Me.mnuClimateMethodsCreateClimateObject.Tag = "Create_Climate_Object"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        resources.ApplyResources(Me.mnuFileSave, "mnuFileSave")
        Me.mnuFileSave.Tag = "Save"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileSaveAsDataAs, Me.mnuFileSaveAsOutputAs, Me.mnuFileSaveAsLogAs, Me.mnuFileSaveAsScriptAs})
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        resources.ApplyResources(Me.mnuFileSaveAs, "mnuFileSaveAs")
        Me.mnuFileSaveAs.Tag = "Save_As"
        '
        'mnuFileSaveAsDataAs
        '
        Me.mnuFileSaveAsDataAs.Name = "mnuFileSaveAsDataAs"
        resources.ApplyResources(Me.mnuFileSaveAsDataAs, "mnuFileSaveAsDataAs")
        '
        'mnuFileSaveAsOutputAs
        '
        Me.mnuFileSaveAsOutputAs.Name = "mnuFileSaveAsOutputAs"
        resources.ApplyResources(Me.mnuFileSaveAsOutputAs, "mnuFileSaveAsOutputAs")
        '
        'mnuFileSaveAsLogAs
        '
        Me.mnuFileSaveAsLogAs.Name = "mnuFileSaveAsLogAs"
        resources.ApplyResources(Me.mnuFileSaveAsLogAs, "mnuFileSaveAsLogAs")
        '
        'mnuFileSaveAsScriptAs
        '
        Me.mnuFileSaveAsScriptAs.Name = "mnuFileSaveAsScriptAs"
        resources.ApplyResources(Me.mnuFileSaveAsScriptAs, "mnuFileSaveAsScriptAs")
        '
        'mnuFilePrint
        '
        resources.ApplyResources(Me.mnuFilePrint, "mnuFilePrint")
        Me.mnuFilePrint.Name = "mnuFilePrint"
        Me.mnuFilePrint.Tag = "Print"
        '
        'mnuFilePrintPreview
        '
        resources.ApplyResources(Me.mnuFilePrintPreview, "mnuFilePrintPreview")
        Me.mnuFilePrintPreview.Name = "mnuFilePrintPreview"
        Me.mnuFilePrintPreview.Tag = "Print_Preview"
        '
        'tlSeparatorFile3
        '
        Me.tlSeparatorFile3.Name = "tlSeparatorFile3"
        resources.ApplyResources(Me.tlSeparatorFile3, "tlSeparatorFile3")
        '
        'mnuFIleExit
        '
        Me.mnuFIleExit.Name = "mnuFIleExit"
        resources.ApplyResources(Me.mnuFIleExit, "mnuFIleExit")
        Me.mnuFIleExit.Tag = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditFind, Me.mnuEditFindNext, Me.mnuEditReplace, Me.mnuEditCut, Me.mnuEditCopy, Me.mnuEditCopySpecial, Me.mnuEditPaste, Me.mnuEditSelectAll})
        Me.mnuEdit.Name = "mnuEdit"
        resources.ApplyResources(Me.mnuEdit, "mnuEdit")
        Me.mnuEdit.Tag = "Edit"
        '
        'mnuEditFind
        '
        resources.ApplyResources(Me.mnuEditFind, "mnuEditFind")
        Me.mnuEditFind.Name = "mnuEditFind"
        Me.mnuEditFind.Tag = "Find"
        '
        'mnuEditFindNext
        '
        resources.ApplyResources(Me.mnuEditFindNext, "mnuEditFindNext")
        Me.mnuEditFindNext.Name = "mnuEditFindNext"
        '
        'mnuEditReplace
        '
        resources.ApplyResources(Me.mnuEditReplace, "mnuEditReplace")
        Me.mnuEditReplace.Name = "mnuEditReplace"
        Me.mnuEditReplace.Tag = "Replace"
        '
        'mnuEditCut
        '
        resources.ApplyResources(Me.mnuEditCut, "mnuEditCut")
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.Tag = "Cut"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        resources.ApplyResources(Me.mnuEditCopy, "mnuEditCopy")
        Me.mnuEditCopy.Tag = "Copy"
        '
        'mnuEditCopySpecial
        '
        resources.ApplyResources(Me.mnuEditCopySpecial, "mnuEditCopySpecial")
        Me.mnuEditCopySpecial.Name = "mnuEditCopySpecial"
        Me.mnuEditCopySpecial.Tag = "Copy_Special"
        '
        'mnuEditPaste
        '
        resources.ApplyResources(Me.mnuEditPaste, "mnuEditPaste")
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.Tag = "Paste"
        '
        'mnuEditSelectAll
        '
        Me.mnuEditSelectAll.Name = "mnuEditSelectAll"
        resources.ApplyResources(Me.mnuEditSelectAll, "mnuEditSelectAll")
        Me.mnuEditSelectAll.Tag = "Select_All"
        '
        'stsStrip
        '
        Me.stsStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.stsStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstatus})
        resources.ApplyResources(Me.stsStrip, "stsStrip")
        Me.stsStrip.Name = "stsStrip"
        Me.stsStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        '
        'tstatus
        '
        Me.tstatus.Name = "tstatus"
        resources.ApplyResources(Me.tstatus, "tstatus")
        '
        'Tool_strip
        '
        Me.Tool_strip.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Tool_strip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Tool_strip.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.Tool_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTbOpen, Me.mnuTbOpenFromLibrary, Me.mnuTbSave, Me.toolStripSeparator, Me.mnuTbCopy, Me.mnuTbPaste, Me.separator1, Me.mnuTbEditLastDialog, Me.mnuTbLast10Dialogs, Me.mnuTbLastGraph, Me.separator2, Me.mnuTbDataView, Me.mnuTbOutput, Me.mnuTbColumnMetadata, Me.mnuTbLog, Me.mnuTbResetLayout, Me.separator3, Me.mnuTbHelp})
        resources.ApplyResources(Me.Tool_strip, "Tool_strip")
        Me.Tool_strip.Name = "Tool_strip"
        Me.Tool_strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        '
        'mnuTbOpen
        '
        Me.mnuTbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbOpen.Image = Global.instat.My.Resources.Resources.openfromfile2
        resources.ApplyResources(Me.mnuTbOpen, "mnuTbOpen")
        Me.mnuTbOpen.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbOpen.Name = "mnuTbOpen"
        '
        'mnuTbOpenFromLibrary
        '
        Me.mnuTbOpenFromLibrary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbOpenFromLibrary.Image = Global.instat.My.Resources.Resources.openfromlibrary
        resources.ApplyResources(Me.mnuTbOpenFromLibrary, "mnuTbOpenFromLibrary")
        Me.mnuTbOpenFromLibrary.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbOpenFromLibrary.Name = "mnuTbOpenFromLibrary"
        '
        'mnuTbSave
        '
        Me.mnuTbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbSave.Image = Global.instat.My.Resources.Resources.save2
        resources.ApplyResources(Me.mnuTbSave, "mnuTbSave")
        Me.mnuTbSave.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbSave.Name = "mnuTbSave"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        resources.ApplyResources(Me.toolStripSeparator, "toolStripSeparator")
        '
        'mnuTbCopy
        '
        Me.mnuTbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbCopy.Image = Global.instat.My.Resources.Resources.copy2
        resources.ApplyResources(Me.mnuTbCopy, "mnuTbCopy")
        Me.mnuTbCopy.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbCopy.Name = "mnuTbCopy"
        '
        'mnuTbPaste
        '
        Me.mnuTbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.mnuTbPaste, "mnuTbPaste")
        Me.mnuTbPaste.Image = Global.instat.My.Resources.Resources.paste2
        Me.mnuTbPaste.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbPaste.Name = "mnuTbPaste"
        '
        'separator1
        '
        Me.separator1.Name = "separator1"
        resources.ApplyResources(Me.separator1, "separator1")
        '
        'mnuTbEditLastDialog
        '
        Me.mnuTbEditLastDialog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbEditLastDialog.Image = Global.instat.My.Resources.Resources.dialog2
        resources.ApplyResources(Me.mnuTbEditLastDialog, "mnuTbEditLastDialog")
        Me.mnuTbEditLastDialog.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbEditLastDialog.Name = "mnuTbEditLastDialog"
        '
        'mnuTbLast10Dialogs
        '
        Me.mnuTbLast10Dialogs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbLast10Dialogs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sepStart, Me.sepEnd})
        Me.mnuTbLast10Dialogs.Image = Global.instat.My.Resources.Resources.last10dialogs
        resources.ApplyResources(Me.mnuTbLast10Dialogs, "mnuTbLast10Dialogs")
        Me.mnuTbLast10Dialogs.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbLast10Dialogs.Name = "mnuTbLast10Dialogs"
        '
        'sepStart
        '
        Me.sepStart.Name = "sepStart"
        resources.ApplyResources(Me.sepStart, "sepStart")
        '
        'sepEnd
        '
        Me.sepEnd.Name = "sepEnd"
        resources.ApplyResources(Me.sepEnd, "sepEnd")
        '
        'mnuTbLastGraph
        '
        Me.mnuTbLastGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbLastGraph.Image = Global.instat.My.Resources.Resources.lastgraph
        resources.ApplyResources(Me.mnuTbLastGraph, "mnuTbLastGraph")
        Me.mnuTbLastGraph.Name = "mnuTbLastGraph"
        '
        'separator2
        '
        Me.separator2.Name = "separator2"
        resources.ApplyResources(Me.separator2, "separator2")
        '
        'mnuTbDataView
        '
        Me.mnuTbDataView.CheckOnClick = True
        Me.mnuTbDataView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbDataView.Image = Global.instat.My.Resources.Resources.dataframe2
        resources.ApplyResources(Me.mnuTbDataView, "mnuTbDataView")
        Me.mnuTbDataView.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbDataView.Name = "mnuTbDataView"
        '
        'mnuTbOutput
        '
        Me.mnuTbOutput.CheckOnClick = True
        Me.mnuTbOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbOutput.Image = Global.instat.My.Resources.Resources.output3
        resources.ApplyResources(Me.mnuTbOutput, "mnuTbOutput")
        Me.mnuTbOutput.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbOutput.Name = "mnuTbOutput"
        '
        'mnuTbColumnMetadata
        '
        Me.mnuTbColumnMetadata.CheckOnClick = True
        Me.mnuTbColumnMetadata.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbColumnMetadata.Image = Global.instat.My.Resources.Resources.columnmetadata
        resources.ApplyResources(Me.mnuTbColumnMetadata, "mnuTbColumnMetadata")
        Me.mnuTbColumnMetadata.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbColumnMetadata.Name = "mnuTbColumnMetadata"
        '
        'mnuTbLog
        '
        Me.mnuTbLog.CheckOnClick = True
        Me.mnuTbLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbLog.Image = Global.instat.My.Resources.Resources.script2
        resources.ApplyResources(Me.mnuTbLog, "mnuTbLog")
        Me.mnuTbLog.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbLog.Name = "mnuTbLog"
        '
        'mnuTbResetLayout
        '
        Me.mnuTbResetLayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbResetLayout.Image = Global.instat.My.Resources.Resources.reset3
        resources.ApplyResources(Me.mnuTbResetLayout, "mnuTbResetLayout")
        Me.mnuTbResetLayout.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbResetLayout.Name = "mnuTbResetLayout"
        '
        'separator3
        '
        Me.separator3.Name = "separator3"
        resources.ApplyResources(Me.separator3, "separator3")
        '
        'mnuTbHelp
        '
        Me.mnuTbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbHelp.Image = Global.instat.My.Resources.Resources.help2
        resources.ApplyResources(Me.mnuTbHelp, "mnuTbHelp")
        Me.mnuTbHelp.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbHelp.Name = "mnuTbHelp"
        '
        'mnuBar
        '
        Me.mnuBar.AllowMerge = False
        Me.mnuBar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.mnuBar.ImageScalingSize = New System.Drawing.Size(24, 24)
        resources.ApplyResources(Me.mnuBar, "mnuBar")
        Me.mnuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuPrepare, Me.mnuDescribe, Me.mnuModel, Me.mnuClimatic, Me.mnuProcurement, Me.mnuOptionsByContext, Me.mnuTools, Me.mnuView, Me.mnuHelp})
        Me.mnuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.mnuBar.Name = "mnuBar"
        Me.mnuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnuBar.ShowItemToolTips = True
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNewDataFrame, Me.mnuFileOpenFromFile, Me.mnuFileOpenFromLibrary, Me.ToolStripSeparator35, Me.mnuImportFromODK, Me.ImportFromCSPROToolStripMenuItem, Me.ImportFromToolStripMenuItem, Me.OpenNETcdfFileToolStripMenuItem, Me.ToolStripSeparator27, Me.mnuFileConvert, Me.tlSeparatorFile, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuExport, Me.mnuFilePrint, Me.mnuFilePrintPreview, Me.tlSeparatorFile3, Me.mnuFileCloseData, Me.ToolStripSeparator8, Me.mnuFIleExit})
        Me.mnuFile.Name = "mnuFile"
        resources.ApplyResources(Me.mnuFile, "mnuFile")
        Me.mnuFile.Tag = "File"
        '
        'mnuFileNewDataFrame
        '
        Me.mnuFileNewDataFrame.Name = "mnuFileNewDataFrame"
        resources.ApplyResources(Me.mnuFileNewDataFrame, "mnuFileNewDataFrame")
        Me.mnuFileNewDataFrame.Tag = "New_Data_Frame"
        '
        'mnuFileOpenFromFile
        '
        Me.mnuFileOpenFromFile.Name = "mnuFileOpenFromFile"
        resources.ApplyResources(Me.mnuFileOpenFromFile, "mnuFileOpenFromFile")
        Me.mnuFileOpenFromFile.Tag = "Open_From_File"
        '
        'mnuFileOpenFromLibrary
        '
        Me.mnuFileOpenFromLibrary.Name = "mnuFileOpenFromLibrary"
        resources.ApplyResources(Me.mnuFileOpenFromLibrary, "mnuFileOpenFromLibrary")
        Me.mnuFileOpenFromLibrary.Tag = "Open_From_Library"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        resources.ApplyResources(Me.ToolStripSeparator35, "ToolStripSeparator35")
        '
        'mnuImportFromODK
        '
        Me.mnuImportFromODK.Name = "mnuImportFromODK"
        resources.ApplyResources(Me.mnuImportFromODK, "mnuImportFromODK")
        '
        'ImportFromCSPROToolStripMenuItem
        '
        resources.ApplyResources(Me.ImportFromCSPROToolStripMenuItem, "ImportFromCSPROToolStripMenuItem")
        Me.ImportFromCSPROToolStripMenuItem.Name = "ImportFromCSPROToolStripMenuItem"
        '
        'ImportFromToolStripMenuItem
        '
        resources.ApplyResources(Me.ImportFromToolStripMenuItem, "ImportFromToolStripMenuItem")
        Me.ImportFromToolStripMenuItem.Name = "ImportFromToolStripMenuItem"
        '
        'OpenNETcdfFileToolStripMenuItem
        '
        Me.OpenNETcdfFileToolStripMenuItem.Name = "OpenNETcdfFileToolStripMenuItem"
        resources.ApplyResources(Me.OpenNETcdfFileToolStripMenuItem, "OpenNETcdfFileToolStripMenuItem")
        '
        'ToolStripSeparator27
        '
        Me.ToolStripSeparator27.Name = "ToolStripSeparator27"
        resources.ApplyResources(Me.ToolStripSeparator27, "ToolStripSeparator27")
        '
        'mnuFileConvert
        '
        resources.ApplyResources(Me.mnuFileConvert, "mnuFileConvert")
        Me.mnuFileConvert.Name = "mnuFileConvert"
        '
        'tlSeparatorFile
        '
        Me.tlSeparatorFile.Name = "tlSeparatorFile"
        resources.ApplyResources(Me.tlSeparatorFile, "tlSeparatorFile")
        '
        'mnuExport
        '
        Me.mnuExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportDataSetToolStripMenuItem, Me.ExportRObjectsToolStripMenuItem, Me.ExportRWorkspaceToolStripMenuItem, Me.ExportGraphAsImageToolStripMenuItem})
        Me.mnuExport.Name = "mnuExport"
        resources.ApplyResources(Me.mnuExport, "mnuExport")
        '
        'ExportDataSetToolStripMenuItem
        '
        Me.ExportDataSetToolStripMenuItem.Name = "ExportDataSetToolStripMenuItem"
        resources.ApplyResources(Me.ExportDataSetToolStripMenuItem, "ExportDataSetToolStripMenuItem")
        '
        'ExportRObjectsToolStripMenuItem
        '
        Me.ExportRObjectsToolStripMenuItem.Name = "ExportRObjectsToolStripMenuItem"
        resources.ApplyResources(Me.ExportRObjectsToolStripMenuItem, "ExportRObjectsToolStripMenuItem")
        '
        'ExportRWorkspaceToolStripMenuItem
        '
        Me.ExportRWorkspaceToolStripMenuItem.Name = "ExportRWorkspaceToolStripMenuItem"
        resources.ApplyResources(Me.ExportRWorkspaceToolStripMenuItem, "ExportRWorkspaceToolStripMenuItem")
        '
        'ExportGraphAsImageToolStripMenuItem
        '
        Me.ExportGraphAsImageToolStripMenuItem.Name = "ExportGraphAsImageToolStripMenuItem"
        resources.ApplyResources(Me.ExportGraphAsImageToolStripMenuItem, "ExportGraphAsImageToolStripMenuItem")
        '
        'mnuFileCloseData
        '
        Me.mnuFileCloseData.Name = "mnuFileCloseData"
        resources.ApplyResources(Me.mnuFileCloseData, "mnuFileCloseData")
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        resources.ApplyResources(Me.ToolStripSeparator8, "ToolStripSeparator8")
        '
        'mnuPrepare
        '
        Me.mnuPrepare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareDataFrame, Me.mnuPrepareCheckData, Me.ToolStripSeparator6, Me.mnuPrepareColumnCalculate, Me.mnuPrepareColumnGenerate, Me.mnuPrepareColumnFactor, Me.mnuPrepareColumnText, Me.mnuPrepareColumnDate, Me.mnuPrepareColumnReshape, Me.ToolStripSeparator7, Me.mnuPrepareKeysAndLinks, Me.mnuPrepareDataObject, Me.mnuPrepareRObjects})
        Me.mnuPrepare.Name = "mnuPrepare"
        resources.ApplyResources(Me.mnuPrepare, "mnuPrepare")
        Me.mnuPrepare.Tag = "Prepare"
        '
        'mnuPrepareDataFrame
        '
        Me.mnuPrepareDataFrame.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareDataFrameViewData, Me.mnuPrepareDataFrameRenameColumn, Me.mnuPrepareDataFrameRowNumbersNames, Me.ToolStripSeparator1, Me.mnuPrepareDataFrameSort, Me.mnuPrepareDataFrameFilter, Me.mnuPrepareDataFrameReplaceValues, Me.ToolStripSeparator2, Me.mnuPrepareDataFrameConvertColumns, Me.mnuPrepareDataFrameColumnMetadata, Me.mnuPrepareDataFrameColumnStructure, Me.ToolStripSeparator20, Me.mnuPrepareDataFrameReorderColumns, Me.mnuPrepareDataFrameInsertColumnsRows, Me.mnuPrepareDataFrameDeleteColumnsRows, Me.mnuPrepareDataFrameProtectColumn, Me.mnuPrepareDataFrameHideColumns, Me.mnuPrepareDataFrameFreezeColumns, Me.ColourByPropertyToolStripMenuItem})
        Me.mnuPrepareDataFrame.Name = "mnuPrepareDataFrame"
        resources.ApplyResources(Me.mnuPrepareDataFrame, "mnuPrepareDataFrame")
        Me.mnuPrepareDataFrame.Tag = "Data_Frame"
        '
        'mnuPrepareDataFrameViewData
        '
        Me.mnuPrepareDataFrameViewData.Name = "mnuPrepareDataFrameViewData"
        resources.ApplyResources(Me.mnuPrepareDataFrameViewData, "mnuPrepareDataFrameViewData")
        Me.mnuPrepareDataFrameViewData.Tag = "View_Data..."
        '
        'mnuPrepareDataFrameRenameColumn
        '
        Me.mnuPrepareDataFrameRenameColumn.Name = "mnuPrepareDataFrameRenameColumn"
        resources.ApplyResources(Me.mnuPrepareDataFrameRenameColumn, "mnuPrepareDataFrameRenameColumn")
        Me.mnuPrepareDataFrameRenameColumn.Tag = "Rename_Column..."
        '
        'mnuPrepareDataFrameRowNumbersNames
        '
        Me.mnuPrepareDataFrameRowNumbersNames.Name = "mnuPrepareDataFrameRowNumbersNames"
        resources.ApplyResources(Me.mnuPrepareDataFrameRowNumbersNames, "mnuPrepareDataFrameRowNumbersNames")
        Me.mnuPrepareDataFrameRowNumbersNames.Tag = "Row_Numbers/Names..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'mnuPrepareDataFrameSort
        '
        Me.mnuPrepareDataFrameSort.Name = "mnuPrepareDataFrameSort"
        resources.ApplyResources(Me.mnuPrepareDataFrameSort, "mnuPrepareDataFrameSort")
        Me.mnuPrepareDataFrameSort.Tag = "Sort..."
        '
        'mnuPrepareDataFrameFilter
        '
        Me.mnuPrepareDataFrameFilter.Name = "mnuPrepareDataFrameFilter"
        resources.ApplyResources(Me.mnuPrepareDataFrameFilter, "mnuPrepareDataFrameFilter")
        Me.mnuPrepareDataFrameFilter.Tag = "Filter..."
        '
        'mnuPrepareDataFrameReplaceValues
        '
        Me.mnuPrepareDataFrameReplaceValues.Name = "mnuPrepareDataFrameReplaceValues"
        resources.ApplyResources(Me.mnuPrepareDataFrameReplaceValues, "mnuPrepareDataFrameReplaceValues")
        Me.mnuPrepareDataFrameReplaceValues.Tag = "Replace_Values..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'mnuPrepareDataFrameConvertColumns
        '
        Me.mnuPrepareDataFrameConvertColumns.Name = "mnuPrepareDataFrameConvertColumns"
        resources.ApplyResources(Me.mnuPrepareDataFrameConvertColumns, "mnuPrepareDataFrameConvertColumns")
        Me.mnuPrepareDataFrameConvertColumns.Tag = "Convert_Columns..."
        '
        'mnuPrepareDataFrameColumnMetadata
        '
        Me.mnuPrepareDataFrameColumnMetadata.Name = "mnuPrepareDataFrameColumnMetadata"
        resources.ApplyResources(Me.mnuPrepareDataFrameColumnMetadata, "mnuPrepareDataFrameColumnMetadata")
        Me.mnuPrepareDataFrameColumnMetadata.Tag = "Column_Metadata..."
        '
        'mnuPrepareDataFrameColumnStructure
        '
        Me.mnuPrepareDataFrameColumnStructure.Name = "mnuPrepareDataFrameColumnStructure"
        resources.ApplyResources(Me.mnuPrepareDataFrameColumnStructure, "mnuPrepareDataFrameColumnStructure")
        Me.mnuPrepareDataFrameColumnStructure.Tag = "Column_Structure..."
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        resources.ApplyResources(Me.ToolStripSeparator20, "ToolStripSeparator20")
        '
        'mnuPrepareDataFrameReorderColumns
        '
        Me.mnuPrepareDataFrameReorderColumns.Name = "mnuPrepareDataFrameReorderColumns"
        resources.ApplyResources(Me.mnuPrepareDataFrameReorderColumns, "mnuPrepareDataFrameReorderColumns")
        Me.mnuPrepareDataFrameReorderColumns.Tag = "Reorder_Columns..."
        '
        'mnuPrepareDataFrameInsertColumnsRows
        '
        Me.mnuPrepareDataFrameInsertColumnsRows.Name = "mnuPrepareDataFrameInsertColumnsRows"
        resources.ApplyResources(Me.mnuPrepareDataFrameInsertColumnsRows, "mnuPrepareDataFrameInsertColumnsRows")
        Me.mnuPrepareDataFrameInsertColumnsRows.Tag = "Insert_Columns/Rows..."
        '
        'mnuPrepareDataFrameDeleteColumnsRows
        '
        Me.mnuPrepareDataFrameDeleteColumnsRows.Name = "mnuPrepareDataFrameDeleteColumnsRows"
        resources.ApplyResources(Me.mnuPrepareDataFrameDeleteColumnsRows, "mnuPrepareDataFrameDeleteColumnsRows")
        Me.mnuPrepareDataFrameDeleteColumnsRows.Tag = "Delete_Columns/Rows..."
        '
        'mnuPrepareDataFrameProtectColumn
        '
        resources.ApplyResources(Me.mnuPrepareDataFrameProtectColumn, "mnuPrepareDataFrameProtectColumn")
        Me.mnuPrepareDataFrameProtectColumn.Name = "mnuPrepareDataFrameProtectColumn"
        Me.mnuPrepareDataFrameProtectColumn.Tag = "..."
        '
        'mnuPrepareDataFrameHideColumns
        '
        Me.mnuPrepareDataFrameHideColumns.Name = "mnuPrepareDataFrameHideColumns"
        resources.ApplyResources(Me.mnuPrepareDataFrameHideColumns, "mnuPrepareDataFrameHideColumns")
        Me.mnuPrepareDataFrameHideColumns.Tag = "Hide_Columns..."
        '
        'mnuPrepareDataFrameFreezeColumns
        '
        resources.ApplyResources(Me.mnuPrepareDataFrameFreezeColumns, "mnuPrepareDataFrameFreezeColumns")
        Me.mnuPrepareDataFrameFreezeColumns.Name = "mnuPrepareDataFrameFreezeColumns"
        Me.mnuPrepareDataFrameFreezeColumns.Tag = "Freeze_Columns..."
        '
        'ColourByPropertyToolStripMenuItem
        '
        Me.ColourByPropertyToolStripMenuItem.Name = "ColourByPropertyToolStripMenuItem"
        resources.ApplyResources(Me.ColourByPropertyToolStripMenuItem, "ColourByPropertyToolStripMenuItem")
        '
        'mnuPrepareCheckData
        '
        Me.mnuPrepareCheckData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuPrepareCheckData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareCheckDataDuplicates, Me.mnuPrepareCheckDataCompareColumns, Me.mnuPrepareCheckDataNonNumericCases, Me.ToolStripSeparator49, Me.mnuPrepareCheckDataBoxplot, Me.mnuPrepareCheckDataOneVariableSummarise, Me.mnuPrepareCheckDataOneVariableGraph, Me.mnuPrepareCheckDataOneWayFrequencies, Me.ToolStripSeparator41, Me.mnuPrepareCheckDataExportOpenRefine, Me.mnuPrepareCheckDataImportOpenRefine, Me.ToolStripSeparator40, Me.mnuPreparePrepareToShareJitter, Me.mnuCheckDataPrePareToShareSdcPackage, Me.mnuPrepareCheckDataAnonymiseIDColumn})
        Me.mnuPrepareCheckData.Name = "mnuPrepareCheckData"
        resources.ApplyResources(Me.mnuPrepareCheckData, "mnuPrepareCheckData")
        '
        'mnuPrepareCheckDataDuplicates
        '
        Me.mnuPrepareCheckDataDuplicates.Name = "mnuPrepareCheckDataDuplicates"
        resources.ApplyResources(Me.mnuPrepareCheckDataDuplicates, "mnuPrepareCheckDataDuplicates")
        '
        'mnuPrepareCheckDataCompareColumns
        '
        Me.mnuPrepareCheckDataCompareColumns.Name = "mnuPrepareCheckDataCompareColumns"
        resources.ApplyResources(Me.mnuPrepareCheckDataCompareColumns, "mnuPrepareCheckDataCompareColumns")
        '
        'mnuPrepareCheckDataNonNumericCases
        '
        Me.mnuPrepareCheckDataNonNumericCases.Name = "mnuPrepareCheckDataNonNumericCases"
        resources.ApplyResources(Me.mnuPrepareCheckDataNonNumericCases, "mnuPrepareCheckDataNonNumericCases")
        '
        'ToolStripSeparator49
        '
        Me.ToolStripSeparator49.Name = "ToolStripSeparator49"
        resources.ApplyResources(Me.ToolStripSeparator49, "ToolStripSeparator49")
        '
        'mnuPrepareCheckDataBoxplot
        '
        Me.mnuPrepareCheckDataBoxplot.Name = "mnuPrepareCheckDataBoxplot"
        resources.ApplyResources(Me.mnuPrepareCheckDataBoxplot, "mnuPrepareCheckDataBoxplot")
        '
        'mnuPrepareCheckDataOneVariableSummarise
        '
        Me.mnuPrepareCheckDataOneVariableSummarise.Name = "mnuPrepareCheckDataOneVariableSummarise"
        resources.ApplyResources(Me.mnuPrepareCheckDataOneVariableSummarise, "mnuPrepareCheckDataOneVariableSummarise")
        '
        'mnuPrepareCheckDataOneVariableGraph
        '
        Me.mnuPrepareCheckDataOneVariableGraph.Name = "mnuPrepareCheckDataOneVariableGraph"
        resources.ApplyResources(Me.mnuPrepareCheckDataOneVariableGraph, "mnuPrepareCheckDataOneVariableGraph")
        '
        'mnuPrepareCheckDataOneWayFrequencies
        '
        Me.mnuPrepareCheckDataOneWayFrequencies.Name = "mnuPrepareCheckDataOneWayFrequencies"
        resources.ApplyResources(Me.mnuPrepareCheckDataOneWayFrequencies, "mnuPrepareCheckDataOneWayFrequencies")
        '
        'ToolStripSeparator41
        '
        Me.ToolStripSeparator41.Name = "ToolStripSeparator41"
        resources.ApplyResources(Me.ToolStripSeparator41, "ToolStripSeparator41")
        '
        'mnuPrepareCheckDataExportOpenRefine
        '
        Me.mnuPrepareCheckDataExportOpenRefine.Name = "mnuPrepareCheckDataExportOpenRefine"
        resources.ApplyResources(Me.mnuPrepareCheckDataExportOpenRefine, "mnuPrepareCheckDataExportOpenRefine")
        '
        'mnuPrepareCheckDataImportOpenRefine
        '
        Me.mnuPrepareCheckDataImportOpenRefine.Name = "mnuPrepareCheckDataImportOpenRefine"
        resources.ApplyResources(Me.mnuPrepareCheckDataImportOpenRefine, "mnuPrepareCheckDataImportOpenRefine")
        '
        'ToolStripSeparator40
        '
        Me.ToolStripSeparator40.Name = "ToolStripSeparator40"
        resources.ApplyResources(Me.ToolStripSeparator40, "ToolStripSeparator40")
        '
        'mnuPreparePrepareToShareJitter
        '
        resources.ApplyResources(Me.mnuPreparePrepareToShareJitter, "mnuPreparePrepareToShareJitter")
        Me.mnuPreparePrepareToShareJitter.Name = "mnuPreparePrepareToShareJitter"
        '
        'mnuCheckDataPrePareToShareSdcPackage
        '
        resources.ApplyResources(Me.mnuCheckDataPrePareToShareSdcPackage, "mnuCheckDataPrePareToShareSdcPackage")
        Me.mnuCheckDataPrePareToShareSdcPackage.Name = "mnuCheckDataPrePareToShareSdcPackage"
        '
        'mnuPrepareCheckDataAnonymiseIDColumn
        '
        Me.mnuPrepareCheckDataAnonymiseIDColumn.Name = "mnuPrepareCheckDataAnonymiseIDColumn"
        resources.ApplyResources(Me.mnuPrepareCheckDataAnonymiseIDColumn, "mnuPrepareCheckDataAnonymiseIDColumn")
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        resources.ApplyResources(Me.ToolStripSeparator6, "ToolStripSeparator6")
        '
        'mnuPrepareColumnCalculate
        '
        Me.mnuPrepareColumnCalculate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnCalculateCalculations, Me.mnuPrepareColumnCalculateColumnSummaries, Me.mnuPrepareColumnCalculateGeneralSummaries, Me.ToolStripSeparator24, Me.mnuPrepareCalculateDuplicateColumn, Me.mnuPrepareColumnCalculateTransform, Me.mnuPrepareColumnCalculateRank, Me.mnuPrepareColumnCalculatePolynomials, Me.mnuPrepareColumnCalculateRowSummary})
        Me.mnuPrepareColumnCalculate.Name = "mnuPrepareColumnCalculate"
        resources.ApplyResources(Me.mnuPrepareColumnCalculate, "mnuPrepareColumnCalculate")
        Me.mnuPrepareColumnCalculate.Tag = "Column:_Calculate"
        '
        'mnuPrepareColumnCalculateCalculations
        '
        Me.mnuPrepareColumnCalculateCalculations.Name = "mnuPrepareColumnCalculateCalculations"
        resources.ApplyResources(Me.mnuPrepareColumnCalculateCalculations, "mnuPrepareColumnCalculateCalculations")
        Me.mnuPrepareColumnCalculateCalculations.Tag = "Calculations..."
        '
        'mnuPrepareColumnCalculateColumnSummaries
        '
        Me.mnuPrepareColumnCalculateColumnSummaries.Name = "mnuPrepareColumnCalculateColumnSummaries"
        resources.ApplyResources(Me.mnuPrepareColumnCalculateColumnSummaries, "mnuPrepareColumnCalculateColumnSummaries")
        Me.mnuPrepareColumnCalculateColumnSummaries.Tag = "Column_Summaries..."
        '
        'mnuPrepareColumnCalculateGeneralSummaries
        '
        Me.mnuPrepareColumnCalculateGeneralSummaries.Name = "mnuPrepareColumnCalculateGeneralSummaries"
        resources.ApplyResources(Me.mnuPrepareColumnCalculateGeneralSummaries, "mnuPrepareColumnCalculateGeneralSummaries")
        '
        'ToolStripSeparator24
        '
        Me.ToolStripSeparator24.Name = "ToolStripSeparator24"
        resources.ApplyResources(Me.ToolStripSeparator24, "ToolStripSeparator24")
        '
        'mnuPrepareCalculateDuplicateColumn
        '
        Me.mnuPrepareCalculateDuplicateColumn.Name = "mnuPrepareCalculateDuplicateColumn"
        resources.ApplyResources(Me.mnuPrepareCalculateDuplicateColumn, "mnuPrepareCalculateDuplicateColumn")
        '
        'mnuPrepareColumnCalculateTransform
        '
        resources.ApplyResources(Me.mnuPrepareColumnCalculateTransform, "mnuPrepareColumnCalculateTransform")
        Me.mnuPrepareColumnCalculateTransform.Name = "mnuPrepareColumnCalculateTransform"
        Me.mnuPrepareColumnCalculateTransform.Tag = "..."
        '
        'mnuPrepareColumnCalculateRank
        '
        Me.mnuPrepareColumnCalculateRank.Name = "mnuPrepareColumnCalculateRank"
        resources.ApplyResources(Me.mnuPrepareColumnCalculateRank, "mnuPrepareColumnCalculateRank")
        Me.mnuPrepareColumnCalculateRank.Tag = "Rank..."
        '
        'mnuPrepareColumnCalculatePolynomials
        '
        Me.mnuPrepareColumnCalculatePolynomials.Name = "mnuPrepareColumnCalculatePolynomials"
        resources.ApplyResources(Me.mnuPrepareColumnCalculatePolynomials, "mnuPrepareColumnCalculatePolynomials")
        Me.mnuPrepareColumnCalculatePolynomials.Tag = "Polynomials..."
        '
        'mnuPrepareColumnCalculateRowSummary
        '
        Me.mnuPrepareColumnCalculateRowSummary.Name = "mnuPrepareColumnCalculateRowSummary"
        resources.ApplyResources(Me.mnuPrepareColumnCalculateRowSummary, "mnuPrepareColumnCalculateRowSummary")
        Me.mnuPrepareColumnCalculateRowSummary.Tag = "Row_Summary..."
        '
        'mnuPrepareColumnGenerate
        '
        Me.mnuPrepareColumnGenerate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnGenerateRegularSequence, Me.mnuPrepareColumnGenerateCountInFactor, Me.ToolStripSeparator25, Me.mnuPrepareColumnGenerateEnter, Me.mnuPrepareColumnGenerateRandomSamples, Me.mnuPrepareColumnGeneratePermuteRows})
        Me.mnuPrepareColumnGenerate.Name = "mnuPrepareColumnGenerate"
        resources.ApplyResources(Me.mnuPrepareColumnGenerate, "mnuPrepareColumnGenerate")
        Me.mnuPrepareColumnGenerate.Tag = "Column:_Generate"
        '
        'mnuPrepareColumnGenerateRegularSequence
        '
        Me.mnuPrepareColumnGenerateRegularSequence.Name = "mnuPrepareColumnGenerateRegularSequence"
        resources.ApplyResources(Me.mnuPrepareColumnGenerateRegularSequence, "mnuPrepareColumnGenerateRegularSequence")
        Me.mnuPrepareColumnGenerateRegularSequence.Tag = "Regular_Sequence..."
        '
        'mnuPrepareColumnGenerateCountInFactor
        '
        Me.mnuPrepareColumnGenerateCountInFactor.Name = "mnuPrepareColumnGenerateCountInFactor"
        resources.ApplyResources(Me.mnuPrepareColumnGenerateCountInFactor, "mnuPrepareColumnGenerateCountInFactor")
        '
        'ToolStripSeparator25
        '
        Me.ToolStripSeparator25.Name = "ToolStripSeparator25"
        resources.ApplyResources(Me.ToolStripSeparator25, "ToolStripSeparator25")
        '
        'mnuPrepareColumnGenerateEnter
        '
        Me.mnuPrepareColumnGenerateEnter.Name = "mnuPrepareColumnGenerateEnter"
        resources.ApplyResources(Me.mnuPrepareColumnGenerateEnter, "mnuPrepareColumnGenerateEnter")
        '
        'mnuPrepareColumnGenerateRandomSamples
        '
        Me.mnuPrepareColumnGenerateRandomSamples.Name = "mnuPrepareColumnGenerateRandomSamples"
        resources.ApplyResources(Me.mnuPrepareColumnGenerateRandomSamples, "mnuPrepareColumnGenerateRandomSamples")
        Me.mnuPrepareColumnGenerateRandomSamples.Tag = "Random_Samples..."
        '
        'mnuPrepareColumnGeneratePermuteRows
        '
        Me.mnuPrepareColumnGeneratePermuteRows.Name = "mnuPrepareColumnGeneratePermuteRows"
        resources.ApplyResources(Me.mnuPrepareColumnGeneratePermuteRows, "mnuPrepareColumnGeneratePermuteRows")
        Me.mnuPrepareColumnGeneratePermuteRows.Tag = "Permute_Rows..."
        '
        'mnuPrepareColumnFactor
        '
        Me.mnuPrepareColumnFactor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnFactorConvertToFactor, Me.mnuPrepareColumnFactorRecodeNumeric, Me.ToolStripSeparator12, Me.mnuPrepareColumnFactorRecodeFactor, Me.mnuPrepareColumnFactorCombineFactors, Me.mnuPrepareColumnFactorDummyVariables, Me.ToolStripSeparator14, Me.mnuPrepareColumnFactorLevelsLabels, Me.mnuPrepareFactorViewLabels, Me.mnuPrepareColumnFactorReorderLevels, Me.mnuPrepareColumnFactorReferenceLevel, Me.mnuPrepareColumnFactorUnusedLevels, Me.mnuPrepareColumnFactorContrasts, Me.ToolStripSeparator19, Me.mnuPrepareColumnFactorFactorDataFrame})
        Me.mnuPrepareColumnFactor.Name = "mnuPrepareColumnFactor"
        resources.ApplyResources(Me.mnuPrepareColumnFactor, "mnuPrepareColumnFactor")
        Me.mnuPrepareColumnFactor.Tag = "Column:_Factor"
        '
        'mnuPrepareColumnFactorConvertToFactor
        '
        Me.mnuPrepareColumnFactorConvertToFactor.Name = "mnuPrepareColumnFactorConvertToFactor"
        resources.ApplyResources(Me.mnuPrepareColumnFactorConvertToFactor, "mnuPrepareColumnFactorConvertToFactor")
        Me.mnuPrepareColumnFactorConvertToFactor.Tag = "Convert_To_Factor"
        '
        'mnuPrepareColumnFactorRecodeNumeric
        '
        Me.mnuPrepareColumnFactorRecodeNumeric.Name = "mnuPrepareColumnFactorRecodeNumeric"
        resources.ApplyResources(Me.mnuPrepareColumnFactorRecodeNumeric, "mnuPrepareColumnFactorRecodeNumeric")
        Me.mnuPrepareColumnFactorRecodeNumeric.Tag = "Recode_Numeric..."
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        resources.ApplyResources(Me.ToolStripSeparator12, "ToolStripSeparator12")
        '
        'mnuPrepareColumnFactorRecodeFactor
        '
        Me.mnuPrepareColumnFactorRecodeFactor.Name = "mnuPrepareColumnFactorRecodeFactor"
        resources.ApplyResources(Me.mnuPrepareColumnFactorRecodeFactor, "mnuPrepareColumnFactorRecodeFactor")
        Me.mnuPrepareColumnFactorRecodeFactor.Tag = "Recode_Factor..."
        '
        'mnuPrepareColumnFactorCombineFactors
        '
        Me.mnuPrepareColumnFactorCombineFactors.Name = "mnuPrepareColumnFactorCombineFactors"
        resources.ApplyResources(Me.mnuPrepareColumnFactorCombineFactors, "mnuPrepareColumnFactorCombineFactors")
        Me.mnuPrepareColumnFactorCombineFactors.Tag = "Combine_Factors..."
        '
        'mnuPrepareColumnFactorDummyVariables
        '
        Me.mnuPrepareColumnFactorDummyVariables.Name = "mnuPrepareColumnFactorDummyVariables"
        resources.ApplyResources(Me.mnuPrepareColumnFactorDummyVariables, "mnuPrepareColumnFactorDummyVariables")
        Me.mnuPrepareColumnFactorDummyVariables.Tag = "Dummy_Variables..."
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        resources.ApplyResources(Me.ToolStripSeparator14, "ToolStripSeparator14")
        '
        'mnuPrepareColumnFactorLevelsLabels
        '
        Me.mnuPrepareColumnFactorLevelsLabels.Name = "mnuPrepareColumnFactorLevelsLabels"
        resources.ApplyResources(Me.mnuPrepareColumnFactorLevelsLabels, "mnuPrepareColumnFactorLevelsLabels")
        Me.mnuPrepareColumnFactorLevelsLabels.Tag = "Levels/Labels..."
        '
        'mnuPrepareFactorViewLabels
        '
        Me.mnuPrepareFactorViewLabels.Name = "mnuPrepareFactorViewLabels"
        resources.ApplyResources(Me.mnuPrepareFactorViewLabels, "mnuPrepareFactorViewLabels")
        '
        'mnuPrepareColumnFactorReorderLevels
        '
        Me.mnuPrepareColumnFactorReorderLevels.Name = "mnuPrepareColumnFactorReorderLevels"
        resources.ApplyResources(Me.mnuPrepareColumnFactorReorderLevels, "mnuPrepareColumnFactorReorderLevels")
        Me.mnuPrepareColumnFactorReorderLevels.Tag = "Reorder_Levels..."
        '
        'mnuPrepareColumnFactorReferenceLevel
        '
        Me.mnuPrepareColumnFactorReferenceLevel.Name = "mnuPrepareColumnFactorReferenceLevel"
        resources.ApplyResources(Me.mnuPrepareColumnFactorReferenceLevel, "mnuPrepareColumnFactorReferenceLevel")
        Me.mnuPrepareColumnFactorReferenceLevel.Tag = "Reference_Level..."
        '
        'mnuPrepareColumnFactorUnusedLevels
        '
        Me.mnuPrepareColumnFactorUnusedLevels.Name = "mnuPrepareColumnFactorUnusedLevels"
        resources.ApplyResources(Me.mnuPrepareColumnFactorUnusedLevels, "mnuPrepareColumnFactorUnusedLevels")
        Me.mnuPrepareColumnFactorUnusedLevels.Tag = "Unused_Levels..."
        '
        'mnuPrepareColumnFactorContrasts
        '
        Me.mnuPrepareColumnFactorContrasts.Name = "mnuPrepareColumnFactorContrasts"
        resources.ApplyResources(Me.mnuPrepareColumnFactorContrasts, "mnuPrepareColumnFactorContrasts")
        Me.mnuPrepareColumnFactorContrasts.Tag = "Contrasts..."
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        resources.ApplyResources(Me.ToolStripSeparator19, "ToolStripSeparator19")
        '
        'mnuPrepareColumnFactorFactorDataFrame
        '
        Me.mnuPrepareColumnFactorFactorDataFrame.Name = "mnuPrepareColumnFactorFactorDataFrame"
        resources.ApplyResources(Me.mnuPrepareColumnFactorFactorDataFrame, "mnuPrepareColumnFactorFactorDataFrame")
        Me.mnuPrepareColumnFactorFactorDataFrame.Tag = "Factor_Data_Frame"
        '
        'mnuPrepareColumnText
        '
        Me.mnuPrepareColumnText.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnTextFindReplace, Me.mnuPrepareColumnTextTransform, Me.mnuPrepareColumnTextSplit, Me.mnuPrepareColumnTextCombine, Me.mnuPrepareColumnTextMatch, Me.mnuPrepareColumnTextDistance})
        Me.mnuPrepareColumnText.Name = "mnuPrepareColumnText"
        resources.ApplyResources(Me.mnuPrepareColumnText, "mnuPrepareColumnText")
        Me.mnuPrepareColumnText.Tag = "Column:_Text"
        '
        'mnuPrepareColumnTextFindReplace
        '
        Me.mnuPrepareColumnTextFindReplace.Name = "mnuPrepareColumnTextFindReplace"
        resources.ApplyResources(Me.mnuPrepareColumnTextFindReplace, "mnuPrepareColumnTextFindReplace")
        Me.mnuPrepareColumnTextFindReplace.Tag = "Find/Replace..."
        '
        'mnuPrepareColumnTextTransform
        '
        Me.mnuPrepareColumnTextTransform.Name = "mnuPrepareColumnTextTransform"
        resources.ApplyResources(Me.mnuPrepareColumnTextTransform, "mnuPrepareColumnTextTransform")
        Me.mnuPrepareColumnTextTransform.Tag = "Transform..."
        '
        'mnuPrepareColumnTextSplit
        '
        Me.mnuPrepareColumnTextSplit.Name = "mnuPrepareColumnTextSplit"
        resources.ApplyResources(Me.mnuPrepareColumnTextSplit, "mnuPrepareColumnTextSplit")
        Me.mnuPrepareColumnTextSplit.Tag = "Split..."
        '
        'mnuPrepareColumnTextCombine
        '
        Me.mnuPrepareColumnTextCombine.Name = "mnuPrepareColumnTextCombine"
        resources.ApplyResources(Me.mnuPrepareColumnTextCombine, "mnuPrepareColumnTextCombine")
        Me.mnuPrepareColumnTextCombine.Tag = "Combine..."
        '
        'mnuPrepareColumnTextMatch
        '
        resources.ApplyResources(Me.mnuPrepareColumnTextMatch, "mnuPrepareColumnTextMatch")
        Me.mnuPrepareColumnTextMatch.Name = "mnuPrepareColumnTextMatch"
        Me.mnuPrepareColumnTextMatch.Tag = "Match..."
        '
        'mnuPrepareColumnTextDistance
        '
        Me.mnuPrepareColumnTextDistance.Name = "mnuPrepareColumnTextDistance"
        resources.ApplyResources(Me.mnuPrepareColumnTextDistance, "mnuPrepareColumnTextDistance")
        Me.mnuPrepareColumnTextDistance.Tag = "Distance..."
        '
        'mnuPrepareColumnDate
        '
        Me.mnuPrepareColumnDate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnGenerateDate, Me.mnuPrepareColumnMakeDate, Me.mnuPrepareColumnInfillMissingDates, Me.mnuPrepareColumnUseDate, Me.mnuPrepareColumnMakeTime, Me.mnuPrepareColumnUseTime})
        Me.mnuPrepareColumnDate.Name = "mnuPrepareColumnDate"
        resources.ApplyResources(Me.mnuPrepareColumnDate, "mnuPrepareColumnDate")
        '
        'mnuPrepareColumnGenerateDate
        '
        Me.mnuPrepareColumnGenerateDate.Name = "mnuPrepareColumnGenerateDate"
        resources.ApplyResources(Me.mnuPrepareColumnGenerateDate, "mnuPrepareColumnGenerateDate")
        '
        'mnuPrepareColumnMakeDate
        '
        Me.mnuPrepareColumnMakeDate.Name = "mnuPrepareColumnMakeDate"
        resources.ApplyResources(Me.mnuPrepareColumnMakeDate, "mnuPrepareColumnMakeDate")
        '
        'mnuPrepareColumnInfillMissingDates
        '
        Me.mnuPrepareColumnInfillMissingDates.Name = "mnuPrepareColumnInfillMissingDates"
        resources.ApplyResources(Me.mnuPrepareColumnInfillMissingDates, "mnuPrepareColumnInfillMissingDates")
        '
        'mnuPrepareColumnUseDate
        '
        Me.mnuPrepareColumnUseDate.Name = "mnuPrepareColumnUseDate"
        resources.ApplyResources(Me.mnuPrepareColumnUseDate, "mnuPrepareColumnUseDate")
        '
        'mnuPrepareColumnMakeTime
        '
        resources.ApplyResources(Me.mnuPrepareColumnMakeTime, "mnuPrepareColumnMakeTime")
        Me.mnuPrepareColumnMakeTime.Name = "mnuPrepareColumnMakeTime"
        '
        'mnuPrepareColumnUseTime
        '
        resources.ApplyResources(Me.mnuPrepareColumnUseTime, "mnuPrepareColumnUseTime")
        Me.mnuPrepareColumnUseTime.Name = "mnuPrepareColumnUseTime"
        '
        'mnuPrepareColumnReshape
        '
        Me.mnuPrepareColumnReshape.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnReshapeColumnSummaries, Me.mnuPrepareColumnReshapeGeneralSummaries, Me.ToolStripSeparator10, Me.mnuPrepareColumnReshapeStack, Me.mnuPrepareColumnReshapeUnstack, Me.mnuPrepareColumnReshapeMerge, Me.ToolStripSeparator11, Me.mnuPrepareAppendDataFrame, Me.mnuPrepareColumnReshapeSubset, Me.mnuPrepareColumnReshapeRandomSubset, Me.mnuPrepareColumnReshapeTranspose})
        Me.mnuPrepareColumnReshape.Name = "mnuPrepareColumnReshape"
        resources.ApplyResources(Me.mnuPrepareColumnReshape, "mnuPrepareColumnReshape")
        Me.mnuPrepareColumnReshape.Tag = "Column:_Reshape"
        '
        'mnuPrepareColumnReshapeColumnSummaries
        '
        Me.mnuPrepareColumnReshapeColumnSummaries.Name = "mnuPrepareColumnReshapeColumnSummaries"
        resources.ApplyResources(Me.mnuPrepareColumnReshapeColumnSummaries, "mnuPrepareColumnReshapeColumnSummaries")
        Me.mnuPrepareColumnReshapeColumnSummaries.Tag = "Column_Summaries..."
        '
        'mnuPrepareColumnReshapeGeneralSummaries
        '
        Me.mnuPrepareColumnReshapeGeneralSummaries.Name = "mnuPrepareColumnReshapeGeneralSummaries"
        resources.ApplyResources(Me.mnuPrepareColumnReshapeGeneralSummaries, "mnuPrepareColumnReshapeGeneralSummaries")
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        resources.ApplyResources(Me.ToolStripSeparator10, "ToolStripSeparator10")
        '
        'mnuPrepareColumnReshapeStack
        '
        Me.mnuPrepareColumnReshapeStack.Name = "mnuPrepareColumnReshapeStack"
        resources.ApplyResources(Me.mnuPrepareColumnReshapeStack, "mnuPrepareColumnReshapeStack")
        Me.mnuPrepareColumnReshapeStack.Tag = "Stack..."
        '
        'mnuPrepareColumnReshapeUnstack
        '
        Me.mnuPrepareColumnReshapeUnstack.Name = "mnuPrepareColumnReshapeUnstack"
        resources.ApplyResources(Me.mnuPrepareColumnReshapeUnstack, "mnuPrepareColumnReshapeUnstack")
        Me.mnuPrepareColumnReshapeUnstack.Tag = "Unstack..."
        '
        'mnuPrepareColumnReshapeMerge
        '
        Me.mnuPrepareColumnReshapeMerge.Name = "mnuPrepareColumnReshapeMerge"
        resources.ApplyResources(Me.mnuPrepareColumnReshapeMerge, "mnuPrepareColumnReshapeMerge")
        Me.mnuPrepareColumnReshapeMerge.Tag = "Merge..."
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        resources.ApplyResources(Me.ToolStripSeparator11, "ToolStripSeparator11")
        '
        'mnuPrepareAppendDataFrame
        '
        Me.mnuPrepareAppendDataFrame.Name = "mnuPrepareAppendDataFrame"
        resources.ApplyResources(Me.mnuPrepareAppendDataFrame, "mnuPrepareAppendDataFrame")
        '
        'mnuPrepareColumnReshapeSubset
        '
        Me.mnuPrepareColumnReshapeSubset.Name = "mnuPrepareColumnReshapeSubset"
        resources.ApplyResources(Me.mnuPrepareColumnReshapeSubset, "mnuPrepareColumnReshapeSubset")
        Me.mnuPrepareColumnReshapeSubset.Tag = "Subset..."
        '
        'mnuPrepareColumnReshapeRandomSubset
        '
        Me.mnuPrepareColumnReshapeRandomSubset.Name = "mnuPrepareColumnReshapeRandomSubset"
        resources.ApplyResources(Me.mnuPrepareColumnReshapeRandomSubset, "mnuPrepareColumnReshapeRandomSubset")
        Me.mnuPrepareColumnReshapeRandomSubset.Tag = "Random_Subset..."
        '
        'mnuPrepareColumnReshapeTranspose
        '
        Me.mnuPrepareColumnReshapeTranspose.Name = "mnuPrepareColumnReshapeTranspose"
        resources.ApplyResources(Me.mnuPrepareColumnReshapeTranspose, "mnuPrepareColumnReshapeTranspose")
        Me.mnuPrepareColumnReshapeTranspose.Tag = "Transpose..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        resources.ApplyResources(Me.ToolStripSeparator7, "ToolStripSeparator7")
        '
        'mnuPrepareKeysAndLinks
        '
        Me.mnuPrepareKeysAndLinks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareKeysAndLinksAddKey, Me.mnuPrepareKeysAndLinksViewAndRemoveKey, Me.mnuPrepareKeysAndLinksAddLink, Me.mnuPrepareKeysAndLinksViewAndRemoveKeys, Me.mnuPrepareKeysAndLinksAddComment})
        Me.mnuPrepareKeysAndLinks.Name = "mnuPrepareKeysAndLinks"
        resources.ApplyResources(Me.mnuPrepareKeysAndLinks, "mnuPrepareKeysAndLinks")
        '
        'mnuPrepareKeysAndLinksAddKey
        '
        Me.mnuPrepareKeysAndLinksAddKey.Name = "mnuPrepareKeysAndLinksAddKey"
        resources.ApplyResources(Me.mnuPrepareKeysAndLinksAddKey, "mnuPrepareKeysAndLinksAddKey")
        '
        'mnuPrepareKeysAndLinksViewAndRemoveKey
        '
        Me.mnuPrepareKeysAndLinksViewAndRemoveKey.Name = "mnuPrepareKeysAndLinksViewAndRemoveKey"
        resources.ApplyResources(Me.mnuPrepareKeysAndLinksViewAndRemoveKey, "mnuPrepareKeysAndLinksViewAndRemoveKey")
        '
        'mnuPrepareKeysAndLinksAddLink
        '
        Me.mnuPrepareKeysAndLinksAddLink.Name = "mnuPrepareKeysAndLinksAddLink"
        resources.ApplyResources(Me.mnuPrepareKeysAndLinksAddLink, "mnuPrepareKeysAndLinksAddLink")
        '
        'mnuPrepareKeysAndLinksViewAndRemoveKeys
        '
        Me.mnuPrepareKeysAndLinksViewAndRemoveKeys.Name = "mnuPrepareKeysAndLinksViewAndRemoveKeys"
        resources.ApplyResources(Me.mnuPrepareKeysAndLinksViewAndRemoveKeys, "mnuPrepareKeysAndLinksViewAndRemoveKeys")
        '
        'mnuPrepareKeysAndLinksAddComment
        '
        Me.mnuPrepareKeysAndLinksAddComment.Name = "mnuPrepareKeysAndLinksAddComment"
        resources.ApplyResources(Me.mnuPrepareKeysAndLinksAddComment, "mnuPrepareKeysAndLinksAddComment")
        '
        'mnuPrepareDataObject
        '
        Me.mnuPrepareDataObject.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareDataObjectDataFrameMetadata, Me.mnuPrepareDataObjectRenameDataFrame, Me.mnuPrepareDataObjectReorderDataFrames, Me.mnuPrepareDataObjectCopyDataFrame, Me.mnuPrepareDataObjectDeleteDataFrame, Me.ToolStripSeparator21, Me.mnuPrepareDataObjectHideDataframes, Me.mnuPrepareDataObjectMetadata, Me.mnuPrepareDataObjectRenameMetadata, Me.mnuPrepareDataObjectReorderMetadata, Me.mnuPrepareDataObjectDeleteMetadata})
        Me.mnuPrepareDataObject.Name = "mnuPrepareDataObject"
        resources.ApplyResources(Me.mnuPrepareDataObject, "mnuPrepareDataObject")
        Me.mnuPrepareDataObject.Tag = "Data_Object"
        '
        'mnuPrepareDataObjectDataFrameMetadata
        '
        resources.ApplyResources(Me.mnuPrepareDataObjectDataFrameMetadata, "mnuPrepareDataObjectDataFrameMetadata")
        Me.mnuPrepareDataObjectDataFrameMetadata.Name = "mnuPrepareDataObjectDataFrameMetadata"
        Me.mnuPrepareDataObjectDataFrameMetadata.Tag = "Data_Frame_Metadata..."
        '
        'mnuPrepareDataObjectRenameDataFrame
        '
        Me.mnuPrepareDataObjectRenameDataFrame.Name = "mnuPrepareDataObjectRenameDataFrame"
        resources.ApplyResources(Me.mnuPrepareDataObjectRenameDataFrame, "mnuPrepareDataObjectRenameDataFrame")
        Me.mnuPrepareDataObjectRenameDataFrame.Tag = "ReName_Data_Frame..."
        '
        'mnuPrepareDataObjectReorderDataFrames
        '
        resources.ApplyResources(Me.mnuPrepareDataObjectReorderDataFrames, "mnuPrepareDataObjectReorderDataFrames")
        Me.mnuPrepareDataObjectReorderDataFrames.Name = "mnuPrepareDataObjectReorderDataFrames"
        Me.mnuPrepareDataObjectReorderDataFrames.Tag = "Reorder_Data_Frames..."
        '
        'mnuPrepareDataObjectCopyDataFrame
        '
        Me.mnuPrepareDataObjectCopyDataFrame.Name = "mnuPrepareDataObjectCopyDataFrame"
        resources.ApplyResources(Me.mnuPrepareDataObjectCopyDataFrame, "mnuPrepareDataObjectCopyDataFrame")
        Me.mnuPrepareDataObjectCopyDataFrame.Tag = "Copy_Data_Frame..."
        '
        'mnuPrepareDataObjectDeleteDataFrame
        '
        Me.mnuPrepareDataObjectDeleteDataFrame.Name = "mnuPrepareDataObjectDeleteDataFrame"
        resources.ApplyResources(Me.mnuPrepareDataObjectDeleteDataFrame, "mnuPrepareDataObjectDeleteDataFrame")
        Me.mnuPrepareDataObjectDeleteDataFrame.Tag = "Delete_Data_Frame..."
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        resources.ApplyResources(Me.ToolStripSeparator21, "ToolStripSeparator21")
        '
        'mnuPrepareDataObjectHideDataframes
        '
        Me.mnuPrepareDataObjectHideDataframes.Name = "mnuPrepareDataObjectHideDataframes"
        resources.ApplyResources(Me.mnuPrepareDataObjectHideDataframes, "mnuPrepareDataObjectHideDataframes")
        '
        'mnuPrepareDataObjectMetadata
        '
        Me.mnuPrepareDataObjectMetadata.Name = "mnuPrepareDataObjectMetadata"
        resources.ApplyResources(Me.mnuPrepareDataObjectMetadata, "mnuPrepareDataObjectMetadata")
        Me.mnuPrepareDataObjectMetadata.Tag = "Metadata..."
        '
        'mnuPrepareDataObjectRenameMetadata
        '
        resources.ApplyResources(Me.mnuPrepareDataObjectRenameMetadata, "mnuPrepareDataObjectRenameMetadata")
        Me.mnuPrepareDataObjectRenameMetadata.Name = "mnuPrepareDataObjectRenameMetadata"
        Me.mnuPrepareDataObjectRenameMetadata.Tag = "Rename_Metadata..."
        '
        'mnuPrepareDataObjectReorderMetadata
        '
        resources.ApplyResources(Me.mnuPrepareDataObjectReorderMetadata, "mnuPrepareDataObjectReorderMetadata")
        Me.mnuPrepareDataObjectReorderMetadata.Name = "mnuPrepareDataObjectReorderMetadata"
        Me.mnuPrepareDataObjectReorderMetadata.Tag = "Reorder_Metadata..."
        '
        'mnuPrepareDataObjectDeleteMetadata
        '
        resources.ApplyResources(Me.mnuPrepareDataObjectDeleteMetadata, "mnuPrepareDataObjectDeleteMetadata")
        Me.mnuPrepareDataObjectDeleteMetadata.Name = "mnuPrepareDataObjectDeleteMetadata"
        Me.mnuPrepareDataObjectDeleteMetadata.Tag = "Delete_Metadata..."
        '
        'mnuPrepareRObjects
        '
        Me.mnuPrepareRObjects.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareRObjectsView, Me.mnuPrepareRObjectsRename, Me.mnuPrepareRObjectsReorder, Me.mnuPrepareRObjectsDelete})
        Me.mnuPrepareRObjects.Name = "mnuPrepareRObjects"
        resources.ApplyResources(Me.mnuPrepareRObjects, "mnuPrepareRObjects")
        Me.mnuPrepareRObjects.Tag = "R_Objects"
        '
        'mnuPrepareRObjectsView
        '
        Me.mnuPrepareRObjectsView.Name = "mnuPrepareRObjectsView"
        resources.ApplyResources(Me.mnuPrepareRObjectsView, "mnuPrepareRObjectsView")
        Me.mnuPrepareRObjectsView.Tag = "View..."
        '
        'mnuPrepareRObjectsRename
        '
        Me.mnuPrepareRObjectsRename.Name = "mnuPrepareRObjectsRename"
        resources.ApplyResources(Me.mnuPrepareRObjectsRename, "mnuPrepareRObjectsRename")
        Me.mnuPrepareRObjectsRename.Tag = "Rename..."
        '
        'mnuPrepareRObjectsReorder
        '
        Me.mnuPrepareRObjectsReorder.Name = "mnuPrepareRObjectsReorder"
        resources.ApplyResources(Me.mnuPrepareRObjectsReorder, "mnuPrepareRObjectsReorder")
        Me.mnuPrepareRObjectsReorder.Tag = "Reorder"
        '
        'mnuPrepareRObjectsDelete
        '
        Me.mnuPrepareRObjectsDelete.Name = "mnuPrepareRObjectsDelete"
        resources.ApplyResources(Me.mnuPrepareRObjectsDelete, "mnuPrepareRObjectsDelete")
        Me.mnuPrepareRObjectsDelete.Tag = "Delete..."
        '
        'mnuProcurement
        '
        Me.mnuProcurement.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementDefineData, Me.mnuProcurementPrepare, Me.mnuProcurementDescribe, Me.MappingToolStripMenuItem, Me.mnuProcurementModel, Me.ToolStripSeparator45, Me.mnuProcurementDefineRedFlags, Me.mnuProcurementUseCRI})
        Me.mnuProcurement.Name = "mnuProcurement"
        resources.ApplyResources(Me.mnuProcurement, "mnuProcurement")
        '
        'mnuProcurementDefineData
        '
        Me.mnuProcurementDefineData.Name = "mnuProcurementDefineData"
        resources.ApplyResources(Me.mnuProcurementDefineData, "mnuProcurementDefineData")
        '
        'mnuProcurementPrepare
        '
        Me.mnuProcurementPrepare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementPrepareFilterByCountry, Me.ToolStripSeparator42, Me.mnuProcurementPrepareDefineContractValueCategories, Me.mnuProcurementPrepareRecodeNumericIntoQuantiles, Me.mnuProcurementPrepareSetFactorReferenceLevel, Me.mnuProcurementPrepareUseAwardDate, Me.ToolStripSeparator43, Me.SummariseRedFlagsByCountryorOtherToolStripMenuItem, Me.SummariseRedFlagsByCountryAndYearorOtherToolStripMenuItem, Me.mnuProcurementPrepareMergeAdditionalData})
        Me.mnuProcurementPrepare.Name = "mnuProcurementPrepare"
        resources.ApplyResources(Me.mnuProcurementPrepare, "mnuProcurementPrepare")
        '
        'mnuProcurementPrepareFilterByCountry
        '
        Me.mnuProcurementPrepareFilterByCountry.Name = "mnuProcurementPrepareFilterByCountry"
        resources.ApplyResources(Me.mnuProcurementPrepareFilterByCountry, "mnuProcurementPrepareFilterByCountry")
        '
        'ToolStripSeparator42
        '
        Me.ToolStripSeparator42.Name = "ToolStripSeparator42"
        resources.ApplyResources(Me.ToolStripSeparator42, "ToolStripSeparator42")
        '
        'mnuProcurementPrepareDefineContractValueCategories
        '
        Me.mnuProcurementPrepareDefineContractValueCategories.Name = "mnuProcurementPrepareDefineContractValueCategories"
        resources.ApplyResources(Me.mnuProcurementPrepareDefineContractValueCategories, "mnuProcurementPrepareDefineContractValueCategories")
        '
        'mnuProcurementPrepareRecodeNumericIntoQuantiles
        '
        Me.mnuProcurementPrepareRecodeNumericIntoQuantiles.Name = "mnuProcurementPrepareRecodeNumericIntoQuantiles"
        resources.ApplyResources(Me.mnuProcurementPrepareRecodeNumericIntoQuantiles, "mnuProcurementPrepareRecodeNumericIntoQuantiles")
        '
        'mnuProcurementPrepareSetFactorReferenceLevel
        '
        Me.mnuProcurementPrepareSetFactorReferenceLevel.Name = "mnuProcurementPrepareSetFactorReferenceLevel"
        resources.ApplyResources(Me.mnuProcurementPrepareSetFactorReferenceLevel, "mnuProcurementPrepareSetFactorReferenceLevel")
        '
        'mnuProcurementPrepareUseAwardDate
        '
        Me.mnuProcurementPrepareUseAwardDate.Name = "mnuProcurementPrepareUseAwardDate"
        resources.ApplyResources(Me.mnuProcurementPrepareUseAwardDate, "mnuProcurementPrepareUseAwardDate")
        '
        'ToolStripSeparator43
        '
        Me.ToolStripSeparator43.Name = "ToolStripSeparator43"
        resources.ApplyResources(Me.ToolStripSeparator43, "ToolStripSeparator43")
        '
        'SummariseRedFlagsByCountryorOtherToolStripMenuItem
        '
        Me.SummariseRedFlagsByCountryorOtherToolStripMenuItem.Name = "SummariseRedFlagsByCountryorOtherToolStripMenuItem"
        resources.ApplyResources(Me.SummariseRedFlagsByCountryorOtherToolStripMenuItem, "SummariseRedFlagsByCountryorOtherToolStripMenuItem")
        '
        'SummariseRedFlagsByCountryAndYearorOtherToolStripMenuItem
        '
        Me.SummariseRedFlagsByCountryAndYearorOtherToolStripMenuItem.Name = "SummariseRedFlagsByCountryAndYearorOtherToolStripMenuItem"
        resources.ApplyResources(Me.SummariseRedFlagsByCountryAndYearorOtherToolStripMenuItem, "SummariseRedFlagsByCountryAndYearorOtherToolStripMenuItem")
        '
        'mnuProcurementPrepareMergeAdditionalData
        '
        Me.mnuProcurementPrepareMergeAdditionalData.Name = "mnuProcurementPrepareMergeAdditionalData"
        resources.ApplyResources(Me.mnuProcurementPrepareMergeAdditionalData, "mnuProcurementPrepareMergeAdditionalData")
        '
        'mnuProcurementDescribe
        '
        Me.mnuProcurementDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OneVariableSummariseToolStripMenuItem, Me.OneVariableGraphToolStripMenuItem, Me.mnuProcurementDescribeOneVar, Me.ToolStripSeparator44, Me.mnuProcurementDescribeTwoVar, Me.CorrelationsRedFlagsOrOthersToolStripMenuItem})
        Me.mnuProcurementDescribe.Name = "mnuProcurementDescribe"
        resources.ApplyResources(Me.mnuProcurementDescribe, "mnuProcurementDescribe")
        '
        'OneVariableSummariseToolStripMenuItem
        '
        Me.OneVariableSummariseToolStripMenuItem.Name = "OneVariableSummariseToolStripMenuItem"
        resources.ApplyResources(Me.OneVariableSummariseToolStripMenuItem, "OneVariableSummariseToolStripMenuItem")
        '
        'OneVariableGraphToolStripMenuItem
        '
        Me.OneVariableGraphToolStripMenuItem.Name = "OneVariableGraphToolStripMenuItem"
        resources.ApplyResources(Me.OneVariableGraphToolStripMenuItem, "OneVariableGraphToolStripMenuItem")
        '
        'mnuProcurementDescribeOneVar
        '
        Me.mnuProcurementDescribeOneVar.Name = "mnuProcurementDescribeOneVar"
        resources.ApplyResources(Me.mnuProcurementDescribeOneVar, "mnuProcurementDescribeOneVar")
        '
        'ToolStripSeparator44
        '
        Me.ToolStripSeparator44.Name = "ToolStripSeparator44"
        resources.ApplyResources(Me.ToolStripSeparator44, "ToolStripSeparator44")
        '
        'mnuProcurementDescribeTwoVar
        '
        Me.mnuProcurementDescribeTwoVar.Name = "mnuProcurementDescribeTwoVar"
        resources.ApplyResources(Me.mnuProcurementDescribeTwoVar, "mnuProcurementDescribeTwoVar")
        '
        'CorrelationsRedFlagsOrOthersToolStripMenuItem
        '
        Me.CorrelationsRedFlagsOrOthersToolStripMenuItem.Name = "CorrelationsRedFlagsOrOthersToolStripMenuItem"
        resources.ApplyResources(Me.CorrelationsRedFlagsOrOthersToolStripMenuItem, "CorrelationsRedFlagsOrOthersToolStripMenuItem")
        '
        'MappingToolStripMenuItem
        '
        Me.MappingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MapCountryValuesToolStripMenuItem})
        Me.MappingToolStripMenuItem.Name = "MappingToolStripMenuItem"
        resources.ApplyResources(Me.MappingToolStripMenuItem, "MappingToolStripMenuItem")
        '
        'MapCountryValuesToolStripMenuItem
        '
        Me.MapCountryValuesToolStripMenuItem.Name = "MapCountryValuesToolStripMenuItem"
        resources.ApplyResources(Me.MapCountryValuesToolStripMenuItem, "MapCountryValuesToolStripMenuItem")
        '
        'mnuProcurementModel
        '
        Me.mnuProcurementModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementDefineCorruption, Me.mnuProcurementModelFitModelToolStripMenuItem})
        Me.mnuProcurementModel.Name = "mnuProcurementModel"
        resources.ApplyResources(Me.mnuProcurementModel, "mnuProcurementModel")
        '
        'mnuProcurementDefineCorruption
        '
        Me.mnuProcurementDefineCorruption.Name = "mnuProcurementDefineCorruption"
        resources.ApplyResources(Me.mnuProcurementDefineCorruption, "mnuProcurementDefineCorruption")
        '
        'mnuProcurementModelFitModelToolStripMenuItem
        '
        Me.mnuProcurementModelFitModelToolStripMenuItem.Name = "mnuProcurementModelFitModelToolStripMenuItem"
        resources.ApplyResources(Me.mnuProcurementModelFitModelToolStripMenuItem, "mnuProcurementModelFitModelToolStripMenuItem")
        '
        'ToolStripSeparator45
        '
        Me.ToolStripSeparator45.Name = "ToolStripSeparator45"
        resources.ApplyResources(Me.ToolStripSeparator45, "ToolStripSeparator45")
        '
        'mnuProcurementDefineRedFlags
        '
        Me.mnuProcurementDefineRedFlags.Name = "mnuProcurementDefineRedFlags"
        resources.ApplyResources(Me.mnuProcurementDefineRedFlags, "mnuProcurementDefineRedFlags")
        '
        'mnuProcurementUseCRI
        '
        Me.mnuProcurementUseCRI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementCalculateCRI, Me.mnuProcurementUseCRISummariseCRIbyCountry})
        Me.mnuProcurementUseCRI.Name = "mnuProcurementUseCRI"
        resources.ApplyResources(Me.mnuProcurementUseCRI, "mnuProcurementUseCRI")
        '
        'mnuProcurementCalculateCRI
        '
        Me.mnuProcurementCalculateCRI.Name = "mnuProcurementCalculateCRI"
        resources.ApplyResources(Me.mnuProcurementCalculateCRI, "mnuProcurementCalculateCRI")
        '
        'mnuProcurementUseCRISummariseCRIbyCountry
        '
        Me.mnuProcurementUseCRISummariseCRIbyCountry.Name = "mnuProcurementUseCRISummariseCRIbyCountry"
        resources.ApplyResources(Me.mnuProcurementUseCRISummariseCRIbyCountry, "mnuProcurementUseCRISummariseCRIbyCountry")
        '
        'mnuOptionsByContext
        '
        Me.mnuOptionsByContext.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextCheckData, Me.mnuOptionsByContextDefineOptionsByContexts, Me.mnuOptionsByContextPrepare, Me.mnuOptionsByContextDescribe, Me.mnuOptionsByContextModel})
        Me.mnuOptionsByContext.Name = "mnuOptionsByContext"
        resources.ApplyResources(Me.mnuOptionsByContext, "mnuOptionsByContext")
        '
        'mnuOptionsByContextCheckData
        '
        Me.mnuOptionsByContextCheckData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextCheckDataDuplicates, Me.mnuOptionsByContextCheckDataCompareColumns, Me.ToolStripSeparator47, Me.mnuOptionsByContextCheckDataOneVariableSummarise, Me.mnuOptionsByContextCheckDataOneVariableGraph, Me.mnuOptionsByContextCheckDataOneVariableFrequencies})
        Me.mnuOptionsByContextCheckData.Name = "mnuOptionsByContextCheckData"
        resources.ApplyResources(Me.mnuOptionsByContextCheckData, "mnuOptionsByContextCheckData")
        '
        'mnuOptionsByContextCheckDataDuplicates
        '
        Me.mnuOptionsByContextCheckDataDuplicates.Name = "mnuOptionsByContextCheckDataDuplicates"
        resources.ApplyResources(Me.mnuOptionsByContextCheckDataDuplicates, "mnuOptionsByContextCheckDataDuplicates")
        '
        'mnuOptionsByContextCheckDataCompareColumns
        '
        Me.mnuOptionsByContextCheckDataCompareColumns.Name = "mnuOptionsByContextCheckDataCompareColumns"
        resources.ApplyResources(Me.mnuOptionsByContextCheckDataCompareColumns, "mnuOptionsByContextCheckDataCompareColumns")
        '
        'ToolStripSeparator47
        '
        Me.ToolStripSeparator47.Name = "ToolStripSeparator47"
        resources.ApplyResources(Me.ToolStripSeparator47, "ToolStripSeparator47")
        '
        'mnuOptionsByContextCheckDataOneVariableSummarise
        '
        Me.mnuOptionsByContextCheckDataOneVariableSummarise.Name = "mnuOptionsByContextCheckDataOneVariableSummarise"
        resources.ApplyResources(Me.mnuOptionsByContextCheckDataOneVariableSummarise, "mnuOptionsByContextCheckDataOneVariableSummarise")
        '
        'mnuOptionsByContextCheckDataOneVariableGraph
        '
        Me.mnuOptionsByContextCheckDataOneVariableGraph.Name = "mnuOptionsByContextCheckDataOneVariableGraph"
        resources.ApplyResources(Me.mnuOptionsByContextCheckDataOneVariableGraph, "mnuOptionsByContextCheckDataOneVariableGraph")
        '
        'mnuOptionsByContextCheckDataOneVariableFrequencies
        '
        Me.mnuOptionsByContextCheckDataOneVariableFrequencies.Name = "mnuOptionsByContextCheckDataOneVariableFrequencies"
        resources.ApplyResources(Me.mnuOptionsByContextCheckDataOneVariableFrequencies, "mnuOptionsByContextCheckDataOneVariableFrequencies")
        '
        'mnuOptionsByContextDefineOptionsByContexts
        '
        Me.mnuOptionsByContextDefineOptionsByContexts.Name = "mnuOptionsByContextDefineOptionsByContexts"
        resources.ApplyResources(Me.mnuOptionsByContextDefineOptionsByContexts, "mnuOptionsByContextDefineOptionsByContexts")
        '
        'mnuOptionsByContextPrepare
        '
        Me.mnuOptionsByContextPrepare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions, Me.ToolStripSeparator48, Me.mnuOptionsByContextMergeAdditionalData, Me.mnuOptionsByContextPrepareStack, Me.mnuOptionsByContextPrepareUnstack})
        Me.mnuOptionsByContextPrepare.Name = "mnuOptionsByContextPrepare"
        resources.ApplyResources(Me.mnuOptionsByContextPrepare, "mnuOptionsByContextPrepare")
        '
        'mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions
        '
        Me.mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions.Name = "mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions"
        resources.ApplyResources(Me.mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions, "mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions")
        '
        'ToolStripSeparator48
        '
        Me.ToolStripSeparator48.Name = "ToolStripSeparator48"
        resources.ApplyResources(Me.ToolStripSeparator48, "ToolStripSeparator48")
        '
        'mnuOptionsByContextMergeAdditionalData
        '
        Me.mnuOptionsByContextMergeAdditionalData.Name = "mnuOptionsByContextMergeAdditionalData"
        resources.ApplyResources(Me.mnuOptionsByContextMergeAdditionalData, "mnuOptionsByContextMergeAdditionalData")
        '
        'mnuOptionsByContextPrepareStack
        '
        Me.mnuOptionsByContextPrepareStack.Name = "mnuOptionsByContextPrepareStack"
        resources.ApplyResources(Me.mnuOptionsByContextPrepareStack, "mnuOptionsByContextPrepareStack")
        '
        'mnuOptionsByContextPrepareUnstack
        '
        Me.mnuOptionsByContextPrepareUnstack.Name = "mnuOptionsByContextPrepareUnstack"
        resources.ApplyResources(Me.mnuOptionsByContextPrepareUnstack, "mnuOptionsByContextPrepareUnstack")
        '
        'mnuOptionsByContextDescribe
        '
        Me.mnuOptionsByContextDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextDescribeCompareTwoTreatments, Me.mnuOptionsByContextDescribeCompareMultipleTreatments, Me.mnuOptionsByContextDescribeBoxplot})
        Me.mnuOptionsByContextDescribe.Name = "mnuOptionsByContextDescribe"
        resources.ApplyResources(Me.mnuOptionsByContextDescribe, "mnuOptionsByContextDescribe")
        '
        'mnuOptionsByContextDescribeCompareTwoTreatments
        '
        Me.mnuOptionsByContextDescribeCompareTwoTreatments.Name = "mnuOptionsByContextDescribeCompareTwoTreatments"
        resources.ApplyResources(Me.mnuOptionsByContextDescribeCompareTwoTreatments, "mnuOptionsByContextDescribeCompareTwoTreatments")
        '
        'mnuOptionsByContextDescribeCompareMultipleTreatments
        '
        resources.ApplyResources(Me.mnuOptionsByContextDescribeCompareMultipleTreatments, "mnuOptionsByContextDescribeCompareMultipleTreatments")
        Me.mnuOptionsByContextDescribeCompareMultipleTreatments.Name = "mnuOptionsByContextDescribeCompareMultipleTreatments"
        '
        'mnuOptionsByContextDescribeBoxplot
        '
        Me.mnuOptionsByContextDescribeBoxplot.Name = "mnuOptionsByContextDescribeBoxplot"
        resources.ApplyResources(Me.mnuOptionsByContextDescribeBoxplot, "mnuOptionsByContextDescribeBoxplot")
        '
        'mnuOptionsByContextModel
        '
        Me.mnuOptionsByContextModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextModelFitModel, Me.mnuOptionsByContextGeneralFitModel})
        Me.mnuOptionsByContextModel.Name = "mnuOptionsByContextModel"
        resources.ApplyResources(Me.mnuOptionsByContextModel, "mnuOptionsByContextModel")
        '
        'mnuOptionsByContextModelFitModel
        '
        Me.mnuOptionsByContextModelFitModel.Name = "mnuOptionsByContextModelFitModel"
        resources.ApplyResources(Me.mnuOptionsByContextModelFitModel, "mnuOptionsByContextModelFitModel")
        '
        'mnuOptionsByContextGeneralFitModel
        '
        Me.mnuOptionsByContextGeneralFitModel.Name = "mnuOptionsByContextGeneralFitModel"
        resources.ApplyResources(Me.mnuOptionsByContextGeneralFitModel, "mnuOptionsByContextGeneralFitModel")
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuToolsRunRCode, Me.mnuToolsRestartR, Me.mnuToolsCheckForUpdates, Me.mnuToolsClearOutputWindow, Me.ToolStripSeparator5, Me.mnuToolsSaveCurrentOptions, Me.mnuToolsLoadOptions, Me.mnuToolsOptions})
        Me.mnuTools.Name = "mnuTools"
        resources.ApplyResources(Me.mnuTools, "mnuTools")
        '
        'mnuToolsRunRCode
        '
        resources.ApplyResources(Me.mnuToolsRunRCode, "mnuToolsRunRCode")
        Me.mnuToolsRunRCode.Name = "mnuToolsRunRCode"
        Me.mnuToolsRunRCode.Tag = "Run_R_Code..."
        '
        'mnuToolsRestartR
        '
        resources.ApplyResources(Me.mnuToolsRestartR, "mnuToolsRestartR")
        Me.mnuToolsRestartR.Name = "mnuToolsRestartR"
        Me.mnuToolsRestartR.Tag = "Restart_R"
        '
        'mnuToolsCheckForUpdates
        '
        resources.ApplyResources(Me.mnuToolsCheckForUpdates, "mnuToolsCheckForUpdates")
        Me.mnuToolsCheckForUpdates.Name = "mnuToolsCheckForUpdates"
        Me.mnuToolsCheckForUpdates.Tag = "Check_for_Updates..."
        '
        'mnuToolsClearOutputWindow
        '
        Me.mnuToolsClearOutputWindow.Name = "mnuToolsClearOutputWindow"
        resources.ApplyResources(Me.mnuToolsClearOutputWindow, "mnuToolsClearOutputWindow")
        Me.mnuToolsClearOutputWindow.Tag = "Clear_Output_Window..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        '
        'mnuToolsSaveCurrentOptions
        '
        resources.ApplyResources(Me.mnuToolsSaveCurrentOptions, "mnuToolsSaveCurrentOptions")
        Me.mnuToolsSaveCurrentOptions.Name = "mnuToolsSaveCurrentOptions"
        Me.mnuToolsSaveCurrentOptions.Tag = "Save_Current_Options..."
        '
        'mnuToolsLoadOptions
        '
        resources.ApplyResources(Me.mnuToolsLoadOptions, "mnuToolsLoadOptions")
        Me.mnuToolsLoadOptions.Name = "mnuToolsLoadOptions"
        Me.mnuToolsLoadOptions.Tag = "Load_Options..."
        '
        'mnuToolsOptions
        '
        Me.mnuToolsOptions.Name = "mnuToolsOptions"
        resources.ApplyResources(Me.mnuToolsOptions, "mnuToolsOptions")
        Me.mnuToolsOptions.Tag = "Options..."
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        resources.ApplyResources(Me.ExportToolStripMenuItem, "ExportToolStripMenuItem")
        '
        'splOverall
        '
        Me.splOverall.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.splOverall, "splOverall")
        Me.splOverall.Name = "splOverall"
        '
        'splOverall.Panel1
        '
        Me.splOverall.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.splOverall.Panel1.Controls.Add(Me.splExtraWindows)
        '
        'splOverall.Panel2
        '
        Me.splOverall.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.splOverall.Panel2.Controls.Add(Me.splDataOutput)
        '
        'splExtraWindows
        '
        Me.splExtraWindows.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.splExtraWindows, "splExtraWindows")
        Me.splExtraWindows.Name = "splExtraWindows"
        '
        'splExtraWindows.Panel1
        '
        Me.splExtraWindows.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.splExtraWindows.Panel1.Controls.Add(Me.splMetadata)
        '
        'splExtraWindows.Panel2
        '
        Me.splExtraWindows.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.splExtraWindows.Panel2.Controls.Add(Me.splLogScript)
        '
        'splMetadata
        '
        Me.splMetadata.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.splMetadata, "splMetadata")
        Me.splMetadata.Name = "splMetadata"
        '
        'splMetadata.Panel1
        '
        Me.splMetadata.Panel1.Controls.Add(Me.ucrColumnMeta)
        '
        'splMetadata.Panel2
        '
        Me.splMetadata.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.splMetadata.Panel2.Controls.Add(Me.ucrDataFrameMeta)
        '
        'ucrColumnMeta
        '
        Me.ucrColumnMeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.ucrColumnMeta, "ucrColumnMeta")
        Me.ucrColumnMeta.Name = "ucrColumnMeta"
        '
        'ucrDataFrameMeta
        '
        Me.ucrDataFrameMeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.ucrDataFrameMeta, "ucrDataFrameMeta")
        Me.ucrDataFrameMeta.Name = "ucrDataFrameMeta"
        '
        'splLogScript
        '
        Me.splLogScript.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.splLogScript, "splLogScript")
        Me.splLogScript.Name = "splLogScript"
        '
        'splLogScript.Panel1
        '
        Me.splLogScript.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.splLogScript.Panel1.Controls.Add(Me.ucrLogWindow)
        '
        'splLogScript.Panel2
        '
        Me.splLogScript.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.splLogScript.Panel2.Controls.Add(Me.ucrScriptWindow)
        '
        'ucrLogWindow
        '
        Me.ucrLogWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.ucrLogWindow, "ucrLogWindow")
        Me.ucrLogWindow.Name = "ucrLogWindow"
        '
        'ucrScriptWindow
        '
        Me.ucrScriptWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.ucrScriptWindow, "ucrScriptWindow")
        Me.ucrScriptWindow.Name = "ucrScriptWindow"
        Me.ucrScriptWindow.Tag = "Script_Window"
        '
        'splDataOutput
        '
        Me.splDataOutput.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.splDataOutput, "splDataOutput")
        Me.splDataOutput.Name = "splDataOutput"
        '
        'splDataOutput.Panel1
        '
        Me.splDataOutput.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.splDataOutput.Panel1.Controls.Add(Me.ucrDataViewer)
        '
        'splDataOutput.Panel2
        '
        Me.splDataOutput.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.splDataOutput.Panel2.Controls.Add(Me.ucrOutput)
        '
        'ucrDataViewer
        '
        Me.ucrDataViewer.BackColor = System.Drawing.SystemColors.Control
        Me.ucrDataViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.ucrDataViewer, "ucrDataViewer")
        Me.ucrDataViewer.Name = "ucrDataViewer"
        Me.ucrDataViewer.Tag = "Data_View"
        '
        'ucrOutput
        '
        Me.ucrOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.ucrOutput, "ucrOutput")
        Me.ucrOutput.Name = "ucrOutput"
        '
        'mnuClimaticModelSPI
        '
        Me.mnuClimaticModelSPI.Name = "mnuClimaticModelSPI"
        resources.ApplyResources(Me.mnuClimaticModelSPI, "mnuClimaticModelSPI")
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.splOverall)
        Me.Controls.Add(Me.stsStrip)
        Me.Controls.Add(Me.Tool_strip)
        Me.Controls.Add(Me.mnuBar)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuBar
        Me.Name = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.stsStrip.ResumeLayout(False)
        Me.stsStrip.PerformLayout()
        Me.Tool_strip.ResumeLayout(False)
        Me.Tool_strip.PerformLayout()
        Me.mnuBar.ResumeLayout(False)
        Me.mnuBar.PerformLayout()
        Me.splOverall.Panel1.ResumeLayout(False)
        Me.splOverall.Panel2.ResumeLayout(False)
        CType(Me.splOverall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splOverall.ResumeLayout(False)
        Me.splExtraWindows.Panel1.ResumeLayout(False)
        Me.splExtraWindows.Panel2.ResumeLayout(False)
        CType(Me.splExtraWindows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splExtraWindows.ResumeLayout(False)
        Me.splMetadata.Panel1.ResumeLayout(False)
        Me.splMetadata.Panel2.ResumeLayout(False)
        CType(Me.splMetadata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splMetadata.ResumeLayout(False)
        Me.splLogScript.Panel1.ResumeLayout(False)
        Me.splLogScript.Panel2.ResumeLayout(False)
        CType(Me.splLogScript, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splLogScript.ResumeLayout(False)
        Me.splDataOutput.Panel1.ResumeLayout(False)
        Me.splDataOutput.Panel2.ResumeLayout(False)
        CType(Me.splDataOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splDataOutput.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuDescribe As ToolStripMenuItem
    Friend WithEvents mnuModel As ToolStripMenuItem
    Friend WithEvents mnuClimaticExamine As ToolStripMenuItem
    Friend WithEvents mnuClimaticProcess As ToolStripMenuItem
    Friend WithEvents mnuClimaticEvaporation As ToolStripMenuItem
    Friend WithEvents mnuClimaticEvaporationSite As ToolStripMenuItem
    Friend WithEvents mnuClimaticEvaporationPenman As ToolStripMenuItem
    Friend WithEvents mnuClimaticCrop As ToolStripMenuItem
    Friend WithEvents CropCoefficientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WaterSatisfactionIndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClimaticHeatSum As ToolStripMenuItem
    Friend WithEvents mnuView As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents OpenFile As OpenFileDialog
    Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents mnuClimatic As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepare As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareNewWorksheet As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareImportDailyData As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareMakeFactor As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareShiftDailyData As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareStackDailyData As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuFilePrint As ToolStripMenuItem
    Friend WithEvents mnuFilePrintPreview As ToolStripMenuItem
    Friend WithEvents tlSeparatorFile3 As ToolStripSeparator
    Friend WithEvents mnuFIleExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditCut As ToolStripMenuItem
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuEditCopySpecial As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents mnuEditSelectAll As ToolStripMenuItem
    Friend WithEvents mnuEditFind As ToolStripMenuItem
    Friend WithEvents mnuEditReplace As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents stsStrip As StatusStrip
    Friend WithEvents tstatus As ToolStripStatusLabel
    Private WithEvents Tool_strip As ToolStrip
    Friend WithEvents mnuTbSave As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents mnuTbCopy As ToolStripButton
    Friend WithEvents mnuTbPaste As ToolStripButton
    Friend WithEvents separator1 As ToolStripSeparator
    Friend WithEvents mnuTbEditLastDialog As ToolStripButton
    Friend WithEvents separator2 As ToolStripSeparator
    Friend WithEvents mnuTbHelp As ToolStripButton
    Private WithEvents mnuBar As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNewDataFrame As ToolStripMenuItem
    Friend WithEvents mnuFileOpenFromFile As ToolStripMenuItem
    Friend WithEvents mnuFileOpenFromLibrary As ToolStripMenuItem
    Friend WithEvents tlSeparatorFile As ToolStripSeparator
    Friend WithEvents mnuPrepare As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrame As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameViewData As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnReshape As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnReshapeStack As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnReshapeUnstack As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnReshapeSubset As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnFactor As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameRenameColumn As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnReshapeMerge As ToolStripMenuItem
    Friend WithEvents mnuViewColumnMetadata As ToolStripMenuItem
    Friend WithEvents mnuViewDataFrameMetadata As ToolStripMenuItem
    Friend WithEvents mnuViewLog As ToolStripMenuItem
    Friend WithEvents mnuViewScriptWindow As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataObject As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataObjectDeleteDataFrame As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataObjectRenameDataFrame As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataObjectReorderDataFrames As ToolStripMenuItem
    Friend WithEvents mnuViewDataView As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnFactorConvertToFactor As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnFactorLevelsLabels As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnFactorReorderLevels As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnFactorRecodeFactor As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnFactorReferenceLevel As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnFactorUnusedLevels As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnGenerate As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameConvertColumns As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnGeneratePermuteRows As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnReshapeColumnSummaries As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnReshapeRandomSubset As ToolStripMenuItem
    Friend WithEvents mnuExport As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataObjectDataFrameMetadata As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataObjectCopyDataFrame As ToolStripMenuItem
    Friend WithEvents mnuTbLast10Dialogs As ToolStripDropDownButton
    Friend WithEvents sepEnd As ToolStripSeparator
    Friend WithEvents sepStart As ToolStripSeparator
    Friend WithEvents mnuPrepareDataFrameSort As ToolStripMenuItem
    Friend WithEvents mnuPrepareRObjects As ToolStripMenuItem
    Friend WithEvents mnuPrepareRObjectsView As ToolStripMenuItem
    Friend WithEvents mnuPrepareRObjectsReorder As ToolStripMenuItem
    Friend WithEvents mnuPrepareRObjectsRename As ToolStripMenuItem
    Friend WithEvents mnuPrepareRObjectsDelete As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnFactorContrasts As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnFactorFactorDataFrame As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnText As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnTextSplit As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnTextCombine As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnTextMatch As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnTextDistance As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents mnuPrepareDataFrameFilter As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents mnuPrepareColumnReshapeTranspose As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents mnuPrepareColumnFactorCombineFactors As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnFactorDummyVariables As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator19 As ToolStripSeparator
    Friend WithEvents mnuPrepareColumnTextTransform As ToolStripMenuItem
    Friend WithEvents mnuTools As ToolStripMenuItem
    Friend WithEvents mnuToolsOptions As ToolStripMenuItem
    Friend WithEvents mnuEditFindNext As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameRowNumbersNames As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuPrepareDataFrameReplaceValues As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuPrepareDataFrameColumnMetadata As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameColumnStructure As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator20 As ToolStripSeparator
    Friend WithEvents mnuPrepareDataFrameReorderColumns As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameInsertColumnsRows As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameDeleteColumnsRows As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameProtectColumn As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameHideColumns As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameFreezeColumns As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnCalculate As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnCalculateTransform As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnCalculateRank As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnCalculatePolynomials As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnCalculateCalculations As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnCalculateRowSummary As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnGenerateRegularSequence As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnGenerateRandomSamples As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnFactorRecodeNumeric As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnTextFindReplace As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator21 As ToolStripSeparator
    Friend WithEvents mnuPrepareDataObjectMetadata As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataObjectRenameMetadata As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataObjectReorderMetadata As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataObjectDeleteMetadata As ToolStripMenuItem
    Friend WithEvents mnuDescribeOneVariable As ToolStripMenuItem
    Friend WithEvents mnuDescribeOneVariableSummarise As ToolStripMenuItem
    Friend WithEvents mnuDescribeOneVariableGraph As ToolStripMenuItem
    Friend WithEvents mnuDescribeTwoVariables As ToolStripMenuItem
    Friend WithEvents mnuDescribeTwoVariablesSummarise As ToolStripMenuItem
    Friend WithEvents mnuDescribeTwoVariablesTabulate As ToolStripMenuItem
    Friend WithEvents mnuDescribeTwoVariablesGraph As ToolStripMenuItem
    Friend WithEvents mnuDescribeGeneral As ToolStripMenuItem
    Friend WithEvents mnuDescribeGeneralColumnSummaries As ToolStripMenuItem
    Friend WithEvents DescribeGeneralTabulation As ToolStripMenuItem
    Friend WithEvents DescribeGeneralGraphics As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecific As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificFrequency As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificSummary As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificMultipleResponse As ToolStripMenuItem
    Friend WithEvents mnuModelProbabilityDistributions As ToolStripMenuItem
    Friend WithEvents mnuModelProbabilityDistributionsCompareModels As ToolStripMenuItem
    Friend WithEvents mnuModelProbabilityDistributionsRandomSamplesUseModel As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnuModelOneVariable As ToolStripMenuItem
    Friend WithEvents mnuModelOneVariableFitModel As ToolStripMenuItem
    Friend WithEvents mnuModelOneVariableCompareModels As ToolStripMenuItem
    Friend WithEvents mnuModelOneVariableUseModel As ToolStripMenuItem
    Friend WithEvents mnuModelTwoVariables As ToolStripMenuItem
    Friend WithEvents mnuModelTwoVariablesFitModel As ToolStripMenuItem
    Friend WithEvents mnuModelTwoVariablesChooseModel As ToolStripMenuItem
    Friend WithEvents mnuModelTwoVariablesUseModel As ToolStripMenuItem
    Friend WithEvents mnuModelThreeVariables As ToolStripMenuItem
    Friend WithEvents mnuModelThreeVariablesFitModel As ToolStripMenuItem
    Friend WithEvents mnuModelThreeVariablesChooseModel As ToolStripMenuItem
    Friend WithEvents mnuModelThreeVariablesUseModel As ToolStripMenuItem
    Friend WithEvents mnuModelFourVariables As ToolStripMenuItem
    Friend WithEvents mnuModelFourVariablesFitModel As ToolStripMenuItem
    Friend WithEvents mnuModelFourVariablesChooseModel As ToolStripMenuItem
    Friend WithEvents mnuModelFourVariablesUseModel As ToolStripMenuItem
    Friend WithEvents mnuModelGeneral As ToolStripMenuItem
    Friend WithEvents mnuModelGeneralFitModel As ToolStripMenuItem
    Friend WithEvents mnuModelGeneralChooseModel As ToolStripMenuItem
    Friend WithEvents mnuModelGeneralUseModel As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents mnuModelOtherOneVariable As ToolStripMenuItem
    Friend WithEvents mnuModelOtherOneVariableExactResults As ToolStripMenuItem
    Friend WithEvents mnuModelOtherOneVariableSampleSummaryData As ToolStripMenuItem
    Friend WithEvents mnuModelOtherOneVariableNonParametric As ToolStripMenuItem
    Friend WithEvents mnuModelOtherTwoVariables As ToolStripMenuItem
    Friend WithEvents mnuModelOtherThreeVariables As ToolStripMenuItem
    Friend WithEvents mnuModelOtherGeneral As ToolStripMenuItem
    Friend WithEvents mnuModelOtherTwoVariablesTwoSamples As ToolStripMenuItem
    Friend WithEvents mnuModelOtherTwoVariablesSummaryData As ToolStripMenuItem
    Friend WithEvents mnuModelOtherTwoVariablesSimpleRegression As ToolStripMenuItem
    Friend WithEvents mnuModelOtherTwoVariablesOneWayANOVA As ToolStripMenuItem
    Friend WithEvents mnuModelOtherTwoVariablesNonParametricTwoSamples As ToolStripMenuItem
    Friend WithEvents mnuModelOtherTwoVariablesNonParametricOneWayANOVA As ToolStripMenuItem
    Friend WithEvents mnuModelOtherThreeVariablesSimpleWithGroups As ToolStripMenuItem
    Friend WithEvents mnuModelOtherThreeVariablesNonParametricTwoWayANOVA As ToolStripMenuItem
    Friend WithEvents mnuModelOtherThreeVariablesChisquareTest As ToolStripMenuItem
    Friend WithEvents mnuModelOtherGeneralANOVAGeneral As ToolStripMenuItem
    Friend WithEvents mnuModelOtherGeneralRegression As ToolStripMenuItem
    Friend WithEvents mnuModelOtherGeneralLogLinear As ToolStripMenuItem
    Friend WithEvents mnuToolsRunRCode As ToolStripMenuItem
    Friend WithEvents mnuToolsRestartR As ToolStripMenuItem
    Friend WithEvents mnuToolsClearOutputWindow As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents mnuToolsSaveCurrentOptions As ToolStripMenuItem
    Friend WithEvents mnuToolsLoadOptions As ToolStripMenuItem
    Friend WithEvents mnuViewOutputWindow As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator22 As ToolStripSeparator
    Friend WithEvents mnuModelOtherOneVariableGoodnessofFit As ToolStripMenuItem
    Friend WithEvents mnuHelpAboutRInstat As ToolStripMenuItem
    Friend WithEvents mnuHelpLicence As ToolStripMenuItem
    Friend WithEvents mnuToolsCheckForUpdates As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents mnuPrepareCheckData As ToolStripMenuItem
    Friend WithEvents mnuPreparePrepareToShareJitter As ToolStripMenuItem
    Friend WithEvents mnuCheckDataPrePareToShareSdcPackage As ToolStripMenuItem
    Friend WithEvents ColourByPropertyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataObjectHideDataframes As ToolStripMenuItem
    Friend WithEvents mnuPrepareAppendDataFrame As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAsDataAs As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAsOutputAs As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAsLogAs As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAsScriptAs As ToolStripMenuItem
    Friend WithEvents mnuFileCloseData As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator23 As ToolStripSeparator
    Friend WithEvents mnuClimateMethods As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulation As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationStartOfRain As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationEndOfRain As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationChangeFormatDayMonth As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationExportCPTToTabular As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationDayMonth As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationDisplayDaily As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationDisplayDOYOfYear As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationDisplayRainRunningTotal As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationDisplaySpellLength As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationExportForPICSA As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationExtremeEvents As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationMissingData As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationMissingDataTable As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationMonthlySummaries As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationOutputForCD As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsGraphics As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsGraphicsClipBoxPlot As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsGraphicsCliplot As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsGraphicsMissingValues As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsGraphicsHistogram As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsGraphicsCumExceedance As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsGraphicsBoxplot As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsGraphicsInventory As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsGraphicsAnnualRainfall As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsGraphicsRainCount As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsGraphicsTimeseries As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsGraphicsWindrose As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsGraphicsMultipleLines As ToolStripMenuItem
    Friend WithEvents mnuClmateMethodThreeSummaries As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsModel As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsAdditional As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsAdditionalOutputForCPT As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsAdditionalRainsStatistics As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsAdditionalSeasonalSummary As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsAdditionalSeasonalSummaryRain As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsAdditionalWaterBalance As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsCreateClimateObject As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator24 As ToolStripSeparator
    Friend WithEvents mnuClimaticFile As ToolStripMenuItem
    Friend WithEvents mnuClimaticFileOpensst As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnGenerateEnter As ToolStripMenuItem
    Friend WithEvents mnuImportFromODK As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnGenerateCountInFactor As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator25 As ToolStripSeparator
    Friend WithEvents mnuPrepareColumnDate As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnGenerateDate As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnUseDate As ToolStripMenuItem
    Friend WithEvents mnuFileConvert As ToolStripMenuItem
    Friend WithEvents mnuModelProbabilityDistributionsShowModel As ToolStripMenuItem
    Friend WithEvents mnuDescribeMultivariate As ToolStripMenuItem
    Friend WithEvents mnuDescribeMultivariateCorrelations As ToolStripMenuItem
    Friend WithEvents mnuDescribeMultivariateprincipalComponents As ToolStripMenuItem
    Friend WithEvents mnuDescribeMultivariateCanonicalCorrelations As ToolStripMenuItem
    Friend WithEvents mnuDescribeUseGraph As ToolStripMenuItem
    Friend WithEvents mnuDescribeCombineGraph As ToolStripMenuItem
    Friend WithEvents mnuDescribeThemes As ToolStripMenuItem
    Friend WithEvents mnuClimaticDescribe As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareSummary As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator26 As ToolStripSeparator
    Friend WithEvents mnuDescribeSpecificScatterPlot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificLinePlot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificHistogram As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificBoxplot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificDotPlot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificRugPlot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificBarChart As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnMakeDate As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnMakeTime As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnUseTime As ToolStripMenuItem
    Friend WithEvents mnuClimdex As ToolStripMenuItem
    Friend WithEvents mnuPrepareCheckDataExportOpenRefine As ToolStripMenuItem
    Friend WithEvents mnuPrepareCheckDataImportOpenRefine As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator27 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents mnuHelpHelpIntroduction As ToolStripMenuItem
    Friend WithEvents mnuHelpHistFAQ As ToolStripMenuItem
    Friend WithEvents mnuHelpSpreadsheet As ToolStripMenuItem
    Friend WithEvents mnuHelpGetingStarted As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator28 As ToolStripSeparator
    Friend WithEvents mnuHelpMenus As ToolStripMenuItem
    Friend WithEvents mnuHelpR As ToolStripMenuItem
    Friend WithEvents mnuHelpRPackagesCommands As ToolStripMenuItem
    Friend WithEvents mnuHelpDataset As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator29 As ToolStripSeparator
    Friend WithEvents mnuHelpGuide As ToolStripMenuItem
    Friend WithEvents mnuHelpGuidesCaseStudy As ToolStripMenuItem
    Friend WithEvents mnuHelpGuideGlosary As ToolStripMenuItem
    Friend WithEvents mnuhelpGuidesMore As ToolStripMenuItem
    Friend WithEvents mnuClimaticFileExportToCPT As ToolStripMenuItem
    Friend WithEvents mnuClimateFileClimSoft As ToolStripMenuItem
    Friend WithEvents mnuClimaticFileCliData As ToolStripMenuItem
    Friend WithEvents mnuCimaticPrepareTransform As ToolStripMenuItem
    Friend WithEvents mnuClimaticCheckData As ToolStripMenuItem
    Friend WithEvents mnuClimaticDescribeRainfall As ToolStripMenuItem
    Friend WithEvents mnuClimaticDescribeTemperatures As ToolStripMenuItem
    Friend WithEvents mnuClimaticDescribeWindSpeedDirection As ToolStripMenuItem
    Friend WithEvents mnuClimaticPICSA As ToolStripMenuItem
    Friend WithEvents mnuClimaticPICSARainfall As ToolStripMenuItem
    Friend WithEvents mnuClimaticPICSATemperature As ToolStripMenuItem
    Friend WithEvents mnuClimaticPICSACrops As ToolStripMenuItem
    Friend WithEvents mnuClimaticSCF As ToolStripMenuItem
    Friend WithEvents mnuClimaticModels As ToolStripMenuItem
    Friend WithEvents mnuClimaticModelsMarkovModelling As ToolStripMenuItem
    Friend WithEvents mnuClimaticDescribeSunshineRadiation As ToolStripMenuItem
    Friend WithEvents mnuClimaticDescribeGeneral As ToolStripMenuItem
    Friend WithEvents mnuClimaticSCFSupportExporttoCPT As ToolStripMenuItem
    Friend WithEvents mnuClimaticSCFSupportOpenSST As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator31 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator32 As ToolStripSeparator
    Friend WithEvents mnuClimaticSCFSupportCorrelations As ToolStripMenuItem
    Friend WithEvents mnuClimaticSCFSupportPrincipalComponents As ToolStripMenuItem
    Friend WithEvents mnuClimaticSCFSupportCanonicalCorrelations As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareUnstackDailyData As ToolStripMenuItem
    Friend WithEvents mnuClimaticDefineClimaticData As ToolStripMenuItem
    Friend WithEvents mnuPrepareCalculateDuplicateColumn As ToolStripMenuItem
    Friend WithEvents mnuProcurement As ToolStripMenuItem
    Friend WithEvents mnuProcurementPrepare As ToolStripMenuItem
    Friend WithEvents mnuProcurementDescribe As ToolStripMenuItem
    Friend WithEvents mnuProcurementModel As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnReshapeGeneralSummaries As ToolStripMenuItem
    Friend WithEvents mnuPrepareKeysAndLinks As ToolStripMenuItem
    Friend WithEvents mnuPrepareKeysAndLinksAddKey As ToolStripMenuItem
    Friend WithEvents mnuPrepareKeysAndLinksViewAndRemoveKey As ToolStripMenuItem
    Friend WithEvents mnuPrepareKeysAndLinksAddLink As ToolStripMenuItem
    Friend WithEvents mnuPrepareKeysAndLinksViewAndRemoveKeys As ToolStripMenuItem
    Friend WithEvents mnuPrepareKeysAndLinksAddComment As ToolStripMenuItem
    Friend WithEvents mnuClimaticModelsExtremes As ToolStripMenuItem
    Friend WithEvents mnuClimaticModelsCircular As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents mnuClimaticPrepareClimaticSummaries As ToolStripMenuItem
    Friend WithEvents mnuClimaticCheckDataInventory As ToolStripMenuItem
    Friend WithEvents mnuClimaticCheckDataDisplayDaily As ToolStripMenuItem
    Friend WithEvents mnuClimaticCheckDataQCRainfall As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As ToolStripSeparator
    Friend WithEvents mnuProcurementDefineData As ToolStripMenuItem
    Friend WithEvents mnuClimaticSCFSupportCumulativeExceedanceGraphs As ToolStripMenuItem
    Friend WithEvents mnuProcurementPrepareMergeAdditionalData As ToolStripMenuItem
    Friend WithEvents mnuProcurementPrepareFilterByCountry As ToolStripMenuItem
    Friend WithEvents mnuProcurementPrepareUseAwardDate As ToolStripMenuItem
    Friend WithEvents mnuProcurementPrepareSetFactorReferenceLevel As ToolStripMenuItem
    Friend WithEvents mnuProcurementPrepareDefineContractValueCategories As ToolStripMenuItem
    Friend WithEvents mnuProcurementDefineRedFlags As ToolStripMenuItem
    Friend WithEvents mnuProcurementModelFitModelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuProcurementUseCRI As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator33 As ToolStripSeparator
    Friend WithEvents mnuDescribeOneVariableFrequencies As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator34 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents mnuDescribeTwoVariablesFrequencies As ToolStripMenuItem
    Friend WithEvents ImportFromCSPROToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportFromToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenNetCDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuProcurementPrepareRecodeNumericIntoQuantiles As ToolStripMenuItem
    Friend WithEvents mnuDescribeThreeVariable As ToolStripMenuItem
    Friend WithEvents mnuDescribeThreeVariableSummarise As ToolStripMenuItem
    Friend WithEvents mnuDescribeThreeVariableGraph As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator36 As ToolStripSeparator
    Friend WithEvents mnuDescribeThreeVariableFrequencies As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator35 As ToolStripSeparator
    Friend WithEvents splOverall As SplitContainer
    Friend WithEvents splDataOutput As SplitContainer
    Friend WithEvents ucrDataViewer As ucrDataView
    Friend WithEvents ucrOutput As ucrOutputWindow
    Friend WithEvents splExtraWindows As SplitContainer
    Friend WithEvents splMetadata As SplitContainer
    Friend WithEvents splLogScript As SplitContainer
    Friend WithEvents ucrColumnMeta As ucrColumnMetadata
    Friend WithEvents mnuViewResetToDefaultLayout As ToolStripMenuItem
    Friend WithEvents ucrDataFrameMeta As ucrDataFrameMetadata
    Friend WithEvents ucrLogWindow As ucrLog
    Friend WithEvents ucrScriptWindow As ucrScript
    Friend WithEvents mnuClimaticFileImportGriddedData As ToolStripMenuItem
    Friend WithEvents RatingDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuPrepareFactorViewLabels As ToolStripMenuItem
    Friend WithEvents mnuDescribeViewGraph As ToolStripMenuItem
    Friend WithEvents mnuClimaticDates As ToolStripMenuItem
    Friend WithEvents mnuClimaticDatesGenerateDates As ToolStripMenuItem
    Friend WithEvents mnuClimaticDatesMakeDate As ToolStripMenuItem
    Friend WithEvents mnuClimaticDatesUseDate As ToolStripMenuItem
    Friend WithEvents mnuClimaticDatesInfillMissingDates As ToolStripMenuItem
    Friend WithEvents mnuClimaticDatesMakeTime As ToolStripMenuItem
    Friend WithEvents mnuClimaticDatesUseTime As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareStartoftheRains As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareSpells As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareExtremes As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareEndOfRains As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportDataSetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportRWorkspaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportGraphAsImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportRObjectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FrequencyTablesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator38 As ToolStripSeparator
    Friend WithEvents mnuClimaticDescribeWindSpeedDirectionWindRose As ToolStripMenuItem
    Friend WithEvents CummulativeDistributionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuProcurementUseCRISummariseCRIbyCountry As ToolStripMenuItem
    Friend WithEvents mnuProcurementDescribeOneVar As ToolStripMenuItem
    Friend WithEvents mnuProcurementDescribeTwoVar As ToolStripMenuItem
    Friend WithEvents mnuPrepareCheckDataDuplicates As ToolStripMenuItem
    Friend WithEvents mnuClimaticCheckDataBoxplot As ToolStripMenuItem
    Friend WithEvents mnuCMSAF As ToolStripMenuItem
    Friend WithEvents mnuClimaticCMSAFPlotRegion As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnInfillMissingDates As ToolStripMenuItem
    Friend WithEvents mnuTbOpenFromLibrary As ToolStripButton
    Friend WithEvents mnuTbDataView As ToolStripButton
    Friend WithEvents mnuTbOutput As ToolStripButton
    Friend WithEvents mnuTbColumnMetadata As ToolStripButton
    Friend WithEvents mnuTbLog As ToolStripButton
    Friend WithEvents separator3 As ToolStripSeparator
    Friend WithEvents mnuTbResetLayout As ToolStripButton
    Friend WithEvents mnuTbOpen As ToolStripSplitButton
    Friend WithEvents mnuViewClimaticMenu As ToolStripMenuItem
    Friend WithEvents mnuViewProcurementMenu As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator39 As ToolStripSeparator
    Friend WithEvents mnuPrepareCheckDataBoxplot As ToolStripMenuItem
    Friend WithEvents mnuPrepareCheckDataOneVariableGraph As ToolStripMenuItem
    Friend WithEvents mnuPrepareCheckDataOneVariableSummarise As ToolStripMenuItem
    Friend WithEvents mnuPrepareCheckDataOneWayFrequencies As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator40 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator41 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator30 As ToolStripSeparator
    Friend WithEvents mnuClimaticCheckDataQCTemperatures As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator37 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator42 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator43 As ToolStripSeparator
    Friend WithEvents SummariseRedFlagsByCountryorOtherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummariseRedFlagsByCountryAndYearorOtherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OneVariableSummariseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OneVariableGraphToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator44 As ToolStripSeparator
    Friend WithEvents CorrelationsRedFlagsOrOthersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MappingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MapCountryValuesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuProcurementDefineCorruption As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator45 As ToolStripSeparator
    Friend WithEvents mnuProcurementCalculateCRI As ToolStripMenuItem
    Friend WithEvents OpenNETcdfFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificMosaic As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificParallelCoordinatePlot As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnCalculateGeneralSummaries As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnCalculateColumnSummaries As ToolStripMenuItem
    Friend WithEvents mnuModelHypothesisTests As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator46 As ToolStripSeparator
    Friend WithEvents mnuClimaticPrepareEvapotranspiration As ToolStripMenuItem
    Friend WithEvents mnuPrepareCheckDataCompareColumns As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContext As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextDefineOptionsByContexts As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextPrepare As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextMergeAdditionalData As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextCheckData As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextDescribe As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextDescribeCompareTwoTreatments As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextDescribeCompareMultipleTreatments As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextCheckDataDuplicates As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextCheckDataCompareColumns As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextModel As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextModelFitModel As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextGeneralFitModel As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextPrepareStack As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextPrepareUnstack As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator47 As ToolStripSeparator
    Friend WithEvents mnuOptionsByContextCheckDataOneVariableSummarise As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextCheckDataOneVariableGraph As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextCheckDataOneVariableFrequencies As ToolStripMenuItem
    Friend WithEvents mnuViewOptionsByContextMenu As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator48 As ToolStripSeparator
    Friend WithEvents mnuOptionsByContextDescribeBoxplot As ToolStripMenuItem
    Friend WithEvents mnuPrepareCheckDataAnonymiseIDColumn As ToolStripMenuItem
    Friend WithEvents mnuPrepareCheckDataNonNumericCases As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator49 As ToolStripSeparator
    Friend WithEvents mnuClimaticTidyandExamine As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineTidyDailyData As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineNonNumericCases As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineReplaceValues As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineOneVariableSummarize As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator50 As ToolStripSeparator
    Friend WithEvents mnuClimaticPrepareLengthOfSeason As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareCompare As ToolStripMenuItem
    Friend WithEvents mnuClimaticFileImportShapeFile As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineMerge As ToolStripMenuItem
    Friend WithEvents mnuTbLastGraph As ToolStripButton
    Friend WithEvents mnuClimaticCMSAFExporttoCMSAFRToolbox As ToolStripMenuItem
    Friend WithEvents mnuClimaticCheckDataStationMaps As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator51 As ToolStripSeparator
    Friend WithEvents mnuClimaticPrepareConversions As ToolStripMenuItem
    Friend WithEvents mnuHelpAcknowledgments As ToolStripMenuItem
    Friend WithEvents mnuClimaticModelSPI As ToolStripMenuItem
End Class
