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


    'Provides utility functions For managing user interactions With reset operations across multiple dialogs.

    ' Public method to attempt a reset with warning
    ' Returns True if user confirms reset; otherwise False
    Public Shared Function ConfirmReset() As Boolean
        Dim result As MsgBoxResult = MsgBox("Warning: clicking reset will lose all values currently in the receivers",
                                            MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "Warning")
        Return result = MsgBoxResult.Ok
    End Function

End Class

