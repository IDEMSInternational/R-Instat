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
    Public clsCorrelationTestFunction, clsCorrelationFunction As New RFunction
    Dim clsTempFunction As RFunction
    Private bResetSubdialog As Boolean = False
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
        ReopenDialog()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 421

        ucrReceiverFirstColumn.SetParameter(New RParameter("x", 0))
        ucrReceiverFirstColumn.SetParameterIsRFunction()
        ucrReceiverFirstColumn.Selector = ucrSelectorCorrelation
        ucrReceiverFirstColumn.strSelectorHeading = "Numerics"
        ucrReceiverMultipleColumns.Selector = ucrSelectorCorrelation
        ucrReceiverFirstColumn.SetDataType("numeric")
        ucrReceiverFirstColumn.SetMeAsReceiver()

        ucrReceiverSecondColumn.SetParameter(New RParameter("y", 1))
        ucrReceiverSecondColumn.SetParameterIsRFunction()
        ucrReceiverSecondColumn.strSelectorHeading = "Numerics"
        ucrReceiverSecondColumn.Selector = ucrSelectorCorrelation
        ucrReceiverSecondColumn.SetDataType("numeric")
        ucrReceiverSecondColumn.SetMeAsReceiver()
        ucrSelectorCorrelation.Focus()

        ucrReceiverMultipleColumns.Selector = ucrSelectorCorrelation
        ucrReceiverMultipleColumns.strSelectorHeading = "Numerics"
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
        ucrNudConfidenceInterval.SetMinMax(0, 1)
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
        ucrPnlMethod.SetRDefault(Chr(34) & "pearson" & Chr(34))

        ucrPnlCompletePairwise.SetParameter(New RParameter("use", 5))
        ucrPnlCompletePairwise.AddRadioButton(rdoCompleteRowsOnly, Chr(34) & "pairwise.complete.obs" & Chr(34))
        ucrPnlCompletePairwise.AddRadioButton(rdoPairwise, Chr(34) & "complete.obs" & Chr(34))
        ucrPnlCompletePairwise.SetRDefault(Chr(34) & "pairwise.complete.obs" & Chr(34))
        'ucrChk
        'ucrChkCorrelationMatrix.SetParameter(New RParameter("cor_matrix", 6))
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
        clsCorrelationFunction.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34))
        clsCorrelationTestFunction.AddParameter("method", Chr(34) & "pearson" & Chr(34))
        ucrBase.clsRsyntax.SetBaseRFunction(clsCorrelationFunction)

        sdgCorrPlot.SetDefaults()
        ucrSelectorCorrelation.Reset()
        ucrSaveModel.ucrInputModelName.SetName("Cor")
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverMultipleColumns.AddAdditionalCodeParameterPair(clsCorrelationFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverMultipleColumns.SetRCode(clsCorrelationFunction, bReset)
        ucrNudConfidenceInterval.SetRCode(clsCorrelationTestFunction, bReset)
        ucrReceiverFirstColumn.SetRCode(clsCorrelationTestFunction, bReset)
        ucrReceiverSecondColumn.SetRCode(clsCorrelationTestFunction, bReset)
        ucrPnlColumns.SetRCode(clsCorrelationFunction, bReset)
        ucrPnlMethod.SetRCode(clsCorrelationTestFunction, bReset)
        ucrPnlCompletePairwise.SetRCode(clsCorrelationFunction, bReset)
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

    Private Sub ReopenDialog()
        If rdoMultipleColumns.Checked Then
            grpMissing.Visible = True
        Else
            grpMissing.Visible = False
        End If
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

    Private Sub ucrPnlPairwise_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCompletePairwise.ControlValueChanged
        If rdoCompleteRowsOnly.Checked Then
            clsCorrelationFunction.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34))
        ElseIf rdoPairwise.Checked Then
            clsCorrelationFunction.AddParameter("use", Chr(34) & "complete.obs" & Chr(34))
        End If
    End Sub

    Private Sub ucrPnlColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumns.ControlValueChanged
        If rdoTwoColumns.Checked Then
            cmdOptions.Visible = False
        ElseIf rdoMultipleColumns.Checked Then
            cmdOptions.Visible = True
        End If
    End Sub

    Private Sub ucrReceiverFirstColumn_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstColumn.ControlContentsChanged, ucrReceiverSecondColumn.ControlContentsChanged, ucrReceiverMultipleColumns.ControlContentsChanged, ucrPnlColumns.ControlContentsChanged, ucrPnlCompletePairwise.ControlContentsChanged, ucrPnlMethod.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub cmdPlots_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgCorrPlot.SetRFunction(clsCorrelationFunction, bResetSubdialog)
        bResetSubdialog = False
        sdgCorrPlot.ShowDialog()
        TestOKEnabled()
    End Sub
End Class