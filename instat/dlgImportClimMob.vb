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

Imports instat.Translations
Imports RDotNet

Public Class dlgImportfromClimMob
    Private clsKeysFunction, clsClimmobFunction, clsProjectsFunction, clsDplyrFunction, clsSecondDplyrFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsFirstOperator, clsKeysOverallFunction As New ROperator
    Private clsSecondOperator As New ROperator
    Private clsThirdOperator As New ROperator
    Private clsFourthOperator As New ROperator
    Private ReadOnly strClimmob3 As String = "climmob3"
    Private ReadOnly str1000FARMS As String = "1000FARMS"
    Private ReadOnly strAVISA As String = "AVISA"
    Private ReadOnly strRTB As String = "RTB"

    Private Sub dlgImportfromClimMob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
    End Sub

    Private Sub InitialiseDialog()

        ucrInputServerName.SetItems({strClimmob3, str1000FARMS, strAVISA, strRTB})
        ucrInputServerName.SetDropDownStyleAsNonEditable()
        ucrInputServerName.SetLinkedDisplayControl(lblServerName)
        ucrInputServerName.SetParameter(New RParameter("server", 1))

        ucrInputChooseForm.SetParameter(New RParameter("right", 3))
        ucrInputChooseForm.bAllowNonConditionValues = True

        ucrChkDefineTricotData.SetText("Define Tricot Data")
        ucrChkDefineTricotData.Enabled = False

        cmdTricotData.Visible = False

        ucrSaveFile.SetPrefix("climmob_dataframe")
        ucrSaveFile.SetSaveTypeAsDataFrame()
        ucrSaveFile.SetLabelText(" Data Frame Name:")
        ucrSaveFile.SetIsTextBox()
        ucrSaveFile.ucrInputTextSave.bAutoChangeOnLeave = True
    End Sub

    Private Sub SetDefaults()
        clsKeysFunction = New RFunction
        clsClimmobFunction = New RFunction
        clsProjectsFunction = New RFunction
        clsDplyrFunction = New RFunction
        clsSecondDplyrFunction = New RFunction
        clsKeysOverallFunction = New ROperator
        clsFirstOperator = New ROperator
        clsSecondOperator = New ROperator
        clsThirdOperator = New ROperator
        clsFourthOperator = New ROperator

        ucrInputServerName.SetText(strClimmob3)
        ucrInputServerName.bUpdateRCodeFromControl = True

        ' Set up to get Project ID name for the input form button
        clsProjectsFunction.SetPackageName("ClimMobTools")
        clsProjectsFunction.SetRCommand("getProjectsCM")
        clsProjectsFunction.AddParameter("key", clsROperatorParameter:=clsKeysOverallFunction, iPosition:=2)

        clsFirstOperator.SetOperation("$")
        clsFirstOperator.AddParameter("left", clsRFunctionParameter:=clsProjectsFunction, iPosition:=0)
        clsFirstOperator.AddParameter("right", "project_id", iPosition:=1)
        clsFirstOperator.bSpaceAroundOperation = False

        clsSecondOperator.SetOperation("%>%")
        clsSecondOperator.AddParameter("left", clsRFunctionParameter:=clsProjectsFunction, iPosition:=0)
        clsSecondOperator.AddParameter("right", clsROperatorParameter:=clsFourthOperator, iPosition:=2)
        clsSecondOperator.bSpaceAroundOperation = False
        clsSecondOperator.SetAssignTo("user_owner")

        clsThirdOperator.SetOperation("==")
        clsThirdOperator.AddParameter("left", "project_id", iPosition:=0)
        clsThirdOperator.AddParameter("right", Chr(34) & ucrInputChooseForm.GetText & Chr(34), iPosition:=1) ' right = value in the ucrInputBox
        clsThirdOperator.bSpaceAroundOperation = False

        clsFourthOperator.SetOperation("%>%")
        clsFourthOperator.AddParameter("left", clsRFunctionParameter:=clsDplyrFunction, iPosition:=0)
        clsFourthOperator.AddParameter("right", clsRFunctionParameter:=clsSecondDplyrFunction, iPosition:=1)
        clsFourthOperator.bSpaceAroundOperation = False

        ucrInputChooseForm.bAllowNonConditionValues = True
        ucrInputChooseForm.SetName("")

        clsKeysOverallFunction.SetOperation("[")
        clsKeysOverallFunction.AddParameter("left", clsRFunctionParameter:=clsKeysFunction, iPosition:=0)
        clsKeysOverallFunction.AddParameter("right", "1,]", iPosition:=1)
        clsKeysFunction.SetRCommand("read.table")
        clsKeysFunction.AddParameter(strParameterName:="key", Chr(34) & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsKeysFunction.AddParameter(strParameterName:="quote", Chr(34) & "\""" & Chr(34), iPosition:=1)
        clsKeysFunction.AddParameter(strParameterName:="comment.char", Chr(34) & Chr(34), iPosition:=2)

        clsClimmobFunction.SetPackageName("ClimMobTools")
        clsClimmobFunction.SetRCommand("getDataCM")
        clsClimmobFunction.AddParameter("key", clsROperatorParameter:=clsKeysOverallFunction, iPosition:=0)
        clsClimmobFunction.AddParameter("project", ucrInputChooseForm.GetText, iPosition:=1)
        clsClimmobFunction.AddParameter("userowner", clsROperatorParameter:=clsSecondOperator, iPosition:=2)
        clsClimmobFunction.AddParameter("pivot.wider", "TRUE")

        clsDplyrFunction.SetPackageName("dplyr")
        clsDplyrFunction.SetRCommand("filter")
        clsDplyrFunction.AddParameter("project", clsROperatorParameter:=clsThirdOperator, bIncludeArgumentName:=False)

        clsSecondDplyrFunction.SetPackageName("dplyr")
        clsSecondDplyrFunction.SetRCommand("pull")
        clsSecondDplyrFunction.AddParameter("project", "user_owner", bIncludeArgumentName:=False)

        ucrBase.clsRsyntax.SetBaseRFunction(clsClimmobFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputChooseForm.AddAdditionalCodeParameterPair(clsClimmobFunction, New RParameter("project", 1), 1)

        ucrInputChooseForm.SetRCode(clsThirdOperator, bReset)
        ucrSaveFile.SetRCode(clsClimmobFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub ucrInputServerName_NameChanged() Handles ucrInputServerName.ControlValueChanged
        If ucrInputServerName.IsEmpty() Then
            clsClimmobFunction.RemoveParameterByName("server")
            clsProjectsFunction.RemoveParameterByName("server")
        Else
            clsProjectsFunction.AddParameter("server", Chr(34) & ucrInputServerName.GetText & Chr(34))
            clsClimmobFunction.AddParameter("server", Chr(34) & ucrInputServerName.GetText & Chr(34))
        End If
    End Sub

    Private Sub ucrInputChooseForm_NameChanged() Handles ucrInputChooseForm.ControlValueChanged
        If ucrInputChooseForm.IsEmpty() Then
            clsThirdOperator.RemoveParameterByName("right")
        Else
            clsThirdOperator.AddParameter("right", Chr(34) & ucrInputChooseForm.GetText & Chr(34))
        End If
    End Sub

    Private Sub cmdChooseFile_Click(sender As Object, e As EventArgs) Handles cmdKey.Click
        sdgImportFromClimMob.Setup(clsKeysFunction.GetParameter("key"))
        sdgImportFromClimMob.ShowDialog()
    End Sub

    Private Sub cmdTricotData_Click(sender As Object, e As EventArgs) Handles cmdTricotData.Click
        'sdgDefineTricotData.Setup(clsKeysFunction.GetParameter("key"))
        sdgDefineTricotData.ShowDialog()
    End Sub

    Private Sub ucrInputServerName_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputServerName.ControlContentsChanged
        If ucrInputServerName.IsEmpty() Then
            cmdFindForms.Enabled = False
        Else
            cmdFindForms.Enabled = True
        End If
        ucrInputChooseForm.cboInput.Items.Clear()
        ucrInputChooseForm.SetText("")
    End Sub

    Private Sub cmdFindForms_click(sender As Object, e As EventArgs) Handles cmdFindForms.Click
        Dim strFormNames() As String
        Dim expTemp As SymbolicExpression

        Cursor = Cursors.WaitCursor
        expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsFirstOperator.ToScript(), bSeparateThread:=False, bShowWaitDialogOverride:=False)
        Cursor = Cursors.Default
        If expTemp IsNot Nothing Then
            strFormNames = expTemp.AsCharacter().ToArray()
            If strFormNames.Length > 0 Then
                ucrInputChooseForm.SetItems(strFormNames)
                ucrInputChooseForm.SetName(ucrInputChooseForm.cboInput.Items(0))
            Else
                ucrInputChooseForm.cboInput.Items.Clear()
            End If
        Else
            ucrInputChooseForm.cboInput.Items.Clear()
        End If
    End Sub

    Private Sub ucrChkDefineTricotData_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkDefineTricotData.ControlContentsChanged
        If ucrChkDefineTricotData.Checked Then
            cmdTricotData.Visible = True
        Else
            cmdTricotData.Visible = False
        End If
    End Sub
End Class
