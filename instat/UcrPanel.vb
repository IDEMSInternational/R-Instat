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
Public Class UcrPanel
    Public dctRadioButtonValues As New Dictionary(Of RadioButton, String)
    Public bSetToFirstIfNoValue As Boolean = True

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bAllowNonConditionValues = False
    End Sub

    Private Sub AddRadioButtonRange(lstRadioButtons As RadioButton(), Optional bRepositionControls As Boolean = True)
        pnlRadios.Controls.AddRange(lstRadioButtons)
        For Each rdoTemp As RadioButton In lstRadioButtons
            AddHandler rdoTemp.CheckedChanged, AddressOf RadioButtons_CheckedChanged
            If bRepositionControls Then
                If rdoTemp.Location.X - Me.Location.X < 0 OrElse rdoTemp.Location.Y - Me.Location.Y < 0 Then
                    MsgBox("Developer error: Radio button is not within the bounds of the panel. Reposition the radio button in the designer.")
                End If
                rdoTemp.Location = New System.Drawing.Point(Math.Max(rdoTemp.Location.X - Me.Location.X, 0), Math.Max(rdoTemp.Location.Y - Me.Location.Y, 0))
            End If
        Next
    End Sub

    Public Sub AddRadioButton(rdoTemp As RadioButton, Optional strValue As String = "")
        AddRadioButtonRange({rdoTemp})
        If strValue <> "" Then
            dctRadioButtonValues.Add(rdoTemp, strValue)
            AddParameterValuesCondition(rdoTemp, GetParameter().strArgumentName, strValue)
        End If
    End Sub

    Public Sub RadioButtons_CheckedChanged()
        OnControlValueChanged()
    End Sub

    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)
        Dim strNewValue As String = ""
        Dim rdoTemp As RadioButton

        If bChangeParameterValue AndAlso clsTempParam IsNot Nothing Then
            For Each ctrTemp As Control In pnlRadios.Controls
                If TypeOf ctrTemp Is RadioButton Then
                    rdoTemp = CType(ctrTemp, RadioButton)
                    If rdoTemp.Checked Then
                        If dctRadioButtonValues.ContainsKey(rdoTemp) Then
                            strNewValue = dctRadioButtonValues(rdoTemp)
                            Exit For
                        End If
                    End If
                End If
            Next
            If strNewValue <> "" Then
                clsTempParam.SetArgumentValue(strNewValue)
            Else
                If Not bAllowNonConditionValues Then
                    MsgBox("Developer error: No parameter value is associated to the currently checked radio button. Cannot update parameter.")
                End If
            End If
        End If
    End Sub

    Protected Overrides Sub SetToValue(objTemp As Object)
        Dim rdoTemp As RadioButton

        If objTemp IsNot Nothing Then
            If TypeOf objTemp Is RadioButton Then
                rdoTemp = DirectCast(objTemp, RadioButton)
                rdoTemp.Checked = True
            Else
                MsgBox("Developer error: Cannot set the value of " & Name & " because cannot convert value of object to radio button.")
            End If
        Else
            'If no value reset to a default value
            'Need this not to happen sometimes so set bSetToFirstIfNoValue = False e.g. sdgModelOptions
            If bSetToFirstIfNoValue AndAlso pnlRadios.Controls.Count > 0 AndAlso TypeOf pnlRadios.Controls(0) Is RadioButton Then
                rdoTemp = DirectCast(pnlRadios.Controls(0), RadioButton)
                rdoTemp.Checked = True
            End If
        End If
    End Sub

    Public Overrides Function GetValueToSet() As Object
        Dim rdoTemp As RadioButton

        For Each ctrTemp As Control In pnlRadios.Controls
            If TypeOf ctrTemp Is RadioButton Then
                rdoTemp = CType(ctrTemp, RadioButton)
                If rdoTemp.Checked Then
                    Return rdoTemp
                End If
            End If
        Next
        Return Nothing
    End Function

    Public Overrides Function ControlValueContainedIn(lstTemp() As Object) As Boolean
        Dim rdoTemp As RadioButton
        Dim bTemp As Boolean = False

        For Each objVal In lstTemp
            If TypeOf objVal Is RadioButton Then
                rdoTemp = DirectCast(objVal, RadioButton)
                If rdoTemp.Checked Then
                    bTemp = True
                End If
            Else
                MsgBox("Developer error: Cannot convert object to radio button for linked control.")
            End If
        Next
        Return bTemp
    End Function
End Class