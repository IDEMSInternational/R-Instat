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
    Private strAssignToIfUnchecked As String = ""

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
    End Sub

    Private Sub SetDefaults()
        ucrInputTextSave.Reset()
        ucrInputComboSave.Reset()
        SetSaveType(strSaveType)
        LabelOrCheckboxSettings()
        UpdateRCode()
    End Sub

    Public Sub SetLabelText(strText As String)
        Dim iTemp As Integer

        lblSaveText.Text = strText
        bShowLabel = True
        bShowCheckBox = False
        LabelOrCheckboxSettings()
        If bIsComboBox Then
            iTemp = lblSaveText.Location.X + lblSaveText.Size.Width - ucrInputComboSave.Location.X
            If iTemp > 0 Then
                ucrInputComboSave.Width = ucrInputComboSave.Size.Width - iTemp
            End If
        Else
            iTemp = lblSaveText.Location.X + lblSaveText.Size.Width - ucrInputTextSave.Location.X
            If iTemp > 0 Then
                ucrInputTextSave.Width = ucrInputComboSave.Size.Width - iTemp
            End If
        End If
    End Sub

    Public Sub SetCheckBoxText(strText As String)
        ucrChkSave.SetText(strText)
        bShowLabel = False
        bShowCheckBox = True
        LabelOrCheckboxSettings()
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

    Public Sub SetAssignToIfUncheckedValue(strTemp As String)
        strAssignToIfUnchecked = strTemp
        UpdateRCode()
    End Sub

    Public Sub SetAssignToBooleans(Optional bTempAssignToIsPrefix As Boolean = False, Optional bTempAssignToColumnWithoutNames As Boolean = False, Optional bTempInsertColumnBefore As Boolean = False)
        bAssignToIsPrefix = bTempAssignToIsPrefix
        bAssignToColumnWithoutNames = bTempAssignToColumnWithoutNames
        bInsertColumnBefore = bTempInsertColumnBefore
        UpdateRCode()
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
            Case "dataframe"
                ucrInputComboSave.SetDefaultTypeAsDataFrame()
                ucrInputComboSave.SetItemsTypeAsDataFrames()
                ucrInputTextSave.SetDefaultTypeAsDataFrame()
            Case "graph"
                ucrInputComboSave.SetDefaultTypeAsGraph()
                ucrInputComboSave.SetItemsTypeAsGraphs()
                ucrInputTextSave.SetDefaultTypeAsGraph()
            Case "model"
                ucrInputComboSave.SetDefaultTypeAsModel()
                ucrInputComboSave.SetItemsTypeAsModels()
                ucrInputTextSave.SetDefaultTypeAsModel()
            Case "table"
                ucrInputComboSave.SetDefaultTypeAsTable()
                ucrInputComboSave.SetItemsTypeAsTables()
                ucrInputTextSave.SetDefaultTypeAsTable()
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
    End Sub

    Protected Overrides Sub UpdateAllParameters()
        UpdateAssignTo()
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
                                clsTempCode.SetAssignTo(strTemp:=strSaveName, strTempDataframe:=strSaveName, bAssignToIsPrefix:=bAssignToIsPrefix)
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

    Public Overrides Sub UpdateControl(Optional bReset As Boolean = False)
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
End Class