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
    Dim operation As String

    Private Sub dlgFourVariableModelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'UcrInputComboBox1.SetItemsTypeAsModels()

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
        clsModel2.SetOperation("|")
        ucrBaseFourVariableModelling.clsRsyntax.SetFunction("")
        ucrResponse.Selector = ucrSelectorFourVariableModelling
        ucrFirstExplanatory.Selector = ucrSelectorFourVariableModelling
        ucrFirstRandomEffect.Selector = ucrSelectorFourVariableModelling
        ucrSecondRandomEffect.Selector = ucrSelectorFourVariableModelling
        ucrBaseFourVariableModelling.iHelpTopicID = 176 'this is not the correct ID
        ucrFamily.SetGLMDistributions()
        ucrModelName.SetPrefix("reg")
        ucrModelName.SetItemsTypeAsModels()
        ucrModelName.SetDefaultTypeAsModel()
        sdgSimpleRegOptions.SetRModelFunction(ucrBaseFourVariableModelling.clsRsyntax.clsBaseFunction)
        ucrModelPreview.IsReadOnly = True
        sdgSimpleRegOptions.SetRDataFrame(ucrSelectorFourVariableModelling.ucrAvailableDataFrames)
        sdgSimpleRegOptions.SetRYVariable(ucrResponse)
        sdgSimpleRegOptions.SetRXVariable(ucrFirstExplanatory)
        sdgVariableTransformations.SetRYVariable(ucrResponse)
        sdgVariableTransformations.SetRModelOperator(clsModel1)
        sdgModelOptions.SetRCIFunction(clsRCIFunction)
        sdgVariableTransformations.SetRCIFunction(clsRCIFunction)
        AssignModelName()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorFourVariableModelling.Reset()
        ucrResponse.SetMeAsReceiver()
        ucrSelectorFourVariableModelling.Focus()
        operation = "+"
        chkSaveModel.Checked = True
        ucrModelName.Visible = True
        chkConvertToVariate.Checked = False
        chkConvertToVariate.Visible = False
        chkFirstFunction.Checked = False
        chkFirstFunction.Visible = False
        ucrModelName.SetName("reg")
        sdgSimpleRegOptions.SetDefaults()
        sdgModelOptions.SetDefaults()
        ResponseConvert()
        TestOKEnabled()
    End Sub

    Public Sub TestOKEnabled()
        If (Not ucrResponse.IsEmpty()) And (Not ucrFirstExplanatory.IsEmpty()) And (Not ucrFirstRandomEffect.IsEmpty()) And (Not ucrSecondRandomEffect.IsEmpty()) And (operation <> "") Then
            clsModel2.bBrackets = False
            clsModel1.SetParameter(False, strValue:="(" & clsModel2.ToScript.ToString & ")")
            clsModel1.SetOperation(operation)
            clsModel1.bBrackets = False
            clsModel.SetParameter(False, clsOp:=clsModel1)
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

    Private Sub cmdRegressionOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.ShowDialog()
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
                clsModel.SetParameter(True, clsRFunc:=clsRConvert)
                ucrFamily.RecieverDatatype("numeric")
            Else
                clsModel.SetParameter(True, strValue:=ucrResponse.GetVariableNames(bWithQuotes:=False))
                ucrFamily.RecieverDatatype(ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))
            End If
            sdgModelOptions.ucrFamily.RecieverDatatype(ucrFamily.strDataType)
        End If

        If ucrFamily.lstCurrentDistributions.Count = 0 Or ucrResponse.IsEmpty() Then
            ucrFamily.Enabled = False
            ucrFamily.cboDistributions.Text = ""
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
                sdgVariableTransformations.SetRXVariable(ucrFirstExplanatory)
                If chkFirstFunction.Checked Then
                    sdgVariableTransformations.ModelFunction(True)
                Else
                    sdgVariableTransformations.rdoIdentity.Checked = True
                    clsModel1.SetParameter(True, strValue:=currentReceiver.GetVariableNames(bWithQuotes:=False))
                End If
            End If
        End If
        'ucrModelPreview.SetName(clsModel.ToScript)
    End Sub

    Private Sub ucrFirstRandomEffect_SelectionChanged() Handles ucrFirstRandomEffect.SelectionChanged
        clsModel2.SetParameter(True, strValue:=ucrFirstRandomEffect.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled()
    End Sub
    Private Sub ucrSecondRandomEffect_SelectionChanged() Handles ucrSecondRandomEffect.SelectionChanged
        clsModel2.SetParameter(False, strValue:=ucrSecondRandomEffect.GetVariableNames(bWithQuotes:=False))
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
        sdgSimpleRegOptions.RegOptions()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.ShowDialog()
    End Sub

    Private Sub cmdParallelLines_Click(sender As Object, e As EventArgs) Handles cmdParallelLines.Click
        operation = "+"
        TestOKEnabled()
    End Sub

    Private Sub cmdConditional_Click(sender As Object, e As EventArgs) Handles cmdConditional.Click
        operation = ":"
        TestOKEnabled()
    End Sub

    Private Sub cmdJointLines_Click(sender As Object, e As EventArgs) Handles cmdJointLines.Click
        operation = "*"
        TestOKEnabled()
    End Sub

    Private Sub cmdCommonIntercept_Click(sender As Object, e As EventArgs) Handles cmdCommonIntercept.Click
        operation = "/"
        TestOKEnabled()
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

    'Private Sub AssignModelName()
    '    If chkSaveModel.Checked AndAlso ucrModelName.txtValidation.Text <> "" Then
    '        ucrBaseFourVariableModelling.clsRsyntax.SetAssignTo(ucrModelName.txtValidation.Text, strTempModel:=ucrModelName.txtValidation.Text)
    '        ucrBaseFourVariableModelling.clsRsyntax.bExcludeAssignedFunctionOutput = True
    '    Else
    '        ucrBaseFourVariableModelling.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model")
    '        ucrBaseFourVariableModelling.clsRsyntax.bExcludeAssignedFunctionOutput = False
    '    End If
    'End Sub

    Public Sub ucrFamily_cboDistributionsIndexChanged(sender As Object, e As EventArgs) Handles ucrFamily.cboDistributionsIndexChanged
        sdgModelOptions.ucrFamily.RecieverDatatype(ucrFamily.strDataType)
        sdgModelOptions.ucrFamily.cboDistributions.SelectedIndex = sdgModelOptions.ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = ucrFamily.clsCurrDistribution.strNameTag)
        sdgModelOptions.RestrictLink()
        'TODO:   Include multinomial as an option And the appropriate function
        If (ucrFamily.clsCurrDistribution.strNameTag = "Normal") Then
            ucrBaseFourVariableModelling.clsRsyntax.SetFunction("lmer")
            ucrBaseFourVariableModelling.clsRsyntax.RemoveParameter("family")
        Else
            clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
            ucrBaseFourVariableModelling.clsRsyntax.SetFunction("glmer")
            ucrBaseFourVariableModelling.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
        End If
    End Sub

    Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click
        sdgModelOptions.ShowDialog()
        ucrFamily.cboDistributions.SelectedIndex = ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgModelOptions.ucrFamily.clsCurrDistribution.strNameTag)
    End Sub

    Private Sub chkFirstFunction_CheckedChanged(sender As Object, e As EventArgs) Handles chkFirstFunction.CheckedChanged
        If chkFirstFunction.Checked Then
            sdgVariableTransformations.ShowDialog()
        End If
        ExplanatoryFunctionSelect(ucrFirstExplanatory)
    End Sub
End Class