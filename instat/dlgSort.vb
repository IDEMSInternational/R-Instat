
' Instat-R
' Copyright (C) 2015

' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Imports RDotNet
Public Class dlgSort
    Dim newdata As DataFrame

    Private Sub dlgSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("sort")
        ucrMultiple.Selector = ucrAddRemove
        ucrMultiple.SetMeAsReceiver()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.iFunctionType = 2
        autoTranslate(Me)
    End Sub

    Private Sub ucrMultiple_Leave(sender As Object, e As EventArgs) Handles ucrMultiple.Leave
        'Dim objItem As Object
        ''Dim temp_obj As ListBox.ObjectCollection = ucrMultiple.lstSelectedVariables.Items
        'If ucrMultiple.lstSelectedVariables.Items.Count > 0 Then
        '    For Each objItem In temp_obj
        '        ucrBase.clsRsyntax.AddParameter("data_temp$" & objItem & "", "x")
        '    Next
        'End If
    End Sub

    Private Sub rdoAscending_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAscending.CheckedChanged
        If rdoAscending.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("TRUE", "decreasing")
        End If
    End Sub

    Private Sub rdoDescending_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDescending.CheckedChanged
        If rdoDescending.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("FALSE", "decreasing")
        End If
    End Sub

    Private Sub chkWriteBack_CheckStateChanged(sender As Object, e As EventArgs) Handles chkWriteBack.CheckStateChanged
        If chkWriteBack.Checked = True Then
            ucrBase.clsRsyntax.SetFunction("data_temp<-data_temp[order")
            newdata = frmMain.clsRInterface.GetData("data_temp")
            frmEditor.UpdateSheet(newdata)
        Else
            ucrBase.clsRsyntax.SetFunction("order")
        End If
    End Sub

    Private Sub chkWriteBack_CheckedChanged(sender As Object, e As EventArgs) Handles chkWriteBack.CheckedChanged

    End Sub
End Class