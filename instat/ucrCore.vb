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

Public Class ucrCore
    'These lists are intended to be pairs of (RCode, RParameter) which this control may manage
    'The first item in each list can be accessed through the properties clsRCode and clsRParameter
    'There may be duplicate values in the lists. For example, one parameter being added into multiple functions.
    Protected lstAllRCodes As List(Of RCodeStructure) = New List(Of RCodeStructure)({Nothing})
    Protected lstAllRParameters As List(Of RParameter) = New List(Of RParameter)({Nothing})
    'Control may have conditions on RSyntax as a whole i.e. value depends on a function being in the RSyntax
    Protected clsRSyntax As RSyntax = Nothing
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

    'We may set the R code for the control (because it's easier to set for a whole dialog)
    'but do not want the control to update from the code. Set to False in this case.
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
    Public Overridable Sub UpdateControl(Optional bReset As Boolean = False, Optional bCloneIfNeeded As Boolean = False)
        Dim clsTempRCode As RCodeStructure
        Dim clsTempRParameter As RParameter
        Dim clsTempCloneParameter As RParameter

        For i As Integer = 0 To lstAllRCodes.Count - 1
            clsTempRCode = lstAllRCodes(i)
            clsTempRParameter = lstAllRParameters(i)
            If clsTempRCode IsNot Nothing Then
                If clsTempRParameter IsNot Nothing Then
                    If Not clsTempRCode.ContainsParameter(clsTempRParameter) Then
                        If clsTempRCode.ContainsParameter(clsTempRParameter.strArgumentName) Then
                            SetParameter(clsTempRCode.GetParameter(clsTempRParameter.strArgumentName), i)
                        Else
                            'This causes an issue if this parameter is contained in another control
                            'because the link is broken
                            'Not an issue if controls do not need to share parameters
                            'This is needed so that if this parameter is contained in functions in multiple dialogs,
                            'the parameter only changes the functions in the currently open dialog
                            If bCloneIfNeeded Then
                                clsTempCloneParameter = GetParameter(i).Clone()
                            Else
                                clsTempCloneParameter = GetParameter(i)
                            End If

                            If Not bUpdateRCodeFromControl AndAlso bChangeParameterValue AndAlso objDefaultState Is Nothing Then
                                clsTempCloneParameter.ClearAllArguments()
                            End If
                            SetParameter(clsTempCloneParameter, i)

                            'If the control has a default state then it's linked control will set the value and we should not set to R default
                            If objDefaultState Is Nothing Then
                                If objRDefault IsNot Nothing Then
                                    SetToRDefault()
                                End If
                                'If there is no R default the value should remain nothing and SetControlValue() will set an apppropriate "empty" value
                            End If
                        End If
                    End If
                Else
                End If
            Else
                clsTempRCode = New RCodeStructure
            End If
        Next
        SetControlValue()
        UpdateLinkedControls(bReset)
    End Sub

    Protected Overridable Sub SetControlValue()
        Dim bConditionsMet As Boolean = False

        If bIsActiveRControl Then
            'If the default state is set then the linked control will set the value for this control
            If objDefaultState Is Nothing Then
                If clsRCode IsNot Nothing OrElse clsRSyntax IsNot Nothing Then
                    For Each kvpTemp As KeyValuePair(Of Object, List(Of Condition)) In dctConditions
                        If kvpTemp.Value.Count > 0 Then
                            If AllConditionsSatisfied(kvpTemp.Value, clsRCode, clsParameter, clsRSyntax) Then
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
                            SetToValue(GetValueToSet())
                        Else
                            MsgBox("Developer error: no state of control " & Name & " satisfies it's condition. Cannot determine how to set the control from the RCode. Modify control setup so that one state can satisfy its conditions.")
                        End If
                    End If
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
                ucrControl.AddOrRemoveParameter(bTemp AndAlso (ucrControl.CanAddParameter() OrElse Not ucrControl.bAddRemoveParameter))
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

    Public Overridable Sub SetRCode(clsNewCodeStructure As RCodeStructure, Optional bReset As Boolean = False, Optional bUpdate As Boolean = True, Optional bCloneIfNeeded As Boolean = False)
        If clsRCode Is Nothing OrElse Not clsRCode.Equals(clsNewCodeStructure) Then
            clsRCode = clsNewCodeStructure
            If clsRCode IsNot Nothing AndAlso bUpdateRCodeFromControl AndAlso CanUpdate() AndAlso bUpdate Then
                UpdateRCode(bReset)
            End If
        End If
        If bUpdate Then
            UpdateControl(bReset:=bReset, bCloneIfNeeded:=bCloneIfNeeded)
        End If
    End Sub

    'TODO in future may want to set RCode and RSyntax together if both needed for conditions
    '     then would need method to add both at the same time
    Public Overridable Sub SetRSyntax(clsNewRSyntax As RSyntax, Optional bReset As Boolean = False, Optional bCloneIfNeeded As Boolean = False)
        If clsRSyntax Is Nothing OrElse Not clsRSyntax.Equals(clsNewRSyntax) Then
            clsRSyntax = clsNewRSyntax
            If bUpdateRCodeFromControl AndAlso CanUpdate() Then
                UpdateRCode(bReset)
            End If
        End If
        UpdateControl(bReset, bCloneIfNeeded:=bCloneIfNeeded)
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
        'Removed because this is currently only called within UpdateControl() so control will be updated anyway
        'UpdateControl()
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
        UpdateAllParameters()
        UpdateRCode()
        RaiseEvent ControlValueChanged(Me)
    End Sub

    Public Overridable Sub SetParameter(clsNewParameter As RParameter, Optional iIndex As Integer = 0)
        lstAllRParameters(iIndex) = clsNewParameter
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
        For i As Integer = 0 To lstAllRCodes.Count - 1
            If lstAllRCodes(i) IsNot Nothing AndAlso lstAllRParameters(i) IsNot Nothing Then
                If bAdd Then
                    lstAllRCodes(i).AddParameter(lstAllRParameters(i))
                Else
                    lstAllRCodes(i).RemoveParameterByName(lstAllRParameters(i).strArgumentName)
                End If
            End If
        Next
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
        Return clsParameter IsNot Nothing AndAlso clsParameter.strArgumentValue IsNot Nothing AndAlso objRDefault IsNot Nothing AndAlso objRDefault.Equals(clsParameter.strArgumentValue)
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

    Public Overridable Function GetParameter(Optional iIndex As Integer = 0) As RParameter
        If iIndex < lstAllRParameters.Count Then
            Return lstAllRParameters(iIndex)
        Else
            Return Nothing
        End If
    End Function

    Public Overridable Function GetRCode() As RCodeStructure
        Return clsRCode
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

        clsTempCond.SetParameterPresentNames(strParamName, bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    Public Sub AddParameterPresentCondition(objControlState As Object, lstParamName As String(), Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterPresentNames(lstParamName.ToString(), bNewIsPositive)
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

    Public Sub AddParameterValueFunctionNamesCondition(objControlState As Object, strParameterName As String, strFunctionName As String, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterValuesRFunctionNames(strParamName:=strParameterName, strRCodeNames:=strFunctionName, bNewIsPositive:=bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    Public Sub AddParameterValueFunctionNamesCondition(objControlState As Object, strParameterName As String, strFunctionNames As String(), Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterValuesRFunctionNames(strParamName:=strParameterName, lstRCodeNames:=strFunctionNames.ToList(), bNewIsPositive:=bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    Public Sub AddRSyntaxContainsFunctionNamesCondition(objControlState As Object, strFunctionNames As String(), Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetRSyntaxFunctionNamesMultiple(strFunctionNames.ToList(), bNewIsPositive:=bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    Public Sub AddRSyntaxContainCodeCondition(objControlState As Object, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetRSyntaxContainsCode(bNewIsPositive:=bNewIsPositive)
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
            ClearConditions()
        End If
    End Sub

    Public Sub ClearConditions()
        dctConditions.Clear()
    End Sub

    Public Sub SetParameterValue(strNewValue As String)
        If clsParameter IsNot Nothing Then
            clsParameter.SetArgumentValue(strNewValue)
        End If
    End Sub

    Public Sub SetValuesToIgnore(strValues() As String)
        strValuesToIgnore = strValues
    End Sub

    Public Overridable Sub AddAdditionalCodeParameterPair(clsNewRCode As RCodeStructure, clsNewRParameter As RParameter, Optional iAdditionalPairNo As Integer = -1)
        If iAdditionalPairNo = -1 Then
            iAdditionalPairNo = lstAllRCodes.Count
        End If
        If iAdditionalPairNo < lstAllRCodes.Count Then
            lstAllRCodes(iAdditionalPairNo) = clsNewRCode
            lstAllRParameters(iAdditionalPairNo) = clsNewRParameter
        ElseIf iAdditionalPairNo = lstAllRCodes.Count Then
            lstAllRCodes.Add(clsNewRCode)
            lstAllRParameters.Add(clsNewRParameter)
        Else
            MsgBox("Developer error: Cannot add additional RCode and RParameter pair because the additional pair number is out of bounds of the current pairs.")
        End If
    End Sub

    'In general this should not be overrided. Only for controls which use parameters in very different way e.g. ucrSave
    Protected Overridable Sub UpdateAllParameters()
        For i As Integer = 0 To lstAllRParameters.Count - 1
            UpdateParameter(lstAllRParameters(i))
        Next
    End Sub

    Public Overridable Sub UpdateParameter(clsTempParam As RParameter)
        If GetValueToSet() IsNot Nothing Then
            clsTempParam.SetArgumentValue(GetValueToSet().ToString())
        End If
    End Sub

    Public Sub SetParameterIncludeArgumentName(bInclude As Boolean)
        If clsParameter IsNot Nothing Then
            clsParameter.bIncludeArgumentName = bInclude
        End If
    End Sub

    Public Sub SetParameterPosition(iPosition As Integer)
        If clsParameter IsNot Nothing Then
            clsParameter.Position = iPosition
        End If
    End Sub

    Private Property clsParameter As RParameter
        Get
            Return lstAllRParameters(0)
        End Get
        Set(bNewRParameter As RParameter)
            lstAllRParameters(0) = bNewRParameter
        End Set
    End Property

    Private Property clsRCode As RCodeStructure
        Get
            Return lstAllRCodes(0)
        End Get
        Set(bNewRCode As RCodeStructure)
            lstAllRCodes(0) = bNewRCode
        End Set
    End Property

    Protected Overridable Sub ResetControlValue()
        'TODO implement in specific controls
    End Sub

    Public Overridable Sub ClearCodeAndParameters()
        lstAllRCodes = New List(Of RCodeStructure)
        lstAllRParameters = New List(Of RParameter)
        'Ensures there is always something at index 0
        lstAllRCodes.Add(Nothing)
        lstAllRParameters.Add(Nothing)
        UpdateControl()
    End Sub

    Public Overridable Sub SetAddRemoveParameter(bNew As Boolean)
        bAddRemoveParameter = bNew
    End Sub
End Class