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

Imports instat
Imports instat.Translations

Public Class dlgCompareTreatmentLines
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private bResetBoxLayerSubdialog As Boolean = True
    Private bDefaultsSet As Boolean = True
    Private bUpdating As Boolean = False
    Private clsCompareLines As New clsCompareTwoOptionsLines
    Private clsComparePoints As New clsCompareTwoOptionsPoints

    Private lstLinesOnlyControls As New List(Of ucrCore)
    Private lstPointsOnlyControls As New List(Of ucrCore)

    ' String constants for Context variables
    Public strFacetRow As String = "Facet Row"
    Public strFacetCol As String = "Facet Column"
    Public strColour As String = "Colour"
    Public strNone As String = "None"

    Private Sub dlgCompareTreatmentLines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 585
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorPlot.SetParameter(New RParameter("data", 0))
        ucrSelectorPlot.SetParameterIsrfunction()

        ucrReceiverMeasurement.SetParameter(New RParameter("y", 1))
        ucrReceiverMeasurement.Selector = ucrSelectorPlot
        ucrReceiverMeasurement.SetIncludedDataTypes({"numeric"})
        ucrReceiverMeasurement.strSelectorHeading = "Measurements"
        ucrReceiverMeasurement.SetParameterIsString()
        ucrReceiverMeasurement.bWithQuotes = False
        ucrReceiverMeasurement.SetOptionsByContextTypesAllMeasurements()

        ucrReceiverOption.SetParameter(New RParameter("right", 1))
        ucrReceiverOption.Selector = ucrSelectorPlot
        ucrReceiverOption.SetIncludedDataTypes({"factor"})
        ucrReceiverOption.strSelectorHeading = "Options"
        ucrReceiverOption.SetParameterIsString()
        ucrReceiverOption.bWithQuotes = False
        ucrReceiverOption.SetOptionsByContextTypesAllOptions()

        ucrInputFactorOption1.SetParameter(New RParameter("left", 0))
        ucrInputFactorOption1.SetFactorReceiver(ucrReceiverOption)
        ucrInputFactorOption1.AddQuotesIfUnrecognised = False
        ucrInputFactorOption1.strQuotes = "`"

        ucrInputFactorOption2.SetParameter(New RParameter("right", 1))
        ucrInputFactorOption2.SetFactorReceiver(ucrReceiverOption)
        ucrInputFactorOption2.AddQuotesIfUnrecognised = False
        ucrInputFactorOption2.strQuotes = "`"

        ucrReceiverID.SetParameter(New RParameter("left", 0))
        ucrReceiverID.Selector = ucrSelectorPlot
        ucrReceiverID.SetParameterIsString()
        ucrReceiverID.bWithQuotes = False
        ucrReceiverID.strSelectorHeading = "IDs"
        ucrReceiverID.SetOptionsByContextTypesAllIDs()

        clsCompareLines.clsColourParam.SetArgumentName("colour")
        clsCompareLines.clsColourParam.SetArgumentValue(clsCompareLines.strDiffCode)
        clsCompareLines.clsColourParam.Position = 1

        ucrChkColourByDifference.SetText("Colour Lines by Difference")
        ucrChkColourByDifference.SetParameter(clsCompareLines.clsColourParam)
        ucrChkColourByDifference.bAddRemoveParameter = True
        ucrChkColourByDifference.bChangeParameterValue = False
        ucrChkColourByDifference.AddParameterPresentCondition(True, "colour")
        ucrChkColourByDifference.AddParameterPresentCondition(False, "colour", False)

        ucrChkIncludeBoxplot.SetText("Include Boxplot")
        ucrChkIncludeBoxplot.bAddRemoveParameter = True
        ucrChkIncludeBoxplot.bChangeParameterValue = False
        ucrChkIncludeBoxplot.AddParameterPresentCondition(True, "geom_boxplot")
        ucrChkIncludeBoxplot.AddParameterPresentCondition(False, "geom_boxplot", False)
        ucrChkIncludeBoxplot.AddToLinkedControls(ucrNudTransparency, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeBoxplot.AddToLinkedControls(ucrChkBoxplotOnlyComplete, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrNudTransparency.SetLinkedDisplayControl(lblTransparency)
        ucrNudTransparency.SetParameter(New RParameter("alpha", iNewPosition:=1))
        ucrNudTransparency.SetMinMax(0, 1)
        ucrNudTransparency.DecimalPlaces = 2

        ucrChkBoxplotOnlyComplete.SetText("Complete records only")
        ucrChkBoxplotOnlyComplete.bAddRemoveParameter = True
        ucrChkBoxplotOnlyComplete.bChangeParameterValue = False
        ucrChkBoxplotOnlyComplete.AddParameterPresentCondition(True, "right")
        ucrChkBoxplotOnlyComplete.AddParameterPresentCondition(False, "right", False)

        ucrChkIncludeHline.SetText("Include Horizontal Line")
        ucrChkIncludeHline.bAddRemoveParameter = True
        ucrChkIncludeHline.bChangeParameterValue = False
        ucrChkIncludeHline.AddParameterPresentCondition(True, "geom_hline")
        ucrChkIncludeHline.AddParameterPresentCondition(False, "geom_hline", False)
        ucrChkIncludeHline.AddToLinkedControls(ucrInputHlineValue, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputHlineValue.SetParameter(New RParameter("yintercept", iNewPosition:=2))
        ucrInputHlineValue.SetLinkedDisplayControl(lblHlineValue)
        ucrInputHlineValue.SetValidationTypeAsNumeric()
        ucrInputHlineValue.AddQuotesIfUnrecognised = False

        ucrReceiverContext1.Selector = ucrSelectorPlot
        ucrReceiverContext1.SetParameterIsString()
        ucrReceiverContext1.SetParameter(New RParameter("1", iNewPosition:=1))
        ucrReceiverContext1.bWithQuotes = False
        ucrReceiverContext1.strSelectorHeading = "Contexts,Options,Blocks"
        ucrReceiverContext1.SetOptionsByContextTypesAllOptionsContextsBlockings()

        ucrReceiverContext2.Selector = ucrSelectorPlot
        ucrReceiverContext2.SetParameterIsString()
        ucrReceiverContext2.SetParameter(New RParameter("2", iNewPosition:=2))
        ucrReceiverContext2.bWithQuotes = False
        ucrReceiverContext2.strSelectorHeading = "Contexts,Options,Blocks"
        ucrReceiverContext2.SetOptionsByContextTypesAllOptionsContextsBlockings()

        ucrInputContext1.SetItems({strFacetRow, strFacetCol, strNone})
        ucrInputContext1.SetDropDownStyleAsNonEditable()

        ucrInputContext2.SetItems({strFacetRow, strFacetCol, strNone})
        ucrInputContext2.SetDropDownStyleAsNonEditable()

        ucrSavePlot.SetPrefix("two_options")
        ucrSavePlot.SetIsComboBox()
        ucrSavePlot.SetCheckBoxText("Save Graph")
        ucrSavePlot.SetSaveTypeAsGraph()
        ucrSavePlot.SetDataFrameSelector(ucrSelectorPlot.ucrAvailableDataFrames)
        ucrSavePlot.SetAssignToIfUncheckedValue("last_graph")

        'rdoPoints controls
        ucrReceiverContext3.Selector = ucrSelectorPlot
        ucrReceiverContext3.SetParameterIsString()
        ucrReceiverContext3.SetParameter(New RParameter("3", iNewPosition:=3))
        ucrReceiverContext3.bWithQuotes = False
        ucrReceiverContext3.strSelectorHeading = "Contexts,Options,Blocks"
        ucrReceiverContext3.SetOptionsByContextTypesAllOptionsContextsBlockings()
        ucrReceiverContext3.SetLinkedDisplayControl(lblContext3)

        ucrInputContext3.SetItems({strFacetRow, strFacetCol, strColour, strNone})
        ucrInputContext3.SetDropDownStyleAsNonEditable()

        ucrChkIncludeSmoothLine.SetText("Include Smooth Line")
        ucrChkIncludeSmoothLine.AddParameterPresentCondition(True, "geom_smooth")
        ucrChkIncludeSmoothLine.AddParameterPresentCondition(False, "geom_smooth", False)

        ' Disabled until working
        ucrChkIncludeMeanLine.Enabled = False
        ucrChkIncludeMeanLine.SetText("Include Mean Line")
        ucrChkIncludeMeanLine.AddParameterPresentCondition(True, "geom_ablinemean")
        ucrChkIncludeMeanLine.AddParameterPresentCondition(False, "geom_ablinemean", False)

        ucrPnlCompareType.AddRadioButton(rdoLines)
        ucrPnlCompareType.AddRadioButton(rdoPoints)
        ucrPnlCompareType.AddParameterIsRFunctionCondition(rdoLines, "data", False)
        ucrPnlCompareType.AddParameterIsRFunctionCondition(rdoPoints, "data")

        lstLinesOnlyControls.AddRange({ucrChkColourByDifference, ucrChkIncludeBoxplot, ucrChkIncludeHline})
        lstPointsOnlyControls.AddRange({ucrChkIncludeSmoothLine, ucrChkIncludeMeanLine, ucrInputContext3, ucrReceiverContext3})

        For i As Integer = 0 To lstLinesOnlyControls.Count - 1
            ucrPnlCompareType.AddToLinkedControls(lstLinesOnlyControls(i), {rdoLines}, bNewLinkedHideIfParameterMissing:=True)
        Next
        For i As Integer = 0 To lstPointsOnlyControls.Count - 1
            ucrPnlCompareType.AddToLinkedControls(lstPointsOnlyControls(i), {rdoPoints}, bNewLinkedHideIfParameterMissing:=True)
        Next
    End Sub

    Private Sub SetDefaults()
        bDefaultsSet = False
        bUpdating = True
        clsCompareLines.SetDefaults()
        clsComparePoints.SetDefaults()

        clsComparePoints.clsFacetColOp = clsCompareLines.clsFacetColOp
        clsComparePoints.clsFacetRowOp = clsCompareLines.clsFacetRowOp
        clsComparePoints.clsFacetOp = clsCompareLines.clsFacetOp
        clsComparePoints.clsRFacetFunction = clsCompareLines.clsRFacetFunction

        ucrSelectorPlot.Reset()
        ucrSelectorPlot.SetGgplotFunction(clsCompareLines.clsBaseOperator)

        ucrSavePlot.Reset()
        sdgPlots.Reset()

        bResetSubdialog = True
        bResetBoxLayerSubdialog = True

        ' TODO temporary until can link these controls correctly
        ucrInputContext1.SetName(strNone)
        ucrInputContext2.SetName(strNone)
        ucrInputContext3.SetName(strNone)

        SetDataAssignTo()

        clsCompareLines.clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsCompareLines.clsBaseOperator)
        bDefaultsSet = True
        AutoAddDefaults()
        ucrReceiverMeasurement.SetMeAsReceiver()
        bUpdating = False
    End Sub

    Private Sub SetRCodeforControls(bResetControls As Boolean)
        bUpdating = True
        clsComparePoints.SetRCodeforControls(ucrSelectorPlot, ucrReceiverOption, ucrReceiverID, ucrReceiverMeasurement, ucrInputFactorOption1, ucrInputFactorOption2, ucrChkColourByDifference, ucrChkIncludeBoxplot, ucrNudTransparency, ucrChkBoxplotOnlyComplete, ucrChkIncludeHline, ucrInputHlineValue, ucrSavePlot, ucrReceiverContext1, ucrReceiverContext2, ucrReceiverContext3, ucrChkIncludeSmoothLine, ucrChkIncludeMeanLine, bResetControls)
        clsCompareLines.SetRCodeforControls(ucrSelectorPlot, ucrReceiverOption, ucrReceiverID, ucrReceiverMeasurement, ucrInputFactorOption1, ucrInputFactorOption2, ucrChkColourByDifference, ucrChkIncludeBoxplot, ucrNudTransparency, ucrChkBoxplotOnlyComplete, ucrChkIncludeHline, ucrInputHlineValue, ucrSavePlot, ucrReceiverContext1, ucrReceiverContext2, ucrReceiverContext3, ucrChkIncludeSmoothLine, ucrChkIncludeMeanLine, bResetControls)
        ucrPnlCompareType.SetRCode(ucrBase.clsRsyntax.clsBaseOperator.GetParameter("ggplot").clsArgumentCodeStructure)
        bUpdating = False
        UpdateContextParameters()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverMeasurement.IsEmpty() AndAlso Not ucrReceiverOption.IsEmpty() AndAlso Not ucrInputFactorOption1.IsEmpty() AndAlso Not ucrInputFactorOption2.IsEmpty() AndAlso ucrSavePlot.IsComplete() AndAlso Not ucrReceiverID.IsEmpty() AndAlso (Not ucrChkIncludeBoxplot.Checked OrElse ucrNudTransparency.GetText() <> "") AndAlso (Not ucrChkIncludeHline.Checked OrElse Not ucrInputHlineValue.IsEmpty()) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorPlot.ControlValueChanged
        SetDataAssignTo()
        AutoAddDefaults()
    End Sub

    Private Sub ucrReceiverMeasurement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMeasurement.ControlValueChanged
        If ucrReceiverMeasurement.IsEmpty() Then
            clsCompareLines.clsDCast.RemoveParameterByName("value.var")
            clsComparePoints.clsDCast.RemoveParameterByName("value.var")
        Else
            clsCompareLines.clsDCast.AddParameter("value.var", ucrReceiverMeasurement.GetVariableNames(), iPosition:=7)
            clsComparePoints.clsDCast.AddParameter("value.var", ucrReceiverMeasurement.GetVariableNames(), iPosition:=7)
        End If
    End Sub

    Private Sub ucrReceiverID_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverID.ControlValueChanged
        If ucrReceiverID.IsEmpty() Then
            clsCompareLines.clsLeftJoin.RemoveParameterByName("by")
        Else
            clsCompareLines.clsLeftJoin.AddParameter("by", ucrReceiverID.GetVariableNames(), iPosition:=2)
        End If
    End Sub

    Private Sub InputFactorTreatmentControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFactorOption1.ControlValueChanged, ucrInputFactorOption2.ControlValueChanged
        If Not ucrInputFactorOption1.IsEmpty() AndAlso Not ucrInputFactorOption2.IsEmpty Then
            clsCompareLines.clsFilterInOperator.AddParameter("1", "c(" & Chr(34) & ucrInputFactorOption1.GetText().Trim("`") & Chr(34) & ", " & Chr(34) & ucrInputFactorOption2.GetText().Trim("`") & Chr(34) & ")", iPosition:=1)
            clsComparePoints.clsRaesGlobalFunction.AddParameter("y", ucrInputFactorOption1.GetText(), iPosition:=1)
            clsComparePoints.clsRaesGlobalFunction.AddParameter("x", ucrInputFactorOption2.GetText(), iPosition:=0)
            clsComparePoints.clsMean.AddParameter("x", ucrInputFactorOption1.GetText() & "-" & ucrInputFactorOption2.GetText(), iPosition:=0)
        Else
            clsCompareLines.clsFilterInOperator.RemoveParameterByName("x")
            clsComparePoints.clsRaesGlobalFunction.RemoveParameterByName("x")
            clsComparePoints.clsRaesGlobalFunction.RemoveParameterByName("y")
            clsComparePoints.clsMean.RemoveParameterByName("x")
        End If
    End Sub

    Private Sub ContextControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputContext1.ControlValueChanged, ucrInputContext2.ControlValueChanged, ucrInputContext3.ControlValueChanged, ucrReceiverContext1.ControlValueChanged, ucrReceiverContext2.ControlValueChanged, ucrReceiverContext3.ControlValueChanged
        If TypeOf ucrChangedControl Is ucrInputComboBox Then
            UpdateContextParameters(ucrChangedControl)
        Else
            UpdateContextParameters()
        End If
    End Sub

    Private Sub UpdateContextParameters(Optional ucrChangedControl As ucrInputComboBox = Nothing)
        Dim iRowVars As Integer = 0
        Dim iColVars As Integer = 0
        Dim strChangedValue As String

        If Not bUpdating Then
            If ucrChangedControl IsNot Nothing Then
                strChangedValue = ucrChangedControl.GetText()
                If strChangedValue = strColour Then
                    For Each ucrTemp As ucrInputComboBox In {ucrInputContext1, ucrInputContext2, ucrInputContext3}
                        If ucrTemp.GetText() = strChangedValue AndAlso Not ucrTemp.Equals(ucrChangedControl) Then
                            bUpdating = True
                            ucrTemp.SetName(strNone)
                            bUpdating = False
                        End If
                    Next
                End If
            End If
            clsCompareLines.clsFacetColOp.ClearParameters()
            clsCompareLines.clsFacetRowOp.ClearParameters()
            clsCompareLines.clsFacetOp.ClearParameters()
            clsCompareLines.clsRFacetFunction.RemoveParameterByName("dir")
            clsComparePoints.clsPointAes.RemoveParameterByName("colour")

            If Not ucrReceiverContext1.IsEmpty() Then
                Select Case ucrInputContext1.GetText()
                    Case strFacetRow
                        clsCompareLines.clsFacetRowOp.AddParameter(iRowVars, ucrReceiverContext1.GetVariableNames(False), iPosition:=iRowVars)
                        iRowVars = iRowVars + 1
                    Case strFacetCol
                        clsCompareLines.clsFacetColOp.AddParameter(iColVars, ucrReceiverContext1.GetVariableNames(False), iPosition:=iColVars)
                        iColVars = iColVars + 1
                    Case strColour
                        clsComparePoints.clsPointAes.AddParameter("colour", ucrReceiverContext1.GetVariableNames(False), iPosition:=3)
                End Select
            End If
            If Not ucrReceiverContext2.IsEmpty() Then
                Select Case ucrInputContext2.GetText()
                    Case strFacetRow
                        clsCompareLines.clsFacetRowOp.AddParameter(iRowVars, ucrReceiverContext2.GetVariableNames(False), iPosition:=iRowVars)
                        iRowVars = iRowVars + 1
                    Case strFacetCol
                        clsCompareLines.clsFacetColOp.AddParameter(iColVars, ucrReceiverContext2.GetVariableNames(False), iPosition:=iColVars)
                        iColVars = iColVars + 1
                    Case strColour
                        clsComparePoints.clsPointAes.AddParameter("colour", ucrReceiverContext2.GetVariableNames(False), iPosition:=3)
                End Select
            End If
            If Not ucrReceiverContext3.IsEmpty() Then
                Select Case ucrInputContext3.GetText()
                    Case strFacetRow
                        clsCompareLines.clsFacetRowOp.AddParameter(iRowVars, ucrReceiverContext3.GetVariableNames(False), iPosition:=iRowVars)
                        iRowVars = iRowVars + 1
                    Case strFacetCol
                        clsCompareLines.clsFacetColOp.AddParameter(iColVars, ucrReceiverContext3.GetVariableNames(False), iPosition:=iColVars)
                        iColVars = iColVars + 1
                    Case strColour
                        clsComparePoints.clsPointAes.AddParameter("colour", ucrReceiverContext3.GetVariableNames(False), iPosition:=3)
                End Select
            End If
            clsCompareLines.clsRFacetFunction.SetRCommand("facet_wrap")
            If (rdoLines.Checked AndAlso iRowVars = 2) OrElse (rdoPoints.Checked AndAlso iRowVars = 3) Then
                clsCompareLines.clsFacetOp.AddParameter("left", "", iPosition:=0)
                clsCompareLines.clsFacetOp.AddParameter("right", clsROperatorParameter:=clsCompareLines.clsFacetRowOp, iPosition:=1)
                clsCompareLines.clsRFacetFunction.AddParameter("dir", Chr(34) & "h" & Chr(34))
            ElseIf (rdoLines.Checked AndAlso iColVars = 2) OrElse (rdoPoints.Checked AndAlso iColVars = 3) Then
                clsCompareLines.clsFacetOp.AddParameter("left", "", iPosition:=0)
                clsCompareLines.clsFacetOp.AddParameter("right", clsROperatorParameter:=clsCompareLines.clsFacetColOp, iPosition:=1)
                clsCompareLines.clsRFacetFunction.AddParameter("dir", Chr(34) & "v" & Chr(34))
            ElseIf iRowVars >= 1 AndAlso iColVars >= 1 Then
                clsCompareLines.clsFacetOp.AddParameter("left", clsROperatorParameter:=clsCompareLines.clsFacetRowOp, iPosition:=0)
                clsCompareLines.clsFacetOp.AddParameter("right", clsROperatorParameter:=clsCompareLines.clsFacetColOp, iPosition:=1)
                clsCompareLines.clsRFacetFunction.SetRCommand("facet_grid")
            ElseIf iRowVars >= 1 AndAlso iColVars = 0 Then
                clsCompareLines.clsFacetOp.AddParameter("left", "", iPosition:=0)
                clsCompareLines.clsFacetOp.AddParameter("right", clsROperatorParameter:=clsCompareLines.clsFacetRowOp, iPosition:=1)
                clsCompareLines.clsRFacetFunction.AddParameter("dir", Chr(34) & "h" & Chr(34))
            ElseIf iColVars >= 1 AndAlso iRowVars = 0 Then
                clsCompareLines.clsFacetOp.AddParameter("left", "", iPosition:=0)
                clsCompareLines.clsFacetOp.AddParameter("right", clsROperatorParameter:=clsCompareLines.clsFacetColOp, iPosition:=1)
                clsCompareLines.clsRFacetFunction.AddParameter("dir", Chr(34) & "v" & Chr(34))
            End If
            If iRowVars > 0 OrElse iColVars > 0 Then
                clsCompareLines.clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsCompareLines.clsRFacetFunction, iPosition:=10)
                clsComparePoints.clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsCompareLines.clsRFacetFunction, iPosition:=10)
            Else
                clsCompareLines.clsBaseOperator.RemoveParameterByName("facets")
                clsComparePoints.clsBaseOperator.RemoveParameterByName("facets")
            End If
        End If
    End Sub

    Private Sub ucrChkIncludeBoxplot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeBoxplot.ControlValueChanged
        If ucrChkIncludeBoxplot.Checked Then
            clsCompareLines.clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsCompareLines.clsBoxplotGeom, iPosition:=3)
        Else
            clsCompareLines.clsBaseOperator.RemoveParameterByName("geom_boxplot")
        End If
    End Sub

    Private Sub ucrChkHline_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeHline.ControlValueChanged
        If ucrChkIncludeHline.Checked Then
            clsCompareLines.clsBaseOperator.AddParameter("geom_hline", clsRFunctionParameter:=clsCompareLines.clsHlineGeom, iPosition:=4)
        Else
            clsCompareLines.clsBaseOperator.RemoveParameterByName("geom_hline")
        End If
    End Sub

    Private Sub ucrReceiverMeasurement_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMeasurement.ControlContentsChanged, ucrReceiverOption.ControlContentsChanged, ucrInputFactorOption1.ControlContentsChanged, ucrInputFactorOption2.ControlContentsChanged, ucrReceiverID.ControlContentsChanged, ucrChkIncludeBoxplot.ControlContentsChanged, ucrNudTransparency.ControlContentsChanged, ucrChkIncludeHline.ControlContentsChanged, ucrInputHlineValue.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Public Sub SetDataAssignTo()
        If ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            clsCompareLines.clsFilterMissingOperator.SetAssignTo(ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_with_diff")
            clsComparePoints.clsDCast.AddParameter("data", clsRFunctionParameter:=ucrSelectorPlot.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
            clsComparePoints.clsDCast.SetAssignTo(ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_unstacked")
        Else
            clsCompareLines.clsFilterMissingOperator.RemoveAssignTo()
            clsComparePoints.clsDCast.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrChkBoxplotOnlyComplete_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBoxplotOnlyComplete.ControlValueChanged
        If ucrChkBoxplotOnlyComplete.Checked Then
            clsCompareLines.clsFilterMissingOperator.AddParameter("right", clsRFunctionParameter:=clsCompareLines.clsFilterMissingFunction, iPosition:=1)
        Else
            clsCompareLines.clsFilterMissingOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub AutoAddDefaults()
        If bDefaultsSet Then
            ucrReceiverMeasurement.AddItemsWithMetadataProperty(ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"measurement_1_label"})
            ucrReceiverOption.AddItemsWithMetadataProperty(ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"option_1_label"})
            ucrReceiverID.AddItemsWithMetadataProperty(ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"id_1_label"})
            ucrReceiverContext1.AddItemsWithMetadataProperty(ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_1_label"})
            ucrReceiverContext2.AddItemsWithMetadataProperty(ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_2_label"})
        End If
    End Sub

    Private Sub ucrPnlCompareType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCompareType.ControlValueChanged
        Dim strContext1 As String
        Dim strContext2 As String
        Dim strContext3 As String

        bUpdating = True
        strContext1 = ucrInputContext1.GetText()
        strContext2 = ucrInputContext2.GetText()
        strContext3 = ucrInputContext3.GetText()
        If rdoLines.Checked Then
            ucrBase.clsRsyntax.SetBaseROperator(clsCompareLines.clsBaseOperator)
            ucrInputContext1.SetItems({strFacetRow, strFacetCol, strNone})
            ucrInputContext2.SetItems({strFacetRow, strFacetCol, strNone})
        ElseIf rdoPoints.Checked Then
            ucrBase.clsRsyntax.SetBaseROperator(clsComparePoints.clsBaseOperator)
            ucrInputContext1.SetItems({strFacetRow, strFacetCol, strColour, strNone})
            ucrInputContext2.SetItems({strFacetRow, strFacetCol, strColour, strNone})
        End If
        If rdoLines.Checked AndAlso strContext1 = strColour Then
            ucrInputContext1.SetName(strNone)
        Else
            ucrInputContext1.SetName(strContext1)
        End If
        If rdoLines.Checked AndAlso strContext2 = strColour Then
            ucrInputContext2.SetName(strNone)
        Else
            ucrInputContext2.SetName(strContext2)
        End If
        ucrInputContext3.SetName(strContext3)
        bUpdating = False
        'UpdateContextParameters()
    End Sub

    Private Sub ucrChkSmoothLine_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeSmoothLine.ControlValueChanged
        If ucrChkIncludeSmoothLine.Checked Then
            clsComparePoints.clsBaseOperator.AddParameter("geom_smooth", clsRFunctionParameter:=clsComparePoints.clsSmoothGeom, iPosition:=5)
        Else
            clsComparePoints.clsBaseOperator.RemoveParameterByName("geom_smooth")
        End If
    End Sub

    Private Sub ucrChkIncludeMeanLine_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeMeanLine.ControlValueChanged
        If ucrChkIncludeMeanLine.Checked Then
            clsComparePoints.clsBaseOperator.AddParameter("geom_ablinemean", clsRFunctionParameter:=clsComparePoints.clsAblineMeanDiffGeom, iPosition:=5)
        Else
            clsComparePoints.clsBaseOperator.RemoveParameterByName("geom_ablinemean")
        End If
    End Sub
End Class