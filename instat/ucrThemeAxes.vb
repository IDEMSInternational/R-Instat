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

Public Class ucrThemeAxes
    Private bInitialiseControls As Boolean = False
    Public strAxis As String
    Private clsThemeFunction As New RFunction
    Private clsElementText As New RFunction
    Private strParameter As String
    Private clsBaseOperator As New ROperator

    Public Sub InitialiseControl()
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
        ucrColors.SetParameter(New RParameter("colour"))
        ucrColors.AddQuotesIfUnrecognised = False
        ' ucrInputColour.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        'ucrInputColour.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkFamily.SetText("Family")
        ucrInputFamily.SetParameter(New RParameter("family"))
        ucrInputFamily.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFonts))
        ucrInputFamily.SetRDefault(Chr(34) & "Times" & Chr(34))


        'Linking
        ucrChkSize.AddToLinkedControls(ucrNudsize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkHjust.AddToLinkedControls(ucrNudHjust, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkVjust.AddToLinkedControls(ucrNudVjust, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineHeight.AddToLinkedControls(ucrNudLineHeight, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAngle.AddToLinkedControls(ucrNudAngle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFace.AddToLinkedControls(ucrInputFace, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFamily.AddToLinkedControls(ucrInputFamily, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColour.AddToLinkedControls(ucrColors, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        bInitialiseControls = True
    End Sub

    Public Sub SetAxis(strNewAxis As String)
        strAxis = strNewAxis
    End Sub

    Public Sub SetRCodeForControl(strNewAxis As String, clsNewElementText As RFunction, clsNewThemeFunction As RFunction, clsNewBaseOperator As ROperator, Optional bReset As Boolean = False)
        If Not bInitialiseControls Then
            InitialiseControl()
        End If

        SetAxis(strNewAxis)
        clsBaseOperator = clsNewBaseOperator
        clsThemeFunction = clsNewThemeFunction
        clsElementText = clsNewElementText

        ucrNudAngle.SetRCode(clsElementText, bReset)
        ucrChkAngle.SetRCode(clsElementText, bReset)

        ucrNudHjust.SetRCode(clsElementText, bReset)
        ucrChkHjust.SetRCode(clsElementText, bReset)

        ucrNudLineHeight.SetRCode(clsElementText, bReset)
        ucrChkLineHeight.SetRCode(clsElementText, bReset)

        ucrNudsize.SetRCode(clsElementText, bReset)
        ucrChkSize.SetRCode(clsElementText, bReset)

        ucrNudVjust.SetRCode(clsElementText, bReset)
        ucrChkVjust.SetRCode(clsElementText, bReset)

        ucrColors.SetRCode(clsElementText, bReset)
        ucrChkColour.SetRCode(clsElementText, bReset)

        ucrInputFace.SetRCode(clsElementText, bReset)
        ucrChkFace.SetRCode(clsElementText, bReset)

        ucrInputFamily.SetRCode(clsElementText, bReset)
        ucrChkFamily.SetRCode(clsElementText, bReset)

        AddRemoveElementAxis()
    End Sub

    Private Sub AddRemoveElementAxis()
        If ucrChkAngle.Checked OrElse ucrChkHjust.Checked OrElse ucrChkLineHeight.Checked OrElse ucrChkSize.Checked OrElse ucrChkVjust.Checked OrElse ucrChkColour.Checked OrElse ucrChkFace.Checked OrElse ucrChkFamily.Checked Then
            clsThemeFunction.AddParameter(strAxis, clsRFunctionParameter:=clsElementText)
        Else
            clsThemeFunction.RemoveParameterByName(strAxis)
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

    Private Sub ElementXAxisTextControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAngle.ControlValueChanged, ucrChkHjust.ControlValueChanged, ucrChkLineHeight.ControlValueChanged, ucrChkSize.ControlValueChanged, ucrChkVjust.ControlValueChanged, ucrChkColour.ControlValueChanged, ucrChkFace.ControlValueChanged, ucrChkFamily.ControlValueChanged
        AddRemoveElementAxis()
    End Sub
End Class
