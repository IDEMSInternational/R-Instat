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

Public Class dlgTimeSeriesPlot

    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    ' Constants
    Private strReference As String = ""
    Private strEstimates As String = ""
    Private strData As String = "data"
    Private strValue As String = "value"

    ' Adjust NA values
    Private clsAdjustNAOperator As ROperator
    Private clsAdjustNAMutateParameter As RParameter
    Private clsAdjustNAMutate As RFunction
    Private clsIfElseReference As RFunction
    Private clsIsNaReference As RFunction
    Private clsIfElseEstimates As RFunction
    Private clsIsNaEstimates As RFunction

    ' Stack data
    Private clsStackOperator As ROperator
    Private clsPivotLonger As RFunction
    Private clsPivotCFunction As RFunction

    ' Calculate means
    Private clsMeansOperator As ROperator
    Private clsMeansGroupBy As RFunction
    Private clsMeansSummarise As RFunction
    Private clsMeanFunction As RFunction

    ' Calculate Text Summaries

    ' ggplot functions
    Private clsGgplotOperator As ROperator
    Private clsGgplotFunction As RFunction
    Private clsGgplotAes As RFunction
    Private clsGeomLine As RFunction
    Private clsGeomPoint As RFunction
    Private clsGeomHLine As RFunction
    Private clsGeomHLineAes As RFunction
    Private clsGeomText As RFunction
    Private clsGeomTextAes As RFunction

    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsFacetFunction As New RFunction
    Private clsFacetOperator As New ROperator
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)

    'Parameter names for geoms
    Private strGeomLineParameterName As String = "geom_line"
    Private strGeomPointParameterName As String = "geom_point"
    Private strGeomHLineParameterName As String = "geom_hline"
    Private strGeomTextParameterName As String = "geom_text"
    Private strGeomParameterNames() As String = {strGeomLineParameterName, strGeomPointParameterName, strGeomHLineParameterName, strGeomTextParameterName}

    Private Sub dlgTimeSeriesPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
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
    End Sub

    Private Sub InitialiseDialog()
        'ucrBase.iHelpTopicID =
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorTimeSeriesPlots.SetParameter(New RParameter("0", 0))
        ucrSelectorTimeSeriesPlots.SetParameterIsrfunction()

        ucrReceiverReference.SetParameter(New RParameter("x", 0))
        ucrReceiverReference.Selector = ucrSelectorTimeSeriesPlots
        ucrReceiverReference.SetParameterIsString()
        ucrReceiverReference.bWithQuotes = False

        ucrReceiverEstimates.SetParameter(New RParameter("x", 0))
        ucrReceiverEstimates.Selector = ucrSelectorTimeSeriesPlots
        ucrReceiverEstimates.SetParameterIsString()
        ucrReceiverEstimates.bWithQuotes = False

        ucrReceiverTime.SetParameter(New RParameter("x", 0))
        ucrReceiverTime.Selector = ucrSelectorTimeSeriesPlots
        ucrReceiverTime.SetParameterIsString()
        ucrReceiverTime.bWithQuotes = False

        ucrReceiverStation.SetParameter(New RParameter("0", 0, bNewIncludeArgumentName:=False))
        ucrReceiverStation.Selector = ucrSelectorTimeSeriesPlots
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.bWithQuotes = False

        clsAdjustNAMutate = New RFunction
        clsAdjustNAMutateParameter = New RParameter("1", clsAdjustNAMutate, iNewPosition:=1)
        ucrChkNAValues.SetText("Remove rows with any missing values")
        ucrChkNAValues.SetParameter(clsAdjustNAMutateParameter, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrChkIncludePoints.SetText("Include Points")
        ucrChkIncludePoints.Enabled = False

        ucrChkIncludeMeanLines.SetText("Include Mean Lines")
        ucrChkIncludeMeanLines.Enabled = False

        ucrSavePlot.SetPrefix("line")
        ucrSavePlot.SetIsComboBox()
        ucrSavePlot.SetCheckBoxText("Save Graph")
        ucrSavePlot.SetSaveTypeAsGraph()
        ucrSavePlot.SetDataFrameSelector(ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames)
        ucrSavePlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsAdjustNAOperator = New ROperator
        clsIfElseReference = New RFunction
        clsIfElseEstimates = New RFunction
        clsIsNaReference = New RFunction
        clsIsNaEstimates = New RFunction

        clsStackOperator = New ROperator
        clsPivotLonger = New RFunction
        clsPivotCFunction = New RFunction

        clsMeansOperator = New ROperator
        clsMeansGroupBy = New RFunction
        clsMeansSummarise = New RFunction
        clsMeanFunction = New RFunction

        clsGgplotOperator = New ROperator
        clsGgplotFunction = New RFunction
        clsGgplotAes = New RFunction
        clsGeomLine = New RFunction
        clsGeomPoint = New RFunction
        clsGeomHLine = New RFunction
        clsGeomHLineAes = New RFunction
        clsGeomText = New RFunction
        clsGeomTextAes = New RFunction

        ucrSelectorTimeSeriesPlots.Reset()
        ucrSelectorTimeSeriesPlots.SetGgplotFunction(clsGgplotOperator)

        ucrReceiverReference.SetMeAsReceiver()

        ' Adjust NA values

        clsAdjustNAOperator.SetOperation("%>%")
        clsAdjustNAOperator.AddParameter(clsAdjustNAMutateParameter)

        clsAdjustNAMutate.Clear()
        clsAdjustNAMutate.SetPackageName("dplyr")
        clsAdjustNAMutate.SetRCommand("mutate")

        clsIfElseReference.SetRCommand("ifelse")
        clsIfElseReference.AddParameter("test", clsRFunctionParameter:=clsIsNaEstimates, iPosition:=0)
        clsIfElseReference.AddParameter("yes", "NA", iPosition:=1)

        clsIfElseEstimates.SetRCommand("ifelse")
        clsIfElseEstimates.AddParameter("test", clsRFunctionParameter:=clsIsNaReference, iPosition:=0)
        clsIfElseEstimates.AddParameter("yes", "NA", iPosition:=1)

        clsIsNaReference.SetRCommand("is.na")
        clsIsNaEstimates.SetRCommand("is.na")

        ' Stack data

        clsStackOperator.SetOperation("%>%")
        clsStackOperator.AddParameter("0", clsROperatorParameter:=clsAdjustNAOperator, iPosition:=0)
        clsStackOperator.AddParameter("1", clsRFunctionParameter:=clsPivotLonger, iPosition:=1)
        clsStackOperator.bBrackets = False

        clsPivotLonger.SetPackageName("tidyr")
        clsPivotLonger.SetRCommand("pivot_longer")
        clsPivotLonger.AddParameter("cols", clsRFunctionParameter:=clsPivotCFunction, iPosition:=1)
        clsPivotLonger.AddParameter("names_to", Chr(34) & strData & Chr(34), iPosition:=2)
        clsPivotLonger.AddParameter("values_to", Chr(34) & strValue & Chr(34), iPosition:=8)

        clsPivotCFunction.SetRCommand("c")

        ' Calculate means

        clsMeansOperator.SetOperation("%>%")
        clsMeansOperator.AddParameter("0", clsROperatorParameter:=clsStackOperator, iPosition:=0)
        clsMeansOperator.AddParameter("1", clsRFunctionParameter:=clsMeansGroupBy, iPosition:=1)
        clsMeansOperator.AddParameter("2", clsRFunctionParameter:=clsMeansSummarise, iPosition:=2)
        clsMeansOperator.bBrackets = False

        clsMeansGroupBy.SetPackageName("dplyr")
        clsMeansGroupBy.SetRCommand("group_by")
        clsMeansGroupBy.AddParameter("1", strData, iPosition:=1, bIncludeArgumentName:=False)

        clsMeansSummarise.SetPackageName("dplyr")
        clsMeansSummarise.SetRCommand("summarise")
        clsMeansSummarise.AddParameter("mean", clsRFunctionParameter:=clsMeanFunction, iPosition:=0)

        clsMeanFunction.SetRCommand("mean")
        clsMeanFunction.AddParameter("x", strValue, iPosition:=0)
        clsMeanFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        ' Ggplot functions

        clsGgplotOperator.SetOperation("+")
        clsGgplotOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGgplotFunction, iPosition:=0)
        clsGgplotOperator.AddParameter(strGeomLineParameterName, clsRFunctionParameter:=clsGeomLine, iPosition:=1)
        clsGgplotOperator.AddParameter(strGeomPointParameterName, clsRFunctionParameter:=clsGeomPoint, iPosition:=2)
        clsGgplotOperator.AddParameter(strGeomHLineParameterName, clsRFunctionParameter:=clsGeomHLine, iPosition:=3)

        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")
        clsGgplotFunction.AddParameter("data", clsROperatorParameter:=clsStackOperator, iPosition:=0)
        clsGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGgplotAes, iPosition:=1)

        clsGgplotAes.SetPackageName("ggplot2")
        clsGgplotAes.SetRCommand("aes")
        clsGgplotAes.AddParameter("y", strValue, iPosition:=1)
        clsGgplotAes.AddParameter("colour", strData, iPosition:=2)

        clsGeomLine.SetPackageName("ggplot2")
        clsGeomLine.SetRCommand("geom_line")

        clsGeomPoint.SetPackageName("ggplot2")
        clsGeomPoint.SetRCommand("geom_point")

        clsGeomHLine.SetPackageName("ggplot2")
        clsGeomHLine.SetRCommand("geom_hline")
        clsGeomHLine.AddParameter("data", clsROperatorParameter:=clsMeansOperator, iPosition:=0)
        clsGeomHLine.AddParameter("mapping", clsRFunctionParameter:=clsGeomHLineAes, iPosition:=1)

        clsGeomHLineAes.SetPackageName("ggplot2")
        clsGeomHLineAes.SetRCommand("aes")
        clsGeomHLineAes.AddParameter("yintercept", "mean", iPosition:=0)
        clsGeomHLineAes.AddParameter("colour", strData, iPosition:=1)

        clsGeomText.SetPackageName("ggplot2")
        clsGeomText.SetRCommand("geom_text")
        'clsGeomText.AddParameter("data", clsROperatorParameter:=, iPosition:=0)
        clsGeomText.AddParameter("mapping", clsRFunctionParameter:=clsGeomTextAes, iPosition:=1)

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetFunction.SetRCommand("facet_wrap")
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOperator, iPosition:=0)

        clsFacetOperator.SetOperation("~")
        clsFacetOperator.bForceIncludeOperation = True

        clsGgplotOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)

        clsGgplotOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsGgplotOperator)

        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsIfElseReference, New RParameter("no", 2), iAdditionalPairNo:=1)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsPivotCFunction, New RParameter("0", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsIfElseEstimates, New RParameter("no", 2), iAdditionalPairNo:=1)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsPivotCFunction, New RParameter("1", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverStation.AddAdditionalCodeParameterPair(clsFacetOperator, New RParameter("1", 1), iAdditionalPairNo:=1)

        ucrSelectorTimeSeriesPlots.SetRCode(clsAdjustNAOperator, bReset)
        ucrReceiverReference.SetRCode(clsIsNaReference, bReset)
        ucrReceiverEstimates.SetRCode(clsIsNaEstimates, bReset)
        ucrReceiverStation.SetRCode(clsMeansGroupBy, bReset)
        ucrReceiverTime.SetRCode(clsGgplotAes, bReset)
        ucrChkNAValues.SetRCode(clsAdjustNAOperator, bReset)

        SetDataFrameAssignTo()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverEstimates.IsEmpty And Not ucrReceiverReference.IsEmpty AndAlso ucrSavePlot.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDataFrameAssignTo()
        If ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            If ucrChkNAValues.Checked Then
                clsAdjustNAOperator.SetAssignTo(ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            Else
                clsAdjustNAOperator.RemoveAssignTo()
            End If
            clsStackOperator.SetAssignTo(ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stack")
            clsMeansOperator.SetAssignTo(ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_mean")
        Else
            clsAdjustNAOperator.RemoveAssignTo()
            clsStackOperator.RemoveAssignTo()
            clsMeansOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrSelectorTimeSeriesPlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTimeSeriesPlots.ControlValueChanged, ucrChkNAValues.ControlValueChanged
        SetDataFrameAssignTo()
    End Sub

    Private Sub ucrReceiverEstimates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverEstimates.ControlValueChanged
        If ucrReceiverEstimates.IsEmpty Then
            If strEstimates <> "" Then
                clsAdjustNAMutate.RemoveParameterByName(strEstimates)
                strEstimates = ""
            End If
        Else
            strEstimates = ucrReceiverEstimates.GetVariableNames(False)
            clsAdjustNAMutate.AddParameter(strEstimates, clsRFunctionParameter:=clsIfElseEstimates, iPosition:=1)
        End If
    End Sub

    Private Sub ucrReceiverReference_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverReference.ControlValueChanged
        If ucrReceiverReference.IsEmpty Then
            If strReference <> "" Then
                clsAdjustNAMutate.RemoveParameterByName(strReference)
                strReference = ""
            End If
        Else
            strReference = ucrReceiverReference.GetVariableNames(False)
            clsAdjustNAMutate.AddParameter(strReference, clsRFunctionParameter:=clsIfElseReference, iPosition:=0)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverEstimates.ControlContentsChanged, ucrReceiverReference.ControlContentsChanged, ucrSavePlot.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        If ucrReceiverStation.IsEmpty AndAlso clsFacetOperator.clsParameters.Count = 0 Then
            clsGgplotOperator.RemoveParameterByName("facets")
        Else
            clsGgplotOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction, iPosition:=30)
        End If
    End Sub
End Class