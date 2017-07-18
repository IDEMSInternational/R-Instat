﻿' R- Instat
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
Public Class sdgPrincipalComponentAnalysis
    Private bControlsInitialised As Boolean = False
    Private clsREigenValues, clsREigenVectors, clsRRotation As New RFunction
    Public bFirstLoad As Boolean = True

    ' to do:
    Public clsRScores, clsPCAModel, clsRVariablesPlotFunction, clsRVariablesPlotTheme, clsRCoord, clsRContrib, clsREig, clsRFactor, clsRMelt As New RFunction
    Public clsRScreePlotFunction, clsRThemeMinimal, clsRIndividualsPlotFunction, clsRIndividualsPlotTheme, clsRBiplotFunction, clsRBiplotTheme, clsRBarPlotFunction, clsRBarPlotGeom, clsRBarPlotFacet, clsRBarPlotAes As New RFunction
    Public clsRVariablesPlotFunctionValue, clsRIndividualsPlotFunctionValue, clsRBiplotFunctionValue As New RFunction
    'Public clsRScreePlot, clsRVariablesPlot, clsRIndividualsPlot, clsRBiplot As New RSyntax
    Private clsRsyntax As RSyntax
    Dim clsRBarPlot, clsRBarPlot0, clsBaseOperator As New ROperator

    Private Sub sdgPrincipalComponentAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        Dim dctLabelOptionsChoice As New Dictionary(Of String, String)
        Dim dctOptionsForLabel As New Dictionary(Of String, String)

        ucrChkEigenvalues.SetParameter(New RParameter("value1", 2))
        ucrChkEigenvalues.SetText("Eigenvalues")
        ucrChkEigenvalues.SetValueIfChecked(Chr(34) & "eig" & Chr(34))
        ucrChkEigenvalues.AddParameterPresentCondition(True, "value1")
        ucrChkEigenvalues.AddParameterPresentCondition(False, "value1", False)

        ucrChkEigenvectors.SetParameter(New RParameter("value1", 2))
        ucrChkEigenvectors.SetText("Eigenvectors")
        ucrChkEigenvectors.SetValueIfChecked(Chr(34) & "ind" & Chr(34))
        ucrChkEigenvectors.AddParameterPresentCondition(True, "value1")
        ucrChkEigenvectors.AddParameterPresentCondition(False, "value1", False)

        ucrChkRotation.SetParameter(New RParameter("MARGIN", 1))
        ucrChkRotation.SetText("Rotation")
        ucrChkRotation.SetValueIfChecked(2)
        ucrChkRotation.AddParameterPresentCondition(True, "MARGIN")
        ucrChkRotation.AddParameterPresentCondition(False, "MARGIN", False)

        ucrNudDim1.SetParameter(New RParameter("first_dim", 0, bNewIncludeArgumentName:=False))
        ucrNudDim1.SetMinMax(1, 2)
        'temp fix to prevent clearing value
        ucrNudDim1.bUpdateRCodeFromControl = True

        ucrNudDim2.SetParameter(New RParameter("second_dim", 1, bNewIncludeArgumentName:=False))
        ucrNudDim2.SetMinMax(1, 2)

        ucrPnlGraphics.AddRadioButton(rdoScreePlot)
        ucrPnlGraphics.AddRadioButton(rdoVariablesPlot)
        ucrPnlGraphics.AddRadioButton(rdoIndividualsPlot)
        ucrPnlGraphics.AddRadioButton(rdoBiplot)
        ucrPnlGraphics.AddRadioButton(rdoBarPlot)

        ucrPnlGraphics.AddParameterValueFunctionNamesCondition(rdoScreePlot, "plot", "fviz_screeplot") ' need to link these rdos with their class. This will be like "Add additional base function"
        ucrPnlGraphics.AddParameterValueFunctionNamesCondition(rdoVariablesPlot, "plot", "fviz_pca_var")
        ucrPnlGraphics.AddParameterValueFunctionNamesCondition(rdoIndividualsPlot, "plot", "fviz_pca_ind")
        ucrPnlGraphics.AddParameterValueFunctionNamesCondition(rdoBiplot, "plot", "fviz_pca_biplot")
        ucrPnlGraphics.AddParameterValueFunctionNamesCondition(rdoBarPlot, "plot", "ggplot")

        ucrPnlScreePlot.SetParameter(New RParameter("geom", 3))
        ucrPnlScreePlot.AddRadioButton(rdoBar, Chr(34) & "bar" & Chr(34))
        ucrPnlScreePlot.AddRadioButton(rdoLine, Chr(34) & "line" & Chr(34))
        ucrPnlScreePlot.AddRadioButton(rdoBothScree, "c(" & Chr(34) & "bar" & Chr(34) & "," & Chr(34) & "line" & Chr(34) & ")")

        ucrPnlVariablesPlot.SetParameter(New RParameter("geom", 3))
        ucrPnlVariablesPlot.AddRadioButton(rdoArrow, Chr(34) & "arrow" & Chr(34))
        ucrPnlVariablesPlot.AddRadioButton(rdoTextVariables, Chr(34) & "text" & Chr(34))
        ucrPnlVariablesPlot.AddRadioButton(rdoBothVariables, "c(" & Chr(34) & "arrow" & Chr(34) & "," & Chr(34) & "text" & Chr(34) & ")")

        ucrPnlIndividualPlot.SetParameter(New RParameter("geom", 3))
        ucrPnlIndividualPlot.AddRadioButton(rdoPoint, Chr(34) & "point" & Chr(34))
        ucrPnlIndividualPlot.AddRadioButton(rdoTextIndividual, Chr(34) & "text" & Chr(34))
        ucrPnlIndividualPlot.AddRadioButton(rdoBothIndividual, "c(" & Chr(34) & "point" & Chr(34) & "," & Chr(34) & "text" & Chr(34) & ")")

        ucrChkIncludePercentage.SetParameter(New RParameter("addlabels", 4))
        ucrChkIncludePercentage.SetText("Include Percentages")
        ucrChkIncludePercentage.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkIncludePercentage.SetRDefault("FALSE")

        ucrInputLabel1.SetParameter(New RParameter("choice", 5))
        dctLabelOptionsChoice.Add("Variance", Chr(34) & "variance" & Chr(34))
        dctLabelOptionsChoice.Add("Eigenvalue", Chr(34) & "eigenvalue" & Chr(34))
        ' our default is variance. not sure r-default. check.
        ucrInputLabel1.SetRDefault(Chr(34) & "variance" & Chr(34))
        ucrInputLabel1.SetDropDownStyleAsNonEditable()
        ucrInputLabel1.SetItems(dctLabelOptionsChoice)

        ucrInputLabel2.SetParameter(New RParameter("label", 6))
        dctOptionsForLabel.Add("All", Chr(34) & "all" & Chr(34))
        dctOptionsForLabel.Add("Individuals", Chr(34) & "ind" & Chr(34))
        dctOptionsForLabel.Add("Supplementary Individuals", Chr(34) & "ind.sup" & Chr(34))
        dctOptionsForLabel.Add("Qualitative Supplementary Variables", Chr(34) & "quali" & Chr(34))
        dctOptionsForLabel.Add("Quantitative Supplementary Variables", Chr(34) & "quanti.sup" & Chr(34))
        dctOptionsForLabel.Add("Variables", Chr(34) & "var" & Chr(34))
        dctOptionsForLabel.Add("None", Chr(34) & "none" & Chr(34))
        ucrInputLabel2.SetItems(dctOptionsForLabel)
        ucrInputLabel2.SetRDefault(Chr(34) & "all" & Chr(34))
        ucrInputLabel2.SetDropDownStyleAsNonEditable()

        ucrReceiverFactor.SetParameter(New RParameter("factor_col", 7))
        ucrReceiverFactor.SetParameterIsString()
        ucrReceiverFactor.Selector = ucrSelectorFactor
        ucrReceiverFactor.SetDataType("factor")
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.strSelectorHeading = "Factors"

        ucrPnlGraphics.AddToLinkedControls(ucrPnlScreePlot, {rdoScreePlot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoBothScree)
        ucrPnlGraphics.AddToLinkedControls(ucrPnlVariablesPlot, {rdoVariablesPlot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoBothVariables)
        ucrPnlGraphics.AddToLinkedControls(ucrPnlIndividualPlot, {rdoIndividualsPlot, rdoBiplot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoBothIndividual)
        ucrPnlScreePlot.SetLinkedDisplayControl(grpGeom)
        ucrPnlVariablesPlot.SetLinkedDisplayControl(grpVariablePlot)
        ucrPnlIndividualPlot.SetLinkedDisplayControl(GrpIndividualPlot)

        ucrPnlGraphics.AddToLinkedControls(ucrInputLabel2, {rdoVariablesPlot, rdoIndividualsPlot, rdoBiplot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="all")
        ucrInputLabel2.SetLinkedDisplayControl(lblLabel)

        ucrPnlGraphics.AddToLinkedControls(ucrInputLabel1, {rdoScreePlot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrInputLabel1.SetLinkedDisplayControl(lblChoice)

        ucrPnlGraphics.AddToLinkedControls(ucrChkIncludePercentage, {rdoScreePlot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrPnlGraphics.AddToLinkedControls(ucrNudDim1, {rdoVariablesPlot, rdoIndividualsPlot, rdoBiplot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlGraphics.AddToLinkedControls(ucrNudDim2, {rdoVariablesPlot, rdoIndividualsPlot, rdoBiplot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrNudDim1.SetLinkedDisplayControl(lblDim)

        ucrPnlGraphics.AddToLinkedControls(ucrSelectorFactor, {rdoBarPlot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlGraphics.AddToLinkedControls(ucrReceiverFactor, {rdoBarPlot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrReceiverFactor.SetLinkedDisplayControl(lblFactorVariable)
        bControlsInitialised = True
        'TODO: disabled for now: still need to work on passing operators.
        rdoBarPlot.Enabled = False
    End Sub

    Public Sub SetRFunction(clsNewRsyntax As RSyntax, clsNewREigenValues As RFunction, clsNewREigenVectors As RFunction, clsNewRRotation As RFunction, clsNewScreePlotFunction As RFunction, clsNewVariablesPlotFunction As RFunction, clsNewIndividualsPlotFunction As RFunction, clsNewBiplotFunction As RFunction, clsNewBarPlotFunction As RFunction, clsNewVariablesPlotFunctionValue As RFunction, clsNewIndividualsPlotFunctionValue As RFunction, clsNewBiplotFunctionValue As RFunction, clsNewRFactor As RFunction, clsNewBaseOperator As ROperator, clsNewRThemeMinimal As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRsyntax = clsNewRsyntax
        clsREigenValues = clsNewREigenValues
        clsREigenVectors = clsNewREigenVectors
        clsRRotation = clsNewRRotation
        clsRScreePlotFunction = clsNewScreePlotFunction
        clsRVariablesPlotFunction = clsNewVariablesPlotFunction
        clsRIndividualsPlotFunction = clsNewIndividualsPlotFunction
        clsRBiplotFunction = clsNewBiplotFunction
        clsRBarPlotFunction = clsNewBarPlotFunction
        clsRFactor = clsNewRFactor
        clsBaseOperator = clsNewBaseOperator
        clsRThemeMinimal = clsNewRThemeMinimal
        clsRVariablesPlotFunctionValue = clsNewVariablesPlotFunctionValue
        clsRIndividualsPlotFunctionValue = clsNewIndividualsPlotFunctionValue
        clsRBiplotFunctionValue = clsNewBiplotFunctionValue
        ucrInputLabel2.AddAdditionalCodeParameterPair(clsRIndividualsPlotFunction, New RParameter("label"), iAdditionalPairNo:=1)
        ucrInputLabel2.AddAdditionalCodeParameterPair(clsRBiplotFunction, New RParameter("label"), iAdditionalPairNo:=2)
        ucrNudDim1.AddAdditionalCodeParameterPair(clsRVariablesPlotFunctionValue, ucrNudDim1.GetParameter(), iAdditionalPairNo:=1)
        ucrNudDim1.AddAdditionalCodeParameterPair(clsRBiplotFunctionValue, ucrNudDim1.GetParameter(), iAdditionalPairNo:=2)
        ucrNudDim2.AddAdditionalCodeParameterPair(clsRVariablesPlotFunctionValue, ucrNudDim2.GetParameter(), iAdditionalPairNo:=1)
        ucrNudDim2.AddAdditionalCodeParameterPair(clsRBiplotFunctionValue, ucrNudDim2.GetParameter(), iAdditionalPairNo:=2)
        ucrPnlIndividualPlot.AddAdditionalCodeParameterPair(clsRBiplotFunction, New RParameter("geom"), iAdditionalPairNo:=1)

        ucrPnlVariablesPlot.SetRCode(clsRVariablesPlotFunction, bReset, bCloneIfNeeded:=True)
        ucrPnlIndividualPlot.SetRCode(clsRIndividualsPlotFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLabel1.SetRCode(clsRScreePlotFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLabel2.SetRCode(clsRVariablesPlotFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverFactor.SetRCode(clsRFactor, bReset, bCloneIfNeeded:=True)
        ucrChkIncludePercentage.SetRCode(clsRScreePlotFunction, bReset, bCloneIfNeeded:=True)
        ucrChkEigenvalues.SetRCode(clsREigenValues, bReset, bCloneIfNeeded:=True)
        ucrChkEigenvectors.SetRCode(clsREigenVectors, bReset, bCloneIfNeeded:=True)
        ucrChkRotation.SetRCode(clsRRotation, bReset, bCloneIfNeeded:=True)
        ucrPnlGraphics.SetRCode(clsBaseOperator, bReset)
        ucrPnlScreePlot.SetRCode(clsRScreePlotFunction, bReset, bCloneIfNeeded:=True)
        ucrNudDim1.SetRCode(clsRIndividualsPlotFunctionValue, bReset, bCloneIfNeeded:=True)
        ucrNudDim2.SetRCode(clsRIndividualsPlotFunctionValue, bReset, bCloneIfNeeded:=True)
        Visibility()
        Dimensions()
        If bReset Then
            tbRegOptions.SelectedIndex = 0
        End If
    End Sub

    Private Sub ucrChkEigenvalues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEigenvalues.ControlValueChanged
        If ucrChkEigenvalues.Checked Then
            clsRsyntax.AddToAfterCodes(clsREigenValues, iPosition:=1)
        Else
            clsRsyntax.RemoveFromAfterCodes(clsREigenValues)
        End If
    End Sub

    Private Sub ucrChkEigenvectors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEigenvectors.ControlValueChanged
        If ucrChkEigenvectors.Checked Then
            clsRsyntax.AddToAfterCodes(clsREigenVectors, iPosition:=2)
        Else
            clsRsyntax.RemoveFromAfterCodes(clsREigenVectors)
        End If
    End Sub

    Private Sub ucrChkRotation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRotation.ControlValueChanged
        If ucrChkRotation.Checked Then
            clsRsyntax.AddToAfterCodes(clsRRotation, iPosition:=3)
        Else
            clsRsyntax.RemoveFromAfterCodes(clsRRotation)
        End If
    End Sub

    'This is here because when you reopen the subdialog the groupboxes are not visible.Don't know why linking isn't working on reopen.
    Private Sub Visibility()
        If rdoScreePlot.Checked Then
            grpGeom.Visible = True
        ElseIf rdoVariablesPlot.Checked Then
            grpVariablePlot.Visible = True
        ElseIf rdoIndividualsPlot.Checked OrElse rdoBiplot.Checked Then
            GrpIndividualPlot.Visible = True
        End If
    End Sub

    Private Sub ucrPnlGraphics_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGraphics.ControlValueChanged
        If rdoScreePlot.Checked Then
            clsBaseOperator.AddParameter("plot", clsRFunctionParameter:=clsRScreePlotFunction, iPosition:=0)
        ElseIf rdoVariablesPlot.Checked Then
            clsBaseOperator.AddParameter("plot", clsRFunctionParameter:=clsRVariablesPlotFunction, iPosition:=0)
        ElseIf rdoIndividualsPlot.Checked Then
            clsBaseOperator.AddParameter("plot", clsRFunctionParameter:=clsRIndividualsPlotFunction, iPosition:=0)
        ElseIf rdoBiplot.Checked Then
            clsBaseOperator.AddParameter("plot", clsRFunctionParameter:=clsRBiplotFunction, iPosition:=0)
        ElseIf rdoBarPlot.Checked Then
            clsBaseOperator.AddParameter("plot", clsRFunctionParameter:=clsRBarPlotFunction, iPosition:=0)
        End If
    End Sub

    ' Here, the minimum and maximum dimensions selected rely on a few things
    Public Sub Dimensions()
        ' Now, if the receiver is empty or has one variable in it then the value for the second dimension is two
        If dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.IsEmpty OrElse dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count = 1 Then
            ucrNudDim2.Value = 2
            ' If the receiver is has more than two variables, then the maximum dimension allowed depends on a few things
        ElseIf dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count > 1 Then
            ' Firstly, if the row length is shorter than the number of columns, and then if the row length is shorter than the components value selected in the main dialog, the data frame length maximum can only be as much as the row length minus one
            ' otherwise, if the row length is larger than the number of components, then the maximum dimensions can only be as much as the component value selected in the main dialog.
            If dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.iDataFrameLength <= dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count Then
                If dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.iDataFrameLength <= dlgPrincipalComponentAnalysis.ucrNudNumberOfComp.Value Then
                    ucrNudDim1.Maximum = dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.iDataFrameLength - 1
                    ucrNudDim2.Maximum = dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.iDataFrameLength - 1
                Else
                    ucrNudDim1.Maximum = dlgPrincipalComponentAnalysis.ucrNudNumberOfComp.Value
                    ucrNudDim2.Maximum = dlgPrincipalComponentAnalysis.ucrNudNumberOfComp.Value
                End If
            Else
                ' Firstly, if the column length is shorter than the number of rows, and then if the column length is shorter than the components value selected in the main dialog, the data frame length maximum can only be as much as the column length
                ' otherwise, if the column length is larger than the number of components, then the maximum dimensions selected can only be as much as the component value selected in the main dialog.
                If dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count <= dlgPrincipalComponentAnalysis.ucrNudNumberOfComp.Value Then
                    ucrNudDim1.Maximum = dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count
                    ucrNudDim2.Maximum = dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count
                Else
                    ucrNudDim1.Maximum = dlgPrincipalComponentAnalysis.ucrNudNumberOfComp.Value
                    ucrNudDim2.Maximum = dlgPrincipalComponentAnalysis.ucrNudNumberOfComp.Value
                End If
            End If
        End If
    End Sub

End Class