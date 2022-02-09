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

Public Class dlgCompareColumns

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private iDialogHeight As Integer
    Private iBaseMaxY
    Private clsCompareColumnsFunction, clsAbsoluteFunction As New RFunction
    Private clsFirstAsCharacterFunction, clsSecondAsCharacterFunction, clsSummaryFunction As New RFunction
    Private clsYinXOperator, clsIsEqualToOperator, clsSubtractOperator, clsLessorEqualToOperator As New ROperator
    Private clsDummyOperator As ROperator

    Private Sub dlgCompareColumns_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            iDialogHeight = Me.Height
            iBaseMaxY = ucrBase.Location.Y
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
        Dim dctTolerance As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = 546

        ucrPnlOptions.AddRadioButton(rdoByRow)
        ucrPnlOptions.AddRadioButton(rdoByValue)

        ucrPnlOptions.AddToLinkedControls({ucrChkSort, ucrChkFirstNotSecond}, {rdoByValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFirstNotSecond.SetLinkedDisplayControl(grpComparisions)

        ucrReceiverFirst.SetParameter(New RParameter("x", 0))
        ucrReceiverFirst.Selector = ucrSelectorCompareColumns
        ucrReceiverFirst.SetParameterIsRFunction()
        ucrReceiverFirst.bAttachedToPrimaryDataFrame = False
        ucrReceiverFirst.bOnlyLinkedToPrimaryDataFrames = False
        ucrReceiverFirst.bIncludeDataFrameInAssignment = True

        ucrReceiverSecond.SetParameter(New RParameter("y", 1))
        ucrReceiverSecond.Selector = ucrSelectorCompareColumns
        ucrReceiverSecond.SetParameterIsRFunction()
        ucrReceiverSecond.bAttachedToPrimaryDataFrame = False
        ucrReceiverSecond.bOnlyLinkedToPrimaryDataFrames = False
        ucrReceiverSecond.bIncludeDataFrameInAssignment = True

        ucrInputTolerance.SetParameter(New RParameter("tol", 1))
        dctTolerance.Add("0", "0")
        dctTolerance.Add("0.005", "0.005")
        dctTolerance.Add("0.0000000001", "0.0000000001")
        ucrInputTolerance.SetItems(dctTolerance)
        ucrInputTolerance.SetValidationTypeAsNumeric()
        ucrInputTolerance.AddQuotesIfUnrecognised = False
        ucrInputTolerance.SetLinkedDisplayControl(lblTolerance)
        ucrInputTolerance.bAllowNonConditionValues = True

        ucrChkSort.SetParameter(New RParameter("sort_values", 3), bNewChangeParameterValue:=True)
        ucrChkSort.SetText("Sort values")
        ucrChkSort.SetRDefault("TRUE")

        ucrChkFirstNotSecond.SetParameter(New RParameter("firstnotsecond", 4), bNewChangeParameterValue:=True)
        ucrChkFirstNotSecond.SetText("Values in first column not in second")
        ucrChkFirstNotSecond.SetRDefault("TRUE")

        ucrChkSecondNotFirst.SetParameter(New RParameter("secondnotfirst", 5), bNewChangeParameterValue:=True)
        ucrChkSecondNotFirst.SetText("Values in second column not in first")
        ucrChkSecondNotFirst.SetRDefault("TRUE")

        ucrChkIntersection.SetParameter(New RParameter("display_intersection", 6), bNewChangeParameterValue:=True)
        ucrChkIntersection.SetText("Values in both columns (intersection)")
        ucrChkIntersection.SetRDefault("FALSE")

        ucrChkUnion.SetParameter(New RParameter("display_union", 7), bNewChangeParameterValue:=True)
        ucrChkUnion.SetText("Values in either column (union)")
        ucrChkUnion.SetRDefault("FALSE")

        ucrChkAllValues.SetParameter(New RParameter("display_values", 8), bNewChangeParameterValue:=True)
        ucrChkAllValues.SetText("All values if columns are equal")
        ucrChkAllValues.SetRDefault("TRUE")

        ucrSaveLogical.SetPrefix("compare")
        ucrSaveLogical.SetSaveTypeAsColumn()
        ucrSaveLogical.SetDataFrameSelector(ucrSelectorCompareColumns.ucrAvailableDataFrames)
        ucrSaveLogical.SetIsComboBox()

        ucrSaveLogical.SetLabelText("New Column Name:")

        ucrSaveLogical.SetLabelText("Save result for second column:")
        ucrSaveLogical.setLinkedReceiver(ucrReceiverSecond)

        ucrBase.clsRsyntax.iCallType = 2
    End Sub

    Private Sub SetDefaults()
        clsCompareColumnsFunction = New RFunction
        clsAbsoluteFunction = New RFunction
        clsFirstAsCharacterFunction = New RFunction
        clsSecondAsCharacterFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsYinXOperator = New ROperator
        clsIsEqualToOperator = New ROperator
        clsSubtractOperator = New ROperator
        clsLessorEqualToOperator = New ROperator
        clsDummyOperator = New ROperator

        ucrBase.clsRsyntax.ClearCodes()
        rdoByRow.Checked = True

        ucrSelectorCompareColumns.Reset()
        ucrReceiverFirst.SetMeAsReceiver()
        ucrSaveLogical.Reset()

        clsCompareColumnsFunction.SetRCommand("compare_columns")
        clsYinXOperator.SetOperation("%in%")

        clsFirstAsCharacterFunction.SetRCommand("as.character")
        clsSecondAsCharacterFunction.SetRCommand("as.character")

        clsIsEqualToOperator.SetOperation("==")

        clsSubtractOperator.SetOperation("-")

        clsAbsoluteFunction.SetRCommand("abs")
        clsAbsoluteFunction.AddParameter("x", clsROperatorParameter:=clsSubtractOperator, iPosition:=0)

        clsLessorEqualToOperator.SetOperation("<=")
        clsLessorEqualToOperator.AddParameter("tol", 0, iPosition:=1)

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.iCallType = 2

        ucrBase.clsRsyntax.SetBaseROperator(clsDummyOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverFirst.AddAdditionalCodeParameterPair(clsYinXOperator, New RParameter("right", iNewPosition:=1), iAdditionalPairNo:=1)
        ucrReceiverFirst.AddAdditionalCodeParameterPair(clsFirstAsCharacterFunction, New RParameter("first", bNewIncludeArgumentName:=False, iNewPosition:=0), iAdditionalPairNo:=2)
        ucrReceiverFirst.AddAdditionalCodeParameterPair(clsSubtractOperator, New RParameter("first", bNewIncludeArgumentName:=False, iNewPosition:=0), iAdditionalPairNo:=3)

        ucrReceiverSecond.AddAdditionalCodeParameterPair(clsYinXOperator, New RParameter("left", iNewPosition:=0), iAdditionalPairNo:=1)
        ucrReceiverSecond.AddAdditionalCodeParameterPair(clsSecondAsCharacterFunction, New RParameter("second", bNewIncludeArgumentName:=False, iNewPosition:=1), iAdditionalPairNo:=2)
        ucrReceiverSecond.AddAdditionalCodeParameterPair(clsSubtractOperator, New RParameter("second", bNewIncludeArgumentName:=False, iNewPosition:=1), iAdditionalPairNo:=3)

        ucrReceiverFirst.SetRCode(clsCompareColumnsFunction, bReset)
        ucrReceiverSecond.SetRCode(clsCompareColumnsFunction, bReset)
        ucrChkSort.SetRCode(clsCompareColumnsFunction, bReset)
        ucrChkFirstNotSecond.SetRCode(clsCompareColumnsFunction, bReset)
        ucrChkSecondNotFirst.SetRCode(clsCompareColumnsFunction, bReset)
        ucrChkIntersection.SetRCode(clsCompareColumnsFunction, bReset)
        ucrChkUnion.SetRCode(clsCompareColumnsFunction, bReset)
        ucrChkAllValues.SetRCode(clsCompareColumnsFunction, bReset)
        ucrInputTolerance.SetRCode(clsLessorEqualToOperator, bReset)

        ucrSaveLogical.AddAdditionalRCode(clsLessorEqualToOperator, iAdditionalPairNo:=1)
        ucrSaveLogical.AddAdditionalRCode(clsYinXOperator, iAdditionalPairNo:=2)
        ucrSaveLogical.SetRCode(clsIsEqualToOperator, bReset)
    End Sub


    Private Sub TestOkEnabled()
        If ucrReceiverFirst.IsEmpty OrElse ucrReceiverSecond.IsEmpty OrElse Not ucrSaveLogical.IsComplete() Then
            ucrBase.OKEnabled(False)
        Else
            If ({"integer", "numeric"}.Contains(ucrReceiverFirst.strCurrDataType) AndAlso
                {"integer", "numeric"}.Contains(ucrReceiverSecond.strCurrDataType)) OrElse
                (ucrReceiverFirst.strCurrDataType = "Date" AndAlso
                ucrReceiverSecond.strCurrDataType = "Date") OrElse
                ({"factor", "character"}.Contains(ucrReceiverFirst.strCurrDataType) AndAlso
                {"factor", "character"}.Contains(ucrReceiverSecond.strCurrDataType)) OrElse
                (ucrReceiverFirst.strCurrDataType = "logical" AndAlso
                ucrReceiverSecond.strCurrDataType = "logical") Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirst.ControlContentsChanged, ucrReceiverSecond.ControlContentsChanged, ucrSaveLogical.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If rdoByValue.Checked Then
            ucrInputTolerance.Visible = False
            ucrBase.clsRsyntax.SetBaseRFunction(clsCompareColumnsFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)
            ucrBase.clsRsyntax.AddToAfterCodes(clsYinXOperator, iPosition:=1)
            Me.Size = New System.Drawing.Size(Me.Width, iDialogHeight)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY)
            ucrSaveLogical.Location = New Point(ucrSaveLogical.Location.X, iBaseMaxY / 1.07)
        ElseIf rdoByRow.Checked Then
            ucrBase.clsRsyntax.SetBaseROperator(clsDummyOperator)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsYinXOperator)
            ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=1)
            Me.Size = New System.Drawing.Size(Me.Width, iDialogHeight * 0.68)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.62)
            ucrSaveLogical.Location = New Point(ucrSaveLogical.Location.X, iBaseMaxY / 1.8)
        End If
        CheckDatatype()
    End Sub

    Private Sub CheckDatatype()
        If ucrReceiverSecond.IsEmpty OrElse ucrReceiverFirst.IsEmpty Then
            TestOkEnabled()
            Exit Sub
        Else
            If {"integer", "numeric"}.Contains(ucrReceiverFirst.strCurrDataType) AndAlso {"integer", "numeric"}.Contains(ucrReceiverSecond.strCurrDataType) Then
                If rdoByRow.Checked Then
                    ucrInputTolerance.Visible = True
                    clsLessorEqualToOperator.AddParameter("first", clsRFunctionParameter:=clsAbsoluteFunction, iPosition:=0)
                    clsLessorEqualToOperator.AddParameter("tol", "0", iPosition:=1)
                    clsSummaryFunction.AddParameter("object", clsROperatorParameter:=clsLessorEqualToOperator, iPosition:=1)
                    clsDummyOperator = clsLessorEqualToOperator
                End If
            ElseIf {"Date", "date"}.Contains(ucrReceiverFirst.strCurrDataType) AndAlso {"Date", "date"}.Contains(ucrReceiverSecond.strCurrDataType) Then
                If rdoByRow.Checked Then
                    ucrInputTolerance.Visible = True
                    clsLessorEqualToOperator.AddParameter("first", clsRFunctionParameter:=clsAbsoluteFunction, iPosition:=0)
                    clsLessorEqualToOperator.AddParameter("tol", "0", iPosition:=1)
                    clsSummaryFunction.AddParameter("object", clsROperatorParameter:=clsLessorEqualToOperator, iPosition:=1)
                    clsDummyOperator = clsLessorEqualToOperator
                End If
            ElseIf {"factor", "character"}.Contains(ucrReceiverFirst.strCurrDataType) AndAlso {"factor", "character"}.Contains(ucrReceiverSecond.strCurrDataType) Then
                If rdoByRow.Checked Then
                    ucrInputTolerance.Visible = False
                    clsIsEqualToOperator.AddParameter("first", clsRFunctionParameter:=clsFirstAsCharacterFunction, iPosition:=0)
                    clsIsEqualToOperator.AddParameter("second", clsRFunctionParameter:=clsSecondAsCharacterFunction, iPosition:=1)
                    clsSummaryFunction.AddParameter("object", clsROperatorParameter:=clsIsEqualToOperator, iPosition:=1)
                    clsDummyOperator = clsIsEqualToOperator
                End If
            ElseIf ucrReceiverFirst.strCurrDataType = "logical" AndAlso ucrReceiverSecond.strCurrDataType = "logical" Then
                If rdoByRow.Checked Then
                    ucrInputTolerance.Visible = False
                    clsIsEqualToOperator.AddParameter("first", clsRFunctionParameter:=clsFirstAsCharacterFunction, iPosition:=0)
                    clsIsEqualToOperator.AddParameter("second", clsRFunctionParameter:=clsSecondAsCharacterFunction, iPosition:=1)
                    clsSummaryFunction.AddParameter("object", clsROperatorParameter:=clsIsEqualToOperator, iPosition:=1)
                    clsDummyOperator = clsIsEqualToOperator
                End If
            Else
                MsgBox("Receivers must have the same data type, OK will not be enabled")
            End If
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverFirst_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirst.ControlValueChanged, ucrReceiverSecond.ControlValueChanged
        CheckDatatype()
    End Sub
End Class
