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
Public Class dlgRemoveUnusedLabels
    Private Sub dlgRemoveUnusedLabels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("droplevels")
        ucrSelectedVariable.Selector = ucrAddRemove
        ucrSelectedVariable.SetMeAsReceiver()
        autoTranslate(Me)

    End Sub
    Private Sub ucrSelectedVariable_Leave(sender As Object, e As EventArgs) Handles ucrSelectedVariable.Leave
        ucrBase.clsRsyntax.AddParameter("X", ucrSelectedVariable.GetVariableNames())

    End Sub
End Class