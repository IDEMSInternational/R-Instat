Imports System.Text.RegularExpressions

Public Class sdgTransformations
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public clsOutputDataLevel, clsCreateTricotData, clsIDColsFunction, clsVarietyColsFunction, clsTraitColsFunction As New RFunction
    Private ucrBaseSelector As ucrSelector
    Private lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))
    Private lstReceiversLevelID, lstReceiversVarietyLevel, lstReceiversIDVarietyLevel, lstReceiversIDVarietyTraitLevel As New List(Of ucrReceiverSingle)

    Private ReadOnly strPos As String = "_pos"
    Private ReadOnly strBest As String = "_best"
    Private ReadOnly strNeg As String = "_neg"
    Private ReadOnly strWorst As String = "_worst"
    Private ReadOnly strNot As String = "Not observed"
    Private ReadOnly strMissing As String = "Missing"
    Private ReadOnly strNA As String = "NA"

    Private Sub sdgTransformations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        AutoFillReceivers(ucrSelectorTricotIDLevel, lstReceiversLevelID)
        AutoFillReceivers(ucrSelectorTricotVarietyLevel, lstReceiversVarietyLevel)
        AutoFillReceivers(ucrSelectorIDVarietyLevel, lstReceiversIDVarietyLevel)
        AutoFillReceivers(ucrSelectorIDVarTraitLevel, lstReceiversIDVarietyTraitLevel)
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseSdgTransformations.iHelpTopicID = 720

        Dim kvpID As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("id", {"id", "ID", "participant_id", "participant_name"}.ToList())
        Dim kvpTraits As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("traits", {"overall", "overall_perf", "Overall"}.ToList())
        Dim kvpVariety As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("variety", {"item", "items", "variety", "varieties"}.ToList())

        lstRecognisedTypes.AddRange({kvpID, kvpTraits, kvpVariety})
        lstReceiversLevelID.AddRange({ucrReceiverIDVariable})
        lstReceiversVarietyLevel.AddRange({ucrReceiverVariety})
        lstReceiversIDVarietyLevel.AddRange({ucrReceiverIDVarietyVar, ucrReceiverIDVarietyLevel})
        lstReceiversIDVarietyTraitLevel.AddRange({ucrReceiverTraitsVariety, ucrReceiverTraitID, ucrReceiverTraits1})

        ucrSelectorTricotIDLevel.SetParameter(New RParameter("id_level_data", 0))
        ucrSelectorTricotIDLevel.SetParameterIsString()
        SetRSelector(ucrSelectorTricotIDLevel, lstReceiversLevelID)
        SetRSelector(ucrSelectorTricotVarietyLevel, lstReceiversVarietyLevel)
        SetRSelector(ucrSelectorIDVarietyLevel, lstReceiversIDVarietyLevel)
        SetRSelector(ucrSelectorIDVarTraitLevel, lstReceiversIDVarietyTraitLevel)

        ucrReceiverIDVariable.SetParameter(New RParameter("id_cols_a", 1, bNewIncludeArgumentName:=False))
        ucrReceiverIDVariable.SetParameterIsString()
        ucrReceiverIDVariable.Selector = ucrSelectorTricotIDLevel
        ucrReceiverIDVariable.strSelectorHeading = "ID"
        ucrReceiverIDVariable.SetItemType("column")
        ucrReceiverIDVariable.SetTricotType("id")
        ucrReceiverIDVariable.bAutoFill = True

        ucrReceiverIDVarietyLevel.SetParameter(New RParameter("id_cols_b", 1, bNewIncludeArgumentName:=False))
        ucrReceiverIDVarietyLevel.SetParameterIsString()
        ucrReceiverIDVarietyLevel.Selector = ucrSelectorIDVarietyLevel
        ucrReceiverIDVarietyLevel.strSelectorHeading = "ID"
        ucrReceiverIDVarietyLevel.SetItemType("column")
        ucrReceiverIDVarietyLevel.SetTricotType("id")
        ucrReceiverIDVarietyLevel.bAutoFill = True

        ucrReceiverTraitID.SetParameter(New RParameter("id_cols_c", 1, bNewIncludeArgumentName:=False))
        ucrReceiverTraitID.SetParameterIsString()
        ucrReceiverTraitID.Selector = ucrSelectorIDVarTraitLevel
        ucrReceiverTraitID.strSelectorHeading = "ID"
        ucrReceiverTraitID.SetItemType("column")
        ucrReceiverTraitID.SetTricotType("id")
        ucrReceiverTraitID.bAutoFill = True

        ucrReceiverVariety.SetParameter(New RParameter("variety_cols_a", 2, bNewIncludeArgumentName:=False))
        ucrReceiverVariety.SetParameterIsString()
        ucrReceiverVariety.Selector = ucrSelectorTricotVarietyLevel
        ucrReceiverVariety.strSelectorHeading = "Variety"
        ucrReceiverVariety.SetItemType("column")
        ucrReceiverVariety.SetTricotType("variety")
        ucrReceiverVariety.bAutoFill = True

        ucrReceiverTraitsVariety.SetParameter(New RParameter("variety_cols_b", 2, bNewIncludeArgumentName:=False))
        ucrReceiverTraitsVariety.SetParameterIsString()
        ucrReceiverTraitsVariety.Selector = ucrSelectorIDVarTraitLevel
        ucrReceiverTraitsVariety.strSelectorHeading = "Variety"
        ucrReceiverTraitsVariety.SetItemType("column")
        ucrReceiverTraitsVariety.SetTricotType("variety")
        ucrReceiverTraitsVariety.bAutoFill = True

        ucrReceiverIDVarietyVar.SetParameter(New RParameter("variety_cols_c", 2, bNewIncludeArgumentName:=False))
        ucrReceiverIDVarietyVar.SetParameterIsString()
        ucrReceiverIDVarietyVar.Selector = ucrSelectorIDVarietyLevel
        ucrReceiverIDVarietyVar.strSelectorHeading = "Variety"
        ucrReceiverIDVarietyVar.SetItemType("column")
        ucrReceiverIDVarietyVar.SetTricotType("variety")
        ucrReceiverIDVarietyVar.bAutoFill = True

        ucrReceiverTraits1.SetParameter(New RParameter("trait_cols_a", 3, bNewIncludeArgumentName:=False))
        ucrReceiverTraits1.SetParameterIsString()
        ucrReceiverTraits1.Selector = ucrSelectorIDVarTraitLevel
        ucrReceiverTraits1.strSelectorHeading = "Traits"
        ucrReceiverTraits1.SetItemType("column")
        ucrReceiverTraits1.SetTricotType("traits")
        ucrReceiverTraits1.bAutoFill = True

        ucrReceiverTraits2.SetParameter(New RParameter("trait_cols_b", 4, bNewIncludeArgumentName:=False))
        ucrReceiverTraits2.SetParameterIsString()
        ucrReceiverTraits2.Selector = ucrSelectorIDVarietyLevel
        ucrReceiverTraits2.strSelectorHeading = "Traits"
        ucrReceiverTraits2.SetItemType("column")
        ucrReceiverTraits2.SetTricotType("traits")
        ucrReceiverTraits2.bAutoFill = True

        ucrInputGoodTraits.SetItems({strPos, strBest})
        ucrInputGoodTraits.SetDropDownStyleAsNonEditable()
        ucrInputGoodTraits.SetLinkedDisplayControl(lblGoodTraits)
        ucrInputGoodTraits.SetParameter(New RParameter("good_suffixes", 5))
        ucrInputGoodTraits.SetText(strPos)

        ucrInputBadTraits.SetItems({strNeg, strWorst})
        ucrInputBadTraits.SetDropDownStyleAsNonEditable()
        ucrInputBadTraits.SetLinkedDisplayControl(lblBadTraits)
        ucrInputBadTraits.SetParameter(New RParameter("bad_suffixes", 6))
        ucrInputBadTraits.SetText(strNeg)

        ucrInputNAS.SetItems({strNot, strMissing, strNA})
        ucrInputNAS.SetDropDownStyleAsNonEditable()
        ucrInputNAS.SetLinkedDisplayControl(lblNAs)
        ucrInputNAS.SetParameter(New RParameter("na_candidates", 7))
        ucrInputNAS.SetText(strNot)

    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, clsNewDefaultFunction As RFunction, clsNewIDColsFunction As RFunction, clsNewVarietyColsFunction As RFunction, clsNewTraitColsFunction As RFunction, Optional ucrNewBaseSelector As ucrSelector = Nothing, Optional bReset As Boolean = False, Optional strDefaultTab As String = "")
        clsOutputDataLevel = clsNewRFunction
        clsCreateTricotData = clsNewDefaultFunction
        clsIDColsFunction = clsNewIDColsFunction
        clsVarietyColsFunction = clsNewVarietyColsFunction
        clsTraitColsFunction = clsNewTraitColsFunction
        ucrBaseSelector = ucrNewBaseSelector
        ucrReceiverIDVariable.SetMeAsReceiver()
        ucrInputGoodTraits.SetText(strPos)
        ucrInputGoodTraits.bUpdateRCodeFromControl = True
        ucrInputBadTraits.SetText(strNeg)
        ucrInputBadTraits.bUpdateRCodeFromControl = True
        ucrInputNAS.SetText(strNot)
        ucrInputNAS.bUpdateRCodeFromControl = True

        ucrReceiverIDVariable.AddAdditionalCodeParameterPair(clsCreateTricotData, New RParameter("id_col", 0, bNewIncludeArgumentName:=True), iAdditionalPairNo:=1)

        ucrReceiverIDVariable.SetRCode(clsIDColsFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverIDVarietyLevel.SetRCode(clsIDColsFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverTraitID.SetRCode(clsIDColsFunction, bReset, bCloneIfNeeded:=True)

        ucrReceiverVariety.SetRCode(clsVarietyColsFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverIDVarietyVar.SetRCode(clsVarietyColsFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverTraitsVariety.SetRCode(clsVarietyColsFunction, bReset, bCloneIfNeeded:=True)

        ucrReceiverTraits1.SetRCode(clsTraitColsFunction, bReset, bCloneIfNeeded:=True)

        AutoFillReceivers(ucrSelectorTricotIDLevel, lstReceiversLevelID)
        AutoFillReceivers(ucrSelectorTricotVarietyLevel, lstReceiversVarietyLevel)
        AutoFillReceivers(ucrSelectorIDVarietyLevel, lstReceiversIDVarietyLevel)
        AutoFillReceivers(ucrSelectorIDVarTraitLevel, lstReceiversIDVarietyTraitLevel)

        If bReset Then
            ucrReceiverIDVariable.SetMeAsReceiver()
            tbOptions.SelectedIndex = 0
        End If
    End Sub

    Private Sub ucrInputGoodTraits_NameChanged() Handles ucrInputGoodTraits.ControlValueChanged
        If ucrInputGoodTraits.IsEmpty() Then
            clsCreateTricotData.RemoveParameterByName("good_suffixes")
        Else
            clsCreateTricotData.AddParameter("good_suffixes", Chr(34) & ucrInputGoodTraits.GetText & Chr(34))
        End If
    End Sub

    Private Sub ucrInputBadTraits_NameChanged() Handles ucrInputBadTraits.ControlValueChanged
        If ucrInputBadTraits.IsEmpty() Then
            clsCreateTricotData.RemoveParameterByName("bad_suffixes")
        Else
            clsCreateTricotData.AddParameter("bad_suffixes", Chr(34) & ucrInputBadTraits.GetText & Chr(34))
        End If
    End Sub

    Private Sub ucrInputNAS_NameChanged() Handles ucrInputNAS.ControlValueChanged
        If ucrInputNAS.IsEmpty() Then
            clsCreateTricotData.RemoveParameterByName("na_candidates")
        Else
            clsCreateTricotData.AddParameter("na_candidates", Chr(34) & ucrInputNAS.GetText & Chr(34))
        End If
    End Sub

    Private Sub ucrIDReceivers_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverIDVariable.ControlValueChanged, ucrReceiverIDVarietyLevel.ControlValueChanged, ucrReceiverTraitID.ControlValueChanged
        FilledIDReceivers()
    End Sub

    Private Sub ucrVarietyReceivers_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariety.ControlValueChanged, ucrReceiverIDVarietyLevel.ControlValueChanged, ucrReceiverTraitsVariety.ControlValueChanged
        FilledVarietyReceivers()
    End Sub

    Private Sub ucrTraitReceivers_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverTraits1.ControlValueChanged
        FilledTraitReceivers()
    End Sub

    Private Sub ucrSelectorTricotIDLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTricotIDLevel.ControlValueChanged
        AutoFillReceivers(ucrSelectorTricotIDLevel, lstReceiversLevelID)
    End Sub

    Private Sub ucrSelectorTricotVarietyLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTricotVarietyLevel.ControlValueChanged
        AutoFillReceivers(ucrSelectorTricotVarietyLevel, lstReceiversVarietyLevel)
    End Sub

    Private Sub ucrSelectorIDVarietyLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorIDVarietyLevel.ControlValueChanged
        AutoFillReceivers(ucrSelectorIDVarietyLevel, lstReceiversIDVarietyLevel)
    End Sub

    Private Sub ucrSelectorIDVarTraitLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorIDVarTraitLevel.ControlValueChanged
        AutoFillReceivers(ucrSelectorIDVarTraitLevel, lstReceiversIDVarietyTraitLevel)
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
            Else
                clsIDColsFunction.RemoveParameterByName("trait_cols_a")
            End If
        Else
            clsTraitColsFunction.AddParameter("trait_1", Chr(34) & "trait" & Chr(34), bIncludeArgumentName:=False)
            clsTraitColsFunction.AddParameter("trait_2", Chr(34) & "traits" & Chr(34), bIncludeArgumentName:=False)
        End If
    End Sub

    ' TODO: Want receivers to autofill
    Private Sub tbOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbOptions.SelectedIndexChanged
        Select Case tbOptions.SelectedTab.Name
            Case "tbIDLevel"
                ucrReceiverIDVariable.SetMeAsReceiver()
                AutoFillReceivers(ucrSelectorTricotIDLevel, lstReceiversLevelID)
            Case "tbVarietyLevel"
                ucrReceiverVariety.SetMeAsReceiver()
                AutoFillReceivers(ucrSelectorTricotVarietyLevel, lstReceiversVarietyLevel)
            Case "tbIDVarietyLevel"
                ucrReceiverIDVarietyLevel.SetMeAsReceiver()
                AutoFillReceivers(ucrSelectorIDVarietyLevel, lstReceiversIDVarietyLevel)
            Case "tbIDVarietyTraitLevel"
                ucrReceiverTraitID.SetMeAsReceiver()
                AutoFillReceivers(ucrSelectorIDVarTraitLevel, lstReceiversIDVarietyTraitLevel)
        End Select
    End Sub

    Private Sub AutoFillReceivers(sender As ucrSelectorByDataFrameAddRemove, lstReceivers As List(Of ucrReceiverSingle))
        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        If lstReceivers.Count = 0 Then
            Exit Sub
        End If

        ucrCurrentReceiver = sender.CurrentReceiver
        Dim strData As String = sender.strCurrentDataFrame
        For Each ucrTempReceiver As ucrReceiver In lstReceivers
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValues(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In sender.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]|_", String.Empty).Contains(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, strData)
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
    End Sub

    Private Sub SetRSelector(sender As ucrSelectorByDataFrameAddRemove, lstReceivers As List(Of ucrReceiverSingle))
        Dim ucrTempReceiver As ucrReceiver
        For Each ucrTempReceiver In lstReceivers
            ucrTempReceiver.SetParameter(New RParameter(ucrTempReceiver.Tag))
            ucrTempReceiver.Selector = sender
            ucrTempReceiver.SetParameterIsString()
            ucrTempReceiver.bExcludeFromSelector = True
        Next
    End Sub

    Private Function GetRecognisedValues(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function
End Class