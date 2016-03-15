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

Imports instat.Translations
Public Class dlgSimpleWithGroups
    Public bFirstLoad As Boolean = True
    Public clsRSingleModelFunction As RFunction
    Dim clsModel, clsModel1, clsModel2, clsModel3 As New ROperator

    Private Sub dlgSimpleWithGroups_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UcrInputComboBox1.SetItemsTypeAsModels()

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseRegWithGroups.clsRsyntax.SetFunction("lm")
        ucrBaseRegWithGroups.clsRsyntax.iCallType = 2
        clsModel.SetOperation("~")
        ucrResponse.Selector = ucrSelectorSimpleRegGroups
        ucrExplanatory.Selector = ucrSelectorSimpleRegGroups
        ucrGroupingFactor.Selector = ucrSelectorSimpleRegGroups
        ucrBaseRegWithGroups.iHelpTopicID = 176
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorSimpleRegGroups.Reset()
        ucrResponse.SetMeAsReceiver()
        ucrSelectorSimpleRegGroups.Focus()
        chkSaveModel.Checked = True
        ucrModelName.SetName("reg_grp")
        chkAll.Checked = True
        TestOKEnabled(clsModel)
    End Sub

    Public Sub TestOKEnabled(clsModelNew)
        If (Not ucrResponse.IsEmpty()) And (Not ucrExplanatory.IsEmpty()) And (Not ucrGroupingFactor.IsEmpty()) Then
            ucrBaseRegWithGroups.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModelNew)
            ucrBaseRegWithGroups.OKEnabled(True)

        Else
            ucrBaseRegWithGroups.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectorSimpleReg_DataFrameChanged() Handles ucrSelectorSimpleRegGroups.DataFrameChanged
        ucrBaseRegWithGroups.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorSimpleRegGroups.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrResponse_SelectionChanged() Handles ucrResponse.SelectionChanged
        clsModel.SetParameter(True, strValue:=ucrResponse.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled(clsModel)
    End Sub

    Private Sub ucrExplanatory_SelectionChanged() Handles ucrExplanatory.SelectionChanged
        clsModel.SetParameter(False, strValue:=ucrExplanatory.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled(clsModel)
    End Sub

    Private Sub ucrGroupingFactor_SelectionChanged() Handles ucrGroupingFactor.SelectionChanged
        TestOKEnabled(clsModel)
    End Sub

    Private Sub ucrBaseRegWithGroups_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseRegWithGroups.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrModelName_NameChanged() Handles ucrModelName.NameChanged
        AssignModelName()
    End Sub

    Private Sub ucrBaseRegWithGroups_ClickOk(sender As Object, e As EventArgs) Handles ucrBaseRegWithGroups.ClickOk
        RegOptions()
    End Sub

    Private Sub chkModelName_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveModel.CheckedChanged
        If chkSaveModel.Checked Then
            ucrModelName.Visible = True
        Else
            ucrModelName.Visible = False
        End If
        AssignModelName()
    End Sub

    Private Sub AssignModelName()
        If chkSaveModel.Checked AndAlso ucrModelName.txtValidation.Text <> "" Then
            ucrBaseRegWithGroups.clsRsyntax.SetAssignTo(ucrModelName.txtValidation.Text, strTempModel:=ucrModelName.txtValidation.Text)
            ucrBaseRegWithGroups.clsRsyntax.bExcludeAssignedFunctionOutput = True
        Else
            ucrBaseRegWithGroups.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model")
            ucrBaseRegWithGroups.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub

    Private Sub SingleModel()
        ucrBaseRegWithGroups.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel)
        TestOKEnabled(clsModel)
        frmMain.clsRLink.RunScript(ucrBaseRegWithGroups.clsRsyntax.clsBaseFunction.ToScript(), 2)
    End Sub

    Private Sub CommonIntercept()
        clsModel1.SetOperation("/")
        clsModel1.bBrackets = False
        clsModel1.SetParameter(True, clsOp:=clsModel)
        clsModel1.SetParameter(False, strValue:=ucrGroupingFactor.GetVariableNames(bWithQuotes:=False))
        ucrBaseRegWithGroups.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel1)
        TestOKEnabled(clsModel1)
        frmMain.clsRLink.RunScript(ucrBaseRegWithGroups.clsRsyntax.clsBaseFunction.ToScript(), 2)
    End Sub


    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        If (chkAll.Checked) Then
            chkSingle.Checked = True
            chkCommonIntercept.Checked = True
            chkParallelLines.Checked = True
            chkJointLines.Checked = True
        Else
            chkSingle.Checked = False
            chkCommonIntercept.Checked = False
            chkParallelLines.Checked = False
            chkJointLines.Checked = False
        End If
    End Sub

    Private Sub ParallelLines()
        clsModel2.SetOperation("+")
        clsModel2.bBrackets = False
        clsModel2.SetParameter(True, clsOp:=clsModel)
        clsModel2.SetParameter(False, strValue:=ucrGroupingFactor.GetVariableNames(bWithQuotes:=False))
        ucrBaseRegWithGroups.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel2)
        TestOKEnabled(clsModel2)
        frmMain.clsRLink.RunScript(ucrBaseRegWithGroups.clsRsyntax.clsBaseFunction.ToScript(), 2)
    End Sub

    Private Sub JointLines()
        clsModel3.SetOperation("*")
        clsModel3.bBrackets = False
        clsModel3.SetParameter(True, clsOp:=clsModel)
        clsModel3.SetParameter(False, strValue:=ucrGroupingFactor.GetVariableNames(bWithQuotes:=False))
        ucrBaseRegWithGroups.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel3)
        TestOKEnabled(clsModel3)
        frmMain.clsRLink.RunScript(ucrBaseRegWithGroups.clsRsyntax.clsBaseFunction.ToScript(), 2)
    End Sub

    Public Sub RegOptions()
        If (chkSingle.Checked) Then
            SingleModel()
        End If
        If (chkCommonIntercept.Checked) Then
            CommonIntercept()
        End If
        If (chkParallelLines.Checked) Then
            ParallelLines()
        End If
        If (chkJointLines.Checked) Then
            JointLines()
        End If
    End Sub
End Class