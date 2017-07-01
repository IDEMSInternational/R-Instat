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
Imports instat
Imports instat.Translations
Public Class dlgShowModel
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private clsProbabilities, clsQuantiles As New RFunction
    Private Sub dlgTablePlus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 157
        ucrReceiverExpressionForTablePlus.Selector = ucrSelectorForDataFrame
        ucrReceiverExpressionForTablePlus.SetMeAsReceiver()
        ucrReceiverExpressionForTablePlus.SetIncludedDataTypes({"numeric"})

        ucrPnlDistTypes.AddRadioButton(rdoProbabilities)
        ucrPnlDistTypes.AddRadioButton(rdoQuantiles)

        ucrPnlDistTypes.AddFunctionNamesCondition(rdoQuantiles, "qdist")
        ucrPnlDistTypes.AddFunctionNamesCondition(rdoProbabilities, "pdist")

        ucrSaveGraphResults.SetPrefix("Quant")
        ucrSaveGraphResults.SetSaveTypeAsGraph()
        ucrSaveGraphResults.SetIsComboBox()
        ucrSaveGraphResults.SetDataFrameSelector(ucrSelectorForDataFrame.ucrAvailableDataFrames)
        ucrSaveGraphResults.SetCheckBoxText("Save Graph  Result:")
        ucrSaveGraphResults.SetAssignToIfUncheckedValue("last_graph")

        ucrInputProbabilities.SetParameter(New RParameter("p", 1))
        ucrInputProbabilities.AddQuotesIfUnrecognised = False
        ucrInputProbabilities.SetValidationTypeAsNumericList()

        ucrReceiverExpressionForTablePlus.SetParameter(New RParameter("p", 1))
        ucrReceiverExpressionForTablePlus.SetParameterIsRFunction()

        ucrDistributionsFOrTablePlus.SetRDistributions()
        ucrDistributionsFOrTablePlus.SetParameters()

        ucrChkEnterValues.SetText("Enter value(s)")
        ucrChkDisplayGraphResults.SetParameter(New RParameter("plot", 2), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkDisplayGraphResults.SetRDefault("TRUE")
        ucrChkDisplayGraphResults.SetText("Display Graph Results")

        ucrChkEnterValues.AddToLinkedControls(ucrReceiverExpressionForTablePlus, {False}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEnterValues.AddToLinkedControls(ucrInputProbabilities, {True}, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=0.5)
        ucrChkEnterValues.AddParameterIsRFunctionCondition(False, "q", True)
        ucrChkEnterValues.AddParameterIsRFunctionCondition(False, "p", True)
        ucrChkEnterValues.AddParameterIsRFunctionCondition(True, "q", False)
        ucrChkEnterValues.AddParameterIsRFunctionCondition(True, "p", False)
    End Sub

    Private Sub SetDefaults()

        clsQuantiles = New RFunction
        clsProbabilities = New RFunction

        ucrSelectorForDataFrame.Reset()
        ucrInputProbabilities.Reset()
        ucrSaveGraphResults.Reset()

        clsProbabilities.SetPackageName("mosaic")
        clsQuantiles.SetPackageName("mosaic")

        receiverlabels()

        SetItems()
        DisplayTableResults()

        ResetFunctions()
        clsProbabilities.SetRCommand("pdist")
        clsQuantiles.SetRCommand("qdist")

        clsQuantiles.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorForDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.SetBaseRFunction(clsQuantiles)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverExpressionForTablePlus.AddAdditionalCodeParameterPair(clsProbabilities, New RParameter("q", 1), 1)
        ucrInputProbabilities.AddAdditionalCodeParameterPair(clsProbabilities, New RParameter("q", 1), 1)
        ucrChkDisplayGraphResults.AddAdditionalCodeParameterPair(clsProbabilities, ucrChkDisplayGraphResults.GetParameter, 1)
        ucrPnlDistTypes.SetRCode(clsQuantiles, bReset)
        ucrReceiverExpressionForTablePlus.SetRCode(clsQuantiles, bReset)
        ucrChkDisplayGraphResults.SetRCode(clsQuantiles, bReset)
        ucrInputProbabilities.SetRCode(clsQuantiles, bReset)
        ucrSaveGraphResults.AddAdditionalRCode(clsProbabilities, 1)
        ucrSaveGraphResults.SetRCode(clsQuantiles, bReset)
        ucrDistributionsFOrTablePlus.SetRCode(clsQuantiles, bReset)
        ucrChkEnterValues.SetRCode(clsQuantiles, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrDistributionsFOrTablePlus.bParametersFilled Then
            If ((Not ucrReceiverExpressionForTablePlus.IsEmpty) OrElse (Not ucrInputProbabilities.IsEmpty)) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub


    Private Sub SetItems()
        If rdoProbabilities.Checked Then
            ucrInputProbabilities.SetItems({"1", "0.1, 1, 3, 5, 10 ", "-2, -1, 0, 1, 2"})
            ucrInputProbabilities.SetName("1")
        Else
            ucrInputProbabilities.SetItems({"0.5", "0.1, 0.2, 0.4, 0.6, 0.8, 0.9 ", "0.2, 0.5, 0.8", " 0.5, 0.8, 0.9, 0.95, 0.99"})
            ucrInputProbabilities.SetName("0.5")
        End If
    End Sub

    Private Sub SetNewColumName()
        If rdoProbabilities.Checked Then
            If Not ucrSaveGraphResults.bUserTyped Then
                ucrSaveGraphResults.SetPrefix("Prob")
            End If
        Else
            If Not ucrSaveGraphResults.bUserTyped Then
                ucrSaveGraphResults.SetPrefix("Quant")
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub PqParameters()
        If rdoProbabilities.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsProbabilities)
            clsProbabilities.AddParameter("q", "c(" & ucrInputProbabilities.GetText & ")")
            clsQuantiles.RemoveParameterByName("p")
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsQuantiles)
            clsQuantiles.AddParameter("p", "c(" & ucrInputProbabilities.GetText & ")")
            clsProbabilities.RemoveParameterByName("q")
        End If
    End Sub

    Private Sub receiverlabels()
        If rdoProbabilities.Checked Then
            clsProbabilities.ClearParameters()
            clsProbabilities.AddParameter("dist", Chr(34) & ucrDistributionsFOrTablePlus.clsCurrDistribution.strRName & Chr(34))
            PqParameters()
            For Each clstempparam In ucrDistributionsFOrTablePlus.clsCurrRFunction.clsParameters
                clsProbabilities.AddParameter(clstempparam.Clone())
            Next
        Else
            clsQuantiles.ClearParameters()
            clsQuantiles.AddParameter("dist", Chr(34) & ucrDistributionsFOrTablePlus.clsCurrDistribution.strRName & Chr(34))
            PqParameters()
            For Each clstempparam In ucrDistributionsFOrTablePlus.clsCurrRFunction.clsParameters
                clsQuantiles.AddParameter(clstempparam.Clone())
            Next
        End If
    End Sub

    Private Sub ucrDistributionsFOrTablePlus_ParameterChanged() Handles ucrDistributionsFOrTablePlus.ControlValueChanged, ucrDistributionsFOrTablePlus.DistributionsIndexChanged
        receiverlabels()
        TestOKEnabled()
    End Sub

    Private Sub ucrChkEnterValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEnterValues.ControlValueChanged
        ResetFunctions()
        DisplayTableResults()
    End Sub

    Private Sub ResetFunctions()
        If ucrChkEnterValues.Checked Then
            ucrSelectorForDataFrame.SetVariablesVisible(False)
            ucrSelectorForDataFrame.Reset()
            SetName()
        Else
            ucrSelectorForDataFrame.SetVariablesVisible(True)
            ucrInputProbabilities.ResetText()
        End If
    End Sub

    Private Sub SetName()
        If rdoProbabilities.Checked Then
            ucrInputProbabilities.SetName("1")
        Else
            ucrInputProbabilities.SetName("0.5")
        End If
    End Sub

    Private Sub DisplayTableResults()
        If ucrChkDisplayGraphResults.Checked Then
            ucrBase.clsRsyntax.iCallType = 3
        Else
            If ucrChkEnterValues.Checked Then
            Else
                ucrBase.clsRsyntax.iCallType = 2
            End If
        End If
    End Sub

    Private Sub ucrChkDisplayGraphResults_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayGraphResults.ControlValueChanged
        DisplayTableResults()
    End Sub

    Private Sub ucrDistributionsFOrTablePlus_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrDistributionsFOrTablePlus.ControlContentsChanged
        receiverlabels()
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlDistTypes_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlDistTypes.ControlContentsChanged
        SetItems()
        SetName()
        SetNewColumName()
    End Sub

    Private Sub ucrPnlDistTypes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDistTypes.ControlValueChanged
        receiverlabels()
    End Sub

    Private Sub ucrInputProbabilities_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputProbabilities.ControlValueChanged
        PqParameters()
    End Sub

    Private Sub ucrReceiverExpressionForTablePlus_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverExpressionForTablePlus.ControlContentsChanged, ucrInputProbabilities.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class