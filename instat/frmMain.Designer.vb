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
        Me.mnuDescribeTwoThreeVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeTwoThreeVariablesPivotTable = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator36 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeTwoVariablesSummarise = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeTwoVariablesGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeTwoThreeVariablesCorrelations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeTwoThreeVariablesTwoWayFrequencies = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeTwoThreeVariablesThreeWayFrequencies = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificTablesGraphs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator38 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeSpecificBarPieChart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificBoxplotJitterViolinPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificHistogramDensityFrequencyPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificPointPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificLineSmoothPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator26 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeSpecificMapPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificDotPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificMosaic = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificCummulativeDistribution = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificParallelCoordinatePlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeSpecificTables = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeMultivariate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeMultivariateCorrelations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeMultivariateprincipalComponents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeMultivariateCanonicalCorrelations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeMultivariateClusterAnalysis = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeUseTable = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuViewOutput = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewLogScript = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewColumnMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewDataFrameMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewStructuredMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuViewClimaticMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewProcurementMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewOptionsByContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator39 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuViewResetToDefaultLayout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewSwapDataAndMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpHelpIntroduction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpFAQ = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpGetingStarted = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator28 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelpWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpMenus = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAboutR = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpLearningStatistics = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpRPackages = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpGlossary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpLicence = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator29 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelpPackagesDocumentation = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuClimaticTidyandExamineDuplicateRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator54 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticTidyandExamineStack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineUnstack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineMerge = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineAppend = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator69 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticTidyandExamineTransformText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticTidyandExamineSplitText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamineEditData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamineEditDataOneVariableSummarise = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamineEditDataOneVariableGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamineEditDataOneVariableFrequencies = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator78 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExamineEditDataPivotTable = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator79 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExamineEditDataSetupForDataEditing = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamineEditDataDailyDataEditing = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamineEditDataCompareColumns = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuClimaticPICSARainfallGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPICSATemperatureGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPICSAGeneralGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator73 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticPICSACumExeedenceGraph = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPasteNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditWordwrap = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.stsStrip = New System.Windows.Forms.StatusStrip()
        Me.tstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tool_strip = New System.Windows.Forms.ToolStrip()
        Me.mnuTbOpen = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuTbOpenFromLibrary = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbSave = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuSaveData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveOutput = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveScript = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbLast10Dialogs = New System.Windows.Forms.ToolStripSplitButton()
        Me.separator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbDataView = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbOutput = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuOutputWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowRCommand = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIncludeComments = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator74 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLastGraph = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuNormalViewer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuploty = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRViewer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator75 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbLogScript = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuLogScript = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMetadata = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuColumnMetadat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataFrameMetadat = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator76 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbResetLayout = New System.Windows.Forms.ToolStripButton()
        Me.separator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator77 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbLan = New System.Windows.Forms.ToolStripButton()
        Me.separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBar = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNewDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileImportFromFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileImportFromLibrary = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileImportFromODK = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileImportFromCSPRO = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileImportFromDatabases = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileImportFromPostgres = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileImportFromRapidPro = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuPrepareDataFrameFilterRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameSelectColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameReplaceValues = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameConvertColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareDataFrameReorderColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameAddMergeColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameInsertColumnsRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameDeleteColumnsRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameProtectColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameHideColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataFrameFreezeColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataframeColourByProperty = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataVisualiseData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataPivotTable = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator50 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareCheckDataDuplicates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataCompareColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataNonNumericCases = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator49 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareCheckDataBoxplot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataOneVariableSummarise = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataOneVariableGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataOneWayFrequencies = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataViewDeleteLabels = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuPrepareColumnFactorReorderLevels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactorReferenceLevel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactorUnusedLevels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnFactorContrasts = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareColumnFactorFactorDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnTextFindReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnTextSearch = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuPrepareDataReshapeRandomSplit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareKeysAndLinks = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareKeysAndLinksAddKey = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareKeysAndLinksViewAndRemoveKey = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareKeysAndLinksAddLink = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareKeysAndLinksViewAndRemoveKeys = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareKeysAndLinksAddComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareDataBook = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuStructuredSurvey = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuOptionsByContextCheckDataDuplicateRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextCheckDataCompareColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator47 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOptionsByContextCheckDataOneVariableSummarise = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextCheckDataOneVariableGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextCheckDataOneVariableFrequencies = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextDefine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextDefineOnStation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextDefineOnFarm = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuOptionsByContextCropModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsByContextCropModelApsimxExamples = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ucrScriptWindow = New instat.ucrScript()
        Me.splDataOutput = New System.Windows.Forms.SplitContainer()
        Me.ucrDataViewer = New instat.ucrDataView()
        Me.ucrOutput = New instat.ucrOutputWindow()
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
        CType(Me.splDataOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splDataOutput.Panel1.SuspendLayout()
        Me.splDataOutput.Panel2.SuspendLayout()
        Me.splDataOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuDescribe
        '
        Me.mnuDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeOneVariable, Me.mnuDescribeTwoThreeVariables, Me.mnuDescribeSpecificTablesGraphs, Me.mnuDescribeSpecificTables, Me.ToolStripSeparator9, Me.mnuDescribeMultivariate, Me.ToolStripSeparator13, Me.mnuDescribeUseTable, Me.mnuDescribeUseGraph, Me.mnuDescribeCombineGraph, Me.mnuDescribeThemes, Me.mnuDescribeViewGraph})
        Me.mnuDescribe.Name = "mnuDescribe"
        Me.mnuDescribe.Size = New System.Drawing.Size(96, 29)
        Me.mnuDescribe.Tag = "Describe"
        Me.mnuDescribe.Text = "Describe"
        '
        'mnuDescribeOneVariable
        '
        Me.mnuDescribeOneVariable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeOneVariableVisualiseData, Me.ToolStripSeparator72, Me.mnuDescribeOneVariableSummarise, Me.mnuDescribeOneVariableGraph, Me.ToolStripSeparator33, Me.mnuDescribeOneVariableFrequencies, Me.mnuDescribeOneVariableRatingData})
        Me.mnuDescribeOneVariable.Name = "mnuDescribeOneVariable"
        Me.mnuDescribeOneVariable.Size = New System.Drawing.Size(271, 34)
        Me.mnuDescribeOneVariable.Tag = "One_Variable"
        Me.mnuDescribeOneVariable.Text = "One Variable"
        '
        'mnuDescribeOneVariableVisualiseData
        '
        Me.mnuDescribeOneVariableVisualiseData.Name = "mnuDescribeOneVariableVisualiseData"
        Me.mnuDescribeOneVariableVisualiseData.Size = New System.Drawing.Size(235, 34)
        Me.mnuDescribeOneVariableVisualiseData.Text = "Visualise Data..."
        '
        'ToolStripSeparator72
        '
        Me.ToolStripSeparator72.Name = "ToolStripSeparator72"
        Me.ToolStripSeparator72.Size = New System.Drawing.Size(232, 6)
        '
        'mnuDescribeOneVariableSummarise
        '
        Me.mnuDescribeOneVariableSummarise.Name = "mnuDescribeOneVariableSummarise"
        Me.mnuDescribeOneVariableSummarise.Size = New System.Drawing.Size(235, 34)
        Me.mnuDescribeOneVariableSummarise.Tag = "Summarise..."
        Me.mnuDescribeOneVariableSummarise.Text = "Summarise..."
        Me.mnuDescribeOneVariableSummarise.ToolTipText = "One Variable Summarise, Skim and Customised"
        '
        'mnuDescribeOneVariableGraph
        '
        Me.mnuDescribeOneVariableGraph.Name = "mnuDescribeOneVariableGraph"
        Me.mnuDescribeOneVariableGraph.Size = New System.Drawing.Size(235, 34)
        Me.mnuDescribeOneVariableGraph.Tag = "Graph..."
        Me.mnuDescribeOneVariableGraph.Text = "Graph..."
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(232, 6)
        '
        'mnuDescribeOneVariableFrequencies
        '
        Me.mnuDescribeOneVariableFrequencies.Name = "mnuDescribeOneVariableFrequencies"
        Me.mnuDescribeOneVariableFrequencies.Size = New System.Drawing.Size(235, 34)
        Me.mnuDescribeOneVariableFrequencies.Text = "Frequencies..."
        Me.mnuDescribeOneVariableFrequencies.ToolTipText = "Table or Graph. Also Stem and Leaf Plots"
        '
        'mnuDescribeOneVariableRatingData
        '
        Me.mnuDescribeOneVariableRatingData.Name = "mnuDescribeOneVariableRatingData"
        Me.mnuDescribeOneVariableRatingData.Size = New System.Drawing.Size(235, 34)
        Me.mnuDescribeOneVariableRatingData.Text = "Rating Data..."
        Me.mnuDescribeOneVariableRatingData.ToolTipText = "Table, Stacked Graph or Likert Graph"
        '
        'mnuDescribeTwoThreeVariables
        '
        Me.mnuDescribeTwoThreeVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeTwoThreeVariablesPivotTable, Me.ToolStripSeparator36, Me.mnuDescribeTwoVariablesSummarise, Me.mnuDescribeTwoVariablesGraph, Me.ToolStripSeparator34, Me.mnuDescribeTwoThreeVariablesCorrelations, Me.mnuDescribeTwoThreeVariablesTwoWayFrequencies, Me.mnuDescribeTwoThreeVariablesThreeWayFrequencies})
        Me.mnuDescribeTwoThreeVariables.Name = "mnuDescribeTwoThreeVariables"
        Me.mnuDescribeTwoThreeVariables.Size = New System.Drawing.Size(271, 34)
        Me.mnuDescribeTwoThreeVariables.Tag = "Two_Variables"
        Me.mnuDescribeTwoThreeVariables.Text = "Two/Three Variables"
        '
        'mnuDescribeTwoThreeVariablesPivotTable
        '
        Me.mnuDescribeTwoThreeVariablesPivotTable.Name = "mnuDescribeTwoThreeVariablesPivotTable"
        Me.mnuDescribeTwoThreeVariablesPivotTable.Size = New System.Drawing.Size(308, 34)
        Me.mnuDescribeTwoThreeVariablesPivotTable.Text = "Pivot Table..."
        '
        'ToolStripSeparator36
        '
        Me.ToolStripSeparator36.Name = "ToolStripSeparator36"
        Me.ToolStripSeparator36.Size = New System.Drawing.Size(305, 6)
        '
        'mnuDescribeTwoVariablesSummarise
        '
        Me.mnuDescribeTwoVariablesSummarise.DoubleClickEnabled = True
        Me.mnuDescribeTwoVariablesSummarise.Name = "mnuDescribeTwoVariablesSummarise"
        Me.mnuDescribeTwoVariablesSummarise.Size = New System.Drawing.Size(308, 34)
        Me.mnuDescribeTwoVariablesSummarise.Tag = "Summarise..."
        Me.mnuDescribeTwoVariablesSummarise.Text = "Summarise..."
        Me.mnuDescribeTwoVariablesSummarise.ToolTipText = "Skim or Two Variables"
        '
        'mnuDescribeTwoVariablesGraph
        '
        Me.mnuDescribeTwoVariablesGraph.Name = "mnuDescribeTwoVariablesGraph"
        Me.mnuDescribeTwoVariablesGraph.Size = New System.Drawing.Size(308, 34)
        Me.mnuDescribeTwoVariablesGraph.Tag = "Graph..."
        Me.mnuDescribeTwoVariablesGraph.Text = "Graph..."
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(305, 6)
        '
        'mnuDescribeTwoThreeVariablesCorrelations
        '
        Me.mnuDescribeTwoThreeVariablesCorrelations.Name = "mnuDescribeTwoThreeVariablesCorrelations"
        Me.mnuDescribeTwoThreeVariablesCorrelations.Size = New System.Drawing.Size(308, 34)
        Me.mnuDescribeTwoThreeVariablesCorrelations.Text = "Correlations..."
        Me.mnuDescribeTwoThreeVariablesCorrelations.ToolTipText = "Multiple Variables or Two Variables"
        '
        'mnuDescribeTwoThreeVariablesTwoWayFrequencies
        '
        Me.mnuDescribeTwoThreeVariablesTwoWayFrequencies.DoubleClickEnabled = True
        Me.mnuDescribeTwoThreeVariablesTwoWayFrequencies.Name = "mnuDescribeTwoThreeVariablesTwoWayFrequencies"
        Me.mnuDescribeTwoThreeVariablesTwoWayFrequencies.Size = New System.Drawing.Size(308, 34)
        Me.mnuDescribeTwoThreeVariablesTwoWayFrequencies.Text = "Two-Way Frequencies..."
        Me.mnuDescribeTwoThreeVariablesTwoWayFrequencies.ToolTipText = "Table or Graph"
        '
        'mnuDescribeTwoThreeVariablesThreeWayFrequencies
        '
        Me.mnuDescribeTwoThreeVariablesThreeWayFrequencies.Name = "mnuDescribeTwoThreeVariablesThreeWayFrequencies"
        Me.mnuDescribeTwoThreeVariablesThreeWayFrequencies.Size = New System.Drawing.Size(308, 34)
        Me.mnuDescribeTwoThreeVariablesThreeWayFrequencies.Text = "Three-Way Frequencies..."
        Me.mnuDescribeTwoThreeVariablesThreeWayFrequencies.ToolTipText = "Table or Graph"
        '
        'mnuDescribeSpecificTablesGraphs
        '
        Me.mnuDescribeSpecificTablesGraphs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeGeneral, Me.ToolStripSeparator38, Me.mnuDescribeSpecificBarPieChart, Me.mnuDescribeSpecificBoxplotJitterViolinPlot, Me.mnuDescribeSpecificHistogramDensityFrequencyPlot, Me.mnuDescribeSpecificPointPlot, Me.mnuDescribeSpecificLineSmoothPlot, Me.ToolStripSeparator26, Me.mnuDescribeSpecificMapPlot, Me.mnuDescribeSpecificDotPlot, Me.mnuDescribeSpecificMosaic, Me.mnuDescribeSpecificCummulativeDistribution, Me.mnuDescribeSpecificParallelCoordinatePlot})
        Me.mnuDescribeSpecificTablesGraphs.Name = "mnuDescribeSpecificTablesGraphs"
        Me.mnuDescribeSpecificTablesGraphs.Size = New System.Drawing.Size(271, 34)
        Me.mnuDescribeSpecificTablesGraphs.Tag = "Graph_Dialogs"
        Me.mnuDescribeSpecificTablesGraphs.Text = "Graphs"
        '
        'mnuDescribeGeneral
        '
        Me.mnuDescribeGeneral.Name = "mnuDescribeGeneral"
        Me.mnuDescribeGeneral.Size = New System.Drawing.Size(312, 34)
        Me.mnuDescribeGeneral.Text = "General..."
        '
        'ToolStripSeparator38
        '
        Me.ToolStripSeparator38.Name = "ToolStripSeparator38"
        Me.ToolStripSeparator38.Size = New System.Drawing.Size(309, 6)
        '
        'mnuDescribeSpecificBarPieChart
        '
        Me.mnuDescribeSpecificBarPieChart.Name = "mnuDescribeSpecificBarPieChart"
        Me.mnuDescribeSpecificBarPieChart.Size = New System.Drawing.Size(312, 34)
        Me.mnuDescribeSpecificBarPieChart.Tag = "Bar_Chart"
        Me.mnuDescribeSpecificBarPieChart.Text = "Bar Chart..."
        Me.mnuDescribeSpecificBarPieChart.ToolTipText = "Bar, Column, Lollipop, Pie, and Donut Charts, plus Treemaps and Wordclouds"
        '
        'mnuDescribeSpecificBoxplotJitterViolinPlot
        '
        Me.mnuDescribeSpecificBoxplotJitterViolinPlot.Name = "mnuDescribeSpecificBoxplotJitterViolinPlot"
        Me.mnuDescribeSpecificBoxplotJitterViolinPlot.Size = New System.Drawing.Size(312, 34)
        Me.mnuDescribeSpecificBoxplotJitterViolinPlot.Tag = "Boxplot..."
        Me.mnuDescribeSpecificBoxplotJitterViolinPlot.Text = "Boxplot..."
        Me.mnuDescribeSpecificBoxplotJitterViolinPlot.ToolTipText = "Boxplot (including Tufte), Jitter and Violin Plots"
        '
        'mnuDescribeSpecificHistogramDensityFrequencyPlot
        '
        Me.mnuDescribeSpecificHistogramDensityFrequencyPlot.Name = "mnuDescribeSpecificHistogramDensityFrequencyPlot"
        Me.mnuDescribeSpecificHistogramDensityFrequencyPlot.Size = New System.Drawing.Size(312, 34)
        Me.mnuDescribeSpecificHistogramDensityFrequencyPlot.Tag = "Histogram..."
        Me.mnuDescribeSpecificHistogramDensityFrequencyPlot.Text = "Histogram..."
        Me.mnuDescribeSpecificHistogramDensityFrequencyPlot.ToolTipText = "Histograms, Dotplots, Density and Ridge Plots and Frequency Polygons"
        '
        'mnuDescribeSpecificPointPlot
        '
        Me.mnuDescribeSpecificPointPlot.Name = "mnuDescribeSpecificPointPlot"
        Me.mnuDescribeSpecificPointPlot.Size = New System.Drawing.Size(312, 34)
        Me.mnuDescribeSpecificPointPlot.Tag = "Point_Plot..."
        Me.mnuDescribeSpecificPointPlot.Text = "Scatter Plot..."
        Me.mnuDescribeSpecificPointPlot.ToolTipText = "Point Plot"
        '
        'mnuDescribeSpecificLineSmoothPlot
        '
        Me.mnuDescribeSpecificLineSmoothPlot.Name = "mnuDescribeSpecificLineSmoothPlot"
        Me.mnuDescribeSpecificLineSmoothPlot.Size = New System.Drawing.Size(312, 34)
        Me.mnuDescribeSpecificLineSmoothPlot.Tag = "Line_Plot..."
        Me.mnuDescribeSpecificLineSmoothPlot.Text = "Line Plot..."
        Me.mnuDescribeSpecificLineSmoothPlot.ToolTipText = "Line Plots, Smoothed Plots, Dumbbell and Slope Plots"
        '
        'ToolStripSeparator26
        '
        Me.ToolStripSeparator26.Name = "ToolStripSeparator26"
        Me.ToolStripSeparator26.Size = New System.Drawing.Size(309, 6)
        '
        'mnuDescribeSpecificMapPlot
        '
        Me.mnuDescribeSpecificMapPlot.Name = "mnuDescribeSpecificMapPlot"
        Me.mnuDescribeSpecificMapPlot.Size = New System.Drawing.Size(312, 34)
        Me.mnuDescribeSpecificMapPlot.Text = "Heatmap..."
        Me.mnuDescribeSpecificMapPlot.ToolTipText = "Heat Map and Chorolopleth Map"
        '
        'mnuDescribeSpecificDotPlot
        '
        Me.mnuDescribeSpecificDotPlot.Enabled = False
        Me.mnuDescribeSpecificDotPlot.Name = "mnuDescribeSpecificDotPlot"
        Me.mnuDescribeSpecificDotPlot.Size = New System.Drawing.Size(312, 34)
        Me.mnuDescribeSpecificDotPlot.Tag = "Dotplot..."
        Me.mnuDescribeSpecificDotPlot.Text = "Dot Plot..."
        Me.mnuDescribeSpecificDotPlot.Visible = False
        '
        'mnuDescribeSpecificMosaic
        '
        Me.mnuDescribeSpecificMosaic.Name = "mnuDescribeSpecificMosaic"
        Me.mnuDescribeSpecificMosaic.Size = New System.Drawing.Size(312, 34)
        Me.mnuDescribeSpecificMosaic.Text = "Mosaic Plot..."
        Me.mnuDescribeSpecificMosaic.ToolTipText = "Mosaic Plot"
        '
        'mnuDescribeSpecificCummulativeDistribution
        '
        Me.mnuDescribeSpecificCummulativeDistribution.Name = "mnuDescribeSpecificCummulativeDistribution"
        Me.mnuDescribeSpecificCummulativeDistribution.Size = New System.Drawing.Size(312, 34)
        Me.mnuDescribeSpecificCummulativeDistribution.Text = "Cumulative Distribution..."
        Me.mnuDescribeSpecificCummulativeDistribution.ToolTipText = "Cumulative Graph and Exceedance Graph"
        '
        'mnuDescribeSpecificParallelCoordinatePlot
        '
        Me.mnuDescribeSpecificParallelCoordinatePlot.Name = "mnuDescribeSpecificParallelCoordinatePlot"
        Me.mnuDescribeSpecificParallelCoordinatePlot.Size = New System.Drawing.Size(312, 34)
        Me.mnuDescribeSpecificParallelCoordinatePlot.Text = "Parallel Coordinate Plot..."
        '
        'mnuDescribeSpecificTables
        '
        Me.mnuDescribeSpecificTables.Name = "mnuDescribeSpecificTables"
        Me.mnuDescribeSpecificTables.Size = New System.Drawing.Size(271, 34)
        Me.mnuDescribeSpecificTables.Tag = "Table_Dialogs"
        Me.mnuDescribeSpecificTables.Text = "Tables..."
        Me.mnuDescribeSpecificTables.ToolTipText = "Frequency tables and Summary tables"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(268, 6)
        '
        'mnuDescribeMultivariate
        '
        Me.mnuDescribeMultivariate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeMultivariateCorrelations, Me.mnuDescribeMultivariateprincipalComponents, Me.mnuDescribeMultivariateCanonicalCorrelations, Me.mnuDescribeMultivariateClusterAnalysis})
        Me.mnuDescribeMultivariate.Name = "mnuDescribeMultivariate"
        Me.mnuDescribeMultivariate.Size = New System.Drawing.Size(271, 34)
        Me.mnuDescribeMultivariate.Text = "Multivariate"
        '
        'mnuDescribeMultivariateCorrelations
        '
        Me.mnuDescribeMultivariateCorrelations.Name = "mnuDescribeMultivariateCorrelations"
        Me.mnuDescribeMultivariateCorrelations.Size = New System.Drawing.Size(302, 34)
        Me.mnuDescribeMultivariateCorrelations.Text = "Correlations..."
        Me.mnuDescribeMultivariateCorrelations.ToolTipText = "Multiple Variables or Two Variables"
        '
        'mnuDescribeMultivariateprincipalComponents
        '
        Me.mnuDescribeMultivariateprincipalComponents.Name = "mnuDescribeMultivariateprincipalComponents"
        Me.mnuDescribeMultivariateprincipalComponents.Size = New System.Drawing.Size(302, 34)
        Me.mnuDescribeMultivariateprincipalComponents.Text = "Principal Components..."
        '
        'mnuDescribeMultivariateCanonicalCorrelations
        '
        Me.mnuDescribeMultivariateCanonicalCorrelations.Name = "mnuDescribeMultivariateCanonicalCorrelations"
        Me.mnuDescribeMultivariateCanonicalCorrelations.Size = New System.Drawing.Size(302, 34)
        Me.mnuDescribeMultivariateCanonicalCorrelations.Text = "Canonical Correlations..."
        '
        'mnuDescribeMultivariateClusterAnalysis
        '
        Me.mnuDescribeMultivariateClusterAnalysis.Name = "mnuDescribeMultivariateClusterAnalysis"
        Me.mnuDescribeMultivariateClusterAnalysis.Size = New System.Drawing.Size(302, 34)
        Me.mnuDescribeMultivariateClusterAnalysis.Text = "Cluster Analysis..."
        Me.mnuDescribeMultivariateClusterAnalysis.ToolTipText = "Partitioning or Hierarchical"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(268, 6)
        '
        'mnuDescribeUseTable
        '
        Me.mnuDescribeUseTable.Name = "mnuDescribeUseTable"
        Me.mnuDescribeUseTable.Size = New System.Drawing.Size(271, 34)
        Me.mnuDescribeUseTable.Text = "Use Table..."
        '
        'mnuDescribeUseGraph
        '
        Me.mnuDescribeUseGraph.Name = "mnuDescribeUseGraph"
        Me.mnuDescribeUseGraph.Size = New System.Drawing.Size(271, 34)
        Me.mnuDescribeUseGraph.Text = "Use Graph..."
        '
        'mnuDescribeCombineGraph
        '
        Me.mnuDescribeCombineGraph.Name = "mnuDescribeCombineGraph"
        Me.mnuDescribeCombineGraph.Size = New System.Drawing.Size(271, 34)
        Me.mnuDescribeCombineGraph.Text = "Combine Graphs..."
        '
        'mnuDescribeThemes
        '
        Me.mnuDescribeThemes.Enabled = False
        Me.mnuDescribeThemes.Name = "mnuDescribeThemes"
        Me.mnuDescribeThemes.Size = New System.Drawing.Size(271, 34)
        Me.mnuDescribeThemes.Text = "Themes..."
        Me.mnuDescribeThemes.Visible = False
        '
        'mnuDescribeViewGraph
        '
        Me.mnuDescribeViewGraph.Name = "mnuDescribeViewGraph"
        Me.mnuDescribeViewGraph.Size = New System.Drawing.Size(271, 34)
        Me.mnuDescribeViewGraph.Text = "View Graph..."
        '
        'mnuModel
        '
        Me.mnuModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelProbabilityDistributions, Me.ToolStripSeparator3, Me.mnuModelFitModel, Me.mnuModelCompareModels, Me.mnuModelUseModel, Me.mnuModelOtherOneVariable, Me.mnuModelOtherTwoVariables, Me.mnuModelOtherThreeVariables, Me.mnuModelOtherGeneral})
        Me.mnuModel.Name = "mnuModel"
        Me.mnuModel.Size = New System.Drawing.Size(79, 29)
        Me.mnuModel.Tag = "Model"
        Me.mnuModel.Text = "Model"
        '
        'mnuModelProbabilityDistributions
        '
        Me.mnuModelProbabilityDistributions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelProbabilityDistributionsShowModel, Me.mnuModelProbabilityDistributionsCompareModels, Me.mnuModelProbabilityDistributionsRandomSamplesUseModel})
        Me.mnuModelProbabilityDistributions.Name = "mnuModelProbabilityDistributions"
        Me.mnuModelProbabilityDistributions.Size = New System.Drawing.Size(305, 34)
        Me.mnuModelProbabilityDistributions.Tag = "Probability_Distributions"
        Me.mnuModelProbabilityDistributions.Text = "Probability Distributions"
        '
        'mnuModelProbabilityDistributionsShowModel
        '
        Me.mnuModelProbabilityDistributionsShowModel.Name = "mnuModelProbabilityDistributionsShowModel"
        Me.mnuModelProbabilityDistributionsShowModel.Size = New System.Drawing.Size(271, 34)
        Me.mnuModelProbabilityDistributionsShowModel.Text = "Show Model..."
        '
        'mnuModelProbabilityDistributionsCompareModels
        '
        Me.mnuModelProbabilityDistributionsCompareModels.Enabled = False
        Me.mnuModelProbabilityDistributionsCompareModels.Name = "mnuModelProbabilityDistributionsCompareModels"
        Me.mnuModelProbabilityDistributionsCompareModels.Size = New System.Drawing.Size(271, 34)
        Me.mnuModelProbabilityDistributionsCompareModels.Tag = "Show_Models..."
        Me.mnuModelProbabilityDistributionsCompareModels.Text = "Compare Models..."
        '
        'mnuModelProbabilityDistributionsRandomSamplesUseModel
        '
        Me.mnuModelProbabilityDistributionsRandomSamplesUseModel.Name = "mnuModelProbabilityDistributionsRandomSamplesUseModel"
        Me.mnuModelProbabilityDistributionsRandomSamplesUseModel.Size = New System.Drawing.Size(271, 34)
        Me.mnuModelProbabilityDistributionsRandomSamplesUseModel.Tag = "RandomSamples_(Use_Model)..."
        Me.mnuModelProbabilityDistributionsRandomSamplesUseModel.Text = "Random Samples ..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(302, 6)
        '
        'mnuModelFitModel
        '
        Me.mnuModelFitModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelFitModelOneVariable, Me.mnuModelFitModelTwoVariables, Me.mnuModelFitModelThreeVariables, Me.mnuModelFitModelFourVariables, Me.ToolStripSeparator24, Me.mnuModelFitModelGeneral, Me.mnuModelFitModelMachineLearning, Me.ToolStripSeparator57, Me.mnuModelFitModelHypothesisTestsKeyboard, Me.mnuModelFitModelModelKeyboard})
        Me.mnuModelFitModel.Name = "mnuModelFitModel"
        Me.mnuModelFitModel.Size = New System.Drawing.Size(305, 34)
        Me.mnuModelFitModel.Tag = "Fit_Model..."
        Me.mnuModelFitModel.Text = "Fit Model"
        '
        'mnuModelFitModelOneVariable
        '
        Me.mnuModelFitModelOneVariable.Name = "mnuModelFitModelOneVariable"
        Me.mnuModelFitModelOneVariable.Size = New System.Drawing.Size(347, 34)
        Me.mnuModelFitModelOneVariable.Text = "One Variable..."
        '
        'mnuModelFitModelTwoVariables
        '
        Me.mnuModelFitModelTwoVariables.Name = "mnuModelFitModelTwoVariables"
        Me.mnuModelFitModelTwoVariables.Size = New System.Drawing.Size(347, 34)
        Me.mnuModelFitModelTwoVariables.Text = "Two Variables..."
        '
        'mnuModelFitModelThreeVariables
        '
        Me.mnuModelFitModelThreeVariables.Name = "mnuModelFitModelThreeVariables"
        Me.mnuModelFitModelThreeVariables.Size = New System.Drawing.Size(347, 34)
        Me.mnuModelFitModelThreeVariables.Text = "Three Variables..."
        '
        'mnuModelFitModelFourVariables
        '
        Me.mnuModelFitModelFourVariables.Name = "mnuModelFitModelFourVariables"
        Me.mnuModelFitModelFourVariables.Size = New System.Drawing.Size(347, 34)
        Me.mnuModelFitModelFourVariables.Text = "Four Variables..."
        '
        'ToolStripSeparator24
        '
        Me.ToolStripSeparator24.Name = "ToolStripSeparator24"
        Me.ToolStripSeparator24.Size = New System.Drawing.Size(344, 6)
        '
        'mnuModelFitModelGeneral
        '
        Me.mnuModelFitModelGeneral.Name = "mnuModelFitModelGeneral"
        Me.mnuModelFitModelGeneral.Size = New System.Drawing.Size(347, 34)
        Me.mnuModelFitModelGeneral.Text = "General..."
        '
        'mnuModelFitModelMachineLearning
        '
        Me.mnuModelFitModelMachineLearning.Enabled = False
        Me.mnuModelFitModelMachineLearning.Name = "mnuModelFitModelMachineLearning"
        Me.mnuModelFitModelMachineLearning.Size = New System.Drawing.Size(347, 34)
        Me.mnuModelFitModelMachineLearning.Text = "Machine Learning (Caret)..."
        Me.mnuModelFitModelMachineLearning.Visible = False
        '
        'ToolStripSeparator57
        '
        Me.ToolStripSeparator57.Name = "ToolStripSeparator57"
        Me.ToolStripSeparator57.Size = New System.Drawing.Size(344, 6)
        '
        'mnuModelFitModelHypothesisTestsKeyboard
        '
        Me.mnuModelFitModelHypothesisTestsKeyboard.Name = "mnuModelFitModelHypothesisTestsKeyboard"
        Me.mnuModelFitModelHypothesisTestsKeyboard.Size = New System.Drawing.Size(347, 34)
        Me.mnuModelFitModelHypothesisTestsKeyboard.Text = "Hypothesis Tests Keyboards..."
        '
        'mnuModelFitModelModelKeyboard
        '
        Me.mnuModelFitModelModelKeyboard.Name = "mnuModelFitModelModelKeyboard"
        Me.mnuModelFitModelModelKeyboard.Size = New System.Drawing.Size(347, 34)
        Me.mnuModelFitModelModelKeyboard.Text = "Fit Model Keyboards..."
        '
        'mnuModelCompareModels
        '
        Me.mnuModelCompareModels.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelCompareModelsOneVariable})
        Me.mnuModelCompareModels.Name = "mnuModelCompareModels"
        Me.mnuModelCompareModels.Size = New System.Drawing.Size(305, 34)
        Me.mnuModelCompareModels.Text = "Compare Models"
        '
        'mnuModelCompareModelsOneVariable
        '
        Me.mnuModelCompareModelsOneVariable.Name = "mnuModelCompareModelsOneVariable"
        Me.mnuModelCompareModelsOneVariable.Size = New System.Drawing.Size(226, 34)
        Me.mnuModelCompareModelsOneVariable.Text = "One Variable..."
        '
        'mnuModelUseModel
        '
        Me.mnuModelUseModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelUseModelOneVariable, Me.mnuModelUseModelTwoVariables, Me.ToolStripSeparator59, Me.mnuModelUseModelGlance, Me.mnuModelUseModelTidy, Me.mnuModelUseModelAugment, Me.ToolStripSeparator58, Me.mnuModelUseModelUseModelKeyboard})
        Me.mnuModelUseModel.Name = "mnuModelUseModel"
        Me.mnuModelUseModel.Size = New System.Drawing.Size(305, 34)
        Me.mnuModelUseModel.Text = "Use Model"
        '
        'mnuModelUseModelOneVariable
        '
        Me.mnuModelUseModelOneVariable.Name = "mnuModelUseModelOneVariable"
        Me.mnuModelUseModelOneVariable.Size = New System.Drawing.Size(300, 34)
        Me.mnuModelUseModelOneVariable.Text = "One Variable..."
        '
        'mnuModelUseModelTwoVariables
        '
        Me.mnuModelUseModelTwoVariables.Name = "mnuModelUseModelTwoVariables"
        Me.mnuModelUseModelTwoVariables.Size = New System.Drawing.Size(300, 34)
        Me.mnuModelUseModelTwoVariables.Text = "Two Variables..."
        '
        'ToolStripSeparator59
        '
        Me.ToolStripSeparator59.Name = "ToolStripSeparator59"
        Me.ToolStripSeparator59.Size = New System.Drawing.Size(297, 6)
        '
        'mnuModelUseModelGlance
        '
        Me.mnuModelUseModelGlance.Name = "mnuModelUseModelGlance"
        Me.mnuModelUseModelGlance.Size = New System.Drawing.Size(300, 34)
        Me.mnuModelUseModelGlance.Text = "Glance..."
        '
        'mnuModelUseModelTidy
        '
        Me.mnuModelUseModelTidy.Name = "mnuModelUseModelTidy"
        Me.mnuModelUseModelTidy.Size = New System.Drawing.Size(300, 34)
        Me.mnuModelUseModelTidy.Text = "Tidy..."
        '
        'mnuModelUseModelAugment
        '
        Me.mnuModelUseModelAugment.Name = "mnuModelUseModelAugment"
        Me.mnuModelUseModelAugment.Size = New System.Drawing.Size(300, 34)
        Me.mnuModelUseModelAugment.Text = "Augment..."
        '
        'ToolStripSeparator58
        '
        Me.ToolStripSeparator58.Name = "ToolStripSeparator58"
        Me.ToolStripSeparator58.Size = New System.Drawing.Size(297, 6)
        '
        'mnuModelUseModelUseModelKeyboard
        '
        Me.mnuModelUseModelUseModelKeyboard.Name = "mnuModelUseModelUseModelKeyboard"
        Me.mnuModelUseModelUseModelKeyboard.Size = New System.Drawing.Size(300, 34)
        Me.mnuModelUseModelUseModelKeyboard.Text = "Use Model Keyboards..."
        '
        'mnuModelOtherOneVariable
        '
        Me.mnuModelOtherOneVariable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelOtherOneVariableExactResults, Me.mnuModelOtherOneVariableSampleSummaryData, Me.mnuModelOtherOneVariableNonParametric, Me.mnuModelOtherOneVariableGoodnessofFit})
        Me.mnuModelOtherOneVariable.Enabled = False
        Me.mnuModelOtherOneVariable.Name = "mnuModelOtherOneVariable"
        Me.mnuModelOtherOneVariable.Size = New System.Drawing.Size(305, 34)
        Me.mnuModelOtherOneVariable.Tag = "Other_(One_Variable)"
        Me.mnuModelOtherOneVariable.Text = "Other (One Variable)"
        '
        'mnuModelOtherOneVariableExactResults
        '
        Me.mnuModelOtherOneVariableExactResults.Name = "mnuModelOtherOneVariableExactResults"
        Me.mnuModelOtherOneVariableExactResults.Size = New System.Drawing.Size(252, 34)
        Me.mnuModelOtherOneVariableExactResults.Tag = "Exact_Results..."
        Me.mnuModelOtherOneVariableExactResults.Text = "Exact Results..."
        '
        'mnuModelOtherOneVariableSampleSummaryData
        '
        Me.mnuModelOtherOneVariableSampleSummaryData.Enabled = False
        Me.mnuModelOtherOneVariableSampleSummaryData.Name = "mnuModelOtherOneVariableSampleSummaryData"
        Me.mnuModelOtherOneVariableSampleSummaryData.Size = New System.Drawing.Size(252, 34)
        Me.mnuModelOtherOneVariableSampleSummaryData.Tag = "Summary_Data..."
        Me.mnuModelOtherOneVariableSampleSummaryData.Text = "Summary Data..."
        '
        'mnuModelOtherOneVariableNonParametric
        '
        Me.mnuModelOtherOneVariableNonParametric.Enabled = False
        Me.mnuModelOtherOneVariableNonParametric.Name = "mnuModelOtherOneVariableNonParametric"
        Me.mnuModelOtherOneVariableNonParametric.Size = New System.Drawing.Size(252, 34)
        Me.mnuModelOtherOneVariableNonParametric.Tag = "Non_Parametric..."
        Me.mnuModelOtherOneVariableNonParametric.Text = "Non Parametric..."
        '
        'mnuModelOtherOneVariableGoodnessofFit
        '
        Me.mnuModelOtherOneVariableGoodnessofFit.Enabled = False
        Me.mnuModelOtherOneVariableGoodnessofFit.Name = "mnuModelOtherOneVariableGoodnessofFit"
        Me.mnuModelOtherOneVariableGoodnessofFit.Size = New System.Drawing.Size(252, 34)
        Me.mnuModelOtherOneVariableGoodnessofFit.Tag = "Goodness_of_Fit"
        Me.mnuModelOtherOneVariableGoodnessofFit.Text = "Goodness of Fit..."
        '
        'mnuModelOtherTwoVariables
        '
        Me.mnuModelOtherTwoVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelOtherTwoVariablesTwoSamples, Me.mnuModelOtherTwoVariablesSummaryData, Me.mnuModelOtherTwoVariablesSimpleRegression, Me.mnuModelOtherTwoVariablesOneWayANOVA, Me.mnuModelOtherTwoVariablesNonParametricTwoSamples, Me.mnuModelOtherTwoVariablesNonParametricOneWayANOVA})
        Me.mnuModelOtherTwoVariables.Enabled = False
        Me.mnuModelOtherTwoVariables.Name = "mnuModelOtherTwoVariables"
        Me.mnuModelOtherTwoVariables.Size = New System.Drawing.Size(305, 34)
        Me.mnuModelOtherTwoVariables.Tag = "Other_(Two_Variables)"
        Me.mnuModelOtherTwoVariables.Text = "Other (Two Variables)"
        '
        'mnuModelOtherTwoVariablesTwoSamples
        '
        Me.mnuModelOtherTwoVariablesTwoSamples.Enabled = False
        Me.mnuModelOtherTwoVariablesTwoSamples.Name = "mnuModelOtherTwoVariablesTwoSamples"
        Me.mnuModelOtherTwoVariablesTwoSamples.Size = New System.Drawing.Size(399, 34)
        Me.mnuModelOtherTwoVariablesTwoSamples.Tag = "Two_Samples..."
        Me.mnuModelOtherTwoVariablesTwoSamples.Text = "Two Samples..."
        '
        'mnuModelOtherTwoVariablesSummaryData
        '
        Me.mnuModelOtherTwoVariablesSummaryData.Enabled = False
        Me.mnuModelOtherTwoVariablesSummaryData.Name = "mnuModelOtherTwoVariablesSummaryData"
        Me.mnuModelOtherTwoVariablesSummaryData.Size = New System.Drawing.Size(399, 34)
        Me.mnuModelOtherTwoVariablesSummaryData.Tag = "Summary_Data..."
        Me.mnuModelOtherTwoVariablesSummaryData.Text = "Summary Data..."
        '
        'mnuModelOtherTwoVariablesSimpleRegression
        '
        Me.mnuModelOtherTwoVariablesSimpleRegression.Name = "mnuModelOtherTwoVariablesSimpleRegression"
        Me.mnuModelOtherTwoVariablesSimpleRegression.Size = New System.Drawing.Size(399, 34)
        Me.mnuModelOtherTwoVariablesSimpleRegression.Tag = "Simple_Regression..."
        Me.mnuModelOtherTwoVariablesSimpleRegression.Text = "Simple Regression..."
        '
        'mnuModelOtherTwoVariablesOneWayANOVA
        '
        Me.mnuModelOtherTwoVariablesOneWayANOVA.Name = "mnuModelOtherTwoVariablesOneWayANOVA"
        Me.mnuModelOtherTwoVariablesOneWayANOVA.Size = New System.Drawing.Size(399, 34)
        Me.mnuModelOtherTwoVariablesOneWayANOVA.Tag = "One_Way_ANOVA..."
        Me.mnuModelOtherTwoVariablesOneWayANOVA.Text = "One Way ANOVA..."
        '
        'mnuModelOtherTwoVariablesNonParametricTwoSamples
        '
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Enabled = False
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Name = "mnuModelOtherTwoVariablesNonParametricTwoSamples"
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Size = New System.Drawing.Size(399, 34)
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Tag = "Non_Parameteric_Two_Samples..."
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Text = "Non Parametric Two Samples..."
        '
        'mnuModelOtherTwoVariablesNonParametricOneWayANOVA
        '
        Me.mnuModelOtherTwoVariablesNonParametricOneWayANOVA.Name = "mnuModelOtherTwoVariablesNonParametricOneWayANOVA"
        Me.mnuModelOtherTwoVariablesNonParametricOneWayANOVA.Size = New System.Drawing.Size(399, 34)
        Me.mnuModelOtherTwoVariablesNonParametricOneWayANOVA.Tag = "Non_Parameteric_One_Way_ANOVA..."
        Me.mnuModelOtherTwoVariablesNonParametricOneWayANOVA.Text = "Non Parameteric One Way ANOVA..."
        '
        'mnuModelOtherThreeVariables
        '
        Me.mnuModelOtherThreeVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelOtherThreeVariablesSimpleWithGroups, Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA, Me.mnuModelOtherThreeVariablesChisquareTest})
        Me.mnuModelOtherThreeVariables.Enabled = False
        Me.mnuModelOtherThreeVariables.Name = "mnuModelOtherThreeVariables"
        Me.mnuModelOtherThreeVariables.Size = New System.Drawing.Size(305, 34)
        Me.mnuModelOtherThreeVariables.Tag = "Other_(Three_Variable)"
        Me.mnuModelOtherThreeVariables.Text = "Other (Three Variable)"
        '
        'mnuModelOtherThreeVariablesSimpleWithGroups
        '
        Me.mnuModelOtherThreeVariablesSimpleWithGroups.Enabled = False
        Me.mnuModelOtherThreeVariablesSimpleWithGroups.Name = "mnuModelOtherThreeVariablesSimpleWithGroups"
        Me.mnuModelOtherThreeVariablesSimpleWithGroups.Size = New System.Drawing.Size(389, 34)
        Me.mnuModelOtherThreeVariablesSimpleWithGroups.Tag = "Simple_with_groups..."
        Me.mnuModelOtherThreeVariablesSimpleWithGroups.Text = "Simple With Groups..."
        '
        'mnuModelOtherThreeVariablesNonParametricTwoWayANOVA
        '
        Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Name = "mnuModelOtherThreeVariablesNonParametricTwoWayANOVA"
        Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Size = New System.Drawing.Size(389, 34)
        Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Tag = "Non_Parametric_Two_Way_ANOVA..."
        Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Text = "Non Parametric Two Way ANOVA..."
        '
        'mnuModelOtherThreeVariablesChisquareTest
        '
        Me.mnuModelOtherThreeVariablesChisquareTest.Name = "mnuModelOtherThreeVariablesChisquareTest"
        Me.mnuModelOtherThreeVariablesChisquareTest.Size = New System.Drawing.Size(389, 34)
        Me.mnuModelOtherThreeVariablesChisquareTest.Tag = "Chi-square_Test"
        Me.mnuModelOtherThreeVariablesChisquareTest.Text = "Chi-square Test..."
        '
        'mnuModelOtherGeneral
        '
        Me.mnuModelOtherGeneral.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelOtherGeneralANOVAGeneral, Me.mnuModelOtherGeneralRegression, Me.mnuModelOtherGeneralLogLinear})
        Me.mnuModelOtherGeneral.Enabled = False
        Me.mnuModelOtherGeneral.Name = "mnuModelOtherGeneral"
        Me.mnuModelOtherGeneral.Size = New System.Drawing.Size(305, 34)
        Me.mnuModelOtherGeneral.Tag = "Other_(General)"
        Me.mnuModelOtherGeneral.Text = "Other (General)"
        '
        'mnuModelOtherGeneralANOVAGeneral
        '
        Me.mnuModelOtherGeneralANOVAGeneral.Enabled = False
        Me.mnuModelOtherGeneralANOVAGeneral.Name = "mnuModelOtherGeneralANOVAGeneral"
        Me.mnuModelOtherGeneralANOVAGeneral.Size = New System.Drawing.Size(251, 34)
        Me.mnuModelOtherGeneralANOVAGeneral.Tag = "ANOVA_General..."
        Me.mnuModelOtherGeneralANOVAGeneral.Text = "ANOVA General..."
        '
        'mnuModelOtherGeneralRegression
        '
        Me.mnuModelOtherGeneralRegression.Enabled = False
        Me.mnuModelOtherGeneralRegression.Name = "mnuModelOtherGeneralRegression"
        Me.mnuModelOtherGeneralRegression.Size = New System.Drawing.Size(251, 34)
        Me.mnuModelOtherGeneralRegression.Tag = "Regression..."
        Me.mnuModelOtherGeneralRegression.Text = "Regression..."
        '
        'mnuModelOtherGeneralLogLinear
        '
        Me.mnuModelOtherGeneralLogLinear.Enabled = False
        Me.mnuModelOtherGeneralLogLinear.Name = "mnuModelOtherGeneralLogLinear"
        Me.mnuModelOtherGeneralLogLinear.Size = New System.Drawing.Size(251, 34)
        Me.mnuModelOtherGeneralLogLinear.Tag = "Log_Linear"
        Me.mnuModelOtherGeneralLogLinear.Text = "Log Linear..."
        '
        'mnuClimaticExamine
        '
        Me.mnuClimaticExamine.Enabled = False
        Me.mnuClimaticExamine.Name = "mnuClimaticExamine"
        Me.mnuClimaticExamine.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticExamine.Tag = "Examine"
        Me.mnuClimaticExamine.Text = "Examine..."
        Me.mnuClimaticExamine.Visible = False
        '
        'mnuClimaticProcess
        '
        Me.mnuClimaticProcess.Enabled = False
        Me.mnuClimaticProcess.Name = "mnuClimaticProcess"
        Me.mnuClimaticProcess.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticProcess.Tag = "Process"
        Me.mnuClimaticProcess.Text = "Process..."
        Me.mnuClimaticProcess.Visible = False
        '
        'mnuClimaticEvaporation
        '
        Me.mnuClimaticEvaporation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticEvaporationSite, Me.mnuClimaticEvaporationPenman})
        Me.mnuClimaticEvaporation.Name = "mnuClimaticEvaporation"
        Me.mnuClimaticEvaporation.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticEvaporation.Tag = "Evaporation"
        Me.mnuClimaticEvaporation.Text = "Evaporation"
        Me.mnuClimaticEvaporation.Visible = False
        '
        'mnuClimaticEvaporationSite
        '
        Me.mnuClimaticEvaporationSite.Enabled = False
        Me.mnuClimaticEvaporationSite.Name = "mnuClimaticEvaporationSite"
        Me.mnuClimaticEvaporationSite.Size = New System.Drawing.Size(189, 34)
        Me.mnuClimaticEvaporationSite.Tag = "Site"
        Me.mnuClimaticEvaporationSite.Text = "Site..."
        '
        'mnuClimaticEvaporationPenman
        '
        Me.mnuClimaticEvaporationPenman.Enabled = False
        Me.mnuClimaticEvaporationPenman.Name = "mnuClimaticEvaporationPenman"
        Me.mnuClimaticEvaporationPenman.Size = New System.Drawing.Size(189, 34)
        Me.mnuClimaticEvaporationPenman.Tag = "Penman"
        Me.mnuClimaticEvaporationPenman.Text = "Penman..."
        '
        'mnuClimaticCrop
        '
        Me.mnuClimaticCrop.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticCropCropCoefficients, Me.mnuClimaticCropWaterSatisfactionIndex})
        Me.mnuClimaticCrop.Name = "mnuClimaticCrop"
        Me.mnuClimaticCrop.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticCrop.Tag = "Crop"
        Me.mnuClimaticCrop.Text = "Crop"
        Me.mnuClimaticCrop.Visible = False
        '
        'mnuClimaticCropCropCoefficients
        '
        Me.mnuClimaticCropCropCoefficients.Enabled = False
        Me.mnuClimaticCropCropCoefficients.Name = "mnuClimaticCropCropCoefficients"
        Me.mnuClimaticCropCropCoefficients.Size = New System.Drawing.Size(316, 34)
        Me.mnuClimaticCropCropCoefficients.Text = "Crop Coefficients..."
        '
        'mnuClimaticCropWaterSatisfactionIndex
        '
        Me.mnuClimaticCropWaterSatisfactionIndex.Enabled = False
        Me.mnuClimaticCropWaterSatisfactionIndex.Name = "mnuClimaticCropWaterSatisfactionIndex"
        Me.mnuClimaticCropWaterSatisfactionIndex.Size = New System.Drawing.Size(316, 34)
        Me.mnuClimaticCropWaterSatisfactionIndex.Text = "Water Satisfaction Index..."
        '
        'mnuClimaticHeatSum
        '
        Me.mnuClimaticHeatSum.Enabled = False
        Me.mnuClimaticHeatSum.Name = "mnuClimaticHeatSum"
        Me.mnuClimaticHeatSum.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticHeatSum.Tag = "Heat_Sum"
        Me.mnuClimaticHeatSum.Text = "Heat Sum..."
        Me.mnuClimaticHeatSum.Visible = False
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewDataView, Me.mnuViewOutput, Me.mnuViewLogScript, Me.mnuViewColumnMetadata, Me.mnuViewDataFrameMetadata, Me.mnuViewStructuredMenu, Me.ToolStripSeparator22, Me.mnuViewClimaticMenu, Me.mnuViewProcurementMenu, Me.mnuViewOptionsByContextMenu, Me.ToolStripSeparator39, Me.mnuViewResetToDefaultLayout, Me.mnuViewSwapDataAndMetadata})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(65, 29)
        Me.mnuView.Tag = "View"
        Me.mnuView.Text = "View"
        '
        'mnuViewDataView
        '
        Me.mnuViewDataView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuViewDataView.Name = "mnuViewDataView"
        Me.mnuViewDataView.Size = New System.Drawing.Size(314, 34)
        Me.mnuViewDataView.Tag = "Data_View"
        Me.mnuViewDataView.Text = "Data View"
        '
        'mnuViewOutput
        '
        Me.mnuViewOutput.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuViewOutput.Name = "mnuViewOutput"
        Me.mnuViewOutput.Size = New System.Drawing.Size(314, 34)
        Me.mnuViewOutput.Text = "Output"
        '
        'mnuViewLogScript
        '
        Me.mnuViewLogScript.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuViewLogScript.Name = "mnuViewLogScript"
        Me.mnuViewLogScript.Size = New System.Drawing.Size(314, 34)
        Me.mnuViewLogScript.Text = "Log/Script"
        '
        'mnuViewColumnMetadata
        '
        Me.mnuViewColumnMetadata.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuViewColumnMetadata.Name = "mnuViewColumnMetadata"
        Me.mnuViewColumnMetadata.Size = New System.Drawing.Size(314, 34)
        Me.mnuViewColumnMetadata.Tag = "Column_Metadata"
        Me.mnuViewColumnMetadata.Text = "Column Metadata"
        '
        'mnuViewDataFrameMetadata
        '
        Me.mnuViewDataFrameMetadata.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuViewDataFrameMetadata.Name = "mnuViewDataFrameMetadata"
        Me.mnuViewDataFrameMetadata.Size = New System.Drawing.Size(314, 34)
        Me.mnuViewDataFrameMetadata.Tag = "Data_Frame_Metadata"
        Me.mnuViewDataFrameMetadata.Text = "Data Frame Metadata"
        '
        'mnuViewStructuredMenu
        '
        Me.mnuViewStructuredMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuViewStructuredMenu.Name = "mnuViewStructuredMenu"
        Me.mnuViewStructuredMenu.Size = New System.Drawing.Size(314, 34)
        Me.mnuViewStructuredMenu.Text = "Structured Menu"
        '
        'ToolStripSeparator22
        '
        Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
        Me.ToolStripSeparator22.Size = New System.Drawing.Size(311, 6)
        '
        'mnuViewClimaticMenu
        '
        Me.mnuViewClimaticMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuViewClimaticMenu.Name = "mnuViewClimaticMenu"
        Me.mnuViewClimaticMenu.Size = New System.Drawing.Size(314, 34)
        Me.mnuViewClimaticMenu.Tag = ""
        Me.mnuViewClimaticMenu.Text = "Climatic Menu"
        '
        'mnuViewProcurementMenu
        '
        Me.mnuViewProcurementMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuViewProcurementMenu.Name = "mnuViewProcurementMenu"
        Me.mnuViewProcurementMenu.Size = New System.Drawing.Size(314, 34)
        Me.mnuViewProcurementMenu.Tag = ""
        Me.mnuViewProcurementMenu.Text = "Procurement Menu"
        '
        'mnuViewOptionsByContextMenu
        '
        Me.mnuViewOptionsByContextMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuViewOptionsByContextMenu.Name = "mnuViewOptionsByContextMenu"
        Me.mnuViewOptionsByContextMenu.Size = New System.Drawing.Size(314, 34)
        Me.mnuViewOptionsByContextMenu.Text = "Experiments"
        '
        'ToolStripSeparator39
        '
        Me.ToolStripSeparator39.Name = "ToolStripSeparator39"
        Me.ToolStripSeparator39.Size = New System.Drawing.Size(311, 6)
        '
        'mnuViewResetToDefaultLayout
        '
        Me.mnuViewResetToDefaultLayout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuViewResetToDefaultLayout.Name = "mnuViewResetToDefaultLayout"
        Me.mnuViewResetToDefaultLayout.Size = New System.Drawing.Size(314, 34)
        Me.mnuViewResetToDefaultLayout.Text = "Reset to Default Layout"
        '
        'mnuViewSwapDataAndMetadata
        '
        Me.mnuViewSwapDataAndMetadata.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuViewSwapDataAndMetadata.Name = "mnuViewSwapDataAndMetadata"
        Me.mnuViewSwapDataAndMetadata.Size = New System.Drawing.Size(314, 34)
        Me.mnuViewSwapDataAndMetadata.Text = "Swap Data and Metadata"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpHelpIntroduction, Me.mnuHelpFAQ, Me.mnuHelpGetingStarted, Me.ToolStripSeparator28, Me.mnuHelpWindows, Me.mnuHelpMenus, Me.mnuHelpAboutR, Me.mnuHelpLearningStatistics, Me.mnuHelpRPackages, Me.mnuHelpGlossary, Me.mnuHelpData, Me.mnuHelpLicence, Me.ToolStripSeparator29, Me.mnuHelpPackagesDocumentation})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(65, 29)
        Me.mnuHelp.Tag = "Help"
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpHelpIntroduction
        '
        Me.mnuHelpHelpIntroduction.Name = "mnuHelpHelpIntroduction"
        Me.mnuHelpHelpIntroduction.Size = New System.Drawing.Size(314, 34)
        Me.mnuHelpHelpIntroduction.Text = "Introduction"
        '
        'mnuHelpFAQ
        '
        Me.mnuHelpFAQ.Name = "mnuHelpFAQ"
        Me.mnuHelpFAQ.Size = New System.Drawing.Size(314, 34)
        Me.mnuHelpFAQ.Text = "FAQ"
        '
        'mnuHelpGetingStarted
        '
        Me.mnuHelpGetingStarted.Name = "mnuHelpGetingStarted"
        Me.mnuHelpGetingStarted.Size = New System.Drawing.Size(314, 34)
        Me.mnuHelpGetingStarted.Text = "Getting Started"
        '
        'ToolStripSeparator28
        '
        Me.ToolStripSeparator28.Name = "ToolStripSeparator28"
        Me.ToolStripSeparator28.Size = New System.Drawing.Size(311, 6)
        '
        'mnuHelpWindows
        '
        Me.mnuHelpWindows.Name = "mnuHelpWindows"
        Me.mnuHelpWindows.Size = New System.Drawing.Size(314, 34)
        Me.mnuHelpWindows.Text = "Windows"
        '
        'mnuHelpMenus
        '
        Me.mnuHelpMenus.Name = "mnuHelpMenus"
        Me.mnuHelpMenus.Size = New System.Drawing.Size(314, 34)
        Me.mnuHelpMenus.Text = "Menus and Dialogs"
        '
        'mnuHelpAboutR
        '
        Me.mnuHelpAboutR.Name = "mnuHelpAboutR"
        Me.mnuHelpAboutR.Size = New System.Drawing.Size(314, 34)
        Me.mnuHelpAboutR.Text = "About R"
        Me.mnuHelpAboutR.Visible = False
        '
        'mnuHelpLearningStatistics
        '
        Me.mnuHelpLearningStatistics.Name = "mnuHelpLearningStatistics"
        Me.mnuHelpLearningStatistics.Size = New System.Drawing.Size(314, 34)
        Me.mnuHelpLearningStatistics.Text = "Learning Statistics"
        Me.mnuHelpLearningStatistics.Visible = False
        '
        'mnuHelpRPackages
        '
        Me.mnuHelpRPackages.Name = "mnuHelpRPackages"
        Me.mnuHelpRPackages.Size = New System.Drawing.Size(314, 34)
        Me.mnuHelpRPackages.Text = "R Packages"
        '
        'mnuHelpGlossary
        '
        Me.mnuHelpGlossary.Name = "mnuHelpGlossary"
        Me.mnuHelpGlossary.Size = New System.Drawing.Size(314, 34)
        Me.mnuHelpGlossary.Text = "Glossary"
        '
        'mnuHelpData
        '
        Me.mnuHelpData.Name = "mnuHelpData"
        Me.mnuHelpData.Size = New System.Drawing.Size(314, 34)
        Me.mnuHelpData.Text = "Data"
        '
        'mnuHelpLicence
        '
        Me.mnuHelpLicence.Name = "mnuHelpLicence"
        Me.mnuHelpLicence.Size = New System.Drawing.Size(314, 34)
        Me.mnuHelpLicence.Tag = "Licence..."
        Me.mnuHelpLicence.Text = "Licence"
        '
        'ToolStripSeparator29
        '
        Me.ToolStripSeparator29.Name = "ToolStripSeparator29"
        Me.ToolStripSeparator29.Size = New System.Drawing.Size(311, 6)
        '
        'mnuHelpPackagesDocumentation
        '
        Me.mnuHelpPackagesDocumentation.Name = "mnuHelpPackagesDocumentation"
        Me.mnuHelpPackagesDocumentation.Size = New System.Drawing.Size(314, 34)
        Me.mnuHelpPackagesDocumentation.Text = "Packages Documentation"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(322, 6)
        '
        'mnuClimatic
        '
        Me.mnuClimatic.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticFile, Me.ToolStripSeparator18, Me.mnuClimaticTidyandExamine, Me.mnuExamineEditData, Me.mnuClimaticDates, Me.mnuClimaticDefineClimaticData, Me.mnuClimaticCheckData, Me.mnuClimaticPrepare, Me.ToolStripSeparator30, Me.mnuClimaticDescribe, Me.mnuClimaticNCMP, Me.mnuClimaticPICSA, Me.mnuCMSAF, Me.mnuClimaticCompare, Me.mnuClimaticMapping, Me.ToolStripSeparator16, Me.mnuClimaticModel, Me.mnuClimaticExamine, Me.mnuClimaticProcess, Me.ToolStripSeparator23, Me.mnuClimaticSCF, Me.mnuClimaticEvaporation, Me.mnuClimaticCrop, Me.mnuClimaticHeatSum, Me.mnuClimaticClimateMethods})
        Me.mnuClimatic.Name = "mnuClimatic"
        Me.mnuClimatic.Size = New System.Drawing.Size(90, 29)
        Me.mnuClimatic.Tag = "Climatic"
        Me.mnuClimatic.Text = "Climatic"
        '
        'mnuClimaticFile
        '
        Me.mnuClimaticFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticFileImportSST, Me.mnuClimaticFileImportfromIRIDataLibrary, Me.mnuClimaticFileImportfromClimateDataStore, Me.mnuClimaticFileImportandTidyNetCDF, Me.mnuClimaticFileImportandTidyShapefile, Me.ToolStripSeparator20, Me.mnuClimateFileImportfromClimSoft, Me.mnuClimateFileImportfromClimSoftWizard, Me.mnuClimaticFileImportfromCliData, Me.ToolStripSeparator15, Me.mnuClimaticFileExportToClimsoft, Me.mnuClimaticFileExportToCPT, Me.mnuExportToWWRToolStrip})
        Me.mnuClimaticFile.Name = "mnuClimaticFile"
        Me.mnuClimaticFile.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticFile.Text = "File"
        '
        'mnuClimaticFileImportSST
        '
        Me.mnuClimaticFileImportSST.Name = "mnuClimaticFileImportSST"
        Me.mnuClimaticFileImportSST.Size = New System.Drawing.Size(426, 34)
        Me.mnuClimaticFileImportSST.Text = "Import SST..."
        '
        'mnuClimaticFileImportfromIRIDataLibrary
        '
        Me.mnuClimaticFileImportfromIRIDataLibrary.Name = "mnuClimaticFileImportfromIRIDataLibrary"
        Me.mnuClimaticFileImportfromIRIDataLibrary.Size = New System.Drawing.Size(426, 34)
        Me.mnuClimaticFileImportfromIRIDataLibrary.Text = "Import from IRI Data Library..."
        '
        'mnuClimaticFileImportfromClimateDataStore
        '
        Me.mnuClimaticFileImportfromClimateDataStore.Name = "mnuClimaticFileImportfromClimateDataStore"
        Me.mnuClimaticFileImportfromClimateDataStore.Size = New System.Drawing.Size(426, 34)
        Me.mnuClimaticFileImportfromClimateDataStore.Text = "Import from CDS (Climate Data Store)..."
        '
        'mnuClimaticFileImportandTidyNetCDF
        '
        Me.mnuClimaticFileImportandTidyNetCDF.Name = "mnuClimaticFileImportandTidyNetCDF"
        Me.mnuClimaticFileImportandTidyNetCDF.Size = New System.Drawing.Size(426, 34)
        Me.mnuClimaticFileImportandTidyNetCDF.Text = "Import and Tidy NetCDF..."
        '
        'mnuClimaticFileImportandTidyShapefile
        '
        Me.mnuClimaticFileImportandTidyShapefile.Name = "mnuClimaticFileImportandTidyShapefile"
        Me.mnuClimaticFileImportandTidyShapefile.Size = New System.Drawing.Size(426, 34)
        Me.mnuClimaticFileImportandTidyShapefile.Text = "Import and Tidy Shapefile..."
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(423, 6)
        '
        'mnuClimateFileImportfromClimSoft
        '
        Me.mnuClimateFileImportfromClimSoft.Name = "mnuClimateFileImportfromClimSoft"
        Me.mnuClimateFileImportfromClimSoft.Size = New System.Drawing.Size(426, 34)
        Me.mnuClimateFileImportfromClimSoft.Text = "Import from Climsoft..."
        '
        'mnuClimateFileImportfromClimSoftWizard
        '
        Me.mnuClimateFileImportfromClimSoftWizard.Name = "mnuClimateFileImportfromClimSoftWizard"
        Me.mnuClimateFileImportfromClimSoftWizard.Size = New System.Drawing.Size(426, 34)
        Me.mnuClimateFileImportfromClimSoftWizard.Text = "Import from Climsoft Wizard..."
        '
        'mnuClimaticFileImportfromCliData
        '
        Me.mnuClimaticFileImportfromCliData.Enabled = False
        Me.mnuClimaticFileImportfromCliData.Name = "mnuClimaticFileImportfromCliData"
        Me.mnuClimaticFileImportfromCliData.Size = New System.Drawing.Size(426, 34)
        Me.mnuClimaticFileImportfromCliData.Text = "Import from CLIDATA..."
        Me.mnuClimaticFileImportfromCliData.Visible = False
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(423, 6)
        '
        'mnuClimaticFileExportToClimsoft
        '
        Me.mnuClimaticFileExportToClimsoft.Name = "mnuClimaticFileExportToClimsoft"
        Me.mnuClimaticFileExportToClimsoft.Size = New System.Drawing.Size(426, 34)
        Me.mnuClimaticFileExportToClimsoft.Text = "Export to Climsoft..."
        '
        'mnuClimaticFileExportToCPT
        '
        Me.mnuClimaticFileExportToCPT.Name = "mnuClimaticFileExportToCPT"
        Me.mnuClimaticFileExportToCPT.Size = New System.Drawing.Size(426, 34)
        Me.mnuClimaticFileExportToCPT.Tag = "Export_to_CPT"
        Me.mnuClimaticFileExportToCPT.Text = "Export to CPT..."
        '
        'mnuExportToWWRToolStrip
        '
        Me.mnuExportToWWRToolStrip.Name = "mnuExportToWWRToolStrip"
        Me.mnuExportToWWRToolStrip.Size = New System.Drawing.Size(426, 34)
        Me.mnuExportToWWRToolStrip.Text = "Export to World Weather Records..."
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(322, 6)
        '
        'mnuClimaticTidyandExamine
        '
        Me.mnuClimaticTidyandExamine.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticTidyandExamineVisualiseData, Me.mnuClimaticTidyandExamineTidyDailyData, Me.mnuClimaticTidyandExamineNonNumericCases, Me.mnuClimaticTidyandExamineReplaceValues, Me.mnuClimaticTidyandExamineDuplicateRows, Me.ToolStripSeparator54, Me.mnuClimaticTidyandExamineStack, Me.mnuClimaticTidyandExamineUnstack, Me.mnuClimaticTidyandExamineMerge, Me.mnuClimaticTidyandExamineAppend, Me.ToolStripSeparator69, Me.mnuClimaticTidyandExamineTransformText, Me.mnuClimaticTidyandExamineSplitText})
        Me.mnuClimaticTidyandExamine.Name = "mnuClimaticTidyandExamine"
        Me.mnuClimaticTidyandExamine.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticTidyandExamine.Text = "Tidy Data"
        '
        'mnuClimaticTidyandExamineVisualiseData
        '
        Me.mnuClimaticTidyandExamineVisualiseData.Name = "mnuClimaticTidyandExamineVisualiseData"
        Me.mnuClimaticTidyandExamineVisualiseData.Size = New System.Drawing.Size(295, 34)
        Me.mnuClimaticTidyandExamineVisualiseData.Text = "Visualise Data..."
        '
        'mnuClimaticTidyandExamineTidyDailyData
        '
        Me.mnuClimaticTidyandExamineTidyDailyData.Name = "mnuClimaticTidyandExamineTidyDailyData"
        Me.mnuClimaticTidyandExamineTidyDailyData.Size = New System.Drawing.Size(295, 34)
        Me.mnuClimaticTidyandExamineTidyDailyData.Text = "Tidy Daily Data..."
        '
        'mnuClimaticTidyandExamineNonNumericCases
        '
        Me.mnuClimaticTidyandExamineNonNumericCases.Name = "mnuClimaticTidyandExamineNonNumericCases"
        Me.mnuClimaticTidyandExamineNonNumericCases.Size = New System.Drawing.Size(295, 34)
        Me.mnuClimaticTidyandExamineNonNumericCases.Text = "Non-Numeric Values..."
        '
        'mnuClimaticTidyandExamineReplaceValues
        '
        Me.mnuClimaticTidyandExamineReplaceValues.Name = "mnuClimaticTidyandExamineReplaceValues"
        Me.mnuClimaticTidyandExamineReplaceValues.Size = New System.Drawing.Size(295, 34)
        Me.mnuClimaticTidyandExamineReplaceValues.Text = "Replace Values..."
        '
        'mnuClimaticTidyandExamineDuplicateRows
        '
        Me.mnuClimaticTidyandExamineDuplicateRows.Name = "mnuClimaticTidyandExamineDuplicateRows"
        Me.mnuClimaticTidyandExamineDuplicateRows.Size = New System.Drawing.Size(295, 34)
        Me.mnuClimaticTidyandExamineDuplicateRows.Text = "Duplicate Rows..."
        '
        'ToolStripSeparator54
        '
        Me.ToolStripSeparator54.Name = "ToolStripSeparator54"
        Me.ToolStripSeparator54.Size = New System.Drawing.Size(292, 6)
        '
        'mnuClimaticTidyandExamineStack
        '
        Me.mnuClimaticTidyandExamineStack.Name = "mnuClimaticTidyandExamineStack"
        Me.mnuClimaticTidyandExamineStack.Size = New System.Drawing.Size(295, 34)
        Me.mnuClimaticTidyandExamineStack.Text = "Stack (Pivot Longer)..."
        '
        'mnuClimaticTidyandExamineUnstack
        '
        Me.mnuClimaticTidyandExamineUnstack.Name = "mnuClimaticTidyandExamineUnstack"
        Me.mnuClimaticTidyandExamineUnstack.Size = New System.Drawing.Size(295, 34)
        Me.mnuClimaticTidyandExamineUnstack.Text = "Unstack (Pivot Wider)..."
        '
        'mnuClimaticTidyandExamineMerge
        '
        Me.mnuClimaticTidyandExamineMerge.Name = "mnuClimaticTidyandExamineMerge"
        Me.mnuClimaticTidyandExamineMerge.Size = New System.Drawing.Size(295, 34)
        Me.mnuClimaticTidyandExamineMerge.Text = "Merge..."
        '
        'mnuClimaticTidyandExamineAppend
        '
        Me.mnuClimaticTidyandExamineAppend.Name = "mnuClimaticTidyandExamineAppend"
        Me.mnuClimaticTidyandExamineAppend.Size = New System.Drawing.Size(295, 34)
        Me.mnuClimaticTidyandExamineAppend.Text = "Append (Bind Rows)..."
        '
        'ToolStripSeparator69
        '
        Me.ToolStripSeparator69.Name = "ToolStripSeparator69"
        Me.ToolStripSeparator69.Size = New System.Drawing.Size(292, 6)
        '
        'mnuClimaticTidyandExamineTransformText
        '
        Me.mnuClimaticTidyandExamineTransformText.Name = "mnuClimaticTidyandExamineTransformText"
        Me.mnuClimaticTidyandExamineTransformText.Size = New System.Drawing.Size(295, 34)
        Me.mnuClimaticTidyandExamineTransformText.Text = "Transform Text..."
        '
        'mnuClimaticTidyandExamineSplitText
        '
        Me.mnuClimaticTidyandExamineSplitText.Name = "mnuClimaticTidyandExamineSplitText"
        Me.mnuClimaticTidyandExamineSplitText.Size = New System.Drawing.Size(295, 34)
        Me.mnuClimaticTidyandExamineSplitText.Text = "Split Text..."
        '
        'mnuExamineEditData
        '
        Me.mnuExamineEditData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExamineEditDataOneVariableSummarise, Me.mnuExamineEditDataOneVariableGraph, Me.mnuExamineEditDataOneVariableFrequencies, Me.ToolStripSeparator78, Me.mnuExamineEditDataPivotTable, Me.ToolStripSeparator79, Me.mnuExamineEditDataSetupForDataEditing, Me.mnuExamineEditDataDailyDataEditing, Me.mnuExamineEditDataCompareColumns})
        Me.mnuExamineEditData.Name = "mnuExamineEditData"
        Me.mnuExamineEditData.Size = New System.Drawing.Size(325, 34)
        Me.mnuExamineEditData.Text = "Examine/Edit Data"
        '
        'mnuExamineEditDataOneVariableSummarise
        '
        Me.mnuExamineEditDataOneVariableSummarise.Name = "mnuExamineEditDataOneVariableSummarise"
        Me.mnuExamineEditDataOneVariableSummarise.Size = New System.Drawing.Size(324, 34)
        Me.mnuExamineEditDataOneVariableSummarise.Text = "One Variable Summarise..."
        '
        'mnuExamineEditDataOneVariableGraph
        '
        Me.mnuExamineEditDataOneVariableGraph.Name = "mnuExamineEditDataOneVariableGraph"
        Me.mnuExamineEditDataOneVariableGraph.Size = New System.Drawing.Size(324, 34)
        Me.mnuExamineEditDataOneVariableGraph.Text = "One Variable Graph..."
        '
        'mnuExamineEditDataOneVariableFrequencies
        '
        Me.mnuExamineEditDataOneVariableFrequencies.Name = "mnuExamineEditDataOneVariableFrequencies"
        Me.mnuExamineEditDataOneVariableFrequencies.Size = New System.Drawing.Size(324, 34)
        Me.mnuExamineEditDataOneVariableFrequencies.Text = "One Variable Frequencies..."
        '
        'ToolStripSeparator78
        '
        Me.ToolStripSeparator78.Name = "ToolStripSeparator78"
        Me.ToolStripSeparator78.Size = New System.Drawing.Size(321, 6)
        '
        'mnuExamineEditDataPivotTable
        '
        Me.mnuExamineEditDataPivotTable.Name = "mnuExamineEditDataPivotTable"
        Me.mnuExamineEditDataPivotTable.Size = New System.Drawing.Size(324, 34)
        Me.mnuExamineEditDataPivotTable.Text = "Pivot Table..."
        '
        'ToolStripSeparator79
        '
        Me.ToolStripSeparator79.Name = "ToolStripSeparator79"
        Me.ToolStripSeparator79.Size = New System.Drawing.Size(321, 6)
        '
        'mnuExamineEditDataSetupForDataEditing
        '
        Me.mnuExamineEditDataSetupForDataEditing.Name = "mnuExamineEditDataSetupForDataEditing"
        Me.mnuExamineEditDataSetupForDataEditing.Size = New System.Drawing.Size(324, 34)
        Me.mnuExamineEditDataSetupForDataEditing.Text = "Setup for Data Editing..."
        '
        'mnuExamineEditDataDailyDataEditing
        '
        Me.mnuExamineEditDataDailyDataEditing.Name = "mnuExamineEditDataDailyDataEditing"
        Me.mnuExamineEditDataDailyDataEditing.Size = New System.Drawing.Size(324, 34)
        Me.mnuExamineEditDataDailyDataEditing.Text = "Daily Data Editing..."
        '
        'mnuExamineEditDataCompareColumns
        '
        Me.mnuExamineEditDataCompareColumns.Name = "mnuExamineEditDataCompareColumns"
        Me.mnuExamineEditDataCompareColumns.Size = New System.Drawing.Size(324, 34)
        Me.mnuExamineEditDataCompareColumns.Text = "Compare Columns..."
        '
        'mnuClimaticDates
        '
        Me.mnuClimaticDates.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticDatesGenerateDates, Me.mnuClimaticDatesMakeDate, Me.mnuClimaticDatesInfillMissingDates, Me.mnuClimaticDatesUseDate, Me.mnuClimaticDatesMakeTime, Me.mnuClimaticDatesUseTime})
        Me.mnuClimaticDates.Name = "mnuClimaticDates"
        Me.mnuClimaticDates.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticDates.Text = "Dates"
        '
        'mnuClimaticDatesGenerateDates
        '
        Me.mnuClimaticDatesGenerateDates.Name = "mnuClimaticDatesGenerateDates"
        Me.mnuClimaticDatesGenerateDates.Size = New System.Drawing.Size(246, 34)
        Me.mnuClimaticDatesGenerateDates.Text = "Generate Dates..."
        '
        'mnuClimaticDatesMakeDate
        '
        Me.mnuClimaticDatesMakeDate.Name = "mnuClimaticDatesMakeDate"
        Me.mnuClimaticDatesMakeDate.Size = New System.Drawing.Size(246, 34)
        Me.mnuClimaticDatesMakeDate.Text = "Make Date..."
        '
        'mnuClimaticDatesInfillMissingDates
        '
        Me.mnuClimaticDatesInfillMissingDates.Name = "mnuClimaticDatesInfillMissingDates"
        Me.mnuClimaticDatesInfillMissingDates.Size = New System.Drawing.Size(246, 34)
        Me.mnuClimaticDatesInfillMissingDates.Text = "Fill Date Gaps..."
        '
        'mnuClimaticDatesUseDate
        '
        Me.mnuClimaticDatesUseDate.Name = "mnuClimaticDatesUseDate"
        Me.mnuClimaticDatesUseDate.Size = New System.Drawing.Size(246, 34)
        Me.mnuClimaticDatesUseDate.Text = "Use Date..."
        '
        'mnuClimaticDatesMakeTime
        '
        Me.mnuClimaticDatesMakeTime.Enabled = False
        Me.mnuClimaticDatesMakeTime.Name = "mnuClimaticDatesMakeTime"
        Me.mnuClimaticDatesMakeTime.Size = New System.Drawing.Size(246, 34)
        Me.mnuClimaticDatesMakeTime.Text = "Make Time..."
        Me.mnuClimaticDatesMakeTime.Visible = False
        '
        'mnuClimaticDatesUseTime
        '
        Me.mnuClimaticDatesUseTime.Enabled = False
        Me.mnuClimaticDatesUseTime.Name = "mnuClimaticDatesUseTime"
        Me.mnuClimaticDatesUseTime.Size = New System.Drawing.Size(246, 34)
        Me.mnuClimaticDatesUseTime.Text = "Use Time..."
        Me.mnuClimaticDatesUseTime.Visible = False
        '
        'mnuClimaticDefineClimaticData
        '
        Me.mnuClimaticDefineClimaticData.Name = "mnuClimaticDefineClimaticData"
        Me.mnuClimaticDefineClimaticData.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticDefineClimaticData.Text = "Define Climatic Data..."
        '
        'mnuClimaticCheckData
        '
        Me.mnuClimaticCheckData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticCheckDataInventory, Me.mnuClimaticCheckDataDisplayDaily, Me.ToolStripSeparator65, Me.mnuClimaticCheckDataFillMissingValues, Me.mnuClimaticCheckDataBoxplot, Me.mnuClimaticCheckDataQCTemperatures, Me.mnuClimaticCheckDataQCRainfall, Me.ToolStripSeparator70, Me.mnuClimaticCheckDataHomogenization, Me.mnuClimaticCheckDataCheckStationLocations})
        Me.mnuClimaticCheckData.Name = "mnuClimaticCheckData"
        Me.mnuClimaticCheckData.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticCheckData.Text = "Check Data"
        '
        'mnuClimaticCheckDataInventory
        '
        Me.mnuClimaticCheckDataInventory.Name = "mnuClimaticCheckDataInventory"
        Me.mnuClimaticCheckDataInventory.Size = New System.Drawing.Size(313, 34)
        Me.mnuClimaticCheckDataInventory.Text = "Inventory..."
        '
        'mnuClimaticCheckDataDisplayDaily
        '
        Me.mnuClimaticCheckDataDisplayDaily.Name = "mnuClimaticCheckDataDisplayDaily"
        Me.mnuClimaticCheckDataDisplayDaily.Size = New System.Drawing.Size(313, 34)
        Me.mnuClimaticCheckDataDisplayDaily.Text = "Display Daily..."
        '
        'ToolStripSeparator65
        '
        Me.ToolStripSeparator65.Name = "ToolStripSeparator65"
        Me.ToolStripSeparator65.Size = New System.Drawing.Size(310, 6)
        '
        'mnuClimaticCheckDataFillMissingValues
        '
        Me.mnuClimaticCheckDataFillMissingValues.Name = "mnuClimaticCheckDataFillMissingValues"
        Me.mnuClimaticCheckDataFillMissingValues.Size = New System.Drawing.Size(313, 34)
        Me.mnuClimaticCheckDataFillMissingValues.Text = "Fill Missing Values..."
        '
        'mnuClimaticCheckDataBoxplot
        '
        Me.mnuClimaticCheckDataBoxplot.Name = "mnuClimaticCheckDataBoxplot"
        Me.mnuClimaticCheckDataBoxplot.Size = New System.Drawing.Size(313, 34)
        Me.mnuClimaticCheckDataBoxplot.Text = "Boxplot..."
        '
        'mnuClimaticCheckDataQCTemperatures
        '
        Me.mnuClimaticCheckDataQCTemperatures.Name = "mnuClimaticCheckDataQCTemperatures"
        Me.mnuClimaticCheckDataQCTemperatures.Size = New System.Drawing.Size(313, 34)
        Me.mnuClimaticCheckDataQCTemperatures.Text = "QC Temperatures..."
        '
        'mnuClimaticCheckDataQCRainfall
        '
        Me.mnuClimaticCheckDataQCRainfall.Name = "mnuClimaticCheckDataQCRainfall"
        Me.mnuClimaticCheckDataQCRainfall.Size = New System.Drawing.Size(313, 34)
        Me.mnuClimaticCheckDataQCRainfall.Text = "QC Rainfall..."
        '
        'ToolStripSeparator70
        '
        Me.ToolStripSeparator70.Name = "ToolStripSeparator70"
        Me.ToolStripSeparator70.Size = New System.Drawing.Size(310, 6)
        '
        'mnuClimaticCheckDataHomogenization
        '
        Me.mnuClimaticCheckDataHomogenization.Name = "mnuClimaticCheckDataHomogenization"
        Me.mnuClimaticCheckDataHomogenization.Size = New System.Drawing.Size(313, 34)
        Me.mnuClimaticCheckDataHomogenization.Text = "Homogenization..."
        '
        'mnuClimaticCheckDataCheckStationLocations
        '
        Me.mnuClimaticCheckDataCheckStationLocations.Name = "mnuClimaticCheckDataCheckStationLocations"
        Me.mnuClimaticCheckDataCheckStationLocations.Size = New System.Drawing.Size(313, 34)
        Me.mnuClimaticCheckDataCheckStationLocations.Text = "Check Station Locations..."
        '
        'mnuClimaticPrepare
        '
        Me.mnuClimaticPrepare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCimaticPrepareTransform, Me.mnuClimaticPrepareConversions, Me.ToolStripSeparator37, Me.mnuClimaticPrepareClimaticSummaries, Me.mnuClimaticPrepareStartoftheRains, Me.mnuClimaticPrepareEndOfRains, Me.mnuClimaticPrepareLengthOfSeason, Me.mnuClimaticPrepareSpells, Me.mnuClimaticPrepareExtremes, Me.ToolStripSeparator64, Me.mnuClimaticPrepareClimdex, Me.mnuClimaticPrepareSPI, Me.ToolStripSeparator51, Me.mnuClimaticPrepareEvapotranspiration, Me.mnuClimaticPrepareSummary, Me.mnuClimaticPrepareNewWorksheet, Me.mnuClimaticPrepareImportDailyData, Me.mnuClimaticPrepareMakeFactor, Me.mnuClimaticPrepareShiftDailyData, Me.mnuClimaticPrepareUnstackDailyData, Me.mnuClimaticPrepareStackDailyData})
        Me.mnuClimaticPrepare.Name = "mnuClimaticPrepare"
        Me.mnuClimaticPrepare.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticPrepare.Tag = "Prepare"
        Me.mnuClimaticPrepare.Text = "Prepare"
        '
        'mnuCimaticPrepareTransform
        '
        Me.mnuCimaticPrepareTransform.Name = "mnuCimaticPrepareTransform"
        Me.mnuCimaticPrepareTransform.Size = New System.Drawing.Size(281, 34)
        Me.mnuCimaticPrepareTransform.Text = "Transform..."
        '
        'mnuClimaticPrepareConversions
        '
        Me.mnuClimaticPrepareConversions.Name = "mnuClimaticPrepareConversions"
        Me.mnuClimaticPrepareConversions.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareConversions.Text = "Conversions..."
        '
        'ToolStripSeparator37
        '
        Me.ToolStripSeparator37.Name = "ToolStripSeparator37"
        Me.ToolStripSeparator37.Size = New System.Drawing.Size(278, 6)
        '
        'mnuClimaticPrepareClimaticSummaries
        '
        Me.mnuClimaticPrepareClimaticSummaries.Name = "mnuClimaticPrepareClimaticSummaries"
        Me.mnuClimaticPrepareClimaticSummaries.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareClimaticSummaries.Text = "Climatic Summaries..."
        '
        'mnuClimaticPrepareStartoftheRains
        '
        Me.mnuClimaticPrepareStartoftheRains.Name = "mnuClimaticPrepareStartoftheRains"
        Me.mnuClimaticPrepareStartoftheRains.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareStartoftheRains.Text = "Start of the Rains..."
        '
        'mnuClimaticPrepareEndOfRains
        '
        Me.mnuClimaticPrepareEndOfRains.Name = "mnuClimaticPrepareEndOfRains"
        Me.mnuClimaticPrepareEndOfRains.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareEndOfRains.Text = "End of Rains..."
        '
        'mnuClimaticPrepareLengthOfSeason
        '
        Me.mnuClimaticPrepareLengthOfSeason.Name = "mnuClimaticPrepareLengthOfSeason"
        Me.mnuClimaticPrepareLengthOfSeason.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareLengthOfSeason.Text = "Length of Season..."
        '
        'mnuClimaticPrepareSpells
        '
        Me.mnuClimaticPrepareSpells.Name = "mnuClimaticPrepareSpells"
        Me.mnuClimaticPrepareSpells.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareSpells.Text = "Spells..."
        '
        'mnuClimaticPrepareExtremes
        '
        Me.mnuClimaticPrepareExtremes.Name = "mnuClimaticPrepareExtremes"
        Me.mnuClimaticPrepareExtremes.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareExtremes.Text = "Extremes..."
        '
        'ToolStripSeparator64
        '
        Me.ToolStripSeparator64.Name = "ToolStripSeparator64"
        Me.ToolStripSeparator64.Size = New System.Drawing.Size(278, 6)
        '
        'mnuClimaticPrepareClimdex
        '
        Me.mnuClimaticPrepareClimdex.Name = "mnuClimaticPrepareClimdex"
        Me.mnuClimaticPrepareClimdex.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareClimdex.Text = "Climdex..."
        '
        'mnuClimaticPrepareSPI
        '
        Me.mnuClimaticPrepareSPI.Name = "mnuClimaticPrepareSPI"
        Me.mnuClimaticPrepareSPI.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareSPI.Text = "SPI/SPEI..."
        '
        'ToolStripSeparator51
        '
        Me.ToolStripSeparator51.Name = "ToolStripSeparator51"
        Me.ToolStripSeparator51.Size = New System.Drawing.Size(278, 6)
        '
        'mnuClimaticPrepareEvapotranspiration
        '
        Me.mnuClimaticPrepareEvapotranspiration.Name = "mnuClimaticPrepareEvapotranspiration"
        Me.mnuClimaticPrepareEvapotranspiration.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareEvapotranspiration.Text = "Evapotranspiration..."
        '
        'mnuClimaticPrepareSummary
        '
        Me.mnuClimaticPrepareSummary.Enabled = False
        Me.mnuClimaticPrepareSummary.Name = "mnuClimaticPrepareSummary"
        Me.mnuClimaticPrepareSummary.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareSummary.Text = "Summary..."
        Me.mnuClimaticPrepareSummary.Visible = False
        '
        'mnuClimaticPrepareNewWorksheet
        '
        Me.mnuClimaticPrepareNewWorksheet.Enabled = False
        Me.mnuClimaticPrepareNewWorksheet.Name = "mnuClimaticPrepareNewWorksheet"
        Me.mnuClimaticPrepareNewWorksheet.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareNewWorksheet.Tag = "New_Worksheet"
        Me.mnuClimaticPrepareNewWorksheet.Text = "New Worksheet..."
        Me.mnuClimaticPrepareNewWorksheet.Visible = False
        '
        'mnuClimaticPrepareImportDailyData
        '
        Me.mnuClimaticPrepareImportDailyData.Enabled = False
        Me.mnuClimaticPrepareImportDailyData.Name = "mnuClimaticPrepareImportDailyData"
        Me.mnuClimaticPrepareImportDailyData.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareImportDailyData.Tag = "Import_daily_data"
        Me.mnuClimaticPrepareImportDailyData.Text = "Import daily Data..."
        Me.mnuClimaticPrepareImportDailyData.Visible = False
        '
        'mnuClimaticPrepareMakeFactor
        '
        Me.mnuClimaticPrepareMakeFactor.Enabled = False
        Me.mnuClimaticPrepareMakeFactor.Name = "mnuClimaticPrepareMakeFactor"
        Me.mnuClimaticPrepareMakeFactor.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareMakeFactor.Tag = "Make_Factor"
        Me.mnuClimaticPrepareMakeFactor.Text = "Make Factor..."
        Me.mnuClimaticPrepareMakeFactor.Visible = False
        '
        'mnuClimaticPrepareShiftDailyData
        '
        Me.mnuClimaticPrepareShiftDailyData.Enabled = False
        Me.mnuClimaticPrepareShiftDailyData.Name = "mnuClimaticPrepareShiftDailyData"
        Me.mnuClimaticPrepareShiftDailyData.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareShiftDailyData.Tag = "Shift_Daily_data"
        Me.mnuClimaticPrepareShiftDailyData.Text = "Shift Daily Data..."
        Me.mnuClimaticPrepareShiftDailyData.Visible = False
        '
        'mnuClimaticPrepareUnstackDailyData
        '
        Me.mnuClimaticPrepareUnstackDailyData.Enabled = False
        Me.mnuClimaticPrepareUnstackDailyData.Name = "mnuClimaticPrepareUnstackDailyData"
        Me.mnuClimaticPrepareUnstackDailyData.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareUnstackDailyData.Tag = "Unstack_Daily_data"
        Me.mnuClimaticPrepareUnstackDailyData.Text = "Unstack Daily Data..."
        Me.mnuClimaticPrepareUnstackDailyData.Visible = False
        '
        'mnuClimaticPrepareStackDailyData
        '
        Me.mnuClimaticPrepareStackDailyData.Enabled = False
        Me.mnuClimaticPrepareStackDailyData.Name = "mnuClimaticPrepareStackDailyData"
        Me.mnuClimaticPrepareStackDailyData.Size = New System.Drawing.Size(281, 34)
        Me.mnuClimaticPrepareStackDailyData.Tag = "Stack_Daily_data"
        Me.mnuClimaticPrepareStackDailyData.Text = "Stack Daily data..."
        Me.mnuClimaticPrepareStackDailyData.Visible = False
        '
        'ToolStripSeparator30
        '
        Me.ToolStripSeparator30.Name = "ToolStripSeparator30"
        Me.ToolStripSeparator30.Size = New System.Drawing.Size(322, 6)
        '
        'mnuClimaticDescribe
        '
        Me.mnuClimaticDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticDescribeRainfall, Me.mnuClimaticDescribeTemperatures, Me.mnuClimaticDescribeWindSpeedDirection, Me.mnuClimaticDescribeSunshineRadiation, Me.ToolStripSeparator17, Me.mnuClimaticDescribeGeneral, Me.ToolStripSeparator31})
        Me.mnuClimaticDescribe.Name = "mnuClimaticDescribe"
        Me.mnuClimaticDescribe.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticDescribe.Text = "Describe"
        '
        'mnuClimaticDescribeRainfall
        '
        Me.mnuClimaticDescribeRainfall.Enabled = False
        Me.mnuClimaticDescribeRainfall.Name = "mnuClimaticDescribeRainfall"
        Me.mnuClimaticDescribeRainfall.Size = New System.Drawing.Size(301, 34)
        Me.mnuClimaticDescribeRainfall.Text = "Rainfall..."
        '
        'mnuClimaticDescribeTemperatures
        '
        Me.mnuClimaticDescribeTemperatures.Enabled = False
        Me.mnuClimaticDescribeTemperatures.Name = "mnuClimaticDescribeTemperatures"
        Me.mnuClimaticDescribeTemperatures.Size = New System.Drawing.Size(301, 34)
        Me.mnuClimaticDescribeTemperatures.Text = "Temperature..."
        '
        'mnuClimaticDescribeWindSpeedDirection
        '
        Me.mnuClimaticDescribeWindSpeedDirection.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticDescribeWindSpeedDirectionWindRose})
        Me.mnuClimaticDescribeWindSpeedDirection.Name = "mnuClimaticDescribeWindSpeedDirection"
        Me.mnuClimaticDescribeWindSpeedDirection.Size = New System.Drawing.Size(301, 34)
        Me.mnuClimaticDescribeWindSpeedDirection.Text = "Wind Speed/Direction..."
        '
        'mnuClimaticDescribeWindSpeedDirectionWindRose
        '
        Me.mnuClimaticDescribeWindSpeedDirectionWindRose.Name = "mnuClimaticDescribeWindSpeedDirectionWindRose"
        Me.mnuClimaticDescribeWindSpeedDirectionWindRose.Size = New System.Drawing.Size(211, 34)
        Me.mnuClimaticDescribeWindSpeedDirectionWindRose.Text = "Wind Rose..."
        '
        'mnuClimaticDescribeSunshineRadiation
        '
        Me.mnuClimaticDescribeSunshineRadiation.Enabled = False
        Me.mnuClimaticDescribeSunshineRadiation.Name = "mnuClimaticDescribeSunshineRadiation"
        Me.mnuClimaticDescribeSunshineRadiation.Size = New System.Drawing.Size(301, 34)
        Me.mnuClimaticDescribeSunshineRadiation.Text = "Sunshine/Radiation..."
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(298, 6)
        '
        'mnuClimaticDescribeGeneral
        '
        Me.mnuClimaticDescribeGeneral.Enabled = False
        Me.mnuClimaticDescribeGeneral.Name = "mnuClimaticDescribeGeneral"
        Me.mnuClimaticDescribeGeneral.Size = New System.Drawing.Size(301, 34)
        Me.mnuClimaticDescribeGeneral.Text = "General"
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(298, 6)
        '
        'mnuClimaticNCMP
        '
        Me.mnuClimaticNCMP.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticNCMPIndices, Me.mnuClimaticNCMPVariogram, Me.mnuClimaticNCMPRegionAverage, Me.mnuClimaticNCMPTrendGraphs, Me.mnuClimaticNCMPCountRecords, Me.mnuClimaticNCMPSummary})
        Me.mnuClimaticNCMP.Name = "mnuClimaticNCMP"
        Me.mnuClimaticNCMP.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticNCMP.Text = "NCMP"
        '
        'mnuClimaticNCMPIndices
        '
        Me.mnuClimaticNCMPIndices.Name = "mnuClimaticNCMPIndices"
        Me.mnuClimaticNCMPIndices.Size = New System.Drawing.Size(251, 34)
        Me.mnuClimaticNCMPIndices.Text = "Indices..."
        '
        'mnuClimaticNCMPVariogram
        '
        Me.mnuClimaticNCMPVariogram.Name = "mnuClimaticNCMPVariogram"
        Me.mnuClimaticNCMPVariogram.Size = New System.Drawing.Size(251, 34)
        Me.mnuClimaticNCMPVariogram.Text = "Variogram..."
        '
        'mnuClimaticNCMPRegionAverage
        '
        Me.mnuClimaticNCMPRegionAverage.Name = "mnuClimaticNCMPRegionAverage"
        Me.mnuClimaticNCMPRegionAverage.Size = New System.Drawing.Size(251, 34)
        Me.mnuClimaticNCMPRegionAverage.Text = "Region Average..."
        '
        'mnuClimaticNCMPTrendGraphs
        '
        Me.mnuClimaticNCMPTrendGraphs.Name = "mnuClimaticNCMPTrendGraphs"
        Me.mnuClimaticNCMPTrendGraphs.Size = New System.Drawing.Size(251, 34)
        Me.mnuClimaticNCMPTrendGraphs.Text = "Trend Graphs..."
        '
        'mnuClimaticNCMPCountRecords
        '
        Me.mnuClimaticNCMPCountRecords.Name = "mnuClimaticNCMPCountRecords"
        Me.mnuClimaticNCMPCountRecords.Size = New System.Drawing.Size(251, 34)
        Me.mnuClimaticNCMPCountRecords.Text = "Count Records..."
        '
        'mnuClimaticNCMPSummary
        '
        Me.mnuClimaticNCMPSummary.Name = "mnuClimaticNCMPSummary"
        Me.mnuClimaticNCMPSummary.Size = New System.Drawing.Size(251, 34)
        Me.mnuClimaticNCMPSummary.Text = "Summary..."
        '
        'mnuClimaticPICSA
        '
        Me.mnuClimaticPICSA.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticPICSARainfallGraph, Me.mnuClimaticPICSATemperatureGraph, Me.mnuClimaticPICSAGeneralGraph, Me.ToolStripSeparator73, Me.mnuClimaticPICSACumExeedenceGraph, Me.mnuClimaticPICSACrops})
        Me.mnuClimaticPICSA.Name = "mnuClimaticPICSA"
        Me.mnuClimaticPICSA.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticPICSA.Text = "PICSA"
        '
        'mnuClimaticPICSARainfallGraph
        '
        Me.mnuClimaticPICSARainfallGraph.Name = "mnuClimaticPICSARainfallGraph"
        Me.mnuClimaticPICSARainfallGraph.Size = New System.Drawing.Size(364, 34)
        Me.mnuClimaticPICSARainfallGraph.Text = "Rainfall Graph..."
        '
        'mnuClimaticPICSATemperatureGraph
        '
        Me.mnuClimaticPICSATemperatureGraph.Name = "mnuClimaticPICSATemperatureGraph"
        Me.mnuClimaticPICSATemperatureGraph.Size = New System.Drawing.Size(364, 34)
        Me.mnuClimaticPICSATemperatureGraph.Text = "Temperature Graph..."
        '
        'mnuClimaticPICSAGeneralGraph
        '
        Me.mnuClimaticPICSAGeneralGraph.Name = "mnuClimaticPICSAGeneralGraph"
        Me.mnuClimaticPICSAGeneralGraph.Size = New System.Drawing.Size(364, 34)
        Me.mnuClimaticPICSAGeneralGraph.Text = "General Graph..."
        '
        'ToolStripSeparator73
        '
        Me.ToolStripSeparator73.Name = "ToolStripSeparator73"
        Me.ToolStripSeparator73.Size = New System.Drawing.Size(361, 6)
        '
        'mnuClimaticPICSACumExeedenceGraph
        '
        Me.mnuClimaticPICSACumExeedenceGraph.Name = "mnuClimaticPICSACumExeedenceGraph"
        Me.mnuClimaticPICSACumExeedenceGraph.Size = New System.Drawing.Size(364, 34)
        Me.mnuClimaticPICSACumExeedenceGraph.Text = "Cumulative/Exceedance Graph..."
        '
        'mnuClimaticPICSACrops
        '
        Me.mnuClimaticPICSACrops.Name = "mnuClimaticPICSACrops"
        Me.mnuClimaticPICSACrops.Size = New System.Drawing.Size(364, 34)
        Me.mnuClimaticPICSACrops.Text = "Crops..."
        '
        'mnuCMSAF
        '
        Me.mnuCMSAF.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticCMSAFPlotRegion, Me.mnuClimaticCMSAFExporttoCMSAFRToolbox})
        Me.mnuCMSAF.Name = "mnuCMSAF"
        Me.mnuCMSAF.Size = New System.Drawing.Size(325, 34)
        Me.mnuCMSAF.Text = "CM SAF"
        '
        'mnuClimaticCMSAFPlotRegion
        '
        Me.mnuClimaticCMSAFPlotRegion.Name = "mnuClimaticCMSAFPlotRegion"
        Me.mnuClimaticCMSAFPlotRegion.Size = New System.Drawing.Size(351, 34)
        Me.mnuClimaticCMSAFPlotRegion.Text = "Plot Region..."
        '
        'mnuClimaticCMSAFExporttoCMSAFRToolbox
        '
        Me.mnuClimaticCMSAFExporttoCMSAFRToolbox.Name = "mnuClimaticCMSAFExporttoCMSAFRToolbox"
        Me.mnuClimaticCMSAFExporttoCMSAFRToolbox.Size = New System.Drawing.Size(351, 34)
        Me.mnuClimaticCMSAFExporttoCMSAFRToolbox.Text = "Export to CM SAF R Toolbox..."
        '
        'mnuClimaticCompare
        '
        Me.mnuClimaticCompare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticCompareCalculation, Me.mnuClimaticCompareSummary, Me.ToolStripSeparator66, Me.mnuClimaticCompareCorrelations, Me.mnuClimaticCompareScatterplot, Me.mnuClimaticCompareTimeSeriesPlot, Me.mnuClimaticCompareSeasonalPlot, Me.mnuClimaticCompareDensityPlot, Me.mnuClimaticCompareConditionalQuantiles, Me.mnuClimaticCompareTaylorDiagram})
        Me.mnuClimaticCompare.Name = "mnuClimaticCompare"
        Me.mnuClimaticCompare.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticCompare.Text = "Compare"
        '
        'mnuClimaticCompareCalculation
        '
        Me.mnuClimaticCompareCalculation.Name = "mnuClimaticCompareCalculation"
        Me.mnuClimaticCompareCalculation.Size = New System.Drawing.Size(296, 34)
        Me.mnuClimaticCompareCalculation.Text = "Calculation..."
        '
        'mnuClimaticCompareSummary
        '
        Me.mnuClimaticCompareSummary.Name = "mnuClimaticCompareSummary"
        Me.mnuClimaticCompareSummary.Size = New System.Drawing.Size(296, 34)
        Me.mnuClimaticCompareSummary.Text = "Summary..."
        '
        'ToolStripSeparator66
        '
        Me.ToolStripSeparator66.Name = "ToolStripSeparator66"
        Me.ToolStripSeparator66.Size = New System.Drawing.Size(293, 6)
        '
        'mnuClimaticCompareCorrelations
        '
        Me.mnuClimaticCompareCorrelations.Name = "mnuClimaticCompareCorrelations"
        Me.mnuClimaticCompareCorrelations.Size = New System.Drawing.Size(296, 34)
        Me.mnuClimaticCompareCorrelations.Text = "Correlations..."
        '
        'mnuClimaticCompareScatterplot
        '
        Me.mnuClimaticCompareScatterplot.Name = "mnuClimaticCompareScatterplot"
        Me.mnuClimaticCompareScatterplot.Size = New System.Drawing.Size(296, 34)
        Me.mnuClimaticCompareScatterplot.Text = "Scatterplot..."
        '
        'mnuClimaticCompareTimeSeriesPlot
        '
        Me.mnuClimaticCompareTimeSeriesPlot.Name = "mnuClimaticCompareTimeSeriesPlot"
        Me.mnuClimaticCompareTimeSeriesPlot.Size = New System.Drawing.Size(296, 34)
        Me.mnuClimaticCompareTimeSeriesPlot.Text = "Time Series Plot..."
        '
        'mnuClimaticCompareSeasonalPlot
        '
        Me.mnuClimaticCompareSeasonalPlot.Name = "mnuClimaticCompareSeasonalPlot"
        Me.mnuClimaticCompareSeasonalPlot.Size = New System.Drawing.Size(296, 34)
        Me.mnuClimaticCompareSeasonalPlot.Text = "Seasonal Plot..."
        '
        'mnuClimaticCompareDensityPlot
        '
        Me.mnuClimaticCompareDensityPlot.Name = "mnuClimaticCompareDensityPlot"
        Me.mnuClimaticCompareDensityPlot.Size = New System.Drawing.Size(296, 34)
        Me.mnuClimaticCompareDensityPlot.Text = "Density Plot..."
        '
        'mnuClimaticCompareConditionalQuantiles
        '
        Me.mnuClimaticCompareConditionalQuantiles.Name = "mnuClimaticCompareConditionalQuantiles"
        Me.mnuClimaticCompareConditionalQuantiles.Size = New System.Drawing.Size(296, 34)
        Me.mnuClimaticCompareConditionalQuantiles.Text = "Conditional Quantiles..."
        '
        'mnuClimaticCompareTaylorDiagram
        '
        Me.mnuClimaticCompareTaylorDiagram.Name = "mnuClimaticCompareTaylorDiagram"
        Me.mnuClimaticCompareTaylorDiagram.Size = New System.Drawing.Size(296, 34)
        Me.mnuClimaticCompareTaylorDiagram.Text = "Taylor Diagram..."
        '
        'mnuClimaticMapping
        '
        Me.mnuClimaticMapping.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticMappingMap, Me.mnuClimaticMappingCheckStationLocations})
        Me.mnuClimaticMapping.Name = "mnuClimaticMapping"
        Me.mnuClimaticMapping.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticMapping.Text = "Mapping"
        '
        'mnuClimaticMappingMap
        '
        Me.mnuClimaticMappingMap.Name = "mnuClimaticMappingMap"
        Me.mnuClimaticMappingMap.Size = New System.Drawing.Size(313, 34)
        Me.mnuClimaticMappingMap.Text = "Map..."
        '
        'mnuClimaticMappingCheckStationLocations
        '
        Me.mnuClimaticMappingCheckStationLocations.Name = "mnuClimaticMappingCheckStationLocations"
        Me.mnuClimaticMappingCheckStationLocations.Size = New System.Drawing.Size(313, 34)
        Me.mnuClimaticMappingCheckStationLocations.Text = "Check Station Locations..."
        '
        'mnuClimaticModel
        '
        Me.mnuClimaticModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticModelsExtremes, Me.mnuClimaticModelCircular, Me.mnuClimaticModelMarkovModelling})
        Me.mnuClimaticModel.Name = "mnuClimaticModel"
        Me.mnuClimaticModel.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticModel.Text = "Model"
        '
        'mnuClimaticModelsExtremes
        '
        Me.mnuClimaticModelsExtremes.Name = "mnuClimaticModelsExtremes"
        Me.mnuClimaticModelsExtremes.Size = New System.Drawing.Size(271, 34)
        Me.mnuClimaticModelsExtremes.Text = "Extremes..."
        '
        'mnuClimaticModelCircular
        '
        Me.mnuClimaticModelCircular.Enabled = False
        Me.mnuClimaticModelCircular.Name = "mnuClimaticModelCircular"
        Me.mnuClimaticModelCircular.Size = New System.Drawing.Size(271, 34)
        Me.mnuClimaticModelCircular.Text = "Circular..."
        Me.mnuClimaticModelCircular.Visible = False
        '
        'mnuClimaticModelMarkovModelling
        '
        Me.mnuClimaticModelMarkovModelling.Name = "mnuClimaticModelMarkovModelling"
        Me.mnuClimaticModelMarkovModelling.Size = New System.Drawing.Size(271, 34)
        Me.mnuClimaticModelMarkovModelling.Tag = "Markov_Modelling"
        Me.mnuClimaticModelMarkovModelling.Text = "Markov Modelling..."
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        Me.ToolStripSeparator23.Size = New System.Drawing.Size(322, 6)
        '
        'mnuClimaticSCF
        '
        Me.mnuClimaticSCF.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticSCFSupportOpenSST, Me.mnuClimaticSCFSupportExporttoCPT, Me.ToolStripSeparator32, Me.mnuClimaticSCFSupportCorrelations, Me.mnuClimaticSCFSupportPrincipalComponents, Me.mnuClimaticSCFSupportCanonicalCorrelations, Me.mnuClimaticSCFSupportCumulativeExceedanceGraph})
        Me.mnuClimaticSCF.Name = "mnuClimaticSCF"
        Me.mnuClimaticSCF.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticSCF.Text = "Seasonal Forecast Support"
        '
        'mnuClimaticSCFSupportOpenSST
        '
        Me.mnuClimaticSCFSupportOpenSST.Name = "mnuClimaticSCFSupportOpenSST"
        Me.mnuClimaticSCFSupportOpenSST.Size = New System.Drawing.Size(364, 34)
        Me.mnuClimaticSCFSupportOpenSST.Text = "Open SST..."
        '
        'mnuClimaticSCFSupportExporttoCPT
        '
        Me.mnuClimaticSCFSupportExporttoCPT.Name = "mnuClimaticSCFSupportExporttoCPT"
        Me.mnuClimaticSCFSupportExporttoCPT.Size = New System.Drawing.Size(364, 34)
        Me.mnuClimaticSCFSupportExporttoCPT.Tag = "Export_to_CPT"
        Me.mnuClimaticSCFSupportExporttoCPT.Text = "Export to CPT..."
        '
        'ToolStripSeparator32
        '
        Me.ToolStripSeparator32.Name = "ToolStripSeparator32"
        Me.ToolStripSeparator32.Size = New System.Drawing.Size(361, 6)
        '
        'mnuClimaticSCFSupportCorrelations
        '
        Me.mnuClimaticSCFSupportCorrelations.Name = "mnuClimaticSCFSupportCorrelations"
        Me.mnuClimaticSCFSupportCorrelations.Size = New System.Drawing.Size(364, 34)
        Me.mnuClimaticSCFSupportCorrelations.Text = "Correlations..."
        '
        'mnuClimaticSCFSupportPrincipalComponents
        '
        Me.mnuClimaticSCFSupportPrincipalComponents.Name = "mnuClimaticSCFSupportPrincipalComponents"
        Me.mnuClimaticSCFSupportPrincipalComponents.Size = New System.Drawing.Size(364, 34)
        Me.mnuClimaticSCFSupportPrincipalComponents.Text = "Principal Components..."
        '
        'mnuClimaticSCFSupportCanonicalCorrelations
        '
        Me.mnuClimaticSCFSupportCanonicalCorrelations.Name = "mnuClimaticSCFSupportCanonicalCorrelations"
        Me.mnuClimaticSCFSupportCanonicalCorrelations.Size = New System.Drawing.Size(364, 34)
        Me.mnuClimaticSCFSupportCanonicalCorrelations.Text = "Canonical Correlations..."
        '
        'mnuClimaticSCFSupportCumulativeExceedanceGraph
        '
        Me.mnuClimaticSCFSupportCumulativeExceedanceGraph.Name = "mnuClimaticSCFSupportCumulativeExceedanceGraph"
        Me.mnuClimaticSCFSupportCumulativeExceedanceGraph.Size = New System.Drawing.Size(364, 34)
        Me.mnuClimaticSCFSupportCumulativeExceedanceGraph.Text = "Cumulative/Exceedance Graph..."
        '
        'mnuClimaticClimateMethods
        '
        Me.mnuClimaticClimateMethods.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticClimateMethodsDataManipulation, Me.mnuClimaticClimateMethodsGraphics, Me.mnuClimaticClimateMethodsModel, Me.mnuClimaticClimateMethodsAdditional, Me.mnuClimateMethodsCreateClimateObject})
        Me.mnuClimaticClimateMethods.Name = "mnuClimaticClimateMethods"
        Me.mnuClimaticClimateMethods.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticClimateMethods.Tag = "Climatic_Methods"
        Me.mnuClimaticClimateMethods.Text = "Climate Methods"
        Me.mnuClimaticClimateMethods.Visible = False
        '
        'mnuClimaticClimateMethodsDataManipulation
        '
        Me.mnuClimaticClimateMethodsDataManipulation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticClimateMethodsDataManipulationStartOfRain, Me.mnuClimaticClimateMethodsDataManipulationEndOfRain, Me.mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth, Me.mnuClimaticClimateMethodsDataManipulationExportCPTToTabular, Me.mnuClimaticClimateMethodsDataManipulationDayMonth, Me.mnuClimaticClimateMethodsDataManipulationDisplayDaily, Me.mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear, Me.mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal, Me.mnuClimaticClimateMethodsDataManipulationDisplaySpellLength, Me.mnuClimaticClimateMethodsDataManipulationExportForPICSA, Me.mnuClimaticClimateMethodsDataManipulationExtremeEvents, Me.mnuClimaticClimateMethodsDataManipulationMissingData, Me.mnuClimaticClimateMethodsDataManipulationMissingDataTable, Me.mnuClimateMethodsDataManipulationMonthlySummaries, Me.mnuClimateMethodsDataManipulationOutputForCD})
        Me.mnuClimaticClimateMethodsDataManipulation.Name = "mnuClimaticClimateMethodsDataManipulation"
        Me.mnuClimaticClimateMethodsDataManipulation.Size = New System.Drawing.Size(297, 34)
        Me.mnuClimaticClimateMethodsDataManipulation.Tag = "Data_Manipulation"
        Me.mnuClimaticClimateMethodsDataManipulation.Text = "Data Manipulation"
        '
        'mnuClimaticClimateMethodsDataManipulationStartOfRain
        '
        Me.mnuClimaticClimateMethodsDataManipulationStartOfRain.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationStartOfRain.Name = "mnuClimaticClimateMethodsDataManipulationStartOfRain"
        Me.mnuClimaticClimateMethodsDataManipulationStartOfRain.Size = New System.Drawing.Size(342, 34)
        Me.mnuClimaticClimateMethodsDataManipulationStartOfRain.Tag = "Start_of_Rain"
        Me.mnuClimaticClimateMethodsDataManipulationStartOfRain.Text = "Start of Rain..."
        '
        'mnuClimaticClimateMethodsDataManipulationEndOfRain
        '
        Me.mnuClimaticClimateMethodsDataManipulationEndOfRain.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationEndOfRain.Name = "mnuClimaticClimateMethodsDataManipulationEndOfRain"
        Me.mnuClimaticClimateMethodsDataManipulationEndOfRain.Size = New System.Drawing.Size(342, 34)
        Me.mnuClimaticClimateMethodsDataManipulationEndOfRain.Tag = "End_of_Rain"
        Me.mnuClimaticClimateMethodsDataManipulationEndOfRain.Text = "End of Rain..."
        '
        'mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth
        '
        Me.mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth.Name = "mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth"
        Me.mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth.Size = New System.Drawing.Size(342, 34)
        Me.mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth.Tag = "Change_Format_Month"
        Me.mnuClimaticClimateMethodsDataManipulationChangeFormatDayMonth.Text = "Change Format Day Month..."
        '
        'mnuClimaticClimateMethodsDataManipulationExportCPTToTabular
        '
        Me.mnuClimaticClimateMethodsDataManipulationExportCPTToTabular.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationExportCPTToTabular.Name = "mnuClimaticClimateMethodsDataManipulationExportCPTToTabular"
        Me.mnuClimaticClimateMethodsDataManipulationExportCPTToTabular.Size = New System.Drawing.Size(342, 34)
        Me.mnuClimaticClimateMethodsDataManipulationExportCPTToTabular.Tag = "Expot_CPT_to_Tabular"
        Me.mnuClimaticClimateMethodsDataManipulationExportCPTToTabular.Text = "Export CPT to Tabular..."
        '
        'mnuClimaticClimateMethodsDataManipulationDayMonth
        '
        Me.mnuClimaticClimateMethodsDataManipulationDayMonth.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationDayMonth.Name = "mnuClimaticClimateMethodsDataManipulationDayMonth"
        Me.mnuClimaticClimateMethodsDataManipulationDayMonth.Size = New System.Drawing.Size(342, 34)
        Me.mnuClimaticClimateMethodsDataManipulationDayMonth.Tag = "Day_Month"
        Me.mnuClimaticClimateMethodsDataManipulationDayMonth.Text = "Day Month..."
        '
        'mnuClimaticClimateMethodsDataManipulationDisplayDaily
        '
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDaily.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDaily.Name = "mnuClimaticClimateMethodsDataManipulationDisplayDaily"
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDaily.Size = New System.Drawing.Size(342, 34)
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDaily.Tag = "Display_Daily"
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDaily.Text = "Display Daily..."
        '
        'mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear
        '
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear.Name = "mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear"
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear.Size = New System.Drawing.Size(342, 34)
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear.Tag = "Display_DOY_of_Year"
        Me.mnuClimaticClimateMethodsDataManipulationDisplayDOYOfYear.Text = "Display DOY of Year..."
        '
        'mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal
        '
        Me.mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal.Name = "mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal"
        Me.mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal.Size = New System.Drawing.Size(342, 34)
        Me.mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal.Tag = "Display_Rain_Running_Total"
        Me.mnuClimaticClimateMethodsDataManipulationDisplayRainRunningTotal.Text = "Display Rain Running Total..."
        '
        'mnuClimaticClimateMethodsDataManipulationDisplaySpellLength
        '
        Me.mnuClimaticClimateMethodsDataManipulationDisplaySpellLength.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationDisplaySpellLength.Name = "mnuClimaticClimateMethodsDataManipulationDisplaySpellLength"
        Me.mnuClimaticClimateMethodsDataManipulationDisplaySpellLength.Size = New System.Drawing.Size(342, 34)
        Me.mnuClimaticClimateMethodsDataManipulationDisplaySpellLength.Tag = "Display_Spell_length"
        Me.mnuClimaticClimateMethodsDataManipulationDisplaySpellLength.Text = "Display Spell Length..."
        '
        'mnuClimaticClimateMethodsDataManipulationExportForPICSA
        '
        Me.mnuClimaticClimateMethodsDataManipulationExportForPICSA.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationExportForPICSA.Name = "mnuClimaticClimateMethodsDataManipulationExportForPICSA"
        Me.mnuClimaticClimateMethodsDataManipulationExportForPICSA.Size = New System.Drawing.Size(342, 34)
        Me.mnuClimaticClimateMethodsDataManipulationExportForPICSA.Tag = "Export_for_PICSA"
        Me.mnuClimaticClimateMethodsDataManipulationExportForPICSA.Text = "Export for PICSA..."
        '
        'mnuClimaticClimateMethodsDataManipulationExtremeEvents
        '
        Me.mnuClimaticClimateMethodsDataManipulationExtremeEvents.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationExtremeEvents.Name = "mnuClimaticClimateMethodsDataManipulationExtremeEvents"
        Me.mnuClimaticClimateMethodsDataManipulationExtremeEvents.Size = New System.Drawing.Size(342, 34)
        Me.mnuClimaticClimateMethodsDataManipulationExtremeEvents.Tag = "Extreme_Events"
        Me.mnuClimaticClimateMethodsDataManipulationExtremeEvents.Text = "Extreme Events..."
        '
        'mnuClimaticClimateMethodsDataManipulationMissingData
        '
        Me.mnuClimaticClimateMethodsDataManipulationMissingData.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationMissingData.Name = "mnuClimaticClimateMethodsDataManipulationMissingData"
        Me.mnuClimaticClimateMethodsDataManipulationMissingData.Size = New System.Drawing.Size(342, 34)
        Me.mnuClimaticClimateMethodsDataManipulationMissingData.Tag = "Missing_Data"
        Me.mnuClimaticClimateMethodsDataManipulationMissingData.Text = "Missing Data..."
        '
        'mnuClimaticClimateMethodsDataManipulationMissingDataTable
        '
        Me.mnuClimaticClimateMethodsDataManipulationMissingDataTable.Enabled = False
        Me.mnuClimaticClimateMethodsDataManipulationMissingDataTable.Name = "mnuClimaticClimateMethodsDataManipulationMissingDataTable"
        Me.mnuClimaticClimateMethodsDataManipulationMissingDataTable.Size = New System.Drawing.Size(342, 34)
        Me.mnuClimaticClimateMethodsDataManipulationMissingDataTable.Tag = "Missing_Data_Table"
        Me.mnuClimaticClimateMethodsDataManipulationMissingDataTable.Text = "Missing Data Table..."
        '
        'mnuClimateMethodsDataManipulationMonthlySummaries
        '
        Me.mnuClimateMethodsDataManipulationMonthlySummaries.Enabled = False
        Me.mnuClimateMethodsDataManipulationMonthlySummaries.Name = "mnuClimateMethodsDataManipulationMonthlySummaries"
        Me.mnuClimateMethodsDataManipulationMonthlySummaries.Size = New System.Drawing.Size(342, 34)
        Me.mnuClimateMethodsDataManipulationMonthlySummaries.Tag = "Monthly_Summaries"
        Me.mnuClimateMethodsDataManipulationMonthlySummaries.Text = "Monthly Summaries..."
        '
        'mnuClimateMethodsDataManipulationOutputForCD
        '
        Me.mnuClimateMethodsDataManipulationOutputForCD.Enabled = False
        Me.mnuClimateMethodsDataManipulationOutputForCD.Name = "mnuClimateMethodsDataManipulationOutputForCD"
        Me.mnuClimateMethodsDataManipulationOutputForCD.Size = New System.Drawing.Size(342, 34)
        Me.mnuClimateMethodsDataManipulationOutputForCD.Tag = "Output_for_CDT"
        Me.mnuClimateMethodsDataManipulationOutputForCD.Text = "Output for CDT..."
        '
        'mnuClimaticClimateMethodsGraphics
        '
        Me.mnuClimaticClimateMethodsGraphics.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticClimateMethodsGraphicsClipBoxPlot, Me.mnuClimaticClimateMethodsGraphicsCliplot, Me.mnuClimaticClimateMethodsGraphicsMissingValues, Me.mnuClimaticClimateMethodsGraphicsHistogram, Me.mnuClimaticClimateMethodsGraphicsCumExceedance, Me.mnuClimaticClimateMethodsGraphicsBoxplot, Me.mnuClimaticClimateMethodsGraphicsInventory, Me.mnuClimaticClimateMethodsGraphicsAnnualRainfall, Me.mnuClimaticClimateMethodsGraphicsRainCount, Me.mnuClimaticClimateMethodsGraphicsTimeseries, Me.mnuClimaticClimateMethodsGraphicsWindrose, Me.mnuClimateMethodsGraphicsMultipleLines, Me.mnuClmateMethodThreeSummaries})
        Me.mnuClimaticClimateMethodsGraphics.Name = "mnuClimaticClimateMethodsGraphics"
        Me.mnuClimaticClimateMethodsGraphics.Size = New System.Drawing.Size(297, 34)
        Me.mnuClimaticClimateMethodsGraphics.Tag = "Graphics"
        Me.mnuClimaticClimateMethodsGraphics.Text = "Graphics"
        '
        'mnuClimaticClimateMethodsGraphicsClipBoxPlot
        '
        Me.mnuClimaticClimateMethodsGraphicsClipBoxPlot.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsClipBoxPlot.Name = "mnuClimaticClimateMethodsGraphicsClipBoxPlot"
        Me.mnuClimaticClimateMethodsGraphicsClipBoxPlot.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticClimateMethodsGraphicsClipBoxPlot.Tag = "Cliboxplot"
        Me.mnuClimaticClimateMethodsGraphicsClipBoxPlot.Text = "Cliboxplot..."
        '
        'mnuClimaticClimateMethodsGraphicsCliplot
        '
        Me.mnuClimaticClimateMethodsGraphicsCliplot.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsCliplot.Name = "mnuClimaticClimateMethodsGraphicsCliplot"
        Me.mnuClimaticClimateMethodsGraphicsCliplot.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticClimateMethodsGraphicsCliplot.Tag = "Cliplot"
        Me.mnuClimaticClimateMethodsGraphicsCliplot.Text = "Cliplot..."
        '
        'mnuClimaticClimateMethodsGraphicsMissingValues
        '
        Me.mnuClimaticClimateMethodsGraphicsMissingValues.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsMissingValues.Name = "mnuClimaticClimateMethodsGraphicsMissingValues"
        Me.mnuClimaticClimateMethodsGraphicsMissingValues.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticClimateMethodsGraphicsMissingValues.Tag = "Missing_values"
        Me.mnuClimaticClimateMethodsGraphicsMissingValues.Text = "Missing Values..."
        '
        'mnuClimaticClimateMethodsGraphicsHistogram
        '
        Me.mnuClimaticClimateMethodsGraphicsHistogram.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsHistogram.Name = "mnuClimaticClimateMethodsGraphicsHistogram"
        Me.mnuClimaticClimateMethodsGraphicsHistogram.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticClimateMethodsGraphicsHistogram.Tag = "Histogram"
        Me.mnuClimaticClimateMethodsGraphicsHistogram.Text = "Histogram..."
        '
        'mnuClimaticClimateMethodsGraphicsCumExceedance
        '
        Me.mnuClimaticClimateMethodsGraphicsCumExceedance.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsCumExceedance.Name = "mnuClimaticClimateMethodsGraphicsCumExceedance"
        Me.mnuClimaticClimateMethodsGraphicsCumExceedance.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticClimateMethodsGraphicsCumExceedance.Tag = "Cumulative_Exceedence"
        Me.mnuClimaticClimateMethodsGraphicsCumExceedance.Text = "Cummulative Exceedance..."
        '
        'mnuClimaticClimateMethodsGraphicsBoxplot
        '
        Me.mnuClimaticClimateMethodsGraphicsBoxplot.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsBoxplot.Name = "mnuClimaticClimateMethodsGraphicsBoxplot"
        Me.mnuClimaticClimateMethodsGraphicsBoxplot.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticClimateMethodsGraphicsBoxplot.Tag = "Boxplot"
        Me.mnuClimaticClimateMethodsGraphicsBoxplot.Text = "Boxplot..."
        '
        'mnuClimaticClimateMethodsGraphicsInventory
        '
        Me.mnuClimaticClimateMethodsGraphicsInventory.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsInventory.Name = "mnuClimaticClimateMethodsGraphicsInventory"
        Me.mnuClimaticClimateMethodsGraphicsInventory.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticClimateMethodsGraphicsInventory.Tag = "Inventory"
        Me.mnuClimaticClimateMethodsGraphicsInventory.Text = "Inventory..."
        '
        'mnuClimaticClimateMethodsGraphicsAnnualRainfall
        '
        Me.mnuClimaticClimateMethodsGraphicsAnnualRainfall.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsAnnualRainfall.Name = "mnuClimaticClimateMethodsGraphicsAnnualRainfall"
        Me.mnuClimaticClimateMethodsGraphicsAnnualRainfall.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticClimateMethodsGraphicsAnnualRainfall.Tag = "Annual_rainfall"
        Me.mnuClimaticClimateMethodsGraphicsAnnualRainfall.Text = "Annual Rainfall..."
        '
        'mnuClimaticClimateMethodsGraphicsRainCount
        '
        Me.mnuClimaticClimateMethodsGraphicsRainCount.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsRainCount.Name = "mnuClimaticClimateMethodsGraphicsRainCount"
        Me.mnuClimaticClimateMethodsGraphicsRainCount.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticClimateMethodsGraphicsRainCount.Tag = "Rain_count"
        Me.mnuClimaticClimateMethodsGraphicsRainCount.Text = "Rain Count..."
        '
        'mnuClimaticClimateMethodsGraphicsTimeseries
        '
        Me.mnuClimaticClimateMethodsGraphicsTimeseries.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsTimeseries.Name = "mnuClimaticClimateMethodsGraphicsTimeseries"
        Me.mnuClimaticClimateMethodsGraphicsTimeseries.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticClimateMethodsGraphicsTimeseries.Tag = "Timeseries"
        Me.mnuClimaticClimateMethodsGraphicsTimeseries.Text = "Timeseries..."
        '
        'mnuClimaticClimateMethodsGraphicsWindrose
        '
        Me.mnuClimaticClimateMethodsGraphicsWindrose.Enabled = False
        Me.mnuClimaticClimateMethodsGraphicsWindrose.Name = "mnuClimaticClimateMethodsGraphicsWindrose"
        Me.mnuClimaticClimateMethodsGraphicsWindrose.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimaticClimateMethodsGraphicsWindrose.Tag = "Windrose"
        Me.mnuClimaticClimateMethodsGraphicsWindrose.Text = "Windrose..."
        '
        'mnuClimateMethodsGraphicsMultipleLines
        '
        Me.mnuClimateMethodsGraphicsMultipleLines.Enabled = False
        Me.mnuClimateMethodsGraphicsMultipleLines.Name = "mnuClimateMethodsGraphicsMultipleLines"
        Me.mnuClimateMethodsGraphicsMultipleLines.Size = New System.Drawing.Size(325, 34)
        Me.mnuClimateMethodsGraphicsMultipleLines.Tag = "Multiple_lines"
        Me.mnuClimateMethodsGraphicsMultipleLines.Text = "Multple Lines..."
        '
        'mnuClmateMethodThreeSummaries
        '
        Me.mnuClmateMethodThreeSummaries.Enabled = False
        Me.mnuClmateMethodThreeSummaries.Name = "mnuClmateMethodThreeSummaries"
        Me.mnuClmateMethodThreeSummaries.Size = New System.Drawing.Size(325, 34)
        Me.mnuClmateMethodThreeSummaries.Tag = "Three_Summaries"
        Me.mnuClmateMethodThreeSummaries.Text = "Three Summaries..."
        '
        'mnuClimaticClimateMethodsModel
        '
        Me.mnuClimaticClimateMethodsModel.Enabled = False
        Me.mnuClimaticClimateMethodsModel.Name = "mnuClimaticClimateMethodsModel"
        Me.mnuClimaticClimateMethodsModel.Size = New System.Drawing.Size(297, 34)
        Me.mnuClimaticClimateMethodsModel.Tag = "Model"
        Me.mnuClimaticClimateMethodsModel.Text = "Model..."
        '
        'mnuClimaticClimateMethodsAdditional
        '
        Me.mnuClimaticClimateMethodsAdditional.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticClimateMethodsAdditionalOutputForCPT, Me.mnuClimaticClimateMethodsAdditionalRainsStatistics, Me.mnuClimaticClimateMethodsAdditionalSeasonalSummary, Me.mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain, Me.mnuClimaticClimateMethodsAdditionalWaterBalance})
        Me.mnuClimaticClimateMethodsAdditional.Name = "mnuClimaticClimateMethodsAdditional"
        Me.mnuClimaticClimateMethodsAdditional.Size = New System.Drawing.Size(297, 34)
        Me.mnuClimaticClimateMethodsAdditional.Tag = "Additional"
        Me.mnuClimaticClimateMethodsAdditional.Text = "Additional"
        '
        'mnuClimaticClimateMethodsAdditionalOutputForCPT
        '
        Me.mnuClimaticClimateMethodsAdditionalOutputForCPT.Enabled = False
        Me.mnuClimaticClimateMethodsAdditionalOutputForCPT.Name = "mnuClimaticClimateMethodsAdditionalOutputForCPT"
        Me.mnuClimaticClimateMethodsAdditionalOutputForCPT.Size = New System.Drawing.Size(316, 34)
        Me.mnuClimaticClimateMethodsAdditionalOutputForCPT.Tag = "Output_for_CPT"
        Me.mnuClimaticClimateMethodsAdditionalOutputForCPT.Text = "Output for CPT..."
        '
        'mnuClimaticClimateMethodsAdditionalRainsStatistics
        '
        Me.mnuClimaticClimateMethodsAdditionalRainsStatistics.Enabled = False
        Me.mnuClimaticClimateMethodsAdditionalRainsStatistics.Name = "mnuClimaticClimateMethodsAdditionalRainsStatistics"
        Me.mnuClimaticClimateMethodsAdditionalRainsStatistics.Size = New System.Drawing.Size(316, 34)
        Me.mnuClimaticClimateMethodsAdditionalRainsStatistics.Tag = "Rain_Statistics"
        Me.mnuClimaticClimateMethodsAdditionalRainsStatistics.Text = "Rains Statistics..."
        '
        'mnuClimaticClimateMethodsAdditionalSeasonalSummary
        '
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummary.Enabled = False
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummary.Name = "mnuClimaticClimateMethodsAdditionalSeasonalSummary"
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummary.Size = New System.Drawing.Size(316, 34)
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummary.Tag = "Seasonal_Summary"
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummary.Text = "Seasonal Summary..."
        '
        'mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain
        '
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain.Enabled = False
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain.Name = "mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain"
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain.Size = New System.Drawing.Size(316, 34)
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain.Tag = "Seasonal_Summary_Rain"
        Me.mnuClimaticClimateMethodsAdditionalSeasonalSummaryRain.Text = "Seasonal Summary Rain..."
        '
        'mnuClimaticClimateMethodsAdditionalWaterBalance
        '
        Me.mnuClimaticClimateMethodsAdditionalWaterBalance.Enabled = False
        Me.mnuClimaticClimateMethodsAdditionalWaterBalance.Name = "mnuClimaticClimateMethodsAdditionalWaterBalance"
        Me.mnuClimaticClimateMethodsAdditionalWaterBalance.Size = New System.Drawing.Size(316, 34)
        Me.mnuClimaticClimateMethodsAdditionalWaterBalance.Tag = "Water_Balance"
        Me.mnuClimaticClimateMethodsAdditionalWaterBalance.Text = "Water Balance..."
        '
        'mnuClimateMethodsCreateClimateObject
        '
        Me.mnuClimateMethodsCreateClimateObject.Enabled = False
        Me.mnuClimateMethodsCreateClimateObject.Name = "mnuClimateMethodsCreateClimateObject"
        Me.mnuClimateMethodsCreateClimateObject.Size = New System.Drawing.Size(297, 34)
        Me.mnuClimateMethodsCreateClimateObject.Tag = "Create_Climate_Object"
        Me.mnuClimateMethodsCreateClimateObject.Text = "Create Climate Object..."
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(351, 34)
        Me.mnuFileSave.Tag = "Save"
        Me.mnuFileSave.Text = "Save..."
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileSaveAsDataAs, Me.mnuFileSaveAsOutputAs, Me.mnuFileSaveAsLogAs, Me.mnuFileSaveAsScriptAs})
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(351, 34)
        Me.mnuFileSaveAs.Tag = "Save_As"
        Me.mnuFileSaveAs.Text = "Save As"
        '
        'mnuFileSaveAsDataAs
        '
        Me.mnuFileSaveAsDataAs.Name = "mnuFileSaveAsDataAs"
        Me.mnuFileSaveAsDataAs.Size = New System.Drawing.Size(250, 34)
        Me.mnuFileSaveAsDataAs.Text = "Save Data As..."
        '
        'mnuFileSaveAsOutputAs
        '
        Me.mnuFileSaveAsOutputAs.Name = "mnuFileSaveAsOutputAs"
        Me.mnuFileSaveAsOutputAs.Size = New System.Drawing.Size(250, 34)
        Me.mnuFileSaveAsOutputAs.Text = "Save Output As..."
        '
        'mnuFileSaveAsLogAs
        '
        Me.mnuFileSaveAsLogAs.Name = "mnuFileSaveAsLogAs"
        Me.mnuFileSaveAsLogAs.Size = New System.Drawing.Size(250, 34)
        Me.mnuFileSaveAsLogAs.Text = "Save Log As..."
        '
        'mnuFileSaveAsScriptAs
        '
        Me.mnuFileSaveAsScriptAs.Name = "mnuFileSaveAsScriptAs"
        Me.mnuFileSaveAsScriptAs.Size = New System.Drawing.Size(250, 34)
        Me.mnuFileSaveAsScriptAs.Text = "Save Script As..."
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.Enabled = False
        Me.mnuFilePrint.Name = "mnuFilePrint"
        Me.mnuFilePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuFilePrint.Size = New System.Drawing.Size(351, 34)
        Me.mnuFilePrint.Tag = "Print"
        Me.mnuFilePrint.Text = "Print..."
        Me.mnuFilePrint.Visible = False
        '
        'mnuFilePrintPreview
        '
        Me.mnuFilePrintPreview.Enabled = False
        Me.mnuFilePrintPreview.Name = "mnuFilePrintPreview"
        Me.mnuFilePrintPreview.Size = New System.Drawing.Size(351, 34)
        Me.mnuFilePrintPreview.Tag = "Print_Preview"
        Me.mnuFilePrintPreview.Text = "Print Preview..."
        Me.mnuFilePrintPreview.Visible = False
        '
        'tlSeparatorFile3
        '
        Me.tlSeparatorFile3.Name = "tlSeparatorFile3"
        Me.tlSeparatorFile3.Size = New System.Drawing.Size(348, 6)
        '
        'mnuFIleExit
        '
        Me.mnuFIleExit.Name = "mnuFIleExit"
        Me.mnuFIleExit.Size = New System.Drawing.Size(351, 34)
        Me.mnuFIleExit.Tag = "Exit"
        Me.mnuFIleExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditFind, Me.mnuEditCopy, Me.mnuEditPaste, Me.mnuEditPasteNew, Me.mnuEditWordwrap, Me.mnuEditSelectAll})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(58, 29)
        Me.mnuEdit.Tag = "Edit"
        Me.mnuEdit.Text = "Edit"
        '
        'mnuEditFind
        '
        Me.mnuEditFind.Name = "mnuEditFind"
        Me.mnuEditFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuEditFind.Size = New System.Drawing.Size(270, 34)
        Me.mnuEditFind.Tag = "Find"
        Me.mnuEditFind.Text = "Find"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(270, 34)
        Me.mnuEditCopy.Tag = "Copy"
        Me.mnuEditCopy.Text = "Copy"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(270, 34)
        Me.mnuEditPaste.Tag = "Paste"
        Me.mnuEditPaste.Text = "Paste"
        '
        'mnuEditPasteNew
        '
        Me.mnuEditPasteNew.Name = "mnuEditPasteNew"
        Me.mnuEditPasteNew.Size = New System.Drawing.Size(270, 34)
        Me.mnuEditPasteNew.Text = "Paste New"
        '
        'mnuEditWordwrap
        '
        Me.mnuEditWordwrap.Name = "mnuEditWordwrap"
        Me.mnuEditWordwrap.Size = New System.Drawing.Size(270, 34)
        Me.mnuEditWordwrap.Text = "Wordwrap"
        '
        'mnuEditSelectAll
        '
        Me.mnuEditSelectAll.Name = "mnuEditSelectAll"
        Me.mnuEditSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuEditSelectAll.Size = New System.Drawing.Size(270, 34)
        Me.mnuEditSelectAll.Tag = "Select_All"
        Me.mnuEditSelectAll.Text = "Select All "
        '
        'stsStrip
        '
        Me.stsStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.stsStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstatus})
        Me.stsStrip.Location = New System.Drawing.Point(0, 691)
        Me.stsStrip.Name = "stsStrip"
        Me.stsStrip.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.stsStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.stsStrip.Size = New System.Drawing.Size(1251, 32)
        Me.stsStrip.TabIndex = 8
        Me.stsStrip.Text = "Status"
        '
        'tstatus
        '
        Me.tstatus.Name = "tstatus"
        Me.tstatus.Size = New System.Drawing.Size(182, 25)
        Me.tstatus.Text = "No worksheet loaded"
        '
        'Tool_strip
        '
        Me.Tool_strip.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Tool_strip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Tool_strip.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.Tool_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTbOpen, Me.mnuTbOpenFromLibrary, Me.mnuTbSave, Me.toolStripSeparator, Me.mnuTbLast10Dialogs, Me.separator2, Me.mnuTbDataView, Me.mnuTbOutput, Me.ToolStripSeparator74, Me.mnuLastGraph, Me.ToolStripSeparator75, Me.mnuTbLogScript, Me.mnuMetadata, Me.ToolStripSeparator76, Me.mnuTbResetLayout, Me.separator3, Me.mnuTbHelp, Me.ToolStripSeparator77, Me.mnuTbLan, Me.separator1})
        Me.Tool_strip.Location = New System.Drawing.Point(0, 33)
        Me.Tool_strip.Name = "Tool_strip"
        Me.Tool_strip.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Tool_strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Tool_strip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tool_strip.Size = New System.Drawing.Size(1251, 39)
        Me.Tool_strip.TabIndex = 7
        Me.Tool_strip.Text = "Tool"
        '
        'mnuTbOpen
        '
        Me.mnuTbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbOpen.DropDownButtonWidth = 18
        Me.mnuTbOpen.Image = Global.instat.My.Resources.Resources.openfromfile2
        Me.mnuTbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbOpen.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbOpen.Name = "mnuTbOpen"
        Me.mnuTbOpen.Size = New System.Drawing.Size(53, 36)
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
        Me.mnuTbOpenFromLibrary.Size = New System.Drawing.Size(34, 36)
        Me.mnuTbOpenFromLibrary.ToolTipText = "Import From Library"
        '
        'mnuTbSave
        '
        Me.mnuTbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbSave.DropDownButtonWidth = 18
        Me.mnuTbSave.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSaveData, Me.mnuSaveOutput, Me.mnuSaveScript, Me.mnuSaveLog})
        Me.mnuTbSave.Image = Global.instat.My.Resources.Resources.save2
        Me.mnuTbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbSave.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbSave.Name = "mnuTbSave"
        Me.mnuTbSave.Size = New System.Drawing.Size(53, 36)
        Me.mnuTbSave.Text = "&Save"
        '
        'mnuSaveData
        '
        Me.mnuSaveData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuSaveData.Name = "mnuSaveData"
        Me.mnuSaveData.Size = New System.Drawing.Size(213, 34)
        Me.mnuSaveData.Text = "Save Data"
        '
        'mnuSaveOutput
        '
        Me.mnuSaveOutput.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuSaveOutput.Name = "mnuSaveOutput"
        Me.mnuSaveOutput.Size = New System.Drawing.Size(213, 34)
        Me.mnuSaveOutput.Text = "Save Output"
        '
        'mnuSaveScript
        '
        Me.mnuSaveScript.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuSaveScript.Name = "mnuSaveScript"
        Me.mnuSaveScript.Size = New System.Drawing.Size(213, 34)
        Me.mnuSaveScript.Text = "Save Script"
        '
        'mnuSaveLog
        '
        Me.mnuSaveLog.Name = "mnuSaveLog"
        Me.mnuSaveLog.Size = New System.Drawing.Size(213, 34)
        Me.mnuSaveLog.Text = "Save Log"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 39)
        '
        'mnuTbLast10Dialogs
        '
        Me.mnuTbLast10Dialogs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbLast10Dialogs.DropDownButtonWidth = 18
        Me.mnuTbLast10Dialogs.Image = Global.instat.My.Resources.Resources.last10dialogs
        Me.mnuTbLast10Dialogs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbLast10Dialogs.Name = "mnuTbLast10Dialogs"
        Me.mnuTbLast10Dialogs.Size = New System.Drawing.Size(53, 34)
        Me.mnuTbLast10Dialogs.Text = "ToolStripSplitButton3"
        Me.mnuTbLast10Dialogs.ToolTipText = "View/Edit Last Dialogue"
        '
        'separator2
        '
        Me.separator2.Name = "separator2"
        Me.separator2.Size = New System.Drawing.Size(6, 39)
        '
        'mnuTbDataView
        '
        Me.mnuTbDataView.CheckOnClick = True
        Me.mnuTbDataView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbDataView.Image = Global.instat.My.Resources.Resources.dataframe2
        Me.mnuTbDataView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbDataView.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbDataView.Name = "mnuTbDataView"
        Me.mnuTbDataView.Size = New System.Drawing.Size(34, 36)
        Me.mnuTbDataView.ToolTipText = "Toggle Data view open and closed"
        '
        'mnuTbOutput
        '
        Me.mnuTbOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbOutput.DropDownButtonWidth = 18
        Me.mnuTbOutput.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOutputWindow, Me.mnuShowRCommand, Me.mnuIncludeComments})
        Me.mnuTbOutput.Image = Global.instat.My.Resources.Resources.output3
        Me.mnuTbOutput.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbOutput.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbOutput.Name = "mnuTbOutput"
        Me.mnuTbOutput.Size = New System.Drawing.Size(53, 36)
        Me.mnuTbOutput.ToolTipText = "Toggle Output window open and closed"
        '
        'mnuOutputWindow
        '
        Me.mnuOutputWindow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuOutputWindow.Name = "mnuOutputWindow"
        Me.mnuOutputWindow.Size = New System.Drawing.Size(271, 34)
        Me.mnuOutputWindow.Text = "Show Output"
        '
        'mnuShowRCommand
        '
        Me.mnuShowRCommand.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuShowRCommand.Name = "mnuShowRCommand"
        Me.mnuShowRCommand.Size = New System.Drawing.Size(271, 34)
        Me.mnuShowRCommand.Text = "Show R Commands"
        '
        'mnuIncludeComments
        '
        Me.mnuIncludeComments.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuIncludeComments.Name = "mnuIncludeComments"
        Me.mnuIncludeComments.Size = New System.Drawing.Size(271, 34)
        Me.mnuIncludeComments.Text = "Show Comments"
        '
        'ToolStripSeparator74
        '
        Me.ToolStripSeparator74.Name = "ToolStripSeparator74"
        Me.ToolStripSeparator74.Size = New System.Drawing.Size(6, 39)
        '
        'mnuLastGraph
        '
        Me.mnuLastGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuLastGraph.DropDownButtonWidth = 18
        Me.mnuLastGraph.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNormalViewer, Me.mnuploty, Me.mnuRViewer})
        Me.mnuLastGraph.Image = CType(resources.GetObject("mnuLastGraph.Image"), System.Drawing.Image)
        Me.mnuLastGraph.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuLastGraph.Name = "mnuLastGraph"
        Me.mnuLastGraph.Size = New System.Drawing.Size(53, 34)
        Me.mnuLastGraph.Text = "ToolStripSplitButton3"
        Me.mnuLastGraph.ToolTipText = "View Last Graph"
        '
        'mnuNormalViewer
        '
        Me.mnuNormalViewer.Name = "mnuNormalViewer"
        Me.mnuNormalViewer.Size = New System.Drawing.Size(194, 34)
        Me.mnuNormalViewer.Text = "Viewer..."
        '
        'mnuploty
        '
        Me.mnuploty.Name = "mnuploty"
        Me.mnuploty.Size = New System.Drawing.Size(194, 34)
        Me.mnuploty.Text = "Plotly..."
        '
        'mnuRViewer
        '
        Me.mnuRViewer.Name = "mnuRViewer"
        Me.mnuRViewer.Size = New System.Drawing.Size(194, 34)
        Me.mnuRViewer.Text = "R Viewer..."
        '
        'ToolStripSeparator75
        '
        Me.ToolStripSeparator75.Name = "ToolStripSeparator75"
        Me.ToolStripSeparator75.Size = New System.Drawing.Size(6, 39)
        '
        'mnuTbLogScript
        '
        Me.mnuTbLogScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbLogScript.DropDownButtonWidth = 18
        Me.mnuTbLogScript.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogScript})
        Me.mnuTbLogScript.Image = Global.instat.My.Resources.Resources.scriptwindow
        Me.mnuTbLogScript.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbLogScript.Name = "mnuTbLogScript"
        Me.mnuTbLogScript.Size = New System.Drawing.Size(53, 34)
        Me.mnuTbLogScript.Text = "LogScript"
        Me.mnuTbLogScript.ToolTipText = "Toggle Log/Script window open and closed"
        '
        'mnuLogScript
        '
        Me.mnuLogScript.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuLogScript.Name = "mnuLogScript"
        Me.mnuLogScript.Size = New System.Drawing.Size(196, 34)
        Me.mnuLogScript.Text = "Log/Script"
        '
        'mnuMetadata
        '
        Me.mnuMetadata.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuMetadata.DropDownButtonWidth = 18
        Me.mnuMetadata.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColumnMetadat, Me.mnuDataFrameMetadat})
        Me.mnuMetadata.Image = CType(resources.GetObject("mnuMetadata.Image"), System.Drawing.Image)
        Me.mnuMetadata.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuMetadata.Name = "mnuMetadata"
        Me.mnuMetadata.Size = New System.Drawing.Size(53, 34)
        Me.mnuMetadata.Text = "ToolStripSplitButton2"
        Me.mnuMetadata.ToolTipText = "Toggle Metadata windows open and closed"
        '
        'mnuColumnMetadat
        '
        Me.mnuColumnMetadat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuColumnMetadat.Name = "mnuColumnMetadat"
        Me.mnuColumnMetadat.Size = New System.Drawing.Size(307, 34)
        Me.mnuColumnMetadat.Text = "  Column Metadata..."
        '
        'mnuDataFrameMetadat
        '
        Me.mnuDataFrameMetadat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuDataFrameMetadat.Name = "mnuDataFrameMetadat"
        Me.mnuDataFrameMetadat.Size = New System.Drawing.Size(307, 34)
        Me.mnuDataFrameMetadat.Text = "  Data Frame Metadata..."
        '
        'ToolStripSeparator76
        '
        Me.ToolStripSeparator76.Name = "ToolStripSeparator76"
        Me.ToolStripSeparator76.Size = New System.Drawing.Size(6, 39)
        '
        'mnuTbResetLayout
        '
        Me.mnuTbResetLayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbResetLayout.Image = Global.instat.My.Resources.Resources.reset3
        Me.mnuTbResetLayout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbResetLayout.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbResetLayout.Name = "mnuTbResetLayout"
        Me.mnuTbResetLayout.Size = New System.Drawing.Size(34, 36)
        Me.mnuTbResetLayout.ToolTipText = "Reset to Default Layout"
        '
        'separator3
        '
        Me.separator3.Name = "separator3"
        Me.separator3.Size = New System.Drawing.Size(6, 39)
        '
        'mnuTbHelp
        '
        Me.mnuTbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbHelp.Image = Global.instat.My.Resources.Resources.help2
        Me.mnuTbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbHelp.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbHelp.Name = "mnuTbHelp"
        Me.mnuTbHelp.Size = New System.Drawing.Size(34, 36)
        Me.mnuTbHelp.Text = "He&lp"
        '
        'ToolStripSeparator77
        '
        Me.ToolStripSeparator77.Name = "ToolStripSeparator77"
        Me.ToolStripSeparator77.Size = New System.Drawing.Size(6, 39)
        '
        'mnuTbLan
        '
        Me.mnuTbLan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbLan.Image = Global.instat.My.Resources.Resources.lan_btn
        Me.mnuTbLan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbLan.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.mnuTbLan.Name = "mnuTbLan"
        Me.mnuTbLan.Size = New System.Drawing.Size(34, 36)
        Me.mnuTbLan.ToolTipText = "Changes the menu language to English, and from English"
        '
        'separator1
        '
        Me.separator1.Name = "separator1"
        Me.separator1.Size = New System.Drawing.Size(6, 39)
        '
        'mnuBar
        '
        Me.mnuBar.AllowMerge = False
        Me.mnuBar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.mnuBar.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuBar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuBar.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.mnuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuPrepare, Me.mnuDescribe, Me.mnuModel, Me.mnuStructured, Me.mnuClimatic, Me.mnuProcurement, Me.mnuOptionsByContext, Me.mnuTools, Me.mnuView, Me.mnuHelp})
        Me.mnuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.mnuBar.Location = New System.Drawing.Point(0, 0)
        Me.mnuBar.Name = "mnuBar"
        Me.mnuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnuBar.ShowItemToolTips = True
        Me.mnuBar.Size = New System.Drawing.Size(1251, 33)
        Me.mnuBar.TabIndex = 6
        Me.mnuBar.Text = "Menu_strip"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNewDataFrame, Me.mnuFileImportFromFile, Me.mnuFileImportFromLibrary, Me.ToolStripSeparator35, Me.mnuFileImportFromODK, Me.mnuFileImportFromCSPRO, Me.mnuFileImportFromDatabases, Me.mnuFileImportFromPostgres, Me.mnuFileImportFromRapidPro, Me.mnuFileImportandTidyNetCDFFile, Me.mnuFileConvert, Me.tlSeparatorFile, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFileExport, Me.mnuFilePrint, Me.mnuFilePrintPreview, Me.tlSeparatorFile3, Me.mnuFileCloseData, Me.ToolStripSeparator8, Me.mnuFIleExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(54, 29)
        Me.mnuFile.Tag = "File"
        Me.mnuFile.Text = "File"
        '
        'mnuFileNewDataFrame
        '
        Me.mnuFileNewDataFrame.Name = "mnuFileNewDataFrame"
        Me.mnuFileNewDataFrame.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNewDataFrame.Size = New System.Drawing.Size(351, 34)
        Me.mnuFileNewDataFrame.Tag = "New_Data_Frame"
        Me.mnuFileNewDataFrame.Text = "New Data Frame..."
        '
        'mnuFileImportFromFile
        '
        Me.mnuFileImportFromFile.Name = "mnuFileImportFromFile"
        Me.mnuFileImportFromFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileImportFromFile.Size = New System.Drawing.Size(351, 34)
        Me.mnuFileImportFromFile.Tag = "Import_From_File"
        Me.mnuFileImportFromFile.Text = "Import From File..."
        '
        'mnuFileImportFromLibrary
        '
        Me.mnuFileImportFromLibrary.Name = "mnuFileImportFromLibrary"
        Me.mnuFileImportFromLibrary.Size = New System.Drawing.Size(351, 34)
        Me.mnuFileImportFromLibrary.Tag = "Open_From_Library"
        Me.mnuFileImportFromLibrary.Text = "Import From Library..."
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(348, 6)
        '
        'mnuFileImportFromODK
        '
        Me.mnuFileImportFromODK.Name = "mnuFileImportFromODK"
        Me.mnuFileImportFromODK.Size = New System.Drawing.Size(351, 34)
        Me.mnuFileImportFromODK.Text = "Import From ODK..."
        '
        'mnuFileImportFromCSPRO
        '
        Me.mnuFileImportFromCSPRO.Enabled = False
        Me.mnuFileImportFromCSPRO.Name = "mnuFileImportFromCSPRO"
        Me.mnuFileImportFromCSPRO.Size = New System.Drawing.Size(351, 34)
        Me.mnuFileImportFromCSPRO.Text = "Import From CSPRO..."
        Me.mnuFileImportFromCSPRO.Visible = False
        '
        'mnuFileImportFromDatabases
        '
        Me.mnuFileImportFromDatabases.Enabled = False
        Me.mnuFileImportFromDatabases.Name = "mnuFileImportFromDatabases"
        Me.mnuFileImportFromDatabases.Size = New System.Drawing.Size(351, 34)
        Me.mnuFileImportFromDatabases.Text = "Import From Databases..."
        Me.mnuFileImportFromDatabases.Visible = False
        '
        'mnuFileImportFromPostgres
        '
        Me.mnuFileImportFromPostgres.Enabled = False
        Me.mnuFileImportFromPostgres.Name = "mnuFileImportFromPostgres"
        Me.mnuFileImportFromPostgres.Size = New System.Drawing.Size(351, 34)
        Me.mnuFileImportFromPostgres.Text = "Import From Postgres"
        Me.mnuFileImportFromPostgres.Visible = False
        '
        'mnuFileImportFromRapidPro
        '
        Me.mnuFileImportFromRapidPro.Name = "mnuFileImportFromRapidPro"
        Me.mnuFileImportFromRapidPro.Size = New System.Drawing.Size(351, 34)
        Me.mnuFileImportFromRapidPro.Text = "Import From RapidPro"
        '
        'mnuFileImportandTidyNetCDFFile
        '
        Me.mnuFileImportandTidyNetCDFFile.Name = "mnuFileImportandTidyNetCDFFile"
        Me.mnuFileImportandTidyNetCDFFile.Size = New System.Drawing.Size(351, 34)
        Me.mnuFileImportandTidyNetCDFFile.Text = "Import and Tidy NetCDF File..."
        '
        'mnuFileConvert
        '
        Me.mnuFileConvert.Enabled = False
        Me.mnuFileConvert.Name = "mnuFileConvert"
        Me.mnuFileConvert.Size = New System.Drawing.Size(351, 34)
        Me.mnuFileConvert.Text = "Convert..."
        Me.mnuFileConvert.Visible = False
        '
        'tlSeparatorFile
        '
        Me.tlSeparatorFile.Name = "tlSeparatorFile"
        Me.tlSeparatorFile.Size = New System.Drawing.Size(348, 6)
        '
        'mnuFileExport
        '
        Me.mnuFileExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExportExportDataSet, Me.mnuFileExportExportRObjectsToolStripMenuItem, Me.mnuFileExportExportRWorkspace, Me.mnuFileExportExportGraphAsImage})
        Me.mnuFileExport.Name = "mnuFileExport"
        Me.mnuFileExport.Size = New System.Drawing.Size(351, 34)
        Me.mnuFileExport.Text = "Export"
        '
        'mnuFileExportExportDataSet
        '
        Me.mnuFileExportExportDataSet.Name = "mnuFileExportExportDataSet"
        Me.mnuFileExportExportDataSet.Size = New System.Drawing.Size(310, 34)
        Me.mnuFileExportExportDataSet.Text = "Export Dataset..."
        '
        'mnuFileExportExportRObjectsToolStripMenuItem
        '
        Me.mnuFileExportExportRObjectsToolStripMenuItem.Name = "mnuFileExportExportRObjectsToolStripMenuItem"
        Me.mnuFileExportExportRObjectsToolStripMenuItem.Size = New System.Drawing.Size(310, 34)
        Me.mnuFileExportExportRObjectsToolStripMenuItem.Text = "Export R Objects..."
        '
        'mnuFileExportExportRWorkspace
        '
        Me.mnuFileExportExportRWorkspace.Name = "mnuFileExportExportRWorkspace"
        Me.mnuFileExportExportRWorkspace.Size = New System.Drawing.Size(310, 34)
        Me.mnuFileExportExportRWorkspace.Text = "Export R Workspace..."
        '
        'mnuFileExportExportGraphAsImage
        '
        Me.mnuFileExportExportGraphAsImage.Name = "mnuFileExportExportGraphAsImage"
        Me.mnuFileExportExportGraphAsImage.Size = New System.Drawing.Size(310, 34)
        Me.mnuFileExportExportGraphAsImage.Text = "Export Graph As Image..."
        '
        'mnuFileCloseData
        '
        Me.mnuFileCloseData.Name = "mnuFileCloseData"
        Me.mnuFileCloseData.Size = New System.Drawing.Size(351, 34)
        Me.mnuFileCloseData.Text = "Close Data Book"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(348, 6)
        '
        'mnuPrepare
        '
        Me.mnuPrepare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareDataFrame, Me.mnuPrepareCheckData, Me.ToolStripSeparator6, Me.mnuPrepareCalculator, Me.mnuPrepareColumnCalculate, Me.mnuPrepareColumnFactor, Me.mnuPrepareColumnText, Me.mnuPrepareColumnDate, Me.mnuPrepareColumnDefine, Me.ToolStripSeparator4, Me.mnuPrepareDataReshape, Me.ToolStripSeparator7, Me.mnuPrepareKeysAndLinks, Me.mnuPrepareDataBook, Me.mnuPrepareRObjects})
        Me.mnuPrepare.Name = "mnuPrepare"
        Me.mnuPrepare.Size = New System.Drawing.Size(88, 29)
        Me.mnuPrepare.Tag = "Prepare"
        Me.mnuPrepare.Text = "Prepare"
        '
        'mnuPrepareDataFrame
        '
        Me.mnuPrepareDataFrame.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareDataFrameViewData, Me.mnuPrepareDataFrameRenameColumn, Me.mnuPrepareDataFrameDuplicateColumn, Me.mnuPrepareDataFrameRowNumbersNames, Me.ToolStripSeparator1, Me.mnuPrepareDataFrameSort, Me.mnuPrepareDataFrameFilterRows, Me.mnuPrepareDataFrameSelectColumns, Me.mnuPrepareDataFrameReplaceValues, Me.mnuPrepareDataFrameConvertColumns, Me.ToolStripSeparator2, Me.mnuPrepareDataFrameReorderColumns, Me.mnuPrepareDataFrameAddMergeColumns, Me.mnuPrepareDataFrameInsertColumnsRows, Me.mnuPrepareDataFrameDeleteColumnsRows, Me.mnuPrepareDataFrameProtectColumn, Me.mnuPrepareDataFrameHideColumns, Me.mnuPrepareDataFrameFreezeColumns, Me.mnuPrepareDataframeColourByProperty})
        Me.mnuPrepareDataFrame.Name = "mnuPrepareDataFrame"
        Me.mnuPrepareDataFrame.Size = New System.Drawing.Size(275, 34)
        Me.mnuPrepareDataFrame.Tag = "Data_Frame"
        Me.mnuPrepareDataFrame.Text = "Data Frame"
        '
        'mnuPrepareDataFrameViewData
        '
        Me.mnuPrepareDataFrameViewData.Name = "mnuPrepareDataFrameViewData"
        Me.mnuPrepareDataFrameViewData.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameViewData.Tag = "View_Data..."
        Me.mnuPrepareDataFrameViewData.Text = "View Data..."
        '
        'mnuPrepareDataFrameRenameColumn
        '
        Me.mnuPrepareDataFrameRenameColumn.Name = "mnuPrepareDataFrameRenameColumn"
        Me.mnuPrepareDataFrameRenameColumn.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameRenameColumn.Tag = "Rename_Column..."
        Me.mnuPrepareDataFrameRenameColumn.Text = "Rename Columns..."
        '
        'mnuPrepareDataFrameDuplicateColumn
        '
        Me.mnuPrepareDataFrameDuplicateColumn.Name = "mnuPrepareDataFrameDuplicateColumn"
        Me.mnuPrepareDataFrameDuplicateColumn.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameDuplicateColumn.Text = "Duplicate Column..."
        '
        'mnuPrepareDataFrameRowNumbersNames
        '
        Me.mnuPrepareDataFrameRowNumbersNames.Name = "mnuPrepareDataFrameRowNumbersNames"
        Me.mnuPrepareDataFrameRowNumbersNames.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameRowNumbersNames.Tag = "Row_Numbers/Names..."
        Me.mnuPrepareDataFrameRowNumbersNames.Text = "Row Numbers/Names..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(298, 6)
        '
        'mnuPrepareDataFrameSort
        '
        Me.mnuPrepareDataFrameSort.Name = "mnuPrepareDataFrameSort"
        Me.mnuPrepareDataFrameSort.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameSort.Tag = "Sort..."
        Me.mnuPrepareDataFrameSort.Text = "Sort..."
        '
        'mnuPrepareDataFrameFilterRows
        '
        Me.mnuPrepareDataFrameFilterRows.Name = "mnuPrepareDataFrameFilterRows"
        Me.mnuPrepareDataFrameFilterRows.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameFilterRows.Tag = "Filter..."
        Me.mnuPrepareDataFrameFilterRows.Text = "Filter Rows..."
        '
        'mnuPrepareDataFrameSelectColumns
        '
        Me.mnuPrepareDataFrameSelectColumns.Name = "mnuPrepareDataFrameSelectColumns"
        Me.mnuPrepareDataFrameSelectColumns.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameSelectColumns.Text = "Select Columns..."
        '
        'mnuPrepareDataFrameReplaceValues
        '
        Me.mnuPrepareDataFrameReplaceValues.Name = "mnuPrepareDataFrameReplaceValues"
        Me.mnuPrepareDataFrameReplaceValues.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameReplaceValues.Tag = "Replace_Values..."
        Me.mnuPrepareDataFrameReplaceValues.Text = "Replace Values..."
        '
        'mnuPrepareDataFrameConvertColumns
        '
        Me.mnuPrepareDataFrameConvertColumns.Name = "mnuPrepareDataFrameConvertColumns"
        Me.mnuPrepareDataFrameConvertColumns.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameConvertColumns.Tag = "Convert_Columns..."
        Me.mnuPrepareDataFrameConvertColumns.Text = "Convert Columns..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(298, 6)
        '
        'mnuPrepareDataFrameReorderColumns
        '
        Me.mnuPrepareDataFrameReorderColumns.Name = "mnuPrepareDataFrameReorderColumns"
        Me.mnuPrepareDataFrameReorderColumns.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameReorderColumns.Tag = "Reorder_Columns..."
        Me.mnuPrepareDataFrameReorderColumns.Text = "Reorder Columns..."
        '
        'mnuPrepareDataFrameAddMergeColumns
        '
        Me.mnuPrepareDataFrameAddMergeColumns.Name = "mnuPrepareDataFrameAddMergeColumns"
        Me.mnuPrepareDataFrameAddMergeColumns.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameAddMergeColumns.Text = "Add (Merge) Columns..."
        '
        'mnuPrepareDataFrameInsertColumnsRows
        '
        Me.mnuPrepareDataFrameInsertColumnsRows.Name = "mnuPrepareDataFrameInsertColumnsRows"
        Me.mnuPrepareDataFrameInsertColumnsRows.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameInsertColumnsRows.Tag = "Insert_Columns/Rows..."
        Me.mnuPrepareDataFrameInsertColumnsRows.Text = "Insert Columns/Rows..."
        '
        'mnuPrepareDataFrameDeleteColumnsRows
        '
        Me.mnuPrepareDataFrameDeleteColumnsRows.Name = "mnuPrepareDataFrameDeleteColumnsRows"
        Me.mnuPrepareDataFrameDeleteColumnsRows.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameDeleteColumnsRows.Tag = "Delete_Columns/Rows..."
        Me.mnuPrepareDataFrameDeleteColumnsRows.Text = "Delete Columns/Rows..."
        '
        'mnuPrepareDataFrameProtectColumn
        '
        Me.mnuPrepareDataFrameProtectColumn.Enabled = False
        Me.mnuPrepareDataFrameProtectColumn.Name = "mnuPrepareDataFrameProtectColumn"
        Me.mnuPrepareDataFrameProtectColumn.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameProtectColumn.Tag = "..."
        Me.mnuPrepareDataFrameProtectColumn.Text = "Protect Column..."
        Me.mnuPrepareDataFrameProtectColumn.Visible = False
        '
        'mnuPrepareDataFrameHideColumns
        '
        Me.mnuPrepareDataFrameHideColumns.Name = "mnuPrepareDataFrameHideColumns"
        Me.mnuPrepareDataFrameHideColumns.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameHideColumns.Tag = "Hide_Columns..."
        Me.mnuPrepareDataFrameHideColumns.Text = "Hide/Show Columns..."
        '
        'mnuPrepareDataFrameFreezeColumns
        '
        Me.mnuPrepareDataFrameFreezeColumns.Enabled = False
        Me.mnuPrepareDataFrameFreezeColumns.Name = "mnuPrepareDataFrameFreezeColumns"
        Me.mnuPrepareDataFrameFreezeColumns.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataFrameFreezeColumns.Tag = "Freeze_Columns..."
        Me.mnuPrepareDataFrameFreezeColumns.Text = "Freeze Columns..."
        Me.mnuPrepareDataFrameFreezeColumns.Visible = False
        '
        'mnuPrepareDataframeColourByProperty
        '
        Me.mnuPrepareDataframeColourByProperty.Name = "mnuPrepareDataframeColourByProperty"
        Me.mnuPrepareDataframeColourByProperty.Size = New System.Drawing.Size(301, 34)
        Me.mnuPrepareDataframeColourByProperty.Text = "Colour by Property..."
        '
        'mnuPrepareCheckData
        '
        Me.mnuPrepareCheckData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuPrepareCheckData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareCheckDataVisualiseData, Me.mnuPrepareCheckDataPivotTable, Me.ToolStripSeparator50, Me.mnuPrepareCheckDataDuplicates, Me.mnuPrepareCheckDataCompareColumns, Me.mnuPrepareCheckDataNonNumericCases, Me.ToolStripSeparator49, Me.mnuPrepareCheckDataBoxplot, Me.mnuPrepareCheckDataOneVariableSummarise, Me.mnuPrepareCheckDataOneVariableGraph, Me.mnuPrepareCheckDataOneWayFrequencies, Me.mnuPrepareCheckDataViewDeleteLabels, Me.ToolStripSeparator41, Me.mnuPrepareCheckDataExportOpenRefine, Me.mnuPrepareCheckDataImportOpenRefine, Me.ToolStripSeparator40, Me.mnuPreparePrepareToShareJitter, Me.mnuPrepareCheckDataPrePareToShareSdcPackage, Me.mnuPrepareCheckDataAnonymiseIDColumn})
        Me.mnuPrepareCheckData.Name = "mnuPrepareCheckData"
        Me.mnuPrepareCheckData.Size = New System.Drawing.Size(275, 34)
        Me.mnuPrepareCheckData.Text = "Check Data"
        '
        'mnuPrepareCheckDataVisualiseData
        '
        Me.mnuPrepareCheckDataVisualiseData.Name = "mnuPrepareCheckDataVisualiseData"
        Me.mnuPrepareCheckDataVisualiseData.Size = New System.Drawing.Size(370, 34)
        Me.mnuPrepareCheckDataVisualiseData.Text = "Visualise Data..."
        '
        'mnuPrepareCheckDataPivotTable
        '
        Me.mnuPrepareCheckDataPivotTable.Name = "mnuPrepareCheckDataPivotTable"
        Me.mnuPrepareCheckDataPivotTable.Size = New System.Drawing.Size(370, 34)
        Me.mnuPrepareCheckDataPivotTable.Text = "Pivot Table..."
        '
        'ToolStripSeparator50
        '
        Me.ToolStripSeparator50.Name = "ToolStripSeparator50"
        Me.ToolStripSeparator50.Size = New System.Drawing.Size(367, 6)
        '
        'mnuPrepareCheckDataDuplicates
        '
        Me.mnuPrepareCheckDataDuplicates.Name = "mnuPrepareCheckDataDuplicates"
        Me.mnuPrepareCheckDataDuplicates.Size = New System.Drawing.Size(370, 34)
        Me.mnuPrepareCheckDataDuplicates.Text = "Duplicate Rows..."
        '
        'mnuPrepareCheckDataCompareColumns
        '
        Me.mnuPrepareCheckDataCompareColumns.Name = "mnuPrepareCheckDataCompareColumns"
        Me.mnuPrepareCheckDataCompareColumns.Size = New System.Drawing.Size(370, 34)
        Me.mnuPrepareCheckDataCompareColumns.Text = "Compare Columns..."
        '
        'mnuPrepareCheckDataNonNumericCases
        '
        Me.mnuPrepareCheckDataNonNumericCases.Name = "mnuPrepareCheckDataNonNumericCases"
        Me.mnuPrepareCheckDataNonNumericCases.Size = New System.Drawing.Size(370, 34)
        Me.mnuPrepareCheckDataNonNumericCases.Text = "Non-Numeric Values..."
        '
        'ToolStripSeparator49
        '
        Me.ToolStripSeparator49.Name = "ToolStripSeparator49"
        Me.ToolStripSeparator49.Size = New System.Drawing.Size(367, 6)
        '
        'mnuPrepareCheckDataBoxplot
        '
        Me.mnuPrepareCheckDataBoxplot.Name = "mnuPrepareCheckDataBoxplot"
        Me.mnuPrepareCheckDataBoxplot.Size = New System.Drawing.Size(370, 34)
        Me.mnuPrepareCheckDataBoxplot.Text = "Boxplot..."
        '
        'mnuPrepareCheckDataOneVariableSummarise
        '
        Me.mnuPrepareCheckDataOneVariableSummarise.Name = "mnuPrepareCheckDataOneVariableSummarise"
        Me.mnuPrepareCheckDataOneVariableSummarise.Size = New System.Drawing.Size(370, 34)
        Me.mnuPrepareCheckDataOneVariableSummarise.Text = "One Variable Summarise..."
        '
        'mnuPrepareCheckDataOneVariableGraph
        '
        Me.mnuPrepareCheckDataOneVariableGraph.Name = "mnuPrepareCheckDataOneVariableGraph"
        Me.mnuPrepareCheckDataOneVariableGraph.Size = New System.Drawing.Size(370, 34)
        Me.mnuPrepareCheckDataOneVariableGraph.Text = "One Variable Graph..."
        '
        'mnuPrepareCheckDataOneWayFrequencies
        '
        Me.mnuPrepareCheckDataOneWayFrequencies.Name = "mnuPrepareCheckDataOneWayFrequencies"
        Me.mnuPrepareCheckDataOneWayFrequencies.Size = New System.Drawing.Size(370, 34)
        Me.mnuPrepareCheckDataOneWayFrequencies.Text = "One Variable Frequencies..."
        '
        'mnuPrepareCheckDataViewDeleteLabels
        '
        Me.mnuPrepareCheckDataViewDeleteLabels.Name = "mnuPrepareCheckDataViewDeleteLabels"
        Me.mnuPrepareCheckDataViewDeleteLabels.Size = New System.Drawing.Size(370, 34)
        Me.mnuPrepareCheckDataViewDeleteLabels.Text = "View/Delete Labels..."
        '
        'ToolStripSeparator41
        '
        Me.ToolStripSeparator41.Name = "ToolStripSeparator41"
        Me.ToolStripSeparator41.Size = New System.Drawing.Size(367, 6)
        '
        'mnuPrepareCheckDataExportOpenRefine
        '
        Me.mnuPrepareCheckDataExportOpenRefine.Name = "mnuPrepareCheckDataExportOpenRefine"
        Me.mnuPrepareCheckDataExportOpenRefine.Size = New System.Drawing.Size(370, 34)
        Me.mnuPrepareCheckDataExportOpenRefine.Text = "Export To OpenRefine..."
        '
        'mnuPrepareCheckDataImportOpenRefine
        '
        Me.mnuPrepareCheckDataImportOpenRefine.Name = "mnuPrepareCheckDataImportOpenRefine"
        Me.mnuPrepareCheckDataImportOpenRefine.Size = New System.Drawing.Size(370, 34)
        Me.mnuPrepareCheckDataImportOpenRefine.Text = "Import From OpenRefine..."
        Me.mnuPrepareCheckDataImportOpenRefine.Visible = False
        '
        'ToolStripSeparator40
        '
        Me.ToolStripSeparator40.Name = "ToolStripSeparator40"
        Me.ToolStripSeparator40.Size = New System.Drawing.Size(367, 6)
        '
        'mnuPreparePrepareToShareJitter
        '
        Me.mnuPreparePrepareToShareJitter.Enabled = False
        Me.mnuPreparePrepareToShareJitter.Name = "mnuPreparePrepareToShareJitter"
        Me.mnuPreparePrepareToShareJitter.Size = New System.Drawing.Size(370, 34)
        Me.mnuPreparePrepareToShareJitter.Text = "Jitter..."
        Me.mnuPreparePrepareToShareJitter.Visible = False
        '
        'mnuPrepareCheckDataPrePareToShareSdcPackage
        '
        Me.mnuPrepareCheckDataPrePareToShareSdcPackage.Enabled = False
        Me.mnuPrepareCheckDataPrePareToShareSdcPackage.Name = "mnuPrepareCheckDataPrePareToShareSdcPackage"
        Me.mnuPrepareCheckDataPrePareToShareSdcPackage.Size = New System.Drawing.Size(370, 34)
        Me.mnuPrepareCheckDataPrePareToShareSdcPackage.Text = "Prepare to Share (sdc package)..."
        Me.mnuPrepareCheckDataPrePareToShareSdcPackage.Visible = False
        '
        'mnuPrepareCheckDataAnonymiseIDColumn
        '
        Me.mnuPrepareCheckDataAnonymiseIDColumn.Name = "mnuPrepareCheckDataAnonymiseIDColumn"
        Me.mnuPrepareCheckDataAnonymiseIDColumn.Size = New System.Drawing.Size(370, 34)
        Me.mnuPrepareCheckDataAnonymiseIDColumn.Text = "Anonymise ID Column..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(272, 6)
        '
        'mnuPrepareCalculator
        '
        Me.mnuPrepareCalculator.Name = "mnuPrepareCalculator"
        Me.mnuPrepareCalculator.Size = New System.Drawing.Size(275, 34)
        Me.mnuPrepareCalculator.Tag = "Calculator..."
        Me.mnuPrepareCalculator.Text = "Column: Calculator..."
        '
        'mnuPrepareColumnCalculate
        '
        Me.mnuPrepareColumnCalculate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnNumericRegularSequence, Me.mnuPrepareColumnNumericEnter, Me.ToolStripSeparator25, Me.mnuPrepareColumnNumericRowSummaries, Me.mnuPrepareColumnNumericTransform, Me.mnuPrepareColumnNumericPolynomials, Me.ToolStripSeparator56, Me.mnuPrepareColumnNumericRandomSamples, Me.mnuPrepareColumnNumericPermuteRows})
        Me.mnuPrepareColumnCalculate.Name = "mnuPrepareColumnCalculate"
        Me.mnuPrepareColumnCalculate.Size = New System.Drawing.Size(275, 34)
        Me.mnuPrepareColumnCalculate.Tag = "Column:_Calculate"
        Me.mnuPrepareColumnCalculate.Text = "Column: Numeric"
        '
        'mnuPrepareColumnNumericRegularSequence
        '
        Me.mnuPrepareColumnNumericRegularSequence.Name = "mnuPrepareColumnNumericRegularSequence"
        Me.mnuPrepareColumnNumericRegularSequence.Size = New System.Drawing.Size(304, 34)
        Me.mnuPrepareColumnNumericRegularSequence.Tag = "Regular_Sequence..."
        Me.mnuPrepareColumnNumericRegularSequence.Text = "Regular Sequence..."
        '
        'mnuPrepareColumnNumericEnter
        '
        Me.mnuPrepareColumnNumericEnter.Name = "mnuPrepareColumnNumericEnter"
        Me.mnuPrepareColumnNumericEnter.Size = New System.Drawing.Size(304, 34)
        Me.mnuPrepareColumnNumericEnter.Text = "Enter..."
        '
        'ToolStripSeparator25
        '
        Me.ToolStripSeparator25.Name = "ToolStripSeparator25"
        Me.ToolStripSeparator25.Size = New System.Drawing.Size(301, 6)
        '
        'mnuPrepareColumnNumericRowSummaries
        '
        Me.mnuPrepareColumnNumericRowSummaries.Name = "mnuPrepareColumnNumericRowSummaries"
        Me.mnuPrepareColumnNumericRowSummaries.Size = New System.Drawing.Size(304, 34)
        Me.mnuPrepareColumnNumericRowSummaries.Text = "Row Summaries..."
        '
        'mnuPrepareColumnNumericTransform
        '
        Me.mnuPrepareColumnNumericTransform.Name = "mnuPrepareColumnNumericTransform"
        Me.mnuPrepareColumnNumericTransform.Size = New System.Drawing.Size(304, 34)
        Me.mnuPrepareColumnNumericTransform.Tag = "Rank..."
        Me.mnuPrepareColumnNumericTransform.Text = "Transform..."
        '
        'mnuPrepareColumnNumericPolynomials
        '
        Me.mnuPrepareColumnNumericPolynomials.Name = "mnuPrepareColumnNumericPolynomials"
        Me.mnuPrepareColumnNumericPolynomials.Size = New System.Drawing.Size(304, 34)
        Me.mnuPrepareColumnNumericPolynomials.Tag = "Polynomials..."
        Me.mnuPrepareColumnNumericPolynomials.Text = "Polynomials..."
        '
        'ToolStripSeparator56
        '
        Me.ToolStripSeparator56.Name = "ToolStripSeparator56"
        Me.ToolStripSeparator56.Size = New System.Drawing.Size(301, 6)
        '
        'mnuPrepareColumnNumericRandomSamples
        '
        Me.mnuPrepareColumnNumericRandomSamples.Name = "mnuPrepareColumnNumericRandomSamples"
        Me.mnuPrepareColumnNumericRandomSamples.Size = New System.Drawing.Size(304, 34)
        Me.mnuPrepareColumnNumericRandomSamples.Tag = "Random_Samples..."
        Me.mnuPrepareColumnNumericRandomSamples.Text = "Random Samples..."
        '
        'mnuPrepareColumnNumericPermuteRows
        '
        Me.mnuPrepareColumnNumericPermuteRows.Name = "mnuPrepareColumnNumericPermuteRows"
        Me.mnuPrepareColumnNumericPermuteRows.Size = New System.Drawing.Size(304, 34)
        Me.mnuPrepareColumnNumericPermuteRows.Tag = "Permute_Rows..."
        Me.mnuPrepareColumnNumericPermuteRows.Text = "Permute/Sample Rows..."
        '
        'mnuPrepareColumnFactor
        '
        Me.mnuPrepareColumnFactor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnFactorConvertToFactor, Me.mnuPrepareColumnFactorRecodeNumeric, Me.mnuPrepareColumnFactorCountInFactor, Me.ToolStripSeparator12, Me.mnuPrepareColumnFactorRecodeFactor, Me.mnuPrepareColumnFactorCombineFactors, Me.mnuPrepareColumnFactorDummyVariables, Me.ToolStripSeparator14, Me.mnuPrepareColumnFactorLevelsLabels, Me.mnuPrepareColumnFactorReorderLevels, Me.mnuPrepareColumnFactorReferenceLevel, Me.mnuPrepareColumnFactorUnusedLevels, Me.mnuPrepareColumnFactorContrasts, Me.ToolStripSeparator19, Me.mnuPrepareColumnFactorFactorDataFrame})
        Me.mnuPrepareColumnFactor.Name = "mnuPrepareColumnFactor"
        Me.mnuPrepareColumnFactor.Size = New System.Drawing.Size(275, 34)
        Me.mnuPrepareColumnFactor.Tag = "Column:_Factor"
        Me.mnuPrepareColumnFactor.Text = "Column: Factor"
        '
        'mnuPrepareColumnFactorConvertToFactor
        '
        Me.mnuPrepareColumnFactorConvertToFactor.Name = "mnuPrepareColumnFactorConvertToFactor"
        Me.mnuPrepareColumnFactorConvertToFactor.Size = New System.Drawing.Size(270, 34)
        Me.mnuPrepareColumnFactorConvertToFactor.Tag = "Convert_To_Factor"
        Me.mnuPrepareColumnFactorConvertToFactor.Text = "Convert To Factor..."
        '
        'mnuPrepareColumnFactorRecodeNumeric
        '
        Me.mnuPrepareColumnFactorRecodeNumeric.Name = "mnuPrepareColumnFactorRecodeNumeric"
        Me.mnuPrepareColumnFactorRecodeNumeric.Size = New System.Drawing.Size(270, 34)
        Me.mnuPrepareColumnFactorRecodeNumeric.Tag = "Recode_Numeric..."
        Me.mnuPrepareColumnFactorRecodeNumeric.Text = "Recode Numeric..."
        '
        'mnuPrepareColumnFactorCountInFactor
        '
        Me.mnuPrepareColumnFactorCountInFactor.Name = "mnuPrepareColumnFactorCountInFactor"
        Me.mnuPrepareColumnFactorCountInFactor.Size = New System.Drawing.Size(270, 34)
        Me.mnuPrepareColumnFactorCountInFactor.Text = "Count in Factor..."
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(267, 6)
        '
        'mnuPrepareColumnFactorRecodeFactor
        '
        Me.mnuPrepareColumnFactorRecodeFactor.Name = "mnuPrepareColumnFactorRecodeFactor"
        Me.mnuPrepareColumnFactorRecodeFactor.Size = New System.Drawing.Size(270, 34)
        Me.mnuPrepareColumnFactorRecodeFactor.Tag = "Recode_Factor..."
        Me.mnuPrepareColumnFactorRecodeFactor.Text = "Recode Factor..."
        '
        'mnuPrepareColumnFactorCombineFactors
        '
        Me.mnuPrepareColumnFactorCombineFactors.Name = "mnuPrepareColumnFactorCombineFactors"
        Me.mnuPrepareColumnFactorCombineFactors.Size = New System.Drawing.Size(270, 34)
        Me.mnuPrepareColumnFactorCombineFactors.Tag = "Combine_Factors..."
        Me.mnuPrepareColumnFactorCombineFactors.Text = "Combine Factors..."
        '
        'mnuPrepareColumnFactorDummyVariables
        '
        Me.mnuPrepareColumnFactorDummyVariables.Name = "mnuPrepareColumnFactorDummyVariables"
        Me.mnuPrepareColumnFactorDummyVariables.Size = New System.Drawing.Size(270, 34)
        Me.mnuPrepareColumnFactorDummyVariables.Tag = "Dummy_Variables..."
        Me.mnuPrepareColumnFactorDummyVariables.Text = "Dummy Variables..."
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(267, 6)
        '
        'mnuPrepareColumnFactorLevelsLabels
        '
        Me.mnuPrepareColumnFactorLevelsLabels.Name = "mnuPrepareColumnFactorLevelsLabels"
        Me.mnuPrepareColumnFactorLevelsLabels.Size = New System.Drawing.Size(270, 34)
        Me.mnuPrepareColumnFactorLevelsLabels.Tag = "Levels/Labels..."
        Me.mnuPrepareColumnFactorLevelsLabels.Text = "Levels/Labels..."
        '
        'mnuPrepareColumnFactorReorderLevels
        '
        Me.mnuPrepareColumnFactorReorderLevels.Name = "mnuPrepareColumnFactorReorderLevels"
        Me.mnuPrepareColumnFactorReorderLevels.Size = New System.Drawing.Size(270, 34)
        Me.mnuPrepareColumnFactorReorderLevels.Tag = "Reorder_Levels..."
        Me.mnuPrepareColumnFactorReorderLevels.Text = "Reorder Levels..."
        '
        'mnuPrepareColumnFactorReferenceLevel
        '
        Me.mnuPrepareColumnFactorReferenceLevel.Name = "mnuPrepareColumnFactorReferenceLevel"
        Me.mnuPrepareColumnFactorReferenceLevel.Size = New System.Drawing.Size(270, 34)
        Me.mnuPrepareColumnFactorReferenceLevel.Tag = "Reference_Level..."
        Me.mnuPrepareColumnFactorReferenceLevel.Text = "Reference Level..."
        '
        'mnuPrepareColumnFactorUnusedLevels
        '
        Me.mnuPrepareColumnFactorUnusedLevels.Name = "mnuPrepareColumnFactorUnusedLevels"
        Me.mnuPrepareColumnFactorUnusedLevels.Size = New System.Drawing.Size(270, 34)
        Me.mnuPrepareColumnFactorUnusedLevels.Tag = "Unused_Levels..."
        Me.mnuPrepareColumnFactorUnusedLevels.Text = "Unused Levels..."
        '
        'mnuPrepareColumnFactorContrasts
        '
        Me.mnuPrepareColumnFactorContrasts.Name = "mnuPrepareColumnFactorContrasts"
        Me.mnuPrepareColumnFactorContrasts.Size = New System.Drawing.Size(270, 34)
        Me.mnuPrepareColumnFactorContrasts.Tag = "Contrasts..."
        Me.mnuPrepareColumnFactorContrasts.Text = "Contrasts..."
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(267, 6)
        '
        'mnuPrepareColumnFactorFactorDataFrame
        '
        Me.mnuPrepareColumnFactorFactorDataFrame.Name = "mnuPrepareColumnFactorFactorDataFrame"
        Me.mnuPrepareColumnFactorFactorDataFrame.Size = New System.Drawing.Size(270, 34)
        Me.mnuPrepareColumnFactorFactorDataFrame.Tag = "Factor_Data_Frame"
        Me.mnuPrepareColumnFactorFactorDataFrame.Text = "Factor Data Frame..."
        '
        'mnuPrepareColumnText
        '
        Me.mnuPrepareColumnText.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnTextFindReplace, Me.mnuPrepareColumnTextSearch, Me.mnuPrepareColumnTextTransform, Me.mnuPrepareColumnTextSplit, Me.mnuPrepareColumnTextCombine, Me.mnuPrepareColumnTextMatch, Me.mnuPrepareColumnTextDistance})
        Me.mnuPrepareColumnText.Name = "mnuPrepareColumnText"
        Me.mnuPrepareColumnText.Size = New System.Drawing.Size(275, 34)
        Me.mnuPrepareColumnText.Tag = "Column:_Text"
        Me.mnuPrepareColumnText.Text = "Column: Text"
        '
        'mnuPrepareColumnTextFindReplace
        '
        Me.mnuPrepareColumnTextFindReplace.Name = "mnuPrepareColumnTextFindReplace"
        Me.mnuPrepareColumnTextFindReplace.Size = New System.Drawing.Size(227, 34)
        Me.mnuPrepareColumnTextFindReplace.Tag = "Find/Replace..."
        Me.mnuPrepareColumnTextFindReplace.Text = "Find/Replace..."
        '
        'mnuPrepareColumnTextSearch
        '
        Me.mnuPrepareColumnTextSearch.Name = "mnuPrepareColumnTextSearch"
        Me.mnuPrepareColumnTextSearch.Size = New System.Drawing.Size(227, 34)
        Me.mnuPrepareColumnTextSearch.Text = "Search..."
        Me.mnuPrepareColumnTextSearch.Visible = False
        '
        'mnuPrepareColumnTextTransform
        '
        Me.mnuPrepareColumnTextTransform.Name = "mnuPrepareColumnTextTransform"
        Me.mnuPrepareColumnTextTransform.Size = New System.Drawing.Size(227, 34)
        Me.mnuPrepareColumnTextTransform.Tag = "Transform..."
        Me.mnuPrepareColumnTextTransform.Text = "Transform..."
        '
        'mnuPrepareColumnTextSplit
        '
        Me.mnuPrepareColumnTextSplit.Name = "mnuPrepareColumnTextSplit"
        Me.mnuPrepareColumnTextSplit.Size = New System.Drawing.Size(227, 34)
        Me.mnuPrepareColumnTextSplit.Tag = "Split..."
        Me.mnuPrepareColumnTextSplit.Text = "Split..."
        '
        'mnuPrepareColumnTextCombine
        '
        Me.mnuPrepareColumnTextCombine.Name = "mnuPrepareColumnTextCombine"
        Me.mnuPrepareColumnTextCombine.Size = New System.Drawing.Size(227, 34)
        Me.mnuPrepareColumnTextCombine.Tag = "Combine..."
        Me.mnuPrepareColumnTextCombine.Text = "Combine..."
        '
        'mnuPrepareColumnTextMatch
        '
        Me.mnuPrepareColumnTextMatch.Enabled = False
        Me.mnuPrepareColumnTextMatch.Name = "mnuPrepareColumnTextMatch"
        Me.mnuPrepareColumnTextMatch.Size = New System.Drawing.Size(227, 34)
        Me.mnuPrepareColumnTextMatch.Tag = "Match..."
        Me.mnuPrepareColumnTextMatch.Text = "Match..."
        Me.mnuPrepareColumnTextMatch.Visible = False
        '
        'mnuPrepareColumnTextDistance
        '
        Me.mnuPrepareColumnTextDistance.Name = "mnuPrepareColumnTextDistance"
        Me.mnuPrepareColumnTextDistance.Size = New System.Drawing.Size(227, 34)
        Me.mnuPrepareColumnTextDistance.Tag = "Distance..."
        Me.mnuPrepareColumnTextDistance.Text = "Distance..."
        '
        'mnuPrepareColumnDate
        '
        Me.mnuPrepareColumnDate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnDateGenerateDate, Me.mnuPrepareColumnDateMakeDate, Me.mnuPrepareColumnDateInfillMissingDates, Me.mnuPrepareColumnDateUseDate, Me.mnuPrepareColumnDateMakeTime, Me.mnuPrepareColumnDateUseTime})
        Me.mnuPrepareColumnDate.Name = "mnuPrepareColumnDate"
        Me.mnuPrepareColumnDate.Size = New System.Drawing.Size(275, 34)
        Me.mnuPrepareColumnDate.Text = "Column: Date"
        '
        'mnuPrepareColumnDateGenerateDate
        '
        Me.mnuPrepareColumnDateGenerateDate.Name = "mnuPrepareColumnDateGenerateDate"
        Me.mnuPrepareColumnDateGenerateDate.Size = New System.Drawing.Size(246, 34)
        Me.mnuPrepareColumnDateGenerateDate.Text = "Generate Dates..."
        '
        'mnuPrepareColumnDateMakeDate
        '
        Me.mnuPrepareColumnDateMakeDate.Name = "mnuPrepareColumnDateMakeDate"
        Me.mnuPrepareColumnDateMakeDate.Size = New System.Drawing.Size(246, 34)
        Me.mnuPrepareColumnDateMakeDate.Text = "Make Date..."
        '
        'mnuPrepareColumnDateInfillMissingDates
        '
        Me.mnuPrepareColumnDateInfillMissingDates.Name = "mnuPrepareColumnDateInfillMissingDates"
        Me.mnuPrepareColumnDateInfillMissingDates.Size = New System.Drawing.Size(246, 34)
        Me.mnuPrepareColumnDateInfillMissingDates.Text = "Fill Date Gaps..."
        '
        'mnuPrepareColumnDateUseDate
        '
        Me.mnuPrepareColumnDateUseDate.Name = "mnuPrepareColumnDateUseDate"
        Me.mnuPrepareColumnDateUseDate.Size = New System.Drawing.Size(246, 34)
        Me.mnuPrepareColumnDateUseDate.Text = "Use Date..."
        '
        'mnuPrepareColumnDateMakeTime
        '
        Me.mnuPrepareColumnDateMakeTime.Enabled = False
        Me.mnuPrepareColumnDateMakeTime.Name = "mnuPrepareColumnDateMakeTime"
        Me.mnuPrepareColumnDateMakeTime.Size = New System.Drawing.Size(246, 34)
        Me.mnuPrepareColumnDateMakeTime.Text = "Make Time..."
        Me.mnuPrepareColumnDateMakeTime.Visible = False
        '
        'mnuPrepareColumnDateUseTime
        '
        Me.mnuPrepareColumnDateUseTime.Enabled = False
        Me.mnuPrepareColumnDateUseTime.Name = "mnuPrepareColumnDateUseTime"
        Me.mnuPrepareColumnDateUseTime.Size = New System.Drawing.Size(246, 34)
        Me.mnuPrepareColumnDateUseTime.Text = "Use Time..."
        Me.mnuPrepareColumnDateUseTime.Visible = False
        '
        'mnuPrepareColumnDefine
        '
        Me.mnuPrepareColumnDefine.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnDefineConvertColumns, Me.ToolStripSeparator55, Me.mnuPrepareColumnDefineCircular})
        Me.mnuPrepareColumnDefine.Name = "mnuPrepareColumnDefine"
        Me.mnuPrepareColumnDefine.Size = New System.Drawing.Size(275, 34)
        Me.mnuPrepareColumnDefine.Text = "Column: Define"
        '
        'mnuPrepareColumnDefineConvertColumns
        '
        Me.mnuPrepareColumnDefineConvertColumns.Name = "mnuPrepareColumnDefineConvertColumns"
        Me.mnuPrepareColumnDefineConvertColumns.Size = New System.Drawing.Size(263, 34)
        Me.mnuPrepareColumnDefineConvertColumns.Text = "Convert Columns..."
        '
        'ToolStripSeparator55
        '
        Me.ToolStripSeparator55.Name = "ToolStripSeparator55"
        Me.ToolStripSeparator55.Size = New System.Drawing.Size(260, 6)
        '
        'mnuPrepareColumnDefineCircular
        '
        Me.mnuPrepareColumnDefineCircular.Name = "mnuPrepareColumnDefineCircular"
        Me.mnuPrepareColumnDefineCircular.Size = New System.Drawing.Size(263, 34)
        Me.mnuPrepareColumnDefineCircular.Text = "Circular..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(272, 6)
        '
        'mnuPrepareDataReshape
        '
        Me.mnuPrepareDataReshape.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnReshapeColumnSummaries, Me.mnuPrepareColumnReshapeGeneralSummaries, Me.ToolStripSeparator10, Me.mnuPrepareColumnReshapeStack, Me.mnuPrepareColumnReshapeUnstack, Me.mnuPrepareColumnReshapeMerge, Me.ToolStripSeparator11, Me.mnuPrepareAppendDataFrame, Me.mnuPrepareColumnReshapeSubset, Me.mnuPrepareColumnReshapeRandomSubset, Me.mnuPrepareColumnReshapeTranspose, Me.mnuPrepareDataReshapeScaleOrDistance, Me.mnuPrepareDataReshapeRandomSplit})
        Me.mnuPrepareDataReshape.Name = "mnuPrepareDataReshape"
        Me.mnuPrepareDataReshape.Size = New System.Drawing.Size(275, 34)
        Me.mnuPrepareDataReshape.Tag = ""
        Me.mnuPrepareDataReshape.Text = "Data Reshape"
        '
        'mnuPrepareColumnReshapeColumnSummaries
        '
        Me.mnuPrepareColumnReshapeColumnSummaries.Name = "mnuPrepareColumnReshapeColumnSummaries"
        Me.mnuPrepareColumnReshapeColumnSummaries.Size = New System.Drawing.Size(295, 34)
        Me.mnuPrepareColumnReshapeColumnSummaries.Tag = "Column_Summaries..."
        Me.mnuPrepareColumnReshapeColumnSummaries.Text = "Column Summaries..."
        '
        'mnuPrepareColumnReshapeGeneralSummaries
        '
        Me.mnuPrepareColumnReshapeGeneralSummaries.Name = "mnuPrepareColumnReshapeGeneralSummaries"
        Me.mnuPrepareColumnReshapeGeneralSummaries.Size = New System.Drawing.Size(295, 34)
        Me.mnuPrepareColumnReshapeGeneralSummaries.Text = "General Summaries..."
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(292, 6)
        '
        'mnuPrepareColumnReshapeStack
        '
        Me.mnuPrepareColumnReshapeStack.Name = "mnuPrepareColumnReshapeStack"
        Me.mnuPrepareColumnReshapeStack.Size = New System.Drawing.Size(295, 34)
        Me.mnuPrepareColumnReshapeStack.Tag = "Stack..."
        Me.mnuPrepareColumnReshapeStack.Text = "Stack (Pivot Longer)..."
        '
        'mnuPrepareColumnReshapeUnstack
        '
        Me.mnuPrepareColumnReshapeUnstack.Name = "mnuPrepareColumnReshapeUnstack"
        Me.mnuPrepareColumnReshapeUnstack.Size = New System.Drawing.Size(295, 34)
        Me.mnuPrepareColumnReshapeUnstack.Tag = "Unstack..."
        Me.mnuPrepareColumnReshapeUnstack.Text = "Unstack (Pivot Wider)..."
        '
        'mnuPrepareColumnReshapeMerge
        '
        Me.mnuPrepareColumnReshapeMerge.Name = "mnuPrepareColumnReshapeMerge"
        Me.mnuPrepareColumnReshapeMerge.Size = New System.Drawing.Size(295, 34)
        Me.mnuPrepareColumnReshapeMerge.Tag = "Merge (Join)..."
        Me.mnuPrepareColumnReshapeMerge.Text = "Merge (Join)..."
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(292, 6)
        '
        'mnuPrepareAppendDataFrame
        '
        Me.mnuPrepareAppendDataFrame.Name = "mnuPrepareAppendDataFrame"
        Me.mnuPrepareAppendDataFrame.Size = New System.Drawing.Size(295, 34)
        Me.mnuPrepareAppendDataFrame.Text = "Append (Bind Rows)..."
        '
        'mnuPrepareColumnReshapeSubset
        '
        Me.mnuPrepareColumnReshapeSubset.Name = "mnuPrepareColumnReshapeSubset"
        Me.mnuPrepareColumnReshapeSubset.Size = New System.Drawing.Size(295, 34)
        Me.mnuPrepareColumnReshapeSubset.Tag = "Subset..."
        Me.mnuPrepareColumnReshapeSubset.Text = "Subset..."
        '
        'mnuPrepareColumnReshapeRandomSubset
        '
        Me.mnuPrepareColumnReshapeRandomSubset.Name = "mnuPrepareColumnReshapeRandomSubset"
        Me.mnuPrepareColumnReshapeRandomSubset.Size = New System.Drawing.Size(295, 34)
        Me.mnuPrepareColumnReshapeRandomSubset.Tag = "Random_Subset..."
        Me.mnuPrepareColumnReshapeRandomSubset.Text = "Random Subset..."
        '
        'mnuPrepareColumnReshapeTranspose
        '
        Me.mnuPrepareColumnReshapeTranspose.Name = "mnuPrepareColumnReshapeTranspose"
        Me.mnuPrepareColumnReshapeTranspose.Size = New System.Drawing.Size(295, 34)
        Me.mnuPrepareColumnReshapeTranspose.Tag = "Transpose..."
        Me.mnuPrepareColumnReshapeTranspose.Text = "Transpose..."
        '
        'mnuPrepareDataReshapeScaleOrDistance
        '
        Me.mnuPrepareDataReshapeScaleOrDistance.Name = "mnuPrepareDataReshapeScaleOrDistance"
        Me.mnuPrepareDataReshapeScaleOrDistance.Size = New System.Drawing.Size(295, 34)
        Me.mnuPrepareDataReshapeScaleOrDistance.Text = "Scale/Distance..."
        '
        'mnuPrepareDataReshapeRandomSplit
        '
        Me.mnuPrepareDataReshapeRandomSplit.Name = "mnuPrepareDataReshapeRandomSplit"
        Me.mnuPrepareDataReshapeRandomSplit.Size = New System.Drawing.Size(295, 34)
        Me.mnuPrepareDataReshapeRandomSplit.Text = "Random Split..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(272, 6)
        '
        'mnuPrepareKeysAndLinks
        '
        Me.mnuPrepareKeysAndLinks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareKeysAndLinksAddKey, Me.mnuPrepareKeysAndLinksViewAndRemoveKey, Me.mnuPrepareKeysAndLinksAddLink, Me.mnuPrepareKeysAndLinksViewAndRemoveKeys, Me.mnuPrepareKeysAndLinksAddComment})
        Me.mnuPrepareKeysAndLinks.Name = "mnuPrepareKeysAndLinks"
        Me.mnuPrepareKeysAndLinks.Size = New System.Drawing.Size(275, 34)
        Me.mnuPrepareKeysAndLinks.Text = "Keys and Links"
        '
        'mnuPrepareKeysAndLinksAddKey
        '
        Me.mnuPrepareKeysAndLinksAddKey.Name = "mnuPrepareKeysAndLinksAddKey"
        Me.mnuPrepareKeysAndLinksAddKey.Size = New System.Drawing.Size(311, 34)
        Me.mnuPrepareKeysAndLinksAddKey.Text = "Add Key..."
        '
        'mnuPrepareKeysAndLinksViewAndRemoveKey
        '
        Me.mnuPrepareKeysAndLinksViewAndRemoveKey.Name = "mnuPrepareKeysAndLinksViewAndRemoveKey"
        Me.mnuPrepareKeysAndLinksViewAndRemoveKey.Size = New System.Drawing.Size(311, 34)
        Me.mnuPrepareKeysAndLinksViewAndRemoveKey.Text = "View and Remove Keys..."
        '
        'mnuPrepareKeysAndLinksAddLink
        '
        Me.mnuPrepareKeysAndLinksAddLink.Name = "mnuPrepareKeysAndLinksAddLink"
        Me.mnuPrepareKeysAndLinksAddLink.Size = New System.Drawing.Size(311, 34)
        Me.mnuPrepareKeysAndLinksAddLink.Text = "Add Link..."
        '
        'mnuPrepareKeysAndLinksViewAndRemoveKeys
        '
        Me.mnuPrepareKeysAndLinksViewAndRemoveKeys.Name = "mnuPrepareKeysAndLinksViewAndRemoveKeys"
        Me.mnuPrepareKeysAndLinksViewAndRemoveKeys.Size = New System.Drawing.Size(311, 34)
        Me.mnuPrepareKeysAndLinksViewAndRemoveKeys.Text = "View and Remove Links..."
        '
        'mnuPrepareKeysAndLinksAddComment
        '
        Me.mnuPrepareKeysAndLinksAddComment.Name = "mnuPrepareKeysAndLinksAddComment"
        Me.mnuPrepareKeysAndLinksAddComment.Size = New System.Drawing.Size(311, 34)
        Me.mnuPrepareKeysAndLinksAddComment.Text = "Add Comment..."
        '
        'mnuPrepareDataBook
        '
        Me.mnuPrepareDataBook.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareDataObjectDataFrameMetadata, Me.mnuPrepareDataObjectRenameDataFrame, Me.mnuPrepareDataObjectReorderDataFrames, Me.mnuPrepareDataObjectCopyDataFrame, Me.mnuPrepareDataObjectDeleteDataFrame, Me.ToolStripSeparator21, Me.mnuPrepareDataObjectHideDataframes, Me.mnuPrepareDataObjectMetadata, Me.mnuPrepareDataObjectRenameMetadata, Me.mnuPrepareDataObjectReorderMetadata, Me.mnuPrepareDataObjectDeleteMetadata})
        Me.mnuPrepareDataBook.Name = "mnuPrepareDataBook"
        Me.mnuPrepareDataBook.Size = New System.Drawing.Size(275, 34)
        Me.mnuPrepareDataBook.Tag = "Data_Object"
        Me.mnuPrepareDataBook.Text = "Data Book"
        '
        'mnuPrepareDataObjectDataFrameMetadata
        '
        Me.mnuPrepareDataObjectDataFrameMetadata.Enabled = False
        Me.mnuPrepareDataObjectDataFrameMetadata.Name = "mnuPrepareDataObjectDataFrameMetadata"
        Me.mnuPrepareDataObjectDataFrameMetadata.Size = New System.Drawing.Size(318, 34)
        Me.mnuPrepareDataObjectDataFrameMetadata.Tag = "Data_Frame_Metadata..."
        Me.mnuPrepareDataObjectDataFrameMetadata.Text = "Data Frame Metadata..."
        Me.mnuPrepareDataObjectDataFrameMetadata.Visible = False
        '
        'mnuPrepareDataObjectRenameDataFrame
        '
        Me.mnuPrepareDataObjectRenameDataFrame.Name = "mnuPrepareDataObjectRenameDataFrame"
        Me.mnuPrepareDataObjectRenameDataFrame.Size = New System.Drawing.Size(318, 34)
        Me.mnuPrepareDataObjectRenameDataFrame.Tag = "ReName_Data_Frame..."
        Me.mnuPrepareDataObjectRenameDataFrame.Text = "Rename Data Frame..."
        '
        'mnuPrepareDataObjectReorderDataFrames
        '
        Me.mnuPrepareDataObjectReorderDataFrames.Name = "mnuPrepareDataObjectReorderDataFrames"
        Me.mnuPrepareDataObjectReorderDataFrames.Size = New System.Drawing.Size(318, 34)
        Me.mnuPrepareDataObjectReorderDataFrames.Tag = "Reorder_Data_Frames..."
        Me.mnuPrepareDataObjectReorderDataFrames.Text = "Reorder Data Frames..."
        '
        'mnuPrepareDataObjectCopyDataFrame
        '
        Me.mnuPrepareDataObjectCopyDataFrame.Name = "mnuPrepareDataObjectCopyDataFrame"
        Me.mnuPrepareDataObjectCopyDataFrame.Size = New System.Drawing.Size(318, 34)
        Me.mnuPrepareDataObjectCopyDataFrame.Tag = "Copy_Data_Frame..."
        Me.mnuPrepareDataObjectCopyDataFrame.Text = "Copy Data Frame..."
        '
        'mnuPrepareDataObjectDeleteDataFrame
        '
        Me.mnuPrepareDataObjectDeleteDataFrame.Name = "mnuPrepareDataObjectDeleteDataFrame"
        Me.mnuPrepareDataObjectDeleteDataFrame.Size = New System.Drawing.Size(318, 34)
        Me.mnuPrepareDataObjectDeleteDataFrame.Tag = "Delete_Data_Frame..."
        Me.mnuPrepareDataObjectDeleteDataFrame.Text = "Delete Data Frames..."
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(315, 6)
        '
        'mnuPrepareDataObjectHideDataframes
        '
        Me.mnuPrepareDataObjectHideDataframes.Name = "mnuPrepareDataObjectHideDataframes"
        Me.mnuPrepareDataObjectHideDataframes.Size = New System.Drawing.Size(318, 34)
        Me.mnuPrepareDataObjectHideDataframes.Text = "Hide/Show Data Frames..."
        '
        'mnuPrepareDataObjectMetadata
        '
        Me.mnuPrepareDataObjectMetadata.Name = "mnuPrepareDataObjectMetadata"
        Me.mnuPrepareDataObjectMetadata.Size = New System.Drawing.Size(318, 34)
        Me.mnuPrepareDataObjectMetadata.Tag = "Metadata..."
        Me.mnuPrepareDataObjectMetadata.Text = "Metadata..."
        '
        'mnuPrepareDataObjectRenameMetadata
        '
        Me.mnuPrepareDataObjectRenameMetadata.Enabled = False
        Me.mnuPrepareDataObjectRenameMetadata.Name = "mnuPrepareDataObjectRenameMetadata"
        Me.mnuPrepareDataObjectRenameMetadata.Size = New System.Drawing.Size(318, 34)
        Me.mnuPrepareDataObjectRenameMetadata.Tag = "Rename_Metadata..."
        Me.mnuPrepareDataObjectRenameMetadata.Text = "Rename Metadata..."
        Me.mnuPrepareDataObjectRenameMetadata.Visible = False
        '
        'mnuPrepareDataObjectReorderMetadata
        '
        Me.mnuPrepareDataObjectReorderMetadata.Enabled = False
        Me.mnuPrepareDataObjectReorderMetadata.Name = "mnuPrepareDataObjectReorderMetadata"
        Me.mnuPrepareDataObjectReorderMetadata.Size = New System.Drawing.Size(318, 34)
        Me.mnuPrepareDataObjectReorderMetadata.Tag = "Reorder_Metadata..."
        Me.mnuPrepareDataObjectReorderMetadata.Text = "Reorder Metadata..."
        Me.mnuPrepareDataObjectReorderMetadata.Visible = False
        '
        'mnuPrepareDataObjectDeleteMetadata
        '
        Me.mnuPrepareDataObjectDeleteMetadata.Enabled = False
        Me.mnuPrepareDataObjectDeleteMetadata.Name = "mnuPrepareDataObjectDeleteMetadata"
        Me.mnuPrepareDataObjectDeleteMetadata.Size = New System.Drawing.Size(318, 34)
        Me.mnuPrepareDataObjectDeleteMetadata.Tag = "Delete_Metadata..."
        Me.mnuPrepareDataObjectDeleteMetadata.Text = "Delete Metadata..."
        Me.mnuPrepareDataObjectDeleteMetadata.Visible = False
        '
        'mnuPrepareRObjects
        '
        Me.mnuPrepareRObjects.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareRObjectsView, Me.mnuPrepareRObjectsRename, Me.mnuPrepareRObjectsReorder, Me.mnuPrepareRObjectsDelete})
        Me.mnuPrepareRObjects.Name = "mnuPrepareRObjects"
        Me.mnuPrepareRObjects.Size = New System.Drawing.Size(275, 34)
        Me.mnuPrepareRObjects.Tag = "R_Objects"
        Me.mnuPrepareRObjects.Text = "R Objects"
        '
        'mnuPrepareRObjectsView
        '
        Me.mnuPrepareRObjectsView.Name = "mnuPrepareRObjectsView"
        Me.mnuPrepareRObjectsView.Size = New System.Drawing.Size(189, 34)
        Me.mnuPrepareRObjectsView.Tag = "View..."
        Me.mnuPrepareRObjectsView.Text = "View..."
        '
        'mnuPrepareRObjectsRename
        '
        Me.mnuPrepareRObjectsRename.Name = "mnuPrepareRObjectsRename"
        Me.mnuPrepareRObjectsRename.Size = New System.Drawing.Size(189, 34)
        Me.mnuPrepareRObjectsRename.Tag = "Rename..."
        Me.mnuPrepareRObjectsRename.Text = "Rename..."
        '
        'mnuPrepareRObjectsReorder
        '
        Me.mnuPrepareRObjectsReorder.Name = "mnuPrepareRObjectsReorder"
        Me.mnuPrepareRObjectsReorder.Size = New System.Drawing.Size(189, 34)
        Me.mnuPrepareRObjectsReorder.Tag = "Reorder"
        Me.mnuPrepareRObjectsReorder.Text = "Reorder..."
        '
        'mnuPrepareRObjectsDelete
        '
        Me.mnuPrepareRObjectsDelete.Name = "mnuPrepareRObjectsDelete"
        Me.mnuPrepareRObjectsDelete.Size = New System.Drawing.Size(189, 34)
        Me.mnuPrepareRObjectsDelete.Tag = "Delete..."
        Me.mnuPrepareRObjectsDelete.Text = "Delete..."
        '
        'mnuStructured
        '
        Me.mnuStructured.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStructuredCircular, Me.mnuStructuredLow_Flow, Me.mnuStructuredSurvival, Me.mnuStructuredTimeSeries, Me.ToolStripSeparator63, Me.mnuStructuredClimatic, Me.mnuStructuredProcurement, Me.mnuStructuredOptionByContext, Me.mnuStructuredSurvey})
        Me.mnuStructured.Name = "mnuStructured"
        Me.mnuStructured.Size = New System.Drawing.Size(109, 29)
        Me.mnuStructured.Text = "Structured"
        '
        'mnuStructuredCircular
        '
        Me.mnuStructuredCircular.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStructuredCircularDefine, Me.mnuStructuredCircularCalculator, Me.mnuStructuredCircularSummaries, Me.ToolStripSeparator46, Me.mnuStructuredCircularDensityPlot, Me.ToolStripSeparator67, Me.mnuStructuredCircularWindRose, Me.mnuStructuredCircularWindPollutionRose, Me.mnuStructuredCircularOtherRosePlots, Me.ToolStripSeparator68, Me.mnuStructuredCircularCirclize})
        Me.mnuStructuredCircular.Name = "mnuStructuredCircular"
        Me.mnuStructuredCircular.Size = New System.Drawing.Size(281, 34)
        Me.mnuStructuredCircular.Text = "Circular"
        '
        'mnuStructuredCircularDefine
        '
        Me.mnuStructuredCircularDefine.Name = "mnuStructuredCircularDefine"
        Me.mnuStructuredCircularDefine.Size = New System.Drawing.Size(287, 34)
        Me.mnuStructuredCircularDefine.Text = "Define..."
        '
        'mnuStructuredCircularCalculator
        '
        Me.mnuStructuredCircularCalculator.Name = "mnuStructuredCircularCalculator"
        Me.mnuStructuredCircularCalculator.Size = New System.Drawing.Size(287, 34)
        Me.mnuStructuredCircularCalculator.Text = "Calculator..."
        '
        'mnuStructuredCircularSummaries
        '
        Me.mnuStructuredCircularSummaries.Name = "mnuStructuredCircularSummaries"
        Me.mnuStructuredCircularSummaries.Size = New System.Drawing.Size(287, 34)
        Me.mnuStructuredCircularSummaries.Text = "Summaries..."
        '
        'ToolStripSeparator46
        '
        Me.ToolStripSeparator46.Name = "ToolStripSeparator46"
        Me.ToolStripSeparator46.Size = New System.Drawing.Size(284, 6)
        '
        'mnuStructuredCircularDensityPlot
        '
        Me.mnuStructuredCircularDensityPlot.Name = "mnuStructuredCircularDensityPlot"
        Me.mnuStructuredCircularDensityPlot.Size = New System.Drawing.Size(287, 34)
        Me.mnuStructuredCircularDensityPlot.Text = "Circular Plots..."
        '
        'ToolStripSeparator67
        '
        Me.ToolStripSeparator67.Name = "ToolStripSeparator67"
        Me.ToolStripSeparator67.Size = New System.Drawing.Size(284, 6)
        '
        'mnuStructuredCircularWindRose
        '
        Me.mnuStructuredCircularWindRose.Name = "mnuStructuredCircularWindRose"
        Me.mnuStructuredCircularWindRose.Size = New System.Drawing.Size(287, 34)
        Me.mnuStructuredCircularWindRose.Text = "Wind Rose..."
        '
        'mnuStructuredCircularWindPollutionRose
        '
        Me.mnuStructuredCircularWindPollutionRose.Name = "mnuStructuredCircularWindPollutionRose"
        Me.mnuStructuredCircularWindPollutionRose.Size = New System.Drawing.Size(287, 34)
        Me.mnuStructuredCircularWindPollutionRose.Text = "Wind/Pollution Rose..."
        '
        'mnuStructuredCircularOtherRosePlots
        '
        Me.mnuStructuredCircularOtherRosePlots.Name = "mnuStructuredCircularOtherRosePlots"
        Me.mnuStructuredCircularOtherRosePlots.Size = New System.Drawing.Size(287, 34)
        Me.mnuStructuredCircularOtherRosePlots.Text = "Other Rose Plots"
        '
        'ToolStripSeparator68
        '
        Me.ToolStripSeparator68.Name = "ToolStripSeparator68"
        Me.ToolStripSeparator68.Size = New System.Drawing.Size(284, 6)
        '
        'mnuStructuredCircularCirclize
        '
        Me.mnuStructuredCircularCirclize.Enabled = False
        Me.mnuStructuredCircularCirclize.Name = "mnuStructuredCircularCirclize"
        Me.mnuStructuredCircularCirclize.Size = New System.Drawing.Size(287, 34)
        Me.mnuStructuredCircularCirclize.Text = "Circlize..."
        Me.mnuStructuredCircularCirclize.Visible = False
        '
        'mnuStructuredLow_Flow
        '
        Me.mnuStructuredLow_Flow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStructuredLow_FlowDefine})
        Me.mnuStructuredLow_Flow.Name = "mnuStructuredLow_Flow"
        Me.mnuStructuredLow_Flow.Size = New System.Drawing.Size(281, 34)
        Me.mnuStructuredLow_Flow.Text = "Low_Flow"
        Me.mnuStructuredLow_Flow.Visible = False
        '
        'mnuStructuredLow_FlowDefine
        '
        Me.mnuStructuredLow_FlowDefine.Name = "mnuStructuredLow_FlowDefine"
        Me.mnuStructuredLow_FlowDefine.Size = New System.Drawing.Size(177, 34)
        Me.mnuStructuredLow_FlowDefine.Text = "Define..."
        '
        'mnuStructuredSurvival
        '
        Me.mnuStructuredSurvival.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStructuredSurvivalDefine})
        Me.mnuStructuredSurvival.Name = "mnuStructuredSurvival"
        Me.mnuStructuredSurvival.Size = New System.Drawing.Size(281, 34)
        Me.mnuStructuredSurvival.Text = "Survival"
        '
        'mnuStructuredSurvivalDefine
        '
        Me.mnuStructuredSurvivalDefine.Name = "mnuStructuredSurvivalDefine"
        Me.mnuStructuredSurvivalDefine.Size = New System.Drawing.Size(177, 34)
        Me.mnuStructuredSurvivalDefine.Text = "Define..."
        '
        'mnuStructuredTimeSeries
        '
        Me.mnuStructuredTimeSeries.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStructuredTimeSeriesDefine, Me.ToolStripSeparator60, Me.mnuStructuredTimeSeriesDescribe, Me.ToolStripSeparator61, Me.mnuStructuredTimeSeriesModel, Me.ToolStripSeparator62})
        Me.mnuStructuredTimeSeries.Name = "mnuStructuredTimeSeries"
        Me.mnuStructuredTimeSeries.Size = New System.Drawing.Size(281, 34)
        Me.mnuStructuredTimeSeries.Text = "Time Series"
        Me.mnuStructuredTimeSeries.Visible = False
        '
        'mnuStructuredTimeSeriesDefine
        '
        Me.mnuStructuredTimeSeriesDefine.Name = "mnuStructuredTimeSeriesDefine"
        Me.mnuStructuredTimeSeriesDefine.Size = New System.Drawing.Size(182, 34)
        Me.mnuStructuredTimeSeriesDefine.Text = "Define..."
        '
        'ToolStripSeparator60
        '
        Me.ToolStripSeparator60.Name = "ToolStripSeparator60"
        Me.ToolStripSeparator60.Size = New System.Drawing.Size(179, 6)
        '
        'mnuStructuredTimeSeriesDescribe
        '
        Me.mnuStructuredTimeSeriesDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStructuredTimeSeriesDescribeOneVariable, Me.mnuStructuredTimeSeriesDescribeGeneral})
        Me.mnuStructuredTimeSeriesDescribe.Name = "mnuStructuredTimeSeriesDescribe"
        Me.mnuStructuredTimeSeriesDescribe.Size = New System.Drawing.Size(182, 34)
        Me.mnuStructuredTimeSeriesDescribe.Text = "Describe"
        '
        'mnuStructuredTimeSeriesDescribeOneVariable
        '
        Me.mnuStructuredTimeSeriesDescribeOneVariable.Name = "mnuStructuredTimeSeriesDescribeOneVariable"
        Me.mnuStructuredTimeSeriesDescribeOneVariable.Size = New System.Drawing.Size(226, 34)
        Me.mnuStructuredTimeSeriesDescribeOneVariable.Text = "One Variable..."
        '
        'mnuStructuredTimeSeriesDescribeGeneral
        '
        Me.mnuStructuredTimeSeriesDescribeGeneral.Name = "mnuStructuredTimeSeriesDescribeGeneral"
        Me.mnuStructuredTimeSeriesDescribeGeneral.Size = New System.Drawing.Size(226, 34)
        Me.mnuStructuredTimeSeriesDescribeGeneral.Text = "General..."
        '
        'ToolStripSeparator61
        '
        Me.ToolStripSeparator61.Name = "ToolStripSeparator61"
        Me.ToolStripSeparator61.Size = New System.Drawing.Size(179, 6)
        '
        'mnuStructuredTimeSeriesModel
        '
        Me.mnuStructuredTimeSeriesModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStructuredTimeSeriesModelOneVariable, Me.mnuStructuredTimeSeriesModelGeneral})
        Me.mnuStructuredTimeSeriesModel.Name = "mnuStructuredTimeSeriesModel"
        Me.mnuStructuredTimeSeriesModel.Size = New System.Drawing.Size(182, 34)
        Me.mnuStructuredTimeSeriesModel.Text = "Model"
        '
        'mnuStructuredTimeSeriesModelOneVariable
        '
        Me.mnuStructuredTimeSeriesModelOneVariable.Name = "mnuStructuredTimeSeriesModelOneVariable"
        Me.mnuStructuredTimeSeriesModelOneVariable.Size = New System.Drawing.Size(226, 34)
        Me.mnuStructuredTimeSeriesModelOneVariable.Text = "One Variable..."
        '
        'mnuStructuredTimeSeriesModelGeneral
        '
        Me.mnuStructuredTimeSeriesModelGeneral.Name = "mnuStructuredTimeSeriesModelGeneral"
        Me.mnuStructuredTimeSeriesModelGeneral.Size = New System.Drawing.Size(226, 34)
        Me.mnuStructuredTimeSeriesModelGeneral.Text = "General..."
        '
        'ToolStripSeparator62
        '
        Me.ToolStripSeparator62.Name = "ToolStripSeparator62"
        Me.ToolStripSeparator62.Size = New System.Drawing.Size(179, 6)
        '
        'ToolStripSeparator63
        '
        Me.ToolStripSeparator63.Name = "ToolStripSeparator63"
        Me.ToolStripSeparator63.Size = New System.Drawing.Size(278, 6)
        '
        'mnuStructuredClimatic
        '
        Me.mnuStructuredClimatic.Name = "mnuStructuredClimatic"
        Me.mnuStructuredClimatic.Size = New System.Drawing.Size(281, 34)
        Me.mnuStructuredClimatic.Text = "Climatic..."
        Me.mnuStructuredClimatic.Visible = False
        '
        'mnuStructuredProcurement
        '
        Me.mnuStructuredProcurement.Name = "mnuStructuredProcurement"
        Me.mnuStructuredProcurement.Size = New System.Drawing.Size(281, 34)
        Me.mnuStructuredProcurement.Text = "Procurement..."
        Me.mnuStructuredProcurement.Visible = False
        '
        'mnuStructuredOptionByContext
        '
        Me.mnuStructuredOptionByContext.Name = "mnuStructuredOptionByContext"
        Me.mnuStructuredOptionByContext.Size = New System.Drawing.Size(281, 34)
        Me.mnuStructuredOptionByContext.Text = "Options by Context..."
        Me.mnuStructuredOptionByContext.Visible = False
        '
        'mnuStructuredSurvey
        '
        Me.mnuStructuredSurvey.Name = "mnuStructuredSurvey"
        Me.mnuStructuredSurvey.Size = New System.Drawing.Size(281, 34)
        Me.mnuStructuredSurvey.Text = "Survey"
        Me.mnuStructuredSurvey.Visible = False
        '
        'mnuProcurement
        '
        Me.mnuProcurement.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementOpenFromLibrary, Me.mnuProcurementDefineData, Me.mnuProcurementPrepare, Me.mnuProcurementDescribe, Me.mnuProcurementMapping, Me.mnuProcurementModel, Me.ToolStripSeparator45, Me.mnuProcurementDefineRedFlags, Me.mnuProcurementUseCRI})
        Me.mnuProcurement.Name = "mnuProcurement"
        Me.mnuProcurement.Size = New System.Drawing.Size(129, 29)
        Me.mnuProcurement.Text = "Procurement"
        '
        'mnuProcurementOpenFromLibrary
        '
        Me.mnuProcurementOpenFromLibrary.Name = "mnuProcurementOpenFromLibrary"
        Me.mnuProcurementOpenFromLibrary.Size = New System.Drawing.Size(327, 34)
        Me.mnuProcurementOpenFromLibrary.Text = "Open From Library..."
        '
        'mnuProcurementDefineData
        '
        Me.mnuProcurementDefineData.Name = "mnuProcurementDefineData"
        Me.mnuProcurementDefineData.Size = New System.Drawing.Size(327, 34)
        Me.mnuProcurementDefineData.Text = "Define Procurement Data..."
        '
        'mnuProcurementPrepare
        '
        Me.mnuProcurementPrepare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementPrepareFilterByCountry, Me.ToolStripSeparator42, Me.mnuProcurementPrepareDefineContractValueCategories, Me.mnuProcurementPrepareRecodeNumericIntoQuantiles, Me.mnuProcurementPrepareSetFactorReferenceLevel, Me.mnuProcurementPrepareUseAwardDate, Me.ToolStripSeparator43, Me.mnuProcurementPrepareSummariseRedFlagsByCountryorOther, Me.mnuProcurementPrepareSummariseRedFlagsByCountryAndYearorOther, Me.mnuProcurementPrepareMergeAdditionalData})
        Me.mnuProcurementPrepare.Name = "mnuProcurementPrepare"
        Me.mnuProcurementPrepare.Size = New System.Drawing.Size(327, 34)
        Me.mnuProcurementPrepare.Text = "Prepare"
        '
        'mnuProcurementPrepareFilterByCountry
        '
        Me.mnuProcurementPrepareFilterByCountry.Name = "mnuProcurementPrepareFilterByCountry"
        Me.mnuProcurementPrepareFilterByCountry.Size = New System.Drawing.Size(539, 34)
        Me.mnuProcurementPrepareFilterByCountry.Text = "Filter by Country (or other)..."
        '
        'ToolStripSeparator42
        '
        Me.ToolStripSeparator42.Name = "ToolStripSeparator42"
        Me.ToolStripSeparator42.Size = New System.Drawing.Size(536, 6)
        '
        'mnuProcurementPrepareDefineContractValueCategories
        '
        Me.mnuProcurementPrepareDefineContractValueCategories.Name = "mnuProcurementPrepareDefineContractValueCategories"
        Me.mnuProcurementPrepareDefineContractValueCategories.Size = New System.Drawing.Size(539, 34)
        Me.mnuProcurementPrepareDefineContractValueCategories.Text = "Define Contract Value Categories..."
        '
        'mnuProcurementPrepareRecodeNumericIntoQuantiles
        '
        Me.mnuProcurementPrepareRecodeNumericIntoQuantiles.Name = "mnuProcurementPrepareRecodeNumericIntoQuantiles"
        Me.mnuProcurementPrepareRecodeNumericIntoQuantiles.Size = New System.Drawing.Size(539, 34)
        Me.mnuProcurementPrepareRecodeNumericIntoQuantiles.Text = "Recode Numeric into Quantiles..."
        '
        'mnuProcurementPrepareSetFactorReferenceLevel
        '
        Me.mnuProcurementPrepareSetFactorReferenceLevel.Name = "mnuProcurementPrepareSetFactorReferenceLevel"
        Me.mnuProcurementPrepareSetFactorReferenceLevel.Size = New System.Drawing.Size(539, 34)
        Me.mnuProcurementPrepareSetFactorReferenceLevel.Text = "Set Factor Reference Level..."
        '
        'mnuProcurementPrepareUseAwardDate
        '
        Me.mnuProcurementPrepareUseAwardDate.Name = "mnuProcurementPrepareUseAwardDate"
        Me.mnuProcurementPrepareUseAwardDate.Size = New System.Drawing.Size(539, 34)
        Me.mnuProcurementPrepareUseAwardDate.Text = "Use Award Date (or other)..."
        '
        'ToolStripSeparator43
        '
        Me.ToolStripSeparator43.Name = "ToolStripSeparator43"
        Me.ToolStripSeparator43.Size = New System.Drawing.Size(536, 6)
        '
        'mnuProcurementPrepareSummariseRedFlagsByCountryorOther
        '
        Me.mnuProcurementPrepareSummariseRedFlagsByCountryorOther.Name = "mnuProcurementPrepareSummariseRedFlagsByCountryorOther"
        Me.mnuProcurementPrepareSummariseRedFlagsByCountryorOther.Size = New System.Drawing.Size(539, 34)
        Me.mnuProcurementPrepareSummariseRedFlagsByCountryorOther.Text = "Summarise Red Flags by Country (or other)..."
        '
        'mnuProcurementPrepareSummariseRedFlagsByCountryAndYearorOther
        '
        Me.mnuProcurementPrepareSummariseRedFlagsByCountryAndYearorOther.Name = "mnuProcurementPrepareSummariseRedFlagsByCountryAndYearorOther"
        Me.mnuProcurementPrepareSummariseRedFlagsByCountryAndYearorOther.Size = New System.Drawing.Size(539, 34)
        Me.mnuProcurementPrepareSummariseRedFlagsByCountryAndYearorOther.Text = "Summarise Red Flags by Country and Year (or other)..."
        '
        'mnuProcurementPrepareMergeAdditionalData
        '
        Me.mnuProcurementPrepareMergeAdditionalData.Name = "mnuProcurementPrepareMergeAdditionalData"
        Me.mnuProcurementPrepareMergeAdditionalData.Size = New System.Drawing.Size(539, 34)
        Me.mnuProcurementPrepareMergeAdditionalData.Text = "Merge Additional Data..."
        '
        'mnuProcurementDescribe
        '
        Me.mnuProcurementDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementDescribeOneVariableSummarise, Me.mnuProcurementDescribeOneVariableGraph, Me.ToolStripSeparator44, Me.mnuProcurementDescribeCategorical, Me.mnuProcurementDescribeNumeric})
        Me.mnuProcurementDescribe.Name = "mnuProcurementDescribe"
        Me.mnuProcurementDescribe.Size = New System.Drawing.Size(327, 34)
        Me.mnuProcurementDescribe.Text = "Describe"
        '
        'mnuProcurementDescribeOneVariableSummarise
        '
        Me.mnuProcurementDescribeOneVariableSummarise.Name = "mnuProcurementDescribeOneVariableSummarise"
        Me.mnuProcurementDescribeOneVariableSummarise.Size = New System.Drawing.Size(319, 34)
        Me.mnuProcurementDescribeOneVariableSummarise.Text = "One Variable Summarise..."
        '
        'mnuProcurementDescribeOneVariableGraph
        '
        Me.mnuProcurementDescribeOneVariableGraph.Name = "mnuProcurementDescribeOneVariableGraph"
        Me.mnuProcurementDescribeOneVariableGraph.Size = New System.Drawing.Size(319, 34)
        Me.mnuProcurementDescribeOneVariableGraph.Text = "One Variable Graph..."
        '
        'ToolStripSeparator44
        '
        Me.ToolStripSeparator44.Name = "ToolStripSeparator44"
        Me.ToolStripSeparator44.Size = New System.Drawing.Size(316, 6)
        '
        'mnuProcurementDescribeCategorical
        '
        Me.mnuProcurementDescribeCategorical.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementDescribeCategoricalOneVarFreq, Me.mnuProcurementDescribeCategoricalTwoVarFreq, Me.ToolStripSeparator52, Me.mnuProcurementDescribeCategoricalBarCharts, Me.mnuProcurementDescribeCategoricalMosaic, Me.mnuProcurementDescribeCategoricalTreemap, Me.DisplayTopNToolStripMenuItem})
        Me.mnuProcurementDescribeCategorical.Name = "mnuProcurementDescribeCategorical"
        Me.mnuProcurementDescribeCategorical.Size = New System.Drawing.Size(319, 34)
        Me.mnuProcurementDescribeCategorical.Text = "Categorical"
        '
        'mnuProcurementDescribeCategoricalOneVarFreq
        '
        Me.mnuProcurementDescribeCategoricalOneVarFreq.Name = "mnuProcurementDescribeCategoricalOneVarFreq"
        Me.mnuProcurementDescribeCategoricalOneVarFreq.Size = New System.Drawing.Size(482, 34)
        Me.mnuProcurementDescribeCategoricalOneVarFreq.Text = "One Variable Frequencies..."
        '
        'mnuProcurementDescribeCategoricalTwoVarFreq
        '
        Me.mnuProcurementDescribeCategoricalTwoVarFreq.Name = "mnuProcurementDescribeCategoricalTwoVarFreq"
        Me.mnuProcurementDescribeCategoricalTwoVarFreq.Size = New System.Drawing.Size(482, 34)
        Me.mnuProcurementDescribeCategoricalTwoVarFreq.Text = "Two Variable Frequencies by Sector (or other)..."
        '
        'ToolStripSeparator52
        '
        Me.ToolStripSeparator52.Name = "ToolStripSeparator52"
        Me.ToolStripSeparator52.Size = New System.Drawing.Size(479, 6)
        '
        'mnuProcurementDescribeCategoricalBarCharts
        '
        Me.mnuProcurementDescribeCategoricalBarCharts.Name = "mnuProcurementDescribeCategoricalBarCharts"
        Me.mnuProcurementDescribeCategoricalBarCharts.Size = New System.Drawing.Size(482, 34)
        Me.mnuProcurementDescribeCategoricalBarCharts.Text = "Bar Chart..."
        '
        'mnuProcurementDescribeCategoricalMosaic
        '
        Me.mnuProcurementDescribeCategoricalMosaic.Name = "mnuProcurementDescribeCategoricalMosaic"
        Me.mnuProcurementDescribeCategoricalMosaic.Size = New System.Drawing.Size(482, 34)
        Me.mnuProcurementDescribeCategoricalMosaic.Text = "Mosaic Plot..."
        '
        'mnuProcurementDescribeCategoricalTreemap
        '
        Me.mnuProcurementDescribeCategoricalTreemap.Name = "mnuProcurementDescribeCategoricalTreemap"
        Me.mnuProcurementDescribeCategoricalTreemap.Size = New System.Drawing.Size(482, 34)
        Me.mnuProcurementDescribeCategoricalTreemap.Text = "Treemap..."
        '
        'DisplayTopNToolStripMenuItem
        '
        Me.DisplayTopNToolStripMenuItem.Name = "DisplayTopNToolStripMenuItem"
        Me.DisplayTopNToolStripMenuItem.Size = New System.Drawing.Size(482, 34)
        Me.DisplayTopNToolStripMenuItem.Text = "Display Top N..."
        '
        'mnuProcurementDescribeNumeric
        '
        Me.mnuProcurementDescribeNumeric.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementDescribeNumericBoxplot, Me.HistogramToolStripMenuItem, Me.ToolStripSeparator53, Me.mnuProcurementDescribeNumericCorrelationsRedFlagsOrOthers})
        Me.mnuProcurementDescribeNumeric.Name = "mnuProcurementDescribeNumeric"
        Me.mnuProcurementDescribeNumeric.Size = New System.Drawing.Size(319, 34)
        Me.mnuProcurementDescribeNumeric.Text = "Numeric"
        '
        'mnuProcurementDescribeNumericBoxplot
        '
        Me.mnuProcurementDescribeNumericBoxplot.Name = "mnuProcurementDescribeNumericBoxplot"
        Me.mnuProcurementDescribeNumericBoxplot.Size = New System.Drawing.Size(389, 34)
        Me.mnuProcurementDescribeNumericBoxplot.Text = "Boxplot..."
        '
        'HistogramToolStripMenuItem
        '
        Me.HistogramToolStripMenuItem.Name = "HistogramToolStripMenuItem"
        Me.HistogramToolStripMenuItem.Size = New System.Drawing.Size(389, 34)
        Me.HistogramToolStripMenuItem.Text = "Histogram..."
        '
        'ToolStripSeparator53
        '
        Me.ToolStripSeparator53.Name = "ToolStripSeparator53"
        Me.ToolStripSeparator53.Size = New System.Drawing.Size(386, 6)
        '
        'mnuProcurementDescribeNumericCorrelationsRedFlagsOrOthers
        '
        Me.mnuProcurementDescribeNumericCorrelationsRedFlagsOrOthers.Name = "mnuProcurementDescribeNumericCorrelationsRedFlagsOrOthers"
        Me.mnuProcurementDescribeNumericCorrelationsRedFlagsOrOthers.Size = New System.Drawing.Size(389, 34)
        Me.mnuProcurementDescribeNumericCorrelationsRedFlagsOrOthers.Text = "Correlations (Red Flags or others)..."
        '
        'mnuProcurementMapping
        '
        Me.mnuProcurementMapping.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementMappingMapCountryValues})
        Me.mnuProcurementMapping.Name = "mnuProcurementMapping"
        Me.mnuProcurementMapping.Size = New System.Drawing.Size(327, 34)
        Me.mnuProcurementMapping.Text = "Mapping"
        '
        'mnuProcurementMappingMapCountryValues
        '
        Me.mnuProcurementMappingMapCountryValues.Name = "mnuProcurementMappingMapCountryValues"
        Me.mnuProcurementMappingMapCountryValues.Size = New System.Drawing.Size(285, 34)
        Me.mnuProcurementMappingMapCountryValues.Text = "Map Country Values..."
        '
        'mnuProcurementModel
        '
        Me.mnuProcurementModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementModelDefineCorruption, Me.mnuProcurementModelFitModelToolStripMenuItem})
        Me.mnuProcurementModel.Name = "mnuProcurementModel"
        Me.mnuProcurementModel.Size = New System.Drawing.Size(327, 34)
        Me.mnuProcurementModel.Text = "Model"
        '
        'mnuProcurementModelDefineCorruption
        '
        Me.mnuProcurementModelDefineCorruption.Name = "mnuProcurementModelDefineCorruption"
        Me.mnuProcurementModelDefineCorruption.Size = New System.Drawing.Size(351, 34)
        Me.mnuProcurementModelDefineCorruption.Text = "Define Corruption Indicators..."
        '
        'mnuProcurementModelFitModelToolStripMenuItem
        '
        Me.mnuProcurementModelFitModelToolStripMenuItem.Name = "mnuProcurementModelFitModelToolStripMenuItem"
        Me.mnuProcurementModelFitModelToolStripMenuItem.Size = New System.Drawing.Size(351, 34)
        Me.mnuProcurementModelFitModelToolStripMenuItem.Text = "Fit Model..."
        '
        'ToolStripSeparator45
        '
        Me.ToolStripSeparator45.Name = "ToolStripSeparator45"
        Me.ToolStripSeparator45.Size = New System.Drawing.Size(324, 6)
        '
        'mnuProcurementDefineRedFlags
        '
        Me.mnuProcurementDefineRedFlags.Name = "mnuProcurementDefineRedFlags"
        Me.mnuProcurementDefineRedFlags.Size = New System.Drawing.Size(327, 34)
        Me.mnuProcurementDefineRedFlags.Text = "Define Red Flag Variables..."
        '
        'mnuProcurementUseCRI
        '
        Me.mnuProcurementUseCRI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProcurementCTFVCalculateCRI, Me.mnuProcurementUseCRISummariseCRIbyCountry})
        Me.mnuProcurementUseCRI.Name = "mnuProcurementUseCRI"
        Me.mnuProcurementUseCRI.Size = New System.Drawing.Size(327, 34)
        Me.mnuProcurementUseCRI.Text = "Corruption Risk Index (CRI)"
        '
        'mnuProcurementCTFVCalculateCRI
        '
        Me.mnuProcurementCTFVCalculateCRI.Name = "mnuProcurementCTFVCalculateCRI"
        Me.mnuProcurementCTFVCalculateCRI.Size = New System.Drawing.Size(418, 34)
        Me.mnuProcurementCTFVCalculateCRI.Text = "Define Corruption Risk Index (CRI)..."
        '
        'mnuProcurementUseCRISummariseCRIbyCountry
        '
        Me.mnuProcurementUseCRISummariseCRIbyCountry.Name = "mnuProcurementUseCRISummariseCRIbyCountry"
        Me.mnuProcurementUseCRISummariseCRIbyCountry.Size = New System.Drawing.Size(418, 34)
        Me.mnuProcurementUseCRISummariseCRIbyCountry.Text = "Summarise CRI by Country (or other)..."
        '
        'mnuOptionsByContext
        '
        Me.mnuOptionsByContext.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextCheckData, Me.mnuOptionsByContextDefine, Me.mnuOptionsByContextPrepare, Me.mnuOptionsByContextDescribe, Me.mnuOptionsByContextModel, Me.mnuOptionsByContextCropModel})
        Me.mnuOptionsByContext.Name = "mnuOptionsByContext"
        Me.mnuOptionsByContext.Size = New System.Drawing.Size(124, 29)
        Me.mnuOptionsByContext.Text = "Experiments"
        '
        'mnuOptionsByContextCheckData
        '
        Me.mnuOptionsByContextCheckData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextCheckDataDuplicateRows, Me.mnuOptionsByContextCheckDataCompareColumns, Me.ToolStripSeparator47, Me.mnuOptionsByContextCheckDataOneVariableSummarise, Me.mnuOptionsByContextCheckDataOneVariableGraph, Me.mnuOptionsByContextCheckDataOneVariableFrequencies})
        Me.mnuOptionsByContextCheckData.Name = "mnuOptionsByContextCheckData"
        Me.mnuOptionsByContextCheckData.Size = New System.Drawing.Size(209, 34)
        Me.mnuOptionsByContextCheckData.Text = "Check Data"
        '
        'mnuOptionsByContextCheckDataDuplicateRows
        '
        Me.mnuOptionsByContextCheckDataDuplicateRows.Name = "mnuOptionsByContextCheckDataDuplicateRows"
        Me.mnuOptionsByContextCheckDataDuplicateRows.Size = New System.Drawing.Size(324, 34)
        Me.mnuOptionsByContextCheckDataDuplicateRows.Text = "Duplicate Rows..."
        '
        'mnuOptionsByContextCheckDataCompareColumns
        '
        Me.mnuOptionsByContextCheckDataCompareColumns.Name = "mnuOptionsByContextCheckDataCompareColumns"
        Me.mnuOptionsByContextCheckDataCompareColumns.Size = New System.Drawing.Size(324, 34)
        Me.mnuOptionsByContextCheckDataCompareColumns.Text = "Compare Columns..."
        '
        'ToolStripSeparator47
        '
        Me.ToolStripSeparator47.Name = "ToolStripSeparator47"
        Me.ToolStripSeparator47.Size = New System.Drawing.Size(321, 6)
        '
        'mnuOptionsByContextCheckDataOneVariableSummarise
        '
        Me.mnuOptionsByContextCheckDataOneVariableSummarise.Name = "mnuOptionsByContextCheckDataOneVariableSummarise"
        Me.mnuOptionsByContextCheckDataOneVariableSummarise.Size = New System.Drawing.Size(324, 34)
        Me.mnuOptionsByContextCheckDataOneVariableSummarise.Text = "One Variable Summarise..."
        '
        'mnuOptionsByContextCheckDataOneVariableGraph
        '
        Me.mnuOptionsByContextCheckDataOneVariableGraph.Name = "mnuOptionsByContextCheckDataOneVariableGraph"
        Me.mnuOptionsByContextCheckDataOneVariableGraph.Size = New System.Drawing.Size(324, 34)
        Me.mnuOptionsByContextCheckDataOneVariableGraph.Text = "One Variable Graph..."
        '
        'mnuOptionsByContextCheckDataOneVariableFrequencies
        '
        Me.mnuOptionsByContextCheckDataOneVariableFrequencies.Name = "mnuOptionsByContextCheckDataOneVariableFrequencies"
        Me.mnuOptionsByContextCheckDataOneVariableFrequencies.Size = New System.Drawing.Size(324, 34)
        Me.mnuOptionsByContextCheckDataOneVariableFrequencies.Text = "One Variable Frequencies..."
        '
        'mnuOptionsByContextDefine
        '
        Me.mnuOptionsByContextDefine.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextDefineOnStation, Me.mnuOptionsByContextDefineOnFarm})
        Me.mnuOptionsByContextDefine.Name = "mnuOptionsByContextDefine"
        Me.mnuOptionsByContextDefine.Size = New System.Drawing.Size(209, 34)
        Me.mnuOptionsByContextDefine.Text = "Define"
        '
        'mnuOptionsByContextDefineOnStation
        '
        Me.mnuOptionsByContextDefineOnStation.Name = "mnuOptionsByContextDefineOnStation"
        Me.mnuOptionsByContextDefineOnStation.Size = New System.Drawing.Size(222, 34)
        Me.mnuOptionsByContextDefineOnStation.Text = "On - Station..."
        '
        'mnuOptionsByContextDefineOnFarm
        '
        Me.mnuOptionsByContextDefineOnFarm.Name = "mnuOptionsByContextDefineOnFarm"
        Me.mnuOptionsByContextDefineOnFarm.Size = New System.Drawing.Size(222, 34)
        Me.mnuOptionsByContextDefineOnFarm.Text = "On - Farm..."
        '
        'mnuOptionsByContextPrepare
        '
        Me.mnuOptionsByContextPrepare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions, Me.ToolStripSeparator48, Me.mnuOptionsByContextMergeAdditionalData, Me.mnuOptionsByContextPrepareStack, Me.mnuOptionsByContextPrepareUnstack})
        Me.mnuOptionsByContextPrepare.Name = "mnuOptionsByContextPrepare"
        Me.mnuOptionsByContextPrepare.Size = New System.Drawing.Size(209, 34)
        Me.mnuOptionsByContextPrepare.Text = "Prepare"
        '
        'mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions
        '
        Me.mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions.Name = "mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions"
        Me.mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions.Size = New System.Drawing.Size(421, 34)
        Me.mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions.Text = "Calculate Difference Between Options..."
        '
        'ToolStripSeparator48
        '
        Me.ToolStripSeparator48.Name = "ToolStripSeparator48"
        Me.ToolStripSeparator48.Size = New System.Drawing.Size(418, 6)
        '
        'mnuOptionsByContextMergeAdditionalData
        '
        Me.mnuOptionsByContextMergeAdditionalData.Name = "mnuOptionsByContextMergeAdditionalData"
        Me.mnuOptionsByContextMergeAdditionalData.Size = New System.Drawing.Size(421, 34)
        Me.mnuOptionsByContextMergeAdditionalData.Text = "Merge Additional Data..."
        '
        'mnuOptionsByContextPrepareStack
        '
        Me.mnuOptionsByContextPrepareStack.Name = "mnuOptionsByContextPrepareStack"
        Me.mnuOptionsByContextPrepareStack.Size = New System.Drawing.Size(421, 34)
        Me.mnuOptionsByContextPrepareStack.Text = "Stack (Pivot Longer)..."
        '
        'mnuOptionsByContextPrepareUnstack
        '
        Me.mnuOptionsByContextPrepareUnstack.Name = "mnuOptionsByContextPrepareUnstack"
        Me.mnuOptionsByContextPrepareUnstack.Size = New System.Drawing.Size(421, 34)
        Me.mnuOptionsByContextPrepareUnstack.Text = "Unstack (Pivot Wider)..."
        '
        'mnuOptionsByContextDescribe
        '
        Me.mnuOptionsByContextDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextDescribeCompareTwoTreatments, Me.mnuOptionsByContextDescribeCompareMultipleTreatments, Me.mnuOptionsByContextDescribeBoxplot})
        Me.mnuOptionsByContextDescribe.Name = "mnuOptionsByContextDescribe"
        Me.mnuOptionsByContextDescribe.Size = New System.Drawing.Size(209, 34)
        Me.mnuOptionsByContextDescribe.Text = "Describe"
        '
        'mnuOptionsByContextDescribeCompareTwoTreatments
        '
        Me.mnuOptionsByContextDescribeCompareTwoTreatments.Name = "mnuOptionsByContextDescribeCompareTwoTreatments"
        Me.mnuOptionsByContextDescribeCompareTwoTreatments.Size = New System.Drawing.Size(337, 34)
        Me.mnuOptionsByContextDescribeCompareTwoTreatments.Text = "Compare Two Options..."
        '
        'mnuOptionsByContextDescribeCompareMultipleTreatments
        '
        Me.mnuOptionsByContextDescribeCompareMultipleTreatments.Enabled = False
        Me.mnuOptionsByContextDescribeCompareMultipleTreatments.Name = "mnuOptionsByContextDescribeCompareMultipleTreatments"
        Me.mnuOptionsByContextDescribeCompareMultipleTreatments.Size = New System.Drawing.Size(337, 34)
        Me.mnuOptionsByContextDescribeCompareMultipleTreatments.Text = "Compare Multiple Options..."
        '
        'mnuOptionsByContextDescribeBoxplot
        '
        Me.mnuOptionsByContextDescribeBoxplot.Name = "mnuOptionsByContextDescribeBoxplot"
        Me.mnuOptionsByContextDescribeBoxplot.Size = New System.Drawing.Size(337, 34)
        Me.mnuOptionsByContextDescribeBoxplot.Text = "Boxplot..."
        '
        'mnuOptionsByContextModel
        '
        Me.mnuOptionsByContextModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextModelFitModel, Me.mnuOptionsByContextGeneralFitModel})
        Me.mnuOptionsByContextModel.Name = "mnuOptionsByContextModel"
        Me.mnuOptionsByContextModel.Size = New System.Drawing.Size(209, 34)
        Me.mnuOptionsByContextModel.Text = "Model"
        '
        'mnuOptionsByContextModelFitModel
        '
        Me.mnuOptionsByContextModelFitModel.Name = "mnuOptionsByContextModelFitModel"
        Me.mnuOptionsByContextModelFitModel.Size = New System.Drawing.Size(265, 34)
        Me.mnuOptionsByContextModelFitModel.Text = "Fit Model..."
        '
        'mnuOptionsByContextGeneralFitModel
        '
        Me.mnuOptionsByContextGeneralFitModel.Name = "mnuOptionsByContextGeneralFitModel"
        Me.mnuOptionsByContextGeneralFitModel.Size = New System.Drawing.Size(265, 34)
        Me.mnuOptionsByContextGeneralFitModel.Text = "General Fit Model..."
        '
        'mnuOptionsByContextCropModel
        '
        Me.mnuOptionsByContextCropModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsByContextCropModelApsimxExamples})
        Me.mnuOptionsByContextCropModel.Name = "mnuOptionsByContextCropModel"
        Me.mnuOptionsByContextCropModel.Size = New System.Drawing.Size(209, 34)
        Me.mnuOptionsByContextCropModel.Text = "Crop Model"
        '
        'mnuOptionsByContextCropModelApsimxExamples
        '
        Me.mnuOptionsByContextCropModelApsimxExamples.Name = "mnuOptionsByContextCropModelApsimxExamples"
        Me.mnuOptionsByContextCropModelApsimxExamples.Size = New System.Drawing.Size(264, 34)
        Me.mnuOptionsByContextCropModelApsimxExamples.Text = "Apsimx Examples..."
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuToolsRunRCode, Me.mnuToolsRestartR, Me.mnuToolsCheckForUpdates, Me.mnuToolsClearOutputWindow, Me.ToolStripSeparator5, Me.mnuToolsSaveCurrentOptions, Me.mnuToolsLoadOptions, Me.mnuToolsInstallRPackage, Me.mnuToolsOptions})
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(69, 29)
        Me.mnuTools.Text = "Tools"
        '
        'mnuToolsRunRCode
        '
        Me.mnuToolsRunRCode.Enabled = False
        Me.mnuToolsRunRCode.Name = "mnuToolsRunRCode"
        Me.mnuToolsRunRCode.Size = New System.Drawing.Size(298, 34)
        Me.mnuToolsRunRCode.Tag = "Run_R_Code..."
        Me.mnuToolsRunRCode.Text = "Run R Code..."
        '
        'mnuToolsRestartR
        '
        Me.mnuToolsRestartR.Enabled = False
        Me.mnuToolsRestartR.Name = "mnuToolsRestartR"
        Me.mnuToolsRestartR.Size = New System.Drawing.Size(298, 34)
        Me.mnuToolsRestartR.Tag = "Restart_R"
        Me.mnuToolsRestartR.Text = "Restart R"
        '
        'mnuToolsCheckForUpdates
        '
        Me.mnuToolsCheckForUpdates.Name = "mnuToolsCheckForUpdates"
        Me.mnuToolsCheckForUpdates.Size = New System.Drawing.Size(298, 34)
        Me.mnuToolsCheckForUpdates.Tag = "Check_for_Updates..."
        Me.mnuToolsCheckForUpdates.Text = "Check for Updates..."
        '
        'mnuToolsClearOutputWindow
        '
        Me.mnuToolsClearOutputWindow.Name = "mnuToolsClearOutputWindow"
        Me.mnuToolsClearOutputWindow.Size = New System.Drawing.Size(298, 34)
        Me.mnuToolsClearOutputWindow.Tag = "Clear_Output_Window..."
        Me.mnuToolsClearOutputWindow.Text = "Clear Output Window..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(295, 6)
        '
        'mnuToolsSaveCurrentOptions
        '
        Me.mnuToolsSaveCurrentOptions.Enabled = False
        Me.mnuToolsSaveCurrentOptions.Name = "mnuToolsSaveCurrentOptions"
        Me.mnuToolsSaveCurrentOptions.Size = New System.Drawing.Size(298, 34)
        Me.mnuToolsSaveCurrentOptions.Tag = "Save_Current_Options..."
        Me.mnuToolsSaveCurrentOptions.Text = "Save Current Options..."
        '
        'mnuToolsLoadOptions
        '
        Me.mnuToolsLoadOptions.Enabled = False
        Me.mnuToolsLoadOptions.Name = "mnuToolsLoadOptions"
        Me.mnuToolsLoadOptions.Size = New System.Drawing.Size(298, 34)
        Me.mnuToolsLoadOptions.Tag = "Load_Options..."
        Me.mnuToolsLoadOptions.Text = "Load Options..."
        '
        'mnuToolsInstallRPackage
        '
        Me.mnuToolsInstallRPackage.Name = "mnuToolsInstallRPackage"
        Me.mnuToolsInstallRPackage.Size = New System.Drawing.Size(298, 34)
        Me.mnuToolsInstallRPackage.Text = "Install R Package..."
        '
        'mnuToolsOptions
        '
        Me.mnuToolsOptions.Name = "mnuToolsOptions"
        Me.mnuToolsOptions.Size = New System.Drawing.Size(298, 34)
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
        Me.splOverall.Location = New System.Drawing.Point(0, 72)
        Me.splOverall.Margin = New System.Windows.Forms.Padding(4)
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
        Me.splOverall.Size = New System.Drawing.Size(1251, 619)
        Me.splOverall.SplitterDistance = 257
        Me.splOverall.SplitterWidth = 8
        Me.splOverall.TabIndex = 10
        '
        'splExtraWindows
        '
        Me.splExtraWindows.BackColor = System.Drawing.Color.LightGray
        Me.splExtraWindows.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splExtraWindows.Location = New System.Drawing.Point(0, 0)
        Me.splExtraWindows.Margin = New System.Windows.Forms.Padding(4)
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
        Me.splExtraWindows.Panel2.Controls.Add(Me.ucrScriptWindow)
        Me.splExtraWindows.Size = New System.Drawing.Size(1251, 257)
        Me.splExtraWindows.SplitterDistance = 381
        Me.splExtraWindows.SplitterWidth = 8
        Me.splExtraWindows.TabIndex = 0
        '
        'splMetadata
        '
        Me.splMetadata.BackColor = System.Drawing.Color.LightGray
        Me.splMetadata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splMetadata.Location = New System.Drawing.Point(0, 0)
        Me.splMetadata.Margin = New System.Windows.Forms.Padding(4)
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
        Me.splMetadata.Size = New System.Drawing.Size(381, 257)
        Me.splMetadata.SplitterDistance = 105
        Me.splMetadata.SplitterWidth = 8
        Me.splMetadata.TabIndex = 0
        '
        'ucrColumnMeta
        '
        Me.ucrColumnMeta.AutoSize = True
        Me.ucrColumnMeta.BackColor = System.Drawing.SystemColors.Control
        Me.ucrColumnMeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrColumnMeta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrColumnMeta.Location = New System.Drawing.Point(0, 0)
        Me.ucrColumnMeta.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrColumnMeta.Name = "ucrColumnMeta"
        Me.ucrColumnMeta.Size = New System.Drawing.Size(105, 257)
        Me.ucrColumnMeta.TabIndex = 0
        '
        'ucrDataFrameMeta
        '
        Me.ucrDataFrameMeta.AutoSize = True
        Me.ucrDataFrameMeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrDataFrameMeta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrDataFrameMeta.Location = New System.Drawing.Point(0, 0)
        Me.ucrDataFrameMeta.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDataFrameMeta.Name = "ucrDataFrameMeta"
        Me.ucrDataFrameMeta.Size = New System.Drawing.Size(268, 257)
        Me.ucrDataFrameMeta.TabIndex = 0
        '
        'ucrScriptWindow
        '
        Me.ucrScriptWindow.AutoSize = True
        Me.ucrScriptWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrScriptWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrScriptWindow.Location = New System.Drawing.Point(0, 0)
        Me.ucrScriptWindow.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrScriptWindow.Name = "ucrScriptWindow"
        Me.ucrScriptWindow.Size = New System.Drawing.Size(862, 257)
        Me.ucrScriptWindow.strActiveTabText = ""
        Me.ucrScriptWindow.TabIndex = 2
        Me.ucrScriptWindow.Tag = "Script_Window"
        '
        'splDataOutput
        '
        Me.splDataOutput.BackColor = System.Drawing.Color.LightGray
        Me.splDataOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splDataOutput.Location = New System.Drawing.Point(0, 0)
        Me.splDataOutput.Margin = New System.Windows.Forms.Padding(4)
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
        Me.splDataOutput.Size = New System.Drawing.Size(1251, 354)
        Me.splDataOutput.SplitterDistance = 576
        Me.splDataOutput.SplitterWidth = 8
        Me.splDataOutput.TabIndex = 0
        '
        'ucrDataViewer
        '
        Me.ucrDataViewer.AutoSize = True
        Me.ucrDataViewer.BackColor = System.Drawing.SystemColors.Control
        Me.ucrDataViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrDataViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrDataViewer.Location = New System.Drawing.Point(0, 0)
        Me.ucrDataViewer.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrDataViewer.Name = "ucrDataViewer"
        Me.ucrDataViewer.Size = New System.Drawing.Size(576, 354)
        Me.ucrDataViewer.TabIndex = 0
        Me.ucrDataViewer.Tag = "Data_View"
        '
        'ucrOutput
        '
        Me.ucrOutput.AutoSize = True
        Me.ucrOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrOutput.Location = New System.Drawing.Point(0, 0)
        Me.ucrOutput.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrOutput.Name = "ucrOutput"
        Me.ucrOutput.Size = New System.Drawing.Size(667, 354)
        Me.ucrOutput.TabIndex = 0
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1251, 723)
        Me.Controls.Add(Me.splOverall)
        Me.Controls.Add(Me.stsStrip)
        Me.Controls.Add(Me.Tool_strip)
        Me.Controls.Add(Me.mnuBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuBar
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "R-Instat " + My.Application.Info.Version.Major.ToString + "." +
                My.Application.Info.Version.Minor.ToString + "." +
                My.Application.Info.Version.Build.ToString
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
        Me.splExtraWindows.Panel2.PerformLayout()
        CType(Me.splExtraWindows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splExtraWindows.ResumeLayout(False)
        Me.splMetadata.Panel1.ResumeLayout(False)
        Me.splMetadata.Panel1.PerformLayout()
        Me.splMetadata.Panel2.ResumeLayout(False)
        Me.splMetadata.Panel2.PerformLayout()
        CType(Me.splMetadata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splMetadata.ResumeLayout(False)
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
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents mnuEditSelectAll As ToolStripMenuItem
    Friend WithEvents mnuEditFind As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents stsStrip As StatusStrip
    Friend WithEvents tstatus As ToolStripStatusLabel
    Private WithEvents Tool_strip As ToolStrip
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents separator1 As ToolStripSeparator
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
    Friend WithEvents mnuPrepareDataBook As ToolStripMenuItem
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
    Friend WithEvents mnuPrepareDataFrameFilterRows As ToolStripMenuItem
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
    Friend WithEvents mnuPrepareDataFrameRowNumbersNames As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuPrepareDataFrameReplaceValues As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
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
    Friend WithEvents mnuDescribeTwoThreeVariables As ToolStripMenuItem
    Friend WithEvents mnuDescribeTwoVariablesSummarise As ToolStripMenuItem
    Friend WithEvents mnuDescribeTwoVariablesTabulate As ToolStripMenuItem
    Friend WithEvents mnuDescribeTwoVariablesGraph As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificTablesGraphs As ToolStripMenuItem
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
    Friend WithEvents ToolStripSeparator22 As ToolStripSeparator
    Friend WithEvents mnuModelOtherOneVariableGoodnessofFit As ToolStripMenuItem
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
    Friend WithEvents mnuHelpFAQ As ToolStripMenuItem
    Friend WithEvents mnuHelpGetingStarted As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator28 As ToolStripSeparator
    Friend WithEvents mnuHelpMenus As ToolStripMenuItem
    Friend WithEvents mnuHelpAboutR As ToolStripMenuItem
    Friend WithEvents mnuHelpRPackages As ToolStripMenuItem
    Friend WithEvents mnuHelpData As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator29 As ToolStripSeparator
    Friend WithEvents mnuClimaticFileExportToCPT As ToolStripMenuItem
    Friend WithEvents mnuClimateFileImportfromClimSoft As ToolStripMenuItem
    Friend WithEvents mnuClimaticFileImportfromCliData As ToolStripMenuItem
    Friend WithEvents mnuCimaticPrepareTransform As ToolStripMenuItem
    Friend WithEvents mnuClimaticCheckData As ToolStripMenuItem
    Friend WithEvents mnuClimaticDescribeRainfall As ToolStripMenuItem
    Friend WithEvents mnuClimaticDescribeTemperatures As ToolStripMenuItem
    Friend WithEvents mnuClimaticDescribeWindSpeedDirection As ToolStripMenuItem
    Friend WithEvents mnuClimaticPICSA As ToolStripMenuItem
    Friend WithEvents mnuClimaticPICSARainfallGraph As ToolStripMenuItem
    Friend WithEvents mnuClimaticPICSATemperatureGraph As ToolStripMenuItem
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
    Friend WithEvents mnuDescribeTwoThreeVariablesTwoWayFrequencies As ToolStripMenuItem
    Friend WithEvents mnuFileImportFromCSPRO As ToolStripMenuItem
    Friend WithEvents mnuFileImportFromDatabases As ToolStripMenuItem
    Friend WithEvents mnuClimaticFileImportandTidyNetCDF As ToolStripMenuItem
    Friend WithEvents mnuProcurementPrepareRecodeNumericIntoQuantiles As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator35 As ToolStripSeparator
    Friend WithEvents splOverall As SplitContainer
    Friend WithEvents splDataOutput As SplitContainer
    Friend WithEvents ucrDataViewer As ucrDataView
    Friend WithEvents ucrOutput As ucrOutputWindow
    Friend WithEvents splExtraWindows As SplitContainer
    Friend WithEvents splMetadata As SplitContainer
    Friend WithEvents ucrColumnMeta As ucrColumnMetadata
    Friend WithEvents mnuViewResetToDefaultLayout As ToolStripMenuItem
    Friend WithEvents ucrDataFrameMeta As ucrDataFrameMetadata
    Friend WithEvents mnuClimaticFileImportfromIRIDataLibrary As ToolStripMenuItem
    Friend WithEvents mnuDescribeOneVariableRatingData As ToolStripMenuItem
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
    Friend WithEvents mnuOptionsByContextPrepare As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextMergeAdditionalData As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextCheckData As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextDescribe As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextDescribeCompareTwoTreatments As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextDescribeCompareMultipleTreatments As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextCheckDataDuplicateRows As ToolStripMenuItem
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
    Friend WithEvents mnuClimaticPrepareLengthOfSeason As ToolStripMenuItem
    Friend WithEvents mnuClimaticFileImportandTidyShapefile As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineMerge As ToolStripMenuItem
    Friend WithEvents mnuClimaticCMSAFExporttoCMSAFRToolbox As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareConversions As ToolStripMenuItem
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
    Friend WithEvents mnuClimaticTidyandExamineDuplicateRows As ToolStripMenuItem
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
    Friend WithEvents mnuMetadata As ToolStripSplitButton
    Friend WithEvents mnuColumnMetadat As ToolStripMenuItem
    Friend WithEvents mnuDataFrameMetadat As ToolStripMenuItem
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
    Friend WithEvents mnuClimaticMappingMap As ToolStripMenuItem
    Friend WithEvents mnuClimaticMappingCheckStationLocations As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator70 As ToolStripSeparator
    Friend WithEvents mnuClimaticCheckDataCheckStationLocations As ToolStripMenuItem
    Friend WithEvents mnuClimaticFileImportfromClimateDataStore As ToolStripMenuItem
    Friend WithEvents mnuTbLan As ToolStripButton
    Friend WithEvents mnuLastGraph As ToolStripSplitButton
    Friend WithEvents mnuRViewer As ToolStripMenuItem
    Friend WithEvents mnuploty As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameSelectColumns As ToolStripMenuItem
    Friend WithEvents mnuClimaticFileExportToClimsoft As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataFrameDuplicateColumn As ToolStripMenuItem
    Friend WithEvents mnuPrepareDataReshapeScaleOrDistance As ToolStripMenuItem
    Friend WithEvents mnuDescribeOneVariableVisualiseData As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator72 As ToolStripSeparator
    Friend WithEvents mnuModelFitModelMachineLearning As ToolStripMenuItem
    Friend WithEvents mnuDescribeMultivariateClusterAnalysis As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextDefine As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextDefineOnStation As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextDefineOnFarm As ToolStripMenuItem
    Friend WithEvents mnuDescribeTwoThreeVariablesCorrelations As ToolStripMenuItem
    Friend WithEvents mnuDescribeTwoThreeVariablesThreeWayFrequencies As ToolStripMenuItem
    Friend WithEvents mnuDescribeTwoThreeVariablesPivotTable As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator36 As ToolStripSeparator
    Friend WithEvents mnuPrepareDataFrameAddMergeColumns As ToolStripMenuItem
    Friend WithEvents mnuPrepareCheckDataViewDeleteLabels As ToolStripMenuItem
    Friend WithEvents mnuTbLast10Dialogs As ToolStripSplitButton
    Friend WithEvents mnuPrepareDataReshapeRandomSplit As ToolStripMenuItem



    Friend WithEvents mnuClimaticPICSAGeneralGraph As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator73 As ToolStripSeparator
    Friend WithEvents mnuOptionsByContextCropModel As ToolStripMenuItem
    Friend WithEvents mnuOptionsByContextCropModelApsimxExamples As ToolStripMenuItem
    Friend WithEvents mnuFileImportFromRapidPro As ToolStripMenuItem
    Friend WithEvents mnuFileImportFromPostgres As ToolStripMenuItem
    Friend WithEvents mnuNormalViewer As ToolStripMenuItem
    Friend WithEvents mnuEditWordwrap As ToolStripMenuItem
    Friend WithEvents mnuPrepareColumnTextSearch As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificTables As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator26 As ToolStripSeparator
    Friend WithEvents mnuHelpLearningStatistics As ToolStripMenuItem
    Friend WithEvents mnuHelpGlossary As ToolStripMenuItem
    Friend WithEvents mnuHelpPackagesDocumentation As ToolStripMenuItem
    Friend WithEvents mnuDescribeUseTable As ToolStripMenuItem
    Friend WithEvents ucrScriptWindow As ucrScript
    Friend WithEvents mnuViewOutput As ToolStripMenuItem
    Friend WithEvents mnuViewLogScript As ToolStripMenuItem
    Friend WithEvents mnuTbSave As ToolStripSplitButton
    Friend WithEvents mnuTbLogScript As ToolStripSplitButton
    Friend WithEvents mnuLogScript As ToolStripMenuItem
    Friend WithEvents mnuSaveData As ToolStripMenuItem
    Friend WithEvents mnuSaveOutput As ToolStripMenuItem
    Friend WithEvents mnuSaveScript As ToolStripMenuItem
    Friend WithEvents mnuSaveLog As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator74 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator75 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator76 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator77 As ToolStripSeparator
    Friend WithEvents mnuExamineEditData As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineTransformText As ToolStripMenuItem
    Friend WithEvents mnuClimaticTidyandExamineSplitText As ToolStripMenuItem
    Friend WithEvents mnuExamineEditDataOneVariableSummarise As ToolStripMenuItem
    Friend WithEvents mnuExamineEditDataOneVariableGraph As ToolStripMenuItem
    Friend WithEvents mnuExamineEditDataOneVariableFrequencies As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator78 As ToolStripSeparator
    Friend WithEvents mnuExamineEditDataPivotTable As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator79 As ToolStripSeparator
    Friend WithEvents mnuExamineEditDataSetupForDataEditing As ToolStripMenuItem
    Friend WithEvents mnuExamineEditDataDailyDataEditing As ToolStripMenuItem
    Friend WithEvents mnuExamineEditDataCompareColumns As ToolStripMenuItem
    Friend WithEvents mnuStructuredSurvey As ToolStripMenuItem
    Friend WithEvents mnuDescribeGeneral As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator38 As ToolStripSeparator

    Friend WithEvents mnuTbOutput As ToolStripSplitButton
    Friend WithEvents mnuOutputWindow As ToolStripMenuItem
    Friend WithEvents mnuShowRCommand As ToolStripMenuItem
    Friend WithEvents mnuIncludeComments As ToolStripMenuItem

    Friend WithEvents mnuPrepareCheckDataPivotTable As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator50 As ToolStripSeparator
    Friend WithEvents mnuEditPasteNew As ToolStripMenuItem
End Class
