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

Public Class dlgCorrelation
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    'Public bIsTwoColumnFunction As Boolean
    'Public clsRCorrelation As New RFunction
    Dim clsTempFunc As RFunction
    Private Sub dlgCorrelation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 421
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 0

        ucrPnlColumns.AddRadioButton(rdoTwoColumns)
        ucrPnlColumns.AddRadioButton(rdoMultipleColumns)
        ucrPnlColumns.AddFunctionNamesCondition(rdoTwoColumns, "cor.test")
        ucrPnlColumns.AddFunctionNamesCondition(rdoMultipleColumns, "cor")

        ucrPnlColumns.AddToLinkedControls(ucrReceiverFirstColumn, {rdoTwoColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumns.AddToLinkedControls(ucrReceiverSecondColumn, {rdoTwoColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumns.AddToLinkedControls(ucrReceiverMultipleColumns, {rdoMultipleColumns}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumns.AddToLinkedControls(ucrNudConfidenceInterval, {rdoTwoColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumns.AddToLinkedControls(ucrChkSaveModel, {rdoMultipleColumns}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumns.AddToLinkedControls(ucrPnlMissing, {rdoMultipleColumns}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumns.AddToLinkedControls(ucrChkCorelationMatrix, {rdoMultipleColumns}, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverFirstColumn.Selector = ucrSelectorCorrelation
        ucrReceiverFirstColumn.SetParameter(New RParameter("x"))
        ucrReceiverFirstColumn.SetParameterIsRFunction()
        ucrReceiverFirstColumn.SetDataType("numeric")

        ucrReceiverSecondColumn.Selector = ucrSelectorCorrelation
        ucrReceiverSecondColumn.SetParameter(New RParameter("y"))
        ucrReceiverSecondColumn.SetParameterIsRFunction()
        ucrReceiverSecondColumn.SetDataType("numeric")

        ucrReceiverMultipleColumns.Selector = ucrSelectorCorrelation
        ucrReceiverMultipleColumns.SetMeAsReceiver()
        ucrReceiverMultipleColumns.SetParameter(New RParameter("x"))
        ucrReceiverMultipleColumns.SetParameterIsRFunction()
        ucrReceiverMultipleColumns.SetDataType("numeric")

        ucrPnlMethod.SetParameter(New RParameter("method"))
        ucrPnlMethod.AddRadioButton(rdoPearson, Chr(34) & "pearson" & Chr(34))
        ucrPnlMethod.AddRadioButton(rdoKendall, Chr(34) & "kendall" & Chr(34))
        ucrPnlMethod.AddRadioButton(rdoSpearman, Chr(34) & "spearman" & Chr(34))
        ucrPnlMethod.SetRDefault(Chr(34) & "pearson" & Chr(34))

        ucrPnlMissing.SetParameter(New RParameter("use"))
        ucrPnlMissing.AddRadioButton(rdoCompleteRows, Chr(34) & "complete.obs" & Chr(34))
        ucrPnlMissing.AddRadioButton(rdoPairwise, Chr(34) & "pairwise.complete.obs" & Chr(34))
        ucrPnlMethod.SetRDefault(Chr(34) & "pairwise.complete.obs" & Chr(34)) 'this should be addressed by a combo box since we have 4 options with the default being everything

        ucrNudConfidenceInterval.SetParameter(New RParameter("conf.level"))
        ucrNudConfidenceInterval.SetMinMax(0, 1)
        ucrNudConfidenceInterval.SetLinkedDisplayControl(lblConfInterval)
        ucrNudConfidenceInterval.SetRDefault(0.95)
        ucrNudConfidenceInterval.Increment = 0.01
        ucrNudConfidenceInterval.DecimalPlaces = 2

        ucrChkCorelationMatrix.SetText("Correlation Matrix")
        ucrChkCorelationMatrix.bChangeParameterValue = False
        ucrChkCorelationMatrix.Checked = True

        'this should go somewhere else
        sdgCorrPlot.ucrSelectFactor.SetDataframe(ucrSelectorCorrelation.ucrAvailableDataFrames.strCurrDataFrame, bEnableDataframe:=False)

        ucrChkSaveModel.SetPrefix("cor")
        ucrChkSaveModel.SetSaveTypeAsModel()
        ucrChkSaveModel.SetDataFrameSelector(ucrSelectorCorrelation.ucrAvailableDataFrames)
        ucrChkSaveModel.SetCheckBoxText("Result Name")
        ucrChkSaveModel.SetIsComboBox()
        ucrChkSaveModel.SetAssignToIfUncheckedValue("last_cor")

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        rdoPearson.Checked = True
        rdoCompleteRows.Checked = True
        rdoMultipleColumns.Checked = True
        ucrSelectorCorrelation.Reset()
        ucrChkSaveModel.Reset()
        ' ucrReceiverMultipleColumns.SetMeAsReceiver()
        'ucrSelectorCorrelation.Focus()
        clsDefaultFunction.SetRCommand("cor")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        bResetSubdialog = True
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumns.ControlValueChanged
        ColumnTypeChanged()
    End Sub

    Private Sub ColumnTypeChanged()
        If rdoTwoColumns.Checked Then
            ucrBase.clsRsyntax.iCallType = 2
            ucrReceiverFirstColumn.SetMeAsReceiver()
            ucrBase.clsRsyntax.SetFunction("cor.test")
            grpMissing.Visible = False
            cmdOptions.Visible = False
            ucrBase.clsRsyntax.RemoveParameter("use")
            ucrBase.clsRsyntax.AddParameter("alternative", Chr(34) & "two.sided" & Chr(34))
            ucrBase.clsRsyntax.AddParameter("exact", "NULL")
        ElseIf rdoMultipleColumns.Checked Then
            ucrBase.clsRsyntax.iCallType = 0
            ucrReceiverMultipleColumns.SetMeAsReceiver()
            ucrBase.clsRsyntax.SetFunction("cor")
            grpMissing.Visible = True
            cmdOptions.Visible = True
            ucrBase.clsRsyntax.RemoveParameter("alternative")
            ucrBase.clsRsyntax.RemoveParameter("exact")
            'sdgCorrPlot.CorrOptions()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdPlots_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        ' Link the base function to the sub dialog
        sdgCorrPlot.SetRFunction(ucrBase.clsRsyntax.clsBaseFunction, bResetSubdialog)
        bResetSubdialog = False
        sdgCorrPlot.ShowDialog()
    End Sub

    Public Sub TestOKEnabled()
        If rdoTwoColumns.Checked Then
            'ucrBase.clsRsyntax.RemoveAssignTo()

            If (Not ucrReceiverFirstColumn.IsEmpty()) AndAlso (Not ucrReceiverSecondColumn.IsEmpty()) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoMultipleColumns.Checked AndAlso ucrReceiverMultipleColumns.lstSelectedVariables.Items.Count > 1 Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
        'If (rdoMultipleColumns.Checked) AndAlso (ucrChkSaveModel.ucrChkSave.Checked OrElse ucrChkCorelationMatrix.chkCheck.Checked OrElse sdgCorrPlot.rdoCorrelationPlot.Checked OrElse sdgCorrPlot.rdoScatterplotMatrix.Checked OrElse sdgCorrPlot.rdoPairwisePlot.Checked) Then
        '    If (Not ucrReceiverMultipleColumns.IsEmpty()) AndAlso ucrReceiverMultipleColumns.lstSelectedVariables.Items.Count > 1 AndAlso (rdoCompleteRows.Checked OrElse rdoPairwise.Checked) AndAlso (rdoPearson.Checked OrElse rdoKendall.Checked OrElse rdoSpearman.Checked) Then
        '        'SaveModel()
        '        TempData()
        '        'AssignModelName()
        '    End If
        'End If
    End Sub


    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        If rdoMultipleColumns.Checked AndAlso ((sdgCorrPlot.rdoPairwisePlot.Checked OrElse sdgCorrPlot.rdoCorrelationPlot.Checked OrElse sdgCorrPlot.rdoScatterplotMatrix.Checked)) Then
            frmMain.clsRLink.RunScript(ucrBase.clsRsyntax.GetScript(), 2)
        End If
        If sdgCorrPlot.rdoNone.Checked AndAlso (ucrChkCorelationMatrix.chkCheck.Checked) Then
            'ucrBase.clsRsyntax.RemoveAssignTo()
            frmMain.clsRLink.RunScript(ucrBase.clsRsyntax.GetScript(), 2)
        End If
    End Sub

    'Public Sub AssignModelName()
    '    If ucrSaveModel.chkSaveModel.Checked AndAlso ucrSaveModel.ucrInputModelName.GetText() <> "" AndAlso rdoMultipleColumns.Checked AndAlso sdgCorrPlot.rdoNone.Checked Then
    '        ucrBase.clsRsyntax.SetAssignTo(ucrSaveModel.ucrInputModelName.GetText(), strTempModel:=ucrSaveModel.ucrInputModelName.GetText(), strTempDataframe:=ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
    '        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
    '        ucrBase.clsRsyntax.iCallType = 0
    '    ElseIf sdgcorrplot.ucrSaveGraph.bSaveGraph Then
    '        ucrBase.clsRsyntax.SetAssignTo(sdgCorrPlot.ucrSaveGraph.strGraphName, strTempDataframe:=ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=sdgCorrPlot.ucrSaveGraph.strGraphName)
    '        ucrBase.clsRsyntax.iCallType = 0
    '    Else
    '        ucrBase.clsRsyntax.iCallType = 2
    '        ucrBase.clsRsyntax.RemoveAssignTo()
    '    End If
    'End Sub
    'Public Sub SaveModel()
    '    If chkCorrelationMatrix.Checked AndAlso sdgCorrPlot.rdoNone.Checked AndAlso rdoMultipleColumns.Checked Then
    '        ucrSaveModel.Visible = True
    '    Else
    '        ucrSaveModel.Visible = False
    '    End If
    'End Sub

    'Private Sub ucrSaveModel_CheckedChanged(bChecked As Boolean)
    '    TestOKEnabled()
    'End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstColumn.ControlContentsChanged, ucrReceiverSecondColumn.ControlContentsChanged, ucrReceiverMultipleColumns.ControlContentsChanged, ucrChkSaveModel.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorCorrelation_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorCorrelation.ControlContentsChanged
        sdgCorrPlot.chkColour.Checked = False
        sdgCorrPlot.SetDataFrame(strNewDataFrame:=ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        TempData()
    End Sub

    Public Sub TempData()
        clsTempFunc = ucrSelectorCorrelation.ucrAvailableDataFrames.clsCurrDataFrame.Clone()
        clsTempFunc.AddParameter("remove_attr", "TRUE")
        sdgCorrPlot.clsRGraphics.AddParameter("data", clsRFunctionParameter:=clsTempFunc)
        sdgCorrPlot.clsRGGscatmatrix.AddParameter("data", clsRFunctionParameter:=clsTempFunc)
    End Sub
End Class