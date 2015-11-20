
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
Public Class dlgWindrosePlot

    Private Sub dlgWindrosePlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$windrose")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub txtWindroseType_TextChanged(sender As Object, e As EventArgs) Handles txtWindroseType.TextChanged
        ucrBase.clsRsyntax.AddParameter("WR.type", Chr(34) & txtWindroseType.Text & Chr(34))
    End Sub

    Private Sub nudWindThreshold_ValueChanged(sender As Object, e As EventArgs) Handles nudWindThreshold.ValueChanged
        ucrBase.clsRsyntax.AddParameter("wind_threshold", nudWindThreshold.Value.ToString())
    End Sub
End Class