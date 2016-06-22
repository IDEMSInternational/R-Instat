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
    Public clsRCIFunction, clsRConvert As New RFunction
    Public clsRSingleModelFunction As RFunction
    Dim clsModel, clsModel1 As New ROperator
    Dim operation As String

    Private Sub dlgThreeVariableModelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBaseThreeVariableModelling.clsRsyntax.iCallType = 2
        clsModel.SetOperation("~")
        ucrResponse.Selector = ucrSelectorThreeVariableModelling
        ucrFirstExplanatory.Selector = ucrSelectorThreeVariableModelling
        ucrSecondExplanatory.Selector = ucrSelectorThreeVariableModelling
        lblModelPreview.Enabled = False
        ucrModelPreview.Enabled = False
        ucrBaseThreeVariableModelling.iHelpTopicID = 176
        ''''
        ucrFamily.SetGLMDistributions()
        sdgSimpleRegOptions.SetRModelFunction(ucrBaseThreeVariableModelling.clsRsyntax.clsBaseFunction)
        sdgSimpleRegOptions.SetRDataFrame(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames)
        sdgSimpleRegOptions.SetRYVariable(ucrResponse)
        sdgSimpleRegOptions.SetRXVariable(ucrFirstExplanatory)
        sdgVariableTransformations.SetRYVariable(ucrResponse)
        'sdgVariableTransformations.SetRXVariable(ucrFirstExplanatory)
        sdgVariableTransformations.SetRModelOperator(clsModel1)
        sdgModelOptions.SetRCIFunction(clsRCIFunction)
        sdgVariableTransformations.SetRCIFunction(clsRCIFunction)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorThreeVariableModelling.Reset()
        ucrResponse.SetMeAsReceiver()
        ucrSelectorThreeVariableModelling.Focus()
        operation = "+"
        chkSaveModel.Checked = True
        ucrModelName.Visible = True
        chkConvertToVariate.Checked = False
        chkConvertToVariate.Visible = False
        chkFirstFunction.Checked = False
        chkFirstFunction.Visible = False

        'ucrFamily.Enabled = False
        'TODO get this to be getting a default name e.g. reg1, reg2, etc.
        '     will be possible with new textbox user control
        ucrModelName.SetName("reg")
        sdgSimpleRegOptions.SetDefaults()
        sdgModelOptions.SetDefaults()
        ResponseConvert()
        TestOKEnabled()
    End Sub

    Public Sub TestOKEnabled()
        If (Not ucrResponse.IsEmpty()) And (Not ucrFirstExplanatory.IsEmpty()) And (Not ucrSecondExplanatory.IsEmpty()) And (operation <> "") Then
            clsModel1.SetOperation(operation)
            clsModel1.bBrackets = False
            clsModel.SetParameter(False, clsOp:=clsModel1)
            'clsModel.SetParameter(False, strValue:=ucrGroupingFactor.GetVariableNames(bWithQuotes:=False))
            ucrBaseThreeVariableModelling.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel)
            ucrBaseThreeVariableModelling.OKEnabled(True)
            ucrModelPreview.SetName(clsModel.ToScript)
        Else
            ucrBaseThreeVariableModelling.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectorThreeVariableModelling_DataFrameChanged() Handles ucrSelectorThreeVariableModelling.DataFrameChanged
        ucrBaseThreeVariableModelling.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub cmdRegressionOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.ShowDialog()
    End Sub

    Public Sub ResponseConvert()
        If Not ucrResponse.IsEmpty Then
            ucrFamily.RecieverDatatype(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))

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
                ucrFamily.RecieverDatatype(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))
            End If
            sdgModelOptions.ucrFamily.RecieverDatatype(ucrFamily.strDataType)
        End If
        If ucrFamily.lstCurrentDistributions.Count = 0 Then
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
    End Sub

    'Private Sub ExplanatoryFunctionSelect()
    '    Dim strExplanatoryType As String
    '    If Not ucrFirstExplanatory.IsEmpty Then
    '        strExplanatoryType = frmMain.clsRLink.GetDataType(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrFirstExplanatory.GetVariableNames(bWithQuotes:=False))
    '        If strExplanatoryType = "numeric" Or strExplanatoryType = "positive integer" Or strExplanatoryType = "integer" Then
    '            chkFunction.Visible = True
    '        Else
    '            chkFunction.Checked = False
    '            chkFunction.Visible = False
    '        End If
    '        If chkFunction.Checked Then
    '            sdgVariableTransformations.ModelFunction()
    '        Else
    '            sdgVariableTransformations.rdoIdentity.Checked = True
    '            clsModel1.SetParameter(True, strValue:=ucrFirstExplanatory.GetVariableNames(bWithQuotes:=False))
    '        End If
    '    End If
    '    ucrModelPreview.SetName(clsModel.ToScript)
    'End Sub

    Private Sub ExplanatoryFunctionSelect(currentReceiver As ucrReceiverSingle)
        Dim strExplanatoryType As String
        If Not ucrFirstExplanatory.IsEmpty Then
            strExplanatoryType = frmMain.clsRLink.GetDataType(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, currentReceiver.GetVariableNames(bWithQuotes:=False))
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
            If currentReceiver.Name = "ucrSecondExplanatory" Then
                sdgVariableTransformations.SetRXVariable(ucrSecondExplanatory)
                If chkSecondFunction.Checked Then
                    sdgVariableTransformations.ModelFunction(False)
                Else
                    sdgVariableTransformations.rdoIdentity.Checked = True
                    clsModel1.SetParameter(False, strValue:=currentReceiver.GetVariableNames(bWithQuotes:=False))
                End If
            End If
        End If
        ucrModelPreview.SetName(clsModel.ToScript)
    End Sub

    Private Sub ucrSecondExplanatory_SelectionChanged() Handles ucrSecondExplanatory.SelectionChanged
        ExplanatoryFunctionSelect(ucrSecondExplanatory)
        TestOKEnabled()
        'clsModel1.SetParameter(False, strValue:=ucrSecondExplanatory.GetVariableNames(bWithQuotes:=False))
        'TestOKEnabled()
    End Sub

    Private Sub ucrBaseThreeVariableModelling_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseThreeVariableModelling.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrModelName_NameChanged() Handles ucrModelName.NameChanged
        AssignModelName()
    End Sub

    Private Sub ucrBaseThreeVariableModelling_ClickOk(sender As Object, e As EventArgs) Handles ucrBaseThreeVariableModelling.ClickOk
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
    End Sub

    Private Sub AssignModelName()
        If chkSaveModel.Checked AndAlso ucrModelName.txtValidation.Text <> "" Then
            ucrBaseThreeVariableModelling.clsRsyntax.SetAssignTo(ucrModelName.txtValidation.Text, strTempModel:=ucrModelName.txtValidation.Text)
            ucrBaseThreeVariableModelling.clsRsyntax.bExcludeAssignedFunctionOutput = True
        Else
            ucrBaseThreeVariableModelling.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model")
            ucrBaseThreeVariableModelling.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub

    Public Sub ucrFamily_cboDistributionsIndexChanged(sender As Object, e As EventArgs) Handles ucrFamily.cboDistributionsIndexChanged
        sdgModelOptions.ucrFamily.RecieverDatatype(ucrFamily.strDataType)
        sdgModelOptions.ucrFamily.cboDistributions.SelectedIndex = sdgModelOptions.ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = ucrFamily.clsCurrDistribution.strNameTag)
        sdgModelOptions.RestrictLink()
        'TODO:   Include multinomial as an option And the appropriate function
        If (ucrFamily.clsCurrDistribution.strNameTag = "Normal") Then
            ucrBaseThreeVariableModelling.clsRsyntax.SetFunction("lm")
            ucrBaseThreeVariableModelling.clsRsyntax.RemoveParameter("family")
        Else
            clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
            ucrBaseThreeVariableModelling.clsRsyntax.SetFunction("glm")
            ucrBaseThreeVariableModelling.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
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

    Private Sub chkSecondFunction_CheckedChanged(sender As Object, e As EventArgs) Handles chkSecondFunction.CheckedChanged
        If chkSecondFunction.Checked Then
            sdgVariableTransformations.ShowDialog()
        End If
        ExplanatoryFunctionSelect(ucrSecondExplanatory)
    End Sub
End Class