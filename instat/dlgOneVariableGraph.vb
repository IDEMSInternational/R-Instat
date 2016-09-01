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
    Private clsRgeom_boxplotFunction As New RFunction
    Private clsRgeom_barFunction As New RFunction
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
    End Sub

    Private Sub SetDefaults()
        clsRaesFunction.ClearParameters()
        'clear parameters for the other variables 
        ucrSelectorOneVarGraph.Reset()
        ucrSelectorOneVarGraph.Focus()
        ucrReceiverOneVarGraph.ResetText()
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        clsRgeom_barFunction.SetRCommand("geom_bar")
        ucrReceiverOneVarGraph.Selector = ucrSelectorOneVarGraph
        ucrReceiverOneVarGraph.SetMeAsReceiver()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Public Sub TestOkEnabled()
        If Not ucrReceiverOneVarGraph.IsEmpty() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub OneOrMoreVariables()
        If ucrReceiverOneVarGraph.GetVariablesAsList.Count = 1 Then
            clsRaesFunction.AddParameter("y", ucrReceiverOneVarGraph.GetVariableNames(False))
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
            clsRgeom_boxplotFunction.SetRCommand("geom_boxplot")
            ucrBase.clsRsyntax.AddOperatorParameter(False, clsRFunc:=clsRgeom_boxplotFunction)
        End If
    End Sub
End Class