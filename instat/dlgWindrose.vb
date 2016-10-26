
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
Public Class dlgWindrose
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_barFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private Sub dlgWindrose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 452
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRgeom_barFunction.SetRCommand("geom_bar")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_barFunction)
        clsRgeom_barFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34))
        clsRgeom_barFunction.AddParameter("width", "1")

        ucrXReceiver.Selector = ucrWindRoseSelector
        ucrYReceiver.Selector = ucrWindRoseSelector
        ucrFillReceiver.Selector = ucrWindRoseSelector
        ucrXReceiver.SetMeAsReceiver()
    End Sub

    Private Sub SetDefaults()
        ucrWindRoseSelector.Reset()
        ucrXReceiver.SetMeAsReceiver()
        TestOkEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub
    Private Sub TestOkEnabled()
        If Not ucrXReceiver.IsEmpty And Not ucrYReceiver.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
    Private Sub ucrXReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrXReceiver.SelectionChanged
        'this takes in Wind speed 
        If Not ucrXReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrXReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrYReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrYReceiver.SelectionChanged
        'this takes in wind direction
        If Not ucrYReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("y", ucrYReceiver.GetVariableNames(False))

        Else
            clsRaesFunction.RemoveParameterByName("y")
        End If

        TestOkEnabled()
    End Sub

    Private Sub ucrFillReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFillReceiver.SelectionChanged
        If Not ucrFillReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("fill", ucrFillReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("fill")
        End If
    End Sub

    Private Sub ucrWindRoseSelector_DataFrameChanged() Handles ucrWindRoseSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrWindRoseSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub
End Class