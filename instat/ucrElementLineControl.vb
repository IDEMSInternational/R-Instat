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

Public Class ucrElementLineControl
    Private bInitialiseControls As Boolean = False
    Public strAxisLine As String
    Private clsThemeFunction As New RFunction
    Private clsElementLine As New RFunction
    Private clsBaseOperator As New ROperator
    Public Sub InitialiseControl()

        ucrChkLineSize.SetText("Size")
        ucrNudLineSize.SetParameter(New RParameter("size"))
        ucrChkLineSize.AddParameterPresentCondition(True, "size")
        ucrChkLineSize.AddParameterPresentCondition(False, "size", False)
        ucrNudLineSize.Increment = 0.1

        ucrChkLineLineType.SetText("Line Type")
        ucrInputLineLineType.SetParameter(New RParameter("linetype"))
        ucrChkLineLineType.AddParameterPresentCondition(True, "linetype")
        ucrChkLineLineType.AddParameterPresentCondition(False, "linetype", False)
        ucrInputLineLineType.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        ucrInputLineLineType.SetDropDownStyleAsNonEditable()

        ucrChkLineColour.SetText("Colour")
        ucrLineColors.SetParameter(New RParameter("colour"))
        ucrChkLineColour.AddParameterPresentCondition(True, "colour")
        ucrChkLineColour.AddParameterPresentCondition(False, "colour", False)
        ucrLineColors.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrLineColors.SetDropDownStyleAsNonEditable()

        ucrChkLineLineEnd.SetText("Line End")
        ucrInputLineLineEnd.SetParameter(New RParameter("lineend"))
        ucrChkLineLineEnd.AddParameterPresentCondition(True, "lineend")
        ucrChkLineLineEnd.AddParameterPresentCondition(False, "lineend", False)
        ucrInputLineLineEnd.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineEnd))
        ucrInputLineLineEnd.SetDropDownStyleAsNonEditable()

        ucrChkLineSize.AddToLinkedControls(ucrNudLineSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.0)
        ucrChkLineLineType.AddToLinkedControls(ucrInputLineLineType, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Solid")
        ucrChkLineLineEnd.AddToLinkedControls(ucrInputLineLineEnd, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Square")
        ucrChkLineColour.AddToLinkedControls(ucrLineColors, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Black")
        bInitialiseControls = True
    End Sub

    Public Sub SetAxisLine(strNewAxis As String)
        strAxisLine = strNewAxis
    End Sub

    Public Sub SetRCodeForControl(strNewAxisLine As String, clsNewElementLine As RFunction, clsNewThemeFunction As RFunction, clsNewBaseOperator As ROperator, Optional bReset As Boolean = False, Optional bCloneIfNeeded As Boolean = False)
        If Not bInitialiseControls Then
            InitialiseControl()
        End If

        SetAxisLine(strNewAxisLine)
        clsBaseOperator = clsNewBaseOperator
        clsThemeFunction = clsNewThemeFunction
        clsElementLine = clsNewElementLine

        ucrNudLineSize.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrChkLineSize.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrLineColors.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrChkLineColour.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrInputLineLineType.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrChkLineLineType.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrInputLineLineEnd.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrChkLineLineEnd.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        AddRemoveElementLineAxis()
    End Sub

    Private Sub AddRemoveElementLineAxis()
        If ucrChkLineColour.Checked OrElse ucrChkLineLineEnd.Checked OrElse ucrChkLineLineType.Checked OrElse ucrChkLineSize.Checked Then
            clsThemeFunction.AddParameter(strAxisLine, clsRFunctionParameter:=clsElementLine)
        Else
            clsThemeFunction.RemoveParameterByName(strAxisLine)
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

    Private Sub ElementTickAxisLineControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLineLineType.ControlValueChanged, ucrChkLineSize.ControlValueChanged, ucrChkLineLineEnd.ControlValueChanged, ucrChkLineColour.ControlValueChanged
        AddRemoveElementLineAxis()
    End Sub

    Public Sub SetLabel(strlabel As String)
        grpTickMarks.Text = strlabel
    End Sub

End Class
