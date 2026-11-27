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

    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Col"
    Private ReadOnly strFacetNone As String = "None"
    Private ReadOnly strNull As String = "NULL"
    Private ReadOnly strLogicalFalse As String = "FALSE"
    Private ReadOnly strLogicalTrue As String = "TRUE"

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
    Private clsGetColumnFunction As New RFunction
    Private clsIsLogicalFunction As New RFunction
    Private clsLevelsFunction As New RFunction
    Private iNumLevels As Integer
    Private lstFirstVarLevels As New List(Of String)

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
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
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
        ucrReceiverMultipleGGLikert.SetIncludedDataTypes({"factor", "ordered", "logical"})
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

        ucrChkWrap.SetText("Wrap")
        ucrChkWrap.AddParameterValuesCondition(True, "wrap", "TRUE")
        ucrChkWrap.AddParameterValuesCondition(False, "wrap", "FALSE")

        ucrChkValues.SetText("Values")
        ucrChkValues.SetParameter(New RParameter("add_labels", 21))
        ucrChkValues.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkValues.SetRDefault("TRUE")

        ucrChkTotals.SetText("Totals")
        ucrChkTotals.SetParameter(New RParameter("add_totals", 22))
        ucrChkTotals.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkTotals.SetRDefault("TRUE")

        ucrNudCutoff.Minimum = 0
        ucrNudCutoff.Maximum = 0
        ucrNudCutoff.Increment = 0.1D
        ucrNudCutoff.DecimalPlaces = 1
        ucrNudCutoff.nudUpDown.ReadOnly = False

        ucrNudWrap.Minimum = 10
        ucrNudWrap.Maximum = 50
        ucrNudWrap.Increment = 1
        ucrNudWrap.DecimalPlaces = 0
        ucrNudWrap.nudUpDown.ReadOnly = False

        ucrInputExclude.SetDropDownStyleAsNonEditable()
        ucrInputExclude.SetItems({strNull})

        ucrInputCutoffLevel.SetDropDownStyleAsNonEditable()
        lblCutoffLevel.Visible = False
        ucrInputCutoffLevel.Visible = False

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
        clsGetColumnFunction = New RFunction
        clsIsLogicalFunction = New RFunction
        clsLevelsFunction = New RFunction

        ucrSelectorGGLikert.Reset()
        ucrSaveGGLikert.Reset()

        clsGGLikertFunction.SetPackageName("ggstats")
        clsGGLikertFunction.SetRCommand("gglikert")

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

        clsGetColumnFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsIsLogicalFunction.SetRCommand("is.logical")
        clsIsLogicalFunction.AddParameter("x", clsRFunctionParameter:=clsGetColumnFunction, iPosition:=0)
        clsLevelsFunction.SetRCommand("levels")
        clsLevelsFunction.AddParameter("x", clsRFunctionParameter:=clsGetColumnFunction, iPosition:=0)

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
        ucrNudCutoff.Maximum = 0
        ucrNudWrap.Value = 20
        ucrInputExclude.SetItems({strNull})
        ucrInputExclude.SetName(strNull)
        ucrInputCutoffLevel.SetItems(Array.Empty(Of String)())
        ucrInputCutoffLevel.SetName("")
        iNumLevels = 0
        lstFirstVarLevels.Clear()
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
        ucrSaveGGLikert.SetRCode(clsBaseOperator, bReset)
        ucrChkLegend.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)             ' checkbox FIRST
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)   ' then the combo
        ucr1stFactorReceiver.SetRCode(clsRowVarsFunction, bReset)

        If bReset Then
            ucrChkReverse.SetRCode(clsGGLikertFunction, bReset)
            ucrChkSymmetric.SetRCode(clsGGLikertFunction, bReset)
        End If

        bRCodeSet = True
        CheckSelectedFactorsHaveSameLevels()
        AddRemoveFacets()
        AddRemoveTheme()
        UpdateControlsVisibility()
        AddRemoveWrap()
        AddRemoveCutoff()
        UpdateExcludeFillParameter()
        UpdateSideValuesParameter()
    End Sub

    Private Sub AddRemoveWrap()
        If ucrChkWrap.Checked Then
            clsGGLikertFunction.AddParameter("y_label_wrap", ucrNudWrap.Value.ToString(System.Globalization.CultureInfo.InvariantCulture), iPosition:=20)
        Else
            clsGGLikertFunction.RemoveParameterByName("y_label_wrap")
        End If
    End Sub

    Private Sub AddRemoveCutoff()
        If Not rdoStacked.Checked AndAlso ucrChkCutoff.Checked Then
            clsGGLikertFunction.AddParameter("cutoff", ucrNudCutoff.Value.ToString(System.Globalization.CultureInfo.InvariantCulture), iPosition:=13)
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
        Dim bSideValid As Boolean = Not rdoSide.Checked OrElse Not String.IsNullOrEmpty(ucrInputCutoffLevel.GetText())
        Dim bCanOk As Boolean = Not ucrReceiverMultipleGGLikert.IsEmpty() AndAlso
                            Not bSingleVar AndAlso
                            ucrSaveGGLikert.IsComplete AndAlso
                            bLevelsMatch AndAlso
                            bSideValid
        ucrBase.OKEnabled(bCanOk)
    End Sub

    Private Sub UpdateControlsVisibility()
        Dim bIsLikert As Boolean = rdoLikert.Checked
        Dim bIsSide As Boolean = rdoSide.Checked

        ucrChkReverse.Enabled = bIsLikert OrElse bIsSide
        ucrChkSymmetric.Enabled = bIsLikert OrElse bIsSide
        ucrChkCutoff.Enabled = bIsLikert OrElse bIsSide
        ucrNudCutoff.Visible = ucrChkCutoff.Checked
        ucrNudCutoff.Enabled = ucrChkCutoff.Enabled AndAlso ucrChkCutoff.Checked

        ucrNudWrap.Visible = ucrChkWrap.Checked
        ucrNudWrap.Enabled = ucrChkWrap.Checked

        lblExclude.Visible = bIsLikert
        ucrInputExclude.Visible = bIsLikert
        ucrInputExclude.Enabled = bIsLikert

        lblCutoffLevel.Visible = bIsSide
        ucrInputCutoffLevel.Visible = bIsSide
        ucrInputCutoffLevel.Enabled = bIsSide

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
        End If
        UpdateControlsVisibility()
        UpdateCutoffBounds()
        AddRemoveFacets()
        AddRemoveWrap()
        AddRemoveCutoff()
        UpdateExcludeFillParameter()
        UpdateSideValuesParameter()
        SymmetryAddParameters()
        ReverseAddParameters()
        AddRemoveTheme()
        TestOkEnabled()
    End Sub

    Private Function GetColumnLevels(strDataFrame As String, strColName As String) As List(Of String)
        Dim lstLevels As New List(Of String)
        clsGetColumnFunction.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsGetColumnFunction.AddParameter("col_names", Chr(34) & strColName & Chr(34), iPosition:=1)

        Dim expLevels As SymbolicExpression = frmMain.clsRLink.RunInternalScriptGetValue(clsLevelsFunction.ToScript(), bSilent:=True)
        If expLevels IsNot Nothing AndAlso expLevels.Type <> Internals.SymbolicExpressionType.Null Then
            Dim arrLevels = expLevels.AsCharacter()
            If arrLevels IsNot Nothing Then
                lstLevels.AddRange(arrLevels)
            End If
        Else
            Dim expLogical As SymbolicExpression = frmMain.clsRLink.RunInternalScriptGetValue(clsIsLogicalFunction.ToScript(), bSilent:=True)
            If expLogical IsNot Nothing AndAlso expLogical.Type = Internals.SymbolicExpressionType.LogicalVector Then
                Dim arrLogical = expLogical.AsLogical()
                If arrLogical IsNot Nothing AndAlso arrLogical.Length > 0 AndAlso arrLogical(0) Then
                    lstLevels.Add(strLogicalFalse)
                    lstLevels.Add(strLogicalTrue)
                End If
            End If
        End If
        Return lstLevels
    End Function

    Private Sub UpdateSideValuesParameter()
        clsGGLikertFunction.RemoveParameterByName("side_values")

        If rdoSide.Checked AndAlso Not ucrReceiverMultipleGGLikert.IsEmpty() Then
            Dim strSelected As String = ucrInputCutoffLevel.GetText()
            If Not String.IsNullOrEmpty(strSelected) Then
                clsGGLikertFunction.AddParameter("side_values", Chr(34) & strSelected.Replace(Chr(34), "\" & Chr(34)) & Chr(34), iPosition:=14)
            End If
        End If
    End Sub

    Private Sub UpdateCutoffBounds()
        Dim iExcludedCount As Integer = 0
        If rdoLikert.Checked AndAlso Not String.IsNullOrEmpty(ucrInputExclude.GetText()) AndAlso ucrInputExclude.GetText() <> strNull Then
            iExcludedCount = 1
        End If

        Dim decMaxCutoff As Decimal = Math.Max(0, iNumLevels - iExcludedCount)
        If ucrNudCutoff.Value > decMaxCutoff Then
            ucrNudCutoff.Value = decMaxCutoff
        End If
        ucrNudCutoff.Maximum = decMaxCutoff
    End Sub

    Private Sub UpdateExcludeItems(lstLevels As List(Of String))
        Dim strCurrentSelection As String = ucrInputExclude.GetText()
        Dim lstExcludeItems As New List(Of String) From {strNull}
        If lstLevels IsNot Nothing Then
            lstExcludeItems.AddRange(lstLevels)
        End If
        ucrInputExclude.SetItems(lstExcludeItems.ToArray())
        If lstExcludeItems.Contains(strCurrentSelection) Then
            ucrInputExclude.SetName(strCurrentSelection)
        Else
            ucrInputExclude.SetName(strNull)
        End If
    End Sub

    Private Sub UpdateSideValueItems(lstLevels As List(Of String))
        Dim strCurrentSelection As String = ucrInputCutoffLevel.GetText()
        If lstLevels Is Nothing OrElse lstLevels.Count = 0 Then
            ucrInputCutoffLevel.SetItems(Array.Empty(Of String)())
            ucrInputCutoffLevel.SetName("")
        Else
            ucrInputCutoffLevel.SetItems(lstLevels.ToArray())
            If lstLevels.Contains(strCurrentSelection) Then
                ucrInputCutoffLevel.SetName(strCurrentSelection)
            Else
                ucrInputCutoffLevel.SetName(lstLevels(0))
            End If
        End If
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
        Dim varNames As List(Of String) = ucrReceiverMultipleGGLikert.GetVariableNamesAsList()
        Dim strDataFrame As String = ucrSelectorGGLikert.strCurrentDataFrame

        If ucrReceiverMultipleGGLikert.IsEmpty() OrElse varNames Is Nothing OrElse varNames.Count = 0 OrElse String.IsNullOrEmpty(strDataFrame) Then
            bLevelsMatch = True
            lblLevelsWarning.Visible = False
            iNumLevels = 0
            lstFirstVarLevels.Clear()
            UpdateCutoffBounds()
        Else
            lstFirstVarLevels = GetColumnLevels(strDataFrame, varNames(0))
            iNumLevels = lstFirstVarLevels.Count
            UpdateExcludeItems(lstFirstVarLevels)
            UpdateSideValueItems(lstFirstVarLevels)
            UpdateCutoffBounds()

            Dim bMismatchFound As Boolean = False
            For i As Integer = 1 To varNames.Count - 1
                If GetColumnLevels(strDataFrame, varNames(i)).Count <> iNumLevels Then
                    bMismatchFound = True
                    Exit For
                End If
            Next

            bLevelsMatch = Not bMismatchFound
            lblLevelsWarning.Visible = bMismatchFound
        End If
    End Sub

    Private Sub UpdateExcludeFillParameter()
        clsGGLikertFunction.RemoveParameterByName("exclude_fill_values")

        If rdoLikert.Checked AndAlso Not ucrReceiverMultipleGGLikert.IsEmpty() Then
            Dim strSelected As String = ucrInputExclude.GetText()
            If Not String.IsNullOrEmpty(strSelected) AndAlso strSelected <> strNull Then
                clsGGLikertFunction.AddParameter("exclude_fill_values", Chr(34) & strSelected.Replace(Chr(34), "\" & Chr(34)) & Chr(34), iPosition:=31)
            End If
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
        UpdateSideValuesParameter()
        UpdateExcludeFillParameter()
        AddRemoveCutoff()
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

    Private Sub ucrNudWrap_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudWrap.ControlValueChanged
        AddRemoveWrap()
    End Sub

    Private Sub ucrNudCutoff_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudCutoff.ControlValueChanged
        AddRemoveCutoff()
    End Sub

    Private Sub ucrInputExclude_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputExclude.ControlValueChanged
        UpdateCutoffBounds()
        AddRemoveCutoff()
        UpdateExcludeFillParameter()
    End Sub

    Private Sub ucrInputCutoffLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputCutoffLevel.ControlValueChanged
        UpdateSideValuesParameter()
        TestOkEnabled()
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
        AddRemoveWrap()
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