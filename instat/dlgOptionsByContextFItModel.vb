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

Public Class dlgOptionsByContextFitModel

    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public bResetModelOptions As Boolean = False
    Public bResetDisplayOptions As Boolean = False
    Public bResetFirstFunction As Boolean = False
    Public bResetSecondFunction As Boolean = False
    Public bRCodeSet As Boolean = False
    Public bDefaultsSet As Boolean = False

    Public clsFamilyFunction, clsVisReg As New RFunction
    Public clsRSingleModelFunction, clsFormulaFunction, clsAnovaFunction, clsSummaryFunction, clsConfint As RFunction
    Public clsGLM, clsLM, clsLMOrGLM, clsAsNumeric As RFunction

    'Saving Operators/Functions
    Private clsRstandardFunction, clsHatvaluesFunction, clsResidualFunction, clsFittedValuesFunction As New RFunction

    Public clsModelFormula As ROperator
    Private clsOverallInteractions As New ROperator
    Private clsContextsInteractions As New ROperator
    Private clsBlockingContextsAddition As New ROperator
    Private clsBlockingAddition As New ROperator
    Private clsOtherContextAdditions As New ROperator
    Private clsOptionsInteractions As New ROperator

    Private dctPlotFunctions As New Dictionary(Of String, RFunction)

    Private Sub dlgOptionsByContextFItModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()

        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 369
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorFitModel.SetParameter(New RParameter("data", 0))
        ucrSelectorFitModel.SetParameterIsrfunction()

        'The main parameter will be in the as.numeric() function since it's always present there
        ucrReceiverResponse.SetParameter(New RParameter("x", 0))
        ucrReceiverResponse.SetOptionsByContextTypesAllMeasurements()
        ucrReceiverResponse.SetParameterIsString()
        ucrReceiverResponse.bWithQuotes = False
        ucrReceiverResponse.strSelectorHeading = "Measurements"
        ucrReceiverResponse.Selector = ucrSelectorFitModel

        ucrReceiverBlocking.SetParameter(New RParameter("0", 0))
        ucrReceiverBlocking.SetOptionsByContextTypesAllBlockings()
        ucrReceiverBlocking.SetParameterIsString()
        ucrReceiverBlocking.bWithQuotes = False
        ucrReceiverBlocking.strSelectorHeading = "Blocking Variables"
        ucrReceiverBlocking.Selector = ucrSelectorFitModel

        ucrReceiverContext1.SetParameter(New RParameter("0", 0))
        ucrReceiverContext1.SetOptionsByContextTypesAllOptionsContextsBlockings()
        ucrReceiverContext1.SetParameterIsString()
        ucrReceiverContext1.bWithQuotes = False
        ucrReceiverContext1.Selector = ucrSelectorFitModel
        ucrReceiverContext1.strSelectorHeading = "Contexts,Options,Blocks"

        ucrReceiverContext2.SetParameter(New RParameter("1", 1))
        ucrReceiverContext2.SetOptionsByContextTypesAllOptionsContextsBlockings()
        ucrReceiverContext2.SetParameterIsString()
        ucrReceiverContext2.bWithQuotes = False
        ucrReceiverContext2.Selector = ucrSelectorFitModel
        ucrReceiverContext2.strSelectorHeading = "Contexts,Options,Blocks"

        ucrReceiverContext3.SetParameter(New RParameter("2", 2))
        ucrReceiverContext3.SetOptionsByContextTypesAllOptionsContextsBlockings()
        ucrReceiverContext3.SetParameterIsString()
        ucrReceiverContext3.bWithQuotes = False
        ucrReceiverContext3.Selector = ucrSelectorFitModel
        ucrReceiverContext3.strSelectorHeading = "Contexts,Options,Blocks"

        ucrReceiverContext4.SetParameter(New RParameter("3", 3))
        ucrReceiverContext4.SetOptionsByContextTypesAllOptionsContextsBlockings()
        ucrReceiverContext4.SetParameterIsString()
        ucrReceiverContext4.bWithQuotes = False
        ucrReceiverContext4.Selector = ucrSelectorFitModel
        ucrReceiverContext4.strSelectorHeading = "Contexts,Options,Blocks"

        ucrReceiverContextOther.SetParameter(New RParameter("2", 2))
        ucrReceiverContextOther.SetOptionsByContextTypesAllOptionsContextsBlockings()
        ucrReceiverContextOther.SetParameterIsString()
        ucrReceiverContextOther.bWithQuotes = False
        ucrReceiverContextOther.Selector = ucrSelectorFitModel
        ucrReceiverContextOther.strSelectorHeading = "Contexts,Options,Blocks"

        ucrReceiverOptions.SetParameter(New RParameter("right", 1))
        ucrReceiverOptions.SetOptionsByContextTypesAllOptions()
        ucrReceiverOptions.SetParameterIsString()
        ucrReceiverOptions.bWithQuotes = False
        ucrReceiverOptions.Selector = ucrSelectorFitModel
        ucrReceiverOptions.strSelectorHeading = "Options"

        ucrDistributionChoice.SetGLMDistributions()
        ucrDistributionChoice.SetFunctionIsDistFunction()

        ucrSaveModel.SetPrefix("reg")
        ucrSaveModel.SetDataFrameSelector(ucrSelectorFitModel.ucrAvailableDataFrames)
        ucrSaveModel.SetSaveTypeAsModel()
        ucrSaveModel.SetCheckBoxText("Save Model")
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetAssignToIfUncheckedValue("last_model")

        ucrChkConvertToNumeric.SetText("Convert to Variate")
        ucrChkConvertToNumeric.AddParameterIsRFunctionCondition(True, "y", True)
        ucrChkConvertToNumeric.AddParameterIsRFunctionCondition(False, "y", False)

        ucrModelPreview.IsReadOnly = True
    End Sub

    Private Sub SetDefaults()
        clsFamilyFunction = New RFunction
        clsAsNumeric = New RFunction
        clsLM = New RFunction
        clsGLM = New RFunction
        clsFormulaFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsConfint = New RFunction
        clsVisReg = New RFunction

        clsModelFormula = New ROperator
        clsOverallInteractions = New ROperator
        clsContextsInteractions = New ROperator
        clsBlockingContextsAddition = New ROperator
        clsBlockingAddition = New ROperator
        clsOtherContextAdditions = New ROperator
        clsOptionsInteractions = New ROperator

        clsRstandardFunction = New RFunction
        clsHatvaluesFunction = New RFunction
        clsResidualFunction = New RFunction
        clsFittedValuesFunction = New RFunction

        bDefaultsSet = False

        ucrSelectorFitModel.Reset()
        ucrReceiverResponse.SetMeAsReceiver()

        ucrBase.clsRsyntax.ClearCodes()

        ucrDistributionChoice.SetDataType("numeric")
        ucrSaveModel.Reset()
        ucrModelPreview.Reset()

        clsAsNumeric.SetRCommand("as.numeric")

        clsModelFormula = clsRegressionDefaults.clsDefaultFormulaOperator.Clone
        clsModelFormula.AddParameter("1", clsROperatorParameter:=clsOverallInteractions, iPosition:=1)

        clsOverallInteractions.SetOperation("*")
        clsOverallInteractions.AddParameter("0", clsROperatorParameter:=clsBlockingContextsAddition, iPosition:=0)
        clsOverallInteractions.bAllBrackets = True

        clsOptionsInteractions.SetOperation("*")

        clsBlockingContextsAddition.SetOperation("+")
        clsBlockingContextsAddition.bAllBrackets = True

        clsContextsInteractions.SetOperation("*")

        clsOtherContextAdditions.SetOperation("+")

        clsBlockingAddition.SetOperation("+")

        clsLM = clsRegressionDefaults.clsDefaultLmFunction.Clone()
        clsLM.AddParameter("formula", clsROperatorParameter:=clsModelFormula, iPosition:=0)

        clsGLM = clsRegressionDefaults.clsDefaultGlmFunction.Clone()
        clsGLM.AddParameter("formula", clsROperatorParameter:=clsModelFormula, iPosition:=0)

        clsFamilyFunction = ucrDistributionChoice.clsCurrRFunction
        clsGLM.AddParameter("family", clsRFunctionParameter:=clsFamilyFunction)

        'Residual Plots
        dctPlotFunctions = New Dictionary(Of String, RFunction)(clsRegressionDefaults.dctModelPlotFunctions)

        'Model
        clsFormulaFunction = clsRegressionDefaults.clsDefaultFormulaFunction.Clone
        clsFormulaFunction.iCallType = 2

        'Summary
        clsSummaryFunction = clsRegressionDefaults.clsDefaultSummary.Clone
        clsSummaryFunction.iCallType = 2

        'ANOVA
        clsAnovaFunction = clsRegressionDefaults.clsDefaultAnovaFunction.Clone
        clsAnovaFunction.iCallType = 2

        'Confidence Interval
        clsConfint = clsRegressionDefaults.clsDefaultConfint.Clone
        clsConfint.iCallType = 2

        'FitModel
        clsVisReg.SetPackageName("visreg")
        clsVisReg.SetRCommand("visreg")
        clsVisReg.AddParameter("type", Chr(34) & "conditional" & Chr(34))
        'changed gg parameter to FALSE since when TRUE no plot is given (not compatible with ggplot2 package)
        clsVisReg.AddParameter("gg", "FALSE")
        clsVisReg.iCallType = 3
        clsVisReg.bExcludeAssignedFunctionOutput = False

        clsResidualFunction.SetRCommand("residuals")
        clsFittedValuesFunction.SetRCommand("fitted.values")
        clsRstandardFunction.SetRCommand("rstandard")
        clsHatvaluesFunction.SetRCommand("hatvalues")

        clsLM.SetAssignTo(ucrSaveModel.GetText, strTempDataframe:=ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:=ucrSaveModel.GetText, bAssignToIsPrefix:=True)
        clsGLM.SetAssignTo(ucrSaveModel.GetText, strTempDataframe:=ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:=ucrSaveModel.GetText, bAssignToIsPrefix:=True)
        ucrBase.clsRsyntax.SetBaseRFunction(clsLM)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True

        ucrBase.clsRsyntax.AddToAfterCodes(clsFormulaFunction, iPosition:=0)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAnovaFunction, iPosition:=1)
        clsLMOrGLM = clsLM

        bResetModelOptions = True
        bResetDisplayOptions = True
        bResetFirstFunction = True
        bResetSecondFunction = True
        bDefaultsSet = True
        AutoAddDefaults()
    End Sub

    Private Sub SetRCodeForControls(bResetControls As Boolean)
        bRCodeSet = False

        ucrSaveModel.AddAdditionalRCode(clsGLM, 1)
        ucrSelectorFitModel.AddAdditionalCodeParameterPair(clsGLM, ucrSelectorFitModel.GetParameter(), 1)

        ucrReceiverContext1.SetRCode(clsContextsInteractions, bResetControls)
        ucrReceiverContext2.SetRCode(clsContextsInteractions, bResetControls)
        ucrReceiverContext3.SetRCode(clsContextsInteractions, bResetControls)
        ucrReceiverContext4.SetRCode(clsContextsInteractions, bResetControls)
        ucrChkConvertToNumeric.SetRCode(clsModelFormula, bResetControls)
        ucrSelectorFitModel.SetRCode(clsLM, bResetControls)
        ucrSaveModel.SetRCode(clsLM, bResetControls)
        ucrDistributionChoice.SetRCode(clsFamilyFunction, bResetControls)
        ucrReceiverResponse.SetRCode(clsAsNumeric, bResetControls)
        bRCodeSet = True
        TestOKEnabled()
        UpdateContextVariables()
        UpdateBlockingVariables()
        UpdateOptionVariables()
        UpdateOtherContextVariables()
        UpdatePreview()
    End Sub

    Public Sub TestOKEnabled()
        If Not ucrReceiverResponse.IsEmpty AndAlso (Not ucrReceiverBlocking.IsEmpty OrElse Not ucrReceiverContext1.IsEmpty OrElse Not ucrReceiverContext2.IsEmpty OrElse Not ucrReceiverContext3.IsEmpty OrElse ucrReceiverContext4.IsEmpty OrElse ucrReceiverContextOther.IsEmpty OrElse ucrReceiverOptions.IsEmpty) AndAlso Not ucrDistributionChoice.ucrInputDistributions.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub UpdatePreview()
        If Not ucrReceiverResponse.IsEmpty Then
            ucrModelPreview.SetName(clsModelFormula.ToScript)
        Else
            ucrModelPreview.SetName("")
        End If
    End Sub

    Public Sub ResponseConvert()
        If bRCodeSet Then
            If Not ucrReceiverResponse.IsEmpty Then
                ucrDistributionChoice.RecieverDatatype(ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
                If ucrReceiverResponse.strCurrDataType = "numeric" Then
                    ucrChkConvertToNumeric.Checked = False
                    ucrChkConvertToNumeric.Visible = False
                Else
                    ucrChkConvertToNumeric.Visible = True
                End If
                If ucrChkConvertToNumeric.Checked Then
                    clsModelFormula.AddParameter("y", clsRFunctionParameter:=clsAsNumeric, iPosition:=0)
                    ucrDistributionChoice.RecieverDatatype("numeric")
                Else
                    clsModelFormula.AddParameter("y", ucrReceiverResponse.GetVariableNames(False), iPosition:=0)
                    ucrDistributionChoice.RecieverDatatype(ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
                End If
            Else
                ucrChkConvertToNumeric.Visible = False
            End If
            If ucrDistributionChoice.lstCurrentDistributions.Count = 0 OrElse ucrReceiverResponse.IsEmpty() Then
                ucrDistributionChoice.Enabled = False
                ucrDistributionChoice.ucrInputDistributions.SetName("")
                cmdModelOptions.Enabled = False
            Else
                ucrDistributionChoice.Enabled = True
                cmdModelOptions.Enabled = True
            End If
            UpdatePreview()
            TestOKEnabled()
        End If
    End Sub

    Private Sub ResponseControls_ControlValueChanged(ucrChangeControl As ucrCore) Handles ucrReceiverResponse.ControlValueChanged, ucrChkConvertToNumeric.ControlValueChanged, ucrReceiverContext1.ControlValueChanged, ucrReceiverContext2.ControlValueChanged, ucrReceiverContext3.ControlValueChanged, ucrReceiverContext4.ControlValueChanged, ucrReceiverContextOther.ControlValueChanged, ucrReceiverOptions.ControlValueChanged, ucrReceiverBlocking.ControlValueChanged
        SetBaseFunction()
        ResponseConvert()
        If ucrChangeControl.Equals(ucrReceiverBlocking) Then
            UpdateBlockingVariables()
        ElseIf ucrChangeControl.Equals(ucrReceiverContextOther) Then
            UpdateOtherContextVariables()
        ElseIf ucrChangeControl.Equals(ucrReceiverOptions) Then
            UpdateOptionVariables()
        ElseIf ucrChangeControl.Equals(ucrReceiverContext1) OrElse ucrChangeControl.Equals(ucrReceiverContext2) OrElse ucrChangeControl.Equals(ucrReceiverContext2) OrElse ucrChangeControl.Equals(ucrReceiverContext3) OrElse ucrChangeControl.Equals(ucrReceiverContext4) Then
            UpdateContextVariables()
        End If
        UpdatePreview()
    End Sub

    Private Sub ucrBaseThreeVariableModelling_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.SetRCode(clsNewRSyntax:=ucrBase.clsRsyntax, clsNewFormulaFunction:=clsFormulaFunction, clsNewAnovaFunction:=clsAnovaFunction, clsNewRSummaryFunction:=clsSummaryFunction, clsNewConfint:=clsConfint, clsNewVisReg:=clsVisReg, dctNewPlot:=dctPlotFunctions, clsNewResidualFunction:=clsResidualFunction, clsNewFittedValuesFunction:=clsFittedValuesFunction, clsNewRstandardFunction:=clsRstandardFunction, clsNewHatvaluesFunction:=clsHatvaluesFunction, ucrNewAvailableDatafrane:=ucrSelectorFitModel.ucrAvailableDataFrames, bReset:=bResetDisplayOptions)
        sdgSimpleRegOptions.ShowDialog()
        GraphAssignTo()
        bResetDisplayOptions = False
    End Sub

    Private Sub SetBaseFunction()
        If Not ucrReceiverResponse.IsEmpty Then
            If (ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal") AndAlso (Not clsFamilyFunction.ContainsParameter("link") OrElse clsFamilyFunction.GetParameter("link").strArgumentValue = Chr(34) & "identity" & Chr(34)) Then
                clsLMOrGLM = clsLM
            Else
                clsLMOrGLM = clsGLM
            End If

            'Update display functions to contain correct model
            clsFormulaFunction.AddParameter("x", clsRFunctionParameter:=clsLMOrGLM)
            clsAnovaFunction.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            clsConfint.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            clsVisReg.AddParameter("fit", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)

            For Each kvp As KeyValuePair(Of String, RFunction) In dctPlotFunctions
                kvp.Value.AddParameter("x", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            Next

            clsResidualFunction.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            clsFittedValuesFunction.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            clsRstandardFunction.AddParameter("model", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            clsHatvaluesFunction.AddParameter("model", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsLMOrGLM)
        End If
    End Sub

    Public Sub ucrFamily_cboDistributionsIndexChanged() Handles ucrDistributionChoice.DistributionsIndexChanged
        SetBaseFunction()
        clsFamilyFunction.RemoveParameterByName("link")
    End Sub

    Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click
        Dim clsTempParam As RParameter = Nothing

        sdgModelOptions.SetRCodeForControls(ucrDistributionChoice, clsFamilyFunction, bResetModelOptions)
        sdgModelOptions.ShowDialog()
        bResetModelOptions = False
        If clsFamilyFunction.ContainsParameter("link") Then
            clsTempParam = clsFamilyFunction.GetParameter("link")
        End If
        ucrDistributionChoice.ucrInputDistributions.cboInput.SelectedIndex = ucrDistributionChoice.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgModelOptions.ucrDistributionChoice.clsCurrDistribution.strNameTag)
        If clsTempParam IsNot Nothing Then
            clsFamilyFunction.AddParameter(clsTempParam)
        End If
        SetBaseFunction()
    End Sub

    Private Sub Controls_ControlContentsChanged() Handles ucrReceiverResponse.ControlContentsChanged, ucrReceiverBlocking.ControlContentsChanged, ucrReceiverContext1.ControlContentsChanged, ucrReceiverContext2.ControlContentsChanged, ucrReceiverContext3.ControlContentsChanged, ucrReceiverContext4.ControlContentsChanged, ucrReceiverContextOther.ControlContentsChanged, ucrReceiverOptions.ControlContentsChanged, ucrDistributionChoice.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorFitModel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorFitModel.ControlValueChanged
        SetBaseFunction()
        GraphAssignTo()
        AutoAddDefaults()
    End Sub

    Private Sub GraphAssignTo()
        'temp fix for graph display problem with RDotNet
        clsVisReg.SetAssignTo("last_visreg", strTempDataframe:=ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_visreg")

        'Dim lstPlotNames As New List(Of String)
        'Dim i As Integer = 0

        'lstPlotNames = New List(Of String)({"last_residplot", "last_qqplot", "last_scaleloc", "last_cooksdist", "last_residlev", "last_cookslev"})

        'For Each kvp As KeyValuePair(Of String, RFunction) In dctPlotFunctions
        '    kvp.Value.SetAssignTo(lstPlotNames(index:=i), strTempDataframe:=ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=lstPlotNames(index:=i))
        '    i = i + 1
        'Next
    End Sub

    Private Sub AutoAddDefaults()
        If bDefaultsSet Then
            ucrReceiverResponse.AddItemsWithMetadataProperty(ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"measurement_1_label"})
            ucrReceiverOptions.AddItemsWithMetadataProperty(ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"option_1_label"})
            ucrReceiverContext1.AddItemsWithMetadataProperty(ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_1_label"})
            ucrReceiverContext2.AddItemsWithMetadataProperty(ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_2_label"})
            ucrReceiverContext3.AddItemsWithMetadataProperty(ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_3_label"})
            ucrReceiverContext4.AddItemsWithMetadataProperty(ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_4_label"})
            ucrReceiverBlocking.AddItemsWithMetadataProperty(ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"blocking_1_label"})
        End If
    End Sub

    Private Sub UpdateBlockingVariables()
        Dim i As Integer = 0

        If bRCodeSet Then
            clsBlockingAddition.ClearParameters()
            If Not ucrReceiverBlocking.IsEmpty Then
                For Each strBlockingVar As String In ucrReceiverBlocking.GetVariableNamesAsList()
                    clsBlockingAddition.AddParameter(i, strBlockingVar, iPosition:=i)
                    i = i + 1
                Next
            End If
            If clsBlockingAddition.clsParameters.Count = 0 Then
                clsBlockingContextsAddition.RemoveParameterByName("0")
            Else
                clsBlockingContextsAddition.AddParameter("0", clsROperatorParameter:=clsBlockingAddition, iPosition:=0)
            End If
        End If
    End Sub

    Private Sub UpdateOtherContextVariables()
        Dim i As Integer = 0

        If bRCodeSet Then
            clsOtherContextAdditions.ClearParameters()
            If Not ucrReceiverContextOther.IsEmpty Then
                For Each strContextVar As String In ucrReceiverContextOther.GetVariableNamesAsList()
                    clsOtherContextAdditions.AddParameter(i, strContextVar, iPosition:=i)
                    i = i + 1
                Next
            End If
            If clsOtherContextAdditions.clsParameters.Count = 0 Then
                clsBlockingContextsAddition.RemoveParameterByName("2")
            Else
                clsBlockingContextsAddition.AddParameter("2", clsROperatorParameter:=clsOtherContextAdditions, iPosition:=2)
            End If
        End If
    End Sub

    Private Sub UpdateOptionVariables()
        Dim i As Integer = 0

        If bRCodeSet Then
            clsOptionsInteractions.ClearParameters()
            If Not ucrReceiverOptions.IsEmpty Then
                For Each strOptionVar As String In ucrReceiverOptions.GetVariableNamesAsList()
                    clsOptionsInteractions.AddParameter(i, strOptionVar, iPosition:=i)
                    i = i + 1
                Next
            End If
            If clsOptionsInteractions.clsParameters.Count = 0 Then
                clsOverallInteractions.RemoveParameterByName("1")
            Else
                clsOverallInteractions.AddParameter("1", clsROperatorParameter:=clsOptionsInteractions, iPosition:=1)
            End If
        End If
    End Sub

    Private Sub UpdateContextVariables()
        If bRCodeSet Then
            If Not ucrReceiverContext1.IsEmpty() OrElse Not ucrReceiverContext2.IsEmpty() OrElse Not ucrReceiverContext3.IsEmpty() OrElse Not ucrReceiverContext4.IsEmpty() Then
                clsBlockingContextsAddition.AddParameter("1", clsROperatorParameter:=clsContextsInteractions, iPosition:="1")
            Else
                clsBlockingContextsAddition.RemoveParameterByName("1")
            End If
        End If
    End Sub
End Class