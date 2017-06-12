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

        ucrChkLegendSize.SetText("Size")
        ucrNudLegendSize.SetParameter(New RParameter("size"))
        ucrChkLegendSize.AddParameterPresentCondition(True, "size")
        ucrChkLegendSize.AddParameterPresentCondition(False, "size", False)
        ucrNudLegendSize.Increment = 0.1

        ucrChkLegendLineType.SetText("Line Type")
        ucrInputLegendLineType.SetParameter(New RParameter("linetype"))
        ucrChkLegendLineType.AddParameterPresentCondition(True, "linetype")
        ucrChkLegendLineType.AddParameterPresentCondition(False, "linetype", False)
        ucrInputLegendLineType.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))

        ucrChkLegendColour.SetText("Colour")
        ucrLegendColors.SetParameter(New RParameter("colour"))
        ucrChkLegendColour.AddParameterPresentCondition(True, "colour")
        ucrChkLegendColour.AddParameterPresentCondition(False, "colour", False)
        ucrLegendColors.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))

        ucrChkLegendFill.SetText("Fill")
        ucrLegendFill.SetParameter(New RParameter("fill"))
        ucrChkLegendFill.AddParameterPresentCondition(True, "fill")
        ucrChkLegendFill.AddParameterPresentCondition(False, "fill", False)
        ucrLegendFill.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))

        ucrChkLegendSize.AddToLinkedControls(ucrNudLegendSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.0)
        ucrChkLegendLineType.AddToLinkedControls(ucrInputLegendLineType, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Solid")
        ucrChkLegendColour.AddToLinkedControls(ucrLegendColors, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Black")
        ucrChkLegendFill.AddToLinkedControls(ucrLegendFill, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Black")

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

        ucrNudLegendSize.SetRCode(clsElementLine, bReset)
        ucrChkLegendSize.SetRCode(clsElementLine, bReset)

        ucrLegendColors.SetRCode(clsElementLine, bReset)
        ucrChkLegendColour.SetRCode(clsElementLine, bReset)

        ucrLegendFill.SetRCode(clsElementLine, bReset)
        ucrChkLegendFill.SetRCode(clsElementLine, bReset)

        ucrInputLegendLineType.SetRCode(clsElementLine, bReset)
        ucrChkLegendLineType.SetRCode(clsElementLine, bReset)

        AddRemoveElementLineAxis()
    End Sub

    Private Sub AddRemoveElementLineAxis()
        If ucrChkLegendColour.Checked OrElse ucrChkLegendFill.Checked OrElse ucrChkLegendLineType.Checked OrElse ucrChkLegendSize.Checked OrElse ucrChkLegendFill.Checked Then
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

    Private Sub ElementTickAxisLineControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLegendLineType.ControlValueChanged, ucrChkLegendSize.ControlValueChanged, ucrChkLegendFill.ControlValueChanged, ucrChkLegendColour.ControlValueChanged, ucrChkLegendFill.ControlValueChanged
        AddRemoveElementLineAxis()
    End Sub

    Public Sub SetLabel(strlabel As String)
        grpElementRect.Text = strlabel
    End Sub
End Class
