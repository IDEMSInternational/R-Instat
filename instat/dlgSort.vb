
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
Imports RDotNet
Public Class dlgSort
    Private Sub UcrButtons1_clickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strScript As String
        Dim temp
        Dim bFirst As Boolean
        Dim newdata As DataFrame
        bFirst = True


        If rdoAscending.Checked = True Then
            If UcrDataSelection1.lstSelectedVariables.Items.Count > 0 Then
                strScript = "data<-data[order(data["
                For Each temp In UcrDataSelection1.lstSelectedVariables.Items
                    If bFirst Then
                        bFirst = False
                    Else
                        strScript = strScript & "],data["
                    End If
                    strScript = strScript & Chr(34) & temp.ToString & Chr(34)
                Next
                strScript = strScript & "]),]"
                frmMain.clsRInterface.RunScript(strScript, False)
            End If
            newdata = frmMain.clsRInterface.GetData("data")
            frmEditor.UpdateSheet(newdata)
        End If


        If rdoDescending.Checked = True Then
            If UcrDataSelection1.lstSelectedVariables.Items.Count > 0 Then
                strScript = "data<-data[order(data["
                For Each temp In UcrDataSelection1.lstSelectedVariables.Items
                    If bFirst Then
                        bFirst = False
                    Else
                        strScript = strScript & "],data["
                    End If
                    strScript = strScript & Chr(34) & temp.ToString & Chr(34)
                Next
                strScript = strScript & "],decreasing=TRUE),]"
                frmMain.clsRInterface.RunScript(strScript, False)
            End If
            newdata = frmMain.clsRInterface.GetData("data")
            frmEditor.UpdateSheet(newdata)
        End If
        Me.Close()
    End Sub

    Private Sub dlgSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdoAscending.Checked = True
        ucrBase.clsRsyntax.SetFunction("order")
        ucrBase.clsRsyntax.iCallType = -1
        autoTranslate(Me)
    End Sub


End Class