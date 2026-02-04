'Public Class dlgDescribeOneVariableLikertGraph

'End

' R-Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with this program. If not, see http://www.gnu.org/licenses/.

Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports instat.Translations

Public Class dlgDescribeOneVariableLikertGraph
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsLikertFunction As New RFunction
    Private clsPlotFunction As New RFunction
    Private clsSummaryFunction As New RFunction
    Private clsGridLibrary As New RFunction
    Private clsDetachGrid As New RFunction

    Private Sub dlgDescribeOneVariableLikertGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub
    Private Function GetDataFrameFunction(strDataFrame As String, strColumns As String) As RFunction
        Dim clsGetDataFrame As New RFunction
        clsGetDataFrame.SetRCommand("data_book$get_data_frame")
        clsGetDataFrame.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34))
        clsGetDataFrame.AddParameter("col_names", "c(" & strColumns & ")")
        Return clsGetDataFrame
    End Function

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 0
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ' Set up receiver for multiple variables - factors only
        ucrReceiverMultipleLikert.SetParameter(New RParameter("col_names", 1))
        ucrReceiverMultipleLikert.SetParameterIsRFunction()
        ucrReceiverMultipleLikert.Selector = ucrSelectorLikert
        ucrReceiverMultipleLikert.SetMeAsReceiver()
        ucrReceiverMultipleLikert.SetIncludedDataTypes({"factor", "ordered"})
        ucrReceiverMultipleLikert.strSelectorHeading = "Factors"

        ' Set up radio buttons for graph type
        ucrPnlGraphType.AddRadioButton(rdoBar)
        ucrPnlGraphType.AddRadioButton(rdoHeat)
        ucrPnlGraphType.AddRadioButton(rdoDensity)
        ucrPnlGraphType.AddParameterValuesCondition(rdoBar, "type", Chr(34) & "bar" & Chr(34))
        ucrPnlGraphType.AddParameterValuesCondition(rdoHeat, "type", Chr(34) & "heat" & Chr(34))
        ucrPnlGraphType.AddParameterValuesCondition(rdoDensity, "type", Chr(34) & "density" & Chr(34))

        ' Set up checkboxes
        ucrChkIncludeHistogram.SetText("Label Histogram")
        ucrChkIncludeHistogram.SetParameter(New RParameter("include.histogram", 2))
        ucrChkIncludeHistogram.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkIncludeHistogram.SetRDefault("FALSE")

        ucrChkCentre.SetText("Specify Centre")
        ucrNudCentre.SetParameter(New RParameter("center", 3))
        ucrNudCentre.SetMinMax(1.5, 3.5)
        ucrNudCentre.Increment = 0.5
        ucrNudCentre.DecimalPlaces = 1
        ucrNudCentre.SetRDefault(2.5)
        ucrChkCentre.AddToLinkedControls(ucrNudCentre, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkWrap.SetText("Label Width")
        ucrNudWrap.SetParameter(New RParameter("wrap", 4))
        ucrNudWrap.SetMinMax(10, 100)
        ucrNudWrap.Increment = 1
        ucrNudWrap.SetRDefault(50)
        ucrChkWrap.AddToLinkedControls(ucrNudWrap, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ' Set up save control for graph
        ucrSaveGraph.SetPrefix("likert_graph")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorLikert.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
        ucrSaveGraph.SetCheckBoxText("Store Graph")

        ' Set up receiver for summary
        ucrReceiverMultipleLikertSummary.SetParameter(New RParameter("col_names", 1))
        ucrReceiverMultipleLikertSummary.SetParameterIsRFunction()
        ucrReceiverMultipleLikertSummary.Selector = ucrSelectorLikertSummary
        ucrReceiverMultipleLikertSummary.SetMeAsReceiver()
        ucrReceiverMultipleLikertSummary.SetIncludedDataTypes({"factor", "ordered"})
        ucrReceiverMultipleLikertSummary.strSelectorHeading = "Factors"

        ' Set up save control for summary
        ucrSaveSummary.SetPrefix("likert_summary")
        ucrSaveSummary.SetSaveType(RObjectTypeLabel.Summary, strRObjectFormat:=RObjectFormat.Text)
        ucrSaveSummary.SetDataFrameSelector(ucrSelectorLikertSummary.ucrAvailableDataFrames)
        ucrSaveSummary.SetAssignToIfUncheckedValue("last_summary")
        ucrSaveSummary.SetCheckBoxText("Store Summary")
        cmdLikertOptions.Enabled = False ' Disable Likert Options by default
    End Sub

    Private Sub SetDefaults()
        clsLikertFunction = New RFunction
        clsPlotFunction = New RFunction
        clsSummaryFunction = New RFunction

        ' Reset selectors
        ucrSelectorLikert.Reset()
        ucrSelectorLikertSummary.Reset()
        ucrReceiverMultipleLikert.SetMeAsReceiver()
        ucrReceiverMultipleLikertSummary.SetMeAsReceiver()

        ' Set up likert function for both tabs
        clsLikertFunction.SetPackageName("likert")
        clsLikertFunction.SetRCommand("likert")

        ' Set up plot function for graph tab
        clsPlotFunction.SetRCommand("plot")
        clsPlotFunction.AddParameter("type", Chr(34) & "bar" & Chr(34), iPosition:=1)
        clsPlotFunction.AddParameter("include.histogram", "FALSE", iPosition:=2)

        ' Set up summary function for summary tab
        clsSummaryFunction.SetRCommand("summary")

        clsGridLibrary.SetRCommand("library")
        clsGridLibrary.AddParameter("package", Chr(34) & "grid" & Chr(34), bIncludeArgumentName:=False)

        clsDetachGrid.SetRCommand("detach")
        clsDetachGrid.AddParameter("name", Chr(34) & "package:grid" & Chr(34), bIncludeArgumentName:=False)
        clsDetachGrid.AddParameter("character.only", "TRUE")
        clsDetachGrid.AddParameter("unload", "TRUE")

        ucrChkIncludeHistogram.Checked = False
        ucrChkCentre.Checked = False
        ucrChkWrap.Checked = False

        ucrSaveGraph.ucrChkSave.Checked = False
        ucrSaveSummary.ucrChkSave.Checked = False

        cmdLikertOptions.Enabled = False ' Disable Likert Options by default

        If tbcLikert.SelectedTab Is tbpGraph Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsPlotFunction)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
        End If

        ucrPnlGraphType.SetRDefault("bar")
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ' Graph Tab
        ' Don't set RCode for selector - it adds unwanted data_name parameter
        ' ucrSelectorLikert.SetRCode(clsLikertFunction, bReset)
        ucrPnlGraphType.SetRCode(clsPlotFunction, bReset)
        ucrChkIncludeHistogram.SetRCode(clsPlotFunction, bReset)
        ucrNudCentre.SetRCode(clsPlotFunction, bReset)
        ucrNudWrap.SetRCode(clsPlotFunction, bReset)
        ucrSaveGraph.SetRCode(clsPlotFunction, bReset)

        ' Summary Tab
        ' Don't set RCode for selector
        ' ucrSelectorLikertSummary.SetRCode(clsLikertFunction, bReset)
        ucrSaveSummary.SetRCode(clsSummaryFunction, bReset)
    End Sub

    Public Sub TestOKEnabled()
        If tbcLikert.SelectedTab Is tbpGraph Then
            ' Graph tab validation
            If ucrReceiverMultipleLikert.IsEmpty() OrElse Not ucrSaveGraph.IsComplete Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
                ' Enable Likert Options group when factors are selected
                grpLikertOptions.Enabled = Not ucrReceiverMultipleLikert.IsEmpty()
            End If
        Else
            ' Summary tab validation
            If ucrReceiverMultipleLikertSummary.IsEmpty() OrElse Not ucrSaveSummary.IsComplete Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        ucrSaveGraph.Reset()
        ucrSaveSummary.Reset()
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleLikert.ControlContentsChanged,
            ucrSaveGraph.ControlContentsChanged, ucrReceiverMultipleLikertSummary.ControlContentsChanged, ucrSaveSummary.ControlContentsChanged
        TestOKEnabled()
    End Sub


    Private Sub ucrPnlGraphType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGraphType.ControlValueChanged
        ' Enable/disable histogram and centre options based on graph type
        If rdoBar.Checked Then
            ucrChkIncludeHistogram.Enabled = True
            ucrChkCentre.Enabled = True
        Else
            ucrChkIncludeHistogram.Enabled = False
            ucrChkCentre.Enabled = False
            ucrChkIncludeHistogram.Checked = False
            ucrChkCentre.Checked = False
        End If
        ManageGridLibrary()
    End Sub

    Private Sub ucrReceiverMultipleLikert_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleLikert.ControlValueChanged
        If Not ucrReceiverMultipleLikert.IsEmpty Then
            Dim clsGetDataFrame As RFunction = GetDataFrameFunction(ucrSelectorLikert.strCurrentDataFrame, ucrReceiverMultipleLikert.GetVariableNames())

            clsLikertFunction.AddParameter("items", clsRFunctionParameter:=clsGetDataFrame, iPosition:=0, bIncludeArgumentName:=False)
            clsPlotFunction.AddParameter("x", clsRFunctionParameter:=clsLikertFunction, iPosition:=0, bIncludeArgumentName:=False)
        Else
            clsLikertFunction.RemoveParameterByName("items")
            clsPlotFunction.RemoveParameterByName("x")
        End If

        grpLikertOptions.Enabled = Not ucrReceiverMultipleLikert.IsEmpty()
    End Sub

    Private Sub ucrReceiverMultipleLikertSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleLikertSummary.ControlValueChanged
        If Not ucrReceiverMultipleLikertSummary.IsEmpty Then
            Dim clsGetDataFrame As RFunction = GetDataFrameFunction(ucrSelectorLikertSummary.strCurrentDataFrame, ucrReceiverMultipleLikertSummary.GetVariableNames())

            clsLikertFunction.AddParameter("items", clsRFunctionParameter:=clsGetDataFrame, iPosition:=0, bIncludeArgumentName:=False)
            clsLikertFunction.SetAssignTo("likert_data")

            ucrBase.clsRsyntax.AddToBeforeCodes(clsLikertFunction, iPosition:=0)
            clsSummaryFunction.AddParameter("object", "likert_data", bIncludeArgumentName:=False)
        Else
            clsSummaryFunction.RemoveParameterByName("object")
        End If
    End Sub

    Private Sub tbcLikert_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcLikert.SelectedIndexChanged
        ' Switch the base R function based on selected tab
        If tbcLikert.SelectedTab Is tbpGraph Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsPlotFunction)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrChkIncludeHistogram_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeHistogram.ControlValueChanged
        ManageGridLibrary()
    End Sub

    Private Sub ManageGridLibrary()
        If rdoBar.Checked AndAlso ucrChkIncludeHistogram.Checked Then
            ucrBase.clsRsyntax.AddToBeforeCodes(clsGridLibrary, iPosition:=0)
            ucrBase.clsRsyntax.AddToAfterCodes(clsDetachGrid, iPosition:=0)
        Else
            ' Remove grid library codes if conditions not met
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGridLibrary)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDetachGrid)
        End If
    End Sub
End Class