Imports instat
Imports instat.Translations
Public Class dlgWindPollutionRose
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsPollutionRose As New RFunction
    Private Sub dlgWindrose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        setRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        Dim dctSummary As New Dictionary(Of String, String)

        ucrWindPollutionRoseSelector.SetParameter(New RParameter("mydata", iNewPosition:=0))
        ucrWindPollutionRoseSelector.SetParameterIsrfunction()

        ucrReceiverWindSpeed.SetParameter(New RParameter("ws", iNewPosition:=1))
        ucrReceiverWindSpeed.SetParameterIsString()
        ucrReceiverWindSpeed.Selector = ucrWindPollutionRoseSelector
        ucrReceiverWindSpeed.strSelectorHeading = "Numerics"
        ucrReceiverWindSpeed.SetIncludedDataTypes({"numeric"})

        ucrReceiverWindDirection.SetParameter(New RParameter("wd", iNewPosition:=2))
        ucrReceiverWindDirection.SetParameterIsString()
        ucrReceiverWindDirection.Selector = ucrWindPollutionRoseSelector
        ucrReceiverWindDirection.strSelectorHeading = "Numerics"
        ucrReceiverWindDirection.SetIncludedDataTypes({"numeric"})

        ucrReceiverWindDirection2.SetParameter(New RParameter("wd2", iNewPosition:=3))
        ucrReceiverWindDirection2.SetParameterIsString()
        ucrReceiverWindDirection2.Selector = ucrWindPollutionRoseSelector
        ucrReceiverWindDirection2.strSelectorHeading = "Numerics"
        ucrReceiverWindDirection2.SetIncludedDataTypes({"numeric"})

        ucrReceiverWindSpeed2.SetParameter(New RParameter("ws2", iNewPosition:=4))
        ucrReceiverWindSpeed2.SetParameterIsString()
        ucrReceiverWindSpeed2.Selector = ucrWindPollutionRoseSelector
        ucrReceiverWindSpeed2.strSelectorHeading = "Numerics"
        ucrReceiverWindSpeed2.SetIncludedDataTypes({"numeric"})

        ucrChkCompare.SetText("Compare")
        ucrChkCompare.AddParameterPresentCondition(True, "wd2", True)

        ucrChkNormalise.SetText("Normalise")
        ucrChkNormalise.SetParameter(New RParameter("normalise", iNewPosition:=6), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=False)
        ucrChkNormalise.SetValuesCheckedAndUnchecked("TRUE", "FALSE")


        ucrChkPaddle.SetText("Paddle")
        ucrChkPaddle.bUpdateRCodeFromControl = True
        ucrChkPaddle.SetParameter(New RParameter("paddle", iNewPosition:=5), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=False)
        ucrChkPaddle.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrInputSummary.SetParameter(New RParameter("statistic", iNewPosition:=7))
        dctSummary.Add("Proportion", Chr(34) & "prop.count" & Chr(34))
        dctSummary.Add("Mean", Chr(34) & “prop.mean” & Chr(34))
        dctSummary.Add("Count", Chr(34) & “abs.count” & Chr(34))
        ucrInputSummary.SetItems(dctSummary)
        ucrInputSummary.SetDropDownStyleAsNonEditable()


        ucrInputSummary.SetLinkedDisplayControl(lblSummary)
        ucrReceiverWindDirection2.SetLinkedDisplayControl(lblWindDirection2)
        ucrReceiverWindSpeed2.SetLinkedDisplayControl(lblWindSpeed2)
        ucrChkCompare.AddToLinkedControls({ucrReceiverWindDirection2, ucrReceiverWindSpeed2}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveGraph.SetPrefix("windrose")
        ucrSaveGraph.SetDataFrameSelector(ucrWindPollutionRoseSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        ucrWindPollutionRoseSelector.Reset()
        ucrSaveGraph.Reset()
        ucrReceiverWindSpeed.SetMeAsReceiver()

        clsPollutionRose = New RFunction

        clsPollutionRose.SetPackageName("openair")
        clsPollutionRose.SetRCommand("pollutionRose")
        clsPollutionRose.AddParameter("paddle", "TRUE", iPosition:=5)
        clsPollutionRose.AddParameter("normalise", "FALSE", iPosition:=6)
        clsPollutionRose.AddParameter("statistic", Chr(34) & "prop.count" & Chr(34), iPosition:=7)
        clsPollutionRose.SetAssignTo(strTemp:="last_graph", strTempDataframe:=ucrWindPollutionRoseSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsPollutionRose)
    End Sub

    Private Sub setRCodeForControls(bReset As Boolean)
        ucrReceiverWindSpeed.SetRCode(clsPollutionRose, bReset)
        ucrReceiverWindDirection.SetRCode(clsPollutionRose, bReset)
        ucrReceiverWindDirection2.SetRCode(clsPollutionRose, bReset)
        ucrReceiverWindSpeed2.SetRCode(clsPollutionRose, bReset)
        ucrChkNormalise.SetRCode(clsPollutionRose, bReset)
        ucrChkPaddle.SetRCode(clsPollutionRose, bReset)
        ucrChkCompare.SetRCode(clsPollutionRose, bReset)
        ucrInputSummary.SetRCode(clsPollutionRose, bReset)
        ucrSaveGraph.SetRCode(clsPollutionRose, bReset)
        ucrWindPollutionRoseSelector.SetRCode(clsPollutionRose, bReset)
    End Sub
    Private Sub TestOkEnabled()
        If Not ucrReceiverWindSpeed.IsEmpty AndAlso Not ucrReceiverWindDirection.IsEmpty AndAlso ucrSaveGraph.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        setRCodeForControls(True)
        TestOkEnabled()
    End Sub


    Private Sub controlsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWindDirection.ControlValueChanged, ucrReceiverWindDirection2.ControlValueChanged, ucrReceiverWindSpeed.ControlValueChanged, ucrReceiverWindSpeed2.ControlValueChanged, ucrChkCompare.ControlValueChanged, ucrChkNormalise.ControlValueChanged, ucrChkPaddle.ControlValueChanged, ucrInputSummary.ControlValueChanged
        TestOkEnabled()
    End Sub
End Class