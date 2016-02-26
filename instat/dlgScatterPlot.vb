
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
    Private bFirstLoad As Boolean = True
    Private Sub ucrPlotSelector_Load(sender As Object, e As EventArgs) Handles ucrScatterPlotSelector.Load
        ucrReceiverX.Selector = ucrScatterPlotSelector
        ucrReceiverY.Selector = ucrScatterPlotSelector
        ucrFactorOptionalReceiver.Selector = ucrScatterPlotSelector
        autoTranslate(Me)

        If bFirstLoad Then
            'setdefauts
            bFirstLoad = False
            SetDefaults()

        End If
    End Sub
    Private Sub ucrScatterPlotSelector_DataFrameChanged() Handles ucrScatterPlotSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrScatterPlotSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub
    Private Sub TestOkEnabled()
        'tests when okay is enable
    End Sub
    Private Sub SetDefaults()
        'setDefaults
        ucrScatterPlotSelector.Reset()
        ucrReceiverY.SetMeAsReceiver()
    End Sub
End Class