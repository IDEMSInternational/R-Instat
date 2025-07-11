Imports instat.Translations
Imports System.Text.RegularExpressions

Public Class sdgTransformations
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDummyFunction As New RFunction
    Public clsOutputDataLevel, clsDefineTricotDataFunction, clsCreateTricotData, clsIDColsFunction, clsVarietyColsFunction, clsTraitColsFunction As New RFunction
    Private ucrBaseSelector As ucrSelector
    Dim lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))
    Dim lstRecognisedTraitsTypes As New List(Of KeyValuePair(Of String, List(Of String)))
    Dim lstRecognisedVarTypes As New List(Of KeyValuePair(Of String, List(Of String)))
    Dim lstRecognisedVarId As New List(Of KeyValuePair(Of String, List(Of String)))

    Dim lstReceiversLevelID As New List(Of ucrReceiverSingle)
    Dim lstReceiversVarietyLevel As New List(Of ucrReceiverSingle)
    Dim lstReceiversIDVarietyLevel As New List(Of ucrReceiverSingle)
    Dim lstReceiversIDVarietyTraitLevel As New List(Of ucrReceiverSingle)

    Private isFilling As Boolean = False

    Private ReadOnly strPos As String = "_pos"
    Private ReadOnly strBest As String = "_best"
    Private ReadOnly strNeg As String = "_neg"
    Private ReadOnly strWorst As String = "_worst"
    Private ReadOnly strNot As String = "Not observed"
    Private ReadOnly strMissing As String = "Missing"
    Private ReadOnly strNA As String = "NA"

    Private Sub sdgTransformations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        AutoFillReceiverTraitsType()
        AutoFillReceiverIdLevel()
        AutoFillReceiverVarId()
        AutoFillReceiverVariety()
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseSdgTransformations.iHelpTopicID = 720
        Dim kvpIDVar As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("id", {"id", "ID", "participant_id", "participant_name"}.ToList())

        Dim kvpID As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("id", {"id", "ID", "participant_id", "participant_name"}.ToList())
        Dim kvpTraits As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("traits", {"overall", "overall_perf", "Overall"}.ToList())
        Dim kvpVariety As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("variety", {"item", "items", "variety", "varieties"}.ToList())

        lstRecognisedTraitsTypes.AddRange({kvpVariety, kvpID})
        lstRecognisedVarTypes.AddRange({kvpVariety})
        lstRecognisedVarId.AddRange({kvpID, kvpVariety})
        lstRecognisedTypes.AddRange({kvpIDVar})

        lstReceiversLevelID.AddRange({ucrReceiverIDVariable})
        lstReceiversVarietyLevel.AddRange({ucrReceiverVariety})
        lstReceiversIDVarietyLevel.AddRange({ucrReceiverIDVarietyVar, ucrReceiverIDVarietyLevel})
        lstReceiversIDVarietyTraitLevel.AddRange({ucrReceiverTraits1, ucrReceiverTraitID, ucrReceiverTraitsVariety})

        ucrSelectorTricotIDLevel.SetParameter(New RParameter("id_level_data", 0))
        ucrSelectorTricotIDLevel.SetParameterIsString()

        ucrReceiverIDVariable.SetParameter(New RParameter("id_cols_a", 1, bNewIncludeArgumentName:=False))
        ucrReceiverIDVariable.SetParameterIsString()
        ucrReceiverIDVariable.Selector = ucrSelectorTricotIDLevel
        ucrReceiverIDVariable.strSelectorHeading = "ID"
        ucrReceiverIDVariable.SetItemType("column")
        ucrReceiverIDVariable.Tag = "id"

        ucrReceiverIDVarietyLevel.SetParameter(New RParameter("id_cols_b", 1, bNewIncludeArgumentName:=False))
        ucrReceiverIDVarietyLevel.SetParameterIsString()
        ucrReceiverIDVarietyLevel.Selector = ucrSelectorIDVarietyLevel
        ucrReceiverIDVarietyLevel.strSelectorHeading = "ID"
        ucrReceiverIDVarietyLevel.SetItemType("column")
        ucrReceiverIDVarietyLevel.Tag = "id"

        ucrReceiverTraitID.SetParameter(New RParameter("id_cols_c", 1, bNewIncludeArgumentName:=False))
        ucrReceiverTraitID.SetParameterIsString()
        ucrReceiverTraitID.Selector = ucrSelectorIDVarTraitLevel
        ucrReceiverTraitID.strSelectorHeading = "ID"
        ucrReceiverTraitID.SetItemType("column")
        ucrReceiverTraitID.Tag = "id"

        ucrReceiverVariety.SetParameter(New RParameter("variety_cols_a", 2, bNewIncludeArgumentName:=False))
        ucrReceiverVariety.SetParameterIsString()
        ucrReceiverVariety.Selector = ucrSelectorTricotVarietyLevel
        ucrReceiverVariety.strSelectorHeading = "Variety"
        ucrReceiverVariety.SetItemType("column")
        ucrReceiverVariety.Tag = "variety"

        ucrReceiverTraitsVariety.SetParameter(New RParameter("variety_cols_b", 2, bNewIncludeArgumentName:=False))
        ucrReceiverTraitsVariety.SetParameterIsString()
        ucrReceiverTraitsVariety.Selector = ucrSelectorIDVarTraitLevel
        ucrReceiverTraitsVariety.strSelectorHeading = "Variety"
        ucrReceiverTraitsVariety.SetItemType("column")
        ucrReceiverTraitsVariety.Tag = "variety"

        ucrReceiverIDVarietyVar.SetParameter(New RParameter("variety_cols_c", 2, bNewIncludeArgumentName:=False))
        ucrReceiverIDVarietyVar.SetParameterIsString()
        ucrReceiverIDVarietyVar.Selector = ucrSelectorIDVarietyLevel
        ucrReceiverIDVarietyVar.strSelectorHeading = "Variety"
        ucrReceiverIDVarietyVar.SetItemType("column")
        ucrReceiverIDVarietyVar.Tag = "variety"

        ucrReceiverTraits1.SetParameter(New RParameter("trait_cols_a", 3, bNewIncludeArgumentName:=False))
        ucrReceiverTraits1.SetParameterIsString()
        ucrReceiverTraits1.Selector = ucrSelectorIDVarTraitLevel
        ucrReceiverTraits1.strSelectorHeading = "Traits"
        ucrReceiverTraits1.SetItemType("column")
        ucrReceiverTraits1.Tag = "traits"

        ucrReceiverTraits2.SetParameter(New RParameter("trait_cols_b", 4, bNewIncludeArgumentName:=False))
        ucrReceiverTraits2.SetParameterIsString()
        ucrReceiverTraits2.Selector = ucrSelectorIDVarietyLevel
        ucrReceiverTraits2.strSelectorHeading = "Traits"
        ucrReceiverTraits2.SetItemType("column")

        ucrReceiverVarietyVariables.SetParameter(New RParameter("variety_cols", 3, bNewIncludeArgumentName:=False))
        ucrReceiverVarietyVariables.SetLinkedDisplayControl(lblReceiverSpecifyVarietyVariables)
        ucrReceiverVarietyVariables.SetParameterIsString()
        ucrReceiverVarietyVariables.Selector = ucrSelectorTricotIDLevel
        ucrReceiverVarietyVariables.strSelectorHeading = "Varieties"
        ucrReceiverVarietyVariables.SetItemType("column")

        ucrInputRankValues.SetLinkedDisplayControl(lblReceiverRankValues)
        ucrInputRankValues.SetValidationTypeAsList()
        ucrInputRankValues.SetText(Chr(34) & "A" & Chr(34) & "," & Chr(34) & "B" & Chr(34) & "," & Chr(34) & "C" & Chr(34))

        ucrReceiverTraitVariables.SetParameter(New RParameter("data_trait_cols", 3, bNewIncludeArgumentName:=False))
        ucrReceiverTraitVariables.SetLinkedDisplayControl(lblTraitVariables)
        ucrReceiverTraitVariables.SetParameterIsString()
        ucrReceiverTraitVariables.Selector = ucrSelectorTricotIDLevel
        ucrReceiverTraitVariables.strSelectorHeading = "Traits"
        ucrReceiverTraitVariables.SetItemType("column")

        ucrReceiverCarryColumns.SetParameter(New RParameter("carry_cols", 3, bNewIncludeArgumentName:=False))
        ucrReceiverCarryColumns.SetLinkedDisplayControl(lblReceiverCarryColumns)
        ucrReceiverCarryColumns.SetParameterIsString()
        ucrReceiverCarryColumns.Selector = ucrSelectorTricotIDLevel
        ucrReceiverCarryColumns.strSelectorHeading = "Carry Columns"
        ucrReceiverCarryColumns.SetItemType("column")

        ucrChkSpecifyVariety.SetText("Specify Variety Variables")
        ucrChkSpecifyVariety.AddParameterValuesCondition(True, "check", "True")
        ucrChkSpecifyVariety.AddParameterValuesCondition(False, "check", "False")
        ucrChkSpecifyVariety.Checked = False
        'ucrChkSpecifyVariety.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        'ucrChkSpecifyVariety.SetRDefault("FALSE")
        ucrChkSpecifyVariety.AddToLinkedControls(ucrReceiverVarietyVariables, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSpecifyRankValues.SetText("Specify Rank Values")
        ucrChkSpecifyRankValues.AddParameterValuesCondition(True, "check", "True")
        ucrChkSpecifyRankValues.AddParameterValuesCondition(False, "check", "False")
        ucrChkSpecifyRankValues.AddToLinkedControls(ucrInputRankValues, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSpecifyRankValues.Checked = False

        ucrChkSpecifyTraitVariables.SetText("Specify Trait Variables")
        ucrChkSpecifyTraitVariables.AddParameterValuesCondition(True, "check", "True")
        ucrChkSpecifyTraitVariables.AddParameterValuesCondition(False, "check", "False")
        ucrChkSpecifyTraitVariables.AddToLinkedControls(ucrReceiverTraitVariables, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSpecifyTraitVariables.Checked = False

        ucrChkCarryColumns.SetText("Carry columns")
        ucrChkCarryColumns.AddParameterValuesCondition(True, "check", "True")
        ucrChkCarryColumns.AddParameterValuesCondition(False, "check", "False")
        ucrChkCarryColumns.AddToLinkedControls(ucrReceiverCarryColumns, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkCarryColumns.Checked = False

        ucrInputGoodTraits.SetItems({strPos, strBest})
        ucrInputGoodTraits.SetDropDownStyleAsEditable(True)
        ucrInputGoodTraits.SetLinkedDisplayControl(lblGoodTraits)
        ucrInputGoodTraits.SetParameter(New RParameter("good_suffixes", 5))
        ucrInputGoodTraits.SetText(strPos)

        ucrInputBadTraits.SetItems({strNeg, strWorst})
        ucrInputBadTraits.SetDropDownStyleAsEditable(True)
        ucrInputBadTraits.SetLinkedDisplayControl(lblBadTraits)
        ucrInputBadTraits.SetParameter(New RParameter("bad_suffixes", 6))
        ucrInputBadTraits.SetText(strNeg)

        ucrInputNAS.SetItems({strNot, strMissing, strNA})
        ucrInputNAS.SetDropDownStyleAsNonEditable()
        ucrInputNAS.SetLinkedDisplayControl(lblNAs)
        ucrInputNAS.SetParameter(New RParameter("na_candidates", 7))
        ucrInputNAS.SetText(strNot)

        ucrChkTraits.SetText("Choose Traits Suffix")
        ucrChkTraits.AddParameterValuesCondition(True, "check", "True")
        ucrChkTraits.AddParameterValuesCondition(False, "check", "False")
        SetVisibility()
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, clsNewDefineTricotDataFunction As RFunction, clsNewDefaultFunction As RFunction, clsNewIDColsFunction As RFunction, clsNewVarietyColsFunction As RFunction, clsNewTraitColsFunction As RFunction, Optional ucrNewBaseSelector As ucrSelector = Nothing, Optional bReset As Boolean = False, Optional strDefaultTab As String = "")
        clsOutputDataLevel = clsNewRFunction
        clsCreateTricotData = clsNewDefaultFunction
        clsIDColsFunction = clsNewIDColsFunction
        clsVarietyColsFunction = clsNewVarietyColsFunction
        clsTraitColsFunction = clsNewTraitColsFunction
        clsDefineTricotDataFunction = clsNewDefineTricotDataFunction
        ucrBaseSelector = ucrNewBaseSelector
        ucrReceiverIDVariable.SetMeAsReceiver()
        ucrInputGoodTraits.SetText(strPos)
        ucrInputGoodTraits.bUpdateRCodeFromControl = True
        ucrInputBadTraits.SetText(strNeg)
        ucrInputBadTraits.bUpdateRCodeFromControl = True
        ucrInputNAS.SetText(strNot)
        ucrInputNAS.bUpdateRCodeFromControl = True

        clsDummyFunction.AddParameter("check", "False", iPosition:=0)

        ucrReceiverIDVariable.AddAdditionalCodeParameterPair(clsCreateTricotData, New RParameter("id_col", 0, bNewIncludeArgumentName:=True), iAdditionalPairNo:=1)

        ucrReceiverIDVariable.SetRCode(clsIDColsFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverIDVarietyLevel.SetRCode(clsIDColsFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverTraitID.SetRCode(clsIDColsFunction, bReset, bCloneIfNeeded:=True)

        ucrReceiverVariety.SetRCode(clsVarietyColsFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverIDVarietyVar.SetRCode(clsVarietyColsFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverTraitsVariety.SetRCode(clsVarietyColsFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverTraits1.SetRCode(clsTraitColsFunction, bReset, bCloneIfNeeded:=True)

        AutoFillReceiverTraitsType()
        AutoFillReceiverIdLevel()
        AutoFillReceiverVarId()
        AutoFillReceiverVariety()

        AddVarietyColsParam()
        AddRankValuesParam()
        AddDataTraitColsParam()
        AddCarryColsParam()

        SetVisibility()

        If bReset Then
            ucrReceiverVarietyVariables.Clear()
            ucrReceiverTraitVariables.Clear()
            ucrReceiverCarryColumns.Clear()
            ucrChkSpecifyVariety.Checked = False
            ucrChkSpecifyRankValues.Checked = False
            ucrChkSpecifyTraitVariables.Checked = False
            ucrChkCarryColumns.Checked = False
            ucrChkTraits.SetRCode(clsDummyFunction, bReset)
            ucrReceiverIDVariable.SetMeAsReceiver()
            tbOptions.SelectedIndex = 0
        End If
    End Sub

    Private Sub ucrInputGoodTraits_NameChanged() Handles ucrInputGoodTraits.ControlValueChanged
        AddGoodSuffixesPar()
    End Sub

    Private Sub ucrInputBadTraits_NameChanged() Handles ucrInputBadTraits.ControlValueChanged
        AddBadSuffixesPar()
    End Sub

    Private Sub AddBadSuffixesPar()
        If ucrChkTraits.Checked AndAlso Not ucrInputBadTraits.IsEmpty Then
            clsCreateTricotData.AddParameter("bad_suffixes", Chr(34) & ucrInputBadTraits.GetText & Chr(34))
            'clsDefineTricotDataFunction.AddParameter("bad_suffixes", Chr(34) & ucrInputBadTraits.GetText & Chr(34), iPosition:=2)
        Else
            clsCreateTricotData.RemoveParameterByName("bad_suffixes")
            'clsDefineTricotDataFunction.RemoveParameterByName("bad_suffixes")
        End If
    End Sub

    Private Sub AddGoodSuffixesPar()
        If ucrChkTraits.Checked AndAlso Not ucrInputGoodTraits.IsEmpty Then
            clsCreateTricotData.AddParameter("good_suffixes", Chr(34) & ucrInputGoodTraits.GetText & Chr(34))
            'clsDefineTricotDataFunction.AddParameter("good_suffixes", Chr(34) & ucrInputGoodTraits.GetText & Chr(34), iPosition:=1)
        Else
            clsCreateTricotData.RemoveParameterByName("good_suffixes")
            'clsDefineTricotDataFunction.RemoveParameterByName("good_suffixes")
        End If
    End Sub

    Private Sub ucrInputNAS_NameChanged() Handles ucrInputNAS.ControlValueChanged
        If ucrInputNAS.IsEmpty() Then
            clsCreateTricotData.RemoveParameterByName("na_candidates")
            'clsDefineTricotDataFunction.RemoveParameterByName("na_candidates")
        Else
            clsCreateTricotData.AddParameter("na_candidates", Chr(34) & ucrInputNAS.GetText & Chr(34))
            'clsDefineTricotDataFunction.AddParameter("na_candidates", Chr(34) & ucrInputNAS.GetText & Chr(34), iPosition:=3)
        End If
    End Sub

    Private Sub AddVarietyColsParam()
        If ucrChkSpecifyVariety.Checked Then
            ucrReceiverVarietyVariables.SetMeAsReceiver()
            If Not ucrReceiverVarietyVariables.IsEmpty() Then
                clsDefineTricotDataFunction.AddParameter("variety_cols", ucrReceiverVarietyVariables.GetVariableNames(), iPosition:=5)
                clsCreateTricotData.AddParameter("variety_cols", ucrReceiverVarietyVariables.GetVariableNames(), iPosition:=5)
            End If
        Else
            ucrReceiverIDVariable.SetMeAsReceiver()
            If clsDefineTricotDataFunction.ContainsParameter("variety_cols") Then
                clsDefineTricotDataFunction.RemoveParameterByName("variety_cols")
            End If

            If clsCreateTricotData.ContainsParameter("variety_cols") Then
                clsCreateTricotData.RemoveParameterByName("variety_cols")
            End If
        End If
    End Sub

    Private Sub AddRankValuesParam()
        If ucrChkSpecifyRankValues.Checked AndAlso Not ucrInputRankValues.IsEmpty() Then
            clsCreateTricotData.AddParameter("rank_values", "c(" & ucrInputRankValues.GetText() & ")", iPosition:=6)
        Else
            If clsCreateTricotData.ContainsParameter("rank_values") Then
                clsCreateTricotData.RemoveParameterByName("rank_values")
            End If
        End If
    End Sub

    Private Sub AddDataTraitColsParam()
        If ucrChkSpecifyTraitVariables.Checked Then
            ucrReceiverTraitVariables.SetMeAsReceiver()
            If Not ucrReceiverTraitVariables.IsEmpty() Then
                clsCreateTricotData.AddParameter("data_trait_cols", ucrReceiverTraitVariables.GetVariableNames(), iPosition:=7)
            End If
        Else
            ucrReceiverIDVariable.SetMeAsReceiver()
            If clsCreateTricotData.ContainsParameter("data_trait_cols") Then
                clsCreateTricotData.RemoveParameterByName("data_trait_cols")
            End If
        End If
    End Sub

    Private Sub AddCarryColsParam()
        If ucrChkCarryColumns.Checked Then
            ucrReceiverCarryColumns.SetMeAsReceiver()
            If Not ucrReceiverCarryColumns.IsEmpty() Then
                clsCreateTricotData.AddParameter("carry_cols", ucrReceiverCarryColumns.GetVariableNames(), iPosition:=8)
            End If
        Else
            ucrReceiverIDVariable.SetMeAsReceiver()
            If clsCreateTricotData.ContainsParameter("carry_cols") Then
                clsCreateTricotData.RemoveParameterByName("carry_cols")
            End If
        End If
    End Sub

    Private Sub ucrChkCarryColumns_ControlValueChanged(ucrControlChanged As ucrCore) Handles ucrChkCarryColumns.ControlValueChanged
        AddCarryColsParam()
    End Sub

    Private Sub ucrReceiverCarryColumns_ControlValueChanged(ucrControlChanged As ucrCore) Handles ucrReceiverCarryColumns.ControlValueChanged
        AddCarryColsParam()
    End Sub

    Private Sub ucrChkSpecifyTraitVariables_ControlValueChanged(ucrControlChanged As ucrCore) Handles ucrChkSpecifyTraitVariables.ControlValueChanged
        AddDataTraitColsParam()
    End Sub

    Private Sub ucrReceiverTraitVariables_ControlValueChanged(ucrControlChanged As ucrCore) Handles ucrReceiverTraitVariables.ControlValueChanged
        AddDataTraitColsParam()
    End Sub


    Private Sub ucrChkSpecifyRankValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSpecifyRankValues.ControlValueChanged
        AddRankValuesParam()
    End Sub

    Private Sub ucrInputRankValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputRankValues.ControlValueChanged
        AddRankValuesParam()
    End Sub

    Private Sub ucrChkSpecifyVariety_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSpecifyVariety.ControlValueChanged
        AddVarietyColsParam()
    End Sub

    Private Sub ucrReceiverVarietyVariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVarietyVariables.ControlValueChanged
        AddVarietyColsParam()
    End Sub

    Private Sub ucrIDReceivers_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverIDVarietyLevel.ControlValueChanged, ucrReceiverTraitID.ControlValueChanged
        FilledIDReceivers()
    End Sub

    Private Sub ucrVarietyReceivers_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariety.ControlValueChanged, ucrReceiverIDVarietyLevel.ControlValueChanged, ucrReceiverTraitsVariety.ControlValueChanged
        FilledVarietyReceivers()
    End Sub

    Private Sub ucrTraitReceivers_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverTraits1.ControlValueChanged
        FilledTraitReceivers()
    End Sub

    Private Sub FilledIDReceivers()
        If Not ucrReceiverIDVariable.IsEmpty OrElse Not ucrReceiverIDVarietyLevel.IsEmpty OrElse Not ucrReceiverTraitID.IsEmpty Then
            clsIDColsFunction.RemoveParameterByName("id_1")
            clsIDColsFunction.RemoveParameterByName("id_2")
            clsIDColsFunction.RemoveParameterByName("id_3")
            clsIDColsFunction.RemoveParameterByName("id_4")
            If Not ucrReceiverIDVariable.IsEmpty Then
                clsIDColsFunction.AddParameter("id_cols_a", strParameterValue:=ucrReceiverIDVariable.GetVariableNames, bIncludeArgumentName:=False)
            Else
                clsIDColsFunction.RemoveParameterByName("id_cols_a")
            End If
            If Not ucrReceiverIDVariable.IsEmpty Then
                clsIDColsFunction.AddParameter("id_cols_b", strParameterValue:=ucrReceiverIDVarietyLevel.GetVariableNames, bIncludeArgumentName:=False)
            Else
                clsIDColsFunction.RemoveParameterByName("id_cols_b")
            End If
            If Not ucrReceiverIDVariable.IsEmpty Then
                clsIDColsFunction.AddParameter("id_cols_c", strParameterValue:=ucrReceiverTraitID.GetVariableNames, bIncludeArgumentName:=False)
            Else
                clsIDColsFunction.RemoveParameterByName("id_cols_c")
            End If
        Else
            clsIDColsFunction.AddParameter("id_1", Chr(34) & "ID" & Chr(34), bIncludeArgumentName:=False)
            clsIDColsFunction.AddParameter("id_2", Chr(34) & "id" & Chr(34), bIncludeArgumentName:=False)
            clsIDColsFunction.AddParameter("id_3", Chr(34) & "participant_name" & Chr(34), bIncludeArgumentName:=False)
            clsIDColsFunction.AddParameter("id_4", Chr(34) & "participant_id" & Chr(34), bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub FilledVarietyReceivers()
        If Not ucrReceiverIDVariable.IsEmpty OrElse Not ucrReceiverIDVarietyLevel.IsEmpty OrElse Not ucrReceiverTraitID.IsEmpty Then
            clsVarietyColsFunction.RemoveParameterByName("var_1")
            clsVarietyColsFunction.RemoveParameterByName("var_2")
            clsVarietyColsFunction.RemoveParameterByName("var_3")
            clsVarietyColsFunction.RemoveParameterByName("var_4")
            clsVarietyColsFunction.RemoveParameterByName("var_5")
            clsVarietyColsFunction.RemoveParameterByName("var_6")
            If Not ucrReceiverVariety.IsEmpty Then
                clsVarietyColsFunction.AddParameter("variety_cols_a", strParameterValue:=ucrReceiverVariety.GetVariableNames, bIncludeArgumentName:=False)
            Else
                clsVarietyColsFunction.RemoveParameterByName("variety_cols_a")
            End If
            If Not ucrReceiverIDVarietyVar.IsEmpty Then
                clsVarietyColsFunction.AddParameter("variety_cols_b", strParameterValue:=ucrReceiverIDVarietyVar.GetVariableNames, bIncludeArgumentName:=False)
            Else
                clsVarietyColsFunction.RemoveParameterByName("variety_cols_b")
            End If
            If Not ucrReceiverTraitsVariety.IsEmpty Then
                clsVarietyColsFunction.AddParameter("variety_cols_c", strParameterValue:=ucrReceiverTraitsVariety.GetVariableNames, bIncludeArgumentName:=False)
            Else
                clsVarietyColsFunction.RemoveParameterByName("variety_cols_c")
            End If
        Else
            clsVarietyColsFunction.AddParameter("var_1", Chr(34) & "variety" & Chr(34), bIncludeArgumentName:=False)
            clsVarietyColsFunction.AddParameter("var_2", Chr(34) & "varieties" & Chr(34), bIncludeArgumentName:=False)
            clsVarietyColsFunction.AddParameter("var_3", Chr(34) & "item" & Chr(34), bIncludeArgumentName:=False)
            clsVarietyColsFunction.AddParameter("var_4", Chr(34) & "items" & Chr(34), bIncludeArgumentName:=False)
            clsVarietyColsFunction.AddParameter("var_5", Chr(34) & "Genotype" & Chr(34), bIncludeArgumentName:=False)
            clsVarietyColsFunction.AddParameter("var_6", Chr(34) & "genotype" & Chr(34), bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub FilledTraitReceivers()
        If Not ucrReceiverIDVariable.IsEmpty OrElse Not ucrReceiverIDVarietyLevel.IsEmpty OrElse Not ucrReceiverTraitID.IsEmpty Then
            clsTraitColsFunction.RemoveParameterByName("trait_1")
            clsTraitColsFunction.RemoveParameterByName("trait_2")
            If Not ucrReceiverTraits1.IsEmpty Then
                clsTraitColsFunction.AddParameter("trait_cols_a", strParameterValue:=ucrReceiverTraits1.GetVariableNames, bIncludeArgumentName:=False)
                'clsDefineTricotDataFunction.AddParameter("trait_cols", strParameterValue:=ucrReceiverTraits1.GetVariableNames, iPosition:=4)
            Else
                clsIDColsFunction.RemoveParameterByName("trait_cols_a")
                'clsDefineTricotDataFunction.RemoveParameterByName("trait_cols")
            End If
        Else
            clsTraitColsFunction.AddParameter("trait_1", Chr(34) & "trait" & Chr(34), bIncludeArgumentName:=False)
            clsTraitColsFunction.AddParameter("trait_2", Chr(34) & "traits" & Chr(34), bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub AutoFillReceiverTraitsType()
        If isFilling Then
            Exit Sub
        End If
        isFilling = True

        ' Temporarily remove the event handler
        RemoveHandler ucrSelectorIDVarTraitLevel.ControlValueChanged, AddressOf AutoFillReceiverTraitsType

        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrSelectorIDVarTraitLevel.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceiversIDVarietyTraitLevel
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValuesTraits(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrSelectorIDVarTraitLevel.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]_", String.Empty).Contains(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, ucrSelectorIDVarTraitLevel.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                            bFound = True
                            Exit For
                        End If
                    Next
                    If bFound Then
                        bFound = False
                        Exit For
                    End If
                Next
            End If
        Next

        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If

        ' Re-enable the event handler
        AddHandler ucrSelectorIDVarTraitLevel.ControlValueChanged, AddressOf AutoFillReceiverTraitsType

        isFilling = False
    End Sub

    Private Function GetRecognisedValuesTraits(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedTraitsTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function

    Private Sub AutoFillReceiverVariety()
        If isFilling Then
            Exit Sub
        End If
        isFilling = True

        ' Temporarily remove the event handler
        RemoveHandler ucrSelectorTricotVarietyLevel.ControlValueChanged, AddressOf AutoFillReceiverVariety

        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrSelectorTricotVarietyLevel.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceiversVarietyLevel
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedVarietyLev(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrSelectorTricotVarietyLevel.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]|_", String.Empty).Contains(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, ucrSelectorTricotVarietyLevel.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                            bFound = True
                            Exit For
                        End If
                    Next
                    If bFound Then
                        bFound = False
                        Exit For
                    End If
                Next
            End If
        Next

        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If

        ' Re-enable the event handler
        AddHandler ucrSelectorTricotVarietyLevel.ControlValueChanged, AddressOf AutoFillReceiverVariety

        isFilling = False
    End Sub

    Private Function GetRecognisedVarietyLev(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedVarTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function

    Private Sub AutoFillReceiverIdLevel()
        If isFilling Then
            Exit Sub
        End If
        isFilling = True

        ' Temporarily remove the event handler
        RemoveHandler ucrSelectorTricotIDLevel.ControlValueChanged, AddressOf AutoFillReceiverIdLevel

        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrSelectorTricotIDLevel.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceiversLevelID
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValuesId(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrSelectorTricotIDLevel.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]_", String.Empty).Contains(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, ucrSelectorTricotIDLevel.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                            bFound = True
                            Exit For
                        End If
                    Next
                    If bFound Then
                        bFound = False
                        Exit For
                    End If
                Next
            End If
        Next

        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If

        ' Re-enable the event handler
        AddHandler ucrSelectorTricotIDLevel.ControlValueChanged, AddressOf AutoFillReceiverIdLevel

        isFilling = False
    End Sub

    Private Function GetRecognisedValuesId(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function

    Private Sub AutoFillReceiverVarId()
        If isFilling Then
            Exit Sub
        End If
        isFilling = True

        ' Temporarily remove the event handler
        RemoveHandler ucrSelectorIDVarietyLevel.ControlValueChanged, AddressOf AutoFillReceiverVarId

        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrSelectorIDVarietyLevel.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceiversIDVarietyLevel
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValuesVarId(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrSelectorIDVarietyLevel.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]_", String.Empty).Contains(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, ucrSelectorIDVarietyLevel.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                            bFound = True
                            Exit For
                        End If
                    Next
                    If bFound Then
                        bFound = False
                        Exit For
                    End If
                Next
            End If
        Next

        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If

        ' Re-enable the event handler
        AddHandler ucrSelectorIDVarietyLevel.ControlValueChanged, AddressOf AutoFillReceiverVarId

        isFilling = False
    End Sub

    Private Function GetRecognisedValuesVarId(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedVarId
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function

    Private Sub ucrSelectorTricotIDLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTricotIDLevel.ControlValueChanged
        AutoFillReceiverIdLevel()
    End Sub

    Private Sub ucrSelectorTricotVarietyLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTricotVarietyLevel.ControlValueChanged
        AutoFillReceiverVariety()
    End Sub

    Private Sub ucrSelectorIDVarietyLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorIDVarietyLevel.ControlValueChanged
        AutoFillReceiverVarId()
    End Sub

    Private Sub ucrSelectorIDVarTraitLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorIDVarTraitLevel.ControlValueChanged
        AutoFillReceiverTraitsType()
    End Sub

    Private Sub ucrChkTraits_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTraits.ControlValueChanged
        AddGoodSuffixesPar()
        AddBadSuffixesPar()
        SetVisibility()
    End Sub

    Private Sub SetVisibility()
        ucrInputGoodTraits.Visible = ucrChkTraits.Checked
        ucrInputBadTraits.Visible = ucrChkTraits.Checked
        ucrReceiverVarietyVariables.Visible = ucrChkSpecifyVariety.Checked
        ucrInputRankValues.Visible = ucrChkSpecifyRankValues.Checked
        ucrReceiverTraitVariables.Visible = ucrChkSpecifyTraitVariables.Checked
        ucrReceiverCarryColumns.Visible = ucrChkCarryColumns.Checked
    End Sub
End Class
