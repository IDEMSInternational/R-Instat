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
Public Class dlgThreeVariableModelling

    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public bResetSubdialog As Boolean = False
    Public bRCodeSet As Boolean = False
    Public clsFamilyFunction, clsAsNumeric, clsLM, clsGLM, clsLMOrGLM As New RFunction
    Public clsRSingleModelFunction As RFunction
    Dim clsFormulaOperator, clsExplanatoryOperator As New ROperator

    Private Sub dlgThreeVariableModelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
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
    End Sub

    Private Sub InitialiseDialog()

        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 369
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrChkConvertToNumeric.Enabled = False

        ucrSelectorThreeVariableModelling.SetParameter(New RParameter("data", 0))
        ucrSelectorThreeVariableModelling.SetParameterIsrfunction()

        'The main parameter will be in the as.numeric() function since it's always present there
        ucrReceiverResponse.SetParameter(New RParameter("x", 1))
        ucrReceiverResponse.SetParameterIsString()
        ucrReceiverResponse.bWithQuotes = False
        ucrReceiverResponse.Selector = ucrSelectorThreeVariableModelling

        ucrReceiverFirstExplanatory.SetParameter(New RParameter("exp1", 1))
        ucrReceiverFirstExplanatory.SetParameterIsString()
        ucrReceiverFirstExplanatory.bWithQuotes = False
        ucrReceiverFirstExplanatory.Selector = ucrSelectorThreeVariableModelling

        ucrReceiverSecondExplanatory.SetParameter(New RParameter("exp2", 1))
        ucrReceiverSecondExplanatory.SetParameterIsString()
        ucrReceiverSecondExplanatory.bWithQuotes = False
        ucrReceiverSecondExplanatory.Selector = ucrSelectorThreeVariableModelling

        ucrDistributionChoice.SetGLMDistributions()

        ucrSaveModel.SetPrefix("reg")
        ucrSaveModel.SetDataFrameSelector(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames)
        ucrSaveModel.SetSaveTypeAsModel()
        ucrSaveModel.SetCheckBoxText("Save Model")
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetAssignToIfUncheckedValue("last_model")

        ucrChkConvertToNumeric.SetText("Convert to  Variate")
        ucrChkConvertToNumeric.AddParameterIsRFunctionCondition(True, "y", True)
        ucrChkConvertToNumeric.AddParameterIsRFunctionCondition(False, "y", False)

        ucrChkFirstFunction.SetText("Function")
        ucrChkSecondFunction.SetText("Function")
        ucrChkResponseFunction.SetText("Function")

        ucrInputModelOperator.SetItems({"+", "*", ":", "/"})
        ucrInputModelOperator.SetDropDownStyleAsNonEditable()

        ucrModelPreview.IsReadOnly = True

        'sdgSimpleRegOptions.SetRModelFunction(ucrBaseThreeVariableModelling.clsRsyntax.clsBaseFunction)
        'sdgSimpleRegOptions.SetRDataFrame(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames)
        'sdgSimpleRegOptions.SetRYVariable(ucrReceiverResponse)
        'sdgSimpleRegOptions.SetRXVariable(ucrReceiverFirstExplanatory)
        'sdgVariableTransformations.SetRYVariable(ucrReceiverResponse)
        'sdgVariableTransformations.SetRModelOperator(clsModel1)
        'sdgModelOptions.SetRCIFunction(clsRCIFunction)
        'sdgVariableTransformations.SetRCIFunction(clsRCIFunction)
        ' AssignModelName()
    End Sub

    Private Sub SetDefaults()
        clsFamilyFunction = New RFunction
        clsAsNumeric = New RFunction
        clsLM = New RFunction
        clsGLM = New RFunction

        clsFormulaOperator = New ROperator
        clsExplanatoryOperator = New ROperator

        ucrSelectorThreeVariableModelling.Reset()
        ucrReceiverResponse.SetMeAsReceiver()

        clsExplanatoryOperator.SetOperation("+")
        clsExplanatoryOperator.bBrackets = False

        ucrSaveModel.Reset()
        ucrModelPreview.Reset()

        clsAsNumeric.SetRCommand("as.numeric")

        clsFormulaOperator.SetOperation("~")
        clsFormulaOperator.AddParameter("x", clsROperatorParameter:=clsExplanatoryOperator, iPosition:=1)

        clsFamilyFunction = ucrDistributionChoice.clsCurrRFunction

        clsLM = clsRegressionDefaults.clsDefaultLmFunction.Clone()
        clsLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)

        clsGLM = clsRegressionDefaults.clsDefaultGlmFunction.Clone()
        clsGLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)
        clsGLM.AddParameter("family", clsRFunctionParameter:=clsFamilyFunction)

        ' sdgSimpleRegOptions.SetDefaults()
        'sdgModelOptions.SetDefaults()
        'sdgSimpleRegOptions.chkDisplayCLimits.Enabled = True
        'sdgSimpleRegOptions.lblDisplayCLevel.Enabled = True
        ' sdgSimpleRegOptions.nudDisplayCLevel.Enabled = True

        ucrBase.clsRsyntax.SetBaseRFunction(clsLM)
        clsLM.SetAssignTo(ucrSaveModel.GetText, strTempDataframe:=ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:=ucrSaveModel.GetText, bAssignToIsPrefix:=True)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Object)
        bRCodeSet = False

        ucrSaveModel.AddAdditionalRCode(clsGLM, 1)
        ucrSelectorThreeVariableModelling.AddAdditionalCodeParameterPair(clsGLM, ucrSelectorThreeVariableModelling.GetParameter(), 1)
        ucrInputModelOperator.SetName(clsExplanatoryOperator.strOperation)
        ucrChkConvertToNumeric.SetRCode(clsFormulaOperator, bReset)
        ucrSelectorThreeVariableModelling.SetRCode(clsLM, bReset)
        ucrSaveModel.SetRCode(clsLM, bReset)
        ucrDistributionChoice.SetRCode(clsFamilyFunction, bReset)
        ucrReceiverResponse.SetRCode(clsAsNumeric, bReset)
        ucrReceiverFirstExplanatory.SetRCode(clsExplanatoryOperator, bReset)
        ucrReceiverSecondExplanatory.SetRCode(clsExplanatoryOperator, bReset)
        bRCodeSet = True
        TestOKEnabled()
    End Sub

    Public Sub TestOKEnabled()
        If Not ucrReceiverResponse.IsEmpty AndAlso Not ucrReceiverFirstExplanatory.IsEmpty AndAlso Not ucrReceiverSecondExplanatory.IsEmpty AndAlso Not ucrInputModelOperator.IsEmpty AndAlso Not ucrDistributionChoice.ucrInputDistributions.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub UpdatePreview()
        If Not ucrReceiverResponse.IsEmpty Then
            ucrModelPreview.SetName(clsFormulaOperator.ToScript)
        Else
            ucrModelPreview.SetName("")
        End If
    End Sub

    Public Sub ResponseConvert()
        If Not ucrReceiverResponse.IsEmpty Then
            ucrDistributionChoice.RecieverDatatype(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
            If ucrReceiverResponse.strCurrDataType = "numeric" OrElse ucrReceiverResponse.strCurrDataType = "integer" Then
                ucrChkConvertToNumeric.Checked = False
                ucrChkConvertToNumeric.Visible = False
            Else
                ucrChkConvertToNumeric.Visible = True
            End If
            If ucrChkConvertToNumeric.Checked Then
                clsFormulaOperator.AddParameter("y", clsRFunctionParameter:=clsAsNumeric, iPosition:=0)
                ucrDistributionChoice.RecieverDatatype("numeric")
            Else
                clsFormulaOperator.AddParameter("y", ucrReceiverResponse.GetVariableNames(False), iPosition:=0)
                ucrDistributionChoice.RecieverDatatype(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
            End If
        Else
            ucrChkConvertToNumeric.Visible = False
            'sdgModelOptions.ucrDistributionChoice.RecieverDatatype(ucrFamily.strDataType)
        End If
        If ucrDistributionChoice.lstCurrentDistributions.Count = 0 Or ucrReceiverResponse.IsEmpty() Then
            ucrDistributionChoice.Enabled = False
            ucrDistributionChoice.ucrInputDistributions.SetName("")
            cmdModelOptions.Enabled = False
        Else
            ucrDistributionChoice.Enabled = True
            cmdModelOptions.Enabled = True
        End If
    End Sub

    Private Sub ResponseControls_ControlValueChanged() Handles ucrReceiverResponse.ControlValueChanged, ucrChkConvertToNumeric.ControlValueChanged
        ResponseConvert()
        UpdatePreview()
    End Sub

    Private Sub ucrFirstExplanatory_SelectionChanged() Handles ucrReceiverFirstExplanatory.ControlValueChanged
        ExplanatoryFunctionSelect(ucrReceiverFirstExplanatory, ucrChkFirstFunction)
        UpdatePreview()
    End Sub

    Private Sub ExplanatoryFunctionSelect(currentReceiver As ucrReceiverSingle, ucrChkFunction As ucrCheck)
        'Dim strExplanatoryType As String
        'If Not currentReceiver.IsEmpty Then
        '    strExplanatoryType = frmMain.clsRLink.GetDataType(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, currentReceiver.GetVariableNames(bWithQuotes:=False))
        '    If strExplanatoryType = "numeric" Or strExplanatoryType = "positive integer" Or strExplanatoryType = "integer" Then
        '        ucrChkFunction.Visible = True
        '    Else
        '        ucrChkFunction.Checked = False
        '        ucrChkFunction.Visible = False
        '    End If
        '    If currentReceiver.Name = "ucrReceiverFirstExplanatory" Then
        '        'sdgVariableTransformations.SetRXVariable(ucrReceiverFirstExplanatory)
        '        If ucrChkFirstFunction.Checked Then
        '            '  sdgVariableTransformations.ModelFunction(True)
        '        Else
        '            'sdgVariableTransformations.rdoIdentity.Checked = True
        '            clsExplanatoryOperator.AddParameter(iPosition:=0, strParameterValue:=currentReceiver.GetVariableNames(False))
        '        End If
        '    End If
        '    If currentReceiver.Name = "ucrReceiverSecondExplanatory" Then
        '        'sdgVariableTransformations.SetRXVariable(ucrReceiverSecondExplanatory)
        '        If ucrChkSecondFunction.Checked Then
        '            'sdgVariableTransformations.ModelFunction(False)
        '        Else
        '            ' sdgVariableTransformations.rdoIdentity.Checked = True
        '            clsExplanatoryOperator.AddParameter(iPosition:=1, strParameterValue:=currentReceiver.GetVariableNames(False))
        '        End If
        '    End If
        '    'Applying function to response variable 
        '    'If currentReceiver.Name = "ucrResponse" Then
        '    'sdgVariableTransformations.SetRYVariable(ucrResponse)
        '    'If chkResponseFunction.Checked Then
        '    'sdgVariableTransformations.ModelFunction(True)
        '    'Else
        '    'sdgVariableTransformations.rdoIdentity.Checked = True
        '    'clsModel.AddParameter(True, strParameterValue:=currentReceiver.GetVariableNames(False))
        '    'End If
        'End If
        ''ucrModelPreview.SetName(clsModel.ToScript)
    End Sub

    Private Sub ucrReceiverSecondExplanatory_CheckedChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondExplanatory.ControlValueChanged, ucrChkSecondFunction.ControlValueChanged
        ExplanatoryFunctionSelect(ucrReceiverSecondExplanatory, ucrChkSecondFunction)
    End Sub

    Private Sub ucrBaseThreeVariableModelling_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.ShowDialog()
    End Sub

    Private Sub SetExplanatoryOperator()
        clsExplanatoryOperator.SetOperation(ucrInputModelOperator.GetText())
    End Sub

    Private Sub SetBaseFunction()
        If (ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal") Then
            clsLMOrGLM = clsLM
        Else
            clsLMOrGLM = clsGLM
        End If
        ucrBase.clsRsyntax.SetBaseRFunction(clsLMOrGLM)
        'Update display functions to contain correct model
        clsFormulaOperator.AddParameter("x", clsRFunctionParameter:=clsLMOrGLM)
        'clsAnovaFunction.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM)
        'clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM)
        'clsConfint.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM)
        'clsVisReg.AddParameter("fit", clsRFunctionParameter:=clsLMOrGLM)
        'clsAutoPlot.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM)
    End Sub

    Public Sub ucrFamily_cboDistributionsIndexChanged() Handles ucrDistributionChoice.DistributionsIndexChanged
        'TODO:   Include multinomial as an option And the appropriate function
        If (ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal") Then
        ElseIf (ucrDistributionChoice.clsCurrDistribution.strNameTag = "Gamma" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Poisson" Or ucrDistributionChoice.clsCurrDistribution.strNameTag = "Quasipoisson") Then
            clsFamilyFunction.SetRCommand(ucrDistributionChoice.clsCurrDistribution.strGLMFunctionName)
            ucrBase.clsRsyntax.SetFunction("glm")
            ucrBase.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsFamilyFunction)
            clsFamilyFunction.AddParameter("link", "log")
        ElseIf (ucrDistributionChoice.clsCurrDistribution.strNameTag = "Quasi") Then
            clsFamilyFunction.SetRCommand(ucrDistributionChoice.clsCurrDistribution.strGLMFunctionName)
            ucrBase.clsRsyntax.SetFunction("glm")
            ucrBase.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsFamilyFunction)
            clsFamilyFunction.AddParameter("link", "identity")
        ElseIf (ucrDistributionChoice.clsCurrDistribution.strNameTag = "Inverse_Gaussian") Then
            clsFamilyFunction.SetRCommand(ucrDistributionChoice.clsCurrDistribution.strGLMFunctionName)
            ucrBase.clsRsyntax.SetFunction("glm")
            ucrBase.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsFamilyFunction)
            clsFamilyFunction.AddParameter("link", "1/mu^2")
        Else
            clsFamilyFunction.SetRCommand(ucrDistributionChoice.clsCurrDistribution.strGLMFunctionName)
            ucrBase.clsRsyntax.SetFunction("glm")
            ucrBase.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsFamilyFunction)
            clsFamilyFunction.AddParameter("link", "logit")
        End If
    End Sub

    Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click
        sdgModelOptions.SetRFunction(clsFamilyFunction, bResetSubdialog)
        sdgModelOptions.ShowDialog()
        ucrDistributionChoice.ucrInputDistributions.cboInput.SelectedIndex = ucrDistributionChoice.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgModelOptions.ucrDistributionChoice.clsCurrDistribution.strNameTag)
        bResetSubdialog = False
    End Sub

    Private Sub ucrChkResponseFunction_CheckedChanged() Handles ucrChkResponseFunction.ControlValueChanged
        If ucrChkResponseFunction.Checked Then
            sdgVariableTransformations.ShowDialog()
        End If
        ExplanatoryFunctionSelect(ucrReceiverResponse, ucrChkResponseFunction)
    End Sub

    Private Sub ucrChkFirstFunction_CheckedChanged() Handles ucrChkFirstFunction.ControlValueChanged
        If ucrChkFirstFunction.Checked Then
            sdgVariableTransformations.ShowDialog()
        End If
        ExplanatoryFunctionSelect(ucrReceiverFirstExplanatory, ucrChkFirstFunction)
    End Sub

    Private Sub ucrChkSecondFunction_CheckedChanged() Handles ucrChkSecondFunction.ControlValueChanged
        If ucrChkSecondFunction.Checked Then
            sdgVariableTransformations.ShowDialog()
        End If
        ExplanatoryFunctionSelect(ucrReceiverSecondExplanatory, ucrChkSecondFunction)
    End Sub

    Private Sub ucrReceiverFirstExplanatory_contents() Handles ucrReceiverResponse.ControlContentsChanged, ucrReceiverFirstExplanatory.ControlContentsChanged, ucrReceiverSecondExplanatory.ControlContentsChanged, ucrInputModelOperator.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ExplanatoryControls_ControlValueChanged() Handles ucrInputModelOperator.ControlValueChanged, ucrReceiverFirstExplanatory.ControlValueChanged, ucrReceiverSecondExplanatory.ControlValueChanged
        SetExplanatoryOperator()
        UpdatePreview()
    End Sub

    Public Sub ConvertToNumeric()
        If bRCodeSet Then
            If Not ucrReceiverResponse.IsEmpty Then
                ucrDistributionChoice.RecieverDatatype(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
                If ucrDistributionChoice.strDataType = "numeric" Then
                    ucrChkConvertToNumeric.Checked = False
                    ucrChkConvertToNumeric.Visible = False
                Else
                    ucrChkConvertToNumeric.Visible = True
                End If
                If ucrChkConvertToNumeric.Checked Then
                    clsFormulaOperator.AddParameter("y", clsRFunctionParameter:=clsAsNumeric, iPosition:=0)
                    ucrDistributionChoice.RecieverDatatype("numeric")
                Else
                    clsFormulaOperator.AddParameter("y", ucrReceiverResponse.GetVariableNames(False), iPosition:=0)
                    ucrDistributionChoice.RecieverDatatype(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
                End If
            Else
                ucrChkConvertToNumeric.Visible = False
                If ucrDistributionChoice.lstCurrentDistributions.Count = 0 OrElse ucrReceiverResponse.IsEmpty() Then
                    ucrDistributionChoice.ucrInputDistributions.SetName("")
                    ucrDistributionChoice.Enabled = False
                    cmdModelOptions.Enabled = False
                Else
                    cmdModelOptions.Enabled = True
                    ucrDistributionChoice.Enabled = True
                End If
            End If
            UpdatePreview()
            TestOKEnabled()
        End If
    End Sub
End Class