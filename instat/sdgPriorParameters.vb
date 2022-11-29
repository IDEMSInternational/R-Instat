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

    Public clsBayesIferenceFunction, clsConcatenateFunction As New RFunction

    Private Sub sdgPriorParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ucrNudPrioirNull.SetParameter(New RParameter("H1", 0))
        dctNullHypothesis.Add("0.1", "0.1")
        dctNullHypothesis.Add("0.2", "0.2")
        dctNullHypothesis.Add("0.5", "0.5")
        dctNullHypothesis.Add("0.8", "0.8")
        dctNullHypothesis.Add("0.9", "0.9")
        ucrNudPrioirNull.SetItems(dctNullHypothesis)
        ucrNudPrioirNull.AddQuotesIfUnrecognised = False
        ucrNudPrioirNull.SetValidationTypeAsNumeric(dcmMin:=0.0, bIncludeMin:=True, dcmMax:=1.0, bIncludeMax:=True)
        ucrNudPrioirNull.bAllowNonConditionValues = True
        ucrNudPrioirNull.SetRDefault(0.5)

        ucrInputPriorFamily.SetParameter(New RParameter("prior", 14))
        dctPriorFamily.Add("Jeffreys-reference prior", Chr(34) & "JZS" & Chr(34))
        dctPriorFamily.Add("Unit Information prior", Chr(34) & "JUI" & Chr(34))
        dctPriorFamily.Add("Normal-Gamma prior", Chr(34) & "NG" & Chr(34))
        ucrInputPriorFamily.SetItems(dctPriorFamily)
        ucrInputPriorFamily.SetRDefault("JSZ")
        ucrInputPriorFamily.SetDropDownStyleAsNonEditable()

        ucrNudSampleSize.SetLinkedDisplayControl(lblSampleSize)
        ucrNudScaleParameter.SetLinkedDisplayControl(lblScalingParameter)
        ucrNudStandardDeviation.SetLinkedDisplayControl(lblStandardDeviation)
        ucrNudDegreesFreedom.SetLinkedDisplayControl(lblDegreesFreedom)
        ucrNudPrioirNull.SetLinkedDisplayControl(lblPrioir)
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
        ucrNudPrioirNull.SetRCode(clsConcatenateFunction, bReset, bCloneIfNeeded:=True)
    End Sub
End Class