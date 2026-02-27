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
    Private bShowingGraph As Boolean = True
    Private bHistogramChecked As Boolean = False
    Private bCentreChecked As Boolean = False
    Private clsLikertFunction As New RFunction
    Private clsPlotFunction As New RFunction
    Private clsSummaryFunction As New RFunction
    Private clsGridLibrary As New RFunction
    Private clsDetachGrid As New RFunction
    Private clsDevOff As New RFunction
    Private clsGetDataFrame As New RFunction
    Private clsDummyFunction As New RFunction

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

    Private Function GetDataFrameFunction(strDataFrame As String, strColumns As String, iCount As Integer) As RFunction
        Dim clsGetColumns As New RFunction
        clsGetColumns.SetRCommand("data_book$get_columns_from_data")
        clsGetColumns.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34))
        clsGetColumns.AddParameter("col_names", strColumns)

        If iCount = 1 Then
            Dim clsDataFrame As New RFunction
            clsDataFrame.SetRCommand("data.frame")
            clsDataFrame.AddParameter(strColumns.Replace(Chr(34), "").Trim(), clsRFunctionParameter:=clsGetColumns, bIncludeArgumentName:=True)
            Return clsDataFrame
        End If

        Return clsGetColumns
    End Function

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 0
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrReceiverMultipleLikert.SetParameter(New RParameter("col_names", 1))
        ucrReceiverMultipleLikert.SetParameterIsRFunction()
        ucrReceiverMultipleLikert.Selector = ucrSelectorLikert
        ucrReceiverMultipleLikert.SetMeAsReceiver()
        ucrReceiverMultipleLikert.SetIncludedDataTypes({"factor", "ordered"})
        ucrReceiverMultipleLikert.strSelectorHeading = "Factors"

        ucrPnlGraphType.AddRadioButton(rdoBar)
        ucrPnlGraphType.AddRadioButton(rdoHeat)
        ucrPnlGraphType.AddRadioButton(rdoDensity)
        ucrPnlGraphType.AddParameterValuesCondition(rdoBar, "type", Chr(34) & "bar" & Chr(34))
        ucrPnlGraphType.AddParameterValuesCondition(rdoHeat, "type", Chr(34) & "heat" & Chr(34))
        ucrPnlGraphType.AddParameterValuesCondition(rdoDensity, "type", Chr(34) & "density" & Chr(34))

        ucrChkIncludeHistogram.SetText("Label Histogram")
        ucrChkIncludeHistogram.SetParameter(New RParameter("include.histogram", 2))
        ucrChkIncludeHistogram.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkIncludeHistogram.SetRDefault("FALSE")

        ucrChkCentre.SetText("Specify Centre")
        ucrNudCentre.SetParameter(New RParameter("center", 3))
        ucrNudCentre.Minimum = 2
        ucrNudCentre.Maximum = 4
        ucrNudCentre.Increment = 0.1
        ucrNudCentre.DecimalPlaces = 1
        ucrNudCentre.SetRDefault(2.5)
        ucrChkCentre.AddToLinkedControls(ucrNudCentre, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudCentre.nudUpDown.ReadOnly = False

        ucrNudCentre.Visible = False
        ucrNudWrap.Visible = False

        ucrChkWrap.SetText("Label Width")
        ucrNudWrap.SetParameter(New RParameter("wrap", 4))
        ucrNudWrap.Minimum = 0
        ucrNudWrap.Maximum = 100
        ucrNudWrap.Increment = 1
        ucrNudWrap.DecimalPlaces = 0
        ucrNudWrap.SetRDefault(50)
        ucrChkWrap.AddToLinkedControls(ucrNudWrap, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudWrap.nudUpDown.ReadOnly = False

        ucrSaveGraph.SetPrefix("likert_graph")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorLikert.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
        ucrSaveGraph.SetCheckBoxText("Store Graph")

        ucrReceiverMultipleLikertSummary.SetParameter(New RParameter("col_names", 1))
        ucrReceiverMultipleLikertSummary.SetParameterIsRFunction()
        ucrReceiverMultipleLikertSummary.Selector = ucrSelectorLikertSummary
        ucrReceiverMultipleLikertSummary.SetMeAsReceiver()
        ucrReceiverMultipleLikertSummary.SetIncludedDataTypes({"factor", "ordered"})
        ucrReceiverMultipleLikertSummary.strSelectorHeading = "Factors"

        ucrSaveSummary.SetPrefix("likert_summary")
        ucrSaveSummary.SetSaveType(RObjectTypeLabel.Summary, strRObjectFormat:=RObjectFormat.Text)
        ucrSaveSummary.SetDataFrameSelector(ucrSelectorLikertSummary.ucrAvailableDataFrames)
        ucrSaveSummary.SetAssignToIfUncheckedValue("last_summary")
        ucrSaveSummary.SetCheckBoxText("Store Summary")
        cmdLikertOptions.Enabled = False
    End Sub

    Private Sub SetDefaults()
        clsLikertFunction = New RFunction
        clsPlotFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsDummyFunction = New RFunction

        ucrSelectorLikert.Reset()
        ucrSelectorLikertSummary.Reset()
        ucrReceiverMultipleLikert.SetMeAsReceiver()
        ucrReceiverMultipleLikertSummary.SetMeAsReceiver()

        clsLikertFunction.SetPackageName("likert")
        clsLikertFunction.SetRCommand("likert")

        clsDummyFunction.AddParameter("type", Chr(34) & "bar" & Chr(34), iPosition:=0)

        clsPlotFunction.SetRCommand("plot")
        clsPlotFunction.AddParameter("include.histogram", "FALSE", iPosition:=2)

        clsSummaryFunction.SetRCommand("summary")

        clsGridLibrary.SetRCommand("library")
        clsGridLibrary.AddParameter("package", Chr(34) & "grid" & Chr(34), bIncludeArgumentName:=False)

        clsDetachGrid.SetRCommand("detach")
        clsDetachGrid.AddParameter("name", Chr(34) & "package:grid" & Chr(34), bIncludeArgumentName:=False)
        clsDetachGrid.AddParameter("character.only", "TRUE")
        clsDetachGrid.AddParameter("unload", "TRUE")
        clsDevOff.SetRCommand("dev.off")

        ucrChkIncludeHistogram.Checked = False
        ucrChkCentre.Checked = False
        ucrChkWrap.Checked = False
        ucrSaveGraph.ucrChkSave.Checked = False
        ucrSaveSummary.ucrChkSave.Checked = False
        cmdLikertOptions.Enabled = False
        bHistogramChecked = False
        bCentreChecked = False

        If bShowingGraph Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsPlotFunction)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
        End If

        ucrPnlGraphType.SetRDefault("bar")
    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkIncludeHistogram.SetRCode(clsPlotFunction, bReset)
        ucrNudCentre.SetRCode(clsPlotFunction, bReset)
        ucrNudWrap.SetRCode(clsPlotFunction, bReset)
        ucrSaveGraph.SetRCode(clsPlotFunction, bReset)
        ucrSaveSummary.SetRCode(clsSummaryFunction, bReset)
        ucrPnlGraphType.SetRCode(clsDummyFunction, bReset)
    End Sub
    Public Sub TestOKEnabled()
        If bShowingGraph Then
            If ucrReceiverMultipleLikert.IsEmpty() OrElse Not ucrSaveGraph.IsComplete Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
                grpLikertOptions.Enabled = Not ucrReceiverMultipleLikert.IsEmpty()
            End If
        Else
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
    Private Sub rdoGraph_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGraph.CheckedChanged
        If rdoGraph.Checked Then
            bShowingGraph = True
            pnlGraph.Visible = True
            pnlSummary.Visible = False
            ucrBase.clsRsyntax.SetBaseRFunction(clsPlotFunction)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsLikertFunction)
            clsLikertFunction.SetAssignTo("")
            TestOKEnabled()
        End If
    End Sub
    Private Sub rdoSummary_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSummary.CheckedChanged
        If rdoSummary.Checked Then
            bShowingGraph = False
            pnlGraph.Visible = False
            pnlSummary.Visible = True
            ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
            clsPlotFunction.RemoveParameterByName("x")
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDetachGrid)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDevOff)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGridLibrary)
            TestOKEnabled()
        End If
    End Sub
    Private Sub ucrChkIncludeHistogram_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeHistogram.ControlValueChanged
        If rdoBar.Checked Then
            bHistogramChecked = ucrChkIncludeHistogram.chkCheck.Checked
        End If
        ManageGridLibrary()
    End Sub
    Private Sub ucrChkCentre_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCentre.ControlValueChanged
        If rdoBar.Checked Then
            bCentreChecked = ucrChkCentre.chkCheck.Checked
        End If
    End Sub

    Private Sub ucrPnlGraphType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGraphType.ControlValueChanged
        If rdoBar.Checked Then
            ucrChkIncludeHistogram.Enabled = True
            ucrChkCentre.Enabled = True
            ucrChkIncludeHistogram.chkCheck.Checked = bHistogramChecked
            ucrChkCentre.chkCheck.Checked = bCentreChecked
            clsPlotFunction.AddParameter("type", Chr(34) & "bar" & Chr(34), iPosition:=1)
            ucrNudCentre.Visible = bCentreChecked
        ElseIf rdoHeat.Checked Then
            ucrChkIncludeHistogram.chkCheck.Checked = False
            ucrChkCentre.chkCheck.Checked = False
            ucrChkIncludeHistogram.Enabled = False
            ucrChkCentre.Enabled = False
            ucrNudCentre.Visible = False
            clsPlotFunction.AddParameter("type", Chr(34) & "heat" & Chr(34), iPosition:=1)
        ElseIf rdoDensity.Checked Then
            ucrChkIncludeHistogram.chkCheck.Checked = False
            ucrChkCentre.chkCheck.Checked = False
            ucrChkIncludeHistogram.Enabled = False
            ucrChkCentre.Enabled = False
            ucrNudCentre.Visible = False
            clsPlotFunction.AddParameter("type", Chr(34) & "density" & Chr(34), iPosition:=1)
        End If
        ManageGridLibrary()
    End Sub

    Private Sub ucrReceiverMultipleLikert_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleLikert.ControlValueChanged
        If Not ucrReceiverMultipleLikert.IsEmpty Then
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataFrame)
            clsGetDataFrame = GetDataFrameFunction(ucrSelectorLikert.strCurrentDataFrame, ucrReceiverMultipleLikert.GetVariableNames(), ucrReceiverMultipleLikert.Count())
            clsGetDataFrame.SetAssignTo("likert_data")
            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataFrame, iPosition:=0)
            clsLikertFunction.RemoveParameterByName("items")
            clsLikertFunction.AddParameter("items", "likert_data", iPosition:=0, bIncludeArgumentName:=False)
            clsPlotFunction.AddParameter("x", clsRFunctionParameter:=clsLikertFunction, iPosition:=0, bIncludeArgumentName:=False)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataFrame)
            clsLikertFunction.RemoveParameterByName("items")
            clsPlotFunction.RemoveParameterByName("x")
        End If
        grpLikertOptions.Enabled = Not ucrReceiverMultipleLikert.IsEmpty()
    End Sub
    Private Sub ucrReceiverMultipleLikertSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleLikertSummary.ControlValueChanged
        If Not ucrReceiverMultipleLikertSummary.IsEmpty Then
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataFrame)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsLikertFunction)
            clsLikertFunction.RemoveParameterByName("items")
            clsGetDataFrame = GetDataFrameFunction(ucrSelectorLikertSummary.strCurrentDataFrame, ucrReceiverMultipleLikertSummary.GetVariableNames(), ucrReceiverMultipleLikertSummary.Count())
            clsGetDataFrame.SetAssignTo("likert_data")
            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataFrame, iPosition:=0)
            clsLikertFunction.AddParameter("items", "likert_data", iPosition:=0, bIncludeArgumentName:=False)
            clsLikertFunction.SetAssignTo("likert_object")
            ucrBase.clsRsyntax.AddToBeforeCodes(clsLikertFunction, iPosition:=1)
            clsSummaryFunction.AddParameter("object", "likert_object", bIncludeArgumentName:=False)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataFrame)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsLikertFunction)
            clsLikertFunction.RemoveParameterByName("items")
            clsSummaryFunction.RemoveParameterByName("object")
        End If
    End Sub
    Private Sub ManageGridLibrary()
        If rdoBar.Checked AndAlso ucrChkIncludeHistogram.Checked Then
            ucrBase.clsRsyntax.AddToBeforeCodes(clsGridLibrary, iPosition:=0)
            ucrBase.clsRsyntax.AddToAfterCodes(clsDetachGrid, iPosition:=0)
            ucrBase.clsRsyntax.AddToAfterCodes(clsDevOff, iPosition:=1)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGridLibrary)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDetachGrid)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDevOff)
        End If
    End Sub
End Class