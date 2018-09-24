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

Public Class dlgFindNonnumericValues
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    ' Private clsRSyntax As RSyntax
    Private clsIsNaFunction, clsIsNaNumericFunction, clsAsNumericFunction, clsSummaryFunction As New RFunction
    Private clsNotEqualToOperator As New ROperator

    Private Sub dlgShowNonnumericValues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverColumn.Selector = ucrSelectorShowNonNumericValues
        ucrSelectorShowNonNumericValues.bUseCurrentFilter = False

        ucrReceiverColumn.SetParameter(New RParameter("x", 1))
        ucrReceiverColumn.SetParameterIsRFunction()
        ucrReceiverColumn.SetExcludedDataTypes({"numeric"})

        ucrSaveLogicalColumn.SetPrefix("nonnum")
        ucrSaveLogicalColumn.SetSaveTypeAsColumn()
        ucrSaveLogicalColumn.SetDataFrameSelector(ucrSelectorShowNonNumericValues.ucrAvailableDataFrames)
        ucrSaveLogicalColumn.SetIsTextBox()
        ucrSaveLogicalColumn.SetLabelText("Logical column:")

        ucrChkShowSummary.SetText("Display summary")
        ucrChkShowSummary.AddRSyntaxContainsFunctionNamesCondition(True, {"summary"})
        ucrChkShowSummary.AddRSyntaxContainsFunctionNamesCondition(False, {"summary"}, False)

        ucrChkFilter.SetText("Filter to non-numeric cases")
    End Sub

    Private Sub SetDefaults()
        clsIsNaFunction = New RFunction
        clsIsNaNumericFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsNotEqualToOperator = New ROperator

        ucrReceiverColumn.SetMeAsReceiver()
        ucrSaveLogicalColumn.Reset()

        ucrSelectorShowNonNumericValues.Reset()

        clsIsNaFunction.SetRCommand("is.na")

        clsNotEqualToOperator.SetOperation("!=")
        clsNotEqualToOperator.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsIsNaFunction, iPosition:=0)
        clsNotEqualToOperator.AddParameter("right", bIncludeArgumentName:=False, clsRFunctionParameter:=clsIsNaNumericFunction, iPosition:=1)

        clsIsNaNumericFunction.SetRCommand("is.na")
        clsIsNaNumericFunction.AddParameter("numeric", bIncludeArgumentName:=False, clsRFunctionParameter:=clsAsNumericFunction)

        clsAsNumericFunction.SetRCommand("as.numeric")

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.iCallType = 2
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseROperator(clsNotEqualToOperator)
        ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverColumn.AddAdditionalCodeParameterPair(clsSummaryFunction, New RParameter("object", 1), iAdditionalPairNo:=1)
        ucrReceiverColumn.AddAdditionalCodeParameterPair(clsAsNumericFunction, New RParameter("x", 1), iAdditionalPairNo:=2)
        ucrReceiverColumn.SetRCode(clsIsNaFunction, bReset)
        ucrSaveLogicalColumn.SetRCode(clsNotEqualToOperator, bReset)
        ucrChkShowSummary.SetRSyntax(ucrBase.clsRsyntax, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverColumn.IsEmpty AndAlso ucrSaveLogicalColumn.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrChkShowSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkShowSummary.ControlValueChanged
        If ucrChkShowSummary.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)
        End If
    End Sub

    Private Sub ucrReceiverColumn_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveLogicalColumn.ControlContentsChanged, ucrReceiverColumn.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class