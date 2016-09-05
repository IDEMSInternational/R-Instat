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
    Public clsRggplotFunction As New RFunction
    Public clsRaesFunction As New RFunction
    Public clsRgeom_boxplotFunction As New RFunction
    Public clsRgeom_barFunction As New RFunction
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
        clsRaesFunction.ClearParameters()
        clsRggplotFunction.ClearParameters()
        ucrSelectorOneVarGraph.Reset()
        ucrSelectorOneVarGraph.Focus()
        ucrReceiverOneVarGraph.ResetText()
        ucrOneVarGraphSave.Reset()
        sdgOneVarGraph.SetDefaults()
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverOneVarGraph.Selector = ucrSelectorOneVarGraph
        ucrReceiverOneVarGraph.SetMeAsReceiver()
        OneOrMoreVariables()
        TestOkEnabled()
        'ucrBase.iHelpTopicID = 
        ucrOneVarGraphSave.strPrefix = "OneVariableGraph"
        ucrOneVarGraphSave.SetDataFrameSelector(ucrSelectorOneVarGraph.ucrAvailableDataFrames)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverOneVarGraph.IsEmpty() Or (ucrOneVarGraphSave.chkSaveGraph.Checked And ucrOneVarGraphSave.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub OneOrMoreVariables()
        If ucrReceiverOneVarGraph.GetVariablesAsList.Count = 1 Then
            ucrBase.clsRsyntax.SetOperation("+")
            clsRggplotFunction.SetRCommand("ggplot")
            clsRaesFunction.SetRCommand("aes")
            clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorOneVarGraph.ucrAvailableDataFrames.clsCurrDataFrame)
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
            ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
            'If Numeric Then
            SetParametersForOneVarNumeric()
            clsRgeom_boxplotFunction.SetRCommand("geom_boxplot")
            ucrBase.clsRsyntax.AddOperatorParameter(False, clsRFunc:=clsRgeom_boxplotFunction)
            'ElseIf Factor Then 
            'SetParametersForOneVarFactor()
            'clsRgeom_barFunction.SetRCommand("geom_bar")
            'ucrBase.clsRsyntax.AddOperatorParameter(False, clsRFunc:=clsRgeom_barFunction)
        ElseIf ucrReceiverOneVarGraph.GetVariableNamesAsList.Count > 1 Then
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$graph_one_variable")
            ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorOneVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
            ucrBase.clsRsyntax.AddParameter("columns", ucrReceiverOneVarGraph.GetVariableNames())
        End If
    End Sub

    Private Sub SetParametersForOneVarNumeric()
        If ucrReceiverOneVarGraph.GetVariablesAsList.Count = 1 Then 'This could just be when variable is numeric 
            clsRaesFunction.AddParameter("y", ucrReceiverOneVarGraph.GetVariableNames(False))
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
        Else
            clsRaesFunction.RemoveParameterByName("y")
            clsRaesFunction.RemoveParameterByName("x")
        End If
    End Sub

    Private Sub SetParametersForOneVarFactor()
        If ucrReceiverOneVarGraph.GetVariablesAsList.Count = 1 Then 'This could just be when variable is a factor
            clsRaesFunction.AddParameter("x", ucrReceiverOneVarGraph.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("x")
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
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorOneVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
        TestOkEnabled()
    End Sub

    Private Sub cmdGraph_Click(sender As Object, e As EventArgs) Handles cmdGraph.Click
        sdgOneVarGraph.ShowDialog()
    End Sub
End Class