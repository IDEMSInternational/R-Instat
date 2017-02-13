' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat
Imports instat.Translations
'Imports RDotNet

Public Class dlgReplace
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
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

        ' Want:  InstatDataObject$replace_value_in_data(old_value= 1, new_value=2, data_name="Damango", col_names="Year")
        ' Want:  InstatDataObject$replace_value_in_data(col_names= "Year", old_value=2, new_value = NA, data_name="Damango")
        ' Want:  InstatDataObject$replace_value_in_data(data_name= "Damango", col_names="Year", end_value="200", start_value="12", new_value="NA")

        'For interval:
        ' Got:
        ' InstatDataObject$replace_value_in_data(data_name = "Blocking", col_names = "x1", closed_end_value = True, end_value = "1", new_value = 2,start_value = "0", old_value = 3)
        ' need to not have old_value in it
        ' need to not have "" around end_value, start_value (the intervals)
        ' want:
        ' InstatDataObject$replace_value_in_data(data_name = "Blocking", col_names = "x1", closed_end_value = TRUE, end_value=1,      new_value=3, start_value=0)
        rdoNewFromAbove.Enabled = False

        '' Old:
        ucrPnlOld.AddRadioButton(rdoOldValue)
        ucrPnlOld.AddRadioButton(rdoOldMissing)
        ucrPnlOld.AddRadioButton(rdoOldInterval)

        'ucrPnlOld.AddParameterPresentCondition(rdoOldValue, "old_value")
        ucrPnlOld.AddParameterValuesCondition(rdoOldValue, "old_value", "NA", bNewIsPositive:=False)
        'ucrPnlOld.AddParameterPresentCondition(rdoOldMissing, "old_value")
        ucrPnlOld.AddParameterValuesCondition(rdoOldMissing, "old_value", "NA")
        ucrPnlOld.AddParameterPresentCondition(rdoOldInterval, "start_value")
        ucrPnlOld.AddParameterPresentCondition(rdoOldInterval, "end_value")

        ucrPnlOld.AddToLinkedControls(ucrInputOldValue, {rdoOldValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOld.AddToLinkedControls(ucrInputRangeFrom, {rdoOldInterval}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOld.AddToLinkedControls(ucrInputRangeTo, {rdoOldInterval}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOld.AddToLinkedControls(ucrChkMin, {rdoOldInterval}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOld.AddToLinkedControls(ucrChkMax, {rdoOldInterval}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrInputOldValue
        ucrInputOldValue.SetParameter(New RParameter("old_value"))
        ucrInputOldValue.SetName("1")
        ucrInputOldValue.bAddRemoveParameter = False

        'ucrInputRangeFrom
        ucrInputRangeFrom.SetParameter(New RParameter("start_value"))
        ' no quotation marks for this '
        ucrInputRangeFrom.SetName("0")
        ucrInputRangeFrom.bChangeParameterValue = False
        ucrInputRangeFrom.SetLinkedDisplayControl(lblRangeMin)

        ucrChkMin.SetParameter(New RParameter("closed_start_value"))
        ucrChkMin.SetText("Including")
        ucrChkMin.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMin.bAddRemoveParameter = False
        ucrChkMin.SetRDefault("FALSE")

        'ucrInputRangeTo
        ucrInputRangeTo.SetParameter(New RParameter("end_value"))
        ucrInputRangeTo.SetName("1")
        ucrInputRangeTo.bChangeParameterValue = False
        ucrInputRangeTo.SetLinkedDisplayControl(lblRangeMax)

        ucrChkMax.SetParameter(New RParameter("closed_end_value"))
        ucrChkMax.SetText("Including")
        ucrChkMax.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMax.bAddRemoveParameter = False
        ucrChkMax.SetRDefault("FALSE")


        '' NEW VALUES:
        ucrPnlNew.AddRadioButton(rdoNewValue)
        ucrPnlNew.AddRadioButton(rdoNewMissing)
        ucrPnlNew.AddRadioButton(rdoNewFromAbove)

        '        ucrPnlNew.AddParameterPresentCondition(rdoNewValue, "new_value")
        ucrPnlNew.AddParameterValuesCondition(rdoNewValue, "new_value", "NA", bNewIsPositive:=False)
        '        ucrPnlNew.AddParameterPresentCondition(rdoNewMissing, "new_value")
        ucrPnlNew.AddParameterValuesCondition(rdoNewMissing, "new_value", "NA")
        ucrPnlNew.AddParameterPresentCondition(rdoNewFromAbove, " ")

        ucrPnlNew.AddToLinkedControls(ucrInputNewValue, {rdoNewValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ''ucrInputNewValue
        ucrInputNewValue.SetParameter(New RParameter("new_value"))
        ucrInputNewValue.SetName("1")
        ucrInputNewValue.bAddRemoveParameter = False
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrSelectorReplace.Reset()
        EnableRange()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$replace_value_in_data")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverReplace.IsEmpty()) Then
            '           If (rdoOldValue.Checked AndAlso ucrInputOldValue.IsEmpty()) OrElse (rdoRange.Checked AndAlso ucrInputRangeFrom.IsEmpty() AndAlso ucrInputRangeTo.IsEmpty()) OrElse (rdoNewValue.Checked AndAlso ucrInputNewValue.IsEmpty()) Then
            '           ucrBase.OKEnabled(False)
            '       Else
            ucrBase.OKEnabled(True)
            '           End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBaseReplace_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlOld_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOld.ControlContentsChanged
        If rdoOldValue.Checked Then
            ucrBase.clsRsyntax.RemoveParameter("old_value")
            ucrBase.clsRsyntax.RemoveParameter("start_value")
            ucrBase.clsRsyntax.RemoveParameter("end_value")
            InputOldValue()
        ElseIf rdoOldMissing.Checked Then
            ucrBase.clsRsyntax.RemoveParameter("start_value")
            ucrBase.clsRsyntax.RemoveParameter("end_value")
            ucrBase.clsRsyntax.RemoveParameter("old_value")
            ucrBase.clsRsyntax.AddParameter("old_value", "NA")
        Else
            ucrBase.clsRsyntax.RemoveParameter("old_value")
            ucrBase.clsRsyntax.RemoveParameter("start_value")
            ucrBase.clsRsyntax.RemoveParameter("end_value")
            ucrBase.clsRsyntax.AddParameter("start_value", ucrInputNewValue.GetText())
            ucrBase.clsRsyntax.AddParameter("end_value", ucrInputNewValue.GetText())
        End If
    End Sub

    Private Sub InputOldValue()
        Dim strVarType As String

        If ucrInputOldValue.IsEmpty() Then
            ucrBase.clsRsyntax.RemoveParameter("old_value")
        Else
            If Not ucrReceiverReplace.IsEmpty Then
                strVarType = ucrReceiverReplace.GetCurrentItemTypes(True)(0)
            Else
                strVarType = ""
            End If
            If (strVarType = "numeric" OrElse strVarType = "integer") Then
                ucrBase.clsRsyntax.RemoveParameter("old_value")
                ucrBase.clsRsyntax.AddParameter("old_value", ucrInputOldValue.GetText)
            Else
                ucrBase.clsRsyntax.RemoveParameter("old_value")
                ucrBase.clsRsyntax.AddParameter("old_value", Chr(34) & ucrInputOldValue.GetText() & Chr(34))
            End If
        End If
    End Sub

    Private Sub ucrPnlNew_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlNew.ControlContentsChanged
        If rdoNewValue.Checked Then
            ucrBase.clsRsyntax.RemoveParameter("new_value")
            InputNewValue()
        ElseIf rdoNewMissing.Checked Then
            ucrBase.clsRsyntax.RemoveParameter("new_value")
            ucrBase.clsRsyntax.AddParameter("new_value", "NA")
        End If
    End Sub

    Private Sub InputNewValue()
        Dim strVarType As String

        If ucrInputNewValue.IsEmpty() Then
            ucrBase.clsRsyntax.RemoveParameter("new_value")
        Else
            If Not ucrReceiverReplace.IsEmpty Then
                strVarType = ucrReceiverReplace.GetCurrentItemTypes(True)(0)
            Else
                strVarType = ""
            End If

            If (strVarType = "numeric" OrElse strVarType = "integer") Then
                ucrBase.clsRsyntax.RemoveParameter("new_value")
                ucrBase.clsRsyntax.AddParameter("new_value", ucrInputNewValue.GetText())
            Else
                ucrBase.clsRsyntax.RemoveParameter("new_value")
                ucrBase.clsRsyntax.AddParameter("new_value", Chr(34) & ucrInputNewValue.GetText & Chr(34))
            End If
        End If
    End Sub

    Private Sub EnableRange()
        Dim strVarType As String

        If Not ucrReceiverReplace.IsEmpty Then
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
    End Sub

    Private Sub ucrReceiverReplace_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverReplace.ControlContentsChanged, ucrSelectorReplace.ControlContentsChanged, ucrInputOldValue.ControlValueChanged, ucrInputNewValue.ControlValueChanged, ucrInputRangeFrom.ControlValueChanged, ucrInputRangeTo.ControlValueChanged
        EnableRange()
        InputOldValue()
        InputNewValue()
        TestOKEnabled()
    End Sub
End Class