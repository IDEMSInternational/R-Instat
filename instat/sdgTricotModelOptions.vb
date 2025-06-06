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
    Private bControlsInitialised As Boolean = False
    Private bRCodeSet As Boolean = True
    Private clsRSyntax As New RSyntax
    Public clsPladmmFunction As New RFunction

    Public enumTricotModelOptionsMode As String = TricotModelOptionsMode.ModelOneVarCov

    Public Enum TricotModelOptionsMode
        ModelOneVarCov
        ModellingGeneral
    End Enum

    Private Sub sdgTricotModelOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        setHelpOptions()
    End Sub

    Private Sub InitialiseControls()

        ucrChkPenaltyPar.SetText("Penalty Parameter")
        ucrChkPenaltyPar.AddToLinkedControls(ucrNudPenaltyPar, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)

        ucrNudPenaltyPar.SetParameter(New RParameter("rho"))
        ucrNudPenaltyPar.Increment = 1
        ucrNudPenaltyPar.SetMinMax(iNewMin:=1, iNewMax:=200000000)
        ucrNudPenaltyPar.SetRDefault(1)

        ucrChkNumberIt.SetText("Number of Iterations")

        ucrInputNumberIt.SetParameter(New RParameter("n_iter"))
        ucrInputNumberIt.SetValidationTypeAsNumeric()

        ucrInputConvTotal.SetParameter(New RParameter("rtol"))
        ucrInputConvTotal.SetValidationTypeAsNumeric()

        ucrChkConvTotal.SetText("Convergence Total")

    End Sub

    Public Sub SetRCode(clsNewRFunction As RFunction, clsNewRSyntax As RSyntax, Optional bReset As Boolean = False)
        ucrInputNumberIt.SetText("500")
        ucrInputConvTotal.SetText("0.0001")
        bRCodeSet = False

        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsRSyntax = clsNewRSyntax
        clsPladmmFunction = clsNewRFunction
        If bReset Then
            ucrChkPenaltyPar.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkConvTotal.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkNumberIt.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
        End If

        AddRemoveParameters()
    End Sub

    Private Sub AddRemoveParameters()
        If ucrChkPenaltyPar.Checked Then
            ucrNudPenaltyPar.Visible = True
            clsPladmmFunction.AddParameter("rho", ucrNudPenaltyPar.GetText, iPosition:=3)
            ucrNudPenaltyPar.SetRDefault(1)
        Else
            clsPladmmFunction.RemoveParameterByName("rho")
            ucrNudPenaltyPar.Visible = False
        End If

        If ucrChkNumberIt.Checked Then
            ucrInputNumberIt.Visible = True
            ucrInputNumberIt.SetRDefault(500)
            clsPladmmFunction.AddParameter("n_iter", ucrInputNumberIt.GetText, iPosition:=4)
        Else
            clsPladmmFunction.RemoveParameterByName("n_iter")
            ucrInputNumberIt.Visible = False
        End If

        If ucrChkConvTotal.Checked Then
            ucrInputConvTotal.Visible = True
            ucrInputConvTotal.SetRDefault(0.0001)
            clsPladmmFunction.AddParameter("rtol", ucrInputConvTotal.GetText, iPosition:=5)
        Else
            clsPladmmFunction.RemoveParameterByName("rtol")
            ucrInputConvTotal.Visible = False
        End If
    End Sub

    Private Sub setHelpOptions()
        Select Case enumTricotModelOptionsMode
            Case TricotModelOptionsMode.ModelOneVarCov
                ucrSdgButton.iHelpTopicID = 725
            Case TricotModelOptionsMode.ModellingGeneral
                ucrSdgButton.iHelpTopicID = 727
        End Select
    End Sub

    Private Sub ucrChecks_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPenaltyPar.ControlValueChanged,
        ucrChkNumberIt.ControlValueChanged, ucrChkConvTotal.ControlValueChanged, ucrNudPenaltyPar.ControlValueChanged, ucrInputConvTotal.ControlValueChanged
        AddRemoveParameters()
    End Sub

End Class