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
Public Class dlgDescribeTwoVarGraph
    Private bFirstLoad As Boolean = True
    Private Sub dlgDescribeTwoVarGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub
    Private Sub SetDefaults()
        ucrTwoVarGraphSave.Reset()
        ucrSelectorTwoVarGraph.Reset()
        ucrSelectorTwoVarGraph.Focus()
        TestOkEnabled()
    End Sub
    Private Sub InitialiseDialog()
        ucrReceiverTwoVarGraph.Selector = ucrSelectorTwoVarGraph
        ucrSecondVariableReceiver.Selector = ucrSelectorTwoVarGraph
        ucrTwoVarGraphSave.SetDataFrameSelector(ucrSelectorTwoVarGraph.ucrAvailableDataFrames)
        ucrTwoVarGraphSave.strPrefix = "TwoVaribleGraph"
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
    End Sub
    Private Sub TestOkEnabled()
        If Not ucrReceiverTwoVarGraph.IsEmpty AndAlso Not ucrSecondVariableReceiver.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrTwoVarGraphSave_Load() Handles ucrTwoVarGraphSave.GraphNameChanged, ucrTwoVarGraphSave.SaveGraphCheckedChanged
        If ucrTwoVarGraphSave.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrTwoVarGraphSave.strGraphName, strTempDataframe:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrTwoVarGraphSave.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
        TestOkEnabled()
    End Sub

    Private Sub cmdGraphOptions_Click(sender As Object, e As EventArgs) Handles cmdGraphOptions.Click
        sdgDescribeTwoVarGraph.ShowDialog()
    End Sub
End Class