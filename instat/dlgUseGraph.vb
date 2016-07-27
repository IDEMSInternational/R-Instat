﻿' Instat-R
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
Public Class dlgUseGraph
    Private bFirstLoad As Boolean = True
    Private Sub dlgUseGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReOpenDialog()
        End If
        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        ucrGraphReceiver.SetMeAsReceiver()
        ucrGraphsSelector.Reset()
        ucrSaveGraphForUseGraph.chkSaveGraph.Checked = False
        TestOkEnabled()
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 430
        ucrGraphsSelector.SetItemType("graph")
        ucrGraphReceiver.Selector = ucrGraphsSelector
        sdgLayerOptions.SetRSyntax(ucrBase.clsRsyntax)
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$get_graphs")
        ucrSaveGraphForUseGraph.SetDataFrameSelector(ucrGraphsSelector.ucrAvailableDataFrames)
        ucrSaveGraphForUseGraph.strPrefix = "Usedgraph"

    End Sub
    Private Sub ReOpenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
    Private Sub TestOkEnabled()
        If Not ucrGraphReceiver.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub ucrGraphReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrGraphReceiver.SelectionChanged
        If Not ucrGraphReceiver.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("graph_name", ucrGraphReceiver.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("graph_name")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrGraphsSelector_DataFrameChanged() Handles ucrGraphsSelector.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrGraphsSelector.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))

    End Sub

    Private Sub cmdPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrSaveGraphForUseGraph_GraphNameChanged() Handles ucrSaveGraphForUseGraph.GraphNameChanged, ucrSaveGraphForUseGraph.SaveGraphCheckedChanged
        If ucrSaveGraphForUseGraph.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveGraphForUseGraph.strGraphName, strTempDataframe:=ucrGraphsSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveGraphForUseGraph.strGraphName)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrGraphsSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If

        TestOkEnabled()
    End Sub
End Class