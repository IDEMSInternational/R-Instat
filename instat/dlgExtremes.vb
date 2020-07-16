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

Imports instat
Imports instat.Translations

Public Class dlgExtremes
    Private clsFevdFunction As New RFunction
    Private clsPlotsFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True


    Private Sub dlgExtremes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)

        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrSelectorExtremes.SetParameter(New RParameter("data", 0))
        ucrSelectorExtremes.SetParameterIsrfunction()

        ucrReceiverVariable.Selector = ucrSelectorExtremes
        ucrReceiverVariable.strSelectorHeading = "Variables"
        ucrReceiverVariable.SetParameter(New RParameter("x", 0))
        'ucrReceiverVariable.SetParameterIsString()

        ucrInputExtremes.SetItems({"GEV", "GP", "PP", "Gumbel", "Exponential"}, bAddConditions:=True)
        ucrInputExtremes.SetName("GEV")
        ucrInputExtremes.SetDropDownStyleAsNonEditable()

    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverVariable.SetRCode(clsFevdFunction, bReset)
        ucrInputExtremes.SetRCode(clsFevdFunction, bReset)
    End Sub
    Private Sub SetDefaults()
        clsFevdFunction = New RFunction
        clsPlotsFunction = New RFunction

        clsPlotsFunction.SetPackageName("extRemes")
        clsPlotsFunction.SetRCommand("plot")

        clsFevdFunction.SetPackageName("extRemes")
        clsFevdFunction.SetRCommand("fevd")

        clsFevdFunction.AddParameter("type", Chr(34) & "GEV" & Chr(34), iPosition:=1)
        clsFevdFunction.AddParameter("method", Chr(34) & "MLE" & Chr(34), iPosition:=2)

        ucrBase.clsRsyntax.SetBaseRFunction(clsPlotsFunction)
    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrInputExtremes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputExtremes.ControlValueChanged
        clsFevdFunction.AddParameter("type", ucrInputExtremes.GetText(), iPosition:=1)
    End Sub
End Class