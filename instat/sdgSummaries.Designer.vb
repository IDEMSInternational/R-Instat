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
        Me.tbCircular = New System.Windows.Forms.TabPage()
        Me.grpCircScale = New System.Windows.Forms.GroupBox()
        Me.grpCircLocation = New System.Windows.Forms.GroupBox()
        Me.tbModel = New System.Windows.Forms.TabPage()
        Me.tbPosition = New System.Windows.Forms.TabPage()
        Me.lblOrderBy = New System.Windows.Forms.Label()
        Me.grpPosition = New System.Windows.Forms.GroupBox()
        Me.lblInputN = New System.Windows.Forms.Label()
        Me.tbTwoVariables = New System.Windows.Forms.TabPage()
        Me.lblSecondVariable = New System.Windows.Forms.Label()
        Me.grpRelationships = New System.Windows.Forms.GroupBox()
        Me.grpHyroGOF = New System.Windows.Forms.GroupBox()
        Me.lblJmia = New System.Windows.Forms.Label()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.tbMore = New System.Windows.Forms.TabPage()
        Me.grpProportionsPercentiles = New System.Windows.Forms.GroupBox()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.lblFractionTrimmed = New System.Windows.Forms.Label()
        Me.grpScale = New System.Windows.Forms.GroupBox()
        Me.grpSkewness = New System.Windows.Forms.GroupBox()
        Me.grpKurtosis = New System.Windows.Forms.GroupBox()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.tbsum = New System.Windows.Forms.TabPage()
        Me.grpDecilesQuintiles = New System.Windows.Forms.GroupBox()
        Me.grpCommon = New System.Windows.Forms.GroupBox()
        Me.grpQuartilesTerciles = New System.Windows.Forms.GroupBox()
        Me.grpNotOrderedFactor = New System.Windows.Forms.GroupBox()
        Me.grpNumeric = New System.Windows.Forms.GroupBox()
        Me.tbSummaries = New System.Windows.Forms.TabControl()
        Me.ttVerificationSummaries = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrButtonsSummaries = New instat.ucrButtonsSubdialogue()
        Me.ucrChkP60 = New instat.ucrCheck()
        Me.ucrChkP90 = New instat.ucrCheck()
        Me.ucrChkP70 = New instat.ucrCheck()
        Me.ucrChkP80 = New instat.ucrCheck()
        Me.ucrChkP40 = New instat.ucrCheck()
        Me.ucrChkP30 = New instat.ucrCheck()
        Me.ucrChkP10 = New instat.ucrCheck()
        Me.ucrChkP20 = New instat.ucrCheck()
        Me.ucrChkn_distinct = New instat.ucrCheck()
        Me.ucrChkNTotal = New instat.ucrCheck()
        Me.ucrChkMode = New instat.ucrCheck()
        Me.ucrChkNMissing = New instat.ucrCheck()
        Me.ucrChkNonMissing = New instat.ucrCheck()
        Me.ucrChkP67 = New instat.ucrCheck()
        Me.ucrChkP33 = New instat.ucrCheck()
        Me.ucrChkP25 = New instat.ucrCheck()
        Me.ucrChkP75 = New instat.ucrCheck()
        Me.ucrChkRange = New instat.ucrCheck()
        Me.ucrChkMaximum = New instat.ucrCheck()
        Me.ucrChkMinimum = New instat.ucrCheck()
        Me.ucrChkVariance = New instat.ucrCheck()
        Me.ucrChkMedian = New instat.ucrCheck()
        Me.ucrChkStdDev = New instat.ucrCheck()
        Me.ucrChkSum = New instat.ucrCheck()
        Me.ucrChkMean = New instat.ucrCheck()
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
        Me.ucrNudFraction = New instat.ucrNud()
        Me.ucrChkTrimmedMean = New instat.ucrCheck()
        Me.ucrChkSn = New instat.ucrCheck()
        Me.ucrChkQn = New instat.ucrCheck()
        Me.ucrChkCoefficientOfVariation = New instat.ucrCheck()
        Me.ucrChkMedianAbsoluteDeviation = New instat.ucrCheck()
        Me.ucrChkMc = New instat.ucrCheck()
        Me.ucrChkSkewness = New instat.ucrCheck()
        Me.ucrChkProportionsPercentages = New instat.ucrCheck()
        Me.ucrChkKurtosis = New instat.ucrCheck()
        Me.ucrChkCovariance = New instat.ucrCheck()
        Me.ucrChkCorrelations = New instat.ucrCheck()
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
        Me.ucrChkNormRootMeanSquaredError = New instat.ucrCheck()
        Me.ucrChkMeanAbsoluteError = New instat.ucrCheck()
        Me.ucrChkIndexOfAgreement = New instat.ucrCheck()
        Me.ucrReceiverSecondVariable = New instat.ucrReceiverSingle()
        Me.ucrSelectorSecondVariable = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkOrderBy = New instat.ucrCheck()
        Me.ucrChkSetseed = New instat.ucrCheck()
        Me.ucrNudSeed = New instat.ucrNud()
        Me.ucrChkSample = New instat.ucrCheck()
        Me.ucrInputN = New instat.ucrInputTextBox()
        Me.ucrChkFirst = New instat.ucrCheck()
        Me.ucrChkLast = New instat.ucrCheck()
        Me.ucrChknth = New instat.ucrCheck()
        Me.ucrSelectorOrderBy = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverOrderBy = New instat.ucrReceiverSingle()
        Me.ucrChkStandardErrorOfMean = New instat.ucrCheck()
        Me.ucrChkCircRange = New instat.ucrCheck()
        Me.ucrChkAngVar = New instat.ucrCheck()
        Me.ucrChkrho = New instat.ucrCheck()
        Me.ucrChkAngDev = New instat.ucrCheck()
        Me.ucrChkVar = New instat.ucrCheck()
        Me.ucrChkSd = New instat.ucrCheck()
        Me.ucrChkCircMedian = New instat.ucrCheck()
        Me.ucrChkMin = New instat.ucrCheck()
        Me.ucrChkMedianH = New instat.ucrCheck()
        Me.ucrChkQ3 = New instat.ucrCheck()
        Me.ucrChkQ1 = New instat.ucrCheck()
        Me.ucrChkMax = New instat.ucrCheck()
        Me.ucrChkCircMean = New instat.ucrCheck()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbCircular
        '
        Me.tbCircular.Controls.Add(Me.grpCircScale)
        Me.tbCircular.Controls.Add(Me.grpCircLocation)
        Me.tbCircular.Location = New System.Drawing.Point(4, 29)
        Me.tbCircular.Name = "tbCircular"
        Me.tbCircular.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCircular.Size = New System.Drawing.Size(618, 581)
        Me.tbCircular.TabIndex = 8
        Me.tbCircular.Text = "Circular"
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
        Me.grpCircScale.Location = New System.Drawing.Point(6, 154)
        Me.grpCircScale.Name = "grpCircScale"
        Me.grpCircScale.Size = New System.Drawing.Size(602, 122)
        Me.grpCircScale.TabIndex = 1
        Me.grpCircScale.TabStop = False
        Me.grpCircScale.Text = "Scale"
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
        Me.grpCircLocation.Location = New System.Drawing.Point(6, 14)
        Me.grpCircLocation.Name = "grpCircLocation"
        Me.grpCircLocation.Size = New System.Drawing.Size(602, 135)
        Me.grpCircLocation.TabIndex = 0
        Me.grpCircLocation.TabStop = False
        Me.grpCircLocation.Text = "Location"
        '
        'tbModel
        '
        Me.tbModel.Controls.Add(Me.ucrChkStandardErrorOfMean)
        Me.tbModel.Location = New System.Drawing.Point(4, 29)
        Me.tbModel.Margin = New System.Windows.Forms.Padding(4)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Padding = New System.Windows.Forms.Padding(4)
        Me.tbModel.Size = New System.Drawing.Size(618, 581)
        Me.tbModel.TabIndex = 6
        Me.tbModel.Text = "Model"
        Me.tbModel.UseVisualStyleBackColor = True
        '
        'tbPosition
        '
        Me.tbPosition.Controls.Add(Me.ucrChkOrderBy)
        Me.tbPosition.Controls.Add(Me.lblOrderBy)
        Me.tbPosition.Controls.Add(Me.grpPosition)
        Me.tbPosition.Controls.Add(Me.ucrSelectorOrderBy)
        Me.tbPosition.Controls.Add(Me.ucrReceiverOrderBy)
        Me.tbPosition.Location = New System.Drawing.Point(4, 29)
        Me.tbPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPosition.Name = "tbPosition"
        Me.tbPosition.Padding = New System.Windows.Forms.Padding(4)
        Me.tbPosition.Size = New System.Drawing.Size(618, 581)
        Me.tbPosition.TabIndex = 7
        Me.tbPosition.Text = "Position"
        Me.tbPosition.UseVisualStyleBackColor = True
        '
        'lblOrderBy
        '
        Me.lblOrderBy.AutoSize = True
        Me.lblOrderBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOrderBy.Location = New System.Drawing.Point(344, 240)
        Me.lblOrderBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderBy.Name = "lblOrderBy"
        Me.lblOrderBy.Size = New System.Drawing.Size(75, 20)
        Me.lblOrderBy.TabIndex = 3
        Me.lblOrderBy.Text = "Order By:"
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
        Me.grpPosition.Location = New System.Drawing.Point(9, 9)
        Me.grpPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.grpPosition.Name = "grpPosition"
        Me.grpPosition.Padding = New System.Windows.Forms.Padding(4)
        Me.grpPosition.Size = New System.Drawing.Size(596, 120)
        Me.grpPosition.TabIndex = 0
        Me.grpPosition.TabStop = False
        Me.grpPosition.Text = "Position"
        '
        'lblInputN
        '
        Me.lblInputN.AutoSize = True
        Me.lblInputN.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInputN.Location = New System.Drawing.Point(322, 33)
        Me.lblInputN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInputN.Name = "lblInputN"
        Me.lblInputN.Size = New System.Drawing.Size(22, 20)
        Me.lblInputN.TabIndex = 2
        Me.lblInputN.Text = "n:"
        '
        'tbTwoVariables
        '
        Me.tbTwoVariables.Controls.Add(Me.lblSecondVariable)
        Me.tbTwoVariables.Controls.Add(Me.grpRelationships)
        Me.tbTwoVariables.Controls.Add(Me.grpHyroGOF)
        Me.tbTwoVariables.Controls.Add(Me.ucrReceiverSecondVariable)
        Me.tbTwoVariables.Controls.Add(Me.ucrSelectorSecondVariable)
        Me.tbTwoVariables.Location = New System.Drawing.Point(4, 29)
        Me.tbTwoVariables.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTwoVariables.Name = "tbTwoVariables"
        Me.tbTwoVariables.Padding = New System.Windows.Forms.Padding(4)
        Me.tbTwoVariables.Size = New System.Drawing.Size(618, 581)
        Me.tbTwoVariables.TabIndex = 5
        Me.tbTwoVariables.Text = " Two-Variables"
        Me.tbTwoVariables.UseVisualStyleBackColor = True
        '
        'lblSecondVariable
        '
        Me.lblSecondVariable.AutoSize = True
        Me.lblSecondVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondVariable.Location = New System.Drawing.Point(394, 310)
        Me.lblSecondVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondVariable.Name = "lblSecondVariable"
        Me.lblSecondVariable.Size = New System.Drawing.Size(130, 20)
        Me.lblSecondVariable.TabIndex = 3
        Me.lblSecondVariable.Text = "Second Variable:"
        '
        'grpRelationships
        '
        Me.grpRelationships.Controls.Add(Me.ucrChkCovariance)
        Me.grpRelationships.Controls.Add(Me.ucrChkCorrelations)
        Me.grpRelationships.Location = New System.Drawing.Point(6, 9)
        Me.grpRelationships.Margin = New System.Windows.Forms.Padding(4)
        Me.grpRelationships.Name = "grpRelationships"
        Me.grpRelationships.Padding = New System.Windows.Forms.Padding(4)
        Me.grpRelationships.Size = New System.Drawing.Size(598, 57)
        Me.grpRelationships.TabIndex = 0
        Me.grpRelationships.TabStop = False
        Me.grpRelationships.Text = "Relationships"
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
        Me.grpHyroGOF.Location = New System.Drawing.Point(9, 68)
        Me.grpHyroGOF.Margin = New System.Windows.Forms.Padding(4)
        Me.grpHyroGOF.Name = "grpHyroGOF"
        Me.grpHyroGOF.Padding = New System.Windows.Forms.Padding(4)
        Me.grpHyroGOF.Size = New System.Drawing.Size(598, 218)
        Me.grpHyroGOF.TabIndex = 1
        Me.grpHyroGOF.TabStop = False
        Me.grpHyroGOF.Text = "HydroGOF"
        '
        'lblJmia
        '
        Me.lblJmia.AutoSize = True
        Me.lblJmia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblJmia.Location = New System.Drawing.Point(426, 188)
        Me.lblJmia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJmia.Name = "lblJmia"
        Me.lblJmia.Size = New System.Drawing.Size(16, 20)
        Me.lblJmia.TabIndex = 20
        Me.lblJmia.Text = "j:"
        '
        'cmdHelp
        '
        Me.cmdHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHelp.Location = New System.Drawing.Point(496, 180)
        Me.cmdHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(102, 34)
        Me.cmdHelp.TabIndex = 22
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'tbMore
        '
        Me.tbMore.Controls.Add(Me.GroupBox1)
        Me.tbMore.Controls.Add(Me.grpProportionsPercentiles)
        Me.tbMore.Controls.Add(Me.grpLocation)
        Me.tbMore.Controls.Add(Me.grpScale)
        Me.tbMore.Controls.Add(Me.grpSkewness)
        Me.tbMore.Controls.Add(Me.grpKurtosis)
        Me.tbMore.Location = New System.Drawing.Point(4, 29)
        Me.tbMore.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMore.Name = "tbMore"
        Me.tbMore.Padding = New System.Windows.Forms.Padding(4)
        Me.tbMore.Size = New System.Drawing.Size(618, 601)
        Me.tbMore.TabIndex = 1
        Me.tbMore.Text = "More"
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
        Me.grpProportionsPercentiles.Location = New System.Drawing.Point(15, 9)
        Me.grpProportionsPercentiles.Margin = New System.Windows.Forms.Padding(4)
        Me.grpProportionsPercentiles.Name = "grpProportionsPercentiles"
        Me.grpProportionsPercentiles.Padding = New System.Windows.Forms.Padding(4)
        Me.grpProportionsPercentiles.Size = New System.Drawing.Size(590, 183)
        Me.grpProportionsPercentiles.TabIndex = 0
        Me.grpProportionsPercentiles.TabStop = False
        Me.grpProportionsPercentiles.Text = "Proportions/Percentiles/Count"
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.lblFractionTrimmed)
        Me.grpLocation.Controls.Add(Me.ucrNudFraction)
        Me.grpLocation.Controls.Add(Me.ucrChkTrimmedMean)
        Me.grpLocation.Location = New System.Drawing.Point(15, 197)
        Me.grpLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Padding = New System.Windows.Forms.Padding(4)
        Me.grpLocation.Size = New System.Drawing.Size(590, 78)
        Me.grpLocation.TabIndex = 0
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Location"
        '
        'lblFractionTrimmed
        '
        Me.lblFractionTrimmed.AutoSize = True
        Me.lblFractionTrimmed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFractionTrimmed.Location = New System.Drawing.Point(312, 32)
        Me.lblFractionTrimmed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFractionTrimmed.Name = "lblFractionTrimmed"
        Me.lblFractionTrimmed.Size = New System.Drawing.Size(136, 20)
        Me.lblFractionTrimmed.TabIndex = 1
        Me.lblFractionTrimmed.Text = "Fraction Trimmed:"
        '
        'grpScale
        '
        Me.grpScale.Controls.Add(Me.ucrChkSn)
        Me.grpScale.Controls.Add(Me.ucrChkQn)
        Me.grpScale.Controls.Add(Me.ucrChkCoefficientOfVariation)
        Me.grpScale.Controls.Add(Me.ucrChkMedianAbsoluteDeviation)
        Me.grpScale.Location = New System.Drawing.Point(15, 279)
        Me.grpScale.Margin = New System.Windows.Forms.Padding(4)
        Me.grpScale.Name = "grpScale"
        Me.grpScale.Padding = New System.Windows.Forms.Padding(4)
        Me.grpScale.Size = New System.Drawing.Size(590, 111)
        Me.grpScale.TabIndex = 1
        Me.grpScale.TabStop = False
        Me.grpScale.Text = "Scale"
        '
        'grpSkewness
        '
        Me.grpSkewness.Controls.Add(Me.ucrChkMc)
        Me.grpSkewness.Controls.Add(Me.ucrChkSkewness)
        Me.grpSkewness.Location = New System.Drawing.Point(15, 395)
        Me.grpSkewness.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSkewness.Name = "grpSkewness"
        Me.grpSkewness.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSkewness.Size = New System.Drawing.Size(590, 74)
        Me.grpSkewness.TabIndex = 2
        Me.grpSkewness.TabStop = False
        Me.grpSkewness.Text = "Skewness"
        '
        'grpKurtosis
        '
        Me.grpKurtosis.Controls.Add(Me.ucrChkKurtosis)
        Me.grpKurtosis.Location = New System.Drawing.Point(15, 467)
        Me.grpKurtosis.Margin = New System.Windows.Forms.Padding(4)
        Me.grpKurtosis.Name = "grpKurtosis"
        Me.grpKurtosis.Padding = New System.Windows.Forms.Padding(4)
        Me.grpKurtosis.Size = New System.Drawing.Size(590, 62)
        Me.grpKurtosis.TabIndex = 3
        Me.grpKurtosis.TabStop = False
        Me.grpKurtosis.Text = "Kurtosis"
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(471, 20)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(111, 34)
        Me.cmdOptions.TabIndex = 10
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'tbsum
        '
        Me.tbsum.Controls.Add(Me.grpDecilesQuintiles)
        Me.tbsum.Controls.Add(Me.grpCommon)
        Me.tbsum.Controls.Add(Me.grpQuartilesTerciles)
        Me.tbsum.Controls.Add(Me.grpNotOrderedFactor)
        Me.tbsum.Controls.Add(Me.grpNumeric)
        Me.tbsum.Location = New System.Drawing.Point(4, 29)
        Me.tbsum.Margin = New System.Windows.Forms.Padding(4)
        Me.tbsum.Name = "tbsum"
        Me.tbsum.Padding = New System.Windows.Forms.Padding(4)
        Me.tbsum.Size = New System.Drawing.Size(618, 581)
        Me.tbsum.TabIndex = 0
        Me.tbsum.Text = "Summaries"
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
        Me.grpDecilesQuintiles.Location = New System.Drawing.Point(15, 434)
        Me.grpDecilesQuintiles.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDecilesQuintiles.Name = "grpDecilesQuintiles"
        Me.grpDecilesQuintiles.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDecilesQuintiles.Size = New System.Drawing.Size(590, 130)
        Me.grpDecilesQuintiles.TabIndex = 4
        Me.grpDecilesQuintiles.TabStop = False
        Me.grpDecilesQuintiles.Tag = ""
        Me.grpDecilesQuintiles.Text = "Deciles && Quintiles"
        '
        'grpCommon
        '
        Me.grpCommon.Controls.Add(Me.ucrChkn_distinct)
        Me.grpCommon.Controls.Add(Me.ucrChkNTotal)
        Me.grpCommon.Controls.Add(Me.ucrChkMode)
        Me.grpCommon.Controls.Add(Me.ucrChkNMissing)
        Me.grpCommon.Controls.Add(Me.ucrChkNonMissing)
        Me.grpCommon.Location = New System.Drawing.Point(15, 9)
        Me.grpCommon.Margin = New System.Windows.Forms.Padding(4)
        Me.grpCommon.Name = "grpCommon"
        Me.grpCommon.Padding = New System.Windows.Forms.Padding(4)
        Me.grpCommon.Size = New System.Drawing.Size(590, 120)
        Me.grpCommon.TabIndex = 0
        Me.grpCommon.TabStop = False
        Me.grpCommon.Tag = "Common"
        Me.grpCommon.Text = "Common"
        '
        'grpQuartilesTerciles
        '
        Me.grpQuartilesTerciles.Controls.Add(Me.ucrChkP67)
        Me.grpQuartilesTerciles.Controls.Add(Me.ucrChkP33)
        Me.grpQuartilesTerciles.Controls.Add(Me.ucrChkP25)
        Me.grpQuartilesTerciles.Controls.Add(Me.ucrChkP75)
        Me.grpQuartilesTerciles.Location = New System.Drawing.Point(15, 345)
        Me.grpQuartilesTerciles.Margin = New System.Windows.Forms.Padding(4)
        Me.grpQuartilesTerciles.Name = "grpQuartilesTerciles"
        Me.grpQuartilesTerciles.Padding = New System.Windows.Forms.Padding(4)
        Me.grpQuartilesTerciles.Size = New System.Drawing.Size(590, 84)
        Me.grpQuartilesTerciles.TabIndex = 3
        Me.grpQuartilesTerciles.TabStop = False
        Me.grpQuartilesTerciles.Tag = "Quartiles"
        Me.grpQuartilesTerciles.Text = "Quartiles && Terciles"
        '
        'grpNotOrderedFactor
        '
        Me.grpNotOrderedFactor.Controls.Add(Me.ucrChkRange)
        Me.grpNotOrderedFactor.Controls.Add(Me.ucrChkMaximum)
        Me.grpNotOrderedFactor.Controls.Add(Me.ucrChkMinimum)
        Me.grpNotOrderedFactor.Location = New System.Drawing.Point(15, 138)
        Me.grpNotOrderedFactor.Margin = New System.Windows.Forms.Padding(4)
        Me.grpNotOrderedFactor.Name = "grpNotOrderedFactor"
        Me.grpNotOrderedFactor.Padding = New System.Windows.Forms.Padding(4)
        Me.grpNotOrderedFactor.Size = New System.Drawing.Size(590, 76)
        Me.grpNotOrderedFactor.TabIndex = 1
        Me.grpNotOrderedFactor.TabStop = False
        Me.grpNotOrderedFactor.Tag = "All_but_unordered_Factor"
        Me.grpNotOrderedFactor.Text = "All but (unordered) Factor"
        '
        'grpNumeric
        '
        Me.grpNumeric.Controls.Add(Me.ucrChkVariance)
        Me.grpNumeric.Controls.Add(Me.ucrChkMedian)
        Me.grpNumeric.Controls.Add(Me.ucrChkStdDev)
        Me.grpNumeric.Controls.Add(Me.ucrChkSum)
        Me.grpNumeric.Controls.Add(Me.ucrChkMean)
        Me.grpNumeric.Location = New System.Drawing.Point(15, 224)
        Me.grpNumeric.Margin = New System.Windows.Forms.Padding(4)
        Me.grpNumeric.Name = "grpNumeric"
        Me.grpNumeric.Padding = New System.Windows.Forms.Padding(4)
        Me.grpNumeric.Size = New System.Drawing.Size(590, 117)
        Me.grpNumeric.TabIndex = 2
        Me.grpNumeric.TabStop = False
        Me.grpNumeric.Tag = "Numeric"
        Me.grpNumeric.Text = "Numeric"
        '
        'tbSummaries
        '
        Me.tbSummaries.Controls.Add(Me.tbsum)
        Me.tbSummaries.Controls.Add(Me.tbMore)
        Me.tbSummaries.Controls.Add(Me.tbTwoVariables)
        Me.tbSummaries.Controls.Add(Me.tbPosition)
        Me.tbSummaries.Controls.Add(Me.tbModel)
        Me.tbSummaries.Controls.Add(Me.tbCircular)
        Me.tbSummaries.Location = New System.Drawing.Point(9, 10)
        Me.tbSummaries.Margin = New System.Windows.Forms.Padding(4)
        Me.tbSummaries.Name = "tbSummaries"
        Me.tbSummaries.SelectedIndex = 0
        Me.tbSummaries.Size = New System.Drawing.Size(626, 634)
        Me.tbSummaries.TabIndex = 0
        '
        'ucrButtonsSummaries
        '
        Me.ucrButtonsSummaries.AutoSize = True
        Me.ucrButtonsSummaries.Location = New System.Drawing.Point(153, 645)
        Me.ucrButtonsSummaries.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrButtonsSummaries.Name = "ucrButtonsSummaries"
        Me.ucrButtonsSummaries.Size = New System.Drawing.Size(336, 46)
        Me.ucrButtonsSummaries.TabIndex = 1
        '
        'ucrChkP60
        '
        Me.ucrChkP60.AutoSize = True
        Me.ucrChkP60.Checked = False
        Me.ucrChkP60.Location = New System.Drawing.Point(10, 76)
        Me.ucrChkP60.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkP60.Name = "ucrChkP60"
        Me.ucrChkP60.Size = New System.Drawing.Size(128, 51)
        Me.ucrChkP60.TabIndex = 7
        '
        'ucrChkP90
        '
        Me.ucrChkP90.AutoSize = True
        Me.ucrChkP90.Checked = False
        Me.ucrChkP90.Location = New System.Drawing.Point(438, 76)
        Me.ucrChkP90.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkP90.Name = "ucrChkP90"
        Me.ucrChkP90.Size = New System.Drawing.Size(128, 51)
        Me.ucrChkP90.TabIndex = 6
        '
        'ucrChkP70
        '
        Me.ucrChkP70.AutoSize = True
        Me.ucrChkP70.Checked = False
        Me.ucrChkP70.Location = New System.Drawing.Point(144, 76)
        Me.ucrChkP70.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkP70.Name = "ucrChkP70"
        Me.ucrChkP70.Size = New System.Drawing.Size(99, 51)
        Me.ucrChkP70.TabIndex = 5
        '
        'ucrChkP80
        '
        Me.ucrChkP80.AutoSize = True
        Me.ucrChkP80.Checked = False
        Me.ucrChkP80.Location = New System.Drawing.Point(252, 76)
        Me.ucrChkP80.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkP80.Name = "ucrChkP80"
        Me.ucrChkP80.Size = New System.Drawing.Size(128, 51)
        Me.ucrChkP80.TabIndex = 4
        '
        'ucrChkP40
        '
        Me.ucrChkP40.AutoSize = True
        Me.ucrChkP40.Checked = False
        Me.ucrChkP40.Location = New System.Drawing.Point(438, 32)
        Me.ucrChkP40.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkP40.Name = "ucrChkP40"
        Me.ucrChkP40.Size = New System.Drawing.Size(128, 51)
        Me.ucrChkP40.TabIndex = 3
        '
        'ucrChkP30
        '
        Me.ucrChkP30.AutoSize = True
        Me.ucrChkP30.Checked = False
        Me.ucrChkP30.Location = New System.Drawing.Point(252, 32)
        Me.ucrChkP30.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkP30.Name = "ucrChkP30"
        Me.ucrChkP30.Size = New System.Drawing.Size(128, 51)
        Me.ucrChkP30.TabIndex = 2
        '
        'ucrChkP10
        '
        Me.ucrChkP10.AutoSize = True
        Me.ucrChkP10.Checked = False
        Me.ucrChkP10.Location = New System.Drawing.Point(10, 32)
        Me.ucrChkP10.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkP10.Name = "ucrChkP10"
        Me.ucrChkP10.Size = New System.Drawing.Size(128, 51)
        Me.ucrChkP10.TabIndex = 0
        '
        'ucrChkP20
        '
        Me.ucrChkP20.AutoSize = True
        Me.ucrChkP20.Checked = False
        Me.ucrChkP20.Location = New System.Drawing.Point(144, 32)
        Me.ucrChkP20.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkP20.Name = "ucrChkP20"
        Me.ucrChkP20.Size = New System.Drawing.Size(99, 51)
        Me.ucrChkP20.TabIndex = 1
        '
        'ucrChkn_distinct
        '
        Me.ucrChkn_distinct.AutoSize = True
        Me.ucrChkn_distinct.Checked = False
        Me.ucrChkn_distinct.Location = New System.Drawing.Point(252, 74)
        Me.ucrChkn_distinct.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkn_distinct.Name = "ucrChkn_distinct"
        Me.ucrChkn_distinct.Size = New System.Drawing.Size(152, 51)
        Me.ucrChkn_distinct.TabIndex = 3
        '
        'ucrChkNTotal
        '
        Me.ucrChkNTotal.AutoSize = True
        Me.ucrChkNTotal.Checked = False
        Me.ucrChkNTotal.Location = New System.Drawing.Point(252, 28)
        Me.ucrChkNTotal.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkNTotal.Name = "ucrChkNTotal"
        Me.ucrChkNTotal.Size = New System.Drawing.Size(150, 51)
        Me.ucrChkNTotal.TabIndex = 2
        '
        'ucrChkMode
        '
        Me.ucrChkMode.AutoSize = True
        Me.ucrChkMode.Checked = False
        Me.ucrChkMode.Location = New System.Drawing.Point(10, 74)
        Me.ucrChkMode.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkMode.Name = "ucrChkMode"
        Me.ucrChkMode.Size = New System.Drawing.Size(150, 51)
        Me.ucrChkMode.TabIndex = 1
        '
        'ucrChkNMissing
        '
        Me.ucrChkNMissing.AutoSize = True
        Me.ucrChkNMissing.Checked = False
        Me.ucrChkNMissing.Location = New System.Drawing.Point(438, 28)
        Me.ucrChkNMissing.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkNMissing.Name = "ucrChkNMissing"
        Me.ucrChkNMissing.Size = New System.Drawing.Size(128, 51)
        Me.ucrChkNMissing.TabIndex = 4
        '
        'ucrChkNonMissing
        '
        Me.ucrChkNonMissing.AutoSize = True
        Me.ucrChkNonMissing.Checked = False
        Me.ucrChkNonMissing.Location = New System.Drawing.Point(10, 28)
        Me.ucrChkNonMissing.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkNonMissing.Name = "ucrChkNonMissing"
        Me.ucrChkNonMissing.Size = New System.Drawing.Size(194, 51)
        Me.ucrChkNonMissing.TabIndex = 0
        '
        'ucrChkP67
        '
        Me.ucrChkP67.AutoSize = True
        Me.ucrChkP67.Checked = False
        Me.ucrChkP67.Location = New System.Drawing.Point(252, 28)
        Me.ucrChkP67.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkP67.Name = "ucrChkP67"
        Me.ucrChkP67.Size = New System.Drawing.Size(128, 51)
        Me.ucrChkP67.TabIndex = 3
        '
        'ucrChkP33
        '
        Me.ucrChkP33.AutoSize = True
        Me.ucrChkP33.Checked = False
        Me.ucrChkP33.Location = New System.Drawing.Point(144, 28)
        Me.ucrChkP33.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkP33.Name = "ucrChkP33"
        Me.ucrChkP33.Size = New System.Drawing.Size(99, 51)
        Me.ucrChkP33.TabIndex = 2
        '
        'ucrChkP25
        '
        Me.ucrChkP25.AutoSize = True
        Me.ucrChkP25.Checked = False
        Me.ucrChkP25.Location = New System.Drawing.Point(10, 28)
        Me.ucrChkP25.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkP25.Name = "ucrChkP25"
        Me.ucrChkP25.Size = New System.Drawing.Size(128, 51)
        Me.ucrChkP25.TabIndex = 0
        '
        'ucrChkP75
        '
        Me.ucrChkP75.AutoSize = True
        Me.ucrChkP75.Checked = False
        Me.ucrChkP75.Location = New System.Drawing.Point(438, 28)
        Me.ucrChkP75.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkP75.Name = "ucrChkP75"
        Me.ucrChkP75.Size = New System.Drawing.Size(128, 51)
        Me.ucrChkP75.TabIndex = 1
        '
        'ucrChkRange
        '
        Me.ucrChkRange.AutoSize = True
        Me.ucrChkRange.Checked = False
        Me.ucrChkRange.Location = New System.Drawing.Point(438, 28)
        Me.ucrChkRange.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkRange.Name = "ucrChkRange"
        Me.ucrChkRange.Size = New System.Drawing.Size(128, 51)
        Me.ucrChkRange.TabIndex = 1
        '
        'ucrChkMaximum
        '
        Me.ucrChkMaximum.AutoSize = True
        Me.ucrChkMaximum.Checked = False
        Me.ucrChkMaximum.Location = New System.Drawing.Point(252, 28)
        Me.ucrChkMaximum.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkMaximum.Name = "ucrChkMaximum"
        Me.ucrChkMaximum.Size = New System.Drawing.Size(150, 51)
        Me.ucrChkMaximum.TabIndex = 2
        '
        'ucrChkMinimum
        '
        Me.ucrChkMinimum.AutoSize = True
        Me.ucrChkMinimum.Checked = False
        Me.ucrChkMinimum.Location = New System.Drawing.Point(10, 28)
        Me.ucrChkMinimum.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkMinimum.Name = "ucrChkMinimum"
        Me.ucrChkMinimum.Size = New System.Drawing.Size(150, 51)
        Me.ucrChkMinimum.TabIndex = 0
        '
        'ucrChkVariance
        '
        Me.ucrChkVariance.AutoSize = True
        Me.ucrChkVariance.Checked = False
        Me.ucrChkVariance.Location = New System.Drawing.Point(252, 74)
        Me.ucrChkVariance.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkVariance.Name = "ucrChkVariance"
        Me.ucrChkVariance.Size = New System.Drawing.Size(236, 51)
        Me.ucrChkVariance.TabIndex = 3
        '
        'ucrChkMedian
        '
        Me.ucrChkMedian.AutoSize = True
        Me.ucrChkMedian.Checked = False
        Me.ucrChkMedian.Location = New System.Drawing.Point(438, 28)
        Me.ucrChkMedian.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkMedian.Name = "ucrChkMedian"
        Me.ucrChkMedian.Size = New System.Drawing.Size(154, 51)
        Me.ucrChkMedian.TabIndex = 4
        '
        'ucrChkStdDev
        '
        Me.ucrChkStdDev.AutoSize = True
        Me.ucrChkStdDev.Checked = False
        Me.ucrChkStdDev.Location = New System.Drawing.Point(10, 74)
        Me.ucrChkStdDev.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkStdDev.Name = "ucrChkStdDev"
        Me.ucrChkStdDev.Size = New System.Drawing.Size(232, 51)
        Me.ucrChkStdDev.TabIndex = 1
        '
        'ucrChkSum
        '
        Me.ucrChkSum.AutoSize = True
        Me.ucrChkSum.Checked = False
        Me.ucrChkSum.Location = New System.Drawing.Point(10, 28)
        Me.ucrChkSum.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkSum.Name = "ucrChkSum"
        Me.ucrChkSum.Size = New System.Drawing.Size(150, 51)
        Me.ucrChkSum.TabIndex = 0
        '
        'ucrChkMean
        '
        Me.ucrChkMean.AutoSize = True
        Me.ucrChkMean.Checked = False
        Me.ucrChkMean.Location = New System.Drawing.Point(252, 28)
        Me.ucrChkMean.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkMean.Name = "ucrChkMean"
        Me.ucrChkMean.Size = New System.Drawing.Size(150, 51)
        Me.ucrChkMean.TabIndex = 2
        '
        'ucrInputQuantile
        '
        Me.ucrInputQuantile.AddQuotesIfUnrecognised = True
        Me.ucrInputQuantile.AutoSize = True
        Me.ucrInputQuantile.IsMultiline = False
        Me.ucrInputQuantile.IsReadOnly = False
        Me.ucrInputQuantile.Location = New System.Drawing.Point(178, 140)
        Me.ucrInputQuantile.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrInputQuantile.Name = "ucrInputQuantile"
        Me.ucrInputQuantile.Size = New System.Drawing.Size(78, 32)
        Me.ucrInputQuantile.TabIndex = 10
        '
        'ucrChkQuantile
        '
        Me.ucrChkQuantile.AutoSize = True
        Me.ucrChkQuantile.Checked = False
        Me.ucrChkQuantile.Location = New System.Drawing.Point(10, 144)
        Me.ucrChkQuantile.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkQuantile.Name = "ucrChkQuantile"
        Me.ucrChkQuantile.Size = New System.Drawing.Size(162, 51)
        Me.ucrChkQuantile.TabIndex = 9
        '
        'ucrInputCountValue
        '
        Me.ucrInputCountValue.AddQuotesIfUnrecognised = True
        Me.ucrInputCountValue.AutoSize = True
        Me.ucrInputCountValue.IsMultiline = False
        Me.ucrInputCountValue.IsReadOnly = False
        Me.ucrInputCountValue.Location = New System.Drawing.Point(262, 102)
        Me.ucrInputCountValue.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.ucrInputCountValue.Name = "ucrInputCountValue"
        Me.ucrInputCountValue.Size = New System.Drawing.Size(76, 30)
        Me.ucrInputCountValue.TabIndex = 8
        '
        'ucrInputComboCountTest
        '
        Me.ucrInputComboCountTest.AccessibleName = ""
        Me.ucrInputComboCountTest.AddQuotesIfUnrecognised = True
        Me.ucrInputComboCountTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboCountTest.GetSetSelectedIndex = -1
        Me.ucrInputComboCountTest.IsReadOnly = False
        Me.ucrInputComboCountTest.Location = New System.Drawing.Point(178, 102)
        Me.ucrInputComboCountTest.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.ucrInputComboCountTest.Name = "ucrInputComboCountTest"
        Me.ucrInputComboCountTest.Size = New System.Drawing.Size(76, 38)
        Me.ucrInputComboCountTest.TabIndex = 7
        '
        'ucrChkProportion
        '
        Me.ucrChkProportion.AutoSize = True
        Me.ucrChkProportion.Checked = False
        Me.ucrChkProportion.Location = New System.Drawing.Point(10, 68)
        Me.ucrChkProportion.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkProportion.Name = "ucrChkProportion"
        Me.ucrChkProportion.Size = New System.Drawing.Size(162, 51)
        Me.ucrChkProportion.TabIndex = 2
        '
        'ucrChkCount
        '
        Me.ucrChkCount.AutoSize = True
        Me.ucrChkCount.Checked = False
        Me.ucrChkCount.Location = New System.Drawing.Point(10, 106)
        Me.ucrChkCount.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkCount.Name = "ucrChkCount"
        Me.ucrChkCount.Size = New System.Drawing.Size(162, 51)
        Me.ucrChkCount.TabIndex = 6
        '
        'ucrChkPercentage
        '
        Me.ucrChkPercentage.AutoSize = True
        Me.ucrChkPercentage.Checked = False
        Me.ucrChkPercentage.Location = New System.Drawing.Point(357, 68)
        Me.ucrChkPercentage.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkPercentage.Name = "ucrChkPercentage"
        Me.ucrChkPercentage.Size = New System.Drawing.Size(152, 51)
        Me.ucrChkPercentage.TabIndex = 5
        '
        'ucrInputPropValue
        '
        Me.ucrInputPropValue.AddQuotesIfUnrecognised = True
        Me.ucrInputPropValue.AutoSize = True
        Me.ucrInputPropValue.IsMultiline = False
        Me.ucrInputPropValue.IsReadOnly = False
        Me.ucrInputPropValue.Location = New System.Drawing.Point(262, 64)
        Me.ucrInputPropValue.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.ucrInputPropValue.Name = "ucrInputPropValue"
        Me.ucrInputPropValue.Size = New System.Drawing.Size(76, 30)
        Me.ucrInputPropValue.TabIndex = 4
        '
        'ucrInputComboPropTest
        '
        Me.ucrInputComboPropTest.AccessibleName = ""
        Me.ucrInputComboPropTest.AddQuotesIfUnrecognised = True
        Me.ucrInputComboPropTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboPropTest.GetSetSelectedIndex = -1
        Me.ucrInputComboPropTest.IsReadOnly = False
        Me.ucrInputComboPropTest.Location = New System.Drawing.Point(178, 64)
        Me.ucrInputComboPropTest.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.ucrInputComboPropTest.Name = "ucrInputComboPropTest"
        Me.ucrInputComboPropTest.Size = New System.Drawing.Size(76, 38)
        Me.ucrInputComboPropTest.TabIndex = 3
        '
        'ucrInputPercentile
        '
        Me.ucrInputPercentile.AddQuotesIfUnrecognised = True
        Me.ucrInputPercentile.AutoSize = True
        Me.ucrInputPercentile.IsMultiline = False
        Me.ucrInputPercentile.IsReadOnly = False
        Me.ucrInputPercentile.Location = New System.Drawing.Point(178, 28)
        Me.ucrInputPercentile.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.ucrInputPercentile.Name = "ucrInputPercentile"
        Me.ucrInputPercentile.Size = New System.Drawing.Size(76, 30)
        Me.ucrInputPercentile.TabIndex = 1
        '
        'ucrChkPercentile
        '
        Me.ucrChkPercentile.AutoSize = True
        Me.ucrChkPercentile.Checked = False
        Me.ucrChkPercentile.Location = New System.Drawing.Point(10, 28)
        Me.ucrChkPercentile.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkPercentile.Name = "ucrChkPercentile"
        Me.ucrChkPercentile.Size = New System.Drawing.Size(162, 51)
        Me.ucrChkPercentile.TabIndex = 0
        '
        'ucrNudFraction
        '
        Me.ucrNudFraction.AutoSize = True
        Me.ucrNudFraction.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFraction.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFraction.Location = New System.Drawing.Point(454, 27)
        Me.ucrNudFraction.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrNudFraction.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFraction.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFraction.Name = "ucrNudFraction"
        Me.ucrNudFraction.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudFraction.TabIndex = 2
        Me.ucrNudFraction.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkTrimmedMean
        '
        Me.ucrChkTrimmedMean.AutoSize = True
        Me.ucrChkTrimmedMean.Checked = False
        Me.ucrChkTrimmedMean.Location = New System.Drawing.Point(10, 28)
        Me.ucrChkTrimmedMean.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkTrimmedMean.Name = "ucrChkTrimmedMean"
        Me.ucrChkTrimmedMean.Size = New System.Drawing.Size(180, 51)
        Me.ucrChkTrimmedMean.TabIndex = 0
        '
        'ucrChkSn
        '
        Me.ucrChkSn.AutoSize = True
        Me.ucrChkSn.Checked = False
        Me.ucrChkSn.Location = New System.Drawing.Point(312, 69)
        Me.ucrChkSn.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkSn.Name = "ucrChkSn"
        Me.ucrChkSn.Size = New System.Drawing.Size(152, 51)
        Me.ucrChkSn.TabIndex = 3
        '
        'ucrChkQn
        '
        Me.ucrChkQn.AutoSize = True
        Me.ucrChkQn.Checked = False
        Me.ucrChkQn.Location = New System.Drawing.Point(312, 28)
        Me.ucrChkQn.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkQn.Name = "ucrChkQn"
        Me.ucrChkQn.Size = New System.Drawing.Size(152, 51)
        Me.ucrChkQn.TabIndex = 2
        '
        'ucrChkCoefficientOfVariation
        '
        Me.ucrChkCoefficientOfVariation.AutoSize = True
        Me.ucrChkCoefficientOfVariation.Checked = False
        Me.ucrChkCoefficientOfVariation.Location = New System.Drawing.Point(10, 28)
        Me.ucrChkCoefficientOfVariation.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkCoefficientOfVariation.Name = "ucrChkCoefficientOfVariation"
        Me.ucrChkCoefficientOfVariation.Size = New System.Drawing.Size(300, 51)
        Me.ucrChkCoefficientOfVariation.TabIndex = 0
        '
        'ucrChkMedianAbsoluteDeviation
        '
        Me.ucrChkMedianAbsoluteDeviation.AutoSize = True
        Me.ucrChkMedianAbsoluteDeviation.Checked = False
        Me.ucrChkMedianAbsoluteDeviation.Location = New System.Drawing.Point(10, 68)
        Me.ucrChkMedianAbsoluteDeviation.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkMedianAbsoluteDeviation.Name = "ucrChkMedianAbsoluteDeviation"
        Me.ucrChkMedianAbsoluteDeviation.Size = New System.Drawing.Size(393, 51)
        Me.ucrChkMedianAbsoluteDeviation.TabIndex = 1
        '
        'ucrChkMc
        '
        Me.ucrChkMc.AutoSize = True
        Me.ucrChkMc.Checked = False
        Me.ucrChkMc.Location = New System.Drawing.Point(312, 28)
        Me.ucrChkMc.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkMc.Name = "ucrChkMc"
        Me.ucrChkMc.Size = New System.Drawing.Size(152, 51)
        Me.ucrChkMc.TabIndex = 1
        '
        'ucrChkSkewness
        '
        Me.ucrChkSkewness.AutoSize = True
        Me.ucrChkSkewness.Checked = False
        Me.ucrChkSkewness.Location = New System.Drawing.Point(10, 28)
        Me.ucrChkSkewness.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkSkewness.Name = "ucrChkSkewness"
        Me.ucrChkSkewness.Size = New System.Drawing.Size(381, 51)
        Me.ucrChkSkewness.TabIndex = 0
        '
        'ucrChkProportionsPercentages
        '
        Me.ucrChkProportionsPercentages.AutoSize = True
        Me.ucrChkProportionsPercentages.Checked = False
        Me.ucrChkProportionsPercentages.Location = New System.Drawing.Point(10, 19)
        Me.ucrChkProportionsPercentages.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkProportionsPercentages.Name = "ucrChkProportionsPercentages"
        Me.ucrChkProportionsPercentages.Size = New System.Drawing.Size(438, 34)
        Me.ucrChkProportionsPercentages.TabIndex = 1
        '
        'ucrChkKurtosis
        '
        Me.ucrChkKurtosis.AutoSize = True
        Me.ucrChkKurtosis.Checked = False
        Me.ucrChkKurtosis.Location = New System.Drawing.Point(10, 25)
        Me.ucrChkKurtosis.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkKurtosis.Name = "ucrChkKurtosis"
        Me.ucrChkKurtosis.Size = New System.Drawing.Size(180, 34)
        Me.ucrChkKurtosis.TabIndex = 0
        '
        'ucrChkCovariance
        '
        Me.ucrChkCovariance.AutoSize = True
        Me.ucrChkCovariance.Checked = False
        Me.ucrChkCovariance.Location = New System.Drawing.Point(249, 15)
        Me.ucrChkCovariance.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkCovariance.Name = "ucrChkCovariance"
        Me.ucrChkCovariance.Size = New System.Drawing.Size(250, 51)
        Me.ucrChkCovariance.TabIndex = 1
        '
        'ucrChkCorrelations
        '
        Me.ucrChkCorrelations.AutoSize = True
        Me.ucrChkCorrelations.Checked = False
        Me.ucrChkCorrelations.Location = New System.Drawing.Point(22, 20)
        Me.ucrChkCorrelations.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkCorrelations.Name = "ucrChkCorrelations"
        Me.ucrChkCorrelations.Size = New System.Drawing.Size(224, 51)
        Me.ucrChkCorrelations.TabIndex = 0
        '
        'ucrInputJmia
        '
        Me.ucrInputJmia.AddQuotesIfUnrecognised = True
        Me.ucrInputJmia.AutoSize = True
        Me.ucrInputJmia.IsMultiline = False
        Me.ucrInputJmia.IsReadOnly = False
        Me.ucrInputJmia.Location = New System.Drawing.Point(448, 183)
        Me.ucrInputJmia.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputJmia.Name = "ucrInputJmia"
        Me.ucrInputJmia.Size = New System.Drawing.Size(48, 32)
        Me.ucrInputJmia.TabIndex = 21
        '
        'ucrChkSelectAll
        '
        Me.ucrChkSelectAll.AutoSize = True
        Me.ucrChkSelectAll.Checked = False
        Me.ucrChkSelectAll.Location = New System.Drawing.Point(14, 22)
        Me.ucrChkSelectAll.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkSelectAll.Name = "ucrChkSelectAll"
        Me.ucrChkSelectAll.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkSelectAll.TabIndex = 0
        '
        'ucrChkRelativeIndexOfAgreement
        '
        Me.ucrChkRelativeIndexOfAgreement.AutoSize = True
        Me.ucrChkRelativeIndexOfAgreement.Checked = False
        Me.ucrChkRelativeIndexOfAgreement.Location = New System.Drawing.Point(306, 112)
        Me.ucrChkRelativeIndexOfAgreement.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkRelativeIndexOfAgreement.Name = "ucrChkRelativeIndexOfAgreement"
        Me.ucrChkRelativeIndexOfAgreement.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkRelativeIndexOfAgreement.TabIndex = 13
        '
        'ucrChkRatioOfStandardDeviation
        '
        Me.ucrChkRatioOfStandardDeviation.AutoSize = True
        Me.ucrChkRatioOfStandardDeviation.Checked = False
        Me.ucrChkRatioOfStandardDeviation.Location = New System.Drawing.Point(141, 81)
        Me.ucrChkRatioOfStandardDeviation.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkRatioOfStandardDeviation.Name = "ucrChkRatioOfStandardDeviation"
        Me.ucrChkRatioOfStandardDeviation.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkRatioOfStandardDeviation.TabIndex = 7
        '
        'ucrChkCoefDetermination
        '
        Me.ucrChkCoefDetermination.AutoSize = True
        Me.ucrChkCoefDetermination.Checked = False
        Me.ucrChkCoefDetermination.Location = New System.Drawing.Point(306, 174)
        Me.ucrChkCoefDetermination.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkCoefDetermination.Name = "ucrChkCoefDetermination"
        Me.ucrChkCoefDetermination.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkCoefDetermination.TabIndex = 15
        '
        'ucrChkRatioOfRootMeanSquaredError
        '
        Me.ucrChkRatioOfRootMeanSquaredError.AutoSize = True
        Me.ucrChkRatioOfRootMeanSquaredError.Checked = False
        Me.ucrChkRatioOfRootMeanSquaredError.Location = New System.Drawing.Point(141, 51)
        Me.ucrChkRatioOfRootMeanSquaredError.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkRatioOfRootMeanSquaredError.Name = "ucrChkRatioOfRootMeanSquaredError"
        Me.ucrChkRatioOfRootMeanSquaredError.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkRatioOfRootMeanSquaredError.TabIndex = 6
        '
        'ucrChkRelativeNashSutcliffeEff
        '
        Me.ucrChkRelativeNashSutcliffeEff.AutoSize = True
        Me.ucrChkRelativeNashSutcliffeEff.Checked = False
        Me.ucrChkRelativeNashSutcliffeEff.Location = New System.Drawing.Point(141, 172)
        Me.ucrChkRelativeNashSutcliffeEff.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkRelativeNashSutcliffeEff.Name = "ucrChkRelativeNashSutcliffeEff"
        Me.ucrChkRelativeNashSutcliffeEff.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkRelativeNashSutcliffeEff.TabIndex = 10
        '
        'ucrChkModifiedIndexOfAgreement
        '
        Me.ucrChkModifiedIndexOfAgreement.AutoSize = True
        Me.ucrChkModifiedIndexOfAgreement.Checked = False
        Me.ucrChkModifiedIndexOfAgreement.Location = New System.Drawing.Point(306, 54)
        Me.ucrChkModifiedIndexOfAgreement.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkModifiedIndexOfAgreement.Name = "ucrChkModifiedIndexOfAgreement"
        Me.ucrChkModifiedIndexOfAgreement.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkModifiedIndexOfAgreement.TabIndex = 11
        '
        'ucrChkCoefPersistence
        '
        Me.ucrChkCoefPersistence.AutoSize = True
        Me.ucrChkCoefPersistence.Checked = False
        Me.ucrChkCoefPersistence.Location = New System.Drawing.Point(306, 142)
        Me.ucrChkCoefPersistence.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkCoefPersistence.Name = "ucrChkCoefPersistence"
        Me.ucrChkCoefPersistence.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkCoefPersistence.TabIndex = 14
        '
        'ucrChkNashSutcliffeEfficiency
        '
        Me.ucrChkNashSutcliffeEfficiency.AutoSize = True
        Me.ucrChkNashSutcliffeEfficiency.Checked = False
        Me.ucrChkNashSutcliffeEfficiency.Location = New System.Drawing.Point(141, 112)
        Me.ucrChkNashSutcliffeEfficiency.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkNashSutcliffeEfficiency.Name = "ucrChkNashSutcliffeEfficiency"
        Me.ucrChkNashSutcliffeEfficiency.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkNashSutcliffeEfficiency.TabIndex = 8
        '
        'ucrChkSumOfSquaredResiduals
        '
        Me.ucrChkSumOfSquaredResiduals.AutoSize = True
        Me.ucrChkSumOfSquaredResiduals.Checked = False
        Me.ucrChkSumOfSquaredResiduals.Location = New System.Drawing.Point(459, 150)
        Me.ucrChkSumOfSquaredResiduals.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkSumOfSquaredResiduals.Name = "ucrChkSumOfSquaredResiduals"
        Me.ucrChkSumOfSquaredResiduals.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkSumOfSquaredResiduals.TabIndex = 19
        '
        'ucrChkKlingGuptaEfficiency
        '
        Me.ucrChkKlingGuptaEfficiency.AutoSize = True
        Me.ucrChkKlingGuptaEfficiency.Checked = False
        Me.ucrChkKlingGuptaEfficiency.Location = New System.Drawing.Point(459, 57)
        Me.ucrChkKlingGuptaEfficiency.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkKlingGuptaEfficiency.Name = "ucrChkKlingGuptaEfficiency"
        Me.ucrChkKlingGuptaEfficiency.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkKlingGuptaEfficiency.TabIndex = 16
        '
        'ucrChkVolumetricEfficiency
        '
        Me.ucrChkVolumetricEfficiency.AutoSize = True
        Me.ucrChkVolumetricEfficiency.Checked = False
        Me.ucrChkVolumetricEfficiency.Location = New System.Drawing.Point(459, 87)
        Me.ucrChkVolumetricEfficiency.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkVolumetricEfficiency.Name = "ucrChkVolumetricEfficiency"
        Me.ucrChkVolumetricEfficiency.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkVolumetricEfficiency.TabIndex = 17
        '
        'ucrChkPercentBias
        '
        Me.ucrChkPercentBias.AutoSize = True
        Me.ucrChkPercentBias.Checked = False
        Me.ucrChkPercentBias.Location = New System.Drawing.Point(12, 174)
        Me.ucrChkPercentBias.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkPercentBias.Name = "ucrChkPercentBias"
        Me.ucrChkPercentBias.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkPercentBias.TabIndex = 5
        '
        'ucrChkModNashSutcliffeEff
        '
        Me.ucrChkModNashSutcliffeEff.AutoSize = True
        Me.ucrChkModNashSutcliffeEff.Checked = False
        Me.ucrChkModNashSutcliffeEff.Location = New System.Drawing.Point(141, 142)
        Me.ucrChkModNashSutcliffeEff.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkModNashSutcliffeEff.Name = "ucrChkModNashSutcliffeEff"
        Me.ucrChkModNashSutcliffeEff.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkModNashSutcliffeEff.TabIndex = 9
        '
        'ucrChkMeanError
        '
        Me.ucrChkMeanError.AutoSize = True
        Me.ucrChkMeanError.Checked = False
        Me.ucrChkMeanError.Location = New System.Drawing.Point(12, 51)
        Me.ucrChkMeanError.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkMeanError.Name = "ucrChkMeanError"
        Me.ucrChkMeanError.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkMeanError.TabIndex = 1
        '
        'ucrChkMeanSquaredError
        '
        Me.ucrChkMeanSquaredError.AutoSize = True
        Me.ucrChkMeanSquaredError.Checked = False
        Me.ucrChkMeanSquaredError.Location = New System.Drawing.Point(459, 118)
        Me.ucrChkMeanSquaredError.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkMeanSquaredError.Name = "ucrChkMeanSquaredError"
        Me.ucrChkMeanSquaredError.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkMeanSquaredError.TabIndex = 18
        '
        'ucrChkRootMeanSquaredError
        '
        Me.ucrChkRootMeanSquaredError.AutoSize = True
        Me.ucrChkRootMeanSquaredError.Checked = False
        Me.ucrChkRootMeanSquaredError.Location = New System.Drawing.Point(12, 111)
        Me.ucrChkRootMeanSquaredError.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkRootMeanSquaredError.Name = "ucrChkRootMeanSquaredError"
        Me.ucrChkRootMeanSquaredError.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkRootMeanSquaredError.TabIndex = 3
        '
        'ucrChkNormRootMeanSquaredError
        '
        Me.ucrChkNormRootMeanSquaredError.AutoSize = True
        Me.ucrChkNormRootMeanSquaredError.Checked = False
        Me.ucrChkNormRootMeanSquaredError.Location = New System.Drawing.Point(12, 142)
        Me.ucrChkNormRootMeanSquaredError.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkNormRootMeanSquaredError.Name = "ucrChkNormRootMeanSquaredError"
        Me.ucrChkNormRootMeanSquaredError.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkNormRootMeanSquaredError.TabIndex = 4
        '
        'ucrChkMeanAbsoluteError
        '
        Me.ucrChkMeanAbsoluteError.AutoSize = True
        Me.ucrChkMeanAbsoluteError.Checked = False
        Me.ucrChkMeanAbsoluteError.Location = New System.Drawing.Point(12, 81)
        Me.ucrChkMeanAbsoluteError.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkMeanAbsoluteError.Name = "ucrChkMeanAbsoluteError"
        Me.ucrChkMeanAbsoluteError.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkMeanAbsoluteError.TabIndex = 2
        '
        'ucrChkIndexOfAgreement
        '
        Me.ucrChkIndexOfAgreement.AutoSize = True
        Me.ucrChkIndexOfAgreement.Checked = False
        Me.ucrChkIndexOfAgreement.Location = New System.Drawing.Point(306, 86)
        Me.ucrChkIndexOfAgreement.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkIndexOfAgreement.Name = "ucrChkIndexOfAgreement"
        Me.ucrChkIndexOfAgreement.Size = New System.Drawing.Size(130, 51)
        Me.ucrChkIndexOfAgreement.TabIndex = 12
        '
        'ucrReceiverSecondVariable
        '
        Me.ucrReceiverSecondVariable.AutoSize = True
        Me.ucrReceiverSecondVariable.frmParent = Nothing
        Me.ucrReceiverSecondVariable.Location = New System.Drawing.Point(399, 334)
        Me.ucrReceiverSecondVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondVariable.Name = "ucrReceiverSecondVariable"
        Me.ucrReceiverSecondVariable.Selector = Nothing
        Me.ucrReceiverSecondVariable.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverSecondVariable.strNcFilePath = ""
        Me.ucrReceiverSecondVariable.TabIndex = 4
        Me.ucrReceiverSecondVariable.ucrSelector = Nothing
        '
        'ucrSelectorSecondVariable
        '
        Me.ucrSelectorSecondVariable.AutoSize = True
        Me.ucrSelectorSecondVariable.bDropUnusedFilterLevels = False
        Me.ucrSelectorSecondVariable.bShowHiddenColumns = False
        Me.ucrSelectorSecondVariable.bUseCurrentFilter = True
        Me.ucrSelectorSecondVariable.Location = New System.Drawing.Point(12, 290)
        Me.ucrSelectorSecondVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSecondVariable.Name = "ucrSelectorSecondVariable"
        Me.ucrSelectorSecondVariable.Size = New System.Drawing.Size(480, 411)
        Me.ucrSelectorSecondVariable.TabIndex = 2
        '
        'ucrChkOrderBy
        '
        Me.ucrChkOrderBy.AutoSize = True
        Me.ucrChkOrderBy.Checked = False
        Me.ucrChkOrderBy.Location = New System.Drawing.Point(18, 152)
        Me.ucrChkOrderBy.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkOrderBy.Name = "ucrChkOrderBy"
        Me.ucrChkOrderBy.Size = New System.Drawing.Size(282, 51)
        Me.ucrChkOrderBy.TabIndex = 1
        '
        'ucrChkSetseed
        '
        Me.ucrChkSetseed.AutoSize = True
        Me.ucrChkSetseed.Checked = False
        Me.ucrChkSetseed.Location = New System.Drawing.Point(249, 68)
        Me.ucrChkSetseed.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkSetseed.Name = "ucrChkSetseed"
        Me.ucrChkSetseed.Size = New System.Drawing.Size(152, 51)
        Me.ucrChkSetseed.TabIndex = 8
        '
        'ucrNudSeed
        '
        Me.ucrNudSeed.AutoSize = True
        Me.ucrNudSeed.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSeed.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSeed.Location = New System.Drawing.Point(410, 68)
        Me.ucrNudSeed.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrNudSeed.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSeed.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSeed.Name = "ucrNudSeed"
        Me.ucrNudSeed.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudSeed.TabIndex = 7
        Me.ucrNudSeed.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkSample
        '
        Me.ucrChkSample.AutoSize = True
        Me.ucrChkSample.Checked = False
        Me.ucrChkSample.Location = New System.Drawing.Point(12, 68)
        Me.ucrChkSample.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkSample.Name = "ucrChkSample"
        Me.ucrChkSample.Size = New System.Drawing.Size(170, 51)
        Me.ucrChkSample.TabIndex = 5
        '
        'ucrInputN
        '
        Me.ucrInputN.AddQuotesIfUnrecognised = True
        Me.ucrInputN.AutoSize = True
        Me.ucrInputN.IsMultiline = False
        Me.ucrInputN.IsReadOnly = False
        Me.ucrInputN.Location = New System.Drawing.Point(350, 28)
        Me.ucrInputN.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.ucrInputN.Name = "ucrInputN"
        Me.ucrInputN.Size = New System.Drawing.Size(96, 30)
        Me.ucrInputN.TabIndex = 3
        '
        'ucrChkFirst
        '
        Me.ucrChkFirst.AutoSize = True
        Me.ucrChkFirst.Checked = False
        Me.ucrChkFirst.Location = New System.Drawing.Point(12, 28)
        Me.ucrChkFirst.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkFirst.Name = "ucrChkFirst"
        Me.ucrChkFirst.Size = New System.Drawing.Size(152, 51)
        Me.ucrChkFirst.TabIndex = 0
        '
        'ucrChkLast
        '
        Me.ucrChkLast.AutoSize = True
        Me.ucrChkLast.Checked = False
        Me.ucrChkLast.Location = New System.Drawing.Point(464, 28)
        Me.ucrChkLast.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkLast.Name = "ucrChkLast"
        Me.ucrChkLast.Size = New System.Drawing.Size(120, 51)
        Me.ucrChkLast.TabIndex = 4
        '
        'ucrChknth
        '
        Me.ucrChknth.AutoSize = True
        Me.ucrChknth.Checked = False
        Me.ucrChknth.Location = New System.Drawing.Point(249, 32)
        Me.ucrChknth.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChknth.Name = "ucrChknth"
        Me.ucrChknth.Size = New System.Drawing.Size(88, 51)
        Me.ucrChknth.TabIndex = 1
        '
        'ucrSelectorOrderBy
        '
        Me.ucrSelectorOrderBy.AutoSize = True
        Me.ucrSelectorOrderBy.bDropUnusedFilterLevels = False
        Me.ucrSelectorOrderBy.bShowHiddenColumns = False
        Me.ucrSelectorOrderBy.bUseCurrentFilter = True
        Me.ucrSelectorOrderBy.Location = New System.Drawing.Point(15, 198)
        Me.ucrSelectorOrderBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOrderBy.Name = "ucrSelectorOrderBy"
        Me.ucrSelectorOrderBy.Size = New System.Drawing.Size(480, 411)
        Me.ucrSelectorOrderBy.TabIndex = 2
        '
        'ucrReceiverOrderBy
        '
        Me.ucrReceiverOrderBy.AutoSize = True
        Me.ucrReceiverOrderBy.frmParent = Nothing
        Me.ucrReceiverOrderBy.Location = New System.Drawing.Point(346, 264)
        Me.ucrReceiverOrderBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOrderBy.Name = "ucrReceiverOrderBy"
        Me.ucrReceiverOrderBy.Selector = Nothing
        Me.ucrReceiverOrderBy.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverOrderBy.strNcFilePath = ""
        Me.ucrReceiverOrderBy.TabIndex = 4
        Me.ucrReceiverOrderBy.ucrSelector = Nothing
        '
        'ucrChkStandardErrorOfMean
        '
        Me.ucrChkStandardErrorOfMean.AutoSize = True
        Me.ucrChkStandardErrorOfMean.Checked = False
        Me.ucrChkStandardErrorOfMean.Location = New System.Drawing.Point(24, 32)
        Me.ucrChkStandardErrorOfMean.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrChkStandardErrorOfMean.Name = "ucrChkStandardErrorOfMean"
        Me.ucrChkStandardErrorOfMean.Size = New System.Drawing.Size(442, 51)
        Me.ucrChkStandardErrorOfMean.TabIndex = 1
        '
        'ucrChkCircRange
        '
        Me.ucrChkCircRange.AutoSize = True
        Me.ucrChkCircRange.Checked = False
        Me.ucrChkCircRange.Location = New System.Drawing.Point(32, 70)
        Me.ucrChkCircRange.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkCircRange.Name = "ucrChkCircRange"
        Me.ucrChkCircRange.Size = New System.Drawing.Size(120, 51)
        Me.ucrChkCircRange.TabIndex = 1
        '
        'ucrChkAngVar
        '
        Me.ucrChkAngVar.AutoSize = True
        Me.ucrChkAngVar.Checked = False
        Me.ucrChkAngVar.Location = New System.Drawing.Point(320, 32)
        Me.ucrChkAngVar.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkAngVar.Name = "ucrChkAngVar"
        Me.ucrChkAngVar.Size = New System.Drawing.Size(120, 51)
        Me.ucrChkAngVar.TabIndex = 4
        '
        'ucrChkrho
        '
        Me.ucrChkrho.AutoSize = True
        Me.ucrChkrho.Checked = False
        Me.ucrChkrho.Location = New System.Drawing.Point(186, 70)
        Me.ucrChkrho.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkrho.Name = "ucrChkrho"
        Me.ucrChkrho.Size = New System.Drawing.Size(120, 51)
        Me.ucrChkrho.TabIndex = 3
        '
        'ucrChkAngDev
        '
        Me.ucrChkAngDev.AutoSize = True
        Me.ucrChkAngDev.Checked = False
        Me.ucrChkAngDev.Location = New System.Drawing.Point(320, 70)
        Me.ucrChkAngDev.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkAngDev.Name = "ucrChkAngDev"
        Me.ucrChkAngDev.Size = New System.Drawing.Size(120, 51)
        Me.ucrChkAngDev.TabIndex = 5
        '
        'ucrChkVar
        '
        Me.ucrChkVar.AutoSize = True
        Me.ucrChkVar.Checked = False
        Me.ucrChkVar.Location = New System.Drawing.Point(186, 28)
        Me.ucrChkVar.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkVar.Name = "ucrChkVar"
        Me.ucrChkVar.Size = New System.Drawing.Size(120, 51)
        Me.ucrChkVar.TabIndex = 2
        '
        'ucrChkSd
        '
        Me.ucrChkSd.AutoSize = True
        Me.ucrChkSd.Checked = False
        Me.ucrChkSd.Location = New System.Drawing.Point(32, 28)
        Me.ucrChkSd.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkSd.Name = "ucrChkSd"
        Me.ucrChkSd.Size = New System.Drawing.Size(120, 51)
        Me.ucrChkSd.TabIndex = 0
        '
        'ucrChkCircMedian
        '
        Me.ucrChkCircMedian.AutoSize = True
        Me.ucrChkCircMedian.Checked = False
        Me.ucrChkCircMedian.Location = New System.Drawing.Point(186, 39)
        Me.ucrChkCircMedian.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkCircMedian.Name = "ucrChkCircMedian"
        Me.ucrChkCircMedian.Size = New System.Drawing.Size(122, 51)
        Me.ucrChkCircMedian.TabIndex = 2
        '
        'ucrChkMin
        '
        Me.ucrChkMin.AutoSize = True
        Me.ucrChkMin.Checked = False
        Me.ucrChkMin.Location = New System.Drawing.Point(320, 39)
        Me.ucrChkMin.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkMin.Name = "ucrChkMin"
        Me.ucrChkMin.Size = New System.Drawing.Size(120, 51)
        Me.ucrChkMin.TabIndex = 4
        '
        'ucrChkMedianH
        '
        Me.ucrChkMedianH.AutoSize = True
        Me.ucrChkMedianH.Checked = False
        Me.ucrChkMedianH.Location = New System.Drawing.Point(450, 39)
        Me.ucrChkMedianH.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkMedianH.Name = "ucrChkMedianH"
        Me.ucrChkMedianH.Size = New System.Drawing.Size(120, 51)
        Me.ucrChkMedianH.TabIndex = 6
        '
        'ucrChkQ3
        '
        Me.ucrChkQ3.AutoSize = True
        Me.ucrChkQ3.Checked = False
        Me.ucrChkQ3.Location = New System.Drawing.Point(186, 81)
        Me.ucrChkQ3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkQ3.Name = "ucrChkQ3"
        Me.ucrChkQ3.Size = New System.Drawing.Size(120, 51)
        Me.ucrChkQ3.TabIndex = 3
        '
        'ucrChkQ1
        '
        Me.ucrChkQ1.AutoSize = True
        Me.ucrChkQ1.Checked = False
        Me.ucrChkQ1.Location = New System.Drawing.Point(32, 81)
        Me.ucrChkQ1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkQ1.Name = "ucrChkQ1"
        Me.ucrChkQ1.Size = New System.Drawing.Size(120, 51)
        Me.ucrChkQ1.TabIndex = 1
        '
        'ucrChkMax
        '
        Me.ucrChkMax.AutoSize = True
        Me.ucrChkMax.Checked = False
        Me.ucrChkMax.Location = New System.Drawing.Point(320, 81)
        Me.ucrChkMax.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkMax.Name = "ucrChkMax"
        Me.ucrChkMax.Size = New System.Drawing.Size(120, 51)
        Me.ucrChkMax.TabIndex = 5
        '
        'ucrChkCircMean
        '
        Me.ucrChkCircMean.AutoSize = True
        Me.ucrChkCircMean.Checked = False
        Me.ucrChkCircMean.Location = New System.Drawing.Point(32, 39)
        Me.ucrChkCircMean.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkCircMean.Name = "ucrChkCircMean"
        Me.ucrChkCircMean.Size = New System.Drawing.Size(129, 51)
        Me.ucrChkCircMean.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdOptions)
        Me.GroupBox1.Controls.Add(Me.ucrChkProportionsPercentages)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 528)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(590, 62)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Percentages"
        '
        'sdgSummaries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(644, 698)
        Me.Controls.Add(Me.ucrButtonsSummaries)
        Me.Controls.Add(Me.tbSummaries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSummaries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Summaries"
        Me.Text = "Summaries"
        Me.tbCircular.ResumeLayout(False)
        Me.grpCircScale.ResumeLayout(False)
        Me.grpCircScale.PerformLayout()
        Me.grpCircLocation.ResumeLayout(False)
        Me.grpCircLocation.PerformLayout()
        Me.tbModel.ResumeLayout(False)
        Me.tbModel.PerformLayout()
        Me.tbPosition.ResumeLayout(False)
        Me.tbPosition.PerformLayout()
        Me.grpPosition.ResumeLayout(False)
        Me.grpPosition.PerformLayout()
        Me.tbTwoVariables.ResumeLayout(False)
        Me.tbTwoVariables.PerformLayout()
        Me.grpRelationships.ResumeLayout(False)
        Me.grpRelationships.PerformLayout()
        Me.grpHyroGOF.ResumeLayout(False)
        Me.grpHyroGOF.PerformLayout()
        Me.tbMore.ResumeLayout(False)
        Me.grpProportionsPercentiles.ResumeLayout(False)
        Me.grpProportionsPercentiles.PerformLayout()
        Me.grpLocation.ResumeLayout(False)
        Me.grpLocation.PerformLayout()
        Me.grpScale.ResumeLayout(False)
        Me.grpScale.PerformLayout()
        Me.grpSkewness.ResumeLayout(False)
        Me.grpSkewness.PerformLayout()
        Me.grpKurtosis.ResumeLayout(False)
        Me.grpKurtosis.PerformLayout()
        Me.tbsum.ResumeLayout(False)
        Me.grpDecilesQuintiles.ResumeLayout(False)
        Me.grpDecilesQuintiles.PerformLayout()
        Me.grpCommon.ResumeLayout(False)
        Me.grpCommon.PerformLayout()
        Me.grpQuartilesTerciles.ResumeLayout(False)
        Me.grpQuartilesTerciles.PerformLayout()
        Me.grpNotOrderedFactor.ResumeLayout(False)
        Me.grpNotOrderedFactor.PerformLayout()
        Me.grpNumeric.ResumeLayout(False)
        Me.grpNumeric.PerformLayout()
        Me.tbSummaries.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents ucrChkProportionsPercentages As ucrCheck
    Friend WithEvents cmdOptions As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class