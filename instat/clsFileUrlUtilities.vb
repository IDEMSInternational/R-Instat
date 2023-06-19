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

Imports System.IO
Imports RDotNet
Public Class clsFileUrlUtilities

    ''' <summary>
    ''' Returns the URL of the package HTML file.
    ''' </summary>
    ''' <param name="strPackageName"> The package name. </param>
    ''' <param name="strTopic"> The package topic. </param>
    ''' <param name="bVignette"> Check if we need to return the URL of the package vignette file. </param>
    ''' <returns></returns>
    Public Shared Function GetHelpFileURL(strPackageName As String, Optional strTopic As String = "", Optional bVignette As Boolean = False) As String
        Dim clsGetPortFunction As New RFunction

        clsGetPortFunction.SetPackageName("tools")
        clsGetPortFunction.SetRCommand("startDynamicHelp")
        clsGetPortFunction.AddParameter("start", "NA", iPosition:=0)

        Dim expPortTemp As SymbolicExpression
        expPortTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetPortFunction.ToScript(), bSeparateThread:=False)
        Dim strPort As String = ""
        If expPortTemp IsNot Nothing AndAlso expPortTemp.Type <> Internals.SymbolicExpressionType.Null Then
            strPort = expPortTemp.AsInteger(0)
        End If

        Dim strFilePath As String = Path.Combine("library", strPackageName, "html", "00Index.html")
        If strTopic <> "" Then
            strFilePath = Path.Combine("library", strPackageName, "html", String.Concat(strTopic, ".html"))
        End If

        Dim strLocalHost As String = "127.0.0.1:"
        Dim strURL As String = Path.Combine(String.Concat("http://", strLocalHost), strPort, strFilePath)

        If bVignette Then
            Dim clsGetVignetteFunction As New RFunction

            clsGetVignetteFunction.SetRCommand("get_vignette")
            clsGetVignetteFunction.AddParameter("package", Chr(34) & strPackageName & Chr(34), iPosition:=0)
            strURL = frmMain.clsRLink.RunInternalScriptGetValue(clsGetVignetteFunction.ToScript(), bSeparateThread:=False).AsCharacter(0)
        End If

        If strURL <> "" Then
            strURL = strURL.Replace("\", "/")
        End If
        Return strURL
    End Function
End Class
