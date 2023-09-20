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
Public Class sdgRenameScript

    Public strCurrentScriptName As String = ""
    Private Sub sdgRenameScript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefault()
    End Sub

    Private Sub SetDefault()
        ucrInputCurrentName.IsReadOnly = True
        ucrInputCurrentName.SetText(strCurrentScriptName)
        ucrInputNewName.SetText(strCurrentScriptName)
    End Sub

    Private Sub ucrBaseSubdialog_ClickReturn(sender As Object, e As EventArgs) Handles ucrBaseSubdialog.ClickReturn
        frmMain.ucrScriptWindow.RenameScript(ucrInputNewName.GetText)
    End Sub
End Class