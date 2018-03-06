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
Public Class dlgReorderMetadata
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private Sub dlgReorderMetadata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            setDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        ReopenDialog()
        TestOKEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub InitialiseDialog()
        ucrReorderMetadata.setDataframes(ucrDataFrameReoderMetadata)
        ucrReorderMetadata.setDataType("metadata")
        ucrBase.iHelpTopicID = 56
    End Sub

    Private Sub setDefaults()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub
End Class