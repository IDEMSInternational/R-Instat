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
    Private clsThemesTabOptionsFunction As New RFunction
    Private bRCodeSet As Boolean = False
    Private bControlsInitialised As Boolean = False

    Private Sub sdgSummaryThemes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        Dim dctAlignment, dctWeights, dctStyles, dctBorderStyles, dctTextTransform As New Dictionary(Of String, String)

        dctWeights.Add("NULL", Chr(34) & "NULL" & Chr(34))
        dctWeights.Add("Normal", Chr(34) & "normal" & Chr(34))
        dctWeights.Add("Bold", Chr(34) & "bold" & Chr(34))
        dctWeights.Add("Lighter", Chr(34) & "lighter" & Chr(34))
        dctWeights.Add("Bolder", Chr(34) & "bolder" & Chr(34))

        dctAlignment.Add("NULL", Chr(34) & "NULL" & Chr(34))
        dctAlignment.Add("Left", Chr(34) & "left" & Chr(34))
        dctAlignment.Add("Right", Chr(34) & "right" & Chr(34))
        dctAlignment.Add("Center", Chr(34) & "center" & Chr(34))

        dctStyles.Add("NULL", Chr(34) & "NULL" & Chr(34))
        dctStyles.Add("Normal", Chr(34) & "normal" & Chr(34))
        dctStyles.Add("Italic", Chr(34) & "italic" & Chr(34))
        dctStyles.Add("Oblique", Chr(34) & "oblique" & Chr(34))

        dctBorderStyles.Add("NULL", Chr(34) & "NULL" & Chr(34))
        dctBorderStyles.Add("Solid", Chr(34) & "solid" & Chr(34))
        dctBorderStyles.Add("Dashed", Chr(34) & "dashed" & Chr(34))
        dctBorderStyles.Add("Dotted", Chr(34) & "dotted" & Chr(34))

        ucrChkBackgroundColour.SetText("Background Colour")
        ucrInputBackgroundColour.SetParameter(New RParameter("heading.background.color", iNewPosition:=0))
        ucrInputBackgroundColour.SetRDefault(Chr(34) & "NULL" & Chr(34))
        ucrChkBackgroundColour.AddParameterPresentCondition(True, "heading.background.color")
        ucrChkBackgroundColour.AddParameterPresentCondition(False, "heading.background.color", False)

        ucrChkAlignment.SetText("Alignment")
        ucrInputAlignment.SetParameter(New RParameter("heading.align", iNewPosition:=1))
        ucrInputAlignment.SetItems(dctAlignment)
        ucrChkAlignment.AddParameterPresentCondition(True, "heading.align")
        ucrChkAlignment.AddParameterPresentCondition(False, "heading.align", False)

        ucrChkFontSize.SetText("Font Size")
        ucrNudFontSize.SetParameter(New RParameter("heading.title.font.size", iNewPosition:=2))
        ucrNudFontSize.SetRDefault(0)
        ucrChkFontSize.AddParameterPresentCondition(True, "heading.title.font.size")
        ucrChkFontSize.AddParameterPresentCondition(False, "heading.title.font.size", False)

        ucrChkSubTitleSize.SetText("Font Size")
        ucrNudSubTitleSize.SetParameter(New RParameter("heading.subtitle.font.size", iNewPosition:=3))
        ucrNudSubTitleSize.SetRDefault(0)
        ucrChkSubTitleSize.AddParameterPresentCondition(True, "heading.subtitle.font.size")
        ucrChkSubTitleSize.AddParameterPresentCondition(False, "heading.subtitle.font.size", False)

        ucrChkFontWeight.SetText("Font Weights")
        ucrInputFontWeight.SetParameter(New RParameter("heading.title.font.weight", iNewPosition:=4))
        ucrInputFontWeight.SetItems(dctWeights)
        ucrChkFontWeight.AddParameterPresentCondition(True, "heading.title.font.weight")
        ucrChkFontWeight.AddParameterPresentCondition(False, "heading.title.font.weight", False)

        ucrChkSubTitleWeight.SetText("Font Weights")
        ucrInputSubTitleWeight.SetParameter(New RParameter("heading.subtitle.font.weight", iNewPosition:=5))
        ucrInputSubTitleWeight.SetItems(dctWeights)
        ucrChkSubTitleWeight.AddParameterPresentCondition(True, "heading.subtitle.font.weight")
        ucrChkSubTitleWeight.AddParameterPresentCondition(False, "heading.subtitle.font.weight", False)

        ucrChkBoxWidth.SetText("Width of box")
        ucrNudBoxWidth.SetParameter(New RParameter("heading.padding", iNewPosition:=6))
        ucrNudBoxWidth.SetRDefault(0)
        ucrChkBoxWidth.AddParameterPresentCondition(True, "heading.padding")
        ucrChkBoxWidth.AddParameterPresentCondition(False, "heading.padding", False)

        ucrChkBoxWidth.SetText("Length of box")
        ucrNudBoxWidth.SetParameter(New RParameter("heading.padding.horizontal", iNewPosition:=7))
        ucrNudBoxWidth.SetRDefault(0)
        ucrChkBoxWidth.AddParameterPresentCondition(True, "heading.padding.horizontal")
        ucrChkBoxWidth.AddParameterPresentCondition(False, "heading.padding,horizontal", False)

        ucrChkBottomWidth.SetText("Width of bottom border")
        ucrNudBottomWidth.SetParameter(New RParameter("heading.border.bottom.width", iNewPosition:=8))
        ucrNudBottomWidth.SetRDefault(0)
        ucrChkBottomWidth.AddParameterPresentCondition(True, "heading.border.bottom.width")
        ucrChkBottomWidth.AddParameterPresentCondition(False, "heading.border.bottom.width", False)

        ucrChkBottomStyle.SetText("Style of bottom border")
        ucrInputBottomStyle.SetParameter(New RParameter("heading.border.bottom.style", iNewPosition:=9))
        ucrInputBottomStyle.SetItems(dctBorderStyles)
        ucrChkBottomStyle.AddParameterPresentCondition(True, "heading.border.bottom.style")
        ucrChkBottomStyle.AddParameterPresentCondition(False, "heading.border.bottom.style", False)

        ucrChkBottomColour.SetText("Colour of bottom border")
        ucrInputBottomColour.SetParameter(New RParameter("heading.border.bottom.color", iNewPosition:=10))
        ucrInputBottomColour.SetRDefault(Chr(34) & "NULL" & Chr(34))
        ucrChkBottomColour.AddParameterPresentCondition(True, "heading.border.bottom.color")
        ucrChkBottomColour.AddParameterPresentCondition(False, "heading.border.bottom.color", False)

        ucrChkSideWidth.SetText("Width of side border")
        ucrNudSideWidth.SetParameter(New RParameter("heading.border.lr.width", iNewPosition:=11))
        ucrNudSideWidth.SetRDefault(0)
        ucrChkSideWidth.AddParameterPresentCondition(True, "heading.border.lr.width")
        ucrChkSideWidth.AddParameterPresentCondition(False, "heading.border.lr.width", False)

        ucrChkSideStyle.SetText("Style of side border")
        ucrInputSideStyle.SetParameter(New RParameter("heading.border.lr.style", iNewPosition:=12))
        ucrInputSideStyle.SetItems(dctBorderStyles)
        ucrChkSideStyle.AddParameterPresentCondition(True, "heading.border.lr.style")
        ucrChkSideStyle.AddParameterPresentCondition(False, "heading.border.lr.style", False)

        ucrChkSideColour.SetText("Colour of side border")
        ucrInputSideColour.SetParameter(New RParameter("heading.border.lr.colour", iNewPosition:=13))
        ucrInputSideColour.SetRDefault(Chr(34) & "NULL" & Chr(34))
        ucrChkSideColour.AddParameterPresentCondition(True, "heading.border.lr.colour")
        ucrChkSideColour.AddParameterPresentCondition(False, "heading.border.lr.colour", False)

        ucrChkBackgroundColour.AddToLinkedControls(ucrInputBackgroundColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrChkAlignment.AddToLinkedControls(ucrInputAlignment, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Vertical")
        ucrChkFontSize.AddToLinkedControls(ucrNudFontSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Top")
        ucrChkFontWeight.AddToLinkedControls(ucrInputFontWeight, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Vertical")
        ucrChkSubTitleSize.AddToLinkedControls(ucrNudSubTitleSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Top")
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
        ucrInputTableFontWeight.SetParameter(New RParameter("table.width", iNewPosition:=14))
        ucrChkTableWidth.AddParameterPresentCondition(True, "table.width")
        ucrChkTableWidth.AddParameterPresentCondition(False, "table.width", False)

        ucrChkTableLayout.SetText("Layout")
        ucrInputTableLayout.SetParameter(New RParameter("table.layout", iNewPosition:=15))
        ucrChkTableLayout.AddParameterPresentCondition(True, "table.layout")
        ucrChkTableLayout.AddParameterPresentCondition(False, "table.layout", False)

        ucrChkTableAlign.SetText("Alignment")
        ucrInputTableAlign.SetParameter(New RParameter("table.align", iNewPosition:=16))
        ucrInputTableAlign.SetItems(dctAlignment)
        ucrChkTableAlign.AddParameterPresentCondition(True, "table.align")
        ucrChkTableAlign.AddParameterPresentCondition(False, "table.align", False)

        ucrChkTableBackColor.SetText("Background color")
        ucrInputTableBackColor.SetParameter(New RParameter("table.background.color", iNewPosition:=17))
        ucrInputTableBackColor.SetRDefault(Chr(34) & "NULL" & Chr(34))
        ucrChkTableBackColor.AddParameterPresentCondition(True, "table.background.color")
        ucrChkTableBackColor.AddParameterPresentCondition(False, "table.background.color", False)

        ucrChkTableFontNames.SetText("Font names")
        ucrInputTableFontNames.SetParameter(New RParameter("table.font.names", iNewPosition:=18))
        ucrChkTableFontNames.AddParameterPresentCondition(True, "table.font.names")
        ucrChkTableFontNames.AddParameterPresentCondition(False, "table.font.names", False)

        ucrChkTableFontSize.SetText("Font size")
        ucrNudTableFontSize.SetParameter(New RParameter("table.font.size", iNewPosition:=19))
        ucrNudTableFontSize.SetRDefault(0)
        ucrChkTableFontSize.AddParameterPresentCondition(True, "table.font.size")
        ucrChkTableFontSize.AddParameterPresentCondition(False, "table.font.size", False)

        ucrChkTableFontWeight.SetText("Font weight")
        ucrInputTableFontWeight.SetParameter(New RParameter("table.font.weight", iNewPosition:=20))
        ucrInputTableFontWeight.SetItems(dctWeights)
        ucrChkTableFontWeight.AddParameterPresentCondition(True, "table.font.weight")
        ucrChkTableFontWeight.AddParameterPresentCondition(False, "table.font.weight", False)

        ucrChkTableFontStyle.SetText("Font style")
        ucrInputTableFontStyle.SetParameter(New RParameter("table.font.style", iNewPosition:=21))
        ucrInputTableFontStyle.SetItems(dctStyles)
        ucrChkTableFontStyle.AddParameterPresentCondition(True, "table.font.style")
        ucrChkTableFontStyle.AddParameterPresentCondition(False, "table.font.style", False)

        ucrChkTableFontColor.SetText("Font color")
        ucrInputTableFontColor.SetParameter(New RParameter("table.font.color", iNewPosition:=22))
        ucrInputTableFontColor.SetRDefault(Chr(34) & "NULL" & Chr(34))
        ucrChkTableFontColor.AddParameterPresentCondition(True, "table.font.color")
        ucrChkTableFontColor.AddParameterPresentCondition(False, "table.font.color", False)

        ucrChkTableTopStyle.SetText("Top border style")
        ucrInputTableTopStyle.SetParameter(New RParameter("table.border.top.style", iNewPosition:=23))
        ucrInputTableTopStyle.SetItems(dctBorderStyles)
        ucrChkTableTopStyle.AddParameterPresentCondition(True, "table.border.top.style")
        ucrChkTableTopStyle.AddParameterPresentCondition(False, "table.border.top.style", False)

        ucrChkTableTopWidth.SetText("Top border Width")
        ucrNudTableTopWidth.SetParameter(New RParameter("table.border.top.width", iNewPosition:=24))
        ucrNudTableTopWidth.SetRDefault(0)
        ucrChkTableTopWidth.AddParameterPresentCondition(True, "table.border.top.width")
        ucrChkTableTopWidth.AddParameterPresentCondition(False, "table.border.top.width", False)

        ucrChkTableTopColor.SetText("Top border color")
        ucrInputTableTopColor.SetParameter(New RParameter("table.border.top.color", iNewPosition:=25))
        ucrInputTableTopColor.SetRDefault(Chr(34) & "NULL" & Chr(34))
        ucrChkTableTopColor.AddParameterPresentCondition(True, "table.border.top.color")
        ucrChkTableTopColor.AddParameterPresentCondition(False, "table.border.top.color", False)

        ucrChkTableRightStyle.SetText("Right border style")
        ucrInputTableRightStyle.SetParameter(New RParameter("table.border.right.style", iNewPosition:=26))
        ucrInputTableRightStyle.SetItems(dctBorderStyles)
        ucrChkTableRightStyle.AddParameterPresentCondition(True, "table.border.right.style")
        ucrChkTableRightStyle.AddParameterPresentCondition(False, "table.border.right.style", False)

        ucrChkTableRightWidth.SetText("Right border Width")
        ucrNudTableRightWidth.SetParameter(New RParameter("table.border.right.width", iNewPosition:=27))
        ucrNudTableRightWidth.SetRDefault(0)
        ucrChkTableRightWidth.AddParameterPresentCondition(True, "table.border.right.width")
        ucrChkTableRightWidth.AddParameterPresentCondition(False, "table.border.right.width", False)

        ucrChkTableRightColor.SetText("Right border color")
        ucrInputTableRightColor.SetParameter(New RParameter("table.border.right.color", iNewPosition:=28))
        ucrInputTableRightColor.SetRDefault(Chr(34) & "NULL" & Chr(34))
        ucrChkTableRightColor.AddParameterPresentCondition(True, "table.border.right.color")
        ucrChkTableRightColor.AddParameterPresentCondition(False, "table.border.right.color", False)

        ucrChkTableBottomStyle.SetText("Bottom border style")
        ucrInputTableBottomStyle.SetParameter(New RParameter("table.border.bottom.style", iNewPosition:=29))
        ucrInputTableBottomStyle.SetItems(dctBorderStyles)
        ucrChkTableBottomStyle.AddParameterPresentCondition(True, "table.border.bottom.style")
        ucrChkTableBottomStyle.AddParameterPresentCondition(False, "table.border.bottom.style", False)

        ucrChkTableBottomWidth.SetText("Bottom border Width")
        ucrNudTableBottomWidth.SetParameter(New RParameter("table.border.bottom.width", iNewPosition:=30))
        ucrNudTableBottomWidth.SetRDefault(0)
        ucrChkTableBottomWidth.AddParameterPresentCondition(True, "table.border.bottom.width")
        ucrChkTableBottomWidth.AddParameterPresentCondition(False, "table.border.bottom.width", False)

        ucrChkTableBottomColor.SetText("Bottom border color")
        ucrInputTableBottomColor.SetParameter(New RParameter("table.border.bottom.color", iNewPosition:=31))
        ucrInputTableBottomColor.SetRDefault(Chr(34) & "NULL" & Chr(34))
        ucrChkTableBottomColor.AddParameterPresentCondition(True, "table.border.bottom.color")
        ucrChkTableBottomColor.AddParameterPresentCondition(False, "table.border.bottom.color", False)

        ucrChkTableLeftStyle.SetText("Left border style")
        ucrInputTableLeftStyle.SetParameter(New RParameter("table.border.left.style", iNewPosition:=32))
        ucrInputTableLeftStyle.SetItems(dctBorderStyles)
        ucrChkTableLeftStyle.AddParameterPresentCondition(True, "table.border.left.style")
        ucrChkTableLeftStyle.AddParameterPresentCondition(False, "table.border.left.style", False)

        ucrChkTableLeftWidth.SetText("Left border Width")
        ucrNudTableLeftWidth.SetParameter(New RParameter("table.border.left.width", iNewPosition:=33))
        ucrNudTableLeftWidth.SetRDefault(0)
        ucrChkTableLeftWidth.AddParameterPresentCondition(True, "table.border.left.width")
        ucrChkTableLeftWidth.AddParameterPresentCondition(False, "table.border.left.width", False)

        ucrChkTableLeftColor.SetText("Left border color")
        ucrInputTableLeftColor.SetParameter(New RParameter("table.border.left.color", iNewPosition:=34))
        ucrChkTableLeftColor.AddParameterPresentCondition(True, "table.border.left.color")
        ucrChkTableLeftColor.AddParameterPresentCondition(False, "table.border.left.color", False)

        ucrChkTableWidth.AddToLinkedControls(ucrNudTableWidth, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableLayout.AddToLinkedControls(ucrInputTableLayout, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableAlign.AddToLinkedControls(ucrInputTableAlign, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableBackColor.AddToLinkedControls(ucrInputTableBackColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableFontNames.AddToLinkedControls(ucrInputTableFontNames, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableFontSize.AddToLinkedControls(ucrNudTableFontSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableFontWeight.AddToLinkedControls(ucrInputTableFontWeight, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableFontStyle.AddToLinkedControls(ucrInputTableFontStyle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableFontColor.AddToLinkedControls(ucrInputTableFontColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableTopColor.AddToLinkedControls(ucrInputTableTopColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableTopStyle.AddToLinkedControls(ucrInputTableTopStyle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableTopWidth.AddToLinkedControls(ucrNudTableTopWidth, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableRightColor.AddToLinkedControls(ucrInputTableRightColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableRightStyle.AddToLinkedControls(ucrInputTableRightStyle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableRightWidth.AddToLinkedControls(ucrNudTableRightWidth, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableBottomColor.AddToLinkedControls(ucrInputTableBottomColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableBottomStyle.AddToLinkedControls(ucrInputTableBottomStyle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableBottomWidth.AddToLinkedControls(ucrNudTableBottomWidth, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableLeftColor.AddToLinkedControls(ucrInputTableLeftColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableLeftStyle.AddToLinkedControls(ucrInputTableLeftStyle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTableLeftWidth.AddToLinkedControls(ucrNudTableLeftWidth, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkColumnsBackColor.SetText("Background Color")
        ucrInputColumnsBackColor.SetParameter(New RParameter("column_labels.background.color", iNewPosition:=35))
        ucrInputColumnsBackColor.SetRDefault(Chr(34) & "NULL" & Chr(34))
        ucrChkColumnsBackColor.AddParameterPresentCondition(True, "column_labels.background.color")
        ucrChkColumnsBackColor.AddParameterPresentCondition(False, "column_labels.background.color", False)

        ucrChkColumnsPadding.SetText("Vertical Padding")
        ucrInputColumnsPadding.SetParameter(New RParameter("column_labels.padding", iNewPosition:=1))
        ' ucrInputColumnsPadding.SetItems(dctAlignment)
        ucrChkColumnsPadding.AddParameterPresentCondition(True, "column_labels.padding")
        ucrChkColumnsPadding.AddParameterPresentCondition(False, "column_labels.padding", False)

        ucrChkColumnsFontSize.SetText("Font Size")
        ucrNudColumnsFontSize.SetParameter(New RParameter("column_labels.font.size", iNewPosition:=2))
        ucrNudColumnsFontSize.SetRDefault(0)
        ucrChkColumnsFontSize.AddParameterPresentCondition(True, "column_labels.font.size")
        ucrChkColumnsFontSize.AddParameterPresentCondition(False, "column_labels.font.size", False)

        ucrChkColumnsHorizontalPadding.SetText("Horizontal Padding")
        ucrInputColumnsHorizontalPadding.SetParameter(New RParameter("column_labels.padding.horizontal", iNewPosition:=3))
        'ucrInputColumnsHorizontalPadding.SetRDefault(0)
        ucrChkColumnsHorizontalPadding.AddParameterPresentCondition(True, "column_labels.padding.horizontal")
        ucrChkColumnsHorizontalPadding.AddParameterPresentCondition(False, "column_labels.padding.horizontal", False)

        ucrChkColumnsFontWeight.SetText("Font Weights")
        ucrInputColumnsFontWeight.SetParameter(New RParameter("column_labels.font.weight", iNewPosition:=4))
        ucrInputColumnsFontWeight.SetItems(dctWeights)
        ucrChkColumnsFontWeight.AddParameterPresentCondition(True, "column_labels.font.weight")
        ucrChkColumnsFontWeight.AddParameterPresentCondition(False, "column_labels.font.weight", False)

        ucrChkColumnsTextTransform.SetText("Text Transform")
        ucrInputColumnsTextTransform.SetParameter(New RParameter("column_labels.text_transform", iNewPosition:=5))
        ucrInputColumnsTextTransform.SetItems(dctTextTransform)
        ucrChkColumnsTextTransform.AddParameterPresentCondition(True, "column_labels.text_transform")
        ucrChkColumnsTextTransform.AddParameterPresentCondition(False, "column_labels.text_transform", False)

        ucrChkBoxWidth.SetText("Width of box")
        ucrNudBoxWidth.SetParameter(New RParameter("heading.padding", iNewPosition:=6))
        ucrNudBoxWidth.SetRDefault(0)
        ucrChkBoxWidth.AddParameterPresentCondition(True, "heading.padding")
        ucrChkBoxWidth.AddParameterPresentCondition(False, "heading.padding", False)

        ucrChkBoxWidth.SetText("Length of box")
        ucrNudBoxWidth.SetParameter(New RParameter("heading.padding.horizontal", iNewPosition:=7))
        ucrNudBoxWidth.SetRDefault(0)
        ucrChkBoxWidth.AddParameterPresentCondition(True, "heading.padding.horizontal")
        ucrChkBoxWidth.AddParameterPresentCondition(False, "heading.padding,horizontal", False)

        ucrChkBottomWidth.SetText("Width of bottom border")
        ucrNudBottomWidth.SetParameter(New RParameter("heading.border.bottom.width", iNewPosition:=8))
        ucrNudBottomWidth.SetRDefault(0)
        ucrChkBottomWidth.AddParameterPresentCondition(True, "heading.border.bottom.width")
        ucrChkBottomWidth.AddParameterPresentCondition(False, "heading.border.bottom.width", False)

        ucrChkBottomStyle.SetText("Style of bottom border")
        ucrInputBottomStyle.SetParameter(New RParameter("heading.border.bottom.style", iNewPosition:=9))
        ucrInputBottomStyle.SetItems(dctBorderStyles)
        ucrChkBottomStyle.AddParameterPresentCondition(True, "heading.border.bottom.style")
        ucrChkBottomStyle.AddParameterPresentCondition(False, "heading.border.bottom.style", False)

        ucrChkBottomColour.SetText("Colour of bottom border")
        ucrInputBottomColour.SetParameter(New RParameter("heading.border.bottom.color", iNewPosition:=10))
        ucrInputBottomColour.SetRDefault(Chr(34) & "NULL" & Chr(34))
        ucrChkBottomColour.AddParameterPresentCondition(True, "heading.border.bottom.color")
        ucrChkBottomColour.AddParameterPresentCondition(False, "heading.border.bottom.color", False)

        ucrChkSideWidth.SetText("Width of side border")
        ucrNudSideWidth.SetParameter(New RParameter("heading.border.lr.width", iNewPosition:=11))
        ucrNudSideWidth.SetRDefault(0)
        ucrChkSideWidth.AddParameterPresentCondition(True, "heading.border.lr.width")
        ucrChkSideWidth.AddParameterPresentCondition(False, "heading.border.lr.width", False)

        ucrChkSideStyle.SetText("Style of side border")
        ucrInputSideStyle.SetParameter(New RParameter("heading.border.lr.style", iNewPosition:=12))
        ucrInputSideStyle.SetItems(dctBorderStyles)
        ucrChkSideStyle.AddParameterPresentCondition(True, "heading.border.lr.style")
        ucrChkSideStyle.AddParameterPresentCondition(False, "heading.border.lr.style", False)

        ucrChkSideColour.SetText("Colour of side border")
        ucrInputSideColour.SetParameter(New RParameter("heading.border.lr.colour", iNewPosition:=13))
        ucrInputSideColour.SetRDefault(Chr(34) & "NULL" & Chr(34))
        ucrChkSideColour.AddParameterPresentCondition(True, "heading.border.lr.colour")
        ucrChkSideColour.AddParameterPresentCondition(False, "heading.border.lr.colour", False)

        ucrChkBackgroundColour.AddToLinkedControls(ucrInputBackgroundColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrChkAlignment.AddToLinkedControls(ucrInputAlignment, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Vertical")
        ucrChkFontSize.AddToLinkedControls(ucrNudFontSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Top")
        ucrChkFontWeight.AddToLinkedControls(ucrInputFontWeight, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Vertical")
        ucrChkSubTitleSize.AddToLinkedControls(ucrNudSubTitleSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Top")
        ucrChkSubTitleWeight.AddToLinkedControls(ucrInputSubTitleWeight, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Normal")
        ucrChkBoxWidth.AddToLinkedControls(ucrNudBoxWidth, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBoxLength.AddToLinkedControls(ucrNudBoxLength, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBottomWidth.AddToLinkedControls(ucrNudBottomWidth, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBottomStyle.AddToLinkedControls(ucrInputBottomStyle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBottomColour.AddToLinkedControls(ucrInputBottomColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSideWidth.AddToLinkedControls(ucrNudSideWidth, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSideStyle.AddToLinkedControls(ucrInputSideStyle, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrChkSideColour.AddToLinkedControls(ucrInputSideColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

    End Sub

    Public Sub SetRCode(bReset As Boolean, clsNewThemesTabOption As RFunction)
        bRCodeSet = False
        clsThemesTabOptionsFunction = clsNewThemesTabOption

        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        ucrInputBackgroundColour.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputAlignment.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudFontSize.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputFontWeight.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudSubTitleSize.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSubTitleWeight.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudBoxLength.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudBoxWidth.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudBottomWidth.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputBottomStyle.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputBottomColour.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudSideWidth.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSideColour.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSideStyle.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableAlign.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableBackColor.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableFontColor.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableLayout.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableFontWeight.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudTableWidth.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudTableFontSize.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableFontNames.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableFontStyle.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableTopColor.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableTopStyle.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudTableTopWidth.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableRightColor.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableRightStyle.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudTableRightWidth.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableBottomColor.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableBottomStyle.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudTableBottomWidth.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableLeftColor.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableLeftStyle.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudTableLeftWidth.SetRCode(clsThemesTabOptionsFunction, bReset, bCloneIfNeeded:=True)
    End Sub

End Class