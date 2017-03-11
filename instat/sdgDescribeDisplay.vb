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
Public Class sdgDescribeDisplay
    Public bControlsInitialised As Boolean = False
    Public clsRAnovaDispOptions, clsRFreqDispOptions As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub sdgDescribeDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    'Public Sub SetAnovaDispOptions(clsRNewAnovaDispOptions As RFunction)
    '    clsRAnovaDispOptions = clsRNewAnovaDispOptions
    'End Sub
    'Public Sub SetFreqDispOptions(clsRNewFreqDispOptions As RFunction)
    '    clsRFreqDispOptions = clsRNewFreqDispOptions
    'End Sub

    Public Sub InitialiseControls()
        ucrChkAddMargins.SetText("Add Margins")
        ucrChkAddMargins.SetParameter(New RParameter("addmargins"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkAddMargins.SetRDefault("FALSE")


        'ucrChkPercentages.Checked = False
        ucrChkPercentages.SetText("Percentages")
        ucrChkPercentages.SetParameter(New RParameter("percentages"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkPercentages.SetRDefault("FALSE")

        'ucrChkProportions.Checked = False
        ucrChkProportions.SetText("Add Margins")
        ucrChkProportions.SetParameter(New RParameter("addmargins"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkProportions.SetRDefault("FALSE")

        'ucrChkTranspose.Checked = False
        ucrChkTranspose.SetText("Transpose")
        ucrChkTranspose.SetParameter(New RParameter("transpose"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkTranspose.SetRDefault("FALSE")

        'ucrChkSignifLevel.Checked = False
        ucrChkSignifLevel.SetText("Significance Level")
        ucrChkSignifLevel.SetParameter(New RParameter("sign_level"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkSignifLevel.SetRDefault("FALSE")

        'ucrChkSignifStars.Checked = False
        ucrChkSignifStars.SetText("Significance stars")
        ucrChkSignifStars.SetParameter(New RParameter("signif.stars"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkSignifStars.SetRDefault("FALSE")

        'ucrChkMeans.Checked = False
        ucrChkMeans.SetText("Means")
        ucrChkMeans.SetParameter(New RParameter("means"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkMeans.SetRDefault("FALSE")


    End Sub

    'Private Sub chkAddMargins_CheckedChanged(sender As Object, e As EventArgs) Handles chkAddMargins.CheckedChanged
    '    If chkAddMargins.Checked Then
    '        clsRFreqDispOptions.AddParameter("addmargins", "TRUE")
    '    Else
    '        clsRFreqDispOptions.RemoveParameterByName("addmargins")
    '    End If
    'End Sub

    'Private Sub chkPercentages_CheckedChanged(sender As Object, e As EventArgs) Handles chkPercentages.CheckedChanged
    '    If chkPercentages.Checked Then
    '        clsRFreqDispOptions.AddParameter("percentages", "TRUE")
    '    Else
    '        clsRFreqDispOptions.RemoveParameterByName("percentages")
    '    End If
    '    If chkProportions.Checked = False Then
    '        MsgBox("Proportions should be checked to display percentages")
    '    End If
    'End Sub

    'Private Sub chkTranspose_CheckedChanged(sender As Object, e As EventArgs) Handles chkTranspose.CheckedChanged
    '    If chkTranspose.Checked Then
    '        clsRFreqDispOptions.AddParameter("transpose", "TRUE")
    '    Else
    '        clsRFreqDispOptions.RemoveParameterByName("transpose")
    '    End If
    'End Sub

    'Private Sub chkProportions_CheckedChanged(sender As Object, e As EventArgs) Handles chkProportions.CheckedChanged
    '    If chkProportions.Checked Then
    '        clsRFreqDispOptions.AddParameter("proportions", "TRUE")
    '    Else
    '        clsRFreqDispOptions.RemoveParameterByName("proportions")
    '    End If
    'End Sub

    'Private Sub chkSignifLevel_CheckedChanged(sender As Object, e As EventArgs) Handles chkSignifLevel.CheckedChanged
    '    If chkSignifLevel.Checked Then
    '        clsRAnovaDispOptions.AddParameter("sign_level", "TRUE")
    '    Else
    '        clsRAnovaDispOptions.RemoveParameterByName("sign_level")
    '    End If
    'End Sub

    'Private Sub chkSignifStars_CheckedChanged(sender As Object, e As EventArgs) Handles chkSignifStars.CheckedChanged
    '    If chkSignifStars.Checked Then
    '        clsRAnovaDispOptions.AddParameter("signif.stars", "TRUE")
    '    Else
    '        clsRAnovaDispOptions.RemoveParameterByName("sign.stars")
    '    End If
    'End Sub

    'Private Sub chkMeans_CheckedChanged(sender As Object, e As EventArgs) Handles chkMeans.CheckedChanged
    '    If chkMeans.Checked Then
    '        clsRAnovaDispOptions.AddParameter("means", "TRUE")
    '    Else
    '        clsRAnovaDispOptions.RemoveParameterByName("means")
    '    End If
    'End Sub

    Public Sub SetRFunction(clsNewFreqRFunction As RFunction, clsNewAnovaRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRFreqDispOptions = clsNewFreqRFunction
        clsRAnovaDispOptions = clsNewAnovaRFunction
        ucrChkAddMargins.SetRCode(clsRFreqDispOptions, bReset)
        ucrChkTranspose.SetRCode(clsRFreqDispOptions, bReset)
        ucrChkProportions.SetRCode(clsRFreqDispOptions, bReset)
        ucrChkPercentages.SetRCode(clsRFreqDispOptions, bReset)
        ucrChkMeans.SetRCode(clsRAnovaDispOptions, bReset)
        ucrChkSignifStars.SetRCode(clsRAnovaDispOptions, bReset)
        ucrChkSignifLevel.SetRCode(clsRAnovaDispOptions, bReset)
        GrpBoxEnable()
    End Sub

    Public Sub GrpBoxEnable()
        If ((dlgDescribeTwoVariable.strVarType = "factor") And (dlgDescribeTwoVariable.strSecondVarType = "numeric" OrElse dlgDescribeTwoVariable.strSecondVarType = "integer")) Then
            grpAnovaOptions.Enabled = True
            ucrChkAddMargins.Enabled = False
            ucrChkPercentages.Enabled = False
            ucrChkProportions.Enabled = False
            ucrChkTranspose.Enabled = False
            ucrChkSignifLevel.Enabled = True
            ucrChkSignifStars.Enabled = True
            ucrChkMeans.Enabled = True
            grpFrequenciesOptions.Enabled = False
        ElseIf ((dlgDescribeTwoVariable.strVarType = "factor") And (dlgDescribeTwoVariable.strSecondVarType = "factor")) Then
            grpFrequenciesOptions.Enabled = True
            ucrChkAddMargins.Enabled = True
            ucrChkPercentages.Enabled = True
            ucrChkProportions.Enabled = True
            ucrChkTranspose.Enabled = True
            ucrChkSignifLevel.Enabled = False
            ucrChkSignifStars.Enabled = False
            ucrChkMeans.Enabled = False
            grpAnovaOptions.Enabled = False
        End If
    End Sub
End Class