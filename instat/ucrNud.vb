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

Imports instat

Public Class ucrNud
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objValueToRemoveParameter = ""
    End Sub

    Public Sub SetMinMax(Optional iNewMin As Integer = Integer.MinValue, Optional iNewMax As Integer = Integer.MaxValue)
        Minimum = iNewMin
        Maximum = iNewMax
    End Sub

    Private Sub nudUpDown_TextChanged(sender As Object, e As EventArgs) Handles nudUpDown.TextChanged
        OnControlValueChanged()
    End Sub

    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)
        If bChangeParameterValue AndAlso clsTempParam IsNot Nothing Then
            If nudUpDown.Text <> "" Then
                clsTempParam.SetArgumentValue(nudUpDown.Value)
            Else
                clsTempParam.SetArgumentValue("")
            End If
        End If
    End Sub

    Public Property Minimum As Decimal
        Get
            Return nudUpDown.Minimum
        End Get
        Set(dNewMin As Decimal)
            nudUpDown.Minimum = dNewMin
        End Set
    End Property

    Public Property Maximum As Decimal
        Get
            Return nudUpDown.Maximum
        End Get
        Set(dNewMax As Decimal)
            nudUpDown.Maximum = dNewMax
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

    Public Property Increment As Decimal
        Get
            Return nudUpDown.Increment
        End Get
        Set(dIncrement As Decimal)
            nudUpDown.Increment = dIncrement
        End Set
    End Property

    Public Property DecimalPlaces As Decimal
        Get
            Return nudUpDown.DecimalPlaces
        End Get
        Set(dDecimalPlaces As Decimal)
            nudUpDown.DecimalPlaces = dDecimalPlaces
        End Set
    End Property

    Public Overrides Sub SetRDefault(objNewDefault As Object)
        Dim dTemp As Decimal

        MyBase.SetRDefault(objNewDefault)
        If Not Decimal.TryParse(objNewDefault, dTemp) Then
            MsgBox("Developer error: Cannot set the default value of the control because it cannot be converted to a decimal.")
            MyBase.SetValueToRemoveParameter(Nothing)
        End If
    End Sub

    Public Overrides Sub SetValueToRemoveParameter(objNewValue As Object)
        Dim dTemp As Decimal

        MyBase.SetValueToRemoveParameter(objNewValue)
        If Not Decimal.TryParse(objNewValue, dTemp) Then
            MsgBox("Developer error: Cannot set the value to remove of the control because it cannot be converted to a decimal.")
            MyBase.SetValueToRemoveParameter(Nothing)
        End If
    End Sub

    Public Overrides Function ControlValueContainedIn(lstTemp As Object()) As Boolean
        Dim dTemp As Decimal
        Dim bTemp As Boolean = False

        For Each objVal In lstTemp
            If Decimal.TryParse(objVal, dTemp) Then
                If dTemp = nudUpDown.Value Then
                    bTemp = True
                End If
            Else
                MsgBox("Developer error: Cannot convert value to decimal for linked control.")
            End If
        Next
        Return bTemp
    End Function

    Public Function GetText() As String
        Return nudUpDown.Text
    End Function

    Protected Overrides Sub SetToValue(objTemp As Object)
        Dim dNewValue As Decimal

        If objTemp IsNot Nothing AndAlso Decimal.TryParse(objTemp, dNewValue) AndAlso dNewValue >= nudUpDown.Minimum AndAlso dNewValue <= nudUpDown.Maximum Then
            nudUpDown.Value = dNewValue
        Else
            MsgBox("Developer error: The value given cannot be converted to a decimal or is outside the range of the control. Value will be unchanged.")
        End If
    End Sub
End Class