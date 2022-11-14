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
Public Class sdgPriorParameters

    Private bControlsInitialised As Boolean = False
    Public bFirstLoad As Boolean = True
    Private bRcodeSet As Boolean = True


    Public clsBayesIferenceFunction, clsConcatenateFunction, clsDummyFunction As RFunction
    Private clsRsyntax As RSyntax

    Private Sub sdgPriorParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        ucrNudSampleSize.SetParameter(New RParameter("n_0", 10))
        ucrNudSampleSize.SetMinMax(1, Integer.MaxValue)
        ucrNudSampleSize.SetRDefault(1)

        ucrNudStandardDeviation.SetParameter(New RParameter("s_0", 11))
        ucrNudStandardDeviation.SetMinMax(0, Integer.MaxValue)
        ucrNudStandardDeviation.SetRDefault(0)

        ucrNudDegreesFreedom.SetParameter(New RParameter("v_0", 12))
        ucrNudDegreesFreedom.SetMinMax(-1, Integer.MaxValue)
        ucrNudDegreesFreedom.SetRDefault(-1)

        ucrNudScaleParameter.SetParameter(New RParameter("rscale", 13))
        ucrNudScaleParameter.SetMinMax(1, Integer.MaxValue)
        ucrNudScaleParameter.SetRDefault(1)

        ucrNudPrioirNull.SetParameter(New RParameter("H1", 0))
        ucrNudPrioirNull.SetMinMax(0, 1)
        ucrNudPrioirNull.DecimalPlaces = 2
        ucrNudPrioirNull.Increment = 0.05
        ucrNudPrioirNull.SetRDefault(0.5)

        ucrNudAlternativePrioir.SetParameter(New RParameter("H2", 1))
        ucrNudAlternativePrioir.SetMinMax(0, 1)
        ucrNudAlternativePrioir.DecimalPlaces = 2
        ucrNudAlternativePrioir.Increment = 0.05
        ucrNudAlternativePrioir.SetRDefault(0.5)

        ucrNudSampleSize.SetLinkedDisplayControl(lblSampleSize)
        ucrNudScaleParameter.SetLinkedDisplayControl(lblScalingParameter)
        ucrNudStandardDeviation.SetLinkedDisplayControl(lblStandardDeviation)
        ucrNudDegreesFreedom.SetLinkedDisplayControl(lblDegreesFreedom)
        ucrNudAlternativePrioir.SetLinkedDisplayControl(lblAlternative)
        ucrNudPrioirNull.SetLinkedDisplayControl(lblPrioir)

    End Sub
    Public Sub SetRFunction(clsNewRSyntax As RSyntax, clsNewBayesIferenceFunction As RFunction, clsNewDummyFunction As RFunction, clsNewConcatenateFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsBayesIferenceFunction = clsNewBayesIferenceFunction
        clsConcatenateFunction = clsNewConcatenateFunction
        clsDummyFunction = clsNewDummyFunction
        clsRsyntax = clsNewRSyntax


        ucrNudSampleSize.SetRCode(clsBayesIferenceFunction, bReset, bCloneIfNeeded:=True)
        ucrNudDegreesFreedom.SetRCode(clsBayesIferenceFunction, bReset, bCloneIfNeeded:=True)
        ucrNudScaleParameter.SetRCode(clsBayesIferenceFunction, bReset, bCloneIfNeeded:=True)
        ucrNudStandardDeviation.SetRCode(clsBayesIferenceFunction, bReset, bCloneIfNeeded:=True)
        ucrNudPrioirNull.SetRCode(clsConcatenateFunction, bReset, bCloneIfNeeded:=True)
        ucrNudAlternativePrioir.SetRCode(clsConcatenateFunction, bReset, bCloneIfNeeded:=True)
    End Sub
End Class