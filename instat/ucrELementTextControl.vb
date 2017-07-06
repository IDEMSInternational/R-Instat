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

Public Class ucrELementTextControl
    Private bInitialiseControls As Boolean = False
    Public strAxis As String
    Private clsThemeFunction As New RFunction
    Private clsElementText As New RFunction
    Private clsBaseOperator As New ROperator

    Public Sub InitialiseControl()
        ucrChkSize.SetText("Size")
        ucrNudsize.SetParameter(New RParameter("size"))
        ucrChkSize.AddParameterPresentCondition(True, "size")
        ucrChkSize.AddParameterPresentCondition(False, "size", False)

        ucrChkAngle.SetText("Angle")
        ucrNudAngle.SetParameter(New RParameter("angle"))
        ucrNudAngle.SetMinMax(0, 360)
        ucrChkAngle.AddParameterPresentCondition(True, "angle")
        ucrChkAngle.AddParameterPresentCondition(False, "angle", False)

        ucrChkHjust.SetText("Hjust")
        ucrNudHjust.SetParameter(New RParameter("hjust"))
        ucrNudHjust.Increment = 0.1
        ucrNudHjust.SetMinMax(0, 1)
        ucrChkHjust.AddParameterPresentCondition(True, "hjust")
        ucrChkHjust.AddParameterPresentCondition(False, "hjust", False)

        ucrChkVjust.SetText("Vjust")
        ucrNudVjust.SetParameter(New RParameter("vjust"))
        ucrNudVjust.Increment = 0.1
        ucrNudVjust.SetMinMax(0, 1)
        ucrChkVjust.AddParameterPresentCondition(True, "vjust")
        ucrChkVjust.AddParameterPresentCondition(False, "vjust", False)

        ucrChkLineHeight.SetText("Line Height")
        ucrNudLineHeight.SetParameter(New RParameter("lineheight"))
        ucrChkLineHeight.AddParameterPresentCondition(True, "lineheight")
        ucrChkLineHeight.AddParameterPresentCondition(False, "lineheight", False)

        ucrChkTextFace.SetText("Face")
        ucrInputTextFace.SetParameter(New RParameter("face"))
        ucrInputTextFace.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFontFace))
        ucrChkTextFace.AddParameterPresentCondition(True, "face")
        ucrChkTextFace.AddParameterPresentCondition(False, "face", False)
        ucrInputTextFace.SetDropDownStyleAsNonEditable()

        ucrChkTextColour.SetText("Colour")
        ucrTextColors.SetParameter(New RParameter("colour"))
        ucrChkTextColour.AddParameterPresentCondition(True, "colour")
        ucrChkTextColour.AddParameterPresentCondition(False, "colour", False)
        ucrTextColors.SetDropDownStyleAsNonEditable()

        ucrChkTextFamily.SetText("Family")
        ucrInputTextFamily.SetParameter(New RParameter("family"))
        ucrInputTextFamily.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFonts))
        ucrChkTextFamily.AddParameterPresentCondition(True, "family")
        ucrChkTextFamily.AddParameterPresentCondition(False, "family", False)
        ucrInputTextFamily.SetDropDownStyleAsNonEditable()

        'Linking
        ucrChkSize.AddToLinkedControls(ucrNudsize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrChkHjust.AddToLinkedControls(ucrNudHjust, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.0)
        ucrChkVjust.AddToLinkedControls(ucrNudVjust, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.0)
        ucrChkLineHeight.AddToLinkedControls(ucrNudLineHeight, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.0)
        ucrChkAngle.AddToLinkedControls(ucrNudAngle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrChkTextFace.AddToLinkedControls(ucrInputTextFace, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Plain")
        ucrChkTextFamily.AddToLinkedControls(ucrInputTextFamily, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Times Roman")
        ucrChkTextColour.AddToLinkedControls(ucrTextColors, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Black")

        bInitialiseControls = True
    End Sub

    Public Sub SetAxis(strNewAxis As String)
        strAxis = strNewAxis
    End Sub

    Public Sub SetRCodeForControl(strNewAxis As String, clsNewElementText As RFunction, clsNewThemeFunction As RFunction, clsNewBaseOperator As ROperator, Optional bReset As Boolean = False, Optional bCloneIfNeeded As Boolean = False)
        If Not bInitialiseControls Then
            InitialiseControl()
        End If

        SetAxis(strNewAxis)
        clsBaseOperator = clsNewBaseOperator
        clsThemeFunction = clsNewThemeFunction
        clsElementText = clsNewElementText

        ucrNudAngle.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrChkAngle.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrNudHjust.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrChkHjust.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrNudLineHeight.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrChkLineHeight.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrNudsize.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrChkSize.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrNudVjust.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrChkVjust.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrTextColors.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrChkTextColour.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrInputTextFace.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrChkTextFace.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrInputTextFamily.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrChkTextFamily.SetRCode(clsElementText, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        AddRemoveElementAxis()
    End Sub

    Private Sub AddRemoveElementAxis()
        If ucrChkAngle.Checked OrElse ucrChkHjust.Checked OrElse ucrChkLineHeight.Checked OrElse ucrChkSize.Checked OrElse ucrChkVjust.Checked OrElse ucrChkTextColour.Checked OrElse ucrChkTextFace.Checked OrElse ucrChkTextFamily.Checked Then
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

    Private Sub ElementXAxisTextControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAngle.ControlValueChanged, ucrChkHjust.ControlValueChanged, ucrChkLineHeight.ControlValueChanged, ucrChkSize.ControlValueChanged, ucrChkVjust.ControlValueChanged, ucrChkTextColour.ControlValueChanged, ucrChkTextFace.ControlValueChanged, ucrChkTextFamily.ControlValueChanged
        AddRemoveElementAxis()
    End Sub

    Public Sub SetLabel(strlabel As String)
        grpAxisLabels.Text = strlabel
    End Sub
End Class
