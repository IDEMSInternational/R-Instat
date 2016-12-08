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

Public Class ucrCore
    'Parameter that is this control manages
    Protected clsParameter As New RParameter
    'Default value of the control
    Protected objDefault As Object
    'A control it's linked to i.e. dependant on/depends on 
    Protected ucrLinkedControl As ucrCore
    'The name of a parameter linked to the control which determines if the control is visible/enabled
    Protected strLinkedParameterName As String
    'These determine what happens to the control when the linked parameter is not found in the code
    Protected bHideIfLinkedParameterMissing As Boolean = False
    Protected bDisabledIfLinkedParameterMissing As Boolean = False
    'If the parameter is not in the code, should the control add the parameter with its value
    'Uses of False would be if the control only adds a parameter when another control is checked
    Public bAddIfParameterNotPresent As Boolean = True

    'ValueChanged is raised when a new value has been set in the control
    Public Event ControlValueChanged(ucrChangedControl As ucrCore)
    'ContentsChanged is raised when the content of the control has changed, but possibly the value has not been set
    'e.g. text in a textbox changes, but the value is not changed until the user leaves the text box
    'For some controls these two events will be equivalent
    'For all controls ValueChanged can't happen without ContentsChanged happening just before
    'ContentsChanged is probably only needed for TestOK
    Public Event ControlContentsChanged(ucrChangedControl As ucrCore)

    Public Sub SetParameterName(strParamName As String)
        clsParameter.strArgumentName = strParamName
    End Sub

    Public Function GetParameterName() As String
        Return clsParameter.strArgumentName
    End Function

    Public Sub SetParameter(clsNewParam As RParameter)
        clsParameter = clsNewParam
    End Sub

    Public Function GetParameter() As RParameter
        Return clsParameter
    End Function

    Public Sub SetDefault(objNewDefault As Object)
        objDefault = objNewDefault
    End Sub

    Public Function GetDefault() As Object
        Return objDefault
    End Function

    Public Overridable Sub SetToDefault()

    End Sub

    Public Overridable Sub SetLinkedControl(ucrNewLinkedControl As ucrCore)
        ucrLinkedControl = ucrNewLinkedControl
    End Sub

    Public Function GetLinkedControl() As ucrCore
        Return ucrLinkedControl
    End Function

    'Update the control based on the the code in RCodeStructure
    Public Overridable Sub UpdateControl(Optional clsRCodeObject As RCodeStructure = Nothing)
        If clsRCodeObject IsNot Nothing Then
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
        End If
    End Sub

    'Update the RCode based on the contents of the control (reverse of above)
    Public Overridable Sub UpdateRCode(clsRCodeObject As RCodeStructure)
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