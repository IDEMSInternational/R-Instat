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

Public Class Distribution
    Public strNameTag As String
    Public strPackagName As String = ""
    Public strRName As String = ""
    Public bIncluded As Boolean = True
    Public strRFunctionName As String = ""
    Public strPFunctionName As String = ""
    Public strQFunctionName As String = ""
    Public strDFunctionName As String = ""
    Public strExactName As String = ""
    Public strGLMFunctionName As String = ""
    Public bNumeric As Boolean = False
    Public bFactor As Boolean = False
    Public bTwoLevelFactor As Boolean = False
    Public bPositiveInt As Boolean = False
    Public bIsContinuous As Boolean = True
    Public bIsExact As Boolean = False
    Public lstExact As String() ' Seven values in the string, {R-Code, Label, nudValue, nudIncrements, nudDecimalPlace, nudMin, nudMax}
    Public clsParameters As New List(Of DistributionParameter)

    Public Sub SetNameTag(strTemp As String)
        strNameTag = strTemp
    End Sub

    Public Sub AddParameter(strArgumentName As String, strNameTag As String, Optional strDefaultValue As String = "")
        Dim NewParameter As New DistributionParameter
        NewParameter.strArgumentName = strArgumentName
        NewParameter.strNameTag = strNameTag
        If Not strDefaultValue = "" Then
            NewParameter.SetDefaultValue(strDefaultValue)
        End If
        clsParameters.Add(NewParameter)
    End Sub

    Public Function IsDistributionFunction(strFunctionName As String) As Boolean
        Dim strNames() As String = {strRFunctionName, strPFunctionName, strQFunctionName, strDFunctionName, strExactName, strGLMFunctionName}
        Return strNames.Contains(strFunctionName)
    End Function
End Class

Public Class DistributionParameter
    Public strArgumentName As String
    Public strNameTag As String
    Public strDefaultValue As String
    Public bHasDefault As Boolean = False

    Public Sub SetDefaultValue(Val As String)
        strDefaultValue = Val
        bHasDefault = True
    End Sub
End Class