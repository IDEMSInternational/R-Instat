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
        sdgOneVarFitModDisplay.InitialiseDialog()
        sdgOneVarFitModel.InitialiseDialog()
        UcrBase.clsRsyntax.SetFunction("fitdist")
        'ucrBase.iHelpTopicID = 
        UcrBase.clsRsyntax.iCallType = 2
        UcrReceiver.Selector = ucrSelectorOneVarFitMod
        UcrReceiver.SetMeAsReceiver()
        ucrSaveModel.SetDataFrameSelector(ucrSelectorOneVarFitMod.ucrAvailableDataFrames)
        ucrSaveModel.SetPrefix("dist")
        ucrSaveModel.SetItemsTypeAsModels()
        ucrSaveModel.SetDefaultTypeAsModel()
        ucrSaveModel.SetValidationTypeAsRVariable()
        UcrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        sdgOneVarFitModDisplay.SetModelFunction(UcrBase.clsRsyntax.clsBaseFunction)
        sdgOneVarFitModel.SetMyRSyntax(UcrBase.clsRsyntax)
        sdgOneVarFitModDisplay.SetDistribution(UcrDistributions)
        sdgOneVarFitModel.SetDistribution(UcrDistributions)
    End Sub

    Private Sub SetDefaults()
        ucrSelectorOneVarFitMod.Reset()
        ucrSelectorOneVarFitMod.Focus()
        chkSaveModel.Checked = True
        ucrSaveModel.Reset()
        SetDataParameter()
        EnableOptions()
        AssignSaveModel()
        sdgOneVarFitModDisplay.SetDefaults()
        sdgOneVarFitModel.SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub TestOKEnabled()
        If (chkSaveModel.Checked AndAlso Not ucrSaveModel.IsEmpty() OrElse Not chkSaveModel.Checked) AndAlso Not UcrReceiver.IsEmpty Then
            UcrBase.OKEnabled(True)
        Else
            UcrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles UcrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrSelectorOneVarFitMod_DataFrameChanged() Handles ucrSelectorOneVarFitMod.DataFrameChanged
        AssignSaveModel()
    End Sub


    Private Sub ucrSaveModel_NameChanged() Handles ucrSaveModel.NameChanged
        AssignSaveModel()
        TestOKEnabled()
    End Sub


    Public Sub SetDataParameter()
        If Not UcrReceiver.IsEmpty Then
            If UcrReceiver.strCurrDataType = "numeric" OrElse UcrReceiver.strCurrDataType = "integer" Then
                chkConvertToVariate.Checked = False
                chkConvertToVariate.Visible = False
            Else
                chkConvertToVariate.Visible = True
            End If
            If chkConvertToVariate.Checked Then
                clsRConvert.SetRCommand("as.numeric")
                clsRConvert.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
                UcrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=clsRConvert)
            Else
                'TODO This is needed because fitdist checks is.vector on data which is FALSE when data has attributes
                clsRConvert.SetRCommand("as.vector")
                clsRConvert.AddParameter("x", clsRFunctionParameter:=UcrReceiver.GetVariables())
                UcrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=clsRConvert)
            End If
        Else
            chkConvertToVariate.Visible = False
            UcrBase.clsRsyntax.RemoveParameter("data")
        End If
    End Sub

    Private Sub AssignSaveModel()
        If chkSaveModel.Checked AndAlso Not ucrSaveModel.IsEmpty Then
            UcrBase.clsRsyntax.SetAssignTo(ucrSaveModel.GetText, strTempModel:=ucrSaveModel.GetText, strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            UcrBase.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model", strTempDataframe:=ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
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
        UcrBase.clsRsyntax.AddParameter("distr", Chr(34) & UcrDistributions.clsCurrDistribution.strRName & Chr(34))
        SetDataParameter()
    End Sub

    Private Sub UcrReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles UcrReceiver.SelectionChanged
        SetDataParameter()
        TestOKEnabled()
        EnableOptions()
    End Sub

    Private Sub cmdFittingOptions_Click(sender As Object, e As EventArgs) Handles cmdFittingOptions.Click
        sdgOneVarFitModel.ShowDialog()
        EnableOptions()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgOneVarFitModDisplay.ShowDialog()
        EnableOptions()
    End Sub

    Private Sub EnableOptions()
        If Not UcrReceiver.IsEmpty Then
            cmdFittingOptions.Enabled = True
            cmdDisplayOptions.Enabled = True
        Else
            cmdFittingOptions.Enabled = False
            cmdDisplayOptions.Enabled = False
        End If
    End Sub

    Private Sub chkConvertToVariate_CheckedChanged(sender As Object, e As EventArgs) Handles chkConvertToVariate.CheckedChanged
        SetDataParameter()
        TestOKEnabled()
    End Sub

    Private Sub UcrBase_ClickOk(sender As Object, e As EventArgs) Handles UcrBase.ClickOk
        sdgOneVarFitModDisplay.CreateGraphs()
    End Sub

End Class