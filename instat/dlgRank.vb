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

Public Class dlgRank
    Private Sub dlgRank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("rank")
        ucrReceiverRank.Selector = ucrAddRemove
        ucrReceiverRank.SetMeAsReceiver()
        rdoKeptAsMissing.Checked = True
        rdoAverage.Checked = True
        ucrBase.clsRsyntax.iCallType = 1
    End Sub
    Private Sub ucrReceiverRank_Leave(sender As Object, e As EventArgs) Handles ucrReceiverRank.Leave
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverRank.GetVariables())

    End Sub
    Private Sub grpTies_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAverage.CheckedChanged, rdoMinimum.CheckedChanged, rdoMaximum.CheckedChanged, rdoFirst.CheckedChanged, rdoRandom.CheckedChanged
        If rdoAverage.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("ties.method", Chr(34) & "average" & Chr(34))
        ElseIf rdoMinimum.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("ties.method", Chr(34) & "minimum" & Chr(34))
        ElseIf rdoMaximum.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("ties.method", Chr(34) & "maximum" & Chr(34))
        ElseIf rdoFirst.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("ties.method", Chr(34) & "first" & Chr(34))
        ElseIf rdoRandom.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("ties.method", Chr(34) & "random" & Chr(34))
        End If

    End Sub

    Private Sub rdoKeptAsMissing_CheckedChanged(sender As Object, e As EventArgs) Handles rdoKeptAsMissing.CheckedChanged, rdoFirstMissingValues.CheckedChanged, rdoLast.CheckedChanged
        If rdoKeptAsMissing.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("na.last", Chr(34) & "keep" & Chr(34))
        ElseIf rdoFirstMissingValues.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("na.last", "FALSE")
        ElseIf rdoLast.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("na.last", "TRUE")
        End If
    End Sub
End Class
