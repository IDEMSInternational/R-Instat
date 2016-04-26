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
    Public clsRConvert As New RFunction
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
        ucrBase.iHelpTopicID = 171
        sdgSimpleRegOptions.SetRModelFunction(ucrBase.clsRsyntax.clsBaseFunction)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorSimpleReg.Reset()
        ucrResponse.SetMeAsReceiver()
        ucrSelectorSimpleReg.Focus()
        chkSaveModel.Checked = True
        ucrModelName.Visible = True
        ucrFamily.Enabled = False
        chkConvertToVariate.Checked = False
        chkConvertToVariate.Visible = False
        chkFunction.Checked = False
        chkFunction.Visible = False
        'TODO get this to be getting a default name e.g. reg1, reg2, etc.
        '     will be possible with new textbox user control
        ucrModelName.SetName("reg")
        sdgSimpleRegOptions.SetDefaults()
        sdgModelOptions.SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrResponse.IsEmpty()) And (Not ucrExplanatory.IsEmpty()) Then
            ucrBase.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel)
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectorSimpleReg_DataFrameChanged() Handles ucrSelectorSimpleReg.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorSimpleReg.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub cmdRegressionOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.ShowDialog()
    End Sub

    Private Sub ResponseConvert()
        If Not ucrResponse.IsEmpty Then
            ucrFamily.RecieverDatatype(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))
            If ucrFamily.strDatatype = "numeric" Then
                chkConvertToVariate.Checked = False
                chkConvertToVariate.Visible = False
            Else
                chkConvertToVariate.Visible = True
            End If
            If chkConvertToVariate.Checked Then
                clsRConvert.SetRCommand("as.numeric")
                clsRConvert.AddParameter("x", ucrResponse.GetVariableNames(bWithQuotes:=False))
                clsModel.SetParameter(True, clsRFunc:=clsRConvert)
                ucrFamily.strDatatype = "numeric"
                ucrFamily.Enabled = True
                ucrFamily.SetGLMDistributions()
            Else
                clsModel.SetParameter(True, strValue:=ucrResponse.GetVariableNames(bWithQuotes:=False))
                ucrFamily.RecieverDatatype(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))
                ucrFamily.Enabled = True
                ucrFamily.SetGLMDistributions()
            End If
        End If
    End Sub

    Private Sub ucrResponse_SelectionChanged() Handles ucrResponse.SelectionChanged
        ResponseConvert()
        TestOKEnabled()
    End Sub

    Private Sub chkConvertToVariate_CheckedChanged(sender As Object, e As EventArgs) Handles chkConvertToVariate.CheckedChanged
        ResponseConvert()
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
                sdgModelOptions.ModelFunction()
            Else
                clsModel.SetParameter(False, strValue:=ucrExplanatory.GetVariableNames(bWithQuotes:=False))
            End If
        End If
    End Sub
    Private Sub ucrExplanatory_SelectionChanged() Handles ucrExplanatory.SelectionChanged

        ExplanatoryFunctionSelect()
        'sdgModelOptions.ModelFunction()
        'clsModel.SetParameter(False, strValue:=ucrExplanatory.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrModelName_NameChanged() Handles ucrModelName.NameChanged
        AssignModelName()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        sdgSimpleRegOptions.RegOptions()
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
            ucrBase.clsRsyntax.SetAssignTo(ucrModelName.txtValidation.Text, strTempModel:=ucrModelName.txtValidation.Text)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model")
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub

    Private Sub ucrFamily_cboDistributionsIndexChanged(sender As Object, e As EventArgs) Handles ucrFamily.cboDistributionsIndexChanged
        'TODO: Include multinomial as an option and the appripriate function
        If (ucrFamily.clsCurrDistribution.strNameTag = "Normal") Then
            ucrBase.clsRsyntax.SetFunction("lm")
            ucrBase.clsRsyntax.RemoveParameter("family")
        Else
            ucrBase.clsRsyntax.SetFunction("glm")
            ucrBase.clsRsyntax.AddParameter("family", ucrFamily.clsCurrDistribution.strGLMFunctionName)
        End If
    End Sub

    Private Sub chkFunction_CheckedChanged(sender As Object, e As EventArgs) Handles chkFunction.CheckedChanged
        If chkFunction.Checked Then
            sdgModelOptions.ShowDialog()
        End If
        ExplanatoryFunctionSelect()
    End Sub
End Class