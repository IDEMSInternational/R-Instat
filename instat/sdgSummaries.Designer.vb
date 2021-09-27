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
Partial Class sdgSummaries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgSummaries))
        Me.tbCircular = New System.Windows.Forms.TabPage()
        Me.grpCircScale = New System.Windows.Forms.GroupBox()
        Me.ucrChkCircRange = New instat.ucrCheck()
        Me.ucrChkAngVar = New instat.ucrCheck()
        Me.ucrChkrho = New instat.ucrCheck()
        Me.ucrChkAngDev = New instat.ucrCheck()
        Me.ucrChkVar = New instat.ucrCheck()
        Me.ucrChkSd = New instat.ucrCheck()
        Me.grpCircLocation = New System.Windows.Forms.GroupBox()
        Me.ucrChkCircMedian = New instat.ucrCheck()
        Me.ucrChkMin = New instat.ucrCheck()
        Me.ucrChkMedianH = New instat.ucrCheck()
        Me.ucrChkQ3 = New instat.ucrCheck()
        Me.ucrChkQ1 = New instat.ucrCheck()
        Me.ucrChkMax = New instat.ucrCheck()
        Me.ucrChkCircMean = New instat.ucrCheck()
        Me.tbModel = New System.Windows.Forms.TabPage()
        Me.ucrChkStandardErrorOfMean = New instat.ucrCheck()
        Me.tbPosition = New System.Windows.Forms.TabPage()
        Me.ucrChkOrderBy = New instat.ucrCheck()
        Me.lblOrderBy = New System.Windows.Forms.Label()
        Me.grpPosition = New System.Windows.Forms.GroupBox()
        Me.ucrChkSetseed = New instat.ucrCheck()
        Me.ucrNudSeed = New instat.ucrNud()
        Me.ucrChkSample = New instat.ucrCheck()
        Me.ucrInputN = New instat.ucrInputTextBox()
        Me.lblInputN = New System.Windows.Forms.Label()
        Me.ucrChkFirst = New instat.ucrCheck()
        Me.ucrChkLast = New instat.ucrCheck()
        Me.ucrChknth = New instat.ucrCheck()
        Me.ucrSelectorOrderBy = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverOrderBy = New instat.ucrReceiverSingle()
        Me.tbTwoVariables = New System.Windows.Forms.TabPage()
        Me.lblSecondVariable = New System.Windows.Forms.Label()
        Me.grpRelationships = New System.Windows.Forms.GroupBox()
        Me.ucrChkCovariance = New instat.ucrCheck()
        Me.ucrChkCorrelations = New instat.ucrCheck()
        Me.grpHyroGOF = New System.Windows.Forms.GroupBox()
        Me.lblJmia = New System.Windows.Forms.Label()
        Me.ucrInputJmia = New instat.ucrInputTextBox()
        Me.ucrChkSelectAll = New instat.ucrCheck()
        Me.ucrChkRelativeIndexOfAgreement = New instat.ucrCheck()
        Me.ucrChkRatioOfStandardDeviation = New instat.ucrCheck()
        Me.ucrChkCoefDetermination = New instat.ucrCheck()
        Me.ucrChkRatioOfRootMeanSquaredError = New instat.ucrCheck()
        Me.ucrChkRelativeNashSutcliffeEff = New instat.ucrCheck()
        Me.ucrChkModifiedIndexOfAgreement = New instat.ucrCheck()
        Me.ucrChkCoefPersistence = New instat.ucrCheck()
        Me.ucrChkNashSutcliffeEfficiency = New instat.ucrCheck()
        Me.ucrChkSumOfSquaredResiduals = New instat.ucrCheck()
        Me.ucrChkKlingGuptaEfficiency = New instat.ucrCheck()
        Me.ucrChkVolumetricEfficiency = New instat.ucrCheck()
        Me.ucrChkPercentBias = New instat.ucrCheck()
        Me.ucrChkModNashSutcliffeEff = New instat.ucrCheck()
        Me.ucrChkMeanError = New instat.ucrCheck()
        Me.ucrChkMeanSquaredError = New instat.ucrCheck()
        Me.ucrChkRootMeanSquaredError = New instat.ucrCheck()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.ucrChkNormRootMeanSquaredError = New instat.ucrCheck()
        Me.ucrChkMeanAbsoluteError = New instat.ucrCheck()
        Me.ucrChkIndexOfAgreement = New instat.ucrCheck()
        Me.ucrReceiverSecondVariable = New instat.ucrReceiverSingle()
        Me.ucrSelectorSecondVariable = New instat.ucrSelectorByDataFrameAddRemove()
        Me.tbMore = New System.Windows.Forms.TabPage()
        Me.grpProportionsPercentiles = New System.Windows.Forms.GroupBox()
        Me.ucrInputQuantile = New instat.ucrInputTextBox()
        Me.ucrChkQuantile = New instat.ucrCheck()
        Me.ucrInputCountValue = New instat.ucrInputTextBox()
        Me.ucrInputComboCountTest = New instat.ucrInputComboBox()
        Me.ucrChkProportion = New instat.ucrCheck()
        Me.ucrChkCount = New instat.ucrCheck()
        Me.ucrChkPercentage = New instat.ucrCheck()
        Me.ucrInputPropValue = New instat.ucrInputTextBox()
        Me.ucrInputComboPropTest = New instat.ucrInputComboBox()
        Me.ucrInputPercentile = New instat.ucrInputTextBox()
        Me.ucrChkPercentile = New instat.ucrCheck()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.lblFractionTrimmed = New System.Windows.Forms.Label()
        Me.ucrNudFraction = New instat.ucrNud()
        Me.ucrChkTrimmedMean = New instat.ucrCheck()
        Me.grpScale = New System.Windows.Forms.GroupBox()
        Me.ucrChkSn = New instat.ucrCheck()
        Me.ucrChkQn = New instat.ucrCheck()
        Me.ucrChkCoefficientOfVariation = New instat.ucrCheck()
        Me.ucrChkMedianAbsoluteDeviation = New instat.ucrCheck()
        Me.grpSkewness = New System.Windows.Forms.GroupBox()
        Me.ucrChkMc = New instat.ucrCheck()
        Me.ucrChkSkewness = New instat.ucrCheck()
        Me.grpKurtosis = New System.Windows.Forms.GroupBox()
        Me.ucrChkKurtosis = New instat.ucrCheck()
        Me.tbsum = New System.Windows.Forms.TabPage()
        Me.grpDecilesQuintiles = New System.Windows.Forms.GroupBox()
        Me.ucrChkP60 = New instat.ucrCheck()
        Me.ucrChkP90 = New instat.ucrCheck()
        Me.ucrChkP70 = New instat.ucrCheck()
        Me.ucrChkP80 = New instat.ucrCheck()
        Me.ucrChkP40 = New instat.ucrCheck()
        Me.ucrChkP30 = New instat.ucrCheck()
        Me.ucrChkP10 = New instat.ucrCheck()
        Me.ucrChkP20 = New instat.ucrCheck()
        Me.grpCommon = New System.Windows.Forms.GroupBox()
        Me.ucrChkn_distinct = New instat.ucrCheck()
        Me.ucrChkNTotal = New instat.ucrCheck()
        Me.ucrChkMode = New instat.ucrCheck()
        Me.ucrChkNMissing = New instat.ucrCheck()
        Me.ucrChkNonMissing = New instat.ucrCheck()
        Me.grpQuartilesTerciles = New System.Windows.Forms.GroupBox()
        Me.ucrChkP67 = New instat.ucrCheck()
        Me.ucrChkP33 = New instat.ucrCheck()
        Me.ucrChkP25 = New instat.ucrCheck()
        Me.ucrChkP75 = New instat.ucrCheck()
        Me.grpNotOrderedFactor = New System.Windows.Forms.GroupBox()
        Me.ucrChkRange = New instat.ucrCheck()
        Me.ucrChkMaximum = New instat.ucrCheck()
        Me.ucrChkMinimum = New instat.ucrCheck()
        Me.grpNumeric = New System.Windows.Forms.GroupBox()
        Me.ucrChkVariance = New instat.ucrCheck()
        Me.ucrChkMedian = New instat.ucrCheck()
        Me.ucrChkStdDev = New instat.ucrCheck()
        Me.ucrChkSum = New instat.ucrCheck()
        Me.ucrChkMean = New instat.ucrCheck()
        Me.tbSummaries = New System.Windows.Forms.TabControl()
        Me.ttVerificationSummaries = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrButtonsSummaries = New instat.ucrButtonsSubdialogue()
        Me.tbCircular.SuspendLayout()
        Me.grpCircScale.SuspendLayout()
        Me.grpCircLocation.SuspendLayout()
        Me.tbModel.SuspendLayout()
        Me.tbPosition.SuspendLayout()
        Me.grpPosition.SuspendLayout()
        Me.tbTwoVariables.SuspendLayout()
        Me.grpRelationships.SuspendLayout()
        Me.grpHyroGOF.SuspendLayout()
        Me.tbMore.SuspendLayout()
        Me.grpProportionsPercentiles.SuspendLayout()
        Me.grpLocation.SuspendLayout()
        Me.grpScale.SuspendLayout()
        Me.grpSkewness.SuspendLayout()
        Me.grpKurtosis.SuspendLayout()
        Me.tbsum.SuspendLayout()
        Me.grpDecilesQuintiles.SuspendLayout()
        Me.grpCommon.SuspendLayout()
        Me.grpQuartilesTerciles.SuspendLayout()
        Me.grpNotOrderedFactor.SuspendLayout()
        Me.grpNumeric.SuspendLayout()
        Me.tbSummaries.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbCircular
        '
        Me.tbCircular.Controls.Add(Me.grpCircScale)
        Me.tbCircular.Controls.Add(Me.grpCircLocation)
        resources.ApplyResources(Me.tbCircular, "tbCircular")
        Me.tbCircular.Name = "tbCircular"
        Me.tbCircular.UseVisualStyleBackColor = True
        '
        'grpCircScale
        '
        Me.grpCircScale.Controls.Add(Me.ucrChkCircRange)
        Me.grpCircScale.Controls.Add(Me.ucrChkAngVar)
        Me.grpCircScale.Controls.Add(Me.ucrChkrho)
        Me.grpCircScale.Controls.Add(Me.ucrChkAngDev)
        Me.grpCircScale.Controls.Add(Me.ucrChkVar)
        Me.grpCircScale.Controls.Add(Me.ucrChkSd)
        resources.ApplyResources(Me.grpCircScale, "grpCircScale")
        Me.grpCircScale.Name = "grpCircScale"
        Me.grpCircScale.TabStop = False
        '
        'ucrChkCircRange
        '
        Me.ucrChkCircRange.Checked = False
        resources.ApplyResources(Me.ucrChkCircRange, "ucrChkCircRange")
        Me.ucrChkCircRange.Name = "ucrChkCircRange"
        '
        'ucrChkAngVar
        '
        Me.ucrChkAngVar.Checked = False
        resources.ApplyResources(Me.ucrChkAngVar, "ucrChkAngVar")
        Me.ucrChkAngVar.Name = "ucrChkAngVar"
        '
        'ucrChkrho
        '
        Me.ucrChkrho.Checked = False
        resources.ApplyResources(Me.ucrChkrho, "ucrChkrho")
        Me.ucrChkrho.Name = "ucrChkrho"
        '
        'ucrChkAngDev
        '
        Me.ucrChkAngDev.Checked = False
        resources.ApplyResources(Me.ucrChkAngDev, "ucrChkAngDev")
        Me.ucrChkAngDev.Name = "ucrChkAngDev"
        '
        'ucrChkVar
        '
        Me.ucrChkVar.Checked = False
        resources.ApplyResources(Me.ucrChkVar, "ucrChkVar")
        Me.ucrChkVar.Name = "ucrChkVar"
        '
        'ucrChkSd
        '
        Me.ucrChkSd.Checked = False
        resources.ApplyResources(Me.ucrChkSd, "ucrChkSd")
        Me.ucrChkSd.Name = "ucrChkSd"
        '
        'grpCircLocation
        '
        Me.grpCircLocation.Controls.Add(Me.ucrChkCircMedian)
        Me.grpCircLocation.Controls.Add(Me.ucrChkMin)
        Me.grpCircLocation.Controls.Add(Me.ucrChkMedianH)
        Me.grpCircLocation.Controls.Add(Me.ucrChkQ3)
        Me.grpCircLocation.Controls.Add(Me.ucrChkQ1)
        Me.grpCircLocation.Controls.Add(Me.ucrChkMax)
        Me.grpCircLocation.Controls.Add(Me.ucrChkCircMean)
        resources.ApplyResources(Me.grpCircLocation, "grpCircLocation")
        Me.grpCircLocation.Name = "grpCircLocation"
        Me.grpCircLocation.TabStop = False
        '
        'ucrChkCircMedian
        '
        Me.ucrChkCircMedian.Checked = False
        resources.ApplyResources(Me.ucrChkCircMedian, "ucrChkCircMedian")
        Me.ucrChkCircMedian.Name = "ucrChkCircMedian"
        '
        'ucrChkMin
        '
        Me.ucrChkMin.Checked = False
        resources.ApplyResources(Me.ucrChkMin, "ucrChkMin")
        Me.ucrChkMin.Name = "ucrChkMin"
        '
        'ucrChkMedianH
        '
        Me.ucrChkMedianH.Checked = False
        resources.ApplyResources(Me.ucrChkMedianH, "ucrChkMedianH")
        Me.ucrChkMedianH.Name = "ucrChkMedianH"
        '
        'ucrChkQ3
        '
        Me.ucrChkQ3.Checked = False
        resources.ApplyResources(Me.ucrChkQ3, "ucrChkQ3")
        Me.ucrChkQ3.Name = "ucrChkQ3"
        '
        'ucrChkQ1
        '
        Me.ucrChkQ1.Checked = False
        resources.ApplyResources(Me.ucrChkQ1, "ucrChkQ1")
        Me.ucrChkQ1.Name = "ucrChkQ1"
        '
        'ucrChkMax
        '
        Me.ucrChkMax.Checked = False
        resources.ApplyResources(Me.ucrChkMax, "ucrChkMax")
        Me.ucrChkMax.Name = "ucrChkMax"
        '
        'ucrChkCircMean
        '
        Me.ucrChkCircMean.Checked = False
        resources.ApplyResources(Me.ucrChkCircMean, "ucrChkCircMean")
        Me.ucrChkCircMean.Name = "ucrChkCircMean"
        '
        'tbModel
        '
        Me.tbModel.Controls.Add(Me.ucrChkStandardErrorOfMean)
        resources.ApplyResources(Me.tbModel, "tbModel")
        Me.tbModel.Name = "tbModel"
        Me.tbModel.UseVisualStyleBackColor = True
        '
        'ucrChkStandardErrorOfMean
        '
        Me.ucrChkStandardErrorOfMean.Checked = False
        resources.ApplyResources(Me.ucrChkStandardErrorOfMean, "ucrChkStandardErrorOfMean")
        Me.ucrChkStandardErrorOfMean.Name = "ucrChkStandardErrorOfMean"
        '
        'tbPosition
        '
        Me.tbPosition.Controls.Add(Me.ucrChkOrderBy)
        Me.tbPosition.Controls.Add(Me.lblOrderBy)
        Me.tbPosition.Controls.Add(Me.grpPosition)
        Me.tbPosition.Controls.Add(Me.ucrSelectorOrderBy)
        Me.tbPosition.Controls.Add(Me.ucrReceiverOrderBy)
        resources.ApplyResources(Me.tbPosition, "tbPosition")
        Me.tbPosition.Name = "tbPosition"
        Me.tbPosition.UseVisualStyleBackColor = True
        '
        'ucrChkOrderBy
        '
        Me.ucrChkOrderBy.Checked = False
        resources.ApplyResources(Me.ucrChkOrderBy, "ucrChkOrderBy")
        Me.ucrChkOrderBy.Name = "ucrChkOrderBy"
        '
        'lblOrderBy
        '
        resources.ApplyResources(Me.lblOrderBy, "lblOrderBy")
        Me.lblOrderBy.Name = "lblOrderBy"
        '
        'grpPosition
        '
        Me.grpPosition.Controls.Add(Me.ucrChkSetseed)
        Me.grpPosition.Controls.Add(Me.ucrNudSeed)
        Me.grpPosition.Controls.Add(Me.ucrChkSample)
        Me.grpPosition.Controls.Add(Me.ucrInputN)
        Me.grpPosition.Controls.Add(Me.lblInputN)
        Me.grpPosition.Controls.Add(Me.ucrChkFirst)
        Me.grpPosition.Controls.Add(Me.ucrChkLast)
        Me.grpPosition.Controls.Add(Me.ucrChknth)
        resources.ApplyResources(Me.grpPosition, "grpPosition")
        Me.grpPosition.Name = "grpPosition"
        Me.grpPosition.TabStop = False
        '
        'ucrChkSetseed
        '
        Me.ucrChkSetseed.Checked = False
        resources.ApplyResources(Me.ucrChkSetseed, "ucrChkSetseed")
        Me.ucrChkSetseed.Name = "ucrChkSetseed"
        '
        'ucrNudSeed
        '
        Me.ucrNudSeed.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSeed.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSeed, "ucrNudSeed")
        Me.ucrNudSeed.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSeed.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSeed.Name = "ucrNudSeed"
        Me.ucrNudSeed.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkSample
        '
        Me.ucrChkSample.Checked = False
        resources.ApplyResources(Me.ucrChkSample, "ucrChkSample")
        Me.ucrChkSample.Name = "ucrChkSample"
        '
        'ucrInputN
        '
        Me.ucrInputN.AddQuotesIfUnrecognised = True
        Me.ucrInputN.IsMultiline = False
        Me.ucrInputN.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputN, "ucrInputN")
        Me.ucrInputN.Name = "ucrInputN"
        '
        'lblInputN
        '
        resources.ApplyResources(Me.lblInputN, "lblInputN")
        Me.lblInputN.Name = "lblInputN"
        '
        'ucrChkFirst
        '
        Me.ucrChkFirst.Checked = False
        resources.ApplyResources(Me.ucrChkFirst, "ucrChkFirst")
        Me.ucrChkFirst.Name = "ucrChkFirst"
        '
        'ucrChkLast
        '
        Me.ucrChkLast.Checked = False
        resources.ApplyResources(Me.ucrChkLast, "ucrChkLast")
        Me.ucrChkLast.Name = "ucrChkLast"
        '
        'ucrChknth
        '
        Me.ucrChknth.Checked = False
        resources.ApplyResources(Me.ucrChknth, "ucrChknth")
        Me.ucrChknth.Name = "ucrChknth"
        '
        'ucrSelectorOrderBy
        '
        Me.ucrSelectorOrderBy.bDropUnusedFilterLevels = False
        Me.ucrSelectorOrderBy.bShowHiddenColumns = False
        Me.ucrSelectorOrderBy.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorOrderBy, "ucrSelectorOrderBy")
        Me.ucrSelectorOrderBy.Name = "ucrSelectorOrderBy"
        '
        'ucrReceiverOrderBy
        '
        Me.ucrReceiverOrderBy.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverOrderBy, "ucrReceiverOrderBy")
        Me.ucrReceiverOrderBy.Name = "ucrReceiverOrderBy"
        Me.ucrReceiverOrderBy.Selector = Nothing
        Me.ucrReceiverOrderBy.strNcFilePath = ""
        Me.ucrReceiverOrderBy.ucrSelector = Nothing
        '
        'tbTwoVariables
        '
        Me.tbTwoVariables.Controls.Add(Me.lblSecondVariable)
        Me.tbTwoVariables.Controls.Add(Me.grpRelationships)
        Me.tbTwoVariables.Controls.Add(Me.grpHyroGOF)
        Me.tbTwoVariables.Controls.Add(Me.ucrReceiverSecondVariable)
        Me.tbTwoVariables.Controls.Add(Me.ucrSelectorSecondVariable)
        resources.ApplyResources(Me.tbTwoVariables, "tbTwoVariables")
        Me.tbTwoVariables.Name = "tbTwoVariables"
        Me.tbTwoVariables.UseVisualStyleBackColor = True
        '
        'lblSecondVariable
        '
        resources.ApplyResources(Me.lblSecondVariable, "lblSecondVariable")
        Me.lblSecondVariable.Name = "lblSecondVariable"
        '
        'grpRelationships
        '
        Me.grpRelationships.Controls.Add(Me.ucrChkCovariance)
        Me.grpRelationships.Controls.Add(Me.ucrChkCorrelations)
        resources.ApplyResources(Me.grpRelationships, "grpRelationships")
        Me.grpRelationships.Name = "grpRelationships"
        Me.grpRelationships.TabStop = False
        '
        'ucrChkCovariance
        '
        Me.ucrChkCovariance.Checked = False
        resources.ApplyResources(Me.ucrChkCovariance, "ucrChkCovariance")
        Me.ucrChkCovariance.Name = "ucrChkCovariance"
        '
        'ucrChkCorrelations
        '
        Me.ucrChkCorrelations.Checked = False
        resources.ApplyResources(Me.ucrChkCorrelations, "ucrChkCorrelations")
        Me.ucrChkCorrelations.Name = "ucrChkCorrelations"
        '
        'grpHyroGOF
        '
        Me.grpHyroGOF.Controls.Add(Me.lblJmia)
        Me.grpHyroGOF.Controls.Add(Me.ucrInputJmia)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkSelectAll)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkRelativeIndexOfAgreement)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkRatioOfStandardDeviation)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkCoefDetermination)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkRatioOfRootMeanSquaredError)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkRelativeNashSutcliffeEff)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkModifiedIndexOfAgreement)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkCoefPersistence)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkNashSutcliffeEfficiency)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkSumOfSquaredResiduals)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkKlingGuptaEfficiency)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkVolumetricEfficiency)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkPercentBias)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkModNashSutcliffeEff)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkMeanError)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkMeanSquaredError)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkRootMeanSquaredError)
        Me.grpHyroGOF.Controls.Add(Me.cmdHelp)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkNormRootMeanSquaredError)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkMeanAbsoluteError)
        Me.grpHyroGOF.Controls.Add(Me.ucrChkIndexOfAgreement)
        resources.ApplyResources(Me.grpHyroGOF, "grpHyroGOF")
        Me.grpHyroGOF.Name = "grpHyroGOF"
        Me.grpHyroGOF.TabStop = False
        '
        'lblJmia
        '
        resources.ApplyResources(Me.lblJmia, "lblJmia")
        Me.lblJmia.Name = "lblJmia"
        '
        'ucrInputJmia
        '
        Me.ucrInputJmia.AddQuotesIfUnrecognised = True
        Me.ucrInputJmia.IsMultiline = False
        Me.ucrInputJmia.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputJmia, "ucrInputJmia")
        Me.ucrInputJmia.Name = "ucrInputJmia"
        '
        'ucrChkSelectAll
        '
        Me.ucrChkSelectAll.Checked = False
        resources.ApplyResources(Me.ucrChkSelectAll, "ucrChkSelectAll")
        Me.ucrChkSelectAll.Name = "ucrChkSelectAll"
        '
        'ucrChkRelativeIndexOfAgreement
        '
        Me.ucrChkRelativeIndexOfAgreement.Checked = False
        resources.ApplyResources(Me.ucrChkRelativeIndexOfAgreement, "ucrChkRelativeIndexOfAgreement")
        Me.ucrChkRelativeIndexOfAgreement.Name = "ucrChkRelativeIndexOfAgreement"
        '
        'ucrChkRatioOfStandardDeviation
        '
        Me.ucrChkRatioOfStandardDeviation.Checked = False
        resources.ApplyResources(Me.ucrChkRatioOfStandardDeviation, "ucrChkRatioOfStandardDeviation")
        Me.ucrChkRatioOfStandardDeviation.Name = "ucrChkRatioOfStandardDeviation"
        '
        'ucrChkCoefDetermination
        '
        Me.ucrChkCoefDetermination.Checked = False
        resources.ApplyResources(Me.ucrChkCoefDetermination, "ucrChkCoefDetermination")
        Me.ucrChkCoefDetermination.Name = "ucrChkCoefDetermination"
        '
        'ucrChkRatioOfRootMeanSquaredError
        '
        Me.ucrChkRatioOfRootMeanSquaredError.Checked = False
        resources.ApplyResources(Me.ucrChkRatioOfRootMeanSquaredError, "ucrChkRatioOfRootMeanSquaredError")
        Me.ucrChkRatioOfRootMeanSquaredError.Name = "ucrChkRatioOfRootMeanSquaredError"
        '
        'ucrChkRelativeNashSutcliffeEff
        '
        Me.ucrChkRelativeNashSutcliffeEff.Checked = False
        resources.ApplyResources(Me.ucrChkRelativeNashSutcliffeEff, "ucrChkRelativeNashSutcliffeEff")
        Me.ucrChkRelativeNashSutcliffeEff.Name = "ucrChkRelativeNashSutcliffeEff"
        '
        'ucrChkModifiedIndexOfAgreement
        '
        Me.ucrChkModifiedIndexOfAgreement.Checked = False
        resources.ApplyResources(Me.ucrChkModifiedIndexOfAgreement, "ucrChkModifiedIndexOfAgreement")
        Me.ucrChkModifiedIndexOfAgreement.Name = "ucrChkModifiedIndexOfAgreement"
        '
        'ucrChkCoefPersistence
        '
        Me.ucrChkCoefPersistence.Checked = False
        resources.ApplyResources(Me.ucrChkCoefPersistence, "ucrChkCoefPersistence")
        Me.ucrChkCoefPersistence.Name = "ucrChkCoefPersistence"
        '
        'ucrChkNashSutcliffeEfficiency
        '
        Me.ucrChkNashSutcliffeEfficiency.Checked = False
        resources.ApplyResources(Me.ucrChkNashSutcliffeEfficiency, "ucrChkNashSutcliffeEfficiency")
        Me.ucrChkNashSutcliffeEfficiency.Name = "ucrChkNashSutcliffeEfficiency"
        '
        'ucrChkSumOfSquaredResiduals
        '
        Me.ucrChkSumOfSquaredResiduals.Checked = False
        resources.ApplyResources(Me.ucrChkSumOfSquaredResiduals, "ucrChkSumOfSquaredResiduals")
        Me.ucrChkSumOfSquaredResiduals.Name = "ucrChkSumOfSquaredResiduals"
        '
        'ucrChkKlingGuptaEfficiency
        '
        Me.ucrChkKlingGuptaEfficiency.Checked = False
        resources.ApplyResources(Me.ucrChkKlingGuptaEfficiency, "ucrChkKlingGuptaEfficiency")
        Me.ucrChkKlingGuptaEfficiency.Name = "ucrChkKlingGuptaEfficiency"
        '
        'ucrChkVolumetricEfficiency
        '
        Me.ucrChkVolumetricEfficiency.Checked = False
        resources.ApplyResources(Me.ucrChkVolumetricEfficiency, "ucrChkVolumetricEfficiency")
        Me.ucrChkVolumetricEfficiency.Name = "ucrChkVolumetricEfficiency"
        '
        'ucrChkPercentBias
        '
        Me.ucrChkPercentBias.Checked = False
        resources.ApplyResources(Me.ucrChkPercentBias, "ucrChkPercentBias")
        Me.ucrChkPercentBias.Name = "ucrChkPercentBias"
        '
        'ucrChkModNashSutcliffeEff
        '
        Me.ucrChkModNashSutcliffeEff.Checked = False
        resources.ApplyResources(Me.ucrChkModNashSutcliffeEff, "ucrChkModNashSutcliffeEff")
        Me.ucrChkModNashSutcliffeEff.Name = "ucrChkModNashSutcliffeEff"
        '
        'ucrChkMeanError
        '
        Me.ucrChkMeanError.Checked = False
        resources.ApplyResources(Me.ucrChkMeanError, "ucrChkMeanError")
        Me.ucrChkMeanError.Name = "ucrChkMeanError"
        '
        'ucrChkMeanSquaredError
        '
        Me.ucrChkMeanSquaredError.Checked = False
        resources.ApplyResources(Me.ucrChkMeanSquaredError, "ucrChkMeanSquaredError")
        Me.ucrChkMeanSquaredError.Name = "ucrChkMeanSquaredError"
        '
        'ucrChkRootMeanSquaredError
        '
        Me.ucrChkRootMeanSquaredError.Checked = False
        resources.ApplyResources(Me.ucrChkRootMeanSquaredError, "ucrChkRootMeanSquaredError")
        Me.ucrChkRootMeanSquaredError.Name = "ucrChkRootMeanSquaredError"
        '
        'cmdHelp
        '
        resources.ApplyResources(Me.cmdHelp, "cmdHelp")
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'ucrChkNormRootMeanSquaredError
        '
        Me.ucrChkNormRootMeanSquaredError.Checked = False
        resources.ApplyResources(Me.ucrChkNormRootMeanSquaredError, "ucrChkNormRootMeanSquaredError")
        Me.ucrChkNormRootMeanSquaredError.Name = "ucrChkNormRootMeanSquaredError"
        '
        'ucrChkMeanAbsoluteError
        '
        Me.ucrChkMeanAbsoluteError.Checked = False
        resources.ApplyResources(Me.ucrChkMeanAbsoluteError, "ucrChkMeanAbsoluteError")
        Me.ucrChkMeanAbsoluteError.Name = "ucrChkMeanAbsoluteError"
        '
        'ucrChkIndexOfAgreement
        '
        Me.ucrChkIndexOfAgreement.Checked = False
        resources.ApplyResources(Me.ucrChkIndexOfAgreement, "ucrChkIndexOfAgreement")
        Me.ucrChkIndexOfAgreement.Name = "ucrChkIndexOfAgreement"
        '
        'ucrReceiverSecondVariable
        '
        Me.ucrReceiverSecondVariable.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverSecondVariable, "ucrReceiverSecondVariable")
        Me.ucrReceiverSecondVariable.Name = "ucrReceiverSecondVariable"
        Me.ucrReceiverSecondVariable.Selector = Nothing
        Me.ucrReceiverSecondVariable.strNcFilePath = ""
        Me.ucrReceiverSecondVariable.ucrSelector = Nothing
        '
        'ucrSelectorSecondVariable
        '
        Me.ucrSelectorSecondVariable.bDropUnusedFilterLevels = False
        Me.ucrSelectorSecondVariable.bShowHiddenColumns = False
        Me.ucrSelectorSecondVariable.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorSecondVariable, "ucrSelectorSecondVariable")
        Me.ucrSelectorSecondVariable.Name = "ucrSelectorSecondVariable"
        '
        'tbMore
        '
        Me.tbMore.Controls.Add(Me.grpProportionsPercentiles)
        Me.tbMore.Controls.Add(Me.grpLocation)
        Me.tbMore.Controls.Add(Me.grpScale)
        Me.tbMore.Controls.Add(Me.grpSkewness)
        Me.tbMore.Controls.Add(Me.grpKurtosis)
        resources.ApplyResources(Me.tbMore, "tbMore")
        Me.tbMore.Name = "tbMore"
        Me.tbMore.UseVisualStyleBackColor = True
        '
        'grpProportionsPercentiles
        '
        Me.grpProportionsPercentiles.Controls.Add(Me.ucrInputQuantile)
        Me.grpProportionsPercentiles.Controls.Add(Me.ucrChkQuantile)
        Me.grpProportionsPercentiles.Controls.Add(Me.ucrInputCountValue)
        Me.grpProportionsPercentiles.Controls.Add(Me.ucrInputComboCountTest)
        Me.grpProportionsPercentiles.Controls.Add(Me.ucrChkProportion)
        Me.grpProportionsPercentiles.Controls.Add(Me.ucrChkCount)
        Me.grpProportionsPercentiles.Controls.Add(Me.ucrChkPercentage)
        Me.grpProportionsPercentiles.Controls.Add(Me.ucrInputPropValue)
        Me.grpProportionsPercentiles.Controls.Add(Me.ucrInputComboPropTest)
        Me.grpProportionsPercentiles.Controls.Add(Me.ucrInputPercentile)
        Me.grpProportionsPercentiles.Controls.Add(Me.ucrChkPercentile)
        resources.ApplyResources(Me.grpProportionsPercentiles, "grpProportionsPercentiles")
        Me.grpProportionsPercentiles.Name = "grpProportionsPercentiles"
        Me.grpProportionsPercentiles.TabStop = False
        '
        'ucrInputQuantile
        '
        Me.ucrInputQuantile.AddQuotesIfUnrecognised = True
        Me.ucrInputQuantile.IsMultiline = False
        Me.ucrInputQuantile.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputQuantile, "ucrInputQuantile")
        Me.ucrInputQuantile.Name = "ucrInputQuantile"
        '
        'ucrChkQuantile
        '
        Me.ucrChkQuantile.Checked = False
        resources.ApplyResources(Me.ucrChkQuantile, "ucrChkQuantile")
        Me.ucrChkQuantile.Name = "ucrChkQuantile"
        '
        'ucrInputCountValue
        '
        Me.ucrInputCountValue.AddQuotesIfUnrecognised = True
        Me.ucrInputCountValue.IsMultiline = False
        Me.ucrInputCountValue.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCountValue, "ucrInputCountValue")
        Me.ucrInputCountValue.Name = "ucrInputCountValue"
        '
        'ucrInputComboCountTest
        '
        resources.ApplyResources(Me.ucrInputComboCountTest, "ucrInputComboCountTest")
        Me.ucrInputComboCountTest.AddQuotesIfUnrecognised = True
        Me.ucrInputComboCountTest.GetSetSelectedIndex = -1
        Me.ucrInputComboCountTest.IsReadOnly = False
        Me.ucrInputComboCountTest.Name = "ucrInputComboCountTest"
        '
        'ucrChkProportion
        '
        Me.ucrChkProportion.Checked = False
        resources.ApplyResources(Me.ucrChkProportion, "ucrChkProportion")
        Me.ucrChkProportion.Name = "ucrChkProportion"
        '
        'ucrChkCount
        '
        Me.ucrChkCount.Checked = False
        resources.ApplyResources(Me.ucrChkCount, "ucrChkCount")
        Me.ucrChkCount.Name = "ucrChkCount"
        '
        'ucrChkPercentage
        '
        Me.ucrChkPercentage.Checked = False
        resources.ApplyResources(Me.ucrChkPercentage, "ucrChkPercentage")
        Me.ucrChkPercentage.Name = "ucrChkPercentage"
        '
        'ucrInputPropValue
        '
        Me.ucrInputPropValue.AddQuotesIfUnrecognised = True
        Me.ucrInputPropValue.IsMultiline = False
        Me.ucrInputPropValue.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPropValue, "ucrInputPropValue")
        Me.ucrInputPropValue.Name = "ucrInputPropValue"
        '
        'ucrInputComboPropTest
        '
        resources.ApplyResources(Me.ucrInputComboPropTest, "ucrInputComboPropTest")
        Me.ucrInputComboPropTest.AddQuotesIfUnrecognised = True
        Me.ucrInputComboPropTest.GetSetSelectedIndex = -1
        Me.ucrInputComboPropTest.IsReadOnly = False
        Me.ucrInputComboPropTest.Name = "ucrInputComboPropTest"
        '
        'ucrInputPercentile
        '
        Me.ucrInputPercentile.AddQuotesIfUnrecognised = True
        Me.ucrInputPercentile.IsMultiline = False
        Me.ucrInputPercentile.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPercentile, "ucrInputPercentile")
        Me.ucrInputPercentile.Name = "ucrInputPercentile"
        '
        'ucrChkPercentile
        '
        Me.ucrChkPercentile.Checked = False
        resources.ApplyResources(Me.ucrChkPercentile, "ucrChkPercentile")
        Me.ucrChkPercentile.Name = "ucrChkPercentile"
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.lblFractionTrimmed)
        Me.grpLocation.Controls.Add(Me.ucrNudFraction)
        Me.grpLocation.Controls.Add(Me.ucrChkTrimmedMean)
        resources.ApplyResources(Me.grpLocation, "grpLocation")
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.TabStop = False
        '
        'lblFractionTrimmed
        '
        resources.ApplyResources(Me.lblFractionTrimmed, "lblFractionTrimmed")
        Me.lblFractionTrimmed.Name = "lblFractionTrimmed"
        '
        'ucrNudFraction
        '
        Me.ucrNudFraction.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFraction.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudFraction, "ucrNudFraction")
        Me.ucrNudFraction.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFraction.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFraction.Name = "ucrNudFraction"
        Me.ucrNudFraction.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkTrimmedMean
        '
        Me.ucrChkTrimmedMean.Checked = False
        resources.ApplyResources(Me.ucrChkTrimmedMean, "ucrChkTrimmedMean")
        Me.ucrChkTrimmedMean.Name = "ucrChkTrimmedMean"
        '
        'grpScale
        '
        Me.grpScale.Controls.Add(Me.ucrChkSn)
        Me.grpScale.Controls.Add(Me.ucrChkQn)
        Me.grpScale.Controls.Add(Me.ucrChkCoefficientOfVariation)
        Me.grpScale.Controls.Add(Me.ucrChkMedianAbsoluteDeviation)
        resources.ApplyResources(Me.grpScale, "grpScale")
        Me.grpScale.Name = "grpScale"
        Me.grpScale.TabStop = False
        '
        'ucrChkSn
        '
        Me.ucrChkSn.Checked = False
        resources.ApplyResources(Me.ucrChkSn, "ucrChkSn")
        Me.ucrChkSn.Name = "ucrChkSn"
        '
        'ucrChkQn
        '
        Me.ucrChkQn.Checked = False
        resources.ApplyResources(Me.ucrChkQn, "ucrChkQn")
        Me.ucrChkQn.Name = "ucrChkQn"
        '
        'ucrChkCoefficientOfVariation
        '
        Me.ucrChkCoefficientOfVariation.Checked = False
        resources.ApplyResources(Me.ucrChkCoefficientOfVariation, "ucrChkCoefficientOfVariation")
        Me.ucrChkCoefficientOfVariation.Name = "ucrChkCoefficientOfVariation"
        '
        'ucrChkMedianAbsoluteDeviation
        '
        Me.ucrChkMedianAbsoluteDeviation.Checked = False
        resources.ApplyResources(Me.ucrChkMedianAbsoluteDeviation, "ucrChkMedianAbsoluteDeviation")
        Me.ucrChkMedianAbsoluteDeviation.Name = "ucrChkMedianAbsoluteDeviation"
        '
        'grpSkewness
        '
        Me.grpSkewness.Controls.Add(Me.ucrChkMc)
        Me.grpSkewness.Controls.Add(Me.ucrChkSkewness)
        resources.ApplyResources(Me.grpSkewness, "grpSkewness")
        Me.grpSkewness.Name = "grpSkewness"
        Me.grpSkewness.TabStop = False
        '
        'ucrChkMc
        '
        Me.ucrChkMc.Checked = False
        resources.ApplyResources(Me.ucrChkMc, "ucrChkMc")
        Me.ucrChkMc.Name = "ucrChkMc"
        '
        'ucrChkSkewness
        '
        Me.ucrChkSkewness.Checked = False
        resources.ApplyResources(Me.ucrChkSkewness, "ucrChkSkewness")
        Me.ucrChkSkewness.Name = "ucrChkSkewness"
        '
        'grpKurtosis
        '
        Me.grpKurtosis.Controls.Add(Me.ucrChkKurtosis)
        resources.ApplyResources(Me.grpKurtosis, "grpKurtosis")
        Me.grpKurtosis.Name = "grpKurtosis"
        Me.grpKurtosis.TabStop = False
        '
        'ucrChkKurtosis
        '
        Me.ucrChkKurtosis.Checked = False
        resources.ApplyResources(Me.ucrChkKurtosis, "ucrChkKurtosis")
        Me.ucrChkKurtosis.Name = "ucrChkKurtosis"
        '
        'tbsum
        '
        Me.tbsum.Controls.Add(Me.grpDecilesQuintiles)
        Me.tbsum.Controls.Add(Me.grpCommon)
        Me.tbsum.Controls.Add(Me.grpQuartilesTerciles)
        Me.tbsum.Controls.Add(Me.grpNotOrderedFactor)
        Me.tbsum.Controls.Add(Me.grpNumeric)
        resources.ApplyResources(Me.tbsum, "tbsum")
        Me.tbsum.Name = "tbsum"
        Me.tbsum.UseVisualStyleBackColor = True
        '
        'grpDecilesQuintiles
        '
        Me.grpDecilesQuintiles.Controls.Add(Me.ucrChkP60)
        Me.grpDecilesQuintiles.Controls.Add(Me.ucrChkP90)
        Me.grpDecilesQuintiles.Controls.Add(Me.ucrChkP70)
        Me.grpDecilesQuintiles.Controls.Add(Me.ucrChkP80)
        Me.grpDecilesQuintiles.Controls.Add(Me.ucrChkP40)
        Me.grpDecilesQuintiles.Controls.Add(Me.ucrChkP30)
        Me.grpDecilesQuintiles.Controls.Add(Me.ucrChkP10)
        Me.grpDecilesQuintiles.Controls.Add(Me.ucrChkP20)
        resources.ApplyResources(Me.grpDecilesQuintiles, "grpDecilesQuintiles")
        Me.grpDecilesQuintiles.Name = "grpDecilesQuintiles"
        Me.grpDecilesQuintiles.TabStop = False
        Me.grpDecilesQuintiles.Tag = ""
        '
        'ucrChkP60
        '
        Me.ucrChkP60.Checked = False
        resources.ApplyResources(Me.ucrChkP60, "ucrChkP60")
        Me.ucrChkP60.Name = "ucrChkP60"
        '
        'ucrChkP90
        '
        Me.ucrChkP90.Checked = False
        resources.ApplyResources(Me.ucrChkP90, "ucrChkP90")
        Me.ucrChkP90.Name = "ucrChkP90"
        '
        'ucrChkP70
        '
        Me.ucrChkP70.Checked = False
        resources.ApplyResources(Me.ucrChkP70, "ucrChkP70")
        Me.ucrChkP70.Name = "ucrChkP70"
        '
        'ucrChkP80
        '
        Me.ucrChkP80.Checked = False
        resources.ApplyResources(Me.ucrChkP80, "ucrChkP80")
        Me.ucrChkP80.Name = "ucrChkP80"
        '
        'ucrChkP40
        '
        Me.ucrChkP40.Checked = False
        resources.ApplyResources(Me.ucrChkP40, "ucrChkP40")
        Me.ucrChkP40.Name = "ucrChkP40"
        '
        'ucrChkP30
        '
        Me.ucrChkP30.Checked = False
        resources.ApplyResources(Me.ucrChkP30, "ucrChkP30")
        Me.ucrChkP30.Name = "ucrChkP30"
        '
        'ucrChkP10
        '
        Me.ucrChkP10.Checked = False
        resources.ApplyResources(Me.ucrChkP10, "ucrChkP10")
        Me.ucrChkP10.Name = "ucrChkP10"
        '
        'ucrChkP20
        '
        Me.ucrChkP20.Checked = False
        resources.ApplyResources(Me.ucrChkP20, "ucrChkP20")
        Me.ucrChkP20.Name = "ucrChkP20"
        '
        'grpCommon
        '
        Me.grpCommon.Controls.Add(Me.ucrChkn_distinct)
        Me.grpCommon.Controls.Add(Me.ucrChkNTotal)
        Me.grpCommon.Controls.Add(Me.ucrChkMode)
        Me.grpCommon.Controls.Add(Me.ucrChkNMissing)
        Me.grpCommon.Controls.Add(Me.ucrChkNonMissing)
        resources.ApplyResources(Me.grpCommon, "grpCommon")
        Me.grpCommon.Name = "grpCommon"
        Me.grpCommon.TabStop = False
        Me.grpCommon.Tag = "Common"
        '
        'ucrChkn_distinct
        '
        Me.ucrChkn_distinct.Checked = False
        resources.ApplyResources(Me.ucrChkn_distinct, "ucrChkn_distinct")
        Me.ucrChkn_distinct.Name = "ucrChkn_distinct"
        '
        'ucrChkNTotal
        '
        Me.ucrChkNTotal.Checked = False
        resources.ApplyResources(Me.ucrChkNTotal, "ucrChkNTotal")
        Me.ucrChkNTotal.Name = "ucrChkNTotal"
        '
        'ucrChkMode
        '
        Me.ucrChkMode.Checked = False
        resources.ApplyResources(Me.ucrChkMode, "ucrChkMode")
        Me.ucrChkMode.Name = "ucrChkMode"
        '
        'ucrChkNMissing
        '
        Me.ucrChkNMissing.Checked = False
        resources.ApplyResources(Me.ucrChkNMissing, "ucrChkNMissing")
        Me.ucrChkNMissing.Name = "ucrChkNMissing"
        '
        'ucrChkNonMissing
        '
        Me.ucrChkNonMissing.Checked = False
        resources.ApplyResources(Me.ucrChkNonMissing, "ucrChkNonMissing")
        Me.ucrChkNonMissing.Name = "ucrChkNonMissing"
        '
        'grpQuartilesTerciles
        '
        Me.grpQuartilesTerciles.Controls.Add(Me.ucrChkP67)
        Me.grpQuartilesTerciles.Controls.Add(Me.ucrChkP33)
        Me.grpQuartilesTerciles.Controls.Add(Me.ucrChkP25)
        Me.grpQuartilesTerciles.Controls.Add(Me.ucrChkP75)
        resources.ApplyResources(Me.grpQuartilesTerciles, "grpQuartilesTerciles")
        Me.grpQuartilesTerciles.Name = "grpQuartilesTerciles"
        Me.grpQuartilesTerciles.TabStop = False
        Me.grpQuartilesTerciles.Tag = "Quartiles"
        '
        'ucrChkP67
        '
        Me.ucrChkP67.Checked = False
        resources.ApplyResources(Me.ucrChkP67, "ucrChkP67")
        Me.ucrChkP67.Name = "ucrChkP67"
        '
        'ucrChkP33
        '
        Me.ucrChkP33.Checked = False
        resources.ApplyResources(Me.ucrChkP33, "ucrChkP33")
        Me.ucrChkP33.Name = "ucrChkP33"
        '
        'ucrChkP25
        '
        Me.ucrChkP25.Checked = False
        resources.ApplyResources(Me.ucrChkP25, "ucrChkP25")
        Me.ucrChkP25.Name = "ucrChkP25"
        '
        'ucrChkP75
        '
        Me.ucrChkP75.Checked = False
        resources.ApplyResources(Me.ucrChkP75, "ucrChkP75")
        Me.ucrChkP75.Name = "ucrChkP75"
        '
        'grpNotOrderedFactor
        '
        Me.grpNotOrderedFactor.Controls.Add(Me.ucrChkRange)
        Me.grpNotOrderedFactor.Controls.Add(Me.ucrChkMaximum)
        Me.grpNotOrderedFactor.Controls.Add(Me.ucrChkMinimum)
        resources.ApplyResources(Me.grpNotOrderedFactor, "grpNotOrderedFactor")
        Me.grpNotOrderedFactor.Name = "grpNotOrderedFactor"
        Me.grpNotOrderedFactor.TabStop = False
        Me.grpNotOrderedFactor.Tag = "All_but_unordered_Factor"
        '
        'ucrChkRange
        '
        Me.ucrChkRange.Checked = False
        resources.ApplyResources(Me.ucrChkRange, "ucrChkRange")
        Me.ucrChkRange.Name = "ucrChkRange"
        '
        'ucrChkMaximum
        '
        Me.ucrChkMaximum.Checked = False
        resources.ApplyResources(Me.ucrChkMaximum, "ucrChkMaximum")
        Me.ucrChkMaximum.Name = "ucrChkMaximum"
        '
        'ucrChkMinimum
        '
        Me.ucrChkMinimum.Checked = False
        resources.ApplyResources(Me.ucrChkMinimum, "ucrChkMinimum")
        Me.ucrChkMinimum.Name = "ucrChkMinimum"
        '
        'grpNumeric
        '
        Me.grpNumeric.Controls.Add(Me.ucrChkVariance)
        Me.grpNumeric.Controls.Add(Me.ucrChkMedian)
        Me.grpNumeric.Controls.Add(Me.ucrChkStdDev)
        Me.grpNumeric.Controls.Add(Me.ucrChkSum)
        Me.grpNumeric.Controls.Add(Me.ucrChkMean)
        resources.ApplyResources(Me.grpNumeric, "grpNumeric")
        Me.grpNumeric.Name = "grpNumeric"
        Me.grpNumeric.TabStop = False
        Me.grpNumeric.Tag = "Numeric"
        '
        'ucrChkVariance
        '
        Me.ucrChkVariance.Checked = False
        resources.ApplyResources(Me.ucrChkVariance, "ucrChkVariance")
        Me.ucrChkVariance.Name = "ucrChkVariance"
        '
        'ucrChkMedian
        '
        Me.ucrChkMedian.Checked = False
        resources.ApplyResources(Me.ucrChkMedian, "ucrChkMedian")
        Me.ucrChkMedian.Name = "ucrChkMedian"
        '
        'ucrChkStdDev
        '
        Me.ucrChkStdDev.Checked = False
        resources.ApplyResources(Me.ucrChkStdDev, "ucrChkStdDev")
        Me.ucrChkStdDev.Name = "ucrChkStdDev"
        '
        'ucrChkSum
        '
        Me.ucrChkSum.Checked = False
        resources.ApplyResources(Me.ucrChkSum, "ucrChkSum")
        Me.ucrChkSum.Name = "ucrChkSum"
        '
        'ucrChkMean
        '
        Me.ucrChkMean.Checked = False
        resources.ApplyResources(Me.ucrChkMean, "ucrChkMean")
        Me.ucrChkMean.Name = "ucrChkMean"
        '
        'tbSummaries
        '
        Me.tbSummaries.Controls.Add(Me.tbsum)
        Me.tbSummaries.Controls.Add(Me.tbMore)
        Me.tbSummaries.Controls.Add(Me.tbTwoVariables)
        Me.tbSummaries.Controls.Add(Me.tbPosition)
        Me.tbSummaries.Controls.Add(Me.tbModel)
        Me.tbSummaries.Controls.Add(Me.tbCircular)
        resources.ApplyResources(Me.tbSummaries, "tbSummaries")
        Me.tbSummaries.Name = "tbSummaries"
        Me.tbSummaries.SelectedIndex = 0
        '
        'ucrButtonsSummaries
        '
        resources.ApplyResources(Me.ucrButtonsSummaries, "ucrButtonsSummaries")
        Me.ucrButtonsSummaries.Name = "ucrButtonsSummaries"
        '
        'sdgSummaries
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrButtonsSummaries)
        Me.Controls.Add(Me.tbSummaries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSummaries"
        Me.Tag = "Summaries"
        Me.tbCircular.ResumeLayout(False)
        Me.grpCircScale.ResumeLayout(False)
        Me.grpCircLocation.ResumeLayout(False)
        Me.tbModel.ResumeLayout(False)
        Me.tbPosition.ResumeLayout(False)
        Me.tbPosition.PerformLayout()
        Me.grpPosition.ResumeLayout(False)
        Me.grpPosition.PerformLayout()
        Me.tbTwoVariables.ResumeLayout(False)
        Me.tbTwoVariables.PerformLayout()
        Me.grpRelationships.ResumeLayout(False)
        Me.grpHyroGOF.ResumeLayout(False)
        Me.grpHyroGOF.PerformLayout()
        Me.tbMore.ResumeLayout(False)
        Me.grpProportionsPercentiles.ResumeLayout(False)
        Me.grpLocation.ResumeLayout(False)
        Me.grpLocation.PerformLayout()
        Me.grpScale.ResumeLayout(False)
        Me.grpSkewness.ResumeLayout(False)
        Me.grpKurtosis.ResumeLayout(False)
        Me.tbsum.ResumeLayout(False)
        Me.grpDecilesQuintiles.ResumeLayout(False)
        Me.grpCommon.ResumeLayout(False)
        Me.grpQuartilesTerciles.ResumeLayout(False)
        Me.grpNotOrderedFactor.ResumeLayout(False)
        Me.grpNumeric.ResumeLayout(False)
        Me.tbSummaries.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsSummaries As ucrButtonsSubdialogue
    Friend WithEvents tbCircular As TabPage
    Friend WithEvents grpCircScale As GroupBox
    Friend WithEvents ucrChkCircRange As ucrCheck
    Friend WithEvents ucrChkAngVar As ucrCheck
    Friend WithEvents ucrChkrho As ucrCheck
    Friend WithEvents ucrChkAngDev As ucrCheck
    Friend WithEvents ucrChkVar As ucrCheck
    Friend WithEvents ucrChkSd As ucrCheck
    Friend WithEvents grpCircLocation As GroupBox
    Friend WithEvents ucrChkCircMedian As ucrCheck
    Friend WithEvents ucrChkMin As ucrCheck
    Friend WithEvents ucrChkMedianH As ucrCheck
    Friend WithEvents ucrChkQ3 As ucrCheck
    Friend WithEvents ucrChkQ1 As ucrCheck
    Friend WithEvents ucrChkMax As ucrCheck
    Friend WithEvents ucrChkCircMean As ucrCheck
    Friend WithEvents tbModel As TabPage
    Friend WithEvents ucrChkStandardErrorOfMean As ucrCheck
    Friend WithEvents tbPosition As TabPage
    Friend WithEvents ucrChkOrderBy As ucrCheck
    Friend WithEvents lblOrderBy As Label
    Friend WithEvents grpPosition As GroupBox
    Friend WithEvents ucrInputN As ucrInputTextBox
    Friend WithEvents lblInputN As Label
    Friend WithEvents ucrChkFirst As ucrCheck
    Friend WithEvents ucrChkLast As ucrCheck
    Friend WithEvents ucrChknth As ucrCheck
    Friend WithEvents ucrSelectorOrderBy As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverOrderBy As ucrReceiverSingle
    Friend WithEvents tbTwoVariables As TabPage
    Friend WithEvents tbSummaries As TabControl
    Friend WithEvents tbsum As TabPage
    Friend WithEvents grpCommon As GroupBox
    Friend WithEvents ucrChkn_distinct As ucrCheck
    Friend WithEvents ucrChkNTotal As ucrCheck
    Friend WithEvents ucrChkMode As ucrCheck
    Friend WithEvents ucrChkNMissing As ucrCheck
    Friend WithEvents ucrChkNonMissing As ucrCheck
    Friend WithEvents grpQuartilesTerciles As GroupBox
    Friend WithEvents ucrChkP25 As ucrCheck
    Friend WithEvents ucrChkP75 As ucrCheck
    Friend WithEvents grpNotOrderedFactor As GroupBox
    Friend WithEvents ucrChkRange As ucrCheck
    Friend WithEvents ucrChkMaximum As ucrCheck
    Friend WithEvents ucrChkMinimum As ucrCheck
    Friend WithEvents grpNumeric As GroupBox
    Friend WithEvents ucrChkVariance As ucrCheck
    Friend WithEvents ucrChkMedian As ucrCheck
    Friend WithEvents ucrChkStdDev As ucrCheck
    Friend WithEvents ucrChkSum As ucrCheck
    Friend WithEvents ucrChkMean As ucrCheck
    Friend WithEvents tbMore As TabPage
    Friend WithEvents grpProportionsPercentiles As GroupBox
    Friend WithEvents ucrInputQuantile As ucrInputTextBox
    Friend WithEvents ucrChkQuantile As ucrCheck
    Friend WithEvents ucrInputCountValue As ucrInputTextBox
    Friend WithEvents ucrInputComboCountTest As ucrInputComboBox
    Friend WithEvents ucrChkProportion As ucrCheck
    Friend WithEvents ucrChkCount As ucrCheck
    Friend WithEvents ucrChkPercentage As ucrCheck
    Friend WithEvents ucrInputPropValue As ucrInputTextBox
    Friend WithEvents ucrInputComboPropTest As ucrInputComboBox
    Friend WithEvents ucrInputPercentile As ucrInputTextBox
    Friend WithEvents ucrChkPercentile As ucrCheck
    Friend WithEvents grpLocation As GroupBox
    Friend WithEvents lblFractionTrimmed As Label
    Friend WithEvents ucrNudFraction As ucrNud
    Friend WithEvents ucrChkTrimmedMean As ucrCheck
    Friend WithEvents grpScale As GroupBox
    Friend WithEvents ucrChkQn As ucrCheck
    Friend WithEvents ucrChkSn As ucrCheck
    Friend WithEvents ucrChkCoefficientOfVariation As ucrCheck
    Friend WithEvents ucrChkMedianAbsoluteDeviation As ucrCheck
    Friend WithEvents grpSkewness As GroupBox
    Friend WithEvents ucrChkMc As ucrCheck
    Friend WithEvents ucrChkSkewness As ucrCheck
    Friend WithEvents grpKurtosis As GroupBox
    Friend WithEvents ucrChkKurtosis As ucrCheck
    Friend WithEvents grpRelationships As GroupBox
    Friend WithEvents ucrChkCovariance As ucrCheck
    Friend WithEvents ucrChkCorrelations As ucrCheck
    Friend WithEvents grpHyroGOF As GroupBox
    Friend WithEvents ucrChkRelativeIndexOfAgreement As ucrCheck
    Friend WithEvents ucrChkSumOfSquaredResiduals As ucrCheck
    Friend WithEvents ucrChkNormRootMeanSquaredError As ucrCheck
    Friend WithEvents ucrChkRatioOfRootMeanSquaredError As ucrCheck
    Friend WithEvents ucrChkMeanAbsoluteError As ucrCheck
    Friend WithEvents ucrChkModifiedIndexOfAgreement As ucrCheck
    Friend WithEvents ucrChkVolumetricEfficiency As ucrCheck
    Friend WithEvents ucrChkNashSutcliffeEfficiency As ucrCheck
    Friend WithEvents ucrChkPercentBias As ucrCheck
    Friend WithEvents ucrChkIndexOfAgreement As ucrCheck
    Friend WithEvents ucrChkCoefDetermination As ucrCheck
    Friend WithEvents ucrChkRatioOfStandardDeviation As ucrCheck
    Friend WithEvents ucrChkKlingGuptaEfficiency As ucrCheck
    Friend WithEvents ucrChkRelativeNashSutcliffeEff As ucrCheck
    Friend WithEvents ucrChkModNashSutcliffeEff As ucrCheck
    Friend WithEvents ucrChkMeanError As ucrCheck
    Friend WithEvents ucrChkMeanSquaredError As ucrCheck
    Friend WithEvents ucrChkRootMeanSquaredError As ucrCheck
    Friend WithEvents ucrChkCoefPersistence As ucrCheck
    Friend WithEvents ucrSelectorSecondVariable As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSecondVariable As Label
    Friend WithEvents ucrReceiverSecondVariable As ucrReceiverSingle
    Friend WithEvents cmdHelp As Button
    Friend WithEvents ttVerificationSummaries As ToolTip
    Friend WithEvents ucrChkSelectAll As ucrCheck
    Friend WithEvents lblJmia As Label
    Friend WithEvents ucrInputJmia As ucrInputTextBox
    Friend WithEvents grpDecilesQuintiles As GroupBox
    Friend WithEvents ucrChkP10 As ucrCheck
    Friend WithEvents ucrChkP20 As ucrCheck
    Friend WithEvents ucrChkP67 As ucrCheck
    Friend WithEvents ucrChkP33 As ucrCheck
    Friend WithEvents ucrChkP60 As ucrCheck
    Friend WithEvents ucrChkP90 As ucrCheck
    Friend WithEvents ucrChkP70 As ucrCheck
    Friend WithEvents ucrChkP80 As ucrCheck
    Friend WithEvents ucrChkP40 As ucrCheck
    Friend WithEvents ucrChkP30 As ucrCheck
    Friend WithEvents ucrChkSample As ucrCheck
    Friend WithEvents ucrChkSetseed As ucrCheck
    Friend WithEvents ucrNudSeed As ucrNud
End Class