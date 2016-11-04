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

Imports instat.Translations

Public Class dlgOneVarFitModel
    Public clsRConvert, clsROneVarFitModel, clsRLength, clsRMean, clsRTTest, clsRBinomTest, clsRPoissonTest, clsRplot, clsRfitdist, clsRStartValues, clsRBinomStart As New RFunction
    Public clsFunctionOperator, clsFactorOperator As New ROperator
    Public bfirstload As Boolean = True

    Private Sub dlgOneVarFitModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bfirstload Then
            InitialiseDialog()
            SetDefaults()
            bfirstload = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        sdgOneVarFitModDisplay.InitialiseDialog()
        sdgOneVarFitModel.InitialiseDialog()
        UcrBase.iHelpTopicID = 296
        UcrBase.clsRsyntax.iCallType = 2
        UcrReceiver.Selector = ucrSelectorOneVarFitMod
        UcrReceiver.SetMeAsReceiver()
        ucrSaveModel.SetDataFrameSelector(ucrSelectorOneVarFitMod.ucrAvailableDataFrames)
        ucrSaveModel.SetPrefix("dist")
        ucrSaveModel.SetItemsTypeAsModels()
        ucrSaveModel.SetDefaultTypeAsModel()
        ucrSaveModel.SetValidationTypeAsRVariable()
        UcrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        sdgOneVarFitModDisplay.SetModelFunction(clsROneVarFitModel)
        sdgOneVarFitModel.SetMyRFunction(clsROneVarFitModel)
        sdgOneVarFitModDisplay.SetDistribution(ucrFamily)
        sdgOneVarFitModel.SetDistribution(ucrFamily)
        nudCI.Increment = 0.05
        nudCI.DecimalPlaces = 2
        nudHyp.DecimalPlaces = 2
        nudCI.Maximum = 1
        nudCI.Minimum = 0
        ucrOperator.SetItems({"==", "<", "<=", ">", ">=", "!="})
        cboVariables.SetItemsTypeAsColumns()    'we want SetItemsTypeAs factors in the column
    End Sub

    Private Sub SetDefaults()
        ucrSelectorOneVarFitMod.Reset()
        ucrSelectorOneVarFitMod.Focus()
        ucrOperator.SetName("==")
        nudCI.Value = 0.95
        BinomialConditions()
        chkSaveModel.Checked = True
        ucrSaveModel.Reset()
        SetDataParameter()
        EnableOptions()
        AssignSaveModel()
        sdgOneVarFitModDisplay.SetDefaults()
        sdgOneVarFitModel.SetDefaults()
        SetBaseFunction()
        rdoGeneral.Checked = True
        TestOKEnabled()
        SetDistributions()
    End Sub

    Private Sub SetDistributions()
        If rdoGeneral.Checked Then
            ucrFamily.SetAllDistributions()
        ElseIf rdoSpecific.Checked Then
            ucrFamily.SetExactDistributions()
        End If
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub TestOKEnabled()
        If (chkSaveModel.Checked AndAlso Not ucrSaveModel.IsEmpty() OrElse Not chkSaveModel.Checked) AndAlso Not UcrReceiver.IsEmpty AndAlso sdgOneVarFitModDisplay.TestOkEnabled() Then
            UcrBase.OKEnabled(True)
        Else
            UcrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles UcrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrSelectorOneVarFitMod_DataFrameChanged() Handles ucrSelectorOneVarFitMod.DataFrameChanged
        AssignSaveModel()
    End Sub

    Private Sub ucrSaveModel_NameChanged() Handles ucrSaveModel.NameChanged
        AssignSaveModel()
        TestOKEnabled()
    End Sub

    Public Sub SetDataParameter()
        If Not UcrReceiver.IsEmpty Then
            If UcrReceiver.strCurrDataType = "numeric" OrElse UcrReceiver.strCurrDataType = "integer" Then
                chkConvertToVariate.Checked = False
                chkConvertToVariate.Visible = False
            Else
                chkConvertToVariate.Visible = True
            End If
            If chkConvertToVariate.Checked Then
                clsRConvert.SetRCommand("as.numeric")
                clsRConvert.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
                UcrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=clsRConvert)
            Else
                'TODO This is needed because fitdist checks is.vector on data which is FALSE when data has attributes
                If ucrFamily.clsCurrDistribution.strNameTag = "Poisson" OrElse ucrFamily.clsCurrDistribution.strNameTag = "Geometric" Then
                    clsRConvert.SetRCommand("as.integer")
                    clsRConvert.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
                    clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvert)
                Else
                    clsRConvert.SetRCommand("as.vector")
                    clsRConvert.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
                    clsROneVarFitModel.AddParameter("data", clsRFunctionParameter:=clsRConvert)
                End If
                If ucrFamily.clsCurrDistribution.strNameTag = "Extreme_Value" Or ucrFamily.clsCurrDistribution.strNameTag = "Binomial" Or ucrFamily.clsCurrDistribution.strNameTag = "Bernouli" Or ucrFamily.clsCurrDistribution.strNameTag = "Students_t" Or ucrFamily.clsCurrDistribution.strNameTag = "Chi_Square" Or ucrFamily.clsCurrDistribution.strNameTag = "F" Or ucrFamily.clsCurrDistribution.strNameTag = "Hypergeometric" Then
                    clsROneVarFitModel.AddParameter("start", clsRFunctionParameter:=clsRStartValues)
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
        clsRConvert.ClearParameters()
        clsRStartValues.ClearParameters()
        If rdoGeneral.Checked Then
            FitDistFunction()
        ElseIf rdoSpecific.Checked Then
            If ucrFamily.clsCurrDistribution.strNameTag = "Poisson" Then
                SetPoissonTest()
            ElseIf ucrFamily.clsCurrDistribution.strNameTag = "Normal" Then
                SetTTest()
            ElseIf ucrFamily.clsCurrDistribution.strNameTag = "Bernouli" Then
                SetBinomialTest()
            End If
        End If
    End Sub

    Public Sub FitDistFunction()
        UcrBase.clsRsyntax.SetBaseRFunction(clsROneVarFitModel)
        clsROneVarFitModel.SetRCommand("fitdist")
        clsROneVarFitModel.AddParameter("distr", Chr(34) & ucrFamily.clsCurrDistribution.strRName & Chr(34))
        SetDataParameter()
    End Sub

    Private Sub SetTTest()
        clsRTTest.SetRCommand("t.test")
        UcrBase.clsRsyntax.SetBaseRFunction(clsRTTest)
        clsRConvert.SetRCommand("as.vector")
        clsRConvert.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
        clsRTTest.AddParameter("x", clsRFunctionParameter:=clsRConvert)
        clsRTTest.AddParameter("mu", nudHyp.Value.ToString)
        clsRTTest.AddParameter("conf.level", nudCI.Value.ToString)
    End Sub

    Private Sub SetPoissonTest()
        clsRPoissonTest.SetRCommand("poisson.test")
        UcrBase.clsRsyntax.SetBaseRFunction(clsRPoissonTest)
        clsRPoissonTest.AddParameter("r", nudHyp.Value.ToString)
        clsRPoissonTest.AddParameter("conf.level", nudCI.Value.ToString)
        clsRPoissonTest.AddParameter("T", clsRFunctionParameter:=clsRMean)
        clsRPoissonTest.AddParameter("x", clsRFunctionParameter:=clsRLength)
        clsRLength.SetRCommand("length")
        clsRLength.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
        clsRMean.SetRCommand("mean")
        clsRMean.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
    End Sub

    Private Sub SetBinomialTest()
        clsRBinomTest.SetRCommand("binom.test")
        UcrBase.clsRsyntax.SetBaseRFunction(clsRBinomTest)
        clsRBinomTest.AddParameter("p", nudHyp.Value.ToString)
        clsRBinomTest.AddParameter("conf.level", nudCI.Value.ToString)
        If chkBinModify.Checked Then
            If UcrReceiver.strCurrDataType = "factor" OrElse UcrReceiver.strCurrDataType = "character" Then
                clsRBinomTest.AddParameter("x", clsROperatorParameter:=clsFactorOperator)
                clsFactorOperator.SetOperation("==")
                clsFactorOperator.SetParameter(True, clsRFunc:=UcrReceiver.GetVariables())
                clsFactorOperator.SetParameter(False, strValue:=cboVariables.GetText())
            Else
                clsRBinomTest.AddParameter("x", clsROperatorParameter:=clsFunctionOperator)
                clsFunctionOperator.SetOperation(ucrOperator.GetText())
                clsFunctionOperator.SetParameter(True, clsRFunc:=UcrReceiver.GetVariables())
                clsFunctionOperator.SetParameter(False, strValue:=nudBinomialConditions.Value.ToString())
            End If
        Else
            clsRBinomTest.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
        End If
    End Sub

    Private Sub PlotResiduals()
        clsRConvert.ClearParameters()
        clsRplot.SetRCommand("plot")
        clsRplot.AddParameter("x", clsRFunctionParameter:=clsRfitdist)
        clsRfitdist.SetRCommand("fitdist")
        clsRfitdist.AddParameter("distr", Chr(34) & ucrFamily.clsCurrDistribution.strRName & Chr(34))
        If ucrFamily.clsCurrDistribution.strNameTag = "Poisson" Then
            clsRConvert.SetRCommand("as.integer")
            clsRConvert.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
            clsRfitdist.AddParameter("data", clsRFunctionParameter:=clsRConvert)
        Else
            clsRConvert.SetRCommand("as.vector")
            clsRConvert.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
            clsRfitdist.AddParameter("data", clsRFunctionParameter:=clsRConvert)
        End If
        If ucrFamily.clsCurrDistribution.strNameTag = "Bernouli" Then
            clsRfitdist.AddParameter("start", clsRFunctionParameter:=clsRBinomStart)
            clsRBinomStart.SetRCommand("mean")
            clsRBinomStart.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
        End If
    End Sub

    Private Sub AssignSaveModel()
        If chkSaveModel.Checked AndAlso Not ucrSaveModel.IsEmpty Then
            UcrBase.clsRsyntax.SetAssignTo(ucrSaveModel.GetText, strTempModel:=ucrSaveModel.GetText, strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            UcrBase.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model", strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
    End Sub

    Private Sub chkSaveModel_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveModel.CheckedChanged
        If chkSaveModel.Checked Then
            ucrSaveModel.Visible = True
        Else
            ucrSaveModel.Visible = False
        End If
        AssignSaveModel()
        TestOKEnabled()
    End Sub

    Private Sub UcrReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles UcrReceiver.SelectionChanged
        SetBaseFunction()
        TestOKEnabled()
        EnableOptions()
        PlotResiduals()
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

    Private Sub chkConvertToVariate_CheckedChanged(sender As Object, e As EventArgs) Handles chkConvertToVariate.CheckedChanged
        SetDataParameter()
        TestOKEnabled()
        Display()
    End Sub

    Private Sub UcrBase_ClickOk(sender As Object, e As EventArgs) Handles UcrBase.ClickOk
        If rdoGeneral.Checked Then
            sdgOneVarFitModDisplay.CreateGraphs()
            If sdgOneVarFitModel.rdoMle.Checked AndAlso (sdgOneVarFitModDisplay.rdoLoglik.Checked Or sdgOneVarFitModDisplay.rdoLik.Checked) Then
                sdgOneVarFitModDisplay.RunLikelihoods()
            End If
        Else
            PlotResiduals()
            frmMain.clsRLink.RunScript(clsRplot.ToScript(), 2)
        End If
    End Sub

    Private Sub Display()
        If rdoGeneral.Checked Then
            cmdFittingOptions.Visible = True
            cmdDisplayOptions.Visible = True
            nudCI.Visible = False
            nudHyp.Visible = False
            lblHyp.Visible = False
            lblConfidenceLimit.Visible = False
        ElseIf rdoSpecific.Checked Then
            cmdFittingOptions.Visible = False
            cmdDisplayOptions.Visible = False
            chkConvertToVariate.Visible = False
            nudCI.Visible = True
            nudHyp.Visible = True
            lblHyp.Visible = True
            lblConfidenceLimit.Visible = True
            ' UcrDistributions.cbodistributions. distributions avaliable = ...
            If ucrFamily.clsCurrDistribution.bIsExact = True Then
                lblHyp.Text = ucrFamily.clsCurrDistribution.lstExact(1)
                nudHyp.Value = ucrFamily.clsCurrDistribution.lstExact(2)
                nudHyp.Increment = ucrFamily.clsCurrDistribution.lstExact(3)
                nudHyp.DecimalPlaces = ucrFamily.clsCurrDistribution.lstExact(4)
                nudHyp.Minimum = ucrFamily.clsCurrDistribution.lstExact(5)
                nudHyp.Maximum = ucrFamily.clsCurrDistribution.lstExact(6)
            End If
        End If
    End Sub

    Private Sub rdoButtons_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSpecific.CheckedChanged, rdoGeneral.CheckedChanged
        EnableOptions()
        BinomialConditions()
        sdgOneVarFitModel.OptimisationMethod()
        sdgOneVarFitModel.Estimators()
        SetDistributions()
    End Sub

    Private Sub ucrDistributions_cboDistributionsIndexChanged(sender As Object, e As EventArgs) Handles ucrFamily.cboDistributionsIndexChanged
        SetBaseFunction()
        BinomialConditions()
        SetDataParameter()
        PlotResiduals()
    End Sub

    Private Sub lbls_VisibleChanged(sender As Object, e As EventArgs) Handles lblHyp.VisibleChanged, lblConfidenceLimit.VisibleChanged, lblEquals.VisibleChanged, lblSuccessIf.VisibleChanged
        BinomialConditions()
    End Sub

    Private Sub nudCI_TextChanged(sender As Object, e As EventArgs) Handles nudCI.TextChanged, nudHyp.TextChanged
        SetBaseFunction()
    End Sub

    Private Sub chkBinModify_CheckedChanged(sender As Object, e As EventArgs) Handles chkBinModify.CheckedChanged
        BinomialConditions()
        SetBinomialTest()
    End Sub

    Private Sub BinomialConditions()
        If rdoSpecific.Checked AndAlso ucrFamily.clsCurrDistribution.strNameTag = "Bernouli" Then
            chkBinModify.Visible = True
            If chkBinModify.Checked Then
                lblSuccessIf.Visible = True
                If UcrReceiver.strCurrDataType = "factor" Then
                    cboVariables.Visible = True
                    lblEquals.Visible = True
                Else
                    lblEquals.Visible = False
                    nudBinomialConditions.Visible = True
                    ucrOperator.Visible = True
                    cboVariables.Visible = False
                End If

            Else
                lblSuccessIf.Visible = False
                lblEquals.Visible = False
                nudBinomialConditions.Visible = False
                ucrOperator.Visible = False
                cboVariables.Visible = False
            End If
        Else
            chkBinModify.Visible = False
            chkBinModify.Checked = False
            lblSuccessIf.Visible = False
            lblEquals.Visible = False
            nudBinomialConditions.Visible = False
            ucrOperator.Visible = False
            cboVariables.Visible = False
        End If
        nudBinomialConditions.Value = 1
        nudBinomialConditions.Maximum = Integer.MaxValue
        nudBinomialConditions.Minimum = Integer.MinValue
        Display()
    End Sub

    Private Sub nudBinomialConditions_ValueChanged(sender As Object, e As EventArgs) Handles nudBinomialConditions.ValueChanged
        SetBinomialTest()
    End Sub

    Private Sub cboVariables_TextChanged(sender As Object, e As EventArgs) Handles cboVariables.TextChanged
        BinomialConditions()
        SetBinomialTest()
    End Sub
End Class
