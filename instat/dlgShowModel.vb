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
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrReceiverProbabilitiesOrValues.Selector = ucrSelectorShowModel
        ucrReceiverProbabilitiesOrValues.SetMeAsReceiver()
        ucrReceiverProbabilitiesOrValues.SetIncludedDataTypes({"numeric"})

        ucrPnlDistributionType.AddRadioButton(rdoProbabilities)
        ucrPnlDistributionType.AddRadioButton(rdoQuantiles)

        ucrPnlDistributionType.AddFunctionNamesCondition(rdoQuantiles, "qdist")
        ucrPnlDistributionType.AddFunctionNamesCondition(rdoProbabilities, "pdist")

        ucrSaveGraph.SetPrefix("quant")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorShowModel.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrInputProbabilities.SetParameter(New RParameter("p", 1))
        ucrInputProbabilities.AddQuotesIfUnrecognised = False
        ucrInputProbabilities.SetValidationTypeAsNumericList()

        ucrReceiverProbabilitiesOrValues.SetParameter(New RParameter("p", 1))
        ucrReceiverProbabilitiesOrValues.SetParameterIsRFunction()

        ucrDistributionAndParameters.SetParameters()

        ucrChkEnterValues.SetText("Enter value(s)")

        ucrChkDisplayGraphResults.SetParameter(New RParameter("plot", 2))
        ucrChkDisplayGraphResults.SetRDefault("TRUE")
        ucrChkDisplayGraphResults.SetText("Display Graph Results")

        ucrChkEnterValues.AddToLinkedControls(ucrReceiverProbabilitiesOrValues, {False}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEnterValues.AddToLinkedControls(ucrInputProbabilities, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.5)
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

        ucrSelectorShowModel.Reset()
        ucrInputProbabilities.Reset()
        ucrSaveGraph.Reset()
        ucrDistributionAndParameters.SetRDistributions()

        clsProbabilitiesFunction.SetPackageName("mosaic")
        clsQuantilesFunction.SetPackageName("mosaic")

        clsProbabilitiesFunction.SetRCommand("pdist")
        clsQuantilesFunction.SetRCommand("qdist")

        clsConcatenateFunction.SetRCommand("c")

        clsQuantilesFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorShowModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph", bAssignToIsPrefix:=True)

        ucrBase.clsRsyntax.SetBaseRFunction(clsQuantilesFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverProbabilitiesOrValues.AddAdditionalCodeParameterPair(clsProbabilitiesFunction, New RParameter("q", 1), 1)
        ucrInputProbabilities.AddAdditionalCodeParameterPair(clsProbabilitiesFunction, New RParameter("q", 1), 1)
        ucrChkDisplayGraphResults.AddAdditionalCodeParameterPair(clsProbabilitiesFunction, ucrChkDisplayGraphResults.GetParameter, 1)
        ucrPnlDistributionType.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverProbabilitiesOrValues.SetRCode(clsQuantilesFunction, bReset)
        ucrChkDisplayGraphResults.SetRCode(clsQuantilesFunction, bReset)
        ucrInputProbabilities.SetRCode(clsConcatenateFunction, bReset)
        If bReset Then
            ucrSaveGraph.AddAdditionalRCode(clsProbabilitiesFunction, 1)
            ucrSaveGraph.SetRCode(clsQuantilesFunction, bReset)
        End If
        ucrDistributionAndParameters.SetRCode(clsQuantilesFunction, bReset)
        ucrChkEnterValues.SetRCode(clsQuantilesFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrDistributionAndParameters.bParametersFilled Then
            If ((Not ucrReceiverProbabilitiesOrValues.IsEmpty) OrElse (Not ucrInputProbabilities.IsEmpty)) AndAlso ucrSaveGraph.IsComplete Then
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

    Private Sub AddRemovePandQParameters()
        If rdoProbabilities.Checked Then
            clsProbabilitiesFunction.AddParameter("q", "c(" & ucrInputProbabilities.GetText & ")", iPosition:=1)
            clsQuantilesFunction.RemoveParameterByName("p")
        Else
            clsQuantilesFunction.AddParameter("p", "c(" & ucrInputProbabilities.GetText & ")", iPosition:=1)
            clsProbabilitiesFunction.RemoveParameterByName("q")
        End If
    End Sub

    Private Sub UpdateDistributionAndParameters()
        If rdoProbabilities.Checked Then
            clsProbabilitiesFunction.ClearParameters()
            clsProbabilitiesFunction.AddParameter("dist", Chr(34) & ucrDistributionAndParameters.clsCurrDistribution.strRName & Chr(34))
            For Each clstempparam In ucrDistributionAndParameters.clsCurrRFunction.clsParameters
                clsProbabilitiesFunction.AddParameter(clstempparam.Clone())
            Next
        Else
            clsQuantilesFunction.ClearParameters()
            clsQuantilesFunction.AddParameter("dist", Chr(34) & ucrDistributionAndParameters.clsCurrDistribution.strRName & Chr(34))
            For Each clstempparam In ucrDistributionAndParameters.clsCurrRFunction.clsParameters
                clsQuantilesFunction.AddParameter(clstempparam.Clone())
            Next
        End If
        AddRemovePandQParameters()
        DisplayGraphOrValues()
    End Sub

    Private Sub ucrDistributionsFOrTablePlus_ParameterChanged() Handles ucrDistributionAndParameters.ControlValueChanged
        UpdateDistributionAndParameters()
    End Sub

    Private Sub ucrChkEnterValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEnterValues.ControlValueChanged
        If ucrChkEnterValues.Checked Then
            ucrSelectorShowModel.SetVariablesVisible(False)
            ucrSelectorShowModel.Reset()
        Else
            ucrSelectorShowModel.SetVariablesVisible(True)
            ucrInputProbabilities.ResetText()
        End If
    End Sub

    Private Sub DisplayGraphOrValues()
        If ucrChkDisplayGraphResults.Checked Then
            ucrBase.clsRsyntax.iCallType = 3
            clsQuantilesFunction.AddParameter("return", Chr(34) & "plot" & Chr(34), iPosition:=9)
            clsProbabilitiesFunction.AddParameter("return", Chr(34) & "plot" & Chr(34), iPosition:=9)
        Else
            ucrBase.clsRsyntax.iCallType = 2
            clsQuantilesFunction.AddParameter("return", Chr(34) & "values" & Chr(34), iPosition:=9)
            clsProbabilitiesFunction.AddParameter("return", Chr(34) & "values" & Chr(34), iPosition:=9)
        End If
    End Sub

    Private Sub ucrChkDisplayGraphResults_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayGraphResults.ControlValueChanged
        DisplayGraphOrValues()
    End Sub

    Private Sub ucrPnlDistributionType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDistributionType.ControlValueChanged
        UpdateDistributionAndParameters()
        If rdoProbabilities.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsProbabilitiesFunction)
            If ucrChkDisplayGraphResults.Checked AndAlso Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("prob")
            End If
            ucrInputProbabilities.SetItems({"1", "0.1, 1, 3, 5, 10 ", "-2, -1, 0, 1, 2"})
            ucrInputProbabilities.SetName("1")
            lblProbValues.Visible = False
            lblQuantValues.Visible = True
        ElseIf rdoQuantiles.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsQuantilesFunction)
            If ucrChkDisplayGraphResults.Checked AndAlso Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("quant")
            End If
            ucrInputProbabilities.SetItems({"0.5", "0.1, 0.2, 0.4, 0.6, 0.8, 0.9 ", "0.2, 0.5, 0.8", " 0.5, 0.8, 0.9, 0.95, 0.99"})
            ucrInputProbabilities.SetName("0.5")
            lblQuantValues.Visible = False
            lblProbValues.Visible = True
        End If
    End Sub

    Private Sub ucrInputProbabilities_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputProbabilities.ControlValueChanged
        AddRemovePandQParameters()
    End Sub

    Private Sub AllControlsContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverProbabilitiesOrValues.ControlContentsChanged, ucrInputProbabilities.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrDistributionAndParameters.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class