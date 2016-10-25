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
Public Class sdgClimdexIndices
    Public clsRFrostDays, clsRIcingDays, clsRSummerDays, clsRTropicalNights As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub sdgClimdexIndices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Public Sub FrostDays()
        dlgClimdex.ucrBaseClimdex.clsRsyntax.iCallType = 2
        clsRFrostDays.SetRCommand("climdex.fd")
        clsRFrostDays.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsRClimdexInput)
        dlgClimdex.ucrBaseClimdex.clsRsyntax.SetBaseRFunction(clsRFrostDays)
    End Sub

    Public Sub SummerDays()
        dlgClimdex.ucrBaseClimdex.clsRsyntax.iCallType = 2
        clsRSummerDays.SetRCommand("climdex.su")
        clsRSummerDays.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsRClimdexInput)
        dlgClimdex.ucrBaseClimdex.clsRsyntax.SetBaseRFunction(clsRSummerDays)
    End Sub

    Public Sub IcingDays()
        dlgClimdex.ucrBaseClimdex.clsRsyntax.iCallType = 2
        clsRIcingDays.SetRCommand("climdex.id")
        clsRIcingDays.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsRClimdexInput)
        dlgClimdex.ucrBaseClimdex.clsRsyntax.SetBaseRFunction(clsRIcingDays)
    End Sub

    Private Sub chkClimdexIndices_CheckedChanged(sender As Object, e As EventArgs) Handles chkFrostDays.CheckedChanged, chkIcingDays.CheckedChanged, chkSummerDays.CheckedChanged, chkTropicalNights.CheckedChanged
        IndicesOptions()
    End Sub

    Public Sub TropicalNights()
        dlgClimdex.ucrBaseClimdex.clsRsyntax.iCallType = 2
        clsRTropicalNights.SetRCommand("climdex.tn")
        clsRTropicalNights.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsRClimdexInput)
        dlgClimdex.ucrBaseClimdex.clsRsyntax.SetBaseRFunction(clsRTropicalNights)
    End Sub

    Public Sub SetDefaults()
        chkFrostDays.Checked = True
    End Sub

    Public Sub IndicesOptions()
        If (chkFrostDays.Checked = True) Then
            FrostDays()
        End If
        If (chkSummerDays.Checked = True) Then
            SummerDays()
        End If
        If (chkIcingDays.Checked = True) Then
            IcingDays()
        End If
        If (chkTropicalNights.Checked = True) Then
            TropicalNights()
        End If
    End Sub
End Class