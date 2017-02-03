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
    Private dctRadioButtonValues As New Dictionary(Of RadioButton, String)

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
            AddParameterValuesCondition(rdoTemp, clsParameter.strArgumentName, strValue)
        End If
    End Sub

    Public Sub RadioButtons_CheckedChanged()
        Dim strNewValue As String = ""
        Dim rdoTemp As RadioButton

        If bChangeParameterValue AndAlso clsParameter IsNot Nothing Then
            For Each ctrTemp As Control In pnlRadios.Controls
                If TypeOf ctrTemp Is RadioButton Then
                    rdoTemp = DirectCast(ctrTemp, RadioButton)
                    If rdoTemp.Checked Then
                        If dctRadioButtonValues.ContainsKey(rdoTemp) Then
                            strNewValue = dctRadioButtonValues(rdoTemp)
                            Exit For
                        End If
                    End If
                End If
            Next
            If strNewValue <> "" Then
                clsParameter.SetArgumentValue(strNewValue)
            Else
                MsgBox("Developer error: No parameter value is associated to the currently checked radio button. Cannot update parameter.")
            End If
        End If
        UpdateRCode()
        OnControlValueChanged()
    End Sub

    Protected Overrides Sub SetToValue(objTemp As Object)
        Dim rdoTemp As RadioButton

        If TypeOf objTemp Is RadioButton Then
            rdoTemp = DirectCast(objTemp, RadioButton)
            rdoTemp.Checked = True
        Else
            MsgBox("Developer error: Cannot set the value of " & Name & " because cannot convert value of object to radio button.")
        End If
    End Sub

    Private Sub UcrPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        bAllowNonConditionValues = False
    End Sub
End Class
