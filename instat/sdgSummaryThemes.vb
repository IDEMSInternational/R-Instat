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

        dctAlignment.Add("Left", Chr(34) & "left" & Chr(34))
        dctAlignment.Add("Right", Chr(34) & "right" & Chr(34))
        dctAlignment.Add("Center", Chr(34) & "center" & Chr(34))

        ucrChkAlignment.SetText("Font Size")
        ucrInputAlignment.SetParameter(New RParameter("heading.align"))
        ucrInputAlignment.SetItems(dctAlignment)
        ucrChkAlignment.AddParameterPresentCondition(True, "heading.align")
        ucrChkAlignment.AddParameterPresentCondition(False, "heading.align", False)

        dctFontSize.Add("Small", Chr(34) & "small" & Chr(34))
        ucrChkFontSize.SetText("Font Size")
        ucrInputFontSize.SetParameter(New RParameter("heading.title.font.size"))
        ucrInputFontSize.SetItems(dctFontSize)
        ucrChkFontSize.AddParameterPresentCondition(True, "heading.title.font.size")
        ucrChkFontSize.AddParameterPresentCondition(False, "heading.title.font.size", False)

        ucrChkSubTitleSize.SetText("Font Size")
        ucrInputSubTitleSize.SetParameter(New RParameter("heading.subtitle.font.size"))
        ucrInputSubTitleSize.SetItems(dctFontSize)
        ucrChkSubTitleSize.AddParameterPresentCondition(True, "heading.subtitle.font.size")
        ucrChkSubTitleSize.AddParameterPresentCondition(False, "heading.subtitle.font.size", False)

        dctWeights.Add("Normal", Chr(34) & "normal" & Chr(34))
        dctWeights.Add("Bold", Chr(34) & "bold" & Chr(34))
        dctWeights.Add("Lighter", Chr(34) & "lighter" & Chr(34))
        dctWeights.Add("Bolder", Chr(34) & "bolder" & Chr(34))

        ucrChkFontWeight.SetText("Font Weights")
        ucrInputFontWeight.SetParameter(New RParameter("heading.title.font.weight"))
        ucrInputFontWeight.SetItems(dctWeights)
        ucrChkFontWeight.AddParameterPresentCondition(True, "heading.title.font.weight")
        ucrChkFontWeight.AddParameterPresentCondition(False, "heading.title.font.weight", False)

        ucrChkSubTitleWeight.SetText("Font Weights")
        ucrInputSubTitleWeight.SetParameter(New RParameter("heading.subtitle.font.weight"))
        ucrInputSubTitleWeight.SetItems(dctWeights)
        ucrChkSubTitleWeight.AddParameterPresentCondition(True, "heading.subtitle.font.weight")
        ucrChkSubTitleWeight.AddParameterPresentCondition(False, "heading.subtitle.font.weight", False)

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
        ucrChkSubTitleWeight.AddToLinkedControls(ucrInputSubTitleWeight, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Normal")
        ucrChkBoxWidth.AddToLinkedControls(ucrNudBoxWidth, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBoxLength.AddToLinkedControls(ucrNudBoxLength, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBottomWidth.AddToLinkedControls(ucrNudBottomWidth, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBottomStyle.AddToLinkedControls(ucrInputBottomStyle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBottomColour.AddToLinkedControls(ucrInputBottomColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSideWidth.AddToLinkedControls(ucrNudSideWidth, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSideStyle.AddToLinkedControls(ucrInputSideStyle, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrChkSideColour.AddToLinkedControls(ucrInputSideColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkTableWidth.SetText("Width")
        ucrInputTableFontWeight.SetParameter(New RParameter("table.width"))
        ucrChkTableWidth.AddParameterPresentCondition(True, "table.width")
        ucrChkTableWidth.AddParameterPresentCondition(False, "table.width", False)

        ucrChkTableLayout.SetText("Layout")
        ucrInputTableLayout.SetParameter(New RParameter("table.layout"))
        ucrChkTableLayout.AddParameterPresentCondition(True, "table.layout")
        ucrChkTableLayout.AddParameterPresentCondition(False, "table.layout", False)

        ucrChkTableAlign.SetText("Alignment")
        ucrInputTableAlign.SetParameter(New RParameter("table.align"))
        ucrInputTableAlign.SetItems(dctAlignment)
        ucrChkTableAlign.AddParameterPresentCondition(True, "table.align")
        ucrChkTableAlign.AddParameterPresentCondition(False, "table.align", False)

        ucrChkTableBackColor.SetText("Background color")
        ucrInputTableBackColor.SetParameter(New RParameter("table.background.color"))
        ucrChkTableBackColor.AddParameterPresentCondition(True, "table.background.color")
        ucrChkTableBackColor.AddParameterPresentCondition(False, "table.background.color", False)

        ucrChkTableFontNames.SetText("Font names")
        ucrInputTableFontNames.SetParameter(New RParameter("table.font.names"))
        ucrChkTableFontNames.AddParameterPresentCondition(True, "table.font.names")
        ucrChkTableFontNames.AddParameterPresentCondition(False, "table.font.names", False)

        ucrChkTableFontSize.SetText("Font size")
        ucrInputTableFontSize.SetParameter(New RParameter("table.font.size"))
        ucrChkTableFontSize.AddParameterPresentCondition(True, "table.font.size")
        ucrChkTableFontSize.AddParameterPresentCondition(False, "table.font.size", False)

        ucrChkTableFontWeight.SetText("Font weight")
        ucrInputTableFontWeight.SetParameter(New RParameter("table.font.weight"))
        ucrInputTableFontWeight.SetItems(dctWeights)
        ucrChkTableFontWeight.AddParameterPresentCondition(True, "table.font.weight")
        ucrChkTableFontWeight.AddParameterPresentCondition(False, "table.font.weight", False)

        ucrChkTableFontStyle.SetText("Font style")
        ucrInputTableFontStyle.SetParameter(New RParameter("table.font.style"))
        ucrInputTableFontStyle.SetItems(dctStyles)
        ucrChkTableFontStyle.AddParameterPresentCondition(True, "table.font.style")
        ucrChkTableFontStyle.AddParameterPresentCondition(False, "table.font.style", False)

        ucrChkTableFontColor.SetText("Font color")
        ucrInputTableFontColor.SetParameter(New RParameter("table.font.color"))
        ucrChkTableFontColor.AddParameterPresentCondition(True, "table.font.color")
        ucrChkTableFontColor.AddParameterPresentCondition(False, "table.font.color", False)

        ucrChkTableTopStyle.SetText("Top border style")
        ucrInputTableTopStyle.SetParameter(New RParameter("table.border.top.style"))
        ucrInputTableTopStyle.SetItems(dctStyles)
        ucrChkTableTopStyle.AddParameterPresentCondition(True, "table.border.top.style")
        ucrChkTableTopStyle.AddParameterPresentCondition(False, "table.border.top.style", False)

        ucrChkTableTopWidth.SetText("Top border Width")
        ucrInputTableTopWidth.SetParameter(New RParameter("table.border.top.width"))
        ucrChkTableTopWidth.AddParameterPresentCondition(True, "table.border.top.width")
        ucrChkTableTopWidth.AddParameterPresentCondition(False, "table.border.top.width", False)

        ucrChkTableTopColor.SetText("Top border color")
        ucrInputTableTopColor.SetParameter(New RParameter("table.border.top.color"))
        ucrChkTableTopColor.AddParameterPresentCondition(True, "table.border.top.color")
        ucrChkTableTopColor.AddParameterPresentCondition(False, "table.border.top.color", False)

        ucrChkTableRightStyle.SetText("Right border style")
        ucrInputTableRightStyle.SetParameter(New RParameter("table.border.right.style"))
        ucrInputTableRightStyle.SetItems(dctStyles)
        ucrChkTableRightStyle.AddParameterPresentCondition(True, "table.border.right.style")
        ucrChkTableRightStyle.AddParameterPresentCondition(False, "table.border.right.style", False)

        ucrChkTableRightWidth.SetText("Right border Width")
        ucrInputTableRightWidth.SetParameter(New RParameter("table.border.right.width"))
        ucrChkTableRightWidth.AddParameterPresentCondition(True, "table.border.right.width")
        ucrChkTableRightWidth.AddParameterPresentCondition(False, "table.border.right.width", False)

        ucrChkTableRightColor.SetText("Right border color")
        ucrInputTableRightColor.SetParameter(New RParameter("table.border.right.color"))
        ucrChkTableRightColor.AddParameterPresentCondition(True, "table.border.right.color")
        ucrChkTableRightColor.AddParameterPresentCondition(False, "table.border.right.color", False)

        ucrChkTableBottomStyle.SetText("Bottom border style")
        ucrInputTableBottomStyle.SetParameter(New RParameter("table.border.bottom.style"))
        ucrInputTableBottomStyle.SetItems(dctStyles)
        ucrChkTableBottomStyle.AddParameterPresentCondition(True, "table.border.bottom.style")
        ucrChkTableBottomStyle.AddParameterPresentCondition(False, "table.border.bottom.style", False)

        ucrChkTableBottomWidth.SetText("Bottom border Width")
        ucrInputTableBottomWidth.SetParameter(New RParameter("table.border.bottom.width"))
        ucrChkTableBottomWidth.AddParameterPresentCondition(True, "table.border.bottom.width")
        ucrChkTableBottomWidth.AddParameterPresentCondition(False, "table.border.bottom.width", False)

        ucrChkTableBottomColor.SetText("Bottom border color")
        ucrInputTableBottomColor.SetParameter(New RParameter("table.border.bottom.color"))
        ucrChkTableBottomColor.AddParameterPresentCondition(True, "table.border.bottom.color")
        ucrChkTableBottomColor.AddParameterPresentCondition(False, "table.border.bottom.color", False)

        ucrChkTableLeftStyle.SetText("Left border style")
        ucrInputTableLeftStyle.SetParameter(New RParameter("table.border.left.style"))
        ucrInputTableLeftStyle.SetItems(dctStyles)
        ucrChkTableLeftStyle.AddParameterPresentCondition(True, "table.border.left.style")
        ucrChkTableLeftStyle.AddParameterPresentCondition(False, "table.border.left.style", False)

        ucrChkTableLeftWidth.SetText("Left border Width")
        ucrInputTableLeftWidth.SetParameter(New RParameter("table.border.left.width"))
        ucrChkTableLeftWidth.AddParameterPresentCondition(True, "table.border.left.width")
        ucrChkTableLeftWidth.AddParameterPresentCondition(False, "table.border.left.width", False)

        ucrChkTableLeftColor.SetText("Left border color")
        ucrInputTableLeftColor.SetParameter(New RParameter("table.border.left.color"))
        ucrChkTableLeftColor.AddParameterPresentCondition(True, "table.border.left.color")
        ucrChkTableLeftColor.AddParameterPresentCondition(False, "table.border.left.color", False)

        ucrChkTableWidth.AddToLinkedControls(ucrInputTableWidth, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableLayout.AddToLinkedControls(ucrInputTableLayout, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableAlign.AddToLinkedControls(ucrInputTableAlign, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableBackColor.AddToLinkedControls(ucrInputTableBackColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableFontNames.AddToLinkedControls(ucrInputTableFontNames, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

    End Sub

End Class