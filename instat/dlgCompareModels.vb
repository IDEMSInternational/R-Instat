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
Public Class dlgCompareModels
    Public bFirstLoad As Boolean = True
    Private Sub dlgCompareModels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.clsRsyntax.SetFunction("plotDist")
    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrDistributionForCompareModels_ParameterChanged() Handles ucrDistributionForCompareModels.ParameterChanged
        distParameters()
    End Sub

    Private Sub distParameters()
        ucrBase.clsRsyntax.ClearParameters()
        ucrBase.clsRsyntax.AddParameter("dist", Chr(34) & ucrDistributionForCompareModels.clsCurrDistribution.strRName & Chr(34))

        For Each clstempparam In ucrDistributionForCompareModels.clsCurrRFunction.clsParameters
            ucrBase.clsRsyntax.AddParameter(clstempparam.Clone())
        Next
    End Sub

    Private Sub cmdAddNewDistributions_Click(sender As Object, e As EventArgs) Handles cmdAddNewDistributions.Click
        sdgAddNewDistribution.ShowDialog()
    End Sub
End Class