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
    Private clsCarryColumnsOperator As New ROperator
    Private clsSelectFunction As New RFunction
    Private clsUnstackedOperator, clsCommaOperator As New ROperator
    Private clsDcastFunction As New RFunction
    Private clsBaseRCode As New RCodeStructure

    Private iReceiverMaxY As Integer
    Private iReceiverLabelMaxY As Integer
    Private lstRCodeStructure As List(Of RCodeStructure)

    Private Sub dlgunstack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            iReceiverMaxY = ucrReceiverCarryColumns.Location.Y
            iReceiverLabelMaxY = lblCarryColumns.Location.Y
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
        ucrReceiverFactorToUnstackby.SetParameter(New RParameter("right", 1))
        ucrReceiverFactorToUnstackby.SetParameterIsString()
        ucrReceiverFactorToUnstackby.bWithQuotes = False
        ucrReceiverFactorToUnstackby.Selector = ucrSelectorForUnstack
        ucrReceiverFactorToUnstackby.SetDataType("factor")
        ucrReceiverFactorToUnstackby.strSelectorHeading = "Factors"

        'ucrColumn
        ucrReceiverColumnToUnstack.SetParameter(New RParameter("value.var", 4))
        ucrReceiverColumnToUnstack.SetParameterIsString()
        ucrReceiverColumnToUnstack.Selector = ucrSelectorForUnstack

        ''ucrMultipleColumnsReceiver
        'ucrMultipleColumnsReceiver.SetParameter(New RParameter("value.var", 1))
        'ucrMultipleColumnsReceiver.SetParameterIsString()
        'ucrMultipleColumnsReceiver.Selector = ucrSelectorForUnstack

        'ucrCarryColumns
        ucrReceiverCarryColumns.SetParameter(New RParameter("y", 1, bNewIncludeArgumentName:=False))
        ucrReceiverCarryColumns.SetParameterIsString()
        ucrReceiverCarryColumns.bWithQuotes = False
        ucrReceiverCarryColumns.Selector = ucrSelectorForUnstack

        'chkbox
        ucrChkDropMissingCombinations.SetParameter(New RParameter("drop", 3))
        ucrChkDropMissingCombinations.SetText("Drop Missing Combinations")
        ucrChkDropMissingCombinations.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDropMissingCombinations.SetRDefault("TRUE")

        'ucrSave
        ucrNewDFName.SetSaveTypeAsDataFrame()
        ucrNewDFName.SetDataFrameSelector(ucrSelectorForUnstack.ucrAvailableDataFrames)
        ucrNewDFName.SetLabelText("New Data Frame Name:")
        ucrNewDFName.SetIsTextBox()

        ucrPnlUnstackCol.AddRadioButton(rdoSingle)
        ucrPnlUnstackCol.AddRadioButton(rdoMultiple)
        ucrPnlUnstackCol.AddRadioButton(rdoRestoreHierarchy)

        ucrPnlUnstackCol.AddFunctionNamesCondition(rdoSingle, "dcast")
        ucrPnlUnstackCol.AddRCodeIsRFunctionCondition(rdoRestoreHierarchy, bNewIsPositive:=False)
        'TODO add function name condition for rdoMultiple

        ucrPnlUnstackCol.AddToLinkedControls(ucrReceiverColumnToUnstack, {rdoSingle}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlUnstackCol.AddToLinkedControls(ucrMultipleColumnsReceiver, {rdoMultiple}, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverColumnToUnstack.SetLinkedDisplayControl(lblColumnToUnstack)
        ucrMultipleColumnsReceiver.SetLinkedDisplayControl(lblMultipleColumns)
    End Sub

    Private Sub ResetRCode()
        clsDcastFunction = New RFunction
        clsSelectFunction = New RFunction
        clsUnstackedOperator = New ROperator
        clsCommaOperator = New ROperator
        clsFormula = New ROperator
        clsCarryColumnsOperator = New ROperator

        clsFormula.SetOperation("~")
        clsFormula.bBrackets = False

        clsCarryColumnsOperator.bBrackets = False
        clsCarryColumnsOperator.SetOperation("+")

        clsDcastFunction.SetPackageName("reshape2")
        clsDcastFunction.SetRCommand("dcast")

        clsSelectFunction.SetPackageName("dplyr")
        clsSelectFunction.SetRCommand("select")

        clsCommaOperator.SetOperation(",")

        clsUnstackedOperator.SetOperation("%>%")

        clsBaseRCode = clsDcastFunction
    End Sub

    Private Sub SetRCodeDefaultParameters()
        clsDcastFunction.AddParameter("formula", clsROperatorParameter:=clsFormula, iPosition:=1)
        clsSelectFunction.AddParameter("comma", clsROperatorParameter:=clsCommaOperator, bIncludeArgumentName:=False)
        clsUnstackedOperator.AddParameter("left", clsRFunctionParameter:=clsDcastFunction, iPosition:=0)
        clsUnstackedOperator.AddParameter("right", clsRFunctionParameter:=clsSelectFunction, iPosition:=1)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDcastFunction)
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForUnstack.Reset()
        ucrNewDFName.Reset()
        ucrReceiverFactorToUnstackby.SetMeAsReceiver()
        If IsNothing(lstRCodeStructure) Then
            SetRCodeDefaultParameters()
        ElseIf (lstRCodeStructure.Count > 1) Then
            SetRCodeDefaultParameters()
            MsgBox("Developer error: Only one RCodestructure required")
        ElseIf (lstRCodeStructure.Count = 0) Then
            If TypeOf (lstRCodeStructure(0)) Is RFunction Then
                If TryCast(lstRCodeStructure(0), RFunction).strRCommand = clsDcastFunction.strRCommand Then
                    clsDcastFunction = lstRCodeStructure(0)
                Else
                    SetRCodeDefaultParameters()
                    MsgBox("Developer error: This dialogue recognizes the " & Chr(39) & "reshape2: dcast" & Chr(39) & "function only")
                End If
            ElseIf TypeOf (lstRCodeStructure(0)) Is ROperator Then
                If TryCast(lstRCodeStructure(0), ROperator).strOperation = clsUnstackedOperator.strOperation Then
                    For Each clsParameter In TryCast(lstRCodeStructure(0), ROperator).clsParameters
                        If clsParameter.bIsFunction AndAlso Not IsNothing(clsParameter.clsArgumentCodeStructure) Then
                            If TryCast(clsParameter.clsArgumentCodeStructure, RFunction).strRCommand = clsDcastFunction.strRCommand Then
                                clsParameter.strArgumentName = "left"
                            ElseIf TryCast(clsParameter.clsArgumentCodeStructure, RFunction).strRCommand = clsSelectFunction.strRCommand Then
                                clsParameter.strArgumentName = "right"
                            End If


                        End If
                    Next

                End If
            End If
        End If


    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverFactorToUnstackby.AddAdditionalCodeParameterPair(clsCommaOperator, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrNewDFName.AddAdditionalRCode(clsUnstackedOperator, iAdditionalPairNo:=1)
        ucrSelectorForUnstack.SetRCode(clsDcastFunction, bReset)
        ucrReceiverColumnToUnstack.SetRCode(clsDcastFunction, bReset)
        ucrPnlUnstackCol.SetRCode(clsBaseRCode, bReset)
        ucrNewDFName.SetRCode(clsBaseRCode, bReset)
        ucrReceiverCarryColumns.SetRCode(clsCommaOperator, bReset)
        ucrChkDropMissingCombinations.SetRCode(clsDcastFunction, bReset)
        ucrReceiverFactorToUnstackby.SetRCode(clsFormula, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverFactorToUnstackby.IsEmpty() AndAlso ucrNewDFName.IsComplete Then
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

    Private Sub ucrSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForUnstack.ControlValueChanged
        NewDefaultName()
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
            clsDcastFunction.RemoveAssignTo()
        End If
        ucrNewDFName.SetRCode(clsBaseRCode)
        CarryColumnsLabelReceiverLocation()
        SetFormula()
    End Sub

    Private Sub CarryColumnsLabelReceiverLocation()
        If rdoRestoreHierarchy.Checked Then
            lblCarryColumns.Location = New Point(lblCarryColumns.Location.X, iReceiverLabelMaxY / 1.4)
            ucrReceiverCarryColumns.Location = New Point(ucrReceiverCarryColumns.Location.X, iReceiverMaxY / 1.35)
        Else
            lblCarryColumns.Location = New Point(lblCarryColumns.Location.X, iReceiverLabelMaxY)
            ucrReceiverCarryColumns.Location = New Point(ucrReceiverCarryColumns.Location.X, iReceiverMaxY)
        End If
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewDFName.ControlContentsChanged, ucrReceiverFactorToUnstackby.ControlContentsChanged, ucrReceiverCarryColumns.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Public Property lstScriptsRCodeStructure As List(Of RCodeStructure)
        Get
            Return lstRCodeStructure
        End Get
        Set(lstNewRCodeStructure As List(Of RCodeStructure))
            lstRCodeStructure = lstNewRCodeStructure
            bReset = True
        End Set
    End Property
End Class