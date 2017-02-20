
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
Imports instat
Imports instat.Translations
Public Class dlgScatterPlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_scatterplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    '    Private bResetSubdialog As Boolean = False

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
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 433

        'ucrSelectorForScatter
        ucrSelectorForScatter.SetParameter(New RParameter("data", 0)) ' for clsRggplotFunction
        ucrSelectorForScatter.SetParameterIsString()

        'ucrMainReceiver
        ' set parameter? canne if not inherits ucrCore
        ucrVariablesAsFactorForScatter.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForScatter.SetSelector(ucrSelectorForScatter)
        ucrVariablesAsFactorForScatter.SetIncludedDataType({"factor", "numeric"})

        'ucrReceiverX
        ucrReceiverX.SetParameter(New RParameter("x",)) ' only x = this if it is full, otherwise x = "", clsaes
        ucrReceiverX.Selector = ucrSelectorForScatter
        ucrReceiverX.SetIncludedDataTypes({"factor", "numeric"})
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.GetVariableNames(False)

        'ucrReceiverOptional
        ucrFactorOptionalReceiver.SetParameter(New RParameter("colour",)) 'clsaes, only x = this if it is full, otherwise x = ""
        ucrFactorOptionalReceiver.SetParameterIsString()
        ucrFactorOptionalReceiver.GetVariableNames(False)
        ucrFactorOptionalReceiver.Selector = ucrSelectorForScatter
        ucrFactorOptionalReceiver.SetIncludedDataTypes({"factor", "numeric"})

        'ucrSave
        ucrSaveGraph.SetPrefix("Scatter")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorForScatter.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")


        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)

        clsRgeom_scatterplotFunction.SetRCommand("geom_point")
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_scatterplotFunction)

        '        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
    End Sub
    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        ucrSaveGraph.Reset()
        ucrSelectorForScatter.Reset()
        ucrVariablesAsFactorForScatter.ResetControl()
        '        sdgPlots.Reset()

        'setDefaults
        clsRaesFunction.ClearParameters()
        clsRgeom_scatterplotFunction.ClearParameters()
        SetXParameter()
        SetYParameter()
        TestOkEnabled()
        '        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$graph_one_variable")

        ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorForScatter.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        '       ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        '        bResetSubdialog = True
    End Sub

    Private Sub ucrSelectorForScatter_DataFrameChanged() Handles ucrSelectorForScatter.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorForScatter.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub SetXParameter()
        If Not ucrReceiverX.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False))
        Else
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
    End Sub

    Private Sub SetYParameter()
        If Not ucrVariablesAsFactorForScatter.IsEmpty Then
            clsRaesFunction.AddParameter("y", ucrVariablesAsFactorForScatter.GetVariableNames(False))
        Else
            clsRaesFunction.AddParameter("y", Chr(34) & Chr(34))
        End If
    End Sub

    Private Sub ucrReceiverX_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverX.SelectionChanged
        SetXParameter()
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
        'tests when okay Is enable. Both x and y aesthetics are mandatory but can be set to x="" or(exclusive) y="" in case the other one is filled. 
        If (Not ucrReceiverX.IsEmpty() OrElse Not ucrVariablesAsFactorForScatter.IsEmpty) AndAlso (ucrSaveGraph.IsComplete()) AndAlso ucrVariablesAsFactorForScatter.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        '        sdgPlots.SetDataFrame(strNewDataFrame:=ucrSelectorForScatter.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        '        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrVariablesAsFactor_SelectionChanged() Handles ucrVariablesAsFactorForScatter.SelectionChanged
        SetYParameter()
        TestOkEnabled()
    End Sub

    Private Sub cmdScatterPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdScatterPlotOptions.Click
        'SetupLayer sends the components storing the plot info (clsRaesFunction, clsRggplotFunction, ...) of dlgScatteredPlot through to sdgLayerOptions where these will be edited.
        '        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_scatterplotFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrSelectorForScatter.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True, bIgnoreGlobalAes:=False)
        '        sdgLayerOptions.ShowDialog()
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

    Private Sub ucrSaveGraph_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveGraph.ControlContentsChanged, ucrReceiverX.ControlContentsChanged, ucrFactorOptionalReceiver.ControlContentsChanged ', ucrVariablesAsFactorForScatter.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class