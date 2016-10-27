' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgRegressionSimple
    Public bFirstLoad As Boolean = True
    Public clsModel, clsFunctionOperation As New ROperator
    Public clsRConvert, clsRCIFunction, clsTwoVarModel, clsRCount, clsRCount2 As New RFunction

    Private Sub dlgRegressionSimple_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.SetFunction("")
        clsModel.SetOperation("~")
        ucrResponse.Selector = ucrSelectorSimpleReg
        ucrExplanatory.Selector = ucrSelectorSimpleReg
        ucrBase.iHelpTopicID = 171
        ucrModelName.SetDataFrameSelector(ucrSelectorSimpleReg.ucrAvailableDataFrames)
        ucrModelName.SetPrefix("reg")
        ucrModelName.SetItemsTypeAsModels()
        ucrModelName.SetDefaultTypeAsModel()
        ucrModelName.SetValidationTypeAsRVariable()
        ucrModelPreview.IsReadOnly = True
        sdgSimpleRegOptions.SetRModelFunction(ucrBase.clsRsyntax.clsBaseFunction)
        'sdgSimpleRegOptions.SetRModelFunction(clsTwoVarModel)
        sdgSimpleRegOptions.SetRDataFrame(ucrSelectorSimpleReg.ucrAvailableDataFrames)
        sdgSimpleRegOptions.SetRYVariable(ucrResponse)
        sdgSimpleRegOptions.SetRXVariable(ucrExplanatory)
        sdgVariableTransformations.SetRYVariable(ucrResponse)
        sdgVariableTransformations.SetRXVariable(ucrExplanatory)
        sdgVariableTransformations.SetRModelOperator(clsModel)
        sdgModelOptions.SetRCIFunction(clsRCIFunction)
        sdgVariableTransformations.SetRCIFunction(clsRCIFunction)
        AssignModelName()
        nudCI.Increment = 0.05
        nudCI.Minimum = 0
        nudCI.Maximum = 1
        nudCI.DecimalPlaces = 2
        nudHypothesis.DecimalPlaces = 2
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorSimpleReg.Reset()
        ucrResponse.SetMeAsReceiver()
        ucrSelectorSimpleReg.Focus()
        chkSaveModel.Checked = True
        ucrModelName.Visible = True
        chkConvertToVariate.Checked = False
        chkConvertToVariate.Visible = False
        chkFunction.Checked = False
        chkFunction.Visible = False
        rdoGeneral.Checked = True
        nudCI.Value = 0.95
        sdgSimpleRegOptions.SetDefaults()
        sdgModelOptions.SetDefaults()
        ucrModelName.Reset()
        ucrModelPreview.SetName("")
        ResponseConvert()
        TestOKEnabled()
        PoissonChange()
    End Sub

    Private Sub SimpleRegression()
        clsTwoVarModel.SetRCommand("")
        TestOKEnabled()
        '        If rdoGeneral.Checked Then
        '        If (ucrFamily.clsCurrDistribution.strNameTag = "Normal") Then
        '        clsTwoVarModel.ClearParameters()
        '        clsTwoVarModel.SetRCommand("")
        '        clsTwoVarModel.AddParameter("lm")
        '        Else
        '        clsTwoVarModel.ClearParameters()
        '        clsTwoVarModel.SetRCommand("")
        '        clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
        '        clsTwoVarModel.AddParameter("glm")
        '        clsTwoVarModel.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
        '        End If
        '       End If
        'TODO:   Include multinomial as an option And the appropriate function
        If rdoGeneral.Checked Then
            If (ucrFamily.clsCurrDistribution.strNameTag = "Normal") Then
                ucrBase.clsRsyntax.SetFunction("lm")
                ucrBase.clsRsyntax.RemoveParameter("family")
            Else
                clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
                ucrBase.clsRsyntax.SetFunction("glm")
                clsTwoVarModel.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
            End If
        End If
    End Sub

    Private Sub SetTTest()
        clsTwoVarModel.ClearParameters()
        ' only variables the response receiver can accept is numerical
        clsTwoVarModel.SetRCommand("t.test")
        clsTwoVarModel.AddParameter("conf.level", nudCI.Value.ToString())
        clsTwoVarModel.AddParameter("mu", nudHypothesis.Value.ToString())
        If ucrExplanatory.strCurrDataType = "numeric" OrElse ucrExplanatory.strCurrDataType = "integer" Then 'is that the corerct way to write it - check
            clsTwoVarModel.AddParameter("x", clsRFunctionParameter:=ucrResponse.GetVariables())
            clsTwoVarModel.AddParameter("y", clsRFunctionParameter:=ucrExplanatory.GetVariables())
        Else
            clsModel.SetOperation("~")
            clsModel.SetParameter(True, clsRFunc:=ucrResponse.GetVariables())
            clsModel.SetParameter(False, clsRFunc:=ucrExplanatory.GetVariables())
            clsTwoVarModel.AddParameter("x", clsROperatorParameter:=clsModel)
            clsTwoVarModel.AddParameter("y", clsROperatorParameter:=clsModel)
        End If

        If chkPaired.Checked Then
            clsTwoVarModel.AddParameter("paired", "TRUE")
        Else
            clsTwoVarModel.AddParameter("paired", "FALSE")
        End If
    End Sub

    Private Sub SetBinomTest()
        clsTwoVarModel.ClearParameters()
        ' only variables the response receiver can accept is numerical
        ' only variables the explanatory receiver can accept is factor
        clsTwoVarModel.SetRCommand("prop.test")
        clsTwoVarModel.AddParameter("conf.level", nudCI.Value.ToString())
        clsTwoVarModel.AddParameter("p", nudHypothesis.Value.ToString())
        clsModel.SetParameter(True, clsRFunc:=ucrResponse.GetVariables())
        clsModel.SetParameter(False, clsRFunc:=ucrExplanatory.GetVariables())
        clsTwoVarModel.AddParameter("x", clsROperatorParameter:=clsModel)
        clsTwoVarModel.AddParameter("y", clsROperatorParameter:=clsModel)
    End Sub

    Private Sub SetPoissonTest()
        clsTwoVarModel.ClearParameters()
        ' can accept any variables in any receiver

        clsTwoVarModel.SetRCommand("poisson.test")
        clsTwoVarModel.AddParameter("conf.level", nudCI.Value.ToString())
        clsTwoVarModel.AddParameter("r", nudHypothesis.Value.ToString())
        clsRCount.SetRCommand("count")
        If chkModifyPoisson1.Checked Then
            If chkModifyPoisson2.Checked Then
                '                clsTwoVarModel.AddParameter("x", "c(" & clsRCount & "," & clsRCount2 & ")")
                clsRCount.AddParameter("x", clsROperatorParameter:=clsFunctionOperation)
                clsFunctionOperation.SetOperation("==")
                clsFunctionOperation.SetParameter(True, clsRFunc:=ucrResponse.GetVariables())
                clsFunctionOperation.SetParameter(False, strValue:=Chr(34) & ucrTextforX.GetText.ToString & Chr(34))
                clsRCount2.AddParameter("x", clsROperatorParameter:=clsFunctionOperation)
                clsFunctionOperation.SetParameter(True, clsRFunc:=ucrExplanatory.GetVariables())
                clsFunctionOperation.SetParameter(False, strValue:=Chr(34) & ucrTextforY.GetText.ToString & Chr(34))
            ElseIf Not chkModifyPoisson2.Checked Then
                ' receiver is altered, explanatory is not
                '               clsTwoVarModel.AddParameter("x", "c(" & clsRCount & "," & clsRCount2 & ")")
                clsRCount.AddParameter("x", clsROperatorParameter:=clsFunctionOperation)
                clsFunctionOperation.SetOperation("==")
                clsFunctionOperation.SetParameter(True, clsRFunc:=ucrResponse.GetVariables())
                clsFunctionOperation.SetParameter(False, strValue:=Chr(34) & ucrTextforX.GetText.ToString & Chr(34))
                clsRCount2.AddParameter("x", clsRFunctionParameter:=ucrExplanatory.GetVariables())
            End If
        Else
            If chkModifyPoisson2.Checked Then
                ' modify receiever is not altered but modify explanaatory is
                '              clsTwoVarModel.AddParameter("x", "c(" & clsRCount & "," & clsRCount2 & ")")
                clsRCount.AddParameter("x", clsRFunctionParameter:=ucrResponse.GetVariables())
                clsFunctionOperation.SetOperation("==")
                clsRCount2.AddParameter("x", clsROperatorParameter:=clsFunctionOperation)
                clsFunctionOperation.SetParameter(True, clsRFunc:=ucrExplanatory.GetVariables())
                clsFunctionOperation.SetParameter(False, strValue:=Chr(34) & ucrTextforY.GetText.ToString & Chr(34))
            ElseIf Not chkModifyPoisson2.Checked Then
                ' neither is altered, so we just have our values from the receiver
                '             clsTwoVarModel.AddParameter("x", "c(" & clsRCount & "," & clsRCount2 & ")")
                clsRCount.AddParameter("x", clsRFunctionParameter:=ucrResponse.GetVariables())
                clsRCount2.AddParameter("x", clsRFunctionParameter:=ucrExplanatory.GetVariables())
            End If
        End If
    End Sub

    Private Sub SetRCode()
        If rdoSpecific.Checked Then
            If ucrFamily.clsCurrDistribution.strNameTag = "Normal" Then
                SetTTest()
            ElseIf ucrFamily.clsCurrDistribution.strNameTag = "Poisson" Then
                SetPoissonTest()
            ElseIf ucrFamily.clsCurrDistribution.strNameTag = "Binomial" Then
                SetBinomTest()
            End If

            'elseif rdoGeneral.checked
        End If
    End Sub


    Private Sub TestOKEnabled()
        If Not ucrResponse.IsEmpty() AndAlso Not ucrExplanatory.IsEmpty() AndAlso ucrFamily.Enabled AndAlso (chkSaveModel.Checked AndAlso Not ucrModelName.IsEmpty() OrElse Not chkSaveModel.Checked) Then
            ucrBase.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel)
            ucrBase.OKEnabled(True)
            ucrModelPreview.SetName(clsModel.ToScript)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectorSimpleReg_DataFrameChanged() Handles ucrSelectorSimpleReg.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorSimpleReg.ucrAvailableDataFrames.clsCurrDataFrame)
        AssignModelName()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.ShowDialog()
        Display()
    End Sub

    Public Sub ResponseConvert()
        If Not ucrResponse.IsEmpty AndAlso rdoGeneral.Checked Then

            ucrFamily.RecieverDatatype(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))
            If ucrFamily.strDataType = "numeric" Then
                chkConvertToVariate.Checked = False
                chkConvertToVariate.Visible = False
            Else
                chkConvertToVariate.Visible = True
            End If

            If chkConvertToVariate.Checked Then
                clsRConvert.SetRCommand("as.numeric")
                clsRConvert.AddParameter("x", ucrResponse.GetVariableNames(bWithQuotes:=False))
                clsModel.SetParameter(True, clsRFunc:=clsRConvert)
                ucrFamily.RecieverDatatype("numeric")
            Else
                clsModel.SetParameter(True, strValue:=ucrResponse.GetVariableNames(bWithQuotes:=False))
                ucrFamily.RecieverDatatype(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))
            End If
            sdgModelOptions.ucrFamily.RecieverDatatype(ucrFamily.strDataType)
        End If

        If ucrFamily.lstCurrentDistributions.Count = 0 Or ucrResponse.IsEmpty() Then
            ucrFamily.cboDistributions.Text = ""
            cmdModelOptions.Enabled = False
        Else
            cmdModelOptions.Enabled = True
        End If
    End Sub

    Private Sub DistributionsOffered()
        '        If rdoGeneral.Checked Then
        '        ucrFamily.SetGLMDistributions()
        '        Else
        '        ucrFamily.bDistributionsSet = True
        ' set only normal, poisson and binomial
        '       End If
    End Sub

    Private Sub ucrResponse_SelectionChanged() Handles ucrResponse.SelectionChanged
        ResponseConvert()
        SetRCode()
        TestOKEnabled()
    End Sub

    Private Sub chkConvertToVariate_CheckedChanged(sender As Object, e As EventArgs) Handles chkConvertToVariate.CheckedChanged
        ResponseConvert()
        TestOKEnabled()
        Display()
    End Sub

    Private Sub ExplanatoryFunctionSelect()
        Dim strExplanatoryType As String
        If Not ucrExplanatory.IsEmpty AndAlso rdoGeneral.Checked Then
            strExplanatoryType = frmMain.clsRLink.GetDataType(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrExplanatory.GetVariableNames(bWithQuotes:=False))
            If rdoGeneral.Checked AndAlso (strExplanatoryType = "numeric" Or strExplanatoryType = "positive integer" Or strExplanatoryType = "integer") Then
                chkFunction.Visible = True
            Else
                chkFunction.Checked = False
                chkFunction.Visible = False
            End If
            If chkFunction.Checked Then
                sdgVariableTransformations.ModelFunction(False)
            Else
                sdgVariableTransformations.rdoIdentity.Checked = True
                clsModel.SetParameter(False, strValue:=ucrExplanatory.GetVariableNames(bWithQuotes:=False))
            End If
        End If
    End Sub

    Private Sub ucrExplanatory_SelectionChanged() Handles ucrExplanatory.SelectionChanged
        ExplanatoryFunctionSelect()
        SetRCode()
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrModelName_NameChanged() Handles ucrModelName.NameChanged
        AssignModelName()
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        sdgSimpleRegOptions.RegOptions()
    End Sub

    Private Sub chkModelName_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveModel.CheckedChanged
        If chkSaveModel.Checked Then
            ucrModelName.Enabled = True
        Else
            ucrModelName.Enabled = False
        End If
        AssignModelName()
        TestOKEnabled()
    End Sub

    Private Sub AssignModelName()
        If chkSaveModel.Checked AndAlso Not ucrModelName.IsEmpty Then
            ucrBase.clsRsyntax.SetAssignTo(ucrModelName.GetText, strTempModel:=ucrModelName.GetText, strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model", strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub

    Private Sub ucrFamily_cboDistributionsIndexChanged(sender As Object, e As EventArgs) Handles ucrFamily.cboDistributionsIndexChanged
        sdgModelOptions.ucrFamily.RecieverDatatype(ucrFamily.strDataType)
        sdgModelOptions.ucrFamily.cboDistributions.SelectedIndex = sdgModelOptions.ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = ucrFamily.clsCurrDistribution.strNameTag)
        sdgModelOptions.RestrictLink()
        DistributionsOffered()
        SimpleRegression()
        PoissonChange()
    End Sub

    Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click
        sdgModelOptions.ShowDialog()
        ucrFamily.cboDistributions.SelectedIndex = ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgModelOptions.ucrFamily.clsCurrDistribution.strNameTag)
        Display()
    End Sub

    Private Sub chkConvertToVariate_CheckedChanged_1(sender As Object, e As EventArgs)
        ResponseConvert()
        TestOKEnabled()
    End Sub

    Private Sub ucrExplanatory_SelectionChanged(sender As Object, e As EventArgs) Handles ucrExplanatory.SelectionChanged

    End Sub

    Private Sub ucrResponse_SelectionChanged(sender As Object, e As EventArgs) Handles ucrResponse.SelectionChanged

    End Sub

    Private Sub chkFunction_CheckedChanged(sender As Object, e As EventArgs) Handles chkFunction.CheckedChanged
        If chkFunction.Checked Then
            sdgVariableTransformations.ShowDialog()
        End If
        ExplanatoryFunctionSelect()
        TestOKEnabled()
        Display()
    End Sub

    Private Sub Display()
        If rdoGeneral.Checked Then
            nudHypothesis.Visible = False
            nudCI.Visible = False
            chkPaired.Visible = False
            lblMean.Visible = False
            lblFactor.Visible = False
            lblNumeric.Visible = False
            lblProbability.Visible = False
            lblRate.Visible = False
            lblCI.Visible = False
            ucrModelPreview.Visible = True
            lblModelPreview.Visible = True
            lblResponse.Visible = True
            lblExplanatory.Visible = True
            cmdDisplayOptions.Visible = True
            cmdModelOptions.Visible = True
        ElseIf rdoSpecific.Checked Then
            ucrModelPreview.Visible = False
            lblModelPreview.Visible = False
            lblResponse.Visible = False
            lblExplanatory.Visible = False
            cmdDisplayOptions.Visible = False
            cmdModelOptions.Visible = False
            lblFactor.Visible = True
            lblNumeric.Visible = True
            nudCI.Visible = True
            nudHypothesis.Visible = True
            lblCI.Visible = True
            chkConvertToVariate.Visible = False
            chkFunction.Visible = False
            If ucrFamily.clsCurrDistribution.strNameTag = "Normal" Then
                lblMean.Visible = True
                lblProbability.Visible = False
                lblRate.Visible = False
                chkPaired.Visible = True
                nudHypothesis.Increment = 1
                nudHypothesis.Maximum = Integer.MaxValue
                nudHypothesis.Minimum = Integer.MinValue
                nudHypothesis.Value = 0
            ElseIf ucrFamily.clsCurrDistribution.strNameTag = "Poisson" Then
                lblMean.Visible = False
                lblProbability.Visible = False
                lblRate.Visible = True
                chkPaired.Visible = False
                nudHypothesis.Increment = 1
                nudHypothesis.Maximum = Integer.MaxValue
                nudHypothesis.Minimum = 0
                nudHypothesis.Value = 1
            ElseIf ucrFamily.clsCurrDistribution.strNameTag = "Binomial" Then
                lblMean.Visible = False
                lblProbability.Visible = True
                lblRate.Visible = False
                chkPaired.Visible = False
                nudHypothesis.Increment = 0.1
                nudHypothesis.Maximum = 1
                nudHypothesis.Minimum = 0
                nudHypothesis.Value = 0.5
            End If
        End If
    End Sub

    Private Sub lbls_VisibleChanged(sender As Object, e As EventArgs) Handles lblCI.VisibleChanged, lblRate.VisibleChanged, lblProbability.VisibleChanged, lblMean.VisibleChanged, lblExplanatory.VisibleChanged, lblResponse.VisibleChanged, lblModelPreview.VisibleChanged, lblFactor.VisibleChanged, lblNumeric.VisibleChanged
        Display()
    End Sub

    Private Sub nuds_TextChanged(sender As Object, e As EventArgs) Handles nudCI.TextChanged, nudHypothesis.TextChanged
        SetRCode()
    End Sub

    Private Sub chkboxes_VisibleChanged(sender As Object, e As EventArgs) Handles chkFunction.VisibleChanged, chkConvertToVariate.VisibleChanged, chkPaired.VisibleChanged
        Display()
        ExplanatoryFunctionSelect()
        ResponseConvert()
        TestOKEnabled()
    End Sub

    Private Sub rdoTop_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGeneral.CheckedChanged, rdoSpecific.CheckedChanged
        Display()
        ResponseConvert()
        ExplanatoryFunctionSelect()
        DistributionsOffered()
    End Sub

    Private Sub PoissonChange()
        If rdoSpecific.Checked AndAlso ucrFamily.clsCurrDistribution.strNameTag = "Poisson" Then
            chkModifyPoisson1.Visible = True
            chkModifyPoisson2.Visible = True
            If chkModifyPoisson1.Checked Then
                lblX.Visible = True
                ucrTextforX.Visible = True
            Else
                lblX.Visible = False
                ucrTextforX.Visible = False
            End If
            If chkModifyPoisson2.Checked Then
                lblY.visible = True
                ucrTextforY.Visible = True
            Else
                lblY.Visible = False
                ucrTextforY.Visible = False
            End If
        Else
            chkModifyPoisson1.Visible = False
            chkModifyPoisson2.Visible = False
            lblX.Visible = False
            lblY.Visible = False
            ucrTextforX.Visible = False
            ucrTextforY.Visible = False
        End If
        Display()
    End Sub

    Private Sub PoissonObjects(sender As Object, e As EventArgs) Handles chkModifyPoisson1.VisibleChanged, chkModifyPoisson2.VisibleChanged, lblX.VisibleChanged, lblY.VisibleChanged, ucrTextforX.VisibleChanged, ucrTextforX.VisibleChanged
        PoissonChange()
        SetPoissonTest()
    End Sub
End Class