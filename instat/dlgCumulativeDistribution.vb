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
Public Class dlgCumulativeDistribution
    Private clsRggplotFunction As New RFunction
    Private clsStatECDFFunction As New RFunction
    Private clsStatECDFPointFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsStatECDFAesFunction As New RFunction
    Private clsStatECDFPointAesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bFirstLoad As Boolean = True
    Private clsLabsFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private bResetSubdialog As Boolean = True
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private clsSequence As New RFunction
    Private bReset As Boolean = True

    Private clsFacetFunction As New RFunction
    Private clsFacetVariablesOperator As New ROperator
    Private clsVarsFunction As New RFunction
    Private clsPipeOperator As New ROperator
    Private clsGroupByFunction As New RFunction

    Private ReadOnly strNone As String = "None"
    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"
    Private ReadOnly strFacetRowAll As String = "Facet Row + O"
    Private ReadOnly strFacetColAll As String = "Facet Col + O"

    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False

    Private strFirstParameterName As String = "stat_ecdf"
    Private strFirstPointParameterName As String = "stat_ecdf2"
    Private strYScleParameterName As String = "YscaleContinous"
    Private strGeomParameterNames() As String = {strFirstParameterName, strFirstPointParameterName, strYScleParameterName}

    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator

    Private Sub dlgCumulativeDistribution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitaliseDialog()
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

    Private Sub InitaliseDialog()
        Dim dctScalesPairs As New Dictionary(Of String, String)
        Dim dctLegendPosition As New Dictionary(Of String, String)

        ucrChkCountsOnYAxis.Enabled = False ' temporary What should this do?

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 453

        ucrPnlOption.AddRadioButton(rdoCumulative)
        ucrPnlOption.AddRadioButton(rdoExceedance)

        ucrPnlOption.AddParameterPresentCondition(rdoCumulative, "mapping", bNewIsPositive:=False)
        ucrPnlOption.AddParameterPresentCondition(rdoExceedance, "mapping")

        ucrCumDistSelector.SetParameter(New RParameter("data", 0))
        ucrCumDistSelector.SetParameterIsrfunction()

        ucrFactorReceiver.SetParameter(New RParameter("colour", 1))
        ucrFactorReceiver.Selector = ucrCumDistSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorReceiver.strSelectorHeading = "Factors"
        ucrFactorReceiver.SetParameterIsString()
        ucrFactorReceiver.bWithQuotes = False

        ucrVariablesAsFactorforCumDist.SetParameter(New RParameter("x", 0))
        ucrVariablesAsFactorforCumDist.SetFactorReceiver(ucrFactorReceiver)
        ucrVariablesAsFactorforCumDist.Selector = ucrCumDistSelector
        ucrVariablesAsFactorforCumDist.SetIncludedDataTypes({"numeric"})
        ucrVariablesAsFactorforCumDist.strSelectorHeading = "Numerics"
        ucrVariablesAsFactorforCumDist.SetParameterIsString()
        ucrVariablesAsFactorforCumDist.bWithQuotes = False

        ucrInputComboScales.SetParameter(New RParameter("labels"))
        dctScalesPairs.Add("Proportion", "scales::comma")
        dctScalesPairs.Add("Percent", "scales::percent")
        ucrInputComboScales.SetItems(dctScalesPairs)
        ucrInputComboScales.SetDropDownStyleAsNonEditable()
        ucrInputComboScales.SetRDefault("scales::comma")

        ucrNudBy.SetParameter(New RParameter("by"))
        ucrNudBy.DecimalPlaces = 2
        ucrNudBy.Increment = 0.01
        ucrNudBy.Minimum = 0
        ucrNudBy.Maximum = 1

        ucrChkCountsOnYAxis.SetText("Counts on Y Axis")

        ucrChkIncludePoints.SetText("Include Points")
        ucrChkIncludePoints.SetParameter(New RParameter("geom"), bNewChangeParameterValue:=False)
        ucrChkIncludePoints.SetParameterValue(Chr(34) & "point" & Chr(34))

        'ucrInputComboPad.SetParameter(New RParameter("pad"))
        'ucrInputComboPad.SetItems({"TRUE", "FALSE"})
        'ucrInputComboPad.SetDropDownStyleAsNonEditable()
        'ucrInputComboPad.SetRDefault("TRUE")

        ucrChkLegend.SetText("Legend:")
        ucrChkLegend.AddToLinkedControls({ucrInputLegendPosition}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrInputLegendPosition.SetDropDownStyleAsNonEditable()
        ucrInputLegendPosition.SetParameter(New RParameter("legend.position"))
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        ucrChkLegend.AddParameterPresentCondition(True, "legend.position")
        ucrChkLegend.AddParameterPresentCondition(False, "legend.position", False)

        ucr1stFactorReceiver.SetParameter(New RParameter("var1"))
        ucr1stFactorReceiver.Selector = ucrCumDistSelector
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.SetParameterPosition(1)
        ucr1stFactorReceiver.SetLinkedDisplayControl(lblFacetBy)

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strFacetRowAll, strFacetColAll, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrSaveCumDist.SetSaveTypeAsGraph()
        ucrSaveCumDist.SetDataFrameSelector(ucrCumDistSelector.ucrAvailableDataFrames)
        ucrSaveCumDist.SetCheckBoxText("Store Graph")
        ucrSaveCumDist.SetIsComboBox()
        ucrSaveCumDist.SetPrefix("cumulative_dist")
        ucrSaveCumDist.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRaesFunction = New RFunction
        clsStatECDFFunction = New RFunction
        clsStatECDFPointFunction = New RFunction
        clsRggplotFunction = New RFunction
        clsStatECDFAesFunction = New RFunction
        clsStatECDFPointAesFunction = New RFunction
        clsFacetFunction = New RFunction
        clsFacetVariablesOperator = New ROperator
        clsVarsFunction = New RFunction
        clsPipeOperator = New ROperator
        clsGroupByFunction = New RFunction

        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True


        clsSequence = New RFunction
        clsSequence.SetRCommand("seq")
        clsSequence.AddParameter("from", "0", iPosition:=0)
        clsSequence.AddParameter("to", "1", iPosition:=1)
        clsSequence.AddParameter("by", "0.25", iPosition:=2)

        ucrCumDistSelector.Reset()
        ucrCumDistSelector.SetGgplotFunction(clsBaseOperator)
        ucrCumDistSelector.Focus()
        ucrSaveCumDist.Reset()
        ucrVariablesAsFactorforCumDist.SetMeAsReceiver()
        sdgPlots.Reset()
        bResetSubdialog = True


        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsStatECDFFunction.SetPackageName("ggplot2")
        clsStatECDFFunction.SetRCommand("stat_ecdf")
        clsStatECDFFunction.AddParameter("pad", "FALSE", iPosition:=0)

        clsStatECDFPointFunction.SetPackageName("ggplot2")
        clsStatECDFPointFunction.SetRCommand("stat_ecdf")
        clsStatECDFPointFunction.AddParameter("pad", "FALSE", iPosition:=0)

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("labs", clsRFunctionParameter:=clsLabsFunction, iPosition:=1)

        clsStatECDFAesFunction.SetPackageName("ggplot2")
        clsStatECDFAesFunction.SetRCommand("aes")
        clsStatECDFAesFunction.AddParameter("y", "1 - ..y..", iPosition:=0)

        clsStatECDFPointAesFunction.SetPackageName("ggplot2")
        clsStatECDFPointAesFunction.SetRCommand("aes")
        clsStatECDFPointAesFunction.AddParameter("y", "1 - ..y..", iPosition:=0)


        clsYScalecontinuousFunction.AddParameter("labels", "scales::comma")

        clsLabsFunction.SetRCommand("labs")
        clsLabsFunction.AddParameter("y", "NULL")

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator, iPosition:=0)

        clsFacetVariablesOperator.SetOperation("~")
        clsFacetVariablesOperator.bForceIncludeOperation = True
        clsFacetVariablesOperator.bBrackets = False

        clsVarsFunction.SetPackageName("ggplot2")
        clsVarsFunction.SetRCommand("vars")

        clsPipeOperator.SetOperation("%>%")
        SetPipeAssignTo()

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)

        clsYScalecontinuousFunction.AddParameter("breaks", clsRFunctionParameter:=clsSequence)

        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsStatECDFFunction, iPosition:=2)
        clsBaseOperator.AddParameter(strYScleParameterName, clsRFunctionParameter:=clsYScalecontinuousFunction, bIncludeArgumentName:=False)

        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrCumDistSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrFactorReceiver.SetRCode(clsRaesFunction, bReset)
        ucrVariablesAsFactorforCumDist.SetRCode(clsRaesFunction, bReset)
        ucrSaveCumDist.SetRCode(clsBaseOperator, bReset)
        ucrCumDistSelector.SetRCode(clsRggplotFunction, bReset)

        ucrPnlOption.SetRCode(clsStatECDFFunction, bReset)
        ucrInputComboScales.SetRCode(clsYScalecontinuousFunction, bReset)

        ucrChkIncludePoints.SetRCode(clsStatECDFPointFunction, bReset)

        ucrChkLegend.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)

        ucrNudBy.SetRCode(clsSequence, bReset)

    End Sub

    Private Sub TestOkEnabled()
        If ucrVariablesAsFactorforCumDist.IsEmpty OrElse Not ucrSaveCumDist.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction,
                          clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction,
                          clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction,
                          clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, ucrNewBaseSelector:=ucrCumDistSelector, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewFacetVariablesOperator:=clsFacetVariablesOperator,
                          clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction,
                           clsNewAnnotateFunction:=clsAnnotateFunction, strMainDialogGeomParameterNames:=strGeomParameterNames, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        ucr1stFactorReceiver.Add(sdgPlots.ucr1stFactorReceiver.GetText)
        bResetSubdialog = False
    End Sub

    Private Sub CoreControls_ControlContentsChanged() Handles ucrVariablesAsFactorforCumDist.ControlContentsChanged, ucrSaveCumDist.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlOption_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOption.ControlValueChanged
        If rdoExceedance.Checked Then
            clsStatECDFFunction.AddParameter("mapping", clsRFunctionParameter:=clsStatECDFAesFunction, iPosition:=2)
            clsStatECDFPointFunction.AddParameter("mapping", clsRFunctionParameter:=clsStatECDFPointAesFunction, iPosition:=2)

        ElseIf rdoCumulative.Checked Then
            clsStatECDFFunction.RemoveParameterByName("mapping")
            clsStatECDFPointFunction.RemoveParameterByName("mapping")
        End If
    End Sub

    Private Sub ucrChkIncludePoints_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludePoints.ControlValueChanged
        If ucrChkIncludePoints.Checked Then
            clsBaseOperator.AddParameter(strFirstPointParameterName, clsRFunctionParameter:=clsStatECDFPointFunction, iPosition:=3)
        Else
            clsBaseOperator.RemoveParameterByName(strFirstPointParameterName)
        End If
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ucrChkLegend_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLegend.ControlValueChanged, ucrInputLegendPosition.ControlValueChanged
        AddRemoveTheme()
    End Sub

    Private Sub AutoFacetStation()
        Dim currentReceiver As ucrReceiver = ucrCumDistSelector.CurrentReceiver

        If currentReceiver IsNot Nothing Then
            ucr1stFactorReceiver.AddItemsWithMetadataProperty(ucrCumDistSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
            currentReceiver.SetMeAsReceiver()
            AddRemoveGroupBy()
        End If
    End Sub

    Private Sub ucrInput_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputStation.ControlValueChanged
        If Not bUpdateComboOptions Then
            Exit Sub
        End If

        Dim strChangedText As String = ucrChangedControl.GetText()
        If strChangedText <> strNone Then
            If Not (strChangedText = strFacetCol OrElse strChangedText = strFacetColAll _
            OrElse strChangedText = strFacetRow OrElse strChangedText = strFacetRowAll) _
            AndAlso Not ucrInputStation.Equals(ucrChangedControl) _
            AndAlso ucrInputStation.GetText() = strChangedText Then

                bUpdateComboOptions = False
                ucrInputStation.SetName(strNone)
                bUpdateComboOptions = True
            End If
            If (strChangedText = strFacetWrap AndAlso
            (ucrInputStation.GetText = strFacetRow OrElse ucrInputStation.GetText = strFacetRowAll _
            OrElse ucrInputStation.GetText = strFacetCol OrElse ucrInputStation.GetText = strFacetColAll)) _
        OrElse ((strChangedText = strFacetRow OrElse strChangedText = strFacetRowAll) _
            AndAlso ucrInputStation.GetText = strFacetWrap) _
        OrElse ((strChangedText = strFacetCol OrElse strChangedText = strFacetColAll) _
            AndAlso ucrInputStation.GetText = strFacetWrap) Then

                ucrInputStation.SetName(strNone)
            End If
        End If
        UpdateParameters()
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub UpdateParameters()
        clsFacetVariablesOperator.RemoveParameterByName("var1")
        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters = True
        ucr1stFactorReceiver.SetRCode(Nothing)
        Select Case ucrInputStation.GetText()
            Case strFacetWrap
                ucr1stFactorReceiver.ChangeParameterName("var1")
                ucr1stFactorReceiver.SetRCode(clsFacetVariablesOperator)
            Case strFacetCol, strFacetColAll
                ucr1stFactorReceiver.ChangeParameterName("col" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsVarsFunction)
            Case strFacetRow, strFacetRowAll
                ucr1stFactorReceiver.ChangeParameterName("row" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsVarsFunction)
        End Select
        If Not clsRaesFunction.ContainsParameter("x") Then
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
        bUpdatingParameters = False
    End Sub

    Private Sub AddRemoveFacets()
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False
        Dim bColAll As Boolean = False
        Dim bRowAll As Boolean = False

        If bUpdatingParameters Then
            Exit Sub
        End If
        clsBaseOperator.RemoveParameterByName("facets")
        If Not ucr1stFactorReceiver.IsEmpty Then
            Select Case ucrInputStation.GetText()
                Case strFacetWrap
                    bWrap = True
                Case strFacetCol
                    bCol = True
                Case strFacetRow
                    bRow = True
                Case strFacetColAll
                    bColAll = True
                Case strFacetRowAll
                    bRowAll = True
            End Select
        End If
        If bWrap OrElse bRow OrElse bCol OrElse bColAll OrElse bRowAll Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
        End If

        If bWrap Then
            clsFacetFunction.SetRCommand("facet_wrap")
        End If

        If bRow OrElse bCol OrElse bRowAll OrElse bColAll Then
            clsFacetFunction.SetRCommand("facet_grid")
            clsFacetFunction.RemoveParameterByName("facets")
        End If

        If bRowAll OrElse bColAll Then
            clsFacetFunction.AddParameter("margin", "TRUE")
        Else
            clsFacetFunction.RemoveParameterByName("margin")
        End If

        If bRow OrElse bRowAll Then
            clsFacetFunction.AddParameter("rows", clsRFunctionParameter:=clsVarsFunction, iPosition:=0)
        Else
            clsFacetFunction.RemoveParameterByName("rows")
        End If

        If bCol OrElse bColAll Then
            clsFacetFunction.AddParameter("cols", clsRFunctionParameter:=clsVarsFunction, iPosition:=0)
        Else
            clsFacetFunction.RemoveParameterByName("cols")
        End If
    End Sub

    Private Sub ucr1stFactorReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucr1stFactorReceiver.ControlValueChanged, ucrVariablesAsFactorforCumDist.ControlValueChanged
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub GetParameterValue(clsOperator As ROperator)
        Dim i As Integer = 0
        For Each clsTempParam As RParameter In clsOperator.clsParameters
            If clsTempParam.strArgumentValue <> "" AndAlso clsTempParam.strArgumentValue <> "." Then
                clsGroupByFunction.AddParameter(i, clsTempParam.strArgumentValue, bIncludeArgumentName:=False, iPosition:=i)
                i = i + 1
            End If
        Next
    End Sub

    Private Sub AddRemoveGroupBy()
        If clsPipeOperator.ContainsParameter("mutate") Then
            clsGroupByFunction.ClearParameters()
            If clsBaseOperator.ContainsParameter("facets") Then
                Select Case ucrInputStation.GetText()
                    Case strFacetWrap
                        GetParameterValue(clsFacetVariablesOperator)
                    Case strFacetCol, strFacetColAll, strFacetRow, strFacetRowAll
                        Dim i As Integer = clsGroupByFunction.iParameterCount
                        For Each clsTempParam As RParameter In clsVarsFunction.clsParameters
                            If clsTempParam.strArgumentValue <> "" AndAlso clsTempParam.strArgumentValue <> "." Then
                                clsGroupByFunction.AddParameter(i, clsTempParam.strArgumentValue, bIncludeArgumentName:=False, iPosition:=i)
                                i = i + 1
                            End If
                        Next
                End Select
            End If
            If clsGroupByFunction.iParameterCount > 0 Then
                clsPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)
            Else
                clsPipeOperator.RemoveParameterByName("group_by")
            End If
        Else
            clsPipeOperator.RemoveParameterByName("group_by")
        End If
        SetPipeAssignTo()
    End Sub

    Private Sub SetPipeAssignTo()
        If ucrCumDistSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrCumDistSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrCumDistSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCumDistSelector.ControlValueChanged
        AutoFacetStation()
        SetPipeAssignTo()
    End Sub
End Class