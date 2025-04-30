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
Public Class sdgTricotModelOptions
    Public clsPladmmFunction As New RFunction

    Private Sub sdgTricotModelOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()

        ucrNudPenaltyPar.SetParameter(New RParameter("rho"))
        ucrNudPenaltyPar.DecimalPlaces = 2
        ucrNudPenaltyPar.Increment = 1
        ucrNudPenaltyPar.SetRDefault(1)

        ucrChkPenaltyPar.AddToLinkedControls(ucrNudPenaltyPar, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkPenaltyPar.SetText("Penalty Parameter")

        ucrNudNumberIt.SetParameter(New RParameter("n_iter"))
        ucrNudNumberIt.Increment = 1
        ucrNudNumberIt.SetRDefault(500)

        ucrChkNumberIt.AddToLinkedControls(ucrNudNumberIt, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkNumberIt.SetText("Number of Iterations")

        ucrInputConvTotal.SetParameter(New RParameter("rtol"))
        ucrInputConvTotal.SetValidationTypeAsNumeric()
        ucrInputConvTotal.SetRDefault(0.0001)

        ucrChkConvTotal.AddToLinkedControls(ucrInputConvTotal, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkConvTotal.SetText("Convergence Total")

    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction)
        clsPladmmFunction = clsNewRFunction
    End Sub

    Private Sub AddRemoveParameters()
        If ucrChkPenaltyPar.Checked Then
            clsPladmmFunction.AddParameter("rho", ucrNudPenaltyPar.GetText, iPosition:=3)
        Else
            clsPladmmFunction.RemoveParameterByName("rho")
        End If

        If ucrChkNumberIt.Checked Then
            clsPladmmFunction.AddParameter("n_iter", ucrNudNumberIt.GetText, iPosition:=4)
        Else
            clsPladmmFunction.RemoveParameterByName("n_iter")
        End If

        If ucrChkConvTotal.Checked Then
            clsPladmmFunction.AddParameter("rtol", ucrInputConvTotal.GetText, iPosition:=5)
        Else
            clsPladmmFunction.RemoveParameterByName("rtol")
        End If
    End Sub

    Private Sub ucrChecks_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPenaltyPar.ControlValueChanged,
        ucrChkNumberIt.ControlValueChanged, ucrChkConvTotal.ControlValueChanged
        AddRemoveParameters()
    End Sub
End Class