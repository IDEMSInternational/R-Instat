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
Public Class sdgAddNewDistribution
    Public bFirstLoad As Boolean = True
    Public clsCompareDist As New RFunction
    Private Sub sdgAddNewDistribution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()

    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub ucrNewDistributions_ParameterChanged() Handles ucrNewDistributions.ControlContentsChanged
        newDist()
    End Sub

    Private Sub newDist()
        clsCompareDist.ClearParameters()
        clsCompareDist.AddParameter("dist", Chr(34) & ucrNewDistributions.clsCurrDistribution.strRName & Chr(34))

        For Each clstempparam In ucrNewDistributions.clsCurrRFunction.clsParameters
            clsCompareDist.AddParameter(clstempparam.Clone())
        Next
    End Sub
End Class