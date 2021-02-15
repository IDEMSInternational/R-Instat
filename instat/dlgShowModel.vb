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
    Private bResetSubdialog As Boolean = False
    Private bFirstLoad As Boolean = True
    Private clsProbabilitiesFunction As New RFunction
    Private clsQuantilesFunction As New RFunction
    Private clsLabsFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private clsPipeOperator As New ROperator
    ' Private clsConcatenateFunction As New RFunction 'This RFunction is needed for automatic passing of p/q parameter for example p = c(0.5).

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
        ucrPnlDistributionType.AddParameterValueFunctionNamesCondition(rdoQuantiles, "0", "qdist")
        ucrPnlDistributionType.AddParameterValueFunctionNamesCondition(rdoProbabilities, "0", "pdist")

        ucrSaveGraph.SetPrefix("quant")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorShowModel.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrInputValuesOrProbabilities.SetParameter(New RParameter("p", 1, bNewIncludeArgumentName:=False))
        ucrInputValuesOrProbabilities.AddQuotesIfUnrecognised = False
        ucrInputValuesOrProbabilities.SetValidationTypeAsNumericList()

        ucrReceiverProbabilitiesOrValues.SetParameter(New RParameter("p", 1))
        ucrReceiverProbabilitiesOrValues.SetParameterIsRFunction()

        ucrDistributionAndParameters.SetParameters()

        ucrChkEnterValues.SetText("Enter value(s)")

        ucrChkDisplayGraphResults.SetParameter(New RParameter("plot", 2))
        ucrChkDisplayGraphResults.SetRDefault("TRUE")
        ucrChkDisplayGraphResults.SetText("Display Graph Results")

        ucrChkEnterValues.AddToLinkedControls(ucrReceiverProbabilitiesOrValues, {False}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEnterValues.AddToLinkedControls(ucrInputValuesOrProbabilities, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDisplayGraphResults.AddToLinkedControls(ucrSaveGraph, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'These conditions might still be needed when SetRcode for this checkbox is enabled.
        'ucrChkEnterValues.AddParameterIsRFunctionCondition(False, "q", True)
        'ucrChkEnterValues.AddParameterIsRFunctionCondition(False, "p", True)
        'ucrChkEnterValues.AddParameterIsRFunctionCondition(True, "q", False)
        'ucrChkEnterValues.AddParameterIsRFunctionCondition(True, "p", False)
    End Sub

    Private Sub SetDefaults()
        clsQuantilesFunction = New RFunction
        clsProbabilitiesFunction = New RFunction
        ' clsConcatenateFunction = New RFunction

        clsPipeOperator = New ROperator

        ucrSelectorShowModel.Reset()
        ucrInputValuesOrProbabilities.Reset()
        ucrSaveGraph.Reset()
        ucrDistributionAndParameters.SetRDistributions()

        ucrChkEnterValues.Checked = True 'TODO: Set conditions properly!

        clsProbabilitiesFunction.SetPackageName("mosaic")
        clsProbabilitiesFunction.SetRCommand("pdist")

        clsQuantilesFunction.SetPackageName("mosaic")
        clsQuantilesFunction.SetRCommand("qdist")

        ' clsConcatenateFunction.SetRCommand("c") 

        clsLabsFunction.SetPackageName("ggformula")
        clsLabsFunction.SetRCommand("gf_labs")

        clsThemeFunction.SetPackageName("ggformula")
        clsThemeFunction.SetRCommand("gf_theme")

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("0", clsRFunctionParameter:=clsQuantilesFunction, iPosition:=0)
        clsPipeOperator.AddParameter("1", clsRFunctionParameter:=clsLabsFunction, iPosition:=1)
        clsPipeOperator.AddParameter("2", clsRFunctionParameter:=clsThemeFunction, iPosition:=2)

        clsPipeOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorShowModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph", bAssignToIsPrefix:=True)
        bResetSubdialog = True
        ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        'Commented out these SetRcodes because two controls i.e ucrReceiverProbabilitiesOrValues and ucrInputValuesOrProbabilities pass the same R parameter. 
        'There might be an easy way to allow these to work automatically as desired.
        'ucrChkEnterValues SetRcode is commented out because it is needed once conditions for this checkbox are set properly!

        'ucrReceiverProbabilitiesOrValues.AddAdditionalCodeParameterPair(clsProbabilitiesFunction, New RParameter("q", 1), 1)
        'ucrInputValuesOrProbabilities.AddAdditionalCodeParameterPair(clsProbabilitiesFunction, New RParameter("q", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrChkDisplayGraphResults.AddAdditionalCodeParameterPair(clsProbabilitiesFunction, ucrChkDisplayGraphResults.GetParameter, iAdditionalPairNo:=1)
        'ucrChkEnterValues.AddAdditionalCodeParameterPair(clsProbabilitiesFunction, ucrChkEnterValues.GetParameter, iAdditionalPairNo:=1)
        ucrPnlDistributionType.SetRCode(clsPipeOperator, bReset)
        'ucrReceiverProbabilitiesOrValues.SetRCode(clsQuantilesFunction, bReset)
        ucrChkDisplayGraphResults.SetRCode(clsQuantilesFunction, bReset)
        'ucrInputValuesOrProbabilities.SetRCode(clsConcatenateFunction, bReset)
        If bReset Then
            'ucrSaveGraph.AddAdditionalRCode(clsProbabilitiesFunction, 1)
            ucrSaveGraph.SetRCode(clsPipeOperator, bReset)
        End If
        ucrDistributionAndParameters.SetRCode(clsQuantilesFunction, bReset)
        'ucrChkEnterValues.SetRCode(clsQuantilesFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrDistributionAndParameters.bParametersFilled OrElse (Not ucrChkEnterValues.Checked AndAlso ucrReceiverProbabilitiesOrValues.IsEmpty) OrElse
                (ucrChkEnterValues.Checked AndAlso ucrInputValuesOrProbabilities.IsEmpty) OrElse Not ucrSaveGraph.IsComplete Then
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

    Private Sub AddPandQParameters()
        If ucrChkEnterValues.Checked Then
            ucrSelectorShowModel.SetVariablesVisible(False)
            clsProbabilitiesFunction.AddParameter("q", "c(" & ucrInputValuesOrProbabilities.GetText & ")", iPosition:=0)
            clsQuantilesFunction.AddParameter("p", "c(" & ucrInputValuesOrProbabilities.GetText & ")", iPosition:=0)
        Else
            ucrSelectorShowModel.SetVariablesVisible(True)
            clsQuantilesFunction.AddParameter("p", clsRFunctionParameter:=ucrReceiverProbabilitiesOrValues.GetVariables, iPosition:=0)
            clsProbabilitiesFunction.AddParameter("q", clsRFunctionParameter:=ucrReceiverProbabilitiesOrValues.GetVariables, iPosition:=0)
        End If
    End Sub

    Private Sub ucrReceiverProbabilitiesOrValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverProbabilitiesOrValues.ControlValueChanged, ucrChkEnterValues.ControlValueChanged, ucrInputValuesOrProbabilities.ControlValueChanged
        AddPandQParameters()
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
        DisplayGraphOrValues()
        AddPandQParameters()
    End Sub

    Private Sub ucrDistributionsFOrTablePlus_ParameterChanged() Handles ucrDistributionAndParameters.ControlValueChanged
        UpdateDistributionAndParameters()
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
        AddPandQParameters()
        If rdoProbabilities.Checked Then
            '  ucrBase.clsRsyntax.SetBaseRFunction(clsProbabilitiesFunction)
            clsPipeOperator.AddParameter("0", clsRFunctionParameter:=clsProbabilitiesFunction, iPosition:=0)
            If ucrChkDisplayGraphResults.Checked AndAlso Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("prob")
            End If
            ucrInputValuesOrProbabilities.SetName("1")
            ucrInputValuesOrProbabilities.SetItems({"1", "0.1, 1, 3, 5, 10 ", "-2, -1, 0, 1, 2", "0.01, 0.05, 0.1, 0.2, 0.5, 0.8, 0.9, 0.95, 0.99", "0.5, 0.8, 0.9, 0.95, 0.98, 0.99, 0.995, 0.998, 0.999"})
            lblProbValues.Visible = False
            lblQuantValues.Visible = True
        ElseIf rdoQuantiles.Checked Then
            'ucrBase.clsRsyntax.SetBaseRFunction(clsQuantilesFunction)
            clsPipeOperator.AddParameter("0", clsRFunctionParameter:=clsQuantilesFunction, iPosition:=0)
            If ucrChkDisplayGraphResults.Checked AndAlso Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("quant")
            End If
            ucrInputValuesOrProbabilities.SetName("0.5")
            ucrInputValuesOrProbabilities.SetItems({"0.5", "0.1, 0.2, 0.4, 0.6, 0.8, 0.9 ", "0.2, 0.5, 0.8", " 0.5, 0.8, 0.9, 0.95, 0.99", "-4, -3, -2, -1, 0, 1, 2, 3, 4", "40, 50, 60, 80, 100, 130, 160, 200, 250"})
            lblQuantValues.Visible = False
            lblProbValues.Visible = True
        End If
    End Sub

    Private Sub AllControlsContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverProbabilitiesOrValues.ControlContentsChanged, ucrInputValuesOrProbabilities.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrDistributionAndParameters.ControlContentsChanged, ucrChkEnterValues.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub cmdDistributionOptions_Click(sender As Object, e As EventArgs) Handles cmdDistributionOptions.Click
        sdgDistributionOptions.SetRCode(clsNewLabsFunction:=clsLabsFunction, clsNewThemeFunction:=clsThemeFunction, bReset:=bResetSubdialog)
        sdgDistributionOptions.ShowDialog()
        bResetSubdialog = False
    End Sub
End Class