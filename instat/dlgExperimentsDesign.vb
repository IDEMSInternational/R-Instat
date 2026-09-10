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
Public Class dlgExperimentsDesign

    Private bFirstLoad As Boolean = True

    Private Sub dlgExperimentsDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

    End Sub

    Private Sub InitialiseDialog()


    End Sub

    Private Sub SetDefaults()

        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)


    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverFirstVariables_Load(sender As Object, e As EventArgs) Handles ucrReceiverFirstVariables.Load

    End Sub

    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load

    End Sub

    Private Sub ucrSaveExperimentsDesign_Load(sender As Object, e As EventArgs) Handles ucrSaveExperimentsDesign.Load

    End Sub

    Private Sub ucrSelectorExperimentsDesign_Load(sender As Object, e As EventArgs) Handles ucrSelectorExperimentsDesign.Load

    End Sub
End Class



