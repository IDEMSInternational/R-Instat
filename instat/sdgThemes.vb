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
    Private clsElementLine, clsElementXAxisTextTop, clsElementXAxisLine, clsElementYAxisLine, clsElementText, clsElementYAxisTextRight, clsElementXAxisLineTop, clsThemeFunction As New RFunction

    Private Sub ucrThemeAxesTitle_Load(sender As Object, e As EventArgs) Handles ucrThemeAxesTitle.Load

    End Sub

    Private clsBaseOperator As New ROperator

    Private dctThemeFunctions As New Dictionary(Of String, RFunction)

    Private Sub sdgThemes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()

        'Units
        ucrChkUnits.SetText("Tick length")
        ucrInputTickUnits.SetParameter(New RParameter("units"))
        ucrInputTickUnits.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFonts))
        ucrInputTickUnits.SetRDefault(Chr(34) & "npc" & Chr(34))
        ucrThemeBottomXAxis.setlabel("X axis tick labels")
        ucrThemeTopXAxis.setlabel("X axis tick labels on top axis")
        ucrThemeLeftYAxis.setlabel("Y axis tick labels")
        ucrThemeYRightAxis.setlabel("Y axis tick labels on right axis")
        ucrThemeTitleXAxis.setlabel("X axis label ")
        ucrThemeTitleXTopAxis.setlabel("X axis label on top axis")
        ucrThemeTitleYAxis.setlabel("Y axis labels")
        ucrThemeTitleYRightAxis.setlabel("Y axis labels on right axis")
        ucrTickMarksYAxis.setlabel("Y axis tick marks")
        ucrYAxisLines.setlabel("Line along y axis")
        ucrTickMarksXAxis.setlabel("X axis tick marks")
        ucrXAxisLines.setlabel("Line along x axis")
        ucrTickMarksAxes.setlabel("Tick marks along axes")
        ucrThemeAxesTitle.setlabel("Label of axes")
        ucrThemeAxesTickLabels.setlabel("Tick marks along axes")
        ucrThemeAxesLines.setlabel("Lines along axes")
    End Sub

    Public Sub SetRCode(clsBaseOperator As ROperator, clsNewThemeFunction As RFunction, dctNewThemeFunctions As Dictionary(Of String, RFunction), Optional bReset As Boolean = False)
        Dim clsXElementText As New RFunction
        Dim clsElementTickText As New RFunction
        Dim clsXElementTitleText As New RFunction
        Dim clsYElementText As New RFunction
        Dim clsXTopElementText As New RFunction
        Dim clsYRightElementText As New RFunction
        Dim clsXElementTitle As New RFunction
        Dim clsYElementTitle As New RFunction
        Dim clsXTopElementTitle As New RFunction
        Dim clsYRightElementTitle As New RFunction

        Dim clsXElementLine As New RFunction
        Dim clsElementLineAxes As New RFunction
        Dim clsYElementLine As New RFunction
        Dim clsElementTickAxes As New RFunction
        Dim clsElementTickXAxis As New RFunction
        Dim clsElementTickYAxis As New RFunction
        Dim clsElementLineXAxis As New RFunction
        Dim clsElementLineYAxis As New RFunction

        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsThemeFunction = clsNewThemeFunction
        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)

        dctThemeFunctions = dctNewThemeFunctions
        dctThemeFunctions.TryGetValue("axis.text", clsElementTickText)
        dctThemeFunctions.TryGetValue("axis.text.x", clsXElementText)
        dctThemeFunctions.TryGetValue("axis.text.y", clsYElementText)
        dctThemeFunctions.TryGetValue("axis.text.x.top", clsXTopElementText)
        dctThemeFunctions.TryGetValue("axis.text.y.right", clsYRightElementText)

        dctThemeFunctions.TryGetValue("axis.title", clsXElementTitleText)
        dctThemeFunctions.TryGetValue("axis.title.x", clsXElementTitle)
        dctThemeFunctions.TryGetValue("axis.title.y", clsYElementTitle)
        dctThemeFunctions.TryGetValue("axis.title.x.top", clsXTopElementTitle)
        dctThemeFunctions.TryGetValue("axis.title.y.right", clsYRightElementTitle)


        dctThemeFunctions.TryGetValue("axis.ticks.x", clsXElementLine)
        dctThemeFunctions.TryGetValue("axis.ticks.y", clsYElementLine)
        dctThemeFunctions.TryGetValue("axis.line.x", clsElementLineXAxis)
        dctThemeFunctions.TryGetValue("axis.line.y", clsElementLineYAxis)
        dctThemeFunctions.TryGetValue("axis.ticks", clsElementTickAxes)
        dctThemeFunctions.TryGetValue("axis.line", clsElementLineAxes)

        ucrTickMarksXAxis.SetRCodeForControl("axis.ticks.x", clsXElementLine, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrTickMarksYAxis.SetRCodeForControl("axis.ticks.y", clsYElementLine, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrXAxisLines.SetRCodeForControl("axis.line.x", clsElementLineXAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrYAxisLines.SetRCodeForControl("axis.line.y", clsElementLineYAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeAxesTickLabels.SetRCodeForControl("axis.ticks", clsElementTickAxes, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrTickMarksAxes.SetRCodeForControl("axis.text", clsElementTickText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeAxesTitle.SetRCodeForControl("axis.title", clsXElementTitleText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeAxesLines.SetRCodeForControl("axis.line", clsElementLineAxes, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrThemeBottomXAxis.SetRCodeForControl("axis.text.x", clsXElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTopXAxis.SetRCodeForControl("axis.text.x.top", clsXTopElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeLeftYAxis.SetRCodeForControl("axis.text.y", clsYElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeYRightAxis.SetRCodeForControl("axis.text.y.right", clsYRightElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrThemeTitleXAxis.SetRCodeForControl("axis.title.x", clsXElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTitleXTopAxis.SetRCodeForControl("axis.title.x.top", clsXTopElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTitleYAxis.SetRCodeForControl("axis.title.y", clsYElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTitleYRightAxis.SetRCodeForControl("axis.title.y.right", clsYRightElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        'AddRemoveElementParameters()
    End Sub

    'Private Sub AddRemoveElementParameters()
    '    If ucrChkAngle.Checked OrElse ucrChkHjust.Checked OrElse ucrChkLineHeight.Checked OrElse ucrChkSize.Checked OrElse ucrChkVjust.Checked OrElse ucrChkColour.Checked OrElse ucrChkFace.Checked OrElse ucrChkFamily.Checked Then
    '        clsThemeFunction.AddParameter("axis.text.x", clsRFunctionParameter:=clsElementText)
    '        clsThemeFunction.AddParameter("axis.text.y", clsRFunctionParameter:=clsElementText)
    '        clsThemeFunction.AddParameter("axis.ticks.y", clsRFunctionParameter:=clsElementLine)
    '        clsThemeFunction.AddParameter("axis.ticks.x", clsRFunctionParameter:=clsElementLine)

    '    Else
    '        clsThemeFunction.RemoveParameterByName("axis.text.x")
    '        clsThemeFunction.RemoveParameterByName("axis.text.y")
    '        clsThemeFunction.RemoveParameterByName("axis.ticks.y")
    '        clsThemeFunction.RemoveParameterByName("axis.ticks.x")
    '    End If
    '    AddRemoveTheme()
    'End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

End Class