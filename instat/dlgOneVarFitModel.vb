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
    Public clsROneVarFitModel, clsFamilyFunction, clsRLogLikFunction, clsRLength, clsRMean, clsRTTest, clsVarTest, clsREnormTest, clsRNonSignTest, clsRWilcoxTest, clsRBinomTest, clsRPoissonTest, clsRplot, clsRfitdist, clsRStartValues, clsRBinomStart, clsRConvertVector, clsRConvertInteger, clsRConvertNumeric As New RFunction
    Public clsRplotFunction, clsRplotPPComp, clsRplotCdfcomp, clsRplotQqComp, clsRplotDenscomp As RFunction
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

        ucrReceiverVariable.SetParameter(New RParameter("x"))
        ucrReceiverVariable.SetParameterIsRFunction()

        ucrChkConvertVariate.SetText("Convert to Numeric")
        ucrChkConvertVariate.AddParameterValueFunctionNamesCondition(True, "data", "as.numeric", True)
        ucrChkConvertVariate.AddParameterValueFunctionNamesCondition(False, "data", frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data", True)

        ucrSaveModel.SetPrefix("dist")
        ucrSaveModel.SetSaveTypeAsModel()
        ucrSaveModel.SetDataFrameSelector(ucrSelectorOneVarFitMod.ucrAvailableDataFrames)
        ucrSaveModel.SetCheckBoxText("Save Model")
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetAssignToIfUncheckedValue("last_model")

        ucrChkBinModify.SetText("Modify Conditions for 'Success'")

        ucrPnlGeneralExactCase.AddRadioButton(rdoGeneralCase)
        ucrPnlGeneralExactCase.AddRadioButton(rdoExactCase)

        ucrPnlGeneralExactCase.AddFunctionNamesCondition(rdoGeneralCase, "fitdist")
        ucrPnlGeneralExactCase.AddFunctionNamesCondition(rdoExactCase, "fitdist", False)

        ucrPnlGeneralExactCase.AddToLinkedControls(ucrPnlStats, {rdoExactCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrNudCI, {rdoExactCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.95)
        ucrNudCI.SetLinkedDisplayControl(lblConfidenceLimit)
        'ucrPnlGeneralExactCase.AddToLinkedControls(ucrNudHyp, {rdoExactCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudHyp.SetLinkedDisplayControl(lblHyp)
        ucrPnlStats.SetLinkedDisplayControl(grpConditions)

        'ucrPnlGeneralExactCase.AddToLinkedControls(ucrPnlStats, {rdoExactCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ' For Exact Option
        ucrNudCI.SetParameter(New RParameter("conf.level", 2))
        ucrNudCI.Increment = 0.05
        ucrNudCI.DecimalPlaces = 2
        ucrNudCI.SetMinMax(0, 1)

        ucrNudHyp.SetParameter(New RParameter("mu", 1)) ' name for wilcox, sign median, t.test
        ucrNudHyp.Increment = 1
        ucrNudHyp.DecimalPlaces = 2
        ucrNudHyp.SetMinMax(0.00, Integer.MaxValue)
        ucrNudHyp.SetLinkedDisplayControl(lblHyp)

        ' Normal tests
        ucrPnlStats.AddRadioButton(rdoMeanNormal)
        ucrPnlStats.AddRadioButton(rdoVarNormal)
        ucrPnlStats.AddRadioButton(rdoEnormNorm)

        ucrPnlStats.AddFunctionNamesCondition(rdoMeanNormal, "t.test")
        ucrPnlStats.AddFunctionNamesCondition(rdoVarNormal, "varTest")
        ucrPnlStats.AddFunctionNamesCondition(rdoEnormNorm, "enorm")

        ' Different default states for each of these radio buttons. enorm also doesn't connect to this option.
        ucrPnlStats.AddToLinkedControls(ucrNudHyp, {rdoMeanNormal, rdoVarNormal}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlStats.AddToLinkedControls(ucrNudHyp, {rdoVarNormal}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)

        ' Non parametric tests
        ucrPnlWilcoxVarTest.AddRadioButton(rdoWilcoxSignTest)
        ucrPnlWilcoxVarTest.AddRadioButton(rdoVarSignTest)
        ucrPnlWilcoxVarTest.AddFunctionNamesCondition(rdoWilcoxSignTest, "wilcox.test")
        ucrPnlWilcoxVarTest.AddFunctionNamesCondition(rdoVarSignTest, "signmedian.test")

        ucrPnlWilcoxVarTest.AddToLinkedControls(ucrNudHyp, {rdoWilcoxSignTest, rdoVarSignTest}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

        ' to move
        ucrOperator.SetItems({"==", "<", "<=", ">", ">=", "!="})
        dctucrOperator.Add("(==)", "==")
        dctucrOperator.Add("<", "<")
        dctucrOperator.Add("(<=)", "<=")
        dctucrOperator.Add("(>)", ">")
        dctucrOperator.Add("(>=)", ">=")
        dctucrOperator.Add("(!=)", "!=")

        'Disabled for now
        'rdoExactCase.Enabled = False
        'ucrOperator.SetItems(dctucrOperator)
        ' ucrVariables.SetItemsTypeAsColumns()    'we want SetItemsTypeAs factors in the column

        'temp disabled as only works for numeric columns currently
        '.Enabled = False
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

        clsFamilyFunction = ucrDistributionChoice.clsCurrRFunction
        clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertInteger)

        'Exact Case
        'TTest
        clsRTTest.SetPackageName("stats")
        clsRTTest.SetRCommand("t.test")
        clsRTTest.AddParameter("x", clsRFunctionParameter:=clsRConvertVector, iPosition:=0)
        clsRTTest.AddParameter("mu", 0, iPosition:=1)

        'VarTest
        clsVarTest.SetPackageName("EnvStats")
        clsVarTest.SetRCommand("varTest")
        clsVarTest.AddParameter("x", clsRFunctionParameter:=clsRConvertVector, iPosition:=0)
        clsVarTest.AddParameter("sigma.squared", 1, iPosition:=1)

        'Enorm
        clsREnormTest.SetPackageName("EnvStats")
        clsREnormTest.SetRCommand("enorm")
        clsREnormTest.AddParameter("x", clsRFunctionParameter:=clsRConvertVector, iPosition:=0)

        ' Non-Parametric tests
        clsRWilcoxTest.SetPackageName("stats")
        clsRWilcoxTest.SetRCommand("wilcox.test")
        clsRWilcoxTest.AddParameter("mu", 0, iPosition:=1)

        clsRNonSignTest.SetPackageName("signmedian.test")
        clsRNonSignTest.SetRCommand("signmedian.test")
        clsRNonSignTest.AddParameter("mu", 0, iPosition:=1)





        clsRPoissonTest.SetPackageName("stats")
        clsRPoissonTest.SetRCommand("poisson.test")

        clsRLength.SetPackageName("base")
        clsRLength.SetRCommand("length")

        clsRMean.SetPackageName("base")
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

        SetDataParameter()
        EnableOptions()
        BinomialConditions()
        SetBaseFunction()
        SetDistributions()

        clsROneVarFitModel.SetAssignTo("last_model", strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model")
        clsRLogLikFunction.SetAssignTo("last_likelihood", strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_likelihood")
        clsRplotFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsROneVarFitModel)

        clsRplotFunction.AddParameter("x", clsRFunctionParameter:=clsROneVarFitModel)
        ucrBase.clsRsyntax.AddToAfterCodes(clsRplotFunction, iPosition:=1)
        ucrBase.clsRsyntax.AddToAfterCodes(clsRLogLikFunction, iPosition:=2)
        bResetFittingOptions = True
        bResetFitModDisplay = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRConvertNumeric, New RParameter("x"), iAdditionalPairNo:=1)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRConvertInteger, New RParameter("x"), iAdditionalPairNo:=2)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRStartValues, New RParameter("x"), iAdditionalPairNo:=3)

        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRWilcoxTest, New RParameter("x"), iAdditionalPairNo:=4) ' I think I want this converted not this itself?
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRNonSignTest, New RParameter("x"), iAdditionalPairNo:=5)
        'ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRLength, New RParameter("x"), iAdditionalPairNo:=5)
        'ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRMean, New RParameter("x"), iAdditionalPairNo:=6)
        'ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRBinomTest, New RParameter("x"), iAdditionalPairNo:=7)

        ucrNudHyp.AddAdditionalCodeParameterPair(clsVarTest, New RParameter("sigma.squared", 1), iAdditionalPairNo:=1)
        ucrNudHyp.AddAdditionalCodeParameterPair(clsRWilcoxTest, ucrNudHyp.GetParameter(), iAdditionalPairNo:=2)
        ucrNudHyp.AddAdditionalCodeParameterPair(clsRNonSignTest, ucrNudHyp.GetParameter(), iAdditionalPairNo:=3)
        'ucrNudHyp.AddAdditionalCodeParameterPair(clsRBinomTest, New RParameter("p"), iAdditionalPairNo:=6)
        'ucrNudHyp.AddAdditionalCodeParameterPair(clsRPoissonTest, New RParameter("r"), iAdditionalPairNo:=7)
        ' ucrNudHyp.AddAdditionalCodeParameterPair(clsRPoissonTest, New RParameter("sigma.squared"), iAdditionalPairNo:=8)

        ucrNudCI.AddAdditionalCodeParameterPair(clsRTTest, ucrNudCI.GetParameter(), iAdditionalPairNo:=1)
        ucrNudCI.AddAdditionalCodeParameterPair(clsVarTest, ucrNudCI.GetParameter(), iAdditionalPairNo:=2)
        ucrNudCI.AddAdditionalCodeParameterPair(clsREnormTest, ucrNudCI.GetParameter(), iAdditionalPairNo:=3)
        ucrNudCI.AddAdditionalCodeParameterPair(clsRWilcoxTest, ucrNudCI.GetParameter(), iAdditionalPairNo:=4)
        ucrNudCI.AddAdditionalCodeParameterPair(clsRNonSignTest, ucrNudCI.GetParameter(), iAdditionalPairNo:=5)
        'ucrNudCI.AddAdditionalCodeParameterPair(clsRBinomTest, New RParameter("conf.level"), iAdditionalPairNo:=6)
        '  ucrNudCI.AddAdditionalCodeParameterPair(clsRPoissonTest, New RParameter("conf.level"), iAdditionalPairNo:=6)

        ucrPnlGeneralExactCase.SetRCode(clsROneVarFitModel, bReset)
        ucrPnlStats.SetRCode(clsRTTest, bReset)
        ucrPnlWilcoxVarTest.SetRCode(clsRWilcoxTest, bReset)
        ucrReceiverVariable.SetRCode(clsRConvertVector, bReset)
        ucrChkConvertVariate.SetRCode(clsROneVarFitModel, bReset)

        ucrNudHyp.SetRCode(clsRTTest, bReset)
        ucrDistributionChoice.SetRCode(clsFamilyFunction, bReset)
        ucrSaveModel.SetRCode(clsROneVarFitModel, bReset)
        bRCodeSet = True
    End Sub

    Private Sub ucrPnlStats_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStats.ControlValueChanged
        SetBaseFunction()
        Display()
    End Sub

    Private Sub ucrPnlWilcoxVarTest_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlWilcoxVarTest.ControlValueChanged
        SetBaseFunction()
        Display()
    End Sub

    Private Sub SetDistributions()
        If rdoGeneralCase.Checked Then
            ucrDistributionChoice.SetAllDistributions()
        ElseIf rdoExactCase.Checked Then
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
                clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertNumeric)
            Else
                'TODO This is needed because fitdist checks is.vector on data which is FALSE when data has attributes
                If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Poisson" OrElse ucrDistributionChoice.clsCurrDistribution.strNameTag = "Geometric" Then
                    clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertInteger)
                Else
                    clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertVector)
                End If
                If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Extreme_Value" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Binomial" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Bernouli" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Students_t" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Chi_Square" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "F" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Hypergeometric" Then
                    clsROneVarFitModel.AddParameter("start", clsRFunctionParameter:=clsRStartValues)
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
        If rdoGeneralCase.Checked Then
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
                        clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertNumeric)
                    Else
                        'TODO This is needed because fitdist checks is.vector on data which is FALSE when data has attributes
                        If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Poisson" OrElse ucrDistributionChoice.clsCurrDistribution.strNameTag = "Geometric" Then
                            clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertInteger)
                        Else
                            clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertVector)
                        End If
                        If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Extreme_Value" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Binomial" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Bernouli" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Students_t" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Chi_Square" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "F" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Hypergeometric" Then
                            clsROneVarFitModel.AddParameter("start", clsRFunctionParameter:=clsRStartValues)
                            ' TODO llplot() no longer works with starting values. However, the mle's will not plot without starting values for these variables
                        End If
                    End If
                Else
                    ucrChkConvertVariate.Visible = False
                End If
                TestOKEnabled()
            End If
        End If
    End Sub

    Public Sub SetBaseFunction()
        SetDataParameter()
        If rdoGeneralCase.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsROneVarFitModel)
            clsROneVarFitModel.AddParameter("distr", Chr(34) & ucrDistributionChoice.clsCurrDistribution.strRName & Chr(34))
            clsRplotPPComp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
            clsRplotPPComp.AddParameter("ft", clsRFunctionParameter:=clsROneVarFitModel)
            clsRplotCdfcomp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
            clsRplotCdfcomp.AddParameter("ft", clsRFunctionParameter:=clsROneVarFitModel)
            clsRplotQqComp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
            clsRplotQqComp.AddParameter("ft", clsRFunctionParameter:=clsROneVarFitModel)
            clsRplotDenscomp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
            clsRplotDenscomp.AddParameter("ft", clsRFunctionParameter:=clsROneVarFitModel)
            clsRLogLikFunction.AddParameter("mlefit", clsRFunctionParameter:=clsROneVarFitModel)
        ElseIf rdoExactCase.Checked Then
            If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Poisson" Then
                grpVarAndWilcoxSign.Hide()
                grpVarAndWilcox.Hide()
                If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Poisson" AndAlso (ucrReceiverVariable.strCurrDataType = "factor" OrElse ucrReceiverVariable.strCurrDataType = "character") Then
                    ucrReceiverVariable.Clear()
                End If
                clsRPoissonTest.AddParameter("T", clsRFunctionParameter:=clsRMean)
                clsRPoissonTest.AddParameter("x", clsRFunctionParameter:=clsRLength)
                ucrBase.clsRsyntax.SetBaseRFunction(clsRPoissonTest)
            ElseIf ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal" Then
                grpVarAndWilcox.Show()
                grpVarAndWilcoxSign.Hide()
                If rdoExactCase.Checked Then
                    If rdoMeanNormal.Checked Then
                        ucrNudHyp.SetMinMax(0.00, 1)
                        'clsRTTest.AddParameter("x", clsRFunctionParameter:=clsRConvertVector)
                        ucrBase.clsRsyntax.SetBaseRFunction(clsRTTest)
                    ElseIf rdoEnormNorm.Checked Then
                        ucrNudHyp.SetMinMax(0.01, Integer.MaxValue)
                        'ucrNudHyp.Value = 0.00
                        'clsREnormTest.AddParameter("x", clsRFunctionParameter:=clsRConvertVector)
                        ucrBase.clsRsyntax.SetBaseRFunction(clsREnormTest)
                    Else
                        ucrNudHyp.SetMinMax(0.00, Integer.MaxValue)
                        'ucrNudHyp.Value = 1.0
                        'clsVarTest.AddParameter("x", clsRFunctionParameter:=clsRConvertVector)
                        ucrBase.clsRsyntax.SetBaseRFunction(clsVarTest)
                    End If
                End If
            ElseIf ucrDistributionChoice.clsCurrDistribution.strNameTag = "Bernouli" Then
                grpVarAndWilcoxSign.Hide()
                grpVarAndWilcox.Hide()
                SetBinomialTest()
            Else
                grpVarAndWilcox.Hide()
                grpVarAndWilcoxSign.Show()
                If rdoWilcoxSignTest.Checked Then
                    '    clsRWilcoxTest.AddParameter("x", clsRFunctionParameter:=clsRConvertVector)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsRWilcoxTest)
                Else
                    '    clsRNonSignTest.AddParameter("x", clsRFunctionParameter:=clsRConvertVector)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsRNonSignTest)
                End If
            End If
        End If
    End Sub

    Public Sub DataTypeAccepted()
        If rdoGeneralCase.Checked Then
            ucrReceiverVariable.SetIncludedDataTypes({"integer", "numeric", "character", "factor"})
        ElseIf rdoExactCase.Checked Then
            If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Poisson" Then
                ucrReceiverVariable.SetIncludedDataTypes({"integer", "numeric"})
                If (ucrReceiverVariable.strCurrDataType = "factor" OrElse ucrReceiverVariable.strCurrDataType = "character") Then
                    ucrReceiverVariable.Clear()
                End If
            Else
                ucrReceiverVariable.SetIncludedDataTypes({"integer", "numeric", "character", "factor"})
            End If
        End If
    End Sub


    Private Sub SetBinomialTest()
        If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Binomial" Then
            ucrReceiverVariable.SetDataType(strTemp:="integer" OrElse "numeric" OrElse "character" OrElse "factor")
        End If
        If ucrChkBinModify.Checked Then
            If ucrReceiverVariable.strCurrDataType = "factor" OrElse ucrReceiverVariable.strCurrDataType = "character" Then
                clsFactorOperator.SetOperation("==")
                clsFactorOperator.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrReceiverVariable.GetVariables())
                clsFactorOperator.AddParameter(strParameterValue:=ucrVariables.GetText())
                clsRBinomTest.AddParameter("x", clsROperatorParameter:=clsFactorOperator)
            Else
                clsFunctionOperator.SetOperation(ucrOperator.GetText())
                clsFunctionOperator.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrReceiverVariable.GetVariables())
                clsFunctionOperator.AddParameter(strParameterValue:=ucrNudBinomialConditions.Value.ToString())
                clsRBinomTest.AddParameter("x", clsROperatorParameter:=clsFunctionOperator)
            End If
        Else
            clsRBinomTest.AddParameter("x", clsRFunctionParameter:=ucrReceiverVariable.GetVariables())
        End If
        ucrBase.clsRsyntax.SetBaseRFunction(clsRBinomTest)
    End Sub

    Private Sub PlotResiduals()
        clsRplot.AddParameter("x", clsRFunctionParameter:=clsRfitdist)
        clsRfitdist.AddParameter("distr", Chr(34) & ucrDistributionChoice.clsCurrDistribution.strRName & Chr(34))
        If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Poisson" Then
            clsRConvertInteger.SetRCommand("as.integer")
            clsRfitdist.AddParameter("data", clsRFunctionParameter:=clsRConvertInteger)
        Else
            clsRConvertVector.SetRCommand("as.vector")
            clsRfitdist.AddParameter("data", clsRFunctionParameter:=clsRConvertVector)
        End If
        If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Bernouli" Then
            clsRBinomStart.SetRCommand("mean")
            clsRfitdist.AddParameter("start", clsRFunctionParameter:=clsRBinomStart)
        End If
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgOneVarFitModDisplay.SetRCode(ucrBase.clsRsyntax, clsRNewOneVarFitModel:=clsROneVarFitModel, clsNewRLogLikFunction:=clsRLogLikFunction, clsNewRplotFunction:=clsRplotFunction, clsNewRplotPPComp:=clsRplotPPComp, clsNewRplotCdfcomp:=clsRplotCdfcomp, clsNewRplotQqComp:=clsRplotQqComp, clsNewRplotDenscomp:=clsRplotDenscomp, ucrNewDistribution:=ucrDistribution, bReset:=bResetFitModDisplay)
        bResetFitModDisplay = False
        sdgOneVarFitModDisplay.ShowDialog()
        EnableOptions()
        TestOKEnabled()
    End Sub

    Private Sub cmdFittingOptions_Click(sender As Object, e As EventArgs) Handles cmdFittingOptions.Click
        sdgOneVarFitModel.SetRCode(ucrBase.clsRsyntax, clsROneVarFitModel, clsNewRLogLikFunction:=clsRLogLikFunction, ucrNewDistribution:=ucrDistribution, bReset:=bResetFittingOptions)
        bResetFittingOptions = False
        sdgOneVarFitModel.ShowDialog()
        EnableOptions()
        TestOKEnabled()
    End Sub

    Private Sub EnableOptions()
        If Not ucrReceiverVariable.IsEmpty AndAlso rdoGeneralCase.Checked Then
            cmdFittingOptions.Visible = True
            cmdDisplayOptions.Visible = True
        Else
            cmdFittingOptions.Visible = False
            cmdDisplayOptions.Visible = False
        End If
    End Sub

    'Private Sub UcrBase_ClickOk(sender As Object, e As EventArgs) Handles UcrBase.ClickOk
    '    If rdoGeneralCase.Checked Then
    '    ElseIf rdoExactCase.Checked Then
    '        If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal" OrElse ucrDistributionChoice.clsCurrDistribution.strNameTag = "Poisson" Then ' can remove this line once Bernouli residual plots are working
    '            PlotResiduals()
    '        End If
    '    End If
    'End Sub

    Private Sub Display()
        If rdoGeneralCase.Checked Then
            cmdFittingOptions.Visible = True
            cmdDisplayOptions.Visible = True
            grpConditions.Visible = False
            rdoMeanNormal.Visible = False ' only visible if normal is selected and if rdoExact is chosen
            rdoVarNormal.Visible = False ' only visible if normal is selected and if rdoExact is chosen
            rdoEnormNorm.Visible = False ' only visible if normal is selected and if rdoExact is chosen
            grpVarAndWilcoxSign.Hide()
        ElseIf rdoExactCase.Checked Then
            ucrChkConvertVariate.Visible = False
            grpConditions.Visible = True
            If ucrDistributionChoice.clsCurrDistribution.bIsExact = True Then
                If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal" Then
                    grpVarAndWilcoxSign.Hide()
                    grpVarAndWilcox.Show()
                    rdoMeanNormal.Visible = True
                    rdoVarNormal.Visible = True
                    rdoEnormNorm.Visible = True
                    If rdoVarNormal.Checked Then
                        ucrNudHyp.SetMinMax(0.01, 1)
                    Else
                        ucrNudHyp.SetMinMax(ucrDistributionChoice.clsCurrDistribution.lstExact(5), ucrNudHyp.Value = ucrDistributionChoice.clsCurrDistribution.lstExact(2))
                    End If

                ElseIf ucrDistributionChoice.clsCurrDistribution.strNameTag = "No_Distribution" Then
                    grpVarAndWilcox.Hide()
                    grpVarAndWilcoxSign.Show()
                    ucrNudHyp.Minimum = ucrDistributionChoice.clsCurrDistribution.lstExact(5)
                    ucrNudHyp.Value = ucrDistributionChoice.clsCurrDistribution.lstExact(2)

                Else
                    ucrNudHyp.Minimum = ucrDistributionChoice.clsCurrDistribution.lstExact(5)
                    ucrNudHyp.Value = ucrDistributionChoice.clsCurrDistribution.lstExact(2)
                    'grpVarAndWilcoxSign.Hide()
                    ' grpVarAndWilcox.Hide()
                    'rdoMeanWilcox.Visible = False
                    ' rdoVarSign.Visible = False
                    ' rdoEnorm.Visible = False
                End If
                ucrNudHyp.Increment = ucrDistributionChoice.clsCurrDistribution.lstExact(3)
                ucrNudHyp.DecimalPlaces = ucrDistributionChoice.clsCurrDistribution.lstExact(4)
                ucrNudHyp.Maximum = ucrDistributionChoice.clsCurrDistribution.lstExact(6)
            End If
        End If
    End Sub

    Private Sub ucrPnlGeneralExactCase_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGeneralExactCase.ControlValueChanged
        EnableOptions()
        BinomialConditions()
        SetDistributions()
        DataTypeAccepted()
        ResponseConvert()
        Display()
    End Sub

    Private Sub ucrDistributions_cboDistributionsIndexChanged() Handles ucrDistributionChoice.DistributionsIndexChanged
        SetBaseFunction()
        BinomialConditions()
        SetDataParameter()
        PlotResiduals()
        DataTypeAccepted()
        TestOKEnabled()
        Display()
    End Sub

    Private Sub lbls_VisibleChanged(sender As Object, e As EventArgs) Handles lblEquals.VisibleChanged, lblSuccessIf.VisibleChanged
        BinomialConditions()
    End Sub

    Private Sub BinomialConditions()
        If rdoExactCase.Checked AndAlso ucrDistributionChoice.clsCurrDistribution.strNameTag = "Bernouli" Then
            'ucrChkBinModify.Enabled = True
            ucrChkBinModify.Visible = True
            If ucrChkBinModify.Checked Then
                lblSuccessIf.Visible = True
                If ucrReceiverVariable.strCurrDataType = "factor" Then
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

    Private Sub cboVariables_TextChanged() Handles ucrVariables.NameChanged
        BinomialConditions()
        SetBinomialTest()
    End Sub

    Private Sub AllControl_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveModel.ControlContentsChanged, ucrReceiverVariable.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkBinModify_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBinModify.ControlValueChanged
        SetBinomialTest()
        BinomialConditions()
    End Sub

    Private Sub UcrReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariable.ControlValueChanged
        SetBaseFunction()
        EnableOptions()
        PlotResiduals()
        ResponseConvert()
        DataTypeAccepted()
    End Sub

    Private Sub ucrChkConvertVariate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkConvertVariate.ControlValueChanged
        SetDataParameter()
    End Sub
End Class
