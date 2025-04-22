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

Public Class dlgPlacketLuceModel
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsNamesFunction, clsGetVarMetadataFunction, clsGetObjectRFunction, clsRankingsItemsFunction, clsVarFunction, clsMapFunction, clsPlacketFunction As RFunction
    Private clsGetRankingOperator, clsModelOperator, clsPlacketOperator, clsNamesOperator As ROperator

    Private Sub dlgPlacketLuceModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRcodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorTraitsPL.SetParameter(New RParameter("data_name", 0))
        ucrSelectorTraitsPL.SetParameterIsString()

        ucrReceiverMultipleTraits.SetParameter(New RParameter("vars_to_get", 1, False))
        ucrReceiverMultipleTraits.SetParameterIsString()
        ucrReceiverMultipleTraits.Selector = ucrSelectorTraitsPL
        ucrReceiverMultipleTraits.strSelectorHeading = "Traits"
        ucrReceiverMultipleTraits.SetMeAsReceiver()
        ucrReceiverMultipleTraits.SetTricotType({"traits"})
        ucrReceiverMultipleTraits.SetLinkedDisplayControl(lblTraits)

        ucrSaveResult.SetPrefix("model")
        ucrSaveResult.SetIsComboBox()
        ucrSaveResult.SetSaveTypeAsModel()
        ucrSaveResult.SetCheckBoxText("Store Model")
        ucrSaveResult.SetAssignToIfUncheckedValue("last_model")
        ucrSaveResult.SetDataFrameSelector(ucrSelectorTraitsPL.ucrAvailableDataFrames)
    End Sub

    Private Sub SetDefaults()
        Dim strVarsAssignedScript As String = "vars"
        Dim strVarMetadataAssignedScript As String = "get_index_names"
        Dim strGetRankingAssignedScript As String = "rankings_object"
        Dim strAssignedScript As String = "rankings_object"
        Dim strMapAssignedScript As String = "mod"

        clsGetVarMetadataFunction = New RFunction
        clsRankingsItemsFunction = New RFunction
        clsGetObjectRFunction = New RFunction
        clsVarFunction = New RFunction
        clsMapFunction = New RFunction
        clsPlacketFunction = New RFunction
        clsNamesFunction = New RFunction

        clsGetRankingOperator = New ROperator
        clsPlacketOperator = New ROperator
        clsNamesOperator = New ROperator
        clsModelOperator = New ROperator

        ucrSelectorTraitsPL.Reset()
        ucrSaveResult.Reset()

        clsVarFunction.SetRCommand("")
        clsVarFunction.SetAssignTo("vars")
        'Dim strVarsAssignedScript As String = ""
        'clsVarFunction.ToScript(strScript:=strVarsAssignedScript)

        clsGetVarMetadataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVarMetadataFunction.SetAssignTo("get_index_names ")
        'Dim strVarMetadataAssignedScript As String = ""
        'clsGetVarMetadataFunction.ToScript(strScript:=strVarMetadataAssignedScript)

        clsGetObjectRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object")
        clsGetObjectRFunction.AddParameter("object_name", Chr(34) & "rankings_list" & Chr(34), iPosition:=1)

        clsGetRankingOperator.SetOperation("$")
        clsGetRankingOperator.AddParameter("left", clsRFunctionParameter:=clsGetObjectRFunction, iPosition:=0)
        clsGetRankingOperator.AddParameter("right", "object")
        clsGetRankingOperator.bSpaceAroundOperation = False
        clsGetRankingOperator.SetAssignTo("rankings_object")
        'Dim strGetRankingAssignedScript As String = ""
        'clsGetRankingOperator.ToScript(strScript:=strGetRankingAssignedScript)

        clsRankingsItemsFunction.SetRCommand("get_ranking_items")
        clsRankingsItemsFunction.AddParameter("data", clsRFunctionParameter:=clsGetVarMetadataFunction, iPosition:=0)
        clsRankingsItemsFunction.AddParameter("vars_to_get", clsRFunctionParameter:=clsVarFunction, iPosition:=1)
        clsRankingsItemsFunction.AddParameter("index", Chr(34) & "rankings_index" & Chr(34), iPosition:=2)
        clsRankingsItemsFunction.AddParameter("rankings_object", clsROperatorParameter:=clsGetRankingOperator, bIncludeArgumentName:=False, iPosition:=3)
        clsRankingsItemsFunction.SetAssignTo("rankings_object")
        'Dim strAssignedScript As String = ""
        'clsRankingsItemsFunction.ToScript(strScript:=strAssignedScript)

        clsMapFunction.SetPackageName("purrr")
        clsMapFunction.SetRCommand("map")
        clsMapFunction.AddParameter(".x", clsRFunctionParameter:=clsRankingsItemsFunction, iPosition:=0)
        clsMapFunction.AddParameter(".f", clsROperatorParameter:=clsPlacketOperator, iPosition:=2)
        clsMapFunction.SetAssignTo("mod")
        'Dim strMapAssignedScript As String = ""
        'clsMapFunction.ToScript(strScript:=strMapAssignedScript)

        clsPlacketOperator.SetOperation("~")
        clsPlacketOperator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)
        clsPlacketOperator.AddParameter("right", clsRFunctionParameter:=clsPlacketFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsPlacketFunction.SetPackageName("PlackettLuce")
        clsPlacketFunction.SetRCommand("PlackettLuce")
        clsPlacketFunction.AddParameter("x", ".x", iPosition:=0, bIncludeArgumentName:=False)

        clsNamesOperator.SetOperation("<-")
        clsNamesOperator.AddParameter("left", clsRFunctionParameter:=clsNamesFunction)
        clsNamesOperator.AddParameter("right", "vars")
        clsNamesOperator.bAllBrackets = False

        clsNamesFunction.SetRCommand("names")
        clsNamesFunction.AddParameter("x", "mod", iPosition:=0, bIncludeArgumentName:=False)

        clsModelOperator.SetOperation("")
        clsModelOperator.AddParameter("left", "mod", iPosition:=0)
        clsModelOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorTraitsPL.strCurrentDataFrame,
                                                  strObjectName:="last_model")

        ucrBase.clsRsyntax.ClearCodes()
        'ucrBase.clsRsyntax.AddToBeforeCodes(clsGetVarMetadataFunction, iPosition:=0)
        'ucrBase.clsRsyntax.AddToBeforeCodes(clsGetObjectRFunction, iPosition:=1)
        'ucrBase.clsRsyntax.AddToBeforeCodes(clsVarFunction, iPosition:=2)
        'ucrBase.clsRsyntax.AddToBeforeCodes(clsRankingsItemsFunction, iPosition:=3)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsMapFunction, iPosition:=4)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsNamesOperator, iPosition:=5)
        ucrBase.clsRsyntax.SetBaseROperator(clsModelOperator)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrSelectorTraitsPL.AddAdditionalCodeParameterPair(clsGetObjectRFunction, New RParameter("data_name", 0), iAdditionalPairNo:=1)
        ucrReceiverMultipleTraits.SetRCode(clsVarFunction, bReset)
        ucrSelectorTraitsPL.SetRCode(clsGetVarMetadataFunction, bReset)
        ucrSaveResult.SetRCode(clsModelOperator, bReset)
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrReceiverMultipleTraits.IsEmpty AndAlso ucrSaveResult.IsComplete)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTraitsPL.ControlContentsChanged, ucrReceiverMultipleTraits.ControlContentsChanged, ucrSaveResult.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class