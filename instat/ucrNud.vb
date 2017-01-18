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
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objValueToRemoveParameter = ""
    End Sub

    Public Overrides Sub UpdateControl()
        Dim dNewValue As Decimal

        MyBase.UpdateControl()

        If bChangeParameterValue Then
            If Decimal.TryParse(clsParameter.strArgumentValue, dNewValue) AndAlso dNewValue >= nudUpDown.Minimum AndAlso dNewValue <= nudUpDown.Maximum Then
                nudUpDown.Value = dNewValue
            Else
                MsgBox("Developer error: The value of parameter " & clsParameter.strArgumentName & ": " & clsParameter.strArgumentValue & " cannot be converted to a decimal or is outside the range of the control. Setting to the default value.")
                If Decimal.TryParse(objDefault, dNewValue) Then
                    nudUpDown.Value = dNewValue
                Else
                    MsgBox("Developer error: The default value of the control cannot be converted to a decimal. Setting to the minimum of the control.")
                    nudUpDown.Value = Minimum
                End If
            End If
            UpdateLinkedControls()
        End If
    End Sub

    Public Overrides Sub UpdateLinkedControls()
        MyBase.UpdateLinkedControls()
    End Sub

    Public Overrides Sub UpdateRCode(clsRCodeObject As RCodeStructure)
        MyBase.UpdateRCode(clsRCodeObject)
        If clsParameter IsNot Nothing Then
            If bAddRemoveParameter Then
                If clsParameter.strArgumentValue = objValueToRemoveParameter.ToString() Then
                    clsRCodeObject.RemoveParameter(clsParameter)
                Else
                    clsRCodeObject.AddParameter(clsParameter)
                End If
            End If
        End If
    End Sub

    Public Sub SetMinMax(Optional iNewMin As Integer = Integer.MinValue, Optional iNewMax As Integer = Integer.MaxValue)
        Minimum = iNewMin
        Maximum = iNewMax
    End Sub

    Private Sub nudUpDown_TextChanged(sender As Object, e As EventArgs) Handles nudUpDown.TextChanged
        If bChangeParameterValue Then
            If nudUpDown.Text <> "" Then
                clsParameter.strArgumentValue = nudUpDown.Value
            Else
                clsParameter.strArgumentValue = ""
            End If
        End If
        OnControlValueChanged()
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

    Public Overrides Sub SetToDefault()
        Dim dNewValue As Decimal

        MyBase.SetToDefault()
        If objDefault IsNot Nothing AndAlso Integer.TryParse(objDefault, dNewValue) AndAlso dNewValue >= nudUpDown.Minimum AndAlso dNewValue <= nudUpDown.Maximum Then
            nudUpDown.Value = dNewValue
        Else
            MsgBox("Developer error: The default value of the control is either Nothing, cannot be converted to an integer or is outside the range of the numeric up/down. Setting to the minimum value instead.")
            nudUpDown.Value = Minimum
        End If
    End Sub

    Public Overrides Sub SetDefault(objNewDefault As Object)
        Dim dTemp As Decimal

        MyBase.SetDefault(objNewDefault)
        If Not Decimal.TryParse(objNewDefault, dTemp) Then
            MsgBox("Developer error: Cannot set the default value of the control because it cannot be converted to an integer.")
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

    Public Overrides Function ValueContainedIn(lstTemp As Object()) As Boolean
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
End Class