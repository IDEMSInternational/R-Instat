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
    Public clsTextTheme, clsSegmentTheme, clsGgThemes As New RFunction
    Private clsBaseOperator As New ROperator
    Private Sub sdgThemes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub lblHjust_Click(sender As Object, e As EventArgs) Handles lblHjust.Click

    End Sub


    Public Sub InitialiseControls()
        Dim dctucrInputColour As New Dictionary(Of String, String)
        Dim dctucrInputColourSegment As New Dictionary(Of String, String)
        Dim dctucrInputFace As New Dictionary(Of String, String)
        Dim dctucrInputFamily As New Dictionary(Of String, String)
        Dim dctucrInputLineType As New Dictionary(Of String, String)
        Dim dctucrInputLineEnd As New Dictionary(Of String, String)

        'Text Theme
        ucrNudsize.SetParameter(New RParameter("size"))
        ucrNudAngle.SetParameter(New RParameter("angle"))
        ucrNudAngle.SetMinMax(0, 360)
        ucrNudHjust.SetParameter(New RParameter("hjust"))
        ucrNudHjust.Increment = 0.1
        ucrNudHjust.SetMinMax(0, 1)
        ucrNudVjust.SetParameter(New RParameter("vjust"))
        ucrNudVjust.Increment = 0.1
        ucrNudVjust.SetMinMax(0, 1)
        ucrNudLineHeight.SetParameter(New RParameter("lineheight"))

        ucrInputColour.SetParameter(New RParameter("colour"))
        ucrInputFace.SetParameter(New RParameter("face"))
        ucrInputFamily.SetParameter(New RParameter("family"))

        dctucrInputFace.Add("Plain", Chr(34) & "plain" & Chr(34))
        dctucrInputFace.Add("Bold", Chr(34) & "bold" & Chr(34))
        dctucrInputFace.Add("Italic", Chr(34) & "italic" & Chr(34))
        dctucrInputFace.Add("Bold italic", Chr(34) & "bold.italic" & Chr(34))
        ucrInputFace.SetItems(dctucrInputFace)
        ucrInputFace.SetRDefault(Chr(34) & "plain" & Chr(34))

        dctucrInputColour.Add("Black", Chr(34) & "black" & Chr(34))
        dctucrInputColour.Add("Red", Chr(34) & "red" & Chr(34))
        dctucrInputColour.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctucrInputColour.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctucrInputColour.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctucrInputColour.Add("Yellow-Green", Chr(34) & "yellowgreen" & Chr(34))
        ucrInputColour.SetItems(dctucrInputColour)
        ucrInputColour.SetRDefault(Chr(34) & "black" & Chr(34))
        ucrInputColour.bUpdateRCodeFromControl = False

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
        ucrInputFamily.SetItems(dctucrInputFamily)
        ucrInputFamily.SetRDefault(Chr(34) & "Times" & Chr(34))
        ucrInputFamily.bUpdateRCodeFromControl = False

        'Segment Theme
        ucrNudSizeSegment.SetParameter(New RParameter("size"))

        ucrInputLineType.SetParameter(New RParameter("linetype"))
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
        ucrInputLineType.SetItems(dctucrInputLineType)
        ucrInputLineType.SetRDefault(Chr(34) & "blank" & Chr(34))
        ucrInputLineType.bUpdateRCodeFromControl = False

        ucrInputColourSegment.SetParameter(New RParameter("colour"))
        dctucrInputColourSegment.Add("Black", Chr(34) & "black" & Chr(34))
        dctucrInputColourSegment.Add("Red", Chr(34) & "red" & Chr(34))
        dctucrInputColourSegment.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctucrInputColourSegment.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctucrInputColourSegment.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctucrInputColourSegment.Add("Yellow-Green", Chr(34) & "yellowgreen" & Chr(34))
        ucrInputColourSegment.SetItems(dctucrInputColourSegment)
        ucrInputColourSegment.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrInputLineEnd.SetParameter(New RParameter("lineend"))
        dctucrInputLineEnd.Add("NULL", Chr(34) & "NULL" & Chr(34))
        dctucrInputLineEnd.Add("round", Chr(34) & "round" & Chr(34))
        dctucrInputLineEnd.Add("butt", Chr(34) & "butt" & Chr(34))
        dctucrInputLineEnd.Add("square", Chr(34) & "square" & Chr(34))
        ucrInputLineEnd.SetItems(dctucrInputLineEnd)
        ucrInputLineEnd.SetRDefault(Chr(34) & "NULL" & Chr(34))
        ucrInputLineEnd.bUpdateRCodeFromControl = False

        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsBaseOperator As ROperator, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If


        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsGgThemes, iPosition:=15)
        clsGgThemes.SetRCommand("theme")

        clsTextTheme.SetRCommand("element_text")
        clsSegmentTheme.SetRCommand("element_line")

        'For Setting default values for the nuds 
        '' clsTextTheme.AddParameter("size", 10)
        '' clsTextTheme.AddParameter("angle", 45)
        ''clsTextTheme.AddParameter("hjust", 0.5)
        ''clsTextTheme.AddParameter("vjust", 0.5)
        ''clsTextTheme.AddParameter("lineheight", 1.1)



        'For Setting default values for the nuds 
        '' clsSegmentTheme.AddParameter("size", 0.5)
        '' clsSegmentTheme.AddParameter("linetype", 1)
        clsGgThemes.AddParameter("axis.ticks", clsRFunctionParameter:=clsSegmentTheme)
        clsGgThemes.AddParameter("axis.title", clsRFunctionParameter:=clsTextTheme)
        clsGgThemes.AddParameter("axis.text.x", clsRFunctionParameter:=clsTextTheme)
        clsGgThemes.AddParameter("axis.text", clsRFunctionParameter:=clsTextTheme)
        clsGgThemes.AddParameter("axis.text", clsRFunctionParameter:=clsTextTheme)
        clsGgThemes.AddParameter("title", clsRFunctionParameter:=clsTextTheme)

        clsGgThemes.AddParameter("axis.title.y.right", clsRFunctionParameter:=clsTextTheme)
        clsGgThemes.AddParameter("axis.title.y", clsRFunctionParameter:=clsTextTheme)


        ucrNudAngle.SetRCode(clsTextTheme, bReset)
        ucrNudHjust.SetRCode(clsTextTheme, bReset)
        ucrNudLineHeight.SetRCode(clsTextTheme, bReset)
        ucrNudsize.SetRCode(clsTextTheme, bReset)
        ucrNudVjust.SetRCode(clsTextTheme, bReset)
        ucrInputColour.SetRCode(clsTextTheme, bReset)
        ucrInputFace.SetRCode(clsTextTheme, bReset)
        ucrInputFamily.SetRCode(clsTextTheme, bReset)

        ucrNudSizeSegment.SetRCode(clsSegmentTheme, bReset)
        ucrInputColourSegment.SetRCode(clsSegmentTheme, bReset)
        ucrInputLineType.SetRCode(clsSegmentTheme, bReset)
    End Sub

End Class