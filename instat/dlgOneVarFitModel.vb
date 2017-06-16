' Instat-R
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
    Public clsROneVarFitModel, clsRLength, clsRMean, clsRTTest, clsVarTest, clsREnormTest, clsRNonSignTest, clsRWilcoxTest, clsRBinomTest, clsRPoissonTest, clsRplot, clsRfitdist, clsRStartValues, clsRBinomStart, clsRConvertVector, clsRConvertInteger, clsRConvertNumeric As New RFunction
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
        sdgOneVarFitModDisplay.InitialiseDialog()
        sdgOneVarFitModel.InitialiseDialog()

        UcrReceiver.Selector = ucrSelectorOneVarFitMod
        UcrReceiver.SetMeAsReceiver()

        ucrSaveModel.SetPrefix("dist")
        ucrSaveModel.SetSaveTypeAsModel()
        ucrSaveModel.SetDataFrameSelector(ucrSelectorOneVarFitMod.ucrAvailableDataFrames)
        ucrSaveModel.SetCheckBoxText("Save Model")
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetAssignToIfUncheckedValue("last_model")


        sdgOneVarFitModDisplay.SetModelFunction(clsROneVarFitModel)
        sdgOneVarFitModel.SetMyRFunction(clsROneVarFitModel)
        sdgOneVarFitModDisplay.SetDistribution(ucrFamily)
        sdgOneVarFitModel.SetDistribution(ucrFamily)

        ucrPnlGeneralExactCase.AddRadioButton(rdoGeneralCase)
        ucrPnlGeneralExactCase.AddRadioButton(rdoExactCase)

        ucrPnlStats.AddRadioButton(rdoEnorm)
        ucrPnlStats.AddRadioButton(rdoMeanWilcox)
        ucrPnlStats.AddRadioButton(rdoVarSign)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrPnlStats, {rdoExactCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrNudCI, {rdoExactCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudCI.SetLinkedDisplayControl(lblConfidenceLimit)
        ucrPnlGeneralExactCase.AddToLinkedControls(ucrNudHyp, {rdoExactCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudHyp.SetLinkedDisplayControl(lblHyp)
        ucrPnlStats.SetLinkedDisplayControl(grpConditions)

        ucrNudCI.Increment = 0.05
        ucrNudCI.DecimalPlaces = 2
        ucrNudCI.SetMinMax(0, 1)

        ucrNudHyp.DecimalPlaces = 2

        ucrOperator.SetItems({"==", "<", "<=", ">", ">=", "!="})
        dctucrOperator.Add("Equal to(==)", "==")
        ucrVariables.SetItemsTypeAsColumns()    'we want SetItemsTypeAs factors in the column
        ' rdoMeanWilcox.Checked = True

        'temp disabled as only works for numeric columns currently
        '.Enabled = False
    End Sub

    Private Sub SetDefaults()
        ucrSelectorOneVarFitMod.Reset()
        ucrSelectorOneVarFitMod.Focus()
        ucrOperator.SetName("==")
        clsROneVarFitModel.SetPackageName("fitdistrplus")
        clsROneVarFitModel.SetRCommand("fitdist")

        ucrNudCI.Value = 0.95
        BinomialConditions()
        ucrSaveModel.Reset()
        SetDataParameter()
        EnableOptions()
        sdgOneVarFitModDisplay.SetDefaults()
        sdgOneVarFitModel.SetDefaults()
        SetBaseFunction()
        rdoGeneralCase.Checked = True
        clsROneVarFitModel.SetAssignTo("last_model", strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_model")
        UcrBase.clsRsyntax.SetBaseRFunction(clsROneVarFitModel)
        SetDistributions()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlGeneralExactCase.SetRCode(clsROneVarFitModel, bReset)
        UcrReceiver.AddAdditionalCodeParameterPair()
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
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles UcrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Public Sub SetDataParameter()
        If Not UcrReceiver.IsEmpty Then
            If UcrReceiver.strCurrDataType = "numeric" OrElse UcrReceiver.strCurrDataType = "integer" Then
                chkConvertToVariate.Checked = False
                chkConvertToVariate.Visible = False
            Else
                chkConvertToVariate.Visible = True
                chkConvertToVariate.Checked = True
            End If
            If chkConvertToVariate.Checked Then
                clsRConvertNumeric.SetPackageName("base")
                clsRConvertNumeric.SetRCommand("as.numeric")
                clsRConvertNumeric.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
                UcrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=clsRConvertNumeric)
            Else
                'TODO This is needed because fitdist checks is.vector on data which is FALSE when data has attributes
                If ucrFamily.clsCurrDistribution.strNameTag = "Poisson" OrElse ucrFamily.clsCurrDistribution.strNameTag = "Geometric" Then
                    clsRConvertInteger.SetPackageName("base")
                    clsRConvertInteger.SetRCommand("as.integer")
                    clsRConvertInteger.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
                    clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertInteger)
                Else
                    clsRConvertVector.SetPackageName("base")
                    clsRConvertVector.SetRCommand("as.vector")
                    clsRConvertVector.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
                    clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvertVector)
                End If
                If ucrFamily.clsCurrDistribution.strNameTag = "Extreme_Value" Or ucrFamily.clsCurrDistribution.strNameTag = "Binomial" Or ucrFamily.clsCurrDistribution.strNameTag = "Bernouli" Or ucrFamily.clsCurrDistribution.strNameTag = "Students_t" Or ucrFamily.clsCurrDistribution.strNameTag = "Chi_Square" Or ucrFamily.clsCurrDistribution.strNameTag = "F" Or ucrFamily.clsCurrDistribution.strNameTag = "Hypergeometric" Then
                    clsROneVarFitModel.AddParameter("start", clsRFunctionParameter:=clsRStartValues)
                    clsRStartValues.SetPackageName("base")
                    clsRStartValues.SetRCommand("mean")
                    clsRStartValues.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
                    ' TODO llplot() no longer works with starting values. However, the mle's will not plot without starting values for these variables
                End If
            End If
        Else
            chkConvertToVariate.Visible = False
            UcrBase.clsRsyntax.RemoveParameter("data")
        End If
    End Sub

    Public Sub SetBaseFunction()
        clsROneVarFitModel.ClearParameters()
        clsRPoissonTest.ClearParameters()
        clsRBinomTest.ClearParameters()
        clsRTTest.ClearParameters()
        clsRStartValues.ClearParameters()
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
        UcrBase.clsRsyntax.SetBaseRFunction(clsROneVarFitModel)
        clsROneVarFitModel.AddParameter("distr", Chr(34) & ucrFamily.clsCurrDistribution.strRName & Chr(34))
        SetDataParameter()
    End Sub

    Private Sub SetTTest()
        clsRTTest.SetPackageName("base")
        clsRTTest.SetRCommand("t.test")
        UcrBase.clsRsyntax.SetBaseRFunction(clsRTTest)
        clsRConvertVector.SetRCommand("as.vector")
        clsRConvertVector.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
        clsRTTest.AddParameter("x", clsRFunctionParameter:=clsRConvertVector)
        clsRTTest.AddParameter("mu", ucrNudHyp.Value.ToString)
        clsRTTest.AddParameter("conf.level", ucrNudCI.Value.ToString)
    End Sub

    Private Sub SetVarTest()
        clsVarTest.SetPackageName("EnvStats")
        clsVarTest.SetRCommand("varTest")
        UcrBase.clsRsyntax.SetBaseRFunction(clsVarTest)
        clsRConvertVector.SetPackageName("base")
        clsRConvertVector.SetRCommand("as.vector")
        clsRConvertVector.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
        clsVarTest.AddParameter("x", clsRFunctionParameter:=clsRConvertVector)
        clsVarTest.AddParameter("sigma.squared", ucrNudHyp.Value.ToString)
        clsVarTest.AddParameter("conf.level", ucrNudCI.Value.ToString)
    End Sub

    Private Sub SetEnormTest()
        clsREnormTest.SetPackageName("EnvStats")
        clsREnormTest.SetRCommand("enorm")
        UcrBase.clsRsyntax.SetBaseRFunction(clsREnormTest)
        clsRConvertVector.SetPackageName("base")
        clsRConvertVector.SetRCommand("as.vector")
        clsRConvertVector.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
        clsREnormTest.AddParameter("x", clsRFunctionParameter:=clsRConvertVector)
        clsREnormTest.AddParameter("conf.level", ucrNudCI.Value.ToString)
        ' what is the hyp nud?
    End Sub

    Private Sub SetWilcoxTest()
        clsRWilcoxTest.SetPackageName("stats")
        clsRWilcoxTest.SetRCommand("wilcox.test")
        UcrBase.clsRsyntax.SetBaseRFunction(clsRWilcoxTest)
        'clsRConvert.SetPackageName("base")
        'clsRConvert.SetRCommand("as.vector")
        'clsRConvert.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
        'clsRWilcoxTest.AddParameter("x", clsRFunctionParameter:=clsRConvert)
        clsRWilcoxTest.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
        clsRWilcoxTest.AddParameter("conf.level", ucrNudCI.Value.ToString)
        clsRWilcoxTest.AddParameter("mu", ucrNudHyp.Value.ToString)
    End Sub

    Private Sub SetNonSignTest()
        clsRNonSignTest.SetPackageName("signmedian.test")
        clsRNonSignTest.SetRCommand("signmedian.test")
        UcrBase.clsRsyntax.SetBaseRFunction(clsRNonSignTest)
        clsRNonSignTest.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
        clsRNonSignTest.AddParameter("conf.level", ucrNudCI.Value.ToString)
        clsRNonSignTest.AddParameter("mu", ucrNudCI.Value.ToString)
    End Sub

    Private Sub SetPoissonTest()
        If ucrFamily.clsCurrDistribution.strNameTag = "Poisson" AndAlso (UcrReceiver.strCurrDataType = "factor" OrElse UcrReceiver.strCurrDataType = "character") Then
            UcrReceiver.Clear()
        End If
        clsRPoissonTest.SetPackageName("stats")
        clsRPoissonTest.SetRCommand("poisson.test")
        UcrBase.clsRsyntax.SetBaseRFunction(clsRPoissonTest)
        clsRPoissonTest.AddParameter("r", ucrNudHyp.Value.ToString)
        clsRPoissonTest.AddParameter("conf.level", ucrNudCI.Value.ToString)
        clsRPoissonTest.AddParameter("T", clsRFunctionParameter:=clsRMean)
        clsRPoissonTest.AddParameter("x", clsRFunctionParameter:=clsRLength)
        clsRLength.SetPackageName("base")
        clsRLength.SetRCommand("length")
        clsRLength.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
        clsRMean.SetPackageName("base")
        clsRMean.SetRCommand("mean")
        clsRMean.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
    End Sub

    Private Sub SetBinomialTest()
        If ucrFamily.clsCurrDistribution.strNameTag = "Binomial" Then
            UcrReceiver.SetDataType(strTemp:="integer" OrElse "numeric" OrElse "character" OrElse "factor")
        End If
        clsRBinomTest.SetPackageName("stats")
        clsRBinomTest.SetRCommand("binom.test")
        UcrBase.clsRsyntax.SetBaseRFunction(clsRBinomTest)
        clsRBinomTest.AddParameter("p", ucrNudHyp.Value.ToString)
        clsRBinomTest.AddParameter("conf.level", ucrNudCI.Value.ToString)
        If chkBinModify.Checked Then
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
        clsRplot.SetPackageName("graphics")
        clsRplot.SetRCommand("plot")
        clsRplot.AddParameter("x", clsRFunctionParameter:=clsRfitdist)
        clsRfitdist.SetPackageName("fitdistrplus")
        clsRfitdist.SetRCommand("fitdist")
        clsRfitdist.AddParameter("distr", Chr(34) & ucrFamily.clsCurrDistribution.strRName & Chr(34))
        If ucrFamily.clsCurrDistribution.strNameTag = "Poisson" Then
            clsRConvertInteger.SetPackageName("base")
            clsRConvertInteger.SetRCommand("as.integer")
            clsRConvertInteger.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
            clsRfitdist.AddParameter("data", clsRFunctionParameter:=clsRConvertInteger)
        Else
            clsRConvertVector.SetPackageName("base")
            clsRConvertVector.SetRCommand("as.vector")
            clsRConvertVector.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
            clsRfitdist.AddParameter("data", clsRFunctionParameter:=clsRConvertVector)
        End If
        If ucrFamily.clsCurrDistribution.strNameTag = "Bernouli" Then
            clsRfitdist.AddParameter("start", clsRFunctionParameter:=clsRBinomStart)
            clsRBinomStart.SetPackageName("base")
            clsRBinomStart.SetRCommand("mean")
            clsRBinomStart.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
        End If
    End Sub

    Private Sub UcrReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles UcrReceiver.SelectionChanged
        SetBaseFunction()
        EnableOptions()
        PlotResiduals()
        DataTypeAccepted()
    End Sub

    Private Sub cmdFittingOptions_Click(sender As Object, e As EventArgs) Handles cmdFittingOptions.Click
        sdgOneVarFitModel.ShowDialog()
        EnableOptions()
        Display()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgOneVarFitModDisplay.ShowDialog()
        Display()
        EnableOptions()
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

    Private Sub chkConvertToVariate_CheckedChanged(sender As Object, e As EventArgs) Handles chkConvertToVariate.CheckedChanged
        SetDataParameter()
        Display()
    End Sub

    Private Sub UcrBase_ClickOk(sender As Object, e As EventArgs) Handles UcrBase.ClickOk
        If rdoGeneralCase.Checked Then
            sdgOneVarFitModDisplay.CreateGraphs()
            If sdgOneVarFitModel.rdoMle.Checked AndAlso (sdgOneVarFitModDisplay.rdoLoglik.Checked Or sdgOneVarFitModDisplay.rdoLik.Checked) Then
                sdgOneVarFitModDisplay.RunLikelihoods()
            End If
        ElseIf rdoExactCase.Checked Then
            If ucrFamily.clsCurrDistribution.strNameTag = "Normal" OrElse ucrFamily.clsCurrDistribution.strNameTag = "Poisson" Then ' can remove this line once Bernouli residual plots are working
                PlotResiduals()
                frmMain.clsRLink.RunScript(clsRplot.ToScript(), 3)
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
            chkConvertToVariate.Visible = False
            grpConditions.Visible = True
            If ucrFamily.clsCurrDistribution.bIsExact = True Then
                If ucrFamily.clsCurrDistribution.strNameTag = "Normal" Then
                    rdoMeanWilcox.Visible = True
                    rdoVarSign.Visible = True
                    rdoEnorm.Visible = True
                    rdoMeanWilcox.Text = "Compare Mean"
                    rdoVarSign.Text = "Compare Variance"
                    If rdoVarSign.Checked Then
                        ucrNudHyp.Minimum = 0.01
                        ucrNudHyp.Value = 1
                    Else
                        ucrNudHyp.Minimum = ucrFamily.clsCurrDistribution.lstExact(5)
                        ucrNudHyp.Value = ucrFamily.clsCurrDistribution.lstExact(2)
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

    Private Sub ucrDistributions_cboDistributionsIndexChanged() Handles ucrFamily.DistributionsIndexChanged, ucrFamily.DistributionsIndexChanged
        SetBaseFunction()
        BinomialConditions()
        SetDataParameter()
        PlotResiduals()
        DataTypeAccepted()
    End Sub

    Private Sub lbls_VisibleChanged(sender As Object, e As EventArgs) Handles lblEquals.VisibleChanged, lblSuccessIf.VisibleChanged, lblHyp.VisibleChanged, lblConfidenceLimit.VisibleChanged
        BinomialConditions()
    End Sub

    Private Sub chkBinModify_CheckedChanged(sender As Object, e As EventArgs) Handles chkBinModify.CheckedChanged
        BinomialConditions()
        SetBinomialTest()
    End Sub

    Private Sub BinomialConditions()
        If rdoExactCase.Checked AndAlso ucrFamily.clsCurrDistribution.strNameTag = "Bernouli" Then
            chkBinModify.Visible = True
            If chkBinModify.Checked Then
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
            chkBinModify.Visible = False
            chkBinModify.Checked = False
            lblSuccessIf.Visible = False
            lblEquals.Visible = False
            ucrNudBinomialConditions.Visible = False
            ucrOperator.Visible = False
            ucrVariables.Visible = False
        End If
        ucrNudBinomialConditions.Value = 1
        ucrNudBinomialConditions.Maximum = Integer.MaxValue
        ucrNudBinomialConditions.Minimum = Integer.MinValue
        Display()
    End Sub

    Private Sub ucrNudBinomialConditions_ValueChanged(sender As Object, e As EventArgs)
        SetBinomialTest()
    End Sub

    Private Sub cboVariables_TextChanged() Handles ucrVariables.NameChanged
        BinomialConditions()
        SetBinomialTest()
    End Sub

    Private Sub rdoMean_VisibleChanged(sender As Object, e As EventArgs)
        Display()
        SetBaseFunction()

    End Sub


End Class
