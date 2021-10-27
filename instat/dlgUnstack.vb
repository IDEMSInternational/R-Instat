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
    Private clsHierachyFunction As New RFunction
    Private clsSelectDataFunction As New RFunction
    Private clsUnstackedOperator, clsCommaOperator, clsFormula, clspipeOperator As New ROperator
    Private clsDcastFunction As New RFunction
    Private clsBaseRCode As New RCodeStructure

    Private iReceiverMaxY As Integer
    Private iReceiverLabelMaxY As Integer
    Private iCarryClomunsY As Integer

    Private Sub dlgunstack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            iReceiverMaxY = ucrReceiverCarryColumns.Location.Y
            iReceiverLabelMaxY = lblColumnsToCarry.Location.Y
            iCarryClomunsY = ucrChkCarryColumns.Location.Y
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 58

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
        ucrReceiverColumnToUnstack.SetParameter(New RParameter("values_from", 2))

        ucrReceiverColumnToUnstack.SetParameterIsString()
        ucrReceiverColumnToUnstack.bWithQuotes = False
        ucrReceiverColumnToUnstack.Selector = ucrSelectorForUnstack

        'ucrMultipleColumnsReceiver
        ucrMultipleColumnsReceiver.SetParameter(New RParameter("values_from", 2))
        ucrMultipleColumnsReceiver.SetParameterIsString()
        ucrMultipleColumnsReceiver.bWithQuotes = False
        ucrMultipleColumnsReceiver.Selector = ucrSelectorForUnstack

        ucrChkCarryColumns.SetText("Columns to Carry")
        ucrChkCarryColumns.AddToLinkedControls(ucrReceiverCarryColumns, {True}, bNewLinkedHideIfParameterMissing:=True)

        'ucrCarryColumns
        ucrReceiverCarryColumns.SetParameterIsString()
        ucrReceiverCarryColumns.bWithQuotes = False
        ucrReceiverCarryColumns.Selector = ucrSelectorForUnstack
        ucrReceiverCarryColumns.SetValuesToIgnore({"NULL"})

        ucrChkValuesFill.SetText("Fill Missing Values:")
        ucrChkValuesFill.AddParameterPresentCondition(True, "values_fill", True)
        ucrChkValuesFill.AddParameterPresentCondition(False, "values_fill", False)
        ucrChkValuesFill.AddToLinkedControls(ucrNudValuesFill, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrNudValuesFill.SetParameter(New RParameter("values_fill", iNewPosition:=7))
        ucrNudValuesFill.SetMinMax(iNewMin:=0)

        ucrInputTextPrefix.SetParameter(New RParameter("names_prefix", 5))

        'ucrAddprefix
        ucrChkAddPrefix.SetText("Add Prefix:")
        'ucrChkAddPrefix.SetParameter(ucrInputTextPrefix.GetParameter, bNewAddRemoveParameter:=True, bNewChangeParameterValue:=True)
        ucrChkAddPrefix.AddParameterPresentCondition(True, "names_prefix")
        ucrChkAddPrefix.AddParameterPresentCondition(False, "names_prefix", False)
        ucrChkAddPrefix.AddToLinkedControls(ucrInputTextPrefix, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        'ucrSave
        ucrNewDFName.SetSaveTypeAsDataFrame()
        ucrNewDFName.SetDataFrameSelector(ucrSelectorForUnstack.ucrAvailableDataFrames)
        ucrNewDFName.SetLabelText("New Data Frame Name:")
        ucrNewDFName.SetIsTextBox()

        ucrPnlUnstackCol.AddRadioButton(rdoSingle)
        ucrPnlUnstackCol.AddRadioButton(rdoMultiple)
        ucrPnlUnstackCol.AddRadioButton(rdoRestoreHierarchy)

        ucrPnlUnstackCol.AddFunctionNamesCondition({rdoSingle}, "pivot_wider")
        'ucrPnlUnstackCol.AddParameterIsROperatorCondition(rdoRestoreHierarchy, "%>%")

        ucrPnlUnstackCol.AddRCodeIsRFunctionCondition(rdoRestoreHierarchy, bNewIsPositive:=False)
        'TODO add function name condition for rdoMultiple

        ucrPnlUnstackCol.AddToLinkedControls(ucrReceiverColumnToUnstack, {rdoSingle}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlUnstackCol.AddToLinkedControls(ucrMultipleColumnsReceiver, {rdoMultiple}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlUnstackCol.AddToLinkedControls(ucrChkAddPrefix, {rdoSingle, rdoMultiple}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlUnstackCol.AddToLinkedControls(ucrChkValuesFill, {rdoMultiple, rdoSingle}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrReceiverColumnToUnstack.SetLinkedDisplayControl(lblColumnToUnstack)
        ucrMultipleColumnsReceiver.SetLinkedDisplayControl(lblMultipleColumns)
        ucrReceiverCarryColumns.SetLinkedDisplayControl(lblColumnsToCarry)
    End Sub

    Private Sub SetDefaults()
        clsDcastFunction = New RFunction
        clsSelectFunction = New RFunction
        clsHierachyFunction = New RFunction
        clsUnstackedOperator = New ROperator
        clsCommaOperator = New ROperator
        clsCarryColumnsOperator = New ROperator
        clsFormula = New ROperator

        ucrReceiverColumnToUnstack.SetMeAsReceiver()


        ucrSelectorForUnstack.Reset()
        ucrNewDFName.Reset()
        ucrReceiverFactorToUnstackby.SetMeAsReceiver()

        ucrChkValuesFill.Checked = False
        ucrChkAddPrefix.Checked = False

        ' Operations
        clsFormula.SetOperation("~")
        clsFormula.bBrackets = False
        'clsFormula.AddParameter("left", clsROperatorParameter:=clsCarryColumnsOperator, iPosition:=0)


        clsSelectDataFunction.SetPackageName("dplyr")
        clsSelectDataFunction.SetRCommand("select")

        clspipeOperator.SetOperation(" %>% ")
        clspipeOperator.AddParameter("left", clsRFunctionParameter:=ucrSelectorForUnstack.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clspipeOperator.AddParameter("right", clsRFunctionParameter:=clsSelectDataFunction, iPosition:=1)

        clsCarryColumnsOperator.bBrackets = False
        clsCarryColumnsOperator.SetOperation("+")

        clsDcastFunction.SetPackageName("tidyr")
        clsDcastFunction.SetRCommand("pivot_wider")

        clsHierachyFunction.SetPackageName("reshape2")
        clsHierachyFunction.SetRCommand("dcast")
        clsHierachyFunction.AddParameter("formula", clsROperatorParameter:=clsFormula, iPosition:=1)


        clsSelectFunction.SetPackageName("dplyr")
        clsSelectFunction.SetRCommand("select")
        clsSelectFunction.AddParameter("comma", clsROperatorParameter:=clsCommaOperator, bIncludeArgumentName:=False)

        clsCommaOperator.SetOperation(",")
        clsUnstackedOperator.SetOperation("%>%")
        clsUnstackedOperator.AddParameter("left", clsRFunctionParameter:=clsHierachyFunction, iPosition:=0)
        clsUnstackedOperator.AddParameter("right", clsRFunctionParameter:=clsSelectFunction, iPosition:=1)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDcastFunction)
        AddRemoveParameters()

    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        'ucrReceiverCarryColumns.AddAdditionalCodeParameterPair(clsHierachyFunction, New RParameter("cols", ucrReceiverCarryColumns.GetVariables, 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverFactorToUnstackby.AddAdditionalCodeParameterPair(clsFormula, New RParameter("right", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverFactorToUnstackby.AddAdditionalCodeParameterPair(clsCommaOperator, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverFactorToUnstackby.AddAdditionalCodeParameterPair(clsSelectDataFunction, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrReceiverCarryColumns.AddAdditionalCodeParameterPair(clsSelectDataFunction, New RParameter("x", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrNewDFName.AddAdditionalRCode(clsUnstackedOperator, iAdditionalPairNo:=1)
        ucrSelectorForUnstack.AddAdditionalCodeParameterPair(clsHierachyFunction, ucrSelectorForUnstack.GetParameter, iAdditionalPairNo:=1)
        ucrReceiverCarryColumns.AddAdditionalCodeParameterPair(clsCommaOperator, New RParameter("y", 1, bNewIncludeArgumentName:=False))

        ucrSelectorForUnstack.SetRCode(clsDcastFunction, bReset)
        ucrReceiverColumnToUnstack.SetRCode(clsDcastFunction, bReset)
        ucrPnlUnstackCol.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrNewDFName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverCarryColumns.SetRCode(clsDcastFunction, bReset)
        ucrNudValuesFill.SetRCode(clsDcastFunction, bReset)
        ucrReceiverFactorToUnstackby.SetRCode(clsDcastFunction, bReset)
        ucrInputTextPrefix.SetRCode(clsDcastFunction, bReset)
        ucrMultipleColumnsReceiver.SetRCode(clsDcastFunction, bReset)
        ucrChkValuesFill.SetRCode(clsDcastFunction, bReset)
        ucrChkCarryColumns.SetRCode(clsDcastFunction, bReset)
    End Sub

    Private Sub ucrChkCarryColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCarryColumns.ControlValueChanged,
    ucrMultipleColumnsReceiver.ControlValueChanged, ucrReceiverCarryColumns.ControlValueChanged
        clsSelectDataFunction.ClearParameters()
        Dim iPosition As Integer = 0
        For Each strColumn In ucrMultipleColumnsReceiver.GetVariableNamesAsList()
            clsSelectDataFunction.AddParameter(strColumn, strColumn, iPosition:=iPosition, bIncludeArgumentName:=False)
            iPosition = iPosition + 1
        Next
        clsSelectDataFunction.AddParameter(New RParameter("x", ucrReceiverColumnToUnstack.GetVariables, bNewIncludeArgumentName:=False))
        clsSelectDataFunction.AddParameter(New RParameter("y", ucrReceiverFactorToUnstackby.GetVariables, bNewIncludeArgumentName:=False))
        If ucrChkCarryColumns.Checked Then
            ucrReceiverCarryColumns.SetMeAsReceiver()
            For Each strColumn In ucrReceiverCarryColumns.GetVariableNamesAsList
                If Not ucrMultipleColumnsReceiver.GetVariableNamesAsList.Contains(strColumn) Then
                    clsSelectDataFunction.AddParameter(strColumn, strColumn, iPosition:=iPosition, bIncludeArgumentName:=False)
                    iPosition = iPosition + 1
                End If
            Next
        Else
            ucrMultipleColumnsReceiver.SetMeAsReceiver()
        End If
        AddRemoveDataOrPipeOperator()
    End Sub

    Private Sub AddRemoveDataOrPipeOperator()
        If Not ucrChkCarryColumns.Checked Then
            clsDcastFunction.RemoveParameterByName("%>%")
            clsDcastFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorForUnstack.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        Else
            clsDcastFunction.RemoveParameterByName("data")
            clsDcastFunction.AddParameter("data", clsROperatorParameter:=clspipeOperator, iPosition:=0, bIncludeArgumentName:=True)
        End If
    End Sub
    Private Sub TestOKEnabled()
        If Not ucrReceiverFactorToUnstackby.IsEmpty() AndAlso ucrNewDFName.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub AddRemoveParameters()
        If ucrInputTextPrefix.IsEmpty Then
            clsDcastFunction.RemoveParameterByName("names_prefix")
        End If

        If ucrChkValuesFill.Checked Then
            clsDcastFunction.RemoveParameterByName("values_fill")
            clsDcastFunction.AddParameter(New RParameter("values_fill", "0"))
        Else
            clsDcastFunction.RemoveParameterByName("values_fill")
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
    End Sub

    Private Sub SetFormula()
        Dim i As Integer = 0

        If Not ucrReceiverFactorToUnstackby.IsEmpty Then
            clsCarryColumnsOperator.ClearParameters()
            If rdoRestoreHierarchy.Checked Then
                clsCarryColumnsOperator.AddParameter(i, ucrReceiverFactorToUnstackby.GetVariableNames(False), iPosition:=i)
                i = i + 1


            End If
            If rdoSingle.Checked AndAlso ucrReceiverCarryColumns.IsEmpty Then
                clsFormula.AddParameter("left", ".", iPosition:=0)
            Else
                For Each strIndicatorVar As String In ucrReceiverCarryColumns.GetVariableNamesAsList
                    clsCarryColumnsOperator.AddParameter(i, strIndicatorVar, iPosition:=i)
                    i = i + 1
                Next
                clsFormula.AddParameter("left", clsROperatorParameter:=clsCarryColumnsOperator, iPosition:=0)
            End If
        End If
    End Sub

    Private Sub ucrReceiverCarryColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCarryColumns.ControlValueChanged, ucrReceiverFactorToUnstackby.ControlValueChanged
        SetFormula()

    End Sub

    Private Sub ucrPnlUnstackCol_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlUnstackCol.ControlValueChanged
        If rdoSingle.Checked Then
            clsBaseRCode = clsDcastFunction
            ucrBase.clsRsyntax.SetBaseRFunction(clsDcastFunction)
        ElseIf rdoRestoreHierarchy.Checked Then
            clsBaseRCode = clsUnstackedOperator
            ucrBase.clsRsyntax.SetBaseROperator(clsUnstackedOperator)
            clsHierachyFunction.RemoveAssignTo()
        End If
        ucrNewDFName.SetRCode(clsBaseRCode)
        CarryColumnsLabelReceiverLocation()
        SetFormula()
    End Sub

    Private Sub CarryColumnsLabelReceiverLocation()
        If rdoRestoreHierarchy.Checked Then
            lblColumnsToCarry.Location = New Point(lblColumnsToCarry.Location.X, iReceiverLabelMaxY / 2)
            ucrReceiverCarryColumns.Location = New Point(ucrReceiverCarryColumns.Location.X, iReceiverMaxY / 1.95)
            ucrChkCarryColumns.Location = New Point(ucrChkCarryColumns.Location.X, iCarryClomunsY / 1.95)
        ElseIf rdoSingle.Checked Then
            lblColumnsToCarry.Location = New Point(lblColumnsToCarry.Location.X, iReceiverLabelMaxY / 1.5)
            ucrReceiverCarryColumns.Location = New Point(ucrReceiverCarryColumns.Location.X, iReceiverMaxY / 1.45)
            ucrChkCarryColumns.Location = New Point(ucrChkCarryColumns.Location.X, iCarryClomunsY / 1.45)
        Else
            lblColumnsToCarry.Location = New Point(lblColumnsToCarry.Location.X, iReceiverLabelMaxY)
            ucrReceiverCarryColumns.Location = New Point(ucrReceiverCarryColumns.Location.X, iReceiverMaxY)
            ucrChkCarryColumns.Location = New Point(ucrChkCarryColumns.Location.X, iCarryClomunsY)
        End If

    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewDFName.ControlContentsChanged, ucrReceiverFactorToUnstackby.ControlContentsChanged, ucrReceiverCarryColumns.ControlContentsChanged, ucrNudValuesFill.ControlContentsChanged, ucrInputTextPrefix.ControlContentsChanged, ucrChkAddPrefix.ControlContentsChanged, ucrChkValuesFill.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrInputTextPrefix_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTextPrefix.ControlValueChanged
        AddRemoveParameters()
    End Sub
End Class