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
Imports instat
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
        'X-Axis tab
        Dim dctucrInputColour As New Dictionary(Of String, String)
        Dim dctucrInputColourTopAxis As New Dictionary(Of String, String)
        Dim dctucrInputColourSegment As New Dictionary(Of String, String)
        Dim dctucrInputFace As New Dictionary(Of String, String)
        Dim dctucrInputFaceTopAxis As New Dictionary(Of String, String)
        Dim dctucrInputFamily As New Dictionary(Of String, String)
        Dim dctucrInputFamilyTopAxis As New Dictionary(Of String, String)
        Dim dctucrInputLineType As New Dictionary(Of String, String)
        Dim dctucrInputLineTypeXTickMarks As New Dictionary(Of String, String)
        Dim dctucrInputColourXTickMarks As New Dictionary(Of String, String)
        Dim dctucrInputLineEnd As New Dictionary(Of String, String)
        Dim dctucrInputLineEndXTickMarks As New Dictionary(Of String, String)

        'Y -Axis tab
        Dim dctucrInputColourYAxis As New Dictionary(Of String, String)
        Dim dctucrInputColourTopYAxis As New Dictionary(Of String, String)
        'Dim dctucrInputColour As New Dictionary(Of String, String)
        Dim dctucrInputFaceYAxis As New Dictionary(Of String, String)
        Dim dctucrInputFaceTopYAxis As New Dictionary(Of String, String)
        Dim dctucrInputFamilyYAxis As New Dictionary(Of String, String)
        Dim dctucrInputFamilyTopYAxis As New Dictionary(Of String, String)
        Dim dctucrInputLineTypeTickLabelsYAxis As New Dictionary(Of String, String)
        Dim dctucrInputLineEndTickLabelsYAxis As New Dictionary(Of String, String)
        Dim dctucrInputColourTickMarksYAxis As New Dictionary(Of String, String)
        'Dim dctucrInputColourTickMarksYAxis As New Dictionary(Of String, String)
        Dim dctucrInputColourTickLabelsYAxis As New Dictionary(Of String, String)
        Dim dctucrInputLineTypeTickMarksYAxis As New Dictionary(Of String, String)
        Dim dctucrInputLineEndTickMarksYAxis As New Dictionary(Of String, String)

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
        dctucrInputFace.Add("Plain", Chr(34) & "plain" & Chr(34))
        dctucrInputFace.Add("Bold", Chr(34) & "bold" & Chr(34))
        dctucrInputFace.Add("Italic", Chr(34) & "italic" & Chr(34))
        dctucrInputFace.Add("Bold italic", Chr(34) & "bold.italic" & Chr(34))
        ucrInputFace.SetItems(dctucrInputFace)
        ucrInputFace.SetRDefault(Chr(34) & "plain" & Chr(34))

        ucrChkColour.SetText("Colour")
        ucrInputColour.SetParameter(New RParameter("colour"))
        dctucrInputColour.Add("Black", Chr(34) & "black" & Chr(34))
        dctucrInputColour.Add("Red", Chr(34) & "red" & Chr(34))
        dctucrInputColour.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctucrInputColour.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctucrInputColour.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctucrInputColour.Add("Yellow-Green", Chr(34) & "yellowgreen" & Chr(34))
        ucrInputColour.SetItems(dctucrInputColour)
        ucrInputColour.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkFamily.SetText("Family")
        ucrInputFamily.SetParameter(New RParameter("family"))
        dctucrInputFamily.Add("Times Roman", Chr(34) & "Times" & Chr(34))
        dctucrInputFamily.Add("Courier", Chr(34) & "Courier" & Chr(34))
        dctucrInputFamily.Add("Couriersans", Chr(34) & "Couriersans" & Chr(34))
        dctucrInputFamily.Add("Serif", Chr(34) & "serif" & Chr(34))
        dctucrInputFamily.Add("NimbusSanCond", Chr(34) & "NimbusSanCond" & Chr(34))
        dctucrInputFamily.Add("CenturySch", Chr(34) & "CenturySch" & Chr(34))
        dctucrInputFamily.Add("NewCenturySchoolbook", Chr(34) & "NewCenturySchoolbook" & Chr(34))
        dctucrInputFamily.Add("Palatino", Chr(34) & "Palatino" & Chr(34))
        dctucrInputFamily.Add("Bookman", Chr(34) & "Bookman" & Chr(34))
        dctucrInputFamily.Add("URWBookman", Chr(34) & "URWBookman" & Chr(34))
        dctucrInputFamily.Add("URWGothic", Chr(34) & "URWGothic" & Chr(34))
        dctucrInputFamily.Add("NimbusRom", Chr(34) & "NimbusRom" & Chr(34))
        dctucrInputFamily.Add("URWPalladioURWTimes", Chr(34) & "URWPalladioURWTimes" & Chr(34))
        dctucrInputFamily.Add("NimbusMonURWHelvetica", Chr(34) & "NimbusMonURWHelvetica" & Chr(34))
        dctucrInputFamily.Add("Helvetica - Narrow", Chr(34) & "Helvetica - Narrow" & Chr(34))
        dctucrInputFamily.Add("Helveticaserif", Chr(34) & "Helveticaserif" & Chr(34))
        dctucrInputFamily.Add("Short", Chr(34) & "Short" & Chr(34))
        dctucrInputFamily.Add("Canonicalmono", Chr(34) & "Canonicalmono" & Chr(34))
        dctucrInputFamily.Add("AvantGarde", Chr(34) & "AvantGarde" & Chr(34))
        ucrInputFamily.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFonts))
        ucrInputFamily.SetRDefault(Chr(34) & "Times" & Chr(34))

        'Tick Marks Along Axes
        ucrChkSizeTickMarksXAxis.SetText("Size")
        ucrNudSizeTickMarks.SetParameter(New RParameter("size"))
        ucrNudSizeTickMarks.Increment = 0.1


        ucrChkLineTypeTickMarksXAxis.SetText("Line Type")
        ucrInputLineTypeTickMarks.SetParameter(New RParameter("linetype"))
        dctucrInputLineType.Add("Blank", Chr(34) & "blank" & Chr(34))
        dctucrInputLineType.Add("Solid", Chr(34) & "solid" & Chr(34))
        dctucrInputLineType.Add("Dashed", Chr(34) & "dashed" & Chr(34))
        dctucrInputLineType.Add("Dotted", Chr(34) & "dotted" & Chr(34))
        dctucrInputLineType.Add("Dot-dash", Chr(34) & "dotdash" & Chr(34))
        dctucrInputLineType.Add("Long-dash", Chr(34) & "longdash" & Chr(34))
        dctucrInputLineType.Add("Two-Dash", Chr(34) & "twodash" & Chr(34))
        dctucrInputLineType.Add("1F", Chr(34) & "1F" & Chr(34))
        dctucrInputLineType.Add("F1", Chr(34) & "F1" & Chr(34))
        dctucrInputLineType.Add("4C88C488", Chr(34) & "4C88C488" & Chr(34))
        dctucrInputLineType.Add("12345678", Chr(34) & "12345678" & Chr(34))
        ucrInputLineTypeTickMarks.SetItems(dctucrInputLineType)
        ucrInputLineTypeTickMarks.SetRDefault(Chr(34) & "blank" & Chr(34))

        ucrChkColourTickMarksXAxis.SetText("Colour")
        ucrInputColourTickMarks.SetParameter(New RParameter("colour"))
        dctucrInputColourSegment.Add("Black", Chr(34) & "black" & Chr(34))
        dctucrInputColourSegment.Add("Red", Chr(34) & "red" & Chr(34))
        dctucrInputColourSegment.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctucrInputColourSegment.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctucrInputColourSegment.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctucrInputColourSegment.Add("Yellow-Green", Chr(34) & "yellowgreen" & Chr(34))
        ucrInputColourTickMarks.SetItems(dctucrInputColourSegment)
        ucrInputColourTickMarks.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkLineEndTickMarksXAxis.SetText("Line End")
        ucrInputLineEndTickMarks.SetParameter(New RParameter("lineend"))
        '  dctucrInputLineEnd.Add("NULL", Chr(34) & "NULL" & Chr(34))
        dctucrInputLineEnd.Add("round", Chr(34) & "round" & Chr(34))
        dctucrInputLineEnd.Add("butt", Chr(34) & "butt" & Chr(34))
        dctucrInputLineEnd.Add("square", Chr(34) & "square" & Chr(34))
        ucrInputLineEndTickMarks.SetItems(dctucrInputLineEnd)
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
        dctucrInputFaceTopAxis.Add("Plain", Chr(34) & "plain" & Chr(34))
        dctucrInputFaceTopAxis.Add("Bold", Chr(34) & "bold" & Chr(34))
        dctucrInputFaceTopAxis.Add("Italic", Chr(34) & "italic" & Chr(34))
        dctucrInputFaceTopAxis.Add("Bold italic", Chr(34) & "bold.italic" & Chr(34))
        ucrInputFaceTopAxis.SetItems(dctucrInputFaceTopAxis)
        ucrInputFaceTopAxis.SetRDefault(Chr(34) & "plain" & Chr(34))

        ucrChkColourTopXAxis.SetText("colour")
        ucrInputColourTopAxis.SetParameter(New RParameter("colour"))
        dctucrInputColourTopAxis.Add("Black", Chr(34) & "black" & Chr(34))
        dctucrInputColourTopAxis.Add("Red", Chr(34) & "red" & Chr(34))
        dctucrInputColourTopAxis.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctucrInputColourTopAxis.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctucrInputColourTopAxis.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctucrInputColourTopAxis.Add("Yellow-Green", Chr(34) & "yellowgreen" & Chr(34))
        ucrInputColourTopAxis.SetItems(dctucrInputColourTopAxis)
        ucrInputColourTopAxis.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkFamilyTopXAxis.SetText("Family")
        ucrInputFamilyTopAxis.SetParameter(New RParameter("family"))
        dctucrInputFamilyTopAxis.Add("Times Roman", Chr(34) & "Times" & Chr(34))
        dctucrInputFamilyTopAxis.Add("Courier", Chr(34) & "Courier" & Chr(34))
        dctucrInputFamilyTopAxis.Add("Couriersans", Chr(34) & "Couriersans" & Chr(34))
        dctucrInputFamilyTopAxis.Add("Serif", Chr(34) & "serif" & Chr(34))
        dctucrInputFamilyTopAxis.Add("NimbusSanCond", Chr(34) & "NimbusSanCond" & Chr(34))
        dctucrInputFamilyTopAxis.Add("CenturySch", Chr(34) & "CenturySch" & Chr(34))
        dctucrInputFamilyTopAxis.Add("NewCenturySchoolbook", Chr(34) & "NewCenturySchoolbook" & Chr(34))
        dctucrInputFamilyTopAxis.Add("Palatino", Chr(34) & "Palatino" & Chr(34))
        dctucrInputFamilyTopAxis.Add("Bookman", Chr(34) & "Bookman" & Chr(34))
        dctucrInputFamilyTopAxis.Add("URWBookman", Chr(34) & "URWBookman" & Chr(34))
        dctucrInputFamilyTopAxis.Add("URWGothic", Chr(34) & "URWGothic" & Chr(34))
        dctucrInputFamilyTopAxis.Add("NimbusRom", Chr(34) & "NimbusRom" & Chr(34))
        dctucrInputFamilyTopAxis.Add("URWPalladioURWTimes", Chr(34) & "URWPalladioURWTimes" & Chr(34))
        dctucrInputFamilyTopAxis.Add("NimbusMonURWHelvetica", Chr(34) & "NimbusMonURWHelvetica" & Chr(34))
        dctucrInputFamilyTopAxis.Add("Helvetica - Narrow", Chr(34) & "Helvetica - Narrow" & Chr(34))
        dctucrInputFamilyTopAxis.Add("Helveticaserif", Chr(34) & "Helveticaserif" & Chr(34))
        dctucrInputFamilyTopAxis.Add("Short", Chr(34) & "Short" & Chr(34))
        dctucrInputFamilyTopAxis.Add("Canonicalmono", Chr(34) & "Canonicalmono" & Chr(34))
        dctucrInputFamilyTopAxis.Add("AvantGarde", Chr(34) & "AvantGarde" & Chr(34))
        ucrInputFamilyTopAxis.SetItems(dctucrInputFamilyTopAxis)
        ucrInputFamilyTopAxis.SetRDefault(Chr(34) & "Times" & Chr(34))

        'Tick Marks Along Axes
        ucrChkSizeTickLabelsXAxis.SetText("Size")
        ucrNudSizeTickLabelsXAxis.SetParameter(New RParameter("size"))
        ucrNudSizeTickLabelsXAxis.Increment = 0.1

        ucrChkLineTypeTickLabelsXAxis.SetText("Line Type")
        ucrInputLineTypeTickLabelsXAxis.SetParameter(New RParameter("linetype"))
        dctucrInputLineTypeXTickMarks.Add("Blank", Chr(34) & "blank" & Chr(34))
        dctucrInputLineTypeXTickMarks.Add("Solid", Chr(34) & "solid" & Chr(34))
        dctucrInputLineTypeXTickMarks.Add("Dashed", Chr(34) & "dashed" & Chr(34))
        dctucrInputLineTypeXTickMarks.Add("Dotted", Chr(34) & "dotted" & Chr(34))
        dctucrInputLineTypeXTickMarks.Add("Dot-dash", Chr(34) & "dotdash" & Chr(34))
        dctucrInputLineTypeXTickMarks.Add("Long-dash", Chr(34) & "longdash" & Chr(34))
        dctucrInputLineTypeXTickMarks.Add("Two-Dash", Chr(34) & "twodash" & Chr(34))
        dctucrInputLineTypeXTickMarks.Add("1F", Chr(34) & "1F" & Chr(34))
        dctucrInputLineTypeXTickMarks.Add("F1", Chr(34) & "F1" & Chr(34))
        dctucrInputLineTypeXTickMarks.Add("4C88C488", Chr(34) & "4C88C488" & Chr(34))
        dctucrInputLineTypeXTickMarks.Add("12345678", Chr(34) & "12345678" & Chr(34))
        ucrInputLineTypeTickLabelsXAxis.SetItems(dctucrInputLineTypeXTickMarks)
        ucrInputLineTypeTickLabelsXAxis.SetRDefault(Chr(34) & "blank" & Chr(34))

        ucrChkColourTickLabelsXAxis.SetText("Colour")
        ucrInputColourTickLabelsXAxis.SetParameter(New RParameter("colour"))
        dctucrInputColourXTickMarks.Add("Black", Chr(34) & "black" & Chr(34))
        dctucrInputColourXTickMarks.Add("Red", Chr(34) & "red" & Chr(34))
        dctucrInputColourXTickMarks.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctucrInputColourXTickMarks.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctucrInputColourXTickMarks.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctucrInputColourXTickMarks.Add("Yellow-Green", Chr(34) & "yellowgreen" & Chr(34))
        ucrInputColourTickLabelsXAxis.SetItems(dctucrInputColourXTickMarks)
        ucrInputColourTickLabelsXAxis.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkLineEndTickLabelsXAxis.SetText("Line End")
        ucrInputLineEndTickLabelsXAxis.SetParameter(New RParameter("lineend"))
        'dctucrInputLineEndXTickMarks.Add("None", Chr(34) & "NULL" & Chr(34))
        dctucrInputLineEndXTickMarks.Add("round", Chr(34) & "round" & Chr(34))
        dctucrInputLineEndXTickMarks.Add("butt", Chr(34) & "butt" & Chr(34))
        dctucrInputLineEndXTickMarks.Add("square", Chr(34) & "square" & Chr(34))
        ucrInputLineEndTickLabelsXAxis.SetItems(dctucrInputLineEndXTickMarks)
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
        dctucrInputFaceYAxis.Add("Plain", Chr(34) & "plain" & Chr(34))
        dctucrInputFaceYAxis.Add("Bold", Chr(34) & "bold" & Chr(34))
        dctucrInputFaceYAxis.Add("Italic", Chr(34) & "italic" & Chr(34))
        dctucrInputFaceYAxis.Add("Bold italic", Chr(34) & "bold.italic" & Chr(34))
        ucrInputFaceYAxis.SetItems(dctucrInputFaceYAxis)
        ucrInputFaceYAxis.SetRDefault(Chr(34) & "plain" & Chr(34))

        ucrChkColourYAxis.SetText("Colour")
        ucrInputColourYAxis.SetParameter(New RParameter("colour"))
        dctucrInputColourYAxis.Add("Black", Chr(34) & "black" & Chr(34))
        dctucrInputColourYAxis.Add("Red", Chr(34) & "red" & Chr(34))
        dctucrInputColourYAxis.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctucrInputColourYAxis.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctucrInputColourYAxis.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctucrInputColourYAxis.Add("Yellow-Green", Chr(34) & "yellowgreen" & Chr(34))
        ucrInputColourYAxis.SetItems(dctucrInputColourYAxis)
        ucrInputColourYAxis.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkFamilyYAxis.SetText("Family")
        ucrInputFamilyYAxis.SetParameter(New RParameter("family"))
        dctucrInputFamilyYAxis.Add("Times Roman", Chr(34) & "Times" & Chr(34))
        dctucrInputFamilyYAxis.Add("Courier", Chr(34) & "Courier" & Chr(34))
        dctucrInputFamilyYAxis.Add("Couriersans", Chr(34) & "Couriersans" & Chr(34))
        dctucrInputFamilyYAxis.Add("Serif", Chr(34) & "serif" & Chr(34))
        dctucrInputFamilyYAxis.Add("NimbusSanCond", Chr(34) & "NimbusSanCond" & Chr(34))
        dctucrInputFamilyYAxis.Add("CenturySch", Chr(34) & "CenturySch" & Chr(34))
        dctucrInputFamilyYAxis.Add("NewCenturySchoolbook", Chr(34) & "NewCenturySchoolbook" & Chr(34))
        dctucrInputFamilyYAxis.Add("Palatino", Chr(34) & "Palatino" & Chr(34))
        dctucrInputFamilyYAxis.Add("Bookman", Chr(34) & "Bookman" & Chr(34))
        dctucrInputFamilyYAxis.Add("URWBookman", Chr(34) & "URWBookman" & Chr(34))
        dctucrInputFamilyYAxis.Add("URWGothic", Chr(34) & "URWGothic" & Chr(34))
        dctucrInputFamilyYAxis.Add("NimbusRom", Chr(34) & "NimbusRom" & Chr(34))
        dctucrInputFamilyYAxis.Add("URWPalladioURWTimes", Chr(34) & "URWPalladioURWTimes" & Chr(34))
        dctucrInputFamilyYAxis.Add("NimbusMonURWHelvetica", Chr(34) & "NimbusMonURWHelvetica" & Chr(34))
        dctucrInputFamilyYAxis.Add("Helvetica - Narrow", Chr(34) & "Helvetica - Narrow" & Chr(34))
        dctucrInputFamilyYAxis.Add("Helveticaserif", Chr(34) & "Helveticaserif" & Chr(34))
        dctucrInputFamilyYAxis.Add("Short", Chr(34) & "Short" & Chr(34))
        dctucrInputFamilyYAxis.Add("Canonicalmono", Chr(34) & "Canonicalmono" & Chr(34))
        dctucrInputFamilyYAxis.Add("AvantGarde", Chr(34) & "AvantGarde" & Chr(34))
        ucrInputFamilyYAxis.SetItems(dctucrInputFamilyYAxis)
        ucrInputFamilyYAxis.SetRDefault(Chr(34) & "Times" & Chr(34))

        'Tick Marks Along-Axes
        ucrChkSizeTickMarksYAxis.SetText("Size")
        ucrNudSizeTickMarksYAxis.SetParameter(New RParameter("size"))
        ucrNudSizeTickMarksYAxis.Increment = 0.1

        ucrChkLineTypeTickLabelsYAxis.SetText("Line Type")
        ucrInputLineTypeTickLabelsYAxis.SetParameter(New RParameter("linetype"))
        dctucrInputLineTypeTickLabelsYAxis.Add("Blank", Chr(34) & "blank" & Chr(34))
        dctucrInputLineTypeTickLabelsYAxis.Add("Solid", Chr(34) & "solid" & Chr(34))
        dctucrInputLineTypeTickLabelsYAxis.Add("Dashed", Chr(34) & "dashed" & Chr(34))
        dctucrInputLineTypeTickLabelsYAxis.Add("Dotted", Chr(34) & "dotted" & Chr(34))
        dctucrInputLineTypeTickLabelsYAxis.Add("Dot-dash", Chr(34) & "dotdash" & Chr(34))
        dctucrInputLineTypeTickLabelsYAxis.Add("Long-dash", Chr(34) & "longdash" & Chr(34))
        dctucrInputLineTypeTickLabelsYAxis.Add("Two-Dash", Chr(34) & "twodash" & Chr(34))
        dctucrInputLineTypeTickLabelsYAxis.Add("1F", Chr(34) & "1F" & Chr(34))
        dctucrInputLineTypeTickLabelsYAxis.Add("F1", Chr(34) & "F1" & Chr(34))
        dctucrInputLineTypeTickLabelsYAxis.Add("4C88C488", Chr(34) & "4C88C488" & Chr(34))
        dctucrInputLineTypeTickLabelsYAxis.Add("12345678", Chr(34) & "12345678" & Chr(34))
        ucrInputLineTypeTickLabelsYAxis.SetItems(dctucrInputLineTypeTickLabelsYAxis)
        ucrInputLineTypeTickLabelsYAxis.SetRDefault(Chr(34) & "blank" & Chr(34))

        ucrChkColourTickMarksYAxis.SetText("Colour")
        ucrInputColourTickMarksYAxis.SetParameter(New RParameter("colour"))
        dctucrInputColourTickMarksYAxis.Add("Black", Chr(34) & "black" & Chr(34))
        dctucrInputColourTickMarksYAxis.Add("Red", Chr(34) & "red" & Chr(34))
        dctucrInputColourTickMarksYAxis.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctucrInputColourTickMarksYAxis.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctucrInputColourTickMarksYAxis.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctucrInputColourTickMarksYAxis.Add("Yellow-Green", Chr(34) & "yellowgreen" & Chr(34))
        ucrInputColourTickMarksYAxis.SetItems(dctucrInputColourTickMarksYAxis)
        ucrInputColourTickMarksYAxis.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkLineEndTickLabelsYAxis.SetText("Line End")
        ucrInputLineEndTickLabelsYAxis.SetParameter(New RParameter("lineend"))
        '  dctucrInputLineEnd.Add("NULL", Chr(34) & "NULL" & Chr(34))
        dctucrInputLineEndTickLabelsYAxis.Add("round", Chr(34) & "round" & Chr(34))
        dctucrInputLineEndTickLabelsYAxis.Add("butt", Chr(34) & "butt" & Chr(34))
        dctucrInputLineEndTickLabelsYAxis.Add("square", Chr(34) & "square" & Chr(34))
        ucrInputLineEndTickLabelsYAxis.SetItems(dctucrInputLineEndTickLabelsYAxis)
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
        dctucrInputFaceTopYAxis.Add("Plain", Chr(34) & "plain" & Chr(34))
        dctucrInputFaceTopYAxis.Add("Bold", Chr(34) & "bold" & Chr(34))
        dctucrInputFaceTopYAxis.Add("Italic", Chr(34) & "italic" & Chr(34))
        dctucrInputFaceTopYAxis.Add("Bold italic", Chr(34) & "bold.italic" & Chr(34))
        ucrInputFaceRightYAxis.SetItems(dctucrInputFaceTopAxis)
        ucrInputFaceRightYAxis.SetRDefault(Chr(34) & "plain" & Chr(34))

        ucrChkColourRightYAxis.SetText("Colour")
        ucrInputColourRightYAxis.SetParameter(New RParameter("colour"))
        dctucrInputColourTopYAxis.Add("Black", Chr(34) & "black" & Chr(34))
        dctucrInputColourTopYAxis.Add("Red", Chr(34) & "red" & Chr(34))
        dctucrInputColourTopYAxis.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctucrInputColourTopYAxis.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctucrInputColourTopYAxis.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctucrInputColourTopYAxis.Add("Yellow-Green", Chr(34) & "yellowgreen" & Chr(34))
        ucrInputColourRightYAxis.SetItems(dctucrInputColourTopYAxis)
        ucrInputColourRightYAxis.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkFamilyRightYAxis.SetText("Family")
        ucrInputFamilyRightYAxis.SetParameter(New RParameter("family"))
        'dctucrInputFamilyYAxisTopAxis.Add("Times Roman", Chr(34) & "Times" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("Courier", Chr(34) & "Courier" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("Couriersans", Chr(34) & "Couriersans" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("Serif", Chr(34) & "serif" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("NimbusSanCond", Chr(34) & "NimbusSanCond" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("CenturySch", Chr(34) & "CenturySch" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("NewCenturySchoolbook", Chr(34) & "NewCenturySchoolbook" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("Palatino", Chr(34) & "Palatino" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("Bookman", Chr(34) & "Bookman" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("URWBookman", Chr(34) & "URWBookman" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("URWGothic", Chr(34) & "URWGothic" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("NimbusRom", Chr(34) & "NimbusRom" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("URWPalladioURWTimes", Chr(34) & "URWPalladioURWTimes" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("NimbusMonURWHelvetica", Chr(34) & "NimbusMonURWHelvetica" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("Helvetica - Narrow", Chr(34) & "Helvetica - Narrow" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("Helveticaserif", Chr(34) & "Helveticaserif" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("Short", Chr(34) & "Short" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("Canonicalmono", Chr(34) & "Canonicalmono" & Chr(34))
        dctucrInputFamilyTopYAxis.Add("AvantGarde", Chr(34) & "AvantGarde" & Chr(34))
        ucrInputFamilyRightYAxis.SetItems(dctucrInputFamilyTopYAxis)
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
        dctucrInputLineTypeTickMarksYAxis.Add("Blank", Chr(34) & "blank" & Chr(34))
        dctucrInputLineTypeTickMarksYAxis.Add("Solid", Chr(34) & "solid" & Chr(34))
        dctucrInputLineTypeTickMarksYAxis.Add("Dashed", Chr(34) & "dashed" & Chr(34))
        dctucrInputLineTypeTickMarksYAxis.Add("Dotted", Chr(34) & "dotted" & Chr(34))
        dctucrInputLineTypeTickMarksYAxis.Add("Dot-dash", Chr(34) & "dotdash" & Chr(34))
        dctucrInputLineTypeTickMarksYAxis.Add("Long-dash", Chr(34) & "longdash" & Chr(34))
        dctucrInputLineTypeTickMarksYAxis.Add("Two-Dash", Chr(34) & "twodash" & Chr(34))
        dctucrInputLineTypeTickMarksYAxis.Add("1F", Chr(34) & "1F" & Chr(34))
        dctucrInputLineTypeTickMarksYAxis.Add("F1", Chr(34) & "F1" & Chr(34))
        dctucrInputLineTypeTickMarksYAxis.Add("4C88C488", Chr(34) & "4C88C488" & Chr(34))
        dctucrInputLineTypeTickMarksYAxis.Add("12345678", Chr(34) & "12345678" & Chr(34))
        ucrInputLineTypeTickMarksYAxis.SetItems(dctucrInputLineTypeTickMarksYAxis)
        ucrInputLineTypeTickMarksYAxis.SetRDefault(Chr(34) & "blank" & Chr(34))

        ucrChkColourTickLabelsYAxis.SetText("Colour")
        ucrInputColourTickLabelsYAxis.SetParameter(New RParameter("colour"))
        dctucrInputColourTickLabelsYAxis.Add("Black", Chr(34) & "black" & Chr(34))
        dctucrInputColourTickLabelsYAxis.Add("Red", Chr(34) & "red" & Chr(34))
        dctucrInputColourTickLabelsYAxis.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctucrInputColourTickLabelsYAxis.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctucrInputColourTickLabelsYAxis.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctucrInputColourTickLabelsYAxis.Add("Yellow-Green", Chr(34) & "yellowgreen" & Chr(34))
        ucrInputColourTickLabelsYAxis.SetItems(dctucrInputColourTickMarksYAxis)
        ucrInputColourTickLabelsYAxis.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkLineEndTickMarksYAxis.SetText("Line End")
        ucrInputLineEndTickMarksYAxis.SetParameter(New RParameter("lineend"))
        'dctucrInputLineEndXTickMarks.Add("None", Chr(34) & "NULL" & Chr(34))
        dctucrInputLineEndTickMarksYAxis.Add("round", Chr(34) & "round" & Chr(34))
        dctucrInputLineEndTickMarksYAxis.Add("butt", Chr(34) & "butt" & Chr(34))
        dctucrInputLineEndTickMarksYAxis.Add("square", Chr(34) & "square" & Chr(34))
        ucrInputLineEndTickMarksYAxis.SetItems(dctucrInputLineEndTickMarksYAxis)
        ucrInputLineEndTickMarksYAxis.SetRDefault(Chr(34) & "square" & Chr(34))

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
        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        clsThemeFunction = clsNewThemeFunction

        dctThemeFunctions = dctNewThemeFunctions
        dctThemeFunctions.TryGetValue("axis.text.x", clsElementXAxisText)

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
    End Sub

    Private Sub AddRemoveElementXAxisText()
        If ucrChkAngle.Checked OrElse ucrChkHjust.Checked OrElse ucrChkLineHeight.Checked OrElse ucrChkSize.Checked OrElse ucrChkVjust.Checked OrElse ucrChkColour.Checked OrElse ucrChkFace.Checked OrElse ucrChkFamily.Checked Then
            clsThemeFunction.AddParameter("axis.text.x", clsRFunctionParameter:=clsElementXAxisText)
        Else
            clsThemeFunction.RemoveParameterByName("axis.text.x")
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