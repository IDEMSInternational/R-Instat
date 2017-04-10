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

    'Function or Operator that this control's parameter is added/removed from
    Protected clsRCode As RCodeStructure
    'Parameter that this control manages
    'Either by editing its value or adding/removing it from an RCodeStructure
    Public clsParameter As RParameter

    'Default value of the control
    'No specific type since it can be interpreted different by each control type
    Protected objRDefault As Object = Nothing

    Protected objDefaultState As Object = Nothing

    'Protected typControlType As Type = Object

    ''A control it's linked to i.e. dependant on/depends on 
    'Protected ucrLinkedControl As ucrCore
    ''The name of a parameter linked to the control which determines if the control is visible/enabled
    'Protected strLinkedParameterName As String

    'Sets what aspects of clsParameter this control can change
    'e.g. check box may not change parameter value, only add/remove it
    '     For this bAddRemoveParameter = True and bChangeParameterValue = False
    'e.g. nud may not add/remove parameter, only change its value
    Public bAddRemoveParameter As Boolean = True
    Public bChangeParameterValue As Boolean = True

    'Optional value
    'If parameter has this value then it will be removed from RCodeStructure 
    Public objValueToRemoveParameter As Object

    'ValueChanged is raised when a new value has been set in the control
    Public Event ControlValueChanged(ucrChangedControl As ucrCore)

    'ContentsChanged is raised when the content of the control has changed, but possibly the value has not been set
    'e.g. text in a textbox changes, but the value is not changed until the user leaves the text box
    'For some controls these two events will be equivalent
    'When ValueChanged is raised, so is ContentsChanged
    'ContentsChanged is probably only needed for TestOK
    Public Event ControlContentsChanged(ucrChangedControl As ucrCore)

    'List of controls that this control links to
    'Used when this control determines aspects of other controls
    'e.g. add/remove the parameter of other controls
    '     set the visible/enabled property of other controls
    'e.g. a checkbox that shows/hides set of controls
    Protected lstValuesAndControl As New List(Of KeyValuePair(Of ucrCore, Object()))

    'If this control is in another controls lstLinkedControls
    'These values specifiy how that control can modify this control
    Public bLinkedAddRemoveParameter As Boolean = False
    Public bLinkedUpdateFunction As Boolean = False
    Public bLinkedDisabledIfParameterMissing As Boolean = False
    Public bLinkedHideIfParameterMissing As Boolean = False
    Public bLinkedChangeToDefaultState As Boolean = False

    Protected ctrLinkedDisaplyControl As Control

    Public bIsActiveRControl As Boolean = True

    Public bUpdateRCodeFromControl As Boolean = False

    Protected dctConditions As New Dictionary(Of Object, List(Of Condition))

    Public bAllowNonConditionValues As Boolean = True

    Public bIsVisible As Boolean = True

    ' Values which the parameter associated to the control may have but which shouldn't be used to set the control's value
    ' Individual controls can determine what value to set when a parameter value is contained in strValuesToIgnore
    ' (Currently only implemented for receivers)
    Protected strValuesToIgnore As String()

    'Update the control based on the code in RCodeStructure
    'bReset : should the control reset to the default value if the parameter is not present in the code
    Public Overridable Sub UpdateControl(Optional bReset As Boolean = False)
        If clsRCode IsNot Nothing Then
            If clsParameter IsNot Nothing Then
                If Not clsRCode.ContainsParameter(clsParameter) Then
                    If clsRCode.ContainsParameter(clsParameter.strArgumentName) Then
                        clsParameter = clsRCode.GetParameter(clsParameter.strArgumentName)
                    ElseIf bReset Then
                        If objDefaultState Is Nothing Then
                            SetToRDefault()
                            'Exit Sub
                        End If
                    Else
                    End If
                End If
            Else
            End If
        Else
            clsRCode = New RCodeStructure
        End If
        SetControlValue()
        UpdateLinkedControls(bReset)
    End Sub

    Protected Overridable Sub SetControlValue()
        Dim bConditionsMet As Boolean = False
        If clsRCode IsNot Nothing Then
            For Each kvpTemp As KeyValuePair(Of Object, List(Of Condition)) In dctConditions
                If kvpTemp.Value.Count > 0 Then
                    If AllConditionsSatisfied(kvpTemp.Value, clsRCode, clsParameter) Then
                        If bConditionsMet Then
                            MsgBox("Developer error: More than one state of control " & Name & " satisfies it's condition. Cannot determine how to set the control from the RCode. Modify conditions so that only one state can satisfy its conditions.")
                        Else
                            SetToValue(kvpTemp.Key)
                            bConditionsMet = True
                        End If
                    End If
                End If
            Next
            If Not bConditionsMet Then
                If bAllowNonConditionValues Then
                    If GetValueToSet() IsNot Nothing Then
                        SetToValue(GetValueToSet())
                    End If
                Else
                    MsgBox("Developer error: no state of control " & Name & " satisfies it's condition. Cannot determine how to set the control from the RCode. Modify control setup so that one state can satisfy its conditions.")
                End If
            End If
        End If
    End Sub

    Public Overridable Function GetValueToSet() As Object
        If clsParameter IsNot Nothing Then
            If clsParameter.bIsString Then
                Return clsParameter.strArgumentValue
            ElseIf clsParameter.bIsFunction OrElse clsParameter.bIsOperator Then
                Return clsParameter.clsArgumentCodeStructure
            Else
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function

    Public Overridable Sub UpdateLinkedControls(Optional bReset As Boolean = False)
        Dim ucrControl As ucrCore
        Dim lstValues As Object()
        Dim bTemp As Boolean

        For Each kvpTemp As KeyValuePair(Of ucrCore, Object()) In lstValuesAndControl
            lstValues = kvpTemp.Value
            ucrControl = kvpTemp.Key
            bTemp = ControlValueContainedIn(lstValues) AndAlso bIsVisible
            If ucrControl.bLinkedUpdateFunction AndAlso bTemp Then
                ucrControl.SetRCode(clsRCode)
            End If
            If ucrControl.bLinkedChangeToDefaultState AndAlso bReset Then
                If ucrControl.clsRCode Is Nothing OrElse ucrControl.clsParameter Is Nothing OrElse (ucrControl.clsRCode IsNot Nothing AndAlso ucrControl.clsParameter IsNot Nothing AndAlso ucrControl.clsParameter.strArgumentName IsNot Nothing AndAlso (Not ucrControl.clsRCode.ContainsParameter(ucrControl.clsParameter.strArgumentName))) Then
                    ucrControl.SetToDefaultState()
                End If
            End If
            If ucrControl.bLinkedAddRemoveParameter Then
                ucrControl.AddOrRemoveParameter(bTemp)
            End If
            If ucrControl.bLinkedHideIfParameterMissing Then
                ucrControl.SetVisible(bTemp)
            End If
            If ucrControl.bLinkedDisabledIfParameterMissing Then
                ucrControl.Enabled = bTemp
            End If
            ucrControl.UpdateLinkedControls(bReset)
        Next
    End Sub

    'Update the RCode based on the contents of the control (reverse of above)
    Public Overridable Sub UpdateRCode(Optional bReset As Boolean = False)
        If bAddRemoveParameter Then
            AddOrRemoveParameter(CanAddParameter())
        End If
        UpdateLinkedControls(bReset)
    End Sub

    Public Overridable Sub SetRCode(clsNewCodeStructure As RCodeStructure, Optional bReset As Boolean = False)
        If clsRCode Is Nothing OrElse Not clsRCode.Equals(clsNewCodeStructure) Then
            clsRCode = clsNewCodeStructure
            If bUpdateRCodeFromControl AndAlso CanUpdate() Then
                UpdateRCode(bReset)
            End If
            UpdateControl(bReset)
        End If
    End Sub

    Protected Overridable Function CanUpdate()
        Return (clsParameter IsNot Nothing AndAlso (Not clsRCode.ContainsParameter(clsParameter.strArgumentName)) AndAlso clsParameter.HasValue())
    End Function

    Public Overridable Sub SetRDefault(objNewDefault As Object)
        objRDefault = objNewDefault
    End Sub

    Public Overridable Sub SetValueToRemoveParameter(objNewValue As Object)
        objValueToRemoveParameter = objNewValue
    End Sub

    Public Overridable Sub SetToRDefault()
        If clsParameter IsNot Nothing AndAlso objRDefault IsNot Nothing Then
            clsParameter.SetArgumentValue(objRDefault.ToString())
        End If
        UpdateControl()
    End Sub

    ''Set a linked paramter name and what the control should do when the parameter is not in the R code
    'Public Sub SetLinkedParameterName(strNewLinkedParameterName As String, Optional bNewHideIfLinkedParameterMissing As Boolean = False, Optional bNewDisableIfLinkedParameterMissing As Boolean = False)
    '    strLinkedParameterName = strNewLinkedParameterName
    '    bHideIfParameterMissing = bNewHideIfLinkedParameterMissing
    '    bDisabledIfParameterMissing = bNewDisableIfLinkedParameterMissing
    'End Sub

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
        OnControlContentsChanged()
        UpdateRCode()
        RaiseEvent ControlValueChanged(Me)
    End Sub

    Public Overridable Sub SetParameter(clsNewParameter As RParameter)
        clsParameter = clsNewParameter
    End Sub

    Public Overridable Function GetParameterName() As String
        If clsParameter IsNot Nothing Then
            Return clsParameter.strArgumentName
        Else
            Return ""
        End If
    End Function

    Public Overridable Function GetDefault() As Object
        Return objRDefault
    End Function

    Public Overridable Function ControlValueContainedIn(lstTemp As Object()) As Boolean
        Return False
    End Function

    Public Overridable Sub AddOrRemoveParameter(bAdd As Boolean)
        If clsRCode IsNot Nothing AndAlso clsParameter IsNot Nothing Then
            If bAdd Then
                clsRCode.AddParameter(clsParameter)
            Else
                clsRCode.RemoveParameter(clsParameter)
            End If
        End If
    End Sub

    Public Sub AddToLinkedControls(lstLinked As ucrCore(), objValues As Object(), Optional bNewLinkedAddRemoveParameter As Boolean = False, Optional bNewLinkedUpdateFunction As Boolean = False, Optional bNewLinkedDisabledIfParameterMissing As Boolean = False, Optional bNewLinkedHideIfParameterMissing As Boolean = False, Optional bNewLinkedChangeToDefaultState As Boolean = False, Optional objNewDefaultState As Object = Nothing)
        For Each ucrLinked As ucrCore In lstLinked
            AddToLinkedControls(ucrLinked:=ucrLinked, objValues:=objValues, bNewLinkedAddRemoveParameter:=bNewLinkedAddRemoveParameter, bNewLinkedUpdateFunction:=bNewLinkedUpdateFunction, bNewLinkedDisabledIfParameterMissing:=bNewLinkedDisabledIfParameterMissing, bNewLinkedHideIfParameterMissing:=bNewLinkedHideIfParameterMissing, bNewLinkedChangeToDefaultState:=bNewLinkedChangeToDefaultState, objNewDefaultState:=objNewDefaultState)
        Next
    End Sub

    Public Sub AddToLinkedControls(ucrLinked As ucrCore, objValues As Object(), Optional bNewLinkedAddRemoveParameter As Boolean = False, Optional bNewLinkedUpdateFunction As Boolean = False, Optional bNewLinkedDisabledIfParameterMissing As Boolean = False, Optional bNewLinkedHideIfParameterMissing As Boolean = False, Optional bNewLinkedChangeToDefaultState As Boolean = False, Optional objNewDefaultState As Object = Nothing)
        If Not IsLinkedTo(ucrLinked) Then
            ucrLinked.bLinkedAddRemoveParameter = bNewLinkedAddRemoveParameter
            ucrLinked.bLinkedChangeToDefaultState = bNewLinkedChangeToDefaultState
            ucrLinked.bLinkedDisabledIfParameterMissing = bNewLinkedDisabledIfParameterMissing
            ucrLinked.bLinkedHideIfParameterMissing = bNewLinkedHideIfParameterMissing
            ucrLinked.bLinkedUpdateFunction = bNewLinkedUpdateFunction
            ucrLinked.SetDefaultState(objNewDefaultState)
            lstValuesAndControl.Add(New KeyValuePair(Of ucrCore, Object())(ucrLinked, objValues))
        End If
    End Sub

    Public Function IsLinkedTo(ucrControl) As Boolean
        Dim bTemp As Boolean = False

        For Each kvpTemp As KeyValuePair(Of ucrCore, Object()) In lstValuesAndControl
            If kvpTemp.Key.Equals(ucrControl) Then
                bTemp = True
                Exit For
            End If
        Next
        Return bTemp
    End Function

    Public Overridable Function IsRDefault() As Boolean
        Return clsParameter IsNot Nothing AndAlso objRDefault IsNot Nothing AndAlso objRDefault.Equals(clsParameter.strArgumentValue)
    End Function

    Public Overridable Function CanAddParameter() As Boolean
        Return Not IsRDefault()
    End Function

    Public Function LinkedControlsParametersPresent() As Boolean
        Dim bTemp As Boolean = False

        For Each kvpTemp As KeyValuePair(Of ucrCore, Object()) In lstValuesAndControl
            If kvpTemp.Key.clsRCode IsNot Nothing AndAlso kvpTemp.Key.clsParameter IsNot Nothing AndAlso kvpTemp.Key.clsRCode.ContainsParameter(kvpTemp.Key.clsParameter) Then
                bTemp = True
                Exit For
            End If
        Next
        Return bTemp
    End Function

    Public Overridable Function GetParameter() As RParameter
        Return clsParameter
    End Function

    Public Sub SetLinkedDisplayControl(ctrNewControl As Control)
        ctrLinkedDisaplyControl = ctrNewControl
        SetLinkedDisplayControlVisibility()
    End Sub

    Private Sub ucrCore_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        SetLinkedDisplayControlVisibility()
    End Sub

    Private Sub SetLinkedDisplayControlVisibility()
        If ctrLinkedDisaplyControl IsNot Nothing Then
            ctrLinkedDisaplyControl.Visible = Visible
        End If
    End Sub

    Protected Overridable Sub SetToValue(objTemp As Object)
    End Sub

    Public Sub AddCondition(objControlState As Object, clsCond As Condition)
        If dctConditions.ContainsKey(objControlState) Then
            dctConditions(objControlState).Add(clsCond)
        Else
            dctConditions.Add(objControlState, {clsCond}.ToList())
        End If
    End Sub

    Public Sub AddParameterValuesCondition(objControlState As Object, strParamName As String, strParamValue As String, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterValues(strParamName, strParamValue, bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    Public Sub AddParameterValuesCondition(objControlState As Object, strParamName As String, lstParamValues As String(), Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterValues(strParamName, lstParamValues.ToList(), bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    Public Sub AddParameterPresentCondition(objControlState As Object, strParamName As String, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterPresentName(strParamName, bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    Public Sub AddFunctionNamesCondition(objControlState As Object, strFunctionName As String, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetFunctionName(strFunctionName, bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    Public Sub AddFunctionNamesCondition(objControlState As Object, lstFunctionNames As String(), Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetFunctionNamesMultiple(lstFunctionNames.ToList(), bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    Public Sub AddParameterIsStringCondition(objControlState As Object, strParameterName As String, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterType(strType:="string", strParamName:=strParameterName, bNewIsPositive:=bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    Public Sub AddParameterIsRFunctionCondition(objControlState As Object, strParameterName As String, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterType(strType:="RFunction", strParamName:=strParameterName, bNewIsPositive:=bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    Public Sub AddParameterIsROperatorCondition(objControlState As Object, strParameterName As String, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterType(strType:="ROperator", strParamName:=strParameterName, bNewIsPositive:=bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    Public Sub SetVisible(bVisible As Boolean)
        If ctrLinkedDisaplyControl IsNot Nothing AndAlso TypeOf ctrLinkedDisaplyControl Is GroupBox Then
            ctrLinkedDisaplyControl.Visible = bVisible
        Else
            Visible = bVisible
        End If
        SetLinkedDisplayControlVisibility()
        bIsVisible = bVisible
    End Sub

    Public Sub SetDefaultState(objState As Object)
        objDefaultState = objState
    End Sub

    Protected Overridable Sub SetToDefaultState()
        SetToValue(objDefaultState)
    End Sub

    'This should be used very cautiously, only if you want to change the parameter name and keep all other properties the same.
    'Setting a new parameter is usually a much safer option.
    Public Overridable Sub ChangeParameterName(strNewName As String, Optional bClearConditions As Boolean = True)
        If clsParameter IsNot Nothing Then
            clsParameter.SetArgumentName(strNewName)
        End If
        If bClearConditions Then
            dctConditions.Clear()
        End If
    End Sub

    Public Sub SetParameterValue(strNewValue As String)
        If clsParameter IsNot Nothing Then
            clsParameter.SetArgumentValue(strNewValue)
        End If
    End Sub

    Public Sub SetValuesToIgnore(strValues() As String)
        strValuesToIgnore = strValues
    End Sub
End Class