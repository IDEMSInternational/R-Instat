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
Public Class dlgCumulativeDistribution
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_CumDistFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub dlgCumulativeDistribution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitaliseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOkEnabled()
    End Sub
    Public Sub InitaliseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        clsRgeom_CumDistFunction.SetRCommand("stat_ecdf")
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_CumDistFunction)


        ucrFactorReceiver.Selector = ucrCumDistSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.iHelpTopicID = 453

        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)


        ucrVariablesAsFactorforCumDist.SetFactorReceiver(ucrFactorReceiver)
        ucrVariablesAsFactorforCumDist.Selector = ucrCumDistSelector
        ucrVariablesAsFactorforCumDist.SetIncludedDataTypes({"numeric"})


        ucrSaveCumDist.SetDataFrameSelector(ucrCumDistSelector.ucrAvailableDataFrames)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
    End Sub

    Private Sub SetDefaults()
        'set defaults here 
        ucrSaveCumDist.strPrefix = "Graph"
        ucrCumDistSelector.Reset()
        ucrCumDistSelector.Focus()
        chkCountsOnYAxis.Checked = False
        chkExceedancePlots.Checked = True
        chkIncludePoints.Checked = False
        ucrSaveCumDist.Reset()
        sdgPlots.Reset()
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        'TODO what enables ok
        If ucrVariablesAsFactorforCumDist.IsEmpty OrElse (ucrSaveCumDist.chkSaveGraph.Checked AndAlso ucrSaveCumDist.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub
    Private Sub ucrCumDistSelector_DataFrameChanged() Handles ucrCumDistSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrCumDistSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub
    Private Sub ucrFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorReceiver.SelectionChanged
        If Not ucrFactorReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("colour", ucrFactorReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("colour")
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrVariablesAsFactorforCumDist_SelectionChanged() Handles ucrVariablesAsFactorforCumDist.SelectionChanged
        If Not ucrVariablesAsFactorforCumDist.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrVariablesAsFactorforCumDist.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
        TestOkEnabled()
    End Sub

    Private Sub chkExceedancePlots_CheckedChanged(sender As Object, e As EventArgs) Handles chkExceedancePlots.CheckedChanged
        Dim clsTempRFunc As New RFunction
        If chkExceedancePlots.Checked Then
            clsTempRFunc.SetRCommand("scale_y_reverse")
            clsTempRFunc.AddParameter("breaks", "seq(1,0,-0.25), labels = seq(0,1,0.25)")
            ucrBase.clsRsyntax.AddOperatorParameter("scale_y_reverse", clsRFunc:=clsTempRFunc)
        Else
            ucrBase.clsRsyntax.RemoveOperatorParameter("scale_y_reverse")
        End If
    End Sub

    Private Sub ucrSaveCumDist_GraphNameChanged() Handles ucrSaveCumDist.GraphNameChanged, ucrSaveCumDist.SaveGraphCheckedChanged
        If ucrSaveCumDist.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveCumDist.strGraphName, strTempDataframe:=ucrCumDistSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveCumDist.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrCumDistSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
    End Sub

    Private Sub cmdPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrCumDistSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
    End Sub

    Private Sub cmdLineOptions_Click(sender As Object, e As EventArgs) Handles cmdLineOptions.Click
        sdgLayerOptions.ShowDialog()
    End Sub

    Private Sub ucrSaveCumDist_ContentsChanged() Handles ucrSaveCumDist.ContentsChanged
        TestOkEnabled()
    End Sub
End Class