
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
Public Class dlgRugPlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_RugPlotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private bFirstLoad As Boolean = True

    Private Sub dlgRugPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
        'TestOkEnabled()
        'this is already done in SetDefaults !
    End Sub

    Private Sub ucrRugPlotSelector_DataFrameChanged() Handles ucrRugPlotSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrRugPlotSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrReceiverX_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverX.SelectionChanged

        If Not ucrReceiverX.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrFactorOptionalReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorOptionalReceiver.SelectionChanged
        If Not ucrFactorOptionalReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("colour", ucrFactorOptionalReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("colour")
        End If
    End Sub

    Private Sub TestOkEnabled()
        'tests when okay Is enable
        If (ucrReceiverX.IsEmpty() And ucrVariablesAsFactorForRugPlot.IsEmpty) Or (ucrSaveRugPlot.chkSaveGraph.Checked And ucrSaveRugPlot.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)

        clsRgeom_RugPlotFunction.SetRCommand("geom_rug")
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_RugPlotFunction)

        ucrVariablesAsFactorForRugPlot.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForRugPlot.SetSelector(ucrRugPlotSelector)
        ucrVariablesAsFactorForRugPlot.SetIncludedDataType({"factor", "numeric"})

        ucrReceiverX.Selector = ucrRugPlotSelector
        ucrReceiverX.SetIncludedDataTypes({"factor", "numeric"})
        ucrFactorOptionalReceiver.Selector = ucrRugPlotSelector
        ucrFactorOptionalReceiver.SetIncludedDataTypes({"factor"})

        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        'should the sdgLayerOptions be linked here as well ?
        ucrBase.iHelpTopicID = 433

        ucrSaveRugPlot.SetDataFrameSelector(ucrRugPlotSelector.ucrAvailableDataFrames)
        ucrSaveRugPlot.strPrefix = "Rug"
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

    End Sub
    Private Sub SetDefaults()
        clsRaesFunction.ClearParameters()
        clsRgeom_RugPlotFunction.ClearParameters()
        ucrRugPlotSelector.Reset()
        ucrRugPlotSelector.Focus()
        ucrVariablesAsFactorForRugPlot.ResetControl()
        sdgPlots.Reset()
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrRugPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrVariablesAsFactor_SelectionChanged() Handles ucrVariablesAsFactorForRugPlot.SelectionChanged
        If Not ucrVariablesAsFactorForRugPlot.IsEmpty Then
            clsRaesFunction.AddParameter("y", ucrVariablesAsFactorForRugPlot.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("y")
        End If
        TestOkEnabled()
    End Sub

    Private Sub cmdRugPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdRugPlotOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_RugPlotFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrRugPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bUseGlobalAes:=True, bHideApplyToAllLayers:=True)
        'Attempt to solve the Apply to all Layers problem: when I untick the Apply To All Layers that appear on the sdg raised by RugPlotOptions, what I have selected in the options are not carried through to RugPlot dialogue... 
        'Hence I have added a parameter bHideApplyToAllLayers  to the functions SetupLayer in sdgLayerOptions And subsequently in Setup in ucrGeomListWithAes, that when True (default is False), will trigger chkApplyOnAllLayers.Hide() in the ucrGeomListWithAes.
        'It is not very very clean in the sense that it doesn't do it for all the specific dialogues and should be added independently, but might work anyway...
        sdgLayerOptions.ShowDialog()

        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "y" Then
                'TODO Fix this generally
                'ucrVariablesAsFactorForScatter.SetSingleReceiverStatus(True)
                ucrVariablesAsFactorForRugPlot.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "x" Then
                ucrReceiverX.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrFactorOptionalReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
    End Sub

    Private Sub ucrSaveScatterPlot_GraphNameChanged() Handles ucrSaveRugPlot.GraphNameChanged, ucrSaveRugPlot.SaveGraphCheckedChanged
        If ucrSaveRugPlot.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveRugPlot.strGraphName, strTempDataframe:=ucrRugPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveRugPlot.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrRugPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
        TestOkEnabled()
    End Sub
End Class