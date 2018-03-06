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
Public Class dlgLockUnlock
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgLockUnlock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 0

        'rdo
        'ucrPnlLock.SetParameter()
        ucrPnlLock.AddRadioButton(rdoLock, Chr(34) & " " & Chr(34))
        ucrPnlLock.AddRadioButton(rdoUnlock, Chr(34) & "" & Chr(34))
        ucrPnlLock.SetRDefault(Chr(34) & " " & Chr(34)) ' rdoLock as default

        ucrChkReserveFreeSpace.SetText("Reserve Free Space")
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrChkReserveFreeSpace.Checked = False

        'clsDefaultFunction.SetRCommand()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub TestOKEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub
End Class