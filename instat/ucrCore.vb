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

Public Class ucrCore
    'Name of parameter control sets
    Protected strParameterName As String
    'A control it's linked to i.e. dependant on/depends on 
    Protected ucrLinkedControl As ucrCore
    'The name of a parameter linked to the control which determines if the control is visible/enabled
    Protected strLinkedParameterName As String
    'These determine what happens to the control when the linked parameter is not found in the code
    Protected bHideIfLinkedParameterMissing As Boolean = False
    Protected bDisabledIfLinkedParameterMissing As Boolean = False

    Public Event ControlValueChanged(ucrChangedControl As ucrCore)
    Public Event ControlContentsChanged(ucrChangedControl As ucrCore)

    Public Sub SetParameterName(strParamName As String)
        strParameterName = strParamName
    End Sub

    Public Function GetParameterName() As String
        Return strParameterName
    End Function

    Public Overridable Sub SetLinkedControl(ucrNewLinkedControl As ucrCore)
        ucrLinkedControl = ucrNewLinkedControl
    End Sub

    Public Function GetLinkedControl() As ucrCore
        Return ucrLinkedControl
    End Function

    'Update the control based on the the code in RCodeStructure
    Public Overridable Sub UpdateControl(clsRCodeObject As RCodeStructure)
        If strLinkedParameterName <> "" Then
            If clsRCodeObject.GetParameter(strLinkedParameterName) Is Nothing Then
                If bHideIfLinkedParameterMissing Then
                    Visible = False
                Else
                    Visible = True
                End If
                If bDisabledIfLinkedParameterMissing Then
                    Enabled = False
                Else
                    Enabled = True
                End If
            Else
                If bHideIfLinkedParameterMissing Then
                    Visible = True
                End If
                If bDisabledIfLinkedParameterMissing Then
                    Enabled = True
                End If
            End If
        End If
    End Sub

    'Update the RCode based on the contents of the control (reverse of above)
    Public Overridable Sub UpdateRCode(Optional clsRFunction As RFunction = Nothing, Optional clsROperator As ROperator = Nothing)
    End Sub

    'Set a linked paramter name and what the control should do when the parameter is not in the R code
    Public Sub SetLinkedParameterName(strNewLinkedParameterName As String, Optional bNewHideIfLinkedParameterMissing As Boolean = False, Optional bNewDisableIfLinkedParameterMissing As Boolean = False)
        strLinkedParameterName = strNewLinkedParameterName
        bHideIfLinkedParameterMissing = bNewHideIfLinkedParameterMissing
        bDisabledIfLinkedParameterMissing = bNewDisableIfLinkedParameterMissing
    End Sub

    'Set the Text property of the control(s) inside this control (should only be one). Implemented different by each VB control.
    Public Overridable Sub SetText(strNewText As String)
        For Each ctrTemp In Controls
            ctrTemp.Text = strNewText
        Next
    End Sub

    Public Sub OnControlContentsChanged()
        RaiseEvent ControlContentsChanged(Me)
    End Sub

    Public Sub OnControlValueChanged()
        RaiseEvent ControlValueChanged(Me)
    End Sub
End Class