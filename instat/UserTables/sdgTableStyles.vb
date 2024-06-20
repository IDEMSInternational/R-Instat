Imports instat.Translations

Public Class sdgTableStyles

    Private clsCellTextRFunction, clsCellFillRFunction As New RFunction
    Private bFirstload As Boolean = True

    Private Sub sdgTableTextFormatOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()

        '-----------------
        ucrCboColorText.SetDropDownStyleAsNonEditable()
        ucrCboColorText.SetParameter(New RParameter("color", iNewPosition:=0))
        ucrCboColorText.SetColours()
        ucrCboColorText.SetRDefault("NULL")
        '-----------------

        '-----------------
        Dim dctFontFamily As New Dictionary(Of String, String) From {
            {"Default", "NULL"},
            {"Arial (sans-serif)", Chr(34) & "Arial, sans-serif" & Chr(34)},
            {"Verdana (sans-serif)", Chr(34) & "Verdana, sans-serif" & Chr(34)},
            {"Tahoma", Chr(34) & "Tahoma, sans-serif" & Chr(34)},
            {"Trebuchet MS", Chr(34) & "'Trebuchet MS', sans-serif" & Chr(34)},
            {"Times New Roman (serif)", Chr(34) & "'Times New Roman', serif" & Chr(34)},
            {"Georgia (serif)", Chr(34) & "Georgia, serif" & Chr(34)},
            {"Garamond (serif)", Chr(34) & "Garamond, serif" & Chr(34)}
        }
        ucrCboFontFamily.SetDropDownStyleAsNonEditable()
        ucrCboFontFamily.SetParameter(New RParameter("font", iNewPosition:=1))
        ucrCboFontFamily.SetItems(dctFontFamily)
        ucrCboFontFamily.SetRDefault("NULL")
        '-----------------

        '-----------------
        ucrTxtFontSize.SetParameter(New RParameter("size", iNewPosition:=2))
        ucrTxtFontSize.SetRDefault("NULL")
        '-----------------

        '-----------------
        Dim dctAlignHorizontal As New Dictionary(Of String, String) From {
            {"Default", "NULL"},
            {"Center", Chr(34) & "center" & Chr(34)},
            {"Left", Chr(34) & "left" & Chr(34)},
            {"Right", Chr(34) & "right" & Chr(34)},
            {"Justify", Chr(34) & "justify" & Chr(34)}
        }
        ucrCboAlignHorizontal.SetDropDownStyleAsNonEditable()
        ucrCboAlignHorizontal.SetParameter(New RParameter("align", iNewPosition:=3))
        ucrCboAlignHorizontal.SetItems(dctAlignHorizontal)
        ucrCboAlignHorizontal.SetRDefault("NULL")
        '-----------------

        '-----------------
        Dim dctAlignVertical As New Dictionary(Of String, String) From {
            {"Default", "NULL"},
            {"Middle", Chr(34) & "middle" & Chr(34)},
            {"Top", Chr(34) & "top" & Chr(34)},
            {"Bottom", Chr(34) & "bottom" & Chr(34)}
        }
        ucrCboAlignVertical.SetDropDownStyleAsNonEditable()
        ucrCboAlignVertical.SetParameter(New RParameter("align", iNewPosition:=4))
        ucrCboAlignVertical.SetItems(dctAlignHorizontal)
        ucrCboAlignVertical.SetRDefault("NULL")
        '-----------------

        '-----------------
        Dim dctFontStyle As New Dictionary(Of String, String) From {
            {"Default", "NULL"},
            {"Normal", Chr(34) & "normal" & Chr(34)},
            {"Italic", Chr(34) & "italic" & Chr(34)},
            {"Oblique", Chr(34) & "oblique" & Chr(34)}
        }

        ucrCboFontStyle.SetDropDownStyleAsNonEditable()
        ucrCboFontStyle.SetParameter(New RParameter("style", iNewPosition:=5))
        ucrCboFontStyle.SetItems(dctFontStyle)
        ucrCboFontStyle.SetRDefault("NULL")
        '-----------------

        '-----------------
        Dim dctFontWeight As New Dictionary(Of String, String) From {
            {"Default", "NULL"},
            {"Normal", Chr(34) & "normal" & Chr(34)},
            {"Bold", Chr(34) & "bold" & Chr(34)},
            {"Lighter", Chr(34) & "lighter" & Chr(34)},
            {"Bolder", Chr(34) & "bold" & Chr(34)}
        }

        ucrCboFontWeight.SetDropDownStyleAsNonEditable()
        ucrCboFontWeight.SetParameter(New RParameter("weight", iNewPosition:=7))
        ucrCboFontWeight.SetItems(dctFontWeight)
        ucrCboFontWeight.SetRDefault("NULL")
        '-----------------

        '-----------------
        Dim dctUnderlineType As New Dictionary(Of String, String) From {
            {"Default", "NULL"},
            {"Underline", Chr(34) & "underline" & Chr(34)},
            {"Overline", Chr(34) & "overline" & Chr(34)},
            {"Line-through", Chr(34) & "line-through" & Chr(34)}
        }
        ucrCboUnderlineType.SetDropDownStyleAsNonEditable()
        ucrCboUnderlineType.SetParameter(New RParameter("decorate", iNewPosition:=8))
        ucrCboUnderlineType.SetItems(dctUnderlineType)
        ucrCboUnderlineType.SetRDefault("NULL")


        'Dim dctUnderlineStyle As New Dictionary(Of String, String) From {
        '    {"Default", "NULL"},
        '    {"Solid", Chr(34) & "solid" & Chr(34)},
        '    {"Double", Chr(34) & "double" & Chr(34)},
        '    {"Dotted", Chr(34) & "dotted" & Chr(34)},
        '    {"Dashed", Chr(34) & "dashed" & Chr(34)},
        '    {"Wavy", Chr(34) & "wavy" & Chr(34)}
        '}
        'ucrCboUnderlineStyle.SetDropDownStyleAsNonEditable()
        'ucrCboUnderlineStyle.SetParameter(New RParameter("text.decoration.style"))
        'ucrCboUnderlineStyle.SetItems(dctUnderlineStyle)
        'ucrCboUnderlineStyle.SetRDefault("NULL")

        'ucrCboUnderLineColor.SetDropDownStyleAsNonEditable()
        'ucrCboUnderLineColor.SetParameter(New RParameter("text.decoration.color"))
        'ucrCboUnderLineColor.SetColours()
        'ucrCboUnderLineColor.SetRDefault("NULL")
        '-----------------

        '-----------------
        Dim dctTransform As New Dictionary(Of String, String) From {
            {"Default", "NULL"},
            {"Uppercase", Chr(34) & "uppercase" & Chr(34)},
            {"Lowercase", Chr(34) & "lowercase" & Chr(34)},
            {"Capitalize", Chr(34) & "capitalize" & Chr(34)}
        }
        ucrInputCboTransform.SetDropDownStyleAsNonEditable()
        ucrInputCboTransform.SetParameter(New RParameter("transform", iNewPosition:=9))
        ucrInputCboTransform.SetItems(dctTransform)
        ucrInputCboTransform.SetRDefault("NULL")
        '-----------------

        '-----------------
        Dim dctStretch As New Dictionary(Of String, String) From {
            {"Default", "NULL"},
            {"Ultra-condensed", Chr(34) & "ultra-condensed" & Chr(34)},
            {"Extra-condensed", Chr(34) & "extra-condensed" & Chr(34)},
            {"Condensed", Chr(34) & "condensed" & Chr(34)},
            {"Semi-condensed", Chr(34) & "semi-condensed" & Chr(34)},
            {"normal", Chr(34) & "normal" & Chr(34)},
            {"Semi-expanded", Chr(34) & "semi-expanded" & Chr(34)},
            {"Expanded", Chr(34) & "expanded" & Chr(34)},
            {"Extra-expanded", Chr(34) & "extra-expanded" & Chr(34)},
            {"Ultra-expanded", Chr(34) & "ultra-expanded" & Chr(34)}
        }
        ucrCboStretch.SetDropDownStyleAsNonEditable()
        ucrCboStretch.SetParameter(New RParameter("stretch", iNewPosition:=10))
        ucrCboStretch.SetItems(dctStretch)
        ucrCboStretch.SetRDefault("NULL")
        '-----------------

        '-----------------
        ucrTxtIndent.SetParameter(New RParameter("indent", iNewPosition:=11))
        ucrTxtIndent.SetRDefault("NULL")
        '-----------------

        '-----------------
        Dim dctWhiteSpace As New Dictionary(Of String, String) From {
            {"Default", "NULL"},
            {"Normal", Chr(34) & "normal" & Chr(34)},
            {"No wrap", Chr(34) & "nowrap" & Chr(34)},
            {"Pre", Chr(34) & "pre" & Chr(34)},
            {"Pre-wrap", Chr(34) & "pre-wrap" & Chr(34)},
            {"Pre-line", Chr(34) & "pre-line" & Chr(34)},
            {"Break-spaces", Chr(34) & "break-spaces" & Chr(34)}
        }
        ucrCboStretch.SetDropDownStyleAsNonEditable()
        ucrCboStretch.SetParameter(New RParameter("transform", iNewPosition:=11))
        ucrCboStretch.SetItems(dctWhiteSpace)
        ucrCboStretch.SetRDefault("NULL")
        '-----------------

        '---------------------------------------------------
        ' Cell fill controls
        ucrCboColorBackground.SetDropDownStyleAsNonEditable()
        ucrCboColorBackground.SetParameter(New RParameter("color", iNewPosition:=0))
        ucrCboColorBackground.SetColours()
        ucrCboColorBackground.SetRDefault("NULL")
        '-----------------

        '---------------------------------------------------
        ' Cell Border
        '-----------------
        Dim dctBorderSpace As New Dictionary(Of String, String) From {
         {"Default", "NULL"},
         {"Left", Chr(34) & "left" & Chr(34)},
         {"Right", Chr(34) & "right" & Chr(34)},
         {"Top", Chr(34) & "top" & Chr(34)},
         {"Bottom", Chr(34) & "bottom" & Chr(34)}
     }
        'ucrCboBorderSides.SetParameter(New RParameter("sides", iNewPosition:=0))
        'ucrCboBorderSides.SetRDefault("NULL")



        '-----------------
        ucrCboColorBackground.SetDropDownStyleAsNonEditable()
        ucrCboColorBackground.SetParameter(New RParameter("color", iNewPosition:=0))
        ucrCboColorBackground.SetColours()
        ucrCboColorBackground.SetRDefault("NULL")

        '-----------------



    End Sub

    Public Sub Setup()

        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If

        clsCellTextRFunction = New RFunction
        clsCellFillRFunction = New RFunction

        clsCellTextRFunction.SetRCommand("cell_fill")
        clsCellTextRFunction.SetRCommand("cell_text")



        SetRCode()

    End Sub

    Private Sub SetRCode()
        '-----------------
        ' Cell text controls
        ucrCboFontFamily.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboFontStyle.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboFontWeight.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrTxtFontSize.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboColorText.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboUnderlineType.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        'ucrCboUnderlineStyle.SetRCode(clsNewStyleRFunction, bReset:=False, bCloneIfNeeded:=True)
        'ucrCboUnderLineColor.SetRCode(clsNewStyleRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboAlignHorizontal.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboAlignVertical.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrInputCboTransform.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrTxtFontSize.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboWhiteSpace.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboStretch.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        '-----------------

        '-----------------
        'Cell fill controls
        ucrCboColorBackground.SetRCode(clsCellFillRFunction, bReset:=False, bCloneIfNeeded:=True)
        '-----------------


    End Sub
End Class