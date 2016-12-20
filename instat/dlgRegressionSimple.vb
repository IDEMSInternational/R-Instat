'Instat-R
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
    Public clsModel, clsFunctionOperation, clsPoissonOperation, clsPoissonOperation2 As New ROperator
    Public clsRConvert, clsRCIFunction, clsRPoisson, clsRTTest, clsRFTest, clsRKruskalTest, clsRBinomial, clsRWilcoxTest, clsRLength, clsRMean, clsRMean2, clsRLength2, clsRGroup, clsRGroup2, clsRLengthGrouped, clsRLengthGrouped2 As New RFunction
    Public clsRLmOrGLM As New RFunction
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
        clsModel.SetOperation("~")
        ucrResponse.Selector = ucrSelectorSimpleReg
        ucrExplanatory.Selector = ucrSelectorSimpleReg
        ucrBase.iHelpTopicID = 366
        ucrModelName.SetDataFrameSelector(ucrSelectorSimpleReg.ucrAvailableDataFrames)
        ucrModelName.SetItemsTypeAsModels()
        ucrModelName.SetDefaultTypeAsModel()
        ucrModelName.SetValidationTypeAsRVariable()
        ucrModelPreview.IsReadOnly = True
        sdgSimpleRegOptions.SetRModelFunction(clsRLmOrGLM)
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
        chkPaired.Enabled = False 'for the time being
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrModelName.SetPrefix("reg")
        ucrSelectorSimpleReg.Reset()
        ucrResponse.SetMeAsReceiver()
        ucrSelectorSimpleReg.Focus()
        chkSaveModel.Checked = True
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
        SetRCode()
        ucrFamily.SetGLMDistributions()
        sdgSimpleRegOptions.chkDisplayCLimits.Enabled = True
        sdgSimpleRegOptions.lblDisplayCLevel.Enabled = True
        sdgSimpleRegOptions.nudDisplayCLevel.Enabled = True
        rdoCompareMeans.Checked = True
        SetEnableDists()
        TestOKEnabled()
    End Sub

    Private Sub LM()
        clsRLmOrGLM.SetRCommand("lm")
        clsRLmOrGLM.AddParameter("data", clsRFunctionParameter:=ucrSelectorSimpleReg.ucrAvailableDataFrames.clsCurrDataFrame)
        ucrBase.clsRsyntax.SetBaseRFunction(clsRLmOrGLM)
        clsRLmOrGLM.AddParameter("formula", clsROperatorParameter:=clsModel)
        clsModel.SetOperation("~")
    End Sub

    Private Sub GLM()
        clsRLmOrGLM.SetRCommand("glm")
        clsRLmOrGLM.AddParameter("data", clsRFunctionParameter:=ucrSelectorSimpleReg.ucrAvailableDataFrames.clsCurrDataFrame)
        ucrBase.clsRsyntax.SetBaseRFunction(clsRLmOrGLM)
        clsRLmOrGLM.AddParameter("formula", clsROperatorParameter:=clsModel)
        clsModel.SetOperation("~")
        clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
        clsRLmOrGLM.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
    End Sub

    Private Sub SetTTest()
        clsRTTest.SetRCommand("t.test")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRTTest)
        clsRTTest.AddParameter("conf.level", nudCI.Value.ToString())
        clsRTTest.AddParameter("mu", nudHypothesis.Value.ToString())
        '        If ucrExplanatory.strCurrDataType = "numeric" OrElse ucrExplanatory.strCurrDataType = "integer" Then
        '        clsRTTest.AddParameter("x", clsRFunctionParameter:=ucrResponse.GetVariables())
        '        clsRTTest.AddParameter("y", clsRFunctionParameter:=ucrExplanatory.GetVariables())
        '        Else
        clsModel.SetOperation("~")
        clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrResponse.GetVariables())
        clsModel.AddParameter(clsRFunctionParameter:=ucrExplanatory.GetVariables())
        clsRTTest.AddParameter("x", clsROperatorParameter:=clsModel)
        '        End If
        If chkPaired.Checked Then
            clsRTTest.AddParameter("paired", "TRUE")
        Else
            clsRTTest.RemoveParameterByName("paired")
        End If
    End Sub

    Private Sub SetFTest()
        clsRFTest.SetRCommand("var.test")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRFTest)
        clsRFTest.AddParameter("conf.level", nudCI.Value.ToString())
        clsRFTest.AddParameter("mu", nudHypothesis.Value.ToString())
        clsModel.SetOperation("~")
        clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrResponse.GetVariables())
        clsModel.AddParameter(clsRFunctionParameter:=ucrExplanatory.GetVariables())
        clsRFTest.AddParameter("", clsROperatorParameter:=clsModel)
    End Sub

    Private Sub SetWilcoxTest()
        clsRWilcoxTest.SetRCommand("wilcox.test")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRWilcoxTest)
        clsRWilcoxTest.AddParameter("conf.level", nudCI.Value.ToString())
        clsRWilcoxTest.AddParameter("mu", nudHypothesis.Value.ToString())
        clsModel.SetOperation("~")
        clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrResponse.GetVariables())
        clsModel.AddParameter(clsRFunctionParameter:=ucrExplanatory.GetVariables())
        clsRWilcoxTest.AddParameter("", clsROperatorParameter:=clsModel)
    End Sub

    Private Sub SetKruskalTest()
        clsRKruskalTest.SetRCommand("kruskal.test")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRKruskalTest)
        clsModel.SetOperation("~")
        clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrResponse.GetVariables())
        clsModel.AddParameter(clsRFunctionParameter:=ucrExplanatory.GetVariables())
        clsRKruskalTest.AddParameter("", clsROperatorParameter:=clsModel)
    End Sub

    Public Sub DataTypeAccepted()
        If rdoSpecific.Checked Then
            ucrResponse.SetIncludedDataTypes({"integer", "numeric"})
            ucrExplanatory.SetIncludedDataTypes({"character", "factor"})
            If ucrResponse.strCurrDataType = "factor" OrElse ucrResponse.strCurrDataType = "character" Then
                ucrResponse.Clear()
            End If
            If ucrExplanatory.strCurrDataType = "integer" OrElse ucrExplanatory.strCurrDataType = "numeric" OrElse ucrResponse.strCurrDataType = "positive integer" Then
                ucrExplanatory.Clear()
            End If
        End If
    End Sub

    Private Sub SetBinomTest()
        clsRBinomial.SetRCommand("prop.test")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRBinomial)
        clsRBinomial.AddParameter("conf.level", nudCI.Value.ToString())
        ' If two factors:
        ' clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrResponse.GetVariables())
        'clsModel.AddParameter(clsRFunctionParameter:=ucrExplanatory.GetVariables())
        'clsRBinomial.AddParameter("x", clsROperatorParameter:=clsModel)
        clsRBinomial.AddParameter("data", ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    End Sub

    Private Sub SetPoissonTest()
        Dim clsxFunc As New RFunction
        Dim clsTFunc As New RFunction

        clsRPoisson.SetRCommand("poisson.test")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRPoisson)
        clsRPoisson.AddParameter("conf.level", nudCI.Value.ToString())
        clsRPoisson.AddParameter("r", nudHypothesis.Value.ToString())

        ' x = ...

        clsxFunc.SetRCommand("c")
        clsxFunc.AddParameter("l1", clsRFunctionParameter:=clsRLength, bIncludeArgumentName:=False)
        clsxFunc.AddParameter("l2", clsRFunctionParameter:=clsRLength2, bIncludeArgumentName:=False)
        clsRPoisson.AddParameter("x", clsRFunctionParameter:=clsxFunc)

        ' poisson.test(x = c(length(x=Calls[Group == 1]), length(x=Calls[Group == 2])), T =c(mean(Calls[Group == 1]), mean(Calls[Group == 2])))

        clsRLength.SetRCommand("length")
        clsRLength.AddParameter("x", clsRFunctionParameter:=clsRLengthGrouped)
        clsRLengthGrouped.AddParameter("x", ucrResponse.GetVariables().ToScript & "[" & clsRGroup.ToScript & "]")
        clsRGroup.AddParameter("x", clsROperatorParameter:=clsPoissonOperation)
        clsPoissonOperation.SetOperation("==")
        clsPoissonOperation.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrExplanatory.GetVariables())
        clsPoissonOperation.AddParameter(strParameterValue:=2)

        clsRLength2.SetRCommand("length")
        clsRLength2.AddParameter("x", clsRFunctionParameter:=clsRLengthGrouped2)
        clsRLengthGrouped2.AddParameter("x", ucrResponse.GetVariables().ToScript & "[" & clsRGroup2.ToScript & "]")
        clsRGroup2.AddParameter("x", clsROperatorParameter:=clsPoissonOperation2)
        clsPoissonOperation2.SetOperation("==")
        clsPoissonOperation2.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrExplanatory.GetVariables())
        clsPoissonOperation2.AddParameter(strParameterValue:=1)

        ' T = ...
        ' T =c(mean(Calls[Group == 1]), mean(Calls[Group == 2])))
        clsTFunc.SetRCommand("c")
        clsTFunc.AddParameter("m1", clsRFunctionParameter:=clsRMean, bIncludeArgumentName:=False)
        clsTFunc.AddParameter("m2", clsRFunctionParameter:=clsRMean2, bIncludeArgumentName:=False)
        clsRPoisson.AddParameter("T", clsRFunctionParameter:=clsTFunc)

        clsRMean.SetRCommand("mean")
        clsRMean.AddParameter("x", clsRFunctionParameter:=clsRLengthGrouped)

        clsRMean2.SetRCommand("mean")
        clsRMean2.AddParameter("x", clsRFunctionParameter:=clsRLengthGrouped2)

        ' ' ' ' ' Doesn't recognise which dataframe it is from


        ' For two numeric variables:
        '        clsRPoisson.SetRCommand("poisson.test")
        '        ucrBase.clsRsyntax.SetBaseRFunction(clsRPoisson)
        '        clsRPoisson.AddParameter("conf.level", nudCI.Value.ToString())
        '        clsRPoisson.AddParameter("r", nudHypothesis.Value.ToString())
        '        clsRLength.SetRCommand("length")
        '        clsRLength.AddParameter("x", clsRFunctionParameter:=ucrResponse.GetVariables())
        '        clsRLength2.SetRCommand("length")
        '        clsRLength2.AddParameter("x", clsRFunctionParameter:=ucrExplanatory.GetVariables())
        '        clsRMean.SetRCommand("mean")
        '        clsRMean.AddParameter("x", clsRFunctionParameter:=ucrResponse.GetVariables())
        '        clsRMean2.SetRCommand("mean")
        '        clsRMean2.AddParameter("x", clsRFunctionParameter:=ucrExplanatory.GetVariables())
    End Sub

    Private Sub SetRCode()
        clsRPoisson.ClearParameters()
        clsRBinomial.ClearParameters()
        clsRTTest.ClearParameters()
        clsRLength.ClearParameters()
        clsRLmOrGLM.ClearParameters()
        If rdoGeneral.Checked Then
            If (ucrFamily.clsCurrDistribution.strNameTag = "Normal") Then
                LM()
            Else
                GLM()
            End If
        ElseIf rdoSpecific.Checked Then
            If ucrFamily.clsCurrDistribution.strNameTag = "Normal" Then
                If rdoCompareMeans.Checked Then
                    SetTTest()
                ElseIf rdoCompareVar.Checked Then
                    SetFTest()
                End If
            ElseIf ucrFamily.clsCurrDistribution.strNameTag = "Poisson" Then
                SetPoissonTest()
            ElseIf ucrFamily.clsCurrDistribution.strNameTag = "Bernouli" Then
                SetBinomTest()
            Else
                If rdoCompareMeans.Checked Then
                    SetWilcoxTest()
                ElseIf rdoCompareVar.Checked Then
                    SetKruskalTest()
                End If
            End If
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrResponse.IsEmpty() AndAlso Not ucrExplanatory.IsEmpty() AndAlso ucrFamily.Enabled AndAlso ucrFamily.cboDistributions.Text <> "" AndAlso (chkSaveModel.Checked AndAlso Not ucrModelName.IsEmpty() OrElse Not chkSaveModel.Checked) Then
            ucrBase.OKEnabled(True)
            ucrModelPreview.SetName(clsModel.ToScript)
            If rdoGeneral.Checked Then
                ucrBase.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectorSimpleReg_DataFrameChanged() Handles ucrSelectorSimpleReg.DataFrameChanged
        AssignModelName()
        SetRCode()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        Display()
        sdgSimpleRegOptions.ShowDialog()
    End Sub

    Public Sub ConvertToVariate()
        If rdoGeneral.Checked Then
            If Not ucrResponse.IsEmpty Then
                ucrFamily.RecieverDatatype(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))
                If ucrFamily.strDataType = "numeric" Then
                    chkConvertToVariate.Checked = False
                    chkConvertToVariate.Visible = False
                Else
                    chkConvertToVariate.Visible = True
                End If
                sdgModelOptions.ucrFamily.RecieverDatatype(ucrFamily.strDataType)
                If chkConvertToVariate.Checked Then
                    clsRConvert.SetRCommand("as.numeric")
                    clsRConvert.AddParameter("x", ucrResponse.GetVariableNames(bWithQuotes:=False))
                    clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=clsRConvert)
                    clsModel.AddParameter(clsRFunctionParameter:=ucrExplanatory.GetVariables())
                    ucrFamily.RecieverDatatype("numeric")
                Else
                    clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrResponse.GetVariables())
                    clsModel.AddParameter(clsRFunctionParameter:=ucrExplanatory.GetVariables())
                    clsModel.AddParameter(iPosition:=0, strParameterValue:=ucrResponse.GetVariableNames(bWithQuotes:=False))
                    ucrFamily.RecieverDatatype(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))
                End If
            Else
                If ucrFamily.lstCurrentDistributions.Count = 0 OrElse ucrResponse.IsEmpty() Then
                    ucrFamily.cboDistributions.Text = ""
                    cmdModelOptions.Enabled = False
                Else
                    cmdModelOptions.Enabled = True
                End If
            End If
        Else
            If Not ucrResponse.IsEmpty Then
                ucrFamily.RecieverDatatype(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))
            End If
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrResponse_SelectionChanged() Handles ucrResponse.SelectionChanged
        SetRCode()
        ConvertToVariate()
        TestOKEnabled()
        DataTypeAccepted()
        SetEnableDists()
    End Sub

    Public Sub SetEnableDists()
        ucrFamily.Enabled = Not ucrResponse.IsEmpty
    End Sub

    Private Sub ucrExplanatory_SelectionChanged(sender As Object, e As EventArgs) Handles ucrExplanatory.SelectionChanged
        If Not ucrExplanatory.IsEmpty Then
            '            ucrLevel1.SetItems({ucrExplanatory.GetItemType("Levels")})
        End If
    End Sub

    Private Sub ucrResponse_SelectionChanged(sender As Object, e As EventArgs) Handles ucrResponse.SelectionChanged

    End Sub

    Private Sub chkConvertToVariate_CheckedChanged(sender As Object, e As EventArgs) Handles chkConvertToVariate.CheckedChanged, chkConvertToVariate.VisibleChanged
        SetRCode()
        ConvertToVariate()
        TestOKEnabled()
        Display()
    End Sub

    Private Sub ExplanatoryFunctionSelect()
        Dim strExplanatoryType As String
        If Not ucrExplanatory.IsEmpty AndAlso rdoGeneral.Checked Then
            strExplanatoryType = frmMain.clsRLink.GetDataType(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrExplanatory.GetVariableNames(bWithQuotes:=False))
            If rdoGeneral.Checked AndAlso (strExplanatoryType = "numeric" OrElse strExplanatoryType = "positive integer" OrElse strExplanatoryType = "integer") Then
                chkFunction.Visible = True
            Else
                chkFunction.Checked = False
                chkFunction.Visible = False
            End If
            If chkFunction.Checked Then
                sdgVariableTransformations.ModelFunction(False)
            Else
                sdgVariableTransformations.rdoIdentity.Checked = True
                clsModel.AddParameter(strParameterValue:=ucrExplanatory.GetVariableNames(bWithQuotes:=False))
            End If
        End If
    End Sub

    Private Sub ucrExplanatory_SelectionChanged() Handles ucrExplanatory.SelectionChanged
        ExplanatoryFunctionSelect()
        SetRCode()
        TestOKEnabled()
        DataTypeAccepted()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrModelName_NameChanged() Handles ucrModelName.NameChanged
        AssignModelName()
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        If rdoGeneral.Checked Then
            sdgSimpleRegOptions.RegOptions()
        End If
    End Sub

    Private Sub chkModelName_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveModel.CheckedChanged
        If chkSaveModel.Checked Then
            ucrModelName.Visible = True
        Else
            ucrModelName.Visible = False
        End If
        AssignModelName()
        TestOKEnabled()
    End Sub

    Private Sub AssignModelName()
        If chkSaveModel.Checked AndAlso Not ucrModelName.IsEmpty Then
            ucrBase.clsRsyntax.SetAssignTo(ucrModelName.GetText, strTempModel:=ucrModelName.GetText, strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            If rdoGeneral.Checked Then
                ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
            Else
                ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
            End If
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model", strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub

    Private Sub ucrFamily_cboDistributionsIndexChanged(sender As Object, e As EventArgs) Handles ucrFamily.cboDistributionsIndexChanged
        sdgModelOptions.ucrFamily.RecieverDatatype(ucrFamily.strDataType)
        sdgModelOptions.ucrFamily.cboDistributions.SelectedIndex = sdgModelOptions.ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = ucrFamily.clsCurrDistribution.strNameTag)
        sdgModelOptions.RestrictLink()
        ExplanatoryFunctionSelect()
        SetRCode()
        Display()
        DataTypeAccepted()
    End Sub

    Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click
        sdgModelOptions.ShowDialog()
        ucrFamily.cboDistributions.SelectedIndex = ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgModelOptions.ucrFamily.clsCurrDistribution.strNameTag)
        Display()
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
            lblFactor.Visible = False
            lblNumeric.Visible = False
            ucrModelPreview.Visible = True
            lblModelPreview.Visible = True
            lblResponse.Visible = True
            lblExplanatory.Visible = True
            cmdDisplayOptions.Visible = True
            cmdModelOptions.Visible = True
            grpParameters.Visible = False
        ElseIf rdoSpecific.Checked Then
            ucrModelPreview.Visible = False
            lblModelPreview.Visible = False
            lblResponse.Visible = False
            lblExplanatory.Visible = False
            cmdDisplayOptions.Visible = False
            cmdModelOptions.Visible = False
            lblFactor.Visible = True
            lblNumeric.Visible = True
            chkConvertToVariate.Visible = False
            chkFunction.Visible = False
            grpParameters.Visible = True
            If ucrFamily.clsCurrDistribution.bIsExact = True Then
                lblHyp1.Text = ucrFamily.clsCurrDistribution.lstExact(1)
                nudHypothesis.Value = ucrFamily.clsCurrDistribution.lstExact(2)
                nudHypothesis.Increment = ucrFamily.clsCurrDistribution.lstExact(3)
                nudHypothesis.DecimalPlaces = ucrFamily.clsCurrDistribution.lstExact(4)
                nudHypothesis.Minimum = ucrFamily.clsCurrDistribution.lstExact(5)
                nudHypothesis.Maximum = ucrFamily.clsCurrDistribution.lstExact(6)
                If ucrFamily.clsCurrDistribution.strNameTag = "Normal" Then
                    rdoCompareMeans.Visible = True
                    rdoCompareVar.Visible = True
                    rdoCompareMeans.Text = "Compare Means"
                    rdoCompareVar.Text = "Compare Variances"
                    nudCI.Enabled = True
                    lblLevel1.Visible = False
                    lblLevel2.Visible = False
                    ucrLevel1.Visible = False
                    ucrLevel2.Visible = False
                    If rdoCompareMeans.Checked Then
                        chkPaired.Visible = True
                        nudHypothesis.Enabled = True
                    ElseIf rdoCompareVar.Checked Then
                        chkPaired.Visible = False
                        nudHypothesis.Enabled = False
                    End If
                ElseIf ucrFamily.clsCurrDistribution.strNameTag = "No_Distribution" Then
                    rdoCompareMeans.Visible = True
                    rdoCompareVar.Visible = True
                    rdoCompareMeans.Text = "Wilcoxon Test"
                    rdoCompareVar.Text = "Kruskal Test"
                    lblLevel1.Visible = False
                    lblLevel2.Visible = False
                    ucrLevel1.Visible = False
                    ucrLevel2.Visible = False
                    If rdoCompareMeans.Checked Then
                        chkPaired.Visible = True
                        nudHypothesis.Enabled = True
                        nudCI.Enabled = True
                    ElseIf rdoCompareVar.Checked Then
                        chkPaired.Visible = False
                        nudHypothesis.Enabled = False
                        nudCI.Enabled = False
                    End If
                Else
                    chkPaired.Visible = False
                    rdoCompareMeans.Visible = False
                    rdoCompareVar.Visible = False
                    nudHypothesis.Enabled = True
                    nudCI.Enabled = True
                    lblLevel1.Visible = True
                    lblLevel2.Visible = True
                    ucrLevel1.Visible = True
                    ucrLevel2.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub nuds_TextChanged(sender As Object, e As EventArgs) Handles nudCI.TextChanged, nudHypothesis.TextChanged
        SetRCode()
    End Sub

    Private Sub chkboxes_VisibleChanged(sender As Object, e As EventArgs) Handles chkFunction.VisibleChanged
        Display()
        ExplanatoryFunctionSelect()
        ConvertToVariate()
        TestOKEnabled()
    End Sub

    Private Sub rdoTop_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGeneral.CheckedChanged, rdoSpecific.CheckedChanged
        If rdoGeneral.Checked Then
            ucrFamily.SetGLMDistributions()
        Else
            ucrFamily.SetExactDistributions()
        End If
        Display()
        SetRCode()
        TestOKEnabled()
        DataTypeAccepted()
        AssignModelName()
        ConvertToVariate()
    End Sub

    Private Sub ucrFamily_EnabledChanged(sender As Object, e As EventArgs) Handles ucrFamily.EnabledChanged
        DataTypeAccepted()
        TestOKEnabled()
        SetEnableDists()
    End Sub

    Private Sub rdoCompareMeans_VisibleChanged(sender As Object, e As EventArgs) Handles rdoCompareMeans.VisibleChanged, rdoCompareVar.VisibleChanged, chkPaired.VisibleChanged, rdoCompareMeans.CheckedChanged, rdoCompareVar.CheckedChanged, chkPaired.CheckedChanged
        Display()
        SetRCode()
    End Sub

    Private Sub ucrLevel_TextChanged(sender As Object, e As EventArgs) Handles ucrLevel1.TextChanged
        SetPoissonTest()
    End Sub

    Private Sub ucrLevel2_TextChanged(sender As Object, e As EventArgs) Handles ucrLevel2.TextChanged
        SetPoissonTest()
    End Sub
End Class