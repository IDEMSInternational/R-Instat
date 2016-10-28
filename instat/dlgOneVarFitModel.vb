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
    Public clsRConvert, clsROneVarFitModel, clsRLength, clsRMean, clsRTTest, clsRBinomTest, clsRPoissonTest As New RFunction
    Public clsFunctionOperator As New ROperator
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
        sdgOneVarFitModDisplay.SetDistribution(UcrDistributions)
        sdgOneVarFitModel.SetDistribution(UcrDistributions)
        nudCI.Increment = 0.05
        nudCI.DecimalPlaces = 2
        nudHyp.DecimalPlaces = 2
        nudCI.Maximum = 1
        nudCI.Minimum = 0
        ucrOperator.SetItems({"==", "<", "<=", ">", ">=", "!="})
    End Sub

    Private Sub SetDefaults()
        UcrDistributions.cboDistributions.SelectedItem = "Normal"
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
                clsRConvert.SetRCommand("as.vector")
                clsRConvert.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
                UcrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=clsRConvert)
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
        If rdoGeneral.Checked Then
            FitDistFunction()
        ElseIf rdoSpecific.Checked Then
            If UcrDistributions.clsCurrDistribution.strNameTag = "Poisson" Then
                SetPoissonTest()
            ElseIf UcrDistributions.clsCurrDistribution.strNameTag = "Normal" Then
                SetTTest()
            ElseIf UcrDistributions.clsCurrDistribution.strNameTag = "Binomial" Then
                SetBinomialTest()
            End If
        End If
    End Sub

    Public Sub FitDistFunction()
        UcrBase.clsRsyntax.SetBaseRFunction(clsROneVarFitModel)
        clsROneVarFitModel.SetRCommand("fitdist")
        clsROneVarFitModel.AddParameter("distr", Chr(34) & UcrDistributions.clsCurrDistribution.strRName & Chr(34))
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
            clsRBinomTest.AddParameter("x", clsROperatorParameter:=clsFunctionOperator)
            clsFunctionOperator.SetOperation(ucrOperator.GetText())
            clsFunctionOperator.SetParameter(True, clsRFunc:=UcrReceiver.GetVariables())
            clsFunctionOperator.SetParameter(False, strValue:=nudBinomialConditions.Value.ToString())
        Else
            clsRBinomTest.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
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
            '  If Not sdgOneVarFitModel.rdoMle.Checked AndAlso (sdgOneVarFitModDisplay.rdoLoglik.Checked Or sdgOneVarFitModDisplay.rdoLik.Checked) Then
            'message to say likelihood won't be displayed
        End If
    End Sub

    Private Sub Display()
        If rdoGeneral.Checked Then
            cmdFittingOptions.Visible = True
            cmdDisplayOptions.Visible = True
            nudCI.Visible = False
            nudHyp.Visible = False
            lblMean.Visible = False
            lblRate.Visible = False
            lblprobability.Visible = False
            lblConfidenceLimit.Visible = False
        ElseIf rdoSpecific.Checked Then
            cmdFittingOptions.Visible = False
            cmdDisplayOptions.Visible = False
            chkConvertToVariate.Visible = False
            nudCI.Visible = True
            lblConfidenceLimit.Visible = True
            ' UcrDistributions.cbodistributions. distributions avaliable = ...
            If UcrDistributions.clsCurrDistribution.strNameTag = "Normal" Then
                lblMean.Visible = True
                lblRate.Visible = False
                lblprobability.Visible = False
                nudHyp.Visible = True
                nudHyp.Value = 0
                nudHyp.Increment = 1
                nudHyp.DecimalPlaces = 2
                nudHyp.Maximum = Integer.MaxValue
                nudHyp.Minimum = Integer.MinValue
            ElseIf UcrDistributions.clsCurrDistribution.strNameTag = "Binomial" Then
                lblprobability.Visible = True
                lblMean.Visible = False
                lblRate.Visible = False
                nudHyp.Visible = True
                nudHyp.Value = 0.5
                nudHyp.Maximum = 1
                nudHyp.Minimum = 0
                nudHyp.Increment = 0.1
                nudHyp.DecimalPlaces = 2
            ElseIf UcrDistributions.clsCurrDistribution.strNameTag = "Poisson" Then
                lblMean.Visible = False
                lblRate.Visible = True
                lblprobability.Visible = False
                nudHyp.Visible = True
                nudHyp.Value = 1
                nudHyp.Increment = 1
                nudHyp.DecimalPlaces = 2
                nudHyp.Maximum = Integer.MaxValue
                nudHyp.Minimum = 0
            End If
        End If
    End Sub

    Private Sub rdoButtons_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSpecific.CheckedChanged, rdoGeneral.CheckedChanged
        EnableOptions()
        BinomialConditions()
        sdgOneVarFitModel.OptimisationMethod()
        sdgOneVarFitModel.Estimators()
    End Sub

    Private Sub ucrDistributions_cboDistributionsIndexChanged(sender As Object, e As EventArgs) Handles UcrDistributions.cboDistributionsIndexChanged
        SetBaseFunction()
        BinomialConditions()
    End Sub

    Private Sub lbls_VisibleChanged(sender As Object, e As EventArgs) Handles lblMean.VisibleChanged, lblRate.VisibleChanged, lblprobability.VisibleChanged, lblConfidenceLimit.VisibleChanged, lblSuccessIf.VisibleChanged
        Display()
    End Sub

    Private Sub nudCI_TextChanged(sender As Object, e As EventArgs) Handles nudCI.TextChanged, nudHyp.TextChanged
        SetBaseFunction()
    End Sub

    Private Sub chkBinModify_CheckedChanged(sender As Object, e As EventArgs) Handles chkBinModify.CheckedChanged
        BinomialConditions()
        SetBinomialTest() '''' do we need this?
    End Sub

    Private Sub BinomialConditions()
        If rdoSpecific.Checked AndAlso UcrDistributions.clsCurrDistribution.strNameTag = "Binomial" Then
            chkBinModify.Visible = True
            If chkBinModify.Checked Then
                lblSuccessIf.Visible = True
                nudBinomialConditions.Visible = True
                ucrOperator.Visible = True
            Else
                lblSuccessIf.Visible = False
                nudBinomialConditions.Visible = False
                ucrOperator.Visible = False
            End If
        Else
            chkBinModify.Visible = False
            chkBinModify.Checked = False
            lblSuccessIf.Visible = False
            nudBinomialConditions.Visible = False
            ucrOperator.Visible = False
        End If
        nudBinomialConditions.Value = 1
        nudBinomialConditions.Maximum = Integer.MaxValue
        nudBinomialConditions.Minimum = Integer.MinValue
        Display()
    End Sub

    Private Sub nudBinomialConditions_ValueChanged(sender As Object, e As EventArgs) Handles nudBinomialConditions.ValueChanged
        SetBinomialTest()
    End Sub
End Class
