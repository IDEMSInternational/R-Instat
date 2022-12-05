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

Imports instat
Imports instat.Translations
Public Class sdgPairPlotOptions
    Public clsOperator As New ROperator
    Public clsPairThemesFunction, clsGGpairAesFunction As New RFunction
    Private bControlsInitialised As Boolean = False
    Private Sub sdgPairPlotOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub
    Public Sub InitialiseControls()
        Dim dctLegendPosition As New Dictionary(Of String, String)

        ucrChkShowLegend.SetText("Show Legend")
        ucrChkShowLegend.AddParameterPresentCondition(True, "show_legend")
        ucrChkShowLegend.AddParameterPresentCondition(False, "show_legend", False)

        ucrChkLegendPosition.SetText("Legend Position")
        ucrChkLegendPosition.AddToLinkedControls(ucrInputLegendPosition, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrInputLegendPosition.SetDropDownStyleAsNonEditable()
        ucrInputLegendPosition.SetParameter(New RParameter("legend.position"))
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        ucrChkLegendPosition.AddParameterPresentCondition(True, "legend_position")
        ucrChkLegendPosition.AddParameterPresentCondition(False, "legend_position", False)

    End Sub

    Public Sub SetRCode(clsNewOperetor As ROperator, clsNewPairThemesFunction As RFunction, clsNewGGpairAesFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsOperator = clsNewOperetor
        clsPairThemesFunction = clsNewPairThemesFunction
        clsGGpairAesFunction = clsNewGGpairAesFunction


        ucrChkLegendPosition.SetRCode(clsPairThemesFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsPairThemesFunction, bReset, bCloneIfNeeded:=True)
        ucrChkShowLegend.SetRCode(clsGGpairAesFunction, bReset, bCloneIfNeeded:=True)

    End Sub
    'Private Sub AddRemoveTheme()
    '    'If clsThemeFunction.iParameterCount > 0 Then
    '    '    clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
    '    'Else
    '    '    clsBaseOperator.RemoveParameterByName("theme")
    '    'End If
    'End Sub
    Private Sub ucrChkLegendPosition_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLegendPosition.ControlValueChanged, ucrInputLegendPosition.ControlValueChanged
        If ucrChkLegendPosition.Checked Then
            clsOperator.AddParameter("right", clsRFunctionParameter:=clsPairThemesFunction, iPosition:=1)

        Else
            clsOperator.RemoveParameterByName("right")
        End If

    End Sub

    Private Sub ucrChkShowLegend_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkShowLegend.ControlValueChanged
        If ucrChkShowLegend.Checked Then
            clsGGpairAesFunction.AddParameter("legend", 1, iPosition:=2)
        Else
            clsGGpairAesFunction.RemoveParameterByName("legend")
        End If
    End Sub
End Class