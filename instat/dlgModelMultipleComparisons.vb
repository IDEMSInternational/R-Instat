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

Public Class dlgModelMultipleComparisons
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private clsMultipleComparisonsFunction As New RFunction
    Private clsGetModelFunction As New RFunction
    Private clsAssignModelOperator As New ROperator
    Private clsRmFunction As New RFunction

    Private Sub dlgModelMultipleComparisons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()

        ucrBase.iHelpTopicID = 0
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrReceiverMultipleMeanComparisonUseModel.SetItemType(RObjectTypeLabel.Model)
        ucrReceiverMultipleMeanComparisonUseModel.Selector = ucrSelectorModelMultipleComparisons
        ucrReceiverMultipleMeanComparisonUseModel.SetMeAsReceiver()
        ucrReceiverMultipleMeanComparisonUseModel.strSelectorHeading = "Models"

        ucrReceiverLabelVariable.Selector = ucrSelectorModelMultipleComparisons
        ucrReceiverLabelVariable.SetParameter(New RParameter("classify", 1))
        ucrReceiverLabelVariable.SetParameterIsString()
        ucrReceiverLabelVariable.SetIncludedDataTypes({"factor"})

        ucrReceiverBy.Selector = ucrSelectorModelMultipleComparisons
        ucrReceiverBy.SetParameter(New RParameter("by", 2))
        ucrReceiverBy.SetParameterIsString()
        ucrReceiverBy.SetIncludedDataTypes({"factor"})

        ucrChkAlpha.SetText("Alpha")
        ucrInputComboBoxAlpha.SetItems({"0.001", "0.01", "0.02", "0.05", "0.1"})
        ucrInputComboBoxAlpha.SetDropDownStyleAsNonEditable()
        ucrInputComboBoxAlpha.AddQuotesIfUnrecognised = False
        ucrInputComboBoxAlpha.SetParameter(New RParameter("sig", 3))
        ucrChkAlpha.AddToLinkedControls(ucrInputComboBoxAlpha, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05")

        ucrChkConfidenceInterval.SetText("Confidence Interval")
        ucrInputComboBoxConfidenceInterval.SetItems({"ci", "tukey", "1se", "2se", "none"})
        ucrInputComboBoxConfidenceInterval.SetDropDownStyleAsNonEditable()
        ucrInputComboBoxConfidenceInterval.AddQuotesIfUnrecognised = True
        ucrInputComboBoxConfidenceInterval.SetParameter(New RParameter("int.type", 4))
        ucrChkConfidenceInterval.AddToLinkedControls(ucrInputComboBoxConfidenceInterval, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="ci")

        ucrChkDisplayLetters.SetText("Display Letters")
        ucrInputComboBoxDisplayLetters.SetItems({"TRUE", "FALSE"})
        ucrInputComboBoxDisplayLetters.SetDropDownStyleAsNonEditable()
        ucrInputComboBoxDisplayLetters.AddQuotesIfUnrecognised = False
        ucrInputComboBoxDisplayLetters.SetParameter(New RParameter("groups", 7))
        ucrChkDisplayLetters.AddToLinkedControls(ucrInputComboBoxDisplayLetters, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")

        ucrChkDescending.SetText("Descending")
        ucrInputComboBoxDescending.SetItems({"TRUE", "FALSE"})
        ucrInputComboBoxDescending.SetDropDownStyleAsNonEditable()
        ucrInputComboBoxDescending.AddQuotesIfUnrecognised = False
        ucrInputComboBoxDescending.SetParameter(New RParameter("descending", 5))
        ucrChkDescending.AddToLinkedControls(ucrInputComboBoxDescending, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")

        ucrChkAdjustment.SetText("Adjustment")
        ucrInputComboBoxAdjustment.SetItems({"tukey", "bonferroni", "holm", "hochberg", "hommel", "BH", "BY", "none"})
        ucrInputComboBoxAdjustment.SetDropDownStyleAsNonEditable()
        ucrInputComboBoxAdjustment.AddQuotesIfUnrecognised = True
        ucrInputComboBoxAdjustment.SetParameter(New RParameter("adjust", 6))
        ucrChkAdjustment.AddToLinkedControls(ucrInputComboBoxAdjustment, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="tukey")

        ucrSaveModelMultipleComparisons.SetPrefix("mct")
        ucrSaveModelMultipleComparisons.SetCheckBoxText("Store mct:")
        ucrSaveModelMultipleComparisons.SetIsComboBox()
        ucrSaveModelMultipleComparisons.SetSaveType(strRObjectType:=RObjectTypeLabel.Summary, strRObjectFormat:=RObjectFormat.Text)
    End Sub

    Private Sub SetDefaults()

        clsGetModelFunction = New RFunction
        clsGetModelFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")

        clsAssignModelOperator = New ROperator
        clsAssignModelOperator.SetOperation("<-")
        clsAssignModelOperator.AddParameter("left", "model_tmp", iPosition:=0)
        clsAssignModelOperator.AddParameter("right", clsRFunctionParameter:=clsGetModelFunction, iPosition:=1)
        clsAssignModelOperator.bToScriptAsRString = False


        clsMultipleComparisonsFunction = New RFunction
        clsMultipleComparisonsFunction.SetPackageName("biometryassist")
        clsMultipleComparisonsFunction.SetRCommand("multiple_comparisons")
        clsMultipleComparisonsFunction.AddParameter("model.obj", "model_tmp", iPosition:=0)

        clsRmFunction = New RFunction
        clsRmFunction.SetRCommand("rm")
        clsRmFunction.AddParameter("list", "c(""model_tmp"")", bIncludeArgumentName:=True, iPosition:=0)
        clsRmFunction.bToScriptAsRString = False

        ucrSelectorModelMultipleComparisons.Reset()
        ucrSaveModelMultipleComparisons.Reset()
        ucrSaveModelMultipleComparisons.ucrChkSave.Checked = False

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsAssignModelOperator)
        ucrBase.clsRsyntax.SetBaseRFunction(clsMultipleComparisonsFunction)
        ucrBase.clsRsyntax.AddToAfterCodes(clsRmFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

        ucrReceiverLabelVariable.SetRCode(clsMultipleComparisonsFunction, bReset)
        ucrReceiverBy.SetRCode(clsMultipleComparisonsFunction, bReset)
        ucrInputComboBoxDisplayLetters.SetRCode(clsMultipleComparisonsFunction, bReset)
        ucrInputComboBoxConfidenceInterval.SetRCode(clsMultipleComparisonsFunction, bReset)

        ucrInputComboBoxAlpha.SetRCode(clsMultipleComparisonsFunction, bReset)
        ucrInputComboBoxDescending.SetRCode(clsMultipleComparisonsFunction, bReset)
        ucrInputComboBoxAdjustment.SetRCode(clsMultipleComparisonsFunction, bReset)

        If bReset Then

            ucrChkAlpha.SetRCode(clsMultipleComparisonsFunction, bReset)
            ucrChkConfidenceInterval.SetRCode(clsMultipleComparisonsFunction, bReset)
            ucrChkDisplayLetters.SetRCode(clsMultipleComparisonsFunction, bReset)
            ucrChkDescending.SetRCode(clsMultipleComparisonsFunction, bReset)
            ucrChkAdjustment.SetRCode(clsMultipleComparisonsFunction, bReset)

        End If
    End Sub

    Private Sub TestOkEnabled()
        Dim bOKEnabled As Boolean = Not ucrReceiverMultipleMeanComparisonUseModel.IsEmpty() AndAlso
                                    Not ucrReceiverLabelVariable.IsEmpty() AndAlso
                                    ucrSaveModelMultipleComparisons.IsComplete()

        ucrBase.OKEnabled(bOKEnabled)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverMultipleMeanComparisonUseModel_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverMultipleMeanComparisonUseModel.SelectionChanged
        If Not ucrReceiverMultipleMeanComparisonUseModel.IsEmpty() Then
            clsGetModelFunction.AddParameter("object_name", ucrReceiverMultipleMeanComparisonUseModel.GetVariableNames())
            UpdateSaveName()
        Else
            clsGetModelFunction.RemoveParameterByName("object_name")
        End If
        TestOkEnabled()
    End Sub

    'Updates the Default name In the "Store mct:" save control based On the currently selected model, rather than the Label Variable
    'strips off the prefix before the first underscore And uses the remainder As the suffix For the mct Object name
    Private Sub UpdateSaveName()
        Dim strModelName As String = ucrReceiverMultipleMeanComparisonUseModel.GetVariableNames(bWithQuotes:=False)
        Dim iUnderscoreIndex As Integer = strModelName.IndexOf("_"c)

        If iUnderscoreIndex >= 0 AndAlso iUnderscoreIndex < strModelName.Length - 1 Then
            ucrSaveModelMultipleComparisons.SetName("mct_" & strModelName.Substring(iUnderscoreIndex + 1))
        Else
            ucrSaveModelMultipleComparisons.SetName("mct_" & strModelName)
        End If
    End Sub

    Private Sub ucrSelectorModelMultipleComparisons_DataFrameChanged() Handles ucrSelectorModelMultipleComparisons.DataFrameChanged
        If Not String.IsNullOrEmpty(ucrSelectorModelMultipleComparisons.strCurrentDataFrame) Then
            clsGetModelFunction.AddParameter("data_name", Chr(34) & ucrSelectorModelMultipleComparisons.strCurrentDataFrame & Chr(34))
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveModelMultipleComparisons_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveModelMultipleComparisons.ControlValueChanged
        If ucrSaveModelMultipleComparisons.ucrChkSave.Checked AndAlso ucrSaveModelMultipleComparisons.GetText() <> "" AndAlso ucrSaveModelMultipleComparisons.IsComplete() Then
            clsMultipleComparisonsFunction.SetAssignToOutputObject(
        strRObjectToAssignTo:=ucrSaveModelMultipleComparisons.GetText(),
        strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
        strRObjectFormatToAssignTo:=RObjectFormat.Text,
        strRDataFrameNameToAddObjectTo:=ucrSelectorModelMultipleComparisons.strCurrentDataFrame,
        strObjectName:=ucrSaveModelMultipleComparisons.GetText())
        Else
            clsMultipleComparisonsFunction.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrReceiverLabelVariable_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverLabelVariable.SelectionChanged
        TestOkEnabled()
    End Sub


    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles _
        ucrReceiverLabelVariable.ControlContentsChanged,
        ucrReceiverBy.ControlContentsChanged,
        ucrSaveModelMultipleComparisons.ControlContentsChanged,
        ucrChkAlpha.ControlContentsChanged,
        ucrInputComboBoxAlpha.ControlContentsChanged,
        ucrChkConfidenceInterval.ControlContentsChanged,
        ucrChkDisplayLetters.ControlContentsChanged,
        ucrInputComboBoxConfidenceInterval.ControlContentsChanged,
        ucrChkDescending.ControlContentsChanged,
        ucrInputComboBoxDescending.ControlContentsChanged,
        ucrChkAdjustment.ControlContentsChanged,
        ucrInputComboBoxAdjustment.ControlContentsChanged

        TestOkEnabled()
    End Sub
End Class