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

Public Class sdgThemes
    Public bControlsInitialised As Boolean = False
    Private clsElementXAxisText, clsElementXAxisTextTop, clsElementXAxisLine, clsElementYAxisLine, clsElementYAxisText, clsElementYAxisTextRight, clsElementXAxisLineTop, clsThemeFunction As New RFunction
    Private clsBaseOperator As New ROperator

    Private dctThemeFunctions As New Dictionary(Of String, RFunction)

    Private Sub sdgThemes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()

        'X axis Label
        ucrChkSize.SetText("Size")
        ucrNudsize.SetParameter(New RParameter("size"))
        ucrChkAngle.SetText("Angle")
        ucrNudAngle.SetParameter(New RParameter("angle"))
        ucrNudAngle.SetMinMax(0, 360)
        ucrChkHjust.SetText("Hjust")
        ucrNudHjust.SetParameter(New RParameter("hjust"))
        ucrNudHjust.Increment = 0.1
        ucrNudHjust.SetMinMax(0, 1)
        ucrChkVjust.SetText("Vjust")
        ucrNudVjust.SetParameter(New RParameter("vjust"))
        ucrNudVjust.Increment = 0.1
        ucrNudVjust.SetMinMax(0, 1)
        ucrChkLineHeight.SetText("Line Height")
        ucrNudLineHeight.SetParameter(New RParameter("lineheight"))

        ucrChkFace.SetText("Face")
        ucrInputFace.SetParameter(New RParameter("face"))
        ucrInputFace.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFontFace))
        ucrInputFace.SetRDefault(Chr(34) & "plain" & Chr(34))

        ucrChkColour.SetText("Colour")
        ucrInputColour.SetParameter(New RParameter("colour"))
        ucrInputColour.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputColour.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkFamily.SetText("Family")
        ucrInputFamily.SetParameter(New RParameter("family"))
        ucrInputFamily.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFonts))
        ucrInputFamily.SetRDefault(Chr(34) & "Times" & Chr(34))

        'Tick Marks Along Axes
        ucrChkSizeTickMarksXAxis.SetText("Size")
        ucrNudSizeTickMarks.SetParameter(New RParameter("size"))
        ucrNudSizeTickMarks.Increment = 0.1


        ucrChkLineTypeTickMarksXAxis.SetText("Line Type")
        ucrInputLineTypeTickMarks.SetParameter(New RParameter("linetype"))
        ucrInputLineTypeTickMarks.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        ucrInputLineTypeTickMarks.SetRDefault(Chr(34) & "blank" & Chr(34))

        ucrChkColourTickMarksXAxis.SetText("Colour")
        ucrInputColourTickMarks.SetParameter(New RParameter("colour"))
        ucrInputColourTickMarks.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputColourTickMarks.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkLineEndTickMarksXAxis.SetText("Line End")
        ucrInputLineEndTickMarks.SetParameter(New RParameter("lineend"))
        ucrInputLineEndTickMarks.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineEnd))
        ucrInputLineEndTickMarks.SetRDefault(Chr(34) & "square" & Chr(34))

        'X axis Label Top  Axis
        ucrChkSizeTopXAxis.SetText("Size")
        ucrNudSizeTopaxis.SetParameter(New RParameter("size"))
        ucrNudSizeTopaxis.Increment = 0.1
        ucrChkAngleTopXAxis.SetText("Angle")
        ucrNudAngleTopAxis.SetParameter(New RParameter("angle"))
        ucrNudAngleTopAxis.SetMinMax(0, 360)
        ucrChkHjustTopXAxis.SetText("Hjust")
        ucrNudHjustTopAxis.SetParameter(New RParameter("hjust"))
        ucrNudHjustTopAxis.Increment = 0.1
        ucrNudHjustTopAxis.SetMinMax(0, 1)
        ucrChkVjustTopXAxis.SetText("Vjust")
        ucrNudVjustTopAxis.SetParameter(New RParameter("vjust"))
        ucrNudVjustTopAxis.Increment = 0.1
        ucrNudVjustTopAxis.SetMinMax(0, 1)
        ucrChkLineHeightTopXAxis.SetText("Line Height")
        ucrNudLineHeightTopAxis.SetParameter(New RParameter("lineheight"))

        ucrChkFaceTopXAxis.SetText("Face")
        ucrInputFaceTopAxis.SetParameter(New RParameter("face"))
        ucrInputFaceTopAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFontFace))
        ucrInputFaceTopAxis.SetRDefault(Chr(34) & "plain" & Chr(34))

        ucrChkColourTopXAxis.SetText("colour")
        ucrInputColourTopAxis.SetParameter(New RParameter("colour"))
        ucrInputColourTopAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputColourTopAxis.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkFamilyTopXAxis.SetText("Family")
        ucrInputFamilyTopAxis.SetParameter(New RParameter("family"))
        ucrInputFamilyTopAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFonts))
        ucrInputFamilyTopAxis.SetRDefault(Chr(34) & "Times" & Chr(34))

        'Tick Marks Along Axes
        ucrChkSizeTickLabelsXAxis.SetText("Size")
        ucrNudSizeTickLabelsXAxis.SetParameter(New RParameter("size"))
        ucrNudSizeTickLabelsXAxis.Increment = 0.1

        ucrChkLineTypeTickLabelsXAxis.SetText("Line Type")
        ucrInputLineTypeTickLabelsXAxis.SetParameter(New RParameter("linetype"))
        ucrInputLineTypeTickLabelsXAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        ucrInputLineTypeTickLabelsXAxis.SetRDefault(Chr(34) & "blank" & Chr(34))

        ucrChkColourTickLabelsXAxis.SetText("Colour")
        ucrInputColourTickLabelsXAxis.SetParameter(New RParameter("colour"))
        ucrInputColourTickLabelsXAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputColourTickLabelsXAxis.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkLineEndTickLabelsXAxis.SetText("Line End")
        ucrInputLineEndTickLabelsXAxis.SetParameter(New RParameter("lineend"))
        ucrInputLineEndTickLabelsXAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputLineEndTickLabelsXAxis.SetRDefault(Chr(34) & "square" & Chr(34))

        'Linking
        ucrChkSize.AddToLinkedControls(ucrNudsize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkHjust.AddToLinkedControls(ucrNudHjust, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkVjust.AddToLinkedControls(ucrNudVjust, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineHeight.AddToLinkedControls(ucrNudLineHeight, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAngle.AddToLinkedControls(ucrNudAngle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFace.AddToLinkedControls(ucrInputFace, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFamily.AddToLinkedControls(ucrInputFamily, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColour.AddToLinkedControls(ucrInputColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSizeTopXAxis.AddToLinkedControls(ucrNudSizeTopaxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkHjustTopXAxis.AddToLinkedControls(ucrNudHjustTopAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkVjustTopXAxis.AddToLinkedControls(ucrNudVjustTopAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineHeightTopXAxis.AddToLinkedControls(ucrNudLineHeightTopAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAngleTopXAxis.AddToLinkedControls(ucrNudAngleTopAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFaceTopXAxis.AddToLinkedControls(ucrInputFaceTopAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFamilyTopXAxis.AddToLinkedControls(ucrInputFamilyTopAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColourTopXAxis.AddToLinkedControls(ucrInputColourTopAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSizeTickMarksXAxis.AddToLinkedControls(ucrNudSizeTickMarks, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineTypeTickMarksXAxis.AddToLinkedControls(ucrInputLineTypeTickMarks, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineEndTickMarksXAxis.AddToLinkedControls(ucrInputLineEndTickMarks, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColourTickMarksXAxis.AddToLinkedControls(ucrInputColourTickMarks, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSizeTickLabelsXAxis.AddToLinkedControls(ucrNudSizeTickLabelsXAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineTypeTickLabelsXAxis.AddToLinkedControls(ucrInputLineTypeTickLabelsXAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineEndTickLabelsXAxis.AddToLinkedControls(ucrInputLineEndTickLabelsXAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColourTickLabelsXAxis.AddToLinkedControls(ucrInputColourTickLabelsXAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'Y-axis Label
        ucrChkSizeYAxis.SetText("Size")
        ucrNudSizeYAxis.SetParameter(New RParameter("size"))
        ucrChkAngleYAxis.SetText("Angle")
        ucrNudAngleYAxis.SetParameter(New RParameter("angle"))
        ucrNudAngleYAxis.SetMinMax(0, 360)
        ucrChkHjustYAxis.SetText("Hjust")
        ucrNudHjustYAxis.SetParameter(New RParameter("hjust"))
        ucrNudHjustYAxis.Increment = 0.1
        ucrNudHjustYAxis.SetMinMax(0, 1)
        ucrChkVjustYAxis.SetText("Vjust")
        ucrNudVjustYAxis.SetParameter(New RParameter("vjust"))
        ucrNudVjustYAxis.Increment = 0.1
        ucrNudVjustYAxis.SetMinMax(0, 1)
        ucrChkLineHeightYAxis.SetText("Line Height")
        ucrNudLineHeightYAxis.SetParameter(New RParameter("lineheight"))

        ucrChkFaceYAxis.SetText("Face")
        ucrInputFaceYAxis.SetParameter(New RParameter("face"))
        ucrInputFaceYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFontFace))
        ucrInputFaceYAxis.SetRDefault(Chr(34) & "plain" & Chr(34))

        ucrChkColourYAxis.SetText("Colour")
        ucrInputColourYAxis.SetParameter(New RParameter("colour"))
        ucrInputColourYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputColourYAxis.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkFamilyYAxis.SetText("Family")
        ucrInputFamilyYAxis.SetParameter(New RParameter("family"))
        ucrInputFamilyYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFonts))
        ucrInputFamilyYAxis.SetRDefault(Chr(34) & "Times" & Chr(34))

        'Tick Marks Along-Axes
        ucrChkSizeTickMarksYAxis.SetText("Size")
        ucrNudSizeTickMarksYAxis.SetParameter(New RParameter("size"))
        ucrNudSizeTickMarksYAxis.Increment = 0.1

        ucrChkLineTypeTickLabelsYAxis.SetText("Line Type")
        ucrInputLineTypeTickLabelsYAxis.SetParameter(New RParameter("linetype"))

        ucrInputLineTypeTickLabelsYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        ucrInputLineTypeTickLabelsYAxis.SetRDefault(Chr(34) & "blank" & Chr(34))

        ucrChkColourTickMarksYAxis.SetText("Colour")
        ucrInputColourTickMarksYAxis.SetParameter(New RParameter("colour"))
        ucrInputColourTickMarksYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputColourTickMarksYAxis.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkLineEndTickLabelsYAxis.SetText("Line End")
        ucrInputLineEndTickLabelsYAxis.SetParameter(New RParameter("lineend"))
        ucrInputLineEndTickLabelsYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineEnd))
        ucrInputLineEndTickLabelsYAxis.SetRDefault(Chr(34) & "square" & Chr(34))

        'Y axis Label Top  Axis
        ucrChkSizeRightYAxis.SetText("Size")
        ucrNudSizeRightYAxis.SetParameter(New RParameter("size"))
        ucrNudSizeRightYAxis.Increment = 0.1
        ucrChkAngleRightYAxis.SetText("Angle")
        ucrNudAngleRightYAxis.SetParameter(New RParameter("angle"))
        ucrNudAngleRightYAxis.SetMinMax(0, 360)
        ucrChkHjustRightYAxis.SetText("Hjust")
        ucrNudHjustRightYAxis.SetParameter(New RParameter("hjust"))
        ucrNudHjustRightYAxis.Increment = 0.1
        ucrNudHjustRightYAxis.SetMinMax(0, 1)
        ucrChkVjustRightYAxis.SetText("Vjust")
        ucrNudHjustRightYAxis.SetParameter(New RParameter("vjust"))
        ucrNudVjustRightYAxis.Increment = 0.1
        ucrNudVjustRightYAxis.SetMinMax(0, 1)
        ucrChkLineHeightRightYAxis.SetText("Line Height")
        ucrNudLineHeightRightYAxis.SetParameter(New RParameter("lineheight"))

        ucrChkFaceRightYAxis.SetText("Face")
        ucrInputFaceRightYAxis.SetParameter(New RParameter("face"))
        ucrInputFaceRightYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFontFace))
        ucrInputFaceRightYAxis.SetRDefault(Chr(34) & "plain" & Chr(34))

        ucrChkColourRightYAxis.SetText("Colour")
        ucrInputColourRightYAxis.SetParameter(New RParameter("colour"))
        ucrInputColourRightYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputColourRightYAxis.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkFamilyRightYAxis.SetText("Family")
        ucrInputFamilyRightYAxis.SetParameter(New RParameter("family"))
        ucrInputFamilyRightYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFonts))
        ucrInputFamilyRightYAxis.SetRDefault(Chr(34) & "Times" & Chr(34))

        'Tick Marks Along Axes
        ucrChkSizeTickMarksYAxis.SetText("Size")
        ucrNudSizeTickMarksYAxis.SetParameter(New RParameter("size"))
        ucrNudSizeTickMarksYAxis.Increment = 0.1

        ucrChkSizeTickLabelsYAxis.SetText("Size")
        ucrNudSizeTickLabelsYAxis.SetParameter(New RParameter("size"))
        ucrNudSizeTickLabelsYAxis.Increment = 0.1

        ucrChkLineTypeTickMarksYAxis.SetText("Line Type")
        ucrInputLineTypeTickMarksYAxis.SetParameter(New RParameter("linetype"))
        ucrInputLineTypeTickMarksYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        ucrInputLineTypeTickMarksYAxis.SetRDefault(Chr(34) & "blank" & Chr(34))

        ucrChkColourTickLabelsYAxis.SetText("Colour")
        ucrInputColourTickLabelsYAxis.SetParameter(New RParameter("colour"))
        ucrInputColourTickLabelsYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputColourTickLabelsYAxis.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkLineEndTickMarksYAxis.SetText("Line End")
        ucrInputLineEndTickMarksYAxis.SetParameter(New RParameter("lineend"))
        ucrInputLineEndTickMarksYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineEnd))
        ucrInputLineEndTickMarksYAxis.SetRDefault(Chr(34) & "square" & Chr(34))

        'Units
        ucrChkUnits.SetText("Tick length")
        ucrInputTickUnits.SetParameter(New RParameter("units"))
        ucrInputTickUnits.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFonts))
        ucrInputTickUnits.SetRDefault(Chr(34) & "npc" & Chr(34))

        ucrChkSizeYAxis.AddToLinkedControls(ucrNudSizeYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkHjustYAxis.AddToLinkedControls(ucrNudHjustYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkVjustYAxis.AddToLinkedControls(ucrNudVjustYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineHeightYAxis.AddToLinkedControls(ucrNudLineHeightYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAngleYAxis.AddToLinkedControls(ucrNudAngleYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFaceYAxis.AddToLinkedControls(ucrInputFaceYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFamilyYAxis.AddToLinkedControls(ucrInputFamilyYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColourYAxis.AddToLinkedControls(ucrInputColourYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSizeRightYAxis.AddToLinkedControls(ucrNudSizeRightYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkHjustRightYAxis.AddToLinkedControls(ucrNudHjustRightYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkVjustRightYAxis.AddToLinkedControls(ucrNudVjustRightYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineHeightRightYAxis.AddToLinkedControls(ucrNudLineHeightRightYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAngleRightYAxis.AddToLinkedControls(ucrNudAngleRightYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFaceRightYAxis.AddToLinkedControls(ucrInputFaceRightYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFamilyRightYAxis.AddToLinkedControls(ucrInputFamilyRightYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColourRightYAxis.AddToLinkedControls(ucrInputColourRightYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSizeTickMarksYAxis.AddToLinkedControls(ucrNudSizeTickMarksYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineTypeTickMarksYAxis.AddToLinkedControls(ucrInputLineTypeTickMarksYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineEndTickMarksYAxis.AddToLinkedControls(ucrInputLineEndTickMarksYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColourTickMarksYAxis.AddToLinkedControls(ucrInputColourTickMarksYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSizeTickLabelsYAxis.AddToLinkedControls(ucrNudSizeTickLabelsYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineTypeTickLabelsYAxis.AddToLinkedControls(ucrInputLineTypeTickLabelsYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineEndTickLabelsYAxis.AddToLinkedControls(ucrInputLineEndTickLabelsYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColourTickLabelsYAxis.AddToLinkedControls(ucrInputColourTickLabelsYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Public Sub SetRCode(clsBaseOperator As ROperator, clsNewThemeFunction As RFunction, dctNewThemeFunctions As Dictionary(Of String, RFunction), Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsThemeFunction = clsNewThemeFunction
        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)


        dctThemeFunctions = dctNewThemeFunctions
        dctThemeFunctions.TryGetValue("axis.text.x", clsElementXAxisText)
        dctThemeFunctions.TryGetValue("axis.text.y", clsElementYAxisText)
        dctThemeFunctions.TryGetValue("axis.text.y", clsElementYAxisText)
        dctThemeFunctions.TryGetValue("axis.ticks.x", clsElementXAxisText)
        dctThemeFunctions.TryGetValue("axis.ticks.y", clsElementYAxisText)

        'clsElementXAxisText.SetRCommand("element_text")
        'clsElementXAxisTextTop.SetRCommand("element_text")
        'clsElementXAxisLine.SetRCommand("element_line")
        '' clsElementXAxisLineTop.SetRCommand("element_line")

        'clsElementYAxisText.SetRCommand("element_text")
        'clsElementYAxisTextRight.SetRCommand("element_text")
        'clsElementYAxisLine.SetRCommand("element_line")
        '' clsElementXAxisLineTop.SetRCommand("element_line")

        'clsThemeFunction.AddParameter("axis.ticks", clsRFunctionParameter:=clsElementXAxisLine)
        'clsThemeFunction.AddParameter("axis.ticks.x", clsRFunctionParameter:=clsElementXAxisLine)
        'clsThemeFunction.AddParameter("axis.text.x", clsRFunctionParameter:=clsElementXAxisText)
        'clsThemeFunction.AddParameter("axis.text.x.top", clsRFunctionParameter:=clsElementXAxisTextTop)

        ''clsGgThemes.AddParameter("axis.ticks", clsRFunctionParameter:=clsElementYAxisLine)
        'clsThemeFunction.AddParameter("axis.ticks.y", clsRFunctionParameter:=clsElementYAxisLine)
        'clsThemeFunction.AddParameter("axis.text.y", clsRFunctionParameter:=clsElementYAxisText)
        'clsThemeFunction.AddParameter("axis.text.y.right", clsRFunctionParameter:=clsElementYAxisTextRight)

        'X axis Label
        ucrNudAngle.SetRCode(clsElementXAxisText, bReset)
        ucrChkAngle.SetRCode(clsElementXAxisText, bReset)

        ucrNudHjust.SetRCode(clsElementXAxisText, bReset)
        ucrChkHjust.SetRCode(clsElementXAxisText, bReset)

        ucrNudLineHeight.SetRCode(clsElementXAxisText, bReset)
        ucrChkLineHeight.SetRCode(clsElementXAxisText, bReset)

        ucrNudsize.SetRCode(clsElementXAxisText, bReset)
        ucrChkSize.SetRCode(clsElementXAxisText, bReset)

        ucrNudVjust.SetRCode(clsElementXAxisText, bReset)
        ucrChkVjust.SetRCode(clsElementXAxisText, bReset)

        ucrInputColour.SetRCode(clsElementXAxisText, bReset)
        ucrChkColour.SetRCode(clsElementXAxisText, bReset)

        ucrInputFace.SetRCode(clsElementXAxisText, bReset)
        ucrChkFace.SetRCode(clsElementXAxisText, bReset)

        ucrInputFamily.SetRCode(clsElementXAxisText, bReset)
        ucrChkFamily.SetRCode(clsElementXAxisText, bReset)

        'X axis Label Top Axis
        ucrNudSizeTickMarks.SetRCode(clsElementXAxisLine, bReset)
        ucrChkSizeTickMarksXAxis.SetRCode(clsElementXAxisLine, bReset)

        ucrInputColourTickMarks.SetRCode(clsElementXAxisLine, bReset)
        ucrChkColourTickMarksXAxis.SetRCode(clsElementXAxisLine, bReset)

        ucrInputLineTypeTickMarks.SetRCode(clsElementXAxisLine, bReset)
        ucrChkLineTypeTickMarksXAxis.SetRCode(clsElementXAxisLine, bReset)

        ucrInputLineEndTickMarks.SetRCode(clsElementXAxisLine, bReset)
        ucrChkLineEndTickMarksXAxis.SetRCode(clsElementXAxisLine, bReset)

        ucrNudAngleTopAxis.SetRCode(clsElementXAxisTextTop, bReset)
        ucrChkAngleTopXAxis.SetRCode(clsElementXAxisTextTop, bReset)

        ucrNudHjustTopAxis.SetRCode(clsElementXAxisTextTop, bReset)
        ucrChkHjustTopXAxis.SetRCode(clsElementXAxisTextTop, bReset)

        ucrNudLineHeightTopAxis.SetRCode(clsElementXAxisTextTop, bReset)
        ucrChkLineHeightTopXAxis.SetRCode(clsElementXAxisTextTop, bReset)

        ucrNudSizeTopaxis.SetRCode(clsElementXAxisTextTop, bReset)
        ucrChkSizeTopXAxis.SetRCode(clsElementXAxisTextTop, bReset)

        ucrNudVjustTopAxis.SetRCode(clsElementXAxisTextTop, bReset)
        ucrChkVjustTopXAxis.SetRCode(clsElementXAxisTextTop, bReset)

        ucrInputColourTopAxis.SetRCode(clsElementXAxisTextTop, bReset)
        ucrChkColourTopXAxis.SetRCode(clsElementXAxisTextTop, bReset)

        ucrInputFaceTopAxis.SetRCode(clsElementXAxisTextTop, bReset)
        ucrChkFaceTopXAxis.SetRCode(clsElementXAxisTextTop, bReset)

        ucrInputFamilyTopAxis.SetRCode(clsElementXAxisTextTop, bReset)
        ucrChkFamilyTopXAxis.SetRCode(clsElementXAxisTextTop, bReset)

        ucrNudSizeTickLabelsXAxis.SetRCode(clsElementXAxisLine, bReset)
        ucrChkSizeTickLabelsXAxis.SetRCode(clsElementXAxisLine, bReset)

        ucrInputColourTickLabelsXAxis.SetRCode(clsElementXAxisLine, bReset)
        ucrChkColourTickLabelsXAxis.SetRCode(clsElementXAxisLine, bReset)

        ucrInputLineTypeTickLabelsXAxis.SetRCode(clsElementXAxisLine, bReset)
        ucrChkLineTypeTickLabelsXAxis.SetRCode(clsElementXAxisLine, bReset)

        ucrInputLineEndTickLabelsXAxis.SetRCode(clsElementXAxisLine, bReset)
        ucrChkLineEndTickLabelsXAxis.SetRCode(clsElementXAxisLine, bReset)

        'Y axis Label
        ucrNudAngleYAxis.SetRCode(clsElementYAxisText, bReset)
        ucrChkAngleYAxis.SetRCode(clsElementYAxisText, bReset)

        ucrNudHjustYAxis.SetRCode(clsElementYAxisText, bReset)
        ucrChkHjustYAxis.SetRCode(clsElementYAxisText, bReset)

        ucrNudLineHeightYAxis.SetRCode(clsElementYAxisText, bReset)
        ucrChkLineHeightYAxis.SetRCode(clsElementYAxisText, bReset)

        ucrNudSizeYAxis.SetRCode(clsElementYAxisText, bReset)
        ucrChkSizeYAxis.SetRCode(clsElementYAxisText, bReset)

        ucrNudVjustYAxis.SetRCode(clsElementYAxisText, bReset)
        ucrChkVjustYAxis.SetRCode(clsElementYAxisText, bReset)

        ucrInputColourYAxis.SetRCode(clsElementYAxisText, bReset)
        ucrChkColourYAxis.SetRCode(clsElementYAxisText, bReset)

        ucrInputFaceYAxis.SetRCode(clsElementYAxisText, bReset)
        ucrChkFaceYAxis.SetRCode(clsElementYAxisText, bReset)

        ucrInputFamilyYAxis.SetRCode(clsElementYAxisText, bReset)
        ucrChkFamilyYAxis.SetRCode(clsElementYAxisText, bReset)

        'X axis Label Top Axis
        ucrNudSizeTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkSizeTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)

        ucrInputColourTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkColourTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)

        ucrInputLineTypeTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkLineTypeTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)

        ucrInputLineEndTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkLineEndTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)

        ucrNudAngleRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)
        ucrChkAngleRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)

        ucrNudHjustRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)
        ucrChkHjustRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)

        ucrNudLineHeightRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)
        ucrChkLineHeightRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)

        ucrNudSizeRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)
        ucrChkSizeRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)

        ucrNudVjustRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)
        ucrChkVjustRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)

        ucrInputColourRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)
        ucrChkColourRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)

        ucrInputFaceRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)
        ucrChkFaceRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)

        ucrInputFamilyRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)
        ucrChkFamilyRightYAxis.SetRCode(clsElementYAxisTextRight, bReset)

        ucrNudSizeTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkSizeTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)

        ucrInputColourTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkColourTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)

        ucrInputLineTypeTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkLineTypeTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)

        ucrInputLineEndTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkLineEndTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)

        AddRemoveElementXAxisText()
        AddRemoveElementYAxisText()
        AddRemoveElementXTickLine()
        AddRemoveElementYTickLine()
    End Sub

    Private Sub AddRemoveElementXAxisText()
        If ucrChkAngle.Checked OrElse ucrChkHjust.Checked OrElse ucrChkLineHeight.Checked OrElse ucrChkSize.Checked OrElse ucrChkVjust.Checked OrElse ucrChkColour.Checked OrElse ucrChkFace.Checked OrElse ucrChkFamily.Checked Then
            clsThemeFunction.AddParameter("axis.text.x", clsRFunctionParameter:=clsElementXAxisText)
        Else
            clsThemeFunction.RemoveParameterByName("axis.text.x")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveElementYAxisText()
        If ucrChkAngle.Checked OrElse ucrChkHjust.Checked OrElse ucrChkLineHeight.Checked OrElse ucrChkSize.Checked OrElse ucrChkVjust.Checked OrElse ucrChkColour.Checked OrElse ucrChkFace.Checked OrElse ucrChkFamily.Checked Then
            clsThemeFunction.AddParameter("axis.text.y", clsRFunctionParameter:=clsElementXAxisText)
        Else
            clsThemeFunction.RemoveParameterByName("axis.text.y")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveElementYTickLine()
        If ucrChkAngle.Checked OrElse ucrChkHjust.Checked OrElse ucrChkLineHeight.Checked OrElse ucrChkSize.Checked OrElse ucrChkVjust.Checked OrElse ucrChkColour.Checked OrElse ucrChkFace.Checked OrElse ucrChkFamily.Checked Then
            clsThemeFunction.AddParameter("axis.ticks.y", clsRFunctionParameter:=clsElementXAxisText)
        Else
            clsThemeFunction.RemoveParameterByName("axis.ticks.y")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveElementXTickLine()
        If ucrChkAngle.Checked OrElse ucrChkHjust.Checked OrElse ucrChkLineHeight.Checked OrElse ucrChkSize.Checked OrElse ucrChkVjust.Checked OrElse ucrChkColour.Checked OrElse ucrChkFace.Checked OrElse ucrChkFamily.Checked Then
            clsThemeFunction.AddParameter("axis.ticks.x", clsRFunctionParameter:=clsElementXAxisText)
        Else
            clsThemeFunction.RemoveParameterByName("axis.ticks.x")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ElementXAxisTextControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAngle.ControlValueChanged, ucrChkHjust.ControlValueChanged 'etc. add all controls for "axis.text.x"
        AddRemoveElementXAxisText()
    End Sub
End Class