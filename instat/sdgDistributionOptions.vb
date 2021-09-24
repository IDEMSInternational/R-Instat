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

Imports instat.Translations
Public Class sdgDistributionOptions
    Private bInitialiseControls As Boolean = True
    Private clsLabsFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private Sub sdgDistributionOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        Dim dctThemes As New Dictionary(Of String, String)
        Dim strThemes As String()

        ucrInputGraphTitle.SetParameter(New RParameter("title", 0))

        ucrInputGraphSubTitle.SetParameter(New RParameter("subtitle", 1))

        ucrInputGraphCaption.SetParameter(New RParameter("caption", 2))

        ucrInputXAxisLabel.SetParameter(New RParameter("x", 3))

        ucrInputYAxisLabel.SetParameter(New RParameter("y", 4))

        ucrPnlYAxis.AddRadioButton(rdoYAxisAuto)
        ucrPnlYAxis.AddRadioButton(rdoYAxisSpecifyTitle)
        ucrPnlYAxis.AddRadioButton(rdoYAxisNoTitle)
        ucrPnlYAxis.AddParameterPresentCondition(rdoYAxisAuto, "y", False)
        ucrPnlYAxis.AddParameterPresentCondition(rdoYAxisSpecifyTitle, "y", True)
        ucrPnlYAxis.AddParameterValuesCondition(rdoYAxisNoTitle, "y", Chr(34) & Chr(34), True)

        ucrPnlXAxis.AddRadioButton(rdoXAxisAuto)
        ucrPnlXAxis.AddRadioButton(rdoXAxisSpecifyTitle)
        ucrPnlXAxis.AddRadioButton(rdoXAxisNoTitle)
        ucrPnlXAxis.AddParameterPresentCondition(rdoXAxisAuto, "x", True)
        ucrPnlXAxis.AddParameterValuesCondition(rdoXAxisSpecifyTitle, "x", True)
        ucrPnlXAxis.AddParameterValuesCondition(rdoXAxisNoTitle, "x", Chr(34) & Chr(34), True)

        ucrPnlXAxis.AddToLinkedControls(ucrInputXAxisLabel, {rdoXAxisSpecifyTitle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlYAxis.AddToLinkedControls(ucrInputYAxisLabel, {rdoYAxisSpecifyTitle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputXAxisLabel.SetLinkedDisplayControl(lblXAxisTitle)
        ucrInputYAxisLabel.SetLinkedDisplayControl(lblYAxisTitle)

        strThemes = GgplotDefaults.strThemes

        ucrInputThemes.SetParameter(New RParameter("theme", 0))
        For Each strTemp As String In strThemes
            If strTemp.StartsWith("theme_") Then
                dctThemes.Add(strTemp.Remove(0, 6), strTemp & "()")
            Else
                dctThemes.Add(strTemp, strTemp & "()")
            End If
        Next
        ucrInputThemes.SetItems(dctThemes)
        ucrInputThemes.SetRDefault("theme_grey()")
        ucrInputThemes.SetDropDownStyleAsNonEditable()
    End Sub

    Public Sub SetRCode(clsNewLabsFunction As RFunction, clsNewThemeFunction As RFunction, Optional bReset As Boolean = False)
        If bInitialiseControls Then
            InitialiseControls()
            bInitialiseControls = False
        End If

        clsThemeFunction = clsNewThemeFunction
        clsLabsFunction = clsNewLabsFunction

        ucrInputGraphTitle.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputGraphSubTitle.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputGraphCaption.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputXAxisLabel.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputYAxisLabel.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputThemes.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)

        If bReset Then
            rdoXAxisAuto.Checked = True
            rdoYAxisAuto.Checked = True
        End If
    End Sub

    Private Sub ucrPnlXAxis_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlXAxis.ControlValueChanged
        If rdoXAxisAuto.Checked Then
            clsLabsFunction.RemoveParameterByName("x")
        ElseIf rdoXAxisNoTitle.Checked Then
            clsLabsFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=3)
        Else
            clsLabsFunction.AddParameter("x", Chr(34) & ucrInputXAxisLabel.GetText() & Chr(34), iPosition:=3)
        End If
    End Sub

    Private Sub ucrPnlYAxis_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlYAxis.ControlValueChanged
        If rdoYAxisAuto.Checked Then
            clsLabsFunction.RemoveParameterByName("y")
        ElseIf rdoYAxisNoTitle.Checked Then
            clsLabsFunction.AddParameter("y", Chr(34) & Chr(34), iPosition:=4)
        Else
            clsLabsFunction.AddParameter("y", Chr(34) & ucrInputYAxisLabel.GetText() & Chr(34), iPosition:=4)
        End If
    End Sub
End Class