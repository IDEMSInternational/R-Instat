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

Public Class sdgDoyRange
    Private clsDoyFilterCalc As RFunction
    Private clsCalcFromList As RFunction
    Private clsCalcFromMainDataFrame As RFunction
    Private clsDayFromOperator As ROperator
    Private clsDayToOperator As ROperator
    Private bControlsInitialised As Boolean = False
    Private strMainDataFrame As String
    Private strDoyColumn As String
    Private bUpdate As Boolean = True

    Private Sub sdgDoyRange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub Setup(clsNewDoyFilterCalc As RFunction, clsNewDayFromOperator As ROperator, clsNewDayToOperator As ROperator, clsNewCalcFromList As RFunction, strNewMainDataFrame As String, strNewDoyColumn As String)
        Dim iFrom As Integer
        Dim iTo As Integer
        Dim iDiff As Integer
        Dim clsFromParam As RParameter
        Dim clsToParam As RParameter
        Dim strDataFrameName As String = ""
        Dim expTemp As SymbolicExpression
        Dim chrTemp As CharacterVector
        Dim numTemp As NumericVector
        Dim clsFindDfFunc As New RFunction
        Dim clsFixedDiffOp As ROperator
        Dim clsDiffParam As RParameter
        Dim clsGetStartDay As New RFunction
        Dim iNewStartDay As Integer

        If Not bControlsInitialised Then
            bUpdate = False
            InitialiseControls()
            bUpdate = True
        End If
        clsDoyFilterCalc = clsNewDoyFilterCalc
        clsCalcFromList = clsNewCalcFromList
        strMainDataFrame = strNewMainDataFrame
        strDoyColumn = strNewDoyColumn

        ucrSelectorDoy.SetPrimaryDataFrameOptions(strMainDataFrame, True, True)

        clsFindDfFunc.SetRCommand("find_df_from_calc_from")
        clsFindDfFunc.AddParameter("x", clsRFunctionParameter:=clsCalcFromList, iPosition:=0)

        clsGetStartDay.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetStartDay.AddParameter("data_name", Chr(34) & strMainDataFrame & Chr(34), iPosition:=0)
        clsGetStartDay.AddParameter("column", Chr(34) & strDoyColumn & Chr(34), iPosition:=1)
        clsGetStartDay.AddParameter("property", "doy_start_label", iPosition:=2)
        clsGetStartDay.AddParameter("error_if_no_property", "FALSE", iPosition:=3)

        expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetStartDay.ToScript(), bSilent:=True, bShowWaitDialogOverride:=False)
        If expTemp IsNot Nothing AndAlso expTemp.Type = Internals.SymbolicExpressionType.NumericVector Then
            numTemp = expTemp.AsNumeric()
            If numTemp.Count > 0 Then
                If Integer.TryParse(numTemp(0), iNewStartDay) Then
                    ucrDoyFrom.SetStartDay(iNewStartDay)
                    ucrDoyTo.SetStartDay(iNewStartDay)
                Else
                    ucrDoyFrom.SetStartDay(1)
                    ucrDoyTo.SetStartDay(1)
                End If
            Else
                ucrDoyFrom.SetStartDay(1)
                ucrDoyTo.SetStartDay(1)
            End If
        Else
            ucrDoyFrom.SetStartDay(1)
            ucrDoyTo.SetStartDay(1)
        End If

        clsDayFromOperator = clsNewDayFromOperator
        clsFromParam = clsDayFromOperator.GetParameter("from")
        bUpdate = False
        If clsFromParam IsNot Nothing Then
            If clsFromParam.bIsString AndAlso clsFromParam.strArgumentValue IsNot Nothing Then
                If Integer.TryParse(clsFromParam.strArgumentValue, iFrom) Then
                    rdoFromFixed.Checked = True
                    ucrDoyFrom.SetValue(iFrom)
                Else
                    clsFindDfFunc.AddParameter("column", strParameterValue:=Chr(34) & clsFromParam.strArgumentValue & Chr(34), iPosition:=1)
                    expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsFindDfFunc.ToScript(), bSilent:=True, bShowWaitDialogOverride:=False)
                    If expTemp IsNot Nothing AndAlso expTemp.Type = Internals.SymbolicExpressionType.CharacterVector Then
                        chrTemp = expTemp.AsCharacter
                        If chrTemp.Count > 0 Then
                            strDataFrameName = chrTemp(0)
                        End If
                    End If
                    rdoFromVariable.Checked = True
                    ucrReceiverFrom.Add(clsFromParam.strArgumentValue, strDataFrameName, False)
                End If
            End If
        End If

        bUpdate = True
        clsDayToOperator = clsNewDayToOperator
        clsToParam = clsDayToOperator.GetParameter("to")
        If clsToParam IsNot Nothing Then
            If clsToParam.bIsString AndAlso clsToParam.strArgumentValue IsNot Nothing Then
                If Integer.TryParse(clsToParam.strArgumentValue, iTo) Then
                    rdoToFixed.Checked = True
                    ucrDoyTo.SetValue(iTo)
                Else
                    clsFindDfFunc.AddParameter("column", strParameterValue:=clsToParam.strArgumentValue, iPosition:=1)
                    expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsFindDfFunc.ToScript(), bSilent:=True, bShowWaitDialogOverride:=False)
                    If expTemp IsNot Nothing AndAlso expTemp.Type = Internals.SymbolicExpressionType.CharacterVector Then
                        chrTemp = expTemp.AsCharacter
                        If chrTemp.Count > 0 Then
                            strDataFrameName = chrTemp(0)
                        End If
                    End If
                    rdoToVariable.Checked = True
                    ucrReceiverTo.Add(clsToParam.strArgumentValue, strDataFrameName, False)
                End If
            ElseIf clsToParam.bIsOperator AndAlso clsToParam.clsArgumentCodeStructure IsNot Nothing Then
                clsFixedDiffOp = TryCast(clsToParam.clsArgumentCodeStructure, ROperator)
                If clsFixedDiffOp IsNot Nothing Then
                    clsDiffParam = clsFixedDiffOp.GetParameter("diff")
                    If clsDiffParam.bIsString AndAlso clsDiffParam.strArgumentValue IsNot Nothing Then
                        If Integer.TryParse(clsDiffParam.strArgumentValue, iDiff) Then
                            rdoLength.Checked = True
                            ucrNudToDiff.SetToValue(iDiff)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub InitialiseControls()
        ucrNudToDiff.SetMinMax(1, 366)
        ucrNudToDiff.SetLinkedDisplayControl(lblToPlus)

        ucrPnlFrom.AddRadioButton(rdoFromFixed)
        ucrPnlFrom.AddRadioButton(rdoFromVariable)
        ucrPnlFrom.AddToLinkedControls(ucrDoyFrom, {rdoFromFixed}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrom.AddToLinkedControls(ucrReceiverFrom, {rdoFromVariable}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlTo.AddRadioButton(rdoToFixed)
        ucrPnlTo.AddRadioButton(rdoToVariable)
        ucrPnlTo.AddRadioButton(rdoLength)
        ucrPnlTo.AddToLinkedControls(ucrDoyTo, {rdoToFixed}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTo.AddToLinkedControls(ucrReceiverTo, {rdoToVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTo.AddToLinkedControls(ucrNudToDiff, {rdoLength}, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverFrom.Selector = ucrSelectorDoy
        'Strict because we only want numeric/integer, not Dates etc.
        ucrReceiverFrom.SetIncludedDataTypes({"numeric"}, bStrict:=True)
        ucrReceiverFrom.strSelectorHeading = "Numerics"

        ucrReceiverTo.Selector = ucrSelectorDoy
        ucrReceiverTo.SetIncludedDataTypes({"numeric"}, bStrict:=True)
        ucrReceiverTo.strSelectorHeading = "Numerics"

        ucrDoyFrom.SetParameterIsNumber()
        ucrDoyTo.SetParameterIsNumber()

        bControlsInitialised = True
        ucrSelectorDoy.Reset()
    End Sub

    Private Sub Fromrdo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFromFixed.CheckedChanged, rdoFromVariable.CheckedChanged
        UpdateFromValues()
        If rdoFromVariable.Checked Then
            ucrReceiverFrom.SetMeAsReceiver()
        End If
        SetSelectorVisible()
    End Sub

    Private Sub SetSelectorVisible()
        ucrSelectorDoy.Visible = (rdoFromVariable.Checked OrElse rdoToVariable.Checked)
    End Sub

    Private Sub UpdateFromValues()
        If bUpdate Then
            If rdoFromFixed.Checked Then
                clsDayFromOperator.AddParameter("from", strParameterValue:=ucrDoyFrom.GetValue(), iPosition:=1)
            ElseIf rdoFromVariable.Checked Then
                clsDayFromOperator.AddParameter("from", strParameterValue:=ucrReceiverFrom.GetVariableNames(False), iPosition:=1)
            End If
            UpdateCalculatedFrom()
        End If
    End Sub

    Private Sub Tordo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoToFixed.CheckedChanged, rdoToVariable.CheckedChanged, rdoLength.CheckedChanged
        UpdateToValues()
        If rdoToVariable.Checked Then
            ucrReceiverTo.SetMeAsReceiver()
        End If
        lblToDays.Visible = rdoLength.Checked
        SetSelectorVisible()
    End Sub

    Public Sub UpdateToValues()
        Dim clsFixedDiffOp As New ROperator

        If bUpdate Then
            If rdoToFixed.Checked Then
                clsDayToOperator.AddParameter("to", strParameterValue:=ucrDoyTo.GetValue(), iPosition:=1)
            ElseIf rdoToVariable.Checked Then
                clsDayToOperator.AddParameter("to", strParameterValue:=ucrReceiverTo.GetVariableNames(False), iPosition:=1)
            ElseIf rdoLength.Checked Then
                clsFixedDiffOp.SetOperation("+")
                If clsDayFromOperator.ContainsParameter("from") Then
                    clsFixedDiffOp.AddParameter("value", strParameterValue:=clsDayFromOperator.GetParameter("from").strArgumentValue, iPosition:=0)
                    clsFixedDiffOp.AddParameter("diff", strParameterValue:=ucrNudToDiff.Value, iPosition:=1)
                    clsFixedDiffOp.bBrackets = True
                    clsDayToOperator.AddParameter("to", clsROperatorParameter:=clsFixedDiffOp, iPosition:=1)
                End If
            End If
            UpdateCalculatedFrom()
        End If
    End Sub

    Private Sub UpdateCalculatedFrom()
        Dim clsCList As New RFunction

        If bUpdate Then
            clsCalcFromList.ClearParameters()
            clsCalcFromList.AddParameter(strMainDataFrame, Chr(34) & strDoyColumn & Chr(34), iPosition:=0)
            If rdoFromVariable.Checked OrElse rdoToVariable.Checked Then
                clsCList.SetRCommand("c")
                If rdoFromVariable.Checked Then
                    clsCList.AddParameter("0", ucrReceiverFrom.GetVariableNames(), iPosition:=0, bIncludeArgumentName:=False)
                End If
                If rdoToVariable.Checked Then
                    clsCList.AddParameter("1", ucrReceiverTo.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)
                End If
                clsCalcFromList.AddParameter(ucrSelectorDoy.ucrAvailableDataFrames.cboAvailableDataFrames.Text, clsRFunctionParameter:=clsCList, iPosition:=1)
            End If
        End If
    End Sub

    Private Sub ToControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDoyTo.ControlValueChanged, ucrNudToDiff.ControlValueChanged, ucrReceiverTo.ControlValueChanged
        UpdateToValues()
    End Sub

    Private Sub FromControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDoyFrom.ControlValueChanged, ucrReceiverFrom.ControlValueChanged
        UpdateFromValues()
        UpdateToValues()
    End Sub
End Class
