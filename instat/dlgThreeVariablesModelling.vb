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
        'Temporary fix: function autoplot does not support glm/lm models
        sdgSimpleRegOptions.chkMultiplePlots.Enabled = False
        ucrBaseThreeVariableModelling.clsRsyntax.iCallType = 2
        ucrBaseThreeVariableModelling.clsRsyntax.SetFunction("")
        ucrBaseThreeVariableModelling.iHelpTopicID = 369
        clsModel.SetOperation("~")
        clsModel.AddParameter(clsROperatorParameter:=clsModel1)
        clsModel1.bBrackets = False
        ucrResponse.Selector = ucrSelectorThreeVariableModelling
        ucrFirstExplanatory.Selector = ucrSelectorThreeVariableModelling
        ucrSecondExplanatory.Selector = ucrSelectorThreeVariableModelling
        ucrModelOperator.SetItems({"+", "*", ":", "/"})
        ucrFamily.SetGLMDistributions()
        ucrModelName.SetDataFrameSelector(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames)
        ucrModelName.SetPrefix("reg")
        ucrModelName.SetItemsTypeAsModels()
        ucrModelName.SetDefaultTypeAsModel()
        ucrModelPreview.IsReadOnly = True
        sdgSimpleRegOptions.SetRModelFunction(ucrBaseThreeVariableModelling.clsRsyntax.clsBaseFunction)
        sdgSimpleRegOptions.SetRDataFrame(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames)
        sdgSimpleRegOptions.SetRYVariable(ucrResponse)
        sdgSimpleRegOptions.SetRXVariable(ucrFirstExplanatory)
        'sdgVariableTransformations.SetRYVariable(ucrResponse)
        'sdgVariableTransformations.SetRModelOperator(clsModel1)
        'sdgModelOptions.SetRCIFunction(clsRCIFunction)
        'sdgVariableTransformations.SetRCIFunction(clsRCIFunction)
        AssignModelName()
        ucrModelName.SetValidationTypeAsRVariable()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorThreeVariableModelling.Reset()
        ucrResponse.SetMeAsReceiver()
        ucrSelectorThreeVariableModelling.Focus()
        ucrModelOperator.SetName("+")
        ucrModelOperator.Reset()
        chkSaveModel.Checked = True
        ucrModelName.Visible = True
        chkConvertToVariate.Checked = False
        chkConvertToVariate.Visible = False
        chkResponseFunction.Checked = False
        chkResponseFunction.Visible = False
        chkFirstFunction.Checked = False
        chkFirstFunction.Visible = False
        chkSecondFunction.Checked = False
        chkSecondFunction.Visible = False
        sdgSimpleRegOptions.SetDefaults()
        sdgModelOptions.SetDefaults()
        ucrModelName.Reset()
        ucrModelPreview.Reset()
        ResponseConvert()
        ModelOperator()
        sdgSimpleRegOptions.chkDisplayCLimits.Enabled = True
        sdgSimpleRegOptions.lblDisplayCLevel.Enabled = True
        sdgSimpleRegOptions.nudDisplayCLevel.Enabled = True
        TestOKEnabled()
    End Sub

    Public Sub TestOKEnabled()
        If Not ucrResponse.IsEmpty AndAlso Not ucrFirstExplanatory.IsEmpty AndAlso Not ucrSecondExplanatory.IsEmpty AndAlso Not ucrModelOperator.IsEmpty Then
            ucrBaseThreeVariableModelling.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel)
            ModelOperator()
            ucrBaseThreeVariableModelling.OKEnabled(True)
            ucrModelPreview.SetName(clsModel.ToScript)
        Else
            ucrBaseThreeVariableModelling.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectorThreeVariableModelling_DataFrameChanged() Handles ucrSelectorThreeVariableModelling.DataFrameChanged
        ucrBaseThreeVariableModelling.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.clsCurrDataFrame)
        AssignModelName()
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
                clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=clsRConvert)
                ucrFamily.RecieverDatatype("numeric")
            Else
                clsModel.AddParameter(iPosition:=0, strParameterValue:=ucrResponse.GetVariableNames(bWithQuotes:=False))
                ucrFamily.RecieverDatatype(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))
            End If
            sdgModelOptions.ucrFamily.RecieverDatatype(ucrFamily.strDataType)
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
        ExplanatoryFunctionSelect(ucrFirstExplanatory, chkFirstFunction)
        TestOKEnabled()
    End Sub

    Private Sub chkConvertToVariate_CheckedChanged(sender As Object, e As EventArgs) Handles chkConvertToVariate.CheckedChanged
        ResponseConvert()
    End Sub

    Private Sub ExplanatoryFunctionSelect(currentReceiver As ucrReceiverSingle, chkFunction As CheckBox)
        Dim strExplanatoryType As String
        If Not currentReceiver.IsEmpty Then
            strExplanatoryType = frmMain.clsRLink.GetDataType(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, currentReceiver.GetVariableNames(bWithQuotes:=False))
            If strExplanatoryType = "numeric" Or strExplanatoryType = "positive integer" Or strExplanatoryType = "integer" Then
                chkFunction.Visible = True
            Else
                chkFunction.Checked = False
                chkFunction.Visible = False
            End If
            If currentReceiver.Name = "ucrFirstExplanatory" Then
                '   sdgVariableTransformations.SetRXVariable(ucrFirstExplanatory)
                If chkFirstFunction.Checked Then
                    sdgVariableTransformations.ModelFunction(True)
                Else
                    sdgVariableTransformations.rdoIdentity.Checked = True
                    clsModel1.AddParameter(iPosition:=0, strParameterValue:=currentReceiver.GetVariableNames(False))
                End If
            End If
            If currentReceiver.Name = "ucrSecondExplanatory" Then
                ' sdgVariableTransformations.SetRXVariable(ucrSecondExplanatory)
                If chkSecondFunction.Checked Then
                    sdgVariableTransformations.ModelFunction(False)
                Else
                    sdgVariableTransformations.rdoIdentity.Checked = True
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

    Private Sub ucrSecondExplanatory_SelectionChanged() Handles ucrSecondExplanatory.SelectionChanged
        ExplanatoryFunctionSelect(ucrSecondExplanatory, chkSecondFunction)
        TestOKEnabled()
    End Sub

    Private Sub ucrBaseThreeVariableModelling_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseThreeVariableModelling.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrModelName_NameChanged() Handles ucrModelName.NameChanged
        AssignModelName()
        TestOKEnabled()
    End Sub

    Private Sub ucrBaseThreeVariableModelling_ClickOk(sender As Object, e As EventArgs) Handles ucrBaseThreeVariableModelling.ClickOk
        sdgSimpleRegOptions.RegOptions()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.ShowDialog()
    End Sub

    Private Sub ModelOperator()
        If Not ucrFirstExplanatory.IsEmpty AndAlso Not ucrSecondExplanatory.IsEmpty AndAlso Not ucrModelOperator.IsEmpty Then
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
            ucrBaseThreeVariableModelling.clsRsyntax.SetAssignTo(ucrModelName.GetText, strTempModel:=ucrModelName.GetText, strTempDataframe:=ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBaseThreeVariableModelling.clsRsyntax.bExcludeAssignedFunctionOutput = True
        Else
            ucrBaseThreeVariableModelling.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model", strTempDataframe:=ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBaseThreeVariableModelling.clsRsyntax.bExcludeAssignedFunctionOutput = False
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
        Else
            clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
            ucrBaseThreeVariableModelling.clsRsyntax.SetFunction("glm")
            ucrBaseThreeVariableModelling.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
        End If
    End Sub

    Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click
        sdgModelOptions.ShowDialog()
        ucrFamily.ucrInputDistributions.cboInput.SelectedIndex = ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgModelOptions.ucrFamily.clsCurrDistribution.strNameTag)
    End Sub

    Private Sub chkResponseFunction_CheckedChanged(sender As Object, e As EventArgs) Handles chkResponseFunction.CheckedChanged
        If chkResponseFunction.Checked Then
            sdgVariableTransformations.ShowDialog()
        End If
        ExplanatoryFunctionSelect(ucrResponse, chkResponseFunction)
        TestOKEnabled()
    End Sub

    Private Sub chkFirstFunction_CheckedChanged(sender As Object, e As EventArgs) Handles chkFirstFunction.CheckedChanged
        If chkFirstFunction.Checked Then
            sdgVariableTransformations.ShowDialog()
        End If
        ExplanatoryFunctionSelect(ucrFirstExplanatory, chkFirstFunction)
        TestOKEnabled()
    End Sub

    Private Sub chkSecondFunction_CheckedChanged(sender As Object, e As EventArgs) Handles chkSecondFunction.CheckedChanged
        If chkSecondFunction.Checked Then
            sdgVariableTransformations.ShowDialog()
        End If
        ExplanatoryFunctionSelect(ucrSecondExplanatory, chkSecondFunction)
        TestOKEnabled()
    End Sub

    Private Sub ucrModelOperator_NameChanged() Handles ucrModelOperator.NameChanged
        ModelOperator()
    End Sub

End Class