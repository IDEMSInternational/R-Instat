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
    Private lstRadioButtonValues As New List(Of KeyValuePair(Of RadioButton, String))

    Public Sub AddRadioButtonRange(lstRadioButtons As RadioButton(), Optional bRepositionControls As Boolean = True)
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

    Public Sub AddRadioButtonRange(lstNewRadioButtonValues As List(Of KeyValuePair(Of RadioButton, String)), Optional bRepositionControls As Boolean = True)
        Dim lstRadioButtons As New List(Of RadioButton)

        For Each kvpTemp As KeyValuePair(Of RadioButton, String) In lstNewRadioButtonValues
            lstRadioButtons.Add(kvpTemp.Key)
        Next
        AddRadioButtonRange(lstRadioButtons.ToArray(), bRepositionControls)
        lstRadioButtonValues.AddRange(lstNewRadioButtonValues)
    End Sub

    Public Sub AddRadioButton(rdoTemp As RadioButton, Optional strValue As String = "")
        Dim kvpTemp As New KeyValuePair(Of RadioButton, String)(rdoTemp, strValue)

        AddRadioButtonRange({rdoTemp})
        If strValue <> "" Then
            lstRadioButtonValues.Add(kvpTemp)
        End If
    End Sub

    Public Sub RadioButtons_CheckedChanged()
        Dim strNewValue As String = ""
        Dim rdoTemp As RadioButton
        Dim iIndex As Integer

        If bChangeParameterValue AndAlso clsParameter IsNot Nothing Then
            For Each ctrTemp As Control In pnlRadios.Controls
                If TypeOf ctrTemp Is RadioButton Then
                    rdoTemp = DirectCast(ctrTemp, RadioButton)
                    If rdoTemp.Checked Then
                        iIndex = lstRadioButtonValues.FindIndex(Function(x) x.Key.Equals(rdoTemp))
                        If iIndex <> -1 Then
                            strNewValue = lstRadioButtonValues(iIndex).Value
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

    Public Overrides Sub UpdateControl(Optional bReset As Boolean = False)
        Dim strCurrentValue As String
        Dim bFound As Boolean = False

        MyBase.UpdateControl(bReset)

        If clsParameter IsNot Nothing Then
            If bChangeParameterValue Then
                strCurrentValue = clsParameter.strArgumentValue

                For Each kvpTemp As KeyValuePair(Of RadioButton, String) In lstRadioButtonValues
                    If kvpTemp.Value = strCurrentValue Then
                        kvpTemp.Key.Checked = True
                        bFound = True
                        Exit For
                    End If
                Next
                If Not bFound Then
                    MsgBox("Parameter as value: " & strCurrentValue & " which is not associated to any radio button in this control. Cannot update radio buttons.")
                End If
            ElseIf bAddRemoveParameter Then
                'Commented out as not currently needed. Can be included if needed.
                'If bParameterIncludedWhenChecked Then
                'chkCheck.Checked = clsRCode.ContainsParameter(clsParameter)
                'Else
                'chkCheck.Checked = Not clsRCodeObject.clsParameters.Contains(clsParameter)
                'End If
            End If
        Else
            'chkCheck.Checked = LinkedControlsParametersPresent()
        End If
        UpdateLinkedControls()
    End Sub
End Class
