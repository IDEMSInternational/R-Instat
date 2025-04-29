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


Public Class sdgTransformations
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public clsOutputDataLevel, clsCreateTricotData As New RFunction
    Private ucrBaseSelector As ucrSelector

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

        If bReset Then
            'SetRFunction()
        End If
        'SetRCodeForControls(bReset)
    End Sub

    Private Sub InitialiseDialog()

        ucrPnlTransformations.AddRadioButton(rdoIDLevel)
        ucrPnlTransformations.AddRadioButton(rdoIDVarietyLevel)
        ucrPnlTransformations.AddRadioButton(rdoVarietyLevel)
        ucrPnlTransformations.AddRadioButton(rdoIDVarietyTraitLevel)

        ucrPnlTransformations.AddToLinkedControls({ucrReceiverIDVariable, ucrInputGoodTraits, ucrInputBadTraits, ucrInputNAS}, {rdoIDLevel}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransformations.AddToLinkedControls({ucrReceiverVariety}, {rdoVarietyLevel}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransformations.AddToLinkedControls({ucrReceiverVariety, ucrReceiverIDVariable, ucrReceiverTraits2}, {rdoIDVarietyLevel}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransformations.AddToLinkedControls({ucrReceiverVariety, ucrReceiverIDVariable, ucrReceiverTraits1}, {rdoIDVarietyTraitLevel}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSelectorTricotTransformations.SetParameter(New RParameter("id_level_data", 0))
        ucrSelectorTricotTransformations.SetParameterIsString()

        ucrReceiverIDVariable.SetParameter(New RParameter("id_cols", 1))
        ucrReceiverIDVariable.SetParameterIsString()
        ucrReceiverIDVariable.Selector = ucrSelectorTricotTransformations
        ucrReceiverIDVariable.strSelectorHeading = "ID"
        ucrReceiverIDVariable.SetItemType("column")
        ucrReceiverIDVariable.SetLinkedDisplayControl(lblIDVariable)

        ucrReceiverVariety.SetParameter(New RParameter("variety_cols", 2))
        ucrReceiverVariety.SetParameterIsString()
        ucrReceiverVariety.Selector = ucrSelectorTricotTransformations
        ucrReceiverVariety.strSelectorHeading = "ID"
        ucrReceiverVariety.SetItemType("column")
        ucrReceiverVariety.SetLinkedDisplayControl(lblVariety)

        ucrReceiverTraits1.SetParameter(New RParameter("trait_cols", 3))
        ucrReceiverTraits1.SetParameterIsString()
        ucrReceiverTraits1.Selector = ucrSelectorTricotTransformations
        ucrReceiverTraits1.strSelectorHeading = "ID"
        ucrReceiverTraits1.SetItemType("column")
        ucrReceiverTraits1.SetLinkedDisplayControl(lblTraits)

        ucrReceiverTraits2.SetParameter(New RParameter("trait_cols", 4))
        ucrReceiverTraits2.SetParameterIsString()
        ucrReceiverTraits2.Selector = ucrSelectorTricotTransformations
        ucrReceiverTraits2.strSelectorHeading = "ID"
        ucrReceiverTraits2.SetItemType("column")
        ucrReceiverTraits2.SetLinkedDisplayControl(lblTraits2)

        ucrInputGoodTraits.SetItems({strPos, strBest})
        ucrInputGoodTraits.SetDropDownStyleAsNonEditable()
        ucrInputGoodTraits.SetLinkedDisplayControl(lblGoodTraits)
        ucrInputGoodTraits.SetParameter(New RParameter("good_suffixes", 5))

        ucrInputBadTraits.SetItems({strNeg, strWorst})
        ucrInputBadTraits.SetDropDownStyleAsNonEditable()
        ucrInputBadTraits.SetLinkedDisplayControl(lblBadTraits)
        ucrInputBadTraits.SetParameter(New RParameter("bad_suffixes", 6))

        ucrInputNAS.SetItems({strNot, strMissing, strNA})
        ucrInputNAS.SetDropDownStyleAsNonEditable()
        ucrInputNAS.SetLinkedDisplayControl(lblNAs)
        ucrInputNAS.SetParameter(New RParameter("na_candidates", 7))

    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, clsNewDefaultFunction As RFunction, Optional ucrNewBaseSelector As ucrSelector = Nothing, Optional bReset As Boolean = False, Optional strDefaultTab As String = "")
        clsOutputDataLevel = clsNewRFunction
        clsCreateTricotData = clsNewDefaultFunction
        ucrBaseSelector = ucrNewBaseSelector

        ucrInputGoodTraits.SetText(strPos)
        ucrInputGoodTraits.bUpdateRCodeFromControl = True
        ucrInputBadTraits.SetText(strNeg)
        ucrInputBadTraits.bUpdateRCodeFromControl = True
        ucrInputNAS.SetText(strNot)
        ucrInputNAS.bUpdateRCodeFromControl = True
        ucrReceiverIDVariable.SetMeAsReceiver()

        ucrReceiverIDVariable.SetRCode(clsOutputDataLevel, bReset, bCloneIfNeeded:=True)
        ucrReceiverVariety.SetRCode(clsOutputDataLevel, bReset, bCloneIfNeeded:=True)
        ucrReceiverTraits1.SetRCode(clsOutputDataLevel, bReset, bCloneIfNeeded:=True)
        ucrReceiverTraits2.SetRCode(clsOutputDataLevel, bReset, bCloneIfNeeded:=True)

    End Sub

    Private Sub SetDialogOptions()
        If rdoIDLevel.Checked Then
            ucrReceiverIDVariable.Visible = True
            clsOutputDataLevel.RemoveParameterByName("variety_cols")
            clsOutputDataLevel.RemoveParameterByName("trait_cols")
        ElseIf rdoVarietyLevel.Checked Then
            ucrReceiverVariety.Visible = True
            clsOutputDataLevel.RemoveParameterByName("id_cols")
            clsOutputDataLevel.RemoveParameterByName("trait_cols")
        ElseIf rdoIDVarietyLevel.Checked Then
            ucrReceiverVariety.Visible = True
            ucrReceiverIDVariable.Visible = True
            ucrReceiverTraits2.Visible = True
        ElseIf rdoIDVarietyTraitLevel.Checked Then
            ucrReceiverVariety.Visible = True
            ucrReceiverIDVariable.Visible = True
            ucrReceiverTraits1.Visible = True
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

    Private Sub ucrPnlTransformations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlTransformations.ControlValueChanged, ucrReceiverIDVariable.ControlValueChanged, ucrReceiverVariety.ControlValueChanged, ucrReceiverTraits2.ControlValueChanged,
            ucrReceiverTraits1.ControlValueChanged, ucrInputBadTraits.ControlValueChanged, ucrInputGoodTraits.ControlValueChanged, ucrInputNAS.ControlValueChanged
        SetDialogOptions()
    End Sub
End Class