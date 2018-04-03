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

    Private Sub sdgDoyRange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub Setup(clsNewDoyFilterCalc As RFunction, clsNewDayFromOperator As ROperator, clsNewDayToOperator As ROperator, clsNewCalcFromList As RFunction, strNewMainDataFrame As String)
        Dim iFrom As Integer
        Dim iTo As Integer
        Dim iDiff As Integer
        Dim clsFromParam As RParameter
        Dim clsToParam As RParameter
        Dim strDataFrameName As String = ""
        Dim expTemp As SymbolicExpression
        Dim chrTemp As CharacterVector
        Dim clsFindDfFunc As New RFunction
        Dim clsFixedDiffOp As ROperator
        Dim clsDiffParam As RParameter

        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsDoyFilterCalc = clsNewDoyFilterCalc
        clsDayFromOperator = clsNewDayFromOperator
        clsDayToOperator = clsNewDayToOperator
        clsCalcFromList = clsNewCalcFromList
        strMainDataFrame = strNewMainDataFrame

        clsFindDfFunc.SetRCommand("find_df_from_calc_from")
        clsFindDfFunc.AddParameter("x", clsRFunctionParameter:=clsCalcFromList, iPosition:=0)

        clsFromParam = clsDayFromOperator.GetParameter("from")
        If clsFromParam IsNot Nothing Then
            If clsFromParam.bIsString AndAlso clsFromParam.strArgumentValue IsNot Nothing Then
                If Integer.TryParse(clsFromParam.strArgumentValue, iFrom) Then
                    rdoFromFixed.Checked = True
                    ucrDoyFrom.SetValue(iFrom)
                Else
                    clsFindDfFunc.AddParameter("column", strParameterValue:=clsFromParam.strArgumentValue, iPosition:=1)
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

        clsToParam = clsDayFromOperator.GetParameter("to")
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
                    ucrReceiverTo.Add(clsFromParam.strArgumentValue, strDataFrameName, False)
                End If
            ElseIf clsToParam.bIsOperator AndAlso clsToParam.clsArgumentCodeStructure IsNot Nothing Then
                clsFixedDiffOp = TryCast(clsToParam.clsArgumentCodeStructure, ROperator)
                If clsFixedDiffOp IsNot Nothing Then
                    clsDiffParam = clsFixedDiffOp.GetParameter("diff")
                    If clsDiffParam.bIsString AndAlso clsDiffParam.strArgumentValue IsNot Nothing Then
                        If Integer.TryParse(clsDiffParam.strArgumentValue, iDiff) Then
                            rdoToFixedDiff.Checked = True
                            ucrNudToDiff.SetToValue(iDiff)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub InitialiseControls()
        ucrNudToDiff.SetMinMax(1, 366)
        ucrNudToDiff.SetLinkedDisplayControl(lblToDiff)

        ucrPnlFrom.AddRadioButton(rdoFromFixed)
        ucrPnlFrom.AddRadioButton(rdoFromVariable)
        ucrPnlFrom.AddToLinkedControls(ucrDoyFrom, {rdoFromFixed}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrom.AddToLinkedControls(ucrReceiverFrom, {rdoFromVariable}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlTo.AddRadioButton(rdoToFixed)
        ucrPnlTo.AddRadioButton(rdoToVariable)
        ucrPnlTo.AddRadioButton(rdoToFixedDiff)
        ucrPnlTo.AddToLinkedControls(ucrDoyFrom, {rdoToFixed}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTo.AddToLinkedControls(ucrReceiverTo, {rdoToVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTo.AddToLinkedControls(ucrNudToDiff, {rdoToFixedDiff}, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverFrom.Selector = ucrSelectorDoy
        ucrReceiverTo.Selector = ucrSelectorDoy

        ucrDoyFrom.SetParameterIsNumber()
        ucrDoyTo.SetParameterIsNumber()

        bControlsInitialised = True
    End Sub

    Private Sub Fromrdo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFromFixed.CheckedChanged, rdoFromVariable.CheckedChanged
        If rdoFromFixed.Checked Then
            clsDayFromOperator.AddParameter("from", strParameterValue:=ucrDoyFrom.GetValue(), iPosition:=1)
        ElseIf rdoFromVariable.Checked Then
            clsDayFromOperator.AddParameter("from", strParameterValue:=ucrReceiverFrom.GetVariableNames(), iPosition:=1)
        End If
    End Sub

    Private Sub UpdateCalculatedFrom()
        Dim clsCList As New RFunction

        clsCList.SetRCommand("c")
        clsCalcFromList.ClearParameters()
        clsCalcFromList.AddParameter(strMainDataFrame, clsRFunctionParameter:=clsCalcFromMainDataFrame, iPosition:=0)
        If rdoFromVariable.Checked OrElse rdoToVariable.Checked Then
            If rdoFromVariable.Checked Then
                clsCList.AddParameter("0", ucrReceiverFrom.GetVariableNames(), iPosition:=0, bIncludeArgumentName:=False)
            End If
            If rdoToVariable.Checked Then
                clsCList.AddParameter("1", ucrReceiverTo.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)
            End If
            clsCalcFromList.AddParameter(ucrSelectorDoy.ucrAvailableDataFrames.cboAvailableDataFrames.Text, clsRFunctionParameter:=clsCList, iPosition:=1)
        End If
    End Sub
End Class