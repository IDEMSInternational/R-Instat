﻿' Instat-R
' Copyright (C) 2015
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat
Imports instat.Translations

Public Class dlgOneVarFitModel
    Public clsROneVarFitModel, clsRLogLikFunction, clsRLength, clsRMean, clsRTTest, clsVarTest, clsREnormTest, clsRNonSignTest, clsRWilcoxTest, clsRBinomTest, clsRPoissonTest, clsRplot, clsRfitdist, clsRStartValues, clsRBinomStart, clsRConvertVector, clsRConvertInteger, clsRConvertNumeric As New RFunction
    Public clsRplotFunction, clsRplotPPComp, clsRplotCdfcomp, clsRplotQqComp, clsRplotDenscomp As RFunction
    Public clsFunctionOperator, clsFactorOperator As New ROperator
    Public bfirstload As Boolean = True
    Public bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private Sub dlgOneVarFitModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bfirstload Then
            InitialiseDialog()
            bfirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctucrOperator As New Dictionary(Of String, String)

        UcrBase.iHelpTopicID = 296
        UcrBase.clsRsyntax.iCallType = 2
        UcrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        'sdgOneVarFitModDisplay.InitialiseDialog()
        'sdgOneVarFitModel.InitialiseDialog()



        UcrReceiver.Selector = ucrSelectorOneVarFitMod
        UcrReceiver.SetMeAsReceiver()

        UcrReceiver.SetParameter(New RParameter("x"))
        UcrReceiver.SetParameterIsRFunction()

        ucrChkConvertVariate.SetText("Convert to Variate")
        ucrChkConvertVariate.SetParameter(New RParameter("data"))

        ucrNudHyp.SetParameter(New RParameter("mu"))

        ucrNudCI.SetParameter(New RParameter("mu"))

        ucrSaveModel.SetPrefix("dist")
        ucrSaveModel.SetSaveTypeAsModel()
        ucrSaveModel.SetDataFrameSelector(ucrSelectorOneVarFitMod.ucrAvailableDataFrames)
        ucrSaveModel.SetCheckBoxText("Save Model")
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetAssignToIfUncheckedValue("last_model")

        ucrChkBinModify.SetText("Modify Conditions for 'Success'")

        ' sdgOneVarFitModDisplay.SetModelFunction(clsROneVarFitModel)
        'sdgOneVarFitModel.SetMyRFunction(clsROneVarFitModel)
        'sdgOneVarFitModDisplay.SetDistribution(ucrFamily)
        'sdgOneVarFitModel.SetDistribution(ucrFamily)

        ucrPnlGeneralExactCase.AddRadioButton(rdoGeneralCase)
        ucrPnlGeneralExactCase.AddRadioButton(rdoExactCase)

        ucrPnlGeneralExactCase.AddFunctionNamesCondition(rdoGeneralCase, "fitdist")
        ucrPnlGeneralExactCase.AddFunctionNamesCondition(rdoExactCase, "fitdist", False)

        ucrPnlStats.AddRadioButton(rdoEnorm)
        ucrPnlStats.AddRadioButton(rdoMeanWilcox)
        ucrPnlStats.AddRadioButton(rdoVarSign)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrPnlStats, {rdoExactCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrNudCI, {rdoExactCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.95)
        ucrNudCI.SetLinkedDisplayControl(lblConfidenceLimit)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrNudHyp, {rdoExactCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudHyp.SetLinkedDisplayControl(lblHyp)
        ucrPnlStats.SetLinkedDisplayControl(grpConditions)

        '  ucrPnlGeneralExactCase.AddToLinkedControls(ucrChkBinModify, {rdoExactCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)


        ucrNudCI.Increment = 0.05
        ucrNudCI.DecimalPlaces = 2
        ucrNudCI.SetMinMax(0, 1)

        ucrNudHyp.DecimalPlaces = 2

        ' ucrOperator.SetItems({"==", "<", "<=", ">", ">=", "!="})
        ' dctucrOperator.Add("Equal to(==)", "==")
        ' ucrVariables.SetItemsTypeAsColumns()    'we want SetItemsTypeAs factors in the column
        ' rdoMeanWilcox.Checked = True

        'temp disabled as only works for numeric columns currently
        '.Enabled = False
    End Sub

    Private Sub SetDefaults()
        clsROneVarFitModel = New RFunction
        clsRLength = New RFunction
        clsRMean = New RFunction
        clsRTTest = New RFunction
        clsVarTest = New RFunction
        clsREnormTest = New RFunction
        clsRNonSignTest = New RFunction
        clsRWilcoxTest = New RFunction
        clsRBinomTest = New RFunction
        clsRPoissonTest = New RFunction
        clsRplot = New RFunction
        clsRfitdist = New RFunction
        clsRStartValues = New RFunction
        clsRBinomStart = New RFunction
        clsRConvertVector = New RFunction
        clsRConvertInteger = New RFunction
        clsRConvertNumeric = New RFunction
        clsRplotFunction = New RFunction
        clsRplotPPComp = New RFunction
        clsRplotCdfcomp = New RFunction
        clsRplotQqComp = New RFunction
        clsRplotDenscomp = New RFunction
        clsRLogLikFunction = New RFunction

        clsFunctionOperator = New ROperator
        clsFactorOperator = New ROperator

        ucrSelectorOneVarFitMod.Reset()
        ucrSaveModel.Reset()
        ' ucrOperator.SetName("==")
        clsROneVarFitModel.SetPackageName("fitdistrplus")
        clsROneVarFitModel.SetRCommand("fitdist")
        clsROneVarFitModel.AddParameter("method", Chr(34) & "mle" & Chr(34))

        clsRConvertNumeric.SetPackageName("base")
        clsRConvertNumeric.SetRCommand("as.numeric")
        clsRConvertInteger.SetPackageName("base")
        clsRConvertInteger.SetRCommand("as.integer")
        clsRConvertVector.SetPackageName("base")
        clsRConvertVector.SetRCommand("as.vector")
        clsRStartValues.SetPackageName("base")
        clsRStartValues.SetRCommand("mean")
        clsRfitdist.SetPackageName("fitdistrplus")
        clsRfitdist.SetRCommand("fitdist")
        BinomialConditions()

        'TTest
        clsRTTest.SetPackageName("stats")
        clsRTTest.SetRCommand("t.test")
        'VarTest
        clsVarTest.SetPackageName("EnvStats")
        clsVarTest.SetRCommand("varTest")

        clsREnormTest.SetPackageName("EnvStats")
        clsREnormTest.SetRCommand("enorm")

        clsRWilcoxTest.SetPackageName("stats")
        clsRWilcoxTest.SetRCommand("wilcox.test")

        clsRNonSignTest.SetPackageName("signmedian.test")
        clsRNonSignTest.SetRCommand("signmedian.test")

        clsRPoissonTest.SetPackageName("stats")
        clsRPoissonTest.SetRCommand("poisson.test")

        clsRLength.SetPackageName("base")
        clsRLength.SetRCommand("length")
        clsRMean.SetPackageName("base")
        clsRMean.SetRCommand("mean")

        clsRBinomTest.SetPackageName("stats")
        clsRBinomTest.SetRCommand("binom.test")

        clsRplot.SetPackageName("graphics")
        clsRplot.SetRCommand("plot")
        clsRplot.iCallType = 3

        clsRConvertVector.SetPackageName("base")
        clsRBinomStart.SetPackageName("base")
        clsRConvertInteger.SetPackageName("base")
        'clsRConvert.SetPackageName("base")

        'sdg
        clsRplotFunction.SetPackageName("graphics")
        clsRplotFunction.SetRCommand("plot")
        clsRplotFunction.iCallType = 3

        clsRplotPPComp.SetPackageName("fitdistrplus")
        clsRplotPPComp.SetRCommand("ppcomp")
        clsRplotPPComp.iCallType = 3

        clsRplotCdfcomp.SetPackageName("fitdistrplus")
        clsRplotCdfcomp.SetRCommand("cdfcomp")
        clsRplotCdfcomp.iCallType = 3

        clsRplotQqComp.SetPackageName("fitdistrplus")
        clsRplotQqComp.SetRCommand("qqcomp")
        clsRplotQqComp.iCallType = 3

        clsRplotDenscomp.SetPackageName("fitdistrplus")
        clsRplotDenscomp.SetRCommand("denscomp")
        clsRplotDenscomp.iCallType = 3

        clsRLogLikFunction.SetPackageName("fitdistrplus")
        clsRLogLikFunction.SetRCommand("llplot")
        clsRLogLikFunction.iCallType = 3

        SetDataParameter()
        EnableOptions()

        SetBaseFunction()
        clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertInteger)
        clsRLogLikFunction.AddParameter("mlefit", clsRFunctionParameter:=clsROneVarFitModel)
        clsROneVarFitModel.SetAssignTo("last_model", strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model")
        UcrBase.clsRsyntax.SetBaseRFunction(clsROneVarFitModel)
        SetDistributions()
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlGeneralExactCase.SetRCode(clsROneVarFitModel, bReset)
        UcrReceiver.SetRCode(clsRConvertVector, bReset)
        ucrChkConvertVariate.SetRCode(clsRConvertNumeric, bReset)
        ucrNudHyp.SetRCode(clsRTTest, bReset)
        UcrReceiver.AddAdditionalCodeParameterPair(clsRConvertNumeric, New RParameter("x"), iAdditionalPairNo:=1)
        UcrReceiver.AddAdditionalCodeParameterPair(clsRConvertInteger, New RParameter("x"), iAdditionalPairNo:=2)
        UcrReceiver.AddAdditionalCodeParameterPair(clsRWilcoxTest, New RParameter("x"), iAdditionalPairNo:=3)
        UcrReceiver.AddAdditionalCodeParameterPair(clsRNonSignTest, New RParameter("x"), iAdditionalPairNo:=4)
        ' UcrReceiver.AddAdditionalCodeParameterPair(clsRLength, New RParameter("x"), iAdditionalPairNo:=6)
        '  UcrReceiver.AddAdditionalCodeParameterPair(clsRMean, New RParameter("x"), iAdditionalPairNo:=7)
        ' UcrReceiver.AddAdditionalCodeParameterPair(clsRBinomTest, New RParameter("x"), iAdditionalPairNo:=9)
        '  UcrReceiver.AddAdditionalCodeParameterPair(clsRConvertVector, New RParameter("x"), iAdditionalPairNo:=10)

        '  UcrReceiver.AddAdditionalCodeParameterPair(clsRplotFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        UcrReceiver.AddAdditionalCodeParameterPair(clsRplotPPComp, New RParameter("ft", 0), iAdditionalPairNo:=2)
        UcrReceiver.AddAdditionalCodeParameterPair(clsRplotCdfcomp, New RParameter("ft", 0), iAdditionalPairNo:=3)
        UcrReceiver.AddAdditionalCodeParameterPair(clsRplotQqComp, New RParameter("ft", 0), iAdditionalPairNo:=4)
        UcrReceiver.AddAdditionalCodeParameterPair(clsRplotDenscomp, New RParameter("ft", 0), iAdditionalPairNo:=4)


        ucrChkConvertVariate.AddAdditionalCodeParameterPair(clsROneVarFitModel, ucrChkConvertVariate.GetParameter(), iAdditionalPairNo:=1)
        ucrChkConvertVariate.AddAdditionalCodeParameterPair(clsROneVarFitModel, ucrChkConvertVariate.GetParameter(), iAdditionalPairNo:=2)
        ucrChkConvertVariate.AddAdditionalCodeParameterPair(clsROneVarFitModel, ucrChkConvertVariate.GetParameter(), iAdditionalPairNo:=3)

        ucrNudHyp.AddAdditionalCodeParameterPair(clsVarTest, New RParameter("sigma.squared"), iAdditionalPairNo:=1)
        ucrNudHyp.AddAdditionalCodeParameterPair(clsVarTest, New RParameter("sigma.squared"), iAdditionalPairNo:=2)
        ucrNudHyp.AddAdditionalCodeParameterPair(clsRWilcoxTest, New RParameter("mu"), iAdditionalPairNo:=3)
        ucrNudHyp.AddAdditionalCodeParameterPair(clsRNonSignTest, New RParameter("mu"), iAdditionalPairNo:=4)
        ucrNudHyp.AddAdditionalCodeParameterPair(clsRTTest, New RParameter("mu"), iAdditionalPairNo:=5)
        ucrNudHyp.AddAdditionalCodeParameterPair(clsRBinomTest, New RParameter("p"), iAdditionalPairNo:=6)
        'ucrNudHyp.AddAdditionalCodeParameterPair(clsRPoissonTest, New RParameter("r"), iAdditionalPairNo:=7)
        ' ucrNudHyp.AddAdditionalCodeParameterPair(clsRPoissonTest, New RParameter("sigma.squared"), iAdditionalPairNo:=8)

        ucrNudCI.AddAdditionalCodeParameterPair(clsRTTest, New RParameter("conf.level"), iAdditionalPairNo:=1)
        ucrNudCI.AddAdditionalCodeParameterPair(clsVarTest, New RParameter("conf.level"), iAdditionalPairNo:=2)
        ucrNudCI.AddAdditionalCodeParameterPair(clsREnormTest, New RParameter("conf.level"), iAdditionalPairNo:=3)
        ucrNudCI.AddAdditionalCodeParameterPair(clsRWilcoxTest, New RParameter("conf.level"), iAdditionalPairNo:=4)
        ' ucrNudCI.AddAdditionalCodeParameterPair(clsRNonSignTest, New RParameter("conf.level"), iAdditionalPairNo:=5)
        '  ucrNudCI.AddAdditionalCodeParameterPair(clsRBinomTest, New RParameter("conf.level"), iAdditionalPairNo:=7)
        '  ucrNudCI.AddAdditionalCodeParameterPair(clsRPoissonTest, New RParameter("conf.level"), iAdditionalPairNo:=6)
    End Sub

    Private Sub SetDistributions()
        If rdoGeneralCase.Checked Then
            ucrFamily.SetAllDistributions()
        ElseIf rdoExactCase.Checked Then
            ucrFamily.SetExactDistributions()
        End If
    End Sub

    Private Sub TestOKEnabled()
        If ucrSaveModel.IsComplete() AndAlso Not UcrReceiver.IsEmpty Then
            UcrBase.OKEnabled(True)
        Else
            UcrBase.OKEnabled(False)
        End If
        UcrBase.OKEnabled(True)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles UcrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Public Sub SetDataParameter()
        If Not UcrReceiver.IsEmpty Then
            If UcrReceiver.strCurrDataType = "numeric" OrElse UcrReceiver.strCurrDataType = "integer" Then
                ucrChkConvertVariate.Checked = False
                ucrChkConvertVariate.Visible = False
            Else
                ucrChkConvertVariate.Visible = True
                ucrChkConvertVariate.Checked = True
            End If
            If ucrChkConvertVariate.Checked Then

                UcrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=clsRConvertNumeric)
            Else
                'TODO This is needed because fitdist checks is.vector on data which is FALSE when data has attributes
                If ucrFamily.clsCurrDistribution.strNameTag = "Poisson" OrElse ucrFamily.clsCurrDistribution.strNameTag = "Geometric" Then
                    clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertInteger)
                Else
                    clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertVector)
                End If
                If ucrFamily.clsCurrDistribution.strNameTag = "Extreme_Value" Or ucrFamily.clsCurrDistribution.strNameTag = "Binomial" Or ucrFamily.clsCurrDistribution.strNameTag = "Bernouli" Or ucrFamily.clsCurrDistribution.strNameTag = "Students_t" Or ucrFamily.clsCurrDistribution.strNameTag = "Chi_Square" Or ucrFamily.clsCurrDistribution.strNameTag = "F" Or ucrFamily.clsCurrDistribution.strNameTag = "Hypergeometric" Then
                    clsROneVarFitModel.AddParameter("start", clsRFunctionParameter:=clsRStartValues)
                    ' TODO llplot() no longer works with starting values. However, the mle's will not plot without starting values for these variables
                End If
            End If
        Else
            ucrChkConvertVariate.Visible = False
            'UcrBase.clsRsyntax.RemoveParameter("data")
        End If
    End Sub

    Public Sub SetBaseFunction()
        'clsROneVarFitModel.ClearParameters()
        'clsRPoissonTest.ClearParameters()
        'clsRBinomTest.ClearParameters()
        'clsRTTest.ClearParameters()
        'clsRStartValues.ClearParameters()
        If rdoGeneralCase.Checked Then
            FitDistFunction()
        ElseIf rdoExactCase.Checked Then
            If ucrFamily.clsCurrDistribution.strNameTag = "Poisson" Then
                SetPoissonTest()
            ElseIf ucrFamily.clsCurrDistribution.strNameTag = "Normal" Then
                If rdoMeanWilcox.Checked Then
                    SetTTest()
                ElseIf rdoVarSign.Checked Then
                    SetVarTest()
                ElseIf rdoEnorm.Checked Then
                    SetEnormTest()
                End If
            ElseIf ucrFamily.clsCurrDistribution.strNameTag = "Bernouli" Then
                SetBinomialTest()
            Else
                If rdoMeanWilcox.Checked Then
                    SetWilcoxTest()
                ElseIf rdoVarSign.Checked Then
                    SetNonSignTest()
                End If
            End If
        End If
    End Sub

    Public Sub DataTypeAccepted()
        If rdoGeneralCase.Checked Then
            UcrReceiver.SetIncludedDataTypes({"integer", "numeric", "character", "factor"})
        ElseIf rdoExactCase.Checked Then
            If ucrFamily.clsCurrDistribution.strNameTag = "Normal" Or ucrFamily.clsCurrDistribution.strNameTag = "Poisson" Then
                UcrReceiver.SetIncludedDataTypes({"integer", "numeric"})
                If (UcrReceiver.strCurrDataType = "factor" OrElse UcrReceiver.strCurrDataType = "character") Then
                    UcrReceiver.Clear()
                End If
            Else
                UcrReceiver.SetIncludedDataTypes({"integer", "numeric", "character", "factor"})
            End If
        End If
    End Sub

    Public Sub FitDistFunction()
        ' UcrBase.clsRsyntax.SetBaseRFunction(clsROneVarFitModel)
        clsROneVarFitModel.AddParameter("distr", Chr(34) & ucrFamily.clsCurrDistribution.strRName & Chr(34))
        SetDataParameter()
    End Sub

    Private Sub SetTTest()
        UcrBase.clsRsyntax.SetBaseRFunction(clsRTTest)
        clsRConvertVector.SetRCommand("as.vector")
        clsRTTest.AddParameter("x", clsRFunctionParameter:=clsRConvertVector)
        'clsRTTest.AddParameter("mu", ucrNudHyp.Value.ToString)
        'clsRTTest.AddParameter("conf.level", ucrNudCI.Value.ToString)
    End Sub

    Private Sub SetVarTest()
        UcrBase.clsRsyntax.SetBaseRFunction(clsVarTest)
        clsRConvertVector.SetRCommand("as.vector")
        clsVarTest.AddParameter("x", clsRFunctionParameter:=clsRConvertVector)
        clsVarTest.AddParameter("sigma.squared", ucrNudHyp.Value.ToString)
        ' clsVarTest.AddParameter("conf.level", ucrNudCI.Value.ToString)
    End Sub

    Private Sub SetEnormTest()
        UcrBase.clsRsyntax.SetBaseRFunction(clsREnormTest)
        clsRConvertVector.SetRCommand("as.vector")
        clsREnormTest.AddParameter("x", clsRFunctionParameter:=clsRConvertVector)
        ' clsREnormTest.AddParameter("conf.level", ucrNudCI.Value.ToString)
        ' what is the hyp nud?
    End Sub

    Private Sub SetWilcoxTest()
        UcrBase.clsRsyntax.SetBaseRFunction(clsRWilcoxTest)
        'clsRConvert.SetRCommand("as.vector")
        'clsRWilcoxTest.AddParameter("x", clsRFunctionParameter:=clsRConvert)
        ' clsRWilcoxTest.AddParameter("conf.level", ucrNudCI.Value.ToString)
        ' clsRWilcoxTest.AddParameter("mu", ucrNudHyp.Value.ToString)
    End Sub

    Private Sub SetNonSignTest()

        UcrBase.clsRsyntax.SetBaseRFunction(clsRNonSignTest)
        ' clsRNonSignTest.AddParameter("conf.level", ucrNudCI.Value.ToString)
        'clsRNonSignTest.AddParameter("mu", ucrNudCI.Value.ToString)
    End Sub

    Private Sub SetPoissonTest()
        If ucrFamily.clsCurrDistribution.strNameTag = "Poisson" AndAlso (UcrReceiver.strCurrDataType = "factor" OrElse UcrReceiver.strCurrDataType = "character") Then
            UcrReceiver.Clear()
        End If

        UcrBase.clsRsyntax.SetBaseRFunction(clsRPoissonTest)
        ' clsRPoissonTest.AddParameter("r", ucrNudHyp.Value.ToString)
        ' clsRPoissonTest.AddParameter("conf.level", ucrNudCI.Value.ToString)
        clsRPoissonTest.AddParameter("T", clsRFunctionParameter:=clsRMean)
        clsRPoissonTest.AddParameter("x", clsRFunctionParameter:=clsRLength)

    End Sub

    Private Sub SetBinomialTest()
        If ucrFamily.clsCurrDistribution.strNameTag = "Binomial" Then
            UcrReceiver.SetDataType(strTemp:="integer" OrElse "numeric" OrElse "character" OrElse "factor")
        End If

        UcrBase.clsRsyntax.SetBaseRFunction(clsRBinomTest)
        clsRBinomTest.AddParameter("p", ucrNudHyp.Value.ToString)
        clsRBinomTest.AddParameter("conf.level", ucrNudCI.Value.ToString)
        If ucrChkBinModify.Checked Then
            If UcrReceiver.strCurrDataType = "factor" OrElse UcrReceiver.strCurrDataType = "character" Then
                clsRBinomTest.AddParameter("x", clsROperatorParameter:=clsFactorOperator)
                clsFactorOperator.SetOperation("==")
                clsFactorOperator.AddParameter(iPosition:=0, clsRFunctionParameter:=UcrReceiver.GetVariables())
                clsFactorOperator.AddParameter(strParameterValue:=ucrVariables.GetText())
            Else
                clsRBinomTest.AddParameter("x", clsROperatorParameter:=clsFunctionOperator)
                clsFunctionOperator.SetOperation(ucrOperator.GetText())
                clsFunctionOperator.AddParameter(iPosition:=0, clsRFunctionParameter:=UcrReceiver.GetVariables())
                clsFunctionOperator.AddParameter(strParameterValue:=ucrNudBinomialConditions.Value.ToString())
            End If
        Else
            clsRBinomTest.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
        End If
    End Sub

    Private Sub PlotResiduals()

        clsRplot.AddParameter("x", clsRFunctionParameter:=clsRfitdist)
        clsRfitdist.AddParameter("distr", Chr(34) & ucrFamily.clsCurrDistribution.strRName & Chr(34))
        If ucrFamily.clsCurrDistribution.strNameTag = "Poisson" Then
            clsRConvertInteger.SetRCommand("as.integer")
            clsRfitdist.AddParameter("data", clsRFunctionParameter:=clsRConvertInteger)
        Else
            clsRConvertVector.SetRCommand("as.vector")
            clsRfitdist.AddParameter("data", clsRFunctionParameter:=clsRConvertVector)
        End If
        If ucrFamily.clsCurrDistribution.strNameTag = "Bernouli" Then
            clsRBinomStart.SetRCommand("mean")
            clsRfitdist.AddParameter("start", clsRFunctionParameter:=clsRBinomStart)
        End If
    End Sub

    Private Sub cmdFittingOptions_Click(sender As Object, e As EventArgs) Handles cmdFittingOptions.Click
        sdgOneVarFitModel.SetRCode(clsROneVarFitModel, bResetSubdialog)
        bResetSubdialog = False
        sdgOneVarFitModel.ShowDialog()
        EnableOptions()
        Display()
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgOneVarFitModDisplay.SetRCode(UcrBase.clsRsyntax, clsRNewOneVarFitModel:=clsROneVarFitModel, clsNewRLogLikFunction:=clsRLogLikFunction, clsNewRplotFunction:=clsRplotFunction, clsNewRplotPPComp:=clsRplotPPComp, clsNewRplotCdfcomp:=clsRplotCdfcomp, clsNewRplotQqComp:=clsRplotQqComp, clsNewRplotDenscomp:=clsRplotDenscomp, bReset:=bResetSubdialog)
        bResetSubdialog = False
        sdgOneVarFitModDisplay.ShowDialog()
        Display()
        EnableOptions()
        TestOKEnabled()
    End Sub

    Private Sub EnableOptions()
        If Not UcrReceiver.IsEmpty Then
            cmdFittingOptions.Enabled = True
            cmdDisplayOptions.Enabled = True
        Else
            cmdFittingOptions.Enabled = False
            cmdDisplayOptions.Enabled = False
        End If
    End Sub

    Private Sub chkConvertToVariate_CheckedChanged(sender As Object, e As EventArgs)
        SetDataParameter()
        Display()
    End Sub

    Private Sub UcrBase_ClickOk(sender As Object, e As EventArgs) Handles UcrBase.ClickOk
        If rdoGeneralCase.Checked Then
            ' If sdgOneVarFitModel.rdoMle.Checked AndAlso (sdgOneVarFitModDisplay.rdoLoglik.Checked Or sdgOneVarFitModDisplay.rdoLik.Checked) Then
            ' sdgOneVarFitModDisplay.RunLikelihoods()
            'End If
        ElseIf rdoExactCase.Checked Then
            If ucrFamily.clsCurrDistribution.strNameTag = "Normal" OrElse ucrFamily.clsCurrDistribution.strNameTag = "Poisson" Then ' can remove this line once Bernouli residual plots are working
                PlotResiduals()
                'frmMain.clsRLink.RunScript(clsRplot.ToScript(), 3)
            End If
        End If
    End Sub

    Private Sub Display()
        If rdoGeneralCase.Checked Then
            cmdFittingOptions.Visible = True
            cmdDisplayOptions.Visible = True
            grpConditions.Visible = False
            rdoMeanWilcox.Visible = False
            rdoVarSign.Visible = False
            rdoEnorm.Visible = False
        ElseIf rdoExactCase.Checked Then
            cmdFittingOptions.Visible = False
            cmdDisplayOptions.Visible = False
            ucrChkConvertVariate.Visible = False
            grpConditions.Visible = True
            If ucrFamily.clsCurrDistribution.bIsExact = True Then
                If ucrFamily.clsCurrDistribution.strNameTag = "Normal" Then
                    rdoMeanWilcox.Visible = True
                    rdoVarSign.Visible = True
                    rdoEnorm.Visible = True
                    rdoMeanWilcox.Text = "Compare Mean"
                    rdoVarSign.Text = "Compare Variance"
                    If rdoVarSign.Checked Then
                        ucrNudHyp.SetMinMax(0.01, 1)
                    Else
                        ucrNudHyp.SetMinMax(ucrFamily.clsCurrDistribution.lstExact(5), ucrNudHyp.Value = ucrFamily.clsCurrDistribution.lstExact(2))
                    End If
                ElseIf ucrFamily.clsCurrDistribution.strNameTag = "No_Distribution" Then
                    rdoMeanWilcox.Visible = True
                    rdoVarSign.Visible = True
                    rdoEnorm.Visible = False
                    rdoMeanWilcox.Text = "None-Wilcoxon"
                    rdoVarSign.Text = "None-Sign"
                    ucrNudHyp.Minimum = ucrFamily.clsCurrDistribution.lstExact(5)
                    ucrNudHyp.Value = ucrFamily.clsCurrDistribution.lstExact(2)
                Else
                    ucrNudHyp.Minimum = ucrFamily.clsCurrDistribution.lstExact(5)
                    ucrNudHyp.Value = ucrFamily.clsCurrDistribution.lstExact(2)
                    rdoMeanWilcox.Visible = False
                    rdoVarSign.Visible = False
                    rdoEnorm.Visible = False
                End If
                ucrNudHyp.Increment = ucrFamily.clsCurrDistribution.lstExact(3)
                ucrNudHyp.DecimalPlaces = ucrFamily.clsCurrDistribution.lstExact(4)
                ucrNudHyp.Maximum = ucrFamily.clsCurrDistribution.lstExact(6)
            End If
        End If
    End Sub

    Private Sub ucrPnlGeneralExactCase_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGeneralExactCase.ControlValueChanged
        EnableOptions()
        BinomialConditions()
        sdgOneVarFitModel.OptimisationMethod()
        sdgOneVarFitModel.Estimators()
        SetDistributions()
        DataTypeAccepted()
    End Sub

    Private Sub ucrDistributions_cboDistributionsIndexChanged() Handles ucrFamily.DistributionsIndexChanged
        SetBaseFunction()
        BinomialConditions()
        SetDataParameter()
        PlotResiduals()
        DataTypeAccepted()
    End Sub

    Private Sub lbls_VisibleChanged(sender As Object, e As EventArgs) Handles lblEquals.VisibleChanged, lblSuccessIf.VisibleChanged
        BinomialConditions()
    End Sub

    Private Sub BinomialConditions()
        If rdoExactCase.Checked AndAlso ucrFamily.clsCurrDistribution.strNameTag = "Bernouli" Then
            ucrChkBinModify.Visible = True
            If ucrChkBinModify.Checked Then
                lblSuccessIf.Visible = True
                If UcrReceiver.strCurrDataType = "factor" Then
                    ucrVariables.Visible = True
                    lblEquals.Visible = True
                Else
                    lblEquals.Visible = False
                    ucrNudBinomialConditions.Visible = True
                    ucrOperator.Visible = True
                    ucrVariables.Visible = False
                End If
            Else
                lblSuccessIf.Visible = False
                lblEquals.Visible = False
                ucrNudBinomialConditions.Visible = False
                ucrOperator.Visible = False
                ucrVariables.Visible = False
            End If
        Else
            ucrChkBinModify.Visible = False
            ucrChkBinModify.Checked = False
            lblSuccessIf.Visible = False
            lblEquals.Visible = False
            ucrNudBinomialConditions.Visible = False
            ucrOperator.Visible = False
            ucrVariables.Visible = False
        End If
        ' ucrNudBinomialConditions.Value = 1
        ucrNudBinomialConditions.Maximum = Integer.MaxValue
        ucrNudBinomialConditions.Minimum = Integer.MinValue
        Display()
    End Sub

    'Private Sub ucrNudBinomialConditions_ValueChanged(sender As Object, e As EventArgs)
    '    SetBinomialTest()
    'End Sub

    Private Sub cboVariables_TextChanged() Handles ucrVariables.NameChanged
        BinomialConditions()
        SetBinomialTest()
    End Sub

    'Private Sub rdoMean_VisibleChanged(sender As Object, e As EventArgs)
    '    Display()
    '    SetBaseFunction()
    'End Sub

    Private Sub AllControl_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveModel.ControlContentsChanged, UcrReceiver.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkBinModify_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBinModify.ControlValueChanged
        SetBinomialTest()
        BinomialConditions()
    End Sub

    Private Sub ucrPnlStats_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStats.ControlValueChanged
        SetBaseFunction()
        Display()
    End Sub

    Private Sub UcrReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles UcrReceiver.ControlValueChanged
        SetBaseFunction()
        EnableOptions()
        PlotResiduals()
        DataTypeAccepted()
    End Sub
End Class
