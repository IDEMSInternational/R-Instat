
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

        ucrSaveNewDataFrame.SetPrefix("Newdataframe")
        ucrSaveNewDataFrame.SetIsComboBox()
        ucrSaveNewDataFrame.SetSaveTypeAsModel()
        ucrSaveNewDataFrame.SetCheckBoxText("Save New data frame")
        ucrSaveNewDataFrame.SetAssignToIfUncheckedValue("Last_Model")
        ucrSaveNewDataFrame.SetDataFrameSelector(ucrModelSelector.ucrAvailableDataFrames)
        ucrSaveNewDataFrame.ucrChkSave.Checked = False

        ucrModelReceiver.SetParameter(New RParameter("x", 0))
        ucrModelReceiver.Selector = ucrModelSelector
        ucrModelReceiver.SetMeAsReceiver()


    End Sub

    Private Sub SetDefaults()

        ucrSaveNewDataFrame.Reset()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 2
        clsAugment.SetRCommand("augment")
        clsAugment.SetPackageName("broom")
        ucrBase.clsRsyntax.SetBaseRFunction(clsAugment)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveNewDataFrame.SetRCode(ucrBase.clsRsyntax.clsBaseCommandString, bReset)
        ucrModelReceiver.SetRCode(clsAugment, bReset)
    End Sub

    Private Sub TestOKEnabled()
        'Tests when ok can be enabled
        If ucrModelReceiver.IsEmpty OrElse Not ucrSaveNewDataFrame.IsComplete Then
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

    Private Sub CoreControls_ControlContentsChanged() Handles ucrModelReceiver.ControlContentsChanged, ucrSaveNewDataFrame.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class