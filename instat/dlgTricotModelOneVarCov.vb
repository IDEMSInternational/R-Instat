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
Imports RDotNet
Public Class dlgTricotModelOneVarCov
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bIsUnique As Boolean = True
    Private clsGetVariablesMetadataFunction As New RFunction
    Private clsGetObjectFunction, clsGetRankingItemsFunction, clsGetDataFrameFunction, clsGetColumn,
        clsLevelsFunction, clsFactorsFunction, clsMappingFunction, clsPladmmFunction, clsNamesFunction,
    clsCheckUniqueFunction As New RFunction
    Private clsObjectOperator, clsTildeOperator, clsTilde2Operator, clsBracketOperator,
        clsNamesOperator, clsModelOperator, clsSpaceOperator, clsTilde3Operator As New ROperator



    Private Sub dlgTricotModelOneVarCov_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            setDefaults()
        End If

        SetRcodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 706

        ucrSelectorTraitsRanking.SetParameter(New RParameter("data_name", 0))
        ucrSelectorTraitsRanking.SetParameterIsString()

        ucrTraitsReceiver.SetParameter(New RParameter("x", 0))
        ucrTraitsReceiver.Selector = ucrSelectorTraitsRanking
        ucrTraitsReceiver.SetParameterIsString()
        ucrTraitsReceiver.SetMeAsReceiver()
        ucrTraitsReceiver.strSelectorHeading = "Traits"
        ucrTraitsReceiver.SetTricotType({"traits"})

        ucrSelectorVarietyLevel.SetParameter(New RParameter("data", 3))
        ucrSelectorVarietyLevel.SetParameterIsrfunction()

        ucrVarietyLevelReceiver.SetParameter(New RParameter("c", 0))
        ucrVarietyLevelReceiver.Selector = ucrSelectorVarietyLevel
        ucrVarietyLevelReceiver.SetParameterIsRFunction()
        ucrVarietyLevelReceiver.SetMeAsReceiver()

        ucrTricOneVarSave.SetDataFrameSelector(ucrSelectorVarietyLevel.ucrAvailableDataFrames)
        ucrTricOneVarSave.SetSaveTypeAsModel()
        ucrTricOneVarSave.SetCheckBoxText("Store Model")
        ucrTricOneVarSave.SetIsComboBox()
        ucrTricOneVarSave.SetAssignToIfUncheckedValue("last_model")

        btnModelOptions.Enabled = False
        btnDisplayOptions.Enabled = False
    End Sub

    Private Sub setDefaults()

        clsGetVariablesMetadataFunction = New RFunction
        clsGetObjectFunction = New RFunction
        clsObjectOperator = New ROperator
        clsSpaceOperator = New ROperator
        clsGetRankingItemsFunction = New RFunction
        clsGetColumn = New RFunction
        clsLevelsFunction = New RFunction
        clsMappingFunction = New RFunction
        clsPladmmFunction = New RFunction
        clsTildeOperator = New ROperator
        clsTilde2Operator = New ROperator
        clsFactorsFunction = New RFunction
        clsBracketOperator = New ROperator
        clsNamesFunction = New RFunction
        clsNamesOperator = New ROperator
        clsModelOperator = New ROperator
        clsCheckUniqueFunction = New RFunction
        clsTilde3Operator = New ROperator

        ucrTricOneVarSave.Reset()
        ucrSelectorTraitsRanking.Reset()
        ucrSelectorVarietyLevel.Reset()

        clsCheckUniqueFunction.SetRCommand("check_variety_data_level")

        clsGetVariablesMetadataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVariablesMetadataFunction.SetAssignTo("get_index_names")

        clsGetObjectFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object")
        clsGetObjectFunction.AddParameter("object_name", Chr(34) & "rankings_list" & Chr(34), iPosition:=1)

        clsObjectOperator.SetOperation("$")
        clsObjectOperator.AddParameter("left", clsRFunctionParameter:=clsGetObjectFunction, iPosition:=0)
        clsObjectOperator.AddParameter("right", "object", iPosition:=1)
        clsObjectOperator.SetAssignTo("rankings_object")

        clsSpaceOperator.SetOperation(" ")
        clsSpaceOperator.AddParameter("x", ucrTraitsReceiver.GetVariableNames(), iPosition:=0, bIncludeArgumentName:=False)
        clsSpaceOperator.SetAssignTo("vars")

        clsGetRankingItemsFunction.SetRCommand("get_ranking_items")
        clsGetRankingItemsFunction.AddParameter("data", clsRFunctionParameter:=clsGetVariablesMetadataFunction, iPosition:=0)
        clsGetRankingItemsFunction.AddParameter("vars_to_get", clsROperatorParameter:=clsSpaceOperator, iPosition:=1)
        clsGetRankingItemsFunction.AddParameter("index ", Chr(34) & "rankings_index" & Chr(34), iPosition:=2)
        clsGetRankingItemsFunction.AddParameter("data_object", clsROperatorParameter:=clsObjectOperator, iPosition:=1, bIncludeArgumentName:=False)
        clsGetRankingItemsFunction.SetAssignTo("rankings_object")

        clsGetColumn.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetColumn.SetAssignTo("column")

        clsLevelsFunction.SetRCommand("levels")
        clsLevelsFunction.AddParameter("x", clsRFunctionParameter:=clsFactorsFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsFactorsFunction.SetRCommand("factor")
        clsFactorsFunction.AddParameter("x", clsRFunctionParameter:=clsGetColumn, iPosition:=0, bIncludeArgumentName:=False)

        clsBracketOperator.SetOperation("[")
        clsBracketOperator.AddParameter("left", clsRFunctionParameter:=clsLevelsFunction, iPosition:=0)
        clsBracketOperator.AddParameter("right", "1]", iPosition:=1)
        clsBracketOperator.SetAssignTo("baseline")

        clsTildeOperator.SetOperation("~")
        clsTildeOperator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)
        clsTildeOperator.AddParameter("right", clsRFunctionParameter:=clsPladmmFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsMappingFunction.SetPackageName("purrr")
        clsMappingFunction.SetRCommand("map")
        clsMappingFunction.AddParameter(".x", "rankings_object", iPosition:=0)
        clsMappingFunction.AddParameter(".f", clsROperatorParameter:=clsTildeOperator, iPosition:=1)
        clsMappingFunction.SetAssignTo("mod_list")

        clsPladmmFunction.SetPackageName("PlackettLuce")
        clsPladmmFunction.SetRCommand("pladmm")
        clsPladmmFunction.AddParameter("x", ".x", iPosition:=0, bIncludeArgumentName:=False)
        clsPladmmFunction.AddParameter("y", clsROperatorParameter:=clsTilde2Operator, iPosition:=1, bIncludeArgumentName:=False)


        clsTilde2Operator.SetOperation("~")
        clsTilde2Operator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)

        clsNamesFunction.SetRCommand("names")
        clsNamesFunction.AddParameter("x", clsRFunctionParameter:=clsMappingFunction, bIncludeArgumentName:=False)

        clsNamesOperator.SetOperation("<-")
        clsNamesOperator.AddParameter("left", clsRFunctionParameter:=clsNamesFunction, iPosition:=0)
        clsNamesOperator.AddParameter("right", clsROperatorParameter:=clsSpaceOperator, iPosition:=1)

        clsModelOperator.SetOperation("")
        clsModelOperator.AddParameter("left", "mod_list", iPosition:=0)
        clsModelOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorVarietyLevel.strCurrentDataFrame,
                                                  strObjectName:="last_model")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetRankingItemsFunction, iPosition:=3)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsBracketOperator, iPosition:=4)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsNamesOperator, iPosition:=5)
        ucrBase.clsRsyntax.SetBaseROperator(clsModelOperator)

    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrSelectorTraitsRanking.AddAdditionalCodeParameterPair(clsGetVariablesMetadataFunction, ucrSelectorTraitsRanking.GetParameter())

        ucrSelectorTraitsRanking.SetRCode(clsGetObjectFunction, bReset)
        ucrSelectorVarietyLevel.SetRCode(clsPladmmFunction, bReset)
        ucrTraitsReceiver.SetRCode(clsSpaceOperator, bReset)
        ucrTricOneVarSave.SetRCode(clsModelOperator, bReset)

    End Sub

    Private Sub TestOkEnabled()
        If Not ucrTraitsReceiver.IsEmpty AndAlso Not ucrVarietyLevelReceiver.IsEmpty AndAlso
            ucrTricOneVarSave.IsComplete AndAlso Not ucrInputCheckVariety.IsEmpty AndAlso bIsUnique = True Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)

        End If
    End Sub


    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub
    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrTraitsReceiver.ControlContentsChanged, ucrVarietyLevelReceiver.ControlContentsChanged,
        ucrTricOneVarSave.ControlContentsChanged, ucrSelectorVarietyLevel.ControlContentsChanged
        TestOkEnabled()
    End Sub
    Private Sub ucrVarietyLevelReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrVarietyLevelReceiver.ControlValueChanged
        clsTilde2Operator.AddParameter("right", ucrVarietyLevelReceiver.GetVariableNames(bWithQuotes:=False), iPosition:=1, bIncludeArgumentName:=False)
        clsGetColumn.AddParameter("col_name", ucrVarietyLevelReceiver.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)

    End Sub
    Private Sub cmdCheckVariety_Click(sender As Object, e As EventArgs) Handles cmdCheckVariety.Click
        Dim iAnyDuplicated As Integer

        Try
            iAnyDuplicated = frmMain.clsRLink.RunInternalScriptGetValue(clsCheckUniqueFunction.ToScript()).AsInteger(0)
        Catch ex As Exception
            iAnyDuplicated = 0
        End Try

        If iAnyDuplicated = 0 Then
            ucrInputCheckVariety.SetName("Model fails. There is no variety variable that is Tricot-Defined in this data.")
            ucrInputCheckVariety.txtInput.BackColor = Color.Coral
            bIsUnique = False
        ElseIf iAnyDuplicated = 1 Then
            ucrInputCheckVariety.SetName("Model fails. No key columns are defined in the dataset.")
            ucrInputCheckVariety.txtInput.BackColor = Color.Coral
            bIsUnique = False

        ElseIf iAnyDuplicated = 2 Then
            ucrInputCheckVariety.SetName("Model fails. Only variety level data can be used for this data. This is data where there is a unique row for each variety given.")
            ucrInputCheckVariety.txtInput.BackColor = Color.Coral
            bIsUnique = False
        Else
            ucrInputCheckVariety.SetName("Model runs OK.")
            ucrInputCheckVariety.txtInput.BackColor = Color.LightGreen
            bIsUnique = True
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorVarietyLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorVarietyLevel.ControlValueChanged
        clsGetColumn.AddParameter("x", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsCheckUniqueFunction.AddParameter("x", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)

    End Sub
End Class