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
Public Class dlgPlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_lineplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Public bFirstLoad As Boolean = True

    Private Sub dlgPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
            'SetDefaults
            SetDefaults()
        Else
            'reopendialog
        End If

        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        clsRaesFunction.ClearParameters()
        clsRgeom_lineplotFunction.ClearParameters()
        chkPoints.Checked = False
        ucrLinePlotSelector.Focus()
        ucrLinePlotSelector.Reset()
        ucrVariablesAsFactorForLinePlot.ResetControl()
        ucrSaveLinePlot.Reset()
        sdgPlots.Reset()
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)

        clsRgeom_lineplotFunction.SetRCommand("geom_line")
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_lineplotFunction)

        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.iHelpTopicID = 434


        ucrReceiverX.Selector = ucrLinePlotSelector
        ucrReceiverX.SetIncludedDataTypes({"numeric", "factor"})
        ucrFactorOptionalReceiver.Selector = ucrLinePlotSelector
        ucrFactorOptionalReceiver.SetIncludedDataTypes({"factor"})
        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)



        ucrVariablesAsFactorForLinePlot.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForLinePlot.SetSelector(ucrLinePlotSelector)
        ucrVariablesAsFactorForLinePlot.SetIncludedDataType({"numeric", "factor"})

        ucrSaveLinePlot.SetDataFrameSelector(ucrLinePlotSelector.ucrAvailableDataFrames)
        ucrSaveLinePlot.strPrefix = "Line"
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False


    End Sub

    Private Sub TestOkEnabled()
        If (ucrReceiverX.IsEmpty() AndAlso ucrVariablesAsFactorForLinePlot.IsEmpty()) OrElse (ucrSaveLinePlot.chkSaveGraph.Checked AndAlso ucrSaveLinePlot.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrPlotSelector_DataFrameChanged() Handles ucrLinePlotSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrLinePlotSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrReceiverX_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverX.SelectionChanged

        If ucrReceiverX.IsEmpty() = False Then
            clsRaesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False))
            ucrFactorOptionalReceiver.SetMeAsReceiver()
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrFactorOptionalReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorOptionalReceiver.SelectionChanged
        If ucrFactorOptionalReceiver.IsEmpty() = False Then
            clsRaesFunction.AddParameter("colour", ucrFactorOptionalReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("colour")
        End If
    End Sub
    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub chkPoints_CheckedChanged(sender As Object, e As EventArgs) Handles chkPoints.CheckedChanged
        Dim clsTempRFunc As New RFunction
        If chkPoints.Checked = True Then
            clsTempRFunc.SetRCommand("geom_point")
            ucrBase.clsRsyntax.AddOperatorParameter("geom_point", clsRFunc:=clsTempRFunc)
        Else
            ucrBase.clsRsyntax.RemoveOperatorParameter("geom_point")
        End If
    End Sub

    Private Sub UcrVariablesAsFactor_SelectionChanged() Handles ucrVariablesAsFactorForLinePlot.SelectionChanged
        If Not ucrVariablesAsFactorForLinePlot.IsEmpty() Then
            clsRaesFunction.AddParameter("y", ucrVariablesAsFactorForLinePlot.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("y")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveLinePlot_GraphNameChanged() Handles ucrSaveLinePlot.GraphNameChanged, ucrSaveLinePlot.SaveGraphCheckedChanged
        If ucrSaveLinePlot.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveLinePlot.strGraphName, strTempDataframe:=ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveLinePlot.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
        TestOkEnabled()
    End Sub

    Private Sub cmdPointOptions_Click(sender As Object, e As EventArgs) Handles cmdPointOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_lineplotFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True, bIgnoreGlobalAes:=False)
        sdgLayerOptions.ShowDialog()

        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "y" Then
                ucrVariablesAsFactorForLinePlot.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "x" Then
                ucrReceiverX.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrFactorOptionalReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveLinePlot_ContentsChanged() Handles ucrSaveLinePlot.ContentsChanged
        TestOkEnabled()
    End Sub
End Class