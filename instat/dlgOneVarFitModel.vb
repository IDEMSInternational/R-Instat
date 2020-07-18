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
        Dim lstCommandButtons As New List(Of Control)

        ucrBase.iHelpTopicID = 296
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrPnlGeneralExactCase.AddRadioButton(rdoGeneralCase)
        ucrPnlGeneralExactCase.AddRadioButton(rdoTest)
        ucrPnlGeneralExactCase.AddRadioButton(rdoEstimate)

        ucrPnlGeneralExactCase.AddFunctionNamesCondition(rdoGeneralCase, "fitdist")
        ucrPnlGeneralExactCase.AddFunctionNamesCondition(rdoTest, {"binom.test", "prop.test", "SignTest", "t.test", "wilcox.test", "ZTest", "BartelsRankTest", "br.test", "RunsTest", "sens.slope", "serialcorrelationTest", "snh.test", "ad.test", "cvm.test", "lillie.test", "pearson.test", "sf.test"})
        ucrPnlGeneralExactCase.AddFunctionNamesCondition(rdoEstimate, {"MeanCI", "MedianCI ", "normCI", "PoissonCI", "quantileCI", "sdCI", "VarCI"})

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

        ucrInputComboTests.SetItems({"Binomial", "Proportion", "Sign", "T", "Wilcoxon", "Z", "Bartel", "Br", "Runs", "Sen", "Serial Corr", "Snh", "Ad", "Cvm", "Lillie", "Pearson", "Sf"})
        ucrInputComboTests.SetDropDownStyleAsNonEditable()

        ucrInputComboEstimate.SetItems({"Mean", "Median", "Normal", "Quantile", "Sd", "Variance"})
        ucrInputComboEstimate.SetDropDownStyleAsNonEditable()

        ucrInputMeanCIMethod.SetParameter(New RParameter("method", 3))
        dctmeanCI.Add("Classic", Chr(34) & "classic" & Chr(34))
        dctmeanCI.Add("Boot", Chr(34) & "boot" & Chr(34))
        ucrInputMeanCIMethod.SetItems(dctmeanCI)
        ucrInputMeanCIMethod.SetDropDownStyleAsNonEditable()

        ucrInputComboMedianCI.SetParameter(New RParameter("method", 2))
        dctMedianCI.Add("Exact", Chr(34) & "exact" & Chr(34))
        dctMedianCI.Add("Boot", Chr(34) & "boot" & Chr(34))
        ucrInputComboMedianCI.SetItems(dctMedianCI)
        ucrInputComboMedianCI.SetDropDownStyleAsNonEditable()

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

        ucrNudConfidenceLevel.SetParameter(New RParameter("conf.level", 2))
        ucrNudConfidenceLevel.DecimalPlaces = 2
        ucrNudConfidenceLevel.Increment = 0.05
        ucrNudConfidenceLevel.Maximum = 1
        ucrNudConfidenceLevel.SetRDefault(0.95)


        ucrInputNullHypothesis.SetParameter(New RParameter("p", 1))
        ucrInputNullHypothesis.SetParameterValue("0.5")
        'ucrInputNullHypothesis.SetText("Null Hypothesis")
        ucrInputNullHypothesis.SetValidationTypeAsNumeric(0, 1)
        ucrInputNullHypothesis.AddQuotesIfUnrecognised = False

        ucrInputTxtSd.SetParameter(New RParameter("sd_pop", 2))
        'ucrInputTxtSd.SetText("Sd_Pop:")
        ucrInputTxtSd.SetParameterValue(1)
        ucrInputTxtSd.SetValidationTypeAsNumeric()
        ucrInputTxtSd.AddQuotesIfUnrecognised = False

        ucrPnlGeneralExactCase.AddToLinkedControls(ucrInputComboTests, {rdoTest}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Binomial")
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrInputComboEstimate, {rdoEstimate}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Mean")
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrDistributionChoice, {rdoGeneralCase}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrChkOmitMissing, {rdoEstimate}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrNudConfidenceLevel, {rdoTest, rdoEstimate}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrInputNullHypothesis, {rdoTest}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboEstimate.AddToLinkedControls(ucrInputMeanCIMethod, {"Mean"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboEstimate.AddToLinkedControls(ucrInputComboMedianCI, {"Median"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboEstimate.AddToLinkedControls(ucrInputComboVarianceCI, {"Variance"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboEstimate.AddToLinkedControls(ucrInputComboQuantilCI, {"Quantile"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.AddToLinkedControls(ucrInputCIMethods, {"Binomial"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.AddToLinkedControls(ucrInputComboMethod, {"Bartel"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.AddToLinkedControls(ucrNudConfidenceLevel, {"Binomial", "Proportion", "Sign", "T", "Wilcoxon", "Z", "Serial Corr"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.AddToLinkedControls(ucrInputNullHypothesis, {"Binomial", "Proportion", "Sign", "T", "Wilcoxon", "Z"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.AddToLinkedControls(ucrInputTxtSd, {"Z"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboTests.SetLinkedDisplayControl(lblTests)
        ucrInputComboEstimate.SetLinkedDisplayControl(lblEstimate)
        ucrNudConfidenceLevel.SetLinkedDisplayControl(lblConfidenceLevel)
        ucrInputNullHypothesis.SetLinkedDisplayControl(lblNullHypothesis)
        ucrInputMeanCIMethod.SetLinkedDisplayControl(lblMeanCIMethod)
        ucrInputComboMedianCI.SetLinkedDisplayControl(lblMedianCIMethod)
        ucrInputComboQuantilCI.SetLinkedDisplayControl(lblQuantileCI)
        ucrInputComboVarianceCI.SetLinkedDisplayControl(lblVarCI)
        ucrInputCIMethods.SetLinkedDisplayControl(lblCIMethods)
        ucrInputComboMethod.SetLinkedDisplayControl(lblMethods)
        ucrInputTxtSd.SetLinkedDisplayControl(lblSd)

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
        clsBionomialFunction.AddParameter("p", 0.5, iPosition:=1)
        clsBionomialFunction.AddParameter("ci.method", Chr(34) & "Clopper-Pearson" & Chr(34), iPosition:=3)

        clsProportionFunction.SetPackageName("mosaic")
        clsProportionFunction.SetRCommand("prop.test")
        clsProportionFunction.AddParameter("n", "", iPosition:=1)
        clsProportionFunction.AddParameter("p", "0.5", iPosition:=2)

        clsSignTestFunction.SetPackageName("DescTools")
        clsSignTestFunction.SetRCommand("SignTest")

        clsTtestFunction.SetPackageName("mosaic")
        clsTtestFunction.SetRCommand("t.test")
        clsTtestFunction.AddParameter("mu", "0", iPosition:=1)

        clsWilcoxonFunction.SetPackageName("stats")
        clsWilcoxonFunction.SetRCommand("wilcox.test")
        clsWilcoxonFunction.AddParameter("mu", "0", iPosition:=1)


        clsZTestFunction.SetPackageName("DescTools")
        clsZTestFunction.SetRCommand("ZTest")
        clsZTestFunction.AddParameter("mu", "0", iPosition:=1)

        clsBartelFunction.SetPackageName("DescTools")
        clsBartelFunction.SetRCommand("BartelsRankTest")
        clsBartelFunction.AddParameter("method", Chr(34) & "normal" & Chr(34), iPosition:=1)

        clsBrFunction.SetPackageName("trend")
        clsBrFunction.SetRCommand("br.test")
        clsBrFunction.AddParameter("m", "20000", iPosition:=1)

        clsRunsFunction.SetPackageName("DescTools")
        clsRunsFunction.SetRCommand("RunsTest")
        clsRunsFunction.AddParameter("na.rm", "True", iPosition:=1)

        clsSenFunction.SetPackageName("trend")
        clsSenFunction.SetRCommand("sens.slope")

        clsSerialCorrFunction.SetPackageName("EnvStats")
        clsSerialCorrFunction.SetRCommand("serialCorrelationTest")
        clsSerialCorrFunction.AddParameter("test", Chr(34) & "rank.von.Neumann" & Chr(34), iPosition:=1)

        clsSnhFunction.SetPackageName("trend")
        clsSnhFunction.SetRCommand("snh.test")
        clsSfFunction.AddParameter("m", "20000", iPosition:=2)

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
        clsMeanCIFunction.AddParameter("tream", "0", iPosition:=1)
        clsMeanCIFunction.AddParameter("method", Chr(34) & "classic" & Chr(34), iPosition:=3)


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
        ucrNudConfidenceLevel.AddAdditionalCodeParameterPair(clsTtestFunction, New RParameter("conf.level", 3), iAdditionalPairNo:=1)
        ucrNudConfidenceLevel.AddAdditionalCodeParameterPair(clsProportionFunction, New RParameter("conf.level", 3), iAdditionalPairNo:=2)
        ucrNudConfidenceLevel.AddAdditionalCodeParameterPair(clsZTestFunction, New RParameter("conf.level", 3), iAdditionalPairNo:=3)
        ucrNudConfidenceLevel.AddAdditionalCodeParameterPair(clsSignTestFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=4)
        ucrNudConfidenceLevel.AddAdditionalCodeParameterPair(clsWilcoxonFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=5)
        ucrNudConfidenceLevel.AddAdditionalCodeParameterPair(clsSenFunction, New RParameter("conf.level", 1), iAdditionalPairNo:=6)
        ucrNudConfidenceLevel.AddAdditionalCodeParameterPair(clsSerialCorrFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=7)
        ucrNudConfidenceLevel.AddAdditionalCodeParameterPair(clsMedianCIFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=8)
        ucrNudConfidenceLevel.AddAdditionalCodeParameterPair(clsNormCIFunction, New RParameter("conf.level", 1), iAdditionalPairNo:=9)
        ucrNudConfidenceLevel.AddAdditionalCodeParameterPair(clsQuantileCIFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=10)
        ucrNudConfidenceLevel.AddAdditionalCodeParameterPair(clsSdCIFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=11)
        ucrNudConfidenceLevel.AddAdditionalCodeParameterPair(clsSdCIFunction, New RParameter("conf.level", 1), iAdditionalPairNo:=12)
        ucrNudConfidenceLevel.AddAdditionalCodeParameterPair(clsMeanCIFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=13)
        ucrNudConfidenceLevel.AddAdditionalCodeParameterPair(clsVarCIFunction, New RParameter("conf.level", 2), iAdditionalPairNo:=14)
        ucrInputNullHypothesis.AddAdditionalCodeParameterPair(clsSignTestFunction, New RParameter("mu", 1), iAdditionalPairNo:=1)
        ucrInputNullHypothesis.AddAdditionalCodeParameterPair(clsSfFunction, New RParameter("mu", 1), iAdditionalPairNo:=2)



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
        'ucrNudConfLevel.SetRCode(clsMeanCIFunction, bReset)
        ucrNudConfidenceLevel.SetRCode(clsBionomialFunction, bReset)
        ucrInputNullHypothesis.SetRCode(clsBionomialFunction, bReset)
        ucrInputMeanCIMethod.SetRCode(clsMeanCIFunction, bReset)
        ucrInputCIMethods.SetRCode(clsBionomialFunction, bReset)
        ucrInputComboMethod.SetRCode(clsBartelFunction, bReset)
        ucrInputComboMedianCI.SetRCode(clsMedianCIFunction, bReset)
        ucrInputComboVarianceCI.SetRCode(clsVarCIFunction, bReset)
        ucrInputComboQuantilCI.SetRCode(clsQuantileCIFunction, bReset)
        ucrInputTxtSd.SetRCode(clsZTestFunction, bReset)

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

    Private Sub ResponseConvert()
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

    Private Sub PlotResiduals()
        clsRfitdist.AddParameter("distr", Chr(34) & ucrDistributionChoice.clsCurrDistribution.strRName & Chr(34))
        If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Poisson" Then
            clsRConvertInteger.SetRCommand("as.integer")
            clsRfitdist.AddParameter("data", clsRFunctionParameter:=clsRConvertInteger, iPosition:=0)
        Else
            clsRConvertVector.SetRCommand("as.vector")
            clsRfitdist.AddParameter("data", clsRFunctionParameter:=clsRConvertVector, iPosition:=0)
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
        SetTestEstimateBaseFunction()
        SetSaveLabelTextAndPrefix()
    End Sub

    Private Sub ucrDistributions_cboDistributionsIndexChanged() Handles ucrDistributionChoice.DistributionsIndexChanged
        If rdoGeneralCase.Checked Then
            clsROneVarFitModel.AddParameter("distr", Chr(34) & ucrDistributionChoice.clsCurrDistribution.strRName & Chr(34))
            ucrSaveModel.SetPrefix(ucrDistributionChoice.clsCurrDistribution.strNameTag)
            PlotResiduals()
            StartParameterValues()
            TestOKEnabled()
        End If
    End Sub

    Private Sub ucrReceiverVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariable.ControlValueChanged
        PlotResiduals()
        ResponseConvert()
    End Sub

    Private Sub SetTestEstimateBaseFunction()
        If rdoGeneralCase.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsROneVarFitModel)
            ucrBase.clsRsyntax.AddToAfterCodes(clsRplotFunction, iPosition:=1)
        ElseIf rdoTest.Checked Then
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRplotFunction)
            Select Case ucrInputComboTests.GetValue
                Case "Binomial"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsBionomialFunction)
                Case "Proportion"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsProportionFunction)
                Case "Sign"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsSignTestFunction)
                Case "T"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsTtestFunction)
                Case "Wilcoxon"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsWilcoxonFunction)
                Case "Z"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsZTestFunction)
                Case "Bartel"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsBartelFunction)
                Case "Br"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsBrFunction)
                Case "Runs"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsRunsFunction)
                Case "Sen"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsSenFunction)
                Case "Serial Corr"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsSerialCorrFunction)
                Case "Snh"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsSnhFunction)
                Case "Ad"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsAdFunction)
                Case "Cvm"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsLillieFunction)
                Case "Pearson"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsPearsonFunction)
                Case "Sf"
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
