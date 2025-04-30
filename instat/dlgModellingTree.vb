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

Public Class dlgModellingTree

    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public bRCodeSet As Boolean = False
    Public clsFormulaOperator As New ROperator

    Public clsRConvert As New RFunction
    Public bResetModelOptions As Boolean = False

    Private clsFactorFunction, clsLevelsFunction, clsMappingFunction, clsPlackettLuceFunction As New RFunction
    Private clsGetVariablesMetaDataFunction, clsRGetObjectFunction, clsGetRankingItemsFunction, clsNamesFunction As New RFunction
    Private clsGetDataFrameFunction, clsGetVariablesFromMetaDataFunction, clsGetSecondDataFrameFunction, clsLibraryFunction As New RFunction
    Private clsTildaOperator, clsRankingsOperator, clsEmptySpaceOperator, clsFormularTildaOperator, clsVarOperator, clsAssignOperator, clsSaveOperator As New ROperator

    Public bResetSubDialog As Boolean = False
    Public bResetOptionsSubDialog As Boolean = False

    Private dctPlotFunctions As New Dictionary(Of String, RFunction)

    Private Sub dlgFitModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorByDataFrameAddRemoveForModellingTree.SetParameter(New RParameter("data", 0))
        ucrSelectorByDataFrameAddRemoveForModellingTree.SetParameterIsrfunction()

        UcrSelectorByDataFrameForModellingTreeSecond.SetParameter(New RParameter("data", 0))
        UcrSelectorByDataFrameForModellingTreeSecond.SetParameterIsString()

        ucrReceiverModellingTree.SetParameter(New RParameter("vars_to_get", 1))
        ucrReceiverModellingTree.SetParameterIsRFunction()
        ucrReceiverModellingTree.Selector = ucrSelectorByDataFrameAddRemoveForModellingTree

        ucrReceiverExpressionModellingTree.SetParameter(New RParameter("y", 2))
        ucrReceiverExpressionModellingTree.SetParameterIsString()
        ucrReceiverExpressionModellingTree.bWithQuotes = False
        ucrReceiverExpressionModellingTree.AddtoCombobox("1")
        'ucrTryModelling.SetReceiver(ucrReceiverExpressionModellingTree)
        'ucrTryModelling.SetIsModel()


        ucrModelName.SetDataFrameSelector(ucrSelectorByDataFrameAddRemoveForModellingTree.ucrAvailableDataFrames)
        ucrModelName.SetPrefix("gen_model")
        ucrModelName.SetSaveTypeAsModel()
        ucrModelName.SetCheckBoxText("Store Model")
        ucrModelName.SetIsComboBox()
        ucrModelName.SetAssignToIfUncheckedValue("last_model")
    End Sub

    Private Sub SetDefaults()
        clsFormulaOperator = New ROperator

        clsRConvert = New RFunction

        clsGetVariablesMetaDataFunction = New RFunction
        clsRGetObjectFunction = New RFunction
        clsGetRankingItemsFunction = New RFunction
        clsRankingsOperator = New ROperator
        clsFactorFunction = New RFunction
        clsLevelsFunction = New RFunction
        clsMappingFunction = New RFunction
        clsNamesFunction = New RFunction
        clsEmptySpaceOperator = New ROperator
        clsTildaOperator = New ROperator
        clsFormularTildaOperator = New ROperator
        clsVarOperator = New ROperator
        clsAssignOperator = New ROperator
        clsSaveOperator = New ROperator


        ucrSelectorByDataFrameAddRemoveForModellingTree.Reset()
        ucrReceiverExpressionModellingTree.Clear()
        ucrModelName.Reset()
        ucrReceiverModellingTree.SetMeAsReceiver()
        ucrSelectorByDataFrameAddRemoveForModellingTree.Focus()

        clsRConvert.SetRCommand("as.numeric")

        clsFormulaOperator = clsRegressionDefaults.clsDefaultFormulaOperator.Clone

        ucrReceiverModellingTree.SetMeAsReceiver()
        ucrReceiverExpressionModellingTree.Selector = UcrSelectorByDataFrameForModellingTreeSecond
        ucrReceiverModellingTree.Selector = ucrSelectorByDataFrameAddRemoveForModellingTree


        ucrInputModelPreview.SetName("")
        ucrInputModelPreview.IsReadOnly = True

        clsGetVariablesMetaDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVariablesMetaDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34), bIncludeArgumentName:=False)
        clsGetVariablesMetaDataFunction.SetAssignTo("get_index_names")


        clsRGetObjectFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object")
        clsRGetObjectFunction.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34), iPosition:=0)
        clsRGetObjectFunction.AddParameter("object_name", Chr(34) & "grouped_rankings_list" & Chr(34))

        clsRankingsOperator.SetOperation("$")
        clsRankingsOperator.AddParameter("left", clsRFunctionParameter:=clsRGetObjectFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsRankingsOperator.AddParameter("right", "object", bIncludeArgumentName:=False, iPosition:=1)
        clsRankingsOperator.SetAssignTo("rankings_object")
        clsRankingsOperator.bSpaceAroundOperation = False

        clsVarOperator.SetOperation("")
        clsVarOperator.AddParameter("combine", strParameterValue:=ucrReceiverModellingTree.GetVariableNames(), bIncludeArgumentName:=False)
        clsVarOperator.SetAssignTo("vars")


        clsGetRankingItemsFunction.SetRCommand("get_ranking_items")
        clsGetRankingItemsFunction.AddParameter("data", clsRFunctionParameter:=clsGetVariablesMetaDataFunction, iPosition:=0)
        clsGetRankingItemsFunction.AddParameter("vars_to_get", clsROperatorParameter:=clsVarOperator, iPosition:=1)
        clsGetRankingItemsFunction.AddParameter("index", Chr(34) & "rankings_index" & Chr(34), iPosition:=2)
        clsGetRankingItemsFunction.AddParameter("ranking_objects", clsROperatorParameter:=clsRankingsOperator, bIncludeArgumentName:=False, iPosition:=3)
        clsGetRankingItemsFunction.SetAssignTo("ranking_objects")

        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFrameFunction.AddParameter("data", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34), bIncludeArgumentName:=False)
        clsGetDataFrameFunction.SetAssignTo(ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame)

        clsGetSecondDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetSecondDataFrameFunction.AddParameter("data", Chr(34) & UcrSelectorByDataFrameForModellingTreeSecond.strCurrentDataFrame & Chr(34), bIncludeArgumentName:=False)
        clsGetSecondDataFrameFunction.SetAssignTo(UcrSelectorByDataFrameForModellingTreeSecond.strCurrentDataFrame)


        clsGetVariablesFromMetaDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_from_metadata")
        clsGetVariablesFromMetaDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34))
        clsGetVariablesFromMetaDataFunction.AddParameter("property", Chr(34) & "Tricot_Type" & Chr(34))
        clsGetVariablesFromMetaDataFunction.AddParameter("property_value", Chr(34) & "variety" & Chr(34))
        clsGetVariablesFromMetaDataFunction.SetAssignTo("var_name")

        clsLevelsFunction.SetRCommand("levels")
        clsLevelsFunction.AddParameter("x", clsRFunctionParameter:=clsFactorFunction, bIncludeArgumentName:=False)

        clsFactorFunction.SetRCommand("factor")
        clsFactorFunction.AddParameter("x", ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & "[[var_name]]", bIncludeArgumentName:=False)

        clsEmptySpaceOperator.SetOperation("")
        clsEmptySpaceOperator.AddParameter("left", clsRFunctionParameter:=clsLevelsFunction, bIncludeArgumentName:=False)
        clsEmptySpaceOperator.AddParameter("right", "[1]", bIncludeArgumentName:=False)
        clsEmptySpaceOperator.SetAssignTo("variety_baseline")
        clsEmptySpaceOperator.bSpaceAroundOperation = False

        clsMappingFunction.SetPackageName("purrr")
        clsMappingFunction.SetRCommand("map")
        clsMappingFunction.AddParameter(".x", clsRFunctionParameter:=clsGetRankingItemsFunction)
        clsMappingFunction.AddParameter(".f", clsROperatorParameter:=clsTildaOperator)
        clsMappingFunction.SetAssignTo("mod_list")

        clsPlackettLuceFunction.SetPackageName("PlackettLuce")
        clsPlackettLuceFunction.SetRCommand("pltree")
        clsPlackettLuceFunction.AddParameter(".x", clsROperatorParameter:=clsFormularTildaOperator, bIncludeArgumentName:=False)
        clsPlackettLuceFunction.AddParameter("data", UcrSelectorByDataFrameForModellingTreeSecond.strCurrentDataFrame)
        clsPlackettLuceFunction.AddParameter("ref", clsROperatorParameter:=clsEmptySpaceOperator, iPosition:=2)

        clsTildaOperator.SetOperation("~")
        clsTildaOperator.AddParameter("left", "", bIncludeArgumentName:=False, iPosition:=0)
        clsTildaOperator.AddParameter("right", clsRFunctionParameter:=clsPlackettLuceFunction, bIncludeArgumentName:=False, iPosition:=2)
        clsTildaOperator.bSpaceAroundOperation = False

        clsFormularTildaOperator.SetOperation("~")
        clsFormularTildaOperator.AddParameter("left", ".x", bIncludeArgumentName:=False, iPosition:=0)
        clsFormularTildaOperator.AddParameter("right", ucrReceiverExpressionModellingTree.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=2)


        clsLibraryFunction.SetRCommand("library")
        clsLibraryFunction.AddParameter("package_name", "PlackettLuce", bIncludeArgumentName:=False)

        clsNamesFunction.SetRCommand("names")
        clsNamesFunction.AddParameter("x", "mod_list", bIncludeArgumentName:=False)

        clsAssignOperator.SetOperation("<-")
        clsAssignOperator.AddParameter("left", clsRFunctionParameter:=clsNamesFunction, bIncludeArgumentName:=False)
        clsAssignOperator.AddParameter("right", "vars", bIncludeArgumentName:=False)
        clsAssignOperator.bAllBrackets = False

        clsSaveOperator.SetOperation("")
        clsSaveOperator.AddParameter("right", clsRFunctionParameter:=clsMappingFunction, bIncludeArgumentName:=False)
        clsSaveOperator.bAllBrackets = False

        ucrBase.clsRsyntax.ClearCodes()

        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataFrameFunction)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetSecondDataFrameFunction)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetVariablesFromMetaDataFunction)

        ucrBase.clsRsyntax.AddToBeforeCodes(clsLibraryFunction)
        ucrBase.clsRsyntax.SetBaseROperator(clsSaveOperator)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAssignOperator)

        bResetModelOptions = True
        'ucrTryModelling.SetRSyntax(ucrBase.clsRsyntax)
    End Sub

    Private Sub assignToControlsChanged(ucrChangedControl As ucrCore) Handles ucrModelName.ControlValueChanged

    End Sub


    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False
        ucrModelName.AddAdditionalRCode(clsSaveOperator, bReset)
        ucrModelName.SetRCode(clsSaveOperator)

        bRCodeSet = True
        ResponseConvert()
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverModellingTree.IsEmpty()) AndAlso (Not ucrReceiverExpressionModellingTree.IsEmpty()) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdColon_Click(sender As Object, e As EventArgs) Handles cmdColon.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition(":")
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("*")
    End Sub

    Private Sub cmdDiv_Click(sender As Object, e As EventArgs) Handles cmdDiv.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("/")
    End Sub

    Private Sub cmdDoubleBracket_Click(sender As Object, e As EventArgs) Handles cmdDoubleBracket.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("( )", 2)
    End Sub

    Private Sub cmdOpeningBracket_Click(sender As Object, e As EventArgs) Handles cmdOpeningBracket.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("(")
    End Sub

    Private Sub cmdClosingBracket_Click(sender As Object, e As EventArgs) Handles cmdClosingBracket.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition(")")
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("^")
    End Sub

    Private Sub ucrSelectorByDataFrameAddRemoveForModellingTree_Load(sender As Object, e As EventArgs) Handles ucrSelectorByDataFrameAddRemoveForModellingTree.Load

    End Sub

    Private Sub cmdMinus_Click(sender As Object, e As EventArgs) Handles cmdMinus.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("-")
    End Sub

    Private Sub cmdZero_Click(sender As Object, e As EventArgs) Handles cmdZero.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("I()", 1)
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverExpressionModellingTree.Clear()
    End Sub

    Private Sub cmdSqrt_Click(sender As Object, e As EventArgs) Handles cmdSqrt.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("sqrt( )", 2)
    End Sub

    Private Sub cmdCos_Click(sender As Object, e As EventArgs) Handles cmdCos.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("cos( )", 2)
    End Sub

    Private Sub cmdLog_Click(sender As Object, e As EventArgs) Handles cmdLog.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("log( )", 2)
    End Sub

    Private Sub cmdSin_Click(sender As Object, e As EventArgs) Handles cmdSin.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("sin( )", 2)
    End Sub

    Private Sub cmdExp_Click(sender As Object, e As EventArgs) Handles cmdExp.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("exp( )", 2)
    End Sub

    Private Sub cmdTan_Click(sender As Object, e As EventArgs) Handles cmdTan.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("tan( )", 2)
    End Sub

    Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click

    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click

    End Sub

    Private Sub UpdatePreview()
        If Not ucrReceiverModellingTree.IsEmpty Then
            ucrInputModelPreview.SetName(clsFormularTildaOperator.ToScript())
        Else
            ucrInputModelPreview.SetName("")
        End If
    End Sub

    Public Sub ResponseConvert()
        If bRCodeSet Then
            If Not ucrReceiverExpressionModellingTree.IsEmpty() Then
                clsFormularTildaOperator.AddParameter("right", ucrReceiverExpressionModellingTree.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=2)
            End If


            If Not ucrReceiverModellingTree.IsEmpty Then
                clsVarOperator.AddParameter("combine", strParameterValue:=ucrReceiverModellingTree.GetVariableNames(), bIncludeArgumentName:=False)
                clsGetRankingItemsFunction.AddParameter("vars_to_get", clsROperatorParameter:=clsVarOperator, iPosition:=1)
            End If
            UpdatePreview()
            TestOKEnabled()
        End If
    End Sub


    Private Sub ucrReceiverExpressionModellingTree_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverExpressionModellingTree.ControlValueChanged
        clsFormularTildaOperator.AddParameter("right", ucrReceiverExpressionModellingTree.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=2)
        UpdatePreview()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverModellingTree_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverModellingTree.ControlValueChanged
        ResponseConvert()
    End Sub

    Private Sub ucrSelectorByDataFrameAddRemoveForModellingTree_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorByDataFrameAddRemoveForModellingTree.ControlValueChanged

        If clsGetVariablesMetaDataFunction.ContainsParameter("data_name") Then
            clsGetVariablesMetaDataFunction.RemoveParameterByName("data_name")
            clsGetVariablesMetaDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34), bIncludeArgumentName:=False)
        End If
        If clsGetVariablesFromMetaDataFunction.ContainsParameter("data_name") Then
            clsGetVariablesFromMetaDataFunction.RemoveParameterByName("data_name")
            clsGetVariablesFromMetaDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34), iPosition:=0)
        End If
        If clsRGetObjectFunction.ContainsParameter("data_name") Then
            clsRGetObjectFunction.RemoveParameterByName("data_name")
            clsRGetObjectFunction.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34))
        End If
        If clsGetDataFrameFunction.ContainsParameter("data") Then
            clsGetDataFrameFunction.RemoveParameterByName("data")
            clsGetDataFrameFunction.AddParameter("data", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34), bIncludeArgumentName:=False)
        End If
        If clsFactorFunction.ContainsParameter("x") Then
            clsFactorFunction.RemoveParameterByName("x")
            clsFactorFunction.AddParameter("x", ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & "[[var_name]]", bIncludeArgumentName:=False)
        End If

        clsGetDataFrameFunction.SetAssignTo(ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame)

    End Sub

    Private Sub UcrSelectorByDataFrameForModellingTreeSecond_ControlValueChanged(ucrChangedControl As ucrCore) Handles UcrSelectorByDataFrameForModellingTreeSecond.ControlValueChanged

        If clsGetSecondDataFrameFunction.ContainsParameter("data") Then
            clsGetSecondDataFrameFunction.RemoveParameterByName("data")
            clsGetSecondDataFrameFunction.AddParameter("data", Chr(34) & UcrSelectorByDataFrameForModellingTreeSecond.strCurrentDataFrame & Chr(34), bIncludeArgumentName:=False)
        End If
        If clsPlackettLuceFunction.ContainsParameter("data") Then
            clsPlackettLuceFunction.RemoveParameterByName("data")
            clsPlackettLuceFunction.AddParameter("data", UcrSelectorByDataFrameForModellingTreeSecond.strCurrentDataFrame)
        End If
        clsGetSecondDataFrameFunction.SetAssignTo(UcrSelectorByDataFrameForModellingTreeSecond.strCurrentDataFrame)



    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ucrReceiverExpressionModellingTree.AddtoCombobox(ucrReceiverExpressionModellingTree.GetText)
    End Sub

End Class







