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
Public Class dlgPICSARainfall
    Public bFirstLoad As Boolean = True
    Private clsRggplotFunction As New RFunction
    Private clsRgeomlineplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bReset As Boolean = True
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private bResetLineLayerSubdialog As Boolean = True
    Private clsLocalRaesFunction As New RFunction
    Private clsGeomPoint As New RFunction
    Private clsPointsFunc As New RFunction
    Private clsPointsParam As New RParameter
    Private clsYLabFunction, clsXLabFunction, clsLabsFunction As RFunction
    Private clsXAxisLabels, clsYAxisLabels As New RFunction
    Private clsMeanLine, clsMedianLine, clsTretile As New RFunction
    Private clsPnlBackgroundFunction, clsPnlGridLinesFunction As RFunction

    Private Sub dlgPCSARainfall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        'ucrBase.iHelpTopicID= 

        ucrPICSARainfallSelector.SetParameter(New RParameter("data", 0))
        ucrPICSARainfallSelector.SetParameterIsrfunction()

        ucrReceiverX.SetParameter(New RParameter("x", 0))
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.Selector = ucrPICSARainfallSelector
        ucrReceiverX.SetClimaticType("year")
        ucrReceiverX.strSelectorHeading = "Year Variables"
        ucrReceiverX.bAutoFill = True
        ucrReceiverX.bWithQuotes = False

        ucrFactorOptionalReceiver.SetParameter(New RParameter("colour", 2))
        ucrFactorOptionalReceiver.Selector = ucrPICSARainfallSelector
        ucrFactorOptionalReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorOptionalReceiver.strSelectorHeading = "Factors"
        ucrFactorOptionalReceiver.bWithQuotes = False
        ucrFactorOptionalReceiver.SetParameterIsString()

        ucrVariablesAsFactorForPicsa.SetParameter(New RParameter("y", 1))
        ucrVariablesAsFactorForPicsa.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForPicsa.Selector = ucrPICSARainfallSelector
        ucrVariablesAsFactorForPicsa.strSelectorHeading = "Varibles"
        ucrVariablesAsFactorForPicsa.SetParameterIsString()
        ucrVariablesAsFactorForPicsa.bWithQuotes = False

        ucrChkPoints.SetText("Add Points")
        ucrChkPoints.AddParameterPresentCondition(True, "points")
        ucrChkPoints.AddParameterPresentCondition(False, "points", False)
        clsPointsFunc.SetPackageName("ggplot2")
        clsPointsFunc.SetRCommand("geom_point")
        clsPointsParam.SetArgumentName("points")
        clsPointsParam.SetArgument(clsPointsFunc)
        clsPointsFunc.AddParameter("size", "3")
        clsPointsFunc.AddParameter("colour", Chr(34) & "red" & Chr(34))
        ucrChkPoints.SetParameter(clsPointsParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrSave.SetPrefix("PICSA_Rainfall_Graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Save Graph")
        ucrSave.SetDataFrameSelector(ucrPICSARainfallSelector.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsRggplotFunction = New RFunction
        clsRgeomlineplotFunction = New RFunction
        clsRaesFunction = New RFunction
        clsBaseOperator = New ROperator

        Dim clsPanelBackgroundElementRect As New RFunction
        Dim clsXElementLabels As New RFunction
        Dim clsPanelGridMajorElementLine As New RFunction
        Dim clsPanelGridMinorElementLine As New RFunction
        Dim clsPanelBorderElementRect As New RFunction

        ucrPICSARainfallSelector.Reset()
        ucrPICSARainfallSelector.SetGgplotFunction(clsBaseOperator)
        ucrSave.Reset()
        ucrVariablesAsFactorForPicsa.SetMeAsReceiver()
        bResetSubdialog = True
        bResetLineLayerSubdialog = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("lineplot", clsRFunctionParameter:=clsRgeomlineplotFunction, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsRgeomlineplotFunction.SetPackageName("ggplot2")
        clsRgeomlineplotFunction.SetRCommand("geom_line")
        clsRgeomlineplotFunction.AddParameter("colour", Chr(34) & "blue" & Chr(34))
        clsRgeomlineplotFunction.AddParameter("size", "0.8")
        clsBaseOperator.AddParameter(clsPointsParam)

        clsXLabFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYLabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()

        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        If dctThemeFunctions.TryGetValue("panel.background", clsPanelBackgroundElementRect) Then
            clsPanelBackgroundElementRect.AddParameter("colour", Chr(34) & "white" & Chr(34))
            clsPanelBackgroundElementRect.AddParameter("fill", Chr(34) & "white" & Chr(34))
            clsPanelBackgroundElementRect.AddParameter("size", "0.5")
            clsPanelBackgroundElementRect.AddParameter("linetype", Chr(34) & "solid" & Chr(34))
            clsThemeFunction.AddParameter("panel.background", clsRFunctionParameter:=clsPanelBackgroundElementRect)
        End If

        If dctThemeFunctions.TryGetValue("panel.grid.major", clsPanelGridMajorElementLine) Then
            clsPanelGridMajorElementLine.AddParameter("colour", Chr(34) & "lightblue" & Chr(34))
            clsPanelGridMajorElementLine.AddParameter("linetype", Chr(34) & "longdash" & Chr(34))
            clsThemeFunction.AddParameter("panel.grid.major", clsRFunctionParameter:=clsPanelGridMajorElementLine)
        End If

        If dctThemeFunctions.TryGetValue("panel.grid.minor", clsPanelGridMinorElementLine) Then
            clsPanelGridMinorElementLine.AddParameter("colour", Chr(34) & "lightblue" & Chr(34))
            clsPanelGridMinorElementLine.AddParameter("linetype", Chr(34) & "longdash" & Chr(34))
            clsThemeFunction.AddParameter("panel.grid.minor", clsRFunctionParameter:=clsPanelGridMinorElementLine)
        End If

        If dctThemeFunctions.TryGetValue("panel.border", clsPanelBorderElementRect) Then
            clsPanelBorderElementRect.AddParameter("colour", Chr(34) & "black" & Chr(34))
            clsPanelBorderElementRect.AddParameter("fill", Chr(34) & "NA" & Chr(34))
            clsThemeFunction.AddParameter("panel.border", clsRFunctionParameter:=clsPanelBorderElementRect)
        End If

        If dctThemeFunctions.TryGetValue("axis.text.x", clsXElementLabels) Then
            clsXElementLabels.AddParameter("angle", "90")
            clsThemeFunction.AddParameter("axis.text.x", clsRFunctionParameter:=clsXElementLabels)
        End If

        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=100)
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrPICSARainfallSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TempOptionsDisabledInMultipleVariablesCase()
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrPICSARainfallSelector.SetRCode(clsRggplotFunction, bReset)
        ucrReceiverX.SetRCode(clsRaesFunction, bReset)
        ucrFactorOptionalReceiver.SetRCode(clsRaesFunction, bReset)
        ucrSave.SetRCode(clsBaseOperator, bReset)
        ucrChkPoints.SetRCode(clsBaseOperator, bReset)
        ucrVariablesAsFactorForPicsa.SetRCode(clsRaesFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If (ucrVariablesAsFactorForPicsa.IsEmpty OrElse ucrReceiverX.IsEmpty) OrElse Not ucrSave.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub TempOptionsDisabledInMultipleVariablesCase()
        If ucrVariablesAsFactorForPicsa.bSingleVariable Then
            'Added this because this sub is called on sed defaults and  it over writes the enabled property 
            cmdPICSAOptions.Enabled = True
            cmdLineOptions.Enabled = True
            cmdOptions.Enabled = True
        Else
            cmdPICSAOptions.Enabled = False
            cmdLineOptions.Enabled = False
            cmdOptions.Enabled = False
        End If
    End Sub
    Private Sub ucrVariablesAsFactorForPicsa_ControlValueChanged() Handles ucrVariablesAsFactorForPicsa.ControlValueChanged
        TempOptionsDisabledInMultipleVariablesCase()
    End Sub

    'add more functions 
    Private Sub cmdPICSAOptions_Click(sender As Object, e As EventArgs) Handles cmdPICSAOptions.Click
        sdgPICSARainfallGraph.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, dctNewThemeFunctions:=dctThemeFunctions, clsNewLabsFunction:=clsLabsFunction, clsNewThemeFunction:=clsThemeFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, bReset:=bResetSubdialog)
        sdgPICSARainfallGraph.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXLabFunction, clsNewYLabTitleFunction:=clsYLabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction, ucrNewBaseSelector:=ucrPICSARainfallSelector, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False

        ucrVariablesAsFactorForPicsa.SetParameter(New RParameter("x"))

    End Sub

    Private Sub cmdLineOptions_Click(sender As Object, e As EventArgs) Handles cmdLineOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomlineplotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrPICSARainfallSelector, bApplyAesGlobally:=True, bReset:=bResetLineLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetLineLayerSubdialog = False
        'Coming from the sdgLayerOptions, clsRaesFunction and others has been modified. One then needs to display these modifications on the dlgScatteredPlot.

        'The aesthetics parameters on the main dialog are repopulated as required.
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrReceiverX.Clear()
                Else
                    ucrReceiverX.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the vlue stored in the clsReasFunction in the multiplevariables case is "value", however that one shouldn't be written in the multiple variables receiver (otherwise it would stack all variables and the stack ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables independently from the multiple variables method ? Here if the receiver is actually in single mode, the variable "value" will still be given back, which throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForPicsa.bSingleVariable) Then
                'Still might be in the case of bSingleVariable with mapping y="".
                If clsParam.strArgumentValue = (Chr(34) & Chr(34)) Then
                    ucrVariablesAsFactorForPicsa.Clear()
                Else ucrVariablesAsFactorForPicsa.Add(clsParam.strArgumentValue)
                End If
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrFactorOptionalReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub AllControl_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorForPicsa.ControlContentsChanged, ucrSave.ControlContentsChanged, ucrReceiverX.ControlContentsChanged
        TestOkEnabled()
    End Sub


End Class