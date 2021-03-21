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
Public Class sdgFrequency
    Private bFirstLoad As Boolean
    Private bReset As Boolean
    Private Sub sdgFrequency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        bReset = False

    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub InitialiseDialog()
        ucrchkDisplay.SetText("How to Display")
        ucrchkMargins.SetText("Margins to Dispaly")
        ucrchkDisplay.AddToLinkedControls(ucrPnlDisplayType, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDisplayType.AddRadioButton(rdoSeparateTables)
        ucrPnlDisplayType.AddRadioButton(rdoVertically)
        ucrPnlDisplayType.AddRadioButton(rdoHorizontally)
    End Sub

End Class