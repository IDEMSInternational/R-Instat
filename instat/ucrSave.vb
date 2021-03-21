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
''' <summary>   This control allows the user to specify how an object should be saved. 
'''             <para>
'''             This control can save the following types of objects: 'column', 'dataframe', 
'''             'graph', model', 'surv', 'table'.
'''             The user can enter/update the name of the saved object via a text box or combo box.
'''             A combo box may be used to display a list of possible save names (e.g. the existing 
'''             column names).
'''             An optional check box allows the text/combo box to be made visible or not visible.
'''             </para><para>
'''             For columns, the control provides additional functionality.
'''             There is a 'position' button that when clicked opens a sub-dialog.
'''             This allows the user to specify the position of the saved column in relation to the other columns.
'''             This can be the first column, the last column, or before/after an existing named column.
'''             </para></summary>
Public Class ucrSave
    'TODO SJL 06/07/20 If you refactor this class then please see the suggestions from @Patowhiz in PR #5794
    ' 

    ''' <summary>   True if the control has not yet loaded. </summary>
    Public bFirstLoad As Boolean = True

    ''' <summary>   True to show, false to hide the check box. <para>
    '''             Note: This control can either display a check box or a label but cannot 
    '''             display both. </para><para>
    '''             If a checkbox is displayed then saving is optional (checked means save, 
    '''             unchecked means don't save).</para><para>
    '''             If a label is displayed then saving is mandatory (i.e. the dialog is forcing 
    '''             the user to save the object).</para><para>
    '''             Normally the decision to display a check box or label is only made once when 
    '''             the dialog loads, and then does not change. 
    '''             However, in rare cases it may change after loading. 
    '''             For example, radio buttons may require the control to switch between different 
    '''             states.</para>
    '''             </summary>
    Private bShowCheckBox As Boolean = True
    ''' <summary>   True to show, false to hide the label. </summary>
    '''             (mutually exclusive with bShowCheckBox, see note above) 
    Private bShowLabel As Boolean = False 'TODO SJL 04/06/20 always set to the opposite of bShowCheckBox. Remove bShowLabel? May be an edge case (not yet implemented) want save/combo box with neither label or check box (e.g. if you want a separate label somewhere else in the dialog)
    ''' <summary>   Type of object saved by this control 
    '''             (valid values are: 'column', 'dataframe', 'graph', model', 'surv', 'table') 
    '''             </summary>
    Private strSaveType As String = "column"
    ''' <summary>   Prefix used for the default name displayed in the text/combo box </summary>
    Private strPrefix As String
    ''' <summary>   True if this control has a combo box rather than a text box.<para>
    '''             Note: This control can have either a combo box or a text box but cannot have 
    '''             both. </para><para>
    '''             A text box is normally used when pre-defined names aren’t of any interest to 
    '''             the user. </para><para>
    '''             A combo box is normally used when the user needs to see previously defined 
    '''             names (e.g. existing column names). The user may then deliberately save to an 
    '''             existing name (and overwirte that object), or select a new name (and save to 
    '''             a new object).
    '''             The user may wish to overwrite an existing column if they are doing a series 
    '''             of intermediate steps. They may choose to overwrite the previous intermediate 
    '''             column with the next step of their analysis.</para>
    '''             </summary>
    Private bIsComboBox As Boolean = True
    ''' <summary>   If true then only show the text/combo box when the check box is checked. </summary>
    Private bHideIfUnchecked As Boolean = True 'TODO SJL 15/05/20 Always true and is never set to false. Remove?
    ''' <summary>   The data frame selector linked to the text/combo box. 
    '''             This selector is used to set the data frame used by the R code's column 
    '''             position and 'assign to' variables. </summary>
    Private WithEvents ucrDataFrameSelector As ucrDataFrame
    ''' <summary>   If true then the R parameter 'use_col_name_as_prefix' is set to true,
    '''             else the parameter is set to false.
    '''             Only used when this control is saving a column. </summary>
    Private bAssignToIsPrefix As Boolean = False
    ''' <summary>   If true then don't assign to a specific named column. If false then assign to 
    '''             a named column (i.e. the R "col_name" parameter needs to be set). 
    '''             </summary>
    Private bAssignToColumnWithoutNames As Boolean = False
    ''' <summary>   If true then set the R "before" parameter to true, else set it to false.
    '''             Only used when this control is saving a column.
    '''             </summary>
    Private bInsertColumnBefore As Boolean = False
    ''' <summary>   If true then a list of data frames is assigned (i.e. the R "data_names" 
    '''             parameter needs to be set).
    '''             Only used when this control is saving a data frame.
    '''             </summary>
    Public bDataFrameList As Boolean = False
    ''' <summary>   The names of the new data frames (i.e. the data frame names associated with
    '''             the R "data_names" parameter). This has the format "c(data1, data2, data3)".
    '''             Only used when this control is saving a data frame and 'bDataFrameList' is true.
    '''             </summary>
    Public strDataFrameNames As String
    ''' <summary>   The text to use for the save assignment when the check box is unchecked
    '''             (if the check box is checked then use the text from the text/combo box instead) 
    '''             </summary>
    Private strAssignToIfUnchecked As String = ""
    ''' <summary>   The data frame used in the assignment. 
    '''             Only used if the data frame selector is not specified. 
    '''             </summary>
    Private strGlobalDataName As String = ""
    ''' <summary>   The receiver linked to this control. This receiver allows the user to specify 
    '''             the column name.
    '''             Only used when this control is saving a column. </summary>
    Private ucrLinkedReceiver As ucrReceiver
    ''' <summary>   Function containing the parameters ('before' and 'adjacent_column') and their 
    '''             respective values. These parameters are only used when the save object is a 
    '''             column.
    '''             In this case it is used to specify the position of the new column in the data 
    '''             frame (start, end or before/after a specified column).
    '''             <para>
    '''             Note that only the parameters of this function are set and referenced. 
    '''             No other RFunction data members are used.
    '''             </para></summary>
    Private clsColPosFunction As New RFunction
    'TODO SJL 16/06/20 This RFunction only seems to be used for local storage of parameters 
    '                  (i.e. just a list of parameters). These parameters are never part of the 
    '                  main function. 
    '                  The parameters are created in LinkedReceiverControlValueChanged and 
    '                  converted to booleans in UpdateColumnPositionVariables. 
    '                  The booleans are converted back into parameters in 'RCodeStructure.ToScript'.
    '                  Normally, these would be stored as parameters in the actual function that 
    '                  adds columns. 
    '                  Or the parameters could be explicitly stored as a list of parameters.
    '                  Or just the booleans could be stored.
    ''' <summary>   Width of the combo box. </summary>
    Private iComboBoxWidth As Integer
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Executes whenever this control loads.
    '''             If this is the first time that the control has loaded then initialises the 
    '''             control and sets it to the default state.
    '''             If the control has already been loaded then this function does nothing.
    '''             </summary>
    '''
    ''' <param name="sender">   Source of the event. </param>
    ''' <param name="e">        Event information. </param>
    '''--------------------------------------------------------------------------------------------
    Private Sub ucrSave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'if this is the first time the control has loaded
        If bFirstLoad Then
            'initialise the control and set the control to the default state
            InitialiseControl()
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Initialises the control. 
    '''             <para>
    '''             Sets flags to show that check box and the text/combo box can be set from the 
    '''             control’s R code.
    '''             Also sets flags to show that the control’s R code should be updated whenever the 
    '''             control’s value changes.</para>
    ''' </summary>
    '''--------------------------------------------------------------------------------------------
    Private Sub InitialiseControl()
        bUpdateRCodeFromControl = True
        ucrInputComboSave.SetValidationTypeAsRVariable()
        ucrInputTextSave.SetValidationTypeAsRVariable()
        ucrChkSave.bIsActiveRControl = False
        ucrInputComboSave.bIsActiveRControl = False
        ucrInputTextSave.bIsActiveRControl = False
        ucrInputComboSave.bUpdateRCodeFromControl = True
        ucrInputTextSave.bUpdateRCodeFromControl = True
        iComboBoxWidth = ucrInputComboSave.Size.Width
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Resets the control to its default state. </summary>
    '''--------------------------------------------------------------------------------------------
    Private Sub SetDefaults()
        ucrInputTextSave.Reset()
        ucrInputComboSave.Reset()
        SetSaveType(strSaveType)
        LabelOrCheckboxSettings()
        UpdateRCode()
        'update the variables used for column position
        UpdateColumnPositionVariables(True)
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the label to <paramref name="strText"/> and sets the child 
    '''             controls to the correct enabled/visible state depending on this control's 
    '''             current state.
    '''             If the new label overlaps with the combo box then reduces the width of the 
    '''             combo box and text box.
    ''' </summary>
    '''
    ''' <param name="strText">  The label text. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetLabelText(strText As String)
        Dim iTemp As Integer
        lblSaveText.Text = strText
        bShowLabel = True
        bShowCheckBox = False
        LabelOrCheckboxSettings()
        'Do for both in case text/combo not set yet, or will change at run time
        iTemp = lblSaveText.Location.X + lblSaveText.Size.Width - ucrInputComboSave.Location.X
        If iTemp > 0 Then
            ucrInputComboSave.Width = iComboBoxWidth - iTemp
            ucrInputTextSave.Width = ucrInputComboSave.Width
        End If
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the check box text to <paramref name="strText"/> and sets the child
    '''             controls to the correct enabled/visible state depending on this control's
    '''             current state.
    '''             If displaying <paramref name="strText"/> exceeds the maximum length allowed 
    '''             then reduces the width of the window displaying the text. </summary>
    '''
    ''' <param name="strText">  The check box text. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetCheckBoxText(strText As String)
        Dim g As Graphics = ucrChkSave.chkCheck.CreateGraphics
        Dim s As SizeF
        ucrChkSave.SetText(strText)
        bShowLabel = False
        bShowCheckBox = True
        LabelOrCheckboxSettings()
        ' "[box]" allows for a sufficient amount of space for the box of the checkbox
        s = g.MeasureString(ucrChkSave.chkCheck.Text & "[box]", ucrChkSave.chkCheck.Font)
        ucrChkSave.Width = Math.Max(100, s.Width)
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Specifies that this control has a combo box rather than a text box (a save 
    '''             control has either a combo box or a text box but cannot have both).
    '''             </summary>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetIsComboBox()
        bIsComboBox = True
        If bShowCheckBox Then
            CheckedChanged()
        Else
            ucrInputComboSave.Visible = True
            ucrInputTextSave.Visible = False
        End If
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Specifies that this control has a text box rather than a combo box (a save 
    '''             control has either a combo box or a text box but cannot have both).
    '''             </summary>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetIsTextBox()
        bIsComboBox = False
        If bShowCheckBox Then
            CheckedChanged()
        Else
            ucrInputComboSave.Visible = False
            ucrInputTextSave.Visible = True
        End If
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the prefix for the text/combo box value to
    '''             <paramref name="strNewPrefix"/>. If <paramref name="strNewPrefix"/> is not an
    '''             empty string then also sets the default value associated with the text/combo 
    '''             box.</summary>
    '''
    ''' <param name="strNewPrefix"> The new prefix for the text/combo box value. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetPrefix(strNewPrefix As String)
        strPrefix = strNewPrefix
        ucrInputComboSave.SetPrefix(strPrefix)
        ucrInputTextSave.SetPrefix(strPrefix)
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   TODO SJL 07/05/20 Not used, remove? </summary>
    '''
    ''' <param name="bShowButton">  True to show, false to hide the button. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub showButtonPosition(bShowButton As Boolean)
        btnColumnPosition.Visible = bShowButton
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the text to use for the save assignment when the check box is unchecked
    '''             (if the check box is checked then the text from the text/combo box is used 
    '''             instead).</summary>
    '''
    ''' <param name="strTemp">  The text to use for the the save assignment when the check box is 
    '''                         unchecked. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetAssignToIfUncheckedValue(strTemp As String)
        strAssignToIfUnchecked = strTemp
        UpdateRCode()
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the 'assign to' configuration. </summary>
    '''
    ''' <param name="bTempAssignToIsPrefix">            (Optional) If true then the R parameter 
    '''                                                 'use_col_name_as_prefix' is set to true,
    '''                                                 else the parameter is set to false. 
    '''                                                 Only used when this control is saving a column.</param>
    ''' <param name="bTempAssignToColumnWithoutNames">  (Optional) If true then don't assign to a 
    '''                                                 specific named column. If false then assign to
    '''                                                 a named column (i.e. the R "col_name" parameter 
    '''                                                 needs to be set). </param>
    ''' <param name="bTempInsertColumnBefore">          (Optional) If true then set the R 'before' 
    '''                                                 parameter to true, else set it to false.
    '''                                                 Only used when this control is saving a column. </param>
    ''' <param name="bTempDataFrameList">               (Optional) If true then a list of data 
    '''                                                 frames is assigned (i.e. the R "data_names"
    '''                                                 parameter needs to be set).
    '''                                                 Only used when this control is saving a 
    '''                                                 data frame.</param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetAssignToBooleans(Optional bTempAssignToIsPrefix As Boolean = False, Optional bTempAssignToColumnWithoutNames As Boolean = False, Optional bTempInsertColumnBefore As Boolean = False, Optional bTempDataFrameList As Boolean = False)
        bAssignToIsPrefix = bTempAssignToIsPrefix
        bAssignToColumnWithoutNames = bTempAssignToColumnWithoutNames
        bInsertColumnBefore = bTempInsertColumnBefore
        bDataFrameList = bTempDataFrameList
        UpdateRCode()
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>  The names of the new data frames (i.e. the data frame names associated with
    '''            the R "data_names" parameter).
    '''            Only used when this control is saving a data frame and 'bDataFrameList' is true.
    '''            </summary>
    '''
    ''' <param name="strTempDataFrameNames">    The names of the new data frames formatted as: 
    '''                                         "c(data1, data2, data3)".</param>
    '''-------------------------------------------------------------------------------------------- 
    Public Sub SetDataFrameNames(strTempDataFrameNames As String)
        strDataFrameNames = strTempDataFrameNames
        UpdateRCode()
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>  Sets the names of the new data frames (i.e. the data frame names associated with
    '''            the R "data_names" parameter).
    '''            Converts <paramref name="lstTempDataFrameNames"/> into a string with the format
    '''            "c(data1, data2, data3)".</summary>
    '''
    ''' <param name="lstTempDataFrameNames">    List of data frame names. </param>
    '''-------------------------------------------------------------------------------------------- 
    Public Sub SetDataFrameNames(lstTempDataFrameNames As List(Of String))
        If lstTempDataFrameNames.Count = 1 Then
            SetDataFrameNames(lstTempDataFrameNames(0))
        Else
            For i As Integer = 0 To lstTempDataFrameNames.Count - 1
                lstTempDataFrameNames(i) = Chr(34) & frmMain.clsRLink.MakeValidText(lstTempDataFrameNames(i)) & Chr(34)
            Next
            SetDataFrameNames("c(" & String.Join(", ", lstTempDataFrameNames) & ")")
        End If
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the child controls to the correct enabled/visible state depending on 
    '''             this control's current state.
    '''             </summary>
    '''--------------------------------------------------------------------------------------------
    Private Sub LabelOrCheckboxSettings()
        If bShowLabel Then
            ucrInputComboSave.Enabled = True
            ucrInputTextSave.Enabled = True
            lblSaveText.Visible = True
            ucrChkSave.Visible = False
            If bIsComboBox Then
                ucrInputComboSave.Visible = True
            Else
                ucrInputTextSave.Visible = True
            End If
        ElseIf bShowCheckBox Then
            lblSaveText.Visible = False
            ucrChkSave.Visible = True
            CheckedChanged()
        Else 'TODO SJL This check should never be reached
            ucrInputComboSave.Enabled = True
            ucrInputTextSave.Enabled = True
            lblSaveText.Visible = False
            ucrChkSave.Visible = False
        End If
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets save type to <paramref name="strType"/>. Valid values are: 
    '''             "column", "dataframe", "graph", "model", "surv" or "table".
    '''             Sets the combobox and textbox to be the same type.
    '''             If type is "column" then makes the 'position' button visible, else makes it not
    '''             visible. This is because the position functionality is currently only 
    '''             implemented for columns.
    '''             (The position functionality allows the user to specifiy if the new object will 
    '''             be placed at the start end, or before/after an adjacent object.)
    '''             </summary>
    '''
    ''' <param name="strType">  The type of object saved by this control. Valid values are: 
    '''                         "column", "dataframe", "graph", "model", "surv" or "table". 
    '''                         An invalid value throws a developer error.</param>
    '''--------------------------------------------------------------------------------------------
    Private Sub SetSaveType(strType As String)
        strSaveType = strType
        Select Case strSaveType
            Case "column"
                ucrInputComboSave.SetDefaultTypeAsColumn()
                ucrInputComboSave.SetItemsTypeAsColumns()
                ucrInputTextSave.SetDefaultTypeAsColumn()
                btnColumnPosition.Visible = True
            Case "dataframe"
                ucrInputComboSave.SetDefaultTypeAsDataFrame()
                ucrInputComboSave.SetItemsTypeAsDataFrames()
                ucrInputTextSave.SetDefaultTypeAsDataFrame()
                btnColumnPosition.Visible = False
            Case "graph"
                ucrInputComboSave.SetDefaultTypeAsGraph()
                ucrInputComboSave.SetItemsTypeAsGraphs()
                ucrInputTextSave.SetDefaultTypeAsGraph()
                btnColumnPosition.Visible = False
            Case "model"
                ucrInputComboSave.SetDefaultTypeAsModel()
                ucrInputComboSave.SetItemsTypeAsModels()
                ucrInputTextSave.SetDefaultTypeAsModel()
                btnColumnPosition.Visible = False
            Case "surv"
                ucrInputComboSave.SetDefaultTypeAsSurv()
                ucrInputComboSave.SetItemsTypeAsSurv()
                ucrInputTextSave.SetDefaultTypeAsSurv()
                btnColumnPosition.Visible = False
            Case "table"
                ucrInputComboSave.SetDefaultTypeAsTable()
                ucrInputComboSave.SetItemsTypeAsTables()
                ucrInputTextSave.SetDefaultTypeAsTable()
                btnColumnPosition.Visible = False
            Case Else
                MsgBox("Developer error: unrecognised save type: " & strType)
        End Select
    End Sub
    ''' <summary>   Sets save type as column. </summary>
    Public Sub SetSaveTypeAsColumn()
        SetSaveType("column")
    End Sub
    ''' <summary>   Sets save type as data frame. </summary>
    Public Sub SetSaveTypeAsDataFrame()
        SetSaveType("dataframe")
    End Sub
    ''' <summary>   Sets save type as graph. </summary>
    Public Sub SetSaveTypeAsGraph()
        SetSaveType("graph")
    End Sub
    ''' <summary>   Sets save type as model. </summary>
    Public Sub SetSaveTypeAsModel()
        SetSaveType("model")
    End Sub
    ''' <summary>   Sets save type as surv. </summary>
    Public Sub SetSaveTypeAsSurv()
        SetSaveType("surv")
    End Sub
    ''' <summary>   Sets save type as table. </summary>
    Public Sub SetSaveTypeAsTable()
        SetSaveType("table")
    End Sub
    ''' <summary>   Resets this control to its default values.  </summary>
    Public Sub Reset()
        SetDefaults()
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the data frame selector to <paramref name="ucrNewDataFrameSelector"/>. 
    '''             Also links the selector to the combo box and text box.
    '''             </summary>
    '''
    ''' <param name="ucrNewDataFrameSelector">  The new data frame selector. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetDataFrameSelector(ucrNewDataFrameSelector As ucrDataFrame)
        ucrDataFrameSelector = ucrNewDataFrameSelector
        ucrInputComboSave.SetDataFrameSelector(ucrNewDataFrameSelector)
        ucrInputTextSave.SetDataFrameSelector(ucrNewDataFrameSelector)
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Handles event triggered when the state of the check box changes. </summary>
    '''
    ''' <param name="ucrChangedControl">    Not used. </param>
    '''--------------------------------------------------------------------------------------------
    Private Sub ucrChkSave_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSave.ControlValueChanged
        If bShowCheckBox Then
            CheckedChanged()
        End If
        OnControlValueChanged()
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the enabled state, visibility and contents of the text/combo box. This is 
    '''             determined by the state of the check box and other conditions:
    '''             <para>
    '''             If the assignment part of the script is defined, the check box is checked, and
    '''             the user hasn't entered their own text, then sets the default text for the 
    '''             text/combo box.
    '''             </para><para>
    '''             If the text/combo box should only be displayed when the check box is checked, 
    '''             then makes the text/combo box visible (or not visible) accordingly.
    '''             </para>
    '''             </summary>
    '''--------------------------------------------------------------------------------------------
    Private Sub CheckedChanged()
        ucrInputTextSave.Enabled = ucrChkSave.Checked
        ucrInputComboSave.Enabled = ucrChkSave.Checked
        ucrInputTextSave.Visible = False
        ucrInputComboSave.Visible = False
        btnColumnPosition.Visible = False

        'always hide position button if save type is not a column
        If strSaveType = "column" Then
            btnColumnPosition.Visible = ucrChkSave.Checked
        End If

        If strAssignToIfUnchecked <> "" Then
            If ucrChkSave.Checked Then
                If bIsComboBox Then
                    If Not ucrInputComboSave.bUserTyped Then
                        ucrInputComboSave.SetDefaultName()
                    End If
                Else
                    If Not ucrInputTextSave.bUserTyped Then
                        ucrInputTextSave.SetDefaultName()
                    End If
                End If
            End If
        End If
        If bHideIfUnchecked Then
            If bIsComboBox Then
                ucrInputComboSave.Visible = ucrChkSave.Checked
            Else
                ucrInputTextSave.Visible = ucrChkSave.Checked
            End If
        Else
            ucrInputComboSave.Visible = bIsComboBox
            ucrInputTextSave.Visible = Not bIsComboBox
        End If
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Handles event triggered when the state of the text/combo box or selector 
    '''             changes. </summary>
    '''
    ''' <param name="ucrChangedControl">    The ucr changed control. </param>
    '''--------------------------------------------------------------------------------------------
    Private Sub ucrInputControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboSave.ControlValueChanged, ucrInputTextSave.ControlValueChanged, ucrDataFrameSelector.ControlValueChanged
        OnControlValueChanged()
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Updates the control's 'assign to' variables, linked controls and column 
    '''             position variables. If <paramref name="bReset"/> is true then resets the linked 
    '''             controls and column position variables. </summary>
    '''
    ''' <param name="bReset">   (Optional) if true then reset the linked controls and column 
    '''                         position variables. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overrides Sub UpdateRCode(Optional bReset As Boolean = False)
        UpdateAssignTo()
        'the control's R code has changed so ensure that the linked controls stay consistent
        UpdateLinkedControls(bReset)
        'update the variables used for column position
        UpdateColumnPositionVariables(bReset)
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Updates the control's 'assign to' variables and column position variables. 
    '''             </summary>
    '''--------------------------------------------------------------------------------------------
    Protected Overrides Sub UpdateAllParameters()
        UpdateAssignTo()
        'update the variables used for column position
        UpdateColumnPositionVariables()
        ' TODO SJL 16/06/20 Name ‘UpdateAllParameters’ is misleading, parent function does what the name says, this function doesn’t. Ask Danny's advice?
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   TODO SJL 13/05/20 Same as parent function - remove?. </summary>
    '''
    ''' <param name="bReset">   (Optional) True to reset. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overrides Sub UpdateLinkedControls(Optional bReset As Boolean = False)
        MyBase.UpdateLinkedControls(bReset)
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   If <paramref name="bRemove"/> is true, or there is currently no save name 
    '''             specified, then removes all the current assignments from the control's R code.
    '''             <para>
    '''             If <paramref name="bRemove"/> is false then sets the R code 'assign to' 
    '''             variables. If the output from the R command needs to be assigned, then these 
    '''             variables help create the part of the script to the left of the assignment 
    '''             operator ('&lt;-').These variables include things such as the name of the 
    '''             object to assign to, and how to insert into columns.
    '''             </para></summary>
    '''
    ''' <param name="bRemove">  (Optional) If true then removes all the current assignments from 
    '''                         the control's R code. 
    '''                         If false then sets the R code 'assign to' variables.</param>
    '''--------------------------------------------------------------------------------------------
    Private Sub UpdateAssignTo(Optional bRemove As Boolean = False)
        Dim strSaveName As String
        Dim strDataName As String = ""
        Dim clsTempCode As RCodeStructure
        For i As Integer = 0 To lstAllRCodes.Count - 1
            clsTempCode = lstAllRCodes(i)
            If clsTempCode IsNot Nothing Then
                If bRemove Then
                    clsTempCode.RemoveAssignTo()
                Else
                    If ucrDataFrameSelector IsNot Nothing Then
                        strDataName = ucrDataFrameSelector.cboAvailableDataFrames.Text
                    Else
                        strDataName = strGlobalDataName
                    End If
                    If bShowCheckBox AndAlso Not ucrChkSave.Checked Then
                        strSaveName = strAssignToIfUnchecked
                    Else
                        strSaveName = GetText()
                    End If
                    If strSaveName <> "" Then
                        Select Case strSaveType
                            Case "column"
                                clsTempCode.SetAssignTo(strTemp:=strSaveName, strTempDataframe:=strDataName, strTempColumn:=strSaveName, bAssignToIsPrefix:=bAssignToIsPrefix, bAssignToColumnWithoutNames:=bAssignToColumnWithoutNames, bInsertColumnBefore:=bInsertColumnBefore)
                            Case "dataframe"
                                clsTempCode.SetAssignTo(strTemp:=strSaveName, strTempDataframe:=strSaveName, bAssignToIsPrefix:=bAssignToIsPrefix, bDataFrameList:=bDataFrameList, strDataFrameNames:=strDataFrameNames)
                            Case "graph"
                                clsTempCode.SetAssignTo(strTemp:=strSaveName, strTempDataframe:=strDataName, strTempGraph:=strSaveName, bAssignToIsPrefix:=bAssignToIsPrefix)
                            Case "model"
                                clsTempCode.SetAssignTo(strTemp:=strSaveName, strTempDataframe:=strDataName, strTempModel:=strSaveName, bAssignToIsPrefix:=bAssignToIsPrefix)
                            Case "table"
                                clsTempCode.SetAssignTo(strTemp:=strSaveName, strTempDataframe:=strDataName, strTempTable:=strSaveName, bAssignToIsPrefix:=bAssignToIsPrefix)
                            Case "surv"
                                clsTempCode.SetAssignTo(strTemp:=strSaveName, strTempDataframe:=strDataName, strTempSurv:=strSaveName, bAssignToIsPrefix:=bAssignToIsPrefix)
                        End Select
                    Else
                        clsTempCode.RemoveAssignTo()
                    End If
                End If
            End If
        Next
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Handles event triggered when text/combo box contents changes. </summary>
    '''
    ''' <param name="ucrChangedControl">    Not used. </param>
    '''--------------------------------------------------------------------------------------------
    Private Sub ucrInputControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputComboSave.ControlContentsChanged, ucrInputTextSave.ControlContentsChanged, ucrChkSave.ControlContentsChanged
        OnControlContentsChanged()
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Updates this control, and the linked controls, based upon the assignment part of
    '''             the control's R code. This ensures that this control (and the linked controls) 
    '''             show the correct values when the control is displayed.
    '''             <para>
    '''             If the R code has an assignment part then sets the text/combo box to the R code 
    '''             assignment string. Else sets the combo/text box to an empty string.
    '''             </para><para>
    '''             If the R code has an assignment part that's different to the 'default' (in this 
    '''             case the assignment used if the check box is unchecked), then sets the 
    '''             check box to checked. Else sets the check box to unchecked.
    '''             </para>
    ''' </summary>
    '''
    ''' <param name="bReset">           (Optional) Not used. Only included to be consistent with 
    '''                                 overridden function. </param>
    ''' <param name="bCloneIfNeeded">   (Optional) Not used. Only included to be consistent with
    '''                                 overridden function. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overrides Sub UpdateControl(Optional bReset As Boolean = False, Optional bCloneIfNeeded As Boolean = False)
        Dim clsMainRCode As RCodeStructure
        clsMainRCode = GetRCode()
        If clsMainRCode IsNot Nothing Then
            If clsMainRCode.bToBeAssigned OrElse clsMainRCode.bIsAssigned Then
                If bIsComboBox Then
                    ucrInputComboSave.SetName(clsMainRCode.strAssignTo)
                    ucrInputTextSave.SetName("")
                Else
                    ucrInputTextSave.SetName(clsMainRCode.strAssignTo)
                    ucrInputComboSave.SetName("")
                End If
            Else
                ucrInputComboSave.SetName("")
                ucrInputTextSave.SetName("")
            End If
            If bShowCheckBox Then
                If GetText() = strAssignToIfUnchecked Then
                    ucrChkSave.Checked = False
                Else
                    ucrChkSave.Checked = (clsMainRCode.bToBeAssigned OrElse clsMainRCode.bIsAssigned)
                End If
            End If
            UpdateLinkedControls()
        End If
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns true if the name to save the object to is defined, else returns false. 
    '''             <para>
    '''             If this control has an unchecked check box then returns true.
    '''             If this control has a checked check box and the text/combo box contains 
    '''             text then returns true.
    '''             If this control doesn't have a check box, but the text/combo box does contain 
    '''             text, then returns true.
    '''             In all other cases, returns false
    '''             </para>
    '''             </summary>
    '''
    ''' <returns>   True if the name to save the object to is defined, else returns false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function IsComplete() As Boolean
        If bShowCheckBox Then
            Return ((ucrChkSave.Checked AndAlso GetText() <> "") OrElse Not ucrChkSave.Checked)
        Else
            Return GetText() <> ""
        End If
    End Function
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the text from the text/combo box. </summary>
    '''
    ''' <returns>   The text from the text/combo box. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetText() As String
        If bIsComboBox Then
            Return ucrInputComboSave.GetText()
        Else
            Return ucrInputTextSave.GetText()
        End If
    End Function
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   True if the user has entered text into the text/combo box, else false. </summary>
    '''
    ''' <value>     True if the user has entered text into the text/combo box, else false. </value>
    '''--------------------------------------------------------------------------------------------
    Public ReadOnly Property bUserTyped As Boolean
        Get
            If bIsComboBox Then
                Return ucrInputComboSave.bUserTyped
            Else
                Return ucrInputTextSave.bUserTyped
            End If
        End Get
    End Property
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the contents of the text/combo box to <paramref name="strName"/>.
    '''             </summary>
    '''
    ''' <param name="strName">  The new contents for the text/combo box. </param>
    ''' <param name="bSilent">  (Optional) If true, and this control has a combo box, then looks
    '''                         for <paramref name="strName"/> in the combox box list, and if found 
    '''                         stores the index. 
    '''                         If false then first validates <paramref name="strName"/> before
    '''                         assigning it to the text/combo box. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetName(strName As String, Optional bSilent As Boolean = False)
        'TODO SJL 23/06/20 Patowhiz - Another opinion from me. This a perfect example of a method name used "out of context". 
        ' The name is SetName() yet the function sets the contents of the control not the name of the control. 
        ' And when getting the contents of the control, we use GetText not GetName().
        If bIsComboBox Then
            ucrInputComboSave.SetName(strName, bSilent)
        Else
            ucrInputTextSave.SetName(strName, bSilent)
        End If
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns true if the R code can be updated.</summary>
    '''
    ''' <returns>   If the type of object to save is specified (e.g. column), the R code's output 
    '''             hasn't been assigned, and doesn't need to be assigned, then returns true. </returns>
    '''--------------------------------------------------------------------------------------------
    Protected Overrides Function CanUpdate() As Object
        'TODO SJL 15/05/20 
        '    - Should this function return boolean? The parent function in ucrCore has no return type! Is this good coding practice?
        '    - The parent function returns true if the control has a paremter that is not yet included in the R command. Why is this control different?
        '    - Is the condition for bToBeAssigned correct?
        Return ((Not GetRCode().bIsAssigned AndAlso Not GetRCode().bToBeAssigned) AndAlso strSaveType <> "")
    End Function
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   If <paramref name="bAdd"/> is true then sets the R code 'assign to'
    '''             variables. If the output from the R command needs to be assigned, then these
    '''             variables help create the part of the script to the left of the assignment
    '''             operator ('&lt;-').These variables include things such as the name of the
    '''             object to assign to, and how to insert into columns.
    '''             <para>
    '''              If <paramref name="bAdd"/> is false, or there is currently no save name
    '''             specified, then removes all the current assignments from the control's R code.
    '''             </para></summary>
    '''
    ''' <param name="bAdd">  If true then sets the R code 'assign to' variables. If false then 
    '''                      removes all the current assignments from the control's R code. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overrides Sub AddOrRemoveParameter(bAdd As Boolean)
        'TODO SJL 15/05/20 
        '   - The name is quite confusing. Rename?
        '   - If we made 'UpdateAssignTo' public then we could remove this function
        UpdateAssignTo(Not bAdd)
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Adds <paramref name="clsNewRCode"/> to the control's command-parameter 
    '''             lists (sets the corresponding parameter to 'nothing'):
    ''' <list type="bullet">
    '''     <item><description>
    '''             If the specified pair number is -1 (the default) or is the index of the next 
    '''             available list element, then <paramref name="clsNewRCode"/> is added to
    '''             the list.
    '''     </description></item><item><description>
    '''             If the specified pair number already exists in the list, then that pair is 
    '''             updated with <paramref name="clsNewRCode"/>.
    '''     </description></item><item><description>
    '''             If the pair number is greater than the number of list elements, then throws 
    '''             a developer error.
    '''     </description></item>
    ''' </list></summary>
    '''
    ''' <param name="clsNewRCode">          The R code to add/update to the control's 
    '''                                     command-parameter lists. </param>
    ''' <param name="iAdditionalPairNo">    (Optional) The position in the list to add/update 
    '''                                     <paramref name="clsNewRCode"/>. Must be less than or 
    '''                                     equal to the number of command-parameter pairs in the 
    '''                                     lists. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub AddAdditionalRCode(clsNewRCode As RCodeStructure, Optional iAdditionalPairNo As Integer = -1)
        'TODO SJL 16/06/20 This subroutine adds a command to the command-parameter pair list without a parameter! 
        '                  This is strange behaviour? I assume it's used in situations where 
        '                  commands are used for assignments but parameters not important. 
        '                  For dialog Like conversions dialog. Uses just 1 of a set of commands. 
        '                  These commands assign to but have no modifiable parameters. 
        '                  Normally manipulating parameters but in this case we only care about the 
        '                  assign to (because we're saving something). Ask Danny's advice?
        AddAdditionalCodeParameterPair(clsNewRCode, Nothing, iAdditionalPairNo)
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns true if the user has typed text into the text/combo box, else returns 
    '''             false.<para>
    '''             This function may be used to determine whether the default value should be used.
    '''             If the user has not typed anything into the text/combo box, then the default 
    '''             should be used.
    '''             Otherwise the user-entered value should be used. The default should only be 
    '''             used again if the user resets the dialog by clicking on the reset button.
    '''             </para></summary>
    '''
    ''' <returns>   True if the user has typed text into the text/combo box, else returns
    '''             false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function UserTyped() As Boolean
        ' TODO SJL 16/06/20 This function is not called. It could be that the dialogue boxes 
        '                   already know whether they are using a combo box or textbox and check 
        '                   this boolean directly instead of via this function. We should maybe 
        '                   check all cases of this and change the code to call this function 
        '                   instead because it is safer because there are some cases where it 
        '                   may change from a text box to a combo box dynamically after the 
        '                   control has been initialised. For example, in a complex climatic 
        '                   dialog such as summaries there may be an option to get a column back 
        '                   or a table or a graph. Depending on the type of object the dialogue 
        '                   may require either a combo box or a textbox.
        If bIsComboBox Then
            Return ucrInputComboSave.bUserTyped
        Else
            Return ucrInputTextSave.bUserTyped
        End If
    End Function
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the data frame used in the assignment, and updates the other R code 
    '''             'assign to' variables.
    '''             Only used if the data frame selector is not specified. </summary>
    '''
    ''' <param name="strNewGlobalDataName"> The data frame used in the assignment. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetGlobalDataName(strNewGlobalDataName As String)
        strGlobalDataName = strNewGlobalDataName
        UpdateAssignTo()
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Handles event triggered when the user clicks the 'position' button. 
    '''             Initialises and displays the column position dialog. </summary>
    '''
    ''' <param name="sender">   Not used. </param>
    ''' <param name="e">        Not used. </param>
    '''--------------------------------------------------------------------------------------------
    Private Sub btnColumnPosition_Click(sender As Object, e As EventArgs) Handles btnColumnPosition.Click
        Dim strDataName As String
        If ucrDataFrameSelector IsNot Nothing Then
            strDataName = ucrDataFrameSelector.cboAvailableDataFrames.Text
        Else
            strDataName = strGlobalDataName
        End If
        sdgSaveColumnPosition.SetUp(clsColPosFunction, strDataName)
        sdgSaveColumnPosition.ShowDialog()
        UpdateColumnPositionVariables()
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the receiver linked to this control. 
    '''             The receiver contains the column used for the calculation.
    '''             Normally the user wants the new column to be inserted before/after this column. 
    '''             <para>
    '''             The link is made here rather than in the sub-dialog because the sub-dialog 
    '''             should not have any specific knowledge about the calling parent. </para></summary>
    '''
    ''' <param name="ucrLinkedReceiver">    The receiver that specifies the column used for the 
    '''                                     calculation. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub setLinkedReceiver(ucrLinkedReceiver As ucrReceiver)
        Me.ucrLinkedReceiver = ucrLinkedReceiver
        AddHandler ucrLinkedReceiver.ControlValueChanged, AddressOf LinkedReceiverControlValueChanged
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Updates the control's R command's column position variables.
    '''             These variables specify the position of the new column in the data frame 
    '''             (start, end or before/after a specified column).<para>
    '''             This subroutine is called automatically when the receiver (specifying a column name) linked to 
    '''             clsColPosFunction changes. </para><para>
    '''             If the save object is not a column then this function does nothing.</para><para>
    '''             If the user has selected a column in the linked receiver, then sets the 
    '''             parameters to ensure that the new column is added directly after the receiver 
    '''             column. If the user has not specified a column in the receiver then the 
    '''             parameters are set to append the column after the final column. </para>
    '''             </summary>
    '''--------------------------------------------------------------------------------------------
    Private Sub LinkedReceiverControlValueChanged()
        If Not sdgSaveColumnPosition.bUserSelected Then
            clsColPosFunction.AddParameter(strParameterName:="before", strParameterValue:="FALSE")
            If Not ucrLinkedReceiver.IsEmpty Then
                clsColPosFunction.AddParameter(strParameterName:="adjacent_column", strParameterValue:=ucrLinkedReceiver.GetVariableNames())
            Else
                clsColPosFunction.RemoveParameterByName("adjacent_column")
            End If
        End If
        UpdateColumnPositionVariables()
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   If save object is a column then updates the control's R command's column 
    '''             position variables.
    '''             These variables specify the position of the new column in the data frame 
    '''             (start, end or before/after a specified column).
    '''             <para>
    '''             If <paramref name="bReset"/> is true then also resets the position dialog and
    '''             variables so that the column will be appended to the end of the data frame.
    '''             </para><para>
    '''             If save object is not a column then this function does nothing.
    '''             </para></summary>
    '''
    ''' <param name="bReset">   (Optional) If true then resets the position dialog, sets the 
    '''                         'before' parameter to false, and removes any 'adjacent_column' 
    '''                         parameter. This means that the column will be appended to the end 
    '''                         of the data frame. </param>
    '''--------------------------------------------------------------------------------------------
    Private Sub UpdateColumnPositionVariables(Optional bReset As Boolean = False)
        Dim clsTempCode As RCodeStructure
        If strSaveType <> "column" Then
            Exit Sub
        End If
        If bReset Then 'TODO SJL 17/06/20 Should the reset be done here or in the normal reset function?
            sdgSaveColumnPosition.Reset()
            'set the 'before' parameter to false, and remove any 'adjacent_column' parameter
            '(this means that the column will be appended to the end of the data frame)
            clsColPosFunction.AddParameter(strParameterName:="before", strParameterValue:="FALSE")
            clsColPosFunction.RemoveParameterByName("adjacent_column")
        End If
        'for each command in the control's command-parameter lists
        For i As Integer = 0 To lstAllRCodes.Count - 1
            clsTempCode = lstAllRCodes(i)
            If clsTempCode Is Nothing Then
                Continue For
            End If
            'set the command's column position variables from this control's stored 'before' and 'adjacent_column' parameters
            If clsColPosFunction.GetParameter("before") Is Nothing Then
                clsTempCode.bInsertColumnBefore = False
            Else
                clsTempCode.bInsertColumnBefore = If(clsColPosFunction.GetParameter("before").strArgumentValue = "TRUE", True, False)
            End If
            If clsColPosFunction.GetParameter("adjacent_column") Is Nothing Then
                clsTempCode.strAdjacentColumn = ""
            Else
                clsTempCode.strAdjacentColumn = clsColPosFunction.GetParameter("adjacent_column").strArgumentValue
            End If
        Next
    End Sub
End Class
