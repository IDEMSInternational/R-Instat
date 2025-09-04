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
Public Class dlgTraitCorrelations
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private bRcodeSet As Boolean = True
    Private clsGetVariablesMetadataFunction, clsGetObjectRFunction, clsDummyFunction, clsCombineVarsFunction, clsFashionFunction, clsGetObjectFunction, clsGetRankingItemsFunction, clsDataFrameFunction,
        clsNamesFunction, clsMapDfrFunction, clsKendallTauFunction, clsMutateFunction, clsSelectFunction, clsMapDfr2Function, clsAesFunction, clsGgplotFunction, clsGeomBoxplotFunction, clsLabsFunction,
        clsGetObjectRFunction2 As New RFunction
    Private clsBaseLineOperator, clsObjectOperator, clsPipe2Operator, clsPipeOperator, clsNamesOperator, clsMultivarsOpeator, clsTildeOperator, clsAdditionOperator As New ROperator

    Private Sub dlgTraitCorrelations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()

        ucrBase.iHelpTopicID = 703
        ucrReceiverTrait.SetParameterIsRFunction()
        ucrReceiverTrait.Selector = ucrSelecetorTraits

        ucrReceiverTraitsToCompare.SetParameterIsRFunction()
        ucrReceiverTraitsToCompare.Selector = ucrSelecetorTraits
        ucrReceiverTraitsToCompare.strSelectorHeading = "Traits"
        ucrReceiverTraitsToCompare.SetTricotType("traits")
        ucrReceiverTraitsToCompare.bAutoFill = True

        ucrSelecetorTraits.SetParameterIsrfunction()

        ucrNudDecimalPlaces.SetParameter(New RParameter("decimals", 1))
        ucrNudDecimalPlaces.SetMinMax(0, 5)
        ucrNudDecimalPlaces.Increment = 1
        ucrNudDecimalPlaces.SetRDefault(2)
        ucrNudDecimalPlaces.SetLinkedDisplayControl(lblDecimalPlaces)

        ucrChkLeadingZeros.SetParameter(New RParameter("leading_zeros", 2))
        ucrChkLeadingZeros.SetText("Leading Zeros")
        ucrChkLeadingZeros.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkIncludePValues.SetText("Include P-Values")
        ucrChkIncludePValues.AddParameterValuesCondition(True, "value", "True")
        ucrChkIncludePValues.AddParameterValuesCondition(False, "value", "False")

        ucrPnlOutput.AddRadioButton(rdoAsDataFrame)
        ucrPnlOutput.AddRadioButton(rdoAsText)
        ucrPnlOutput.AddParameterValuesCondition(rdoAsText, "output", "as.table")
        ucrPnlOutput.AddParameterValuesCondition(rdoAsDataFrame, "output", "as.dataframe")

        ucrChkDisplayOptions.SetText("Display Options")
        ucrChkDisplayOptions.AddParameterValuesCondition(True, "display", "True")
        ucrChkDisplayOptions.AddParameterValuesCondition(False, "display", "False")

        ucrChkDisplayOptions.AddToLinkedControls({ucrChkLeadingZeros, ucrChkIncludePValues, ucrNudDecimalPlaces, ucrPnlOutput}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOutput.SetLinkedDisplayControl(grpOutput)

        ucrChkBootstrapCorrelations.SetText("Bootstrap correlations")
        ucrChkBootstrapCorrelations.AddToLinkedControls({ucrNudBootstrapCorrelations}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBootstrapCorrelations.AddParameterValuesCondition(True, "correlations", "True")
        ucrChkBootstrapCorrelations.AddParameterValuesCondition(False, "correlations", "False")

        ucrNudBootstrapCorrelations.SetParameter(New RParameter("nboot", 1))
        ucrNudBootstrapCorrelations.Increment = 1
        ucrNudBootstrapCorrelations.SetLinkedDisplayControl(lblBootstrapCorrelations)
        ucrNudBootstrapCorrelations.SetRDefault(50)
        ucrNudBootstrapCorrelations.SetText(50)

        ucrSaveCorrelation.SetDataFrameSelector(ucrSelecetorTraits.ucrAvailableDataFrames)
        ucrSaveCorrelation.SetIsComboBox()

        ucrSaveBootstrapGraph.SetDataFrameSelector(ucrSelecetorTraits.ucrAvailableDataFrames)
        ucrSaveBootstrapGraph.SetIsComboBox()
        ucrSaveBootstrapGraph.SetSaveTypeAsGraph()
        ucrSaveBootstrapGraph.SetAssignToIfUncheckedValue("last_graph")
        ucrSaveBootstrapGraph.SetCheckBoxText("Store Graph")

        HideShowOptions()
        ChangeOutputObject()
    End Sub

    Private Sub SetDefaults()
        clsGetVariablesMetadataFunction = New RFunction
        clsNamesFunction = New RFunction
        clsMutateFunction = New RFunction
        clsMapDfrFunction = New RFunction
        clsGetObjectFunction = New RFunction
        clsKendallTauFunction = New RFunction
        clsFashionFunction = New RFunction
        clsCombineVarsFunction = New RFunction
        clsDummyFunction = New RFunction
        clsGetObjectRFunction = New RFunction
        clsDataFrameFunction = New RFunction
        clsAesFunction = New RFunction
        clsGgplotFunction = New RFunction
        clsGeomBoxplotFunction = New RFunction
        clsLabsFunction = New RFunction
        clsGetObjectRFunction2 = New RFunction
        clsTildeOperator = New ROperator
        clsAdditionOperator = New ROperator
        clsBaseLineOperator = New ROperator
        clsMultivarsOpeator = New ROperator
        clsObjectOperator = New ROperator
        clsNamesOperator = New ROperator
        clsPipeOperator = New ROperator
        clsPipe2Operator = New ROperator

        ucrSelecetorTraits.Reset()
        ucrSaveCorrelation.Reset()
        ucrSaveBootstrapGraph.Reset()
        ucrReceiverTrait.SetMeAsReceiver()
        ucrNudBootstrapCorrelations.SetText(50)

        clsDummyFunction.AddParameter("display", "False", iPosition:=0)
        clsDummyFunction.AddParameter("output", "as.table", iPosition:=1)
        clsDummyFunction.AddParameter("value", "False", iPosition:=2)

        clsGetVariablesMetadataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVariablesMetadataFunction.SetAssignTo("get_index_names")

        clsGetObjectFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object")
        clsGetObjectFunction.AddParameter("object_name", Chr(34) & "rankings_list" & Chr(34), iPosition:=1)

        clsObjectOperator.SetOperation("$")
        clsObjectOperator.AddParameter("left", clsRFunctionParameter:=clsGetObjectFunction, iPosition:=0)
        clsObjectOperator.AddParameter("right", "object", iPosition:=1)
        clsObjectOperator.SetAssignTo("rankings_object")

        clsBaseLineOperator.SetOperation("<-", bBracketsTemp:=False)
        clsBaseLineOperator.SetAssignTo("baseline")

        clsMultivarsOpeator.SetOperation("<-", bBracketsTemp:=False)
        clsMultivarsOpeator.SetAssignTo("multiple_vars")

        clsCombineVarsFunction.SetRCommand("c")
        clsCombineVarsFunction.AddParameter("var1", clsROperatorParameter:=clsBaseLineOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsCombineVarsFunction.AddParameter("var2", clsROperatorParameter:=clsMultivarsOpeator, iPosition:=1, bIncludeArgumentName:=False)
        clsCombineVarsFunction.SetAssignTo("all_vars")

        clsGetRankingItemsFunction.SetRCommand("get_ranking_items")
        clsGetRankingItemsFunction.AddParameter("data", clsRFunctionParameter:=clsGetVariablesMetadataFunction, iPosition:=0)
        clsGetRankingItemsFunction.AddParameter("vars_to_get", clsRFunctionParameter:=clsCombineVarsFunction, iPosition:=1)
        clsGetRankingItemsFunction.AddParameter("index ", Chr(34) & "rankings_index" & Chr(34), iPosition:=2)
        clsGetRankingItemsFunction.AddParameter("data_object", clsROperatorParameter:=clsObjectOperator, iPosition:=1, bIncludeArgumentName:=False)
        clsGetRankingItemsFunction.SetAssignTo("compare_variables ")

        clsNamesFunction.SetRCommand("names")
        clsNamesFunction.AddParameter("names", clsRFunctionParameter:=clsGetRankingItemsFunction, bIncludeArgumentName:=False)

        clsNamesOperator.SetOperation("<-")
        clsNamesOperator.AddParameter("left", clsRFunctionParameter:=clsNamesFunction, iPosition:=0)
        clsNamesOperator.AddParameter("right", "all_vars", iPosition:=1)

        clsTildeOperator.SetOperation("~")
        clsTildeOperator.AddParameter("right", "", iPosition:=0, bIncludeArgumentName:=False)
        clsTildeOperator.AddParameter("right", "~ {k <- gosset::kendallTau_bootstrap(x = compare_variables[[.x]], y = compare_variables[[baseline]], nboot = " & ucrNudBootstrapCorrelations.GetText() & "); tibble(trait = .x, kendallTau = k)}", iPosition:=1, bIncludeArgumentName:=False)





        clsMapDfr2Function.SetPackageName("purrr")
        clsMapDfr2Function.SetRCommand("map_dfr")
        clsMapDfr2Function.AddParameter(".x", "multiple_vars", iPosition:=0)
        clsMapDfr2Function.AddParameter(".f", clsROperatorParameter:=clsTildeOperator, iPosition:=1)
        clsMapDfr2Function.SetAssignTo("kendall_bootstrap")

        clsAesFunction.SetRCommand("aes")
        clsAesFunction.AddParameter("y", "trait", iPosition:=0)
        clsAesFunction.AddParameter("x", "kendallTau", iPosition:=1)

        clsGgplotFunction.SetRCommand("ggplot")
        clsGgplotFunction.AddParameter("x", clsRFunctionParameter:=clsMapDfr2Function, iPosition:=0, bIncludeArgumentName:=False)
        clsGgplotFunction.AddParameter("y", clsRFunctionParameter:=clsAesFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsGeomBoxplotFunction.SetRCommand("geom_boxplot")

        clsLabsFunction.SetRCommand("labs")
        clsLabsFunction.AddParameter("y", Chr(34) & Chr(34), iPosition:=0)
        clsLabsFunction.AddParameter("x", Chr(34) & "Correlation with the 'Overall'" & Chr(34))

        clsAdditionOperator.SetOperation("+")
        clsAdditionOperator.AddParameter("x", clsRFunctionParameter:=clsGgplotFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsAdditionOperator.AddParameter("y", clsRFunctionParameter:=clsGeomBoxplotFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsAdditionOperator.AddParameter("z", clsRFunctionParameter:=clsLabsFunction, iPosition:=2, bIncludeArgumentName:=False)
        clsAdditionOperator.SetAssignTo(ucrSaveBootstrapGraph.GetText)

        clsKendallTauFunction.SetPackageName("~ gosset")
        clsKendallTauFunction.SetRCommand("kendallTau")
        clsKendallTauFunction.AddParameter("x", "compare_variables[[.x]]", iPosition:=0)
        clsKendallTauFunction.AddParameter("y", "compare_variables[[baseline]]", iPosition:=1)
        clsKendallTauFunction.SetAssignTo("kendall_rankings")

        clsMapDfrFunction.SetPackageName("purrr")
        clsMapDfrFunction.SetRCommand("map_dfr")
        clsMapDfrFunction.AddParameter(".x", "multiple_vars", iPosition:=0)
        clsMapDfrFunction.AddParameter("kendal", clsRFunctionParameter:=clsKendallTauFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")
        clsMutateFunction.AddParameter("trait", "multiple_vars", iPosition:=0)
        clsMutateFunction.AddParameter(".before", "everything()", iPosition:=0)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("left", clsRFunctionParameter:=clsMapDfrFunction, iPosition:=0)
        clsPipeOperator.AddParameter("right", clsRFunctionParameter:=clsMutateFunction, iPosition:=1)
        clsPipeOperator.SetAssignTo("kendall_rankings")

        clsSelectFunction.SetPackageName("dplyr")
        clsSelectFunction.SetRCommand("select")

        clsPipe2Operator.SetOperation("%>%", bBracketsTemp:=False)
        clsPipe2Operator.AddParameter("left", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        clsPipe2Operator.SetAssignTo("kendall_rankings")

        clsFashionFunction.SetPackageName("corrr")
        clsFashionFunction.SetRCommand("fashion")
        clsFashionFunction.AddParameter("var", clsROperatorParameter:=clsPipe2Operator, iPosition:=0, bIncludeArgumentName:=False)

        clsDataFrameFunction.SetRCommand("data.frame")
        clsDataFrameFunction.AddParameter("x", clsRFunctionParameter:=clsFashionFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsGetObjectRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsGetObjectRFunction.AddParameter("as_file", "TRUE", iPosition:=3)

        clsGetObjectRFunction2.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsGetObjectRFunction2.AddParameter("data_name", Chr(34) & ucrSelecetorTraits.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsGetObjectRFunction2.AddParameter("object_name", Chr(34) & ucrSaveBootstrapGraph.GetText() & Chr(34), iPosition:=1)
        clsGetObjectRFunction2.AddParameter("as_file", "TRUE", iPosition:=2)


        ucrBase.clsRsyntax.AddToBeforeCodes(clsNamesOperator, 1)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDataFrameFunction)
        ChangeOutputObject()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

        ucrNudDecimalPlaces.SetRCode(clsFashionFunction, bReset)
        ucrChkLeadingZeros.SetRCode(clsFashionFunction, bReset)
        ucrChkDisplayOptions.SetRCode(clsDummyFunction, bReset)


        If bReset Then
            ucrPnlOutput.SetRCode(clsDummyFunction, bReset)
            ucrChkIncludePValues.SetRCode(clsDummyFunction, bReset)
            ucrSaveCorrelation.SetRCode(clsDataFrameFunction, bReset)
            ucrSaveBootstrapGraph.SetRCode(clsAdditionOperator, bReset)
            ucrChkBootstrapCorrelations.Checked = False
        End If

        ChangeOutputObject()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverTrait.IsEmpty AndAlso Not ucrReceiverTraitsToCompare.IsEmpty AndAlso ucrSaveCorrelation.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)

        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub


    Private Sub ucrChkBootstrapCorrelations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBootstrapCorrelations.ControlValueChanged
        If ucrChkBootstrapCorrelations.Checked Then
            ucrBase.clsRsyntax.AddToBeforeCodes(clsAdditionOperator, 3)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetObjectRFunction2, 4)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsAdditionOperator)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetObjectRFunction2)
        End If
        HideShowOptions()
    End Sub

    Private Sub ucrNudBootstrapCorrelations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudBootstrapCorrelations.ControlValueChanged
        clsTildeOperator.AddParameter("right", "~ {k <- gosset::kendallTau_bootstrap(x = compare_variables[[.x]], y = compare_variables[[baseline]], nboot = " & ucrNudBootstrapCorrelations.GetText() & "); tibble(trait = .x, kendallTau = k)}", iPosition:=1, bIncludeArgumentName:=False)
    End Sub

    Private Sub ucrSelecetorTraits_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelecetorTraits.ControlValueChanged
        Dim DataFrame As String = ucrSelecetorTraits.strCurrentDataFrame

        clsGetVariablesMetadataFunction.AddParameter("data", Chr(34) & DataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGetObjectFunction.AddParameter("data_name", Chr(34) & DataFrame & Chr(34), iPosition:=0)
        clsGetObjectRFunction.AddParameter("data_name", Chr(34) & ucrSelecetorTraits.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsGetObjectRFunction2.AddParameter("data_name", Chr(34) & ucrSelecetorTraits.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
    End Sub

    Private Sub ucrReceiverTraitsToCompare_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverTraitsToCompare.ControlValueChanged
        clsMultivarsOpeator.AddParameter("data", ucrReceiverTraitsToCompare.GetVariableNames, iPosition:=0, bIncludeArgumentName:=False)
    End Sub

    Private Sub ucrReceiverTrait_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverTrait.ControlValueChanged
        clsBaseLineOperator.AddParameter("var", ucrReceiverTrait.GetVariableNames, iPosition:=0, bIncludeArgumentName:=False)
    End Sub

    Private Sub ucrChkIncludePValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludePValues.ControlValueChanged
        AddPValues()
    End Sub

    Private Sub AddPValues()
        If ucrChkDisplayOptions.Checked Then
            If ucrChkIncludePValues.Checked Then
                clsPipe2Operator.RemoveParameterByName("right")
                clsSelectFunction.RemoveParameterByName("select")
                clsSelectFunction.RemoveParameterByName("z")
            Else
                clsSelectFunction.AddParameter("select", "-c(`Pr(>|z|)`", iPosition:=0, bIncludeArgumentName:=False)
                clsSelectFunction.AddParameter("z", "`Zvalue`)", iPosition:=1, bIncludeArgumentName:=False)
                clsPipe2Operator.AddParameter("right", clsRFunctionParameter:=clsSelectFunction, iPosition:=1)
            End If
        Else
            clsSelectFunction.AddParameter("select", "-c(`Pr(>|z|)`", iPosition:=0, bIncludeArgumentName:=False)
            clsSelectFunction.AddParameter("z", "`Zvalue`)", iPosition:=1, bIncludeArgumentName:=False)
            clsPipe2Operator.AddParameter("right", clsRFunctionParameter:=clsSelectFunction, iPosition:=1)
        End If
    End Sub

    Private Sub AddingDecimals()
        If ucrChkDisplayOptions.Checked Then
            clsDummyFunction.AddParameter("display", "True", iPosition:=0)

            If Not ucrNudDecimalPlaces.IsEmpty Then
                clsFashionFunction.AddParameter("decimals", ucrNudDecimalPlaces.GetText, iPosition:=1)
            Else
                clsFashionFunction.RemoveParameterByName("decimals")
            End If
        Else
            clsDummyFunction.AddParameter("display", "False", iPosition:=0)
            clsFashionFunction.RemoveParameterByName("decimals")
        End If
    End Sub

    Private Sub AddingLeadingZeros()
        If ucrChkDisplayOptions.Checked Then
            If ucrChkLeadingZeros.Checked Then
                clsFashionFunction.AddParameter("leading_zeros", "TRUE", iPosition:=1)
            Else
                clsFashionFunction.RemoveParameterByName("leading_zeros")
            End If
        Else
            clsFashionFunction.RemoveParameterByName("leading_zeros")
        End If
    End Sub

    Private Sub ucrNudDecimalPlaces_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudDecimalPlaces.ControlValueChanged
        AddingDecimals()
    End Sub

    Private Sub ucrChkDisplayOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayOptions.ControlValueChanged, ucrPnlOutput.ControlValueChanged
        AddingDecimals()
        AddingLeadingZeros()
        ChangeBaseFunction()
        ChangeOutputObject()
        HideShowOptions()
        AddPValues()
    End Sub

    Private Sub ucrChkLeadingZeros_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLeadingZeros.ControlValueChanged
        AddingLeadingZeros()
    End Sub

    Private Sub ChangeOutputObject()

        If ucrChkDisplayOptions.Checked Then
            clsDataFrameFunction.RemoveAssignTo()
            If rdoAsText.Checked Then
                clsDummyFunction.AddParameter("output", "as.table", iPosition:=2)
                ucrSaveCorrelation.SetSaveType(strRObjectType:=RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Text)
                ucrSaveCorrelation.SetCheckBoxText("Store Table")
                ucrSaveCorrelation.SetPrefix("summary_table")
                ucrSaveCorrelation.SetAssignToIfUncheckedValue("last_table")

            Else
                clsDummyFunction.AddParameter("output", "as.dataframe", iPosition:=2)
                clsDataFrameFunction.RemoveAssignTo()
                ucrSaveCorrelation.SetSaveTypeAsDataFrame()
                ucrSaveCorrelation.SetCheckBoxText("Store Data Frame")
                ucrSaveCorrelation.SetPrefix("data_frame")
                ucrSaveCorrelation.SetAssignToIfUncheckedValue("last_dataframe")
            End If
        Else

            ucrSaveCorrelation.SetSaveType(strRObjectType:=RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Text)
            ucrSaveCorrelation.SetCheckBoxText("Store Table")
            ucrSaveCorrelation.SetPrefix("summary_table")
            ucrSaveCorrelation.SetAssignToIfUncheckedValue("last_table")

        End If
    End Sub

    Private Sub ChangeBaseFunction()
        If bRcodeSet Then
            If ucrChkDisplayOptions.Checked Then
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetObjectRFunction)
                If rdoAsDataFrame.Checked Then
                    ucrBase.clsRsyntax.iCallType = 0
                    ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetObjectRFunction)
                Else
                    ucrBase.clsRsyntax.AddToAfterCodes(clsGetObjectRFunction, iPosition:=1)
                End If
            Else
                ucrBase.clsRsyntax.AddToAfterCodes(clsGetObjectRFunction, iPosition:=1)
            End If
        End If
    End Sub

    Private Sub HideShowOptions()
        grpDisplayOptions.Visible = ucrChkDisplayOptions.Checked
        ucrNudBootstrapCorrelations.Visible = ucrChkBootstrapCorrelations.Checked
        ucrSaveBootstrapGraph.Visible = ucrChkBootstrapCorrelations.Checked
    End Sub

    Private Sub ucrSaveCorrelation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveCorrelation.ControlValueChanged
        If ucrSaveCorrelation.ucrChkSave.Checked Then
            clsGetObjectRFunction.AddParameter("object_name", Chr(34) & ucrSaveCorrelation.GetText & Chr(34), iPosition:=1)
        Else
            clsGetObjectRFunction.AddParameter("object_name", Chr(34) & "last_table" & Chr(34), iPosition:=1)
        End If
    End Sub

    Private Sub ucrSaveBootstrapGraph_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveBootstrapGraph.ControlValueChanged
        clsAdditionOperator.SetAssignTo(ucrSaveBootstrapGraph.GetText)
        clsGetObjectRFunction2.AddParameter("object_name", Chr(34) & ucrSaveBootstrapGraph.GetText() & Chr(34), iPosition:=1)

    End Sub

    Private Sub ucrSaveCorrelation_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveCorrelation.ControlContentsChanged, ucrReceiverTrait.ControlContentsChanged, ucrReceiverTraitsToCompare.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveCorrelation_TextChanged(sender As Object, e As EventArgs) Handles ucrSaveCorrelation.TextChanged
        ChangeOutputObject()
    End Sub
End Class