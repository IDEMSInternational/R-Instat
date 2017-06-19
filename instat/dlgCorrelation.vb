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
Public Class dlgCorrelation
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsCorrelationTestFunction, clsCorrelationFunction As New RFunction
    Private Sub dlgCorrelation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 421

        ucrReceiverFirstColumn.SetParameter(New RParameter("x", 0))
        ucrReceiverFirstColumn.SetParameterIsRFunction()
        ucrReceiverFirstColumn.Selector = ucrSelectorCorrelation
        ucrReceiverFirstColumn.SetDataType("numeric")

        ucrReceiverSecondColumn.SetParameter(New RParameter("y", 1))
        ucrReceiverSecondColumn.SetParameterIsRFunction()
        ucrReceiverSecondColumn.Selector = ucrSelectorCorrelation
        ucrReceiverSecondColumn.SetDataType("numeric")

        ucrReceiverMultipleColumns.Selector = ucrSelectorCorrelation
        ucrReceiverMultipleColumns.SetParameterIsRFunction()
        ucrReceiverMultipleColumns.SetDataType("numeric")
        ucrReceiverMultipleColumns.SetMeAsReceiver()

        ucrSelectorCorrelation.Focus()

        ucrSaveModel.chkSaveModel.Text = "Result Name"
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        'TODO: Fix bugs produced when rdoScatterplotMatrix is checked. Disabled for now
        sdgCorrPlot.rdoScatterplotMatrix.Enabled = False

        sdgCorrPlot.ucrSelectFactor.SetDataframe(ucrSelectorCorrelation.ucrAvailableDataFrames.strCurrDataFrame, bEnableDataframe:=False)

        ucrNudConfidenceInterval.SetParameter(New RParameter("conf.level", 3))
        ucrNudConfidenceInterval.SetMinMax(0, 100)
        ucrNudConfidenceInterval.DecimalPlaces = 2
        ucrNudConfidenceInterval.Increment = 0.05
        ucrNudConfidenceInterval.SetRDefault(0.95)

        ucrPnlColumns.AddRadioButton(rdoTwoColumns)
        ucrPnlColumns.AddRadioButton(rdoMultipleColumns)
        ucrPnlColumns.AddFunctionNamesCondition(rdoTwoColumns, "cor.test")
        ucrPnlColumns.AddFunctionNamesCondition(rdoMultipleColumns, "cor")

        ucrPnlMethod.SetParameter(New RParameter("method", 4))
        ucrPnlMethod.AddRadioButton(rdoPearson, Chr(34) & "pearson" & Chr(34))
        ucrPnlMethod.AddRadioButton(rdoKendall, Chr(34) & "kendall" & Chr(34))
        ucrPnlMethod.AddRadioButton(rdoSpearman, Chr(34) & "spearman" & Chr(34))

        ucrPnlMethod.AddParameterValuesCondition(rdoPearson, "method", "pearson")
        ucrPnlMethod.AddParameterValuesCondition(rdoPearson, "method", "pearson", False)
        ucrPnlMethod.AddParameterValuesCondition(rdoPearson, "method", "pearson", False)

        ucrPnlMethod.AddParameterValuesCondition(rdoKendall, "method", "kendall")
        ucrPnlMethod.AddParameterValuesCondition(rdoKendall, "method", "pearson", False)
        ucrPnlMethod.AddParameterValuesCondition(rdoKendall, "method", "pearson", False)

        ucrPnlMethod.AddParameterValuesCondition(rdoSpearman, "method", "spearman")
        ucrPnlMethod.AddParameterValuesCondition(rdoSpearman, "method", "pearson", False)
        ucrPnlMethod.AddParameterValuesCondition(rdoSpearman, "method", "pearson", False)

        ucrPnlCompletePairwise.SetParameter(New RParameter("use", 5))
        ucrPnlCompletePairwise.AddRadioButton(rdoPairwise, Chr(34) & "pairwise.complete.obs" & Chr(34))
        ucrPnlCompletePairwise.AddRadioButton(rdoCompleteRowsOnly, Chr(34) & "complete.obs" & Chr(34))
        'ucrChk
        ucrChkCorrelationMatrix.SetText("Correlation Matrix")

        ucrPnlColumns.AddToLinkedControls({ucrReceiverFirstColumn, ucrNudConfidenceInterval, ucrReceiverSecondColumn}, {rdoTwoColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumns.AddToLinkedControls({ucrReceiverMultipleColumns}, {rdoMultipleColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudConfidenceInterval.SetLinkedDisplayControl(lblConfInterval)
        ucrPnlColumns.AddToLinkedControls(ucrPnlCompletePairwise, {rdoMultipleColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlCompletePairwise.SetLinkedDisplayControl(grpMissing)
    End Sub

    Private Sub SetDefaults()
        clsCorrelationTestFunction = New RFunction
        clsCorrelationFunction = New RFunction
        ucrBase.clsRsyntax.iCallType = 2

        clsCorrelationTestFunction.SetRCommand("cor.test")
        clsCorrelationFunction.SetRCommand("cor")
        clsCorrelationTestFunction.AddParameter("alternative", Chr(34) & "two.sided" & Chr(34))
        clsCorrelationTestFunction.AddParameter("exact", "NULL")
        clsCorrelationTestFunction.AddParameter("conf.level", "0.95")
        ucrBase.clsRsyntax.SetBaseRFunction(clsCorrelationFunction)

        sdgCorrPlot.SetDefaults()
        ucrSelectorCorrelation.Reset()
        ucrSaveModel.ucrInputModelName.SetName("Cor")
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverMultipleColumns.AddAdditionalCodeParameterPair(clsCorrelationFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        'ucrNudConfidenceInterval.AddAdditionalCodeParameterPair(clsCorrelationFunction, New RParameter("conf.level", 3), iAdditionalPairNo:=1)

        ucrReceiverMultipleColumns.SetRCode(clsCorrelationFunction, bReset)
        ucrNudConfidenceInterval.SetRCode(clsCorrelationTestFunction, bReset)
        ucrReceiverFirstColumn.SetRCode(clsCorrelationTestFunction, bReset)
        ucrReceiverSecondColumn.SetRCode(clsCorrelationTestFunction, bReset)
        ucrPnlColumns.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlMethod.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Public Sub TestOKEnabled()
        If rdoTwoColumns.Checked Then
            ucrBase.clsRsyntax.RemoveAssignTo()
            If (Not ucrReceiverFirstColumn.IsEmpty()) AndAlso (Not ucrReceiverSecondColumn.IsEmpty()) AndAlso (rdoPearson.Checked = True Or rdoKendall.Checked = True Or rdoSpearman.Checked = True) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoMultipleColumns.Checked AndAlso ucrReceiverMultipleColumns.lstSelectedVariables.Items.Count > 1 AndAlso (rdoCompleteRowsOnly.Checked OrElse rdoPairwise.Checked) AndAlso (rdoPearson.Checked OrElse rdoKendall.Checked OrElse rdoSpearman.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
        'If (rdoMultipleColumns.Checked) AndAlso (ucrSaveModel.chkSaveModel.Checked OrElse chkCorrelationMatrix.Checked OrElse sdgCorrPlot.rdoCorrelationPlot.Checked OrElse sdgCorrPlot.rdoScatterplotMatrix.Checked OrElse sdgCorrPlot.rdoPairwisePlot.Checked) Then
        '    If (Not ucrReceiverMultipleColumns.IsEmpty()) AndAlso ucrReceiverMultipleColumns.lstSelectedVariables.Items.Count > 1 AndAlso (rdoCompleteRowsOnly.Checked OrElse rdoPairwise.Checked) AndAlso (rdoPearson.Checked OrElse rdoKendall.Checked OrElse rdoSpearman.Checked) Then
        '        SaveModel()
        '        TempData()
        '        AssignModelName()
        '    End If
        'End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If rdoTwoColumns.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCorrelationTestFunction)
        ElseIf rdoMultipleColumns.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCorrelationFunction)
        End If
    End Sub

    Private Sub ucrReceiverFirstColumn_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstColumn.ControlContentsChanged, ucrReceiverSecondColumn.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlPairwise_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCompletePairwise.ControlValueChanged
        If rdoCompleteRowsOnly.Checked Then
            clsCorrelationFunction.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34))
        ElseIf rdoPairwise.Checked Then
            clsCorrelationFunction.AddParameter("use", Chr(34) & "complete.obs" & Chr(34))
        End If
    End Sub

    Public Sub ucrReceiverMultipleColumns_SelectionChanged() Handles ucrReceiverMultipleColumns.SelectionChanged
        If Not ucrReceiverMultipleColumns.IsEmpty() Then
            ' clsRCorrelation.AddParameter("x", clsRFunctionParameter:=ucrReceiverMultipleColumns.GetVariables())
            sdgCorrPlot.clsRGraphics.AddParameter("columns", ucrReceiverMultipleColumns.GetVariableNames())
            sdgCorrPlot.clsRGGscatmatrix.AddParameter("columns", ucrReceiverMultipleColumns.GetVariableNames)
        End If
        TestOKEnabled()
    End Sub

    'Private Sub rdoForMethodsCheckedChanged(sender As Object, e As EventArgs) Handles rdoPearson.CheckedChanged, rdoKendall.CheckedChanged, rdoSpearman.CheckedChanged
    '    If rdoPearson.Checked Then
    '        clsRCorrelation.AddParameter("method", Chr(34) & "pearson" & Chr(34))
    '        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
    '            clsRCorrelation.AddParameter("method", Chr(34) & "pearson" & Chr(34))
    '        Else
    '            clsRCorrelation.RemoveParameterByName("method")
    '        End If
    '    ElseIf rdoKendall.Checked Then
    '        clsRCorrelation.AddParameter("method", Chr(34) & "kendall" & Chr(34))

    '    ElseIf rdoSpearman.Checked Then
    '        clsRCorrelation.AddParameter("method", Chr(34) & "spearman" & Chr(34))
    '    Else
    '        clsRCorrelation.RemoveParameterByName("method")
    '    End If
    'End Sub

    'Private Sub SetTwoColumnAsFunction()
    '    ucrBase.clsRsyntax.iCallType = 2
    '    ucrReceiverFirstColumn.SetMeAsReceiver()
    '    'clsRCorrelation.SetRCommand("cor.test")
    '    ucrBase.clsRsyntax.SetBaseRFunction(clsRCorrelation)
    '    grpMissing.Visible = False
    '    cmdOptions.Visible = False
    '    lblConfInterval.Visible = True
    '    'nudConfidenceInterval.Visible = True
    '    ucrReceiverFirstColumn.Visible = True
    '    ucrReceiverSecondColumn.Visible = True
    '    ucrReceiverMultipleColumns.Visible = False
    '    clsRCorrelation.RemoveParameterByName("use")
    '    ' If nudConfidenceInterval.Value.ToString = "" Then
    '    'nudConfidenceInterval.Value = 0.95
    '    'End If
    '    'clsRCorrelation.AddParameter("conf.level", nudConfidenceInterval.Value.ToString)
    '    clsRCorrelation.AddParameter("x", clsRFunctionParameter:=ucrReceiverFirstColumn.GetVariables())
    '    clsRCorrelation.AddParameter("y", clsRFunctionParameter:=ucrReceiverSecondColumn.GetVariables())
    '    'clsRCorrelation.AddParameter("alternative", Chr(34) & "two.sided" & Chr(34))
    '    'clsRCorrelation.AddParameter("exact", "NULL")
    '    bIsTwoColumnFunction = True
    '    TestOKEnabled()
    'End Sub

    Private Sub nudConfidenceInterval_ValueChanged(sender As Object, e As EventArgs)
        'clsRCorrelation.AddParameter("conf.level", nudConfidenceInterval.Value.ToString)
    End Sub

    'Public Sub SetMultipleColumnAsFunction()
    '    ucrBase.clsRsyntax.iCallType = 0
    '    ucrReceiverMultipleColumns.SetMeAsReceiver()
    '    'clsRCorrelation.SetRCommand("cor")
    '    grpMissing.Visible = True
    '    cmdOptions.Visible = True
    '    lblConfInterval.Visible = False
    '    'nudConfidenceInterval.Visible = False
    '    ucrReceiverFirstColumn.Visible = False
    '    ucrReceiverSecondColumn.Visible = False
    '    ucrReceiverMultipleColumns.Visible = True
    '    'clsRCorrelation.RemoveParameterByName("alternative")
    '    'clsRCorrelation.RemoveParameterByName("exact")
    '    'clsRCorrelation.RemoveParameterByName("conf.level")
    '    'clsRCorrelation.RemoveParameterByName("y")
    '    'SetUseParameter()
    '    clsRCorrelation.AddParameter("x", clsRFunctionParameter:=ucrReceiverMultipleColumns.GetVariables())
    '    'bIsTwoColumnFunction = False
    '    TestOKEnabled()
    'End Sub

    Private Sub ColumnTypeChanged(sender As Object, e As EventArgs)
        If rdoTwoColumns.Checked Then
            'SetTwoColumnAsFunction()
        ElseIf rdoMultipleColumns.Checked Then
            'SetMultipleColumnAsFunction()
            sdgCorrPlot.CorrOptions()
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdPlots_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgCorrPlot.ShowDialog()
    End Sub

    Private Sub ucrReceiverMultipleColumns_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverMultipleColumns.SelectionChanged

    End Sub

    'Public Sub TempData()
    '    clsTempFunc = ucrSelectorCorrelation.ucrAvailableDataFrames.clsCurrDataFrame.Clone()
    '    clsTempFunc.AddParameter("remove_attr", "TRUE")
    '    sdgCorrPlot.clsRGraphics.AddParameter("data", clsRFunctionParameter:=clsTempFunc)
    '    sdgCorrPlot.clsRGGscatmatrix.AddParameter("data", clsRFunctionParameter:=clsTempFunc)
    'End Sub

    'Private Sub ucrSelectorCorrelation_DataFrameChanged() Handles ucrSelectorCorrelation.DataFrameChanged
    '    TestOKEnabled()
    '    sdgCorrPlot.chkColour.Checked = False
    '    sdgCorrPlot.SetDataFrame(strNewDataFrame:=ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    'End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        'If rdoMultipleColumns.Checked AndAlso chkCorrelationMatrix.Checked AndAlso ((sdgCorrPlot.rdoPairwisePlot.Checked OrElse sdgCorrPlot.rdoCorrelationPlot.Checked OrElse sdgCorrPlot.rdoScatterplotMatrix.Checked)) Then
        '    frmMain.clsRLink.RunScript(clsRCorrelation.ToScript(), 2)
        'End If
        'If ucrSaveModel.chkSaveModel.Checked AndAlso sdgCorrPlot.rdoNone.Checked AndAlso (chkCorrelationMatrix.Checked) Then
        '    ucrBase.clsRsyntax.RemoveAssignTo()
        '    frmMain.clsRLink.RunScript(clsRCorrelation.ToScript(), 2)
        'End If
    End Sub

    'Public Sub AssignModelName()
    '    If ucrSaveModel.chkSaveModel.Checked AndAlso ucrSaveModel.ucrInputModelName.GetText() <> "" AndAlso rdoMultipleColumns.Checked AndAlso sdgCorrPlot.rdoNone.Checked Then
    '        ucrBase.clsRsyntax.SetAssignTo(ucrSaveModel.ucrInputModelName.GetText(), strTempModel:=ucrSaveModel.ucrInputModelName.GetText(), strTempDataframe:=ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
    '        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
    '        ucrBase.clsRsyntax.iCallType = 0
    '    ElseIf sdgCorrPlot.ucrSaveGraph.bSaveGraph Then
    '        ucrBase.clsRsyntax.SetAssignTo(sdgCorrPlot.ucrSaveGraph.strGraphName, strTempDataframe:=ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=sdgCorrPlot.ucrSaveGraph.strGraphName)
    '        ucrBase.clsRsyntax.iCallType = 0
    '    Else
    '        ucrBase.clsRsyntax.iCallType = 2
    '        ucrBase.clsRsyntax.RemoveAssignTo()
    '    End If
    'End Sub
End Class