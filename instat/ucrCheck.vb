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

Public Class ucrCheck
    Protected strValueIfChecked As String = "TRUE"
    Protected strValueIfUnchecked As String = "FALSE"
    Public bCheckIfParameterPresent As Boolean = True
    Public bIsParameterValue As Boolean = True
    Public bIsParameterPresent As Boolean = False
    Public Event evtCheckChanged(sender As Object, e As EventArgs)

    Public Overrides Sub UpdateControl(clsRFunction As RFunction)
        Dim clsTempParam As RParameter
        'TODO Add methods in RFunction/base class for RFunction/ROperator to do these checks better
        clsTempParam = clsRFunction.GetParameter(strParameterName)
        If strParameterName <> "" Then
            If bIsParameterValue Then
                If clsTempParam IsNot Nothing Then
                    If clsTempParam.strArgumentValue = strValueIfChecked OrElse clsTempParam.strArgumentValue = strValueIfUnchecked Then
                        chkCheck.Checked = clsTempParam.strArgumentValue = strValueIfChecked
                    Else
                        MsgBox("Developer error: The value of parameter " & clsTempParam.strArgumentName & ": " & clsTempParam.strArgumentValue & " does not match strValueIfChecked or strValueIfUnchecked so cannot determine state for the checkbox. Defaulting to unchecked.")
                        chkCheck.Checked = False
                    End If
                Else
                    chkCheck.Checked = bCheckIfParameterPresent
                End If
            End If
        ElseIf bIsParameterPresent Then
            If clsTempParam IsNot Nothing Then
                chkCheck.Checked = bCheckIfParameterPresent
            Else
                chkCheck.Checked = Not bCheckIfParameterPresent
            End If
        End If
    End Sub

    Public Overrides Sub UpdateRFunction(clsRFunction As RFunction)
        Throw New NotImplementedException()
    End Sub

    Public Sub SetValueIfChecked(strNewValueIfChecked As String)
        strValueIfChecked = strNewValueIfChecked
        bIsParameterValue = True
        bIsParameterPresent = False
    End Sub

    Public Sub SetValueIfUnchecked(strNewValueIfUnchecked As String)
        strValueIfUnchecked = strNewValueIfUnchecked
        bIsParameterValue = True
        bIsParameterPresent = False
    End Sub

    Public Sub SetValuesCheckedAndUnchecked(strNewValueIfChecked As String, strNewValueIfUnchecked As String)
        SetValueIfChecked(strNewValueIfChecked)
        SetValueIfUnchecked(strNewValueIfUnchecked)
    End Sub

    Public Sub SetIsParameterPresent(bNewIsParameterPresent As Boolean)
        bIsParameterPresent = bNewIsParameterPresent
        bIsParameterValue = False
    End Sub

    Public Sub SetIsParameterValue(bNewIsParameterValue As Boolean)
        bIsParameterValue = bNewIsParameterValue
        bIsParameterPresent = False
    End Sub

    Private Sub chkCheck_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheck.CheckedChanged
        RaiseEvent evtCheckChanged(sender, e)
    End Sub

    Public Property Checked As Boolean
        Get
            Return chkCheck.Checked
        End Get
        Set(bChecked As Boolean)
            chkCheck.Checked = bChecked
        End Set
    End Property
End Class