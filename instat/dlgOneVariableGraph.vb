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
    Private clsBaseOperatorOneColumn As New ROperator
    Private clsBaseFunctionMultipleVariables As New RFunction
    Public strNumericGeomFunction As String
    Public strCategoricalGeomFunction As String

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
        rdoCombineGraph.Enabled = False
        sdgOneVarGraph.SetDefaults()
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverOneVarGraph.Selector = ucrSelectorOneVarGraph
        ucrReceiverOneVarGraph.SetMeAsReceiver()
        OneOrMoreVariables()
        'ucrBase.iHelpTopicID = 
        ucrOneVarGraphSave.strPrefix = "OneVariableGraph"
        ucrOneVarGraphSave.SetDataFrameSelector(ucrSelectorOneVarGraph.ucrAvailableDataFrames)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        clsBaseOperatorOneColumn.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.ClearParameters()
        clsBaseOperatorOneColumn.SetParameter(True, clsRFunc:=clsRggplotFunction)
        clsBaseOperatorOneColumn.SetParameter(False, clsRFunc:=clsRgeom_Function)
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorOneVarGraph.ucrAvailableDataFrames.clsCurrDataFrame)
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)

        clsBaseFunctionMultipleVariables.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$graph_one_variable")
        sdgOneVarGraph.SetRSyntax(ucrBase.clsRsyntax)
        sdgOneVarGraph.SetNumericGeomFunction(strNumericGeomFunction)
        sdgOneVarGraph.SetCategoricalGeomFunction(strCategoricalGeomFunction)

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverOneVarGraph.IsEmpty() OrElse (ucrOneVarGraphSave.chkSaveGraph.Checked AndAlso ucrOneVarGraphSave.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub OneOrMoreVariables()
        If ucrReceiverOneVarGraph.GetVariablesAsList.Count = 1 Then
            ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperatorOneColumn)

            If ucrReceiverOneVarGraph.GetCurrentItemTypes()(0) = "numeric" Then
                'TODO Geom should come from the subdialog
                clsRgeom_Function.SetRCommand(strNumericGeomFunction)
                If Not ucrReceiverOneVarGraph.IsEmpty() Then
                    clsRaesFunction.AddParameter("y", ucrReceiverOneVarGraph.GetVariableNames(False))
                End If

                clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
            Else
                'TODO Geom should come from the subdialog
                clsRgeom_Function.SetRCommand(strCategoricalGeomFunction)

                If Not ucrReceiverOneVarGraph.IsEmpty() Then
                    clsRaesFunction.AddParameter("x", ucrReceiverOneVarGraph.GetVariableNames(False))
                End If
            End If
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsBaseFunctionMultipleVariables)
            clsBaseFunctionMultipleVariables.AddParameter("data_name", Chr(34) & ucrSelectorOneVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
            clsBaseFunctionMultipleVariables.AddParameter("columns", ucrReceiverOneVarGraph.GetVariableNames())
        End If
    End Sub

    Private Sub ucrSelectorOneVarGraph_DataFrameChanged() Handles ucrSelectorOneVarGraph.DataFrameChanged
        OneOrMoreVariables()
    End Sub

    Private Sub ucrReceiverOneVarGraph_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverOneVarGraph.SelectionChanged
        OneOrMoreVariables()
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

    Private Sub rdoFacets_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFacets.CheckedChanged
        If rdoFacets.Checked Then
            clsBaseFunctionMultipleVariables.AddParameter("facets", "TRUE")
        Else
            clsBaseFunctionMultipleVariables.RemoveParameterByName("facets")
        End If
    End Sub
End Class