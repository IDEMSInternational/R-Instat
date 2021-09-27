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
Public Class dlgPivotTable
    Private bFirstLoad As Boolean = True
    Private bRcodeSet As Boolean = False
    Private bReset As Boolean = True
    Private clsRPivotTableFunction, clsSelectFunction,
        clsConcatenateFunction, clsGetObjectFunction As New RFunction
    Private clsPipeOperator As New ROperator

    Private Sub dlgPivotTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 417
        ucrBase.clsRsyntax.iCallType = 2

        ucrSelectorPivot.SetParameter(New RParameter("data", iNewPosition:=0))
        ucrSelectorPivot.SetParameterIsrfunction()

        UcrReceiverMultipleIntialRowFactor.SetParameter(New RParameter("rows", iNewPosition:=1))
        UcrReceiverMultipleIntialRowFactor.SetParameterIsString()
        UcrReceiverMultipleIntialRowFactor.Selector = ucrSelectorPivot
        UcrReceiverMultipleIntialRowFactor.SetLinkedDisplayControl(lblInitialColumnFactor)

        ucrReceiverInitialColumnFactor.SetParameter(New RParameter("cols", iNewPosition:=2))
        ucrReceiverInitialColumnFactor.SetParameterIsString()
        ucrReceiverInitialColumnFactor.Selector = ucrSelectorPivot

        ucrReceiverSelectedVariable.Selector = ucrSelectorPivot

        ucrChkSelectedVariable.AddParameterIsRFunctionCondition(False, "data", True)
        ucrChkSelectedVariable.AddParameterIsRFunctionCondition(True, "data", False)

        ucrChkSelectedVariable.SetText("Selected Variable(s)")
        ucrChkSelectedVariable.AddToLinkedControls(ucrReceiverSelectedVariable, {True}, bNewLinkedHideIfParameterMissing:=True)
        ttSelectedVariable.SetToolTip(ucrChkSelectedVariable.chkCheck, "Include the dataframe if unchecked")

        ucrChkIncludeSubTotals.SetText("Subtotals")
        ucrChkIncludeSubTotals.SetParameter(New RParameter("subtotals", iNewPosition:=3))
        ucrChkIncludeSubTotals.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkIncludeSubTotals.SetRDefault("FALSE")

        ucrSavePivot.SetPrefix("pivot_table")
        ucrSavePivot.SetSaveTypeAsTable()
        ucrSavePivot.SetDataFrameSelector(ucrSelectorPivot.ucrAvailableDataFrames)
        ucrSavePivot.SetIsComboBox()
        ucrSavePivot.SetCheckBoxText("Save Table")
        ucrSavePivot.SetAssignToIfUncheckedValue("last_table")
    End Sub

    Private Sub SetDefaults()
        clsRPivotTableFunction = New RFunction
        clsSelectFunction = New RFunction
        clsConcatenateFunction = New RFunction
        clsPipeOperator = New ROperator
        clsGetObjectFunction = New RFunction

        UcrReceiverMultipleIntialRowFactor.SetMeAsReceiver()
        ucrSelectorPivot.Reset()
        ucrSavePivot.Reset()
        ucrBase.clsRsyntax.ClearCodes()

        clsGetObjectFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_objects")
        clsGetObjectFunction.AddParameter("data_name", Chr(34) & ucrSelectorPivot.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("columns", clsRFunctionParameter:=clsSelectFunction, iPosition:=1)
        clsPipeOperator.SetAssignTo("data_selected")

        clsRPivotTableFunction.SetPackageName("rpivotTable")
        clsRPivotTableFunction.SetRCommand("rpivotTable")
        clsRPivotTableFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorPivot.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsSelectFunction.SetPackageName("dplyr")
        clsSelectFunction.SetRCommand("select")
        clsSelectFunction.AddParameter("concatenate", clsRFunctionParameter:=clsConcatenateFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsConcatenateFunction.SetRCommand("c")

        ucrBase.clsRsyntax.AddToBeforeCodes(clsRPivotTableFunction, 1)
        ucrBase.clsRsyntax.SetBaseRFunction(clsGetObjectFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRcodeSet = False
        ucrSelectorPivot.SetRCode(clsPipeOperator, bReset)
        ucrReceiverInitialColumnFactor.SetRCode(clsRPivotTableFunction, bReset)
        UcrReceiverMultipleIntialRowFactor.SetRCode(clsRPivotTableFunction, bReset)
        ucrSavePivot.SetRCode(clsRPivotTableFunction, bReset)
        ucrChkSelectedVariable.SetRCode(clsRPivotTableFunction, bReset)
        ucrChkIncludeSubTotals.SetRCode(clsRPivotTableFunction, bReset)
        bRcodeSet = True
    End Sub

    Private Sub TestOkEnabled()
        If ucrSavePivot.IsComplete AndAlso Not String.IsNullOrEmpty(ucrSelectorPivot.ucrAvailableDataFrames.cboAvailableDataFrames.Text) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrChkSelectedVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSelectedVariable.ControlValueChanged
        If ucrChkSelectedVariable.Checked Then
            ucrReceiverSelectedVariable.SetMeAsReceiver()
            ucrBase.clsRsyntax.AddToBeforeCodes(clsPipeOperator, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsPipeOperator)
        End If
        ChangeDataParameterValue()
    End Sub

    Private Sub ucrSelectorPivot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorPivot.ControlValueChanged
        clsGetObjectFunction.AddParameter("data_name", Chr(34) & ucrSelectorPivot.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        ChangeDataParameterValue()
    End Sub

    Private Sub ChangeDataParameterValue()
        If ucrChkSelectedVariable.Checked Then
            clsRPivotTableFunction.AddParameter("data", "data_selected", iPosition:=0)
        Else
            clsRPivotTableFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorPivot.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        End If
    End Sub

    Private Sub ReceiversChanged(ucrChangedControls As ucrCore) Handles ucrReceiverInitialColumnFactor.ControlValueChanged, ucrReceiverSelectedVariable.ControlValueChanged
        If Not bRcodeSet OrElse Not ucrChkSelectedVariable.Checked Then
            Exit Sub
        End If

        clsConcatenateFunction.ClearParameters()
        Dim iCount As Integer = 2
        'To avoid repeating the same column in the c() function eg c("fert"."fert")
        If Not ucrReceiverInitialColumnFactor.IsEmpty AndAlso Not UcrReceiverMultipleIntialRowFactor.IsEmpty Then
            If UcrReceiverMultipleIntialRowFactor.GetVariableNames(bWithQuotes:=False) <> ucrReceiverInitialColumnFactor.GetVariableNames(bWithQuotes:=False) Then
                clsConcatenateFunction.AddParameter("column", ucrReceiverInitialColumnFactor.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=0)
                clsConcatenateFunction.AddParameter("row", UcrReceiverMultipleIntialRowFactor.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=1)
            Else
                clsConcatenateFunction.AddParameter("column", ucrReceiverInitialColumnFactor.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=0)
            End If
        Else
            If Not ucrReceiverInitialColumnFactor.IsEmpty Then
                clsConcatenateFunction.AddParameter("column", ucrReceiverInitialColumnFactor.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=0)
            End If
            If Not UcrReceiverMultipleIntialRowFactor.IsEmpty Then
                clsConcatenateFunction.AddParameter("row", UcrReceiverMultipleIntialRowFactor.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=1)
            End If
        End If
        For Each strItem In ucrReceiverSelectedVariable.GetVariableNamesList(bWithQuotes:=False)
            If strItem <> UcrReceiverMultipleIntialRowFactor.GetVariableNames(bWithQuotes:=False) AndAlso strItem <> ucrReceiverInitialColumnFactor.GetVariableNames(bWithQuotes:=False) Then
                clsConcatenateFunction.AddParameter(strItem, strItem, bIncludeArgumentName:=False, iPosition:=iCount)
                iCount += 1
            End If
        Next
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelectedVariable.ControlContentsChanged,
            ucrReceiverInitialColumnFactor.ControlContentsChanged, ucrChkSelectedVariable.ControlContentsChanged, ucrSavePivot.ControlContentsChanged, ucrSelectorPivot.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSavePivot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSavePivot.ControlValueChanged
        clsGetObjectFunction.AddParameter("object_name", Chr(34) & ucrSavePivot.ucrInputComboSave.GetText & Chr(34), iPosition:=1)
    End Sub
End Class