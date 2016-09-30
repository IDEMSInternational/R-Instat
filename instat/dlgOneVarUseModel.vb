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
        'sdg----.InitaliseDialog()
        'ucrBase.iHelpTopicID = 
        'ucrBase.clsRsyntax.iCallType = 2
        ucrReceiver.Selector = ucrSelector
        ucrReceiver.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction("bootdist")
        ucrSelector.SetItemType("model")
        'sdg---.SetModelFunction(ucrBase.clsRsyntax.clsBaseFunction?)
    End Sub

    Private Sub SetDefaults()
        ucrSelector.Reset()
        ucrSelector.Focus()
        'sdg---.SetDefaults()
        chkSaveModel.Checked = True
        ucrSaveModel.SetDataFrameSelector(ucrSelector.ucrAvailableDataFrames)
        ucrSaveModel.SetPrefix("Model")
        ucrSaveModel.SetItemsTypeAsModels()
        ucrSaveModel.SetDefaultTypeAsModel()
        ucrSaveModel.SetValidationTypeAsRVariable()
        'ucrSaveObjects.SetPrefix("Bootstrap")
        ucrSaveObjects.SetItemsTypeAsModels()
        ucrSaveObjects.SetDefaultTypeAsModel()
        ucrSaveObjects.SetValidationTypeAsRVariable()
        ucrSaveObjects.Visible = False
        ucrSaveObjects.Enabled = False
        chkProduceBootstrap.Enabled = False
        chkProduceBootstrap.Checked = False
        chkSaveBootstrap.Visible = False
        cmdBootstrapOptions.Visible = False
        chkSaveBootstrap.Visible = False
        cmdBootstrapOptions.Visible = False
        BootstrapEnabled()
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

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        'sdg, graph it
        TestOKEnabled()
    End Sub

    Private Sub AssignSaveModel()
        If chkSaveModel.Checked AndAlso Not ucrSaveModel.IsEmpty Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveModel.GetText, strTempModel:=ucrSaveModel.GetText, strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model", strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
    End Sub

    Private Sub AssignSaveObjects()
        '       If chkSaveBootstrap.Checked AndAlso Not ucrSaveObjects.IsEmpty Then
        '      ucrBase.clsRsyntax.SetAssignTo(ucrSaveObjects.GetText, strTempModel:=ucrSaveObjects.GetText, strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        '     Else
        '?    ucrBase.clsRsyntax.SetAssignTo("last_bootstrap", strTempModel:="last_bootstrap", strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        '   End If
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

    Private Sub chkSaveBootstrap_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveBootstrap.CheckedChanged
        If chkSaveBootstrap.Checked Then
            ucrSaveObjects.Enabled = True
        Else
            ucrSaveObjects.Enabled = False
        End If
        AssignSaveObjects()
        TestOKEnabled()
    End Sub

    Private Sub UcrReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiver.SelectionChanged
        ''''''ucrBase.clsRsyntax.AddParameter("f", clsRFunctionParameter:=ucrReceiver.GetVariables())
        TestOKEnabled()
        BootstrapEnabled()
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
            ucrSaveObjects.Visible = False
        Else
            chkSaveBootstrap.Visible = True
            cmdBootstrapOptions.Visible = True
            ucrSaveObjects.Visible = True
        End If
        TestOKEnabled()
        AssignSaveObjects()
    End Sub

    Private Sub cmdBootstrapOptions_Click(sender As Object, e As EventArgs) Handles cmdBootstrapOptions.Click

    End Sub

    Private Sub ucrSaveModel_NameChanged() Handles ucrSaveModel.NameChanged
        AssignSaveModel()
        TestOKEnabled()
    End Sub

    Private Sub ucrSaveObjects_Load(sender As Object, e As EventArgs) Handles ucrSaveObjects.Load
        AssignSaveObjects()
        TestOKEnabled()
    End Sub


End Class