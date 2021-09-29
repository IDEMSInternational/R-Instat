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
Public Class dlgThreeVariablePivotTable
    Private bFirstLoad As Boolean = True
    Private bRcodeSet As Boolean = False
    Private bReset As Boolean = True
    Private clsRPivotTableFunction, clsSelectFunction, clsRowConcatenateFunction,
        clsConcatenateFunction, clsGetObjectFunction As New RFunction
    Private clsPasteFunction, clsShQuoteFuction, clsSorterPasteFunction, clsAttrFunction,
        clsIfFunction, clsSorterAsFunction, clsLevelFunction, clsGetDataFrameFunction As New RFunction

    Private clsPipeOperator, clsDollarOperator, clsSpaceOperator,
    clsEqualOperator, clsEqualSpaceOperator As New ROperator

    Private Sub dlgThreeVariablePivotTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 603
        ucrBase.clsRsyntax.iCallType = 2


        ucrReceiverInitialRowFactor.SetParameter(New RParameter("col", iNewPosition:=1, bNewIncludeArgumentName:=False))
        ucrReceiverInitialRowFactor.SetParameterIsString()
        ucrReceiverInitialRowFactor.Selector = ucrSelectorPivot

        ucrReceiverInitialColumnFactor.SetParameter(New RParameter("cols", iNewPosition:=2))
        ucrReceiverInitialColumnFactor.SetParameterIsString()
        ucrReceiverInitialColumnFactor.Selector = ucrSelectorPivot

        ucrReceiverSelectedVariable.Selector = ucrSelectorPivot

        ucrReceiverAdditionalRowFactor.SetParameterIsString()
        ucrReceiverAdditionalRowFactor.Selector = ucrSelectorPivot

        ucrChkSelectedVariable.AddParameterIsRFunctionCondition(False, "data", True)
        ucrChkSelectedVariable.AddParameterIsRFunctionCondition(True, "data", False)

        ucrChkSelectedVariable.SetText("Select Variable(s)")
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
        clsPasteFunction = New RFunction
        clsShQuoteFuction = New RFunction
        clsLevelFunction = New RFunction
        clsDollarOperator = New ROperator
        clsRowConcatenateFunction = New RFunction
        clsSorterPasteFunction = New RFunction
        clsAttrFunction = New RFunction
        clsSorterAsFunction = New RFunction
        clsIfFunction = New RFunction
        clsSpaceOperator = New ROperator
        clsEqualOperator = New ROperator
        clsEqualSpaceOperator = New ROperator
        clsGetDataFrameFunction = New RFunction

        ucrReceiverInitialRowFactor.SetMeAsReceiver()
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

        clsRowConcatenateFunction.SetRCommand("c")

        clsPasteFunction.SetRCommand("paste")
        clsPasteFunction.AddParameter("shQoute", clsRFunctionParameter:=clsShQuoteFuction, iPosition:=0, bIncludeArgumentName:=False)
        clsPasteFunction.AddParameter("collapse", Chr(34) & "," & Chr(34), iPosition:=1)
        clsPasteFunction.SetAssignTo("month_levels_given")

        clsShQuoteFuction.SetRCommand("shQuote")
        clsShQuoteFuction.AddParameter("level", clsRFunctionParameter:=clsLevelFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsShQuoteFuction.AddParameter("type", Chr(34) & "cmd" & Chr(34), iPosition:=1)

        clsLevelFunction.SetRCommand("levels")
        clsLevelFunction.AddParameter("dollar", clsROperatorParameter:=clsDollarOperator, bIncludeArgumentName:=False, iPosition:=0)

        clsDollarOperator.SetOperation("$")

        clsSorterPasteFunction.SetRCommand("paste")
        clsSorterPasteFunction.AddParameter("spaceop", clsROperatorParameter:=clsSpaceOperator, iPosition:=0, bIncludeArgumentName:=False)

        clsSpaceOperator.SetOperation("")
        clsSpaceOperator.AddParameter("left qoutes", Chr(34), iPosition:=0)
        clsSpaceOperator.AddParameter("attr", clsRFunctionParameter:=clsAttrFunction, iPosition:=1)
        clsSpaceOperator.AddParameter("rightCurlyBrackets", "{", iPosition:=2)
        clsSpaceOperator.AddParameter("varAsSorter", "var sortAs = $.pivotUtilities.sortAs", iPosition:=3)
        clsSpaceOperator.AddParameter("firstSemiColon", ";", iPosition:=4)
        clsSpaceOperator.AddParameter("if", clsRFunctionParameter:=clsIfFunction, iPosition:=5)
        clsSpaceOperator.AddParameter("secondRightCurlyBrackets", "{", iPosition:=6)
        clsSpaceOperator.AddParameter("return", "return", iPosition:=7)
        clsSpaceOperator.AddParameter("sorter", clsRFunctionParameter:=clsSorterAsFunction, iPosition:=8)
        clsSpaceOperator.AddParameter("secondSemicolon", ";", iPosition:=9)
        clsSpaceOperator.AddParameter("leftCurlyBrackets", "}", iPosition:=10)
        clsSpaceOperator.AddParameter("SecondLeftCurlyBrackets", "}", iPosition:=11)
        clsSpaceOperator.AddParameter("right qoutes", Chr(34), iPosition:=12)


        clsAttrFunction.SetRCommand("function")
        clsAttrFunction.AddParameter("attr", "attr", bIncludeArgumentName:=False, iPosition:=0)

        clsIfFunction.SetRCommand("if")
        clsIfFunction.AddParameter("equal", clsROperatorParameter:=clsEqualOperator, iPosition:=0, bIncludeArgumentName:=False)

        clsEqualOperator.SetOperation("==")
        clsEqualOperator.AddParameter("attr", "attr", iPosition:=0)
        clsEqualOperator.AddParameter("operation", clsROperatorParameter:=clsEqualSpaceOperator, iPosition:=1)


        clsEqualSpaceOperator.SetOperation("")
        clsEqualSpaceOperator.AddParameter("FirstComma", Chr(34) & ", " & Chr(34), iPosition:=0)
        clsEqualSpaceOperator.AddParameter("slashQoute1", "\" & Chr(34), iPosition:=1)
        clsEqualSpaceOperator.AddParameter("slashQoute2", "\" & Chr(34) & Chr(34), iPosition:=3)
        clsEqualSpaceOperator.AddParameter("SecondComma", ", " & Chr(34), iPosition:=4)


        clsSorterAsFunction.SetRCommand("sortAs")
        clsSorterAsFunction.AddParameter("level", "["", month_levels_given,""]", bIncludeArgumentName:=False, iPosition:=0)

        clsGetDataFrameFunction = ucrSelectorPivot.ucrAvailableDataFrames.clsCurrDataFrame

        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataFrameFunction, iPosition:=0)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsRPivotTableFunction, iPosition:=3)
        ucrBase.clsRsyntax.SetBaseRFunction(clsGetObjectFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRcodeSet = False
        ucrReceiverInitialColumnFactor.SetRCode(clsRPivotTableFunction, bReset)
        ucrReceiverInitialRowFactor.SetRCode(clsRowConcatenateFunction, bReset)
        ucrSavePivot.SetRCode(clsRPivotTableFunction, bReset)
        ucrChkSelectedVariable.SetRCode(clsRPivotTableFunction, bReset)
        ucrChkIncludeSubTotals.SetRCode(clsRPivotTableFunction, bReset)
        bRcodeSet = True
    End Sub

    Private Sub TestOkEnabled()
        If ucrSavePivot.IsComplete AndAlso Not ucrReceiverInitialColumnFactor.IsEmpty AndAlso Not ucrReceiverInitialRowFactor.IsEmpty Then
            If ucrChkSelectedVariable.Checked Then
                If Not ucrReceiverSelectedVariable.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            Else
                ucrBase.OKEnabled(True)
            End If
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
            ucrBase.clsRsyntax.AddToBeforeCodes(clsPipeOperator, iPosition:=2)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsPipeOperator)
        End If
        ChangeDataParameterValue()
    End Sub

    Private Sub ucrSelectorPivot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorPivot.ControlValueChanged
        clsGetObjectFunction.AddParameter("data_name", Chr(34) & ucrSelectorPivot.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsDollarOperator.AddParameter("data", ucrSelectorPivot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
        clsGetDataFrameFunction.SetAssignTo(ucrSelectorPivot.ucrAvailableDataFrames.strCurrDataFrame)
        clsPipeOperator.AddParameter("data", ucrSelectorPivot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
        ChangeDataParameterValue()
    End Sub

    Private Sub ChangeDataParameterValue()
        If ucrChkSelectedVariable.Checked Then
            clsRPivotTableFunction.AddParameter("data", "data_selected", iPosition:=0)
        Else
            clsRPivotTableFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorPivot.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        End If
    End Sub

    Private Sub ReceiversChanged(ucrChangedControls As ucrCore) Handles ucrReceiverInitialColumnFactor.ControlValueChanged,
            ucrReceiverInitialRowFactor.ControlValueChanged, ucrReceiverSelectedVariable.ControlValueChanged
        AddRowParameter()

        If Not bRcodeSet OrElse Not ucrChkSelectedVariable.Checked Then
            Exit Sub
        End If

        clsConcatenateFunction.ClearParameters()
        Dim iCount As Integer = 3
        'To avoid repeating the same column in the c() function eg c("fert"."fert")
        If Not ucrReceiverInitialColumnFactor.IsEmpty AndAlso Not ucrReceiverInitialRowFactor.IsEmpty Then
            If ucrReceiverInitialRowFactor.GetVariableNames(bWithQuotes:=False) <> ucrReceiverInitialColumnFactor.GetVariableNames(bWithQuotes:=False) Then
                clsConcatenateFunction.AddParameter("column", ucrReceiverInitialColumnFactor.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=0)
                clsConcatenateFunction.AddParameter("row", ucrReceiverInitialRowFactor.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=1)
            Else
                clsConcatenateFunction.AddParameter("column", ucrReceiverInitialColumnFactor.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=0)
            End If
        Else
            If Not ucrReceiverInitialColumnFactor.IsEmpty Then
                clsConcatenateFunction.AddParameter("column", ucrReceiverInitialColumnFactor.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=0)
            End If
            If Not ucrReceiverInitialRowFactor.IsEmpty Then
                clsConcatenateFunction.AddParameter("row", ucrReceiverInitialRowFactor.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=2)
            End If
        End If

        If Not ucrReceiverAdditionalRowFactor.IsEmpty Then
            If ucrReceiverInitialRowFactor.GetVariableNames(bWithQuotes:=False) <> ucrReceiverAdditionalRowFactor.GetVariableNames(bWithQuotes:=False) AndAlso ucrReceiverInitialColumnFactor.GetVariableNames(bWithQuotes:=False) <> ucrReceiverAdditionalRowFactor.GetVariableNames(bWithQuotes:=False) Then
                clsConcatenateFunction.AddParameter("additionalRow", ucrReceiverAdditionalRowFactor.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=1)
            End If
        End If

        For Each strItem In ucrReceiverSelectedVariable.GetVariableNamesList(bWithQuotes:=False)
            If strItem <> ucrReceiverInitialRowFactor.GetVariableNames(bWithQuotes:=False) AndAlso strItem <> ucrReceiverInitialColumnFactor.GetVariableNames(bWithQuotes:=False) AndAlso strItem <> ucrReceiverAdditionalRowFactor.GetVariableNames(bWithQuotes:=False) Then
                clsConcatenateFunction.AddParameter(strItem, strItem, bIncludeArgumentName:=False, iPosition:=iCount)
                iCount += 1
            End If
        Next
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelectedVariable.ControlContentsChanged,
            ucrReceiverInitialColumnFactor.ControlContentsChanged, ucrReceiverInitialRowFactor.ControlContentsChanged, ucrChkSelectedVariable.ControlContentsChanged, ucrSavePivot.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSavePivot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSavePivot.ControlValueChanged
        clsGetObjectFunction.AddParameter("object_name", Chr(34) & ucrSavePivot.ucrInputComboSave.GetText & Chr(34), iPosition:=1)
    End Sub

    Private Sub ucrReceiverAdditionalRowFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverAdditionalRowFactor.ControlValueChanged
        If Not ucrReceiverAdditionalRowFactor.IsEmpty Then
            clsRPivotTableFunction.AddParameter("rows", clsRFunctionParameter:=clsRowConcatenateFunction, iPosition:=2)
            If ucrReceiverAdditionalRowFactor.strCurrDataType = "factor" Then
                ucrBase.clsRsyntax.AddToBeforeCodes(clsPasteFunction, iPosition:=2)
                clsRowConcatenateFunction.AddParameter("column2", ucrReceiverAdditionalRowFactor.GetVariableNames(), bIncludeArgumentName:=False, iPosition:=1)
                clsEqualSpaceOperator.AddParameter("factor", ucrReceiverAdditionalRowFactor.GetVariableNames(False), iPosition:=2)
                clsDollarOperator.AddParameter("column", ucrReceiverAdditionalRowFactor.GetVariableNames(False), iPosition:=1)
                clsRPivotTableFunction.AddParameter("sorters", clsRFunctionParameter:=clsSorterPasteFunction, iPosition:=3)
            Else
                clsRPivotTableFunction.RemoveParameterByName("sorters")
                ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsPasteFunction)
            End If
        Else
            clsRPivotTableFunction.RemoveParameterByName("sorters")
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsPasteFunction)
            AddRowParameter()
        End If
    End Sub

    Private Sub AddRowParameter()
        If ucrReceiverInitialRowFactor.IsEmpty Then
            clsRPivotTableFunction.RemoveParameterByName("rows")
        Else
            clsRPivotTableFunction.AddParameter("rows", ucrReceiverInitialRowFactor.GetVariableNames, iPosition:=2)
        End If
    End Sub
End Class