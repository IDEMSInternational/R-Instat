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
Imports instat
Imports instat.Translations

Public Class dlgOneVarUseModel
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    '  Private bResetSubdialog As Boolean = False
    Public clsProduceBootstrap, clsOverallFunction As New RFunction

    Private Sub dlgOneVarUseModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        ReopenDialog()
        TestOKEnabled()
    End Sub
    'WANT:
    'dsadsasa <- InstatDataObject$get_models(model_name="dsadsasa", data_name="data1")
    '' if bootstrap isn't checked:
    ' quantile(x=dsadsasa)

    '' if bootstrap checked
    ' bootdist(f=dsadsasa)
    ' quantile(x=bootdist(f=dsadsasa))

    Private Sub InitialiseDialog()
        'sdgOneVarUseModBootstrap.InitialiseDialog()
        'sdgOneVarUseModFit.InitialiseDialog()
        ucrBase.iHelpTopicID = 375
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        'ucrReceiver
        ucrReceiver.Selector = ucrSelector
        ucrReceiver.SetMeAsReceiver()
        'ucrReceiver.AddToLinkedControls(ucrLinked:=ucrChkProduceBootstrap, objValues:={True}, bNewLinkedDisabledIfParameterMissing:=True)
        ' how do I say that if this has a value in it then I want it to be visible

        ucrSelector.SetItemType("model")

        ' ucrSave
        ucrSaveToDataframe.SetCheckBoxText("Save to Dataframe:")
        ucrSaveToDataframe.SetSaveTypeAsModel()
        ucrSaveToDataframe.SetPrefix("UseModel")
        ucrSaveToDataframe.SetIsComboBox()
        ucrSaveToDataframe.SetDataFrameSelector(ucrSelector.ucrAvailableDataFrames)
        ucrSaveToDataframe.SetAssignToIfUncheckedValue("last_model")

        'ucrChkProduceBootstrap
        ucrChkProduceBootstrap.SetText("Produce Bootstrap")
        ' this adds bootdist(f = ...) but that's an additional function I have done that in it's own sub
        ' I need to do that we have f = ...
        ' this also changes the item in the main "quantile" function
        ' means classes are involved, like in FileNew
        ' however, I'm not sure of an example where a class is added to the main functino through a check box
        ucrChkProduceBootstrap.AddToLinkedControls(ucrLinked:=ucrSaveBootstrapObjects, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrSaveBootstrapObjects
        ucrSaveBootstrapObjects.SetCheckBoxText("Save Bootstrap:")
        ucrSaveBootstrapObjects.SetSaveTypeAsModel()
        ucrSaveBootstrapObjects.SetName("Bootstrap")
        ucrSaveBootstrapObjects.SetIsComboBox()
        'ucrSaveBootstrapObjects.SetDataFrameSelector(ucrSelector.ucrAvailableDataFrames)
        ucrSaveBootstrapObjects.SetAssignToIfUncheckedValue("last_bootstrap")
        ucrSaveBootstrapObjects.SetAssignToBooleans(bTempInsertColumnBefore:=True)

        'sdgOneVarUseModBootstrap.SetMyBootFunction(clsRbootFunction)
        'sdgOneVarUseModBootstrap.SetMyRSyntax(ucrBase.clsRsyntax)
        'sdgOneVarUseModFit.SetModelFunction(ucrBase.clsRsyntax.clsBaseFunction)
        'sdgOneVarUseModFit.SetMyBootFunction(clsRbootFunction)
        'sdgOneVarUseModFit.SetMyRSyntax(ucrBase.clsRsyntax)
    End Sub


    Private Sub SetDefaults()
        Dim clsDefaultFunction, clsDefaultProduceBootstrap As New RFunction

        ucrSelector.Reset()
        ucrSaveBootstrapObjects.Reset()
        ucrSaveToDataframe.Reset()
        ucrChkProduceBootstrap.Checked = False
        cmdBootstrapOptions.Visible = False

        clsDefaultFunction.SetRCommand("quantile")
        clsDefaultFunction.SetAssignTo(strTemp:=ucrSaveToDataframe.GetText, strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        clsDefaultFunction.SetAssignTo(strTemp:=ucrSaveBootstrapObjects.GetText, strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:=ucrSaveBootstrapObjects.GetText(), bInsertColumnBefore:=True)

        ' the main command is quantile
        ' then this = one thing if the check box isn't checked 
        ' this = something else if the check box is checked.

        clsProduceBootstrap = clsDefaultProduceBootstrap.Clone
        clsOverallFunction = clsDefaultFunction.Clone


        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFunction)
        'bResetSubdialog = True


        'sdgOneVarUseModBootstrap.SetDefaults()
        'sdgOneVarUseModFit.SetDefaults()
        SetFunctions()
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiver.IsEmpty AndAlso ucrSaveToDataframe.IsComplete() AndAlso ((ucrChkProduceBootstrap.Checked AndAlso ucrSaveBootstrapObjects.IsComplete()) OrElse Not ucrChkProduceBootstrap.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    ' Base Function parameters change depending if check box is checked
    Private Sub SetFunctions()
        If ucrChkProduceBootstrap.Checked Then
            clsProduceBootstrap.SetRCommand("bootdist")
            clsProduceBootstrap.AddParameter("f", clsRFunctionParameter:=ucrReceiver.GetVariables())
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=clsProduceBootstrap)
        Else
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiver.GetVariables())
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdBootstrapOptions_Click(sender As Object, e As EventArgs) Handles cmdBootstrapOptions.Click
        'sdgOneVarUseModBootstrap.SetRFunction(ucrBase.clsRsyntax.clsBaseFunction, bResetSubdialog)
        'bResetSubdialog = False
        'sdgOneVarUseModBootstrap.ShowDialog()
    End Sub

    Private Sub cmdFitModel_Click(sender As Object, e As EventArgs) Handles cmdFitModel.Click
        'sdgOneVarUseModFit.SetRFunction(ucrBase.clsRsyntax.clsBaseFunction, bResetSubdialog)
        'bResetSubdialog = False
        'sdgOneVarUseModFit.ShowDialog()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        'sdgOneVarUseModFit.CreateGraphs()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If ucrChkProduceBootstrap.Checked Then
            frmMain.clsRLink.RunScript(clsProduceBootstrap.ToScript(), iCallType:=2)
        End If
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        'ucr....SetRCode(clsOverallFunction, bReset)
        ucrChkProduceBootstrap.SetRCode(clsProduceBootstrap, bReset)
    End Sub

    Private Sub TestOK_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiver.ControlContentsChanged, ucrSaveToDataframe.ControlContentsChanged, ucrSaveBootstrapObjects.ControlContentsChanged, ucrChkProduceBootstrap.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkProduceBootstrap_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkProduceBootstrap.ControlContentsChanged
        If Not ucrChkProduceBootstrap.Checked Then
            cmdBootstrapOptions.Visible = False
        Else
            cmdBootstrapOptions.Visible = True
        End If
        SetFunctions()
    End Sub
End Class