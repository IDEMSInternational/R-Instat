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
Public Class sdgDistributionOptions
    Private bInitialiseControls As Boolean = True
    Private clsLabsFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private Sub sdgDistributionOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()

    End Sub

    Public Sub SetRCode(clsNewLabsFunction As RFunction, clsNewThemeFunction As RFunction, Optional bReset As Boolean = False)
        If bInitialiseControls Then
            InitialiseControls()
            bInitialiseControls = False
        End If

        clsThemeFunction = clsNewThemeFunction
        clsLabsFunction = clsNewLabsFunction


    End Sub
End Class