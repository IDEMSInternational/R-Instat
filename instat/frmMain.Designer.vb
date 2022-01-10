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
        Me.mnuDescribeOneVariableVisualiseData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator72 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeOneVariableSummarise = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeOneVariableGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeOneVariableFrequencies = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeOneVariableRatingData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeTwoVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeTwoVariablesSummarise = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeTwoVariablesGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeTwoVariablesFrequencies = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeTwoVariablesPivotTable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeThreeVariable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeThreeVariableSummarise = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeThreeVariableGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator36 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeThreeVariableFrequencies = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeThreeVariablePivotTable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificTablesGraphs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificFrequency = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificMultipleResponse = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator26 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeSpecificBarPieChart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificBoxplotJitterViolinPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificHistogramDensityFrequencyPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificPointPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificLineSmoothPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificMapPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificDotPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator27 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeSpecificMosaic = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificCummulativeDistribution = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificParallelCoordinatePlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeGeneralColumnSummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeGeneralTabulation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeGeneralGraphics = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator38 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeGeneralUseSummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeMultivariate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeMultivariateCorrelations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeMultivariateprincipalComponents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeMultivariateCanonicalCorrelations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeMultivariateClusterAnalysis = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuModelFitModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelFitModelOneVariable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelFitModelTwoVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelFitModelThreeVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelFitModelFourVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator24 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuModelFitModelGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelFitModelMachineLearning = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator57 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuModelFitModelHypothesisTestsKeyboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelFitModelModelKeyboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelCompareModels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelCompareModelsOneVariable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelUseModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelUseModelOneVariable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelUseModelTwoVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator59 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuModelUseModelGlance = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelUseModelTidy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModelUseModelAugment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator58 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuModelUseModelUseModelKeyboard = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuClimaticCropCropCoefficients = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCropWaterSatisfactionIndex = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticHeatSum = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewDataView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewOutputWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewScriptWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewColumnMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewDataFrameMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuViewStructuredMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewClimaticMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewProcurementMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewOptionsByContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator39 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuViewResetToDefaultLayout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewSwapDataAndMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpHelpIntroduction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpHistFAQ = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpGetingStarted = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator28 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelpWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpDataViewSpreadsheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpMenus = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAboutR = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuClimaticFileImportSST = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticFileImportfromIRIDataLibrary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticFileImportfromClimateDataStore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticFileImportandTidyNetCDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticFileImportandTidyShapefile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimateFileImportfromClimSoft = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateFileImportfromClimSoftWizard = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticFileImportfromCliData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticFileExportToClimsoft = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticFileExportToCPT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportToWWRToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticTidyandExamine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineVisualiseData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineTidyDailyData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineNonNumericCases = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineReplaceValues = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineDuplicates = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator54 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticTidyandExamineStack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineUnstack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineMerge = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineAppend = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator69 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSetupForDataEntry = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTidyandExamineClimaticDataEntry = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineCompareColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator50 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticTidyandExamineOneVariableSummarize = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineOneVariableGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineOneVariableFrequencies = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDatesGenerateDates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDatesMakeDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDatesInfillMissingDates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDatesUseDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDatesMakeTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDatesUseTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDefineClimaticData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCheckData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCheckDataInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCheckDataDisplayDaily = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator65 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticCheckDataFillMissingValues = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCheckDataBoxplot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCheckDataQCTemperatures = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCheckDataQCRainfall = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator70 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticCheckDataHomogenization = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCheckDataCheckStationLocations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepare = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCimaticPrepareTransform = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareConversions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator37 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticPrepareClimaticSummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareStartoftheRains = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareEndOfRains = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareLengthOfSeason = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareSpells = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareExtremes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator64 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticPrepareClimdex = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareSPI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator51 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticPrepareEvapotranspiration = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareNewWorksheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareImportDailyData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareMakeFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareShiftDailyData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareUnstackDailyData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareStackDailyData = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuClimaticNCMP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticNCMPIndices = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticNCMPVariogram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticNCMPRegionAverage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticNCMPTrendGraphs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticNCMPCountRecords = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticNCMPSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPICSA = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPICSARainfall = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPICSACumExeedenceGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPICSATemperature = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPICSACrops = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMSAF = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCMSAFPlotRegion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCMSAFExporttoCMSAFRToolbox = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCompare = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCompareCalculation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCompareSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator66 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticCompareCorrelations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCompareScatterplot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCompareTimeSeriesPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCompareSeasonalPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCompareDensityPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCompareConditionalQuantiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticCompareTaylorDiagram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticMapping = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticMappingMap = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticMappingCheckStationLocations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticModelsExtremes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticModelCircular = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticModelMarkovModelling = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticSCF = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticSCFSupportOpenSST = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticSCFSupportExporttoCPT = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator32 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticSCFSupportCorrelations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticSCFSupportPrincipalComponents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticSCFSupportCanonicalCorrelations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticSCFSupportCumulativeExceedanceGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethods = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsDataManipulation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsDataManipulationStartOfRain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsDataManipulationEndOfRain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsDataManipulationExportCPTToTabular = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsDataManipulationDayMonth = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDaily = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsDataManipulationDisplaySpellLength = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsDataManipulationExportForPICSA = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsDataManipulationExtremeEvents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsDataManipulationMissingData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsDataManipulationMissingDataTable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationMonthlySummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsDataManipulationOutputForCD = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsGraphics = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsGraphicsClipBoxPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsGraphicsCliplot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsGraphicsMissingValues = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsGraphicsHistogram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsGraphicsCumExceedance = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsGraphicsBoxplot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsGraphicsInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsGraphicsAnnualRainfall = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsGraphicsRainCount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsGraphicsTimeseries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsGraphicsWindrose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateMethodsGraphicsMultipleLines = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClmateMethodThreeSummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsAdditional = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsAdditionalOutputForCPT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsAdditionalRainsStatistics = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticClimateMethodsAdditionalWaterBalance = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuPasteSpecial = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPasteNewDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator71 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEditScript = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.stsStrip = New System.Windows.Forms.StatusStrip()
        Me.tstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tool_strip = New System.Windows.Forms.ToolStrip()
        Me.mnuTbOpen = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuTbOpenFromLibrary = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbSave = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbCopy = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuSubTbCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSubTbCopySpecial = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTbPaste = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuSubTbPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSubTbPasteSpecial = New System.Windows.Forms.ToolStripMenuItem()
        Me.separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbEditLastDialog = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbLast10Dialogs = New System.Windows.Forms.ToolStripDropDownButton()
        Me.sepStart = New System.Windows.Forms.ToolStripSeparator()
        Me.sepEnd = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLastGraph = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuViewer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuploty = New System.Windows.Forms.ToolStripMenuItem()
        Me.separator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbDataView = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbOutput = New System.Windows.Forms.ToolStripButton()
        Me.mnuMetadata = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuColumnMetadat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataFrameMetadat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTbLog = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuLogWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScriptWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTbResetLayout = New System.Windows.Forms.ToolStripButton()
        Me.separator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbHelp = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbLan = New System.Windows.Forms.ToolStripButton()
        Me.mnuBar = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNewDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileImportFromFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileImportFromLibrary = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileImportFromODK = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileImportFromCSPRO = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileImportFromDatabases = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileImportandTidyNetCDFFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileConvert = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlSeparatorFile = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExportExportDataSet = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExportExportRObjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExportExportRWorkspace = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExportExportGraphAsImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileCloseData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepare = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameViewData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameRenameColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameDuplicateColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameRowNumbersNames = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareDataFrameSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameSelectColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameReplaceValues = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameConvertColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareDataFrameReorderColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameInsertColumnsRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameDeleteColumnsRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameProtectColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameHideColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameFreezeColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameColumnStructure = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataframeColourByProperty = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataVisualiseData = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuPrepareCheckDataPrePareToShareSdcPackage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataAnonymiseIDColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareCalculator = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnCalculate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnNumericRegularSequence = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnNumericEnter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator25 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareColumnNumericRowSummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnNumericTransform = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnNumericPolynomials = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator56 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareColumnNumericRandomSamples = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnNumericPermuteRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactorConvertToFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactorRecodeNumeric = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactorCountInFactor = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuPrepareColumnDateGenerateDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnDateMakeDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnDateInfillMissingDates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnDateUseDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnDateMakeTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnDateUseTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnDefine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnDefineConvertColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator55 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareColumnDefineCircular = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareDataReshape = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuPrepareDataReshapeScaleOrDistance = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuStructured = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredCircular = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredCircularDefine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredCircularCalculator = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredCircularSummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator46 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuStructuredCircularDensityPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator67 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuStructuredCircularWindRose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredCircularWindPollutionRose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredCircularOtherRosePlots = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator68 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuStructuredCircularCirclize = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredLow_Flow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredLow_FlowDefine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredSurvival = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredSurvivalDefine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredTimeSeries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredTimeSeriesDefine = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator60 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuStructuredTimeSeriesDescribe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredTimeSeriesDescribeOneVariable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredTimeSeriesDescribeGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator61 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuStructuredTimeSeriesModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredTimeSeriesModelOneVariable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredTimeSeriesModelGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator62 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator63 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuStructuredClimatic = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredProcurement = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStructuredOptionByContext = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurement = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementOpenFromLibrary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementDefineData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementPrepare = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementPrepareFilterByCountry = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator42 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuProcurementPrepareDefineContractValueCategories = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementPrepareRecodeNumericIntoQuantiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementPrepareSetFactorReferenceLevel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementPrepareUseAwardDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator43 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuProcurementPrepareSummariseRedFlagsByCountryorOther = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementPrepareSummariseRedFlagsByCountryAndYearorOther = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementPrepareMergeAdditionalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementDescribe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementDescribeOneVariableSummarise = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementDescribeOneVariableGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator44 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuProcurementDescribeCategorical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementDescribeCategoricalOneVarFreq = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementDescribeCategoricalTwoVarFreq = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator52 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuProcurementDescribeCategoricalBarCharts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementDescribeCategoricalMosaic = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementDescribeCategoricalTreemap = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayTopNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementDescribeNumeric = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementDescribeNumericBoxplot = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistogramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator53 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuProcurementDescribeNumericCorrelationsRedFlagsOrOthers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementMapping = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementMappingMapCountryValues = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementModelDefineCorruption = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementModelFitModelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator45 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuProcurementDefineRedFlags = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementUseCRI = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProcurementCTFVCalculateCRI = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuToolsInstallRPackage = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuRViewer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPlotly = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColumnMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataFrameMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScriptFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogFile = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeOneVariable, Me.mnuDescribeTwoVariables, Me.mnuDescribeThreeVariable, Me.mnuDescribeSpecificTablesGraphs, Me.mnuDescribeGeneral, Me.ToolStripSeparator9, Me.mnuDescribeMultivariate, Me.ToolStripSeparator13, Me.mnuDescribeUseGraph, Me.mnuDescribeCombineGraph, Me.mnuDescribeThemes, Me.mnuDescribeViewGraph})
        Me.mnuDescribe.Name = "mnuDescribe"
        Me.mnuDescribe.Size = New System.Drawing.Size(64, 20)
        Me.mnuDescribe.Tag = "Describe"
        Me.mnuDescribe.Text = "Describe"
        '
        'mnuDescribeOneVariable
        '
        Me.mnuDescribeOneVariable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeOneVariableVisualiseData, Me.ToolStripSeparator72, Me.mnuDescribeOneVariableSummarise, Me.mnuDescribeOneVariableGraph, Me.ToolStripSeparator33, Me.mnuDescribeOneVariableFrequencies, Me.mnuDescribeOneVariableRatingData})
        Me.mnuDescribeOneVariable.Name = "mnuDescribeOneVariable"
        Me.mnuDescribeOneVariable.Size = New System.Drawing.Size(192, 22)
        Me.mnuDescribeOneVariable.Tag = "One_Variable"
        Me.mnuDescribeOneVariable.Text = "One Variable"
        '
        'mnuDescribeOneVariableVisualiseData
        '
        Me.mnuDescribeOneVariableVisualiseData.Name = "mnuDescribeOneVariableVisualiseData"
        Me.mnuDescribeOneVariableVisualiseData.Size = New System.Drawing.Size(155, 22)
        Me.mnuDescribeOneVariableVisualiseData.Text = "Visualise Data..."
        '
        'ToolStripSeparator72
        '
        Me.ToolStripSeparator72.Name = "ToolStripSeparator72"
        Me.ToolStripSeparator72.Size = New System.Drawing.Size(152, 6)
        '
        'mnuDescribeOneVariableSummarise
        '
        Me.mnuDescribeOneVariableSummarise.Name = "mnuDescribeOneVariableSummarise"
        Me.mnuDescribeOneVariableSummarise.Size = New System.Drawing.Size(155, 22)
        Me.mnuDescribeOneVariableSummarise.Tag = "Summarise..."
        Me.mnuDescribeOneVariableSummarise.Text = "Summarise..."
        '
        'mnuDescribeOneVariableGraph
        '
        Me.mnuDescribeOneVariableGraph.Name = "mnuDescribeOneVariableGraph"
        Me.mnuDescribeOneVariableGraph.Size = New System.Drawing.Size(155, 22)
        Me.mnuDescribeOneVariableGraph.Tag = "Graph..."
        Me.mnuDescribeOneVariableGraph.Text = "Graph..."
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(152, 6)
        '
        'mnuDescribeOneVariableFrequencies
        '
        Me.mnuDescribeOneVariableFrequencies.Name = "mnuDescribeOneVariableFrequencies"
        Me.mnuDescribeOneVariableFrequencies.Size = New System.Drawing.Size(155, 22)
        Me.mnuDescribeOneVariableFrequencies.Text = "Frequencies..."
        '
        'mnuDescribeOneVariableRatingData
        '
        Me.mnuDescribeOneVariableRatingData.Name = "mnuDescribeOneVariableRatingData"
        Me.mnuDescribeOneVariableRatingData.Size = New System.Drawing.Size(155, 22)
        Me.mnuDescribeOneVariableRatingData.Text = "Rating Data..."
        '
        'mnuDescribeTwoVariables
        '
        Me.mnuDescribeTwoVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeTwoVariablesSummarise, Me.mnuDescribeTwoVariablesGraph, Me.ToolStripSeparator34, Me.mnuDescribeTwoVariablesFrequencies, Me.mnuDescribeTwoVariablesPivotTable})
        Me.mnuDescribeTwoVariables.Name = "mnuDescribeTwoVariables"
        Me.mnuDescribeTwoVariables.Size = New System.Drawing.Size(192, 22)
        Me.mnuDescribeTwoVariables.Tag = "Two_Variables"
        Me.mnuDescribeTwoVariables.Text = "Two Variables"
        '
        'mnuDescribeTwoVariablesSummarise
        '
        Me.mnuDescribeTwoVariablesSummarise.DoubleClickEnabled = True
        Me.mnuDescribeTwoVariablesSummarise.Name = "mnuDescribeTwoVariablesSummarise"
        Me.mnuDescribeTwoVariablesSummarise.Size = New System.Drawing.Size(146, 22)
        Me.mnuDescribeTwoVariablesSummarise.Tag = "Summarise..."
        Me.mnuDescribeTwoVariablesSummarise.Text = "Summarise..."
        '
        'mnuDescribeTwoVariablesGraph
        '
        Me.mnuDescribeTwoVariablesGraph.Name = "mnuDescribeTwoVariablesGraph"
        Me.mnuDescribeTwoVariablesGraph.Size = New System.Drawing.Size(146, 22)
        Me.mnuDescribeTwoVariablesGraph.Tag = "Graph..."
        Me.mnuDescribeTwoVariablesGraph.Text = "Graph..."
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(143, 6)
        '
        'mnuDescribeTwoVariablesFrequencies
        '
        Me.mnuDescribeTwoVariablesFrequencies.DoubleClickEnabled = True
        Me.mnuDescribeTwoVariablesFrequencies.Name = "mnuDescribeTwoVariablesFrequencies"
        Me.mnuDescribeTwoVariablesFrequencies.Size = New System.Drawing.Size(146, 22)
        Me.mnuDescribeTwoVariablesFrequencies.Text = "Frequencies..."
        '
        'mnuDescribeTwoVariablesPivotTable
        '
        Me.mnuDescribeTwoVariablesPivotTable.Name = "mnuDescribeTwoVariablesPivotTable"
        Me.mnuDescribeTwoVariablesPivotTable.Size = New System.Drawing.Size(146, 22)
        Me.mnuDescribeTwoVariablesPivotTable.Text = "Pivot Table..."
        '
        'mnuDescribeThreeVariable
        '
        Me.mnuDescribeThreeVariable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeThreeVariableSummarise, Me.mnuDescribeThreeVariableGraph, Me.ToolStripSeparator36, Me.mnuDescribeThreeVariableFrequencies, Me.mnuDescribeThreeVariablePivotTable})
        Me.mnuDescribeThreeVariable.Name = "mnuDescribeThreeVariable"
        Me.mnuDescribeThreeVariable.Size = New System.Drawing.Size(192, 22)
        Me.mnuDescribeThreeVariable.Text = "Three Variables"
        '
        'mnuDescribeThreeVariableSummarise
        '
        Me.mnuDescribeThreeVariableSummarise.Enabled = False
        Me.mnuDescribeThreeVariableSummarise.Name = "mnuDescribeThreeVariableSummarise"
        Me.mnuDescribeThreeVariableSummarise.Size = New System.Drawing.Size(146, 22)
        Me.mnuDescribeThreeVariableSummarise.Text = "Summarise..."
        '
        'mnuDescribeThreeVariableGraph
        '
        Me.mnuDescribeThreeVariableGraph.Enabled = False
        Me.mnuDescribeThreeVariableGraph.Name = "mnuDescribeThreeVariableGraph"
        Me.mnuDescribeThreeVariableGraph.Size = New System.Drawing.Size(146, 22)
        Me.mnuDescribeThreeVariableGraph.Text = "Graph..."
        '
        'ToolStripSeparator36
        '
        Me.ToolStripSeparator36.Name = "ToolStripSeparator36"
        Me.ToolStripSeparator36.Size = New System.Drawing.Size(143, 6)
        '
        'mnuDescribeThreeVariableFrequencies
        '
        Me.mnuDescribeThreeVariableFrequencies.Name = "mnuDescribeThreeVariableFrequencies"
        Me.mnuDescribeThreeVariableFrequencies.Size = New System.Drawing.Size(146, 22)
        Me.mnuDescribeThreeVariableFrequencies.Text = "Frequencies..."
        '
        'mnuDescribeThreeVariablePivotTable
        '
        Me.mnuDescribeThreeVariablePivotTable.Name = "mnuDescribeThreeVariablePivotTable"
        Me.mnuDescribeThreeVariablePivotTable.Size = New System.Drawing.Size(146, 22)
        Me.mnuDescribeThreeVariablePivotTable.Text = "Pivot Table..."
        '
        'mnuDescribeSpecificTablesGraphs
        '
        Me.mnuDescribeSpecificTablesGraphs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeSpecificFrequency, Me.mnuDescribeSpecificSummary, Me.mnuDescribeSpecificMultipleResponse, Me.ToolStripSeparator26, Me.mnuDescribeSpecificBarPieChart, Me.mnuDescribeSpecificBoxplotJitterViolinPlot, Me.mnuDescribeSpecificHistogramDensityFrequencyPlot, Me.mnuDescribeSpecificPointPlot, Me.mnuDescribeSpecificLineSmoothPlot, Me.mnuDescribeSpecificMapPlot, Me.mnuDescribeSpecificDotPlot, Me.ToolStripSeparator27, Me.mnuDescribeSpecificMosaic, Me.mnuDescribeSpecificCummulativeDistribution, Me.mnuDescribeSpecificParallelCoordinatePlot})
        Me.mnuDescribeSpecificTablesGraphs.Name = "mnuDescribeSpecificTablesGraphs"
        Me.mnuDescribeSpecificTablesGraphs.Size = New System.Drawing.Size(192, 22)
        Me.mnuDescribeSpecificTablesGraphs.Tag = "Table_Dialogs"
        Me.mnuDescribeSpecificTablesGraphs.Text = "Specific Tables/Graphs"
        '
        'mnuDescribeSpecificFrequency
        '
        Me.mnuDescribeSpecificFrequency.Name = "mnuDescribeSpecificFrequency"
        Me.mnuDescribeSpecificFrequency.Size = New System.Drawing.Size(299, 22)
        Me.mnuDescribeSpecificFrequency.Tag = "Frequency..."
        Me.mnuDescribeSpecificFrequency.Text = "Frequency Tables..."
        '
        'mnuDescribeSpecificSummary
        '
        Me.mnuDescribeSpecificSummary.Name = "mnuDescribeSpecificSummary"
        Me.mnuDescribeSpecificSummary.Size = New System.Drawing.Size(299, 22)
        Me.mnuDescribeSpecificSummary.Tag = "Summary..."
        Me.mnuDescribeSpecificSummary.Text = "Summary Tables..."
        '
        'mnuDescribeSpecificMultipleResponse
        '
        Me.mnuDescribeSpecificMultipleResponse.Enabled = False
        Me.mnuDescribeSpecificMultipleResponse.Name = "mnuDescribeSpecificMultipleResponse"
        Me.mnuDescribeSpecificMultipleResponse.Size = New System.Drawing.Size(299, 22)
        Me.mnuDescribeSpecificMultipleResponse.Tag = "Multiple_Response..."
        Me.mnuDescribeSpecificMultipleResponse.Text = "Multiple Response..."
        Me.mnuDescribeSpecificMultipleResponse.Visible = False
        '
        'ToolStripSeparator26
        '
        Me.ToolStripSeparator26.Name = "ToolStripSeparator26"
        Me.ToolStripSeparator26.Size = New System.Drawing.Size(296, 6)
        '
        'mnuDescribeSpecificBarPieChart
        '
        Me.mnuDescribeSpecificBarPieChart.Name = "mnuDescribeSpecificBarPieChart"
        Me.mnuDescribeSpecificBarPieChart.Size = New System.Drawing.Size(299, 22)
        Me.mnuDescribeSpecificBarPieChart.Tag = "Bar_Chart"
        Me.mnuDescribeSpecificBarPieChart.Text = "Bar Chart..."
        '
        'mnuDescribeSpecificBoxplotJitterViolinPlot
        '
        Me.mnuDescribeSpecificBoxplotJitterViolinPlot.Name = "mnuDescribeSpecificBoxplotJitterViolinPlot"
        Me.mnuDescribeSpecificBoxplotJitterViolinPlot.Size = New System.Drawing.Size(299, 22)
        Me.mnuDescribeSpecificBoxplotJitterViolinPlot.Tag = "Boxplot..."
        Me.mnuDescribeSpecificBoxplotJitterViolinPlot.Text = "Boxplot/Jitter/Violin Plot..."
        '
        'mnuDescribeSpecificHistogramDensityFrequencyPlot
        '
        Me.mnuDescribeSpecificHistogramDensityFrequencyPlot.Name = "mnuDescribeSpecificHistogramDensityFrequencyPlot"
        Me.mnuDescribeSpecificHistogramDensityFrequencyPlot.Size = New System.Drawing.Size(299, 22)
        Me.mnuDescribeSpecificHistogramDensityFrequencyPlot.Tag = "Histogram..."
        Me.mnuDescribeSpecificHistogramDensityFrequencyPlot.Text = "Histogram/Density/Frequency Plot..."
        '
        'mnuDescribeSpecificPointPlot
        '
        Me.mnuDescribeSpecificPointPlot.Name = "mnuDescribeSpecificPointPlot"
        Me.mnuDescribeSpecificPointPlot.Size = New System.Drawing.Size(299, 22)
        Me.mnuDescribeSpecificPointPlot.Tag = "Point_Plot..."
        Me.mnuDescribeSpecificPointPlot.Text = "Point (Scatter) Plot..."
        '
        'mnuDescribeSpecificLineSmoothPlot
        '
        Me.mnuDescribeSpecificLineSmoothPlot.Name = "mnuDescribeSpecificLineSmoothPlot"
        Me.mnuDescribeSpecificLineSmoothPlot.Size = New System.Drawing.Size(299, 22)
        Me.mnuDescribeSpecificLineSmoothPlot.Tag = "Line_Plot..."
        Me.mnuDescribeSpecificLineSmoothPlot.Text = "Line/Smooth/Dumbbell/Slope Plot..."
        '
        'mnuDescribeSpecificMapPlot
        '
        Me.mnuDescribeSpecificMapPlot.Name = "mnuDescribeSpecificMapPlot"
        Me.mnuDescribeSpecificMapPlot.Size = New System.Drawing.Size(299, 22)
        Me.mnuDescribeSpecificMapPlot.Text = "Map/Choropleth/Contour/Heatmap Plot..."
        '
        'mnuDescribeSpecificDotPlot
        '
        Me.mnuDescribeSpecificDotPlot.Enabled = False
        Me.mnuDescribeSpecificDotPlot.Name = "mnuDescribeSpecificDotPlot"
        Me.mnuDescribeSpecificDotPlot.Size = New System.Drawing.Size(299, 22)
        Me.mnuDescribeSpecificDotPlot.Tag = "Dotplot..."
        Me.mnuDescribeSpecificDotPlot.Text = "Dot Plot..."
        Me.mnuDescribeSpecificDotPlot.Visible = False
        '
        'ToolStripSeparator27
        '
        Me.ToolStripSeparator27.Name = "ToolStripSeparator27"
        Me.ToolStripSeparator27.Size = New System.Drawing.Size(296, 6)
        '
        'mnuDescribeSpecificMosaic
        '
        Me.mnuDescribeSpecificMosaic.Name = "mnuDescribeSpecificMosaic"
        Me.mnuDescribeSpecificMosaic.Size = New System.Drawing.Size(299, 22)
        Me.mnuDescribeSpecificMosaic.Text = "Mosaic Plot..."
        '
        'mnuDescribeSpecificCummulativeDistribution
        '
        Me.mnuDescribeSpecificCummulativeDistribution.Name = "mnuDescribeSpecificCummulativeDistribution"
        Me.mnuDescribeSpecificCummulativeDistribution.Size = New System.Drawing.Size(299, 22)
        Me.mnuDescribeSpecificCummulativeDistribution.Text = "Cumulative Distribution..."
        '
        'mnuDescribeSpecificParallelCoordinatePlot
        '
        Me.mnuDescribeSpecificParallelCoordinatePlot.Name = "mnuDescribeSpecificParallelCoordinatePlot"
        Me.mnuDescribeSpecificParallelCoordinatePlot.Size = New System.Drawing.Size(299, 22)
        Me.mnuDescribeSpecificParallelCoordinatePlot.Text = "Parallel Coordinate Plot..."
        '
        'mnuDescribeGeneral
        '
        Me.mnuDescribeGeneral.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeGeneralColumnSummaries, Me.mnuDescribeGeneralTabulation, Me.mnuDescribeGeneralGraphics, Me.ToolStripSeparator38, Me.mnuDescribeGeneralUseSummaries})
        Me.mnuDescribeGeneral.Name = "mnuDescribeGeneral"
        Me.mnuDescribeGeneral.Size = New System.Drawing.Size(192, 22)
        Me.mnuDescribeGeneral.Tag = "General"
        Me.mnuDescribeGeneral.Text = "General"
        '
        'mnuDescribeGeneralColumnSummaries
        '
        Me.mnuDescribeGeneralColumnSummaries.Name = "mnuDescribeGeneralColumnSummaries"
        Me.mnuDescribeGeneralColumnSummaries.Size = New System.Drawing.Size(188, 22)
        Me.mnuDescribeGeneralColumnSummaries.Tag = "Column_Summaries..."
        Me.mnuDescribeGeneralColumnSummaries.Text = "Column Summaries..."
        '
        'mnuDescribeGeneralTabulation
        '
        Me.mnuDescribeGeneralTabulation.Enabled = False
        Me.mnuDescribeGeneralTabulation.Name = "mnuDescribeGeneralTabulation"
        Me.mnuDescribeGeneralTabulation.Size = New System.Drawing.Size(188, 22)
        Me.mnuDescribeGeneralTabulation.Tag = "Tabulation..."
        Me.mnuDescribeGeneralTabulation.Text = "Tabulation..."
        Me.mnuDescribeGeneralTabulation.Visible = False
        '
        'mnuDescribeGeneralGraphics
        '
        Me.mnuDescribeGeneralGraphics.Name = "mnuDescribeGeneralGraphics"
        Me.mnuDescribeGeneralGraphics.Size = New System.Drawing.Size(188, 22)
        Me.mnuDescribeGeneralGraphics.Tag = "Graphics..."
        Me.mnuDescribeGeneralGraphics.Text = "Graphics..."
        '
        'ToolStripSeparator38
        '
        Me.ToolStripSeparator38.Name = "ToolStripSeparator38"
        Me.ToolStripSeparator38.Size = New System.Drawing.Size(185, 6)
        '
        'mnuDescribeGeneralUseSummaries
        '
        Me.mnuDescribeGeneralUseSummaries.Name = "mnuDescribeGeneralUseSummaries"
        Me.mnuDescribeGeneralUseSummaries.Size = New System.Drawing.Size(188, 22)
        Me.mnuDescribeGeneralUseSummaries.Text = "Use Summaries..."
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(189, 6)
        '
        'mnuDescribeMultivariate
        '
        Me.mnuDescribeMultivariate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeMultivariateCorrelations, Me.mnuDescribeMultivariateprincipalComponents, Me.mnuDescribeMultivariateCanonicalCorrelations, Me.mnuDescribeMultivariateClusterAnalysis})
        Me.mnuDescribeMultivariate.Name = "mnuDescribeMultivariate"
        Me.mnuDescribeMultivariate.Size = New System.Drawing.Size(192, 22)
        Me.mnuDescribeMultivariate.Text = "Multivariate"
        '
        'mnuDescribeMultivariateCorrelations
        '
        Me.mnuDescribeMultivariateCorrelations.Name = "mnuDescribeMultivariateCorrelations"
        Me.mnuDescribeMultivariateCorrelations.Size = New System.Drawing.Size(203, 22)
        Me.mnuDescribeMultivariateCorrelations.Text = "Correlations..."
        '
        'mnuDescribeMultivariateprincipalComponents
        '
        Me.mnuDescribeMultivariateprincipalComponents.Name = "mnuDescribeMultivariateprincipalComponents"
        Me.mnuDescribeMultivariateprincipalComponents.Size = New System.Drawing.Size(203, 22)
        Me.mnuDescribeMultivariateprincipalComponents.Text = "Principal Components..."
        '
        'mnuDescribeMultivariateCanonicalCorrelations
        '
        Me.mnuDescribeMultivariateCanonicalCorrelations.Name = "mnuDescribeMultivariateCanonicalCorrelations"
        Me.mnuDescribeMultivariateCanonicalCorrelations.Size = New System.Drawing.Size(203, 22)
        Me.mnuDescribeMultivariateCanonicalCorrelations.Text = "Canonical Correlations..."
        '
        'mnuDescribeMultivariateClusterAnalysis
        '
        Me.mnuDescribeMultivariateClusterAnalysis.Enabled = False
        Me.mnuDescribeMultivariateClusterAnalysis.Name = "mnuDescribeMultivariateClusterAnalysis"
        Me.mnuDescribeMultivariateClusterAnalysis.Size = New System.Drawing.Size(203, 22)
        Me.mnuDescribeMultivariateClusterAnalysis.Text = "Cluster Analysis..."
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(189, 6)
        '
        'mnuDescribeUseGraph
        '
        Me.mnuDescribeUseGraph.Name = "mnuDescribeUseGraph"
        Me.mnuDescribeUseGraph.Size = New System.Drawing.Size(192, 22)
        Me.mnuDescribeUseGraph.Text = "Use Graph..."
        '
        'mnuDescribeCombineGraph
        '
        Me.mnuDescribeCombineGraph.Name = "mnuDescribeCombineGraph"
        Me.mnuDescribeCombineGraph.Size = New System.Drawing.Size(192, 22)
        Me.mnuDescribeCombineGraph.Text = "Combine Graphs..."
        '
        'mnuDescribeThemes
        '
        Me.mnuDescribeThemes.Enabled = False
        Me.mnuDescribeThemes.Name = "mnuDescribeThemes"
        Me.mnuDescribeThemes.Size = New System.Drawing.Size(192, 22)
        Me.mnuDescribeThemes.Text = "Themes..."
        Me.mnuDescribeThemes.Visible = False
        '
        'mnuDescribeViewGraph
        '
        Me.mnuDescribeViewGraph.Name = "mnuDescribeViewGraph"
        Me.mnuDescribeViewGraph.Size = New System.Drawing.Size(192, 22)
        Me.mnuDescribeViewGraph.Text = "View Graph..."
        '
        'mnuModel
        '
        Me.mnuModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelProbabilityDistributions, Me.ToolStripSeparator3, Me.mnuModelFitModel, Me.mnuModelCompareModels, Me.mnuModelUseModel, Me.mnuModelOtherOneVariable, Me.mnuModelOtherTwoVariables, Me.mnuModelOtherThreeVariables, Me.mnuModelOtherGeneral})
        Me.mnuModel.Name = "mnuModel"
        Me.mnuModel.Size = New System.Drawing.Size(53, 20)
        Me.mnuModel.Tag = "Model"
        Me.mnuModel.Text = "Model"
        '
        'mnuModelProbabilityDistributions
        '
        Me.mnuModelProbabilityDistributions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelProbabilityDistributionsShowModel, Me.mnuModelProbabilityDistributionsCompareModels, Me.mnuModelProbabilityDistributionsRandomSamplesUseModel})
        Me.mnuModelProbabilityDistributions.Name = "mnuModelProbabilityDistributions"
        Me.mnuModelProbabilityDistributions.Size = New System.Drawing.Size(201, 22)
        Me.mnuModelProbabilityDistributions.Tag = "Probability_Distributions"
        Me.mnuModelProbabilityDistributions.Text = "Probability Distributions"
        '
        'mnuModelProbabilityDistributionsShowModel
        '
        Me.mnuModelProbabilityDistributionsShowModel.Name = "mnuModelProbabilityDistributionsShowModel"
        Me.mnuModelProbabilityDistributionsShowModel.Size = New System.Drawing.Size(178, 22)
        Me.mnuModelProbabilityDistributionsShowModel.Text = "Show Model..."
        '
        'mnuModelProbabilityDistributionsCompareModels
        '
        Me.mnuModelProbabilityDistributionsCompareModels.Enabled = False
        Me.mnuModelProbabilityDistributionsCompareModels.Name = "mnuModelProbabilityDistributionsCompareModels"
        Me.mnuModelProbabilityDistributionsCompareModels.Size = New System.Drawing.Size(178, 22)
        Me.mnuModelProbabilityDistributionsCompareModels.Tag = "Show_Models..."
        Me.mnuModelProbabilityDistributionsCompareModels.Text = "Compare Models..."
        '
        'mnuModelProbabilityDistributionsRandomSamplesUseModel
        '
        Me.mnuModelProbabilityDistributionsRandomSamplesUseModel.Name = "mnuModelProbabilityDistributionsRandomSamplesUseModel"
        Me.mnuModelProbabilityDistributionsRandomSamplesUseModel.Size = New System.Drawing.Size(178, 22)
        Me.mnuModelProbabilityDistributionsRandomSamplesUseModel.Tag = "RandomSamples_(Use_Model)..."
        Me.mnuModelProbabilityDistributionsRandomSamplesUseModel.Text = "Random Samples ..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(198, 6)
        '
        'mnuModelFitModel
        '
        Me.mnuModelFitModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelFitModelOneVariable, Me.mnuModelFitModelTwoVariables, Me.mnuModelFitModelThreeVariables, Me.mnuModelFitModelFourVariables, Me.ToolStripSeparator24, Me.mnuModelFitModelGeneral, Me.mnuModelFitModelMachineLearning, Me.ToolStripSeparator57, Me.mnuModelFitModelHypothesisTestsKeyboard, Me.mnuModelFitModelModelKeyboard})
        Me.mnuModelFitModel.Name = "mnuModelFitModel"
        Me.mnuModelFitModel.Size = New System.Drawing.Size(201, 22)
        Me.mnuModelFitModel.Tag = "Fit_Model..."
        Me.mnuModelFitModel.Text = "Fit Model"
        '
        'mnuModelFitModelOneVariable
        '
        Me.mnuModelFitModelOneVariable.Name = "mnuModelFitModelOneVariable"
        Me.mnuModelFitModelOneVariable.Size = New System.Drawing.Size(228, 22)
        Me.mnuModelFitModelOneVariable.Text = "One Variable..."
        '
        'mnuModelFitModelTwoVariables
        '
        Me.mnuModelFitModelTwoVariables.Name = "mnuModelFitModelTwoVariables"
        Me.mnuModelFitModelTwoVariables.Size = New System.Drawing.Size(228, 22)
        Me.mnuModelFitModelTwoVariables.Text = "Two Variables..."
        '
        'mnuModelFitModelThreeVariables
        '
        Me.mnuModelFitModelThreeVariables.Name = "mnuModelFitModelThreeVariables"
        Me.mnuModelFitModelThreeVariables.Size = New System.Drawing.Size(228, 22)
        Me.mnuModelFitModelThreeVariables.Text = "Three Variables..."
        '
        'mnuModelFitModelFourVariables
        '
        Me.mnuModelFitModelFourVariables.Name = "mnuModelFitModelFourVariables"
        Me.mnuModelFitModelFourVariables.Size = New System.Drawing.Size(228, 22)
        Me.mnuModelFitModelFourVariables.Text = "Four Variables..."
        '
        'ToolStripSeparator24
        '
        Me.ToolStripSeparator24.Name = "ToolStripSeparator24"
        Me.ToolStripSeparator24.Size = New System.Drawing.Size(225, 6)
        '
        'mnuModelFitModelGeneral
        '
        Me.mnuModelFitModelGeneral.Name = "mnuModelFitModelGeneral"
        Me.mnuModelFitModelGeneral.Size = New System.Drawing.Size(228, 22)
        Me.mnuModelFitModelGeneral.Text = "General..."
        '
        'mnuModelFitModelMachineLearning
        '
        Me.mnuModelFitModelMachineLearning.Enabled = False
        Me.mnuModelFitModelMachineLearning.Name = "mnuModelFitModelMachineLearning"
        Me.mnuModelFitModelMachineLearning.Size = New System.Drawing.Size(228, 22)
        Me.mnuModelFitModelMachineLearning.Text = "Machine Learning (Caret)..."
        Me.mnuModelFitModelMachineLearning.Visible = False
        '
        'ToolStripSeparator57
        '
        Me.ToolStripSeparator57.Name = "ToolStripSeparator57"
        Me.ToolStripSeparator57.Size = New System.Drawing.Size(225, 6)
        '
        'mnuModelFitModelHypothesisTestsKeyboard
        '
        Me.mnuModelFitModelHypothesisTestsKeyboard.Name = "mnuModelFitModelHypothesisTestsKeyboard"
        Me.mnuModelFitModelHypothesisTestsKeyboard.Size = New System.Drawing.Size(228, 22)
        Me.mnuModelFitModelHypothesisTestsKeyboard.Text = "Hypothesis Tests Keyboards..."
        '
        'mnuModelFitModelModelKeyboard
        '
        Me.mnuModelFitModelModelKeyboard.Name = "mnuModelFitModelModelKeyboard"
        Me.mnuModelFitModelModelKeyboard.Size = New System.Drawing.Size(228, 22)
        Me.mnuModelFitModelModelKeyboard.Text = "Fit Model Keyboards..."
        '
        'mnuModelCompareModels
        '
        Me.mnuModelCompareModels.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelCompareModelsOneVariable})
        Me.mnuModelCompareModels.Name = "mnuModelCompareModels"
        Me.mnuModelCompareModels.Size = New System.Drawing.Size(201, 22)
        Me.mnuModelCompareModels.Text = "Compare Models"
        '
        'mnuModelCompareModelsOneVariable
        '
        Me.mnuModelCompareModelsOneVariable.Name = "mnuModelCompareModelsOneVariable"
        Me.mnuModelCompareModelsOneVariable.Size = New System.Drawing.Size(149, 22)
        Me.mnuModelCompareModelsOneVariable.Text = "One Variable..."
        '
        'mnuModelUseModel
        '
        Me.mnuModelUseModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelUseModelOneVariable, Me.mnuModelUseModelTwoVariables, Me.ToolStripSeparator59, Me.mnuModelUseModelGlance, Me.mnuModelUseModelTidy, Me.mnuModelUseModelAugment, Me.ToolStripSeparator58, Me.mnuModelUseModelUseModelKeyboard})
        Me.mnuModelUseModel.Name = "mnuModelUseModel"
        Me.mnuModelUseModel.Size = New System.Drawing.Size(201, 22)
        Me.mnuModelUseModel.Text = "Use Model"
        '
        'mnuModelUseModelOneVariable
        '
        Me.mnuModelUseModelOneVariable.Name = "mnuModelUseModelOneVariable"
        Me.mnuModelUseModelOneVariable.Size = New System.Drawing.Size(197, 22)
        Me.mnuModelUseModelOneVariable.Text = "One Variable..."
        '
        'mnuModelUseModelTwoVariables
        '
        Me.mnuModelUseModelTwoVariables.Name = "mnuModelUseModelTwoVariables"
        Me.mnuModelUseModelTwoVariables.Size = New System.Drawing.Size(197, 22)
        Me.mnuModelUseModelTwoVariables.Text = "Two Variables..."
        '
        'ToolStripSeparator59
        '
        Me.ToolStripSeparator59.Name = "ToolStripSeparator59"
        Me.ToolStripSeparator59.Size = New System.Drawing.Size(194, 6)
        '
        'mnuModelUseModelGlance
        '
        Me.mnuModelUseModelGlance.Name = "mnuModelUseModelGlance"
        Me.mnuModelUseModelGlance.Size = New System.Drawing.Size(197, 22)
        Me.mnuModelUseModelGlance.Text = "Glance..."
        '
        'mnuModelUseModelTidy
        '
        Me.mnuModelUseModelTidy.Name = "mnuModelUseModelTidy"
        Me.mnuModelUseModelTidy.Size = New System.Drawing.Size(197, 22)
        Me.mnuModelUseModelTidy.Text = "Tidy..."
        '
        'mnuModelUseModelAugment
        '
        Me.mnuModelUseModelAugment.Name = "mnuModelUseModelAugment"
        Me.mnuModelUseModelAugment.Size = New System.Drawing.Size(197, 22)
        Me.mnuModelUseModelAugment.Text = "Augment..."
        '
        'ToolStripSeparator58
        '
        Me.ToolStripSeparator58.Name = "ToolStripSeparator58"
        Me.ToolStripSeparator58.Size = New System.Drawing.Size(194, 6)
        '
        'mnuModelUseModelUseModelKeyboard
        '
        Me.mnuModelUseModelUseModelKeyboard.Name = "mnuModelUseModelUseModelKeyboard"
        Me.mnuModelUseModelUseModelKeyboard.Size = New System.Drawing.Size(197, 22)
        Me.mnuModelUseModelUseModelKeyboard.Text = "Use Model Keyboards..."
        '
        'mnuModelOtherOneVariable
        '
        Me.mnuModelOtherOneVariable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelOtherOneVariableExactResults, Me.mnuModelOtherOneVariableSampleSummaryData, Me.mnuModelOtherOneVariableNonParametric, Me.mnuModelOtherOneVariableGoodnessofFit})
        Me.mnuModelOtherOneVariable.Enabled = False
        Me.mnuModelOtherOneVariable.Name = "mnuModelOtherOneVariable"
        Me.mnuModelOtherOneVariable.Size = New System.Drawing.Size(201, 22)
        Me.mnuModelOtherOneVariable.Tag = "Other_(One_Variable)"
        Me.mnuModelOtherOneVariable.Text = "Other (One Variable)"
        '
        'mnuModelOtherOneVariableExactResults
        '
        Me.mnuModelOtherOneVariableExactResults.Name = "mnuModelOtherOneVariableExactResults"
        Me.mnuModelOtherOneVariableExactResults.Size = New System.Drawing.Size(166, 22)
        Me.mnuModelOtherOneVariableExactResults.Tag = "Exact_Results..."
        Me.mnuModelOtherOneVariableExactResults.Text = "Exact Results..."
        '
        'mnuModelOtherOneVariableSampleSummaryData
        '
        Me.mnuModelOtherOneVariableSampleSummaryData.Enabled = False
        Me.mnuModelOtherOneVariableSampleSummaryData.Name = "mnuModelOtherOneVariableSampleSummaryData"
        Me.mnuModelOtherOneVariableSampleSummaryData.Size = New System.Drawing.Size(166, 22)
        Me.mnuModelOtherOneVariableSampleSummaryData.Tag = "Summary_Data..."
        Me.mnuModelOtherOneVariableSampleSummaryData.Text = "Summary Data..."
        '
        'mnuModelOtherOneVariableNonParametric
        '
        Me.mnuModelOtherOneVariableNonParametric.Enabled = False
        Me.mnuModelOtherOneVariableNonParametric.Name = "mnuModelOtherOneVariableNonParametric"
        Me.mnuModelOtherOneVariableNonParametric.Size = New System.Drawing.Size(166, 22)
        Me.mnuModelOtherOneVariableNonParametric.Tag = "Non_Parametric..."
        Me.mnuModelOtherOneVariableNonParametric.Text = "Non Parametric..."
        '
        'mnuModelOtherOneVariableGoodnessofFit
        '
        Me.mnuModelOtherOneVariableGoodnessofFit.Enabled = False
        Me.mnuModelOtherOneVariableGoodnessofFit.Name = "mnuModelOtherOneVariableGoodnessofFit"
        Me.mnuModelOtherOneVariableGoodnessofFit.Size = New System.Drawing.Size(166, 22)
        Me.mnuModelOtherOneVariableGoodnessofFit.Tag = "Goodness_of_Fit"
        Me.mnuModelOtherOneVariableGoodnessofFit.Text = "Goodness of Fit..."
        '
        'mnuModelOtherTwoVariables
        '
        Me.mnuModelOtherTwoVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelOtherTwoVariablesTwoSamples, Me.mnuModelOtherTwoVariablesSummaryData, Me.mnuModelOtherTwoVariablesSimpleRegression, Me.mnuModelOtherTwoVariablesOneWayANOVA, Me.mnuModelOtherTwoVariablesNonParametricTwoSamples, Me.mnuModelOtherTwoVariablesNonParametricOneWayANOVA})
        Me.mnuModelOtherTwoVariables.Enabled = False
        Me.mnuModelOtherTwoVariables.Name = "mnuModelOtherTwoVariables"
        Me.mnuModelOtherTwoVariables.Size = New System.Drawing.Size(201, 22)
        Me.mnuModelOtherTwoVariables.Tag = "Other_(Two_Variables)"
        Me.mnuModelOtherTwoVariables.Text = "Other (Two Variables)"
        '
        'mnuModelOtherTwoVariablesTwoSamples
        '
        Me.mnuModelOtherTwoVariablesTwoSamples.Enabled = False
        Me.mnuModelOtherTwoVariablesTwoSamples.Name = "mnuModelOtherTwoVariablesTwoSamples"
        Me.mnuModelOtherTwoVariablesTwoSamples.Size = New System.Drawing.Size(266, 22)
        Me.mnuModelOtherTwoVariablesTwoSamples.Tag = "Two_Samples..."
        Me.mnuModelOtherTwoVariablesTwoSamples.Text = "Two Samples..."
        '
        'mnuModelOtherTwoVariablesSummaryData
        '
        Me.mnuModelOtherTwoVariablesSummaryData.Enabled = False
        Me.mnuModelOtherTwoVariablesSummaryData.Name = "mnuModelOtherTwoVariablesSummaryData"
        Me.mnuModelOtherTwoVariablesSummaryData.Size = New System.Drawing.Size(266, 22)
        Me.mnuModelOtherTwoVariablesSummaryData.Tag = "Summary_Data..."
        Me.mnuModelOtherTwoVariablesSummaryData.Text = "Summary Data..."
        '
        'mnuModelOtherTwoVariablesSimpleRegression
        '
        Me.mnuModelOtherTwoVariablesSimpleRegression.Name = "mnuModelOtherTwoVariablesSimpleRegression"
        Me.mnuModelOtherTwoVariablesSimpleRegression.Size = New System.Drawing.Size(266, 22)
        Me.mnuModelOtherTwoVariablesSimpleRegression.Tag = "Simple_Regression..."
        Me.mnuModelOtherTwoVariablesSimpleRegression.Text = "Simple Regression..."
        '
        'mnuModelOtherTwoVariablesOneWayANOVA
        '
        Me.mnuModelOtherTwoVariablesOneWayANOVA.Name = "mnuModelOtherTwoVariablesOneWayANOVA"
        Me.mnuModelOtherTwoVariablesOneWayANOVA.Size = New System.Drawing.Size(266, 22)
        Me.mnuModelOtherTwoVariablesOneWayANOVA.Tag = "One_Way_ANOVA..."
        Me.mnuModelOtherTwoVariablesOneWayANOVA.Text = "One Way ANOVA..."
        '
        'mnuModelOtherTwoVariablesNonParametricTwoSamples
        '
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Enabled = False
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Name = "mnuModelOtherTwoVariablesNonParametricTwoSamples"
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Size = New System.Drawing.Size(266, 22)
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Tag = "Non_Parameteric_Two_Samples..."
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Text = "Non Parametric Two Samples..."
        '
        'mnuModelOtherTwoVariablesNonParametricOneWayANOVA
        '
        Me.mnuModelOtherTwoVariablesNonParametricOneWayANOVA.Name = "mnuModelOtherTwoVariablesNonParametricOneWayANOVA"
        Me.mnuModelOtherTwoVariablesNonParametricOneWayANOVA.Size = New System.Drawing.Size(266, 22)
        Me.mnuModelOtherTwoVariablesNonParametricOneWayANOVA.Tag = "Non_Parameteric_One_Way_ANOVA..."
        Me.mnuModelOtherTwoVariablesNonParametricOneWayANOVA.Text = "Non Parameteric One Way ANOVA..."
        '
        'mnuModelOtherThreeVariables
        '
        Me.mnuModelOtherThreeVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelOtherThreeVariablesSimpleWithGroups, Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA, Me.mnuModelOtherThreeVariablesChisquareTest})
        Me.mnuModelOtherThreeVariables.Enabled = False
        Me.mnuModelOtherThreeVariables.Name = "mnuModelOtherThreeVariables"
        Me.mnuModelOtherThreeVariables.Size = New System.Drawing.Size(201, 22)
        Me.mnuModelOtherThreeVariables.Tag = "Other_(Three_Variable)"
        Me.mnuModelOtherThreeVariables.Text = "Other (Three Variable)"
        '
        'mnuModelOtherThreeVariablesSimpleWithGroups
        '
        Me.mnuModelOtherThreeVariablesSimpleWithGroups.Enabled = False
        Me.mnuModelOtherThreeVariablesSimpleWithGroups.Name = "mnuModelOtherThreeVariablesSimpleWithGroups"
        Me.mnuModelOtherThreeVariablesSimpleWithGroups.Size = New System.Drawing.Size(259, 22)
        Me.mnuModelOtherThreeVariablesSimpleWithGroups.Tag = "Simple_with_groups..."
        Me.mnuModelOtherThreeVariablesSimpleWithGroups.Text = "Simple With Groups..."
        '
        'mnuModelOtherThreeVariablesNonParametricTwoWayANOVA
        '
        Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Name = "mnuModelOtherThreeVariablesNonParametricTwoWayANOVA"
        Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Size = New System.Drawing.Size(259, 22)
        Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Tag = "Non_Parametric_Two_Way_ANOVA..."
        Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Text = "Non Parametric Two Way ANOVA..."
        '
        'mnuModelOtherThreeVariablesChisquareTest
        '
        Me.mnuModelOtherThreeVariablesChisquareTest.Name = "mnuModelOtherThreeVariablesChisquareTest"
        Me.mnuModelOtherThreeVariablesChisquareTest.Size = New System.Drawing.Size(259, 22)
        Me.mnuModelOtherThreeVariablesChisquareTest.Tag = "Chi-square_Test"
        Me.mnuModelOtherThreeVariablesChisquareTest.Text = "Chi-square Test..."
        '
        'mnuModelOtherGeneral
        '
        Me.mnuModelOtherGeneral.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelOtherGeneralANOVAGeneral, Me.mnuModelOtherGeneralRegression, Me.mnuModelOtherGeneralLogLinear})
        Me.mnuModelOtherGeneral.Enabled = False
        Me.mnuModelOtherGeneral.Name = "mnuModelOtherGeneral"
        Me.mnuModelOtherGeneral.Size = New System.Drawing.Size(201, 22)
        Me.mnuModelOtherGeneral.Tag = "Other_(General)"
        Me.mnuModelOtherGeneral.Text = "Other (General)"
        '
        'mnuModelOtherGeneralANOVAGeneral
        '
        Me.mnuModelOtherGeneralANOVAGeneral.Enabled = False
        Me.mnuModelOtherGeneralANOVAGeneral.Name = "mnuModelOtherGeneralANOVAGeneral"
        Me.mnuModelOtherGeneralANOVAGeneral.Size = New System.Drawing.Size(166, 22)
        Me.mnuModelOtherGeneralANOVAGeneral.Tag = "ANOVA_General..."
        Me.mnuModelOtherGeneralANOVAGeneral.Text = "ANOVA General..."
        '
        'mnuModelOtherGeneralRegression
        '
        Me.mnuModelOtherGeneralRegression.Enabled = False
        Me.mnuModelOtherGeneralRegression.Name = "mnuModelOtherGeneralRegression"
        Me.mnuModelOtherGeneralRegression.Size = New System.Drawing.Size(166, 22)
        Me.mnuModelOtherGeneralRegression.Tag = "Regression..."
        Me.mnuModelOtherGeneralRegression.Text = "Regression..."
        '
        'mnuModelOtherGeneralLogLinear
        '
        Me.mnuModelOtherGeneralLogLinear.Enabled = False
        Me.mnuModelOtherGeneralLogLinear.Name = "mnuModelOtherGeneralLogLinear"
        Me.mnuModelOtherGeneralLogLinear.Size = New System.Drawing.Size(166, 22)
        Me.mnuModelOtherGeneralLogLinear.Tag = "Log_Linear"
        Me.mnuModelOtherGeneralLogLinear.Text = "Log Linear..."
        '
        'mnuClimaticExamine
        '
        Me.mnuClimaticExamine.Enabled = False
        Me.mnuClimaticExamine.Name = "mnuClimaticExamine"
        Me.mnuClimaticExamine.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticExamine.Tag = "Examine"
        Me.mnuClimaticExamine.Text = "Examine..."
        Me.mnuClimaticExamine.Visible = False
        '
        'mnuClimaticProcess
        '
        Me.mnuClimaticProcess.Enabled = False
        Me.mnuClimaticProcess.Name = "mnuClimaticProcess"
        Me.mnuClimaticProcess.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticProcess.Tag = "Process"
        Me.mnuClimaticProcess.Text = "Process..."
        Me.mnuClimaticProcess.Visible = False
        '
        'mnuClimaticEvaporation
        '
        Me.mnuClimaticEvaporation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticEvaporationSite, Me.mnuClimaticEvaporationPenman})
        Me.mnuClimaticEvaporation.Name = "mnuClimaticEvaporation"
        Me.mnuClimaticEvaporation.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticEvaporation.Tag = "Evaporation"
        Me.mnuClimaticEvaporation.Text = "Evaporation"
        Me.mnuClimaticEvaporation.Visible = False
        '
        'mnuClimaticEvaporationSite
        '
        Me.mnuClimaticEvaporationSite.Enabled = False
        Me.mnuClimaticEvaporationSite.Name = "mnuClimaticEvaporationSite"
        Me.mnuClimaticEvaporationSite.Size = New System.Drawing.Size(127, 22)
        Me.mnuClimaticEvaporationSite.Tag = "Site"
        Me.mnuClimaticEvaporationSite.Text = "Site..."
        '
        'mnuClimaticEvaporationPenman
        '
        Me.mnuClimaticEvaporationPenman.Enabled = False
        Me.mnuClimaticEvaporationPenman.Name = "mnuClimaticEvaporationPenman"
        Me.mnuClimaticEvaporationPenman.Size = New System.Drawing.Size(127, 22)
        Me.mnuClimaticEvaporationPenman.Tag = "Penman"
        Me.mnuClimaticEvaporationPenman.Text = "Penman..."
        '
        'mnuClimaticCrop
        '
        Me.mnuClimaticCrop.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticCropCropCoefficients, Me.mnuClimaticCropWaterSatisfactionIndex})
        Me.mnuClimaticCrop.Name = "mnuClimaticCrop"
        Me.mnuClimaticCrop.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticCrop.Tag = "Crop"
        Me.mnuClimaticCrop.Text = "Crop"
        Me.mnuClimaticCrop.Visible = False
        '
        'mnuClimaticCropCropCoefficients
        '
        Me.mnuClimaticCropCropCoefficients.Enabled = False
        Me.mnuClimaticCropCropCoefficients.Name = "mnuClimaticCropCropCoefficients"
        Me.mnuClimaticCropCropCoefficients.Size = New System.Drawing.Size(210, 22)
        Me.mnuClimaticCropCropCoefficients.Text = "Crop Coefficients..."
        '
        'mnuClimaticCropWaterSatisfactionIndex
        '
        Me.mnuClimaticCropWaterSatisfactionIndex.Enabled = False
        Me.mnuClimaticCropWaterSatisfactionIndex.Name = "mnuClimaticCropWaterSatisfactionIndex"
        Me.mnuClimaticCropWaterSatisfactionIndex.Size = New System.Drawing.Size(210, 22)
        Me.mnuClimaticCropWaterSatisfactionIndex.Text = "Water Satisfaction Index..."
        '
        'mnuClimaticHeatSum
        '
        Me.mnuClimaticHeatSum.Enabled = False
        Me.mnuClimaticHeatSum.Name = "mnuClimaticHeatSum"
        Me.mnuClimaticHeatSum.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticHeatSum.Tag = "Heat_Sum"
        Me.mnuClimaticHeatSum.Text = "Heat Sum..."
        Me.mnuClimaticHeatSum.Visible = False
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewDataView, Me.mnuViewOutputWindow, Me.mnuViewLog, Me.mnuViewScriptWindow, Me.mnuViewColumnMetadata, Me.mnuViewDataFrameMetadata, Me.ToolStripSeparator22, Me.mnuViewStructuredMenu, Me.mnuViewClimaticMenu, Me.mnuViewProcurementMenu, Me.mnuViewOptionsByContextMenu, Me.ToolStripSeparator39, Me.mnuViewResetToDefaultLayout, Me.mnuViewSwapDataAndMetadata})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 20)
        Me.mnuView.Tag = "View"
        Me.mnuView.Text = "View"
        '
        'mnuViewDataView
        '
        Me.mnuViewDataView.Name = "mnuViewDataView"
        Me.mnuViewDataView.Size = New System.Drawing.Size(211, 22)
        Me.mnuViewDataView.Tag = "Data_View"
        Me.mnuViewDataView.Text = "Data View"
        '
        'mnuViewOutputWindow
        '
        Me.mnuViewOutputWindow.Name = "mnuViewOutputWindow"
        Me.mnuViewOutputWindow.Size = New System.Drawing.Size(211, 22)
        Me.mnuViewOutputWindow.Text = "Output Window"
        '
        'mnuViewLog
        '
        Me.mnuViewLog.Name = "mnuViewLog"
        Me.mnuViewLog.Size = New System.Drawing.Size(211, 22)
        Me.mnuViewLog.Tag = "Log"
        Me.mnuViewLog.Text = "Log Window"
        '
        'mnuViewScriptWindow
        '
        Me.mnuViewScriptWindow.Name = "mnuViewScriptWindow"
        Me.mnuViewScriptWindow.Size = New System.Drawing.Size(211, 22)
        Me.mnuViewScriptWindow.Tag = "Script_Window"
        Me.mnuViewScriptWindow.Text = "Script Window"
        '
        'mnuViewColumnMetadata
        '
        Me.mnuViewColumnMetadata.Name = "mnuViewColumnMetadata"
        Me.mnuViewColumnMetadata.Size = New System.Drawing.Size(211, 22)
        Me.mnuViewColumnMetadata.Tag = "Column_Metadata"
        Me.mnuViewColumnMetadata.Text = "Column Metadata"
        '
        'mnuViewDataFrameMetadata
        '
        Me.mnuViewDataFrameMetadata.Name = "mnuViewDataFrameMetadata"
        Me.mnuViewDataFrameMetadata.Size = New System.Drawing.Size(211, 22)
        Me.mnuViewDataFrameMetadata.Tag = "Data_Frame_Metadata"
        Me.mnuViewDataFrameMetadata.Text = "Data Frame Metadata"
        '
        'ToolStripSeparator22
        '
        Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
        Me.ToolStripSeparator22.Size = New System.Drawing.Size(208, 6)
        '
        'mnuViewStructuredMenu
        '
        Me.mnuViewStructuredMenu.Name = "mnuViewStructuredMenu"
        Me.mnuViewStructuredMenu.Size = New System.Drawing.Size(211, 22)
        Me.mnuViewStructuredMenu.Text = "Structured Menu"
        '
        'mnuViewClimaticMenu
        '
        Me.mnuViewClimaticMenu.Name = "mnuViewClimaticMenu"
        Me.mnuViewClimaticMenu.Size = New System.Drawing.Size(211, 22)
        Me.mnuViewClimaticMenu.Tag = ""
        Me.mnuViewClimaticMenu.Text = "Climatic Menu"
        '
        'mnuViewProcurementMenu
        '
        Me.mnuViewProcurementMenu.Name = "mnuViewProcurementMenu"
        Me.mnuViewProcurementMenu.Size = New System.Drawing.Size(211, 22)
        Me.mnuViewProcurementMenu.Tag = ""
        Me.mnuViewProcurementMenu.Text = "Procurement Menu"
        '
        'mnuViewOptionsByContextMenu
        '
        Me.mnuViewOptionsByContextMenu.Name = "mnuViewOptionsByContextMenu"
        Me.mnuViewOptionsByContextMenu.Size = New System.Drawing.Size(211, 22)
        Me.mnuViewOptionsByContextMenu.Text = "Options by Context Menu"
        '
        'ToolStripSeparator39
        '
        Me.ToolStripSeparator39.Name = "ToolStripSeparator39"
        Me.ToolStripSeparator39.Size = New System.Drawing.Size(208, 6)
        '
        'mnuViewResetToDefaultLayout
        '
        Me.mnuViewResetToDefaultLayout.Name = "mnuViewResetToDefaultLayout"
        Me.mnuViewResetToDefaultLayout.Size = New System.Drawing.Size(211, 22)
        Me.mnuViewResetToDefaultLayout.Text = "Reset to Default Layout"
        '
        'mnuViewSwapDataAndMetadata
        '
        Me.mnuViewSwapDataAndMetadata.Name = "mnuViewSwapDataAndMetadata"
        Me.mnuViewSwapDataAndMetadata.Size = New System.Drawing.Size(211, 22)
        Me.mnuViewSwapDataAndMetadata.Text = "Swap Data and Metadata"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpHelpIntroduction, Me.mnuHelpHistFAQ, Me.mnuHelpGetingStarted, Me.ToolStripSeparator28, Me.mnuHelpWindows, Me.mnuHelpDataViewSpreadsheet, Me.mnuHelpMenus, Me.mnuHelpAboutR, Me.mnuHelpRPackagesCommands, Me.mnuHelpDataset, Me.ToolStripSeparator29, Me.mnuHelpGuide, Me.mnuHelpAboutRInstat, Me.mnuHelpLicence, Me.mnuHelpAcknowledgments})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Tag = "Help"
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpHelpIntroduction
        '
        Me.mnuHelpHelpIntroduction.Name = "mnuHelpHelpIntroduction"
        Me.mnuHelpHelpIntroduction.Size = New System.Drawing.Size(230, 22)
        Me.mnuHelpHelpIntroduction.Text = "Introduction"
        '
        'mnuHelpHistFAQ
        '
        Me.mnuHelpHistFAQ.Name = "mnuHelpHistFAQ"
        Me.mnuHelpHistFAQ.Size = New System.Drawing.Size(230, 22)
        Me.mnuHelpHistFAQ.Text = "History and FAQ"
        '
        'mnuHelpGetingStarted
        '
        Me.mnuHelpGetingStarted.Name = "mnuHelpGetingStarted"
        Me.mnuHelpGetingStarted.Size = New System.Drawing.Size(230, 22)
        Me.mnuHelpGetingStarted.Text = "Getting Started"
        '
        'ToolStripSeparator28
        '
        Me.ToolStripSeparator28.Name = "ToolStripSeparator28"
        Me.ToolStripSeparator28.Size = New System.Drawing.Size(227, 6)
        '
        'mnuHelpWindows
        '
        Me.mnuHelpWindows.Name = "mnuHelpWindows"
        Me.mnuHelpWindows.Size = New System.Drawing.Size(230, 22)
        Me.mnuHelpWindows.Text = "Windows"
        '
        'mnuHelpDataViewSpreadsheet
        '
        Me.mnuHelpDataViewSpreadsheet.Name = "mnuHelpDataViewSpreadsheet"
        Me.mnuHelpDataViewSpreadsheet.Size = New System.Drawing.Size(230, 22)
        Me.mnuHelpDataViewSpreadsheet.Text = "Data View (Spreadsheet)"
        '
        'mnuHelpMenus
        '
        Me.mnuHelpMenus.Name = "mnuHelpMenus"
        Me.mnuHelpMenus.Size = New System.Drawing.Size(230, 22)
        Me.mnuHelpMenus.Text = "Menus and Dialogs"
        '
        'mnuHelpAboutR
        '
        Me.mnuHelpAboutR.Name = "mnuHelpAboutR"
        Me.mnuHelpAboutR.Size = New System.Drawing.Size(230, 22)
        Me.mnuHelpAboutR.Text = "About R"
        '
        'mnuHelpRPackagesCommands
        '
        Me.mnuHelpRPackagesCommands.Name = "mnuHelpRPackagesCommands"
        Me.mnuHelpRPackagesCommands.Size = New System.Drawing.Size(230, 22)
        Me.mnuHelpRPackagesCommands.Text = "R Packages and Commands..."
        '
        'mnuHelpDataset
        '
        Me.mnuHelpDataset.Name = "mnuHelpDataset"
        Me.mnuHelpDataset.Size = New System.Drawing.Size(230, 22)
        Me.mnuHelpDataset.Text = "Datasets"
        '
        'ToolStripSeparator29
        '
        Me.ToolStripSeparator29.Name = "ToolStripSeparator29"
        Me.ToolStripSeparator29.Size = New System.Drawing.Size(227, 6)
        '
        'mnuHelpGuide
        '
        Me.mnuHelpGuide.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpGuidesCaseStudy, Me.mnuHelpGuideGlosary, Me.mnuhelpGuidesMore})
        Me.mnuHelpGuide.Name = "mnuHelpGuide"
        Me.mnuHelpGuide.Size = New System.Drawing.Size(230, 22)
        Me.mnuHelpGuide.Text = "Guides"
        '
        'mnuHelpGuidesCaseStudy
        '
        Me.mnuHelpGuidesCaseStudy.Name = "mnuHelpGuidesCaseStudy"
        Me.mnuHelpGuidesCaseStudy.Size = New System.Drawing.Size(166, 22)
        Me.mnuHelpGuidesCaseStudy.Text = "Case Study Guide"
        '
        'mnuHelpGuideGlosary
        '
        Me.mnuHelpGuideGlosary.Name = "mnuHelpGuideGlosary"
        Me.mnuHelpGuideGlosary.Size = New System.Drawing.Size(166, 22)
        Me.mnuHelpGuideGlosary.Text = "Glossary"
        '
        'mnuhelpGuidesMore
        '
        Me.mnuhelpGuidesMore.Enabled = False
        Me.mnuhelpGuidesMore.Name = "mnuhelpGuidesMore"
        Me.mnuhelpGuidesMore.Size = New System.Drawing.Size(166, 22)
        Me.mnuhelpGuidesMore.Text = "More..."
        '
        'mnuHelpAboutRInstat
        '
        Me.mnuHelpAboutRInstat.Enabled = False
        Me.mnuHelpAboutRInstat.Name = "mnuHelpAboutRInstat"
        Me.mnuHelpAboutRInstat.Size = New System.Drawing.Size(230, 22)
        Me.mnuHelpAboutRInstat.Tag = "About_R-Instat"
        Me.mnuHelpAboutRInstat.Text = "About R-Instat"
        '
        'mnuHelpLicence
        '
        Me.mnuHelpLicence.Name = "mnuHelpLicence"
        Me.mnuHelpLicence.Size = New System.Drawing.Size(230, 22)
        Me.mnuHelpLicence.Tag = "Licence..."
        Me.mnuHelpLicence.Text = "Licence..."
        '
        'mnuHelpAcknowledgments
        '
        Me.mnuHelpAcknowledgments.Name = "mnuHelpAcknowledgments"
        Me.mnuHelpAcknowledgments.Size = New System.Drawing.Size(230, 22)
        Me.mnuHelpAcknowledgments.Text = "Acknowledgements"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(209, 6)
        '
        'mnuClimatic
        '
        Me.mnuClimatic.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticFile, Me.ToolStripSeparator18, Me.mnuClimaticTidyandExamine, Me.mnuClimaticDates, Me.mnuClimaticDefineClimaticData, Me.mnuClimaticCheckData, Me.mnuClimaticPrepare, Me.ToolStripSeparator30, Me.mnuClimaticDescribe, Me.mnuClimaticNCMP, Me.mnuClimaticPICSA, Me.mnuCMSAF, Me.mnuClimaticCompare, Me.mnuClimaticMapping, Me.ToolStripSeparator16, Me.mnuClimaticModel, Me.mnuClimaticExamine, Me.mnuClimaticProcess, Me.ToolStripSeparator23, Me.mnuClimaticSCF, Me.mnuClimaticEvaporation, Me.mnuClimaticCrop, Me.mnuClimaticHeatSum, Me.mnuClimaticClimateMethods})
        Me.mnuClimatic.Name = "mnuClimatic"
        Me.mnuClimatic.Size = New System.Drawing.Size(63, 20)
        Me.mnuClimatic.Tag = "Climatic"
        Me.mnuClimatic.Text = "Climatic"
        '
        'mnuClimaticFile
        '
        Me.mnuClimaticFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticFileImportSST, Me.mnuClimaticFileImportfromIRIDataLibrary, Me.mnuClimaticFileImportfromClimateDataStore, Me.mnuClimaticFileImportandTidyNetCDF, Me.mnuClimaticFileImportandTidyShapefile, Me.ToolStripSeparator20, Me.mnuClimateFileImportfromClimSoft, Me.mnuClimateFileImportfromClimSoftWizard, Me.mnuClimaticFileImportfromCliData, Me.ToolStripSeparator15, Me.mnuClimaticFileExportToClimsoft, Me.mnuClimaticFileExportToCPT, Me.mnuExportToWWRToolStrip})
        Me.mnuClimaticFile.Name = "mnuClimaticFile"
        Me.mnuClimaticFile.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticFile.Text = "File"
        '
        'mnuClimaticFileImportSST
        '
        Me.mnuClimaticFileImportSST.Name = "mnuClimaticFileImportSST"
        Me.mnuClimaticFileImportSST.Size = New System.Drawing.Size(282, 22)
        Me.mnuClimaticFileImportSST.Text = "Import SST..."
        '
        'mnuClimaticFileImportfromIRIDataLibrary
        '
        Me.mnuClimaticFileImportfromIRIDataLibrary.Name = "mnuClimaticFileImportfromIRIDataLibrary"
        Me.mnuClimaticFileImportfromIRIDataLibrary.Size = New System.Drawing.Size(282, 22)
        Me.mnuClimaticFileImportfromIRIDataLibrary.Text = "Import from IRI Data Library..."
        '
        'mnuClimaticFileImportfromClimateDataStore
        '
        Me.mnuClimaticFileImportfromClimateDataStore.Name = "mnuClimaticFileImportfromClimateDataStore"
        Me.mnuClimaticFileImportfromClimateDataStore.Size = New System.Drawing.Size(282, 22)
        Me.mnuClimaticFileImportfromClimateDataStore.Text = "Import from CDS (Climate Data Store)..."
        '
        'mnuClimaticFileImportandTidyNetCDF
        '
        Me.mnuClimaticFileImportandTidyNetCDF.Name = "mnuClimaticFileImportandTidyNetCDF"
        Me.mnuClimaticFileImportandTidyNetCDF.Size = New System.Drawing.Size(282, 22)
        Me.mnuClimaticFileImportandTidyNetCDF.Text = "Import and Tidy NetCDF..."
        '
        'mnuClimaticFileImportandTidyShapefile
        '
        Me.mnuClimaticFileImportandTidyShapefile.Name = "mnuClimaticFileImportandTidyShapefile"
        Me.mnuClimaticFileImportandTidyShapefile.Size = New System.Drawing.Size(282, 22)
        Me.mnuClimaticFileImportandTidyShapefile.Text = "Import and Tidy Shapefile..."
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(279, 6)
        '
        'mnuClimateFileImportfromClimSoft
        '
        Me.mnuClimateFileImportfromClimSoft.Name = "mnuClimateFileImportfromClimSoft"
        Me.mnuClimateFileImportfromClimSoft.Size = New System.Drawing.Size(282, 22)
        Me.mnuClimateFileImportfromClimSoft.Text = "Import from Climsoft..."
        '
        'mnuClimateFileImportfromClimSoftWizard
        '
        Me.mnuClimateFileImportfromClimSoftWizard.Name = "mnuClimateFileImportfromClimSoftWizard"
        Me.mnuClimateFileImportfromClimSoftWizard.Size = New System.Drawing.Size(282, 22)
        Me.mnuClimateFileImportfromClimSoftWizard.Text = "Import from Climsoft Wizard..."
        '
        'mnuClimaticFileImportfromCliData
        '
        Me.mnuClimaticFileImportfromCliData.Enabled = False
        Me.mnuClimaticFileImportfromCliData.Name = "mnuClimaticFileImportfromCliData"
        Me.mnuClimaticFileImportfromCliData.Size = New System.Drawing.Size(282, 22)
        Me.mnuClimaticFileImportfromCliData.Text = "Import from CLIDATA..."
        Me.mnuClimaticFileImportfromCliData.Visible = False
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(279, 6)
        '
        'mnuClimaticFileExportToClimsoft
        '
        Me.mnuClimaticFileExportToClimsoft.Enabled = False
        Me.mnuClimaticFileExportToClimsoft.Name = "mnuClimaticFileExportToClimsoft"
        Me.mnuClimaticFileExportToClimsoft.Size = New System.Drawing.Size(282, 22)
        Me.mnuClimaticFileExportToClimsoft.Text = "Export to Climsoft..."
        Me.mnuClimaticFileExportToClimsoft.Visible = False
        '
        'mnuClimaticFileExportToCPT
        '
        Me.mnuClimaticFileExportToCPT.Name = "mnuClimaticFileExportToCPT"
        Me.mnuClimaticFileExportToCPT.Size = New System.Drawing.Size(282, 22)
        Me.mnuClimaticFileExportToCPT.Tag = "Export_to_CPT"
        Me.mnuClimaticFileExportToCPT.Text = "Export to CPT..."
        '
        'mnuExportToWWRToolStrip
        '
        Me.mnuExportToWWRToolStrip.Name = "mnuExportToWWRToolStrip"
        Me.mnuExportToWWRToolStrip.Size = New System.Drawing.Size(282, 22)
        Me.mnuExportToWWRToolStrip.Text = "Export to World Weather Records..."
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(209, 6)
        '
        'mnuClimaticTidyandExamine
        '
        Me.mnuClimaticTidyandExamine.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticTidyandExamineVisualiseData, Me.mnuClimaticTidyandExamineTidyDailyData, Me.mnuClimaticTidyandExamineNonNumericCases, Me.mnuClimaticTidyandExamineReplaceValues, Me.mnuClimaticTidyandExamineDuplicates, Me.ToolStripSeparator54, Me.mnuClimaticTidyandExamineStack, Me.mnuClimaticTidyandExamineUnstack, Me.mnuClimaticTidyandExamineMerge, Me.mnuClimaticTidyandExamineAppend, Me.ToolStripSeparator69, Me.mnuSetupForDataEntry, Me.mnuTidyandExamineClimaticDataEntry, Me.mnuClimaticTidyandExamineCompareColumns, Me.ToolStripSeparator50, Me.mnuClimaticTidyandExamineOneVariableSummarize, Me.mnuClimaticTidyandExamineOneVariableGraph, Me.mnuClimaticTidyandExamineOneVariableFrequencies})
        Me.mnuClimaticTidyandExamine.Name = "mnuClimaticTidyandExamine"
        Me.mnuClimaticTidyandExamine.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticTidyandExamine.Text = "Tidy and Examine"
        '
        'mnuClimaticTidyandExamineVisualiseData
        '
        Me.mnuClimaticTidyandExamineVisualiseData.Name = "mnuClimaticTidyandExamineVisualiseData"
        Me.mnuClimaticTidyandExamineVisualiseData.Size = New System.Drawing.Size(215, 22)
        Me.mnuClimaticTidyandExamineVisualiseData.Text = "Visualise Data..."
        '
        'mnuClimaticTidyandExamineTidyDailyData
        '
        Me.mnuClimaticTidyandExamineTidyDailyData.Name = "mnuClimaticTidyandExamineTidyDailyData"
        Me.mnuClimaticTidyandExamineTidyDailyData.Size = New System.Drawing.Size(215, 22)
        Me.mnuClimaticTidyandExamineTidyDailyData.Text = "Tidy Daily Data..."
        '
        'mnuClimaticTidyandExamineNonNumericCases
        '
        Me.mnuClimaticTidyandExamineNonNumericCases.Name = "mnuClimaticTidyandExamineNonNumericCases"
        Me.mnuClimaticTidyandExamineNonNumericCases.Size = New System.Drawing.Size(215, 22)
        Me.mnuClimaticTidyandExamineNonNumericCases.Text = "Non-Numeric Values..."
        '
        'mnuClimaticTidyandExamineReplaceValues
        '
        Me.mnuClimaticTidyandExamineReplaceValues.Name = "mnuClimaticTidyandExamineReplaceValues"
        Me.mnuClimaticTidyandExamineReplaceValues.Size = New System.Drawing.Size(215, 22)
        Me.mnuClimaticTidyandExamineReplaceValues.Text = "Replace Values..."
        '
        'mnuClimaticTidyandExamineDuplicates
        '
        Me.mnuClimaticTidyandExamineDuplicates.Name = "mnuClimaticTidyandExamineDuplicates"
        Me.mnuClimaticTidyandExamineDuplicates.Size = New System.Drawing.Size(215, 22)
        Me.mnuClimaticTidyandExamineDuplicates.Text = "Duplicates..."
        '
        'ToolStripSeparator54
        '
        Me.ToolStripSeparator54.Name = "ToolStripSeparator54"
        Me.ToolStripSeparator54.Size = New System.Drawing.Size(212, 6)
        '
        'mnuClimaticTidyandExamineStack
        '
        Me.mnuClimaticTidyandExamineStack.Name = "mnuClimaticTidyandExamineStack"
        Me.mnuClimaticTidyandExamineStack.Size = New System.Drawing.Size(215, 22)
        Me.mnuClimaticTidyandExamineStack.Text = "Stack (Pivot Longer)..."
        '
        'mnuClimaticTidyandExamineUnstack
        '
        Me.mnuClimaticTidyandExamineUnstack.Name = "mnuClimaticTidyandExamineUnstack"
        Me.mnuClimaticTidyandExamineUnstack.Size = New System.Drawing.Size(215, 22)
        Me.mnuClimaticTidyandExamineUnstack.Text = "Unstack (Pivot Wider)..."
        '
        'mnuClimaticTidyandExamineMerge
        '
        Me.mnuClimaticTidyandExamineMerge.Name = "mnuClimaticTidyandExamineMerge"
        Me.mnuClimaticTidyandExamineMerge.Size = New System.Drawing.Size(215, 22)
        Me.mnuClimaticTidyandExamineMerge.Text = "Merge..."
        '
        'mnuClimaticTidyandExamineAppend
        '
        Me.mnuClimaticTidyandExamineAppend.Name = "mnuClimaticTidyandExamineAppend"
        Me.mnuClimaticTidyandExamineAppend.Size = New System.Drawing.Size(215, 22)
        Me.mnuClimaticTidyandExamineAppend.Text = "Append (Bind Rows)..."
        '
        'ToolStripSeparator69
        '
        Me.ToolStripSeparator69.Name = "ToolStripSeparator69"
        Me.ToolStripSeparator69.Size = New System.Drawing.Size(212, 6)
        '
        'mnuSetupForDataEntry
        '
        Me.mnuSetupForDataEntry.Name = "mnuSetupForDataEntry"
        Me.mnuSetupForDataEntry.Size = New System.Drawing.Size(215, 22)
        Me.mnuSetupForDataEntry.Text = "Setup for Data Entry..."
        '
        'mnuTidyandExamineClimaticDataEntry
        '
        Me.mnuTidyandExamineClimaticDataEntry.Name = "mnuTidyandExamineClimaticDataEntry"
        Me.mnuTidyandExamineClimaticDataEntry.Size = New System.Drawing.Size(215, 22)
        Me.mnuTidyandExamineClimaticDataEntry.Text = "Daily Data Entry..."
        '
        'mnuClimaticTidyandExamineCompareColumns
        '
        Me.mnuClimaticTidyandExamineCompareColumns.Name = "mnuClimaticTidyandExamineCompareColumns"
        Me.mnuClimaticTidyandExamineCompareColumns.Size = New System.Drawing.Size(215, 22)
        Me.mnuClimaticTidyandExamineCompareColumns.Text = "Compare Columns..."
        '
        'ToolStripSeparator50
        '
        Me.ToolStripSeparator50.Name = "ToolStripSeparator50"
        Me.ToolStripSeparator50.Size = New System.Drawing.Size(212, 6)
        '
        'mnuClimaticTidyandExamineOneVariableSummarize
        '
        Me.mnuClimaticTidyandExamineOneVariableSummarize.Name = "mnuClimaticTidyandExamineOneVariableSummarize"
        Me.mnuClimaticTidyandExamineOneVariableSummarize.Size = New System.Drawing.Size(215, 22)
        Me.mnuClimaticTidyandExamineOneVariableSummarize.Text = "One Variable Summarise..."
        '
        'mnuClimaticTidyandExamineOneVariableGraph
        '
        Me.mnuClimaticTidyandExamineOneVariableGraph.Name = "mnuClimaticTidyandExamineOneVariableGraph"
        Me.mnuClimaticTidyandExamineOneVariableGraph.Size = New System.Drawing.Size(215, 22)
        Me.mnuClimaticTidyandExamineOneVariableGraph.Text = "One Variable Graph..."
        '
        'mnuClimaticTidyandExamineOneVariableFrequencies
        '
        Me.mnuClimaticTidyandExamineOneVariableFrequencies.Name = "mnuClimaticTidyandExamineOneVariableFrequencies"
        Me.mnuClimaticTidyandExamineOneVariableFrequencies.Size = New System.Drawing.Size(215, 22)
        Me.mnuClimaticTidyandExamineOneVariableFrequencies.Text = "One Variable Frequencies..."
        '
        'mnuClimaticDates
        '
        Me.mnuClimaticDates.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticDatesGenerateDates, Me.mnuClimaticDatesMakeDate, Me.mnuClimaticDatesInfillMissingDates, Me.mnuClimaticDatesUseDate, Me.mnuClimaticDatesMakeTime, Me.mnuClimaticDatesUseTime})
        Me.mnuClimaticDates.Name = "mnuClimaticDates"
        Me.mnuClimaticDates.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticDates.Text = "Dates"
        '
        'mnuClimaticDatesGenerateDates
        '
        Me.mnuClimaticDatesGenerateDates.Name = "mnuClimaticDatesGenerateDates"
        Me.mnuClimaticDatesGenerateDates.Size = New System.Drawing.Size(162, 22)
        Me.mnuClimaticDatesGenerateDates.Text = "Generate Dates..."
        '
        'mnuClimaticDatesMakeDate
        '
        Me.mnuClimaticDatesMakeDate.Name = "mnuClimaticDatesMakeDate"
        Me.mnuClimaticDatesMakeDate.Size = New System.Drawing.Size(162, 22)
        Me.mnuClimaticDatesMakeDate.Text = "Make Date..."
        '
        'mnuClimaticDatesInfillMissingDates
        '
        Me.mnuClimaticDatesInfillMissingDates.Name = "mnuClimaticDatesInfillMissingDates"
        Me.mnuClimaticDatesInfillMissingDates.Size = New System.Drawing.Size(162, 22)
        Me.mnuClimaticDatesInfillMissingDates.Text = "Fill Date Gaps..."
        '
        'mnuClimaticDatesUseDate
        '
        Me.mnuClimaticDatesUseDate.Name = "mnuClimaticDatesUseDate"
        Me.mnuClimaticDatesUseDate.Size = New System.Drawing.Size(162, 22)
        Me.mnuClimaticDatesUseDate.Text = "Use Date..."
        '
        'mnuClimaticDatesMakeTime
        '
        Me.mnuClimaticDatesMakeTime.Enabled = False
        Me.mnuClimaticDatesMakeTime.Name = "mnuClimaticDatesMakeTime"
        Me.mnuClimaticDatesMakeTime.Size = New System.Drawing.Size(162, 22)
        Me.mnuClimaticDatesMakeTime.Text = "Make Time..."
        Me.mnuClimaticDatesMakeTime.Visible = False
        '
        'mnuClimaticDatesUseTime
        '
        Me.mnuClimaticDatesUseTime.Enabled = False
        Me.mnuClimaticDatesUseTime.Name = "mnuClimaticDatesUseTime"
        Me.mnuClimaticDatesUseTime.Size = New System.Drawing.Size(162, 22)
        Me.mnuClimaticDatesUseTime.Text = "Use Time..."
        Me.mnuClimaticDatesUseTime.Visible = False
        '
        'mnuClimaticDefineClimaticData
        '
        Me.mnuClimaticDefineClimaticData.Name = "mnuClimaticDefineClimaticData"
        Me.mnuClimaticDefineClimaticData.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticDefineClimaticData.Text = "Define Climatic Data..."
        '
        'mnuClimaticCheckData
        '
        Me.mnuClimaticCheckData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticCheckDataInventory, Me.mnuClimaticCheckDataDisplayDaily, Me.ToolStripSeparator65, Me.mnuClimaticCheckDataFillMissingValues, Me.mnuClimaticCheckDataBoxplot, Me.mnuClimaticCheckDataQCTemperatures, Me.mnuClimaticCheckDataQCRainfall, Me.ToolStripSeparator70, Me.mnuClimaticCheckDataHomogenization, Me.mnuClimaticCheckDataCheckStationLocations})
        Me.mnuClimaticCheckData.Name = "mnuClimaticCheckData"
        Me.mnuClimaticCheckData.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticCheckData.Text = "Check Data"
        '
        'mnuClimaticCheckDataInventory
        '
        Me.mnuClimaticCheckDataInventory.Name = "mnuClimaticCheckDataInventory"
        Me.mnuClimaticCheckDataInventory.Size = New System.Drawing.Size(210, 22)
        Me.mnuClimaticCheckDataInventory.Text = "Inventory..."
        '
        'mnuClimaticCheckDataDisplayDaily
        '
        Me.mnuClimaticCheckDataDisplayDaily.Name = "mnuClimaticCheckDataDisplayDaily"
        Me.mnuClimaticCheckDataDisplayDaily.Size = New System.Drawing.Size(210, 22)
        Me.mnuClimaticCheckDataDisplayDaily.Text = "Display Daily..."
        '
        'ToolStripSeparator65
        '
        Me.ToolStripSeparator65.Name = "ToolStripSeparator65"
        Me.ToolStripSeparator65.Size = New System.Drawing.Size(207, 6)
        '
        'mnuClimaticCheckDataFillMissingValues
        '
        Me.mnuClimaticCheckDataFillMissingValues.Name = "mnuClimaticCheckDataFillMissingValues"
        Me.mnuClimaticCheckDataFillMissingValues.Size = New System.Drawing.Size(210, 22)
        Me.mnuClimaticCheckDataFillMissingValues.Text = "Fill Missing Values..."
        '
        'mnuClimaticCheckDataBoxplot
        '
        Me.mnuClimaticCheckDataBoxplot.Name = "mnuClimaticCheckDataBoxplot"
        Me.mnuClimaticCheckDataBoxplot.Size = New System.Drawing.Size(210, 22)
        Me.mnuClimaticCheckDataBoxplot.Text = "Boxplot..."
        '
        'mnuClimaticCheckDataQCTemperatures
        '
        Me.mnuClimaticCheckDataQCTemperatures.Name = "mnuClimaticCheckDataQCTemperatures"
        Me.mnuClimaticCheckDataQCTemperatures.Size = New System.Drawing.Size(210, 22)
        Me.mnuClimaticCheckDataQCTemperatures.Text = "QC Temperatures..."
        '
        'mnuClimaticCheckDataQCRainfall
        '
        Me.mnuClimaticCheckDataQCRainfall.Name = "mnuClimaticCheckDataQCRainfall"
        Me.mnuClimaticCheckDataQCRainfall.Size = New System.Drawing.Size(210, 22)
        Me.mnuClimaticCheckDataQCRainfall.Text = "QC Rainfall..."
        '
        'ToolStripSeparator70
        '
        Me.ToolStripSeparator70.Name = "ToolStripSeparator70"
        Me.ToolStripSeparator70.Size = New System.Drawing.Size(207, 6)
        '
        'mnuClimaticCheckDataHomogenization
        '
        Me.mnuClimaticCheckDataHomogenization.Name = "mnuClimaticCheckDataHomogenization"
        Me.mnuClimaticCheckDataHomogenization.Size = New System.Drawing.Size(210, 22)
        Me.mnuClimaticCheckDataHomogenization.Text = "Homogenization..."
        '
        'mnuClimaticCheckDataCheckStationLocations
        '
        Me.mnuClimaticCheckDataCheckStationLocations.Name = "mnuClimaticCheckDataCheckStationLocations"
        Me.mnuClimaticCheckDataCheckStationLocations.Size = New System.Drawing.Size(210, 22)
        Me.mnuClimaticCheckDataCheckStationLocations.Text = "Check Station Locations..."
        '
        'mnuClimaticPrepare
        '
        Me.mnuClimaticPrepare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCimaticPrepareTransform, Me.mnuClimaticPrepareConversions, Me.ToolStripSeparator37, Me.mnuClimaticPrepareClimaticSummaries, Me.mnuClimaticPrepareStartoftheRains, Me.mnuClimaticPrepareEndOfRains, Me.mnuClimaticPrepareLengthOfSeason, Me.mnuClimaticPrepareSpells, Me.mnuClimaticPrepareExtremes, Me.ToolStripSeparator64, Me.mnuClimaticPrepareClimdex, Me.mnuClimaticPrepareSPI, Me.ToolStripSeparator51, Me.mnuClimaticPrepareEvapotranspiration, Me.mnuClimaticPrepareSummary, Me.mnuClimaticPrepareNewWorksheet, Me.mnuClimaticPrepareImportDailyData, Me.mnuClimaticPrepareMakeFactor, Me.mnuClimaticPrepareShiftDailyData, Me.mnuClimaticPrepareUnstackDailyData, Me.mnuClimaticPrepareStackDailyData})
        Me.mnuClimaticPrepare.Name = "mnuClimaticPrepare"
        Me.mnuClimaticPrepare.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticPrepare.Tag = "Prepare"
        Me.mnuClimaticPrepare.Text = "Prepare"
        '
        'mnuCimaticPrepareTransform
        '
        Me.mnuCimaticPrepareTransform.Name = "mnuCimaticPrepareTransform"
        Me.mnuCimaticPrepareTransform.Size = New System.Drawing.Size(189, 22)
        Me.mnuCimaticPrepareTransform.Text = "Transform..."
        '
        'mnuClimaticPrepareConversions
        '
        Me.mnuClimaticPrepareConversions.Name = "mnuClimaticPrepareConversions"
        Me.mnuClimaticPrepareConversions.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareConversions.Text = "Conversions..."
        '
        'ToolStripSeparator37
        '
        Me.ToolStripSeparator37.Name = "ToolStripSeparator37"
        Me.ToolStripSeparator37.Size = New System.Drawing.Size(186, 6)
        '
        'mnuClimaticPrepareClimaticSummaries
        '
        Me.mnuClimaticPrepareClimaticSummaries.Name = "mnuClimaticPrepareClimaticSummaries"
        Me.mnuClimaticPrepareClimaticSummaries.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareClimaticSummaries.Text = "Climatic Summaries..."
        '
        'mnuClimaticPrepareStartoftheRains
        '
        Me.mnuClimaticPrepareStartoftheRains.Name = "mnuClimaticPrepareStartoftheRains"
        Me.mnuClimaticPrepareStartoftheRains.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareStartoftheRains.Text = "Start of the Rains..."
        '
        'mnuClimaticPrepareEndOfRains
        '
        Me.mnuClimaticPrepareEndOfRains.Name = "mnuClimaticPrepareEndOfRains"
        Me.mnuClimaticPrepareEndOfRains.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareEndOfRains.Text = "End of Rains..."
        '
        'mnuClimaticPrepareLengthOfSeason
        '
        Me.mnuClimaticPrepareLengthOfSeason.Name = "mnuClimaticPrepareLengthOfSeason"
        Me.mnuClimaticPrepareLengthOfSeason.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareLengthOfSeason.Text = "Length of Season..."
        '
        'mnuClimaticPrepareSpells
        '
        Me.mnuClimaticPrepareSpells.Name = "mnuClimaticPrepareSpells"
        Me.mnuClimaticPrepareSpells.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareSpells.Text = "Spells..."
        '
        'mnuClimaticPrepareExtremes
        '
        Me.mnuClimaticPrepareExtremes.Name = "mnuClimaticPrepareExtremes"
        Me.mnuClimaticPrepareExtremes.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareExtremes.Text = "Extremes..."
        '
        'ToolStripSeparator64
        '
        Me.ToolStripSeparator64.Name = "ToolStripSeparator64"
        Me.ToolStripSeparator64.Size = New System.Drawing.Size(186, 6)
        '
        'mnuClimaticPrepareClimdex
        '
        Me.mnuClimaticPrepareClimdex.Name = "mnuClimaticPrepareClimdex"
        Me.mnuClimaticPrepareClimdex.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareClimdex.Text = "Climdex..."
        '
        'mnuClimaticPrepareSPI
        '
        Me.mnuClimaticPrepareSPI.Name = "mnuClimaticPrepareSPI"
        Me.mnuClimaticPrepareSPI.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareSPI.Text = "SPI/SPEI..."
        '
        'ToolStripSeparator51
        '
        Me.ToolStripSeparator51.Name = "ToolStripSeparator51"
        Me.ToolStripSeparator51.Size = New System.Drawing.Size(186, 6)
        '
        'mnuClimaticPrepareEvapotranspiration
        '
        Me.mnuClimaticPrepareEvapotranspiration.Name = "mnuClimaticPrepareEvapotranspiration"
        Me.mnuClimaticPrepareEvapotranspiration.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareEvapotranspiration.Text = "Evapotranspiration..."
        '
        'mnuClimaticPrepareSummary
        '
        Me.mnuClimaticPrepareSummary.Enabled = False
        Me.mnuClimaticPrepareSummary.Name = "mnuClimaticPrepareSummary"
        Me.mnuClimaticPrepareSummary.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareSummary.Text = "Summary..."
        Me.mnuClimaticPrepareSummary.Visible = False
        '
        'mnuClimaticPrepareNewWorksheet
        '
        Me.mnuClimaticPrepareNewWorksheet.Enabled = False
        Me.mnuClimaticPrepareNewWorksheet.Name = "mnuClimaticPrepareNewWorksheet"
        Me.mnuClimaticPrepareNewWorksheet.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareNewWorksheet.Tag = "New_Worksheet"
        Me.mnuClimaticPrepareNewWorksheet.Text = "New Worksheet..."
        Me.mnuClimaticPrepareNewWorksheet.Visible = False
        '
        'mnuClimaticPrepareImportDailyData
        '
        Me.mnuClimaticPrepareImportDailyData.Enabled = False
        Me.mnuClimaticPrepareImportDailyData.Name = "mnuClimaticPrepareImportDailyData"
        Me.mnuClimaticPrepareImportDailyData.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareImportDailyData.Tag = "Import_daily_data"
        Me.mnuClimaticPrepareImportDailyData.Text = "Import daily Data..."
        Me.mnuClimaticPrepareImportDailyData.Visible = False
        '
        'mnuClimaticPrepareMakeFactor
        '
        Me.mnuClimaticPrepareMakeFactor.Enabled = False
        Me.mnuClimaticPrepareMakeFactor.Name = "mnuClimaticPrepareMakeFactor"
        Me.mnuClimaticPrepareMakeFactor.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareMakeFactor.Tag = "Make_Factor"
        Me.mnuClimaticPrepareMakeFactor.Text = "Make Factor..."
        Me.mnuClimaticPrepareMakeFactor.Visible = False
        '
        'mnuClimaticPrepareShiftDailyData
        '
        Me.mnuClimaticPrepareShiftDailyData.Enabled = False
        Me.mnuClimaticPrepareShiftDailyData.Name = "mnuClimaticPrepareShiftDailyData"
        Me.mnuClimaticPrepareShiftDailyData.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareShiftDailyData.Tag = "Shift_Daily_data"
        Me.mnuClimaticPrepareShiftDailyData.Text = "Shift Daily Data..."
        Me.mnuClimaticPrepareShiftDailyData.Visible = False
        '
        'mnuClimaticPrepareUnstackDailyData
        '
        Me.mnuClimaticPrepareUnstackDailyData.Enabled = False
        Me.mnuClimaticPrepareUnstackDailyData.Name = "mnuClimaticPrepareUnstackDailyData"
        Me.mnuClimaticPrepareUnstackDailyData.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareUnstackDailyData.Tag = "Unstack_Daily_data"
        Me.mnuClimaticPrepareUnstackDailyData.Text = "Unstack Daily Data..."
        Me.mnuClimaticPrepareUnstackDailyData.Visible = False
        '
        'mnuClimaticPrepareStackDailyData
        '
        Me.mnuClimaticPrepareStackDailyData.Enabled = False
        Me.mnuClimaticPrepareStackDailyData.Name = "mnuClimaticPrepareStackDailyData"
        Me.mnuClimaticPrepareStackDailyData.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareStackDailyData.Tag = "Stack_Daily_data"
        Me.mnuClimaticPrepareStackDailyData.Text = "Stack Daily data..."
        Me.mnuClimaticPrepareStackDailyData.Visible = False
        '
        'ToolStripSeparator30
        '
        Me.ToolStripSeparator30.Name = "ToolStripSeparator30"
        Me.ToolStripSeparator30.Size = New System.Drawing.Size(209, 6)
        '
        'mnuClimaticDescribe
        '
        Me.mnuClimaticDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticDescribeRainfall, Me.mnuClimaticDescribeTemperatures, Me.mnuClimaticDescribeWindSpeedDirection, Me.mnuClimaticDescribeSunshineRadiation, Me.ToolStripSeparator17, Me.mnuClimaticDescribeGeneral, Me.ToolStripSeparator31})
        Me.mnuClimaticDescribe.Name = "mnuClimaticDescribe"
        Me.mnuClimaticDescribe.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticDescribe.Text = "Describe"
        '
        'mnuClimaticDescribeRainfall
        '
        Me.mnuClimaticDescribeRainfall.Enabled = False
        Me.mnuClimaticDescribeRainfall.Name = "mnuClimaticDescribeRainfall"
        Me.mnuClimaticDescribeRainfall.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimaticDescribeRainfall.Text = "Rainfall..."
        '
        'mnuClimaticDescribeTemperatures
        '
        Me.mnuClimaticDescribeTemperatures.Enabled = False
        Me.mnuClimaticDescribeTemperatures.Name = "mnuClimaticDescribeTemperatures"
        Me.mnuClimaticDescribeTemperatures.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimaticDescribeTemperatures.Text = "Temperature..."
        '
        'mnuClimaticDescribeWindSpeedDirection
        '
        Me.mnuClimaticDescribeWindSpeedDirection.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticDescribeWindSpeedDirectionWindRose})
        Me.mnuClimaticDescribeWindSpeedDirection.Name = "mnuClimaticDescribeWindSpeedDirection"
        Me.mnuClimaticDescribeWindSpeedDirection.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimaticDescribeWindSpeedDirection.Text = "Wind Speed/Direction..."
        '
        'mnuClimaticDescribeWindSpeedDirectionWindRose
        '
        Me.mnuClimaticDescribeWindSpeedDirectionWindRose.Name = "mnuClimaticDescribeWindSpeedDirectionWindRose"
        Me.mnuClimaticDescribeWindSpeedDirectionWindRose.Size = New System.Drawing.Size(139, 22)
        Me.mnuClimaticDescribeWindSpeedDirectionWindRose.Text = "Wind Rose..."
        '
        'mnuClimaticDescribeSunshineRadiation
        '
        Me.mnuClimaticDescribeSunshineRadiation.Enabled = False
        Me.mnuClimaticDescribeSunshineRadiation.Name = "mnuClimaticDescribeSunshineRadiation"
        Me.mnuClimaticDescribeSunshineRadiation.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimaticDescribeSunshineRadiation.Text = "Sunshine/Radiation..."
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(196, 6)
        '
        'mnuClimaticDescribeGeneral
        '
        Me.mnuClimaticDescribeGeneral.Enabled = False
        Me.mnuClimaticDescribeGeneral.Name = "mnuClimaticDescribeGeneral"
        Me.mnuClimaticDescribeGeneral.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimaticDescribeGeneral.Text = "General"
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(196, 6)
        '
        'mnuClimaticNCMP
        '
        Me.mnuClimaticNCMP.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticNCMPIndices, Me.mnuClimaticNCMPVariogram, Me.mnuClimaticNCMPRegionAverage, Me.mnuClimaticNCMPTrendGraphs, Me.mnuClimaticNCMPCountRecords, Me.mnuClimaticNCMPSummary})
        Me.mnuClimaticNCMP.Name = "mnuClimaticNCMP"
        Me.mnuClimaticNCMP.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticNCMP.Text = "NCMP"
        '
        'mnuClimaticNCMPIndices
        '
        Me.mnuClimaticNCMPIndices.Name = "mnuClimaticNCMPIndices"
        Me.mnuClimaticNCMPIndices.Size = New System.Drawing.Size(166, 22)
        Me.mnuClimaticNCMPIndices.Text = "Indices..."
        '
        'mnuClimaticNCMPVariogram
        '
        Me.mnuClimaticNCMPVariogram.Name = "mnuClimaticNCMPVariogram"
        Me.mnuClimaticNCMPVariogram.Size = New System.Drawing.Size(166, 22)
        Me.mnuClimaticNCMPVariogram.Text = "Variogram..."
        '
        'mnuClimaticNCMPRegionAverage
        '
        Me.mnuClimaticNCMPRegionAverage.Name = "mnuClimaticNCMPRegionAverage"
        Me.mnuClimaticNCMPRegionAverage.Size = New System.Drawing.Size(166, 22)
        Me.mnuClimaticNCMPRegionAverage.Text = "Region Average..."
        '
        'mnuClimaticNCMPTrendGraphs
        '
        Me.mnuClimaticNCMPTrendGraphs.Name = "mnuClimaticNCMPTrendGraphs"
        Me.mnuClimaticNCMPTrendGraphs.Size = New System.Drawing.Size(166, 22)
        Me.mnuClimaticNCMPTrendGraphs.Text = "Trend Graphs..."
        '
        'mnuClimaticNCMPCountRecords
        '
        Me.mnuClimaticNCMPCountRecords.Name = "mnuClimaticNCMPCountRecords"
        Me.mnuClimaticNCMPCountRecords.Size = New System.Drawing.Size(166, 22)
        Me.mnuClimaticNCMPCountRecords.Text = "Count Records..."
        '
        'mnuClimaticNCMPSummary
        '
        Me.mnuClimaticNCMPSummary.Name = "mnuClimaticNCMPSummary"
        Me.mnuClimaticNCMPSummary.Size = New System.Drawing.Size(166, 22)
        Me.mnuClimaticNCMPSummary.Text = "Summary..."
        '
        'mnuClimaticPICSA
        '
        Me.mnuClimaticPICSA.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticPICSARainfall, Me.mnuClimaticPICSACumExeedenceGraph, Me.mnuClimaticPICSATemperature, Me.mnuClimaticPICSACrops})
        Me.mnuClimaticPICSA.Name = "mnuClimaticPICSA"
        Me.mnuClimaticPICSA.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticPICSA.Text = "PICSA"
        '
        'mnuClimaticPICSARainfall
        '
        Me.mnuClimaticPICSARainfall.Name = "mnuClimaticPICSARainfall"
        Me.mnuClimaticPICSARainfall.Size = New System.Drawing.Size(246, 22)
        Me.mnuClimaticPICSARainfall.Text = "Rainfall Graph..."
        '
        'mnuClimaticPICSACumExeedenceGraph
        '
        Me.mnuClimaticPICSACumExeedenceGraph.Name = "mnuClimaticPICSACumExeedenceGraph"
        Me.mnuClimaticPICSACumExeedenceGraph.Size = New System.Drawing.Size(246, 22)
        Me.mnuClimaticPICSACumExeedenceGraph.Text = "Cumulative/Exceedance Graph..."
        '
        'mnuClimaticPICSATemperature
        '
        Me.mnuClimaticPICSATemperature.Enabled = False
        Me.mnuClimaticPICSATemperature.Name = "mnuClimaticPICSATemperature"
        Me.mnuClimaticPICSATemperature.Size = New System.Drawing.Size(246, 22)
        Me.mnuClimaticPICSATemperature.Text = "Temperature..."
        '
        'mnuClimaticPICSACrops
        '
        Me.mnuClimaticPICSACrops.Name = "mnuClimaticPICSACrops"
        Me.mnuClimaticPICSACrops.Size = New System.Drawing.Size(246, 22)
        Me.mnuClimaticPICSACrops.Text = "Crops..."
        '
        'mnuCMSAF
        '
        Me.mnuCMSAF.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticCMSAFPlotRegion, Me.mnuClimaticCMSAFExporttoCMSAFRToolbox})
        Me.mnuCMSAF.Name = "mnuCMSAF"
        Me.mnuCMSAF.Size = New System.Drawing.Size(212, 22)
        Me.mnuCMSAF.Text = "CM SAF"
        '
        'mnuClimaticCMSAFPlotRegion
        '
        Me.mnuClimaticCMSAFPlotRegion.Name = "mnuClimaticCMSAFPlotRegion"
        Me.mnuClimaticCMSAFPlotRegion.Size = New System.Drawing.Size(231, 22)
        Me.mnuClimaticCMSAFPlotRegion.Text = "Plot Region..."
        '
        'mnuClimaticCMSAFExporttoCMSAFRToolbox
        '
        Me.mnuClimaticCMSAFExporttoCMSAFRToolbox.Name = "mnuClimaticCMSAFExporttoCMSAFRToolbox"
        Me.mnuClimaticCMSAFExporttoCMSAFRToolbox.Size = New System.Drawing.Size(231, 22)
        Me.mnuClimaticCMSAFExporttoCMSAFRToolbox.Text = "Export to CM SAF R Toolbox..."
        '
        'mnuClimaticCompare
        '
        Me.mnuClimaticCompare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticCompareCalculation, Me.mnuClimaticCompareSummary, Me.ToolStripSeparator66, Me.mnuClimaticCompareCorrelations, Me.mnuClimaticCompareScatterplot, Me.mnuClimaticCompareTimeSeriesPlot, Me.mnuClimaticCompareSeasonalPlot, Me.mnuClimaticCompareDensityPlot, Me.mnuClimaticCompareConditionalQuantiles, Me.mnuClimaticCompareTaylorDiagram})
        Me.mnuClimaticCompare.Name = "mnuClimaticCompare"
        Me.mnuClimaticCompare.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticCompare.Text = "Compare"
        '
        'mnuClimaticCompareCalculation
        '
        Me.mnuClimaticCompareCalculation.Name = "mnuClimaticCompareCalculation"
        Me.mnuClimaticCompareCalculation.Size = New System.Drawing.Size(198, 22)
        Me.mnuClimaticCompareCalculation.Text = "Calculation..."
        '
        'mnuClimaticCompareSummary
        '
        Me.mnuClimaticCompareSummary.Name = "mnuClimaticCompareSummary"
        Me.mnuClimaticCompareSummary.Size = New System.Drawing.Size(198, 22)
        Me.mnuClimaticCompareSummary.Text = "Summary..."
        '
        'ToolStripSeparator66
        '
        Me.ToolStripSeparator66.Name = "ToolStripSeparator66"
        Me.ToolStripSeparator66.Size = New System.Drawing.Size(195, 6)
        '
        'mnuClimaticCompareCorrelations
        '
        Me.mnuClimaticCompareCorrelations.Name = "mnuClimaticCompareCorrelations"
        Me.mnuClimaticCompareCorrelations.Size = New System.Drawing.Size(198, 22)
        Me.mnuClimaticCompareCorrelations.Text = "Correlations..."
        '
        'mnuClimaticCompareScatterplot
        '
        Me.mnuClimaticCompareScatterplot.Name = "mnuClimaticCompareScatterplot"
        Me.mnuClimaticCompareScatterplot.Size = New System.Drawing.Size(198, 22)
        Me.mnuClimaticCompareScatterplot.Text = "Scatterplot..."
        '
        'mnuClimaticCompareTimeSeriesPlot
        '
        Me.mnuClimaticCompareTimeSeriesPlot.Name = "mnuClimaticCompareTimeSeriesPlot"
        Me.mnuClimaticCompareTimeSeriesPlot.Size = New System.Drawing.Size(198, 22)
        Me.mnuClimaticCompareTimeSeriesPlot.Text = "Time Series Plot..."
        '
        'mnuClimaticCompareSeasonalPlot
        '
        Me.mnuClimaticCompareSeasonalPlot.Name = "mnuClimaticCompareSeasonalPlot"
        Me.mnuClimaticCompareSeasonalPlot.Size = New System.Drawing.Size(198, 22)
        Me.mnuClimaticCompareSeasonalPlot.Text = "Seasonal Plot..."
        '
        'mnuClimaticCompareDensityPlot
        '
        Me.mnuClimaticCompareDensityPlot.Name = "mnuClimaticCompareDensityPlot"
        Me.mnuClimaticCompareDensityPlot.Size = New System.Drawing.Size(198, 22)
        Me.mnuClimaticCompareDensityPlot.Text = "Density Plot..."
        '
        'mnuClimaticCompareConditionalQuantiles
        '
        Me.mnuClimaticCompareConditionalQuantiles.Name = "mnuClimaticCompareConditionalQuantiles"
        Me.mnuClimaticCompareConditionalQuantiles.Size = New System.Drawing.Size(198, 22)
        Me.mnuClimaticCompareConditionalQuantiles.Text = "Conditional Quantiles..."
        '
        'mnuClimaticCompareTaylorDiagram
        '
        Me.mnuClimaticCompareTaylorDiagram.Name = "mnuClimaticCompareTaylorDiagram"
        Me.mnuClimaticCompareTaylorDiagram.Size = New System.Drawing.Size(198, 22)
        Me.mnuClimaticCompareTaylorDiagram.Text = "Taylor Diagram..."
        '
        'mnuClimaticMapping
        '
        Me.mnuClimaticMapping.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticMappingMap, Me.mnuClimaticMappingCheckStationLocations})
        Me.mnuClimaticMapping.Name = "mnuClimaticMapping"
        Me.mnuClimaticMapping.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticMapping.Text = "Mapping"
        '
        'mnuClimaticMappingMap
        '
        Me.mnuClimaticMappingMap.Name = "mnuClimaticMappingMap"
        Me.mnuClimaticMappingMap.Size = New System.Drawing.Size(210, 22)
        Me.mnuClimaticMappingMap.Text = "Map..."
        '
        'mnuClimaticMappingCheckStationLocations
        '
        Me.mnuClimaticMappingCheckStationLocations.Name = "mnuClimaticMappingCheckStationLocations"
        Me.mnuClimaticMappingCheckStationLocations.Size = New System.Drawing.Size(210, 22)
        Me.mnuClimaticMappingCheckStationLocations.Text = "Check Station Locations..."
        '
        'mnuClimaticModel
        '
        Me.mnuClimaticModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticModelsExtremes, Me.mnuClimaticModelCircular, Me.mnuClimaticModelMarkovModelling})
        Me.mnuClimaticModel.Name = "mnuClimaticModel"
        Me.mnuClimaticModel.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticModel.Text = "Model"
        '
        'mnuClimaticModelsExtremes
        '
        Me.mnuClimaticModelsExtremes.Name = "mnuClimaticModelsExtremes"
        Me.mnuClimaticModelsExtremes.Size = New System.Drawing.Size(180, 22)
        Me.mnuClimaticModelsExtremes.Text = "Extremes..."
        '
        'mnuClimaticModelCircular
        '
        Me.mnuClimaticModelCircular.Enabled = False
        Me.mnuClimaticModelCircular.Name = "mnuClimaticModelCircular"
        Me.mnuClimaticModelCircular.Size = New System.Drawing.Size(180, 22)
        Me.mnuClimaticModelCircular.Text = "Circular..."
        Me.mnuClimaticModelCircular.Visible = False
        '
        'mnuClimaticModelMarkovModelling
        '
        Me.mnuClimaticModelMarkovModelling.Name = "mnuClimaticModelMarkovModelling"
        Me.mnuClimaticModelMarkovModelling.Size = New System.Drawing.Size(180, 22)
        Me.mnuClimaticModelMarkovModelling.Tag = "Markov_Modelling"
        Me.mnuClimaticModelMarkovModelling.Text = "Markov Modelling..."
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        Me.ToolStripSeparator23.Size = New System.Drawing.Size(209, 6)
        '
        'mnuClimaticSCF
        '
        Me.mnuClimaticSCF.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticSCFSupportOpenSST, Me.mnuClimaticSCFSupportExporttoCPT, Me.ToolStripSeparator32, Me.mnuClimaticSCFSupportCorrelations, Me.mnuClimaticSCFSupportPrincipalComponents, Me.mnuClimaticSCFSupportCanonicalCorrelations, Me.mnuClimaticSCFSupportCumulativeExceedanceGraph})
        Me.mnuClimaticSCF.Name = "mnuClimaticSCF"
        Me.mnuClimaticSCF.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticSCF.Text = "Seasonal Forecast Support"
        '
        'mnuClimaticSCFSupportOpenSST
        '
        Me.mnuClimaticSCFSupportOpenSST.Name = "mnuClimaticSCFSupportOpenSST"
        Me.mnuClimaticSCFSupportOpenSST.Size = New System.Drawing.Size(246, 22)
        Me.mnuClimaticSCFSupportOpenSST.Text = "Open SST..."
        '
        'mnuClimaticSCFSupportExporttoCPT
        '
        Me.mnuClimaticSCFSupportExporttoCPT.Name = "mnuClimaticSCFSupportExporttoCPT"
        Me.mnuClimaticSCFSupportExporttoCPT.Size = New System.Drawing.Size(246, 22)
        Me.mnuClimaticSCFSupportExporttoCPT.Tag = "Export_to_CPT"
        Me.mnuClimaticSCFSupportExporttoCPT.Text = "Export to CPT..."
        '
        'ToolStripSeparator32
        '
        Me.ToolStripSeparator32.Name = "ToolStripSeparator32"
        Me.ToolStripSeparator32.Size = New System.Drawing.Size(243, 6)
        '
        'mnuClimaticSCFSupportCorrelations
        '
        Me.mnuClimaticSCFSupportCorrelations.Name = "mnuClimaticSCFSupportCorrelations"
        Me.mnuClimaticSCFSupportCorrelations.Size = New System.Drawing.Size(246, 22)
        Me.mnuClimaticSCFSupportCorrelations.Text = "Correlations..."
        '
        'mnuClimaticSCFSupportPrincipalComponents
        '
        Me.mnuClimaticSCFSupportPrincipalComponents.Name = "mnuClimaticSCFSupportPrincipalComponents"
        Me.mnuClimaticSCFSupportPrincipalComponents.Size = New System.Drawing.Size(246, 22)
        Me.mnuClimaticSCFSupportPrincipalComponents.Text = "Principal Components..."
        '
        'mnuClimaticSCFSupportCanonicalCorrelations
        '
        Me.mnuClimaticSCFSupportCanonicalCorrelations.Name = "mnuClimaticSCFSupportCanonicalCorrelations"
        Me.mnuClimaticSCFSupportCanonicalCorrelations.Size = New System.Drawing.Size(246, 22)
        Me.mnuClimaticSCFSupportCanonicalCorrelations.Text = "Canonical Correlations..."
        '
        'mnuClimaticSCFSupportCumulativeExceedanceGraph
        '
        Me.mnuClimaticSCFSupportCumulativeExceedanceGraph.Name = "mnuClimaticSCFSupportCumulativeExceedanceGraph"
        Me.mnuClimaticSCFSupportCumulativeExceedanceGraph.Size = New System.Drawing.Size(246, 22)
        Me.mnuClimaticSCFSupportCumulativeExceedanceGraph.Text = "Cumulative/Exceedance Graph..."
        '
        'mnuClimaticClimateMethods
        '
        Me.mnuClimaticClimateMethods.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticClimateMethodsDataManipulation, Me.mnuClimaticClimateMethodsGraphics, Me.mnuClimaticClimateMethodsModel, Me.mnuClimaticClimateMethodsAdditional, Me.mnuClimateMethodsCreateClimateObject})
        Me.mnuClimaticClimateMethods.Name = "mnuClimaticClimateMethods"
        Me.mnuClimaticClimateMethods.Size = New System.Drawing.Size(212, 22)
        Me.mnuClimaticClimateMethods.Tag = "Climatic_Methods"
        Me.mnuClimaticClimateMethods.Text = "Climate Methods"
        Me.mnuClimaticClimateMethods.Visible = False
        '
        'mnuClimaticClimateMethodsDataManipulation
        '
        Me.mnuClimaticClimateMethodsDataManipulation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticClimateMethodsDataManipulationStartOfRain, Me.mnuClimaticClimateMethodsDataManipulationEndOfRain, Me.mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth, Me.mnuClimaticClimateMethodsDataManipulationExportCPTToTabular, Me.mnuClimaticClimateMethodsDataManipulationDayMonth, Me.mnuClimaticClimateMethodsDataManipulationDisplayDaily, Me.mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear, Me.mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal, Me.mnuClimaticClimateMethodsDataManipulationDisplaySpellLength, Me.mnuClimaticClimateMethodsDataManipulationExportForPICSA, Me.mnuClimaticClimateMethodsDataManipulationExtremeEvents, Me.mnuClimaticClimateMethodsDataManipulationMissingData, Me.mnuClimaticClimateMethodsDataManipulationMissingDataTable, Me.mnuClimateMethodsDataManipulationMonthlySummaries, Me.mnuClimateMethodsDataManipulationOutputForCD})
        Me.mnuClimaticClimateMethodsDataManipulation.Name = "mnuClimaticClimateMethodsDataManipulation"
        Me.mnuClimaticClimateMethodsDataManipulation.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimaticClimateMethodsDataManipulation.Tag = "Data_Manipulation"
        Me.mnuClimaticClimateMethodsDataManipulation.Text = "Data Manipulation"
        '
        'mnuClimaticClimateMethodsDataManipulationStartOfRain
        '
        Me.mnuClimaticClimateMethodsDataManipulationStartOfRain.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationStartOfRain.Name = "mnuClimaticClimateMethodsDataManipulationStartOfRain"
        Me.mnuClimaticClimateMethodsDataManipulationStartOfRain.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimaticClimateMethodsDataManipulationStartOfRain.Tag = "Start_of_Rain"
        Me.mnuClimaticClimateMethodsDataManipulationStartOfRain.Text = "Start of Rain..."
        '
        'mnuClimaticClimateMethodsDataManipulationEndOfRain
        '
        Me.mnuClimaticClimateMethodsDataManipulationEndOfRain.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationEndOfRain.Name = "mnuClimaticClimateMethodsDataManipulationEndOfRain"
        Me.mnuClimaticClimateMethodsDataManipulationEndOfRain.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimaticClimateMethodsDataManipulationEndOfRain.Tag = "End_of_Rain"
        Me.mnuClimaticClimateMethodsDataManipulationEndOfRain.Text = "End of Rain..."
        '
        'mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth
        '
        Me.mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth.Name = "mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth"
        Me.mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth.Tag = "Change_Format_Month"
        Me.mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth.Text = "Change Format Day Month..."
        '
        'mnuClimaticClimateMethodsDataManipulationExportCPTToTabular
        '
        Me.mnuClimaticClimateMethodsDataManipulationExportCPTToTabular.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationExportCPTToTabular.Name = "mnuClimaticClimateMethodsDataManipulationExportCPTToTabular"
        Me.mnuClimaticClimateMethodsDataManipulationExportCPTToTabular.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimaticClimateMethodsDataManipulationExportCPTToTabular.Tag = "Expot_CPT_to_Tabular"
        Me.mnuClimaticClimateMethodsDataManipulationExportCPTToTabular.Text = "Export CPT to Tabular..."
        '
        'mnuClimaticClimateMethodsDataManipulationDayMonth
        '
        Me.mnuClimaticClimateMethodsDataManipulationDayMonth.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationDayMonth.Name = "mnuClimaticClimateMethodsDataManipulationDayMonth"
        Me.mnuClimaticClimateMethodsDataManipulationDayMonth.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimaticClimateMethodsDataManipulationDayMonth.Tag = "Day_Month"
        Me.mnuClimaticClimateMethodsDataManipulationDayMonth.Text = "Day Month..."
        '
        'mnuClimaticClimateMethodsDataManipulationDisplayDaily
        '
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDaily.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDaily.Name = "mnuClimaticClimateMethodsDataManipulationDisplayDaily"
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDaily.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDaily.Tag = "Display_Daily"
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDaily.Text = "Display Daily..."
        '
        'mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear
        '
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear.Name = "mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear"
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear.Tag = "Display_DOY_of_Year"
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear.Text = "Display DOY of Year..."
        '
        'mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal
        '
        Me.mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal.Name = "mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal"
        Me.mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal.Tag = "Display_Rain_Running_Total"
        Me.mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal.Text = "Display Rain Running Total..."
        '
        'mnuClimaticClimateMethodsDataManipulationDisplaySpellLength
        '
        Me.mnuClimaticClimateMethodsDataManipulationDisplaySpellLength.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationDisplaySpellLength.Name = "mnuClimaticClimateMethodsDataManipulationDisplaySpellLength"
        Me.mnuClimaticClimateMethodsDataManipulationDisplaySpellLength.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimaticClimateMethodsDataManipulationDisplaySpellLength.Tag = "Display_Spell_length"
        Me.mnuClimaticClimateMethodsDataManipulationDisplaySpellLength.Text = "Display Spell Length..."
        '
        'mnuClimaticClimateMethodsDataManipulationExportForPICSA
        '
        Me.mnuClimaticClimateMethodsDataManipulationExportForPICSA.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationExportForPICSA.Name = "mnuClimaticClimateMethodsDataManipulationExportForPICSA"
        Me.mnuClimaticClimateMethodsDataManipulationExportForPICSA.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimaticClimateMethodsDataManipulationExportForPICSA.Tag = "Export_for_PICSA"
        Me.mnuClimaticClimateMethodsDataManipulationExportForPICSA.Text = "Export for PICSA..."
        '
        'mnuClimaticClimateMethodsDataManipulationExtremeEvents
        '
        Me.mnuClimaticClimateMethodsDataManipulationExtremeEvents.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationExtremeEvents.Name = "mnuClimaticClimateMethodsDataManipulationExtremeEvents"
        Me.mnuClimaticClimateMethodsDataManipulationExtremeEvents.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimaticClimateMethodsDataManipulationExtremeEvents.Tag = "Extreme_Events"
        Me.mnuClimaticClimateMethodsDataManipulationExtremeEvents.Text = "Extreme Events..."
        '
        'mnuClimaticClimateMethodsDataManipulationMissingData
        '
        Me.mnuClimaticClimateMethodsDataManipulationMissingData.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationMissingData.Name = "mnuClimaticClimateMethodsDataManipulationMissingData"
        Me.mnuClimaticClimateMethodsDataManipulationMissingData.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimaticClimateMethodsDataManipulationMissingData.Tag = "Missing_Data"
        Me.mnuClimaticClimateMethodsDataManipulationMissingData.Text = "Missing Data..."
        '
        'mnuClimaticClimateMethodsDataManipulationMissingDataTable
        '
        Me.mnuClimaticClimateMethodsDataManipulationMissingDataTable.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationMissingDataTable.Name = "mnuClimaticClimateMethodsDataManipulationMissingDataTable"
        Me.mnuClimaticClimateMethodsDataManipulationMissingDataTable.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimaticClimateMethodsDataManipulationMissingDataTable.Tag = "Missing_Data_Table"
        Me.mnuClimaticClimateMethodsDataManipulationMissingDataTable.Text = "Missing Data Table..."
        '
        'mnuClimateMethodsDataManipulationMonthlySummaries
        '
        Me.mnuClimateMethodsDataManipulationMonthlySummaries.Enabled = False
        Me.mnuClimateMethodsDataManipulationMonthlySummaries.Name = "mnuClimateMethodsDataManipulationMonthlySummaries"
        Me.mnuClimateMethodsDataManipulationMonthlySummaries.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimateMethodsDataManipulationMonthlySummaries.Tag = "Monthly_Summaries"
        Me.mnuClimateMethodsDataManipulationMonthlySummaries.Text = "Monthly Summaries..."
        '
        'mnuClimateMethodsDataManipulationOutputForCD
        '
        Me.mnuClimateMethodsDataManipulationOutputForCD.Enabled = False
        Me.mnuClimateMethodsDataManipulationOutputForCD.Name = "mnuClimateMethodsDataManipulationOutputForCD"
        Me.mnuClimateMethodsDataManipulationOutputForCD.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimateMethodsDataManipulationOutputForCD.Tag = "Output_for_CDT"
        Me.mnuClimateMethodsDataManipulationOutputForCD.Text = "Output for CDT..."
        '
        'mnuClimaticClimateMethodsGraphics
        '
        Me.mnuClimaticClimateMethodsGraphics.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticClimateMethodsGraphicsClipBoxPlot, Me.mnuClimaticClimateMethodsGraphicsCliplot, Me.mnuClimaticClimateMethodsGraphicsMissingValues, Me.mnuClimaticClimateMethodsGraphicsHistogram, Me.mnuClimaticClimateMethodsGraphicsCumExceedance, Me.mnuClimaticClimateMethodsGraphicsBoxplot, Me.mnuClimaticClimateMethodsGraphicsInventory, Me.mnuClimaticClimateMethodsGraphicsAnnualRainfall, Me.mnuClimaticClimateMethodsGraphicsRainCount, Me.mnuClimaticClimateMethodsGraphicsTimeseries, Me.mnuClimaticClimateMethodsGraphicsWindrose, Me.mnuClimateMethodsGraphicsMultipleLines, Me.mnuClmateMethodThreeSummaries})
        Me.mnuClimaticClimateMethodsGraphics.Name = "mnuClimaticClimateMethodsGraphics"
        Me.mnuClimaticClimateMethodsGraphics.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimaticClimateMethodsGraphics.Tag = "Graphics"
        Me.mnuClimaticClimateMethodsGraphics.Text = "Graphics"
        '
        'mnuClimaticClimateMethodsGraphicsClipBoxPlot
        '
        Me.mnuClimaticClimateMethodsGraphicsClipBoxPlot.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsClipBoxPlot.Name = "mnuClimaticClimateMethodsGraphicsClipBoxPlot"
        Me.mnuClimaticClimateMethodsGraphicsClipBoxPlot.Size = New System.Drawing.Size(220, 22)
        Me.mnuClimaticClimateMethodsGraphicsClipBoxPlot.Tag = "Cliboxplot"
        Me.mnuClimaticClimateMethodsGraphicsClipBoxPlot.Text = "Cliboxplot..."
        '
        'mnuClimaticClimateMethodsGraphicsCliplot
        '
        Me.mnuClimaticClimateMethodsGraphicsCliplot.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsCliplot.Name = "mnuClimaticClimateMethodsGraphicsCliplot"
        Me.mnuClimaticClimateMethodsGraphicsCliplot.Size = New System.Drawing.Size(220, 22)
        Me.mnuClimaticClimateMethodsGraphicsCliplot.Tag = "Cliplot"
        Me.mnuClimaticClimateMethodsGraphicsCliplot.Text = "Cliplot..."
        '
        'mnuClimaticClimateMethodsGraphicsMissingValues
        '
        Me.mnuClimaticClimateMethodsGraphicsMissingValues.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsMissingValues.Name = "mnuClimaticClimateMethodsGraphicsMissingValues"
        Me.mnuClimaticClimateMethodsGraphicsMissingValues.Size = New System.Drawing.Size(220, 22)
        Me.mnuClimaticClimateMethodsGraphicsMissingValues.Tag = "Missing_values"
        Me.mnuClimaticClimateMethodsGraphicsMissingValues.Text = "Missing Values..."
        '
        'mnuClimaticClimateMethodsGraphicsHistogram
        '
        Me.mnuClimaticClimateMethodsGraphicsHistogram.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsHistogram.Name = "mnuClimaticClimateMethodsGraphicsHistogram"
        Me.mnuClimaticClimateMethodsGraphicsHistogram.Size = New System.Drawing.Size(220, 22)
        Me.mnuClimaticClimateMethodsGraphicsHistogram.Tag = "Histogram"
        Me.mnuClimaticClimateMethodsGraphicsHistogram.Text = "Histogram..."
        '
        'mnuClimaticClimateMethodsGraphicsCumExceedance
        '
        Me.mnuClimaticClimateMethodsGraphicsCumExceedance.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsCumExceedance.Name = "mnuClimaticClimateMethodsGraphicsCumExceedance"
        Me.mnuClimaticClimateMethodsGraphicsCumExceedance.Size = New System.Drawing.Size(220, 22)
        Me.mnuClimaticClimateMethodsGraphicsCumExceedance.Tag = "Cumulative_Exceedence"
        Me.mnuClimaticClimateMethodsGraphicsCumExceedance.Text = "Cummulative Exceedance..."
        '
        'mnuClimaticClimateMethodsGraphicsBoxplot
        '
        Me.mnuClimaticClimateMethodsGraphicsBoxplot.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsBoxplot.Name = "mnuClimaticClimateMethodsGraphicsBoxplot"
        Me.mnuClimaticClimateMethodsGraphicsBoxplot.Size = New System.Drawing.Size(220, 22)
        Me.mnuClimaticClimateMethodsGraphicsBoxplot.Tag = "Boxplot"
        Me.mnuClimaticClimateMethodsGraphicsBoxplot.Text = "Boxplot..."
        '
        'mnuClimaticClimateMethodsGraphicsInventory
        '
        Me.mnuClimaticClimateMethodsGraphicsInventory.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsInventory.Name = "mnuClimaticClimateMethodsGraphicsInventory"
        Me.mnuClimaticClimateMethodsGraphicsInventory.Size = New System.Drawing.Size(220, 22)
        Me.mnuClimaticClimateMethodsGraphicsInventory.Tag = "Inventory"
        Me.mnuClimaticClimateMethodsGraphicsInventory.Text = "Inventory..."
        '
        'mnuClimaticClimateMethodsGraphicsAnnualRainfall
        '
        Me.mnuClimaticClimateMethodsGraphicsAnnualRainfall.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsAnnualRainfall.Name = "mnuClimaticClimateMethodsGraphicsAnnualRainfall"
        Me.mnuClimaticClimateMethodsGraphicsAnnualRainfall.Size = New System.Drawing.Size(220, 22)
        Me.mnuClimaticClimateMethodsGraphicsAnnualRainfall.Tag = "Annual_rainfall"
        Me.mnuClimaticClimateMethodsGraphicsAnnualRainfall.Text = "Annual Rainfall..."
        '
        'mnuClimaticClimateMethodsGraphicsRainCount
        '
        Me.mnuClimaticClimateMethodsGraphicsRainCount.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsRainCount.Name = "mnuClimaticClimateMethodsGraphicsRainCount"
        Me.mnuClimaticClimateMethodsGraphicsRainCount.Size = New System.Drawing.Size(220, 22)
        Me.mnuClimaticClimateMethodsGraphicsRainCount.Tag = "Rain_count"
        Me.mnuClimaticClimateMethodsGraphicsRainCount.Text = "Rain Count..."
        '
        'mnuClimaticClimateMethodsGraphicsTimeseries
        '
        Me.mnuClimaticClimateMethodsGraphicsTimeseries.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsTimeseries.Name = "mnuClimaticClimateMethodsGraphicsTimeseries"
        Me.mnuClimaticClimateMethodsGraphicsTimeseries.Size = New System.Drawing.Size(220, 22)
        Me.mnuClimaticClimateMethodsGraphicsTimeseries.Tag = "Timeseries"
        Me.mnuClimaticClimateMethodsGraphicsTimeseries.Text = "Timeseries..."
        '
        'mnuClimaticClimateMethodsGraphicsWindrose
        '
        Me.mnuClimaticClimateMethodsGraphicsWindrose.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsWindrose.Name = "mnuClimaticClimateMethodsGraphicsWindrose"
        Me.mnuClimaticClimateMethodsGraphicsWindrose.Size = New System.Drawing.Size(220, 22)
        Me.mnuClimaticClimateMethodsGraphicsWindrose.Tag = "Windrose"
        Me.mnuClimaticClimateMethodsGraphicsWindrose.Text = "Windrose..."
        '
        'mnuClimateMethodsGraphicsMultipleLines
        '
        Me.mnuClimateMethodsGraphicsMultipleLines.Enabled = False
        Me.mnuClimateMethodsGraphicsMultipleLines.Name = "mnuClimateMethodsGraphicsMultipleLines"
        Me.mnuClimateMethodsGraphicsMultipleLines.Size = New System.Drawing.Size(220, 22)
        Me.mnuClimateMethodsGraphicsMultipleLines.Tag = "Multiple_lines"
        Me.mnuClimateMethodsGraphicsMultipleLines.Text = "Multple Lines..."
        '
        'mnuClmateMethodThreeSummaries
        '
        Me.mnuClmateMethodThreeSummaries.Enabled = False
        Me.mnuClmateMethodThreeSummaries.Name = "mnuClmateMethodThreeSummaries"
        Me.mnuClmateMethodThreeSummaries.Size = New System.Drawing.Size(220, 22)
        Me.mnuClmateMethodThreeSummaries.Tag = "Three_Summaries"
        Me.mnuClmateMethodThreeSummaries.Text = "Three Summaries..."
        '
        'mnuClimaticClimateMethodsModel
        '
        Me.mnuClimaticClimateMethodsModel.Enabled = False
        Me.mnuClimaticClimateMethodsModel.Name = "mnuClimaticClimateMethodsModel"
        Me.mnuClimaticClimateMethodsModel.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimaticClimateMethodsModel.Tag = "Model"
        Me.mnuClimaticClimateMethodsModel.Text = "Model..."
        '
        'mnuClimaticClimateMethodsAdditional
        '
        Me.mnuClimaticClimateMethodsAdditional.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticClimateMethodsAdditionalOutputForCPT, Me.mnuClimaticClimateMethodsAdditionalRainsStatistics, Me.mnuClimaticClimateMethodsAdditionalSeasonalSummary, Me.mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain, Me.mnuClimaticClimateMethodsAdditionalWaterBalance})
        Me.mnuClimaticClimateMethodsAdditional.Name = "mnuClimaticClimateMethodsAdditional"
        Me.mnuClimaticClimateMethodsAdditional.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimaticClimateMethodsAdditional.Tag = "Additional"
        Me.mnuClimaticClimateMethodsAdditional.Text = "Additional"
        '
        'mnuClimaticClimateMethodsAdditionalOutputForCPT
        '
        Me.mnuClimaticClimateMethodsAdditionalOutputForCPT.Enabled = False
        Me.mnuClimaticClimateMethodsAdditionalOutputForCPT.Name = "mnuClimaticClimateMethodsAdditionalOutputForCPT"
        Me.mnuClimaticClimateMethodsAdditionalOutputForCPT.Size = New System.Drawing.Size(209, 22)
        Me.mnuClimaticClimateMethodsAdditionalOutputForCPT.Tag = "Output_for_CPT"
        Me.mnuClimaticClimateMethodsAdditionalOutputForCPT.Text = "Output for CPT..."
        '
        'mnuClimaticClimateMethodsAdditionalRainsStatistics
        '
        Me.mnuClimaticClimateMethodsAdditionalRainsStatistics.Enabled = False
        Me.mnuClimaticClimateMethodsAdditionalRainsStatistics.Name = "mnuClimaticClimateMethodsAdditionalRainsStatistics"
        Me.mnuClimaticClimateMethodsAdditionalRainsStatistics.Size = New System.Drawing.Size(209, 22)
        Me.mnuClimaticClimateMethodsAdditionalRainsStatistics.Tag = "Rain_Statistics"
        Me.mnuClimaticClimateMethodsAdditionalRainsStatistics.Text = "Rains Statistics..."
        '
        'mnuClimaticClimateMethodsAdditionalSeasonalSummary
        '
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummary.Enabled = False
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummary.Name = "mnuClimaticClimateMethodsAdditionalSeasonalSummary"
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummary.Size = New System.Drawing.Size(209, 22)
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummary.Tag = "Seasonal_Summary"
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummary.Text = "Seasonal Summary..."
        '
        'mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain
        '
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain.Enabled = False
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain.Name = "mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain"
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain.Size = New System.Drawing.Size(209, 22)
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain.Tag = "Seasonal_Summary_Rain"
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain.Text = "Seasonal Summary Rain..."
        '
        'mnuClimaticClimateMethodsAdditionalWaterBalance
        '
        Me.mnuClimaticClimateMethodsAdditionalWaterBalance.Enabled = False
        Me.mnuClimaticClimateMethodsAdditionalWaterBalance.Name = "mnuClimaticClimateMethodsAdditionalWaterBalance"
        Me.mnuClimaticClimateMethodsAdditionalWaterBalance.Size = New System.Drawing.Size(209, 22)
        Me.mnuClimaticClimateMethodsAdditionalWaterBalance.Tag = "Water_Balance"
        Me.mnuClimaticClimateMethodsAdditionalWaterBalance.Text = "Water Balance..."
        '
        'mnuClimateMethodsCreateClimateObject
        '
        Me.mnuClimateMethodsCreateClimateObject.Enabled = False
        Me.mnuClimateMethodsCreateClimateObject.Name = "mnuClimateMethodsCreateClimateObject"
        Me.mnuClimateMethodsCreateClimateObject.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimateMethodsCreateClimateObject.Tag = "Create_Climate_Object"
        Me.mnuClimateMethodsCreateClimateObject.Text = "Create Climate Object..."
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(232, 22)
        Me.mnuFileSave.Tag = "Save"
        Me.mnuFileSave.Text = "Save..."
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileSaveAsDataAs, Me.mnuFileSaveAsOutputAs, Me.mnuFileSaveAsLogAs, Me.mnuFileSaveAsScriptAs})
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(232, 22)
        Me.mnuFileSaveAs.Tag = "Save_As"
        Me.mnuFileSaveAs.Text = "Save As"
        '
        'mnuFileSaveAsDataAs
        '
        Me.mnuFileSaveAsDataAs.Name = "mnuFileSaveAsDataAs"
        Me.mnuFileSaveAsDataAs.Size = New System.Drawing.Size(164, 22)
        Me.mnuFileSaveAsDataAs.Text = "Save Data As..."
        '
        'mnuFileSaveAsOutputAs
        '
        Me.mnuFileSaveAsOutputAs.Name = "mnuFileSaveAsOutputAs"
        Me.mnuFileSaveAsOutputAs.Size = New System.Drawing.Size(164, 22)
        Me.mnuFileSaveAsOutputAs.Text = "Save Output As..."
        '
        'mnuFileSaveAsLogAs
        '
        Me.mnuFileSaveAsLogAs.Name = "mnuFileSaveAsLogAs"
        Me.mnuFileSaveAsLogAs.Size = New System.Drawing.Size(164, 22)
        Me.mnuFileSaveAsLogAs.Text = "Save Log As..."
        '
        'mnuFileSaveAsScriptAs
        '
        Me.mnuFileSaveAsScriptAs.Name = "mnuFileSaveAsScriptAs"
        Me.mnuFileSaveAsScriptAs.Size = New System.Drawing.Size(164, 22)
        Me.mnuFileSaveAsScriptAs.Text = "Save Script As..."
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.Enabled = False
        Me.mnuFilePrint.Name = "mnuFilePrint"
        Me.mnuFilePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuFilePrint.Size = New System.Drawing.Size(232, 22)
        Me.mnuFilePrint.Tag = "Print"
        Me.mnuFilePrint.Text = "Print..."
        Me.mnuFilePrint.Visible = False
        '
        'mnuFilePrintPreview
        '
        Me.mnuFilePrintPreview.Enabled = False
        Me.mnuFilePrintPreview.Name = "mnuFilePrintPreview"
        Me.mnuFilePrintPreview.Size = New System.Drawing.Size(232, 22)
        Me.mnuFilePrintPreview.Tag = "Print_Preview"
        Me.mnuFilePrintPreview.Text = "Print Preview..."
        Me.mnuFilePrintPreview.Visible = False
        '
        'tlSeparatorFile3
        '
        Me.tlSeparatorFile3.Name = "tlSeparatorFile3"
        Me.tlSeparatorFile3.Size = New System.Drawing.Size(229, 6)
        '
        'mnuFIleExit
        '
        Me.mnuFIleExit.Name = "mnuFIleExit"
        Me.mnuFIleExit.Size = New System.Drawing.Size(232, 22)
        Me.mnuFIleExit.Tag = "Exit"
        Me.mnuFIleExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditFind, Me.mnuEditFindNext, Me.mnuEditReplace, Me.mnuEditCut, Me.mnuEditCopy, Me.mnuEditCopySpecial, Me.mnuEditPaste, Me.mnuPasteSpecial, Me.mnuEditPasteNewDataFrame, Me.mnuEditSelectAll, Me.ToolStripSeparator71, Me.mnuEditScript})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Tag = "Edit"
        Me.mnuEdit.Text = "Edit"
        '
        'mnuEditFind
        '
        Me.mnuEditFind.Enabled = False
        Me.mnuEditFind.Name = "mnuEditFind"
        Me.mnuEditFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuEditFind.Size = New System.Drawing.Size(207, 22)
        Me.mnuEditFind.Tag = "Find"
        Me.mnuEditFind.Text = "Find"
        '
        'mnuEditFindNext
        '
        Me.mnuEditFindNext.Enabled = False
        Me.mnuEditFindNext.Name = "mnuEditFindNext"
        Me.mnuEditFindNext.Size = New System.Drawing.Size(207, 22)
        Me.mnuEditFindNext.Text = "Find Next"
        '
        'mnuEditReplace
        '
        Me.mnuEditReplace.Enabled = False
        Me.mnuEditReplace.Name = "mnuEditReplace"
        Me.mnuEditReplace.Size = New System.Drawing.Size(207, 22)
        Me.mnuEditReplace.Tag = "Replace"
        Me.mnuEditReplace.Text = "Replace"
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Enabled = False
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(207, 22)
        Me.mnuEditCut.Tag = "Cut"
        Me.mnuEditCut.Text = "Cut"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(207, 22)
        Me.mnuEditCopy.Tag = "Copy"
        Me.mnuEditCopy.Text = "Copy"
        '
        'mnuEditCopySpecial
        '
        Me.mnuEditCopySpecial.Name = "mnuEditCopySpecial"
        Me.mnuEditCopySpecial.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopySpecial.Size = New System.Drawing.Size(207, 22)
        Me.mnuEditCopySpecial.Tag = "Copy_Special"
        Me.mnuEditCopySpecial.Text = "Copy Special"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(207, 22)
        Me.mnuEditPaste.Tag = "Paste"
        Me.mnuEditPaste.Text = "Paste"
        '
        'mnuPasteSpecial
        '
        Me.mnuPasteSpecial.Name = "mnuPasteSpecial"
        Me.mnuPasteSpecial.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPasteSpecial.Size = New System.Drawing.Size(207, 22)
        Me.mnuPasteSpecial.Tag = "Paste"
        Me.mnuPasteSpecial.Text = "Paste Special"
        '
        'mnuEditPasteNewDataFrame
        '
        Me.mnuEditPasteNewDataFrame.Name = "mnuEditPasteNewDataFrame"
        Me.mnuEditPasteNewDataFrame.Size = New System.Drawing.Size(207, 22)
        Me.mnuEditPasteNewDataFrame.Tag = "Paste"
        Me.mnuEditPasteNewDataFrame.Text = "Paste New Data Frame"
        '
        'mnuEditSelectAll
        '
        Me.mnuEditSelectAll.Name = "mnuEditSelectAll"
        Me.mnuEditSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuEditSelectAll.Size = New System.Drawing.Size(207, 22)
        Me.mnuEditSelectAll.Tag = "Select_All"
        Me.mnuEditSelectAll.Text = "Select All "
        '
        'ToolStripSeparator71
        '
        Me.ToolStripSeparator71.Name = "ToolStripSeparator71"
        Me.ToolStripSeparator71.Size = New System.Drawing.Size(204, 6)
        '
        'mnuEditScript
        '
        Me.mnuEditScript.Name = "mnuEditScript"
        Me.mnuEditScript.Size = New System.Drawing.Size(207, 22)
        Me.mnuEditScript.Text = "Script"
        '
        'stsStrip
        '
        Me.stsStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.stsStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstatus})
        Me.stsStrip.Location = New System.Drawing.Point(0, 460)
        Me.stsStrip.Name = "stsStrip"
        Me.stsStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.stsStrip.Size = New System.Drawing.Size(834, 22)
        Me.stsStrip.TabIndex = 8
        Me.stsStrip.Text = "Status"
        '
        'tstatus
        '
        Me.tstatus.Name = "tstatus"
        Me.tstatus.Size = New System.Drawing.Size(119, 17)
        Me.tstatus.Text = "No worksheet loaded"
        '
        'Tool_strip
        '
        Me.Tool_strip.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Tool_strip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Tool_strip.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.Tool_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTbOpen, Me.mnuTbOpenFromLibrary, Me.mnuTbSave, Me.toolStripSeparator, Me.mnuTbCopy, Me.mnuTbPaste, Me.separator1, Me.mnuTbEditLastDialog, Me.mnuTbLast10Dialogs, Me.mnuLastGraph, Me.separator2, Me.mnuTbDataView, Me.mnuTbOutput, Me.mnuMetadata, Me.mnuTbLog, Me.mnuTbResetLayout, Me.separator3, Me.mnuTbHelp, Me.mnuTbLan})
        Me.Tool_strip.Location = New System.Drawing.Point(0, 24)
        Me.Tool_strip.Name = "Tool_strip"
        Me.Tool_strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Tool_strip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tool_strip.Size = New System.Drawing.Size(834, 37)
        Me.Tool_strip.TabIndex = 7
        Me.Tool_strip.Text = "Tool"
        '
        'mnuTbOpen
        '
        Me.mnuTbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbOpen.Image = Global.instat.My.Resources.Resources.openfromfile2
        Me.mnuTbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbOpen.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbOpen.Name = "mnuTbOpen"
        Me.mnuTbOpen.Size = New System.Drawing.Size(46, 34)
        Me.mnuTbOpen.Text = "&Open"
        Me.mnuTbOpen.ToolTipText = "Import"
        '
        'mnuTbOpenFromLibrary
        '
        Me.mnuTbOpenFromLibrary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbOpenFromLibrary.Image = Global.instat.My.Resources.Resources.openfromlibrary
        Me.mnuTbOpenFromLibrary.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbOpenFromLibrary.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbOpenFromLibrary.Name = "mnuTbOpenFromLibrary"
        Me.mnuTbOpenFromLibrary.Size = New System.Drawing.Size(34, 34)
        Me.mnuTbOpenFromLibrary.ToolTipText = "Import From Library"
        '
        'mnuTbSave
        '
        Me.mnuTbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbSave.Image = Global.instat.My.Resources.Resources.save2
        Me.mnuTbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbSave.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbSave.Name = "mnuTbSave"
        Me.mnuTbSave.Size = New System.Drawing.Size(34, 34)
        Me.mnuTbSave.Text = "&Save"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 37)
        '
        'mnuTbCopy
        '
        Me.mnuTbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbCopy.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSubTbCopy, Me.mnuSubTbCopySpecial})
        Me.mnuTbCopy.Image = Global.instat.My.Resources.Resources.copy2
        Me.mnuTbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbCopy.Name = "mnuTbCopy"
        Me.mnuTbCopy.Size = New System.Drawing.Size(46, 34)
        Me.mnuTbCopy.Text = "ToolStripSplitButton3"
        Me.mnuTbCopy.ToolTipText = "View Last Graph"
        '
        'mnuSubTbCopy
        '
        Me.mnuSubTbCopy.Name = "mnuSubTbCopy"
        Me.mnuSubTbCopy.Size = New System.Drawing.Size(142, 22)
        Me.mnuSubTbCopy.Text = "Copy"
        '
        'mnuSubTbCopySpecial
        '
        Me.mnuSubTbCopySpecial.Name = "mnuSubTbCopySpecial"
        Me.mnuSubTbCopySpecial.Size = New System.Drawing.Size(142, 22)
        Me.mnuSubTbCopySpecial.Text = "Copy Special"
        '
        'mnuTbPaste
        '
        Me.mnuTbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbPaste.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSubTbPaste, Me.mnuSubTbPasteSpecial})
        Me.mnuTbPaste.Image = Global.instat.My.Resources.Resources.paste2
        Me.mnuTbPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbPaste.Name = "mnuTbPaste"
        Me.mnuTbPaste.Size = New System.Drawing.Size(46, 34)
        Me.mnuTbPaste.Text = "ToolStripSplitButton3"
        Me.mnuTbPaste.ToolTipText = "View Last Graph"
        '
        'mnuSubTbPaste
        '
        Me.mnuSubTbPaste.Name = "mnuSubTbPaste"
        Me.mnuSubTbPaste.Size = New System.Drawing.Size(142, 22)
        Me.mnuSubTbPaste.Text = "Paste"
        '
        'mnuSubTbPasteSpecial
        '
        Me.mnuSubTbPasteSpecial.Name = "mnuSubTbPasteSpecial"
        Me.mnuSubTbPasteSpecial.Size = New System.Drawing.Size(142, 22)
        Me.mnuSubTbPasteSpecial.Text = "Paste Special"
        '
        'separator1
        '
        Me.separator1.Name = "separator1"
        Me.separator1.Size = New System.Drawing.Size(6, 37)
        '
        'mnuTbEditLastDialog
        '
        Me.mnuTbEditLastDialog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbEditLastDialog.Image = Global.instat.My.Resources.Resources.dialog2
        Me.mnuTbEditLastDialog.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbEditLastDialog.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbEditLastDialog.Name = "mnuTbEditLastDialog"
        Me.mnuTbEditLastDialog.Size = New System.Drawing.Size(34, 34)
        Me.mnuTbEditLastDialog.ToolTipText = "Edit Last Dialog"
        '
        'mnuTbLast10Dialogs
        '
        Me.mnuTbLast10Dialogs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbLast10Dialogs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sepStart, Me.sepEnd})
        Me.mnuTbLast10Dialogs.Image = Global.instat.My.Resources.Resources.last10dialogs
        Me.mnuTbLast10Dialogs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbLast10Dialogs.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbLast10Dialogs.Name = "mnuTbLast10Dialogs"
        Me.mnuTbLast10Dialogs.Size = New System.Drawing.Size(43, 34)
        Me.mnuTbLast10Dialogs.ToolTipText = "Last 10 Dialogs"
        '
        'sepStart
        '
        Me.sepStart.Name = "sepStart"
        Me.sepStart.Size = New System.Drawing.Size(57, 6)
        Me.sepStart.Visible = False
        '
        'sepEnd
        '
        Me.sepEnd.Name = "sepEnd"
        Me.sepEnd.Size = New System.Drawing.Size(57, 6)
        Me.sepEnd.Visible = False
        '
        'mnuLastGraph
        '
        Me.mnuLastGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuLastGraph.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewer, Me.mnuploty})
        Me.mnuLastGraph.Image = CType(resources.GetObject("mnuLastGraph.Image"), System.Drawing.Image)
        Me.mnuLastGraph.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuLastGraph.Name = "mnuLastGraph"
        Me.mnuLastGraph.Size = New System.Drawing.Size(46, 34)
        Me.mnuLastGraph.Text = "ToolStripSplitButton3"
        Me.mnuLastGraph.ToolTipText = "View Last Graph"
        '
        'mnuViewer
        '
        Me.mnuViewer.Name = "mnuViewer"
        Me.mnuViewer.Size = New System.Drawing.Size(128, 22)
        Me.mnuViewer.Text = "R Viewer..."
        '
        'mnuploty
        '
        Me.mnuploty.Name = "mnuploty"
        Me.mnuploty.Size = New System.Drawing.Size(128, 22)
        Me.mnuploty.Text = "Plotly..."
        '
        'separator2
        '
        Me.separator2.Name = "separator2"
        Me.separator2.Size = New System.Drawing.Size(6, 37)
        '
        'mnuTbDataView
        '
        Me.mnuTbDataView.CheckOnClick = True
        Me.mnuTbDataView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbDataView.Image = Global.instat.My.Resources.Resources.dataframe2
        Me.mnuTbDataView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbDataView.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbDataView.Name = "mnuTbDataView"
        Me.mnuTbDataView.Size = New System.Drawing.Size(34, 34)
        Me.mnuTbDataView.ToolTipText = "Data View"
        '
        'mnuTbOutput
        '
        Me.mnuTbOutput.CheckOnClick = True
        Me.mnuTbOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbOutput.Image = Global.instat.My.Resources.Resources.output3
        Me.mnuTbOutput.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbOutput.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbOutput.Name = "mnuTbOutput"
        Me.mnuTbOutput.Size = New System.Drawing.Size(34, 34)
        Me.mnuTbOutput.ToolTipText = "Output Window"
        '
        'mnuMetadata
        '
        Me.mnuMetadata.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuMetadata.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColumnMetadat, Me.mnuDataFrameMetadat})
        Me.mnuMetadata.Image = CType(resources.GetObject("mnuMetadata.Image"), System.Drawing.Image)
        Me.mnuMetadata.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuMetadata.Name = "mnuMetadata"
        Me.mnuMetadata.Size = New System.Drawing.Size(46, 34)
        Me.mnuMetadata.Text = "ToolStripSplitButton2"
        Me.mnuMetadata.ToolTipText = "Column Metadata"
        '
        'mnuColumnMetadat
        '
        Me.mnuColumnMetadat.Name = "mnuColumnMetadat"
        Me.mnuColumnMetadat.Size = New System.Drawing.Size(202, 22)
        Me.mnuColumnMetadat.Text = "  Column Metadata..."
        '
        'mnuDataFrameMetadat
        '
        Me.mnuDataFrameMetadat.Name = "mnuDataFrameMetadat"
        Me.mnuDataFrameMetadat.Size = New System.Drawing.Size(202, 22)
        Me.mnuDataFrameMetadat.Text = "  Data Frame Metadata..."
        '
        'mnuTbLog
        '
        Me.mnuTbLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbLog.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogWindow, Me.mnuScriptWindow})
        Me.mnuTbLog.Image = CType(resources.GetObject("mnuTbLog.Image"), System.Drawing.Image)
        Me.mnuTbLog.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbLog.Name = "mnuTbLog"
        Me.mnuTbLog.Size = New System.Drawing.Size(46, 34)
        Me.mnuTbLog.Text = "Script Window..."
        Me.mnuTbLog.ToolTipText = "Log Window"
        '
        'mnuLogWindow
        '
        Me.mnuLogWindow.Name = "mnuLogWindow"
        Me.mnuLogWindow.Size = New System.Drawing.Size(166, 22)
        Me.mnuLogWindow.Text = "  Log Window..."
        '
        'mnuScriptWindow
        '
        Me.mnuScriptWindow.Name = "mnuScriptWindow"
        Me.mnuScriptWindow.Size = New System.Drawing.Size(166, 22)
        Me.mnuScriptWindow.Text = "  Script Window..."
        '
        'mnuTbResetLayout
        '
        Me.mnuTbResetLayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbResetLayout.Image = Global.instat.My.Resources.Resources.reset3
        Me.mnuTbResetLayout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbResetLayout.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbResetLayout.Name = "mnuTbResetLayout"
        Me.mnuTbResetLayout.Size = New System.Drawing.Size(34, 34)
        Me.mnuTbResetLayout.ToolTipText = "Reset to Default Layout"
        '
        'separator3
        '
        Me.separator3.Name = "separator3"
        Me.separator3.Size = New System.Drawing.Size(6, 37)
        '
        'mnuTbHelp
        '
        Me.mnuTbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbHelp.Image = Global.instat.My.Resources.Resources.help2
        Me.mnuTbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbHelp.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbHelp.Name = "mnuTbHelp"
        Me.mnuTbHelp.Size = New System.Drawing.Size(34, 34)
        Me.mnuTbHelp.Text = "He&lp"
        '
        'mnuTbLan
        '
        Me.mnuTbLan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbLan.Image = Global.instat.My.Resources.Resources.lan_btn
        Me.mnuTbLan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbLan.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbLan.Name = "mnuTbLan"
        Me.mnuTbLan.Size = New System.Drawing.Size(34, 34)
        Me.mnuTbLan.ToolTipText = "Changes the menu language to English, and from English"
        '
        'mnuBar
        '
        Me.mnuBar.AllowMerge = False
        Me.mnuBar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.mnuBar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuBar.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.mnuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuPrepare, Me.mnuDescribe, Me.mnuModel, Me.mnuStructured, Me.mnuClimatic, Me.mnuProcurement, Me.mnuOptionsByContext, Me.mnuTools, Me.mnuView, Me.mnuHelp})
        Me.mnuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.mnuBar.Location = New System.Drawing.Point(0, 0)
        Me.mnuBar.Name = "mnuBar"
        Me.mnuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnuBar.ShowItemToolTips = True
        Me.mnuBar.Size = New System.Drawing.Size(834, 24)
        Me.mnuBar.TabIndex = 6
        Me.mnuBar.Text = "Menu_strip"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNewDataFrame, Me.mnuFileImportFromFile, Me.mnuFileImportFromLibrary, Me.ToolStripSeparator35, Me.mnuFileImportFromODK, Me.mnuFileImportFromCSPRO, Me.mnuFileImportFromDatabases, Me.mnuFileImportandTidyNetCDFFile, Me.mnuFileConvert, Me.tlSeparatorFile, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFileExport, Me.mnuFilePrint, Me.mnuFilePrintPreview, Me.tlSeparatorFile3, Me.mnuFileCloseData, Me.ToolStripSeparator8, Me.mnuFIleExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Tag = "File"
        Me.mnuFile.Text = "File"
        '
        'mnuFileNewDataFrame
        '
        Me.mnuFileNewDataFrame.Name = "mnuFileNewDataFrame"
        Me.mnuFileNewDataFrame.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNewDataFrame.Size = New System.Drawing.Size(232, 22)
        Me.mnuFileNewDataFrame.Tag = "New_Data_Frame"
        Me.mnuFileNewDataFrame.Text = "New Data Frame..."
        '
        'mnuFileImportFromFile
        '
        Me.mnuFileImportFromFile.Name = "mnuFileImportFromFile"
        Me.mnuFileImportFromFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileImportFromFile.Size = New System.Drawing.Size(232, 22)
        Me.mnuFileImportFromFile.Tag = "Import_From_File"
        Me.mnuFileImportFromFile.Text = "Import From File..."
        '
        'mnuFileImportFromLibrary
        '
        Me.mnuFileImportFromLibrary.Name = "mnuFileImportFromLibrary"
        Me.mnuFileImportFromLibrary.Size = New System.Drawing.Size(232, 22)
        Me.mnuFileImportFromLibrary.Tag = "Open_From_Library"
        Me.mnuFileImportFromLibrary.Text = "Import From Library..."
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(229, 6)
        '
        'mnuFileImportFromODK
        '
        Me.mnuFileImportFromODK.Name = "mnuFileImportFromODK"
        Me.mnuFileImportFromODK.Size = New System.Drawing.Size(232, 22)
        Me.mnuFileImportFromODK.Text = "Import From ODK..."
        '
        'mnuFileImportFromCSPRO
        '
        Me.mnuFileImportFromCSPRO.Enabled = False
        Me.mnuFileImportFromCSPRO.Name = "mnuFileImportFromCSPRO"
        Me.mnuFileImportFromCSPRO.Size = New System.Drawing.Size(232, 22)
        Me.mnuFileImportFromCSPRO.Text = "Import From CSPRO..."
        Me.mnuFileImportFromCSPRO.Visible = False
        '
        'mnuFileImportFromDatabases
        '
        Me.mnuFileImportFromDatabases.Enabled = False
        Me.mnuFileImportFromDatabases.Name = "mnuFileImportFromDatabases"
        Me.mnuFileImportFromDatabases.Size = New System.Drawing.Size(232, 22)
        Me.mnuFileImportFromDatabases.Text = "Import From Databases..."
        Me.mnuFileImportFromDatabases.Visible = False
        '
        'mnuFileImportandTidyNetCDFFile
        '
        Me.mnuFileImportandTidyNetCDFFile.Name = "mnuFileImportandTidyNetCDFFile"
        Me.mnuFileImportandTidyNetCDFFile.Size = New System.Drawing.Size(232, 22)
        Me.mnuFileImportandTidyNetCDFFile.Text = "Import and Tidy NetCDF File..."
        '
        'mnuFileConvert
        '
        Me.mnuFileConvert.Enabled = False
        Me.mnuFileConvert.Name = "mnuFileConvert"
        Me.mnuFileConvert.Size = New System.Drawing.Size(232, 22)
        Me.mnuFileConvert.Text = "Convert..."
        Me.mnuFileConvert.Visible = False
        '
        'tlSeparatorFile
        '
        Me.tlSeparatorFile.Name = "tlSeparatorFile"
        Me.tlSeparatorFile.Size = New System.Drawing.Size(229, 6)
        '
        'mnuFileExport
        '
        Me.mnuFileExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExportExportDataSet, Me.mnuFileExportExportRObjectsToolStripMenuItem, Me.mnuFileExportExportRWorkspace, Me.mnuFileExportExportGraphAsImage})
        Me.mnuFileExport.Name = "mnuFileExport"
        Me.mnuFileExport.Size = New System.Drawing.Size(232, 22)
        Me.mnuFileExport.Text = "Export"
        '
        'mnuFileExportExportDataSet
        '
        Me.mnuFileExportExportDataSet.Name = "mnuFileExportExportDataSet"
        Me.mnuFileExportExportDataSet.Size = New System.Drawing.Size(204, 22)
        Me.mnuFileExportExportDataSet.Text = "Export Dataset..."
        '
        'mnuFileExportExportRObjectsToolStripMenuItem
        '
        Me.mnuFileExportExportRObjectsToolStripMenuItem.Name = "mnuFileExportExportRObjectsToolStripMenuItem"
        Me.mnuFileExportExportRObjectsToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.mnuFileExportExportRObjectsToolStripMenuItem.Text = "Export R Objects..."
        '
        'mnuFileExportExportRWorkspace
        '
        Me.mnuFileExportExportRWorkspace.Name = "mnuFileExportExportRWorkspace"
        Me.mnuFileExportExportRWorkspace.Size = New System.Drawing.Size(204, 22)
        Me.mnuFileExportExportRWorkspace.Text = "Export R Workspace..."
        '
        'mnuFileExportExportGraphAsImage
        '
        Me.mnuFileExportExportGraphAsImage.Name = "mnuFileExportExportGraphAsImage"
        Me.mnuFileExportExportGraphAsImage.Size = New System.Drawing.Size(204, 22)
        Me.mnuFileExportExportGraphAsImage.Text = "Export Graph As Image..."
        '
        'mnuFileCloseData
        '
        Me.mnuFileCloseData.Name = "mnuFileCloseData"
        Me.mnuFileCloseData.Size = New System.Drawing.Size(232, 22)
        Me.mnuFileCloseData.Text = "Close Data Book"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(229, 6)
        '
        'mnuPrepare
        '
        Me.mnuPrepare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareDataFrame, Me.mnuPrepareCheckData, Me.ToolStripSeparator6, Me.mnuPrepareCalculator, Me.mnuPrepareColumnCalculate, Me.mnuPrepareColumnFactor, Me.mnuPrepareColumnText, Me.mnuPrepareColumnDate, Me.mnuPrepareColumnDefine, Me.ToolStripSeparator4, Me.mnuPrepareDataReshape, Me.ToolStripSeparator7, Me.mnuPrepareKeysAndLinks, Me.mnuPrepareDataObject, Me.mnuPrepareRObjects})
        Me.mnuPrepare.Name = "mnuPrepare"
        Me.mnuPrepare.Size = New System.Drawing.Size(59, 20)
        Me.mnuPrepare.Tag = "Prepare"
        Me.mnuPrepare.Text = "Prepare"
        '
        'mnuPrepareDataFrame
        '
        Me.mnuPrepareDataFrame.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareDataFrameViewData, Me.mnuPrepareDataFrameRenameColumn, Me.mnuPrepareDataFrameDuplicateColumn, Me.mnuPrepareDataFrameRowNumbersNames, Me.ToolStripSeparator1, Me.mnuPrepareDataFrameSort, Me.mnuPrepareDataFrameFilter, Me.mnuPrepareDataFrameSelectColumns, Me.mnuPrepareDataFrameReplaceValues, Me.mnuPrepareDataFrameConvertColumns, Me.ToolStripSeparator2, Me.mnuPrepareDataFrameReorderColumns, Me.mnuPrepareDataFrameInsertColumnsRows, Me.mnuPrepareDataFrameDeleteColumnsRows, Me.mnuPrepareDataFrameProtectColumn, Me.mnuPrepareDataFrameHideColumns, Me.mnuPrepareDataFrameFreezeColumns, Me.mnuPrepareDataFrameColumnStructure, Me.mnuPrepareDataframeColourByProperty})
        Me.mnuPrepareDataFrame.Name = "mnuPrepareDataFrame"
        Me.mnuPrepareDataFrame.Size = New System.Drawing.Size(186, 22)
        Me.mnuPrepareDataFrame.Tag = "Data_Frame"
        Me.mnuPrepareDataFrame.Text = "Data Frame"
        '
        'mnuPrepareDataFrameViewData
        '
        Me.mnuPrepareDataFrameViewData.Name = "mnuPrepareDataFrameViewData"
        Me.mnuPrepareDataFrameViewData.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameViewData.Tag = "View_Data..."
        Me.mnuPrepareDataFrameViewData.Text = "View Data..."
        '
        'mnuPrepareDataFrameRenameColumn
        '
        Me.mnuPrepareDataFrameRenameColumn.Name = "mnuPrepareDataFrameRenameColumn"
        Me.mnuPrepareDataFrameRenameColumn.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameRenameColumn.Tag = "Rename_Column..."
        Me.mnuPrepareDataFrameRenameColumn.Text = "Rename Columns..."
        '
        'mnuPrepareDataFrameDuplicateColumn
        '
        Me.mnuPrepareDataFrameDuplicateColumn.Name = "mnuPrepareDataFrameDuplicateColumn"
        Me.mnuPrepareDataFrameDuplicateColumn.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameDuplicateColumn.Text = "Duplicate Column..."
        '
        'mnuPrepareDataFrameRowNumbersNames
        '
        Me.mnuPrepareDataFrameRowNumbersNames.Name = "mnuPrepareDataFrameRowNumbersNames"
        Me.mnuPrepareDataFrameRowNumbersNames.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameRowNumbersNames.Tag = "Row_Numbers/Names..."
        Me.mnuPrepareDataFrameRowNumbersNames.Text = "Row Numbers/Names..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(197, 6)
        '
        'mnuPrepareDataFrameSort
        '
        Me.mnuPrepareDataFrameSort.Name = "mnuPrepareDataFrameSort"
        Me.mnuPrepareDataFrameSort.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameSort.Tag = "Sort..."
        Me.mnuPrepareDataFrameSort.Text = "Sort..."
        '
        'mnuPrepareDataFrameFilter
        '
        Me.mnuPrepareDataFrameFilter.Name = "mnuPrepareDataFrameFilter"
        Me.mnuPrepareDataFrameFilter.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameFilter.Tag = "Filter..."
        Me.mnuPrepareDataFrameFilter.Text = "Filter..."
        '
        'mnuPrepareDataFrameSelectColumns
        '
        Me.mnuPrepareDataFrameSelectColumns.Name = "mnuPrepareDataFrameSelectColumns"
        Me.mnuPrepareDataFrameSelectColumns.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameSelectColumns.Text = "Column Selection..."
        '
        'mnuPrepareDataFrameReplaceValues
        '
        Me.mnuPrepareDataFrameReplaceValues.Name = "mnuPrepareDataFrameReplaceValues"
        Me.mnuPrepareDataFrameReplaceValues.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameReplaceValues.Tag = "Replace_Values..."
        Me.mnuPrepareDataFrameReplaceValues.Text = "Replace Values..."
        '
        'mnuPrepareDataFrameConvertColumns
        '
        Me.mnuPrepareDataFrameConvertColumns.Name = "mnuPrepareDataFrameConvertColumns"
        Me.mnuPrepareDataFrameConvertColumns.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameConvertColumns.Tag = "Convert_Columns..."
        Me.mnuPrepareDataFrameConvertColumns.Text = "Convert Columns..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(197, 6)
        '
        'mnuPrepareDataFrameReorderColumns
        '
        Me.mnuPrepareDataFrameReorderColumns.Name = "mnuPrepareDataFrameReorderColumns"
        Me.mnuPrepareDataFrameReorderColumns.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameReorderColumns.Tag = "Reorder_Columns..."
        Me.mnuPrepareDataFrameReorderColumns.Text = "Reorder Columns..."
        '
        'mnuPrepareDataFrameInsertColumnsRows
        '
        Me.mnuPrepareDataFrameInsertColumnsRows.Name = "mnuPrepareDataFrameInsertColumnsRows"
        Me.mnuPrepareDataFrameInsertColumnsRows.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameInsertColumnsRows.Tag = "Insert_Columns/Rows..."
        Me.mnuPrepareDataFrameInsertColumnsRows.Text = "Insert Columns/Rows..."
        '
        'mnuPrepareDataFrameDeleteColumnsRows
        '
        Me.mnuPrepareDataFrameDeleteColumnsRows.Name = "mnuPrepareDataFrameDeleteColumnsRows"
        Me.mnuPrepareDataFrameDeleteColumnsRows.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameDeleteColumnsRows.Tag = "Delete_Columns/Rows..."
        Me.mnuPrepareDataFrameDeleteColumnsRows.Text = "Delete Columns/Rows..."
        '
        'mnuPrepareDataFrameProtectColumn
        '
        Me.mnuPrepareDataFrameProtectColumn.Enabled = False
        Me.mnuPrepareDataFrameProtectColumn.Name = "mnuPrepareDataFrameProtectColumn"
        Me.mnuPrepareDataFrameProtectColumn.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameProtectColumn.Tag = "..."
        Me.mnuPrepareDataFrameProtectColumn.Text = "Protect Column..."
        Me.mnuPrepareDataFrameProtectColumn.Visible = False
        '
        'mnuPrepareDataFrameHideColumns
        '
        Me.mnuPrepareDataFrameHideColumns.Name = "mnuPrepareDataFrameHideColumns"
        Me.mnuPrepareDataFrameHideColumns.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameHideColumns.Tag = "Hide_Columns..."
        Me.mnuPrepareDataFrameHideColumns.Text = "Hide/Show Columns..."
        '
        'mnuPrepareDataFrameFreezeColumns
        '
        Me.mnuPrepareDataFrameFreezeColumns.Enabled = False
        Me.mnuPrepareDataFrameFreezeColumns.Name = "mnuPrepareDataFrameFreezeColumns"
        Me.mnuPrepareDataFrameFreezeColumns.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameFreezeColumns.Tag = "Freeze_Columns..."
        Me.mnuPrepareDataFrameFreezeColumns.Text = "Freeze Columns..."
        Me.mnuPrepareDataFrameFreezeColumns.Visible = False
        '
        'mnuPrepareDataFrameColumnStructure
        '
        Me.mnuPrepareDataFrameColumnStructure.Name = "mnuPrepareDataFrameColumnStructure"
        Me.mnuPrepareDataFrameColumnStructure.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameColumnStructure.Tag = "Column_Structure..."
        Me.mnuPrepareDataFrameColumnStructure.Text = "Column Structure..."
        '
        'mnuPrepareDataframeColourByProperty
        '
        Me.mnuPrepareDataframeColourByProperty.Name = "mnuPrepareDataframeColourByProperty"
        Me.mnuPrepareDataframeColourByProperty.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataframeColourByProperty.Text = "Colour by Property..."
        '
        'mnuPrepareCheckData
        '
        Me.mnuPrepareCheckData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuPrepareCheckData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareCheckDataVisualiseData, Me.mnuPrepareCheckDataDuplicates, Me.mnuPrepareCheckDataCompareColumns, Me.mnuPrepareCheckDataNonNumericCases, Me.ToolStripSeparator49, Me.mnuPrepareCheckDataBoxplot, Me.mnuPrepareCheckDataOneVariableSummarise, Me.mnuPrepareCheckDataOneVariableGraph, Me.mnuPrepareCheckDataOneWayFrequencies, Me.ToolStripSeparator41, Me.mnuPrepareCheckDataExportOpenRefine, Me.mnuPrepareCheckDataImportOpenRefine, Me.ToolStripSeparator40, Me.mnuPreparePrepareToShareJitter, Me.mnuPrepareCheckDataPrePareToShareSdcPackage, Me.mnuPrepareCheckDataAnonymiseIDColumn})
        Me.mnuPrepareCheckData.Name = "mnuPrepareCheckData"
        Me.mnuPrepareCheckData.Size = New System.Drawing.Size(186, 22)
        Me.mnuPrepareCheckData.Text = "Check Data"
        '
        'mnuPrepareCheckDataVisualiseData
        '
        Me.mnuPrepareCheckDataVisualiseData.Name = "mnuPrepareCheckDataVisualiseData"
        Me.mnuPrepareCheckDataVisualiseData.Size = New System.Drawing.Size(245, 22)
        Me.mnuPrepareCheckDataVisualiseData.Text = "Visualise Data..."
        '
        'mnuPrepareCheckDataDuplicates
        '
        Me.mnuPrepareCheckDataDuplicates.Name = "mnuPrepareCheckDataDuplicates"
        Me.mnuPrepareCheckDataDuplicates.Size = New System.Drawing.Size(245, 22)
        Me.mnuPrepareCheckDataDuplicates.Text = "Duplicates..."
        '
        'mnuPrepareCheckDataCompareColumns
        '
        Me.mnuPrepareCheckDataCompareColumns.Name = "mnuPrepareCheckDataCompareColumns"
        Me.mnuPrepareCheckDataCompareColumns.Size = New System.Drawing.Size(245, 22)
        Me.mnuPrepareCheckDataCompareColumns.Text = "Compare Columns..."
        '
        'mnuPrepareCheckDataNonNumericCases
        '
        Me.mnuPrepareCheckDataNonNumericCases.Name = "mnuPrepareCheckDataNonNumericCases"
        Me.mnuPrepareCheckDataNonNumericCases.Size = New System.Drawing.Size(245, 22)
        Me.mnuPrepareCheckDataNonNumericCases.Text = "Non-Numeric Values..."
        '
        'ToolStripSeparator49
        '
        Me.ToolStripSeparator49.Name = "ToolStripSeparator49"
        Me.ToolStripSeparator49.Size = New System.Drawing.Size(242, 6)
        '
        'mnuPrepareCheckDataBoxplot
        '
        Me.mnuPrepareCheckDataBoxplot.Name = "mnuPrepareCheckDataBoxplot"
        Me.mnuPrepareCheckDataBoxplot.Size = New System.Drawing.Size(245, 22)
        Me.mnuPrepareCheckDataBoxplot.Text = "Boxplot..."
        '
        'mnuPrepareCheckDataOneVariableSummarise
        '
        Me.mnuPrepareCheckDataOneVariableSummarise.Name = "mnuPrepareCheckDataOneVariableSummarise"
        Me.mnuPrepareCheckDataOneVariableSummarise.Size = New System.Drawing.Size(245, 22)
        Me.mnuPrepareCheckDataOneVariableSummarise.Text = "One Variable Summarise..."
        '
        'mnuPrepareCheckDataOneVariableGraph
        '
        Me.mnuPrepareCheckDataOneVariableGraph.Name = "mnuPrepareCheckDataOneVariableGraph"
        Me.mnuPrepareCheckDataOneVariableGraph.Size = New System.Drawing.Size(245, 22)
        Me.mnuPrepareCheckDataOneVariableGraph.Text = "One Variable Graph..."
        '
        'mnuPrepareCheckDataOneWayFrequencies
        '
        Me.mnuPrepareCheckDataOneWayFrequencies.Name = "mnuPrepareCheckDataOneWayFrequencies"
        Me.mnuPrepareCheckDataOneWayFrequencies.Size = New System.Drawing.Size(245, 22)
        Me.mnuPrepareCheckDataOneWayFrequencies.Text = "One Variable Frequencies..."
        '
        'ToolStripSeparator41
        '
        Me.ToolStripSeparator41.Name = "ToolStripSeparator41"
        Me.ToolStripSeparator41.Size = New System.Drawing.Size(242, 6)
        '
        'mnuPrepareCheckDataExportOpenRefine
        '
        Me.mnuPrepareCheckDataExportOpenRefine.Name = "mnuPrepareCheckDataExportOpenRefine"
        Me.mnuPrepareCheckDataExportOpenRefine.Size = New System.Drawing.Size(245, 22)
        Me.mnuPrepareCheckDataExportOpenRefine.Text = "Export To OpenRefine..."
        '
        'mnuPrepareCheckDataImportOpenRefine
        '
        Me.mnuPrepareCheckDataImportOpenRefine.Name = "mnuPrepareCheckDataImportOpenRefine"
        Me.mnuPrepareCheckDataImportOpenRefine.Size = New System.Drawing.Size(245, 22)
        Me.mnuPrepareCheckDataImportOpenRefine.Text = "Import From OpenRefine..."
        '
        'ToolStripSeparator40
        '
        Me.ToolStripSeparator40.Name = "ToolStripSeparator40"
        Me.ToolStripSeparator40.Size = New System.Drawing.Size(242, 6)
        '
        'mnuPreparePrepareToShareJitter
        '
        Me.mnuPreparePrepareToShareJitter.Enabled = False
        Me.mnuPreparePrepareToShareJitter.Name = "mnuPreparePrepareToShareJitter"
        Me.mnuPreparePrepareToShareJitter.Size = New System.Drawing.Size(245, 22)
        Me.mnuPreparePrepareToShareJitter.Text = "Jitter..."
        Me.mnuPreparePrepareToShareJitter.Visible = False
        '
        'mnuPrepareCheckDataPrePareToShareSdcPackage
        '
        Me.mnuPrepareCheckDataPrePareToShareSdcPackage.Enabled = False
        Me.mnuPrepareCheckDataPrePareToShareSdcPackage.Name = "mnuPrepareCheckDataPrePareToShareSdcPackage"
        Me.mnuPrepareCheckDataPrePareToShareSdcPackage.Size = New System.Drawing.Size(245, 22)
        Me.mnuPrepareCheckDataPrePareToShareSdcPackage.Text = "Prepare to Share (sdc package)..."
        Me.mnuPrepareCheckDataPrePareToShareSdcPackage.Visible = False
        '
        'mnuPrepareCheckDataAnonymiseIDColumn
        '
        Me.mnuPrepareCheckDataAnonymiseIDColumn.Name = "mnuPrepareCheckDataAnonymiseIDColumn"
        Me.mnuPrepareCheckDataAnonymiseIDColumn.Size = New System.Drawing.Size(245, 22)
        Me.mnuPrepareCheckDataAnonymiseIDColumn.Text = "Anonymise ID Column..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(183, 6)
        '
        'mnuPrepareCalculator
        '
        Me.mnuPrepareCalculator.Name = "mnuPrepareCalculator"
        Me.mnuPrepareCalculator.Size = New System.Drawing.Size(186, 22)
        Me.mnuPrepareCalculator.Tag = "Calculator..."
        Me.mnuPrepareCalculator.Text = "Column: Calculator..."
        '
        'mnuPrepareColumnCalculate
        '
        Me.mnuPrepareColumnCalculate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnNumericRegularSequence, Me.mnuPrepareColumnNumericEnter, Me.ToolStripSeparator25, Me.mnuPrepareColumnNumericRowSummaries, Me.mnuPrepareColumnNumericTransform, Me.mnuPrepareColumnNumericPolynomials, Me.ToolStripSeparator56, Me.mnuPrepareColumnNumericRandomSamples, Me.mnuPrepareColumnNumericPermuteRows})
        Me.mnuPrepareColumnCalculate.Name = "mnuPrepareColumnCalculate"
        Me.mnuPrepareColumnCalculate.Size = New System.Drawing.Size(186, 22)
        Me.mnuPrepareColumnCalculate.Tag = "Column:_Calculate"
        Me.mnuPrepareColumnCalculate.Text = "Column: Numeric"
        '
        'mnuPrepareColumnNumericRegularSequence
        '
        Me.mnuPrepareColumnNumericRegularSequence.Name = "mnuPrepareColumnNumericRegularSequence"
        Me.mnuPrepareColumnNumericRegularSequence.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnNumericRegularSequence.Tag = "Regular_Sequence..."
        Me.mnuPrepareColumnNumericRegularSequence.Text = "Regular Sequence..."
        '
        'mnuPrepareColumnNumericEnter
        '
        Me.mnuPrepareColumnNumericEnter.Name = "mnuPrepareColumnNumericEnter"
        Me.mnuPrepareColumnNumericEnter.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnNumericEnter.Text = "Enter..."
        '
        'ToolStripSeparator25
        '
        Me.ToolStripSeparator25.Name = "ToolStripSeparator25"
        Me.ToolStripSeparator25.Size = New System.Drawing.Size(176, 6)
        '
        'mnuPrepareColumnNumericRowSummaries
        '
        Me.mnuPrepareColumnNumericRowSummaries.Name = "mnuPrepareColumnNumericRowSummaries"
        Me.mnuPrepareColumnNumericRowSummaries.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnNumericRowSummaries.Text = "Row Summaries..."
        '
        'mnuPrepareColumnNumericTransform
        '
        Me.mnuPrepareColumnNumericTransform.Name = "mnuPrepareColumnNumericTransform"
        Me.mnuPrepareColumnNumericTransform.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnNumericTransform.Tag = "Rank..."
        Me.mnuPrepareColumnNumericTransform.Text = "Transform..."
        '
        'mnuPrepareColumnNumericPolynomials
        '
        Me.mnuPrepareColumnNumericPolynomials.Name = "mnuPrepareColumnNumericPolynomials"
        Me.mnuPrepareColumnNumericPolynomials.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnNumericPolynomials.Tag = "Polynomials..."
        Me.mnuPrepareColumnNumericPolynomials.Text = "Polynomials..."
        '
        'ToolStripSeparator56
        '
        Me.ToolStripSeparator56.Name = "ToolStripSeparator56"
        Me.ToolStripSeparator56.Size = New System.Drawing.Size(176, 6)
        '
        'mnuPrepareColumnNumericRandomSamples
        '
        Me.mnuPrepareColumnNumericRandomSamples.Name = "mnuPrepareColumnNumericRandomSamples"
        Me.mnuPrepareColumnNumericRandomSamples.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnNumericRandomSamples.Tag = "Random_Samples..."
        Me.mnuPrepareColumnNumericRandomSamples.Text = "Random Samples..."
        '
        'mnuPrepareColumnNumericPermuteRows
        '
        Me.mnuPrepareColumnNumericPermuteRows.Name = "mnuPrepareColumnNumericPermuteRows"
        Me.mnuPrepareColumnNumericPermuteRows.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnNumericPermuteRows.Tag = "Permute_Rows..."
        Me.mnuPrepareColumnNumericPermuteRows.Text = "Permute Columns..."
        '
        'mnuPrepareColumnFactor
        '
        Me.mnuPrepareColumnFactor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnFactorConvertToFactor, Me.mnuPrepareColumnFactorRecodeNumeric, Me.mnuPrepareColumnFactorCountInFactor, Me.ToolStripSeparator12, Me.mnuPrepareColumnFactorRecodeFactor, Me.mnuPrepareColumnFactorCombineFactors, Me.mnuPrepareColumnFactorDummyVariables, Me.ToolStripSeparator14, Me.mnuPrepareColumnFactorLevelsLabels, Me.mnuPrepareFactorViewLabels, Me.mnuPrepareColumnFactorReorderLevels, Me.mnuPrepareColumnFactorReferenceLevel, Me.mnuPrepareColumnFactorUnusedLevels, Me.mnuPrepareColumnFactorContrasts, Me.ToolStripSeparator19, Me.mnuPrepareColumnFactorFactorDataFrame})
        Me.mnuPrepareColumnFactor.Name = "mnuPrepareColumnFactor"
        Me.mnuPrepareColumnFactor.Size = New System.Drawing.Size(186, 22)
        Me.mnuPrepareColumnFactor.Tag = "Column:_Factor"
        Me.mnuPrepareColumnFactor.Text = "Column: Factor"
        '
        'mnuPrepareColumnFactorConvertToFactor
        '
        Me.mnuPrepareColumnFactorConvertToFactor.Name = "mnuPrepareColumnFactorConvertToFactor"
        Me.mnuPrepareColumnFactorConvertToFactor.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnFactorConvertToFactor.Tag = "Convert_To_Factor"
        Me.mnuPrepareColumnFactorConvertToFactor.Text = "Convert To Factor..."
        '
        'mnuPrepareColumnFactorRecodeNumeric
        '
        Me.mnuPrepareColumnFactorRecodeNumeric.Name = "mnuPrepareColumnFactorRecodeNumeric"
        Me.mnuPrepareColumnFactorRecodeNumeric.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnFactorRecodeNumeric.Tag = "Recode_Numeric..."
        Me.mnuPrepareColumnFactorRecodeNumeric.Text = "Recode Numeric..."
        '
        'mnuPrepareColumnFactorCountInFactor
        '
        Me.mnuPrepareColumnFactorCountInFactor.Name = "mnuPrepareColumnFactorCountInFactor"
        Me.mnuPrepareColumnFactorCountInFactor.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnFactorCountInFactor.Text = "Count in Factor..."
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(176, 6)
        '
        'mnuPrepareColumnFactorRecodeFactor
        '
        Me.mnuPrepareColumnFactorRecodeFactor.Name = "mnuPrepareColumnFactorRecodeFactor"
        Me.mnuPrepareColumnFactorRecodeFactor.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnFactorRecodeFactor.Tag = "Recode_Factor..."
        Me.mnuPrepareColumnFactorRecodeFactor.Text = "Recode Factor..."
        '
        'mnuPrepareColumnFactorCombineFactors
        '
        Me.mnuPrepareColumnFactorCombineFactors.Name = "mnuPrepareColumnFactorCombineFactors"
        Me.mnuPrepareColumnFactorCombineFactors.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnFactorCombineFactors.Tag = "Combine_Factors..."
        Me.mnuPrepareColumnFactorCombineFactors.Text = "Combine Factors..."
        '
        'mnuPrepareColumnFactorDummyVariables
        '
        Me.mnuPrepareColumnFactorDummyVariables.Name = "mnuPrepareColumnFactorDummyVariables"
        Me.mnuPrepareColumnFactorDummyVariables.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnFactorDummyVariables.Tag = "Dummy_Variables..."
        Me.mnuPrepareColumnFactorDummyVariables.Text = "Dummy Variables..."
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(176, 6)
        '
        'mnuPrepareColumnFactorLevelsLabels
        '
        Me.mnuPrepareColumnFactorLevelsLabels.Name = "mnuPrepareColumnFactorLevelsLabels"
        Me.mnuPrepareColumnFactorLevelsLabels.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnFactorLevelsLabels.Tag = "Levels/Labels..."
        Me.mnuPrepareColumnFactorLevelsLabels.Text = "Levels/Labels..."
        '
        'mnuPrepareFactorViewLabels
        '
        Me.mnuPrepareFactorViewLabels.Name = "mnuPrepareFactorViewLabels"
        Me.mnuPrepareFactorViewLabels.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareFactorViewLabels.Text = "View Labels..."
        '
        'mnuPrepareColumnFactorReorderLevels
        '
        Me.mnuPrepareColumnFactorReorderLevels.Name = "mnuPrepareColumnFactorReorderLevels"
        Me.mnuPrepareColumnFactorReorderLevels.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnFactorReorderLevels.Tag = "Reorder_Levels..."
        Me.mnuPrepareColumnFactorReorderLevels.Text = "Reorder Levels..."
        '
        'mnuPrepareColumnFactorReferenceLevel
        '
        Me.mnuPrepareColumnFactorReferenceLevel.Name = "mnuPrepareColumnFactorReferenceLevel"
        Me.mnuPrepareColumnFactorReferenceLevel.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnFactorReferenceLevel.Tag = "Reference_Level..."
        Me.mnuPrepareColumnFactorReferenceLevel.Text = "Reference Level..."
        '
        'mnuPrepareColumnFactorUnusedLevels
        '
        Me.mnuPrepareColumnFactorUnusedLevels.Name = "mnuPrepareColumnFactorUnusedLevels"
        Me.mnuPrepareColumnFactorUnusedLevels.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnFactorUnusedLevels.Tag = "Unused_Levels..."
        Me.mnuPrepareColumnFactorUnusedLevels.Text = "Unused Levels..."
        '
        'mnuPrepareColumnFactorContrasts
        '
        Me.mnuPrepareColumnFactorContrasts.Name = "mnuPrepareColumnFactorContrasts"
        Me.mnuPrepareColumnFactorContrasts.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnFactorContrasts.Tag = "Contrasts..."
        Me.mnuPrepareColumnFactorContrasts.Text = "Contrasts..."
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(176, 6)
        '
        'mnuPrepareColumnFactorFactorDataFrame
        '
        Me.mnuPrepareColumnFactorFactorDataFrame.Name = "mnuPrepareColumnFactorFactorDataFrame"
        Me.mnuPrepareColumnFactorFactorDataFrame.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnFactorFactorDataFrame.Tag = "Factor_Data_Frame"
        Me.mnuPrepareColumnFactorFactorDataFrame.Text = "Factor Data Frame..."
        '
        'mnuPrepareColumnText
        '
        Me.mnuPrepareColumnText.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnTextFindReplace, Me.mnuPrepareColumnTextTransform, Me.mnuPrepareColumnTextSplit, Me.mnuPrepareColumnTextCombine, Me.mnuPrepareColumnTextMatch, Me.mnuPrepareColumnTextDistance})
        Me.mnuPrepareColumnText.Name = "mnuPrepareColumnText"
        Me.mnuPrepareColumnText.Size = New System.Drawing.Size(186, 22)
        Me.mnuPrepareColumnText.Tag = "Column:_Text"
        Me.mnuPrepareColumnText.Text = "Column: Text"
        '
        'mnuPrepareColumnTextFindReplace
        '
        Me.mnuPrepareColumnTextFindReplace.Name = "mnuPrepareColumnTextFindReplace"
        Me.mnuPrepareColumnTextFindReplace.Size = New System.Drawing.Size(152, 22)
        Me.mnuPrepareColumnTextFindReplace.Tag = "Find/Replace..."
        Me.mnuPrepareColumnTextFindReplace.Text = "Find/Replace..."
        '
        'mnuPrepareColumnTextTransform
        '
        Me.mnuPrepareColumnTextTransform.Name = "mnuPrepareColumnTextTransform"
        Me.mnuPrepareColumnTextTransform.Size = New System.Drawing.Size(152, 22)
        Me.mnuPrepareColumnTextTransform.Tag = "Transform..."
        Me.mnuPrepareColumnTextTransform.Text = "Transform..."
        '
        'mnuPrepareColumnTextSplit
        '
        Me.mnuPrepareColumnTextSplit.Name = "mnuPrepareColumnTextSplit"
        Me.mnuPrepareColumnTextSplit.Size = New System.Drawing.Size(152, 22)
        Me.mnuPrepareColumnTextSplit.Tag = "Split..."
        Me.mnuPrepareColumnTextSplit.Text = "Split..."
        '
        'mnuPrepareColumnTextCombine
        '
        Me.mnuPrepareColumnTextCombine.Name = "mnuPrepareColumnTextCombine"
        Me.mnuPrepareColumnTextCombine.Size = New System.Drawing.Size(152, 22)
        Me.mnuPrepareColumnTextCombine.Tag = "Combine..."
        Me.mnuPrepareColumnTextCombine.Text = "Combine..."
        '
        'mnuPrepareColumnTextMatch
        '
        Me.mnuPrepareColumnTextMatch.Enabled = False
        Me.mnuPrepareColumnTextMatch.Name = "mnuPrepareColumnTextMatch"
        Me.mnuPrepareColumnTextMatch.Size = New System.Drawing.Size(152, 22)
        Me.mnuPrepareColumnTextMatch.Tag = "Match..."
        Me.mnuPrepareColumnTextMatch.Text = "Match..."
        Me.mnuPrepareColumnTextMatch.Visible = False
        '
        'mnuPrepareColumnTextDistance
        '
        Me.mnuPrepareColumnTextDistance.Name = "mnuPrepareColumnTextDistance"
        Me.mnuPrepareColumnTextDistance.Size = New System.Drawing.Size(152, 22)
        Me.mnuPrepareColumnTextDistance.Tag = "Distance..."
        Me.mnuPrepareColumnTextDistance.Text = "Distance..."
        '
        'mnuPrepareColumnDate
        '
        Me.mnuPrepareColumnDate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnDateGenerateDate, Me.mnuPrepareColumnDateMakeDate, Me.mnuPrepareColumnDateInfillMissingDates, Me.mnuPrepareColumnDateUseDate, Me.mnuPrepareColumnDateMakeTime, Me.mnuPrepareColumnDateUseTime})
        Me.mnuPrepareColumnDate.Name = "mnuPrepareColumnDate"
        Me.mnuPrepareColumnDate.Size = New System.Drawing.Size(186, 22)
        Me.mnuPrepareColumnDate.Text = "Column: Date"
        '
        'mnuPrepareColumnDateGenerateDate
        '
        Me.mnuPrepareColumnDateGenerateDate.Name = "mnuPrepareColumnDateGenerateDate"
        Me.mnuPrepareColumnDateGenerateDate.Size = New System.Drawing.Size(162, 22)
        Me.mnuPrepareColumnDateGenerateDate.Text = "Generate Dates..."
        '
        'mnuPrepareColumnDateMakeDate
        '
        Me.mnuPrepareColumnDateMakeDate.Name = "mnuPrepareColumnDateMakeDate"
        Me.mnuPrepareColumnDateMakeDate.Size = New System.Drawing.Size(162, 22)
        Me.mnuPrepareColumnDateMakeDate.Text = "Make Date..."
        '
        'mnuPrepareColumnDateInfillMissingDates
        '
        Me.mnuPrepareColumnDateInfillMissingDates.Name = "mnuPrepareColumnDateInfillMissingDates"
        Me.mnuPrepareColumnDateInfillMissingDates.Size = New System.Drawing.Size(162, 22)
        Me.mnuPrepareColumnDateInfillMissingDates.Text = "Fill Date Gaps..."
        '
        'mnuPrepareColumnDateUseDate
        '
        Me.mnuPrepareColumnDateUseDate.Name = "mnuPrepareColumnDateUseDate"
        Me.mnuPrepareColumnDateUseDate.Size = New System.Drawing.Size(162, 22)
        Me.mnuPrepareColumnDateUseDate.Text = "Use Date..."
        '
        'mnuPrepareColumnDateMakeTime
        '
        Me.mnuPrepareColumnDateMakeTime.Enabled = False
        Me.mnuPrepareColumnDateMakeTime.Name = "mnuPrepareColumnDateMakeTime"
        Me.mnuPrepareColumnDateMakeTime.Size = New System.Drawing.Size(162, 22)
        Me.mnuPrepareColumnDateMakeTime.Text = "Make Time..."
        Me.mnuPrepareColumnDateMakeTime.Visible = False
        '
        'mnuPrepareColumnDateUseTime
        '
        Me.mnuPrepareColumnDateUseTime.Enabled = False
        Me.mnuPrepareColumnDateUseTime.Name = "mnuPrepareColumnDateUseTime"
        Me.mnuPrepareColumnDateUseTime.Size = New System.Drawing.Size(162, 22)
        Me.mnuPrepareColumnDateUseTime.Text = "Use Time..."
        Me.mnuPrepareColumnDateUseTime.Visible = False
        '
        'mnuPrepareColumnDefine
        '
        Me.mnuPrepareColumnDefine.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnDefineConvertColumns, Me.ToolStripSeparator55, Me.mnuPrepareColumnDefineCircular})
        Me.mnuPrepareColumnDefine.Name = "mnuPrepareColumnDefine"
        Me.mnuPrepareColumnDefine.Size = New System.Drawing.Size(186, 22)
        Me.mnuPrepareColumnDefine.Text = "Column: Define"
        '
        'mnuPrepareColumnDefineConvertColumns
        '
        Me.mnuPrepareColumnDefineConvertColumns.Name = "mnuPrepareColumnDefineConvertColumns"
        Me.mnuPrepareColumnDefineConvertColumns.Size = New System.Drawing.Size(176, 22)
        Me.mnuPrepareColumnDefineConvertColumns.Text = "Convert Columns..."
        '
        'ToolStripSeparator55
        '
        Me.ToolStripSeparator55.Name = "ToolStripSeparator55"
        Me.ToolStripSeparator55.Size = New System.Drawing.Size(173, 6)
        '
        'mnuPrepareColumnDefineCircular
        '
        Me.mnuPrepareColumnDefineCircular.Name = "mnuPrepareColumnDefineCircular"
        Me.mnuPrepareColumnDefineCircular.Size = New System.Drawing.Size(176, 22)
        Me.mnuPrepareColumnDefineCircular.Text = "Circular..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(183, 6)
        '
        'mnuPrepareDataReshape
        '
        Me.mnuPrepareDataReshape.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnReshapeColumnSummaries, Me.mnuPrepareColumnReshapeGeneralSummaries, Me.ToolStripSeparator10, Me.mnuPrepareColumnReshapeStack, Me.mnuPrepareColumnReshapeUnstack, Me.mnuPrepareColumnReshapeMerge, Me.ToolStripSeparator11, Me.mnuPrepareAppendDataFrame, Me.mnuPrepareColumnReshapeSubset, Me.mnuPrepareColumnReshapeRandomSubset, Me.mnuPrepareColumnReshapeTranspose, Me.mnuPrepareDataReshapeScaleOrDistance})
        Me.mnuPrepareDataReshape.Name = "mnuPrepareDataReshape"
        Me.mnuPrepareDataReshape.Size = New System.Drawing.Size(186, 22)
        Me.mnuPrepareDataReshape.Tag = ""
        Me.mnuPrepareDataReshape.Text = "Data Reshape"
        '
        'mnuPrepareColumnReshapeColumnSummaries
        '
        Me.mnuPrepareColumnReshapeColumnSummaries.Name = "mnuPrepareColumnReshapeColumnSummaries"
        Me.mnuPrepareColumnReshapeColumnSummaries.Size = New System.Drawing.Size(197, 22)
        Me.mnuPrepareColumnReshapeColumnSummaries.Tag = "Column_Summaries..."
        Me.mnuPrepareColumnReshapeColumnSummaries.Text = "Column Summaries..."
        '
        'mnuPrepareColumnReshapeGeneralSummaries
        '
        Me.mnuPrepareColumnReshapeGeneralSummaries.Name = "mnuPrepareColumnReshapeGeneralSummaries"
        Me.mnuPrepareColumnReshapeGeneralSummaries.Size = New System.Drawing.Size(197, 22)
        Me.mnuPrepareColumnReshapeGeneralSummaries.Text = "General Summaries..."
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(194, 6)
        '
        'mnuPrepareColumnReshapeStack
        '
        Me.mnuPrepareColumnReshapeStack.Name = "mnuPrepareColumnReshapeStack"
        Me.mnuPrepareColumnReshapeStack.Size = New System.Drawing.Size(197, 22)
        Me.mnuPrepareColumnReshapeStack.Tag = "Stack..."
        Me.mnuPrepareColumnReshapeStack.Text = "Stack (Pivot Longer)..."
        '
        'mnuPrepareColumnReshapeUnstack
        '
        Me.mnuPrepareColumnReshapeUnstack.Name = "mnuPrepareColumnReshapeUnstack"
        Me.mnuPrepareColumnReshapeUnstack.Size = New System.Drawing.Size(197, 22)
        Me.mnuPrepareColumnReshapeUnstack.Tag = "Unstack..."
        Me.mnuPrepareColumnReshapeUnstack.Text = "Unstack (Pivot Wider)..."
        '
        'mnuPrepareColumnReshapeMerge
        '
        Me.mnuPrepareColumnReshapeMerge.Name = "mnuPrepareColumnReshapeMerge"
        Me.mnuPrepareColumnReshapeMerge.Size = New System.Drawing.Size(197, 22)
        Me.mnuPrepareColumnReshapeMerge.Tag = "Merge..."
        Me.mnuPrepareColumnReshapeMerge.Text = "Merge..."
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(194, 6)
        '
        'mnuPrepareAppendDataFrame
        '
        Me.mnuPrepareAppendDataFrame.Name = "mnuPrepareAppendDataFrame"
        Me.mnuPrepareAppendDataFrame.Size = New System.Drawing.Size(197, 22)
        Me.mnuPrepareAppendDataFrame.Text = "Append (Bind Rows)..."
        '
        'mnuPrepareColumnReshapeSubset
        '
        Me.mnuPrepareColumnReshapeSubset.Name = "mnuPrepareColumnReshapeSubset"
        Me.mnuPrepareColumnReshapeSubset.Size = New System.Drawing.Size(197, 22)
        Me.mnuPrepareColumnReshapeSubset.Tag = "Subset..."
        Me.mnuPrepareColumnReshapeSubset.Text = "Subset..."
        '
        'mnuPrepareColumnReshapeRandomSubset
        '
        Me.mnuPrepareColumnReshapeRandomSubset.Name = "mnuPrepareColumnReshapeRandomSubset"
        Me.mnuPrepareColumnReshapeRandomSubset.Size = New System.Drawing.Size(197, 22)
        Me.mnuPrepareColumnReshapeRandomSubset.Tag = "Random_Subset..."
        Me.mnuPrepareColumnReshapeRandomSubset.Text = "Random Subset..."
        '
        'mnuPrepareColumnReshapeTranspose
        '
        Me.mnuPrepareColumnReshapeTranspose.Name = "mnuPrepareColumnReshapeTranspose"
        Me.mnuPrepareColumnReshapeTranspose.Size = New System.Drawing.Size(197, 22)
        Me.mnuPrepareColumnReshapeTranspose.Tag = "Transpose..."
        Me.mnuPrepareColumnReshapeTranspose.Text = "Transpose..."
        '
        'mnuPrepareDataReshapeScaleOrDistance
        '
        Me.mnuPrepareDataReshapeScaleOrDistance.Name = "mnuPrepareDataReshapeScaleOrDistance"
        Me.mnuPrepareDataReshapeScaleOrDistance.Size = New System.Drawing.Size(197, 22)
        Me.mnuPrepareDataReshapeScaleOrDistance.Text = "Scale/Distance..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(183, 6)
        '
        'mnuPrepareKeysAndLinks
        '
        Me.mnuPrepareKeysAndLinks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareKeysAndLinksAddKey, Me.mnuPrepareKeysAndLinksViewAndRemoveKey, Me.mnuPrepareKeysAndLinksAddLink, Me.mnuPrepareKeysAndLinksViewAndRemoveKeys, Me.mnuPrepareKeysAndLinksAddComment})
        Me.mnuPrepareKeysAndLinks.Name = "mnuPrepareKeysAndLinks"
        Me.mnuPrepareKeysAndLinks.Size = New System.Drawing.Size(186, 22)
        Me.mnuPrepareKeysAndLinks.Text = "Keys and Links"
        '
        'mnuPrepareKeysAndLinksAddKey
        '
        Me.mnuPrepareKeysAndLinksAddKey.Name = "mnuPrepareKeysAndLinksAddKey"
        Me.mnuPrepareKeysAndLinksAddKey.Size = New System.Drawing.Size(207, 22)
        Me.mnuPrepareKeysAndLinksAddKey.Text = "Add Key..."
        '
        'mnuPrepareKeysAndLinksViewAndRemoveKey
        '
        Me.mnuPrepareKeysAndLinksViewAndRemoveKey.Name = "mnuPrepareKeysAndLinksViewAndRemoveKey"
        Me.mnuPrepareKeysAndLinksViewAndRemoveKey.Size = New System.Drawing.Size(207, 22)
        Me.mnuPrepareKeysAndLinksViewAndRemoveKey.Text = "View and Remove Keys..."
        '
        'mnuPrepareKeysAndLinksAddLink
        '
        Me.mnuPrepareKeysAndLinksAddLink.Name = "mnuPrepareKeysAndLinksAddLink"
        Me.mnuPrepareKeysAndLinksAddLink.Size = New System.Drawing.Size(207, 22)
        Me.mnuPrepareKeysAndLinksAddLink.Text = "Add Link..."
        '
        'mnuPrepareKeysAndLinksViewAndRemoveKeys
        '
        Me.mnuPrepareKeysAndLinksViewAndRemoveKeys.Name = "mnuPrepareKeysAndLinksViewAndRemoveKeys"
        Me.mnuPrepareKeysAndLinksViewAndRemoveKeys.Size = New System.Drawing.Size(207, 22)
        Me.mnuPrepareKeysAndLinksViewAndRemoveKeys.Text = "View and Remove Links..."
        '
        'mnuPrepareKeysAndLinksAddComment
        '
        Me.mnuPrepareKeysAndLinksAddComment.Name = "mnuPrepareKeysAndLinksAddComment"
        Me.mnuPrepareKeysAndLinksAddComment.Size = New System.Drawing.Size(207, 22)
        Me.mnuPrepareKeysAndLinksAddComment.Text = "Add Comment..."
        '
        'mnuPrepareDataObject
        '
        Me.mnuPrepareDataObject.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareDataObjectDataFrameMetadata, Me.mnuPrepareDataObjectRenameDataFrame, Me.mnuPrepareDataObjectReorderDataFrames, Me.mnuPrepareDataObjectCopyDataFrame, Me.mnuPrepareDataObjectDeleteDataFrame, Me.ToolStripSeparator21, Me.mnuPrepareDataObjectHideDataframes, Me.mnuPrepareDataObjectMetadata, Me.mnuPrepareDataObjectRenameMetadata, Me.mnuPrepareDataObjectReorderMetadata, Me.mnuPrepareDataObjectDeleteMetadata})
        Me.mnuPrepareDataObject.Name = "mnuPrepareDataObject"
        Me.mnuPrepareDataObject.Size = New System.Drawing.Size(186, 22)
        Me.mnuPrepareDataObject.Tag = "Data_Object"
        Me.mnuPrepareDataObject.Text = "Data Object"
        '
        'mnuPrepareDataObjectDataFrameMetadata
        '
        Me.mnuPrepareDataObjectDataFrameMetadata.Enabled = False
        Me.mnuPrepareDataObjectDataFrameMetadata.Name = "mnuPrepareDataObjectDataFrameMetadata"
        Me.mnuPrepareDataObjectDataFrameMetadata.Size = New System.Drawing.Size(210, 22)
        Me.mnuPrepareDataObjectDataFrameMetadata.Tag = "Data_Frame_Metadata..."
        Me.mnuPrepareDataObjectDataFrameMetadata.Text = "Data Frame Metadata..."
        Me.mnuPrepareDataObjectDataFrameMetadata.Visible = False
        '
        'mnuPrepareDataObjectRenameDataFrame
        '
        Me.mnuPrepareDataObjectRenameDataFrame.Name = "mnuPrepareDataObjectRenameDataFrame"
        Me.mnuPrepareDataObjectRenameDataFrame.Size = New System.Drawing.Size(210, 22)
        Me.mnuPrepareDataObjectRenameDataFrame.Tag = "ReName_Data_Frame..."
        Me.mnuPrepareDataObjectRenameDataFrame.Text = "Rename Data Frame..."
        '
        'mnuPrepareDataObjectReorderDataFrames
        '
        Me.mnuPrepareDataObjectReorderDataFrames.Name = "mnuPrepareDataObjectReorderDataFrames"
        Me.mnuPrepareDataObjectReorderDataFrames.Size = New System.Drawing.Size(210, 22)
        Me.mnuPrepareDataObjectReorderDataFrames.Tag = "Reorder_Data_Frames..."
        Me.mnuPrepareDataObjectReorderDataFrames.Text = "Reorder Data Frames..."
        '
        'mnuPrepareDataObjectCopyDataFrame
        '
        Me.mnuPrepareDataObjectCopyDataFrame.Name = "mnuPrepareDataObjectCopyDataFrame"
        Me.mnuPrepareDataObjectCopyDataFrame.Size = New System.Drawing.Size(210, 22)
        Me.mnuPrepareDataObjectCopyDataFrame.Tag = "Copy_Data_Frame..."
        Me.mnuPrepareDataObjectCopyDataFrame.Text = "Copy Data Frame..."
        '
        'mnuPrepareDataObjectDeleteDataFrame
        '
        Me.mnuPrepareDataObjectDeleteDataFrame.Name = "mnuPrepareDataObjectDeleteDataFrame"
        Me.mnuPrepareDataObjectDeleteDataFrame.Size = New System.Drawing.Size(210, 22)
        Me.mnuPrepareDataObjectDeleteDataFrame.Tag = "Delete_Data_Frame..."
        Me.mnuPrepareDataObjectDeleteDataFrame.Text = "Delete Data Frames..."
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(207, 6)
        '
        'mnuPrepareDataObjectHideDataframes
        '
        Me.mnuPrepareDataObjectHideDataframes.Name = "mnuPrepareDataObjectHideDataframes"
        Me.mnuPrepareDataObjectHideDataframes.Size = New System.Drawing.Size(210, 22)
        Me.mnuPrepareDataObjectHideDataframes.Text = "Hide/Show Data Frames..."
        '
        'mnuPrepareDataObjectMetadata
        '
        Me.mnuPrepareDataObjectMetadata.Name = "mnuPrepareDataObjectMetadata"
        Me.mnuPrepareDataObjectMetadata.Size = New System.Drawing.Size(210, 22)
        Me.mnuPrepareDataObjectMetadata.Tag = "Metadata..."
        Me.mnuPrepareDataObjectMetadata.Text = "Metadata..."
        '
        'mnuPrepareDataObjectRenameMetadata
        '
        Me.mnuPrepareDataObjectRenameMetadata.Enabled = False
        Me.mnuPrepareDataObjectRenameMetadata.Name = "mnuPrepareDataObjectRenameMetadata"
        Me.mnuPrepareDataObjectRenameMetadata.Size = New System.Drawing.Size(210, 22)
        Me.mnuPrepareDataObjectRenameMetadata.Tag = "Rename_Metadata..."
        Me.mnuPrepareDataObjectRenameMetadata.Text = "Rename Metadata..."
        Me.mnuPrepareDataObjectRenameMetadata.Visible = False
        '
        'mnuPrepareDataObjectReorderMetadata
        '
        Me.mnuPrepareDataObjectReorderMetadata.Enabled = False
        Me.mnuPrepareDataObjectReorderMetadata.Name = "mnuPrepareDataObjectReorderMetadata"
        Me.mnuPrepareDataObjectReorderMetadata.Size = New System.Drawing.Size(210, 22)
        Me.mnuPrepareDataObjectReorderMetadata.Tag = "Reorder_Metadata..."
        Me.mnuPrepareDataObjectReorderMetadata.Text = "Reorder Metadata..."
        Me.mnuPrepareDataObjectReorderMetadata.Visible = False
        '
        'mnuPrepareDataObjectDeleteMetadata
        '
        Me.mnuPrepareDataObjectDeleteMetadata.Enabled = False
        Me.mnuPrepareDataObjectDeleteMetadata.Name = "mnuPrepareDataObjectDeleteMetadata"
        Me.mnuPrepareDataObjectDeleteMetadata.Size = New System.Drawing.Size(210, 22)
        Me.mnuPrepareDataObjectDeleteMetadata.Tag = "Delete_Metadata..."
        Me.mnuPrepareDataObjectDeleteMetadata.Text = "Delete Metadata..."
        Me.mnuPrepareDataObjectDeleteMetadata.Visible = False
        '
        'mnuPrepareRObjects
        '
        Me.mnuPrepareRObjects.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareRObjectsView, Me.mnuPrepareRObjectsRename, Me.mnuPrepareRObjectsReorder, Me.mnuPrepareRObjectsDelete})
        Me.mnuPrepareRObjects.Name = "mnuPrepareRObjects"
        Me.mnuPrepareRObjects.Size = New System.Drawing.Size(186, 22)
        Me.mnuPrepareRObjects.Tag = "R_Objects"
        Me.mnuPrepareRObjects.Text = "R Objects"
        '
        'mnuPrepareRObjectsView
        '
        Me.mnuPrepareRObjectsView.Name = "mnuPrepareRObjectsView"
        Me.mnuPrepareRObjectsView.Size = New System.Drawing.Size(126, 22)
        Me.mnuPrepareRObjectsView.Tag = "View..."
        Me.mnuPrepareRObjectsView.Text = "View..."
        '
        'mnuPrepareRObjectsRename
        '
        Me.mnuPrepareRObjectsRename.Name = "mnuPrepareRObjectsRename"
        Me.mnuPrepareRObjectsRename.Size = New System.Drawing.Size(126, 22)
        Me.mnuPrepareRObjectsRename.Tag = "Rename..."
        Me.mnuPrepareRObjectsRename.Text = "Rename..."
        '
        'mnuPrepareRObjectsReorder
        '
        Me.mnuPrepareRObjectsReorder.Name = "mnuPrepareRObjectsReorder"
        Me.mnuPrepareRObjectsReorder.Size = New System.Drawing.Size(126, 22)
        Me.mnuPrepareRObjectsReorder.Tag = "Reorder"
        Me.mnuPrepareRObjectsReorder.Text = "Reorder..."
        '
        'mnuPrepareRObjectsDelete
        '
        Me.mnuPrepareRObjectsDelete.Name = "mnuPrepareRObjectsDelete"
        Me.mnuPrepareRObjectsDelete.Size = New System.Drawing.Size(126, 22)
        Me.mnuPrepareRObjectsDelete.Tag = "Delete..."
        Me.mnuPrepareRObjectsDelete.Text = "Delete..."
        '
        'mnuStructured
        '
        Me.mnuStructured.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStructuredCircular, Me.mnuStructuredLow_Flow, Me.mnuStructuredSurvival, Me.mnuStructuredTimeSeries, Me.ToolStripSeparator63, Me.mnuStructuredClimatic, Me.mnuStructuredProcurement, Me.mnuStructuredOptionByContext})
        Me.mnuStructured.Name = "mnuStructured"
        Me.mnuStructured.Size = New System.Drawing.Size(74, 20)
        Me.mnuStructured.Text = "Structured"
        '
        'mnuStructuredCircular
        '
        Me.mnuStructuredCircular.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStructuredCircularDefine, Me.mnuStructuredCircularCalculator, Me.mnuStructuredCircularSummaries, Me.ToolStripSeparator46, Me.mnuStructuredCircularDensityPlot, Me.ToolStripSeparator67, Me.mnuStructuredCircularWindRose, Me.mnuStructuredCircularWindPollutionRose, Me.mnuStructuredCircularOtherRosePlots, Me.ToolStripSeparator68, Me.mnuStructuredCircularCirclize})
        Me.mnuStructuredCircular.Name = "mnuStructuredCircular"
        Me.mnuStructuredCircular.Size = New System.Drawing.Size(186, 22)
        Me.mnuStructuredCircular.Text = "Circular"
        '
        'mnuStructuredCircularDefine
        '
        Me.mnuStructuredCircularDefine.Name = "mnuStructuredCircularDefine"
        Me.mnuStructuredCircularDefine.Size = New System.Drawing.Size(192, 22)
        Me.mnuStructuredCircularDefine.Text = "Define..."
        '
        'mnuStructuredCircularCalculator
        '
        Me.mnuStructuredCircularCalculator.Name = "mnuStructuredCircularCalculator"
        Me.mnuStructuredCircularCalculator.Size = New System.Drawing.Size(192, 22)
        Me.mnuStructuredCircularCalculator.Text = "Calculator..."
        '
        'mnuStructuredCircularSummaries
        '
        Me.mnuStructuredCircularSummaries.Name = "mnuStructuredCircularSummaries"
        Me.mnuStructuredCircularSummaries.Size = New System.Drawing.Size(192, 22)
        Me.mnuStructuredCircularSummaries.Text = "Summaries..."
        '
        'ToolStripSeparator46
        '
        Me.ToolStripSeparator46.Name = "ToolStripSeparator46"
        Me.ToolStripSeparator46.Size = New System.Drawing.Size(189, 6)
        '
        'mnuStructuredCircularDensityPlot
        '
        Me.mnuStructuredCircularDensityPlot.Name = "mnuStructuredCircularDensityPlot"
        Me.mnuStructuredCircularDensityPlot.Size = New System.Drawing.Size(192, 22)
        Me.mnuStructuredCircularDensityPlot.Text = "Circular Plots..."
        '
        'ToolStripSeparator67
        '
        Me.ToolStripSeparator67.Name = "ToolStripSeparator67"
        Me.ToolStripSeparator67.Size = New System.Drawing.Size(189, 6)
        '
        'mnuStructuredCircularWindRose
        '
        Me.mnuStructuredCircularWindRose.Name = "mnuStructuredCircularWindRose"
        Me.mnuStructuredCircularWindRose.Size = New System.Drawing.Size(192, 22)
        Me.mnuStructuredCircularWindRose.Text = "Wind Rose..."
        '
        'mnuStructuredCircularWindPollutionRose
        '
        Me.mnuStructuredCircularWindPollutionRose.Name = "mnuStructuredCircularWindPollutionRose"
        Me.mnuStructuredCircularWindPollutionRose.Size = New System.Drawing.Size(192, 22)
        Me.mnuStructuredCircularWindPollutionRose.Text = "Wind/Pollution Rose..."
        '
        'mnuStructuredCircularOtherRosePlots
        '
        Me.mnuStructuredCircularOtherRosePlots.Name = "mnuStructuredCircularOtherRosePlots"
        Me.mnuStructuredCircularOtherRosePlots.Size = New System.Drawing.Size(192, 22)
        Me.mnuStructuredCircularOtherRosePlots.Text = "Other Rose Plots"
        '
        'ToolStripSeparator68
        '
        Me.ToolStripSeparator68.Name = "ToolStripSeparator68"
        Me.ToolStripSeparator68.Size = New System.Drawing.Size(189, 6)
        '
        'mnuStructuredCircularCirclize
        '
        Me.mnuStructuredCircularCirclize.Enabled = False
        Me.mnuStructuredCircularCirclize.Name = "mnuStructuredCircularCirclize"
        Me.mnuStructuredCircularCirclize.Size = New System.Drawing.Size(192, 22)
        Me.mnuStructuredCircularCirclize.Text = "Circlize..."
        Me.mnuStructuredCircularCirclize.Visible = False
        '
        'mnuStructuredLow_Flow
        '
        Me.mnuStructuredLow_Flow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStructuredLow_FlowDefine})
        Me.mnuStructuredLow_Flow.Name = "mnuStructuredLow_Flow"
        Me.mnuStructuredLow_Flow.Size = New System.Drawing.Size(186, 22)
        Me.mnuStructuredLow_Flow.Text = "Low_Flow"
        '
        'mnuStructuredLow_FlowDefine
        '
        Me.mnuStructuredLow_FlowDefine.Name = "mnuStructuredLow_FlowDefine"
        Me.mnuStructuredLow_FlowDefine.Size = New System.Drawing.Size(117, 22)
        Me.mnuStructuredLow_FlowDefine.Text = "Define..."
        '
        'mnuStructuredSurvival
        '
        Me.mnuStructuredSurvival.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStructuredSurvivalDefine})
        Me.mnuStructuredSurvival.Name = "mnuStructuredSurvival"
        Me.mnuStructuredSurvival.Size = New System.Drawing.Size(186, 22)
        Me.mnuStructuredSurvival.Text = "Survival"
        '
        'mnuStructuredSurvivalDefine
        '
        Me.mnuStructuredSurvivalDefine.Name = "mnuStructuredSurvivalDefine"
        Me.mnuStructuredSurvivalDefine.Size = New System.Drawing.Size(117, 22)
        Me.mnuStructuredSurvivalDefine.Text = "Define..."
        '
        'mnuStructuredTimeSeries
        '
        Me.mnuStructuredTimeSeries.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStructuredTimeSeriesDefine, Me.ToolStripSeparator60, Me.mnuStructuredTimeSeriesDescribe, Me.ToolStripSeparator61, Me.mnuStructuredTimeSeriesModel, Me.ToolStripSeparator62})
        Me.mnuStructuredTimeSeries.Name = "mnuStructuredTimeSeries"
        Me.mnuStructuredTimeSeries.Size = New System.Drawing.Size(186, 22)
        Me.mnuStructuredTimeSeries.Text = "Time Series"
        '
        'mnuStructuredTimeSeriesDefine
        '
        Me.mnuStructuredTimeSeriesDefine.Name = "mnuStructuredTimeSeriesDefine"
        Me.mnuStructuredTimeSeriesDefine.Size = New System.Drawing.Size(119, 22)
        Me.mnuStructuredTimeSeriesDefine.Text = "Define..."
        '
        'ToolStripSeparator60
        '
        Me.ToolStripSeparator60.Name = "ToolStripSeparator60"
        Me.ToolStripSeparator60.Size = New System.Drawing.Size(116, 6)
        '
        'mnuStructuredTimeSeriesDescribe
        '
        Me.mnuStructuredTimeSeriesDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStructuredTimeSeriesDescribeOneVariable, Me.mnuStructuredTimeSeriesDescribeGeneral})
        Me.mnuStructuredTimeSeriesDescribe.Name = "mnuStructuredTimeSeriesDescribe"
        Me.mnuStructuredTimeSeriesDescribe.Size = New System.Drawing.Size(119, 22)
        Me.mnuStructuredTimeSeriesDescribe.Text = "Describe"
        '
        'mnuStructuredTimeSeriesDescribeOneVariable
        '
        Me.mnuStructuredTimeSeriesDescribeOneVariable.Name = "mnuStructuredTimeSeriesDescribeOneVariable"
        Me.mnuStructuredTimeSeriesDescribeOneVariable.Size = New System.Drawing.Size(149, 22)
        Me.mnuStructuredTimeSeriesDescribeOneVariable.Text = "One Variable..."
        '
        'mnuStructuredTimeSeriesDescribeGeneral
        '
        Me.mnuStructuredTimeSeriesDescribeGeneral.Name = "mnuStructuredTimeSeriesDescribeGeneral"
        Me.mnuStructuredTimeSeriesDescribeGeneral.Size = New System.Drawing.Size(149, 22)
        Me.mnuStructuredTimeSeriesDescribeGeneral.Text = "General..."
        '
        'ToolStripSeparator61
        '
        Me.ToolStripSeparator61.Name = "ToolStripSeparator61"
        Me.ToolStripSeparator61.Size = New System.Drawing.Size(116, 6)
        '
        'mnuStructuredTimeSeriesModel
        '
        Me.mnuStructuredTimeSeriesModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStructuredTimeSeriesModelOneVariable, Me.mnuStructuredTimeSeriesModelGeneral})
        Me.mnuStructuredTimeSeriesModel.Name = "mnuStructuredTimeSeriesModel"
        Me.mnuStructuredTimeSeriesModel.Size = New System.Drawing.Size(119, 22)
        Me.mnuStructuredTimeSeriesModel.Text = "Model"
        '
        'mnuStructuredTimeSeriesModelOneVariable
        '
        Me.mnuStructuredTimeSeriesModelOneVariable.Name = "mnuStructuredTimeSeriesModelOneVariable"
        Me.mnuStructuredTimeSeriesModelOneVariable.Size = New System.Drawing.Size(149, 22)
        Me.mnuStructuredTimeSeriesModelOneVariable.Text = "One Variable..."
        '
        'mnuStructuredTimeSeriesModelGeneral
        '
        Me.mnuStructuredTimeSeriesModelGeneral.Name = "mnuStructuredTimeSeriesModelGeneral"
        Me.mnuStructuredTimeSeriesModelGeneral.Size = New System.Drawing.Size(149, 22)
        Me.mnuStructuredTimeSeriesModelGeneral.Text = "General..."
        '
        'ToolStripSeparator62
        '
        Me.ToolStripSeparator62.Name = "ToolStripSeparator62"
        Me.ToolStripSeparator62.Size = New System.Drawing.Size(116, 6)
        '
        'ToolStripSeparator63
        '
        Me.ToolStripSeparator63.Name = "ToolStripSeparator63"
        Me.ToolStripSeparator63.Size = New System.Drawing.Size(183, 6)
        '
        'mnuStructuredClimatic
        '
        Me.mnuStructuredClimatic.Name = "mnuStructuredClimatic"
        Me.mnuStructuredClimatic.Size = New System.Drawing.Size(186, 22)
        Me.mnuStructuredClimatic.Text = "Climatic..."
        '
        'mnuStructuredProcurement
        '
        Me.mnuStructuredProcurement.Name = "mnuStructuredProcurement"
        Me.mnuStructuredProcurement.Size = New System.Drawing.Size(186, 22)
        Me.mnuStructuredProcurement.Text = "Procurement..."
        '
        'mnuStructuredOptionByContext
        '
        Me.mnuStructuredOptionByContext.Name = "mnuStructuredOptionByContext"
        Me.mnuStructuredOptionByContext.Size = New System.Drawing.Size(186, 22)
        Me.mnuStructuredOptionByContext.Text = "Options by Context..."
        '
        'mnuProcurement
        '
        Me.mnuProcurement.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementOpenFromLibrary, Me.mnuProcurementDefineData, Me.mnuProcurementPrepare, Me.mnuProcurementDescribe, Me.mnuProcurementMapping, Me.mnuProcurementModel, Me.ToolStripSeparator45, Me.mnuProcurementDefineRedFlags, Me.mnuProcurementUseCRI})
        Me.mnuProcurement.Name = "mnuProcurement"
        Me.mnuProcurement.Size = New System.Drawing.Size(88, 20)
        Me.mnuProcurement.Text = "Procurement"
        '
        'mnuProcurementOpenFromLibrary
        '
        Me.mnuProcurementOpenFromLibrary.Name = "mnuProcurementOpenFromLibrary"
        Me.mnuProcurementOpenFromLibrary.Size = New System.Drawing.Size(217, 22)
        Me.mnuProcurementOpenFromLibrary.Text = "Open From Library..."
        '
        'mnuProcurementDefineData
        '
        Me.mnuProcurementDefineData.Name = "mnuProcurementDefineData"
        Me.mnuProcurementDefineData.Size = New System.Drawing.Size(217, 22)
        Me.mnuProcurementDefineData.Text = "Define Procurement Data..."
        '
        'mnuProcurementPrepare
        '
        Me.mnuProcurementPrepare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementPrepareFilterByCountry, Me.ToolStripSeparator42, Me.mnuProcurementPrepareDefineContractValueCategories, Me.mnuProcurementPrepareRecodeNumericIntoQuantiles, Me.mnuProcurementPrepareSetFactorReferenceLevel, Me.mnuProcurementPrepareUseAwardDate, Me.ToolStripSeparator43, Me.mnuProcurementPrepareSummariseRedFlagsByCountryorOther, Me.mnuProcurementPrepareSummariseRedFlagsByCountryAndYearorOther, Me.mnuProcurementPrepareMergeAdditionalData})
        Me.mnuProcurementPrepare.Name = "mnuProcurementPrepare"
        Me.mnuProcurementPrepare.Size = New System.Drawing.Size(217, 22)
        Me.mnuProcurementPrepare.Text = "Prepare"
        '
        'mnuProcurementPrepareFilterByCountry
        '
        Me.mnuProcurementPrepareFilterByCountry.Name = "mnuProcurementPrepareFilterByCountry"
        Me.mnuProcurementPrepareFilterByCountry.Size = New System.Drawing.Size(358, 22)
        Me.mnuProcurementPrepareFilterByCountry.Text = "Filter by Country (or other)..."
        '
        'ToolStripSeparator42
        '
        Me.ToolStripSeparator42.Name = "ToolStripSeparator42"
        Me.ToolStripSeparator42.Size = New System.Drawing.Size(355, 6)
        '
        'mnuProcurementPrepareDefineContractValueCategories
        '
        Me.mnuProcurementPrepareDefineContractValueCategories.Name = "mnuProcurementPrepareDefineContractValueCategories"
        Me.mnuProcurementPrepareDefineContractValueCategories.Size = New System.Drawing.Size(358, 22)
        Me.mnuProcurementPrepareDefineContractValueCategories.Text = "Define Contract Value Categories..."
        '
        'mnuProcurementPrepareRecodeNumericIntoQuantiles
        '
        Me.mnuProcurementPrepareRecodeNumericIntoQuantiles.Name = "mnuProcurementPrepareRecodeNumericIntoQuantiles"
        Me.mnuProcurementPrepareRecodeNumericIntoQuantiles.Size = New System.Drawing.Size(358, 22)
        Me.mnuProcurementPrepareRecodeNumericIntoQuantiles.Text = "Recode Numeric into Quantiles..."
        '
        'mnuProcurementPrepareSetFactorReferenceLevel
        '
        Me.mnuProcurementPrepareSetFactorReferenceLevel.Name = "mnuProcurementPrepareSetFactorReferenceLevel"
        Me.mnuProcurementPrepareSetFactorReferenceLevel.Size = New System.Drawing.Size(358, 22)
        Me.mnuProcurementPrepareSetFactorReferenceLevel.Text = "Set Factor Reference Level..."
        '
        'mnuProcurementPrepareUseAwardDate
        '
        Me.mnuProcurementPrepareUseAwardDate.Name = "mnuProcurementPrepareUseAwardDate"
        Me.mnuProcurementPrepareUseAwardDate.Size = New System.Drawing.Size(358, 22)
        Me.mnuProcurementPrepareUseAwardDate.Text = "Use Award Date (or other)..."
        '
        'ToolStripSeparator43
        '
        Me.ToolStripSeparator43.Name = "ToolStripSeparator43"
        Me.ToolStripSeparator43.Size = New System.Drawing.Size(355, 6)
        '
        'mnuProcurementPrepareSummariseRedFlagsByCountryorOther
        '
        Me.mnuProcurementPrepareSummariseRedFlagsByCountryorOther.Name = "mnuProcurementPrepareSummariseRedFlagsByCountryorOther"
        Me.mnuProcurementPrepareSummariseRedFlagsByCountryorOther.Size = New System.Drawing.Size(358, 22)
        Me.mnuProcurementPrepareSummariseRedFlagsByCountryorOther.Text = "Summarise Red Flags by Country (or other)..."
        '
        'mnuProcurementPrepareSummariseRedFlagsByCountryAndYearorOther
        '
        Me.mnuProcurementPrepareSummariseRedFlagsByCountryAndYearorOther.Name = "mnuProcurementPrepareSummariseRedFlagsByCountryAndYearorOther"
        Me.mnuProcurementPrepareSummariseRedFlagsByCountryAndYearorOther.Size = New System.Drawing.Size(358, 22)
        Me.mnuProcurementPrepareSummariseRedFlagsByCountryAndYearorOther.Text = "Summarise Red Flags by Country and Year (or other)..."
        '
        'mnuProcurementPrepareMergeAdditionalData
        '
        Me.mnuProcurementPrepareMergeAdditionalData.Name = "mnuProcurementPrepareMergeAdditionalData"
        Me.mnuProcurementPrepareMergeAdditionalData.Size = New System.Drawing.Size(358, 22)
        Me.mnuProcurementPrepareMergeAdditionalData.Text = "Merge Additional Data..."
        '
        'mnuProcurementDescribe
        '
        Me.mnuProcurementDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementDescribeOneVariableSummarise, Me.mnuProcurementDescribeOneVariableGraph, Me.ToolStripSeparator44, Me.mnuProcurementDescribeCategorical, Me.mnuProcurementDescribeNumeric})
        Me.mnuProcurementDescribe.Name = "mnuProcurementDescribe"
        Me.mnuProcurementDescribe.Size = New System.Drawing.Size(217, 22)
        Me.mnuProcurementDescribe.Text = "Describe"
        '
        'mnuProcurementDescribeOneVariableSummarise
        '
        Me.mnuProcurementDescribeOneVariableSummarise.Name = "mnuProcurementDescribeOneVariableSummarise"
        Me.mnuProcurementDescribeOneVariableSummarise.Size = New System.Drawing.Size(211, 22)
        Me.mnuProcurementDescribeOneVariableSummarise.Text = "One Variable Summarise..."
        '
        'mnuProcurementDescribeOneVariableGraph
        '
        Me.mnuProcurementDescribeOneVariableGraph.Name = "mnuProcurementDescribeOneVariableGraph"
        Me.mnuProcurementDescribeOneVariableGraph.Size = New System.Drawing.Size(211, 22)
        Me.mnuProcurementDescribeOneVariableGraph.Text = "One Variable Graph..."
        '
        'ToolStripSeparator44
        '
        Me.ToolStripSeparator44.Name = "ToolStripSeparator44"
        Me.ToolStripSeparator44.Size = New System.Drawing.Size(208, 6)
        '
        'mnuProcurementDescribeCategorical
        '
        Me.mnuProcurementDescribeCategorical.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementDescribeCategoricalOneVarFreq, Me.mnuProcurementDescribeCategoricalTwoVarFreq, Me.ToolStripSeparator52, Me.mnuProcurementDescribeCategoricalBarCharts, Me.mnuProcurementDescribeCategoricalMosaic, Me.mnuProcurementDescribeCategoricalTreemap, Me.DisplayTopNToolStripMenuItem})
        Me.mnuProcurementDescribeCategorical.Name = "mnuProcurementDescribeCategorical"
        Me.mnuProcurementDescribeCategorical.Size = New System.Drawing.Size(211, 22)
        Me.mnuProcurementDescribeCategorical.Text = "Categorical"
        '
        'mnuProcurementDescribeCategoricalOneVarFreq
        '
        Me.mnuProcurementDescribeCategoricalOneVarFreq.Name = "mnuProcurementDescribeCategoricalOneVarFreq"
        Me.mnuProcurementDescribeCategoricalOneVarFreq.Size = New System.Drawing.Size(319, 22)
        Me.mnuProcurementDescribeCategoricalOneVarFreq.Text = "One Variable Frequencies..."
        '
        'mnuProcurementDescribeCategoricalTwoVarFreq
        '
        Me.mnuProcurementDescribeCategoricalTwoVarFreq.Name = "mnuProcurementDescribeCategoricalTwoVarFreq"
        Me.mnuProcurementDescribeCategoricalTwoVarFreq.Size = New System.Drawing.Size(319, 22)
        Me.mnuProcurementDescribeCategoricalTwoVarFreq.Text = "Two Variable Frequencies by Sector (or other)..."
        '
        'ToolStripSeparator52
        '
        Me.ToolStripSeparator52.Name = "ToolStripSeparator52"
        Me.ToolStripSeparator52.Size = New System.Drawing.Size(316, 6)
        '
        'mnuProcurementDescribeCategoricalBarCharts
        '
        Me.mnuProcurementDescribeCategoricalBarCharts.Name = "mnuProcurementDescribeCategoricalBarCharts"
        Me.mnuProcurementDescribeCategoricalBarCharts.Size = New System.Drawing.Size(319, 22)
        Me.mnuProcurementDescribeCategoricalBarCharts.Text = "Bar Chart..."
        '
        'mnuProcurementDescribeCategoricalMosaic
        '
        Me.mnuProcurementDescribeCategoricalMosaic.Name = "mnuProcurementDescribeCategoricalMosaic"
        Me.mnuProcurementDescribeCategoricalMosaic.Size = New System.Drawing.Size(319, 22)
        Me.mnuProcurementDescribeCategoricalMosaic.Text = "Mosaic Plot..."
        '
        'mnuProcurementDescribeCategoricalTreemap
        '
        Me.mnuProcurementDescribeCategoricalTreemap.Name = "mnuProcurementDescribeCategoricalTreemap"
        Me.mnuProcurementDescribeCategoricalTreemap.Size = New System.Drawing.Size(319, 22)
        Me.mnuProcurementDescribeCategoricalTreemap.Text = "Treemap..."
        '
        'DisplayTopNToolStripMenuItem
        '
        Me.DisplayTopNToolStripMenuItem.Name = "DisplayTopNToolStripMenuItem"
        Me.DisplayTopNToolStripMenuItem.Size = New System.Drawing.Size(319, 22)
        Me.DisplayTopNToolStripMenuItem.Text = "Display Top N..."
        '
        'mnuProcurementDescribeNumeric
        '
        Me.mnuProcurementDescribeNumeric.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementDescribeNumericBoxplot, Me.HistogramToolStripMenuItem, Me.ToolStripSeparator53, Me.mnuProcurementDescribeNumericCorrelationsRedFlagsOrOthers})
        Me.mnuProcurementDescribeNumeric.Name = "mnuProcurementDescribeNumeric"
        Me.mnuProcurementDescribeNumeric.Size = New System.Drawing.Size(211, 22)
        Me.mnuProcurementDescribeNumeric.Text = "Numeric"
        '
        'mnuProcurementDescribeNumericBoxplot
        '
        Me.mnuProcurementDescribeNumericBoxplot.Name = "mnuProcurementDescribeNumericBoxplot"
        Me.mnuProcurementDescribeNumericBoxplot.Size = New System.Drawing.Size(258, 22)
        Me.mnuProcurementDescribeNumericBoxplot.Text = "Boxplot..."
        '
        'HistogramToolStripMenuItem
        '
        Me.HistogramToolStripMenuItem.Name = "HistogramToolStripMenuItem"
        Me.HistogramToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.HistogramToolStripMenuItem.Text = "Histogram..."
        '
        'ToolStripSeparator53
        '
        Me.ToolStripSeparator53.Name = "ToolStripSeparator53"
        Me.ToolStripSeparator53.Size = New System.Drawing.Size(255, 6)
        '
        'mnuProcurementDescribeNumericCorrelationsRedFlagsOrOthers
        '
        Me.mnuProcurementDescribeNumericCorrelationsRedFlagsOrOthers.Name = "mnuProcurementDescribeNumericCorrelationsRedFlagsOrOthers"
        Me.mnuProcurementDescribeNumericCorrelationsRedFlagsOrOthers.Size = New System.Drawing.Size(258, 22)
        Me.mnuProcurementDescribeNumericCorrelationsRedFlagsOrOthers.Text = "Correlations (Red Flags or others)..."
        '
        'mnuProcurementMapping
        '
        Me.mnuProcurementMapping.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementMappingMapCountryValues})
        Me.mnuProcurementMapping.Name = "mnuProcurementMapping"
        Me.mnuProcurementMapping.Size = New System.Drawing.Size(217, 22)
        Me.mnuProcurementMapping.Text = "Mapping"
        '
        'mnuProcurementMappingMapCountryValues
        '
        Me.mnuProcurementMappingMapCountryValues.Name = "mnuProcurementMappingMapCountryValues"
        Me.mnuProcurementMappingMapCountryValues.Size = New System.Drawing.Size(189, 22)
        Me.mnuProcurementMappingMapCountryValues.Text = "Map Country Values..."
        '
        'mnuProcurementModel
        '
        Me.mnuProcurementModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementModelDefineCorruption, Me.mnuProcurementModelFitModelToolStripMenuItem})
        Me.mnuProcurementModel.Name = "mnuProcurementModel"
        Me.mnuProcurementModel.Size = New System.Drawing.Size(217, 22)
        Me.mnuProcurementModel.Text = "Model"
        '
        'mnuProcurementModelDefineCorruption
        '
        Me.mnuProcurementModelDefineCorruption.Name = "mnuProcurementModelDefineCorruption"
        Me.mnuProcurementModelDefineCorruption.Size = New System.Drawing.Size(233, 22)
        Me.mnuProcurementModelDefineCorruption.Text = "Define Corruption Indicators..."
        '
        'mnuProcurementModelFitModelToolStripMenuItem
        '
        Me.mnuProcurementModelFitModelToolStripMenuItem.Name = "mnuProcurementModelFitModelToolStripMenuItem"
        Me.mnuProcurementModelFitModelToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.mnuProcurementModelFitModelToolStripMenuItem.Text = "Fit Model..."
        '
        'ToolStripSeparator45
        '
        Me.ToolStripSeparator45.Name = "ToolStripSeparator45"
        Me.ToolStripSeparator45.Size = New System.Drawing.Size(214, 6)
        '
        'mnuProcurementDefineRedFlags
        '
        Me.mnuProcurementDefineRedFlags.Name = "mnuProcurementDefineRedFlags"
        Me.mnuProcurementDefineRedFlags.Size = New System.Drawing.Size(217, 22)
        Me.mnuProcurementDefineRedFlags.Text = "Define Red Flag Variables..."
        '
        'mnuProcurementUseCRI
        '
        Me.mnuProcurementUseCRI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementCTFVCalculateCRI, Me.mnuProcurementUseCRISummariseCRIbyCountry})
        Me.mnuProcurementUseCRI.Name = "mnuProcurementUseCRI"
        Me.mnuProcurementUseCRI.Size = New System.Drawing.Size(217, 22)
        Me.mnuProcurementUseCRI.Text = "Corruption Risk Index (CRI)"
        '
        'mnuProcurementCTFVCalculateCRI
        '
        Me.mnuProcurementCTFVCalculateCRI.Name = "mnuProcurementCTFVCalculateCRI"
        Me.mnuProcurementCTFVCalculateCRI.Size = New System.Drawing.Size(278, 22)
        Me.mnuProcurementCTFVCalculateCRI.Text = "Define Corruption Risk Index (CRI)..."
        '
        'mnuProcurementUseCRISummariseCRIbyCountry
        '
        Me.mnuProcurementUseCRISummariseCRIbyCountry.Name = "mnuProcurementUseCRISummariseCRIbyCountry"
        Me.mnuProcurementUseCRISummariseCRIbyCountry.Size = New System.Drawing.Size(278, 22)
        Me.mnuProcurementUseCRISummariseCRIbyCountry.Text = "Summarise CRI by Country (or other)..."
        '
        'mnuOptionsByContext
        '
        Me.mnuOptionsByContext.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextCheckData, Me.mnuOptionsByContextDefineOptionsByContexts, Me.mnuOptionsByContextPrepare, Me.mnuOptionsByContextDescribe, Me.mnuOptionsByContextModel})
        Me.mnuOptionsByContext.Name = "mnuOptionsByContext"
        Me.mnuOptionsByContext.Size = New System.Drawing.Size(122, 20)
        Me.mnuOptionsByContext.Text = "Options by Context"
        '
        'mnuOptionsByContextCheckData
        '
        Me.mnuOptionsByContextCheckData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextCheckDataDuplicates, Me.mnuOptionsByContextCheckDataCompareColumns, Me.ToolStripSeparator47, Me.mnuOptionsByContextCheckDataOneVariableSummarise, Me.mnuOptionsByContextCheckDataOneVariableGraph, Me.mnuOptionsByContextCheckDataOneVariableFrequencies})
        Me.mnuOptionsByContextCheckData.Name = "mnuOptionsByContextCheckData"
        Me.mnuOptionsByContextCheckData.Size = New System.Drawing.Size(250, 22)
        Me.mnuOptionsByContextCheckData.Text = "Check Data"
        '
        'mnuOptionsByContextCheckDataDuplicates
        '
        Me.mnuOptionsByContextCheckDataDuplicates.Name = "mnuOptionsByContextCheckDataDuplicates"
        Me.mnuOptionsByContextCheckDataDuplicates.Size = New System.Drawing.Size(215, 22)
        Me.mnuOptionsByContextCheckDataDuplicates.Text = "Duplicates..."
        '
        'mnuOptionsByContextCheckDataCompareColumns
        '
        Me.mnuOptionsByContextCheckDataCompareColumns.Name = "mnuOptionsByContextCheckDataCompareColumns"
        Me.mnuOptionsByContextCheckDataCompareColumns.Size = New System.Drawing.Size(215, 22)
        Me.mnuOptionsByContextCheckDataCompareColumns.Text = "Compare Columns..."
        '
        'ToolStripSeparator47
        '
        Me.ToolStripSeparator47.Name = "ToolStripSeparator47"
        Me.ToolStripSeparator47.Size = New System.Drawing.Size(212, 6)
        '
        'mnuOptionsByContextCheckDataOneVariableSummarise
        '
        Me.mnuOptionsByContextCheckDataOneVariableSummarise.Name = "mnuOptionsByContextCheckDataOneVariableSummarise"
        Me.mnuOptionsByContextCheckDataOneVariableSummarise.Size = New System.Drawing.Size(215, 22)
        Me.mnuOptionsByContextCheckDataOneVariableSummarise.Text = "One Variable Summarise..."
        '
        'mnuOptionsByContextCheckDataOneVariableGraph
        '
        Me.mnuOptionsByContextCheckDataOneVariableGraph.Name = "mnuOptionsByContextCheckDataOneVariableGraph"
        Me.mnuOptionsByContextCheckDataOneVariableGraph.Size = New System.Drawing.Size(215, 22)
        Me.mnuOptionsByContextCheckDataOneVariableGraph.Text = "One Variable Graph..."
        '
        'mnuOptionsByContextCheckDataOneVariableFrequencies
        '
        Me.mnuOptionsByContextCheckDataOneVariableFrequencies.Name = "mnuOptionsByContextCheckDataOneVariableFrequencies"
        Me.mnuOptionsByContextCheckDataOneVariableFrequencies.Size = New System.Drawing.Size(215, 22)
        Me.mnuOptionsByContextCheckDataOneVariableFrequencies.Text = "One Variable Frequencies..."
        '
        'mnuOptionsByContextDefineOptionsByContexts
        '
        Me.mnuOptionsByContextDefineOptionsByContexts.Name = "mnuOptionsByContextDefineOptionsByContexts"
        Me.mnuOptionsByContextDefineOptionsByContexts.Size = New System.Drawing.Size(250, 22)
        Me.mnuOptionsByContextDefineOptionsByContexts.Text = "Define Options by Context Data..."
        '
        'mnuOptionsByContextPrepare
        '
        Me.mnuOptionsByContextPrepare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions, Me.ToolStripSeparator48, Me.mnuOptionsByContextMergeAdditionalData, Me.mnuOptionsByContextPrepareStack, Me.mnuOptionsByContextPrepareUnstack})
        Me.mnuOptionsByContextPrepare.Name = "mnuOptionsByContextPrepare"
        Me.mnuOptionsByContextPrepare.Size = New System.Drawing.Size(250, 22)
        Me.mnuOptionsByContextPrepare.Text = "Prepare"
        '
        'mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions
        '
        Me.mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions.Name = "mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions"
        Me.mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions.Size = New System.Drawing.Size(282, 22)
        Me.mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions.Text = "Calculate Difference Between Options..."
        '
        'ToolStripSeparator48
        '
        Me.ToolStripSeparator48.Name = "ToolStripSeparator48"
        Me.ToolStripSeparator48.Size = New System.Drawing.Size(279, 6)
        '
        'mnuOptionsByContextMergeAdditionalData
        '
        Me.mnuOptionsByContextMergeAdditionalData.Name = "mnuOptionsByContextMergeAdditionalData"
        Me.mnuOptionsByContextMergeAdditionalData.Size = New System.Drawing.Size(282, 22)
        Me.mnuOptionsByContextMergeAdditionalData.Text = "Merge Additional Data..."
        '
        'mnuOptionsByContextPrepareStack
        '
        Me.mnuOptionsByContextPrepareStack.Name = "mnuOptionsByContextPrepareStack"
        Me.mnuOptionsByContextPrepareStack.Size = New System.Drawing.Size(282, 22)
        Me.mnuOptionsByContextPrepareStack.Text = "Stack (Pivot Longer)..."
        '
        'mnuOptionsByContextPrepareUnstack
        '
        Me.mnuOptionsByContextPrepareUnstack.Name = "mnuOptionsByContextPrepareUnstack"
        Me.mnuOptionsByContextPrepareUnstack.Size = New System.Drawing.Size(282, 22)
        Me.mnuOptionsByContextPrepareUnstack.Text = "Unstack (Pivot Wider)..."
        '
        'mnuOptionsByContextDescribe
        '
        Me.mnuOptionsByContextDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextDescribeCompareTwoTreatments, Me.mnuOptionsByContextDescribeCompareMultipleTreatments, Me.mnuOptionsByContextDescribeBoxplot})
        Me.mnuOptionsByContextDescribe.Name = "mnuOptionsByContextDescribe"
        Me.mnuOptionsByContextDescribe.Size = New System.Drawing.Size(250, 22)
        Me.mnuOptionsByContextDescribe.Text = "Describe"
        '
        'mnuOptionsByContextDescribeCompareTwoTreatments
        '
        Me.mnuOptionsByContextDescribeCompareTwoTreatments.Name = "mnuOptionsByContextDescribeCompareTwoTreatments"
        Me.mnuOptionsByContextDescribeCompareTwoTreatments.Size = New System.Drawing.Size(224, 22)
        Me.mnuOptionsByContextDescribeCompareTwoTreatments.Text = "Compare Two Options..."
        '
        'mnuOptionsByContextDescribeCompareMultipleTreatments
        '
        Me.mnuOptionsByContextDescribeCompareMultipleTreatments.Enabled = False
        Me.mnuOptionsByContextDescribeCompareMultipleTreatments.Name = "mnuOptionsByContextDescribeCompareMultipleTreatments"
        Me.mnuOptionsByContextDescribeCompareMultipleTreatments.Size = New System.Drawing.Size(224, 22)
        Me.mnuOptionsByContextDescribeCompareMultipleTreatments.Text = "Compare Multiple Options..."
        '
        'mnuOptionsByContextDescribeBoxplot
        '
        Me.mnuOptionsByContextDescribeBoxplot.Name = "mnuOptionsByContextDescribeBoxplot"
        Me.mnuOptionsByContextDescribeBoxplot.Size = New System.Drawing.Size(224, 22)
        Me.mnuOptionsByContextDescribeBoxplot.Text = "Boxplot..."
        '
        'mnuOptionsByContextModel
        '
        Me.mnuOptionsByContextModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextModelFitModel, Me.mnuOptionsByContextGeneralFitModel})
        Me.mnuOptionsByContextModel.Name = "mnuOptionsByContextModel"
        Me.mnuOptionsByContextModel.Size = New System.Drawing.Size(250, 22)
        Me.mnuOptionsByContextModel.Text = "Model"
        '
        'mnuOptionsByContextModelFitModel
        '
        Me.mnuOptionsByContextModelFitModel.Name = "mnuOptionsByContextModelFitModel"
        Me.mnuOptionsByContextModelFitModel.Size = New System.Drawing.Size(176, 22)
        Me.mnuOptionsByContextModelFitModel.Text = "Fit Model..."
        '
        'mnuOptionsByContextGeneralFitModel
        '
        Me.mnuOptionsByContextGeneralFitModel.Name = "mnuOptionsByContextGeneralFitModel"
        Me.mnuOptionsByContextGeneralFitModel.Size = New System.Drawing.Size(176, 22)
        Me.mnuOptionsByContextGeneralFitModel.Text = "General Fit Model..."
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuToolsRunRCode, Me.mnuToolsRestartR, Me.mnuToolsCheckForUpdates, Me.mnuToolsClearOutputWindow, Me.ToolStripSeparator5, Me.mnuToolsSaveCurrentOptions, Me.mnuToolsLoadOptions, Me.mnuToolsInstallRPackage, Me.mnuToolsOptions})
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(46, 20)
        Me.mnuTools.Text = "Tools"
        '
        'mnuToolsRunRCode
        '
        Me.mnuToolsRunRCode.Enabled = False
        Me.mnuToolsRunRCode.Name = "mnuToolsRunRCode"
        Me.mnuToolsRunRCode.Size = New System.Drawing.Size(198, 22)
        Me.mnuToolsRunRCode.Tag = "Run_R_Code..."
        Me.mnuToolsRunRCode.Text = "Run R Code..."
        '
        'mnuToolsRestartR
        '
        Me.mnuToolsRestartR.Enabled = False
        Me.mnuToolsRestartR.Name = "mnuToolsRestartR"
        Me.mnuToolsRestartR.Size = New System.Drawing.Size(198, 22)
        Me.mnuToolsRestartR.Tag = "Restart_R"
        Me.mnuToolsRestartR.Text = "Restart R"
        '
        'mnuToolsCheckForUpdates
        '
        Me.mnuToolsCheckForUpdates.Enabled = False
        Me.mnuToolsCheckForUpdates.Name = "mnuToolsCheckForUpdates"
        Me.mnuToolsCheckForUpdates.Size = New System.Drawing.Size(198, 22)
        Me.mnuToolsCheckForUpdates.Tag = "Check_for_Updates..."
        Me.mnuToolsCheckForUpdates.Text = "Check for Updates..."
        '
        'mnuToolsClearOutputWindow
        '
        Me.mnuToolsClearOutputWindow.Name = "mnuToolsClearOutputWindow"
        Me.mnuToolsClearOutputWindow.Size = New System.Drawing.Size(198, 22)
        Me.mnuToolsClearOutputWindow.Tag = "Clear_Output_Window..."
        Me.mnuToolsClearOutputWindow.Text = "Clear Output Window..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(195, 6)
        '
        'mnuToolsSaveCurrentOptions
        '
        Me.mnuToolsSaveCurrentOptions.Enabled = False
        Me.mnuToolsSaveCurrentOptions.Name = "mnuToolsSaveCurrentOptions"
        Me.mnuToolsSaveCurrentOptions.Size = New System.Drawing.Size(198, 22)
        Me.mnuToolsSaveCurrentOptions.Tag = "Save_Current_Options..."
        Me.mnuToolsSaveCurrentOptions.Text = "Save Current Options..."
        '
        'mnuToolsLoadOptions
        '
        Me.mnuToolsLoadOptions.Enabled = False
        Me.mnuToolsLoadOptions.Name = "mnuToolsLoadOptions"
        Me.mnuToolsLoadOptions.Size = New System.Drawing.Size(198, 22)
        Me.mnuToolsLoadOptions.Tag = "Load_Options..."
        Me.mnuToolsLoadOptions.Text = "Load Options..."
        '
        'mnuToolsInstallRPackage
        '
        Me.mnuToolsInstallRPackage.Name = "mnuToolsInstallRPackage"
        Me.mnuToolsInstallRPackage.Size = New System.Drawing.Size(198, 22)
        Me.mnuToolsInstallRPackage.Text = "Install R Package..."
        '
        'mnuToolsOptions
        '
        Me.mnuToolsOptions.Name = "mnuToolsOptions"
        Me.mnuToolsOptions.Size = New System.Drawing.Size(198, 22)
        Me.mnuToolsOptions.Tag = "Options..."
        Me.mnuToolsOptions.Text = "Options..."
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ExportToolStripMenuItem.Text = "Export..."
        '
        'splOverall
        '
        Me.splOverall.BackColor = System.Drawing.Color.LightGray
        Me.splOverall.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splOverall.Location = New System.Drawing.Point(0, 61)
        Me.splOverall.Name = "splOverall"
        Me.splOverall.Orientation = System.Windows.Forms.Orientation.Horizontal
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
        Me.splOverall.Size = New System.Drawing.Size(834, 399)
        Me.splOverall.SplitterDistance = 168
        Me.splOverall.SplitterWidth = 5
        Me.splOverall.TabIndex = 10
        '
        'splExtraWindows
        '
        Me.splExtraWindows.BackColor = System.Drawing.Color.LightGray
        Me.splExtraWindows.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splExtraWindows.Location = New System.Drawing.Point(0, 0)
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
        Me.splExtraWindows.Size = New System.Drawing.Size(834, 168)
        Me.splExtraWindows.SplitterDistance = 255
        Me.splExtraWindows.SplitterWidth = 5
        Me.splExtraWindows.TabIndex = 0
        '
        'splMetadata
        '
        Me.splMetadata.BackColor = System.Drawing.Color.LightGray
        Me.splMetadata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splMetadata.Location = New System.Drawing.Point(0, 0)
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
        Me.splMetadata.Size = New System.Drawing.Size(255, 168)
        Me.splMetadata.SplitterDistance = 72
        Me.splMetadata.SplitterWidth = 5
        Me.splMetadata.TabIndex = 0
        '
        'ucrColumnMeta
        '
        Me.ucrColumnMeta.AutoSize = True
        Me.ucrColumnMeta.BackColor = System.Drawing.SystemColors.Control
        Me.ucrColumnMeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrColumnMeta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrColumnMeta.Location = New System.Drawing.Point(0, 0)
        Me.ucrColumnMeta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrColumnMeta.Name = "ucrColumnMeta"
        Me.ucrColumnMeta.Size = New System.Drawing.Size(72, 168)
        Me.ucrColumnMeta.TabIndex = 0
        '
        'ucrDataFrameMeta
        '
        Me.ucrDataFrameMeta.AutoSize = True
        Me.ucrDataFrameMeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrDataFrameMeta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrDataFrameMeta.Location = New System.Drawing.Point(0, 0)
        Me.ucrDataFrameMeta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrDataFrameMeta.Name = "ucrDataFrameMeta"
        Me.ucrDataFrameMeta.Size = New System.Drawing.Size(178, 168)
        Me.ucrDataFrameMeta.TabIndex = 0
        '
        'splLogScript
        '
        Me.splLogScript.BackColor = System.Drawing.Color.LightGray
        Me.splLogScript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splLogScript.Location = New System.Drawing.Point(0, 0)
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
        Me.splLogScript.Size = New System.Drawing.Size(574, 168)
        Me.splLogScript.SplitterDistance = 174
        Me.splLogScript.SplitterWidth = 5
        Me.splLogScript.TabIndex = 0
        '
        'ucrLogWindow
        '
        Me.ucrLogWindow.AutoSize = True
        Me.ucrLogWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrLogWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrLogWindow.Location = New System.Drawing.Point(0, 0)
        Me.ucrLogWindow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrLogWindow.Name = "ucrLogWindow"
        Me.ucrLogWindow.Size = New System.Drawing.Size(174, 168)
        Me.ucrLogWindow.TabIndex = 0
        '
        'ucrScriptWindow
        '
        Me.ucrScriptWindow.AutoSize = True
        Me.ucrScriptWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrScriptWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrScriptWindow.Location = New System.Drawing.Point(0, 0)
        Me.ucrScriptWindow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrScriptWindow.Name = "ucrScriptWindow"
        Me.ucrScriptWindow.Size = New System.Drawing.Size(395, 168)
        Me.ucrScriptWindow.TabIndex = 0
        Me.ucrScriptWindow.Tag = "Script_Window"
        '
        'splDataOutput
        '
        Me.splDataOutput.BackColor = System.Drawing.Color.LightGray
        Me.splDataOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splDataOutput.Location = New System.Drawing.Point(0, 0)
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
        Me.splDataOutput.Size = New System.Drawing.Size(834, 226)
        Me.splDataOutput.SplitterDistance = 384
        Me.splDataOutput.SplitterWidth = 5
        Me.splDataOutput.TabIndex = 0
        '
        'ucrDataViewer
        '
        Me.ucrDataViewer.AutoSize = True
        Me.ucrDataViewer.BackColor = System.Drawing.SystemColors.Control
        Me.ucrDataViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrDataViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrDataViewer.grdCurrSheet = Nothing
        Me.ucrDataViewer.Location = New System.Drawing.Point(0, 0)
        Me.ucrDataViewer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrDataViewer.Name = "ucrDataViewer"
        Me.ucrDataViewer.Size = New System.Drawing.Size(384, 226)
        Me.ucrDataViewer.TabIndex = 0
        Me.ucrDataViewer.Tag = "Data_View"
        '
        'ucrOutput
        '
        Me.ucrOutput.AutoSize = True
        Me.ucrOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrOutput.Location = New System.Drawing.Point(0, 0)
        Me.ucrOutput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrOutput.Name = "ucrOutput"
        Me.ucrOutput.Size = New System.Drawing.Size(445, 226)
        Me.ucrOutput.TabIndex = 0
        '
        'mnuRViewer
        '
        Me.mnuRViewer.Name = "mnuRViewer"
        Me.mnuRViewer.Size = New System.Drawing.Size(180, 22)
        Me.mnuRViewer.Text = "R Viewer..."
        Me.mnuRViewer.ToolTipText = "View Last Graph"
        '
        'mnuPlotly
        '
        Me.mnuPlotly.Name = "mnuPlotly"
        Me.mnuPlotly.Size = New System.Drawing.Size(180, 22)
        Me.mnuPlotly.Text = "Plotly..."
        Me.mnuPlotly.ToolTipText = "View Interactive Plot"
        '
        'mnuColumnMetadata
        '
        Me.mnuColumnMetadata.Name = "mnuColumnMetadata"
        Me.mnuColumnMetadata.Size = New System.Drawing.Size(196, 22)
        Me.mnuColumnMetadata.Text = "Column Metadata..."
        Me.mnuColumnMetadata.ToolTipText = "Column Metadata"
        '
        'mnuDataFrameMetadata
        '
        Me.mnuDataFrameMetadata.Name = "mnuDataFrameMetadata"
        Me.mnuDataFrameMetadata.Size = New System.Drawing.Size(196, 22)
        Me.mnuDataFrameMetadata.Text = "Data Frame Metadata..."
        Me.mnuDataFrameMetadata.ToolTipText = "Data Frame Metadata"
        '
        'mnuScriptFile
        '
        Me.mnuScriptFile.Name = "mnuScriptFile"
        Me.mnuScriptFile.Size = New System.Drawing.Size(180, 22)
        Me.mnuScriptFile.Text = "Script Window..."
        Me.mnuScriptFile.ToolTipText = "Script Window"
        '
        'mnuLogFile
        '
        Me.mnuLogFile.Name = "mnuLogFile"
        Me.mnuLogFile.Size = New System.Drawing.Size(180, 22)
        Me.mnuLogFile.Text = "Log Window..."
        Me.mnuLogFile.ToolTipText = "Log Window"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(834, 482)
        Me.Controls.Add(Me.splOverall)
        Me.Controls.Add(Me.stsStrip)
        Me.Controls.Add(Me.Tool_strip)
        Me.Controls.Add(Me.mnuBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuBar
        Me.Name = "frmMain"
        Me.Text = "R-Instat"
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
        Me.splMetadata.Panel1.PerformLayout()
        Me.splMetadata.Panel2.ResumeLayout(False)
        Me.splMetadata.Panel2.PerformLayout()
        CType(Me.splMetadata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splMetadata.ResumeLayout(False)
        Me.splLogScript.Panel1.ResumeLayout(False)
        Me.splLogScript.Panel1.PerformLayout()
        Me.splLogScript.Panel2.ResumeLayout(False)
        Me.splLogScript.Panel2.PerformLayout()
        CType(Me.splLogScript, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splLogScript.ResumeLayout(False)
        Me.splDataOutput.Panel1.ResumeLayout(False)
        Me.splDataOutput.Panel1.PerformLayout()
        Me.splDataOutput.Panel2.ResumeLayout(False)
        Me.splDataOutput.Panel2.PerformLayout()
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
    Friend WithEvents mnuClimaticCropCropCoefficients As ToolStripMenuItem
    Friend WithEvents mnuClimaticCropWaterSatisfactionIndex As ToolStripMenuItem
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
    Friend WithEvents separator1 As ToolStripSeparator
    Friend WithEvents mnuTbEditLastDialog As ToolStripButton
    Friend WithEvents separator2 As ToolStripSeparator
    Friend WithEvents mnuTbHelp As ToolStripButton
    Private WithEvents mnuBar As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNewDataFrame As ToolStripMenuItem
    Friend WithEvents mnuFileImportFromFile As ToolStripMenuItem
    Friend WithEvents mnuFileImportFromLibrary As ToolStripMenuItem
    Friend WithEvents tlSeparatorFile As ToolStripSeparator
    Friend WithEvents mnuPrepare As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrame As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameViewData As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataReshape As ToolStripMenuItem
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
    Friend WithEvents mnuPrepareColumnCalculate As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameConvertColumns As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnNumericPermuteRows As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnReshapeColumnSummaries As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnReshapeRandomSubset As ToolStripMenuItem
    Friend WithEvents mnuFileExport As ToolStripMenuItem
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
    Friend WithEvents mnuPrepareDataFrameColumnStructure As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameReorderColumns As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameInsertColumnsRows As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameDeleteColumnsRows As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameProtectColumn As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameHideColumns As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameFreezeColumns As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnNumericRegularSequence As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnNumericRandomSamples As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnFactorRecodeNumeric As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnTextFindReplace As ToolStripMenuItem
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
    Friend WithEvents mnuDescribeGeneralTabulation As ToolStripMenuItem
    Friend WithEvents mnuDescribeGeneralGraphics As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificTablesGraphs As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificFrequency As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificSummary As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificMultipleResponse As ToolStripMenuItem
    Friend WithEvents mnuModelProbabilityDistributions As ToolStripMenuItem
    Friend WithEvents mnuModelProbabilityDistributionsCompareModels As ToolStripMenuItem
    Friend WithEvents mnuModelProbabilityDistributionsRandomSamplesUseModel As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
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
    Friend WithEvents mnuPrepareCheckDataPrePareToShareSdcPackage As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataframeColourByProperty As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataObjectHideDataframes As ToolStripMenuItem
    Friend WithEvents mnuPrepareAppendDataFrame As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAsDataAs As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAsOutputAs As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAsLogAs As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAsScriptAs As ToolStripMenuItem
    Friend WithEvents mnuFileCloseData As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator23 As ToolStripSeparator
    Friend WithEvents mnuClimaticClimateMethods As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsDataManipulation As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsDataManipulationStartOfRain As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsDataManipulationEndOfRain As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsDataManipulationExportCPTToTabular As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsDataManipulationDayMonth As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsDataManipulationDisplayDaily As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsDataManipulationDisplaySpellLength As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsDataManipulationExportForPICSA As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsDataManipulationExtremeEvents As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsDataManipulationMissingData As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsDataManipulationMissingDataTable As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationMonthlySummaries As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsDataManipulationOutputForCD As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsGraphics As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsGraphicsClipBoxPlot As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsGraphicsCliplot As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsGraphicsMissingValues As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsGraphicsHistogram As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsGraphicsCumExceedance As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsGraphicsBoxplot As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsGraphicsInventory As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsGraphicsAnnualRainfall As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsGraphicsRainCount As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsGraphicsTimeseries As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsGraphicsWindrose As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsGraphicsMultipleLines As ToolStripMenuItem
    Friend WithEvents mnuClmateMethodThreeSummaries As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsModel As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsAdditional As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsAdditionalOutputForCPT As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsAdditionalRainsStatistics As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsAdditionalSeasonalSummary As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain As ToolStripMenuItem
    Friend WithEvents mnuClimaticClimateMethodsAdditionalWaterBalance As ToolStripMenuItem
    Friend WithEvents mnuClimateMethodsCreateClimateObject As ToolStripMenuItem
    Friend WithEvents mnuClimaticFile As ToolStripMenuItem
    Friend WithEvents mnuClimaticFileImportSST As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnNumericEnter As ToolStripMenuItem
    Friend WithEvents mnuFileImportFromODK As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator25 As ToolStripSeparator
    Friend WithEvents mnuPrepareColumnDate As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnDateGenerateDate As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnDateUseDate As ToolStripMenuItem
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
    Friend WithEvents mnuDescribeSpecificPointPlot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificLineSmoothPlot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificHistogramDensityFrequencyPlot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificBoxplotJitterViolinPlot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificDotPlot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificMapPlot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificBarPieChart As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnDateMakeDate As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnDateMakeTime As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnDateUseTime As ToolStripMenuItem
    Friend WithEvents mnuPrepareCheckDataExportOpenRefine As ToolStripMenuItem
    Friend WithEvents mnuPrepareCheckDataImportOpenRefine As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents mnuHelpHelpIntroduction As ToolStripMenuItem
    Friend WithEvents mnuHelpHistFAQ As ToolStripMenuItem
    Friend WithEvents mnuHelpGetingStarted As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator28 As ToolStripSeparator
    Friend WithEvents mnuHelpMenus As ToolStripMenuItem
    Friend WithEvents mnuHelpAboutR As ToolStripMenuItem
    Friend WithEvents mnuHelpRPackagesCommands As ToolStripMenuItem
    Friend WithEvents mnuHelpDataset As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator29 As ToolStripSeparator
    Friend WithEvents mnuHelpGuide As ToolStripMenuItem
    Friend WithEvents mnuHelpGuidesCaseStudy As ToolStripMenuItem
    Friend WithEvents mnuHelpGuideGlosary As ToolStripMenuItem
    Friend WithEvents mnuhelpGuidesMore As ToolStripMenuItem
    Friend WithEvents mnuClimaticFileExportToCPT As ToolStripMenuItem
    Friend WithEvents mnuClimateFileImportfromClimSoft As ToolStripMenuItem
    Friend WithEvents mnuClimaticFileImportfromCliData As ToolStripMenuItem
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
    Friend WithEvents mnuClimaticModel As ToolStripMenuItem
    Friend WithEvents mnuClimaticModelMarkovModelling As ToolStripMenuItem
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
    Friend WithEvents mnuClimaticModelCircular As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents mnuClimaticPrepareClimaticSummaries As ToolStripMenuItem
    Friend WithEvents mnuClimaticCheckDataInventory As ToolStripMenuItem
    Friend WithEvents mnuClimaticCheckDataDisplayDaily As ToolStripMenuItem
    Friend WithEvents mnuClimaticCheckDataQCRainfall As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As ToolStripSeparator
    Friend WithEvents mnuProcurementDefineData As ToolStripMenuItem
    Friend WithEvents mnuClimaticSCFSupportCumulativeExceedanceGraph As ToolStripMenuItem
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
    Friend WithEvents mnuFileImportFromCSPRO As ToolStripMenuItem
    Friend WithEvents mnuFileImportFromDatabases As ToolStripMenuItem
    Friend WithEvents mnuClimaticFileImportandTidyNetCDF As ToolStripMenuItem
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
    Friend WithEvents mnuClimaticFileImportfromIRIDataLibrary As ToolStripMenuItem
    Friend WithEvents mnuDescribeOneVariableRatingData As ToolStripMenuItem
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
    Friend WithEvents mnuFileExportExportDataSet As ToolStripMenuItem
    Friend WithEvents mnuFileExportExportRWorkspace As ToolStripMenuItem
    Friend WithEvents mnuFileExportExportGraphAsImage As ToolStripMenuItem
    Friend WithEvents mnuFileExportExportRObjectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDescribeGeneralUseSummaries As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator38 As ToolStripSeparator
    Friend WithEvents mnuClimaticDescribeWindSpeedDirectionWindRose As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificCummulativeDistribution As ToolStripMenuItem
    Friend WithEvents mnuProcurementUseCRISummariseCRIbyCountry As ToolStripMenuItem
    Friend WithEvents mnuPrepareCheckDataDuplicates As ToolStripMenuItem
    Friend WithEvents mnuClimaticCheckDataBoxplot As ToolStripMenuItem
    Friend WithEvents mnuCMSAF As ToolStripMenuItem
    Friend WithEvents mnuClimaticCMSAFPlotRegion As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnDateInfillMissingDates As ToolStripMenuItem
    Friend WithEvents mnuTbOpenFromLibrary As ToolStripButton
    Friend WithEvents mnuTbDataView As ToolStripButton
    Friend WithEvents mnuTbOutput As ToolStripButton
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
    Friend WithEvents ToolStripSeparator37 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator42 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator43 As ToolStripSeparator
    Friend WithEvents mnuProcurementPrepareSummariseRedFlagsByCountryorOther As ToolStripMenuItem
    Friend WithEvents mnuProcurementPrepareSummariseRedFlagsByCountryAndYearorOther As ToolStripMenuItem
    Friend WithEvents mnuProcurementDescribeOneVariableSummarise As ToolStripMenuItem
    Friend WithEvents mnuProcurementDescribeOneVariableGraph As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator44 As ToolStripSeparator
    Friend WithEvents mnuProcurementMapping As ToolStripMenuItem
    Friend WithEvents mnuProcurementMappingMapCountryValues As ToolStripMenuItem
    Friend WithEvents mnuProcurementModelDefineCorruption As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator45 As ToolStripSeparator
    Friend WithEvents mnuProcurementCTFVCalculateCRI As ToolStripMenuItem
    Friend WithEvents mnuFileImportandTidyNetCDFFile As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificMosaic As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificParallelCoordinatePlot As ToolStripMenuItem
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
    Friend WithEvents mnuClimaticFileImportandTidyShapefile As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineMerge As ToolStripMenuItem
    Friend WithEvents mnuClimaticCMSAFExporttoCMSAFRToolbox As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareConversions As ToolStripMenuItem
    Friend WithEvents mnuHelpAcknowledgments As ToolStripMenuItem
    Friend WithEvents mnuProcurementDescribeCategorical As ToolStripMenuItem
    Friend WithEvents mnuProcurementDescribeNumeric As ToolStripMenuItem
    Friend WithEvents mnuProcurementDescribeCategoricalOneVarFreq As ToolStripMenuItem
    Friend WithEvents mnuProcurementDescribeCategoricalTwoVarFreq As ToolStripMenuItem
    Friend WithEvents mnuProcurementDescribeNumericCorrelationsRedFlagsOrOthers As ToolStripMenuItem
    Friend WithEvents mnuProcurementDescribeCategoricalBarCharts As ToolStripMenuItem
    Friend WithEvents mnuProcurementDescribeCategoricalMosaic As ToolStripMenuItem
    Friend WithEvents mnuProcurementDescribeNumericBoxplot As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator52 As ToolStripSeparator
    Friend WithEvents HistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator53 As ToolStripSeparator
    Friend WithEvents mnuProcurementOpenFromLibrary As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineUnstack As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineStack As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineAppend As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator54 As ToolStripSeparator
    Friend WithEvents mnuClimaticPrepareClimdex As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareSPI As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator51 As ToolStripSeparator
    Friend WithEvents mnuClimaticMapping As ToolStripMenuItem
    Friend WithEvents mnuHelpWindows As ToolStripMenuItem
    Friend WithEvents mnuHelpDataViewSpreadsheet As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineDuplicates As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineOneVariableGraph As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineOneVariableFrequencies As ToolStripMenuItem
    Friend WithEvents mnuModelUseModel As ToolStripMenuItem
    Friend WithEvents mnuClimaticPICSACumExeedenceGraph As ToolStripMenuItem
    Friend WithEvents mnuClimaticCheckDataQCTemperatures As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnDefine As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnDefineConvertColumns As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator55 As ToolStripSeparator
    Friend WithEvents mnuPrepareColumnDefineCircular As ToolStripMenuItem
    Friend WithEvents mnuProcurementDescribeCategoricalTreemap As ToolStripMenuItem

    Friend WithEvents mnuToolsInstallRPackage As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnNumericRowSummaries As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnNumericTransform As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnNumericPolynomials As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator56 As ToolStripSeparator
    Friend WithEvents mnuPrepareCalculator As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnFactorCountInFactor As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents mnuTbLog As ToolStripSplitButton
    Friend WithEvents mnuScriptWindow As ToolStripMenuItem
    Friend WithEvents mnuLogWindow As ToolStripMenuItem
    Friend WithEvents mnuMetadata As ToolStripSplitButton
    Friend WithEvents mnuColumnMetadat As ToolStripMenuItem
    Friend WithEvents mnuDataFrameMetadat As ToolStripMenuItem
    Friend WithEvents mnuRViewer As ToolStripMenuItem
    Friend WithEvents mnuPlotly As ToolStripMenuItem
    Friend WithEvents mnuColumnMetadata As ToolStripMenuItem
    Friend WithEvents mnuDataFrameMetadata As ToolStripMenuItem
    Friend WithEvents mnuScriptFile As ToolStripMenuItem
    Friend WithEvents mnuLogFile As ToolStripMenuItem
    Friend WithEvents mnuModelFitModel As ToolStripMenuItem
    Friend WithEvents mnuModelFitModelOneVariable As ToolStripMenuItem
    Friend WithEvents mnuModelFitModelTwoVariables As ToolStripMenuItem
    Friend WithEvents mnuModelFitModelThreeVariables As ToolStripMenuItem
    Friend WithEvents mnuModelFitModelFourVariables As ToolStripMenuItem
    Friend WithEvents mnuModelFitModelGeneral As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator24 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator57 As ToolStripSeparator
    Friend WithEvents mnuModelFitModelModelKeyboard As ToolStripMenuItem
    Friend WithEvents mnuModelUseModelOneVariable As ToolStripMenuItem
    Friend WithEvents mnuModelUseModelTwoVariables As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator59 As ToolStripSeparator
    Friend WithEvents mnuModelUseModelGlance As ToolStripMenuItem
    Friend WithEvents mnuModelUseModelTidy As ToolStripMenuItem
    Friend WithEvents mnuModelUseModelAugment As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator58 As ToolStripSeparator
    Friend WithEvents mnuModelUseModelUseModelKeyboard As ToolStripMenuItem
    Friend WithEvents mnuModelCompareModels As ToolStripMenuItem
    Friend WithEvents mnuModelCompareModelsOneVariable As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents DisplayTopNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuModelFitModelHypothesisTestsKeyboard As ToolStripMenuItem
    Friend WithEvents mnuClimaticCheckDataHomogenization As ToolStripMenuItem
    Friend WithEvents mnuStructured As ToolStripMenuItem
    Friend WithEvents mnuStructuredCircular As ToolStripMenuItem
    Friend WithEvents mnuStructuredCircularDefine As ToolStripMenuItem
    Friend WithEvents mnuStructuredLow_Flow As ToolStripMenuItem
    Friend WithEvents mnuStructuredLow_FlowDefine As ToolStripMenuItem
    Friend WithEvents mnuStructuredSurvival As ToolStripMenuItem
    Friend WithEvents mnuStructuredSurvivalDefine As ToolStripMenuItem
    Friend WithEvents mnuStructuredTimeSeries As ToolStripMenuItem
    Friend WithEvents mnuStructuredTimeSeriesDefine As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator60 As ToolStripSeparator
    Friend WithEvents mnuStructuredTimeSeriesDescribe As ToolStripMenuItem
    Friend WithEvents mnuStructuredTimeSeriesDescribeOneVariable As ToolStripMenuItem
    Friend WithEvents mnuStructuredTimeSeriesDescribeGeneral As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator61 As ToolStripSeparator
    Friend WithEvents mnuStructuredTimeSeriesModel As ToolStripMenuItem
    Friend WithEvents mnuStructuredTimeSeriesModelOneVariable As ToolStripMenuItem
    Friend WithEvents mnuStructuredTimeSeriesModelGeneral As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator62 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator63 As ToolStripSeparator
    Friend WithEvents mnuStructuredClimatic As ToolStripMenuItem
    Friend WithEvents mnuStructuredProcurement As ToolStripMenuItem
    Friend WithEvents mnuStructuredOptionByContext As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator64 As ToolStripSeparator
    Friend WithEvents mnuClimaticCheckDataFillMissingValues As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator65 As ToolStripSeparator
    Friend WithEvents mnuPrepareCheckDataVisualiseData As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineVisualiseData As ToolStripMenuItem
    Friend WithEvents mnuClimaticCompare As ToolStripMenuItem
    Friend WithEvents mnuClimaticCompareCalculation As ToolStripMenuItem
    Friend WithEvents mnuClimaticCompareSummary As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator66 As ToolStripSeparator
    Friend WithEvents mnuClimaticCompareCorrelations As ToolStripMenuItem
    Friend WithEvents mnuClimaticCompareScatterplot As ToolStripMenuItem
    Friend WithEvents mnuClimaticCompareTimeSeriesPlot As ToolStripMenuItem
    Friend WithEvents mnuClimaticCompareSeasonalPlot As ToolStripMenuItem
    Friend WithEvents mnuClimaticCompareDensityPlot As ToolStripMenuItem
    Friend WithEvents mnuClimaticCompareConditionalQuantiles As ToolStripMenuItem
    Friend WithEvents mnuClimaticCompareTaylorDiagram As ToolStripMenuItem
    Friend WithEvents mnuStructuredCircularCalculator As ToolStripMenuItem
    Friend WithEvents mnuStructuredCircularSummaries As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator46 As ToolStripSeparator
    Friend WithEvents mnuStructuredCircularDensityPlot As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator67 As ToolStripSeparator
    Friend WithEvents mnuStructuredCircularWindRose As ToolStripMenuItem
    Friend WithEvents mnuStructuredCircularWindPollutionRose As ToolStripMenuItem
    Friend WithEvents mnuStructuredCircularOtherRosePlots As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator68 As ToolStripSeparator
    Friend WithEvents mnuStructuredCircularCirclize As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator20 As ToolStripSeparator
    Friend WithEvents mnuClimateFileImportfromClimSoftWizard As ToolStripMenuItem
    Friend WithEvents mnuExportToWWRToolStrip As ToolStripMenuItem
    Friend WithEvents mnuViewStructuredMenu As ToolStripMenuItem
    Friend WithEvents mnuClimaticNCMP As ToolStripMenuItem
    Friend WithEvents mnuClimaticNCMPIndices As ToolStripMenuItem
    Friend WithEvents mnuClimaticNCMPVariogram As ToolStripMenuItem
    Friend WithEvents mnuClimaticNCMPRegionAverage As ToolStripMenuItem
    Friend WithEvents mnuClimaticNCMPTrendGraphs As ToolStripMenuItem
    Friend WithEvents mnuClimaticNCMPCountRecords As ToolStripMenuItem
    Friend WithEvents mnuClimaticNCMPSummary As ToolStripMenuItem
    Friend WithEvents mnuViewSwapDataAndMetadata As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator69 As ToolStripSeparator
    Friend WithEvents mnuTidyandExamineClimaticDataEntry As ToolStripMenuItem
    Friend WithEvents mnuClimaticMappingMap As ToolStripMenuItem
    Friend WithEvents mnuClimaticMappingCheckStationLocations As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator70 As ToolStripSeparator
    Friend WithEvents mnuClimaticCheckDataCheckStationLocations As ToolStripMenuItem
    Friend WithEvents mnuClimaticFileImportfromClimateDataStore As ToolStripMenuItem
    Friend WithEvents mnuSetupForDataEntry As ToolStripMenuItem
    Friend WithEvents mnuEditPasteNewDataFrame As ToolStripMenuItem
    Friend WithEvents mnuTbLan As ToolStripButton
    Friend WithEvents mnuPasteSpecial As ToolStripMenuItem
    Friend WithEvents mnuTbCopy As ToolStripSplitButton
    Friend WithEvents mnuSubTbCopy As ToolStripMenuItem
    Friend WithEvents mnuSubTbCopySpecial As ToolStripMenuItem
    Friend WithEvents mnuTbPaste As ToolStripSplitButton
    Friend WithEvents mnuSubTbPaste As ToolStripMenuItem
    Friend WithEvents mnuSubTbPasteSpecial As ToolStripMenuItem
    Friend WithEvents mnuLastGraph As ToolStripSplitButton
    Friend WithEvents mnuViewer As ToolStripMenuItem
    Friend WithEvents mnuploty As ToolStripMenuItem
    Friend WithEvents mnuDescribeTwoVariablesPivotTable As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator27 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator71 As ToolStripSeparator
    Friend WithEvents mnuEditScript As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameSelectColumns As ToolStripMenuItem
    Friend WithEvents mnuDescribeThreeVariablePivotTable As ToolStripMenuItem
    Friend WithEvents mnuClimaticFileExportToClimsoft As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineCompareColumns As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameDuplicateColumn As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataReshapeScaleOrDistance As ToolStripMenuItem
    Friend WithEvents mnuDescribeOneVariableVisualiseData As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator72 As ToolStripSeparator
    Friend WithEvents mnuModelFitModelMachineLearning As ToolStripMenuItem
    Friend WithEvents mnuDescribeMultivariateClusterAnalysis As ToolStripMenuItem
End Class
