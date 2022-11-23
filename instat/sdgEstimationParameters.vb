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
Public Class sdgEstimationParameters

    Private bControlsInitialised As Boolean = False
    Public bFirstLoad As Boolean = True
    Public clsBayesIferenceFunction, clsConcatenateFunction As New RFunction
    Private Sub sdgEstimationParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub
    Private Sub InitialiseControls()
        Dim dctNullHypothesis As New Dictionary(Of String, String)
        Dim dctPriorFamily As New Dictionary(Of String, String)
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

        ucrInputPriorFamily.SetParameter(New RParameter("prior", 14))
        dctPriorFamily.Add("Jeffreys-reference prior", Chr(34) & "JZS" & Chr(34))
        dctPriorFamily.Add("Unit Information prior", Chr(34) & "JUI" & Chr(34))
        dctPriorFamily.Add("Improper uniform prior", Chr(34) & "ref" & Chr(34))
        dctPriorFamily.Add("Normal-Gamma prior", Chr(34) & "NG" & Chr(34))
        ucrInputPriorFamily.SetItems(dctPriorFamily)
        ucrInputPriorFamily.SetRDefault("JSZ")
        ucrInputPriorFamily.SetDropDownStyleAsNonEditable()

        ucrInputPriorMean.SetParameter(New RParameter("mu_0", 15))
        ucrInputPriorMean.SetValidationTypeAsNumeric()
        ucrInputPriorMean.AddQuotesIfUnrecognised = False
        ucrInputPriorMean.SetValidationTypeAsNumeric(dcmMin:=0.0, bIncludeMin:=True, dcmMax:=Integer.MaxValue, bIncludeMax:=True)

        ucrNudSampleSize.SetLinkedDisplayControl(lblSampleSize)
        ucrNudScaleParameter.SetLinkedDisplayControl(lblScalingParameter)
        ucrNudStandardDeviation.SetLinkedDisplayControl(lblStandardDeviation)
        ucrNudDegreesFreedom.SetLinkedDisplayControl(lblDegreesFreedom)
        ucrInputPriorFamily.SetLinkedDisplayControl(lblPriorFamily)
        ucrInputPriorMean.SetLinkedDisplayControl(lblPriorMean)
    End Sub
    Public Sub SetRFunction(clsNewBayesIferenceFunction As RFunction, clsNewConcatenateFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsBayesIferenceFunction = clsNewBayesIferenceFunction
        clsConcatenateFunction = clsNewConcatenateFunction

        ucrNudSampleSize.SetRCode(clsBayesIferenceFunction, bReset, bCloneIfNeeded:=True)
        ucrNudDegreesFreedom.SetRCode(clsBayesIferenceFunction, bReset, bCloneIfNeeded:=True)
        ucrNudScaleParameter.SetRCode(clsBayesIferenceFunction, bReset, bCloneIfNeeded:=True)
        ucrNudStandardDeviation.SetRCode(clsBayesIferenceFunction, bReset, bCloneIfNeeded:=True)
        ucrInputPriorFamily.SetRCode(clsBayesIferenceFunction, bReset, bCloneIfNeeded:=True)
        ucrInputPriorMean.SetRCode(clsBayesIferenceFunction, bReset, bCloneIfNeeded:=True)
    End Sub
End Class