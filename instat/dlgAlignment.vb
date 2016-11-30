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

Public Class dlgAlignment
    Private Sub dlgAlignment_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        ucrMultiple.Selector = ucrAddRemove
        ucrMultiple.SetMeAsReceiver()
        ucrBase.OKEnabled(False)
        defaultSettings()
    End Sub

    Private Sub defaultSettings()
        ucrAddRemove.lstAvailableVariable.ResetText()
        ucrMultiple.lstSelectedVariables.Items.Clear()
        lstAlignment.ResetText()
        txtColumnWidth.Text = ""
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        defaultSettings()
    End Sub
End Class