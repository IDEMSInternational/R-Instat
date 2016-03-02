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
    Dim clsModel, clsModel2 As New ROperator
    Public myRSyntax As New RSyntax

    Private Sub dlgSimpleWithGroups_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        'sdgSimpleRegOptions.SetRModelFunction(ucrBaseRegWithGroups.clsRsyntax.clsBaseFunction)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorSimpleRegGroups.Reset()
        ucrResponse.SetMeAsReceiver()
        ucrSelectorSimpleRegGroups.Focus()
        chkSaveModel.Checked = True
        ucrModelName.SetName("reg_grp")
        sdgSimpleRegOptions.SetDefaults()
        TestOKEnabled()
    End Sub

    Public Sub TestOKEnabled()
        If (Not ucrResponse.IsEmpty()) And (Not ucrExplanatory.IsEmpty()) And (Not ucrGroupingFactor.IsEmpty()) Then
            ucrBaseRegWithGroups.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel2)
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
        TestOKEnabled()
    End Sub

    Private Sub ucrExplanatory_SelectionChanged() Handles ucrExplanatory.SelectionChanged
        clsModel.SetParameter(False, strValue:=ucrExplanatory.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled()
    End Sub

    Private Sub ucrGroupingFactor_SelectionChanged() Handles ucrGroupingFactor.SelectionChanged
        clsModel2.SetOperation("+")
        clsModel2.bBrackets = False
        clsModel2.SetParameter(True, clsOp:=clsModel)
        clsModel2.SetParameter(False, strValue:=ucrGroupingFactor.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled()
    End Sub

    Private Sub ucrBaseRegWithGroups_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseRegWithGroups.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrModelName_NameChanged() Handles ucrModelName.NameChanged
        AssignModelName()
    End Sub

    Private Sub ucrBaseRegWithGroups_ClickOk(sender As Object, e As EventArgs) Handles ucrBaseRegWithGroups.ClickOk
        ' sdgSimpleRegOptions.RegOptions()
        frmMain.clsRLink.RunScript(ucrBaseRegWithGroups.clsRsyntax.clsBaseFunction.ToScript(), 2)
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

End Class