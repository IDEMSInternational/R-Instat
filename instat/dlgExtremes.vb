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

Public Class dlgExtremes
    Private clsFevdFunction As New RFunction
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
    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverVariable.SetRCode(clsFevdFunction, bReset)
    End Sub
    Private Sub SetDefaults()
        clsFevdFunction = New RFunction

        clsFevdFunction.SetPackageName("extRemes")
        clsFevdFunction.SetRCommand("fevd")
    End Sub

    Private Sub TestOkEnabled()

    End Sub
End Class