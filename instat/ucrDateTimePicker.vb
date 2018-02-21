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

Public Class ucrDateTimePicker
    Public bIsRDate As Boolean = True

    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)
        If bChangeParameterValue AndAlso clsTempParam IsNot Nothing Then
            clsTempParam.SetArgument(ValueAsRDate())
        End If
    End Sub

    Public Sub SetMinMax(dtNewMin As Date, dtNewMax As Date)
        MinDate = dtNewMin
        MaxDate = dtNewMax
    End Sub

    Public Property MinDate As Date
        Get
            Return dtpDateTime.MinDate
        End Get
        Set(dtNewMin As Date)
            dtpDateTime.MinDate = dtNewMin
        End Set
    End Property

    Public Property MaxDate As Date
        Get
            Return dtpDateTime.MaxDate
        End Get
        Set(dtNewMax As Date)
            dtpDateTime.MaxDate = dtNewMax
        End Set
    End Property

    Public Function ValueAsRDate() As RFunction
        Dim clsAsDate As New RFunction

        clsAsDate.SetRCommand("as.Date")
        clsAsDate.AddParameter("x", Chr(34) & dtpDateTime.Value.Year & "/" & dtpDateTime.Value.Month & "/" & dtpDateTime.Value.Day)

        Return clsAsDate
    End Function

    Protected Overrides Sub SetControlValue()
        Dim clsDateFunction As RFunction
        Dim clsDateValueParameter As RParameter
        Dim lstCurrentVariables As String() = Nothing
        Dim clsTempParameter As RParameter
        Dim bInvalid As Boolean = False

        clsTempParameter = GetParameter()
        If clsTempParameter IsNot Nothing Then
            If bChangeParameterValue Then
                If bIsRDate Then
                    If clsTempParameter.bIsFunction Then
                        clsDateFunction = TryCast(clsTempParameter.clsArgumentCodeStructure, RFunction)
                        If clsDateFunction IsNot Nothing Then
                            If clsDateFunction.ContainsParameter("x") Then
                                clsDateValueParameter = clsDateFunction.GetParameter("x")
                                If clsDateValueParameter.bIsString Then
                                    'Should we assume it is as.Date(x = '2000/1/1') or convert RFunction to character and then split?
                                End If
                            End If
                        Else
                        End If
                    End If
                End If
                If Not bInvalid Then
                    MsgBox("Developer error: Cannot set value of control: " & Name & ". Expecting parameter value to be of form: as.Date(x = '2000/1/1')")
                End If
            End If
        End If
    End Sub
End Class
