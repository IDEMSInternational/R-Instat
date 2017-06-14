' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgDotPlot
    'In order, the global ggplot function, the geom_dotplot function and the aes function, used as parameter in the ggplot function.
    Private clsRggPlotFunction As New RFunction
    Private clsRDotplotGeomFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    'bFirstload is used to determine whether the dlg still needs setup or not.
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    'strBinAxis stores the name of the axis along which the bins are made. Then strOtherAxis is the other axis (x or y)
    Private strBinAxis As String
    Private strOtherAxis As String
    'bEditAesFunction is used to avoid the aesthetics to be edited within clsRaesFunction when the receivers are actually setup according to the content of clsRaesFunction (for example coming back from LayerOptions).
    Private bEditAesFunction As Boolean
    Private clsLocalRaesFunction As New RFunction
    Private bResetLayerSubdialog As Boolean = True

    Private Sub dlgDotPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForContorls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForContorls(bReset As Boolean)
        ucrDotPlotSelector.SetRCode(clsRggPlotFunction, bReset)
        ucrSaveDotPlot.SetRCode(clsBaseOperator, bReset)
        ucrPnlBinAxis.SetRCode(clsRDotplotGeomFunction, bReset)

        ucrVariablesAsFactorDotPlot.SetRCode(clsRaesFunction, bReset)
        ucrOtherAxisReceiver.SetRCode(clsRaesFunction, bReset)
        ucrFactorReceiver.SetRCode(clsRaesFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 437
        ucrBase.clsRsyntax.iCallType = 3

        ucrDotPlotSelector.SetParameter(New RParameter("data", 0))
        ucrDotPlotSelector.SetParameterIsrfunction()

        ucrPnlBinAxis.SetParameter(New RParameter("binaxis", 0))
        ucrPnlBinAxis.AddRadioButton(rdoXBinAxis, Chr(34) & "x" & Chr(34))
        ucrPnlBinAxis.AddRadioButton(rdoYBinAxis, Chr(34) & "y" & Chr(34))

        ucrOtherAxisReceiver.SetParameter(New RParameter("y", 1))
        ucrOtherAxisReceiver.SetParameterIsString()
        ucrOtherAxisReceiver.Selector = ucrDotPlotSelector
        ucrOtherAxisReceiver.SetIncludedDataTypes({"factor", "numeric"}) 'Warning: Even if having "factor" only could be more appropriate for the Axis that is not BinAxis, when coming back from the LayerOptions, where x and y can take both numeric and factor values, we would get bugs if numeric was not allowed.
        ucrOtherAxisReceiver.bWithQuotes = False
        ucrOtherAxisReceiver.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrOtherAxisReceiver.bAddParameterIfEmpty = True

        ucrFactorReceiver.SetParameter(New RParameter("fill", 2))
        ucrFactorReceiver.Selector = ucrDotPlotSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorReceiver.bWithQuotes = False
        ucrFactorReceiver.SetParameterIsString()

        'The ucrVariablesAsFactorDotPlot could be called the ucrBinAxis in spirit.
        'On the next line, the ucrOtherAxisReceiver receiver is used as the aesthetics to factor by when different variables are grouped into a single column in the multiple variables method. 
        ucrVariablesAsFactorDotPlot.SetParameter(New RParameter("x"), 0)
        ucrVariablesAsFactorDotPlot.SetFactorReceiver(ucrOtherAxisReceiver) 'Could choose the ucrFactorReceiver for this purpose... 
        ucrVariablesAsFactorDotPlot.Selector = ucrDotPlotSelector
        ucrVariablesAsFactorDotPlot.SetIncludedDataTypes({"numeric", "factor"})
        ucrVariablesAsFactorDotPlot.bWithQuotes = False
        ucrVariablesAsFactorDotPlot.SetParameterIsString()

        ucrSaveDotPlot.SetPrefix("dotPlot")
        ucrSaveDotPlot.SetSaveTypeAsGraph()
        ucrSaveDotPlot.SetIsComboBox()
        ucrSaveDotPlot.SetCheckBoxText("Save Graph")
        ucrSaveDotPlot.SetDataFrameSelector(ucrDotPlotSelector.ucrAvailableDataFrames)
        ucrSaveDotPlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub TestOkEnabled()
        If ucrVariablesAsFactorDotPlot.IsEmpty OrElse Not ucrSaveDotPlot.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggPlotFunction = New RFunction
        clsRDotplotGeomFunction = New RFunction
        clsRaesFunction = New RFunction

        ucrDotPlotSelector.Reset()
        ucrSaveDotPlot.Reset()
        bResetSubdialog = True

        'I am not sure we need this
        bEditAesFunction = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggPlotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("dotplot", clsRFunctionParameter:=clsRDotplotGeomFunction)

        clsRggPlotFunction.SetPackageName("ggplot2")
        clsRggPlotFunction.SetRCommand("ggplot")
        clsRggPlotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("y", Chr(34) & Chr(34))

        clsRDotplotGeomFunction.SetPackageName("ggplot2")
        clsRDotplotGeomFunction.SetRCommand("geom_dotplot")
        clsRDotplotGeomFunction.AddParameter("binaxis", Chr(34) & "x" & Chr(34))

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrDotPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)

    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForContorls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdDotPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdDotPlotOptions.Click
        'This sub handles a call of the options which opens the LayerOptions sdg.
        Dim iIndex As Integer
        bEditAesFunction = False 'The content of the AesFunction should not be edited when we are setting up the dialogue according to the content of AesFunction, when coming back from LayerOptions.
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggPlotFunction, clsNewGeomFunc:=clsRDotplotGeomFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrDotPlotSelector, bApplyAesGlobally:=True, bReset:=bResetLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        iIndex = clsRDotplotGeomFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "binaxis")
        If iIndex <> -1 AndAlso clsRDotplotGeomFunction.clsParameters(iIndex).strArgumentValue = Chr(34) & "y" & Chr(34) Then
            rdoYBinAxis.Checked = True
        Else
            rdoXBinAxis.Checked = True 'Note: the default value of "binaxis" is "x"
        End If
        'Task: adapt for multivariable case...
        'Warning: In specific plots in general, we still have the bug that if ApplyOnAllLayers is unchecked on the LayerOptions, then the aesthetics will be stored in the LocalAes.
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = strOtherAxis Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrOtherAxisReceiver.Clear()
                Else
                    ucrOtherAxisReceiver.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the value stored in the clsReasFunction in the multiplevariables case is "value", however that one shouldn't be written in the multiple variables receiver (otherwise it would stack all variables and the stack ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables independently from the multiple variables method ? Here if the receiver is actually in single mode, the variable "value" will still be given back, which throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = strBinAxis AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorDotPlot.bSingleVariable) Then
                ucrVariablesAsFactorDotPlot.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        bEditAesFunction = True
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, ucrNewBaseSelector:=ucrDotPlotSelector, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub AllControlChanged() Handles ucrVariablesAsFactorDotPlot.ControlContentsChanged, ucrSaveDotPlot.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class