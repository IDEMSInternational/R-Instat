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

Imports instat.Translations
Public Class dlgOneVarFitModel
    Private clsROneVarFitModel, clsRLogLikFunction, clsRfitdist, clsRConvertVector, clsRConvertInteger, clsRConvertNumeric, clsNaExclude As New RFunction
    Private clsRplotFunction, clsRplotPPComp, clsRplotCdfcomp, clsRplotQqComp, clsRplotDenscomp As New RFunction
    Private clsBionomialFunction, clsProportionFunction, clsSignTestFunction, clsTtestFunction, clsWilcoxonFunction, clsZTestFunction, clsBartelFunction, clsBrFunction, clsRunsFunction, clsSenFunction, clsSerialCorrFunction, clsSnhFunction, clsAdFunction, clsCvmFunction, clsLillieFunction, clsPearsonFunction, clsSfFunction As New RFunction
    Private clsMeanCIFunction, clsMedianCIFunction, clsNormCIFunction, clsQuantileCIFunction, clsSdCIFunction, clsVarCIFunction As New RFunction
    Private WithEvents ucrDistribution As ucrDistributions
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private bResetFittingOptions As Boolean = False
    Private bResetFitModDisplay As Boolean = False

    Private Sub dlgOneVarFitModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctCIMethods As New Dictionary(Of String, String)
        Dim dctMethods As New Dictionary(Of String, String)
        Dim dctmeanCI As New Dictionary(Of String, String)
        Dim dctMedianCI As New Dictionary(Of String, String)
        Dim dctVarCI As New Dictionary(Of String, String)
        Dim dctQuantileCI As New Dictionary(Of String, String)
        Dim dctConfidence As New Dictionary(Of String, String)
        Dim dctQMethod As New Dictionary(Of String, String)
        Dim dctConfidenceInterval As New Dictionary(Of String, String)
        Dim lstCommandButtons As New List(Of Control)

        ucrBase.iHelpTopicID = 296
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrPnlGeneralExactCase.AddRadioButton(rdoGeneralCase)
        ucrPnlGeneralExactCase.AddRadioButton(rdoTest)
        ucrPnlGeneralExactCase.AddRadioButton(rdoEstimate)

        ucrPnlGeneralExactCase.AddFunctionNamesCondition(rdoGeneralCase, "fitdist")
        ucrPnlGeneralExactCase.AddFunctionNamesCondition(rdoTest, {"binom.test", "prop.test", "SignTest", "t.test", "wilcox.test", "ZTest", "BartelsRankTest", "br.test", "RunsTest", "sens.slope", "serialcorrelationTest", "snh.test", "ad.test", "cvm.test", "lillie.test", "pearson.test", "sf.test"})
        ucrPnlGeneralExactCase.AddFunctionNamesCondition(rdoEstimate, {"MeanCI", "MedianCI ", "normCI", "quantileCI", "sdCI", "VarCI"})

        ucrReceiverVariable.SetParameter(New RParameter("object", 0))
        ucrReceiverVariable.Selector = ucrSelectorOneVarFitMod
        ucrReceiverVariable.SetParameterIsRFunction()
        ucrReceiverVariable.SetMeAsReceiver()

        ucrChkConvertVariate.SetText("Convert to Numeric")
        ucrChkConvertVariate.AddParameterValueFunctionNamesCondition(True, "data", "as.numeric", True)
        ucrChkConvertVariate.AddParameterValueFunctionNamesCondition(False, "data", frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data", True)

        ucrDistribution = ucrDistributionChoice
        ucrDistributionChoice.SetGLMDistributions()
        ucrDistributionChoice.SetFunctionIsDistFunction()

        ucrSaveModel.SetDataFrameSelector(ucrSelectorOneVarFitMod.ucrAvailableDataFrames)
        ucrSaveModel.SetSaveTypeAsModel()
        ucrSaveModel.SetCheckBoxText("Save Model")
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetAssignToIfUncheckedValue("last_model")

        ucrInputComboTests.SetItems({"binomial", "proportion", "sign", "t", "Wilcoxon", "Z", "Bartel", "br", "runs", "Sen", "serial corr", "snh", "ad", "cvm", "lillie", "pearson", "sf"})
        ucrInputComboTests.SetDropDownStyleAsNonEditable()

        ucrInputComboEstimate.SetItems({"mean", "median", "normal", "quantile", "sd", "variance"})
        ucrInputComboEstimate.SetDropDownStyleAsNonEditable()

        ucrInputMeanCIMethod.SetParameter(New RParameter("method", 3))
        dctmeanCI.Add("Classic", Chr(34) & "classic" & Chr(34))
        dctmeanCI.Add("Boot", Chr(34) & "boot" & Chr(34))
        ucrInputMeanCIMethod.SetItems(dctmeanCI)
        ucrInputMeanCIMethod.SetDropDownStyleAsNonEditable()

        ucrInputTxtHypothesis.SetParameter(New RParameter("mu", 1))
        ucrInputTxtHypothesis.SetValidationTypeAsNumeric()
        ucrInputTxtHypothesis.AddQuotesIfUnrecognised = False

        ucrInputNulHypothesis.SetParameter(New RParameter("mu", 1))
        ucrInputNulHypothesis.SetValidationTypeAsNumeric()
        ucrInputNulHypothesis.AddQuotesIfUnrecognised = False

        ucrInputTextM.SetParameter(New RParameter("m", 1))
        ucrInputTextM.SetValidationTypeAsNumeric()
        ucrInputTextM.AddQuotesIfUnrecognised = False

        ucrInputComboMedianCI.SetParameter(New RParameter("method", 2))
        dctMedianCI.Add("Exact", Chr(34) & "exact" & Chr(34))
        dctMedianCI.Add("Boot", Chr(34) & "boot" & Chr(34))
        ucrInputComboMedianCI.SetItems(dctMedianCI)
        ucrInputComboMedianCI.SetDropDownStyleAsNonEditable()

        ucrInputComboQMethod.SetParameter(New RParameter("method", 3))
        DctQMethod.Add("exact", Chr(34) & "exact" & Chr(34))
        DctQMethod.Add("asymptotic ", Chr(34) & "asymptotic " & Chr(34))
        DctQMethod.Add("boot", Chr(34) & "boot" & Chr(34))
        ucrInputComboQMethod.SetItems(DctQMethod)
        ucrInputComboQMethod.SetDropDownStyleAsNonEditable()

        ucrInputComboVarianceCI.SetParameter(New RParameter("method", 1))
        dctVarCI.Add("Classic", Chr(34) & "classic" & Chr(34))
        dctVarCI.Add("Bonett", Chr(34) & "bonett" & Chr(34))
        dctVarCI.Add("Norm", Chr(34) & "norm" & Chr(34))
        dctVarCI.Add("Basic", Chr(34) & "basic" & Chr(34))
        dctVarCI.Add("Stud", Chr(34) & "stud" & Chr(34))
        dctVarCI.Add("Perc", Chr(34) & "perc" & Chr(34))
        dctVarCI.Add("Bca", Chr(34) & "bca" & Chr(34))
        ucrInputComboVarianceCI.SetItems(dctVarCI)
        ucrInputComboVarianceCI.SetDropDownStyleAsNonEditable()

        ucrInputComboQuantilCI.SetParameter(New RParameter("bootci.type", 5))
        dctQuantileCI.Add("Norm", Chr(34) & "norm" & Chr(34))
        dctQuantileCI.Add("Basic", Chr(34) & "basic" & Chr(34))
        dctQuantileCI.Add("Perc", Chr(34) & "perc" & Chr(34))
        dctQuantileCI.Add("Bca", Chr(34) & "bca" & Chr(34))
        ucrInputComboQuantilCI.SetItems(dctQuantileCI)
        ucrInputComboQuantilCI.SetDropDownStyleAsNonEditable()

        ucrInputCIMethods.SetParameter(New RParameter("ci.method", 3))
        dctCIMethods.Add("Clopper-Pearson", Chr(34) & "Clopper-Pearson" & Chr(34))
        dctCIMethods.Add("binom.test", Chr(34) & "binom.test" & Chr(34))
        dctCIMethods.Add("Score", Chr(34) & "Score" & Chr(34))
        dctCIMethods.Add("Wilson", Chr(34) & "Wilson" & Chr(34))
        dctCIMethods.Add("prop.test", Chr(34) & "prop.test" & Chr(34))
        dctCIMethods.Add("Plus4", Chr(34) & "Plus4" & Chr(34))
        dctCIMethods.Add("Agresti-Coull", Chr(34) & "Agresti-Coull" & Chr(34))
        dctCIMethods.Add("Wald", Chr(34) & "Wald" & Chr(34))
        ucrInputCIMethods.SetItems(dctCIMethods)
        ucrInputCIMethods.SetDropDownStyleAsNonEditable()

        ucrInputComboMethod.SetParameter(New RParameter("method", 1))
        dctMethods.Add("Normal", Chr(34) & "normal" & Chr(34))
        dctMethods.Add("Beta", Chr(34) & "beta" & Chr(34))
        dctMethods.Add("Auto", Chr(34) & "auto" & Chr(34))
        ucrInputComboMethod.SetItems(dctMethods)
        ucrInputComboMethod.SetDropDownStyleAsNonEditable()

        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 3))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")

        ucrNudQuantile.SetParameter(New RParameter("prob", 1))
        ucrNudQuantile.DecimalPlaces = 2
        ucrNudQuantile.Increment = 0.05
        ucrNudQuantile.Maximum = 1
        ucrNudQuantile.SetRDefault(0.5)

        ucrInputNullHypothesis.SetParameter(New RParameter("p", 1))
        ucrInputNullHypothesis.SetValidationTypeAsNumeric(dcmMin:=0, bIncludeMin:=True, dcmMax:=1, bIncludeMax:=True)
        ucrInputNullHypothesis.AddQuotesIfUnrecognised = False

        ucrInputTxtSd.SetParameter(New RParameter("sd_pop", 2))
        ucrInputTxtSd.SetValidationTypeAsNumeric(dcmMin:=0, bIncludeMin:=False)
        ucrInputTxtSd.AddQuotesIfUnrecognised = False


        ucrInputComboConfidenceLevel.SetParameter(New RParameter("conf.level", 2))
        dctConfidence.Add("0.900", "0.90")
        dctConfidence.Add("0.950", "0.95")
        dctConfidence.Add("0.980", "0.98")
        dctConfidence.Add("0.990", "0.99")
        dctConfidence.Add("0.999", "0.999")
        ucrInputComboConfidenceLevel.SetItems(dctConfidence)
        ucrInputComboConfidenceLevel.AddQuotesIfUnrecognised = False
        ucrInputComboConfidenceLevel.SetValidationTypeAsNumeric(dcmMin:=0.0, bIncludeMin:=True, dcmMax:=1.0, bIncludeMax:=True)

        'ucrInputConfidenceInterval.SetParameter(New RParameter("conf.level", 2))
        'dctConfidenceInterval.Add("0.900", "0.90")
        'dctConfidenceInterval.Add("0.950", "0.95")
        'dctConfidenceInterval.Add("0.980", "0.98")
        'dctConfidenceInterval.Add("0.990", "0.99")
        'dctConfidenceInterval.Add("0.999", "0.999")
        'ucrInputConfidenceInterval.SetItems(dctConfidenceInterval)
        'ucrInputConfidenceInterval.AddQuotesIfUnrecognised = False
        'ucrInputConfidenceInterval.SetValidationTypeAsNumeric(dcmMin:=0.0, bIncludeMin:=True, dcmMax:=1.0, bIncludeMax:=True)

        ucrInputSuccess.SetParameter(New RParameter("success", 6))

        ucrPnlGeneralExactCase.AddToLinkedControls(ucrInputComboTests, {rdoTest}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Binomial")
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrInputComboEstimate, {rdoEstimate}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Mean")
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrInputComboConfidenceLevel, {rdoEstimate, rdoTest}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrDistributionChoice, {rdoGeneralCase}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrChkOmitMissing, {rdoEstimate}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboEstimate.AddToLinkedControls(ucrInputComboConfidenceLevel, {"mean", "median", "normal", "quantile", "sd", "variance"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboEstimate.AddToLinkedControls(ucrInputMeanCIMethod, {"mean"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboEstimate.AddToLinkedControls(ucrInputComboMedianCI, {"median"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboEstimate.AddToLinkedControls(ucrInputComboVarianceCI, {"variance"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboEstimate.AddToLinkedControls(ucrInputComboQuantilCI, {"quantile"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.AddToLinkedControls(ucrInputCIMethods, {"binomial"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.AddToLinkedControls(ucrInputComboMethod, {"Bartel"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.AddToLinkedControls(ucrInputComboConfidenceLevel, {"binomial", "proportion", "sign", "t", "Wilcoxon", "Z", "serial corr", "Sen"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.AddToLinkedControls(ucrInputNullHypothesis, {"binomial", "proportion"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.AddToLinkedControls(ucrInputSuccess, {"binomial", "proportion"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.AddToLinkedControls(ucrInputTxtSd, {"Z"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboEstimate.AddToLinkedControls(ucrNudQuantile, {"quantile"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.AddToLinkedControls(ucrChkOmitMissing, {"runs"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.AddToLinkedControls(ucrInputTxtHypothesis, {"sign", "Wilcoxon"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.AddToLinkedControls(ucrInputNulHypothesis, {"t", "Z"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.AddToLinkedControls(ucrInputTextM, {"br", "snh"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboEstimate.AddToLinkedControls(ucrInputComboQMethod, {"quantile"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.SetLinkedDisplayControl(lblTests)
        ucrInputComboEstimate.SetLinkedDisplayControl(lblEstimate)
        ucrInputNullHypothesis.SetLinkedDisplayControl(lblNullHypothesis)
        ucrInputMeanCIMethod.SetLinkedDisplayControl(lblMeanCIMethod)
        ucrInputComboMedianCI.SetLinkedDisplayControl(lblMedianCIMethod)
        ucrInputComboQuantilCI.SetLinkedDisplayControl(lblQuantileCI)
        ucrInputComboVarianceCI.SetLinkedDisplayControl(lblVarCI)
        ucrInputCIMethods.SetLinkedDisplayControl(lblCIMethods)
        ucrInputComboMethod.SetLinkedDisplayControl(lblMethods)
        ucrInputTxtSd.SetLinkedDisplayControl(lblSd)
        ucrInputComboConfidenceLevel.SetLinkedDisplayControl(lblCI)
        ucrNudQuantile.SetLinkedDisplayControl(lblQuantile)
        ucrInputTxtHypothesis.SetLinkedDisplayControl(lblNullHyp)
        ucrInputNulHypothesis.SetLinkedDisplayControl(lblNulHypothesis)
        ucrInputTextM.SetLinkedDisplayControl(lblMonteCarlo)
        ucrInputComboQMethod.SetLinkedDisplayControl(lblQMethod)
        ucrInputSuccess.SetLinkedDisplayControl(lblSuccess)

        lstCommandButtons.AddRange({cmdDisplayOptions, cmdFittingOptions})
        ucrDistributionChoice.SetLinkedDisplayControl(lstCommandButtons)
    End Sub

    Private Sub SetDefaults()
        clsROneVarFitModel = New RFunction
        clsRConvertInteger = New RFunction
        clsRConvertNumeric = New RFunction

        clsRplotFunction = New RFunction
        clsRplotPPComp = New RFunction
        clsRplotCdfcomp = New RFunction
        clsRplotQqComp = New RFunction
        clsRplotDenscomp = New RFunction
        clsRLogLikFunction = New RFunction

        ucrDistribution = New ucrDistributions
        ucrChkOmitMissing.Checked = True


        clsRfitdist = New RFunction
        clsRConvertVector = New RFunction
        clsNaExclude = New RFunction

        clsBionomialFunction = New RFunction
        clsProportionFunction = New RFunction
        clsSignTestFunction = New RFunction
        clsTtestFunction = New RFunction
        clsWilcoxonFunction = New RFunction
        clsZTestFunction = New RFunction
        clsBartelFunction = New RFunction
        clsBrFunction = New RFunction
        clsRunsFunction = New RFunction
        clsSenFunction = New RFunction
        clsSerialCorrFunction = New RFunction
        clsSnhFunction = New RFunction
        clsAdFunction = New RFunction
        clsCvmFunction = New RFunction
        clsLillieFunction = New RFunction
        clsPearsonFunction = New RFunction
        clsSfFunction = New RFunction


        clsMeanCIFunction = New RFunction
        clsMedianCIFunction = New RFunction
        clsNormCIFunction = New RFunction
        clsQuantileCIFunction = New RFunction
        clsSdCIFunction = New RFunction
        clsVarCIFunction = New RFunction

        ucrSelectorOneVarFitMod.Reset()
        ucrSaveModel.Reset()

        ucrChkConvertVariate.Visible = False 'hide convert to numeric checkbox by default

        'General Case
        clsROneVarFitModel.SetPackageName("fitdistrplus")
        clsROneVarFitModel.SetRCommand("fitdist")
        clsROneVarFitModel.AddParameter("method", Chr(34) & "mle" & Chr(34), iPosition:=1)
        clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertInteger, iPosition:=0)

        clsNaExclude.SetPackageName("stats")
        clsNaExclude.SetRCommand("na.exclude")

        clsRConvertNumeric.SetRCommand("as.numeric")
        clsRConvertNumeric.AddParameter("x", clsRFunctionParameter:=clsNaExclude, iPosition:=0)

        clsRConvertInteger.SetRCommand("as.integer")
        clsRConvertInteger.AddParameter("x", clsRFunctionParameter:=clsNaExclude, iPosition:=0)

        clsRConvertVector.SetRCommand("as.vector")
        clsRConvertVector.AddParameter("x", clsRFunctionParameter:=clsNaExclude, iPosition:=0)

        clsRfitdist.SetPackageName("fitdistrplus")
        clsRfitdist.SetRCommand("fitdist")

        'Display Options/Functions
        clsRplotFunction.SetPackageName("graphics")
        clsRplotFunction.SetRCommand("plot")
        clsRplotFunction.AddParameter("x", clsRFunctionParameter:=clsROneVarFitModel, iPosition:=0)
        clsRplotFunction.iCallType = 3
        clsRplotFunction.bExcludeAssignedFunctionOutput = False

        clsRplotPPComp.SetPackageName("fitdistrplus")
        clsRplotPPComp.SetRCommand("ppcomp")
        clsRplotPPComp.bExcludeAssignedFunctionOutput = False
        clsRplotPPComp.iCallType = 3
        clsRplotPPComp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34), iPosition:=0)
        clsRplotPPComp.AddParameter("ft", clsRFunctionParameter:=clsROneVarFitModel, iPosition:=1)

        clsRplotCdfcomp.SetPackageName("fitdistrplus")
        clsRplotCdfcomp.SetRCommand("cdfcomp")
        clsRplotCdfcomp.bExcludeAssignedFunctionOutput = False
        clsRplotCdfcomp.iCallType = 3
        clsRplotCdfcomp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34), iPosition:=0)
        clsRplotCdfcomp.AddParameter("ft", clsRFunctionParameter:=clsROneVarFitModel, iPosition:=1)

        clsRplotQqComp.SetPackageName("fitdistrplus")
        clsRplotQqComp.SetRCommand("qqcomp")
        clsRplotQqComp.bExcludeAssignedFunctionOutput = False
        clsRplotQqComp.iCallType = 3
        clsRplotQqComp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34), iPosition:=0)
        clsRplotQqComp.AddParameter("ft", clsRFunctionParameter:=clsROneVarFitModel, iPosition:=1)

        clsRplotDenscomp.SetPackageName("fitdistrplus")
        clsRplotDenscomp.SetRCommand("denscomp")
        clsRplotDenscomp.bExcludeAssignedFunctionOutput = False
        clsRplotDenscomp.iCallType = 3
        clsRplotDenscomp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34), iPosition:=0)
        clsRplotDenscomp.AddParameter("ft", clsRFunctionParameter:=clsROneVarFitModel, iPosition:=1)

        clsRLogLikFunction.SetPackageName("fitdistrplus")
        clsRLogLikFunction.SetRCommand("llplot")
        clsRLogLikFunction.iCallType = 3
        clsRLogLikFunction.AddParameter("mlefit", clsRFunctionParameter:=clsROneVarFitModel, iPosition:=0)

        'Test
        clsBionomialFunction.SetPackageName("mosaic")
        clsBionomialFunction.SetRCommand("binom.test")
        clsBionomialFunction.AddParameter("p", "0.5", iPosition:=1)
        clsBionomialFunction.AddParameter("conf.level", "0.95", iPosition:=2)
        clsBionomialFunction.AddParameter("ci.method", Chr(34) & "Clopper-Pearson" & Chr(34), iPosition:=3)

        clsProportionFunction.SetPackageName("mosaic")
        clsProportionFunction.SetRCommand("prop.test")
        clsProportionFunction.AddParameter("p", "0.5", iPosition:=1)

        clsSignTestFunction.SetPackageName("DescTools")
        clsSignTestFunction.SetRCommand("SignTest")
        clsSignTestFunction.AddParameter("mu", "0", iPosition:=1)

        clsTtestFunction.SetPackageName("mosaic")
        clsTtestFunction.SetRCommand("t.test")
        clsTtestFunction.AddParameter("mu", "0", iPosition:=1)

        clsWilcoxonFunction.SetPackageName("stats")
        clsWilcoxonFunction.SetRCommand("wilcox.test")
        clsWilcoxonFunction.AddParameter("mu", "0", iPosition:=1)


        clsZTestFunction.SetPackageName("DescTools")
        clsZTestFunction.SetRCommand("ZTest")
        clsZTestFunction.AddParameter("sd_pop", "1", iPosition:=2)

        clsBartelFunction.SetPackageName("DescTools")
        clsBartelFunction.SetRCommand("BartelsRankTest")
        clsBartelFunction.AddParameter("method", Chr(34) & "normal" & Chr(34), iPosition:=1)

        clsBrFunction.SetPackageName("trend")
        clsBrFunction.SetRCommand("br.test")
        clsBrFunction.AddParameter("m", "20000", iPosition:=1)

        clsRunsFunction.SetPackageName("DescTools")
        clsRunsFunction.SetRCommand("RunsTest")

        clsSenFunction.SetPackageName("trend")
        clsSenFunction.SetRCommand("sens.slope")

        clsSerialCorrFunction.SetPackageName("EnvStats")
        clsSerialCorrFunction.SetRCommand("serialCorrelationTest")
        clsSerialCorrFunction.AddParameter("test", Chr(34) & "rank.von.Neumann" & Chr(34), iPosition:=1)

        clsSnhFunction.SetPackageName("trend")
        clsSnhFunction.SetRCommand("snh.test")

        clsAdFunction.SetPackageName("nortest")
        clsAdFunction.SetRCommand("ad.test")

        clsCvmFunction.SetPackageName("nortest")
        clsCvmFunction.SetRCommand("cvm.test")

        clsLillieFunction.SetPackageName("nortest")
        clsLillieFunction.SetRCommand("lillie.test")

        clsPearsonFunction.SetPackageName("nortest")
        clsPearsonFunction.SetRCommand("pearson.test")

        clsSfFunction.SetPackageName("nortest")
        clsSfFunction.SetRCommand("sf.test")

        'Estimate
        clsMeanCIFunction.SetPackageName("DescTools")
        clsMeanCIFunction.SetRCommand("MeanCI")
        clsMeanCIFunction.AddParameter("conf.level", "0.95", iPosition:=1)
        clsMeanCIFunction.AddParameter("method", Chr(34) & "classic" & Chr(34), iPosition:=2)


        clsMedianCIFunction.SetPackageName("DescTools")
        clsMedianCIFunction.SetRCommand("MedianCI ")
        clsMedianCIFunction.AddParameter("method", Chr(34) & "exact" & Chr(34), iPosition:=2)

        clsNormCIFunction.SetPackageName("MKinfer")
        clsNormCIFunction.SetRCommand("normCI")
        clsNormCIFunction.AddParameter("mean", "NULL", iPosition:=1)
        clsNormCIFunction.AddParameter("sd", "NULL", iPosition:=2)
        clsNormCIFunction.AddParameter("boot", "FALSE", iPosition:=4)
        clsNormCIFunction.AddParameter("R", "9999", iPosition:=5)
        clsNormCIFunction.AddParameter("bootci.type", Chr(34) & "all" & Chr(34), iPosition:=6)


        clsQuantileCIFunction.SetPackageName("MKinfer")
        clsQuantileCIFunction.SetRCommand("quantileCI")
        clsQuantileCIFunction.AddParameter("prob", "0.5", iPosition:=1)
        clsQuantileCIFunction.AddParameter("method", Chr(34) & "exact" & Chr(34), iPosition:=3)
        clsQuantileCIFunction.AddParameter("R", "9999", iPosition:=4)
        clsQuantileCIFunction.AddParameter("minLength", "FALSE", iPosition:=6)
        clsQuantileCIFunction.AddParameter("bootci.type", Chr(34) & "norm" & Chr(34), iPosition:=5)



        clsSdCIFunction.SetPackageName("MKinfer")
        clsSdCIFunction.SetRCommand("sdCI")
        clsSdCIFunction.AddParameter("boot", "FALSE", iPosition:=2)
        clsSdCIFunction.AddParameter("R", "9999", iPosition:=3)
        clsSdCIFunction.AddParameter("bootci.type", "all", iPosition:=4)
        clsSdCIFunction.AddParameter("na.rm", "TRUE", iPosition:=5)

        clsVarCIFunction.SetPackageName("DescTools")
        clsVarCIFunction.SetRCommand("VarCI")
        clsVarCIFunction.AddParameter("method", Chr(34) & "classic" & Chr(34), iPosition:=1)

        clsROneVarFitModel.SetAssignTo("last_model", strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model")
        clsRLogLikFunction.SetAssignTo("last_likelihood", strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_likelihood")
        clsRplotFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsROneVarFitModel)
        bResetFittingOptions = True
        bResetFitModDisplay = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsBionomialFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsProportionFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsSignTestFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsTtestFunction, New RParameter("x", 0), iAdditionalPairNo:=4)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsWilcoxonFunction, New RParameter("x", 0), iAdditionalPairNo:=5)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsZTestFunction, New RParameter("x", 0), iAdditionalPairNo:=6)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsMeanCIFunction, New RParameter("x", 0), iAdditionalPairNo:=7)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsMedianCIFunction, New RParameter("x", 0), iAdditionalPairNo:=8)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsNormCIFunction, New RParameter("x", 0), iAdditionalPairNo:=9)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsQuantileCIFunction, New RParameter("x", 0), iAdditionalPairNo:=10)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsSdCIFunction, New RParameter("x", 0), iAdditionalPairNo:=11)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsVarCIFunction, New RParameter("x", 0), iAdditionalPairNo:=12)
        ucrChkOmitMissing.AddAdditionalCodeParameterPair(clsMedianCIFunction, ucrChkOmitMissing.GetParameter(), iAdditionalPairNo:=1)
        ucrChkOmitMissing.AddAdditionalCodeParameterPair(clsVarCIFunction, ucrChkOmitMissing.GetParameter(), iAdditionalPairNo:=2)
        ucrChkOmitMissing.AddAdditionalCodeParameterPair(clsSdCIFunction, ucrChkOmitMissing.GetParameter(), iAdditionalPairNo:=3)
        ucrChkOmitMissing.AddAdditionalCodeParameterPair(clsNormCIFunction, ucrChkOmitMissing.GetParameter(), iAdditionalPairNo:=4)
        ucrChkOmitMissing.AddAdditionalCodeParameterPair(clsQuantileCIFunction, ucrChkOmitMissing.GetParameter(), iAdditionalPairNo:=5)
        ucrChkOmitMissing.AddAdditionalCodeParameterPair(clsRunsFunction, ucrChkOmitMissing.GetParameter(), iAdditionalPairNo:=6)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsBartelFunction, New RParameter("x", 0), iAdditionalPairNo:=13)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsBrFunction, New RParameter("x", 0), iAdditionalPairNo:=14)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRunsFunction, New RParameter("x", 0), iAdditionalPairNo:=15)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsSenFunction, New RParameter("x", 0), iAdditionalPairNo:=16)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsSerialCorrFunction, New RParameter("x", 0), iAdditionalPairNo:=17)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsSnhFunction, New RParameter("x", 0), iAdditionalPairNo:=18)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsAdFunction, New RParameter("x", 0), iAdditionalPairNo:=19)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsCvmFunction, New RParameter("x", 0), iAdditionalPairNo:=20)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsLillieFunction, New RParameter("x", 0), iAdditionalPairNo:=21)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsPearsonFunction, New RParameter("x", 0), iAdditionalPairNo:=22)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsSfFunction, New RParameter("x", 0), iAdditionalPairNo:=23)
        ucrInputComboConfidenceLevel.AddAdditionalCodeParameterPair(clsMedianCIFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=1)
        ucrInputComboConfidenceLevel.AddAdditionalCodeParameterPair(clsNormCIFunction, New RParameter("conf.level", 1), iAdditionalPairNo:=2)
        ucrInputComboConfidenceLevel.AddAdditionalCodeParameterPair(clsQuantileCIFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=3)
        ucrInputComboConfidenceLevel.AddAdditionalCodeParameterPair(clsSdCIFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=4)
        ucrInputComboConfidenceLevel.AddAdditionalCodeParameterPair(clsSdCIFunction, New RParameter("conf.level", 1), iAdditionalPairNo:=5)
        ucrInputComboConfidenceLevel.AddAdditionalCodeParameterPair(clsVarCIFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=6)
        ucrInputComboConfidenceLevel.AddAdditionalCodeParameterPair(clsTtestFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=7)
        ucrInputComboConfidenceLevel.AddAdditionalCodeParameterPair(clsProportionFunction, New RParameter("conf.level", 3), iAdditionalPairNo:=8)
        ucrInputComboConfidenceLevel.AddAdditionalCodeParameterPair(clsZTestFunction, New RParameter("conf.level", 3), iAdditionalPairNo:=9)
        ucrInputComboConfidenceLevel.AddAdditionalCodeParameterPair(clsSignTestFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=10)
        ucrInputComboConfidenceLevel.AddAdditionalCodeParameterPair(clsWilcoxonFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=11)
        ucrInputComboConfidenceLevel.AddAdditionalCodeParameterPair(clsSenFunction, New RParameter("conf.level", 1), iAdditionalPairNo:=12)
        ucrInputComboConfidenceLevel.AddAdditionalCodeParameterPair(clsSerialCorrFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=13)
        ucrInputComboConfidenceLevel.AddAdditionalCodeParameterPair(clsBionomialFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=14)
        ucrInputTxtHypothesis.AddAdditionalCodeParameterPair(clsWilcoxonFunction, New RParameter("mu", 2), iAdditionalPairNo:=1)
        ucrInputNullHypothesis.AddAdditionalCodeParameterPair(clsSfFunction, New RParameter("mu", 1), iAdditionalPairNo:=1)
        ucrInputNulHypothesis.AddAdditionalCodeParameterPair(clsZTestFunction, New RParameter("mu", 1), iAdditionalPairNo:=1)
        ucrInputTextM.AddAdditionalCodeParameterPair(clsSnhFunction, New RParameter("m", 1), iAdditionalPairNo:=1)
        ucrInputSuccess.AddAdditionalCodeParameterPair(clsProportionFunction, ucrInputSuccess.GetParameter(), iAdditionalPairNo:=1)

        ' Additional Rcode for test functions
        ucrSaveModel.AddAdditionalRCode(clsBionomialFunction, iAdditionalPairNo:=1)
        ucrSaveModel.AddAdditionalRCode(clsProportionFunction, iAdditionalPairNo:=2)
        ucrSaveModel.AddAdditionalRCode(clsSignTestFunction, iAdditionalPairNo:=3)
        ucrSaveModel.AddAdditionalRCode(clsTtestFunction, iAdditionalPairNo:=4)
        ucrSaveModel.AddAdditionalRCode(clsZTestFunction, iAdditionalPairNo:=5)
        ucrSaveModel.AddAdditionalRCode(clsBartelFunction, iAdditionalPairNo:=6)
        ucrSaveModel.AddAdditionalRCode(clsBrFunction, iAdditionalPairNo:=7)
        ucrSaveModel.AddAdditionalRCode(clsRunsFunction, iAdditionalPairNo:=8)
        ucrSaveModel.AddAdditionalRCode(clsSenFunction, iAdditionalPairNo:=9)
        ucrSaveModel.AddAdditionalRCode(clsSerialCorrFunction, iAdditionalPairNo:=10)
        ucrSaveModel.AddAdditionalRCode(clsSfFunction, iAdditionalPairNo:=11)
        ucrSaveModel.AddAdditionalRCode(clsSnhFunction, iAdditionalPairNo:=12)
        ucrSaveModel.AddAdditionalRCode(clsAdFunction, iAdditionalPairNo:=13)
        ucrSaveModel.AddAdditionalRCode(clsCvmFunction, iAdditionalPairNo:=14)
        ucrSaveModel.AddAdditionalRCode(clsWilcoxonFunction, iAdditionalPairNo:=15)
        ucrSaveModel.AddAdditionalRCode(clsLillieFunction, iAdditionalPairNo:=16)
        ucrSaveModel.AddAdditionalRCode(clsPearsonFunction, iAdditionalPairNo:=17)

        ' Additional Rcode for estimates functions
        ucrSaveModel.AddAdditionalRCode(clsMeanCIFunction, iAdditionalPairNo:=18)
        ucrSaveModel.AddAdditionalRCode(clsMedianCIFunction, iAdditionalPairNo:=19)
        ucrSaveModel.AddAdditionalRCode(clsQuantileCIFunction, iAdditionalPairNo:=20)
        ucrSaveModel.AddAdditionalRCode(clsSdCIFunction, iAdditionalPairNo:=21)
        ucrSaveModel.AddAdditionalRCode(clsVarCIFunction, iAdditionalPairNo:=22)


        ucrPnlGeneralExactCase.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverVariable.SetRCode(clsNaExclude, bReset)
        ucrChkConvertVariate.SetRCode(clsROneVarFitModel, bReset)
        ucrChkOmitMissing.SetRCode(clsMeanCIFunction, bReset)
        ucrInputNullHypothesis.SetRCode(clsBionomialFunction, bReset)
        ucrInputMeanCIMethod.SetRCode(clsMeanCIFunction, bReset)
        ucrInputCIMethods.SetRCode(clsBionomialFunction, bReset)
        ucrInputComboMethod.SetRCode(clsBartelFunction, bReset)
        ucrInputComboMedianCI.SetRCode(clsMedianCIFunction, bReset)
        ucrInputComboVarianceCI.SetRCode(clsVarCIFunction, bReset)
        ucrInputComboQuantilCI.SetRCode(clsQuantileCIFunction, bReset)
        ucrInputTxtSd.SetRCode(clsZTestFunction, bReset)
        ucrInputComboConfidenceLevel.SetRCode(clsMeanCIFunction, bReset)
        ucrNudQuantile.SetRCode(clsQuantileCIFunction, bReset)
        ucrInputTxtHypothesis.SetRCode(clsSignTestFunction, bReset)
        ucrInputComboQMethod.SetRCode(clsQuantileCIFunction, bReset)
        ucrInputNulHypothesis.SetRCode(clsTtestFunction, bReset)
        ucrInputTextM.SetRCode(clsBrFunction)
        ucrInputSuccess.SetRCode(clsBionomialFunction, bReset)

        ucrSaveModel.SetRCode(clsROneVarFitModel, bReset)

    End Sub

    Private Sub TestOKEnabled()
        If ucrSaveModel.IsComplete() AndAlso Not ucrReceiverVariable.IsEmpty AndAlso ucrDistributionChoice.ucrInputDistributions.cboInput.SelectedItem <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub StartParameterValues()
        If ucrDistributionChoice.clsCurrDistribution.strNameTag = "von_mises" Then
            clsROneVarFitModel.AddParameter("start", "list(mu = 0.1, kappa = 0.2)", iPosition:=1)
        Else
            Select Case ucrDistributionChoice.clsCurrDistribution.strNameTag
                Case "Chi_Square"
                    clsROneVarFitModel.AddParameter("start", "list(df = 0.1)", iPosition:=1)
                Case "Students_t"
                    clsROneVarFitModel.AddParameter("start", "list(df = 0.1)", iPosition:=1)
                Case "F"
                    clsROneVarFitModel.AddParameter("start", "list(df1 = 0.1, df2 = 0.2)", iPosition:=1)
                Case "Bernouli"
                    clsROneVarFitModel.AddParameter("start", "list(size = 1, prob = 0.5)", iPosition:=1)
                Case "Binomial"
                    clsROneVarFitModel.AddParameter("start", "list(size = 1, prob = 0.5)", iPosition:=1)
                Case "Weibull"
                    clsROneVarFitModel.AddParameter("start", "list(shape = 1, scale = 2)", iPosition:=1)
                Case Else
                    clsROneVarFitModel.RemoveParameterByName("start")
            End Select
        End If
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgOneVarFitModDisplay.SetRCode(ucrBase.clsRsyntax, clsRNewOneVarFitModel:=clsROneVarFitModel, clsNewRLogLikFunction:=clsRLogLikFunction, clsNewRplotFunction:=clsRplotFunction, clsNewRplotPPComp:=clsRplotPPComp, clsNewRplotCdfcomp:=clsRplotCdfcomp, clsNewRplotQqComp:=clsRplotQqComp, clsNewRplotDenscomp:=clsRplotDenscomp, ucrNewDistribution:=ucrDistribution, bReset:=bResetFitModDisplay)
        bResetFitModDisplay = False
        sdgOneVarFitModDisplay.ShowDialog()
    End Sub

    Private Sub cmdFittingOptions_Click(sender As Object, e As EventArgs) Handles cmdFittingOptions.Click
        sdgOneVarFitModel.SetRCode(ucrBase.clsRsyntax, clsROneVarFitModel, clsNewRLogLikFunction:=clsRLogLikFunction, ucrNewDistribution:=ucrDistribution, bReset:=bResetFittingOptions)
        bResetFittingOptions = False
        sdgOneVarFitModel.ShowDialog()
    End Sub

    Private Sub SetSaveLabelTextAndPrefix()
        If rdoGeneralCase.Checked Then
            ucrSaveModel.SetCheckBoxText("Save Model")
            ucrSaveModel.SetPrefix("dist")
        ElseIf rdoTest.Checked Then
            ucrSaveModel.SetCheckBoxText("Save Test")
            ucrSaveModel.SetPrefix("test")
        ElseIf rdoEstimate.Checked Then
            ucrSaveModel.SetCheckBoxText("Save Estimate")
            ucrSaveModel.SetPrefix("ci")
        End If
    End Sub

    Private Sub ucrPnlGeneralExactCase_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGeneralExactCase.ControlValueChanged
        If rdoGeneralCase.Checked Then
            ucrDistributionChoice.SetAllDistributions()
        Else
            ucrDistributionChoice.SetExactDistributions()
        End If
        SetTestEstimateBaseFunction()
        SetSaveLabelTextAndPrefix()
    End Sub

    Private Sub ucrDistributions_cboDistributionsIndexChanged() Handles ucrDistributionChoice.DistributionsIndexChanged
        If rdoGeneralCase.Checked Then
            clsROneVarFitModel.AddParameter("distr", Chr(34) & ucrDistributionChoice.clsCurrDistribution.strRName & Chr(34))
            ucrSaveModel.SetPrefix(ucrDistributionChoice.clsCurrDistribution.strNameTag)
            StartParameterValues()
            TestOKEnabled()
        End If
    End Sub

    Private Sub ucrReceiverVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariable.ControlValueChanged, ucrDistributionChoice.ControlValueChanged, ucrPnlGeneralExactCase.ControlValueChanged
        If rdoGeneralCase.Checked Then
            clsRfitdist.AddParameter("distr", Chr(34) & ucrDistributionChoice.clsCurrDistribution.strRName & Chr(34))
            If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Poisson" Then
                clsRConvertInteger.SetRCommand("as.integer")
                clsRfitdist.AddParameter("data", clsRFunctionParameter:=clsRConvertInteger, iPosition:=0)
            Else
                clsRConvertVector.SetRCommand("as.vector")
                clsRfitdist.AddParameter("data", clsRFunctionParameter:=clsRConvertVector, iPosition:=0)
            End If
            If Not ucrReceiverVariable.IsEmpty Then
                ucrDistributionChoice.RecieverDatatype(ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverVariable.GetVariableNames(bWithQuotes:=False))
                If ucrReceiverVariable.strCurrDataType = "numeric" Then
                    ucrChkConvertVariate.Checked = False
                    ucrChkConvertVariate.Visible = False
                Else
                    ucrChkConvertVariate.Visible = True
                End If
                If ucrChkConvertVariate.Checked Then
                    clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertNumeric, iPosition:=0)
                Else
                    'TODO This is needed because fitdist checks is.vector on data which is FALSE when data has attributes
                    If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Poisson" OrElse ucrDistributionChoice.clsCurrDistribution.strNameTag = "Geometric" Then
                        clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertInteger, iPosition:=0)
                    Else
                        clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertVector, iPosition:=0)
                    End If
                    If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Extreme_Value" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Binomial" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Bernouli" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Students_t" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Chi_Square" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "F" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Hypergeometric" Then
                        ' TODO llplot() no longer works with starting values. However, the mle's will not plot without starting values for these variables
                    End If
                End If
            Else
                ucrChkConvertVariate.Visible = False
            End If
            If ucrDistributionChoice.lstCurrentDistributions.Count = 0 OrElse ucrReceiverVariable.IsEmpty() Then
                ucrDistributionChoice.Enabled = False
                ucrDistributionChoice.ucrInputDistributions.SetName("")
            Else
                ucrDistributionChoice.Enabled = True
            End If
        Else
            ucrChkConvertVariate.Visible = False
        End If
    End Sub

    Private Sub SetTestEstimateBaseFunction()
        If rdoGeneralCase.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsROneVarFitModel)
            ucrBase.clsRsyntax.AddToAfterCodes(clsRplotFunction, iPosition:=1)
        ElseIf rdoTest.Checked Then
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRplotFunction)
            ucrReceiverVariable.AddIncludedMetadataProperty("class", {Chr(34) & "" & Chr(34)})
            Select Case ucrInputComboTests.GetValue
                Case "binomial"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsBionomialFunction)
                Case "proportion"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsProportionFunction)
                Case "sign"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsSignTestFunction)
                Case "t"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsTtestFunction)
                Case "Wilcoxon"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsWilcoxonFunction)
                Case "Z"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsZTestFunction)
                Case "Bartel"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsBartelFunction)
                Case "br"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsBrFunction)
                Case "runs"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsRunsFunction)
                Case "Sen"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsSenFunction)
                Case "serial corr"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsSerialCorrFunction)
                Case "snh"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsSnhFunction)
                Case "ad"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsAdFunction)
                Case "cvm"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsLillieFunction)
                Case "pearson"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsPearsonFunction)
                Case "sf"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsSfFunction)
            End Select
        ElseIf rdoEstimate.Checked Then
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRplotFunction)
            Select Case ucrInputComboEstimate.GetValue
                Case "mean"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsMeanCIFunction)
                Case "median"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsMedianCIFunction)
                Case "normal"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsNormCIFunction)
                Case "quantile"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsQuantileCIFunction)
                Case "sd"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsSdCIFunction)
                Case "variance"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsVarCIFunction)
            End Select
        End If
    End Sub

    Private Sub ucrInputTests_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboTests.ControlValueChanged, ucrInputComboEstimate.ControlValueChanged
        SetTestEstimateBaseFunction()
    End Sub

    Private Sub AllControl_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveModel.ControlContentsChanged, ucrReceiverVariable.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
