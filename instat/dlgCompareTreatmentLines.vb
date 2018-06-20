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

    ' Main functions and operator for ggplot
    Private clsBaseOperator As New ROperator
    Private clsRggplotFunction As New RFunction
    Private clsRaesGlobalFunction As New RFunction
    Private clsRaesLineFunction As New RFunction

    ' Geoms (layers)
    Private clsLineGeom As New RFunction
    Private clsColourParam As New RParameter
    Private clsBoxplotGeom As New RFunction
    Private clsHlineGeom As New RFunction

    ' Additional functions for plot subdialog
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)

    ' Facet functions
    Private clsRFacetFunction As New RFunction
    Private clsFacetOp As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator

    ' Data unstacking, diff calculation and merge codes
    Private clsLeftJoin As New RFunction
    Private clsFilter As New RFunction
    Private clsFilterInOperator As New ROperator
    Private clsDCast As New RFunction
    Private clsDCastFormula As New ROperator
    Private clsPipeOperator As New ROperator
    Private clsMutate As New RFunction
    Private clsDiffOperator As New ROperator
    Private clsCut As New RFunction
    Private clsCutBreaks As New RFunction
    Private clsCutLabels As New RFunction

    ' String constants
    Private strFacetRow As String = "Facet Row"
    Private strFacetCol As String = "Facet Column"
    Private strNone As String = "None"

    Private strDiff As String = "diff"
    Private strDiffCode As String = "diff_code"

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
        'autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        'ucrBase.iHelpTopicID = 
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorPlot.SetParameter(New RParameter("data", 0))
        ucrSelectorPlot.SetParameterIsrfunction()

        ucrReceiverMeasurement.SetParameter(New RParameter("y", 1))
        ucrReceiverMeasurement.Selector = ucrSelectorPlot
        ucrReceiverMeasurement.SetIncludedDataTypes({"numeric"})
        ucrReceiverMeasurement.strSelectorHeading = "Numerics"
        ucrReceiverMeasurement.SetParameterIsString()
        ucrReceiverMeasurement.bWithQuotes = False

        ucrReceiverOption.SetParameter(New RParameter("right", 1))
        ucrReceiverOption.Selector = ucrSelectorPlot
        ucrReceiverOption.SetIncludedDataTypes({"factor"})
        ucrReceiverOption.strSelectorHeading = "Factors"
        ucrReceiverOption.SetParameterIsString()
        ucrReceiverOption.bWithQuotes = False

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

        clsColourParam.SetArgumentName("colour")
        clsColourParam.SetArgumentValue(strDiffCode)
        clsColourParam.Position = 1
        ucrChkColourByDifference.SetText("Colour lines by difference")
        ucrChkColourByDifference.SetParameter(clsColourParam)
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

        ucrNudTransparency.SetLinkedDisplayControl(lblTransparency)
        ucrNudTransparency.SetParameter(New RParameter("alpha", iNewPosition:=1))
        ucrNudTransparency.SetMinMax(0, 1)
        ucrNudTransparency.DecimalPlaces = 2

        ucrChkHline.SetText("Horizontal Line")
        ucrChkHline.bAddRemoveParameter = True
        ucrChkHline.bChangeParameterValue = False
        ucrChkHline.AddParameterPresentCondition(True, "geom_hline")
        ucrChkHline.AddParameterPresentCondition(False, "geom_hline", False)
        ucrChkHline.AddToLinkedControls(ucrInputHlineValue, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputHlineValue.SetParameter(New RParameter("yintercept", iNewPosition:=2))
        ucrInputHlineValue.SetLinkedDisplayControl(lblHlineValue)
        ucrInputHlineValue.SetValidationTypeAsNumeric()
        ucrInputHlineValue.AddQuotesIfUnrecognised = False

        ucrReceiverContext1.Selector = ucrSelectorPlot
        ucrReceiverContext1.SetParameterIsString()
        ucrReceiverContext1.bWithQuotes = False

        ucrReceiverContext2.Selector = ucrSelectorPlot
        ucrReceiverContext2.SetParameterIsString()
        ucrReceiverContext2.bWithQuotes = False

        ucrInputContext1.SetItems({strFacetRow, strFacetCol, strNone})
        ucrInputContext1.SetDropDownStyleAsNonEditable()

        ucrInputContext2.SetItems({strFacetRow, strFacetCol, strNone})
        ucrInputContext2.SetDropDownStyleAsNonEditable()

        ucrSavePlot.SetPrefix("line")
        ucrSavePlot.SetIsComboBox()
        ucrSavePlot.SetCheckBoxText("Save Graph")
        ucrSavePlot.SetSaveTypeAsGraph()
        ucrSavePlot.SetDataFrameSelector(ucrSelectorPlot.ucrAvailableDataFrames)
        ucrSavePlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRaesGlobalFunction = New RFunction
        clsRaesLineFunction = New RFunction

        clsLineGeom = New RFunction
        clsBoxplotGeom = New RFunction
        clsHlineGeom = New RFunction

        clsRFacetFunction = New RFunction
        clsFacetOp = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator

        clsLeftJoin = New RFunction
        clsFilter = New RFunction
        clsFilterInOperator = New ROperator
        clsPipeOperator = New ROperator
        clsDCast = New RFunction
        clsDCastFormula = New ROperator
        clsMutate = New RFunction
        clsDiffOperator = New ROperator
        clsCut = New RFunction
        clsCutBreaks = New RFunction
        clsCutLabels = New RFunction

        ucrSelectorPlot.Reset()
        ucrSelectorPlot.SetGgplotFunction(clsBaseOperator)
        ucrReceiverMeasurement.SetMeAsReceiver()

        ucrSavePlot.Reset()
        sdgPlots.Reset()

        bResetSubdialog = True
        bResetBoxLayerSubdialog = True

        ' Data manipulation code
        clsLeftJoin.SetPackageName("dplyr")
        clsLeftJoin.SetRCommand("left_join")
        SetLeftJoinAssignTo()

        clsLeftJoin.AddParameter("x", clsRFunctionParameter:=clsFilter, iPosition:=0)
        clsLeftJoin.AddParameter("y", clsROperatorParameter:=clsPipeOperator, iPosition:=1)

        clsFilter.SetPackageName("dplyr")
        clsFilter.SetRCommand("filter")
        clsFilter.AddParameter("1", clsROperatorParameter:=clsFilterInOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsFilterInOperator.SetOperation("%in%")

        clsPipeOperator.SetOperation("%>%")

        clsPipeOperator.AddParameter("1", clsRFunctionParameter:=clsDCast, iPosition:=1)
        clsPipeOperator.AddParameter("2", clsRFunctionParameter:=clsMutate, iPosition:=2)

        clsDCast.SetPackageName("reshape2")
        clsDCast.SetRCommand("dcast")
        clsDCast.AddParameter("formula", clsROperatorParameter:=clsDCastFormula, iPosition:=1)
        clsDCast.AddParameter("fun.aggregate", "mean", iPosition:=2)

        clsDCastFormula.SetOperation("~")

        clsMutate.SetPackageName("dplyr")
        clsMutate.SetRCommand("mutate")

        clsMutate.AddParameter(strDiff, clsROperatorParameter:=clsDiffOperator, iPosition:=0)
        clsMutate.AddParameter(strDiffCode, clsRFunctionParameter:=clsCut, iPosition:=1)

        clsDiffOperator.SetOperation("-")

        clsCut.SetRCommand("cut")
        clsCut.AddParameter("x", strDiff, iPosition:=0)
        clsCut.AddParameter("breaks", clsRFunctionParameter:=clsCutBreaks, iPosition:=1)
        clsCut.AddParameter("labels", clsRFunctionParameter:=clsCutLabels, iPosition:=2)

        clsCutBreaks.SetRCommand("c")
        clsCutBreaks.AddParameter("0", "-Inf, -10, 10, Inf", bIncludeArgumentName:=False)

        clsCutLabels.SetRCommand("c")
        clsCutLabels.AddParameter("0", Chr(34) & "Decrease" & Chr(34) & ", " & Chr(34) & "Same" & Chr(34) & ", " & Chr(34) & "Increase" & Chr(34), bIncludeArgumentName:=False)

        ' ggplot code
        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsLineGeom, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=clsLeftJoin, iPosition:=0)
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesGlobalFunction, iPosition:=1)

        clsRaesGlobalFunction.SetPackageName("ggplot2")
        clsRaesGlobalFunction.SetRCommand("aes")

        clsLineGeom.SetPackageName("ggplot2")
        clsLineGeom.SetRCommand("geom_line")
        clsLineGeom.AddParameter("mapping", clsRFunctionParameter:=clsRaesLineFunction, iPosition:=0)

        clsRaesLineFunction.SetPackageName("ggplot2")
        clsRaesLineFunction.SetRCommand("aes")
        clsRaesLineFunction.AddParameter(clsColourParam)

        clsBoxplotGeom.SetPackageName("ggplot2")
        clsBoxplotGeom.SetRCommand("geom_boxplot")
        clsBoxplotGeom.AddParameter("outlier.colour", Chr(34) & "red" & Chr(34), iPosition:=1)
        clsBoxplotGeom.AddParameter("alpha", "0.75")

        clsHlineGeom.SetPackageName("ggplot2")
        clsHlineGeom.SetRCommand("geom_hline")
        clsHlineGeom.AddParameter("yintercept", 0, iPosition:=2)

        clsRFacetFunction.SetPackageName("ggplot2")
        clsRFacetFunction.SetRCommand("facet_grid")
        clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOp, iPosition:=0)

        clsFacetOp.SetOperation("~")
        clsFacetOp.bForceIncludeOperation = True
        clsFacetOp.bBrackets = False

        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)

        ' TODO temporary until can link these controls correctly
        ucrInputContext1.SetName(strNone)
        ucrInputContext2.SetName(strNone)

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeforControls(bResetControls As Boolean)
        ucrSelectorPlot.AddAdditionalCodeParameterPair(clsPipeOperator, ucrSelectorPlot.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverOption.AddAdditionalCodeParameterPair(clsRaesGlobalFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=1)
        ucrReceiverOption.AddAdditionalCodeParameterPair(clsFilterInOperator, New RParameter("0", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverID.AddAdditionalCodeParameterPair(clsRaesLineFunction, New RParameter("group", iNewPosition:=0), iAdditionalPairNo:=1)

        ucrReceiverMeasurement.SetRCode(clsRaesGlobalFunction, bResetControls)
        ucrReceiverOption.SetRCode(clsDCastFormula, bResetControls)
        'Needs to be done after linked receiver is set
        ucrInputFactorOption1.SetRCode(clsDiffOperator, bResetControls)
        ucrInputFactorOption2.SetRCode(clsDiffOperator, bResetControls)
        ucrReceiverID.SetRCode(clsDCastFormula, bResetControls)
        ucrSelectorPlot.SetRCode(clsFilter, bResetControls)
        ucrChkColourByDifference.SetRCode(clsRaesLineFunction, bResetControls)
        ucrChkIncludeBoxplot.SetRCode(clsBaseOperator, bResetControls)
        ucrNudTransparency.SetRCode(clsBoxplotGeom, bResetControls)
        ucrChkHline.SetRCode(clsBaseOperator, bResetControls)
        ucrInputHlineValue.SetRCode(clsHlineGeom, bResetControls)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverMeasurement.IsEmpty() AndAlso Not ucrReceiverOption.IsEmpty() AndAlso Not ucrInputFactorOption1.IsEmpty() AndAlso Not ucrInputFactorOption2.IsEmpty() AndAlso ucrSavePlot.IsComplete() AndAlso Not ucrReceiverID.IsEmpty() AndAlso (Not ucrChkIncludeBoxplot.Checked OrElse ucrNudTransparency.GetText() <> "") AndAlso (Not ucrChkHline.Checked OrElse Not ucrInputHlineValue.IsEmpty()) Then
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
        SetLeftJoinAssignTo()
    End Sub

    Private Sub SetLeftJoinAssignTo()
        If ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            clsLeftJoin.SetAssignTo(ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_with_diff")
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrReceiverMeasurement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMeasurement.ControlValueChanged
        If ucrReceiverMeasurement.IsEmpty() Then
            clsDCast.RemoveParameterByName("value.var")
        Else
            clsDCast.AddParameter("value.var", ucrReceiverMeasurement.GetVariableNames(), iPosition:=7)
        End If
    End Sub

    Private Sub ucrReceiverID_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverID.ControlValueChanged
        If ucrReceiverID.IsEmpty() Then
            clsLeftJoin.RemoveParameterByName("by")
        Else
            clsLeftJoin.AddParameter("by", ucrReceiverID.GetVariableNames(), iPosition:=2)
        End If
    End Sub

    Private Sub InputFactorTreatmentControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFactorOption1.ControlValueChanged, ucrInputFactorOption2.ControlValueChanged
        If Not ucrInputFactorOption1.IsEmpty() AndAlso Not ucrInputFactorOption2.IsEmpty Then
            clsFilterInOperator.AddParameter("1", "c(" & Chr(34) & ucrInputFactorOption1.GetText().Trim("`") & Chr(34) & ", " & Chr(34) & ucrInputFactorOption2.GetText().Trim("`") & Chr(34) & ")", iPosition:=1)
        Else
            clsFilterInOperator.RemoveParameterByName("1")
        End If
    End Sub

    Private Sub ContextControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputContext1.ControlValueChanged, ucrInputContext2.ControlValueChanged, ucrReceiverContext1.ControlValueChanged, ucrReceiverContext2.ControlValueChanged
        Dim iRowVars As Integer = 0
        Dim iColVars As Integer = 0

        clsFacetColOp.ClearParameters()
        clsFacetRowOp.ClearParameters()
        clsFacetOp.ClearParameters()
        clsRFacetFunction.RemoveParameterByName("dir")

        If Not ucrReceiverContext1.IsEmpty() Then
            Select Case ucrInputContext1.GetText()
                Case strFacetRow
                    clsFacetRowOp.AddParameter(iRowVars, ucrReceiverContext1.GetVariableNames(False), iPosition:=iRowVars)
                    iRowVars = iRowVars + 1
                Case strFacetCol
                    clsFacetColOp.AddParameter(iColVars, ucrReceiverContext1.GetVariableNames(False), iPosition:=iColVars)
                    iColVars = iColVars + 1
            End Select
        End If
        If Not ucrReceiverContext2.IsEmpty() Then
            Select Case ucrInputContext2.GetText()
                Case strFacetRow
                    clsFacetRowOp.AddParameter(iRowVars, ucrReceiverContext2.GetVariableNames(False), iPosition:=iRowVars)
                    iRowVars = iRowVars + 1
                Case strFacetCol
                    clsFacetColOp.AddParameter(iColVars, ucrReceiverContext2.GetVariableNames(False), iPosition:=iColVars)
                    iColVars = iColVars + 1
            End Select
        End If
        clsRFacetFunction.SetRCommand("facet_wrap")
        If iRowVars = 2 Then
            clsFacetOp.AddParameter("left", "", iPosition:=0)
            clsFacetOp.AddParameter("right", clsROperatorParameter:=clsFacetRowOp, iPosition:=1)
        ElseIf iColVars = 2 Then
            clsFacetOp.AddParameter("left", "", iPosition:=0)
            clsFacetOp.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
        ElseIf iRowVars = 1 AndAlso iColVars = 1 Then
            clsFacetOp.AddParameter("left", clsROperatorParameter:=clsFacetRowOp, iPosition:=0)
            clsFacetOp.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
            clsRFacetFunction.SetRCommand("facet_grid")
        ElseIf iRowVars = 1 AndAlso iColVars = 0 Then
            clsFacetOp.AddParameter("left", "", iPosition:=0)
            clsFacetOp.AddParameter("right", clsROperatorParameter:=clsFacetRowOp, iPosition:=1)
            clsRFacetFunction.AddParameter("dir", Chr(34) & "h" & Chr(34))
        ElseIf iColVars = 1 AndAlso iRowVars = 0 Then
            clsFacetOp.AddParameter("left", "", iPosition:=0)
            clsFacetOp.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
            clsRFacetFunction.AddParameter("dir", Chr(34) & "v" & Chr(34))
        End If
        If iRowVars > 0 OrElse iColVars > 0 Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsRFacetFunction, iPosition:=10)
        Else
            clsBaseOperator.RemoveParameterByName("facets")
        End If
    End Sub

    Private Sub ucrChkIncludeBoxplot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeBoxplot.ControlValueChanged
        If ucrChkIncludeBoxplot.Checked Then
            clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsBoxplotGeom, iPosition:=3)
        Else
            clsBaseOperator.RemoveParameterByName("geom_boxplot")
        End If
    End Sub

    Private Sub ucrChkHline_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkHline.ControlValueChanged
        If ucrChkHline.Checked Then
            clsBaseOperator.AddParameter("geom_hline", clsRFunctionParameter:=clsHlineGeom, iPosition:=4)
        Else
            clsBaseOperator.RemoveParameterByName("geom_hline")
        End If
    End Sub

    Private Sub ucrReceiverMeasurement_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMeasurement.ControlContentsChanged, ucrReceiverOption.ControlContentsChanged, ucrInputFactorOption1.ControlContentsChanged, ucrInputFactorOption2.ControlContentsChanged, ucrReceiverID.ControlContentsChanged, ucrChkIncludeBoxplot.ControlContentsChanged, ucrNudTransparency.ControlContentsChanged, ucrChkHline.ControlContentsChanged, ucrInputHlineValue.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class