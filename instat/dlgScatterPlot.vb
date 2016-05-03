
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
Public Class dlgScatterPlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_scatterplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private bFirstLoad As Boolean = True

    Private Sub dlgScatterPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            'setdefauts
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
        TestOkEnabled()

    End Sub

    Private Sub ucrSelectorForScatter_DataFrameChanged() Handles ucrSelectorForScatter.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorForScatter.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrReceiverX_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverX.SelectionChanged

        If Not ucrReceiverX.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrFactorOptionalReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorOptionalReceiver.SelectionChanged
        If Not ucrFactorOptionalReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("color", ucrFactorOptionalReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("color")
        End If
    End Sub

    Private Sub TestOkEnabled()
        'tests when okay Is enable
        If ucrReceiverX.IsEmpty() = True Or ucrVariablesAsFactorForScatter.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)

        clsRgeom_scatterplotFunction.SetRCommand("geom_point")
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_scatterplotFunction)

        ucrReceiverX.Selector = ucrSelectorForScatter
        ucrReceiverX.SetIncludedDataTypes({"numeric"})
        ucrFactorOptionalReceiver.Selector = ucrSelectorForScatter
        ucrFactorOptionalReceiver.SetIncludedDataTypes({"factor"})

        ucrVariablesAsFactorForScatter.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForScatter.SetSelector(ucrSelectorForScatter)
        ucrVariablesAsFactorForScatter.SetExcludedDataTypes({"numeric"})
        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)

    End Sub
    Private Sub SetDefaults()
        'setDefaults
        ucrSelectorForScatter.Reset()
        ucrSelectorForScatter.Focus()
        ucrVariablesAsFactorForScatter.ResetControl()
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.ShowDialog()
    End Sub
    Private Sub ucrVariablesAsFactor_SelectionChanged() Handles ucrVariablesAsFactorForScatter.SelectionChanged
        If Not ucrVariablesAsFactorForScatter.IsEmpty Then
            clsRaesFunction.AddParameter("y", ucrVariablesAsFactorForScatter.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("y")
        End If
        TestOkEnabled()
    End Sub

    Private Sub cmdScatterPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdScatterPlotOptions.Click
        sdgScatterPlot.ShowDialog()
    End Sub
End Class