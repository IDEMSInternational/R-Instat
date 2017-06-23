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
    Public clsRCIFunction, clsRConvert, clsRLmOrGLM As New RFunction
    Public clsRSingleModelFunction As RFunction
    Dim clsModel, clsModel1 As New ROperator

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
        'Temporary fix: function autoplot does not support glm/lm models
        'sdgSimpleRegOptions.chkMultiplePlots.Enabled = False

        ucrBaseThreeVariableModelling.clsRsyntax.iCallType = 2
        ucrBaseThreeVariableModelling.clsRsyntax.SetFunction("")
        ucrBaseThreeVariableModelling.iHelpTopicID = 369
        ucrBaseThreeVariableModelling.clsRsyntax.bExcludeAssignedFunctionOutput = False
        clsModel1.bBrackets = False
        ucrChkConvertToVariate.Enabled = False

        ucrReceiverResponse.Selector = ucrSelectorThreeVariableModelling
        ucrReceiverFirstExplanatory.Selector = ucrSelectorThreeVariableModelling
        ucrReceiverSecondExplanatory.Selector = ucrSelectorThreeVariableModelling

        ucrSelectorThreeVariableModelling.SetParameter(New RParameter("data", 0))
        ucrSelectorThreeVariableModelling.SetParameterIsrfunction()

        ucrReceiverResponse.SetParameter(New RParameter("x", 1))
        ucrReceiverResponse.SetParameterIsString()
        ucrReceiverResponse.bWithQuotes = False


        ucrReceiverFirstExplanatory.SetParameter(New RParameter("var1", 1))
        ucrReceiverFirstExplanatory.SetParameterIsString()
        ucrReceiverFirstExplanatory.SetParameterIncludeArgumentName(False)
        ucrReceiverFirstExplanatory.bWithQuotes = False

        ucrReceiverSecondExplanatory.SetParameter(New RParameter("var2", 1))
        ucrReceiverSecondExplanatory.SetParameterIsString()
        ucrReceiverSecondExplanatory.SetParameterIncludeArgumentName(False)
        ucrReceiverSecondExplanatory.bWithQuotes = False


        ucrModelOperator.SetItems({"+", "*", ":", "/"})
        ucrFamily.SetGLMDistributions()

        ucrSaveModel.SetPrefix("reg")
        ucrSaveModel.SetDataFrameSelector(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames)
        ucrSaveModel.SetSaveTypeAsModel()
        ucrSaveModel.SetCheckBoxText("Save Model")
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetAssignToIfUncheckedValue("last_model")

        ucrModelPreview.IsReadOnly = True

        ucrChkConvertToVariate.AddParameterValueFunctionNamesCondition(True, "x", "as.numeric", True)
        ucrChkConvertToVariate.AddParameterValueFunctionNamesCondition(False, "x", "as.numeric", False)
        ucrChkConvertToVariate.SetText("Convert to  Variate")
        ucrChkFirstFunction.SetText("Function")
        ucrChkSecondFunction.SetText("Function")
        ucrChkResponseFunction.SetText("Function")



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

    Private Sub SetRCodeForControls(bReset As Object)
        ucrChkConvertToVariate.SetRCode(clsRConvert, bReset)
        ' ucrReceiverResponse.SetRCode(clsModel, bReset)
        'ucrReceiverFirstExplanatory.SetRCode(clsModel, bReset)
        ucrSaveModel.SetRCode(clsRLmOrGLM, bReset)
        ucrSelectorThreeVariableModelling.SetRCode(clsRLmOrGLM, bReset)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsRConvert, ucrReceiverResponse.GetParameter, iAdditionalPairNo:=1)

    End Sub

    Private Sub SetDefaults()
        clsRCIFunction = New RFunction
        clsRConvert = New RFunction
        clsRLmOrGLM = New RFunction
        clsModel = New ROperator
        clsModel1 = New ROperator

        ucrSelectorThreeVariableModelling.Reset()
        ucrReceiverResponse.SetMeAsReceiver()
        ucrSelectorThreeVariableModelling.Focus()

        ucrModelOperator.SetName("+")
        ucrModelOperator.Reset()
        ucrSaveModel.Reset()
        ucrModelPreview.Reset()


        clsRConvert.SetRCommand("as.numeric")

        clsModel.SetOperation("~")
        clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=clsRConvert)
        clsModel.AddParameter(iPosition:=1, clsROperatorParameter:=clsModel1)

        clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)


        clsRLmOrGLM.SetRCommand("lm")
        clsRLmOrGLM.AddParameter("formula", clsROperatorParameter:=clsModel, iPosition:=0)

        ResponseConvert()
        ModelOperator()

        ucrChkResponseFunction.Visible = False
        ucrChkSecondFunction.Visible = False
        ucrChkFirstFunction.Visible = False

        ' sdgSimpleRegOptions.SetDefaults()
        'sdgModelOptions.SetDefaults()
        'sdgSimpleRegOptions.chkDisplayCLimits.Enabled = True
        'sdgSimpleRegOptions.lblDisplayCLevel.Enabled = True
        ' sdgSimpleRegOptions.nudDisplayCLevel.Enabled = True

        ucrBaseThreeVariableModelling.clsRsyntax.SetBaseRFunction(clsRLmOrGLM)
        clsRLmOrGLM.SetAssignTo(ucrSaveModel.GetText, strTempDataframe:=ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:=ucrSaveModel.GetText, bAssignToIsPrefix:=True)
        bResetSubdialog = True

    End Sub

    Public Sub TestOKEnabled()
        If Not ucrReceiverResponse.IsEmpty AndAlso Not ucrReceiverFirstExplanatory.IsEmpty AndAlso Not ucrReceiverSecondExplanatory.IsEmpty AndAlso Not ucrModelOperator.IsEmpty Then
            ucrModelPreview.SetName(clsModel.ToScript)
            ucrBaseThreeVariableModelling.OKEnabled(True)
        Else
            ucrBaseThreeVariableModelling.OKEnabled(False)
        End If
    End Sub

    Public Sub ResponseConvert()
        If Not ucrReceiverResponse.IsEmpty Then
            ucrFamily.RecieverDatatype(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))

            If ucrReceiverResponse.strCurrDataType = "numeric" OrElse ucrReceiverResponse.strCurrDataType = "integer" Then
                ucrChkConvertToVariate.Checked = False
                ucrChkConvertToVariate.Visible = False
            Else
                ucrChkConvertToVariate.Visible = True
                ucrChkConvertToVariate.Checked = True
            End If
            If ucrChkConvertToVariate.Checked Then
                clsRConvert.SetRCommand("as.numeric")
                ucrFamily.RecieverDatatype("numeric")
            Else
                ' clsModel.AddParameter(iPosition:=0, strParameterValue:=ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
                ucrFamily.RecieverDatatype(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
            End If
            sdgModelOptions.ucrFamily.RecieverDatatype(ucrFamily.strDataType)
        Else
            ucrChkConvertToVariate.Visible = False
        End If
        If ucrFamily.lstCurrentDistributions.Count = 0 Or ucrReceiverResponse.IsEmpty() Then
            ucrFamily.Enabled = False
            ucrFamily.ucrInputDistributions.SetName("")
            cmdModelOptions.Enabled = False
        Else
            ucrFamily.Enabled = True
            cmdModelOptions.Enabled = True
        End If
    End Sub

    Private Sub ucrResponse_SelectionChanged() Handles ucrReceiverResponse.ControlValueChanged, ucrChkConvertToVariate.ControlValueChanged
        ResponseConvert()
    End Sub

    Private Sub ucrFirstExplanatory_SelectionChanged() Handles ucrReceiverFirstExplanatory.ControlValueChanged
        ExplanatoryFunctionSelect(ucrReceiverFirstExplanatory, ucrChkFirstFunction)
    End Sub

    Private Sub ExplanatoryFunctionSelect(currentReceiver As ucrReceiverSingle, ucrChkFunction As ucrCheck)
        Dim strExplanatoryType As String
        If Not currentReceiver.IsEmpty Then
            strExplanatoryType = frmMain.clsRLink.GetDataType(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, currentReceiver.GetVariableNames(bWithQuotes:=False))
            If strExplanatoryType = "numeric" Or strExplanatoryType = "positive integer" Or strExplanatoryType = "integer" Then
                ucrChkFunction.Visible = True

            Else

                ucrChkFunction.Checked = False
                ucrChkFunction.Visible = False
            End If
            If currentReceiver.Name = "ucrReceiverFirstExplanatory" Then
                'sdgVariableTransformations.SetRXVariable(ucrReceiverFirstExplanatory)
                If ucrChkFirstFunction.Checked Then
                    '  sdgVariableTransformations.ModelFunction(True)
                Else
                    'sdgVariableTransformations.rdoIdentity.Checked = True
                    clsModel1.AddParameter(iPosition:=0, strParameterValue:=currentReceiver.GetVariableNames(False))
                End If
            End If
            If currentReceiver.Name = "ucrReceiverSecondExplanatory" Then
                'sdgVariableTransformations.SetRXVariable(ucrReceiverSecondExplanatory)
                If ucrChkSecondFunction.Checked Then
                    'sdgVariableTransformations.ModelFunction(False)
                Else
                    ' sdgVariableTransformations.rdoIdentity.Checked = True
                    clsModel1.AddParameter(iPosition:=1, strParameterValue:=currentReceiver.GetVariableNames(False))
                End If
            End If
            'Applying function to response variable 
            'If currentReceiver.Name = "ucrResponse" Then
            'sdgVariableTransformations.SetRYVariable(ucrResponse)
            'If chkResponseFunction.Checked Then
            'sdgVariableTransformations.ModelFunction(True)
            'Else
            'sdgVariableTransformations.rdoIdentity.Checked = True
            'clsModel.AddParameter(True, strParameterValue:=currentReceiver.GetVariableNames(False))
            'End If
        End If
        'ucrModelPreview.SetName(clsModel.ToScript)
    End Sub

    Private Sub chkSecondFunction_CheckedChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondExplanatory.ControlValueChanged, ucrChkSecondFunction.ControlValueChanged
        ExplanatoryFunctionSelect(ucrReceiverSecondExplanatory, ucrChkSecondFunction)
    End Sub

    Private Sub ucrBaseThreeVariableModelling_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseThreeVariableModelling.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrBaseThreeVariableModelling_ClickOk(sender As Object, e As EventArgs) Handles ucrBaseThreeVariableModelling.ClickOk
        ' sdgSimpleRegOptions.RegOptions()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        '  sdgSimpleRegOptions.ShowDialog()
    End Sub

    Private Sub ModelOperator()
        If Not ucrReceiverFirstExplanatory.IsEmpty AndAlso Not ucrReceiverSecondExplanatory.IsEmpty AndAlso Not ucrModelOperator.IsEmpty Then
            Select Case ucrModelOperator.GetText
                Case "+"
                    clsModel1.SetOperation("+")
                Case "*"
                    clsModel1.SetOperation("*")
                Case ":"
                    clsModel1.SetOperation(":")
                Case "/"
                    clsModel1.SetOperation("/")
            End Select
        End If
    End Sub

    Public Sub ucrFamily_cboDistributionsIndexChanged() Handles ucrFamily.DistributionsIndexChanged
        sdgModelOptions.ucrFamily.RecieverDatatype(ucrFamily.strDataType)
        sdgModelOptions.ucrFamily.ucrInputDistributions.cboInput.SelectedIndex = sdgModelOptions.ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = ucrFamily.clsCurrDistribution.strNameTag)
        sdgModelOptions.RestrictLink()
        'TODO:   Include multinomial as an option And the appropriate function
        If (ucrFamily.clsCurrDistribution.strNameTag = "Normal") Then
            ucrBaseThreeVariableModelling.clsRsyntax.SetFunction("lm")
            ucrBaseThreeVariableModelling.clsRsyntax.RemoveParameter("family")
        ElseIf (ucrFamily.clsCurrDistribution.strNameTag = "Gamma" Or ucrFamily.clsCurrDistribution.strNameTag = "Poisson" Or ucrFamily.clsCurrDistribution.strNameTag = "Quasipoisson") Then
            clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
            ucrBaseThreeVariableModelling.clsRsyntax.SetFunction("glm")
            ucrBaseThreeVariableModelling.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
            clsRCIFunction.AddParameter("link", "log")

        ElseIf (ucrFamily.clsCurrDistribution.strNameTag = "Quasi") Then
            clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
            ucrBaseThreeVariableModelling.clsRsyntax.SetFunction("glm")
            ucrBaseThreeVariableModelling.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
            clsRCIFunction.AddParameter("link", "identity")

        ElseIf (ucrFamily.clsCurrDistribution.strNameTag = "Inverse_Gaussian") Then
            clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
            ucrBaseThreeVariableModelling.clsRsyntax.SetFunction("glm")
            ucrBaseThreeVariableModelling.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
            clsRCIFunction.AddParameter("link", "1/mu^2")
        Else
            clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
            ucrBaseThreeVariableModelling.clsRsyntax.SetFunction("glm")
            ucrBaseThreeVariableModelling.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
            clsRCIFunction.AddParameter("link", "logit")
        End If

    End Sub

    Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click
        sdgModelOptions.SetRFunction(clsRCIFunction, bResetSubdialog)
        sdgModelOptions.ShowDialog()
        ucrFamily.ucrInputDistributions.cboInput.SelectedIndex = ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgModelOptions.ucrFamily.clsCurrDistribution.strNameTag)
        bResetSubdialog = False
    End Sub
    Private Sub chkResponseFunction_CheckedChanged() Handles ucrChkResponseFunction.ControlValueChanged
        If ucrChkResponseFunction.Checked Then
            ' sdgVariableTransformations.ShowDialog()
        End If
        ExplanatoryFunctionSelect(ucrReceiverResponse, ucrChkResponseFunction)
    End Sub

    Private Sub chkFirstFunction_CheckedChanged() Handles ucrChkFirstFunction.ControlValueChanged
        If ucrChkFirstFunction.Checked Then
            'sdgVariableTransformations.ShowDialog()
        End If
        ExplanatoryFunctionSelect(ucrReceiverFirstExplanatory, ucrChkFirstFunction)
    End Sub

    Private Sub chkSecondFunction_CheckedChanged() Handles ucrChkSecondFunction.ControlValueChanged
        If ucrChkSecondFunction.Checked Then
            ' sdgVariableTransformations.ShowDialog()
        End If
        ExplanatoryFunctionSelect(ucrReceiverSecondExplanatory, ucrChkSecondFunction)
    End Sub

    Private Sub ucrReceiverFirstExplanatory_contents() Handles ucrReceiverResponse.ControlContentsChanged, ucrReceiverFirstExplanatory.ControlContentsChanged, ucrReceiverSecondExplanatory.ControlContentsChanged, ucrModelOperator.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrModelOperator_NameChanged() Handles ucrModelOperator.ControlValueChanged, ucrReceiverFirstExplanatory.ControlValueChanged, ucrReceiverSecondExplanatory.ControlValueChanged
        ModelOperator()
    End Sub
End Class