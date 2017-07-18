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


Public Class dlgOutputforCDT
    Public bFirstLoad As Boolean = True

    Private Sub ucrInputFileName_Leave(sender As Object, e As EventArgs) Handles ucrInputFileName.Leave
        ucrBase.clsRsyntax.AddParameter("Filename", Chr(34) & ucrInputFileName.Text & Chr(34))

    End Sub


    Private Sub ucrInputInterestedVariables_Leave(sender As Object, e As EventArgs) Handles ucrInputInterestedVariables.Leave
        ucrBase.clsRsyntax.AddParameter("Interested_vaiables", Chr(34) & ucrInputInterestedVariables.Text & Chr(34))

    End Sub

    Private Sub dlgOutputforCDT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)



        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()

    End Sub

    Private Sub TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction("climate_obj$output_for_CDT")
    End Sub
    Private Sub SetDefaults()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
End Class


