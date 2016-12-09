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

Public Class ucrNud
    Public Overrides Sub UpdateControl(clsRCodeObject As RCodeStructure)
        Dim iNewValue As Integer
        Dim clsTempParam As RParameter

        MyBase.UpdateControl(clsRCodeObject)

        clsTempParam = clsRCodeObject.GetParameter(strParameterName)
        If strParameterName <> "" Then
            If clsTempParam IsNot Nothing Then
                If Integer.TryParse(clsTempParam.strArgumentValue, iNewValue) AndAlso iNewValue >= nudUpDown.Minimum AndAlso iNewValue <= nudUpDown.Maximum Then
                    nudUpDown.Value = iNewValue
                Else
                    MsgBox("Developer error: The value of parameter " & clsTempParam.strArgumentName & ": " & clsTempParam.strArgumentValue & " cannot be converted to an integer or is outside the range of the control. Defaulting to the minimum value.")
                    nudUpDown.Value = nudUpDown.Minimum
                End If
            End If
        End If
    End Sub

    Public Overrides Sub UpdateRCode(Optional clsRFunction As RFunction = Nothing, Optional clsROperator As ROperator = Nothing)
        Dim clsTempParam As RParameter

        If clsRFunction IsNot Nothing Then
            clsTempParam = clsRFunction.GetParameter(strParameterName)
            If strParameterName <> "" Then
                If clsTempParam IsNot Nothing OrElse bAddIfParameterNotPresent Then
                    clsRFunction.AddParameter(strParameterName, nudUpDown.Value)
                End If
            Else
                clsRFunction.RemoveParameterByName(strParameterName)
            End If
        ElseIf clsROperator IsNot Nothing Then
            clsTempParam = clsROperator.GetParameter(strParameterName)
            'TODO
        End If
    End Sub

    Public Sub SetMinMax(Optional iNewMin As Integer = Integer.MinValue, Optional iNewMax As Integer = Integer.MaxValue)
        Minimum = iNewMin
        Maximum = iNewMax
    End Sub

    Private Sub nudUpDown_TextChanged(sender As Object, e As EventArgs) Handles nudUpDown.TextChanged
        OnControlContentsChanged()
        OnControlValueChanged()
    End Sub

    Public Property Minimum As Integer
        Get
            Return nudUpDown.Minimum
        End Get
        Set(iNewMin As Integer)
            nudUpDown.Minimum = iNewMin
        End Set
    End Property

    Public Property Maximum As Integer
        Get
            Return nudUpDown.Maximum
        End Get
        Set(iNewMax As Integer)
            nudUpDown.Maximum = iNewMax
        End Set
    End Property

    Public Property Value As Decimal
        Get
            Return nudUpDown.Value
        End Get
        Set(dcNewMax As Decimal)
            nudUpDown.Value = dcNewMax
        End Set
    End Property
End Class
