Imports instat
Imports instat.Translations
Public Class dlgTidy
    Public bfirstload As Boolean = True
    Public bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsRSyntax As RSyntax
    Private clsTidy, clsMap_df As New RFunction

    Private Sub dlgTidy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bfirstload Then
            InitialiseDialog()
            bfirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()

        ucrModelReceiver.SetItemType("model")
        ucrModelReceiver.strSelectorHeading = "Model"
        ucrModelReceiver.SetParameterIsRFunction()
        ucrModelReceiver.Selector = ucrModelSelector
        ucrModelReceiver.bForceVariablesAsList = True

        ucrPnlOptions.AddRadioButton(rdoDisplayInOutput)
        ucrPnlOptions.AddRadioButton(rdoNewDataFrame)

        ucrPnlOptions.bAllowNonConditionValues = True

        ucrPnlOptions.AddToLinkedControls(ucrSaveNewDataFrame, {rdoNewDataFrame}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)


        ucrModelSelector.SetParameter(New RParameter("data", 0))
        ucrModelSelector.SetParameterIsrfunction()

        ucrSaveNewDataFrame.SetSaveTypeAsDataFrame()
        ucrSaveNewDataFrame.lblSaveText.Visible = False
        ucrSaveNewDataFrame.SetLabelText("")
        ucrSaveNewDataFrame.SetDataFrameSelector(ucrModelSelector.ucrAvailableDataFrames)

        ucrModelReceiver.SetParameter(New RParameter(".x", 0))
        ucrModelReceiver.Selector = ucrModelSelector
        ucrModelReceiver.SetMeAsReceiver()
    End Sub

    Private Sub SetDefaults()
        clsMap_df = New RFunction

        ucrModelSelector.Reset()
        ucrSaveNewDataFrame.Reset()

        'tem fix
        rdoDisplayInOutput.Checked = True


        'todo implement as a function properly
        clsMap_df.SetPackageName("purrr")
        clsMap_df.SetRCommand("map_df")
        clsMap_df.AddParameter(strParameterName:=".f", strParameterValue:="broom::tidy", iPosition:=1)
        clsMap_df.AddParameter(strParameterName:=".id", strParameterValue:=Chr(34) & "model" & Chr(34))

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.SetBaseRFunction(clsMap_df)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrModelReceiver.SetRCode(clsMap_df, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If (rdoNewDataFrame.Checked AndAlso ucrSaveNewDataFrame.IsComplete AndAlso Not ucrModelReceiver.IsEmpty()) Then
            ucrBase.OKEnabled(True)
        ElseIf (rdoDisplayInOutput.Checked AndAlso Not ucrModelReceiver.IsEmpty()) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetDefaultNewDataFrameName()
        If ucrModelSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrSaveNewDataFrame.SetPrefix("tidy_" & ucrModelSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If rdoDisplayInOutput.Checked Then
            ucrBase.clsRsyntax.RemoveAssignTo()
            ucrBase.clsRsyntax.iCallType = 2
        ElseIf rdoNewDataFrame.Checked Then
            clsMap_df.SetAssignTo(ucrModelSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempDataframe:=ucrSaveNewDataFrame.GetText)
            ucrBase.clsRsyntax.iCallType = 0
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged() Handles ucrModelReceiver.ControlContentsChanged, ucrSaveNewDataFrame.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrModelSelector_DataFrameChanged() Handles ucrModelSelector.DataFrameChanged
        SetDefaultNewDataFrameName()
    End Sub
End Class
