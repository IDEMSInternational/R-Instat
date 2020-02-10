﻿' R- Instat
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

Public Class ucrSave
    Public bFirstLoad As Boolean = True
    Private bShowCheckBox As Boolean = True
    Private bShowLabel As Boolean = False
    Private strSaveType As String = "column"
    Private strPrefix As String
    Private bIsComboBox As Boolean = True
    Private bHideIfUnchecked As Boolean = True
    Private WithEvents ucrDataFrameSelector As ucrDataFrame
    Private bAssignToIsPrefix As Boolean = False
    Private bAssignToColumnWithoutNames As Boolean = False
    Private bInsertColumnBefore As Boolean = False
    ' If true then a list of data frames is being assigned, otherwise a single data frame
    Public bDataFrameList As Boolean = False
    ' Optional R character vector to give names of new data frames if data frame list is not named
    Public strDataFrameNames As String
    Private strAssignToIfUnchecked As String = ""
    Private strGlobalDataName As String = ""
    Private ucrLinkedReceiver As ucrReceiver
    Private clsColPosFunction As New RFunction
    Private iComboBoxWidth As Integer

    Private Sub ucrSave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControl()
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

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

    Private Sub SetDefaults()
        ucrInputTextSave.Reset()
        ucrInputComboSave.Reset()
        SetSaveType(strSaveType)
        LabelOrCheckboxSettings()
        UpdateRCode()
        'update the variables used for column position
        UpdateColumnPositionVariables(True)
    End Sub

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

    Public Sub SetIsComboBox()
        bIsComboBox = True
        If bShowCheckBox Then
            CheckedChanged()
        Else
            ucrInputComboSave.Visible = True
            ucrInputTextSave.Visible = False
        End If
    End Sub

    Public Sub SetIsTextBox()
        bIsComboBox = False
        If bShowCheckBox Then
            CheckedChanged()
        Else
            ucrInputComboSave.Visible = False
            ucrInputTextSave.Visible = True
        End If
    End Sub

    Public Sub SetPrefix(strNewPrefix As String)
        strPrefix = strNewPrefix
        ucrInputComboSave.SetPrefix(strPrefix)
        ucrInputTextSave.SetPrefix(strPrefix)
    End Sub

    Public Sub showButtonPosition(bShowButton As Boolean)
        btnColumnPosition.Visible = bShowButton
    End Sub

    Public Sub SetAssignToIfUncheckedValue(strTemp As String)
        strAssignToIfUnchecked = strTemp
        UpdateRCode()
    End Sub

    Public Sub SetAssignToBooleans(Optional bTempAssignToIsPrefix As Boolean = False, Optional bTempAssignToColumnWithoutNames As Boolean = False, Optional bTempInsertColumnBefore As Boolean = False, Optional bTempDataFrameList As Boolean = False)
        bAssignToIsPrefix = bTempAssignToIsPrefix
        bAssignToColumnWithoutNames = bTempAssignToColumnWithoutNames
        bInsertColumnBefore = bTempInsertColumnBefore
        bDataFrameList = bTempDataFrameList
        UpdateRCode()
    End Sub

    ' Use this if you already have a valid R character vector
    ' strTempDataFrameNames should be a valid R character vector
    ' e.g. "data" or c("data1", "data2")
    Public Sub SetDataFrameNames(strTempDataFrameNames As String)
        strDataFrameNames = strTempDataFrameNames
        UpdateRCode()
    End Sub

    ' Use this if you just have a list of string
    ' This will be convered into a valid R character vector
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

    Public Sub SetSaveTypeAsColumn()
        SetSaveType("column")
    End Sub

    Public Sub SetSaveTypeAsDataFrame()
        SetSaveType("dataframe")
    End Sub

    Public Sub SetSaveTypeAsGraph()
        SetSaveType("graph")
    End Sub

    Public Sub SetSaveTypeAsModel()
        SetSaveType("model")
    End Sub

    Public Sub SetSaveTypeAsSurv()
        SetSaveType("surv")
    End Sub

    Public Sub SetSaveTypeAsTable()
        SetSaveType("table")
    End Sub

    Public Sub Reset()
        SetDefaults()
    End Sub

    Public Sub SetDataFrameSelector(ucrNewDataFrameSelector As ucrDataFrame)
        ucrDataFrameSelector = ucrNewDataFrameSelector
        ucrInputComboSave.SetDataFrameSelector(ucrNewDataFrameSelector)
        ucrInputTextSave.SetDataFrameSelector(ucrNewDataFrameSelector)
    End Sub

    Private Sub ucrChkSave_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSave.ControlValueChanged
        If bShowCheckBox Then
            CheckedChanged()
        End If
        OnControlValueChanged()
    End Sub

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

    Private Sub ucrInputControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboSave.ControlValueChanged, ucrInputTextSave.ControlValueChanged, ucrDataFrameSelector.ControlValueChanged
        OnControlValueChanged()
    End Sub

    Public Overrides Sub UpdateRCode(Optional bReset As Boolean = False)
        UpdateAssignTo()
        UpdateLinkedControls(bReset)
        'update the variables used for column position
        UpdateColumnPositionVariables(bReset)
    End Sub

    Protected Overrides Sub UpdateAllParameters()
        UpdateAssignTo()
        'update the variables used for column position
        UpdateColumnPositionVariables()
    End Sub

    Public Overrides Sub UpdateLinkedControls(Optional bReset As Boolean = False)
        MyBase.UpdateLinkedControls(bReset)
    End Sub

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

    Private Sub ucrInputControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputComboSave.ControlContentsChanged, ucrInputTextSave.ControlContentsChanged
        OnControlContentsChanged()
    End Sub

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

    Public Function IsComplete() As Boolean
        If bShowCheckBox Then
            Return ((ucrChkSave.Checked AndAlso GetText() <> "") OrElse Not ucrChkSave.Checked)
        Else
            Return GetText() <> ""
        End If
    End Function

    Public Function GetText() As String
        If bIsComboBox Then
            Return ucrInputComboSave.GetText()
        Else
            Return ucrInputTextSave.GetText()
        End If
    End Function

    Public ReadOnly Property bUserTyped As Boolean
        Get
            If bIsComboBox Then
                Return ucrInputComboSave.bUserTyped
            Else
                Return ucrInputTextSave.bUserTyped
            End If
        End Get
    End Property

    Public Sub SetName(strName As String, Optional bSilent As Boolean = False)
        If bIsComboBox Then
            ucrInputComboSave.SetName(strName, bSilent)
        Else
            ucrInputTextSave.SetName(strName, bSilent)
        End If
    End Sub

    Protected Overrides Function CanUpdate() As Object
        Return ((Not GetRCode().bIsAssigned AndAlso Not GetRCode().bToBeAssigned) AndAlso strSaveType <> "")
    End Function

    Public Overrides Sub AddOrRemoveParameter(bAdd As Boolean)
        UpdateAssignTo(Not bAdd)
    End Sub

    Public Sub AddAdditionalRCode(clsNewRCode As RCodeStructure, Optional iAdditionalPairNo As Integer = -1)
        AddAdditionalCodeParameterPair(clsNewRCode, Nothing, iAdditionalPairNo)
    End Sub

    Public Function UserTyped() As Boolean
        If bIsComboBox Then
            Return ucrInputComboSave.bUserTyped
        Else
            Return ucrInputTextSave.bUserTyped
        End If
    End Function

    Public Sub SetGlobalDataName(strNewGlobalDataName As String)
        strGlobalDataName = strNewGlobalDataName
        UpdateAssignTo()
    End Sub

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

    Public Sub setLinkedReceiver(ucrLinkedReceiver As ucrReceiver)
        Me.ucrLinkedReceiver = ucrLinkedReceiver
        AddHandler ucrLinkedReceiver.ControlValueChanged, AddressOf LinkedReceiverControlValueChanged
    End Sub

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