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

Imports instat

Public Class ucrCheck
    ''Is the checkbox linked to specific parameter values when checked/unchecked
    'Private bIsParameterValue As Boolean = True

    Private strValueIfChecked As String = "TRUE"
    Private strValueIfUnchecked As String = "FALSE"

    Public Sub SetValueIfChecked(strNewValueIfChecked As String)
        Dim clsTempCond As New Condition

        strValueIfChecked = strNewValueIfChecked
        If GetParameter() Is Nothing Then
            MsgBox("Developer error: Parameter must be set before SetValueIfChecked can be run! Control will not update correctly.")
        Else
            AddParameterValuesCondition(True, GetParameter().strArgumentName, strValueIfChecked)
        End If
    End Sub

    Public Sub SetValueIfUnchecked(strNewValueIfUnchecked As String)
        strValueIfUnchecked = strNewValueIfUnchecked
        If GetParameter() Is Nothing OrElse GetParameter().strArgumentName Is Nothing Then
            MsgBox("Developer error: Parameter must be set with a parameter name before SetValueIfUnchecked can be run! Control will not update correctly.")
        Else
            AddParameterValuesCondition(False, GetParameter().strArgumentName, strValueIfUnchecked)
        End If
    End Sub

    Public Overloads Sub SetParameter(clsNewParameter As RParameter, bNewChangeParameterValue As Boolean, Optional bNewAddRemoveParameter As Boolean = True, Optional strNewValueIfChecked As String = "TRUE", Optional strNewValueIfUnchecked As String = "FALSE")
        MyBase.SetParameter(clsNewParameter)
        bChangeParameterValue = bNewChangeParameterValue
        bAddRemoveParameter = bNewAddRemoveParameter
        If bChangeParameterValue Then
            SetValuesCheckedAndUnchecked(strNewValueIfChecked, strNewValueIfUnchecked)
        ElseIf bAddRemoveParameter Then
            AddParameterPresentCondition(True, GetParameter().strArgumentName)
            AddParameterPresentCondition(False, GetParameter().strArgumentName, False)
        End If
    End Sub

    Public Sub SetValuesCheckedAndUnchecked(strNewValueIfChecked As String, strNewValueIfUnchecked As String)
        SetValueIfChecked(strNewValueIfChecked)
        SetValueIfUnchecked(strNewValueIfUnchecked)
    End Sub

    Private Sub chkCheck_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheck.CheckedChanged
        OnControlValueChanged()
    End Sub

    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)
        If bChangeParameterValue AndAlso clsTempParam IsNot Nothing Then
            If chkCheck.Checked Then
                If strValueIfChecked <> "" Then
                    clsTempParam.SetArgumentValue(strValueIfChecked)
                End If
            Else
                If strValueIfUnchecked <> "" Then
                    clsTempParam.SetArgumentValue(strValueIfUnchecked)
                End If
            End If
        End If
    End Sub

    Public Property Checked As Boolean
        Get
            Return chkCheck.Checked
        End Get
        Set(bChecked As Boolean)
            chkCheck.Checked = bChecked
        End Set
    End Property

    Public Overrides Function ControlValueContainedIn(lstTemp As Object()) As Boolean
        Dim bTempValue As Boolean
        Dim bContainedIn As Boolean = False

        For Each objVal In lstTemp
            If Boolean.TryParse(objVal, bTempValue) Then
                If bTempValue = chkCheck.Checked Then
                    bContainedIn = True
                End If
            Else
                MsgBox("Developer error: Cannot convert value to boolean for linked control.")
            End If
        Next
        Return bContainedIn
    End Function

    Public Overrides Function GetValueToSet() As Object
        Dim clsMainParameter As RParameter

        clsMainParameter = GetParameter()
        If clsMainParameter IsNot Nothing Then
            If clsMainParameter.bIsString Then
                If bChangeParameterValue Then
                    If clsMainParameter.strArgumentValue = strValueIfChecked OrElse clsMainParameter.strArgumentValue = strValueIfUnchecked Then
                        Return (clsMainParameter.strArgumentValue = strValueIfChecked)
                    Else
                        Return clsMainParameter.strArgumentValue
                    End If
                ElseIf bAddRemoveParameter Then
                    Return GetRCode().ContainsParameter(clsMainParameter)
                Else
                    Return Nothing
                End If
            ElseIf clsMainParameter.bIsFunction OrElse clsMainParameter.bIsOperator Then
                Return clsMainParameter.clsArgumentCodeStructure
            Else
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function

    Protected Overrides Sub SetToValue(objTemp As Object)
        Dim bTempValue As Boolean

        If objTemp Is Nothing Then
            'If no value reset to a default value
            Checked = False
        Else
            If Boolean.TryParse(objTemp, bTempValue) Then
                Checked = bTempValue
            Else
                MsgBox("Developer error: Cannot set the value of " & Name & " because cannot convert value of object to boolean.")
            End If
        End If
    End Sub

    Public Overrides Function CanAddParameter() As Boolean
        If bChangeParameterValue Then
            Return MyBase.CanAddParameter()
        ElseIf bAddRemoveParameter Then
            Return Checked
        Else
            Return False
        End If
    End Function

    Public Overrides Sub ChangeParameterName(strNewName As String, Optional bClearConditions As Boolean = True)
        MyBase.ChangeParameterName(strNewName, bClearConditions)
        If bClearConditions Then
            If bChangeParameterValue Then
                SetValuesCheckedAndUnchecked(strValueIfChecked, strValueIfUnchecked)
            ElseIf bAddRemoveParameter Then
                AddParameterPresentCondition(True, GetParameter().strArgumentName)
                AddParameterPresentCondition(False, GetParameter().strArgumentName, False)
            End If
        End If
    End Sub

    Protected Overrides Sub ResetControlValue()
        Checked = False
    End Sub
End Class