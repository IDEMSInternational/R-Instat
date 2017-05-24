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
    Public bReset As Boolean = True
    Public clsRbootFunction, clsQuantileFunction, clsSeqFunction As New RFunction
    Private Sub dlgOneVarUseModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bfirstload Then
            InitialiseDialog()
            bfirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()

        ucrBase.iHelpTopicID = 375
        ucrBase.clsRsyntax.iCallType = 2

        ucrSelector.SetItemType("model")

        ucrReceiver.Selector = ucrSelector
        ucrReceiver.SetParameter(New RParameter("x", 1))
        ucrReceiver.SetParameterIsRFunction()
        ucrReceiver.SetMeAsReceiver()

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrNewDataframeName.SetPrefix("UseModel")
        ucrNewDataframeName.SetDataFrameSelector(ucrSelector.ucrAvailableDataFrames)
        ucrNewDataframeName.SetSaveTypeAsModel()
        ucrNewDataframeName.SetIsComboBox()
        ucrNewDataframeName.SetCheckBoxText("Save Model")
        ucrNewDataframeName.SetAssignToIfUncheckedValue("last_model")

        ucrSaveObjects.SetName("bootstrap")
        ucrSaveObjects.SetSaveTypeAsModel()
        ucrSaveObjects.SetIsComboBox()
        ucrSaveObjects.SetCheckBoxText("Save Bootstrap")

        ucrChkProduceBootstrap.AddToLinkedControls(ucrSaveObjects, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=False)
        ucrChkProduceBootstrap.AddParameterValueFunctionNamesCondition(True, "x", "bootdist", True)
        ucrChkProduceBootstrap.AddParameterValueFunctionNamesCondition(False, "x", "bootdist", False)
        ucrChkProduceBootstrap.SetText("Produce Bootstrap")
        ucrChkProduceBootstrap.SetLinkedDisplayControl(cmdBootstrapOptions)

        'This part is temporary for now
        sdgOneVarUseModBootstrap.InitialiseDialog()
        sdgOneVarUseModFit.InitialiseDialog()
        sdgOneVarUseModBootstrap.SetMyBootFunction(clsRbootFunction)
        sdgOneVarUseModBootstrap.SetMyRSyntax(ucrBase.clsRsyntax)
        sdgOneVarUseModFit.SetModelFunction(ucrBase.clsRsyntax.clsBaseFunction)
        sdgOneVarUseModFit.SetMyBootFunction(clsRbootFunction)
        sdgOneVarUseModFit.SetMyRSyntax(ucrBase.clsRsyntax)
    End Sub

    Private Sub SetDefaults()
        clsRbootFunction = New RFunction
        clsQuantileFunction = New RFunction

        ucrSelector.Reset()
        ucrSaveObjects.Enabled = False 'for now
        ucrSaveObjects.Reset()
        ucrNewDataframeName.Reset()
        sdgOneVarUseModBootstrap.SetDefaults()
        sdgOneVarUseModFit.SetDefaults()


        clsSeqFunction.SetRCommand("seq")
        clsSeqFunction.AddParameter("from", 0)
        clsSeqFunction.AddParameter("to", 1)

        clsQuantileFunction.SetRCommand("quantile")
        clsRbootFunction.SetRCommand("bootdist")
        clsQuantileFunction.AddParameter("probs", clsRFunctionParameter:=clsSeqFunction)

        ucrBase.clsRsyntax.SetBaseRFunction(clsQuantileFunction)

        ucrBase.clsRsyntax.SetAssignTo(ucrNewDataframeName.GetText, strTempModel:="last_model", strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiver.AddAdditionalCodeParameterPair(clsRbootFunction, New RParameter("f"), iAdditionalPairNo:=1)
        ucrChkProduceBootstrap.SetRCode(clsRbootFunction, bReset)
        ucrNewDataframeName.SetRCode(clsQuantileFunction, bReset)
        ucrSaveObjects.SetRCode(clsRbootFunction, bReset)
        ucrReceiver.SetRCode(clsQuantileFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiver.IsEmpty AndAlso ucrSaveObjects.IsComplete() AndAlso ucrNewDataframeName.IsComplete() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    '  Private Sub AssignSaveObjects()
    ' If chkSaveBootstrap.Checked AndAlso Not ucrSaveObjects.IsEmpty Then
    ''       ucrBase.clsRsyntax.SetAssignTo(ucrSaveObjects.GetText, strTempModel:=ucrSaveObjects.GetText, strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    ''Else
    ''       ucrBase.clsRsyntax.SetAssignTo("last_bootstrap", strTempModel:="last_bootstrap", strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    'End If
    'End Sub

    Private Sub cmdBootstrapOptions_Click(sender As Object, e As EventArgs) Handles cmdBootstrapOptions.Click
        sdgOneVarUseModBootstrap.ShowDialog()
    End Sub

    Private Sub cmdFitModel_Click(sender As Object, e As EventArgs) Handles cmdFitModel.Click
        sdgOneVarUseModFit.ShowDialog()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        sdgOneVarUseModFit.CreateGraphs()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If ucrChkProduceBootstrap.Checked Then
            frmMain.clsRLink.RunScript(clsRbootFunction.ToScript(), iCallType:=2)
        End If
    End Sub

    Private Sub ucrChkProduceBootstrap_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkProduceBootstrap.ControlValueChanged
        If ucrChkProduceBootstrap.Checked Then
            clsQuantileFunction.AddParameter("x", clsRFunctionParameter:=clsRbootFunction)
            cmdBootstrapOptions.Visible = True
        Else
            clsQuantileFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiver.GetVariables())
            cmdBootstrapOptions.Visible = False
        End If
    End Sub

    Private Sub ucrReceiver_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiver.ControlContentsChanged, ucrSaveObjects.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class