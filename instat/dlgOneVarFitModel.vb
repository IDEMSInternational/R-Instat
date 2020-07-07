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
    Private clsMeanCIFunction, clsMedianCIFunction, clsNormCIFunction, clsPoissonCIFunction, clsQuantileCIFunction, clsSdCIFunction, clsVarCIFunction As New RFunction
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
        Dim dctucrOperator As New Dictionary(Of String, String)
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
        ucrSaveModel.SetPrefix("Normal")

        ucrInputComboTests.SetItems({"Binomial", "Proportion", "Sign", "T", "Wilcoxon", "Z", "Bartel", "Br", "Runs", "Sen", "Serial Corr", "Snh", "Ad", "Cvm", "Lillie", "Pearson", "Sf"})
        ucrInputComboTests.SetDropDownStyleAsNonEditable()

        ucrInputComboEstimate.SetItems({"mean", "median", "normal", "poisson", "quantile", "sd", "variance"})
        ucrInputComboEstimate.SetDropDownStyleAsNonEditable()

        ucrInputMethod.SetItems({"classic", "boot"})
        ucrInputMethod.SetDropDownStyleAsNonEditable()




        ucrNudTrim.SetParameter(New RParameter("trim", 1))
        ucrNudTrim.Maximum = 0.5
        ucrNudTrim.DecimalPlaces = 2
        ucrNudTrim.Increment = 0.01


        ucrNudConfidenceLevel.SetParameter(New RParameter("conf.level"))
        ucrNudConfidenceLevel.DecimalPlaces = 3
        ucrNudConfidenceLevel.Minimum = 0.8
        ucrNudConfidenceLevel.Maximum = 0.999
        ucrNudConfidenceLevel.Increment = 0.001

        ucrNudHypothesis.SetParameter(New RParameter("mu"))


        ucrPnlGeneralExactCase.AddToLinkedControls(ucrInputComboTests, {rdoTest}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Binomial")
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrInputComboEstimate, {rdoEstimate}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="mean")
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrDistributionChoice, {rdoGeneralCase}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrNudTrim, {rdoEstimate}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrOmmitMissing, {rdoEstimate}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrNudConfidenceLevel, {rdoTest}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.95)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrNudHypothesis, {rdoTest}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrInputMethod, {rdoEstimate}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="classic")
        ucrInputComboTests.SetLinkedDisplayControl(lblTests)
        ucrInputComboEstimate.SetLinkedDisplayControl(lblEstimate)
        ucrNudTrim.SetLinkedDisplayControl(lblTrim)
        ucrNudTrim.SetLinkedDisplayControl(grpParameters)
        ucrNudConfidenceLevel.SetLinkedDisplayControl(lblConfidenceLevel)
        ucrNudConfidenceLevel.SetLinkedDisplayControl(grpParameters)
        ucrNudHypothesis.SetLinkedDisplayControl(lblDifferenceInMean)
        ucrNudHypothesis.SetLinkedDisplayControl(grpParameters)
        ucrInputMethod.SetLinkedDisplayControl(lblMethod)
        ucrInputMethod.SetLinkedDisplayControl(grpParameters)

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
        clsPoissonCIFunction = New RFunction
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

        clsProportionFunction.SetPackageName("mosaic")
        clsProportionFunction.SetRCommand("prop.test")

        clsSignTestFunction.SetPackageName("DescTools")
        clsSignTestFunction.SetRCommand("SignTest")

        clsTtestFunction.SetPackageName("mosaic")
        clsTtestFunction.SetRCommand("t.test")

        clsWilcoxonFunction.SetPackageName("stats")
        clsWilcoxonFunction.SetRCommand("wilcox.test")


        clsZTestFunction.SetPackageName("DescTools")
        clsZTestFunction.SetRCommand("ZTest")

        clsBartelFunction.SetPackageName("DescTools")
        clsBartelFunction.SetRCommand("BartelsRankTest")

        clsBrFunction.SetPackageName("trend")
        clsBrFunction.SetRCommand("br.test")

        clsRunsFunction.SetPackageName("DescTools")
        clsRunsFunction.SetRCommand("RunsTest")

        clsSenFunction.SetPackageName("trend")
        clsSenFunction.SetRCommand("sens.slope")

        clsSerialCorrFunction.SetPackageName("EnvStats")
        clsSerialCorrFunction.SetRCommand("serialCorrelationTest")

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

        clsMedianCIFunction.SetPackageName("DescTools")
        clsMedianCIFunction.SetRCommand("MedianCI ")

        clsNormCIFunction.SetPackageName("MKinfer")
        clsNormCIFunction.SetRCommand("normCI")

        clsPoissonCIFunction.SetPackageName("DescTools")
        clsPoissonCIFunction.SetRCommand("PoissonCI")

        clsQuantileCIFunction.SetPackageName("MKinfer")
        clsQuantileCIFunction.SetRCommand("quantileCI")

        clsSdCIFunction.SetPackageName("MKinfer")
        clsSdCIFunction.SetRCommand("sdCI")

        clsVarCIFunction.SetPackageName("DescTools")
        clsVarCIFunction.SetRCommand("VarCI")

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
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsPoissonCIFunction, New RParameter("x", 0), iAdditionalPairNo:=10)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsQuantileCIFunction, New RParameter("x", 0), iAdditionalPairNo:=11)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsSdCIFunction, New RParameter("x", 0), iAdditionalPairNo:=12)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsVarCIFunction, New RParameter("x", 0), iAdditionalPairNo:=13)
        ucrOmmitMissing.AddAdditionalCodeParameterPair(clsMedianCIFunction, ucrOmmitMissing.GetParameter(), iAdditionalPairNo:=1)
        ucrOmmitMissing.AddAdditionalCodeParameterPair(clsVarCIFunction, ucrOmmitMissing.GetParameter(), iAdditionalPairNo:=2)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsBartelFunction, New RParameter("x", 0), iAdditionalPairNo:=14)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsBrFunction, New RParameter("x", 0), iAdditionalPairNo:=15)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRunsFunction, New RParameter("x", 0), iAdditionalPairNo:=16)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsSenFunction, New RParameter("x", 0), iAdditionalPairNo:=17)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsSerialCorrFunction, New RParameter("x", 0), iAdditionalPairNo:=18)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsSnhFunction, New RParameter("x", 0), iAdditionalPairNo:=19)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsAdFunction, New RParameter("x", 0), iAdditionalPairNo:=20)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsCvmFunction, New RParameter("x", 0), iAdditionalPairNo:=21)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsLillieFunction, New RParameter("x", 0), iAdditionalPairNo:=22)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsPearsonFunction, New RParameter("x", 0), iAdditionalPairNo:=23)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsSfFunction, New RParameter("x", 0), iAdditionalPairNo:=24)

        ucrPnlGeneralExactCase.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverVariable.SetRCode(clsNaExclude, bReset)
        ucrChkConvertVariate.SetRCode(clsROneVarFitModel, bReset)
        ucrNudTrim.SetRCode(clsMeanCIFunction, bReset)
        ucrOmmitMissing.SetRCode(clsMeanCIFunction, bReset)
        'ucrNudConfidenceLevel.SetRCode(clsTtestFunction)
        'ucrNudHypothesis.SetRCode(clsTtestFunction)

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
            ucrSaveModel.SetAssignToIfUncheckedValue("last_estimate")
            ucrSaveModel.SetPrefix("ci")
        End If
    End Sub

    Private Sub VisibilityOfgrpParameters()
        If rdoTest.Checked Or rdoEstimate.Checked Then
            grpParameters.Visible = True
        Else
            grpParameters.Visible = False
        End If
    End Sub

    Private Sub ucrPnlGeneralExactCase_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGeneralExactCase.ControlValueChanged
        SetTestEstimateBaseFunction()
        VisibilityOfgrpParameters()
    End Sub

    Private Sub ucrDistributions_cboDistributionsIndexChanged() Handles ucrDistributionChoice.DistributionsIndexChanged
        clsROneVarFitModel.AddParameter("distr", Chr(34) & ucrDistributionChoice.clsCurrDistribution.strRName & Chr(34))
        ucrSaveModel.SetPrefix(ucrDistributionChoice.clsCurrDistribution.strNameTag)
        PlotResiduals()
        StartParameterValues()
        TestOKEnabled()
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
                Case "poisson"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsPoissonCIFunction)
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
        SetSaveLabelTextAndPrefix()
        SetTestEstimateBaseFunction()
    End Sub

    Private Sub AllControl_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveModel.ControlContentsChanged, ucrReceiverVariable.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
