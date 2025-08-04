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

Public Class clsWarningMessage
    ' Indicates whether to show the reset warning message
    Public Shared Property ShowWarning As Boolean = True

    ' Public method to attempt a reset with optional warning
    Public Shared Function ConfirmReset() As Boolean
        If Not ShowWarning Then
            Return True
        End If

        Dim result As MsgBoxResult = MsgBox("Warning: clicking reset will lose all values currently in the receivers",
                                            MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "Warning")
        Return result = MsgBoxResult.Ok
    End Function

    Public Shared Function ConfirmDelete() As Boolean
        If Not ShowWarning Then Return True

        Dim result As MsgBoxResult = MsgBox("Are you sure you want to delete these column(s)?" & Environment.NewLine & "This action cannot be undone.",
                                        MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Delete Column")
        Return result = MsgBoxResult.Yes
    End Function

End Class

