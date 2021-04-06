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

Public Class dlgDisplayTopN
    Private clsBaseOperator As New ROperator

    Private clsPipeOperator As New ROperator
    Private clsFilterFunction As New RFunction
    Private clsInTopNFunction As New RFunction
    Private clsFctReorder As New RFunction

    Private clsGgplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsLocalAesFunction As New RFunction
    Private clsStatSummaryPointBarFunction As New RFunction
    Private clsStatSummaryPointBarAesFunction As New RFunction
    Private clsStatSummaryLineRangeFunction As New RFunction
    Private clsStatSummaryLineRangeAesFunction As New RFunction
    Private clsStatCountPointBarFunction As New RFunction
    Private clsStatCountPointBarAesFunction As New RFunction
    Private clsStatCountLineRangeFunction As New RFunction
    Private clsStatCountLineRangeAesFunction As New RFunction

    Private clsDollarFormatFunction As New RFunction
    Private clsLabelsParameter As New RParameter

    Private clsLabsFunction As New RFunction
    Private clsXlabFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction

    Private dctThemeFunctions As New Dictionary(Of String, RFunction)

    Dim clsCoordFlipFunc As New RFunction
    Dim clsCoordFlipParam As New RParameter

    'Parameter names for geoms
    Private strStatSummaryPointBarParameterName As String = "stat_summary_pointbar"
    Private strStatSummaryLineRangeParameterName As String = "stat_summary_linerange"
    Private strStatCountPointBarParameterName As String = "stat_count_pointbar"
    Private strStatCountLineRangeParameterName As String = "stat_count_linerange"
    Private strGeomParameterNames() As String = {strStatSummaryPointBarParameterName, strStatSummaryLineRangeParameterName, strStatCountPointBarParameterName, strStatCountLineRangeParameterName}

    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private bRCodeSet As Boolean = False
    Private bResetSubdialog As Boolean = True

    Private Sub dlgDisplayTopN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub InitialiseDialog()
        Dim dctOrder As New Dictionary(Of String, String)
        Dim dctDisplay As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        'ucrBase.iHelpTopicID = 

        ucrSelectorDisplayTopN.SetParameter(New RParameter("data", 0))
        ucrSelectorDisplayTopN.SetParameterIsrfunction()

        ucrReceiverVariable.SetParameter(New RParameter(".f", 0))
        ucrReceiverVariable.Selector = ucrSelectorDisplayTopN
        ucrReceiverVariable.SetParameterIsString()
        ucrReceiverVariable.bWithQuotes = False

        ucrReceiverWeightBy.SetParameter(New RParameter("y", 1))
        ucrReceiverWeightBy.Selector = ucrSelectorDisplayTopN
        ucrReceiverWeightBy.SetParameterIsString()
        ucrReceiverWeightBy.SetValuesToIgnore({"stat(count)"})
        ucrReceiverWeightBy.bWithQuotes = False
        ucrReceiverWeightBy.SetDataType("numeric")
        ucrReceiverWeightBy.SetSelectorHeading("Numerics")

        ucrInputSummary.SetParameter(New RParameter("fun.y", 5))
        ucrInputSummary.SetItems({"sum", "mean", "min", "max"})
        ucrInputSummary.AddQuotesIfUnrecognised = False
        ucrInputSummary.SetLinkedDisplayControl(lblSummary)
        ucrInputSummary.SetValidationTypeAsRVariable()
        ucrInputSummary.bAllowNonConditionValues = True

        ucrInputNLevels.SetValidationTypeAsNumeric()
        ucrInputNLevels.SetParameter(New RParameter("n", iNewPosition:=1))
        ucrInputNLevels.SetRDefault("10")
        ucrInputNLevels.AddQuotesIfUnrecognised = False

        clsLabelsParameter.SetArgumentName("labels")
        clsLabelsParameter.SetArgument(clsDollarFormatFunction)
        clsLabelsParameter.Position = 3

        ucrChkIsCurrency.SetText("Is Currency")
        ucrChkIsCurrency.SetParameter(clsLabelsParameter, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkIsCurrency.AddToLinkedControls(ucrInputSymbol, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputSymbol.SetParameter(New RParameter("prefix", iNewPosition:=2))
        ucrInputSymbol.SetRDefault("$")
        ucrInputSymbol.SetLinkedDisplayControl(lblSymbol)

        dctOrder.Add("Ascending", "FALSE")
        dctOrder.Add("Descending", "TRUE")

        ucrInputOrder.SetParameter(New RParameter(".desc", iNewPosition:=3))
        ucrInputOrder.SetItems(dctOrder)
        ucrInputOrder.SetRDefault("FALSE")
        ucrInputOrder.SetDropDownStyleAsNonEditable()

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        clsCoordFlipParam.Position = 15

        ucrInputLayout.SetItems({"Horizontal bars", "Vertical bars"}, bAddQuotes:=False)
        ucrInputLayout.SetParameter(clsCoordFlipParam)
        ucrInputLayout.bChangeParameterValue = False
        ucrInputLayout.AddParameterPresentCondition("Horizontal bars", "coord_flip")
        ucrInputLayout.AddParameterPresentCondition("Vertical bars", "coord_flip", False)
        ucrInputLayout.SetDropDownStyleAsNonEditable()

        dctDisplay.Add("Bar", Chr(34) & "bar" & Chr(34))
        dctDisplay.Add("Lollipop", Chr(34) & "point" & Chr(34))
        ucrInputDisplay.SetParameter(New RParameter("geom", 2))
        ucrInputDisplay.SetItems(dctDisplay)
        ucrInputDisplay.SetDropDownStyleAsNonEditable()

        ucrSaveDisplay.SetIsComboBox()
        ucrSaveDisplay.SetCheckBoxText("Save Graph")
        ucrSaveDisplay.SetDataFrameSelector(ucrSelectorDisplayTopN.ucrAvailableDataFrames)
        ucrSaveDisplay.SetSaveTypeAsGraph()
        ucrSaveDisplay.SetPrefix("lollipop")
        ucrSaveDisplay.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator

        clsPipeOperator = New ROperator
        clsFilterFunction = New RFunction
        clsInTopNFunction = New RFunction
        clsFctReorder = New RFunction

        clsGgplotFunction = New RFunction
        clsRaesFunction = New RFunction
        clsLocalAesFunction = New RFunction
        clsStatSummaryPointBarFunction = New RFunction
        clsStatSummaryPointBarAesFunction = New RFunction
        clsStatSummaryLineRangeFunction = New RFunction
        clsStatSummaryLineRangeAesFunction = New RFunction
        clsStatCountPointBarFunction = New RFunction
        clsStatCountPointBarAesFunction = New RFunction
        clsStatCountLineRangeFunction = New RFunction
        clsStatCountLineRangeAesFunction = New RFunction

        clsDollarFormatFunction.Clear()

        clsLabsFunction = New RFunction
        clsXlabFunction = New RFunction
        clsYlabFunction = New RFunction
        clsXScalecontinuousFunction = New RFunction
        clsYScalecontinuousFunction = New RFunction
        clsRFacetFunction = New RFunction
        clsCoordPolarFunction = New RFunction
        clsCoordPolarStartOperator = New ROperator
        clsThemeFunction = New RFunction
        dctThemeFunctions = New Dictionary(Of String, RFunction)

        ucrSelectorDisplayTopN.Reset()
        ucrSelectorDisplayTopN.SetGgplotFunction(clsBaseOperator)

        ucrReceiverVariable.SetMeAsReceiver()

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGgplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter(strStatCountPointBarParameterName, clsRFunctionParameter:=clsStatCountPointBarFunction, iPosition:=2)
        clsBaseOperator.AddParameter(strStatCountLineRangeParameterName, clsRFunctionParameter:=clsStatCountLineRangeFunction, iPosition:=3)
        clsBaseOperator.AddParameter(clsCoordFlipParam)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("1", clsRFunctionParameter:=clsFilterFunction, iPosition:=1)

        clsFilterFunction.SetPackageName("dplyr")
        clsFilterFunction.SetRCommand("filter")
        clsFilterFunction.AddParameter("0", clsRFunctionParameter:=clsInTopNFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsInTopNFunction.SetRCommand("in_top_n")
        clsInTopNFunction.AddParameter("n", "10", iPosition:=1)

        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")
        clsGgplotFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        clsGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", clsRFunctionParameter:=clsFctReorder, iPosition:=0)
        clsRaesFunction.AddParameter("y", "stat(count)", iPosition:=1)

        clsFctReorder.SetPackageName("forcats")
        clsFctReorder.SetRCommand("fct_reorder")
        clsFctReorder.AddParameter(".fun", "length", iPosition:=2)

        clsStatCountPointBarFunction.SetPackageName("ggplot2")
        clsStatCountPointBarFunction.SetRCommand("stat_count")
        clsStatCountPointBarFunction.AddParameter("geom", Chr(34) & "point" & Chr(34), iPosition:=2)

        clsStatCountLineRangeFunction.SetPackageName("ggplot2")
        clsStatCountLineRangeFunction.SetRCommand("stat_count")
        clsStatCountLineRangeFunction.AddParameter("geom", Chr(34) & "linerange" & Chr(34), iPosition:=2)
        clsStatCountLineRangeFunction.AddParameter("mapping", clsRFunctionParameter:=clsStatCountLineRangeAesFunction, iPosition:=0)

        clsStatCountLineRangeAesFunction.SetPackageName("ggplot2")
        clsStatCountLineRangeAesFunction.SetRCommand("aes")
        clsStatCountLineRangeAesFunction.AddParameter("ymax", "stat(count)", iPosition:=6)
        clsStatCountLineRangeAesFunction.AddParameter("ymin", "0*stat(count)", iPosition:=7)

        clsStatSummaryPointBarFunction.SetPackageName("ggplot2")
        clsStatSummaryPointBarFunction.SetRCommand("stat_summary")
        clsStatSummaryPointBarFunction.AddParameter("geom", Chr(34) & "point" & Chr(34), iPosition:=2)
        clsStatSummaryPointBarFunction.AddParameter("fun.y", "sum", iPosition:=5)

        clsStatSummaryLineRangeFunction.SetPackageName("ggplot2")
        clsStatSummaryLineRangeFunction.SetRCommand("stat_summary")
        clsStatSummaryLineRangeFunction.AddParameter("geom", Chr(34) & "linerange" & Chr(34), iPosition:=2)
        clsStatSummaryLineRangeFunction.AddParameter("fun.ymax", "sum", iPosition:=6)
        clsStatSummaryLineRangeFunction.AddParameter("fun.ymin", "function(x) 0", iPosition:=7)

        clsDollarFormatFunction.SetPackageName("scales")
        clsDollarFormatFunction.SetRCommand("dollar_format")

        clsXlabFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorDisplayTopN.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsInTopNFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=1)
        ucrInputDisplay.AddAdditionalCodeParameterPair(clsStatCountPointBarFunction, New RParameter("geom", iNewPosition:=2), iAdditionalPairNo:=1)
        ucrInputSummary.AddAdditionalCodeParameterPair(clsStatSummaryLineRangeFunction, New RParameter("fun.ymax", iNewPosition:=2), iAdditionalPairNo:=1)
        ucrInputSummary.AddAdditionalCodeParameterPair(clsInTopNFunction, New RParameter("fun", iNewPosition:=3), iAdditionalPairNo:=2)
        ucrInputSummary.AddAdditionalCodeParameterPair(clsFctReorder, New RParameter(".fun", iNewPosition:=3), iAdditionalPairNo:=3)

        ucrSelectorDisplayTopN.SetRCode(clsPipeOperator, bReset)
        ucrReceiverVariable.SetRCode(clsFctReorder, bReset)
        ucrReceiverWeightBy.SetRCode(clsRaesFunction, bReset)
        ucrInputNLevels.SetRCode(clsInTopNFunction, bReset)
        ucrInputOrder.SetRCode(clsFctReorder, bReset)
        ucrChkIsCurrency.SetRCode(clsYScalecontinuousFunction, bReset)
        ucrInputSymbol.SetRCode(clsDollarFormatFunction, bReset)
        ucrInputLayout.SetRCode(clsBaseOperator, bReset)
        ucrInputDisplay.SetRCode(clsStatSummaryPointBarFunction, bReset)
        ucrInputSummary.SetRCode(clsStatSummaryPointBarFunction, bReset)

        bRCodeSet = True
        SetWeightAndDisplayOptions()
        AddRemoveCoordFlip()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverVariable.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=ucrSelectorDisplayTopN, strMainDialogGeomParameterNames:=strGeomParameterNames, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub ucrReceiversInputDisplay_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWeightBy.ControlValueChanged, ucrReceiverVariable.ControlValueChanged, ucrInputDisplay.ControlValueChanged
        If bRCodeSet Then
            SetWeightAndDisplayOptions()
        End If
        ucrSaveDisplay.SetPrefix("lollipop")

    End Sub

    Private Sub ucrInputDisplay_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputDisplay.ControlValueChanged
        If bRCodeSet Then
            If ucrInputDisplay.GetText() = "Bar" Then
                ucrSaveDisplay.SetPrefix("bar")
            ElseIf ucrInputDisplay.GetText() = "Lollipop" Then
                ucrSaveDisplay.SetPrefix("lollipop")
            End If
        End If
    End Sub

    Private Sub ucrReceiverVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariable.ControlValueChanged
        If bRCodeSet Then
            If Not ucrReceiverVariable.IsEmpty Then
                clsXlabFunction.AddParameter("label", ucrReceiverVariable.GetVariableNames(), iPosition:=0)
                clsBaseOperator.AddParameter("xlab", clsRFunctionParameter:=clsXlabFunction, iPosition:=15)
            Else
                clsXlabFunction.RemoveParameterByName("label")
                clsBaseOperator.RemoveParameterByName("xlab")
            End If
        End If
    End Sub

    Private Sub SetWeightAndDisplayOptions()
        Dim strBarLollipop As String

        strBarLollipop = ucrInputDisplay.GetText()

        If ucrReceiverWeightBy.IsEmpty Then
            ucrInputSummary.Visible = False
            ucrChkIsCurrency.Visible = False
            ucrInputSymbol.Visible = False
            clsBaseOperator.AddParameter(strStatCountPointBarParameterName, clsRFunctionParameter:=clsStatCountPointBarFunction, iPosition:=2)
            If strBarLollipop = "Bar" Then
                clsBaseOperator.RemoveParameterByName(strStatCountLineRangeParameterName)
            ElseIf strBarLollipop = "Lollipop" Then
                clsBaseOperator.AddParameter(strStatCountLineRangeParameterName, clsRFunctionParameter:=clsStatCountLineRangeFunction, iPosition:=3)
            End If
            clsBaseOperator.RemoveParameterByName(strStatSummaryPointBarParameterName)
            clsBaseOperator.RemoveParameterByName(strStatSummaryLineRangeParameterName)
            clsFctReorder.AddParameter(".x", ucrReceiverVariable.GetVariableNames(False), iPosition:=1)
            clsFctReorder.AddParameter(".fun", "length", iPosition:=2)
            clsFctReorder.RemoveParameterByName("na.rm")
            clsInTopNFunction.RemoveParameterByName("wt")
        Else
            ucrInputSummary.Visible = True
            ucrChkIsCurrency.Visible = True
            If ucrChkIsCurrency.Checked Then
                ucrInputSymbol.Visible = True
            End If
            clsBaseOperator.AddParameter(strStatSummaryPointBarParameterName, clsRFunctionParameter:=clsStatSummaryPointBarFunction, iPosition:=2)
            If strBarLollipop = "Bar" Then
                clsBaseOperator.RemoveParameterByName(strStatSummaryLineRangeParameterName)
            ElseIf strBarLollipop = "Lollipop" Then
                clsBaseOperator.AddParameter(strStatSummaryLineRangeParameterName, clsRFunctionParameter:=clsStatSummaryLineRangeFunction, iPosition:=3)
            End If
            clsBaseOperator.RemoveParameterByName(strStatCountPointBarParameterName)
            clsBaseOperator.RemoveParameterByName(strStatCountLineRangeParameterName)
            clsFctReorder.AddParameter(".x", ucrReceiverWeightBy.GetVariableNames(False), iPosition:=1)
            clsFctReorder.AddParameter(".fun", ucrInputSummary.GetText(), iPosition:=2)
            clsFctReorder.AddParameter("na.rm", "TRUE", iPosition:=3)
            clsInTopNFunction.AddParameter("wt", ucrReceiverWeightBy.GetVariableNames(False), iPosition:=2)
        End If
    End Sub

    Private Sub ucrChkIsCurrency_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIsCurrency.ControlValueChanged
        If bRCodeSet Then
            If clsYScalecontinuousFunction.clsParameters.Count > 0 Then
                clsBaseOperator.AddParameter("scale_y_continuous", clsRFunctionParameter:=clsYScalecontinuousFunction, iPosition:=13)
            Else
                clsBaseOperator.RemoveParameterByName("scale_y_continuous")
            End If
        End If
    End Sub

    Private Sub ucrInputLayout_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputLayout.ControlValueChanged
        If bRCodeSet Then
            AddRemoveCoordFlip()
        End If
    End Sub

    Private Sub AddRemoveCoordFlip()
        If ucrInputLayout.GetText() = "Horizontal bars" Then
            clsBaseOperator.AddParameter(clsCoordFlipParam)
        ElseIf ucrInputLayout.GetText() = "Vertical bars" Then
            clsBaseOperator.RemoveParameter(clsCoordFlipParam)
        End If
    End Sub
End Class