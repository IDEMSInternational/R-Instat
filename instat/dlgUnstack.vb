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

Public Class dlgUnstack
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsCarryColumnsOperator As New ROperator
    Private clsSelectFunction As New RFunction
    'clsDummyFunction controls the state of the UcrpnlUnstackCol 
    Private clsDummyFunction As New RFunction
    Private clsDummyCarryFunction As New RFunction
    Private clsHierachyFunction As New RFunction
    Private clsSelectDataFunction As New RFunction
    Private clsUnstackedOperator, clsCommaOperator, clsformulaOperator, clspipeOperator As New ROperator
    Private clsDcastFunction As New RFunction
    Private clsBaseRCode As New RCodeStructure
    Private iReceiverMaxY As Integer
    Private iCarryClomunsY As Integer

    Private Sub dlgunstack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 58
        iReceiverMaxY = ucrReceiverCarryColumns.Location.Y
        iCarryClomunsY = ucrChkCarryColumns.Location.Y

        'ucrSelector
        ucrSelectorForUnstack.SetParameter(New RParameter("data", 0))
        ucrSelectorForUnstack.SetParameterIsrfunction()

        'ucrFactor
        ucrReceiverFactorToUnstackby.SetParameter(New RParameter("names_from", 1))
        ucrReceiverFactorToUnstackby.SetParameterIsString()
        ucrReceiverFactorToUnstackby.bWithQuotes = False
        ucrReceiverFactorToUnstackby.Selector = ucrSelectorForUnstack
        ucrReceiverFactorToUnstackby.SetDataType("factor")
        ucrReceiverFactorToUnstackby.strSelectorHeading = "Factors"

        'ucrColumn
        ucrReceiverColumnToUnstack.Selector = ucrSelectorForUnstack

        'ucrMultipleColumnsReceiver
        ucrMultipleColumnsReceiver.Selector = ucrSelectorForUnstack

        ucrChkCarryColumns.SetText("Columns to Carry:")
        ucrChkCarryColumns.SetParameter(New RParameter("checked", iNewPosition:=0))
        ucrChkCarryColumns.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkCarryColumns.AddToLinkedControls(ucrReceiverCarryColumns, {True}, bNewLinkedHideIfParameterMissing:=True)

        'ucrCarryColumns
        ucrReceiverCarryColumns.Selector = ucrSelectorForUnstack

        ucrChkValuesFill.SetText("Fill Missing Values:")
        ucrChkValuesFill.AddParameterPresentCondition(True, "values_fill", True)
        ucrChkValuesFill.AddParameterPresentCondition(False, "values_fill", False)
        ucrChkValuesFill.AddToLinkedControls(ucrNudValuesFill, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=0, bNewLinkedChangeToDefaultState:=True)

        ucrNudValuesFill.SetMinMax(iNewMin:=0)

        'ucrAddprefix
        ucrChkAddPrefix.SetText("Add Prefix:")
        ucrChkAddPrefix.AddParameterPresentCondition(True, "names_prefix", True)
        ucrChkAddPrefix.AddParameterPresentCondition(False, "names_prefix", False)
        ucrChkAddPrefix.AddToLinkedControls(ucrInputTextPrefix, {True}, bNewLinkedUpdateFunction:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrInputTextPrefix.SetParameter(New RParameter("names_prefix", iNewPosition:=5))

        'ucrSave
        ucrNewDFName.SetSaveTypeAsDataFrame()
        ucrNewDFName.SetDataFrameSelector(ucrSelectorForUnstack.ucrAvailableDataFrames)
        ucrNewDFName.SetLabelText("New Data Frame Name:")
        ucrNewDFName.SetIsTextBox()

        ucrPnlUnstackCol.AddRadioButton(rdoSingle)
        ucrPnlUnstackCol.AddRadioButton(rdoMultiple)
        ucrPnlUnstackCol.AddRadioButton(rdoRestoreHierarchy)

        ucrPnlUnstackCol.AddParameterValuesCondition(rdoSingle, "checked", "single")
        ucrPnlUnstackCol.AddParameterValuesCondition(rdoMultiple, "checked", "multiple")
        ucrPnlUnstackCol.AddParameterValuesCondition(rdoRestoreHierarchy, "checked", "hierarchy")

        ucrPnlUnstackCol.AddToLinkedControls(ucrReceiverColumnToUnstack, {rdoSingle}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlUnstackCol.AddToLinkedControls(ucrMultipleColumnsReceiver, {rdoMultiple}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlUnstackCol.AddToLinkedControls(ucrChkAddPrefix, {rdoSingle, rdoMultiple}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlUnstackCol.AddToLinkedControls(ucrChkValuesFill, {rdoMultiple, rdoSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverColumnToUnstack.SetLinkedDisplayControl(lblColumnToUnstack)
        ucrMultipleColumnsReceiver.SetLinkedDisplayControl(lblMultipleColumns)
    End Sub

    Private Sub SetDefaults()
        clsDcastFunction = New RFunction
        clsSelectFunction = New RFunction
        clsHierachyFunction = New RFunction
        clsUnstackedOperator = New ROperator
        clsCommaOperator = New ROperator
        clsCarryColumnsOperator = New ROperator
        clsformulaOperator = New ROperator
        clsDummyFunction = New RFunction
        clsDummyCarryFunction = New RFunction

        clsDummyCarryFunction.AddParameter("checked", "FALSE", iPosition:=0)

        clsDummyFunction.AddParameter("checked", "single", iPosition:=0)
        ucrReceiverFactorToUnstackby.SetMeAsReceiver()

        ucrSelectorForUnstack.Reset()
        ucrNewDFName.Reset()

        ' Operations
        clsformulaOperator.SetOperation("~")
        clsformulaOperator.bBrackets = False

        clsSelectDataFunction.SetPackageName("dplyr")
        clsSelectDataFunction.SetRCommand("select")

        clspipeOperator.SetOperation(" %>% ")
        clspipeOperator.AddParameter("left", clsRFunctionParameter:=ucrSelectorForUnstack.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clspipeOperator.AddParameter("right", clsRFunctionParameter:=clsSelectDataFunction, iPosition:=1)

        clsCarryColumnsOperator.bBrackets = False
        clsCarryColumnsOperator.SetOperation("+")

        clsDcastFunction.SetPackageName("tidyr")
        clsDcastFunction.SetRCommand("pivot_wider")

        clsHierachyFunction.SetPackageName("data.table")
        clsHierachyFunction.SetRCommand("dcast")
        clsHierachyFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorForUnstack.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsHierachyFunction.AddParameter("formula", clsROperatorParameter:=clsformulaOperator, iPosition:=1)

        clsSelectFunction.SetPackageName("dplyr")
        clsSelectFunction.SetRCommand("select")
        clsSelectFunction.AddParameter("comma", clsROperatorParameter:=clsCommaOperator, bIncludeArgumentName:=False, iPosition:=0)

        clsCommaOperator.SetOperation(",")
        clsUnstackedOperator.SetOperation("%>%")
        clsUnstackedOperator.AddParameter("left", clsRFunctionParameter:=clsHierachyFunction, iPosition:=0)
        clsUnstackedOperator.AddParameter("right", clsRFunctionParameter:=clsSelectFunction, iPosition:=1)

        AddRemoveDataOrPipeOperator()
        ValuesfillParameter()

        clsBaseRCode = clsDcastFunction
        ucrBase.clsRsyntax.SetBaseRFunction(clsDcastFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverFactorToUnstackby.AddAdditionalCodeParameterPair(clsformulaOperator, New RParameter("right", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverFactorToUnstackby.AddAdditionalCodeParameterPair(clsCommaOperator, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverFactorToUnstackby.AddAdditionalCodeParameterPair(clsSelectDataFunction, New RParameter("factor", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrNewDFName.AddAdditionalRCode(clsUnstackedOperator, iAdditionalPairNo:=1)

        ucrPnlUnstackCol.SetRCode(clsDummyFunction, bReset)
        ucrReceiverFactorToUnstackby.SetRCode(clsDcastFunction, bReset)
        ucrChkAddPrefix.SetRCode(clsDcastFunction, bReset)
        ucrChkValuesFill.SetRCode(clsDcastFunction, bReset)
        ucrChkCarryColumns.SetRCode(clsDummyCarryFunction, bReset)
        ucrNewDFName.SetRCode(clsBaseRCode, bReset)
    End Sub

    Private Sub ucrReceiverFactorToUnstackby_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactorToUnstackby.ControlValueChanged
        SetFormula()
    End Sub

    Private Sub ucrReceiverColumnToUnstack_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnToUnstack.ControlValueChanged
        ValuesfillParameter()
    End Sub

    Private Sub ucrMultipleColumnsReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrMultipleColumnsReceiver.ControlValueChanged
        ValuesfillParameter()
    End Sub

    Private Sub ucrChkCarryColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCarryColumns.ControlValueChanged
        AddRemoveDataOrPipeOperator()
        CarryColumnsParameter()
        SetFormula()
    End Sub

    Private Sub ValuesfillParameter()
        Dim clsCommaMultiple As New ROperator
        clsCommaMultiple.SetOperation(",")
        Dim position As Integer
        position = 0
        If rdoSingle.Checked Then
            clsSelectDataFunction.RemoveParameterByName("Multiple_Values")
            clsDcastFunction.AddParameter("values_from", ucrReceiverColumnToUnstack.GetVariableNames(False), iPosition:=2)
            clsSelectDataFunction.AddParameter("single", ucrReceiverColumnToUnstack.GetVariableNames(False), iPosition:=1, bIncludeArgumentName:=False)
        ElseIf rdoMultiple.Checked Then
            clsSelectDataFunction.RemoveParameterByName("single")
            For Each strMultiple In ucrMultipleColumnsReceiver.GetVariableNamesAsList()
                clsCommaMultiple.AddParameter(strMultiple, strMultiple, iPosition:=position)
                position = position + 1
            Next
            clsSelectDataFunction.AddParameter("Multiple_Values", clsROperatorParameter:=clsCommaMultiple, iPosition:=4, bIncludeArgumentName:=False)
            clsDcastFunction.AddParameter("values_from", ucrMultipleColumnsReceiver.GetVariableNames(False), iPosition:=2)
        End If
        TestOKEnabled()
    End Sub

    Private Sub AddRemoveDataOrPipeOperator()
        If Not ucrChkCarryColumns.Checked Then
            clsDcastFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorForUnstack.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        Else
            clsDcastFunction.AddParameter("data", clsROperatorParameter:=clspipeOperator, iPosition:=0)
        End If
    End Sub

    Private Sub TestOKEnabled()
        If rdoSingle.Checked Then
            If ucrReceiverFactorToUnstackby.IsEmpty OrElse ucrReceiverColumnToUnstack.IsEmpty OrElse Not ucrNewDFName.IsComplete OrElse (ucrReceiverCarryColumns.IsEmpty AndAlso ucrChkCarryColumns.Checked) OrElse (ucrInputTextPrefix.IsEmpty AndAlso ucrChkAddPrefix.Checked) Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        ElseIf rdoMultiple.Checked Then
            If ucrReceiverFactorToUnstackby.IsEmpty OrElse ucrMultipleColumnsReceiver.IsEmpty OrElse Not ucrNewDFName.IsComplete OrElse (ucrReceiverCarryColumns.IsEmpty AndAlso ucrChkCarryColumns.Checked) OrElse (ucrInputTextPrefix.IsEmpty AndAlso ucrChkAddPrefix.Checked) Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        ElseIf rdoRestoreHierarchy.Checked Then
            If ucrReceiverFactorToUnstackby.IsEmpty OrElse Not ucrNewDFName.IsComplete OrElse (ucrReceiverCarryColumns.IsEmpty AndAlso ucrChkCarryColumns.Checked) Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub NewDefaultName()
        If (Not ucrNewDFName.bUserTyped) AndAlso ucrSelectorForUnstack.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDFName.SetName(ucrSelectorForUnstack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_unstacked")
        End If
    End Sub

    Private Sub ucrSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForUnstack.ControlValueChanged
        NewDefaultName()
        AddRemoveDataOrPipeOperator()
    End Sub

    Private Sub SetFormula()
        Dim i As Integer = 1
        Dim strcoll As String = ucrReceiverFactorToUnstackby.GetVariableNames(False)
        If Not ucrReceiverFactorToUnstackby.IsEmpty Then
            clsCarryColumnsOperator.ClearParameters()
            If ucrChkCarryColumns.Checked Then
                clsCarryColumnsOperator.AddParameter("factor", ucrReceiverFactorToUnstackby.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                For Each strIndicatorVar As String In ucrReceiverCarryColumns.GetVariableNamesAsList
                    clsCarryColumnsOperator.AddParameter(i, strIndicatorVar, iPosition:=i)
                    i = i + 1
                Next
                If ucrReceiverCarryColumns.GetVariableNamesAsList.Contains(strcoll) Then
                    clsCarryColumnsOperator.RemoveParameterByName("factor")
                End If
                clsformulaOperator.AddParameter("left", clsROperatorParameter:=clsCarryColumnsOperator, iPosition:=0)
            Else
                clsformulaOperator.RemoveParameterByName("left")
                clsformulaOperator.AddParameter("left", ucrReceiverFactorToUnstackby.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
            End If
        End If
    End Sub

    Private Sub CarryColumnsParameter()
        Dim clsTempCommaOperator As New ROperator
        clsTempCommaOperator.SetOperation(",")
        Dim iposition As Integer = 0

        If ucrChkCarryColumns.Checked Then
            ucrReceiverCarryColumns.SetMeAsReceiver()
            For Each strcolumn In ucrReceiverCarryColumns.GetVariableNamesAsList
                clsTempCommaOperator.AddParameter(strcolumn, strcolumn, iPosition:=iposition)
                iposition = iposition + 1
            Next

            If rdoSingle.Checked Then
                clsSelectDataFunction.AddParameter("comma", clsROperatorParameter:=clsTempCommaOperator, iPosition:=3, bIncludeArgumentName:=False)
            ElseIf rdoMultiple.Checked Then
                clsTempCommaOperator.ClearParameters()
                For Each strcolumn In ucrReceiverCarryColumns.GetVariableNamesAsList
                    If Not ucrMultipleColumnsReceiver.GetVariableNamesAsList.Contains(strcolumn) Then
                        clsTempCommaOperator.AddParameter(strcolumn, strcolumn, iPosition:=iposition)
                        iposition = iposition + 1
                    End If
                Next
                clsSelectDataFunction.AddParameter("comma", clsROperatorParameter:=clsTempCommaOperator, iPosition:=3, bIncludeArgumentName:=False)

            ElseIf rdoRestoreHierarchy.Checked Then
                clsCommaOperator.AddParameter("comma", clsROperatorParameter:=clsTempCommaOperator, iPosition:=1)
            End If
        Else
            ucrReceiverFactorToUnstackby.SetMeAsReceiver()
            clsSelectDataFunction.RemoveParameterByName("comma")
            clsCommaOperator.RemoveParameterByName("comma")
        End If

    End Sub
    Private Sub ucrReceiverCarryColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCarryColumns.ControlValueChanged
        SetFormula()
        CarryColumnsParameter()
    End Sub

    Private Sub ucrPnlUnstackCol_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlUnstackCol.ControlValueChanged
        If rdoSingle.Checked OrElse rdoMultiple.Checked Then
            clsBaseRCode = clsDcastFunction
            ucrBase.clsRsyntax.SetBaseRFunction(clsDcastFunction)
            If rdoSingle.Checked Then
                clsDummyFunction.AddParameter("checked", "single", iPosition:=0)
            ElseIf rdoMultiple.Checked Then
                clsDummyFunction.AddParameter("checked", "multiple", iPosition:=0)
            End If
        ElseIf rdoRestoreHierarchy.Checked Then
            clsBaseRCode = clsUnstackedOperator
            clsDummyFunction.AddParameter("checked", "hierarchy", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseROperator(clsUnstackedOperator)
            clsDcastFunction.RemoveAssignTo()
        End If
        ucrNewDFName.SetRCode(clsBaseRCode)
        CarryColumnsLabelReceiverLocation()
        SetFormula()
        ValuesfillParameter()
        CarryColumnsParameter()
    End Sub

    Private Sub CarryColumnsLabelReceiverLocation()
        If rdoRestoreHierarchy.Checked Then
            ucrReceiverCarryColumns.Location = New Point(ucrReceiverCarryColumns.Location.X, iReceiverMaxY / 1.8)
            ucrChkCarryColumns.Location = New Point(ucrChkCarryColumns.Location.X, iCarryClomunsY / 2)
        ElseIf rdoSingle.Checked Then
            ucrReceiverCarryColumns.Location = New Point(ucrReceiverCarryColumns.Location.X, iReceiverMaxY / 1.45)
            ucrChkCarryColumns.Location = New Point(ucrChkCarryColumns.Location.X, iCarryClomunsY / 1.5)
        Else
            ucrReceiverCarryColumns.Location = New Point(ucrReceiverCarryColumns.Location.X, iReceiverMaxY)
            ucrChkCarryColumns.Location = New Point(ucrChkCarryColumns.Location.X, iCarryClomunsY)
        End If

    End Sub

    Private Sub ucrChkValuesFill_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkValuesFill.ControlValueChanged, ucrNudValuesFill.ControlValueChanged
        If ucrChkValuesFill.Checked Then
            clsDcastFunction.AddParameter(New RParameter("values_fill", ucrNudValuesFill.GetText, iNewPosition:=7))
        Else
            clsDcastFunction.RemoveParameterByName("values_fill")
        End If
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewDFName.ControlContentsChanged, ucrReceiverFactorToUnstackby.ControlContentsChanged, ucrReceiverCarryColumns.ControlContentsChanged, ucrNudValuesFill.ControlContentsChanged, ucrInputTextPrefix.ControlContentsChanged, ucrChkAddPrefix.ControlContentsChanged, ucrChkValuesFill.ControlContentsChanged, ucrMultipleColumnsReceiver.ControlContentsChanged, ucrReceiverColumnToUnstack.ControlContentsChanged, ucrChkCarryColumns.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class