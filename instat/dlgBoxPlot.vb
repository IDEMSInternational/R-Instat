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
Public Class dlgBoxplot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_boxplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private bFirstLoad As Boolean = True

    Private Sub dlgBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
    End Sub
    Public Sub SetOperator()
        Dim clsTempRFunc As New RFunction
        If chkHorizontalBoxplot.Checked Then
            clsTempRFunc.SetRCommand("coord_flip")
            ucrBase.clsRsyntax.AddOperatorParameter("coord_flip", clsRFunc:=clsTempRFunc)
        Else
            ucrBase.clsRsyntax.RemoveOperatorParameter("coord_flip")
        End If
    End Sub

    Private Sub SetDefaults()
        clsRaesFunction.ClearParameters()
        clsRgeom_boxplotFunction.ClearParameters()
        ucrSelectorBoxPlot.Reset()
        ucrSelectorBoxPlot.Focus()
        ucrVariablesAsFactorForBoxplot.ResetControl()
        chkHorizontalBoxplot.Checked = False
        sdgPlots.Reset()
        TestOkEnabled()
        SetXParameter()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRgeom_boxplotFunction.SetRCommand("geom_boxplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_boxplotFunction)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrBase.iHelpTopicID = 436
        ucrBase.clsRsyntax.iCallType = 0

        ucrByFactorsReceiver.Selector = ucrSelectorBoxPlot
        ucrByFactorsReceiver.SetIncludedDataTypes({"factor"})

        ucrSecondFactorReceiver.Selector = ucrSelectorBoxPlot
        ucrSecondFactorReceiver.SetIncludedDataTypes({"factor"})


        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        sdgPlots.SetGgplotFunction(clsRggplotFunction)

        ucrVariablesAsFactorForBoxplot.SetFactorReceiver(ucrByFactorsReceiver)
        ucrVariablesAsFactorForBoxplot.SetSelector(ucrSelectorBoxPlot)
        ucrVariablesAsFactorForBoxplot.SetIncludedDataType({"numeric"})


        ucrSaveBoxplot.SetDataFrameSelector(ucrSelectorBoxPlot.ucrAvailableDataFrames)
        ucrSaveBoxplot.strPrefix = "Boxplot"

    End Sub

    Private Sub TestOkEnabled()

        If ucrVariablesAsFactorForBoxplot.IsEmpty Or (ucrSaveBoxplot.chkSaveGraph.Checked And ucrSaveBoxplot.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrSelectorBoxPlot_DataFrameChanged() Handles ucrSelectorBoxPlot.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorBoxPlot.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrByFactorsReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrByFactorsReceiver.SelectionChanged
        SetXParameter()
    End Sub

    Private Sub SetXParameter()
        If Not ucrByFactorsReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrByFactorsReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
    End Sub

    Private Sub ucrSecondFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrSecondFactorReceiver.SelectionChanged

        If Not ucrSecondFactorReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("fill", ucrSecondFactorReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("fill")
        End If
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub cmdBoxPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdBoxPlotOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_boxplotFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True, bIgnoreGlobalAes:=False)
        sdgLayerOptions.ShowDialog()
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = "" Then
                    ucrByFactorsReceiver.Clear()
                Else
                    ucrByFactorsReceiver.Add(clsParam.strArgumentValue)
                End If
            ElseIf clsParam.strArgumentName = "y" Then
                ucrVariablesAsFactorForBoxplot.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrSecondFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub chkHorizontalBoxplot_CheckedChanged(sender As Object, e As EventArgs) Handles chkHorizontalBoxplot.CheckedChanged
        SetOperator()
    End Sub

    Private Sub UcrVariablesAsFactor1_SelectionChanged() Handles ucrVariablesAsFactorForBoxplot.SelectionChanged
        If Not ucrVariablesAsFactorForBoxplot.IsEmpty Then
            clsRaesFunction.AddParameter("y", ucrVariablesAsFactorForBoxplot.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("y")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveBoxplot_GraphNameChanged() Handles ucrSaveBoxplot.GraphNameChanged, ucrSaveBoxplot.SaveGraphCheckedChanged
        If ucrSaveBoxplot.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveBoxplot.strGraphName, strTempDataframe:=ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveBoxplot.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
        TestOkEnabled()
    End Sub
End Class