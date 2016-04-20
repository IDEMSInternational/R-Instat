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
    Dim clsModel, clsModel1 As New ROperator
    Dim operation As String

    Private Sub dlgSimpleWithGroups_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'UcrInputComboBox1.SetItemsTypeAsModels()

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
        operation = ""
        chkSaveModel.Checked = True
        ucrModelName.Visible = True
        ucrFamily.Enabled = False
        'TODO get this to be getting a default name e.g. reg1, reg2, etc.
        '     will be possible with new textbox user control
        ucrModelName.SetName("reg")
        'sdgSimpleRegOptions.SetDefaults()
        TestOKEnabled()
    End Sub

    Public Sub TestOKEnabled()
        If (Not ucrResponse.IsEmpty()) And (Not ucrExplanatory.IsEmpty()) And (Not ucrGroupingFactor.IsEmpty()) And (operation <> "") Then
            clsModel1.SetOperation(operation)
            clsModel1.bBrackets = False
            clsModel1.SetParameter(True, clsOp:=clsModel)
            clsModel1.SetParameter(False, strValue:=ucrGroupingFactor.GetVariableNames(bWithQuotes:=False))
            ucrBaseRegWithGroups.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel1)
            ucrModelPreview.txtInput.Text = clsModel1.strAssignToModel
            ucrBaseRegWithGroups.OKEnabled(True)

        Else
            ucrBaseRegWithGroups.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectorSimpleReg_DataFrameChanged() Handles ucrSelectorSimpleRegGroups.DataFrameChanged
        ucrBaseRegWithGroups.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorSimpleRegGroups.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub
    Private Sub ucrResponse_SelectionChanged() Handles ucrResponse.SelectionChanged
        If Not ucrResponse.IsEmpty Then
            clsModel.SetParameter(True, strValue:=ucrResponse.GetVariableNames(bWithQuotes:=False))
            ucrFamily.RecieverDatatype(ucrSelectorSimpleRegGroups.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))
            ucrFamily.Enabled = True
            ucrFamily.SetGLMDistributions()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrExplanatory_SelectionChanged() Handles ucrExplanatory.SelectionChanged
        clsModel.SetParameter(False, strValue:=ucrExplanatory.GetVariableNames(bWithQuotes:=False))
        TestOKEnabled()
    End Sub

    Private Sub ucrGroupingFactor_SelectionChanged() Handles ucrGroupingFactor.SelectionChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrBaseRegWithGroups_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseRegWithGroups.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrModelName_NameChanged() Handles ucrModelName.NameChanged
        AssignModelName()
    End Sub

    Private Sub ucrModelPreview_TextChanged(sender As Object, e As EventArgs) Handles ucrModelPreview.TextChanged
        'TODO: we need to preview the model here
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        'sdgSimpleWithGroupsOptions.ShowDialog()
    End Sub

    Private Sub cmdParallelLines_Click(sender As Object, e As EventArgs) Handles cmdParallelLines.Click
        operation = "+"
        TestOKEnabled()
    End Sub

    Private Sub cmdConditional_Click(sender As Object, e As EventArgs) Handles cmdConditional.Click
        operation = ":"
        TestOKEnabled()
    End Sub

    Private Sub cmdJointLines_Click(sender As Object, e As EventArgs) Handles cmdJointLines.Click
        operation = "*"
        TestOKEnabled()
    End Sub

    Private Sub ucrGroupingFactor_SelectionChanged(sender As Object, e As EventArgs) Handles ucrGroupingFactor.SelectionChanged

    End Sub

    Private Sub ucrExplanatory_SelectionChanged(sender As Object, e As EventArgs) Handles ucrExplanatory.SelectionChanged

    End Sub

    Private Sub ucrResponse_SelectionChanged(sender As Object, e As EventArgs) Handles ucrResponse.SelectionChanged

    End Sub

    Private Sub cmdCommonIntercept_Click(sender As Object, e As EventArgs) Handles cmdCommonIntercept.Click
        operation = "/"
        TestOKEnabled()
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

    Private Sub ucrFamily_cboDistributionsIndexChanged(sender As Object, e As EventArgs) Handles ucrFamily.cboDistributionsIndexChanged
        'TODO: Include multinomial as an option and the appropriate function
        If (ucrFamily.clsCurrDistribution.strNameTag = "Normal") Then
            ucrBaseRegWithGroups.clsRsyntax.SetFunction("lm")
            ucrBaseRegWithGroups.clsRsyntax.RemoveParameter("family")
        Else
            ucrBaseRegWithGroups.clsRsyntax.SetFunction("glm")
            ucrBaseRegWithGroups.clsRsyntax.AddParameter("family", ucrFamily.clsCurrDistribution.strGLMFunctionName)
        End If
    End Sub
End Class