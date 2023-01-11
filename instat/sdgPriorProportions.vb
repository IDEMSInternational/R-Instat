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
Public Class sdgPriorProportions
    Private bControlsInitialised As Boolean = False


    Private clsBayesInferenceFunction, clsConcatenateFunction, clsConcatenateBetaFuction As New RFunction
    Private Sub sdgPriorProportions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub
    Private Sub InitialiseControls()
        Dim dctNullHypothesis As New Dictionary(Of String, String)

        ucrNudBetaPrioirA.SetParameter(New RParameter("a", 11))
        ucrNudBetaPrioirA.SetMinMax(0, Integer.MaxValue)
        ucrNudBetaPrioirA.SetRDefault(1)

        ucrNudBetaPrioirB.SetParameter(New RParameter("b", 12))
        ucrNudBetaPrioirB.SetMinMax(-1, Integer.MaxValue)
        ucrNudBetaPrioirB.SetRDefault(1)

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
    End Sub

    Public Sub SetRFunction(clsNewConcatenateFunction As RFunction, clsNewConcatenateBetaFuction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsConcatenateFunction = clsNewConcatenateFunction
        clsConcatenateBetaFuction = clsNewConcatenateBetaFuction

        ucrNudBetaPrioirA.SetRCode(clsConcatenateBetaFuction, bReset, bCloneIfNeeded:=True)
        ucrNudBetaPrioirB.SetRCode(clsConcatenateBetaFuction, bReset, bCloneIfNeeded:=True)

        ucrNudPrioirNull.SetRCode(clsConcatenateFunction, bReset, bCloneIfNeeded:=True)
    End Sub
End Class