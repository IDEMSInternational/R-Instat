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
    Public clsGgParameters As New List(Of GgParameters)



    Public Sub AddGgParameter(strGgParameterName As String, Optional strGgParameterValue As String = Nothing, Optional strIncludedDataTypes As String() = Nothing, Optional strExcludedDataTypes As String() = Nothing)
        'will be adding parameters to the geom as well as the value of the parameter.
        Dim NewGgParameter As New GgParameters
        NewGgParameter.strGgParameterName = strGgParameterName
        NewGgParameter.strGgParameterValue = strGgParameterValue
        NewGgParameter.strIncludedDataTypes = strIncludedDataTypes
        NewGgParameter.strExcludedDataTypes = strExcludedDataTypes
        clsGgParameters.Add(NewGgParameter)
    End Sub
End Class

Public Class GgParameters
    'contains info about the geom aesthetics and urguments for the geom
    Public strGgParameterName As String
    Public strIncludedDataTypes As String()
    Public strExcludedDataTypes As String()
    Public strGgParameterValue As String

End Class




