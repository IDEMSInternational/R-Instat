
Imports instat
Imports instat.Translations
Public Class dlgAugment
    Public bfirstload As Boolean = True
    Public bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsRSyntax As RSyntax
    Private clsAugment As New RFunction

    Private Sub dlgTidy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
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
    End Sub

    Private Sub InitialiseDialog()

        ucrModelReceiver.SetItemType("model")
        ucrModelReceiver.strSelectorHeading = "Model"
        ucrModelReceiver.SetParameterIsRFunction()
        ucrModelReceiver.Selector = ucrModelSelector

        ucrChkDisplayInOutput.SetText("Display in Output")
        ucrChkDisplayInOutput.Checked = True

        ucrModelSelector.SetParameter(New RParameter("data", 0))
        ucrModelSelector.SetParameterIsrfunction()

        ucrSaveDataFrame.SetPrefix("Newdataframe")
        ucrSaveDataFrame.SetIsComboBox()
        ucrSaveDataFrame.SetSaveTypeAsModel()
        ucrSaveDataFrame.SetCheckBoxText("SaveNewdataframe")
        ucrSaveDataFrame.SetAssignToIfUncheckedValue("dataframe")
        ucrSaveDataFrame.SetDataFrameSelector(ucrModelSelector.ucrAvailableDataFrames)
        ucrSaveDataFrame.ucrChkSave.Checked = False

        ucrModelReceiver.SetParameter(New RParameter("x", 0))
        ucrModelReceiver.Selector = ucrModelSelector
        ucrModelReceiver.SetMeAsReceiver()


    End Sub

    Private Sub SetDefaults()
        clsAugment = New RFunction
        ucrModelSelector.Reset()
        ucrSaveDataFrame.Reset()
        clsAugment.SetRCommand("augment")
        clsAugment.SetPackageName("broom")
        ucrBase.clsRsyntax.SetBaseRFunction(clsAugment)
        UpdateAssignTo()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveDataFrame.SetRCode(ucrBase.clsRsyntax.clsBaseCommandString, bReset)
        ucrModelReceiver.SetRCode(clsAugment, bReset)
        UpdateAssignTo()
    End Sub

    Private Sub TestOKEnabled()
        'Tests when ok can be enabled
        If ucrModelReceiver.IsEmpty AndAlso ucrSaveDataFrame.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub CoreControls_ControlContentsChanged() Handles ucrModelReceiver.ControlContentsChanged, ucrSaveDataFrame.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub UpdateAssignTo()
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:="augment_data", strTempDataframe:=ucrModelSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
    End Sub

    Private Sub ucrChkDisplayInOutput_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayInOutput.ControlValueChanged
        If ucrChkDisplayInOutput.Checked Then
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        Else
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
        End If
    End Sub
End Class