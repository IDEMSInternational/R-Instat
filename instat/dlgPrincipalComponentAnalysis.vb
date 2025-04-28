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
Public Class dlgPrincipalComponentAnalysis
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private bResettingDialogue As Boolean = False
    Private lstEditedVariables As New List(Of String)
    Private clsPCAFunction, clsPCASummaryFuction, clsMatchFunction, clsMatch2Function, clsNamesFunction, clsSummaryFunction, clsGetColumnsFunction As New RFunction
    Private clsREigenValues, clsREigenVectors, clsRRotation, clsRRotationCoord, clsRRotationEig, clsDummyFunction As New RFunction
    Private clsRScreePlotFunction, clsRThemeMinimal, clsRVariablesPlotFunction, clsRVariablesPlotTheme, clsRIndividualsPlotFunction, clsRIndividualsPlotTheme, clsRBiplotFunction, clsRBiplotTheme, clsRBarPlotFunction As New RFunction
    Private clsRFactor, clsRMelt, clsRBarPlotGeom, clsRBarPlotAes, clsRBarPlotFacet, clsRVariablesPlotFunctionValue, clsRIndividualsFunctionValue, clsRBiplotFunctionValue As New RFunction
    Private clsRScreePlot, clsRVariablesPlot, clsRIndividualsPlot, clsRBiplot As New RSyntax
    Private clsRBarPlot, clsRBarPlot0, clsBaseOperator As New ROperator
    ' call all classes in the sub dialog

    Private Sub dlgPrincipalComponentAnalysis_oad(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 422
        ucrSelectorPCA.SetParameter(New RParameter("data_name", 0))
        ucrSelectorPCA.SetParameterIsrfunction()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        'ucrReceiver
        ucrReceiverMultiplePCA.SetParameter(New RParameter("col_names", 1))
        ucrReceiverMultiplePCA.SetParameterIsString()
        ucrReceiverMultiplePCA.Selector = ucrSelectorPCA
        ucrReceiverMultiplePCA.SetDataType("numeric", bStrict:=True)
        ucrReceiverMultiplePCA.SetMeAsReceiver()

        ucrReceiverSuppNumeric.SetParameter(New RParameter("right", 1, bNewIncludeArgumentName:=False))
        ucrReceiverSuppNumeric.SetParameterIsString()
        ucrReceiverSuppNumeric.Selector = ucrSelectorPCA
        ucrReceiverSuppNumeric.SetDataType("numeric")
        ucrReceiverSuppNumeric.SetLinkedDisplayControl(lblSupplNumeric)
        ucrReceiverSuppNumeric.bExcludeFromSelector = True

        ucrReceiverSupplFactors.SetParameter(New RParameter("right", 1, bNewIncludeArgumentName:=False))
        ucrReceiverSupplFactors.SetParameterIsString()
        ucrReceiverSupplFactors.Selector = ucrSelectorPCA
        ucrReceiverSupplFactors.SetDataType("factor")
        ucrReceiverSupplFactors.SetLinkedDisplayControl(lblSupplFactors)

        ucrChkExtraVariables.SetText("Extra Variables")
        ucrChkExtraVariables.SetParameter(New RParameter("checked", iNewPosition:=0))
        ucrChkExtraVariables.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkExtraVariables.AddToLinkedControls({ucrReceiverSuppNumeric, ucrReceiverSupplFactors}, {True}, bNewLinkedHideIfParameterMissing:=True)

        'ucrCheckBox
        ucrChkScaleData.SetParameter(New RParameter("scale.unit", 2))
        ucrChkScaleData.SetText("Scale Data")
        ucrChkScaleData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkScaleData.SetRDefault("TRUE")

        'ucrNud
        ucrNudNumberOfComp.SetParameter(New RParameter("ncp", 3))
        ucrNudNumberOfComp.SetRDefault(5)

        'ucrSaveResult
        ucrSaveResult.SetPrefix("pca")
        ucrSaveResult.SetSaveTypeAsModel()
        ucrSaveResult.SetDataFrameSelector(ucrSelectorPCA.ucrAvailableDataFrames)
        ucrSaveResult.SetCheckBoxText("Store Result")
        ucrSaveResult.SetIsComboBox()
        ucrSaveResult.SetAssignToIfUncheckedValue("last_model")

    End Sub

    Private Sub SetDefaults()
        clsPCAFunction = New RFunction
        clsPCASummaryFuction = New RFunction
        clsREigenVectors = New RFunction
        clsREigenValues = New RFunction
        clsRRotation = New RFunction
        clsRRotationEig = New RFunction
        clsRRotationCoord = New RFunction
        clsRThemeMinimal = New RFunction
        clsBaseOperator = New ROperator
        clsRScreePlotFunction = New RFunction
        clsRVariablesPlotFunction = New RFunction
        clsRVariablesPlotTheme = New RFunction
        clsRVariablesPlot = New RSyntax
        clsRIndividualsPlotFunction = New RFunction
        clsRIndividualsPlotTheme = New RFunction
        clsRIndividualsPlot = New RSyntax
        clsRBiplotFunction = New RFunction
        clsRBiplotTheme = New RFunction
        clsRBiplot = New RSyntax
        clsRBarPlotFunction = New RFunction
        clsRFactor = New RFunction
        clsRMelt = New RFunction
        clsRBarPlotGeom = New RFunction
        clsRBarPlotAes = New RFunction
        clsRBarPlotFacet = New RFunction
        clsRBarPlot0 = New ROperator
        clsRBarPlot = New ROperator
        clsRVariablesPlotFunctionValue = New RFunction
        clsRIndividualsFunctionValue = New RFunction
        clsRBiplotFunctionValue = New RFunction
        clsDummyFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsGetColumnsFunction = New RFunction
        clsNamesFunction = New RFunction
        clsMatchFunction = New RFunction
        clsMatch2Function = New RFunction

        ' package name, r command and defaults for sdg

        ucrSelectorPCA.Reset()
        ucrSaveResult.Reset()

        clsDummyFunction.AddParameter("checked", "FALSE", iPosition:=0)
        clsDummyFunction.AddParameter("value1", "FALSE", iPosition:=1)

        clsGetColumnsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetColumnsFunction.SetAssignTo("col_data")

        clsPCAFunction.SetPackageName("FactoMineR")
        clsPCAFunction.SetRCommand("PCA")
        clsPCAFunction.AddParameter("X", clsRFunctionParameter:=clsGetColumnsFunction, iPosition:=1)
        clsPCAFunction.AddParameter("ncp", 2)
        clsPCAFunction.AddParameter("graph", "FALSE")
        clsPCAFunction.iCallType = 2
        clsPCAFunction.SetAssignTo("last_model", strTempModel:="last_model", strTempDataframe:=ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)

        clsREigenValues.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsREigenValues.AddParameter("value1", Chr(34) & "eig" & Chr(34))
        clsREigenValues.iCallType = 2

        clsMatchFunction.SetRCommand("match")
        clsMatchFunction.SetAssignTo("quan_columns")

        clsMatch2Function.SetRCommand("match")
        clsMatch2Function.SetAssignTo("qual_columns")

        clsNamesFunction.SetRCommand("names")

        clsPCASummaryFuction.SetPackageName("FactoMineR")
        clsPCASummaryFuction.SetRCommand("PCA")
        clsPCASummaryFuction.AddParameter("X", "col_data")
        clsPCASummaryFuction.AddParameter("ncp", 2)
        clsPCASummaryFuction.AddParameter("graph", "FALSE")

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsPCASummaryFuction, iPosition:=0)
        clsSummaryFunction.iCallType = 2

        clsREigenVectors.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsREigenVectors.AddParameter("value1", Chr(34) & "ind" & Chr(34))
        clsREigenVectors.AddParameter("value2", Chr(34) & "coord" & Chr(34))
        clsREigenVectors.iCallType = 2

        clsRRotationCoord.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsRRotationCoord.AddParameter("value1", Chr(34) & "var" & Chr(34))
        clsRRotationCoord.AddParameter("value2", Chr(34) & "coord" & Chr(34))

        clsRRotationEig.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsRRotationEig.AddParameter("value1", Chr(34) & "eig" & Chr(34))

        ' Scree Function
        clsBaseOperator.SetOperation("+")
        clsRScreePlotFunction.SetPackageName("factoextra")
        clsRScreePlotFunction.SetRCommand("fviz_screeplot")
        clsRScreePlotFunction.AddParameter("X", clsRFunctionParameter:=clsPCASummaryFuction)
        clsRScreePlotFunction.iCallType = 3
        clsRScreePlotFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                     strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                     strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                     strRDataFrameNameToAddObjectTo:=ucrSelectorPCA.strCurrentDataFrame,
                                     strObjectName:="last_graph")

        clsRThemeMinimal.SetPackageName("ggplot2")
        clsRThemeMinimal.SetRCommand("theme_minimal")

        ' Variables Function
        clsRVariablesPlotFunction.SetPackageName("factoextra")
        clsRVariablesPlotFunction.SetRCommand("fviz_pca_var")
        clsRVariablesPlotFunction.AddParameter("X", clsRFunctionParameter:=clsPCASummaryFuction)
        clsRVariablesPlotFunctionValue.SetRCommand("c")
        clsRVariablesPlotFunctionValue.AddParameter("first_dim", 1, bIncludeArgumentName:=False, iPosition:=0)
        clsRVariablesPlotFunctionValue.AddParameter("second_dim", 2, bIncludeArgumentName:=False, iPosition:=1)
        clsRVariablesPlotFunction.AddParameter("axes", clsRFunctionParameter:=clsRVariablesPlotFunctionValue, iPosition:=1)
        clsRVariablesPlotFunction.iCallType = 3
        clsRVariablesPlotFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                     strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                     strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                     strRDataFrameNameToAddObjectTo:=ucrSelectorPCA.strCurrentDataFrame,
                                     strObjectName:="last_graph")

        ' Individual Plot
        clsRIndividualsPlotFunction.SetPackageName("factoextra")
        clsRIndividualsPlotFunction.SetRCommand("fviz_pca_ind")
        clsRIndividualsPlotFunction.AddParameter("X", clsRFunctionParameter:=clsPCASummaryFuction)
        clsRIndividualsFunctionValue.SetRCommand("c")
        clsRIndividualsFunctionValue.AddParameter("first_dim", 1, bIncludeArgumentName:=False, iPosition:=0)
        clsRIndividualsFunctionValue.AddParameter("second_dim", 2, bIncludeArgumentName:=False, iPosition:=1)
        clsRIndividualsPlotFunction.AddParameter("axes", clsRFunctionParameter:=clsRIndividualsFunctionValue, iPosition:=1)
        clsRIndividualsPlotFunction.iCallType = 3
        clsRIndividualsPlotFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                     strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                     strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                     strRDataFrameNameToAddObjectTo:=ucrSelectorPCA.strCurrentDataFrame,
                                     strObjectName:="last_graph")

        ' Biplot
        clsRBiplotFunction.SetPackageName("factoextra")
        clsRBiplotFunction.SetRCommand("fviz_pca_biplot")
        clsRBiplotFunction.AddParameter("X", clsRFunctionParameter:=clsPCASummaryFuction)
        clsRBiplotFunctionValue.SetRCommand("c")
        clsRBiplotFunctionValue.AddParameter("first_dim", 1, bIncludeArgumentName:=False, iPosition:=0)
        clsRBiplotFunctionValue.AddParameter("second_dim", 2, bIncludeArgumentName:=False, iPosition:=1)
        clsRBiplotFunction.AddParameter("axes", clsRFunctionParameter:=clsRBiplotFunctionValue, iPosition:=1)
        clsRBiplotFunction.iCallType = 3
        clsRBiplotFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                     strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                     strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                     strRDataFrameNameToAddObjectTo:=ucrSelectorPCA.strCurrentDataFrame,
                                     strObjectName:="last_graph")

        ' Barplot
        clsRBarPlot0.SetOperation("+")
        clsRBarPlot.SetOperation("+")
        clsRFactor.SetRCommand("cbind")

        clsRMelt.SetPackageName("reshape2")
        clsRMelt.SetRCommand("melt")
        clsRMelt.AddParameter("", clsRFunctionParameter:=clsREigenVectors) ' not sure if this will work!
        clsRFactor.AddParameter("", clsRFunctionParameter:=clsRMelt)
        clsRBarPlotFunction.SetPackageName("ggplot2")
        clsRBarPlotFunction.SetRCommand("ggplot")
        clsRBarPlotFunction.AddParameter("data", clsRFunctionParameter:=clsRFactor)
        clsRBarPlotGeom.SetPackageName("ggplot2")
        clsRBarPlotGeom.SetRCommand("geom_bar")
        clsRBarPlotAes.SetPackageName("ggplot2")
        clsRBarPlotAes.SetRCommand("aes")
        clsRBarPlotAes.AddParameter("x", "Var1")
        clsRBarPlotAes.AddParameter("y", "value")
        clsRBarPlotAes.AddParameter("fill", "factor_col") ' may not run this here
        clsRBarPlotGeom.AddParameter("", clsRFunctionParameter:=clsRBarPlotAes)
        clsRBarPlotGeom.AddParameter("stat", Chr(34) & "identity" & Chr(34))
        clsRBarPlotFacet.SetPackageName("ggplot2")
        clsRBarPlotFacet.SetRCommand("facet_wrap")
        clsRBarPlotFacet.AddParameter("", "~Var2")
        clsRBarPlot0.AddParameter(iPosition:=0, clsRFunctionParameter:=clsRBarPlotFunction)
        clsRBarPlot0.AddParameter(clsRFunctionParameter:=clsRBarPlotGeom)
        clsRBarPlot.AddParameter(iPosition:=0, clsROperatorParameter:=clsRBarPlot0)
        clsRBarPlot.AddParameter(clsRFunctionParameter:=clsRBarPlotFacet)
        clsRScreePlotFunction.AddParameter("choice", Chr(34) & "variance" & Chr(34))
        clsBaseOperator.AddParameter("plot", clsRFunctionParameter:=clsRScreePlotFunction, iPosition:=0)
        clsBaseOperator.iCallType = 3

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsPCAFunction)
        ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
        ucrBase.clsRsyntax.AddToAfterCodes(clsBaseOperator, iPosition:=1)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrSelectorPCA.AddAdditionalCodeParameterPair(clsREigenVectors, ucrSelectorPCA.GetParameter, iAdditionalPairNo:=1)
        ucrSelectorPCA.AddAdditionalCodeParameterPair(clsRRotationCoord, ucrSelectorPCA.GetParameter, iAdditionalPairNo:=2)
        ucrSelectorPCA.AddAdditionalCodeParameterPair(clsRRotationEig, ucrSelectorPCA.GetParameter, iAdditionalPairNo:=3)

        ucrSelectorPCA.SetRCode(clsGetColumnsFunction, bReset)
        ucrSaveResult.SetRCode(clsPCAFunction, bReset)
        ucrChkScaleData.SetRCode(clsPCAFunction, bReset)
        ucrChkExtraVariables.SetRCode(clsDummyFunction, bReset)
        ucrNudNumberOfComp.SetRCode(clsPCAFunction, bReset)
        If bReset Then
            ucrReceiverSuppNumeric.SetRCode(clsMatchFunction, bReset)
            ucrReceiverSupplFactors.SetRCode(clsMatch2Function, bReset)
        End If
    End Sub

    Private Sub TestOKEnabled() ' add in if the sdg has a clear nud, etc
        If Not ucrReceiverMultiplePCA.IsEmpty AndAlso ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count > 1 AndAlso ucrNudNumberOfComp.GetText <> "" Then
            If ucrChkExtraVariables.Checked Then
                If Not ucrReceiverSupplFactors.IsEmpty OrElse Not ucrReceiverSuppNumeric.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBasePCA_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdPCAOptions_Click(sender As Object, e As EventArgs) Handles cmdPCAOptions.Click
        sdgPrincipalComponentAnalysis.SetRFunction(ucrBase.clsRsyntax, clsRRotation, clsRScreePlotFunction, clsRVariablesPlotFunction, clsRIndividualsPlotFunction, clsRBiplotFunction, clsRBarPlotFunction, clsRVariablesPlotFunctionValue, clsRIndividualsFunctionValue, clsRBiplotFunctionValue, clsRFactor, clsBaseOperator, clsRThemeMinimal, bResetSubdialog)
        bResetSubdialog = False
        sdgPrincipalComponentAnalysis.ShowDialog()
    End Sub

    Private Sub ucrReceiverMultiplePCA_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultiplePCA.ControlValueChanged, ucrChkExtraVariables.ControlValueChanged
        If ucrReceiverMultiplePCA.IsEmpty Then
            ucrNudNumberOfComp.Minimum = 0
            ucrNudNumberOfComp.Value = 0
        ElseIf ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count = 1 Then
            ucrNudNumberOfComp.Minimum = 2
        ElseIf ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count > 1 Then
            ucrNudNumberOfComp.Minimum = 2
            If ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count > 5 Then
                ucrNudNumberOfComp.Value = 5
            Else
                ucrNudNumberOfComp.Value = ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count
            End If
        End If
        If ucrReceiverMultiplePCA.IsEmpty AndAlso lstEditedVariables.Count > 0 Then
            UpdateSelector()
            ucrReceiverMultiplePCA.SetMeAsReceiver()
        End If
        If ucrReceiverMultiplePCA.IsEmpty Then
            ucrReceiverSuppNumeric.Clear()
        End If
        GetColumns()
    End Sub

    Private Sub ucrSelectorPCA_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorPCA.ControlValueChanged
        clsRRotationEig.AddParameter("data_name", Chr(34) & ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsGetColumnsFunction.AddParameter("data_name", Chr(34) & ucrSelectorPCA.ucrAvailableDataFrames.strCurrDataFrame & Chr(34), iPosition:=0)
        clsPCAFunction.AddParameter("X", clsRFunctionParameter:=clsGetColumnsFunction, iPosition:=0)
        clsNamesFunction.AddParameter("names", "col_data", iPosition:=0, bIncludeArgumentName:=False)
        clsMatchFunction.AddParameter("data", clsRFunctionParameter:=clsNamesFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsMatch2Function.AddParameter("data1", clsRFunctionParameter:=clsNamesFunction, iPosition:=1, bIncludeArgumentName:=False)
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlContentsChanged, ucrReceiverMultiplePCA.ControlContentsChanged, ucrNudNumberOfComp.ControlContentsChanged,
            ucrChkExtraVariables.ControlContentsChanged, ucrReceiverSuppNumeric.ControlContentsChanged, ucrReceiverSupplFactors.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkExtraVariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkExtraVariables.ControlValueChanged, ucrReceiverSupplFactors.ControlValueChanged, ucrReceiverSuppNumeric.ControlValueChanged
        If ucrChkExtraVariables.Checked AndAlso Not ucrReceiverSuppNumeric.IsEmpty Then
            clsPCAFunction.AddParameter("quanti.sup", clsRFunctionParameter:=clsMatchFunction, iPosition:=4)
            clsPCASummaryFuction.AddParameter("quanti.sup", "quan_columns", iPosition:=4)
        Else
            clsPCAFunction.RemoveParameterByName("quanti.sup")
            clsPCASummaryFuction.RemoveParameterByName("quanti.sup")
        End If

        If ucrChkExtraVariables.Checked AndAlso Not ucrReceiverSupplFactors.IsEmpty Then
            clsPCAFunction.AddParameter("quali.sup", clsRFunctionParameter:=clsMatch2Function, iPosition:=5)
            clsPCASummaryFuction.AddParameter("quali.sup", "qual_columns", iPosition:=5)
        Else
            clsPCAFunction.RemoveParameterByName("quali.sup")
            clsPCASummaryFuction.RemoveParameterByName("quali.sup")
        End If
        If ucrChkExtraVariables.Checked Then
            ucrReceiverMultiplePCA.RemoveExcludedMetadataProperty("class")
        Else
            ucrReceiverMultiplePCA.SetDataType("numeric")
            ucrReceiverMultiplePCA.SetMeAsReceiver()
        End If
        GetColumns()
    End Sub

    Private Sub GetColumns()
        If ucrChkExtraVariables.Checked Then
            Dim lstVariables As List(Of String) = ucrReceiverMultiplePCA.GetVariableNamesAsList()

            If Not ucrReceiverMultiplePCA.IsEmpty AndAlso (Not ucrReceiverSuppNumeric.IsEmpty OrElse Not ucrReceiverSupplFactors.IsEmpty) Then
                lstVariables.AddRange(ucrReceiverSuppNumeric.GetVariableNamesAsList())
                lstVariables.AddRange(ucrReceiverSupplFactors.GetVariableNamesAsList())
            End If

            clsGetColumnsFunction.AddParameter("col_names", frmMain.clsRLink.GetListAsRString(lstVariables, bWithQuotes:=True), iPosition:=1)
        Else
            clsGetColumnsFunction.AddParameter("col_names", ucrReceiverMultiplePCA.GetVariableNames)
        End If

    End Sub

    Private Sub UpdateSelector()
        ClearSelector()
        If bResettingDialogue Then
            For i = 0 To lstEditedVariables.Count - 1
                ucrSelectorPCA.lstAvailableVariable.Items.Add(lstEditedVariables.Item(i))
                ucrSelectorPCA.lstAvailableVariable.Items(i).Tag = ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.Text
            Next
        End If
    End Sub

    Private Sub ClearSelector()
        ucrSelectorPCA.lstAvailableVariable.Clear()
        ucrSelectorPCA.lstAvailableVariable.Groups.Clear()
        ucrSelectorPCA.lstAvailableVariable.Columns.Add("Variables")
    End Sub

    Private Sub ucrReceiverSuppNumeric_Enter(sender As Object, e As EventArgs) Handles ucrReceiverSuppNumeric.Enter
        If Not ucrReceiverMultiplePCA.IsEmpty Then
            Dim arrItems As String() = ucrReceiverMultiplePCA.GetVariableNamesList(False)

            For Each item As ListViewItem In ucrSelectorPCA.lstAvailableVariable.Items
                If arrItems.Contains(item.Text) Then
                    ucrSelectorPCA.lstAvailableVariable.Items.Remove(item)
                End If
            Next
        End If
    End Sub

    Private Sub ucrSelectorPCA_DataFrameChanged() Handles ucrSelectorPCA.DataFrameChanged
        If Not bResettingDialogue Then
            If ucrSelectorPCA.lstAvailableVariable.Items.Count > 0 Then
                lstEditedVariables.Clear()
                lstEditedVariables = ucrSelectorPCA.lstAvailableVariable.Items.Cast(Of ListViewItem)().Select(Function(item) item.Text).ToList()
            End If
        End If
    End Sub

    Private Sub ucrReceiverMultiplePCA_Enter(sender As Object, e As EventArgs) Handles ucrReceiverMultiplePCA.Enter
        bResettingDialogue = True
        UpdateSelector()
        bResettingDialogue = False
    End Sub
End Class