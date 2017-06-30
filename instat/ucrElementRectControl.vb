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

Public Class ucrElementRectControl
    Private bInitialiseControls As Boolean = False
    Public strLegend As String
    Private clsThemeFunction As New RFunction
    Private clsElementLine As New RFunction
    Private clsBaseOperator As New ROperator

    Public Sub InitialiseControl()

        ucrChkRectSize.SetText("Size")
        ucrNudRectSize.SetParameter(New RParameter("size"))
        ucrChkRectSize.AddParameterPresentCondition(True, "size")
        ucrChkRectSize.AddParameterPresentCondition(False, "size", False)
        ucrNudRectSize.Increment = 0.1

        ucrChkRectLineType.SetText("Line Type")
        ucrInputRectLineType.SetParameter(New RParameter("linetype"))
        ucrChkRectLineType.AddParameterPresentCondition(True, "linetype")
        ucrChkRectLineType.AddParameterPresentCondition(False, "linetype", False)
        ucrInputRectLineType.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        ucrInputRectLineType.SetDropDownStyleAsNonEditable()

        ucrChkRectColour.SetText("Colour")
        ucrRectColors.SetParameter(New RParameter("colour"))
        ucrChkRectColour.AddParameterPresentCondition(True, "colour")
        ucrChkRectColour.AddParameterPresentCondition(False, "colour", False)
        ucrRectColors.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrRectColors.SetDropDownStyleAsNonEditable()

        ucrChkRectFill.SetText("Fill")
        ucrRectFill.SetParameter(New RParameter("fill"))
        ucrChkRectFill.AddParameterPresentCondition(True, "fill")
        ucrChkRectFill.AddParameterPresentCondition(False, "fill", False)
        ucrRectFill.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrRectFill.SetDropDownStyleAsNonEditable()

        ucrChkRectSize.AddToLinkedControls(ucrNudRectSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.0)
        ucrChkRectLineType.AddToLinkedControls(ucrInputRectLineType, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Solid")
        ucrChkRectColour.AddToLinkedControls(ucrRectColors, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Black")
        ucrChkRectFill.AddToLinkedControls(ucrRectFill, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Black")

        bInitialiseControls = True
    End Sub

    Public Sub SetAxisLine(strNewLegend As String)
        strLegend = strNewLegend
    End Sub


    Public Sub SetRCodeForControl(strNewLegend As String, clsNewElementLine As RFunction, clsNewThemeFunction As RFunction, clsNewBaseOperator As ROperator, Optional bReset As Boolean = False)
        If Not bInitialiseControls Then
            InitialiseControl()
        End If

        SetAxisLine(strNewLegend)
        clsBaseOperator = clsNewBaseOperator
        clsThemeFunction = clsNewThemeFunction
        clsElementLine = clsNewElementLine

        ucrNudRectSize.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=True)
        ucrChkRectSize.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=True)

        ucrRectColors.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=True)
        ucrChkRectColour.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=True)

        ucrRectFill.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=True)
        ucrChkRectFill.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=True)

        ucrInputRectLineType.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=True)
        ucrChkRectLineType.SetRCode(clsElementLine, bReset, bCloneIfNeeded:=True)

        AddRemoveElementLineAxis()
    End Sub

    Private Sub AddRemoveElementLineAxis()
        If ucrChkRectColour.Checked OrElse ucrChkRectFill.Checked OrElse ucrChkRectLineType.Checked OrElse ucrChkRectSize.Checked OrElse ucrChkRectFill.Checked Then
            clsThemeFunction.AddParameter(strLegend, clsRFunctionParameter:=clsElementLine)
        Else
            clsThemeFunction.RemoveParameterByName(strLegend)
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

    Private Sub ElementTickAxisLineControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRectLineType.ControlValueChanged, ucrChkRectSize.ControlValueChanged, ucrChkRectFill.ControlValueChanged, ucrChkRectColour.ControlValueChanged, ucrChkRectFill.ControlValueChanged
        AddRemoveElementLineAxis()
    End Sub

    Public Sub SetLabel(strlabel As String)
        grpElementRect.Text = strlabel
    End Sub
End Class
