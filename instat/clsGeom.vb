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

Public Class Geoms
    Public strGeomName As String = ""
    Public clsAesParameters As New List(Of AesParameters)
    Public clsLayerParameters As New List(Of LayerParameter)

    Public Sub SetGeomName(strTempName As String)
        strGeomName = strTempName
    End Sub

    Public Sub AddAesParameter(strAesParameterName As String, Optional strAesParameterValue As String = Nothing, Optional strIncludedDataTypes As String() = Nothing, Optional strExcludedDataTypes As String() = Nothing, Optional bIsMandatory As Boolean = False)
        'will be adding parameters to the geom as well as the value of the parameter.
        Dim NewAesParameter As New AesParameters
        NewAesParameter.strAesParameterName = strAesParameterName
        NewAesParameter.strAesParameterValue = strAesParameterValue
        NewAesParameter.strIncludedDataTypes = strIncludedDataTypes
        NewAesParameter.strExcludedDataTypes = strExcludedDataTypes
        NewAesParameter.bIsMandatory = bIsMandatory
        'NewAesParameter.bIsDependentlyMandatory = bIsDependentlyMandatory
        clsAesParameters.Add(NewAesParameter)
    End Sub

    Public Sub AddLayerParameter(strLayerParameterName As String, strLayerParameterDataType As String, strLayerParameterDefaultValue As String, Optional bIsDependent As Boolean = False, Optional lstParameterStrings As String() = Nothing, Optional strDependentParameter As String = "", Optional strDependantpParameterValue As String = "")
        Dim NewLayerParameter As New LayerParameter

        If lstParameterStrings Is Nothing Then
            lstParameterStrings = New String() {}
        End If
        NewLayerParameter.strLayerParameterName = strLayerParameterName
        NewLayerParameter.strLayerParameterDataType = strLayerParameterDataType
        NewLayerParameter.strParameterDefaultValue = strLayerParameterDefaultValue
        NewLayerParameter.lstParameterStrings = lstParameterStrings
        'NewLayerParameter.strDependentParameter = strDependentParameter
        'NewLayerParameter.strDependantparameterValue = strDependantpParameterValue
        'NewLayerParameter.bIsDependent = bIsDependent

        clsLayerParameters.Add(NewLayerParameter)
    End Sub

    Public ReadOnly Property iNumMandatoryAes As Integer
        Get
            Dim iCount As Integer = 0
            For Each clsParam In clsAesParameters
                If clsParam.bIsMandatory Then
                    iCount = iCount + 1
                End If
            Next
            Return iCount
        End Get
    End Property
End Class

Public Class AesParameters
    'contains info about the geom aesthetics and urguments for the geom
    Public strAesParameterName As String
    Public strIncludedDataTypes As String()
    Public strExcludedDataTypes As String()
    Public strAesParameterValue As String
    Public bIsMandatory As Boolean
    'Public bIsDependentlyMandatory As Boolean 'proposition for solving the situation in which one out of two aes need to be filled. For the moment not in use.
    'Task: modify the mandatory method to have three cases: not mandatory, mandatory and partial mandatory (requires mapping to "" when not filled). Would enable to clean methods in sdgLayerOptions: ucrSdgLayerBase_ClickReturn; ucrGeomListWithAes: SetAes and dlg[SpecificGraphs]: cmd[SpecificGraph]Options_Click and SetX/YParameter.
End Class

Public Class LayerParameter
    'contains info about the layer parameters
    Public strLayerParameterName As String
    Public strLayerParameterDataType As String
    Public strParameterDefaultValue As String
    Public strDependentParameter As String
    Public strDependantparameterValue As String
    Public bIsDependent As Boolean
    Public lstParameterStrings As String()
End Class