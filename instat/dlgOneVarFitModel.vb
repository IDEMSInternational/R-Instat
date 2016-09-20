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


Public Class dlgOneVarFitModel
    Public clsRConvert, clsRCIFunction As New RFunction
    Public bfirstload As Boolean = True

    Private Sub dlgOneVarFitModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bfirstload Then
            InitialiseDialog()
            SetDefaults()
            bfirstload = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        UcrBase.clsRsyntax.SetFunction("")
        'ucrBase.iHelpTopicID = 

        UcrReceiver.Selector = ucrSelectorOneVarFitMod
        ucrSaveModel.SetDataFrameSelector(ucrSelectorOneVarFitMod.ucrAvailableDataFrames)
        UcrDistributions.SetGLMDistributions()

        ucrSaveModel.SetPrefix("dist")
        AssignSaveModel()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorOneVarFitMod.Focus()
        ucrSelectorOneVarFitMod.Reset()
        UcrReceiver.SetMeAsReceiver()
        chkConvertToVariate.Checked = False
        chkConvertToVariate.Visible = False
        ucrSaveModel.Visible = True
        chkSaveModel.Checked = True
        ucrSaveModel.Reset()
        ConverttoVariate()
        'sdgOneVarFitModel.SetDefaults()
        '       sdgOneVarFitModDisplay.SetDefaults()
        ucrSaveModel.Reset()
        TestOKEnabled()
        If (ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "") Then
            ucrSaveModel.SetName(ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_dist")
        Else
            ucrSaveModel.SetName("")
        End If
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub TestOKEnabled()
        If (chkSaveModel.Checked AndAlso Not ucrSaveModel.IsEmpty() OrElse Not chkSaveModel.Checked) AndAlso UcrDistributions.Enabled AndAlso Not UcrReceiver.IsEmpty Then
            UcrBase.OKEnabled(True)
        Else
            UcrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles UcrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles UcrBase.ClickOk
        'sdgOneVarFitModel.RegOptions()
    End Sub



    Private Sub ucrSelectorOneVarFitMod_DataFrameChanged() Handles ucrSelectorOneVarFitMod.DataFrameChanged
        UcrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.clsCurrDataFrame)
        'the above line may not be correct..
        AssignSaveModel()
    End Sub



    Private Sub ucrSaveModel_NameChanged() Handles ucrSaveModel.NameChanged
        AssignSaveModel()
        TestOKEnabled()
    End Sub


    Public Sub ConverttoVariate()
        If Not UcrReceiver.IsEmpty Then

            ' UcrDistributions.ReceiverDataType(ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, UcrReceiver.GetVariableNames(bWithQuotes:=False))

            If UcrDistributions.strDataType = "numeric" Then
                chkConvertToVariate.Checked = False
                chkConvertToVariate.Visible = False
            Else
                chkConvertToVariate.Visible = True
            End If

            If chkConvertToVariate.Checked Then
                clsRConvert.SetRCommand("as.numeric")
                clsRConvert.AddParameter("x", UcrReceiver.GetVariableNames(bWithQuotes:=False))
                'clsModel.SetParameter(True, clsRFunc:=clsRConvert)
                '   UcrDistributions.ReceiverDataType("numeric")
            Else
                '      clsmodel.setparameter(True, strValue:=UcrReceiver.GetVariableNames(bWithQuotes:=False))
                '  UcrDistributions.receiverdatatype(ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, UcrReceiver.GetVariableNames(bWithQuotes:=False))

            End If
            ' sdgModelOptions.ucrDistributions.ReceiverDatatype(ucrDistributions.strDataType)
        End If

        'If UcrDistributions.1stCurrentDistribution.Count=0 Or ucrreceiver.IsEmpty() Then
        'UcrDistributions.Enabled = False
        'UcrDistributions.cboDistributions.Text = ""
        'cmdFittingOptions.Enabled = False
        'Else
        'UcrDistributions.Enabled = True
        'cmdFittingOptions.Enabled = True
        'End If
    End Sub


    Private Sub AssignSaveModel()
        If chkSaveModel.Checked AndAlso Not ucrSaveModel.IsEmpty Then
            UcrBase.clsRsyntax.SetAssignTo(ucrSaveModel.GetText, strTempModel:=ucrSaveModel.GetText, strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            UcrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
        Else
            UcrBase.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model", strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            UcrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub

    Private Sub chkSaveModel_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveModel.CheckedChanged
        If chkSaveModel.Checked Then
            ucrSaveModel.Enabled = True
        Else
            ucrSaveModel.Enabled = False
        End If
        AssignSaveModel()
        TestOKEnabled()
    End Sub

    Private Sub ucrDistributions_cboDistributionsIndexChanged(sender As Object, e As EventArgs) Handles UcrDistributions.cboDistributionsIndexChanged
        '    sdgModelOptions.ucrDistributions.ReceiverDatatype(UcrDistributions.strDataType)
        '   sdgModelOptions.ucrDistributions.cboDistributions.SelectedIndex = sdgModelOptions.ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = ucrFamily.clsCurrDistribution.strNameTag)
        '  sdgModelOptions.RestrictLink()
        ' 'TODO:   Include multinomial as an option And the appropriate function
        'If (UcrDistributions.clsCurrDistribution.strNameTag = "Normal") Then
        'UcrBase.clsRsyntax.SetFunction("lm")
        'UcrBase.clsRsyntax.RemoveParameter("family")
        'Else
        '   clsRCIFunction.SetRCommand(UcrDistributions.clsCurrDistribution.strGLMFunctionName)
        '  UcrBase.clsRsyntax.SetFunction("glm")
        ' UcrBase.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
        'End If
    End Sub

    Private Sub UcrReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles UcrReceiver.SelectionChanged
        ConverttoVariate()
        TestOKEnabled()
    End Sub

    Private Sub chkConvertToVariate_CheckedChanged_1(sender As Object, e As EventArgs)
        ConverttoVariate()
        TestOKEnabled()
    End Sub

    Private Sub cmdFittingOptions_Click(sender As Object, e As EventArgs) Handles cmdFittingOptions.Click
        sdgOneVarFitModel.ShowDialog()
        'UcrDistributions.cboDistributions.SelectedIndex = UcrDistributions.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgFittingOptions.ucrDistributions.clsCurrDistribution.strNameTag)
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgOneVarFitModDisplay.ShowDialog()
    End Sub
End Class