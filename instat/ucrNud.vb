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

        MyBase.UpdateControl(clsRCodeObject)

        If Integer.TryParse(clsParameter.strArgumentValue, iNewValue) AndAlso iNewValue >= nudUpDown.Minimum AndAlso iNewValue <= nudUpDown.Maximum Then
            nudUpDown.Value = iNewValue
        Else
            MsgBox("Developer error: The value of parameter " & clsParameter.strArgumentName & ": " & clsParameter.strArgumentValue & " cannot be converted to an integer or is outside the range of the control. Setting to the default value.")
            If Integer.TryParse(objDefault, iNewValue) Then
                nudUpDown.Value = iNewValue
            Else
                MsgBox("Developer error: The default value of the control cannot be converted to integer. Setting to the minimum of the control.")
                nudUpDown.Value = Minimum
            End If
        End If

        'clsTempParam = clsRCodeObject.GetParameter(strParameterName)
        'If strParameterName <> "" Then
        '    If clsTempParam IsNot Nothing Then
        '        If Integer.TryParse(clsTempParam.strArgumentValue, iNewValue) AndAlso iNewValue >= nudUpDown.Minimum AndAlso iNewValue <= nudUpDown.Maximum Then
        '            nudUpDown.Value = iNewValue
        '        Else
        '            MsgBox("Developer error: The value of parameter " & clsTempParam.strArgumentName & ": " & clsTempParam.strArgumentValue & " cannot be converted to an integer or is outside the range of the control. Defaulting to the minimum value.")
        '            nudUpDown.Value = nudUpDown.Minimum
        '        End If
        '    End If
        'End If
    End Sub

    Public Overrides Sub UpdateRCode(Optional clsRFunction As RFunction = Nothing, Optional clsROperator As ROperator = Nothing)
        If clsParameter IsNot Nothing Then
            clsParameter.strArgumentValue = nudUpDown.Value
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

    Public Overrides Sub SetToDefault()
        Dim iNewValue As Integer

        MyBase.SetToDefault()
        If Integer.TryParse(objDefault, iNewValue) AndAlso iNewValue >= nudUpDown.Minimum AndAlso iNewValue <= nudUpDown.Maximum Then
            nudUpDown.Value = iNewValue
        Else
            MsgBox("Developer error: The default value of the control either cannot be converted to an integer or is outside the range of the control. Setting to the minimum value.")
            nudUpDown.Value = Minimum
        End If
    End Sub
End Class
