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

    Private clsBaseOperator As New ROperator

    Private dctThemeFunctions As New Dictionary(Of String, RFunction)

    Private Sub sdgThemes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()


        'Tick Marks Along Axes
        ucrChkSizeTickMarksXAxis.SetText("Size")
        ucrNudSizeTickMarks.SetParameter(New RParameter("size"))
        ucrNudSizeTickMarks.Increment = 0.1


        ucrChkLineTypeTickMarksXAxis.SetText("Line Type")
        ucrInputLineTypeTickMarks.SetParameter(New RParameter("linetype"))
        ucrInputLineTypeTickMarks.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        ucrInputLineTypeTickMarks.SetRDefault(Chr(34) & "blank" & Chr(34))

        ucrChkColourTickMarksXAxis.SetText("Colour")
        ucrInputColourTickMarks.SetParameter(New RParameter("colour"))
        ucrInputColourTickMarks.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputColourTickMarks.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkLineEndTickMarksXAxis.SetText("Line End")
        ucrInputLineEndTickMarks.SetParameter(New RParameter("lineend"))
        ucrInputLineEndTickMarks.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineEnd))
        ucrInputLineEndTickMarks.SetRDefault(Chr(34) & "square" & Chr(34))


        'Tick Marks Along Axes
        ucrChkSizeTickLabelsXAxis.SetText("Size")
        ucrNudSizeTickLabelsXAxis.SetParameter(New RParameter("size"))
        ucrNudSizeTickLabelsXAxis.Increment = 0.1

        ucrChkLineTypeTickLabelsXAxis.SetText("Line Type")
        ucrInputLineTypeTickLabelsXAxis.SetParameter(New RParameter("linetype"))
        ucrInputLineTypeTickLabelsXAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        ucrInputLineTypeTickLabelsXAxis.SetRDefault(Chr(34) & "blank" & Chr(34))

        ucrChkColourTickLabelsXAxis.SetText("Colour")
        ucrInputColourTickLabelsXAxis.SetParameter(New RParameter("colour"))
        ucrInputColourTickLabelsXAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputColourTickLabelsXAxis.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkLineEndTickLabelsXAxis.SetText("Line End")
        ucrInputLineEndTickLabelsXAxis.SetParameter(New RParameter("lineend"))
        ucrInputLineEndTickLabelsXAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputLineEndTickLabelsXAxis.SetRDefault(Chr(34) & "square" & Chr(34))

        ucrChkSizeTickMarksXAxis.AddToLinkedControls(ucrNudSizeTickMarks, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineTypeTickMarksXAxis.AddToLinkedControls(ucrInputLineTypeTickMarks, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineEndTickMarksXAxis.AddToLinkedControls(ucrInputLineEndTickMarks, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColourTickMarksXAxis.AddToLinkedControls(ucrInputColourTickMarks, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSizeTickLabelsXAxis.AddToLinkedControls(ucrNudSizeTickLabelsXAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineTypeTickLabelsXAxis.AddToLinkedControls(ucrInputLineTypeTickLabelsXAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineEndTickLabelsXAxis.AddToLinkedControls(ucrInputLineEndTickLabelsXAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColourTickLabelsXAxis.AddToLinkedControls(ucrInputColourTickLabelsXAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)


        'Tick Marks Along-Axes
        ucrChkSizeTickMarksYAxis.SetText("Size")
        ucrNudSizeTickMarksYAxis.SetParameter(New RParameter("size"))
        ucrNudSizeTickMarksYAxis.Increment = 0.1

        ucrChkLineTypeTickLabelsYAxis.SetText("Line Type")
        ucrInputLineTypeTickLabelsYAxis.SetParameter(New RParameter("linetype"))

        ucrInputLineTypeTickLabelsYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        ucrInputLineTypeTickLabelsYAxis.SetRDefault(Chr(34) & "blank" & Chr(34))

        ucrChkColourTickMarksYAxis.SetText("Colour")
        ucrInputColourTickMarksYAxis.SetParameter(New RParameter("colour"))
        ucrInputColourTickMarksYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputColourTickMarksYAxis.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkLineEndTickLabelsYAxis.SetText("Line End")
        ucrInputLineEndTickLabelsYAxis.SetParameter(New RParameter("lineend"))
        ucrInputLineEndTickLabelsYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineEnd))
        ucrInputLineEndTickLabelsYAxis.SetRDefault(Chr(34) & "square" & Chr(34))

        'Tick Marks Along Axes
        ucrChkSizeTickMarksYAxis.SetText("Size")
        ucrNudSizeTickMarksYAxis.SetParameter(New RParameter("size"))
        ucrNudSizeTickMarksYAxis.Increment = 0.1

        ucrChkSizeTickLabelsYAxis.SetText("Size")
        ucrNudSizeTickLabelsYAxis.SetParameter(New RParameter("size"))
        ucrNudSizeTickLabelsYAxis.Increment = 0.1

        ucrChkLineTypeTickMarksYAxis.SetText("Line Type")
        ucrInputLineTypeTickMarksYAxis.SetParameter(New RParameter("linetype"))
        ucrInputLineTypeTickMarksYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        ucrInputLineTypeTickMarksYAxis.SetRDefault(Chr(34) & "blank" & Chr(34))

        ucrChkColourTickLabelsYAxis.SetText("Colour")
        ucrInputColourTickLabelsYAxis.SetParameter(New RParameter("colour"))
        ucrInputColourTickLabelsYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputColourTickLabelsYAxis.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkLineEndTickMarksYAxis.SetText("Line End")
        ucrInputLineEndTickMarksYAxis.SetParameter(New RParameter("lineend"))
        ucrInputLineEndTickMarksYAxis.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineEnd))
        ucrInputLineEndTickMarksYAxis.SetRDefault(Chr(34) & "square" & Chr(34))

        'Units
        ucrChkUnits.SetText("Tick length")
        ucrInputTickUnits.SetParameter(New RParameter("units"))
        ucrInputTickUnits.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFonts))
        ucrInputTickUnits.SetRDefault(Chr(34) & "npc" & Chr(34))

        ucrChkSizeTickMarksYAxis.AddToLinkedControls(ucrNudSizeTickMarksYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineTypeTickMarksYAxis.AddToLinkedControls(ucrInputLineTypeTickMarksYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineEndTickMarksYAxis.AddToLinkedControls(ucrInputLineEndTickMarksYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColourTickMarksYAxis.AddToLinkedControls(ucrInputColourTickMarksYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSizeTickLabelsYAxis.AddToLinkedControls(ucrNudSizeTickLabelsYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineTypeTickLabelsYAxis.AddToLinkedControls(ucrInputLineTypeTickLabelsYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineEndTickLabelsYAxis.AddToLinkedControls(ucrInputLineEndTickLabelsYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColourTickLabelsYAxis.AddToLinkedControls(ucrInputColourTickLabelsYAxis, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Public Sub SetRCode(clsBaseOperator As ROperator, clsNewThemeFunction As RFunction, dctNewThemeFunctions As Dictionary(Of String, RFunction), Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsThemeFunction = clsNewThemeFunction
        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)


        dctThemeFunctions = dctNewThemeFunctions
        dctThemeFunctions.TryGetValue("axis.text.x", clsElementText)
        dctThemeFunctions.TryGetValue("axis.text.y", clsElementText)
        dctThemeFunctions.TryGetValue("axis.text.y", clsElementText)
        dctThemeFunctions.TryGetValue("axis.ticks.x", clsElementLine)
        dctThemeFunctions.TryGetValue("axis.ticks.y", clsElementLine)

        'X axis Label Top Axis
        ucrNudSizeTickMarks.SetRCode(clsElementXAxisLine, bReset)
        ucrChkSizeTickMarksXAxis.SetRCode(clsElementXAxisLine, bReset)

        ucrInputColourTickMarks.SetRCode(clsElementXAxisLine, bReset)
        ucrChkColourTickMarksXAxis.SetRCode(clsElementXAxisLine, bReset)

        ucrInputLineTypeTickMarks.SetRCode(clsElementXAxisLine, bReset)
        ucrChkLineTypeTickMarksXAxis.SetRCode(clsElementXAxisLine, bReset)

        ucrInputLineEndTickMarks.SetRCode(clsElementXAxisLine, bReset)
        ucrChkLineEndTickMarksXAxis.SetRCode(clsElementXAxisLine, bReset)

        'X axis Label Top Axis
        ucrNudSizeTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkSizeTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)

        ucrInputColourTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkColourTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)

        ucrInputLineTypeTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkLineTypeTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)

        ucrInputLineEndTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkLineEndTickMarksYAxis.SetRCode(clsElementYAxisLine, bReset)


        ucrNudSizeTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkSizeTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)

        ucrInputColourTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkColourTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)

        ucrInputLineTypeTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkLineTypeTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)

        ucrInputLineEndTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)
        ucrChkLineEndTickLabelsYAxis.SetRCode(clsElementYAxisLine, bReset)


        ucrThemeBottomXAxis.SetRCodeForControl(dctNewThemeFunctions:=dctThemeFunctions, clsNewThemeFUnction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, clsNewElementText:=clsElementText)
        ucrThemeTopXAxis.SetRCodeForControl(dctNewThemeFunctions:=dctThemeFunctions, clsNewThemeFUnction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, clsNewElementText:=clsElementText)
        ucrThemeLeftYAxis.SetRCodeForControl(dctNewThemeFunctions:=dctThemeFunctions, clsNewThemeFUnction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, clsNewElementText:=clsElementText)
        ucrThemeRightYAxis.SetRCodeForControl(dctNewThemeFunctions:=dctThemeFunctions, clsNewThemeFUnction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, clsNewElementText:=clsElementText)

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