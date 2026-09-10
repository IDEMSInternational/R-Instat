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

Imports instat.Translations
Imports RDotNet

Public Class dlgDescribeTwoVariableMoreLikertGraphs

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private bLevelsMatch As Boolean = True
    Private bRCodeSet As Boolean = False
    Private clsGGLikertFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsLabsFunction As New RFunction
    Private clsXLabsFunction As New RFunction
    Private clsYLabsFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private clsAnnotateFunction As New RFunction
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsFacetFunction As New RFunction
    Private clsRowVarsFunction As New RFunction
    Private clsColVarsFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsWrapDummyFunction As New RFunction
    Private clsCutoffDummyFunction As New RFunction
    Private clsGetDf As New RFunction
    Private clsGetDfAssignOperator As New ROperator
    Private iNumLevels As Integer

    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Col"
    Private ReadOnly strFacetNone As String = "None"

    Private Sub dlgDescribeTwoVariableMoreLikertGraphs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        ucrSaveGGLikert.Reset()
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 759
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrPnlChartType.AddRadioButton(rdoLikert)
        ucrPnlChartType.AddRadioButton(rdoStacked)
        ucrPnlChartType.AddRadioButton(rdoSide)

        ucrPnlChartType.AddParameterValuesCondition(rdoLikert, "chart_type", Chr(34) & "likert" & Chr(34))
        ucrPnlChartType.AddParameterValuesCondition(rdoStacked, "chart_type", Chr(34) & "stacked" & Chr(34))
        ucrPnlChartType.AddParameterValuesCondition(rdoSide, "chart_type", Chr(34) & "side" & Chr(34))

        ucrReceiverMultipleGGLikert.SetParameter(New RParameter("include", 1))
        ucrReceiverMultipleGGLikert.SetParameterIsString()
        ucrReceiverMultipleGGLikert.Selector = ucrSelectorGGLikert
        ucrReceiverMultipleGGLikert.SetMeAsReceiver()
        ucrReceiverMultipleGGLikert.SetIncludedDataTypes({"factor", "ordered"})
        ucrReceiverMultipleGGLikert.strSelectorHeading = "Factors"

        ucrChkSort.SetText("Sort")
        ucrChkSort.AddToLinkedControls(ucrChkDescending, {True}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=False)
        ucrChkDescending.SetText("Descending")

        ucrChkReverse.SetText("Reverse")
        ucrChkReverse.SetParameter(New RParameter("reverse_likert", 11))
        ucrChkReverse.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkReverse.SetRDefault("FALSE")

        ucrChkSymmetric.SetText("Symmetric")
        ucrChkSymmetric.SetParameter(New RParameter("symmetric", 12))
        ucrChkSymmetric.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSymmetric.SetRDefault("FALSE")

        ucrChkCutoff.SetText("Cutoff")
        ucrChkCutoff.AddParameterValuesCondition(True, "cutoff_chk", "TRUE")
        ucrChkCutoff.AddParameterValuesCondition(False, "cutoff_chk", "FALSE")
        ucrChkCutoff.AddToLinkedControls(ucrNudCutoff, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkWrap.SetText("Wrap")
        ucrChkWrap.AddParameterValuesCondition(True, "wrap", "TRUE")
        ucrChkWrap.AddParameterValuesCondition(False, "wrap", "FALSE")
        ucrChkWrap.AddToLinkedControls(ucrNudWrap, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkValues.SetText("Values")
        ucrChkValues.SetParameter(New RParameter("add_labels", 21))
        ucrChkValues.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkValues.SetRDefault("TRUE")

        ucrChkTotals.SetText("Totals")
        ucrChkTotals.SetParameter(New RParameter("add_totals", 22))
        ucrChkTotals.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkTotals.SetRDefault("TRUE")

        ucrNudCutoff.SetParameter(New RParameter("cutoff", 13))
        ucrNudCutoff.Minimum = 0
        ucrNudCutoff.Maximum = 9
        ucrNudCutoff.Increment = 0.5
        ucrNudCutoff.DecimalPlaces = 1
        ucrNudCutoff.SetRDefault(0)
        ucrNudCutoff.nudUpDown.ReadOnly = False

        ucrNudWrap.SetParameter(New RParameter("y_label_wrap", 20))
        ucrNudWrap.Minimum = 10
        ucrNudWrap.Maximum = 50
        ucrNudWrap.Increment = 1
        ucrNudWrap.DecimalPlaces = 0
        ucrNudWrap.nudUpDown.ReadOnly = False

        ucrNudCutoffLevel.Minimum = 1
        ucrNudCutoffLevel.Maximum = ucrNudCutoffLevel.Minimum
        ucrNudCutoffLevel.Increment = 1
        ucrNudCutoffLevel.DecimalPlaces = 0
        ucrNudCutoffLevel.nudUpDown.ReadOnly = False

        ucrNudExclude.Minimum = 0
        ucrNudExclude.Maximum = iNumLevels
        ucrNudExclude.Increment = 1
        ucrNudExclude.DecimalPlaces = 0
        ucrNudExclude.SetRDefault(0)
        ucrNudExclude.nudUpDown.ReadOnly = False

        lblCutoffLevel.Visible = False
        ucrNudCutoffLevel.Visible = False

        ucrSaveGGLikert.SetPrefix("gglikert_graph")
        ucrSaveGGLikert.SetSaveTypeAsGraph()
        ucrSaveGGLikert.SetDataFrameSelector(ucrSelectorGGLikert.ucrAvailableDataFrames)
        ucrSaveGGLikert.SetAssignToIfUncheckedValue("last_graph")
        ucrSaveGGLikert.SetCheckBoxText("Store Graph")

        ucr1stFactorReceiver.SetParameter(New RParameter("rows", bNewIncludeArgumentName:=False))
        ucr1stFactorReceiver.Selector = ucrSelectorGGLikert
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.SetLinkedDisplayControl(lblFacetBy)

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strFacetNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrChkLegend.SetText("Legend:")
        ucrChkLegend.AddToLinkedControls({ucrInputLegendPosition}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrInputLegendPosition.SetDropDownStyleAsNonEditable()
        ucrInputLegendPosition.SetParameter(New RParameter("legend.position"))
        ucrInputLegendPosition.SetItems(New Dictionary(Of String, String) From {
            {"None", Chr(34) & "none" & Chr(34)},
            {"Left", Chr(34) & "left" & Chr(34)},
            {"Right", Chr(34) & "right" & Chr(34)},
            {"Top", Chr(34) & "top" & Chr(34)},
            {"Bottom", Chr(34) & "bottom" & Chr(34)}
        })
        ucrChkLegend.AddParameterPresentCondition(True, "legend.position")
        ucrChkLegend.AddParameterPresentCondition(False, "legend.position", False)
    End Sub

    Private Sub SetDefaults()
        clsGGLikertFunction = New RFunction
        clsBaseOperator = New ROperator
        clsLabsFunction = New RFunction
        clsXLabsFunction = New RFunction
        clsYLabsFunction = New RFunction
        clsXScaleContinuousFunction = New RFunction
        clsYScaleContinuousFunction = New RFunction
        clsThemeFunction = New RFunction
        dctThemeFunctions = New Dictionary(Of String, RFunction)
        clsAnnotateFunction = New RFunction
        clsXScaleDateFunction = New RFunction
        clsYScaleDateFunction = New RFunction
        clsCoordPolarFunction = New RFunction
        clsCoordPolarStartOperator = New ROperator
        clsFacetFunction = New RFunction
        clsRowVarsFunction = New RFunction
        clsColVarsFunction = New RFunction
        clsDummyFunction = New RFunction
        clsWrapDummyFunction = New RFunction
        clsCutoffDummyFunction = New RFunction
        clsGetDf = New RFunction
        clsGetDfAssignOperator = New ROperator

        ucrSelectorGGLikert.Reset()
        ucrSaveGGLikert.Reset()

        clsGGLikertFunction.SetPackageName("ggstats")
        clsGGLikertFunction.SetRCommand("gglikert")

        clsGGLikertFunction.AddParameter("y_label_wrap", "20", iPosition:=20)
        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("plot", clsRFunctionParameter:=clsGGLikertFunction, iPosition:=0)
        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorGGLikert.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)

        clsRowVarsFunction.SetPackageName("ggplot2")
        clsRowVarsFunction.SetRCommand("vars")

        clsColVarsFunction.SetPackageName("ggplot2")
        clsColVarsFunction.SetRCommand("vars")

        clsFacetFunction.SetPackageName("ggplot2")

        clsDummyFunction.AddParameter("chart_type", Chr(34) & "likert" & Chr(34), iPosition:=0)
        clsWrapDummyFunction.AddParameter("wrap", "FALSE", iPosition:=0)
        clsCutoffDummyFunction.AddParameter("cutoff_chk", "FALSE", iPosition:=0)

        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXLabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYLabsFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction.Clone()

        ucrInputStation.SetName(strFacetWrap)
        ucrNudCutoff.Value = 0
        ucrNudWrap.Value = 20
        ucrNudExclude.Value = 0
        ucrNudCutoffLevel.Value = 1
        iNumLevels = Nothing
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False

        ucrPnlChartType.SetRCode(clsDummyFunction, bReset)
        ucrChkWrap.SetRCode(clsWrapDummyFunction, bReset)
        ucrChkCutoff.SetRCode(clsCutoffDummyFunction, bReset)
        ucrReceiverMultipleGGLikert.SetRCode(clsGGLikertFunction, bReset)
        ucrChkValues.SetRCode(clsGGLikertFunction, bReset)
        ucrChkTotals.SetRCode(clsGGLikertFunction, bReset)
        ucrNudWrap.SetRCode(clsGGLikertFunction, bReset)
        ucrSaveGGLikert.SetRCode(clsBaseOperator, bReset)
        ucrChkLegend.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucr1stFactorReceiver.SetRCode(clsRowVarsFunction, bReset)

        If bReset Then
            ucrChkReverse.SetRCode(clsGGLikertFunction, bReset)
            ucrChkSymmetric.SetRCode(clsGGLikertFunction, bReset)
        End If

        bRCodeSet = True
        AddRemoveFacets()
        AddRemoveTheme()
        UpdateControlsVisibility()
        AddRemoveCutoff()
    End Sub

    Private Sub AddRemoveCutoff()
        If Not rdoStacked.Checked Then
            If ucrChkCutoff.Checked AndAlso Not clsGGLikertFunction.ContainsParameter("cutoff") Then
                clsGGLikertFunction.AddParameter("cutoff", ucrNudCutoff.nudUpDown.Text, iPosition:=13)
            End If
        Else
            clsGGLikertFunction.RemoveParameterByName("cutoff")
        End If
    End Sub

    Private Sub SymmetryAddParameters()
        If Not rdoStacked.Checked Then
            If ucrChkSymmetric.Checked Then
                clsGGLikertFunction.AddParameter("symmetric", "TRUE", iPosition:=12)
            Else
                clsGGLikertFunction.RemoveParameterByName("symmetric")
            End If
        Else
            clsGGLikertFunction.RemoveParameterByName("symmetric")
        End If
    End Sub

    Private Sub ReverseAddParameters()
        If Not rdoStacked.Checked Then
            If ucrChkReverse.Checked Then
                clsGGLikertFunction.AddParameter("reverse_likert", "TRUE", iPosition:=11)
            Else
                clsGGLikertFunction.RemoveParameterByName("reverse_likert")
            End If
        Else
            clsGGLikertFunction.RemoveParameterByName("reverse_likert")
        End If
    End Sub

    Private Sub TestOkEnabled()
        Dim varNames As List(Of String) = ucrReceiverMultipleGGLikert.GetVariableNamesAsList()
        Dim bSingleVar As Boolean = varNames IsNot Nothing AndAlso varNames.Count = 1

        Dim bCanOk As Boolean = Not ucrReceiverMultipleGGLikert.IsEmpty() AndAlso
                            Not bSingleVar AndAlso
                            ucrSaveGGLikert.IsComplete AndAlso
                            bLevelsMatch
        ucrBase.OKEnabled(bCanOk)
    End Sub

    Private Sub UpdateControlsVisibility()
        Dim bIsLikert As Boolean = rdoLikert.Checked
        Dim bIsStacked As Boolean = rdoStacked.Checked
        Dim bIsSide As Boolean = rdoSide.Checked

        ucrChkReverse.Enabled = bIsLikert OrElse bIsSide
        ucrChkSymmetric.Enabled = bIsLikert OrElse bIsSide
        ucrChkCutoff.Enabled = bIsLikert OrElse bIsSide
        ucrNudCutoff.Enabled = ucrChkCutoff.Enabled AndAlso ucrChkCutoff.Checked

        lblExclude.Visible = bIsLikert
        ucrNudExclude.Visible = bIsLikert
        ucrNudExclude.Enabled = bIsLikert

        lblCutoffLevel.Visible = bIsSide
        ucrNudCutoffLevel.Visible = bIsSide
        ucrNudCutoffLevel.Enabled = bIsSide

        ucrChkDescending.Enabled = ucrChkSort.Checked
        ucrInputLegendPosition.Enabled = ucrChkLegend.Checked
    End Sub

    Private Sub ucrPnlChartType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlChartType.ControlValueChanged
        If rdoLikert.Checked Then
            clsDummyFunction.AddParameter("chart_type", Chr(34) & "likert" & Chr(34), iPosition:=0)
            clsGGLikertFunction.SetRCommand("gglikert")
            clsGGLikertFunction.RemoveParameterByName("side_values")
            clsBaseOperator.SetOperation("+")
            clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        ElseIf rdoStacked.Checked Then
            clsDummyFunction.AddParameter("chart_type", Chr(34) & "stacked" & Chr(34), iPosition:=0)
            clsGGLikertFunction.SetRCommand("gglikert_stacked")
            clsGGLikertFunction.RemoveParameterByName("side_values")
            clsGGLikertFunction.RemoveParameterByName("cutoff")
            clsGGLikertFunction.RemoveParameterByName("reverse_likert")
            clsGGLikertFunction.RemoveParameterByName("symmetric")
            clsGGLikertFunction.RemoveParameterByName("exclude_fill_values")
            clsBaseOperator.SetOperation("+")
            clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        ElseIf rdoSide.Checked Then
            clsDummyFunction.AddParameter("chart_type", Chr(34) & "side" & Chr(34), iPosition:=0)
            clsGGLikertFunction.SetRCommand("gglikert_side")
            clsGGLikertFunction.RemoveParameterByName("exclude_fill_values")
            clsBaseOperator.SetOperation("&")
            clsBaseOperator.RemoveParameterByName(GgplotDefaults.clsDefaultThemeParameter.strArgumentName)
            UpdateSideValuesParameter()
        End If
        SetRCodeForControls(False)
        If rdoStacked.Checked Then
            clsGGLikertFunction.RemoveParameterByName("cutoff")
        End If
        AddRemoveFacets()
        AddRemoveCutoff()
        SymmetryAddParameters()
        ReverseAddParameters()
    End Sub

    Private Sub UpdateSideValuesParameter()
        clsGGLikertFunction.RemoveParameterByName("side_values")

        If rdoSide.Checked AndAlso Not ucrReceiverMultipleGGLikert.IsEmpty() Then
            Dim varNames As List(Of String) = ucrReceiverMultipleGGLikert.GetVariableNamesAsList()

            If varNames IsNot Nothing AndAlso varNames.Count > 0 Then
                Dim strScript As String = String.Format(
                "levels(data_book$get_data_frame(data_name={0})[[{1}]])[{2}]",
                Chr(34) & ucrSelectorGGLikert.strCurrentDataFrame & Chr(34),
                Chr(34) & varNames(0) & Chr(34),
                CInt(ucrNudCutoffLevel.Value))

                Dim expResult = frmMain.clsRLink.RunInternalScriptGetValue(strScript, bSilent:=True)

                If expResult IsNot Nothing AndAlso expResult.Type <> Internals.SymbolicExpressionType.Null Then
                    Dim strLevel As String = expResult.AsCharacter()(0)

                    If Not String.IsNullOrEmpty(strLevel) Then
                        clsGGLikertFunction.AddParameter("side_values", Chr(34) & strLevel & Chr(34), iPosition:=14)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub UpdateCutoffExcludeBounds()
        Dim iMaxCutoff As Decimal = Math.Max(0, iNumLevels - CInt(ucrNudExclude.Value) - 1)
        ucrNudCutoff.nudUpDown.Maximum = Math.Max(iMaxCutoff, ucrNudCutoff.Value)
        If ucrNudCutoff.Value > iMaxCutoff Then ucrNudCutoff.Value = iMaxCutoff

        Dim iMaxExclude As Integer = Math.Max(0, iNumLevels - CInt(ucrNudCutoff.Value) - 1)
        ucrNudExclude.nudUpDown.Maximum = Math.Max(iMaxExclude, ucrNudExclude.Value)
        If ucrNudExclude.Value > iMaxExclude Then ucrNudExclude.Value = iMaxExclude
    End Sub

    Private Sub AddRemoveFacets()
        If bRCodeSet Then
            clsGGLikertFunction.RemoveParameterByName("facet_rows")
            clsGGLikertFunction.RemoveParameterByName("facet_cols")
            clsBaseOperator.RemoveParameterByName("facets")

            If Not ucr1stFactorReceiver.IsEmpty AndAlso ucrInputStation.GetText() <> strFacetNone Then
                If rdoStacked.Checked Then
                    clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=BuildFacetFunction(), iPosition:=3)
                Else
                    Select Case ucrInputStation.GetText()
                        Case strFacetWrap, strFacetRow
                            clsGGLikertFunction.AddParameter("facet_rows", clsRFunctionParameter:=clsRowVarsFunction, iPosition:=50)
                        Case strFacetCol
                            clsGGLikertFunction.AddParameter("facet_cols", clsRFunctionParameter:=clsRowVarsFunction, iPosition:=51)
                    End Select
                End If
            End If
        End If
    End Sub

    'ggstacked doesn't have built in facet parameters and gglikert and gg_side facets is done via built in facet_grid
    Private Function BuildFacetFunction() As RFunction
        Dim clsFacet As New RFunction
        clsFacet.SetPackageName("ggplot2")
        Select Case ucrInputStation.GetText()
            Case strFacetWrap
                clsFacet.SetRCommand("facet_wrap")
                clsFacet.AddParameter("facets", clsRFunctionParameter:=clsRowVarsFunction, iPosition:=0, bIncludeArgumentName:=False)
            Case strFacetRow
                clsFacet.SetRCommand("facet_grid")
                clsFacet.AddParameter("rows", clsRFunctionParameter:=clsRowVarsFunction, iPosition:=0)
            Case strFacetCol
                clsFacet.SetRCommand("facet_grid")
                clsFacet.AddParameter("cols", clsRFunctionParameter:=clsRowVarsFunction, iPosition:=0)
        End Select
        Return clsFacet
    End Function

    'This add column labels to data since gglikert only works with data that has column labels
    Private Sub UpdateDataAndSetLabels()
        clsGGLikertFunction.RemoveParameterByName("data")

        If Not ucrReceiverMultipleGGLikert.IsEmpty() Then
            Dim varNames As List(Of String) = ucrReceiverMultipleGGLikert.GetVariableNamesAsList()
            Dim strDataFrame As String = Chr(34) & ucrSelectorGGLikert.strCurrentDataFrame & Chr(34)
            Dim strVarVector As String = "c(" & String.Join(",", varNames.Select(Function(v) Chr(34) & v & Chr(34))) & ")"

            Dim strScript As String = String.Format(
        "invisible(lapply({0}, function(v) {{" &
        "current_label <- attr(data_book$get_data_frame(data_name = {1})[[v]], 'label');" &
        "needs_fix <- is.null(current_label) || nchar(trimws(current_label)) == 0;" &
        "if (needs_fix) {{" &
        "clean_label <- trimws(gsub('.', ' ', v, fixed = TRUE));" &
        "clean_label <- trimws(gsub('\\s+', ' ', clean_label));" &
        "data_book$rename_column_in_data(data_name = {1}, type = " & Chr(34) & "single" & Chr(34) & ", column_name = v, new_val = v, label = clean_label)" &
        "}}" &
        "}}))",
        strVarVector,
        strDataFrame)
            frmMain.clsRLink.RunInternalScript(strScript, bSilent:=True)

            Dim clsGetDataFrameFunction As RFunction = ucrSelectorGGLikert.ucrAvailableDataFrames.clsCurrDataFrame.Clone
            clsGGLikertFunction.AddParameter("data", clsRFunctionParameter:=clsGetDataFrameFunction, iPosition:=0, bIncludeArgumentName:=True)
        End If
    End Sub

    Private Sub UpdateSortParameter()
        If ucrChkSort.Checked Then
            Dim strSortValue As String = If(ucrChkDescending.Checked, "descending", "ascending")
            clsGGLikertFunction.AddParameter("sort", Chr(34) & strSortValue & Chr(34), iPosition:=10)
        Else
            clsGGLikertFunction.AddParameter("sort", Chr(34) & "none" & Chr(34), iPosition:=10)
        End If
    End Sub

    Private Sub CheckSelectedFactorsHaveSameLevels()
        If ucrReceiverMultipleGGLikert.IsEmpty() Then
            bLevelsMatch = True
            lblLevelsWarning.Visible = False
        Else
            Dim strScript As String = "as.numeric(sapply(data_book$get_columns_from_data(data_name = " & Chr(34) & ucrSelectorGGLikert.strCurrentDataFrame & Chr(34) & ", col_names = " & ucrReceiverMultipleGGLikert.GetVariableNames() & "), nlevels))"
            Dim expResult = frmMain.clsRLink.RunInternalScriptGetValue(strScript, bSilent:=True)

            If expResult Is Nothing OrElse expResult.Type = Internals.SymbolicExpressionType.Null Then
                bLevelsMatch = True
                lblLevelsWarning.Visible = False
            Else
                Dim arrLevels = expResult.AsNumeric()

                If arrLevels Is Nothing OrElse arrLevels.Length = 0 Then
                    bLevelsMatch = True
                Else
                    Dim iFirstLevel As Integer = CInt(arrLevels(0))
                    Dim bMismatchFound As Boolean = False

                    For Each dLevel In arrLevels
                        If CInt(dLevel) <> iFirstLevel Then
                            bMismatchFound = True
                        End If
                    Next

                    If bMismatchFound Then
                        bLevelsMatch = False
                        lblLevelsWarning.Visible = True
                    Else
                        bLevelsMatch = True
                        lblLevelsWarning.Visible = False
                        iNumLevels = iFirstLevel
                        ucrNudCutoffLevel.Maximum = iNumLevels
                        UpdateCutoffExcludeBounds()
                        If rdoSide.Checked Then UpdateSideValuesParameter()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub UpdateExcludeFillParameter()
        clsGGLikertFunction.RemoveParameterByName("exclude_fill_values")

        If ucrNudExclude.Value > 0 Then
            Dim varNames = ucrReceiverMultipleGGLikert.GetVariableNamesAsList()
            Dim strScript = String.Format("levels({0}$get_columns_from_data(data_name={1}, col_names={2}))",
            frmMain.clsRLink.strInstatDataObject,
            Chr(34) & ucrSelectorGGLikert.strCurrentDataFrame & Chr(34),
            Chr(34) & varNames(0) & Chr(34))

            Dim arrLevels = frmMain.clsRLink.RunInternalScriptGetValue(strScript, bSilent:=True).AsCharacter()

            Dim clsExcludeVector As New RFunction
            clsExcludeVector.SetRCommand("c")
            For i As Integer = 0 To CInt(ucrNudExclude.Value) - 1
                clsExcludeVector.AddParameter(i.ToString(), Chr(34) & arrLevels(i) & Chr(34), bIncludeArgumentName:=False, iPosition:=i)
            Next
            clsGGLikertFunction.AddParameter("exclude_fill_values", clsRFunctionParameter:=clsExcludeVector, iPosition:=31)
        End If
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=100)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ucrChkLegend_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLegend.ControlValueChanged, ucrInputLegendPosition.ControlValueChanged
        AddRemoveTheme()
        UpdateControlsVisibility()
    End Sub

    Private Sub ucrReceiverMultipleGGLikert_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleGGLikert.ControlValueChanged
        UpdateDataAndSetLabels()
        CheckSelectedFactorsHaveSameLevels()
        If rdoSide.Checked Then UpdateSideValuesParameter()
        TestOkEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleGGLikert.ControlContentsChanged, ucrSaveGGLikert.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorGGLikert_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorGGLikert.ControlValueChanged
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorGGLikert.strCurrentDataFrame, strTempGraph:="last_graph")
        UpdateDataAndSetLabels()
    End Sub

    Private Sub ucrChkSort_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSort.ControlValueChanged
        ucrChkDescending.Enabled = ucrChkSort.Checked
        If Not ucrChkSort.Checked Then ucrChkDescending.Checked = False
        UpdateSortParameter()
    End Sub

    Private Sub ucrChkDescending_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDescending.ControlValueChanged
        UpdateSortParameter()
    End Sub

    Private Sub ucr1stFactorReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucr1stFactorReceiver.ControlValueChanged
        AddRemoveFacets()
    End Sub

    Private Sub ucrInputStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputStation.ControlValueChanged
        AddRemoveFacets()
    End Sub

    Private Sub ucrNudCutoff_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudCutoff.ControlValueChanged
        UpdateCutoffExcludeBounds()
        AddRemoveCutoff()
    End Sub

    Private Sub ucrNudExclude_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudExclude.ControlValueChanged
        UpdateCutoffExcludeBounds()
        UpdateExcludeFillParameter()
    End Sub

    Private Sub ucrNudCutoffLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudCutoffLevel.ControlValueChanged
        UpdateSideValuesParameter()
        AddRemoveCutoff()
    End Sub

    Private Sub ucrChkWrap_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWrap.ControlValueChanged
        If bRCodeSet Then
            If ucrChkWrap.Checked Then
                clsWrapDummyFunction.AddParameter("wrap", "TRUE", iPosition:=0)
            Else
                clsWrapDummyFunction.AddParameter("wrap", "FALSE", iPosition:=0)
            End If
        End If
        UpdateControlsVisibility()
    End Sub

    Private Sub ucrChkCutoff_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCutoff.ControlValueChanged
        If bRCodeSet Then
            If ucrChkCutoff.Checked Then
                clsCutoffDummyFunction.AddParameter("cutoff_chk", "TRUE", iPosition:=0)
            Else
                clsCutoffDummyFunction.AddParameter("cutoff_chk", "FALSE", iPosition:=0)
            End If
        End If
        UpdateControlsVisibility()
        AddRemoveCutoff()
    End Sub

    Private Sub cmdPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        If clsBaseOperator IsNot Nothing Then
            clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
            sdgPlots.SetRCode(clsBaseOperator,
              clsNewXScaleDateFunction:=clsXScaleDateFunction,
              clsNewYScaleDateFunction:=clsYScaleDateFunction,
              clsNewThemeFunction:=clsThemeFunction,
              dctNewThemeFunctions:=dctThemeFunctions,
              clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction,
              clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction,
              clsNewXLabsTitleFunction:=clsXLabsFunction,
              clsNewYLabTitleFunction:=clsYLabsFunction,
              clsNewLabsFunction:=clsLabsFunction,
              clsNewFacetFunction:=clsFacetFunction,
              clsNewCoordPolarFunction:=clsCoordPolarFunction,
              clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator,
              clsNewAnnotateFunction:=GgplotDefaults.clsAnnotateFunction,
              clsNewColVarsFunction:=New RFunction,
              clsNewRowVarsFunction:=New RFunction,
              ucrNewBaseSelector:=ucrSelectorGGLikert,
              bReset:=bResetSubdialog)
            sdgPlots.ShowDialog()
            bResetSubdialog = False
            AddRemoveTheme()
        End If
    End Sub
    Private Sub ucrChkSymmetric_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSymmetric.ControlValueChanged
        SymmetryAddParameters()
    End Sub

    Private Sub ucrChkReverse_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkReverse.ControlValueChanged
        ReverseAddParameters()
    End Sub
End Class