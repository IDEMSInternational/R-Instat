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
Public Class dlgCombineforGraphics
    Private bFirstLoad As Boolean = True
    Private Sub dlgCombineforGraphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()

        End If
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 430
        ucrCombineGraphReceiver.Selector = ucrCombineGraphSelector
        ucrCombineGraphSelector.SetItemType("graph")
        ucrSaveCombinedGraph.strPrefix = "CombineGraph"
        ucrSaveCombinedGraph.SetDataFrameSelector(ucrCombineGraphSelector.ucrAvailableDataFrames)
        sdgCombineGraphOptions.SetRSyntax(ucrBase.clsRsyntax)
        ucrBase.clsRsyntax.SetFunction("gridExtra::grid.arrange")
    End Sub

    Private Sub SetDefaults()
        ucrCombineGraphReceiver.SetMeAsReceiver()
        ucrCombineGraphSelector.Reset()
        ucrSaveCombinedGraph.chkSaveGraph.Checked = False
        sdgCombineGraphOptions.SetDefaults()
        TestOkEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub
    Private Sub TestOkEnabled()
        If ucrCombineGraphReceiver.lstSelectedVariables.Items.Count > 1 Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrCombineGraphReceiver_SelectionChanged() Handles ucrCombineGraphReceiver.SelectionChanged
        If Not ucrCombineGraphReceiver.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("grobs", clsRFunctionParameter:=ucrCombineGraphReceiver.GetVariables())
            sdgCombineGraphOptions.SetDefaultRowAndColumns()
        Else
            ucrBase.clsRsyntax.RemoveParameter("grobs")
        End If
        TestOkEnabled()
    End Sub
    Private Sub cmdLayout_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgCombineGraphOptions.ShowDialog()
    End Sub

    Private Sub ucrSaveCombinedGraph_Load() Handles ucrSaveCombinedGraph.GraphNameChanged, ucrSaveCombinedGraph.SaveGraphCheckedChanged
        If ucrSaveCombinedGraph.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveCombinedGraph.strGraphName, strTempDataframe:=ucrCombineGraphSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveCombinedGraph.strGraphName)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrCombineGraphSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
        TestOkEnabled()
    End Sub
End Class