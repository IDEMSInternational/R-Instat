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
    Public clsTextTheme, clsSegmentTheme As New RFunction
    Private Sub sdgThemes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        'Text Theme
        ucrNudsize.SetParameter(New RParameter("size"))
        ucrNudAngle.SetParameter(New RParameter("angle"))
        ucrNudHjust.SetParameter(New RParameter("hjust"))
        ucrNudVjust.SetParameter(New RParameter("vjust"))
        ucrNudsize.SetParameter(New RParameter("lineheight"))

        ucrInputColour.SetParameter(New RParameter("colour"))
        ucrInputFace.SetParameter(New RParameter("face"))
        ucrInputFamily.SetParameter(New RParameter("family"))

        'Segment Theme
        ucrNudSizeSegment.SetParameter(New RParameter("size"))
        ucrInputLineType.SetParameter(New RParameter("linetype"))
        ucrInputColourSegment.SetParameter(New RParameter("colour"))

        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewTextTheme As RFunction, clsNewSegmentTheme As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsTextTheme = clsNewTextTheme
        clsSegmentTheme = clsNewSegmentTheme
    End Sub

End Class