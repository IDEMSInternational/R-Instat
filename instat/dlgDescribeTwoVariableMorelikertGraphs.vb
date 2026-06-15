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

    ' -------------------------------------------------------------------------
    ' Chart type enum - replaces fragile string comparisons on radio buttons
    ' -------------------------------------------------------------------------
    Private Enum ChartType
        Likert
        Stacked
        Side
    End Enum

    ' -------------------------------------------------------------------------
    ' R parameter position constants - one place to manage ordering
    ' -------------------------------------------------------------------------
    Private Const POS_DATA As Integer = 0
    Private Const POS_INCLUDE As Integer = 1
    Private Const POS_SIDE_VALUES As Integer = 2
    Private Const POS_SORT As Integer = 10
    Private Const POS_REVERSE As Integer = 11
    Private Const POS_SYMMETRIC As Integer = 12
    Private Const POS_CUTOFF As Integer = 13
    Private Const POS_LABEL_WRAP As Integer = 20
    Private Const POS_ADD_LABELS As Integer = 21
    Private Const POS_ADD_TOTALS As Integer = 22
    Private Const POS_CUTOFF_LEVEL As Integer = 30
    Private Const POS_EXCLUDE_FILL As Integer = 31
    Private Const POS_FACET_ROWS As Integer = 50
    Private Const POS_FACET_COLS As Integer = 51
    Private Const POS_FACET_LAYER As Integer = 52

    ' -------------------------------------------------------------------------
    ' Facet type constants - replaces magic strings scattered through the code
    ' -------------------------------------------------------------------------
    Private Const FACET_WRAP As String = "Facet Wrap"
    Private Const FACET_ROW As String = "Facet Row"
    Private Const FACET_COL As String = "Facet Col"
    Private Const FACET_NONE As String = "None"

    ' -------------------------------------------------------------------------
    ' Dialog state flags
    ' -------------------------------------------------------------------------
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private bLevelsMatch As Boolean = True
    Private iNumLevels As Integer = 5
    Private bSortChecked As Boolean = False
    Private bDescendingChecked As Boolean = False

    ' -------------------------------------------------------------------------
    ' R function / operator objects
    ' -------------------------------------------------------------------------
    Private clsGGLikertFunction As RFunction
    Private clsBaseOperator As ROperator
    Private clsCoordPolarFunction As RFunction
    Private clsCoordPolarStartOperator As ROperator
    Private clsXScaleContinuousFunction As RFunction
    Private clsYScaleContinuousFunction As RFunction
    Private clsLabsFunction As RFunction
    Private clsXLabsFunction As RFunction
    Private clsYLabsFunction As RFunction
    Private clsThemeFunction As RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private clsAnnotateFunction As RFunction
    Private clsXScaleDateFunction As RFunction
    Private clsYScaleDateFunction As RFunction
    Private clsRowVarsFunction As New RFunction
    Private clsColVarsFunction As New RFunction
    Private clsFacetFunction As New RFunction
    Private clsFacetAfterCode As RCodeStructure = Nothing
    Private dPreservedCutoff As Decimal = 0
    Private lblCutoffClampWarning As Label

    ' =========================================================================
    ' Dialog lifecycle
    ' =========================================================================

    Private Sub dlgDescribeTwoVariableMoreLikertGraphs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
            SetRCodeForControls(bReset)
            bReset = False
        End If
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        ucrSaveGGLikert.Reset()
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    ' =========================================================================
    ' Initialisation - runs once on first load, wires up static control config
    ' =========================================================================

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 759
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ' --- Receiver ---
        ucrReceiverMultipleGGLikert.SetParameter(New RParameter("include", POS_INCLUDE))
        ucrReceiverMultipleGGLikert.SetParameterIsRFunction()
        ucrReceiverMultipleGGLikert.Selector = ucrSelectorGGLikert
        ucrReceiverMultipleGGLikert.SetMeAsReceiver()
        ucrReceiverMultipleGGLikert.SetIncludedDataTypes({"factor", "ordered"})
        ucrReceiverMultipleGGLikert.strSelectorHeading = "Factors"

        ' --- Checkboxes ---
        ucrChkSort.SetText("Sort")
        ucrChkSort.AddToLinkedControls(ucrChkDescending, {True},
                                       bNewLinkedAddRemoveParameter:=False,
                                       bNewLinkedHideIfParameterMissing:=False)
        ucrChkDescending.SetText("Descending")

        ucrChkReverse.SetText("Reverse")
        ucrChkReverse.SetParameter(New RParameter("reverse_likert", POS_REVERSE))
        ucrChkReverse.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkReverse.SetRDefault("FALSE")

        ucrChkSymmetric.SetText("Symmetric")
        ucrChkSymmetric.SetParameter(New RParameter("symmetric", POS_SYMMETRIC))
        ucrChkSymmetric.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSymmetric.SetRDefault("FALSE")

        ucrChkCutoff.SetText("Cutoff")
        ucrChkCutoff.AddToLinkedControls(ucrNudCutoff, {True},
                                         bNewLinkedAddRemoveParameter:=True,
                                         bNewLinkedHideIfParameterMissing:=True)

        ucrChkWrap.SetText("Wrap")
        ucrChkWrap.AddToLinkedControls(ucrNudWrap, {True},
                               bNewLinkedAddRemoveParameter:=False,
                               bNewLinkedHideIfParameterMissing:=True)

        ucrChkValues.SetText("Values")
        ucrChkValues.SetParameter(New RParameter("add_labels", POS_ADD_LABELS))
        ucrChkValues.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkValues.SetRDefault("TRUE")

        ucrChkTotals.SetText("Totals")
        ucrChkTotals.SetParameter(New RParameter("add_totals", POS_ADD_TOTALS))
        ucrChkTotals.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkTotals.SetRDefault("TRUE")

        ' --- Numeric controls ---
        ucrNudCutoff.SetParameter(New RParameter("cutoff", POS_CUTOFF))
        ucrNudCutoff.Minimum = 0
        ucrNudCutoff.Maximum = 9
        ucrNudCutoff.Increment = 0.5
        ucrNudCutoff.DecimalPlaces = 1
        ucrNudCutoff.SetRDefault(0)
        ucrNudCutoff.nudUpDown.ReadOnly = False

        ucrNudWrap.SetParameter(New RParameter("y_label_wrap", POS_LABEL_WRAP))
        ucrNudWrap.Minimum = 10
        ucrNudWrap.Maximum = 50
        ucrNudWrap.Increment = 1
        ucrNudWrap.DecimalPlaces = 0
        ucrNudWrap.SetRDefault(20)
        ucrNudWrap.nudUpDown.ReadOnly = False

        ucrNudCutoffLevel.Minimum = 1
        ucrNudCutoffLevel.Maximum = iNumLevels
        ucrNudCutoffLevel.Increment = 1
        ucrNudCutoffLevel.DecimalPlaces = 0
        ucrNudCutoffLevel.nudUpDown.ReadOnly = False

        ucrNudExclude.SetParameter(New RParameter("exclude_fill_values", POS_EXCLUDE_FILL))
        ucrNudExclude.Minimum = 0
        ucrNudExclude.Maximum = iNumLevels
        ucrNudExclude.Increment = 1
        ucrNudExclude.DecimalPlaces = 0
        ucrNudExclude.SetRDefault(0)
        ucrNudExclude.nudUpDown.ReadOnly = False

        ' Warning label placed to the right of the cutoff nudge
        lblCutoffClampWarning = New Label()
        lblCutoffClampWarning.Name = "lblCutoffClampWarning"
        lblCutoffClampWarning.Text = "Cutoff exceeds remaining levels"
        lblCutoffClampWarning.ForeColor = Color.Red
        lblCutoffClampWarning.AutoSize = True
        lblCutoffClampWarning.Visible = False
        lblCutoffClampWarning.Location = New Point(
            ucrChkDescending.Right + 5,
            ucrChkDescending.Top + (ucrChkDescending.Height - lblCutoffClampWarning.PreferredHeight) \ 2)
        Me.Controls.Add(lblCutoffClampWarning)

        ' Side-chart-only controls start hidden
        lblCutoffLevel.Visible = False
        ucrNudCutoffLevel.Visible = False

        ' --- Save control ---
        ucrSaveGGLikert.SetPrefix("gglikert_graph")
        ucrSaveGGLikert.SetSaveTypeAsGraph()
        ucrSaveGGLikert.SetDataFrameSelector(ucrSelectorGGLikert.ucrAvailableDataFrames)
        ucrSaveGGLikert.SetAssignToIfUncheckedValue("last_graph")
        ucrSaveGGLikert.SetCheckBoxText("Store Graph")

        ' --- Facet controls ---
        ucr1stFactorReceiver.SetParameter(New RParameter("rows", bNewIncludeArgumentName:=False))
        ucr1stFactorReceiver.Selector = ucrSelectorGGLikert
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.SetLinkedDisplayControl(lblFacetBy)

        ucrInputStation.SetItems({FACET_WRAP, FACET_ROW, FACET_COL, FACET_NONE})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ' --- Legend controls ---
        ucrChkLegend.SetText("Legend:")
        ucrChkLegend.AddToLinkedControls({ucrInputLegendPosition}, {True},
                                      bNewLinkedAddRemoveParameter:=True,
                                      bNewLinkedHideIfParameterMissing:=True,
                                      bNewLinkedChangeToDefaultState:=True,
                                      objNewDefaultState:="None")
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

    ' =========================================================================
    ' SetDefaults - resets all state; follows the flat pattern used in other
    ' R-Instat dialogs (dlgDescribeTwoVarGraph, dlgOneVariableGraph, etc.)
    ' =========================================================================

    Private Sub SetDefaults()
        ' --- R function objects ---
        clsGGLikertFunction = New RFunction
        clsGGLikertFunction.SetPackageName("ggstats")
        clsGGLikertFunction.SetRCommand("gglikert")

        clsBaseOperator = New ROperator
        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("plot",
                                     clsRFunctionParameter:=clsGGLikertFunction,
                                     iPosition:=POS_DATA)
        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsBaseOperator.SetAssignTo("last_graph",
                                    strTempDataframe:=ucrSelectorGGLikert.strCurrentDataFrame,
                                    strTempGraph:="last_graph")

        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)

        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXLabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYLabsFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        If GgplotDefaults.clsXScaleDateFunction IsNot Nothing Then
            clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        End If
        If GgplotDefaults.clsYScaleDateFunction IsNot Nothing Then
            clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        End If

        ' --- Facet state ---
        clsFacetFunction = New RFunction
        clsRowVarsFunction = New RFunction
        clsColVarsFunction = New RFunction

        clsRowVarsFunction.SetPackageName("ggplot2")
        clsRowVarsFunction.SetRCommand("vars")
        clsColVarsFunction.SetPackageName("ggplot2")
        clsColVarsFunction.SetRCommand("vars")

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetFunction.AddParameter("facets",
                                      clsRFunctionParameter:=clsRowVarsFunction,
                                      iPosition:=POS_DATA)

        ucrInputStation.SetName(FACET_WRAP)

        If clsFacetAfterCode IsNot Nothing Then
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsFacetAfterCode)
            clsFacetAfterCode = Nothing
        End If

        ' --- Dialog state ---
        bSortChecked = False
        bDescendingChecked = False
        bResetSubdialog = True
        bLevelsMatch = True
        iNumLevels = 5
        dPreservedCutoff = 0

        ' --- Chart type ---
        rdoLikert.Checked = True
        cmdLikertOptions.Enabled = False
        cmdPlotOptions.Enabled = False

        ' --- Checkbox states (via their R defaults where possible;
        '     hard-coded only for controls that have no SetRDefault path) ---
        ucrChkSort.Checked = False
        ucrChkDescending.Checked = False
        ucrChkDescending.Enabled = False
        ucrChkReverse.Checked = False
        ucrChkReverse.Enabled = True
        ucrChkSymmetric.Checked = False
        ucrChkSymmetric.Enabled = True
        ucrChkCutoff.Checked = False
        ucrChkWrap.Checked = False
        ucrChkValues.Checked = True
        ucrChkTotals.Checked = True
        ucrChkLegend.Checked = False

        ' --- Numeric control values (match SetRDefault / Minimum defaults) ---
        ucrNudCutoff.Value = 0
        ucrNudWrap.Value = 20
        ucrNudCutoffLevel.Value = iNumLevels
        ucrNudExclude.Value = 0

        ' --- Visibility: controls that start hidden until a chart type enables them ---
        ucrNudCutoff.Visible = False
        ucrNudWrap.Visible = False
        lblCutoffLevel.Visible = False
        ucrNudCutoffLevel.Visible = False
        lblExclude.Visible = True
        ucrNudExclude.Visible = True
        lblLevelsWarning.Visible = False
        If lblCutoffClampWarning IsNot Nothing Then lblCutoffClampWarning.Visible = False

        ' --- Selector / save ---
        ucrSelectorGGLikert.Reset()
        ucrSaveGGLikert.Reset()
    End Sub

    ' =========================================================================
    ' R code wiring - links controls to their R function parameters
    ' =========================================================================

    Private Sub SetRCodeForControls(bResetCode As Boolean)
        If clsGGLikertFunction Is Nothing Then Exit Sub

        If Not rdoStacked.Checked Then
            ucrChkReverse.SetRCode(clsGGLikertFunction, bResetCode)
            ucrChkSymmetric.SetRCode(clsGGLikertFunction, bResetCode)
        End If

        ' Only wire cutoff controls when not Stacked (gglikert_stacked has no cutoff parameter)
        If Not rdoStacked.Checked Then
            ucrChkCutoff.SetRCode(clsGGLikertFunction, bResetCode)
            ucrNudCutoff.SetRCode(clsGGLikertFunction, bResetCode)
        Else
            ucrChkCutoff.SetRCode(Nothing, bResetCode)
            ucrNudCutoff.SetRCode(Nothing, bResetCode)
        End If

        ucrChkValues.SetRCode(clsGGLikertFunction, bResetCode)
        ucrChkTotals.SetRCode(clsGGLikertFunction, bResetCode)
        ucr1stFactorReceiver.SetRCode(clsRowVarsFunction, bResetCode)

        SyncWrapParameter()

        If rdoStacked.Checked OrElse rdoLikert.Checked Then
            ucrSaveGGLikert.SetRCode(clsBaseOperator, bResetCode)
        Else
            ucrSaveGGLikert.SetRCode(clsGGLikertFunction, bResetCode)
        End If

        ucrChkLegend.SetRCode(clsThemeFunction, bResetCode, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bResetCode, bCloneIfNeeded:=True)
    End Sub

    ' Keeps the y_label_wrap parameter in sync with the checkbox + nudge state.
    Private Sub SyncWrapParameter()
        If clsGGLikertFunction Is Nothing Then Exit Sub
        If ucrChkWrap.Checked Then
            clsGGLikertFunction.AddParameter("y_label_wrap",
                                             CStr(CInt(ucrNudWrap.Value)),
                                             iPosition:=POS_LABEL_WRAP)
        Else
            clsGGLikertFunction.RemoveParameterByName("y_label_wrap")
        End If
    End Sub

    ' =========================================================================
    ' Chart type switching
    ' =========================================================================

    Private Sub ApplyChartType(chartType As ChartType)
        If clsGGLikertFunction Is Nothing Then Exit Sub

        Select Case chartType
            Case ChartType.Stacked
                clsGGLikertFunction.SetRCommand("gglikert_stacked")
                If ucrChkCutoff.Checked Then dPreservedCutoff = ucrNudCutoff.Value
                clsGGLikertFunction.RemoveParameterByName("side_values")
                clsGGLikertFunction.RemoveParameterByName("reverse_likert")
                clsGGLikertFunction.RemoveParameterByName("symmetric")
                clsGGLikertFunction.RemoveParameterByName("cutoff_after")
                clsGGLikertFunction.RemoveParameterByName("exclude_fill_values")
                clsGGLikertFunction.RemoveParameterByName("cutoff")

            Case ChartType.Likert
                clsGGLikertFunction.SetRCommand("gglikert")
                clsGGLikertFunction.RemoveParameterByName("side_values")
                clsGGLikertFunction.RemoveParameterByName("cutoff_after")
                clsGGLikertFunction.RemoveParameterByName("exclude_fill_values")
                RestoreCutoff()
                ucrNudCutoff.SetRCode(clsGGLikertFunction, False)

            Case ChartType.Side
                clsGGLikertFunction.SetRCommand("gglikert_side")
                clsGGLikertFunction.RemoveParameterByName("exclude_fill_values")
                clsGGLikertFunction.RemoveParameterByName("reverse_likert")
                clsGGLikertFunction.RemoveParameterByName("symmetric")
                RestoreCutoff()
                UpdateCutoffLevelBounds()
                SyncSideValuesParameter()
        End Select

        Dim bIsStacked As Boolean = (chartType = ChartType.Stacked)
        Dim bIsSide As Boolean = (chartType = ChartType.Side)

        ucrChkReverse.Enabled = Not bIsStacked
        ucrChkSymmetric.Enabled = Not bIsStacked
        ucrChkCutoff.Enabled = Not bIsStacked
        ucrNudCutoff.Enabled = Not bIsStacked AndAlso ucrChkCutoff.Checked

        lblExclude.Visible = Not bIsStacked AndAlso Not bIsSide
        ucrNudExclude.Visible = Not bIsStacked AndAlso Not bIsSide

        lblCutoffLevel.Visible = bIsSide
        ucrNudCutoffLevel.Visible = bIsSide

        If bIsSide Then
            clsBaseOperator.RemoveParameterByName("theme_name")
        Else
            If Not clsBaseOperator.ContainsParameter("theme_name") Then
                clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
            End If
        End If

        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        AddRemoveFacets()
    End Sub

    ''' <summary>
    ''' Syncs the side_values parameter from ucrNudCutoffLevel.
    ''' </summary>
    Private Sub SyncSideValuesParameter()
        If clsGGLikertFunction Is Nothing Then Exit Sub
        clsGGLikertFunction.RemoveParameterByName("side_values")

        If ucrReceiverMultipleGGLikert.IsEmpty() OrElse iNumLevels <= 0 Then Exit Sub

        Dim varNames As List(Of String) = ucrReceiverMultipleGGLikert.GetVariableNamesAsList()
        If varNames Is Nothing OrElse varNames.Count = 0 Then Exit Sub
        Dim strFirstVar As String = varNames(0)
        If String.IsNullOrEmpty(strFirstVar) Then Exit Sub

        Dim iSelectedIndex As Integer = CInt(ucrNudCutoffLevel.Value)
        If iSelectedIndex < 1 Then iSelectedIndex = 1
        If iSelectedIndex > iNumLevels Then iSelectedIndex = iNumLevels

        Dim strScript As String = BuildGetLevelsScript(
            ucrSelectorGGLikert.strCurrentDataFrame, strFirstVar)

        Dim expLevels = frmMain.clsRLink.RunInternalScriptGetValue(strScript, bSilent:=True)
        If expLevels Is Nothing OrElse
           expLevels.Type = Internals.SymbolicExpressionType.Null Then Exit Sub

        Dim arrLevels = expLevels.AsCharacter()
        If arrLevels Is Nothing OrElse arrLevels.Length = 0 Then Exit Sub

        Dim iArrayIndex As Integer = Math.Max(0, Math.Min(iSelectedIndex - 1, arrLevels.Length - 1))

        clsGGLikertFunction.AddParameter("side_values",
                                         Chr(34) & arrLevels(iArrayIndex) & Chr(34),
                                         iPosition:=POS_SIDE_VALUES,
                                         bIncludeArgumentName:=True)
    End Sub

    ' Radio button handlers delegate to ApplyChartType

    Private Sub rdoStacked_CheckedChanged(sender As Object, e As EventArgs) Handles rdoStacked.CheckedChanged
        If rdoStacked.Checked Then ApplyChartType(ChartType.Stacked)
    End Sub

    Private Sub rdoLikert_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLikert.CheckedChanged
        If rdoLikert.Checked Then ApplyChartType(ChartType.Likert)
    End Sub

    Private Sub rdoSide_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSide.CheckedChanged
        If rdoSide.Checked Then ApplyChartType(ChartType.Side)
    End Sub

    ' =========================================================================
    ' Facet management
    ' =========================================================================

    Private Sub AddRemoveFacets()
        If clsBaseOperator Is Nothing OrElse clsGGLikertFunction Is Nothing Then Exit Sub
        RemoveFacets()
        If Not ucr1stFactorReceiver.IsEmpty Then
            RebuildFacets()
        End If
    End Sub

    Private Sub RemoveFacets()
        clsGGLikertFunction.RemoveParameterByName("facet_rows")
        clsGGLikertFunction.RemoveParameterByName("facet_cols")
        clsBaseOperator.RemoveParameterByName("facet_layer")

        If clsFacetAfterCode IsNot Nothing Then
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsFacetAfterCode)
            clsFacetAfterCode = Nothing
        End If
    End Sub

    Private Sub RebuildFacets()
        Dim strFacetType As String = ucrInputStation.GetText()
        If strFacetType = FACET_NONE Then Exit Sub

        If rdoStacked.Checked Then
            Dim clsFacetLayer As RFunction = BuildFacetLayerFunction(strFacetType)
            If clsFacetLayer Is Nothing Then Exit Sub
            clsBaseOperator.AddParameter("facet_layer",
                                         clsRFunctionParameter:=clsFacetLayer,
                                         iPosition:=POS_FACET_LAYER)
            clsFacetAfterCode = clsFacetLayer
        Else
            Select Case strFacetType
                Case FACET_WRAP, FACET_ROW
                    clsGGLikertFunction.AddParameter("facet_rows",
                                                     clsRFunctionParameter:=clsRowVarsFunction,
                                                     iPosition:=POS_FACET_ROWS)
                Case FACET_COL
                    clsGGLikertFunction.AddParameter("facet_cols",
                                                     clsRFunctionParameter:=clsRowVarsFunction,
                                                     iPosition:=POS_FACET_COLS)
            End Select
        End If
    End Sub

    Private Function BuildFacetLayerFunction(strFacetType As String) As RFunction
        Dim clsLayer As New RFunction
        clsLayer.SetPackageName("ggplot2")

        Select Case strFacetType
            Case FACET_WRAP
                clsLayer.SetRCommand("facet_wrap")
                clsLayer.AddParameter("facets",
                                      clsRFunctionParameter:=clsRowVarsFunction,
                                      iPosition:=POS_DATA,
                                      bIncludeArgumentName:=False)
            Case FACET_ROW
                clsLayer.SetRCommand("facet_grid")
                clsLayer.AddParameter("rows",
                                      clsRFunctionParameter:=clsRowVarsFunction,
                                      iPosition:=POS_DATA)
            Case FACET_COL
                clsLayer.SetRCommand("facet_grid")
                clsLayer.AddParameter("cols",
                                      clsRFunctionParameter:=clsRowVarsFunction,
                                      iPosition:=POS_DATA)
            Case Else
                Return Nothing
        End Select

        Return clsLayer
    End Function

    ' =========================================================================
    ' Data / include parameter helpers
    ' =========================================================================

    Private Sub UpdateDataAndIncludeParameters()
        If clsGGLikertFunction Is Nothing Then Exit Sub

        If ucrReceiverMultipleGGLikert.IsEmpty() Then
            clsGGLikertFunction.RemoveParameterByName("data")
            clsGGLikertFunction.RemoveParameterByName("include")
            Exit Sub
        End If

        Dim varNames As List(Of String) = ucrReceiverMultipleGGLikert.GetVariableNamesAsList()

        Dim clsGetDf As New RFunction
        clsGetDf.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDf.AddParameter("data_name",
                              Chr(34) & ucrSelectorGGLikert.strCurrentDataFrame & Chr(34))
        clsGGLikertFunction.RemoveParameterByName("data")
        clsGGLikertFunction.AddParameter("data",
                                         clsRFunctionParameter:=clsGetDf,
                                         iPosition:=POS_DATA,
                                         bIncludeArgumentName:=True)

        Dim clsInclude As New RFunction
        clsInclude.SetRCommand("c")
        For i As Integer = 0 To varNames.Count - 1
            clsInclude.AddParameter(i.ToString(),
                                    varNames(i),
                                    bIncludeArgumentName:=False,
                                    iPosition:=i)
        Next

        clsGGLikertFunction.AddParameter("include",
                                         clsRFunctionParameter:=clsInclude,
                                         iPosition:=POS_INCLUDE,
                                         bIncludeArgumentName:=True)
    End Sub

    ''' <summary>
    ''' Ensures every selected variable has a clean, non-dotted label.
    ''' </summary>
    Private Sub SetVariableLabels()
        If ucrReceiverMultipleGGLikert.IsEmpty() Then Exit Sub
        Dim varNames As List(Of String) = ucrReceiverMultipleGGLikert.GetVariableNamesAsList()
        If varNames Is Nothing OrElse varNames.Count = 0 Then Exit Sub
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
    End Sub

    Private Sub UpdateSortParameter()
        If clsGGLikertFunction Is Nothing Then Exit Sub
        If bSortChecked Then
            Dim strSortValue As String = If(bDescendingChecked, "descending", "ascending")
            clsGGLikertFunction.AddParameter("sort",
                                             Chr(34) & strSortValue & Chr(34),
                                             iPosition:=POS_SORT)
        Else
            clsGGLikertFunction.AddParameter("sort",
                                             Chr(34) & "none" & Chr(34),
                                             iPosition:=POS_SORT)
        End If
    End Sub

    ' =========================================================================
    ' Level validation
    ' =========================================================================

    Private Sub CheckSelectedFactorsHaveSameLevels()
        If ucrReceiverMultipleGGLikert.IsEmpty() Then
            bLevelsMatch = True
            lblLevelsWarning.Visible = False
            Exit Sub
        End If

        Dim strScript As String = BuildGetNumLevelsScript(
            ucrSelectorGGLikert.strCurrentDataFrame,
            ucrReceiverMultipleGGLikert.GetVariableNames())

        Dim expResult = frmMain.clsRLink.RunInternalScriptGetValue(strScript, bSilent:=True)

        If expResult Is Nothing OrElse
           expResult.Type = Internals.SymbolicExpressionType.Null Then
            bLevelsMatch = True
            lblLevelsWarning.Visible = False
            Exit Sub
        End If

        Dim arrLevels = expResult.AsNumeric()
        If arrLevels Is Nothing OrElse arrLevels.Length = 0 Then
            bLevelsMatch = True
            Exit Sub
        End If

        Dim iFirstLevel As Integer = CInt(arrLevels(0))
        For Each dLevel In arrLevels
            If CInt(dLevel) <> iFirstLevel Then
                bLevelsMatch = False
                lblLevelsWarning.Visible = True
                Exit Sub
            End If
        Next

        bLevelsMatch = True
        lblLevelsWarning.Visible = False
        iNumLevels = iFirstLevel
        UpdateNudgeMaxima()
        If rdoSide.Checked Then UpdateCutoffLevelBounds()
    End Sub

    ''' <summary>
    ''' Central method for the Cutoff/Exclude conflict system.
    ''' </summary>
    Private Sub UpdateNudgeMaxima()
        ucrNudCutoffLevel.Maximum = iNumLevels
        ucrNudExclude.Maximum = iNumLevels

        Dim iEffectiveLevels As Integer = Math.Max(1, iNumLevels - CInt(ucrNudExclude.Value))
        Dim iNewCutoffMax As Decimal = iEffectiveLevels - 1

        Dim bConflict As Boolean = ucrChkCutoff.Checked AndAlso
                                   ucrNudCutoff.Value > iNewCutoffMax

        ' Keep Maximum at least as high as current value to avoid nudge auto-clamping
        ucrNudCutoff.Maximum = Math.Max(iNewCutoffMax, ucrNudCutoff.Value)

        If ucrNudCutoffLevel.Value > ucrNudCutoffLevel.Maximum Then
            ucrNudCutoffLevel.Value = ucrNudCutoffLevel.Maximum
        End If
        If ucrNudExclude.Value > ucrNudExclude.Maximum Then
            ucrNudExclude.Value = ucrNudExclude.Maximum
        End If

        lblCutoffClampWarning.Visible = bConflict

        If bConflict Then
            ucrNudCutoff.nudUpDown.Maximum = ucrNudCutoff.Value
            ucrNudCutoff.nudUpDown.Enabled = True

            Dim iNextEffective As Integer = Math.Max(1, iNumLevels - (CInt(ucrNudExclude.Value) + 1))
            Dim iNextCutoffMax As Decimal = iNextEffective - 1

            If ucrNudCutoff.Value > iNextCutoffMax Then
                ucrNudExclude.nudUpDown.Maximum = ucrNudExclude.Value
            Else
                ucrNudExclude.nudUpDown.Maximum = iNumLevels
            End If
            ucrNudExclude.nudUpDown.Enabled = True
        Else
            ucrNudExclude.nudUpDown.Maximum = iNumLevels
            ucrNudCutoff.nudUpDown.Maximum = iNewCutoffMax
            ucrNudExclude.nudUpDown.Enabled = True
            ucrNudCutoff.nudUpDown.Enabled = True
        End If

        TestOKEnabled()
    End Sub

    Private Sub ucrNudCutoff_ControlValueChanged(ucrChangedControl As ucrCore) _
        Handles ucrNudCutoff.ControlValueChanged
        If clsGGLikertFunction Is Nothing OrElse Not ucrChkCutoff.Checked Then Exit Sub
        UpdateNudgeMaxima()
    End Sub

    ' =========================================================================
    ' R script builders
    ' =========================================================================

    Private Function BuildGetNumLevelsScript(dataFrame As String, colNames As String) As String
        Return String.Format(
            "as.numeric(sapply(data_book$get_columns_from_data(data_name = {0}, col_names = {1}), nlevels))",
            Chr(34) & dataFrame & Chr(34),
            colNames)
    End Function

    Private Function BuildGetLevelsScript(dataFrame As String, colName As String) As String
        Return String.Format(
            "levels({0}$get_columns_from_data(data_name={1}, col_names={2}))",
            frmMain.clsRLink.strInstatDataObject,
            Chr(34) & dataFrame & Chr(34),
            Chr(34) & colName & Chr(34))
    End Function

    ' =========================================================================
    ' OK button enablement
    ' =========================================================================

    Public Sub TestOKEnabled()
        Dim bConflict As Boolean = lblCutoffClampWarning IsNot Nothing AndAlso lblCutoffClampWarning.Visible

        Dim varNames As List(Of String) = ucrReceiverMultipleGGLikert.GetVariableNamesAsList()
        Dim bSingleVar As Boolean = varNames IsNot Nothing AndAlso varNames.Count = 1

        Dim bCanOK As Boolean = Not ucrReceiverMultipleGGLikert.IsEmpty() AndAlso
                                Not bSingleVar AndAlso
                                ucrSaveGGLikert.IsComplete AndAlso
                                bLevelsMatch AndAlso
                                Not bConflict
        ucrBase.OKEnabled(bCanOK)
        cmdPlotOptions.Enabled = Not ucrReceiverMultipleGGLikert.IsEmpty()
    End Sub

    ' =========================================================================
    ' Event handlers - thin delegates; logic lives in the methods above
    ' =========================================================================

    Private Sub ucrReceiverMultipleGGLikert_ControlValueChanged(ucrChangedControl As ucrCore) _
        Handles ucrReceiverMultipleGGLikert.ControlValueChanged
        CheckSelectedFactorsHaveSameLevels()
        SetVariableLabels()
        UpdateDataAndIncludeParameters()
        TestOKEnabled()
        If rdoSide.Checked Then SyncSideValuesParameter()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) _
        Handles ucrReceiverMultipleGGLikert.ControlContentsChanged,
                ucrSaveGGLikert.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorGGLikert_ControlValueChanged(ucrChangedControl As ucrCore) _
        Handles ucrSelectorGGLikert.ControlValueChanged
        If clsBaseOperator Is Nothing Then Exit Sub
        clsBaseOperator.SetAssignTo("last_graph",
                                    strTempDataframe:=ucrSelectorGGLikert.strCurrentDataFrame,
                                    strTempGraph:="last_graph")
        If Not ucrReceiverMultipleGGLikert.IsEmpty() Then
            UpdateDataAndIncludeParameters()
        End If
    End Sub

    Private Sub ucrChkWrap_ControlValueChanged(ucrChangedControl As ucrCore) _
        Handles ucrChkWrap.ControlValueChanged
        SyncWrapParameter()
    End Sub

    Private Sub ucrNudWrap_ControlValueChanged(ucrChangedControl As ucrCore) _
        Handles ucrNudWrap.ControlValueChanged
        SyncWrapParameter()
    End Sub

    Private Sub ucrChkSort_ControlValueChanged(ucrChangedControl As ucrCore) _
        Handles ucrChkSort.ControlValueChanged
        If clsGGLikertFunction Is Nothing Then Exit Sub
        bSortChecked = ucrChkSort.Checked
        ucrChkDescending.Enabled = bSortChecked
        If Not bSortChecked Then
            ucrChkDescending.Checked = False
            bDescendingChecked = False
        End If
        UpdateSortParameter()
    End Sub

    Private Sub ucrChkDescending_ControlValueChanged(ucrChangedControl As ucrCore) _
        Handles ucrChkDescending.ControlValueChanged
        If clsGGLikertFunction Is Nothing Then Exit Sub
        bDescendingChecked = ucrChkDescending.Checked
        If bSortChecked Then UpdateSortParameter()
    End Sub

    Private Sub ucr1stFactorReceiver_ControlValueChanged(ucrChangedControl As ucrCore) _
        Handles ucr1stFactorReceiver.ControlValueChanged
        AddRemoveFacets()
    End Sub

    Private Sub ucrInputStation_ControlValueChanged(ucrChangedControl As ucrCore) _
        Handles ucrInputStation.ControlValueChanged
        AddRemoveFacets()
    End Sub

    Private Sub ucrNudExclude_ControlValueChanged(ucrChangedControl As ucrCore) _
        Handles ucrNudExclude.ControlValueChanged
        If clsGGLikertFunction Is Nothing OrElse Not rdoLikert.Checked Then Exit Sub
        UpdateNudgeMaxima()
        UpdateExcludeFillParameter()
    End Sub

    Private Sub ucrNudCutoffLevel_ControlValueChanged(ucrChangedControl As ucrCore) _
        Handles ucrNudCutoffLevel.ControlValueChanged
        If rdoSide.Checked AndAlso clsGGLikertFunction IsNot Nothing Then
            SyncSideValuesParameter()
        End If
    End Sub

    Private Sub UpdateExcludeFillParameter()
        clsGGLikertFunction.RemoveParameterByName("exclude_fill_values")

        Dim iExclude As Integer = CInt(ucrNudExclude.Value)
        If iExclude = 0 OrElse ucrReceiverMultipleGGLikert.IsEmpty() Then Exit Sub

        Dim strScript As String = BuildGetLevelsScript(
            ucrSelectorGGLikert.strCurrentDataFrame,
            ucrReceiverMultipleGGLikert.GetVariableNamesAsList()(0))

        Dim expLevels = frmMain.clsRLink.RunInternalScriptGetValue(strScript, bSilent:=True)
        If expLevels Is Nothing OrElse
           expLevels.Type = Internals.SymbolicExpressionType.Null Then Exit Sub

        Dim arrLevels = expLevels.AsCharacter()
        If arrLevels Is Nothing OrElse arrLevels.Length < iExclude Then Exit Sub

        If iExclude = 1 Then
            clsGGLikertFunction.AddParameter("exclude_fill_values",
                                             Chr(34) & arrLevels(0) & Chr(34),
                                             iPosition:=POS_EXCLUDE_FILL)
        Else
            Dim clsExcludeVector As New RFunction
            clsExcludeVector.SetRCommand("c")
            For i As Integer = 0 To iExclude - 1
                clsExcludeVector.AddParameter(i.ToString(),
                                              Chr(34) & arrLevels(i) & Chr(34),
                                              bIncludeArgumentName:=False,
                                              iPosition:=i)
            Next
            clsGGLikertFunction.AddParameter("exclude_fill_values",
                                             clsRFunctionParameter:=clsExcludeVector,
                                             iPosition:=POS_EXCLUDE_FILL)
        End If
    End Sub

    Private Sub cmdPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        If clsBaseOperator Is Nothing Then Exit Sub
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

        ' Only re-sync the save control since sdgPlots only touches clsBaseOperator.
        If rdoStacked.Checked OrElse rdoLikert.Checked Then
            ucrSaveGGLikert.SetRCode(clsBaseOperator, False)
        Else
            ucrSaveGGLikert.SetRCode(clsGGLikertFunction, False)
        End If
    End Sub

    Private Sub cmdLikertOptions_Click(sender As Object, e As EventArgs) Handles cmdLikertOptions.Click
        ' TODO: open sdgLikertOptions sub-dialog when implemented
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction Is Nothing Then Exit Sub
        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ucrChkLegend_ControlValueChanged(ucrChangedControl As ucrCore) _
        Handles ucrChkLegend.ControlValueChanged,
                ucrInputLegendPosition.ControlValueChanged
        AddRemoveTheme()
    End Sub

    Private Sub UpdateCutoffLevelBounds()
        ucrNudCutoffLevel.Minimum = 1.0
        ucrNudCutoffLevel.Maximum = iNumLevels
        If ucrNudCutoffLevel.Value < 1 Then ucrNudCutoffLevel.Value = 1
        If ucrNudCutoffLevel.Value > iNumLevels Then ucrNudCutoffLevel.Value = iNumLevels
    End Sub

    Private Sub RestoreCutoff()
        If clsGGLikertFunction Is Nothing Then Exit Sub
        If Not ucrChkCutoff.Checked Then Exit Sub
        ucrNudCutoff.Value = dPreservedCutoff
        clsGGLikertFunction.AddParameter("cutoff",
            CStr(CDbl(dPreservedCutoff)),
            iPosition:=POS_CUTOFF)
    End Sub
End Class