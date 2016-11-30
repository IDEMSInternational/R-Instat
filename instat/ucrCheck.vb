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

Public Class ucrCheck
    'Is the checkbox linked to specific parameter values when checked/unchecked
    Private bIsParameterValue As Boolean = True
    'If either of these = "" then the parameter will be removed in the case where = ""
    'TODO may want this more sophisticated so that it can store an unchecked value but still uncheck if that value is given
    Private strValueIfChecked As String = "TRUE"
    Private strValueIfUnchecked As String = "FALSE"
    'Is the checkbox linked to a parameter only by whether the parameter is present or not, irrespective of the parameter value
    Private bIsParameterPresent As Boolean = False
    'When bIsParameterPresent should the control be checked when the parameter is present (and unchecked when not present)
    'If = False then the opposite.
    Public bParameterIncludedWhenChecked As Boolean = True

    Public Overrides Sub UpdateControl(clsRCodeObject As RCodeStructure)
        Dim clsTempParam As RParameter

        MyBase.UpdateControl(clsRCodeObject)

        'TODO Add methods in RFunction/base class for RFunction/ROperator to do these checks better
        clsTempParam = clsRCodeObject.GetParameter(strParameterName)
        If strParameterName <> "" Then
            If bIsParameterValue Then
                If clsTempParam IsNot Nothing Then
                    If clsTempParam.strArgumentValue = strValueIfChecked OrElse clsTempParam.strArgumentValue = strValueIfUnchecked Then
                        chkCheck.Checked = (clsTempParam.strArgumentValue = strValueIfChecked)
                    Else
                        MsgBox("Developer error: The value of parameter " & clsTempParam.strArgumentName & ": " & clsTempParam.strArgumentValue & " does not match strValueIfChecked or strValueIfUnchecked so cannot determine state for the checkbox. Defaulting to unchecked.")
                        chkCheck.Checked = False
                    End If
                Else
                    If strValueIfChecked = "" Then
                        chkCheck.Checked = True
                    ElseIf strValueIfUnchecked = "" Then
                        chkCheck.Checked = False
                    Else
                        'If parameter is missing with no information about what that means, then uncheck by default
                        chkCheck.Checked = False
                    End If
                End If
            End If
        ElseIf bIsParameterPresent Then
            If clsTempParam IsNot Nothing Then
                chkCheck.Checked = bParameterIncludedWhenChecked
            Else
                chkCheck.Checked = Not bParameterIncludedWhenChecked
            End If
        End If
    End Sub

    Public Overrides Sub UpdateRCode(Optional clsRFunction As RFunction = Nothing, Optional clsROperator As ROperator = Nothing)
        Dim bCurrentAddValue As Boolean

        If strParameterName <> "" Then
            If bIsParameterValue Then
                If chkCheck.Checked Then
                    If clsRFunction IsNot Nothing Then
                        If strValueIfChecked <> "" Then
                            clsRFunction.AddParameter(strParameterName, strValueIfChecked)
                        Else
                            clsRFunction.RemoveParameterByName(strParameterName)
                        End If
                    ElseIf clsROperator IsNot Nothing Then
                        'TODO
                    End If
                Else
                    If clsRFunction IsNot Nothing Then
                        If strValueIfUnchecked <> "" Then
                            clsRFunction.AddParameter(strParameterName, strValueIfUnchecked)
                        Else
                            clsRFunction.RemoveParameterByName(strParameterName)
                        End If
                    ElseIf clsROperator IsNot Nothing Then
                        'TODO Implement something like this
                        'clsROperator.SetParameter() or clsROperator.AddAdditionalParameter()
                    End If
                End If
            ElseIf bIsParameterPresent Then
                If (chkCheck.Checked AndAlso bParameterIncludedWhenChecked) OrElse ((Not chkCheck.Checked) AndAlso (Not bParameterIncludedWhenChecked)) Then
                    If ucrLinkedControl IsNot Nothing Then
                        bCurrentAddValue = ucrLinkedControl.bAddIfParameterNotPresent
                        ucrLinkedControl.bAddIfParameterNotPresent = True
                        ucrLinkedControl.UpdateRCode(clsRFunction)
                        ucrLinkedControl.bAddIfParameterNotPresent = bCurrentAddValue
                    End If
                Else
                    clsRFunction.RemoveParameterByName(strParameterName)
                End If
            End If
        End If
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

    Public Sub SetIsParameterPresent()
        bIsParameterPresent = True
        bIsParameterValue = False
    End Sub

    Public Sub SetIsParameterValue()
        bIsParameterValue = True
        bIsParameterPresent = False
    End Sub

    Public Overrides Sub SetLinkedControl(ucrNewLinkedControl As ucrCore)
        MyBase.SetLinkedControl(ucrNewLinkedControl)
        bIsParameterPresent = True
        bIsParameterValue = False
    End Sub

    Private Sub chkCheck_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheck.CheckedChanged
        OnControlContentsChanged()
        OnControlValueChanged()
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