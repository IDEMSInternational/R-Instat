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

Public Class dlgTwoVariableTabulate
    Private bFirstload As Boolean = True
    Private Sub dlgTwoVariableTabulate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            SetDefaults()
            bFirstload = False
        Else
            ReopenDialog()
        End If
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 415
    End Sub
    Private Sub SetDefaults()

    End Sub

    Private Sub ReopenDialog()

    End Sub
End Class