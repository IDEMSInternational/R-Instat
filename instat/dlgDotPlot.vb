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
Public Class dlgDotPlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_dotplot As New RFunction
    Private clsRaesFunction As New RFunction
    Private bFirstLoad As Boolean = True

    Private Sub dlgDotPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRgeom_dotplot.SetRCommand("geom_dotplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrYVariableReceiver.Selector = ucrDotPlotSelector
        ucrFactorReceiver.Selector = ucrDotPlotSelector
        ucrSecondFactorReceiver.Selector = ucrDotPlotSelector
        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.OKEnabled(False)
        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If ucrYVariableReceiver.IsEmpty() = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        ucrDotPlotSelector.Reset()
        ucrYVariableReceiver.SetMeAsReceiver()
        TestOkEnabled()
    End Sub

    Private Sub ucrFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorReceiver.SelectionChanged
        If ucrFactorReceiver.IsEmpty() = False Then
            clsRaesFunction.AddParameter("x", ucrFactorReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.AddParameter("x", Chr(34) & "" & Chr(34))
        End If

    End Sub

    Private Sub ucrSecondFactorReceiver_SelectonChanged(sender As Object, e As EventArgs) Handles ucrSecondFactorReceiver.SelectionChanged
        If ucrSecondFactorReceiver.IsEmpty() = False Then
            clsRaesFunction.AddParameter("fill", ucrSecondFactorReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("fill")
        End If
    End Sub

    Private Sub ucrYVariableReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrYVariableReceiver.SelectionChanged

        If ucrYVariableReceiver.IsEmpty() = False Then
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_dotplot)
            clsRaesFunction.AddParameter("y", ucrYVariableReceiver.GetVariableNames(False))
            clsRgeom_dotplot.AddParameter("binaxis", Chr(34) & "y" & Chr(34))
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrDotPlotSelector_DataFrameChanged() Handles ucrDotPlotSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrDotPlotSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
End Class