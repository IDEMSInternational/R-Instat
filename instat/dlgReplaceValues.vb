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

Public Class dlgReplaceValues
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsReplace As New RFunction
    Private strVarType As String = ""

    Private Sub dlgReplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 47

        'ucrSelector
        ucrSelectorReplace.SetParameter(New RParameter("data_name", 0))
        ucrSelectorReplace.SetParameterIsString()

        'ucrReceiver
        ucrReceiverReplace.SetParameter(New RParameter("col_names", 1))
        ucrReceiverReplace.Selector = ucrSelectorReplace
        ucrReceiverReplace.SetMeAsReceiver()
        ucrReceiverReplace.SetSingleTypeStatus(True)
        ucrReceiverReplace.SetParameterIsString()
        ucrReceiverReplace.SetExcludedDataTypes({"Date"})

        'Old Values
        ucrPnlOld.AddRadioButton(rdoOldValue)
        ucrPnlOld.AddRadioButton(rdoOldMissing)
        ucrPnlOld.AddRadioButton(rdoOldInterval)

        ucrPnlOld.AddParameterValuesCondition(rdoOldMissing, "old_is_missing", "TRUE")
        ucrPnlOld.AddParameterPresentCondition(rdoOldValue, "old_is_missing", False)
        ucrPnlOld.AddParameterPresentCondition(rdoOldInterval, "old_is_missing", False)

        ucrPnlOld.AddParameterPresentCondition(rdoOldValue, "old_value")
        ucrPnlOld.AddParameterPresentCondition(rdoOldMissing, "old_value", False)
        ucrPnlOld.AddParameterPresentCondition(rdoOldInterval, "old_value", False)

        ucrPnlOld.AddParameterPresentCondition(rdoOldInterval, "start_value")
        ucrPnlOld.AddParameterPresentCondition(rdoOldMissing, "start_value", False)
        ucrPnlOld.AddParameterPresentCondition(rdoOldValue, "start_value", False)

        ucrPnlOld.AddParameterPresentCondition(rdoOldInterval, "end_value")
        ucrPnlOld.AddParameterPresentCondition(rdoOldMissing, "end_value", False)
        ucrPnlOld.AddParameterPresentCondition(rdoOldValue, "end_value", False)
        'Temp fix otherwise you get a developer error on reopening the dialog when on rdoOldMissing
        ucrPnlOld.bAllowNonConditionValues = True

        ucrPnlOld.AddToLinkedControls(ucrPnlNew, {rdoOldInterval, rdoOldValue, rdoOldMissing}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoNewMissing)
        ucrPnlOld.AddToLinkedControls(ucrInputOldValue, {rdoOldValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlOld.AddToLinkedControls(ucrInputRangeFrom, {rdoOldInterval}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrPnlOld.AddToLinkedControls(ucrInputRangeTo, {rdoOldInterval}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrPnlOld.AddToLinkedControls(ucrChkMin, {rdoOldInterval}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOld.AddToLinkedControls(ucrChkMax, {rdoOldInterval}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrInputOldValue
        ucrInputOldValue.SetParameter(New RParameter("old_value", 3))
        ucrInputOldValue.bAddRemoveParameter = False

        'ucrInputRangeFrom
        ucrInputRangeFrom.SetParameter(New RParameter("start_value", 5))
        ucrInputRangeFrom.AddQuotesIfUnrecognised = False
        ucrInputRangeFrom.bAddRemoveParameter = False
        ucrInputRangeFrom.SetLinkedDisplayControl(lblRangeMin)
        ucrInputRangeFrom.SetRDefault("NA")

        ucrChkMin.SetParameter(New RParameter("closed_start_value", 9))
        ucrChkMin.SetText("Including")
        ucrChkMin.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMin.bAddRemoveParameter = False
        ucrChkMin.SetRDefault("FALSE")

        'ucrInputRangeTo
        ucrInputRangeTo.SetParameter(New RParameter("end_value", 6))
        ucrInputRangeTo.AddQuotesIfUnrecognised = False
        ucrInputRangeTo.bAddRemoveParameter = False
        ucrInputRangeTo.SetLinkedDisplayControl(lblRangeMax)
        ucrInputRangeTo.SetRDefault("NA")

        ucrChkMax.SetParameter(New RParameter("closed_end_value", 10))
        ucrChkMax.SetText("Including")
        ucrChkMax.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMax.bAddRemoveParameter = False
        ucrChkMax.SetRDefault("FALSE")

        ''ucrInputNewValue
        ucrInputNewValue.SetParameter(New RParameter("new_value", 7))
        ucrInputNewValue.bAddRemoveParameter = False

        '' NEW VALUES:
        ucrPnlNew.AddRadioButton(rdoNewFromBelow)
        ucrPnlNew.AddRadioButton(rdoNewFromAbove)
        ucrPnlNew.AddRadioButton(rdoNewValue)
        ucrPnlNew.AddRadioButton(rdoNewMissing)

        ucrPnlNew.AddParameterPresentCondition(rdoNewMissing, "new_value", False)
        ucrPnlNew.AddParameterPresentCondition(rdoNewValue, "new_value")
        ucrPnlNew.AddParameterPresentCondition(rdoNewFromBelow, "new_value", False)
        ucrPnlNew.AddParameterPresentCondition(rdoNewFromAbove, "new_value", False)

        ucrPnlNew.AddParameterValuesCondition(rdoNewMissing, "new_is_missing", "TRUE")
        ucrPnlNew.AddParameterPresentCondition(rdoNewValue, "new_is_missing", False)
        ucrPnlNew.AddParameterPresentCondition(rdoNewFromBelow, "new_is_missing", False)
        ucrPnlNew.AddParameterPresentCondition(rdoNewFromAbove, "new_is_missing", False)

        ucrPnlNew.AddParameterPresentCondition(rdoNewMissing, "from_last", False)
        ucrPnlNew.AddParameterPresentCondition(rdoNewValue, "from_last", False)
        ucrPnlNew.AddParameterValuesCondition(rdoNewFromBelow, "from_last", "TRUE")
        ucrPnlNew.AddParameterValuesCondition(rdoNewFromAbove, "from_last", "FALSE")

        ucrPnlNew.AddParameterPresentCondition(rdoNewValue, "locf", False)
        ucrPnlNew.AddParameterPresentCondition(rdoNewMissing, "locf", False)
        ucrPnlNew.AddParameterPresentCondition(rdoNewFromBelow, "locf")
        ucrPnlNew.AddParameterPresentCondition(rdoNewFromAbove, "locf")

        ucrPnlNew.AddToLinkedControls(ucrInputNewValue, {rdoNewValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)

    End Sub

    Private Sub SetDefaults()
        clsReplace = New RFunction

        ucrSelectorReplace.Reset()
        EnableRange()

        clsReplace.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$replace_value_in_data")
        clsReplace.AddParameter("old_value", "-99", iPosition:=3)
        clsReplace.AddParameter("new_is_missing", "TRUE", iPosition:=8)
        ucrBase.clsRsyntax.SetBaseRFunction(clsReplace)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverReplace.IsEmpty() OrElse (rdoOldInterval.Checked AndAlso (ucrInputRangeFrom.IsEmpty() OrElse ucrInputRangeTo.IsEmpty())) OrElse (rdoOldValue.Checked AndAlso ucrInputOldValue.IsEmpty AndAlso {"numeric", "integer"}.Contains(strVarType)) OrElse (rdoNewValue.Checked AndAlso ucrInputNewValue.IsEmpty AndAlso {"numeric", "integer"}.Contains(strVarType)) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBaseReplace_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub InputValue()
        If Not ucrReceiverReplace.IsEmpty AndAlso ucrReceiverReplace.GetCurrentItemTypes(True).Count > 0 Then
            strVarType = ucrReceiverReplace.GetCurrentItemTypes(True)(0)
            If rdoOldValue.Checked Then
                If (strVarType = "numeric" OrElse strVarType = "integer") Then
                    ucrInputOldValue.AddQuotesIfUnrecognised = False
                Else
                    ucrInputOldValue.AddQuotesIfUnrecognised = True
                End If
                clsReplace.RemoveParameterByName("old_is_missing")

            ElseIf rdoOldMissing.Checked Then
                clsReplace.AddParameter("old_is_missing", "TRUE")
            Else
                clsReplace.RemoveParameterByName("old_is_missing")
            End If
            If rdoNewValue.Checked Then
                If (strVarType = "numeric" OrElse strVarType = "integer") Then
                    ucrInputNewValue.AddQuotesIfUnrecognised = False
                Else
                    ucrInputNewValue.AddQuotesIfUnrecognised = True
                End If
                clsReplace.RemoveParameterByName("new_is_missing")
            ElseIf rdoNewMissing.Checked Then
                clsReplace.AddParameter("new_is_missing", "TRUE")
            Else
                clsReplace.RemoveParameterByName("new_is_missing")
            End If
            If rdoNewFromBelow.Checked OrElse rdoNewFromAbove.Checked Then
                clsReplace.AddParameter("locf", "TRUE")
                clsReplace.RemoveParameterByName("new_is_missing")
                clsReplace.RemoveParameterByName("old_value")
                If rdoNewFromBelow.Checked Then
                    clsReplace.AddParameter("from_last", "TRUE")
                ElseIf rdoNewFromAbove.Checked Then
                    clsReplace.AddParameter("from_last", "FALSE")
                End If
            Else
                clsReplace.RemoveParameterByName("locf")
                clsReplace.RemoveParameterByName("from_last")
            End If
        Else
            strVarType = ""
        End If
    End Sub

    Private Sub EnableRange()
        Dim strVarType As String

        If Not ucrReceiverReplace.IsEmpty AndAlso ucrReceiverReplace.GetCurrentItemTypes(True).Count > 0 Then
            strVarType = ucrReceiverReplace.GetCurrentItemTypes(True)(0)
        Else
            strVarType = ""
        End If
        If strVarType = "" OrElse strVarType = "numeric" OrElse strVarType = "integer" Then
            rdoOldInterval.Enabled = True
        Else
            rdoOldInterval.Enabled = False
        End If

        If rdoOldInterval.Enabled = False Then
            If rdoOldInterval.Checked = True Then
                rdoOldValue.Checked = True
                rdoOldInterval.Checked = False
            End If
        End If
        If rdoOldInterval.Checked OrElse rdoOldValue.Checked Then
            rdoNewFromBelow.Enabled = False
            rdoNewFromAbove.Enabled = False
            rdoNewMissing.Enabled = True
        Else
            rdoNewFromBelow.Enabled = True
            rdoNewFromAbove.Enabled = True
        End If

    End Sub

    Private Sub CheckedRadio()
        If (rdoNewFromAbove.Checked AndAlso rdoNewFromAbove.Enabled = False) OrElse (rdoNewFromBelow.Checked AndAlso rdoNewFromBelow.Enabled = False) Then
            rdoNewMissing.Checked = True
        End If
    End Sub

    Private Sub ucrPnlOld_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOld.ControlValueChanged, ucrPnlNew.ControlValueChanged, ucrInputRangeFrom.ControlContentsChanged, ucrInputRangeTo.ControlContentsChanged
        InputValue()
        EnableRange()
        CheckedRadio()
    End Sub

    Private Sub ucrReceiverReplace_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverReplace.ControlValueChanged
        InputValue()
        EnableRange()
    End Sub

    Private Sub Control_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverReplace.ControlContentsChanged, ucrPnlNew.ControlContentsChanged, ucrPnlOld.ControlContentsChanged, ucrInputNewValue.ControlContentsChanged, ucrInputOldValue.ControlContentsChanged, ucrInputRangeFrom.ControlContentsChanged, ucrInputRangeTo.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class