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
        Dim dctColor As New Dictionary(Of String, String)
        Dim dctFontSize As New Dictionary(Of String, String)
        Dim dctAlignment As New Dictionary(Of String, String)
        Dim dctWeights As New Dictionary(Of String, String)
        Dim dctStyles As New Dictionary(Of String, String)
        Dim dctWidth As New Dictionary(Of String, String)

        ucrChkBackgroundColour.SetText("Background Colour")
        ucrInputBackgroundColour.SetParameter(New RParameter("heading.background.color"))
        ucrInputBackgroundColour.SetItems(dctColor)
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
        ucrInputFontSize.SetParameter(New RParameter("heading.title.font.size"))
        ucrInputFontSize.SetItems(dctFontSize)
        ucrChkFontSize.AddParameterPresentCondition(True, "heading.title.font.size")
        ucrChkFontSize.AddParameterPresentCondition(False, "heading.title.font.size", False)

        ucrChkFontSize.SetText("Font Size")
        ucrInputFontSize.SetParameter(New RParameter("heading.subtitle.font.size"))
        ucrInputFontSize.SetItems(dctFontSize)
        ucrChkFontSize.AddParameterPresentCondition(True, "heading.subtitle.font.size")
        ucrChkFontSize.AddParameterPresentCondition(False, "heading.subtitle.font.size", False)

        dctWeights.Add("Normal", Chr(34) & "normal" & Chr(34))
        dctWeights.Add("Bold", Chr(34) & "bold" & Chr(34))
        dctWeights.Add("Lighter", Chr(34) & "lighter" & Chr(34))
        dctWeights.Add("Bolder", Chr(34) & "bolder" & Chr(34))

        ucrChkFontWeight.SetText("Font Weights")
        ucrInputFontWeight.SetParameter(New RParameter("heading.title.font.weight"))
        ucrInputFontWeight.SetItems(dctWeights)
        ucrChkFontWeight.AddParameterPresentCondition(True, "heading.title.font.weightt")
        ucrChkFontWeight.AddParameterPresentCondition(False, "heading.title.font.weight", False)

        ucrChkFontWeight.SetText("Font Weights")
        ucrInputFontWeight.SetParameter(New RParameter("heading.subtitle.font.weight"))
        ucrInputFontWeight.SetItems(dctWeights)
        ucrChkFontWeight.AddParameterPresentCondition(True, "heading.subtitle.font.weightt")
        ucrChkFontWeight.AddParameterPresentCondition(False, "heading.subtitle.font.weight", False)

        ucrChkBoxWidth.SetText("Width of box")
        ucrNudBoxWidth.SetParameter(New RParameter("heading.padding"))
        ucrNudBoxWidth.Increment = 0.1
        ucrNudBoxWidth.Minimum = 30
        ucrChkBoxWidth.AddParameterPresentCondition(True, "heading.padding")
        ucrChkBoxWidth.AddParameterPresentCondition(False, "heading.padding", False)

        ucrChkBoxWidth.SetText("Length of box")
        ucrNudBoxWidth.SetParameter(New RParameter("heading.padding.horizontal"))
        ucrNudBoxWidth.Increment = 0.1
        ucrNudBoxWidth.Minimum = 30
        ucrChkBoxWidth.AddParameterPresentCondition(True, "heading.padding.horizontal")
        ucrChkBoxWidth.AddParameterPresentCondition(False, "heading.padding,horizontal", False)

        ucrChkBottomWidth.SetText("Width of bottom border")
        ucrNudBottomWidth.SetParameter(New RParameter("heading.border.bottom.width"))
        ucrNudBottomWidth.Increment = 0.1
        ucrNudBottomWidth.Minimum = 30
        ucrChkBottomWidth.AddParameterPresentCondition(True, "heading.border.bottom.width")
        ucrChkBottomWidth.AddParameterPresentCondition(False, "heading.border.bottom.width", False)

        ucrChkBottomStyle.SetText("Style of bottom border")
        ucrInputBottomStyle.SetParameter(New RParameter("heading.border.bottom.style"))
        ucrInputBottomStyle.SetItems(dctStyles)
        ucrChkBottomStyle.AddParameterPresentCondition(True, "heading.border.bottom.style")
        ucrChkBottomStyle.AddParameterPresentCondition(False, "heading.border.bottom.style", False)

        ucrChkBottomColour.SetText("Colour of bottom border")
        ucrInputBottomColour.SetParameter(New RParameter("heading.border.bottom.colour"))
        ucrInputBottomColour.SetItems(dctColor)
        ucrChkBottomColour.AddParameterPresentCondition(True, "heading.border.bottom.colour")
        ucrChkBottomColour.AddParameterPresentCondition(False, "heading.border.bottom.colour", False)

        ucrChkSideWidth.SetText("Width of side border")
        ucrNudSideWidth.SetParameter(New RParameter("heading.border.lr.width"))
        ucrNudSideWidth.Increment = 0.1
        ucrNudSideWidth.Minimum = 30
        ucrChkSideWidth.AddParameterPresentCondition(True, "heading.border.lr.width")
        ucrChkSideWidth.AddParameterPresentCondition(False, "heading.border.lr.width", False)

        ucrChkSideStyle.SetText("Style of side border")
        ucrInputSideStyle.SetParameter(New RParameter("heading.border.lr.style"))
        ucrInputSideStyle.SetItems(dctStyles)
        ucrChkSideStyle.AddParameterPresentCondition(True, "heading.border.lr.style")
        ucrChkSideStyle.AddParameterPresentCondition(False, "heading.border.lr.style", False)

        ucrChkSideColour.SetText("Colour of side border")
        ucrInputSideColour.SetParameter(New RParameter("heading.border.lr.colour"))
        ucrInputSideColour.SetItems(dctColor)
        ucrChkSideColour.AddParameterPresentCondition(True, "heading.border.lr.colour")
        ucrChkSideColour.AddParameterPresentCondition(False, "heading.border.lr.colour", False)

        ucrChkBackgroundColour.AddToLinkedControls(ucrInputBackgroundColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrChkAlignment.AddToLinkedControls(ucrInputAlignment, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Vertical")
        ucrChkFontSize.AddToLinkedControls(ucrInputFontSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Top")
        ucrChkFontWeight.AddToLinkedControls(ucrInputFontWeight, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Vertical")
        ucrChkSubTitleSize.AddToLinkedControls(ucrInputSubTitleSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Top")

    End Sub

    Private Sub UcrCheck21_Load(sender As Object, e As EventArgs) Handles ucrChkTableLeftStyle.Load

    End Sub
End Class