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

Public Class dlgOneVariableGraph
    Private clsRggplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsRgeom_Function As New RFunction
    Private bFirstLoad As Boolean = True

    Private Sub dlgOneVariableGraph_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorOneVarGraph.Reset()
        ucrSelectorOneVarGraph.Focus()
        ucrOneVarGraphSave.Reset()
        rdoFacets.Checked = True
        ucrOneVarGraphSave.Reset()
        sdgOneVarGraph.SetDefaults()
        ucrOneVarGraphSave.strPrefix = "OneVariableGraph"
        chkFlipCoordinates.Checked = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        rdoSingleGraphs.Enabled = False
        ucrReceiverOneVarGraph.Selector = ucrSelectorOneVarGraph
        ucrReceiverOneVarGraph.SetMeAsReceiver()
        ucrBase.iHelpTopicID = 412
        ucrOneVarGraphSave.strPrefix = "OneVariableGraph"
        ucrOneVarGraphSave.SetDataFrameSelector(ucrSelectorOneVarGraph.ucrAvailableDataFrames)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$graph_one_variable")
        sdgOneVarGraph.SetRSyntax(ucrBase.clsRsyntax)
        sdgOneVarGraph.InitialiseDialog()

    End Sub
    Private Sub ReopenDialog()
        CheckDataType()
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverOneVarGraph.IsEmpty() OrElse (ucrOneVarGraphSave.chkSaveGraph.Checked AndAlso ucrOneVarGraphSave.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrSelectorOneVarGraph_DataFrameChanged() Handles ucrSelectorOneVarGraph.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorOneVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
    End Sub

    Private Sub ucrReceiverOneVarGraph_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverOneVarGraph.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("columns", ucrReceiverOneVarGraph.GetVariableNames())
        CheckDataType()
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOkEnabled()
    End Sub

    Private Sub ucrOneVarGraphSave_GraphNameChanged() Handles ucrOneVarGraphSave.GraphNameChanged, ucrOneVarGraphSave.SaveGraphCheckedChanged
        If ucrOneVarGraphSave.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrOneVarGraphSave.strGraphName, strTempDataframe:=ucrSelectorOneVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrOneVarGraphSave.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorOneVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
        TestOkEnabled()
    End Sub
    Private Sub cmdGraph_Click(sender As Object, e As EventArgs) Handles cmdGraphOptions.Click
        sdgOneVarGraph.ShowDialog()
    End Sub

    Private Sub rdoFacets_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFacets.CheckedChanged, rdoCombineGraph.CheckedChanged, rdoSingleGraphs.CheckedChanged
        SetOutputparameter()
    End Sub

    Private Sub SetOutputparameter()
        If rdoFacets.Checked Then
            ucrBase.clsRsyntax.AddParameter("output", Chr(34) & "facets" & Chr(34))
        ElseIf rdoCombineGraph.Checked Then
            ucrBase.clsRsyntax.AddParameter("output", Chr(34) & "combine" & Chr(34))
        ElseIf rdoSingleGraphs.Checked Then
            ucrBase.clsRsyntax.AddParameter("output", Chr(34) & "single" & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("output") 'this might never run because atleast one must be checked at a time
        End If
    End Sub

    Private Sub CheckDataType()
        If ucrReceiverOneVarGraph.IsAllNumeric() OrElse ucrReceiverOneVarGraph.IsAllCategorical() Then
            rdoFacets.Enabled = True
        Else
            rdoFacets.Enabled = False
            If rdoFacets.Checked Then
                rdoCombineGraph.Checked = True
            End If
        End If
    End Sub

    Private Sub ucrOneVarGraphSave_ContentsChanged() Handles ucrOneVarGraphSave.ContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub chkFlipCoordinates_CheckedChanged(sender As Object, e As EventArgs) Handles chkFlipCoordinates.CheckedChanged
        If chkFlipCoordinates.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("coord_flip", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("coord_flip")
        End If
    End Sub
End Class