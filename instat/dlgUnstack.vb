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
    Private clsFormula As New ROperator
    Private clsCarryColumns As New ROperator
    Private clsSelect As New RFunction
    Private clsUnstackedOperator, clsCommaOperator As New ROperator
    Private clsDcastFunction As New RFunction
    Private clsBaseRCode As New RCodeStructure


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
        'autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 58

        'ucrSelector
        ucrSelectorForUnstack.SetParameter(New RParameter("data", 0))
        ucrSelectorForUnstack.SetParameterIsrfunction()

        'ucrFactor
        ucrFactorToUnstackReceiver.SetParameter(New RParameter("y", 2))
        ucrFactorToUnstackReceiver.SetParameterIsString()
        ucrFactorToUnstackReceiver.bWithQuotes = False
        ucrFactorToUnstackReceiver.Selector = ucrSelectorForUnstack
        ucrFactorToUnstackReceiver.SetDataType("factor")
        ucrFactorToUnstackReceiver.strSelectorHeading = "Factors"

        ''ucrColumn
        'ucrColumnToUnstackReceiver.SetParameter(New RParameter("value.var", 4))
        'ucrColumnToUnstackReceiver.SetParameterIsString()
        'ucrColumnToUnstackReceiver.Selector = ucrSelectorForUnstack

        ''ucrMultipleColumnsReceiver
        'ucrMultipleColumnsReceiver.SetParameter(New RParameter("value.var", 1))
        'ucrMultipleColumnsReceiver.SetParameterIsString()
        'ucrMultipleColumnsReceiver.Selector = ucrSelectorForUnstack

        'ucrCarryColumns
        ucrReceiverCarryColumns.SetParameter(New RParameter("y", 1, bNewIncludeArgumentName:=False))
        ucrReceiverCarryColumns.SetParameterIsString()
        ucrReceiverCarryColumns.Selector = ucrSelectorForUnstack

        ' Operations
        clsFormula.SetOperation("~")
        clsFormula.AddParameter("formula", clsROperatorParameter:=clsCarryColumns, iPosition:=0)
        clsFormula.bBrackets = False
        clsCarryColumns.bBrackets = False

        'chkbox
        ucrChkDropMissingCombinations.SetParameter(New RParameter("drop", 3))
        ucrChkDropMissingCombinations.SetText("Drop Missing Combinations")
        ucrChkDropMissingCombinations.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDropMissingCombinations.SetRDefault("TRUE")

        'ucrSave
        ucrNewDFName.SetIsTextBox()
        ucrNewDFName.SetSaveTypeAsDataFrame()
        ucrNewDFName.SetDataFrameSelector(ucrSelectorForUnstack.ucrAvailableDataFrames)
        ucrNewDFName.SetLabelText("New Data Frame Name:")

        ucrPnlUnstackCol.AddRadioButton(rdoSingle)
        ucrPnlUnstackCol.AddRadioButton(rdoMultiple)
        ucrPnlUnstackCol.AddRadioButton(rdoRestoreHierarchy)


        ucrPnlUnstackCol.AddFunctionNamesCondition(rdoSingle, "dcast")
        ucrPnlUnstackCol.AddRCodeIsRFunctionCondition(rdoRestoreHierarchy, bNewIsPositive:=False)
        'TODO add function name condition for rdoMultiple


        ucrPnlUnstackCol.AddToLinkedControls(ucrColumnToUnstackReceiver, {rdoSingle}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlUnstackCol.AddToLinkedControls(ucrMultipleColumnsReceiver, {rdoMultiple}, bNewLinkedHideIfParameterMissing:=True)

        ucrColumnToUnstackReceiver.SetLinkedDisplayControl(lblColumnToUnstack)
        ucrMultipleColumnsReceiver.SetLinkedDisplayControl(lblMultipleColumns)

    End Sub

    Private Sub SetDefaults()
        clsDcastFunction = New RFunction
        clsSelect = New RFunction
        clsUnstackedOperator = New ROperator
        clsCommaOperator = New ROperator

        ucrSelectorForUnstack.Reset()
        ucrNewDFName.Reset()
        ucrFactorToUnstackReceiver.SetMeAsReceiver()

        clsDcastFunction.SetPackageName("reshape2")
        clsDcastFunction.SetRCommand("dcast")
        clsDcastFunction.SetAssignTo(ucrSelectorForUnstack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked", strTempDataframe:=ucrSelectorForUnstack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")

        clsSelect.SetPackageName("dplyr")
        clsSelect.SetRCommand("select")
        clsSelect.AddParameter("comma", clsROperatorParameter:=clsCommaOperator, bIncludeArgumentName:=False)

        clsCommaOperator.SetOperation(",")
        clsUnstackedOperator.SetOperation("%>%")
        clsUnstackedOperator.AddParameter("left", clsRFunctionParameter:=clsDcastFunction, iPosition:=0)
        clsUnstackedOperator.AddParameter("right", clsRFunctionParameter:=clsSelect, iPosition:=1)

        clsBaseRCode = clsDcastFunction
        ucrBase.clsRsyntax.SetBaseRFunction(clsDcastFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrFactorToUnstackReceiver.AddAdditionalCodeParameterPair(clsCommaOperator, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrSelectorForUnstack.SetRCode(clsDcastFunction, bReset)
        ucrPnlUnstackCol.SetRCode(clsBaseRCode, bReset)
        ucrNewDFName.AddAdditionalRCode(clsUnstackedOperator, iAdditionalPairNo:=1)
        ucrNewDFName.SetRCode(clsDcastFunction, bReset)
        ucrReceiverCarryColumns.SetRCode(clsCommaOperator, bReset)
        ucrChkDropMissingCombinations.SetRCode(clsDcastFunction, bReset)
        ucrFactorToUnstackReceiver.SetRCode(clsFormula, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrFactorToUnstackReceiver.IsEmpty() AndAlso Not ucrReceiverCarryColumns.IsEmpty() AndAlso ucrNewDFName.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
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

    Private Sub SetFormula()
        Dim i As Integer = 0
        If Not ucrFactorToUnstackReceiver.IsEmpty AndAlso Not ucrReceiverCarryColumns.IsEmpty Then
            clsDcastFunction.AddParameter("formula", clsROperatorParameter:=clsFormula)
            clsCarryColumns.SetOperation("+")
            clsCarryColumns.ClearParameters()
            For Each strIndicatorVar As String In ucrReceiverCarryColumns.GetVariableNamesAsList
                clsCarryColumns.AddParameter(i, strIndicatorVar, iPosition:=i)
                i = i + 1
            Next
        End If
    End Sub

    Private Sub ucrSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForUnstack.ControlValueChanged
        NewDefaultName()
    End Sub

    Private Sub ucrReceiverFormula_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCarryColumns.ControlValueChanged, ucrFactorToUnstackReceiver.ControlValueChanged
        SetFormula()
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewDFName.ControlContentsChanged, ucrColumnToUnstackReceiver.ControlContentsChanged, ucrFactorToUnstackReceiver.ControlContentsChanged, ucrReceiverCarryColumns.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlUnstackCol_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlUnstackCol.ControlContentsChanged
        If rdoSingle.Checked Then
            clsBaseRCode = clsDcastFunction
            ucrBase.clsRsyntax.SetBaseRFunction(clsDcastFunction)
        ElseIf rdoRestoreHierarchy.Checked Then
            clsBaseRCode = clsUnstackedOperator
            ucrBase.clsRsyntax.SetBaseROperator(clsUnstackedOperator)
        End If
    End Sub
End Class