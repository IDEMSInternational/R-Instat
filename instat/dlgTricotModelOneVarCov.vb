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
Public Class dlgTricotModelOneVarCov
    Public bFirstLoad As Boolean = True
    Private clsGetVariablesMetadataFunction, clsVarsFunction As New RFunction
    Private clsGetObjectFunction, clsGetRankingItemsFunction, clsGetDataFrameFunction, clsGetColumn, clsLevelsFunction, clsFactorsFunction,
    clsMappingFunction, clsPladmmFunction, clsNamesFunction As New RFunction
    Private clsObjectOperator, clsTildeOperator, clsTilde2Operator, clsBracketOperator, clsNamesOperator As New ROperator


    Private Sub dlgTricotModelOneVarCov_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
    End Sub
    Private Sub InitialiseDialog()
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
    End Sub

    Private Sub setDefaults()

        clsGetVariablesMetadataFunction = New RFunction
        clsGetObjectFunction = New RFunction
        clsObjectOperator = New ROperator
        clsVarsFunction = New RFunction
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

        ucrTricOneVarSave.Reset()

        clsGetVariablesMetadataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVariablesMetadataFunction.SetAssignTo("get_index_names")

        clsGetObjectFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object")
        clsGetObjectFunction.AddParameter("object_name", Chr(34) & "rankings_list" & Chr(34), iPosition:=1)

        clsObjectOperator.SetOperation("$")
        clsObjectOperator.AddParameter("left", clsRFunctionParameter:=clsGetObjectFunction, iPosition:=0)
        clsObjectOperator.AddParameter("right", "object", iPosition:=1)
        clsObjectOperator.SetAssignTo("rankings_object")

        clsVarsFunction.SetRCommand("c")
        clsVarsFunction.SetAssignTo("vars")

        clsGetRankingItemsFunction.SetRCommand("get_ranking_items")
        clsGetRankingItemsFunction.AddParameter("data", clsRFunctionParameter:=clsGetVariablesMetadataFunction, iPosition:=0)
        clsGetRankingItemsFunction.AddParameter("vars_to_get", clsRFunctionParameter:=clsVarsFunction, iPosition:=1)
        clsGetRankingItemsFunction.AddParameter("index ", Chr(34) & "rankings_index" & Chr(34), iPosition:=2)
        clsGetRankingItemsFunction.AddParameter("data_object", clsROperatorParameter:=clsObjectOperator, iPosition:=1, bIncludeArgumentName:=False)
        clsGetRankingItemsFunction.SetAssignTo("rankings_objects ")

        clsGetColumn.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetColumn.AddParameter("col_name", ucrVarietyLevelReceiver.GetVariableNames(), iPosition:=1)
        clsGetColumn.SetAssignTo("column")

        clsLevelsFunction.SetRCommand("levels")
        clsLevelsFunction.AddParameter("x", clsRFunctionParameter:=clsFactorsFunction, iPosition:=0)

        clsFactorsFunction.SetRCommand("factor")

        clsBracketOperator.SetOperation("[")
        clsBracketOperator.AddParameter("left", clsRFunctionParameter:=clsLevelsFunction, iPosition:=0)
        clsBracketOperator.AddParameter("right", "1,]", iPosition:=1)
        clsBracketOperator.SetAssignTo("baseline")

        clsPladmmFunction.SetPackageName("PlackettLuce")
        clsPladmmFunction.SetRCommand("pladmm")
        clsPladmmFunction.AddParameter("x", ".x", iPosition:=0, bIncludeArgumentName:=False)
        clsPladmmFunction.AddParameter("y", clsROperatorParameter:=clsTilde2Operator, iPosition:=1, bIncludeArgumentName:=False)

        clsTildeOperator.SetOperation("~")
        clsTildeOperator.AddParameter("y", clsRFunctionParameter:=clsPladmmFunction, iPosition:=1)

        clsMappingFunction.SetPackageName("purr")
        clsMappingFunction.SetRCommand("map")
        clsMappingFunction.AddParameter(".x", clsRFunctionParameter:=clsGetRankingItemsFunction, iPosition:=0)
        clsMappingFunction.AddParameter(".f", clsROperatorParameter:=clsTildeOperator, iPosition:=1)
        clsMappingFunction.SetAssignTo("mod_list")

        clsTilde2Operator.SetOperation("~")
        clsTilde2Operator.AddParameter("y", ucrVarietyLevelReceiver.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)

        clsNamesFunction.SetRCommand("names")
        clsNamesFunction.AddParameter("x", clsRFunctionParameter:=clsMappingFunction, bIncludeArgumentName:=False)

        clsNamesOperator.SetOperation("<-")
        clsNamesOperator.AddParameter("left", clsRFunctionParameter:=clsNamesFunction, iPosition:=0)
        clsNamesOperator.AddParameter("right", clsRFunctionParameter:=clsVarsFunction, iPosition:=1)

    End Sub
    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrSelectorTraitsRanking.AddAdditionalCodeParameterPair(clsGetVariablesMetadataFunction, ucrSelectorTraitsRanking.GetParameter())
        ucrSelectorVarietyLevel.AddAdditionalCodeParameterPair(clsGetColumn, ucrSelectorVarietyLevel.GetParameter())

        ucrSelectorTraitsRanking.SetRCode(clsGetObjectFunction, bReset)
        ucrSelectorVarietyLevel.SetRCode(clsPladmmFunction, bReset)
        ucrTraitsReceiver.SetRCode(clsVarsFunction, bReset)
        ucrVarietyLevelReceiver.SetRCode(clsFactorsFunction, bReset)

    End Sub

    Private Sub TestOkEnabled()
        If Not ucrTraitsReceiver.IsEmpty AndAlso Not ucrVarietyLevelReceiver.IsEmpty AndAlso ucrTricOneVarSave.IsComplete Then
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
    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrTraitsReceiver.ControlContentsChanged, ucrVarietyLevelReceiver.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class