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


Imports instat.Translations
Public Class dlgShowModel
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private clsProbabilitiesFunction As New RFunction
    Private clsQuantilesFunction As New RFunction
    Private clsConcatenateFunction As New RFunction

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

        ucrSaveGraph.SetPrefix("Quant")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorForDataFrame.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

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
        ucrChkDisplayGraphResults.AddToLinkedControls(ucrSaveGraph, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEnterValues.AddParameterIsRFunctionCondition(False, "q", True)
        ucrChkEnterValues.AddParameterIsRFunctionCondition(False, "p", True)
        ucrChkEnterValues.AddParameterIsRFunctionCondition(True, "q", False)
        ucrChkEnterValues.AddParameterIsRFunctionCondition(True, "p", False)
    End Sub

    Private Sub SetDefaults()
        clsQuantilesFunction = New RFunction
        clsProbabilitiesFunction = New RFunction
        clsConcatenateFunction = New RFunction

        ucrSelectorForDataFrame.Reset()
        ucrInputProbabilities.Reset()
        ucrSaveGraph.Reset()

        clsProbabilitiesFunction.SetPackageName("mosaic")
        clsQuantilesFunction.SetPackageName("mosaic")

        clsProbabilitiesFunction.SetRCommand("pdist")
        clsQuantilesFunction.SetRCommand("qdist")

        clsConcatenateFunction.SetRCommand("c")

        clsQuantilesFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorForDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph", bAssignToIsPrefix:=True)

        ucrBase.clsRsyntax.SetBaseRFunction(clsQuantilesFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverExpressionForTablePlus.AddAdditionalCodeParameterPair(clsProbabilitiesFunction, New RParameter("q", 1), 1)
        ucrInputProbabilities.AddAdditionalCodeParameterPair(clsProbabilitiesFunction, New RParameter("q", 1), 1)
        ucrChkDisplayGraphResults.AddAdditionalCodeParameterPair(clsProbabilitiesFunction, ucrChkDisplayGraphResults.GetParameter, 1)
        ucrPnlDistTypes.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverExpressionForTablePlus.SetRCode(clsQuantilesFunction, bReset)
        ucrChkDisplayGraphResults.SetRCode(clsQuantilesFunction, bReset)
        ucrInputProbabilities.SetRCode(clsConcatenateFunction, bReset)
        If bReset Then
            ucrSaveGraph.AddAdditionalRCode(clsProbabilitiesFunction, 1)
            ucrSaveGraph.SetRCode(clsQuantilesFunction, bReset)
        End If
        ucrDistributionsFOrTablePlus.SetRCode(clsQuantilesFunction, bReset)
        ucrChkEnterValues.SetRCode(clsQuantilesFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrDistributionsFOrTablePlus.bParametersFilled Then
            If ((Not ucrReceiverExpressionForTablePlus.IsEmpty) OrElse (Not ucrInputProbabilities.IsEmpty)) AndAlso ucrSaveGraph.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub PqParameters()
        If rdoProbabilities.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsProbabilitiesFunction)
            clsProbabilitiesFunction.AddParameter("q", "c(" & ucrInputProbabilities.GetText & ")", iPosition:=1)
            clsQuantilesFunction.RemoveParameterByName("p")
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsQuantilesFunction)
            clsQuantilesFunction.AddParameter("p", "c(" & ucrInputProbabilities.GetText & ")", iPosition:=1)
            clsProbabilitiesFunction.RemoveParameterByName("q")
        End If
    End Sub

    Private Sub receiverlabels()
        If rdoProbabilities.Checked Then
            clsProbabilitiesFunction.ClearParameters()
            clsProbabilitiesFunction.AddParameter("dist", Chr(34) & ucrDistributionsFOrTablePlus.clsCurrDistribution.strRName & Chr(34))
            PqParameters()
            For Each clstempparam In ucrDistributionsFOrTablePlus.clsCurrRFunction.clsParameters
                clsProbabilitiesFunction.AddParameter(clstempparam.Clone())
            Next
        Else
            clsQuantilesFunction.ClearParameters()
            clsQuantilesFunction.AddParameter("dist", Chr(34) & ucrDistributionsFOrTablePlus.clsCurrDistribution.strRName & Chr(34))
            PqParameters()
            For Each clstempparam In ucrDistributionsFOrTablePlus.clsCurrRFunction.clsParameters
                clsQuantilesFunction.AddParameter(clstempparam.Clone())
            Next
        End If
    End Sub

    Private Sub ucrDistributionsFOrTablePlus_ParameterChanged() Handles ucrDistributionsFOrTablePlus.ControlValueChanged, ucrDistributionsFOrTablePlus.DistributionsIndexChanged
        receiverlabels()
    End Sub

    Private Sub ucrChkEnterValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEnterValues.ControlValueChanged
        If ucrChkEnterValues.Checked Then
            ucrSelectorForDataFrame.SetVariablesVisible(False)
            ucrSelectorForDataFrame.Reset()
        Else
            ucrSelectorForDataFrame.SetVariablesVisible(True)
            ucrInputProbabilities.ResetText()
        End If
    End Sub

    Private Sub ucrChkDisplayGraphResults_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayGraphResults.ControlValueChanged
        If ucrChkDisplayGraphResults.Checked Then
            ucrBase.clsRsyntax.iCallType = 3
        Else
            ucrBase.clsRsyntax.iCallType = 2
        End If
    End Sub

    Private Sub ucrDistributionsFOrTablePlus_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrDistributionsFOrTablePlus.ControlContentsChanged
        receiverlabels()
    End Sub

    Private Sub ucrPnlDistTypes_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlDistTypes.ControlContentsChanged
        If rdoProbabilities.Checked Then
            If ucrChkDisplayGraphResults.Checked AndAlso Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("prob")
            End If
            ucrInputProbabilities.SetItems({"1", "0.1, 1, 3, 5, 10 ", "-2, -1, 0, 1, 2"})
            ucrInputProbabilities.SetName("1")
            lblProbValues.Visible = False
            lblQuantValues.Visible = True
        Else
            If ucrChkDisplayGraphResults.Checked AndAlso Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("quant")
            End If
            ucrInputProbabilities.SetItems({"0.5", "0.1, 0.2, 0.4, 0.6, 0.8, 0.9 ", "0.2, 0.5, 0.8", " 0.5, 0.8, 0.9, 0.95, 0.99"})
            ucrInputProbabilities.SetName("0.5")
            lblQuantValues.Visible = False
            lblProbValues.Visible = True
        End If
    End Sub

    Private Sub ucrPnlDistTypes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDistTypes.ControlValueChanged
        receiverlabels()
    End Sub

    Private Sub ucrInputProbabilities_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputProbabilities.ControlValueChanged
        PqParameters()
    End Sub

    Private Sub ucrReceiverExpressionForTablePlus_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverExpressionForTablePlus.ControlContentsChanged, ucrInputProbabilities.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class