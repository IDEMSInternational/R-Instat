Public Class dlgSPI
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSpiFunction As New RFunction

    Private Sub dlgSPI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On first load we initialise the dialog
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
            'If resetting, we set the defaults
            If bReset Then
                SetDefaults()
            End If
            'We always set the R code for the controls. This sub updates the values of the dialog controls so that they in sync with the values in the RFunction.
            SetRCodeForControls(bReset)
            bReset = False
            'We always translate the dialog in case the language has been changed
            'autoTranslate(Me)
            'We finally test and set the Ok button to be enabled or disabled.
            TestOkEnabled()
        End If
    End Sub
    Private Sub InitialiseDialog()

        ucrReceiverSpiDate.SetParameter(New RParameter("data_name", 0))
        ucrReceiverSpiDate.SetParameterIsRFunction()
        ucrReceiverSpiDate.bForceAsDataFrame = True
        ucrReceiverSpiDate.Selector = ucrSelectorSpi

        ucrNudTimeScale.SetParameter(New RParameter("time_Scale", 1))
        ucrNudTimeScale.SetMinMax(1, 24)
        ucrNudTimeScale.Increment = 1

        'Sets the help page ID for the dialog
        'We don’t know this yet for our dialog so we comment out the line
        'ucrBaseDescribeOneVar.iHelpTopicID =

        'This sets the type of output for our function that will be displayed in the output window. 2 indicates that there will be text output.
        ' clsRsyntax manages the R script that the dialog will run.
        ucrBase.clsRsyntax.iCallType = 2
    End Sub
    Private Sub SetDefaults()
        'Resets the summary function so that all previous information is cleared
        clsSpiFunction = New RFunction

        'Resets the selector so that the current data frame in the spreadsheet is selected by default.
        ucrSelectorSpi.Reset()

        'Sets the name of the R command for our function.
        clsSpiFunction.SetPackageName("spei")
        clsSpiFunction.SetRCommand("spei")
        'Adds any default parameters to our function.

        'Sets the main (base) R command of the R syntax, meaning that clsSpiFunction is the main function this dialog will run.
        ucrBase.clsRsyntax.SetBaseRFunction(clsSpiFunction)
        TestOkEnabled()
    End Sub
    'The links the controls on the dialog to the RFunctions the dialog will run. During the linking process, the controls will read the RFunction that it has been assigned and update its value based on the value so that the RFunctions stored in the dialog are in sync with the values the control displays on the dialog to the user.
    'In this example, we only have one control which links to a parameter in the function.
    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    'Enables/disables Ok depending on whether the required information is complete on the dialog.
    'In our example, if the receiver is not empty, Ok can be clicked.
    Private Sub TestOkEnabled()
        If ucrReceiverSpiDate.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    'This handles the ClickReset event of ucrBase, which is triggered when the Reset button is clicked. Here we set the defaults, set the R code for the controls and run TestOKEnabled().
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    'This handles the ControlContentsChanged event of ucrSummaryTestReceiver. This event is triggered when the contents of the receiver control changes in any way. Which is why it is necessary to run TestOKEnabled() on this event.
    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSpiDate.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class