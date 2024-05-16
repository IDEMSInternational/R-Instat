Imports instat.Translations
Public Class sdgTableOptionsTextFormat

    Private bDialogInitised As Boolean = False

    Private Sub sdgTableTextFormatOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
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
        ucrCboFontFamily.SetParameter(New RParameter("font.family"))
        ucrCboFontFamily.SetItems(dctFontFamily)
        ucrCboFontFamily.SetRDefault("NULL")

        Dim dctFontStyle As New Dictionary(Of String, String) From {
            {"Default", "NULL"},
            {"Normal", Chr(34) & "normal" & Chr(34)},
            {"Italic", Chr(34) & "italic" & Chr(34)},
            {"Oblique", Chr(34) & "oblique" & Chr(34)}
        }

        ucrCboFontStyle.SetDropDownStyleAsNonEditable()
        ucrCboFontStyle.SetParameter(New RParameter("font.style"))
        ucrCboFontStyle.SetItems(dctFontStyle)
        ucrCboFontStyle.SetRDefault("NULL")


        Dim dctFontWeight As New Dictionary(Of String, String) From {
            {"Default", "NULL"},
            {"Normal", Chr(34) & "normal" & Chr(34)},
            {"Lighter", Chr(34) & "lighter" & Chr(34)},
            {"Bold", Chr(34) & "bold" & Chr(34)}
        }

        ucrCboFontWeight.SetDropDownStyleAsNonEditable()
        ucrCboFontWeight.SetParameter(New RParameter("font.weight"))
        ucrCboFontWeight.SetItems(dctFontWeight)
        ucrCboFontWeight.SetRDefault("NULL")

        ucrTxtFontSize.SetParameter(New RParameter("font.size"))
        ucrTxtFontSize.SetRDefault(Chr(34) & "" & Chr(34))

        ucrCboColorText.SetDropDownStyleAsNonEditable()
        ucrCboColorText.SetParameter(New RParameter("color"))
        ucrCboColorText.SetColours()
        ucrCboColorText.SetRDefault("NULL")

        ucrCboColorBackground.SetDropDownStyleAsNonEditable()
        ucrCboColorBackground.SetParameter(New RParameter("background.color"))
        ucrCboColorBackground.SetColours()
        ucrCboColorBackground.SetRDefault("NULL")

        Dim dctUnderlineType As New Dictionary(Of String, String) From {
            {"Default", "NULL"},
            {"Underline", Chr(34) & "underline" & Chr(34)},
            {"Overline", Chr(34) & "overline" & Chr(34)},
            {"Underline Overline", Chr(34) & "underline overline" & Chr(34)},
            {"Line-through", Chr(34) & "line-through" & Chr(34)}
        }
        ucrCboUnderlineType.SetDropDownStyleAsNonEditable()
        ucrCboUnderlineType.SetParameter(New RParameter("text.decoration.line"))
        ucrCboUnderlineType.SetItems(dctUnderlineType)
        ucrCboUnderlineType.SetRDefault("NULL")

        Dim dctUnderlineStyle As New Dictionary(Of String, String) From {
            {"Default", "NULL"},
            {"Solid", Chr(34) & "solid" & Chr(34)},
            {"Double", Chr(34) & "double" & Chr(34)},
            {"Dotted", Chr(34) & "dotted" & Chr(34)},
            {"Dashed", Chr(34) & "dashed" & Chr(34)},
            {"Wavy", Chr(34) & "wavy" & Chr(34)}
        }
        ucrCboUnderlineStyle.SetDropDownStyleAsNonEditable()
        ucrCboUnderlineStyle.SetParameter(New RParameter("text.decoration.style"))
        ucrCboUnderlineStyle.SetItems(dctUnderlineStyle)
        ucrCboUnderlineStyle.SetRDefault("NULL")

        ucrCboUnderLineColor.SetDropDownStyleAsNonEditable()
        ucrCboUnderLineColor.SetParameter(New RParameter("text.decoration.color"))
        ucrCboUnderLineColor.SetColours()
        ucrCboUnderLineColor.SetRDefault("NULL")


        Dim dctAlign As New Dictionary(Of String, String) From {
            {"Default", "NULL"},
            {"Center", Chr(34) & "center" & Chr(34)},
            {"Left", Chr(34) & "left" & Chr(34)},
            {"Right", Chr(34) & "right" & Chr(34)},
            {"Justify", Chr(34) & "justify" & Chr(34)}
        }
        ucrCboAlignHorizontal.SetDropDownStyleAsNonEditable()
        ucrCboAlignHorizontal.SetParameter(New RParameter("text.align"))
        ucrCboAlignHorizontal.SetItems(dctAlign)
        ucrCboAlignHorizontal.SetRDefault("NULL")

    End Sub

    Public Sub Setup(clsNewStyleRFunction As RFunction)

        If Not bDialogInitised Then
            InitialiseDialog()
            bDialogInitised = True
        End If

        ucrCboFontFamily.SetRCode(clsNewStyleRFunction, bReset:=True)
        ucrCboFontStyle.SetRCode(clsNewStyleRFunction, bReset:=True)
        ucrCboFontWeight.SetRCode(clsNewStyleRFunction, bReset:=True)
        ucrTxtFontSize.SetRCode(clsNewStyleRFunction, bReset:=True)

        ucrCboColorText.SetRCode(clsNewStyleRFunction, bReset:=True)
        ucrCboColorBackground.SetRCode(clsNewStyleRFunction, bReset:=True)

        ucrCboUnderlineType.SetRCode(clsNewStyleRFunction, bReset:=True)
        ucrCboUnderlineStyle.SetRCode(clsNewStyleRFunction, bReset:=True)
        ucrCboUnderLineColor.SetRCode(clsNewStyleRFunction, bReset:=True)

        ucrCboAlignHorizontal.SetRCode(clsNewStyleRFunction, bReset:=True)
    End Sub

End Class