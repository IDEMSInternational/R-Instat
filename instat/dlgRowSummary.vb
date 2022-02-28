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
Public Class dlgRowSummary
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsApplyFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsOtherDummyFunction As New RFunction
    Private clsGetColumnsFunction As RFunction


    Private Sub dlgRowSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 45
        ucrReceiverForRowSummaries.Selector = ucrSelectorForRowSummaries
        ucrReceiverForRowSummaries.SetMeAsReceiver()
        ucrReceiverForRowSummaries.strSelectorHeading = "Numerics"
        ucrReceiverForRowSummaries.SetIncludedDataTypes({"numeric"})
        ucrReceiverForRowSummaries.SetParameterIsRFunction()

        ucrChkIgnoreMissingValues.AddParameterPresentCondition(True, "na.rm")
        ucrChkIgnoreMissingValues.AddParameterPresentCondition(False, "na.rm", False)
        ucrChkIgnoreMissingValues.SetText("Ignore Missing Values")

        'linking controls
        ucrPnlRowSummaries.AddRadioButton(rdoSingle)
        ucrPnlRowSummaries.AddRadioButton(rdoMultiple)

        ucrPnlRowSummaries.AddFunctionNamesCondition(rdoSingle, {"apply"})

        ucrPnlStatistics.AddToLinkedControls(ucrChkIgnoreMissingValues, {rdoMean, rdoMinimum, rdoSum, rdoMedian, rdoStandardDeviation, rdoMaximum}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStatistics.AddToLinkedControls(ucrInputUserDefined, {rdoMore}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlStatistics.SetParameter(New RParameter("checked", 0))
        ucrPnlStatistics.AddRadioButton(rdoMean, "mean")
        ucrPnlStatistics.AddRadioButton(rdoMinimum, "min")
        ucrPnlStatistics.AddRadioButton(rdoSum, "sum")
        ucrPnlStatistics.AddRadioButton(rdoMedian, "median")
        ucrPnlStatistics.AddRadioButton(rdoNumberMissing, "number missing")
        ucrPnlStatistics.AddRadioButton(rdoStandardDeviation, "sd")
        ucrPnlStatistics.AddRadioButton(rdoMaximum, "max")
        ucrPnlStatistics.AddRadioButton(rdoCount, "count")
        ucrPnlStatistics.AddRadioButton(rdoMore, "user_defined")

        'ucrInputUserDefined
        ucrInputUserDefined.SetItems({"sum", "mean", "median", "sd", "min", "max", "count", "number missing"})

        ucrSaveResults.SetPrefix("row_summary")
        ucrSaveResults.SetSaveTypeAsColumn()
        ucrSaveResults.SetDataFrameSelector(ucrSelectorForRowSummaries.ucrAvailableDataFrames)
        ucrSaveResults.SetLabelText("New Column Name:")
        ucrSaveResults.SetIsComboBox()
        ucrSaveResults.setLinkedReceiver(ucrReceiverForRowSummaries)
    End Sub

    Private Sub SetDefaults()
        clsApplyFunction = New RFunction
        clsDummyFunction = New RFunction
        clsOtherDummyFunction = New RFunction
        clsGetColumnsFunction = New RFunction

        'reset
        ucrSelectorForRowSummaries.Reset()
        ucrSaveResults.Reset()
        ucrInputUserDefined.cboInput.SelectedIndex = 1

        clsOtherDummyFunction.AddParameter("checked", "mean", iPosition:=0)

        'Defining the default RFunction
        clsApplyFunction.SetPackageName("base")
        clsApplyFunction.SetRCommand("apply")
        clsApplyFunction.AddParameter("FUN", "mean", iPosition:=2)
        clsApplyFunction.AddParameter("MARGIN", 1)
        clsApplyFunction.SetAssignTo(ucrSaveResults.GetText, strTempDataframe:=ucrSelectorForRowSummaries.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        ucrBase.clsRsyntax.SetBaseRFunction(clsApplyFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrChkIgnoreMissingValues.SetRCode(clsApplyFunction, bReset)
        ucrPnlStatistics.SetRCode(clsOtherDummyFunction, bReset)
        ucrSaveResults.SetRCode(clsApplyFunction, bReset)

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverForRowSummaries.IsEmpty AndAlso ucrSaveResults.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForRowSummaries.ControlContentsChanged, ucrSaveResults.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkIgnoreMissingValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIgnoreMissingValues.ControlValueChanged, ucrPnlStatistics.ControlValueChanged, ucrInputUserDefined.ControlValueChanged
        If ucrChkIgnoreMissingValues.Checked Then
            If rdoMean.Checked OrElse rdoMedian.Checked OrElse rdoSum.Checked OrElse rdoStandardDeviation.Checked OrElse rdoMinimum.Checked OrElse rdoMaximum.Checked Then
                clsApplyFunction.AddParameter("na.rm", "TRUE", iPosition:=3)
            Else
                clsApplyFunction.RemoveParameterByName("na.rm")
            End If
        Else
            clsApplyFunction.RemoveParameterByName("na.rm")
        End If
        If rdoMore.Checked Then
            clsOtherDummyFunction.AddParameter("checked", "user_defined", iPosition:=0)
            clsApplyFunction.AddParameter("FUN", ucrInputUserDefined.GetText, iPosition:=2)
        ElseIf rdoMean.Checked Then
            clsOtherDummyFunction.AddParameter("checked", "mean", iPosition:=0)
            clsApplyFunction.AddParameter("FUN", "mean", iPosition:=2)
        ElseIf rdoMaximum.Checked Then
            clsOtherDummyFunction.AddParameter("checked", "max", iPosition:=0)
            clsApplyFunction.AddParameter("FUN", "max", iPosition:=2)
        ElseIf rdoMinimum.Checked Then
            clsOtherDummyFunction.AddParameter("checked", "min", iPosition:=0)
            clsApplyFunction.AddParameter("FUN", "min", iPosition:=2)
        ElseIf rdoStandardDeviation.Checked Then
            clsOtherDummyFunction.AddParameter("checked", "sd", iPosition:=0)
            clsApplyFunction.AddParameter("FUN", "sd", iPosition:=2)
        ElseIf rdoSum.Checked Then
            clsOtherDummyFunction.AddParameter("checked", "sum", iPosition:=0)
            clsApplyFunction.AddParameter("FUN", "sum", iPosition:=2)
        ElseIf rdoMedian.Checked Then
            clsOtherDummyFunction.AddParameter("checked", "median", iPosition:=0)
            clsApplyFunction.AddParameter("FUN", "median", iPosition:=2)
        ElseIf rdoCount.Checked Then
            clsOtherDummyFunction.AddParameter("checked", "count", iPosition:=0)
            clsApplyFunction.AddParameter("FUN", "function(z) sum(!is.na(z))", iPosition:=2)
        ElseIf rdoNumberMissing.Checked Then
            clsOtherDummyFunction.AddParameter("checked", "number missing", iPosition:=0)
            clsApplyFunction.AddParameter("FUN", "function(z) sum(is.na(z))", iPosition:=2)
        Else
            clsApplyFunction.RemoveParameterByName("FUN")
        End If
    End Sub

    Private Sub ucrReceiverForRowSummaries_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForRowSummaries.ControlValueChanged
        ucrBase.clsRsyntax.lstBeforeCodes.Clear()
        clsGetColumnsFunction = ucrReceiverForRowSummaries.GetVariables(True).Clone
        clsGetColumnsFunction.SetAssignTo("columns")
        clsApplyFunction.AddParameter("X", clsRFunctionParameter:=clsGetColumnsFunction, iPosition:=0)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetColumnsFunction)
    End Sub
End Class