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

Public Class dlgOneVarUseModel
    Public bfirstload As Boolean = True
    Public clsRbootFunction As New RFunction

    Private Sub dlgOneVarUseModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        sdgOneVarUseModBootstrap.InitialiseDialog()
        sdgOneVarUseModFit.InitialiseDialog()
        ucrBase.iHelpTopicID = 375
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiver.Selector = ucrSelector
        ucrReceiver.SetMeAsReceiver()
        ucrSaveModel.SetDataFrameSelector(ucrSelector.ucrAvailableDataFrames)
        ucrSaveModel.SetPrefix("model")
        ucrBase.clsRsyntax.SetFunction("quantile")
        ucrSaveModel.SetItemsTypeAsModels()
        ucrSaveModel.SetDefaultTypeAsModel()
        ucrSaveModel.SetValidationTypeAsRVariable()
        ucrSaveObjects.SetName("bootstrap")
        ucrSaveObjects.SetItemsTypeAsModels()
        ucrSaveObjects.SetDefaultTypeAsModel()
        ucrSaveObjects.SetValidationTypeAsRVariable()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrSelector.SetItemType("model")
        sdgOneVarUseModBootstrap.SetMyBootFunction(clsRbootFunction)
        sdgOneVarUseModBootstrap.SetMyRSyntax(ucrBase.clsRsyntax)
        sdgOneVarUseModFit.SetModelFunction(ucrBase.clsRsyntax.clsBaseFunction)
        sdgOneVarUseModFit.SetMyBootFunction(clsRbootFunction)
        sdgOneVarUseModFit.SetMyRSyntax(ucrBase.clsRsyntax)
    End Sub

    Private Sub SetDefaults()
        ucrSelector.Reset()
        ucrSelector.Focus()
        sdgOneVarUseModBootstrap.SetDefaults()
        sdgOneVarUseModFit.SetDefaults()
        chkSaveModel.Checked = True
        ucrSaveObjects.Visible = False
        ucrSaveObjects.Reset()
        ucrSaveModel.Reset()
        chkProduceBootstrap.Enabled = False
        chkProduceBootstrap.Checked = False
        chkSaveBootstrap.Visible = False
        cmdBootstrapOptions.Visible = False
        chkSaveBootstrap.Visible = False
        cmdBootstrapOptions.Visible = False
        BootstrapEnabled()
        SetFunctions()
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub TestOKEnabled()
        If (chkSaveModel.Checked AndAlso Not ucrSaveModel.IsEmpty() OrElse Not chkSaveModel.Checked) AndAlso Not ucrReceiver.IsEmpty AndAlso (chkSaveBootstrap.Checked AndAlso Not ucrSaveObjects.IsEmpty() OrElse Not chkSaveBootstrap.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrSelector_DataFrameChanged() Handles ucrSelector.DataFrameChanged
        AssignSaveModel()
        ' AssignSaveObjects()
    End Sub

    Private Sub ucrSaveModel_NameChanged() Handles ucrSaveModel.NameChanged
        AssignSaveModel()
        TestOKEnabled()
    End Sub

    Private Sub ucrSaveObjects_NameChanged() Handles ucrSaveObjects.NameChanged
        ' AssignSaveObjects()
        TestOKEnabled()
    End Sub

    Private Sub SetFunctions()
        If chkProduceBootstrap.Checked Then
            clsRbootFunction.SetRCommand("bootdist")
            clsRbootFunction.AddParameter("f", clsRFunctionParameter:=ucrReceiver.GetVariables())
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=clsRbootFunction)
        Else
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiver.GetVariables())
        End If

    End Sub

    Private Sub AssignSaveModel()
        If chkSaveModel.Checked AndAlso Not ucrSaveModel.IsEmpty Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveModel.GetText, strTempModel:=ucrSaveModel.GetText, strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model", strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
    End Sub

    ' Private Sub AssignSaveObjects()
    'If chkSaveBootstrap.Checked AndAlso Not ucrSaveObjects.IsEmpty Then
    '       ucrBase.clsRsyntax.SetAssignTo(ucrSaveObjects.GetText, strTempModel:=ucrSaveObjects.GetText, strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    'Else
    '       ucrBase.clsRsyntax.SetAssignTo("last_bootstrap", strTempModel:="last_bootstrap", strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    'End If
    'End Sub

    Private Sub chkSaveModel_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveModel.CheckedChanged
        If chkSaveModel.Checked Then
            ucrSaveModel.Enabled = True
        Else
            ucrSaveModel.Enabled = False
        End If
        AssignSaveModel()
        TestOKEnabled()
    End Sub

    Private Sub chkSaveBootstrap_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveBootstrap.CheckedChanged
        If Not chkSaveBootstrap.Checked Then
            ucrSaveObjects.Visible = False
        Else
            ucrSaveObjects.Visible = True
        End If
        '   AssignSaveObjects()
        TestOKEnabled()
    End Sub

    Private Sub UcrReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiver.SelectionChanged
        BootstrapEnabled()
        SetFunctions()
        TestOKEnabled()
    End Sub

    Private Sub BootstrapEnabled()
        If Not ucrReceiver.IsEmpty Then
            chkProduceBootstrap.Enabled = True
        Else
            chkProduceBootstrap.Enabled = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub chkProduceBootstrap_CheckedChanged(sender As Object, e As EventArgs) Handles chkProduceBootstrap.CheckedChanged
        If Not chkProduceBootstrap.Checked Then
            chkSaveBootstrap.Visible = False
            cmdBootstrapOptions.Visible = False
        Else
            chkSaveBootstrap.Visible = True
            cmdBootstrapOptions.Visible = True
        End If
        TestOKEnabled()
        ' AssignSaveObjects()
        SetFunctions()
        sdgOneVarUseModFit.SetPlotOptions()
    End Sub

    Private Sub cmdBootstrapOptions_Click(sender As Object, e As EventArgs) Handles cmdBootstrapOptions.Click
        sdgOneVarUseModBootstrap.ShowDialog()
        BootstrapEnabled()
    End Sub

    Private Sub cmdFitModel_Click(sender As Object, e As EventArgs) Handles cmdFitModel.Click
        sdgOneVarUseModFit.ShowDialog()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        sdgOneVarUseModFit.CreateGraphs()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        frmMain.clsRLink.RunScript(clsRbootFunction.ToScript(), bReturnOutput:=2)
    End Sub

End Class