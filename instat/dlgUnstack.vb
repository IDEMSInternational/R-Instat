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

Public Class dlgUnstack
    Public bFirstLoad As Boolean = True
    Private Sub dlgUnstack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("spread")
        ucrBase.iHelpTopicID = 58

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        'Checks if Ok can be enabled.
        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub ReopenDialog()


    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub ucrSelectorForUnstack_DataFrameChanged() Handles ucrSelectorForUnstack.DataFrameChanged


    End Sub

    Private Sub ucrFactorToUnstackReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorToUnstackReceiver.SelectionChanged

    End Sub


    Private Sub ucrColumnToUnstackReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrColumnToUnstackReceiver.SelectionChanged


    End Sub

    Private Sub chkKeepUnusedFactorLevels_CheckedChanged(sender As Object, e As EventArgs) Handles chkKeepUnusedFactorLevels.CheckedChanged



    End Sub


End Class

