Imports instat

Public Class dlgUseModel
    Public bFirstLoad As Boolean = True
    Public bReset As Boolean = True
    Public bUpdating As Boolean = False
    Public clsSummaryFunction
    Public clsRcommand As New RFunction

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

    Private Sub autoTranslate(dlgUseModel As dlgUseModel)

    End Sub

    Private Sub SetRcodeForControls(bReset As Object)
        clsSummaryFunction = New RFunction
        ucrBase.clsRsyntax.ClearCodes()

        bUpdating = True
        ucrSelectorUseModel.Reset()

        ucrBase.clsRsyntax.SetCommandString("")
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("summary()", 1)
        ucrReceiverForTestColumn.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model", strTempDataframe:=ucrSelectorUseModel.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 2

        ucrInputComboRPackage.SetName("stats")

        clsSummaryFunction = clsRegressionDefaults.clsDefaultSummary.Clone
        clsSummaryFunction.iCallType = 2
        ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, 2)

    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverForTestColumn.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        ' ucrBase.iHelpTopicID = 379
        ucrReceiverForTestColumn.SetMeAsReceiver()
        ucrSelectorUseModel.Reset()
        ucrInputComboRPackage.SetName("general")

        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")

        ucrReceiverForTestColumn.Selector = ucrSelectorUseModel
        clsRcommand.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_models")
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRcommand)

        ucrReceiverForTestColumn.SetParameterIsRFunction()
        ucrReceiverForTestColumn.SetItemType("model")
        ucrReceiverForTestColumn.strSelectorHeading = "Models"
        ucrReceiverForTestColumn.Selector = ucrSelectorUseModel
        ucrReceiverForTestColumn.SetMeAsReceiver()

        ucrInputComboRPackage.SetItems({"general", "prediction", "extRemes", "circular"})
        ucrInputComboRPackage.SetDropDownStyleAsNonEditable()

        bUpdating = False
    End Sub


    Private Sub cmdsummary_Click(sender As Object, e As EventArgs) Handles cmdsummary.Click
        Clear()
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("stats::summary()", 1)
    End Sub

    Private Sub cmdanova_Click(sender As Object, e As EventArgs) Handles cmdanova.Click
        Clear()
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("stats::anova()", 1)
    End Sub

    Private Sub cmdresiduals_Click(sender As Object, e As EventArgs) Handles cmdresiduals.Click
        Clear()
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("stats::residuals()", 1)
    End Sub

    Private Sub cmdPredict_Click(sender As Object, e As EventArgs) Handles cmdPredict.Click
        Clear()
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
        Select Case ucrInputComboRPackage.GetText
            Case "general"
                grpgeneral.Visible = True
                grpPrediction.Visible = False
            Case "prediction"
                grpgeneral.Visible = False
                grpPrediction.Visible = True
            Case "extRemes"
                grpgeneral.Visible = False
                grpPrediction.Visible = False
            Case "circular"
                grpgeneral.Visible = False
                grpPrediction.Visible = False
        End Select
    End Sub
End Class