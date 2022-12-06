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

Public Class sdgSummaryThemes
    Private Sub sdgSummaryThemes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        Dim dctBackgroundColor As New Dictionary(Of String, String)
        Dim dctFontSize As New Dictionary(Of String, String)
        Dim dctAlignment As New Dictionary(Of String, String)
        Dim dctWeights As New Dictionary(Of String, String)
        Dim dctStyles As New Dictionary(Of String, String)

        ucrChkBackgroundColour.SetText("Background Colour")
        ucrInputBackgroundColour.SetParameter(New RParameter("heading.background.color"))
        dctBackgroundColor.Add("None", Chr(34) & "none" & Chr(34))
        dctBackgroundColor.Add("Left", Chr(34) & "left" & Chr(34))
        dctBackgroundColor.Add("Right", Chr(34) & "right" & Chr(34))
        dctBackgroundColor.Add("Top", Chr(34) & "top" & Chr(34))
        dctBackgroundColor.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputBackgroundColour.SetItems(dctBackgroundColor)
        ucrChkBackgroundColour.AddParameterPresentCondition(True, "heading.background.color")
        ucrChkBackgroundColour.AddParameterPresentCondition(False, "heading.background.color", False)

        ucrChkAlignment.SetText("Font Size")
        ucrInputAlignment.SetParameter(New RParameter("heading.align"))
        dctAlignment.Add("Left", Chr(34) & "left" & Chr(34))
        dctAlignment.Add("Right", Chr(34) & "right" & Chr(34))
        dctAlignment.Add("Center", Chr(34) & "center" & Chr(34))
        ucrInputAlignment.SetItems(dctAlignment)
        ucrChkAlignment.AddParameterPresentCondition(True, "heading.align")
        ucrChkAlignment.AddParameterPresentCondition(False, "heading.align", False)

        dctFontSize.Add("Small", Chr(34) & "small" & Chr(34))
        ucrChkFontSize.SetText("Font Size")
        ucrInputFontSize.SetParameter(New RParameter("title.font.size"))
        ucrInputFontSize.SetItems(dctFontSize)
        ucrChkFontSize.AddParameterPresentCondition(True, "title.font.size")
        ucrChkFontSize.AddParameterPresentCondition(False, "title.font.size", False)

        dctWeights.Add("Normal", Chr(34) & "normal" & Chr(34))
        dctWeights.Add("Bold", Chr(34) & "bold" & Chr(34))
        dctWeights.Add("Lighter", Chr(34) & "lighter" & Chr(34))
        dctWeights.Add("Bolder", Chr(34) & "bolder" & Chr(34))

        ucrChkFontWeight.SetText("Font Weights")
        ucrInputFontWeight.SetParameter(New RParameter("title.font.weight"))
        ucrInputFontWeight.SetItems(dctWeights)
        ucrChkFontWeight.AddParameterPresentCondition(True, "title.font.weight")
        ucrChkFontWeight.AddParameterPresentCondition(False, "title.font.weight", False)

    End Sub
End Class