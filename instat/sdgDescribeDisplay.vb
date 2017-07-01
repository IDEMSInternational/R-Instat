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
    Private Sub sdgDescribeDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrChkAddMargins.SetText("Add Margins")
        ucrChkAddMargins.SetParameter(New RParameter("addmargins"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkAddMargins.SetRDefault("FALSE")

        ucrChkPercentages.SetText("Percentages")
        ucrChkPercentages.SetParameter(New RParameter("percentages"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkPercentages.SetRDefault("FALSE")

        ucrChkProportions.SetText("Proportions")
        ucrChkProportions.SetParameter(New RParameter("proportions"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkProportions.SetRDefault("FALSE")

        ucrChkTranspose.SetText("Transpose")
        ucrChkTranspose.SetParameter(New RParameter("transpose"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkTranspose.SetRDefault("FALSE")

        ucrChkSignifLevel.SetText("Significance Level")
        ucrChkSignifLevel.SetParameter(New RParameter("sign_level"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkSignifLevel.SetRDefault("FALSE")

        ucrChkSignifStars.SetText("Significance Stars")
        ucrChkSignifStars.SetParameter(New RParameter("signif.stars"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkSignifStars.SetRDefault("FALSE")

        ucrChkMeans.SetText("Means")
        ucrChkMeans.SetParameter(New RParameter("means"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkMeans.SetRDefault("FALSE")
    End Sub

    Public Sub SetRFunction(clsNewFreqRFunction As RFunction, clsNewAnovaRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRFreqDispOptions = clsNewFreqRFunction
        clsRAnovaDispOptions = clsNewAnovaRFunction
        ucrChkAddMargins.SetRCode(clsRFreqDispOptions, bReset, bCloneIfNeeded:=True)
        ucrChkTranspose.SetRCode(clsRFreqDispOptions, bReset, bCloneIfNeeded:=True)
        ucrChkProportions.SetRCode(clsRFreqDispOptions, bReset, bCloneIfNeeded:=True)
        ucrChkPercentages.SetRCode(clsRFreqDispOptions, bReset, bCloneIfNeeded:=True)
        ucrChkMeans.SetRCode(clsRAnovaDispOptions, bReset, bCloneIfNeeded:=True)
        ucrChkSignifStars.SetRCode(clsRAnovaDispOptions, bReset, bCloneIfNeeded:=True)
        ucrChkSignifLevel.SetRCode(clsRAnovaDispOptions, bReset, bCloneIfNeeded:=True)
        GrpBoxEnable()
    End Sub

    Public Sub GrpBoxEnable()
        If ((dlgDescribeTwoVariable.strSecondVarType = "factor") And (dlgDescribeTwoVariable.strVarType = "numeric" OrElse dlgDescribeTwoVariable.strVarType = "integer")) Then
            grpAnovaOptions.Enabled = True
            grpFrequenciesOptions.Enabled = False
        ElseIf ((dlgDescribeTwoVariable.strVarType = "factor") And (dlgDescribeTwoVariable.strSecondVarType = "factor")) Then
            grpFrequenciesOptions.Enabled = True
            grpAnovaOptions.Enabled = False
        End If
    End Sub
End Class