' Instat+R
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
Public Class Geoms
    Public strGeomName As String
    Public clsAes As New List(Of GeomAes)
    Public clsGeomParameter As New List(Of GeomParameters)

    Public Sub AddGeomParameter(strGeomParameterName As String, Optional ParameterValue As String = "")
        'will be adding parameters to the geom as well as the value of the parameter.

    End Sub

    Public Sub AddGeomAes(strGeomAes As String)
        'will pass the Geom Aesthetics


    End Sub

End Class

Public Class GeomAes
    'contains info about the geom aesthetics
    Public strAesName As String

End Class

Public Class GeomParameters
    'contains info about the geom Parameters
    Public strGeomParameterName As String

End Class
