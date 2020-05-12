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

''' <summary>   An ucr save. </summary>
Public Class ucrSave
    ''' <summary>   True if the control has not yet loaded. </summary>
    Public bFirstLoad As Boolean = True

    ''' <summary>   True to show, false to hide the check box. </summary>
    Private bShowCheckBox As Boolean = True

    ''' <summary>   True to show, false to hide the label. </summary>
    Private bShowLabel As Boolean = False

    ''' <summary>   Type of the save. </summary>
    Private strSaveType As String = "column"

    ''' <summary>   The prefix. </summary>
    Private strPrefix As String

    ''' <summary>   True if is combo box, false if not. </summary>
    Private bIsComboBox As Boolean = True

    ''' <summary>   True to hide, false to show if unchecked. </summary>
    Private bHideIfUnchecked As Boolean = True

    ''' <summary>   The with events. </summary>
    Private WithEvents ucrDataFrameSelector As ucrDataFrame

    ''' <summary>   True if assign to is prefix. </summary>
    Private bAssignToIsPrefix As Boolean = False

    ''' <summary>   True to assign to column without names. </summary>
    Private bAssignToColumnWithoutNames As Boolean = False

    ''' <summary>   True to insert column before. </summary>
    Private bInsertColumnBefore As Boolean = False

    ''' <summary>   If true then a list of data frames is being assigned, otherwise a single data 
    '''             frame. </summary>
    Public bDataFrameList As Boolean = False

    ''' <summary>   Optional R character vector to give names of new data frames if data frame list is not named. </summary>
    Public strDataFrameNames As String

    ''' <summary>   The assign to if unchecked. </summary>
    Private strAssignToIfUnchecked As String = ""

    ''' <summary>   Name of the global data. </summary>
    Private strGlobalDataName As String = ""

    ''' <summary>   The ucr linked receiver. </summary>
    Private ucrLinkedReceiver As ucrReceiver

    ''' <summary>   The cls col position function. </summary>
    Private clsColPosFunction As New RFunction

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
    '''             For this control, it sets a flag to show that this control's R code should be 
    '''             updated.
    '''             It sets the combo box and text box to R variables, currently inactive, whose R 
    '''             code should be updated. 
    '''             It sets the checkbox as inactive.
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

    ''' <summary>   Resets the control to its default state. </summary>
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

    ''' <summary>   Sets is combo box. </summary>
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
    ''' <summary>   If specified conditions are met then sets the text/combo box to enabled and
    '''             visible. If other conditions are met then also displays the default name in the
    '''             text/combo box:. </summary>
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
    ''' <summary>   Sets the default value for the text/combo box based on 
    '''             <paramref name="strNewPrefix"/>. </summary>
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
    ''' <summary>   Sets assign to if unchecked value. </summary>
    '''
    ''' <param name="strTemp">  The temporary. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetAssignToIfUncheckedValue(strTemp As String)
        strAssignToIfUnchecked = strTemp
        UpdateRCode()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets assign to booleans. </summary>
    '''
    ''' <param name="bTempAssignToIsPrefix">            (Optional) True if temporary assign to is
    '''                                                 prefix. </param>
    ''' <param name="bTempAssignToColumnWithoutNames">  (Optional) True to temporary assign to column
    '''                                                 without names. </param>
    ''' <param name="bTempInsertColumnBefore">          (Optional) True to temporary insert column
    '''                                                 before. </param>
    ''' <param name="bTempDataFrameList">               (Optional) True to temporary data frame list. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetAssignToBooleans(Optional bTempAssignToIsPrefix As Boolean = False, Optional bTempAssignToColumnWithoutNames As Boolean = False, Optional bTempInsertColumnBefore As Boolean = False, Optional bTempDataFrameList As Boolean = False)
        bAssignToIsPrefix = bTempAssignToIsPrefix
        bAssignToColumnWithoutNames = bTempAssignToColumnWithoutNames
        bInsertColumnBefore = bTempInsertColumnBefore
        bDataFrameList = bTempDataFrameList
        UpdateRCode()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>  Use this if you already have a valid R character vector
    '''    ' strTempDataFrameNames should be a valid R character vector
    '''    ' e.g. "data" or c("data1", "data2"). </summary>
    '''
    ''' <param name="strTempDataFrameNames">    List of names of the temporary data frames. </param>
    '''-------------------------------------------------------------------------------------------- 
    Public Sub SetDataFrameNames(strTempDataFrameNames As String)
        strDataFrameNames = strTempDataFrameNames
        UpdateRCode()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Use this if you just have a list of string
    '''    ' This will be convered into a valid R character vector. </summary>
    '''
    ''' <param name="lstTempDataFrameNames">    List of names of the list temporary data frames. </param>
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

    ''' <summary>   Sets the child controls to the correct enabled/visible state depending on 
    '''             this control's current state.
    '''             </summary>
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
        Else
            ucrInputComboSave.Enabled = True
            ucrInputTextSave.Enabled = True
            lblSaveText.Visible = False
            ucrChkSave.Visible = False
        End If
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets save type. </summary>
    '''
    ''' <param name="strType">  The type. </param>
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

    ''' <summary>   Resets this.  </summary>
    Public Sub Reset()
        SetDefaults()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets data frame selector. </summary>
    '''
    ''' <param name="ucrNewDataFrameSelector">  The ucr new data frame selector. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetDataFrameSelector(ucrNewDataFrameSelector As ucrDataFrame)
        ucrDataFrameSelector = ucrNewDataFrameSelector
        ucrInputComboSave.SetDataFrameSelector(ucrNewDataFrameSelector)
        ucrInputTextSave.SetDataFrameSelector(ucrNewDataFrameSelector)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Ucr check save control value changed. </summary>
    '''
    ''' <param name="ucrChangedControl">    The ucr changed control. </param>
    '''--------------------------------------------------------------------------------------------
    Private Sub ucrChkSave_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSave.ControlValueChanged
        If bShowCheckBox Then
            CheckedChanged()
        End If
        OnControlValueChanged()
    End Sub

    ''' <summary>   If the conditions below are met then sets the text/combo box to enabled and 
    '''             visible:
    '''                
    '''             If the conditions below are met then also displays the default name in the 
    '''             text/combo box:
    '''             TODO SJL 07/05/20 Complete condition lists
    '''             </summary>
    Private Sub CheckedChanged()
        ucrInputTextSave.Enabled = ucrChkSave.Checked
        ucrInputComboSave.Enabled = ucrChkSave.Checked
        ucrInputTextSave.Visible = False
        ucrInputComboSave.Visible = False
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
    ''' <summary>   Ucr input controls control value changed. </summary>
    '''
    ''' <param name="ucrChangedControl">    The ucr changed control. </param>
    '''--------------------------------------------------------------------------------------------
    Private Sub ucrInputControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboSave.ControlValueChanged, ucrInputTextSave.ControlValueChanged, ucrDataFrameSelector.ControlValueChanged
        OnControlValueChanged()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Updates the r code described by bReset. </summary>
    '''
    ''' <param name="bReset">   (Optional) True to reset. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overrides Sub UpdateRCode(Optional bReset As Boolean = False)
        UpdateAssignTo()
        UpdateLinkedControls(bReset)
        'update the variables used for column position
        UpdateColumnPositionVariables(bReset)
    End Sub
    ''' <summary>   Updates all parameters. </summary>

    Protected Overrides Sub UpdateAllParameters()
        UpdateAssignTo()
        'update the variables used for column position
        UpdateColumnPositionVariables()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Updates the linked controls described by bReset. </summary>
    '''
    ''' <param name="bReset">   (Optional) True to reset. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overrides Sub UpdateLinkedControls(Optional bReset As Boolean = False)
        MyBase.UpdateLinkedControls(bReset)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Updates the assign to described by bRemove. </summary>
    '''
    ''' <param name="bRemove">  (Optional) True to remove. </param>
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
                        End Select
                    Else
                        clsTempCode.RemoveAssignTo()
                    End If
                End If
            End If
        Next
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Ucr input controls control contents changed. </summary>
    '''
    ''' <param name="ucrChangedControl">    The ucr changed control. </param>
    '''--------------------------------------------------------------------------------------------
    Private Sub ucrInputControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputComboSave.ControlContentsChanged, ucrInputTextSave.ControlContentsChanged
        OnControlContentsChanged()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Updates the control. </summary>
    '''
    ''' <param name="bReset">           (Optional) True to reset. </param>
    ''' <param name="bCloneIfNeeded">   (Optional) True if clone if needed. </param>
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
    ''' <summary>   Query if this  is complete. </summary>
    '''
    ''' <returns>   True if complete, false if not. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function IsComplete() As Boolean
        If bShowCheckBox Then
            Return ((ucrChkSave.Checked AndAlso GetText() <> "") OrElse Not ucrChkSave.Checked)
        Else
            Return GetText() <> ""
        End If
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the text. </summary>
    '''
    ''' <returns>   The text. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetText() As String
        If bIsComboBox Then
            Return ucrInputComboSave.GetText()
        Else
            Return ucrInputTextSave.GetText()
        End If
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the user typed. </summary>
    '''
    ''' <value> The b user typed. </value>
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
    ''' <summary>   Sets a name. </summary>
    '''
    ''' <param name="strName">  The name. </param>
    ''' <param name="bSilent">  (Optional) True to silent. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetName(strName As String, Optional bSilent As Boolean = False)
        If bIsComboBox Then
            ucrInputComboSave.SetName(strName, bSilent)
        Else
            ucrInputTextSave.SetName(strName, bSilent)
        End If
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Can update. </summary>
    '''
    ''' <returns>   An Object. </returns>
    '''--------------------------------------------------------------------------------------------
    Protected Overrides Function CanUpdate() As Object
        Return ((Not GetRCode().bIsAssigned AndAlso Not GetRCode().bToBeAssigned) AndAlso strSaveType <> "")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Adds an or remove parameter. </summary>
    '''
    ''' <param name="bAdd"> True to add. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overrides Sub AddOrRemoveParameter(bAdd As Boolean)
        UpdateAssignTo(Not bAdd)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Adds an additional r code to 'iAdditionalPairNo'. </summary>
    '''
    ''' <param name="clsNewRCode">          The cls new r code. </param>
    ''' <param name="iAdditionalPairNo">    (Optional) Zero-based index of the additional pair no. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub AddAdditionalRCode(clsNewRCode As RCodeStructure, Optional iAdditionalPairNo As Integer = -1)
        AddAdditionalCodeParameterPair(clsNewRCode, Nothing, iAdditionalPairNo)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Determines if we can user typed. </summary>
    '''
    ''' <returns>   True if it succeeds, false if it fails. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function UserTyped() As Boolean
        If bIsComboBox Then
            Return ucrInputComboSave.bUserTyped
        Else
            Return ucrInputTextSave.bUserTyped
        End If
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets global data name. </summary>
    '''
    ''' <param name="strNewGlobalDataName"> Name of the new global data. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetGlobalDataName(strNewGlobalDataName As String)
        strGlobalDataName = strNewGlobalDataName
        UpdateAssignTo()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Button column position click. </summary>
    '''
    ''' <param name="sender">   Source of the event. </param>
    ''' <param name="e">        Event information. </param>
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
    ''' <summary>   Sets linked receiver. </summary>
    '''
    ''' <param name="ucrLinkedReceiver">    The ucr linked receiver. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub setLinkedReceiver(ucrLinkedReceiver As ucrReceiver)
        Me.ucrLinkedReceiver = ucrLinkedReceiver
        AddHandler ucrLinkedReceiver.ControlValueChanged, AddressOf LinkedReceiverControlValueChanged
    End Sub

    ''' <summary>   Linked receiver control value changed. </summary>
    Private Sub LinkedReceiverControlValueChanged()
        'if the user has not explictly set the column position then set it to after the specified column by default
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
    ''' <summary>   Updates the column position variables described by bReset. </summary>
    '''
    ''' <param name="bReset">   (Optional) True to reset. </param>
    '''--------------------------------------------------------------------------------------------
    Private Sub UpdateColumnPositionVariables(Optional bReset As Boolean = False)
        Dim clsTempCode As RCodeStructure

        If strSaveType <> "column" Then
            Exit Sub
        End If

        If bReset Then
            sdgSaveColumnPosition.Reset()
            clsColPosFunction.AddParameter(strParameterName:="before", strParameterValue:="FALSE")
            clsColPosFunction.RemoveParameterByName("adjacent_column")
        End If

        For i As Integer = 0 To lstAllRCodes.Count - 1
            clsTempCode = lstAllRCodes(i)

            If clsTempCode Is Nothing Then
                Continue For
            End If

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