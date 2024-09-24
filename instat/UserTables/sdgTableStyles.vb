Imports instat.Translations

Public Class sdgTableStyles
    Private clsStyleListRFunction, clsCellTextRFunction, clsCellFillRFunction, clsCellBordersRFunction, clsCellBorderSidesRFunction As New RFunction
    Private bFirstload As Boolean = True
    Private bUserClickedReturn As Boolean = False

    Private Sub sdgTableTextFormatOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If

        SetRCode()

        bUserClickedReturn = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseSubdialog.iHelpTopicID = 150

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
        ucrCboAlignVertical.SetParameter(New RParameter("v_align", iNewPosition:=4))
        ucrCboAlignVertical.SetItems(dctAlignVertical)
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
            {"None", "NULL"},
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
        ucrCboTransform.SetDropDownStyleAsNonEditable()
        ucrCboTransform.SetParameter(New RParameter("transform", iNewPosition:=9))
        ucrCboTransform.SetItems(dctTransform)
        ucrCboTransform.SetRDefault("NULL")
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
        ucrNudIndent.SetParameter(New RParameter("indent", iNewPosition:=11))
        ucrNudIndent.SetRDefault(0)
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
        ucrCboWhiteSpace.SetDropDownStyleAsNonEditable()
        ucrCboWhiteSpace.SetParameter(New RParameter("transform", iNewPosition:=11))
        ucrCboWhiteSpace.SetItems(dctWhiteSpace)
        ucrCboWhiteSpace.SetRDefault("NULL")
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
        ucrChkBorderLeft.SetText("Left")
        ucrChkBorderLeft.SetParameter(New RParameter("left", iNewPosition:=0, bNewIncludeArgumentName:=False))
        ucrChkBorderLeft.SetValuesCheckedAndUnchecked(Chr(34) & "left" & Chr(34), "NULL")
        ucrChkBorderLeft.SetRDefault("NULL")

        ucrChkBorderRight.SetText("Right")
        ucrChkBorderRight.SetParameter(New RParameter("right", iNewPosition:=1, bNewIncludeArgumentName:=False))
        ucrChkBorderRight.SetValuesCheckedAndUnchecked(Chr(34) & "right" & Chr(34), "NULL")
        ucrChkBorderRight.SetRDefault("NULL")

        ucrChkBorderTop.SetText("Top")
        ucrChkBorderTop.SetParameter(New RParameter("top", iNewPosition:=2, bNewIncludeArgumentName:=False))
        ucrChkBorderTop.SetValuesCheckedAndUnchecked(Chr(34) & "top" & Chr(34), "NULL")
        ucrChkBorderTop.SetRDefault("NULL")

        ucrChkBorderBottom.SetText("Bottom")
        ucrChkBorderBottom.SetParameter(New RParameter("bottom", iNewPosition:=3, bNewIncludeArgumentName:=False))
        ucrChkBorderBottom.SetValuesCheckedAndUnchecked(Chr(34) & "bottom" & Chr(34), "NULL")
        ucrChkBorderBottom.SetRDefault("NULL")

        '-----------------
        ucrCboBorderColor.SetDropDownStyleAsNonEditable()
        ucrCboBorderColor.SetParameter(New RParameter("color", iNewPosition:=1))
        ucrCboBorderColor.SetColours()
        ucrCboBorderColor.SetRDefault("NULL")
        '-----------------

        '-----------------
        Dim dctBorderStyle As New Dictionary(Of String, String) From {
          {"Default", "solid"},
          {"Solid", Chr(34) & "solid" & Chr(34)},
          {"Dashed", Chr(34) & "dashed" & Chr(34)},
          {"Dotted", Chr(34) & "dotted" & Chr(34)}
      }
        ucrCboBorderStyle.SetDropDownStyleAsNonEditable()
        ucrCboBorderStyle.SetParameter(New RParameter("style", iNewPosition:=2))
        ucrCboBorderStyle.SetItems(dctBorderStyle)
        ucrCboBorderStyle.SetRDefault("solid")
        '-----------------

        '-----------------
        ucrNudBorderWeight.SetParameter(New RParameter("weight", iNewPosition:=3))
        ucrNudBorderWeight.SetRDefault(1)
        '-----------------

        '---------------------------------------------------

    End Sub

    Public Sub Setup(Optional clsNewStyleListRFunction As RFunction = Nothing)
        clsStyleListRFunction = New RFunction
        clsCellTextRFunction = New RFunction
        clsCellFillRFunction = New RFunction
        clsCellBordersRFunction = New RFunction
        clsCellBorderSidesRFunction = New RFunction

        clsStyleListRFunction.SetRCommand("list")

        clsCellTextRFunction.SetPackageName("gt")
        clsCellTextRFunction.SetRCommand("cell_text")

        clsCellFillRFunction.SetPackageName("gt")
        clsCellFillRFunction.SetRCommand("cell_fill")

        clsCellBordersRFunction.SetPackageName("gt")
        clsCellBordersRFunction.SetRCommand("cell_borders")

        clsCellBorderSidesRFunction.SetRCommand("c")

        ucrTxtFontSize.SetName("")

        If clsNewStyleListRFunction IsNot Nothing Then
            clsStyleListRFunction = clsNewStyleListRFunction

            If clsStyleListRFunction.ContainsParameter("cell_text_param") Then
                clsCellTextRFunction = clsStyleListRFunction.GetParameter("cell_text_param").clsArgumentCodeStructure
                Dim sizeValue As String = clsCellTextRFunction.GetParameter("size")?.clsArgumentCodeStructure.GetParameter("x")?.strArgumentValue
                ucrTxtFontSize.SetName(If(sizeValue IsNot Nothing, sizeValue, ""))
            End If

            If clsStyleListRFunction.ContainsParameter("cell_fill_param") Then
                clsCellFillRFunction = clsStyleListRFunction.GetParameter("cell_fill_param").clsArgumentCodeStructure
            End If

            If clsStyleListRFunction.ContainsParameter("cell_borders_param") Then
                clsCellBordersRFunction = clsStyleListRFunction.GetParameter("cell_borders_param").clsArgumentCodeStructure
                If clsCellBordersRFunction.ContainsParameter("sides") Then
                    clsCellBordersRFunction = clsCellBordersRFunction.GetParameter("sides").clsArgumentCodeStructure
                End If
            End If

        End If
    End Sub

    Public Function GetNewUserInputAsRFunction() As RFunction
        If Not bUserClickedReturn Then
            Return Nothing
        End If

        If clsCellTextRFunction.clsParameters.Count > 0 Then
            clsStyleListRFunction.AddParameter(strParameterName:="cell_text_param", clsRFunctionParameter:=clsCellTextRFunction, bIncludeArgumentName:=False, iPosition:=0)
        End If

        If clsCellFillRFunction.clsParameters.Count > 0 Then
            clsStyleListRFunction.AddParameter(strParameterName:="cell_fill_param", clsRFunctionParameter:=clsCellFillRFunction, bIncludeArgumentName:=False, iPosition:=1)
        End If

        If clsCellBordersRFunction.clsParameters.Count > 0 OrElse clsCellBorderSidesRFunction.clsParameters.Count > 0 Then
            If clsCellBorderSidesRFunction.clsParameters.Count > 0 Then
                clsCellBordersRFunction.AddParameter(strParameterName:="sides", clsRFunctionParameter:=clsCellBorderSidesRFunction, iPosition:=0)
            End If
            clsStyleListRFunction.AddParameter(strParameterName:="cell_borders_param", clsRFunctionParameter:=clsCellBordersRFunction, bIncludeArgumentName:=False, iPosition:=1)
        End If

        Return If(clsStyleListRFunction.clsParameters.Count > 0, clsStyleListRFunction, Nothing)
    End Function


    Private Sub SetRCode()
        '-----------------
        ' Cell text controls
        ucrCboFontFamily.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboFontStyle.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboFontWeight.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboColorText.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboUnderlineType.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        'ucrCboUnderlineStyle.SetRCode(clsNewStyleRFunction, bReset:=False, bCloneIfNeeded:=True)
        'ucrCboUnderLineColor.SetRCode(clsNewStyleRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboAlignHorizontal.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboAlignVertical.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboTransform.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboWhiteSpace.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboStretch.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        'ucrTxtIndent.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrNudIndent.SetRCode(clsCellTextRFunction, bReset:=False, bCloneIfNeeded:=True)
        '-----------------

        '-----------------
        'Cell fill controls
        ucrCboColorBackground.SetRCode(clsCellFillRFunction, bReset:=False, bCloneIfNeeded:=True)
        '-----------------

        '-----------------
        'Cell border controls
        ucrChkBorderLeft.SetRCode(clsCellBorderSidesRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrChkBorderRight.SetRCode(clsCellBorderSidesRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrChkBorderTop.SetRCode(clsCellBorderSidesRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrChkBorderBottom.SetRCode(clsCellBorderSidesRFunction, bReset:=False, bCloneIfNeeded:=True)

        ucrCboBorderColor.SetRCode(clsCellBordersRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrCboBorderStyle.SetRCode(clsCellBordersRFunction, bReset:=False, bCloneIfNeeded:=True)
        ucrNudBorderWeight.SetRCode(clsCellBordersRFunction, bReset:=False, bCloneIfNeeded:=True)
        '-----------------
    End Sub


    Private Sub ucrBaseSubdialog_ClickReturn(sender As Object, e As EventArgs) Handles ucrBaseSubdialog.ClickReturn
        bUserClickedReturn = True
    End Sub

    Private Sub ucrTxtFontSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrTxtFontSize.ControlValueChanged
        If ucrTxtFontSize.IsEmpty Then
            clsCellTextRFunction.RemoveParameterByName("size")
        Else
            Dim pxRFunction As New RFunction
            pxRFunction.SetPackageName("gt")
            pxRFunction.SetRCommand("px")
            pxRFunction.AddParameter(strParameterName:="x", strParameterValue:=ucrTxtFontSize.GetText(), bIncludeArgumentName:=False, iPosition:=2)
            clsCellTextRFunction.AddParameter(strParameterName:="size", clsRFunctionParameter:=pxRFunction)
        End If
    End Sub



End Class