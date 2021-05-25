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
    'This RFunction is needed for automatic passing of p/q parameter for example p = c(0.5). The instance of
    'clsConcatenateFunction are commented out since the function is not used at the moment
    ' Private clsConcatenateFunction As New RFunction

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
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorShowModel.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrSaveNewColumn.SetLabelText("New column name:")
        ucrSaveNewColumn.SetSaveTypeAsColumn()
        ucrSaveNewColumn.SetIsComboBox()
        ucrSaveNewColumn.SetPrefix("quant")
        ucrSaveNewColumn.SetDataFrameSelector(ucrSelectorShowModel.ucrAvailableDataFrames)

        ucrInputValuesOrProbabilities.SetParameter(New RParameter("p", 1, bNewIncludeArgumentName:=False))
        ucrInputValuesOrProbabilities.AddQuotesIfUnrecognised = False
        ucrInputValuesOrProbabilities.SetValidationTypeAsNumericList()

        ucrReceiverProbabilitiesOrValues.SetParameter(New RParameter("p", 1))
        ucrReceiverProbabilitiesOrValues.SetParameterIsRFunction()

        ucrDistributionAndParameters.SetParameters()

        ucrChkEnterValues.SetText("Enter value(s)")

        ucrPnlGraphValues.SetParameter(New RParameter("plot", 2))
        ucrPnlGraphValues.AddRadioButton(rdoGraph, "TRUE")
        ucrPnlGraphValues.AddRadioButton(rdoValues, "FALSE")
        ucrPnlGraphValues.SetRDefault("TRUE")

        ucrChkEnterValues.AddToLinkedControls(ucrReceiverProbabilitiesOrValues, {False}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEnterValues.AddToLinkedControls(ucrInputValuesOrProbabilities, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphValues.AddToLinkedControls(ucrSaveGraph, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'These conditions might still be needed when SetRcode for this checkbox is enabled.
        'ucrChkEnterValues.AddParameterIsRFunctionCondition(False, "q", True)
        'ucrChkEnterValues.AddParameterIsRFunctionCondition(False, "p", True)
        'ucrChkEnterValues.AddParameterIsRFunctionCondition(True, "q", False)
        'ucrChkEnterValues.AddParameterIsRFunctionCondition(True, "p", False)
    End Sub

    Private Sub SetDefaults()
        clsQuantilesFunction = New RFunction
        clsProbabilitiesFunction = New RFunction
        'clsConcatenateFunction = New RFunction
        clsLabsFunction = New RFunction
        clsThemeFunction = New RFunction

        clsPipeOperator = New ROperator

        ucrSaveGraph.ucrChkSave.Checked = False 'Reset the checkbox here since saving is done manually!

        ucrSelectorShowModel.Reset()
        ucrInputValuesOrProbabilities.Reset()
        ucrSaveGraph.Reset()
        ucrSaveNewColumn.Reset()
        ucrDistributionAndParameters.SetRDistributions()

        ucrChkEnterValues.Checked = True 'TODO: Set conditions properly!

        clsProbabilitiesFunction.SetPackageName("mosaic")
        clsProbabilitiesFunction.SetRCommand("pdist")

        clsQuantilesFunction.SetPackageName("mosaic")
        clsQuantilesFunction.SetRCommand("qdist")

        'clsConcatenateFunction.SetRCommand("c") 

        clsLabsFunction.SetPackageName("ggformula")
        clsLabsFunction.SetRCommand("gf_labs")

        clsThemeFunction.SetPackageName("ggformula")
        clsThemeFunction.SetRCommand("gf_theme")

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("0", clsRFunctionParameter:=clsQuantilesFunction, iPosition:=0)
        clsPipeOperator.AddParameter("1", clsRFunctionParameter:=clsLabsFunction, iPosition:=1)
        clsPipeOperator.AddParameter("2", clsRFunctionParameter:=clsThemeFunction, iPosition:=2)

        bResetSubdialog = True
        ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        'Commented out these SetRcodes because two controls i.e ucrReceiverProbabilitiesOrValues and ucrInputValuesOrProbabilities pass the same R parameter. 
        'There might be an easy way to allow these to work automatically as desired.
        'ucrChkEnterValues SetRcode is commented out because it is needed once conditions for this checkbox are set properly!

        'ucrReceiverProbabilitiesOrValues.AddAdditionalCodeParameterPair(clsProbabilitiesFunction, New RParameter("q", 1), 1)
        'ucrInputValuesOrProbabilities.AddAdditionalCodeParameterPair(clsProbabilitiesFunction, New RParameter("q", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        If bReset Then
            ucrPnlGraphValues.AddAdditionalCodeParameterPair(clsProbabilitiesFunction, ucrPnlGraphValues.GetParameter, iAdditionalPairNo:=1)
            ucrPnlGraphValues.SetRCode(clsQuantilesFunction, bReset)
        End If
        'ucrChkEnterValues.AddAdditionalCodeParameterPair(clsProbabilitiesFunction, ucrChkEnterValues.GetParameter, iAdditionalPairNo:=1)
        ucrPnlDistributionType.SetRCode(clsPipeOperator, bReset)
        'ucrReceiverProbabilitiesOrValues.SetRCode(clsQuantilesFunction, bReset)

        'ucrInputValuesOrProbabilities.SetRCode(clsConcatenateFunction, bReset)
        ucrDistributionAndParameters.SetRCode(clsQuantilesFunction, bReset)
        SwitchBetweenSaveGraphOrColumn()
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

    Private Sub cmdDistributionOptions_Click(sender As Object, e As EventArgs) Handles cmdDistributionOptions.Click
        sdgDistributionOptions.SetRCode(clsNewLabsFunction:=clsLabsFunction, clsNewThemeFunction:=clsThemeFunction, bReset:=bResetSubdialog)
        sdgDistributionOptions.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub SwitchBetweenSaveGraphOrColumn()
        clsPipeOperator.RemoveAssignTo()
        If rdoValues.Checked AndAlso ucrReceiverProbabilitiesOrValues.Visible Then
            ucrBase.clsRsyntax.iCallType = 0
            clsPipeOperator.SetAssignTo(ucrSaveNewColumn.GetText(), strTempDataframe:=ucrSelectorShowModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveNewColumn.GetText)
        ElseIf rdoGraph.Checked AndAlso ucrSaveGraph.ucrChkSave.Checked Then
            ucrBase.clsRsyntax.iCallType = 3
            clsPipeOperator.SetAssignTo(ucrSaveGraph.GetText(), strTempDataframe:=ucrSelectorShowModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveGraph.GetText)
        ElseIf rdoGraph.Checked AndAlso Not ucrSaveGraph.ucrChkSave.Checked Then
            ucrBase.clsRsyntax.iCallType = 3
            clsPipeOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorShowModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph", bAssignToIsPrefix:=True)
        Else
            ucrBase.clsRsyntax.iCallType = 2
        End If
    End Sub

    Private Sub HideShowSaveControl()
        If (ucrChkEnterValues.Checked AndAlso rdoValues.Checked) OrElse
                rdoGraph.Checked Then
            ucrSaveNewColumn.Hide()
        Else
            ucrSaveNewColumn.Show()
        End If
    End Sub

    Private Sub AddPandQParameters()
        HideShowSaveControl()
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
        SwitchBetweenSaveGraphOrColumn()
    End Sub

    Private Sub UpdateDistributionAndParameters()
        If rdoProbabilities.Checked Then
            clsProbabilitiesFunction.ClearParameters()
            clsProbabilitiesFunction.AddParameter("dist", Chr(34) & ucrDistributionAndParameters.clsCurrDistribution.strRName & Chr(34))
            For Each clstempParam In ucrDistributionAndParameters.clsCurrRFunction.clsParameters
                clsProbabilitiesFunction.AddParameter(clstempParam.Clone())
            Next
        Else
            clsQuantilesFunction.ClearParameters()
            clsQuantilesFunction.AddParameter("dist", Chr(34) & ucrDistributionAndParameters.clsCurrDistribution.strRName & Chr(34))
            For Each clstempParam In ucrDistributionAndParameters.clsCurrRFunction.clsParameters
                clsQuantilesFunction.AddParameter(clstempParam.Clone())
            Next
        End If
        DisplayGraphOrValues()
        AddPandQParameters()
    End Sub

    Private Sub ucrDistributionsFOrTablePlus_ParameterChanged() Handles ucrDistributionAndParameters.ControlValueChanged
        UpdateDistributionAndParameters()
    End Sub

    Private Sub DisplayGraphOrValues()
        If rdoGraph.Checked Then
            cmdDistributionOptions.Enabled = True
            clsPipeOperator.AddParameter("1", clsRFunctionParameter:=clsLabsFunction, iPosition:=1)
            clsPipeOperator.AddParameter("2", clsRFunctionParameter:=clsThemeFunction, iPosition:=2)
            clsQuantilesFunction.AddParameter("return", Chr(34) & "plot" & Chr(34), iPosition:=9)
            clsProbabilitiesFunction.AddParameter("return", Chr(34) & "plot" & Chr(34), iPosition:=9)
        ElseIf rdoValues.Checked Then
            cmdDistributionOptions.Enabled = False
            ucrBase.clsRsyntax.RemoveOperatorParameter("1")
            ucrBase.clsRsyntax.RemoveOperatorParameter("2")
            clsQuantilesFunction.AddParameter("return", Chr(34) & "values" & Chr(34), iPosition:=9)
            clsProbabilitiesFunction.AddParameter("return", Chr(34) & "values" & Chr(34), iPosition:=9)
        End If
    End Sub

    Private Sub ucrPnlGraphValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGraphValues.ControlValueChanged
        DisplayGraphOrValues()
        SwitchBetweenSaveGraphOrColumn()
        HideShowSaveControl()
    End Sub

    Private Sub ucrPnlDistributionType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDistributionType.ControlValueChanged
        SwitchBetweenSaveGraphOrColumn()
        UpdateDistributionAndParameters()
        AddPandQParameters()
        If rdoProbabilities.Checked Then
            clsPipeOperator.AddParameter("0", clsRFunctionParameter:=clsProbabilitiesFunction, iPosition:=0)
            ucrSaveGraph.SetPrefix("prob")
            ucrSaveNewColumn.SetPrefix("prob")
            ucrInputValuesOrProbabilities.SetName("1")
            ucrInputValuesOrProbabilities.SetItems({"1", "0.1, 1, 3, 5, 10 ", "-2, -1, 0, 1, 2"})
            lblProbValues.Visible = False
            lblQuantValues.Visible = True
        ElseIf rdoQuantiles.Checked Then
            clsPipeOperator.AddParameter("0", clsRFunctionParameter:=clsQuantilesFunction, iPosition:=0)
            ucrSaveGraph.SetPrefix("quant")
            ucrSaveNewColumn.SetPrefix("quant")
            ucrInputValuesOrProbabilities.SetName("0.5")
            ucrInputValuesOrProbabilities.SetItems({"0.5", "0.1, 0.2, 0.4, 0.6, 0.8, 0.9 ", "0.2, 0.5, 0.8", " 0.5, 0.8, 0.9, 0.95, 0.99"})
            lblQuantValues.Visible = False
            lblProbValues.Visible = True
        End If
    End Sub

    Private Sub ucrSaveGraph_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveGraph.ControlValueChanged, ucrSaveNewColumn.ControlValueChanged
        SwitchBetweenSaveGraphOrColumn()
    End Sub

    Private Sub AllControlsContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverProbabilitiesOrValues.ControlContentsChanged, ucrInputValuesOrProbabilities.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrDistributionAndParameters.ControlContentsChanged, ucrChkEnterValues.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
