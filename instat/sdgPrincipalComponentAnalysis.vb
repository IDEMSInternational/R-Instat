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
Public Class sdgPrincipalComponentAnalysis
    Private bControlsInitialised As Boolean = False
    Private clsREigenValues, clsREigenVectors, clsRRotation As New RFunction
    Public bFirstLoad As Boolean = True

    ' to do:
    Public clsRScores, clsPCAModel, clsRVariablesPlotFunction, clsRVariablesPlotTheme, clsRCoord, clsRContrib, clsREig, clsRFactor, clsRMelt As New RFunction
    Public clsRScreePlotFunction, clsRScreePlotTheme, clsRIndividualsPlotFunction, clsRIndividualsPlotTheme, clsRBiplotFunction, clsRBiplotTheme, clsRBarPlotFunction, clsRBarPlotGeom, clsRBarPlotFacet, clsRBarPlotAes As New RFunction
    'Public clsRScreePlot, clsRVariablesPlot, clsRIndividualsPlot, clsRBiplot As New RSyntax
    Private clsRsyntax As RSyntax
    Dim clsRBarPlot, clsRBarPlot0 As New ROperator

    Private Sub sdgPrincipalComponentAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        Dim dctLabelOptionsChoice As New Dictionary(Of String, String)
        Dim dctOptionsForLabel As New Dictionary(Of String, String)

        ucrChkEigenvalues.AddRSyntaxContainsFunctionNamesCondition(True, {frmMain.clsRLink.strInstatDataObject & "$get_from_model"})
        ucrChkEigenvalues.SetParameter(New RParameter("value1", 2))
        ucrChkEigenvalues.SetText("Eigenvalues")
        ucrChkEigenvalues.SetValueIfChecked(Chr(34) & "eig" & Chr(34))

        ucrChkEigenvectors.AddRSyntaxContainsFunctionNamesCondition(True, {frmMain.clsRLink.strInstatDataObject & "$get_from_model"})
        ucrChkEigenvectors.SetParameter(New RParameter("value1", 2))
        ucrChkEigenvectors.SetText("Eigenvectors")
        ucrChkEigenvectors.SetValueIfChecked(Chr(34) & "ind" & Chr(34))

        ucrChkRotation.AddRSyntaxContainsFunctionNamesCondition(True, {frmMain.clsRLink.strInstatDataObject & "$get_from_model"})
        ucrChkRotation.SetParameter(New RParameter("MARGIN", 1))
        ucrChkRotation.SetText("Rotation")
        ucrChkRotation.SetValueIfChecked(2)

        ucrNudDim.SetMinMax(1, 2)
        ucrNudDim2.SetMinMax(1, 2)

        ucrPnlGraphics.AddRadioButton(rdoNoPlot)
        ucrPnlGraphics.AddRadioButton(rdoScreePlot)
        ucrPnlGraphics.AddRadioButton(rdoVariablesPlot)
        ucrPnlGraphics.AddRadioButton(rdoIndividualsPlot)
        ucrPnlGraphics.AddRadioButton(rdoBiplot)
        ucrPnlGraphics.AddRadioButton(rdoBarPlot)

        ucrPnlGraphics.AddRSyntaxContainsFunctionNamesCondition(rdoScreePlot, {"fviz_screeplot"}) ' need to link these rdos with their class. This will be like "Add additional base function"
        ucrPnlGraphics.AddRSyntaxContainsFunctionNamesCondition(rdoVariablesPlot, {"fviz_pca_var"})
        ucrPnlGraphics.AddRSyntaxContainsFunctionNamesCondition(rdoIndividualsPlot, {"fviz_pca_ind"})
        ucrPnlGraphics.AddRSyntaxContainsFunctionNamesCondition(rdoBiplot, {"fviz_pca_biplot"})
        ucrPnlGraphics.AddRSyntaxContainsFunctionNamesCondition(rdoBarPlot, {"ggplot"})
        ucrPnlGraphics.AddRSyntaxContainsFunctionNamesCondition(rdoNoPlot, {"fviz_screeplot", "fviz_pca_var", "fviz_pca_ind", "fviz_pca_biplot", "ggplot"}, False)

        ucrPnlScreePlot.AddRadioButton(rdoBar)
        ucrPnlScreePlot.AddRadioButton(rdoLine)
        ucrPnlScreePlot.AddRadioButton(rdoBothScree)

        ucrPnlScreePlot.SetParameter(New RParameter("geom"))
        ucrPnlScreePlot.AddRadioButton(rdoBar, Chr(34) & "bar" & Chr(34))
        ucrPnlScreePlot.AddRadioButton(rdoLine, Chr(34) & "line" & Chr(34))
        ucrPnlScreePlot.AddRadioButton(rdoBothScree, "c(" & Chr(34) & "bar" & Chr(34) & "," & Chr(34) & "line" & Chr(34) & ")")

        ucrPnlScreePlot.AddParameterPresentCondition(rdoBar, Chr(34) & "bar" & Chr(34))
        ucrPnlScreePlot.AddParameterPresentCondition(rdoLine, Chr(34) & "line" & Chr(34))
        ucrPnlScreePlot.AddParameterPresentCondition(rdoBothScree, "c(" & Chr(34) & "bar" & Chr(34) & "," & Chr(34) & "line" & Chr(34) & ")")


        ucrPnlVariablesPlot.AddRadioButton(rdoArrow)
        ucrPnlVariablesPlot.AddRadioButton(rdoTextVariable)
        ucrPnlVariablesPlot.AddRadioButton(rdoBothVariables)

        ucrPnlVariablesPlot.SetParameter(New RParameter("geom"))
        ucrPnlVariablesPlot.AddRadioButton(rdoArrow, Chr(34) & "arrow" & Chr(34))
        ucrPnlVariablesPlot.AddRadioButton(rdoTextVariable, Chr(34) & "text" & Chr(34))
        ucrPnlVariablesPlot.AddRadioButton(rdoBothVariables, "c(" & Chr(34) & "arrow" & Chr(34) & "," & Chr(34) & "text" & Chr(34) & ")")

        ucrPnlIndividualPlot.AddRadioButton(rdoPoint)
        ucrPnlIndividualPlot.AddRadioButton(rdoTextIndividual)
        ucrPnlIndividualPlot.AddRadioButton(rdoBothIndividual)

        ucrPnlIndividualPlot.SetParameter(New RParameter("geom"))
        ucrPnlIndividualPlot.AddRadioButton(rdoPoint, Chr(34) & "point" & Chr(34))
        ucrPnlIndividualPlot.AddRadioButton(rdoTextIndividual, Chr(34) & "text" & Chr(34))
        ucrPnlIndividualPlot.AddRadioButton(rdoBothIndividual, "c(" & Chr(34) & "point" & Chr(34) & "," & Chr(34) & "text" & Chr(34) & ")")

        ucrChkIncludePercentage.SetParameter(New RParameter("addlabels"))
        ucrChkIncludePercentage.SetText("Include Percentages")
        ucrChkIncludePercentage.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkIncludePercentage.SetRDefault("FALSE")

        ucrPnlGraphics.AddToLinkedControls(ucrPnlScreePlot, {rdoScreePlot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoBothScree)
        ucrPnlGraphics.AddToLinkedControls(ucrPnlVariablesPlot, {rdoVariablesPlot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoBothVariables)
        ucrPnlGraphics.AddToLinkedControls(ucrPnlIndividualPlot, {rdoIndividualsPlot, rdoBiplot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoBothIndividual)

        ucrInputLabel1.SetParameter(New RParameter("choice"))
        dctLabelOptionsChoice.Add("Variance", Chr(34) & "variance" & Chr(34))
        dctLabelOptionsChoice.Add("Eigenvalue", Chr(34) & "eigenvalue" & Chr(34))
        ' our default is variance. not sure r-default. check.
        ucrInputLabel1.SetDropDownStyleAsNonEditable()
        ucrInputLabel1.SetItems(dctLabelOptionsChoice)

        ucrInputLabel2.SetParameter(New RParameter("label"))
        dctOptionsForLabel.Add("All", Chr(34) & "all" & Chr(34))
        dctOptionsForLabel.Add("Individuals", Chr(34) & "ind" & Chr(34))
        dctOptionsForLabel.Add("Supplementary Individuals", Chr(34) & "ind.sup" & Chr(34))
        dctOptionsForLabel.Add("Qualitative Supplementary Variables", Chr(34) & "quali" & Chr(34))
        dctOptionsForLabel.Add("Quantitative Supplementary Variables", Chr(34) & "quanti.sup" & Chr(34))
        dctOptionsForLabel.Add("Variables", Chr(34) & "var" & Chr(34))
        dctOptionsForLabel.Add("None", Chr(34) & "none" & Chr(34))
        ucrInputLabel2.SetItems(dctOptionsForLabel)
        ucrInputLabel2.SetRDefault("all")
        ucrInputLabel2.SetDropDownStyleAsNonEditable()

        ucrReceiverFactor.SetParameter(New RParameter("factor_col"))
        ucrReceiverFactor.SetParameterIsRFunction()
        ucrReceiverFactor.Selector = ucrSelectorFactor
        ucrReceiverFactor.SetDataType("factor")
        ucrReceiverFactor.SetMeAsReceiver()

        ucrPnlGraphics.AddToLinkedControls(ucrInputLabel2, {rdoVariablesPlot, rdoIndividualsPlot, rdoBiplot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="all")
        ucrInputLabel2.SetLinkedDisplayControl(lblLabel)
        ucrPnlGraphics.AddToLinkedControls(ucrPnlScreePlot, {rdoScreePlot, rdoVariablesPlot, rdoIndividualsPlot, rdoBiplot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoBothScree)
        ucrPnlScreePlot.SetLinkedDisplayControl(grpGeom)

        ucrPnlGraphics.AddToLinkedControls(ucrInputLabel1, {rdoScreePlot, rdoVariablesPlot, rdoIndividualsPlot, rdoBiplot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Variance")
        ucrInputLabel1.SetLinkedDisplayControl(lblChoice)

        ucrPnlGraphics.AddToLinkedControls(ucrChkIncludePercentage, {rdoScreePlot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrPnlGraphics.AddToLinkedControls(ucrNudDim, {rdoVariablesPlot, rdoIndividualsPlot, rdoBiplot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlGraphics.AddToLinkedControls(ucrNudDim2, {rdoVariablesPlot, rdoIndividualsPlot, rdoBiplot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrNudDim.SetLinkedDisplayControl(lblDim)

        ucrPnlGraphics.AddToLinkedControls(ucrSelectorFactor, {rdoBarPlot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoNoPlot)
        ucrPnlGraphics.AddToLinkedControls(ucrReceiverFactor, {rdoBarPlot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrReceiverFactor.SetLinkedDisplayControl(lblFactorVariable)
        bControlsInitialised = True

        'TODO: disabled for now because it has bugs
        rdoBarPlot.Enabled = False
    End Sub

    Public Sub SetRFunction(clsNewRsyntax As RSyntax, clsNewREigenValues As RFunction, clsNewREigenVectors As RFunction, clsNewRRotation As RFunction, clsNewScreePlotFunction As RFunction, clsNewVariablesPlotFunction As RFunction, clsNewIndividualsPlotFunction As RFunction, clsNewBiplotFunction As RFunction, clsNewBarPlotFunction As RFunction, Optional bReset As Boolean = False)
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
        clsRFactor = clsNewBarPlotFunction

        'ucrPnlScreePlot.AddAdditionalCodeParameterPair(clsRVariablesPlotFunction, clsNewRParameter:=New RParameter("Geom"), iAdditionalPairNo:=1)
        'ucrPnlScreePlot.AddAdditionalCodeParameterPair(clsRIndividualsPlotFunction, clsNewRParameter:=New RParameter("Geom"), iAdditionalPairNo:=2)
        'ucrPnlScreePlot.AddAdditionalCodeParameterPair(clsRBiplotFunction, clsNewRParameter:=New RParameter("Geom"), iAdditionalPairNo:=3)
        ucrPnlScreePlot.SetRCode(clsRScreePlotFunction, bReset)
        ucrPnlVariablesPlot.SetRCode(clsRVariablesPlotFunction, bReset)
        ucrPnlIndividualPlot.SetRCode(clsRVariablesPlotTheme, bReset)

        'ucrInputLabel2.AddAdditionalCodeParameterPair(clsRVariablesPlotFunction, New RParameter("label"), iAdditionalPairNo:=1)
        'ucrInputLabel2.AddAdditionalCodeParameterPair(clsRIndividualsPlotFunction, New RParameter("label"), iAdditionalPairNo:=2)
        'ucrInputLabel2.AddAdditionalCodeParameterPair(clsRBiplotFunction, New RParameter("label"), iAdditionalPairNo:=3)

        ucrInputLabel1.SetRCode(clsRScreePlotFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLabel2.SetRCode(clsRVariablesPlotFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverFactor.SetRCode(clsRFactor, bReset, bCloneIfNeeded:=True)
        ucrChkIncludePercentage.SetRSyntax(clsRsyntax, bReset)
        ucrChkEigenvalues.SetRSyntax(clsRsyntax, bReset)
        ucrChkEigenvectors.SetRSyntax(clsRsyntax, bReset)
        ucrChkRotation.SetRSyntax(clsRsyntax, bReset)
        ucrPnlGraphics.SetRSyntax(clsRsyntax, bReset)
    End Sub

    Private Sub ucrChkEigenvalues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEigenvalues.ControlValueChanged
        clsRsyntax.AddToAfterCodes(clsREigenValues, iPosition:=1)
        clsREigenValues.iCallType = 2
    End Sub

    Private Sub ucrChkEigenvectors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEigenvectors.ControlValueChanged
        clsRsyntax.AddToAfterCodes(clsREigenVectors, iPosition:=2)
        clsREigenVectors.iCallType = 2
    End Sub

    Private Sub ucrChkRotation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRotation.ControlValueChanged
        clsRsyntax.AddToAfterCodes(clsRRotation, iPosition:=3)
        clsRRotation.iCallType = 2
    End Sub

    Private Sub ucrPnlGraphics_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGraphics.ControlValueChanged
        If rdoScreePlot.Checked Then
            clsRsyntax.AddToAfterCodes(clsRScreePlotFunction, iPosition:=4)
        ElseIf rdoVariablesPlot.Checked Then
            clsRsyntax.AddToAfterCodes(clsRVariablesPlotFunction, iPosition:=5)
        ElseIf rdoIndividualsPlot.Checked Then
            clsRsyntax.AddToAfterCodes(clsRIndividualsPlotFunction, iPosition:=6)
        ElseIf rdoBiplot.Checked Then
            clsRsyntax.AddToAfterCodes(clsRBiplotFunction, iPosition:=6)
        ElseIf rdoBarPlot.Checked Then
            clsRsyntax.AddToAfterCodes(clsRBarPlot, iPosition:=6)
        ElseIf rdoNoPlot.Checked Then
            clsRsyntax.RemoveFromAfterCodes(clsRScreePlotFunction)
            clsRsyntax.RemoveFromAfterCodes(clsRVariablesPlotFunction)
            clsRsyntax.RemoveFromAfterCodes(clsRIndividualsPlotFunction)
            clsRsyntax.RemoveFromAfterCodes(clsRBiplotFunction)
            clsRsyntax.RemoveFromAfterCodes(clsRBarPlot)
        End If
    End Sub

    Private Sub InitialiseDialog()
        'ucrNudDim.Minimum = 1
        'ucrNudDim2.Minimum = 1
    End Sub

    Public Sub SetDefaults()
        'ucrSelectorFactor.Focus()
        'ucrChkIncludePercentage.Checked = False
        'rdoScreePlot.Checked = True
        'ucrNudDim.Value = 1
        'ucrNudDim2.Value = 2
        'rdoBoth.Checked = True
        'Dimensions()
        'DisplayOptions()
        'ucrSelectorFactor.Reset()
    End Sub

    'When to run the various options in the "Display" tab and "Graphics" tab

    Public Sub PCAOptions()
        'If rdoIndividualsPlot.Checked Then
        '    IndividualsPlot()
        'End If
        'If rdoVariablesPlot.Checked Then
        '    VariablesPlot()
        'End If
        'If rdoBiplot.Checked Then
        '    Biplot()
        'End If
        'If rdoBarPlot.Checked Then
        '    Barplot()
        '    frmMain.clsRLink.RunScript(clsRBarPlot.ToScript, 3)
        'End If
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
                    ucrNudDim.Maximum = dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.iDataFrameLength - 1
                    ucrNudDim2.Maximum = dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.iDataFrameLength - 1
                Else
                    ucrNudDim.Maximum = dlgPrincipalComponentAnalysis.ucrNudNumberOfComp.Value
                    ucrNudDim2.Maximum = dlgPrincipalComponentAnalysis.ucrNudNumberOfComp.Value
                End If
            Else
                ' Firstly, if the column length is shorter than the number of rows, and then if the column length is shorter than the components value selected in the main dialog, the data frame length maximum can only be as much as the column length
                ' otherwise, if the column length is larger than the number of components, then the maximum dimensions selected can only be as much as the component value selected in the main dialog.
                If dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count <= dlgPrincipalComponentAnalysis.ucrNudNumberOfComp.Value Then
                    ucrNudDim.Maximum = dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count
                    ucrNudDim2.Maximum = dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count
                Else
                    ucrNudDim.Maximum = dlgPrincipalComponentAnalysis.ucrNudNumberOfComp.Value
                    ucrNudDim2.Maximum = dlgPrincipalComponentAnalysis.ucrNudNumberOfComp.Value
                End If
            End If
        End If
    End Sub

    ' In the "Graphics" tab, the groupbox regarding plot options changes depending what graph is chosen.
    ' Additionally, some label names change depending which is selected. This sub is about these changes.
    Private Sub DisplayOptions()
        'Dim dctOptionsForLabel As Dictionary(Of String, String)
        If rdoScreePlot.Checked Then
            'lblChoiceScree.Text = "Choice:  "
            'rdoOne.Text = "Bar"
            'rdoTwo.Text = "Line"
            'ucrLabel.SetItems({"variance", "eigenvalue"})
            'ucrLabel.SetName("variance")
            'dctOptionsForLabel.Add("Variance", Chr(34) & "variance" & Chr(34))
            'dctOptionsForLabel.Add("Eigenvalue", Chr(34) & "eigenvalue" & Chr(34))
            'ucrLabel.SetItems(dctOptionsForLabel)
        Else
            'dctOptionsForLabel.Add("All", Chr(34) & "all" & Chr(34))
            'dctOptionsForLabel.Add("Individuals", Chr(34) & "ind" & Chr(34))
            'dctOptionsForLabel.Add("Supplementary Individuals", Chr(34) & "ind.sup" & Chr(34))
            'dctOptionsForLabel.Add("Qualitative Supplementary Variables", Chr(34) & "quali" & Chr(34))
            'dctOptionsForLabel.Add("Quantitative Supplementary Variables", Chr(34) & "quanti.sup" & Chr(34))
            'dctOptionsForLabel.Add("Variables", Chr(34) & "var" & Chr(34))
            'dctOptionsForLabel.Add("None", Chr(34) & "none" & Chr(34))
            'ucrInputLabel1.SetItems(dctOptionsForLabel)
            ' selected item is ALL

            'ucrLabel.SetItems({"all", "ind.sup", "quali", "quanti.sup", "var", "ind", "none"})
            'lblDim.Visible = True
            'lblChoiceScree.Text = "Label:"
            'rdoTwo.Text = "Text"
            If rdoVariablesPlot.Checked Then
                'rdoOne.Text = "Arrow"
            Else
                'rdoOne.Text = "Point"
            End If
        End If
    End Sub

    Private Sub rdoPlotItems_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBothScree.CheckedChanged, rdoBar.CheckedChanged, rdoLine.CheckedChanged
        'GeomChecked()
    End Sub

    'Public Sub ucrReceiverFactor_SelectionChanged() Handles ucrReceiverFactor.SelectionChanged
    '    Barplot()
    'End Sub

    Private Sub rdoPlots_CheckedChanged(sender As Object, e As EventArgs) Handles rdoScreePlot.CheckedChanged, rdoBarPlot.CheckedChanged, rdoBiplot.CheckedChanged, rdoVariablesPlot.CheckedChanged, rdoIndividualsPlot.CheckedChanged
        ' DisplayOptions()
        'GeomChecked()
    End Sub

    ' One of the options in the "Graphics" tab is what should be plotted on the graph. These options can change depending on which radio button is selected. This sub is about running the correct code for each graphic options
    'Private Sub GeomChecked()
    '    If rdoScreePlot.Checked Then
    '        If rdoBothScree.Checked Then
    '            clsRScreePlotFunction.AddParameter("geom", "c(" & Chr(34) & "bar" & Chr(34) & "," & Chr(34) & "line" & Chr(34) & ")")
    '        ElseIf rdoBar.Checked Then
    '            clsRScreePlotFunction.AddParameter("geom", Chr(34) & "bar" & Chr(34))
    '        ElseIf rdoLine.Checked Then
    '            clsRScreePlotFunction.AddParameter("geom", Chr(34) & "line" & Chr(34))
    '        End If
    '    ElseIf rdoVariablesPlot.Checked Then
    '        If rdoBothScree.Checked Then
    '            clsRVariablesPlotFunction.AddParameter("geom", "c(" & Chr(34) & "arrow" & Chr(34) & "," & Chr(34) & "text" & Chr(34) & ")")
    '        ElseIf rdoBar.Checked Then
    '            clsRVariablesPlotFunction.AddParameter("geom", Chr(34) & "arrow" & Chr(34))
    '        ElseIf rdoLine.Checked Then
    '            clsRVariablesPlotFunction.AddParameter("geom", Chr(34) & "text" & Chr(34))
    '        End If
    '    ElseIf rdoIndividualsPlot.Checked Then
    '        If rdoBothScree.Checked Then
    '            clsRIndividualsPlotFunction.AddParameter("geom", "c(" & Chr(34) & "point" & Chr(34) & "," & Chr(34) & "text" & Chr(34) & ")")
    '        ElseIf rdoBar.Checked Then
    '            clsRIndividualsPlotFunction.AddParameter("geom", Chr(34) & "point" & Chr(34))
    '        ElseIf rdoLine.Checked Then
    '            clsRIndividualsPlotFunction.AddParameter("geom", Chr(34) & "text" & Chr(34))
    '        End If
    '    ElseIf rdoBiplot.Checked Then
    '        If rdoBothScree.Checked Then
    '            clsRBiplotFunction.AddParameter("geom", "c(" & Chr(34) & "point" & Chr(34) & "," & Chr(34) & "text" & Chr(34) & ")")
    '        ElseIf rdoBar.Checked Then
    '            clsRBiplotFunction.AddParameter("geom", Chr(34) & "point" & Chr(34))
    '        ElseIf rdoLine.Checked Then
    '            clsRBiplotFunction.AddParameter("geom", Chr(34) & "text" & Chr(34))
    '        Else
    '            clsRBiplotFunction.RemoveParameterByName("geom")
    '        End If
    '    Else
    '        clsRScreePlotFunction.RemoveParameterByName("geom")
    '    End If
    'End Sub

    'Private Sub VariablesPlot()
    '    clsRVariablesPlotFunction.AddParameter("axes", "c(" & ucrNudDim.Value & "," & ucrNudDim2.Value & ")")
    '    frmMain.clsRLink.RunScript(clsRVariablesPlot.GetScript(), 3)
    'End Sub

    ''Code for running Individuals Plot if it is selected in the "Graphics" tab
    'Private Sub IndividualsPlot()
    '    clsRIndividualsPlotFunction.AddParameter("axes", "c(" & ucrNudDim.Value & "," & ucrNudDim2.Value & ")")
    '    frmMain.clsRLink.RunScript(clsRIndividualsPlot.GetScript(), 3)
    'End Sub

    ''Code for running Biplot if it is selected in the "Graphics" tab
    'Private Sub Biplot()
    '    clsRBiplotFunction.AddParameter("axes", "c(" & ucrNudDim.Value & "," & ucrNudDim2.Value & ")")
    '    frmMain.clsRLink.RunScript(clsRBiplot.GetScript(), 3)
    'End Sub

    ''Code for running Barplot if it is selected in the "Graphics" tab
    'Private Sub Barplot()
    '    clsRBarPlot0.SetOperation("+")
    '    clsRBarPlot.SetOperation("+")
    '    clsRFactor.SetRCommand("cbind")
    '    clsRMelt.SetRCommand("melt")
    '    clsRMelt.AddParameter("", clsRFunctionParameter:=clsREigenVectors)
    '    clsRFactor.AddParameter("", clsRFunctionParameter:=clsRMelt)
    '    clsRBarPlotFunction.SetRCommand("ggplot")
    '    clsRBarPlotFunction.AddParameter("data", clsRFunctionParameter:=clsRFactor)
    '    clsRBarPlotGeom.SetRCommand("geom_bar")
    '    clsRBarPlotAes.SetRCommand("aes")
    '    clsRBarPlotAes.AddParameter("x", "Var1")
    '    clsRBarPlotAes.AddParameter("y", "value")
    '    clsRBarPlotAes.AddParameter("fill", "factor_col")
    '    clsRBarPlotGeom.AddParameter("", clsRFunctionParameter:=clsRBarPlotAes)
    '    clsRBarPlotGeom.AddParameter("stat", Chr(34) & "identity" & Chr(34))
    '    clsRBarPlotFacet.SetRCommand("facet_wrap")
    '    clsRBarPlotFacet.AddParameter("", "~Var2")
    '    clsRBarPlot0.AddParameter(iPosition:=0, clsRFunctionParameter:=clsRBarPlotFunction)
    '    clsRBarPlot0.AddParameter(clsRFunctionParameter:=clsRBarPlotGeom)
    '    clsRBarPlot.AddParameter(iPosition:=0, clsROperatorParameter:=clsRBarPlot0)
    '    clsRBarPlot.AddParameter(clsRFunctionParameter:=clsRBarPlotFacet)
    'End Sub

    'Private Sub Rotation()
    '    clsRRotation.SetRCommand("sweep")
    '    clsRCoord.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
    '    clsRCoord.AddParameter("data_name", Chr(34) & dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    '    clsRCoord.AddParameter("model_name", Chr(34) & dlgPrincipalComponentAnalysis.strModelName & Chr(34))
    '    clsRCoord.AddParameter("value1", Chr(34) & "var" & Chr(34))
    '    clsRCoord.AddParameter("value2", Chr(34) & "coord" & Chr(34))
    '    clsREig.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
    '    clsREig.AddParameter("data_name", Chr(34) & dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    '    clsREig.AddParameter("model_name", Chr(34) & dlgPrincipalComponentAnalysis.strModelName & Chr(34))
    '    clsREig.AddParameter("value1", Chr(34) & "eig" & Chr(34))
    '    clsRRotation.AddParameter("x", clsRFunctionParameter:=clsRCoord)
    '    clsRRotation.AddParameter("MARGIN", 2)
    '    clsRRotation.AddParameter("STATS", "sqrt(" & clsREig.ToScript.ToString & "[,1])")
    '    clsRRotation.AddParameter("FUN", " '/'")
    '    frmMain.clsRLink.RunScript(clsRRotation.ToScript(), 2)
    'End Sub
End Class