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
Imports RDotNet
Public Class dlgTwoVariableUseModel
    Private bFirstLoad As Boolean = True
    Public clsRModel, clsRCommand, clsRFormula As New RFunction
    Dim strModel As String

    Private Sub dlgTwoVariableUseModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReOpenDialog()
        End If
        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        ucrBaseUseModel.iHelpTopicID = 379
        ucrReceiverUseModel.SetMeAsReceiver()
        ucrSelectorUseModel.Reset()
        ucrModel.SetName("")
        cmdPredict.Enabled = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'Temporary fix: Bugs if you run the dialogue the second time
        ' sdgSimpleRegOptions.chkFittedModel.Enabled = False
        'autoplot function does not support glm/lm models
        '  sdgSimpleRegOptions.chkFittedModel.Enabled = False
        'ucrBase.iHelpTopicID = 
        ucrBaseUseModel.clsRsyntax.SetOperation("+")
        ucrReceiverUseModel.SetItemType("model")
        ucrReceiverUseModel.Selector = ucrSelectorUseModel
        clsRCommand.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_models")
        ucrBaseUseModel.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRCommand)
        ucrModel.IsReadOnly = True
        ' sdgSimpleRegOptions.SetRModelFunction(clsRCommand)
        sdgSimpleRegOptions.SetRDataFrame(ucrSelectorUseModel.ucrAvailableDataFrames)
        ucrReceiverUseModel.strSelectorHeading = "Models"
    End Sub

    Private Sub ReOpenDialog()

    End Sub

    Private Sub ucrBaseUseModel_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseUseModel.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrBaseUseModel_ClickOk(sender As Object, e As EventArgs) Handles ucrBaseUseModel.ClickOk
        sdgSimpleRegOptions.RegOptions()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverUseModel.IsEmpty Then
            ucrBaseUseModel.OKEnabled(True)
        Else
            ucrBaseUseModel.OKEnabled(False)
        End If
        Model()
    End Sub

    Private Sub Model()
        If Not ucrReceiverUseModel.IsEmpty And Not ucrSelectorUseModel.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = "" Then
            clsRFormula.SetRCommand("as.formula")
            clsRModel.SetRCommand("formula")
            clsRModel.AddParameter("x", clsRFunctionParameter:=clsRCommand)
            clsRFormula.AddParameter("", clsRFunctionParameter:=clsRModel)
            strModel = frmMain.clsRLink.RunInternalScriptGetOutput(clsRFormula.ToScript()).AsCharacter(0)
        Else
            strModel = ""
        End If
        ucrModel.SetName(strModel)
    End Sub

    Private Sub ucrModelReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverUseModel.SelectionChanged
        If Not ucrReceiverUseModel.IsEmpty Then
            clsRCommand.AddParameter("model_name", ucrReceiverUseModel.GetVariableNames())
        Else
            ucrBaseUseModel.clsRsyntax.RemoveParameter("model_name")
        End If
        TestOkEnabled()

    End Sub

    Private Sub ucrSelectorUseModel_DataFrameChanged() Handles ucrSelectorUseModel.DataFrameChanged
        clsRCommand.AddParameter("data_name", Chr(34) & ucrSelectorUseModel.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        TestOkEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.ShowDialog()
    End Sub

    Private Sub cmdPredict_Click(sender As Object, e As EventArgs) Handles cmdPredict.Click
        'this should lead to predict subdialogue
    End Sub
End Class