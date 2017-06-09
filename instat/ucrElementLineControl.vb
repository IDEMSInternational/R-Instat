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

        ucrChkTickSize.SetText("Size")
        ucrNudTickSize.SetParameter(New RParameter("size"))
        ucrChkTickSize.AddParameterPresentCondition(True, "size")
        ucrChkTickSize.AddParameterPresentCondition(False, "size", False)
        ucrNudTickSize.Increment = 0.1


        ucrChkTickLineType.SetText("Line Type")
        ucrInputTickLineType.SetParameter(New RParameter("linetype"))
        ucrChkTickLineType.AddParameterPresentCondition(True, "linetype")
        ucrChkTickLineType.AddParameterPresentCondition(False, "linetype", False)
        ucrInputTickLineType.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))

        ucrChkTickColour.SetText("Colour")
        ucrColors.SetParameter(New RParameter("colour"))
        ucrChkTickColour.AddParameterPresentCondition(True, "colour")
        ucrChkTickColour.AddParameterPresentCondition(False, "colour", False)
        ucrColors.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))

        ucrChkTickLineEnd.SetText("Line End")
        ucrInpuTicktLineEnd.SetParameter(New RParameter("lineend"))
        ucrChkTickLineEnd.AddParameterPresentCondition(True, "lineend")
        ucrChkTickLineEnd.AddParameterPresentCondition(False, "lineend", False)
        ucrInpuTicktLineEnd.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineEnd))

        ucrChkTickSize.AddToLinkedControls(ucrNudTickSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.0)
        ucrChkTickLineType.AddToLinkedControls(ucrInputTickLineType, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Solid")
        ucrChkTickLineEnd.AddToLinkedControls(ucrInpuTicktLineEnd, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Square")
        ucrChkTickColour.AddToLinkedControls(ucrColors, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Black")
        bInitialiseControls = True
    End Sub

    Public Sub SetAxisLine(strNewAxis As String)
        strAxisLine = strNewAxis
    End Sub

    Public Sub SetRCodeForControl(strNewAxisLine As String, clsNewElementLine As RFunction, clsNewThemeFunction As RFunction, clsNewBaseOperator As ROperator, Optional bReset As Boolean = False)
        If Not bInitialiseControls Then
            InitialiseControl()
        End If

        SetAxisLine(strNewAxisLine)
        clsBaseOperator = clsNewBaseOperator
        clsThemeFunction = clsNewThemeFunction
        clsElementLine = clsNewElementLine

        ucrNudTickSize.SetRCode(clsElementLine, bReset)
        ucrChkTickSize.SetRCode(clsElementLine, bReset)

        ucrColors.SetRCode(clsElementLine, bReset)
        ucrChkTickColour.SetRCode(clsElementLine, bReset)

        ucrInputTickLineType.SetRCode(clsElementLine, bReset)
        ucrChkTickLineType.SetRCode(clsElementLine, bReset)

        ucrInpuTicktLineEnd.SetRCode(clsElementLine, bReset)
        ucrChkTickLineEnd.SetRCode(clsElementLine, bReset)
        AddRemoveElementLineAxis()
    End Sub

    Private Sub AddRemoveElementLineAxis()
        If ucrChkTickColour.Checked OrElse ucrChkTickLineEnd.Checked OrElse ucrChkTickLineType.Checked OrElse ucrChkTickSize.Checked Then
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

    Private Sub ElementTickAxisLineControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTickLineType.ControlValueChanged, ucrChkTickSize.ControlValueChanged, ucrChkTickLineEnd.ControlValueChanged, ucrChkTickColour.ControlValueChanged
        AddRemoveElementLineAxis()
    End Sub

    Public Sub SetLabel(strlabel As String)
        grpTickMarks.Text = strlabel
    End Sub
End Class
