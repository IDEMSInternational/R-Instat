﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.mnuDescribeTwoVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeTwoVariablesSummarise = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeTwoVariablesTabulate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeTwoVariablesGraph = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuDescribeSpecificBarChartFromSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeGeneralColumnSummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescribeGeneralTabulation = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescribeGeneralGraphics = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeMultivariate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeMultivariateCorrelations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeMultivariateprincipalComponents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeMultivariateCanonicalCorrelations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeMoreGraphs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeOtherGraphicsDialogsWindRose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeOtherGraphicsDialogsCumulativeDistribution = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeOtherGraphicsDialogsInventoryPlot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeOtherGraphicsDialogsPopulationPyramid = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDescribeUseGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeCombineGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescribeThemes = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuViewCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewTileVertically = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewTileHorizontally = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.mnuClimatic = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticFileOpensst = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimateFileClimSoft = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticFileCliData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticFileExportToCPT = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCliDefineClimaticData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepare = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareDates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareDatesGenerateDates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareDatesMakeDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareDatesUseDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareInfillMissingDates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareDatesMakeTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareDatesUseTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCimaticPrepareTransform = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareClimaticSummaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareSpecificEvents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareEventsStartoftheRains = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareEventsSpells = New System.Windows.Forms.ToolStripMenuItem()
        Me.Extremes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareEventsWaterBalance = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareEventsEndoftheRains = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareNewWorksheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareImportDailyData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareMakeFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareShiftDailyData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareUnstackDailyData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPrepareStackDailyData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticQualityControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayDailyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QCProceduresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator30 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimdex = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDescribe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDescribeRainfall = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDescribeTemperatures = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDescribeWindSpeedDirection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDescribeSunshineRadiation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticDescribeGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator31 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClimaticMoreGraphs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDescribeMoreGraphsWindoRose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticDescribeMoreGraphsCummulaiveDistribution = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPICSA = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPICSARainfall = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPICSATemperature = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticPICSACrops = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuTbNew = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbOpen = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbSave = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbPrint = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbCut = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbCopy = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbPaste = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbDelete = New System.Windows.Forms.ToolStripButton()
        Me.separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditLastDialogueToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.mnuTbShowLast10 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.sepStart = New System.Windows.Forms.ToolStripSeparator()
        Me.sepEnd = New System.Windows.Forms.ToolStripSeparator()
        Me.separator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTbHelp = New System.Windows.Forms.ToolStripButton()
        Me.mnuBar = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNewDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpenFromFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpenFromLibrary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImportFromODK = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator27 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileConvert = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlSeparatorFile = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExport = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuPreparePrepareToShareJitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataExportOpenRefine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareCheckDataImportOpenRefine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCheckDataPrePareToShareSdcPackage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrepareColumnCalculate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrepareColumnCalculateCalculations = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuCorruption = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCorruptionFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCorruptionDefineCorruptionData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCorruptionPrepare = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCorruptionDescribe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCorruptionModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsRunRCode = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsRestartR = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsCheckForUpdates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsClearOutputWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuToolsSaveCurrentOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsLoadOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClimaticSCFSupportCumulativeExceedanceGraphs = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsStrip.SuspendLayout()
        Me.Tool_strip.SuspendLayout()
        Me.mnuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuDescribe
        '
        Me.mnuDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeOneVariable, Me.mnuDescribeTwoVariables, Me.mnuDescribeSpecific, Me.mnuDescribeGeneral, Me.ToolStripSeparator9, Me.mnuDescribeMultivariate, Me.mnuDescribeMoreGraphs, Me.ToolStripSeparator13, Me.mnuDescribeUseGraph, Me.mnuDescribeCombineGraph, Me.mnuDescribeThemes})
        Me.mnuDescribe.Name = "mnuDescribe"
        Me.mnuDescribe.Size = New System.Drawing.Size(64, 20)
        Me.mnuDescribe.Tag = "Describe"
        Me.mnuDescribe.Text = "Describe"
        '
        'mnuDescribeOneVariable
        '
        Me.mnuDescribeOneVariable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeOneVariableSummarise, Me.mnuDescribeOneVariableGraph})
        Me.mnuDescribeOneVariable.Name = "mnuDescribeOneVariable"
        Me.mnuDescribeOneVariable.Size = New System.Drawing.Size(172, 22)
        Me.mnuDescribeOneVariable.Tag = "One_Variable"
        Me.mnuDescribeOneVariable.Text = "One Variable"
        '
        'mnuDescribeOneVariableSummarise
        '
        Me.mnuDescribeOneVariableSummarise.Name = "mnuDescribeOneVariableSummarise"
        Me.mnuDescribeOneVariableSummarise.Size = New System.Drawing.Size(142, 22)
        Me.mnuDescribeOneVariableSummarise.Tag = "Summarise..."
        Me.mnuDescribeOneVariableSummarise.Text = "Summarise..."
        '
        'mnuDescribeOneVariableGraph
        '
        Me.mnuDescribeOneVariableGraph.Name = "mnuDescribeOneVariableGraph"
        Me.mnuDescribeOneVariableGraph.Size = New System.Drawing.Size(142, 22)
        Me.mnuDescribeOneVariableGraph.Tag = "Graph..."
        Me.mnuDescribeOneVariableGraph.Text = "Graph..."
        '
        'mnuDescribeTwoVariables
        '
        Me.mnuDescribeTwoVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeTwoVariablesSummarise, Me.mnuDescribeTwoVariablesTabulate, Me.mnuDescribeTwoVariablesGraph})
        Me.mnuDescribeTwoVariables.Name = "mnuDescribeTwoVariables"
        Me.mnuDescribeTwoVariables.Size = New System.Drawing.Size(172, 22)
        Me.mnuDescribeTwoVariables.Tag = "Two_Variables"
        Me.mnuDescribeTwoVariables.Text = "Two Variables"
        '
        'mnuDescribeTwoVariablesSummarise
        '
        Me.mnuDescribeTwoVariablesSummarise.Name = "mnuDescribeTwoVariablesSummarise"
        Me.mnuDescribeTwoVariablesSummarise.Size = New System.Drawing.Size(142, 22)
        Me.mnuDescribeTwoVariablesSummarise.Tag = "Summarise..."
        Me.mnuDescribeTwoVariablesSummarise.Text = "Summarise..."
        '
        'mnuDescribeTwoVariablesTabulate
        '
        Me.mnuDescribeTwoVariablesTabulate.Enabled = False
        Me.mnuDescribeTwoVariablesTabulate.Name = "mnuDescribeTwoVariablesTabulate"
        Me.mnuDescribeTwoVariablesTabulate.Size = New System.Drawing.Size(142, 22)
        Me.mnuDescribeTwoVariablesTabulate.Tag = "Tabulate..."
        Me.mnuDescribeTwoVariablesTabulate.Text = "Tabulate..."
        '
        'mnuDescribeTwoVariablesGraph
        '
        Me.mnuDescribeTwoVariablesGraph.Name = "mnuDescribeTwoVariablesGraph"
        Me.mnuDescribeTwoVariablesGraph.Size = New System.Drawing.Size(142, 22)
        Me.mnuDescribeTwoVariablesGraph.Tag = "Graph..."
        Me.mnuDescribeTwoVariablesGraph.Text = "Graph..."
        '
        'mnuDescribeSpecific
        '
        Me.mnuDescribeSpecific.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeSpecificFrequency, Me.mnuDescribeSpecificSummary, Me.mnuDescribeSpecificMultipleResponse, Me.ToolStripSeparator26, Me.mnuDescribeSpecificScatterPlot, Me.mnuDescribeSpecificLinePlot, Me.mnuDescribeSpecificHistogram, Me.mnuDescribeSpecificBoxplot, Me.mnuDescribeSpecificDotPlot, Me.mnuDescribeSpecificRugPlot, Me.mnuDescribeSpecificBarChart, Me.mnuDescribeSpecificBarChartFromSummary})
        Me.mnuDescribeSpecific.Name = "mnuDescribeSpecific"
        Me.mnuDescribeSpecific.Size = New System.Drawing.Size(172, 22)
        Me.mnuDescribeSpecific.Tag = "Table_Dialogs"
        Me.mnuDescribeSpecific.Text = "Specific"
        '
        'mnuDescribeSpecificFrequency
        '
        Me.mnuDescribeSpecificFrequency.Enabled = False
        Me.mnuDescribeSpecificFrequency.Name = "mnuDescribeSpecificFrequency"
        Me.mnuDescribeSpecificFrequency.Size = New System.Drawing.Size(217, 22)
        Me.mnuDescribeSpecificFrequency.Tag = "Frequency..."
        Me.mnuDescribeSpecificFrequency.Text = "Frequency..."
        '
        'mnuDescribeSpecificSummary
        '
        Me.mnuDescribeSpecificSummary.Enabled = False
        Me.mnuDescribeSpecificSummary.Name = "mnuDescribeSpecificSummary"
        Me.mnuDescribeSpecificSummary.Size = New System.Drawing.Size(217, 22)
        Me.mnuDescribeSpecificSummary.Tag = "Summary..."
        Me.mnuDescribeSpecificSummary.Text = "Summary..."
        '
        'mnuDescribeSpecificMultipleResponse
        '
        Me.mnuDescribeSpecificMultipleResponse.Enabled = False
        Me.mnuDescribeSpecificMultipleResponse.Name = "mnuDescribeSpecificMultipleResponse"
        Me.mnuDescribeSpecificMultipleResponse.Size = New System.Drawing.Size(217, 22)
        Me.mnuDescribeSpecificMultipleResponse.Tag = "Multiple_Response..."
        Me.mnuDescribeSpecificMultipleResponse.Text = "Multiple Response..."
        '
        'ToolStripSeparator26
        '
        Me.ToolStripSeparator26.Name = "ToolStripSeparator26"
        Me.ToolStripSeparator26.Size = New System.Drawing.Size(214, 6)
        '
        'mnuDescribeSpecificScatterPlot
        '
        Me.mnuDescribeSpecificScatterPlot.Name = "mnuDescribeSpecificScatterPlot"
        Me.mnuDescribeSpecificScatterPlot.Size = New System.Drawing.Size(217, 22)
        Me.mnuDescribeSpecificScatterPlot.Tag = "Scatter_Plot..."
        Me.mnuDescribeSpecificScatterPlot.Text = "Scatter Plot..."
        '
        'mnuDescribeSpecificLinePlot
        '
        Me.mnuDescribeSpecificLinePlot.Name = "mnuDescribeSpecificLinePlot"
        Me.mnuDescribeSpecificLinePlot.Size = New System.Drawing.Size(217, 22)
        Me.mnuDescribeSpecificLinePlot.Tag = "Line_Plot..."
        Me.mnuDescribeSpecificLinePlot.Text = "Line Plot..."
        '
        'mnuDescribeSpecificHistogram
        '
        Me.mnuDescribeSpecificHistogram.Name = "mnuDescribeSpecificHistogram"
        Me.mnuDescribeSpecificHistogram.Size = New System.Drawing.Size(217, 22)
        Me.mnuDescribeSpecificHistogram.Tag = "Histogram..."
        Me.mnuDescribeSpecificHistogram.Text = "Histogram..."
        '
        'mnuDescribeSpecificBoxplot
        '
        Me.mnuDescribeSpecificBoxplot.Name = "mnuDescribeSpecificBoxplot"
        Me.mnuDescribeSpecificBoxplot.Size = New System.Drawing.Size(217, 22)
        Me.mnuDescribeSpecificBoxplot.Tag = "Boxplot..."
        Me.mnuDescribeSpecificBoxplot.Text = "Boxplot..."
        '
        'mnuDescribeSpecificDotPlot
        '
        Me.mnuDescribeSpecificDotPlot.Name = "mnuDescribeSpecificDotPlot"
        Me.mnuDescribeSpecificDotPlot.Size = New System.Drawing.Size(217, 22)
        Me.mnuDescribeSpecificDotPlot.Tag = "Dotplot..."
        Me.mnuDescribeSpecificDotPlot.Text = "Dot Plot..."
        '
        'mnuDescribeSpecificRugPlot
        '
        Me.mnuDescribeSpecificRugPlot.Name = "mnuDescribeSpecificRugPlot"
        Me.mnuDescribeSpecificRugPlot.Size = New System.Drawing.Size(217, 22)
        Me.mnuDescribeSpecificRugPlot.Text = "Rug Plot..."
        '
        'mnuDescribeSpecificBarChart
        '
        Me.mnuDescribeSpecificBarChart.Name = "mnuDescribeSpecificBarChart"
        Me.mnuDescribeSpecificBarChart.Size = New System.Drawing.Size(217, 22)
        Me.mnuDescribeSpecificBarChart.Tag = "Bar_Chart"
        Me.mnuDescribeSpecificBarChart.Text = "Bar Chart..."
        '
        'mnuDescribeSpecificBarChartFromSummary
        '
        Me.mnuDescribeSpecificBarChartFromSummary.Name = "mnuDescribeSpecificBarChartFromSummary"
        Me.mnuDescribeSpecificBarChartFromSummary.Size = New System.Drawing.Size(217, 22)
        Me.mnuDescribeSpecificBarChartFromSummary.Tag = "Bar_Chart_From_Summary..."
        Me.mnuDescribeSpecificBarChartFromSummary.Text = "Bar Chart From Summary..."
        '
        'mnuDescribeGeneral
        '
        Me.mnuDescribeGeneral.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeGeneralColumnSummaries, Me.DescribeGeneralTabulation, Me.DescribeGeneralGraphics})
        Me.mnuDescribeGeneral.Name = "mnuDescribeGeneral"
        Me.mnuDescribeGeneral.Size = New System.Drawing.Size(172, 22)
        Me.mnuDescribeGeneral.Tag = "General"
        Me.mnuDescribeGeneral.Text = "General..."
        '
        'mnuDescribeGeneralColumnSummaries
        '
        Me.mnuDescribeGeneralColumnSummaries.Name = "mnuDescribeGeneralColumnSummaries"
        Me.mnuDescribeGeneralColumnSummaries.Size = New System.Drawing.Size(188, 22)
        Me.mnuDescribeGeneralColumnSummaries.Tag = "Column_Summaries..."
        Me.mnuDescribeGeneralColumnSummaries.Text = "Column Summaries..."
        '
        'DescribeGeneralTabulation
        '
        Me.DescribeGeneralTabulation.Enabled = False
        Me.DescribeGeneralTabulation.Name = "DescribeGeneralTabulation"
        Me.DescribeGeneralTabulation.Size = New System.Drawing.Size(188, 22)
        Me.DescribeGeneralTabulation.Tag = "Tabulation..."
        Me.DescribeGeneralTabulation.Text = "Tabulation..."
        '
        'DescribeGeneralGraphics
        '
        Me.DescribeGeneralGraphics.Name = "DescribeGeneralGraphics"
        Me.DescribeGeneralGraphics.Size = New System.Drawing.Size(188, 22)
        Me.DescribeGeneralGraphics.Tag = "Graphics..."
        Me.DescribeGeneralGraphics.Text = "Graphics..."
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(169, 6)
        '
        'mnuDescribeMultivariate
        '
        Me.mnuDescribeMultivariate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeMultivariateCorrelations, Me.mnuDescribeMultivariateprincipalComponents, Me.mnuDescribeMultivariateCanonicalCorrelations})
        Me.mnuDescribeMultivariate.Name = "mnuDescribeMultivariate"
        Me.mnuDescribeMultivariate.Size = New System.Drawing.Size(172, 22)
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
        'mnuDescribeMoreGraphs
        '
        Me.mnuDescribeMoreGraphs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDescribeOtherGraphicsDialogsWindRose, Me.mnuDescribeOtherGraphicsDialogsCumulativeDistribution, Me.mnuDescribeOtherGraphicsDialogsInventoryPlot, Me.mnuDescribeOtherGraphicsDialogsPopulationPyramid})
        Me.mnuDescribeMoreGraphs.Name = "mnuDescribeMoreGraphs"
        Me.mnuDescribeMoreGraphs.Size = New System.Drawing.Size(172, 22)
        Me.mnuDescribeMoreGraphs.Text = "Graphs"
        '
        'mnuDescribeOtherGraphicsDialogsWindRose
        '
        Me.mnuDescribeOtherGraphicsDialogsWindRose.Name = "mnuDescribeOtherGraphicsDialogsWindRose"
        Me.mnuDescribeOtherGraphicsDialogsWindRose.Size = New System.Drawing.Size(209, 22)
        Me.mnuDescribeOtherGraphicsDialogsWindRose.Tag = "WindRose..."
        Me.mnuDescribeOtherGraphicsDialogsWindRose.Text = "Wind Rose..."
        '
        'mnuDescribeOtherGraphicsDialogsCumulativeDistribution
        '
        Me.mnuDescribeOtherGraphicsDialogsCumulativeDistribution.Name = "mnuDescribeOtherGraphicsDialogsCumulativeDistribution"
        Me.mnuDescribeOtherGraphicsDialogsCumulativeDistribution.Size = New System.Drawing.Size(209, 22)
        Me.mnuDescribeOtherGraphicsDialogsCumulativeDistribution.Tag = "Cumulative_Distribution..."
        Me.mnuDescribeOtherGraphicsDialogsCumulativeDistribution.Text = "Cumulative Distribution..."
        '
        'mnuDescribeOtherGraphicsDialogsInventoryPlot
        '
        Me.mnuDescribeOtherGraphicsDialogsInventoryPlot.Enabled = False
        Me.mnuDescribeOtherGraphicsDialogsInventoryPlot.Name = "mnuDescribeOtherGraphicsDialogsInventoryPlot"
        Me.mnuDescribeOtherGraphicsDialogsInventoryPlot.Size = New System.Drawing.Size(209, 22)
        Me.mnuDescribeOtherGraphicsDialogsInventoryPlot.Tag = "Inventory_Plot..."
        Me.mnuDescribeOtherGraphicsDialogsInventoryPlot.Text = "Inventory Plot..."
        '
        'mnuDescribeOtherGraphicsDialogsPopulationPyramid
        '
        Me.mnuDescribeOtherGraphicsDialogsPopulationPyramid.Enabled = False
        Me.mnuDescribeOtherGraphicsDialogsPopulationPyramid.Name = "mnuDescribeOtherGraphicsDialogsPopulationPyramid"
        Me.mnuDescribeOtherGraphicsDialogsPopulationPyramid.Size = New System.Drawing.Size(209, 22)
        Me.mnuDescribeOtherGraphicsDialogsPopulationPyramid.Tag = "Population_Pyramid..."
        Me.mnuDescribeOtherGraphicsDialogsPopulationPyramid.Text = "Population Pyramid..."
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(169, 6)
        '
        'mnuDescribeUseGraph
        '
        Me.mnuDescribeUseGraph.Name = "mnuDescribeUseGraph"
        Me.mnuDescribeUseGraph.Size = New System.Drawing.Size(172, 22)
        Me.mnuDescribeUseGraph.Text = "Use Graph..."
        '
        'mnuDescribeCombineGraph
        '
        Me.mnuDescribeCombineGraph.Name = "mnuDescribeCombineGraph"
        Me.mnuDescribeCombineGraph.Size = New System.Drawing.Size(172, 22)
        Me.mnuDescribeCombineGraph.Text = "Combine Graphs..."
        '
        'mnuDescribeThemes
        '
        Me.mnuDescribeThemes.Enabled = False
        Me.mnuDescribeThemes.Name = "mnuDescribeThemes"
        Me.mnuDescribeThemes.Size = New System.Drawing.Size(172, 22)
        Me.mnuDescribeThemes.Text = "Themes..."
        '
        'mnuModel
        '
        Me.mnuModel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelProbabilityDistributions, Me.ToolStripSeparator3, Me.mnuModelOneVariable, Me.mnuModelTwoVariables, Me.mnuModelThreeVariables, Me.mnuModelFourVariables, Me.mnuModelGeneral, Me.ToolStripSeparator4, Me.mnuModelOtherOneVariable, Me.mnuModelOtherTwoVariables, Me.mnuModelOtherThreeVariables, Me.mnuModelOtherGeneral})
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
        Me.mnuModelProbabilityDistributionsShowModel.Size = New System.Drawing.Size(242, 22)
        Me.mnuModelProbabilityDistributionsShowModel.Text = "Show Model..."
        '
        'mnuModelProbabilityDistributionsCompareModels
        '
        Me.mnuModelProbabilityDistributionsCompareModels.Enabled = False
        Me.mnuModelProbabilityDistributionsCompareModels.Name = "mnuModelProbabilityDistributionsCompareModels"
        Me.mnuModelProbabilityDistributionsCompareModels.Size = New System.Drawing.Size(242, 22)
        Me.mnuModelProbabilityDistributionsCompareModels.Tag = "Show_Models..."
        Me.mnuModelProbabilityDistributionsCompareModels.Text = "Compare Models..."
        '
        'mnuModelProbabilityDistributionsRandomSamplesUseModel
        '
        Me.mnuModelProbabilityDistributionsRandomSamplesUseModel.Name = "mnuModelProbabilityDistributionsRandomSamplesUseModel"
        Me.mnuModelProbabilityDistributionsRandomSamplesUseModel.Size = New System.Drawing.Size(242, 22)
        Me.mnuModelProbabilityDistributionsRandomSamplesUseModel.Tag = "RandomSamples_(Use_Model)..."
        Me.mnuModelProbabilityDistributionsRandomSamplesUseModel.Text = "Random Samples (Use Model)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(198, 6)
        '
        'mnuModelOneVariable
        '
        Me.mnuModelOneVariable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelOneVariableFitModel, Me.mnuModelOneVariableCompareModels, Me.mnuModelOneVariableUseModel})
        Me.mnuModelOneVariable.Name = "mnuModelOneVariable"
        Me.mnuModelOneVariable.Size = New System.Drawing.Size(201, 22)
        Me.mnuModelOneVariable.Tag = "One_Variable"
        Me.mnuModelOneVariable.Text = "One Variable"
        '
        'mnuModelOneVariableFitModel
        '
        Me.mnuModelOneVariableFitModel.Name = "mnuModelOneVariableFitModel"
        Me.mnuModelOneVariableFitModel.Size = New System.Drawing.Size(174, 22)
        Me.mnuModelOneVariableFitModel.Tag = "Fit_Model..."
        Me.mnuModelOneVariableFitModel.Text = "Fit Model..."
        '
        'mnuModelOneVariableCompareModels
        '
        Me.mnuModelOneVariableCompareModels.Name = "mnuModelOneVariableCompareModels"
        Me.mnuModelOneVariableCompareModels.Size = New System.Drawing.Size(174, 22)
        Me.mnuModelOneVariableCompareModels.Tag = "Choose_Models..."
        Me.mnuModelOneVariableCompareModels.Text = "Compare Models..."
        '
        'mnuModelOneVariableUseModel
        '
        Me.mnuModelOneVariableUseModel.Name = "mnuModelOneVariableUseModel"
        Me.mnuModelOneVariableUseModel.Size = New System.Drawing.Size(174, 22)
        Me.mnuModelOneVariableUseModel.Tag = "Use_Model..."
        Me.mnuModelOneVariableUseModel.Text = "Use Model..."
        '
        'mnuModelTwoVariables
        '
        Me.mnuModelTwoVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelTwoVariablesFitModel, Me.mnuModelTwoVariablesChooseModel, Me.mnuModelTwoVariablesUseModel})
        Me.mnuModelTwoVariables.Name = "mnuModelTwoVariables"
        Me.mnuModelTwoVariables.Size = New System.Drawing.Size(201, 22)
        Me.mnuModelTwoVariables.Tag = "Two_Variables"
        Me.mnuModelTwoVariables.Text = "Two Variables"
        '
        'mnuModelTwoVariablesFitModel
        '
        Me.mnuModelTwoVariablesFitModel.Name = "mnuModelTwoVariablesFitModel"
        Me.mnuModelTwoVariablesFitModel.Size = New System.Drawing.Size(160, 22)
        Me.mnuModelTwoVariablesFitModel.Tag = "Fit_Model..."
        Me.mnuModelTwoVariablesFitModel.Text = "Fit Model..."
        '
        'mnuModelTwoVariablesChooseModel
        '
        Me.mnuModelTwoVariablesChooseModel.Enabled = False
        Me.mnuModelTwoVariablesChooseModel.Name = "mnuModelTwoVariablesChooseModel"
        Me.mnuModelTwoVariablesChooseModel.Size = New System.Drawing.Size(160, 22)
        Me.mnuModelTwoVariablesChooseModel.Tag = "Choose_Model..."
        Me.mnuModelTwoVariablesChooseModel.Text = "Choose Model..."
        '
        'mnuModelTwoVariablesUseModel
        '
        Me.mnuModelTwoVariablesUseModel.Name = "mnuModelTwoVariablesUseModel"
        Me.mnuModelTwoVariablesUseModel.Size = New System.Drawing.Size(160, 22)
        Me.mnuModelTwoVariablesUseModel.Tag = "Use_Model..."
        Me.mnuModelTwoVariablesUseModel.Text = "Use Model..."
        '
        'mnuModelThreeVariables
        '
        Me.mnuModelThreeVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelThreeVariablesFitModel, Me.mnuModelThreeVariablesChooseModel, Me.mnuModelThreeVariablesUseModel})
        Me.mnuModelThreeVariables.Name = "mnuModelThreeVariables"
        Me.mnuModelThreeVariables.Size = New System.Drawing.Size(201, 22)
        Me.mnuModelThreeVariables.Tag = "Three_Variables"
        Me.mnuModelThreeVariables.Text = "Three Variables"
        '
        'mnuModelThreeVariablesFitModel
        '
        Me.mnuModelThreeVariablesFitModel.Name = "mnuModelThreeVariablesFitModel"
        Me.mnuModelThreeVariablesFitModel.Size = New System.Drawing.Size(160, 22)
        Me.mnuModelThreeVariablesFitModel.Tag = "Fit_Model..."
        Me.mnuModelThreeVariablesFitModel.Text = "Fit Model..."
        '
        'mnuModelThreeVariablesChooseModel
        '
        Me.mnuModelThreeVariablesChooseModel.Enabled = False
        Me.mnuModelThreeVariablesChooseModel.Name = "mnuModelThreeVariablesChooseModel"
        Me.mnuModelThreeVariablesChooseModel.Size = New System.Drawing.Size(160, 22)
        Me.mnuModelThreeVariablesChooseModel.Tag = "Choose_Model..."
        Me.mnuModelThreeVariablesChooseModel.Text = "Choose Model..."
        '
        'mnuModelThreeVariablesUseModel
        '
        Me.mnuModelThreeVariablesUseModel.Enabled = False
        Me.mnuModelThreeVariablesUseModel.Name = "mnuModelThreeVariablesUseModel"
        Me.mnuModelThreeVariablesUseModel.Size = New System.Drawing.Size(160, 22)
        Me.mnuModelThreeVariablesUseModel.Tag = "Use_Model..."
        Me.mnuModelThreeVariablesUseModel.Text = "Use Model..."
        '
        'mnuModelFourVariables
        '
        Me.mnuModelFourVariables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelFourVariablesFitModel, Me.mnuModelFourVariablesChooseModel, Me.mnuModelFourVariablesUseModel})
        Me.mnuModelFourVariables.Name = "mnuModelFourVariables"
        Me.mnuModelFourVariables.Size = New System.Drawing.Size(201, 22)
        Me.mnuModelFourVariables.Tag = "Four_Variables"
        Me.mnuModelFourVariables.Text = "Four Variables"
        '
        'mnuModelFourVariablesFitModel
        '
        Me.mnuModelFourVariablesFitModel.Name = "mnuModelFourVariablesFitModel"
        Me.mnuModelFourVariablesFitModel.Size = New System.Drawing.Size(160, 22)
        Me.mnuModelFourVariablesFitModel.Tag = "Fit_Model..."
        Me.mnuModelFourVariablesFitModel.Text = "Fit Model..."
        '
        'mnuModelFourVariablesChooseModel
        '
        Me.mnuModelFourVariablesChooseModel.Enabled = False
        Me.mnuModelFourVariablesChooseModel.Name = "mnuModelFourVariablesChooseModel"
        Me.mnuModelFourVariablesChooseModel.Size = New System.Drawing.Size(160, 22)
        Me.mnuModelFourVariablesChooseModel.Tag = "Choose_Model..."
        Me.mnuModelFourVariablesChooseModel.Text = "Choose Model..."
        '
        'mnuModelFourVariablesUseModel
        '
        Me.mnuModelFourVariablesUseModel.Enabled = False
        Me.mnuModelFourVariablesUseModel.Name = "mnuModelFourVariablesUseModel"
        Me.mnuModelFourVariablesUseModel.Size = New System.Drawing.Size(160, 22)
        Me.mnuModelFourVariablesUseModel.Tag = "Use_Model..."
        Me.mnuModelFourVariablesUseModel.Text = "Use Model..."
        '
        'mnuModelGeneral
        '
        Me.mnuModelGeneral.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelGeneralFitModel, Me.mnuModelGeneralChooseModel, Me.mnuModelGeneralUseModel})
        Me.mnuModelGeneral.Name = "mnuModelGeneral"
        Me.mnuModelGeneral.Size = New System.Drawing.Size(201, 22)
        Me.mnuModelGeneral.Tag = "General"
        Me.mnuModelGeneral.Text = "General"
        '
        'mnuModelGeneralFitModel
        '
        Me.mnuModelGeneralFitModel.Name = "mnuModelGeneralFitModel"
        Me.mnuModelGeneralFitModel.Size = New System.Drawing.Size(160, 22)
        Me.mnuModelGeneralFitModel.Tag = "Fit_Model..."
        Me.mnuModelGeneralFitModel.Text = "Fit Model..."
        '
        'mnuModelGeneralChooseModel
        '
        Me.mnuModelGeneralChooseModel.Enabled = False
        Me.mnuModelGeneralChooseModel.Name = "mnuModelGeneralChooseModel"
        Me.mnuModelGeneralChooseModel.Size = New System.Drawing.Size(160, 22)
        Me.mnuModelGeneralChooseModel.Tag = "Choose_Model..."
        Me.mnuModelGeneralChooseModel.Text = "Choose Model..."
        '
        'mnuModelGeneralUseModel
        '
        Me.mnuModelGeneralUseModel.Enabled = False
        Me.mnuModelGeneralUseModel.Name = "mnuModelGeneralUseModel"
        Me.mnuModelGeneralUseModel.Size = New System.Drawing.Size(160, 22)
        Me.mnuModelGeneralUseModel.Tag = "Use_Model..."
        Me.mnuModelGeneralUseModel.Text = "Use Model..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(198, 6)
        '
        'mnuModelOtherOneVariable
        '
        Me.mnuModelOtherOneVariable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModelOtherOneVariableExactResults, Me.mnuModelOtherOneVariableSampleSummaryData, Me.mnuModelOtherOneVariableNonParametric, Me.mnuModelOtherOneVariableGoodnessofFit})
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
        Me.mnuModelOtherTwoVariablesSummaryData.Tag = "Summary_Data"
        Me.mnuModelOtherTwoVariablesSummaryData.Text = "Summary Data..."
        '
        'mnuModelOtherTwoVariablesSimpleRegression
        '
        Me.mnuModelOtherTwoVariablesSimpleRegression.Name = "mnuModelOtherTwoVariablesSimpleRegression"
        Me.mnuModelOtherTwoVariablesSimpleRegression.Size = New System.Drawing.Size(266, 22)
        Me.mnuModelOtherTwoVariablesSimpleRegression.Tag = "Simple_Regression"
        Me.mnuModelOtherTwoVariablesSimpleRegression.Text = "Simple Regression..."
        '
        'mnuModelOtherTwoVariablesOneWayANOVA
        '
        Me.mnuModelOtherTwoVariablesOneWayANOVA.Name = "mnuModelOtherTwoVariablesOneWayANOVA"
        Me.mnuModelOtherTwoVariablesOneWayANOVA.Size = New System.Drawing.Size(266, 22)
        Me.mnuModelOtherTwoVariablesOneWayANOVA.Tag = "One_Way_ANOVA"
        Me.mnuModelOtherTwoVariablesOneWayANOVA.Text = "One Way ANOVA..."
        '
        'mnuModelOtherTwoVariablesNonParametricTwoSamples
        '
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Enabled = False
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Name = "mnuModelOtherTwoVariablesNonParametricTwoSamples"
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Size = New System.Drawing.Size(266, 22)
        Me.mnuModelOtherTwoVariablesNonParametricTwoSamples.Tag = "Non_Parameteric_Two_Samples"
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
        Me.mnuModelOtherThreeVariablesSimpleWithGroups.Size = New System.Drawing.Size(260, 22)
        Me.mnuModelOtherThreeVariablesSimpleWithGroups.Tag = "Simple_with_groups"
        Me.mnuModelOtherThreeVariablesSimpleWithGroups.Text = "Simple With Groups..."
        '
        'mnuModelOtherThreeVariablesNonParametricTwoWayANOVA
        '
        Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Name = "mnuModelOtherThreeVariablesNonParametricTwoWayANOVA"
        Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Size = New System.Drawing.Size(260, 22)
        Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Tag = "Non_Parametric_Two_Way_ANOVA..."
        Me.mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Text = "Non Parametric Two Way ANOVA..."
        '
        'mnuModelOtherThreeVariablesChisquareTest
        '
        Me.mnuModelOtherThreeVariablesChisquareTest.Name = "mnuModelOtherThreeVariablesChisquareTest"
        Me.mnuModelOtherThreeVariablesChisquareTest.Size = New System.Drawing.Size(260, 22)
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
        Me.mnuModelOtherGeneralRegression.Tag = "Regression"
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
        Me.mnuClimaticExamine.Size = New System.Drawing.Size(191, 22)
        Me.mnuClimaticExamine.Tag = "Examine"
        Me.mnuClimaticExamine.Text = "Examine..."
        Me.mnuClimaticExamine.Visible = False
        '
        'mnuClimaticProcess
        '
        Me.mnuClimaticProcess.Enabled = False
        Me.mnuClimaticProcess.Name = "mnuClimaticProcess"
        Me.mnuClimaticProcess.Size = New System.Drawing.Size(191, 22)
        Me.mnuClimaticProcess.Tag = "Process"
        Me.mnuClimaticProcess.Text = "Process..."
        Me.mnuClimaticProcess.Visible = False
        '
        'mnuClimaticEvaporation
        '
        Me.mnuClimaticEvaporation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticEvaporationSite, Me.mnuClimaticEvaporationPenman})
        Me.mnuClimaticEvaporation.Name = "mnuClimaticEvaporation"
        Me.mnuClimaticEvaporation.Size = New System.Drawing.Size(191, 22)
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
        Me.mnuClimaticCrop.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CropCoefficientsToolStripMenuItem, Me.WaterSatisfactionIndexToolStripMenuItem})
        Me.mnuClimaticCrop.Name = "mnuClimaticCrop"
        Me.mnuClimaticCrop.Size = New System.Drawing.Size(191, 22)
        Me.mnuClimaticCrop.Tag = "Crop"
        Me.mnuClimaticCrop.Text = "Crop"
        Me.mnuClimaticCrop.Visible = False
        '
        'CropCoefficientsToolStripMenuItem
        '
        Me.CropCoefficientsToolStripMenuItem.Enabled = False
        Me.CropCoefficientsToolStripMenuItem.Name = "CropCoefficientsToolStripMenuItem"
        Me.CropCoefficientsToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CropCoefficientsToolStripMenuItem.Text = "Crop Coefficients..."
        '
        'WaterSatisfactionIndexToolStripMenuItem
        '
        Me.WaterSatisfactionIndexToolStripMenuItem.Enabled = False
        Me.WaterSatisfactionIndexToolStripMenuItem.Name = "WaterSatisfactionIndexToolStripMenuItem"
        Me.WaterSatisfactionIndexToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.WaterSatisfactionIndexToolStripMenuItem.Text = "Water Satisfaction Index..."
        '
        'mnuClimaticHeatSum
        '
        Me.mnuClimaticHeatSum.Enabled = False
        Me.mnuClimaticHeatSum.Name = "mnuClimaticHeatSum"
        Me.mnuClimaticHeatSum.Size = New System.Drawing.Size(191, 22)
        Me.mnuClimaticHeatSum.Tag = "Heat_Sum"
        Me.mnuClimaticHeatSum.Text = "Heat Sum..."
        Me.mnuClimaticHeatSum.Visible = False
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewDataView, Me.mnuViewOutputWindow, Me.mnuViewLog, Me.mnuViewScriptWindow, Me.mnuViewColumnMetadata, Me.mnuViewDataFrameMetadata, Me.ToolStripSeparator22, Me.mnuViewCascade, Me.mnuViewTileVertically, Me.mnuViewTileHorizontally})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 20)
        Me.mnuView.Tag = "View"
        Me.mnuView.Text = "View"
        '
        'mnuViewDataView
        '
        Me.mnuViewDataView.Name = "mnuViewDataView"
        Me.mnuViewDataView.Size = New System.Drawing.Size(187, 22)
        Me.mnuViewDataView.Tag = "Data_View"
        Me.mnuViewDataView.Text = "Data View"
        '
        'mnuViewOutputWindow
        '
        Me.mnuViewOutputWindow.Name = "mnuViewOutputWindow"
        Me.mnuViewOutputWindow.Size = New System.Drawing.Size(187, 22)
        Me.mnuViewOutputWindow.Text = "Output Window"
        '
        'mnuViewLog
        '
        Me.mnuViewLog.Name = "mnuViewLog"
        Me.mnuViewLog.Size = New System.Drawing.Size(187, 22)
        Me.mnuViewLog.Tag = "Log"
        Me.mnuViewLog.Text = "Log Window"
        '
        'mnuViewScriptWindow
        '
        Me.mnuViewScriptWindow.Name = "mnuViewScriptWindow"
        Me.mnuViewScriptWindow.Size = New System.Drawing.Size(187, 22)
        Me.mnuViewScriptWindow.Tag = "Script_Window"
        Me.mnuViewScriptWindow.Text = "Script Window"
        '
        'mnuViewColumnMetadata
        '
        Me.mnuViewColumnMetadata.Name = "mnuViewColumnMetadata"
        Me.mnuViewColumnMetadata.Size = New System.Drawing.Size(187, 22)
        Me.mnuViewColumnMetadata.Tag = "Column_Metadata"
        Me.mnuViewColumnMetadata.Text = "Column Metadata"
        '
        'mnuViewDataFrameMetadata
        '
        Me.mnuViewDataFrameMetadata.Name = "mnuViewDataFrameMetadata"
        Me.mnuViewDataFrameMetadata.Size = New System.Drawing.Size(187, 22)
        Me.mnuViewDataFrameMetadata.Tag = "Data_Frame_Metadata"
        Me.mnuViewDataFrameMetadata.Text = "Data Frame Metadata"
        '
        'ToolStripSeparator22
        '
        Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
        Me.ToolStripSeparator22.Size = New System.Drawing.Size(184, 6)
        '
        'mnuViewCascade
        '
        Me.mnuViewCascade.Name = "mnuViewCascade"
        Me.mnuViewCascade.Size = New System.Drawing.Size(187, 22)
        Me.mnuViewCascade.Text = "Cascade"
        '
        'mnuViewTileVertically
        '
        Me.mnuViewTileVertically.Name = "mnuViewTileVertically"
        Me.mnuViewTileVertically.Size = New System.Drawing.Size(187, 22)
        Me.mnuViewTileVertically.Text = "Tile Vertically"
        '
        'mnuViewTileHorizontally
        '
        Me.mnuViewTileHorizontally.Name = "mnuViewTileHorizontally"
        Me.mnuViewTileHorizontally.Size = New System.Drawing.Size(187, 22)
        Me.mnuViewTileHorizontally.Text = "Tile Horizontally"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpHelpIntroduction, Me.mnuHelpHistFAQ, Me.mnuHelpSpreadsheet, Me.mnuHelpGetingStarted, Me.ToolStripSeparator28, Me.mnuHelpMenus, Me.mnuHelpR, Me.mnuHelpRPackagesCommands, Me.mnuHelpDataset, Me.ToolStripSeparator29, Me.mnuHelpGuide, Me.mnuHelpAboutRInstat, Me.mnuHelpLicence})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Tag = "Help"
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpHelpIntroduction
        '
        Me.mnuHelpHelpIntroduction.Name = "mnuHelpHelpIntroduction"
        Me.mnuHelpHelpIntroduction.Size = New System.Drawing.Size(221, 22)
        Me.mnuHelpHelpIntroduction.Text = "Introduction"
        '
        'mnuHelpHistFAQ
        '
        Me.mnuHelpHistFAQ.Name = "mnuHelpHistFAQ"
        Me.mnuHelpHistFAQ.Size = New System.Drawing.Size(221, 22)
        Me.mnuHelpHistFAQ.Text = "History and FAQ"
        '
        'mnuHelpSpreadsheet
        '
        Me.mnuHelpSpreadsheet.Name = "mnuHelpSpreadsheet"
        Me.mnuHelpSpreadsheet.Size = New System.Drawing.Size(221, 22)
        Me.mnuHelpSpreadsheet.Text = "Spreadsheet"
        '
        'mnuHelpGetingStarted
        '
        Me.mnuHelpGetingStarted.Name = "mnuHelpGetingStarted"
        Me.mnuHelpGetingStarted.Size = New System.Drawing.Size(221, 22)
        Me.mnuHelpGetingStarted.Text = "Getting Started"
        '
        'ToolStripSeparator28
        '
        Me.ToolStripSeparator28.Name = "ToolStripSeparator28"
        Me.ToolStripSeparator28.Size = New System.Drawing.Size(218, 6)
        '
        'mnuHelpMenus
        '
        Me.mnuHelpMenus.Name = "mnuHelpMenus"
        Me.mnuHelpMenus.Size = New System.Drawing.Size(221, 22)
        Me.mnuHelpMenus.Text = "Menus and Dialogs"
        '
        'mnuHelpR
        '
        Me.mnuHelpR.Name = "mnuHelpR"
        Me.mnuHelpR.Size = New System.Drawing.Size(221, 22)
        Me.mnuHelpR.Text = "About R"
        '
        'mnuHelpRPackagesCommands
        '
        Me.mnuHelpRPackagesCommands.Name = "mnuHelpRPackagesCommands"
        Me.mnuHelpRPackagesCommands.Size = New System.Drawing.Size(221, 22)
        Me.mnuHelpRPackagesCommands.Text = "R Packages and Commands"
        '
        'mnuHelpDataset
        '
        Me.mnuHelpDataset.Name = "mnuHelpDataset"
        Me.mnuHelpDataset.Size = New System.Drawing.Size(221, 22)
        Me.mnuHelpDataset.Text = "Datasets"
        '
        'ToolStripSeparator29
        '
        Me.ToolStripSeparator29.Name = "ToolStripSeparator29"
        Me.ToolStripSeparator29.Size = New System.Drawing.Size(218, 6)
        '
        'mnuHelpGuide
        '
        Me.mnuHelpGuide.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpGuidesCaseStudy, Me.mnuHelpGuideGlosary, Me.mnuhelpGuidesMore})
        Me.mnuHelpGuide.Name = "mnuHelpGuide"
        Me.mnuHelpGuide.Size = New System.Drawing.Size(221, 22)
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
        Me.mnuHelpAboutRInstat.Size = New System.Drawing.Size(221, 22)
        Me.mnuHelpAboutRInstat.Tag = "About_R-Instat"
        Me.mnuHelpAboutRInstat.Text = "About R-Instat"
        '
        'mnuHelpLicence
        '
        Me.mnuHelpLicence.Name = "mnuHelpLicence"
        Me.mnuHelpLicence.Size = New System.Drawing.Size(221, 22)
        Me.mnuHelpLicence.Tag = "Licence..."
        Me.mnuHelpLicence.Text = "Licence..."
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(188, 6)
        '
        'mnuClimatic
        '
        Me.mnuClimatic.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticFile, Me.ToolStripSeparator18, Me.mnuCliDefineClimaticData, Me.mnuClimaticPrepare, Me.mnuClimaticQualityControl, Me.ToolStripSeparator30, Me.mnuClimdex, Me.mnuClimaticDescribe, Me.mnuClimaticPICSA, Me.ToolStripSeparator16, Me.mnuClimaticModels, Me.mnuClimaticExamine, Me.mnuClimaticProcess, Me.ToolStripSeparator23, Me.mnuClimaticSCF, Me.mnuClimaticEvaporation, Me.mnuClimaticCrop, Me.mnuClimaticHeatSum, Me.mnuClimateMethods})
        Me.mnuClimatic.Name = "mnuClimatic"
        Me.mnuClimatic.Size = New System.Drawing.Size(63, 20)
        Me.mnuClimatic.Tag = "Climatic"
        Me.mnuClimatic.Text = "Climatic"
        '
        'mnuClimaticFile
        '
        Me.mnuClimaticFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticFileOpensst, Me.mnuClimateFileClimSoft, Me.mnuClimaticFileCliData, Me.ToolStripSeparator15, Me.mnuClimaticFileExportToCPT})
        Me.mnuClimaticFile.Name = "mnuClimaticFile"
        Me.mnuClimaticFile.Size = New System.Drawing.Size(191, 22)
        Me.mnuClimaticFile.Text = "File"
        '
        'mnuClimaticFileOpensst
        '
        Me.mnuClimaticFileOpensst.Name = "mnuClimaticFileOpensst"
        Me.mnuClimaticFileOpensst.Size = New System.Drawing.Size(155, 22)
        Me.mnuClimaticFileOpensst.Text = "Open SST..."
        '
        'mnuClimateFileClimSoft
        '
        Me.mnuClimateFileClimSoft.Name = "mnuClimateFileClimSoft"
        Me.mnuClimateFileClimSoft.Size = New System.Drawing.Size(155, 22)
        Me.mnuClimateFileClimSoft.Text = "ClimSoft..."
        '
        'mnuClimaticFileCliData
        '
        Me.mnuClimaticFileCliData.Name = "mnuClimaticFileCliData"
        Me.mnuClimaticFileCliData.Size = New System.Drawing.Size(155, 22)
        Me.mnuClimaticFileCliData.Text = "CliData..."
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(152, 6)
        '
        'mnuClimaticFileExportToCPT
        '
        Me.mnuClimaticFileExportToCPT.Name = "mnuClimaticFileExportToCPT"
        Me.mnuClimaticFileExportToCPT.Size = New System.Drawing.Size(155, 22)
        Me.mnuClimaticFileExportToCPT.Tag = "Export_to_CPT"
        Me.mnuClimaticFileExportToCPT.Text = "Export to CPT..."
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(188, 6)
        '
        'mnuCliDefineClimaticData
        '
        Me.mnuCliDefineClimaticData.Name = "mnuCliDefineClimaticData"
        Me.mnuCliDefineClimaticData.Size = New System.Drawing.Size(191, 22)
        Me.mnuCliDefineClimaticData.Text = "Define Climatic Data..."
        '
        'mnuClimaticPrepare
        '
        Me.mnuClimaticPrepare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticPrepareDates, Me.mnuCimaticPrepareTransform, Me.mnuClimaticPrepareClimaticSummaries, Me.mnuClimaticPrepareSpecificEvents, Me.mnuClimaticPrepareSummary, Me.mnuClimaticPrepareNewWorksheet, Me.mnuClimaticPrepareImportDailyData, Me.mnuClimaticPrepareMakeFactor, Me.mnuClimaticPrepareShiftDailyData, Me.mnuClimaticPrepareUnstackDailyData, Me.mnuClimaticPrepareStackDailyData})
        Me.mnuClimaticPrepare.Name = "mnuClimaticPrepare"
        Me.mnuClimaticPrepare.Size = New System.Drawing.Size(191, 22)
        Me.mnuClimaticPrepare.Tag = "Prepare"
        Me.mnuClimaticPrepare.Text = "Prepare"
        '
        'mnuClimaticPrepareDates
        '
        Me.mnuClimaticPrepareDates.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticPrepareDatesGenerateDates, Me.mnuClimaticPrepareDatesMakeDate, Me.mnuClimaticPrepareDatesUseDate, Me.mnuClimaticPrepareInfillMissingDates, Me.mnuClimaticPrepareDatesMakeTime, Me.mnuClimaticPrepareDatesUseTime})
        Me.mnuClimaticPrepareDates.Name = "mnuClimaticPrepareDates"
        Me.mnuClimaticPrepareDates.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareDates.Text = "Dates"
        '
        'mnuClimaticPrepareDatesGenerateDates
        '
        Me.mnuClimaticPrepareDatesGenerateDates.Enabled = False
        Me.mnuClimaticPrepareDatesGenerateDates.Name = "mnuClimaticPrepareDatesGenerateDates"
        Me.mnuClimaticPrepareDatesGenerateDates.Size = New System.Drawing.Size(182, 22)
        Me.mnuClimaticPrepareDatesGenerateDates.Text = "Generate Dates..."
        '
        'mnuClimaticPrepareDatesMakeDate
        '
        Me.mnuClimaticPrepareDatesMakeDate.Name = "mnuClimaticPrepareDatesMakeDate"
        Me.mnuClimaticPrepareDatesMakeDate.Size = New System.Drawing.Size(182, 22)
        Me.mnuClimaticPrepareDatesMakeDate.Text = "Make Date..."
        '
        'mnuClimaticPrepareDatesUseDate
        '
        Me.mnuClimaticPrepareDatesUseDate.Name = "mnuClimaticPrepareDatesUseDate"
        Me.mnuClimaticPrepareDatesUseDate.Size = New System.Drawing.Size(182, 22)
        Me.mnuClimaticPrepareDatesUseDate.Text = "Use Date..."
        '
        'mnuClimaticPrepareInfillMissingDates
        '
        Me.mnuClimaticPrepareInfillMissingDates.Name = "mnuClimaticPrepareInfillMissingDates"
        Me.mnuClimaticPrepareInfillMissingDates.Size = New System.Drawing.Size(182, 22)
        Me.mnuClimaticPrepareInfillMissingDates.Text = "Infill Missing Dates..."
        '
        'mnuClimaticPrepareDatesMakeTime
        '
        Me.mnuClimaticPrepareDatesMakeTime.Name = "mnuClimaticPrepareDatesMakeTime"
        Me.mnuClimaticPrepareDatesMakeTime.Size = New System.Drawing.Size(182, 22)
        Me.mnuClimaticPrepareDatesMakeTime.Text = "Make Time..."
        '
        'mnuClimaticPrepareDatesUseTime
        '
        Me.mnuClimaticPrepareDatesUseTime.Name = "mnuClimaticPrepareDatesUseTime"
        Me.mnuClimaticPrepareDatesUseTime.Size = New System.Drawing.Size(182, 22)
        Me.mnuClimaticPrepareDatesUseTime.Text = "Use Time..."
        '
        'mnuCimaticPrepareTransform
        '
        Me.mnuCimaticPrepareTransform.Name = "mnuCimaticPrepareTransform"
        Me.mnuCimaticPrepareTransform.Size = New System.Drawing.Size(189, 22)
        Me.mnuCimaticPrepareTransform.Text = "Transform..."
        '
        'mnuClimaticPrepareClimaticSummaries
        '
        Me.mnuClimaticPrepareClimaticSummaries.Name = "mnuClimaticPrepareClimaticSummaries"
        Me.mnuClimaticPrepareClimaticSummaries.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareClimaticSummaries.Text = "Climatic Summaries..."
        '
        'mnuClimaticPrepareSpecificEvents
        '
        Me.mnuClimaticPrepareSpecificEvents.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticPrepareEventsStartoftheRains, Me.mnuClimaticPrepareEventsSpells, Me.Extremes, Me.mnuClimaticPrepareEventsWaterBalance, Me.mnuClimaticPrepareEventsEndoftheRains})
        Me.mnuClimaticPrepareSpecificEvents.Name = "mnuClimaticPrepareSpecificEvents"
        Me.mnuClimaticPrepareSpecificEvents.Size = New System.Drawing.Size(189, 22)
        Me.mnuClimaticPrepareSpecificEvents.Text = "Specific Events"
        '
        'mnuClimaticPrepareEventsStartoftheRains
        '
        Me.mnuClimaticPrepareEventsStartoftheRains.Enabled = False
        Me.mnuClimaticPrepareEventsStartoftheRains.Name = "mnuClimaticPrepareEventsStartoftheRains"
        Me.mnuClimaticPrepareEventsStartoftheRains.Size = New System.Drawing.Size(172, 22)
        Me.mnuClimaticPrepareEventsStartoftheRains.Text = "Start of the Rains..."
        '
        'mnuClimaticPrepareEventsSpells
        '
        Me.mnuClimaticPrepareEventsSpells.Enabled = False
        Me.mnuClimaticPrepareEventsSpells.Name = "mnuClimaticPrepareEventsSpells"
        Me.mnuClimaticPrepareEventsSpells.Size = New System.Drawing.Size(172, 22)
        Me.mnuClimaticPrepareEventsSpells.Text = "Spells..."
        '
        'Extremes
        '
        Me.Extremes.Name = "Extremes"
        Me.Extremes.Size = New System.Drawing.Size(172, 22)
        Me.Extremes.Text = "Extremes..."
        '
        'mnuClimaticPrepareEventsWaterBalance
        '
        Me.mnuClimaticPrepareEventsWaterBalance.Enabled = False
        Me.mnuClimaticPrepareEventsWaterBalance.Name = "mnuClimaticPrepareEventsWaterBalance"
        Me.mnuClimaticPrepareEventsWaterBalance.Size = New System.Drawing.Size(172, 22)
        Me.mnuClimaticPrepareEventsWaterBalance.Text = "Water Balance..."
        '
        'mnuClimaticPrepareEventsEndoftheRains
        '
        Me.mnuClimaticPrepareEventsEndoftheRains.Enabled = False
        Me.mnuClimaticPrepareEventsEndoftheRains.Name = "mnuClimaticPrepareEventsEndoftheRains"
        Me.mnuClimaticPrepareEventsEndoftheRains.Size = New System.Drawing.Size(172, 22)
        Me.mnuClimaticPrepareEventsEndoftheRains.Text = "End of the Rains..."
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
        'mnuClimaticQualityControl
        '
        Me.mnuClimaticQualityControl.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryToolStripMenuItem, Me.DisplayDailyToolStripMenuItem, Me.QCProceduresToolStripMenuItem})
        Me.mnuClimaticQualityControl.Name = "mnuClimaticQualityControl"
        Me.mnuClimaticQualityControl.Size = New System.Drawing.Size(191, 22)
        Me.mnuClimaticQualityControl.Text = "Quality Control"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.InventoryToolStripMenuItem.Text = "Inventory..."
        '
        'DisplayDailyToolStripMenuItem
        '
        Me.DisplayDailyToolStripMenuItem.Name = "DisplayDailyToolStripMenuItem"
        Me.DisplayDailyToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DisplayDailyToolStripMenuItem.Text = "Display Daily..."
        '
        'QCProceduresToolStripMenuItem
        '
        Me.QCProceduresToolStripMenuItem.Name = "QCProceduresToolStripMenuItem"
        Me.QCProceduresToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.QCProceduresToolStripMenuItem.Text = "QC Procedures..."
        '
        'ToolStripSeparator30
        '
        Me.ToolStripSeparator30.Name = "ToolStripSeparator30"
        Me.ToolStripSeparator30.Size = New System.Drawing.Size(188, 6)
        '
        'mnuClimdex
        '
        Me.mnuClimdex.Name = "mnuClimdex"
        Me.mnuClimdex.Size = New System.Drawing.Size(191, 22)
        Me.mnuClimdex.Tag = "Climdex"
        Me.mnuClimdex.Text = "Climdex..."
        '
        'mnuClimaticDescribe
        '
        Me.mnuClimaticDescribe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticDescribeRainfall, Me.mnuClimaticDescribeTemperatures, Me.mnuClimaticDescribeWindSpeedDirection, Me.mnuClimaticDescribeSunshineRadiation, Me.ToolStripSeparator17, Me.mnuClimaticDescribeGeneral, Me.ToolStripSeparator31, Me.mnuClimaticMoreGraphs})
        Me.mnuClimaticDescribe.Name = "mnuClimaticDescribe"
        Me.mnuClimaticDescribe.Size = New System.Drawing.Size(191, 22)
        Me.mnuClimaticDescribe.Text = "Describe"
        '
        'mnuClimaticDescribeRainfall
        '
        Me.mnuClimaticDescribeRainfall.Name = "mnuClimaticDescribeRainfall"
        Me.mnuClimaticDescribeRainfall.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimaticDescribeRainfall.Text = "Rainfall..."
        '
        'mnuClimaticDescribeTemperatures
        '
        Me.mnuClimaticDescribeTemperatures.Name = "mnuClimaticDescribeTemperatures"
        Me.mnuClimaticDescribeTemperatures.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimaticDescribeTemperatures.Text = "Temperature..."
        '
        'mnuClimaticDescribeWindSpeedDirection
        '
        Me.mnuClimaticDescribeWindSpeedDirection.Name = "mnuClimaticDescribeWindSpeedDirection"
        Me.mnuClimaticDescribeWindSpeedDirection.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimaticDescribeWindSpeedDirection.Text = "Wind Speed/Direction..."
        '
        'mnuClimaticDescribeSunshineRadiation
        '
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
        Me.mnuClimaticDescribeGeneral.Name = "mnuClimaticDescribeGeneral"
        Me.mnuClimaticDescribeGeneral.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimaticDescribeGeneral.Text = "General"
        '
        'ToolStripSeparator31
        '
        Me.ToolStripSeparator31.Name = "ToolStripSeparator31"
        Me.ToolStripSeparator31.Size = New System.Drawing.Size(196, 6)
        '
        'mnuClimaticMoreGraphs
        '
        Me.mnuClimaticMoreGraphs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticDescribeMoreGraphsWindoRose, Me.mnuClimaticDescribeMoreGraphsCummulaiveDistribution})
        Me.mnuClimaticMoreGraphs.Name = "mnuClimaticMoreGraphs"
        Me.mnuClimaticMoreGraphs.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimaticMoreGraphs.Text = "Climatic Graphs"
        '
        'mnuClimaticDescribeMoreGraphsWindoRose
        '
        Me.mnuClimaticDescribeMoreGraphsWindoRose.AccessibleDescription = "mnuClimaticDescribeCummulativeDistribution"
        Me.mnuClimaticDescribeMoreGraphsWindoRose.Name = "mnuClimaticDescribeMoreGraphsWindoRose"
        Me.mnuClimaticDescribeMoreGraphsWindoRose.Size = New System.Drawing.Size(209, 22)
        Me.mnuClimaticDescribeMoreGraphsWindoRose.Tag = "WindRose..."
        Me.mnuClimaticDescribeMoreGraphsWindoRose.Text = "WindRose..."
        '
        'mnuClimaticDescribeMoreGraphsCummulaiveDistribution
        '
        Me.mnuClimaticDescribeMoreGraphsCummulaiveDistribution.Name = "mnuClimaticDescribeMoreGraphsCummulaiveDistribution"
        Me.mnuClimaticDescribeMoreGraphsCummulaiveDistribution.Size = New System.Drawing.Size(209, 22)
        Me.mnuClimaticDescribeMoreGraphsCummulaiveDistribution.Tag = "Cumulative_Distribution..."
        Me.mnuClimaticDescribeMoreGraphsCummulaiveDistribution.Text = "Cumulative Distribution..."
        '
        'mnuClimaticPICSA
        '
        Me.mnuClimaticPICSA.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticPICSARainfall, Me.mnuClimaticPICSATemperature, Me.mnuClimaticPICSACrops})
        Me.mnuClimaticPICSA.Name = "mnuClimaticPICSA"
        Me.mnuClimaticPICSA.Size = New System.Drawing.Size(191, 22)
        Me.mnuClimaticPICSA.Text = "PICSA"
        '
        'mnuClimaticPICSARainfall
        '
        Me.mnuClimaticPICSARainfall.Name = "mnuClimaticPICSARainfall"
        Me.mnuClimaticPICSARainfall.Size = New System.Drawing.Size(150, 22)
        Me.mnuClimaticPICSARainfall.Text = "Rainfall..."
        '
        'mnuClimaticPICSATemperature
        '
        Me.mnuClimaticPICSATemperature.Name = "mnuClimaticPICSATemperature"
        Me.mnuClimaticPICSATemperature.Size = New System.Drawing.Size(150, 22)
        Me.mnuClimaticPICSATemperature.Text = "Temperature..."
        '
        'mnuClimaticPICSACrops
        '
        Me.mnuClimaticPICSACrops.Name = "mnuClimaticPICSACrops"
        Me.mnuClimaticPICSACrops.Size = New System.Drawing.Size(150, 22)
        Me.mnuClimaticPICSACrops.Text = "Crops..."
        '
        'mnuClimaticModels
        '
        Me.mnuClimaticModels.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticModelsExtremes, Me.mnuClimaticModelsCircular, Me.mnuClimaticModelsMarkovModelling})
        Me.mnuClimaticModels.Name = "mnuClimaticModels"
        Me.mnuClimaticModels.Size = New System.Drawing.Size(191, 22)
        Me.mnuClimaticModels.Text = "Model"
        '
        'mnuClimaticModelsExtremes
        '
        Me.mnuClimaticModelsExtremes.Name = "mnuClimaticModelsExtremes"
        Me.mnuClimaticModelsExtremes.Size = New System.Drawing.Size(180, 22)
        Me.mnuClimaticModelsExtremes.Text = "Extremes..."
        '
        'mnuClimaticModelsCircular
        '
        Me.mnuClimaticModelsCircular.Enabled = False
        Me.mnuClimaticModelsCircular.Name = "mnuClimaticModelsCircular"
        Me.mnuClimaticModelsCircular.Size = New System.Drawing.Size(180, 22)
        Me.mnuClimaticModelsCircular.Text = "Circular..."
        '
        'mnuClimaticModelsMarkovModelling
        '
        Me.mnuClimaticModelsMarkovModelling.Name = "mnuClimaticModelsMarkovModelling"
        Me.mnuClimaticModelsMarkovModelling.Size = New System.Drawing.Size(180, 22)
        Me.mnuClimaticModelsMarkovModelling.Tag = "Markov_Modelling"
        Me.mnuClimaticModelsMarkovModelling.Text = "Markov Modelling..."
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        Me.ToolStripSeparator23.Size = New System.Drawing.Size(188, 6)
        '
        'mnuClimaticSCF
        '
        Me.mnuClimaticSCF.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimaticSCFSupportOpenSST, Me.mnuClimaticSCFSupportExporttoCPT, Me.ToolStripSeparator32, Me.mnuClimaticSCFSupportCorrelations, Me.mnuClimaticSCFSupportPrincipalComponents, Me.mnuClimaticSCFSupportCanonicalCorrelations, Me.mnuClimaticSCFSupportCumulativeExceedanceGraphs})
        Me.mnuClimaticSCF.Name = "mnuClimaticSCF"
        Me.mnuClimaticSCF.Size = New System.Drawing.Size(191, 22)
        Me.mnuClimaticSCF.Text = "SCF Support"
        '
        'mnuClimaticSCFSupportOpenSST
        '
        Me.mnuClimaticSCFSupportOpenSST.Name = "mnuClimaticSCFSupportOpenSST"
        Me.mnuClimaticSCFSupportOpenSST.Size = New System.Drawing.Size(250, 22)
        Me.mnuClimaticSCFSupportOpenSST.Text = "Open SST..."
        '
        'mnuClimaticSCFSupportExporttoCPT
        '
        Me.mnuClimaticSCFSupportExporttoCPT.Name = "mnuClimaticSCFSupportExporttoCPT"
        Me.mnuClimaticSCFSupportExporttoCPT.Size = New System.Drawing.Size(250, 22)
        Me.mnuClimaticSCFSupportExporttoCPT.Tag = "Export_to_CPT"
        Me.mnuClimaticSCFSupportExporttoCPT.Text = "Export to CPT..."
        '
        'ToolStripSeparator32
        '
        Me.ToolStripSeparator32.Name = "ToolStripSeparator32"
        Me.ToolStripSeparator32.Size = New System.Drawing.Size(247, 6)
        '
        'mnuClimaticSCFSupportCorrelations
        '
        Me.mnuClimaticSCFSupportCorrelations.Name = "mnuClimaticSCFSupportCorrelations"
        Me.mnuClimaticSCFSupportCorrelations.Size = New System.Drawing.Size(250, 22)
        Me.mnuClimaticSCFSupportCorrelations.Text = "Correlations..."
        '
        'mnuClimaticSCFSupportPrincipalComponents
        '
        Me.mnuClimaticSCFSupportPrincipalComponents.Name = "mnuClimaticSCFSupportPrincipalComponents"
        Me.mnuClimaticSCFSupportPrincipalComponents.Size = New System.Drawing.Size(250, 22)
        Me.mnuClimaticSCFSupportPrincipalComponents.Text = "Principal Components..."
        '
        'mnuClimaticSCFSupportCanonicalCorrelations
        '
        Me.mnuClimaticSCFSupportCanonicalCorrelations.Name = "mnuClimaticSCFSupportCanonicalCorrelations"
        Me.mnuClimaticSCFSupportCanonicalCorrelations.Size = New System.Drawing.Size(250, 22)
        Me.mnuClimaticSCFSupportCanonicalCorrelations.Text = "Canonical Correlations..."
        '
        'mnuClimateMethods
        '
        Me.mnuClimateMethods.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimateMethodsDataManipulation, Me.mnuClimateMethodsGraphics, Me.mnuClimateMethodsModel, Me.mnuClimateMethodsAdditional, Me.mnuClimateMethodsCreateClimateObject})
        Me.mnuClimateMethods.Name = "mnuClimateMethods"
        Me.mnuClimateMethods.Size = New System.Drawing.Size(191, 22)
        Me.mnuClimateMethods.Tag = "Climatic_Methods"
        Me.mnuClimateMethods.Text = "Climate Methods"
        Me.mnuClimateMethods.Visible = False
        '
        'mnuClimateMethodsDataManipulation
        '
        Me.mnuClimateMethodsDataManipulation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimateMethodsDataManipulationStartOfRain, Me.mnuClimateMethodsDataManipulationEndOfRain, Me.mnuClimateMethodsDataManipulationChangeFormatDayMonth, Me.mnuClimateMethodsDataManipulationExportCPTToTabular, Me.mnuClimateMethodsDataManipulationDayMonth, Me.mnuClimateMethodsDataManipulationDisplayDaily, Me.mnuClimateMethodsDataManipulationDisplayDOYOfYear, Me.mnuClimateMethodsDataManipulationDisplayRainRunningTotal, Me.mnuClimateMethodsDataManipulationDisplaySpellLength, Me.mnuClimateMethodsDataManipulationExportForPICSA, Me.mnuClimateMethodsDataManipulationExtremeEvents, Me.mnuClimateMethodsDataManipulationMissingData, Me.mnuClimateMethodsDataManipulationMissingDataTable, Me.mnuClimateMethodsDataManipulationMonthlySummaries, Me.mnuClimateMethodsDataManipulationOutputForCD})
        Me.mnuClimateMethodsDataManipulation.Name = "mnuClimateMethodsDataManipulation"
        Me.mnuClimateMethodsDataManipulation.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimateMethodsDataManipulation.Tag = "Data_Manipulation"
        Me.mnuClimateMethodsDataManipulation.Text = "Data Manipulation"
        '
        'mnuClimateMethodsDataManipulationStartOfRain
        '
        Me.mnuClimateMethodsDataManipulationStartOfRain.Enabled = False
        Me.mnuClimateMethodsDataManipulationStartOfRain.Name = "mnuClimateMethodsDataManipulationStartOfRain"
        Me.mnuClimateMethodsDataManipulationStartOfRain.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimateMethodsDataManipulationStartOfRain.Tag = "Start_of_Rain"
        Me.mnuClimateMethodsDataManipulationStartOfRain.Text = "Start of Rain..."
        '
        'mnuClimateMethodsDataManipulationEndOfRain
        '
        Me.mnuClimateMethodsDataManipulationEndOfRain.Enabled = False
        Me.mnuClimateMethodsDataManipulationEndOfRain.Name = "mnuClimateMethodsDataManipulationEndOfRain"
        Me.mnuClimateMethodsDataManipulationEndOfRain.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimateMethodsDataManipulationEndOfRain.Tag = "End_of_Rain"
        Me.mnuClimateMethodsDataManipulationEndOfRain.Text = "End of Rain..."
        '
        'mnuClimateMethodsDataManipulationChangeFormatDayMonth
        '
        Me.mnuClimateMethodsDataManipulationChangeFormatDayMonth.Enabled = False
        Me.mnuClimateMethodsDataManipulationChangeFormatDayMonth.Name = "mnuClimateMethodsDataManipulationChangeFormatDayMonth"
        Me.mnuClimateMethodsDataManipulationChangeFormatDayMonth.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimateMethodsDataManipulationChangeFormatDayMonth.Tag = "Change_Format_Month"
        Me.mnuClimateMethodsDataManipulationChangeFormatDayMonth.Text = "Change Format Day Month..."
        '
        'mnuClimateMethodsDataManipulationExportCPTToTabular
        '
        Me.mnuClimateMethodsDataManipulationExportCPTToTabular.Enabled = False
        Me.mnuClimateMethodsDataManipulationExportCPTToTabular.Name = "mnuClimateMethodsDataManipulationExportCPTToTabular"
        Me.mnuClimateMethodsDataManipulationExportCPTToTabular.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimateMethodsDataManipulationExportCPTToTabular.Tag = "Expot_CPT_to_Tabular"
        Me.mnuClimateMethodsDataManipulationExportCPTToTabular.Text = "Export CPT to Tabular..."
        '
        'mnuClimateMethodsDataManipulationDayMonth
        '
        Me.mnuClimateMethodsDataManipulationDayMonth.Enabled = False
        Me.mnuClimateMethodsDataManipulationDayMonth.Name = "mnuClimateMethodsDataManipulationDayMonth"
        Me.mnuClimateMethodsDataManipulationDayMonth.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimateMethodsDataManipulationDayMonth.Tag = "Day_Month"
        Me.mnuClimateMethodsDataManipulationDayMonth.Text = "Day Month..."
        '
        'mnuClimateMethodsDataManipulationDisplayDaily
        '
        Me.mnuClimateMethodsDataManipulationDisplayDaily.Enabled = False
        Me.mnuClimateMethodsDataManipulationDisplayDaily.Name = "mnuClimateMethodsDataManipulationDisplayDaily"
        Me.mnuClimateMethodsDataManipulationDisplayDaily.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimateMethodsDataManipulationDisplayDaily.Tag = "Display_Daily"
        Me.mnuClimateMethodsDataManipulationDisplayDaily.Text = "Display Daily..."
        '
        'mnuClimateMethodsDataManipulationDisplayDOYOfYear
        '
        Me.mnuClimateMethodsDataManipulationDisplayDOYOfYear.Enabled = False
        Me.mnuClimateMethodsDataManipulationDisplayDOYOfYear.Name = "mnuClimateMethodsDataManipulationDisplayDOYOfYear"
        Me.mnuClimateMethodsDataManipulationDisplayDOYOfYear.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimateMethodsDataManipulationDisplayDOYOfYear.Tag = "Display_DOY_of_Year"
        Me.mnuClimateMethodsDataManipulationDisplayDOYOfYear.Text = "Display DOY of Year..."
        '
        'mnuClimateMethodsDataManipulationDisplayRainRunningTotal
        '
        Me.mnuClimateMethodsDataManipulationDisplayRainRunningTotal.Enabled = False
        Me.mnuClimateMethodsDataManipulationDisplayRainRunningTotal.Name = "mnuClimateMethodsDataManipulationDisplayRainRunningTotal"
        Me.mnuClimateMethodsDataManipulationDisplayRainRunningTotal.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimateMethodsDataManipulationDisplayRainRunningTotal.Tag = "Display_Rain_Running_Total"
        Me.mnuClimateMethodsDataManipulationDisplayRainRunningTotal.Text = "Display Rain Running Total..."
        '
        'mnuClimateMethodsDataManipulationDisplaySpellLength
        '
        Me.mnuClimateMethodsDataManipulationDisplaySpellLength.Enabled = False
        Me.mnuClimateMethodsDataManipulationDisplaySpellLength.Name = "mnuClimateMethodsDataManipulationDisplaySpellLength"
        Me.mnuClimateMethodsDataManipulationDisplaySpellLength.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimateMethodsDataManipulationDisplaySpellLength.Tag = "Display_Spell_length"
        Me.mnuClimateMethodsDataManipulationDisplaySpellLength.Text = "Display Spell Length..."
        '
        'mnuClimateMethodsDataManipulationExportForPICSA
        '
        Me.mnuClimateMethodsDataManipulationExportForPICSA.Enabled = False
        Me.mnuClimateMethodsDataManipulationExportForPICSA.Name = "mnuClimateMethodsDataManipulationExportForPICSA"
        Me.mnuClimateMethodsDataManipulationExportForPICSA.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimateMethodsDataManipulationExportForPICSA.Tag = "Export_for_PICSA"
        Me.mnuClimateMethodsDataManipulationExportForPICSA.Text = "Export for PICSA..."
        '
        'mnuClimateMethodsDataManipulationExtremeEvents
        '
        Me.mnuClimateMethodsDataManipulationExtremeEvents.Enabled = False
        Me.mnuClimateMethodsDataManipulationExtremeEvents.Name = "mnuClimateMethodsDataManipulationExtremeEvents"
        Me.mnuClimateMethodsDataManipulationExtremeEvents.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimateMethodsDataManipulationExtremeEvents.Tag = "Extreme_Events"
        Me.mnuClimateMethodsDataManipulationExtremeEvents.Text = "Extreme Events..."
        '
        'mnuClimateMethodsDataManipulationMissingData
        '
        Me.mnuClimateMethodsDataManipulationMissingData.Enabled = False
        Me.mnuClimateMethodsDataManipulationMissingData.Name = "mnuClimateMethodsDataManipulationMissingData"
        Me.mnuClimateMethodsDataManipulationMissingData.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimateMethodsDataManipulationMissingData.Tag = "Missing_Data"
        Me.mnuClimateMethodsDataManipulationMissingData.Text = "Missing Data..."
        '
        'mnuClimateMethodsDataManipulationMissingDataTable
        '
        Me.mnuClimateMethodsDataManipulationMissingDataTable.Enabled = False
        Me.mnuClimateMethodsDataManipulationMissingDataTable.Name = "mnuClimateMethodsDataManipulationMissingDataTable"
        Me.mnuClimateMethodsDataManipulationMissingDataTable.Size = New System.Drawing.Size(227, 22)
        Me.mnuClimateMethodsDataManipulationMissingDataTable.Tag = "Missing_Data_Table"
        Me.mnuClimateMethodsDataManipulationMissingDataTable.Text = "Missing Data Table..."
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
        'mnuClimateMethodsGraphics
        '
        Me.mnuClimateMethodsGraphics.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimateMethodsGraphicsClipBoxPlot, Me.mnuClimateMethodsGraphicsCliplot, Me.mnuClimateMethodsGraphicsMissingValues, Me.mnuClimateMethodsGraphicsHistogram, Me.mnuClimateMethodsGraphicsCumExceedance, Me.mnuClimateMethodsGraphicsBoxplot, Me.mnuClimateMethodsGraphicsInventory, Me.mnuClimateMethodsGraphicsAnnualRainfall, Me.mnuClimateMethodsGraphicsRainCount, Me.mnuClimateMethodsGraphicsTimeseries, Me.mnuClimateMethodsGraphicsWindrose, Me.mnuClimateMethodsGraphicsMultipleLines, Me.mnuClmateMethodThreeSummaries})
        Me.mnuClimateMethodsGraphics.Name = "mnuClimateMethodsGraphics"
        Me.mnuClimateMethodsGraphics.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimateMethodsGraphics.Tag = "Graphics"
        Me.mnuClimateMethodsGraphics.Text = "Graphics"
        '
        'mnuClimateMethodsGraphicsClipBoxPlot
        '
        Me.mnuClimateMethodsGraphicsClipBoxPlot.Enabled = False
        Me.mnuClimateMethodsGraphicsClipBoxPlot.Name = "mnuClimateMethodsGraphicsClipBoxPlot"
        Me.mnuClimateMethodsGraphicsClipBoxPlot.Size = New System.Drawing.Size(219, 22)
        Me.mnuClimateMethodsGraphicsClipBoxPlot.Tag = "Cliboxplot"
        Me.mnuClimateMethodsGraphicsClipBoxPlot.Text = "Cliboxplot..."
        '
        'mnuClimateMethodsGraphicsCliplot
        '
        Me.mnuClimateMethodsGraphicsCliplot.Enabled = False
        Me.mnuClimateMethodsGraphicsCliplot.Name = "mnuClimateMethodsGraphicsCliplot"
        Me.mnuClimateMethodsGraphicsCliplot.Size = New System.Drawing.Size(219, 22)
        Me.mnuClimateMethodsGraphicsCliplot.Tag = "Cliplot"
        Me.mnuClimateMethodsGraphicsCliplot.Text = "Cliplot..."
        '
        'mnuClimateMethodsGraphicsMissingValues
        '
        Me.mnuClimateMethodsGraphicsMissingValues.Enabled = False
        Me.mnuClimateMethodsGraphicsMissingValues.Name = "mnuClimateMethodsGraphicsMissingValues"
        Me.mnuClimateMethodsGraphicsMissingValues.Size = New System.Drawing.Size(219, 22)
        Me.mnuClimateMethodsGraphicsMissingValues.Tag = "Missing_values"
        Me.mnuClimateMethodsGraphicsMissingValues.Text = "Missing Values..."
        '
        'mnuClimateMethodsGraphicsHistogram
        '
        Me.mnuClimateMethodsGraphicsHistogram.Enabled = False
        Me.mnuClimateMethodsGraphicsHistogram.Name = "mnuClimateMethodsGraphicsHistogram"
        Me.mnuClimateMethodsGraphicsHistogram.Size = New System.Drawing.Size(219, 22)
        Me.mnuClimateMethodsGraphicsHistogram.Tag = "Histogram"
        Me.mnuClimateMethodsGraphicsHistogram.Text = "Histogram..."
        '
        'mnuClimateMethodsGraphicsCumExceedance
        '
        Me.mnuClimateMethodsGraphicsCumExceedance.Enabled = False
        Me.mnuClimateMethodsGraphicsCumExceedance.Name = "mnuClimateMethodsGraphicsCumExceedance"
        Me.mnuClimateMethodsGraphicsCumExceedance.Size = New System.Drawing.Size(219, 22)
        Me.mnuClimateMethodsGraphicsCumExceedance.Tag = "Cumulative_Exceedence"
        Me.mnuClimateMethodsGraphicsCumExceedance.Text = "Cummulative Exceedance..."
        '
        'mnuClimateMethodsGraphicsBoxplot
        '
        Me.mnuClimateMethodsGraphicsBoxplot.Enabled = False
        Me.mnuClimateMethodsGraphicsBoxplot.Name = "mnuClimateMethodsGraphicsBoxplot"
        Me.mnuClimateMethodsGraphicsBoxplot.Size = New System.Drawing.Size(219, 22)
        Me.mnuClimateMethodsGraphicsBoxplot.Tag = "Boxplot"
        Me.mnuClimateMethodsGraphicsBoxplot.Text = "Boxplot..."
        '
        'mnuClimateMethodsGraphicsInventory
        '
        Me.mnuClimateMethodsGraphicsInventory.Enabled = False
        Me.mnuClimateMethodsGraphicsInventory.Name = "mnuClimateMethodsGraphicsInventory"
        Me.mnuClimateMethodsGraphicsInventory.Size = New System.Drawing.Size(219, 22)
        Me.mnuClimateMethodsGraphicsInventory.Tag = "Inventory"
        Me.mnuClimateMethodsGraphicsInventory.Text = "Inventory..."
        '
        'mnuClimateMethodsGraphicsAnnualRainfall
        '
        Me.mnuClimateMethodsGraphicsAnnualRainfall.Enabled = False
        Me.mnuClimateMethodsGraphicsAnnualRainfall.Name = "mnuClimateMethodsGraphicsAnnualRainfall"
        Me.mnuClimateMethodsGraphicsAnnualRainfall.Size = New System.Drawing.Size(219, 22)
        Me.mnuClimateMethodsGraphicsAnnualRainfall.Tag = "Annual_rainfall"
        Me.mnuClimateMethodsGraphicsAnnualRainfall.Text = "Annual Rainfall..."
        '
        'mnuClimateMethodsGraphicsRainCount
        '
        Me.mnuClimateMethodsGraphicsRainCount.Enabled = False
        Me.mnuClimateMethodsGraphicsRainCount.Name = "mnuClimateMethodsGraphicsRainCount"
        Me.mnuClimateMethodsGraphicsRainCount.Size = New System.Drawing.Size(219, 22)
        Me.mnuClimateMethodsGraphicsRainCount.Tag = "Rain_count"
        Me.mnuClimateMethodsGraphicsRainCount.Text = "Rain Count..."
        '
        'mnuClimateMethodsGraphicsTimeseries
        '
        Me.mnuClimateMethodsGraphicsTimeseries.Enabled = False
        Me.mnuClimateMethodsGraphicsTimeseries.Name = "mnuClimateMethodsGraphicsTimeseries"
        Me.mnuClimateMethodsGraphicsTimeseries.Size = New System.Drawing.Size(219, 22)
        Me.mnuClimateMethodsGraphicsTimeseries.Tag = "Timeseries"
        Me.mnuClimateMethodsGraphicsTimeseries.Text = "Timeseries..."
        '
        'mnuClimateMethodsGraphicsWindrose
        '
        Me.mnuClimateMethodsGraphicsWindrose.Enabled = False
        Me.mnuClimateMethodsGraphicsWindrose.Name = "mnuClimateMethodsGraphicsWindrose"
        Me.mnuClimateMethodsGraphicsWindrose.Size = New System.Drawing.Size(219, 22)
        Me.mnuClimateMethodsGraphicsWindrose.Tag = "Windrose"
        Me.mnuClimateMethodsGraphicsWindrose.Text = "Windrose..."
        '
        'mnuClimateMethodsGraphicsMultipleLines
        '
        Me.mnuClimateMethodsGraphicsMultipleLines.Enabled = False
        Me.mnuClimateMethodsGraphicsMultipleLines.Name = "mnuClimateMethodsGraphicsMultipleLines"
        Me.mnuClimateMethodsGraphicsMultipleLines.Size = New System.Drawing.Size(219, 22)
        Me.mnuClimateMethodsGraphicsMultipleLines.Tag = "Multiple_lines"
        Me.mnuClimateMethodsGraphicsMultipleLines.Text = "Multple Lines..."
        '
        'mnuClmateMethodThreeSummaries
        '
        Me.mnuClmateMethodThreeSummaries.Enabled = False
        Me.mnuClmateMethodThreeSummaries.Name = "mnuClmateMethodThreeSummaries"
        Me.mnuClmateMethodThreeSummaries.Size = New System.Drawing.Size(219, 22)
        Me.mnuClmateMethodThreeSummaries.Tag = "Three_Summaries"
        Me.mnuClmateMethodThreeSummaries.Text = "Three Summaries..."
        '
        'mnuClimateMethodsModel
        '
        Me.mnuClimateMethodsModel.Enabled = False
        Me.mnuClimateMethodsModel.Name = "mnuClimateMethodsModel"
        Me.mnuClimateMethodsModel.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimateMethodsModel.Tag = "Model"
        Me.mnuClimateMethodsModel.Text = "Model..."
        '
        'mnuClimateMethodsAdditional
        '
        Me.mnuClimateMethodsAdditional.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClimateMethodsAdditionalOutputForCPT, Me.mnuClimateMethodsAdditionalRainsStatistics, Me.mnuClimateMethodsAdditionalSeasonalSummary, Me.mnuClimateMethodsAdditionalSeasonalSummaryRain, Me.mnuClimateMethodsAdditionalWaterBalance})
        Me.mnuClimateMethodsAdditional.Name = "mnuClimateMethodsAdditional"
        Me.mnuClimateMethodsAdditional.Size = New System.Drawing.Size(199, 22)
        Me.mnuClimateMethodsAdditional.Tag = "Additional"
        Me.mnuClimateMethodsAdditional.Text = "Additional"
        '
        'mnuClimateMethodsAdditionalOutputForCPT
        '
        Me.mnuClimateMethodsAdditionalOutputForCPT.Enabled = False
        Me.mnuClimateMethodsAdditionalOutputForCPT.Name = "mnuClimateMethodsAdditionalOutputForCPT"
        Me.mnuClimateMethodsAdditionalOutputForCPT.Size = New System.Drawing.Size(209, 22)
        Me.mnuClimateMethodsAdditionalOutputForCPT.Tag = "Output_for_CPT"
        Me.mnuClimateMethodsAdditionalOutputForCPT.Text = "Output for CPT..."
        '
        'mnuClimateMethodsAdditionalRainsStatistics
        '
        Me.mnuClimateMethodsAdditionalRainsStatistics.Enabled = False
        Me.mnuClimateMethodsAdditionalRainsStatistics.Name = "mnuClimateMethodsAdditionalRainsStatistics"
        Me.mnuClimateMethodsAdditionalRainsStatistics.Size = New System.Drawing.Size(209, 22)
        Me.mnuClimateMethodsAdditionalRainsStatistics.Tag = "Rain_Statistics"
        Me.mnuClimateMethodsAdditionalRainsStatistics.Text = "Rains Statistics..."
        '
        'mnuClimateMethodsAdditionalSeasonalSummary
        '
        Me.mnuClimateMethodsAdditionalSeasonalSummary.Enabled = False
        Me.mnuClimateMethodsAdditionalSeasonalSummary.Name = "mnuClimateMethodsAdditionalSeasonalSummary"
        Me.mnuClimateMethodsAdditionalSeasonalSummary.Size = New System.Drawing.Size(209, 22)
        Me.mnuClimateMethodsAdditionalSeasonalSummary.Tag = "Seasonal_Summary"
        Me.mnuClimateMethodsAdditionalSeasonalSummary.Text = "Seasonal Summary..."
        '
        'mnuClimateMethodsAdditionalSeasonalSummaryRain
        '
        Me.mnuClimateMethodsAdditionalSeasonalSummaryRain.Enabled = False
        Me.mnuClimateMethodsAdditionalSeasonalSummaryRain.Name = "mnuClimateMethodsAdditionalSeasonalSummaryRain"
        Me.mnuClimateMethodsAdditionalSeasonalSummaryRain.Size = New System.Drawing.Size(209, 22)
        Me.mnuClimateMethodsAdditionalSeasonalSummaryRain.Tag = "Seasonal_Summary_Rain"
        Me.mnuClimateMethodsAdditionalSeasonalSummaryRain.Text = "Seasonal Summary Rain..."
        '
        'mnuClimateMethodsAdditionalWaterBalance
        '
        Me.mnuClimateMethodsAdditionalWaterBalance.Enabled = False
        Me.mnuClimateMethodsAdditionalWaterBalance.Name = "mnuClimateMethodsAdditionalWaterBalance"
        Me.mnuClimateMethodsAdditionalWaterBalance.Size = New System.Drawing.Size(209, 22)
        Me.mnuClimateMethodsAdditionalWaterBalance.Tag = "Water_Balance"
        Me.mnuClimateMethodsAdditionalWaterBalance.Text = "Water Balance..."
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
        Me.mnuFileSave.Size = New System.Drawing.Size(204, 22)
        Me.mnuFileSave.Tag = "Save"
        Me.mnuFileSave.Text = "Save"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileSaveAsDataAs, Me.mnuFileSaveAsOutputAs, Me.mnuFileSaveAsLogAs, Me.mnuFileSaveAsScriptAs})
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(204, 22)
        Me.mnuFileSaveAs.Tag = "Save_As"
        Me.mnuFileSaveAs.Text = "Save As"
        '
        'mnuFileSaveAsDataAs
        '
        Me.mnuFileSaveAsDataAs.Name = "mnuFileSaveAsDataAs"
        Me.mnuFileSaveAsDataAs.Size = New System.Drawing.Size(211, 22)
        Me.mnuFileSaveAsDataAs.Text = "Save Data As..."
        '
        'mnuFileSaveAsOutputAs
        '
        Me.mnuFileSaveAsOutputAs.Name = "mnuFileSaveAsOutputAs"
        Me.mnuFileSaveAsOutputAs.Size = New System.Drawing.Size(211, 22)
        Me.mnuFileSaveAsOutputAs.Text = "Save Output Window As..."
        '
        'mnuFileSaveAsLogAs
        '
        Me.mnuFileSaveAsLogAs.Name = "mnuFileSaveAsLogAs"
        Me.mnuFileSaveAsLogAs.Size = New System.Drawing.Size(211, 22)
        Me.mnuFileSaveAsLogAs.Text = "Save Log As..."
        '
        'mnuFileSaveAsScriptAs
        '
        Me.mnuFileSaveAsScriptAs.Name = "mnuFileSaveAsScriptAs"
        Me.mnuFileSaveAsScriptAs.Size = New System.Drawing.Size(211, 22)
        Me.mnuFileSaveAsScriptAs.Text = "Save Script Window As..."
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.Name = "mnuFilePrint"
        Me.mnuFilePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuFilePrint.Size = New System.Drawing.Size(204, 22)
        Me.mnuFilePrint.Tag = "Print"
        Me.mnuFilePrint.Text = "Print"
        '
        'mnuFilePrintPreview
        '
        Me.mnuFilePrintPreview.Name = "mnuFilePrintPreview"
        Me.mnuFilePrintPreview.Size = New System.Drawing.Size(204, 22)
        Me.mnuFilePrintPreview.Tag = "Print_Preview"
        Me.mnuFilePrintPreview.Text = "Print Preview"
        '
        'tlSeparatorFile3
        '
        Me.tlSeparatorFile3.Name = "tlSeparatorFile3"
        Me.tlSeparatorFile3.Size = New System.Drawing.Size(201, 6)
        '
        'mnuFIleExit
        '
        Me.mnuFIleExit.Name = "mnuFIleExit"
        Me.mnuFIleExit.Size = New System.Drawing.Size(204, 22)
        Me.mnuFIleExit.Tag = "Exit"
        Me.mnuFIleExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditFind, Me.mnuEditFindNext, Me.mnuEditReplace, Me.mnuEditCut, Me.mnuEditCopy, Me.mnuEditCopySpecial, Me.mnuEditPaste, Me.mnuEditSelectAll})
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
        Me.mnuEditFind.Size = New System.Drawing.Size(183, 22)
        Me.mnuEditFind.Tag = "Find"
        Me.mnuEditFind.Text = "Find"
        '
        'mnuEditFindNext
        '
        Me.mnuEditFindNext.Enabled = False
        Me.mnuEditFindNext.Name = "mnuEditFindNext"
        Me.mnuEditFindNext.Size = New System.Drawing.Size(183, 22)
        Me.mnuEditFindNext.Text = "Find Next"
        '
        'mnuEditReplace
        '
        Me.mnuEditReplace.Enabled = False
        Me.mnuEditReplace.Name = "mnuEditReplace"
        Me.mnuEditReplace.Size = New System.Drawing.Size(183, 22)
        Me.mnuEditReplace.Tag = "Replace"
        Me.mnuEditReplace.Text = "Replace"
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Enabled = False
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(183, 22)
        Me.mnuEditCut.Tag = "Cut"
        Me.mnuEditCut.Text = "Cut"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(183, 22)
        Me.mnuEditCopy.Tag = "Copy"
        Me.mnuEditCopy.Text = "Copy"
        '
        'mnuEditCopySpecial
        '
        Me.mnuEditCopySpecial.Enabled = False
        Me.mnuEditCopySpecial.Name = "mnuEditCopySpecial"
        Me.mnuEditCopySpecial.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.mnuEditCopySpecial.Size = New System.Drawing.Size(183, 22)
        Me.mnuEditCopySpecial.Tag = "Copy_Special"
        Me.mnuEditCopySpecial.Text = "Copy Special"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Enabled = False
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(183, 22)
        Me.mnuEditPaste.Tag = "Paste"
        Me.mnuEditPaste.Text = "Paste"
        '
        'mnuEditSelectAll
        '
        Me.mnuEditSelectAll.Name = "mnuEditSelectAll"
        Me.mnuEditSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuEditSelectAll.Size = New System.Drawing.Size(183, 22)
        Me.mnuEditSelectAll.Tag = "Select_All"
        Me.mnuEditSelectAll.Text = "Select All "
        '
        'stsStrip
        '
        Me.stsStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstatus})
        Me.stsStrip.Location = New System.Drawing.Point(0, 347)
        Me.stsStrip.Name = "stsStrip"
        Me.stsStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.stsStrip.Size = New System.Drawing.Size(769, 22)
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
        Me.Tool_strip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Tool_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTbNew, Me.mnuTbOpen, Me.mnuTbSave, Me.mnuTbPrint, Me.toolStripSeparator, Me.mnuTbCut, Me.mnuTbCopy, Me.mnuTbPaste, Me.mnuTbDelete, Me.separator1, Me.EditLastDialogueToolStrip, Me.mnuTbShowLast10, Me.separator2, Me.mnuTbHelp})
        Me.Tool_strip.Location = New System.Drawing.Point(0, 24)
        Me.Tool_strip.Name = "Tool_strip"
        Me.Tool_strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Tool_strip.Size = New System.Drawing.Size(769, 25)
        Me.Tool_strip.TabIndex = 7
        Me.Tool_strip.Text = "Tool"
        '
        'mnuTbNew
        '
        Me.mnuTbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbNew.Image = CType(resources.GetObject("mnuTbNew.Image"), System.Drawing.Image)
        Me.mnuTbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbNew.Name = "mnuTbNew"
        Me.mnuTbNew.Size = New System.Drawing.Size(23, 22)
        Me.mnuTbNew.Text = "&New"
        '
        'mnuTbOpen
        '
        Me.mnuTbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbOpen.Image = CType(resources.GetObject("mnuTbOpen.Image"), System.Drawing.Image)
        Me.mnuTbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbOpen.Name = "mnuTbOpen"
        Me.mnuTbOpen.Size = New System.Drawing.Size(23, 22)
        Me.mnuTbOpen.Text = "&Open"
        '
        'mnuTbSave
        '
        Me.mnuTbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbSave.Image = CType(resources.GetObject("mnuTbSave.Image"), System.Drawing.Image)
        Me.mnuTbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbSave.Name = "mnuTbSave"
        Me.mnuTbSave.Size = New System.Drawing.Size(23, 22)
        Me.mnuTbSave.Text = "&Save"
        '
        'mnuTbPrint
        '
        Me.mnuTbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbPrint.Image = CType(resources.GetObject("mnuTbPrint.Image"), System.Drawing.Image)
        Me.mnuTbPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbPrint.Name = "mnuTbPrint"
        Me.mnuTbPrint.Size = New System.Drawing.Size(23, 22)
        Me.mnuTbPrint.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'mnuTbCut
        '
        Me.mnuTbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbCut.Enabled = False
        Me.mnuTbCut.Image = CType(resources.GetObject("mnuTbCut.Image"), System.Drawing.Image)
        Me.mnuTbCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbCut.Name = "mnuTbCut"
        Me.mnuTbCut.Size = New System.Drawing.Size(23, 22)
        Me.mnuTbCut.Text = "C&ut"
        '
        'mnuTbCopy
        '
        Me.mnuTbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbCopy.Image = CType(resources.GetObject("mnuTbCopy.Image"), System.Drawing.Image)
        Me.mnuTbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbCopy.Name = "mnuTbCopy"
        Me.mnuTbCopy.Size = New System.Drawing.Size(23, 22)
        Me.mnuTbCopy.Text = "&Copy"
        '
        'mnuTbPaste
        '
        Me.mnuTbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbPaste.Enabled = False
        Me.mnuTbPaste.Image = CType(resources.GetObject("mnuTbPaste.Image"), System.Drawing.Image)
        Me.mnuTbPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbPaste.Name = "mnuTbPaste"
        Me.mnuTbPaste.Size = New System.Drawing.Size(23, 22)
        Me.mnuTbPaste.Text = "&Paste"
        '
        'mnuTbDelete
        '
        Me.mnuTbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbDelete.Image = Global.instat.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Status_dialog_error
        Me.mnuTbDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbDelete.Name = "mnuTbDelete"
        Me.mnuTbDelete.Size = New System.Drawing.Size(23, 22)
        Me.mnuTbDelete.Text = "&Delete"
        Me.mnuTbDelete.ToolTipText = "Clears the output window"
        '
        'separator1
        '
        Me.separator1.Name = "separator1"
        Me.separator1.Size = New System.Drawing.Size(6, 25)
        '
        'EditLastDialogueToolStrip
        '
        Me.EditLastDialogueToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditLastDialogueToolStrip.Image = Global.instat.My.Resources.Resources.Paomedia_Small_N_Flat_Window_layout
        Me.EditLastDialogueToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditLastDialogueToolStrip.Name = "EditLastDialogueToolStrip"
        Me.EditLastDialogueToolStrip.Size = New System.Drawing.Size(23, 22)
        Me.EditLastDialogueToolStrip.Text = "&Edit last dialogue"
        '
        'mnuTbShowLast10
        '
        Me.mnuTbShowLast10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbShowLast10.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sepStart, Me.sepEnd})
        Me.mnuTbShowLast10.Image = Global.instat.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Actions_window_duplicate
        Me.mnuTbShowLast10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbShowLast10.Name = "mnuTbShowLast10"
        Me.mnuTbShowLast10.Size = New System.Drawing.Size(29, 22)
        Me.mnuTbShowLast10.Text = "&Show last 10 dialogues"
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
        'separator2
        '
        Me.separator2.Name = "separator2"
        Me.separator2.Size = New System.Drawing.Size(6, 25)
        '
        'mnuTbHelp
        '
        Me.mnuTbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuTbHelp.Image = CType(resources.GetObject("mnuTbHelp.Image"), System.Drawing.Image)
        Me.mnuTbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTbHelp.Name = "mnuTbHelp"
        Me.mnuTbHelp.Size = New System.Drawing.Size(23, 22)
        Me.mnuTbHelp.Text = "He&lp"
        '
        'mnuBar
        '
        Me.mnuBar.AllowMerge = False
        Me.mnuBar.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.mnuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuPrepare, Me.mnuDescribe, Me.mnuModel, Me.mnuClimatic, Me.mnuCorruption, Me.mnuTools, Me.mnuView, Me.mnuHelp})
        Me.mnuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.mnuBar.Location = New System.Drawing.Point(0, 0)
        Me.mnuBar.Name = "mnuBar"
        Me.mnuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnuBar.ShowItemToolTips = True
        Me.mnuBar.Size = New System.Drawing.Size(769, 24)
        Me.mnuBar.TabIndex = 6
        Me.mnuBar.Text = "Menu_strip"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNewDataFrame, Me.mnuFileOpenFromFile, Me.mnuFileOpenFromLibrary, Me.mnuImportFromODK, Me.ToolStripSeparator27, Me.mnuFileConvert, Me.tlSeparatorFile, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuExport, Me.mnuFilePrint, Me.mnuFilePrintPreview, Me.tlSeparatorFile3, Me.mnuFileCloseData, Me.ToolStripSeparator8, Me.mnuFIleExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Tag = "File"
        Me.mnuFile.Text = "File"
        '
        'mnuFileNewDataFrame
        '
        Me.mnuFileNewDataFrame.Name = "mnuFileNewDataFrame"
        Me.mnuFileNewDataFrame.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNewDataFrame.Size = New System.Drawing.Size(204, 22)
        Me.mnuFileNewDataFrame.Tag = "New_Data_Frame"
        Me.mnuFileNewDataFrame.Text = "New Data Frame"
        '
        'mnuFileOpenFromFile
        '
        Me.mnuFileOpenFromFile.Name = "mnuFileOpenFromFile"
        Me.mnuFileOpenFromFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpenFromFile.Size = New System.Drawing.Size(204, 22)
        Me.mnuFileOpenFromFile.Tag = "Open_From_File"
        Me.mnuFileOpenFromFile.Text = "Open From File"
        '
        'mnuFileOpenFromLibrary
        '
        Me.mnuFileOpenFromLibrary.Name = "mnuFileOpenFromLibrary"
        Me.mnuFileOpenFromLibrary.Size = New System.Drawing.Size(204, 22)
        Me.mnuFileOpenFromLibrary.Tag = "Open_From_Library"
        Me.mnuFileOpenFromLibrary.Text = "Open From Library"
        '
        'mnuImportFromODK
        '
        Me.mnuImportFromODK.Name = "mnuImportFromODK"
        Me.mnuImportFromODK.Size = New System.Drawing.Size(204, 22)
        Me.mnuImportFromODK.Text = "Import from ODK..."
        '
        'ToolStripSeparator27
        '
        Me.ToolStripSeparator27.Name = "ToolStripSeparator27"
        Me.ToolStripSeparator27.Size = New System.Drawing.Size(201, 6)
        '
        'mnuFileConvert
        '
        Me.mnuFileConvert.Name = "mnuFileConvert"
        Me.mnuFileConvert.Size = New System.Drawing.Size(204, 22)
        Me.mnuFileConvert.Text = "Convert..."
        '
        'tlSeparatorFile
        '
        Me.tlSeparatorFile.Name = "tlSeparatorFile"
        Me.tlSeparatorFile.Size = New System.Drawing.Size(201, 6)
        '
        'mnuExport
        '
        Me.mnuExport.Name = "mnuExport"
        Me.mnuExport.Size = New System.Drawing.Size(204, 22)
        Me.mnuExport.Text = "Export Data"
        '
        'mnuFileCloseData
        '
        Me.mnuFileCloseData.Enabled = False
        Me.mnuFileCloseData.Name = "mnuFileCloseData"
        Me.mnuFileCloseData.Size = New System.Drawing.Size(204, 22)
        Me.mnuFileCloseData.Text = "Close Data File"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(201, 6)
        '
        'mnuPrepare
        '
        Me.mnuPrepare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareDataFrame, Me.mnuPrepareCheckData, Me.ToolStripSeparator6, Me.mnuPrepareColumnCalculate, Me.mnuPrepareColumnGenerate, Me.mnuPrepareColumnFactor, Me.mnuPrepareColumnText, Me.mnuPrepareColumnDate, Me.mnuPrepareColumnReshape, Me.ToolStripSeparator7, Me.mnuPrepareKeysAndLinks, Me.mnuPrepareDataObject, Me.mnuPrepareRObjects})
        Me.mnuPrepare.Name = "mnuPrepare"
        Me.mnuPrepare.Size = New System.Drawing.Size(59, 20)
        Me.mnuPrepare.Tag = "Prepare"
        Me.mnuPrepare.Text = "Prepare"
        '
        'mnuPrepareDataFrame
        '
        Me.mnuPrepareDataFrame.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareDataFrameViewData, Me.mnuPrepareDataFrameRenameColumn, Me.mnuPrepareDataFrameRowNumbersNames, Me.ToolStripSeparator1, Me.mnuPrepareDataFrameSort, Me.mnuPrepareDataFrameFilter, Me.mnuPrepareDataFrameReplaceValues, Me.ToolStripSeparator2, Me.mnuPrepareDataFrameConvertColumns, Me.mnuPrepareDataFrameColumnMetadata, Me.mnuPrepareDataFrameColumnStructure, Me.ToolStripSeparator20, Me.mnuPrepareDataFrameReorderColumns, Me.mnuPrepareDataFrameInsertColumnsRows, Me.mnuPrepareDataFrameDeleteColumnsRows, Me.mnuPrepareDataFrameProtectColumn, Me.mnuPrepareDataFrameHideColumns, Me.mnuPrepareDataFrameFreezeColumns, Me.ColourByPropertyToolStripMenuItem})
        Me.mnuPrepareDataFrame.Name = "mnuPrepareDataFrame"
        Me.mnuPrepareDataFrame.Size = New System.Drawing.Size(172, 22)
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
        Me.mnuPrepareDataFrameRenameColumn.Text = "Rename Column..."
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
        'mnuPrepareDataFrameReplaceValues
        '
        Me.mnuPrepareDataFrameReplaceValues.Name = "mnuPrepareDataFrameReplaceValues"
        Me.mnuPrepareDataFrameReplaceValues.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameReplaceValues.Tag = "Replace_Values..."
        Me.mnuPrepareDataFrameReplaceValues.Text = "Replace Values..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(197, 6)
        '
        'mnuPrepareDataFrameConvertColumns
        '
        Me.mnuPrepareDataFrameConvertColumns.Name = "mnuPrepareDataFrameConvertColumns"
        Me.mnuPrepareDataFrameConvertColumns.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameConvertColumns.Tag = "Convert_Columns..."
        Me.mnuPrepareDataFrameConvertColumns.Text = "Convert Columns..."
        '
        'mnuPrepareDataFrameColumnMetadata
        '
        Me.mnuPrepareDataFrameColumnMetadata.Name = "mnuPrepareDataFrameColumnMetadata"
        Me.mnuPrepareDataFrameColumnMetadata.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameColumnMetadata.Tag = "Column_Metadata..."
        Me.mnuPrepareDataFrameColumnMetadata.Text = "Column Metadata..."
        '
        'mnuPrepareDataFrameColumnStructure
        '
        Me.mnuPrepareDataFrameColumnStructure.Name = "mnuPrepareDataFrameColumnStructure"
        Me.mnuPrepareDataFrameColumnStructure.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameColumnStructure.Tag = "Column_Structure..."
        Me.mnuPrepareDataFrameColumnStructure.Text = "Column Structure..."
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(197, 6)
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
        '
        'mnuPrepareDataFrameHideColumns
        '
        Me.mnuPrepareDataFrameHideColumns.Name = "mnuPrepareDataFrameHideColumns"
        Me.mnuPrepareDataFrameHideColumns.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameHideColumns.Tag = "Hide_Columns..."
        Me.mnuPrepareDataFrameHideColumns.Text = "Hide Columns..."
        '
        'mnuPrepareDataFrameFreezeColumns
        '
        Me.mnuPrepareDataFrameFreezeColumns.Enabled = False
        Me.mnuPrepareDataFrameFreezeColumns.Name = "mnuPrepareDataFrameFreezeColumns"
        Me.mnuPrepareDataFrameFreezeColumns.Size = New System.Drawing.Size(200, 22)
        Me.mnuPrepareDataFrameFreezeColumns.Tag = "Freeze_Columns..."
        Me.mnuPrepareDataFrameFreezeColumns.Text = "Freeze Columns..."
        '
        'ColourByPropertyToolStripMenuItem
        '
        Me.ColourByPropertyToolStripMenuItem.Name = "ColourByPropertyToolStripMenuItem"
        Me.ColourByPropertyToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ColourByPropertyToolStripMenuItem.Text = "Colour by Property..."
        '
        'mnuPrepareCheckData
        '
        Me.mnuPrepareCheckData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuPrepareCheckData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPreparePrepareToShareJitter, Me.mnuPrepareCheckDataExportOpenRefine, Me.mnuPrepareCheckDataImportOpenRefine, Me.mnuCheckDataPrePareToShareSdcPackage})
        Me.mnuPrepareCheckData.Name = "mnuPrepareCheckData"
        Me.mnuPrepareCheckData.Size = New System.Drawing.Size(172, 22)
        Me.mnuPrepareCheckData.Text = "Check Data"
        '
        'mnuPreparePrepareToShareJitter
        '
        Me.mnuPreparePrepareToShareJitter.Name = "mnuPreparePrepareToShareJitter"
        Me.mnuPreparePrepareToShareJitter.Size = New System.Drawing.Size(245, 22)
        Me.mnuPreparePrepareToShareJitter.Text = "Jitter..."
        '
        'mnuPrepareCheckDataExportOpenRefine
        '
        Me.mnuPrepareCheckDataExportOpenRefine.Name = "mnuPrepareCheckDataExportOpenRefine"
        Me.mnuPrepareCheckDataExportOpenRefine.Size = New System.Drawing.Size(245, 22)
        Me.mnuPrepareCheckDataExportOpenRefine.Text = "Export To OpenRefine..."
        '
        'mnuPrepareCheckDataImportOpenRefine
        '
        Me.mnuPrepareCheckDataImportOpenRefine.Enabled = False
        Me.mnuPrepareCheckDataImportOpenRefine.Name = "mnuPrepareCheckDataImportOpenRefine"
        Me.mnuPrepareCheckDataImportOpenRefine.Size = New System.Drawing.Size(245, 22)
        Me.mnuPrepareCheckDataImportOpenRefine.Text = "Import From OpenRefine..."
        '
        'mnuCheckDataPrePareToShareSdcPackage
        '
        Me.mnuCheckDataPrePareToShareSdcPackage.Enabled = False
        Me.mnuCheckDataPrePareToShareSdcPackage.Name = "mnuCheckDataPrePareToShareSdcPackage"
        Me.mnuCheckDataPrePareToShareSdcPackage.Size = New System.Drawing.Size(245, 22)
        Me.mnuCheckDataPrePareToShareSdcPackage.Text = "Prepare to Share (sdc package)..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(169, 6)
        '
        'mnuPrepareColumnCalculate
        '
        Me.mnuPrepareColumnCalculate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnCalculateCalculations, Me.ToolStripSeparator24, Me.mnuPrepareCalculateDuplicateColumn, Me.mnuPrepareColumnCalculateTransform, Me.mnuPrepareColumnCalculateRank, Me.mnuPrepareColumnCalculatePolynomials, Me.mnuPrepareColumnCalculateRowSummary})
        Me.mnuPrepareColumnCalculate.Name = "mnuPrepareColumnCalculate"
        Me.mnuPrepareColumnCalculate.Size = New System.Drawing.Size(172, 22)
        Me.mnuPrepareColumnCalculate.Tag = "Column:_Calculate"
        Me.mnuPrepareColumnCalculate.Text = "Column: Calculate"
        '
        'mnuPrepareColumnCalculateCalculations
        '
        Me.mnuPrepareColumnCalculateCalculations.Name = "mnuPrepareColumnCalculateCalculations"
        Me.mnuPrepareColumnCalculateCalculations.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnCalculateCalculations.Tag = "Calculations..."
        Me.mnuPrepareColumnCalculateCalculations.Text = "Calculations..."
        '
        'ToolStripSeparator24
        '
        Me.ToolStripSeparator24.Name = "ToolStripSeparator24"
        Me.ToolStripSeparator24.Size = New System.Drawing.Size(176, 6)
        '
        'mnuPrepareCalculateDuplicateColumn
        '
        Me.mnuPrepareCalculateDuplicateColumn.Name = "mnuPrepareCalculateDuplicateColumn"
        Me.mnuPrepareCalculateDuplicateColumn.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareCalculateDuplicateColumn.Text = "Duplicate Column..."
        '
        'mnuPrepareColumnCalculateTransform
        '
        Me.mnuPrepareColumnCalculateTransform.Enabled = False
        Me.mnuPrepareColumnCalculateTransform.Name = "mnuPrepareColumnCalculateTransform"
        Me.mnuPrepareColumnCalculateTransform.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnCalculateTransform.Tag = "..."
        Me.mnuPrepareColumnCalculateTransform.Text = "Transform..."
        '
        'mnuPrepareColumnCalculateRank
        '
        Me.mnuPrepareColumnCalculateRank.Name = "mnuPrepareColumnCalculateRank"
        Me.mnuPrepareColumnCalculateRank.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnCalculateRank.Tag = "Rank..."
        Me.mnuPrepareColumnCalculateRank.Text = "Rank..."
        '
        'mnuPrepareColumnCalculatePolynomials
        '
        Me.mnuPrepareColumnCalculatePolynomials.Name = "mnuPrepareColumnCalculatePolynomials"
        Me.mnuPrepareColumnCalculatePolynomials.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnCalculatePolynomials.Tag = "Polynomials..."
        Me.mnuPrepareColumnCalculatePolynomials.Text = "Polynomials..."
        '
        'mnuPrepareColumnCalculateRowSummary
        '
        Me.mnuPrepareColumnCalculateRowSummary.Name = "mnuPrepareColumnCalculateRowSummary"
        Me.mnuPrepareColumnCalculateRowSummary.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnCalculateRowSummary.Tag = "Row_Summary..."
        Me.mnuPrepareColumnCalculateRowSummary.Text = "Row Summary..."
        '
        'mnuPrepareColumnGenerate
        '
        Me.mnuPrepareColumnGenerate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnGenerateRegularSequence, Me.mnuPrepareColumnGenerateCountInFactor, Me.ToolStripSeparator25, Me.mnuPrepareColumnGenerateEnter, Me.mnuPrepareColumnGenerateRandomSamples, Me.mnuPrepareColumnGeneratePermuteRows})
        Me.mnuPrepareColumnGenerate.Name = "mnuPrepareColumnGenerate"
        Me.mnuPrepareColumnGenerate.Size = New System.Drawing.Size(172, 22)
        Me.mnuPrepareColumnGenerate.Tag = "Column:_Generate"
        Me.mnuPrepareColumnGenerate.Text = "Column: Generate"
        '
        'mnuPrepareColumnGenerateRegularSequence
        '
        Me.mnuPrepareColumnGenerateRegularSequence.Name = "mnuPrepareColumnGenerateRegularSequence"
        Me.mnuPrepareColumnGenerateRegularSequence.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnGenerateRegularSequence.Tag = "Regular_Sequence..."
        Me.mnuPrepareColumnGenerateRegularSequence.Text = "Regular Sequence..."
        '
        'mnuPrepareColumnGenerateCountInFactor
        '
        Me.mnuPrepareColumnGenerateCountInFactor.Name = "mnuPrepareColumnGenerateCountInFactor"
        Me.mnuPrepareColumnGenerateCountInFactor.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnGenerateCountInFactor.Text = "Count in Factor..."
        '
        'ToolStripSeparator25
        '
        Me.ToolStripSeparator25.Name = "ToolStripSeparator25"
        Me.ToolStripSeparator25.Size = New System.Drawing.Size(176, 6)
        '
        'mnuPrepareColumnGenerateEnter
        '
        Me.mnuPrepareColumnGenerateEnter.Name = "mnuPrepareColumnGenerateEnter"
        Me.mnuPrepareColumnGenerateEnter.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnGenerateEnter.Text = "Enter..."
        '
        'mnuPrepareColumnGenerateRandomSamples
        '
        Me.mnuPrepareColumnGenerateRandomSamples.Name = "mnuPrepareColumnGenerateRandomSamples"
        Me.mnuPrepareColumnGenerateRandomSamples.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnGenerateRandomSamples.Tag = "Random_Samples..."
        Me.mnuPrepareColumnGenerateRandomSamples.Text = "Random Samples..."
        '
        'mnuPrepareColumnGeneratePermuteRows
        '
        Me.mnuPrepareColumnGeneratePermuteRows.Name = "mnuPrepareColumnGeneratePermuteRows"
        Me.mnuPrepareColumnGeneratePermuteRows.Size = New System.Drawing.Size(179, 22)
        Me.mnuPrepareColumnGeneratePermuteRows.Tag = "Permute_Rows..."
        Me.mnuPrepareColumnGeneratePermuteRows.Text = "Permute Columns..."
        '
        'mnuPrepareColumnFactor
        '
        Me.mnuPrepareColumnFactor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnFactorConvertToFactor, Me.mnuPrepareColumnFactorRecodeNumeric, Me.ToolStripSeparator12, Me.mnuPrepareColumnFactorRecodeFactor, Me.mnuPrepareColumnFactorCombineFactors, Me.mnuPrepareColumnFactorDummyVariables, Me.ToolStripSeparator14, Me.mnuPrepareColumnFactorLevelsLabels, Me.mnuPrepareColumnFactorReorderLevels, Me.mnuPrepareColumnFactorReferenceLevel, Me.mnuPrepareColumnFactorUnusedLevels, Me.mnuPrepareColumnFactorContrasts, Me.ToolStripSeparator19, Me.mnuPrepareColumnFactorFactorDataFrame})
        Me.mnuPrepareColumnFactor.Name = "mnuPrepareColumnFactor"
        Me.mnuPrepareColumnFactor.Size = New System.Drawing.Size(172, 22)
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
        Me.mnuPrepareColumnText.Size = New System.Drawing.Size(172, 22)
        Me.mnuPrepareColumnText.Tag = "Column:_Text"
        Me.mnuPrepareColumnText.Text = "Column: Text"
        '
        'mnuPrepareColumnTextFindReplace
        '
        Me.mnuPrepareColumnTextFindReplace.Enabled = False
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
        '
        'mnuPrepareColumnTextDistance
        '
        Me.mnuPrepareColumnTextDistance.Enabled = False
        Me.mnuPrepareColumnTextDistance.Name = "mnuPrepareColumnTextDistance"
        Me.mnuPrepareColumnTextDistance.Size = New System.Drawing.Size(152, 22)
        Me.mnuPrepareColumnTextDistance.Tag = "Distance..."
        Me.mnuPrepareColumnTextDistance.Text = "Distance..."
        '
        'mnuPrepareColumnDate
        '
        Me.mnuPrepareColumnDate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnGenerateDate, Me.mnuPrepareColumnMakeDate, Me.mnuPrepareColumnUseDate, Me.mnuPrepareColumnMakeTime, Me.mnuPrepareColumnUseTime})
        Me.mnuPrepareColumnDate.Name = "mnuPrepareColumnDate"
        Me.mnuPrepareColumnDate.Size = New System.Drawing.Size(172, 22)
        Me.mnuPrepareColumnDate.Text = "Column: Date"
        '
        'mnuPrepareColumnGenerateDate
        '
        Me.mnuPrepareColumnGenerateDate.Enabled = False
        Me.mnuPrepareColumnGenerateDate.Name = "mnuPrepareColumnGenerateDate"
        Me.mnuPrepareColumnGenerateDate.Size = New System.Drawing.Size(162, 22)
        Me.mnuPrepareColumnGenerateDate.Text = "Generate Dates..."
        '
        'mnuPrepareColumnMakeDate
        '
        Me.mnuPrepareColumnMakeDate.Name = "mnuPrepareColumnMakeDate"
        Me.mnuPrepareColumnMakeDate.Size = New System.Drawing.Size(162, 22)
        Me.mnuPrepareColumnMakeDate.Text = "Make Date..."
        '
        'mnuPrepareColumnUseDate
        '
        Me.mnuPrepareColumnUseDate.Name = "mnuPrepareColumnUseDate"
        Me.mnuPrepareColumnUseDate.Size = New System.Drawing.Size(162, 22)
        Me.mnuPrepareColumnUseDate.Text = "Use Date..."
        '
        'mnuPrepareColumnMakeTime
        '
        Me.mnuPrepareColumnMakeTime.Enabled = False
        Me.mnuPrepareColumnMakeTime.Name = "mnuPrepareColumnMakeTime"
        Me.mnuPrepareColumnMakeTime.Size = New System.Drawing.Size(162, 22)
        Me.mnuPrepareColumnMakeTime.Text = "Make Time..."
        '
        'mnuPrepareColumnUseTime
        '
        Me.mnuPrepareColumnUseTime.Enabled = False
        Me.mnuPrepareColumnUseTime.Name = "mnuPrepareColumnUseTime"
        Me.mnuPrepareColumnUseTime.Size = New System.Drawing.Size(162, 22)
        Me.mnuPrepareColumnUseTime.Text = "Use Time..."
        '
        'mnuPrepareColumnReshape
        '
        Me.mnuPrepareColumnReshape.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareColumnReshapeColumnSummaries, Me.mnuPrepareColumnReshapeGeneralSummaries, Me.ToolStripSeparator10, Me.mnuPrepareColumnReshapeStack, Me.mnuPrepareColumnReshapeUnstack, Me.mnuPrepareColumnReshapeMerge, Me.ToolStripSeparator11, Me.mnuPrepareAppendDataFrame, Me.mnuPrepareColumnReshapeSubset, Me.mnuPrepareColumnReshapeRandomSubset, Me.mnuPrepareColumnReshapeTranspose})
        Me.mnuPrepareColumnReshape.Name = "mnuPrepareColumnReshape"
        Me.mnuPrepareColumnReshape.Size = New System.Drawing.Size(172, 22)
        Me.mnuPrepareColumnReshape.Tag = "Column:_Reshape"
        Me.mnuPrepareColumnReshape.Text = "Column: Reshape"
        '
        'mnuPrepareColumnReshapeColumnSummaries
        '
        Me.mnuPrepareColumnReshapeColumnSummaries.Name = "mnuPrepareColumnReshapeColumnSummaries"
        Me.mnuPrepareColumnReshapeColumnSummaries.Size = New System.Drawing.Size(193, 22)
        Me.mnuPrepareColumnReshapeColumnSummaries.Tag = "Column_Summaries..."
        Me.mnuPrepareColumnReshapeColumnSummaries.Text = "Column Summaries..."
        '
        'mnuPrepareColumnReshapeGeneralSummaries
        '
        Me.mnuPrepareColumnReshapeGeneralSummaries.Name = "mnuPrepareColumnReshapeGeneralSummaries"
        Me.mnuPrepareColumnReshapeGeneralSummaries.Size = New System.Drawing.Size(193, 22)
        Me.mnuPrepareColumnReshapeGeneralSummaries.Text = "General Summaries..."
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(190, 6)
        '
        'mnuPrepareColumnReshapeStack
        '
        Me.mnuPrepareColumnReshapeStack.Name = "mnuPrepareColumnReshapeStack"
        Me.mnuPrepareColumnReshapeStack.Size = New System.Drawing.Size(193, 22)
        Me.mnuPrepareColumnReshapeStack.Tag = "Stack..."
        Me.mnuPrepareColumnReshapeStack.Text = "Stack..."
        '
        'mnuPrepareColumnReshapeUnstack
        '
        Me.mnuPrepareColumnReshapeUnstack.Name = "mnuPrepareColumnReshapeUnstack"
        Me.mnuPrepareColumnReshapeUnstack.Size = New System.Drawing.Size(193, 22)
        Me.mnuPrepareColumnReshapeUnstack.Tag = "Unstack..."
        Me.mnuPrepareColumnReshapeUnstack.Text = "Unstack..."
        '
        'mnuPrepareColumnReshapeMerge
        '
        Me.mnuPrepareColumnReshapeMerge.Name = "mnuPrepareColumnReshapeMerge"
        Me.mnuPrepareColumnReshapeMerge.Size = New System.Drawing.Size(193, 22)
        Me.mnuPrepareColumnReshapeMerge.Tag = "Merge..."
        Me.mnuPrepareColumnReshapeMerge.Text = "Merge..."
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(190, 6)
        '
        'mnuPrepareAppendDataFrame
        '
        Me.mnuPrepareAppendDataFrame.Name = "mnuPrepareAppendDataFrame"
        Me.mnuPrepareAppendDataFrame.Size = New System.Drawing.Size(193, 22)
        Me.mnuPrepareAppendDataFrame.Text = "Append Data Frames..."
        '
        'mnuPrepareColumnReshapeSubset
        '
        Me.mnuPrepareColumnReshapeSubset.Name = "mnuPrepareColumnReshapeSubset"
        Me.mnuPrepareColumnReshapeSubset.Size = New System.Drawing.Size(193, 22)
        Me.mnuPrepareColumnReshapeSubset.Tag = "Subset..."
        Me.mnuPrepareColumnReshapeSubset.Text = "Subset..."
        '
        'mnuPrepareColumnReshapeRandomSubset
        '
        Me.mnuPrepareColumnReshapeRandomSubset.Name = "mnuPrepareColumnReshapeRandomSubset"
        Me.mnuPrepareColumnReshapeRandomSubset.Size = New System.Drawing.Size(193, 22)
        Me.mnuPrepareColumnReshapeRandomSubset.Tag = "Random_Subset..."
        Me.mnuPrepareColumnReshapeRandomSubset.Text = "Random Subset..."
        '
        'mnuPrepareColumnReshapeTranspose
        '
        Me.mnuPrepareColumnReshapeTranspose.Name = "mnuPrepareColumnReshapeTranspose"
        Me.mnuPrepareColumnReshapeTranspose.Size = New System.Drawing.Size(193, 22)
        Me.mnuPrepareColumnReshapeTranspose.Tag = "Transpose..."
        Me.mnuPrepareColumnReshapeTranspose.Text = "Transpose..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(169, 6)
        '
        'mnuPrepareKeysAndLinks
        '
        Me.mnuPrepareKeysAndLinks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareKeysAndLinksAddKey, Me.mnuPrepareKeysAndLinksViewAndRemoveKey, Me.mnuPrepareKeysAndLinksAddLink, Me.mnuPrepareKeysAndLinksViewAndRemoveKeys, Me.mnuPrepareKeysAndLinksAddComment})
        Me.mnuPrepareKeysAndLinks.Name = "mnuPrepareKeysAndLinks"
        Me.mnuPrepareKeysAndLinks.Size = New System.Drawing.Size(172, 22)
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
        Me.mnuPrepareKeysAndLinksAddComment.Text = "Add comment..."
        '
        'mnuPrepareDataObject
        '
        Me.mnuPrepareDataObject.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareDataObjectDataFrameMetadata, Me.mnuPrepareDataObjectRenameDataFrame, Me.mnuPrepareDataObjectReorderDataFrames, Me.mnuPrepareDataObjectCopyDataFrame, Me.mnuPrepareDataObjectDeleteDataFrame, Me.ToolStripSeparator21, Me.mnuPrepareDataObjectHideDataframes, Me.mnuPrepareDataObjectMetadata, Me.mnuPrepareDataObjectRenameMetadata, Me.mnuPrepareDataObjectReorderMetadata, Me.mnuPrepareDataObjectDeleteMetadata})
        Me.mnuPrepareDataObject.Name = "mnuPrepareDataObject"
        Me.mnuPrepareDataObject.Size = New System.Drawing.Size(172, 22)
        Me.mnuPrepareDataObject.Tag = "Data_Object"
        Me.mnuPrepareDataObject.Text = "Data Object"
        '
        'mnuPrepareDataObjectDataFrameMetadata
        '
        Me.mnuPrepareDataObjectDataFrameMetadata.Enabled = False
        Me.mnuPrepareDataObjectDataFrameMetadata.Name = "mnuPrepareDataObjectDataFrameMetadata"
        Me.mnuPrepareDataObjectDataFrameMetadata.Size = New System.Drawing.Size(196, 22)
        Me.mnuPrepareDataObjectDataFrameMetadata.Tag = "Data_Frame_Metadata..."
        Me.mnuPrepareDataObjectDataFrameMetadata.Text = "Data Frame Metadata..."
        '
        'mnuPrepareDataObjectRenameDataFrame
        '
        Me.mnuPrepareDataObjectRenameDataFrame.Name = "mnuPrepareDataObjectRenameDataFrame"
        Me.mnuPrepareDataObjectRenameDataFrame.Size = New System.Drawing.Size(196, 22)
        Me.mnuPrepareDataObjectRenameDataFrame.Tag = "ReName_Data_Frame..."
        Me.mnuPrepareDataObjectRenameDataFrame.Text = "Rename Data Frame..."
        '
        'mnuPrepareDataObjectReorderDataFrames
        '
        Me.mnuPrepareDataObjectReorderDataFrames.Enabled = False
        Me.mnuPrepareDataObjectReorderDataFrames.Name = "mnuPrepareDataObjectReorderDataFrames"
        Me.mnuPrepareDataObjectReorderDataFrames.Size = New System.Drawing.Size(196, 22)
        Me.mnuPrepareDataObjectReorderDataFrames.Tag = "Reorder_Data_Frames..."
        Me.mnuPrepareDataObjectReorderDataFrames.Text = "Reorder Data Frames..."
        '
        'mnuPrepareDataObjectCopyDataFrame
        '
        Me.mnuPrepareDataObjectCopyDataFrame.Name = "mnuPrepareDataObjectCopyDataFrame"
        Me.mnuPrepareDataObjectCopyDataFrame.Size = New System.Drawing.Size(196, 22)
        Me.mnuPrepareDataObjectCopyDataFrame.Tag = "Copy_Data_Frame..."
        Me.mnuPrepareDataObjectCopyDataFrame.Text = "Copy Data Frame..."
        '
        'mnuPrepareDataObjectDeleteDataFrame
        '
        Me.mnuPrepareDataObjectDeleteDataFrame.Name = "mnuPrepareDataObjectDeleteDataFrame"
        Me.mnuPrepareDataObjectDeleteDataFrame.Size = New System.Drawing.Size(196, 22)
        Me.mnuPrepareDataObjectDeleteDataFrame.Tag = "Delete_Data_Frame..."
        Me.mnuPrepareDataObjectDeleteDataFrame.Text = "Delete Data Frame..."
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(193, 6)
        '
        'mnuPrepareDataObjectHideDataframes
        '
        Me.mnuPrepareDataObjectHideDataframes.Enabled = False
        Me.mnuPrepareDataObjectHideDataframes.Name = "mnuPrepareDataObjectHideDataframes"
        Me.mnuPrepareDataObjectHideDataframes.Size = New System.Drawing.Size(196, 22)
        Me.mnuPrepareDataObjectHideDataframes.Text = "Hide Dataframes..."
        '
        'mnuPrepareDataObjectMetadata
        '
        Me.mnuPrepareDataObjectMetadata.Name = "mnuPrepareDataObjectMetadata"
        Me.mnuPrepareDataObjectMetadata.Size = New System.Drawing.Size(196, 22)
        Me.mnuPrepareDataObjectMetadata.Tag = "Metadata..."
        Me.mnuPrepareDataObjectMetadata.Text = "Metadata..."
        '
        'mnuPrepareDataObjectRenameMetadata
        '
        Me.mnuPrepareDataObjectRenameMetadata.Enabled = False
        Me.mnuPrepareDataObjectRenameMetadata.Name = "mnuPrepareDataObjectRenameMetadata"
        Me.mnuPrepareDataObjectRenameMetadata.Size = New System.Drawing.Size(196, 22)
        Me.mnuPrepareDataObjectRenameMetadata.Tag = "Rename_Metadata..."
        Me.mnuPrepareDataObjectRenameMetadata.Text = "Rename Metadata..."
        '
        'mnuPrepareDataObjectReorderMetadata
        '
        Me.mnuPrepareDataObjectReorderMetadata.Enabled = False
        Me.mnuPrepareDataObjectReorderMetadata.Name = "mnuPrepareDataObjectReorderMetadata"
        Me.mnuPrepareDataObjectReorderMetadata.Size = New System.Drawing.Size(196, 22)
        Me.mnuPrepareDataObjectReorderMetadata.Tag = "Reorder_Metadata..."
        Me.mnuPrepareDataObjectReorderMetadata.Text = "Reorder Metadata..."
        '
        'mnuPrepareDataObjectDeleteMetadata
        '
        Me.mnuPrepareDataObjectDeleteMetadata.Enabled = False
        Me.mnuPrepareDataObjectDeleteMetadata.Name = "mnuPrepareDataObjectDeleteMetadata"
        Me.mnuPrepareDataObjectDeleteMetadata.Size = New System.Drawing.Size(196, 22)
        Me.mnuPrepareDataObjectDeleteMetadata.Tag = "Delete_Metadata..."
        Me.mnuPrepareDataObjectDeleteMetadata.Text = "Delete Metadata..."
        '
        'mnuPrepareRObjects
        '
        Me.mnuPrepareRObjects.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrepareRObjectsView, Me.mnuPrepareRObjectsRename, Me.mnuPrepareRObjectsReorder, Me.mnuPrepareRObjectsDelete})
        Me.mnuPrepareRObjects.Name = "mnuPrepareRObjects"
        Me.mnuPrepareRObjects.Size = New System.Drawing.Size(172, 22)
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
        'mnuCorruption
        '
        Me.mnuCorruption.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCorruptionFile, Me.mnuCorruptionDefineCorruptionData, Me.mnuCorruptionPrepare, Me.mnuCorruptionDescribe, Me.mnuCorruptionModel})
        Me.mnuCorruption.Name = "mnuCorruption"
        Me.mnuCorruption.Size = New System.Drawing.Size(77, 20)
        Me.mnuCorruption.Text = "Corruption"
        '
        'mnuCorruptionFile
        '
        Me.mnuCorruptionFile.Name = "mnuCorruptionFile"
        Me.mnuCorruptionFile.Size = New System.Drawing.Size(205, 22)
        Me.mnuCorruptionFile.Text = "File..."
        '
        'mnuCorruptionDefineCorruptionData
        '
        Me.mnuCorruptionDefineCorruptionData.Name = "mnuCorruptionDefineCorruptionData"
        Me.mnuCorruptionDefineCorruptionData.Size = New System.Drawing.Size(205, 22)
        Me.mnuCorruptionDefineCorruptionData.Text = "Define Corruption Data..."
        '
        'mnuCorruptionPrepare
        '
        Me.mnuCorruptionPrepare.Name = "mnuCorruptionPrepare"
        Me.mnuCorruptionPrepare.Size = New System.Drawing.Size(205, 22)
        Me.mnuCorruptionPrepare.Text = "Prepare..."
        '
        'mnuCorruptionDescribe
        '
        Me.mnuCorruptionDescribe.Name = "mnuCorruptionDescribe"
        Me.mnuCorruptionDescribe.Size = New System.Drawing.Size(205, 22)
        Me.mnuCorruptionDescribe.Text = "Describe..."
        '
        'mnuCorruptionModel
        '
        Me.mnuCorruptionModel.Name = "mnuCorruptionModel"
        Me.mnuCorruptionModel.Size = New System.Drawing.Size(205, 22)
        Me.mnuCorruptionModel.Text = "Model..."
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuToolsRunRCode, Me.mnuToolsRestartR, Me.mnuToolsCheckForUpdates, Me.mnuToolsClearOutputWindow, Me.ToolStripSeparator5, Me.mnuToolsSaveCurrentOptions, Me.mnuToolsLoadOptions, Me.mnuToolsOptions})
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(47, 20)
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
        'mnuToolsOptions
        '
        Me.mnuToolsOptions.Name = "mnuToolsOptions"
        Me.mnuToolsOptions.Size = New System.Drawing.Size(198, 22)
        Me.mnuToolsOptions.Tag = "Options..."
        Me.mnuToolsOptions.Text = "Options..."
        '
        'mnuClimaticSCFSupportCumulativeExceedanceGraphs
        '
        Me.mnuClimaticSCFSupportCumulativeExceedanceGraphs.Name = "mnuClimaticSCFSupportCumulativeExceedanceGraphs"
        Me.mnuClimaticSCFSupportCumulativeExceedanceGraphs.Size = New System.Drawing.Size(250, 22)
        Me.mnuClimaticSCFSupportCumulativeExceedanceGraphs.Text = "Cumulative/Exceedance Graphs..."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 369)
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
    Friend WithEvents mnuTbNew As ToolStripButton
    Friend WithEvents mnuTbOpen As ToolStripButton
    Friend WithEvents mnuTbSave As ToolStripButton
    Friend WithEvents mnuTbPrint As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents mnuTbCut As ToolStripButton
    Friend WithEvents mnuTbCopy As ToolStripButton
    Friend WithEvents mnuTbPaste As ToolStripButton
    Friend WithEvents mnuTbDelete As ToolStripButton
    Friend WithEvents separator1 As ToolStripSeparator
    Friend WithEvents EditLastDialogueToolStrip As ToolStripButton
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
    Friend WithEvents mnuTbShowLast10 As ToolStripDropDownButton
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
    Friend WithEvents mnuViewCascade As ToolStripMenuItem
    Friend WithEvents mnuViewTileVertically As ToolStripMenuItem
    Friend WithEvents mnuViewTileHorizontally As ToolStripMenuItem
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
    Friend WithEvents mnuClimaticPrepareSpecificEvents As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareEventsStartoftheRains As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareEventsSpells As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareEventsWaterBalance As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareEventsEndoftheRains As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator26 As ToolStripSeparator
    Friend WithEvents mnuDescribeSpecificScatterPlot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificLinePlot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificHistogram As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificBoxplot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificDotPlot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificRugPlot As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificBarChart As ToolStripMenuItem
    Friend WithEvents mnuDescribeSpecificBarChartFromSummary As ToolStripMenuItem
    Friend WithEvents mnuDescribeMoreGraphs As ToolStripMenuItem
    Friend WithEvents mnuDescribeOtherGraphicsDialogsWindRose As ToolStripMenuItem
    Friend WithEvents mnuDescribeOtherGraphicsDialogsCumulativeDistribution As ToolStripMenuItem
    Friend WithEvents mnuDescribeOtherGraphicsDialogsInventoryPlot As ToolStripMenuItem
    Friend WithEvents mnuDescribeOtherGraphicsDialogsPopulationPyramid As ToolStripMenuItem
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
    Friend WithEvents mnuClimaticPrepareDates As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareDatesGenerateDates As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareDatesMakeDate As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareDatesUseDate As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareDatesMakeTime As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareDatesUseTime As ToolStripMenuItem
    Friend WithEvents mnuClimaticQualityControl As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator30 As ToolStripSeparator
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
    Friend WithEvents mnuClimaticMoreGraphs As ToolStripMenuItem
    Friend WithEvents mnuClimaticDescribeMoreGraphsWindoRose As ToolStripMenuItem
    Friend WithEvents mnuClimaticDescribeMoreGraphsCummulaiveDistribution As ToolStripMenuItem
    Friend WithEvents mnuClimaticSCFSupportExporttoCPT As ToolStripMenuItem
    Friend WithEvents mnuClimaticSCFSupportOpenSST As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator31 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator32 As ToolStripSeparator
    Friend WithEvents mnuClimaticSCFSupportCorrelations As ToolStripMenuItem
    Friend WithEvents mnuClimaticSCFSupportPrincipalComponents As ToolStripMenuItem
    Friend WithEvents mnuClimaticSCFSupportCanonicalCorrelations As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareUnstackDailyData As ToolStripMenuItem
    Friend WithEvents mnuCliDefineClimaticData As ToolStripMenuItem
    Friend WithEvents mnuPrepareCalculateDuplicateColumn As ToolStripMenuItem
    Friend WithEvents mnuCorruption As ToolStripMenuItem
    Friend WithEvents mnuCorruptionFile As ToolStripMenuItem
    Friend WithEvents mnuCorruptionPrepare As ToolStripMenuItem
    Friend WithEvents mnuCorruptionDescribe As ToolStripMenuItem
    Friend WithEvents mnuCorruptionModel As ToolStripMenuItem
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
    Friend WithEvents mnuClimaticPrepareInfillMissingDates As ToolStripMenuItem
    Friend WithEvents mnuClimaticPrepareClimaticSummaries As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayDailyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QCProceduresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As ToolStripSeparator
    Friend WithEvents Extremes As ToolStripMenuItem
    Friend WithEvents mnuCorruptionDefineCorruptionData As ToolStripMenuItem
    Friend WithEvents mnuClimaticSCFSupportCumulativeExceedanceGraphs As ToolStripMenuItem
End Class
