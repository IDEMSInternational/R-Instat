' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgOneVarUseModel
    Public bfirstload As Boolean = True
    Public bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Public clsRBootFunction, clsQuantileFunction, clsSeqFunction, clsReceiver, clsRPlotAllFunction, clsRplotPPfunction, clsRplotCDFfunction, clsRplotQQfunction, clsRplotDensfunction, clsRplotCIfunction As New RFunction
    'temp fix to deciding if plot should be included
    'won't be needed once RSyntax can contain multiple functions
    Private bPlot As Boolean

    Private Sub dlgOneVarUseModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()

        'Temp fix: Bugs on second running- an inifinite loop is created
        sdgOneVarUseModFit.rdoCIcdf.Enabled = False
        ucrBase.iHelpTopicID = 375
        'ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrReceiverObject.SetParameter(New RParameter("x", 0))
        ucrReceiverObject.Selector = ucrSelectorUseModel
        ucrReceiverObject.SetParameterIsRFunction()
        ucrReceiverObject.SetMeAsReceiver()
        ucrReceiverObject.strSelectorHeading = "Models"
        ucrReceiverObject.SetItemType(RObjectTypeLabel.Model)

        ucrChkProduceBootstrap.AddRSyntaxContainsFunctionNamesCondition(True, {"bootdist"})
        ucrChkProduceBootstrap.AddRSyntaxContainsFunctionNamesCondition(False, {"bootdist"}, False)
        'ucrChkProduceBootstrap.AddToLinkedControls(ucrSaveObjects, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=False)
        ucrChkProduceBootstrap.SetText("Produce Bootstrap")

        'This control is not used yet 
        ucrNewDataFrameName.Visible = False
        'ucrNewDataFrameName.SetPrefix("use_model")
        'ucrNewDataFrameName.SetDataFrameSelector(ucrSelectorUseModel.ucrAvailableDataFrames)
        'ucrNewDataFrameName.SetSaveTypeAsModel()
        'ucrNewDataFrameName.SetIsComboBox()
        'ucrNewDataFrameName.SetCheckBoxText("Save Model")
        'ucrNewDataFrameName.SetAssignToIfUncheckedValue("last_model")

        'This control is not used yet 
        ucrSaveObjects.Visible = False
        'ucrSaveObjects.SetPrefix("bootstrap")
        'ucrSaveObjects.SetDataFrameSelector(ucrSelectorUseModel.ucrAvailableDataFrames)
        'ucrSaveObjects.SetSaveTypeAsModel()
        'ucrSaveObjects.SetIsComboBox()
        'ucrSaveObjects.SetCheckBoxText("Save Bootstrap")
        'ucrSaveObjects.SetAssignToIfUncheckedValue("last_bootstrap")
    End Sub

    Private Sub SetDefaults()
        clsRBootFunction = New RFunction
        clsQuantileFunction = New RFunction
        clsSeqFunction = New RFunction
        clsRPlotAllFunction = New RFunction
        clsRplotPPfunction = New RFunction
        clsRplotCDFfunction = New RFunction
        clsRplotQQfunction = New RFunction
        clsRplotDensfunction = New RFunction
        clsRplotCIfunction = New RFunction

        ucrSelectorUseModel.Reset()

        clsRPlotAllFunction.SetPackageName("graphics")
        clsRPlotAllFunction.SetRCommand("plot")
        clsRPlotAllFunction.bExcludeAssignedFunctionOutput = False
        clsRPlotAllFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorUseModel.strCurrentDataFrame,
                                           strObjectName:="last_graph")

        clsRplotCDFfunction.SetPackageName("fitdistrplus")
        clsRplotCDFfunction.SetRCommand("cdfcomp")
        clsRplotCDFfunction.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
        clsRplotCDFfunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorUseModel.strCurrentDataFrame,
                                           strObjectName:="last_graph")

        clsRplotQQfunction.SetPackageName("fitdistrplus")
        clsRplotQQfunction.SetRCommand("qqcomp")
        clsRplotQQfunction.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
        clsRplotQQfunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorUseModel.strCurrentDataFrame,
                                           strObjectName:="last_graph")

        clsRplotDensfunction.SetPackageName("fitdistrplus")
        clsRplotDensfunction.SetRCommand("denscomp")
        clsRplotDensfunction.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
        clsRplotDensfunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorUseModel.strCurrentDataFrame,
                                           strObjectName:="last_graph")

        clsRplotPPfunction.SetPackageName("fitdistrplus")
        clsRplotPPfunction.SetRCommand("ppcomp")
        clsRplotPPfunction.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
        clsRplotPPfunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorUseModel.strCurrentDataFrame,
                                           strObjectName:="last_graph")

        'todo. this option is disabled in the subdialog
        clsRplotCIfunction.SetPackageName("fitdistrplus")
        clsRplotCIfunction.SetRCommand("CIcdfplot")

        clsSeqFunction.SetRCommand("seq")
        clsSeqFunction.AddParameter("from", 0)
        clsSeqFunction.AddParameter("to", 1)
        clsSeqFunction.AddParameter("by", 0.25)

        clsRBootFunction.SetPackageName("fitdistrplus")
        clsRBootFunction.SetRCommand("bootdist")
        clsRBootFunction.AddParameter("bootmethod", Chr(34) & "nonparam" & Chr(34))
        clsRBootFunction.AddParameter("niter", 1001)
        clsRBootFunction.bExcludeAssignedFunctionOutput = False
        clsRBootFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorUseModel.strCurrentDataFrame,
                                           strObjectName:="last_summary")

        clsQuantileFunction.SetRCommand("quantile")
        clsQuantileFunction.AddParameter("probs", clsRFunctionParameter:=clsSeqFunction)
        clsQuantileFunction.bExcludeAssignedFunctionOutput = False
        clsQuantileFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorUseModel.strCurrentDataFrame,
                                           strObjectName:="last_summary")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToAfterCodes(clsRPlotAllFunction, iPosition:=2)
        ucrBase.clsRsyntax.SetBaseRFunction(clsQuantileFunction)

        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverObject.SetRCode(clsRPlotAllFunction, bReset)
        ucrReceiverObject.AddAdditionalCodeParameterPair(clsRBootFunction, New RParameter("f", 0), iAdditionalPairNo:=1)
        ucrReceiverObject.AddAdditionalCodeParameterPair(clsQuantileFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverObject.AddAdditionalCodeParameterPair(clsRplotPPfunction, New RParameter("ft", 0), iAdditionalPairNo:=3)
        ucrReceiverObject.AddAdditionalCodeParameterPair(clsRplotCDFfunction, New RParameter("ft", 0), iAdditionalPairNo:=4)
        ucrReceiverObject.AddAdditionalCodeParameterPair(clsRplotQQfunction, New RParameter("ft", 0), iAdditionalPairNo:=5)
        ucrReceiverObject.AddAdditionalCodeParameterPair(clsRplotDensfunction, New RParameter("ft", 0), iAdditionalPairNo:=6)
        ucrChkProduceBootstrap.SetRCode(clsRBootFunction, bReset)
        ucrChkProduceBootstrap.SetRSyntax(ucrBase.clsRsyntax, bReset)


    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverObject.IsEmpty Then
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

    'Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
    '    If ucrChkProduceBootstrap.Checked Then
    '        frmMain.clsRLink.RunRScript(clsRBootFunction.ToScript(), iCallType:=2)
    '    End If
    'End Sub

    'Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
    '    If bPlot Then
    '        frmMain.clsRLink.RunRScript(clsRPlotFunction.ToScript(), iCallType:=3)
    '    Else

    '    End If
    'End Sub

    '  Private Sub AssignSaveObjects()
    ' If chkSaveBootstrap.Checked AndAlso Not ucrSaveObjects.IsEmpty Then
    ''       ucrBase.clsRsyntax.SetAssignTo(ucrSaveObjects.GetText, strTempModel:=ucrSaveObjects.GetText, strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    ''Else
    ''       ucrBase.clsRsyntax.SetAssignTo("last_bootstrap", strTempModel:="last_bootstrap", strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    'End If
    'End Sub

    Private Sub cmdFitModel_Click(sender As Object, e As EventArgs) Handles cmdFitModelandBootstrap.Click
        sdgOneVarUseModFit.SetRcode(ucrBase.clsRsyntax, clsSeqFunction, clsRBootFunction, clsQuantileFunction, clsReceiver, clsRPlotAllFunction, clsRplotPPfunction, clsRplotCDFfunction, clsRplotQQfunction, clsRplotDensfunction, clsRplotCIfunction, bResetSubdialog)
        bPlot = Not sdgOneVarUseModFit.rdoNoPlot.Checked
        sdgOneVarUseModFit.ShowDialog()
        sdgOneVarUseModFit.SetPlotOptions()
        bResetSubdialog = False
    End Sub

    Private Sub ucrChkProduceBootstrap_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkProduceBootstrap.ControlValueChanged
        If ucrChkProduceBootstrap.Checked Then
            clsQuantileFunction.AddParameter("x", clsRFunctionParameter:=clsRBootFunction)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsRBootFunction, iPosition:=1)
        Else
            clsQuantileFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverObject.GetVariables())
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsRBootFunction)
        End If
        sdgOneVarUseModFit.SetPlotOptions()
    End Sub

    Private Sub ucrReceiver_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverObject.ControlContentsChanged, ucrSaveObjects.ControlContentsChanged, ucrNewDataFrameName.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class