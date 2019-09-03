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
Imports instat.Translations

Public Class dlgUseModel
    Public bFirstLoad As Boolean = True
    Public bReset As Boolean = True
    Public bUpdating As Boolean = False

    Private Sub dlgUseModelLoad(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOkEnabled()
        SetRcodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverForTestColumn.Selector = ucrSelectorUseModel
        ucrReceiverForTestColumn.SetParameterIsRFunction()
        ucrReceiverForTestColumn.SetItemType("model")
        ucrReceiverForTestColumn.strSelectorHeading = "Models"
        ucrReceiverForTestColumn.Selector = ucrSelectorUseModel
        ucrReceiverForTestColumn.SetMeAsReceiver()

        ucrInputComboRPackage.SetItems({"General", "Prediction", "extRemes"})
        ucrInputComboRPackage.SetDropDownStyleAsNonEditable()

        ucrInputTryMessage.Hide()

        cmdTry.Hide()

        ucrInputModels.IsReadOnly = True

        bUpdating = False
    End Sub

    Private Sub SetDefaults()
        ' ucrBase.iHelpTopicID = 379

        ucrSelectorUseModel.Reset()

        ucrReceiverForTestColumn.SetMeAsReceiver()
        ucrReceiverForTestColumn.Clear()

        ucrInputComboRPackage.SetName("General")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetCommandString("")
        ucrBase.clsRsyntax.iCallType = 2
        KeyboardsVisibility()
        GetModels()
        TestOkEnabled()
    End Sub

    Private Sub SetRcodeForControls(bReset As Object)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverForTestColumn.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub cmdsummary_Click(sender As Object, e As EventArgs) Handles cmdsummary.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("summary()", 1)
    End Sub

    Private Sub cmdanova_Click(sender As Object, e As EventArgs) Handles cmdanova.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("anova()", 1)
    End Sub

    Private Sub cmdresiduals_Click(sender As Object, e As EventArgs) Handles cmdresiduals.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("residuals()", 1)
    End Sub

    Private Sub cmdPredict_Click(sender As Object, e As EventArgs) Handles cmdPredict.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("prediction::prediction()", 1)
    End Sub

    Private Sub Clear()
        ucrReceiverForTestColumn.Clear()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrInputComboRPackage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboRPackage.ControlValueChanged
        KeyboardsVisibility()
    End Sub

    Private Sub KeyboardsVisibility()
        grpGeneral.Visible = False
        grpPrediction.Visible = False
        grpExtrRemes.Visible = False
        Select Case ucrInputComboRPackage.GetText
            Case "General"
                grpGeneral.Visible = True
            Case "Prediction"
                grpPrediction.Visible = True
            Case "extRemes"
                grpExtrRemes.Visible = True
        End Select
    End Sub

    Private Sub ucrReceiverForTestColumn_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForTestColumn.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverForTestColumn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForTestColumn.ControlValueChanged
        ucrBase.clsRsyntax.SetCommandString(ucrReceiverForTestColumn.GetVariableNames(False))
        GetModels()
    End Sub

    Private Sub GetModels()
        Dim clsGetModel As New RFunction
        Dim strExpression As String
        Dim lstModels As New List(Of String)
        Dim i As Integer = 0
        Dim strModel As String
        Dim item As ListViewItem

        ucrBase.clsRsyntax.lstBeforeCodes.Clear()
        clsGetModel.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_models")
        ucrInputModels.SetName("[No models selected]")
        strExpression = ucrReceiverForTestColumn.GetVariableNames(False)
        For Each item In ucrSelectorUseModel.lstAvailableVariable.Items
            strModel = item.Text
            If strExpression.Contains(strModel) Then
                lstModels.Add(strModel)
                clsGetModel.AddParameter("data_name", Chr(34) & ucrSelectorUseModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
                clsGetModel.AddParameter("model_name", Chr(34) & strModel & Chr(34), iPosition:=1)
                clsGetModel.SetAssignTo(strModel)
                ucrBase.clsRsyntax.AddToBeforeCodes(clsGetModel.Clone(), iPosition:=i)
                i = i + 1
            End If
        Next
        If i > 0 Then
            ucrInputModels.SetName(String.Join(", ", lstModels))
        End If
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("print()", 1)
    End Sub

    Private Sub cmdCoefficient_Click(sender As Object, e As EventArgs) Handles cmdCoefficient.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coefficients()", 1)
    End Sub

    Private Sub cmdAIC_Click(sender As Object, e As EventArgs) Handles cmdAIC.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("AIC()", 1)
    End Sub

    Private Sub cmdBIC_Click(sender As Object, e As EventArgs) Handles cmdBIC.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("BIC()", 1)
    End Sub

    Private Sub cmdOutlierTest_Click(sender As Object, e As EventArgs) Handles cmdOutlierTest.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("car::outlierTest()", 1)
    End Sub

    Private Sub cmdNcvTest_Click(sender As Object, e As EventArgs) Handles cmdNcvTest.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("car::ncvTest()", 1)
    End Sub

    Private Sub cmdDurbinWatsonTest_Click(sender As Object, e As EventArgs) Handles cmdDurbinWatsonTest.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("car:: durbinWatsonTest()", 1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("car::Anova()", 1)
    End Sub

    Private Sub cmdCi_Click(sender As Object, e As EventArgs) Handles cmdCi.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::ci.fevd()", 1)

    End Sub

    Private Sub cmdDistill_Click(sender As Object, e As EventArgs) Handles cmdDistill.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::distill.fevd()", 1)

    End Sub

    Private Sub cmdErlevd_Click(sender As Object, e As EventArgs) Handles cmdErlevd.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::erlevd()", 1)

    End Sub

    Private Sub cmdFindpars_Click(sender As Object, e As EventArgs) Handles cmdFindpars.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::findpars()", 1)

    End Sub

    Private Sub cmdIsFixedfevd_Click(sender As Object, e As EventArgs) Handles cmdIsFixedfevd.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::is.fixedfevd()", 1)

    End Sub

    Private Sub cmdLrTest_Click(sender As Object, e As EventArgs) Handles cmdLrTest.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::lr.test()", 1)

    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverForTestColumn.Clear()
    End Sub
End Class