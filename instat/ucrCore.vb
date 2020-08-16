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

''' <summary> The ucrCore class inherits from the 'System.Windows.Forms.UserControl' class.
''' It is an empty control that is used as the foundation class for the other R-Instat controls.
''' <para> Each R-Instat user control class is prefixed with 'ucr' (e.g. ucrButtons, ucrCalculator, ucrCheck etc.).
''' Any class that inherits from ucrCore is called a core control. 
''' There are also some non-core controls such as the selector (which does not correspond to any R command or parameter). </para>
''' <para> The comments for this class use the following terminology: </para>
''' <list type="bullet"><item><description> Control </description></item>
''' <item><description> Core control </description></item>
''' <item><description> Control's value </description></item>
''' <item><description> Control’s R code </description></item>
''' <item><description> Primary pair </description></item>
''' <item><description> Non-primary pair(s) </description></item>
''' <item><description> Linked control </description></item>
''' <item><description>	Parent control </description></item>
''' </list>
''' </summary>

Public Class ucrCore
    'These lists are intended to be pairs of (RCode, RParameter) which this control may manage
    'The first item in each list can be accessed through the properties clsRCode and clsRParameter
    'There may be duplicate values in the lists. For example, one parameter being added into multiple functions.

    ''' <summary> The 'lstAllRCodes' and 'lstAllRParameters' lists contain pairs of R commands and 
    '''           parameters associated with the user control. 
    '''           The first pair is considered the primary pair and can be accessed directly using 
    '''           the properties 'clsRCode' and 'clsRParameter' (these just reference the first 
    '''           element in the lists).
    ''' </summary>
    Protected lstAllRCodes As List(Of RCodeStructure) = New List(Of RCodeStructure)({Nothing})
    ''' <summary> The 'lstAllRCodes' and 'lstAllRParameters' lists contain pairs of R commands and 
    '''           parameters associated with the user control. 
    '''           The first pair is considered the primary pair and can be accessed directly using 
    '''           the properties 'clsRCode' and 'clsRParameter' (these just reference the first 
    '''           element in the lists).
    ''' </summary>
    Protected lstAllRParameters As List(Of RParameter) = New List(Of RParameter)({Nothing})



    ''' <summary> Only used within the conditions.
    ''' A condition may apply to an RSyntax object rather than the primary command-parameter pair. </summary>
    Protected clsRSyntax As RSyntax = Nothing



    ''' <summary> The object default is the control's default value
    ''' for the primary parameter (i.e. the value that R will assume if the primary parameter is not included in the script). </summary>
    Protected objRDefault As Object = Nothing

    ''' <summary> The object default is the control's default value 
    ''' for the primary parameter (i.e. the value that R will assume if the primary parameter is not included in the script). </summary>
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

    ''' <summary> If true then this user control can add/remove parameters.
    '''  (e.g. check box may not change parameter value, only add/remove it
    '''  For this bAddRemoveParameter = True and bChangeParameterValue = False)
    ''' </summary>
    Public bAddRemoveParameter As Boolean = True

    ''' <summary> If true then this user control may change the value of parameters.
    ''' (e.g. check box may not change parameter value, only add/remove it
    '''  For this bAddRemoveParameter = True and bChangeParameterValue = False)
    ''' </summary>
    Public bChangeParameterValue As Boolean = True

    ''' <summary> If parameter has this value the it will be removed from the RCodeStructure </summary>
    Public objValueToRemoveParameter As Object

    ''' <summary>
    ''' ValueChanged is raised when a new value has been set in the control (e.g. the user set a text in a textbox)
    ''' </summary>
    ''' <param name="ucrChangedControl"> Refer to the control changed </param>
    Public Event ControlValueChanged(ucrChangedControl As ucrCore)


    ''' <summary>
    ''' ContentsChanged is raised when the content of the control has changed, 
    ''' but possibly the value has not been set (e.g. text in a textbox changes, 
    ''' but the value is not changed until the user leaves the text box)
    ''' When ValueChanged is raised, so is ContentsChanged
    ''' ContentsChanged is probably only needed for TestOK
    ''' </summary>
    ''' <param name="ucrChangedControl"> Refer to the control changed </param>
    Public Event ControlContentsChanged(ucrChangedControl As ucrCore)

    ''' <summary> ControlClicked is raised when the control is clicked.
    ''' For some controls, this will be raised when their child controls is clicked.
    ''' </summary>
    Public Event ControlClicked()


    ''' <summary> Lists all the controls linked to this control (hereafter called 'child control' and 'parent control' respectively).
    ''' Used when this control determines aspects of other controls (e.g. add/remove the parameter of other controls)
    ''' set the visible/enabled property of other controls (e.g. a checkbox that shows/hides set of controls)
    ''' </summary>
    Protected lstValuesAndControl As New List(Of KeyValuePair(Of ucrCore, Object()))


    ''' <summary> If this control is in another control's lstLinkedControls then these booleans specify
    ''' how the parent control can modify this control. </summary>
    Public bLinkedAddRemoveParameter As Boolean = False

    ''' <summary> If this control is in another control's lstLinkedControls then
    ''' these booleans specify how the parent control can modify this control. </summary>
    Public bLinkedUpdateFunction As Boolean = False

    ''' <summary> If this control is in another control's lstLinkedControls then these booleans specify how the parent control can modify this control. </summary>
    Public bLinkedDisabledIfParameterMissing As Boolean = False

    ''' <summary> If this control is in another control's lstLinkedControls then 
    ''' these booleans specify how the parent control can modify this control. </summary>
    Public bLinkedHideIfParameterMissing As Boolean = False

    ''' <summary> If this control is in another control's lstLinkedControls then 
    ''' these booleans specify how the parent control can modify this control. </summary>
    Public bLinkedChangeToDefaultState As Boolean = False
    'Suggested new option needed so that linked control gets value set correctly

    ''' <summary> If this control is in another control's lstLinkedControls then
    ''' these booleans specify how the parent control can modify this control. </summary>
    Public bLinkedChangeParameterValue As Boolean = False

    ''' <summary> List all the controls to display linked to this control,
    ''' set the visible/enabled property of these controls (e.g. a checkbox that shows/hides set of controls)
    ''' </summary>
    Protected lstCtrLinkedDisplayControls As List(Of Control)


    ''' <summary> If true then the control's value can be set from the control's R code (if false, then it cannot be set). </summary>
    Public bIsActiveRControl As Boolean = True

    ''' <summary> If true, then update the control's associated commands and parameters whenever the control's value changes. </summary>
    Public bUpdateRCodeFromControl As Boolean = False


    ''' <summary> This dictionary is used to set the control's value (i.e. the value displayed to the user in the control's dialog box), from the control's R code.  </summary>
    Protected dctConditions As New Dictionary(Of Object, List(Of Condition))

    ''' <summary> If true then allow the control's value to be set to a value that is not one of the pre-defined valid values in the 'dctConditions' dictionary.
    ''' If false, then only pre-defined values are allowed (e.g. a check box sets a value to either true or false). </summary>
    Public bAllowNonConditionValues As Boolean = True

    ''' <summary> If true then set visible property of this control </summary>
    Public bIsVisible As Boolean = True


    ''' <summary> Values which the parameter associated to the control may have 
    ''' but which shouldn't be used to set the control's value.
    ''' (Currently only implemented for receivers) </summary>
    Protected strValuesToIgnore As String()


    ''' <summary> Updates the control, and the linked controls, based upon the values of the parameters in the command-parameter pair list. </summary>
    ''' <param name="bReset"> (Optional) Should the control reset to the default value if the parameter is not present in the code </param>
    ''' <param name="bCloneIfNeeded"> (Optional) Should the control control if needed when the parameter is present in the code </param>
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

    ''' <summary> Updates the control value from the control’s R code.
    ''' <para> It does this by checking all the control’s conditions: </para>
    ''' <list type="bullet">
    ''' <item><description> If one (and only one) condition is met then the control's value is set to the value associated with the condition. </description></item>
    ''' <item><description> If no conditions are met and 'bAllowNonConditionValues' is true then the control’s value is set from the primary parameter. </description></item>
    ''' <item><description> Else a developer error is thrown. </description></item>
    ''' </list>
    ''' 
    ''' </summary>
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

    ''' <summary> Returns the value of the primary parameter (the first parameter in the command-parameter list): 
    ''' <list type="bullet">
    ''' <item><description> If the parameter's argument is a string then returns a string object. 
    ''' Please note that all arguments that are not functions or operators (e.g. names, integers, reals, booleans etc.) are returned as strings </description></item>
    ''' <item><description> If the parameter's argument is a function or operator, then returns an 'RCodeStructure' </description></item>
    ''' <item><description> Else returns 'nothing'. </description></item>
    ''' </list>
    ''' </summary>
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

    ''' <summary> Updates all the controls linked to this control (hereafter called 'child' and 'parent' respectively) </summary>
    ''' <param name="bReset"> (Optional) The control should reset to the default value. </param>
    Public Overridable Sub UpdateLinkedControls(Optional bReset As Boolean = False)
        Dim ucrControl As ucrCore
        Dim lstValues As Object()
        Dim bTemp As Boolean
        Dim objTempDefaultState As Object

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
                If (bTemp AndAlso (ucrControl.CanAddParameter() OrElse Not ucrControl.bAddRemoveParameter)) AndAlso ucrControl.bLinkedChangeParameterValue Then
                    ' Temp clear the default state so that control will set value correctly
                    ' This is a temporary fix!
                    ' TODO reimplement this through changing SetControlValue()
                    objTempDefaultState = ucrControl.objDefaultState
                    ucrControl.SetDefaultState(Nothing)
                    ucrControl.SetControlValue()
                    ucrControl.SetDefaultState(objTempDefaultState)
                End If
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


    ''' <summary> Update the R code by adding/removing  parameter. </summary>
    ''' <param name="bReset"> (Optional) The control should reset to the default value. </param>
    Public Overridable Sub UpdateRCode(Optional bReset As Boolean = False)
        If bAddRemoveParameter Then
            AddOrRemoveParameter(CanAddParameter())
        End If
        UpdateLinkedControls(bReset)
    End Sub

    'Private Sub RemoveParameterFromRCode()
    '    If Not clsRCode Is Nothing Then
    '        clsRCode.RemoveParameter(clsParameter)
    '    End If
    'End Sub

    Public Overridable Sub SetRCode(clsNewCodeStructure As RCodeStructure, Optional bReset As Boolean = False, Optional bUpdate As Boolean = True, Optional bCloneIfNeeded As Boolean = False)
        If clsRCode Is Nothing OrElse Not clsRCode.Equals(clsNewCodeStructure) Then
            '    If Not clsRCode Is Nothing Then
            '        RemoveParameterFromRCode()
            '    End If
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

    ''' <summary> Set the R syntax to the control.  </summary>
    ''' <param name="clsNewRSyntax"> The new R syntax. </param>
    ''' <param name="bReset"> If true reset to default </param>
    ''' <param name="bCloneIfNeeded"> (Optional) The control should reset to the default value. </param>
    Public Overridable Sub SetRSyntax(clsNewRSyntax As RSyntax, Optional bReset As Boolean = False, Optional bCloneIfNeeded As Boolean = False)
        If clsRSyntax Is Nothing OrElse Not clsRSyntax.Equals(clsNewRSyntax) Then
            clsRSyntax = clsNewRSyntax
            If bUpdateRCodeFromControl AndAlso CanUpdate() Then
                UpdateRCode(bReset)
            End If
        End If
        UpdateControl(bReset, bCloneIfNeeded:=bCloneIfNeeded)
    End Sub

    ''' <summary> Can update the parameter into the R codes.  </summary>
    ''' <returns> The parameter updated. </returns>
    Protected Overridable Function CanUpdate()
        Return (clsParameter IsNot Nothing AndAlso (Not clsRCode.ContainsParameter(clsParameter.strArgumentName)) AndAlso clsParameter.HasValue())
    End Function

    ''' <summary> Set the object to be a default R object. </summary>
    ''' <param name="objNewDefault"> The R object parameter</param>
    Public Overridable Sub SetRDefault(objNewDefault As Object)
        objRDefault = objNewDefault
    End Sub

    ''' <summary> Set a value in the object to remove a parameter. </summary>
    ''' <param name="objNewValue"> The parameter of the object. </param>
    Public Overridable Sub SetValueToRemoveParameter(objNewValue As Object)
        objValueToRemoveParameter = objNewValue
    End Sub


    ''' <summary> Set an object to R default. </summary>
    Public Overridable Sub SetToRDefault()
        If clsParameter IsNot Nothing AndAlso objRDefault IsNot Nothing Then
            clsParameter.SetArgumentValue(objRDefault.ToString())
        End If
        'Removed because this is currently only called within UpdateControl() so control will be updated anyway
        'UpdateControl()
    End Sub


    ''' <summary> Set the Text property of the control(s) inside this control (should only be one). 
    ''' Implemented different by each VB control. </summary>
    ''' 
    ''' <param name="strNewText"> The parameter's String value.</param>
    Public Overridable Sub SetText(strNewText As String)
        For Each ctrTemp In Controls
            ctrTemp.Text = strNewText
        Next
    End Sub

    ''' <summary> OnControlContentsChanged is raised when the content of the control is changed. </summary>
    Public Sub OnControlContentsChanged()
        RaiseEvent ControlContentsChanged(Me)
    End Sub

    ''' <summary> OnControlContentsChanged is raised when the value of the control is changed.
    ''' This update all the prameters in the code, the Rcode and content of this control. </summary>
    Public Sub OnControlValueChanged()
        OnControlContentsChanged()
        UpdateAllParameters()
        UpdateRCode()
        RaiseEvent ControlValueChanged(Me)
    End Sub

    ''' <summary> OnControlClicked is raised when the user click on a control. </summary>
    Public Sub OnControlClicked()
        RaiseEvent ControlClicked()
    End Sub


    ''' <summary> Set the parameter in the R code. </summary>
    ''' 
    ''' <param name="clsNewParameter"> The new parameter to set. </param>
    ''' <param name="iIndex"> (Optional) The relative position of the parameter in this object's parameter list. </param>
    Public Overridable Sub SetParameter(clsNewParameter As RParameter, Optional iIndex As Integer = 0)
        ''this should be removing the old parameter from the rcode before replacing it. Currently only implemented for iIndex =0
        'If iIndex = 0 Then
        '    RemoveParameterFromRCode()
        'End If
        lstAllRParameters(iIndex) = clsNewParameter
    End Sub


    ''' <summary> Get the parameter name. </summary>
    ''' <returns> Return the name of the parameter. </returns>
    Public Overridable Function GetParameterName() As String
        If clsParameter IsNot Nothing Then
            Return clsParameter.strArgumentName
        Else
            Return ""
        End If
    End Function

    ''' <summary> Get the default object. </summary>
    ''' <returns> Return the default object. </returns>
    Public Overridable Function GetDefault() As Object
        Return objRDefault
    End Function


    ''' <summary> Control the value contained in the control. </summary>
    ''' <param name="lstTemp"> The parameter of the control. </param>
    ''' <returns> Return False. </returns>
    Public Overridable Function ControlValueContainedIn(lstTemp As Object()) As Boolean
        Return False
    End Function

    ''' <summary> Add/Remove parameter in the RCodes.
    ''' </summary>
    ''' <param name="bAdd"> True to add parameter in the RCode. </param>
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

    ''' <summary> Adds a new linked control to the 'lstValuesAndControl' list. </summary>
    ''' <param name="lstLinked">  The parameter's control. </param>
    ''' <param name="objValues"> The object parameter. </param>
    ''' <param name="bNewLinkedAddRemoveParameter"> Add/Remove parameter of the new linked control. </param>
    ''' <param name="bNewLinkedUpdateFunction"> Update the function of the new linked control. </param>
    ''' <param name="bNewLinkedDisabledIfParameterMissing"> Disable the new linked control if parameter missing. </param>
    ''' <param name="bNewLinkedHideIfParameterMissing"> Hide the new linked control if parameter missing. </param>
    ''' <param name="bNewLinkedChangeToDefaultState"> The New linked change to default state of the control. </param>
    ''' <param name="objNewDefaultState"> The new state of the boject. </param>
    ''' <param name="bNewLinkedChangeParameterValue"> The New value change of the parameter linked. </param>
    Public Sub AddToLinkedControls(lstLinked As ucrCore(), objValues As Object(), Optional bNewLinkedAddRemoveParameter As Boolean = False, Optional bNewLinkedUpdateFunction As Boolean = False, Optional bNewLinkedDisabledIfParameterMissing As Boolean = False, Optional bNewLinkedHideIfParameterMissing As Boolean = False, Optional bNewLinkedChangeToDefaultState As Boolean = False, Optional objNewDefaultState As Object = Nothing, Optional bNewLinkedChangeParameterValue As Boolean = False)
        For Each ucrLinked As ucrCore In lstLinked
            AddToLinkedControls(ucrLinked:=ucrLinked, objValues:=objValues, bNewLinkedAddRemoveParameter:=bNewLinkedAddRemoveParameter, bNewLinkedUpdateFunction:=bNewLinkedUpdateFunction, bNewLinkedDisabledIfParameterMissing:=bNewLinkedDisabledIfParameterMissing, bNewLinkedHideIfParameterMissing:=bNewLinkedHideIfParameterMissing, bNewLinkedChangeToDefaultState:=bNewLinkedChangeToDefaultState, objNewDefaultState:=objNewDefaultState, bNewLinkedChangeParameterValue:=bNewLinkedChangeParameterValue)
        Next
    End Sub

    ''' <summary> Adds a new linked control to the 'lstValuesAndControl' list. </summary>
    ''' <param name="ucrLinked"> The parameter's control. </param>
    ''' <param name="objValues"> The object parameter. </param>
    ''' <param name="bNewLinkedAddRemoveParameter"> Add/Remove parameter of the new linked control. </param>
    ''' <param name="bNewLinkedUpdateFunction"> Update the function of the new linked control. </param>
    ''' <param name="bNewLinkedDisabledIfParameterMissing"> Disable the new linked control if parameter missing. </param>
    ''' <param name="bNewLinkedHideIfParameterMissing"> Hide the new linked control if parameter missing. </param>
    ''' <param name="bNewLinkedChangeToDefaultState"> The New linked change to default state of the control. </param>
    ''' <param name="objNewDefaultState"> The new state of the boject. </param>
    ''' <param name="bNewLinkedChangeParameterValue"> The New value change of the parameter linked. </param>
    Public Sub AddToLinkedControls(ucrLinked As ucrCore, objValues As Object(), Optional bNewLinkedAddRemoveParameter As Boolean = False, Optional bNewLinkedUpdateFunction As Boolean = False, Optional bNewLinkedDisabledIfParameterMissing As Boolean = False, Optional bNewLinkedHideIfParameterMissing As Boolean = False, Optional bNewLinkedChangeToDefaultState As Boolean = False, Optional objNewDefaultState As Object = Nothing, Optional bNewLinkedChangeParameterValue As Boolean = False)
        If Not IsLinkedTo(ucrLinked) Then
            ucrLinked.bLinkedAddRemoveParameter = bNewLinkedAddRemoveParameter
            ucrLinked.bLinkedChangeToDefaultState = bNewLinkedChangeToDefaultState
            ucrLinked.bLinkedDisabledIfParameterMissing = bNewLinkedDisabledIfParameterMissing
            ucrLinked.bLinkedHideIfParameterMissing = bNewLinkedHideIfParameterMissing
            ucrLinked.bLinkedUpdateFunction = bNewLinkedUpdateFunction
            ucrLinked.SetDefaultState(objNewDefaultState)
            ucrLinked.bLinkedChangeParameterValue = bNewLinkedChangeParameterValue
            lstValuesAndControl.Add(New KeyValuePair(Of ucrCore, Object())(ucrLinked, objValues))
        End If
    End Sub


    ''' <summary> Check if the control is linked to another control.
    ''' </summary>
    ''' <param name="ucrControl"> parameter refering to the control</param>
    ''' <returns> Temporary control value. </returns>
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

    ''' <summary> If the parameter is a default R code. </summary>
    ''' <returns> Parameter. </returns>
    Public Overridable Function IsRDefault() As Boolean
        Return clsParameter IsNot Nothing AndAlso clsParameter.strArgumentValue IsNot Nothing AndAlso objRDefault IsNot Nothing AndAlso objRDefault.Equals(clsParameter.strArgumentValue)
    End Function

    ''' <summary> Can add parameter in the R code. </summary>
    ''' <returns> True if it's not a default R code. False otherwise. </returns>
    Public Overridable Function CanAddParameter() As Boolean
        Return Not IsRDefault()
    End Function


    ''' <summary> True if the is a present linked controls parameters otherwise False. </summary>
    ''' <returns> Temporary control value </returns>
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

    ''' <summary> Get the list of all the R parameters.
    ''' </summary>
    ''' <param name="iIndex"> The position that needs to count the list of R parameters </param>
    ''' <returns> A list of All the R parameters or Nothing. </returns>
    Public Overridable Function GetParameter(Optional iIndex As Integer = 0) As RParameter
        If iIndex < lstAllRParameters.Count Then
            Return lstAllRParameters(iIndex)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary> Get the R codes.  </summary>
    ''' <returns> R codes.  </returns>
    Public Overridable Function GetRCode() As RCodeStructure
        Return clsRCode
    End Function

    ''' <summary>
    ''' Set the link of the new control with other controls linked to display.
    ''' </summary>
    ''' <param name="ctrNewControl"> The new control to be linked to other </param>
    Public Sub SetLinkedDisplayControl(ctrNewControl As Control)
        Dim lstCtrNewControls As New List(Of Control)
        lstCtrNewControls.Add(ctrNewControl)

        SetLinkedDisplayControl(lstCtrNewControls)

    End Sub

    ''' <summary>
    ''' Set the link of the new control with other controls linked to display to be visible.
    ''' </summary>
    ''' <param name="lstCtrNewControls"> The list of new controls to be linked to other </param>
    Public Sub SetLinkedDisplayControl(lstCtrNewControls As List(Of Control))
        lstCtrLinkedDisplayControls = lstCtrNewControls
        SetLinkedDisplayControlVisibility()
    End Sub

    Private Sub ucrCore_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        SetLinkedDisplayControlVisibility()
    End Sub

    ''' <summary>
    ''' Set the linked control to display to be visible property and return the contains groupbox.
    ''' </summary>
    Private Sub SetLinkedDisplayControlVisibility()
        SetLinkedDisplayControlVisibilityAndReturnContainsGroupBox(Visible)
    End Sub


    ''' <summary>
    ''' Set the linked control to display to be visible property and return the contains groupbox. 
    ''' </summary>
    ''' <param name="bVisible"> True then visible property of the controls. </param>
    ''' <returns> True is if the type of control is a groupbox. </returns>
    Private Function SetLinkedDisplayControlVisibilityAndReturnContainsGroupBox(bVisible As Boolean) As Boolean
        Dim ctr As Control
        Dim bContainsGroupBox As Boolean = False

        If lstCtrLinkedDisplayControls IsNot Nothing Then
            For Each ctr In lstCtrLinkedDisplayControls
                ctr.Visible = bVisible

                If (TypeOf ctr Is GroupBox) Then
                    bContainsGroupBox = True
                End If
            Next

        End If

        Return bContainsGroupBox
    End Function

    ''' <summary> Set the value to the object. </summary>
    ''' <param name="objTemp"> The parameter's object value.</param>
    Public Overridable Sub SetToValue(objTemp As Object)
    End Sub

    ''' <summary> Add a condition to the object. </summary>
    ''' <param name="objControlState"> The parameter that control the state of the object </param>
    ''' <param name="clsCond"> The parameter of the condition to add </param>
    Public Sub AddCondition(objControlState As Object, clsCond As Condition)
        If dctConditions.ContainsKey(objControlState) Then
            dctConditions(objControlState).Add(clsCond)
        Else
            dctConditions.Add(objControlState, {clsCond}.ToList())
        End If
    End Sub

    ''' <summary> Add the condition to the valus of the parameter </summary>
    ''' <param name="objControlState"> The parameter that control the state of the object. </param>
    ''' <param name="strParamName"> The parameter's name.</param>
    ''' <param name="strParamValue"> The parameter's name. </param>
    ''' <param name="bNewIsPositive"> (Optional) If true then add condition to the parameter values. </param>
    Public Sub AddParameterValuesCondition(objControlState As Object, strParamName As String, strParamValue As String, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterValues(strParamName, strParamValue, bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub


    ''' <summary> Add the condition to the valus of the parameter </summary>
    ''' <param name="objControlState"> The parameter that control the state of the object. </param>
    ''' <param name="strParamName"> The parameter's name. </param>
    ''' <param name="lstParamValues"> The parameter's values list.</param>
    ''' <param name="bNewIsPositive"> (Optional) If true then add condition to the parameter values. </param>
    Public Sub AddParameterValuesCondition(objControlState As Object, strParamName As String, lstParamValues As String(), Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterValues(strParamName, lstParamValues.ToList(), bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub


    ''' <summary> Add condition to the current parameter.
    ''' </summary>
    ''' <param name="objControlState"> The parameter that control the state of the object. </param>
    ''' <param name="strParamName"> The parameter's name. </param>
    ''' <param name="bNewIsPositive"> (Optional) If true then add condition to the parameter. </param>
    Public Sub AddParameterPresentCondition(objControlState As Object, strParamName As String, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterPresentNames(strParamName, bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub


    ''' <summary> Add condition to the current parameter.
    ''' </summary>
    ''' <param name="objControlState"> The parameter that control the state of the object. </param>
    ''' <param name="lstParamName"> The parameter's list. </param>
    ''' <param name="bNewIsPositive"> (Optional) If true then add condition to the parameter. </param>
    Public Sub AddParameterPresentCondition(objControlState As Object, lstParamName As String(), Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterPresentNames(lstParamName.ToString(), bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub


    ''' <summary> Add condition name to the function.
    ''' </summary>
    ''' <param name="objControlState"> The parameter that control the state of the object. </param>
    ''' <param name="strFunctionName"> The parameter's function. </param>
    ''' <param name="bNewIsPositive"> (Optional) If true then add condition name to the function. </param>
    Public Sub AddFunctionNamesCondition(objControlState As Object, strFunctionName As String, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetFunctionName(strFunctionName, bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    ''' <summary> Add condition to the R function is a R codes.
    ''' </summary>
    ''' <param name="objControlState"> The parameter that control the state of the object. </param>
    ''' <param name="bNewIsPositive"> (Optional) If true then add condition name to the function. </param>
    Public Sub AddRCodeIsRFunctionCondition(objControlState As Object, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetRCodeIsRFunction(bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    ''' <summary> Add condition name to the function.
    ''' </summary>
    ''' <param name="objControlState"> The parameter that control the state of the object. </param>
    ''' <param name="lstFunctionNames"> The parameter's function list. </param>
    ''' <param name="bNewIsPositive"> (Optional) If true then add condition name to the function. </param>
    Public Sub AddFunctionNamesCondition(objControlState As Object, lstFunctionNames As String(), Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetFunctionNamesMultiple(lstFunctionNames.ToList(), bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    ''' <summary> dd condition to the parameter is string.
    ''' Set the parameter's name to <paramref name="strParameterName"/>. </summary>
    ''' <param name="objControlState"> The parameter control the object in the R syntax. </param>
    ''' <param name="strParameterName"> The parameter's name. </param>
    ''' <param name="bNewIsPositive"> The relative position the object in the R syntax. </param>
    Public Sub AddParameterIsStringCondition(objControlState As Object, strParameterName As String, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterType(strType:="string", strParamName:=strParameterName, bNewIsPositive:=bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub


    ''' <summary> Add a condition to the parameter is the R function.
    ''' Sets parameter's name to <paramref name="strParameterName"/>.
    ''' </summary>
    ''' <param name="objControlState"> The parameter control the object in the R codes.</param>
    ''' <param name="strParameterName"> Name of the parameter. </param>
    ''' <param name="bNewIsPositive"> (Optional) The relative position the object in the R syntax. </param>
    Public Sub AddParameterIsRFunctionCondition(objControlState As Object, strParameterName As String, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterType(strType:="RFunction", strParamName:=strParameterName, bNewIsPositive:=bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub


    ''' <summary> Add a condition to the parameter is the R opertor.
    ''' Sets parameter's name to <paramref name="strParameterName"/>.
    ''' </summary>
    ''' <param name="objControlState"> The parameter control the object in the R codes.</param>
    ''' <param name="strParameterName"> Name of the parameter. </param>
    ''' <param name="bNewIsPositive"> (Optional) The relative position the object in the R syntax. </param>
    Public Sub AddParameterIsROperatorCondition(objControlState As Object, strParameterName As String, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterType(strType:="ROperator", strParamName:=strParameterName, bNewIsPositive:=bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub


    ''' <summary>  Add the condition to the parameter value and function names.
    ''' Sets parameter's name to <paramref name="strParameterName"/> and function'name to <paramref name="strFunctionName"/>.</summary>
    ''' <param name="objControlState"> The parameter control the object in the R codes. </param>
    ''' <param name="strParameterName"> Name of the parameter. </param>
    ''' <param name="strFunctionName"> Name of the function. </param>
    ''' <param name="bNewIsPositive"> (Optional) The relative position the object in the R syntax. </param>
    Public Sub AddParameterValueFunctionNamesCondition(objControlState As Object, strParameterName As String, strFunctionName As String, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterValuesRFunctionNames(strParamName:=strParameterName, strRCodeNames:=strFunctionName, bNewIsPositive:=bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub


    ''' <summary> Add a condition to the parameter value and function name of the R codes.
    ''' Sets parameter's name to <paramref name="strParameterName"/> and function's name to <paramref name="strFunctionNames"/>.</summary>
    ''' 
    ''' <param name="objControlState"> The parameter control the object in the R codes. </param>
    ''' <param name="strParameterName"> Name of the parameter. </param>
    ''' <param name="strFunctionNames"> Name of the function. </param>
    ''' <param name="bNewIsPositive">  (Optional) The relative position the object in the R codes. </param>
    Public Sub AddParameterValueFunctionNamesCondition(objControlState As Object, strParameterName As String, strFunctionNames As String(), Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetParameterValuesRFunctionNames(strParamName:=strParameterName, lstRCodeNames:=strFunctionNames.ToList(), bNewIsPositive:=bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub


    ''' <summary> Add a conditon to the R syntax contains the function name.
    ''' Set the function's name  to <paramref name="strFunctionNames"/>.</summary>
    '''
    ''' <param name="objControlState"> The parameter control the object in the R syntax. </param>
    ''' <param name="strFunctionNames"> Name of the function. </param>
    ''' <param name="bNewIsPositive"> The relative position the object in the R syntax. </param>
    Public Sub AddRSyntaxContainsFunctionNamesCondition(objControlState As Object, strFunctionNames As String(), Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetRSyntaxFunctionNamesMultiple(strFunctionNames.ToList(), bNewIsPositive:=bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub

    ''' <summary> Add a condition to the code contain the R syntax. </summary>
    ''' <param name="objControlState"> The parameter control the R state. </param>
    ''' <param name="bNewIsPositive"> The relative position the object in the R syntax. </param>
    Public Sub AddRSyntaxContainCodeCondition(objControlState As Object, Optional bNewIsPositive As Boolean = True)
        Dim clsTempCond As New Condition

        clsTempCond.SetRSyntaxContainsCode(bNewIsPositive:=bNewIsPositive)
        AddCondition(objControlState, clsTempCond)
    End Sub


    ''' <summary> Set visible a control. </summary>
    ''' <param name="bVisible"> If true then set a control visible property. </param>
    Public Sub SetVisible(bVisible As Boolean)
        'TODO: check how this should behave with linked group boxes
        If Not SetLinkedDisplayControlVisibilityAndReturnContainsGroupBox(bVisible) Then
            Visible = bVisible
        End If

        bIsVisible = bVisible

    End Sub

    ''' <summary> Set to default state an object. </summary>
    ''' <param name="objState"> The object to set default. </param>
    Public Sub SetDefaultState(objState As Object)
        objDefaultState = objState
    End Sub


    ''' <summary> Set to default state an object. </summary>
    Protected Overridable Sub SetToDefaultState()
        SetToValue(objDefaultState)
    End Sub


    ''' <summary> This should be used very cautiously, only if you want to change the parameter name and keep all other properties the same. </summary>
    ''' <param name="strNewName"> The parameter's name. </param>
    ''' <param name="bClearConditions"> If true then clear the condition. </param>
    Public Overridable Sub ChangeParameterName(strNewName As String, Optional bClearConditions As Boolean = True)
        If clsParameter IsNot Nothing Then
            clsParameter.SetArgumentName(strNewName)
        End If
        If bClearConditions Then
            ClearConditions()
        End If
    End Sub

    ''' <summary> Clear the conditions. </summary>
    Public Sub ClearConditions()
        dctConditions.Clear()
    End Sub

    ''' <summary> Set the value of the parameter. </summary>
    ''' <param name="strNewValue"> The parameter's String value. </param>
    Public Sub SetParameterValue(strNewValue As String)
        If clsParameter IsNot Nothing Then
            clsParameter.SetArgumentValue(strNewValue)
        End If
    End Sub

    ''' <summary> Set the value of the parameter. </summary>
    ''' <param name="clsNewRCode"> The parameter's function. </param>
    Public Sub SetParameterValue(clsNewRCode As RCodeStructure)
        If clsParameter IsNot Nothing Then
            clsParameter.SetArgument(clsNewRCode)
        End If
    End Sub


    ''' <summary> Set the value to Ignore.  </summary>
    ''' <param name="strValues"> The parameter's String value. </param>
    Public Sub SetValuesToIgnore(strValues() As String)
        strValuesToIgnore = strValues
    End Sub

    ''' <summary> Adds/updates a command-parameter pair to/in the control’s lists:
    ''' <list type="bullet">
    ''' <item><description> If the specified pair number is -1 (the default) or is the index of the next available list element, then the new pair is added to the list. </description></item>
    ''' <item><description> If the specified pair number already exists in the list, then that pair is updated with the new values. </description></item>
    ''' <item><description> If the pair number is greater than the number of list elements, then throws a developer error </description></item>
    ''' </list>
    ''' </summary>
    ''' <param name="clsNewRCode"> The new R code. </param>
    ''' <param name="clsNewRParameter"> The new R parameter. </param>
    ''' <param name="iAdditionalPairNo"> (optional) The parameter's position in relation to the associated R command's other
    '''                                         parameters.</param>
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


    ''' <summary> Update all the parameters in the R script.
    '''In general this should not be overrided. Only for controls which use parameters in very different way e.g. ucrSave
    ''' </summary>
    Protected Overridable Sub UpdateAllParameters()
        For i As Integer = 0 To lstAllRParameters.Count - 1
            UpdateParameter(lstAllRParameters(i))
        Next
    End Sub

    ''' <summary> Update the parameter in the R script. </summary>
    ''' <param name="clsTempParam"> The temporary parameter's value. </param>
    Public Overridable Sub UpdateParameter(clsTempParam As RParameter)
        If GetValueToSet() IsNot Nothing Then
            clsTempParam.SetArgumentValue(GetValueToSet().ToString())
        End If
    End Sub


    ''' <summary> Set the parameter's name in the R script if needed.  </summary>
    ''' <param name="bInclude"> If true include name of the parameter in the R script. </param>
    Public Sub SetParameterIncludeArgumentName(bInclude As Boolean)
        If clsParameter IsNot Nothing Then
            clsParameter.bIncludeArgumentName = bInclude
        End If
    End Sub


    ''' <summary> Set the postion of the parameter in the parameter set. </summary>
    ''' <param name="iPosition"> Index parameter's position. </param>
    Public Sub SetParameterPosition(iPosition As Integer)
        If clsParameter IsNot Nothing Then
            clsParameter.Position = iPosition
        End If
    End Sub

    ''' <summary> List of all the Parameters. </summary>
    ''' <returns> List all Parameters. </returns>
    Private Property clsParameter As RParameter
        Get
            Return lstAllRParameters(0)
        End Get
        Set(bNewRParameter As RParameter)
            'RemoveParameterFromRCode()
            lstAllRParameters(0) = bNewRParameter
        End Set
    End Property

    ''' <summary> List of all the R codes. </summary>
    ''' <returns> List all R codes</returns>
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

    ''' <summary> Clear code and parameters. </summary>
    Public Overridable Sub ClearCodeAndParameters()
        'Shouldn't this be removing them properly by removing the parameters from the functions first?
        lstAllRCodes = New List(Of RCodeStructure)
        lstAllRParameters = New List(Of RParameter)
        'Ensures there is always something at index 0
        lstAllRCodes.Add(Nothing)
        lstAllRParameters.Add(Nothing)
        UpdateControl()
    End Sub

    ''' <summary> Add/Remove parameter in the R code.
    ''' </summary>
    ''' <param name="bNew"> If true then Add parameter otherwise Remove. </param>
    Public Overridable Sub SetAddRemoveParameter(bNew As Boolean)
        bAddRemoveParameter = bNew
    End Sub
End Class
