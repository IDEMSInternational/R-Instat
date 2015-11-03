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

Public Class RSyntax
    Dim strScript As String
    Public Sub manage(lstOfString As Object, type As String)
        Select Case type
            Case "regular"
                strScript = "capture.output(seq(from = " & Convert.ToInt32(lstOfString(0)) & ", to = " & Convert.ToInt32(lstOfString(1)) & ", by = " & Convert.ToInt32(lstOfString(2)) & "))"
                frmMain.clsRInterface.RunScript(strScript)
            Case "repeated"
                strScript = "capture.output(seq(from = " & Convert.ToInt32(lstOfString(0)) & ", to = " & Convert.ToInt32(lstOfString(0)) & ", length.out = " & Convert.ToInt32(lstOfString(1)) & "))"
                frmMain.clsRInterface.RunScript(strScript)
            Case "date"
                strScript = "capture.output(seq(from = as.Date('" & Format(lstOfString(0), "yyyy/MM/dd") & "'), to = as.Date('" & Format(lstOfString(1), "yyyy/MM/dd") & "'), by = '" & lstOfString(2) & "'))"
                frmMain.clsRInterface.RunScript(strScript)
        End Select

    End Sub

    Public Sub graphics(strString As String, submenu As String)



    End Sub

    Public Sub statistcs(strString As String, submenu As String)



    End Sub

    Public Sub climatic(strString As String, submenu As String)



    End Sub

End Class
