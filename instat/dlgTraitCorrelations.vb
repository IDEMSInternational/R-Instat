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
    Private clsBaseLineOperator, clsObjectOperator, clsPipeOperator, clsNamesOperator, clsMultivarsOpeator, clsTildeOperator, clsAdditionOperator As New ROperator

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

        ucrReceiverTrait.SetParameter(New RParameter("var", 0, bNewIncludeArgumentName:=False))
        ucrReceiverTrait.SetParameterIsString()
        ucrReceiverTrait.Selector = ucrSelecetorTraits

        ucrReceiverTraitsToCompare.SetParameter(New RParameter("data", 0, bNewIncludeArgumentName:=False))
        ucrReceiverTraitsToCompare.SetParameterIsString()
        ucrReceiverTraitsToCompare.Selector = ucrSelecetorTraits
        ucrReceiverTraitsToCompare.strSelectorHeading = "Traits"
        ucrReceiverTraitsToCompare.SetTricotType("traits")
        ucrReceiverTraitsToCompare.bAutoFill = True

        ucrSelecetorTraits.SetParameter(New RParameter("data_name", 1))
        ucrSelecetorTraits.SetParameterIsString()

        ucrNudDecimalPlaces.SetParameter(New RParameter("decimals", 1))
        ucrNudDecimalPlaces.SetMinMax(0, 5)
        ucrNudDecimalPlaces.Increment = 1
        ucrNudDecimalPlaces.SetRDefault(2)
        ucrNudDecimalPlaces.SetLinkedDisplayControl(lblDecimalPlaces)

        ucrChkLeadingZeros.SetParameter(New RParameter("leading_zeros", 2))
        ucrChkLeadingZeros.SetText("Leading Zeros")
        ucrChkLeadingZeros.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkLeadingZeros.SetRDefault("FALSE")

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

        ucrNudBootstrapCorrelations.SetParameter(New RParameter("nboot", 1))
        ucrNudBootstrapCorrelations.Increment = 1
        ucrNudBootstrapCorrelations.SetLinkedDisplayControl(lblBootstrapCorrelations)
        ucrNudBootstrapCorrelations.SetRDefault(100)

        ucrChkBootstrapCorrelations.SetText("Bootstrap correlations")
        ucrChkBootstrapCorrelations.AddToLinkedControls({ucrNudBootstrapCorrelations, ucrSaveBootstrapGraph}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBootstrapCorrelations.AddParameterValuesCondition(True, "correlations", "True")
        ucrChkBootstrapCorrelations.AddParameterValuesCondition(False, "correlations", "False")

        ucrSaveBootstrapGraph.SetIsComboBox()
        ucrSaveBootstrapGraph.SetCheckBoxText("Store Graph")
        ucrSaveBootstrapGraph.SetDataFrameSelector(ucrSelecetorTraits.ucrAvailableDataFrames)
        ucrSaveBootstrapGraph.SetSaveTypeAsGraph()
        ucrSaveBootstrapGraph.SetPrefix("bootstrap")
        ucrSaveBootstrapGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrSaveCorrelation.SetDataFrameSelector(ucrSelecetorTraits.ucrAvailableDataFrames)
        ucrSaveCorrelation.SetIsComboBox()

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

        ucrReceiverTrait.SetMeAsReceiver()
        ucrSelecetorTraits.Reset()
        ucrSaveCorrelation.Reset()
        ucrSaveBootstrapGraph.Reset()
        ucrChkBootstrapCorrelations.Checked = False

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

        clsAesFunction.SetPackageName("ggplot2")
        clsAesFunction.SetRCommand("aes")
        clsAesFunction.AddParameter("y", "trait", iPosition:=0)
        clsAesFunction.AddParameter("x", "kendallTau", iPosition:=1)

        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")
        clsGgplotFunction.AddParameter("data", clsRFunctionParameter:=clsMapDfr2Function, iPosition:=0)
        clsGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesFunction, iPosition:=1)

        clsGeomBoxplotFunction.SetPackageName("ggplot2")
        clsGeomBoxplotFunction.SetRCommand("geom_boxplot")

        clsLabsFunction.SetPackageName("ggplot2")
        clsLabsFunction.SetRCommand("labs")
        clsLabsFunction.AddParameter("x", Chr(34) & "Correlation with the 'Overall'" & Chr(34))

        clsAdditionOperator.iCallType = 3
        clsAdditionOperator.SetOperation("+")
        clsAdditionOperator.AddParameter("x", clsRFunctionParameter:=clsGgplotFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsAdditionOperator.AddParameter("y", clsRFunctionParameter:=clsGeomBoxplotFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsAdditionOperator.AddParameter("z", clsRFunctionParameter:=clsLabsFunction, iPosition:=2, bIncludeArgumentName:=False)
        clsAdditionOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelecetorTraits.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        clsKendallTauFunction.SetPackageName("~ gosset")
        clsKendallTauFunction.SetRCommand("kendallTau")
        clsKendallTauFunction.AddParameter("x", "compare_variables[[.x]]", iPosition:=0)
        clsKendallTauFunction.AddParameter("y", "compare_variables[[baseline]]", iPosition:=1)
        clsKendallTauFunction.SetAssignTo("kendall_rankings")

        clsMapDfrFunction.SetPackageName("purrr")
        clsMapDfrFunction.SetRCommand("map_dfr")
        clsMapDfrFunction.AddParameter(".x", "multiple_vars", iPosition:=0)
        clsMapDfrFunction.AddParameter(".f", clsRFunctionParameter:=clsKendallTauFunction, iPosition:=1)

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")
        clsMutateFunction.AddParameter("trait", "multiple_vars", iPosition:=0)
        clsMutateFunction.AddParameter(".before", "everything()", iPosition:=0)

        clsSelectFunction.SetPackageName("dplyr")
        clsSelectFunction.SetRCommand("select")

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("first", clsRFunctionParameter:=clsMapDfrFunction, iPosition:=0)
        clsPipeOperator.AddParameter("second", clsRFunctionParameter:=clsMutateFunction, iPosition:=1)
        clsPipeOperator.AddParameter("third", clsRFunctionParameter:=clsSelectFunction, iPosition:=2)
        clsPipeOperator.SetAssignTo("kendall_rankings")

        clsFashionFunction.SetPackageName("corrr")
        clsFashionFunction.SetRCommand("fashion")
        clsFashionFunction.AddParameter("var", clsROperatorParameter:=clsPipeOperator, iPosition:=0, bIncludeArgumentName:=False)

        clsDataFrameFunction.SetRCommand("data.frame")
        clsDataFrameFunction.AddParameter("x", clsRFunctionParameter:=clsFashionFunction, iPosition:=0, bIncludeArgumentName:=False)

        '        clsGetObjectRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        '        clsGetObjectRFunction.AddParameter("as_file", "TRUE", iPosition:=3)

        '        clsGetObjectRFunction2.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        '        clsGetObjectRFunction2.AddParameter("data_name", Chr(34) & ucrSelecetorTraits.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        '        clsGetObjectRFunction2.AddParameter("object_name", Chr(34) & ucrSaveBootstrapGraph.GetText() & Chr(34), iPosition:=1)
        '        clsGetObjectRFunction2.AddParameter("as_file", "TRUE", iPosition:=2)

        ucrBase.clsRsyntax.AddToBeforeCodes(clsNamesOperator, 1)
        ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
        ChangeOutputObject()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRcodeSet = False

        ucrChkDisplayOptions.AddAdditionalCodeParameterPair(clsDummyFunction, New RParameter("display", 0), iAdditionalPairNo:=1)
        ucrChkIncludePValues.AddAdditionalCodeParameterPair(clsDummyFunction, New RParameter("value", 1), iAdditionalPairNo:=1)
        ucrPnlOutput.AddAdditionalCodeParameterPair(clsDummyFunction, New RParameter("output", 2), iAdditionalPairNo:=1)

        ucrSelecetorTraits.AddAdditionalCodeParameterPair(clsGetVariablesMetadataFunction, New RParameter("data", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrSaveCorrelation.AddAdditionalRCode(clsDataFrameFunction, iAdditionalPairNo:=1)

        ucrNudDecimalPlaces.SetRCode(clsFashionFunction, bReset)
        ucrChkLeadingZeros.SetRCode(clsFashionFunction, bReset)
        ucrChkDisplayOptions.SetRCode(clsDummyFunction, bReset)

        ucrReceiverTrait.SetRCode(clsBaseLineOperator, bReset)
        ucrReceiverTraitsToCompare.SetRCode(clsMultivarsOpeator, bReset)
        ucrSelecetorTraits.SetRCode(clsGetObjectFunction, bReset)   'clsDataFrameFunction
        ucrPnlOutput.SetRCode(clsDummyFunction, bReset)
        ucrChkIncludePValues.SetRCode(clsDummyFunction, bReset)
        ucrSaveCorrelation.SetRCode(clsPipeOperator, bReset)
        ucrSaveBootstrapGraph.SetRCode(clsAdditionOperator, bReset)

        bRcodeSet = True
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
            '    ucrBase.clsRsyntax.AddToBeforeCodes(clsGetObjectRFunction2, 4)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsAdditionOperator)
            '    ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetObjectRFunction2)
        End If
    End Sub

    Private Sub ucrNudBootstrapCorrelations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudBootstrapCorrelations.ControlValueChanged
        clsTildeOperator.AddParameter("right", "~ {k <- gosset::kendallTau_bootstrap(x = compare_variables[[.x]], y = compare_variables[[baseline]], nboot = " & ucrNudBootstrapCorrelations.GetText() & "); tibble(trait = .x, kendallTau = k)}", iPosition:=1, bIncludeArgumentName:=False)
    End Sub

    Private Sub ucrSelecetorTraits_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelecetorTraits.ControlValueChanged
        Dim DataFrame As String = ucrSelecetorTraits.strCurrentDataFrame

        clsGetVariablesMetadataFunction.AddParameter("data", Chr(34) & DataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        '     clsGetObjectFunction.AddParameter("data_name", Chr(34) & DataFrame & Chr(34), iPosition:=0)
        '     clsGetObjectRFunction.AddParameter("data_name", Chr(34) & ucrSelecetorTraits.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        '     clsGetObjectRFunction2.AddParameter("data_name", Chr(34) & ucrSelecetorTraits.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
    End Sub

    Private Sub ucrChkIncludePValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludePValues.ControlValueChanged
        AddPValues()
    End Sub

    Private Sub AddPValues()
        If ucrChkDisplayOptions.Checked Then
            If ucrChkIncludePValues.Checked Then
                clsPipeOperator.RemoveParameterByName("third")
                clsSelectFunction.RemoveParameterByName("select")
                clsSelectFunction.RemoveParameterByName("z")
            Else
                clsSelectFunction.AddParameter("select", "-c(`Pr(>|z|)`", iPosition:=0, bIncludeArgumentName:=False)
                clsSelectFunction.AddParameter("z", "`Zvalue`)", iPosition:=1, bIncludeArgumentName:=False)
                clsPipeOperator.AddParameter("third", clsRFunctionParameter:=clsSelectFunction, iPosition:=1)
            End If
        Else
            clsSelectFunction.AddParameter("select", "-c(`Pr(>|z|)`", iPosition:=0, bIncludeArgumentName:=False)
            clsSelectFunction.AddParameter("z", "`Zvalue`)", iPosition:=1, bIncludeArgumentName:=False)
            clsPipeOperator.AddParameter("third", clsRFunctionParameter:=clsSelectFunction, iPosition:=1)
        End If
    End Sub

    Private Sub ucrChkDisplayOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayOptions.ControlValueChanged, ucrPnlOutput.ControlValueChanged
        ChangeOutputObject()
        ChangeBaseFunction()
        HideShowOptions()
        AddPValues()
    End Sub

    Private Sub ChangeOutputObject()
        clsDataFrameFunction.RemoveAssignTo()
        clsPipeOperator.RemoveAssignTo()

        If ucrChkDisplayOptions.Checked Then
            If rdoAsText.Checked Then
                clsDummyFunction.AddParameter("output", "as.table", iPosition:=2)
                ucrSaveCorrelation.SetSaveType(strRObjectType:=RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Text)
                ucrSaveCorrelation.SetCheckBoxText("Store Table")
                ucrSaveCorrelation.SetPrefix("summary_table")
                ucrSaveCorrelation.SetAssignToIfUncheckedValue("last_table")
                clsDataFrameFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                        strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                        strRObjectFormatToAssignTo:=RObjectFormat.Text,
                        strRDataFrameNameToAddObjectTo:=ucrSelecetorTraits.strCurrentDataFrame,
                        strObjectName:="last_table")
            Else
                clsDummyFunction.AddParameter("output", "as.dataframe", iPosition:=2)
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
            clsPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                                         strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                                         strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                         strRDataFrameNameToAddObjectTo:=ucrSelecetorTraits.strCurrentDataFrame,
                                                         strObjectName:="last_table")
        End If
    End Sub

    Private Sub ChangeBaseFunction()
        'If bRcodeSet Then
        If ucrChkDisplayOptions.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDataFrameFunction)

            '    ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
            '    ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetObjectRFunction)
            If rdoAsDataFrame.Checked Then
                ucrBase.clsRsyntax.iCallType = 0
                '        ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetObjectRFunction)
            Else
                ucrBase.clsRsyntax.iCallType = 2
                '        ucrBase.clsRsyntax.SetBaseRFunction(clsDataFrameFunction)
                '        ucrBase.clsRsyntax.AddToAfterCodes(clsGetObjectRFunction, iPosition:=1)
            End If
        Else
            ucrBase.clsRsyntax.iCallType = 2
            ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
            '    ucrBase.clsRsyntax.AddToAfterCodes(clsGetObjectRFunction, iPosition:=1)
        End If
        'End If
    End Sub

    Private Sub HideShowOptions()
        grpDisplayOptions.Visible = ucrChkDisplayOptions.Checked
    End Sub

    'Private Sub ucrSaveBootstrapGraph_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveBootstrapGraph.ControlValueChanged
    '    clsGetObjectRFunction2.AddParameter("object_name", Chr(34) & ucrSaveBootstrapGraph.GetText() & Chr(34), iPosition:=1)
    'End Sub

    Private Sub ucrSaveCorrelation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveCorrelation.ControlValueChanged
        '    If ucrSaveCorrelation.ucrChkSave.Checked Then
        '    clsGetObjectRFunction.AddParameter("object_name", Chr(34) & ucrSaveCorrelation.GetText & Chr(34), iPosition:=1)
        '    Else
        '    clsGetObjectRFunction.AddParameter("object_name", Chr(34) & "last_table" & Chr(34), iPosition:=1)
        '    End If
    End Sub

    Private Sub ucrSaveCorrelation_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveCorrelation.ControlContentsChanged, ucrReceiverTrait.ControlContentsChanged, ucrReceiverTraitsToCompare.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveCorrelation_TextChanged(sender As Object, e As EventArgs) Handles ucrSaveCorrelation.TextChanged
        ChangeOutputObject()
    End Sub
End Class