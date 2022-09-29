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

Public Class sdgTableOptions
    'Private bFirstLoad As Boolean
    Private bReset As Boolean
    Private clsCellTextFunction, clsGoogleFontFunction, clsCellBorderFunction, clsCellFillFunction, clsSidesOptions As New RFunction
    Private Sub sdgTableOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InitialiseDialog()
        Dim dctAlignOptions As New Dictionary(Of String, String)
        Dim dctColorOptions As New Dictionary(Of String, String)
        Dim dctValignOptions As New Dictionary(Of String, String)
        Dim dctStyleOptions As New Dictionary(Of String, String)
        Dim dctFontOptions As New Dictionary(Of String, String)
        Dim dctSizeOptions As New Dictionary(Of String, String)
        Dim dctWeightOptions As New Dictionary(Of String, String)
        Dim dctStretchOptions As New Dictionary(Of String, String)
        Dim dctWhitespaceOptions As New Dictionary(Of String, String)
        Dim dctDecorateOptions As New Dictionary(Of String, String)
        Dim dctTransformOptions As New Dictionary(Of String, String)
        Dim dctBorderColorOptions As New Dictionary(Of String, String)
        Dim dctBorderStyleOptions As New Dictionary(Of String, String)
        Dim dctBorderWeightOptions As New Dictionary(Of String, String)
        Dim dctCellFillOptions As New Dictionary(Of String, String)

        'Size
        ucrChkSize.SetText("Size")
        ucrInputSize.SetParameter(New RParameter("size"), 0)
        dctSizeOptions.Add("None", "NULL")
        dctSizeOptions.Add("Extra Extra Small", Chr(34) & "xx-small" & Chr(34))
        dctSizeOptions.Add("Extra Small", Chr(34) & "x-small" & Chr(34))
        dctSizeOptions.Add("Small", Chr(34) & "small" & Chr(34))
        dctSizeOptions.Add("Medium", Chr(34) & "medium" & Chr(34))
        dctSizeOptions.Add("Large", Chr(34) & "large" & Chr(34))
        dctSizeOptions.Add("Extra Large", Chr(34) & "x-large" & Chr(34))
        dctSizeOptions.Add("Extra Extra Large", Chr(34) & "xx-large" & Chr(34))
        ucrInputSize.SetItems(dctSizeOptions)
        ucrInputSize.SetRDefault("NULL")
        ucrChkSize.AddToLinkedControls(ucrInputSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)

        'Color
        ucrChkColor.SetText("Color")
        ucrInputColor.SetParameter(New RParameter("color"), 1)
        dctColorOptions.Add("None", "NULL")
        dctColorOptions.Add("Black", Chr(34) & "black" & Chr(34))
        dctColorOptions.Add("White", Chr(34) & "white" & Chr(34))
        dctColorOptions.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctColorOptions.Add("Red", Chr(34) & "red" & Chr(34))
        dctColorOptions.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctColorOptions.Add("Purple", Chr(34) & "purple" & Chr(34))
        dctColorOptions.Add("Green", Chr(34) & "green" & Chr(34))
        dctColorOptions.Add("Orange", Chr(34) & "orange" & Chr(34))
        dctColorOptions.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctColorOptions.Add("Brown", Chr(34) & "brown" & Chr(34))
        dctColorOptions.Add("Pink", Chr(34) & "pink" & Chr(34))
        ucrInputColor.SetItems(dctColorOptions)
        ucrInputColor.SetRDefault("NULL")
        ucrChkColor.AddToLinkedControls(ucrInputColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)

        'Font
        ucrChkFont.SetText("Font")
        ucrInputFont.SetParameter(New RParameter("name"), 0)
        dctFontOptions.Add("None", "NULL")
        dctFontOptions.Add("Anonymous Pro", Chr(34) & "Anonymous Pro" & Chr(34))
        dctFontOptions.Add("Fira Code", Chr(34) & "Fira Code" & Chr(34))
        dctFontOptions.Add("IBM Plex Mono", Chr(34) & "IBM Plex Mono" & Chr(34))
        dctFontOptions.Add("Inconsolata", Chr(34) & "Inconsolata" & Chr(34))
        dctFontOptions.Add("Space Mono", Chr(34) & "Space Mono" & Chr(34))
        dctFontOptions.Add("Archivo Narrow", Chr(34) & "Archivo Narrow" & Chr(34))
        dctFontOptions.Add("Cabin", Chr(34) & "Cabin" & Chr(34))
        dctFontOptions.Add("Chivo", Chr(34) & "Chivo" & Chr(34))
        dctFontOptions.Add("Encode Sans", Chr(34) & "Encode Sans" & Chr(34))
        dctFontOptions.Add("Exo 2", Chr(34) & "Exo 2" & Chr(34))
        dctFontOptions.Add("Fira Sans", Chr(34) & "Fira Sans" & Chr(34))
        dctFontOptions.Add("IBM Plex Sans", Chr(34) & "IBM Plex Sans" & Chr(34))
        dctFontOptions.Add("Inter", Chr(34) & "Inter" & Chr(34))
        dctFontOptions.Add("Karla", Chr(34) & "Inter" & Chr(34))
        dctFontOptions.Add("Lato", Chr(34) & "Lato" & Chr(34))
        ucrInputFont.SetItems(dctFontOptions)
        ucrInputFont.SetRDefault("NULL")
        ucrChkFont.AddToLinkedControls(ucrInputFont, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)

        'Align
        ucrChkAlign.SetText("Align")
        ucrInputAlign.SetParameter(New RParameter("align"), 3)
        dctAlignOptions.Add("Center", Chr(34) & "center" & Chr(34))
        dctAlignOptions.Add("Left", Chr(34) & "left" & Chr(34))
        dctAlignOptions.Add("Right", Chr(34) & "right" & Chr(34))
        dctAlignOptions.Add("Justify", Chr(34) & "justify" & Chr(34))
        dctAlignOptions.Add("None", "NULL")
        ucrInputAlign.SetItems(dctAlignOptions)
        ucrInputAlign.SetRDefault("NULL")
        ucrChkAlign.AddToLinkedControls(ucrInputAlign, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)

        'Valign
        ucrChkValign.SetText("V_Align")
        ucrInputValign.SetParameter(New RParameter("v_align"), 4)
        dctValignOptions.Add("Middle", Chr(34) & "middle" & Chr(34))
        dctValignOptions.Add("Top", Chr(34) & "top" & Chr(34))
        dctValignOptions.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctValignOptions.Add("None", "NULL")
        ucrInputValign.SetItems(dctValignOptions)
        ucrInputValign.SetRDefault("NULL")
        ucrChkValign.AddToLinkedControls(ucrInputValign, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)

        'Style
        ucrChkStyle.SetText("Style")
        ucrInputStyle.SetParameter(New RParameter("style"), 5)
        dctStyleOptions.Add("None", "NULL")
        dctStyleOptions.Add("Normal", Chr(34) & "normal" & Chr(34))
        dctStyleOptions.Add("Italic", Chr(34) & "italic" & Chr(34))
        dctStyleOptions.Add("Oblique", Chr(34) & "oblique" & Chr(34))
        ucrInputStyle.SetItems(dctStyleOptions)
        ucrInputStyle.SetRDefault("NULL")
        ucrChkStyle.AddToLinkedControls(ucrInputStyle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)

        'Weight
        ucrChkWeight.SetText("Weight")
        ucrInputWeight.SetParameter(New RParameter("weight"), 6)
        dctWeightOptions.Add("None", "NULL")
        dctWeightOptions.Add("Normal", Chr(34) & "normal" & Chr(34))
        dctWeightOptions.Add("Bold", Chr(34) & "bold" & Chr(34))
        dctWeightOptions.Add("Lighter", Chr(34) & "lighter" & Chr(34))
        dctWeightOptions.Add("Bolder", Chr(34) & "bolder" & Chr(34))
        ucrInputWeight.SetItems(dctWeightOptions)
        ucrInputWeight.SetRDefault("NULL")
        ucrChkWeight.AddToLinkedControls(ucrInputWeight, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)

        'Stretch
        ucrChkStretch.SetText("Stretch")
        ucrInputStretch.SetParameter(New RParameter("stretch"), 7)
        dctStretchOptions.Add("None", "NULL")
        dctStretchOptions.Add("Ultra Condensed", Chr(34) & "ultra-condensed" & Chr(34))
        dctStretchOptions.Add("Extra Condensed", Chr(34) & "extra-condensed" & Chr(34))
        dctStretchOptions.Add("Condensed", Chr(34) & "condensed" & Chr(34))
        dctStretchOptions.Add("Semi Condensed", Chr(34) & "semi-condensed" & Chr(34))
        dctStretchOptions.Add("Normal", Chr(34) & "normal" & Chr(34))
        dctStretchOptions.Add("Semi  Expanded", Chr(34) & "semi-expanded" & Chr(34))
        dctStretchOptions.Add("Expanded", Chr(34) & "expanded" & Chr(34))
        dctStretchOptions.Add("Extra Expanded", Chr(34) & "extra-expanded" & Chr(34))
        dctStretchOptions.Add("Ultra Expanded", Chr(34) & "ultra-expanded" & Chr(34))
        ucrInputStretch.SetItems(dctStretchOptions)
        ucrInputStretch.SetRDefault("NULL")
        ucrChkStretch.AddToLinkedControls(ucrInputStretch, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)

        'Whitespace
        ucrChkWhitespace.SetText("Whitesapce")
        ucrInputWhitespace.SetParameter(New RParameter("whitespace"), 8)
        dctWhitespaceOptions.Add("None", Chr(34) & "NULL" & Chr(34))
        dctWhitespaceOptions.Add("Normal", Chr(34) & "normal" & Chr(34))
        dctWhitespaceOptions.Add("nowrap", Chr(34) & "nowrap" & Chr(34))
        dctWhitespaceOptions.Add("Pre", Chr(34) & "pre" & Chr(34))
        dctWhitespaceOptions.Add("Pre-Wrap", Chr(34) & "pre-wrap" & Chr(34))
        dctWhitespaceOptions.Add("Pre-Line", Chr(34) & "pre-line" & Chr(34))
        dctWhitespaceOptions.Add("Break Spaces", Chr(34) & "break-spaces" & Chr(34))
        ucrInputWhitespace.SetItems(dctWhitespaceOptions)
        ucrInputWhitespace.SetRDefault("NULL")
        ucrChkWhitespace.AddToLinkedControls(ucrInputWhitespace, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)

        'Decorate
        ucrChkDecorate.SetText("Decorate")
        ucrInputDecorate.SetParameter(New RParameter("decorate"), 9)
        dctDecorateOptions.Add("None", "NULL")
        dctDecorateOptions.Add("Overline", Chr(34) & "overline" & Chr(34))
        dctDecorateOptions.Add("Line-Through", Chr(34) & "line-through" & Chr(34))
        dctDecorateOptions.Add("Underline", Chr(34) & "underline" & Chr(34))
        ucrInputDecorate.SetItems(dctDecorateOptions)
        ucrInputDecorate.SetRDefault("NULL")
        ucrChkDecorate.AddToLinkedControls(ucrInputDecorate, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)

        'Transform
        ucrChkTransform.SetText("Transform")
        ucrInputTransform.SetParameter(New RParameter("transform"), 10)
        dctTransformOptions.Add("None", "NULL")
        dctTransformOptions.Add("Uppercase", Chr(34) & "uppercase" & Chr(34))
        dctTransformOptions.Add("Lowercase", Chr(34) & "lowercase" & Chr(34))
        dctTransformOptions.Add("Capitalize", Chr(34) & "capitalize" & Chr(34))
        ucrInputTransform.SetItems(dctTransformOptions)
        ucrInputTransform.SetRDefault("NULL")
        ucrChkTransform.AddToLinkedControls(ucrInputTransform, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)

        'Indent
        ucrChkIndent.SetText("Indent")
        ucrNudIndent.SetParameter(New RParameter("indent"), 11)
        ucrNudIndent.Increment = 1
        ucrNudIndent.SetMinMax(1, 15)
        ucrChkIndent.AddToLinkedControls(ucrNudIndent, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)

        ucrChkEditText.SetText("Edit Text")
        ucrChkEditText.SetLinkedDisplayControl(grpText)

        ucrChkEditBorders.SetText("Edit Borders")
        ucrChkEditBorders.SetLinkedDisplayControl(grpBorders)

        ucrChkEditFill.SetText("Edit Fill")
        ucrChkEditFill.SetLinkedDisplayControl(grpFill)

        ucrChkSideLeft.SetText("Left")
        ucrChkSideLeft.SetValueIfChecked("left")

        ucrChkSideRight.SetText("Right")
        ucrChkSideRight.SetValueIfChecked("right")

        ucrChkSideTop.SetText("Top")
        ucrChkSideTop.SetValueIfChecked("top")

        ucrChkSideBottom.SetText("Bottom")
        ucrChkSideBottom.SetValueIfChecked("bottom")

        'Border Color
        ucrChkBorderColor.SetText("Color")
        ucrInputBorderColor.SetParameter(New RParameter("color"))
        dctBorderWeightOptions.Add("None", "NULL")
        dctBorderColorOptions.Add("Black", Chr(34) & "black" & Chr(34))
        dctBorderColorOptions.Add("White", Chr(34) & "white" & Chr(34))
        dctBorderColorOptions.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctBorderColorOptions.Add("Red", Chr(34) & "red" & Chr(34))
        dctBorderColorOptions.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctBorderColorOptions.Add("Purple", Chr(34) & "purple" & Chr(34))
        dctBorderColorOptions.Add("Green", Chr(34) & "green" & Chr(34))
        dctBorderColorOptions.Add("Orange", Chr(34) & "orange" & Chr(34))
        dctBorderColorOptions.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctBorderColorOptions.Add("Brown", Chr(34) & "brown" & Chr(34))
        dctBorderColorOptions.Add("Pink", Chr(34) & "pink" & Chr(34))
        ucrInputBorderColor.SetItems(dctBorderColorOptions)
        ucrInputBorderColor.SetRDefault(Chr(34) & "black" & Chr(34))
        ucrChkBorderColor.AddToLinkedControls(ucrInputBorderColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)

        'Border Style
        ucrChkBorderStyle.SetText("Style")
        ucrInputBorderStyle.SetParameter(New RParameter("style"))
        dctBorderWeightOptions.Add("None", "NULL")
        dctBorderStyleOptions.Add("Solid", Chr(34) & "solid" & Chr(34))
        dctBorderStyleOptions.Add("Dashed", Chr(34) & "dashed" & Chr(34))
        dctBorderStyleOptions.Add("Dotted", Chr(34) & "dotted" & Chr(34))
        dctBorderStyleOptions.Add("Hidden", Chr(34) & "hidden" & Chr(34))
        ucrInputBorderStyle.SetItems(dctBorderStyleOptions)
        ucrInputBorderStyle.SetRDefault(Chr(34) & "solid" & Chr(34))
        ucrChkBorderStyle.AddToLinkedControls(ucrInputBorderStyle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)

        'Border Weight
        ucrChkBorderWeight.SetText("Weight")
        ucrInputBorderWeight.SetParameter(New RParameter("weight"))
        dctBorderWeightOptions.Add("None", "NULL")
        dctBorderWeightOptions.Add("Normal", Chr(34) & "normal" & Chr(34))
        dctBorderWeightOptions.Add("Bold", Chr(34) & "bold" & Chr(34))
        dctBorderWeightOptions.Add("Lighter", Chr(34) & "lighter" & Chr(34))
        dctBorderWeightOptions.Add("Bolder", Chr(34) & "bolder" & Chr(34))
        ucrInputBorderWeight.SetItems(dctBorderWeightOptions)
        ucrInputBorderWeight.SetRDefault("Null")
        ucrChkBorderWeight.AddToLinkedControls(ucrInputBorderWeight, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)

        'Cell Fill
        ucrInputFillColor.SetParameter(New RParameter("color"))
        dctCellFillOptions.Add("None", "NULL")
        dctCellFillOptions.Add("Black", Chr(34) & "black" & Chr(34))
        dctCellFillOptions.Add("White", Chr(34) & "white" & Chr(34))
        dctCellFillOptions.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctCellFillOptions.Add("Red", Chr(34) & "red" & Chr(34))
        dctCellFillOptions.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctCellFillOptions.Add("Purple", Chr(34) & "purple" & Chr(34))
        dctCellFillOptions.Add("Green", Chr(34) & "green" & Chr(34))
        dctCellFillOptions.Add("Orange", Chr(34) & "orange" & Chr(34))
        dctCellFillOptions.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctCellFillOptions.Add("Light Grey", Chr(34) & "#D3D3D3" & Chr(34))
        dctCellFillOptions.Add("Brown", Chr(34) & "brown" & Chr(34))
        dctCellFillOptions.Add("Pink", Chr(34) & "pink" & Chr(34))
        ucrInputFillColor.SetItems(dctCellFillOptions)
        ucrInputFillColor.SetRDefault(Chr(34) & "#D3D3D3" & Chr(34))
        ucrInputFillColor.SetLinkedDisplayControl(lblFillColor)

        'Fill Transparency
        ucrNudFillTransparency.SetParameter(New RParameter("alpha"))
        ucrNudFillTransparency.Increment = 0.1
        ucrNudFillTransparency.SetMinMax(0, 1)
        ucrNudFillTransparency.SetRDefault("0.5")
        ucrNudFillTransparency.SetLinkedDisplayControl(lblFillTransparency)

    End Sub

    Private Sub SetDefaults()
        clsCellTextFunction = New RFunction
        clsGoogleFontFunction = New RFunction
        clsCellBorderFunction = New RFunction
        clsCellFillFunction = New RFunction

        clsCellTextFunction.SetPackageName("gt")
        clsCellTextFunction.SetRCommand("cell_text")

        clsCellBorderFunction.SetPackageName("gt")
        clsCellBorderFunction.SetRCommand("cell_borders")
        clsSidesOptions.SetRCommand("c")
        clsCellBorderFunction.AddParameter("sides", clsRFunctionParameter:=clsSidesOptions)


        clsCellFillFunction.SetPackageName("gt")
        clsCellFillFunction.SetRCommand("cell_fill")

        clsGoogleFontFunction.SetRCommand("google_font")
        clsGoogleFontFunction.AddParameter("font", clsRFunctionParameter:=clsGoogleFontFunction, iPosition:=2)

        'ucrBaseSubDialog.clsRsyntax.SetBaseRFunction(clsCellTextFunction)

    End Sub

    Private Sub SetRCodeForControls()
        ucrInputSize.SetRCode(clsCellTextFunction, bReset)
        ucrInputAlign.SetRCode(clsCellTextFunction, bReset)
        ucrInputColor.SetRCode(clsCellTextFunction, bReset)
        ucrInputStyle.SetRCode(clsCellTextFunction, bReset)
        ucrInputDecorate.SetRCode(clsCellTextFunction, bReset)
        ucrInputStretch.SetRCode(clsCellTextFunction, bReset)
        ucrInputTransform.SetRCode(clsCellTextFunction, bReset)
        ucrInputValign.SetRCode(clsCellTextFunction, bReset)
        ucrInputWeight.SetRCode(clsCellTextFunction, bReset)
        ucrInputWhitespace.SetRCode(clsCellTextFunction, bReset)
        ucrNudIndent.SetRCode(clsCellTextFunction, bReset)
        ucrInputFont.SetRCode(clsGoogleFontFunction, bReset)
        ucrInputBorderColor.SetRCode(clsCellBorderFunction, bReset)
        ucrChkBorderStyle.SetRCode(clsCellBorderFunction, bReset)
        ucrInputBorderWeight.SetRCode(clsCellBorderFunction, bReset)
        ucrInputFillColor.SetRCode(clsCellFillFunction, bReset)
        ucrNudFillTransparency.SetRCode(clsCellFillFunction, bReset)
        ucrChkSideLeft.SetRCode(clsSidesOptions, bReset)
        ucrChkSideRight.SetRCode(clsSidesOptions, bReset)
        ucrChkSideTop.SetRCode(clsSidesOptions, bReset)
        ucrChkSideBottom.SetRCode(clsSidesOptions, bReset)
    End Sub

End Class