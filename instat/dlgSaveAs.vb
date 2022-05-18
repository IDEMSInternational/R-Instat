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
Public Class dlgSaveAs
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSaveFunction As New RFunction

    Private Sub dlgSaveAs_Load(sender As Object, e As EventArgs) Handles Me.Load
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
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 332

        ucrFilePath.SetPathControlParameter(New RParameter("file", 0))

        lblConfirm.Visible = False
        lblConfirm.ForeColor = Color.Green
    End Sub

    Private Sub SetDefaults()
        clsSaveFunction = New RFunction

        ucrFilePath.ResetPathControl()

        clsSaveFunction.SetRCommand("saveRDS")
        clsSaveFunction.AddParameter("object", frmMain.clsRLink.strInstatDataObject)

        ucrBase.clsRsyntax.SetBaseRFunction(clsSaveFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrFilePath.SetPathControlRcode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If ucrFilePath.IsEmpty() Then
            lblConfirm.Visible = False
            ucrBase.OKEnabled(False)
        Else
            lblConfirm.Visible = True
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        frmMain.strSaveFilePath = ucrFilePath.FilePath
        frmMain.clsRecentItems.addToMenu(Replace(ucrFilePath.FilePath, "\", "/"))
        frmMain.bDataSaved = True
    End Sub

    Private Sub ucrFilePath_FilePathChanged() Handles ucrFilePath.FilePathChanged
        TestOKEnabled()
    End Sub

End Class
