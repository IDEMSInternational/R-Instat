Imports instat

Public Class ucrSave
    Public bFirstLoad As Boolean = True
    Private bShowCheckBox As Boolean
    Private bShowLabel As Boolean
    Private strSaveType As String
    Private strPrefix As String
    Private bIsComboBox As Boolean = True
    Private bHideIfUnchecked As Boolean = True
    Private ucrDataFrameSelector As ucrDataFrame
    Private bAssignToIsPrefix As Boolean = False
    Private bAssignToColumnWithoutNames As Boolean = False
    Private bInsertColumnBefore As Boolean = False
    Private strAssignToIfUnchecked As String = ""

    Private Sub ucrSaveGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub InitialiseControl()
        ucrInputComboSave.SetValidationTypeAsRVariable()
        ucrInputTextSave.SetValidationTypeAsRVariable()
    End Sub

    Private Sub SetDefaults()
        strSaveType = "column"
        SetSaveType(strSaveType)
        bShowCheckBox = True
        bShowLabel = False
        bIsComboBox = True
        LabelOrCheckboxSettings()
        SetIsComboBox(bIsComboBox)
        UpdateRCode()
    End Sub

    Public Sub SetLabelText(strText As String)
        lblSaveText.Text = strText
        bShowLabel = True
        bShowCheckBox = False
        LabelOrCheckboxSettings()
    End Sub

    Public Sub SetCheckBoxText(strText As String)
        ucrChkSave.chkCheck.Text = strText
        bShowLabel = False
        bShowCheckBox = True
        LabelOrCheckboxSettings()
    End Sub

    Public Sub SetIsComboBox(bIsCombo As Boolean)
        bIsComboBox = bIsCombo
        If bShowCheckBox Then
            CheckedChanged()
        Else
            ucrInputComboSave.Visible = bIsCombo
            ucrInputTextSave.Visible = Not bIsCombo
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

    Public Sub SetSaveType(strType As String)
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
            Case Else
                MsgBox("Developer error: unrecognised save type: " & strType)
        End Select
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

    Private Sub ucrInputControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboSave.ControlValueChanged, ucrInputTextSave.ControlValueChanged
        OnControlValueChanged()
    End Sub

    Public Overrides Sub UpdateRCode()
        Dim strSaveName As String
        Dim strDataName As String = ""
        Dim bAddAssignTo As Boolean = True

        MyBase.UpdateRCode()

        If clsRCode IsNot Nothing Then
            strSaveName = GetText()
            If ucrDataFrameSelector IsNot Nothing Then
                strDataName = ucrDataFrameSelector.cboAvailableDataFrames.Text
            End If
            If GetText() <> "" Then
                strSaveName = GetText()
            ElseIf strAssignToIfUnchecked <> "" Then
                strSaveName = strAssignToIfUnchecked
            End If
            If bShowCheckBox Then
                bAddAssignTo = bAddAssignTo AndAlso strSaveName <> ""
            End If
            If bAddAssignTo Then
                Select Case strSaveType
                    Case "column"
                        clsRCode.SetAssignTo(strTemp:=strSaveName, strTempDataframe:=strDataName, strTempColumn:=strSaveName, bAssignToIsPrefix:=bAssignToIsPrefix, bAssignToColumnWithoutNames:=bAssignToColumnWithoutNames, bInsertColumnBefore:=bInsertColumnBefore)
                    Case "dataframe"
                        clsRCode.SetAssignTo(strTemp:=strSaveName, strTempDataframe:=strDataName, bAssignToIsPrefix:=bAssignToIsPrefix)
                    Case "graph"
                        clsRCode.SetAssignTo(strTemp:=strSaveName, strTempDataframe:=strDataName, strTempGraph:=strSaveName, bAssignToIsPrefix:=bAssignToIsPrefix)
                    Case "model"
                        clsRCode.SetAssignTo(strTemp:=strSaveName, strTempDataframe:=strDataName, strTempModel:=strSaveName, bAssignToIsPrefix:=bAssignToIsPrefix)
                End Select
            Else
                clsRCode.RemoveAssignTo()
            End If
        End If
    End Sub

    Private Sub ucrInputControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputComboSave.ControlContentsChanged, ucrInputTextSave.ControlContentsChanged
        OnControlContentsChanged()
    End Sub

    Public Overrides Sub UpdateControl(Optional bReset As Boolean = False)
        MyBase.UpdateControl(bReset)
        If clsRCode IsNot Nothing Then
            If clsRCode.bToBeAssigned OrElse clsRCode.bIsAssigned Then
                If bIsComboBox Then
                    ucrInputComboSave.SetName(clsRCode.strAssignTo)
                    ucrInputTextSave.SetName("")
                Else
                    ucrInputTextSave.SetName(clsRCode.strAssignTo)
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
                    ucrChkSave.Checked = (clsRCode.bToBeAssigned OrElse clsRCode.bIsAssigned)
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
End Class