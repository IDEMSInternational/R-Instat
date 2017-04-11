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

Public Class dlgScatterPlot
    Private clsRggplotFunction As New RFunction
    Private clsRScatterGeomFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgScatterPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 433

        ucrSelectorForScatter.SetParameter(New RParameter("data", 0))
        ucrSelectorForScatter.SetParameterIsrfunction()

        ucrVariablesAsFactorForScatter.SetParameter(New RParameter("y", 1))
        ucrVariablesAsFactorForScatter.SetParameterIsString()
        ucrVariablesAsFactorForScatter.bWithQuotes = False
        ucrVariablesAsFactorForScatter.Selector = ucrSelectorForScatter
        ucrVariablesAsFactorForScatter.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForScatter.SetIncludedDataTypes({"factor", "numeric"})

        ucrReceiverX.SetParameter(New RParameter("x", 0))
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.bWithQuotes = False
        ucrReceiverX.Selector = ucrSelectorForScatter
        ucrReceiverX.SetIncludedDataTypes({"factor", "numeric"})

        ucrFactorOptionalReceiver.SetParameter(New RParameter("colour", 2))
        ucrFactorOptionalReceiver.SetParameterIsString()
        ucrFactorOptionalReceiver.bWithQuotes = False
        ucrFactorOptionalReceiver.Selector = ucrSelectorForScatter
        ucrFactorOptionalReceiver.SetIncludedDataTypes({"factor", "numeric"})

        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)

        ucrSaveScatterPlot.SetDataFrameSelector(ucrSelectorForScatter.ucrAvailableDataFrames)
        ucrSaveScatterPlot.strPrefix = "Scatter"

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRScatterGeomFunction = New RFunction
        clsRaesFunction = New RFunction

        ucrSelectorForScatter.Reset()

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("scatter", clsRFunctionParameter:=clsRScatterGeomFunction)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsRScatterGeomFunction.SetRCommand("geom_point")
        clsRScatterGeomFunction.SetPackageName("ggplot2")

        sdgPlots.Reset()
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorForScatter.SetRCode(clsRggplotFunction, bReset)
        ucrReceiverX.SetRCode(clsRaesFunction, bReset)
        ucrVariablesAsFactorForScatter.SetRCode(clsRaesFunction, bReset)
        ucrFactorOptionalReceiver.SetRCode(clsRaesFunction, bReset)
    End Sub

    'Private Sub ucrSelectorForScatter_DataFrameChanged() Handles ucrSelectorForScatter.DataFrameChanged
    '    clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorForScatter.ucrAvailableDataFrames.clsCurrDataFrame)
    'End Sub

    'Private Sub SetXParameter()
    '    If Not ucrReceiverX.IsEmpty Then
    '        clsRaesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False))
    '    Else
    '        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
    '    End If
    'End Sub

    'Private Sub SetYParameter()
    '    If Not ucrVariablesAsFactorForScatter.IsEmpty Then
    '        clsRaesFunction.AddParameter("y", ucrVariablesAsFactorForScatter.GetVariableNames(False))
    '    Else
    '        clsRaesFunction.AddParameter("y", Chr(34) & Chr(34))
    '    End If
    'End Sub
    'Private Sub ucrReceiverX_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverX.SelectionChanged
    '    SetXParameter()
    '    TestOkEnabled()
    'End Sub

    'Private Sub ucrFactorOptionalReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorOptionalReceiver.SelectionChanged
    '    If Not ucrFactorOptionalReceiver.IsEmpty Then
    '        clsRaesFunction.AddParameter("colour", ucrFactorOptionalReceiver.GetVariableNames(False))
    '    Else
    '        clsRaesFunction.RemoveParameterByName("colour")
    '    End If
    'End Sub

    Private Sub TestOkEnabled()
        'tests when okay Is enable. Both x and y aesthetics are mandatory but can be set to x="" or(exclusive) y="" in case the other one is filled. 
        If (ucrReceiverX.IsEmpty() AndAlso ucrVariablesAsFactorForScatter.IsEmpty) OrElse (ucrSaveScatterPlot.chkSaveGraph.Checked AndAlso ucrSaveScatterPlot.ucrInputGraphName.IsEmpty) Then
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

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrSelectorForScatter.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
    End Sub

    'Private Sub ucrVariablesAsFactor_SelectionChanged() Handles ucrVariablesAsFactorForScatter.SelectionChanged
    '    SetYParameter()
    '    TestOkEnabled()
    'End Sub

    Private Sub cmdScatterPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdScatterPlotOptions.Click
        'SetupLayer sends the components storing the plot info (clsRaesFunction, clsRggplotFunction, ...) of dlgScatteredPlot through to sdgLayerOptions where these will be edited.
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRScatterGeomFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrSelectorForScatter.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True, bIgnoreGlobalAes:=False)
        sdgLayerOptions.ShowDialog()
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
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForScatter.bSingleVariable) Then
                'Still might be in the case of bSingleVariable with mapping y="".
                If clsParam.strArgumentValue = (Chr(34) & Chr(34)) Then
                    ucrVariablesAsFactorForScatter.Clear()
                Else ucrVariablesAsFactorForScatter.Add(clsParam.strArgumentValue)
                End If
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrFactorOptionalReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
    End Sub

    Private Sub ucrsavescatterplot_graphnamechanged() Handles ucrSaveScatterPlot.GraphNameChanged, ucrSaveScatterPlot.SaveGraphCheckedChanged
        If ucrSaveScatterPlot.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveScatterPlot.strGraphName, strTempDataframe:=ucrSelectorForScatter.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveScatterPlot.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorForScatter.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveScatterPlot_ContentsChanged() Handles ucrSaveScatterPlot.ContentsChanged, ucrReceiverX.ControlContentsChanged, ucrVariablesAsFactorForScatter.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class