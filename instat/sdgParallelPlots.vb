' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class sdgParallelPlots
    Public bControlsInitialised As Boolean = False
    Public clsggparcoordFunc As New RFunction
    Private Sub sdgParallelPlots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        Dim dctMissing As New Dictionary(Of String, String)
        Dim dctOrder As New Dictionary(Of String, String)

        ucrInputMissing.SetParameter(New RParameter("missing", 6))
        dctMissing.Add("Exclude", Chr(34) & "exclude" & Chr(34))
        dctMissing.Add("Mean", Chr(34) & "mean" & Chr(34))
        dctMissing.Add("Median", Chr(34) & "median" & Chr(34))
        dctMissing.Add("Min10", Chr(34) & "min10" & Chr(34))
        dctMissing.Add("Random", Chr(34) & "random" & Chr(34))
        ucrInputMissing.SetItems(dctMissing)
        ucrInputMissing.SetRDefault("exclude")
        ucrInputMissing.SetDropDownStyleAsNonEditable()

        ucrInputOrder.SetParameter(New RParameter("order", 7))
        dctOrder.Add("Any Class", Chr(34) & "anyClass" & Chr(34))
        dctOrder.Add("All Class", Chr(34) & "allClass" & Chr(34))
        dctOrder.Add("Skewness", Chr(34) & "skewness" & Chr(34))
        'this parameter is commented out because it uses scagnostics packeage which has not been added
        'dctOrder.Add("Outlying", Chr(34) & "Outlying" & Chr(34))
        ucrInputOrder.SetItems(dctOrder)
        ucrInputOrder.SetDropDownStyleAsNonEditable()
    End Sub

    Public Sub SetRCode(clsNewRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsggparcoordFunc = clsNewRFunction
        mdlCoreControl.SetRCode(Me, clsggparcoordFunc, bReset)
    End Sub
End Class