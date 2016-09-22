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
    Public clsModel As New ROperator
    Public clsRConvert, clsRCIFunction As New RFunction

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
        ucrFamily.SetGLMDistributions()
        ucrModelName.SetDataFrameSelector(ucrSelectorSimpleReg.ucrAvailableDataFrames)
        ucrModelName.SetPrefix("reg")
        ucrModelName.SetItemsTypeAsModels()
        ucrModelName.SetDefaultTypeAsModel()
        ucrModelName.SetValidationTypeAsRVariable()
        ucrModelPreview.IsReadOnly = True
        sdgSimpleRegOptions.SetRModelFunction(ucrBase.clsRsyntax.clsBaseFunction)
        sdgSimpleRegOptions.SetRDataFrame(ucrSelectorSimpleReg.ucrAvailableDataFrames)
        sdgSimpleRegOptions.SetRYVariable(ucrResponse)
        sdgSimpleRegOptions.SetRXVariable(ucrExplanatory)
        sdgVariableTransformations.SetRYVariable(ucrResponse)
        sdgVariableTransformations.SetRXVariable(ucrExplanatory)
        sdgVariableTransformations.SetRModelOperator(clsModel)
        sdgModelOptions.SetRCIFunction(clsRCIFunction)
        sdgVariableTransformations.SetRCIFunction(clsRCIFunction)
        AssignModelName()
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
        sdgSimpleRegOptions.SetDefaults()
        sdgModelOptions.SetDefaults()
        ucrModelName.Reset()
        ucrModelPreview.SetName("")
        ResponseConvert()
        TestOKEnabled()
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
    End Sub

    Public Sub ResponseConvert()
        If Not ucrResponse.IsEmpty Then

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

    Private Sub chkConvertToVariate_CheckedChanged(sender As Object, e As EventArgs) Handles chkConvertToVariate.CheckedChanged
        ResponseConvert()
        TestOKEnabled()
    End Sub

    Private Sub ExplanatoryFunctionSelect()
        Dim strExplanatoryType As String
        If Not ucrExplanatory.IsEmpty Then
            strExplanatoryType = frmMain.clsRLink.GetDataType(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrExplanatory.GetVariableNames(bWithQuotes:=False))
            If strExplanatoryType = "numeric" Or strExplanatoryType = "positive integer" Or strExplanatoryType = "integer" Then
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
        'TODO:   Include multinomial as an option And the appropriate function
        If (ucrFamily.clsCurrDistribution.strNameTag = "Normal") Then
            ucrBase.clsRsyntax.SetFunction("lm")
            ucrBase.clsRsyntax.RemoveParameter("family")
        Else
            clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
            ucrBase.clsRsyntax.SetFunction("glm")
            ucrBase.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
        End If
    End Sub

    Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click
        sdgModelOptions.ShowDialog()
        ucrFamily.cboDistributions.SelectedIndex = ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgModelOptions.ucrFamily.clsCurrDistribution.strNameTag)
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
    End Sub
End Class