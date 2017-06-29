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
Public Class dlgFourVariableModelling
    Public bFirstLoad As Boolean = True
    Public clsRCIFunction, clsRConvert As New RFunction
    Public clsRSingleModelFunction As RFunction
    Dim clsModel, clsModel1, clsModel2 As New ROperator

    Private Sub dlgFourVariableModelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBaseFourVariableModelling.clsRsyntax.iCallType = 2
        clsModel.SetOperation("~")
        ucrBaseFourVariableModelling.clsRsyntax.SetFunction("")
        ucrResponse.Selector = ucrSelectorFourVariableModelling
        ucrFirstExplanatory.Selector = ucrSelectorFourVariableModelling
        ucrSecondExplanatoryVariable.Selector = ucrSelectorFourVariableModelling
        ucrThirdExplanatoryVariable.Selector = ucrSelectorFourVariableModelling
        ucrBaseFourVariableModelling.iHelpTopicID = 385 'this is now the correct ID
        ucrFamily.SetGLMDistributions()
        ucrModelName.SetDataFrameSelector(ucrSelectorFourVariableModelling.ucrAvailableDataFrames)
        ucrModelName.SetPrefix("reg")
        ucrModelName.SetItemsTypeAsModels()
        ucrModelName.SetDefaultTypeAsModel()
        ucrInputModelOperators1.SetItems({"+", "*", ":", "/", "|"})
        ucrInputModelOperators2.SetItems({"+", "*", ":", "/", "|"})
        ucrModelName.SetValidationTypeAsRVariable()
        '  sdgSimpleRegOptions.SetRModelFunction(ucrBaseFourVariableModelling.clsRsyntax.clsBaseFunction)
        ucrModelPreview.IsReadOnly = True
        sdgSimpleRegOptions.SetRDataFrame(ucrSelectorFourVariableModelling.ucrAvailableDataFrames)
        'sdgSimpleRegOptions.SetRYVariable(ucrResponse)
        ' sdgSimpleRegOptions.SetRXVariable(ucrFirstExplanatory)
        'sdgVariableTransformations.SetRYVariable(ucrResponse)
        'sdgVariableTransformations.SetRModelOperator(clsModel1)
        'sdgModelOptions.SetRCIFunction(clsRCIFunction)
        'sdgVariableTransformations.SetRCIFunction(clsRCIFunction)
        AssignModelName()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorFourVariableModelling.Reset()
        ucrResponse.SetMeAsReceiver()
        ucrSelectorFourVariableModelling.Focus()
        ucrInputModelOperators1.cboInput.SelectedItem = "+"
        ucrInputModelOperators2.cboInput.SelectedItem = "|"
        chkSaveModel.Checked = True
        ucrModelName.Visible = True
        chkConvertToVariate.Checked = False
        chkConvertToVariate.Visible = False
        chkFirstFunction.Checked = False
        chkFirstFunction.Visible = False
        ucrModelName.SetName("reg")
        ' sdgSimpleRegOptions.SetDefaults()
        sdgModelOptions.SetDefaults()
        ResponseConvert()
        TestOKEnabled()
    End Sub

    Public Sub TestOKEnabled()
        If (Not ucrResponse.IsEmpty()) AndAlso (Not ucrFirstExplanatory.IsEmpty()) AndAlso (Not ucrSecondExplanatoryVariable.IsEmpty()) AndAlso (Not ucrThirdExplanatoryVariable.IsEmpty()) AndAlso (ucrInputModelOperators1.GetText <> "") Then
            clsModel2.bBrackets = False
            clsModel1.AddParameter(strParameterValue:="(" & clsModel2.ToScript.ToString & ")")
            clsModel1.SetOperation(ucrInputModelOperators1.GetText)
            clsModel1.bBrackets = False
            clsModel.AddParameter(clsROperatorParameter:=clsModel1)
            ucrBaseFourVariableModelling.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel)
            ucrBaseFourVariableModelling.OKEnabled(True)
            ucrModelPreview.SetName(clsModel.ToScript)
        Else
            ucrBaseFourVariableModelling.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectorThreeVariableModelling_DataFrameChanged() Handles ucrSelectorFourVariableModelling.DataFrameChanged
        ucrBaseFourVariableModelling.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorFourVariableModelling.ucrAvailableDataFrames.clsCurrDataFrame)
        AssignModelName()
    End Sub

    Public Sub ResponseConvert()
        If Not ucrResponse.IsEmpty Then
            ucrFamily.RecieverDatatype(ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))

            If ucrFamily.strDataType = "numeric" Then
                chkConvertToVariate.Checked = False
                chkConvertToVariate.Visible = False
            Else
                chkConvertToVariate.Visible = True
            End If

            If chkConvertToVariate.Checked Then
                clsRConvert.SetRCommand("as.numeric")
                clsRConvert.AddParameter("x", ucrResponse.GetVariableNames(bWithQuotes:=False))
                clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=clsRConvert)
                ucrFamily.RecieverDatatype("numeric")
            Else
                clsModel.AddParameter(iPosition:=0, strParameterValue:=ucrResponse.GetVariableNames(bWithQuotes:=False))
                ucrFamily.RecieverDatatype(ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))
            End If
            sdgModelOptions.ucrDistributionChoice.RecieverDatatype(ucrFamily.strDataType)
        End If

        If ucrFamily.lstCurrentDistributions.Count = 0 Or ucrResponse.IsEmpty() Then
            ucrFamily.Enabled = False
            ucrFamily.ucrInputDistributions.SetName("")
            cmdModelOptions.Enabled = False
        Else
            ucrFamily.Enabled = True
            cmdModelOptions.Enabled = True
        End If
    End Sub

    Private Sub ucrResponse_SelectionChanged() Handles ucrResponse.SelectionChanged
        ResponseConvert()
        TestOKEnabled()
    End Sub

    Private Sub ucrFirstExplanatory_SelectionChanged() Handles ucrFirstExplanatory.SelectionChanged
        ExplanatoryFunctionSelect(ucrFirstExplanatory)
        TestOKEnabled()
    End Sub

    Private Sub chkConvertToVariate_CheckedChanged(sender As Object, e As EventArgs) Handles chkConvertToVariate.CheckedChanged
        ResponseConvert()
        TestOKEnabled()
    End Sub

    Private Sub ExplanatoryFunctionSelect(currentReceiver As ucrReceiverSingle)
        Dim strExplanatoryType As String
        If Not currentReceiver.IsEmpty Then
            strExplanatoryType = frmMain.clsRLink.GetDataType(ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, currentReceiver.GetVariableNames(bWithQuotes:=False))
            If strExplanatoryType = "numeric" Or strExplanatoryType = "positive integer" Or strExplanatoryType = "integer" Then
                chkFirstFunction.Visible = True
            Else
                chkFirstFunction.Checked = False
                chkFirstFunction.Visible = False
            End If
            If currentReceiver.Name = "ucrFirstExplanatory" Then
                'sdgVariableTransformations.SetRXVariable(ucrFirstExplanatory)
                If chkFirstFunction.Checked Then
                    'sdgVariableTransformations.ModelFunction(True)
                Else
                    sdgVariableTransformations.rdoIdentity.Checked = True
                    clsModel1.AddParameter(True, strParameterValue:=currentReceiver.GetVariableNames(bWithQuotes:=False))
                End If
            End If
        End If
    End Sub

    Private Sub ucrFirstRandomEffect_SelectionChanged() Handles ucrSecondExplanatoryVariable.SelectionChanged
        clsModel2.AddParameter(iPosition:=0, strParameterValue:=ucrSecondExplanatoryVariable.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled()
    End Sub
    Private Sub ucrSecondRandomEffect_SelectionChanged() Handles ucrThirdExplanatoryVariable.SelectionChanged
        clsModel2.AddParameter(strParameterValue:=ucrThirdExplanatoryVariable.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled()
    End Sub

    Private Sub ucrBaseFourVariableModelling_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseFourVariableModelling.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrModelName_NameChanged() Handles ucrModelName.NameChanged
        AssignModelName()
        TestOKEnabled()
    End Sub

    Private Sub ucrBaseFourVariableModelling_ClickOk(sender As Object, e As EventArgs) Handles ucrBaseFourVariableModelling.ClickOk
        'sdgSimpleRegOptions.RegOptions()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.ShowDialog()
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
            ucrBaseFourVariableModelling.clsRsyntax.SetAssignTo(ucrModelName.GetText, strTempModel:=ucrModelName.GetText, strTempDataframe:=ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBaseFourVariableModelling.clsRsyntax.bExcludeAssignedFunctionOutput = True
        Else
            ucrBaseFourVariableModelling.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model", strTempDataframe:=ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBaseFourVariableModelling.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub

    Private Sub ucrInputModelOperators1_TextChanged(sender As Object, e As EventArgs) Handles ucrInputModelOperators1.TextChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrInputModelOperators2_TextChanged(sender As Object, e As EventArgs) Handles ucrInputModelOperators2.TextChanged
        ChooseRFunction()
        clsModel2.SetOperation(ucrInputModelOperators2.GetText)
        TestOKEnabled()
    End Sub

    Public Sub ChooseRFunction()
        sdgModelOptions.ucrDistributionChoice.RecieverDatatype(ucrFamily.strDataType)
        sdgModelOptions.ucrDistributionChoice.ucrInputDistributions.cboInput.SelectedIndex = sdgModelOptions.ucrDistributionChoice.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = ucrFamily.clsCurrDistribution.strNameTag)
        sdgModelOptions.RestrictLink()
        'TODO:   Include multinomial as an option And the appropriate function
        If (ucrFamily.clsCurrDistribution.strNameTag = "Normal" And ucrInputModelOperators2.GetText <> "|") Then
            'sdgSimpleRegOptions.chkDisplayCLimits.Enabled = True
            sdgSimpleRegOptions.lblConfLevel.Enabled = True
            'sdgSimpleRegOptions.nudDisplayCLevel.Enabled = True
            ucrBaseFourVariableModelling.clsRsyntax.SetFunction("lm")
            ucrBaseFourVariableModelling.clsRsyntax.RemoveParameter("family")
        ElseIf (ucrFamily.clsCurrDistribution.strNameTag = "Normal" And ucrInputModelOperators2.GetText = "|") Then
            ' sdgSimpleRegOptions.chkDisplayCLimits.Checked = False
            ' sdgSimpleRegOptions.chkDisplayCLimits.Enabled = False
            sdgSimpleRegOptions.lblConfLevel.Enabled = False
            ' sdgSimpleRegOptions.nudDisplayCLevel.Enabled = False
            ucrBaseFourVariableModelling.clsRsyntax.SetFunction("lmer")
            ucrBaseFourVariableModelling.clsRsyntax.RemoveParameter("family")
        ElseIf (ucrFamily.clsCurrDistribution.strNameTag <> "Normal" And ucrInputModelOperators2.GetText = "|") Then
            'sdgSimpleRegOptions.chkDisplayCLimits.Checked = False
            'sdgSimpleRegOptions.chkDisplayCLimits.Enabled = False
            sdgSimpleRegOptions.lblConfLevel.Enabled = False
            'sdgSimpleRegOptions.nudDisplayCLevel.Enabled = False
            clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
            ucrBaseFourVariableModelling.clsRsyntax.SetFunction("glmer")
            ucrBaseFourVariableModelling.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
        Else
            ' sdgSimpleRegOptions.chkDisplayCLimits.Enabled = True
            sdgSimpleRegOptions.lblConfLevel.Enabled = True
            'sdgSimpleRegOptions.nudDisplayCLevel.Enabled = True
            clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
            ucrBaseFourVariableModelling.clsRsyntax.SetFunction("glm")
            ucrBaseFourVariableModelling.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
        End If
    End Sub

    Public Sub ucrFamily_cboDistributionsIndexChanged() Handles ucrFamily.ControlValueChanged
        ChooseRFunction()
    End Sub

    Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click
        sdgModelOptions.ShowDialog()
        ucrFamily.ucrInputDistributions.cboInput.SelectedIndex = ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgModelOptions.ucrDistributionChoice.clsCurrDistribution.strNameTag)
    End Sub

    Private Sub chkFirstFunction_CheckedChanged(sender As Object, e As EventArgs) Handles chkFirstFunction.CheckedChanged
        If chkFirstFunction.Checked Then
            sdgVariableTransformations.ShowDialog()
        End If
        ExplanatoryFunctionSelect(ucrFirstExplanatory)
    End Sub
End Class