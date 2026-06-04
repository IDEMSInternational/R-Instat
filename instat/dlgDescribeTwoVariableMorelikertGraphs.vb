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
        ucrBase.iHelpTopicID = 0
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        InitialiseReceiverControl()
        InitialiseCheckboxControls()
        InitialiseNumericControls()
        InitialiseSaveControl()
        InitialiseFacetControls()
    End Sub

    Private Sub InitialiseReceiverControl()
        ucrReceiverMultipleGGLikert.SetParameter(New RParameter("include", POS_INCLUDE))
        ucrReceiverMultipleGGLikert.SetParameterIsRFunction()
        ucrReceiverMultipleGGLikert.Selector = ucrSelectorGGLikert
        ucrReceiverMultipleGGLikert.SetMeAsReceiver()
        ucrReceiverMultipleGGLikert.SetIncludedDataTypes({"factor", "ordered"})
        ucrReceiverMultipleGGLikert.strSelectorHeading = "Factors"
    End Sub

    Private Sub InitialiseCheckboxControls()
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
    End Sub

    Private Sub InitialiseNumericControls()
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
        ucrNudWrap.SetRDefault(50)
        ucrNudWrap.nudUpDown.ReadOnly = False

        ' ucrNudCutoffLevel: selects which level (by index, 1-based) goes on the side.
        ' Maps to side_values parameter with the actual level name.
        ' Not wired via SetParameter/SetRCode - managed manually to avoid collision
        ' with ucrNudCutoff which uses parameter name "cutoff".
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

        ' Warning label to the right of ucrNudCutoff
        lblCutoffClampWarning = New Label()
        lblCutoffClampWarning.Name = "lblCutoffClampWarning"
        lblCutoffClampWarning.Text = "Cutoff exceeds remaining levels"
        lblCutoffClampWarning.ForeColor = Color.Red
        lblCutoffClampWarning.AutoSize = True
        lblCutoffClampWarning.Visible = False
        lblCutoffClampWarning.Location = New Point(
            ucrNudCutoff.Right + 5,
            ucrNudCutoff.Top + (ucrNudCutoff.Height - lblCutoffClampWarning.PreferredHeight) \ 2)
        Me.Controls.Add(lblCutoffClampWarning)

        ' Side-chart-only controls start hidden
        lblCutoffLevel.Visible = False
        ucrNudCutoffLevel.Visible = False
    End Sub

    Private Sub InitialiseSaveControl()
        ucrSaveGGLikert.SetPrefix("gglikert_graph")
        ucrSaveGGLikert.SetSaveTypeAsGraph()
        ucrSaveGGLikert.SetDataFrameSelector(ucrSelectorGGLikert.ucrAvailableDataFrames)
        ucrSaveGGLikert.SetAssignToIfUncheckedValue("last_graph")
        ucrSaveGGLikert.SetCheckBoxText("Store Graph")
    End Sub

    Private Sub InitialiseFacetControls()
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
    End Sub

    ' =========================================================================
    ' SetDefaults - broken into focused sub-methods so each area is easy to find
    ' =========================================================================

    Private Sub SetDefaults()
        ResetRFunctions()
        ResetCheckboxStates()
        ResetNumericValues()
        ResetVisibility()
        ResetFacetState()

        bSortChecked = False
        bDescendingChecked = False
        bResetSubdialog = True
        bLevelsMatch = True

        rdoLikert.Checked = True
        cmdLikertOptions.Enabled = False
        cmdPlotOptions.Enabled = False

        ucrSelectorGGLikert.Reset()
        ucrSaveGGLikert.Reset()
    End Sub

    Private Sub ResetRFunctions()
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
    End Sub

    Private Sub ResetCheckboxStates()
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
    End Sub

    Private Sub ResetNumericValues()
        ucrNudCutoff.Value = 0
        ucrNudWrap.Value = 50
        ucrNudCutoffLevel.Value = iNumLevels
        ucrNudExclude.Value = 0
    End Sub

    'Private Sub ResetVisibility()
    '    ucrNudCutoff.Visible = False
    '    ucrNudWrap.Visible = False
    '    lblCutoffLevel.Visible = False
    '    ucrNudCutoffLevel.Visible = False
    '    lblExclude.Visible = True
    '    ucrNudExclude.Visible = True
    '    lblLevelsWarning.Visible = False
    'End Sub

    Private Sub ResetVisibility()
        ucrNudCutoff.Visible = False
        ucrNudWrap.Visible = False
        lblCutoffLevel.Visible = False
        ucrNudCutoffLevel.Visible = False
        lblExclude.Visible = True
        ucrNudExclude.Visible = True
        lblLevelsWarning.Visible = False
        If lblCutoffClampWarning IsNot Nothing Then lblCutoffClampWarning.Visible = False
    End Sub

    Private Sub ResetFacetState()
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
            ' Disconnect cutoff controls from Stacked to prevent unused argument error
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
    End Sub

    ' Keeps the y_label_wrap parameter in sync with the checkbox + nudge state.
    ' Called from both the checkbox and nudge change handlers.
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
    ' Chart type switching - single method replaces three near-identical handlers
    ' =========================================================================

    Private Sub ApplyChartType(chartType As ChartType)
        If clsGGLikertFunction Is Nothing Then Exit Sub

        ' --- Set the R command and strip parameters that don't apply ---
        Select Case chartType
            Case ChartType.Stacked
                clsGGLikertFunction.SetRCommand("gglikert_stacked")
                ' Preserve the user's cutoff before stripping it — gglikert_stacked has no
                ' cutoff parameter, so we must be able to restore it on the way back.
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
                RestoreCutoff()                                  ' <-- re-add before re-binding
                ucrNudCutoff.SetRCode(clsGGLikertFunction, False)

            Case ChartType.Side
                clsGGLikertFunction.SetRCommand("gglikert_side")
                clsGGLikertFunction.RemoveParameterByName("exclude_fill_values")
                clsGGLikertFunction.RemoveParameterByName("reverse_likert")
                clsGGLikertFunction.RemoveParameterByName("symmetric")
                RestoreCutoff()
                SyncSideValuesParameter()
        End Select

        ' --- Update UI controls enabled/visible state ---
        Dim bIsStacked As Boolean = (chartType = ChartType.Stacked)
        Dim bIsSide As Boolean = (chartType = ChartType.Side)

        ucrChkReverse.Enabled = Not bIsStacked
        ucrChkSymmetric.Enabled = Not bIsStacked
        ' Disable cutoff checkbox for Stacked (no cutoff parameter in gglikert_stacked)
        ucrChkCutoff.Enabled = Not bIsStacked
        ucrNudCutoff.Enabled = Not bIsStacked AndAlso ucrChkCutoff.Checked

        lblExclude.Visible = Not bIsStacked AndAlso Not bIsSide
        ucrNudExclude.Visible = Not bIsStacked AndAlso Not bIsSide
        SetSideNudgesVisible(bIsSide)

        ' Stacked chart: theme goes on the operator; side chart: no theme on operator
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
    ''' Looks up the level name at the selected index (1-based) and sets it as
    ''' a quoted string parameter on the R function.
    ''' </summary>
    Private Sub SyncSideValuesParameter()
        If clsGGLikertFunction Is Nothing Then Exit Sub

        ' Always remove existing side_values first
        clsGGLikertFunction.RemoveParameterByName("side_values")

        If ucrReceiverMultipleGGLikert.IsEmpty() OrElse iNumLevels <= 0 Then Exit Sub

        Dim varNames As List(Of String) = ucrReceiverMultipleGGLikert.GetVariableNamesAsList()
        If varNames Is Nothing OrElse varNames.Count = 0 Then Exit Sub
        Dim strFirstVar As String = varNames(0)
        If String.IsNullOrEmpty(strFirstVar) Then Exit Sub

        Dim iSelectedIndex As Integer = CInt(ucrNudCutoffLevel.Value)
        ' Clamp to valid range
        If iSelectedIndex < 1 Then iSelectedIndex = 1
        If iSelectedIndex > iNumLevels Then iSelectedIndex = iNumLevels

        Dim strScript As String = BuildGetLevelsScript(
            ucrSelectorGGLikert.strCurrentDataFrame,
            strFirstVar)

        Dim expLevels = frmMain.clsRLink.RunInternalScriptGetValue(strScript, bSilent:=True)
        If expLevels Is Nothing OrElse
           expLevels.Type = Internals.SymbolicExpressionType.Null Then Exit Sub

        Dim arrLevels = expLevels.AsCharacter()
        If arrLevels Is Nothing OrElse arrLevels.Length = 0 Then Exit Sub

        ' Convert 1-based UI index to 0-based array index
        Dim iArrayIndex As Integer = iSelectedIndex - 1
        If iArrayIndex >= arrLevels.Length Then iArrayIndex = arrLevels.Length - 1
        If iArrayIndex < 0 Then iArrayIndex = 0

        clsGGLikertFunction.AddParameter("side_values",
                                         Chr(34) & arrLevels(iArrayIndex) & Chr(34),
                                         iPosition:=POS_SIDE_VALUES,
                                         bIncludeArgumentName:=True)
    End Sub

    ' Radio button handlers simply delegate to ApplyChartType

    Private Sub rdoStacked_CheckedChanged(sender As Object, e As EventArgs) Handles rdoStacked.CheckedChanged
        If rdoStacked.Checked Then ApplyChartType(ChartType.Stacked)
    End Sub

    Private Sub rdoLikert_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLikert.CheckedChanged
        If rdoLikert.Checked Then ApplyChartType(ChartType.Likert)
    End Sub

    Private Sub rdoSide_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSide.CheckedChanged
        If rdoSide.Checked Then ApplyChartType(ChartType.Side)
    End Sub

    Private Sub SetSideNudgesVisible(bVisible As Boolean)
        lblCutoffLevel.Visible = bVisible
        ucrNudCutoffLevel.Visible = bVisible
    End Sub

    ' =========================================================================
    ' Facet management - split into teardown + rebuild so the path is predictable
    ' =========================================================================

    Private Sub AddRemoveFacets()
        If clsBaseOperator Is Nothing OrElse clsGGLikertFunction Is Nothing Then Exit Sub
        RemoveFacets()
        If Not ucr1stFactorReceiver.IsEmpty Then
            RebuildFacets()
        End If
    End Sub

    ''' <summary>Tears down all facet state cleanly before rebuilding.</summary>
    Private Sub RemoveFacets()
        clsGGLikertFunction.RemoveParameterByName("facet_rows")
        clsGGLikertFunction.RemoveParameterByName("facet_cols")
        clsBaseOperator.RemoveParameterByName("facet_layer")

        If clsFacetAfterCode IsNot Nothing Then
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsFacetAfterCode)
            clsFacetAfterCode = Nothing
        End If
    End Sub

    ''' <summary>
    ''' Adds the correct facet parameters or operator layer based on current
    ''' chart type and the chosen facet type.
    ''' </summary>
    Private Sub RebuildFacets()
        Dim strFacetType As String = ucrInputStation.GetText()
        If strFacetType = FACET_NONE Then Exit Sub

        If rdoStacked.Checked Then
            ' Stacked chart: faceting is done via an extra ggplot2 layer on the operator
            Dim clsFacetLayer As RFunction = BuildFacetLayerFunction(strFacetType)
            If clsFacetLayer Is Nothing Then Exit Sub
            clsBaseOperator.AddParameter("facet_layer",
                                         clsRFunctionParameter:=clsFacetLayer,
                                         iPosition:=POS_FACET_LAYER)
            clsFacetAfterCode = clsFacetLayer
        Else
            ' Likert / Side: use the native facet_rows / facet_cols parameters
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

    ' <summary>
    ' Builds the correct ggplot2 facet function for the Stacked chart type.
    ' Returns Nothing if the facet type is unrecognised.
    ' </summary>
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

    ' <summary>
    ' Keeps the data= and include= parameters on the R function in sync with
    ' whatever is currently in the receiver control.
    ' </summary>
    Private Sub UpdateDataAndIncludeParameters()
        If clsGGLikertFunction Is Nothing Then Exit Sub

        If ucrReceiverMultipleGGLikert.IsEmpty() Then
            clsGGLikertFunction.RemoveParameterByName("data")
            clsGGLikertFunction.RemoveParameterByName("include")
            Exit Sub
        End If

        Dim clsGetDf As New RFunction
        clsGetDf.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDf.AddParameter("data_name",
                              Chr(34) & ucrSelectorGGLikert.strCurrentDataFrame & Chr(34))

        Dim clsInclude As New RFunction
        clsInclude.SetRCommand("c")
        Dim varNames As List(Of String) = ucrReceiverMultipleGGLikert.GetVariableNamesAsList()
        For i As Integer = 0 To varNames.Count - 1
            clsInclude.AddParameter(i.ToString(), varNames(i),
                                    bIncludeArgumentName:=False, iPosition:=i)
        Next

        clsGGLikertFunction.AddParameter("data",
                                         clsRFunctionParameter:=clsGetDf,
                                         iPosition:=POS_DATA,
                                         bIncludeArgumentName:=True)
        clsGGLikertFunction.AddParameter("include",
                                         clsRFunctionParameter:=clsInclude,
                                         iPosition:=POS_INCLUDE,
                                         bIncludeArgumentName:=True)
    End Sub

    ''' <summary>Syncs the sort= parameter based on the current checkbox states.</summary>
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

    ' <summary>
    ' Checks that all selected factors have the same number of levels.
    ' Updates bLevelsMatch and shows/hides the warning label accordingly.
    ' Also updates the nudge control maxima when levels are confirmed.
    ' </summary>
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
    End Sub

    ''' <summary>
    ''' Central method for the Cutoff/Exclude conflict system.
    ''' Called whenever iNumLevels, Exclude, or Cutoff changes.
    ''' 
    ''' Logic:
    '''   effective levels  = iNumLevels - Exclude
    '''   max valid cutoff  = effective levels - 1
    '''   conflict          = Cutoff > max valid cutoff
    ''' 
    ''' On conflict: warning shown, OK blocked, up-arrows restricted.
    ''' On resolution: warning hidden, OK re-enabled, maxima restored.
    ''' </summary>
    Private Sub UpdateNudgeMaxima()
        ucrNudCutoffLevel.Maximum = iNumLevels
        ucrNudExclude.Maximum = iNumLevels

        Dim iEffectiveLevels As Integer = iNumLevels - CInt(ucrNudExclude.Value)
        If iEffectiveLevels < 1 Then iEffectiveLevels = 1
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

        'Dim lbl As Label = TryCast(Me.Controls.Find("lblCutoffClampWarning", True).FirstOrDefault(), Label)
        'If lbl IsNot Nothing Then
        '    lbl.Visible = bConflict
        'End If
        lblCutoffClampWarning.Visible = bConflict

        If bConflict Then
            ' Block Cutoff from going UP (would worsen conflict)
            ucrNudCutoff.nudUpDown.Maximum = ucrNudCutoff.Value
            ucrNudCutoff.nudUpDown.Enabled = True

            ' For Exclude: only block going UP if next increment would still conflict
            Dim iNextEffective As Integer = iNumLevels - (CInt(ucrNudExclude.Value) + 1)
            If iNextEffective < 1 Then iNextEffective = 1
            Dim iNextCutoffMax As Decimal = iNextEffective - 1

            If ucrNudCutoff.Value > iNextCutoffMax Then
                ' Next exclude increment would still conflict - block up
                ucrNudExclude.nudUpDown.Maximum = ucrNudExclude.Value
            Else
                ' Next exclude increment is safe - allow up
                ucrNudExclude.nudUpDown.Maximum = iNumLevels
            End If
            ucrNudExclude.nudUpDown.Enabled = True
        Else
            ' No conflict - restore normal maxima
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
    ' R script builders - all inline script construction in one place
    ' =========================================================================

    Private Function BuildGetNumLevelsScript(dataFrame As String, colNames As String) As String
        Return String.Format(
            "as.numeric(sapply(data_book$get_columns_from_data(data_name = {0}, col_names = {1}), nlevels))",
            Chr(34) & dataFrame & Chr(34),
            colNames)
    End Function

    ''' <summary>
    ''' Returns an R script that retrieves the levels of the specified column in
    ''' the specified data frame.
    ''' </summary>
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
        ' Check if conflict label is visible
        'Dim lbl As Label = TryCast(Me.Controls.Find("lblCutoffClampWarning", True).FirstOrDefault(), Label)
        'Dim bConflict As Boolean = lbl IsNot Nothing AndAlso lbl.Visible
        Dim bConflict As Boolean = lblCutoffClampWarning IsNot Nothing AndAlso lblCutoffClampWarning.Visible

        Dim bCanOK As Boolean = Not ucrReceiverMultipleGGLikert.IsEmpty() AndAlso
                            ucrSaveGGLikert.IsComplete AndAlso
                            bLevelsMatch AndAlso
                            Not bConflict

        ucrBase.OKEnabled(bCanOK)
        cmdPlotOptions.Enabled = Not ucrReceiverMultipleGGLikert.IsEmpty()
        cmdLikertOptions.Enabled = False
    End Sub

    ' =========================================================================
    ' Event handlers - thin delegates; logic lives in the methods above
    ' =========================================================================

    Private Sub ucrReceiverMultipleGGLikert_ControlValueChanged(ucrChangedControl As ucrCore) _
        Handles ucrReceiverMultipleGGLikert.ControlValueChanged
        UpdateDataAndIncludeParameters()
        CheckSelectedFactorsHaveSameLevels()
        TestOKEnabled()
        ' If in Side mode, factors changed so re-sync side_values
        If rdoSide.Checked Then
            SyncSideValuesParameter()
        End If
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

    ''' <summary>
    ''' When the Side chart level selector changes, re-sync the side_values parameter.
    ''' </summary>
    Private Sub ucrNudCutoffLevel_ControlValueChanged(ucrChangedControl As ucrCore) _
        Handles ucrNudCutoffLevel.ControlValueChanged
        If rdoSide.Checked AndAlso clsGGLikertFunction IsNot Nothing Then
            SyncSideValuesParameter()
        End If
    End Sub

    ' <summary>
    ' Builds the exclude_fill_values parameter from the current nudge value
    ' and the actual factor level names fetched from R.
    ' </summary>
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
        ' Do NOT call SetRCodeForControls — it resets the checkbox states.
        If rdoStacked.Checked OrElse rdoLikert.Checked Then
            ucrSaveGGLikert.SetRCode(clsBaseOperator, False)
        Else
            ucrSaveGGLikert.SetRCode(clsGGLikertFunction, False)
        End If
    End Sub

    Private Sub cmdLikertOptions_Click(sender As Object, e As EventArgs) Handles cmdLikertOptions.Click
        ' TODO: open sdgLikertOptions sub-dialog when implemented
    End Sub

    ' <summary>
    ' Restores the cutoff nudge value and re-adds the "cutoff" parameter after a
    ' detour through the Stacked chart (which strips it). Must run BEFORE
    ' ucrNudCutoff.SetRCode so the control re-binds to a populated parameter
    ' instead of resetting to its RDefault.
    ' </summary>
    Private Sub RestoreCutoff()
        If clsGGLikertFunction Is Nothing Then Exit Sub
        If Not ucrChkCutoff.Checked Then Exit Sub
        ucrNudCutoff.Value = dPreservedCutoff
        clsGGLikertFunction.AddParameter("cutoff",
            CStr(CDbl(dPreservedCutoff)),
            iPosition:=POS_CUTOFF)
    End Sub

End Class