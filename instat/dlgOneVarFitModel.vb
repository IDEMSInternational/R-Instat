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
    Public clsROneVarFitModel, clsFamilyFunction, clsRLogLikFunction, clsRLength, clsRMean, clsRTTest, clsVarTest, clsREnormTest, clsRNonSignTest, clsRWilcoxTest, clsRBinomTest, clsRPoissonTest, clsRplot, clsRfitdist, clsRStartValues, clsRBinomStart, clsRConvertVector, clsNaExclude, clsRConvertInteger, clsRConvertNumeric As New RFunction
    Public clsRplotFunction, clsRplotPPComp, clsRplotCdfcomp, clsRplotQqComp, clsRplotDenscomp As RFunction
    Public clsBionomialFunction As New RFunction
    Public clsFunctionOperator, clsFactorOperator As New ROperator
    Private WithEvents ucrDistribution As ucrDistributions
    Public bfirstload As Boolean = True
    Public bRCodeSet As Boolean = False
    Public bReset As Boolean = True
    Private bResetFittingOptions As Boolean = False
    Private bResetFitModDisplay As Boolean = False

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

        ucrBase.iHelpTopicID = 296
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrDistribution = ucrDistributionChoice
        ucrDistributionChoice.SetGLMDistributions()
        ucrDistributionChoice.SetFunctionIsDistFunction()

        ucrReceiverVariable.Selector = ucrSelectorOneVarFitMod
        ucrReceiverVariable.SetMeAsReceiver()

        ucrReceiverVariable.SetParameter(New RParameter("object"))
        ucrReceiverVariable.SetParameterIsRFunction()

        ucrChkConvertVariate.SetText("Convert to Numeric")
        ucrChkConvertVariate.AddParameterValueFunctionNamesCondition(True, "data", "as.numeric", True)
        ucrChkConvertVariate.AddParameterValueFunctionNamesCondition(False, "data", frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data", True)

        ucrSaveModel.SetSaveTypeAsModel()
        ucrSaveModel.SetDataFrameSelector(ucrSelectorOneVarFitMod.ucrAvailableDataFrames)
        ucrSaveModel.SetCheckBoxText("Save Model")
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetAssignToIfUncheckedValue("last_model")
        ucrSaveModel.SetPrefix("Normal")

        ucrInputTests.SetParameter(New RParameter("y", 0))
        ucrInputTests.SetDropDownStyleAsNonEditable()
        ucrInputTests.SetItems({"Binomial", "Proportion", "Sign", "T", "Wilcoxon", "Z"})

        ucrPnlGeneralExactCase.AddRadioButton(rdoGeneralCase)
        ucrPnlGeneralExactCase.AddRadioButton(rdoTest)
        ucrPnlGeneralExactCase.AddRadioButton(rdoEstimate)

        ucrPnlGeneralExactCase.AddFunctionNamesCondition(rdoGeneralCase, "fitdist")
        ucrPnlGeneralExactCase.AddFunctionNamesCondition(rdoTest, "fitdist", False)
        ucrPnlGeneralExactCase.AddFunctionNamesCondition(rdoEstimate, "fitdist", False)

        ucrPnlGeneralExactCase.AddToLinkedControls(ucrInputTests, {rdoTest, rdoEstimate}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrDistributionChoice, {rdoGeneralCase}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputTests.SetLinkedDisplayControl(lblTests)
    End Sub

    Private Sub SetDefaults()
        clsFunctionOperator = New ROperator
        clsFactorOperator = New ROperator

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
        clsNaExclude = New RFunction
        clsBionomialFunction = New RFunction


        clsRConvertInteger = New RFunction
        clsRConvertNumeric = New RFunction
        clsRplotFunction = New RFunction
        clsRplotPPComp = New RFunction
        clsRplotCdfcomp = New RFunction
        clsRplotQqComp = New RFunction
        clsRplotDenscomp = New RFunction
        clsRLogLikFunction = New RFunction
        clsFamilyFunction = New RFunction
        clsROneVarFitModel = New RFunction
        ucrDistribution = New ucrDistributions

        ucrSelectorOneVarFitMod.Reset()
        ucrSaveModel.Reset()

        'General Case
        clsROneVarFitModel.SetPackageName("fitdistrplus")
        clsROneVarFitModel.SetRCommand("fitdist")
        clsROneVarFitModel.AddParameter("method", Chr(34) & "mle" & Chr(34), iPosition:=1)


        clsNaExclude.SetPackageName("stats")
        clsNaExclude.SetRCommand("na.exclude")

        clsRConvertNumeric.SetRCommand("as.numeric")
        clsRConvertNumeric.AddParameter("x", clsRFunctionParameter:=clsNaExclude, iPosition:=0)
        clsRConvertInteger.SetRCommand("as.integer")
        clsRConvertInteger.AddParameter("x", clsRFunctionParameter:=clsNaExclude, iPosition:=0)

        clsRConvertVector.SetRCommand("as.vector")
        clsRConvertVector.AddParameter("x", clsRFunctionParameter:=clsNaExclude)
        clsRStartValues.SetRCommand("mean")

        clsRfitdist.SetPackageName("fitdistrplus")
        clsRfitdist.SetRCommand("fitdist")

        clsFamilyFunction = ucrDistributionChoice.clsCurrRFunction
        clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertInteger, iPosition:=0)

        'TTest
        clsRTTest.SetPackageName("stats")
        clsRTTest.SetRCommand("t.test")
        clsRTTest.AddParameter("mu", 0.00)

        'VarTest
        clsVarTest.SetPackageName("EnvStats")
        clsVarTest.SetRCommand("varTest")

        'Enorm
        clsREnormTest.SetPackageName("EnvStats")
        clsREnormTest.SetRCommand("enorm")

        clsRWilcoxTest.SetPackageName("stats")
        clsRWilcoxTest.SetRCommand("wilcox.test")
        clsRWilcoxTest.AddParameter("mu", 0.00)

        clsRNonSignTest.SetPackageName("signmedian.test")
        clsRNonSignTest.SetRCommand("signmedian.test")

        clsRPoissonTest.SetPackageName("stats")
        clsRPoissonTest.SetRCommand("poisson.test")

        clsRLength.SetRCommand("length")
        clsRMean.SetRCommand("mean")

        clsRBinomTest.SetPackageName("stats")
        clsRBinomTest.SetRCommand("binom.test")

        'Display Options/Functions
        clsRplotFunction.SetPackageName("graphics")
        clsRplotFunction.SetRCommand("plot")
        clsRplotFunction.iCallType = 3
        clsRplotFunction.bExcludeAssignedFunctionOutput = False

        clsRplotPPComp.SetPackageName("fitdistrplus")
        clsRplotPPComp.SetRCommand("ppcomp")
        clsRplotPPComp.bExcludeAssignedFunctionOutput = False
        clsRplotPPComp.iCallType = 3

        clsRplotCdfcomp.SetPackageName("fitdistrplus")
        clsRplotCdfcomp.SetRCommand("cdfcomp")
        clsRplotCdfcomp.bExcludeAssignedFunctionOutput = False
        clsRplotCdfcomp.iCallType = 3

        clsRplotQqComp.SetPackageName("fitdistrplus")
        clsRplotQqComp.SetRCommand("qqcomp")
        clsRplotQqComp.bExcludeAssignedFunctionOutput = False
        clsRplotQqComp.iCallType = 3

        clsRplotDenscomp.SetPackageName("fitdistrplus")
        clsRplotDenscomp.SetRCommand("denscomp")
        clsRplotDenscomp.bExcludeAssignedFunctionOutput = False
        clsRplotDenscomp.iCallType = 3

        clsRLogLikFunction.SetPackageName("fitdistrplus")
        clsRLogLikFunction.SetRCommand("llplot")
        clsRLogLikFunction.iCallType = 3

        clsBionomialFunction.SetPackageName("mosaic")
        clsBionomialFunction.SetRCommand("binom.test")

        SetDataParameter()
        SetBaseFunction()
        SetDistributions()

        clsROneVarFitModel.SetAssignTo("last_model", strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model")
        clsRLogLikFunction.SetAssignTo("last_likelihood", strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_likelihood")
        clsRplotFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsROneVarFitModel)

        clsRplotFunction.AddParameter("x", clsRFunctionParameter:=clsROneVarFitModel)
        ucrBase.clsRsyntax.AddToAfterCodes(clsRplotFunction, iPosition:=1)
        bResetFittingOptions = True
        bResetFitModDisplay = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False
        ucrPnlGeneralExactCase.SetRCode(clsROneVarFitModel, bReset)
        ucrReceiverVariable.SetRCode(clsNaExclude, bReset)
        ucrChkConvertVariate.SetRCode(clsROneVarFitModel, bReset)
        ucrDistributionChoice.SetRCode(clsFamilyFunction, bReset)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRWilcoxTest, New RParameter("x"), iAdditionalPairNo:=1)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRNonSignTest, New RParameter("x"), iAdditionalPairNo:=2)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRLength, New RParameter("x"), iAdditionalPairNo:=3)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRMean, New RParameter("x"), iAdditionalPairNo:=4)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRBinomTest, New RParameter("x"), iAdditionalPairNo:=5)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRStartValues, New RParameter("x"), iAdditionalPairNo:=6)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsBionomialFunction, New RParameter("x", 0), iAdditionalPairNo:=7)

        ucrSaveModel.SetRCode(clsROneVarFitModel, bReset)
        bRCodeSet = True
    End Sub

    Private Sub ucrPnlStats_ControlValueChanged(ucrChangedControl As ucrCore)
        SetBaseFunction()
    End Sub

    Private Sub ucrPnlWilcoxVarTest_ControlValueChanged(ucrChangedControl As ucrCore)
        SetBaseFunction()
    End Sub

    Private Sub SetDistributions()
        If rdoGeneralCase.Checked Then
            ucrDistributionChoice.SetAllDistributions()
        ElseIf rdoTest.Checked Then
            ucrDistributionChoice.SetExactDistributions()
        End If
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

    Public Sub SetDataParameter()
        If Not ucrReceiverVariable.IsEmpty Then
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
            clsROneVarFitModel.RemoveParameterByName("data")
        End If
        If ucrDistributionChoice.lstCurrentDistributions.Count = 0 OrElse ucrReceiverVariable.IsEmpty() Then
            ucrDistributionChoice.Enabled = False
            ucrDistributionChoice.ucrInputDistributions.SetName("")
        Else
            ucrDistributionChoice.Enabled = True
        End If
    End Sub


    Public Sub ResponseConvert()
        If bRCodeSet Then
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

    Public Sub SetBaseFunction()
        If rdoGeneralCase.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsROneVarFitModel)
            clsROneVarFitModel.AddParameter("distr", Chr(34) & ucrDistributionChoice.clsCurrDistribution.strRName & Chr(34))
            SetDataParameter()
            clsRplotPPComp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34), iPosition:=0)
            clsRplotPPComp.AddParameter("ft", clsRFunctionParameter:=clsROneVarFitModel, iPosition:=1)
            clsRplotCdfcomp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34), iPosition:=0)
            clsRplotCdfcomp.AddParameter("ft", clsRFunctionParameter:=clsROneVarFitModel, iPosition:=1)
            clsRplotQqComp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34), iPosition:=0)
            clsRplotQqComp.AddParameter("ft", clsRFunctionParameter:=clsROneVarFitModel, iPosition:=1)
            clsRplotDenscomp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34), iPosition:=0)
            clsRplotDenscomp.AddParameter("ft", clsRFunctionParameter:=clsROneVarFitModel, iPosition:=1)
            clsRLogLikFunction.AddParameter("mlefit", clsRFunctionParameter:=clsROneVarFitModel, iPosition:=0)
        End If
    End Sub

    Public Sub DataTypeAccepted()
        If rdoGeneralCase.Checked Then
            ucrReceiverVariable.RemoveIncludedMetadataProperty("class")
        ElseIf rdoTest.Checked Then
            If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Poisson" Then
                ucrReceiverVariable.SetIncludedDataTypes({"numeric"})
                If (ucrReceiverVariable.strCurrDataType = "factor" OrElse ucrReceiverVariable.strCurrDataType = "character") Then
                    ucrReceiverVariable.Clear()
                End If
            Else
                ucrReceiverVariable.RemoveIncludedMetadataProperty("class")
            End If
        End If
    End Sub


    Private Sub SetBinomialTest()
        If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Binomial" Then
            ucrReceiverVariable.SetDataType(strTemp:="integer" OrElse "numeric" OrElse "character" OrElse "factor")
        End If
        ucrBase.clsRsyntax.SetBaseRFunction(clsRBinomTest)
    End Sub

    Private Sub PlotResiduals()
        clsRplot.AddParameter("x", clsRFunctionParameter:=clsRfitdist)
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

    Private Sub Display()
        If rdoGeneralCase.Checked Then
            cmdFittingOptions.Visible = True
            cmdDisplayOptions.Visible = True
        ElseIf rdoTest.Checked OrElse rdoEstimate.Checked Then
            cmdFittingOptions.Visible = False
            cmdDisplayOptions.Visible = False
        End If
    End Sub

    Private Sub SetTestsLabelSaveLabelTextPrefix()
        If rdoGeneralCase.Checked Then
            ucrSaveModel.SetCheckBoxText("Save Model")
            ucrSaveModel.SetPrefix("dist")
        ElseIf rdoTest.Checked Then
            lblTests.Text = "Test:"
            ucrSaveModel.SetCheckBoxText("Save Test")
            ucrSaveModel.SetPrefix("test")
        ElseIf rdoEstimate.Checked Then
            lblTests.Text = "Estimate:"
            ucrSaveModel.SetCheckBoxText("Save Estimate")
            ucrSaveModel.SetPrefix("ci")
        End If
    End Sub

    Private Sub ucrPnlGeneralExactCase_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGeneralExactCase.ControlValueChanged
        SetDistributions()
        DataTypeAccepted()
        SetTestsLabelSaveLabelTextPrefix()
        Display()
    End Sub

    Private Sub ucrDistributions_cboDistributionsIndexChanged() Handles ucrDistributionChoice.DistributionsIndexChanged
        ucrSaveModel.SetPrefix(ucrDistributionChoice.clsCurrDistribution.strNameTag)
        SetBaseFunction()
        SetDataParameter()
        PlotResiduals()
        DataTypeAccepted()
        StartParameterValues()
        TestOKEnabled()
    End Sub

    Private Sub cboVariables_TextChanged()
        SetBinomialTest()
    End Sub

    Private Sub ucrChkBinModify_ControlValueChanged(ucrChangedControl As ucrCore)
        SetBinomialTest()
    End Sub

    Private Sub UcrReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariable.ControlValueChanged
        SetBaseFunction()
        PlotResiduals()
        ResponseConvert()
        DataTypeAccepted()
    End Sub

    Private Sub ucrChkConvertVariate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkConvertVariate.ControlValueChanged
        SetDataParameter()
    End Sub

    Private Sub ucrInputTests_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTests.ControlValueChanged
        Select Case ucrInputTests.GetValue
            Case "Binomial"
                ucrBase.clsRsyntax.SetBaseRFunction(clsBionomialFunction)
            Case "Proportion"

        End Select
    End Sub

    Private Sub AllControl_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveModel.ControlContentsChanged, ucrReceiverVariable.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
